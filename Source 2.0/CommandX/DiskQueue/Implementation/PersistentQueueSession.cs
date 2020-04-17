using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace DiskQueue.Implementation
{
	// Token: 0x02000013 RID: 19
	public sealed class PersistentQueueSession : IDisposable, IPersistentQueueSession
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00056E18 File Offset: 0x00055018
		public PersistentQueueSession(IPersistentQueueImpl queue, Stream currentStream, int writeBufferSize)
		{
			lock (PersistentQueueSession._ctorLock)
			{
				this.queue = queue;
				this.currentStream = currentStream;
				if (writeBufferSize < 65536)
				{
					writeBufferSize = 65536;
				}
				this.writeBufferSize = writeBufferSize;
				this.disposed = false;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004BF3 File Offset: 0x00002DF3
		public void Enqueue(byte[] data)
		{
			this.buffer.Add(data);
			this.bufferSize += data.Length;
			if (this.bufferSize > this.writeBufferSize)
			{
				this.AsyncFlushBuffer();
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00004C2A File Offset: 0x00002E2A
		private void AsyncFlushBuffer()
		{
			this.queue.AcquireWriter(this.currentStream, new Func<Stream, long>(this.AsyncWriteToStream), new Action<Stream>(this.OnReplaceStream));
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00004C55 File Offset: 0x00002E55
		private void SyncFlushBuffer()
		{
			this.queue.AcquireWriter(this.currentStream, delegate(Stream stream)
			{
				byte[] array = this.ConcatenateBufferAndAddIndividualOperations(stream);
				stream.Write(array, 0, array.Length);
				return stream.Position;
			}, new Action<Stream>(this.OnReplaceStream));
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00056EC4 File Offset: 0x000550C4
		private long AsyncWriteToStream(Stream stream)
		{
			byte[] array = this.ConcatenateBufferAndAddIndividualOperations(stream);
			ManualResetEvent resetEvent = new ManualResetEvent(false);
			this.pendingWritesHandles.Add(resetEvent);
			long result = stream.Position + (long)array.Length;
			stream.BeginWrite(array, 0, array.Length, delegate(IAsyncResult ar)
			{
				try
				{
					stream.EndWrite(ar);
				}
				catch (Exception item)
				{
					lock (this.pendingWritesFailures)
					{
						this.pendingWritesFailures.Add(item);
					}
				}
				finally
				{
					resetEvent.Set();
				}
			}, null);
			return result;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00056F44 File Offset: 0x00055144
		private byte[] ConcatenateBufferAndAddIndividualOperations(Stream stream)
		{
			byte[] array = new byte[this.bufferSize];
			int num = (int)stream.Position;
			int num2 = 0;
			foreach (byte[] current in this.buffer)
			{
				this.operations.Add(new Operation(OperationType.Enqueue, this.queue.CurrentFileNumber, num, current.Length));
				Buffer.BlockCopy(current, 0, array, num2, current.Length);
				num += current.Length;
				num2 += current.Length;
			}
			this.bufferSize = 0;
			this.buffer.Clear();
			return array;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004C80 File Offset: 0x00002E80
		private void OnReplaceStream(Stream newStream)
		{
			this.streamsToDisposeOnFlush.Add(this.currentStream);
			this.currentStream = newStream;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00056FFC File Offset: 0x000551FC
		public byte[] Dequeue()
		{
			Entry entry = this.queue.Dequeue();
			byte[] result;
			if (entry == null)
			{
				result = null;
			}
			else
			{
				this.operations.Add(new Operation(OperationType.Dequeue, entry.FileNumber, entry.Start, entry.Length));
				result = entry.Data;
			}
			return result;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00057050 File Offset: 0x00055250
		public void Flush()
		{
			try
			{
				this.WaitForPendingWrites();
				this.SyncFlushBuffer();
			}
			finally
			{
				foreach (Stream current in this.streamsToDisposeOnFlush)
				{
					current.Flush();
					current.Dispose();
				}
				this.streamsToDisposeOnFlush.Clear();
			}
			this.currentStream.Flush();
			this.queue.CommitTransaction(this.operations);
			this.operations.Clear();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000570F8 File Offset: 0x000552F8
		private void WaitForPendingWrites()
		{
			while (this.pendingWritesHandles.Count != 0)
			{
				WaitHandle[] array = this.pendingWritesHandles.Take(64).ToArray<WaitHandle>();
				WaitHandle[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					WaitHandle waitHandle = array2[i];
					this.pendingWritesHandles.Remove(waitHandle);
				}
				WaitHandle.WaitAll(array);
				array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					WaitHandle waitHandle = array2[i];
					waitHandle.Close();
				}
				this.AssertNoPendingWritesFailures();
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0005717C File Offset: 0x0005537C
		private void AssertNoPendingWritesFailures()
		{
			lock (this.pendingWritesFailures)
			{
				if (this.pendingWritesFailures.Count != 0)
				{
					Exception[] pendingWritesExceptions = this.pendingWritesFailures.ToArray<Exception>();
					this.pendingWritesFailures.Clear();
					throw new PendingWriteException(pendingWritesExceptions);
				}
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000571EC File Offset: 0x000553EC
		public void Dispose()
		{
			lock (PersistentQueueSession._ctorLock)
			{
				if (this.disposed)
				{
					return;
				}
				this.disposed = true;
				this.queue.Reinstate(this.operations);
				this.operations.Clear();
				foreach (Stream current in this.streamsToDisposeOnFlush)
				{
					current.Dispose();
				}
				this.currentStream.Dispose();
				GC.SuppressFinalize(this);
			}
			Thread.Sleep(0);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000572B8 File Offset: 0x000554B8
		~PersistentQueueSession()
		{
			if (!this.disposed)
			{
				this.Dispose();
			}
		}

		// Token: 0x04000058 RID: 88
		private const int MinSizeThatMakeAsyncWritePractical = 65536;

		// Token: 0x04000059 RID: 89
		private readonly List<Operation> operations = new List<Operation>();

		// Token: 0x0400005A RID: 90
		private readonly IList<Exception> pendingWritesFailures = new List<Exception>();

		// Token: 0x0400005B RID: 91
		private readonly IList<WaitHandle> pendingWritesHandles = new List<WaitHandle>();

		// Token: 0x0400005C RID: 92
		private Stream currentStream;

		// Token: 0x0400005D RID: 93
		private readonly int writeBufferSize;

		// Token: 0x0400005E RID: 94
		private readonly IPersistentQueueImpl queue;

		// Token: 0x0400005F RID: 95
		private readonly List<Stream> streamsToDisposeOnFlush = new List<Stream>();

		// Token: 0x04000060 RID: 96
		private static readonly object _ctorLock = new object();

		// Token: 0x04000061 RID: 97
		private volatile bool disposed;

		// Token: 0x04000062 RID: 98
		private readonly List<byte[]> buffer = new List<byte[]>();

		// Token: 0x04000063 RID: 99
		private int bufferSize;
	}
}

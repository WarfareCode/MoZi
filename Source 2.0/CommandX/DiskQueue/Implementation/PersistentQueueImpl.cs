using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace DiskQueue.Implementation
{
	// Token: 0x0200000E RID: 14
	internal sealed class PersistentQueueImpl : IPersistentQueueImpl, IDisposable
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00004B11 File Offset: 0x00002D11
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00004B19 File Offset: 0x00002D19
		public bool TrimTransactionLogOnDispose
		{
			get;
			set;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00055C48 File Offset: 0x00053E48
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00004B22 File Offset: 0x00002D22
		public int SuggestedReadBuffer
		{
			get;
			set;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00055C60 File Offset: 0x00053E60
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00004B2B File Offset: 0x00002D2B
		public int SuggestedWriteBuffer
		{
			get;
			set;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00055C78 File Offset: 0x00053E78
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00004B34 File Offset: 0x00002D34
		public long SuggestedMaxTransactionLogSize
		{
			get;
			set;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00055C90 File Offset: 0x00053E90
		public PersistentQueueImpl(string path, int maxFileSize)
		{
			lock (PersistentQueueImpl._configLock)
			{
				this.disposed = true;
				this.TrimTransactionLogOnDispose = true;
				this.ParanoidFlushing = true;
				this.SuggestedMaxTransactionLogSize = 33554432L;
				this.SuggestedReadBuffer = 1048576;
				this.SuggestedWriteBuffer = 1048576;
				this.MaxFileSize = maxFileSize;
				try
				{
					this.path = Path.GetFullPath(path);
					if (!Directory.Exists(this.path))
					{
						this.CreateDirectory(this.path);
					}
					this.LockQueue();
				}
				catch (UnauthorizedAccessException)
				{
					throw new UnauthorizedAccessException("Directory \"" + path + "\" does not exist or is missing write permissions");
				}
				catch (IOException innerException)
				{
					GC.SuppressFinalize(this);
					throw new InvalidOperationException("Another instance of the queue is already in action, or directory does not exists", innerException);
				}
				try
				{
					this.ReadMetaState();
					this.ReadTransactionLog();
				}
				catch (Exception)
				{
					GC.SuppressFinalize(this);
					this.UnlockQueue();
					throw;
				}
				this.disposed = false;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00055DF0 File Offset: 0x00053FF0
		private void UnlockQueue()
		{
			if (this.path != null)
			{
				string text = Path.Combine(this.path, "lock");
				if (this.fileLock != null)
				{
					this.fileLock.Dispose();
					File.Delete(text);
				}
				this.fileLock = null;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00055E40 File Offset: 0x00054040
		private void LockQueue()
		{
			string text = Path.Combine(this.path, "lock");
			this.fileLock = new FileStream(text, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004B3D File Offset: 0x00002D3D
		private void CreateDirectory(string s)
		{
			Directory.CreateDirectory(s);
			SetPermissions.TryAllowReadWriteForAll(s);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004B4C File Offset: 0x00002D4C
		public PersistentQueueImpl(string path) : this(path, 33554432)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00055E70 File Offset: 0x00054070
		public int EstimatedCountOfItemsInQueue
		{
			get
			{
				return this.entries.Count + this.checkedOutEntries.Count;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00004B5A File Offset: 0x00002D5A
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00004B62 File Offset: 0x00002D62
		public bool ParanoidFlushing
		{
			get;
			set;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00055E98 File Offset: 0x00054098
		private int CurrentCountOfItemsInQueue
		{
			get
			{
				int result;
				lock (this.entries)
				{
					result = this.entries.Count + this.checkedOutEntries.Count;
				}
				return result;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00055EF0 File Offset: 0x000540F0
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00004B6B File Offset: 0x00002D6B
		public int MaxFileSize
		{
			get;
			private set;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00055F08 File Offset: 0x00054108
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00004B74 File Offset: 0x00002D74
		public long CurrentFilePosition
		{
			get;
			private set;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00055F20 File Offset: 0x00054120
		private string TransactionLog
		{
			get
			{
				return Path.Combine(this.path, "transaction.log");
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00055F40 File Offset: 0x00054140
		private string Meta
		{
			get
			{
				return Path.Combine(this.path, "meta.state");
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00055F60 File Offset: 0x00054160
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00004B7D File Offset: 0x00002D7D
		public int CurrentFileNumber
		{
			get;
			private set;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00055F78 File Offset: 0x00054178
		~PersistentQueueImpl()
		{
			if (!this.disposed)
			{
				this.Dispose();
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00055FB4 File Offset: 0x000541B4
		public void Dispose()
		{
			lock (PersistentQueueImpl._configLock)
			{
				if (!this.disposed)
				{
					try
					{
						this.disposed = true;
						lock (this.transactionLogLock)
						{
							if (this.TrimTransactionLogOnDispose)
							{
								this.FlushTrimmedTransactionLog();
							}
						}
						GC.SuppressFinalize(this);
					}
					finally
					{
						this.UnlockQueue();
					}
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00056060 File Offset: 0x00054260
		public void AcquireWriter(Stream stream, Func<Stream, long> action, Action<Stream> onReplaceStream)
		{
			lock (this.writerLock)
			{
				if (stream.Position != this.CurrentFilePosition)
				{
					stream.Position = this.CurrentFilePosition;
				}
				this.CurrentFilePosition = action(stream);
				if (this.CurrentFilePosition >= (long)this.MaxFileSize)
				{
					this.CurrentFileNumber++;
					FileStream fileStream = this.CreateWriter();
					fileStream.SetLength(this.CurrentFilePosition);
					this.CurrentFilePosition = 0L;
					onReplaceStream(fileStream);
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00056114 File Offset: 0x00054314
		public void CommitTransaction(ICollection<Operation> operations)
		{
			if (operations.Count != 0)
			{
				byte[] array = PersistentQueueImpl.GenerateTransactionBuffer(operations);
				lock (this.transactionLogLock)
				{
					long position;
					using (FileStream fileStream = this.WaitForTransactionLog(array))
					{
						fileStream.Write(array, 0, array.Length);
						position = fileStream.Position;
						fileStream.Flush();
					}
					this.ApplyTransactionOperations(operations);
					this.TrimTransactionLogIfNeeded(position);
					Atomic.Write(this.Meta, delegate(Stream stream)
					{
						byte[] bytes = BitConverter.GetBytes(this.CurrentFileNumber);
						stream.Write(bytes, 0, bytes.Length);
						bytes = BitConverter.GetBytes(this.CurrentFilePosition);
						stream.Write(bytes, 0, bytes.Length);
					});
					if (this.ParanoidFlushing)
					{
						this.FlushTrimmedTransactionLog();
					}
				}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000561EC File Offset: 0x000543EC
		private FileStream WaitForTransactionLog(byte[] transactionBuffer)
		{
			for (int i = 0; i < 10; i++)
			{
				try
				{
					return new FileStream(this.TransactionLog, FileMode.Append, FileAccess.Write, FileShare.None, transactionBuffer.Length, FileOptions.WriteThrough | FileOptions.SequentialScan);
				}
				catch (Exception)
				{
					Thread.Sleep(250);
				}
			}
			throw new TimeoutException("Could not aquire transaction log lock");
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0005624C File Offset: 0x0005444C
		public Entry Dequeue()
		{
			Entry result;
			lock (this.entries)
			{
				LinkedListNode<Entry> first = this.entries.First;
				if (first == null)
				{
					result = null;
				}
				else
				{
					Entry value = first.Value;
					if (value.Data == null)
					{
						this.ReadAhead();
					}
					this.entries.RemoveFirst();
					this.checkedOutEntries.Add(new Entry(value.FileNumber, value.Start, value.Length));
					result = value;
				}
			}
			return result;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000562F4 File Offset: 0x000544F4
		private void ReadAhead()
		{
			long num = 0L;
			Entry value = this.entries.First.Value;
			Entry entry = value;
			foreach (Entry current in this.entries)
			{
				if ((current != entry && (current.FileNumber != entry.FileNumber || current.Start != entry.Start + entry.Length)) || num + (long)current.Length > (long)this.SuggestedReadBuffer)
				{
					break;
				}
				entry = current;
				num += (long)current.Length;
			}
			if (entry == value)
			{
				num = (long)entry.Length;
			}
			byte[] src = this.ReadEntriesFromFile(value, num);
			int num2 = 0;
			foreach (Entry current in this.entries)
			{
				current.Data = new byte[current.Length];
				Buffer.BlockCopy(src, num2, current.Data, 0, current.Length);
				num2 += current.Length;
				if (current == entry)
				{
					break;
				}
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00056460 File Offset: 0x00054660
		private byte[] ReadEntriesFromFile(Entry firstEntry, long currentBufferSize)
		{
			byte[] array = new byte[currentBufferSize];
			using (FileStream fileStream = new FileStream(this.GetDataPath(firstEntry.FileNumber), FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
			{
				fileStream.Position = (long)firstEntry.Start;
				int num = 0;
				while (true)
				{
					int num2 = fileStream.Read(array, num, array.Length - num);
					if (num2 == 0)
					{
						break;
					}
					num += num2;
					if (num >= array.Length)
					{
						goto IL_5C;
					}
				}
				throw new InvalidOperationException("End of file reached while trying to read queue item");
				IL_5C:;
			}
			return array;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000564F0 File Offset: 0x000546F0
		public IPersistentQueueSession OpenSession()
		{
			return new PersistentQueueSession(this, this.CreateWriter(), this.SuggestedWriteBuffer);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00056514 File Offset: 0x00054714
		public void Reinstate(IEnumerable<Operation> reinstatedOperations)
		{
			lock (this.entries)
			{
				this.ApplyTransactionOperations(from entry in reinstatedOperations
				where entry.Type == OperationType.Dequeue
				select new Operation(OperationType.Reinstate, entry.FileNumber, entry.Start, entry.Length));
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0005659C File Offset: 0x0005479C
		private void ReadTransactionLog()
		{
			bool requireTxLogTrimming = false;
			Atomic.Read(this.TransactionLog, delegate(Stream stream)
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					bool readingTransaction = false;
					try
					{
						int num = 0;
						while (true)
						{
							num++;
							PersistentQueueImpl.AssertTransactionSeperator(binaryReader, num, Constants.StartTransactionSeparatorGuid, delegate
							{
								readingTransaction = true;
							});
							int num2 = binaryReader.ReadInt32();
							List<Operation> list = new List<Operation>(num2);
							for (int i = 0; i < num2; i++)
							{
								PersistentQueueImpl.AssertOperationSeparator(binaryReader);
								Operation operation = new Operation((OperationType)binaryReader.ReadByte(), binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
								list.Add(operation);
								if (operation.Type != OperationType.Enqueue)
								{
									requireTxLogTrimming = true;
								}
							}
							PersistentQueueImpl.AssertTransactionSeperator(binaryReader, num, Constants.EndTransactionSeparatorGuid, delegate
							{
							});
							readingTransaction = false;
							this.ApplyTransactionOperations(list);
						}
					}
					catch (EndOfStreamException)
					{
						if (readingTransaction)
						{
							requireTxLogTrimming = true;
						}
					}
				}
			});
			if (requireTxLogTrimming)
			{
				this.FlushTrimmedTransactionLog();
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000565E8 File Offset: 0x000547E8
		private void FlushTrimmedTransactionLog()
		{
			byte[] transactionBuffer;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				memoryStream.Write(Constants.StartTransactionSeparator, 0, Constants.StartTransactionSeparator.Length);
				byte[] bytes = BitConverter.GetBytes(this.EstimatedCountOfItemsInQueue);
				memoryStream.Write(bytes, 0, bytes.Length);
				Entry[] array = this.checkedOutEntries.ToArray<Entry>();
				Entry[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					Entry entry = array2[i];
					PersistentQueueImpl.WriteEntryToTransactionLog(memoryStream, entry, OperationType.Enqueue);
				}
				Entry[] array3 = this.entries.ToArray<Entry>();
				array2 = array3;
				for (int i = 0; i < array2.Length; i++)
				{
					Entry entry = array2[i];
					PersistentQueueImpl.WriteEntryToTransactionLog(memoryStream, entry, OperationType.Enqueue);
				}
				memoryStream.Write(Constants.EndTransactionSeparator, 0, Constants.EndTransactionSeparator.Length);
				memoryStream.Flush();
				transactionBuffer = memoryStream.ToArray();
			}
			Atomic.Write(this.TransactionLog, delegate(Stream stream)
			{
				stream.SetLength((long)transactionBuffer.Length);
				stream.Write(transactionBuffer, 0, transactionBuffer.Length);
			});
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000566F0 File Offset: 0x000548F0
		private static void WriteEntryToTransactionLog(Stream ms, Entry entry, OperationType operationType)
		{
			ms.Write(Constants.OperationSeparatorBytes, 0, Constants.OperationSeparatorBytes.Length);
			ms.WriteByte((byte)operationType);
			byte[] bytes = BitConverter.GetBytes(entry.FileNumber);
			ms.Write(bytes, 0, bytes.Length);
			byte[] bytes2 = BitConverter.GetBytes(entry.Start);
			ms.Write(bytes2, 0, bytes2.Length);
			byte[] bytes3 = BitConverter.GetBytes(entry.Length);
			ms.Write(bytes3, 0, bytes3.Length);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0005675C File Offset: 0x0005495C
		private static void AssertOperationSeparator(BinaryReader reader)
		{
			int num = reader.ReadInt32();
			if (num != Constants.OperationSeparator)
			{
				throw new InvalidOperationException("Unexpected data in transaction log. Expected to get transaction separator but got unknonwn data");
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00056788 File Offset: 0x00054988
		public int[] ApplyTransactionOperationsInMemory(IEnumerable<Operation> operations)
		{
			foreach (Operation current in operations)
			{
				switch (current.Type)
				{
				case OperationType.Enqueue:
				{
					Entry entry = new Entry(current);
					this.entries.AddLast(entry);
					int valueOrDefault = this.countOfItemsPerFile.GetValueOrDefault(entry.FileNumber);
					this.countOfItemsPerFile[entry.FileNumber] = valueOrDefault + 1;
					break;
				}
				case OperationType.Dequeue:
				{
					Entry entry2 = new Entry(current);
					this.checkedOutEntries.Remove(entry2);
					int valueOrDefault2 = this.countOfItemsPerFile.GetValueOrDefault(entry2.FileNumber);
					this.countOfItemsPerFile[entry2.FileNumber] = valueOrDefault2 - 1;
					break;
				}
				case OperationType.Reinstate:
				{
					Entry entry3 = new Entry(current);
					this.entries.AddFirst(entry3);
					this.checkedOutEntries.Remove(entry3);
					break;
				}
				}
			}
			HashSet<int> hashSet = new HashSet<int>(from pair in this.countOfItemsPerFile
			where pair.Value < 1
			select pair.Key);
			foreach (int current2 in hashSet)
			{
				this.countOfItemsPerFile.Remove(current2);
			}
			return hashSet.ToArray<int>();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0005693C File Offset: 0x00054B3C
		private static void AssertTransactionSeperator(BinaryReader binaryReader, int txCount, Guid expectedValue, Action hasData)
		{
			byte[] array = binaryReader.ReadBytes(16);
			if (array.Length == 0)
			{
				throw new EndOfStreamException();
			}
			hasData();
			if (array.Length != 16)
			{
				if (binaryReader.BaseStream.Length == binaryReader.BaseStream.Position)
				{
					throw new EndOfStreamException();
				}
				throw new InvalidOperationException("Unexpected data in transaction log. Expected to get transaction separator but got truncated data. Tx #" + txCount);
			}
			else
			{
				Guid a = new Guid(array);
				if (a != expectedValue)
				{
					throw new InvalidOperationException("Unexpected data in transaction log. Expected to get transaction separator but got unknown data. Tx #" + txCount);
				}
				return;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004B86 File Offset: 0x00002D86
		private void ReadMetaState()
		{
			Atomic.Read(this.Meta, delegate(Stream stream)
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					try
					{
						this.CurrentFileNumber = binaryReader.ReadInt32();
						this.CurrentFilePosition = binaryReader.ReadInt64();
					}
					catch (EndOfStreamException)
					{
					}
				}
			});
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000569D8 File Offset: 0x00054BD8
		private void TrimTransactionLogIfNeeded(long txLogSize)
		{
			if (txLogSize >= this.SuggestedMaxTransactionLogSize)
			{
				long optimalTransactionLogSize = this.GetOptimalTransactionLogSize();
				if (txLogSize >= optimalTransactionLogSize * 2L)
				{
					this.FlushTrimmedTransactionLog();
				}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00056A14 File Offset: 0x00054C14
		private void ApplyTransactionOperations(IEnumerable<Operation> operations)
		{
			int[] array;
			lock (this.entries)
			{
				array = this.ApplyTransactionOperationsInMemory(operations);
			}
			int[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				int num = array2[i];
				if (this.CurrentFileNumber != num)
				{
					File.Delete(this.GetDataPath(num));
				}
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00056A94 File Offset: 0x00054C94
		private static byte[] GenerateTransactionBuffer(ICollection<Operation> operations)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				memoryStream.Write(Constants.StartTransactionSeparator, 0, Constants.StartTransactionSeparator.Length);
				byte[] bytes = BitConverter.GetBytes(operations.Count);
				memoryStream.Write(bytes, 0, bytes.Length);
				foreach (Operation current in operations)
				{
					PersistentQueueImpl.WriteEntryToTransactionLog(memoryStream, new Entry(current), current.Type);
				}
				memoryStream.Write(Constants.EndTransactionSeparator, 0, Constants.EndTransactionSeparator.Length);
				memoryStream.Flush();
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00056B60 File Offset: 0x00054D60
		private FileStream CreateWriter()
		{
			string dataPath = this.GetDataPath(this.CurrentFileNumber);
			FileStream result = new FileStream(dataPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite, 65536, FileOptions.WriteThrough | FileOptions.Asynchronous | FileOptions.SequentialScan);
			SetPermissions.TryAllowReadWriteForAll(dataPath);
			return result;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00056B98 File Offset: 0x00054D98
		public string GetDataPath(int index)
		{
			return Path.Combine(this.path, "data." + index);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00056BC4 File Offset: 0x00054DC4
		private long GetOptimalTransactionLogSize()
		{
			return 20L + (long)(16 * this.CurrentCountOfItemsInQueue);
		}

		// Token: 0x0400003C RID: 60
		private const int _32Megabytes = 33554432;

		// Token: 0x0400003D RID: 61
		private readonly HashSet<Entry> checkedOutEntries = new HashSet<Entry>();

		// Token: 0x0400003E RID: 62
		private readonly Dictionary<int, int> countOfItemsPerFile = new Dictionary<int, int>();

		// Token: 0x0400003F RID: 63
		private readonly LinkedList<Entry> entries = new LinkedList<Entry>();

		// Token: 0x04000040 RID: 64
		private readonly string path;

		// Token: 0x04000041 RID: 65
		private readonly object transactionLogLock = new object();

		// Token: 0x04000042 RID: 66
		private readonly object writerLock = new object();

		// Token: 0x04000043 RID: 67
		private static readonly object _configLock = new object();

		// Token: 0x04000044 RID: 68
		private volatile bool disposed;

		// Token: 0x04000045 RID: 69
		private FileStream fileLock;
	}
}

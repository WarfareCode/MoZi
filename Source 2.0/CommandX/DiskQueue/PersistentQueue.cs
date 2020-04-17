using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using DiskQueue.Implementation;

namespace DiskQueue
{
	// Token: 0x02000016 RID: 22
	public sealed class PersistentQueue : IDisposable, IPersistentQueue
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x000573A8 File Offset: 0x000555A8
		public static IPersistentQueue WaitFor(string storagePath, TimeSpan maxWait)
		{
			Stopwatch stopwatch = new Stopwatch();
			try
			{
				stopwatch.Start();
				do
				{
					try
					{
						return new PersistentQueue(storagePath);
					}
					catch (DirectoryNotFoundException)
					{
						throw new Exception("Target storagePath does not exist or is not accessible");
					}
					catch (PlatformNotSupportedException ex)
					{
						Console.WriteLine(string.Concat(new string[]
						{
							"Blocked by ",
							ex.GetType().Name,
							"; ",
							ex.Message,
							"\r\n\r\n",
							ex.StackTrace
						}));
						throw;
					}
					catch
					{
						Thread.Sleep(50);
					}
				}
				while (stopwatch.Elapsed < maxWait);
			}
			finally
			{
				stopwatch.Stop();
			}
			throw new TimeoutException("Could not aquire a lock in the time specified");
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004CA6 File Offset: 0x00002EA6
		public PersistentQueue(string storagePath)
		{
			this._queue = new PersistentQueueImpl(storagePath);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004CBA File Offset: 0x00002EBA
		public PersistentQueue(string storagePath, int maxSize)
		{
			this._queue = new PersistentQueueImpl(storagePath, maxSize);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0005748C File Offset: 0x0005568C
		public void Dispose()
		{
			PersistentQueueImpl persistentQueueImpl = Interlocked.Exchange<PersistentQueueImpl>(ref this._queue, null);
			if (persistentQueueImpl != null)
			{
				persistentQueueImpl.Dispose();
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000574BC File Offset: 0x000556BC
		~PersistentQueue()
		{
			if (this._queue != null)
			{
				this.Dispose();
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000574F8 File Offset: 0x000556F8
		public IPersistentQueueSession OpenSession()
		{
			if (this._queue == null)
			{
				throw new Exception("This queue has been disposed");
			}
			return this._queue.OpenSession();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0005752C File Offset: 0x0005572C
		public int EstimatedCountOfItemsInQueue
		{
			get
			{
				return this._queue.EstimatedCountOfItemsInQueue;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00057548 File Offset: 0x00055748
		public IPersistentQueueImpl Internals
		{
			get
			{
				return this._queue;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00057560 File Offset: 0x00055760
		public int MaxFileSize
		{
			get
			{
				return this._queue.MaxFileSize;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0005757C File Offset: 0x0005577C
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00004CCF File Offset: 0x00002ECF
		public long SuggestedMaxTransactionLogSize
		{
			get
			{
				return this._queue.SuggestedMaxTransactionLogSize;
			}
			set
			{
				this._queue.SuggestedMaxTransactionLogSize = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00004CDD File Offset: 0x00002EDD
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00004CEA File Offset: 0x00002EEA
		public bool TrimTransactionLogOnDispose
		{
			get
			{
				return this._queue.TrimTransactionLogOnDispose;
			}
			set
			{
				this._queue.TrimTransactionLogOnDispose = value;
			}
		}

		// Token: 0x04000067 RID: 103
		private PersistentQueueImpl _queue;
	}
}

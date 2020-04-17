using System;
using System.Collections.Generic;
using System.IO;
using DiskQueue.Implementation;

namespace DiskQueue
{
	// Token: 0x0200000D RID: 13
	public interface IPersistentQueueImpl : IDisposable
	{
		// Token: 0x06000046 RID: 70
		void AcquireWriter(Stream stream, Func<Stream, long> action, Action<Stream> onReplaceStream);

		// Token: 0x06000047 RID: 71
		void CommitTransaction(ICollection<Operation> operations);

		// Token: 0x06000048 RID: 72
		Entry Dequeue();

		// Token: 0x06000049 RID: 73
		void Reinstate(IEnumerable<Operation> reinstatedOperations);

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004A RID: 74
		int CurrentFileNumber
		{
			get;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004B RID: 75
		// (set) Token: 0x0600004C RID: 76
		bool TrimTransactionLogOnDispose
		{
			get;
			set;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004D RID: 77
		// (set) Token: 0x0600004E RID: 78
		bool ParanoidFlushing
		{
			get;
			set;
		}
	}
}

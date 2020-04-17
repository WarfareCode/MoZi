using System;

namespace DiskQueue
{
	// Token: 0x02000015 RID: 21
	public interface IPersistentQueue : IDisposable
	{
		// Token: 0x060000A1 RID: 161
		IPersistentQueueSession OpenSession();

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A2 RID: 162
		int EstimatedCountOfItemsInQueue
		{
			get;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A3 RID: 163
		IPersistentQueueImpl Internals
		{
			get;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A4 RID: 164
		int MaxFileSize
		{
			get;
		}
	}
}

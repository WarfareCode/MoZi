using System;

namespace DiskQueue.Implementation
{
	// Token: 0x0200000B RID: 11
	public enum OperationType : byte
	{
		// Token: 0x04000038 RID: 56
		Enqueue = 1,
		// Token: 0x04000039 RID: 57
		Dequeue,
		// Token: 0x0400003A RID: 58
		Reinstate
	}
}

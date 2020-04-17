using System;

namespace DiskQueue
{
	// Token: 0x02000012 RID: 18
	public interface IPersistentQueueSession : IDisposable
	{
		// Token: 0x0600008D RID: 141
		void Enqueue(byte[] data);

		// Token: 0x0600008E RID: 142
		byte[] Dequeue();

		// Token: 0x0600008F RID: 143
		void Flush();
	}
}

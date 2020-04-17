using System;

namespace DiskQueue.Implementation
{
	// Token: 0x02000005 RID: 5
	public static class Constants
	{
		// Token: 0x0400000E RID: 14
		public static int OperationSeparator = 1123990689;

		// Token: 0x0400000F RID: 15
		public static byte[] OperationSeparatorBytes = BitConverter.GetBytes(Constants.OperationSeparator);

		// Token: 0x04000010 RID: 16
		public static Guid StartTransactionSeparatorGuid = new Guid("b75bfb12-93bb-42b6-acb1-a897239ea3a5");

		// Token: 0x04000011 RID: 17
		public static byte[] StartTransactionSeparator = Constants.StartTransactionSeparatorGuid.ToByteArray();

		// Token: 0x04000012 RID: 18
		public static Guid EndTransactionSeparatorGuid = new Guid("866c9705-4456-4e9d-b452-3146b3bfa4ce");

		// Token: 0x04000013 RID: 19
		public static byte[] EndTransactionSeparator = Constants.EndTransactionSeparatorGuid.ToByteArray();
	}
}

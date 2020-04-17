using System;

namespace DiskQueue.Implementation
{
	// Token: 0x0200000A RID: 10
	public sealed class Operation
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00004A99 File Offset: 0x00002C99
		public Operation(OperationType type, int fileNumber, int start, int length)
		{
			this.Type = type;
			this.FileNumber = fileNumber;
			this.Start = start;
			this.Length = length;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00055B0C File Offset: 0x00053D0C
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00004ABE File Offset: 0x00002CBE
		public OperationType Type
		{
			get;
			set;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00055B24 File Offset: 0x00053D24
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00004AC7 File Offset: 0x00002CC7
		public int FileNumber
		{
			get;
			set;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00055B3C File Offset: 0x00053D3C
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00004AD0 File Offset: 0x00002CD0
		public int Start
		{
			get;
			set;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00055B54 File Offset: 0x00053D54
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00004AD9 File Offset: 0x00002CD9
		public int Length
		{
			get;
			set;
		}
	}
}

using System;

namespace ns28
{
	// Token: 0x020000FE RID: 254
	public sealed class Class2366
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00067578 File Offset: 0x00065778
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00006FFB File Offset: 0x000051FB
		public string Value
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00067590 File Offset: 0x00065790
		public Enum171 method_0()
		{
			return this.enum171_0;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000675A8 File Offset: 0x000657A8
		public string method_1()
		{
			return this.string_0;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000675C0 File Offset: 0x000657C0
		public string method_2()
		{
			return this.string_2;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00007004 File Offset: 0x00005204
		public void method_3(string string_3)
		{
			this.string_2 = string_3;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000675D8 File Offset: 0x000657D8
		protected internal Class2366(string string_3, string string_4, Enum171 enum171_1, string string_5)
		{
			this.string_0 = string_3;
			this.string_1 = string_4;
			this.enum171_0 = enum171_1;
			this.string_2 = string_5;
		}

		// Token: 0x04000287 RID: 647
		private Enum171 enum171_0 = Enum171.const_2;

		// Token: 0x04000288 RID: 648
		private string string_0 = "";

		// Token: 0x04000289 RID: 649
		private string string_1 = "";

		// Token: 0x0400028A RID: 650
		private string string_2 = null;
	}
}

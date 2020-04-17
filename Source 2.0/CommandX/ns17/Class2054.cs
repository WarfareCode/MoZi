using System;
using ns16;

namespace ns17
{
	// Token: 0x02000710 RID: 1808
	public sealed class Class2054 : Class2050
	{
		// Token: 0x06002D02 RID: 11522 RVA: 0x0000818B File Offset: 0x0000638B
		public Class2054()
		{
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x000187C4 File Offset: 0x000169C4
		public Class2054(string string_1) : base(string_1)
		{
			this.method_1();
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x000187D3 File Offset: 0x000169D3
		public void method_1()
		{
			if (base.Value.Length < this.method_2())
			{
				throw new Exception("Too short");
			}
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x0000945D File Offset: 0x0000765D
		public int method_2()
		{
			return 1;
		}
	}
}

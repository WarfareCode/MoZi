using System;
using ns16;

namespace ns17
{
	// Token: 0x02000702 RID: 1794
	public sealed class Class2051 : Class2050
	{
		// Token: 0x06002CC4 RID: 11460 RVA: 0x0000818B File Offset: 0x0000638B
		public Class2051()
		{
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x00018538 File Offset: 0x00016738
		public Class2051(string string_1) : base(string_1)
		{
			this.method_1();
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x00018547 File Offset: 0x00016747
		public void method_1()
		{
			if (base.Value.Length < this.method_2())
			{
				throw new Exception("Too short");
			}
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x0000945D File Offset: 0x0000765D
		public int method_2()
		{
			return 1;
		}
	}
}

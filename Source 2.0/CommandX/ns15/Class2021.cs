using System;
using ns16;

namespace ns15
{
	// Token: 0x0200065B RID: 1627
	public sealed class Class2021 : Class2020
	{
		// Token: 0x0600297E RID: 10622 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2021()
		{
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x00016B46 File Offset: 0x00014D46
		public Class2021(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x00016B55 File Offset: 0x00014D55
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

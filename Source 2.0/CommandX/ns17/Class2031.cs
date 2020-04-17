using System;
using ns16;

namespace ns17
{
	// Token: 0x020006FC RID: 1788
	public sealed class Class2031 : Class2020
	{
		// Token: 0x06002CA1 RID: 11425 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2031()
		{
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x000183ED File Offset: 0x000165ED
		public Class2031(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x000183FC File Offset: 0x000165FC
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

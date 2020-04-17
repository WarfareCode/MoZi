using System;
using ns16;

namespace ns17
{
	// Token: 0x020006FF RID: 1791
	public sealed class Class2033 : Class2020
	{
		// Token: 0x06002CAD RID: 11437 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2033()
		{
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x0001844D File Offset: 0x0001664D
		public Class2033(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x0001845C File Offset: 0x0001665C
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
			if (base.CompareTo(this.method_3()) > 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x00059F00 File Offset: 0x00058100
		public Class2020 method_3()
		{
			return new Class2020("180");
		}
	}
}

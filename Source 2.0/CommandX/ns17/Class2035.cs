using System;
using ns16;

namespace ns17
{
	// Token: 0x02000704 RID: 1796
	public sealed class Class2035 : Class2020
	{
		// Token: 0x06002CCC RID: 11468 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2035()
		{
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x000185A0 File Offset: 0x000167A0
		public Class2035(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x000185AF File Offset: 0x000167AF
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

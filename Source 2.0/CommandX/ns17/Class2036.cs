using System;
using ns16;

namespace ns17
{
	// Token: 0x02000705 RID: 1797
	public sealed class Class2036 : Class2020
	{
		// Token: 0x06002CD0 RID: 11472 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2036()
		{
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x000185D0 File Offset: 0x000167D0
		public Class2036(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x000185DF File Offset: 0x000167DF
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

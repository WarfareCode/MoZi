using System;
using ns16;

namespace ns17
{
	// Token: 0x02000706 RID: 1798
	public sealed class Class2037 : Class2020
	{
		// Token: 0x06002CD4 RID: 11476 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2037()
		{
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x00018600 File Offset: 0x00016800
		public Class2037(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x0001860F File Offset: 0x0001680F
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

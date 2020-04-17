using System;
using ns16;

namespace ns17
{
	// Token: 0x02000713 RID: 1811
	public sealed class Class2016 : Class2010
	{
		// Token: 0x06002D15 RID: 11541 RVA: 0x000180E5 File Offset: 0x000162E5
		public Class2016()
		{
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x0001885D File Offset: 0x00016A5D
		public Class2016(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x0001886C File Offset: 0x00016A6C
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

		// Token: 0x06002D18 RID: 11544 RVA: 0x0010206C File Offset: 0x0010026C
		public Class2010 method_2()
		{
			return new Class2010("0");
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00102088 File Offset: 0x00100288
		public Class2010 method_3()
		{
			return new Class2010("255");
		}
	}
}

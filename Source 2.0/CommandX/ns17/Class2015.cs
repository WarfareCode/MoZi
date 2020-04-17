using System;
using ns16;

namespace ns17
{
	// Token: 0x02000712 RID: 1810
	public sealed class Class2015 : Class2010
	{
		// Token: 0x06002D10 RID: 11536 RVA: 0x000180E5 File Offset: 0x000162E5
		public Class2015()
		{
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x0001880E File Offset: 0x00016A0E
		public Class2015(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x0001881D File Offset: 0x00016A1D
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

		// Token: 0x06002D13 RID: 11539 RVA: 0x0010206C File Offset: 0x0010026C
		public Class2010 method_2()
		{
			return new Class2010("0");
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00102088 File Offset: 0x00100288
		public Class2010 method_3()
		{
			return new Class2010("255");
		}
	}
}

using System;
using ns16;

namespace ns17
{
	// Token: 0x020006F6 RID: 1782
	public sealed class Class2014 : Class2010
	{
		// Token: 0x06002C80 RID: 11392 RVA: 0x000180E5 File Offset: 0x000162E5
		public Class2014()
		{
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x0001829A File Offset: 0x0001649A
		public Class2014(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x000182A9 File Offset: 0x000164A9
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

		// Token: 0x06002C83 RID: 11395 RVA: 0x0010206C File Offset: 0x0010026C
		public Class2010 method_2()
		{
			return new Class2010("0");
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x00102088 File Offset: 0x00100288
		public Class2010 method_3()
		{
			return new Class2010("255");
		}
	}
}

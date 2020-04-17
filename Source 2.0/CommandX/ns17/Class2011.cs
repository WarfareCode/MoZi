using System;
using ns16;

namespace ns17
{
	// Token: 0x020006EF RID: 1775
	public sealed class Class2011 : Class2010
	{
		// Token: 0x06002C61 RID: 11361 RVA: 0x000180E5 File Offset: 0x000162E5
		public Class2011()
		{
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x000180ED File Offset: 0x000162ED
		public Class2011(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x000180FC File Offset: 0x000162FC
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

		// Token: 0x06002C64 RID: 11364 RVA: 0x0010206C File Offset: 0x0010026C
		public Class2010 method_2()
		{
			return new Class2010("0");
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x00102088 File Offset: 0x00100288
		public Class2010 method_3()
		{
			return new Class2010("255");
		}
	}
}

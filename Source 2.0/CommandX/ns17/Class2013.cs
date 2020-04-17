using System;
using ns16;

namespace ns17
{
	// Token: 0x020006F5 RID: 1781
	public sealed class Class2013 : Class2010
	{
		// Token: 0x06002C7B RID: 11387 RVA: 0x000180E5 File Offset: 0x000162E5
		public Class2013()
		{
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x0001824B File Offset: 0x0001644B
		public Class2013(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x0001825A File Offset: 0x0001645A
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

		// Token: 0x06002C7E RID: 11390 RVA: 0x0010206C File Offset: 0x0010026C
		public Class2010 method_2()
		{
			return new Class2010("0");
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x00102088 File Offset: 0x00100288
		public Class2010 method_3()
		{
			return new Class2010("255");
		}
	}
}

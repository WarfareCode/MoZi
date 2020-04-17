using System;
using ns16;

namespace ns17
{
	// Token: 0x020006F0 RID: 1776
	public sealed class Class2012 : Class2010
	{
		// Token: 0x06002C66 RID: 11366 RVA: 0x000180E5 File Offset: 0x000162E5
		public Class2012()
		{
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x0001813C File Offset: 0x0001633C
		public Class2012(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x0001814B File Offset: 0x0001634B
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

		// Token: 0x06002C69 RID: 11369 RVA: 0x0010206C File Offset: 0x0010026C
		public Class2010 method_2()
		{
			return new Class2010("0");
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x00102088 File Offset: 0x00100288
		public Class2010 method_3()
		{
			return new Class2010("255");
		}
	}
}

using System;
using ns16;

namespace ns20
{
	// Token: 0x02000714 RID: 1812
	public sealed class Class2017 : Class2010
	{
		// Token: 0x06002D1A RID: 11546 RVA: 0x000180E5 File Offset: 0x000162E5
		public Class2017()
		{
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x000188AC File Offset: 0x00016AAC
		public Class2017(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x000188BB File Offset: 0x00016ABB
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

		// Token: 0x06002D1D RID: 11549 RVA: 0x0010206C File Offset: 0x0010026C
		public Class2010 method_2()
		{
			return new Class2010("0");
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x00102088 File Offset: 0x00100288
		public Class2010 method_3()
		{
			return new Class2010("255");
		}
	}
}

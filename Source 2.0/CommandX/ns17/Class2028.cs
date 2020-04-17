using System;
using ns16;

namespace ns17
{
	// Token: 0x020006F7 RID: 1783
	public sealed class Class2028 : Class2020
	{
		// Token: 0x06002C85 RID: 11397 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2028()
		{
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000182E9 File Offset: 0x000164E9
		public Class2028(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x000182F8 File Offset: 0x000164F8
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) <= 0)
			{
				throw new Exception("Out of range");
			}
			if (base.CompareTo(this.method_3()) > 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x00059F00 File Offset: 0x00058100
		public Class2020 method_3()
		{
			return new Class2020("180");
		}
	}
}

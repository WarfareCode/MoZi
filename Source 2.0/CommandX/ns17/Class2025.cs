using System;
using ns16;

namespace ns17
{
	// Token: 0x020006F2 RID: 1778
	public sealed class Class2025 : Class2020
	{
		// Token: 0x06002C6F RID: 11375 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2025()
		{
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x000181BB File Offset: 0x000163BB
		public Class2025(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x000181CA File Offset: 0x000163CA
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

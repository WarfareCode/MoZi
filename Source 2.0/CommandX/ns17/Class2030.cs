using System;
using ns16;

namespace ns17
{
	// Token: 0x020006FA RID: 1786
	public sealed class Class2030 : Class2020
	{
		// Token: 0x06002C98 RID: 11416 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2030()
		{
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x0001837F File Offset: 0x0001657F
		public Class2030(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x0001838E File Offset: 0x0001658E
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

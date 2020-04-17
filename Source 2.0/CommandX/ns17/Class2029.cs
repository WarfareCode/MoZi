using System;
using ns16;

namespace ns17
{
	// Token: 0x020006F8 RID: 1784
	public sealed class Class2029 : Class2020
	{
		// Token: 0x06002C8A RID: 11402 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2029()
		{
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x00018335 File Offset: 0x00016535
		public Class2029(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x00018344 File Offset: 0x00016544
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

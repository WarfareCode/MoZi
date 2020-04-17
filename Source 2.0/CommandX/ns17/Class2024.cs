using System;
using ns16;

namespace ns17
{
	// Token: 0x020006F1 RID: 1777
	public sealed class Class2024 : Class2020
	{
		// Token: 0x06002C6B RID: 11371 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2024()
		{
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x0001818B File Offset: 0x0001638B
		public Class2024(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x0001819A File Offset: 0x0001639A
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

using System;
using ns16;

namespace ns17
{
	// Token: 0x020006FD RID: 1789
	public sealed class Class2032 : Class2020
	{
		// Token: 0x06002CA5 RID: 11429 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2032()
		{
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x0001841D File Offset: 0x0001661D
		public Class2032(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x0001842C File Offset: 0x0001662C
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

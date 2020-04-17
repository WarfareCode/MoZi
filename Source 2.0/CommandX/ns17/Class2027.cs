using System;
using ns16;

namespace ns17
{
	// Token: 0x020006F4 RID: 1780
	public sealed class Class2027 : Class2020
	{
		// Token: 0x06002C77 RID: 11383 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2027()
		{
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x0001821B File Offset: 0x0001641B
		public Class2027(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x0001822A File Offset: 0x0001642A
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

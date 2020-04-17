using System;
using ns16;

namespace ns17
{
	// Token: 0x02000708 RID: 1800
	public sealed class Class2038 : Class2020
	{
		// Token: 0x06002CE1 RID: 11489 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2038()
		{
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x00018656 File Offset: 0x00016856
		public Class2038(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x00018665 File Offset: 0x00016865
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

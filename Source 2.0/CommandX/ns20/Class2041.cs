using System;
using ns16;

namespace ns20
{
	// Token: 0x02000716 RID: 1814
	public sealed class Class2041 : Class2020
	{
		// Token: 0x06002D2A RID: 11562 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2041()
		{
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x00018937 File Offset: 0x00016B37
		public Class2041(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00018946 File Offset: 0x00016B46
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

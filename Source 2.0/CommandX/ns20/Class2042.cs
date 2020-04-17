using System;
using ns16;

namespace ns20
{
	// Token: 0x02000717 RID: 1815
	public sealed class Class2042 : Class2020
	{
		// Token: 0x06002D2E RID: 11566 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2042()
		{
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00018967 File Offset: 0x00016B67
		public Class2042(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x00018976 File Offset: 0x00016B76
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

using System;
using ns16;

namespace ns21
{
	// Token: 0x0200014F RID: 335
	public sealed class Class2048 : Class2020
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2048()
		{
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00007EE7 File Offset: 0x000060E7
		public Class2048(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00007EF6 File Offset: 0x000060F6
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
			if (base.CompareTo(this.method_3()) > 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00059EE4 File Offset: 0x000580E4
		public Class2020 method_2()
		{
			return new Class2020("-180");
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00059F00 File Offset: 0x00058100
		public Class2020 method_3()
		{
			return new Class2020("180");
		}
	}
}

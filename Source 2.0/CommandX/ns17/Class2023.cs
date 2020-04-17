using System;
using ns16;

namespace ns17
{
	// Token: 0x020006BB RID: 1723
	public sealed class Class2023 : Class2020
	{
		// Token: 0x06002B84 RID: 11140 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2023()
		{
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x00017AE8 File Offset: 0x00015CE8
		public Class2023(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x00017AF7 File Offset: 0x00015CF7
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

		// Token: 0x06002B87 RID: 11143 RVA: 0x00059EE4 File Offset: 0x000580E4
		public Class2020 method_2()
		{
			return new Class2020("-180");
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x00059F00 File Offset: 0x00058100
		public Class2020 method_3()
		{
			return new Class2020("180");
		}
	}
}

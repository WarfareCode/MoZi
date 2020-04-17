using System;
using ns16;

namespace ns17
{
	// Token: 0x020006B6 RID: 1718
	public sealed class Class2022 : Class2020
	{
		// Token: 0x06002B72 RID: 11122 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2022()
		{
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x00017A54 File Offset: 0x00015C54
		public Class2022(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x00017A63 File Offset: 0x00015C63
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

		// Token: 0x06002B75 RID: 11125 RVA: 0x00059EAC File Offset: 0x000580AC
		public Class2020 method_2()
		{
			return new Class2020("-90");
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x00059EC8 File Offset: 0x000580C8
		public Class2020 method_3()
		{
			return new Class2020("90");
		}
	}
}

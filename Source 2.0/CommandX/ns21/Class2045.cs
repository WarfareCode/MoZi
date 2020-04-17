using System;
using ns16;

namespace ns21
{
	// Token: 0x0200006B RID: 107
	public sealed class Class2045 : Class2020
	{
		// Token: 0x06000210 RID: 528 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2045()
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000566A File Offset: 0x0000386A
		public Class2045(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00005679 File Offset: 0x00003879
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

		// Token: 0x06000213 RID: 531 RVA: 0x00059EAC File Offset: 0x000580AC
		public Class2020 method_2()
		{
			return new Class2020("-90");
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00059EC8 File Offset: 0x000580C8
		public Class2020 method_3()
		{
			return new Class2020("90");
		}
	}
}

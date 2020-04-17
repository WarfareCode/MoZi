using System;
using ns16;

namespace ns17
{
	// Token: 0x0200070C RID: 1804
	public sealed class Class2039 : Class2020
	{
		// Token: 0x06002CED RID: 11501 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2039()
		{
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x000186E0 File Offset: 0x000168E0
		public Class2039(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x000186EF File Offset: 0x000168EF
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

		// Token: 0x06002CF0 RID: 11504 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x00059F00 File Offset: 0x00058100
		public Class2020 method_3()
		{
			return new Class2020("180");
		}
	}
}

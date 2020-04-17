using System;
using ns16;

namespace ns17
{
	// Token: 0x0200070E RID: 1806
	public sealed class Class2040 : Class2020
	{
		// Token: 0x06002CFA RID: 11514 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2040()
		{
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x00018766 File Offset: 0x00016966
		public Class2040(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00018775 File Offset: 0x00016975
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

		// Token: 0x06002CFD RID: 11517 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x00059F00 File Offset: 0x00058100
		public Class2020 method_3()
		{
			return new Class2020("180");
		}
	}
}

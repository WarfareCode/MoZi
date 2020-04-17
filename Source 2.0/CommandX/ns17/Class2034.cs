using System;
using ns16;

namespace ns17
{
	// Token: 0x02000700 RID: 1792
	public sealed class Class2034 : Class2020
	{
		// Token: 0x06002CB2 RID: 11442 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2034()
		{
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x0001849C File Offset: 0x0001669C
		public Class2034(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x000184AB File Offset: 0x000166AB
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

		// Token: 0x06002CB5 RID: 11445 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x00059F00 File Offset: 0x00058100
		public Class2020 method_3()
		{
			return new Class2020("180");
		}
	}
}

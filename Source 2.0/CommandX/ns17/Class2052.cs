using System;
using ns16;

namespace ns17
{
	// Token: 0x02000703 RID: 1795
	public sealed class Class2052 : Class2050
	{
		// Token: 0x06002CC8 RID: 11464 RVA: 0x0000818B File Offset: 0x0000638B
		public Class2052()
		{
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x0001856C File Offset: 0x0001676C
		public Class2052(string string_1) : base(string_1)
		{
			this.method_1();
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x0001857B File Offset: 0x0001677B
		public void method_1()
		{
			if (base.Value.Length < this.method_2())
			{
				throw new Exception("Too short");
			}
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x0000945D File Offset: 0x0000765D
		public int method_2()
		{
			return 1;
		}
	}
}

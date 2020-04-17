using System;
using ns16;

namespace ns21
{
	// Token: 0x0200006A RID: 106
	public sealed class Class2044 : Class2020
	{
		// Token: 0x0600020B RID: 523 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2044()
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000561B File Offset: 0x0000381B
		public Class2044(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000562A File Offset: 0x0000382A
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

		// Token: 0x0600020E RID: 526 RVA: 0x00059EE4 File Offset: 0x000580E4
		public Class2020 method_2()
		{
			return new Class2020("-180");
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00059F00 File Offset: 0x00058100
		public Class2020 method_3()
		{
			return new Class2020("180");
		}
	}
}

using System;
using ns16;

namespace ns17
{
	// Token: 0x020006F3 RID: 1779
	public sealed class Class2026 : Class2020
	{
		// Token: 0x06002C73 RID: 11379 RVA: 0x000055C4 File Offset: 0x000037C4
		public Class2026()
		{
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x000181EB File Offset: 0x000163EB
		public Class2026(string string_0) : base(string_0)
		{
			this.method_1();
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x000181FA File Offset: 0x000163FA
		public void method_1()
		{
			if (base.CompareTo(this.method_2()) < 0)
			{
				throw new Exception("Out of range");
			}
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x000FD808 File Offset: 0x000FBA08
		public Class2020 method_2()
		{
			return new Class2020("0");
		}
	}
}

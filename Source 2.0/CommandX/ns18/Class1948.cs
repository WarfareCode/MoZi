using System;
using System.Globalization;
using ns16;

namespace ns18
{
	// Token: 0x0200037C RID: 892
	public sealed class Class1948 : Class1947
	{
		// Token: 0x0600157A RID: 5498 RVA: 0x0000945D File Offset: 0x0000765D
		public  bool vmethod_0()
		{
			return true;
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x0000EFB0 File Offset: 0x0000D1B0
		public Class1948(string string_6, string string_7)
		{
			this.string_5 = string_7;
			this.string_4 = string_6;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x0008BB1C File Offset: 0x00089D1C
		protected override string vmethod_2(Class1992 class1992_0)
		{
			return string.Format(CultureInfo.InvariantCulture, "{0}?T={1}&L={2}&X={3}&Y={4}", new object[]
			{
				this.string_5,
				this.string_4,
				class1992_0.int_0,
				class1992_0.int_2,
				class1992_0.int_1
			});
		}

		// Token: 0x040008F2 RID: 2290
		private string string_4 = "";

		// Token: 0x040008F3 RID: 2291
		private string string_5;
	}
}

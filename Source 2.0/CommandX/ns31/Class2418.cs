using System;
using System.Runtime.CompilerServices;

namespace ns31
{
	// Token: 0x02000471 RID: 1137
	public sealed class Class2418
	{
		// Token: 0x06001D81 RID: 7553 RVA: 0x00012142 File Offset: 0x00010342
		[CompilerGenerated]
		private void method_0(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x000BE378 File Offset: 0x000BC578
		[CompilerGenerated]
		public Class2417 method_1()
		{
			return this.class2417_0;
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x0001214B File Offset: 0x0001034B
		[CompilerGenerated]
		private void method_2(Class2417 class2417_1)
		{
			this.class2417_0 = class2417_1;
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00012154 File Offset: 0x00010354
		public Class2418(Class2419 tle, string name = "")
		{
			this.method_2(new Class2417(tle));
			if (name == "")
			{
				this.method_0(this.method_1().method_19());
			}
			else
			{
				this.method_0(name);
			}
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x000BE390 File Offset: 0x000BC590
		public Class2411 method_3(DateTime dateTime_0)
		{
			return this.method_1().method_23(dateTime_0);
		}

		// Token: 0x04000D1C RID: 3356
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000D1D RID: 3357
		[CompilerGenerated]
		private Class2417 class2417_0;
	}
}

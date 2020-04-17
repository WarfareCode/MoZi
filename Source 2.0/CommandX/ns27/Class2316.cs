using System;
using System.Runtime.CompilerServices;

namespace ns27
{
	// Token: 0x02000773 RID: 1907
	public class Class2316 : Class2313
	{
		// Token: 0x06002F33 RID: 12083 RVA: 0x00107244 File Offset: 0x00105444
		[CompilerGenerated]
		protected Class2314[] method_0()
		{
			return this.class2314_0;
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x0001992C File Offset: 0x00017B2C
		[CompilerGenerated]
		protected void method_1(Class2314[] class2314_1)
		{
			this.class2314_0 = class2314_1;
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x0010725C File Offset: 0x0010545C
		public void method_2(Class2314 class2314_1, Class2314 class2314_2)
		{
			this.method_1(new Class2314[]
			{
				class2314_1,
				class2314_2
			});
			class2314_1.vmethod_0(this);
			class2314_2.vmethod_0(this);
			class2314_1.vmethod_5(class2314_2);
			class2314_2.vmethod_5(class2314_1);
			class2314_1.vmethod_4().vmethod_2(class2314_1);
			class2314_2.vmethod_4().vmethod_2(class2314_2);
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x001072B4 File Offset: 0x001054B4
		public virtual Class2314 vmethod_0(int int_0)
		{
			return this.method_0()[int_0];
		}

		// Token: 0x040015EB RID: 5611
		[CompilerGenerated]
		private Class2314[] class2314_0;
	}
}

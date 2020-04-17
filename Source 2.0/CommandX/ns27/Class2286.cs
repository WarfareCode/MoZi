using System;
using System.Collections;
using ns23;

namespace ns27
{
	// Token: 0x020006D2 RID: 1746
	public abstract class Class2286 : Interface47
	{
		// Token: 0x06002BDF RID: 11231 RVA: 0x00004A21 File Offset: 0x00002C21
		protected Class2286()
		{
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00017D88 File Offset: 0x00015F88
		protected Class2286(Interface48 interface48_1)
		{
			this.interface48_0 = interface48_1;
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x001010E4 File Offset: 0x000FF2E4
		public Interface48 method_0()
		{
			return this.interface48_0;
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x00017D97 File Offset: 0x00015F97
		public void method_1(Interface48 interface48_1)
		{
			this.interface48_0 = interface48_1;
		}

		// Token: 0x06002BE3 RID: 11235
		public abstract void imethod_0(IList ilist_0);

		// Token: 0x06002BE4 RID: 11236
		public abstract IList imethod_1();

		// Token: 0x040014BB RID: 5307
		private Interface48 interface48_0;
	}
}

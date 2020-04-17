using System;
using System.Collections;
using ns28;

namespace ns23
{
	// Token: 0x020006A0 RID: 1696
	public abstract class Class2269 : Interface45
	{
		// Token: 0x06002AF8 RID: 11000 RVA: 0x000176C5 File Offset: 0x000158C5
		protected Class2269(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x000FFA8C File Offset: 0x000FDC8C
		public  IList vmethod_0()
		{
			return this.arrayList_0;
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x000FFAA4 File Offset: 0x000FDCA4
		public virtual object imethod_0()
		{
			if (this.object_0 == null)
			{
				this.object_0 = this.vmethod_1();
			}
			return this.object_0;
		}

		// Token: 0x06002AFB RID: 11003
		protected abstract object vmethod_1();

		// Token: 0x06002AFC RID: 11004 RVA: 0x000176DF File Offset: 0x000158DF
		public  void vmethod_2(Interface45 interface45_0)
		{
			Class2347.smethod_0(this.object_0 == null);
			this.arrayList_0.Add(interface45_0);
		}

		// Token: 0x04001469 RID: 5225
		private readonly ArrayList arrayList_0 = new ArrayList();

		// Token: 0x0400146A RID: 5226
		private readonly int int_0;

		// Token: 0x0400146B RID: 5227
		private object object_0;
	}
}

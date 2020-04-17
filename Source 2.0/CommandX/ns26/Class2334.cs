using System;
using System.Collections;
using ns27;

namespace ns26
{
	// Token: 0x020007DD RID: 2013
	public sealed class Class2334
	{
		// Token: 0x060031D3 RID: 12755 RVA: 0x0010D058 File Offset: 0x0010B258
		public  int vmethod_0()
		{
			return this.ilist_0.Count;
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x0001AD05 File Offset: 0x00018F05
		public  void vmethod_1(Class2314 class2314_0)
		{
			this.ilist_0.Add(class2314_0);
			this.bool_0 = false;
		}

		// Token: 0x04001721 RID: 5921
		private IList ilist_0 = new ArrayList();

		// Token: 0x04001722 RID: 5922
		private bool bool_0;
	}
}

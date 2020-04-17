using System;
using System.Collections;

namespace ns23
{
	// Token: 0x0200065E RID: 1630
	public abstract class Class2254
	{
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x000FD964 File Offset: 0x000FBB64
		// (set) Token: 0x06002997 RID: 10647 RVA: 0x00016CA7 File Offset: 0x00014EA7
		public virtual Class2255[] Nodes
		{
			get
			{
				return this.class2255_0;
			}
			protected set
			{
				this.class2255_0 = value;
			}
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x00016CB0 File Offset: 0x00014EB0
		public  void vmethod_0(object object_0)
		{
			this.ilist_0.Add(object_0);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000FD97C File Offset: 0x000FBB7C
		public  IList vmethod_1(Class2252 class2252_0, IList ilist_1)
		{
			IList result;
			if (!this.vmethod_2(class2252_0))
			{
				result = this.ilist_0;
			}
			else
			{
				foreach (object current in this.ilist_0)
				{
					ilist_1.Add(current);
				}
				for (int i = 0; i < 2; i++)
				{
					if (this.class2255_0[i] != null)
					{
						this.class2255_0[i].vmethod_1(class2252_0, ilist_1);
					}
				}
				result = this.ilist_0;
			}
			return result;
		}

		// Token: 0x0600299A RID: 10650
		protected abstract bool vmethod_2(Class2252 class2252_0);

		// Token: 0x0600299B RID: 10651 RVA: 0x000FDA20 File Offset: 0x000FBC20
		public static int smethod_0(Class2252 class2252_0, double double_0)
		{
			int result = -1;
			if (class2252_0.vmethod_0() >= double_0)
			{
				result = 1;
			}
			if (class2252_0.vmethod_2() <= double_0)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x040013F3 RID: 5107
		private readonly IList ilist_0 = new ArrayList();

		// Token: 0x040013F4 RID: 5108
		private Class2255[] class2255_0 = new Class2255[2];
	}
}

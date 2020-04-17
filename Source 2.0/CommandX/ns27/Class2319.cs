using System;
using System.Collections;
using DotSpatial.Topology;
using ns26;

namespace ns27
{
	// Token: 0x02000775 RID: 1909
	public abstract class Class2319
	{
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06002F39 RID: 12089 RVA: 0x001072CC File Offset: 0x001054CC
		public virtual ICollection Nodes
		{
			get
			{
				return this.class2335_0.vmethod_0();
			}
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x001072E8 File Offset: 0x001054E8
		public virtual Class2318 vmethod_0(Coordinate coordinate_0)
		{
			return this.class2335_0.vmethod_2(coordinate_0);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x0001994C File Offset: 0x00017B4C
		protected virtual void vmethod_1(Class2318 class2318_0)
		{
			this.class2335_0.vmethod_1(class2318_0);
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x0001995B File Offset: 0x00017B5B
		protected virtual void vmethod_2(Class2316 class2316_0)
		{
			this.ilist_0.Add(class2316_0);
			this.vmethod_3(class2316_0.vmethod_0(0));
			this.vmethod_3(class2316_0.vmethod_0(1));
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x00019984 File Offset: 0x00017B84
		protected virtual void vmethod_3(Class2314 class2314_0)
		{
			this.ilist_1.Add(class2314_0);
		}

		// Token: 0x040015ED RID: 5613
		private readonly IList ilist_0 = new ArrayList();

		// Token: 0x040015EE RID: 5614
		private readonly Class2335 class2335_0 = new Class2335();

		// Token: 0x040015EF RID: 5615
		private IList ilist_1 = new ArrayList();
	}
}

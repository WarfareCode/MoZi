using System;
using System.Collections;
using DotSpatial.Topology;
using ns23;
using ns25;

namespace ns27
{
	// Token: 0x020006CF RID: 1743
	public sealed class Class2284 : Interface48
	{
		// Token: 0x06002BD7 RID: 11223 RVA: 0x00017D56 File Offset: 0x00015F56
		public Class2284(LineIntersector class2239_1)
		{
			this.class2239_0 = class2239_1;
			this.ilist_0 = new ArrayList();
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x00100F24 File Offset: 0x000FF124
		public IList method_0()
		{
			return this.ilist_0;
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x00100F3C File Offset: 0x000FF13C
		public void imethod_0(Class2295 class2295_0, int int_0, Class2295 class2295_1, int int_1)
		{
			if (class2295_0 != class2295_1 || int_0 != int_1)
			{
				Coordinate coordinate_ = class2295_0.method_3()[int_0];
				Coordinate coordinate_2 = class2295_0.method_3()[int_0 + 1];
				Coordinate coordinate_3 = class2295_1.method_3()[int_1];
				Coordinate coordinate_4 = class2295_1.method_3()[int_1 + 1];
				this.class2239_0.ComputeIntersection(coordinate_, coordinate_2, coordinate_3, coordinate_4);
				if (this.class2239_0.HasIntersection() && this.class2239_0.vmethod_7())
				{
					for (int i = 0; i < this.class2239_0.vmethod_11(); i++)
					{
						this.ilist_0.Add(this.class2239_0.GetIntersection(i));
					}
					class2295_0.method_7(this.class2239_0, int_0);
					class2295_1.method_7(this.class2239_0, int_1);
				}
			}
		}

		// Token: 0x040014B6 RID: 5302
		private readonly IList ilist_0;

		// Token: 0x040014B7 RID: 5303
		private readonly LineIntersector class2239_0;
	}
}

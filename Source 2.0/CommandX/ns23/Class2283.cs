using System;
using DotSpatial.Topology;
using ns25;
using ns27;

namespace ns23
{
	// Token: 0x020006CE RID: 1742
	public sealed class Class2283 : Interface48
	{
		// Token: 0x06002BD3 RID: 11219 RVA: 0x00017D32 File Offset: 0x00015F32
		public Class2283(LineIntersector class2239_1)
		{
			this.class2239_0 = class2239_1;
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x00100D9C File Offset: 0x000FEF9C
		public void imethod_0(Class2295 class2295_0, int int_4, Class2295 class2295_1, int int_5)
		{
			if (class2295_0 != class2295_1 || int_4 != int_5)
			{
				this.int_3++;
				Coordinate coordinate_ = class2295_0.method_3()[int_4];
				Coordinate coordinate_2 = class2295_0.method_3()[int_4 + 1];
				Coordinate coordinate_3 = class2295_1.method_3()[int_5];
				Coordinate coordinate_4 = class2295_1.method_3()[int_5 + 1];
				this.class2239_0.ComputeIntersection(coordinate_, coordinate_2, coordinate_3, coordinate_4);
				if (this.class2239_0.HasIntersection())
				{
					this.int_1++;
					if (this.class2239_0.vmethod_7())
					{
						this.int_0++;
						this.bool_0 = true;
					}
					if (!this.method_0(class2295_0, int_4, class2295_1, int_5))
					{
						this.bool_1 = true;
						class2295_0.method_7(this.class2239_0, int_4);
						class2295_1.method_7(this.class2239_0, int_5);
						if (this.class2239_0.vmethod_14())
						{
							this.int_2++;
							this.bool_2 = true;
							this.bool_3 = true;
						}
					}
				}
			}
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x000119AD File Offset: 0x0000FBAD
		private static bool smethod_0(int int_4, int int_5)
		{
			return Math.Abs(int_4 - int_5) == 1;
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x00100EB4 File Offset: 0x000FF0B4
		private bool method_0(Class2295 class2295_0, int int_4, Class2295 class2295_1, int int_5)
		{
			bool result;
			if (class2295_0 == class2295_1 && this.class2239_0.vmethod_11() == 1)
			{
				if (Class2283.smethod_0(int_4, int_5))
				{
					result = true;
					return result;
				}
				if (class2295_0.method_4())
				{
					int num = class2295_0.method_2() - 1;
					bool arg_5A_0;
					if (int_4 == 0)
					{
						if (int_5 == num)
						{
							arg_5A_0 = false;
							goto IL_5A;
						}
					}
					arg_5A_0 = (int_5 != 0 || int_4 != num);
					IL_5A:
					if (!arg_5A_0)
					{
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}

		// Token: 0x040014AD RID: 5293
		private readonly LineIntersector class2239_0;

		// Token: 0x040014AE RID: 5294
		public int int_0;

		// Token: 0x040014AF RID: 5295
		private bool bool_0;

		// Token: 0x040014B0 RID: 5296
		private bool bool_1;

		// Token: 0x040014B1 RID: 5297
		private bool bool_2 = false;

		// Token: 0x040014B2 RID: 5298
		private bool bool_3;

		// Token: 0x040014B3 RID: 5299
		private int int_1;

		// Token: 0x040014B4 RID: 5300
		private int int_2 = 0;

		// Token: 0x040014B5 RID: 5301
		private int int_3 = 0;
	}
}

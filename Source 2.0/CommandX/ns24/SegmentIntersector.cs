using System;
using System.Collections;
using DotSpatial.Topology;
using ns25;

namespace ns24
{
	// Token: 0x0200059E RID: 1438
	public sealed class SegmentIntersector
	{
		// Token: 0x060024D8 RID: 9432 RVA: 0x000151C5 File Offset: 0x000133C5
		public SegmentIntersector(LineIntersector class2239_1, bool bool_5, bool bool_6)
		{
			this.class2239_0 = class2239_1;
			this._includeProper = bool_5;
			this.bool_1 = bool_6;
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000E3124 File Offset: 0x000E1324
		public  Coordinate vmethod_0()
		{
			return this.coordinate_0;
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x000151E9 File Offset: 0x000133E9
		public  bool vmethod_1()
		{
			return this.bool_3;
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x000119AD File Offset: 0x0000FBAD
		public static bool smethod_0(int int_2, int int_3)
		{
			return Math.Abs(int_2 - int_3) == 1;
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x000E313C File Offset: 0x000E133C
		private bool method_0(Class2199 class2199_0, int int_2, Class2199 class2199_1, int int_3)
		{
			bool result;
			if (object.ReferenceEquals(class2199_0, class2199_1) && this.class2239_0.vmethod_11() == 1)
			{
				if (SegmentIntersector.smethod_0(int_2, int_3))
				{
					result = true;
					return result;
				}
				if (class2199_0.vmethod_14())
				{
					int num = class2199_0.vmethod_7() - 1;
					bool arg_5F_0;
					if (int_2 == 0)
					{
						if (int_3 == num)
						{
							arg_5F_0 = false;
							goto IL_5F;
						}
					}
					arg_5F_0 = (int_3 != 0 || int_2 != num);
					IL_5F:
					if (!arg_5F_0)
					{
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x000E31B4 File Offset: 0x000E13B4
		public  void vmethod_2(Class2199 class2199_0, int int_2, Class2199 class2199_1, int int_3)
		{
			if (!object.ReferenceEquals(class2199_0, class2199_1) || int_2 != int_3)
			{
				this.int_0++;
				Coordinate coordinate_ = class2199_0.vmethod_8()[int_2];
				Coordinate coordinate_2 = class2199_0.vmethod_8()[int_2 + 1];
				Coordinate coordinate_3 = class2199_1.vmethod_8()[int_3];
				Coordinate coordinate_4 = class2199_1.vmethod_8()[int_3 + 1];
				this.class2239_0.ComputeIntersection(coordinate_, coordinate_2, coordinate_3, coordinate_4);
				if (this.class2239_0.HasIntersection())
				{
					if (this.bool_1)
					{
						class2199_0.vmethod_15(false);
						class2199_1.vmethod_15(false);
					}
					this.int_1++;
					if (!this.method_0(class2199_0, int_2, class2199_1, int_3))
					{
						this.bool_2 = true;
						if (this._includeProper || !this.class2239_0.vmethod_14())
						{
							class2199_0.vmethod_17(this.class2239_0, int_2, 0);
							class2199_1.vmethod_17(this.class2239_0, int_3, 1);
						}
						if (this.class2239_0.vmethod_14())
						{
							this.coordinate_0 = (Coordinate)this.class2239_0.GetIntersection(0).Clone();
							this.bool_3 = true;
							if (!SegmentIntersector.smethod_1(this.class2239_0, this.icollection_0))
							{
								this.bool_4 = true;
							}
						}
					}
				}
			}
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x000151F1 File Offset: 0x000133F1
		private static bool smethod_1(LineIntersector class2239_1, ICollection[] icollection_1)
		{
			return icollection_1 != null && (SegmentIntersector.smethod_2(class2239_1, icollection_1[0]) || SegmentIntersector.smethod_2(class2239_1, icollection_1[1]));
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x000E3304 File Offset: 0x000E1504
		private static bool smethod_2(LineIntersector class2239_1, IEnumerable ienumerable_0)
		{
			IEnumerator enumerator = ienumerable_0.GetEnumerator();
			bool result;
			while (enumerator.MoveNext())
			{
				Class2200 @class = (Class2200)enumerator.Current;
				Coordinate coordinate_ = @class.vmethod_5();
				if (class2239_1.vmethod_6(coordinate_))
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x040011B8 RID: 4536
		private readonly bool _includeProper;

		// Token: 0x040011B9 RID: 4537
		private readonly LineIntersector class2239_0;

		// Token: 0x040011BA RID: 4538
		private readonly bool bool_1;

		// Token: 0x040011BB RID: 4539
		public int int_0;

		// Token: 0x040011BC RID: 4540
		private ICollection[] icollection_0;

		// Token: 0x040011BD RID: 4541
		private bool bool_2 = false;

		// Token: 0x040011BE RID: 4542
		private bool bool_3;

		// Token: 0x040011BF RID: 4543
		private bool bool_4;

		// Token: 0x040011C0 RID: 4544
		private int int_1;

		// Token: 0x040011C1 RID: 4545
		private Coordinate coordinate_0;
	}
}

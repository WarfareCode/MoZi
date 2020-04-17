using System;
using DotSpatial.Topology;
using ns25;
using ns26;

namespace ns27
{
	// Token: 0x0200074E RID: 1870
	public class Class2314 : Class2313, IComparable
	{
		// Token: 0x06002E6A RID: 11882 RVA: 0x00106218 File Offset: 0x00104418
		public Class2314(Class2318 class2318_2, Class2318 class2318_3, Coordinate coordinate_2, bool bool_1)
		{
			this.class2318_0 = class2318_2;
			this.class2318_1 = class2318_3;
			this.bool_0 = bool_1;
			this.coordinate_0 = this.class2318_0.vmethod_0();
			this.coordinate_1 = coordinate_2;
			double x = this.coordinate_1.X - this.coordinate_0.X;
			double num = this.coordinate_1.Y - this.coordinate_0.Y;
			this.int_0 = Class2223.smethod_0(x, num);
			this.double_0 = Math.Atan2(num, x);
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x00019412 File Offset: 0x00017612
		public  void vmethod_0(Class2316 class2316_1)
		{
			this.class2316_0 = class2316_1;
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x001062A4 File Offset: 0x001044A4
		public  int vmethod_1()
		{
			return this.int_0;
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x001062BC File Offset: 0x001044BC
		public  Coordinate vmethod_2()
		{
			return this.coordinate_0;
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x001062D4 File Offset: 0x001044D4
		public  Coordinate vmethod_3()
		{
			return this.coordinate_1;
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x001062EC File Offset: 0x001044EC
		public virtual Class2318 vmethod_4()
		{
			return this.class2318_0;
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x0001941B File Offset: 0x0001761B
		public  void vmethod_5(Class2314 class2314_1)
		{
			this.class2314_0 = class2314_1;
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x00106304 File Offset: 0x00104504
		public virtual int CompareTo(object target)
		{
			Class2314 class2314_ = (Class2314)target;
			return this.vmethod_6(class2314_);
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x00106324 File Offset: 0x00104524
		public  int vmethod_6(Class2314 class2314_1)
		{
			int result;
			if (this.int_0 > class2314_1.vmethod_1())
			{
				result = 1;
			}
			else if (this.int_0 < class2314_1.vmethod_1())
			{
				result = -1;
			}
			else
			{
				result = CgAlgorithms.ComputeOrientation(class2314_1.vmethod_2(), class2314_1.vmethod_3(), this.coordinate_1);
			}
			return result;
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x00106378 File Offset: 0x00104578
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"DirectedEdge: ",
				this.coordinate_0,
				" - ",
				this.coordinate_1,
				" ",
				this.int_0,
				":",
				this.double_0
			});
		}

		// Token: 0x0400159E RID: 5534
		private readonly double double_0;

		// Token: 0x0400159F RID: 5535
		private readonly bool bool_0;

		// Token: 0x040015A0 RID: 5536
		private readonly Class2318 class2318_0;

		// Token: 0x040015A1 RID: 5537
		private readonly Coordinate coordinate_0;

		// Token: 0x040015A2 RID: 5538
		private readonly Coordinate coordinate_1;

		// Token: 0x040015A3 RID: 5539
		private readonly int int_0;

		// Token: 0x040015A4 RID: 5540
		private readonly Class2318 class2318_1;

		// Token: 0x040015A5 RID: 5541
		private Class2316 class2316_0;

		// Token: 0x040015A6 RID: 5542
		private Class2314 class2314_0;
	}
}

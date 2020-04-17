using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using DotSpatial.Topology.Noding;
using ns25;

namespace ns27
{
	// Token: 0x02000701 RID: 1793
	public sealed class Class2295
	{
		// Token: 0x06002CB7 RID: 11447 RVA: 0x0010262C File Offset: 0x0010082C
		public static IList smethod_0(IList ilist_1)
		{
			IList list = new ArrayList();
			Class2295.smethod_1(ilist_1, list);
			return list;
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x0010264C File Offset: 0x0010084C
		public static void smethod_1(IList ilist_1, IList ilist_2)
		{
			foreach (object current in ilist_1)
			{
				Class2295 @class = (Class2295)current;
				@class.method_1().method_5(ilist_2);
			}
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x000184EB File Offset: 0x000166EB
		public Class2295(IList<Coordinate> ilist_1, object object_1)
		{
			this.class2292_0 = new Class2292(this);
			this.ilist_0 = ilist_1;
			this.object_0 = object_1;
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x001026AC File Offset: 0x001008AC
		public object method_0()
		{
			return this.object_0;
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x001026C4 File Offset: 0x001008C4
		public Class2292 method_1()
		{
			return this.class2292_0;
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x001026DC File Offset: 0x001008DC
		public int method_2()
		{
			return this.ilist_0.Count;
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x001026F8 File Offset: 0x001008F8
		public IList<Coordinate> method_3()
		{
			return this.ilist_0;
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x0001850D File Offset: 0x0001670D
		public bool method_4()
		{
			return this.ilist_0[0].Equals(this.ilist_0[this.ilist_0.Count - 1]);
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x00102710 File Offset: 0x00100910
		public Coordinate method_5(int int_0)
		{
			return this.ilist_0[int_0];
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x0010272C File Offset: 0x0010092C
		public OctantDirection method_6(int int_0)
		{
			OctantDirection result;
			if (int_0 == this.ilist_0.Count - 1)
			{
				result = OctantDirection.Null;
			}
			else
			{
				result = Class2288.smethod_1(this.method_5(int_0), this.method_5(int_0 + 1));
			}
			return result;
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x0010276C File Offset: 0x0010096C
		public void method_7(LineIntersector class2239_0, int int_0)
		{
			for (int i = 0; i < class2239_0.vmethod_11(); i++)
			{
				this.method_8(class2239_0, int_0, i);
			}
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x00102798 File Offset: 0x00100998
		public void method_8(LineIntersector class2239_0, int int_0, int int_1)
		{
			Coordinate coordinate_ = new Coordinate(class2239_0.GetIntersection(int_1));
			this.method_9(coordinate_, int_0);
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x001027BC File Offset: 0x001009BC
		public void method_9(Coordinate coordinate_0, int int_0)
		{
			int num = int_0;
			int num2 = num + 1;
			if (num2 < this.ilist_0.Count)
			{
				Coordinate b = this.ilist_0[num2];
				if (coordinate_0.Equals2D(b))
				{
					num = num2;
				}
			}
			this.class2292_0.method_0(coordinate_0, num);
		}

		// Token: 0x04001504 RID: 5380
		private readonly Class2292 class2292_0;

		// Token: 0x04001505 RID: 5381
		private readonly IList<Coordinate> ilist_0;

		// Token: 0x04001506 RID: 5382
		private object object_0;
	}
}

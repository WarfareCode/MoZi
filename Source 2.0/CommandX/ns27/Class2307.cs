using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns24;
using ns25;

namespace ns27
{
	// Token: 0x02000747 RID: 1863
	public sealed class Class2307
	{
		// Token: 0x06002E49 RID: 11849 RVA: 0x000192E8 File Offset: 0x000174E8
		public Class2307(IList ilist_1)
		{
			this.ilist_0 = ilist_1;
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x00105830 File Offset: 0x00103A30
		public  int vmethod_0(Coordinate coordinate_0)
		{
			ArrayList arrayList = new ArrayList(this.method_0(coordinate_0));
			int result;
			if (arrayList.Count == 0)
			{
				result = 0;
			}
			else
			{
				arrayList.Sort();
				Class2307.Class2308 @class = (Class2307.Class2308)arrayList[0];
				result = @class.method_0();
			}
			return result;
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x00105878 File Offset: 0x00103A78
		private IList method_0(Coordinate coordinate_0)
		{
			IList list = new ArrayList();
			IEnumerator enumerator = this.ilist_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2303 @class = (Class2303)enumerator.Current;
				this.method_1(coordinate_0, @class.vmethod_0(), list);
			}
			return list;
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x001058C0 File Offset: 0x00103AC0
		private void method_1(Coordinate coordinate_0, IEnumerable ienumerable_0, IList ilist_1)
		{
			IEnumerator enumerator = ienumerable_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2193 @class = (Class2193)enumerator.Current;
				if (@class.vmethod_17())
				{
					this.method_2(coordinate_0, @class, ilist_1);
				}
			}
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x00105900 File Offset: 0x00103B00
		private void method_2(Coordinate coordinate_0, Class2193 class2193_0, IList ilist_1)
		{
			IList<Coordinate> list = class2193_0.vmethod_0().vmethod_8();
			for (int i = 0; i < list.Count - 1; i++)
			{
				this.lineSegment_0.SetP0(list[i]);
				this.lineSegment_0.SetP1(list[i + 1]);
				if (this.lineSegment_0.GetP0().Y > this.lineSegment_0.GetP1().Y)
				{
					this.lineSegment_0.Reverse();
				}
				double num = Math.Max(this.lineSegment_0.GetP0().X, this.lineSegment_0.GetP1().X);
				if (num >= coordinate_0.X && !this.lineSegment_0.IsHorizontal() && coordinate_0.Y >= this.lineSegment_0.GetP0().Y && coordinate_0.Y <= this.lineSegment_0.GetP1().Y && CgAlgorithms.ComputeOrientation(this.lineSegment_0.GetP0(), this.lineSegment_0.GetP1(), coordinate_0) != -1)
				{
					int int_ = class2193_0.vmethod_12(Enum158.const_1);
					if (!this.lineSegment_0.GetP0().Equals(list[i]))
					{
						int_ = class2193_0.vmethod_12(Enum158.const_2);
					}
					Class2307.Class2308 value = new Class2307.Class2308(this.lineSegment_0, int_);
					ilist_1.Add(value);
				}
			}
		}

		// Token: 0x04001590 RID: 5520
		private readonly LineSegment lineSegment_0 = new LineSegment();

		// Token: 0x04001591 RID: 5521
		private readonly IList ilist_0;

		// Token: 0x02000748 RID: 1864
		private sealed class Class2308 : IComparable
		{
			// Token: 0x06002E4E RID: 11854 RVA: 0x00019302 File Offset: 0x00017502
			public Class2308(ILineSegmentBase interface39_0, int int_1)
			{
				this.lineSegment_0 = new LineSegment(interface39_0);
				this.int_0 = int_1;
			}

			// Token: 0x06002E4F RID: 11855 RVA: 0x00105A5C File Offset: 0x00103C5C
			public int method_0()
			{
				return this.int_0;
			}

			// Token: 0x06002E50 RID: 11856 RVA: 0x00105A74 File Offset: 0x00103C74
			public int CompareTo(object target)
			{
				Class2307.Class2308 @class = (Class2307.Class2308)target;
				int num = this.lineSegment_0.OrientationIndex(@class.lineSegment_0);
				if (num == 0)
				{
					num = -1 * @class.lineSegment_0.OrientationIndex(this.lineSegment_0);
				}
				int result;
				if (num != 0)
				{
					result = num;
				}
				else
				{
					result = Class2307.Class2308.smethod_0(this.lineSegment_0, @class.lineSegment_0);
				}
				return result;
			}

			// Token: 0x06002E51 RID: 11857 RVA: 0x00105AD4 File Offset: 0x00103CD4
			private static int smethod_0(ILineSegmentBase interface39_0, ILineSegmentBase interface39_1)
			{
				int num = interface39_0.GetP0().CompareTo(interface39_1.GetP0());
				int result;
				if (num == 0)
				{
					result = interface39_0.GetP1().CompareTo(interface39_1.GetP1());
				}
				else
				{
					result = num;
				}
				return result;
			}

			// Token: 0x04001592 RID: 5522
			private readonly int int_0;

			// Token: 0x04001593 RID: 5523
			private readonly LineSegment lineSegment_0;
		}
	}
}

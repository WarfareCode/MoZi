using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;
using ns25;

namespace ns23
{
	// Token: 0x0200064F RID: 1615
	public sealed class Class2249 : Interface42
	{
		// Token: 0x06002967 RID: 10599 RVA: 0x000FD5E4 File Offset: 0x000FB7E4
		public bool imethod_0(Coordinate coordinate_0)
		{
			this.int_0 = 0;
			IList list = this.class2273_0.vmethod_11(coordinate_0.Y);
			IEnumerator enumerator = list.GetEnumerator();
			while (enumerator.MoveNext())
			{
				LineSegment interface39_ = (LineSegment)enumerator.Current;
				this.method_0(coordinate_0, interface39_);
			}
			return this.int_0 % 2 == 1;
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x000FD63C File Offset: 0x000FB83C
		private void method_0(Coordinate coordinate_0, ILineSegmentBase interface39_0)
		{
			Coordinate p = interface39_0.GetP0();
			Coordinate p2 = interface39_0.GetP1();
			double x = p.X - coordinate_0.X;
			double num = p.Y - coordinate_0.Y;
			double x2 = p2.X - coordinate_0.X;
			double num2 = p2.Y - coordinate_0.Y;
			if ((num > 0.0 && num2 <= 0.0) || (num2 > 0.0 && num <= 0.0))
			{
				double num3 = (double)RobustDeterminant.SignOfDet2X2(x, num, x2, num2) / (num2 - num);
				if (0.0 < num3)
				{
					this.int_0++;
				}
			}
		}

		// Token: 0x040013D3 RID: 5075
		private int int_0;

		// Token: 0x040013D4 RID: 5076
		private Class2273 class2273_0;
	}
}

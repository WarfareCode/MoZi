using System;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns16;

namespace ns26
{
	// Token: 0x020007F0 RID: 2032
	public sealed class DouglasPeuckerLineSimplifier
	{
		// Token: 0x0600321F RID: 12831 RVA: 0x0001B016 File Offset: 0x00019216
		private DouglasPeuckerLineSimplifier(IList<Coordinate> pts)
		{
			this._pts = pts;
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x0010D570 File Offset: 0x0010B770
		public static IList<Coordinate> Simplify(IList<Coordinate> ilist_1, double double_1)
		{
			return new DouglasPeuckerLineSimplifier(ilist_1)
			{
				_distanceTolerance = double_1
			}.Simplify();
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x0010D594 File Offset: 0x0010B794
		private Coordinate[] Simplify()
		{
			this._usePt = new bool[this._pts.Count];
			for (int i = 0; i < this._pts.Count; i++)
			{
				this._usePt[i] = true;
			}
			this.SimplifySection(0, this._pts.Count - 1);
			Class833 @class = new Class833();
			for (int j = 0; j < this._pts.Count; j++)
			{
				if (this._usePt[j])
				{
					@class.Add(new Coordinate(this._pts[j]));
				}
			}
			return @class.vmethod_12();
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x0010D638 File Offset: 0x0010B838
		private void SimplifySection(int int_0, int int_1)
		{
			if (int_0 + 1 != int_1)
			{
				this._seg.SetP0(this._pts[int_0]);
				this._seg.SetP1(this._pts[int_1]);
				double num = -1.0;
				int num2 = int_0;
				for (int i = int_0 + 1; i < int_1; i++)
				{
					double num3 = this._seg.Distance(this._pts[i]);
					if (num3 > num)
					{
						num = num3;
						num2 = i;
					}
				}
				if (num <= this._distanceTolerance)
				{
					for (int j = int_0 + 1; j < int_1; j++)
					{
						this._usePt[j] = false;
					}
				}
				else
				{
					this.SimplifySection(int_0, num2);
					this.SimplifySection(num2, int_1);
				}
			}
		}

		// Token: 0x04001742 RID: 5954
		private readonly IList<Coordinate> _pts;

		// Token: 0x04001743 RID: 5955
		private readonly LineSegment _seg = new LineSegment();

		// Token: 0x04001744 RID: 5956
		private double _distanceTolerance;

		// Token: 0x04001745 RID: 5957
		private bool[] _usePt;
	}
}

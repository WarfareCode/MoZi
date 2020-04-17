using System;
using System.Collections.Generic;

namespace Command_Core
{
	// Token: 0x02000B8B RID: 2955
	public sealed class RBWQuadTree
	{
		// Token: 0x02000B8C RID: 2956
		[Serializable]
		public struct TQPoint<T>
		{
			// Token: 0x04003488 RID: 13448
			public double X;

			// Token: 0x04003489 RID: 13449
			public double Y;

			// Token: 0x0400348A RID: 13450
			public List<T> Data;
		}

		// Token: 0x02000B8D RID: 2957
		[Serializable]
		public sealed class TSelectNode<T> : IComparer<RBWQuadTree.TSelectNode<T>>
		{
			// Token: 0x06006193 RID: 24979 RVA: 0x002F2FF8 File Offset: 0x002F11F8
			public int Compare(RBWQuadTree.TSelectNode<T> x, RBWQuadTree.TSelectNode<T> y)
			{
				double num = y.Distance - x.Distance;
				int result;
				if (num > 0.0)
				{
					result = -1;
				}
				else if (num < 0.0)
				{
					result = 1;
				}
				else
				{
					result = 0;
				}
				return result;
			}

			// Token: 0x0400348B RID: 13451
			public double Distance;

			// Token: 0x0400348C RID: 13452
			public RBWQuadTree.TQPoint<T> Point;
		}
	}
}

using System;
using GisSharpBlog.NetTopologySuite.Geometries;

namespace ns12
{
	// Token: 0x020003C1 RID: 961
	public sealed class Class610
	{
		// Token: 0x020003C2 RID: 962
		private sealed class Class611 : IComparable
		{
			// Token: 0x060017CA RID: 6090 RVA: 0x000931C4 File Offset: 0x000913C4
			public int CompareTo(object target)
			{
				Class610.Class611 @class = (Class610.Class611)target;
				int num = this.lineSegment_0.method_2(@class.lineSegment_0);
				if (num == 0)
				{
					num = -1 * @class.lineSegment_0.method_2(this.lineSegment_0);
				}
				int result;
				if (num != 0)
				{
					result = num;
				}
				else
				{
					result = this.method_0(this.lineSegment_0, @class.lineSegment_0);
				}
				return result;
			}

			// Token: 0x060017CB RID: 6091 RVA: 0x0009322C File Offset: 0x0009142C
			private int method_0(LineSegment lineSegment_1, LineSegment lineSegment_2)
			{
				int num = lineSegment_1.method_1().CompareTo(lineSegment_2.method_1());
				int result;
				if (num != 0)
				{
					result = num;
				}
				else
				{
					result = lineSegment_1.method_0().CompareTo(lineSegment_2.method_0());
				}
				return result;
			}

			// Token: 0x040009B7 RID: 2487
			private LineSegment lineSegment_0;
		}
	}
}

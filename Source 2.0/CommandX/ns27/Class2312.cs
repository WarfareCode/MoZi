using System;
using DotSpatial.Topology;

namespace ns27
{
	// Token: 0x0200074C RID: 1868
	public sealed class Class2312
	{
		// Token: 0x06002E66 RID: 11878 RVA: 0x000193E5 File Offset: 0x000175E5
		public Class2312(IGeometry igeometry_1, int int_1, Coordinate coordinate_1)
		{
			this.igeometry_0 = igeometry_1;
			this.int_0 = int_1;
			this.coordinate_0 = new Coordinate(coordinate_1);
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x00019407 File Offset: 0x00017607
		public Class2312(IGeometry igeometry_1, Coordinate coordinate_1) : this(igeometry_1, -1, coordinate_1)
		{
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x00106200 File Offset: 0x00104400
		public  Coordinate vmethod_0()
		{
			return this.coordinate_0;
		}

		// Token: 0x0400159B RID: 5531
		private readonly IGeometry igeometry_0;

		// Token: 0x0400159C RID: 5532
		private readonly Coordinate coordinate_0;

		// Token: 0x0400159D RID: 5533
		private readonly int int_0;
	}
}

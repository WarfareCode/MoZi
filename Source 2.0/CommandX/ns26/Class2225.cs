using System;
using DotSpatial.Topology;

namespace ns26
{
	// Token: 0x020007F4 RID: 2036
	public sealed class Class2225 : LineSegment
	{
		// Token: 0x0600322F RID: 12847 RVA: 0x0001B057 File Offset: 0x00019257
		public Class2225(Coordinate coordinate_0, Coordinate coordinate_1, IGeometry igeometry_1, int int_1) : base(coordinate_0, coordinate_1)
		{
			this.igeometry_0 = igeometry_1;
			this.int_0 = int_1;
		}

		// Token: 0x0400174B RID: 5963
		private readonly int int_0;

		// Token: 0x0400174C RID: 5964
		private readonly IGeometry igeometry_0;
	}
}

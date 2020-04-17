using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;

namespace ns27
{
	// Token: 0x0200074A RID: 1866
	public sealed class Class2310 : IGeometryFilter
	{
		// Token: 0x06002E55 RID: 11861 RVA: 0x00019368 File Offset: 0x00017568
		public  void Filter(IGeometry igeometry_0)
		{
			if (igeometry_0 is Point || igeometry_0 is LineString || igeometry_0 is Polygon)
			{
				this.ilist_0.Add(igeometry_0.GetCoordinate());
			}
		}

		// Token: 0x04001595 RID: 5525
		private readonly IList ilist_0;
	}
}

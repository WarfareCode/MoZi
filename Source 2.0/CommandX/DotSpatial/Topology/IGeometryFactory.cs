using System;
using System.Collections;
using System.Collections.Generic;
using ns24;

namespace DotSpatial.Topology
{
	// Token: 0x0200053B RID: 1339
	public interface IGeometryFactory
	{
		// Token: 0x060022D4 RID: 8916
		int GetSrid();

		// Token: 0x060022D5 RID: 8917
		PrecisionModelType GetPrecisionModel();

		// Token: 0x060022D6 RID: 8918
		IGeometry BuildGeometry(IList ilist_0);

		// Token: 0x060022D7 RID: 8919
		IPoint CreatePoint(Coordinate coordinate_0);

		// Token: 0x060022D8 RID: 8920
		IMultiLineString CreateMultiLineString(IBasicLineString[] interface33_0);

		// Token: 0x060022D9 RID: 8921
		IGeometryCollection CreateGeometryCollection(IGeometry[] igeometry_0);

		// Token: 0x060022DA RID: 8922
		IMultiPolygon CreateMultiPolygon(IPolygon[] ipolygon_0);

		// Token: 0x060022DB RID: 8923
		ILinearRing CreateLinearRing(IList<Coordinate> ilist_0);

		// Token: 0x060022DC RID: 8924
		IMultiPoint CreateMultiPoint(IEnumerable<ICoordinate> ienumerable_0);

		// Token: 0x060022DD RID: 8925
		ILineString CreateLineString(IList<Coordinate> ilist_0);

		// Token: 0x060022DE RID: 8926
		IPolygon CreatePolygon(ILinearRing ilinearRing_0, ILinearRing[] ilinearRing_1);
	}
}

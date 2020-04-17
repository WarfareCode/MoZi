using System;
using ns14;

namespace GeoAPI.Geometries
{
	// Token: 0x0200045F RID: 1119
	public interface IGeometryFactory
	{
		// Token: 0x06001CA2 RID: 7330
		ICoordinateSequenceFactory imethod_0();

		// Token: 0x06001CA3 RID: 7331
		int imethod_1();

		// Token: 0x06001CA4 RID: 7332
		IPrecisionModel imethod_2();

		// Token: 0x06001CA5 RID: 7333
		IPoint imethod_3(ICoordinate icoordinate_0);

		// Token: 0x06001CA6 RID: 7334
		ILineString imethod_4(ICoordinate[] icoordinate_0);

		// Token: 0x06001CA7 RID: 7335
		ILinearRing imethod_5(ICoordinate[] icoordinate_0);

		// Token: 0x06001CA8 RID: 7336
		ILinearRing imethod_6(ICoordinateSequence icoordinateSequence_0);

		// Token: 0x06001CA9 RID: 7337
		IPolygon imethod_7(ILinearRing ilinearRing_0, ILinearRing[] ilinearRing_1);

		// Token: 0x06001CAA RID: 7338
		IMultiPoint imethod_8(IPoint[] ipoint_0);

		// Token: 0x06001CAB RID: 7339
		Interface25 imethod_9(ILineString[] ilineString_0);

		// Token: 0x06001CAC RID: 7340
		IMultiPolygon imethod_10(IPolygon[] ipolygon_0);

		// Token: 0x06001CAD RID: 7341
		IGeometryCollection imethod_11(IGeometry[] igeometry_0);
	}
}

using System;

namespace GeoAPI.Geometries
{
	// Token: 0x0200044D RID: 1101
	public interface IPolygon : IComparable<IGeometry>, IEquatable<IGeometry>, IComparable, ICloneable, IGeometry
	{
		// Token: 0x06001C34 RID: 7220
		ILineString imethod_11();

		// Token: 0x06001C35 RID: 7221
		ILinearRing imethod_12();

		// Token: 0x06001C36 RID: 7222
		int imethod_13();

		// Token: 0x06001C37 RID: 7223
		ILineString[] imethod_14();

		// Token: 0x06001C38 RID: 7224
		ILineString imethod_15(int int_0);

		// Token: 0x06001C39 RID: 7225
		ILinearRing[] imethod_16();
	}
}

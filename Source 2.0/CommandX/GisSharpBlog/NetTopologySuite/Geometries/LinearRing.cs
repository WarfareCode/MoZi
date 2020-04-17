using System;
using GeoAPI.Geometries;
using ns14;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000403 RID: 1027
	[Serializable]
	public sealed class LinearRing : LineString, IComparable<IGeometry>, IEquatable<IGeometry>, IComparable, ICloneable, IGeometry, Interface24, ILineString, ILinearRing
	{
		// Token: 0x060019A2 RID: 6562 RVA: 0x00010B24 File Offset: 0x0000ED24
		public LinearRing(ICoordinateSequence icoordinateSequence_0, IGeometryFactory igeometryFactory_0) : base(icoordinateSequence_0, igeometryFactory_0)
		{
			this.method_5();
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0009DDC4 File Offset: 0x0009BFC4
		private void method_5()
		{
			if (!this.imethod_10() && !base.imethod_12())
			{
				throw new ArgumentException("points must form a closed linestring");
			}
			if (base.imethod_11().Count >= 1 && base.imethod_11().Count <= 3)
			{
				throw new ArgumentException("Number of points must be 0 or >3");
			}
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool imethod_12()
		{
			return true;
		}
	}
}

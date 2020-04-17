using System;
using System.Collections;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x0200045C RID: 1116
	[Serializable]
	public sealed class MultiPolygon : GeometryCollection, IComparable<IGeometry>, IEquatable<IGeometry>, IEnumerable, IComparable, ICloneable, IGeometry, IGeometryCollection, IMultiPolygon
	{
		// Token: 0x06001C87 RID: 7303 RVA: 0x0000FCAF File Offset: 0x0000DEAF
		public MultiPolygon(IPolygon[] ipolygon_0, IGeometryFactory igeometryFactory_0) : base(ipolygon_0, igeometryFactory_0)
		{
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00011AB0 File Offset: 0x0000FCB0
		public override Dimensions imethod_7()
		{
			return Dimensions.Surface;
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0000945D File Offset: 0x0000765D
		public override Dimensions imethod_4()
		{
			return Dimensions.Curve;
		}

		// Token: 0x04000C7C RID: 3196
		public new static readonly IMultiPolygon Empty = new GeometryFactory().imethod_10(null);
	}
}

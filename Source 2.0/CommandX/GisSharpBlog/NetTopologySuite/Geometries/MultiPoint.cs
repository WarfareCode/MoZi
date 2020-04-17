using System;
using System.Collections;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x0200047D RID: 1149
	[Serializable]
	public sealed class MultiPoint : GeometryCollection, IComparable<IGeometry>, IEquatable<IGeometry>, IEnumerable, IComparable, ICloneable, IGeometry, IGeometryCollection, IMultiPoint
	{
		// Token: 0x06001DBD RID: 7613 RVA: 0x0000FCAF File Offset: 0x0000DEAF
		public MultiPoint(IPoint[] ipoint_0, IGeometryFactory igeometryFactory_0) : base(ipoint_0, igeometryFactory_0)
		{
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x000081A2 File Offset: 0x000063A2
		public override Dimensions imethod_7()
		{
			return Dimensions.Point;
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x0000FBB3 File Offset: 0x0000DDB3
		public override Dimensions imethod_4()
		{
			return Dimensions.False;
		}

		// Token: 0x04000D4C RID: 3404
		public new static readonly IMultiPoint Empty = new GeometryFactory().imethod_8(new IPoint[0]);
	}
}

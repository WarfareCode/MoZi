using System;
using GisSharpBlog.NetTopologySuite.IO;
using ns12;
using ns14;

namespace ns13
{
	// Token: 0x02000408 RID: 1032
	public sealed class Class638
	{
		// Token: 0x060019C2 RID: 6594 RVA: 0x0009E170 File Offset: 0x0009C370
		public static Class612 smethod_0(ShapeGeometryType shapeGeometryType_0)
		{
			Class612 @class;
			Class612 result;
			switch (shapeGeometryType_0)
			{
			case ShapeGeometryType.Point:
			case ShapeGeometryType.PointZ:
			case ShapeGeometryType.PointZM:
			case ShapeGeometryType.PointM:
				@class = new Class614();
				result = @class;
				return result;
			case ShapeGeometryType.LineString:
			case ShapeGeometryType.LineStringZ:
			case ShapeGeometryType.LineStringZM:
			case ShapeGeometryType.LineStringM:
				@class = new Class613();
				result = @class;
				return result;
			case ShapeGeometryType.Polygon:
			case ShapeGeometryType.PolygonZM:
			case ShapeGeometryType.PolygonZ:
			case ShapeGeometryType.PolygonM:
				@class = new Class616();
				result = @class;
				return result;
			case ShapeGeometryType.MultiPoint:
			case ShapeGeometryType.MultiPointZM:
			case ShapeGeometryType.MultiPointZ:
			case ShapeGeometryType.MultiPointM:
				@class = new Class615();
				result = @class;
				return result;
			}
			@class = null;
			result = @class;
			return result;
		}
	}
}

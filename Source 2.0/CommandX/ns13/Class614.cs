using System;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using GisSharpBlog.NetTopologySuite.IO;
using ns12;
using ns14;

namespace ns13
{
	// Token: 0x020003EE RID: 1006
	public sealed class Class614 : Class612
	{
		// Token: 0x0600190A RID: 6410 RVA: 0x000999E0 File Offset: 0x00097BE0
		public override IGeometry vmethod_0(Class661 class661_0, IGeometryFactory igeometryFactory_0)
		{
			int num = class661_0.ReadInt32();
			this.shapeGeometryType_0 = (ShapeGeometryType)Enum.Parse(typeof(ShapeGeometryType), num.ToString());
			IGeometry result;
			if (this.shapeGeometryType_0 == ShapeGeometryType.NullShape)
			{
				ICoordinate icoordinate_ = null;
				result = igeometryFactory_0.imethod_3(icoordinate_);
			}
			else
			{
				if (this.shapeGeometryType_0 != ShapeGeometryType.Point && this.shapeGeometryType_0 != ShapeGeometryType.PointM && this.shapeGeometryType_0 != ShapeGeometryType.PointZ && this.shapeGeometryType_0 != ShapeGeometryType.PointZM)
				{
					throw new Exception8("Attempting to load a point as point.");
				}
				double double_ = class661_0.ReadDouble();
				double double_2 = class661_0.ReadDouble();
				ICoordinate icoordinate_2 = new Coordinate(double_, double_2);
				igeometryFactory_0.imethod_2().imethod_3(icoordinate_2);
				IPoint point = igeometryFactory_0.imethod_3(icoordinate_2);
				base.method_4(class661_0);
				result = point;
			}
			return result;
		}
	}
}

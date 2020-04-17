using System;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using GisSharpBlog.NetTopologySuite.IO;
using ns12;

namespace ns14
{
	// Token: 0x02000441 RID: 1089
	public sealed class Class615 : Class612
	{
		// Token: 0x06001BDB RID: 7131 RVA: 0x000B28E8 File Offset: 0x000B0AE8
		public override IGeometry vmethod_0(Class661 class661_0, IGeometryFactory igeometryFactory_0)
		{
			int num = class661_0.ReadInt32();
			this.shapeGeometryType_0 = (ShapeGeometryType)Enum.Parse(typeof(ShapeGeometryType), num.ToString());
			IGeometry result;
			if (this.shapeGeometryType_0 == ShapeGeometryType.NullShape)
			{
				result = igeometryFactory_0.imethod_8(new IPoint[0]);
			}
			else
			{
				if (this.shapeGeometryType_0 != ShapeGeometryType.MultiPoint && this.shapeGeometryType_0 != ShapeGeometryType.MultiPointM && this.shapeGeometryType_0 != ShapeGeometryType.MultiPointZ && this.shapeGeometryType_0 != ShapeGeometryType.MultiPointZM)
				{
					throw new Exception8("Attempting to load a non-multipoint as multipoint.");
				}
				int num2 = base.method_6();
				this.double_0 = new double[num2];
				while (this.int_0 < 4)
				{
					double num3 = class661_0.ReadDouble();
					this.double_0[this.int_0] = num3;
					this.int_0++;
				}
				int num4 = class661_0.ReadInt32();
				IPoint[] array = new IPoint[num4];
				for (int i = 0; i < num4; i++)
				{
					double double_ = class661_0.ReadDouble();
					double double_2 = class661_0.ReadDouble();
					IPoint point = igeometryFactory_0.imethod_3(new Coordinate(double_, double_2));
					array[i] = point;
				}
				this.igeometry_0 = igeometryFactory_0.imethod_8(array);
				base.method_5(class661_0);
				result = this.igeometry_0;
			}
			return result;
		}
	}
}

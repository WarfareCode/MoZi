using System;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using GisSharpBlog.NetTopologySuite.IO;
using ns14;

namespace ns12
{
	// Token: 0x020003C5 RID: 965
	public sealed class Class613 : Class612
	{
		// Token: 0x060017E6 RID: 6118 RVA: 0x00095CDC File Offset: 0x00093EDC
		public override IGeometry vmethod_0(Class661 class661_0, IGeometryFactory igeometryFactory_0)
		{
			int num = class661_0.ReadInt32();
			this.shapeGeometryType_0 = (ShapeGeometryType)Enum.Parse(typeof(ShapeGeometryType), num.ToString());
			IGeometry result;
			if (this.shapeGeometryType_0 == ShapeGeometryType.NullShape)
			{
				result = igeometryFactory_0.imethod_9(null);
			}
			else
			{
				if (this.shapeGeometryType_0 != ShapeGeometryType.LineString && this.shapeGeometryType_0 != ShapeGeometryType.LineStringM && this.shapeGeometryType_0 != ShapeGeometryType.LineStringZ && this.shapeGeometryType_0 != ShapeGeometryType.LineStringZM)
				{
					throw new Exception8("Attempting to load a non-arc as arc.");
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
				int num5 = class661_0.ReadInt32();
				int[] array = new int[num4];
				for (int i = 0; i < num4; i++)
				{
					array[i] = class661_0.ReadInt32();
				}
				ILineString[] array2 = new ILineString[num4];
				for (int j = 0; j < num4; j++)
				{
					int num6 = array[j];
					int num7;
					if (j == num4 - 1)
					{
						num7 = num5;
					}
					else
					{
						num7 = array[j + 1];
					}
					int num8 = num7 - num6;
					Class662 @class = new Class662();
					@class.Capacity = num8;
					for (int i = 0; i < num8; i++)
					{
						double double_ = class661_0.ReadDouble();
						double double_2 = class661_0.ReadDouble();
						ICoordinate coordinate = new Coordinate(double_, double_2);
						igeometryFactory_0.imethod_2().imethod_3(coordinate);
						@class.Add(coordinate);
					}
					ILineString lineString = igeometryFactory_0.imethod_4(@class.ToArray());
					array2[j] = lineString;
				}
				this.igeometry_0 = igeometryFactory_0.imethod_9(array2);
				base.method_5(class661_0);
				result = this.igeometry_0;
			}
			return result;
		}
	}
}

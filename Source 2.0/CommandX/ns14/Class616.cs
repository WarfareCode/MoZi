using System;
using System.Collections;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using GisSharpBlog.NetTopologySuite.IO;
using ns12;
using ns13;

namespace ns14
{
	// Token: 0x0200047B RID: 1147
	public sealed class Class616 : Class612
	{
		// Token: 0x06001DBA RID: 7610 RVA: 0x000BFE5C File Offset: 0x000BE05C
		public override IGeometry vmethod_0(Class661 class661_0, IGeometryFactory igeometryFactory_0)
		{
			int num = class661_0.ReadInt32();
			this.shapeGeometryType_0 = (ShapeGeometryType)Enum.Parse(typeof(ShapeGeometryType), num.ToString());
			IGeometry result;
			if (this.shapeGeometryType_0 == ShapeGeometryType.NullShape)
			{
				result = igeometryFactory_0.imethod_7(null, null);
			}
			else
			{
				if (this.shapeGeometryType_0 != ShapeGeometryType.Polygon && this.shapeGeometryType_0 != ShapeGeometryType.PolygonM && this.shapeGeometryType_0 != ShapeGeometryType.PolygonZ && this.shapeGeometryType_0 != ShapeGeometryType.PolygonZM)
				{
					throw new Exception8("Attempting to load a non-polygon as polygon.");
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
				ArrayList arrayList = new ArrayList();
				ArrayList arrayList2 = new ArrayList();
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
						ICoordinate coordinate = new Coordinate(class661_0.ReadDouble(), class661_0.ReadDouble());
						igeometryFactory_0.imethod_2().imethod_3(coordinate);
						ICoordinate icoordinate_ = coordinate;
						@class.method_2(icoordinate_, true);
					}
					if (@class.Count > 2)
					{
						if (@class[0].imethod_7(@class[@class.Count - 1]) > 1E-05)
						{
							@class.Add(new Coordinate(@class[0]));
						}
						else if (@class[0].imethod_7(@class[@class.Count - 1]) > 0.0)
						{
							@class[@class.Count - 1].imethod_6(@class[0]);
						}
						ILinearRing value = igeometryFactory_0.imethod_5(@class.ToArray());
						if (num4 == 1)
						{
							arrayList.Add(value);
						}
						else if (Class628.smethod_3(@class.ToArray()))
						{
							arrayList2.Add(value);
						}
						else
						{
							arrayList.Add(value);
						}
					}
				}
				ArrayList arrayList3 = new ArrayList(arrayList.Count);
				for (int i = 0; i < arrayList.Count; i++)
				{
					arrayList3.Add(new ArrayList());
				}
				for (int i = 0; i < arrayList2.Count; i++)
				{
					ILinearRing linearRing = (ILinearRing)arrayList2[i];
					ILinearRing linearRing2 = null;
					IEnvelope envelope = null;
					IEnvelope ienvelope_ = linearRing.imethod_8();
					ICoordinate icoordinate_2 = linearRing.imethod_13(0);
					for (int k = 0; k < arrayList.Count; k++)
					{
						ILinearRing linearRing3 = (ILinearRing)arrayList[k];
						IEnvelope envelope2 = linearRing3.imethod_8();
						if (linearRing2 != null)
						{
							envelope = linearRing2.imethod_8();
						}
						bool flag = false;
						Class662 class2 = new Class662(linearRing3.imethod_6());
						if (envelope2.imethod_6(ienvelope_) && (Class628.smethod_1(icoordinate_2, class2.ToArray()) || this.method_7(icoordinate_2, class2)))
						{
							flag = true;
						}
						if (flag)
						{
							if (linearRing2 == null || envelope.imethod_6(envelope2))
							{
								linearRing2 = linearRing3;
							}
							ArrayList arrayList4 = (ArrayList)arrayList3[k];
							arrayList4.Add(linearRing);
						}
					}
				}
				IPolygon[] array2 = new IPolygon[arrayList.Count];
				for (int i = 0; i < arrayList.Count; i++)
				{
					array2[i] = igeometryFactory_0.imethod_7((ILinearRing)arrayList[i], (ILinearRing[])((ArrayList)arrayList3[i]).ToArray(typeof(ILinearRing)));
				}
				if (array2.Length == 1)
				{
					this.igeometry_0 = array2[0];
				}
				else
				{
					this.igeometry_0 = igeometryFactory_0.imethod_10(array2);
				}
				base.method_5(class661_0);
				result = this.igeometry_0;
			}
			return result;
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x000C02C8 File Offset: 0x000BE4C8
		private bool method_7(ICoordinate icoordinate_0, Class662 class662_0)
		{
			bool result;
			foreach (ICoordinate current in class662_0)
			{
				if (current.imethod_8(icoordinate_0))
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}
	}
}

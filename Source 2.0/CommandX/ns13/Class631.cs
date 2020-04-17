using System;
using System.Collections;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using ns14;

namespace ns13
{
	// Token: 0x020003F1 RID: 1009
	public sealed class Class631
	{
		// Token: 0x0600191C RID: 6428 RVA: 0x00099D4C File Offset: 0x00097F4C
		public Enum143 method_0(ICoordinate icoordinate_0, IGeometry igeometry_0)
		{
			Enum143 result;
			if (igeometry_0.imethod_10())
			{
				result = Enum143.const_2;
			}
			else if (igeometry_0 is ILineString)
			{
				result = this.method_3(icoordinate_0, (ILineString)igeometry_0);
			}
			else if (igeometry_0 is IPolygon)
			{
				result = this.method_5(icoordinate_0, (IPolygon)igeometry_0);
			}
			else
			{
				this.bool_0 = false;
				this.int_0 = 0;
				this.method_1(icoordinate_0, igeometry_0);
				if (Class640.smethod_0(this.int_0))
				{
					result = Enum143.const_1;
				}
				else if (this.int_0 > 0 || this.bool_0)
				{
					result = Enum143.const_0;
				}
				else
				{
					result = Enum143.const_2;
				}
			}
			return result;
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00099DF4 File Offset: 0x00097FF4
		private void method_1(ICoordinate icoordinate_0, IGeometry igeometry_0)
		{
			if (igeometry_0 is ILineString)
			{
				this.method_2(this.method_3(icoordinate_0, (ILineString)igeometry_0));
			}
			else if (igeometry_0 is Polygon)
			{
				this.method_2(this.method_5(icoordinate_0, (IPolygon)igeometry_0));
			}
			else if (igeometry_0 is Interface25)
			{
				Interface25 @interface = (Interface25)igeometry_0;
				IGeometry[] array = @interface.imethod_11();
				for (int i = 0; i < array.Length; i++)
				{
					ILineString ilineString_ = (ILineString)array[i];
					this.method_2(this.method_3(icoordinate_0, ilineString_));
				}
			}
			else if (igeometry_0 is IMultiPolygon)
			{
				IMultiPolygon multiPolygon = (IMultiPolygon)igeometry_0;
				IGeometry[] array = multiPolygon.imethod_11();
				for (int i = 0; i < array.Length; i++)
				{
					IPolygon ipolygon_ = (IPolygon)array[i];
					this.method_2(this.method_5(icoordinate_0, ipolygon_));
				}
			}
			else if (igeometry_0 is IGeometryCollection)
			{
				IEnumerator enumerator = new Class655((IGeometryCollection)igeometry_0);
				while (enumerator.MoveNext())
				{
					IGeometry geometry = (IGeometry)enumerator.Current;
					if (geometry != igeometry_0)
					{
						this.method_1(icoordinate_0, geometry);
					}
				}
			}
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000106F7 File Offset: 0x0000E8F7
		private void method_2(Enum143 enum143_0)
		{
			if (enum143_0 == Enum143.const_0)
			{
				this.bool_0 = true;
			}
			if (enum143_0 == Enum143.const_1)
			{
				this.int_0++;
			}
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00099F24 File Offset: 0x00098124
		private Enum143 method_3(ICoordinate icoordinate_0, ILineString ilineString_0)
		{
			ICoordinate[] array = ilineString_0.imethod_6();
			Enum143 result;
			if (!ilineString_0.imethod_12() && (icoordinate_0.Equals(array[0]) || icoordinate_0.Equals(array[array.Length - 1])))
			{
				result = Enum143.const_1;
			}
			else if (Class628.smethod_2(icoordinate_0, array))
			{
				result = Enum143.const_0;
			}
			else
			{
				result = Enum143.const_2;
			}
			return result;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00099F7C File Offset: 0x0009817C
		private Enum143 method_4(ICoordinate icoordinate_0, ILinearRing ilinearRing_0)
		{
			Enum143 result;
			if (Class628.smethod_1(icoordinate_0, ilinearRing_0.imethod_6()))
			{
				result = Enum143.const_0;
			}
			else if (Class628.smethod_2(icoordinate_0, ilinearRing_0.imethod_6()))
			{
				result = Enum143.const_1;
			}
			else
			{
				result = Enum143.const_2;
			}
			return result;
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00099FB8 File Offset: 0x000981B8
		private Enum143 method_5(ICoordinate icoordinate_0, IPolygon ipolygon_0)
		{
			Enum143 @enum;
			Enum143 result;
			if (ipolygon_0.imethod_10())
			{
				@enum = Enum143.const_2;
			}
			else
			{
				ILinearRing ilinearRing_ = ipolygon_0.imethod_12();
				Enum143 enum2 = this.method_4(icoordinate_0, ilinearRing_);
				if (enum2 == Enum143.const_2)
				{
					@enum = Enum143.const_2;
				}
				else if (enum2 == Enum143.const_1)
				{
					@enum = Enum143.const_1;
				}
				else
				{
					ILineString[] array = ipolygon_0.imethod_14();
					for (int i = 0; i < array.Length; i++)
					{
						ILinearRing ilinearRing_2 = (ILinearRing)array[i];
						Enum143 enum3 = this.method_4(icoordinate_0, ilinearRing_2);
						if (enum3 == Enum143.const_0)
						{
							result = Enum143.const_2;
							return result;
						}
						if (enum3 == Enum143.const_1)
						{
							result = Enum143.const_1;
							return result;
						}
					}
					@enum = Enum143.const_0;
				}
			}
			result = @enum;
			return result;
		}

		// Token: 0x04000A46 RID: 2630
		private bool bool_0;

		// Token: 0x04000A47 RID: 2631
		private int int_0;
	}
}

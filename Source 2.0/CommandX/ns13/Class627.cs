using System;
using System.Collections;
using GeoAPI.Geometries;
using ns14;

namespace ns13
{
	// Token: 0x020003E1 RID: 993
	public sealed class Class627
	{
		// Token: 0x060018BE RID: 6334 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class627()
		{
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00098B3C File Offset: 0x00096D3C
		public static Enum143 smethod_0(ICoordinate icoordinate_0, IGeometry igeometry_0)
		{
			Enum143 result;
			if (igeometry_0.imethod_10())
			{
				result = Enum143.const_2;
			}
			else if (Class627.smethod_1(icoordinate_0, igeometry_0))
			{
				result = Enum143.const_0;
			}
			else
			{
				result = Enum143.const_2;
			}
			return result;
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00098B70 File Offset: 0x00096D70
		private static bool smethod_1(ICoordinate icoordinate_0, IGeometry igeometry_0)
		{
			bool flag;
			bool result;
			if (igeometry_0 is IPolygon)
			{
				flag = Class627.smethod_2(icoordinate_0, (IPolygon)igeometry_0);
			}
			else
			{
				if (igeometry_0 is IGeometryCollection)
				{
					IEnumerator enumerator = new Class655((IGeometryCollection)igeometry_0);
					while (enumerator.MoveNext())
					{
						IGeometry geometry = (IGeometry)enumerator.Current;
						if (!object.ReferenceEquals(geometry, igeometry_0) && Class627.smethod_1(icoordinate_0, geometry))
						{
							result = true;
							return result;
						}
					}
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00098BF4 File Offset: 0x00096DF4
		public static bool smethod_2(ICoordinate icoordinate_0, IPolygon ipolygon_0)
		{
			bool flag;
			bool result;
			if (ipolygon_0.imethod_10())
			{
				flag = false;
			}
			else
			{
				ILinearRing linearRing = (ILinearRing)ipolygon_0.imethod_11();
				if (!Class628.smethod_1(icoordinate_0, linearRing.imethod_6()))
				{
					flag = false;
				}
				else
				{
					for (int i = 0; i < ipolygon_0.imethod_13(); i++)
					{
						ILinearRing linearRing2 = (ILinearRing)ipolygon_0.imethod_15(i);
						if (Class628.smethod_1(icoordinate_0, linearRing2.imethod_6()))
						{
							result = false;
							return result;
						}
					}
					flag = true;
				}
			}
			result = flag;
			return result;
		}
	}
}

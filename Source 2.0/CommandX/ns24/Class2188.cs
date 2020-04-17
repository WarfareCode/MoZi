using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns25;

namespace ns24
{
	// Token: 0x0200053F RID: 1343
	public sealed class Class2188
	{
		// Token: 0x0600230E RID: 8974 RVA: 0x00004A21 File Offset: 0x00002C21
		public Class2188()
		{
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x00014723 File Offset: 0x00012923
		public Class2188(IGeometryFactory igeometryFactory_1)
		{
			this.igeometryFactory_0 = igeometryFactory_1;
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x000DF654 File Offset: 0x000DD854
		public  IGeometry vmethod_0(IGeometry igeometry_0, Class2188.Interface32 interface32_0)
		{
			if (this.igeometryFactory_0 == null)
			{
				this.igeometryFactory_0 = igeometry_0.GetFactory();
			}
			IGeometry result;
			if (igeometry_0 is GeometryCollection)
			{
				result = this.method_1(igeometry_0, interface32_0);
			}
			else if (igeometry_0 is Polygon)
			{
				result = this.method_0(igeometry_0, interface32_0);
			}
			else if (igeometry_0 is Point)
			{
				result = interface32_0.imethod_0(igeometry_0, this.igeometryFactory_0);
			}
			else
			{
				if (!(igeometry_0 is LineString))
				{
					throw new Exception21();
				}
				result = interface32_0.imethod_0(igeometry_0, this.igeometryFactory_0);
			}
			return result;
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x000DF6EC File Offset: 0x000DD8EC
		private IPolygon method_0(IGeometry igeometry_0, Class2188.Interface32 interface32_0)
		{
			Polygon polygon = (Polygon)interface32_0.imethod_0(igeometry_0, this.igeometryFactory_0);
			IPolygon result;
			if (polygon.IsEmpty())
			{
				result = polygon;
			}
			else
			{
				LinearRing linearRing = (LinearRing)this.vmethod_0(polygon.GetShell(), interface32_0);
				if (linearRing.IsEmpty())
				{
					result = this.igeometryFactory_0.CreatePolygon(null, null);
				}
				else
				{
					ArrayList arrayList = new ArrayList();
					for (int i = 0; i < polygon.GetNumHoles(); i++)
					{
						LinearRing linearRing2 = (LinearRing)this.vmethod_0(polygon.GetInteriorRingN(i), interface32_0);
						if (!linearRing2.IsEmpty())
						{
							arrayList.Add(linearRing2);
						}
					}
					result = this.igeometryFactory_0.CreatePolygon(linearRing, (LinearRing[])arrayList.ToArray(typeof(LinearRing)));
				}
			}
			return result;
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x000DF7B4 File Offset: 0x000DD9B4
		private IGeometryCollection method_1(IGeometry igeometry_0, Class2188.Interface32 interface32_0)
		{
			GeometryCollection geometryCollection = (GeometryCollection)interface32_0.imethod_0(igeometry_0, this.igeometryFactory_0);
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < geometryCollection.GetNumGeometries(); i++)
			{
				IGeometry geometry = this.vmethod_0(geometryCollection.GetGeometryN(i), interface32_0);
				if (!geometry.IsEmpty())
				{
					arrayList.Add(geometry);
				}
			}
			IGeometryCollection result;
			if (geometryCollection is MultiPoint)
			{
				result = this.igeometryFactory_0.CreateMultiPoint((Point[])arrayList.ToArray(typeof(Point)));
			}
			else if (geometryCollection is MultiLineString)
			{
				result = this.igeometryFactory_0.CreateMultiLineString((LineString[])arrayList.ToArray(typeof(LineString)));
			}
			else if (geometryCollection is MultiPolygon)
			{
				result = this.igeometryFactory_0.CreateMultiPolygon((Polygon[])arrayList.ToArray(typeof(Polygon)));
			}
			else
			{
				result = this.igeometryFactory_0.CreateGeometryCollection((Geometry[])arrayList.ToArray(typeof(Geometry)));
			}
			return result;
		}

		// Token: 0x04001109 RID: 4361
		private IGeometryFactory igeometryFactory_0;

		// Token: 0x02000540 RID: 1344
		public interface Interface32
		{
			// Token: 0x06002313 RID: 8979
			IGeometry imethod_0(IGeometry igeometry_0, IGeometryFactory igeometryFactory_0);
		}

		// Token: 0x02000541 RID: 1345
		public abstract class Class2189 : Class2188.Interface32
		{
			// Token: 0x06002314 RID: 8980 RVA: 0x000DF8CC File Offset: 0x000DDACC
			public virtual IGeometry imethod_0(IGeometry igeometry_0, IGeometryFactory igeometryFactory_0)
			{
				IGeometry result;
				if (igeometry_0 is LinearRing)
				{
					result = igeometryFactory_0.CreateLinearRing(this.vmethod_0(igeometry_0.GetCoordinates(), igeometry_0));
				}
				else if (igeometry_0 is LineString)
				{
					result = igeometryFactory_0.CreateLineString(this.vmethod_0(igeometry_0.GetCoordinates(), igeometry_0));
				}
				else if (igeometry_0 is Point)
				{
					IList<Coordinate> list = this.vmethod_0(igeometry_0.GetCoordinates(), igeometry_0);
					result = igeometryFactory_0.CreatePoint((list.Count > 0) ? list[0] : null);
				}
				else
				{
					result = igeometry_0;
				}
				return result;
			}

			// Token: 0x06002315 RID: 8981
			public abstract IList<Coordinate> vmethod_0(IList<Coordinate> ilist_0, IGeometry igeometry_0);
		}
	}
}

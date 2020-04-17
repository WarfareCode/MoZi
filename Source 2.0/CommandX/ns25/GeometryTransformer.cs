using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns24;

namespace ns25
{
	// Token: 0x0200062A RID: 1578
	internal class GeometryTransformer
	{
		// Token: 0x060027FC RID: 10236 RVA: 0x000F18CC File Offset: 0x000EFACC
		public virtual IGeometry Transform(IGeometry anInputGeom)
		{
			this._inputGeom = anInputGeom;
			IGeometry result;
			if (anInputGeom is IPoint)
			{
				result = this.TransformPoint((Point)anInputGeom);
			}
			else if (anInputGeom is IMultiPoint)
			{
				result = this.TransformMultiPoint((IMultiPoint)anInputGeom);
			}
			else if (anInputGeom is ILinearRing)
			{
				result = this.TransformLineString((LinearRing)anInputGeom);
			}
			else if (anInputGeom is ILineString)
			{
				result = this.TransformLineString((LineString)anInputGeom);
			}
			else if (anInputGeom is IMultiLineString)
			{
				result = this.TransformMultiLineString((IMultiLineString)anInputGeom);
			}
			else if (anInputGeom is IPolygon)
			{
				result = this.TransformPolygon((Polygon)anInputGeom, null);
			}
			else if (anInputGeom is IMultiPolygon)
			{
				result = this.TransformMultiPolygon((IMultiPolygon)anInputGeom);
			}
			else
			{
				if (!(anInputGeom is IGeometryCollection))
				{
					throw new ArgumentException("Unknown Geometry subtype: " + anInputGeom.GetGeometryType());
				}
				result = this.TransformGeometryCollection((IGeometryCollection)anInputGeom, null);
			}
			return result;
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000F19E8 File Offset: 0x000EFBE8
		protected virtual IList<Coordinate> Copy(IList<Coordinate> seq)
		{
			return EnumerableExt.CloneList<Coordinate>(seq);
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000F1A00 File Offset: 0x000EFC00
		protected virtual IList<Coordinate> TransformCoordinates(IList<Coordinate> coords, IGeometry parent)
		{
			return this.Copy(coords);
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x000F1A18 File Offset: 0x000EFC18
		protected virtual IGeometry TransformPoint(IPoint ipoint_0)
		{
			return this._factory.CreatePoint(this.TransformCoordinates(ipoint_0.GetCoordinates(), ipoint_0)[0]);
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x000F1A48 File Offset: 0x000EFC48
		protected virtual IGeometry TransformMultiPoint(IMultiPoint imultiPoint_0)
		{
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < imultiPoint_0.GetNumGeometries(); i++)
			{
				IGeometry geometry = this.TransformPoint((Point)imultiPoint_0.GetGeometryN(i));
				if (geometry != null && !geometry.IsEmpty())
				{
					arrayList.Add(geometry);
				}
			}
			return this._factory.BuildGeometry(arrayList);
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x000F1AA8 File Offset: 0x000EFCA8
		protected virtual IGeometry TransformLinearRing(ILinearRing geom)
		{
			IList<Coordinate> list = this.TransformCoordinates(geom.GetCoordinates(), geom);
			int count = list.Count;
			IGeometry result;
			if (count > 0 && count < 4)
			{
				result = this._factory.CreateLineString(list);
			}
			else
			{
				result = this._factory.CreateLinearRing(list);
			}
			return result;
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x000F1AF8 File Offset: 0x000EFCF8
		protected virtual IGeometry TransformLineString(ILineString ilineString_0)
		{
			return this._factory.CreateLineString(this.TransformCoordinates(ilineString_0.GetCoordinates(), ilineString_0));
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x000F1B20 File Offset: 0x000EFD20
		protected virtual IGeometry TransformMultiLineString(IMultiLineString interface41_0)
		{
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < interface41_0.GetNumGeometries(); i++)
			{
				IGeometry geometry = this.TransformLineString((ILineString)interface41_0.GetGeometryN(i));
				if (geometry != null && !geometry.IsEmpty())
				{
					arrayList.Add(geometry);
				}
			}
			return this._factory.BuildGeometry(arrayList);
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x000F1B80 File Offset: 0x000EFD80
		protected virtual IGeometry TransformPolygon(IPolygon ipolygon_0, IGeometry igeometry_1)
		{
			bool flag = true;
			IGeometry geometry = this.TransformLinearRing(ipolygon_0.GetShell());
			if (geometry == null || !(geometry is LinearRing) || geometry.IsEmpty())
			{
				flag = false;
			}
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < ipolygon_0.GetNumHoles(); i++)
			{
				IGeometry geometry2 = this.TransformLinearRing((ILinearRing)ipolygon_0.GetInteriorRingN(i));
				if (geometry2 != null && !geometry2.IsEmpty())
				{
					if (!(geometry2 is LinearRing))
					{
						flag = false;
					}
					arrayList.Add(geometry2);
				}
			}
			IGeometry result;
			if (flag)
			{
				result = this._factory.CreatePolygon((ILinearRing)geometry, (ILinearRing[])arrayList.ToArray(typeof(ILinearRing)));
			}
			else
			{
				ArrayList arrayList2 = new ArrayList();
				if (geometry != null)
				{
					arrayList2.Add(geometry);
				}
				foreach (object current in arrayList)
				{
					arrayList2.Add(current);
				}
				result = this._factory.BuildGeometry(arrayList2);
			}
			return result;
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x000F1CB4 File Offset: 0x000EFEB4
		protected virtual IGeometry TransformMultiPolygon(IMultiPolygon imultiPolygon_0)
		{
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < imultiPolygon_0.GetNumGeometries(); i++)
			{
				IGeometry geometry = this.TransformPolygon((Polygon)imultiPolygon_0.GetGeometryN(i), imultiPolygon_0);
				if (geometry != null && !geometry.IsEmpty())
				{
					arrayList.Add(geometry);
				}
			}
			return this._factory.BuildGeometry(arrayList);
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x000F1D14 File Offset: 0x000EFF14
		protected virtual IGeometry TransformGeometryCollection(IGeometryCollection igeometryCollection_0, IGeometry igeometry_1)
		{
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < igeometryCollection_0.GetNumGeometries(); i++)
			{
				IGeometry geometry = this.Transform(igeometryCollection_0.GetGeometryN(i));
				if (geometry != null && !geometry.IsEmpty())
				{
					arrayList.Add(geometry);
				}
			}
			return this._factory.CreateGeometryCollection(GeometryFactory.ToGeometryArray(arrayList));
		}

		// Token: 0x0400133E RID: 4926
		private readonly GeometryFactory _factory = Geometry.DefaultFactory;

		// Token: 0x0400133F RID: 4927
		private IGeometry _inputGeom;
	}
}

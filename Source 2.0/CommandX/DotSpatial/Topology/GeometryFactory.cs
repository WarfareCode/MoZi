using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology.Utilities;
using ns24;
using ns25;
using ns26;

namespace DotSpatial.Topology
{
	// Token: 0x0200053E RID: 1342
	[Serializable]
	public sealed class GeometryFactory : IGeometryFactory
	{
		// Token: 0x060022F8 RID: 8952 RVA: 0x000146A4 File Offset: 0x000128A4
		public GeometryFactory(PrecisionModel precisionModel_0, int int_0, ICoordinateSequenceFactory icoordinateSequenceFactory_0)
		{
			this._precisionModel = precisionModel_0;
			this._coordinateSequenceFactory = icoordinateSequenceFactory_0;
			this._srid = int_0;
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x000146C1 File Offset: 0x000128C1
		public GeometryFactory(PrecisionModel precisionModel_0) : this(precisionModel_0, 0, GeometryFactory.GetDefaultCoordinateSequenceFactory())
		{
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x000146D0 File Offset: 0x000128D0
		public GeometryFactory(PrecisionModel precisionModel_0, int int_0) : this(precisionModel_0, int_0, GeometryFactory.GetDefaultCoordinateSequenceFactory())
		{
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x000146DF File Offset: 0x000128DF
		public GeometryFactory() : this(new PrecisionModel(), 0)
		{
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x000DF328 File Offset: 0x000DD528
		public  PrecisionModelType GetPrecisionModel()
		{
			return this._precisionModel.GetPrecisionModelType();
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x000DF344 File Offset: 0x000DD544
		public  int GetSrid()
		{
			return this._srid;
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x000DF35C File Offset: 0x000DD55C
		public  IPoint CreatePoint(Coordinate coordinate_0)
		{
			return new Point(coordinate_0, this);
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x000DF374 File Offset: 0x000DD574
		public  IMultiLineString CreateMultiLineString(IBasicLineString[] lineStrings)
		{
			IMultiLineString result;
			if (lineStrings == null)
			{
				result = new MultiLineString();
			}
			else
			{
				int num = lineStrings.Length;
				LineString[] array = new LineString[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = new LineString(lineStrings[i]);
				}
				result = new MultiLineString(array);
			}
			return result;
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x000DF3C0 File Offset: 0x000DD5C0
		public  IGeometryCollection CreateGeometryCollection(IGeometry[] geometries)
		{
			return new GeometryCollection(geometries, this);
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x000DF3D8 File Offset: 0x000DD5D8
		public  IMultiPolygon CreateMultiPolygon(IPolygon[] polygons)
		{
			return new MultiPolygon(polygons, this);
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x000DF3F0 File Offset: 0x000DD5F0
		public  ILinearRing CreateLinearRing(IList<Coordinate> coordinates)
		{
			return new LinearRing(coordinates);
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x000DF408 File Offset: 0x000DD608
		public  IMultiPoint CreateMultiPoint(IEnumerable<Coordinate> point)
		{
			return new MultiPoint(point, this);
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x000DF420 File Offset: 0x000DD620
		public IMultiPoint CreateMultiPoint(IEnumerable<ICoordinate> ienumerable_0)
		{
			return new MultiPoint(ienumerable_0);
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x000DF438 File Offset: 0x000DD638
		public  IPolygon CreatePolygon(ILinearRing shell, ILinearRing[] holes)
		{
			return new Polygon(shell, holes, this);
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x000DF450 File Offset: 0x000DD650
		public  IGeometry BuildGeometry(IList geomList)
		{
			Type type = null;
			bool flag = false;
			IEnumerator enumerator = geomList.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Geometry geometry = (Geometry)enumerator.Current;
				Type type2 = geometry.GetType();
				if (type == null)
				{
					type = type2;
				}
				if (type2 != type)
				{
					flag = true;
				}
			}
			IGeometry result;
			if (type == null)
			{
				result = this.CreateGeometryCollection(null);
			}
			else if (flag)
			{
				result = this.CreateGeometryCollection(GeometryFactory.ToGeometryArray(geomList));
			}
			else
			{
				IEnumerator enumerator2 = geomList.GetEnumerator();
				enumerator2.MoveNext();
				Geometry geometry2 = (Geometry)enumerator2.Current;
				if (geomList.Count <= 1)
				{
					result = geometry2;
				}
				else if (geometry2 is Polygon)
				{
					result = this.CreateMultiPolygon(GeometryFactory.ToPolygonArray(geomList));
				}
				else if (geometry2 is LineString)
				{
					result = this.CreateMultiLineString(GeometryFactory.ToLinearRingArray(geomList));
				}
				else
				{
					if (!(geometry2 is Point))
					{
						throw new Exception27();
					}
					result = new MultiPoint(GeometryFactory.ToPointArray(geomList));
				}
			}
			return result;
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x000DF56C File Offset: 0x000DD76C
		public  ILineString CreateLineString(IList<Coordinate> coordinates)
		{
			return new LineString(coordinates, this);
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x000DF584 File Offset: 0x000DD784
		public static IPoint[] ToPointArray(IList points)
		{
			return (Point[])new ArrayList(points).ToArray(typeof(Point));
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x000DF5B0 File Offset: 0x000DD7B0
		public static IGeometry[] ToGeometryArray(IList geometries)
		{
			IGeometry[] result;
			if (geometries == null)
			{
				result = null;
			}
			else
			{
				result = (Geometry[])new ArrayList(geometries).ToArray(typeof(Geometry));
			}
			return result;
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x000DF5E8 File Offset: 0x000DD7E8
		public static ILineString[] ToLinearRingArray(IList linearRings)
		{
			return (LineString[])new ArrayList(linearRings).ToArray(typeof(LineString));
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x000DF614 File Offset: 0x000DD814
		public static IPolygon[] ToPolygonArray(IList polygons)
		{
			return (Polygon[])new ArrayList(polygons).ToArray(typeof(Polygon));
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x000DF640 File Offset: 0x000DD840
		private static ICoordinateSequenceFactory GetDefaultCoordinateSequenceFactory()
		{
			return CoordinateArraySequenceFactory.Instance;
		}

		// Token: 0x04001102 RID: 4354
		private static GeometryFactory _default = new GeometryFactory();

		// Token: 0x04001103 RID: 4355
		private static GeometryFactory _floating = new GeometryFactory();

		// Token: 0x04001104 RID: 4356
		private static GeometryFactory _floatingSingle = new GeometryFactory(new PrecisionModel(PrecisionModelType.FloatingSingle));

		// Token: 0x04001105 RID: 4357
		private static GeometryFactory _fixed = new GeometryFactory(new PrecisionModel(PrecisionModelType.Fixed));

		// Token: 0x04001106 RID: 4358
		private readonly ICoordinateSequenceFactory _coordinateSequenceFactory;

		// Token: 0x04001107 RID: 4359
		private readonly PrecisionModel _precisionModel;

		// Token: 0x04001108 RID: 4360
		private readonly int _srid;
	}
}

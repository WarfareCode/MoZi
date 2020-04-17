using System;
using GeoAPI.Geometries;
using ns12;
using ns14;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000460 RID: 1120
	[Serializable]
	public sealed class GeometryFactory : IGeometryFactory
	{
		// Token: 0x06001CAE RID: 7342 RVA: 0x000B577C File Offset: 0x000B397C
		public IPrecisionModel imethod_2()
		{
			return this.precisionModel;
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x000B5794 File Offset: 0x000B3994
		public ICoordinateSequenceFactory imethod_0()
		{
			return this.coordinateSequenceFactory;
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x000B57AC File Offset: 0x000B39AC
		public int imethod_1()
		{
			return this.srid;
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00011E23 File Offset: 0x00010023
		public GeometryFactory(IPrecisionModel iprecisionModel_0, int int_0, ICoordinateSequenceFactory icoordinateSequenceFactory_0)
		{
			this.precisionModel = iprecisionModel_0;
			this.coordinateSequenceFactory = icoordinateSequenceFactory_0;
			this.srid = int_0;
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00011E40 File Offset: 0x00010040
		public GeometryFactory(IPrecisionModel iprecisionModel_0) : this(iprecisionModel_0, 0, GeometryFactory.smethod_0())
		{
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00011E4F File Offset: 0x0001004F
		public GeometryFactory(PrecisionModel precisionModel_0, int int_0) : this(precisionModel_0, int_0, GeometryFactory.smethod_0())
		{
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00011E5E File Offset: 0x0001005E
		public GeometryFactory() : this(new PrecisionModel(), 0)
		{
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x000B57C4 File Offset: 0x000B39C4
		public IPoint imethod_3(ICoordinate icoordinate_0)
		{
			return this.vmethod_0((icoordinate_0 != null) ? this.imethod_0().imethod_0(new ICoordinate[]
			{
				icoordinate_0
			}) : null);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x000B57F8 File Offset: 0x000B39F8
		public IPoint vmethod_0(ICoordinateSequence icoordinateSequence_0)
		{
			return new Point(icoordinateSequence_0, this);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x000B5810 File Offset: 0x000B3A10
		public ILineString imethod_4(ICoordinate[] icoordinate_0)
		{
			return this.vmethod_1((icoordinate_0 != null) ? this.imethod_0().imethod_0(icoordinate_0) : null);
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x000B5838 File Offset: 0x000B3A38
		public ILineString vmethod_1(ICoordinateSequence icoordinateSequence_0)
		{
			return new LineString(icoordinateSequence_0, this);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x000B5850 File Offset: 0x000B3A50
		public ILinearRing imethod_5(ICoordinate[] icoordinate_0)
		{
			return this.imethod_6((icoordinate_0 != null) ? this.imethod_0().imethod_0(icoordinate_0) : null);
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x000B5878 File Offset: 0x000B3A78
		public ILinearRing imethod_6(ICoordinateSequence icoordinateSequence_0)
		{
			return new LinearRing(icoordinateSequence_0, this);
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x000B5890 File Offset: 0x000B3A90
		public IPolygon imethod_7(ILinearRing ilinearRing_0, ILinearRing[] ilinearRing_1)
		{
			return new Polygon(ilinearRing_0, ilinearRing_1, this);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x000B58A8 File Offset: 0x000B3AA8
		public IMultiPoint imethod_8(IPoint[] ipoint_0)
		{
			return new MultiPoint(ipoint_0, this);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x000B58C0 File Offset: 0x000B3AC0
		public Interface25 imethod_9(ILineString[] ilineString_0)
		{
			return new Class595(ilineString_0, this);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x000B58D8 File Offset: 0x000B3AD8
		public IMultiPolygon imethod_10(IPolygon[] ipolygon_0)
		{
			return new MultiPolygon(ipolygon_0, this);
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x000B58F0 File Offset: 0x000B3AF0
		public IGeometryCollection imethod_11(IGeometry[] igeometry_0)
		{
			return new GeometryCollection(igeometry_0, this);
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x000B5908 File Offset: 0x000B3B08
		private static ICoordinateSequenceFactory smethod_0()
		{
			return CoordinateArraySequenceFactory.smethod_0();
		}

		// Token: 0x04000C7F RID: 3199
		public static readonly IGeometryFactory Default = new GeometryFactory();

		// Token: 0x04000C80 RID: 3200
		public static readonly IGeometryFactory Floating = GeometryFactory.Default;

		// Token: 0x04000C81 RID: 3201
		public static readonly IGeometryFactory FloatingSingle = new GeometryFactory(new PrecisionModel(PrecisionModels.FloatingSingle));

		// Token: 0x04000C82 RID: 3202
		public static readonly IGeometryFactory Fixed = new GeometryFactory(new PrecisionModel(PrecisionModels.Fixed));

		// Token: 0x04000C83 RID: 3203
		private IPrecisionModel precisionModel;

		// Token: 0x04000C84 RID: 3204
		private ICoordinateSequenceFactory coordinateSequenceFactory;

		// Token: 0x04000C85 RID: 3205
		private int srid;
	}
}

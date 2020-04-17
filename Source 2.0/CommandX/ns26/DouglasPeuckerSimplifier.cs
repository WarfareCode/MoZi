using System;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns25;

namespace ns26
{
	// Token: 0x020007F1 RID: 2033
	public sealed class DouglasPeuckerSimplifier
	{
		// Token: 0x06003223 RID: 12835 RVA: 0x0001B030 File Offset: 0x00019230
		public DouglasPeuckerSimplifier(Geometry geometry_1)
		{
			this._inputGeom = geometry_1;
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x0010D700 File Offset: 0x0010B900
		public  double GetDistanceTolerance()
		{
			return this._distanceTolerance;
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x0001B03F File Offset: 0x0001923F
		public  void SetDistanceTolerance(double value)
		{
			this._distanceTolerance = value;
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x0010D718 File Offset: 0x0010B918
		public static IGeometry Simplify(Geometry geom, double distanceTolerance)
		{
			DouglasPeuckerSimplifier douglasPeuckerSimplifier = new DouglasPeuckerSimplifier(geom);
			douglasPeuckerSimplifier.SetDistanceTolerance(distanceTolerance);
			return douglasPeuckerSimplifier.GetResultGeometry();
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x0010D73C File Offset: 0x0010B93C
		public  IGeometry GetResultGeometry()
		{
			return new DouglasPeuckerSimplifier.DpTransformer(this).Transform(this._inputGeom);
		}

		// Token: 0x04001746 RID: 5958
		private readonly Geometry _inputGeom;

		// Token: 0x04001747 RID: 5959
		private double _distanceTolerance;

		// Token: 0x020007F2 RID: 2034
		private sealed class DpTransformer : GeometryTransformer
		{
			// Token: 0x06003228 RID: 12840 RVA: 0x0001B048 File Offset: 0x00019248
			public DpTransformer(DouglasPeuckerSimplifier container)
			{
				this._container = container;
			}

			// Token: 0x06003229 RID: 12841 RVA: 0x0010D75C File Offset: 0x0010B95C
			protected override IList<Coordinate> TransformCoordinates(IList<Coordinate> ilist_0, IGeometry igeometry_1)
			{
				return DouglasPeuckerLineSimplifier.Simplify(ilist_0, this._container.GetDistanceTolerance());
			}

			// Token: 0x0600322A RID: 12842 RVA: 0x0010D77C File Offset: 0x0010B97C
			protected override IGeometry TransformPolygon(IPolygon ipolygon_0, IGeometry igeometry_1)
			{
				IGeometry geometry = base.TransformPolygon(ipolygon_0, igeometry_1);
				IGeometry result;
				if (igeometry_1 is MultiPolygon)
				{
					result = geometry;
				}
				else
				{
					result = DouglasPeuckerSimplifier.DpTransformer.CreateValidArea(geometry);
				}
				return result;
			}

			// Token: 0x0600322B RID: 12843 RVA: 0x0010D7AC File Offset: 0x0010B9AC
			protected override IGeometry TransformMultiPolygon(IMultiPolygon imultiPolygon_0)
			{
				IGeometry igeometry_ = base.TransformMultiPolygon(imultiPolygon_0);
				return DouglasPeuckerSimplifier.DpTransformer.CreateValidArea(igeometry_);
			}

			// Token: 0x0600322C RID: 12844 RVA: 0x0010D7CC File Offset: 0x0010B9CC
			private static IGeometry CreateValidArea(IGeometry igeometry_1)
			{
				return igeometry_1.Buffer(0.0);
			}

			// Token: 0x04001748 RID: 5960
			private readonly DouglasPeuckerSimplifier _container;
		}
	}
}

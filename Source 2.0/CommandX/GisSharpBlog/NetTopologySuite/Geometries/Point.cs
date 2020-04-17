using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000465 RID: 1125
	[Serializable]
	public sealed class Point : Geometry, IComparable<IGeometry>, IEquatable<IGeometry>, IComparable, ICloneable, IGeometry, IPoint
	{
		// Token: 0x06001CCD RID: 7373 RVA: 0x00011EF9 File Offset: 0x000100F9
		public Point(ICoordinateSequence icoordinateSequence_0, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (icoordinateSequence_0 == null)
			{
				icoordinateSequence_0 = igeometryFactory_0.imethod_0().imethod_0(new ICoordinate[0]);
			}
			this.coordinates = icoordinateSequence_0;
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x000B59C4 File Offset: 0x000B3BC4
		public override ICoordinate[] imethod_6()
		{
			return this.imethod_10() ? new ICoordinate[0] : new ICoordinate[]
			{
				this.imethod_5()
			};
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000B59F4 File Offset: 0x000B3BF4
		public override int imethod_3()
		{
			return this.imethod_10() ? 0 : 1;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00011F25 File Offset: 0x00010125
		public override bool imethod_10()
		{
			return this.imethod_5() == null;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x000081A2 File Offset: 0x000063A2
		public override Dimensions imethod_7()
		{
			return Dimensions.Point;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0000FBB3 File Offset: 0x0000DDB3
		public override Dimensions imethod_4()
		{
			return Dimensions.False;
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x000B5A10 File Offset: 0x000B3C10
		public override ICoordinate imethod_5()
		{
			return (this.coordinates.Count != 0) ? this.coordinates.imethod_0(0) : null;
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x000B5A3C File Offset: 0x000B3C3C
		protected override IEnvelope vmethod_1()
		{
			IEnvelope result;
			if (this.imethod_10())
			{
				result = new Envelope();
			}
			else
			{
				result = new Envelope(this.imethod_5().imethod_0(), this.imethod_5().imethod_0(), this.imethod_5().imethod_2(), this.imethod_5().imethod_2());
			}
			return result;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x000B5A94 File Offset: 0x000B3C94
		public  object Clone()
		{
			Point point = (Point)base.Clone();
			point.coordinates = (ICoordinateSequence)this.coordinates.Clone();
			return point;
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x000B5AC8 File Offset: 0x000B3CC8
		protected internal override int vmethod_2(object object_0)
		{
			Point point = (Point)object_0;
			return this.imethod_5().CompareTo(point.imethod_5());
		}

		// Token: 0x04000C88 RID: 3208
		private static readonly ICoordinate emptyCoordinate = null;

		// Token: 0x04000C89 RID: 3209
		public static readonly IPoint Empty = new GeometryFactory().imethod_3(Point.emptyCoordinate);

		// Token: 0x04000C8A RID: 3210
		private ICoordinateSequence coordinates;
	}
}

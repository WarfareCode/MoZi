using System;
using System.Collections;
using System.Collections.Generic;
using ns24;

namespace DotSpatial.Topology
{
	// Token: 0x02000604 RID: 1540
	[Serializable]
	public sealed class MultiPoint : GeometryCollection, IEnumerable, IComparable, ICloneable, IBasicGeometry, IGeometry, IGeometryCollection, IMultiPoint
	{
		// Token: 0x170002D2 RID: 722
		public new IPoint this[int index]
		{
			get
			{
				return base[index] as IPoint;
			}
			set
			{
				base[index] = value;
			}
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00015EBF File Offset: 0x000140BF
		public MultiPoint(IEnumerable<Coordinate> points, IGeometryFactory igeometryFactory_0) : base(MultiPoint.CastPoints(points), igeometryFactory_0)
		{
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00015E8F File Offset: 0x0001408F
		public MultiPoint(IBasicGeometry inBasicGeometry) : base(inBasicGeometry, Geometry.DefaultFactory)
		{
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00015ECE File Offset: 0x000140CE
		public MultiPoint(IEnumerable<ICoordinate> points) : base(MultiPoint.CastPoints(points), Geometry.DefaultFactory)
		{
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x000F0160 File Offset: 0x000EE360
		public override string GetGeometryType()
		{
			return "MultiPoint";
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool IsValid()
		{
			return true;
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x000F0174 File Offset: 0x000EE374
		private static IEnumerable<IBasicGeometry> CastPoints(IEnumerable<Coordinate> rawPoints)
		{
			List<IBasicGeometry> list = new List<IBasicGeometry>();
			foreach (Coordinate current in rawPoints)
			{
				list.Add(new Point(current));
			}
			return list;
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x000F01D0 File Offset: 0x000EE3D0
		private static IEnumerable<IBasicGeometry> CastPoints(IEnumerable<ICoordinate> rawPoints)
		{
			List<IBasicGeometry> list = new List<IBasicGeometry>();
			foreach (ICoordinate current in rawPoints)
			{
				list.Add(new Point(current));
			}
			return list;
		}

		// Token: 0x040012EA RID: 4842
		public new static readonly IMultiPoint Empty = new MultiPoint(new Point[0]);
	}
}

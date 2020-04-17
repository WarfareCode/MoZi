using System;
using System.Collections;
using ns24;

namespace DotSpatial.Topology
{
	// Token: 0x02000605 RID: 1541
	[Serializable]
	public sealed class MultiPolygon : GeometryCollection, IEnumerable, IComparable, ICloneable, IBasicGeometry, IGeometry, IGeometryCollection, IMultiPolygon
	{
		// Token: 0x06002738 RID: 10040 RVA: 0x00015E8F File Offset: 0x0001408F
		public MultiPolygon(IBasicGeometry interface30_0) : base(interface30_0, Geometry.DefaultFactory)
		{
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x00015EF3 File Offset: 0x000140F3
		public MultiPolygon(IPolygon[] ipolygon_0, IGeometryFactory igeometryFactory_0) : base(ipolygon_0, igeometryFactory_0)
		{
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x000F022C File Offset: 0x000EE42C
		public override string GetGeometryType()
		{
			return "MultiPolygon";
		}

		// Token: 0x040012EB RID: 4843
		public new static readonly IMultiPolygon Empty = new GeometryFactory().CreateMultiPolygon(null);
	}
}

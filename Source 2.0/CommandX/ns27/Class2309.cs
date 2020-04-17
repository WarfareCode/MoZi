using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;

namespace ns27
{
	// Token: 0x02000749 RID: 1865
	public sealed class Class2309 : IGeometryFilter
	{
		// Token: 0x06002E52 RID: 11858 RVA: 0x0001931D File Offset: 0x0001751D
		private Class2309(IList ilist_1)
		{
			this.ilist_0 = ilist_1;
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x0001932C File Offset: 0x0001752C
		public  void Filter(IGeometry igeometry_0)
		{
			if (igeometry_0 is Point || igeometry_0 is LineString || igeometry_0 is Polygon)
			{
				this.ilist_0.Add(new Class2312(igeometry_0, 0, igeometry_0.GetCoordinate()));
			}
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x00105B14 File Offset: 0x00103D14
		public static IList smethod_0(IGeometry igeometry_0)
		{
			IList list = new ArrayList();
			igeometry_0.Apply(new Class2309(list));
			return list;
		}

		// Token: 0x04001594 RID: 5524
		private readonly IList ilist_0;
	}
}

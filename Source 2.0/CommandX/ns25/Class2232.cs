using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;

namespace ns25
{
	// Token: 0x0200062D RID: 1581
	public sealed class Class2232 : IGeometryFilter
	{
		// Token: 0x0600280E RID: 10254 RVA: 0x00016383 File Offset: 0x00014583
		public Class2232(IList ilist_1)
		{
			this.ilist_0 = ilist_1;
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x00016392 File Offset: 0x00014592
		public  void Filter(IGeometry igeometry_0)
		{
			if (igeometry_0 is Polygon)
			{
				this.ilist_0.Add(igeometry_0);
			}
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x000F1DBC File Offset: 0x000EFFBC
		public static IList smethod_0(IGeometry igeometry_0)
		{
			IList list = new ArrayList();
			igeometry_0.Apply(new Class2232(list));
			return list;
		}

		// Token: 0x04001342 RID: 4930
		private readonly IList ilist_0;
	}
}

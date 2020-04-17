using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;

namespace ns25
{
	// Token: 0x0200062B RID: 1579
	public sealed class Class2230 : IGeometryComponentFilter
	{
		// Token: 0x06002808 RID: 10248 RVA: 0x0001632B File Offset: 0x0001452B
		public Class2230(IList ilist_1)
		{
			this.ilist_0 = ilist_1;
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x0001633A File Offset: 0x0001453A
		public  void Filter(IGeometry igeometry_0)
		{
			if (igeometry_0 is LineString)
			{
				this.ilist_0.Add(igeometry_0);
			}
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x000F1D74 File Offset: 0x000EFF74
		public static IList smethod_0(IGeometry igeometry_0)
		{
			IList list = new ArrayList();
			igeometry_0.Apply(new Class2230(list));
			return list;
		}

		// Token: 0x04001340 RID: 4928
		private readonly IList ilist_0;
	}
}

using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;

namespace ns25
{
	// Token: 0x0200062C RID: 1580
	public sealed class Class2231 : IGeometryFilter
	{
		// Token: 0x0600280B RID: 10251 RVA: 0x00016357 File Offset: 0x00014557
		public Class2231(IList ilist_1)
		{
			this.ilist_0 = ilist_1;
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x00016366 File Offset: 0x00014566
		public  void Filter(IGeometry igeometry_0)
		{
			if (igeometry_0 is Point)
			{
				this.ilist_0.Add(igeometry_0);
			}
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000F1D98 File Offset: 0x000EFF98
		public static IList smethod_0(IGeometry igeometry_0)
		{
			IList list = new ArrayList();
			igeometry_0.Apply(new Class2231(list));
			return list;
		}

		// Token: 0x04001341 RID: 4929
		private readonly IList ilist_0;
	}
}

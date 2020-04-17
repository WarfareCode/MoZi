using System;
using System.Collections.Generic;
using Command_Core;

namespace ns4
{
	// Token: 0x02000BFC RID: 3068
	public sealed class Class377 : FixedGeoPolygon
	{
		// Token: 0x06006615 RID: 26133 RVA: 0x0035037C File Offset: 0x0034E57C
		public override List<GeoPoint> vmethod_0()
		{
			return this.list_0;
		}

		// Token: 0x06006616 RID: 26134 RVA: 0x0002C2E7 File Offset: 0x0002A4E7
		public Class377(List<GeoPoint> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x04003828 RID: 14376
		private List<GeoPoint> list_0;
	}
}

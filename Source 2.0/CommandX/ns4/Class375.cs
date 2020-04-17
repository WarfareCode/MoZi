using System;
using System.Collections.Generic;
using Command_Core;
using Microsoft.VisualBasic;

namespace ns4
{
	// Token: 0x02000C08 RID: 3080
	public sealed class Class375 : FixedGeoPolygon
	{
		// Token: 0x0600667A RID: 26234 RVA: 0x00353C20 File Offset: 0x00351E20
		public override List<GeoPoint> vmethod_0()
		{
			if (Information.IsNothing(this.list_0))
			{
				this.list_0 = new List<GeoPoint>
				{
					new GeoPoint(26.16, 40.08),
					new GeoPoint(26.24, 40.08),
					new GeoPoint(26.66, 40.5),
					new GeoPoint(26.75, 40.5),
					new GeoPoint(26.75, 40.33),
					new GeoPoint(26.66, 40.33),
					new GeoPoint(26.25, 39.91),
					new GeoPoint(26.16, 39.91)
				};
			}
			return this.list_0;
		}

		// Token: 0x0400384E RID: 14414
		private List<GeoPoint> list_0;
	}
}

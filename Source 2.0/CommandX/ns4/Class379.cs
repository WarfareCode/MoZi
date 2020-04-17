using System;
using System.Collections.Generic;
using Command_Core;
using Microsoft.VisualBasic;

namespace ns4
{
	// Token: 0x02000CB5 RID: 3253
	public sealed class Class379 : FixedGeoPolygon
	{
		// Token: 0x06006B61 RID: 27489 RVA: 0x003A9434 File Offset: 0x003A7634
		public override List<GeoPoint> vmethod_0()
		{
			if (Information.IsNothing(this.list_0))
			{
				this.list_0 = new List<GeoPoint>
				{
					new GeoPoint(32.25, 31.3),
					new GeoPoint(32.25, 30.3),
					new GeoPoint(32.3, 30.25),
					new GeoPoint(32.35, 30.2),
					new GeoPoint(32.4, 30.15),
					new GeoPoint(32.45, 30.1),
					new GeoPoint(32.45, 29.9),
					new GeoPoint(32.6, 29.9),
					new GeoPoint(32.6, 30.25),
					new GeoPoint(32.45, 30.4),
					new GeoPoint(32.45, 31.3)
				};
			}
			return this.list_0;
		}

		// Token: 0x04003D84 RID: 15748
		private List<GeoPoint> list_0;
	}
}

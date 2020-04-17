using System;
using System.Collections.Generic;
using Command_Core;
using Microsoft.VisualBasic;

namespace ns4
{
	// Token: 0x02000BFB RID: 3067
	public sealed class Class376 : FixedGeoPolygon
	{
		// Token: 0x06006613 RID: 26131 RVA: 0x00350240 File Offset: 0x0034E440
		public override List<GeoPoint> vmethod_0()
		{
			if (Information.IsNothing(this.list_0))
			{
				this.list_0 = new List<GeoPoint>
				{
					new GeoPoint(29.08, 41.25),
					new GeoPoint(29.25, 41.25),
					new GeoPoint(29.16, 41.16),
					new GeoPoint(29.16, 41.08),
					new GeoPoint(29.0, 40.91),
					new GeoPoint(29.0, 40.91),
					new GeoPoint(28.91, 41.0),
					new GeoPoint(29.0, 41.08),
					new GeoPoint(29.0, 41.16)
				};
			}
			return this.list_0;
		}

		// Token: 0x04003827 RID: 14375
		private List<GeoPoint> list_0;
	}
}

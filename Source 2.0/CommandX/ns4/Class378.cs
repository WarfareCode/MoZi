using System;
using System.Collections.Generic;
using Command_Core;
using Microsoft.VisualBasic;

namespace ns4
{
	// Token: 0x02000CB4 RID: 3252
	public sealed class Class378 : FixedGeoPolygon
	{
		// Token: 0x06006B5F RID: 27487 RVA: 0x003A9144 File Offset: 0x003A7344
		public override List<GeoPoint> vmethod_0()
		{
			if (Information.IsNothing(this.list_0))
			{
				this.list_0 = new List<GeoPoint>
				{
					new GeoPoint(-79.9, 9.45),
					new GeoPoint(-79.95, 9.4),
					new GeoPoint(-79.95, 9.4),
					new GeoPoint(-79.95, 9.35),
					new GeoPoint(-79.95, 9.3),
					new GeoPoint(-79.95, 9.25),
					new GeoPoint(-79.9, 9.2),
					new GeoPoint(-79.85, 9.15),
					new GeoPoint(-79.8, 9.1),
					new GeoPoint(-79.75, 9.05),
					new GeoPoint(-79.7, 9.0),
					new GeoPoint(-79.65, 8.95),
					new GeoPoint(-79.6, 8.9),
					new GeoPoint(-79.55, 8.85),
					new GeoPoint(-79.48, 8.92),
					new GeoPoint(-79.55, 9.0),
					new GeoPoint(-79.6, 9.05),
					new GeoPoint(-79.65, 9.1),
					new GeoPoint(-79.7, 9.15),
					new GeoPoint(-79.75, 9.2),
					new GeoPoint(-79.8, 9.25),
					new GeoPoint(-79.85, 9.3),
					new GeoPoint(-79.85, 9.35),
					new GeoPoint(-79.85, 9.4)
				};
			}
			return this.list_0;
		}

		// Token: 0x04003D83 RID: 15747
		private List<GeoPoint> list_0;
	}
}

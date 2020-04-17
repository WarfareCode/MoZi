using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;

namespace ns26
{
	// Token: 0x020007F6 RID: 2038
	public sealed class Class2345
	{
		// Token: 0x04001751 RID: 5969
		private IDictionary idictionary_0;

		// Token: 0x020007F7 RID: 2039
		private sealed class Class2346 : IGeometryComponentFilter
		{
			// Token: 0x06003233 RID: 12851 RVA: 0x0010D8A4 File Offset: 0x0010BAA4
			public void Filter(IGeometry igeometry_0)
			{
				if (igeometry_0 is LinearRing)
				{
					Class2344 value = new Class2344((LineString)igeometry_0, 4);
					this.class2345_0.idictionary_0.Add(igeometry_0, value);
				}
				else if (igeometry_0 is LineString)
				{
					Class2344 value2 = new Class2344((LineString)igeometry_0, 2);
					this.class2345_0.idictionary_0.Add(igeometry_0, value2);
				}
			}

			// Token: 0x04001752 RID: 5970
			private readonly Class2345 class2345_0;
		}
	}
}

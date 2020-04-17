using System;
using System.Collections;
using DotSpatial.Topology;

namespace ns26
{
	// Token: 0x02000792 RID: 1938
	public sealed class Class2326
	{
		// Token: 0x06003017 RID: 12311 RVA: 0x001096B0 File Offset: 0x001078B0
		public Class2326()
		{
			this.class2325_0 = new Class2325(this);
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x00019DF4 File Offset: 0x00017FF4
		public  void vmethod_0(IGeometry igeometry_0)
		{
			igeometry_0.Apply(this.class2325_0);
		}

		// Token: 0x04001671 RID: 5745
		private readonly Class2321 class2321_0 = new Class2321(new GeometryFactory());

		// Token: 0x04001672 RID: 5746
		private readonly Class2325 class2325_0;

		// Token: 0x04001673 RID: 5747
		private IList ilist_0 = new ArrayList();

		// Token: 0x04001674 RID: 5748
		private IList ilist_1 = new ArrayList();

		// Token: 0x04001675 RID: 5749
		private IList ilist_2 = new ArrayList();
	}
}

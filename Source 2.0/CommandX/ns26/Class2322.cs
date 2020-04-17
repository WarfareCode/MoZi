using System;
using DotSpatial.Topology;
using ns24;
using ns27;

namespace ns26
{
	// Token: 0x02000777 RID: 1911
	public sealed class Class2322
	{
		// Token: 0x06002F42 RID: 12098 RVA: 0x000199C4 File Offset: 0x00017BC4
		private void method_0(LineString lineString_0)
		{
			if (this.igeometryFactory_0 == null)
			{
				this.igeometryFactory_0 = lineString_0.GetFactory();
			}
			this.class2320_0.vmethod_4(lineString_0);
		}

		// Token: 0x040015F0 RID: 5616
		private readonly Class2320 class2320_0 = new Class2320();

		// Token: 0x040015F1 RID: 5617
		private IGeometryFactory igeometryFactory_0;

		// Token: 0x02000778 RID: 1912
		private sealed class Class2323 : IGeometryComponentFilter
		{
			// Token: 0x06002F44 RID: 12100 RVA: 0x000199FF File Offset: 0x00017BFF
			public void Filter(IGeometry igeometry_0)
			{
				if (igeometry_0 is LineString)
				{
					this.class2322_0.method_0((LineString)igeometry_0);
				}
			}

			// Token: 0x040015F2 RID: 5618
			private readonly Class2322 class2322_0;
		}
	}
}

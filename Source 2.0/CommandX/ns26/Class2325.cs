using System;
using DotSpatial.Topology;
using ns24;

namespace ns26
{
	// Token: 0x0200078E RID: 1934
	public sealed class Class2325 : IGeometryComponentFilter
	{
		// Token: 0x06002FB6 RID: 12214 RVA: 0x00019CB6 File Offset: 0x00017EB6
		public Class2325(Class2326 class2326_1)
		{
			this.class2326_0 = class2326_1;
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x00107F40 File Offset: 0x00106140
		public  void Filter(IGeometry igeometry_0)
		{
			ILineString lineString = igeometry_0 as ILineString;
			if (lineString != null)
			{
				this.class2326_0.vmethod_0(lineString);
			}
		}

		// Token: 0x04001615 RID: 5653
		private readonly Class2326 class2326_0;
	}
}

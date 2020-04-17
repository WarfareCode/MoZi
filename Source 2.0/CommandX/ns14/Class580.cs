using System;
using GeoAPI.Geometries;
using ns12;
using ns13;

namespace ns14
{
	// Token: 0x0200043C RID: 1084
	public sealed class Class580 : Class579
	{
		// Token: 0x06001BCB RID: 7115 RVA: 0x00011755 File Offset: 0x0000F955
		public Class580(ICoordinate icoordinate_1, Class624 class624_1) : base(icoordinate_1, class624_1)
		{
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0001175F File Offset: 0x0000F95F
		public override void vmethod_1(Class666 class666_0)
		{
			class666_0.method_2(this.class652_0.method_2(0), this.class652_0.method_2(1), Dimensions.Point);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00011780 File Offset: 0x0000F980
		public void method_7(Class666 class666_0)
		{
			((Class625)this.class624_0).method_6(class666_0);
		}
	}
}

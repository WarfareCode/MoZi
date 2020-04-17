using System;
using DotSpatial.Topology;
using ns23;

namespace ns25
{
	// Token: 0x0200063A RID: 1594
	public class Class2242
	{
		// Token: 0x06002876 RID: 10358 RVA: 0x0001667D File Offset: 0x0001487D
		public  void vmethod_0(Class2257 class2257_0, int int_0)
		{
			this.lineSegment_0 = class2257_0.vmethod_4(int_0);
			this.vmethod_1(this.lineSegment_0);
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public  void vmethod_1(LineSegment lineSegment_1)
		{
		}

		// Token: 0x0400135C RID: 4956
		public Envelope envelope_0 = new Envelope();

		// Token: 0x0400135D RID: 4957
		private LineSegment lineSegment_0;
	}
}

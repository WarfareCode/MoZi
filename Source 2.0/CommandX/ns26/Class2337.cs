using System;
using DotSpatial.Topology;
using ns24;

namespace ns26
{
	// Token: 0x020007EA RID: 2026
	public sealed class Class2337
	{
		// Token: 0x0400173A RID: 5946
		private readonly Class2337.Class2338 class2338_0 = new Class2337.Class2338();

		// Token: 0x020007EB RID: 2027
		public sealed class Class2338 : ICoordinateFilter
		{
			// Token: 0x06003216 RID: 12822 RVA: 0x0001AF70 File Offset: 0x00019170
			public  void Filter(Coordinate coordinate_0)
			{
				this.class2336_0.vmethod_0(coordinate_0.X);
				this.class2336_1.vmethod_0(coordinate_0.Y);
			}

			// Token: 0x0400173B RID: 5947
			private readonly Class2336 class2336_0 = new Class2336();

			// Token: 0x0400173C RID: 5948
			private readonly Class2336 class2336_1 = new Class2336();
		}

		// Token: 0x020007EC RID: 2028
		private sealed class Class2339 : ICoordinateFilter
		{
			// Token: 0x06003218 RID: 12824 RVA: 0x0001AFB2 File Offset: 0x000191B2
			public void Filter(Coordinate coordinate_1)
			{
				coordinate_1.X += this.coordinate_0.X;
				coordinate_1.Y += this.coordinate_0.Y;
			}

			// Token: 0x0400173D RID: 5949
			private readonly Coordinate coordinate_0;
		}
	}
}

using System;
using DotSpatial.Topology;
using ns23;
using ns25;

namespace ns27
{
	// Token: 0x02000709 RID: 1801
	public sealed class Class2297
	{
		// Token: 0x06002CE5 RID: 11493 RVA: 0x00018686 File Offset: 0x00016886
		public Class2297(ISpatialIndex interface44_0)
		{
			this.class2274_0 = (Class2274)interface44_0;
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x00102C60 File Offset: 0x00100E60
		public bool method_0(Class2296 class2296_0, Class2295 class2295_0, int int_0)
		{
			Envelope envelope = class2296_0.method_1();
			Class2297.Class2244 @class = new Class2297.Class2244(class2296_0, class2295_0, int_0);
			this.class2274_0.vmethod_11(envelope, new Class2297.Class2298(envelope, @class));
			return @class.method_0();
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x0001869A File Offset: 0x0001689A
		public bool method_1(Class2296 class2296_0)
		{
			return this.method_0(class2296_0, null, -1);
		}

		// Token: 0x04001513 RID: 5395
		private readonly Class2274 class2274_0;

		// Token: 0x0200070A RID: 1802
		public sealed class Class2244 : Class2242
		{
			// Token: 0x06002CE8 RID: 11496 RVA: 0x000186A5 File Offset: 0x000168A5
			public Class2244(Class2296 class2296_1, Class2295 class2295_1, int int_1)
			{
				this.class2296_0 = class2296_1;
				this.class2295_0 = class2295_1;
				this.int_0 = int_1;
			}

			// Token: 0x06002CE9 RID: 11497 RVA: 0x000186C2 File Offset: 0x000168C2
			public bool method_0()
			{
				return this.bool_0;
			}

			// Token: 0x06002CEA RID: 11498 RVA: 0x00102C98 File Offset: 0x00100E98
			public  void vmethod_0(Class2257 class2257_0, int int_1)
			{
				Class2295 @class = (Class2295)class2257_0.vmethod_2();
				if (this.class2295_0 == null || @class != this.class2295_0 || int_1 != this.int_0)
				{
					this.bool_0 = Class2300.smethod_1(this.class2296_0, @class, int_1);
				}
			}

			// Token: 0x04001514 RID: 5396
			private readonly Class2296 class2296_0;

			// Token: 0x04001515 RID: 5397
			private readonly Class2295 class2295_0;

			// Token: 0x04001516 RID: 5398
			private readonly int int_0;

			// Token: 0x04001517 RID: 5399
			private bool bool_0;
		}

		// Token: 0x0200070B RID: 1803
		private sealed class Class2298 : Interface43
		{
			// Token: 0x06002CEB RID: 11499 RVA: 0x000186CA File Offset: 0x000168CA
			public Class2298(Envelope envelope_1, Class2297.Class2244 class2244_1)
			{
				this.envelope_0 = envelope_1;
				this.class2244_0 = class2244_1;
			}

			// Token: 0x06002CEC RID: 11500 RVA: 0x00102CE8 File Offset: 0x00100EE8
			public void VisitItem(object object_0)
			{
				Class2257 @class = (Class2257)object_0;
				@class.vmethod_5(this.envelope_0, this.class2244_0);
			}

			// Token: 0x04001518 RID: 5400
			private readonly Class2297.Class2244 class2244_0;

			// Token: 0x04001519 RID: 5401
			private readonly Envelope envelope_0;
		}
	}
}

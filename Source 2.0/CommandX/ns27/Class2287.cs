using System;
using System.Collections;
using ns23;

namespace ns27
{
	// Token: 0x020006E3 RID: 1763
	public sealed class Class2287 : Class2286
	{
		// Token: 0x06002C37 RID: 11319 RVA: 0x00017FD4 File Offset: 0x000161D4
		public Class2287()
		{
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x00017FF2 File Offset: 0x000161F2
		public Class2287(Interface48 interface48_1) : base(interface48_1)
		{
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x00101594 File Offset: 0x000FF794
		public ISpatialIndex method_2()
		{
			return this.interface44_0;
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x001015AC File Offset: 0x000FF7AC
		public override IList imethod_1()
		{
			return Class2295.smethod_0(this.ilist_1);
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x001015C8 File Offset: 0x000FF7C8
		public override void imethod_0(IList ilist_2)
		{
			this.ilist_1 = ilist_2;
			foreach (object current in ilist_2)
			{
				this.method_4((Class2295)current);
			}
			this.method_3();
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x00101630 File Offset: 0x000FF830
		private void method_3()
		{
			Class2259 class2259_ = new Class2287.Class2260(base.method_0());
			foreach (object current in this.ilist_0)
			{
				Class2257 @class = (Class2257)current;
				IList list = this.interface44_0.Query(@class.vmethod_3());
				foreach (object current2 in list)
				{
					Class2257 class2 = (Class2257)current2;
					if (class2.vmethod_0() > @class.vmethod_0())
					{
						@class.vmethod_6(class2, class2259_);
						this.int_1++;
					}
				}
			}
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00101728 File Offset: 0x000FF928
		private void method_4(Class2295 class2295_0)
		{
			IList list = Class2258.smethod_2(class2295_0.method_3(), class2295_0);
			foreach (object current in list)
			{
				Class2257 @class = (Class2257)current;
				@class.vmethod_1(this.int_0++);
				this.interface44_0.Insert(@class.vmethod_3(), @class);
				this.ilist_0.Add(@class);
			}
		}

		// Token: 0x040014D8 RID: 5336
		private readonly ISpatialIndex interface44_0 = new Class2274();

		// Token: 0x040014D9 RID: 5337
		private readonly IList ilist_0 = new ArrayList();

		// Token: 0x040014DA RID: 5338
		private int int_0;

		// Token: 0x040014DB RID: 5339
		private int int_1;

		// Token: 0x040014DC RID: 5340
		private IList ilist_1;

		// Token: 0x020006E4 RID: 1764
		public sealed class Class2260 : Class2259
		{
			// Token: 0x06002C3E RID: 11326 RVA: 0x00018011 File Offset: 0x00016211
			public Class2260(Interface48 interface48_1)
			{
				this.interface48_0 = interface48_1;
			}

			// Token: 0x06002C3F RID: 11327 RVA: 0x001017C4 File Offset: 0x000FF9C4
			public  void vmethod_0(Class2257 class2257_0, int int_0, Class2257 class2257_1, int int_1)
			{
				Class2295 class2295_ = (Class2295)class2257_0.vmethod_2();
				Class2295 class2295_2 = (Class2295)class2257_1.vmethod_2();
				this.interface48_0.imethod_0(class2295_, int_0, class2295_2, int_1);
			}

			// Token: 0x040014DD RID: 5341
			private readonly Interface48 interface48_0;
		}
	}
}

using System;
using GeoAPI.Geometries;
using ns14;

namespace ns12
{
	// Token: 0x02000369 RID: 873
	public abstract class Class578
	{
		// Token: 0x060014AE RID: 5294 RVA: 0x0000E9D6 File Offset: 0x0000CBD6
		public Class578()
		{
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x000899D0 File Offset: 0x00087BD0
		public Class652 method_0()
		{
			return this.class652_0;
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0000E9FA File Offset: 0x0000CBFA
		public void method_1(Class652 class652_1)
		{
			this.class652_0 = class652_1;
		}

		// Token: 0x060014B1 RID: 5297
		public abstract ICoordinate vmethod_0();

		// Token: 0x060014B2 RID: 5298
		public abstract void vmethod_1(Class666 class666_0);

		// Token: 0x060014B3 RID: 5299
		public abstract bool vmethod_2();

		// Token: 0x060014B4 RID: 5300 RVA: 0x0000EA03 File Offset: 0x0000CC03
		public void method_2(Class666 class666_0)
		{
			Class570.smethod_0(this.class652_0.method_7() >= 2, "found partial label");
			this.vmethod_1(class666_0);
		}

		// Token: 0x040008C4 RID: 2244
		protected Class652 class652_0;

		// Token: 0x040008C5 RID: 2245
		private bool bool_0 = false;

		// Token: 0x040008C6 RID: 2246
		private bool bool_1 = false;

		// Token: 0x040008C7 RID: 2247
		private bool bool_2 = false;

		// Token: 0x040008C8 RID: 2248
		private bool bool_3 = false;
	}
}

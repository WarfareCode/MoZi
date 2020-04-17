using System;
using System.Collections;

namespace ns23
{
	// Token: 0x020006B7 RID: 1719
	public sealed class Class2273 : Class2272
	{
		// Token: 0x06002B77 RID: 11127 RVA: 0x00017AA3 File Offset: 0x00015CA3
		public Class2273() : this(10)
		{
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x00017AAD File Offset: 0x00015CAD
		public Class2273(int int_1) : base(int_1)
		{
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x00100620 File Offset: 0x000FE820
		protected override Class2272.Interface46 vmethod_1()
		{
			return this.interface46_0;
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x00100638 File Offset: 0x000FE838
		protected override Class2269 vmethod_3(int int_1)
		{
			return new Class2273.Class2270(int_1);
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x00100650 File Offset: 0x000FE850
		public  IList vmethod_11(double double_0)
		{
			return this.vmethod_12(double_0, double_0);
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x00100668 File Offset: 0x000FE868
		public  IList vmethod_12(double double_0, double double_1)
		{
			return base.vmethod_8(new Class2275(Math.Min(double_0, double_1), Math.Max(double_0, double_1)));
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x00100690 File Offset: 0x000FE890
		protected override IComparer vmethod_10()
		{
			return this.icomparer_0;
		}

		// Token: 0x04001494 RID: 5268
		private readonly IComparer icomparer_0 = new Class2273.Class2277();

		// Token: 0x04001495 RID: 5269
		private readonly Class2272.Interface46 interface46_0 = new Class2273.Class2278();

		// Token: 0x020006B8 RID: 1720
		private sealed class Class2277 : IComparer
		{
			// Token: 0x06002B7E RID: 11134 RVA: 0x001006A8 File Offset: 0x000FE8A8
			public int Compare(object x, object y)
			{
				return new Class2273().vmethod_6(((Class2275)((Interface45)x).imethod_0()).vmethod_0(), ((Class2275)((Interface45)y).imethod_0()).vmethod_0());
			}
		}

		// Token: 0x020006B9 RID: 1721
		private sealed class Class2270 : Class2269
		{
			// Token: 0x06002B80 RID: 11136 RVA: 0x00017ACC File Offset: 0x00015CCC
			public Class2270(int int_1) : base(int_1)
			{
			}

			// Token: 0x06002B81 RID: 11137 RVA: 0x001006EC File Offset: 0x000FE8EC
			protected override object vmethod_1()
			{
				Class2275 @class = null;
				IEnumerator enumerator = this.vmethod_0().GetEnumerator();
				while (enumerator.MoveNext())
				{
					Interface45 @interface = (Interface45)enumerator.Current;
					if (@class == null)
					{
						@class = new Class2275((Class2275)@interface.imethod_0());
					}
					else
					{
						@class.vmethod_1((Class2275)@interface.imethod_0());
					}
				}
				return @class;
			}
		}

		// Token: 0x020006BA RID: 1722
		private sealed class Class2278 : Class2272.Interface46
		{
			// Token: 0x06002B82 RID: 11138 RVA: 0x00017AD5 File Offset: 0x00015CD5
			public bool imethod_0(object object_0, object object_1)
			{
				return ((Class2275)object_0).vmethod_2((Class2275)object_1);
			}
		}
	}
}

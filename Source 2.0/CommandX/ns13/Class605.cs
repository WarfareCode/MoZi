using System;
using System.Collections;
using ns12;

namespace ns13
{
	// Token: 0x020003F7 RID: 1015
	public sealed class Class605 : Class603
	{
		// Token: 0x06001962 RID: 6498 RVA: 0x0001097D File Offset: 0x0000EB7D
		public Class605() : this(10)
		{
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00010987 File Offset: 0x0000EB87
		public Class605(int int_1) : base(int_1)
		{
		}

		// Token: 0x04000A59 RID: 2649
		private IComparer icomparer_0 = new Class605.Class633();

		// Token: 0x04000A5A RID: 2650
		private Class603.Interface22 interface22_0 = new Class605.Class634();

		// Token: 0x020003F8 RID: 1016
		private sealed class Class633 : IComparer
		{
			// Token: 0x06001964 RID: 6500 RVA: 0x0009AEA8 File Offset: 0x000990A8
			public int Compare(object x, object y)
			{
				return new Class605().method_0(((Class609)((Interface23)x).imethod_0()).method_0(), ((Class609)((Interface23)y).imethod_0()).method_0());
			}
		}

		// Token: 0x020003F9 RID: 1017
		private sealed class Class634 : Class603.Interface22
		{
		}
	}
}

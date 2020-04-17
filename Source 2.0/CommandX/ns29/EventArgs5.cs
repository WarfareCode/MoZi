using System;
using System.ComponentModel;

namespace ns29
{
	// Token: 0x02000182 RID: 386
	public sealed class EventArgs5 : CancelEventArgs
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x00008AD2 File Offset: 0x00006CD2
		private EventArgs5()
		{
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00008ADA File Offset: 0x00006CDA
		public EventArgs5(TreeGridViewRow class2384_1)
		{
			this.class2384_0 = class2384_1;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0006BC48 File Offset: 0x00069E48
		public TreeGridViewRow method_0()
		{
			return this.class2384_0;
		}

		// Token: 0x040003AD RID: 941
		private TreeGridViewRow class2384_0;
	}
}

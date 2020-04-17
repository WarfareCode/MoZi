using System;
using System.ComponentModel;

namespace ns29
{
	// Token: 0x02000184 RID: 388
	public sealed class EventArgs6 : CancelEventArgs
	{
		// Token: 0x060008A5 RID: 2213 RVA: 0x00008AD2 File Offset: 0x00006CD2
		private EventArgs6()
		{
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00008AF2 File Offset: 0x00006CF2
		public EventArgs6(TreeGridViewRow class2384_1)
		{
			this.class2384_0 = class2384_1;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0006BC60 File Offset: 0x00069E60
		public TreeGridViewRow method_0()
		{
			return this.class2384_0;
		}

		// Token: 0x040003AE RID: 942
		private TreeGridViewRow class2384_0;
	}
}

using System;

namespace ns15
{
	// Token: 0x0200048D RID: 1165
	public sealed class EventArgs2 : EventArgs
	{
		// Token: 0x06001E17 RID: 7703 RVA: 0x00012552 File Offset: 0x00010752
		public EventArgs2(Class670 class670_1)
		{
			this.class670_0 = class670_1;
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x000C2260 File Offset: 0x000C0460
		public Class670 method_0()
		{
			return this.class670_0;
		}

		// Token: 0x04000D9C RID: 3484
		private Class670 class670_0;
	}
}

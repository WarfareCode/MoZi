using System;

namespace ns16
{
	// Token: 0x020004C0 RID: 1216
	public sealed class Exception16 : Exception14
	{
		// Token: 0x06001FB0 RID: 8112 RVA: 0x000130FD File Offset: 0x000112FD
		public Exception16(Interface28 interface28_2, Interface28 interface28_3) : base("Values could not be converted")
		{
			this.interface28_0 = interface28_2;
			this.interface28_1 = interface28_3;
		}

		// Token: 0x04000F05 RID: 3845
		protected Interface28 interface28_0;

		// Token: 0x04000F06 RID: 3846
		protected Interface28 interface28_1;
	}
}

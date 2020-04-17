using System;

namespace ns32
{
	// Token: 0x020004F2 RID: 1266
	public sealed class EventArgs7 : EventArgs
	{
		// Token: 0x06002102 RID: 8450 RVA: 0x00013D42 File Offset: 0x00011F42
		public EventArgs7(string string_1)
		{
			this.string_0 = string_1;
			this.method_0(true);
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00013D58 File Offset: 0x00011F58
		public void method_0(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x04000FE8 RID: 4072
		private string string_0;

		// Token: 0x04000FE9 RID: 4073
		private bool bool_0;
	}
}

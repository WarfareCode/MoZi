using System;

namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x02000509 RID: 1289
	public sealed class PowerPlanInfo
	{
		// Token: 0x06002191 RID: 8593 RVA: 0x00014061 File Offset: 0x00012261
		public bool Set()
		{
			return PowerSchemeHelper.SetPowerScheme(this.SchemeGuid);
		}

		// Token: 0x04001045 RID: 4165
		public string FriendlyName;

		// Token: 0x04001046 RID: 4166
		public Guid SchemeGuid;

		// Token: 0x04001047 RID: 4167
		public object Tag;
	}
}

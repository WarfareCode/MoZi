using System;
using System.Runtime.CompilerServices;

namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x020004C6 RID: 1222
	public sealed class PowerSettingChangeNotification
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06001FD0 RID: 8144 RVA: 0x000D12A8 File Offset: 0x000CF4A8
		// (remove) Token: 0x06001FD1 RID: 8145 RVA: 0x000D12E4 File Offset: 0x000CF4E4
		[CompilerGenerated]
		[method: CompilerGenerated]
		internal event Action PowerSettingsChanged;

		// Token: 0x06001FD2 RID: 8146 RVA: 0x000131E9 File Offset: 0x000113E9
		public PowerSettingChangeNotification()
		{
			this._regNotHelper = new RegistryChangesNotificationHelper(RegistryChangesNotificationHelper.HKeyEnum.LocalMachine, "SYSTEM\\CurrentControlSet\\Control\\Power\\User\\PowerSchemes", true);
			this._regNotHelper.RegistryChanged += new Action(this._regNotHelper_RegistryChanged);
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x0001321A File Offset: 0x0001141A
		private void _regNotHelper_RegistryChanged()
		{
			this.OnPowerSettingsChanged();
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00013222 File Offset: 0x00011422
		private void OnPowerSettingsChanged()
		{
			if (this.PowerSettingsChanged != null)
			{
				this.PowerSettingsChanged();
			}
		}

		// Token: 0x04000F19 RID: 3865
		private RegistryChangesNotificationHelper _regNotHelper;
	}
}

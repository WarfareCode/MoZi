using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x02000CE6 RID: 3302
	public sealed partial class PowerNotificationForm : Form
	{
		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06006C3B RID: 27707 RVA: 0x003CE214 File Offset: 0x003CC414
		// (remove) Token: 0x06006C3C RID: 27708 RVA: 0x003CE250 File Offset: 0x003CC450
		[CompilerGenerated]
		[method: CompilerGenerated]
		internal event Action<string, PowerSettingNotificationMsgFilter.PowerSavingLevelEnum> PowerStatusChangedEvent;

		// Token: 0x06006C3D RID: 27709 RVA: 0x003CE28C File Offset: 0x003CC48C
		public PowerNotificationForm()
		{
			this.InitializeComponent();
			this._powerLineHelper = new PowerLineHelper();
			this._currentLineName = PowerLineHelper.GetCurrentSystemPowerStatus().ToString();
			this._powerLineHelper.BatteryLifePercentChanged += new Action<int>(this.powerLineHelper_BatteryLifePercentChanged);
			this._powerLineHelper.PowerLineStatusChanged += new Action<PowerLineHelper.PowerLineStatus>(this.powerLineHelper_OnPowerLineStatusChanged);
		}

		// Token: 0x06006C3E RID: 27710 RVA: 0x0002E5B5 File Offset: 0x0002C7B5
		private void powerLineHelper_BatteryLifePercentChanged(int obj)
		{
			this.OnPowerStatusChangedEvent();
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x003CE2F4 File Offset: 0x003CC4F4
		protected override void WndProc(ref Message m)
		{
			if (this._pwrNotMsgFilter != null)
			{
				if (!this._pwrNotMsgFilter.PreFilterMessage(ref m))
				{
					base.WndProc(ref m);
				}
			}
			else
			{
				base.WndProc(ref m);
			}
			int num = 22;
			if (m.Msg == 17)
			{
				m.Result = (IntPtr)1;
			}
			else if (m.Msg == num)
			{
				this.DetachPowerSettingNotificationMsgFilter();
				m.Result = (IntPtr)0;
				base.Close();
				Application.Exit();
			}
		}

		// Token: 0x06006C40 RID: 27712 RVA: 0x0002E5BD File Offset: 0x0002C7BD
		private void OnPowerStatusChangedEvent()
		{
			if (this.PowerStatusChangedEvent != null)
			{
				this.PowerStatusChangedEvent(this._currentLineName, this._currentPowerSavingLevel);
			}
		}

		// Token: 0x06006C41 RID: 27713 RVA: 0x0002E5E1 File Offset: 0x0002C7E1
		private void PowerNotificationForm_Shown(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x06006C42 RID: 27714 RVA: 0x0002E5E9 File Offset: 0x0002C7E9
		private void PowerNotificationForm_Load(object sender, EventArgs e)
		{
			this.AttachPowerSettingNotificationMsgFilter();
		}

		// Token: 0x06006C43 RID: 27715 RVA: 0x0002E5F1 File Offset: 0x0002C7F1
		private void PowerNotificationForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DetachPowerSettingNotificationMsgFilter();
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x0002E5F9 File Offset: 0x0002C7F9
		private void AttachPowerSettingNotificationMsgFilter()
		{
			this._pwrNotMsgFilter = new PowerSettingNotificationMsgFilter(this);
			this._pwrNotMsgFilter.PowerSchemeChanged += new Action<PowerSettingNotificationMsgFilter.PowerSavingLevelEnum>(this.pwrNotMsgFilter_OnPowerSchemeChanged);
		}

		// Token: 0x06006C45 RID: 27717 RVA: 0x0002E61E File Offset: 0x0002C81E
		private void DetachPowerSettingNotificationMsgFilter()
		{
			this._pwrNotMsgFilter.Destroy();
		}

		// Token: 0x06006C46 RID: 27718 RVA: 0x0002E62B File Offset: 0x0002C82B
		private void powerLineHelper_OnPowerLineStatusChanged(PowerLineHelper.PowerLineStatus obj)
		{
			this._currentLineName = PowerLineHelper.GetCurrentSystemPowerStatus().ToString();
			this.OnPowerStatusChangedEvent();
		}

		// Token: 0x06006C47 RID: 27719 RVA: 0x0002E648 File Offset: 0x0002C848
		private void pwrNotMsgFilter_OnPowerSchemeChanged(PowerSettingNotificationMsgFilter.PowerSavingLevelEnum powerSavingLevel)
		{
			this._currentPowerSavingLevel = powerSavingLevel;
			this.OnPowerStatusChangedEvent();
		}

		// Token: 0x04003E5E RID: 15966
		private PowerSettingNotificationMsgFilter _pwrNotMsgFilter;

		// Token: 0x04003E5F RID: 15967
		private PowerLineHelper _powerLineHelper;

		// Token: 0x04003E60 RID: 15968
		private string _currentLineName;

		// Token: 0x04003E61 RID: 15969
		private PowerSettingNotificationMsgFilter.PowerSavingLevelEnum _currentPowerSavingLevel;
	}
}

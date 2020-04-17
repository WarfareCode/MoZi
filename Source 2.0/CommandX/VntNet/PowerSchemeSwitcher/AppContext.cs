using System;
using System.Windows.Forms;
using VntNet.PowerSchemeSwitcher.Properties;

namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x020004B4 RID: 1204
	public sealed class AppContext : ApplicationContext
	{
		// Token: 0x06001F8B RID: 8075 RVA: 0x000CFB24 File Offset: 0x000CDD24
		public AppContext()
		{
			this._autoUpdate = new AutoUpdatePowerSchemeEngine();
			this._pwrForm = new PowerNotificationForm();
			this._systemTryIcon = new SystemTryIcon();
			this._systemTryIcon.ShowSettingForm += new Action(this.ShowAppSettingForm);
			this._systemTryIcon.SettingChanged += new Action(this.AppSettingChanged);
			this._systemTryIcon.Show();
			this._pwrForm.PowerStatusChangedEvent += new Action<string, PowerSettingNotificationMsgFilter.PowerSavingLevelEnum>(this.PowerModeChanged);
			this._pwrForm.Show();
			this._settingsCangheNot = new PowerSettingChangeNotification();
			this._settingsCangheNot.PowerSettingsChanged += new Action(this.PowerSettingsChanged);
			this._autoUpdate.SettingValidated += new Action<bool>(this.AppSettingsValidated);
			this._autoUpdate.Update();
			this._validSettings = true;
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x000CFC0C File Offset: 0x000CDE0C
		private void AppSettingsValidated(bool result)
		{
			this.syncContext.Post(delegate(object param0)
			{
				this.AppSettingsValidatedInternal(result);
			}, null);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x000CFC48 File Offset: 0x000CDE48
		private void AppSettingsValidatedInternal(bool result)
		{
			this._validSettings = result;
			if (!result && Settings.Default.EnableAutoSwitching)
			{
				this._systemTryIcon.ShowBalloonTip(3000, "Failed to applay saved settings", "The saved settings can not be used.Please open setting and fix them.Auto mode is now be disabled", ToolTipIcon.Error);
				Settings.Default.EnableAutoSwitching = false;
			}
			this._systemTryIcon.UpdateMenuAutoItemStatus(result);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x000CFCA4 File Offset: 0x000CDEA4
		private void ShowAppSettingForm()
		{
			if (this._settingForm == null)
			{
				this._settingForm = new SettingsForm();
				this._settingForm.SettingChanged += new Action(this.AppSettingChanged);
				this._settingForm.FormClosed += new FormClosedEventHandler(this.SettingFormClosed);
				this._settingForm.Show();
			}
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00012F60 File Offset: 0x00011160
		private void SettingFormClosed(object sender, FormClosedEventArgs e)
		{
			this._settingForm = null;
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x00012F69 File Offset: 0x00011169
		private void PowerSettingsChanged()
		{
			this.syncContext.Post(delegate(object param0)
			{
				this.PowerSettingsChangedInternal();
			}, null);
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x00012F83 File Offset: 0x00011183
		private void PowerSettingsChangedInternal()
		{
			this._systemTryIcon.UpdateUiInfo();
			this._autoUpdate.Update();
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00012F9B File Offset: 0x0001119B
		private void AppSettingChanged()
		{
			this._autoUpdate.Update();
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x000CFD04 File Offset: 0x000CDF04
		private void PowerModeChanged(string currentLineName, PowerSettingNotificationMsgFilter.PowerSavingLevelEnum currentPowerSavingLevel)
		{
			this.syncContext.Post(delegate(object param0)
			{
				this.PowerModeChangedInternal(currentLineName, currentPowerSavingLevel);
			}, null);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x00012FA8 File Offset: 0x000111A8
		private void PowerModeChangedInternal(string currentLineName, PowerSettingNotificationMsgFilter.PowerSavingLevelEnum currentPowerSavingLevel)
		{
			this._autoUpdate.Update();
			this._systemTryIcon.UpdateUiInfo(currentLineName, currentPowerSavingLevel);
		}

		// Token: 0x04000ECD RID: 3789
		private const int BALLOON_TIMEOUT = 3000;

		// Token: 0x04000ECE RID: 3790
		private SystemTryIcon _systemTryIcon;

		// Token: 0x04000ECF RID: 3791
		private PowerNotificationForm _pwrForm;

		// Token: 0x04000ED0 RID: 3792
		private AutoUpdatePowerSchemeEngine _autoUpdate;

		// Token: 0x04000ED1 RID: 3793
		private PowerSettingChangeNotification _settingsCangheNot;

		// Token: 0x04000ED2 RID: 3794
		private SettingsForm _settingForm;

		// Token: 0x04000ED3 RID: 3795
		private bool _validSettings;

		// Token: 0x04000ED4 RID: 3796
		private WindowsFormsSynchronizationContext syncContext = new WindowsFormsSynchronizationContext();
	}
}

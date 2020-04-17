using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VntNet.PowerSchemeSwitcher.Properties;

namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x02000538 RID: 1336
	public sealed class SystemTryIcon : Component
	{
		// Token: 0x06002299 RID: 8857 RVA: 0x00014397 File Offset: 0x00012597
		public SystemTryIcon()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x000143A5 File Offset: 0x000125A5
		public SystemTryIcon(IContainer container)
		{
			container.Add(this);
			this.InitializeComponent();
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x000143BA File Offset: 0x000125BA
		private void _menuAutoItem_Click(object sender, EventArgs e)
		{
			this._menuAutoItem.Checked = !this._menuAutoItem.Checked;
			Settings.Default.EnableAutoSwitching = this._menuAutoItem.Checked;
			this.OnSettingChanged();
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x000DE4F0 File Offset: 0x000DC6F0
		private void AddAutoMenuItem()
		{
			this._menuAutoItem = new ToolStripMenuItem("Auto");
			this._menuAutoItem.Click += new EventHandler(this._menuAutoItem_Click);
			this.systemTryContextMenuStrip.Items.Add(this._menuAutoItem);
			this.systemTryContextMenuStrip.Items.Add(new ToolStripSeparator());
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x000DE554 File Offset: 0x000DC754
		private void AddExitMenuItem()
		{
			this.systemTryContextMenuStrip.Items.Add(new ToolStripSeparator());
			this._menuExitItem = new ToolStripMenuItem("Exit");
			this._menuExitItem.Click += new EventHandler(this.menuExitItem_Click);
			this.systemTryContextMenuStrip.Items.Add(this._menuExitItem);
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x000DE5B8 File Offset: 0x000DC7B8
		private void AddMenuItem(PowerPlanInfo powerPlanInfo)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(powerPlanInfo.FriendlyName)
			{
				Tag = powerPlanInfo
			};
			toolStripMenuItem.Click += new EventHandler(this.menuItem_Click);
			powerPlanInfo.Tag = toolStripMenuItem;
			if (this._menuExitItem == null)
			{
				this.systemTryContextMenuStrip.Items.Add(toolStripMenuItem);
			}
			else
			{
				this.systemTryContextMenuStrip.Items.Insert(this.systemTryContextMenuStrip.Items.Count - 2, toolStripMenuItem);
			}
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x000DE638 File Offset: 0x000DC838
		private void AddPowerPlansAsMenuItems()
		{
			this._powerPlans = PowerSchemeHelper.GetAllPowerSchemas();
			foreach (KeyValuePair<Guid, PowerPlanInfo> current in this._powerPlans)
			{
				this.AddMenuItem(current.Value);
			}
			PowerSchemeHelper.SetPowerScheme(PowerSchemeHelper.GetPowerActiveScheme());
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x000143F0 File Offset: 0x000125F0
		private void CheckMenuItem(ToolStripMenuItem menuItem)
		{
			if (this._selectedMenuItem != null)
			{
				this._selectedMenuItem.Checked = false;
			}
			this._selectedMenuItem = menuItem;
			menuItem.Checked = true;
			this._currentPowerSchemeName = menuItem.Text;
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00014423 File Offset: 0x00012623
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x000DE6A8 File Offset: 0x000DC8A8
		private void InitializeComponent()
		{
			this.components = new Container();
			this.systemTryContextMenuStrip = new ContextMenuStrip(this.components);
			this.notifyIcon = new NotifyIcon(this.components);
			this.systemTryContextMenuStrip.Name = "systemTryContextMenuStrip";
			this.systemTryContextMenuStrip.Size = new Size(61, 4);
			this.notifyIcon.ContextMenuStrip = this.systemTryContextMenuStrip;
			this.notifyIcon.Text = "Power Config Switch";
			this.notifyIcon.Visible = true;
			this.notifyIcon.BalloonTipClicked += new EventHandler(this.notifyIcon_BalloonTipClicked);
			this.notifyIcon.DoubleClick += new EventHandler(this.notifyIcon_DoubleClick);
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x00014448 File Offset: 0x00012648
		private void menuExitItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x0001444F File Offset: 0x0001264F
		private void menuItem_Click(object sender, EventArgs e)
		{
			((sender as ToolStripMenuItem).Tag as PowerPlanInfo).Set();
			Settings.Default.EnableAutoSwitching = false;
			this._menuAutoItem.Checked = false;
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x0001447E File Offset: 0x0001267E
		private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
		{
			this.OnShowSettingForm();
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x0001447E File Offset: 0x0001267E
		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			this.OnShowSettingForm();
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x00014486 File Offset: 0x00012686
		private void OnSettingChanged()
		{
			if (this.SettingChanged != null)
			{
				this.SettingChanged();
			}
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x0001449E File Offset: 0x0001269E
		private void OnShowSettingForm()
		{
			if (this.ShowSettingForm != null)
			{
				this.ShowSettingForm();
			}
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000DE760 File Offset: 0x000DC960
		private void RemoveMenuItem(PowerPlanInfo powerPlanInfo)
		{
			ToolStripMenuItem value = (ToolStripMenuItem)powerPlanInfo.Tag;
			this.systemTryContextMenuStrip.Items.Remove(value);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x000144B6 File Offset: 0x000126B6
		internal void Show()
		{
			this.AddAutoMenuItem();
			this.AddPowerPlansAsMenuItems();
			this.AddExitMenuItem();
			this.notifyIcon.Icon = Resources.TypicalPowerIcon;
			this.notifyIcon.Visible = true;
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x000144E6 File Offset: 0x000126E6
		internal void ShowBalloonTip(int timeout, string tipTitle, string tipText, ToolTipIcon tipIcon)
		{
			this.notifyIcon.ShowBalloonTip(timeout, tipTitle, tipText, tipIcon);
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x000DE78C File Offset: 0x000DC98C
		private void UpdateIcon(PowerSettingNotificationMsgFilter.PowerSavingLevelEnum currentPowerSavingLevel)
		{
			switch (currentPowerSavingLevel)
			{
			case PowerSettingNotificationMsgFilter.PowerSavingLevelEnum.Max:
				this.notifyIcon.Icon = Resources.MaxSavingIcon;
				break;
			case PowerSettingNotificationMsgFilter.PowerSavingLevelEnum.Min:
				this.notifyIcon.Icon = Resources.MaxPowerIcon;
				break;
			case PowerSettingNotificationMsgFilter.PowerSavingLevelEnum.Typical:
				this.notifyIcon.Icon = Resources.TypicalPowerIcon;
				break;
			default:
				this.notifyIcon.Icon = Resources.TypicalPowerIcon;
				break;
			}
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x000144F8 File Offset: 0x000126F8
		internal void UpdateMenuAutoItemStatus(bool enable)
		{
			this._menuAutoItem.Enabled = enable;
			this._menuAutoItem.Checked = Settings.Default.EnableAutoSwitching;
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x000DE7F4 File Offset: 0x000DC9F4
		private void UpdatePowerPlansMenuItems()
		{
			Dictionary<Guid, PowerPlanInfo> allPowerSchemas = PowerSchemeHelper.GetAllPowerSchemas();
			foreach (KeyValuePair<Guid, PowerPlanInfo> current in allPowerSchemas)
			{
				if (this._powerPlans.ContainsKey(current.Key))
				{
					PowerPlanInfo powerPlanInfo = this._powerPlans[current.Key];
					if (!(current.Value.FriendlyName == powerPlanInfo.FriendlyName))
					{
						((ToolStripMenuItem)powerPlanInfo.Tag).Text = current.Value.FriendlyName;
					}
				}
				else
				{
					this.AddMenuItem(current.Value);
					this._powerPlans.Add(current.Key, current.Value);
				}
			}
			for (int i = this._powerPlans.Count - 1; i >= 0; i--)
			{
				KeyValuePair<Guid, PowerPlanInfo> keyValuePair = this._powerPlans.ElementAt(i);
				if (!allPowerSchemas.ContainsKey(keyValuePair.Key))
				{
					this.RemoveMenuItem(keyValuePair.Value);
					this._powerPlans.Remove(keyValuePair.Key);
				}
			}
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x000DE934 File Offset: 0x000DCB34
		private void UpdateSelectedItem(Guid activeSchemeGuid)
		{
			foreach (KeyValuePair<Guid, PowerPlanInfo> current in this._powerPlans)
			{
				if (!(current.Key != activeSchemeGuid))
				{
					this.CheckMenuItem((ToolStripMenuItem)current.Value.Tag);
				}
			}
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x0001451B File Offset: 0x0001271B
		private void UpdateToolTip()
		{
			this.notifyIcon.Text = string.Format("{0}{1}{2}", this._currentPowerLineName, '-', this._currentPowerSchemeName);
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00014545 File Offset: 0x00012745
		internal void UpdateUiInfo(string currentPowerLineName, PowerSettingNotificationMsgFilter.PowerSavingLevelEnum currentPowerSavingLevel)
		{
			this._currentPowerLineName = currentPowerLineName;
			this.UpdateIcon(currentPowerSavingLevel);
			this.UpdateUiInfo();
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x000DE9AC File Offset: 0x000DCBAC
		internal void UpdateUiInfo()
		{
			Guid powerActiveScheme = PowerSchemeHelper.GetPowerActiveScheme();
			this.UpdatePowerPlansMenuItems();
			this.UpdateSelectedItem(powerActiveScheme);
			this.UpdateToolTip();
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060022B3 RID: 8883 RVA: 0x000DE9D4 File Offset: 0x000DCBD4
		// (remove) Token: 0x060022B4 RID: 8884 RVA: 0x000DEA10 File Offset: 0x000DCC10
		internal event Action SettingChanged;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060022B5 RID: 8885 RVA: 0x000DEA4C File Offset: 0x000DCC4C
		// (remove) Token: 0x060022B6 RID: 8886 RVA: 0x000DEA88 File Offset: 0x000DCC88
		internal event Action ShowSettingForm;

		// Token: 0x040010ED RID: 4333
		private ToolStripMenuItem _selectedMenuItem;

		// Token: 0x040010EE RID: 4334
		private Dictionary<Guid, PowerPlanInfo> _powerPlans;

		// Token: 0x040010EF RID: 4335
		private ToolStripMenuItem _menuExitItem;

		// Token: 0x040010F0 RID: 4336
		private ToolStripMenuItem _menuAutoItem;

		// Token: 0x040010F1 RID: 4337
		private string _currentPowerLineName;

		// Token: 0x040010F2 RID: 4338
		private string _currentPowerSchemeName;

		// Token: 0x040010F3 RID: 4339
		private IContainer components;

		// Token: 0x040010F4 RID: 4340
		private ContextMenuStrip systemTryContextMenuStrip;

		// Token: 0x040010F5 RID: 4341
		private NotifyIcon notifyIcon;
	}
}

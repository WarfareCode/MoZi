using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using VntNet.PowerSchemeSwitcher.Properties;

namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x02000CE4 RID: 3300
	public sealed partial class SettingsForm : Form
	{
		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06006C29 RID: 27689 RVA: 0x003CD3EC File Offset: 0x003CB5EC
		// (remove) Token: 0x06006C2A RID: 27690 RVA: 0x003CD428 File Offset: 0x003CB628
		[CompilerGenerated]
		[method: CompilerGenerated]
		internal event Action SettingChanged;

		// Token: 0x06006C2B RID: 27691 RVA: 0x003CD464 File Offset: 0x003CB664
		public SettingsForm()
		{
			this.InitializeComponent();
			Dictionary<Guid, PowerPlanInfo> allPowerSchemas = PowerSchemeHelper.GetAllPowerSchemas();
			foreach (KeyValuePair<Guid, PowerPlanInfo> current in allPowerSchemas)
			{
				this.acComboBox.Items.Add(new SettingsForm.PowerPlanComboBoxItem(current.Value));
				this.batteryComboBox.Items.Add(new SettingsForm.PowerPlanComboBoxItem(current.Value));
				this.lowBatteryComboBox.Items.Add(new SettingsForm.PowerPlanComboBoxItem(current.Value));
			}
			this.SetComboSavedSettings(allPowerSchemas, Settings.Default.OnAcScheme, this.acComboBox);
			this.SetComboSavedSettings(allPowerSchemas, Settings.Default.OnFullBatteryScheme, this.batteryComboBox);
			this.SetComboSavedSettings(allPowerSchemas, Settings.Default.OnLowBatteryScheme, this.lowBatteryComboBox);
		}

		// Token: 0x06006C2C RID: 27692 RVA: 0x003CD55C File Offset: 0x003CB75C
		private void SetComboSavedSettings(Dictionary<Guid, PowerPlanInfo> list, Guid settingGuid, ComboBox comboBox)
		{
			if (settingGuid != Guid.Empty && list.ContainsKey(settingGuid))
			{
				for (int i = 0; i < comboBox.Items.Count; i++)
				{
					if (((SettingsForm.PowerPlanComboBoxItem)comboBox.Items[i]).SchemeGuid == settingGuid)
					{
						comboBox.SelectedIndex = i;
						break;
					}
				}
			}
		}

		// Token: 0x06006C2D RID: 27693 RVA: 0x0002E4CD File Offset: 0x0002C6CD
		private void OnSettingChanged()
		{
			if (this.SettingChanged != null)
			{
				this.SettingChanged();
			}
		}

		// Token: 0x06006C2E RID: 27694 RVA: 0x0002E4E5 File Offset: 0x0002C6E5
		private void ShowAbout()
		{
			new AboutDialog().ShowDialog();
		}

		// Token: 0x06006C2F RID: 27695 RVA: 0x0002E4F2 File Offset: 0x0002C6F2
		private void btnOK_Click(object sender, EventArgs e)
		{
			Settings.Default.Save();
			this.OnSettingChanged();
			base.Close();
		}

		// Token: 0x06006C30 RID: 27696 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06006C31 RID: 27697 RVA: 0x0002E50A File Offset: 0x0002C70A
		private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default.Reload();
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x0002E516 File Offset: 0x0002C716
		private void acComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Settings.Default.OnAcScheme = ((SettingsForm.PowerPlanComboBoxItem)this.acComboBox.SelectedItem).SchemeGuid;
		}

		// Token: 0x06006C33 RID: 27699 RVA: 0x0002E537 File Offset: 0x0002C737
		private void batteryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Settings.Default.OnFullBatteryScheme = ((SettingsForm.PowerPlanComboBoxItem)this.batteryComboBox.SelectedItem).SchemeGuid;
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x0002E558 File Offset: 0x0002C758
		private void lowBatteryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Settings.Default.OnLowBatteryScheme = ((SettingsForm.PowerPlanComboBoxItem)this.lowBatteryComboBox.SelectedItem).SchemeGuid;
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x0002E579 File Offset: 0x0002C779
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.ShowAbout();
		}

		// Token: 0x02000CE5 RID: 3301
		private sealed class PowerPlanComboBoxItem
		{
			// Token: 0x17000521 RID: 1313
			// (get) Token: 0x06006C38 RID: 27704 RVA: 0x003CE1DC File Offset: 0x003CC3DC
			internal Guid SchemeGuid
			{
				get
				{
					return this._info.SchemeGuid;
				}
			}

			// Token: 0x06006C39 RID: 27705 RVA: 0x0002E5A6 File Offset: 0x0002C7A6
			public PowerPlanComboBoxItem(PowerPlanInfo info)
			{
				this._info = info;
			}

			// Token: 0x06006C3A RID: 27706 RVA: 0x003CE1F8 File Offset: 0x003CC3F8
			public override string ToString()
			{
				return this._info.FriendlyName;
			}

			// Token: 0x04003E5D RID: 15965
			private PowerPlanInfo _info;
		}
	}
}

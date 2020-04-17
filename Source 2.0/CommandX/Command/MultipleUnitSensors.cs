using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace Command
{
	// 传感器设置窗口
	[DesignerGenerated]
	public sealed partial class MultipleUnitSensors : CommandForm
	{
		// Token: 0x060053FF RID: 21503 RVA: 0x002274BC File Offset: 0x002256BC
		public MultipleUnitSensors()
		{
			base.Load += new EventHandler(this.MultipleUnitSensors_Load);
			base.KeyDown += new KeyEventHandler(this.MultipleUnitSensors_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.MultipleUnitSensors_FormClosing);
			this.collection_0 = new Collection<Sensor>();
			this.collection_1 = new Collection<Sensor>();
			this.collection_2 = new Collection<Sensor>();
			this.InitializeComponent();
		}

		// Token: 0x06005402 RID: 21506 RVA: 0x00227864 File Offset: 0x00225A64
		[CompilerGenerated]
		internal  CheckBox GetCB_radar()
		{
			return this.CB_radar;
		}

		// Token: 0x06005403 RID: 21507 RVA: 0x0022787C File Offset: 0x00225A7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCB_radar(CheckBox checkBox_3)
		{
			EventHandler value = new EventHandler(this.CB_radar_Click);
			CheckBox cB_radar = this.CB_radar;
			if (cB_radar != null)
			{
				cB_radar.Click -= value;
			}
			this.CB_radar = checkBox_3;
			cB_radar = this.CB_radar;
			if (cB_radar != null)
			{
				cB_radar.Click += value;
			}
		}

		// Token: 0x06005404 RID: 21508 RVA: 0x002278C8 File Offset: 0x00225AC8
		[CompilerGenerated]
		internal  CheckBox GetCB_Sonar()
		{
			return this.CB_Sonar;
		}

		// Token: 0x06005405 RID: 21509 RVA: 0x002278E0 File Offset: 0x00225AE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCB_Sonar(CheckBox checkBox_3)
		{
			EventHandler value = new EventHandler(this.CB_Sonar_Click);
			CheckBox cB_Sonar = this.CB_Sonar;
			if (cB_Sonar != null)
			{
				cB_Sonar.Click -= value;
			}
			this.CB_Sonar = checkBox_3;
			cB_Sonar = this.CB_Sonar;
			if (cB_Sonar != null)
			{
				cB_Sonar.Click += value;
			}
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x0022792C File Offset: 0x00225B2C
		[CompilerGenerated]
		internal  CheckBox GetCB_ECM()
		{
			return this.CB_ECM;
		}

		// Token: 0x06005407 RID: 21511 RVA: 0x00227944 File Offset: 0x00225B44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCB_ECM(CheckBox checkBox_3)
		{
			EventHandler value = new EventHandler(this.CB_ECM_Click);
			CheckBox cB_ECM = this.CB_ECM;
			if (cB_ECM != null)
			{
				cB_ECM.Click -= value;
			}
			this.CB_ECM = checkBox_3;
			cB_ECM = this.CB_ECM;
			if (cB_ECM != null)
			{
				cB_ECM.Click += value;
			}
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x00227990 File Offset: 0x00225B90
		[CompilerGenerated]
		internal  Label GetCB_Active()
		{
			return this.CB_Active;
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x00026D9B File Offset: 0x00024F9B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCB_Active(Label label_1)
		{
			this.CB_Active = label_1;
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x002279A8 File Offset: 0x00225BA8
		private void MultipleUnitSensors_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (!Information.IsNothing(Client.GetWayPointSelected()))
			{
				if (Operators.CompareString(Client.GetWayPointSelected().Name, "", false) == 0)
				{
					this.Text = "导航点传感器";
				}
				else
				{
					this.Text = Client.GetWayPointSelected().Name + "传感器: ";
				}
			}
			else if (Client.GetHookedUnit().IsActiveUnit())
			{
				this.Text = "多个传感器— " + Client.GetHookedUnit().Name;
			}
			checked
			{
				if (!Information.IsNothing(Client.GetWayPointSelected()))
				{
					if (Client.GetWayPointSelected().m_Doctrine.EMCON_SettingsHasNoValue())
					{
						this.GetCB_radar().CheckState = CheckState.Indeterminate;
					}
					else if (Client.GetWayPointSelected().m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar() == Doctrine.EMCON_Settings.Enum36.const_1)
					{
						this.GetCB_radar().Checked = true;
					}
					else if (Client.GetWayPointSelected().m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar() == Doctrine.EMCON_Settings.Enum36.const_3)
					{
						this.GetCB_radar().CheckState = CheckState.Indeterminate;
					}
					else
					{
						this.GetCB_radar().Checked = false;
					}
					if (Client.GetWayPointSelected().m_Doctrine.EMCON_SettingsHasNoValue())
					{
						this.GetCB_Sonar().CheckState = CheckState.Indeterminate;
					}
					else if (Client.GetWayPointSelected().m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar() == Doctrine.EMCON_Settings.Enum36.const_1)
					{
						this.GetCB_Sonar().Checked = true;
					}
					else if (Client.GetWayPointSelected().m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar() == Doctrine.EMCON_Settings.Enum36.const_3)
					{
						this.GetCB_Sonar().CheckState = CheckState.Indeterminate;
					}
					else
					{
						this.GetCB_Sonar().Checked = false;
					}
					if (Client.GetWayPointSelected().m_Doctrine.EMCON_SettingsHasNoValue())
					{
						this.GetCB_ECM().CheckState = CheckState.Indeterminate;
					}
					else if (Client.GetWayPointSelected().m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM() == Doctrine.EMCON_Settings.Enum36.const_1)
					{
						this.GetCB_ECM().Checked = true;
					}
					else if (Client.GetWayPointSelected().m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM() == Doctrine.EMCON_Settings.Enum36.const_3)
					{
						this.GetCB_ECM().CheckState = CheckState.Indeterminate;
					}
					else
					{
						this.GetCB_ECM().Checked = false;
					}
				}
				else
				{
					this.ienumerable_0 = this.list_0.Where(MultipleUnitSensors.UnitFunc0);
					using (IEnumerator<Unit> enumerator = this.ienumerable_0.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Sensor[] noneMCMSensors = ((ActiveUnit)enumerator.Current).GetNoneMCMSensors();
							for (int i = 0; i < noneMCMSensors.Length; i++)
							{
								Sensor sensor = noneMCMSensors[i];
								if (sensor.sensorType == Sensor.SensorType.Radar)
								{
									this.collection_0.Add(sensor);
								}
							}
						}
					}
					IEnumerable<Sensor> source = this.collection_0.Where(MultipleUnitSensors.SensorFunc1);
					if (source.Count<Sensor>() == 0)
					{
						this.GetCB_radar().Checked = false;
					}
					else if (source.Count<Sensor>() == this.collection_0.Count)
					{
						this.GetCB_radar().Checked = true;
					}
					else
					{
						this.GetCB_radar().CheckState = CheckState.Indeterminate;
					}
					using (IEnumerator<Unit> enumerator2 = this.ienumerable_0.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Sensor[] noneMCMSensors2 = ((ActiveUnit)enumerator2.Current).GetNoneMCMSensors();
							for (int j = 0; j < noneMCMSensors2.Length; j++)
							{
								Sensor sensor2 = noneMCMSensors2[j];
								if (sensor2.IsSonar())
								{
									this.collection_1.Add(sensor2);
								}
							}
						}
					}
					IEnumerable<Sensor> source2 = this.collection_1.Where(MultipleUnitSensors.SensorFunc2);
					if (source2.Count<Sensor>() == 0)
					{
						this.GetCB_Sonar().Checked = false;
					}
					else if (source2.Count<Sensor>() == this.collection_1.Count)
					{
						this.GetCB_Sonar().Checked = true;
					}
					else
					{
						this.GetCB_Sonar().CheckState = CheckState.Indeterminate;
					}
					using (IEnumerator<Unit> enumerator3 = this.ienumerable_0.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							Sensor[] noneMCMSensors3 = ((ActiveUnit)enumerator3.Current).GetNoneMCMSensors();
							for (int k = 0; k < noneMCMSensors3.Length; k++)
							{
								Sensor sensor3 = noneMCMSensors3[k];
								if (sensor3.IsJammer())
								{
									this.collection_2.Add(sensor3);
								}
							}
						}
					}
					IEnumerable<Sensor> source3 = this.collection_2.Where(MultipleUnitSensors.SensorFunc3);
					if (source3.Count<Sensor>() == 0)
					{
						this.GetCB_ECM().Checked = false;
					}
					else if (source3.Count<Sensor>() == this.collection_2.Count)
					{
						this.GetCB_ECM().Checked = true;
					}
					else
					{
						this.GetCB_ECM().CheckState = CheckState.Indeterminate;
					}
				}
			}
		}

		// Token: 0x0600540B RID: 21515 RVA: 0x00026DA4 File Offset: 0x00024FA4
		private bool method_1()
		{
			//return Interaction.MsgBox("Override strict obedience to EMCON settings if present?", MsgBoxStyle.YesNo, "Override EMCON?") == MsgBoxResult.Yes;
            return Interaction.MsgBox("将重新设置当前的电磁辐射控制规则?", MsgBoxStyle.YesNo, "覆盖电磁辐射控制规则?") == MsgBoxResult.Yes;
        }

		// Token: 0x0600540C RID: 21516 RVA: 0x00227EBC File Offset: 0x002260BC
		private void CB_radar_Click(object sender, EventArgs e)
		{
			if (Information.IsNothing(Client.GetWayPointSelected()))
			{
				bool flag = this.method_1();
				bool @checked;
				if (@checked = this.GetCB_radar().Checked)
				{
					if (!@checked)
					{
						goto IL_11E;
					}
					using (IEnumerator<Sensor> enumerator = this.collection_0.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Sensor current = enumerator.Current;
							if (!(current.GetParentPlatform().GetSensory().IsObeysEMCON() & !flag))
							{
								current.GetParentPlatform().GetSensory().SetIsObeysEMCON(false);
								if (!current.NonSearchAndTrackSensorOtherThanMCMAndMAD() && !current.IsEmmitting())
								{
									current.TurnOn();
								}
							}
						}
						goto IL_11E;
					}
				}
				foreach (Sensor current2 in this.collection_0)
				{
					if (!(current2.GetParentPlatform().GetSensory().IsObeysEMCON() & !flag))
					{
						current2.GetParentPlatform().GetSensory().SetIsObeysEMCON(false);
						if (!current2.NonSearchAndTrackSensorOtherThanMCMAndMAD() && current2.IsEmmitting())
						{
							current2.TurnOff();
						}
					}
				}
				IL_11E:
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
			else
			{
				this.GetCB_radar().ThreeState = true;
				switch (this.GetCB_radar().CheckState)
				{
				case CheckState.Unchecked:
					Client.GetWayPointSelected().m_Doctrine.SetEMCON_Settings(false);
					Client.GetWayPointSelected().m_Doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_0, Client.GetClientScenario());
					break;
				case CheckState.Checked:
					Client.GetWayPointSelected().m_Doctrine.SetEMCON_Settings(false);
					Client.GetWayPointSelected().m_Doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_1, Client.GetClientScenario());
					break;
				case CheckState.Indeterminate:
					if (Client.GetWayPointSelected().m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar() == Doctrine.EMCON_Settings.Enum36.const_3 && Client.GetWayPointSelected().m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM() == Doctrine.EMCON_Settings.Enum36.const_3)
					{
						Client.GetWayPointSelected().m_Doctrine.SetEMCON_Settings(true);
					}
					Client.GetWayPointSelected().m_Doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_3, Client.GetClientScenario());
					break;
				}
			}
		}

		// Token: 0x0600540D RID: 21517 RVA: 0x00228100 File Offset: 0x00226300
		private void CB_Sonar_Click(object sender, EventArgs e)
		{
			if (Information.IsNothing(Client.GetWayPointSelected()))
			{
				bool flag = this.method_1();
				bool @checked;
				if (@checked = this.GetCB_Sonar().Checked)
				{
					if (!@checked)
					{
						goto IL_105;
					}
					using (IEnumerator<Sensor> enumerator = this.collection_1.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Sensor current = enumerator.Current;
							if (!(current.GetParentPlatform().GetSensory().IsObeysEMCON() & !flag) && !current.NonSearchAndTrackSensorOtherThanMCMAndMAD() && (!current.IsEmmitting() & current.IsActiveCapable()))
							{
								current.TurnOn();
							}
						}
						goto IL_105;
					}
				}
				foreach (Sensor current2 in this.collection_1)
				{
					if (!(current2.GetParentPlatform().GetSensory().IsObeysEMCON() & !flag) && !current2.NonSearchAndTrackSensorOtherThanMCMAndMAD() && current2.IsEmmitting())
					{
						current2.TurnOff();
					}
				}
				IL_105:
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
			else
			{
				this.GetCB_Sonar().ThreeState = true;
				switch (this.GetCB_Sonar().CheckState)
				{
				case CheckState.Unchecked:
					Client.GetWayPointSelected().m_Doctrine.SetEMCON_Settings(false);
					Client.GetWayPointSelected().m_Doctrine.SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.Enum36.const_0, Client.GetClientScenario());
					break;
				case CheckState.Checked:
					Client.GetWayPointSelected().m_Doctrine.SetEMCON_Settings(false);
					Client.GetWayPointSelected().m_Doctrine.SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.Enum36.const_1, Client.GetClientScenario());
					break;
				case CheckState.Indeterminate:
					if (Client.GetWayPointSelected().m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar() == Doctrine.EMCON_Settings.Enum36.const_3 && Client.GetWayPointSelected().m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM() == Doctrine.EMCON_Settings.Enum36.const_3)
					{
						Client.GetWayPointSelected().m_Doctrine.SetEMCON_Settings(true);
					}
					Client.GetWayPointSelected().m_Doctrine.SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.Enum36.const_3, Client.GetClientScenario());
					break;
				}
			}
		}

		// Token: 0x0600540E RID: 21518 RVA: 0x0022832C File Offset: 0x0022652C
		private void CB_ECM_Click(object sender, EventArgs e)
		{
			if (Information.IsNothing(Client.GetWayPointSelected()))
			{
				bool flag = this.method_1();
				bool @checked;
				if (@checked = this.GetCB_ECM().Checked)
				{
					if (!@checked)
					{
						goto IL_E7;
					}
					using (IEnumerator<Sensor> enumerator = this.collection_2.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Sensor current = enumerator.Current;
							if (!(current.GetParentPlatform().GetSensory().IsObeysEMCON() & !flag) && !current.IsEmmitting())
							{
								current.TurnOn();
							}
						}
						goto IL_E7;
					}
				}
				foreach (Sensor current2 in this.collection_2)
				{
					if (!(current2.GetParentPlatform().GetSensory().IsObeysEMCON() & !flag) && current2.IsEmmitting())
					{
						current2.TurnOff();
					}
				}
				IL_E7:
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
			else
			{
				this.GetCB_ECM().ThreeState = true;
				switch (this.GetCB_ECM().CheckState)
				{
				case CheckState.Unchecked:
					Client.GetWayPointSelected().m_Doctrine.SetEMCON_Settings(false);
					Client.GetWayPointSelected().m_Doctrine.method_173(Doctrine.EMCON_Settings.Enum36.const_0, Client.GetClientScenario());
					break;
				case CheckState.Checked:
					Client.GetWayPointSelected().m_Doctrine.SetEMCON_Settings(false);
					Client.GetWayPointSelected().m_Doctrine.method_173(Doctrine.EMCON_Settings.Enum36.const_1, Client.GetClientScenario());
					break;
				case CheckState.Indeterminate:
					if (Client.GetWayPointSelected().m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar() == Doctrine.EMCON_Settings.Enum36.const_3 && Client.GetWayPointSelected().m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar() == Doctrine.EMCON_Settings.Enum36.const_3)
					{
						Client.GetWayPointSelected().m_Doctrine.SetEMCON_Settings(true);
					}
					Client.GetWayPointSelected().m_Doctrine.method_173(Doctrine.EMCON_Settings.Enum36.const_3, Client.GetClientScenario());
					break;
				}
			}
		}

		// Token: 0x0600540F RID: 21519 RVA: 0x00228538 File Offset: 0x00226738
		private void MultipleUnitSensors_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F9 && base.Visible)
			{
				base.Close();
			}
			else if (!base.Visible || (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Space))
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x00004D83 File Offset: 0x00002F83
		private void MultipleUnitSensors_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x04002783 RID: 10115
		public static Func<Unit, bool> UnitFunc0 = (Unit unit_0) => unit_0.IsActiveUnit() & unit_0.GetSide(false) == Client.GetClientSide();

		// Token: 0x04002784 RID: 10116
		public static Func<Sensor, bool> SensorFunc1 = (Sensor sensor_0) => sensor_0.IsEmmitting();

		// Token: 0x04002785 RID: 10117
		public static Func<Sensor, bool> SensorFunc2 = (Sensor sensor_0) => sensor_0.IsEmmitting();

		// Token: 0x04002786 RID: 10118
		public static Func<Sensor, bool> SensorFunc3 = (Sensor sensor_0) => sensor_0.IsEmmitting();

		// Token: 0x04002788 RID: 10120
		[CompilerGenerated]
		private CheckBox CB_radar;

		// Token: 0x04002789 RID: 10121
		[CompilerGenerated]
		private CheckBox CB_Sonar;

		// Token: 0x0400278A RID: 10122
		[CompilerGenerated]
		private CheckBox CB_ECM;

		// Token: 0x0400278B RID: 10123
		[CompilerGenerated]
		private Label CB_Active;

		// Token: 0x0400278C RID: 10124
		public List<Unit> list_0;

		// Token: 0x0400278D RID: 10125
		private Collection<Sensor> collection_0;

		// Token: 0x0400278E RID: 10126
		private Collection<Sensor> collection_1;

		// Token: 0x0400278F RID: 10127
		private Collection<Sensor> collection_2;

		// Token: 0x04002790 RID: 10128
		private IEnumerable<Unit> ienumerable_0;
	}
}

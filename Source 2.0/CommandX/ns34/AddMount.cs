using System;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x02000A26 RID: 2598
	[DesignerGenerated]
	public sealed partial class AddMount : CommandForm
	{
		// Token: 0x060050D3 RID: 20691 RVA: 0x0020DF00 File Offset: 0x0020C100
		public AddMount()
		{
			base.Load += new EventHandler(this.AddMount_Load);
			base.KeyDown += new KeyEventHandler(this.AddMount_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.AddMount_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x0020E578 File Offset: 0x0020C778
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x00025CE2 File Offset: 0x00023EE2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			this.dataGridView_0 = dataGridView_1;
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x0020E590 File Offset: 0x0020C790
		[CompilerGenerated]
		internal  BackgroundWorker vmethod_2()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x0020E5A8 File Offset: 0x0020C7A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler value = new DoWorkEventHandler(this.method_2);
			RunWorkerCompletedEventHandler value2 = new RunWorkerCompletedEventHandler(this.method_3);
			BackgroundWorker backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value;
				backgroundWorker.RunWorkerCompleted -= value2;
			}
			this.backgroundWorker_0 = backgroundWorker_1;
			backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value;
				backgroundWorker.RunWorkerCompleted += value2;
			}
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x0020E60C File Offset: 0x0020C80C
		[CompilerGenerated]
		internal  StatusStrip vmethod_4()
		{
			return this.statusStrip_0;
		}

		// Token: 0x060050DB RID: 20699 RVA: 0x00025CEB File Offset: 0x00023EEB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(StatusStrip statusStrip_1)
		{
			this.statusStrip_0 = statusStrip_1;
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x0020E624 File Offset: 0x0020C824
		[CompilerGenerated]
		internal  ToolStripStatusLabel vmethod_6()
		{
			return this.toolStripStatusLabel_0;
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x00025CF4 File Offset: 0x00023EF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripStatusLabel toolStripStatusLabel_1)
		{
			this.toolStripStatusLabel_0 = toolStripStatusLabel_1;
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x0020E63C File Offset: 0x0020C83C
		[CompilerGenerated]
		internal  Button vmethod_8()
		{
			return this.button_0;
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x0020E654 File Offset: 0x0020C854
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_1)
		{
			EventHandler value = new EventHandler(this.method_1);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_1;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x0020E6A0 File Offset: 0x0020C8A0
		[CompilerGenerated]
		internal  CheckBox vmethod_10()
		{
			return this.checkBox_0;
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x00025CFD File Offset: 0x00023EFD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(CheckBox checkBox_1)
		{
			this.checkBox_0 = checkBox_1;
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x0020E6B8 File Offset: 0x0020C8B8
		[CompilerGenerated]
		internal  TextBox vmethod_12()
		{
			return this.textBox_0;
		}

		// Token: 0x060050E3 RID: 20707 RVA: 0x0020E6D0 File Offset: 0x0020C8D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(TextBox textBox_1)
		{
			EventHandler value = new EventHandler(this.method_4);
			EventHandler value2 = new EventHandler(this.method_7);
			EventHandler value3 = new EventHandler(this.method_8);
			TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
				textBox.Enter -= value2;
				textBox.Leave -= value3;
			}
			this.textBox_0 = textBox_1;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged += value;
				textBox.Enter += value2;
				textBox.Leave += value3;
			}
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x0020E750 File Offset: 0x0020C950
		[CompilerGenerated]
		internal  PlatformComponentArcControl vmethod_14()
		{
			return this.platformComponentArcControl_0;
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x00025D06 File Offset: 0x00023F06
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(PlatformComponentArcControl platformComponentArcControl_1)
		{
			this.platformComponentArcControl_0 = platformComponentArcControl_1;
		}

		// Token: 0x060050E6 RID: 20710 RVA: 0x0020E768 File Offset: 0x0020C968
		[CompilerGenerated]
		internal  Label vmethod_16()
		{
			return this.label_0;
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x00025D0F File Offset: 0x00023F0F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x0020E780 File Offset: 0x0020C980
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_18()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x00025D18 File Offset: 0x00023F18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x0020E798 File Offset: 0x0020C998
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_20()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x00025D21 File Offset: 0x00023F21
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x00025D2A File Offset: 0x00023F2A
		private void AddMount_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_2().RunWorkerAsync();
			this.vmethod_6().Text = "Fetching mounts...";
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x0020E7B0 File Offset: 0x0020C9B0
		private void method_1(object sender, EventArgs e)
		{
			checked
			{
				if (!Information.IsNothing(Client.GetHookedUnit()) && Client.GetHookedUnit().IsActiveUnit())
				{
					if (this.vmethod_14().method_0())
					{
						Interaction.MsgBox("You must select coverage arcs for this mount", MsgBoxStyle.Critical, "No coverage arcs selected!");
					}
					else
					{
						int mountDBID = Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value);
						Scenario clientScenario = Client.GetClientScenario();
						Mount mount = DBFunctions.LoadMountData(mountDBID, ref clientScenario, true);
						mount.coverageArc = this.vmethod_14().struct19_0;
						ScenarioArrayUtil.AddMount(ref ((ActiveUnit)Client.GetHookedUnit()).m_Mounts, mount);
						mount.SetParentPlatform((ActiveUnit)Client.GetHookedUnit());
						Sensor[] sensors = mount.GetSensors();
						for (int i = 0; i < sensors.Length; i++)
						{
							Sensor sensor = sensors[i];
							sensor.SetParentPlatform((ActiveUnit)Client.GetHookedUnit());
							sensor.coverageArc = mount.coverageArc;
							sensor.coverageArcMax = mount.coverageArc;
						}
						if (this.form_0 == Client.smethod_26())
						{
							Client.smethod_26().method_10();
						}
					}
				}
			}
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x0020E8D8 File Offset: 0x0020CAD8
		private void method_2(object sender, DoWorkEventArgs e)
		{
			SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
			this.dataTable_0 = DBFunctions.smethod_65(ref sQLiteConnection);
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x00025D5F File Offset: 0x00023F5F
		private void method_3(object sender, RunWorkerCompletedEventArgs e)
		{
			this.vmethod_6().Text = "点击表头按ID或名称排序； 点击一行挂架选择。";
			this.method_6();
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x00025D77 File Offset: 0x00023F77
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_10().Checked & Operators.CompareString(this.vmethod_12().Text, "", false) != 0)
			{
				this.method_5();
			}
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x0020E900 File Offset: 0x0020CB00
		private void method_5()
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Name ASC";
			dataView.RowFilter = "Name LIKE '%" + this.vmethod_12().Text + "%'";
			this.vmethod_0().DataSource = dataView;
			this.vmethod_0().Refresh();
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x00025DAC File Offset: 0x00023FAC
		private void method_6()
		{
			this.dataView_0 = new DataView(this.dataTable_0);
			this.dataView_0.Sort = "Name ASC";
			this.vmethod_0().AutoGenerateColumns = false;
			this.vmethod_0().DataSource = this.dataView_0;
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x0020E95C File Offset: 0x0020CB5C
		private void AddMount_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else
			{
				if (this.bool_0)
				{
					if (e.KeyValue == 13 && base.Visible)
					{
						this.vmethod_10().Select();
						return;
					}
					if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
					{
						CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
					}
				}
				if (!this.bool_0 && (e.KeyValue != 32 || !base.Visible))
				{
					CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x00025DEC File Offset: 0x00023FEC
		private void method_7(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x00025DF5 File Offset: 0x00023FF5
		private void method_8(object sender, EventArgs e)
		{
			this.bool_0 = false;
			this.vmethod_10().Select();
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x00004D83 File Offset: 0x00002F83
		private void AddMount_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x04002602 RID: 9730
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04002603 RID: 9731
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04002604 RID: 9732
		[CompilerGenerated]
		private StatusStrip statusStrip_0;

		// Token: 0x04002605 RID: 9733
		[CompilerGenerated]
		private ToolStripStatusLabel toolStripStatusLabel_0;

		// Token: 0x04002606 RID: 9734
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04002607 RID: 9735
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04002608 RID: 9736
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04002609 RID: 9737
		[CompilerGenerated]
		private PlatformComponentArcControl platformComponentArcControl_0;

		// Token: 0x0400260A RID: 9738
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x0400260B RID: 9739
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x0400260C RID: 9740
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x0400260D RID: 9741
		private DataTable dataTable_0;

		// Token: 0x0400260E RID: 9742
		private DataView dataView_0;

		// Token: 0x0400260F RID: 9743
		private bool bool_0;

		// Token: 0x04002610 RID: 9744
		public Form form_0;
	}
}

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
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x02000A2A RID: 2602
	[DesignerGenerated]
	public sealed partial class AddSensor : CommandForm
	{
		// Token: 0x0600516F RID: 20847 RVA: 0x00214064 File Offset: 0x00212264
		public AddSensor()
		{
			base.Load += new EventHandler(this.AddSensor_Load);
			base.KeyDown += new KeyEventHandler(this.AddSensor_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.AddSensor_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x00214838 File Offset: 0x00212A38
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06005173 RID: 20851 RVA: 0x0002604D File Offset: 0x0002424D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			this.dataGridView_0 = dataGridView_1;
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x00214850 File Offset: 0x00212A50
		[CompilerGenerated]
		internal  BackgroundWorker vmethod_2()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x00214868 File Offset: 0x00212A68
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

		// Token: 0x06005176 RID: 20854 RVA: 0x002148CC File Offset: 0x00212ACC
		[CompilerGenerated]
		internal  StatusStrip vmethod_4()
		{
			return this.statusStrip_0;
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x00026056 File Offset: 0x00024256
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(StatusStrip statusStrip_1)
		{
			this.statusStrip_0 = statusStrip_1;
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x002148E4 File Offset: 0x00212AE4
		[CompilerGenerated]
		internal  ToolStripStatusLabel vmethod_6()
		{
			return this.toolStripStatusLabel_0;
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x0002605F File Offset: 0x0002425F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripStatusLabel toolStripStatusLabel_1)
		{
			this.toolStripStatusLabel_0 = toolStripStatusLabel_1;
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x002148FC File Offset: 0x00212AFC
		[CompilerGenerated]
		internal  Button vmethod_8()
		{
			return this.button_0;
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x00214914 File Offset: 0x00212B14
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

		// Token: 0x0600517C RID: 20860 RVA: 0x00214960 File Offset: 0x00212B60
		[CompilerGenerated]
		internal  CheckBox vmethod_10()
		{
			return this.checkBox_0;
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x00026068 File Offset: 0x00024268
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(CheckBox checkBox_1)
		{
			this.checkBox_0 = checkBox_1;
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x00214978 File Offset: 0x00212B78
		[CompilerGenerated]
		internal  TextBox vmethod_12()
		{
			return this.textBox_0;
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x00214990 File Offset: 0x00212B90
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

		// Token: 0x06005180 RID: 20864 RVA: 0x00214A10 File Offset: 0x00212C10
		[CompilerGenerated]
		internal  PlatformComponentArcControl vmethod_14()
		{
			return this.platformComponentArcControl_0;
		}

		// Token: 0x06005181 RID: 20865 RVA: 0x00026071 File Offset: 0x00024271
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(PlatformComponentArcControl platformComponentArcControl_2)
		{
			this.platformComponentArcControl_0 = platformComponentArcControl_2;
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x00214A28 File Offset: 0x00212C28
		[CompilerGenerated]
		internal  Label vmethod_16()
		{
			return this.label_0;
		}

		// Token: 0x06005183 RID: 20867 RVA: 0x0002607A File Offset: 0x0002427A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_3)
		{
			this.label_0 = label_3;
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x00214A40 File Offset: 0x00212C40
		[CompilerGenerated]
		internal  PlatformComponentArcControl vmethod_18()
		{
			return this.platformComponentArcControl_1;
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x00026083 File Offset: 0x00024283
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(PlatformComponentArcControl platformComponentArcControl_2)
		{
			this.platformComponentArcControl_1 = platformComponentArcControl_2;
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x00214A58 File Offset: 0x00212C58
		[CompilerGenerated]
		internal  Label vmethod_20()
		{
			return this.label_1;
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x0002608C File Offset: 0x0002428C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Label label_3)
		{
			this.label_1 = label_3;
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x00214A70 File Offset: 0x00212C70
		[CompilerGenerated]
		internal  Label vmethod_22()
		{
			return this.label_2;
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x00026095 File Offset: 0x00024295
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Label label_3)
		{
			this.label_2 = label_3;
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x00214A88 File Offset: 0x00212C88
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_24()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x0002609E File Offset: 0x0002429E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x00214AA0 File Offset: 0x00212CA0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_26()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x000260A7 File Offset: 0x000242A7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x000260B0 File Offset: 0x000242B0
		private void AddSensor_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_2().RunWorkerAsync();
			this.vmethod_6().Text = "Fetching sensors...";
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x00214AB8 File Offset: 0x00212CB8
		private void method_1(object sender, EventArgs e)
		{
			if (!Information.IsNothing(Client.GetHookedUnit()) && Client.GetHookedUnit().IsActiveUnit() && (!this.vmethod_18().method_0() || Interaction.MsgBox("You have defined no detection arcs for this sensor. Are you sure?", MsgBoxStyle.YesNo, "No detection arcs defined!") != MsgBoxResult.No))
			{
				int dBID = Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value);
				SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
				Sensor sensor = DBFunctions.LoadSensorData(dBID, ref sQLiteConnection);
				sensor.coverageArc = this.vmethod_18().struct19_0;
				sensor.coverageArcMax = this.vmethod_14().struct19_0;
				((ActiveUnit)Client.GetHookedUnit()).AddSensor(sensor);
				sensor.SetParentPlatform((ActiveUnit)Client.GetHookedUnit());
				if (!Information.IsNothing(Client.unitSensors))
				{
					Client.unitSensors.method_3();
				}
			}
		}

		// Token: 0x06005190 RID: 20880 RVA: 0x00214B9C File Offset: 0x00212D9C
		private void method_2(object sender, DoWorkEventArgs e)
		{
			SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
			this.dataTable_0 = DBFunctions.smethod_68(ref sQLiteConnection);
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x000260E5 File Offset: 0x000242E5
		private void method_3(object sender, RunWorkerCompletedEventArgs e)
		{
			this.vmethod_6().Text = "点击表头按ID或名称进行排序； 点击一行选择传感器。";
			this.method_6();
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x000260FD File Offset: 0x000242FD
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_10().Checked & Operators.CompareString(this.vmethod_12().Text, "", false) != 0)
			{
				this.method_5();
			}
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x00214BC4 File Offset: 0x00212DC4
		private void method_5()
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Name ASC";
			dataView.RowFilter = "Name LIKE '%" + this.vmethod_12().Text + "%'";
			this.vmethod_0().DataSource = dataView;
			this.vmethod_0().Refresh();
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x00026132 File Offset: 0x00024332
		private void method_6()
		{
			this.dataView_0 = new DataView(this.dataTable_0);
			this.dataView_0.Sort = "Name ASC";
			this.vmethod_0().AutoGenerateColumns = false;
			this.vmethod_0().DataSource = this.dataView_0;
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x00214C20 File Offset: 0x00212E20
		private void AddSensor_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06005196 RID: 20886 RVA: 0x00026172 File Offset: 0x00024372
		private void method_7(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x0002617B File Offset: 0x0002437B
		private void method_8(object sender, EventArgs e)
		{
			this.bool_0 = false;
			this.vmethod_10().Select();
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x00004D83 File Offset: 0x00002F83
		private void AddSensor_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x04002647 RID: 9799
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04002648 RID: 9800
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04002649 RID: 9801
		[CompilerGenerated]
		private StatusStrip statusStrip_0;

		// Token: 0x0400264A RID: 9802
		[CompilerGenerated]
		private ToolStripStatusLabel toolStripStatusLabel_0;

		// Token: 0x0400264B RID: 9803
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x0400264C RID: 9804
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x0400264D RID: 9805
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x0400264E RID: 9806
		[CompilerGenerated]
		private PlatformComponentArcControl platformComponentArcControl_0;

		// Token: 0x0400264F RID: 9807
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04002650 RID: 9808
		[CompilerGenerated]
		private PlatformComponentArcControl platformComponentArcControl_1;

		// Token: 0x04002651 RID: 9809
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04002652 RID: 9810
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04002653 RID: 9811
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04002654 RID: 9812
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04002655 RID: 9813
		private DataTable dataTable_0;

		// Token: 0x04002656 RID: 9814
		private DataView dataView_0;

		// Token: 0x04002657 RID: 9815
		private bool bool_0;

		// Token: 0x04002658 RID: 9816
		public Form form_0;
	}
}

using System;
using System.Collections;
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
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns32;

namespace ns33
{
	// Token: 0x0200096E RID: 2414
	[DesignerGenerated]
	public sealed partial class AddMagazine : CommandForm
	{
		// Token: 0x06003B50 RID: 15184 RVA: 0x0012500C File Offset: 0x0012320C
		public AddMagazine()
		{
			base.Shown += new EventHandler(this.AddMagazine_Shown);
			base.KeyDown += new KeyEventHandler(this.AddMagazine_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.AddMagazine_FormClosing);
			base.Load += new EventHandler(this.AddMagazine_Load);
			this.InitializeComponent();
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x001255B0 File Offset: 0x001237B0
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x0001F7CF File Offset: 0x0001D9CF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			this.dataGridView_0 = dataGridView_1;
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_2(BackgroundWorker backgroundWorker_1)
		{
			this.backgroundWorker_0 = backgroundWorker_1;
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x001255C8 File Offset: 0x001237C8
		[CompilerGenerated]
		internal  StatusStrip vmethod_3()
		{
			return this.statusStrip_0;
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x0001F7E1 File Offset: 0x0001D9E1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_4(StatusStrip statusStrip_1)
		{
			this.statusStrip_0 = statusStrip_1;
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x001255E0 File Offset: 0x001237E0
		[CompilerGenerated]
		internal  ToolStripStatusLabel vmethod_5()
		{
			return this.toolStripStatusLabel_0;
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x0001F7EA File Offset: 0x0001D9EA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_6(ToolStripStatusLabel toolStripStatusLabel_1)
		{
			this.toolStripStatusLabel_0 = toolStripStatusLabel_1;
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x001255F8 File Offset: 0x001237F8
		[CompilerGenerated]
		internal  Button vmethod_7()
		{
			return this.button_0;
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x00125610 File Offset: 0x00123810
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_8(Button button_1)
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

		// Token: 0x06003B5C RID: 15196 RVA: 0x0012565C File Offset: 0x0012385C
		[CompilerGenerated]
		internal  TextBox vmethod_9()
		{
			return this.textBox_0;
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x00125674 File Offset: 0x00123874
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_10(TextBox textBox_1)
		{
			EventHandler value = new EventHandler(this.method_3);
			EventHandler value2 = new EventHandler(this.method_6);
			EventHandler value3 = new EventHandler(this.method_7);
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

		// Token: 0x06003B5E RID: 15198 RVA: 0x001256F4 File Offset: 0x001238F4
		[CompilerGenerated]
		internal  CheckBox vmethod_11()
		{
			return this.checkBox_0;
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x0001F7F3 File Offset: 0x0001D9F3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_12(CheckBox checkBox_1)
		{
			this.checkBox_0 = checkBox_1;
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x0012570C File Offset: 0x0012390C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_13()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x0001F7FC File Offset: 0x0001D9FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_14(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x00125724 File Offset: 0x00123924
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_15()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x0001F805 File Offset: 0x0001DA05
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_16(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x0001F80E File Offset: 0x0001DA0E
		private void AddMagazine_Shown(object sender, EventArgs e)
		{
			this.method_2();
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x0012573C File Offset: 0x0012393C
		private void method_1(object sender, EventArgs e)
		{
			if (this.form_0 == Client.magazines)
			{
				Magazine magazine = DBFunctions.GetMagazine(Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value), ref Client.magazines.activeUnit_0.m_Scenario, true);
				ScenarioArrayUtil.AddMagazine(ref ((Platform)Client.magazines.activeUnit_0).m_Magazines, magazine);
				magazine.SetParentPlatform((ActiveUnit)Client.GetHookedUnit());
				Client.magazines.method_12();
			}
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x001257CC File Offset: 0x001239CC
		private void method_2()
		{
			SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
			this.dataTable_0 = DBFunctions.smethod_67(ref sQLiteConnection);
			if (!this.dataTable_0.Columns.Contains("Description"))
			{
				this.dataTable_0.Columns.Add("Description", typeof(string));
			}
			IEnumerator enumerator = this.dataTable_0.Rows.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					dataRow["Description"] = RuntimeHelpers.GetObjectValue(dataRow["Name"]);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.vmethod_5().Text = "Sort magazines by clicking on column headers (ID or Description); Click on a magazine to select it.";
			this.method_5();
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x0001F816 File Offset: 0x0001DA16
		private void method_3(object sender, EventArgs e)
		{
			if (this.vmethod_11().Checked & Operators.CompareString(this.vmethod_9().Text, "", false) != 0)
			{
				this.method_4();
			}
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x001258B0 File Offset: 0x00123AB0
		private void method_4()
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Description ASC";
			dataView.RowFilter = "Description LIKE '%" + this.vmethod_9().Text + "%'";
			this.vmethod_0().DataSource = dataView;
			this.vmethod_0().Refresh();
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x0001F84B File Offset: 0x0001DA4B
		private void method_5()
		{
			this.dataView_0 = new DataView(this.dataTable_0);
			this.dataView_0.Sort = "Description ASC";
			this.vmethod_0().AutoGenerateColumns = false;
			this.vmethod_0().DataSource = this.dataView_0;
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x0012590C File Offset: 0x00123B0C
		private void AddMagazine_KeyDown(object sender, KeyEventArgs e)
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
						this.vmethod_11().Select();
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

		// Token: 0x06003B6B RID: 15211 RVA: 0x0001F88B File Offset: 0x0001DA8B
		private void method_6(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x0001F894 File Offset: 0x0001DA94
		private void method_7(object sender, EventArgs e)
		{
			this.bool_0 = false;
			this.vmethod_11().Select();
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x00004D83 File Offset: 0x00002F83
		private void AddMagazine_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void AddMagazine_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001B0A RID: 6922
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04001B0B RID: 6923
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04001B0C RID: 6924
		[CompilerGenerated]
		private StatusStrip statusStrip_0;

		// Token: 0x04001B0D RID: 6925
		[CompilerGenerated]
		private ToolStripStatusLabel toolStripStatusLabel_0;

		// Token: 0x04001B0E RID: 6926
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001B0F RID: 6927
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04001B10 RID: 6928
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04001B11 RID: 6929
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04001B12 RID: 6930
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04001B13 RID: 6931
		private DataTable dataTable_0;

		// Token: 0x04001B14 RID: 6932
		private DataView dataView_0;

		// Token: 0x04001B15 RID: 6933
		private bool bool_0;

		// Token: 0x04001B16 RID: 6934
		public Form form_0;
	}
}

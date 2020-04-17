using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	// Token: 0x02000A2E RID: 2606
	[DesignerGenerated]
	public sealed partial class AddWeaponRecord : CommandForm
	{
		// Token: 0x06005263 RID: 21091 RVA: 0x0021AD30 File Offset: 0x00218F30
		public AddWeaponRecord()
		{
			base.Shown += new EventHandler(this.AddWeaponRecord_Shown);
			base.KeyDown += new KeyEventHandler(this.AddWeaponRecord_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.AddWeaponRecord_FormClosing);
			base.Load += new EventHandler(this.AddWeaponRecord_Load);
			this.InitializeComponent();
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x0021B3DC File Offset: 0x002195DC
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x000265BF File Offset: 0x000247BF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			this.dataGridView_0 = dataGridView_1;
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x000265C8 File Offset: 0x000247C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_2(BackgroundWorker backgroundWorker_1)
		{
			this.backgroundWorker_0 = backgroundWorker_1;
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x0021B3F4 File Offset: 0x002195F4
		[CompilerGenerated]
		internal  StatusStrip vmethod_3()
		{
			return this.statusStrip_0;
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x000265D1 File Offset: 0x000247D1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_4(StatusStrip statusStrip_1)
		{
			this.statusStrip_0 = statusStrip_1;
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x0021B40C File Offset: 0x0021960C
		[CompilerGenerated]
		internal  ToolStripStatusLabel vmethod_5()
		{
			return this.toolStripStatusLabel_0;
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x000265DA File Offset: 0x000247DA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_6(ToolStripStatusLabel toolStripStatusLabel_1)
		{
			this.toolStripStatusLabel_0 = toolStripStatusLabel_1;
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x0021B424 File Offset: 0x00219624
		[CompilerGenerated]
		internal  Button vmethod_7()
		{
			return this.button_0;
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x0021B43C File Offset: 0x0021963C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_8(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_1);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_2;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x0021B488 File Offset: 0x00219688
		[CompilerGenerated]
		internal  CheckBox vmethod_9()
		{
			return this.checkBox_0;
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x0021B4A0 File Offset: 0x002196A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_10(CheckBox checkBox_2)
		{
			EventHandler value = new EventHandler(this.method_5);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_0 = checkBox_2;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x0021B4EC File Offset: 0x002196EC
		[CompilerGenerated]
		internal  TextBox vmethod_11()
		{
			return this.textBox_0;
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x0021B504 File Offset: 0x00219704
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_12(TextBox textBox_1)
		{
			EventHandler value = new EventHandler(this.method_3);
			EventHandler value2 = new EventHandler(this.method_10);
			EventHandler value3 = new EventHandler(this.method_11);
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

		// Token: 0x06005273 RID: 21107 RVA: 0x0021B584 File Offset: 0x00219784
		[CompilerGenerated]
		internal  CheckBox vmethod_13()
		{
			return this.checkBox_1;
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x0021B59C File Offset: 0x0021979C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_14(CheckBox checkBox_2)
		{
			EventHandler value = new EventHandler(this.method_7);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_1 = checkBox_2;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x0021B5E8 File Offset: 0x002197E8
		[CompilerGenerated]
		internal  Button vmethod_15()
		{
			return this.button_1;
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x0021B600 File Offset: 0x00219800
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_16(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_12);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_2;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x0021B64C File Offset: 0x0021984C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_17()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x000265E3 File Offset: 0x000247E3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_18(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x0021B664 File Offset: 0x00219864
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_19()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x0600527A RID: 21114 RVA: 0x000265EC File Offset: 0x000247EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_20(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600527B RID: 21115 RVA: 0x0021B67C File Offset: 0x0021987C
		private void method_1(object sender, EventArgs e)
		{
			if (this.form_0 == Client.smethod_26())
			{
				WeaponRec weaponRec = DBFunctions.LoadWeaponRecordData(Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value), Client.GetClientScenario());
				Client.smethod_26().method_1(weaponRec);
				Client.smethod_26().method_9();
			}
			if (this.form_0 == Client.magazines)
			{
				WeaponRec item = DBFunctions.LoadWeaponRecordData(Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value), Client.magazines.activeUnit_0.m_Scenario);
				Client.magazines.magazine_0.GetWeaponRecCollection().Add(item);
			}
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x0021B740 File Offset: 0x00219940
		private void method_2()
		{
			SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
			this.dataTable_0 = DBFunctions.smethod_69(ref sQLiteConnection);
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
					dataRow["Description"] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["Name"], " ("), dataRow["DefaultLoad"]), "/"), dataRow["MaxLoad"]), ") - ROF:"), dataRow["ROF"]);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.vmethod_5().Text = "点击表头按ID或名称进行排序；点击一行选择。";
			this.method_6();
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x000265F5 File Offset: 0x000247F5
		private void method_3(object sender, EventArgs e)
		{
			if (this.vmethod_9().Checked & Operators.CompareString(this.vmethod_11().Text, "", false) != 0)
			{
				this.method_4();
			}
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x0021B86C File Offset: 0x00219A6C
		private void method_4()
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Description ASC";
			dataView.RowFilter = "Description LIKE '%" + this.vmethod_11().Text + "%'";
			this.vmethod_0().DataSource = dataView;
			this.vmethod_0().Refresh();
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x0002662A File Offset: 0x0002482A
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_9().Checked)
			{
				this.vmethod_13().Checked = false;
			}
		}

		// Token: 0x06005280 RID: 21120 RVA: 0x00026648 File Offset: 0x00024848
		private void method_6()
		{
			this.dataView_0 = new DataView(this.dataTable_0);
			this.dataView_0.Sort = "Description ASC";
			this.vmethod_0().AutoGenerateColumns = false;
			this.vmethod_0().DataSource = this.dataView_0;
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x00026688 File Offset: 0x00024888
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_13().Checked)
			{
				this.vmethod_9().Checked = false;
				this.method_8();
			}
			else
			{
				this.method_6();
			}
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x0021B8C8 File Offset: 0x00219AC8
		private void method_8()
		{
			Collection<int> collection = new Collection<int>();
			List<Aircraft>.Enumerator enumerator = this.method_9().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int dBID = enumerator.Current.DBID;
					SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
					Collection<int> collection2 = DBFunctions.smethod_43(dBID, ref sQLiteConnection);
					foreach (int current in collection2)
					{
						if (!collection.Contains(current))
						{
							collection.Add(current);
						}
					}
				}
			}
			finally
			{
				IDisposable disposable = enumerator;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Description ASC";
			if (collection.Count > 0)
			{
				string text = "(";
				foreach (int current2 in collection)
				{
					text = text + Conversions.ToString(current2) + ",";
				}
				text += ")";
				dataView.RowFilter = "ComponentID IN " + text;
			}
			else
			{
				dataView.RowFilter = "1=2";
			}
			this.vmethod_0().DataSource = dataView;
			this.vmethod_0().Refresh();
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x0021BA50 File Offset: 0x00219C50
		private List<Aircraft> method_9()
		{
			List<Aircraft> result;
			if (this.form_0 == Client.magazines)
			{
				ActiveUnit parentPlatform = Client.magazines.magazine_0.GetParentPlatform();
				if (parentPlatform.HasParentGroup())
				{
					if (parentPlatform.GetParentGroup(false).HasFixedFacility())
					{
						result = parentPlatform.GetParentGroup(false).GetAirOps().GetHostedAircrafts();
					}
					else
					{
						result = parentPlatform.GetAirOps().GetHostedAircrafts();
					}
				}
				else
				{
					result = parentPlatform.GetAirOps().GetHostedAircrafts();
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x0021BAD0 File Offset: 0x00219CD0
		private void AddWeaponRecord_Shown(object sender, EventArgs e)
		{
			this.method_2();
			if (!Information.IsNothing(Client.magazines))
			{
				if (this.form_0 == Client.magazines)
				{
					List<Aircraft> list = this.method_9();
					this.vmethod_13().Visible = (!Information.IsNothing(list) && list.Count > 0);
				}
				else
				{
					this.vmethod_13().Visible = false;
				}
			}
			else
			{
				this.vmethod_13().Visible = false;
			}
			if (this.vmethod_13().Visible)
			{
				this.vmethod_13().Checked = true;
			}
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x0021BB60 File Offset: 0x00219D60
		private void AddWeaponRecord_KeyDown(object sender, KeyEventArgs e)
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
						this.vmethod_9().Select();
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

		// Token: 0x06005286 RID: 21126 RVA: 0x000266B4 File Offset: 0x000248B4
		private void method_10(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x000266BD File Offset: 0x000248BD
		private void method_11(object sender, EventArgs e)
		{
			this.bool_0 = false;
			this.vmethod_9().Select();
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x00004D83 File Offset: 0x00002F83
		private void AddWeaponRecord_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x0021BC94 File Offset: 0x00219E94
		private void method_12(object sender, EventArgs e)
		{
			if (this.form_0 == Client.smethod_26())
			{
				WeaponRec weaponRec = DBFunctions.LoadWeaponRecordData(Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value), Client.GetClientScenario());
				weaponRec.RecID = null;
				weaponRec.SetCurrentLoad(10000);
				weaponRec.MaxLoad = 10000;
				Client.smethod_26().method_1(weaponRec);
				Client.smethod_26().method_9();
			}
			if (this.form_0 == Client.magazines)
			{
				WeaponRec weaponRec2 = DBFunctions.LoadWeaponRecordData(Conversions.ToInteger(this.vmethod_0().CurrentRow.Cells["ID"].Value), Client.magazines.activeUnit_0.m_Scenario);
				weaponRec2.RecID = null;
				weaponRec2.MaxLoad = 10000;
				Client.magazines.magazine_0.GetWeaponRecCollection().Add(weaponRec2);
			}
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void AddWeaponRecord_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x040026AB RID: 9899
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x040026AC RID: 9900
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x040026AD RID: 9901
		[CompilerGenerated]
		private StatusStrip statusStrip_0;

		// Token: 0x040026AE RID: 9902
		[CompilerGenerated]
		private ToolStripStatusLabel toolStripStatusLabel_0;

		// Token: 0x040026AF RID: 9903
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x040026B0 RID: 9904
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x040026B1 RID: 9905
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x040026B2 RID: 9906
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x040026B3 RID: 9907
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x040026B4 RID: 9908
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x040026B5 RID: 9909
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x040026B6 RID: 9910
		private DataTable dataTable_0;

		// Token: 0x040026B7 RID: 9911
		private DataView dataView_0;

		// Token: 0x040026B8 RID: 9912
		private bool bool_0;

		// Token: 0x040026B9 RID: 9913
		public Form form_0;
	}
}

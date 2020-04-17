using System;
using System.Collections.Generic;
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
	// Token: 0x02000A45 RID: 2629
	[DesignerGenerated]
	public sealed partial class SelectLoadout : CommandForm
	{
		// Token: 0x06005379 RID: 21369 RVA: 0x00222F64 File Offset: 0x00221164
		public SelectLoadout()
		{
			base.Load += new EventHandler(this.SelectLoadout_Load);
			base.KeyDown += new KeyEventHandler(this.SelectLoadout_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.SelectLoadout_FormClosing);
			this.geoPoint_0 = new GeoPoint();
			this.dataTable_0 = new DataTable();
			this.dataTable_1 = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x00223B48 File Offset: 0x00221D48
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x00223B60 File Offset: 0x00221D60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_2)
		{
			KeyEventHandler value = new KeyEventHandler(this.method_5);
			EventHandler value2 = new EventHandler(this.method_6);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value;
				dataGridView.SelectionChanged -= value2;
			}
			this.dataGridView_0 = dataGridView_2;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value;
				dataGridView.SelectionChanged += value2;
			}
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x00223BC4 File Offset: 0x00221DC4
		[CompilerGenerated]
		internal  DataGridView vmethod_2()
		{
			return this.dataGridView_1;
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x00026B64 File Offset: 0x00024D64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DataGridView dataGridView_2)
		{
			this.dataGridView_1 = dataGridView_2;
		}

		// Token: 0x06005380 RID: 21376 RVA: 0x00223BDC File Offset: 0x00221DDC
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_0;
		}

		// Token: 0x06005381 RID: 21377 RVA: 0x00026B6D File Offset: 0x00024D6D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x00223BF4 File Offset: 0x00221DF4
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_0;
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x00223C0C File Offset: 0x00221E0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_2)
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

		// Token: 0x06005384 RID: 21380 RVA: 0x00223C58 File Offset: 0x00221E58
		[CompilerGenerated]
		internal  Button vmethod_8()
		{
			return this.button_1;
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x00223C70 File Offset: 0x00221E70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_3);
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

		// Token: 0x06005386 RID: 21382 RVA: 0x00223CBC File Offset: 0x00221EBC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_10()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x00026B76 File Offset: 0x00024D76
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x00223CD4 File Offset: 0x00221ED4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_12()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x00026B7F File Offset: 0x00024D7F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x00223CEC File Offset: 0x00221EEC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_14()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x00026B88 File Offset: 0x00024D88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x00223D04 File Offset: 0x00221F04
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_16()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x00026B91 File Offset: 0x00024D91
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x00223D1C File Offset: 0x00221F1C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_18()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x00026B9A File Offset: 0x00024D9A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x00223D34 File Offset: 0x00221F34
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_20()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x00026BA3 File Offset: 0x00024DA3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x00223D4C File Offset: 0x00221F4C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_22()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x00026BAC File Offset: 0x00024DAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x00223D64 File Offset: 0x00221F64
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_24()
		{
			return this.dataGridViewTextBoxColumn_7;
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x00026BB5 File Offset: 0x00024DB5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_7 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x00223D7C File Offset: 0x00221F7C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_26()
		{
			return this.dataGridViewTextBoxColumn_8;
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x00026BBE File Offset: 0x00024DBE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9)
		{
			this.dataGridViewTextBoxColumn_8 = dataGridViewTextBoxColumn_9;
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x00223D94 File Offset: 0x00221F94
		private void SelectLoadout_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.geoPoint_0 = CommandFactory.GetCommandMain().GetMainForm().geoPoint_0;
			this.vmethod_0().AutoGenerateColumns = false;
			int aircraftID = this.int_0;
			Dictionary<int, int> selectedAircraftTotalWeaponQty = null;
			SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
			Scenario clientScenario = Client.GetClientScenario();
			bool flag = false;
			Scenario scenario = null;
			Aircraft aircraft = null;
			int num = 0;
			bool flag2 = false;
			this.dataTable_0 = DBFunctions.smethod_42(aircraftID, selectedAircraftTotalWeaponQty, ref sQLiteConnection, clientScenario, ref flag, ref scenario, ref aircraft, ref num, ref flag2);
			this.vmethod_0().DataSource = this.dataTable_0;
			this.vmethod_2().DataSource = this.method_4(this.int_1);
			this.int_1 = Conversions.ToInteger(this.vmethod_0().Rows[0].Cells["ID"].Value);
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x00026BC7 File Offset: 0x00024DC7
		private void method_1(object sender, EventArgs e)
		{
			this.method_2();
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x00223E78 File Offset: 0x00222078
		private void method_2()
		{
			Aircraft aircraft = Client.GetClientScenario().AddAircraft(this.side_0, this.string_0, this.geoPoint_0.GetLongitude(), this.geoPoint_0.GetLatitude(), this.int_0, this.int_1, 100f, CommandFactory.GetCommandMain().GetAddNewUnit().string_0);
			Aircraft aircraft2 = aircraft;
			ActiveUnit_AI aircraftAI = aircraft.GetAircraftAI();
			Aircraft aircraft3;
			ActiveUnit activeUnit_;
			bool bool_ = (aircraft3 = aircraft).IsTerrainFollowing(activeUnit_ = aircraft);
			float desiredAltitude = aircraftAI.method_78(ref aircraft, ActiveUnit.Throttle.Cruise, ref bool_);
			aircraft3.SetIsTerrainFollowing(activeUnit_, bool_);
			aircraft2.SetDesiredAltitude(desiredAltitude);
			aircraft.SetAltitude_ASL(false, aircraft.GetDesiredAltitude());
			checked
			{
				if (!Information.IsNothing(aircraft.GetLoadout()))
				{
					WeaponRec[] weaponRecArray = aircraft.GetLoadout().WeaponRecArray;
					for (int i = 0; i < weaponRecArray.Length; i++)
					{
						weaponRecArray[i].GetWeapon(aircraft.m_Scenario).SetAltitude_ASL(false, aircraft.GetCurrentAltitude_ASL(false));
					}
				}
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
				if (CommandFactory.GetCommandMain().GetAddNewUnit().Visible)
				{
					CommandFactory.GetCommandMain().GetAddNewUnit().Close();
				}
				base.Close();
			}
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x00223F9C File Offset: 0x0022219C
		private DataTable method_4(int int_2)
		{
			int num = this.int_1;
			SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
			bool flag = false;
			return DBFunctions.LoadLoadoutWeaponsData(num, ref sQLiteConnection, ref flag);
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00026BCF File Offset: 0x00024DCF
		private void method_5(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.method_2();
			}
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x00223FCC File Offset: 0x002221CC
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				this.int_1 = Conversions.ToInteger(this.vmethod_0().SelectedRows[0].Cells["ID"].Value);
				this.vmethod_2().DataSource = this.method_4(this.int_1);
			}
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		private void SelectLoadout_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x00004D83 File Offset: 0x00002F83
		private void SelectLoadout_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x0400272F RID: 10031
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04002730 RID: 10032
		[CompilerGenerated]
		private DataGridView dataGridView_1;

		// Token: 0x04002731 RID: 10033
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04002732 RID: 10034
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04002733 RID: 10035
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04002734 RID: 10036
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04002735 RID: 10037
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04002736 RID: 10038
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04002737 RID: 10039
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04002738 RID: 10040
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04002739 RID: 10041
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x0400273A RID: 10042
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x0400273B RID: 10043
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		// Token: 0x0400273C RID: 10044
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		// Token: 0x0400273D RID: 10045
		public string string_0;

		// Token: 0x0400273E RID: 10046
		public int int_0;

		// Token: 0x0400273F RID: 10047
		public Side side_0;

		// Token: 0x04002740 RID: 10048
		private int int_1;

		// Token: 0x04002741 RID: 10049
		private GeoPoint geoPoint_0;

		// Token: 0x04002742 RID: 10050
		private DataTable dataTable_0;

		// Token: 0x04002743 RID: 10051
		private DataTable dataTable_1;
	}
}

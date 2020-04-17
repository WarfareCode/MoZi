using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x020009C5 RID: 2501
	[DesignerGenerated]
	public sealed partial class EditBoats : CommandForm
	{
		// Token: 0x0600438B RID: 17291 RVA: 0x0018B8F4 File Offset: 0x00189AF4
		public EditBoats()
		{
			base.Load += new EventHandler(this.EditBoats_Load);
			base.FormClosing += new FormClosingEventHandler(this.EditBoats_FormClosing);
			base.KeyDown += new KeyEventHandler(this.EditBoats_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x0018C8AC File Offset: 0x0018AAAC
		[CompilerGenerated]
		internal  GroupBox vmethod_0()
		{
			return this.groupBox_0;
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x00021C09 File Offset: 0x0001FE09
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(GroupBox groupBox_2)
		{
			this.groupBox_0 = groupBox_2;
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x0018C8C4 File Offset: 0x0018AAC4
		[CompilerGenerated]
		internal  ComboBox vmethod_2()
		{
			return this.comboBox_0;
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x0018C8DC File Offset: 0x0018AADC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ComboBox comboBox_2)
		{
			EventHandler value = new EventHandler(this.method_11);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value;
			}
			this.comboBox_0 = comboBox_2;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x0018C928 File Offset: 0x0018AB28
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_0;
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x00021C12 File Offset: 0x0001FE12
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_6)
		{
			this.label_0 = label_6;
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x0018C940 File Offset: 0x0018AB40
		[CompilerGenerated]
		internal  Label vmethod_6()
		{
			return this.label_1;
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x00021C1B File Offset: 0x0001FE1B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Label label_6)
		{
			this.label_1 = label_6;
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x0018C958 File Offset: 0x0018AB58
		[CompilerGenerated]
		internal  TextBox vmethod_8()
		{
			return this.textBox_0;
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x0018C970 File Offset: 0x0018AB70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TextBox textBox_2)
		{
			EventHandler value = new EventHandler(this.method_9);
			TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
			}
			this.textBox_0 = textBox_2;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged += value;
			}
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x0018C9BC File Offset: 0x0018ABBC
		[CompilerGenerated]
		internal  DataGridView vmethod_10()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x0018C9D4 File Offset: 0x0018ABD4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DataGridView dataGridView_1)
		{
			KeyPressEventHandler value = new KeyPressEventHandler(this.method_8);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.KeyPress -= value;
			}
			this.dataGridView_0 = dataGridView_1;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.KeyPress += value;
			}
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x0018CA20 File Offset: 0x0018AC20
		[CompilerGenerated]
		internal  Button vmethod_12()
		{
			return this.button_0;
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x0018CA38 File Offset: 0x0018AC38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_7);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_3;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x0018CA84 File Offset: 0x0018AC84
		[CompilerGenerated]
		internal  GroupBox vmethod_14()
		{
			return this.groupBox_1;
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x00021C24 File Offset: 0x0001FE24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(GroupBox groupBox_2)
		{
			this.groupBox_1 = groupBox_2;
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x0018CA9C File Offset: 0x0018AC9C
		[CompilerGenerated]
		internal  NumericUpDown vmethod_16()
		{
			return this.numericUpDown_0;
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x00021C2D File Offset: 0x0001FE2D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(NumericUpDown numericUpDown_1)
		{
			this.numericUpDown_0 = numericUpDown_1;
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x0018CAB4 File Offset: 0x0018ACB4
		[CompilerGenerated]
		internal  Button vmethod_18()
		{
			return this.button_1;
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x0018CACC File Offset: 0x0018ACCC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_6);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_3;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x0018CB18 File Offset: 0x0018AD18
		[CompilerGenerated]
		internal  TextBox vmethod_20()
		{
			return this.textBox_1;
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x00021C36 File Offset: 0x0001FE36
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(TextBox textBox_2)
		{
			this.textBox_1 = textBox_2;
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x0018CB30 File Offset: 0x0018AD30
		[CompilerGenerated]
		internal  Label vmethod_22()
		{
			return this.label_2;
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x00021C3F File Offset: 0x0001FE3F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Label label_6)
		{
			this.label_2 = label_6;
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x0018CB48 File Offset: 0x0018AD48
		[CompilerGenerated]
		internal  Button vmethod_24()
		{
			return this.button_2;
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x0018CB60 File Offset: 0x0018AD60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_5);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_3;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x0018CBAC File Offset: 0x0018ADAC
		[CompilerGenerated]
		internal  Label vmethod_26()
		{
			return this.label_3;
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x00021C48 File Offset: 0x0001FE48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Label label_6)
		{
			this.label_3 = label_6;
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x0018CBC4 File Offset: 0x0018ADC4
		[CompilerGenerated]
		internal  Label vmethod_28()
		{
			return this.label_4;
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x00021C51 File Offset: 0x0001FE51
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Label label_6)
		{
			this.label_4 = label_6;
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x0018CBDC File Offset: 0x0018ADDC
		[CompilerGenerated]
		internal  ListView vmethod_30()
		{
			return this.listView_0;
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x0018CBF4 File Offset: 0x0018ADF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(ListView listView_1)
		{
			ListViewItemSelectionChangedEventHandler value = new ListViewItemSelectionChangedEventHandler(this.method_3);
			ListView listView = this.listView_0;
			if (listView != null)
			{
				listView.ItemSelectionChanged -= value;
			}
			this.listView_0 = listView_1;
			listView = this.listView_0;
			if (listView != null)
			{
				listView.ItemSelectionChanged += value;
			}
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x0018CC40 File Offset: 0x0018AE40
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_32()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x00021C5A File Offset: 0x0001FE5A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x0018CC58 File Offset: 0x0018AE58
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_34()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x00021C63 File Offset: 0x0001FE63
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x0018CC70 File Offset: 0x0018AE70
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_36()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x00021C6C File Offset: 0x0001FE6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x0018CC88 File Offset: 0x0018AE88
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_38()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x00021C75 File Offset: 0x0001FE75
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x0018CCA0 File Offset: 0x0018AEA0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_40()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x00021C7E File Offset: 0x0001FE7E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x0018CCB8 File Offset: 0x0018AEB8
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_42()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x00021C87 File Offset: 0x0001FE87
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x0018CCD0 File Offset: 0x0018AED0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_44()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x00021C90 File Offset: 0x0001FE90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_7;
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x0018CCE8 File Offset: 0x0018AEE8
		[CompilerGenerated]
		internal  ComboBox vmethod_46()
		{
			return this.comboBox_1;
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x0018CD00 File Offset: 0x0018AF00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(ComboBox comboBox_2)
		{
			EventHandler value = new EventHandler(this.method_12);
			ComboBox comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_1 = comboBox_2;
			comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x0018CD4C File Offset: 0x0018AF4C
		[CompilerGenerated]
		internal  Label vmethod_48()
		{
			return this.label_5;
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x00021C99 File Offset: 0x0001FE99
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Label label_6)
		{
			this.label_5 = label_6;
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x0018CD64 File Offset: 0x0018AF64
		private void EditBoats_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_46().SelectedIndex = 0;
			this.method_1();
			DataTable cache_OperatorCountries_DT = Client.GetClientScenario().Cache_OperatorCountries_DT;
			this.vmethod_2().DataSource = cache_OperatorCountries_DT;
			this.vmethod_2().DisplayMember = "Description";
			this.vmethod_2().ValueMember = "ID";
			this.vmethod_2().SelectedIndex = 0;
			this.Text = "Edit docked boats for " + this.activeUnit_0.Name;
			this.method_10();
			this.method_2();
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x0018CE08 File Offset: 0x0018B008
		private void method_1()
		{
			int selectedIndex = this.vmethod_46().SelectedIndex;
			if (selectedIndex != 0)
			{
				if (selectedIndex == 1)
				{
					this.dataTable_0 = Client.GetClientScenario().Cache_Subs_DT.Copy();
				}
			}
			else
			{
				this.dataTable_0 = Client.GetClientScenario().Cache_Ships_DT.Copy();
			}
			List<DataRow> list = new List<DataRow>();
			IEnumerator enumerator = this.dataTable_0.Rows.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					short short_ = Conversions.ToShort(dataRow["Length"]);
					DockFacility._DockFacilityPhysicalSizeCode dockFacilityPhysicalSizeCode_ = (DockFacility._DockFacilityPhysicalSizeCode)Conversions.ToShort(dataRow["PhysicalSizeCode"]);
					if (!this.activeUnit_0.GetDockingOps().method_38(short_, dockFacilityPhysicalSizeCode_))
					{
						list.Add(dataRow);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			foreach (DataRow current in list)
			{
				this.dataTable_0.Rows.Remove(current);
			}
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x0018CF44 File Offset: 0x0018B144
		private void EditBoats_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Stop)
			{
				CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit(), false);
			}
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
			CommandFactory.GetCommandMain().GetMainForm().GetMapBox().Focus();
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x0018CFAC File Offset: 0x0018B1AC
		private void method_2()
		{
			Client.b_Completed = true;
			this.vmethod_30().Clear();
			IEnumerable<int> enumerable = this.activeUnit_0.GetDockingOps().GetDockedUnits().Where(EditBoats.ActiveUnitFunc0).Select(EditBoats.ActiveUnitFunc1).Distinct<int>();
			IEnumerable<int> enumerable2 = this.activeUnit_0.GetDockingOps().GetDockedUnits().Where(EditBoats.ActiveUnitFunc2).Select(EditBoats.ActiveUnitFunc3).Distinct<int>();
			foreach (int current in enumerable)
			{
				EditBoats.Class2514 @class = new EditBoats.Class2514(null);
				@class.int_0 = current;
				IEnumerable<ActiveUnit> source = this.activeUnit_0.GetDockingOps().GetDockedUnits().Where(new Func<ActiveUnit, bool>(@class.method_0));
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Tag = "Ship_" + Conversions.ToString(@class.int_0);
				listViewItem.Text = Conversions.ToString(source.Count<ActiveUnit>()) + "x " + source.ElementAtOrDefault(0).UnitClass;
				this.vmethod_30().Items.Add(listViewItem);
			}
			foreach (int current2 in enumerable2)
			{
				EditBoats.Class2515 class2 = new EditBoats.Class2515(null);
				class2.int_0 = current2;
				IEnumerable<ActiveUnit> source2 = this.activeUnit_0.GetDockingOps().GetDockedUnits().Where(new Func<ActiveUnit, bool>(class2.method_0));
				ListViewItem listViewItem2 = new ListViewItem();
				listViewItem2.Tag = "Sub_" + Conversions.ToString(class2.int_0);
				listViewItem2.Text = Conversions.ToString(source2.Count<ActiveUnit>()) + "x " + source2.ElementAtOrDefault(0).UnitClass;
				this.vmethod_30().Items.Add(listViewItem2);
			}
			this.vmethod_12().Visible = (this.vmethod_30().SelectedItems.Count > 0);
			this.vmethod_12().Enabled = this.vmethod_12().Visible;
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x0018D1FC File Offset: 0x0018B3FC
		private void method_3(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (this.vmethod_30().SelectedItems.Count > 0)
			{
				EditBoats.Class2516 @class = new EditBoats.Class2516();
				string text = this.vmethod_30().SelectedItems[0].Tag.ToString();
				@class.int_0 = Conversions.ToInteger(text.Split(new char[]
				{
					'_'
				})[1]);
				string left = text.Split(new char[]
				{
					'_'
				})[0];
				int value;
				if (Operators.CompareString(left, "Ship", false) != 0)
				{
					if (Operators.CompareString(left, "Sub", false) != 0)
					{
						throw new NotImplementedException();
					}
					value = this.activeUnit_0.GetDockingOps().GetDockedUnits().Where(new Func<ActiveUnit, bool>(@class.method_1)).Count<ActiveUnit>();
				}
				else
				{
					value = this.activeUnit_0.GetDockingOps().GetDockedUnits().Where(new Func<ActiveUnit, bool>(@class.method_0)).Count<ActiveUnit>();
				}
				this.vmethod_16().Value = new decimal(value);
			}
			this.vmethod_12().Visible = (this.vmethod_30().SelectedItems.Count > 0);
			this.vmethod_12().Enabled = this.vmethod_12().Visible;
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x0018D340 File Offset: 0x0018B540
		private void method_4(int int_0, ref bool bool_0)
		{
			int selectedIndex = this.vmethod_46().SelectedIndex;
			if (selectedIndex == 0)
			{
				Ship ship = Client.GetClientScenario().AddShip(Client.GetClientSide(), int_0, "", 0.0, 0.0, false, null);
				ship.Name = ship.UnitClass + " #" + Conversions.ToString(Client.GetClientScenario().UnitsAutoIncrement);
				if (this.activeUnit_0.GetDockingOps().method_37(ship))
				{
					this.activeUnit_0.GetDockingOps().method_39(ship);
				}
				else
				{
					Scenario clientScenario = Client.GetClientScenario();
					GameGeneral.RemoveUnit(ref clientScenario, ship.GetGuid());
					bool_0 = true;
				}
				bool arg_AB_0 = Debugger.IsAttached;
			}
			else if (selectedIndex == 1)
			{
				Submarine submarine = Client.GetClientScenario().AddSubmarine(Client.GetClientSide(), int_0, "", 0.0, 0.0, false, null);
				submarine.Name = submarine.UnitClass + " #" + Conversions.ToString(Client.GetClientScenario().UnitsAutoIncrement);
				if (this.activeUnit_0.GetDockingOps().method_37(submarine))
				{
					this.activeUnit_0.GetDockingOps().method_39(submarine);
				}
				else
				{
					Scenario clientScenario = Client.GetClientScenario();
					GameGeneral.RemoveUnit(ref clientScenario, submarine.GetGuid());
					bool_0 = true;
				}
				bool arg_14D_0 = Debugger.IsAttached;
			}
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x0018D49C File Offset: 0x0018B69C
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_10().SelectedRows.Count != 0)
			{
				int num = Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells[0].Value.ToString());
				if (!(num == 10000 | num == 10001 | num == 10002) && Versioned.IsNumeric(this.vmethod_20().Text))
				{
					this.vmethod_24().Text = "Working...";
					this.vmethod_24().Enabled = false;
					bool flag = false;
					int num2 = Conversions.ToInteger(this.vmethod_20().Text);
					for (int i = 1; i <= num2; i++)
					{
						this.method_4(num, ref flag);
					}
					if (flag)
					{
						Interaction.MsgBox("Unable to add all boats to host - Exceeded maximum docking space.", MsgBoxStyle.OkOnly, "Out of space!");
					}
					this.vmethod_24().Text = "Add Selected";
					this.vmethod_24().Enabled = true;
					this.method_2();
				}
			}
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x0018D5A8 File Offset: 0x0018B7A8
		private void method_6(object sender, EventArgs e)
		{
			EditBoats.Class2517 @class = new EditBoats.Class2517(null);
			if (this.vmethod_30().SelectedItems.Count != 0)
			{
				this.vmethod_18().Text = "Working...";
				this.vmethod_18().Enabled = false;
				string text = this.vmethod_30().SelectedItems[0].Tag.ToString();
				@class.int_0 = Conversions.ToInteger(text.Split(new char[]
				{
					'_'
				})[1]);
				string left = text.Split(new char[]
				{
					'_'
				})[0];
				IEnumerable<ActiveUnit> source;
				if (Operators.CompareString(left, "Ship", false) != 0)
				{
					if (Operators.CompareString(left, "Sub", false) != 0)
					{
						throw new NotImplementedException();
					}
					source = this.activeUnit_0.GetDockingOps().GetDockedUnits().Where(new Func<ActiveUnit, bool>(@class.method_1));
				}
				else
				{
					source = this.activeUnit_0.GetDockingOps().GetDockedUnits().Where(new Func<ActiveUnit, bool>(@class.method_0));
				}
				if (decimal.Compare(this.vmethod_16().Value, new decimal(source.Count<ActiveUnit>())) < 0)
				{
					int num = source.Count<ActiveUnit>() - 1;
					int num2 = Convert.ToInt32(this.vmethod_16().Value);
					for (int i = num; i >= num2; i += -1)
					{
						Scenario clientScenario = Client.GetClientScenario();
						GameGeneral.RemoveUnit(ref clientScenario, source.ElementAtOrDefault(i).GetGuid());
					}
				}
				bool flag = false;
				if (decimal.Compare(this.vmethod_16().Value, new decimal(source.Count<ActiveUnit>())) > 0)
				{
					source.Select(EditBoats.ActiveUnitFunc4).ElementAtOrDefault(0);
					int num3 = source.Count<ActiveUnit>() + 1;
					int num4 = Convert.ToInt32(this.vmethod_16().Value);
					for (int j = num3; j <= num4; j++)
					{
						this.method_4(@class.int_0, ref flag);
					}
				}
				if (flag)
				{
					Interaction.MsgBox("Unable to add all boats to host - Exceeded maximum docking space.", MsgBoxStyle.OkOnly, "Out of space!");
				}
				this.vmethod_18().Text = "Apply";
				this.vmethod_18().Enabled = true;
				this.method_2();
			}
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x0018D7DC File Offset: 0x0018B9DC
		private void method_7(object sender, EventArgs e)
		{
			EditBoats.Class2518 @class = new EditBoats.Class2518(null);
			string text = this.vmethod_30().SelectedItems[0].Tag.ToString();
			@class.int_0 = Conversions.ToInteger(text.Split(new char[]
			{
				'_'
			})[1]);
			string left = text.Split(new char[]
			{
				'_'
			})[0];
			IEnumerable<ActiveUnit> source;
			if (Operators.CompareString(left, "Ship", false) != 0)
			{
				if (Operators.CompareString(left, "Sub", false) != 0)
				{
					throw new NotImplementedException();
				}
				source = this.activeUnit_0.GetDockingOps().GetDockedUnits().Where(new Func<ActiveUnit, bool>(@class.method_1));
			}
			else
			{
				source = this.activeUnit_0.GetDockingOps().GetDockedUnits().Where(new Func<ActiveUnit, bool>(@class.method_0));
			}
			for (int i = source.Count<ActiveUnit>() - 1; i >= 0; i += -1)
			{
				Scenario clientScenario = Client.GetClientScenario();
				GameGeneral.RemoveUnit(ref clientScenario, source.ElementAtOrDefault(i).GetGuid());
			}
			this.method_2();
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x0018D8F4 File Offset: 0x0018BAF4
		private void method_8(object sender, KeyPressEventArgs e)
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Name ASC";
			dataView.RowFilter = "Name LIKE '" + Conversions.ToString(e.KeyChar) + "%'";
			if (dataView.Count > 0)
			{
				int num = Conversions.ToInteger(dataView[0][0]);
				int firstDisplayedScrollingRowIndex = 0;
				IEnumerator enumerator = ((IEnumerable)this.vmethod_10().Rows).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
						if (Conversions.ToInteger(dataGridViewRow.Cells[0].Value) == num)
						{
							firstDisplayedScrollingRowIndex = dataGridViewRow.Index;
							break;
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.vmethod_10().FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
			}
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x00021CA2 File Offset: 0x0001FEA2
		private void method_9(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.vmethod_8().Text, "", false) != 0)
			{
				this.method_10();
			}
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x0018D9E8 File Offset: 0x0018BBE8
		private void method_10()
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Name ASC";
			if (!(Operators.CompareString(this.vmethod_8().Text, "", false) == 0 & this.vmethod_2().SelectedIndex == 0))
			{
				string text = "1=1 ";
				if (Operators.CompareString(this.vmethod_8().Text, "", false) != 0)
				{
					string str = this.vmethod_8().Text.Replace("'", "''");
					text = text + " AND Name LIKE '%" + str + "%' ";
				}
				if (this.vmethod_2().SelectedIndex > 0)
				{
					text = text + " AND OperatorCountry=" + this.vmethod_2().SelectedValue.ToString();
				}
				text = text.Replace("[", "[[");
				text = text.Replace("]", "]]");
				text = text.Replace("[[", "[[]");
				text = text.Replace("]]", "[]]");
				dataView.RowFilter = text;
			}
			this.vmethod_10().AutoGenerateColumns = false;
			this.vmethod_10().DataSource = dataView;
			this.vmethod_10().Refresh();
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x00021CC5 File Offset: 0x0001FEC5
		private void method_11(object sender, EventArgs e)
		{
			this.method_10();
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x00021CCD File Offset: 0x0001FECD
		private void method_12(object sender, EventArgs e)
		{
			this.method_1();
			this.method_10();
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void EditBoats_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x04001F9C RID: 8092
		public static Func<ActiveUnit, bool> ActiveUnitFunc0 = (ActiveUnit activeUnit_0) => activeUnit_0.IsShip;

		// Token: 0x04001F9D RID: 8093
		public static Func<ActiveUnit, int> ActiveUnitFunc1 = (ActiveUnit activeUnit_0) => activeUnit_0.DBID;

		// Token: 0x04001F9E RID: 8094
		public static Func<ActiveUnit, bool> ActiveUnitFunc2 = (ActiveUnit activeUnit_0) => activeUnit_0.IsSubmarine;

		// Token: 0x04001F9F RID: 8095
		public static Func<ActiveUnit, int> ActiveUnitFunc3 = (ActiveUnit activeUnit_0) => activeUnit_0.DBID;

		// Token: 0x04001FA0 RID: 8096
		public static Func<ActiveUnit, int> ActiveUnitFunc4 = (ActiveUnit activeUnit_0) => activeUnit_0.DBID;

		// Token: 0x04001FA2 RID: 8098
		[CompilerGenerated]
		private GroupBox groupBox_0;

		// Token: 0x04001FA3 RID: 8099
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04001FA4 RID: 8100
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001FA5 RID: 8101
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001FA6 RID: 8102
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04001FA7 RID: 8103
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04001FA8 RID: 8104
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001FA9 RID: 8105
		[CompilerGenerated]
		private GroupBox groupBox_1;

		// Token: 0x04001FAA RID: 8106
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x04001FAB RID: 8107
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001FAC RID: 8108
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x04001FAD RID: 8109
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04001FAE RID: 8110
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04001FAF RID: 8111
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04001FB0 RID: 8112
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04001FB1 RID: 8113
		[CompilerGenerated]
		private ListView listView_0;

		// Token: 0x04001FB2 RID: 8114
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04001FB3 RID: 8115
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04001FB4 RID: 8116
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04001FB5 RID: 8117
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04001FB6 RID: 8118
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04001FB7 RID: 8119
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x04001FB8 RID: 8120
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x04001FB9 RID: 8121
		[CompilerGenerated]
		private ComboBox comboBox_1;

		// Token: 0x04001FBA RID: 8122
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x04001FBB RID: 8123
		public ActiveUnit activeUnit_0;

		// Token: 0x04001FBC RID: 8124
		private DataTable dataTable_0;

		// Token: 0x020009C6 RID: 2502
		[CompilerGenerated]
		public sealed class Class2514
		{
			// Token: 0x060043D5 RID: 17365 RVA: 0x00021CDB File Offset: 0x0001FEDB
			public Class2514(EditBoats.Class2514 class2514_0)
			{
				if (class2514_0 != null)
				{
					this.int_0 = class2514_0.int_0;
				}
			}

			// Token: 0x060043D6 RID: 17366 RVA: 0x00021CF5 File Offset: 0x0001FEF5
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.IsShip & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04001FC2 RID: 8130
			public int int_0;
		}

		// Token: 0x020009C7 RID: 2503
		[CompilerGenerated]
		public sealed class Class2515
		{
			// Token: 0x060043D7 RID: 17367 RVA: 0x00021D0C File Offset: 0x0001FF0C
			public Class2515(EditBoats.Class2515 class2515_0)
			{
				if (class2515_0 != null)
				{
					this.int_0 = class2515_0.int_0;
				}
			}

			// Token: 0x060043D8 RID: 17368 RVA: 0x00021D26 File Offset: 0x0001FF26
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.IsSubmarine & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04001FC3 RID: 8131
			public int int_0;
		}

		// Token: 0x020009C8 RID: 2504
		[CompilerGenerated]
		public sealed class Class2516
		{
			// Token: 0x060043D9 RID: 17369 RVA: 0x00021D3D File Offset: 0x0001FF3D
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.IsShip & string.CompareOrdinal(Conversions.ToString(activeUnit_0.DBID), Conversions.ToString(this.int_0)) == 0;
			}

			// Token: 0x060043DA RID: 17370 RVA: 0x00021D64 File Offset: 0x0001FF64
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.IsSubmarine & string.CompareOrdinal(Conversions.ToString(activeUnit_0.DBID), Conversions.ToString(this.int_0)) == 0;
			}

			// Token: 0x04001FC4 RID: 8132
			public int int_0;
		}

		// Token: 0x020009C9 RID: 2505
		[CompilerGenerated]
		public sealed class Class2517
		{
			// Token: 0x060043DC RID: 17372 RVA: 0x00021D8B File Offset: 0x0001FF8B
			public Class2517(EditBoats.Class2517 class2517_0)
			{
				if (class2517_0 != null)
				{
					this.int_0 = class2517_0.int_0;
				}
			}

			// Token: 0x060043DD RID: 17373 RVA: 0x00021DA5 File Offset: 0x0001FFA5
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.IsShip & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x060043DE RID: 17374 RVA: 0x00021DBC File Offset: 0x0001FFBC
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.IsSubmarine & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04001FC5 RID: 8133
			public int int_0;
		}

		// Token: 0x020009CA RID: 2506
		[CompilerGenerated]
		public sealed class Class2518
		{
			// Token: 0x060043DF RID: 17375 RVA: 0x00021DD3 File Offset: 0x0001FFD3
			public Class2518(EditBoats.Class2518 class2518_0)
			{
				if (class2518_0 != null)
				{
					this.int_0 = class2518_0.int_0;
				}
			}

			// Token: 0x060043E0 RID: 17376 RVA: 0x00021DED File Offset: 0x0001FFED
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.IsShip & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x060043E1 RID: 17377 RVA: 0x00021E04 File Offset: 0x00020004
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.IsSubmarine & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04001FC6 RID: 8134
			public int int_0;
		}
	}
}

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
using ns0;
using ns2;
using ns32;
using ns33;

namespace Command
{
	// 编辑飞机（AirCraft）
	[DesignerGenerated]
	public sealed partial class EditAC : CommandForm
	{
		// Token: 0x060040F3 RID: 16627 RVA: 0x00162494 File Offset: 0x00160694
		public EditAC()
		{
			base.FormClosing += new FormClosingEventHandler(this.EditAC_FormClosing);
			base.Load += new EventHandler(this.EditAC_Load);
			base.KeyDown += new KeyEventHandler(this.EditAC_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x00163674 File Offset: 0x00161874
//		[CompilerGenerated]
//		internal  ListView vmethod_0()
//		{
//			return this.listView_0;
//		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x0016368C File Offset: 0x0016188C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_1(ListView listView_1)
//		{
//			ListViewItemSelectionChangedEventHandler value = new ListViewItemSelectionChangedEventHandler(this.method_2);
//			ListView listView = this.listView_0;
//			if (listView != null)
//			{
//				listView.ItemSelectionChanged -= value;
//			}
//			this.listView_0 = listView_1;
//			listView = this.listView_0;
//			if (listView != null)
//			{
//				listView.ItemSelectionChanged += value;
//			}
//		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x001636D8 File Offset: 0x001618D8
//		[CompilerGenerated]
//		internal  Label vmethod_2()
//		{
//			return this.label_0;
//		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x000210B0 File Offset: 0x0001F2B0
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_3(Label label_7)
//		{
//			this.label_0 = label_7;
//		}

		// Token: 0x060040FA RID: 16634 RVA: 0x001636F0 File Offset: 0x001618F0
//		[CompilerGenerated]
//		internal  Label vmethod_4()
//		{
//			return this.label_1;
//		}

		// Token: 0x060040FB RID: 16635 RVA: 0x000210B9 File Offset: 0x0001F2B9
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_5(Label label_7)
//		{
//			this.label_1 = label_7;
//		}

		// Token: 0x060040FC RID: 16636 RVA: 0x00163708 File Offset: 0x00161908
//		[CompilerGenerated]
//		internal  NumericUpDown vmethod_6()
//		{
//			return this.numericUpDown_0;
//		}

		// Token: 0x060040FD RID: 16637 RVA: 0x000210C2 File Offset: 0x0001F2C2
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_7(NumericUpDown numericUpDown_1)
//		{
//			this.numericUpDown_0 = numericUpDown_1;
//		}

		// Token: 0x060040FE RID: 16638 RVA: 0x00163720 File Offset: 0x00161920
//		[CompilerGenerated]
//		internal  TextBox vmethod_8()
//		{
//			return this.textBox_0;
//		}

		// Token: 0x060040FF RID: 16639 RVA: 0x000210CB File Offset: 0x0001F2CB
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_9(TextBox textBox_3)
//		{
//			this.textBox_0 = textBox_3;
//		}

		// Token: 0x06004100 RID: 16640 RVA: 0x00163738 File Offset: 0x00161938
//		[CompilerGenerated]
//		internal  Label vmethod_10()
//		{
//			return this.label_2;
//		}

		// Token: 0x06004101 RID: 16641 RVA: 0x000210D4 File Offset: 0x0001F2D4
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_11(Label label_7)
//		{
//			this.label_2 = label_7;
//		}

		// Token: 0x06004102 RID: 16642 RVA: 0x00163750 File Offset: 0x00161950
//		[CompilerGenerated]
//		internal  Button vmethod_12()
//		{
//			return this.button_0;
//		}

		// Token: 0x06004103 RID: 16643 RVA: 0x00163768 File Offset: 0x00161968
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_13(Button button_3)
//		{
//			EventHandler value = new EventHandler(this.method_3);
//			Button button = this.button_0;
//			if (button != null)
//			{
//				button.Click -= value;
//			}
//			this.button_0 = button_3;
//			button = this.button_0;
//			if (button != null)
//			{
//				button.Click += value;
//			}
//		}

		// Token: 0x06004104 RID: 16644 RVA: 0x001637B4 File Offset: 0x001619B4
//		[CompilerGenerated]
//		internal  Label vmethod_14()
//		{
//			return this.label_3;
//		}

		// Token: 0x06004105 RID: 16645 RVA: 0x000210DD File Offset: 0x0001F2DD
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_15(Label label_7)
//		{
//			this.label_3 = label_7;
//		}

		// Token: 0x06004106 RID: 16646 RVA: 0x001637CC File Offset: 0x001619CC
//		[CompilerGenerated]
//		internal  TextBox vmethod_16()
//		{
//			return this.textBox_1;
//		}

		// Token: 0x06004107 RID: 16647 RVA: 0x000210E6 File Offset: 0x0001F2E6
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_17(TextBox textBox_3)
//		{
//			this.textBox_1 = textBox_3;
//		}

		// Token: 0x06004108 RID: 16648 RVA: 0x001637E4 File Offset: 0x001619E4
//		[CompilerGenerated]
//		internal  Button vmethod_18()
//		{
//			return this.button_1;
//		}

		// Token: 0x06004109 RID: 16649 RVA: 0x001637FC File Offset: 0x001619FC
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_19(Button button_3)
//		{
//			EventHandler value = new EventHandler(this.method_4);
//			Button button = this.button_1;
//			if (button != null)
//			{
//				button.Click -= value;
//			}
//			this.button_1 = button_3;
//			button = this.button_1;
//			if (button != null)
//			{
//				button.Click += value;
//			}
//		}

		// Token: 0x0600410A RID: 16650 RVA: 0x00163848 File Offset: 0x00161A48
//		[CompilerGenerated]
//		internal  GroupBox vmethod_20()
//		{
//			return this.groupBox_0;
//		}

		// Token: 0x0600410B RID: 16651 RVA: 0x000210EF File Offset: 0x0001F2EF
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_21(GroupBox groupBox_2)
//		{
//			this.groupBox_0 = groupBox_2;
//		}

		// Token: 0x0600410C RID: 16652 RVA: 0x00163860 File Offset: 0x00161A60
//		[CompilerGenerated]
//		internal  Button vmethod_22()
//		{
//			return this.button_2;
//		}

		// Token: 0x0600410D RID: 16653 RVA: 0x00163878 File Offset: 0x00161A78
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_23(Button button_3)
//		{
//			EventHandler value = new EventHandler(this.method_5);
//			Button button = this.button_2;
//			if (button != null)
//			{
//				button.Click -= value;
//			}
//			this.button_2 = button_3;
//			button = this.button_2;
//			if (button != null)
//			{
//				button.Click += value;
//			}
//		}

		// Token: 0x0600410E RID: 16654 RVA: 0x001638C4 File Offset: 0x00161AC4
//		[CompilerGenerated]
//		internal  DataGridView vmethod_24()
//		{
//			return this.dataGridView_0;
//		}

		// Token: 0x0600410F RID: 16655 RVA: 0x001638DC File Offset: 0x00161ADC
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_25(DataGridView dataGridView_1)
//		{
//			KeyPressEventHandler value = new KeyPressEventHandler(this.method_6);
//			DataGridView dataGridView = this.dataGridView_0;
//			if (dataGridView != null)
//			{
//				dataGridView.KeyPress -= value;
//			}
//			this.dataGridView_0 = dataGridView_1;
//			dataGridView = this.dataGridView_0;
//			if (dataGridView != null)
//			{
//				dataGridView.KeyPress += value;
//			}
//		}

		// Token: 0x06004110 RID: 16656 RVA: 0x00163928 File Offset: 0x00161B28
//		[CompilerGenerated]
//		internal  GroupBox vmethod_26()
//		{
//			return this.groupBox_1;
//		}

		// Token: 0x06004111 RID: 16657 RVA: 0x000210F8 File Offset: 0x0001F2F8
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_27(GroupBox groupBox_2)
//		{
//			this.groupBox_1 = groupBox_2;
//		}

		// Token: 0x06004112 RID: 16658 RVA: 0x00163940 File Offset: 0x00161B40
//		[CompilerGenerated]
//		internal  ComboBox vmethod_28()
//		{
//			return this.comboBox_0;
//		}

		// Token: 0x06004113 RID: 16659 RVA: 0x00163958 File Offset: 0x00161B58
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_29(ComboBox comboBox_2)
//		{
//			EventHandler value = new EventHandler(this.method_9);
//			ComboBox comboBox = this.comboBox_0;
//			if (comboBox != null)
//			{
//				comboBox.SelectedIndexChanged -= value;
//			}
//			this.comboBox_0 = comboBox_2;
//			comboBox = this.comboBox_0;
//			if (comboBox != null)
//			{
//				comboBox.SelectedIndexChanged += value;
//			}
//		}

		// Token: 0x06004114 RID: 16660 RVA: 0x001639A4 File Offset: 0x00161BA4
//		[CompilerGenerated]
//		internal  Label vmethod_30()
//		{
//			return this.label_4;
//		}

		// Token: 0x06004115 RID: 16661 RVA: 0x00021101 File Offset: 0x0001F301
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_31(Label label_7)
//		{
//			this.label_4 = label_7;
//		}

		// Token: 0x06004116 RID: 16662 RVA: 0x001639BC File Offset: 0x00161BBC
//		[CompilerGenerated]
//		internal  Label vmethod_32()
//		{
//			return this.label_5;
//		}

		// Token: 0x06004117 RID: 16663 RVA: 0x0002110A File Offset: 0x0001F30A
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_33(Label label_7)
//		{
//			this.label_5 = label_7;
//		}

		// Token: 0x06004118 RID: 16664 RVA: 0x001639D4 File Offset: 0x00161BD4
//		[CompilerGenerated]
//		internal  TextBox vmethod_34()
//		{
//			return this.textBox_2;
//		}

		// Token: 0x06004119 RID: 16665 RVA: 0x001639EC File Offset: 0x00161BEC
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_35(TextBox textBox_3)
//		{
//			EventHandler value = new EventHandler(this.method_7);
//			TextBox textBox = this.textBox_2;
//			if (textBox != null)
//			{
//				textBox.TextChanged -= value;
//			}
//			this.textBox_2 = textBox_3;
//			textBox = this.textBox_2;
//			if (textBox != null)
//			{
//				textBox.TextChanged += value;
//			}
//		}

		// Token: 0x0600411A RID: 16666 RVA: 0x00163A38 File Offset: 0x00161C38
//		[CompilerGenerated]
//		internal  CheckBox vmethod_36()
//		{
//			return this.checkBox_0;
//		}

		// Token: 0x0600411B RID: 16667 RVA: 0x00021113 File Offset: 0x0001F313
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_37(CheckBox checkBox_1)
//		{
//			this.checkBox_0 = checkBox_1;
//		}

		// Token: 0x0600411C RID: 16668 RVA: 0x00163A50 File Offset: 0x00161C50
//		[CompilerGenerated]
//		internal  ComboBox vmethod_38()
//		{
//			return this.comboBox_1;
//		}

		// Token: 0x0600411D RID: 16669 RVA: 0x00163A68 File Offset: 0x00161C68
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_39(ComboBox comboBox_2)
//		{
//			EventHandler value = new EventHandler(this.method_10);
//			ComboBox comboBox = this.comboBox_1;
//			if (comboBox != null)
//			{
//				comboBox.SelectionChangeCommitted -= value;
//			}
//			this.comboBox_1 = comboBox_2;
//			comboBox = this.comboBox_1;
//			if (comboBox != null)
//			{
//				comboBox.SelectionChangeCommitted += value;
//			}
//		}

		// Token: 0x0600411E RID: 16670 RVA: 0x00163AB4 File Offset: 0x00161CB4
//		[CompilerGenerated]
//		internal  Label vmethod_40()
//		{
//			return this.label_6;
//		}

		// Token: 0x0600411F RID: 16671 RVA: 0x0002111C File Offset: 0x0001F31C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_41(Label label_7)
//		{
//			this.label_6 = label_7;
//		}

		// Token: 0x06004120 RID: 16672 RVA: 0x00163ACC File Offset: 0x00161CCC
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_42()
//		{
//			return this.dataGridViewTextBoxColumn_0;
//		}

		// Token: 0x06004121 RID: 16673 RVA: 0x00021125 File Offset: 0x0001F325
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_43(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
//		{
//			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_7;
//		}

		// Token: 0x06004122 RID: 16674 RVA: 0x00163AE4 File Offset: 0x00161CE4
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_44()
//		{
//			return this.dataGridViewTextBoxColumn_1;
//		}

		// Token: 0x06004123 RID: 16675 RVA: 0x0002112E File Offset: 0x0001F32E
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_45(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
//		{
//			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_7;
//		}

		// Token: 0x06004124 RID: 16676 RVA: 0x00163AFC File Offset: 0x00161CFC
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_46()
//		{
//			return this.dataGridViewTextBoxColumn_2;
//		}

		// Token: 0x06004125 RID: 16677 RVA: 0x00021137 File Offset: 0x0001F337
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_47(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
//		{
//			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_7;
//		}

		// Token: 0x06004126 RID: 16678 RVA: 0x00163B14 File Offset: 0x00161D14
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_48()
//		{
//			return this.dataGridViewTextBoxColumn_3;
//		}

		// Token: 0x06004127 RID: 16679 RVA: 0x00021140 File Offset: 0x0001F340
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_49(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
//		{
//			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_7;
//		}

		// Token: 0x06004128 RID: 16680 RVA: 0x00163B2C File Offset: 0x00161D2C
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_50()
//		{
//			return this.dataGridViewTextBoxColumn_4;
//		}

		// Token: 0x06004129 RID: 16681 RVA: 0x00021149 File Offset: 0x0001F349
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_51(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
//		{
//			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_7;
//		}

		// Token: 0x0600412A RID: 16682 RVA: 0x00163B44 File Offset: 0x00161D44
//		[CompilerGenerated]
//		internal  DataGridViewCheckBoxColumn vmethod_52()
//		{
//			return this.dataGridViewCheckBoxColumn_0;
//		}

		// Token: 0x0600412B RID: 16683 RVA: 0x00021152 File Offset: 0x0001F352
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_53(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1)
//		{
//			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_1;
//		}

		// Token: 0x0600412C RID: 16684 RVA: 0x00163B5C File Offset: 0x00161D5C
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_54()
//		{
//			return this.dataGridViewTextBoxColumn_5;
//		}

		// Token: 0x0600412D RID: 16685 RVA: 0x0002115B File Offset: 0x0001F35B
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_55(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
//		{
//			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_7;
//		}

		// Token: 0x0600412E RID: 16686 RVA: 0x00163B74 File Offset: 0x00161D74
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_56()
//		{
//			return this.dataGridViewTextBoxColumn_6;
//		}

		// Token: 0x0600412F RID: 16687 RVA: 0x00021164 File Offset: 0x0001F364
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_57(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7)
//		{
//			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_7;
//		}

		// Token: 0x06004130 RID: 16688 RVA: 0x00163B8C File Offset: 0x00161D8C
		private void EditAC_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Stop)
			{
				CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit(), false);
			}
			Client.b_Completed = true;
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x00163BE4 File Offset: 0x00161DE4
		private void EditAC_Load(object sender, EventArgs e)
		{
			this.dataTable_0 = Client.GetClientScenario().Cache_Aircraft_DT;
			DataTable cache_OperatorCountries_DT = Client.GetClientScenario().Cache_OperatorCountries_DT;
			this.comboBox_0.DataSource = cache_OperatorCountries_DT;
			this.comboBox_0.DisplayMember = "Description";
			this.comboBox_0.ValueMember = "ID";
			this.comboBox_0.SelectedIndex = 0;
			this.comboBox_1.Items.Clear();
			this.comboBox_1.Items.Add("Show all platforms, both real-life and hypothetical");
			this.comboBox_1.Items.Add("Show real-life platforms only");
			this.comboBox_1.Items.Add("Show hypothetical platforms only");
			this.comboBox_1.SelectedIndex = 0;
			this.Text = "Edit Aircraft for " + this.activeUnit_0.Name;
			this.method_8();
			this.method_1();
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x00163CCC File Offset: 0x00161ECC
		private void method_1()
		{
			Client.b_Completed = true;
			this.listView_0.Clear();
			IEnumerable<int> enumerable = this.activeUnit_0.GetAirOps().GetHostedAircrafts().Select(EditAC.AircraftFunc).Distinct<int>();
			foreach (int current in enumerable)
			{
				EditAC.Class2510 @class = new EditAC.Class2510(null);
				@class.int_0 = current;
				IEnumerable<Aircraft> source = this.activeUnit_0.GetAirOps().GetHostedAircrafts().Where(new Func<Aircraft, bool>(@class.method_0));
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Tag = @class.int_0;
				listViewItem.Text = Conversions.ToString(source.Count<Aircraft>()) + "x " + source.ElementAtOrDefault(0).UnitClass;
				this.listView_0.Items.Add(listViewItem);
			}
			this.button_2.Visible = (this.listView_0.SelectedItems.Count > 0);
			this.button_2.Enabled = this.button_2.Visible;
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x00163E04 File Offset: 0x00162004
		private void method_2(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (this.listView_0.SelectedItems.Count > 0)
			{
				int value = this.activeUnit_0.GetAirOps().GetHostedAircrafts().Where(new Func<Aircraft, bool>(this.method_11)).Count<Aircraft>();
				this.numericUpDown_0.Value = new decimal(value);
			}
			this.button_2.Visible = (this.listView_0.SelectedItems.Count > 0);
			this.button_2.Enabled = this.button_2.Visible;
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x00163E98 File Offset: 0x00162098
		private void method_3(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows.Count != 0)
			{
				int num = Conversions.ToInteger(this.dataGridView_0.SelectedRows[0].Cells[0].Value.ToString());
				if (!(num == 10000 | num == 10001 | num == 10002))
				{
					string str;
					if (string.IsNullOrEmpty(this.textBox_0.Text))
					{
						str = CallsignGenerator.smethod_3();
					}
					else
					{
						str = this.textBox_0.Text;
					}
					if (Versioned.IsNumeric(this.textBox_1.Text))
					{
						this.button_0.Text = "正在工作...";
						this.button_0.Enabled = false;
						int num2 = Conversions.ToInteger(this.textBox_1.Text);
						for (int i = 1; i <= num2; i++)
						{
							Aircraft aircraft = Client.GetClientScenario().AddAircraft(Client.GetClientSide(), str + " #" + Conversions.ToString(i), 0.0, 0.0, num, 0, 0f, null);
							if (!this.activeUnit_0.GetAirOps().CanBeHostedOnAirFacility(aircraft))
							{
								Scenario clientScenario = Client.GetClientScenario();
								GameGeneral.RemoveUnit(ref clientScenario, aircraft.GetGuid());
								Interaction.MsgBox("不能将所有飞机添加到机场 -超过了停放容量限制.", MsgBoxStyle.OkOnly, "停放空间不够!");
								this.button_0.Text = "添加所选";
								this.button_0.Enabled = true;
								this.method_1();
								return;
							}
							this.activeUnit_0.GetAirOps().method_18(aircraft, false);
						}
						this.button_0.Text = "添加所选";
						this.button_0.Enabled = true;
						this.method_1();
					}
				}
			}
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x00164058 File Offset: 0x00162258
		private void method_4(object sender, EventArgs e)
		{
			if (this.listView_0.SelectedItems.Count != 0)
			{
				this.button_1.Text = "正在工作...";
				this.button_1.Enabled = false;
				IEnumerable<Aircraft> source = this.activeUnit_0.GetAirOps().GetHostedAircrafts().Where(new Func<Aircraft, bool>(this.method_12));
				if (decimal.Compare(this.numericUpDown_0.Value, new decimal(source.Count<Aircraft>())) < 0)
				{
					int num = source.Count<Aircraft>() - 1;
					int num2 = Convert.ToInt32(this.numericUpDown_0.Value);
					for (int i = num; i >= num2; i += -1)
					{
						Scenario clientScenario = Client.GetClientScenario();
						GameGeneral.RemoveUnit(ref clientScenario, source.ElementAtOrDefault(i).GetGuid());
					}
				}
				if (decimal.Compare(this.numericUpDown_0.Value, new decimal(source.Count<Aircraft>())) > 0)
				{
					int aircraftDBID = source.Select(EditAC.AircraftFunc).ElementAtOrDefault(0);
					string str = CallsignGenerator.smethod_3();
					int num3 = source.Count<Aircraft>() + 1;
					int num4 = Convert.ToInt32(this.numericUpDown_0.Value);
					for (int j = num3; j <= num4; j++)
					{
						Aircraft aircraft = Client.GetClientScenario().AddAircraft(Client.GetClientSide(), str + " " + Conversions.ToString(j), 0.0, 0.0, aircraftDBID, 0, 0f, null);
						if (!this.activeUnit_0.GetAirOps().CanBeHostedOnAirFacility(aircraft))
						{
							Scenario clientScenario = Client.GetClientScenario();
							GameGeneral.RemoveUnit(ref clientScenario, aircraft.GetGuid());
							Interaction.MsgBox("不能将所有飞机添加到机场 -超过了停放容量限制.", MsgBoxStyle.OkOnly, "停放空间不够!");
							break;
						}
						this.activeUnit_0.GetAirOps().method_18(aircraft, false);
					}
				}
				this.button_1.Text = "Apply";
				this.button_1.Enabled = true;
				this.method_1();
			}
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x00164248 File Offset: 0x00162448
		private void method_5(object sender, EventArgs e)
		{
			IEnumerable<Aircraft> source = this.activeUnit_0.GetAirOps().GetHostedAircrafts().Where(new Func<Aircraft, bool>(this.method_13));
			for (int i = source.Count<Aircraft>() - 1; i >= 0; i += -1)
			{
				Scenario clientScenario = Client.GetClientScenario();
				GameGeneral.RemoveUnit(ref clientScenario, source.ElementAtOrDefault(i).GetGuid());
			}
			this.method_1();
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x001642B0 File Offset: 0x001624B0
		private void method_6(object sender, KeyPressEventArgs e)
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Name ASC";
			dataView.RowFilter = "Name LIKE '" + Conversions.ToString(e.KeyChar) + "%'";
			if (dataView.Count > 0)
			{
				int num = Conversions.ToInteger(dataView[0][0]);
				int firstDisplayedScrollingRowIndex = 0;
				IEnumerator enumerator = ((IEnumerable)this.dataGridView_0.Rows).GetEnumerator();
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
				this.dataGridView_0.FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
			}
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x0002116D File Offset: 0x0001F36D
		private void method_7(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.textBox_2.Text, "", false) != 0)
			{
				this.method_8();
			}
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x001643A4 File Offset: 0x001625A4
		private void method_8()
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "Name ASC";
			if (Operators.CompareString(this.textBox_2.Text, "", false) != 0 || this.comboBox_0.SelectedIndex != 0 || this.comboBox_1.SelectedIndex != 0)
			{
				string text = "1=1 ";
				if (Operators.CompareString(this.textBox_2.Text, "", false) != 0)
				{
					string str = this.textBox_2.Text.Replace("'", "''");
					text = text + " AND Name LIKE '%" + str + "%' ";
				}
				if (this.comboBox_0.SelectedIndex > 0)
				{
					text = text + " AND OperatorCountry=" + this.comboBox_0.SelectedValue.ToString();
				}
				if (this.comboBox_1.SelectedIndex == 1)
				{
					text += " AND Hypothetical=FALSE";
				}
				else if (this.comboBox_1.SelectedIndex == 2)
				{
					text += " AND Hypothetical=TRUE";
				}
				text = text.Replace("[", "[[");
				text = text.Replace("]", "]]");
				text = text.Replace("[[", "[[]");
				text = text.Replace("]]", "[]]");
				if (this.checkBox_0.Checked)
				{
					GlobalVariables._RunwayLengthCode value = this.activeUnit_0.GetAirOps().vmethod_2();
					GlobalVariables.AircraftSizeClass value2 = this.activeUnit_0.GetAirOps().vmethod_3();
					text = string.Concat(new string[]
					{
						text,
						" AND PhysicalSizeCode => ",
						Conversions.ToString((byte)value2),
						" AND RunwayLengthCode <= ",
						Conversions.ToString((int)value)
					});
				}
				dataView.RowFilter = text;
			}
			this.dataGridView_0.DataSource = dataView;
			this.dataGridView_0.Refresh();
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x00021190 File Offset: 0x0001F390
		private void method_9(object sender, EventArgs e)
		{
			this.method_8();
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void EditAC_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x0600413C RID: 16700 RVA: 0x00021190 File Offset: 0x0001F390
		private void method_10(object sender, EventArgs e)
		{
			this.method_8();
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x00021198 File Offset: 0x0001F398
		[CompilerGenerated]
		private bool method_11(Aircraft aircraft_0)
		{
			return string.CompareOrdinal(Conversions.ToString(aircraft_0.DBID), this.listView_0.SelectedItems[0].Tag.ToString()) == 0;
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x000211C8 File Offset: 0x0001F3C8
		[CompilerGenerated]
		private bool method_12(Aircraft aircraft_0)
		{
			return (double)aircraft_0.DBID == Conversions.ToDouble(this.listView_0.SelectedItems[0].Tag.ToString());
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x000211C8 File Offset: 0x0001F3C8
		[CompilerGenerated]
		private bool method_13(Aircraft aircraft_0)
		{
			return (double)aircraft_0.DBID == Conversions.ToDouble(this.listView_0.SelectedItems[0].Tag.ToString());
		}

		// Token: 0x04001DDA RID: 7642
		public static Func<Aircraft, int> AircraftFunc = (Aircraft aircraft_0) => aircraft_0.DBID;

		// Token: 0x04001DDC RID: 7644
		[CompilerGenerated]
		private ListView listView_0;

		// Token: 0x04001DDD RID: 7645
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001DDE RID: 7646
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001DDF RID: 7647
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x04001DE0 RID: 7648
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04001DE1 RID: 7649
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04001DE2 RID: 7650
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001DE3 RID: 7651
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04001DE4 RID: 7652
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x04001DE5 RID: 7653
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001DE6 RID: 7654
		[CompilerGenerated]
		private GroupBox groupBox_0;

		// Token: 0x04001DE7 RID: 7655
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04001DE8 RID: 7656
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04001DE9 RID: 7657
		[CompilerGenerated]
		private GroupBox groupBox_1;

		// Token: 0x04001DEA RID: 7658
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04001DEB RID: 7659
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04001DEC RID: 7660
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x04001DED RID: 7661
		[CompilerGenerated]
		private TextBox textBox_2;

		// Token: 0x04001DEE RID: 7662
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04001DEF RID: 7663
		[CompilerGenerated]
		private ComboBox comboBox_1;

		// Token: 0x04001DF0 RID: 7664
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x04001DF1 RID: 7665
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04001DF2 RID: 7666
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04001DF3 RID: 7667
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04001DF4 RID: 7668
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04001DF5 RID: 7669
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04001DF6 RID: 7670
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x04001DF7 RID: 7671
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x04001DF8 RID: 7672
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x04001DF9 RID: 7673
		public ActiveUnit activeUnit_0;

		// Token: 0x04001DFA RID: 7674
		private DataTable dataTable_0;

		// Token: 0x020009A7 RID: 2471
		[CompilerGenerated]
		public sealed class Class2510
		{
			// Token: 0x06004142 RID: 16706 RVA: 0x00021217 File Offset: 0x0001F417
			public Class2510(EditAC.Class2510 class2510_0)
			{
				if (class2510_0 != null)
				{
					this.int_0 = class2510_0.int_0;
				}
			}

			// Token: 0x06004143 RID: 16707 RVA: 0x00021231 File Offset: 0x0001F431
			internal bool method_0(Aircraft aircraft_0)
			{
				return aircraft_0.DBID == this.int_0;
			}

			// Token: 0x04001DFC RID: 7676
			public int int_0;
		}
	}
}

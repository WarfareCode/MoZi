using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x02000B6C RID: 2924
	[DesignerGenerated]
	public sealed partial class EditEvent : CommandForm
	{
		// Token: 0x06006056 RID: 24662 RVA: 0x002DD438 File Offset: 0x002DB638
		public EditEvent()
		{
			base.FormClosing += new FormClosingEventHandler(this.EditEvent_FormClosing);
			base.Load += new EventHandler(this.EditEvent_Load);
			base.KeyDown += new KeyEventHandler(this.EditEvent_KeyDown);
			base.FormClosed += new FormClosedEventHandler(this.EditEvent_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x06006059 RID: 24665 RVA: 0x002DEB6C File Offset: 0x002DCD6C
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_0()
		{
			return this.textBox_0;
		}

		// Token: 0x0600605A RID: 24666 RVA: 0x002DEB84 File Offset: 0x002DCD84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(System.Windows.Forms.TextBox textBox_1)
		{
			EventHandler value = new EventHandler(this.method_15);
			System.Windows.Forms.TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
			}
			this.textBox_0 = textBox_1;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged += value;
			}
		}

		// Token: 0x0600605B RID: 24667 RVA: 0x002DEBD0 File Offset: 0x002DCDD0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x0600605C RID: 24668 RVA: 0x0002AD5B File Offset: 0x00028F5B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(System.Windows.Forms.Label label_5)
		{
			this.label_0 = label_5;
		}

		// Token: 0x0600605D RID: 24669 RVA: 0x002DEBE8 File Offset: 0x002DCDE8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_4()
		{
			return this.label_1;
		}

		// Token: 0x0600605E RID: 24670 RVA: 0x0002AD64 File Offset: 0x00028F64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(System.Windows.Forms.Label label_5)
		{
			this.label_1 = label_5;
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x002DEC00 File Offset: 0x002DCE00
		[CompilerGenerated]
		internal  DataGridView vmethod_6()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06006060 RID: 24672 RVA: 0x0002AD6D File Offset: 0x00028F6D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(DataGridView dataGridView_3)
		{
			this.dataGridView_0 = dataGridView_3;
		}

		// Token: 0x06006061 RID: 24673 RVA: 0x002DEC18 File Offset: 0x002DCE18
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_8()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06006062 RID: 24674 RVA: 0x0002AD76 File Offset: 0x00028F76
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06006063 RID: 24675 RVA: 0x002DEC30 File Offset: 0x002DCE30
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_10()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06006064 RID: 24676 RVA: 0x0002AD7F File Offset: 0x00028F7F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06006065 RID: 24677 RVA: 0x002DEC48 File Offset: 0x002DCE48
		[CompilerGenerated]
		internal  DataGridView vmethod_12()
		{
			return this.dataGridView_1;
		}

		// Token: 0x06006066 RID: 24678 RVA: 0x0002AD88 File Offset: 0x00028F88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(DataGridView dataGridView_3)
		{
			this.dataGridView_1 = dataGridView_3;
		}

		// Token: 0x06006067 RID: 24679 RVA: 0x002DEC60 File Offset: 0x002DCE60
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_14()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06006068 RID: 24680 RVA: 0x0002AD91 File Offset: 0x00028F91
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06006069 RID: 24681 RVA: 0x002DEC78 File Offset: 0x002DCE78
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_16()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x0002AD9A File Offset: 0x00028F9A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x0600606B RID: 24683 RVA: 0x002DEC90 File Offset: 0x002DCE90
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_18()
		{
			return this.label_2;
		}

		// Token: 0x0600606C RID: 24684 RVA: 0x0002ADA3 File Offset: 0x00028FA3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(System.Windows.Forms.Label label_5)
		{
			this.label_2 = label_5;
		}

		// Token: 0x0600606D RID: 24685 RVA: 0x002DECA8 File Offset: 0x002DCEA8
		[CompilerGenerated]
		internal  DataGridView vmethod_20()
		{
			return this.dataGridView_2;
		}

		// Token: 0x0600606E RID: 24686 RVA: 0x0002ADAC File Offset: 0x00028FAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridView dataGridView_3)
		{
			this.dataGridView_2 = dataGridView_3;
		}

		// Token: 0x0600606F RID: 24687 RVA: 0x002DECC0 File Offset: 0x002DCEC0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_22()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06006070 RID: 24688 RVA: 0x0002ADB5 File Offset: 0x00028FB5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06006071 RID: 24689 RVA: 0x002DECD8 File Offset: 0x002DCED8
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_24()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x06006072 RID: 24690 RVA: 0x0002ADBE File Offset: 0x00028FBE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x002DECF0 File Offset: 0x002DCEF0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_26()
		{
			return this.label_3;
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x0002ADC7 File Offset: 0x00028FC7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(System.Windows.Forms.Label label_5)
		{
			this.label_3 = label_5;
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x002DED08 File Offset: 0x002DCF08
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_28()
		{
			return this.button_0;
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x002DED20 File Offset: 0x002DCF20
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(System.Windows.Forms.Button button_11)
		{
			EventHandler value = new EventHandler(this.method_9);
			System.Windows.Forms.Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_11;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x002DED6C File Offset: 0x002DCF6C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_30()
		{
			return this.comboBox_0;
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x0002ADD0 File Offset: 0x00028FD0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(System.Windows.Forms.ComboBox comboBox_3)
		{
			this.comboBox_0 = comboBox_3;
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x002DED84 File Offset: 0x002DCF84
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_32()
		{
			return this.button_1;
		}

		// Token: 0x0600607A RID: 24698 RVA: 0x002DED9C File Offset: 0x002DCF9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(System.Windows.Forms.Button button_11)
		{
			EventHandler value = new EventHandler(this.method_11);
			System.Windows.Forms.Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_11;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600607B RID: 24699 RVA: 0x002DEDE8 File Offset: 0x002DCFE8
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_34()
		{
			return this.button_2;
		}

		// Token: 0x0600607C RID: 24700 RVA: 0x002DEE00 File Offset: 0x002DD000
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(System.Windows.Forms.Button button_11)
		{
			EventHandler value = new EventHandler(this.method_16);
			System.Windows.Forms.Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_11;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x002DEE4C File Offset: 0x002DD04C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_36()
		{
			return this.comboBox_1;
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x0002ADD9 File Offset: 0x00028FD9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(System.Windows.Forms.ComboBox comboBox_3)
		{
			this.comboBox_1 = comboBox_3;
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x002DEE64 File Offset: 0x002DD064
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_38()
		{
			return this.button_3;
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x002DEE7C File Offset: 0x002DD07C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(System.Windows.Forms.Button button_11)
		{
			EventHandler value = new EventHandler(this.method_20);
			System.Windows.Forms.Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_11;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006081 RID: 24705 RVA: 0x002DEEC8 File Offset: 0x002DD0C8
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_40()
		{
			return this.button_4;
		}

		// Token: 0x06006082 RID: 24706 RVA: 0x002DEEE0 File Offset: 0x002DD0E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(System.Windows.Forms.Button button_11)
		{
			EventHandler value = new EventHandler(this.method_12);
			System.Windows.Forms.Button button = this.button_4;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_4 = button_11;
			button = this.button_4;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006083 RID: 24707 RVA: 0x002DEF2C File Offset: 0x002DD12C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_42()
		{
			return this.comboBox_2;
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x0002ADE2 File Offset: 0x00028FE2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(System.Windows.Forms.ComboBox comboBox_3)
		{
			this.comboBox_2 = comboBox_3;
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x002DEF44 File Offset: 0x002DD144
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_44()
		{
			return this.button_5;
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x002DEF5C File Offset: 0x002DD15C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(System.Windows.Forms.Button button_11)
		{
			EventHandler value = new EventHandler(this.method_10);
			System.Windows.Forms.Button button = this.button_5;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_5 = button_11;
			button = this.button_5;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006087 RID: 24711 RVA: 0x002DEFA8 File Offset: 0x002DD1A8
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_46()
		{
			return this.button_6;
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x002DEFC0 File Offset: 0x002DD1C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(System.Windows.Forms.Button button_11)
		{
			EventHandler value = new EventHandler(this.method_14);
			System.Windows.Forms.Button button = this.button_6;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_6 = button_11;
			button = this.button_6;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x002DF00C File Offset: 0x002DD20C
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_48()
		{
			return this.button_7;
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x002DF024 File Offset: 0x002DD224
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(System.Windows.Forms.Button button_11)
		{
			EventHandler value = new EventHandler(this.method_13);
			System.Windows.Forms.Button button = this.button_7;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_7 = button_11;
			button = this.button_7;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600608B RID: 24715 RVA: 0x002DF070 File Offset: 0x002DD270
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_50()
		{
			return this.checkBox_0;
		}

		// Token: 0x0600608C RID: 24716 RVA: 0x002DF088 File Offset: 0x002DD288
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(System.Windows.Forms.CheckBox checkBox_3)
		{
			EventHandler value = new EventHandler(this.method_6);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_0 = checkBox_3;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x0600608D RID: 24717 RVA: 0x002DF0D4 File Offset: 0x002DD2D4
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_52()
		{
			return this.checkBox_1;
		}

		// Token: 0x0600608E RID: 24718 RVA: 0x002DF0EC File Offset: 0x002DD2EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(System.Windows.Forms.CheckBox checkBox_3)
		{
			EventHandler value = new EventHandler(this.method_7);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_1 = checkBox_3;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x002DF138 File Offset: 0x002DD338
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_54()
		{
			return this.label_4;
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x0002ADEB File Offset: 0x00028FEB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(System.Windows.Forms.Label label_5)
		{
			this.label_4 = label_5;
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x002DF150 File Offset: 0x002DD350
		[CompilerGenerated]
		internal  NumericUpDown vmethod_56()
		{
			return this.numericUpDown_0;
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x002DF168 File Offset: 0x002DD368
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(NumericUpDown numericUpDown_1)
		{
			EventHandler value = new EventHandler(this.method_17);
			NumericUpDown numericUpDown = this.numericUpDown_0;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged -= value;
			}
			this.numericUpDown_0 = numericUpDown_1;
			numericUpDown = this.numericUpDown_0;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged += value;
			}
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x002DF1B4 File Offset: 0x002DD3B4
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_58()
		{
			return this.button_8;
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x002DF1CC File Offset: 0x002DD3CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(System.Windows.Forms.Button button_11)
		{
			EventHandler value = new EventHandler(this.method_18);
			System.Windows.Forms.Button button = this.button_8;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_8 = button_11;
			button = this.button_8;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006095 RID: 24725 RVA: 0x002DF218 File Offset: 0x002DD418
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_60()
		{
			return this.button_9;
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x002DF230 File Offset: 0x002DD430
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(System.Windows.Forms.Button button_11)
		{
			EventHandler value = new EventHandler(this.method_19);
			System.Windows.Forms.Button button = this.button_9;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_9 = button_11;
			button = this.button_9;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x002DF27C File Offset: 0x002DD47C
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_62()
		{
			return this.button_10;
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x002DF294 File Offset: 0x002DD494
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(System.Windows.Forms.Button button_11)
		{
			EventHandler value = new EventHandler(this.method_21);
			System.Windows.Forms.Button button = this.button_10;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_10 = button_11;
			button = this.button_10;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x002DF2E0 File Offset: 0x002DD4E0
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_64()
		{
			return this.checkBox_2;
		}

		// Token: 0x0600609A RID: 24730 RVA: 0x002DF2F8 File Offset: 0x002DD4F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(System.Windows.Forms.CheckBox checkBox_3)
		{
			EventHandler value = new EventHandler(this.method_8);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_2 = checkBox_3;
			checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x0600609B RID: 24731 RVA: 0x002DF344 File Offset: 0x002DD544
		public SimEvent method_1()
		{
			return this.simEvent_0;
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x002DF35C File Offset: 0x002DD55C
		public void method_2(SimEvent simEvent_1)
		{
			this.simEvent_0 = simEvent_1;
			this.vmethod_0().Text = this.method_1().Description;
			this.method_4();
			this.method_5();
			this.vmethod_50().Checked = this.simEvent_0.IsRepeatable;
			this.vmethod_52().Checked = this.simEvent_0.IsActive;
			this.vmethod_64().Checked = this.simEvent_0.IsShown;
			this.vmethod_56().Value = new decimal((int)this.simEvent_0.Probability);
		}

		// Token: 0x0600609D RID: 24733 RVA: 0x002DF3F0 File Offset: 0x002DD5F0
		private void EditEvent_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.enum186_0 == EditEvent.Enum186.const_1)
			{
				if (this.method_1().Triggers.Count == 0)
				{
					Interaction.MsgBox("事件至少应分配一个触发器.", MsgBoxStyle.Critical, "非分配触发器!");
					e.Cancel = true;
					return;
				}
				if (this.method_1().Actions.Count == 0)
				{
					Interaction.MsgBox("事件至少应分配一个动作.", MsgBoxStyle.Critical, "未分配动作!");
					e.Cancel = true;
					return;
				}
			}
			CommandFactory.GetCommandMain().GetListEvents().method_1();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x0600609E RID: 24734 RVA: 0x002DF490 File Offset: 0x002DD690
		private void EditEvent_Load(object sender, EventArgs e)
		{
			Scenario.AddEventTriggersChangedEvent(new Scenario.EventTriggersChangedEventHandler(this.method_3));
			Scenario.AddConditionsChangedEvent(new Scenario.EventConditionsChangedEventHandler(this.method_3));
			Scenario.AddActionsChangedEvent(new Scenario.EventActionsChangedEventHandler(this.method_3));
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (Information.IsNothing(this.method_1()))
			{
				base.Close();
			}
		}

		// Token: 0x0600609F RID: 24735 RVA: 0x0002ADF4 File Offset: 0x00028FF4
		private void method_3(Scenario scenario_0)
		{
			if (scenario_0 == Client.GetClientScenario())
			{
				this.method_5();
			}
		}

		// Token: 0x060060A0 RID: 24736 RVA: 0x002DF500 File Offset: 0x002DD700
		private void method_4()
		{
			this.vmethod_6().SuspendLayout();
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("ID", typeof(string));
			dataTable.Columns.Add("Description", typeof(string));
			foreach (EventTrigger current in this.method_1().Triggers)
			{
				DataRow dataRow = dataTable.NewRow();
				dataRow["ID"] = current.GetGuid();
				dataRow["Description"] = current.strDescription;
				dataTable.Rows.Add(dataRow);
			}
			this.vmethod_6().DataSource = dataTable;
			this.vmethod_6().ResumeLayout();
			this.vmethod_12().SuspendLayout();
			dataTable = new DataTable();
			dataTable.Columns.Add("ID", typeof(string));
			dataTable.Columns.Add("Description", typeof(string));
			foreach (EventCondition current2 in this.method_1().Conditions)
			{
				DataRow dataRow2 = dataTable.NewRow();
				dataRow2["ID"] = current2.GetGuid();
				dataRow2["Description"] = current2.strDescription;
				dataTable.Rows.Add(dataRow2);
			}
			this.vmethod_12().DataSource = dataTable;
			this.vmethod_12().ResumeLayout();
			this.vmethod_20().SuspendLayout();
			dataTable = new DataTable();
			dataTable.Columns.Add("ID", typeof(string));
			dataTable.Columns.Add("Description", typeof(string));
			foreach (EventAction current3 in this.method_1().Actions)
			{
				DataRow dataRow3 = dataTable.NewRow();
				dataRow3["ID"] = current3.GetGuid();
				dataRow3["Description"] = current3.strDescription;
				dataTable.Rows.Add(dataRow3);
			}
			this.vmethod_20().DataSource = dataTable;
			this.vmethod_20().ResumeLayout();
		}

		// Token: 0x060060A1 RID: 24737 RVA: 0x002DF79C File Offset: 0x002DD99C
		public void method_5()
		{
			this.vmethod_30().Items.Clear();
			this.vmethod_30().DisplayMember = "Content";
			foreach (EventTrigger current in Client.GetClientScenario().GetEventTriggers().Values.OrderBy(EditEvent.EventTriggerFunc))
			{
				ComboBoxItem comboBoxItem = new ComboBoxItem();
				comboBoxItem.Content = current.strDescription;
				comboBoxItem.Tag = current;
				this.vmethod_30().Items.Add(comboBoxItem);
			}
			this.vmethod_36().Items.Clear();
			this.vmethod_36().DisplayMember = "Content";
			foreach (EventCondition current2 in Client.GetClientScenario().GetEventConditions().Values.OrderBy(EditEvent.EventConditionFunc))
			{
				ComboBoxItem comboBoxItem2 = new ComboBoxItem();
				comboBoxItem2.Content = current2.strDescription;
				comboBoxItem2.Tag = current2;
				this.vmethod_36().Items.Add(comboBoxItem2);
			}
			this.vmethod_42().Items.Clear();
			this.vmethod_42().DisplayMember = "Content";
			foreach (EventAction current3 in Client.GetClientScenario().GetEventActions().Values.OrderBy(EditEvent.EventActionFunc))
			{
				ComboBoxItem comboBoxItem3 = new ComboBoxItem();
				comboBoxItem3.Content = current3.strDescription;
				comboBoxItem3.Tag = current3;
				this.vmethod_42().Items.Add(comboBoxItem3);
			}
		}

		// Token: 0x060060A2 RID: 24738 RVA: 0x0002AE09 File Offset: 0x00029009
		private void method_6(object sender, EventArgs e)
		{
			this.method_1().IsRepeatable = this.vmethod_50().Checked;
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x0002AE21 File Offset: 0x00029021
		private void method_7(object sender, EventArgs e)
		{
			this.method_1().IsActive = this.vmethod_52().Checked;
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x0002AE39 File Offset: 0x00029039
		private void method_8(object sender, EventArgs e)
		{
			this.method_1().IsShown = this.vmethod_64().Checked;
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x002DF988 File Offset: 0x002DDB88
		private void method_9(object sender, EventArgs e)
		{
			if (this.vmethod_30().SelectedIndex >= 0)
			{
				EventTrigger item = (EventTrigger)((ComboBoxItem)this.vmethod_30().SelectedItem).Tag;
				if (!this.method_1().Triggers.Contains(item))
				{
					this.method_1().Triggers.Add(item);
					this.method_4();
				}
			}
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x002DF9EC File Offset: 0x002DDBEC
		private void method_10(object sender, EventArgs e)
		{
			if (this.vmethod_42().SelectedIndex >= 0)
			{
				EventAction item = (EventAction)((ComboBoxItem)this.vmethod_42().SelectedItem).Tag;
				if (!this.method_1().Actions.Contains(item))
				{
					this.method_1().Actions.Add(item);
					this.method_4();
				}
			}
		}

		// Token: 0x060060A7 RID: 24743 RVA: 0x002DFA50 File Offset: 0x002DDC50
		private void method_11(object sender, EventArgs e)
		{
			if (this.vmethod_6().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_6().SelectedRows[0].Cells[0].Value);
				EventTrigger item = Client.GetClientScenario().GetEventTriggers()[key];
				this.method_1().Triggers.Remove(item);
				this.method_4();
			}
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x002DFAC4 File Offset: 0x002DDCC4
		private void method_12(object sender, EventArgs e)
		{
			if (this.vmethod_20().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_20().SelectedRows[0].Cells[0].Value);
				EventAction item = Client.GetClientScenario().GetEventActions()[key];
				this.method_1().Actions.Remove(item);
				this.method_4();
			}
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x002DFB38 File Offset: 0x002DDD38
		private void method_13(object sender, EventArgs e)
		{
			if (this.method_1().Triggers.Count == 0)
			{
				Interaction.MsgBox("事件至少应分配一个触发器.", MsgBoxStyle.Critical, "非分配触发器!");
			}
			else if (this.method_1().Actions.Count == 0)
			{
				Interaction.MsgBox("事件至少应分配一个动作.", MsgBoxStyle.Critical, "非分配动作!");
			}
			else
			{
				EditEvent.Enum186 @enum = this.enum186_0;
				if (@enum != EditEvent.Enum186.const_0)
				{
					if (@enum != EditEvent.Enum186.const_1)
					{
					}
				}
				else
				{
					Client.GetClientScenario().GetSimEvents().Add(this.method_1().GetGuid(), this.method_1());
				}
				base.Close();
			}
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_14(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x0002AE51 File Offset: 0x00029051
		private void method_15(object sender, EventArgs e)
		{
			this.method_1().Description = this.vmethod_0().Text;
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x002DFBD8 File Offset: 0x002DDDD8
		private void method_16(object sender, EventArgs e)
		{
			if (this.vmethod_12().SelectedRows.Count != 0)
			{
				string key = Conversions.ToString(this.vmethod_12().SelectedRows[0].Cells[0].Value);
				EventCondition item = Client.GetClientScenario().GetEventConditions()[key];
				this.method_1().Conditions.Remove(item);
				this.method_4();
			}
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x0002AE69 File Offset: 0x00029069
		private void method_17(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_56().Value))
			{
				this.method_1().Probability = Convert.ToInt16(this.vmethod_56().Value);
			}
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x0002AEA0 File Offset: 0x000290A0
		private void method_18(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetListTriggers().Show();
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x0002AEB1 File Offset: 0x000290B1
		private void method_19(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetListActions().Show();
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x002DFC4C File Offset: 0x002DDE4C
		private void method_20(object sender, EventArgs e)
		{
			if (this.vmethod_36().SelectedIndex >= 0)
			{
				EventCondition item = (EventCondition)((ComboBoxItem)this.vmethod_36().SelectedItem).Tag;
				if (!this.method_1().Conditions.Contains(item))
				{
					this.method_1().Conditions.Add(item);
					this.method_4();
				}
			}
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x0002AEC2 File Offset: 0x000290C2
		private void method_21(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetListConditions().Show();
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void EditEvent_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x060060B3 RID: 24755 RVA: 0x0002AED3 File Offset: 0x000290D3
		private void EditEvent_FormClosed(object sender, FormClosedEventArgs e)
		{
			Scenario.RemoveEventTriggersChangedEvent(new Scenario.EventTriggersChangedEventHandler(this.method_3));
			Scenario.RemoveConditionsChangedEvent(new Scenario.EventConditionsChangedEventHandler(this.method_3));
			Scenario.RemoveActionsChangedEvent(new Scenario.EventActionsChangedEventHandler(this.method_3));
		}

		// Token: 0x040033E1 RID: 13281
		public static Func<EventTrigger, string> EventTriggerFunc = (EventTrigger eventTrigger_0) => eventTrigger_0.strDescription;

		// Token: 0x040033E2 RID: 13282
		public static Func<EventCondition, string> EventConditionFunc = (EventCondition eventCondition_0) => eventCondition_0.strDescription;

		// Token: 0x040033E3 RID: 13283
		public static Func<EventAction, string> EventActionFunc = (EventAction eventAction_0) => eventAction_0.strDescription;

		// Token: 0x040033E5 RID: 13285
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_0;

		// Token: 0x040033E6 RID: 13286
		[CompilerGenerated]
		private System.Windows.Forms.Label label_0;

		// Token: 0x040033E7 RID: 13287
		[CompilerGenerated]
		private System.Windows.Forms.Label label_1;

		// Token: 0x040033E8 RID: 13288
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x040033E9 RID: 13289
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x040033EA RID: 13290
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x040033EB RID: 13291
		[CompilerGenerated]
		private DataGridView dataGridView_1;

		// Token: 0x040033EC RID: 13292
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x040033ED RID: 13293
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x040033EE RID: 13294
		[CompilerGenerated]
		private System.Windows.Forms.Label label_2;

		// Token: 0x040033EF RID: 13295
		[CompilerGenerated]
		private DataGridView dataGridView_2;

		// Token: 0x040033F0 RID: 13296
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x040033F1 RID: 13297
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x040033F2 RID: 13298
		[CompilerGenerated]
		private System.Windows.Forms.Label label_3;

		// Token: 0x040033F3 RID: 13299
		[CompilerGenerated]
		private System.Windows.Forms.Button button_0;

		// Token: 0x040033F4 RID: 13300
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_0;

		// Token: 0x040033F5 RID: 13301
		[CompilerGenerated]
		private System.Windows.Forms.Button button_1;

		// Token: 0x040033F6 RID: 13302
		[CompilerGenerated]
		private System.Windows.Forms.Button button_2;

		// Token: 0x040033F7 RID: 13303
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_1;

		// Token: 0x040033F8 RID: 13304
		[CompilerGenerated]
		private System.Windows.Forms.Button button_3;

		// Token: 0x040033F9 RID: 13305
		[CompilerGenerated]
		private System.Windows.Forms.Button button_4;

		// Token: 0x040033FA RID: 13306
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_2;

		// Token: 0x040033FB RID: 13307
		[CompilerGenerated]
		private System.Windows.Forms.Button button_5;

		// Token: 0x040033FC RID: 13308
		[CompilerGenerated]
		private System.Windows.Forms.Button button_6;

		// Token: 0x040033FD RID: 13309
		[CompilerGenerated]
		private System.Windows.Forms.Button button_7;

		// Token: 0x040033FE RID: 13310
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_0;

		// Token: 0x040033FF RID: 13311
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_1;

		// Token: 0x04003400 RID: 13312
		[CompilerGenerated]
		private System.Windows.Forms.Label label_4;

		// Token: 0x04003401 RID: 13313
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x04003402 RID: 13314
		[CompilerGenerated]
		private System.Windows.Forms.Button button_8;

		// Token: 0x04003403 RID: 13315
		[CompilerGenerated]
		private System.Windows.Forms.Button button_9;

		// Token: 0x04003404 RID: 13316
		[CompilerGenerated]
		private System.Windows.Forms.Button button_10;

		// Token: 0x04003405 RID: 13317
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_2;

		// Token: 0x04003406 RID: 13318
		private SimEvent simEvent_0;

		// Token: 0x04003407 RID: 13319
		public EditEvent.Enum186 enum186_0;

		// Token: 0x02000B6D RID: 2925
		public enum Enum186 : byte
		{
			// Token: 0x0400340C RID: 13324
			const_0,
			// Token: 0x0400340D RID: 13325
			const_1
		}
	}
}

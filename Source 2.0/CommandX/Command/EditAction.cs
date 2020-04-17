using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MSDN.Html.Editor;
using ns0;
using ns1;
using ns15;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x02000B53 RID: 2899
	[DesignerGenerated]
	public sealed partial class EditAction : CommandForm
	{
		// Token: 0x06005F3E RID: 24382 RVA: 0x002D01F4 File Offset: 0x002CE3F4
		public EditAction()
		{
			base.FormClosing += new FormClosingEventHandler(this.EditAction_FormClosing);
			base.Load += new EventHandler(this.EditAction_Load);
			base.KeyDown += new KeyEventHandler(this.EditAction_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x06005F41 RID: 24385 RVA: 0x002D175C File Offset: 0x002CF95C
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_0()
		{
			return this.textBox_0;
		}

		// Token: 0x06005F42 RID: 24386 RVA: 0x002D1774 File Offset: 0x002CF974
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(System.Windows.Forms.TextBox textBox_2)
		{
			EventHandler value = new EventHandler(this.method_5);
			System.Windows.Forms.TextBox textBox = this.textBox_0;
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

		// Token: 0x06005F43 RID: 24387 RVA: 0x002D17C0 File Offset: 0x002CF9C0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x06005F44 RID: 24388 RVA: 0x0002A4B6 File Offset: 0x000286B6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(System.Windows.Forms.Label label_13)
		{
			this.label_0 = label_13;
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x002D17D8 File Offset: 0x002CF9D8
		[CompilerGenerated]
		internal  Control1 vmethod_4()
		{
			return this.control1_0;
		}

		// Token: 0x06005F46 RID: 24390 RVA: 0x0002A4BF File Offset: 0x000286BF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Control1 control1_1)
		{
			this.control1_0 = control1_1;
		}

		// Token: 0x06005F47 RID: 24391 RVA: 0x002D17F0 File Offset: 0x002CF9F0
		[CompilerGenerated]
		internal  TabPage vmethod_6()
		{
			return this.tabPage_0;
		}

		// Token: 0x06005F48 RID: 24392 RVA: 0x0002A4C8 File Offset: 0x000286C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TabPage tabPage_6)
		{
			this.tabPage_0 = tabPage_6;
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x002D1808 File Offset: 0x002CFA08
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_8()
		{
			return this.label_1;
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x0002A4D1 File Offset: 0x000286D1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(System.Windows.Forms.Label label_13)
		{
			this.label_1 = label_13;
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x002D1820 File Offset: 0x002CFA20
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_10()
		{
			return this.button_0;
		}

		// Token: 0x06005F4C RID: 24396 RVA: 0x002D1838 File Offset: 0x002CFA38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(System.Windows.Forms.Button button_4)
		{
			EventHandler value = new EventHandler(this.method_1);
			System.Windows.Forms.Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_4;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005F4D RID: 24397 RVA: 0x002D1884 File Offset: 0x002CFA84
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_12()
		{
			return this.button_1;
		}

		// Token: 0x06005F4E RID: 24398 RVA: 0x002D189C File Offset: 0x002CFA9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(System.Windows.Forms.Button button_4)
		{
			EventHandler value = new EventHandler(this.method_2);
			System.Windows.Forms.Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_4;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005F4F RID: 24399 RVA: 0x002D18E8 File Offset: 0x002CFAE8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_14()
		{
			return this.label_2;
		}

		// Token: 0x06005F50 RID: 24400 RVA: 0x0002A4DA File Offset: 0x000286DA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(System.Windows.Forms.Label label_13)
		{
			this.label_2 = label_13;
		}

		// Token: 0x06005F51 RID: 24401 RVA: 0x002D1900 File Offset: 0x002CFB00
		[CompilerGenerated]
		internal  NumericUpDown vmethod_16()
		{
			return this.numericUpDown_0;
		}

		// Token: 0x06005F52 RID: 24402 RVA: 0x002D1918 File Offset: 0x002CFB18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(NumericUpDown numericUpDown_2)
		{
			EventHandler value = new EventHandler(this.method_4);
			NumericUpDown numericUpDown = this.numericUpDown_0;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged -= value;
			}
			this.numericUpDown_0 = numericUpDown_2;
			numericUpDown = this.numericUpDown_0;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged += value;
			}
		}

		// Token: 0x06005F53 RID: 24403 RVA: 0x002D1964 File Offset: 0x002CFB64
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_18()
		{
			return this.comboBox_0;
		}

		// Token: 0x06005F54 RID: 24404 RVA: 0x002D197C File Offset: 0x002CFB7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(System.Windows.Forms.ComboBox comboBox_6)
		{
			EventHandler value = new EventHandler(this.method_3);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_6;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x002D19C8 File Offset: 0x002CFBC8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_20()
		{
			return this.label_3;
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x0002A4E3 File Offset: 0x000286E3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(System.Windows.Forms.Label label_13)
		{
			this.label_3 = label_13;
		}

		// Token: 0x06005F57 RID: 24407 RVA: 0x002D19E0 File Offset: 0x002CFBE0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_22()
		{
			return this.label_4;
		}

		// Token: 0x06005F58 RID: 24408 RVA: 0x0002A4EC File Offset: 0x000286EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(System.Windows.Forms.Label label_13)
		{
			this.label_4 = label_13;
		}

		// Token: 0x06005F59 RID: 24409 RVA: 0x002D19F8 File Offset: 0x002CFBF8
		[CompilerGenerated]
		internal  TabPage vmethod_24()
		{
			return this.tabPage_1;
		}

		// Token: 0x06005F5A RID: 24410 RVA: 0x0002A4F5 File Offset: 0x000286F5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(TabPage tabPage_6)
		{
			this.tabPage_1 = tabPage_6;
		}

		// Token: 0x06005F5B RID: 24411 RVA: 0x002D1A10 File Offset: 0x002CFC10
		[CompilerGenerated]
		internal  TabPage vmethod_26()
		{
			return this.tabPage_2;
		}

		// Token: 0x06005F5C RID: 24412 RVA: 0x0002A4FE File Offset: 0x000286FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(TabPage tabPage_6)
		{
			this.tabPage_2 = tabPage_6;
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x002D1A28 File Offset: 0x002CFC28
		[CompilerGenerated]
		internal  System.Windows.Forms.ListBox vmethod_28()
		{
			return this.listBox_0;
		}

		// Token: 0x06005F5E RID: 24414 RVA: 0x002D1A40 File Offset: 0x002CFC40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(System.Windows.Forms.ListBox listBox_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			System.Windows.Forms.ListBox listBox = this.listBox_0;
			if (listBox != null)
			{
				listBox.SelectedValueChanged -= value;
			}
			this.listBox_0 = listBox_1;
			listBox = this.listBox_0;
			if (listBox != null)
			{
				listBox.SelectedValueChanged += value;
			}
		}

		// Token: 0x06005F5F RID: 24415 RVA: 0x002D1A8C File Offset: 0x002CFC8C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_30()
		{
			return this.label_5;
		}

		// Token: 0x06005F60 RID: 24416 RVA: 0x0002A507 File Offset: 0x00028707
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(System.Windows.Forms.Label label_13)
		{
			this.label_5 = label_13;
		}

		// Token: 0x06005F61 RID: 24417 RVA: 0x002D1AA4 File Offset: 0x002CFCA4
		[CompilerGenerated]
		internal  AreaEditor vmethod_32()
		{
			return this.areaEditor_0;
		}

		// Token: 0x06005F62 RID: 24418 RVA: 0x0002A510 File Offset: 0x00028710
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(AreaEditor areaEditor_1)
		{
			this.areaEditor_0 = areaEditor_1;
		}

		// Token: 0x06005F63 RID: 24419 RVA: 0x002D1ABC File Offset: 0x002CFCBC
		[CompilerGenerated]
		internal  TabPage vmethod_34()
		{
			return this.tabPage_3;
		}

		// Token: 0x06005F64 RID: 24420 RVA: 0x0002A519 File Offset: 0x00028719
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(TabPage tabPage_6)
		{
			this.tabPage_3 = tabPage_6;
		}

		// Token: 0x06005F65 RID: 24421 RVA: 0x002D1AD4 File Offset: 0x002CFCD4
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_36()
		{
			return this.comboBox_1;
		}

		// Token: 0x06005F66 RID: 24422 RVA: 0x002D1AEC File Offset: 0x002CFCEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(System.Windows.Forms.ComboBox comboBox_6)
		{
			EventHandler value = new EventHandler(this.method_7);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_1 = comboBox_6;
			comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x002D1B38 File Offset: 0x002CFD38
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_38()
		{
			return this.label_6;
		}

		// Token: 0x06005F68 RID: 24424 RVA: 0x0002A522 File Offset: 0x00028722
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(System.Windows.Forms.Label label_13)
		{
			this.label_6 = label_13;
		}

		// Token: 0x06005F69 RID: 24425 RVA: 0x002D1B50 File Offset: 0x002CFD50
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_40()
		{
			return this.label_7;
		}

		// Token: 0x06005F6A RID: 24426 RVA: 0x0002A52B File Offset: 0x0002872B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(System.Windows.Forms.Label label_13)
		{
			this.label_7 = label_13;
		}

		// Token: 0x06005F6B RID: 24427 RVA: 0x002D1B68 File Offset: 0x002CFD68
		[CompilerGenerated]
		internal  TabPage vmethod_42()
		{
			return this.tabPage_4;
		}

		// Token: 0x06005F6C RID: 24428 RVA: 0x0002A534 File Offset: 0x00028734
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(TabPage tabPage_6)
		{
			this.tabPage_4 = tabPage_6;
		}

		// Token: 0x06005F6D RID: 24429 RVA: 0x002D1B80 File Offset: 0x002CFD80
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_44()
		{
			return this.label_8;
		}

		// Token: 0x06005F6E RID: 24430 RVA: 0x0002A53D File Offset: 0x0002873D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(System.Windows.Forms.Label label_13)
		{
			this.label_8 = label_13;
		}

		// Token: 0x06005F6F RID: 24431 RVA: 0x002D1B98 File Offset: 0x002CFD98
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_46()
		{
			return this.comboBox_2;
		}

		// Token: 0x06005F70 RID: 24432 RVA: 0x002D1BB0 File Offset: 0x002CFDB0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(System.Windows.Forms.ComboBox comboBox_6)
		{
			EventHandler value = new EventHandler(this.method_9);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_2 = comboBox_6;
			comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005F71 RID: 24433 RVA: 0x002D1BFC File Offset: 0x002CFDFC
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_48()
		{
			return this.comboBox_3;
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x002D1C14 File Offset: 0x002CFE14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(System.Windows.Forms.ComboBox comboBox_6)
		{
			EventHandler value = new EventHandler(this.method_8);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_3;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_3 = comboBox_6;
			comboBox = this.comboBox_3;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x002D1C60 File Offset: 0x002CFE60
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_50()
		{
			return this.label_9;
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x0002A546 File Offset: 0x00028746
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(System.Windows.Forms.Label label_13)
		{
			this.label_9 = label_13;
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x002D1C78 File Offset: 0x002CFE78
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_52()
		{
			return this.label_10;
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x0002A54F File Offset: 0x0002874F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(System.Windows.Forms.Label label_13)
		{
			this.label_10 = label_13;
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x002D1C90 File Offset: 0x002CFE90
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_54()
		{
			return this.comboBox_4;
		}

		// Token: 0x06005F78 RID: 24440 RVA: 0x002D1CA8 File Offset: 0x002CFEA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(System.Windows.Forms.ComboBox comboBox_6)
		{
			EventHandler value = new EventHandler(this.method_10);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_4;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_4 = comboBox_6;
			comboBox = this.comboBox_4;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005F79 RID: 24441 RVA: 0x002D1CF4 File Offset: 0x002CFEF4
		[CompilerGenerated]
		internal  HtmlEditorControl vmethod_56()
		{
			return this.htmlEditorControl_0;
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x0002A558 File Offset: 0x00028758
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(HtmlEditorControl htmlEditorControl_1)
		{
			this.htmlEditorControl_0 = htmlEditorControl_1;
		}

		// Token: 0x06005F7B RID: 24443 RVA: 0x002D1D0C File Offset: 0x002CFF0C
		[CompilerGenerated]
		internal  TabPage vmethod_58()
		{
			return this.tabPage_5;
		}

		// Token: 0x06005F7C RID: 24444 RVA: 0x0002A561 File Offset: 0x00028761
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(TabPage tabPage_6)
		{
			this.tabPage_5 = tabPage_6;
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x002D1D24 File Offset: 0x002CFF24
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_60()
		{
			return this.button_2;
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x002D1D3C File Offset: 0x002CFF3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(System.Windows.Forms.Button button_4)
		{
			EventHandler value = new EventHandler(this.method_11);
			System.Windows.Forms.Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_4;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005F7F RID: 24447 RVA: 0x002D1D88 File Offset: 0x002CFF88
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_62()
		{
			return this.comboBox_5;
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x0002A56A File Offset: 0x0002876A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(System.Windows.Forms.ComboBox comboBox_6)
		{
			this.comboBox_5 = comboBox_6;
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x002D1DA0 File Offset: 0x002CFFA0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_64()
		{
			return this.label_11;
		}

		// Token: 0x06005F82 RID: 24450 RVA: 0x0002A573 File Offset: 0x00028773
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(System.Windows.Forms.Label label_13)
		{
			this.label_11 = label_13;
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x002D1DB8 File Offset: 0x002CFFB8
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_66()
		{
			return this.textBox_1;
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x0002A57C File Offset: 0x0002877C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(System.Windows.Forms.TextBox textBox_2)
		{
			this.textBox_1 = textBox_2;
		}

		// Token: 0x06005F85 RID: 24453 RVA: 0x002D1DD0 File Offset: 0x002CFFD0
		[CompilerGenerated]
		internal  NumericUpDown vmethod_68()
		{
			return this.numericUpDown_1;
		}

		// Token: 0x06005F86 RID: 24454 RVA: 0x002D1DE8 File Offset: 0x002CFFE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(NumericUpDown numericUpDown_2)
		{
			EventHandler value = new EventHandler(this.method_12);
			NumericUpDown numericUpDown = this.numericUpDown_1;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged -= value;
			}
			this.numericUpDown_1 = numericUpDown_2;
			numericUpDown = this.numericUpDown_1;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged += value;
			}
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x002D1E34 File Offset: 0x002D0034
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_70()
		{
			return this.label_12;
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x0002A585 File Offset: 0x00028785
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(System.Windows.Forms.Label label_13)
		{
			this.label_12 = label_13;
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x002D1E4C File Offset: 0x002D004C
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_72()
		{
			return this.button_3;
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x002D1E64 File Offset: 0x002D0064
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(System.Windows.Forms.Button button_4)
		{
			EventHandler value = new EventHandler(this.method_13);
			System.Windows.Forms.Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_4;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005F8B RID: 24459 RVA: 0x0002A58E File Offset: 0x0002878E
		private void EditAction_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetListActions().method_1();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06005F8C RID: 24460 RVA: 0x002D1EB0 File Offset: 0x002D00B0
		private void EditAction_Load(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.eventAction_0))
			{
				base.Close();
			}
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_0().Text = this.eventAction_0.strDescription;
			this.vmethod_12().Visible = true;
			this.vmethod_10().Visible = this.vmethod_12().Visible;
			checked
			{
				switch (this.eventAction_0.eventActionType)
				{
				case EventAction.EventActionType.Points:
				{
					this.vmethod_4().SelectedIndex = 0;
					this.vmethod_18().Items.Clear();
					this.vmethod_18().DisplayMember = "Content";
					Side[] sides = Client.GetClientScenario().GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						ComboBoxItem comboBoxItem = new ComboBoxItem();
						comboBoxItem.Content = side.GetSideName();
						comboBoxItem.Tag = side.GetGuid();
						this.vmethod_18().Items.Add(comboBoxItem);
					}
					IEnumerator enumerator = this.vmethod_18().Items.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ComboBoxItem comboBoxItem2 = (ComboBoxItem)enumerator.Current;
							if (Operators.ConditionalCompareObjectEqual(comboBoxItem2.Tag, ((EventAction_Points)this.eventAction_0).SideID, false))
							{
								this.vmethod_18().SelectedItem = comboBoxItem2;
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
					this.vmethod_16().Value = new decimal(((EventAction_Points)this.eventAction_0).PointChange);
					break;
				}
				case EventAction.EventActionType.EndScenario:
					this.vmethod_4().SelectedIndex = 1;
					break;
				case EventAction.EventActionType.TeleportInArea:
				{
					this.vmethod_4().SelectedIndex = 2;
					this.vmethod_28().Items.Clear();
					TreeNode treeNode = new TreeNode();
					foreach (ActiveUnit current in Client.GetClientScenario().GetActiveUnitList())
					{
						treeNode = new TreeNode();
						treeNode.Name = current.Name;
						treeNode.Tag = current;
						this.vmethod_28().Items.Add(treeNode);
						if (((EventAction_TeleportInArea)this.eventAction_0).UnitIDs.Contains(current.GetGuid()))
						{
							this.vmethod_28().SetSelected(this.vmethod_28().Items.IndexOf(treeNode), true);
						}
					}
					this.vmethod_32().list_0 = ((EventAction_TeleportInArea)this.eventAction_0).Area;
					this.vmethod_32().method_1();
					break;
				}
				case EventAction.EventActionType.Message:
				{
					this.vmethod_4().SelectedIndex = 3;
					this.vmethod_36().Items.Clear();
					this.vmethod_36().DisplayMember = "Content";
					Side[] sides2 = Client.GetClientScenario().GetSides();
					for (int j = 0; j < sides2.Length; j++)
					{
						Side side2 = sides2[j];
						ComboBoxItem comboBoxItem3 = new ComboBoxItem();
						comboBoxItem3.Content = side2.GetSideName();
						comboBoxItem3.Tag = side2.GetGuid();
						this.vmethod_36().Items.Add(comboBoxItem3);
					}
					IEnumerator enumerator3 = this.vmethod_36().Items.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							ComboBoxItem comboBoxItem4 = (ComboBoxItem)enumerator3.Current;
							if (Operators.ConditionalCompareObjectEqual(comboBoxItem4.Tag, ((EventAction_Message)this.eventAction_0).SideID, false))
							{
								this.vmethod_36().SelectedItem = comboBoxItem4;
								break;
							}
						}
					}
					finally
					{
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					if (!string.IsNullOrEmpty(((EventAction_Message)this.eventAction_0).strText))
					{
						this.vmethod_56().BodyHtml = ((EventAction_Message)this.eventAction_0).strText;
					}
					break;
				}
				case EventAction.EventActionType.ChangeMissionStatus:
				{
					this.vmethod_4().SelectedIndex = 4;
					if (Client.GetClientScenario().GetSides().Count<Side>() == 0)
					{
						return;
					}
					Side side3 = Client.GetClientScenario().GetSides()[0];
					this.vmethod_48().Items.Clear();
					this.vmethod_48().DisplayMember = "Content";
					Side[] sides3 = Client.GetClientScenario().GetSides();
					for (int k = 0; k < sides3.Length; k++)
					{
						Side side4 = sides3[k];
						ComboBoxItem comboBoxItem5 = new ComboBoxItem();
						comboBoxItem5.Content = side4.GetSideName();
						comboBoxItem5.Tag = side4.GetGuid();
						this.vmethod_48().Items.Add(comboBoxItem5);
					}
					Side[] sides4 = Client.GetClientScenario().GetSides();
					for (int l = 0; l < sides4.Length; l++)
					{
						Side side5 = sides4[l];
						using (IEnumerator<Mission> enumerator4 = side5.GetMissionCollection().GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								if (Operators.CompareString(enumerator4.Current.GetGuid(), ((EventAction_ChangeMissionStatus)this.eventAction_0).MissionID, false) == 0)
								{
									IEnumerator enumerator5 = this.vmethod_48().Items.GetEnumerator();
									try
									{
										while (enumerator5.MoveNext())
										{
											ComboBoxItem comboBoxItem6 = (ComboBoxItem)enumerator5.Current;
											if (Operators.ConditionalCompareObjectEqual(comboBoxItem6.Tag, side5.GetGuid(), false))
											{
												side3 = side5;
												this.vmethod_48().SelectedItem = comboBoxItem6;
												break;
											}
										}
									}
									finally
									{
										if (enumerator5 is IDisposable)
										{
											(enumerator5 as IDisposable).Dispose();
										}
									}
								}
							}
						}
					}
					if (Client.GetClientSide().GetMissionCollection().Count == 0)
					{
						return;
					}
					this.vmethod_46().Items.Clear();
					this.vmethod_46().DisplayMember = "Content";
					foreach (Mission current2 in side3.GetMissionCollection())
					{
						ComboBoxItem comboBoxItem7 = new ComboBoxItem();
						comboBoxItem7.Content = current2.Name;
						comboBoxItem7.Tag = current2.GetGuid();
						this.vmethod_46().Items.Add(comboBoxItem7);
					}
					if (side3.GetMissionCollection().Count > 0)
					{
						Mission mission = side3.GetMissionCollection()[0];
						foreach (Mission current3 in side3.GetMissionCollection())
						{
							if (Operators.CompareString(current3.GetGuid(), ((EventAction_ChangeMissionStatus)this.eventAction_0).MissionID, false) == 0)
							{
								mission = current3;
								break;
							}
						}
						IEnumerator enumerator8 = this.vmethod_46().Items.GetEnumerator();
						try
						{
							while (enumerator8.MoveNext())
							{
								ComboBoxItem comboBoxItem8 = (ComboBoxItem)enumerator8.Current;
								if (Operators.ConditionalCompareObjectEqual(comboBoxItem8.Tag, mission.GetGuid(), false))
								{
									this.vmethod_46().SelectedItem = comboBoxItem8;
									break;
								}
							}
						}
						finally
						{
							if (enumerator8 is IDisposable)
							{
								(enumerator8 as IDisposable).Dispose();
							}
						}
					}
					this.vmethod_54().SelectedIndex = (int)((EventAction_ChangeMissionStatus)this.eventAction_0).missionStatus;
					break;
				}
				case EventAction.EventActionType.LuaScript:
					this.vmethod_4().SelectedIndex = 5;
					if (!string.IsNullOrEmpty(((EventAction_LuaScript)this.eventAction_0).ScriptText))
					{
						this.vmethod_66().Text = ((EventAction_LuaScript)this.eventAction_0).ScriptText;
					}
					this.vmethod_68().Value = new decimal(this.vmethod_66().Font.Size);
					this.vmethod_62().Items.AddRange(LuaSandBox.LuaMethods.OrderBy(EditAction.stringFunc).ToArray<string>());
					this.vmethod_62().SelectedIndex = 0;
					break;
				}
				this.vmethod_4().TabPages[0].Enabled = false;
				this.vmethod_4().TabPages[1].Enabled = false;
				this.vmethod_4().TabPages[2].Enabled = false;
				this.vmethod_4().TabPages[3].Enabled = false;
				this.vmethod_4().TabPages[4].Enabled = false;
				this.vmethod_4().TabPages[5].Enabled = false;
				this.vmethod_4().TabPages[this.vmethod_4().SelectedIndex].Enabled = true;
			}
		}

		// Token: 0x06005F8D RID: 24461 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06005F8E RID: 24462 RVA: 0x002D27C0 File Offset: 0x002D09C0
		private void method_2(object sender, EventArgs e)
		{
			switch (this.eventAction_0.eventActionType)
			{
			case EventAction.EventActionType.TeleportInArea:
				if (((EventAction_TeleportInArea)this.eventAction_0).Area.Count < 3)
				{
					Interaction.MsgBox("You must define at least 3 reference points for the teleport area.", MsgBoxStyle.Exclamation, "Not enough reference points!");
					return;
				}
				break;
			case EventAction.EventActionType.Message:
				((EventAction_Message)this.eventAction_0).strText = this.vmethod_56().BodyHtml;
				break;
			case EventAction.EventActionType.LuaScript:
				((EventAction_LuaScript)this.eventAction_0).ScriptText = this.vmethod_66().Text;
				break;
			}
			this.eventAction_0.strDescription = this.vmethod_0().Text;
			EditAction.Enum184 @enum = this.enum184_0;
			if (@enum != EditAction.Enum184.const_0)
			{
				if (@enum != EditAction.Enum184.const_1)
				{
				}
			}
			else
			{
				Client.GetClientScenario().GetEventActions().Add(this.eventAction_0.GetGuid(), this.eventAction_0);
			}
			base.Close();
		}

		// Token: 0x06005F8F RID: 24463 RVA: 0x0002A5AE File Offset: 0x000287AE
		private void method_3(object sender, EventArgs e)
		{
			((EventAction_Points)this.eventAction_0).SideID = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_18().SelectedItem, null, "tag", new object[0], null, null, null));
		}

		// Token: 0x06005F90 RID: 24464 RVA: 0x0002A5E4 File Offset: 0x000287E4
		private void method_4(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_16().Value))
			{
				((EventAction_Points)this.eventAction_0).PointChange = Convert.ToInt32(this.vmethod_16().Value);
			}
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x0002A620 File Offset: 0x00028820
		private void method_5(object sender, EventArgs e)
		{
			this.eventAction_0.strDescription = this.vmethod_0().Text;
		}

		// Token: 0x06005F92 RID: 24466 RVA: 0x002D28B0 File Offset: 0x002D0AB0
		private void method_6(object sender, EventArgs e)
		{
			HashSet<string> unitIDs = ((EventAction_TeleportInArea)this.eventAction_0).UnitIDs;
			List<object> list = new List<object>();
			IEnumerator enumerator = this.vmethod_28().Items.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					list.Add(RuntimeHelpers.GetObjectValue(objectValue));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			IEnumerator enumerator2 = this.vmethod_28().SelectedItems.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
					list.Remove(RuntimeHelpers.GetObjectValue(objectValue2));
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			IEnumerator enumerator3 = this.vmethod_28().SelectedItems.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator3.Current);
					unitIDs.Add(((ActiveUnit)NewLateBinding.LateGet(objectValue3, null, "Tag", new object[0], null, null, null)).GetGuid());
				}
			}
			finally
			{
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			using (List<object>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					object objectValue4 = RuntimeHelpers.GetObjectValue(enumerator4.Current);
					unitIDs.Remove(((ActiveUnit)NewLateBinding.LateGet(objectValue4, null, "Tag", new object[0], null, null, null)).GetGuid());
				}
			}
		}

		// Token: 0x06005F93 RID: 24467 RVA: 0x002D2A7C File Offset: 0x002D0C7C
		private void method_7(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventAction_0))
			{
				((EventAction_Message)this.eventAction_0).SideID = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_36().SelectedItem, null, "tag", new object[0], null, null, null));
			}
		}

		// Token: 0x06005F94 RID: 24468 RVA: 0x002D2ACC File Offset: 0x002D0CCC
		private void method_8(object sender, EventArgs e)
		{
			checked
			{
				if (Client.GetClientScenario().GetSides().Count<Side>() != 0)
				{
					Side side = Client.GetClientScenario().GetSides()[0];
					Side[] sides = Client.GetClientScenario().GetSides();
					int i = 0;
					while (i < sides.Length)
					{
						Side side2 = sides[i];
						if (!Operators.ConditionalCompareObjectEqual(side2.GetGuid(), NewLateBinding.LateGet(this.vmethod_48().SelectedItem, null, "tag", new object[0], null, null, null), false))
						{
							i++;
						}
						else
						{
							side = side2;
							this.vmethod_46().Items.Clear();
							this.vmethod_46().DisplayMember = "Content";
							foreach (Mission current in side.GetMissionCollection())
							{
								ComboBoxItem comboBoxItem = new ComboBoxItem();
								comboBoxItem.Content = current.Name;
								comboBoxItem.Tag = current.GetGuid();
								this.vmethod_46().Items.Add(comboBoxItem);
							}
							if (Information.IsNothing(this.eventAction_0) || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_46().SelectedItem)))
							{
								return;
							}
							((EventAction_ChangeMissionStatus)this.eventAction_0).MissionID = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_46().SelectedItem, null, "Tag", new object[0], null, null, null));
							if (side.GetMissionCollection().Count > 0)
							{
								this.vmethod_54().SelectedIndex = (int)side.GetMissionCollection()[0].GetMissionStatus(Client.GetClientScenario());
								return;
							}
							return;
						}
					}
					this.vmethod_46().Items.Clear();
					this.vmethod_46().DisplayMember = "Content";
					foreach (Mission current in side.GetMissionCollection())
					{
						ComboBoxItem comboBoxItem = new ComboBoxItem();
						comboBoxItem.Content = current.Name;
						comboBoxItem.Tag = current.GetGuid();
						this.vmethod_46().Items.Add(comboBoxItem);
					}
					if (!Information.IsNothing(this.eventAction_0) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_46().SelectedItem)))
					{
						((EventAction_ChangeMissionStatus)this.eventAction_0).MissionID = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_46().SelectedItem, null, "Tag", new object[0], null, null, null));
						if (side.GetMissionCollection().Count > 0)
						{
							this.vmethod_54().SelectedIndex = (int)side.GetMissionCollection()[0].GetMissionStatus(Client.GetClientScenario());
						}
					}
				}
			}
		}

		// Token: 0x06005F95 RID: 24469 RVA: 0x002D2DAC File Offset: 0x002D0FAC
		private void method_9(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventAction_0))
			{
				((EventAction_ChangeMissionStatus)this.eventAction_0).MissionID = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_46().SelectedItem, null, "Tag", new object[0], null, null, null));
			}
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x0002A638 File Offset: 0x00028838
		private void method_10(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventAction_0))
			{
				((EventAction_ChangeMissionStatus)this.eventAction_0).missionStatus = (Mission._MissionStatus)this.vmethod_54().SelectedIndex;
			}
		}

		// Token: 0x06005F97 RID: 24471 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void EditAction_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06005F98 RID: 24472 RVA: 0x0002A663 File Offset: 0x00028863
		private void method_11(object sender, EventArgs e)
		{
			this.vmethod_66().Text = this.vmethod_66().Text.Insert(this.vmethod_66().SelectionStart, Conversions.ToString(this.vmethod_62().SelectedItem));
		}

		// Token: 0x06005F99 RID: 24473 RVA: 0x0002A69B File Offset: 0x0002889B
		private void method_12(object sender, EventArgs e)
		{
			this.vmethod_66().Font = new Font(this.vmethod_66().Font.FontFamily, Convert.ToSingle(this.vmethod_68().Value));
		}

		// Token: 0x06005F9A RID: 24474 RVA: 0x0002A6CD File Offset: 0x000288CD
		private void method_13(object sender, EventArgs e)
		{
			this.vmethod_56().HtmlContentsEdit();
		}

		// Token: 0x04003265 RID: 12901
		public static Func<string, string> stringFunc = (string string_0) => string_0;

		// Token: 0x04003267 RID: 12903
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_0;

		// Token: 0x04003268 RID: 12904
		[CompilerGenerated]
		private System.Windows.Forms.Label label_0;

		// Token: 0x04003269 RID: 12905
		[CompilerGenerated]
		private Control1 control1_0;

		// Token: 0x0400326A RID: 12906
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x0400326B RID: 12907
		[CompilerGenerated]
		private System.Windows.Forms.Label label_1;

		// Token: 0x0400326C RID: 12908
		[CompilerGenerated]
		private System.Windows.Forms.Button button_0;

		// Token: 0x0400326D RID: 12909
		[CompilerGenerated]
		private System.Windows.Forms.Button button_1;

		// Token: 0x0400326E RID: 12910
		[CompilerGenerated]
		private System.Windows.Forms.Label label_2;

		// Token: 0x0400326F RID: 12911
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x04003270 RID: 12912
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_0;

		// Token: 0x04003271 RID: 12913
		[CompilerGenerated]
		private System.Windows.Forms.Label label_3;

		// Token: 0x04003272 RID: 12914
		[CompilerGenerated]
		private System.Windows.Forms.Label label_4;

		// Token: 0x04003273 RID: 12915
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x04003274 RID: 12916
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x04003275 RID: 12917
		[CompilerGenerated]
		private System.Windows.Forms.ListBox listBox_0;

		// Token: 0x04003276 RID: 12918
		[CompilerGenerated]
		private System.Windows.Forms.Label label_5;

		// Token: 0x04003277 RID: 12919
		[CompilerGenerated]
		private AreaEditor areaEditor_0;

		// Token: 0x04003278 RID: 12920
		[CompilerGenerated]
		private TabPage tabPage_3;

		// Token: 0x04003279 RID: 12921
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_1;

		// Token: 0x0400327A RID: 12922
		[CompilerGenerated]
		private System.Windows.Forms.Label label_6;

		// Token: 0x0400327B RID: 12923
		[CompilerGenerated]
		private System.Windows.Forms.Label label_7;

		// Token: 0x0400327C RID: 12924
		[CompilerGenerated]
		private TabPage tabPage_4;

		// Token: 0x0400327D RID: 12925
		[CompilerGenerated]
		private System.Windows.Forms.Label label_8;

		// Token: 0x0400327E RID: 12926
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_2;

		// Token: 0x0400327F RID: 12927
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_3;

		// Token: 0x04003280 RID: 12928
		[CompilerGenerated]
		private System.Windows.Forms.Label label_9;

		// Token: 0x04003281 RID: 12929
		[CompilerGenerated]
		private System.Windows.Forms.Label label_10;

		// Token: 0x04003282 RID: 12930
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_4;

		// Token: 0x04003283 RID: 12931
		[CompilerGenerated]
		private HtmlEditorControl htmlEditorControl_0;

		// Token: 0x04003284 RID: 12932
		[CompilerGenerated]
		private TabPage tabPage_5;

		// Token: 0x04003285 RID: 12933
		[CompilerGenerated]
		private System.Windows.Forms.Button button_2;

		// Token: 0x04003286 RID: 12934
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_5;

		// Token: 0x04003287 RID: 12935
		[CompilerGenerated]
		private System.Windows.Forms.Label label_11;

		// Token: 0x04003288 RID: 12936
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_1;

		// Token: 0x04003289 RID: 12937
		[CompilerGenerated]
		private NumericUpDown numericUpDown_1;

		// Token: 0x0400328A RID: 12938
		[CompilerGenerated]
		private System.Windows.Forms.Label label_12;

		// Token: 0x0400328B RID: 12939
		[CompilerGenerated]
		private System.Windows.Forms.Button button_3;

		// Token: 0x0400328C RID: 12940
		public EventAction eventAction_0;

		// Token: 0x0400328D RID: 12941
		public EditAction.Enum184 enum184_0;

		// Token: 0x02000B54 RID: 2900
		public enum Enum184 : byte
		{
			// Token: 0x04003290 RID: 12944
			const_0,
			// Token: 0x04003291 RID: 12945
			const_1
		}
	}
}

using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns15;
using ns32;

namespace ns33
{
	// Token: 0x0200099D RID: 2461
	[DesignerGenerated]
	public sealed partial class EditTrigger : CommandForm
	{
		// Token: 0x06003F12 RID: 16146 RVA: 0x00152DD0 File Offset: 0x00150FD0
		public EditTrigger()
		{
			base.FormClosing += new FormClosingEventHandler(this.EditTrigger_FormClosing);
			base.Load += new EventHandler(this.EditTrigger_Load);
			base.KeyDown += new KeyEventHandler(this.EditTrigger_KeyDown);
			base.FormClosed += new FormClosedEventHandler(this.EditTrigger_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x001554A8 File Offset: 0x001536A8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x00020828 File Offset: 0x0001EA28
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(System.Windows.Forms.Label label_19)
		{
			this.label_0 = label_19;
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x001554C0 File Offset: 0x001536C0
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_2()
		{
			return this.textBox_0;
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x001554D8 File Offset: 0x001536D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(System.Windows.Forms.TextBox textBox_5)
		{
			EventHandler value = new EventHandler(this.method_3);
			System.Windows.Forms.TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
			}
			this.textBox_0 = textBox_5;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged += value;
			}
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x00155524 File Offset: 0x00153724
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_4()
		{
			return this.button_0;
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x0015553C File Offset: 0x0015373C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(System.Windows.Forms.Button button_5)
		{
			EventHandler value = new EventHandler(this.method_2);
			System.Windows.Forms.Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_5;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x00155588 File Offset: 0x00153788
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_6()
		{
			return this.button_1;
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x001555A0 File Offset: 0x001537A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(System.Windows.Forms.Button button_5)
		{
			EventHandler value = new EventHandler(this.method_1);
			System.Windows.Forms.Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_5;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x001555EC File Offset: 0x001537EC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_8()
		{
			return this.label_1;
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x00020831 File Offset: 0x0001EA31
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(System.Windows.Forms.Label label_19)
		{
			this.label_1 = label_19;
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x00155604 File Offset: 0x00153804
		[CompilerGenerated]
		internal  TabPage vmethod_10()
		{
			return this.tabPage_0;
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x0002083A File Offset: 0x0001EA3A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TabPage tabPage_9)
		{
			this.tabPage_0 = tabPage_9;
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x0015561C File Offset: 0x0015381C
		[CompilerGenerated]
		internal  Control1 vmethod_12()
		{
			return this.control1_0;
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x00020843 File Offset: 0x0001EA43
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Control1 control1_1)
		{
			this.control1_0 = control1_1;
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x00155634 File Offset: 0x00153834
		[CompilerGenerated]
		internal  UnitFilter vmethod_14()
		{
			return this.unitFilter_0;
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x0002084C File Offset: 0x0001EA4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(UnitFilter unitFilter_5)
		{
			this.unitFilter_0 = unitFilter_5;
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x0015564C File Offset: 0x0015384C
		[CompilerGenerated]
		internal  TabPage vmethod_16()
		{
			return this.tabPage_1;
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x00020855 File Offset: 0x0001EA55
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(TabPage tabPage_9)
		{
			this.tabPage_1 = tabPage_9;
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x00155664 File Offset: 0x00153864
		[CompilerGenerated]
		internal  TabPage vmethod_18()
		{
			return this.tabPage_2;
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x0002085E File Offset: 0x0001EA5E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(TabPage tabPage_9)
		{
			this.tabPage_2 = tabPage_9;
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x0015567C File Offset: 0x0015387C
		[CompilerGenerated]
		internal  UnitFilter vmethod_20()
		{
			return this.unitFilter_1;
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x00020867 File Offset: 0x0001EA67
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(UnitFilter unitFilter_5)
		{
			this.unitFilter_1 = unitFilter_5;
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x00155694 File Offset: 0x00153894
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_22()
		{
			return this.comboBox_0;
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x001556AC File Offset: 0x001538AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(System.Windows.Forms.ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.method_5);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value;
			}
			this.comboBox_0 = comboBox_5;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x001556F8 File Offset: 0x001538F8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_24()
		{
			return this.label_2;
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x00020870 File Offset: 0x0001EA70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(System.Windows.Forms.Label label_19)
		{
			this.label_2 = label_19;
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x00155710 File Offset: 0x00153910
		[CompilerGenerated]
		internal  NumericUpDown vmethod_26()
		{
			return this.numericUpDown_0;
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x00155728 File Offset: 0x00153928
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(NumericUpDown numericUpDown_2)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x06003F31 RID: 16177 RVA: 0x00155774 File Offset: 0x00153974
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_28()
		{
			return this.comboBox_1;
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x0015578C File Offset: 0x0015398C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(System.Windows.Forms.ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.method_4);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value;
			}
			this.comboBox_1 = comboBox_5;
			comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x001557D8 File Offset: 0x001539D8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_30()
		{
			return this.label_3;
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x00020879 File Offset: 0x0001EA79
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(System.Windows.Forms.Label label_19)
		{
			this.label_3 = label_19;
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x001557F0 File Offset: 0x001539F0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_32()
		{
			return this.label_4;
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x00020882 File Offset: 0x0001EA82
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(System.Windows.Forms.Label label_19)
		{
			this.label_4 = label_19;
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x00155808 File Offset: 0x00153A08
		[CompilerGenerated]
		internal  TabPage vmethod_34()
		{
			return this.tabPage_3;
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x0002088B File Offset: 0x0001EA8B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(TabPage tabPage_9)
		{
			this.tabPage_3 = tabPage_9;
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x00155820 File Offset: 0x00153A20
		[CompilerGenerated]
		internal  DateTimePicker vmethod_36()
		{
			return this.dateTimePicker_0;
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x00020894 File Offset: 0x0001EA94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(DateTimePicker dateTimePicker_10)
		{
			this.dateTimePicker_0 = dateTimePicker_10;
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x00155838 File Offset: 0x00153A38
		[CompilerGenerated]
		internal  DateTimePicker vmethod_38()
		{
			return this.dateTimePicker_1;
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x0002089D File Offset: 0x0001EA9D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(DateTimePicker dateTimePicker_10)
		{
			this.dateTimePicker_1 = dateTimePicker_10;
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x00155850 File Offset: 0x00153A50
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_40()
		{
			return this.label_5;
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x000208A6 File Offset: 0x0001EAA6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(System.Windows.Forms.Label label_19)
		{
			this.label_5 = label_19;
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x00155868 File Offset: 0x00153A68
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_42()
		{
			return this.button_2;
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x00155880 File Offset: 0x00153A80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(System.Windows.Forms.Button button_5)
		{
			EventHandler value = new EventHandler(this.method_7);
			System.Windows.Forms.Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_5;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x001558CC File Offset: 0x00153ACC
		[CompilerGenerated]
		internal  NumericUpDown vmethod_44()
		{
			return this.numericUpDown_1;
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x001558E4 File Offset: 0x00153AE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(NumericUpDown numericUpDown_2)
		{
			EventHandler value = new EventHandler(this.method_8);
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

		// Token: 0x06003F43 RID: 16195 RVA: 0x00155930 File Offset: 0x00153B30
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_46()
		{
			return this.label_6;
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x000208AF File Offset: 0x0001EAAF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(System.Windows.Forms.Label label_19)
		{
			this.label_6 = label_19;
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x00155948 File Offset: 0x00153B48
		[CompilerGenerated]
		internal  TabPage vmethod_48()
		{
			return this.tabPage_4;
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x000208B8 File Offset: 0x0001EAB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(TabPage tabPage_9)
		{
			this.tabPage_4 = tabPage_9;
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x00155960 File Offset: 0x00153B60
		[CompilerGenerated]
		internal  UnitFilter vmethod_50()
		{
			return this.unitFilter_2;
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x000208C1 File Offset: 0x0001EAC1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(UnitFilter unitFilter_5)
		{
			this.unitFilter_2 = unitFilter_5;
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x00155978 File Offset: 0x00153B78
		[CompilerGenerated]
		internal  AreaEditor vmethod_52()
		{
			return this.areaEditor_0;
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x000208CA File Offset: 0x0001EACA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(AreaEditor areaEditor_2)
		{
			this.areaEditor_0 = areaEditor_2;
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x00155990 File Offset: 0x00153B90
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_54()
		{
			return this.groupBox_0;
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x000208D3 File Offset: 0x0001EAD3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(System.Windows.Forms.GroupBox groupBox_2)
		{
			this.groupBox_0 = groupBox_2;
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x001559A8 File Offset: 0x00153BA8
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_56()
		{
			return this.textBox_1;
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x000208DC File Offset: 0x0001EADC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(System.Windows.Forms.TextBox textBox_5)
		{
			this.textBox_1 = textBox_5;
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x001559C0 File Offset: 0x00153BC0
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_58()
		{
			return this.textBox_2;
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x000208E5 File Offset: 0x0001EAE5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(System.Windows.Forms.TextBox textBox_5)
		{
			this.textBox_2 = textBox_5;
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x001559D8 File Offset: 0x00153BD8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_60()
		{
			return this.label_7;
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x000208EE File Offset: 0x0001EAEE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(System.Windows.Forms.Label label_19)
		{
			this.label_7 = label_19;
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x001559F0 File Offset: 0x00153BF0
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_62()
		{
			return this.textBox_3;
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x000208F7 File Offset: 0x0001EAF7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(System.Windows.Forms.TextBox textBox_5)
		{
			this.textBox_3 = textBox_5;
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x00155A08 File Offset: 0x00153C08
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_64()
		{
			return this.label_8;
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x00020900 File Offset: 0x0001EB00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(System.Windows.Forms.Label label_19)
		{
			this.label_8 = label_19;
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x00155A20 File Offset: 0x00153C20
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_66()
		{
			return this.label_9;
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x00020909 File Offset: 0x0001EB09
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(System.Windows.Forms.Label label_19)
		{
			this.label_9 = label_19;
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x00155A38 File Offset: 0x00153C38
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_68()
		{
			return this.label_10;
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x00020912 File Offset: 0x0001EB12
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(System.Windows.Forms.Label label_19)
		{
			this.label_10 = label_19;
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x00155A50 File Offset: 0x00153C50
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_70()
		{
			return this.textBox_4;
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x0002091B File Offset: 0x0001EB1B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(System.Windows.Forms.TextBox textBox_5)
		{
			this.textBox_4 = textBox_5;
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x00155A68 File Offset: 0x00153C68
		[CompilerGenerated]
		internal  TabPage vmethod_72()
		{
			return this.tabPage_5;
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x00020924 File Offset: 0x0001EB24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(TabPage tabPage_9)
		{
			this.tabPage_5 = tabPage_9;
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x00155A80 File Offset: 0x00153C80
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_74()
		{
			return this.groupBox_1;
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x0002092D File Offset: 0x0001EB2D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(System.Windows.Forms.GroupBox groupBox_2)
		{
			this.groupBox_1 = groupBox_2;
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x00155A98 File Offset: 0x00153C98
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_76()
		{
			return this.label_11;
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x00020936 File Offset: 0x0001EB36
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(System.Windows.Forms.Label label_19)
		{
			this.label_11 = label_19;
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x00155AB0 File Offset: 0x00153CB0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_78()
		{
			return this.label_12;
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x0002093F File Offset: 0x0001EB3F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(System.Windows.Forms.Label label_19)
		{
			this.label_12 = label_19;
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x00155AC8 File Offset: 0x00153CC8
		[CompilerGenerated]
		internal  AreaEditor vmethod_80()
		{
			return this.areaEditor_1;
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x00020948 File Offset: 0x0001EB48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(AreaEditor areaEditor_2)
		{
			this.areaEditor_1 = areaEditor_2;
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x00155AE0 File Offset: 0x00153CE0
		[CompilerGenerated]
		internal  UnitFilter vmethod_82()
		{
			return this.unitFilter_3;
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x00020951 File Offset: 0x0001EB51
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(UnitFilter unitFilter_5)
		{
			this.unitFilter_3 = unitFilter_5;
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x00155AF8 File Offset: 0x00153CF8
		[CompilerGenerated]
		internal  DateTimePicker vmethod_84()
		{
			return this.dateTimePicker_2;
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x0002095A File Offset: 0x0001EB5A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(DateTimePicker dateTimePicker_10)
		{
			this.dateTimePicker_2 = dateTimePicker_10;
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x00155B10 File Offset: 0x00153D10
		[CompilerGenerated]
		internal  DateTimePicker vmethod_86()
		{
			return this.dateTimePicker_3;
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x00020963 File Offset: 0x0001EB63
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(DateTimePicker dateTimePicker_10)
		{
			this.dateTimePicker_3 = dateTimePicker_10;
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x00155B28 File Offset: 0x00153D28
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_88()
		{
			return this.button_3;
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x00155B40 File Offset: 0x00153D40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(System.Windows.Forms.Button button_5)
		{
			EventHandler value = new EventHandler(this.method_14);
			System.Windows.Forms.Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_5;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x00155B8C File Offset: 0x00153D8C
		[CompilerGenerated]
		internal  DateTimePicker vmethod_90()
		{
			return this.dateTimePicker_4;
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x0002096C File Offset: 0x0001EB6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(DateTimePicker dateTimePicker_10)
		{
			this.dateTimePicker_4 = dateTimePicker_10;
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x00155BA4 File Offset: 0x00153DA4
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_92()
		{
			return this.checkBox_0;
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x00020975 File Offset: 0x0001EB75
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(System.Windows.Forms.CheckBox checkBox_1)
		{
			this.checkBox_0 = checkBox_1;
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x00155BBC File Offset: 0x00153DBC
		[CompilerGenerated]
		internal  System.Windows.Forms.ToolTip vmethod_94()
		{
			return this.toolTip_0;
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x0002097E File Offset: 0x0001EB7E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(System.Windows.Forms.ToolTip toolTip_1)
		{
			this.toolTip_0 = toolTip_1;
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x00155BD4 File Offset: 0x00153DD4
		[CompilerGenerated]
		internal  DateTimePicker vmethod_96()
		{
			return this.dateTimePicker_5;
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x00020987 File Offset: 0x0001EB87
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_97(DateTimePicker dateTimePicker_10)
		{
			this.dateTimePicker_5 = dateTimePicker_10;
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x00155BEC File Offset: 0x00153DEC
		[CompilerGenerated]
		internal  TabPage vmethod_98()
		{
			return this.tabPage_6;
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x00020990 File Offset: 0x0001EB90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_99(TabPage tabPage_9)
		{
			this.tabPage_6 = tabPage_9;
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x00155C04 File Offset: 0x00153E04
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_100()
		{
			return this.label_13;
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x00020999 File Offset: 0x0001EB99
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_101(System.Windows.Forms.Label label_19)
		{
			this.label_13 = label_19;
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x00155C1C File Offset: 0x00153E1C
		[CompilerGenerated]
		internal  DateTimePicker vmethod_102()
		{
			return this.dateTimePicker_6;
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x000209A2 File Offset: 0x0001EBA2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_103(DateTimePicker dateTimePicker_10)
		{
			this.dateTimePicker_6 = dateTimePicker_10;
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x00155C34 File Offset: 0x00153E34
		[CompilerGenerated]
		internal  DateTimePicker vmethod_104()
		{
			return this.dateTimePicker_7;
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x000209AB File Offset: 0x0001EBAB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_105(DateTimePicker dateTimePicker_10)
		{
			this.dateTimePicker_7 = dateTimePicker_10;
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x00155C4C File Offset: 0x00153E4C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_106()
		{
			return this.label_14;
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x000209B4 File Offset: 0x0001EBB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_107(System.Windows.Forms.Label label_19)
		{
			this.label_14 = label_19;
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x00155C64 File Offset: 0x00153E64
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_108()
		{
			return this.button_4;
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x00155C7C File Offset: 0x00153E7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_109(System.Windows.Forms.Button button_5)
		{
			EventHandler value = new EventHandler(this.method_15);
			System.Windows.Forms.Button button = this.button_4;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_4 = button_5;
			button = this.button_4;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x00155CC8 File Offset: 0x00153EC8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_110()
		{
			return this.label_15;
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x000209BD File Offset: 0x0001EBBD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_111(System.Windows.Forms.Label label_19)
		{
			this.label_15 = label_19;
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x00155CE0 File Offset: 0x00153EE0
		[CompilerGenerated]
		internal  DateTimePicker vmethod_112()
		{
			return this.dateTimePicker_8;
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x000209C6 File Offset: 0x0001EBC6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_113(DateTimePicker dateTimePicker_10)
		{
			this.dateTimePicker_8 = dateTimePicker_10;
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x00155CF8 File Offset: 0x00153EF8
		[CompilerGenerated]
		internal  DateTimePicker vmethod_114()
		{
			return this.dateTimePicker_9;
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x000209CF File Offset: 0x0001EBCF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_115(DateTimePicker dateTimePicker_10)
		{
			this.dateTimePicker_9 = dateTimePicker_10;
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x00155D10 File Offset: 0x00153F10
		[CompilerGenerated]
		internal  TabPage vmethod_116()
		{
			return this.tabPage_7;
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x000209D8 File Offset: 0x0001EBD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_117(TabPage tabPage_9)
		{
			this.tabPage_7 = tabPage_9;
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x00155D28 File Offset: 0x00153F28
		[CompilerGenerated]
		internal  UnitFilter vmethod_118()
		{
			return this.unitFilter_4;
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x000209E1 File Offset: 0x0001EBE1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_119(UnitFilter unitFilter_5)
		{
			this.unitFilter_4 = unitFilter_5;
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x00155D40 File Offset: 0x00153F40
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_120()
		{
			return this.comboBox_2;
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x00155D58 File Offset: 0x00153F58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_121(System.Windows.Forms.ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.method_16);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value;
			}
			this.comboBox_2 = comboBox_5;
			comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x00155DA4 File Offset: 0x00153FA4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_122()
		{
			return this.label_16;
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x000209EA File Offset: 0x0001EBEA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_123(System.Windows.Forms.Label label_19)
		{
			this.label_16 = label_19;
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x00155DBC File Offset: 0x00153FBC
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_124()
		{
			return this.comboBox_3;
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x00155DD4 File Offset: 0x00153FD4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_125(System.Windows.Forms.ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.method_17);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_3;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_3 = comboBox_5;
			comboBox = this.comboBox_3;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x00155E20 File Offset: 0x00154020
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_126()
		{
			return this.label_17;
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x000209F3 File Offset: 0x0001EBF3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_127(System.Windows.Forms.Label label_19)
		{
			this.label_17 = label_19;
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x00155E38 File Offset: 0x00154038
		[CompilerGenerated]
		internal  TabPage vmethod_128()
		{
			return this.tabPage_8;
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x000209FC File Offset: 0x0001EBFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_129(TabPage tabPage_9)
		{
			this.tabPage_8 = tabPage_9;
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x00155E50 File Offset: 0x00154050
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_130()
		{
			return this.comboBox_4;
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x00155E68 File Offset: 0x00154068
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_131(System.Windows.Forms.ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.method_18);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_4;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_4 = comboBox_5;
			comboBox = this.comboBox_4;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x00155EB4 File Offset: 0x001540B4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_132()
		{
			return this.label_18;
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x00020A05 File Offset: 0x0001EC05
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_133(System.Windows.Forms.Label label_19)
		{
			this.label_18 = label_19;
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x00020A0E File Offset: 0x0001EC0E
		private void EditTrigger_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetListTriggers().method_1();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x00155ECC File Offset: 0x001540CC
		private void EditTrigger_Load(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.eventTrigger_0))
			{
				base.Close();
			}
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_2().Text = this.eventTrigger_0.strDescription;
			this.vmethod_4().Visible = (this.enum187_0 == EditTrigger.Enum187.const_0);
			this.vmethod_6().Visible = this.vmethod_4().Visible;
			IEnumerator enumerator = this.vmethod_12().TabPages.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((TabPage)enumerator.Current).Enabled = false;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			checked
			{
				switch (this.eventTrigger_0.eventTriggerType)
				{
				case EventTrigger.EventTriggerType.UnitDestroyed:
					this.vmethod_12().SelectedIndex = 0;
					this.vmethod_12().TabPages[0].Enabled = true;
					this.vmethod_14().method_0(((EventTrigger_UnitDestroyed)this.eventTrigger_0).TargetFilter);
					break;
				case EventTrigger.EventTriggerType.Points:
				{
					this.vmethod_12().SelectedIndex = 2;
					this.vmethod_12().TabPages[2].Enabled = true;
					this.vmethod_28().Items.Clear();
					this.vmethod_28().DisplayMember = "Content";
					Side[] sides = Client.GetClientScenario().GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						ComboBoxItem comboBoxItem = new ComboBoxItem();
						comboBoxItem.Content = side.GetSideName();
						comboBoxItem.Tag = side.GetGuid();
						this.vmethod_28().Items.Add(comboBoxItem);
					}
					IEnumerator enumerator2 = this.vmethod_28().Items.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							ComboBoxItem comboBoxItem2 = (ComboBoxItem)enumerator2.Current;
							if (Operators.ConditionalCompareObjectEqual(comboBoxItem2.Tag, ((EventTrigger_Points)this.eventTrigger_0).SideID, false))
							{
								this.vmethod_28().SelectedItem = comboBoxItem2;
								break;
							}
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					this.vmethod_22().SelectedIndex = (int)((EventTrigger_Points)this.eventTrigger_0).reachDirection;
					this.vmethod_26().Value = new decimal(((EventTrigger_Points)this.eventTrigger_0).PointValue);
					break;
				}
				case EventTrigger.EventTriggerType.Time:
				{
					this.vmethod_12().SelectedIndex = 3;
					this.vmethod_12().TabPages[3].Enabled = true;
					DateTime time = ((EventTrigger_Time)this.eventTrigger_0).m_Time;
					this.vmethod_40().Text = "当前设置: " + time.ToShortDateString() + " - " + time.ToShortTimeString();
					this.vmethod_38().Value = time;
					this.vmethod_36().Value = time;
					break;
				}
				case EventTrigger.EventTriggerType.UnitDamaged:
					this.vmethod_12().SelectedIndex = 1;
					this.vmethod_12().TabPages[1].Enabled = true;
					this.vmethod_20().method_0(((EventTrigger_UnitDamaged)this.eventTrigger_0).TargetFilter);
					this.vmethod_44().Value = new decimal((int)((EventTrigger_UnitDamaged)this.eventTrigger_0).DamagePercent);
					break;
				case EventTrigger.EventTriggerType.UnitRemainsInArea:
				{
					this.vmethod_12().SelectedIndex = 4;
					this.vmethod_12().TabPages[4].Enabled = true;
					this.vmethod_50().method_0(((EventTrigger_UnitRemainsInArea)this.eventTrigger_0).TargetFilter);
					this.vmethod_52().list_0 = ((EventTrigger_UnitRemainsInArea)this.eventTrigger_0).referencePointList;
					this.vmethod_52().method_1();
					TimeSpan timeSpan = TimeSpan.FromSeconds((double)((EventTrigger_UnitRemainsInArea)this.eventTrigger_0).TD);
					this.vmethod_62().Text = Conversions.ToString(timeSpan.Days);
					this.vmethod_58().Text = Conversions.ToString(timeSpan.Hours);
					this.vmethod_56().Text = Conversions.ToString(timeSpan.Minutes);
					this.vmethod_70().Text = Conversions.ToString(timeSpan.Seconds);
					this.vmethod_62().TextChanged += new EventHandler(this.method_9);
					this.vmethod_58().TextChanged += new EventHandler(this.method_10);
					this.vmethod_56().TextChanged += new EventHandler(this.method_11);
					this.vmethod_70().TextChanged += new EventHandler(this.method_12);
					break;
				}
				case EventTrigger.EventTriggerType.UnitEntersArea:
				{
					this.vmethod_12().SelectedIndex = 5;
					this.vmethod_12().TabPages[5].Enabled = true;
					this.vmethod_82().method_0(((EventTrigger_UnitEntersArea)this.eventTrigger_0).TargetFilter);
					this.vmethod_80().list_0 = ((EventTrigger_UnitEntersArea)this.eventTrigger_0).Area;
					this.vmethod_80().method_1();
					DateTime eTOA = ((EventTrigger_UnitEntersArea)this.eventTrigger_0).ETOA;
					DateTime lTOA = ((EventTrigger_UnitEntersArea)this.eventTrigger_0).LTOA;
					this.vmethod_84().Value = eTOA;
					this.vmethod_96().Value = eTOA;
					this.vmethod_86().Value = lTOA;
					this.vmethod_90().Value = lTOA;
					this.vmethod_78().Text = "Earliest: " + eTOA.ToShortDateString() + " - " + eTOA.ToShortTimeString();
					this.vmethod_76().Text = "Latest: " + lTOA.ToShortDateString() + " - " + lTOA.ToShortTimeString();
					this.vmethod_92().Checked = ((EventTrigger_UnitEntersArea)this.eventTrigger_0).NOT;
					this.vmethod_92().CheckedChanged += new EventHandler(this.method_13);
					break;
				}
				case EventTrigger.EventTriggerType.RandomTime:
				{
					this.vmethod_12().SelectedIndex = 6;
					this.vmethod_12().TabPages[6].Enabled = true;
					DateTime earliestTime = ((EventTrigger_RandomTime)this.eventTrigger_0).EarliestTime;
					DateTime latestTime = ((EventTrigger_RandomTime)this.eventTrigger_0).LatestTime;
					this.vmethod_110().Text = string.Concat(new string[]
					{
						"当前设置: \r\n最早: ",
						earliestTime.ToShortDateString(),
						" - ",
						earliestTime.ToShortTimeString(),
						"\r\n最晚: ",
						latestTime.ToShortDateString(),
						" - ",
						latestTime.ToShortTimeString()
					});
					this.vmethod_114().Value = earliestTime;
					this.vmethod_112().Value = earliestTime;
					this.vmethod_104().Value = latestTime;
					this.vmethod_102().Value = latestTime;
					break;
				}
				case EventTrigger.EventTriggerType.UnitDetected:
				{
					this.vmethod_12().SelectedIndex = 7;
					this.vmethod_12().TabPages[7].Enabled = true;
					this.vmethod_120().Items.Clear();
					this.vmethod_120().DisplayMember = "Content";
					Side[] sides2 = Client.GetClientScenario().GetSides();
					for (int j = 0; j < sides2.Length; j++)
					{
						Side side2 = sides2[j];
						ComboBoxItem comboBoxItem3 = new ComboBoxItem();
						comboBoxItem3.Content = side2.GetSideName();
						comboBoxItem3.Tag = side2.GetGuid();
						this.vmethod_120().Items.Add(comboBoxItem3);
					}
					IEnumerator enumerator3 = this.vmethod_120().Items.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							ComboBoxItem comboBoxItem4 = (ComboBoxItem)enumerator3.Current;
							if (Operators.ConditionalCompareObjectEqual(comboBoxItem4.Tag, ((EventTrigger_UnitDetected)this.eventTrigger_0).DetectorSideID, false))
							{
								this.vmethod_120().SelectedItem = comboBoxItem4;
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
					this.vmethod_118().method_0(((EventTrigger_UnitDetected)this.eventTrigger_0).m_DetectedUnit);
					this.vmethod_124().SelectedIndex = (int)((EventTrigger_UnitDetected)this.eventTrigger_0).identificationStatus;
					break;
				}
				case EventTrigger.EventTriggerType.RegularTime:
					this.vmethod_12().SelectedIndex = 8;
					this.vmethod_12().TabPages[8].Enabled = true;
					this.vmethod_130().SelectedIndex = (int)((EventTrigger_RegularTime)this.eventTrigger_0).Interval;
					break;
				}
			}
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x00156768 File Offset: 0x00154968
		private void method_2(object sender, EventArgs e)
		{
			EditTrigger.Enum187 @enum = this.enum187_0;
			if (@enum != EditTrigger.Enum187.const_0)
			{
				if (@enum != EditTrigger.Enum187.const_1)
				{
				}
			}
			else
			{
				Client.GetClientScenario().GetEventTriggers().Add(this.eventTrigger_0.GetGuid(), this.eventTrigger_0);
			}
			base.Close();
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x00020A2E File Offset: 0x0001EC2E
		private void method_3(object sender, EventArgs e)
		{
			this.eventTrigger_0.strDescription = this.vmethod_2().Text;
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00020A46 File Offset: 0x0001EC46
		private void method_4(object sender, EventArgs e)
		{
			((EventTrigger_Points)this.eventTrigger_0).SideID = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_28().SelectedItem, null, "tag", new object[0], null, null, null));
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x00020A7C File Offset: 0x0001EC7C
		private void method_5(object sender, EventArgs e)
		{
			((EventTrigger_Points)this.eventTrigger_0).reachDirection = (EventTrigger_Points._ReachDirection)this.vmethod_22().SelectedIndex;
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x00020A9A File Offset: 0x0001EC9A
		private void method_6(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_26().Value))
			{
				((EventTrigger_Points)this.eventTrigger_0).PointValue = Convert.ToInt32(this.vmethod_26().Value);
			}
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x001567B0 File Offset: 0x001549B0
		private void method_7(object sender, EventArgs e)
		{
			((EventTrigger_Time)this.eventTrigger_0).m_Time = new DateTime(this.vmethod_38().Value.Year, this.vmethod_38().Value.Month, this.vmethod_38().Value.Day, this.vmethod_36().Value.Hour, this.vmethod_36().Value.Minute, this.vmethod_36().Value.Second);
			this.vmethod_40().Text = "Currently set: " + ((EventTrigger_Time)this.eventTrigger_0).m_Time.ToShortDateString() + " - " + ((EventTrigger_Time)this.eventTrigger_0).m_Time.ToShortTimeString();
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x00156888 File Offset: 0x00154A88
		private void method_8(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_44().Value) && !Information.IsNothing(this.eventTrigger_0))
			{
				((EventTrigger_UnitDamaged)this.eventTrigger_0).DamagePercent = Convert.ToByte(this.vmethod_44().Value);
			}
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x001568DC File Offset: 0x00154ADC
		private void method_9(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.vmethod_62().Text))
			{
				this.vmethod_62().Text = "0";
			}
			if (Versioned.IsNumeric(this.vmethod_62().Text))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(this.vmethod_62().Text), Conversions.ToInteger(this.vmethod_58().Text), Conversions.ToInteger(this.vmethod_56().Text), Conversions.ToInteger(this.vmethod_70().Text));
				if (!Information.IsNothing(this.eventTrigger_0))
				{
					((EventTrigger_UnitRemainsInArea)this.eventTrigger_0).TD = (long)Math.Round(timeSpan.TotalSeconds);
				}
			}
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x00156994 File Offset: 0x00154B94
		private void method_10(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.vmethod_58().Text))
			{
				this.vmethod_58().Text = "0";
			}
			if (Versioned.IsNumeric(this.vmethod_58().Text))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(this.vmethod_62().Text), Conversions.ToInteger(this.vmethod_58().Text), Conversions.ToInteger(this.vmethod_56().Text), Conversions.ToInteger(this.vmethod_70().Text));
				if (!Information.IsNothing(this.eventTrigger_0))
				{
					((EventTrigger_UnitRemainsInArea)this.eventTrigger_0).TD = (long)Math.Round(timeSpan.TotalSeconds);
				}
			}
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x00156A4C File Offset: 0x00154C4C
		private void method_11(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.vmethod_56().Text))
			{
				this.vmethod_56().Text = "0";
			}
			if (Versioned.IsNumeric(this.vmethod_56().Text))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(this.vmethod_62().Text), Conversions.ToInteger(this.vmethod_58().Text), Conversions.ToInteger(this.vmethod_56().Text), Conversions.ToInteger(this.vmethod_70().Text));
				if (!Information.IsNothing(this.eventTrigger_0))
				{
					((EventTrigger_UnitRemainsInArea)this.eventTrigger_0).TD = (long)Math.Round(timeSpan.TotalSeconds);
				}
			}
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x00156B04 File Offset: 0x00154D04
		private void method_12(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.vmethod_70().Text))
			{
				this.vmethod_70().Text = "0";
			}
			if (Versioned.IsNumeric(this.vmethod_70().Text))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(this.vmethod_62().Text), Conversions.ToInteger(this.vmethod_58().Text), Conversions.ToInteger(this.vmethod_56().Text), Conversions.ToInteger(this.vmethod_70().Text));
				if (!Information.IsNothing(this.eventTrigger_0))
				{
					((EventTrigger_UnitRemainsInArea)this.eventTrigger_0).TD = (long)Math.Round(timeSpan.TotalSeconds);
				}
			}
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x00020AD6 File Offset: 0x0001ECD6
		private void method_13(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventTrigger_0))
			{
				((EventTrigger_UnitEntersArea)this.eventTrigger_0).NOT = this.vmethod_92().Checked;
			}
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x00156BBC File Offset: 0x00154DBC
		private void method_14(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventTrigger_0))
			{
				((EventTrigger_UnitEntersArea)this.eventTrigger_0).ETOA = new DateTime(this.vmethod_84().Value.Year, this.vmethod_84().Value.Month, this.vmethod_84().Value.Day, this.vmethod_96().Value.Hour, this.vmethod_96().Value.Minute, this.vmethod_96().Value.Second);
				this.vmethod_78().Text = "Earliest: " + ((EventTrigger_UnitEntersArea)this.eventTrigger_0).ETOA.ToShortDateString() + " - " + ((EventTrigger_UnitEntersArea)this.eventTrigger_0).ETOA.ToShortTimeString();
				((EventTrigger_UnitEntersArea)this.eventTrigger_0).LTOA = new DateTime(this.vmethod_86().Value.Year, this.vmethod_86().Value.Month, this.vmethod_86().Value.Day, this.vmethod_90().Value.Hour, this.vmethod_90().Value.Minute, this.vmethod_90().Value.Second);
				this.vmethod_76().Text = "Latest: " + ((EventTrigger_UnitEntersArea)this.eventTrigger_0).LTOA.ToShortDateString() + " - " + ((EventTrigger_UnitEntersArea)this.eventTrigger_0).LTOA.ToShortTimeString();
			}
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x00156D70 File Offset: 0x00154F70
		private void method_15(object sender, EventArgs e)
		{
			((EventTrigger_RandomTime)this.eventTrigger_0).EarliestTime = new DateTime(this.vmethod_114().Value.Year, this.vmethod_114().Value.Month, this.vmethod_114().Value.Day, this.vmethod_112().Value.Hour, this.vmethod_112().Value.Minute, this.vmethod_112().Value.Second);
			((EventTrigger_RandomTime)this.eventTrigger_0).LatestTime = new DateTime(this.vmethod_104().Value.Year, this.vmethod_104().Value.Month, this.vmethod_104().Value.Day, this.vmethod_102().Value.Hour, this.vmethod_102().Value.Minute, this.vmethod_102().Value.Second);
			if (DateTime.Compare(((EventTrigger_RandomTime)this.eventTrigger_0).EarliestTime, ((EventTrigger_RandomTime)this.eventTrigger_0).LatestTime) > 0)
			{
				Interaction.MsgBox("Error! Earliest Time cannot be greater than Latest Time!", MsgBoxStyle.OkOnly, null);
				this.vmethod_110().Text = "Error! Earliest Time cannot be greater than Latest Time";
			}
			else
			{
				this.vmethod_110().Text = string.Concat(new string[]
				{
					"Currently set: \r\nEarliest: ",
					((EventTrigger_RandomTime)this.eventTrigger_0).EarliestTime.ToShortDateString(),
					" - ",
					((EventTrigger_RandomTime)this.eventTrigger_0).EarliestTime.ToShortTimeString(),
					"\r\nLatest: ",
					((EventTrigger_RandomTime)this.eventTrigger_0).LatestTime.ToShortDateString(),
					" - ",
					((EventTrigger_RandomTime)this.eventTrigger_0).LatestTime.ToShortTimeString()
				});
			}
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void EditTrigger_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06003FAD RID: 16301 RVA: 0x00020B00 File Offset: 0x0001ED00
		private void method_16(object sender, EventArgs e)
		{
			((EventTrigger_UnitDetected)this.eventTrigger_0).DetectorSideID = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_120().SelectedItem, null, "tag", new object[0], null, null, null));
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x00156F74 File Offset: 0x00155174
		private void EditTrigger_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.vmethod_62().TextChanged -= new EventHandler(this.method_9);
			this.vmethod_58().TextChanged -= new EventHandler(this.method_10);
			this.vmethod_56().TextChanged -= new EventHandler(this.method_11);
			this.vmethod_70().TextChanged -= new EventHandler(this.method_12);
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x00020B36 File Offset: 0x0001ED36
		private void method_17(object sender, EventArgs e)
		{
			((EventTrigger_UnitDetected)this.eventTrigger_0).identificationStatus = (Contact_Base.IdentificationStatus)this.vmethod_124().SelectedIndex;
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x00156FE0 File Offset: 0x001551E0
		private void method_18(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventTrigger_0))
			{
				switch (this.vmethod_130().SelectedIndex)
				{
				case 0:
					((EventTrigger_RegularTime)this.eventTrigger_0).Interval = EventTrigger_RegularTime._Interval.Second;
					break;
				case 1:
					((EventTrigger_RegularTime)this.eventTrigger_0).Interval = EventTrigger_RegularTime._Interval.FifthSecond;
					break;
				case 2:
					((EventTrigger_RegularTime)this.eventTrigger_0).Interval = EventTrigger_RegularTime._Interval.FifteenthSecond;
					break;
				case 3:
					((EventTrigger_RegularTime)this.eventTrigger_0).Interval = EventTrigger_RegularTime._Interval.ThirtiethSecond;
					break;
				case 4:
					((EventTrigger_RegularTime)this.eventTrigger_0).Interval = EventTrigger_RegularTime._Interval.Minute;
					break;
				case 5:
					((EventTrigger_RegularTime)this.eventTrigger_0).Interval = EventTrigger_RegularTime._Interval.FifthMinute;
					break;
				case 6:
					((EventTrigger_RegularTime)this.eventTrigger_0).Interval = EventTrigger_RegularTime._Interval.FifteenthMinute;
					break;
				case 7:
					((EventTrigger_RegularTime)this.eventTrigger_0).Interval = EventTrigger_RegularTime._Interval.ThirtiethMinute;
					break;
				case 8:
					((EventTrigger_RegularTime)this.eventTrigger_0).Interval = EventTrigger_RegularTime._Interval.Hour;
					break;
				}
			}
		}

		// Token: 0x04001D02 RID: 7426
		[CompilerGenerated]
		private System.Windows.Forms.Label label_0;

		// Token: 0x04001D03 RID: 7427
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_0;

		// Token: 0x04001D04 RID: 7428
		[CompilerGenerated]
		private System.Windows.Forms.Button button_0;

		// Token: 0x04001D05 RID: 7429
		[CompilerGenerated]
		private System.Windows.Forms.Button button_1;

		// Token: 0x04001D06 RID: 7430
		[CompilerGenerated]
		private System.Windows.Forms.Label label_1;

		// Token: 0x04001D07 RID: 7431
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x04001D08 RID: 7432
		[CompilerGenerated]
		private Control1 control1_0;

		// Token: 0x04001D09 RID: 7433
		[CompilerGenerated]
		private UnitFilter unitFilter_0;

		// Token: 0x04001D0A RID: 7434
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x04001D0B RID: 7435
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x04001D0C RID: 7436
		[CompilerGenerated]
		private UnitFilter unitFilter_1;

		// Token: 0x04001D0D RID: 7437
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_0;

		// Token: 0x04001D0E RID: 7438
		[CompilerGenerated]
		private System.Windows.Forms.Label label_2;

		// Token: 0x04001D0F RID: 7439
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x04001D10 RID: 7440
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_1;

		// Token: 0x04001D11 RID: 7441
		[CompilerGenerated]
		private System.Windows.Forms.Label label_3;

		// Token: 0x04001D12 RID: 7442
		[CompilerGenerated]
		private System.Windows.Forms.Label label_4;

		// Token: 0x04001D13 RID: 7443
		[CompilerGenerated]
		private TabPage tabPage_3;

		// Token: 0x04001D14 RID: 7444
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_0;

		// Token: 0x04001D15 RID: 7445
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_1;

		// Token: 0x04001D16 RID: 7446
		[CompilerGenerated]
		private System.Windows.Forms.Label label_5;

		// Token: 0x04001D17 RID: 7447
		[CompilerGenerated]
		private System.Windows.Forms.Button button_2;

		// Token: 0x04001D18 RID: 7448
		[CompilerGenerated]
		private NumericUpDown numericUpDown_1;

		// Token: 0x04001D19 RID: 7449
		[CompilerGenerated]
		private System.Windows.Forms.Label label_6;

		// Token: 0x04001D1A RID: 7450
		[CompilerGenerated]
		private TabPage tabPage_4;

		// Token: 0x04001D1B RID: 7451
		[CompilerGenerated]
		private UnitFilter unitFilter_2;

		// Token: 0x04001D1C RID: 7452
		[CompilerGenerated]
		private AreaEditor areaEditor_0;

		// Token: 0x04001D1D RID: 7453
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_0;

		// Token: 0x04001D1E RID: 7454
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_1;

		// Token: 0x04001D1F RID: 7455
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_2;

		// Token: 0x04001D20 RID: 7456
		[CompilerGenerated]
		private System.Windows.Forms.Label label_7;

		// Token: 0x04001D21 RID: 7457
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_3;

		// Token: 0x04001D22 RID: 7458
		[CompilerGenerated]
		private System.Windows.Forms.Label label_8;

		// Token: 0x04001D23 RID: 7459
		[CompilerGenerated]
		private System.Windows.Forms.Label label_9;

		// Token: 0x04001D24 RID: 7460
		[CompilerGenerated]
		private System.Windows.Forms.Label label_10;

		// Token: 0x04001D25 RID: 7461
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_4;

		// Token: 0x04001D26 RID: 7462
		[CompilerGenerated]
		private TabPage tabPage_5;

		// Token: 0x04001D27 RID: 7463
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_1;

		// Token: 0x04001D28 RID: 7464
		[CompilerGenerated]
		private System.Windows.Forms.Label label_11;

		// Token: 0x04001D29 RID: 7465
		[CompilerGenerated]
		private System.Windows.Forms.Label label_12;

		// Token: 0x04001D2A RID: 7466
		[CompilerGenerated]
		private AreaEditor areaEditor_1;

		// Token: 0x04001D2B RID: 7467
		[CompilerGenerated]
		private UnitFilter unitFilter_3;

		// Token: 0x04001D2C RID: 7468
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_2;

		// Token: 0x04001D2D RID: 7469
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_3;

		// Token: 0x04001D2E RID: 7470
		[CompilerGenerated]
		private System.Windows.Forms.Button button_3;

		// Token: 0x04001D2F RID: 7471
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_4;

		// Token: 0x04001D30 RID: 7472
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_0;

		// Token: 0x04001D31 RID: 7473
		[CompilerGenerated]
		private System.Windows.Forms.ToolTip toolTip_0;

		// Token: 0x04001D32 RID: 7474
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_5;

		// Token: 0x04001D33 RID: 7475
		[CompilerGenerated]
		private TabPage tabPage_6;

		// Token: 0x04001D34 RID: 7476
		[CompilerGenerated]
		private System.Windows.Forms.Label label_13;

		// Token: 0x04001D35 RID: 7477
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_6;

		// Token: 0x04001D36 RID: 7478
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_7;

		// Token: 0x04001D37 RID: 7479
		[CompilerGenerated]
		private System.Windows.Forms.Label label_14;

		// Token: 0x04001D38 RID: 7480
		[CompilerGenerated]
		private System.Windows.Forms.Button button_4;

		// Token: 0x04001D39 RID: 7481
		[CompilerGenerated]
		private System.Windows.Forms.Label label_15;

		// Token: 0x04001D3A RID: 7482
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_8;

		// Token: 0x04001D3B RID: 7483
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_9;

		// Token: 0x04001D3C RID: 7484
		[CompilerGenerated]
		private TabPage tabPage_7;

		// Token: 0x04001D3D RID: 7485
		[CompilerGenerated]
		private UnitFilter unitFilter_4;

		// Token: 0x04001D3E RID: 7486
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_2;

		// Token: 0x04001D3F RID: 7487
		[CompilerGenerated]
		private System.Windows.Forms.Label label_16;

		// Token: 0x04001D40 RID: 7488
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_3;

		// Token: 0x04001D41 RID: 7489
		[CompilerGenerated]
		private System.Windows.Forms.Label label_17;

		// Token: 0x04001D42 RID: 7490
		[CompilerGenerated]
		private TabPage tabPage_8;

		// Token: 0x04001D43 RID: 7491
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_4;

		// Token: 0x04001D44 RID: 7492
		[CompilerGenerated]
		private System.Windows.Forms.Label label_18;

		// Token: 0x04001D45 RID: 7493
		public EventTrigger eventTrigger_0;

		// Token: 0x04001D46 RID: 7494
		public EditTrigger.Enum187 enum187_0;

		// Token: 0x0200099E RID: 2462
		public enum Enum187 : byte
		{
			// Token: 0x04001D48 RID: 7496
			const_0,
			// Token: 0x04001D49 RID: 7497
			const_1
		}
	}
}

using System;
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
using ns1;
using ns2;
using ns32;
using ns33;

namespace Command
{
	// 新建使命对话框
	[DesignerGenerated]
	public sealed partial class NewMission : CommandForm
	{
		// Token: 0x06004A52 RID: 19026 RVA: 0x001CE05C File Offset: 0x001CC25C
		public NewMission()
		{
			base.FormClosing += new FormClosingEventHandler(this.NewMission_FormClosing);
			base.Load += new EventHandler(this.NewMission_Load);
			base.VisibleChanged += new EventHandler(this.NewMission_VisibleChanged);
			base.KeyDown += new KeyEventHandler(this.NewMission_KeyDown);
			this.bool_0 = true;
			this.bool_1 = false;
			this.bool_2 = false;
			this.bool_3 = false;
			this.bool_4 = false;
			this.InitializeComponent();
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x001CF924 File Offset: 0x001CDB24
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x00023BBB File Offset: 0x00021DBB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_14)
		{
			this.label_0 = label_14;
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x001CF93C File Offset: 0x001CDB3C
		[CompilerGenerated]
		internal  TextBox GetTextBox_Name()
		{
			return this.textBox_0;
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x001CF954 File Offset: 0x001CDB54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TextBox textBox_1)
		{
			EventHandler value = new EventHandler(this.method_1);
			TextBox textBox = this.textBox_0;
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

		// Token: 0x06004A59 RID: 19033 RVA: 0x001CF9A0 File Offset: 0x001CDBA0
		[CompilerGenerated]
		internal  ComboBox GetCB_MissionClass()
		{
			return this.comboBox_0;
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x001CF9B8 File Offset: 0x001CDBB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.method_2);
			ComboBox comboBox = this.comboBox_0;
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

		// Token: 0x06004A5B RID: 19035 RVA: 0x001CFA04 File Offset: 0x001CDC04
		[CompilerGenerated]
		internal  Label vmethod_6()
		{
			return this.label_1;
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x00023BC4 File Offset: 0x00021DC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Label label_14)
		{
			this.label_1 = label_14;
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x001CFA1C File Offset: 0x001CDC1C
		[CompilerGenerated]
		internal  Label vmethod_8()
		{
			return this.label_2;
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x00023BCD File Offset: 0x00021DCD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Label label_14)
		{
			this.label_2 = label_14;
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x001CFA34 File Offset: 0x001CDC34
		[CompilerGenerated]
		internal  ComboBox GetCB_MissionType()
		{
			return this.comboBox_1;
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x00023BD6 File Offset: 0x00021DD6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ComboBox comboBox_5)
		{
			this.comboBox_1 = comboBox_5;
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x001CFA4C File Offset: 0x001CDC4C
		[CompilerGenerated]
		internal  Button vmethod_12()
		{
			return this.button_0;
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x001CFA64 File Offset: 0x001CDC64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_6)
		{
			EventHandler value = new EventHandler(this.method_3);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_6;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x001CFAB0 File Offset: 0x001CDCB0
		[CompilerGenerated]
		internal  Button vmethod_14()
		{
			return this.button_1;
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x001CFAC8 File Offset: 0x001CDCC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Button button_6)
		{
			EventHandler value = new EventHandler(this.method_5);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_6;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x001CFB14 File Offset: 0x001CDD14
		[CompilerGenerated]
		internal  CheckBox GetCB_OpenMissionEditor()
		{
			return this.checkBox_0;
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x001CFB2C File Offset: 0x001CDD2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(CheckBox checkBox_4)
		{
			EventHandler value = new EventHandler(this.method_7);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_0 = checkBox_4;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x001CFB78 File Offset: 0x001CDD78
		[CompilerGenerated]
		internal  ComboBox GetCB_MissionStatus()
		{
			return this.comboBox_2;
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x00023BDF File Offset: 0x00021DDF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(ComboBox comboBox_5)
		{
			this.comboBox_2 = comboBox_5;
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x001CFB90 File Offset: 0x001CDD90
		[CompilerGenerated]
		internal  Label GetLabel_MissionStatus()
		{
			return this.label_3;
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x00023BE8 File Offset: 0x00021DE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Label label_14)
		{
			this.label_3 = label_14;
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x001CFBA8 File Offset: 0x001CDDA8
		[CompilerGenerated]
		internal  Label GetLabel_Category()
		{
			return this.label_4;
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x00023BF1 File Offset: 0x00021DF1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Label label_14)
		{
			this.label_4 = label_14;
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x001CFBC0 File Offset: 0x001CDDC0
		[CompilerGenerated]
		internal  ComboBox GetCB_Category()
		{
			return this.CB_Category;
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x001CFBD8 File Offset: 0x001CDDD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCB_Category(ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.CB_Category_SelectedIndexChanged);
			ComboBox cB_Category = this.CB_Category;
			if (cB_Category != null)
			{
				cB_Category.SelectedIndexChanged -= value;
			}
			this.CB_Category = comboBox_5;
			cB_Category = this.CB_Category;
			if (cB_Category != null)
			{
				cB_Category.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x001CFC24 File Offset: 0x001CDE24
		[CompilerGenerated]
		internal  FlowLayoutPanel GetFlowLayoutPanel1()
		{
			return this.flowLayoutPanel_0;
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x00023BFA File Offset: 0x00021DFA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(FlowLayoutPanel flowLayoutPanel_1)
		{
			this.flowLayoutPanel_0 = flowLayoutPanel_1;
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x001CFC3C File Offset: 0x001CDE3C
		[CompilerGenerated]
		internal  GroupBox vmethod_28()
		{
			return this.groupBox_0;
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x00023C03 File Offset: 0x00021E03
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(GroupBox groupBox_4)
		{
			this.groupBox_0 = groupBox_4;
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x001CFC54 File Offset: 0x001CDE54
		[CompilerGenerated]
		internal  Button vmethod_30()
		{
			return this.button_2;
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x001CFC6C File Offset: 0x001CDE6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Button button_6)
		{
			EventHandler value = new EventHandler(this.method_35);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_6;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x001CFCB8 File Offset: 0x001CDEB8
		[CompilerGenerated]
		internal  DateTimePicker vmethod_32()
		{
			return this.dateTimePicker_0;
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x001CFCD0 File Offset: 0x001CDED0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_12);
			EventHandler value2 = new EventHandler(this.method_13);
			DateTimePicker dateTimePicker = this.dateTimePicker_0;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
			}
			this.dateTimePicker_0 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_0;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
			}
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x001CFD34 File Offset: 0x001CDF34
		[CompilerGenerated]
		internal  DateTimePicker vmethod_34()
		{
			return this.dateTimePicker_1;
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x001CFD4C File Offset: 0x001CDF4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_10);
			EventHandler value2 = new EventHandler(this.method_11);
			EventHandler value3 = new EventHandler(this.method_39);
			EventHandler value4 = new EventHandler(this.method_41);
			DateTimePicker dateTimePicker = this.dateTimePicker_1;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
				dateTimePicker.DropDown -= value3;
				dateTimePicker.CloseUp -= value4;
			}
			this.dateTimePicker_1 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_1;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
				dateTimePicker.DropDown += value3;
				dateTimePicker.CloseUp += value4;
			}
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x001CFDF4 File Offset: 0x001CDFF4
		[CompilerGenerated]
		internal  Label vmethod_36()
		{
			return this.label_5;
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x00023C0C File Offset: 0x00021E0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Label label_14)
		{
			this.label_5 = label_14;
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x001CFE0C File Offset: 0x001CE00C
		[CompilerGenerated]
		internal  Label vmethod_38()
		{
			return this.label_6;
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x00023C15 File Offset: 0x00021E15
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Label label_14)
		{
			this.label_6 = label_14;
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x001CFE24 File Offset: 0x001CE024
		[CompilerGenerated]
		internal  GroupBox vmethod_40()
		{
			return this.groupBox_1;
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x00023C1E File Offset: 0x00021E1E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(GroupBox groupBox_4)
		{
			this.groupBox_1 = groupBox_4;
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x001CFE3C File Offset: 0x001CE03C
		[CompilerGenerated]
		internal  CheckBox GetCheckBox_DeleteMission()
		{
			return this.checkBox_1;
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x00023C27 File Offset: 0x00021E27
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(CheckBox checkBox_4)
		{
			this.checkBox_1 = checkBox_4;
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x001CFE54 File Offset: 0x001CE054
		[CompilerGenerated]
		internal  CheckBox GetCheckBox_OrderRTB()
		{
			return this.checkBox_2;
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x00023C30 File Offset: 0x00021E30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(CheckBox checkBox_4)
		{
			this.checkBox_2 = checkBox_4;
		}

		// Token: 0x06004A83 RID: 19075 RVA: 0x001CFE6C File Offset: 0x001CE06C
		[CompilerGenerated]
		internal  CheckBox GetCheckBox_UnassignUnits()
		{
			return this.checkBox_3;
		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x00023C39 File Offset: 0x00021E39
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(CheckBox checkBox_4)
		{
			this.checkBox_3 = checkBox_4;
		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x001CFE84 File Offset: 0x001CE084
		[CompilerGenerated]
		internal  Button GetButton_Clear_DeactivationTime()
		{
			return this.button_3;
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x001CFE9C File Offset: 0x001CE09C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Button button_6)
		{
			EventHandler value = new EventHandler(this.method_36);
			Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_6;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x001CFEE8 File Offset: 0x001CE0E8
		[CompilerGenerated]
		internal  DateTimePicker GetDateTimePicker_DeactivationTime()
		{
			return this.dateTimePicker_2;
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x001CFF00 File Offset: 0x001CE100
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_16);
			EventHandler value2 = new EventHandler(this.method_17);
			DateTimePicker dateTimePicker = this.dateTimePicker_2;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
			}
			this.dateTimePicker_2 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_2;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
			}
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x001CFF64 File Offset: 0x001CE164
		[CompilerGenerated]
		internal  Label vmethod_52()
		{
			return this.label_7;
		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x00023C42 File Offset: 0x00021E42
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Label label_14)
		{
			this.label_7 = label_14;
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x001CFF7C File Offset: 0x001CE17C
		[CompilerGenerated]
		internal  DateTimePicker GetDateTimePicker_DeactivationDate()
		{
			return this.dateTimePicker_3;
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x001CFF94 File Offset: 0x001CE194
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_14);
			EventHandler value2 = new EventHandler(this.method_15);
			EventHandler value3 = new EventHandler(this.method_40);
			EventHandler value4 = new EventHandler(this.method_42);
			DateTimePicker dateTimePicker = this.dateTimePicker_3;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
				dateTimePicker.DropDown -= value3;
				dateTimePicker.CloseUp -= value4;
			}
			this.dateTimePicker_3 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_3;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
				dateTimePicker.DropDown += value3;
				dateTimePicker.CloseUp += value4;
			}
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x001D003C File Offset: 0x001CE23C
		[CompilerGenerated]
		internal  Label vmethod_56()
		{
			return this.label_8;
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x00023C4B File Offset: 0x00021E4B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(Label label_14)
		{
			this.label_8 = label_14;
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x001D0054 File Offset: 0x001CE254
		[CompilerGenerated]
		internal  GroupBox GetGroupBox_TakeOffTime()
		{
			return this.groupBox_2;
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x00023C54 File Offset: 0x00021E54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(GroupBox groupBox_4)
		{
			this.groupBox_2 = groupBox_4;
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x001D006C File Offset: 0x001CE26C
		[CompilerGenerated]
		internal  DateTimePicker GetDateTimePicker_TakeOffTime()
		{
			return this.dateTimePicker_4;
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x001D0084 File Offset: 0x001CE284
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_20);
			EventHandler value2 = new EventHandler(this.method_21);
			DateTimePicker dateTimePicker = this.dateTimePicker_4;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
			}
			this.dateTimePicker_4 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_4;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
			}
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x001D00E8 File Offset: 0x001CE2E8
		[CompilerGenerated]
		internal  DateTimePicker GetDateTimePicker_TakeOffDate()
		{
			return this.dateTimePicker_5;
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x001D0100 File Offset: 0x001CE300
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_18);
			EventHandler value2 = new EventHandler(this.method_19);
			EventHandler value3 = new EventHandler(this.method_43);
			DateTimePicker dateTimePicker = this.dateTimePicker_5;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
				dateTimePicker.CloseUp -= value3;
			}
			this.dateTimePicker_5 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_5;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
				dateTimePicker.CloseUp += value3;
			}
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x001D0180 File Offset: 0x001CE380
		[CompilerGenerated]
		internal  Label vmethod_64()
		{
			return this.label_9;
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x00023C5D File Offset: 0x00021E5D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(Label label_14)
		{
			this.label_9 = label_14;
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x001D0198 File Offset: 0x001CE398
		[CompilerGenerated]
		internal  Label vmethod_66()
		{
			return this.label_10;
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x00023C66 File Offset: 0x00021E66
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(Label label_14)
		{
			this.label_10 = label_14;
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x001D01B0 File Offset: 0x001CE3B0
		[CompilerGenerated]
		internal  GroupBox GetGroupBox_TimeOnTarget()
		{
			return this.groupBox_3;
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x00023C6F File Offset: 0x00021E6F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(GroupBox groupBox_4)
		{
			this.groupBox_3 = groupBox_4;
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x001D01C8 File Offset: 0x001CE3C8
		[CompilerGenerated]
		internal  DateTimePicker vmethod_70()
		{
			return this.dateTimePicker_6;
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x001D01E0 File Offset: 0x001CE3E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_24);
			EventHandler value2 = new EventHandler(this.method_25);
			DateTimePicker dateTimePicker = this.dateTimePicker_6;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
			}
			this.dateTimePicker_6 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_6;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
			}
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x001D0244 File Offset: 0x001CE444
		[CompilerGenerated]
		internal  DateTimePicker vmethod_72()
		{
			return this.dateTimePicker_7;
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x001D025C File Offset: 0x001CE45C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_22);
			EventHandler value2 = new EventHandler(this.method_23);
			EventHandler value3 = new EventHandler(this.method_44);
			DateTimePicker dateTimePicker = this.dateTimePicker_7;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
				dateTimePicker.CloseUp -= value3;
			}
			this.dateTimePicker_7 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_7;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
				dateTimePicker.CloseUp += value3;
			}
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x001D02DC File Offset: 0x001CE4DC
		[CompilerGenerated]
		internal  Label vmethod_74()
		{
			return this.label_11;
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x00023C78 File Offset: 0x00021E78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(Label label_14)
		{
			this.label_11 = label_14;
		}

		// Token: 0x06004AA1 RID: 19105 RVA: 0x001D02F4 File Offset: 0x001CE4F4
		[CompilerGenerated]
		internal  Label vmethod_76()
		{
			return this.label_12;
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x00023C81 File Offset: 0x00021E81
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(Label label_14)
		{
			this.label_12 = label_14;
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x001D030C File Offset: 0x001CE50C
		[CompilerGenerated]
		internal  Button GetButton_Clear_TakeOffTime()
		{
			return this.button_4;
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x001D0324 File Offset: 0x001CE524
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(Button button_6)
		{
			EventHandler value = new EventHandler(this.method_37);
			Button button = this.button_4;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_4 = button_6;
			button = this.button_4;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x001D0370 File Offset: 0x001CE570
		[CompilerGenerated]
		internal  Button GetButton_Clear_TimeOnTarget()
		{
			return this.button_5;
		}

		// Token: 0x06004AA6 RID: 19110 RVA: 0x001D0388 File Offset: 0x001CE588
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(Button button_6)
		{
			EventHandler value = new EventHandler(this.method_38);
			Button button = this.button_5;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_5 = button_6;
			button = this.button_5;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004AA7 RID: 19111 RVA: 0x001D03D4 File Offset: 0x001CE5D4
		[CompilerGenerated]
		internal  ComboBox GetCB_ParentPool()
		{
			return this.comboBox_4;
		}

		// Token: 0x06004AA8 RID: 19112 RVA: 0x00023C8A File Offset: 0x00021E8A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(ComboBox comboBox_5)
		{
			this.comboBox_4 = comboBox_5;
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x001D03EC File Offset: 0x001CE5EC
		[CompilerGenerated]
		internal  Label vmethod_84()
		{
			return this.label_13;
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x00023C93 File Offset: 0x00021E93
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(Label label_14)
		{
			this.label_13 = label_14;
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x00023C9C File Offset: 0x00021E9C
		private void method_1(object sender, EventArgs e)
		{
			this.vmethod_12().Enabled = (Operators.CompareString(this.GetTextBox_Name().Text, "", false) != 0);
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x001D0404 File Offset: 0x001CE604
		private void method_2(object sender, EventArgs e)
		{
			if (this.GetCB_MissionClass().SelectedIndex != -1)
			{
				switch (this.GetCB_MissionClass().SelectedIndex)
				{
				case 0:
					this.GetCB_MissionType().Enabled = true;
					this.vmethod_8().Enabled = true;
					this.GetCB_MissionType().Items.Clear();
					this.GetCB_MissionType().Items.Add("空中截击");
					this.GetCB_MissionType().Items.Add("对陆打击");
					this.GetCB_MissionType().Items.Add("对海打击");
					this.GetCB_MissionType().Items.Add("对潜突击");
					if (this.GetCB_MissionType().Items.Count > 0 && this.GetCB_MissionType().SelectedIndex < 0)
					{
						this.GetCB_MissionType().SelectedIndex = 0;
					}
					break;
				case 1:
					this.GetCB_MissionType().Enabled = true;
					this.vmethod_8().Enabled = true;
					this.GetCB_MissionType().Items.Clear();
					this.GetCB_MissionType().Items.Add("空战巡逻");
					this.GetCB_MissionType().Items.Add("反水面战巡逻（海上）");
					this.GetCB_MissionType().Items.Add("反水面战巡逻（陆上）");
					this.GetCB_MissionType().Items.Add("反水面战巡逻（混合）");
					this.GetCB_MissionType().Items.Add("反潜战巡逻");
					this.GetCB_MissionType().Items.Add("压制敌防空巡逻");
					this.GetCB_MissionType().Items.Add("海上控制巡逻");
					if (this.GetCB_MissionType().Items.Count > 0 && this.GetCB_MissionType().SelectedIndex < 0)
					{
						this.GetCB_MissionType().SelectedIndex = 0;
					}
					break;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
					this.GetCB_MissionType().Items.Clear();
					this.GetCB_MissionType().Enabled = false;
					this.vmethod_8().Enabled = true;
					break;
				}
			}
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x00023CC5 File Offset: 0x00021EC5
		private void method_3(object sender, EventArgs e)
		{
			this.method_4();
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x001D0638 File Offset: 0x001CE838
		private void method_4()
		{
			if (this.GetCB_Category().SelectedIndex != -1)
			{
				if (this.GetCB_Category().SelectedIndex != 1 && this.GetCB_MissionClass().SelectedIndex == -1)
				{
					Interaction.MsgBox("请为任务（Task）包确定一个类型名称.", MsgBoxStyle.Critical, null);
				}
				else if (Operators.CompareString(this.GetTextBox_Name().Text, "", false) == 0)
				{
					Interaction.MsgBox("请输入名称!", MsgBoxStyle.Critical, null);
				}
				else
				{
					this.method_27();
					this.method_29();
					this.method_31();
					this.method_33();
					switch (this.GetCB_Category().SelectedIndex)
					{
					case 0:
					case 2:
					{
						Mission.MissionCategory missionCategory;
						if (this.GetCB_Category().SelectedIndex == 2)
						{
							if (this.GetCB_ParentPool().Items.Count == 0 || this.GetCB_ParentPool().SelectedIndex < 0)
							{
								Interaction.MsgBox("请选选择一个上级的飞机任务（Task）池!如果没有，请先创建一个。", MsgBoxStyle.Critical, null);
								return;
							}
							missionCategory = Mission.MissionCategory.Package;
							Client.GetClientSide().PackageIDInc();
						}
						else
						{
							missionCategory = Mission.MissionCategory.Mission;
						}
						switch (this.GetCB_MissionClass().SelectedIndex)
						{
						case 0:
							switch (this.GetCB_MissionType().SelectedIndex)
							{
							case 0:
							{
								Strike strike = new Strike(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, Strike.StrikeType.Air_Intercept);
								if (strike.category == Mission.MissionCategory.Package)
								{
									string right = this.GetCB_ParentPool().SelectedItem.ToString();
									foreach (Mission current in Client.GetClientSide().GetMissionCollection())
									{
										if (Operators.CompareString(current.Name, right, false) == 0)
										{
											((TaskPool)current).Packages.Add(strike);
											strike.SetTaskPoolID(Client.GetClientSide(), current.GetGuid());
											break;
										}
									}
								}
								int selectedIndex = this.GetCB_MissionStatus().SelectedIndex;
								if (selectedIndex == 1)
								{
									strike.SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.DeActivation);
								}
								if (this.bool_0)
								{
									Client.GetMissionEditor().method_5(strike);
								}
								strike.Deactivation_UnassignUnits = this.GetCheckBox_UnassignUnits().Checked;
								strike.CheckBox_OrderRTB = this.GetCheckBox_OrderRTB().Checked;
								strike.CheckBox_DeleteMission = this.GetCheckBox_DeleteMission().Checked;
								if (strike.category == Mission.MissionCategory.Mission)
								{
									if (!Information.IsNothing(this.StartTime))
									{
										strike.SetStartTime(this.StartTime);
									}
									if (!Information.IsNothing(this.EndTime))
									{
										strike.SetEndTime(this.EndTime);
									}
								}
								else
								{
									if (!Information.IsNothing(this.TakeOffTime))
									{
										strike.SetTakeOffTime(this.TakeOffTime);
									}
									if (!Information.IsNothing(this.TimeOnTarget))
									{
										strike.SetTimeOnTarget(this.TimeOnTarget);
									}
								}
								if (!Client.GetMissionEditor().Visible)
								{
									Client.GetMissionEditor().Show();
								}
								else
								{
									Client.GetMissionEditor().method_1();
								}
								base.Close();
								break;
							}
							case 1:
							{
								Strike strike2 = new Strike(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, Strike.StrikeType.Land_Strike);
								if (strike2.category == Mission.MissionCategory.Package)
								{
									string right2 = this.GetCB_ParentPool().SelectedItem.ToString();
									foreach (Mission current2 in Client.GetClientSide().GetMissionCollection())
									{
										if (Operators.CompareString(current2.Name, right2, false) == 0)
										{
											((TaskPool)current2).Packages.Add(strike2);
											strike2.SetTaskPoolID(Client.GetClientSide(), current2.GetGuid());
											break;
										}
									}
								}
								int selectedIndex2 = this.GetCB_MissionStatus().SelectedIndex;
								if (selectedIndex2 == 1)
								{
									strike2.SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.DeActivation);
								}
								foreach (Unit current3 in Client.GetClientSide().GetUnitReadOnlyCollection())
								{
									if (current3.GetSide(false) != Client.GetClientSide() && !Client.GetClientSide().IsFriendlyToSide(current3.GetSide(false)))
									{
										if (current3.IsGroup)
										{
											using (IEnumerator<ActiveUnit> enumerator4 = ((Group)current3).GetUnitsInGroup().Values.GetEnumerator())
											{
												while (enumerator4.MoveNext())
												{
													ActiveUnit current4 = enumerator4.Current;
													strike2.SpecificTargets.Add(current4);
													if (strike2.IsActive() && Client.GetClientSide().GetPostureStance(current4.GetSide(false)) != Misc.PostureStance.Hostile)
													{
														Client.GetClientSide().SetPostureStance(current4.GetSide(false), Misc.PostureStance.Hostile);
													}
												}
												continue;
											}
										}
										if (current3.IsActiveUnit())
										{
											strike2.SpecificTargets.Add(current3);
											if (strike2.IsActive() && Client.GetClientSide().GetPostureStance(current3.GetSide(false)) != Misc.PostureStance.Hostile)
											{
												Client.GetClientSide().SetPostureStance(current3.GetSide(false), Misc.PostureStance.Hostile);
											}
										}
										else
										{
											Contact contact = (Contact)current3;
											if (!Information.IsNothing(contact.ActualUnit))
											{
												if (Client.GetClientSide().GetContactsObDictionary().ContainsKey(contact.ActualUnit.GetGuid()))
												{
													using (IEnumerator<ActiveUnit> enumerator5 = ((Group)contact.ActualUnit).GetUnitsInGroup().Values.GetEnumerator())
													{
														while (enumerator5.MoveNext())
														{
															ActiveUnit current5 = enumerator5.Current;
															if (Client.GetClientSide().GetContactObservableDictionary().ContainsKey(current5.GetGuid()))
															{
																Contact contact2 = null;
																Client.GetClientSide().GetContactObservableDictionary().TryGetValue(current5.GetGuid(), ref contact2);
																if (!Information.IsNothing(contact2))
																{
																	strike2.SpecificTargets.Add(contact2);
																	if (strike2.IsActive() && contact.GetPostureStance(Client.GetClientSide()) != Misc.PostureStance.Hostile)
																	{
																		contact.MarkAs(Client.GetClientSide(), false, Misc.PostureStance.Hostile);
																	}
																}
															}
														}
														continue;
													}
												}
												strike2.SpecificTargets.Add(contact);
												if (strike2.IsActive() && contact.GetPostureStance(Client.GetClientSide()) != Misc.PostureStance.Hostile)
												{
													contact.MarkAs(Client.GetClientSide(), false, Misc.PostureStance.Hostile);
												}
											}
										}
									}
								}
								if (strike2.SpecificTargets.Count > 0)
								{
									strike2.PrePlannedOnly = true;
								}
								strike2.Deactivation_UnassignUnits = this.GetCheckBox_UnassignUnits().Checked;
								strike2.CheckBox_OrderRTB = this.GetCheckBox_OrderRTB().Checked;
								strike2.CheckBox_DeleteMission = this.GetCheckBox_DeleteMission().Checked;
								if (strike2.category == Mission.MissionCategory.Mission)
								{
									if (!Information.IsNothing(this.StartTime))
									{
										strike2.SetStartTime(this.StartTime);
									}
									if (!Information.IsNothing(this.EndTime))
									{
										strike2.SetEndTime(this.EndTime);
									}
								}
								else
								{
									if (!Information.IsNothing(this.TakeOffTime))
									{
										strike2.SetTakeOffTime(this.TakeOffTime);
									}
									if (!Information.IsNothing(this.TimeOnTarget))
									{
										strike2.SetTimeOnTarget(this.TimeOnTarget);
									}
								}
								if (this.bool_0)
								{
									Client.GetMissionEditor().method_5(strike2);
									if (!Client.GetMissionEditor().Visible)
									{
										Client.GetMissionEditor().Show();
									}
									else
									{
										Client.GetMissionEditor().method_1();
									}
									Client.GetMissionEditor().Show();
								}
								base.Close();
								break;
							}
							case 2:
							{
								Strike strike3 = new Strike(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, Strike.StrikeType.Maritime_Strike);
								if (strike3.category == Mission.MissionCategory.Package)
								{
									string right3 = this.GetCB_ParentPool().SelectedItem.ToString();
									foreach (Mission current6 in Client.GetClientSide().GetMissionCollection())
									{
										if (Operators.CompareString(current6.Name, right3, false) == 0)
										{
											((TaskPool)current6).Packages.Add(strike3);
											strike3.SetTaskPoolID(Client.GetClientSide(), current6.GetGuid());
											break;
										}
									}
								}
								int selectedIndex3 = this.GetCB_MissionStatus().SelectedIndex;
								if (selectedIndex3 == 1)
								{
									strike3.SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.DeActivation);
								}
								foreach (Unit current7 in Client.GetClientSide().GetUnitReadOnlyCollection())
								{
									if (current7.GetSide(false) != Client.GetClientSide() && !Client.GetClientSide().IsFriendlyToSide(current7.GetSide(false)))
									{
										if (current7.IsGroup)
										{
											using (IEnumerator<ActiveUnit> enumerator8 = ((Group)current7).GetUnitsInGroup().Values.GetEnumerator())
											{
												while (enumerator8.MoveNext())
												{
													ActiveUnit current8 = enumerator8.Current;
													strike3.SpecificTargets.Add(current8);
													if (strike3.IsActive() && Client.GetClientSide().GetPostureStance(current8.GetSide(false)) != Misc.PostureStance.Hostile)
													{
														Client.GetClientSide().SetPostureStance(current8.GetSide(false), Misc.PostureStance.Hostile);
													}
												}
												continue;
											}
										}
										if (current7.IsActiveUnit())
										{
											strike3.SpecificTargets.Add(current7);
											if (strike3.IsActive() && Client.GetClientSide().GetPostureStance(current7.GetSide(false)) != Misc.PostureStance.Hostile)
											{
												Client.GetClientSide().SetPostureStance(current7.GetSide(false), Misc.PostureStance.Hostile);
											}
										}
										else
										{
											Contact contact3 = (Contact)current7;
											if (!Information.IsNothing(contact3.ActualUnit))
											{
												if (Client.GetClientSide().GetContactsObDictionary().ContainsKey(contact3.ActualUnit.GetGuid()))
												{
													using (IEnumerator<ActiveUnit> enumerator9 = ((Group)contact3.ActualUnit).GetUnitsInGroup().Values.GetEnumerator())
													{
														while (enumerator9.MoveNext())
														{
															ActiveUnit current9 = enumerator9.Current;
															if (Client.GetClientSide().GetContactObservableDictionary().ContainsKey(current9.GetGuid()))
															{
																Contact contact4 = null;
																Client.GetClientSide().GetContactObservableDictionary().TryGetValue(current9.GetGuid(), ref contact4);
																if (!Information.IsNothing(contact4))
																{
																	strike3.SpecificTargets.Add(contact4);
																	if (strike3.IsActive() && contact3.GetPostureStance(Client.GetClientSide()) != Misc.PostureStance.Hostile)
																	{
																		contact3.MarkAs(Client.GetClientSide(), false, Misc.PostureStance.Hostile);
																	}
																}
															}
														}
														continue;
													}
												}
												strike3.SpecificTargets.Add(contact3);
												if (strike3.IsActive() && contact3.GetPostureStance(Client.GetClientSide()) != Misc.PostureStance.Hostile)
												{
													contact3.MarkAs(Client.GetClientSide(), false, Misc.PostureStance.Hostile);
												}
											}
										}
									}
								}
								if (strike3.SpecificTargets.Count > 0)
								{
									strike3.PrePlannedOnly = true;
								}
								strike3.Deactivation_UnassignUnits = this.GetCheckBox_UnassignUnits().Checked;
								strike3.CheckBox_OrderRTB = this.GetCheckBox_OrderRTB().Checked;
								strike3.CheckBox_DeleteMission = this.GetCheckBox_DeleteMission().Checked;
								if (strike3.category == Mission.MissionCategory.Mission)
								{
									if (!Information.IsNothing(this.StartTime))
									{
										strike3.SetStartTime(this.StartTime);
									}
									if (!Information.IsNothing(this.EndTime))
									{
										strike3.SetEndTime(this.EndTime);
									}
								}
								else
								{
									if (!Information.IsNothing(this.TakeOffTime))
									{
										strike3.SetTakeOffTime(this.TakeOffTime);
									}
									if (!Information.IsNothing(this.TimeOnTarget))
									{
										strike3.SetTimeOnTarget(this.TimeOnTarget);
									}
								}
								if (this.bool_0)
								{
									Client.GetMissionEditor().method_5(strike3);
									if (!Client.GetMissionEditor().Visible)
									{
										Client.GetMissionEditor().Show();
									}
									else
									{
										Client.GetMissionEditor().method_1();
									}
									Client.GetMissionEditor().Show();
								}
								base.Close();
								break;
							}
							case 3:
							{
								Strike strike4 = new Strike(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, Strike.StrikeType.Sub_Strike);
								if (strike4.category == Mission.MissionCategory.Package)
								{
									string right4 = this.GetCB_ParentPool().SelectedItem.ToString();
									foreach (Mission current10 in Client.GetClientSide().GetMissionCollection())
									{
										if (Operators.CompareString(current10.Name, right4, false) == 0)
										{
											((TaskPool)current10).Packages.Add(strike4);
											strike4.SetTaskPoolID(Client.GetClientSide(), current10.GetGuid());
											break;
										}
									}
								}
								int selectedIndex4 = this.GetCB_MissionStatus().SelectedIndex;
								if (selectedIndex4 == 1)
								{
									strike4.SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.DeActivation);
								}
								foreach (Unit current11 in Client.GetClientSide().GetUnitReadOnlyCollection())
								{
									if (current11.GetSide(false) != Client.GetClientSide() && !Client.GetClientSide().IsFriendlyToSide(current11.GetSide(false)))
									{
										if (current11.IsGroup)
										{
											using (IEnumerator<ActiveUnit> enumerator12 = ((Group)current11).GetUnitsInGroup().Values.GetEnumerator())
											{
												while (enumerator12.MoveNext())
												{
													ActiveUnit current12 = enumerator12.Current;
													strike4.SpecificTargets.Add(current12);
													if (strike4.IsActive() && Client.GetClientSide().GetPostureStance(current12.GetSide(false)) != Misc.PostureStance.Hostile)
													{
														Client.GetClientSide().SetPostureStance(current12.GetSide(false), Misc.PostureStance.Hostile);
													}
												}
												continue;
											}
										}
										if (current11.IsActiveUnit())
										{
											strike4.SpecificTargets.Add(current11);
											if (strike4.IsActive() && Client.GetClientSide().GetPostureStance(current11.GetSide(false)) != Misc.PostureStance.Hostile)
											{
												Client.GetClientSide().SetPostureStance(current11.GetSide(false), Misc.PostureStance.Hostile);
											}
										}
										else
										{
											Contact contact5 = (Contact)current11;
											if (!Information.IsNothing(contact5.ActualUnit))
											{
												if (Client.GetClientSide().GetContactsObDictionary().ContainsKey(contact5.ActualUnit.GetGuid()))
												{
													using (IEnumerator<ActiveUnit> enumerator13 = ((Group)contact5.ActualUnit).GetUnitsInGroup().Values.GetEnumerator())
													{
														while (enumerator13.MoveNext())
														{
															ActiveUnit current13 = enumerator13.Current;
															if (Client.GetClientSide().GetContactObservableDictionary().ContainsKey(current13.GetGuid()))
															{
																Contact contact6 = null;
																Client.GetClientSide().GetContactObservableDictionary().TryGetValue(current13.GetGuid(), ref contact6);
																if (!Information.IsNothing(contact6))
																{
																	strike4.SpecificTargets.Add(contact6);
																	if (strike4.IsActive() && contact5.GetPostureStance(Client.GetClientSide()) != Misc.PostureStance.Hostile)
																	{
																		contact5.MarkAs(Client.GetClientSide(), false, Misc.PostureStance.Hostile);
																	}
																}
															}
														}
														continue;
													}
												}
												strike4.SpecificTargets.Add(contact5);
												if (strike4.IsActive() && contact5.GetPostureStance(Client.GetClientSide()) != Misc.PostureStance.Hostile)
												{
													contact5.MarkAs(Client.GetClientSide(), false, Misc.PostureStance.Hostile);
												}
											}
										}
									}
								}
								if (strike4.SpecificTargets.Count > 0)
								{
									strike4.PrePlannedOnly = true;
								}
								strike4.Deactivation_UnassignUnits = this.GetCheckBox_UnassignUnits().Checked;
								strike4.CheckBox_OrderRTB = this.GetCheckBox_OrderRTB().Checked;
								strike4.CheckBox_DeleteMission = this.GetCheckBox_DeleteMission().Checked;
								if (strike4.category == Mission.MissionCategory.Mission)
								{
									if (!Information.IsNothing(this.StartTime))
									{
										strike4.SetStartTime(this.StartTime);
									}
									if (!Information.IsNothing(this.EndTime))
									{
										strike4.SetEndTime(this.EndTime);
									}
								}
								else
								{
									if (!Information.IsNothing(this.TakeOffTime))
									{
										strike4.SetTakeOffTime(this.TakeOffTime);
									}
									if (!Information.IsNothing(this.TimeOnTarget))
									{
										strike4.SetTimeOnTarget(this.TimeOnTarget);
									}
								}
								if (this.bool_0)
								{
									Client.GetMissionEditor().method_5(strike4);
									if (!Client.GetMissionEditor().Visible)
									{
										Client.GetMissionEditor().Show();
									}
									else
									{
										Client.GetMissionEditor().method_1();
									}
									Client.GetMissionEditor().Show();
								}
								base.Close();
								break;
							}
							default:
								Interaction.MsgBox("Please select a type.", MsgBoxStyle.Critical, null);
								return;
							}
							break;
						case 1:
						{
							IEnumerable<ReferencePoint> enumerable = Client.GetClientSide().GetReferencePoints().Where(NewMission.ReferencePointFunc);
							if (enumerable.Count<ReferencePoint>() == 0)
							{
								Interaction.MsgBox("创建巡逻任务前请先选择至少一个参考点.", MsgBoxStyle.OkOnly, "没有选择参考点!");
								return;
							}
							List<ReferencePoint> list = new List<ReferencePoint>();
							list.AddRange(enumerable);
							Mission mission = null;
							switch (this.GetCB_MissionType().SelectedIndex)
							{
							case 0:
								mission = new Patrol(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, list, GlobalVariables.PatrolType.AAW, true);
								break;
							case 1:
								mission = new Patrol(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, list, GlobalVariables.PatrolType.ASuW_Naval, true);
								break;
							case 2:
								mission = new Patrol(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, list, GlobalVariables.PatrolType.ASuW_Land, true);
								break;
							case 3:
								mission = new Patrol(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, list, GlobalVariables.PatrolType.ASuW_Mixed, true);
								break;
							case 4:
								mission = new Patrol(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, list, GlobalVariables.PatrolType.ASW, true);
								break;
							case 5:
								mission = new Patrol(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, list, GlobalVariables.PatrolType.SEAD, true);
								break;
							case 6:
								mission = new Patrol(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, list, GlobalVariables.PatrolType.SeaControl, true);
								break;
							default:
								Interaction.MsgBox("请选择一个任务类型.", MsgBoxStyle.Critical, null);
								return;
							}
							if (Information.IsNothing(mission))
							{
								Interaction.MsgBox("请选择一个巡逻任务类型.", MsgBoxStyle.OkOnly, "没有选择巡逻任务类型!");
							}
							else
							{
								if (mission.category == Mission.MissionCategory.Package)
								{
									string right5 = this.GetCB_ParentPool().SelectedItem.ToString();
									foreach (Mission current14 in Client.GetClientSide().GetMissionCollection())
									{
										if (Operators.CompareString(current14.Name, right5, false) == 0)
										{
											((TaskPool)current14).Packages.Add(mission);
											mission.SetTaskPoolID(Client.GetClientSide(), current14.GetGuid());
											break;
										}
									}
								}
								int selectedIndex5 = this.GetCB_MissionStatus().SelectedIndex;
								if (selectedIndex5 == 1)
								{
									mission.SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.DeActivation);
								}
								mission.Deactivation_UnassignUnits = this.GetCheckBox_UnassignUnits().Checked;
								mission.CheckBox_OrderRTB = this.GetCheckBox_OrderRTB().Checked;
								mission.CheckBox_DeleteMission = this.GetCheckBox_DeleteMission().Checked;
								if (mission.category == Mission.MissionCategory.Mission)
								{
									if (!Information.IsNothing(this.StartTime))
									{
										mission.SetStartTime(this.StartTime);
									}
									if (!Information.IsNothing(this.EndTime))
									{
										mission.SetEndTime(this.EndTime);
									}
								}
								else
								{
									if (!Information.IsNothing(this.TakeOffTime))
									{
										mission.SetTakeOffTime(this.TakeOffTime);
									}
									if (!Information.IsNothing(this.TimeOnTarget))
									{
										mission.SetTimeOnTarget(this.TimeOnTarget);
									}
								}
								if (this.bool_0)
								{
									Client.GetMissionEditor().method_5(mission);
									if (!Client.GetMissionEditor().Visible)
									{
										Client.GetMissionEditor().Show();
									}
									else
									{
										Client.GetMissionEditor().method_1();
									}
								}
								base.Close();
							}
							break;
						}
						case 2:
						{
							IEnumerable<ReferencePoint> enumerable2 = Client.GetClientSide().GetReferencePoints().Where(NewMission.ReferencePointFunc);
							if (enumerable2.Count<ReferencePoint>() == 0)
							{
								Interaction.MsgBox("在创建支援任务之前请至少建立一个参考点.", MsgBoxStyle.OkOnly, "没有选择参考点!");
								return;
							}
							List<ReferencePoint> list2 = new List<ReferencePoint>();
							list2.AddRange(enumerable2);
							Side clientSide = Client.GetClientSide();
							Scenario clientScenario = Client.GetClientScenario();
							SupportMission supportMission = new SupportMission(ref clientSide, ref clientScenario, this.GetTextBox_Name().Text, missionCategory, ref list2, true);
							Client.SetClientSide(clientSide);
							SupportMission supportMission2 = supportMission;
							if (supportMission2.category == Mission.MissionCategory.Package)
							{
								string right6 = this.GetCB_ParentPool().SelectedItem.ToString();
								foreach (Mission current15 in Client.GetClientSide().GetMissionCollection())
								{
									if (Operators.CompareString(current15.Name, right6, false) == 0)
									{
										((TaskPool)current15).Packages.Add(supportMission2);
										supportMission2.SetTaskPoolID(Client.GetClientSide(), current15.GetGuid());
										break;
									}
								}
							}
							int selectedIndex6 = this.GetCB_MissionStatus().SelectedIndex;
							if (selectedIndex6 == 1)
							{
								supportMission2.SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.DeActivation);
							}
							supportMission2.Deactivation_UnassignUnits = this.GetCheckBox_UnassignUnits().Checked;
							supportMission2.CheckBox_OrderRTB = this.GetCheckBox_OrderRTB().Checked;
							supportMission2.CheckBox_DeleteMission = this.GetCheckBox_DeleteMission().Checked;
							if (supportMission2.category == Mission.MissionCategory.Mission)
							{
								if (!Information.IsNothing(this.StartTime))
								{
									supportMission2.SetStartTime(this.StartTime);
								}
								if (!Information.IsNothing(this.EndTime))
								{
									supportMission2.SetEndTime(this.EndTime);
								}
							}
							else
							{
								if (!Information.IsNothing(this.TakeOffTime))
								{
									supportMission2.SetTakeOffTime(this.TakeOffTime);
								}
								if (!Information.IsNothing(this.TimeOnTarget))
								{
									supportMission2.SetTimeOnTarget(this.TimeOnTarget);
								}
							}
							if (this.bool_0)
							{
								Client.GetMissionEditor().method_5(supportMission2);
								if (!Client.GetMissionEditor().Visible)
								{
									Client.GetMissionEditor().Show();
								}
								else
								{
									Client.GetMissionEditor().method_1();
								}
							}
							base.Close();
							break;
						}
						case 3:
						{
							if (Information.IsNothing(Client.GetHookedUnit()) || !Client.GetHookedUnit().IsActiveUnit())
							{
								Interaction.MsgBox("You must select a valid destination before creating a ferry mission.", MsgBoxStyle.OkOnly, "No valid destination selected!");
								return;
							}
							FerryMission ferryMission = new FerryMission(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, (ActiveUnit)Client.GetHookedUnit());
							if (ferryMission.category == Mission.MissionCategory.Package)
							{
								string right7 = this.GetCB_ParentPool().SelectedItem.ToString();
								foreach (Mission current16 in Client.GetClientSide().GetMissionCollection())
								{
									if (Operators.CompareString(current16.Name, right7, false) == 0)
									{
										((TaskPool)current16).Packages.Add(ferryMission);
										ferryMission.SetTaskPoolID(Client.GetClientSide(), current16.GetGuid());
										break;
									}
								}
							}
							int selectedIndex7 = this.GetCB_MissionStatus().SelectedIndex;
							if (selectedIndex7 == 1)
							{
								ferryMission.SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.DeActivation);
							}
							ferryMission.Deactivation_UnassignUnits = this.GetCheckBox_UnassignUnits().Checked;
							ferryMission.CheckBox_OrderRTB = this.GetCheckBox_OrderRTB().Checked;
							ferryMission.CheckBox_DeleteMission = this.GetCheckBox_DeleteMission().Checked;
							if (ferryMission.category == Mission.MissionCategory.Mission)
							{
								if (!Information.IsNothing(this.StartTime))
								{
									ferryMission.SetStartTime(this.StartTime);
								}
								if (!Information.IsNothing(this.EndTime))
								{
									ferryMission.SetEndTime(this.EndTime);
								}
							}
							else
							{
								if (!Information.IsNothing(this.TakeOffTime))
								{
									ferryMission.SetTakeOffTime(this.TakeOffTime);
								}
								if (!Information.IsNothing(this.TimeOnTarget))
								{
									ferryMission.SetTimeOnTarget(this.TimeOnTarget);
								}
							}
							if (this.bool_0)
							{
								Client.GetMissionEditor().method_5(ferryMission);
								if (!Client.GetMissionEditor().Visible)
								{
									Client.GetMissionEditor().Show();
								}
								else
								{
									Client.GetMissionEditor().method_1();
								}
							}
							base.Close();
							break;
						}
						case 4:
						{
							IEnumerable<ReferencePoint> source = Client.GetClientSide().GetReferencePoints().Where(NewMission.ReferencePointFunc);
							if (source.Count<ReferencePoint>() < 2)
							{
								Interaction.MsgBox("在创建布雷任务之前请至少选择两个参考点.", MsgBoxStyle.OkOnly, "没有选择足够数量的参考点!");
								return;
							}
							List<ReferencePoint> list_ = source.ToList<ReferencePoint>();
							MiningMission miningMission = new MiningMission(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, list_, true);
							if (miningMission.category == Mission.MissionCategory.Package)
							{
								string right8 = this.GetCB_ParentPool().SelectedItem.ToString();
								foreach (Mission current17 in Client.GetClientSide().GetMissionCollection())
								{
									if (Operators.CompareString(current17.Name, right8, false) == 0)
									{
										((TaskPool)current17).Packages.Add(miningMission);
										miningMission.SetTaskPoolID(Client.GetClientSide(), current17.GetGuid());
										break;
									}
								}
							}
							int selectedIndex8 = this.GetCB_MissionStatus().SelectedIndex;
							if (selectedIndex8 == 1)
							{
								miningMission.SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.DeActivation);
							}
							miningMission.Deactivation_UnassignUnits = this.GetCheckBox_UnassignUnits().Checked;
							miningMission.CheckBox_OrderRTB = this.GetCheckBox_OrderRTB().Checked;
							miningMission.CheckBox_DeleteMission = this.GetCheckBox_DeleteMission().Checked;
							if (miningMission.category == Mission.MissionCategory.Mission)
							{
								if (!Information.IsNothing(this.StartTime))
								{
									miningMission.SetStartTime(this.StartTime);
								}
								if (!Information.IsNothing(this.EndTime))
								{
									miningMission.SetEndTime(this.EndTime);
								}
							}
							else
							{
								if (!Information.IsNothing(this.TakeOffTime))
								{
									miningMission.SetTakeOffTime(this.TakeOffTime);
								}
								if (!Information.IsNothing(this.TimeOnTarget))
								{
									miningMission.SetTimeOnTarget(this.TimeOnTarget);
								}
							}
							if (this.bool_0)
							{
								Client.GetMissionEditor().method_5(miningMission);
								if (!Client.GetMissionEditor().Visible)
								{
									Client.GetMissionEditor().Show();
								}
								else
								{
									Client.GetMissionEditor().method_1();
								}
							}
							base.Close();
							break;
						}
						case 5:
						{
							IEnumerable<ReferencePoint> source2 = Client.GetClientSide().GetReferencePoints().Where(NewMission.ReferencePointFunc);
							if (source2.Count<ReferencePoint>() < 2)
							{
								Interaction.MsgBox("在创建扫雷任务之前请至少选择两个参考点.", MsgBoxStyle.OkOnly, "没有选择足够数量的参考点!");
								return;
							}
							List<ReferencePoint> list_2 = source2.ToList<ReferencePoint>();
							MineClearingMission mineClearingMission = new MineClearingMission(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, missionCategory, list_2, true);
							if (mineClearingMission.category == Mission.MissionCategory.Package)
							{
								string right9 = this.GetCB_ParentPool().SelectedItem.ToString();
								foreach (Mission current18 in Client.GetClientSide().GetMissionCollection())
								{
									if (Operators.CompareString(current18.Name, right9, false) == 0)
									{
										((TaskPool)current18).Packages.Add(mineClearingMission);
										mineClearingMission.SetTaskPoolID(Client.GetClientSide(), current18.GetGuid());
										break;
									}
								}
							}
							int selectedIndex9 = this.GetCB_MissionStatus().SelectedIndex;
							if (selectedIndex9 == 1)
							{
								mineClearingMission.SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.DeActivation);
							}
							mineClearingMission.Deactivation_UnassignUnits = this.GetCheckBox_UnassignUnits().Checked;
							mineClearingMission.CheckBox_OrderRTB = this.GetCheckBox_OrderRTB().Checked;
							mineClearingMission.CheckBox_DeleteMission = this.GetCheckBox_DeleteMission().Checked;
							if (mineClearingMission.category == Mission.MissionCategory.Mission)
							{
								if (!Information.IsNothing(this.StartTime))
								{
									mineClearingMission.SetStartTime(this.StartTime);
								}
								if (!Information.IsNothing(this.EndTime))
								{
									mineClearingMission.SetEndTime(this.EndTime);
								}
							}
							else
							{
								if (!Information.IsNothing(this.TakeOffTime))
								{
									mineClearingMission.SetTakeOffTime(this.TakeOffTime);
								}
								if (!Information.IsNothing(this.TimeOnTarget))
								{
									mineClearingMission.SetTimeOnTarget(this.TimeOnTarget);
								}
							}
							if (this.bool_0)
							{
								Client.GetMissionEditor().method_5(mineClearingMission);
								if (!Client.GetMissionEditor().Visible)
								{
									Client.GetMissionEditor().Show();
								}
								else
								{
									Client.GetMissionEditor().method_1();
								}
							}
							base.Close();
							break;
						}
						case 6:
						{
							IEnumerable<ReferencePoint> enumerable3 = Client.GetClientSide().GetReferencePoints().Where(NewMission.ReferencePointFunc);
							if (enumerable3.Count<ReferencePoint>() == 0)
							{
								Interaction.MsgBox("在创建投送任务之前请至少选择一个参考点.", MsgBoxStyle.OkOnly, "没有选择参考点!");
								return;
							}
							List<ReferencePoint> list3 = new List<ReferencePoint>();
							list3.AddRange(enumerable3);
							CargoMission cargoMission = new CargoMission(Client.GetClientSide(), Client.GetClientScenario(), this.GetTextBox_Name().Text, list3, true);
							if (Information.IsNothing(cargoMission))
							{
								Interaction.MsgBox("请选择一个投送任务类型.", MsgBoxStyle.OkOnly, "没有选择投送类型!");
							}
							else
							{
								cargoMission.Name = this.GetTextBox_Name().Text;
								if (this.bool_0)
								{
									Client.GetMissionEditor().method_5(cargoMission);
									if (!Client.GetMissionEditor().Visible)
									{
										Client.GetMissionEditor().Show();
									}
									else
									{
										Client.GetMissionEditor().method_1();
									}
								}
								base.Close();
							}
							break;
						}
						}
						break;
					}
					case 1:
					{
						Side clientSide = Client.GetClientSide();
						Scenario clientScenario = Client.GetClientScenario();
						TaskPool taskPool = new TaskPool(ref clientSide, ref clientScenario, this.GetTextBox_Name().Text, Mission.MissionCategory.TaskPool);
						Client.SetClientSide(clientSide);
						TaskPool mission_ = taskPool;
						if (this.bool_0)
						{
							Client.GetMissionEditor().method_5(mission_);
							if (!Client.GetMissionEditor().Visible)
							{
								Client.GetMissionEditor().Show();
							}
							else
							{
								Client.GetMissionEditor().method_1();
							}
						}
						base.Close();
						break;
					}
					}
					Client.b_Completed = true;
				}
			}
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_5(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x00023CCD File Offset: 0x00021ECD
		private void NewMission_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.GetTextBox_Name().Focus();
			e.Cancel = true;
			base.Hide();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x001D2688 File Offset: 0x001D0888
		public static void SetMissionCategoryData(ref DataTable dataTable_0)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				"任务"
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				"任务（Task）池"
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"任务（Task）包"
			});
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x001D2768 File Offset: 0x001D0968
		private void NewMission_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			DataTable dataSource = new DataTable();
			NewMission.SetMissionCategoryData(ref dataSource);
			ComboBox cB_Category = this.GetCB_Category();
			cB_Category.DataSource = dataSource;
			cB_Category.DropDownWidth = 500;
			cB_Category.DisplayMember = "Description";
			cB_Category.ValueMember = "ID";
			this.GetCB_ParentPool().Visible = false;
			this.GetCheckBox_UnassignUnits().Visible = false;
			this.GetCheckBox_OrderRTB().Visible = false;
			this.GetCheckBox_DeleteMission().Visible = false;
			this.vmethod_84().Visible = false;
			this.Text = "新建任务";
			this.method_6();
			this.vmethod_12().Enabled = (Operators.CompareString(this.GetTextBox_Name().Text, "", false) != 0);
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x00023CF7 File Offset: 0x00021EF7
		private void NewMission_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				this.GetTextBox_Name().Text = "";
				this.method_6();
			}
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x001D2840 File Offset: 0x001D0A40
		private void method_6()
		{
			this.GetTextBox_Name().Text = "";
			this.StartTime = null;
			this.EndTime = null;
			this.TakeOffTime = null;
			this.TimeOnTarget = null;
			this.GetCB_Category().SelectedIndex = 0;
			this.method_9();
			this.GetCB_MissionClass().SelectedIndex = 0;
			this.GetCB_MissionType().SelectedIndex = 0;
			this.GetCB_OpenMissionEditor().Checked = this.bool_0;
			this.GetCB_MissionStatus().SelectedIndex = 0;
			this.vmethod_28().Visible = true;
			this.vmethod_40().Visible = true;
			this.GetGroupBox_TakeOffTime().Visible = false;
			this.GetGroupBox_TimeOnTarget().Visible = false;
			this.vmethod_34().CustomFormat = "None";
			this.vmethod_34().Format = DateTimePickerFormat.Custom;
			this.vmethod_32().CustomFormat = "None";
			this.vmethod_32().Format = DateTimePickerFormat.Custom;
			this.GetDateTimePicker_DeactivationDate().CustomFormat = "None";
			this.GetDateTimePicker_DeactivationDate().Format = DateTimePickerFormat.Custom;
			this.GetDateTimePicker_DeactivationTime().CustomFormat = "None";
			this.GetDateTimePicker_DeactivationTime().Format = DateTimePickerFormat.Custom;
			this.GetDateTimePicker_TakeOffDate().CustomFormat = "None";
			this.GetDateTimePicker_TakeOffDate().Format = DateTimePickerFormat.Custom;
			this.GetDateTimePicker_TakeOffTime().CustomFormat = "None";
			this.GetDateTimePicker_TakeOffTime().Format = DateTimePickerFormat.Custom;
			this.vmethod_72().CustomFormat = "None";
			this.vmethod_72().Format = DateTimePickerFormat.Custom;
			this.vmethod_70().CustomFormat = "None";
			this.vmethod_70().Format = DateTimePickerFormat.Custom;
			this.method_34();
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x001D29EC File Offset: 0x001D0BEC
		private void NewMission_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F11 && e.Modifiers == Keys.Control && base.Visible)
			{
				base.Close();
			}
			else
			{
				if (e.KeyCode == Keys.Return && base.Visible && this.vmethod_12().Enabled)
				{
					this.method_4();
				}
				if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
				{
					CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x00023D1A File Offset: 0x00021F1A
		private void method_7(object sender, EventArgs e)
		{
			this.bool_0 = this.GetCB_OpenMissionEditor().Checked;
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x001D2B10 File Offset: 0x001D0D10
		private void CB_Category_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_9();
			if (this.GetCB_MissionClass().Items.Count > 0 && this.GetCB_MissionClass().SelectedIndex < 0)
			{
				this.GetCB_MissionClass().SelectedIndex = 0;
			}
			if (this.GetCB_MissionType().Items.Count > 0 && this.GetCB_MissionType().SelectedIndex < 0)
			{
				this.GetCB_MissionType().SelectedIndex = 0;
			}
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x001D2B90 File Offset: 0x001D0D90
		private void method_9()
		{
			if (this.GetCB_Category().SelectedIndex != -1)
			{
				switch (this.GetCB_Category().SelectedIndex)
				{
				case 0:
				case 2:
					if (this.GetCB_Category().SelectedIndex == 2)
					{
						this.GetTextBox_Name().Text = "Package " + Conversions.ToString(Client.GetClientSide().GetPackageID());
						this.vmethod_28().Visible = false;
						this.vmethod_40().Visible = false;
						this.GetGroupBox_TakeOffTime().Visible = true;
						this.GetGroupBox_TimeOnTarget().Visible = true;
						this.GetCB_ParentPool().Enabled = true;
						this.vmethod_84().Enabled = true;
						this.GetCB_ParentPool().Items.Clear();
						foreach (Mission current in Client.GetClientSide().GetMissionCollection())
						{
							if (current.category == Mission.MissionCategory.TaskPool)
							{
								this.GetCB_ParentPool().Items.Add(current.Name);
							}
						}
						if (this.GetCB_ParentPool().Items.Count > 0)
						{
							this.GetCB_ParentPool().SelectedIndex = 0;
						}
					}
					else
					{
						this.GetTextBox_Name().Text = "任务: <名称>";
						this.vmethod_28().Visible = true;
						this.vmethod_40().Visible = true;
						this.GetGroupBox_TakeOffTime().Visible = false;
						this.GetGroupBox_TimeOnTarget().Visible = false;
						this.GetCB_ParentPool().Enabled = false;
						this.vmethod_84().Enabled = true;
						this.GetCB_ParentPool().Items.Clear();
					}
					this.GetCB_MissionType().Items.Clear();
					this.GetCB_MissionType().Enabled = false;
					this.vmethod_8().Enabled = false;
					this.GetCB_MissionClass().Enabled = true;
					this.vmethod_6().Enabled = true;
					this.GetCB_MissionClass().Items.Clear();
					this.GetCB_MissionClass().Items.Add("打击");
					this.GetCB_MissionClass().Items.Add("巡逻");
					this.GetCB_MissionClass().Items.Add("支援");
					this.GetCB_MissionClass().Items.Add("转场");
					this.GetCB_MissionClass().Items.Add("布雷");
					this.GetCB_MissionClass().Items.Add("扫雷");
					if (Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps))
					{
						this.GetCB_MissionClass().Items.Add("投送");
					}
					break;
				case 1:
					this.vmethod_28().Visible = false;
					this.vmethod_40().Visible = false;
					this.GetGroupBox_TakeOffTime().Visible = false;
					this.GetGroupBox_TimeOnTarget().Visible = false;
					this.GetCB_ParentPool().Enabled = false;
					this.vmethod_84().Enabled = false;
					this.GetCB_ParentPool().Items.Clear();
					this.GetCB_MissionClass().Items.Clear();
					this.GetCB_MissionClass().Enabled = false;
					this.vmethod_6().Enabled = false;
					this.GetCB_MissionType().Items.Clear();
					this.GetCB_MissionType().Enabled = false;
					this.vmethod_8().Enabled = false;
					this.GetTextBox_Name().Text = "任务（Task）池: <名称>";
					break;
				}
				this.method_34();
			}
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x00023D2D File Offset: 0x00021F2D
		private void method_10(object sender, EventArgs e)
		{
			this.bool_1 = true;
			this.method_26();
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x00023D3C File Offset: 0x00021F3C
		private void method_11(object sender, EventArgs e)
		{
			this.method_27();
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x00023D2D File Offset: 0x00021F2D
		private void method_12(object sender, EventArgs e)
		{
			this.bool_1 = true;
			this.method_26();
		}

		// Token: 0x06004ABC RID: 19132 RVA: 0x00023D3C File Offset: 0x00021F3C
		private void method_13(object sender, EventArgs e)
		{
			this.method_27();
		}

		// Token: 0x06004ABD RID: 19133 RVA: 0x00023D44 File Offset: 0x00021F44
		private void method_14(object sender, EventArgs e)
		{
			this.bool_2 = true;
			this.method_28();
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x00023D53 File Offset: 0x00021F53
		private void method_15(object sender, EventArgs e)
		{
			this.method_29();
		}

		// Token: 0x06004ABF RID: 19135 RVA: 0x00023D44 File Offset: 0x00021F44
		private void method_16(object sender, EventArgs e)
		{
			this.bool_2 = true;
			this.method_28();
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x00023D53 File Offset: 0x00021F53
		private void method_17(object sender, EventArgs e)
		{
			this.method_29();
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x00023D5B File Offset: 0x00021F5B
		private void method_18(object sender, EventArgs e)
		{
			this.bool_3 = true;
			this.method_30();
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x00023D6A File Offset: 0x00021F6A
		private void method_19(object sender, EventArgs e)
		{
			this.method_31();
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x00023D5B File Offset: 0x00021F5B
		private void method_20(object sender, EventArgs e)
		{
			this.bool_3 = true;
			this.method_30();
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x00023D6A File Offset: 0x00021F6A
		private void method_21(object sender, EventArgs e)
		{
			this.method_31();
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x00023D72 File Offset: 0x00021F72
		private void method_22(object sender, EventArgs e)
		{
			this.bool_4 = true;
			this.method_32();
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x00023D81 File Offset: 0x00021F81
		private void method_23(object sender, EventArgs e)
		{
			this.method_33();
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x00023D72 File Offset: 0x00021F72
		private void method_24(object sender, EventArgs e)
		{
			this.bool_4 = true;
			this.method_32();
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x00023D81 File Offset: 0x00021F81
		private void method_25(object sender, EventArgs e)
		{
			this.method_33();
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x001D2F1C File Offset: 0x001D111C
		private void method_26()
		{
			if (Information.IsNothing(this.StartTime))
			{
				this.vmethod_34().Value = Client.GetClientScenario().GetStartTime();
				this.vmethod_32().Value = Client.GetClientScenario().GetStartTime();
			}
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x001D2F68 File Offset: 0x001D1168
		private void method_27()
		{
			if (this.bool_1)
			{
				this.vmethod_34().Format = DateTimePickerFormat.Short;
				this.vmethod_32().Format = DateTimePickerFormat.Time;
				this.StartTime = new DateTime?(new DateTime(this.vmethod_34().Value.Year, this.vmethod_34().Value.Month, this.vmethod_34().Value.Day, this.vmethod_32().Value.Hour, this.vmethod_32().Value.Minute, this.vmethod_32().Value.Second));
				this.bool_1 = false;
			}
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x001D3024 File Offset: 0x001D1224
		private void method_28()
		{
			if (Information.IsNothing(this.EndTime))
			{
				this.GetDateTimePicker_DeactivationDate().Value = Client.GetClientScenario().GetStartTime().Add(Client.GetClientScenario().GetDuration());
				this.GetDateTimePicker_DeactivationTime().Value = Client.GetClientScenario().GetStartTime().Add(Client.GetClientScenario().GetDuration());
			}
		}

		// Token: 0x06004ACC RID: 19148 RVA: 0x001D3094 File Offset: 0x001D1294
		private void method_29()
		{
			if (this.bool_2)
			{
				this.GetDateTimePicker_DeactivationDate().Format = DateTimePickerFormat.Short;
				this.GetDateTimePicker_DeactivationTime().Format = DateTimePickerFormat.Time;
				this.EndTime = new DateTime?(new DateTime(this.GetDateTimePicker_DeactivationDate().Value.Year, this.GetDateTimePicker_DeactivationDate().Value.Month, this.GetDateTimePicker_DeactivationDate().Value.Day, this.GetDateTimePicker_DeactivationTime().Value.Hour, this.GetDateTimePicker_DeactivationTime().Value.Minute, this.GetDateTimePicker_DeactivationTime().Value.Second));
				this.bool_2 = false;
			}
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x001D3150 File Offset: 0x001D1350
		private void method_30()
		{
			if (Information.IsNothing(this.TakeOffTime))
			{
				this.GetDateTimePicker_TakeOffDate().Value = Client.GetClientScenario().GetStartTime().AddMinutes(30.0);
				this.GetDateTimePicker_TakeOffTime().Value = Client.GetClientScenario().GetStartTime().AddMinutes(30.0);
			}
		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x001D31C0 File Offset: 0x001D13C0
		private void method_31()
		{
			if (this.bool_3)
			{
				this.GetDateTimePicker_TakeOffDate().Format = DateTimePickerFormat.Short;
				this.GetDateTimePicker_TakeOffTime().Format = DateTimePickerFormat.Time;
				this.TakeOffTime = new DateTime?(new DateTime(this.GetDateTimePicker_TakeOffDate().Value.Year, this.GetDateTimePicker_TakeOffDate().Value.Month, this.GetDateTimePicker_TakeOffDate().Value.Day, this.GetDateTimePicker_TakeOffTime().Value.Hour, this.GetDateTimePicker_TakeOffTime().Value.Minute, this.GetDateTimePicker_TakeOffTime().Value.Second));
				this.method_34();
				this.bool_3 = false;
			}
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x001D3284 File Offset: 0x001D1484
		private void method_32()
		{
			if (Information.IsNothing(this.TimeOnTarget))
			{
				this.vmethod_72().Value = Client.GetClientScenario().GetStartTime().AddHours(3.0);
				this.vmethod_70().Value = Client.GetClientScenario().GetStartTime().AddHours(3.0);
			}
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x001D32F4 File Offset: 0x001D14F4
		private void method_33()
		{
			if (this.bool_4)
			{
				this.vmethod_72().Format = DateTimePickerFormat.Short;
				this.vmethod_70().Format = DateTimePickerFormat.Time;
				this.TimeOnTarget = new DateTime?(new DateTime(this.vmethod_72().Value.Year, this.vmethod_72().Value.Month, this.vmethod_72().Value.Day, this.vmethod_70().Value.Hour, this.vmethod_70().Value.Minute, this.vmethod_70().Value.Second));
				this.method_34();
				this.bool_4 = false;
			}
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x001D33B8 File Offset: 0x001D15B8
		private void method_34()
		{
			if (this.TimeOnTarget.HasValue)
			{
				this.GetDateTimePicker_TakeOffDate().Enabled = false;
				this.GetDateTimePicker_TakeOffTime().Enabled = false;
				this.GetButton_Clear_TakeOffTime().Enabled = false;
				this.vmethod_72().Enabled = true;
				this.vmethod_70().Enabled = true;
				this.GetButton_Clear_TimeOnTarget().Enabled = true;
			}
			else if (this.TakeOffTime.HasValue)
			{
				this.GetDateTimePicker_TakeOffDate().Enabled = true;
				this.GetDateTimePicker_TakeOffTime().Enabled = true;
				this.GetButton_Clear_TakeOffTime().Enabled = true;
				this.vmethod_72().Enabled = false;
				this.vmethod_70().Enabled = false;
				this.GetButton_Clear_TimeOnTarget().Enabled = false;
			}
			else
			{
				this.GetDateTimePicker_TakeOffDate().Enabled = true;
				this.GetDateTimePicker_TakeOffTime().Enabled = true;
				this.GetButton_Clear_TakeOffTime().Enabled = true;
				this.vmethod_72().Enabled = true;
				this.vmethod_70().Enabled = true;
				this.GetButton_Clear_TimeOnTarget().Enabled = true;
			}
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x001D34C4 File Offset: 0x001D16C4
		private void method_35(object sender, EventArgs e)
		{
			this.StartTime = null;
			this.vmethod_34().CustomFormat = "None";
			this.vmethod_34().Format = DateTimePickerFormat.Custom;
			this.vmethod_32().CustomFormat = "None";
			this.vmethod_32().Format = DateTimePickerFormat.Custom;
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x001D3518 File Offset: 0x001D1718
		private void method_36(object sender, EventArgs e)
		{
			this.EndTime = null;
			this.GetDateTimePicker_DeactivationDate().CustomFormat = "None";
			this.GetDateTimePicker_DeactivationDate().Format = DateTimePickerFormat.Custom;
			this.GetDateTimePicker_DeactivationTime().CustomFormat = "None";
			this.GetDateTimePicker_DeactivationTime().Format = DateTimePickerFormat.Custom;
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x001D356C File Offset: 0x001D176C
		private void method_37(object sender, EventArgs e)
		{
			this.TakeOffTime = null;
			this.GetDateTimePicker_TakeOffDate().CustomFormat = "None";
			this.GetDateTimePicker_TakeOffDate().Format = DateTimePickerFormat.Custom;
			this.GetDateTimePicker_TakeOffTime().CustomFormat = "None";
			this.GetDateTimePicker_TakeOffTime().Format = DateTimePickerFormat.Custom;
			this.method_34();
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x001D35C4 File Offset: 0x001D17C4
		private void method_38(object sender, EventArgs e)
		{
			this.TimeOnTarget = null;
			this.vmethod_72().CustomFormat = "None";
			this.vmethod_72().Format = DateTimePickerFormat.Custom;
			this.vmethod_70().CustomFormat = "None";
			this.vmethod_70().Format = DateTimePickerFormat.Custom;
			this.method_34();
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_39(object sender, EventArgs e)
		{
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_40(object sender, EventArgs e)
		{
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x00023D89 File Offset: 0x00021F89
		private void method_41(object sender, EventArgs e)
		{
			this.bool_1 = true;
			this.method_27();
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x00023D98 File Offset: 0x00021F98
		private void method_42(object sender, EventArgs e)
		{
			this.bool_2 = true;
			this.method_29();
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x00023DA7 File Offset: 0x00021FA7
		private void method_43(object sender, EventArgs e)
		{
			this.bool_3 = true;
			this.method_31();
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x00023DB6 File Offset: 0x00021FB6
		private void method_44(object sender, EventArgs e)
		{
			this.bool_4 = true;
			this.method_33();
		}

		// Token: 0x040022EA RID: 8938
		public static Func<ReferencePoint, bool> ReferencePointFunc = (ReferencePoint referencePoint_0) => referencePoint_0.IsSelected();

		// Token: 0x040022EC RID: 8940
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x040022ED RID: 8941
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x040022EE RID: 8942
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x040022EF RID: 8943
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x040022F0 RID: 8944
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x040022F1 RID: 8945
		[CompilerGenerated]
		private ComboBox comboBox_1;

		// Token: 0x040022F2 RID: 8946
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x040022F3 RID: 8947
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x040022F4 RID: 8948
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x040022F5 RID: 8949
		[CompilerGenerated]
		private ComboBox comboBox_2;

		// Token: 0x040022F6 RID: 8950
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x040022F7 RID: 8951
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x040022F8 RID: 8952
		[CompilerGenerated]
		private ComboBox CB_Category;

		// Token: 0x040022F9 RID: 8953
		[CompilerGenerated]
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x040022FA RID: 8954
		[CompilerGenerated]
		private GroupBox groupBox_0;

		// Token: 0x040022FB RID: 8955
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x040022FC RID: 8956
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_0;

		// Token: 0x040022FD RID: 8957
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_1;

		// Token: 0x040022FE RID: 8958
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x040022FF RID: 8959
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x04002300 RID: 8960
		[CompilerGenerated]
		private GroupBox groupBox_1;

		// Token: 0x04002301 RID: 8961
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x04002302 RID: 8962
		[CompilerGenerated]
		private CheckBox checkBox_2;

		// Token: 0x04002303 RID: 8963
		[CompilerGenerated]
		private CheckBox checkBox_3;

		// Token: 0x04002304 RID: 8964
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04002305 RID: 8965
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_2;

		// Token: 0x04002306 RID: 8966
		[CompilerGenerated]
		private Label label_7;

		// Token: 0x04002307 RID: 8967
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_3;

		// Token: 0x04002308 RID: 8968
		[CompilerGenerated]
		private Label label_8;

		// Token: 0x04002309 RID: 8969
		[CompilerGenerated]
		private GroupBox groupBox_2;

		// Token: 0x0400230A RID: 8970
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_4;

		// Token: 0x0400230B RID: 8971
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_5;

		// Token: 0x0400230C RID: 8972
		[CompilerGenerated]
		private Label label_9;

		// Token: 0x0400230D RID: 8973
		[CompilerGenerated]
		private Label label_10;

		// Token: 0x0400230E RID: 8974
		[CompilerGenerated]
		private GroupBox groupBox_3;

		// Token: 0x0400230F RID: 8975
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_6;

		// Token: 0x04002310 RID: 8976
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_7;

		// Token: 0x04002311 RID: 8977
		[CompilerGenerated]
		private Label label_11;

		// Token: 0x04002312 RID: 8978
		[CompilerGenerated]
		private Label label_12;

		// Token: 0x04002313 RID: 8979
		[CompilerGenerated]
		private Button button_4;

		// Token: 0x04002314 RID: 8980
		[CompilerGenerated]
		private Button button_5;

		// Token: 0x04002315 RID: 8981
		[CompilerGenerated]
		private ComboBox comboBox_4;

		// Token: 0x04002316 RID: 8982
		[CompilerGenerated]
		private Label label_13;

		// Token: 0x04002317 RID: 8983
		private bool bool_0;

		// Token: 0x04002318 RID: 8984
		private bool bool_1;

		// Token: 0x04002319 RID: 8985
		private bool bool_2 = false;

		// Token: 0x0400231A RID: 8986
		private bool bool_3;

		// Token: 0x0400231B RID: 8987
		private bool bool_4;

		// Token: 0x0400231C RID: 8988
		private DateTime? StartTime;

		// Token: 0x0400231D RID: 8989
		private DateTime? EndTime;

		// Token: 0x0400231E RID: 8990
		private DateTime? TakeOffTime;

		// Token: 0x0400231F RID: 8991
		private DateTime? TimeOnTarget;
	}
}

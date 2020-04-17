using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x02000A0A RID: 2570
	[DesignerGenerated]
	public sealed partial class TimesAndDuration : CommandForm
	{
		// Token: 0x06004E6D RID: 20077 RVA: 0x001F8E98 File Offset: 0x001F7098
		public TimesAndDuration()
		{
			base.Load += new EventHandler(this.TimesAndDuration_Load);
			base.KeyDown += new KeyEventHandler(this.TimesAndDuration_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.TimesAndDuration_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x001F9CEC File Offset: 0x001F7EEC
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x00025013 File Offset: 0x00023213
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_11)
		{
			this.label_0 = label_11;
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x001F9D04 File Offset: 0x001F7F04
		[CompilerGenerated]
		internal  TextBox vmethod_2()
		{
			return this.textBox_0;
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x0002501C File Offset: 0x0002321C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TextBox textBox_4)
		{
			this.textBox_0 = textBox_4;
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x001F9D1C File Offset: 0x001F7F1C
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_1;
		}

		// Token: 0x06004E75 RID: 20085 RVA: 0x00025025 File Offset: 0x00023225
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_11)
		{
			this.label_1 = label_11;
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x001F9D34 File Offset: 0x001F7F34
		[CompilerGenerated]
		internal  TextBox vmethod_6()
		{
			return this.textBox_1;
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x0002502E File Offset: 0x0002322E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TextBox textBox_4)
		{
			this.textBox_1 = textBox_4;
		}

		// Token: 0x06004E78 RID: 20088 RVA: 0x001F9D4C File Offset: 0x001F7F4C
		[CompilerGenerated]
		internal  Label vmethod_8()
		{
			return this.label_2;
		}

		// Token: 0x06004E79 RID: 20089 RVA: 0x00025037 File Offset: 0x00023237
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Label label_11)
		{
			this.label_2 = label_11;
		}

		// Token: 0x06004E7A RID: 20090 RVA: 0x001F9D64 File Offset: 0x001F7F64
		[CompilerGenerated]
		internal  DateTimePicker vmethod_10()
		{
			return this.dateTimePicker_0;
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x00025040 File Offset: 0x00023240
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DateTimePicker dateTimePicker_4)
		{
			this.dateTimePicker_0 = dateTimePicker_4;
		}

		// Token: 0x06004E7C RID: 20092 RVA: 0x001F9D7C File Offset: 0x001F7F7C
		[CompilerGenerated]
		internal  Label vmethod_12()
		{
			return this.label_3;
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x00025049 File Offset: 0x00023249
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Label label_11)
		{
			this.label_3 = label_11;
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x001F9D94 File Offset: 0x001F7F94
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_4;
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x00025052 File Offset: 0x00023252
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_11)
		{
			this.label_4 = label_11;
		}

		// Token: 0x06004E80 RID: 20096 RVA: 0x001F9DAC File Offset: 0x001F7FAC
		[CompilerGenerated]
		internal  TextBox vmethod_16()
		{
			return this.textBox_2;
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x0002505B File Offset: 0x0002325B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(TextBox textBox_4)
		{
			this.textBox_2 = textBox_4;
		}

		// Token: 0x06004E82 RID: 20098 RVA: 0x001F9DC4 File Offset: 0x001F7FC4
		[CompilerGenerated]
		internal  Button vmethod_18()
		{
			return this.button_0;
		}

		// Token: 0x06004E83 RID: 20099 RVA: 0x001F9DDC File Offset: 0x001F7FDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Button button_2)
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

		// Token: 0x06004E84 RID: 20100 RVA: 0x001F9E28 File Offset: 0x001F8028
		[CompilerGenerated]
		internal  Button vmethod_20()
		{
			return this.button_1;
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x001F9E40 File Offset: 0x001F8040
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_2);
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

		// Token: 0x06004E86 RID: 20102 RVA: 0x001F9E8C File Offset: 0x001F808C
		[CompilerGenerated]
		internal  DateTimePicker vmethod_22()
		{
			return this.dateTimePicker_1;
		}

		// Token: 0x06004E87 RID: 20103 RVA: 0x00025064 File Offset: 0x00023264
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DateTimePicker dateTimePicker_4)
		{
			this.dateTimePicker_1 = dateTimePicker_4;
		}

		// Token: 0x06004E88 RID: 20104 RVA: 0x001F9EA4 File Offset: 0x001F80A4
		[CompilerGenerated]
		internal  DateTimePicker vmethod_24()
		{
			return this.dateTimePicker_2;
		}

		// Token: 0x06004E89 RID: 20105 RVA: 0x0002506D File Offset: 0x0002326D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DateTimePicker dateTimePicker_4)
		{
			this.dateTimePicker_2 = dateTimePicker_4;
		}

		// Token: 0x06004E8A RID: 20106 RVA: 0x001F9EBC File Offset: 0x001F80BC
		[CompilerGenerated]
		internal  Label vmethod_26()
		{
			return this.label_5;
		}

		// Token: 0x06004E8B RID: 20107 RVA: 0x00025076 File Offset: 0x00023276
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Label label_11)
		{
			this.label_5 = label_11;
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x001F9ED4 File Offset: 0x001F80D4
		[CompilerGenerated]
		internal  DateTimePicker vmethod_28()
		{
			return this.dateTimePicker_3;
		}

		// Token: 0x06004E8D RID: 20109 RVA: 0x0002507F File Offset: 0x0002327F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(DateTimePicker dateTimePicker_4)
		{
			this.dateTimePicker_3 = dateTimePicker_4;
		}

		// Token: 0x06004E8E RID: 20110 RVA: 0x001F9EEC File Offset: 0x001F80EC
		[CompilerGenerated]
		internal  Label vmethod_30()
		{
			return this.label_6;
		}

		// Token: 0x06004E8F RID: 20111 RVA: 0x00025088 File Offset: 0x00023288
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Label label_11)
		{
			this.label_6 = label_11;
		}

		// Token: 0x06004E90 RID: 20112 RVA: 0x001F9F04 File Offset: 0x001F8104
		[CompilerGenerated]
		internal  NumericUpDown vmethod_32()
		{
			return this.numericUpDown_0;
		}

		// Token: 0x06004E91 RID: 20113 RVA: 0x00025091 File Offset: 0x00023291
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(NumericUpDown numericUpDown_2)
		{
			this.numericUpDown_0 = numericUpDown_2;
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x001F9F1C File Offset: 0x001F811C
		[CompilerGenerated]
		internal  Label vmethod_34()
		{
			return this.label_7;
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x0002509A File Offset: 0x0002329A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Label label_11)
		{
			this.label_7 = label_11;
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x001F9F34 File Offset: 0x001F8134
		[CompilerGenerated]
		internal  Label vmethod_36()
		{
			return this.label_8;
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x000250A3 File Offset: 0x000232A3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Label label_11)
		{
			this.label_8 = label_11;
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x001F9F4C File Offset: 0x001F814C
		[CompilerGenerated]
		internal  TextBox vmethod_38()
		{
			return this.textBox_3;
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x000250AC File Offset: 0x000232AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(TextBox textBox_4)
		{
			this.textBox_3 = textBox_4;
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x001F9F64 File Offset: 0x001F8164
		[CompilerGenerated]
		internal  NumericUpDown vmethod_40()
		{
			return this.numericUpDown_1;
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x000250B5 File Offset: 0x000232B5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(NumericUpDown numericUpDown_2)
		{
			this.numericUpDown_1 = numericUpDown_2;
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x001F9F7C File Offset: 0x001F817C
		[CompilerGenerated]
		internal  CheckBox vmethod_42()
		{
			return this.checkBox_0;
		}

		// Token: 0x06004E9B RID: 20123 RVA: 0x001F9F94 File Offset: 0x001F8194
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(CheckBox checkBox_1)
		{
			EventHandler value = new EventHandler(this.method_4);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_0 = checkBox_1;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x001F9FE0 File Offset: 0x001F81E0
		[CompilerGenerated]
		internal  Label vmethod_44()
		{
			return this.label_9;
		}

		// Token: 0x06004E9D RID: 20125 RVA: 0x000250BE File Offset: 0x000232BE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Label label_11)
		{
			this.label_9 = label_11;
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x001F9FF8 File Offset: 0x001F81F8
		[CompilerGenerated]
		internal  Label vmethod_46()
		{
			return this.label_10;
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x000250C7 File Offset: 0x000232C7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Label label_11)
		{
			this.label_10 = label_11;
		}

		// Token: 0x06004EA0 RID: 20128 RVA: 0x001FA010 File Offset: 0x001F8210
		[CompilerGenerated]
		internal  MaskedTextBox vmethod_48()
		{
			return this.maskedTextBox_0;
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x000250D0 File Offset: 0x000232D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(MaskedTextBox maskedTextBox_2)
		{
			this.maskedTextBox_0 = maskedTextBox_2;
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x001FA028 File Offset: 0x001F8228
		[CompilerGenerated]
		internal  MaskedTextBox vmethod_50()
		{
			return this.maskedTextBox_1;
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x000250D9 File Offset: 0x000232D9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(MaskedTextBox maskedTextBox_2)
		{
			this.maskedTextBox_1 = maskedTextBox_2;
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x001FA040 File Offset: 0x001F8240
		private void TimesAndDuration_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_24().Value = Client.GetClientScenario().GetCurrentTime(false);
			this.vmethod_28().Value = Client.GetClientScenario().GetCurrentTime(false);
			if (!Information.IsNothing(Client.GetClientScenario().GetDaylightSavingTime_Start()) && Operators.CompareString(Client.GetClientScenario().GetDaylightSavingTime_Start(), "", false) != 0)
			{
				this.vmethod_48().Text = Client.GetClientScenario().GetDaylightSavingTime_Start();
			}
			else
			{
				this.vmethod_48().Text = "00.00";
			}
			if (!Information.IsNothing(Client.GetClientScenario().GetDaylightSavingTime_End()) && Operators.CompareString(Client.GetClientScenario().GetDaylightSavingTime_End(), "", false) != 0)
			{
				this.vmethod_50().Text = Client.GetClientScenario().GetDaylightSavingTime_End();
			}
			else
			{
				this.vmethod_50().Text = "00.00";
			}
			this.vmethod_42().Checked = Client.GetClientScenario().IsUseDaylightSavingTime();
			this.vmethod_48().Enabled = this.vmethod_42().Checked;
			this.vmethod_50().Enabled = this.vmethod_42().Checked;
			this.vmethod_10().Value = Client.GetClientScenario().GetStartTime();
			this.vmethod_22().Value = Client.GetClientScenario().GetStartTime();
			this.vmethod_6().Text = Conversions.ToString(Client.GetClientScenario().GetDuration().Days);
			this.vmethod_2().Text = Conversions.ToString(Client.GetClientScenario().GetDuration().Hours);
			this.vmethod_16().Text = Conversions.ToString(Client.GetClientScenario().GetDuration().Minutes);
			this.vmethod_32().Value = Conversions.ToDecimal(Interaction.IIf(Client.GetClientScenario().Meta_Complexity == 0, 1, Client.GetClientScenario().Meta_Complexity));
			this.vmethod_40().Value = Conversions.ToDecimal(Interaction.IIf(Client.GetClientScenario().Meta_Difficulty == 0, 1, Client.GetClientScenario().Meta_Difficulty));
			this.vmethod_38().Text = Client.GetClientScenario().Meta_ScenSetting;
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x001FA290 File Offset: 0x001F8490
		private void method_1(object sender, EventArgs e)
		{
			if (!(Versioned.IsNumeric(this.vmethod_6().Text) & Versioned.IsNumeric(this.vmethod_2().Text) & Versioned.IsNumeric(this.vmethod_16().Text)))
			{
				Interaction.MsgBox("Please check that the duration day/hour/minute values are all numeric.", MsgBoxStyle.OkOnly, "Non-numeric values entered!");
			}
			else
			{
				Client.GetClientScenario().SetIsUseDaylightSavingTime(this.vmethod_42().Checked);
				if (Client.GetClientScenario().IsUseDaylightSavingTime() && (!this.method_3(this.vmethod_48().Text.Replace(",", ".")) || !this.method_3(this.vmethod_50().Text.Replace(",", "."))))
				{
					Interaction.MsgBox("Please enter a valid Daylight Saving Time start and end date!", MsgBoxStyle.OkOnly, "Illegal values entered!");
				}
				else
				{
					Client.GetClientScenario().AdvanceSimTime(true, new DateTime(this.vmethod_24().Value.Year, this.vmethod_24().Value.Month, this.vmethod_24().Value.Day, this.vmethod_28().Value.Hour, this.vmethod_28().Value.Minute, this.vmethod_28().Value.Second));
					Client.GetClientScenario().SetDaylightSavingTime_Start(this.vmethod_48().Text.Replace(",", "."));
					Client.GetClientScenario().SetDaylightSavingTime_End(this.vmethod_50().Text.Replace(",", "."));
					Client.GetClientScenario().SetStartTime(new DateTime(this.vmethod_10().Value.Year, this.vmethod_10().Value.Month, this.vmethod_10().Value.Day, this.vmethod_22().Value.Hour, this.vmethod_22().Value.Minute, this.vmethod_22().Value.Second));
					Client.GetClientScenario().SetDuration(new TimeSpan((int)Math.Round(Conversions.ToDouble(this.vmethod_6().Text) * 24.0), (int)Math.Round(Conversions.ToDouble(this.vmethod_2().Text) * 60.0), (int)Math.Round(Conversions.ToDouble(this.vmethod_16().Text) * 60.0)));
					Client.GetClientScenario().Meta_Complexity = Convert.ToInt16(this.vmethod_32().Value);
					Client.GetClientScenario().Meta_Difficulty = Convert.ToInt16(this.vmethod_40().Value);
					Client.GetClientScenario().Meta_ScenSetting = this.vmethod_38().Text;
					CommandFactory.GetCommandMain().GetMainForm().method_156();
					base.Close();
				}
			}
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_2(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x001FA580 File Offset: 0x001F8780
		private bool method_3(string string_0)
		{
			List<string> list = string_0.Split(new char[]
			{
				'.'
			}).ToList<string>();
			return (Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1])) && !(Conversions.ToDouble(list[0]) <= 0.0 | Conversions.ToDouble(list[0]) > 31.0) && !(Conversions.ToDouble(list[1]) <= 0.0 | Conversions.ToDouble(list[1]) > 12.0);
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void TimesAndDuration_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06004EA9 RID: 20137 RVA: 0x000250E2 File Offset: 0x000232E2
		private void method_4(object sender, EventArgs e)
		{
			this.vmethod_48().Enabled = this.vmethod_42().Checked;
			this.vmethod_50().Enabled = this.vmethod_42().Checked;
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x00004D83 File Offset: 0x00002F83
		private void TimesAndDuration_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x04002510 RID: 9488
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04002511 RID: 9489
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04002512 RID: 9490
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04002513 RID: 9491
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x04002514 RID: 9492
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04002515 RID: 9493
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_0;

		// Token: 0x04002516 RID: 9494
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04002517 RID: 9495
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04002518 RID: 9496
		[CompilerGenerated]
		private TextBox textBox_2;

		// Token: 0x04002519 RID: 9497
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x0400251A RID: 9498
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x0400251B RID: 9499
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_1;

		// Token: 0x0400251C RID: 9500
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_2;

		// Token: 0x0400251D RID: 9501
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x0400251E RID: 9502
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_3;

		// Token: 0x0400251F RID: 9503
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x04002520 RID: 9504
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x04002521 RID: 9505
		[CompilerGenerated]
		private Label label_7;

		// Token: 0x04002522 RID: 9506
		[CompilerGenerated]
		private Label label_8;

		// Token: 0x04002523 RID: 9507
		[CompilerGenerated]
		private TextBox textBox_3;

		// Token: 0x04002524 RID: 9508
		[CompilerGenerated]
		private NumericUpDown numericUpDown_1;

		// Token: 0x04002525 RID: 9509
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04002526 RID: 9510
		[CompilerGenerated]
		private Label label_9;

		// Token: 0x04002527 RID: 9511
		[CompilerGenerated]
		private Label label_10;

		// Token: 0x04002528 RID: 9512
		[CompilerGenerated]
		private MaskedTextBox maskedTextBox_0;

		// Token: 0x04002529 RID: 9513
		[CompilerGenerated]
		private MaskedTextBox maskedTextBox_1;
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x02000A4C RID: 2636
	[DesignerGenerated]
	public sealed partial class Form_SetFuelAndAirborneTime : CommandForm
	{
		// Token: 0x060053CE RID: 21454 RVA: 0x00225D00 File Offset: 0x00223F00
		public Form_SetFuelAndAirborneTime()
		{
			base.Load += new EventHandler(this.Form_SetFuelAndAirborneTime_Load);
			base.KeyDown += new KeyEventHandler(this.Form_SetFuelAndAirborneTime_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.Form_SetFuelAndAirborneTime_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x0022607C File Offset: 0x0022427C
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x00026CA0 File Offset: 0x00024EA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_2)
		{
			this.label_0 = label_2;
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x00226094 File Offset: 0x00224294
		[CompilerGenerated]
		internal  TextBox vmethod_2()
		{
			return this.textBox_0;
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x002260AC File Offset: 0x002242AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TextBox textBox_1)
		{
			EventHandler value = new EventHandler(this.method_3);
			EventHandler value2 = new EventHandler(this.method_5);
			TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
				textBox.Enter -= value2;
			}
			this.textBox_0 = textBox_1;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged += value;
				textBox.Enter += value2;
			}
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x00226110 File Offset: 0x00224310
		[CompilerGenerated]
		internal  MaskedTextBox vmethod_4()
		{
			return this.maskedTextBox_0;
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x00226128 File Offset: 0x00224328
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(MaskedTextBox maskedTextBox_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			MaskedTextBox maskedTextBox = this.maskedTextBox_0;
			if (maskedTextBox != null)
			{
				maskedTextBox.TextChanged -= value;
			}
			this.maskedTextBox_0 = maskedTextBox_1;
			maskedTextBox = this.maskedTextBox_0;
			if (maskedTextBox != null)
			{
				maskedTextBox.TextChanged += value;
			}
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x00226174 File Offset: 0x00224374
		[CompilerGenerated]
		internal  Label vmethod_6()
		{
			return this.label_1;
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x00026CA9 File Offset: 0x00024EA9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Label label_2)
		{
			this.label_1 = label_2;
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x0022618C File Offset: 0x0022438C
		[CompilerGenerated]
		internal  CheckBox vmethod_8()
		{
			return this.checkBox_0;
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x002261A4 File Offset: 0x002243A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(CheckBox checkBox_1)
		{
			EventHandler value = new EventHandler(this.method_1);
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

		// Token: 0x060053DB RID: 21467 RVA: 0x00026CB2 File Offset: 0x00024EB2
		private void method_1(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.IsAircraft && this.vmethod_8().Checked)
			{
				this.method_2();
			}
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x002261F0 File Offset: 0x002243F0
		private void method_2()
		{
			double num = (double)this.activeUnit_0.GetFuelConsumption(ActiveUnit.Throttle.Cruise, this.activeUnit_0.GetEngines()[0].GetAltBand(ActiveUnit.Throttle.Cruise), null, null, false, false, false, false);
			float abnTime = ((Aircraft)this.activeUnit_0).AbnTime;
			float num2 = (float)(num * 1.1 * (double)abnTime);
			Aircraft aircraft = (Aircraft)this.activeUnit_0;
			float num3 = (float)aircraft.GetFuelRecsMaxQuantity() - num2;
			if (num3 <= 0f)
			{
				Interaction.MsgBox("Fuel quantity will be zero or negative. Skipping auto-calculating fuel quantity.", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				aircraft.SetFuelQuantity(num3);
				this.bool_0 = false;
				this.vmethod_2().Text = Conversions.ToString(num3);
				this.bool_0 = true;
			}
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x002262B8 File Offset: 0x002244B8
		private void method_3(object sender, EventArgs e)
		{
			if (this.bool_0 && Versioned.IsNumeric(this.vmethod_2().Text))
			{
				if (Conversions.ToSingle(this.vmethod_2().Text) > 0f)
				{
					if (!Information.IsNothing(this.activeUnit_0))
					{
						((Aircraft)this.activeUnit_0).SetFuelQuantity(Conversions.ToSingle(this.vmethod_2().Text));
					}
				}
				else
				{
					this.vmethod_2().Text = Conversions.ToString(this.float_0);
					Interaction.MsgBox("Fuel quantity cannot be zero or negative.", MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x00226354 File Offset: 0x00224554
		private void Form_SetFuelAndAirborneTime_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.bool_0 = false;
			this.Text = this.Text + " " + Client.GetHookedUnit().Name;
			if (!Information.IsNothing(Client.GetHookedUnit()) && Client.GetHookedUnit().IsAircraft)
			{
				this.activeUnit_0 = (ActiveUnit)Client.GetHookedUnit();
				Aircraft aircraft = (Aircraft)this.activeUnit_0;
				if (!Information.IsNothing(aircraft.GetLoadout()))
				{
					aircraft.GetAircraftAirOps();
					this.vmethod_4().Text = this.method_4((int)Math.Round((double)aircraft.AbnTime));
					this.vmethod_2().Text = Conversions.ToString(aircraft.GetCurrentFuelQuantity());
				}
			}
			this.bool_0 = true;
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x0022642C File Offset: 0x0022462C
		private string method_4(int int_0)
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds((double)int_0);
			string result;
			if (timeSpan.Hours > 0)
			{
				result = string.Concat(new string[]
				{
					Interaction.IIf(timeSpan.Hours < 10, "0", "").ToString(),
					Conversions.ToString(timeSpan.Hours),
					":",
					Interaction.IIf(timeSpan.Minutes == 0, "00", Interaction.IIf(timeSpan.Minutes < 10, "0", "").ToString() + Conversions.ToString(timeSpan.Minutes)).ToString(),
					":",
					Interaction.IIf(timeSpan.Seconds == 0, "00", Interaction.IIf(timeSpan.Seconds < 10, "0", "").ToString() + Conversions.ToString(timeSpan.Seconds)).ToString()
				});
			}
			else if (timeSpan.Minutes > 0)
			{
				result = string.Concat(new string[]
				{
					"00:",
					Interaction.IIf(timeSpan.Minutes < 10, "0", "").ToString(),
					Conversions.ToString(timeSpan.Minutes),
					":",
					Interaction.IIf(timeSpan.Seconds == 0, "00", Interaction.IIf(timeSpan.Seconds < 10, "0", "").ToString() + Conversions.ToString(timeSpan.Seconds)).ToString()
				});
			}
			else if (timeSpan.Seconds > 0)
			{
				result = "00:00:" + Interaction.IIf(timeSpan.Seconds < 10, "0", "").ToString() + Conversions.ToString(timeSpan.Seconds);
			}
			else
			{
				result = "00:00:00";
			}
			return result;
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void Form_SetFuelAndAirborneTime_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x060053E1 RID: 21473 RVA: 0x00026CE7 File Offset: 0x00024EE7
		private void method_5(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_2().Text))
			{
				this.float_0 = Conversions.ToSingle(this.vmethod_2().Text);
			}
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x0021F59C File Offset: 0x0021D79C
		private void Form_SetFuelAndAirborneTime_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			Client.b_Completed = true;
			if (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Stop)
			{
				CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit(), false);
			}
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x00226640 File Offset: 0x00224840
		private void method_6(object sender, EventArgs e)
		{
			List<string> list = this.vmethod_4().Text.Split(new char[]
			{
				':'
			}).ToList<string>();
			if (Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list[2]))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2]));
				if (this.activeUnit_0.IsAircraft)
				{
					((Aircraft)this.activeUnit_0).AbnTime = (float)timeSpan.TotalSeconds;
				}
				if (this.vmethod_8().Checked)
				{
					this.method_2();
				}
			}
		}

		// Token: 0x0400276B RID: 10091
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x0400276C RID: 10092
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x0400276D RID: 10093
		[CompilerGenerated]
		private MaskedTextBox maskedTextBox_0;

		// Token: 0x0400276E RID: 10094
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x0400276F RID: 10095
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04002770 RID: 10096
		private bool bool_0;

		// Token: 0x04002771 RID: 10097
		private ActiveUnit activeUnit_0;

		// Token: 0x04002772 RID: 10098
		private float float_0;
	}
}

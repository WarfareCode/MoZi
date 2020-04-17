using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
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
	// Token: 0x02000A31 RID: 2609
	[DesignerGenerated]
	public sealed partial class Form_QuickTurnaround : CommandForm
	{
		// Token: 0x06005300 RID: 21248 RVA: 0x0021F210 File Offset: 0x0021D410
		public Form_QuickTurnaround()
		{
			base.FormClosing += new FormClosingEventHandler(this.Form_QuickTurnaround_FormClosing);
			base.Load += new EventHandler(this.Form_QuickTurnaround_Load);
			base.KeyDown += new KeyEventHandler(this.Form_QuickTurnaround_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x0021F4BC File Offset: 0x0021D6BC
		[CompilerGenerated]
		internal  CheckBox vmethod_0()
		{
			return this.checkBox_0;
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x0021F4D4 File Offset: 0x0021D6D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(CheckBox checkBox_1)
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

		// Token: 0x06005305 RID: 21253 RVA: 0x0021F520 File Offset: 0x0021D720
		[CompilerGenerated]
		internal  ComboBox vmethod_2()
		{
			return this.comboBox_0;
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x0021F538 File Offset: 0x0021D738
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.method_2);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value;
			}
			this.comboBox_0 = comboBox_1;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x0021F584 File Offset: 0x0021D784
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_0;
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x000268E8 File Offset: 0x00024AE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x0021F59C File Offset: 0x0021D79C
		private void Form_QuickTurnaround_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			Client.b_Completed = true;
			if (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Stop)
			{
				CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit(), false);
			}
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x0021F5F8 File Offset: 0x0021D7F8
		private void Form_QuickTurnaround_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			CommandFactory.GetCommandMain().GetMainForm().Enabled = false;
			this.Text = this.Text + " " + Client.GetHookedUnit().Name;
			this.bool_0 = false;
			this.vmethod_4().Text = "";
			this.vmethod_0().Enabled = false;
			this.vmethod_2().Enabled = false;
			if (!Information.IsNothing(Client.GetHookedUnit()) && Client.GetHookedUnit().IsAircraft)
			{
				this.aircraft_0 = (Aircraft)Client.GetHookedUnit();
				if (!Information.IsNothing(this.aircraft_0.GetLoadout()) && this.aircraft_0.GetLoadout().QuickTurnaround)
				{
					Aircraft_AirOps aircraftAirOps = this.aircraft_0.GetAircraftAirOps();
					this.int_0 = this.aircraft_0.GetLoadout().QT_MaxSorties;
					this.vmethod_0().Enabled = true;
					this.vmethod_0().Checked = aircraftAirOps.QuickTurnaround_Enabled;
					this.vmethod_2().Enabled = aircraftAirOps.QuickTurnaround_Enabled;
					this.method_3(new int?(aircraftAirOps.QuickTurnaround_SortiesTotal), ref this.aircraft_0);
				}
			}
			this.bool_0 = true;
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x000268F1 File Offset: 0x00024AF1
		private void method_1(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.method_3(new int?(this.int_0), ref this.aircraft_0);
			}
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x0021F748 File Offset: 0x0021D948
		private void method_2(object sender, EventArgs e)
		{
			this.vmethod_4().Text = CommandFactory.GetCommandMain().GetAirOps().method_44();
			if (this.bool_0)
			{
				Aircraft_AirOps aircraftAirOps = this.aircraft_0.GetAircraftAirOps();
				if (this.vmethod_2().SelectedIndex + 2 <= this.aircraft_0.GetLoadout().QT_MaxSorties)
				{
					aircraftAirOps.QuickTurnaround_SortiesTotal = this.vmethod_2().SelectedIndex + 2;
				}
			}
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x0021F7BC File Offset: 0x0021D9BC
		private void method_3(int? nullable_0, ref Aircraft aircraft_1)
		{
			Aircraft_AirOps aircraftAirOps = aircraft_1.GetAircraftAirOps();
			if (aircraftAirOps.QuickTurnaround_SortiesFlown <= 0)
			{
				aircraftAirOps.QuickTurnaround_SortiesFlown = 1;
			}
			if (this.vmethod_0().Checked)
			{
				this.vmethod_2().Enabled = true;
				this.method_4(nullable_0);
				this.vmethod_4().Enabled = true;
				this.vmethod_4().Text = CommandFactory.GetCommandMain().GetAirOps().method_44();
				if (this.bool_0)
				{
					aircraftAirOps.QuickTurnaround_Enabled = true;
				}
			}
			else
			{
				this.vmethod_2().Enabled = false;
				this.method_4(nullable_0);
				this.vmethod_4().Enabled = false;
				this.vmethod_4().Text = "";
				if (this.bool_0)
				{
					aircraftAirOps.QuickTurnaround_Enabled = false;
				}
			}
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x0021F884 File Offset: 0x0021DA84
		private void method_4(int? nullable_0)
		{
			this.vmethod_2().Items.Clear();
			this.vmethod_2().SelectedIndex = -1;
			if (this.vmethod_0().Checked)
			{
				int num = this.int_0;
				for (int i = 2; i <= num; i++)
				{
					if (i == this.int_0)
					{
						this.vmethod_2().Items.Add(Conversions.ToString(i) + "波次(最大)");
					}
					else
					{
						this.vmethod_2().Items.Add(Conversions.ToString(i) + "波次");
					}
				}
				Aircraft_AirOps aircraftAirOps = this.aircraft_0.GetAircraftAirOps();
				if (this.bool_0)
				{
					this.vmethod_2().SelectedIndex = this.int_0 - 2;
				}
				else
				{
					this.vmethod_2().SelectedIndex = aircraftAirOps.QuickTurnaround_SortiesTotal - 2;
				}
				if (this.vmethod_2().SelectedIndex + 2 <= this.aircraft_0.GetLoadout().QT_MaxSorties)
				{
					aircraftAirOps.QuickTurnaround_SortiesTotal = this.vmethod_2().SelectedIndex + 2;
				}
			}
			this.vmethod_4().Text = CommandFactory.GetCommandMain().GetAirOps().method_44();
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void Form_QuickTurnaround_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x040026EB RID: 9963
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x040026EC RID: 9964
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x040026ED RID: 9965
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x040026EE RID: 9966
		private Aircraft aircraft_0;

		// Token: 0x040026EF RID: 9967
		private int int_0;

		// Token: 0x040026F0 RID: 9968
		private bool bool_0;
	}
}

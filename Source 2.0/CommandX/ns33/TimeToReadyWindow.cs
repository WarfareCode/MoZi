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
using ns32;

namespace ns33
{
	// Token: 0x020009BF RID: 2495
	[DesignerGenerated]
	public sealed partial class TimeToReadyWindow : CommandForm
	{
		// Token: 0x060042C0 RID: 17088 RVA: 0x00185D24 File Offset: 0x00183F24
		public TimeToReadyWindow()
		{
			base.Shown += new EventHandler(this.TimeToReadyWindow_Shown);
			base.KeyDown += new KeyEventHandler(this.TimeToReadyWindow_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.TimeToReadyWindow_FormClosing);
			base.Load += new EventHandler(this.TimeToReadyWindow_Load);
			this.list_0 = new List<ActiveUnit>();
			this.InitializeComponent();
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x00185FD8 File Offset: 0x001841D8
		[CompilerGenerated]
		internal  MaskedTextBox vmethod_0()
		{
			return this.maskedTextBox_0;
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x0002193B File Offset: 0x0001FB3B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(MaskedTextBox maskedTextBox_1)
		{
			this.maskedTextBox_0 = maskedTextBox_1;
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x00185FF0 File Offset: 0x001841F0
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x00021944 File Offset: 0x0001FB44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x00186008 File Offset: 0x00184208
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_0;
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x00186020 File Offset: 0x00184220
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_1)
		{
			EventHandler value = new EventHandler(this.method_1);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_1;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x0002194D File Offset: 0x0001FB4D
		private void TimeToReadyWindow_Shown(object sender, EventArgs e)
		{
			if (this.list_0.Count == 0)
			{
				base.Close();
			}
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x0018606C File Offset: 0x0018426C
		private void method_1(object sender, EventArgs e)
		{
			List<string> list = this.vmethod_0().Text.Split(new char[]
			{
				':'
			}).ToList<string>();
			if (Versioned.IsNumeric(list[0]) & Versioned.IsNumeric(list[1]) & Versioned.IsNumeric(list[2]))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(list[0]), Conversions.ToInteger(list[1]), Conversions.ToInteger(list[2]), 0);
				List<ActiveUnit>.Enumerator enumerator = this.list_0.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						if (current.IsAircraft)
						{
							((Aircraft_AirOps)current.GetAirOps()).SetConditionTimer((float)timeSpan.TotalSeconds);
							if (((Aircraft_AirOps)current.GetAirOps()).GetConditionTimer() > 0f)
							{
								if (((Aircraft_AirOps)current.GetAirOps()).GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Parked)
								{
									((Aircraft_AirOps)current.GetAirOps()).SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Readying);
								}
							}
							else if (((Aircraft_AirOps)current.GetAirOps()).GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Readying)
							{
								((Aircraft_AirOps)current.GetAirOps()).SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Parked);
							}
						}
						else
						{
							current.GetDockingOps().CT = timeSpan.TotalSeconds;
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				if (!Information.IsNothing(CommandFactory.GetCommandMain().GetAirOps()) && CommandFactory.GetCommandMain().GetAirOps().Visible)
				{
					CommandFactory.GetCommandMain().GetAirOps().method_10();
				}
				if (!Information.IsNothing(CommandFactory.GetCommandMain().GetDockingOps()) && CommandFactory.GetCommandMain().GetDockingOps().Visible)
				{
					CommandFactory.GetCommandMain().GetDockingOps().method_5();
				}
				base.Close();
			}
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void TimeToReadyWindow_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x060042CC RID: 17100 RVA: 0x00004D83 File Offset: 0x00002F83
		private void TimeToReadyWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void TimeToReadyWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001F2F RID: 7983
		[CompilerGenerated]
		private MaskedTextBox maskedTextBox_0;

		// Token: 0x04001F30 RID: 7984
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001F31 RID: 7985
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001F32 RID: 7986
		public List<ActiveUnit> list_0;
	}
}

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;
using ns4;

namespace ns34
{
	// Token: 0x020009F5 RID: 2549
	[DesignerGenerated]
	public sealed partial class RecorderForm : CommandForm
	{
		// Token: 0x06004C56 RID: 19542 RVA: 0x001E3FB4 File Offset: 0x001E21B4
		public RecorderForm()
		{
			base.Load += new EventHandler(this.RecorderForm_Load);
			base.KeyDown += new KeyEventHandler(this.RecorderForm_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.RecorderForm_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x001E4820 File Offset: 0x001E2A20
		[CompilerGenerated]
		internal  TrackBar GetTB_Snapshots()
		{
			return this.TrackBar_Snapshots;
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x001E4838 File Offset: 0x001E2A38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetTB_Snapshots(TrackBar trackBar_1)
		{
			MouseEventHandler value = new MouseEventHandler(this.TrackBar_Snapshots_MouseMove);
			MouseEventHandler value2 = new MouseEventHandler(this.TrackBar_Snapshots_MouseUp);
			TrackBar trackBar_Snapshots = this.TrackBar_Snapshots;
			if (trackBar_Snapshots != null)
			{
				trackBar_Snapshots.MouseMove -= value;
				trackBar_Snapshots.MouseUp -= value2;
			}
			this.TrackBar_Snapshots = trackBar_1;
			trackBar_Snapshots = this.TrackBar_Snapshots;
			if (trackBar_Snapshots != null)
			{
				trackBar_Snapshots.MouseMove += value;
				trackBar_Snapshots.MouseUp += value2;
			}
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x001E489C File Offset: 0x001E2A9C
		[CompilerGenerated]
		internal  ToolStrip vmethod_2()
		{
			return this.toolStrip_0;
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x000246E3 File Offset: 0x000228E3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x001E48B4 File Offset: 0x001E2AB4
		[CompilerGenerated]
		internal  ToolStripButton vmethod_4()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x001E48CC File Offset: 0x001E2ACC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_3);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_7;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x001E4918 File Offset: 0x001E2B18
		[CompilerGenerated]
		internal  ToolStripSeparator vmethod_6()
		{
			return this.toolStripSeparator_0;
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x000246EC File Offset: 0x000228EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripSeparator toolStripSeparator_1)
		{
			this.toolStripSeparator_0 = toolStripSeparator_1;
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x001E4930 File Offset: 0x001E2B30
		[CompilerGenerated]
		internal  ToolStripButton vmethod_8()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x001E4948 File Offset: 0x001E2B48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_7);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_7;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x001E4994 File Offset: 0x001E2B94
		[CompilerGenerated]
		internal  ToolStripButton vmethod_10()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x001E49AC File Offset: 0x001E2BAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_10);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_7;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x001E49F8 File Offset: 0x001E2BF8
		[CompilerGenerated]
		internal  ToolStripButton vmethod_12()
		{
			return this.toolStripButton_3;
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x001E4A10 File Offset: 0x001E2C10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_6);
			ToolStripButton toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.CheckedChanged -= value;
			}
			this.toolStripButton_3 = toolStripButton_7;
			toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.CheckedChanged += value;
			}
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x001E4A5C File Offset: 0x001E2C5C
		[CompilerGenerated]
		internal  ToolStripButton vmethod_14()
		{
			return this.toolStripButton_4;
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x001E4A74 File Offset: 0x001E2C74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_11);
			ToolStripButton toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_4 = toolStripButton_7;
			toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x001E4AC0 File Offset: 0x001E2CC0
		[CompilerGenerated]
		internal  ToolStripButton vmethod_16()
		{
			return this.toolStripButton_5;
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x001E4AD8 File Offset: 0x001E2CD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_8);
			ToolStripButton toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_5 = toolStripButton_7;
			toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x001E4B24 File Offset: 0x001E2D24
		[CompilerGenerated]
		internal  ToolStripButton vmethod_18()
		{
			return this.toolStripButton_6;
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x001E4B3C File Offset: 0x001E2D3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(ToolStripButton toolStripButton_7)
		{
			EventHandler value = new EventHandler(this.method_4);
			ToolStripButton toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_6 = toolStripButton_7;
			toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x001E4B88 File Offset: 0x001E2D88
		[CompilerGenerated]
		internal  OpenFileDialog vmethod_20()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x000246F5 File Offset: 0x000228F5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x001E4BA0 File Offset: 0x001E2DA0
		[CompilerGenerated]
		internal  Timer vmethod_22()
		{
			return this.timer_0;
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x001E4BB8 File Offset: 0x001E2DB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Timer timer_2)
		{
			EventHandler value = new EventHandler(this.method_15);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_0 = timer_2;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x001E4C04 File Offset: 0x001E2E04
		[CompilerGenerated]
		internal  StatusStrip vmethod_24()
		{
			return this.statusStrip_0;
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x000246FE File Offset: 0x000228FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(StatusStrip statusStrip_1)
		{
			this.statusStrip_0 = statusStrip_1;
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x001E4C1C File Offset: 0x001E2E1C
		[CompilerGenerated]
		internal  ToolStripStatusLabel vmethod_26()
		{
			return this.toolStripStatusLabel_0;
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x00024707 File Offset: 0x00022907
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(ToolStripStatusLabel toolStripStatusLabel_2)
		{
			this.toolStripStatusLabel_0 = toolStripStatusLabel_2;
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x001E4C34 File Offset: 0x001E2E34
		[CompilerGenerated]
		internal  Timer vmethod_28()
		{
			return this.timer_1;
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x001E4C4C File Offset: 0x001E2E4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Timer timer_2)
		{
			EventHandler value = new EventHandler(this.method_19);
			Timer timer = this.timer_1;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_1 = timer_2;
			timer = this.timer_1;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x001E4C98 File Offset: 0x001E2E98
		[CompilerGenerated]
		internal  ToolStripStatusLabel vmethod_30()
		{
			return this.toolStripStatusLabel_1;
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x00024710 File Offset: 0x00022910
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(ToolStripStatusLabel toolStripStatusLabel_2)
		{
			this.toolStripStatusLabel_1 = toolStripStatusLabel_2;
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x001E4CB0 File Offset: 0x001E2EB0
		[CompilerGenerated]
		internal  BackgroundWorker vmethod_32()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x001E4CC8 File Offset: 0x001E2EC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler value = new DoWorkEventHandler(this.method_16);
			RunWorkerCompletedEventHandler value2 = new RunWorkerCompletedEventHandler(this.method_18);
			BackgroundWorker backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value;
				backgroundWorker.RunWorkerCompleted -= value2;
			}
			this.backgroundWorker_0 = backgroundWorker_1;
			backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value;
				backgroundWorker.RunWorkerCompleted += value2;
			}
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x001E4D2C File Offset: 0x001E2F2C
		private int method_1()
		{
			return this.int_0;
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x001E4D44 File Offset: 0x001E2F44
		private void method_2(int int_1)
		{
			this.int_0 = int_1;
			this.side_0 = Client.GetClientScenario().GetCurrentSide();
			while (this.vmethod_32().IsBusy)
			{
				Application.DoEvents();
			}
			this.vmethod_32().RunWorkerAsync();
			this.double_0 = 0.0;
			this.vmethod_26().Visible = true;
		}

		// Token: 0x06004C7D RID: 19581 RVA: 0x001E4DA4 File Offset: 0x001E2FA4
		private void method_3(object sender, EventArgs e)
		{
			this.vmethod_20().InitialDirectory = Application.StartupPath + "\\Recordings\\";
			if (this.vmethod_20().ShowDialog() == DialogResult.OK)
			{
				string fileName = this.vmethod_20().FileName;
				this.method_5(fileName);
			}
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x001E4DF4 File Offset: 0x001E2FF4
		private void method_4(object sender, EventArgs e)
		{
			string text = Recorder.smethod_1();
			if (string.IsNullOrEmpty(text))
			{
				Interaction.MsgBox("No VCR files can be found.", MsgBoxStyle.OkOnly, "No files present!");
			}
			else
			{
				this.method_5(text);
			}
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x001E4E2C File Offset: 0x001E302C
		private void method_5(string string_1)
		{
			this.scenarioSnapshots = Recorder.LoadScenarioSnapshots(string_1);
			if (this.scenarioSnapshots.Snapshots.Count == 0)
			{
				Interaction.MsgBox("This recording does not have any saved snapshots! Please load another recording.", MsgBoxStyle.OkOnly, null);
				this.scenarioSnapshots = null;
			}
			else
			{
				this.GetTB_Snapshots().Maximum = this.scenarioSnapshots.Snapshots.Count - 1;
				this.GetTB_Snapshots().Value = 0;
				this.string_0 = "TapeLoad";
				this.method_2(this.scenarioSnapshots.Snapshots[0].Item1);
				this.vmethod_16().Enabled = true;
				this.vmethod_8().Enabled = true;
				this.vmethod_12().Enabled = true;
				this.vmethod_10().Enabled = true;
				this.vmethod_14().Enabled = true;
				this.GetTB_Snapshots().Enabled = true;
			}
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x001E4F10 File Offset: 0x001E3110
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_12().Checked)
			{
				this.vmethod_12().Checked = true;
				this.vmethod_12().Image = Image.FromFile(Application.StartupPath + "\\Symbols\\Menu\\Pause.gif");
				this.vmethod_22().Start();
			}
			else
			{
				if (this.vmethod_32().IsBusy)
				{
					this.vmethod_32().CancelAsync();
				}
				this.vmethod_12().Checked = false;
				this.vmethod_12().Image = Image.FromFile(Application.StartupPath + "\\Symbols\\Menu\\Run.gif");
				this.vmethod_22().Stop();
			}
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x001E4FB8 File Offset: 0x001E31B8
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_32().IsBusy)
			{
				this.vmethod_32().CancelAsync();
			}
			this.string_0 = "TapeStep";
			this.method_2(this.scenarioSnapshots.Snapshots[0].Item1);
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x001E5008 File Offset: 0x001E3208
		private void method_8(object sender, EventArgs e)
		{
			if (this.vmethod_32().IsBusy)
			{
				this.vmethod_32().CancelAsync();
			}
			this.string_0 = "TapeStep";
			this.method_2(this.scenarioSnapshots.Snapshots[this.scenarioSnapshots.Snapshots.Count - 1].Item1);
		}

		// Token: 0x06004C83 RID: 19587 RVA: 0x001E5068 File Offset: 0x001E3268
		private void TrackBar_Snapshots_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.vmethod_12().Checked = false;
				this.Text = string.Concat(new string[]
				{
					"想定时间: ",
					this.scenarioSnapshots.Snapshots[this.GetTB_Snapshots().Value].Item2.ToShortDateString(),
					" ",
					this.scenarioSnapshots.Snapshots[this.GetTB_Snapshots().Value].Item2.ToShortTimeString(),
					" GMT - 松开鼠标按钮进行加载!"
				});
			}
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x00024719 File Offset: 0x00022919
		private void method_10(object sender, EventArgs e)
		{
			this.method_13();
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x00024721 File Offset: 0x00022921
		private void method_11(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x001E5118 File Offset: 0x001E3318
		private void method_12()
		{
			if (this.GetTB_Snapshots().Value != this.GetTB_Snapshots().Maximum - 1)
			{
				if (this.vmethod_32().IsBusy)
				{
					this.vmethod_32().CancelAsync();
				}
				this.GetTB_Snapshots().Value = Math.Min(this.GetTB_Snapshots().Maximum, this.GetTB_Snapshots().Value + 1);
				this.string_0 = "TapeStep";
				this.method_2(this.scenarioSnapshots.Snapshots[this.GetTB_Snapshots().Value].Item1);
			}
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x001E51B8 File Offset: 0x001E33B8
		private void method_13()
		{
			if (this.GetTB_Snapshots().Value != 0)
			{
				if (this.vmethod_32().IsBusy)
				{
					this.vmethod_32().CancelAsync();
				}
				this.GetTB_Snapshots().Value = Math.Max(this.GetTB_Snapshots().Minimum, this.GetTB_Snapshots().Value - 1);
				this.string_0 = "TapeStep";
				this.method_2(this.scenarioSnapshots.Snapshots[this.GetTB_Snapshots().Value].Item1);
			}
		}

		// Token: 0x06004C88 RID: 19592 RVA: 0x00024729 File Offset: 0x00022929
		private void TrackBar_Snapshots_MouseUp(object sender, MouseEventArgs e)
		{
			this.Text = "复盘推演播放器";
			this.method_2(this.scenarioSnapshots.Snapshots[this.GetTB_Snapshots().Value].Item1);
		}

		// Token: 0x06004C89 RID: 19593 RVA: 0x001E524C File Offset: 0x001E344C
		private void RecorderForm_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_33(new BackgroundWorker());
			this.vmethod_32().WorkerSupportsCancellation = true;
			this.vmethod_28().Start();
			this.vmethod_16().Enabled = false;
			this.vmethod_8().Enabled = false;
			this.vmethod_12().Enabled = false;
			this.vmethod_10().Enabled = false;
			this.vmethod_14().Enabled = false;
			this.GetTB_Snapshots().Enabled = false;
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x001E52DC File Offset: 0x001E34DC
		private void method_15(object sender, EventArgs e)
		{
			if (!Client.bool_3 && this.GetTB_Snapshots().Value != this.GetTB_Snapshots().Maximum)
			{
				this.GetTB_Snapshots().Value = this.GetTB_Snapshots().Value + 1;
				this.string_0 = "TapeStep";
				this.method_2(this.scenarioSnapshots.Snapshots[this.GetTB_Snapshots().Value].Item1);
			}
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x001E5358 File Offset: 0x001E3558
		private void method_16(object sender, DoWorkEventArgs e)
		{
			Client.bool_3 = true;
			try
			{
				try
				{
					new MemoryFailPoint(100).Dispose();
				}
				catch (InsufficientMemoryException ex)
				{
					ProjectData.SetProjectError(ex);
					InsufficientMemoryException ex2 = ex;
					GameGeneral.ForceGarbageCollection();
					ex2.Data.Add("Error at 200394", ex2.Message);
					Exception ex3 = ex2;
					GameGeneral.LogException(ref ex3);
					ex2 = (InsufficientMemoryException)ex3;
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				this.scenario = this.scenarioSnapshots.LoadScenaroFromSnapshots(this.method_1(), ref this.double_0);
				this.bool_0 = false;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				this.bool_0 = true;
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x0002475C File Offset: 0x0002295C
		private void method_17()
		{
			if (this.vmethod_12().Checked | this.vmethod_14().Checked)
			{
				this.method_12();
			}
			if (this.vmethod_10().Checked)
			{
				this.method_13();
			}
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x001E541C File Offset: 0x001E361C
		private void method_18(object sender, RunWorkerCompletedEventArgs e)
		{
			if (this.bool_0)
			{
				this.vmethod_30().Visible = true;
				this.method_17();
			}
			else
			{
				this.vmethod_30().Visible = false;
				checked
				{
					if (!Information.IsNothing(this.side_0))
					{
						Side[] sides = this.scenario.GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							Side side = sides[i];
							if (Operators.CompareString(side.GetGuid(), this.side_0.GetGuid(), false) == 0)
							{
								this.scenario.ChangeSide(side);
								break;
							}
						}
					}
					this.vmethod_26().Visible = false;
					Client.SetClientScenario(this.scenario, true);
					Client.bool_3 = false;
				}
				if (Operators.CompareString(this.string_0, "TapeLoad", false) == 0)
				{
					CommandFactory.GetCommandMain().GetMainForm().method_14(true, Client.GetClientScenario().GetCurrentSide().GetMapCenter());
					CommandFactory.GetCommandMain().GetMainForm().method_6((int)Math.Round(Client.GetClientScenario().GetCurrentSide().CameraAlt));
				}
			}
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x00024796 File Offset: 0x00022996
		private void method_19(object sender, EventArgs e)
		{
			this.vmethod_26().Text = "加载帧..." + Conversions.ToString((int)Math.Round(this.double_0 * 100.0)) + "%";
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x000200A8 File Offset: 0x0001E2A8
		private void RecorderForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x00004D83 File Offset: 0x00002F83
		private void RecorderForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x04002404 RID: 9220
		[CompilerGenerated]
		private TrackBar TrackBar_Snapshots;

		// Token: 0x04002405 RID: 9221
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x04002406 RID: 9222
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04002407 RID: 9223
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x04002408 RID: 9224
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04002409 RID: 9225
		[CompilerGenerated]
		private ToolStripButton toolStripButton_2;

		// Token: 0x0400240A RID: 9226
		[CompilerGenerated]
		private ToolStripButton toolStripButton_3;

		// Token: 0x0400240B RID: 9227
		[CompilerGenerated]
		private ToolStripButton toolStripButton_4;

		// Token: 0x0400240C RID: 9228
		[CompilerGenerated]
		private ToolStripButton toolStripButton_5;

		// Token: 0x0400240D RID: 9229
		[CompilerGenerated]
		private ToolStripButton toolStripButton_6;

		// Token: 0x0400240E RID: 9230
		[CompilerGenerated]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x0400240F RID: 9231
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x04002410 RID: 9232
		[CompilerGenerated]
		private StatusStrip statusStrip_0;

		// Token: 0x04002411 RID: 9233
		[CompilerGenerated]
		private ToolStripStatusLabel toolStripStatusLabel_0;

		// Token: 0x04002412 RID: 9234
		[CompilerGenerated]
		private Timer timer_1;

		// Token: 0x04002413 RID: 9235
		[CompilerGenerated]
		private ToolStripStatusLabel toolStripStatusLabel_1;

		// Token: 0x04002414 RID: 9236
		private ScenarioSnapshots scenarioSnapshots;

		// Token: 0x04002415 RID: 9237
		private int int_0;

		// Token: 0x04002416 RID: 9238
		private Side side_0;

		// Token: 0x04002417 RID: 9239
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04002418 RID: 9240
		private double double_0;

		// Token: 0x04002419 RID: 9241
		private Scenario scenario;

		// Token: 0x0400241A RID: 9242
		private bool bool_0;

		// Token: 0x0400241B RID: 9243
		private string string_0;
	}
}

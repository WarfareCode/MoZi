using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.DirectX.AudioVideoPlayback;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns35;

namespace ns34
{
	// Token: 0x02000CF4 RID: 3316
	[DesignerGenerated]
	public sealed partial class VideoWindow : Form
	{
		// Token: 0x060072EB RID: 29419 RVA: 0x004186A4 File Offset: 0x004168A4
		public VideoWindow()
		{
			base.KeyDown += new KeyEventHandler(this.VideoWindow_KeyDown);
			base.VisibleChanged += new EventHandler(this.VideoWindow_VisibleChanged);
			base.Load += new EventHandler(this.VideoWindow_Load);
			this.InitializeComponent();
		}

		// Token: 0x060072EE RID: 29422 RVA: 0x004187C0 File Offset: 0x004169C0
		[CompilerGenerated]
		internal  Video vmethod_0()
		{
			return this.video_0;
		}

		// Token: 0x060072EF RID: 29423 RVA: 0x004187D8 File Offset: 0x004169D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Video video_1)
		{
			EventHandler eh = new EventHandler(this.method_0);
			EventHandler eh2 = new EventHandler(this.method_2);
			Video video = this.video_0;
			if (video != null)
			{
				video.Ending -= eh;
				video.Stopping -= eh2;
			}
			this.video_0 = video_1;
			video = this.video_0;
			if (video != null)
			{
				video.Ending += eh;
				video.Stopping += eh2;
			}
		}

		// Token: 0x060072F0 RID: 29424 RVA: 0x000301FB File Offset: 0x0002E3FB
		private void method_0(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x060072F1 RID: 29425 RVA: 0x0041883C File Offset: 0x00416A3C
		public void method_1()
		{
			if (!Information.IsNothing(Class2531.class2530_0.vmethod_0()))
			{
				Class2531.class2530_0.vmethod_0().Volume = this.double_0;
			}
			Cursor.Show();
			if (this.bool_1)
			{
				Client.GetConfiguration().SetSimRunMode();
			}
			this.bool_0 = false;
			base.DialogResult = DialogResult.OK;
			base.Hide();
		}

		// Token: 0x060072F2 RID: 29426 RVA: 0x00030203 File Offset: 0x0002E403
		private void VideoWindow_KeyDown(object sender, KeyEventArgs e)
		{
			this.vmethod_0().Stop();
		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x004188A0 File Offset: 0x00416AA0
		private void VideoWindow_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				string item = this.tuple_0.Item1;
				bool item2 = this.tuple_0.Item2;
				int item3 = this.tuple_0.Item3;
				this.bool_0 = true;
				try
				{
					if (item3 > 0)
					{
						base.Opacity = 0.0;
						Thread.Sleep(item3 * 1000);
						base.Opacity = 1.0;
					}
					this.vmethod_1(new Video(item));
					this.vmethod_0().Owner = this;
					this.bool_1 = (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Run);
					if (this.bool_1)
					{
						Client.GetConfiguration().SetSimStopMode();
					}
					if (item2)
					{
						base.WindowState = FormWindowState.Maximized;
						Cursor.Hide();
					}
					else
					{
						base.StartPosition = FormStartPosition.CenterScreen;
					}
					if (!Information.IsNothing(Class2531.class2530_0.vmethod_0()))
					{
						this.double_0 = Class2531.class2530_0.vmethod_0().Volume;
						Class2531.class2530_0.vmethod_0().Volume = 0.0;
					}
					this.vmethod_0().Play();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200415", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					this.bool_0 = false;
					base.Hide();
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060072F4 RID: 29428 RVA: 0x000301FB File Offset: 0x0002E3FB
		private void method_2(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x060072F5 RID: 29429 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void VideoWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04004159 RID: 16729
		public Tuple<string, bool, int> tuple_0;

		// Token: 0x0400415A RID: 16730
		public bool bool_0;

		// Token: 0x0400415B RID: 16731
		[CompilerGenerated]
		private Video video_0;

		// Token: 0x0400415C RID: 16732
		private double double_0;

		// Token: 0x0400415D RID: 16733
		private bool bool_1;
	}
}

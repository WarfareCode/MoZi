using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns15;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x02000A02 RID: 2562
	[DesignerGenerated]
	public sealed partial class EditWeather : CommandForm
	{
		// 气象设置对话框
		public EditWeather()
		{
			base.Load += new EventHandler(this.EditWeather_Load);
			base.KeyDown += new KeyEventHandler(this.EditWeather_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.EditWeather_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x001F2C80 File Offset: 0x001F0E80
		[CompilerGenerated]
		internal  ToolStrip vmethod_0()
		{
			return this.toolStrip_0;
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x00024B7F File Offset: 0x00022D7F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x001F2C98 File Offset: 0x001F0E98
		[CompilerGenerated]
		internal  ToolStripLabel vmethod_2()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x00024B88 File Offset: 0x00022D88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStripLabel toolStripLabel_1)
		{
			this.toolStripLabel_0 = toolStripLabel_1;
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x001F2CB0 File Offset: 0x001F0EB0
		[CompilerGenerated]
		internal  ToolStripDropDownButton vmethod_4()
		{
			return this.toolStripDropDownButton_0;
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x00024B91 File Offset: 0x00022D91
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripDropDownButton toolStripDropDownButton_1)
		{
			this.toolStripDropDownButton_0 = toolStripDropDownButton_1;
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x001F2CC8 File Offset: 0x001F0EC8
		[CompilerGenerated]
		internal  Control1 vmethod_6()
		{
			return this.control1_0;
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x00024B9A File Offset: 0x00022D9A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Control1 control1_1)
		{
			this.control1_0 = control1_1;
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x001F2CE0 File Offset: 0x001F0EE0
		[CompilerGenerated]
		internal  TabPage vmethod_8()
		{
			return this.tabPage_0;
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x00024BA3 File Offset: 0x00022DA3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TabPage tabPage_1)
		{
			this.tabPage_0 = tabPage_1;
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x001F2CF8 File Offset: 0x001F0EF8
		[CompilerGenerated]
		internal  Label vmethod_10()
		{
			return this.label_0;
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x00024BAC File Offset: 0x00022DAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_11)
		{
			this.label_0 = label_11;
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x001F2D10 File Offset: 0x001F0F10
		[CompilerGenerated]
		internal  Label vmethod_12()
		{
			return this.label_1;
		}

		// Token: 0x06004D9F RID: 19871 RVA: 0x00024BB5 File Offset: 0x00022DB5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Label label_11)
		{
			this.label_1 = label_11;
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x001F2D28 File Offset: 0x001F0F28
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_2;
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x00024BBE File Offset: 0x00022DBE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_11)
		{
			this.label_2 = label_11;
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x001F2D40 File Offset: 0x001F0F40
		[CompilerGenerated]
		internal  Label vmethod_16()
		{
			return this.label_3;
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x00024BC7 File Offset: 0x00022DC7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_11)
		{
			this.label_3 = label_11;
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x001F2D58 File Offset: 0x001F0F58
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_4;
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x00024BD0 File Offset: 0x00022DD0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_11)
		{
			this.label_4 = label_11;
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x001F2D70 File Offset: 0x001F0F70
		[CompilerGenerated]
		internal  Label vmethod_20()
		{
			return this.label_5;
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x00024BD9 File Offset: 0x00022DD9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Label label_11)
		{
			this.label_5 = label_11;
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x001F2D88 File Offset: 0x001F0F88
		[CompilerGenerated]
		internal  Label vmethod_22()
		{
			return this.label_6;
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x00024BE2 File Offset: 0x00022DE2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Label label_11)
		{
			this.label_6 = label_11;
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x001F2DA0 File Offset: 0x001F0FA0
		[CompilerGenerated]
		internal  TrackBar vmethod_24()
		{
			return this.trackBar_0;
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x001F2DB8 File Offset: 0x001F0FB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(TrackBar trackBar_4)
		{
			EventHandler value = new EventHandler(this.method_2);
			TrackBar trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.Scroll -= value;
			}
			this.trackBar_0 = trackBar_4;
			trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.Scroll += value;
			}
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x001F2E04 File Offset: 0x001F1004
		[CompilerGenerated]
		internal  TrackBar GetTrackBar_FUR()
		{
			return this.TrackBar_FUR;
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x001F2E1C File Offset: 0x001F101C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetTrackBar_FUR(TrackBar trackBar_4)
		{
			EventHandler value = new EventHandler(this.TrackBar_FUR_Scroll);
			TrackBar trackBar_FUR = this.TrackBar_FUR;
			if (trackBar_FUR != null)
			{
				trackBar_FUR.Scroll -= value;
			}
			this.TrackBar_FUR = trackBar_4;
			trackBar_FUR = this.TrackBar_FUR;
			if (trackBar_FUR != null)
			{
				trackBar_FUR.Scroll += value;
			}
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x001F2E68 File Offset: 0x001F1068
		[CompilerGenerated]
		internal  Label vmethod_28()
		{
			return this.label_7;
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x00024BEB File Offset: 0x00022DEB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Label label_11)
		{
			this.label_7 = label_11;
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x001F2E80 File Offset: 0x001F1080
		[CompilerGenerated]
		internal  TrackBar vmethod_30()
		{
			return this.trackBar_2;
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x001F2E98 File Offset: 0x001F1098
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(TrackBar trackBar_4)
		{
			EventHandler value = new EventHandler(this.method_1);
			TrackBar trackBar = this.trackBar_2;
			if (trackBar != null)
			{
				trackBar.Scroll -= value;
			}
			this.trackBar_2 = trackBar_4;
			trackBar = this.trackBar_2;
			if (trackBar != null)
			{
				trackBar.Scroll += value;
			}
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x001F2EE4 File Offset: 0x001F10E4
		[CompilerGenerated]
		internal  Label vmethod_32()
		{
			return this.label_8;
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x00024BF4 File Offset: 0x00022DF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Label label_11)
		{
			this.label_8 = label_11;
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x001F2EFC File Offset: 0x001F10FC
		[CompilerGenerated]
		internal  Label vmethod_34()
		{
			return this.label_9;
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x00024BFD File Offset: 0x00022DFD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Label label_11)
		{
			this.label_9 = label_11;
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x001F2F14 File Offset: 0x001F1114
		[CompilerGenerated]
		internal  TrackBar vmethod_36()
		{
			return this.trackBar_3;
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x001F2F2C File Offset: 0x001F112C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(TrackBar trackBar_4)
		{
			EventHandler value = new EventHandler(this.method_4);
			TrackBar trackBar = this.trackBar_3;
			if (trackBar != null)
			{
				trackBar.Scroll -= value;
			}
			this.trackBar_3 = trackBar_4;
			trackBar = this.trackBar_3;
			if (trackBar != null)
			{
				trackBar.Scroll += value;
			}
		}

		// Token: 0x06004DB8 RID: 19896 RVA: 0x001F2F78 File Offset: 0x001F1178
		[CompilerGenerated]
		internal  Label vmethod_38()
		{
			return this.label_10;
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x00024C06 File Offset: 0x00022E06
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Label label_11)
		{
			this.label_10 = label_11;
		}

		// Token: 0x06004DBA RID: 19898 RVA: 0x001F2F90 File Offset: 0x001F1190
		private void EditWeather_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.weatherProfile_0 = Client.GetClientScenario().GetWeatherProfile();
			this.vmethod_30().Value = (int)Math.Round(this.weatherProfile_0.GetTemp());
			this.vmethod_28().Text = Conversions.ToString(this.weatherProfile_0.GetTemp()) + " °C";
			this.vmethod_24().Value = (int)Math.Round((double)this.weatherProfile_0.RainFallRate);
			this.GetTrackBar_FUR().Value = (int)Math.Round((double)(this.weatherProfile_0.GetFUR() * 10f));
			this.vmethod_36().Value = this.weatherProfile_0.SeaState;   // 海况
		}

		// Token: 0x06004DBB RID: 19899 RVA: 0x001F305C File Offset: 0x001F125C
		private void method_1(object sender, EventArgs e)
		{
			Client.GetClientScenario().GetWeatherProfile().SetTemp((double)this.vmethod_30().Value);
			this.vmethod_28().Text = Conversions.ToString(Client.GetClientScenario().GetWeatherProfile().GetTemp()) + " °C";
		}

		// Token: 0x06004DBC RID: 19900 RVA: 0x00024C0F File Offset: 0x00022E0F
		private void method_2(object sender, EventArgs e)
		{
			Client.GetClientScenario().GetWeatherProfile().RainFallRate = (float)this.vmethod_24().Value;
		}

		// Token: 0x06004DBD RID: 19901 RVA: 0x00024C2C File Offset: 0x00022E2C
		private void TrackBar_FUR_Scroll(object sender, EventArgs e)
		{
			Client.GetClientScenario().GetWeatherProfile().SetFUR((float)((double)this.GetTrackBar_FUR().Value * 0.1));
		}

		// Token: 0x06004DBE RID: 19902 RVA: 0x00024C54 File Offset: 0x00022E54
		private void method_4(object sender, EventArgs e)
		{
			Client.GetClientScenario().GetWeatherProfile().SeaState = this.vmethod_36().Value;
		}

		// Token: 0x06004DBF RID: 19903 RVA: 0x001F30B0 File Offset: 0x001F12B0
		private void EditWeather_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (!base.Visible || (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right))
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06004DC0 RID: 19904 RVA: 0x00004D83 File Offset: 0x00002F83
		private void EditWeather_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x040024A4 RID: 9380
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x040024A5 RID: 9381
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x040024A6 RID: 9382
		[CompilerGenerated]
		private ToolStripDropDownButton toolStripDropDownButton_0;

		// Token: 0x040024A7 RID: 9383
		[CompilerGenerated]
		private Control1 control1_0;

		// Token: 0x040024A8 RID: 9384
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x040024A9 RID: 9385
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x040024AA RID: 9386
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x040024AB RID: 9387
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x040024AC RID: 9388
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x040024AD RID: 9389
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x040024AE RID: 9390
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x040024AF RID: 9391
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x040024B0 RID: 9392
		[CompilerGenerated]
		private TrackBar trackBar_0;

		// Token: 0x040024B1 RID: 9393
		[CompilerGenerated]
		private TrackBar TrackBar_FUR;

		// Token: 0x040024B2 RID: 9394
		[CompilerGenerated]
		private Label label_7;

		// Token: 0x040024B3 RID: 9395
		[CompilerGenerated]
		private TrackBar trackBar_2;

		// Token: 0x040024B4 RID: 9396
		[CompilerGenerated]
		private Label label_8;

		// Token: 0x040024B5 RID: 9397
		[CompilerGenerated]
		private Label label_9;

		// Token: 0x040024B6 RID: 9398
		[CompilerGenerated]
		private TrackBar trackBar_3;

		// Token: 0x040024B7 RID: 9399
		[CompilerGenerated]
		private Label label_10;

		// Token: 0x040024B8 RID: 9400
		private Weather.WeatherProfile weatherProfile_0;
	}
}

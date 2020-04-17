using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns34;
using ns4;

namespace ns35
{
	// Token: 0x02000CF6 RID: 3318
	[DesignerGenerated]
	public sealed partial class MainSplash : Form
	{
		// Token: 0x06007316 RID: 29462 RVA: 0x00030331 File Offset: 0x0002E531
		public MainSplash()
		{
			base.Shown += new EventHandler(this.MainSplash_Shown);
			base.Load += new EventHandler(this.MainSplash_Load);
			this.InitializeComponent();
		}

		// Token: 0x06007319 RID: 29465 RVA: 0x00419984 File Offset: 0x00417B84
		[CompilerGenerated]
		internal  PictureBox vmethod_0()
		{
			return this.pictureBox_0;
		}

		// Token: 0x0600731A RID: 29466 RVA: 0x00030363 File Offset: 0x0002E563
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(PictureBox pictureBox_1)
		{
			this.pictureBox_0 = pictureBox_1;
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x0041999C File Offset: 0x00417B9C
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x0600731C RID: 29468 RVA: 0x0003036C File Offset: 0x0002E56C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x0600731D RID: 29469 RVA: 0x004199B4 File Offset: 0x00417BB4
		private void MainSplash_Shown(object sender, EventArgs e)
		{
			if (SimConfiguration.gameOptions.LogDebugInfoToFile())
			{
				string text = "显示启动界面.";
				GameGeneral.Log(ref text);
			}
			Application.DoEvents();
			this.vmethod_2().Visible = false;
			if (!GameGeneral.bProfessionEdition && !LicenseChecker.HoldLicense(LicenseChecker.License.CMANOBase))
			{
				if (LicenseChecker.HoldLicense(LicenseChecker.License.NorthernInferno))
				{
					this.vmethod_0().Image = Image.FromFile(Path.Combine(CommandFactory.GetCommandApp().Info.DirectoryPath, "Symbols\\splash_NI.jpg"));
				}
			}
			else
			{
				this.vmethod_0().Image = Image.FromFile(Path.Combine(CommandFactory.GetCommandApp().Info.DirectoryPath, "Symbols\\splash.jpg"));
			}
			Application.DoEvents();
			if (!File.Exists(Path.Combine(CommandFactory.GetCommandApp().Info.DirectoryPath, "Pro.dat")))
			{
			}
			Application.DoEvents();
			Client.Initialize();
			Application.DoEvents();
			Client.IssueOrdersToUnit(Client._CommandOrder.None);
			if (SimConfiguration.gameOptions.LogDebugInfoToFile())
			{
				string text = "等待加载地形数据.";
				GameGeneral.Log(ref text);
			}
			while (!Terrain.bool_0)
			{
				Thread.Sleep(100);
			}
			if (SimConfiguration.gameOptions.LogDebugInfoToFile())
			{
				string text = "地形数据加载完成.";
				GameGeneral.Log(ref text);
			}
			Application.DoEvents();
		}

		// Token: 0x0600731E RID: 29470 RVA: 0x00419AEC File Offset: 0x00417CEC
		private void MainSplash_Load(object sender, EventArgs e)
		{
			if (Information.IsNothing(SimConfiguration.gameOptions))
			{
				SimConfiguration.LoadSimConfiguration();
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "仿真配置加载成功.";
					GameGeneral.Log(ref text);
				}
			}
			Client.float_0 = 1f;
			if (Client.float_0 == 0f)
			{
				int num = Conversions.ToInteger(CommandFactory.GetComputer().Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LogPixels", null));
				if (num > 0)
				{
					Client.float_0 = (float)((double)num / 96.0);
				}
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "DPI registry setting, HKEY_CURRENT_USER\\Control Panel\\Desktop\\LogPixels:" + Conversions.ToString(num) + ".";
					GameGeneral.Log(ref text);
				}
				if (Client.float_0 == 0f)
				{
					num = Conversions.ToInteger(CommandFactory.GetComputer().Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\FontDPI", "LogPixels", null));
					if (num > 0)
					{
						Client.float_0 = (float)((double)num / 96.0);
					}
					if (SimConfiguration.gameOptions.LogDebugInfoToFile())
					{
						string text = "DPI registry setting, HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\FontDPI\\LogPixels:" + Conversions.ToString(num) + ".";
						GameGeneral.Log(ref text);
					}
				}
				if (Client.float_0 == 0f)
				{
					num = Conversions.ToInteger(CommandFactory.GetComputer().Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows NT\\CurrentVersion\\FontDPI", "LogPixels", null));
					if (num > 0)
					{
						Client.float_0 = (float)((double)num / 96.0);
					}
					if (SimConfiguration.gameOptions.LogDebugInfoToFile())
					{
						string text = "DPI registry setting, HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows NT\\CurrentVersion\\FontDPI\\LogPixels:" + Conversions.ToString(num) + ".";
						GameGeneral.Log(ref text);
					}
				}
				if (Client.float_0 == 0f)
				{
					using (Graphics graphics = base.CreateGraphics())
					{
						Client.float_0 = graphics.DpiX / 96f;
					}
				}
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "DPI scale: " + Conversions.ToString(Client.float_0) + ".";
					GameGeneral.Log(ref text);
				}
			}
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x0400416D RID: 16749
		[CompilerGenerated]
		private PictureBox pictureBox_0;

		// Token: 0x0400416E RID: 16750
		[CompilerGenerated]
		private Label label_0;
	}
}

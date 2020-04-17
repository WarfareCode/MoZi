using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns32;
using ns33;
using ns35;
using ns4;

namespace ns34
{
	// Token: 0x02000A1D RID: 2589
	[DesignerGenerated]
	public sealed partial class StartGame : CommandForm
	{
		// Token: 0x06005092 RID: 20626 RVA: 0x0020C4DC File Offset: 0x0020A6DC
		public StartGame()
		{
			base.FormClosed += new FormClosedEventHandler(this.StartGame_FormClosed);
			base.Load += new EventHandler(this.StartGame_Load);
			base.KeyDown += new KeyEventHandler(this.StartGame_KeyDown);
			base.Shown += new EventHandler(this.StartGame_Shown);
			this.InitializeComponent();
		}

		//// Token: 0x06005095 RID: 20629 RVA: 0x0020CBD4 File Offset: 0x0020ADD4
		//[CompilerGenerated]
		//internal  GroupBox vmethod_0()
		//{
		//	return this.groupBox_0;
		//}

		// Token: 0x06005096 RID: 20630 RVA: 0x00025B8D File Offset: 0x00023D8D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(GroupBox groupBox_2)
		{
			this.groupBox_0 = groupBox_2;
		}

		//// Token: 0x06005097 RID: 20631 RVA: 0x0020CBEC File Offset: 0x0020ADEC
		//[CompilerGenerated]
		//internal  Button GetStartScenarioButton()
		//{
		//	return this.StartScenarioButton;
		//}

		//// Token: 0x06005098 RID: 20632 RVA: 0x0020CC04 File Offset: 0x0020AE04
		//[CompilerGenerated]
		//[MethodImpl(MethodImplOptions.Synchronized)]
		//internal void vmethod_3(Button button_7)
		//{
		//	EventHandler value = new EventHandler(this.StartScenarioButton_Click);
		//	Button startScenarioButton = this.StartScenarioButton;
		//	if (startScenarioButton != null)
		//	{
		//		startScenarioButton.Click -= value;
		//	}
		//	this.StartScenarioButton = button_7;
		//	startScenarioButton = this.StartScenarioButton;
		//	if (startScenarioButton != null)
		//	{
		//		startScenarioButton.Click += value;
		//	}
		//}


		//// Token: 0x06005099 RID: 20633 RVA: 0x0020CC50 File Offset: 0x0020AE50
		//[CompilerGenerated]
		//internal  GroupBox vmethod_4()
		//{
		//	return this.groupBox_1;
		//}

		//// Token: 0x0600509A RID: 20634 RVA: 0x00025B96 File Offset: 0x00023D96
		//[CompilerGenerated]
		//[MethodImpl(MethodImplOptions.Synchronized)]
		//internal void vmethod_5(GroupBox groupBox_2)
		//{
		//	this.groupBox_1 = groupBox_2;
		//}

		//// Token: 0x0600509B RID: 20635 RVA: 0x0020CC68 File Offset: 0x0020AE68
		//[CompilerGenerated]
		//internal  Button vmethod_6()
		//{
		//	return this.button_1;
		//}

		//// Token: 0x0600509C RID: 20636 RVA: 0x0020CC80 File Offset: 0x0020AE80
		//[CompilerGenerated]
		//[MethodImpl(MethodImplOptions.Synchronized)]
		//internal void vmethod_7(Button button_7)
		//{
		//	EventHandler value = new EventHandler(this.method_4);
		//	Button button = this.button_1;
		//	if (button != null)
		//	{
		//		button.Click -= value;
		//	}
		//	this.button_1 = button_7;
		//	button = this.button_1;
		//	if (button != null)
		//	{
		//		button.Click += value;
		//	}
		//}

		//// Token: 0x0600509D RID: 20637 RVA: 0x0020CCCC File Offset: 0x0020AECC
		//[CompilerGenerated]
		//internal  Button vmethod_8()
		//{
		//	return this.button_2;
		//}

		//// Token: 0x0600509E RID: 20638 RVA: 0x0020CCE4 File Offset: 0x0020AEE4
		//[CompilerGenerated]
		//[MethodImpl(MethodImplOptions.Synchronized)]
		//internal void vmethod_9(Button button_7)
		//{
		//	EventHandler value = new EventHandler(this.method_1);
		//	Button button = this.button_2;
		//	if (button != null)
		//	{
		//		button.Click -= value;
		//	}
		//	this.button_2 = button_7;
		//	button = this.button_2;
		//	if (button != null)
		//	{
		//		button.Click += value;
		//	}
		//}

		//// Token: 0x0600509F RID: 20639 RVA: 0x0020CD30 File Offset: 0x0020AF30
		//[CompilerGenerated]
		//internal  Button vmethod_10()
		//{
		//	return this.button_3;
		//}

		//// Token: 0x060050A0 RID: 20640 RVA: 0x0020CD48 File Offset: 0x0020AF48
		//[CompilerGenerated]
		//[MethodImpl(MethodImplOptions.Synchronized)]
		//internal void vmethod_11(Button button_7)
		//{
		//	EventHandler value = new EventHandler(this.method_3);
		//	Button button = this.button_3;
		//	if (button != null)
		//	{
		//		button.Click -= value;
		//	}
		//	this.button_3 = button_7;
		//	button = this.button_3;
		//	if (button != null)
		//	{
		//		button.Click += value;
		//	}
		//}

		//// Token: 0x060050A1 RID: 20641 RVA: 0x0020CD94 File Offset: 0x0020AF94
		//[CompilerGenerated]
		//internal  Button vmethod_12()
		//{
		//	return this.button_4;
		//}

		//// Token: 0x060050A2 RID: 20642 RVA: 0x0020CDAC File Offset: 0x0020AFAC
		//[CompilerGenerated]
		//[MethodImpl(MethodImplOptions.Synchronized)]
		//internal void vmethod_13(Button button_7)
		//{
		//	EventHandler value = new EventHandler(this.method_5);
		//	Button button = this.button_4;
		//	if (button != null)
		//	{
		//		button.Click -= value;
		//	}
		//	this.button_4 = button_7;
		//	button = this.button_4;
		//	if (button != null)
		//	{
		//		button.Click += value;
		//	}
		//}

		//// Token: 0x060050A3 RID: 20643 RVA: 0x0020CDF8 File Offset: 0x0020AFF8
		//[CompilerGenerated]
		//internal  PictureBox pictureBox_0
		//{
		//	return this.pictureBox_0;
		//}

		//// Token: 0x060050A4 RID: 20644 RVA: 0x00025B9F File Offset: 0x00023D9F
		//[CompilerGenerated]
		//[MethodImpl(MethodImplOptions.Synchronized)]
		//internal void vmethod_15(PictureBox pictureBox_1)
		//{
		//	this.pictureBox_0 = pictureBox_1;
		//}

		//// Token: 0x060050A5 RID: 20645 RVA: 0x0020CE10 File Offset: 0x0020B010
		//[CompilerGenerated]
		//internal  Button vmethod_16()
		//{
		//	return this.button_5;
		//}

		// Token: 0x060050A6 RID: 20646 RVA: 0x0020CE28 File Offset: 0x0020B028
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Button button_7)
		{
			EventHandler value = new EventHandler(this.method_6);
			Button button = this.button_5;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_5 = button_7;
			button = this.button_5;
			if (button != null)
			{
				button.Click += value;
			}
		}

		//// Token: 0x060050A7 RID: 20647 RVA: 0x0020CE74 File Offset: 0x0020B074
		//[CompilerGenerated]
		//internal  Button vmethod_18()
		//{
		//	return this.button_6;
		//}

		//// Token: 0x060050A8 RID: 20648 RVA: 0x0020CE8C File Offset: 0x0020B08C
		//[CompilerGenerated]
		//[MethodImpl(MethodImplOptions.Synchronized)]
		//internal void vmethod_19(Button button_7)
		//{
		//	EventHandler value = new EventHandler(this.method_7);
		//	Button button = this.button_6;
		//	if (button != null)
		//	{
		//		button.Click -= value;
		//	}
		//	this.button_6 = button_7;
		//	button = this.button_6;
		//	if (button != null)
		//	{
		//		button.Click += value;
		//	}
		//}

		// Token: 0x060050A9 RID: 20649 RVA: 0x00025BA8 File Offset: 0x00023DA8
		private void method_1(object sender, EventArgs e)
		{
			if (!GameGeneral.bProfessionEdition && !LicenseChecker.HoldLicense(LicenseChecker.License.CMANOBase))
			{
				CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().Show();
			}
			else
			{
				Client.GetConfiguration().SetGameMode(Configuration._GameMode.Edit);
				Client.smethod_63();
				base.Close();
			}
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x00025BE3 File Offset: 0x00023DE3
		private void StartScenarioButton_Click(object sender, EventArgs e)
		{
			Client.GetConfiguration().SetGameMode(Configuration._GameMode.Play);
			CommandFactory.GetCommandMain().GetLoadScenario().enum188_0 = LoadScenario.Enum188.const_0;
			CommandFactory.GetCommandMain().GetLoadScenario().Show();
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x00025C0F File Offset: 0x00023E0F
		private void method_3(object sender, EventArgs e)
		{
			Client.GetConfiguration().SetGameMode(Configuration._GameMode.Play);
			CommandFactory.GetCommandMain().GetLoadScenario().enum188_0 = LoadScenario.Enum188.const_1;
			CommandFactory.GetCommandMain().GetLoadScenario().Show();
		}

		// Token: 0x060050AC RID: 20652 RVA: 0x0020CED8 File Offset: 0x0020B0D8
		private void method_4(object sender, EventArgs e)
		{
			if (!LicenseChecker.HoldLicense(LicenseChecker.License.CMANOBase) && !GameGeneral.bProfessionEdition)
			{
				CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().Show();
			}
			else
			{
				Client.GetConfiguration().SetGameMode(Configuration._GameMode.Edit);
				CommandFactory.GetCommandMain().GetLoadScenario().enum188_0 = LoadScenario.Enum188.const_0;
				CommandFactory.GetCommandMain().GetLoadScenario().Show();
			}
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x00025C3B File Offset: 0x00023E3B
		private void method_5(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().Close();
		}

		// Token: 0x060050AE RID: 20654 RVA: 0x00020C50 File Offset: 0x0001EE50
		private void StartGame_FormClosed(object sender, FormClosedEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x060050AF RID: 20655 RVA: 0x0020CF34 File Offset: 0x0020B134
		private void StartGame_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (!GameGeneral.bProfessionEdition && !LicenseChecker.HoldLicense(LicenseChecker.License.CMANOBase))
			{
				if (LicenseChecker.HoldLicense(LicenseChecker.License.NorthernInferno))
				{
					this.pictureBox_0.Image = Image.FromFile(Path.Combine(CommandFactory.GetCommandApp().Info.DirectoryPath, "Symbols\\splash_NI.jpg"));
				}
			}
			else
			{
				this.pictureBox_0.Image = Image.FromFile(Path.Combine(CommandFactory.GetCommandApp().Info.DirectoryPath, "Symbols\\splash.jpg"));
			}
			this.button_6.Visible = true;
			CommandFactory.GetCommandMain().GetMainForm().Enabled = false;
			Client.GetConfiguration().SetSimStopMode();
		}

		// Token: 0x060050B0 RID: 20656 RVA: 0x0020CFF0 File Offset: 0x0020B1F0
		private void method_6(object sender, EventArgs e)
		{
			if (File.Exists(GameGeneral.strScenariosDir + "\\Autosave.scen"))
			{
				Client.GetConfiguration().SetGameMode(Configuration._GameMode.Play);
				CommandFactory.GetCommandMain().GetResumeFromSave().string_0 = GameGeneral.strScenariosDir + "\\Autosave.scen";
				CommandFactory.GetCommandMain().GetResumeFromSave().Show();
				base.Close();
			}
			else
			{
				Interaction.MsgBox("No autosave file was found at the path \\Scenarios\\Autosave.scen", MsgBoxStyle.OkOnly, "No autosave found");
			}
		}

		// Token: 0x060050B1 RID: 20657 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		private void StartGame_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x060050B2 RID: 20658 RVA: 0x00025C4C File Offset: 0x00023E4C
		private void StartGame_Shown(object sender, EventArgs e)
		{
			if (SimConfiguration.gameOptions.IsGameMusicON())
			{
				Class2531.smethod_1();
			}
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x0001FD64 File Offset: 0x0001DF64
		private void method_7(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetCampaignPlayWindow().Show();
			base.Close();
		}

		// Token: 0x040025E0 RID: 9696
		[CompilerGenerated]
		private GroupBox groupBox_0;

		// Token: 0x040025E1 RID: 9697
		[CompilerGenerated]
		private Button StartScenarioButton;

		// Token: 0x040025E2 RID: 9698
		[CompilerGenerated]
		private GroupBox groupBox_1;

		// Token: 0x040025E3 RID: 9699
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x040025E4 RID: 9700
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x040025E5 RID: 9701
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x040025E6 RID: 9702
		[CompilerGenerated]
		private Button button_4;

		// Token: 0x040025E7 RID: 9703
		[CompilerGenerated]
		private PictureBox pictureBox_0;

		// Token: 0x040025E8 RID: 9704
		[CompilerGenerated]
		private Button button_5;

		// Token: 0x040025E9 RID: 9705
		[CompilerGenerated]
		private Button button_6;
	}
}

using System;
using System.Collections.Generic;
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
using ns0;
using ns2;
using ns32;
using ns34;
using ns35;

namespace ns33
{
	// Token: 0x0200097C RID: 2428
	[DesignerGenerated]
	public sealed partial class CampaignScenarioWindow : CommandForm
	{
		// Token: 0x06003C6F RID: 15471 RVA: 0x0001FCBA File Offset: 0x0001DEBA
		public CampaignScenarioWindow()
		{
			base.Shown += new EventHandler(this.CampaignScenarioWindow_Shown);
			base.Load += new EventHandler(this.CampaignScenarioWindow_Load);
			this.vmethod_15(new BackgroundWorker());
			this.InitializeComponent();
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x0012CC58 File Offset: 0x0012AE58
		[CompilerGenerated]
		internal  WebBrowser vmethod_0()
		{
			return this.webBrowser_0;
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x0001FCF7 File Offset: 0x0001DEF7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(WebBrowser webBrowser_1)
		{
			this.webBrowser_0 = webBrowser_1;
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x0012CC70 File Offset: 0x0012AE70
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x0001FD00 File Offset: 0x0001DF00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_2)
		{
			this.label_0 = label_2;
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x0012CC88 File Offset: 0x0012AE88
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_0;
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x0012CCA0 File Offset: 0x0012AEA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x06003C78 RID: 15480 RVA: 0x0012CCEC File Offset: 0x0012AEEC
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_1;
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x0012CD04 File Offset: 0x0012AF04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_5);
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

		// Token: 0x06003C7A RID: 15482 RVA: 0x0012CD50 File Offset: 0x0012AF50
		[CompilerGenerated]
		internal  ProgressBar vmethod_8()
		{
			return this.progressBar_0;
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x0001FD09 File Offset: 0x0001DF09
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ProgressBar progressBar_1)
		{
			this.progressBar_0 = progressBar_1;
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x0012CD68 File Offset: 0x0012AF68
		[CompilerGenerated]
		internal  Label vmethod_10()
		{
			return this.label_1;
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x0001FD12 File Offset: 0x0001DF12
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_2)
		{
			this.label_1 = label_2;
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x0012CD80 File Offset: 0x0012AF80
		[CompilerGenerated]
		internal  Timer vmethod_12()
		{
			return this.timer_0;
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x0012CD98 File Offset: 0x0012AF98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_4);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_0 = timer_1;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x0012CDE4 File Offset: 0x0012AFE4
		[CompilerGenerated]
		public  BackgroundWorker vmethod_14()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x0012CDFC File Offset: 0x0012AFFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void vmethod_15(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler value = new DoWorkEventHandler(this.method_1);
			RunWorkerCompletedEventHandler value2 = new RunWorkerCompletedEventHandler(this.method_2);
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

		// Token: 0x06003C82 RID: 15490 RVA: 0x0012CE60 File Offset: 0x0012B060
		private void CampaignScenarioWindow_Shown(object sender, EventArgs e)
		{
			this.scenContainer_0 = ScenContainer.smethod_2(this.string_0);
			this.vmethod_12().Start();
			this.vmethod_4().Enabled = false;
			this.vmethod_10().Visible = true;
			this.vmethod_8().Visible = true;
			string text = Scenario.XmlReaderSting(this.scenContainer_0.method_9(), "ContentTag");
			if (!LicenseChecker.smethod_20(text))
			{
				if (string.IsNullOrEmpty(text))
				{
					CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CMANOBase;
				}
				else
				{
					string left = text.ToString();
					if (Operators.CompareString(left, "TUTORIAL", false) != 0)
					{
						if (Operators.CompareString(left, "NINFERNO", false) != 0)
						{
							if (Operators.CompareString(left, "OLDGRUDGES", false) != 0)
							{
								if (Operators.CompareString(left, "BREXIT", false) == 0)
								{
									CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CLIVE2;
								}
							}
							else
							{
								CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CLIVE1;
							}
						}
						else
						{
							CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.NorthernInferno;
						}
					}
					else
					{
						CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CMANOBase;
					}
				}
				CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().Show();
				base.Close();
			}
			else
			{
				this.vmethod_14().RunWorkerAsync();
				this.vmethod_0().Visible = true;
				if (!this.method_3(this.vmethod_0(), this.scenContainer_0.ScenDescription, Path.GetDirectoryName(this.string_0)))
				{
					Class2529.smethod_7(this.vmethod_0(), this.scenContainer_0.ScenDescription, default(Color));
				}
				this.vmethod_2().Text = this.scenContainer_0.ScenTitle;
			}
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x0012D00C File Offset: 0x0012B20C
		private void method_1(object sender, DoWorkEventArgs e)
		{
			this.scenario_0 = this.scenContainer_0.LoadScenario(ref Client.string_2, ref this.double_0, false);
			if (this.scenario_0.GetScenAttachments().Count > 0)
			{
				ScenarioCompressor.smethod_1(this.scenario_0, this.string_0);
			}
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x0001FD1B File Offset: 0x0001DF1B
		private void method_2(object sender, RunWorkerCompletedEventArgs e)
		{
			this.vmethod_10().Visible = false;
			this.vmethod_8().Visible = false;
			this.vmethod_4().Enabled = true;
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x0012D060 File Offset: 0x0012B260
		private bool method_3(WebBrowser webBrowser_1, string string_2, string string_3)
		{
			bool result;
			if (string_2.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_2, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_2, "[/LOADDOC]", CompareMethod.Binary);
				string path = string_2.Substring(num, string_2.Length - num - (string_2.Length - num2 + 1));
				if (File.Exists(Path.Combine(string_3, path)))
				{
					webBrowser_1.Navigate(Path.Combine(string_3, path));
					result = true;
				}
				else
				{
					string string_4 = Scenario.XmlReaderSting(this.scenContainer_0.method_9(), "CampaignID");
					Campaign campaign = Campaign.smethod_2(GameGeneral.strScenariosDir, string_4);
					if (!Information.IsNothing(campaign))
					{
						webBrowser_1.Navigate(Path.Combine(campaign.campaignDir, path));
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x0001FD41 File Offset: 0x0001DF41
		private void method_4(object sender, EventArgs e)
		{
			this.vmethod_8().Value = (int)Math.Round(this.double_0 * 100.0);
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x0001FD64 File Offset: 0x0001DF64
		private void method_5(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetCampaignPlayWindow().Show();
			base.Close();
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x0012D130 File Offset: 0x0012B330
		private void method_6(object sender, EventArgs e)
		{
			this.scenario_0.CampaignSessionID = this.CampaignSessionID;
			this.scenario_0.CampaignID = this.m_Campaign.ID;
			this.scenario_0.CampaignScore = this.int_0;
			Client.SetClientScenario(this.scenario_0, false);
			Client.CheckScenario(Client.GetClientScenario(), this.string_0);
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Play)
			{
				Client.GetConfiguration().SetGameMode(Configuration._GameMode.Play);
			}
			List<string> list = new List<string>();
			Campaign.smethod_3(GameGeneral.strScenariosDir, list);
			string customFileName = "";
			foreach (string current in list)
			{
				Campaign campaign = Campaign.GetCampaign(current);
				if (Operators.CompareString(campaign.ID, Client.GetClientScenario().CampaignID, false) == 0)
				{
					customFileName = Path.Combine(Path.GetDirectoryName(current), Guid.NewGuid().ToString() + ".save");
					break;
				}
			}
			Client.SaveTempScenarioFile(false, customFileName, true);
			base.Close();
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void CampaignScenarioWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001B8B RID: 7051
		[CompilerGenerated]
		private WebBrowser webBrowser_0;

		// Token: 0x04001B8C RID: 7052
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001B8D RID: 7053
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001B8E RID: 7054
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001B8F RID: 7055
		[CompilerGenerated]
		private ProgressBar progressBar_0;

		// Token: 0x04001B90 RID: 7056
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001B91 RID: 7057
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x04001B92 RID: 7058
		public Campaign m_Campaign;

		// Token: 0x04001B93 RID: 7059
		public string string_0;

		// Token: 0x04001B94 RID: 7060
		public string CampaignSessionID;

		// Token: 0x04001B95 RID: 7061
		public int int_0;

		// Token: 0x04001B96 RID: 7062
		private Scenario scenario_0;

		// Token: 0x04001B97 RID: 7063
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04001B98 RID: 7064
		private double double_0;

		// Token: 0x04001B99 RID: 7065
		private ScenContainer scenContainer_0;
	}
}

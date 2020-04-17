using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace ns34
{
	// 从保存的想定继续
	[DesignerGenerated]
	public sealed partial class ResumeFromSave : CommandForm
	{
		// Token: 0x06004D12 RID: 19730 RVA: 0x001EB090 File Offset: 0x001E9290
		public ResumeFromSave()
		{
			base.Shown += new EventHandler(this.ResumeFromSave_Shown);
			base.FormClosing += new FormClosingEventHandler(this.ResumeFromSave_FormClosing);
			base.Load += new EventHandler(this.ResumeFromSave_Load);
			this.vmethod_3(new BackgroundWorker());
			this.InitializeComponent();
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x001EB22C File Offset: 0x001E942C
		[CompilerGenerated]
		internal  ProgressBar vmethod_0()
		{
			return this.progressBar_0;
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x00024992 File Offset: 0x00022B92
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ProgressBar progressBar_1)
		{
			this.progressBar_0 = progressBar_1;
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x001EB244 File Offset: 0x001E9444
		[CompilerGenerated]
		internal  BackgroundWorker vmethod_2()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x001EB25C File Offset: 0x001E945C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(BackgroundWorker backgroundWorker_1)
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

		// Token: 0x06004D19 RID: 19737 RVA: 0x001EB2C0 File Offset: 0x001E94C0
		private void ResumeFromSave_Shown(object sender, EventArgs e)
		{
			this.scenContainer_0 = ScenContainer.smethod_2(this.string_0);
			string text = this.scenContainer_0.method_9();
			this.string_1 = Scenario.XmlReaderSting(text, "ContentTag");
			if (string.IsNullOrEmpty(this.string_1))
			{
				this.string_1 = "";
			}
			if (!LicenseChecker.smethod_20(this.string_1))
			{
				if (string.IsNullOrEmpty(this.string_1))
				{
					CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CMANOBase;
				}
				else
				{
					string left = this.string_1.ToString();
					if (Operators.CompareString(left, "TUTORIAL", false) != 0)
					{
						if (Operators.CompareString(left, "NINFERNO", false) != 0)
						{
							if (Operators.CompareString(left, "OLDGRUDGES", false) != 0)
							{
								if (Operators.CompareString(left, "BREXIT", false) == 0)
								{
									if (LicenseChecker.smethod_20(""))
									{
										CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CLIVE2;
									}
									else
									{
										CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CMANOBase;
									}
								}
							}
							else if (LicenseChecker.smethod_20(""))
							{
								CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CLIVE1;
							}
							else
							{
								CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CMANOBase;
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
				Scenario clientScenario = Client.GetClientScenario();
				GameGeneral.ClearActiveUnits(ref clientScenario);
				GameGeneral.ClearScenarioStreamDictionary();
				this.bool_0 = false;
				this.scenario_0 = null;
				this.vmethod_2().RunWorkerAsync();
				this.vmethod_0().Visible = true;
				while (!this.bool_0)
				{
					Application.DoEvents();
					this.vmethod_0().Value = (int)Math.Round(this.double_0 * 100.0);
					Thread.Sleep(50);
				}
			}
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x001EB4B8 File Offset: 0x001E96B8
		private void method_1(object sender, DoWorkEventArgs e)
		{
			try
			{
				Scenario scenario = this.scenContainer_0.LoadScenario(ref Client.string_2, ref this.double_0, false);
				this.scenario_0 = scenario;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200106", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004D1B RID: 19739 RVA: 0x0002499B File Offset: 0x00022B9B
		private void method_2(object sender, RunWorkerCompletedEventArgs e)
		{
			if (!Information.IsNothing(this.scenario_0))
			{
				Client.CheckScenario(this.scenario_0, this.string_0);
				this.bool_0 = true;
				base.Close();
			}
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x00004D83 File Offset: 0x00002F83
		private void ResumeFromSave_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void ResumeFromSave_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04002474 RID: 9332
		[CompilerGenerated]
		private ProgressBar progressBar_0;

		// Token: 0x04002475 RID: 9333
		private ScenContainer scenContainer_0;

		// Token: 0x04002476 RID: 9334
		public string string_0;

		// Token: 0x04002477 RID: 9335
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x04002478 RID: 9336
		private Scenario scenario_0;

		// Token: 0x04002479 RID: 9337
		private bool bool_0;

		// Token: 0x0400247A RID: 9338
		private double double_0;

		// Token: 0x0400247B RID: 9339
		private string string_1;
	}
}

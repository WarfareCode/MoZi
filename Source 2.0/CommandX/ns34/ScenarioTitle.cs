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
using MSDN.Html.Editor;
using ns0;
using ns2;
using ns32;
using ns33;
using ns35;

namespace ns34
{
	// Token: 0x02000A09 RID: 2569
	[DesignerGenerated]
	public sealed partial class ScenarioTitle : CommandForm
	{
		// Token: 0x06004E52 RID: 20050 RVA: 0x001F8158 File Offset: 0x001F6358
		public ScenarioTitle()
		{
			base.FormClosing += new FormClosingEventHandler(this.ScenarioTitle_FormClosing);
			base.Load += new EventHandler(this.ScenarioTitle_Load);
			base.KeyDown += new KeyEventHandler(this.ScenarioTitle_KeyDown);
			base.Shown += new EventHandler(this.ScenarioTitle_Shown);
			base.ResizeEnd += new EventHandler(this.ScenarioTitle_ResizeEnd);
			this.InitializeComponent();
		}

		// Token: 0x06004E55 RID: 20053 RVA: 0x001F85D4 File Offset: 0x001F67D4
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06004E56 RID: 20054 RVA: 0x00024F2E File Offset: 0x0002312E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_2)
		{
			this.label_0 = label_2;
		}

		// Token: 0x06004E57 RID: 20055 RVA: 0x001F85EC File Offset: 0x001F67EC
		[CompilerGenerated]
		internal  TextBox vmethod_2()
		{
			return this.textBox_0;
		}

		// Token: 0x06004E58 RID: 20056 RVA: 0x001F8604 File Offset: 0x001F6804
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TextBox textBox_1)
		{
			EventHandler value = new EventHandler(this.method_1);
			TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
			}
			this.textBox_0 = textBox_1;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged += value;
			}
		}

		// Token: 0x06004E59 RID: 20057 RVA: 0x001F8650 File Offset: 0x001F6850
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_1;
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x00024F37 File Offset: 0x00023137
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_2)
		{
			this.label_1 = label_2;
		}

		// Token: 0x06004E5B RID: 20059 RVA: 0x001F8668 File Offset: 0x001F6868
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_0;
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x001F8680 File Offset: 0x001F6880
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_2);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_3;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004E5D RID: 20061 RVA: 0x001F86CC File Offset: 0x001F68CC
		[CompilerGenerated]
		internal  Button vmethod_8()
		{
			return this.button_1;
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x001F86E4 File Offset: 0x001F68E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_4);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_3;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004E5F RID: 20063 RVA: 0x001F8730 File Offset: 0x001F6930
		[CompilerGenerated]
		internal  HtmlEditorControl vmethod_10()
		{
			return this.htmlEditorControl_0;
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x00024F40 File Offset: 0x00023140
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(HtmlEditorControl htmlEditorControl_1)
		{
			this.htmlEditorControl_0 = htmlEditorControl_1;
		}

		// Token: 0x06004E61 RID: 20065 RVA: 0x001F8748 File Offset: 0x001F6948
		[CompilerGenerated]
		internal  Button vmethod_12()
		{
			return this.button_2;
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x001F8760 File Offset: 0x001F6960
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_5);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_3;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x00024F49 File Offset: 0x00023149
		private void method_1(object sender, EventArgs e)
		{
			if (Client.GetCommandOrder() == Client._CommandOrder.CreateNewScenario)
			{
				this.vmethod_6().Enabled = (Operators.CompareString(this.vmethod_2().Text, "", false) != 0);
			}
		}

		// Token: 0x06004E64 RID: 20068 RVA: 0x001F87AC File Offset: 0x001F69AC
		private void method_2(object sender, EventArgs e)
		{
			string text = Class2529.smethod_1(this.vmethod_2().Text);
			if (Operators.CompareString(text, "", false) == 0)
			{
				Interaction.MsgBox("Please use valid filename characters for the scenario name", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				Client._CommandOrder commandOrder = Client.GetCommandOrder();
				if (commandOrder == Client._CommandOrder.EditScenario)
				{
					Client.GetClientScenario().SetScenarioTitle(this.vmethod_2().Text);
					Client.GetClientScenario().SetDescription(this.vmethod_10().BodyHtml);
					CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
					base.Close();
				}
				else if (commandOrder == Client._CommandOrder.SaveScenario)
				{
					Client.GetClientScenario().SetScenarioTitle(this.vmethod_2().Text);
					Client.GetClientScenario().FileName = text;
					Client.GetClientScenario().SetDescription(this.vmethod_10().BodyHtml);
					CommandFactory.GetCommandMain().GetMainForm().vmethod_26().FileName = text;
					CommandFactory.GetCommandMain().GetMainForm().vmethod_26().AddExtension = true;
					if (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit)
					{
						CommandFactory.GetCommandMain().GetMainForm().vmethod_26().Filter = "Command scenario file (*.scen)|*.scen|Command saved game (*.save)|*.save|All Files (*.*)|*.*";
					}
					else
					{
						CommandFactory.GetCommandMain().GetMainForm().vmethod_26().Filter = "Command saved game (*.save)|*.save|Command scenario file (*.scen)|*.scen|All Files (*.*)|*.*";
					}
					if (string.IsNullOrEmpty(CommandFactory.GetCommandMain().GetMainForm().vmethod_26().InitialDirectory))
					{
						CommandFactory.GetCommandMain().GetMainForm().vmethod_26().InitialDirectory = GameGeneral.strScenariosDir;
					}
					if (CommandFactory.GetCommandMain().GetMainForm().vmethod_26().ShowDialog() == DialogResult.OK)
					{
						Client.SaveTempScenarioFile(true, "", false);
						CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
						base.Close();
					}
					else
					{
						Interaction.MsgBox(CommandFactory.GetCommandMain().GetMainForm().vmethod_26().ShowDialog().ToString(), MsgBoxStyle.OkOnly, null);
					}
					Client.string_3 = CommandFactory.GetCommandMain().GetMainForm().vmethod_26().FileName;
				}
				else if (commandOrder == Client._CommandOrder.EditBriefing)
				{
					Client.GetClientScenario().SetScenarioTitle(this.vmethod_2().Text);
					Client.GetClientScenario().FileName = text;
					Client.GetClientScenario().SetDescription(this.vmethod_10().BodyHtml);
					CommandFactory.GetCommandMain().GetMainForm().vmethod_26().FileName = text;
					CommandFactory.GetCommandMain().GetMainForm().vmethod_26().AddExtension = true;
					CommandFactory.GetCommandMain().GetMainForm().vmethod_26().Filter = "想定打包文件(*.zip)|*.zip";
					if (string.IsNullOrEmpty(CommandFactory.GetCommandMain().GetMainForm().vmethod_26().InitialDirectory))
					{
						CommandFactory.GetCommandMain().GetMainForm().vmethod_26().InitialDirectory = GameGeneral.strScenariosDir;
					}
					if (CommandFactory.GetCommandMain().GetMainForm().vmethod_26().ShowDialog() == DialogResult.OK)
					{
						ScenarioCompressor.smethod_0(Client.GetClientScenario(), Client.GetClientSide(), CommandFactory.GetCommandMain().GetMainForm().vmethod_26().FileName);
						CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
						base.Close();
					}
					else
					{
						Interaction.MsgBox(CommandFactory.GetCommandMain().GetMainForm().vmethod_26().ShowDialog().ToString(), MsgBoxStyle.OkOnly, null);
					}
					Client.string_3 = CommandFactory.GetCommandMain().GetMainForm().vmethod_26().FileName;
				}
			}
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x00024F7F File Offset: 0x0002317F
		private void ScenarioTitle_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.bool_0)
			{
				Client.GetConfiguration().SetSimRunMode();
			}
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			Client.IssueOrdersToUnit(Client._CommandOrder.None);
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x001F8B00 File Offset: 0x001F6D00
		private void ScenarioTitle_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.bool_0 = (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Run);
			if (this.bool_0)
			{
				Client.GetConfiguration().SetSimStopMode();
			}
			switch (Client.GetCommandOrder())
			{
			case Client._CommandOrder.CreateNewScenario:
				this.Text = "Create new scenario";
				this.vmethod_6().Enabled = (Operators.CompareString(this.vmethod_2().Text, "", false) != 0);
				this.vmethod_2().Enabled = true;
				this.vmethod_6().Visible = true;
				this.vmethod_8().Visible = true;
				break;
			case Client._CommandOrder.EditScenario:
				if (!Information.IsNothing(Client.GetClientScenario().GetScenarioTitle()))
				{
					this.vmethod_2().Text = Client.GetClientScenario().GetScenarioTitle().ToString();
				}
				if (!Information.IsNothing(Client.GetClientScenario().GetDescription()))
				{
					this.vmethod_10().BodyHtml = Client.GetClientScenario().GetDescription().ToString();
				}
				this.vmethod_2().Enabled = true;
				this.vmethod_6().Visible = true;
				this.vmethod_8().Visible = true;
				break;
			case Client._CommandOrder.SaveScenario:
				this.Text = "Save scenario";
				if (!Information.IsNothing(Client.GetClientScenario().GetScenarioTitle()))
				{
					this.vmethod_2().Text = Client.GetClientScenario().GetScenarioTitle().ToString();
				}
				if (!Information.IsNothing(Client.GetClientScenario().GetDescription()))
				{
					this.vmethod_10().BodyHtml = Client.GetClientScenario().GetDescription().ToString();
				}
				this.vmethod_2().Enabled = true;
				this.vmethod_6().Visible = true;
				this.vmethod_8().Visible = true;
				break;
			default:
				if (!Information.IsNothing(Client.GetClientScenario().GetScenarioTitle()))
				{
					this.vmethod_2().Text = Client.GetClientScenario().GetScenarioTitle().ToString();
				}
				if (!Information.IsNothing(Client.GetClientScenario().GetDescription()))
				{
					if (!string.IsNullOrEmpty(Client.string_0))
					{
						if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
						{
							if (!this.method_3(this.vmethod_10(), Client.GetClientScenario().GetDescription().ToString(), Path.GetDirectoryName(Client.string_0)))
							{
								this.vmethod_10().BodyHtml = Client.GetClientScenario().GetDescription().ToString();
							}
						}
						else
						{
							this.vmethod_10().BodyHtml = Client.GetClientScenario().GetDescription().ToString();
						}
					}
					else
					{
						this.vmethod_10().BodyHtml = Client.GetClientScenario().GetDescription().ToString();
					}
				}
				this.Text = "Scenario Description";
				this.vmethod_2().Enabled = false;
				this.vmethod_6().Visible = false;
				this.vmethod_8().Visible = false;
				break;
			}
		}

		// Token: 0x06004E67 RID: 20071 RVA: 0x001F8DD0 File Offset: 0x001F6FD0
		private bool method_3(HtmlEditorControl htmlEditorControl_1, string string_0, string string_1)
		{
			bool result;
			if (string_0.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_0, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_0, "[/LOADDOC]", CompareMethod.Binary);
				string path = string_0.Substring(num, string_0.Length - num - (string_0.Length - num2 + 1));
				if (File.Exists(Path.Combine(string_1, path)))
				{
					htmlEditorControl_1.NavigateToUrl(Path.Combine(string_1, path));
					result = true;
				}
				else
				{
					string campaignID = Client.GetClientScenario().CampaignID;
					Campaign campaign = Campaign.smethod_2(GameGeneral.strScenariosDir, campaignID);
					if (!Information.IsNothing(campaign))
					{
						htmlEditorControl_1.NavigateToUrl(Path.Combine(campaign.campaignDir, path));
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

		// Token: 0x06004E68 RID: 20072 RVA: 0x00024D89 File Offset: 0x00022F89
		private void method_4(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			base.Close();
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x00024B05 File Offset: 0x00022D05
		private void ScenarioTitle_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
				base.Close();
			}
		}

		// Token: 0x06004E6A RID: 20074 RVA: 0x00024FBB File Offset: 0x000231BB
		private void ScenarioTitle_Shown(object sender, EventArgs e)
		{
			if (base.Height != 510)
			{
				base.Width--;
				base.Width++;
			}
		}

		// Token: 0x06004E6B RID: 20075 RVA: 0x00024FE8 File Offset: 0x000231E8
		private void ScenarioTitle_ResizeEnd(object sender, EventArgs e)
		{
			base.Width--;
			base.Width++;
		}

		// Token: 0x06004E6C RID: 20076 RVA: 0x00025006 File Offset: 0x00023206
		private void method_5(object sender, EventArgs e)
		{
			this.vmethod_10().HtmlContentsEdit();
		}

		// Token: 0x04002507 RID: 9479
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04002508 RID: 9480
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04002509 RID: 9481
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x0400250A RID: 9482
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x0400250B RID: 9483
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x0400250C RID: 9484
		[CompilerGenerated]
		private HtmlEditorControl htmlEditorControl_0;

		// Token: 0x0400250D RID: 9485
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x0400250E RID: 9486
		private bool bool_0;
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns32;
using ns33;
using ns35;

namespace Command
{
	// 所属方选择对话框
	[DesignerGenerated]
	public sealed partial class ChooseSide : CommandForm
	{
		// Token: 0x06004D75 RID: 19829 RVA: 0x001F1318 File Offset: 0x001EF518
		public ChooseSide()
		{
			base.FormClosing += new FormClosingEventHandler(this.ChooseSide_FormClosing);
			base.Load += new EventHandler(this.ChooseSide_Load);
			base.KeyDown += new KeyEventHandler(this.ChooseSide_KeyDown);
			base.FormClosed += new FormClosedEventHandler(this.ChooseSide_FormClosed);
			this.list_0 = new List<Side>();
			this.InitializeComponent();
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x00024AF5 File Offset: 0x00022CF5
		private void ChooseSide_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.scenario_0 = null;
			this.list_0 = null;
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x00020C50 File Offset: 0x0001EE50
		private void ChooseSide_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x00024B05 File Offset: 0x00022D05
		private void ChooseSide_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
				base.Close();
			}
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x001F1384 File Offset: 0x001EF584
		private void ChooseSide_Load(object sender, EventArgs e)
		{
			List<Side>.Enumerator enumerator = default(List<Side>.Enumerator);
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			Side side = null;
			CommandFactory.GetCommandMain().GetMainForm().Enabled = false;
			Side[] sides = this.scenario_0.GetSides();
			this.list_0 = ((IEnumerable<Side>)sides).Where(ChooseSide.SideFunc).ToList<Side>();
			if (this.list_0.Count != 1)
			{
				this.comboBox_0.Visible = true;
				this.label_0.Visible = true;
				try
				{
					enumerator = this.list_0.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Side current = enumerator.Current;
						this.comboBox_0.Items.Add(current.GetSideName());
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				if (this.comboBox_0.Items.Count > 0)
				{
					this.comboBox_0.SelectedIndex = 0;
				}
				Side[] sides2 = this.scenario_0.GetSides();
				for (int i = 0; i < sides2.Length; i++)
				{
					Side side2 = sides2[i];
					if (Operators.CompareString(side2.GetSideName(), this.comboBox_0.SelectedItem.ToString(), false) == 0)
					{
						side = side2;
						break;
					}
				}
			}
			else
			{
				side = this.list_0[0];
				this.comboBox_0.Enabled = false;
				this.label_0.Enabled = false;
				this.comboBox_0.Items.Add(this.list_0[0].GetSideName());
				this.comboBox_0.SelectedIndex = 0;
			}
			Side[] sides3 = this.scenario_0.GetSides();
			for (int j = 0; j < sides3.Length; j++)
			{
				Side side3 = sides3[j];
				if (Operators.CompareString(side3.GetSideName(), this.comboBox_0.SelectedItem.ToString(), false) == 0)
				{
					side = side3;
					break;
				}
			}
			if (!Information.IsNothing(side) && !string.IsNullOrEmpty(side.Briefing) && !this.method_3(this.webBrowser_0, side.Briefing.ToString(), Path.GetDirectoryName(this.string_0)))
			{
				Class2529.smethod_7(this.webBrowser_0, side.Briefing.ToString(), default(Color));
			}
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x001F1A0C File Offset: 0x001EFC0C
//		[CompilerGenerated]
//		internal  Label vmethod_0()
//		{
//			return this.label_0;
//		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x00024B35 File Offset: 0x00022D35
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_1(Label label_2)
//		{
//			this.label_0 = label_2;
//		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x001F1A24 File Offset: 0x001EFC24
//		[CompilerGenerated]
//		internal  ComboBox vmethod_2()
//		{
//			return this.comboBox_0;
//		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x001F1A3C File Offset: 0x001EFC3C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_3(ComboBox comboBox_1)
//		{
//			EventHandler value = new EventHandler(this.method_4);
//			ComboBox comboBox = this.comboBox_0;
//			if (comboBox != null)
//			{
//				comboBox.SelectionChangeCommitted -= value;
//			}
//			this.comboBox_0 = comboBox_1;
//			comboBox = this.comboBox_0;
//			if (comboBox != null)
//			{
//				comboBox.SelectionChangeCommitted += value;
//			}
//		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x001F1A88 File Offset: 0x001EFC88
//		[CompilerGenerated]
//		internal  Label vmethod_4()
//		{
//			return this.label_1;
//		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x00024B3E File Offset: 0x00022D3E
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_5(Label label_2)
//		{
//			this.label_1 = label_2;
//		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x001F1AA0 File Offset: 0x001EFCA0
//		[CompilerGenerated]
//		internal  Button vmethod_6()
//		{
//			return this.button_0;
//		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x001F1AB8 File Offset: 0x001EFCB8
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_7(Button button_2)
//		{
//			EventHandler value = new EventHandler(this.method_1);
//			Button button = this.button_0;
//			if (button != null)
//			{
//				button.Click -= value;
//			}
//			this.button_0 = button_2;
//			button = this.button_0;
//			if (button != null)
//			{
//				button.Click += value;
//			}
//		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x001F1B04 File Offset: 0x001EFD04
//		[CompilerGenerated]
//		internal  Button vmethod_8()
//		{
//			return this.button_1;
//		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x001F1B1C File Offset: 0x001EFD1C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_9(Button button_2)
//		{
//			EventHandler value = new EventHandler(this.method_5);
//			Button button = this.button_1;
//			if (button != null)
//			{
//				button.Click -= value;
//			}
//			this.button_1 = button_2;
//			button = this.button_1;
//			if (button != null)
//			{
//				button.Click += value;
//			}
//		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x001F1B68 File Offset: 0x001EFD68
//		[CompilerGenerated]
//		internal  WebBrowser vmethod_10()
//		{
//			return this.webBrowser_0;
//		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x00024B47 File Offset: 0x00022D47
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_11(WebBrowser webBrowser_1)
//		{
//			this.webBrowser_0 = webBrowser_1;
//		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x001F1B80 File Offset: 0x001EFD80
		private void method_1(object sender, EventArgs e)
		{
			try
			{
				this.method_2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox("A problem occured while loading the selected scenario. Please select another scenario to load.", MsgBoxStyle.OkOnly, "Problem in loading scenario!");
				CommandFactory.GetCommandMain().GetStartGame().Show();
				base.Close();

                ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x001F1BDC File Offset: 0x001EFDDC
		private void method_2()
		{
			Side[] sides = this.scenario_0.GetSides();
			for (int i = 0; i < sides.Length; i++)
			{
				Side side = sides[i];
				if (Operators.CompareString(side.GetSideName(), this.comboBox_0.SelectedItem.ToString(), false) == 0)
				{
					this.scenario_0.ChangeSide(side);
					break;
				}
			}
			Client.SetClientScenario(this.scenario_0, false);
			if (!Information.IsNothing(Client.GetClientSide()))
			{
				CommandFactory.GetCommandMain().GetMainForm().method_14(true, Client.GetClientSide().GetMapCenter());
				CommandFactory.GetCommandMain().GetMainForm().method_6((int)Math.Round(Client.GetClientSide().CameraAlt));
			}
			else
			{
				CommandFactory.GetCommandMain().GetMainForm().method_6(3000000);
			}
			Client.GetConfiguration().SetSimStopMode();
			Client.b_Completed = true;
			CommandFactory.GetCommandMain().GetMainForm().method_156();
			CommandFactory.GetCommandMain().GetMainForm().method_161();
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			CommandFactory.GetCommandMain().GetMainForm().MapBoxResize();
			if (Client.GetClientScenario().LastSavedInScenEdit)
			{
				CommandFactory.GetCommandMain().GetRealismDialog().method_0(Client.GetClientScenario());
				CommandFactory.GetCommandMain().GetRealismDialog().Show();
			}
			base.Close();
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x001F1D2C File Offset: 0x001EFF2C
		private bool method_3(WebBrowser webBrowser_1, string string_1, string string_2)
		{
			bool result;
			bool flag;
			if (string_1.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_1, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_1, "[/LOADDOC]", CompareMethod.Binary);
				string path;
				try
				{
					path = string_1.Substring(num, string_1.Length - num - (string_1.Length - num2 + 1));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					result = false;
					return result;
				}
				if (File.Exists(Path.Combine(string_2, path)))
				{
					webBrowser_1.Navigate(Path.Combine(string_2, path));
					flag = true;
				}
				else
				{
					string campaignID = this.scenario_0.CampaignID;
					Campaign campaign = Campaign.smethod_2(GameGeneral.strScenariosDir, campaignID);
					if (!Information.IsNothing(campaign))
					{
						webBrowser_1.Navigate(Path.Combine(campaign.campaignDir, path));
						flag = true;
					}
					else
					{
						flag = false;
					}
				}
			}
			else
			{
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x001F1E24 File Offset: 0x001F0024
		private void method_4(object sender, EventArgs e)
		{
			Side side = this.list_0[this.comboBox_0.SelectedIndex];
			if (!string.IsNullOrEmpty(side.Briefing) && !this.method_3(this.webBrowser_0, side.Briefing.ToString(), Path.GetDirectoryName(this.string_0)))
			{
				Class2529.smethod_7(this.webBrowser_0, side.Briefing.ToString(), default(Color));
			}
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x0001FAC2 File Offset: 0x0001DCC2
		private void method_5(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetStartGame().Show();
			base.Close();
		}

		// Token: 0x04002497 RID: 9367
		public static Func<Side, bool> SideFunc = (Side side_0) => !side_0.IsAIOnly();

		// Token: 0x04002499 RID: 9369
		public Scenario scenario_0;

		// Token: 0x0400249A RID: 9370
		public string string_0;

		// Token: 0x0400249B RID: 9371
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x0400249C RID: 9372
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x0400249D RID: 9373
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x0400249E RID: 9374
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x0400249F RID: 9375
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x040024A0 RID: 9376
		[CompilerGenerated]
		private WebBrowser webBrowser_0;

		// Token: 0x040024A1 RID: 9377
		private List<Side> list_0;
	}
}

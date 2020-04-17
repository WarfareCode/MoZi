using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns2;
using ns3;
using ns32;
using ns33;
using ns34;
using ns35;

namespace Command
{
	// 载入想定
	[DesignerGenerated]
	public sealed partial class LoadScenario : CommandForm
	{
		// Token: 0x06004DE5 RID: 19941 RVA: 0x001F469C File Offset: 0x001F289C
		public LoadScenario()
		{
			base.FormClosing += new FormClosingEventHandler(this.LoadScenario_FormClosing);
			base.Load += new EventHandler(this.LoadScenario_Load);
			base.KeyDown += new KeyEventHandler(this.LoadScenario_KeyDown);
			base.FormClosed += new FormClosedEventHandler(this.LoadScenario_FormClosed);
			this.vmethod_37(new BackgroundWorker());
			this.vmethod_39(new BackgroundWorker());
			this.InitializeComponent();
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x001F5260 File Offset: 0x001F3460
		[CompilerGenerated]
		internal  Button GetButton_LoadSelected()
		{
			return this.Button_LoadSelected;
		}

		// Token: 0x06004DE9 RID: 19945 RVA: 0x001F5278 File Offset: 0x001F3478
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_LoadSelected(Button button_2)
		{
			EventHandler value = new EventHandler(this.Button_LoadSelected_Click);
			Button button_LoadSelected = this.Button_LoadSelected;
			if (button_LoadSelected != null)
			{
				button_LoadSelected.Click -= value;
			}
			this.Button_LoadSelected = button_2;
			button_LoadSelected = this.Button_LoadSelected;
			if (button_LoadSelected != null)
			{
				button_LoadSelected.Click += value;
			}
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x001F52C4 File Offset: 0x001F34C4
		[CompilerGenerated]
		internal  TreeView vmethod_2()
		{
			return this.treeView_0;
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x001F52DC File Offset: 0x001F34DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TreeView treeView_2)
		{
			TreeViewEventHandler value = new TreeViewEventHandler(this.method_7);
			TreeViewCancelEventHandler value2 = new TreeViewCancelEventHandler(this.method_10);
			TreeView treeView = this.treeView_0;
			if (treeView != null)
			{
				treeView.AfterSelect -= value;
				treeView.BeforeExpand -= value2;
			}
			this.treeView_0 = treeView_2;
			treeView = this.treeView_0;
			if (treeView != null)
			{
				treeView.AfterSelect += value;
				treeView.BeforeExpand += value2;
			}
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x001F5340 File Offset: 0x001F3540
		[CompilerGenerated]
		internal  TabControl vmethod_4()
		{
			return this.tabControl_0;
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x00024D14 File Offset: 0x00022F14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TabControl tabControl_1)
		{
			this.tabControl_0 = tabControl_1;
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x001F5358 File Offset: 0x001F3558
		[CompilerGenerated]
		internal  TabPage vmethod_6()
		{
			return this.tabPage_0;
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x00024D1D File Offset: 0x00022F1D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TabPage tabPage_2)
		{
			this.tabPage_0 = tabPage_2;
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x001F5370 File Offset: 0x001F3570
		[CompilerGenerated]
		internal  TabPage vmethod_8()
		{
			return this.tabPage_1;
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x00024D26 File Offset: 0x00022F26
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TabPage tabPage_2)
		{
			this.tabPage_1 = tabPage_2;
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x001F5388 File Offset: 0x001F3588
		[CompilerGenerated]
		internal  TreeView vmethod_10()
		{
			return this.treeView_1;
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x001F53A0 File Offset: 0x001F35A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TreeView treeView_2)
		{
			TreeViewEventHandler value = new TreeViewEventHandler(this.method_8);
			TreeViewCancelEventHandler value2 = new TreeViewCancelEventHandler(this.method_11);
			TreeView treeView = this.treeView_1;
			if (treeView != null)
			{
				treeView.AfterSelect -= value;
				treeView.BeforeExpand -= value2;
			}
			this.treeView_1 = treeView_2;
			treeView = this.treeView_1;
			if (treeView != null)
			{
				treeView.AfterSelect += value;
				treeView.BeforeExpand += value2;
			}
		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x001F5404 File Offset: 0x001F3604
		[CompilerGenerated]
		internal  Button vmethod_12()
		{
			return this.button_1;
		}

		// Token: 0x06004DF5 RID: 19957 RVA: 0x001F541C File Offset: 0x001F361C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_9);
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

		// Token: 0x06004DF6 RID: 19958 RVA: 0x001F5468 File Offset: 0x001F3668
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_0;
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x00024D2F File Offset: 0x00022F2F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_6)
		{
			this.label_0 = label_6;
		}

		// Token: 0x06004DF8 RID: 19960 RVA: 0x001F5480 File Offset: 0x001F3680
		[CompilerGenerated]
		internal  ProgressBar vmethod_16()
		{
			return this.progressBar_0;
		}

		// Token: 0x06004DF9 RID: 19961 RVA: 0x00024D38 File Offset: 0x00022F38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(ProgressBar progressBar_3)
		{
			this.progressBar_0 = progressBar_3;
		}

		// Token: 0x06004DFA RID: 19962 RVA: 0x001F5498 File Offset: 0x001F3698
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_1;
		}

		// Token: 0x06004DFB RID: 19963 RVA: 0x00024D41 File Offset: 0x00022F41
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_6)
		{
			this.label_1 = label_6;
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x001F54B0 File Offset: 0x001F36B0
		[CompilerGenerated]
		internal  WebBrowser vmethod_20()
		{
			return this.webBrowser_0;
		}

		// Token: 0x06004DFD RID: 19965 RVA: 0x00024D4A File Offset: 0x00022F4A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(WebBrowser webBrowser_1)
		{
			this.webBrowser_0 = webBrowser_1;
		}

		// Token: 0x06004DFE RID: 19966 RVA: 0x001F54C8 File Offset: 0x001F36C8
		[CompilerGenerated]
		internal  Label vmethod_22()
		{
			return this.label_2;
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x00024D53 File Offset: 0x00022F53
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Label label_6)
		{
			this.label_2 = label_6;
		}

		// Token: 0x06004E00 RID: 19968 RVA: 0x001F54E0 File Offset: 0x001F36E0
		[CompilerGenerated]
		internal  Label vmethod_24()
		{
			return this.label_3;
		}

		// Token: 0x06004E01 RID: 19969 RVA: 0x00024D5C File Offset: 0x00022F5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Label label_6)
		{
			this.label_3 = label_6;
		}

		// Token: 0x06004E02 RID: 19970 RVA: 0x001F54F8 File Offset: 0x001F36F8
		[CompilerGenerated]
		internal  ProgressBar vmethod_26()
		{
			return this.progressBar_1;
		}

		// Token: 0x06004E03 RID: 19971 RVA: 0x00024D65 File Offset: 0x00022F65
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(ProgressBar progressBar_3)
		{
			this.progressBar_1 = progressBar_3;
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x001F5510 File Offset: 0x001F3710
		[CompilerGenerated]
		internal  ProgressBar vmethod_28()
		{
			return this.progressBar_2;
		}

		// Token: 0x06004E05 RID: 19973 RVA: 0x00024D6E File Offset: 0x00022F6E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(ProgressBar progressBar_3)
		{
			this.progressBar_2 = progressBar_3;
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x001F5528 File Offset: 0x001F3728
		[CompilerGenerated]
		internal  Label vmethod_30()
		{
			return this.label_4;
		}

		// Token: 0x06004E07 RID: 19975 RVA: 0x00024D77 File Offset: 0x00022F77
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Label label_6)
		{
			this.label_4 = label_6;
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x001F5540 File Offset: 0x001F3740
		[CompilerGenerated]
		internal  Label vmethod_32()
		{
			return this.label_5;
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x00024D80 File Offset: 0x00022F80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Label label_6)
		{
			this.label_5 = label_6;
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x001F5558 File Offset: 0x001F3758
		[CompilerGenerated]
		internal  ComboBox vmethod_34()
		{
			return this.comboBox_0;
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x001F5570 File Offset: 0x001F3770
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.method_15);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_1;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004E0C RID: 19980 RVA: 0x001F55BC File Offset: 0x001F37BC
		[CompilerGenerated]
		internal  BackgroundWorker vmethod_36()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x001F55D4 File Offset: 0x001F37D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(BackgroundWorker backgroundWorker_2)
		{
			DoWorkEventHandler value = new DoWorkEventHandler(this.LoadScenarioEvent);
			RunWorkerCompletedEventHandler value2 = new RunWorkerCompletedEventHandler(this.method_14);
			BackgroundWorker backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value;
				backgroundWorker.RunWorkerCompleted -= value2;
			}
			this.backgroundWorker_0 = backgroundWorker_2;
			backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value;
				backgroundWorker.RunWorkerCompleted += value2;
			}
		}

		// Token: 0x06004E0E RID: 19982 RVA: 0x001F5638 File Offset: 0x001F3838
		[CompilerGenerated]
		internal  BackgroundWorker vmethod_38()
		{
			return this.backgroundWorker_1;
		}

		// Token: 0x06004E0F RID: 19983 RVA: 0x001F5650 File Offset: 0x001F3850
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(BackgroundWorker backgroundWorker_2)
		{
			DoWorkEventHandler value = new DoWorkEventHandler(this.method_16);
			RunWorkerCompletedEventHandler value2 = new RunWorkerCompletedEventHandler(this.method_17);
			BackgroundWorker backgroundWorker = this.backgroundWorker_1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value;
				backgroundWorker.RunWorkerCompleted -= value2;
			}
			this.backgroundWorker_1 = backgroundWorker_2;
			backgroundWorker = this.backgroundWorker_1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value;
				backgroundWorker.RunWorkerCompleted += value2;
			}
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x001F56B4 File Offset: 0x001F38B4
		private bool method_1(WebBrowser webBrowser_1, string string_3, string string_4)
		{
			bool result;
			if (string.IsNullOrEmpty(string_3))
			{
				result = false;
			}
			else if (string_3.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_3, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_3, "[/LOADDOC]", CompareMethod.Binary);
				string path = string_3.Substring(num, string_3.Length - num - (string_3.Length - num2 + 1));
				if (File.Exists(Path.Combine(string_4, path)))
				{
					webBrowser_1.Navigate(Path.Combine(string_4, path));
					result = true;
				}
				else
				{
					string string_5 = Scenario.XmlReaderSting(this.scenContainer_0.method_9(), "CampaignID");
					Campaign campaign = Campaign.smethod_2(GameGeneral.strScenariosDir, string_5);
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

		// 载入所选想定按钮
		private void Button_LoadSelected_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.scenContainer_0))
			{
				base.Enabled = false;
				if (CommandFactory.GetCommandMain().GetStartGame().Visible)
				{
					CommandFactory.GetCommandMain().GetStartGame().Close();
				}
				if (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Run)
				{
					Client.GetConfiguration().SetSimStopMode();
				}
				this.bool_0 = false;
				this.scenario_0 = null;
				this.vmethod_36().RunWorkerAsync();
				this.vmethod_18().Visible = true;
				this.vmethod_16().Visible = true;
				while (this.vmethod_36().IsBusy)
				{
					Application.DoEvents();
					this.vmethod_16().Value = (int)Math.Round(this.double_0 * 100.0);
					Thread.Sleep(50);
				}
				if (!Information.IsNothing(this.scenario_0))
				{
					Client.CheckScenario(this.scenario_0, this.string_0);
					base.Close();
				}
				base.Enabled = true;
				this.vmethod_18().Visible = false;
				this.vmethod_16().Visible = false;
			}
		}

		// Token: 0x06004E12 RID: 19986 RVA: 0x001F58AC File Offset: 0x001F3AAC
		private List<string> method_3(IEnumerable<string> ienumerable_0)
		{
			List<string> result = new List<string>();
			switch (this.vmethod_34().SelectedIndex)
			{
			case 0:
				result = ienumerable_0.OrderBy(LoadScenario.stringFunc0, new ns3.StringComparer()).ToList<string>();
				break;
			case 1:
				result = ienumerable_0.OrderBy(LoadScenario.stringFunc1).ToList<string>();
				break;
			case 2:
				result = ienumerable_0.OrderBy(LoadScenario.stringFunc2).ToList<string>();
				break;
			case 3:
				result = ienumerable_0.OrderBy(LoadScenario.stringFunc3).ToList<string>();
				break;
			}
			return result;
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x001F5938 File Offset: 0x001F3B38
		private void method_4()
		{
			this.vmethod_2().Nodes.Clear();
			string[] directories = Directory.GetDirectories(GameGeneral.strScenariosDir);
			checked
			{
				for (int i = 0; i < directories.Length; i++)
				{
					string text = directories[i];
					if (this.method_6(text))
					{
						TreeNode treeNode = this.vmethod_2().Nodes.Add(Path.GetFileName(text));
						treeNode.Tag = text;
						if (Directory.GetDirectories(text).Count<string>() > 0 | Directory.GetFiles(text).Count<string>() > 0)
						{
							treeNode.Nodes.Add("virtual");
						}
					}
				}
				List<string> ienumerable_ = this.method_3(Directory.GetFiles(GameGeneral.strScenariosDir).Where(LoadScenario.stringFunc4));
				List<string> list = this.method_3(ienumerable_);
				foreach (string current in list)
				{
					TreeNode treeNode = this.vmethod_2().Nodes.Add(Path.GetFileName(current));
					treeNode.Tag = current;
				}
			}
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x001F5A54 File Offset: 0x001F3C54
		private void method_5()
		{
			this.vmethod_10().Nodes.Clear();
			string[] directories = Directory.GetDirectories(GameGeneral.strScenariosDir);
			checked
			{
				for (int i = 0; i < directories.Length; i++)
				{
					string text = directories[i];
					if (this.method_6(text))
					{
						TreeNode treeNode = this.vmethod_10().Nodes.Add(Path.GetFileName(text));
						treeNode.Tag = text;
						if (Directory.GetDirectories(text).Count<string>() > 0 | Directory.GetFiles(text).Count<string>() > 0)
						{
							treeNode.Nodes.Add("virtual");
						}
					}
				}
				List<string> list = this.method_3(Directory.GetFiles(GameGeneral.strScenariosDir).Where(LoadScenario.stringFunc5));
				foreach (string current in list)
				{
					this.string_1 = Path.GetFileName(current);
					this.fileInfo_0 = new FileInfo(current);
					this.string_1 = string.Concat(new string[]
					{
						"[",
						this.fileInfo_0.LastWriteTime.ToShortDateString(),
						" ",
						this.fileInfo_0.LastWriteTime.ToShortTimeString(),
						"] ",
						this.string_1
					});
					TreeNode treeNode = this.vmethod_10().Nodes.Add(this.string_1);
					treeNode.Tag = current;
				}
			}
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x001F5BF0 File Offset: 0x001F3DF0
		private bool method_6(string string_3)
		{
			string[] files = Directory.GetFiles(string_3);
			checked
			{
				bool result;
				for (int i = 0; i < files.Length; i++)
				{
					string text = files[i];
					if (text.EndsWith(".scen") || text.EndsWith(".save"))
					{
						result = true;
						return result;
					}
				}
				string[] directories = Directory.GetDirectories(string_3);
				for (int j = 0; j < directories.Length; j++)
				{
					string string_4 = directories[j];
					if (this.method_6(string_4))
					{
						result = true;
						return result;
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x00020C50 File Offset: 0x0001EE50
		private void LoadScenario_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x001F5C74 File Offset: 0x001F3E74
		private void LoadScenario_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			CommandFactory.GetCommandMain().GetMainForm().Enabled = false;
			this.vmethod_34().SelectedIndex = 0;
			this.vmethod_18().Visible = false;
			this.vmethod_16().Visible = false;
			this.vmethod_4().SelectedIndex = (int)this.enum188_0;
			this.method_4();
			this.method_5();
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x001F5CEC File Offset: 0x001F3EEC
		private void method_7(object sender, TreeViewEventArgs e)
		{
			string text = e.Node.Tag.ToString();
			if (Directory.Exists(text))
			{
				this.vmethod_14().Visible = false;
				this.vmethod_22().Visible = false;
				this.vmethod_26().Visible = false;
				this.vmethod_24().Visible = false;
				this.vmethod_28().Visible = false;
				this.vmethod_30().Visible = false;
				this.vmethod_20().Visible = false;
			}
			else if (File.Exists(text))
			{
				this.vmethod_14().Visible = true;
				this.vmethod_22().Visible = true;
				this.vmethod_26().Visible = true;
				this.vmethod_24().Visible = true;
				this.vmethod_28().Visible = true;
				this.vmethod_30().Visible = true;
				this.vmethod_20().Visible = true;
				try
				{
					Scenario clientScenario = Client.GetClientScenario();
					GameGeneral.ClearActiveUnits(ref clientScenario);
					this.scenContainer_0 = ScenContainer.smethod_2(text);
					GameGeneral.ClearScenarioStreamDictionary();
					this.string_0 = e.Node.Tag.ToString();
					if (!this.method_1(this.vmethod_20(), this.scenContainer_0.ScenDescription, Path.GetDirectoryName(this.string_0)))
					{
						Class2529.smethod_7(this.vmethod_20(), this.scenContainer_0.ScenDescription, default(Color));
					}
					this.vmethod_14().Text = "想定名称："+ this.scenContainer_0.ScenTitle;
					this.vmethod_14().ForeColor = Color.Black;
					if (!this.vmethod_38().IsBusy)
					{
						this.vmethod_38().RunWorkerAsync();
					}
					this.vmethod_26().Value = (int)(20 * this.scenContainer_0.Difficulty);
					this.vmethod_28().Value = (int)(20 * this.scenContainer_0.Complexity);
					this.vmethod_30().Text = "";
					if (!string.IsNullOrEmpty(this.scenContainer_0.ScenSetting))
					{
						this.vmethod_30().Text = "地点:" + this.scenContainer_0.ScenSetting;
					}
					if (!string.IsNullOrEmpty(this.scenContainer_0.ScenSetting) && !string.IsNullOrEmpty(Conversions.ToString((int)this.scenContainer_0.ScenDate)))
					{
						this.vmethod_30().Text = this.vmethod_30().Text + "  --  ";
					}
					if (!string.IsNullOrEmpty(Conversions.ToString((int)this.scenContainer_0.ScenDate)))
					{
						this.vmethod_30().Text = this.vmethod_30().Text + "年份: " + Conversions.ToString((int)this.scenContainer_0.ScenDate);
					}
					if (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit)
					{
						Client.string_3 = text;
					}
					else
					{
						Client.string_3 = null;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					this.vmethod_14().Text = "Error!";
					Class2529.smethod_7(this.vmethod_20(), string.Concat(new string[]
					{
						"ERROR - Unable to load scenario! Please copy this entire text and submit it to the dev team for investigation. \r\n\r\nException: ",
						ex2.Message,
						"\r\n\r\nException source: ",
						ex2.Source,
						"\r\n\r\nStack Trace:\r\n",
						ex2.StackTrace
					}), default(Color));
					this.vmethod_14().ForeColor = Color.Red;
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x001F6060 File Offset: 0x001F4260
		private void method_8(object sender, TreeViewEventArgs e)
		{
			string text = e.Node.Tag.ToString();
			if (Directory.Exists(text))
			{
				this.vmethod_14().Visible = false;
				this.vmethod_22().Visible = false;
				this.vmethod_26().Visible = false;
				this.vmethod_24().Visible = false;
				this.vmethod_28().Visible = false;
				this.vmethod_30().Visible = false;
				this.vmethod_20().Visible = false;
			}
			else if (File.Exists(text))
			{
				this.vmethod_14().Visible = true;
				this.vmethod_22().Visible = true;
				this.vmethod_26().Visible = true;
				this.vmethod_24().Visible = true;
				this.vmethod_28().Visible = true;
				this.vmethod_30().Visible = true;
				this.vmethod_20().Visible = true;
				try
				{
					Scenario clientScenario = Client.GetClientScenario();
					GameGeneral.ClearActiveUnits(ref clientScenario);
					ScenContainer scenContainer = ScenContainer.smethod_2(text);
					this.scenContainer_0 = scenContainer;
					GameGeneral.ClearScenarioStreamDictionary();
					this.string_0 = e.Node.Tag.ToString();
					if (!this.method_1(this.vmethod_20(), this.scenContainer_0.ScenDescription, Path.GetDirectoryName(this.string_0)))
					{
						Class2529.smethod_7(this.vmethod_20(), this.scenContainer_0.ScenDescription, default(Color));
					}
					if (!Information.IsNothing(scenContainer.ScenTitle))
					{
						this.vmethod_14().Text = scenContainer.ScenTitle;
					}
					else
					{
						this.vmethod_14().Text = Path.GetFileNameWithoutExtension(text);
					}
					this.vmethod_14().ForeColor = Color.Black;
					if (!this.vmethod_38().IsBusy)
					{
						this.vmethod_38().RunWorkerAsync();
					}
					this.vmethod_26().Value = (int)(20 * scenContainer.Difficulty);
					this.vmethod_28().Value = (int)(20 * scenContainer.Complexity);
					this.vmethod_30().Text = "";
					if (!string.IsNullOrEmpty(scenContainer.ScenSetting))
					{
						this.vmethod_30().Text = "地点:" + scenContainer.ScenSetting;
					}
					if (!string.IsNullOrEmpty(scenContainer.ScenSetting) && !string.IsNullOrEmpty(Conversions.ToString((int)scenContainer.ScenDate)))
					{
						this.vmethod_30().Text = this.vmethod_30().Text + "  --  ";
					}
					if (!string.IsNullOrEmpty(Conversions.ToString((int)scenContainer.ScenDate)))
					{
						this.vmethod_30().Text = this.vmethod_30().Text + "年份: " + Conversions.ToString((int)this.scenContainer_0.ScenDate);
					}
					Client.string_3 = text;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					this.vmethod_14().Text = "Error!";
					Class2529.smethod_7(this.vmethod_20(), string.Concat(new string[]
					{
						"ERROR - Unable to load scenario! Please copy this entire text and submit to the dev team.\r\n\r\nException: ",
						ex2.Message,
						"\r\n\r\nException source: ",
						ex2.Source,
						"\r\n\r\nStack Trace:\r\n",
						ex2.StackTrace
					}), default(Color));
					this.vmethod_14().ForeColor = Color.Red;
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x00024D89 File Offset: 0x00022F89
		private void method_9(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			base.Close();
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x00024DA1 File Offset: 0x00022FA1
		private void method_10(object sender, TreeViewCancelEventArgs e)
		{
			this.method_12(e.Node);
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x00024DA1 File Offset: 0x00022FA1
		private void method_11(object sender, TreeViewCancelEventArgs e)
		{
			this.method_12(e.Node);
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x001F63B4 File Offset: 0x001F45B4
		private void method_12(TreeNode treeNode_0)
		{
			LoadScenario.Class2520 @class = new LoadScenario.Class2520(null);
			treeNode_0.Nodes.Clear();
			string path = treeNode_0.Tag.ToString();
			@class.string_0 = "";
			int selectedIndex = this.vmethod_4().SelectedIndex;
			if (selectedIndex != 0)
			{
				if (selectedIndex != 1)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				else
				{
					@class.string_0 = ".save";
				}
			}
			else
			{
				@class.string_0 = ".scen";
			}
			List<string> list = Directory.GetDirectories(path).OrderBy(LoadScenario.stringFunc6, new ns3.StringComparer()).ToList<string>();
			foreach (string current in list)
			{
				if (this.method_6(current))
				{
					TreeNode treeNode = treeNode_0.Nodes.Add(Path.GetFileName(current));
					treeNode.Tag = current;
					if (Directory.GetDirectories(current).Count<string>() > 0 | Directory.GetFiles(current).Count<string>() > 0)
					{
						treeNode.Nodes.Add("virtual");
					}
				}
			}
			List<string> list2 = this.method_3(Directory.GetFiles(path).Where(new Func<string, bool>(@class.method_0)));
			foreach (string current2 in list2)
			{
				this.string_1 = Path.GetFileName(current2);
				if (Operators.CompareString(@class.string_0, ".save", false) == 0)
				{
					this.fileInfo_0 = new FileInfo(current2);
					this.string_1 = string.Concat(new string[]
					{
						"[",
						this.fileInfo_0.LastWriteTime.ToShortDateString(),
						" ",
						this.fileInfo_0.LastWriteTime.ToShortTimeString(),
						"] ",
						this.string_1
					});
				}
				TreeNode treeNode = treeNode_0.Nodes.Add(this.string_1);
				treeNode.Tag = current2;
			}
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x001F65FC File Offset: 0x001F47FC
		private void LoadScenarioEvent(object sender, DoWorkEventArgs e)
		{
			try
			{
				string text = this.scenContainer_0.method_9();
				this.string_2 = Scenario.XmlReaderSting(text, "ContentTag");
				if (string.IsNullOrEmpty(this.string_2))
				{
					this.string_2 = "";
				}
				if (!LicenseChecker.smethod_20(this.string_2))
				{
					this.bool_1 = false;
				}
				else
				{
					this.bool_1 = true;
					Scenario scenario = Scenario.LoadScenario(text, ref Client.string_2, ref this.double_0, false);
					Client.SetNavigationOptions(ref scenario);
					if (scenario.GetScenAttachments().Count > 0)
					{
						ScenarioCompressor.smethod_1(scenario, this.string_0);
					}
					this.scenario_0 = scenario;
				}
			}
			catch (Exception1 exception)
			{
				ProjectData.SetProjectError(exception);
				Exception1 exception2 = exception;
				Interaction.MsgBox(exception2.Message, MsgBoxStyle.OkOnly, null);
				this.bool_1 = true;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
				ex2.Data.Add("Error at 101159", "");
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				this.bool_1 = true;
				throw;
			}
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x001F672C File Offset: 0x001F492C
		private void method_14(object sender, RunWorkerCompletedEventArgs e)
		{
			if (!this.bool_1)
			{
				if (string.IsNullOrEmpty(this.string_2))
				{
					CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CMANOBase;
				}
				else
				{
					string left = this.string_2.ToString();
					uint num = Class2541.smethod_0(left);
					if (num <= 1947498037u)
					{
						if (num != 840819822u)
						{
							if (num != 1400166703u)
							{
								if (num == 1947498037u && Operators.CompareString(left, "BREXIT", false) == 0)
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
							else if (Operators.CompareString(left, "TUTORIAL", false) == 0)
							{
								CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CMANOBase;
							}
						}
						else if (Operators.CompareString(left, "DON", false) == 0)
						{
							if (LicenseChecker.smethod_20(""))
							{
								CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CLIVE4;
							}
							else
							{
								CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CMANOBase;
							}
						}
					}
					else if (num <= 2651058615u)
					{
						if (num != 2617503377u)
						{
							if (num == 2651058615u && Operators.CompareString(left, "CLIVE5", false) == 0)
							{
								if (LicenseChecker.smethod_20(""))
								{
									CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CLIVE5;
								}
								else
								{
									CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CMANOBase;
								}
							}
						}
						else if (Operators.CompareString(left, "CLIVE3", false) == 0)
						{
							if (LicenseChecker.smethod_20(""))
							{
								CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CLIVE3;
							}
							else
							{
								CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CMANOBase;
							}
						}
					}
					else if (num != 2785588663u)
					{
						if (num == 3459788944u && Operators.CompareString(left, "NINFERNO", false) == 0)
						{
							CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.NorthernInferno;
						}
					}
					else if (Operators.CompareString(left, "OLDGRUDGES", false) == 0)
					{
						if (LicenseChecker.smethod_20(""))
						{
							CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CLIVE1;
						}
						else
						{
							CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().license = LicenseChecker.License.CMANOBase;
						}
					}
				}
				CommandFactory.GetCommandMain().GetInsufficientLicenseWindow().Show();
			}
			else
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		private void LoadScenario_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x001F69E0 File Offset: 0x001F4BE0
		private void method_15(object sender, EventArgs e)
		{
			LoadScenario.Class2521 @class = new LoadScenario.Class2521(null);
			List<TreeNode> list = new List<TreeNode>();
			@class.string_0 = "";
			TreeView treeView = null;
			int selectedIndex = this.vmethod_4().SelectedIndex;
			if (selectedIndex != 0)
			{
				if (selectedIndex != 1)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				else
				{
					treeView = this.vmethod_10();
					@class.string_0 = ".save";
				}
			}
			else
			{
				treeView = this.vmethod_2();
				@class.string_0 = ".scen";
			}
			list = Class2529.smethod_5(treeView).ToList<TreeNode>();
			foreach (TreeNode current in list)
			{
				if (current.IsExpanded)
				{
					this.method_12(current);
				}
			}
			List<TreeNode> list2 = new List<TreeNode>();
			IEnumerator enumerator2 = treeView.Nodes.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator2.Current;
					if (treeNode.Nodes.Count == 0)
					{
						list2.Add(treeNode);
					}
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			foreach (TreeNode current2 in list2)
			{
				treeView.Nodes.Remove(current2);
			}
			List<string> list3 = this.method_3(Directory.GetFiles(Application.StartupPath + "\\Scenarios\\").Where(new Func<string, bool>(@class.method_0)));
			foreach (string current3 in list3)
			{
				this.string_1 = Path.GetFileName(current3);
				if (Operators.CompareString(@class.string_0, ".save", false) == 0)
				{
					this.fileInfo_0 = new FileInfo(current3);
					this.string_1 = string.Concat(new string[]
					{
						"[",
						this.fileInfo_0.LastWriteTime.ToShortDateString(),
						" ",
						this.fileInfo_0.LastWriteTime.ToShortTimeString(),
						"] ",
						this.string_1
					});
				}
				treeView.Nodes.Add(this.string_1).Tag = current3;
			}
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x00024DAF File Offset: 0x00022FAF
		private void LoadScenario_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.scenario_0 = null;
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x00024DB8 File Offset: 0x00022FB8
		private void method_16(object sender, DoWorkEventArgs e)
		{
			if (!Information.IsNothing(this.scenContainer_0))
			{
				this.string_2 = Scenario.XmlReaderSting(this.scenContainer_0.method_9(), "ContentTag");
			}
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x00024DE2 File Offset: 0x00022FE2
		private void method_17(object sender, RunWorkerCompletedEventArgs e)
		{
			if (!LicenseChecker.smethod_20(this.string_2))
			{
				this.vmethod_14().Text = "[NOT LICENSED] " + this.scenContainer_0.ScenTitle;
				this.vmethod_14().ForeColor = Color.Red;
			}
		}

		// Token: 0x040024C6 RID: 9414
		public static Func<string, string> stringFunc0 = (string string_0) => string_0;

		// Token: 0x040024C7 RID: 9415
		public static Func<string, string> stringFunc1 = (string string_0) => ScenContainer.smethod_1(string_0, "ScenDate");

		// Token: 0x040024C8 RID: 9416
		public static Func<string, string> stringFunc2 = (string string_0) => ScenContainer.smethod_1(string_0, "Difficulty");

		// Token: 0x040024C9 RID: 9417
		public static Func<string, string> stringFunc3 = (string string_0) => ScenContainer.smethod_1(string_0, "Complexity");

		// Token: 0x040024CA RID: 9418
		public static Func<string, bool> stringFunc4 = (string string_0) => Operators.CompareString(Path.GetExtension(string_0), ".scen", false) == 0;

		// Token: 0x040024CB RID: 9419
		public static Func<string, bool> stringFunc5 = (string string_0) => Operators.CompareString(Path.GetExtension(string_0), ".save", false) == 0;

		// Token: 0x040024CC RID: 9420
		public static Func<string, string> stringFunc6 = (string string_0) => string_0;

		// Token: 0x040024CE RID: 9422
		[CompilerGenerated]
		private Button Button_LoadSelected;

		// Token: 0x040024CF RID: 9423
		[CompilerGenerated]
		private TreeView treeView_0;

		// Token: 0x040024D0 RID: 9424
		[CompilerGenerated]
		private TabControl tabControl_0;

		// Token: 0x040024D1 RID: 9425
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x040024D2 RID: 9426
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x040024D3 RID: 9427
		[CompilerGenerated]
		private TreeView treeView_1;

		// Token: 0x040024D4 RID: 9428
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x040024D5 RID: 9429
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x040024D6 RID: 9430
		[CompilerGenerated]
		private ProgressBar progressBar_0;

		// Token: 0x040024D7 RID: 9431
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x040024D8 RID: 9432
		[CompilerGenerated]
		private WebBrowser webBrowser_0;

		// Token: 0x040024D9 RID: 9433
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x040024DA RID: 9434
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x040024DB RID: 9435
		[CompilerGenerated]
		private ProgressBar progressBar_1;

		// Token: 0x040024DC RID: 9436
		[CompilerGenerated]
		private ProgressBar progressBar_2;

		// Token: 0x040024DD RID: 9437
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x040024DE RID: 9438
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x040024DF RID: 9439
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x040024E0 RID: 9440
		private string string_0;

		// Token: 0x040024E1 RID: 9441
		public LoadScenario.Enum188 enum188_0;

		// Token: 0x040024E2 RID: 9442
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x040024E3 RID: 9443
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_1;

		// Token: 0x040024E4 RID: 9444
		private Scenario scenario_0;

		// Token: 0x040024E5 RID: 9445
		private bool bool_0;

		// Token: 0x040024E6 RID: 9446
		private double double_0;

		// Token: 0x040024E7 RID: 9447
		private bool bool_1;

		// Token: 0x040024E8 RID: 9448
		private string string_1;

		// Token: 0x040024E9 RID: 9449
		private FileInfo fileInfo_0;

		// Token: 0x040024EA RID: 9450
		private ScenContainer scenContainer_0;

		// Token: 0x040024EB RID: 9451
		private string string_2 = "";

		// Token: 0x02000A05 RID: 2565
		public enum Enum188 : byte
		{
			// Token: 0x040024F4 RID: 9460
			const_0,
			// Token: 0x040024F5 RID: 9461
			const_1
		}

		// Token: 0x02000A06 RID: 2566
		[CompilerGenerated]
		public sealed class Class2520
		{
			// Token: 0x06004E2D RID: 20013 RVA: 0x00024E4D File Offset: 0x0002304D
			public Class2520(LoadScenario.Class2520 class2520_0)
			{
				if (class2520_0 != null)
				{
					this.string_0 = class2520_0.string_0;
				}
			}

			// Token: 0x06004E2E RID: 20014 RVA: 0x00024E67 File Offset: 0x00023067
			internal bool method_0(string string_1)
			{
				return Operators.CompareString(Path.GetExtension(string_1), this.string_0, false) == 0;
			}

			// Token: 0x040024F6 RID: 9462
			public string string_0;
		}

		// Token: 0x02000A07 RID: 2567
		[CompilerGenerated]
		public sealed class Class2521
		{
			// Token: 0x06004E2F RID: 20015 RVA: 0x00024E7E File Offset: 0x0002307E
			public Class2521(LoadScenario.Class2521 class2521_0)
			{
				if (class2521_0 != null)
				{
					this.string_0 = class2521_0.string_0;
				}
			}

			// Token: 0x06004E30 RID: 20016 RVA: 0x00024E98 File Offset: 0x00023098
			internal bool method_0(string string_1)
			{
				return Operators.CompareString(Path.GetExtension(string_1), this.string_0, false) == 0;
			}

			// Token: 0x040024F7 RID: 9463
			public string string_0;
		}
	}
}

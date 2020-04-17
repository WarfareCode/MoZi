using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AdvancedDataGridView;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns2;
using ns29;
using ns32;
using ns33;
using ns34;
using ns35;
using ns4;

namespace Command
{
	// Token: 0x0200097A RID: 2426
	[DesignerGenerated]
	public sealed partial class CampaignPlayWindow : CommandForm
	{
		// Token: 0x06003C01 RID: 15361 RVA: 0x0001FA1C File Offset: 0x0001DC1C
		public CampaignPlayWindow()
		{
			base.FormClosed += new FormClosedEventHandler(this.CampaignPlayWindow_FormClosed);
			base.Load += new EventHandler(this.CampaignPlayWindow_Load);
			this.InitializeComponent();
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x0012A4FC File Offset: 0x001286FC
//		[CompilerGenerated]
//		internal  WebBrowser vmethod_0()
//		{
//			return this.webBrowser_0;
//		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x0001FA4E File Offset: 0x0001DC4E
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_1(WebBrowser webBrowser_1)
//		{
//			this.webBrowser_0 = webBrowser_1;
//		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x0012A514 File Offset: 0x00128714
//		[CompilerGenerated]
//		internal  Button vmethod_2()
//		{
//			return this.button_0;
//		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x0012A52C File Offset: 0x0012872C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_3(Button button_5)
//		{
//			EventHandler value = new EventHandler(this.method_3);
//			Button button = this.button_0;
//			if (button != null)
//			{
//				button.Click -= value;
//			}
//			this.button_0 = button_5;
//			button = this.button_0;
//			if (button != null)
//			{
//				button.Click += value;
//			}
//		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x0012A578 File Offset: 0x00128778
//		[CompilerGenerated]
//		internal  TabControl vmethod_4()
//		{
//			return this.tabControl_0;
//		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x0001FA57 File Offset: 0x0001DC57
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_5(TabControl tabControl_1)
//		{
//			this.tabControl_0 = tabControl_1;
//		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x0012A590 File Offset: 0x00128790
//		[CompilerGenerated]
//		internal  TabPage vmethod_6()
//		{
//			return this.tabPage_0;
//		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x0001FA60 File Offset: 0x0001DC60
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_7(TabPage tabPage_2)
//		{
//			this.tabPage_0 = tabPage_2;
//		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x0012A5A8 File Offset: 0x001287A8
//		[CompilerGenerated]
//		internal  TabPage vmethod_8()
//		{
//			return this.tabPage_1;
//		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x0001FA69 File Offset: 0x0001DC69
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_9(TabPage tabPage_2)
//		{
//			this.tabPage_1 = tabPage_2;
//		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x0012A5C0 File Offset: 0x001287C0
//		[CompilerGenerated]
//		public  TreeGridView vmethod_10()
//		{
//			return this.treeGridView_0;
//		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x0012A5D8 File Offset: 0x001287D8
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		public  void vmethod_11(TreeGridView treeGridView_1)
//		{
//			EventHandler value = new EventHandler(this.method_5);
//			TreeGridView treeGridView = this.treeGridView_0;
//			if (treeGridView != null)
//			{
//				treeGridView.SelectionChanged -= value;
//			}
//			this.treeGridView_0 = treeGridView_1;
//			treeGridView = this.treeGridView_0;
//			if (treeGridView != null)
//			{
//				treeGridView.SelectionChanged += value;
//			}
//		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x0012A624 File Offset: 0x00128824
//		[CompilerGenerated]
//		internal  Button vmethod_12()
//		{
//			return this.button_1;
//		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x0012A63C File Offset: 0x0012883C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_13(Button button_5)
//		{
//			EventHandler value = new EventHandler(this.method_6);
//			Button button = this.button_1;
//			if (button != null)
//			{
//				button.Click -= value;
//			}
//			this.button_1 = button_5;
//			button = this.button_1;
//			if (button != null)
//			{
//				button.Click += value;
//			}
//		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x0012A688 File Offset: 0x00128888
//		[CompilerGenerated]
//		internal  Button vmethod_14()
//		{
//			return this.button_2;
//		}

		// Token: 0x06003C13 RID: 15379 RVA: 0x0012A6A0 File Offset: 0x001288A0
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_15(Button button_5)
//		{
//			EventHandler value = new EventHandler(this.method_4);
//			Button button = this.button_2;
//			if (button != null)
//			{
//				button.Click -= value;
//			}
//			this.button_2 = button_5;
//			button = this.button_2;
//			if (button != null)
//			{
//				button.Click += value;
//			}
//		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x0012A6EC File Offset: 0x001288EC
//		[CompilerGenerated]
//		internal  TreeGridViewTextBoxColumn vmethod_16()
//		{
//			return this.class2383_0;
//		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x0001FA72 File Offset: 0x0001DC72
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_17(TreeGridViewTextBoxColumn class2383_3)
//		{
//			this.class2383_0 = class2383_3;
//		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x0012A704 File Offset: 0x00128904
//		[CompilerGenerated]
//		internal  TreeGridViewTextBoxColumn vmethod_18()
//		{
//			return this.class2383_1;
//		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x0001FA7B File Offset: 0x0001DC7B
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_19(TreeGridViewTextBoxColumn class2383_3)
//		{
//			this.class2383_1 = class2383_3;
//		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x0012A71C File Offset: 0x0012891C
//		[CompilerGenerated]
//		internal  TreeGridViewTextBoxColumn vmethod_20()
//		{
//			return this.class2383_2;
//		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x0001FA84 File Offset: 0x0001DC84
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_21(TreeGridViewTextBoxColumn class2383_3)
//		{
//			this.class2383_2 = class2383_3;
//		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x0012A734 File Offset: 0x00128934
//		[CompilerGenerated]
//		internal  FlowLayoutPanel vmethod_22()
//		{
//			return this.flowLayoutPanel_0;
//		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x0001FA8D File Offset: 0x0001DC8D
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_23(FlowLayoutPanel flowLayoutPanel_1)
//		{
//			this.flowLayoutPanel_0 = flowLayoutPanel_1;
//		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x0012A74C File Offset: 0x0012894C
//		[CompilerGenerated]
//		internal  Label vmethod_24()
//		{
//			return this.label_0;
//		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x0001FA96 File Offset: 0x0001DC96
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_25(Label label_1)
//		{
//			this.label_0 = label_1;
//		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x0012A764 File Offset: 0x00128964
//		[CompilerGenerated]
//		internal  Button vmethod_26()
//		{
//			return this.button_3;
//		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x0012A77C File Offset: 0x0012897C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_27(Button button_5)
//		{
//			EventHandler value = new EventHandler(this.method_11);
//			Button button = this.button_3;
//			if (button != null)
//			{
//				button.Click -= value;
//			}
//			this.button_3 = button_5;
//			button = this.button_3;
//			if (button != null)
//			{
//				button.Click += value;
//			}
//		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x0012A7C8 File Offset: 0x001289C8
//		[CompilerGenerated]
//		public  Button vmethod_28()
//		{
//			return this.button_4;
//		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x0001FA9F File Offset: 0x0001DC9F
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		public  void vmethod_29(Button button_5)
//		{
//			this.button_4 = button_5;
//		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x0012A7E0 File Offset: 0x001289E0
		private void method_1()
		{
			this.flowLayoutPanel_0.Controls.Clear();
			List<string> list = new List<string>();
			Campaign.smethod_3(GameGeneral.strScenariosDir, list);
			foreach (string current in list)
			{
				Campaign.GetCampaign(current);
				this.button_4 = new Button();
				this.button_4.Height = 135;
				this.button_4.Width = 280;
				if (File.Exists(Path.ChangeExtension(current, "png")))
				{
					this.button_4.Image = Image.FromFile(Path.ChangeExtension(current, "png"));
				}
				else
				{
					this.button_4.Image = Image.FromFile(Path.Combine(CommandFactory.GetCommandApp().Info.DirectoryPath, "CommandX.ico"));
				}
				this.button_4.Tag = current;
				this.flowLayoutPanel_0.Controls.Add(this.button_4);
				this.button_4.Click += new EventHandler(this.method_7);
				this.button_4.MouseEnter += new EventHandler(this.method_9);
				this.button_4.MouseLeave += new EventHandler(this.method_10);
			}
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x0012A950 File Offset: 0x00128B50
		private void CampaignPlayWindow_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.button_4.Click -= new EventHandler(this.method_7);
			this.button_4.MouseEnter -= new EventHandler(this.method_9);
			this.button_4.MouseLeave -= new EventHandler(this.method_10);
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x0012A9A4 File Offset: 0x00128BA4
		private void method_2()
		{
			this.treeGridView_0.Nodes.Clear();
			List<string> list = new List<string>();
			Campaign.smethod_3(GameGeneral.strScenariosDir, list);
			HashSet<string> hashSet = new HashSet<string>();
			List<string> list2 = new List<string>();
			foreach (string current in list)
			{
				Campaign campaign = Campaign.GetCampaign(current);
				IEnumerable<string> enumerable = Directory.GetFiles(Path.GetDirectoryName(current)).OrderBy(CampaignPlayWindow.stringFunc0);
				Dictionary<string, Tuple<string, string, string, string>> dictionary = new Dictionary<string, Tuple<string, string, string, string>>();
				foreach (string current2 in enumerable)
				{
					if (Operators.CompareString(Path.GetExtension(current2), ".save", false) == 0)
					{
						try
						{
							List<string> list3 = Scenario.XmlReaderList(current2, new List<string>
							{
								"CampaignID",
								"CampaignSessionID",
								"Title",
								"Time"
							});
							string text = list3[0];
							if (!string.IsNullOrEmpty(text))
							{
								dictionary.Add(current2, new Tuple<string, string, string, string>(list3[0], list3[1], list3[2], list3[3]));
								hashSet.Add(text);
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200374", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
					}
				}
				TreeGridViewRow treeGridViewRow = this.treeGridView_0.Nodes.method_0(campaign.Name);
				treeGridViewRow.Tag = campaign;
				list2 = dictionary.Values.Select(CampaignPlayWindow.TupleFunc1).Distinct<string>().ToList<string>();
				foreach (string current3 in list2)
				{
					TreeGridViewRow treeGridViewRow2 = null;
					foreach (string current4 in dictionary.Keys)
					{
						if (Operators.CompareString(dictionary[current4].Item2, current3, false) == 0)
						{
							Tuple<string, string, string, string> tuple = dictionary[current4];
							string text2 = tuple.Item3;
							DateTime dateTime = DateTime.FromBinary(Conversions.ToLong(tuple.Item4));
							if (Information.IsNothing(treeGridViewRow2))
							{
								treeGridViewRow2 = treeGridViewRow.Nodes.method_0("Session started at: " + new FileInfo(current4).CreationTime.ToShortDateString() + " " + new FileInfo(current4).CreationTime.ToShortTimeString());
								treeGridViewRow2.Tag = "Session_" + current3;
							}
							if (ScenContainer.smethod_2(current4).IsCampaignCheckpoint)
							{
								text2 += " (Checkpoint)";
							}
							DateTime lastWriteTime = File.GetLastWriteTime(current4);
							treeGridViewRow2.Nodes.method_1(new object[]
							{
								text2,
								dateTime,
								lastWriteTime
							}).Tag = current4;
						}
					}
				}
				treeGridViewRow.vmethod_4();
			}
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x0012AD98 File Offset: 0x00128F98
		private void CampaignPlayWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.webBrowser_0.Visible = false;
			this.flowLayoutPanel_0.VerticalScroll.Visible = true;
			this.method_1();
			this.method_2();
			this.button_0.Visible = false;
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x0012ADF4 File Offset: 0x00128FF4
		private void method_3(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.string_0))
			{
				string extension = Path.GetExtension(this.string_0);
				if (Operators.CompareString(extension, ".campaign", false) == 0)
				{
					Campaign campaign = Campaign.GetCampaign(this.string_0);
					ScenarioCompressor.smethod_2(Path.GetDirectoryName(this.string_0));
					foreach (Campaign.Scenario current in campaign.ScenarioList)
					{
						Type type = current.GetType();
						if (type == typeof(Campaign.ScenarioInfo))
						{
							string text = Path.GetDirectoryName(this.string_0) + "\\" + ((Campaign.ScenarioInfo)current).strScenarioFile;
							CommandFactory.GetCommandMain().GetCampaignScenarioWindow().m_Campaign = campaign;
							CommandFactory.GetCommandMain().GetCampaignScenarioWindow().string_0 = text;
							CommandFactory.GetCommandMain().GetCampaignScenarioWindow().CampaignSessionID = Guid.NewGuid().ToString();
							CommandFactory.GetCommandMain().GetCampaignScenarioWindow().int_0 = 0;
							CommandFactory.GetCommandMain().GetCampaignScenarioWindow().Show();
							base.Close();
							break;
						}
						if (type == typeof(Campaign.ScenarioInstance))
						{
							Class313.smethod_0(((Campaign.ScenarioInstance)current).strScenarioID, null);
						}
					}
				}
			}
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x0012AF64 File Offset: 0x00129164
		private void method_4(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.treeGridView_0.method_4()))
			{
				string extension = Path.GetExtension(this.string_0);
				if (Operators.CompareString(extension, ".save", false) == 0)
				{
					Client.GetConfiguration().SetGameMode(Configuration._GameMode.Play);
					CommandFactory.GetCommandMain().GetResumeFromSave().string_0 = this.string_0;
					CommandFactory.GetCommandMain().GetResumeFromSave().Show();
					if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Play)
					{
						Client.GetConfiguration().SetGameMode(Configuration._GameMode.Play);
					}
					base.Close();
				}
			}
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x0012AFF4 File Offset: 0x001291F4
		private void method_5(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.treeGridView_0.method_4()))
			{
				this.button_2.Enabled = false;
			}
			else if (this.treeGridView_0.method_4().Tag.GetType() == typeof(string) && !Conversions.ToString(this.treeGridView_0.method_4().Tag).StartsWith("Session_"))
			{
				this.string_0 = Conversions.ToString(this.treeGridView_0.method_4().Tag);
				this.button_2.Enabled = true;
			}
			else
			{
				this.button_2.Enabled = false;
			}
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x0012B0A4 File Offset: 0x001292A4
		private void method_6(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.treeGridView_0.method_4()))
			{
				string extension = Path.GetExtension(this.string_0);
				if (Operators.CompareString(extension, ".save", false) == 0)
				{
					File.Delete(this.string_0);
					this.treeGridView_0.method_4().method_7().Nodes.Remove(this.treeGridView_0.method_4());
				}
			}
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x0012B114 File Offset: 0x00129314
		private void method_7(object sender, EventArgs e)
		{
			this.webBrowser_0.Visible = true;
			this.string_0 = Conversions.ToString(NewLateBinding.LateGet(sender, null, "Tag", new object[0], null, null, null));
			string extension = Path.GetExtension(this.string_0);
			if (Operators.CompareString(extension, ".campaign", false) == 0)
			{
				this.label_0.Visible = false;
				Campaign campaign = Campaign.GetCampaign(this.string_0);
				string text = Scenario.XmlReaderSting(ScenContainer.smethod_2(campaign.method_3(this.string_0)).method_9(), "ContentTag");
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
					this.webBrowser_0.Visible = false;
					this.webBrowser_0.AllowNavigation = false;
					this.button_0.Visible = false;
				}
				else
				{
					this.webBrowser_0.Visible = true;
					this.webBrowser_0.AllowNavigation = true;
					if (!this.method_8(this.webBrowser_0, campaign.strDescription, Path.GetDirectoryName(this.string_0)))
					{
						Class2529.smethod_7(this.webBrowser_0, campaign.strDescription, default(Color));
					}
					this.button_0.Visible = true;
				}
			}
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x0012B2FC File Offset: 0x001294FC
		private bool method_8(WebBrowser webBrowser_1, string string_1, string string_2)
		{
			bool result;
			if (string_1.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_1, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_1, "[/LOADDOC]", CompareMethod.Binary);
				string path = string_1.Substring(num, string_1.Length - num - (string_1.Length - num2 + 1));
				webBrowser_1.Navigate(Path.Combine(string_2, path));
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x0001FAA8 File Offset: 0x0001DCA8
		private void method_9(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x0001FAB5 File Offset: 0x0001DCB5
		private void method_10(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Arrow;
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x0001FAC2 File Offset: 0x0001DCC2
		private void method_11(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetStartGame().Show();
			base.Close();
		}

		// Token: 0x04001B62 RID: 7010
		public static Func<string, DateTime> stringFunc0 = (string string_0) => new FileInfo(string_0).CreationTime;

		// Token: 0x04001B63 RID: 7011
		public static Func<Tuple<string, string, string, string>, string> TupleFunc1 = (Tuple<string, string, string, string> tuple_0) => tuple_0.Item2;

		// Token: 0x04001B65 RID: 7013
		[CompilerGenerated]
		private WebBrowser webBrowser_0;

		// Token: 0x04001B66 RID: 7014
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001B67 RID: 7015
		[CompilerGenerated]
		private TabControl tabControl_0;

		// Token: 0x04001B68 RID: 7016
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x04001B69 RID: 7017
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x04001B6A RID: 7018
		[CompilerGenerated]
		private TreeGridView treeGridView_0;

		// Token: 0x04001B6B RID: 7019
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001B6C RID: 7020
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04001B6D RID: 7021
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn class2383_0;

		// Token: 0x04001B6E RID: 7022
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn class2383_1;

		// Token: 0x04001B6F RID: 7023
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn class2383_2;

		// Token: 0x04001B70 RID: 7024
		[CompilerGenerated]
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x04001B71 RID: 7025
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001B72 RID: 7026
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04001B73 RID: 7027
		private string string_0;

		// Token: 0x04001B74 RID: 7028
		[CompilerGenerated]
		private Button button_4;
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns32;
using ns33;
using ns35;
using ns4;

namespace ns34
{
	// Token: 0x02000A03 RID: 2563
	[DesignerGenerated]
	public sealed partial class Evaluation : CommandForm
	{
		// Token: 0x06004DC1 RID: 19905 RVA: 0x001F312C File Offset: 0x001F132C
		public Evaluation()
		{
			base.Load += new EventHandler(this.Evaluation_Load);
			base.KeyDown += new KeyEventHandler(this.Evaluation_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.Evaluation_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004DC4 RID: 19908 RVA: 0x001F3934 File Offset: 0x001F1B34
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06004DC5 RID: 19909 RVA: 0x00024C70 File Offset: 0x00022E70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_3)
		{
			this.label_0 = label_3;
		}

		// Token: 0x06004DC6 RID: 19910 RVA: 0x001F394C File Offset: 0x001F1B4C
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_1;
		}

		// Token: 0x06004DC7 RID: 19911 RVA: 0x00024C79 File Offset: 0x00022E79
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_3)
		{
			this.label_1 = label_3;
		}

		// Token: 0x06004DC8 RID: 19912 RVA: 0x001F3964 File Offset: 0x001F1B64
		[CompilerGenerated]
		internal  TabControl vmethod_4()
		{
			return this.tabControl_0;
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x00024C82 File Offset: 0x00022E82
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TabControl tabControl_1)
		{
			this.tabControl_0 = tabControl_1;
		}

		// Token: 0x06004DCA RID: 19914 RVA: 0x001F397C File Offset: 0x001F1B7C
		[CompilerGenerated]
		internal  TabPage vmethod_6()
		{
			return this.tabPage_0;
		}

		// Token: 0x06004DCB RID: 19915 RVA: 0x00024C8B File Offset: 0x00022E8B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TabPage tabPage_3)
		{
			this.tabPage_0 = tabPage_3;
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x001F3994 File Offset: 0x001F1B94
		[CompilerGenerated]
		internal  TabPage vmethod_8()
		{
			return this.tabPage_1;
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x00024C94 File Offset: 0x00022E94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TabPage tabPage_3)
		{
			this.tabPage_1 = tabPage_3;
		}

		// Token: 0x06004DCE RID: 19918 RVA: 0x001F39AC File Offset: 0x001F1BAC
		[CompilerGenerated]
		internal  TextBox vmethod_10()
		{
			return this.textBox_0;
		}

		// Token: 0x06004DCF RID: 19919 RVA: 0x00024C9D File Offset: 0x00022E9D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TextBox textBox_2)
		{
			this.textBox_0 = textBox_2;
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x001F39C4 File Offset: 0x001F1BC4
		[CompilerGenerated]
		internal  Button vmethod_12()
		{
			return this.button_0;
		}

		// Token: 0x06004DD1 RID: 19921 RVA: 0x001F39DC File Offset: 0x001F1BDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_5);
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

		// Token: 0x06004DD2 RID: 19922 RVA: 0x001F3A28 File Offset: 0x001F1C28
		[CompilerGenerated]
		internal  Button vmethod_14()
		{
			return this.button_1;
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x001F3A40 File Offset: 0x001F1C40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_6);
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

		// Token: 0x06004DD4 RID: 19924 RVA: 0x001F3A8C File Offset: 0x001F1C8C
		[CompilerGenerated]
		internal  Label vmethod_16()
		{
			return this.label_2;
		}

		// Token: 0x06004DD5 RID: 19925 RVA: 0x00024CA6 File Offset: 0x00022EA6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_3)
		{
			this.label_2 = label_3;
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x001F3AA4 File Offset: 0x001F1CA4
		[CompilerGenerated]
		internal  TabPage vmethod_18()
		{
			return this.tabPage_2;
		}

		// Token: 0x06004DD7 RID: 19927 RVA: 0x00024CAF File Offset: 0x00022EAF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(TabPage tabPage_3)
		{
			this.tabPage_2 = tabPage_3;
		}

		// Token: 0x06004DD8 RID: 19928 RVA: 0x001F3ABC File Offset: 0x001F1CBC
		[CompilerGenerated]
		internal  TextBox vmethod_20()
		{
			return this.textBox_1;
		}

		// Token: 0x06004DD9 RID: 19929 RVA: 0x00024CB8 File Offset: 0x00022EB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(TextBox textBox_2)
		{
			this.textBox_1 = textBox_2;
		}

		// Token: 0x06004DDA RID: 19930 RVA: 0x00024CC1 File Offset: 0x00022EC1
		private void Evaluation_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.method_1();
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x001F3AD4 File Offset: 0x001F1CD4
		private void method_1()
		{
			this.bool_0 = true;
			this.vmethod_0().Text = this.method_4();
			this.vmethod_12().Visible = !Client.GetClientScenario().HasEnded();
			if (Client.GetClientScenario().IsCampaignSession())
			{
				this.vmethod_16().Visible = true;
				this.vmethod_14().Visible = true;
				int num = Class2529.smethod_12(Client.GetClientScenario());
				if (Client.GetClientSide().GetTotalScore(Client.GetClientScenario(), null) >= num)
				{
					this.vmethod_16().Text = "您已达到战役想定的转阶段条件！";
					this.vmethod_14().Enabled = true;
				}
				else
				{
					this.vmethod_16().Text = string.Concat(new string[]
					{
						"您当前的想定推演成绩(",
						Conversions.ToString(Client.GetClientSide().GetTotalScore(Client.GetClientScenario(), null)),
						")尚未达到战役想定的转阶段条件(",
						Conversions.ToString(num),
						")"
					});
					this.vmethod_14().Enabled = false;
				}
			}
			else
			{
				this.vmethod_16().Visible = false;
				this.vmethod_14().Visible = false;
			}
			this.vmethod_10().Clear();
			if (!Information.IsNothing(Client.GetClientSide()))
			{
				if (Client.GetClientScenario().HasEnded())
				{
					this.vmethod_2().Text = "您最终的推演成绩为: " + Conversions.ToString(Client.GetClientSide().GetTotalScore(Client.GetClientScenario(), null));
				}
				else
				{
					this.vmethod_2().Text = "您当前的推演成绩为: " + Conversions.ToString(Client.GetClientSide().GetTotalScore(Client.GetClientScenario(), null));
				}
				this.method_3(Client.GetClientSide());
			}
			Side[] sides = Client.GetClientScenario().GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side_ = sides[i];
					this.method_2(side_);
				}
				this.bool_0 = false;
			}
		}

		// Token: 0x06004DDC RID: 19932 RVA: 0x001F3CA8 File Offset: 0x001F1EA8
		private void method_2(Side side_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("推演方: " + side_0.GetSideName() + "\r\n===========================================================\r\n\r\n");
			stringBuilder.Append("战损:\r\n-------------------------------\r\n");
			Dictionary<string, HashSet<string>>.Enumerator enumerator = side_0.m_AAR.Losses.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, HashSet<string>> current = enumerator.Current;
					string[] array = current.Key.ToString().Split(new char[]
					{
						'_'
					});
					string str = "";
					string left = array[0].ToString();
					if (Operators.CompareString(left, "Aircraft", false) != 0)
					{
						if (Operators.CompareString(left, "Ship", false) != 0)
						{
							if (Operators.CompareString(left, "Submarine", false) != 0)
							{
								if (Operators.CompareString(left, "Facility", false) != 0)
								{
									if (Operators.CompareString(left, "FacilityAimpoint", false) == 0)
									{
										if (Operators.CompareString(array[1], "0", false) == 0)
										{
											str = "Non-identifiable land aimpoint - sorry!";
										}
										else
										{
											int iD_ = Conversions.ToInteger(array[1]);
											SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
											str = Misc.smethod_11(DBFunctions.GetMountName(iD_, ref sQLiteConnection));
										}
									}
								}
								else
								{
									str = Misc.smethod_11(Client.GetClientScenario().Cache_Facilities_DT.Select("ID=" + array[1])[0]["Name"].ToString());
								}
							}
							else
							{
								str = Misc.smethod_11(Client.GetClientScenario().Cache_Subs_DT.Select("ID=" + array[1])[0]["Name"].ToString());
							}
						}
						else
						{
							str = Misc.smethod_11(Client.GetClientScenario().Cache_Ships_DT.Select("ID=" + array[1])[0]["Name"].ToString());
						}
					}
					else
					{
						str = Misc.smethod_11(Client.GetClientScenario().Cache_Aircraft_DT.Select("ID=" + array[1])[0]["Name"].ToString());
					}
					stringBuilder.Append(Conversions.ToString(current.Value.Count) + "x " + str + "\r\n");
				}
			}
			finally
			{
				IDisposable disposable = enumerator;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			stringBuilder.Append("\r\n\r\n消耗:\r\n------------------\r\n");
			foreach (KeyValuePair<int, int> current2 in side_0.m_AAR.Expenditures)
			{
				DataRow[] array2 = Client.GetClientScenario().Cache_Weapons_DT.Select("ID=" + Conversions.ToString(current2.Key));
				stringBuilder.Append(current2.Value.ToString() + "x " + Misc.smethod_11(array2[0]["Name"].ToString()) + "\r\n");
			}
			stringBuilder.Append("\r\n\r\n\r\n");
			this.vmethod_10().Text = this.vmethod_10().Text + stringBuilder.ToString();
		}

		// Token: 0x06004DDD RID: 19933 RVA: 0x001F4020 File Offset: 0x001F2220
		private void method_3(Side side_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			List<string>.Enumerator enumerator = side_0.ScoringLogs.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					stringBuilder.Append(current).Append("\r\n").Append("\r\n");
				}
			}
			finally
			{
				IDisposable disposable = enumerator;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			this.vmethod_20().Text = stringBuilder.ToString();
		}

		// Token: 0x06004DDE RID: 19934 RVA: 0x001F40A8 File Offset: 0x001F22A8
		private string method_4()
		{
			string result = "";
			if (!Information.IsNothing(Client.GetClientSide()))
			{
				int totalScore = Client.GetClientSide().GetTotalScore(Client.GetClientScenario(), null);
				int? num2;
				if (Client.GetClientSide().Scoring_Triumph.HasValue)
				{
					int num = totalScore;
					num2 = Client.GetClientSide().Scoring_Triumph;
					if ((num2.HasValue ? new bool?(num >= num2.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						result = "完胜";
					}
				}
				num2 = Client.GetClientSide().Scoring_Triumph;
				if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() > totalScore) : null).GetValueOrDefault() && totalScore >= Client.GetClientSide().ScoringMode3())
				{
					result = "大胜";
				}
				if (Client.GetClientSide().ScoringMode3() > totalScore && totalScore >= Client.GetClientSide().ScoringMode2())
				{
					result = "小胜";
				}
				if (Client.GetClientSide().ScoringMode2() > totalScore && totalScore > Client.GetClientSide().ScoringMode4())
				{
					result = "平局";
				}
				if (Client.GetClientSide().ScoringMode4() >= totalScore && totalScore > Client.GetClientSide().ScoringMode5())
				{
					result = "小败";
				}
				if (Client.GetClientSide().ScoringMode5() >= totalScore)
				{
					int num = totalScore;
					num2 = Client.GetClientSide().Scoring_Disaster;
					if ((num2.HasValue ? new bool?(num > num2.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						result = "大败";
					}
				}
				if (Client.GetClientSide().Scoring_Disaster.HasValue)
				{
					int num = Client.GetClientSide().GetTotalScore(Client.GetClientScenario(), null);
					num2 = Client.GetClientSide().Scoring_Disaster;
					if ((num2.HasValue ? new bool?(num <= num2.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						result = "完败";
					}
				}
			}
			return result;
		}

		// Token: 0x06004DDF RID: 19935 RVA: 0x00024CE1 File Offset: 0x00022EE1
		private void method_5(object sender, EventArgs e)
		{
			Client.GetClientScenario().ScenCompleted();
			this.method_1();
		}

		// Token: 0x06004DE0 RID: 19936 RVA: 0x001F42C4 File Offset: 0x001F24C4
		private void Evaluation_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (!base.Visible || (e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.End && e.KeyCode != Keys.Home && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract && (e.KeyCode != Keys.C || e.Modifiers != Keys.Control) && (e.KeyCode != Keys.X || e.Modifiers != Keys.Control)))
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06004DE1 RID: 19937 RVA: 0x00004D83 File Offset: 0x00002F83
		private void Evaluation_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004DE2 RID: 19938 RVA: 0x001F43B8 File Offset: 0x001F25B8
		private void method_6(object sender, EventArgs e)
		{
			if (Client.GetClientScenario().IsCampaignSession())
			{
				List<string> list = new List<string>();
				Campaign.smethod_3(GameGeneral.strScenariosDir, list);
				List<string>.Enumerator enumerator = list.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						Campaign campaign = Campaign.GetCampaign(current);
						if (Operators.CompareString(campaign.ID, Client.GetClientScenario().CampaignID, false) == 0)
						{
							foreach (Campaign.Scenario current2 in campaign.ScenarioList)
							{
								if (current2.GetType() == typeof(Campaign.ScenarioInfo) && Operators.CompareString(((Campaign.ScenarioInfo)current2).strScenarioID, Client.GetClientScenario().GetObjectID(), false) == 0)
								{
									int num = campaign.ScenarioList.IndexOf(current2);
									if (num != campaign.ScenarioList.Count - 1)
									{
										Campaign.Scenario scenario = campaign.ScenarioList[num + 1];
										Type type = scenario.GetType();
										if (!(type == typeof(Campaign.ScenarioInfo)))
										{
											if (!(type == typeof(Campaign.ScenarioInstance)))
											{
												continue;
											}
											this.method_7(scenario, campaign, current);
											if (scenario == campaign.ScenarioList.Last<Campaign.Scenario>())
											{
												this.method_8(campaign);
											}
											else
											{
												this.method_7(campaign.ScenarioList[num + 2], campaign, current);
											}
										}
										else
										{
											this.method_7(scenario, campaign, current);
										}
									}
									else
									{
										this.method_8(campaign);
									}
									break;
								}
							}
							break;
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
		}

		// Token: 0x06004DE3 RID: 19939 RVA: 0x001F45B0 File Offset: 0x001F27B0
		private void method_7(Campaign.Scenario scen_, Campaign Campaign_, string string_0)
		{
			Type type = scen_.GetType();
			if (type == typeof(Campaign.ScenarioInfo))
			{
				string string_ = Path.GetDirectoryName(string_0) + "\\" + ((Campaign.ScenarioInfo)scen_).strScenarioFile;
				CommandFactory.GetCommandMain().GetCampaignScenarioWindow().m_Campaign = Campaign_;
				CommandFactory.GetCommandMain().GetCampaignScenarioWindow().string_0 = string_;
				CommandFactory.GetCommandMain().GetCampaignScenarioWindow().CampaignSessionID = Client.GetClientScenario().CampaignSessionID;
				CommandFactory.GetCommandMain().GetCampaignScenarioWindow().int_0 = Client.GetClientScenario().CampaignScore + Client.GetClientSide().GetTotalScore(Client.GetClientScenario(), null);
				CommandFactory.GetCommandMain().GetCampaignScenarioWindow().Show();
				base.Close();
			}
			else if (type == typeof(Campaign.ScenarioInstance))
			{
				Class313.smethod_0(((Campaign.ScenarioInstance)scen_).strScenarioID, null);
			}
		}

		// Token: 0x06004DE4 RID: 19940 RVA: 0x00024CF3 File Offset: 0x00022EF3
		private void method_8(Campaign class111_0)
		{
			CommandFactory.GetCommandMain().GetCampaignEnd().class111_0 = class111_0;
			CommandFactory.GetCommandMain().GetCampaignEnd().Show();
		}

		// Token: 0x040024BA RID: 9402
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x040024BB RID: 9403
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x040024BC RID: 9404
		[CompilerGenerated]
		private TabControl tabControl_0;

		// Token: 0x040024BD RID: 9405
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x040024BE RID: 9406
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x040024BF RID: 9407
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x040024C0 RID: 9408
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x040024C1 RID: 9409
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x040024C2 RID: 9410
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x040024C3 RID: 9411
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x040024C4 RID: 9412
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x040024C5 RID: 9413
		public bool bool_0;
	}
}

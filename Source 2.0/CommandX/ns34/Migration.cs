using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns32;
using ns33;
using ns4;

namespace ns34
{
	// Token: 0x02000A08 RID: 2568
	[DesignerGenerated]
	public sealed partial class Migration : CommandForm
	{
		// Token: 0x06004E31 RID: 20017 RVA: 0x001F6DE0 File Offset: 0x001F4FE0
		public Migration()
		{
			base.Load += new EventHandler(this.Migration_Load);
			base.KeyDown += new KeyEventHandler(this.Migration_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.Migration_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x001F74F8 File Offset: 0x001F56F8
		[CompilerGenerated]
		internal  GroupBox vmethod_0()
		{
			return this.groupBox_0;
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x00024EAF File Offset: 0x000230AF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(GroupBox groupBox_2)
		{
			this.groupBox_0 = groupBox_2;
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x001F7510 File Offset: 0x001F5710
		[CompilerGenerated]
		internal  Button vmethod_2()
		{
			return this.button_0;
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x001F7528 File Offset: 0x001F5728
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_3);
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

		// Token: 0x06004E38 RID: 20024 RVA: 0x001F7574 File Offset: 0x001F5774
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_0;
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x00024EB8 File Offset: 0x000230B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_4)
		{
			this.label_0 = label_4;
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x001F758C File Offset: 0x001F578C
		[CompilerGenerated]
		internal  TextBox vmethod_6()
		{
			return this.textBox_0;
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x00024EC1 File Offset: 0x000230C1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TextBox textBox_1)
		{
			this.textBox_0 = textBox_1;
		}

		// Token: 0x06004E3C RID: 20028 RVA: 0x001F75A4 File Offset: 0x001F57A4
		[CompilerGenerated]
		internal  GroupBox vmethod_8()
		{
			return this.groupBox_1;
		}

		// Token: 0x06004E3D RID: 20029 RVA: 0x00024ECA File Offset: 0x000230CA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(GroupBox groupBox_2)
		{
			this.groupBox_1 = groupBox_2;
		}

		// Token: 0x06004E3E RID: 20030 RVA: 0x001F75BC File Offset: 0x001F57BC
		[CompilerGenerated]
		internal  CheckBox vmethod_10()
		{
			return this.checkBox_0;
		}

		// Token: 0x06004E3F RID: 20031 RVA: 0x00024ED3 File Offset: 0x000230D3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(CheckBox checkBox_2)
		{
			this.checkBox_0 = checkBox_2;
		}

		// Token: 0x06004E40 RID: 20032 RVA: 0x001F75D4 File Offset: 0x001F57D4
		[CompilerGenerated]
		internal  CheckBox vmethod_12()
		{
			return this.checkBox_1;
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x00024EDC File Offset: 0x000230DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(CheckBox checkBox_2)
		{
			this.checkBox_1 = checkBox_2;
		}

		// Token: 0x06004E42 RID: 20034 RVA: 0x001F75EC File Offset: 0x001F57EC
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_1;
		}

		// Token: 0x06004E43 RID: 20035 RVA: 0x00024EE5 File Offset: 0x000230E5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_4)
		{
			this.label_1 = label_4;
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x001F7604 File Offset: 0x001F5804
		[CompilerGenerated]
		internal  Label vmethod_16()
		{
			return this.label_2;
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x00024EEE File Offset: 0x000230EE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_4)
		{
			this.label_2 = label_4;
		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x001F761C File Offset: 0x001F581C
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_3;
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x00024EF7 File Offset: 0x000230F7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_4)
		{
			this.label_3 = label_4;
		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x001F7634 File Offset: 0x001F5834
		[CompilerGenerated]
		internal  Button vmethod_20()
		{
			return this.button_1;
		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x001F764C File Offset: 0x001F584C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_2);
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

		// Token: 0x06004E4A RID: 20042 RVA: 0x001F7698 File Offset: 0x001F5898
		[CompilerGenerated]
		internal  OpenFileDialog vmethod_22()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x00024F00 File Offset: 0x00023100
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x001F76B0 File Offset: 0x001F58B0
		private void Migration_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			DBOps.DBFileCheckResult dBFileCheckResult = DBOps.DBFileCheckResult.Undefined;
			this.string_0 = DBOps.GetDBRecord(DBOps.GetDBRecordHash(Client.GetDBRecord().DBID), ref dBFileCheckResult, true, true).Filename;
			this.Text = "想定迁移(选择的数据库: " + this.string_0 + ")";
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x001F7718 File Offset: 0x001F5918
		private void method_1()
		{
			this.vmethod_6().Text = "开始迁移... \r\n\r\n";
			Application.DoEvents();
			TextBox textBox;
			(textBox = this.vmethod_6()).Text = string.Concat(new string[]
			{
				textBox.Text,
				"将当前想定的副本保存到[",
				GameGeneral.strScenariosDir,
				"\\",
				Client.GetClientScenario().FileName,
				".OLD]... "
			});
			Application.DoEvents();
			Client.SaveTempScenarioFile(true, GameGeneral.strScenariosDir + "\\" + Client.GetClientScenario().FileName + ".OLD", false);
			(textBox = this.vmethod_6()).Text = textBox.Text + "完成.\r\n\r\n";
			Application.DoEvents();
			(textBox = this.vmethod_6()).Text = textBox.Text + "将数据库版本切换到最新... ";
			Client.SetDBUsedHash(DBOps.GetDBRecordHash(Client.GetDBRecord().DBID));
			Application.DoEvents();
			(textBox = this.vmethod_6()).Text = textBox.Text + "完成.\r\n\r\n";
			Application.DoEvents();
			(textBox = this.vmethod_6()).Text = textBox.Text + "自动保存... ";
			Application.DoEvents();
			GameGeneral.SerializeScenario(Client.GetClientScenario());
			Class260.SaveTempScenarioFile(Client.GetClientScenario(), Client.GetClientScenario().GetSides()[0], GameGeneral.strScenariosDir + "\\SBR.scen", false, false);
			(textBox = this.vmethod_6()).Text = textBox.Text + "完成.\r\n\r\n";
			Application.DoEvents();
			(textBox = this.vmethod_6()).Text = textBox.Text + "重新加载迁移后的想定... ";
			Application.DoEvents();
			Scenario scenario = Client.GetClientScenario();
			GameGeneral.ClearActiveUnits(ref scenario);
			scenario = null;
			ScenContainer scenContainer = ScenContainer.smethod_2(GameGeneral.strScenariosDir + "\\SBR.scen");
			string text = "";
			double num = 0.0;
			Scenario scenario2 = scenContainer.LoadScenario(ref text, ref num, this.vmethod_12().Checked);
			GameGeneral.ClearScenarioStreamDictionary();
			(textBox = this.vmethod_6()).Text = textBox.Text + "完成.\r\n\r\n";
			Application.DoEvents();
			string text2;
			if (this.vmethod_10().Checked)
			{
				(textBox = this.vmethod_6()).Text = textBox.Text + "选择INI配置文件... ";
				Application.DoEvents();
				this.vmethod_23(new OpenFileDialog());
				this.vmethod_22().InitialDirectory = GameGeneral.strScenariosDir;
				if (this.vmethod_22().ShowDialog() == DialogResult.OK)
				{
					(textBox = this.vmethod_6()).Text = textBox.Text + "完成.\r\n\r\n";
					Application.DoEvents();
					(textBox = this.vmethod_6()).Text = textBox.Text + "应用INI配置，文件[" + this.vmethod_22().FileName + "]... ";
					Application.DoEvents();
					if (!Directory.Exists(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Logs"))
					{
						Directory.CreateDirectory(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Logs");
					}
					text2 = "\r\n\r\n想定 : " + scenario2.GetScenarioTitle() + "\r\n配置文件: " + this.vmethod_22().FileName;
					StreamWriter streamWriter = File.AppendText(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
					streamWriter.Write("\r\n\r\n" + text2);
					streamWriter.Close();
					ScenarioUnits.smethod_8(scenario2, this.vmethod_22().FileName, false, null);
					text2 = "想定 " + scenario2.GetScenarioTitle() + ":  重建完成";
					StreamWriter streamWriter2 = File.AppendText(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt");
					streamWriter2.Write("\r\n" + text2);
					streamWriter2.Close();
					Class260.SaveTempScenarioFile(scenario2, scenario2.GetSides()[0], GameGeneral.strScenariosDir + "\\SBR.scen", true, false);
					scenario = Client.GetClientScenario();
					GameGeneral.ClearActiveUnits(ref scenario);
					ScenContainer scenContainer2 = ScenContainer.smethod_2(GameGeneral.strScenariosDir + "\\SBR.scen");
					text = "";
					num = 0.0;
					scenario2 = scenContainer2.LoadScenario(ref text, ref num, false);
					GameGeneral.ClearScenarioStreamDictionary();
					(textBox = this.vmethod_6()).Text = textBox.Text + "完成.\r\n\r\n";
					Application.DoEvents();
				}
			}
			text2 = "\r\n\r\n想定 : " + scenario2.GetScenarioTitle();
			StreamWriter streamWriter3 = File.AppendText(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Logs\\SBR plaform list.txt");
			streamWriter3.Write("\r\n\r\n" + text2);
			streamWriter3.Close();
			ScenarioUnits.smethod_9(scenario2);
			List<ActiveUnit>.Enumerator enumerator = scenario2.GetActiveUnitList().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ActiveUnit current = enumerator.Current;
					current.GetSensory().ScheduleEMCONEvent(current.GetAllNoneMCMSensors());
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
			text2 = "想定 " + scenario2.GetScenarioTitle() + ": 重建完成";
			StreamWriter streamWriter4 = File.AppendText(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Logs\\SBR plaform list.txt");
			streamWriter4.Write(text2);
			streamWriter4.Close();
			List<string> list = ScenarioUnits.smethod_13(scenario2);
			if (list.Count > 0)
			{
				text2 = "  ERROR: ONE OR MORE AIRCRAFT FEATURED IN THIS SCENARIO CARRY A LOADOUT THAT IS NOT IN THE AIRCRAFT'S LOADOUT LIST.\r\n  PLATFORMS ARE AS FOLLOWS:\r\n";
				foreach (string current2 in list)
				{
					text2 = text2 + "  " + current2 + "\r\n";
				}
				text2 += "  请联系数据库管理员修正问题.\r\n";
				Interaction.MsgBox(text2, MsgBoxStyle.OkOnly, "新数据库缺少平台!");
			}
			List<string> list2 = new List<string>();
			Side[] sides = scenario2.GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					if (!Information.IsNothing(side.GetMissionCollection()))
					{
                        Mission current3X;
                        foreach (Mission current3 in side.GetPatrolMissionCollection(scenario2))
						{
                            current3X = current3;
                            list2.AddRange(scenario2.FlightSizeHardLimitCheckInfo(ref side, ref current3X));
						}
					}
				}
				if (list2.Count > 0)
				{
					text2 = "警告!由于编队规模限制，该任务行动中的某些飞机不能起飞!\r\n\r\n为解决这个问题，您可以改变编队规模，向任务行动中分配更多飞机，也可以改变现有飞机的挂载方案使得足够多的飞机具备相同的挂载，或者取消对“飞机数量低于编队规模不允许起飞”标志位的选择.\r\n\r\n";
					foreach (string current4 in list2)
					{
						text2 = text2 + "\r\n" + current4;
					}
					Interaction.MsgBox(text2, MsgBoxStyle.OkOnly, "新数据库缺少平台!");
				}
				if (scenario2.LoadingNotices.Count > 0)
				{
					(textBox = this.vmethod_6()).Text = textBox.Text + "注意:\r\n";
					(textBox = this.vmethod_6()).Text = textBox.Text + "--------\r\n";
					foreach (string current5 in Client.GetClientScenario().LoadingNotices)
					{
						(textBox = this.vmethod_6()).Text = textBox.Text + current5 + "\r\n";
					}
					(textBox = this.vmethod_6()).Text = textBox.Text + "--------\r\n";
				}
				scenario2.FeatureCompatibility = default(Scenario._FeatureCompatibility);
				(textBox = this.vmethod_6()).Text = textBox.Text + "全部完成! 想定已经迁移到最新版的数据库。请关闭窗口。";
				Application.DoEvents();
				Client.SetClientScenario(scenario2, false);
				Client.GetConfiguration().SetSimStopMode();
			}
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x001F7F10 File Offset: 0x001F6110
		private void method_2(object sender, EventArgs e)
		{
			if (!Client.GetClientScenario().GetSides().Any<Side>())
			{
				Interaction.MsgBox("想定至少有一个推演方!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				string dBRecordHash = DBOps.GetDBRecordHash(Client.GetDBRecord().DBID);
				List<string> list = ScenarioUnits.smethod_12(Client.GetClientScenario(), dBRecordHash, !this.vmethod_12().Checked);
				if (list.Count > 0)
				{
					string text = "您想迁移到数据库缺少本想定包含的平台。缺少的平台清单如下:\r\n\r\n";
					List<string>.Enumerator enumerator = list.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							text = text + current + "\r\n";
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
					text += "\r\n";
					text += "请联系数据库作者改正该问题. 请删除本单元，替换成数据库中存在的相近作战单元。\r\n\r\n";
					text += "...迁移终止...";
					Interaction.MsgBox(text, MsgBoxStyle.OkOnly, "新数据库缺少平台!");
				}
				else
				{
					list.Clear();
					this.method_1();
				}
			}
		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x001F8010 File Offset: 0x001F6210
		private void method_3(object sender, EventArgs e)
		{
			this.vmethod_6().Text = "选择想定文件列表... ";
			Application.DoEvents();
			this.vmethod_23(new OpenFileDialog());
			this.vmethod_22().InitialDirectory = GameGeneral.strScenariosDir;
			if (this.vmethod_22().ShowDialog() == DialogResult.OK)
			{
				TextBox textBox;
				(textBox = this.vmethod_6()).Text = textBox.Text + "完成!\r\n\r\n";
				Application.DoEvents();
				(textBox = this.vmethod_6()).Text = textBox.Text + "Starting rebuilding all scenarios listed in '" + this.vmethod_22().FileName + "'.\r\n\r\n";
				Application.DoEvents();
				ScenarioUnits.smethod_11(this.vmethod_22().FileName);
				(textBox = this.vmethod_6()).Text = textBox.Text + "Rebuilding done! Please check '" + CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Logs\\SBR log file.txt' for errors.\r\n\r\n";
				Application.DoEvents();
			}
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x001F8100 File Offset: 0x001F6300
		private void Migration_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode != Keys.Space || !base.Visible)
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x00004D83 File Offset: 0x00002F83
		private void Migration_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x040024F9 RID: 9465
		[CompilerGenerated]
		private GroupBox groupBox_0;

		// Token: 0x040024FA RID: 9466
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x040024FB RID: 9467
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x040024FC RID: 9468
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x040024FD RID: 9469
		[CompilerGenerated]
		private GroupBox groupBox_1;

		// Token: 0x040024FE RID: 9470
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x040024FF RID: 9471
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x04002500 RID: 9472
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04002501 RID: 9473
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04002502 RID: 9474
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04002503 RID: 9475
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04002504 RID: 9476
		[CompilerGenerated]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04002505 RID: 9477
		private string string_0;
	}
}

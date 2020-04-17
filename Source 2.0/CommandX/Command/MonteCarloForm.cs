using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns32;
using ns34;

namespace Command
{
	// 蒙特卡洛设置窗体
	[DesignerGenerated]
	public sealed partial class MonteCarloForm : Form
	{
		// 构造函数
		public MonteCarloForm()
		{
			base.Shown += new EventHandler(this.MonteCarloForm_Shown);
			this.string_0 = Path.Combine(CommandFactory.GetCommandApp().Info.DirectoryPath, "Analysis");
			this.bool_0 = false;
			this.bool_1 = false;
			this.InitializeComponent();
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x003CF6C8 File Offset: 0x003CD8C8
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x0002E6F7 File Offset: 0x0002C8F7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_8)
		{
			this.label_0 = label_8;
		}

		// Token: 0x06006C5B RID: 27739 RVA: 0x003CF6E0 File Offset: 0x003CD8E0
		[CompilerGenerated]
		internal  TextBox vmethod_2()
		{
			return this.textBox_0;
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x0002E700 File Offset: 0x0002C900
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TextBox textBox_2)
		{
			this.textBox_0 = textBox_2;
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x003CF6F8 File Offset: 0x003CD8F8
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_0;
		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x003CF710 File Offset: 0x003CD910
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_0);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_4;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x003CF75C File Offset: 0x003CD95C
		[CompilerGenerated]
		internal  Label vmethod_6()
		{
			return this.label_1;
		}

		// Token: 0x06006C60 RID: 27744 RVA: 0x0002E709 File Offset: 0x0002C909
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Label label_8)
		{
			this.label_1 = label_8;
		}

		// Token: 0x06006C61 RID: 27745 RVA: 0x003CF774 File Offset: 0x003CD974
		[CompilerGenerated]
		internal  TextBox vmethod_8()
		{
			return this.textBox_1;
		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x0002E712 File Offset: 0x0002C912
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TextBox textBox_2)
		{
			this.textBox_1 = textBox_2;
		}

		// Token: 0x06006C63 RID: 27747 RVA: 0x003CF78C File Offset: 0x003CD98C
		[CompilerGenerated]
		internal  Button vmethod_10()
		{
			return this.button_1;
		}

		// Token: 0x06006C64 RID: 27748 RVA: 0x003CF7A4 File Offset: 0x003CD9A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_1);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_4;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x003CF7F0 File Offset: 0x003CD9F0
		[CompilerGenerated]
		internal  Label vmethod_12()
		{
			return this.label_2;
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x0002E71B File Offset: 0x0002C91B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Label label_8)
		{
			this.label_2 = label_8;
		}

		// Token: 0x06006C67 RID: 27751 RVA: 0x003CF808 File Offset: 0x003CDA08
		[CompilerGenerated]
		internal  NumericUpDown GetRunTimesNumeric()
		{
			return this.RunTimesNumeric;
		}

		// Token: 0x06006C68 RID: 27752 RVA: 0x0002E724 File Offset: 0x0002C924
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetRunTimesNumeric(NumericUpDown numericUpDown_2)
		{
			this.RunTimesNumeric = numericUpDown_2;
		}

		// Token: 0x06006C69 RID: 27753 RVA: 0x003CF820 File Offset: 0x003CDA20
		[CompilerGenerated]
		internal  Button GetRunButton()
		{
			return this.RunButton;
		}

		// Token: 0x06006C6A RID: 27754 RVA: 0x003CF838 File Offset: 0x003CDA38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetRunButton(Button button_4)
		{
			EventHandler value = new EventHandler(this.RunButton_Click);
			Button runButton = this.RunButton;
			if (runButton != null)
			{
				runButton.Click -= value;
			}
			this.RunButton = button_4;
			runButton = this.RunButton;
			if (runButton != null)
			{
				runButton.Click += value;
			}
		}

		// Token: 0x06006C6B RID: 27755 RVA: 0x003CF884 File Offset: 0x003CDA84
		[CompilerGenerated]
		internal  OpenFileDialog vmethod_18()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x06006C6C RID: 27756 RVA: 0x0002E72D File Offset: 0x0002C92D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x06006C6D RID: 27757 RVA: 0x003CF89C File Offset: 0x003CDA9C
		[CompilerGenerated]
		internal  FolderBrowserDialog vmethod_20()
		{
			return this.folderBrowserDialog_0;
		}

		// Token: 0x06006C6E RID: 27758 RVA: 0x0002E736 File Offset: 0x0002C936
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(FolderBrowserDialog folderBrowserDialog_1)
		{
			this.folderBrowserDialog_0 = folderBrowserDialog_1;
		}

		// Token: 0x06006C6F RID: 27759 RVA: 0x003CF8B4 File Offset: 0x003CDAB4
		[CompilerGenerated]
		internal  BackgroundWorker GetSimulator()
		{
			return this.Simulator;
		}

		// Token: 0x06006C70 RID: 27760 RVA: 0x003CF8CC File Offset: 0x003CDACC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetSimulator(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler value = new DoWorkEventHandler(this.Simulator_DoWork);
			RunWorkerCompletedEventHandler value2 = new RunWorkerCompletedEventHandler(this.Simulator_RunWorkerCompleted);
			BackgroundWorker simulator = this.Simulator;
			if (simulator != null)
			{
				simulator.DoWork -= value;
				simulator.RunWorkerCompleted -= value2;
			}
			this.Simulator = backgroundWorker_1;
			simulator = this.Simulator;
			if (simulator != null)
			{
				simulator.DoWork += value;
				simulator.RunWorkerCompleted += value2;
			}
		}

		// Token: 0x06006C71 RID: 27761 RVA: 0x003CF930 File Offset: 0x003CDB30
		[CompilerGenerated]
		internal  Label vmethod_24()
		{
			return this.label_3;
		}

		// Token: 0x06006C72 RID: 27762 RVA: 0x0002E73F File Offset: 0x0002C93F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Label label_8)
		{
			this.label_3 = label_8;
		}

		// Token: 0x06006C73 RID: 27763 RVA: 0x003CF948 File Offset: 0x003CDB48
		[CompilerGenerated]
		internal  Timer vmethod_26()
		{
			return this.timer_0;
		}

		// Token: 0x06006C74 RID: 27764 RVA: 0x003CF960 File Offset: 0x003CDB60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_5);
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

		// Token: 0x06006C75 RID: 27765 RVA: 0x003CF9AC File Offset: 0x003CDBAC
		[CompilerGenerated]
		internal  Label vmethod_28()
		{
			return this.label_4;
		}

		// Token: 0x06006C76 RID: 27766 RVA: 0x0002E748 File Offset: 0x0002C948
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(Label label_8)
		{
			this.label_4 = label_8;
		}

		// Token: 0x06006C77 RID: 27767 RVA: 0x003CF9C4 File Offset: 0x003CDBC4
		[CompilerGenerated]
		internal  TabControl vmethod_30()
		{
			return this.tabControl_0;
		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x0002E751 File Offset: 0x0002C951
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(TabControl tabControl_1)
		{
			this.tabControl_0 = tabControl_1;
		}

		// Token: 0x06006C79 RID: 27769 RVA: 0x003CF9DC File Offset: 0x003CDBDC
		[CompilerGenerated]
		internal  TabPage vmethod_32()
		{
			return this.tabPage_0;
		}

		// Token: 0x06006C7A RID: 27770 RVA: 0x0002E75A File Offset: 0x0002C95A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(TabPage tabPage_2)
		{
			this.tabPage_0 = tabPage_2;
		}

		// Token: 0x06006C7B RID: 27771 RVA: 0x003CF9F4 File Offset: 0x003CDBF4
		[CompilerGenerated]
		internal  TabPage vmethod_34()
		{
			return this.tabPage_1;
		}

		// Token: 0x06006C7C RID: 27772 RVA: 0x0002E763 File Offset: 0x0002C963
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(TabPage tabPage_2)
		{
			this.tabPage_1 = tabPage_2;
		}

		// Token: 0x06006C7D RID: 27773 RVA: 0x003CFA0C File Offset: 0x003CDC0C
		[CompilerGenerated]
		internal  Label vmethod_36()
		{
			return this.label_5;
		}

		// Token: 0x06006C7E RID: 27774 RVA: 0x0002E76C File Offset: 0x0002C96C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(Label label_8)
		{
			this.label_5 = label_8;
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x003CFA24 File Offset: 0x003CDC24
		[CompilerGenerated]
		internal  NumericUpDown GetElapsedTimeNumeric()
		{
			return this.ElapsedTimeNumeric;
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x0002E775 File Offset: 0x0002C975
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetElapsedTimeNumeric(NumericUpDown numericUpDown_2)
		{
			this.ElapsedTimeNumeric = numericUpDown_2;
		}

		// Token: 0x06006C81 RID: 27777 RVA: 0x003CFA3C File Offset: 0x003CDC3C
		[CompilerGenerated]
		internal  Label vmethod_40()
		{
			return this.label_6;
		}

		// Token: 0x06006C82 RID: 27778 RVA: 0x0002E77E File Offset: 0x0002C97E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Label label_8)
		{
			this.label_6 = label_8;
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x003CFA54 File Offset: 0x003CDC54
		[CompilerGenerated]
		internal  CheckBox GetCB_Record()
		{
			return this.checkBox_0;
		}

		// Token: 0x06006C84 RID: 27780 RVA: 0x0002E787 File Offset: 0x0002C987
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(CheckBox checkBox_5)
		{
			this.checkBox_0 = checkBox_5;
		}

		// Token: 0x06006C85 RID: 27781 RVA: 0x003CFA6C File Offset: 0x003CDC6C
		[CompilerGenerated]
		internal  CheckBox vmethod_44()
		{
			return this.checkBox_1;
		}

		// Token: 0x06006C86 RID: 27782 RVA: 0x0002E790 File Offset: 0x0002C990
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(CheckBox checkBox_5)
		{
			this.checkBox_1 = checkBox_5;
		}

		// Token: 0x06006C87 RID: 27783 RVA: 0x003CFA84 File Offset: 0x003CDC84
		[CompilerGenerated]
		internal  CheckBox vmethod_46()
		{
			return this.checkBox_2;
		}

		// Token: 0x06006C88 RID: 27784 RVA: 0x0002E799 File Offset: 0x0002C999
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(CheckBox checkBox_5)
		{
			this.checkBox_2 = checkBox_5;
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x003CFA9C File Offset: 0x003CDC9C
		[CompilerGenerated]
		internal  CheckBox vmethod_48()
		{
			return this.checkBox_3;
		}

		// Token: 0x06006C8A RID: 27786 RVA: 0x0002E7A2 File Offset: 0x0002C9A2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(CheckBox checkBox_5)
		{
			this.checkBox_3 = checkBox_5;
		}

		// Token: 0x06006C8B RID: 27787 RVA: 0x003CFAB4 File Offset: 0x003CDCB4
		[CompilerGenerated]
		internal  CheckBox vmethod_50()
		{
			return this.checkBox_4;
		}

		// Token: 0x06006C8C RID: 27788 RVA: 0x0002E7AB File Offset: 0x0002C9AB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(CheckBox checkBox_5)
		{
			this.checkBox_4 = checkBox_5;
		}

		// Token: 0x06006C8D RID: 27789 RVA: 0x003CFACC File Offset: 0x003CDCCC
		[CompilerGenerated]
		internal  Label vmethod_52()
		{
			return this.label_7;
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x0002E7B4 File Offset: 0x0002C9B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Label label_8)
		{
			this.label_7 = label_8;
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x003CFAE4 File Offset: 0x003CDCE4
		[CompilerGenerated]
		internal  Button vmethod_54()
		{
			return this.button_3;
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x003CFAFC File Offset: 0x003CDCFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(Button button_4)
		{
			EventHandler value = new EventHandler(this.method_7);
			Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_4;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x0002E7BD File Offset: 0x0002C9BD
		private void MonteCarloForm_Shown(object sender, EventArgs e)
		{
			this.vmethod_8().Text = this.string_0;
			this.vmethod_26().Start();
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x0002E7DB File Offset: 0x0002C9DB
		private void method_0(object sender, EventArgs e)
		{
			if (this.vmethod_18().ShowDialog() == DialogResult.OK)
			{
				this.vmethod_2().Text = this.vmethod_18().FileName;
			}
		}

		// Token: 0x06006C93 RID: 27795 RVA: 0x003CFB48 File Offset: 0x003CDD48
		private void method_1(object sender, EventArgs e)
		{
			if (!Directory.Exists(this.string_0))
			{
				Directory.CreateDirectory(this.string_0);
			}
			this.vmethod_20().SelectedPath = this.string_0;
			if (this.vmethod_20().ShowDialog() == DialogResult.OK)
			{
				this.vmethod_8().Text = this.vmethod_20().SelectedPath;
			}
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x003CFBA8 File Offset: 0x003CDDA8
		private void method_2()
		{
			if (this.vmethod_50().Checked)
			{
				if (EventExporters.listMonteCarlo.Where(MonteCarloForm.EventExporterFunc0).Count<IEventExporter>() == 0)
				{
					EventExporters.listMonteCarlo.Add(new EventExport_CSV(_RunMode.MonteCarlo));
				}
			}
			else if (EventExporters.listMonteCarlo.Where(MonteCarloForm.EventExporterFunc1).Any<IEventExporter>())
			{
				EventExport_CSV item = (EventExport_CSV)EventExporters.listMonteCarlo.Where(MonteCarloForm.EventExporterFunc2).ElementAtOrDefault(0);
				EventExporters.listMonteCarlo.Remove(item);
			}
			if (this.vmethod_46().Checked)
			{
				if (EventExporters.listMonteCarlo.Where(MonteCarloForm.EventExporterFunc3).Count<IEventExporter>() == 0)
				{
					EventExporters.listMonteCarlo.Add(new EventExport_MSAccess(_RunMode.MonteCarlo));
				}
			}
			else if (EventExporters.listMonteCarlo.Where(MonteCarloForm.EventExporterFunc4).Any<IEventExporter>())
			{
				EventExport_MSAccess item2 = (EventExport_MSAccess)EventExporters.listMonteCarlo.Where(MonteCarloForm.EventExporterFunc5).ElementAtOrDefault(0);
				EventExporters.listMonteCarlo.Remove(item2);
			}
			if (this.vmethod_48().Checked)
			{
				if (EventExporters.listMonteCarlo.Where(MonteCarloForm.EventExporterFunc6).Count<IEventExporter>() == 0)
				{
					EventExporters.listMonteCarlo.Add(new EventExport_Tacview1x(_RunMode.MonteCarlo, null));
				}
			}
			else if (EventExporters.listMonteCarlo.Where(MonteCarloForm.EventExporterFunc7).Any<IEventExporter>())
			{
				EventExport_Tacview1x item3 = (EventExport_Tacview1x)EventExporters.listMonteCarlo.Where(MonteCarloForm.EventExporterFunc8).ElementAtOrDefault(0);
				EventExporters.listMonteCarlo.Remove(item3);
			}
			if (this.vmethod_44().Checked)
			{
				if (EventExporters.listMonteCarlo.Where(MonteCarloForm.EventExporterFunc9).Count<IEventExporter>() == 0)
				{
					EventExporters.listMonteCarlo.Add(new EventExport_XMLFile(_RunMode.MonteCarlo));
				}
			}
			else if (EventExporters.listMonteCarlo.Where(MonteCarloForm.EventExporterFunc10).Any<IEventExporter>())
			{
				EventExport_XMLFile item4 = (EventExport_XMLFile)EventExporters.listMonteCarlo.Where(MonteCarloForm.EventExporterFunc11).ElementAtOrDefault(0);
				EventExporters.listMonteCarlo.Remove(item4);
			}
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x003CFDB0 File Offset: 0x003CDFB0
		private void RunButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.vmethod_2().Text))
			{
				Interaction.MsgBox("没有选择仿真想定!", MsgBoxStyle.OkOnly, null);
			}
			else if (string.IsNullOrEmpty(this.vmethod_8().Text))
			{
				Interaction.MsgBox("没有选择仿真结果保存路径!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				this.string_1 = this.vmethod_2().Text;
				this.string_2 = this.vmethod_8().Text;
				if (!Directory.Exists(this.string_2))
				{
					Directory.CreateDirectory(this.string_2);
				}
				else if (!Misc.smethod_0(this.string_2))
				{
					if (Interaction.MsgBox("所选文件夹非空！删除内容并继续，或者取消?", MsgBoxStyle.OkCancel, null) == MsgBoxResult.Cancel)
					{
						return;
					}
					Misc.ClearTemp(this.string_2);
				}
				this.RunTimes = Convert.ToInt32(this.GetRunTimesNumeric().Value);
				this.CurrentSimTime = Convert.ToInt32(this.GetElapsedTimeNumeric().Value);
				this.method_2();
				this.vmethod_30().Enabled = false;
				this.GetRunButton().Enabled = false;
				this.vmethod_54().Enabled = true;
				this.GetSimulator().RunWorkerAsync();
			}
		}

		// Token: 0x06006C96 RID: 27798 RVA: 0x003CFED8 File Offset: 0x003CE0D8
		private void Simulator_DoWork(object sender, DoWorkEventArgs e)
		{
			this.bool_0 = true;
			ScenContainer scenContainer = ScenContainer.smethod_2(this.string_1);
			StreamWriter streamWriter = File.AppendText(this.string_2 + "\\Summary.txt");
			streamWriter.AutoFlush = true;
			int num = 0;
			int num2 = 1;
			int runTimes = this.RunTimes;
			this.Iteration = 1;
			while (this.Iteration <= runTimes)
			{
				this.m_scenario = null;
				if (!this.bool_1)
				{
					ScenContainer scenContainer2 = scenContainer;
					string text = null;
					double num3 = 0.0;
					this.m_scenario = scenContainer2.LoadScenario(ref text, ref num3, false);
					this.m_scenario.SetTimeStep((float)num2);
					this.m_scenario.RunningInMonteCarloMode = true;
					this.m_scenario.SetTimelineID();
					num = 0;
					Directory.CreateDirectory(Path.Combine(this.string_0, Conversions.ToString(this.Iteration)));
					using (List<IEventExporter>.Enumerator enumerator = EventExporters.listMonteCarlo.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.SetExportDirectory(Path.Combine(this.string_0, Conversions.ToString(this.Iteration)));
						}
					}
					if (this.GetCB_Record().Checked)
					{
						Client.m_ScenarioSnapshots = Recorder.GetScenarioSnapshots(Path.Combine(this.string_0, Conversions.ToString(this.Iteration)), Conversions.ToString(this.Iteration));
					}
					float num4 = 0f;
					while (!this.m_scenario.HasEnded())
					{
						if (this.bool_1)
						{
							this.bool_0 = false;
							return;
						}
						Scenario scenario = this.m_scenario;
						num3 = (double)num4;
						Client.ProcessEvent(scenario, ref num3);
						num4 = (float)num3;
						num += num2;
						if (this.GetCB_Record().Checked && num >= this.CurrentSimTime)
						{
							MemoryStream scenarioStream = GameGeneral.GetScenarioStream(this.m_scenario);
							Client.m_ScenarioSnapshots.AddScenarioSnapshot(this.m_scenario.GetCurrentTime(false), scenarioStream);
							num = 0;
						}
						this.CheckScenCompleteCondition();
					}
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine("#######################");
					streamWriter.WriteLine("Iteration #" + Conversions.ToString(this.Iteration));
					streamWriter.WriteLine("Timeline ID: " + this.m_scenario.TimelineID);
					streamWriter.WriteLine("#######################");
					Side[] sides = this.m_scenario.GetSides();
					checked
					{
						for (int i = 0; i < sides.Length; i++)
						{
							Side side_ = sides[i];
							streamWriter.WriteLine("\r\n");
							streamWriter.WriteLine(Losses.GetLossesAndExpendituresStatistics(side_, this.m_scenario));
						}
						streamWriter.WriteLine("#######################");
						streamWriter.WriteLine("\r\n");
					}
					this.Iteration++;
					continue;
				}
				this.bool_0 = false;
				return;
			}
			streamWriter.Close();
			this.bool_0 = false;
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x003D01C0 File Offset: 0x003CE3C0
		public void CheckScenCompleteCondition()
		{
			if (DateTime.Compare(this.m_scenario.GetCurrentTime(false), this.m_scenario.GetStartTime().Add(this.m_scenario.GetDuration())) > 0 && !this.m_scenario.HasEnded())
			{
				this.m_scenario.ScenCompleted();
			}
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x003D021C File Offset: 0x003CE41C
		private void method_5(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.m_scenario))
			{
				this.vmethod_24().Text = "仿真时间: " + this.m_scenario.GetCurrentTime(false).ToString();
				this.vmethod_28().Text = "当前次数: " + Conversions.ToString(this.Iteration);
			}
			if (EventExporters.listMonteCarlo.Any<IEventExporter>())
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("\r\n").Append("事件队列长度:");
				foreach (IEventExporter current in EventExporters.listMonteCarlo)
				{
					stringBuilder.Append(" ").Append(current.GetExporterName()).Append(":").Append(current.GetEventQueueLength());
				}
				this.vmethod_52().Text = stringBuilder.ToString();
			}
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x003D0330 File Offset: 0x003CE530
		private void Simulator_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			using (List<IEventExporter>.Enumerator enumerator = EventExporters.listMonteCarlo.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.StopExport();
				}
			}
			this.vmethod_30().Enabled = true;
			this.GetRunButton().Enabled = true;
			this.vmethod_26().Stop();
			if (this.bool_1)
			{
				this.bool_1 = false;
				Interaction.MsgBox("蒙特卡洛仿真终止.", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				Interaction.MsgBox("蒙特卡洛仿真结束!", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x0002E806 File Offset: 0x0002CA06
		private void method_7(object sender, EventArgs e)
		{
			this.bool_1 = true;
			this.vmethod_54().Enabled = false;
		}

		// Token: 0x04003E6D RID: 15981
		public static Func<IEventExporter, bool> EventExporterFunc0 = (IEventExporter ieventExporter_0) => ieventExporter_0.GetExporterType() == _ExporterType.CSVFile;

		// Token: 0x04003E6E RID: 15982
		public static Func<IEventExporter, bool> EventExporterFunc1 = (IEventExporter ieventExporter_0) => ieventExporter_0.GetExporterType() == _ExporterType.CSVFile;

		// Token: 0x04003E6F RID: 15983
		public static Func<IEventExporter, bool> EventExporterFunc2 = (IEventExporter ieventExporter_0) => ieventExporter_0.GetExporterType() == _ExporterType.CSVFile;

		// Token: 0x04003E70 RID: 15984
		public static Func<IEventExporter, bool> EventExporterFunc3 = (IEventExporter ieventExporter_0) => ieventExporter_0.GetExporterType() == _ExporterType.MSAccess;

		// Token: 0x04003E71 RID: 15985
		public static Func<IEventExporter, bool> EventExporterFunc4 = (IEventExporter ieventExporter_0) => ieventExporter_0.GetExporterType() == _ExporterType.MSAccess;

		// Token: 0x04003E72 RID: 15986
		public static Func<IEventExporter, bool> EventExporterFunc5 = (IEventExporter ieventExporter_0) => ieventExporter_0.GetExporterType() == _ExporterType.MSAccess;

		// Token: 0x04003E73 RID: 15987
		public static Func<IEventExporter, bool> EventExporterFunc6 = (IEventExporter ieventExporter_0) => ieventExporter_0.GetExporterType() == _ExporterType.Tacview1x;

		// Token: 0x04003E74 RID: 15988
		public static Func<IEventExporter, bool> EventExporterFunc7 = (IEventExporter ieventExporter_0) => ieventExporter_0.GetExporterType() == _ExporterType.Tacview1x;

		// Token: 0x04003E75 RID: 15989
		public static Func<IEventExporter, bool> EventExporterFunc8 = (IEventExporter ieventExporter_0) => ieventExporter_0.GetExporterType() == _ExporterType.Tacview1x;

		// Token: 0x04003E76 RID: 15990
		public static Func<IEventExporter, bool> EventExporterFunc9 = (IEventExporter ieventExporter_0) => ieventExporter_0.GetExporterType() == _ExporterType.XMLFile;

		// Token: 0x04003E77 RID: 15991
		public static Func<IEventExporter, bool> EventExporterFunc10 = (IEventExporter ieventExporter_0) => ieventExporter_0.GetExporterType() == _ExporterType.XMLFile;

		// Token: 0x04003E78 RID: 15992
		public static Func<IEventExporter, bool> EventExporterFunc11 = (IEventExporter ieventExporter_0) => ieventExporter_0.GetExporterType() == _ExporterType.XMLFile;

		// Token: 0x04003E7A RID: 15994
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04003E7B RID: 15995
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04003E7C RID: 15996
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04003E7D RID: 15997
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04003E7E RID: 15998
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x04003E7F RID: 15999
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04003E80 RID: 16000
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04003E81 RID: 16001
		[CompilerGenerated]
		private NumericUpDown RunTimesNumeric;

		// Token: 0x04003E82 RID: 16002
		[CompilerGenerated]
		private Button RunButton;

		// Token: 0x04003E83 RID: 16003
		[CompilerGenerated]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04003E84 RID: 16004
		[CompilerGenerated]
		private FolderBrowserDialog folderBrowserDialog_0;

		// Token: 0x04003E85 RID: 16005
		[CompilerGenerated]
		private BackgroundWorker Simulator;

		// Token: 0x04003E86 RID: 16006
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04003E87 RID: 16007
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x04003E88 RID: 16008
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04003E89 RID: 16009
		[CompilerGenerated]
		private TabControl tabControl_0;

		// Token: 0x04003E8A RID: 16010
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x04003E8B RID: 16011
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x04003E8C RID: 16012
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x04003E8D RID: 16013
		[CompilerGenerated]
		private NumericUpDown ElapsedTimeNumeric;

		// Token: 0x04003E8E RID: 16014
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x04003E8F RID: 16015
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04003E90 RID: 16016
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x04003E91 RID: 16017
		[CompilerGenerated]
		private CheckBox checkBox_2;

		// Token: 0x04003E92 RID: 16018
		[CompilerGenerated]
		private CheckBox checkBox_3;

		// Token: 0x04003E93 RID: 16019
		[CompilerGenerated]
		private CheckBox checkBox_4;

		// Token: 0x04003E94 RID: 16020
		[CompilerGenerated]
		private Label label_7;

		// Token: 0x04003E95 RID: 16021
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04003E96 RID: 16022
		public string string_0;

		// Token: 0x04003E97 RID: 16023
		private int RunTimes;

		// Token: 0x04003E98 RID: 16024
		private int Iteration;

		// Token: 0x04003E99 RID: 16025
		private string string_1;

		// Token: 0x04003E9A RID: 16026
		private Scenario m_scenario;

		// Token: 0x04003E9B RID: 16027
		private string string_2 = "";

		// Token: 0x04003E9C RID: 16028
		private int CurrentSimTime = 0;

		// Token: 0x04003E9D RID: 16029
		private bool bool_0;

		// Token: 0x04003E9E RID: 16030
		private bool bool_1;
	}
}

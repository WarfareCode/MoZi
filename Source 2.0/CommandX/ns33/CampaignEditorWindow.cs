using System;
using System.Collections;
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
using ns3;
using ns32;

namespace ns33
{
	// Token: 0x02000977 RID: 2423
	[DesignerGenerated]
	public sealed partial class CampaignEditorWindow : CommandForm
	{
		// Token: 0x06003BA3 RID: 15267 RVA: 0x00127184 File Offset: 0x00125384
		public CampaignEditorWindow()
		{
			base.FormClosing += new FormClosingEventHandler(this.CampaignEditorWindow_FormClosing);
			base.VisibleChanged += new EventHandler(this.CampaignEditorWindow_VisibleChanged);
			base.Load += new EventHandler(this.CampaignEditorWindow_Load);
			this.InitializeComponent();
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x00127B80 File Offset: 0x00125D80
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x00127B98 File Offset: 0x00125D98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			EventHandler value = new EventHandler(this.method_8);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.SelectionChanged -= value;
			}
			this.dataGridView_0 = dataGridView_1;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.SelectionChanged += value;
			}
		}

		// Token: 0x06003BA8 RID: 15272 RVA: 0x00127BE4 File Offset: 0x00125DE4
		[CompilerGenerated]
		internal  ToolStrip vmethod_2()
		{
			return this.toolStrip_0;
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x0001F929 File Offset: 0x0001DB29
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStrip toolStrip_2)
		{
			this.toolStrip_0 = toolStrip_2;
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x00127BFC File Offset: 0x00125DFC
		[CompilerGenerated]
		internal  ToolStripButton vmethod_4()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x00127C14 File Offset: 0x00125E14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_2);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_9;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x00127C60 File Offset: 0x00125E60
		[CompilerGenerated]
		internal  ToolStripButton vmethod_6()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x00127C78 File Offset: 0x00125E78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_3);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_9;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x00127CC4 File Offset: 0x00125EC4
		[CompilerGenerated]
		internal  ToolStripButton vmethod_8()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x00127CDC File Offset: 0x00125EDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_4);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_9;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x00127D28 File Offset: 0x00125F28
		[CompilerGenerated]
		internal  ToolStripButton vmethod_10()
		{
			return this.toolStripButton_3;
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x00127D40 File Offset: 0x00125F40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_5);
			ToolStripButton toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_3 = toolStripButton_9;
			toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x00127D8C File Offset: 0x00125F8C
		[CompilerGenerated]
		internal  ToolStripButton vmethod_12()
		{
			return this.toolStripButton_4;
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x00127DA4 File Offset: 0x00125FA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_6);
			ToolStripButton toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_4 = toolStripButton_9;
			toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x00127DF0 File Offset: 0x00125FF0
		[CompilerGenerated]
		internal  OpenFileDialog vmethod_14()
		{
			return this.openFileDialog_0;
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x0001F932 File Offset: 0x0001DB32
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(OpenFileDialog openFileDialog_1)
		{
			this.openFileDialog_0 = openFileDialog_1;
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x00127E08 File Offset: 0x00126008
		[CompilerGenerated]
		internal  SaveFileDialog vmethod_16()
		{
			return this.saveFileDialog_0;
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x0001F93B File Offset: 0x0001DB3B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(SaveFileDialog saveFileDialog_1)
		{
			this.saveFileDialog_0 = saveFileDialog_1;
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x00127E20 File Offset: 0x00126020
		[CompilerGenerated]
		internal  ToolStripButton vmethod_18()
		{
			return this.toolStripButton_5;
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x00127E38 File Offset: 0x00126038
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_7);
			ToolStripButton toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_5 = toolStripButton_9;
			toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x00127E84 File Offset: 0x00126084
		[CompilerGenerated]
		internal  ToolStripButton vmethod_20()
		{
			return this.toolStripButton_6;
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x00127E9C File Offset: 0x0012609C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_9);
			ToolStripButton toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_6 = toolStripButton_9;
			toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x00127EE8 File Offset: 0x001260E8
		[CompilerGenerated]
		internal  ToolStripButton vmethod_22()
		{
			return this.toolStripButton_7;
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x00127F00 File Offset: 0x00126100
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_10);
			ToolStripButton toolStripButton = this.toolStripButton_7;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_7 = toolStripButton_9;
			toolStripButton = this.toolStripButton_7;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x00127F4C File Offset: 0x0012614C
		[CompilerGenerated]
		internal  ToolStrip vmethod_24()
		{
			return this.toolStrip_1;
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x0001F944 File Offset: 0x0001DB44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(ToolStrip toolStrip_2)
		{
			this.toolStrip_1 = toolStrip_2;
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x00127F64 File Offset: 0x00126164
		[CompilerGenerated]
		internal  ToolStripLabel vmethod_26()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x0001F94D File Offset: 0x0001DB4D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(ToolStripLabel toolStripLabel_1)
		{
			this.toolStripLabel_0 = toolStripLabel_1;
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x00127F7C File Offset: 0x0012617C
		[CompilerGenerated]
		internal  ToolStripTextBox vmethod_28()
		{
			return this.toolStripTextBox_0;
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x0001F956 File Offset: 0x0001DB56
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(ToolStripTextBox toolStripTextBox_1)
		{
			this.toolStripTextBox_0 = toolStripTextBox_1;
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x00127F94 File Offset: 0x00126194
		[CompilerGenerated]
		internal  ToolStripButton vmethod_30()
		{
			return this.toolStripButton_8;
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x00127FAC File Offset: 0x001261AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(ToolStripButton toolStripButton_9)
		{
			EventHandler value = new EventHandler(this.method_11);
			ToolStripButton toolStripButton = this.toolStripButton_8;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_8 = toolStripButton_9;
			toolStripButton = this.toolStripButton_8;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x00127FF8 File Offset: 0x001261F8
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_32()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x0001F95F File Offset: 0x0001DB5F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x00128010 File Offset: 0x00126210
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_34()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x0001F968 File Offset: 0x0001DB68
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x00128028 File Offset: 0x00126228
		public void method_1()
		{
			object obj = null;
			if (this.vmethod_0().SelectedRows.Count > 0)
			{
				obj = RuntimeHelpers.GetObjectValue(this.vmethod_0().SelectedRows[0].Tag);
			}
			this.vmethod_0().Rows.Clear();
			foreach (Campaign.Scenario current in this.class111_0.ScenarioList)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				dataGridViewRow.ReadOnly = false;
				dataGridViewRow.CreateCells(this.vmethod_0());
				Type type = current.GetType();
				if (type == typeof(Campaign.ScenarioInfo))
				{
					dataGridViewRow.Cells[0].Value = "想定: " + current.strScenarioName;
					dataGridViewRow.Cells[1].Value = ((Campaign.ScenarioInfo)current).GetPassScore();
				}
				else if (type == typeof(Campaign.ScenarioInstance))
				{
					dataGridViewRow.Cells[0].Value = "附件: " + current.strScenarioName;
					dataGridViewRow.Cells[1].Value = "";
				}
				dataGridViewRow.Tag = current;
				this.vmethod_0().Rows.Add(dataGridViewRow);
			}
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(obj)))
			{
				IEnumerator enumerator2 = ((IEnumerable)this.vmethod_0().Rows).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)enumerator2.Current;
						if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Tag)) && obj == dataGridViewRow2.Tag)
						{
							dataGridViewRow2.Selected = true;
							break;
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
			}
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x0001F971 File Offset: 0x0001DB71
		private void CampaignEditorWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x00128238 File Offset: 0x00126438
		private void method_2(object sender, EventArgs e)
		{
			this.vmethod_14().Filter = "CommandX想定文件(*.scen)|*.scen";
			if (this.vmethod_14().ShowDialog() == DialogResult.OK)
			{
				try
				{
					ScenContainer scenContainer = ScenContainer.smethod_2(this.vmethod_14().FileName);
					string text = null;
					double num = 0.0;
					Scenario scenario = scenContainer.LoadScenario(ref text, ref num, false);
					scenario.CampaignID = this.class111_0.ID;
					Class260.SaveTempScenarioFile(scenario, scenario.GetSides()[0], this.vmethod_14().FileName, false, false);
					Campaign.ScenarioInfo scenarioInfo = new Campaign.ScenarioInfo();
					scenarioInfo.strScenarioName = scenario.GetScenarioTitle();
					scenarioInfo.strScenarioID = scenario.GetObjectID();
					scenarioInfo.strScenarioFile = Path.GetFileName(this.vmethod_14().FileName);
					this.class111_0.ScenarioList.Add(scenarioInfo);
					this.method_1();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					Interaction.MsgBox("不能加载所选想定。错误为: " + ex2.Message, MsgBoxStyle.OkOnly, null);
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x00128360 File Offset: 0x00126560
		private void method_3(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count > 0)
			{
				IEnumerator enumerator = this.vmethod_0().SelectedRows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						this.class111_0.ScenarioList.Remove((Campaign.Scenario)NewLateBinding.LateGet(objectValue, null, "Tag", new object[0], null, null, null));
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.method_1();
			}
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x0012840C File Offset: 0x0012660C
		private void method_4(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				if (this.vmethod_0().SelectedRows.Count > 1)
				{
					Interaction.MsgBox("一次只能重排一项", MsgBoxStyle.OkOnly, "一次一项!");
				}
				else
				{
					Campaign.Scenario item = (Campaign.Scenario)this.vmethod_0().SelectedRows[0].Tag;
					int num = this.class111_0.ScenarioList.IndexOf(item);
					if (num != 0)
					{
						this.class111_0.ScenarioList.Remove(item);
						this.class111_0.ScenarioList.Insert(num - 1, item);
						this.method_1();
					}
				}
			}
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x001284BC File Offset: 0x001266BC
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				if (this.vmethod_0().SelectedRows.Count > 1)
				{
					Interaction.MsgBox("一次只能重排一项", MsgBoxStyle.OkOnly, "一次一项!");
				}
				else
				{
					Campaign.Scenario item = (Campaign.Scenario)this.vmethod_0().SelectedRows[0].Tag;
					int num = this.class111_0.ScenarioList.IndexOf(item);
					if (num != this.class111_0.ScenarioList.Count - 1)
					{
						this.class111_0.ScenarioList.Remove(item);
						this.class111_0.ScenarioList.Insert(num + 1, item);
						this.method_1();
					}
				}
			}
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x00128580 File Offset: 0x00126780
		private void method_6(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.string_0))
			{
				this.vmethod_16().Filter = "CommandX战役文件(*.campaign)|*.campaign";
				if (this.vmethod_16().ShowDialog() == DialogResult.OK)
				{
					this.class111_0.method_1(this.vmethod_16().FileName);
					this.string_0 = this.vmethod_16().FileName;
				}
			}
			else
			{
				this.class111_0.method_1(this.string_0);
			}
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x0001F980 File Offset: 0x0001DB80
		private void CampaignEditorWindow_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				this.method_1();
			}
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x001285FC File Offset: 0x001267FC
		private void method_7(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetTitleAndDescription().string_0 = this.class111_0.Name;
			CommandFactory.GetCommandMain().GetTitleAndDescription().string_1 = this.class111_0.strDescription;
			if (CommandFactory.GetCommandMain().GetTitleAndDescription().ShowDialog() == DialogResult.OK)
			{
				this.class111_0.Name = CommandFactory.GetCommandMain().GetTitleAndDescription().string_0;
				this.class111_0.strDescription = CommandFactory.GetCommandMain().GetTitleAndDescription().string_1;
			}
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x00128688 File Offset: 0x00126888
		private void method_8(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0)
			{
				Campaign.Scenario scenario = (Campaign.Scenario)this.vmethod_0().SelectedRows[0].Tag;
				if (scenario.GetType() == typeof(Campaign.ScenarioInfo))
				{
					this.vmethod_24().Visible = true;
					this.vmethod_28().Text = Conversions.ToString(((Campaign.ScenarioInfo)scenario).GetPassScore());
				}
				else
				{
					this.vmethod_24().Visible = false;
				}
			}
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x00128718 File Offset: 0x00126918
		private void method_9(object sender, EventArgs e)
		{
			if (CommandFactory.GetCommandMain().method_64().ShowDialog() == DialogResult.OK)
			{
				foreach (ScenAttachmentObject current in CommandFactory.GetCommandMain().method_64().ScenAttachmentObjects)
				{
					Campaign.ScenarioInstance scenarioInstance = new Campaign.ScenarioInstance();
					scenarioInstance.strScenarioName = current.method_1();
					scenarioInstance.strScenarioID = current.method_0();
					this.class111_0.ScenarioList.Add(scenarioInstance);
				}
				if (CommandFactory.GetCommandMain().method_64().ScenAttachmentObjects.Count > 0)
				{
					this.method_1();
				}
			}
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x001287D8 File Offset: 0x001269D8
		private void method_10(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetTitleAndDescription().string_0 = "战役终局描述";
			CommandFactory.GetCommandMain().GetTitleAndDescription().string_1 = this.class111_0.strEndingText;
			if (CommandFactory.GetCommandMain().GetTitleAndDescription().ShowDialog() == DialogResult.OK)
			{
				this.class111_0.strEndingText = CommandFactory.GetCommandMain().GetTitleAndDescription().string_1;
			}
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x00128844 File Offset: 0x00126A44
		private void method_11(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count > 0)
			{
				IEnumerator enumerator = this.vmethod_0().SelectedRows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null))) && NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null).GetType() == typeof(Campaign.ScenarioInfo))
						{
							((Campaign.ScenarioInfo)NewLateBinding.LateGet(objectValue, null, "Tag", new object[0], null, null, null)).SetPassScore(Conversions.ToInteger(this.vmethod_28().Text));
							this.method_1();
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void CampaignEditorWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001B3D RID: 6973
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04001B3E RID: 6974
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x04001B3F RID: 6975
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04001B40 RID: 6976
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04001B41 RID: 6977
		[CompilerGenerated]
		private ToolStripButton toolStripButton_2;

		// Token: 0x04001B42 RID: 6978
		[CompilerGenerated]
		private ToolStripButton toolStripButton_3;

		// Token: 0x04001B43 RID: 6979
		[CompilerGenerated]
		private ToolStripButton toolStripButton_4;

		// Token: 0x04001B44 RID: 6980
		[CompilerGenerated]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04001B45 RID: 6981
		[CompilerGenerated]
		private SaveFileDialog saveFileDialog_0;

		// Token: 0x04001B46 RID: 6982
		[CompilerGenerated]
		private ToolStripButton toolStripButton_5;

		// Token: 0x04001B47 RID: 6983
		[CompilerGenerated]
		private ToolStripButton toolStripButton_6;

		// Token: 0x04001B48 RID: 6984
		[CompilerGenerated]
		private ToolStripButton toolStripButton_7;

		// Token: 0x04001B49 RID: 6985
		[CompilerGenerated]
		private ToolStrip toolStrip_1;

		// Token: 0x04001B4A RID: 6986
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x04001B4B RID: 6987
		[CompilerGenerated]
		private ToolStripTextBox toolStripTextBox_0;

		// Token: 0x04001B4C RID: 6988
		[CompilerGenerated]
		private ToolStripButton toolStripButton_8;

		// Token: 0x04001B4D RID: 6989
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04001B4E RID: 6990
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04001B4F RID: 6991
		public Campaign class111_0;

		// Token: 0x04001B50 RID: 6992
		public string string_0;
	}
}

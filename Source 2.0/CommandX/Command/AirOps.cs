using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using AdvancedDataGridView;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns15;
using ns2;
using ns29;
using ns3;
using ns32;
using ns33;
using ns4;
using ThreadSafeControls;

namespace Command
{
	// Token: 0x020009A3 RID: 2467
	[DesignerGenerated]
	public sealed partial class AirOps : CommandForm
	{
		// Token: 0x0600402A RID: 16426 RVA: 0x0015A2B0 File Offset: 0x001584B0
		public AirOps()
		{
			base.FormClosing += new FormClosingEventHandler(this.AirOps_FormClosing);
			base.Shown += new EventHandler(this.AirOps_Shown);
			base.KeyDown += new KeyEventHandler(this.AirOps_KeyDown);
			base.FormClosed += new FormClosedEventHandler(this.AirOps_FormClosed);
			base.Load += new EventHandler(this.AirOps_Load);
			this.HostUnitSet = new HashSet<ActiveUnit>();
			this.SelectedAvaibleAircrafts = new Collection<ActiveUnit>();
			this.collection_1 = new Collection<Aircraft>();
			this.collection_2 = new Collection<Aircraft>();
			this.class2472_0 = new Class2472();
			this.collection_3 = new Collection<int>();
			this.dataTable_0 = new DataTable();
			this.dataTable_1 = new DataTable();
			this.dictionary_0 = new Dictionary<int, int>();
			this.backgroundWorker_0 = new BackgroundWorker();this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.method_30);this.backgroundWorker_0.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.method_31);
			this.InitializeComponent();
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x0015C46C File Offset: 0x0015A66C
//		[CompilerGenerated]
//		internal  TabControl vmethod_0()
//		{
//			return this.tabControl_0;
//		}

		// Token: 0x0600402E RID: 16430 RVA: 0x0015C484 File Offset: 0x0015A684
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_1(TabControl tabControl_1)
//		{
//			EventHandler value = new EventHandler(this.method_19);
//			TabControl tabControl = this.tabControl_0;
//			if (tabControl != null)
//			{
//				tabControl.SelectedIndexChanged -= value;
//			}
//			this.tabControl_0 = tabControl_1;
//			tabControl = this.tabControl_0;
//			if (tabControl != null)
//			{
//				tabControl.SelectedIndexChanged += value;
//			}
//		}

		// Token: 0x0600402F RID: 16431 RVA: 0x0015C4D0 File Offset: 0x0015A6D0
//		[CompilerGenerated]
//		internal  TabPage vmethod_2()
//		{
//			return this.tabPage_0;
//		}

		// Token: 0x06004030 RID: 16432 RVA: 0x00020DED File Offset: 0x0001EFED
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_3(TabPage tabPage_2)
//		{
//			this.tabPage_0 = tabPage_2;
//		}

		// Token: 0x06004031 RID: 16433 RVA: 0x0015C4E8 File Offset: 0x0015A6E8
//		[CompilerGenerated]
//		internal  TabPage vmethod_4()
//		{
//			return this.tabPage_1;
//		}

		// Token: 0x06004032 RID: 16434 RVA: 0x00020DF6 File Offset: 0x0001EFF6
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_5(TabPage tabPage_2)
//		{
//			this.tabPage_1 = tabPage_2;
//		}

		// Token: 0x06004033 RID: 16435 RVA: 0x0015C500 File Offset: 0x0015A700
//		[CompilerGenerated]
//		internal  System.Windows.Forms.Timer vmethod_6()
//		{
//			return this.timer_0;
//		}

		// Token: 0x06004034 RID: 16436 RVA: 0x0015C518 File Offset: 0x0015A718
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_7(System.Windows.Forms.Timer timer_2)
//		{
//			EventHandler value = new EventHandler(this.method_9);
//			System.Windows.Forms.Timer timer = this.timer_0;
//			if (timer != null)
//			{
//				timer.Tick -= value;
//			}
//			this.timer_0 = timer_2;
//			timer = this.timer_0;
//			if (timer != null)
//			{
//				timer.Tick += value;
//			}
//		}

		// Token: 0x06004035 RID: 16437 RVA: 0x0015C564 File Offset: 0x0015A764
//		[CompilerGenerated]
//		internal  TreeGridViewTextBoxColumn GetFacilities()
//		{
//			return this.TGVTBC_Facilities;
//		}

		// Token: 0x06004036 RID: 16438 RVA: 0x00020DFF File Offset: 0x0001EFFF
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal  void SetFacilities(TreeGridViewTextBoxColumn value)
//		{
//			this.TGVTBC_Facilities = value;
//		}

		// Token: 0x06004037 RID: 16439 RVA: 0x0015C57C File Offset: 0x0015A77C
//		[CompilerGenerated]
//		internal  TreeGridViewTextBoxColumn GetStatus()
//		{
//			return this.TGVTBC_Status;
//		}

		// Token: 0x06004038 RID: 16440 RVA: 0x00020E08 File Offset: 0x0001F008
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal  void SetStatus(TreeGridViewTextBoxColumn value)
//		{
//			this.TGVTBC_Status = value;
//		}

		// Token: 0x06004039 RID: 16441 RVA: 0x0015C594 File Offset: 0x0015A794
//		[CompilerGenerated]
//		internal  ToolStrip vmethod_12()
//		{
//			return this.toolStrip_0;
//		}

		// Token: 0x0600403A RID: 16442 RVA: 0x00020E11 File Offset: 0x0001F011
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_13(ToolStrip toolStrip_1)
//		{
//			this.toolStrip_0 = toolStrip_1;
//		}

		// Token: 0x0600403B RID: 16443 RVA: 0x0015C5AC File Offset: 0x0015A7AC
//		[CompilerGenerated]
//		internal  ToolStripButton vmethod_14()
//		{
//			return this.toolStripButton_0;
//		}

		// Token: 0x0600403C RID: 16444 RVA: 0x0015C5C4 File Offset: 0x0015A7C4
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_15(ToolStripButton toolStripButton_9)
//		{
//			EventHandler value = new EventHandler(this.method_20);
//			ToolStripButton toolStripButton = this.toolStripButton_0;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click -= value;
//			}
//			this.toolStripButton_0 = toolStripButton_9;
//			toolStripButton = this.toolStripButton_0;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click += value;
//			}
//		}

		// Token: 0x0600403D RID: 16445 RVA: 0x0015C610 File Offset: 0x0015A810
//		[CompilerGenerated]
//		internal  ToolStripButton vmethod_16()
//		{
//			return this.toolStripButton_1;
//		}

		// Token: 0x0600403E RID: 16446 RVA: 0x0015C628 File Offset: 0x0015A828
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_17(ToolStripButton toolStripButton_9)
//		{
//			EventHandler value = new EventHandler(this.method_23);
//			ToolStripButton toolStripButton = this.toolStripButton_1;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click -= value;
//			}
//			this.toolStripButton_1 = toolStripButton_9;
//			toolStripButton = this.toolStripButton_1;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click += value;
//			}
//		}

		// Token: 0x0600403F RID: 16447 RVA: 0x0015C674 File Offset: 0x0015A874
//		[CompilerGenerated]
//		internal  ToolStripButton vmethod_18()
//		{
//			return this.toolStripButton_2;
//		}

		// Token: 0x06004040 RID: 16448 RVA: 0x0015C68C File Offset: 0x0015A88C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_19(ToolStripButton toolStripButton_9)
//		{
//			EventHandler value = new EventHandler(this.method_28);
//			ToolStripButton toolStripButton = this.toolStripButton_2;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click -= value;
//			}
//			this.toolStripButton_2 = toolStripButton_9;
//			toolStripButton = this.toolStripButton_2;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click += value;
//			}
//		}

		// Token: 0x06004041 RID: 16449 RVA: 0x0015C6D8 File Offset: 0x0015A8D8
//		[CompilerGenerated]
//		internal  TreeView GetTV_Facilities()
//		{
//			return this.treeView_0;
//		}

		// Token: 0x06004042 RID: 16450 RVA: 0x00020E1A File Offset: 0x0001F01A
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_21(TreeView treeView_1)
//		{
//			this.treeView_0 = treeView_1;
//		}

		// Token: 0x06004043 RID: 16451 RVA: 0x00020E23 File Offset: 0x0001F023
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_22(System.Windows.Forms.Timer timer_2)
//		{
//			this.timer_1 = timer_2;
//		}

		// Token: 0x06004044 RID: 16452 RVA: 0x0015C6F0 File Offset: 0x0015A8F0
//		[CompilerGenerated]
//		internal  TreeGridView GetTGV_Aircraft()
//		{
//			return this.treeGridView_0;
//		}

		// Token: 0x06004045 RID: 16453 RVA: 0x0015C708 File Offset: 0x0015A908
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_24(TreeGridView treeGridView_1)
//		{
//			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_25);
//			Delegate43 delegate43_ = new Delegate43(this.method_26);
//			Delegate41 delegate41_ = new Delegate41(this.method_27);
//			EventHandler value2 = new EventHandler(this.method_34);
//			TreeGridView treeGridView = this.treeGridView_0;
//			if (treeGridView != null)
//			{
//				treeGridView.CellContentClick -= value;
//				treeGridView.method_13(delegate43_);
//				treeGridView.method_11(delegate41_);
//				treeGridView.SelectionChanged -= value2;
//			}
//			this.treeGridView_0 = treeGridView_1;
//			treeGridView = this.treeGridView_0;
//			if (treeGridView != null)
//			{
//				treeGridView.CellContentClick += value;
//				treeGridView.method_12(delegate43_);
//				treeGridView.method_10(delegate41_);
//				treeGridView.SelectionChanged += value2;
//			}
//		}

		// Token: 0x06004046 RID: 16454 RVA: 0x0015C7B0 File Offset: 0x0015A9B0
//		[CompilerGenerated]
//		internal  ToolStripSeparator vmethod_25()
//		{
//			return this.toolStripSeparator_0;
//		}

		// Token: 0x06004047 RID: 16455 RVA: 0x00020E2C File Offset: 0x0001F02C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_26(ToolStripSeparator toolStripSeparator_4)
//		{
//			this.toolStripSeparator_0 = toolStripSeparator_4;
//		}

		// Token: 0x06004048 RID: 16456 RVA: 0x0015C7C8 File Offset: 0x0015A9C8
//		[CompilerGenerated]
//		internal  ToolStripButton vmethod_27()
//		{
//			return this.toolStripButton_3;
//		}

		// Token: 0x06004049 RID: 16457 RVA: 0x0015C7E0 File Offset: 0x0015A9E0
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_28(ToolStripButton toolStripButton_9)
//		{
//			EventHandler value = new EventHandler(this.method_32);
//			ToolStripButton toolStripButton = this.toolStripButton_3;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click -= value;
//			}
//			this.toolStripButton_3 = toolStripButton_9;
//			toolStripButton = this.toolStripButton_3;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click += value;
//			}
//		}

		// Token: 0x0600404A RID: 16458 RVA: 0x0015C82C File Offset: 0x0015AA2C
//		[CompilerGenerated]
//		internal  Label vmethod_29()
//		{
//			return this.label_0;
//		}

		// Token: 0x0600404B RID: 16459 RVA: 0x00020E35 File Offset: 0x0001F035
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_30(Label label_10)
//		{
//			this.label_0 = label_10;
//		}

		// Token: 0x0600404C RID: 16460 RVA: 0x0015C844 File Offset: 0x0015AA44
//		[CompilerGenerated]
//		internal  Label vmethod_31()
//		{
//			return this.label_1;
//		}

		// Token: 0x0600404D RID: 16461 RVA: 0x00020E3E File Offset: 0x0001F03E
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_32(Label label_10)
//		{
//			this.label_1 = label_10;
//		}

		// Token: 0x0600404E RID: 16462 RVA: 0x0015C85C File Offset: 0x0015AA5C
//		[CompilerGenerated]
//		internal  Label vmethod_33()
//		{
//			return this.label_2;
//		}

		// Token: 0x0600404F RID: 16463 RVA: 0x00020E47 File Offset: 0x0001F047
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_34(Label label_10)
//		{
//			this.label_2 = label_10;
//		}

		// Token: 0x06004050 RID: 16464 RVA: 0x0015C874 File Offset: 0x0015AA74
//		[CompilerGenerated]
//		internal  Label vmethod_35()
//		{
//			return this.label_3;
//		}

		// Token: 0x06004051 RID: 16465 RVA: 0x00020E50 File Offset: 0x0001F050
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_36(Label label_10)
//		{
//			this.label_3 = label_10;
//		}

		// Token: 0x06004052 RID: 16466 RVA: 0x0015C88C File Offset: 0x0015AA8C
//		[CompilerGenerated]
//		internal  DataGridView GetDGV_LoadoutItems()
//		{
//			return this.dataGridView_0;
//		}

		// Token: 0x06004053 RID: 16467 RVA: 0x0015C8A4 File Offset: 0x0015AAA4
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_38(DataGridView dataGridView_1)
//		{
//			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_4);
//			DataGridView dataGridView = this.dataGridView_0;
//			if (dataGridView != null)
//			{
//				dataGridView.CellContentClick -= value;
//			}
//			this.dataGridView_0 = dataGridView_1;
//			dataGridView = this.dataGridView_0;
//			if (dataGridView != null)
//			{
//				dataGridView.CellContentClick += value;
//			}
//		}

		// Token: 0x06004054 RID: 16468 RVA: 0x0015C8F0 File Offset: 0x0015AAF0
//		[CompilerGenerated]
//		internal  Label vmethod_39()
//		{
//			return this.label_4;
//		}

		// Token: 0x06004055 RID: 16469 RVA: 0x00020E59 File Offset: 0x0001F059
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_40(Label label_10)
//		{
//			this.label_4 = label_10;
//		}

		// Token: 0x06004056 RID: 16470 RVA: 0x0015C908 File Offset: 0x0015AB08
//		[CompilerGenerated]
//		internal  Label vmethod_41()
//		{
//			return this.label_5;
//		}

		// Token: 0x06004057 RID: 16471 RVA: 0x00020E62 File Offset: 0x0001F062
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_42(Label label_10)
//		{
//			this.label_5 = label_10;
//		}

		// Token: 0x06004058 RID: 16472 RVA: 0x0015C920 File Offset: 0x0015AB20
//		[CompilerGenerated]
//		internal  ToolStripButton GetTSB_SetReadyTime()
//		{
//			return this.toolStripButton_4;
//		}

		// Token: 0x06004059 RID: 16473 RVA: 0x0015C938 File Offset: 0x0015AB38
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_44(ToolStripButton toolStripButton_9)
//		{
//			EventHandler value = new EventHandler(this.method_39);
//			ToolStripButton toolStripButton = this.toolStripButton_4;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click -= value;
//			}
//			this.toolStripButton_4 = toolStripButton_9;
//			toolStripButton = this.toolStripButton_4;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click += value;
//			}
//		}

		// Token: 0x0600405A RID: 16474 RVA: 0x0015C984 File Offset: 0x0015AB84
//		[CompilerGenerated]
//		internal  ToolStripButton GetTSB_Rename()
//		{
//			return this.toolStripButton_5;
//		}

		// Token: 0x0600405B RID: 16475 RVA: 0x0015C99C File Offset: 0x0015AB9C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_46(ToolStripButton toolStripButton_9)
//		{
//			EventHandler value = new EventHandler(this.method_37);
//			ToolStripButton toolStripButton = this.toolStripButton_5;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click -= value;
//			}
//			this.toolStripButton_5 = toolStripButton_9;
//			toolStripButton = this.toolStripButton_5;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click += value;
//			}
//		}

		// Token: 0x0600405C RID: 16476 RVA: 0x0015C9E8 File Offset: 0x0015ABE8
//		[CompilerGenerated]
//		internal  ToolStripButton GetTSB_Delete()
//		{
//			return this.toolStripButton_6;
//		}

		// Token: 0x0600405D RID: 16477 RVA: 0x0015CA00 File Offset: 0x0015AC00
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_48(ToolStripButton toolStripButton_9)
//		{
//			EventHandler value = new EventHandler(this.method_41);
//			ToolStripButton toolStripButton = this.toolStripButton_6;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click -= value;
//			}
//			this.toolStripButton_6 = toolStripButton_9;
//			toolStripButton = this.toolStripButton_6;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click += value;
//			}
//		}

		// Token: 0x0600405E RID: 16478 RVA: 0x0015CA4C File Offset: 0x0015AC4C
//		[CompilerGenerated]
//		internal  Label vmethod_49()
//		{
//			return this.label_6;
//		}

		// Token: 0x0600405F RID: 16479 RVA: 0x00020E6B File Offset: 0x0001F06B
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_50(Label label_10)
//		{
//			this.label_6 = label_10;
//		}

		// Token: 0x06004060 RID: 16480 RVA: 0x0015CA64 File Offset: 0x0015AC64
//		[CompilerGenerated]
//		internal  Label vmethod_51()
//		{
//			return this.label_7;
//		}

		// Token: 0x06004061 RID: 16481 RVA: 0x00020E74 File Offset: 0x0001F074
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_52(Label label_10)
//		{
//			this.label_7 = label_10;
//		}

		// Token: 0x06004062 RID: 16482 RVA: 0x0015CA7C File Offset: 0x0015AC7C
//		[CompilerGenerated]
//		internal  Label vmethod_53()
//		{
//			return this.label_8;
//		}

		// Token: 0x06004063 RID: 16483 RVA: 0x00020E7D File Offset: 0x0001F07D
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_54(Label label_10)
//		{
//			this.label_8 = label_10;
//		}

		// Token: 0x06004064 RID: 16484 RVA: 0x0015CA94 File Offset: 0x0015AC94
//		[CompilerGenerated]
//		internal  ComboBox GetCombo_NumberOfSorties()
//		{
//			return this.comboBox_0;
//		}

		// Token: 0x06004065 RID: 16485 RVA: 0x0015CAAC File Offset: 0x0015ACAC
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_56(ComboBox comboBox_1)
//		{
//			EventHandler value = new EventHandler(this.method_43);
//			ComboBox comboBox = this.comboBox_0;
//			if (comboBox != null)
//			{
//				comboBox.SelectedIndexChanged -= value;
//			}
//			this.comboBox_0 = comboBox_1;
//			comboBox = this.comboBox_0;
//			if (comboBox != null)
//			{
//				comboBox.SelectedIndexChanged += value;
//			}
//		}

		// Token: 0x06004066 RID: 16486 RVA: 0x0015CAF8 File Offset: 0x0015ACF8
//		[CompilerGenerated]
//		internal  CheckBox GetCB_QuickTurnaround()
//		{
//			return this.checkBox_0;
//		}

		// Token: 0x06004067 RID: 16487 RVA: 0x0015CB10 File Offset: 0x0015AD10
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_58(CheckBox checkBox_1)
//		{
//			EventHandler value = new EventHandler(this.method_46);
//			CheckBox checkBox = this.checkBox_0;
//			if (checkBox != null)
//			{
//				checkBox.CheckedChanged -= value;
//			}
//			this.checkBox_0 = checkBox_1;
//			checkBox = this.checkBox_0;
//			if (checkBox != null)
//			{
//				checkBox.CheckedChanged += value;
//			}
//		}

		// Token: 0x06004068 RID: 16488 RVA: 0x0015CB5C File Offset: 0x0015AD5C
//		[CompilerGenerated]
//		internal  ToolStripSeparator vmethod_59()
//		{
//			return this.toolStripSeparator_1;
//		}

		// Token: 0x06004069 RID: 16489 RVA: 0x00020E86 File Offset: 0x0001F086
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_60(ToolStripSeparator toolStripSeparator_4)
//		{
//			this.toolStripSeparator_1 = toolStripSeparator_4;
//		}

		// Token: 0x0600406A RID: 16490 RVA: 0x0015CB74 File Offset: 0x0015AD74
//		[CompilerGenerated]
//		internal  ContextMenuStrip GetCMenu_Unit()
//		{
//			return this.CMenu_Unit;
//		}

		// Token: 0x0600406B RID: 16491 RVA: 0x0015CB8C File Offset: 0x0015AD8C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal  void SetCMenu_Unit(ContextMenuStrip contextMenuStrip_1)
//		{
//			CancelEventHandler value = new CancelEventHandler(this.CMenu_Unit_Opening);
//			ContextMenuStrip cMenu_Unit = this.CMenu_Unit;
//			if (cMenu_Unit != null)
//			{
//				cMenu_Unit.Opening -= value;
//			}
//			this.CMenu_Unit = contextMenuStrip_1;
//			cMenu_Unit = this.CMenu_Unit;
//			if (cMenu_Unit != null)
//			{
//				cMenu_Unit.Opening += value;
//			}
//		}

		// Token: 0x0600406C RID: 16492 RVA: 0x0015CBD8 File Offset: 0x0015ADD8
//		[CompilerGenerated]
//		internal  ToolStripMenuItem GetTSMI_Doctrine()
//		{
//			return this.toolStripMenuItem_0;
//		}

		// Token: 0x0600406D RID: 16493 RVA: 0x0015CBF0 File Offset: 0x0015ADF0
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_64(ToolStripMenuItem toolStripMenuItem_9)
//		{
//			EventHandler value = new EventHandler(this.method_57);
//			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_0;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click -= value;
//			}
//			this.toolStripMenuItem_0 = toolStripMenuItem_9;
//			toolStripMenuItem = this.toolStripMenuItem_0;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click += value;
//			}
//		}

		// Token: 0x0600406E RID: 16494 RVA: 0x0015CC3C File Offset: 0x0015AE3C
//		[CompilerGenerated]
//		internal  ToolStripMenuItem GetTSMI_AssignToMission()
//		{
//			return this.TSMI_AssignToMission;
//		}

		// Token: 0x0600406F RID: 16495 RVA: 0x0015CC54 File Offset: 0x0015AE54
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal  void SetTSMI_AssignToMission(ToolStripMenuItem toolStripMenuItem_9)
//		{
//			EventHandler value = new EventHandler(this.TSMI_AssignToMission_Click);
//			ToolStripItemClickedEventHandler value2 = new ToolStripItemClickedEventHandler(this.TSMI_AssignToMission_DropDownItemClicked);
//			ToolStripMenuItem tSMI_AssignToMission = this.TSMI_AssignToMission;
//			if (tSMI_AssignToMission != null)
//			{
//				tSMI_AssignToMission.Click -= value;
//				tSMI_AssignToMission.DropDownItemClicked -= value2;
//			}
//			this.TSMI_AssignToMission = toolStripMenuItem_9;
//			tSMI_AssignToMission = this.TSMI_AssignToMission;
//			if (tSMI_AssignToMission != null)
//			{
//				tSMI_AssignToMission.Click += value;
//				tSMI_AssignToMission.DropDownItemClicked += value2;
//			}
//		}

		// Token: 0x06004070 RID: 16496 RVA: 0x0015CCB8 File Offset: 0x0015AEB8
//		[CompilerGenerated]
//		internal  ToolStripDropDownButton GetTSB_AssignToMission()
//		{
//			return this.TSB_AssignToMission;
//		}

		// Token: 0x06004071 RID: 16497 RVA: 0x0015CCD0 File Offset: 0x0015AED0
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal  void SetTSB_AssignToMission(ToolStripDropDownButton toolStripDropDownButton_1)
//		{
//			EventHandler value = new EventHandler(this.TSB_AssignToMission_Click);
//			EventHandler value2 = new EventHandler(this.TSB_AssignToMission_DropDownOpening);
//			ToolStripItemClickedEventHandler value3 = new ToolStripItemClickedEventHandler(this.TSB_AssignToMission_DropDownItemClicked);
//			ToolStripDropDownButton tSB_AssignToMission = this.TSB_AssignToMission;
//			if (tSB_AssignToMission != null)
//			{
//				tSB_AssignToMission.Click -= value;
//				tSB_AssignToMission.DropDownOpening -= value2;
//				tSB_AssignToMission.DropDownItemClicked -= value3;
//			}
//			this.TSB_AssignToMission = toolStripDropDownButton_1;
//			tSB_AssignToMission = this.TSB_AssignToMission;
//			if (tSB_AssignToMission != null)
//			{
//				tSB_AssignToMission.Click += value;
//				tSB_AssignToMission.DropDownOpening += value2;
//				tSB_AssignToMission.DropDownItemClicked += value3;
//			}
//		}

		// Token: 0x06004072 RID: 16498 RVA: 0x0015CD50 File Offset: 0x0015AF50
//		[CompilerGenerated]
//		internal  ToolStripButton GetTSB_Doctrine()
//		{
//			return this.toolStripButton_7;
//		}

		// Token: 0x06004073 RID: 16499 RVA: 0x0015CD68 File Offset: 0x0015AF68
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_70(ToolStripButton toolStripButton_9)
//		{
//			EventHandler value = new EventHandler(this.method_52);
//			ToolStripButton toolStripButton = this.toolStripButton_7;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click -= value;
//			}
//			this.toolStripButton_7 = toolStripButton_9;
//			toolStripButton = this.toolStripButton_7;
//			if (toolStripButton != null)
//			{
//				toolStripButton.Click += value;
//			}
//		}

		// Token: 0x06004074 RID: 16500 RVA: 0x0015CDB4 File Offset: 0x0015AFB4
//		[CompilerGenerated]
//		internal  ToolStripMenuItem GetLaunchIndividuallyToolStripMenuItem()
//		{
//			return this.toolStripMenuItem_2;
//		}

		// Token: 0x06004075 RID: 16501 RVA: 0x0015CDCC File Offset: 0x0015AFCC
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_72(ToolStripMenuItem toolStripMenuItem_9)
//		{
//			EventHandler value = new EventHandler(this.method_53);
//			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_2;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click -= value;
//			}
//			this.toolStripMenuItem_2 = toolStripMenuItem_9;
//			toolStripMenuItem = this.toolStripMenuItem_2;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click += value;
//			}
//		}

		// Token: 0x06004076 RID: 16502 RVA: 0x0015CE18 File Offset: 0x0015B018
//		[CompilerGenerated]
//		internal  ToolStripMenuItem GetLaunchAsGroupsToolStripMenuItem()
//		{
//			return this.toolStripMenuItem_3;
//		}

		// Token: 0x06004077 RID: 16503 RVA: 0x0015CE30 File Offset: 0x0015B030
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_74(ToolStripMenuItem toolStripMenuItem_9)
//		{
//			EventHandler value = new EventHandler(this.method_54);
//			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_3;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click -= value;
//			}
//			this.toolStripMenuItem_3 = toolStripMenuItem_9;
//			toolStripMenuItem = this.toolStripMenuItem_3;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click += value;
//			}
//		}

		// Token: 0x06004078 RID: 16504 RVA: 0x0015CE7C File Offset: 0x0015B07C
//		[CompilerGenerated]
//		internal  ToolStripMenuItem GetReadyArmToolStripMenuItem()
//		{
//			return this.toolStripMenuItem_4;
//		}

		// Token: 0x06004079 RID: 16505 RVA: 0x0015CE94 File Offset: 0x0015B094
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_76(ToolStripMenuItem toolStripMenuItem_9)
//		{
//			EventHandler value = new EventHandler(this.method_55);
//			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_4;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click -= value;
//			}
//			this.toolStripMenuItem_4 = toolStripMenuItem_9;
//			toolStripMenuItem = this.toolStripMenuItem_4;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click += value;
//			}
//		}

		// Token: 0x0600407A RID: 16506 RVA: 0x0015CEE0 File Offset: 0x0015B0E0
//		[CompilerGenerated]
//		internal  ToolStripMenuItem GetAbortLaunchToolStripMenuItem()
//		{
//			return this.toolStripMenuItem_5;
//		}

		// Token: 0x0600407B RID: 16507 RVA: 0x0015CEF8 File Offset: 0x0015B0F8
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_78(ToolStripMenuItem toolStripMenuItem_9)
//		{
//			EventHandler value = new EventHandler(this.method_56);
//			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_5;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click -= value;
//			}
//			this.toolStripMenuItem_5 = toolStripMenuItem_9;
//			toolStripMenuItem = this.toolStripMenuItem_5;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click += value;
//			}
//		}

		// Token: 0x0600407C RID: 16508 RVA: 0x0015CF44 File Offset: 0x0015B144
//		[CompilerGenerated]
//		internal  ToolStripSeparator vmethod_79()
//		{
//			return this.toolStripSeparator_2;
//		}

		// Token: 0x0600407D RID: 16509 RVA: 0x00020E8F File Offset: 0x0001F08F
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_80(ToolStripSeparator toolStripSeparator_4)
//		{
//			this.toolStripSeparator_2 = toolStripSeparator_4;
//		}

		// Token: 0x0600407E RID: 16510 RVA: 0x0015CF5C File Offset: 0x0015B15C
//		[CompilerGenerated]
//		internal  ToolStripSeparator vmethod_81()
//		{
//			return this.toolStripSeparator_3;
//		}

		// Token: 0x0600407F RID: 16511 RVA: 0x00020E98 File Offset: 0x0001F098
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_82(ToolStripSeparator toolStripSeparator_4)
//		{
//			this.toolStripSeparator_3 = toolStripSeparator_4;
//		}

		// Token: 0x06004080 RID: 16512 RVA: 0x0015CF74 File Offset: 0x0015B174
//		[CompilerGenerated]
//		internal  ToolStripMenuItem GetSetTimeToReadyToolStripMenuItem()
//		{
//			return this.toolStripMenuItem_6;
//		}

		// Token: 0x06004081 RID: 16513 RVA: 0x0015CF8C File Offset: 0x0015B18C
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_84(ToolStripMenuItem toolStripMenuItem_9)
//		{
//			EventHandler value = new EventHandler(this.method_59);
//			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_6;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click -= value;
//			}
//			this.toolStripMenuItem_6 = toolStripMenuItem_9;
//			toolStripMenuItem = this.toolStripMenuItem_6;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click += value;
//			}
//		}

		// Token: 0x06004082 RID: 16514 RVA: 0x0015CFD8 File Offset: 0x0015B1D8
//		[CompilerGenerated]
//		internal  ToolStripMenuItem GetRenameToolStripMenuItem()
//		{
//			return this.toolStripMenuItem_7;
//		}

		// Token: 0x06004083 RID: 16515 RVA: 0x0015CFF0 File Offset: 0x0015B1F0
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_86(ToolStripMenuItem toolStripMenuItem_9)
//		{
//			EventHandler value = new EventHandler(this.method_60);
//			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_7;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click -= value;
//			}
//			this.toolStripMenuItem_7 = toolStripMenuItem_9;
//			toolStripMenuItem = this.toolStripMenuItem_7;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click += value;
//			}
//		}

		// Token: 0x06004084 RID: 16516 RVA: 0x0015D03C File Offset: 0x0015B23C
//		[CompilerGenerated]
//		internal  ToolStripMenuItem GetRemoveToolStripMenuItem()
//		{
//			return this.toolStripMenuItem_8;
//		}

		// Token: 0x06004085 RID: 16517 RVA: 0x0015D054 File Offset: 0x0015B254
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_88(ToolStripMenuItem toolStripMenuItem_9)
//		{
//			EventHandler value = new EventHandler(this.method_61);
//			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_8;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click -= value;
//			}
//			this.toolStripMenuItem_8 = toolStripMenuItem_9;
//			toolStripMenuItem = this.toolStripMenuItem_8;
//			if (toolStripMenuItem != null)
//			{
//				toolStripMenuItem.Click += value;
//			}
//		}

		// Token: 0x06004086 RID: 16518 RVA: 0x0015D0A0 File Offset: 0x0015B2A0
//		[CompilerGenerated]
//		internal  Label vmethod_89()
//		{
//			return this.label_9;
//		}

		// Token: 0x06004087 RID: 16519 RVA: 0x00020EA1 File Offset: 0x0001F0A1
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_90(Label label_10)
//		{
//			this.label_9 = label_10;
//		}

		// Token: 0x06004088 RID: 16520 RVA: 0x0015D0B8 File Offset: 0x0015B2B8
//		[CompilerGenerated]
//		internal  TreeGridViewTextBoxColumn GetAircraft_TreeGridViewTextBoxColumn()
//		{
//			return this.Aircraft_TreeGridViewTextBoxColumn;
//		}

		// Token: 0x06004089 RID: 16521 RVA: 0x00020EAA File Offset: 0x0001F0AA
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal  void SetAircraft_TreeGridViewTextBoxColumn(TreeGridViewTextBoxColumn class2383_3)
//		{
//			this.Aircraft_TreeGridViewTextBoxColumn = class2383_3;
//		}

		// Token: 0x0600408A RID: 16522 RVA: 0x0015D0D0 File Offset: 0x0015B2D0
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_93()
//		{
//			return this.dataGridViewTextBoxColumn_0;
//		}

		// Token: 0x0600408B RID: 16523 RVA: 0x00020EB3 File Offset: 0x0001F0B3
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_94(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
//		{
//			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_8;
//		}

		// Token: 0x0600408C RID: 16524 RVA: 0x0015D0E8 File Offset: 0x0015B2E8
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_95()
//		{
//			return this.dataGridViewTextBoxColumn_1;
//		}

		// Token: 0x0600408D RID: 16525 RVA: 0x00020EBC File Offset: 0x0001F0BC
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_96(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
//		{
//			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_8;
//		}

		// Token: 0x0600408E RID: 16526 RVA: 0x0015D100 File Offset: 0x0015B300
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_97()
//		{
//			return this.dataGridViewTextBoxColumn_2;
//		}

		// Token: 0x0600408F RID: 16527 RVA: 0x00020EC5 File Offset: 0x0001F0C5
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_98(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
//		{
//			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_8;
//		}

		// Token: 0x06004090 RID: 16528 RVA: 0x0015D118 File Offset: 0x0015B318
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_99()
//		{
//			return this.dataGridViewTextBoxColumn_3;
//		}

		// Token: 0x06004091 RID: 16529 RVA: 0x00020ECE File Offset: 0x0001F0CE
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_100(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
//		{
//			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_8;
//		}

		// Token: 0x06004092 RID: 16530 RVA: 0x0015D130 File Offset: 0x0015B330
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_101()
//		{
//			return this.dataGridViewTextBoxColumn_4;
//		}

		// Token: 0x06004093 RID: 16531 RVA: 0x00020ED7 File Offset: 0x0001F0D7
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_102(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
//		{
//			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_8;
//		}

		// Token: 0x06004094 RID: 16532 RVA: 0x0015D148 File Offset: 0x0015B348
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_103()
//		{
//			return this.dataGridViewTextBoxColumn_5;
//		}

		// Token: 0x06004095 RID: 16533 RVA: 0x00020EE0 File Offset: 0x0001F0E0
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_104(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
//		{
//			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_8;
//		}

		// Token: 0x06004096 RID: 16534 RVA: 0x0015D160 File Offset: 0x0015B360
//		[CompilerGenerated]
//		internal  DataGridViewLinkColumn vmethod_105()
//		{
//			return this.dataGridViewLinkColumn_0;
//		}

		// Token: 0x06004097 RID: 16535 RVA: 0x00020EE9 File Offset: 0x0001F0E9
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_106(DataGridViewLinkColumn dataGridViewLinkColumn_1)
//		{
//			this.dataGridViewLinkColumn_0 = dataGridViewLinkColumn_1;
//		}

		// Token: 0x06004098 RID: 16536 RVA: 0x0015D178 File Offset: 0x0015B378
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_107()
//		{
//			return this.dataGridViewTextBoxColumn_6;
//		}

		// Token: 0x06004099 RID: 16537 RVA: 0x00020EF2 File Offset: 0x0001F0F2
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_108(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
//		{
//			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_8;
//		}

		// Token: 0x0600409A RID: 16538 RVA: 0x0015D190 File Offset: 0x0015B390
//		[CompilerGenerated]
//		internal  DataGridViewTextBoxColumn vmethod_109()
//		{
//			return this.dataGridViewTextBoxColumn_7;
//		}

		// Token: 0x0600409B RID: 16539 RVA: 0x00020EFB File Offset: 0x0001F0FB
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_110(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8)
//		{
//			this.dataGridViewTextBoxColumn_7 = dataGridViewTextBoxColumn_8;
//		}

		// Token: 0x0600409C RID: 16540 RVA: 0x0015D1A8 File Offset: 0x0015B3A8
//		[CompilerGenerated]
//		internal  ToolStripButton GetTSB_Cargo()
//		{
//			return this.TSB_Cargo;
//		}

		// Token: 0x0600409D RID: 16541 RVA: 0x0015D1C0 File Offset: 0x0015B3C0
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal  void SetTSB_Cargo(ToolStripButton toolStripButton_9)
//		{
//			EventHandler value = new EventHandler(this.TSB_Cargo_Click);
//			ToolStripButton tSB_Cargo = this.TSB_Cargo;
//			if (tSB_Cargo != null)
//			{
//				tSB_Cargo.Click -= value;
//			}
//			this.TSB_Cargo = toolStripButton_9;
//			tSB_Cargo = this.TSB_Cargo;
//			if (tSB_Cargo != null)
//			{
//				tSB_Cargo.Click += value;
//			}
//		}

		// Token: 0x0600409E RID: 16542 RVA: 0x0015D20C File Offset: 0x0015B40C
//		[CompilerGenerated]
//		internal  BackgroundWorker vmethod_113()
//		{
//			return this.backgroundWorker_0;
//		}

		// Token: 0x0600409F RID: 16543 RVA: 0x0015D224 File Offset: 0x0015B424
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_114(BackgroundWorker backgroundWorker_1)
//		{
//			DoWorkEventHandler value = new DoWorkEventHandler(this.method_30);
//			RunWorkerCompletedEventHandler value2 = new RunWorkerCompletedEventHandler(this.method_31);
//			BackgroundWorker backgroundWorker = this.backgroundWorker_0;
//			if (backgroundWorker != null)
//			{
//				backgroundWorker.DoWork -= value;
//				backgroundWorker.RunWorkerCompleted -= value2;
//			}
//			this.backgroundWorker_0 = backgroundWorker_1;
//			backgroundWorker = this.backgroundWorker_0;
//			if (backgroundWorker != null)
//			{
//				backgroundWorker.DoWork += value;
//				backgroundWorker.RunWorkerCompleted += value2;
//			}
//		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x00020F04 File Offset: 0x0001F104
		private void AirOps_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.bool_0)
			{
				Client.GetConfiguration().SetSimRunMode();
			}
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
			this.timer_0.Stop();
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x0015D288 File Offset: 0x0015B488
		private void method_1(Group group_0, ActiveUnit activeUnit_1)
		{
			HashSet<ActiveUnit>.Enumerator enumerator = this.HostUnitSet.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == group_0)
					{
						Class739.smethod_5(this.treeView_0).Nodes.method_0(activeUnit_1.Name).Tag = activeUnit_1;
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

		// Token: 0x060040A2 RID: 16546 RVA: 0x0015D304 File Offset: 0x0015B504
		private void method_2(Group group_0, ActiveUnit activeUnit_1)
		{
			HashSet<ActiveUnit>.Enumerator enumerator = this.HostUnitSet.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == group_0)
					{
						Class682 @class = Class739.smethod_5(this.treeView_0);
						foreach (ThreadSafeTreeNode current in @class.Nodes)
						{
							if (current.Tag == activeUnit_1)
							{
								@class.Nodes.Remove(current);
								break;
							}
						}
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

		// Token: 0x060040A3 RID: 16547 RVA: 0x0015D3C4 File Offset: 0x0015B5C4
		private Dictionary<int, int> method_3(ref ActiveUnit activeUnit_1)
		{
			List<Aircraft> list = new List<Aircraft>();
			Dictionary<int, int> result;
			if (Information.IsNothing(activeUnit_1))
			{
				result = null;
			}
			else
			{
				List<Aircraft>.Enumerator enumerator = activeUnit_1.GetAirOps().GetHostedAircrafts().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Aircraft current = enumerator.Current;
						list.Add(current);
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
				if (list.Count == 0)
				{
					result = null;
				}
				else
				{
					List<Aircraft> selectedAircraft = list;
					SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
					bool flag = Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags);
					result = DBFunctions.smethod_40(selectedAircraft, ref sQLiteConnection, ref flag);
				}
			}
			return result;
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x0015D484 File Offset: 0x0015B684
		private void method_4(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && this.dataGridView_0.Columns[e.ColumnIndex].CellType == typeof(DataGridViewLinkCell))
			{
				int dBID = Conversions.ToInteger(this.dataGridView_0.Rows[e.RowIndex].Cells["ComponentID"].Value);
				Client.ShowDBInfo("武器", dBID);
			}
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x0015D508 File Offset: 0x0015B708
		private void method_5(Aircraft aircraft_0)
		{
			using (HashSet<ActiveUnit>.Enumerator enumerator = this.HostUnitSet.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetAirOps().GetHostedAircrafts().Contains(aircraft_0))
					{
						this.collection_1.Add(aircraft_0);
					}
				}
			}
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x00020F35 File Offset: 0x0001F135
		public void method_6()
		{
			this.method_11();
			this.method_16();
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x00020F43 File Offset: 0x0001F143
		private void method_7()
		{
			this.backgroundWorker_0.RunWorkerAsync();
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x00020F50 File Offset: 0x0001F150
		private void method_8(Aircraft aircraft_0)
		{
			this.collection_2.Add(aircraft_0);
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x00020F5E File Offset: 0x0001F15E
		private void method_9(object sender, EventArgs e)
		{
			if (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Run)
			{
				this.method_10();
			}
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x00020F78 File Offset: 0x0001F178
		public void method_10()
		{
			this.method_11();
			this.method_16();
			this.collection_1.Clear();
			this.collection_2.Clear();
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x0015D574 File Offset: 0x0015B774
		private void method_11()
		{
			try
			{
				foreach (TreeGridViewRow current in this.method_12())
				{
					if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(current.Tag)) && current.Tag.GetType() == typeof(Aircraft))
					{
						Aircraft aircraft = (Aircraft)current.Tag;
						string string_;
						if (Information.IsNothing(aircraft.GetLoadout()))
						{
							string_ = "无";
						}
						else
						{
							string_ = aircraft.GetLoadout().Name;
						}
						string text;
						if (Information.IsNothing(aircraft.GetAssignedMission(false)))
						{
							if (!Information.IsNothing(aircraft.GetAssignedTaskPool()))
							{
								text = aircraft.GetAssignedTaskPool().Name + " (任务（Task）池)";
							}
							else
							{
								text = "-";
							}
						}
						else
						{
							string text2 = "";
							if (aircraft.GetAircraftAI().IsEscort)
							{
								text2 = ", 护航";
							}
							text = string.Concat(new string[]
							{
								aircraft.GetAssignedMission(false).Name,
								" (",
								aircraft.GetAssignedMission(false).GetTypeString(Client.GetClientScenario()),
								text2,
								")"
							});
						}
						Aircraft_AirOps aircraftAirOps = aircraft.GetAircraftAirOps();
						DataGridViewRow dataGridViewRow = current;
						object[] array = new object[6];
						array[0] = aircraft.Name;
						array[1] = aircraftAirOps.GetAirOpsConditionString();
						array[2] = text;
						array[3] = Misc.smethod_11(string_);
						long seconds = (long)Math.Round((double)aircraftAirOps.GetConditionTimer());
						Aircraft aircraft2 = aircraft;
						string text3 = null;
						array[4] = Misc.GetTimeString(seconds, aircraft2.GetMaintenanceLevel(ref text3), false, false);
						array[5] = aircraft.GetQuickTurnAroundInfo();
						dataGridViewRow.SetValues(array);
						if (aircraftAirOps.GetConditionTimer() == 0f)
						{
							Aircraft aircraft3 = aircraft;
							text3 = null;
							if (aircraft3.GetMaintenanceLevel(ref text3) == Aircraft_AirOps._Maintenance.const_0)
							{
								current.DefaultCellStyle.ForeColor = Color.DarkGreen;
								continue;
							}
						}
						Aircraft aircraft4 = aircraft;
						text3 = null;
						if (aircraft4.GetMaintenanceLevel(ref text3) == Aircraft_AirOps._Maintenance.const_0)
						{
							current.DefaultCellStyle.ForeColor = Color.Black;
						}
						else
						{
							current.DefaultCellStyle.ForeColor = Color.Red;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200279", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				base.Close();
				ProjectData.ClearProjectError();
				return;
			}
			try
			{
				foreach (Aircraft current2 in this.collection_2)
				{
					AirOps.Class2508 @class = new AirOps.Class2508(null);
					@class.aircraft_0 = current2;
					IEnumerable<TreeGridViewRow> source = this.method_12().Where(new Func<TreeGridViewRow, bool>(@class.method_0));
					if (source.Count<TreeGridViewRow>() > 0)
					{
						source.ElementAtOrDefault(0).method_7().Nodes.Remove(source.ElementAtOrDefault(0));
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 200111", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			try
			{
				foreach (Aircraft current3 in this.collection_1)
				{
					bool flag = false;
					foreach (TreeGridViewRow current4 in this.treeGridView_0.Nodes)
					{
						if (Operators.CompareString(current4.Tag.ToString(), current3.DBID.ToString(), false) == 0)
						{
							string string_2;
							if (Information.IsNothing(current3.GetLoadout()))
							{
								string_2 = "无";
							}
							else
							{
								string_2 = current3.GetLoadout().Name;
							}
							string text4;
							if (Information.IsNothing(current3.GetAssignedMission(false)))
							{
								if (!Information.IsNothing(current3.GetAssignedTaskPool()))
								{
									text4 = current3.GetAssignedTaskPool().Name + " (任务（Task）池)";
								}
								else
								{
									text4 = "-";
								}
							}
							else
							{
								string text5 = "";
								if (current3.GetAircraftAI().IsEscort)
								{
									text5 = ", 护航";
								}
								text4 = string.Concat(new string[]
								{
									current3.GetAssignedMission(false).Name,
									" (",
									current3.GetAssignedMission(false).GetTypeString(Client.GetClientScenario()),
									text5,
									")"
								});
							}
							Aircraft_AirOps aircraftAirOps = current3.GetAircraftAirOps();
							TreeGridViewRowNodes nodes = current4.Nodes;
							object[] array2 = new object[6];
							array2[0] = current3.Name;
							array2[1] = aircraftAirOps.GetAirOpsConditionString();
							array2[2] = text4;
							array2[3] = Misc.smethod_11(string_2);
							long seconds2 = (long)Math.Round((double)aircraftAirOps.GetConditionTimer());
							Aircraft aircraft5 = current3;
							string text3 = null;
							array2[4] = Misc.GetTimeString(seconds2, aircraft5.GetMaintenanceLevel(ref text3), false, false);
							array2[5] = current3.GetQuickTurnAroundInfo();
							nodes.method_1(array2).Tag = current3;
							if (aircraftAirOps.GetConditionTimer() != 0f)
							{
								goto IL_555;
							}
							Aircraft aircraft6 = current3;
							text3 = null;
							if (aircraft6.GetMaintenanceLevel(ref text3) != Aircraft_AirOps._Maintenance.const_0)
							{
								goto IL_555;
							}
							current4.DefaultCellStyle.ForeColor = Color.DarkGreen;
							IL_5A4:
							flag = true;
							continue;
							IL_555:
							Aircraft aircraft7 = current3;
							text3 = null;
							if (aircraft7.GetMaintenanceLevel(ref text3) == Aircraft_AirOps._Maintenance.const_0)
							{
								current4.DefaultCellStyle.ForeColor = Color.Black;
								goto IL_5A4;
							}
							current4.DefaultCellStyle.ForeColor = Color.Red;
							goto IL_5A4;
						}
					}
					if (!flag)
					{
						string string_3;
						if (Information.IsNothing(current3.GetLoadout()))
						{
							string_3 = "无";
						}
						else
						{
							string_3 = current3.GetLoadout().Name;
						}
						string text6;
						if (Information.IsNothing(current3.GetAssignedMission(false)))
						{
							if (!Information.IsNothing(current3.GetAssignedTaskPool()))
							{
								text6 = current3.GetAssignedTaskPool().Name + " (任务（Task）池)";
							}
							else
							{
								text6 = "-";
							}
						}
						else
						{
							string text7 = "";
							if (current3.GetAircraftAI().IsEscort)
							{
								text7 = ", 护航";
							}
							text6 = string.Concat(new string[]
							{
								current3.GetAssignedMission(false).Name,
								" (",
								current3.GetAssignedMission(false).GetTypeString(Client.GetClientScenario()),
								text7,
								")"
							});
						}
						TreeGridViewRow treeGridViewRow = this.treeGridView_0.Nodes.method_0("1x " + Misc.smethod_11(current3.UnitClass));
						treeGridViewRow.Tag = current3.DBID;
						Aircraft_AirOps aircraftAirOps = current3.GetAircraftAirOps();
						TreeGridViewRowNodes nodes2 = treeGridViewRow.Nodes;
						object[] array3 = new object[6];
						array3[0] = current3.Name;
						array3[1] = aircraftAirOps.GetAirOpsConditionString();
						array3[2] = text6;
						array3[3] = Misc.smethod_11(string_3);
						long seconds3 = (long)Math.Round((double)aircraftAirOps.GetConditionTimer());
						Aircraft aircraft8 = current3;
						string text3 = null;
						array3[4] = Misc.GetTimeString(seconds3, aircraft8.GetMaintenanceLevel(ref text3), false, false);
						array3[5] = current3.GetQuickTurnAroundInfo();
						TreeGridViewRow treeGridViewRow2 = nodes2.method_1(array3);
						treeGridViewRow2.Tag = current3;
						if (aircraftAirOps.GetConditionTimer() == 0f)
						{
							Aircraft aircraft9 = current3;
							text3 = null;
							if (aircraft9.GetMaintenanceLevel(ref text3) == Aircraft_AirOps._Maintenance.const_0)
							{
								treeGridViewRow2.DefaultCellStyle.ForeColor = Color.DarkGreen;
								continue;
							}
						}
						Aircraft aircraft10 = current3;
						text3 = null;
						if (aircraft10.GetMaintenanceLevel(ref text3) == Aircraft_AirOps._Maintenance.const_0)
						{
							treeGridViewRow2.DefaultCellStyle.ForeColor = Color.Black;
						}
						else
						{
							treeGridViewRow2.DefaultCellStyle.ForeColor = Color.Red;
						}
					}
				}
				if (this.bool_2)
				{
					this.method_35();
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 200112", "");
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x0015DE8C File Offset: 0x0015C08C
		private ReadOnlyCollection<TreeGridViewRow> method_12()
		{
			ReadOnlyCollection<TreeGridViewRow> result;
			try
			{
				List<TreeGridViewRow> list = new List<TreeGridViewRow>();
				foreach (TreeGridViewRow current in this.treeGridView_0.Nodes)
				{
					if (!list.Contains(current))
					{
						list.Add(current);
					}
					this.method_13(current, list);
				}
				result = list.AsReadOnly();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101133", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<TreeGridViewRow>().AsReadOnly();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x0015DF60 File Offset: 0x0015C160
		private void method_13(TreeGridViewRow class2384_0, List<TreeGridViewRow> list_0)
		{
			foreach (TreeGridViewRow current in class2384_0.Nodes)
			{
				if (!list_0.Contains(current))
				{
					list_0.Add(current);
				}
				this.method_13(current, list_0);
			}
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x0015DFC4 File Offset: 0x0015C1C4
		private void method_14()
		{
			try
			{
				this.treeGridView_0.Nodes.Clear();
				foreach (ActiveUnit current in this.HostUnitSet)
				{
					IEnumerable<int> enumerable = current.GetAirOps().GetHostedAircrafts().Select(AirOps.AircraftFunc0).Distinct<int>();
					foreach (int current2 in enumerable)
					{
						AirOps.Class2509 @class = new AirOps.Class2509(null);
						@class.int_0 = current2;
						IEnumerable<Aircraft> enumerable2 = current.GetAirOps().GetHostedAircrafts().Where(new Func<Aircraft, bool>(@class.method_0)).Select(AirOps.AircraftFunc1);
						TreeGridViewRow treeGridViewRow = this.treeGridView_0.Nodes.method_0(string.Concat(new string[]
						{
							Conversions.ToString(enumerable2.Count<Aircraft>()),
							"x ",
							Misc.smethod_11(enumerable2.ElementAtOrDefault(0).UnitClass),
							" (",
							current.Name,
							")"
						}));
						treeGridViewRow.Tag = enumerable2;
						treeGridViewRow.Nodes.method_0("Temp");
					}
					foreach (int current3 in this.collection_3)
					{
						foreach (TreeGridViewRow current4 in this.treeGridView_0.Nodes)
						{
							try
							{
								if (((IEnumerable<Aircraft>)current4.Tag).ElementAtOrDefault(0).DBID == current3)
								{
									current4.vmethod_4();
								}
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ex2.Data.Add("Error at 200121", ex2.Message);
								GameGeneral.LogException(ref ex2);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								ProjectData.ClearProjectError();
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 101134", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x0015E2D4 File Offset: 0x0015C4D4
		private void method_15()
		{
			try
			{
				this.treeView_0.Nodes.Clear();
				foreach (Unit current in this.HostUnitSet)
				{
					TreeNode treeNode;
					if (current.IsGroup)
					{
						Group.GroupType groupType = ((Group)current).GetGroupType();
						if (groupType == Group.GroupType.AirBase)
						{
							treeNode = this.treeView_0.Nodes.Add(current.Name);
							treeNode.Tag = current;
							this.method_17((ActiveUnit)current, treeNode);
							continue;
						}
						IEnumerable<ActiveUnit> enumerable = ((Group)current).GetUnitsInGroup().Values.Select(AirOps.ActiveUnitFunc2).OrderBy(AirOps.ActiveUnitFunc3);
						using (IEnumerator<ActiveUnit> enumerator2 = enumerable.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								ActiveUnit current2 = enumerator2.Current;
								if (current2.GetAirFacilities().Length > 0)
								{
									treeNode = this.treeView_0.Nodes.Add(current2.Name);
									treeNode.Tag = current2;
									this.method_17(current2, treeNode);
								}
							}
							continue;
						}
					}
					treeNode = this.treeView_0.Nodes.Add(current.Name);
					treeNode.Tag = current;
					this.method_17((ActiveUnit)current, treeNode);
				}
				this.treeView_0.ExpandAll();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101135", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x0015E4CC File Offset: 0x0015C6CC
		private void method_16()
		{
			this.treeView_0.SuspendLayout();
			foreach (ActiveUnit arg_21_0 in this.HostUnitSet)
			{
				IEnumerator enumerator2 = this.treeView_0.Nodes.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						TreeNode treeNode = (TreeNode)enumerator2.Current;
						ActiveUnit activeUnit_ = (ActiveUnit)treeNode.Tag;
						this.method_17(activeUnit_, treeNode);
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
			this.treeView_0.ResumeLayout();
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x0015E594 File Offset: 0x0015C794
		private void method_17(ActiveUnit activeUnit_1, TreeNode treeNode_0)
		{
			IEnumerable<AirFacility> enumerable = activeUnit_1.GetAirFacilities().Select(AirOps.AirFacilityFunc4).OrderBy(AirOps.AirFacilityFunc5);
			foreach (AirFacility current in enumerable)
			{
				bool flag = false;
				IEnumerator enumerator2 = treeNode_0.Nodes.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						TreeNode treeNode = (TreeNode)enumerator2.Current;
						if (treeNode.Tag == current)
						{
							flag = true;
							this.method_18(current, treeNode);
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
				if (!flag)
				{
					TreeNode treeNode2 = treeNode_0.Nodes.Add(current.Name);
					treeNode2.Tag = current;
					treeNode2.Expand();
					foreach (Aircraft current2 in current.GetHostedAircrafts().Values)
					{
						TreeNodeCollection nodes = treeNode2.Nodes;
						string[] array = new string[8];
						array[0] = current2.Name;
						array[1] = " (";
						array[2] = Misc.smethod_11(current2.UnitClass);
						array[3] = "): ";
						array[4] = current2.GetAircraftAirOps().GetAirOpsConditionString();
						array[5] = " (";
						long seconds = (long)Math.Round((double)current2.GetAircraftAirOps().GetConditionTimer());
						Aircraft aircraft = current2;
						string text = null;
						array[6] = Misc.GetTimeString(seconds, aircraft.GetMaintenanceLevel(ref text), false, false);
						array[7] = ")";
						TreeNode treeNode3 = nodes.Add(string.Concat(array));
						treeNode3.Tag = current2;
						treeNode3.Expand();
					}
				}
			}
			Collection<TreeNode> collection = new Collection<TreeNode>();
			IEnumerator enumerator4 = treeNode_0.Nodes.GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					TreeNode treeNode4 = (TreeNode)enumerator4.Current;
					if (!activeUnit_1.GetAirFacilities().Contains((AirFacility)treeNode4.Tag))
					{
						collection.Add(treeNode4);
					}
				}
			}
			finally
			{
				if (enumerator4 is IDisposable)
				{
					(enumerator4 as IDisposable).Dispose();
				}
			}
			foreach (TreeNode current3 in collection)
			{
				treeNode_0.Nodes.Remove(current3);
			}
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x0015E88C File Offset: 0x0015CA8C
		private void method_18(AirFacility airFacility_0, TreeNode treeNode_0)
		{
			foreach (Aircraft current in airFacility_0.GetHostedAircrafts().Values)
			{
				bool flag = false;
				IEnumerator enumerator2 = treeNode_0.Nodes.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						TreeNode treeNode = (TreeNode)enumerator2.Current;
						if (treeNode.Tag == current)
						{
							flag = true;
							treeNode.Text = string.Concat(new string[]
							{
								current.Name,
								"(",
								Misc.smethod_11(current.UnitClass),
								"): ",
								current.GetAircraftAirOps().GetAirOpsConditionString(),
								" (",
								Misc.GetTimeString((long)Math.Round((double)current.GetAircraftAirOps().GetConditionTimer()), Aircraft_AirOps._Maintenance.const_0, false, false),
								")"
							});
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
				if (!flag)
				{
					TreeNodeCollection nodes = treeNode_0.Nodes;
					string[] array = new string[8];
					array[0] = current.Name;
					array[1] = "(";
					array[2] = Misc.smethod_11(current.UnitClass);
					array[3] = "): ";
					array[4] = current.GetAircraftAirOps().GetAirOpsConditionString();
					array[5] = " (";
					long seconds = (long)Math.Round((double)current.GetAircraftAirOps().GetConditionTimer());
					Aircraft aircraft = current;
					string text = null;
					array[6] = Misc.GetTimeString(seconds, aircraft.GetMaintenanceLevel(ref text), false, false);
					array[7] = ")";
					nodes.Add(string.Concat(array)).Tag = current;
				}
			}
			Collection<TreeNode> collection = new Collection<TreeNode>();
			IEnumerator enumerator3 = treeNode_0.Nodes.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					TreeNode treeNode2 = (TreeNode)enumerator3.Current;
					if (!airFacility_0.GetHostedAircrafts().Values.Contains((Aircraft)treeNode2.Tag))
					{
						collection.Add(treeNode2);
					}
				}
			}
			finally
			{
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			foreach (TreeNode current2 in collection)
			{
				treeNode_0.Nodes.Remove(current2);
			}
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_19(object sender, EventArgs e)
		{
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x00020F9C File Offset: 0x0001F19C
		private void method_20(object sender, EventArgs e)
		{
			this.method_21();
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x0015EB64 File Offset: 0x0015CD64
		private void method_21()
		{
			this.method_22(true, true, true, true, true);
			int count = this.SelectedAvaibleAircrafts.Count;
			if (count != 0)
			{
				if (count == 1)
				{
					Aircraft aircraft = (Aircraft)this.SelectedAvaibleAircrafts[0];
					aircraft.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
					aircraft.GetAircraftAirOps().PreparingToLaunch();
				}
				else
				{
					using (IEnumerator<ActiveUnit> enumerator = this.SelectedAvaibleAircrafts.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Aircraft aircraft2 = (Aircraft)enumerator.Current;
							aircraft2.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
							aircraft2.GetAircraftAirOps().PreparingToLaunch();
						}
					}
				}
			}
			this.method_11();
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x0015EC24 File Offset: 0x0015CE24
		private void method_22(bool bool_3, bool bool_4, bool bool_5, bool bool_6, bool bool_7)
		{
			this.SelectedAvaibleAircrafts.Clear();
			foreach (TreeGridViewRow current in this.treeGridView_0.Nodes)
			{
				foreach (TreeGridViewRow current2 in current.Nodes)
				{
					if (current2.Selected)
					{
						this.SelectedAvaibleAircrafts.Add((Aircraft)current2.Tag);
					}
				}
			}
			if (bool_3)
			{
				List<Aircraft> list = new List<Aircraft>();
				using (IEnumerator<ActiveUnit> enumerator3 = this.SelectedAvaibleAircrafts.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						Aircraft aircraft = (Aircraft)enumerator3.Current;
						Aircraft aircraft2 = aircraft;
						string text = null;
						if (aircraft2.GetMaintenanceLevel(ref text) == Aircraft_AirOps._Maintenance.Unavailable)
						{
							list.Add(aircraft);
						}
					}
				}
				if (list.Count > 0)
				{
					Interaction.MsgBox(Conversions.ToString(list.Count) + " of the selected aircraft are unavailable for operations, and will not launch.", MsgBoxStyle.OkOnly, "Unavailable aircraft selected!");
					foreach (Aircraft current3 in list)
					{
						this.SelectedAvaibleAircrafts.Remove(current3);
					}
				}
			}
			if (bool_4)
			{
				List<Aircraft> list2 = new List<Aircraft>();
				using (IEnumerator<ActiveUnit> enumerator5 = this.SelectedAvaibleAircrafts.GetEnumerator())
				{
					while (enumerator5.MoveNext())
					{
						Aircraft aircraft3 = (Aircraft)enumerator5.Current;
						if (aircraft3.GetSide(false) != Client.GetClientSide())
						{
							list2.Add(aircraft3);
						}
					}
				}
				if (list2.Count > 0)
				{
					Interaction.MsgBox(Conversions.ToString(list2.Count) + " of the selected aircraft are allied units not under your direct control.", MsgBoxStyle.OkOnly, "Allied aircraft selected!");
					foreach (Aircraft current4 in list2)
					{
						this.SelectedAvaibleAircrafts.Remove(current4);
					}
				}
			}
			if (bool_5)
			{
				List<Aircraft> list3 = new List<Aircraft>();
				using (IEnumerator<ActiveUnit> enumerator7 = this.SelectedAvaibleAircrafts.GetEnumerator())
				{
					while (enumerator7.MoveNext())
					{
						Aircraft aircraft4 = (Aircraft)enumerator7.Current;
						if (aircraft4.IsOperating())
						{
							list3.Add(aircraft4);
						}
					}
				}
				if (list3.Count > 0)
				{
					Interaction.MsgBox(Conversions.ToString(list3.Count) + " of the selected aircraft are already airborne.", MsgBoxStyle.OkOnly, "Airborne aircraft selected!");
					foreach (Aircraft current5 in list3)
					{
						this.SelectedAvaibleAircrafts.Remove(current5);
					}
				}
			}
			if (bool_6)
			{
				List<Aircraft> list4 = new List<Aircraft>();
				using (IEnumerator<ActiveUnit> enumerator9 = this.SelectedAvaibleAircrafts.GetEnumerator())
				{
					while (enumerator9.MoveNext())
					{
						Aircraft aircraft5 = (Aircraft)enumerator9.Current;
						if (Information.IsNothing(aircraft5.GetLoadout()))
						{
							list4.Add(aircraft5);
						}
					}
				}
				if (list4.Count > 0)
				{
					Interaction.MsgBox(Conversions.ToString(list4.Count) + " of the selected aircraft do not have a loadout, and will not launch.", MsgBoxStyle.OkOnly, "Aircraft with no loadout selected!");
					foreach (Aircraft current6 in list4)
					{
						this.SelectedAvaibleAircrafts.Remove(current6);
					}
				}
			}
			if (bool_7)
			{
				List<Aircraft> list5 = new List<Aircraft>();
				using (IEnumerator<ActiveUnit> enumerator11 = this.SelectedAvaibleAircrafts.GetEnumerator())
				{
					while (enumerator11.MoveNext())
					{
						Aircraft aircraft6 = (Aircraft)enumerator11.Current;
						if (!Information.IsNothing(aircraft6.GetLoadout()))
						{
							Aircraft aircraft7 = aircraft6;
							string text = null;
							if (aircraft7.GetMaintenanceLevel(ref text) == Aircraft_AirOps._Maintenance.ReserveLoadout)
							{
								list5.Add(aircraft6);
							}
						}
					}
				}
				if (list5.Count > 0)
				{
					Interaction.MsgBox(Conversions.ToString(list5.Count) + " of the selected aircraft have a reserve loadout, and will not launch.", MsgBoxStyle.OkOnly, "Aircraft with reserve loadout selected!");
					foreach (Aircraft current7 in list5)
					{
						this.SelectedAvaibleAircrafts.Remove(current7);
					}
				}
			}
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		private void method_23(object sender, EventArgs e)
		{
			this.method_24();
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x0015F170 File Offset: 0x0015D370
		private void method_24()
		{
			this.SelectedAvaibleAircrafts.Clear();
			foreach (TreeGridViewRow current in this.treeGridView_0.Nodes)
			{
				if (current.Selected)
				{
					foreach (Aircraft current2 in ((IEnumerable<Aircraft>)current.Tag))
					{
						if (current2.GetAircraftAirOps().method_66())
						{
							this.SelectedAvaibleAircrafts.Add(current2);
						}
					}
				}
				if (this.SelectedAvaibleAircrafts.Count > 0)
				{
					break;
				}
				foreach (TreeGridViewRow current3 in current.Nodes)
				{
					if (current3.Selected && ((Aircraft)current3.Tag).GetAircraftAirOps().method_66())
					{
						this.SelectedAvaibleAircrafts.Add((Aircraft)current3.Tag);
					}
				}
				if (this.SelectedAvaibleAircrafts.Count > 0)
				{
					break;
				}
			}
			if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
			{
				List<Aircraft> list = new List<Aircraft>();
				using (IEnumerator<ActiveUnit> enumerator4 = this.SelectedAvaibleAircrafts.GetEnumerator())
				{
					while (enumerator4.MoveNext())
					{
						Aircraft aircraft = (Aircraft)enumerator4.Current;
						Aircraft aircraft2 = aircraft;
						string text = null;
						if (aircraft2.GetMaintenanceLevel(ref text) == Aircraft_AirOps._Maintenance.Unavailable)
						{
							list.Add(aircraft);
						}
					}
				}
				if (list.Count > 0)
				{
					Interaction.MsgBox(Conversions.ToString(list.Count) + " of the selected aircraft are unavailable for operations, and will not be readied.", MsgBoxStyle.OkOnly, "Unavailable aircraft selected!");
					foreach (Aircraft current4 in list)
					{
						this.SelectedAvaibleAircrafts.Remove(current4);
					}
				}
			}
			List<Aircraft> list2 = new List<Aircraft>();
			using (IEnumerator<ActiveUnit> enumerator6 = this.SelectedAvaibleAircrafts.GetEnumerator())
			{
				while (enumerator6.MoveNext())
				{
					Aircraft aircraft3 = (Aircraft)enumerator6.Current;
					if (aircraft3.GetSide(false) != Client.GetClientSide())
					{
						list2.Add(aircraft3);
					}
				}
			}
			if (list2.Count > 0)
			{
				Interaction.MsgBox(Conversions.ToString(list2.Count) + " of the selected aircraft are allied units not under your direct control.", MsgBoxStyle.OkOnly, "Allied aircraft selected!");
				foreach (Aircraft current5 in list2)
				{
					this.SelectedAvaibleAircrafts.Remove(current5);
				}
			}
			List<Aircraft> list3 = new List<Aircraft>();
			using (IEnumerator<ActiveUnit> enumerator8 = this.SelectedAvaibleAircrafts.GetEnumerator())
			{
				while (enumerator8.MoveNext())
				{
					Aircraft aircraft4 = (Aircraft)enumerator8.Current;
					if (aircraft4.IsOperating())
					{
						list3.Add(aircraft4);
					}
				}
			}
			if (list3.Count > 0)
			{
				Interaction.MsgBox(Conversions.ToString(list3.Count) + "架选定飞机已经在空.", MsgBoxStyle.OkOnly, "选择在空飞机!");
				foreach (Aircraft current6 in list3)
				{
					this.SelectedAvaibleAircrafts.Remove(current6);
				}
			}
			int num = 0;
			List<Aircraft> list4 = new List<Aircraft>();
			using (IEnumerator<ActiveUnit> enumerator10 = this.SelectedAvaibleAircrafts.GetEnumerator())
			{
				while (enumerator10.MoveNext())
				{
					Aircraft aircraft5 = (Aircraft)enumerator10.Current;
					if (num == 0)
					{
						num = aircraft5.DBID;
					}
					else if (aircraft5.DBID != num)
					{
						list4.Add(aircraft5);
					}
				}
			}
			if (list4.Count > 0)
			{
				Interaction.MsgBox(Conversions.ToString(list4.Count) + " of the selected aircraft are of a different type, and will not be readied.", MsgBoxStyle.OkOnly, "Different aircraft types selected!");
				foreach (Aircraft current7 in list4)
				{
					this.SelectedAvaibleAircrafts.Remove(current7);
				}
			}
			if (this.SelectedAvaibleAircrafts.Count > 0)
			{
				if (!Information.IsNothing(CommandFactory.GetCommandMain().GetReadyAircraft().list_0))
				{
					CommandFactory.GetCommandMain().GetReadyAircraft().list_0.Clear();
				}
				else
				{
					CommandFactory.GetCommandMain().GetReadyAircraft().list_0 = new List<Aircraft>();
				}
				foreach (ActiveUnit current8 in this.SelectedAvaibleAircrafts)
				{
					CommandFactory.GetCommandMain().GetReadyAircraft().list_0.Add((Aircraft)current8);
				}
				if (!Information.IsNothing(((Aircraft)this.SelectedAvaibleAircrafts[0]).GetLoadout()))
				{
					CommandFactory.GetCommandMain().GetReadyAircraft().ID = ((Aircraft)this.SelectedAvaibleAircrafts[0]).GetLoadout().DBID;
				}
				else
				{
					CommandFactory.GetCommandMain().GetReadyAircraft().ID = 0;
				}
				CommandFactory.GetCommandMain().GetReadyAircraft().Show();
			}
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x0015F820 File Offset: 0x0015DA20
		private void method_25(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				TreeGridViewRow treeGridViewRow = null;
				foreach (TreeGridViewRow current in this.treeGridView_0.Nodes)
				{
					if (current.Selected)
					{
						treeGridViewRow = current;
						break;
					}
				}
				if (!Information.IsNothing(treeGridViewRow) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(treeGridViewRow.Tag)))
				{
					int dBID = ((IEnumerable<Aircraft>)treeGridViewRow.Tag).ElementAtOrDefault(0).DBID;
					Client.ShowDBInfo("飞机", dBID);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200122", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x00020FAC File Offset: 0x0001F1AC
		private void method_26(object sender, EventArgs5 e)
		{
			if (e.method_0().method_6() == 1)
			{
				this.collection_3.Remove(((IEnumerable<Aircraft>)e.method_0().Tag).ElementAtOrDefault(0).DBID);
			}
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x0015F910 File Offset: 0x0015DB10
		private void method_27(object sender, EventArgs6 e)
		{
			e.method_0().Nodes.Clear();
			if (e.method_0().method_6() == 1)
			{
				int dBID = ((IEnumerable<Aircraft>)e.method_0().Tag).ElementAtOrDefault(0).DBID;
				if (!this.collection_3.Contains(dBID))
				{
					this.collection_3.Add(dBID);
				}
				List<Aircraft> list = ((IEnumerable<Aircraft>)e.method_0().Tag).Select(AirOps.AircraftFunc6).OrderBy(AirOps.AircraftFunc7, new Class265<string[]>(true)).ToList<Aircraft>();
				foreach (Aircraft current in list)
				{
					string string_;
					if (Information.IsNothing(current.GetLoadout()))
					{
						string_ = "无挂载";
					}
					else
					{
						string_ = current.GetLoadout().Name;
					}
					string text;
					if (Information.IsNothing(current.GetAssignedMission(false)))
					{
						if (!Information.IsNothing(current.GetAssignedTaskPool()))
						{
							text = current.GetAssignedTaskPool().Name + " (任务（Task）池)";
						}
						else
						{
							text = "-";
						}
					}
					else
					{
						string text2 = "";
						if (current.GetAircraftAI().IsEscort)
						{
							text2 = ", 护航";
						}
						text = string.Concat(new string[]
						{
							current.GetAssignedMission(false).Name,
							" (",
							current.GetAssignedMission(false).GetTypeString(Client.GetClientScenario()),
							text2,
							")"
						});
					}
					TreeGridViewRowNodes nodes = e.method_0().Nodes;
					object[] array = new object[6];
					array[0] = current.Name;
					array[1] = current.GetAircraftAirOps().GetAirOpsConditionString();
					array[2] = text;
					array[3] = Misc.smethod_11(string_);
					long seconds = (long)Math.Round((double)current.GetAircraftAirOps().GetConditionTimer());
					Aircraft aircraft = current;
					string text3 = null;
					array[4] = Misc.GetTimeString(seconds, aircraft.GetMaintenanceLevel(ref text3), false, false);
					array[5] = current.GetQuickTurnAroundInfo();
					TreeGridViewRow treeGridViewRow = nodes.method_1(array);
					treeGridViewRow.DefaultCellStyle.ForeColor = Color.Black;
					treeGridViewRow.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Regular);
					if (current.GetAircraftAirOps().GetConditionTimer() != 0f)
					{
						goto IL_256;
					}
					Aircraft aircraft2 = current;
					text3 = null;
					if (aircraft2.GetMaintenanceLevel(ref text3) != Aircraft_AirOps._Maintenance.const_0)
					{
						goto IL_256;
					}
					treeGridViewRow.DefaultCellStyle.ForeColor = Color.DarkGreen;
					IL_2A4:
					treeGridViewRow.Tag = current;
					continue;
					IL_256:
					Aircraft aircraft3 = current;
					text3 = null;
					if (aircraft3.GetMaintenanceLevel(ref text3) == Aircraft_AirOps._Maintenance.const_0)
					{
						treeGridViewRow.DefaultCellStyle.ForeColor = Color.Black;
						goto IL_2A4;
					}
					treeGridViewRow.DefaultCellStyle.ForeColor = Color.Red;
					goto IL_2A4;
				}
			}
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		private void method_28(object sender, EventArgs e)
		{
			this.method_29();
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x0015FC00 File Offset: 0x0015DE00
		private void method_29()
		{
			this.method_22(true, true, true, true, true);
			Misc.smethod_60(this.SelectedAvaibleAircrafts, Client.GetClientScenario(), Client.GetClientSide(), null);
			int count = this.SelectedAvaibleAircrafts.Count;
			if (count != 0)
			{
				if (count == 1)
				{
					Aircraft aircraft = (Aircraft)this.SelectedAvaibleAircrafts[0];
					aircraft.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
					aircraft.GetAircraftAirOps().PreparingToLaunch();
				}
				else
				{
					using (IEnumerator<ActiveUnit> enumerator = this.SelectedAvaibleAircrafts.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Aircraft aircraft2 = (Aircraft)enumerator.Current;
							aircraft2.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
							aircraft2.GetAircraftAirOps().PreparingToLaunch();
						}
					}
				}
			}
			this.method_11();
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x00020FF0 File Offset: 0x0001F1F0
		private void method_30(object sender, DoWorkEventArgs e)
		{
			Thread.Sleep(10);
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x00020FF9 File Offset: 0x0001F1F9
		private void method_31(object sender, RunWorkerCompletedEventArgs e)
		{
			this.method_14();
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x0015FCD8 File Offset: 0x0015DED8
		private void AirOps_Shown(object sender, EventArgs e)
		{
			this.bool_0 = (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Run);
			if (this.bool_0)
			{
				Client.GetConfiguration().SetSimStopMode();
			}
			if (this.HostUnitSet.Count > 1)
			{
				this.Text = "空中行动 - 多基地";
			}
			else
			{
				this.Text = "空中行动 - " + this.HostUnitSet.ElementAtOrDefault(0).Name;
			}
			this.method_7();
			this.method_15();
			this.toolStripButton_4.Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.toolStripButton_5.Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.toolStripButton_6.Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.TSB_Cargo.Visible = Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps);
			this.toolStripSeparator_0.Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.timer_0.Start();
			Aircraft_AirOps.smethod_1(new Aircraft_AirOps.Delegate6(this.method_8));
			Aircraft_AirOps.smethod_3(new Aircraft_AirOps.Delegate7(this.method_5));
			Group.smethod_1(new Group.Delegate14(this.method_1));
			Group.smethod_3(new Group.Delegate15(this.method_2));
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x00021001 File Offset: 0x0001F201
		private void method_32(object sender, EventArgs e)
		{
			this.method_33();
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x0015FE24 File Offset: 0x0015E024
		private void method_33()
		{
			this.method_22(false, true, true, false, false);
			foreach (ActiveUnit current in this.SelectedAvaibleAircrafts)
			{
				if (((Aircraft_AirOps)current.GetAirOps()).method_24())
				{
					((Aircraft_AirOps)current.GetAirOps()).Landing(true, false, true);
				}
				if (current.HasParentGroup())
				{
					current.SetParentGroup(false, null);
				}
			}
			this.method_11();
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x0015FEBC File Offset: 0x0015E0BC
		private void method_34(object sender, EventArgs e)
		{
			this.SelectedAvaibleAircrafts.Clear();
			bool flag = false;
			foreach (TreeGridViewRow current in this.treeGridView_0.Nodes)
			{
				if (current.Selected)
				{
					flag = true;
				}
				foreach (TreeGridViewRow current2 in current.Nodes)
				{
					if (current2.Selected)
					{
						this.SelectedAvaibleAircrafts.Add((Aircraft)current2.Tag);
					}
				}
			}
			if (this.SelectedAvaibleAircrafts.Count > 0)
			{
				ActiveUnit currentHostUnit = ((Aircraft_AirOps)this.SelectedAvaibleAircrafts[0].GetAirOps()).GetCurrentHostUnit();
				if (this.activeUnit_0 != currentHostUnit)
				{
					this.dictionary_0 = this.method_3(ref currentHostUnit);
					this.activeUnit_0 = currentHostUnit;
				}
			}
			if (!flag)
			{
				int count = this.SelectedAvaibleAircrafts.Count;
				if (count == 1)
				{
					Aircraft aircraft = (Aircraft)this.SelectedAvaibleAircrafts[0];
					if (!Information.IsNothing(aircraft.GetLoadout()))
					{
						if (this.SelectedAvaibleAircrafts[0].IsOperating())
						{
							if (!Information.IsNothing(this.dataTable_0))
							{
								this.dataTable_0.Rows.Clear();
							}
						}
						else
						{
							int dBID = this.SelectedAvaibleAircrafts[0].DBID;
							Dictionary<int, int> selectedAircraftTotalWeaponQty = this.dictionary_0;
							SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
							Scenario clientScenario = Client.GetClientScenario();
							Scenario clientScenario2 = Client.GetClientScenario();
							Scenario clientScenario3 = Client.GetClientScenario();
							bool flag2 = clientScenario2.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags);
							Collection<ActiveUnit> selectedAvaibleAircrafts;
							Aircraft value = (Aircraft)(selectedAvaibleAircrafts = this.SelectedAvaibleAircrafts)[0];
							DataTable dataTable = DBFunctions.smethod_42(dBID, selectedAircraftTotalWeaponQty, ref sQLiteConnection, clientScenario, ref flag2, ref clientScenario3, ref value, ref ((Aircraft)this.SelectedAvaibleAircrafts[0]).GetLoadout().DBID, ref aircraft.GetLoadout().NOW);
							selectedAvaibleAircrafts[0] = value;
							this.dataTable_0 = dataTable;
						}
					}
					else if (!Information.IsNothing(this.dataTable_0))
					{
						this.dataTable_0.Rows.Clear();
					}
				}
				else if (!Information.IsNothing(this.dataTable_0))
				{
					this.dataTable_0.Rows.Clear();
				}
			}
			else if (!Information.IsNothing(this.dataTable_0))
			{
				this.dataTable_0.Rows.Clear();
			}
			if (!Information.IsNothing(this.dataTable_0))
			{
				if (this.SelectedAvaibleAircrafts.Count > 0)
				{
					this.method_36((Aircraft)this.SelectedAvaibleAircrafts[0]);
				}
				else
				{
					this.method_36(null);
				}
			}
			if (this.SelectedAvaibleAircrafts.Count > 0)
			{
				this.toolStripButton_0.Enabled = true;
				this.toolStripButton_1.Enabled = true;
				this.toolStripButton_2.Enabled = true;
				this.toolStripButton_3.Enabled = true;
				this.toolStripButton_7.Enabled = true;
				this.TSB_AssignToMission.Enabled = true;
				if (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit)
				{
					this.toolStripButton_4.Enabled = true;
					this.toolStripButton_5.Enabled = true;
					this.toolStripButton_6.Enabled = true;
				}
			}
			else
			{
				this.toolStripButton_0.Enabled = false;
				this.toolStripButton_1.Enabled = false;
				this.toolStripButton_2.Enabled = false;
				this.toolStripButton_3.Enabled = false;
				this.toolStripButton_7.Enabled = false;
				this.TSB_AssignToMission.Enabled = false;
				if (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit)
				{
					this.toolStripButton_4.Enabled = false;
					this.toolStripButton_5.Enabled = false;
					this.toolStripButton_6.Enabled = false;
				}
			}
			this.method_35();
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x001602BC File Offset: 0x0015E4BC
		private void method_35()
		{
			bool flag = true;
			int num = 0;
			bool? flag2 = new bool?(false);
			int? num2 = new int?(0);
			if (this.SelectedAvaibleAircrafts.Count > 0)
			{
				using (IEnumerator<ActiveUnit> enumerator = this.SelectedAvaibleAircrafts.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Aircraft aircraft = (Aircraft)enumerator.Current;
						num++;
						if (aircraft.GetSide(false) == Client.GetClientSide())
						{
							int? num3 = new int?(0);
							if (num == 1 && !Information.IsNothing(aircraft.GetLoadout()))
							{
								num3 = new int?(aircraft.GetLoadout().DBID);
							}
							Doctrine._QuickTurnAround? quickTurnAroundDoctrine = aircraft.m_Doctrine.GetQuickTurnAroundDoctrine(aircraft.m_Scenario, false, false, false, false);
							byte? b = quickTurnAroundDoctrine.HasValue ? new byte?((byte)quickTurnAroundDoctrine.GetValueOrDefault()) : null;
							if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								quickTurnAroundDoctrine = aircraft.m_Doctrine.GetQuickTurnAroundDoctrine(aircraft.m_Scenario, false, false, false, false);
								b = (quickTurnAroundDoctrine.HasValue ? new byte?((byte)quickTurnAroundDoctrine.GetValueOrDefault()) : null);
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									if (Information.IsNothing(aircraft.GetLoadout()))
									{
										flag = false;
										break;
									}
									Loadout loadout = aircraft.GetLoadout();
									if (!loadout.method_13() && !loadout.method_15() && !loadout.LoadoutRoleIsASWPatrol())
									{
										flag = false;
										break;
									}
								}
								else if (!Information.IsNothing(num3))
								{
									if (Information.IsNothing(aircraft.GetLoadout()))
									{
										flag = false;
										break;
									}
									int? num4 = num3;
									int num5 = aircraft.GetLoadout().DBID;
									if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() != num5) : null).GetValueOrDefault())
									{
										flag = false;
										break;
									}
								}
								else if (Information.IsNothing(num3))
								{
									flag = false;
									break;
								}
								if (!Information.IsNothing(aircraft.GetLoadout()))
								{
									if (!aircraft.GetLoadout().QuickTurnaround)
									{
										flag = false;
										break;
									}
									Doctrine._AirOpsTempo? airOpsTempoDoctrine = aircraft.m_Doctrine.GetAirOpsTempoDoctrine(aircraft.m_Scenario, false, false, false, false);
									b = (airOpsTempoDoctrine.HasValue ? new byte?((byte)airOpsTempoDoctrine.GetValueOrDefault()) : null);
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
									{
										this.int_0 = aircraft.GetLoadout().int_3;
									}
									else
									{
										this.int_0 = aircraft.GetLoadout().ReadyTime;
									}
									this.bool_1 = aircraft.GetLoadout().QuickTurnaround;
									this.int_2 = aircraft.GetLoadout().QT_ReadyTime;
									this.int_1 = aircraft.GetLoadout().QT_AirborneTime;
									this.int_3 = aircraft.GetLoadout().QT_MaxSorties;
									this.int_4 = aircraft.GetLoadout().QT_AdditionalTimePenalty;
									if (!this.bool_1)
									{
										flag = false;
										break;
									}
								}
								Aircraft_AirOps aircraftAirOps = aircraft.GetAircraftAirOps();
								if (!Information.IsNothing(flag2))
								{
									bool quickTurnaround_Enabled = aircraftAirOps.QuickTurnaround_Enabled;
									if ((flag2.HasValue ? new bool?(quickTurnaround_Enabled != flag2.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										flag2 = null;
									}
									int num5 = aircraftAirOps.QuickTurnaround_SortiesTotal;
									if ((num2.HasValue ? new bool?(num5 != num2.GetValueOrDefault()) : null).GetValueOrDefault() && !Information.IsNothing(num2))
									{
										num2 = null;
										continue;
									}
									continue;
								}
								else
								{
									if (num == 1)
									{
										flag2 = new bool?(aircraftAirOps.QuickTurnaround_Enabled);
										num2 = new int?(aircraftAirOps.QuickTurnaround_SortiesTotal);
										continue;
									}
									continue;
								}
							}
							else
							{
								flag = false;
							}
						}
						else
						{
							flag = false;
						}
						IL_45C:
						goto IL_46F;
					}
					goto IL_46F;
				}
			}
			flag = false;
			IL_46F:
			this.bool_2 = false;
			if (flag)
			{
				this.checkBox_0.Enabled = true;
				if (Information.IsNothing(flag2))
				{
					this.checkBox_0.CheckState = CheckState.Indeterminate;
					this.method_47(num2);
					this.comboBox_0.Enabled = false;
					this.label_8.Enabled = true;
					this.label_8.Text = "选择的飞机既可以带快速出动选项也不可以不带.";
				}
				else if (flag2.GetValueOrDefault())
				{
					if (this.checkBox_0.CheckState == CheckState.Indeterminate)
					{
						this.checkBox_0.CheckState = CheckState.Checked;
					}
					else
					{
						this.checkBox_0.Checked = true;
					}
					this.method_47(num2);
					this.comboBox_0.Enabled = true;
					this.label_8.Enabled = true;
					if (!Information.IsNothing(num2))
					{
						this.label_8.Text = this.method_44();
					}
					else
					{
						this.label_8.Text = "";
					}
				}
				else
				{
					if (this.checkBox_0.CheckState == CheckState.Indeterminate)
					{
						this.checkBox_0.CheckState = CheckState.Unchecked;
					}
					else
					{
						this.checkBox_0.Checked = false;
					}
					this.method_47(new int?(this.int_3));
					this.comboBox_0.Enabled = false;
					this.label_8.Enabled = false;
					this.label_8.Text = "";
				}
			}
			else
			{
				this.checkBox_0.Enabled = false;
				if (this.checkBox_0.CheckState == CheckState.Indeterminate)
				{
					this.checkBox_0.CheckState = CheckState.Unchecked;
				}
				else
				{
					this.checkBox_0.Checked = false;
				}
				this.method_47(new int?(this.int_3));
			}
			this.bool_2 = true;
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x0016090C File Offset: 0x0015EB0C
		private void method_36(Aircraft aircraft_0)
		{
			new SQLiteDataBase(Client.GetClientScenario().GetSQLiteConnection());
			try
			{
				if (this.dataTable_0.Rows.Count > 0 && Conversions.ToInteger(this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["ID"]) > 4)
				{
					this.label_4.Text = "作战半径与航行剖面: " + this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["RangeProfileDescription"].ToString();
					this.label_2.Text = Conversions.ToString(this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["LoadoutRoleDescription"]);
					this.label_1.Text = string.Concat(new string[]
					{
						"能力: ",
						this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["TimeofDay"].ToString(),
						", ",
						this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["Weather"].ToString(),
						" capable"
					});
					Doctrine._WeaponState value = aircraft_0.m_Doctrine.GetWinchesterShotgunDoctrine(Client.GetClientScenario(), false, false, false, false).Value;
					if (value == Doctrine._WeaponState.LoadoutSetting)
					{
						this.label_9.Text = "预置飞机返航武器状态条件 " + Conversions.ToString(this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["WinchesterShotgunDescription"]);
					}
					else
					{
						string winchesterString = Aircraft.GetWinchesterString(Conversions.ToInteger(this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["ID"]), (int)value, (Loadout.LoadoutRole)Conversions.ToInteger(this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["LoadoutRole"]), Client.GetClientScenario());
						string text = Conversions.ToString(this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["WinchesterShotgunDescription"]);
						if (string.CompareOrdinal(text, winchesterString) != 0)
						{
							this.label_9.Text = string.Concat(new string[]
							{
								"有效的预置飞机返航武器状态条件",
								winchesterString,
								Environment.NewLine,
								"挂载缺省的飞机返航武器状态条件",
								text
							});
						}
						else
						{
							this.label_9.Text = "预置飞机返航武器状态条件" + text;
						}
					}
					this.label_0.Text = "攻击高度: " + this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["AttackAltitude"].ToString();
					this.label_5.Text = "弹药库中可用挂载: " + this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["NumberOfLoadouts"].ToString();
					this.label_6.Text = "可用挂载数，包括飞机上的挂载: " + this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["NumberOfLoadoutsIncludingMountedWeapons"].ToString();
					this.label_7.Text = "可用挂载数，同上，可选武器除外: " + this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["NumberOfLoadoutsIncludingMountedWeapon_MandatoryOnly"].ToString();
					this.label_3.Text = "挂载方案: " + this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["Name"].ToString();
					int num = Conversions.ToInteger(this.dataTable_0.AsEnumerable().ElementAtOrDefault(0)["ID"]);
					SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
					this.dataTable_1 = DBFunctions.LoadLoadoutWeaponsData(num, ref sQLiteConnection, ref aircraft_0.GetLoadout().NOW);
					this.dataTable_1.Columns.Add("Available");
					this.dataTable_1.Columns.Add("AvailableTotal");
					IEnumerator enumerator = this.dataTable_1.Rows.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							int num2 = Conversions.ToInteger(dataRow["ComponentID"]);
							int dBID_ = Conversions.ToInteger(dataRow["ComponentID"]);
							Scenario clientScenario = Client.GetClientScenario();
							if (Weapon.IsNotLaunchableFireWeapon(dBID_, ref clientScenario))
							{
								dataRow["Available"] = "-";
								dataRow["AvailableTotal"] = "-";
							}
							else if (!Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags))
							{
								int weaponLoadsInMagazines = ((Aircraft)this.treeGridView_0.SelectedRows[0].Tag).GetAircraftAirOps().GetCurrentHostUnit().GetWeaponry().GetWeaponLoadsInMagazines(num2);
								int num3 = 0;
								if (!Information.IsNothing(this.dictionary_0) && this.dictionary_0.ContainsKey(num2))
								{
									num3 = this.dictionary_0[num2];
								}
								dataRow["Available"] = weaponLoadsInMagazines;
								dataRow["AvailableTotal"] = weaponLoadsInMagazines + num3;
							}
							else
							{
								dataRow["Available"] = "无限制";
								dataRow["AvailableTotal"] = "无限制";
							}
							dataRow["Item"] = Misc.smethod_11(Conversions.ToString(dataRow["Item"]));
						}
						goto IL_611;
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				this.label_4.Text = "";
				this.label_2.Text = "";
				this.label_1.Text = "";
				this.label_9.Text = "";
				this.label_0.Text = "";
				this.label_5.Text = "";
				this.label_6.Text = "";
				this.label_7.Text = "";
				this.label_3.Text = "挂载方案具体情况:尚未选定";
				this.dataTable_1.Rows.Clear();
				IL_611:
				this.dataGridView_0.AutoGenerateColumns = false;
				this.dataGridView_0.DataSource = this.dataTable_1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101136", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x00160FC0 File Offset: 0x0015F1C0
		private void AirOps_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F6 && base.Visible)
			{
				base.Close();
			}
			else if (!base.Visible || (e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract && e.KeyCode != Keys.End && e.KeyCode != Keys.Home))
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x00021009 File Offset: 0x0001F209
		private void method_37(object sender, EventArgs e)
		{
			this.method_38();
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x001610A0 File Offset: 0x0015F2A0
		private void method_38()
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			foreach (TreeGridViewRow current in this.treeGridView_0.Nodes)
			{
				foreach (TreeGridViewRow current2 in current.Nodes)
				{
					if (current2.Selected)
					{
						list.Add((Aircraft)current2.Tag);
					}
				}
			}
			if (list.Count == 1)
			{
				CommandFactory.GetCommandMain().GetRenameObject().string_0 = list[0].Name;
				if (CommandFactory.GetCommandMain().GetRenameObject().ShowDialog() == DialogResult.OK)
				{
					list[0].Name = CommandFactory.GetCommandMain().GetRenameObject().string_0;
				}
				this.method_11();
				this.method_16();
			}
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x00021011 File Offset: 0x0001F211
		private void method_39(object sender, EventArgs e)
		{
			this.method_40();
		}

		// Token: 0x060040CA RID: 16586 RVA: 0x001611B4 File Offset: 0x0015F3B4
		private void method_40()
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			foreach (TreeGridViewRow current in this.treeGridView_0.Nodes)
			{
				foreach (TreeGridViewRow current2 in current.Nodes)
				{
					if (current2.Selected)
					{
						list.Add((Aircraft)current2.Tag);
					}
				}
			}
			CommandFactory.GetCommandMain().GetTimeToReadyWindow().list_0 = list;
			CommandFactory.GetCommandMain().GetTimeToReadyWindow().Show();
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x00021019 File Offset: 0x0001F219
		private void method_41(object sender, EventArgs e)
		{
			this.method_42();
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x00161280 File Offset: 0x0015F480
		private void method_42()
		{
			List<TreeGridViewRow> list = new List<TreeGridViewRow>();
			foreach (TreeGridViewRow current in this.treeGridView_0.Nodes)
			{
				foreach (TreeGridViewRow current2 in current.Nodes)
				{
					if (current2.Selected)
					{
						list.Add(current2);
					}
				}
			}
			foreach (TreeGridViewRow current3 in list)
			{
				Aircraft aircraft = (Aircraft)current3.Tag;
				aircraft.GetAircraftAirOps().GetHostAirFacility().GetHostedAircrafts().TryRemove(aircraft.GetGuid(), out aircraft);
				Scenario clientScenario = Client.GetClientScenario();
				GameGeneral.RemoveUnit(ref clientScenario, aircraft.GetGuid());
				current3.method_7().Nodes.Remove(current3);
			}
			if (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Stop)
			{
				CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit(), false);
			}
			this.method_14();
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x001613F0 File Offset: 0x0015F5F0
		private void method_43(object sender, EventArgs e)
		{
			this.label_8.Text = this.method_44();
			if (this.bool_2)
			{
				using (IEnumerator<ActiveUnit> enumerator = this.SelectedAvaibleAircrafts.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Aircraft aircraft = (Aircraft)enumerator.Current;
						Aircraft_AirOps aircraftAirOps = aircraft.GetAircraftAirOps();
						if (aircraftAirOps.QuickTurnaround_SortiesFlown >= this.comboBox_0.SelectedIndex + 2)
						{
							if (Interaction.MsgBox("Aircraft " + aircraft.Name + " had flow equal or more sorties than the selected Max Number of Sorties. Do you want to change to this number and stand down?", MsgBoxStyle.YesNo, "Change Max Number of Sorties and Stand Down?") == MsgBoxResult.Yes)
							{
								aircraftAirOps.method_53(ref aircraftAirOps, ref aircraft);
								if (this.comboBox_0.SelectedIndex + 2 <= aircraft.GetLoadout().QT_MaxSorties)
								{
									aircraftAirOps.QuickTurnaround_SortiesTotal = this.comboBox_0.SelectedIndex + 2;
								}
							}
						}
						else if (this.comboBox_0.SelectedIndex + 2 <= aircraft.GetLoadout().QT_MaxSorties)
						{
							aircraftAirOps.QuickTurnaround_SortiesTotal = this.comboBox_0.SelectedIndex + 2;
						}
					}
				}
			}
			this.method_6();
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x0016151C File Offset: 0x0015F71C
		public string method_44()
		{
			string result;
			if (this.comboBox_0.SelectedIndex + 2 <= this.int_3)
			{
				result = string.Concat(new string[]
				{
					Conversions.ToString(this.comboBox_0.SelectedIndex + 2),
					" 波次@",
					Misc.GetTimeString((long)(this.int_1 * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
					"最大留空时间，",
					Misc.GetTimeString((long)(this.int_2 * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
					"一次往返,  ",
					Misc.GetTimeString((long)(this.int_0 * 60), Aircraft_AirOps._Maintenance.const_0, false, false),
					"休整准备时间"
				});
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x001615D8 File Offset: 0x0015F7D8
		private void method_45(int? nullable_0)
		{
			this.comboBox_0.Items.Clear();
			this.comboBox_0.SelectedIndex = -1;
			if (this.checkBox_0.CheckState != CheckState.Indeterminate && this.checkBox_0.Checked)
			{
				int num = this.int_3;
				for (int i = 2; i <= num; i++)
				{
					if (i == this.int_3)
					{
						this.comboBox_0.Items.Add(Conversions.ToString(i) + "波次(最大)");
					}
					else
					{
						this.comboBox_0.Items.Add(Conversions.ToString(i) + "波次");
					}
				}
				if (!Information.IsNothing(nullable_0) && this.comboBox_0.Items.Count > 0)
				{
					Aircraft_AirOps aircraft_AirOps = (Aircraft_AirOps)this.SelectedAvaibleAircrafts[0].GetAirOps();
					if (aircraft_AirOps.QuickTurnaround_SortiesTotal == 0)
					{
						this.comboBox_0.SelectedIndex = this.int_3 - 2;
						return;
					}
					if (this.comboBox_0.Items.Count < aircraft_AirOps.QuickTurnaround_SortiesTotal - 2)
					{
						this.comboBox_0.SelectedIndex = this.comboBox_0.Items.Count - 1;
						return;
					}
					try
					{
						this.comboBox_0.SelectedIndex = aircraft_AirOps.QuickTurnaround_SortiesTotal - 2;
						return;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						this.comboBox_0.SelectedIndex = 0;
						ProjectData.ClearProjectError();
						return;
					}
				}
				this.comboBox_0.Items.Add("Various");
				this.comboBox_0.SelectedIndex = this.comboBox_0.Items.Count - 1;
			}
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x00021021 File Offset: 0x0001F221
		private void method_46(object sender, EventArgs e)
		{
			if (this.bool_2)
			{
				this.method_47(new int?(this.int_3));
			}
			this.method_6();
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x001617A8 File Offset: 0x0015F9A8
		private void method_47(int? nullable_0)
		{
			if (this.checkBox_0.Checked)
			{
				this.comboBox_0.Enabled = true;
				this.method_45(nullable_0);
				this.label_8.Enabled = true;
				this.label_8.Text = this.method_44();
				if (!this.bool_2)
				{
					return;
				}
				using (IEnumerator<ActiveUnit> enumerator = this.SelectedAvaibleAircrafts.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						((Aircraft)enumerator.Current).GetAircraftAirOps().QuickTurnaround_Enabled = true;
					}
					return;
				}
			}
			this.comboBox_0.Enabled = false;
			this.method_45(nullable_0);
			this.label_8.Enabled = false;
			this.label_8.Text = "";
			if (this.bool_2)
			{
				using (IEnumerator<ActiveUnit> enumerator2 = this.SelectedAvaibleAircrafts.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Aircraft aircraft = (Aircraft)enumerator2.Current;
						Aircraft_AirOps aircraftAirOps = aircraft.GetAircraftAirOps();
						if (aircraftAirOps.QuickTurnaround_SortiesFlown > 0)
						{
							if (Interaction.MsgBox("Aircraft " + aircraft.Name + " had Quick Turnaround enabled previously and has flown at least one Quick Turnaround Sortie. Do you want to disable Quick Turnaround and stand down?", MsgBoxStyle.YesNo, "Disable Quick Turnaround and Stand Down?") == MsgBoxResult.Yes)
							{
								aircraftAirOps.QuickTurnaround_Enabled = false;
								aircraftAirOps.method_53(ref aircraftAirOps, ref aircraft);
							}
						}
						else
						{
							aircraftAirOps.QuickTurnaround_Enabled = false;
							aircraftAirOps.method_53(ref aircraftAirOps, ref aircraft);
						}
					}
				}
			}
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x0016192C File Offset: 0x0015FB2C
		private void AirOps_FormClosed(object sender, FormClosedEventArgs e)
		{
			Aircraft_AirOps.smethod_2(new Aircraft_AirOps.Delegate6(this.method_8));
			Aircraft_AirOps.smethod_4(new Aircraft_AirOps.Delegate7(this.method_5));
			Group.smethod_2(new Group.Delegate14(this.method_1));
			Group.smethod_4(new Group.Delegate15(this.method_2));
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void TSB_AssignToMission_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x00161980 File Offset: 0x0015FB80
		private void TSB_AssignToMission_DropDownOpening(object sender, EventArgs e)
		{
			this.SelectedAvaibleAircrafts.Clear();
			foreach (TreeGridViewRow current in this.treeGridView_0.Nodes)
			{
				foreach (TreeGridViewRow current2 in current.Nodes)
				{
					if (current2.Selected)
					{
						this.SelectedAvaibleAircrafts.Add((Aircraft)current2.Tag);
					}
				}
			}
			this.TSB_AssignToMission.DropDownItems.Clear();
			if (this.SelectedAvaibleAircrafts.Count > 0)
			{
				new ToolStripMenuItem();
				((ToolStripMenuItem)this.TSB_AssignToMission.DropDown.Items.Add("< Unassign >", null, new EventHandler(this.TSB_AssignToMission_Click))).Tag = null;
				foreach (Mission current3 in Client.GetClientSide().GetMissionCollection())
				{
					ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
					ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
					toolStripMenuItem = (ToolStripMenuItem)this.TSB_AssignToMission.DropDown.Items.Add(current3.Name, null, new EventHandler(this.TSB_AssignToMission_Click));
					toolStripMenuItem.Tag = current3;
					if (current3.MissionClass == Mission._MissionClass.Strike)
					{
						toolStripMenuItem2 = (ToolStripMenuItem)this.TSB_AssignToMission.DropDown.Items.Add(current3.Name + " - Escort", null, new EventHandler(this.TSB_AssignToMission_Click));
						toolStripMenuItem2.Tag = current3;
					}
					if (this.SelectedAvaibleAircrafts.Count == 1)
					{
						ActiveUnit activeUnit = this.SelectedAvaibleAircrafts[0];
						if (current3 == activeUnit.GetAssignedMission(false))
						{
							if (current3.MissionClass == Mission._MissionClass.Strike && activeUnit.GetAI().IsEscort)
							{
								toolStripMenuItem2.Checked = true;
							}
							else
							{
								toolStripMenuItem.Checked = true;
							}
						}
					}
				}
			}
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x00021045 File Offset: 0x0001F245
		private void TSB_AssignToMission_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			this.DoAssignToMission(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x00161BFC File Offset: 0x0015FDFC
		private void DoAssignToMission(object sender, ToolStripItemClickedEventArgs e)
		{
			this.method_22(false, true, true, false, false);
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(e.ClickedItem.Tag)))
			{
				using (IEnumerator<ActiveUnit> enumerator = this.SelectedAvaibleAircrafts.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						CommandFactory.GetCommandMain().GetMainForm().method_366(ref current);
					}
					goto IL_F5;
				}
			}
			Mission mission_ = (Mission)e.ClickedItem.Tag;
			bool flag = Strings.InStr(e.ClickedItem.Text, " - Escort", CompareMethod.Binary) != 0;
			CommandFactory.GetCommandMain().GetMainForm().AssignToMission(RuntimeHelpers.GetObjectValue(sender), ref this.SelectedAvaibleAircrafts, ref mission_, ref flag);
            ActiveUnit current2X;
            foreach (ActiveUnit current2 in this.SelectedAvaibleAircrafts)
			{
                current2X = current2;

                StrikePlanner.smethod_37(current2.m_Scenario, mission_, ref current2X);
			}
			IL_F5:
			this.method_6();
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x00161D20 File Offset: 0x0015FF20
		private void method_52(object sender, EventArgs e)
		{
			this.method_22(false, true, true, false, false);
			if (this.SelectedAvaibleAircrafts.Count > 0)
			{
				MainForm mainForm = CommandFactory.GetCommandMain().GetMainForm();
				Subject class137_ = null;
				ReadOnlyCollection<Unit> readOnlyCollection = null;
				mainForm.method_254(class137_, ref readOnlyCollection, ref this.SelectedAvaibleAircrafts, false);
			}
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x00020F9C File Offset: 0x0001F19C
		private void method_53(object sender, EventArgs e)
		{
			this.method_21();
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		private void method_54(object sender, EventArgs e)
		{
			this.method_29();
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		private void method_55(object sender, EventArgs e)
		{
			this.method_24();
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x00021001 File Offset: 0x0001F201
		private void method_56(object sender, EventArgs e)
		{
			this.method_33();
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x00161D20 File Offset: 0x0015FF20
		private void method_57(object sender, EventArgs e)
		{
			this.method_22(false, true, true, false, false);
			if (this.SelectedAvaibleAircrafts.Count > 0)
			{
				MainForm mainForm = CommandFactory.GetCommandMain().GetMainForm();
				Subject class137_ = null;
				ReadOnlyCollection<Unit> readOnlyCollection = null;
				mainForm.method_254(class137_, ref readOnlyCollection, ref this.SelectedAvaibleAircrafts, false);
			}
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void TSMI_AssignToMission_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x00021011 File Offset: 0x0001F211
		private void method_59(object sender, EventArgs e)
		{
			this.method_40();
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x00021009 File Offset: 0x0001F209
		private void method_60(object sender, EventArgs e)
		{
			this.method_38();
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x00021019 File Offset: 0x0001F219
		private void method_61(object sender, EventArgs e)
		{
			this.method_42();
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x00161D6C File Offset: 0x0015FF6C
		private void OnUnitContextMenuOpening()
		{
			this.toolStripMenuItem_6.Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.toolStripMenuItem_7.Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.toolStripMenuItem_8.Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.toolStripSeparator_3.Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			if (this.SelectedAvaibleAircrafts.Count > 0)
			{
				this.toolStripMenuItem_2.Enabled = true;
				this.toolStripMenuItem_3.Enabled = true;
				this.toolStripMenuItem_4.Enabled = true;
				this.toolStripMenuItem_5.Enabled = true;
				this.toolStripMenuItem_0.Enabled = true;
				this.TSMI_AssignToMission.Enabled = true;
				if (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit)
				{
					this.toolStripMenuItem_6.Enabled = true;
					this.toolStripMenuItem_7.Enabled = true;
					this.toolStripMenuItem_8.Enabled = true;
				}
			}
			else
			{
				this.toolStripMenuItem_2.Enabled = false;
				this.toolStripMenuItem_3.Enabled = false;
				this.toolStripMenuItem_4.Enabled = false;
				this.toolStripMenuItem_5.Enabled = false;
				this.toolStripMenuItem_0.Enabled = false;
				this.TSMI_AssignToMission.Enabled = false;
				if (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit)
				{
					this.toolStripMenuItem_6.Enabled = false;
					this.toolStripMenuItem_7.Enabled = false;
					this.toolStripMenuItem_8.Enabled = false;
				}
			}
			this.SelectedAvaibleAircrafts.Clear();
			foreach (TreeGridViewRow current in this.treeGridView_0.Nodes)
			{
				foreach (TreeGridViewRow current2 in current.Nodes)
				{
					if (current2.Selected)
					{
						this.SelectedAvaibleAircrafts.Add((Aircraft)current2.Tag);
					}
				}
			}
			this.TSMI_AssignToMission.DropDownItems.Clear();
			if (this.SelectedAvaibleAircrafts.Count > 0)
			{
				new ToolStripMenuItem();
				((ToolStripMenuItem)this.TSMI_AssignToMission.DropDown.Items.Add("< Unassign >", null, new EventHandler(this.TSMI_AssignToMission_Click))).Tag = null;
				foreach (Mission current3 in Client.GetClientSide().GetMissionCollection())
				{
					ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
					ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
					toolStripMenuItem = (ToolStripMenuItem)this.TSMI_AssignToMission.DropDown.Items.Add(current3.Name, null, new EventHandler(this.TSMI_AssignToMission_Click));
					toolStripMenuItem.Tag = current3;
					if (current3.MissionClass == Mission._MissionClass.Strike)
					{
						toolStripMenuItem2 = (ToolStripMenuItem)this.TSMI_AssignToMission.DropDown.Items.Add(current3.Name + " - Escort", null, new EventHandler(this.TSMI_AssignToMission_Click));
						toolStripMenuItem2.Tag = current3;
					}
					if (this.SelectedAvaibleAircrafts.Count == 1)
					{
						ActiveUnit activeUnit = this.SelectedAvaibleAircrafts[0];
						if (current3 == activeUnit.GetAssignedMission(false))
						{
							if (current3.MissionClass == Mission._MissionClass.Strike && activeUnit.GetAI().IsEscort)
							{
								toolStripMenuItem2.Checked = true;
							}
							else
							{
								toolStripMenuItem.Checked = true;
							}
						}
					}
				}
			}
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x00021054 File Offset: 0x0001F254
		private void CMenu_Unit_Opening(object sender, CancelEventArgs e)
		{
			this.OnUnitContextMenuOpening();
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x00021045 File Offset: 0x0001F245
		private void TSMI_AssignToMission_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			this.DoAssignToMission(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void AirOps_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x00162160 File Offset: 0x00160360
		private void TSB_Cargo_Click(object sender, EventArgs e)
		{
			this.SelectedAvaibleAircrafts.Clear();
			foreach (TreeGridViewRow current in this.treeGridView_0.Nodes)
			{
				if (current.Selected)
				{
					foreach (Aircraft current2 in ((IEnumerable<Aircraft>)current.Tag))
					{
						if (current2.GetAircraftAirOps().method_66())
						{
							this.SelectedAvaibleAircrafts.Add(current2);
						}
					}
				}
				if (this.SelectedAvaibleAircrafts.Count > 0)
				{
					break;
				}
				foreach (TreeGridViewRow current3 in current.Nodes)
				{
					if (current3.Selected && ((Aircraft)current3.Tag).GetAircraftAirOps().method_66())
					{
						this.SelectedAvaibleAircrafts.Add((Aircraft)current3.Tag);
					}
				}
				if (this.SelectedAvaibleAircrafts.Count > 0)
				{
					break;
				}
			}
			if (this.SelectedAvaibleAircrafts.Count == 1)
			{
				CommandFactory.GetCommandMain().GetCargoOps().activeUnit_0 = null;
				CommandFactory.GetCommandMain().GetCargoOps().activeUnit_1 = this.SelectedAvaibleAircrafts[0];
				CommandFactory.GetCommandMain().GetCargoOps().Show();
			}
		}

		// Token: 0x04001D7B RID: 7547
		public static Func<Aircraft, int> AircraftFunc0 = (Aircraft aircraft_0) => aircraft_0.DBID;

		// Token: 0x04001D7C RID: 7548
		public static Func<Aircraft, Aircraft> AircraftFunc1 = (Aircraft aircraft_0) => aircraft_0;

		// Token: 0x04001D7D RID: 7549
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc2 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04001D7E RID: 7550
		public static Func<ActiveUnit, string> ActiveUnitFunc3 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x04001D7F RID: 7551
		public static Func<AirFacility, AirFacility> AirFacilityFunc4 = (AirFacility airFacility_0) => airFacility_0;

		// Token: 0x04001D80 RID: 7552
		public static Func<AirFacility, string> AirFacilityFunc5 = (AirFacility airFacility_0) => airFacility_0.Name;

		// Token: 0x04001D81 RID: 7553
		public static Func<Aircraft, Aircraft> AircraftFunc6 = (Aircraft aircraft_0) => aircraft_0;

		// Token: 0x04001D82 RID: 7554
		public static Func<Aircraft, string> AircraftFunc7 = (Aircraft aircraft_0) => aircraft_0.Name;

		// Token: 0x04001D84 RID: 7556
		[CompilerGenerated]
		private TabControl tabControl_0;

		// Token: 0x04001D85 RID: 7557
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x04001D86 RID: 7558
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x04001D87 RID: 7559
		[CompilerGenerated]
		private System.Windows.Forms.Timer timer_0;

		// Token: 0x04001D88 RID: 7560
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn TGVTBC_Facilities;

		// Token: 0x04001D89 RID: 7561
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn TGVTBC_Status;

		// Token: 0x04001D8A RID: 7562
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x04001D8B RID: 7563
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04001D8C RID: 7564
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04001D8D RID: 7565
		[CompilerGenerated]
		private ToolStripButton toolStripButton_2;

		// Token: 0x04001D8E RID: 7566
		[CompilerGenerated]
		private TreeView treeView_0;

		// Token: 0x04001D8F RID: 7567
		[CompilerGenerated]
		private System.Windows.Forms.Timer timer_1;

		// Token: 0x04001D90 RID: 7568
		[CompilerGenerated]
		private TreeGridView treeGridView_0;

		// Token: 0x04001D91 RID: 7569
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x04001D92 RID: 7570
		[CompilerGenerated]
		private ToolStripButton toolStripButton_3;

		// Token: 0x04001D93 RID: 7571
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001D94 RID: 7572
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001D95 RID: 7573
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04001D96 RID: 7574
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04001D97 RID: 7575
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04001D98 RID: 7576
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04001D99 RID: 7577
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x04001D9A RID: 7578
		[CompilerGenerated]
		private ToolStripButton toolStripButton_4;

		// Token: 0x04001D9B RID: 7579
		[CompilerGenerated]
		private ToolStripButton toolStripButton_5;

		// Token: 0x04001D9C RID: 7580
		[CompilerGenerated]
		private ToolStripButton toolStripButton_6;

		// Token: 0x04001D9D RID: 7581
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x04001D9E RID: 7582
		[CompilerGenerated]
		private Label label_7;

		// Token: 0x04001D9F RID: 7583
		[CompilerGenerated]
		private Label label_8;

		// Token: 0x04001DA0 RID: 7584
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04001DA1 RID: 7585
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04001DA2 RID: 7586
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_1;

		// Token: 0x04001DA3 RID: 7587
		[CompilerGenerated]
		private ContextMenuStrip CMenu_Unit;

		// Token: 0x04001DA4 RID: 7588
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04001DA5 RID: 7589
		[CompilerGenerated]
		private ToolStripMenuItem TSMI_AssignToMission;

		// Token: 0x04001DA6 RID: 7590
		[CompilerGenerated]
		private ToolStripDropDownButton TSB_AssignToMission;

		// Token: 0x04001DA7 RID: 7591
		[CompilerGenerated]
		private ToolStripButton toolStripButton_7;

		// Token: 0x04001DA8 RID: 7592
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x04001DA9 RID: 7593
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x04001DAA RID: 7594
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x04001DAB RID: 7595
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_5;

		// Token: 0x04001DAC RID: 7596
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_2;

		// Token: 0x04001DAD RID: 7597
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_3;

		// Token: 0x04001DAE RID: 7598
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_6;

		// Token: 0x04001DAF RID: 7599
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_7;

		// Token: 0x04001DB0 RID: 7600
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_8;

		// Token: 0x04001DB1 RID: 7601
		[CompilerGenerated]
		private Label label_9;

		// Token: 0x04001DB2 RID: 7602
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn Aircraft_TreeGridViewTextBoxColumn;

		// Token: 0x04001DB3 RID: 7603
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04001DB4 RID: 7604
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04001DB5 RID: 7605
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04001DB6 RID: 7606
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04001DB7 RID: 7607
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04001DB8 RID: 7608
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x04001DB9 RID: 7609
		[CompilerGenerated]
		private DataGridViewLinkColumn dataGridViewLinkColumn_0;

		// Token: 0x04001DBA RID: 7610
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x04001DBB RID: 7611
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		// Token: 0x04001DBC RID: 7612
		[CompilerGenerated]
		private ToolStripButton TSB_Cargo;

		// Token: 0x04001DBD RID: 7613
		public HashSet<ActiveUnit> HostUnitSet;

		// Token: 0x04001DBE RID: 7614
		private Collection<ActiveUnit> SelectedAvaibleAircrafts;

		// Token: 0x04001DBF RID: 7615
		private ActiveUnit activeUnit_0;

		// Token: 0x04001DC0 RID: 7616
		private Collection<Aircraft> collection_1;

		// Token: 0x04001DC1 RID: 7617
		private Collection<Aircraft> collection_2;

		// Token: 0x04001DC2 RID: 7618
		private Class2472 class2472_0;

		// Token: 0x04001DC3 RID: 7619
		private bool bool_0;

		// Token: 0x04001DC4 RID: 7620
		private Collection<int> collection_3;

		// Token: 0x04001DC5 RID: 7621
		private DataTable dataTable_0;

		// Token: 0x04001DC6 RID: 7622
		private DataTable dataTable_1;

		// Token: 0x04001DC7 RID: 7623
		private int int_0;

		// Token: 0x04001DC8 RID: 7624
		private bool bool_1;

		// Token: 0x04001DC9 RID: 7625
		private int int_1;

		// Token: 0x04001DCA RID: 7626
		private int int_2 = 0;

		// Token: 0x04001DCB RID: 7627
		private int int_3 = 0;

		// Token: 0x04001DCC RID: 7628
		private int int_4;

		// Token: 0x04001DCD RID: 7629
		private bool bool_2 = false;

		// Token: 0x04001DCE RID: 7630
		private Dictionary<int, int> dictionary_0;

		// Token: 0x04001DCF RID: 7631
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x020009A4 RID: 2468
		[CompilerGenerated]
		public sealed class Class2508
		{
			// Token: 0x060040EF RID: 16623 RVA: 0x0002105C File Offset: 0x0001F25C
			public Class2508(AirOps.Class2508 class2508_0)
			{
				if (class2508_0 != null)
				{
					this.aircraft_0 = class2508_0.aircraft_0;
				}
			}

			// Token: 0x060040F0 RID: 16624 RVA: 0x00021076 File Offset: 0x0001F276
			internal bool method_0(TreeGridViewRow class2384_0)
			{
				return class2384_0.Tag == this.aircraft_0;
			}

			// Token: 0x04001DD8 RID: 7640
			public Aircraft aircraft_0;
		}

		// Token: 0x020009A5 RID: 2469
		[CompilerGenerated]
		public sealed class Class2509
		{
			// Token: 0x060040F1 RID: 16625 RVA: 0x00021086 File Offset: 0x0001F286
			public Class2509(AirOps.Class2509 class2509_0)
			{
				if (class2509_0 != null)
				{
					this.int_0 = class2509_0.int_0;
				}
			}

			// Token: 0x060040F2 RID: 16626 RVA: 0x000210A0 File Offset: 0x0001F2A0
			internal bool method_0(Aircraft aircraft_0)
			{
				return aircraft_0.DBID == this.int_0;
			}

			// Token: 0x04001DD9 RID: 7641
			public int int_0;
		}
	}
}

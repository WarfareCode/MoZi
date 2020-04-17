using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using AdvancedDataGridView;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns29;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x020009C1 RID: 2497
	[DesignerGenerated]
	public sealed partial class DockingOps : CommandForm
	{
		// Token: 0x060042E0 RID: 17120 RVA: 0x00186818 File Offset: 0x00184A18
		public DockingOps()
		{
			base.FormClosing += new FormClosingEventHandler(this.DockingOps_FormClosing);
			base.Load += new EventHandler(this.DockingOps_Load);
			base.KeyDown += new KeyEventHandler(this.DockingOps_KeyDown);
			base.FormClosed += new FormClosedEventHandler(this.DockingOps_FormClosed);
			this.HostUnits = new Collection<ActiveUnit>();
			this.collection_1 = new Collection<ActiveUnit>();
			this.collection_2 = new Collection<ActiveUnit>();
			this.collection_3 = new Collection<ActiveUnit>();
			this.class2472_0 = new Class2472();
			this.hashSet_0 = new HashSet<TreeGridViewRow>();
			this.vmethod_77(new BackgroundWorker());
			this.InitializeComponent();
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x00187BAC File Offset: 0x00185DAC
		[CompilerGenerated]
		internal  TabControl vmethod_0()
		{
			return this.tabControl_0;
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x00187BC4 File Offset: 0x00185DC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TabControl tabControl_1)
		{
			EventHandler value = new EventHandler(this.method_15);
			TabControl tabControl = this.tabControl_0;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged -= value;
			}
			this.tabControl_0 = tabControl_1;
			tabControl = this.tabControl_0;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged += value;
			}
		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x00187C10 File Offset: 0x00185E10
		[CompilerGenerated]
		internal  TabPage vmethod_2()
		{
			return this.tabPage_0;
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x0002198F File Offset: 0x0001FB8F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TabPage tabPage_2)
		{
			this.tabPage_0 = tabPage_2;
		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x00187C28 File Offset: 0x00185E28
		[CompilerGenerated]
		internal  ToolStrip vmethod_4()
		{
			return this.toolStrip_0;
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x00021998 File Offset: 0x0001FB98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x00187C40 File Offset: 0x00185E40
		[CompilerGenerated]
		internal  ToolStripButton GetTSB_LaunchIndividually()
		{
			return this.TSB_LaunchIndividually;
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x00187C58 File Offset: 0x00185E58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetTSB_LaunchIndividually(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.TSB_LaunchIndividually_Click);
			ToolStripButton tSB_LaunchIndividually = this.TSB_LaunchIndividually;
			if (tSB_LaunchIndividually != null)
			{
				tSB_LaunchIndividually.Click -= value;
			}
			this.TSB_LaunchIndividually = toolStripButton_8;
			tSB_LaunchIndividually = this.TSB_LaunchIndividually;
			if (tSB_LaunchIndividually != null)
			{
				tSB_LaunchIndividually.Click += value;
			}
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x00187CA4 File Offset: 0x00185EA4
		[CompilerGenerated]
		internal  ToolStripButton GetTSB_LaunchAsGroup()
		{
			return this.TSB_LaunchAsGroup;
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x00187CBC File Offset: 0x00185EBC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetTSB_LaunchAsGroup(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.TSB_LaunchAsGroup_Click);
			ToolStripButton tSB_LaunchAsGroup = this.TSB_LaunchAsGroup;
			if (tSB_LaunchAsGroup != null)
			{
				tSB_LaunchAsGroup.Click -= value;
			}
			this.TSB_LaunchAsGroup = toolStripButton_8;
			tSB_LaunchAsGroup = this.TSB_LaunchAsGroup;
			if (tSB_LaunchAsGroup != null)
			{
				tSB_LaunchAsGroup.Click += value;
			}
		}

		// Token: 0x060042ED RID: 17133 RVA: 0x00187D08 File Offset: 0x00185F08
		[CompilerGenerated]
		internal  SplitContainer vmethod_10()
		{
			return this.splitContainer_0;
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x000219A1 File Offset: 0x0001FBA1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(SplitContainer splitContainer_1)
		{
			this.splitContainer_0 = splitContainer_1;
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x00187D20 File Offset: 0x00185F20
		[CompilerGenerated]
		internal  TreeGridView vmethod_12()
		{
			return this.treeGridView_0;
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x00187D38 File Offset: 0x00185F38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(TreeGridView treeGridView_1)
		{
			Delegate43 delegate43_ = new Delegate43(this.method_19);
			Delegate41 delegate41_ = new Delegate41(this.method_20);
			EventHandler value = new EventHandler(this.method_25);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_44);
			TreeGridView treeGridView = this.treeGridView_0;
			if (treeGridView != null)
			{
				treeGridView.method_13(delegate43_);
				treeGridView.method_11(delegate41_);
				treeGridView.SelectionChanged -= value;
				treeGridView.CellContentClick -= value2;
			}
			this.treeGridView_0 = treeGridView_1;
			treeGridView = this.treeGridView_0;
			if (treeGridView != null)
			{
				treeGridView.method_12(delegate43_);
				treeGridView.method_10(delegate41_);
				treeGridView.SelectionChanged += value;
				treeGridView.CellContentClick += value2;
			}
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x00187DE0 File Offset: 0x00185FE0
		[CompilerGenerated]
		internal  TabPage vmethod_14()
		{
			return this.tabPage_1;
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x000219AA File Offset: 0x0001FBAA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(TabPage tabPage_2)
		{
			this.tabPage_1 = tabPage_2;
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x00187DF8 File Offset: 0x00185FF8
		[CompilerGenerated]
		internal  TreeView vmethod_16()
		{
			return this.treeView_0;
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x000219B3 File Offset: 0x0001FBB3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(TreeView treeView_1)
		{
			this.treeView_0 = treeView_1;
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x00187E10 File Offset: 0x00186010
		[CompilerGenerated]
		internal  System.Windows.Forms.Timer vmethod_18()
		{
			return this.timer_0;
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x00187E28 File Offset: 0x00186028
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(System.Windows.Forms.Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_6);
			System.Windows.Forms.Timer timer = this.timer_0;
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

		// Token: 0x060042F7 RID: 17143 RVA: 0x00187E74 File Offset: 0x00186074
		[CompilerGenerated]
		internal  ToolStripButton GetTSB_AbortLaunch()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x00187E8C File Offset: 0x0018608C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_28);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_8;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x00187ED8 File Offset: 0x001860D8
		[CompilerGenerated]
		internal  ToolStripSeparator vmethod_22()
		{
			return this.toolStripSeparator_0;
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x000219BC File Offset: 0x0001FBBC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(ToolStripSeparator toolStripSeparator_4)
		{
			this.toolStripSeparator_0 = toolStripSeparator_4;
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x00187EF0 File Offset: 0x001860F0
		[CompilerGenerated]
		internal  ToolStripButton GetTSB_Doctrine()
		{
			return this.toolStripButton_3;
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x00187F08 File Offset: 0x00186108
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_31);
			ToolStripButton toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_3 = toolStripButton_8;
			toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x00187F54 File Offset: 0x00186154
		[CompilerGenerated]
		internal  ToolStripDropDownButton GetTSB_AssignToMission()
		{
			return this.toolStripDropDownButton_0;
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x00187F6C File Offset: 0x0018616C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(ToolStripDropDownButton toolStripDropDownButton_1)
		{
			EventHandler value = new EventHandler(this.method_32);
			EventHandler value2 = new EventHandler(this.method_33);
			ToolStripItemClickedEventHandler value3 = new ToolStripItemClickedEventHandler(this.method_34);
			ToolStripDropDownButton toolStripDropDownButton = this.toolStripDropDownButton_0;
			if (toolStripDropDownButton != null)
			{
				toolStripDropDownButton.Click -= value;
				toolStripDropDownButton.DropDownOpening -= value2;
				toolStripDropDownButton.DropDownItemClicked -= value3;
			}
			this.toolStripDropDownButton_0 = toolStripDropDownButton_1;
			toolStripDropDownButton = this.toolStripDropDownButton_0;
			if (toolStripDropDownButton != null)
			{
				toolStripDropDownButton.Click += value;
				toolStripDropDownButton.DropDownOpening += value2;
				toolStripDropDownButton.DropDownItemClicked += value3;
			}
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x00187FEC File Offset: 0x001861EC
		[CompilerGenerated]
		internal  ContextMenuStrip vmethod_28()
		{
			return this.contextMenuStrip_0;
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x00188004 File Offset: 0x00186204
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(ContextMenuStrip contextMenuStrip_1)
		{
			CancelEventHandler value = new CancelEventHandler(this.method_42);
			ContextMenuStrip contextMenuStrip = this.contextMenuStrip_0;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.Opening -= value;
			}
			this.contextMenuStrip_0 = contextMenuStrip_1;
			contextMenuStrip = this.contextMenuStrip_0;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.Opening += value;
			}
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x00188050 File Offset: 0x00186250
		[CompilerGenerated]
		internal ToolStripMenuItem vmethod_30()
		{
			return this.toolStripMenuItem_0;
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x00188068 File Offset: 0x00186268
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(ToolStripMenuItem toolStripMenuItem_8)
		{
			EventHandler value = new EventHandler(this.method_36);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_0;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_0 = toolStripMenuItem_8;
			toolStripMenuItem = this.toolStripMenuItem_0;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x001880B4 File Offset: 0x001862B4
		[CompilerGenerated]
		internal ToolStripMenuItem vmethod_32()
		{
			return this.toolStripMenuItem_1;
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x001880CC File Offset: 0x001862CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(ToolStripMenuItem toolStripMenuItem_8)
		{
			EventHandler value = new EventHandler(this.method_37);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_1 = toolStripMenuItem_8;
			toolStripMenuItem = this.toolStripMenuItem_1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x00188118 File Offset: 0x00186318
		[CompilerGenerated]
		internal ToolStripMenuItem vmethod_34()
		{
			return this.toolStripMenuItem_2;
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x00188130 File Offset: 0x00186330
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(ToolStripMenuItem toolStripMenuItem_8)
		{
			EventHandler value = new EventHandler(this.method_38);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_2;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_2 = toolStripMenuItem_8;
			toolStripMenuItem = this.toolStripMenuItem_2;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x0018817C File Offset: 0x0018637C
		[CompilerGenerated]
		internal  ToolStripSeparator vmethod_36()
		{
			return this.toolStripSeparator_1;
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x000219C5 File Offset: 0x0001FBC5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(ToolStripSeparator toolStripSeparator_4)
		{
			this.toolStripSeparator_1 = toolStripSeparator_4;
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x00188194 File Offset: 0x00186394
		[CompilerGenerated]
		internal ToolStripMenuItem vmethod_38()
		{
			return this.toolStripMenuItem_3;
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x001881AC File Offset: 0x001863AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(ToolStripMenuItem toolStripMenuItem_8)
		{
			EventHandler value = new EventHandler(this.method_39);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_3;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_3 = toolStripMenuItem_8;
			toolStripMenuItem = this.toolStripMenuItem_3;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x001881F8 File Offset: 0x001863F8
		[CompilerGenerated]
		internal ToolStripMenuItem vmethod_40()
		{
			return this.toolStripMenuItem_4;
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x00188210 File Offset: 0x00186410
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(ToolStripMenuItem toolStripMenuItem_8)
		{
			EventHandler value = new EventHandler(this.method_40);
			ToolStripItemClickedEventHandler value2 = new ToolStripItemClickedEventHandler(this.method_43);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_4;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
				toolStripMenuItem.DropDownItemClicked -= value2;
			}
			this.toolStripMenuItem_4 = toolStripMenuItem_8;
			toolStripMenuItem = this.toolStripMenuItem_4;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
				toolStripMenuItem.DropDownItemClicked += value2;
			}
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x00188274 File Offset: 0x00186474
		[CompilerGenerated]
		internal  ToolStripSeparator vmethod_42()
		{
			return this.toolStripSeparator_2;
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x000219CE File Offset: 0x0001FBCE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(ToolStripSeparator toolStripSeparator_4)
		{
			this.toolStripSeparator_2 = toolStripSeparator_4;
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x0018828C File Offset: 0x0018648C
		[CompilerGenerated]
		internal  ToolStripButton GetTSB_SetReadyTime()
		{
			return this.toolStripButton_4;
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x001882A4 File Offset: 0x001864A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_45);
			ToolStripButton toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_4 = toolStripButton_8;
			toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x001882F0 File Offset: 0x001864F0
		[CompilerGenerated]
		internal  ToolStripButton GetTSB_Rename()
		{
			return this.toolStripButton_5;
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x00188308 File Offset: 0x00186508
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_47);
			ToolStripButton toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_5 = toolStripButton_8;
			toolStripButton = this.toolStripButton_5;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x00188354 File Offset: 0x00186554
		[CompilerGenerated]
		internal  ToolStripButton GetTSB_Delete()
		{
			return this.toolStripButton_6;
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x0018836C File Offset: 0x0018656C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_49);
			ToolStripButton toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_6 = toolStripButton_8;
			toolStripButton = this.toolStripButton_6;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x001883B8 File Offset: 0x001865B8
		[CompilerGenerated]
		internal  ToolStripSeparator vmethod_50()
		{
			return this.toolStripSeparator_3;
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x000219D7 File Offset: 0x0001FBD7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(ToolStripSeparator toolStripSeparator_4)
		{
			this.toolStripSeparator_3 = toolStripSeparator_4;
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x001883D0 File Offset: 0x001865D0
		[CompilerGenerated]
		internal ToolStripMenuItem vmethod_52()
		{
			return this.toolStripMenuItem_5;
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x001883E8 File Offset: 0x001865E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(ToolStripMenuItem toolStripMenuItem_8)
		{
			EventHandler value = new EventHandler(this.method_51);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_5;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_5 = toolStripMenuItem_8;
			toolStripMenuItem = this.toolStripMenuItem_5;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x00188434 File Offset: 0x00186634
		[CompilerGenerated]
		internal ToolStripMenuItem vmethod_54()
		{
			return this.toolStripMenuItem_6;
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x0018844C File Offset: 0x0018664C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(ToolStripMenuItem toolStripMenuItem_8)
		{
			EventHandler value = new EventHandler(this.method_52);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_6;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_6 = toolStripMenuItem_8;
			toolStripMenuItem = this.toolStripMenuItem_6;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x00188498 File Offset: 0x00186698
		[CompilerGenerated]
		internal ToolStripMenuItem vmethod_56()
		{
			return this.toolStripMenuItem_7;
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x001884B0 File Offset: 0x001866B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(ToolStripMenuItem toolStripMenuItem_8)
		{
			EventHandler value = new EventHandler(this.method_53);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_7;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_7 = toolStripMenuItem_8;
			toolStripMenuItem = this.toolStripMenuItem_7;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x001884FC File Offset: 0x001866FC
		[CompilerGenerated]
		internal  ToolStripButton GetTSB_Cargo()
		{
			return this.toolStripButton_7;
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x00188514 File Offset: 0x00186714
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(ToolStripButton toolStripButton_8)
		{
			EventHandler value = new EventHandler(this.method_54);
			ToolStripButton toolStripButton = this.toolStripButton_7;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_7 = toolStripButton_8;
			toolStripButton = this.toolStripButton_7;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x00188560 File Offset: 0x00186760
		[CompilerGenerated]
		internal  TreeGridViewTextBoxColumn vmethod_60()
		{
			return this.class2383_0;
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x000219E0 File Offset: 0x0001FBE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(TreeGridViewTextBoxColumn class2383_1)
		{
			this.class2383_0 = class2383_1;
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x00188578 File Offset: 0x00186778
		[CompilerGenerated]
		internal  DataGridViewLinkColumn vmethod_62()
		{
			return this.dataGridViewLinkColumn_0;
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x000219E9 File Offset: 0x0001FBE9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(DataGridViewLinkColumn dataGridViewLinkColumn_3)
		{
			this.dataGridViewLinkColumn_0 = dataGridViewLinkColumn_3;
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x00188590 File Offset: 0x00186790
		[CompilerGenerated]
		internal  DataGridViewLinkColumn vmethod_64()
		{
			return this.dataGridViewLinkColumn_1;
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x000219F2 File Offset: 0x0001FBF2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(DataGridViewLinkColumn dataGridViewLinkColumn_3)
		{
			this.dataGridViewLinkColumn_1 = dataGridViewLinkColumn_3;
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x001885A8 File Offset: 0x001867A8
		[CompilerGenerated]
		internal  DataGridViewLinkColumn vmethod_66()
		{
			return this.dataGridViewLinkColumn_2;
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x000219FB File Offset: 0x0001FBFB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(DataGridViewLinkColumn dataGridViewLinkColumn_3)
		{
			this.dataGridViewLinkColumn_2 = dataGridViewLinkColumn_3;
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x001885C0 File Offset: 0x001867C0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_68()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x00021A04 File Offset: 0x0001FC04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x001885D8 File Offset: 0x001867D8
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_70()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x00021A0D File Offset: 0x0001FC0D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x001885F0 File Offset: 0x001867F0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_72()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x00021A16 File Offset: 0x0001FC16
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x00188608 File Offset: 0x00186808
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_74()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x00021A1F File Offset: 0x0001FC1F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_4;
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x00188620 File Offset: 0x00186820
		[CompilerGenerated]
		internal  BackgroundWorker vmethod_76()
		{
			return this.backgroundWorker_0;
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x00188638 File Offset: 0x00186838
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(BackgroundWorker backgroundWorker_1)
		{
			DoWorkEventHandler value = new DoWorkEventHandler(this.method_26);
			RunWorkerCompletedEventHandler value2 = new RunWorkerCompletedEventHandler(this.method_27);
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

		// Token: 0x06004331 RID: 17201 RVA: 0x00021A28 File Offset: 0x0001FC28
		private void DockingOps_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.bool_0)
			{
				Client.GetConfiguration().SetSimRunMode();
			}
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
			this.vmethod_18().Stop();
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x0018869C File Offset: 0x0018689C
		private void DockingOps_Load(object sender, EventArgs e)
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
			if (this.HostUnits.Count > 1)
			{
				this.Text = "停靠行动 - 多个宿主单元";
			}
			else
			{
				this.Text = "停靠行动- " + this.HostUnits[0].Name;
			}
			this.method_3();
			this.method_11();
			this.GetTSB_SetReadyTime().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.GetTSB_Rename().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.GetTSB_Delete().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.GetTSB_Cargo().Visible = Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps);
			this.vmethod_18().Start();
			ActiveUnit_DockingOps.smethod_2(new ActiveUnit_DockingOps.Delegate3(this.method_4));
			ActiveUnit_DockingOps.smethod_0(new ActiveUnit_DockingOps.Delegate2(this.method_1));
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x001887C8 File Offset: 0x001869C8
		private void method_1(ActiveUnit activeUnit_)
		{
			using (IEnumerator<ActiveUnit> enumerator = this.HostUnits.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetDockingOps().GetDockedUnits().Contains(activeUnit_))
					{
						this.collection_2.Add(activeUnit_);
					}
				}
			}
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x00021A59 File Offset: 0x0001FC59
		public void method_2()
		{
			this.method_7();
			this.method_12();
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x00021A67 File Offset: 0x0001FC67
		private void method_3()
		{
			this.vmethod_76().RunWorkerAsync();
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x00021A74 File Offset: 0x0001FC74
		private void method_4(ActiveUnit activeUnit_0)
		{
			this.collection_3.Add(activeUnit_0);
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x00021A82 File Offset: 0x0001FC82
		public void method_5()
		{
			this.method_7();
			this.method_12();
			this.collection_2.Clear();
			this.collection_3.Clear();
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x00021AA6 File Offset: 0x0001FCA6
		private void method_6(object sender, EventArgs e)
		{
			if (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Run)
			{
				this.method_5();
			}
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x00188834 File Offset: 0x00186A34
		private void method_7()
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			string text7 = "";
            TreeGridViewRow currentX;

            foreach (TreeGridViewRow current in this.method_8())
			{
				if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(current.Tag)) && (current.Tag.GetType() == typeof(Ship) | current.Tag.GetType() == typeof(Submarine)))
				{
					ActiveUnit activeUnit = (ActiveUnit)current.Tag;
					this.method_22(activeUnit, ref text, ref text2, ref text3, ref text4, ref text5, ref text6, ref text7);
					current.SetValues(new object[]
					{
						activeUnit.Name,
						text,
						text2,
						text3,
						text4,
						text5,
						text6,
						text7
					});
                    currentX = current;

                    this.method_21(ref currentX, activeUnit);
				}
			}
			using (IEnumerator<ActiveUnit> enumerator2 = this.collection_3.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					DockingOps.Class2511 @class = new DockingOps.Class2511(null);
					@class.activeUnit_0 = enumerator2.Current;
					IEnumerable<TreeGridViewRow> source = this.method_8().Where(new Func<TreeGridViewRow, bool>(@class.method_0));
					if (source.Count<TreeGridViewRow>() > 0)
					{
						source.ElementAtOrDefault(0).method_7().Nodes.Remove(source.ElementAtOrDefault(0));
					}
				}
			}
			foreach (ActiveUnit current2 in this.collection_2)
			{
				bool flag = false;
                TreeGridViewRow current3X;

                foreach (TreeGridViewRow current3 in this.vmethod_12().Nodes)
				{
					if (current3.GetType() == typeof(List<ActiveUnit>))
					{
						this.method_22(current2, ref text, ref text2, ref text3, ref text4, ref text5, ref text6, ref text7);
						current3.Nodes.method_1(new object[]
						{
							current2.Name,
							text,
							text2,
							text3,
							text4,
							text5,
							text6,
							text7
						}).Tag = current2;
                        current3X = current3;

                        this.method_21(ref current3X, current2);
						flag = true;
					}
				}
				if (!flag)
				{
					TreeGridViewRow treeGridViewRow = this.vmethod_12().Nodes.method_0("1x " + Misc.smethod_11(current2.UnitClass));
					treeGridViewRow.Tag = current2.DBID;
					this.method_22(current2, ref text, ref text2, ref text3, ref text4, ref text5, ref text6, ref text7);
					TreeGridViewRow treeGridViewRow2 = treeGridViewRow.Nodes.method_1(new object[]
					{
						current2.Name,
						text,
						text2,
						text3,
						text4,
						text5,
						text6,
						text7
					});
					treeGridViewRow2.Tag = current2;
					this.method_21(ref treeGridViewRow2, current2);
				}
			}
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x00188C14 File Offset: 0x00186E14
		private ReadOnlyCollection<TreeGridViewRow> method_8()
		{
			List<TreeGridViewRow> list = new List<TreeGridViewRow>();
			foreach (TreeGridViewRow current in this.vmethod_12().Nodes)
			{
				if (!list.Contains(current))
				{
					list.Add(current);
				}
				this.method_9(current, list);
			}
			return list.AsReadOnly();
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x00188C8C File Offset: 0x00186E8C
		private void method_9(TreeGridViewRow class2384_0, List<TreeGridViewRow> list_0)
		{
			foreach (TreeGridViewRow current in class2384_0.Nodes)
			{
				if (!list_0.Contains(current))
				{
					list_0.Add(current);
				}
				this.method_9(current, list_0);
			}
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x00188CF0 File Offset: 0x00186EF0
		private void method_10()
		{
			this.vmethod_12().Nodes.Clear();
			foreach (ActiveUnit current in this.HostUnits)
			{
				IEnumerable<int> enumerable = current.GetDockingOps().GetDockedUnits().Where(DockingOps.ActiveUnitFunc0).Select(DockingOps.ActiveUnitFunc1).Distinct<int>();
				IEnumerable<int> enumerable2 = current.GetDockingOps().GetDockedUnits().Where(DockingOps.ActiveUnitFunc2).Select(DockingOps.ActiveUnitFunc3).Distinct<int>();
				foreach (int current2 in enumerable)
				{
					DockingOps.Class2512 @class = new DockingOps.Class2512(null);
					@class.int_0 = current2;
					IEnumerable<ActiveUnit> enumerable3 = current.GetDockingOps().GetDockedUnits().Where(new Func<ActiveUnit, bool>(@class.method_0)).Select(DockingOps.ActiveUnitFunc4);
					string text = Conversions.ToString(enumerable3.Count<ActiveUnit>()) + "x " + Misc.smethod_11(enumerable3.ElementAtOrDefault(0).UnitClass);
					if (this.HostUnits.Count > 1)
					{
						text = text + " (" + current.Name + ")";
					}
					TreeGridViewRow treeGridViewRow = this.vmethod_12().Nodes.method_0(text);
					treeGridViewRow.Tag = enumerable3;
					treeGridViewRow.Nodes.method_0("Temp");
				}
				foreach (int current3 in enumerable2)
				{
					DockingOps.Class2513 class2 = new DockingOps.Class2513(null);
					class2.int_0 = current3;
					IEnumerable<ActiveUnit> enumerable4 = current.GetDockingOps().GetDockedUnits().Where(new Func<ActiveUnit, bool>(class2.method_0)).Select(DockingOps.ActiveUnitFunc5);
					string text = Conversions.ToString(enumerable4.Count<ActiveUnit>()) + "x " + Misc.smethod_11(enumerable4.ElementAtOrDefault(0).UnitClass);
					if (this.HostUnits.Count > 1)
					{
						text = text + " (" + current.Name + ")";
					}
					TreeGridViewRow treeGridViewRow2 = this.vmethod_12().Nodes.method_0(text);
					treeGridViewRow2.Tag = enumerable4;
					treeGridViewRow2.Nodes.method_0("Temp");
				}
				using (IEnumerator<TreeGridViewRow> enumerator4 = this.vmethod_12().Nodes.GetEnumerator())
				{
					while (enumerator4.MoveNext())
					{
						enumerator4.Current.vmethod_4();
					}
				}
			}
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x00189010 File Offset: 0x00187210
		private void method_11()
		{
			this.vmethod_16().Nodes.Clear();
			foreach (Unit current in this.HostUnits)
			{
				TreeNode treeNode;
				if (current.IsGroup)
				{
					IEnumerable<ActiveUnit> enumerable = ((Group)current).GetUnitsInGroup().Values.Select(DockingOps.ActiveUnitFunc6).OrderBy(DockingOps.ActiveUnitFunc7);
					using (IEnumerator<ActiveUnit> enumerator2 = enumerable.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							ActiveUnit current2 = enumerator2.Current;
							if (current2.GetDockFacilities().Length > 0)
							{
								treeNode = this.vmethod_16().Nodes.Add(current2.Name);
								treeNode.Tag = current2;
								this.method_13(current2, treeNode);
							}
						}
						goto IL_F0;
					}
					goto IL_C2;
				}
				goto IL_C2;
				IL_F0:
				this.vmethod_16().ExpandAll();
				continue;
				IL_C2:
				treeNode = this.vmethod_16().Nodes.Add(current.Name);
				treeNode.Tag = current;
				this.method_13((ActiveUnit)current, treeNode);
				goto IL_F0;
			}
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x00189150 File Offset: 0x00187350
		private void method_12()
		{
			this.vmethod_16().SuspendLayout();
			IEnumerator enumerator = this.vmethod_16().Nodes.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator.Current;
					ActiveUnit activeUnit_ = (ActiveUnit)treeNode.Tag;
					this.method_13(activeUnit_, treeNode);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.vmethod_16().ResumeLayout();
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x001891DC File Offset: 0x001873DC
		private void method_13(ActiveUnit activeUnit_0, TreeNode treeNode_0)
		{
			IEnumerable<DockFacility> enumerable = activeUnit_0.GetDockFacilities().Select(DockingOps.DockFacilityFunc8).OrderBy(DockingOps.DockFacilityFunc9);
			foreach (DockFacility current in enumerable)
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
							this.method_14(current, treeNode);
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
					foreach (ActiveUnit current2 in current.LazyDockedUnitsDictionary.Value.Values)
					{
						treeNode2.Nodes.Add(string.Concat(new string[]
						{
							current2.Name,
							"(",
							Misc.smethod_11(current2.UnitClass),
							"): ",
							current2.GetDockingOps().GetDockingOpsConditionName(),
							" (",
							Misc.GetTimeString((long)Math.Round(current2.GetDockingOps().CT), Aircraft_AirOps._Maintenance.const_0, false, false),
							")"
						})).Tag = current2;
					}
				}
			}
			Collection<TreeNode> collection = new Collection<TreeNode>();
			IEnumerator enumerator4 = treeNode_0.Nodes.GetEnumerator();
			try
			{
				while (enumerator4.MoveNext())
				{
					TreeNode treeNode3 = (TreeNode)enumerator4.Current;
					if (!activeUnit_0.GetDockFacilities().Contains((DockFacility)treeNode3.Tag))
					{
						collection.Add(treeNode3);
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

		// Token: 0x06004340 RID: 17216 RVA: 0x001894B8 File Offset: 0x001876B8
		private void method_14(DockFacility dockFacility_0, TreeNode treeNode_0)
		{
			foreach (ActiveUnit current in dockFacility_0.LazyDockedUnitsDictionary.Value.Values)
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
								current.GetDockingOps().GetDockingOpsConditionName(),
								" (",
								Misc.GetTimeString((long)Math.Round(current.GetDockingOps().CT), Aircraft_AirOps._Maintenance.const_0, false, false),
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
					treeNode_0.Nodes.Add(string.Concat(new string[]
					{
						current.Name,
						"(",
						Misc.smethod_11(current.UnitClass),
						"): ",
						current.GetDockingOps().GetDockingOpsConditionName(),
						" (",
						Misc.GetTimeString((long)Math.Round(current.GetDockingOps().CT), Aircraft_AirOps._Maintenance.const_0, false, false),
						")"
					})).Tag = current;
				}
			}
			Collection<TreeNode> collection = new Collection<TreeNode>();
			IEnumerator enumerator3 = treeNode_0.Nodes.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					TreeNode treeNode2 = (TreeNode)enumerator3.Current;
					if (!dockFacility_0.LazyDockedUnitsDictionary.Value.Values.Contains((ActiveUnit)treeNode2.Tag))
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

		// Token: 0x06004341 RID: 17217 RVA: 0x00189780 File Offset: 0x00187980
		private void method_15(object sender, EventArgs e)
		{
			int selectedIndex = this.vmethod_0().SelectedIndex;
			if (selectedIndex == 0)
			{
				this.method_3();
			}
			else if (selectedIndex == 1)
			{
				this.method_11();
			}
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x00021AC0 File Offset: 0x0001FCC0
		private void TSB_LaunchIndividually_Click(object sender, EventArgs e)
		{
			this.LaunchIndividually();
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x001897B8 File Offset: 0x001879B8
		private void LaunchIndividually()
		{
			this.method_18(true, false);
			int count = this.collection_1.Count;
			if (count != 0)
			{
				if (count == 1)
				{
					this.collection_1[0].GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
				}
				else
				{
					using (IEnumerator<ActiveUnit> enumerator = this.collection_1.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
						}
					}
				}
			}
			this.method_7();
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x00189850 File Offset: 0x00187A50
		private void method_18(bool bool_1, bool bool_2)
		{
			this.collection_1.Clear();
			foreach (TreeGridViewRow current in this.vmethod_12().Nodes)
			{
				foreach (TreeGridViewRow current2 in current.Nodes)
				{
					if (current2.Selected)
					{
						this.collection_1.Add((ActiveUnit)current2.Tag);
					}
				}
			}
			if (bool_1)
			{
				List<ActiveUnit> list = new List<ActiveUnit>();
				foreach (ActiveUnit current3 in this.collection_1)
				{
					if (current3.GetSide(false) != Client.GetClientSide())
					{
						list.Add(current3);
					}
				}
				if (list.Count > 0)
				{
					Interaction.MsgBox(Conversions.ToString(list.Count) + " of the selected boats are allied units not under your direct control.", MsgBoxStyle.OkOnly, "Allied boats selected!");
					foreach (ActiveUnit current4 in list)
					{
						this.collection_1.Remove(current4);
					}
				}
			}
			List<ActiveUnit> list2 = new List<ActiveUnit>();
			foreach (ActiveUnit current5 in this.collection_1)
			{
				ActiveUnit activeUnit = current5;
				string text = null;
				if (!activeUnit.vmethod_116(ref text))
				{
					list2.Add(current5);
				}
			}
			if (list2.Count > 0)
			{
				Interaction.MsgBox(Conversions.ToString(list2.Count) + " of the selected boats are unavailable for operations, and will not launch.", MsgBoxStyle.OkOnly, "Unavailable boats selected!");
				using (List<ActiveUnit>.Enumerator enumerator6 = list2.GetEnumerator())
				{
					while (enumerator6.MoveNext())
					{
						Aircraft item = (Aircraft)enumerator6.Current;
						this.collection_1.Remove(item);
					}
				}
			}
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x00021AC8 File Offset: 0x0001FCC8
		private void method_19(object sender, EventArgs5 e)
		{
			if (e.method_0().method_6() == 1)
			{
				this.hashSet_0.Remove(e.method_0());
			}
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x00189AC4 File Offset: 0x00187CC4
		private void method_20(object sender, EventArgs6 e)
		{
			e.method_0().Nodes.Clear();
			if (e.method_0().method_6() == 1)
			{
				string arg_41_0 = ((IEnumerable<ActiveUnit>)e.method_0().Tag).ElementAtOrDefault(0).UnitClass;
				this.hashSet_0.Add(e.method_0());
				IEnumerable<ActiveUnit> enumerable = ((IEnumerable<ActiveUnit>)e.method_0().Tag).Select(DockingOps.ActiveUnitFunc10).OrderBy(DockingOps.ActiveUnitFunc11);
				foreach (ActiveUnit current in enumerable)
				{
					string text = "";
					string text2 = "";
					string text3 = "";
					string text4 = "";
					string text5 = "";
					string text6 = "";
					string text7 = "";
					this.method_22(current, ref text, ref text2, ref text3, ref text4, ref text5, ref text6, ref text7);
					TreeGridViewRow treeGridViewRow = e.method_0().Nodes.method_1(new object[]
					{
						current.Name,
						text,
						text2,
						text3,
						text4,
						text5,
						text6,
						text7
					});
					treeGridViewRow.DefaultCellStyle.ForeColor = Color.Black;
					treeGridViewRow.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Regular);
					treeGridViewRow.Tag = current;
					this.method_21(ref treeGridViewRow, current);
				}
			}
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x00189C58 File Offset: 0x00187E58
		private void method_21(ref TreeGridViewRow TreeGridViewRow_, ActiveUnit activeUnit_)
		{
			if (activeUnit_.GetAI().NotExceedRedeployDamageThreshold())
			{
				TreeGridViewRow_.Cells[1].Style.BackColor = Color.LightGreen;
			}
			else
			{
				TreeGridViewRow_.Cells[1].Style.BackColor = Color.PaleVioletRed;
			}
			if (activeUnit_.GetAI().NotExceedRedeployAttackWeaponQuantityThreshold() && activeUnit_.GetAI().NotExceedRedeployDefenceWeaponQuantityThreshold())
			{
				TreeGridViewRow_.Cells[2].Style.BackColor = Color.LightGreen;
				TreeGridViewRow_.Cells[3].Style.BackColor = Color.LightGreen;
			}
			else
			{
				TreeGridViewRow_.Cells[2].Style.BackColor = Color.PaleVioletRed;
				TreeGridViewRow_.Cells[3].Style.BackColor = Color.PaleVioletRed;
			}
			if (activeUnit_.GetAI().NotExceedRedeployFuelThreshold())
			{
				TreeGridViewRow_.Cells[4].Style.BackColor = Color.LightGreen;
			}
			else
			{
				TreeGridViewRow_.Cells[4].Style.BackColor = Color.PaleVioletRed;
			}
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x00189D8C File Offset: 0x00187F8C
		private void method_22(ActiveUnit activeUnit_0, ref string string_0, ref string string_1, ref string string_2, ref string string_3, ref string string_4, ref string string_5, ref string string_6)
		{
			if (activeUnit_0.GetDamage().GetDamagePts() > 0f)
			{
				string_0 = Conversions.ToString(Math.Round((double)activeUnit_0.GetDamage().GetDamagePts(), 1)) + "% 毁伤, ";
			}
			else
			{
				string_0 = "没有结构性毁伤, ";
			}
			int arg_4E_0 = activeUnit_0.GetAllPlatformComponents().Count;
			int num = activeUnit_0.GetAllPlatformComponents().Where(DockingOps.PlatformComponentFunc12).Count<PlatformComponent>();
			if (num > 0)
			{
				string_0 = string_0 + Conversions.ToString(num) + "个系统离线";
			}
			else
			{
				string_0 += "所有系统离线";
			}
			List<WeaponRec> list = new List<WeaponRec>();
			List<WeaponRec> list2 = new List<WeaponRec>();
			List<WeaponRec> list3 = new List<WeaponRec>();
			Mount[] mounts = activeUnit_0.m_Mounts;
			double num2 = 0.0;
			double num3 = 0.0;
			checked
			{
				for (int i = 0; i < mounts.Length; i++)
				{
					Mount mount = mounts[i];
					foreach (WeaponRec current in mount.GetWeaponRecCollection())
					{
						Weapon._WeaponType weaponType = current.GetWeapon(Client.GetClientScenario()).GetWeaponType();
						switch (weaponType)
						{
						case Weapon._WeaponType.GuidedWeapon:
							break;
						case Weapon._WeaponType.Rocket:
						case Weapon._WeaponType.IronBomb:
						case Weapon._WeaponType.Gun:
						case Weapon._WeaponType.Dispenser:
							goto IL_189;
						case Weapon._WeaponType.Decoy_Expendable:
						case Weapon._WeaponType.Decoy_Towed:
						case Weapon._WeaponType.Decoy_Vehicle:
						case Weapon._WeaponType.TrainingRound:
							goto IL_17F;
						default:
							switch (weaponType)
							{
							case Weapon._WeaponType.Torpedo:
								break;
							case Weapon._WeaponType.DepthCharge:
							case Weapon._WeaponType.BottomMine:
							case Weapon._WeaponType.FloatingMine:
							case Weapon._WeaponType.MovingMine:
							case Weapon._WeaponType.RisingMine:
							case Weapon._WeaponType.DriftingMine:
							case Weapon._WeaponType.DummyMine:
								goto IL_189;
							case Weapon._WeaponType.Sonobuoy:
							case Weapon._WeaponType.MooredMine:
							case (Weapon._WeaponType)4010:
								goto IL_17F;
							default:
								goto IL_17F;
							}
							break;
						}
						list.Add(current);
						continue;
						IL_17F:
						list3.Add(current);
						continue;
						IL_189:
						list2.Add(current);
					}
					if (!Information.IsNothing(mount.GetMagazineForMount()))
					{
						foreach (WeaponRec current2 in mount.GetMagazineForMount().GetWeaponRecCollection())
						{
							Weapon._WeaponType weaponType2 = current2.GetWeapon(Client.GetClientScenario()).GetWeaponType();
							switch (weaponType2)
							{
							case Weapon._WeaponType.GuidedWeapon:
								break;
							case Weapon._WeaponType.Rocket:
							case Weapon._WeaponType.IronBomb:
							case Weapon._WeaponType.Gun:
							case Weapon._WeaponType.Dispenser:
								goto IL_27C;
							case Weapon._WeaponType.Decoy_Expendable:
							case Weapon._WeaponType.Decoy_Towed:
							case Weapon._WeaponType.Decoy_Vehicle:
							case Weapon._WeaponType.TrainingRound:
								goto IL_272;
							default:
								switch (weaponType2)
								{
								case Weapon._WeaponType.Torpedo:
									break;
								case Weapon._WeaponType.DepthCharge:
								case Weapon._WeaponType.BottomMine:
								case Weapon._WeaponType.FloatingMine:
								case Weapon._WeaponType.MovingMine:
								case Weapon._WeaponType.RisingMine:
								case Weapon._WeaponType.DriftingMine:
								case Weapon._WeaponType.DummyMine:
									goto IL_27C;
								case Weapon._WeaponType.Sonobuoy:
								case Weapon._WeaponType.MooredMine:
								case (Weapon._WeaponType)4010:
									goto IL_272;
								default:
									goto IL_272;
								}
								break;
							}
							list.Add(current2);
							continue;
							IL_272:
							list3.Add(current2);
							continue;
							IL_27C:
							list2.Add(current2);
						}
					}
				}
				List<string> list4 = new List<string>();
				if (list.Count > 0)
				{
					string item = "制导武器: " + Conversions.ToString(list.Select(DockingOps.WeaponRecFunc13).Sum()) + "/" + Conversions.ToString(list.Select(DockingOps.WeaponRecFunc14).Sum());
					list4.Add(item);
				}
				if (list2.Count > 0)
				{
					string item2 = "非制导武器: " + Conversions.ToString(list2.Select(DockingOps.WeaponRecFunc15).Sum()) + "/" + Conversions.ToString(list2.Select(DockingOps.WeaponRecFunc16).Sum());
					list4.Add(item2);
				}
				if (list3.Count > 0)
				{
					string item3 = "其它武器: " + Conversions.ToString(list3.Select(DockingOps.WeaponRecFunc17).Sum()) + "/" + Conversions.ToString(list3.Select(DockingOps.WeaponRecFunc18).Sum());
					list4.Add(item3);
				}
				string_1 = string.Join("\r\n", list4);
				list.Clear();
				list2.Clear();
				list3.Clear();
				list4.Clear();
				Magazine[] magazinesForAllMounts = activeUnit_0.GetMagazinesForAllMounts();
				for (int j = 0; j < magazinesForAllMounts.Length; j++)
				{
					Magazine magazine = magazinesForAllMounts[j];
					foreach (WeaponRec current3 in magazine.GetWeaponRecCollection())
					{
						Weapon._WeaponType weaponType3 = current3.GetWeapon(Client.GetClientScenario()).GetWeaponType();
						switch (weaponType3)
						{
						case Weapon._WeaponType.GuidedWeapon:
							break;
						case Weapon._WeaponType.Rocket:
						case Weapon._WeaponType.IronBomb:
						case Weapon._WeaponType.Gun:
						case Weapon._WeaponType.Dispenser:
							goto IL_4A7;
						case Weapon._WeaponType.Decoy_Expendable:
						case Weapon._WeaponType.Decoy_Towed:
						case Weapon._WeaponType.Decoy_Vehicle:
						case Weapon._WeaponType.TrainingRound:
							goto IL_49D;
						default:
							switch (weaponType3)
							{
							case Weapon._WeaponType.Torpedo:
								break;
							case Weapon._WeaponType.DepthCharge:
							case Weapon._WeaponType.BottomMine:
							case Weapon._WeaponType.FloatingMine:
							case Weapon._WeaponType.MovingMine:
							case Weapon._WeaponType.RisingMine:
							case Weapon._WeaponType.DriftingMine:
							case Weapon._WeaponType.DummyMine:
								goto IL_4A7;
							case Weapon._WeaponType.Sonobuoy:
							case Weapon._WeaponType.MooredMine:
							case (Weapon._WeaponType)4010:
								goto IL_49D;
							default:
								goto IL_49D;
							}
							break;
						}
						list.Add(current3);
						continue;
						IL_49D:
						list3.Add(current3);
						continue;
						IL_4A7:
						list2.Add(current3);
					}
				}
				if (list.Count > 0)
				{
					string item = "制导武器: " + Conversions.ToString(list.Select(DockingOps.WeaponRecFunc19).Sum()) + "/" + Conversions.ToString(list.Select(DockingOps.WeaponRecFunc20).Sum());
					list4.Add(item);
				}
				if (list2.Count > 0)
				{
					string item2 = "非制导武器: " + Conversions.ToString(list2.Select(DockingOps.WeaponRecFunc21).Sum()) + "/" + Conversions.ToString(list2.Select(DockingOps.WeaponRecFunc22).Sum());
					list4.Add(item2);
				}
				if (list3.Count > 0)
				{
					string item3 = "其它武器: " + Conversions.ToString(list3.Select(DockingOps.WeaponRecFunc23).Sum()) + "/" + Conversions.ToString(list3.Select(DockingOps.WeaponRecFunc24).Sum());
					list4.Add(item3);
				}
				string_2 = string.Join("\r\n", list4);
				num2 = 0.0;
				num3 = 0.0;
			}
			string_3 = Conversions.ToString(Math.Round(activeUnit_0.GetFuelLeft(ref num2, ref num3, false) * 100.0, 1)) + "%";
			if (Information.IsNothing(activeUnit_0.GetAssignedMission(false)))
			{
				string_4 = "-";
			}
			else
			{
				string text = "";
				if (activeUnit_0.GetAI().IsEscort)
				{
					text = ", 护航";
				}
				string_4 = string.Concat(new string[]
				{
					activeUnit_0.GetAssignedMission(false).Name,
					" (",
					activeUnit_0.GetAssignedMission(false).GetTypeString(Client.GetClientScenario()),
					text,
					")"
				});
			}
			string_5 = activeUnit_0.GetDockingOps().GetDockingOpsConditionName();
			string_6 = Misc.GetTimeString((long)Math.Round(activeUnit_0.GetDockingOps().CT), Aircraft_AirOps._Maintenance.const_0, false, false);
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x00021AEF File Offset: 0x0001FCEF
		private void TSB_LaunchAsGroup_Click(object sender, EventArgs e)
		{
			this.LaunchAsGroup();
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x0018A49C File Offset: 0x0018869C
		private void LaunchAsGroup()
		{
			this.method_18(true, true);
			Misc.smethod_60(this.collection_1, Client.GetClientScenario(), Client.GetClientSide(), null);
			int count = this.collection_1.Count;
			if (count != 0)
			{
				if (count == 1)
				{
					this.collection_1[0].GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
				}
				else
				{
					using (IEnumerator<ActiveUnit> enumerator = this.collection_1.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
						}
					}
				}
			}
			this.method_7();
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x0018A548 File Offset: 0x00188748
		private void method_25(object sender, EventArgs e)
		{
			this.collection_1.Clear();
			foreach (TreeGridViewRow current in this.vmethod_12().Nodes)
			{
				bool arg_2F_0 = current.Selected;
				foreach (TreeGridViewRow current2 in current.Nodes)
				{
					if (current2.Selected)
					{
						if (((ActiveUnit)current2.Tag).IsShip)
						{
							this.collection_1.Add((Ship)current2.Tag);
						}
						else if (((ActiveUnit)current2.Tag).IsSubmarine)
						{
							this.collection_1.Add((Submarine)current2.Tag);
						}
					}
				}
			}
			if (this.collection_1.Count > 0)
			{
				this.GetTSB_LaunchIndividually().Enabled = true;
				this.GetTSB_Cargo().Enabled = true;
				this.GetTSB_LaunchAsGroup().Enabled = true;
				this.GetTSB_AbortLaunch().Enabled = true;
				this.GetTSB_Doctrine().Enabled = true;
				this.GetTSB_AssignToMission().Enabled = true;
				if (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit)
				{
					this.GetTSB_SetReadyTime().Enabled = true;
					this.GetTSB_Rename().Enabled = true;
					this.GetTSB_Delete().Enabled = true;
				}
			}
			else
			{
				this.GetTSB_LaunchIndividually().Enabled = false;
				this.GetTSB_Cargo().Enabled = false;
				this.GetTSB_LaunchAsGroup().Enabled = false;
				this.GetTSB_AbortLaunch().Enabled = false;
				this.GetTSB_Doctrine().Enabled = false;
				this.GetTSB_AssignToMission().Enabled = false;
				if (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit)
				{
					this.GetTSB_SetReadyTime().Enabled = false;
					this.GetTSB_Rename().Enabled = false;
					this.GetTSB_Delete().Enabled = false;
				}
			}
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x00020FF0 File Offset: 0x0001F1F0
		private void method_26(object sender, DoWorkEventArgs e)
		{
			Thread.Sleep(10);
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x00021AF7 File Offset: 0x0001FCF7
		private void method_27(object sender, RunWorkerCompletedEventArgs e)
		{
			this.method_10();
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x0018A764 File Offset: 0x00188964
		private void DockingOps_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F7 && base.Visible)
			{
				base.Close();
			}
			else if (!base.Visible || (e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract && e.KeyCode != Keys.End && e.KeyCode != Keys.Home))
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x00021AFF File Offset: 0x0001FCFF
		private void DockingOps_FormClosed(object sender, FormClosedEventArgs e)
		{
			ActiveUnit_DockingOps.smethod_3(new ActiveUnit_DockingOps.Delegate3(this.method_4));
			ActiveUnit_DockingOps.smethod_1(new ActiveUnit_DockingOps.Delegate2(this.method_1));
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x00021B23 File Offset: 0x0001FD23
		private void method_28(object sender, EventArgs e)
		{
			this.method_29();
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x0018A844 File Offset: 0x00188A44
		private void method_29()
		{
			this.method_18(true, false);
			foreach (ActiveUnit current in this.collection_1)
			{
				if (current.GetDockingOps().method_48())
				{
					current.GetDockingOps().method_45(current.GetDockingOps().GetCurrentHostUnit(), true);
				}
			}
			this.method_7();
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x0018A8C4 File Offset: 0x00188AC4
		private void method_30()
		{
			this.collection_1.Clear();
			foreach (TreeGridViewRow current in this.vmethod_12().Nodes)
			{
				foreach (TreeGridViewRow current2 in current.Nodes)
				{
					if (current2.Selected)
					{
						this.collection_1.Add((ActiveUnit)current2.Tag);
					}
				}
			}
			this.GetTSB_AssignToMission().DropDownItems.Clear();
			if (this.collection_1.Count > 0)
			{
				new ToolStripMenuItem();
				((ToolStripMenuItem)this.GetTSB_AssignToMission().DropDown.Items.Add("< Unassign >", null, new EventHandler(this.method_32))).Tag = null;
				foreach (Mission current3 in Client.GetClientSide().GetMissionCollection())
				{
					ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
					ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
					toolStripMenuItem = (ToolStripMenuItem)this.GetTSB_AssignToMission().DropDown.Items.Add(current3.Name, null, new EventHandler(this.method_32));
					toolStripMenuItem.Tag = current3;
					if (current3.MissionClass == Mission._MissionClass.Strike)
					{
						toolStripMenuItem2 = (ToolStripMenuItem)this.GetTSB_AssignToMission().DropDown.Items.Add(current3.Name + " - Escort", null, new EventHandler(this.method_32));
						toolStripMenuItem2.Tag = current3;
					}
					if (this.collection_1.Count == 1)
					{
						ActiveUnit activeUnit = this.collection_1[0];
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

		// Token: 0x06004353 RID: 17235 RVA: 0x0018AB40 File Offset: 0x00188D40
		private void method_31(object sender, EventArgs e)
		{
			this.method_18(true, false);
			if (this.collection_1.Count > 0)
			{
				MainForm mainForm = CommandFactory.GetCommandMain().GetMainForm();
				Subject class137_ = null;
				ReadOnlyCollection<Unit> readOnlyCollection = null;
				mainForm.method_254(class137_, ref readOnlyCollection, ref this.collection_1, false);
			}
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_32(object sender, EventArgs e)
		{
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x00021B2B File Offset: 0x0001FD2B
		private void method_33(object sender, EventArgs e)
		{
			this.method_30();
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x00021B33 File Offset: 0x0001FD33
		private void method_34(object sender, ToolStripItemClickedEventArgs e)
		{
			this.method_35(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x0018AB88 File Offset: 0x00188D88
		private void method_35(object sender, ToolStripItemClickedEventArgs e)
		{
			this.method_18(true, false);
			if (Information.IsNothing(RuntimeHelpers.GetObjectValue(e.ClickedItem.Tag)))
			{
				using (IEnumerator<ActiveUnit> enumerator = this.collection_1.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						CommandFactory.GetCommandMain().GetMainForm().method_366(ref current);
					}
					goto IL_AD;
				}
			}
			Mission mission = (Mission)e.ClickedItem.Tag;
			bool flag = Strings.InStr(e.ClickedItem.Text, " - Escort", CompareMethod.Binary) != 0;
			CommandFactory.GetCommandMain().GetMainForm().AssignToMission(RuntimeHelpers.GetObjectValue(sender), ref this.collection_1, ref mission, ref flag);
			IL_AD:
			this.method_2();
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x00021AC0 File Offset: 0x0001FCC0
		private void method_36(object sender, EventArgs e)
		{
			this.LaunchIndividually();
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x00021AEF File Offset: 0x0001FCEF
		private void method_37(object sender, EventArgs e)
		{
			this.LaunchAsGroup();
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x00021B23 File Offset: 0x0001FD23
		private void method_38(object sender, EventArgs e)
		{
			this.method_29();
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x0018AB40 File Offset: 0x00188D40
		private void method_39(object sender, EventArgs e)
		{
			this.method_18(true, false);
			if (this.collection_1.Count > 0)
			{
				MainForm mainForm = CommandFactory.GetCommandMain().GetMainForm();
				Subject class137_ = null;
				ReadOnlyCollection<Unit> readOnlyCollection = null;
				mainForm.method_254(class137_, ref readOnlyCollection, ref this.collection_1, false);
			}
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_40(object sender, EventArgs e)
		{
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x0018AC58 File Offset: 0x00188E58
		private void method_41()
		{
			if (this.collection_1.Count > 0)
			{
				this.vmethod_30().Enabled = true;
				this.vmethod_32().Enabled = true;
				this.vmethod_34().Enabled = true;
				this.vmethod_38().Enabled = true;
				this.vmethod_40().Enabled = true;
			}
			else
			{
				this.vmethod_30().Enabled = false;
				this.vmethod_32().Enabled = false;
				this.vmethod_34().Enabled = false;
				this.vmethod_38().Enabled = false;
				this.vmethod_40().Enabled = false;
			}
			this.collection_1.Clear();
			foreach (TreeGridViewRow current in this.vmethod_12().Nodes)
			{
				foreach (TreeGridViewRow current2 in current.Nodes)
				{
					if (current2.Selected)
					{
						this.collection_1.Add((ActiveUnit)current2.Tag);
					}
				}
			}
			this.vmethod_40().DropDownItems.Clear();
			if (this.collection_1.Count > 0)
			{
				new ToolStripMenuItem();
				((ToolStripMenuItem)this.vmethod_40().DropDown.Items.Add("< Unassign >", null, new EventHandler(this.method_40))).Tag = null;
				foreach (Mission current3 in Client.GetClientSide().GetMissionCollection())
				{
					ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
					ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
					toolStripMenuItem = (ToolStripMenuItem)this.vmethod_40().DropDown.Items.Add(current3.Name, null, new EventHandler(this.method_40));
					toolStripMenuItem.Tag = current3;
					if (current3.MissionClass == Mission._MissionClass.Strike)
					{
						toolStripMenuItem2 = (ToolStripMenuItem)this.vmethod_40().DropDown.Items.Add(current3.Name + " - Escort", null, new EventHandler(this.method_40));
						toolStripMenuItem2.Tag = current3;
					}
					if (this.collection_1.Count == 1)
					{
						ActiveUnit activeUnit = this.collection_1[0];
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

		// Token: 0x0600435E RID: 17246 RVA: 0x00021B42 File Offset: 0x0001FD42
		private void method_42(object sender, CancelEventArgs e)
		{
			this.method_41();
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x00021B33 File Offset: 0x0001FD33
		private void method_43(object sender, ToolStripItemClickedEventArgs e)
		{
			this.method_35(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x0018AF60 File Offset: 0x00189160
		private void method_44(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				TreeGridViewRow treeGridViewRow = this.vmethod_12().method_4();
				if (!Information.IsNothing(treeGridViewRow) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(treeGridViewRow.Tag)))
				{
					string name = this.vmethod_12().Columns[e.ColumnIndex].Name;
					if (Operators.CompareString(name, "Boat", false) != 0)
					{
						if (Operators.CompareString(name, "Damage", false) != 0)
						{
							if (Operators.CompareString(name, "Weapons", false) != 0)
							{
								if (Operators.CompareString(name, "Magazines", false) == 0)
								{
									ActiveUnit activeUnit_ = (ActiveUnit)treeGridViewRow.Tag;
									Client.magazines = new Magazines();
									Client.magazines.activeUnit_0 = activeUnit_;
									Client.magazines.Show();
								}
							}
							else
							{
								ActiveUnit activeUnit_2 = (ActiveUnit)treeGridViewRow.Tag;
								Client.smethod_26().activeUnit_0 = activeUnit_2;
								Client.smethod_26().Show();
							}
						}
						else
						{
							ActiveUnit activeUnit_3 = (ActiveUnit)treeGridViewRow.Tag;
							Client.damageControlWindow = new DamageControlWindow();
							Client.damageControlWindow.activeUnit_0 = activeUnit_3;
							Client.damageControlWindow.configuration = Client.GetConfiguration();
							Client.damageControlWindow.Show();
						}
					}
					else
					{
						try
						{
							ActiveUnit activeUnit = ((IEnumerable<ActiveUnit>)treeGridViewRow.Tag).ElementAtOrDefault(0);
							int dBID = activeUnit.DBID;
							if (activeUnit.IsShip)
							{
								Client.ShowDBInfo("水面舰艇", dBID);
							}
							else if (activeUnit.IsSubmarine)
							{
								Client.ShowDBInfo("潜艇", dBID);
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200379", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x00021B4A File Offset: 0x0001FD4A
		private void method_45(object sender, EventArgs e)
		{
			this.method_46();
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x0018B170 File Offset: 0x00189370
		private void method_46()
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			foreach (TreeGridViewRow current in this.vmethod_12().Nodes)
			{
				foreach (TreeGridViewRow current2 in current.Nodes)
				{
					if (current2.Selected)
					{
						list.Add((ActiveUnit)current2.Tag);
					}
				}
			}
			CommandFactory.GetCommandMain().GetTimeToReadyWindow().list_0 = list;
			CommandFactory.GetCommandMain().GetTimeToReadyWindow().Show();
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x00021B52 File Offset: 0x0001FD52
		private void method_47(object sender, EventArgs e)
		{
			this.method_48();
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x0018B23C File Offset: 0x0018943C
		private void method_48()
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			foreach (TreeGridViewRow current in this.vmethod_12().Nodes)
			{
				foreach (TreeGridViewRow current2 in current.Nodes)
				{
					if (current2.Selected)
					{
						list.Add((ActiveUnit)current2.Tag);
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
				this.method_7();
				this.method_12();
			}
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x00021B5A File Offset: 0x0001FD5A
		private void method_49(object sender, EventArgs e)
		{
			this.method_50();
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x0018B350 File Offset: 0x00189550
		private void method_50()
		{
			List<TreeGridViewRow> list = new List<TreeGridViewRow>();
			foreach (TreeGridViewRow current in this.vmethod_12().Nodes)
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
				ActiveUnit activeUnit = (ActiveUnit)current3.Tag;
				activeUnit.GetDockingOps().GetHostDockFacility().LazyDockedUnitsDictionary.Value.TryRemove(activeUnit.GetGuid(), out activeUnit);
				Scenario clientScenario = Client.GetClientScenario();
				GameGeneral.RemoveUnit(ref clientScenario, activeUnit.GetGuid());
				current3.method_7().Nodes.Remove(current3);
			}
			if (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Stop)
			{
				CommandFactory.GetCommandMain().GetMainForm().method_3().method_2(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit(), false);
			}
			this.method_10();
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x00021B4A File Offset: 0x0001FD4A
		private void method_51(object sender, EventArgs e)
		{
			this.method_46();
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x00021B52 File Offset: 0x0001FD52
		private void method_52(object sender, EventArgs e)
		{
			this.method_48();
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x00021B5A File Offset: 0x0001FD5A
		private void method_53(object sender, EventArgs e)
		{
			this.method_50();
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x0018B4C4 File Offset: 0x001896C4
		private void method_54(object sender, EventArgs e)
		{
			this.method_18(true, false);
			int count = this.collection_1.Count;
			if (count != 0)
			{
				if (count == 1)
				{
					ActiveUnit activeUnit = this.collection_1[0];
					CommandFactory.GetCommandMain().GetCargoOps().activeUnit_0 = activeUnit.GetDockingOps().GetHostDockFacility().GetParentPlatform();
					CommandFactory.GetCommandMain().GetCargoOps().activeUnit_1 = activeUnit;
					CommandFactory.GetCommandMain().GetCargoOps().Show();
				}
				else
				{
					Interaction.MsgBox("Select one docked ship.", MsgBoxStyle.OkOnly, null);
				}
			}
			this.method_7();
		}

		// Token: 0x04001F38 RID: 7992
		public static Func<ActiveUnit, bool> ActiveUnitFunc0 = (ActiveUnit activeUnit_0) => activeUnit_0.IsShip;

		// Token: 0x04001F39 RID: 7993
		public static Func<ActiveUnit, int> ActiveUnitFunc1 = (ActiveUnit activeUnit_0) => activeUnit_0.DBID;

		// Token: 0x04001F3A RID: 7994
		public static Func<ActiveUnit, bool> ActiveUnitFunc2 = (ActiveUnit activeUnit_0) => activeUnit_0.IsSubmarine;

		// Token: 0x04001F3B RID: 7995
		public static Func<ActiveUnit, int> ActiveUnitFunc3 = (ActiveUnit activeUnit_0) => activeUnit_0.DBID;

		// Token: 0x04001F3C RID: 7996
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc4 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04001F3D RID: 7997
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc5 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04001F3E RID: 7998
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc6 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04001F3F RID: 7999
		public static Func<ActiveUnit, string> ActiveUnitFunc7 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x04001F40 RID: 8000
		public static Func<DockFacility, DockFacility> DockFacilityFunc8 = (DockFacility dockFacility_0) => dockFacility_0;

		// Token: 0x04001F41 RID: 8001
		public static Func<DockFacility, string> DockFacilityFunc9 = (DockFacility dockFacility_0) => dockFacility_0.Name;

		// Token: 0x04001F42 RID: 8002
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc10 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04001F43 RID: 8003
		public static Func<ActiveUnit, string> ActiveUnitFunc11 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x04001F44 RID: 8004
		public static Func<PlatformComponent, bool> PlatformComponentFunc12 = (PlatformComponent platformComponent_0) => platformComponent_0.GetComponentStatus() > PlatformComponent._ComponentStatus.Operational;

		// Token: 0x04001F45 RID: 8005
		public static Func<WeaponRec, int> WeaponRecFunc13 = (WeaponRec weaponRec_0) => weaponRec_0.GetCurrentLoad();

		// Token: 0x04001F46 RID: 8006
		public static Func<WeaponRec, int> WeaponRecFunc14 = (WeaponRec weaponRec_0) => weaponRec_0.DefaultLoad;

		// Token: 0x04001F47 RID: 8007
		public static Func<WeaponRec, int> WeaponRecFunc15 = (WeaponRec weaponRec_0) => weaponRec_0.GetCurrentLoad();

		// Token: 0x04001F48 RID: 8008
		public static Func<WeaponRec, int> WeaponRecFunc16 = (WeaponRec weaponRec_0) => weaponRec_0.DefaultLoad;

		// Token: 0x04001F49 RID: 8009
		public static Func<WeaponRec, int> WeaponRecFunc17 = (WeaponRec weaponRec_0) => weaponRec_0.GetCurrentLoad();

		// Token: 0x04001F4A RID: 8010
		public static Func<WeaponRec, int> WeaponRecFunc18 = (WeaponRec weaponRec_0) => weaponRec_0.DefaultLoad;

		// Token: 0x04001F4B RID: 8011
		public static Func<WeaponRec, int> WeaponRecFunc19 = (WeaponRec weaponRec_0) => weaponRec_0.GetCurrentLoad();

		// Token: 0x04001F4C RID: 8012
		public static Func<WeaponRec, int> WeaponRecFunc20 = (WeaponRec weaponRec_0) => weaponRec_0.DefaultLoad;

		// Token: 0x04001F4D RID: 8013
		public static Func<WeaponRec, int> WeaponRecFunc21 = (WeaponRec weaponRec_0) => weaponRec_0.GetCurrentLoad();

		// Token: 0x04001F4E RID: 8014
		public static Func<WeaponRec, int> WeaponRecFunc22 = (WeaponRec weaponRec_0) => weaponRec_0.DefaultLoad;

		// Token: 0x04001F4F RID: 8015
		public static Func<WeaponRec, int> WeaponRecFunc23 = (WeaponRec weaponRec_0) => weaponRec_0.GetCurrentLoad();

		// Token: 0x04001F50 RID: 8016
		public static Func<WeaponRec, int> WeaponRecFunc24 = (WeaponRec weaponRec_0) => weaponRec_0.DefaultLoad;

		// Token: 0x04001F52 RID: 8018
		[CompilerGenerated]
		private TabControl tabControl_0;

		// Token: 0x04001F53 RID: 8019
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x04001F54 RID: 8020
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x04001F55 RID: 8021
		[CompilerGenerated]
		private ToolStripButton TSB_LaunchIndividually;

		// Token: 0x04001F56 RID: 8022
		[CompilerGenerated]
		private ToolStripButton TSB_LaunchAsGroup;

		// Token: 0x04001F57 RID: 8023
		[CompilerGenerated]
		private SplitContainer splitContainer_0;

		// Token: 0x04001F58 RID: 8024
		[CompilerGenerated]
		private TreeGridView treeGridView_0;

		// Token: 0x04001F59 RID: 8025
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x04001F5A RID: 8026
		[CompilerGenerated]
		private TreeView treeView_0;

		// Token: 0x04001F5B RID: 8027
		[CompilerGenerated]
		private System.Windows.Forms.Timer timer_0;

		// Token: 0x04001F5C RID: 8028
		[CompilerGenerated]
		private ToolStripButton toolStripButton_2;

		// Token: 0x04001F5D RID: 8029
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x04001F5E RID: 8030
		[CompilerGenerated]
		private ToolStripButton toolStripButton_3;

		// Token: 0x04001F5F RID: 8031
		[CompilerGenerated]
		private ToolStripDropDownButton toolStripDropDownButton_0;

		// Token: 0x04001F60 RID: 8032
		[CompilerGenerated]
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x04001F61 RID: 8033
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04001F62 RID: 8034
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04001F63 RID: 8035
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x04001F64 RID: 8036
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_1;

		// Token: 0x04001F65 RID: 8037
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x04001F66 RID: 8038
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x04001F67 RID: 8039
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_2;

		// Token: 0x04001F68 RID: 8040
		[CompilerGenerated]
		private ToolStripButton toolStripButton_4;

		// Token: 0x04001F69 RID: 8041
		[CompilerGenerated]
		private ToolStripButton toolStripButton_5;

		// Token: 0x04001F6A RID: 8042
		[CompilerGenerated]
		private ToolStripButton toolStripButton_6;

		// Token: 0x04001F6B RID: 8043
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_3;

		// Token: 0x04001F6C RID: 8044
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_5;

		// Token: 0x04001F6D RID: 8045
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_6;

		// Token: 0x04001F6E RID: 8046
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_7;

		// Token: 0x04001F6F RID: 8047
		[CompilerGenerated]
		private ToolStripButton toolStripButton_7;

		// Token: 0x04001F70 RID: 8048
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn class2383_0;

		// Token: 0x04001F71 RID: 8049
		[CompilerGenerated]
		private DataGridViewLinkColumn dataGridViewLinkColumn_0;

		// Token: 0x04001F72 RID: 8050
		[CompilerGenerated]
		private DataGridViewLinkColumn dataGridViewLinkColumn_1;

		// Token: 0x04001F73 RID: 8051
		[CompilerGenerated]
		private DataGridViewLinkColumn dataGridViewLinkColumn_2;

		// Token: 0x04001F74 RID: 8052
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04001F75 RID: 8053
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04001F76 RID: 8054
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04001F77 RID: 8055
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04001F78 RID: 8056
		public Collection<ActiveUnit> HostUnits;

		// Token: 0x04001F79 RID: 8057
		private Collection<ActiveUnit> collection_1;

		// Token: 0x04001F7A RID: 8058
		private Collection<ActiveUnit> collection_2;

		// Token: 0x04001F7B RID: 8059
		private Collection<ActiveUnit> collection_3;

		// Token: 0x04001F7C RID: 8060
		private Class2472 class2472_0;

		// Token: 0x04001F7D RID: 8061
		private bool bool_0;

		// Token: 0x04001F7E RID: 8062
		private HashSet<TreeGridViewRow> hashSet_0;

		// Token: 0x04001F7F RID: 8063
		[CompilerGenerated]
		private BackgroundWorker backgroundWorker_0;

		// Token: 0x020009C2 RID: 2498
		[CompilerGenerated]
		public sealed class Class2511
		{
			// Token: 0x06004385 RID: 17285 RVA: 0x00021B7D File Offset: 0x0001FD7D
			public Class2511(DockingOps.Class2511 class2511_0)
			{
				if (class2511_0 != null)
				{
					this.activeUnit_0 = class2511_0.activeUnit_0;
				}
			}

			// Token: 0x06004386 RID: 17286 RVA: 0x00021B97 File Offset: 0x0001FD97
			internal bool method_0(TreeGridViewRow class2384_0)
			{
				return class2384_0.Tag == this.activeUnit_0;
			}

			// Token: 0x04001F99 RID: 8089
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x020009C3 RID: 2499
		[CompilerGenerated]
		public sealed class Class2512
		{
			// Token: 0x06004387 RID: 17287 RVA: 0x00021BA7 File Offset: 0x0001FDA7
			public Class2512(DockingOps.Class2512 class2512_0)
			{
				if (class2512_0 != null)
				{
					this.int_0 = class2512_0.int_0;
				}
			}

			// Token: 0x06004388 RID: 17288 RVA: 0x00021BC1 File Offset: 0x0001FDC1
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.IsShip & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04001F9A RID: 8090
			public int int_0;
		}

		// Token: 0x020009C4 RID: 2500
		[CompilerGenerated]
		public sealed class Class2513
		{
			// Token: 0x06004389 RID: 17289 RVA: 0x00021BD8 File Offset: 0x0001FDD8
			public Class2513(DockingOps.Class2513 class2513_0)
			{
				if (class2513_0 != null)
				{
					this.int_0 = class2513_0.int_0;
				}
			}

			// Token: 0x0600438A RID: 17290 RVA: 0x00021BF2 File Offset: 0x0001FDF2
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.IsSubmarine & activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04001F9B RID: 8091
			public int int_0;
		}
	}
}

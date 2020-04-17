using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns15;
using ns2;
using ns3;
using ns32;
using ns33;
using ns35;
using ns4;
using ThreadSafeControls;

namespace Command
{
	// 任务编辑窗口
	[DesignerGenerated]
	public sealed partial class MissionEditor : CommandForm
	{
		// Token: 0x06004453 RID: 17491 RVA: 0x0019751C File Offset: 0x0019571C
		public MissionEditor()
		{
			base.FormClosing += new FormClosingEventHandler(this.MissionEditor_FormClosing);
			base.Load += new EventHandler(this.MissionEditor_Load);
			base.VisibleChanged += new EventHandler(this.MissionEditor_VisibleChanged);
			base.KeyDown += new KeyEventHandler(this.MissionEditor_KeyDown);
			base.FormClosed += new FormClosedEventHandler(this.MissionEditor_FormClosed);
			this.bool_0 = false;
			this.bool_1 = false;
			this.bool_2 = false;
			this.bool_3 = false;
			this.bool_4 = false;
			this.bool_5 = false;
			this.bool_6 = false;
			this.bool_7 = false;
			this.bool_8 = false;
			this.bool_9 = false;
			this.bool_10 = false;
			this.bool_11 = false;
			this.bool_12 = false;
			this.bool_13 = false;
			this.bool_14 = false;
			this.bool_15 = false;
			this.bool_16 = false;
			this.bool_17 = false;
			this.bool_18 = false;
			this.bool_19 = false;
			this.bool_20 = false;
			this.bool_21 = false;
			this.bool_22 = false;
			this.bool_23 = false;
			this.bool_24 = false;
			this.bool_25 = false;
			this.bool_26 = false;
			this.bool_27 = false;
			this.bool_28 = false;
			this.bool_29 = false;
			this.bool_30 = false;
			this.bool_31 = false;
			this.bool_32 = false;
			this.InitializeComponent();
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x001AA848 File Offset: 0x001A8A48
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x00021FD0 File Offset: 0x000201D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(System.Windows.Forms.Label label_194)
		{
			this.label_0 = label_194;
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x001AA860 File Offset: 0x001A8A60
		[CompilerGenerated]
		internal  System.Windows.Forms.Label GetLabel_AssignedUnits()
		{
			return this.label_1;
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x00021FD9 File Offset: 0x000201D9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(System.Windows.Forms.Label label_194)
		{
			this.label_1 = label_194;
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x001AA878 File Offset: 0x001A8A78
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_4()
		{
			return this.label_2;
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x00021FE2 File Offset: 0x000201E2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(System.Windows.Forms.Label label_194)
		{
			this.label_2 = label_194;
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x001AA890 File Offset: 0x001A8A90
		[CompilerGenerated]
		internal  System.Windows.Forms.TreeView vmethod_6()
		{
			return this.treeView_0;
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x001AA8A8 File Offset: 0x001A8AA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(System.Windows.Forms.TreeView treeView_3)
		{
			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.method_6);
			System.Windows.Forms.TreeView treeView = this.treeView_0;
			if (treeView != null)
			{
				treeView.NodeMouseClick -= value;
			}
			this.treeView_0 = treeView_3;
			treeView = this.treeView_0;
			if (treeView != null)
			{
				treeView.NodeMouseClick += value;
			}
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x001AA8F4 File Offset: 0x001A8AF4
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_UnassignUnitsToMission()
		{
			return this.Button_UnassignUnitsToMission;
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x001AA90C File Offset: 0x001A8B0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_UnassignUnitsToMission(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.Button_UnassignUnitsToMission_Click);
			System.Windows.Forms.Button button_UnassignUnitsToMission = this.Button_UnassignUnitsToMission;
			if (button_UnassignUnitsToMission != null)
			{
				button_UnassignUnitsToMission.Click -= value;
			}
			this.Button_UnassignUnitsToMission = button_38;
			button_UnassignUnitsToMission = this.Button_UnassignUnitsToMission;
			if (button_UnassignUnitsToMission != null)
			{
				button_UnassignUnitsToMission.Click += value;
			}
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x001AA958 File Offset: 0x001A8B58
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_AssignUnitsToMission()
		{
			return this.Button_AssignUnitsToMission;
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x001AA970 File Offset: 0x001A8B70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_AssignUnitsToMission(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.Button_AssignUnitsToMission_Click);
			System.Windows.Forms.Button button_AssignUnitsToMission = this.Button_AssignUnitsToMission;
			if (button_AssignUnitsToMission != null)
			{
				button_AssignUnitsToMission.Click -= value;
			}
			this.Button_AssignUnitsToMission = button_38;
			button_AssignUnitsToMission = this.Button_AssignUnitsToMission;
			if (button_AssignUnitsToMission != null)
			{
				button_AssignUnitsToMission.Click += value;
			}
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x001AA9BC File Offset: 0x001A8BBC
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_DeleteMission()
		{
			return this.Button_DeleteMission;
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x001AA9D4 File Offset: 0x001A8BD4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_DeleteMission(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.Button_DeleteMission_Click);
			System.Windows.Forms.Button button_DeleteMission = this.Button_DeleteMission;
			if (button_DeleteMission != null)
			{
				button_DeleteMission.Click -= value;
			}
			this.Button_DeleteMission = button_38;
			button_DeleteMission = this.Button_DeleteMission;
			if (button_DeleteMission != null)
			{
				button_DeleteMission.Click += value;
			}
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x001AAA20 File Offset: 0x001A8C20
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_14()
		{
			return this.button_3;
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x001AAA38 File Offset: 0x001A8C38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_18);
			System.Windows.Forms.Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_38;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x001AAA84 File Offset: 0x001A8C84
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_16()
		{
			return this.button_4;
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x001AAA9C File Offset: 0x001A8C9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_34);
			System.Windows.Forms.Button button = this.button_4;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_4 = button_38;
			button = this.button_4;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x001AAAE8 File Offset: 0x001A8CE8
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_18()
		{
			return this.button_5;
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x001AAB00 File Offset: 0x001A8D00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_23);
			System.Windows.Forms.Button button = this.button_5;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_5 = button_38;
			button = this.button_5;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x001AAB4C File Offset: 0x001A8D4C
		[CompilerGenerated]
		internal  System.Windows.Forms.TreeView vmethod_20()
		{
			return this.treeView_1;
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x001AAB64 File Offset: 0x001A8D64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(System.Windows.Forms.TreeView treeView_3)
		{
			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.method_13);
			TreeNodeMouseClickEventHandler value2 = new TreeNodeMouseClickEventHandler(this.method_37);
			System.Windows.Forms.TreeView treeView = this.treeView_1;
			if (treeView != null)
			{
				treeView.NodeMouseDoubleClick -= value;
				treeView.NodeMouseClick -= value2;
			}
			this.treeView_1 = treeView_3;
			treeView = this.treeView_1;
			if (treeView != null)
			{
				treeView.NodeMouseDoubleClick += value;
				treeView.NodeMouseClick += value2;
			}
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x001AABC8 File Offset: 0x001A8DC8
		[CompilerGenerated]
		internal  System.Windows.Forms.TreeView vmethod_22()
		{
			return this.treeView_2;
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x001AABE0 File Offset: 0x001A8DE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(System.Windows.Forms.TreeView treeView_3)
		{
			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.method_36);
			System.Windows.Forms.TreeView treeView = this.treeView_2;
			if (treeView != null)
			{
				treeView.NodeMouseClick -= value;
			}
			this.treeView_2 = treeView_3;
			treeView = this.treeView_2;
			if (treeView != null)
			{
				treeView.NodeMouseClick += value;
			}
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x001AAC2C File Offset: 0x001A8E2C
		[CompilerGenerated]
		internal  TabPage vmethod_24()
		{
			return this.tabPage_0;
		}

		// Token: 0x0600446F RID: 17519 RVA: 0x00021FEB File Offset: 0x000201EB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(TabPage tabPage_25)
		{
			this.tabPage_0 = tabPage_25;
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x001AAC44 File Offset: 0x001A8E44
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCB_Patrol_13rule()
		{
			return this.checkBox_0;
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x001AAC5C File Offset: 0x001A8E5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_46);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_0 = checkBox_57;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x001AACA8 File Offset: 0x001A8EA8
		[CompilerGenerated]
		internal  TabPage vmethod_28()
		{
			return this.tabPage_1;
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x00021FF4 File Offset: 0x000201F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(TabPage tabPage_25)
		{
			this.tabPage_1 = tabPage_25;
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x001AACC0 File Offset: 0x001A8EC0
		[CompilerGenerated]
		internal  TabPage vmethod_30()
		{
			return this.tabPage_2;
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x00021FFD File Offset: 0x000201FD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(TabPage tabPage_25)
		{
			this.tabPage_2 = tabPage_25;
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x001AACD8 File Offset: 0x001A8ED8
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_32()
		{
			return this.checkBox_1;
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x001AACF0 File Offset: 0x001A8EF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_44);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_1 = checkBox_57;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x001AAD3C File Offset: 0x001A8F3C
		[CompilerGenerated]
		internal  Control1 GetTC_MissionOptions()
		{
			return this.control1_0;
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x00022006 File Offset: 0x00020206
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Control1 control1_1)
		{
			this.control1_0 = control1_1;
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x001AAD54 File Offset: 0x001A8F54
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_36()
		{
			return this.comboBox_0;
		}

		// Token: 0x0600447B RID: 17531 RVA: 0x001AAD6C File Offset: 0x001A8F6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_30);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_117;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x001AADB8 File Offset: 0x001A8FB8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_38()
		{
			return this.label_3;
		}

		// Token: 0x0600447D RID: 17533 RVA: 0x0002200F File Offset: 0x0002020F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(System.Windows.Forms.Label label_194)
		{
			this.label_3 = label_194;
		}

		// Token: 0x0600447E RID: 17534 RVA: 0x001AADD0 File Offset: 0x001A8FD0
		[CompilerGenerated]
		internal  TabPage vmethod_40()
		{
			return this.tabPage_3;
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x00022018 File Offset: 0x00020218
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(TabPage tabPage_25)
		{
			this.tabPage_3 = tabPage_25;
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x001AADE8 File Offset: 0x001A8FE8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_FerryBehavior()
		{
			return this.comboBox_1;
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x001AAE00 File Offset: 0x001A9000
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_31);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_1 = comboBox_117;
			comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x001AAE4C File Offset: 0x001A904C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_44()
		{
			return this.label_4;
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x00022021 File Offset: 0x00020221
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(System.Windows.Forms.Label label_194)
		{
			this.label_4 = label_194;
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x001AAE64 File Offset: 0x001A9064
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCB_InvestigateOutsidePatrolArea()
		{
			return this.checkBox_2;
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x001AAE7C File Offset: 0x001A907C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_47);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_2 = checkBox_57;
			checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x001AAEC8 File Offset: 0x001A90C8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_Strike_MinimumContactStanceToTrigger()
		{
			return this.comboBox_2;
		}

		// Token: 0x06004487 RID: 17543 RVA: 0x001AAEE0 File Offset: 0x001A90E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_32);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_2 = comboBox_117;
			comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x001AAF2C File Offset: 0x001A912C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_50()
		{
			return this.label_5;
		}

		// Token: 0x06004489 RID: 17545 RVA: 0x0002202A File Offset: 0x0002022A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(System.Windows.Forms.Label label_194)
		{
			this.label_5 = label_194;
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x001AAF44 File Offset: 0x001A9144
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_52()
		{
			return this.button_6;
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x001AAF5C File Offset: 0x001A915C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_33);
			System.Windows.Forms.Button button = this.button_6;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_6 = button_38;
			button = this.button_6;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x001AAFA8 File Offset: 0x001A91A8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_54()
		{
			return this.label_6;
		}

		// Token: 0x0600448D RID: 17549 RVA: 0x00022033 File Offset: 0x00020233
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(System.Windows.Forms.Label label_194)
		{
			this.label_6 = label_194;
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x001AAFC0 File Offset: 0x001A91C0
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_56()
		{
			return this.checkBox_3;
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x001AAFD8 File Offset: 0x001A91D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_42);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_3 = checkBox_57;
			checkBox = this.checkBox_3;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004490 RID: 17552 RVA: 0x001AB024 File Offset: 0x001A9224
		[CompilerGenerated]
		internal  AreaEditor GetAreaEditor_PatrolArea()
		{
			return this.areaEditor_0;
		}

		// Token: 0x06004491 RID: 17553 RVA: 0x0002203C File Offset: 0x0002023C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(AreaEditor areaEditor_6)
		{
			this.areaEditor_0 = areaEditor_6;
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x001AB03C File Offset: 0x001A923C
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCB_ScrubIfHuman()
		{
			return this.checkBox_4;
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x001AB054 File Offset: 0x001A9254
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_45);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_4 = checkBox_57;
			checkBox = this.checkBox_4;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x001AB0A0 File Offset: 0x001A92A0
		[CompilerGenerated]
		internal  AreaEditor vmethod_62()
		{
			return this.areaEditor_1;
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x00022045 File Offset: 0x00020245
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(AreaEditor areaEditor_6)
		{
			this.areaEditor_1 = areaEditor_6;
		}

		// Token: 0x06004496 RID: 17558 RVA: 0x001AB0B8 File Offset: 0x001A92B8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_SupportStationThrottle_Aircraft()
		{
			return this.comboBox_3;
		}

		// Token: 0x06004497 RID: 17559 RVA: 0x001AB0D0 File Offset: 0x001A92D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_125);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_3;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_3 = comboBox_117;
			comboBox = this.comboBox_3;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x001AB11C File Offset: 0x001A931C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_66()
		{
			return this.label_7;
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x0002204E File Offset: 0x0002024E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(System.Windows.Forms.Label label_194)
		{
			this.label_7 = label_194;
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x001AB134 File Offset: 0x001A9334
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_SupportTransitThrottle_Aircraft()
		{
			return this.comboBox_4;
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x001AB14C File Offset: 0x001A934C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_124);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_4;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_4 = comboBox_117;
			comboBox = this.comboBox_4;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x001AB198 File Offset: 0x001A9398
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_70()
		{
			return this.label_8;
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x00022057 File Offset: 0x00020257
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(System.Windows.Forms.Label label_194)
		{
			this.label_8 = label_194;
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x001AB1B0 File Offset: 0x001A93B0
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_72()
		{
			return this.checkBox_5;
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x001AB1C8 File Offset: 0x001A93C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_43);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_5;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_5 = checkBox_57;
			checkBox = this.checkBox_5;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x001AB214 File Offset: 0x001A9414
		[CompilerGenerated]
		internal  TabPage vmethod_74()
		{
			return this.tabPage_4;
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x00022060 File Offset: 0x00020260
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(TabPage tabPage_25)
		{
			this.tabPage_4 = tabPage_25;
		}

		// Token: 0x060044A2 RID: 17570 RVA: 0x001AB22C File Offset: 0x001A942C
		[CompilerGenerated]
		internal  AreaEditor vmethod_76()
		{
			return this.areaEditor_2;
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x00022069 File Offset: 0x00020269
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(AreaEditor areaEditor_6)
		{
			this.areaEditor_2 = areaEditor_6;
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x001AB244 File Offset: 0x001A9444
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_78()
		{
			return this.groupBox_0;
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x00022072 File Offset: 0x00020272
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_0 = groupBox_27;
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x001AB25C File Offset: 0x001A945C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_80()
		{
			return this.label_9;
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x0002207B File Offset: 0x0002027B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(System.Windows.Forms.Label label_194)
		{
			this.label_9 = label_194;
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x001AB274 File Offset: 0x001A9474
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_82()
		{
			return this.label_10;
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x00022084 File Offset: 0x00020284
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(System.Windows.Forms.Label label_194)
		{
			this.label_10 = label_194;
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x001AB28C File Offset: 0x001A948C
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_84()
		{
			return this.textBox_0;
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x0002208D File Offset: 0x0002028D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(System.Windows.Forms.TextBox textBox_36)
		{
			this.textBox_0 = textBox_36;
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x001AB2A4 File Offset: 0x001A94A4
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_86()
		{
			return this.textBox_1;
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x00022096 File Offset: 0x00020296
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(System.Windows.Forms.TextBox textBox_36)
		{
			this.textBox_1 = textBox_36;
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x001AB2BC File Offset: 0x001A94BC
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_88()
		{
			return this.textBox_2;
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x0002209F File Offset: 0x0002029F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(System.Windows.Forms.TextBox textBox_36)
		{
			this.textBox_2 = textBox_36;
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x001AB2D4 File Offset: 0x001A94D4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_90()
		{
			return this.label_11;
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x000220A8 File Offset: 0x000202A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(System.Windows.Forms.Label label_194)
		{
			this.label_11 = label_194;
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x001AB2EC File Offset: 0x001A94EC
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_92()
		{
			return this.textBox_3;
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x000220B1 File Offset: 0x000202B1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(System.Windows.Forms.TextBox textBox_36)
		{
			this.textBox_3 = textBox_36;
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x001AB304 File Offset: 0x001A9504
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_94()
		{
			return this.label_12;
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x000220BA File Offset: 0x000202BA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(System.Windows.Forms.Label label_194)
		{
			this.label_12 = label_194;
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x001AB31C File Offset: 0x001A951C
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_96()
		{
			return this.checkBox_6;
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x001AB334 File Offset: 0x001A9534
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_97(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_48);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_6;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_6 = checkBox_57;
			checkBox = this.checkBox_6;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x001AB380 File Offset: 0x001A9580
		[CompilerGenerated]
		internal  TabPage vmethod_98()
		{
			return this.tabPage_5;
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x000220C3 File Offset: 0x000202C3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_99(TabPage tabPage_25)
		{
			this.tabPage_5 = tabPage_25;
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x001AB398 File Offset: 0x001A9598
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_100()
		{
			return this.checkBox_7;
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x001AB3B0 File Offset: 0x001A95B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_101(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_49);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_7;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_7 = checkBox_57;
			checkBox = this.checkBox_7;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x001AB3FC File Offset: 0x001A95FC
		[CompilerGenerated]
		internal  AreaEditor vmethod_102()
		{
			return this.areaEditor_3;
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x000220CC File Offset: 0x000202CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_103(AreaEditor areaEditor_6)
		{
			this.areaEditor_3 = areaEditor_6;
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x001AB414 File Offset: 0x001A9614
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_104()
		{
			return this.label_13;
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x000220D5 File Offset: 0x000202D5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_105(System.Windows.Forms.Label label_194)
		{
			this.label_13 = label_194;
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x001AB42C File Offset: 0x001A962C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MissionStatus()
		{
			return this.comboBox_5;
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x001AB444 File Offset: 0x001A9644
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_107(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_38);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_5;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_5 = comboBox_117;
			comboBox = this.comboBox_5;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x001AB490 File Offset: 0x001A9690
		[CompilerGenerated]
		internal  TabPage vmethod_108()
		{
			return this.tabPage_6;
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x000220DE File Offset: 0x000202DE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_109(TabPage tabPage_25)
		{
			this.tabPage_6 = tabPage_25;
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x001AB4A8 File Offset: 0x001A96A8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_110()
		{
			return this.comboBox_6;
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x001AB4C0 File Offset: 0x001A96C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_111(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_39);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_6;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_6 = comboBox_117;
			comboBox = this.comboBox_6;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x001AB50C File Offset: 0x001A970C
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_112()
		{
			return this.groupBox_1;
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x000220E7 File Offset: 0x000202E7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_113(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_1 = groupBox_27;
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x001AB524 File Offset: 0x001A9724
		[CompilerGenerated]
		internal  System.Windows.Forms.RadioButton vmethod_114()
		{
			return this.radioButton_0;
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x001AB53C File Offset: 0x001A973C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_115(System.Windows.Forms.RadioButton radioButton_2)
		{
			EventHandler value = new EventHandler(this.method_41);
			System.Windows.Forms.RadioButton radioButton = this.radioButton_0;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_0 = radioButton_2;
			radioButton = this.radioButton_0;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x001AB588 File Offset: 0x001A9788
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_116()
		{
			return this.comboBox_7;
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x000220F0 File Offset: 0x000202F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_117(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_7 = comboBox_117;
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x001AB5A0 File Offset: 0x001A97A0
		[CompilerGenerated]
		internal  System.Windows.Forms.RadioButton vmethod_118()
		{
			return this.radioButton_1;
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x001AB5B8 File Offset: 0x001A97B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_119(System.Windows.Forms.RadioButton radioButton_2)
		{
			EventHandler value = new EventHandler(this.method_40);
			System.Windows.Forms.RadioButton radioButton = this.radioButton_1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_1 = radioButton_2;
			radioButton = this.radioButton_1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x001AB604 File Offset: 0x001A9804
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_120()
		{
			return this.groupBox_2;
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x000220F9 File Offset: 0x000202F9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_121(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_2 = groupBox_27;
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x001AB61C File Offset: 0x001A981C
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_RemoveSelected()
		{
			return this.button_7;
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x001AB634 File Offset: 0x001A9834
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_123(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_52);
			System.Windows.Forms.Button button = this.button_7;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_7 = button_38;
			button = this.button_7;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x001AB680 File Offset: 0x001A9880
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_AddHighlighted()
		{
			return this.Button_AddHighlighted;
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x001AB698 File Offset: 0x001A9898
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_AddHighlighted(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.Button_AddHighlighted_Click);
			System.Windows.Forms.Button button_AddHighlighted = this.Button_AddHighlighted;
			if (button_AddHighlighted != null)
			{
				button_AddHighlighted.Click -= value;
			}
			this.Button_AddHighlighted = button_38;
			button_AddHighlighted = this.Button_AddHighlighted;
			if (button_AddHighlighted != null)
			{
				button_AddHighlighted.Click += value;
			}
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x001AB6E4 File Offset: 0x001A98E4
		[CompilerGenerated]
		internal  System.Windows.Forms.ListBox vmethod_126()
		{
			return this.listBox_0;
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x00022102 File Offset: 0x00020302
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_127(System.Windows.Forms.ListBox listBox_1)
		{
			this.listBox_0 = listBox_1;
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x001AB6FC File Offset: 0x001A98FC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label GetLabel_MissionDescription()
		{
			return this.label_14;
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x0002210B File Offset: 0x0002030B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_129(System.Windows.Forms.Label label_194)
		{
			this.label_14 = label_194;
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x001AB714 File Offset: 0x001A9914
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_130()
		{
			return this.label_15;
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x00022114 File Offset: 0x00020314
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_131(System.Windows.Forms.Label label_194)
		{
			this.label_15 = label_194;
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x001AB72C File Offset: 0x001A992C
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox GetTextBox_MissionName()
		{
			return this.textBox_4;
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x001AB744 File Offset: 0x001A9944
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_133(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_19);
			EventHandler value2 = new EventHandler(this.method_20);
			System.Windows.Forms.TextBox textBox = this.textBox_4;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_4 = textBox_36;
			textBox = this.textBox_4;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x001AB7A8 File Offset: 0x001A99A8
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_134()
		{
			return this.button_9;
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x001AB7C0 File Offset: 0x001A99C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_135(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_53);
			System.Windows.Forms.Button button = this.button_9;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_9 = button_38;
			button = this.button_9;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x001AB80C File Offset: 0x001A9A0C
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_136()
		{
			return this.button_10;
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x001AB824 File Offset: 0x001A9A24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_137(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_54);
			System.Windows.Forms.Button button = this.button_10;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_10 = button_38;
			button = this.button_10;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x001AB870 File Offset: 0x001A9A70
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_138()
		{
			return this.label_16;
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x0002211D File Offset: 0x0002031D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_139(System.Windows.Forms.Label label_194)
		{
			this.label_16 = label_194;
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x001AB888 File Offset: 0x001A9A88
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCB_Strike_UseOffAxisAttack()
		{
			return this.checkBox_8;
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x001AB8A0 File Offset: 0x001A9AA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_141(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_55);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_8;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_8 = checkBox_57;
			checkBox = this.checkBox_8;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060044E4 RID: 17636 RVA: 0x001AB8EC File Offset: 0x001A9AEC
		[CompilerGenerated]
		internal  System.Windows.Forms.TabControl GetTC_PatrolAndProsecutionZones()
		{
			return this.tabControl_0;
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x001AB904 File Offset: 0x001A9B04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_143(System.Windows.Forms.TabControl tabControl_8)
		{
			DrawItemEventHandler value = new DrawItemEventHandler(this.method_56);
			System.Windows.Forms.TabControl tabControl = this.tabControl_0;
			if (tabControl != null)
			{
				tabControl.DrawItem -= value;
			}
			this.tabControl_0 = tabControl_8;
			tabControl = this.tabControl_0;
			if (tabControl != null)
			{
				tabControl.DrawItem += value;
			}
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x001AB950 File Offset: 0x001A9B50
		[CompilerGenerated]
		internal  TabPage vmethod_144()
		{
			return this.tabPage_7;
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x00022126 File Offset: 0x00020326
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_145(TabPage tabPage_25)
		{
			this.tabPage_7 = tabPage_25;
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x001AB968 File Offset: 0x001A9B68
		[CompilerGenerated]
		internal  TabPage vmethod_146()
		{
			return this.tabPage_8;
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x0002212F File Offset: 0x0002032F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_147(TabPage tabPage_25)
		{
			this.tabPage_8 = tabPage_25;
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x001AB980 File Offset: 0x001A9B80
		[CompilerGenerated]
		internal  AreaEditor GetAreaEditor_ProsecutionArea()
		{
			return this.areaEditor_4;
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x00022138 File Offset: 0x00020338
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_149(AreaEditor areaEditor_6)
		{
			this.areaEditor_4 = areaEditor_6;
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x001AB998 File Offset: 0x001A9B98
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_150()
		{
			return this.checkBox_9;
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x001AB9B0 File Offset: 0x001A9BB0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_151(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_57);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_9;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_9 = checkBox_57;
			checkBox = this.checkBox_9;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x001AB9FC File Offset: 0x001A9BFC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_152()
		{
			return this.label_17;
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00022141 File Offset: 0x00020341
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_153(System.Windows.Forms.Label label_194)
		{
			this.label_17 = label_194;
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x001ABA14 File Offset: 0x001A9C14
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_154()
		{
			return this.textBox_5;
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x001ABA2C File Offset: 0x001A9C2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_155(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_98);
			EventHandler value2 = new EventHandler(this.method_99);
			System.Windows.Forms.TextBox textBox = this.textBox_5;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_5 = textBox_36;
			textBox = this.textBox_5;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x001ABA90 File Offset: 0x001A9C90
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_156()
		{
			return this.textBox_6;
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x001ABAA8 File Offset: 0x001A9CA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_157(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_91);
			EventHandler value2 = new EventHandler(this.method_92);
			System.Windows.Forms.TextBox textBox = this.textBox_6;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_6 = textBox_36;
			textBox = this.textBox_6;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x001ABB0C File Offset: 0x001A9D0C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_158()
		{
			return this.label_18;
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x0002214A File Offset: 0x0002034A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_159(System.Windows.Forms.Label label_194)
		{
			this.label_18 = label_194;
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x001ABB24 File Offset: 0x001A9D24
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_160()
		{
			return this.checkBox_10;
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x001ABB3C File Offset: 0x001A9D3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_161(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_58);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_10;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_10 = checkBox_57;
			checkBox = this.checkBox_10;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x001ABB88 File Offset: 0x001A9D88
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox GetTB_PatrolStationAltitude_Aircraft()
		{
			return this.textBox_7;
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x001ABBA0 File Offset: 0x001A9DA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_163(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_82);
			EventHandler value2 = new EventHandler(this.method_83);
			System.Windows.Forms.TextBox textBox = this.textBox_7;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_7 = textBox_36;
			textBox = this.textBox_7;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x001ABC04 File Offset: 0x001A9E04
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_164()
		{
			return this.label_19;
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00022153 File Offset: 0x00020353
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_165(System.Windows.Forms.Label label_194)
		{
			this.label_19 = label_194;
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x001ABC1C File Offset: 0x001A9E1C
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox GetTB_PatrolTransitAltitude_Aircraft()
		{
			return this.textBox_8;
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x001ABC34 File Offset: 0x001A9E34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_167(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_79);
			EventHandler value2 = new EventHandler(this.method_80);
			System.Windows.Forms.TextBox textBox = this.textBox_8;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_8 = textBox_36;
			textBox = this.textBox_8;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x001ABC98 File Offset: 0x001A9E98
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_168()
		{
			return this.label_20;
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x0002215C File Offset: 0x0002035C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_169(System.Windows.Forms.Label label_194)
		{
			this.label_20 = label_194;
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x001ABCB0 File Offset: 0x001A9EB0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_170()
		{
			return this.label_21;
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00022165 File Offset: 0x00020365
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_171(System.Windows.Forms.Label label_194)
		{
			this.label_21 = label_194;
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x001ABCC8 File Offset: 0x001A9EC8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_172()
		{
			return this.label_22;
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x0002216E File Offset: 0x0002036E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_173(System.Windows.Forms.Label label_194)
		{
			this.label_22 = label_194;
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x001ABCE0 File Offset: 0x001A9EE0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_174()
		{
			return this.label_23;
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x00022177 File Offset: 0x00020377
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_175(System.Windows.Forms.Label label_194)
		{
			this.label_23 = label_194;
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x001ABCF8 File Offset: 0x001A9EF8
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox GetTB_Patrol_XUnitsOnStation()
		{
			return this.textBox_9;
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x001ABD10 File Offset: 0x001A9F10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_177(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_59);
			System.Windows.Forms.TextBox textBox = this.textBox_9;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
			}
			this.textBox_9 = textBox_36;
			textBox = this.textBox_9;
			if (textBox != null)
			{
				textBox.TextChanged += value;
			}
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x001ABD5C File Offset: 0x001A9F5C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_178()
		{
			return this.label_24;
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x00022180 File Offset: 0x00020380
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_179(System.Windows.Forms.Label label_194)
		{
			this.label_24 = label_194;
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x001ABD74 File Offset: 0x001A9F74
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_180()
		{
			return this.textBox_10;
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x001ABD8C File Offset: 0x001A9F8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_181(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_60);
			System.Windows.Forms.TextBox textBox = this.textBox_10;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
			}
			this.textBox_10 = textBox_36;
			textBox = this.textBox_10;
			if (textBox != null)
			{
				textBox.TextChanged += value;
			}
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x001ABDD8 File Offset: 0x001A9FD8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_182()
		{
			return this.label_25;
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00022189 File Offset: 0x00020389
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_183(System.Windows.Forms.Label label_194)
		{
			this.label_25 = label_194;
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x001ABDF0 File Offset: 0x001A9FF0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_184()
		{
			return this.label_26;
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x00022192 File Offset: 0x00020392
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_185(System.Windows.Forms.Label label_194)
		{
			this.label_26 = label_194;
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x001ABE08 File Offset: 0x001AA008
		[CompilerGenerated]
		internal  TableLayoutPanel vmethod_186()
		{
			return this.tableLayoutPanel_0;
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x0002219B File Offset: 0x0002039B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_187(TableLayoutPanel tableLayoutPanel_1)
		{
			this.tableLayoutPanel_0 = tableLayoutPanel_1;
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x001ABE20 File Offset: 0x001AA020
		[CompilerGenerated]
		internal  System.Windows.Forms.Panel vmethod_188()
		{
			return this.panel_0;
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x000221A4 File Offset: 0x000203A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_189(System.Windows.Forms.Panel panel_8)
		{
			this.panel_0 = panel_8;
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x001ABE38 File Offset: 0x001AA038
		[CompilerGenerated]
		internal  System.Windows.Forms.Panel vmethod_190()
		{
			return this.panel_1;
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x000221AD File Offset: 0x000203AD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_191(System.Windows.Forms.Panel panel_8)
		{
			this.panel_1 = panel_8;
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x001ABE50 File Offset: 0x001AA050
		[CompilerGenerated]
		internal  System.Windows.Forms.Panel vmethod_192()
		{
			return this.panel_2;
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x000221B6 File Offset: 0x000203B6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_193(System.Windows.Forms.Panel panel_8)
		{
			this.panel_2 = panel_8;
		}

		// Token: 0x06004518 RID: 17688 RVA: 0x001ABE68 File Offset: 0x001AA068
		[CompilerGenerated]
		internal  System.Windows.Forms.Panel vmethod_194()
		{
			return this.panel_3;
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x000221BF File Offset: 0x000203BF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_195(System.Windows.Forms.Panel panel_8)
		{
			this.panel_3 = panel_8;
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x001ABE80 File Offset: 0x001AA080
		[CompilerGenerated]
		internal  System.Windows.Forms.Panel vmethod_196()
		{
			return this.panel_4;
		}

		// Token: 0x0600451B RID: 17691 RVA: 0x000221C8 File Offset: 0x000203C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_197(System.Windows.Forms.Panel panel_8)
		{
			this.panel_4 = panel_8;
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x001ABE98 File Offset: 0x001AA098
		[CompilerGenerated]
		internal  System.Windows.Forms.Panel vmethod_198()
		{
			return this.panel_5;
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x000221D1 File Offset: 0x000203D1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_199(System.Windows.Forms.Panel panel_8)
		{
			this.panel_5 = panel_8;
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x001ABEB0 File Offset: 0x001AA0B0
		[CompilerGenerated]
		internal  System.Windows.Forms.Panel vmethod_200()
		{
			return this.panel_6;
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x000221DA File Offset: 0x000203DA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_201(System.Windows.Forms.Panel panel_8)
		{
			this.panel_6 = panel_8;
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x001ABEC8 File Offset: 0x001AA0C8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_202()
		{
			return this.label_27;
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x000221E3 File Offset: 0x000203E3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_203(System.Windows.Forms.Label label_194)
		{
			this.label_27 = label_194;
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x001ABEE0 File Offset: 0x001AA0E0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_204()
		{
			return this.label_28;
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x000221EC File Offset: 0x000203EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_205(System.Windows.Forms.Label label_194)
		{
			this.label_28 = label_194;
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x001ABEF8 File Offset: 0x001AA0F8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_206()
		{
			return this.label_29;
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x000221F5 File Offset: 0x000203F5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_207(System.Windows.Forms.Label label_194)
		{
			this.label_29 = label_194;
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x001ABF10 File Offset: 0x001AA110
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_FlightSize_Strike()
		{
			return this.comboBox_8;
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x001ABF28 File Offset: 0x001AA128
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_209(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_72);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_8;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_8 = comboBox_117;
			comboBox = this.comboBox_8;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x001ABF74 File Offset: 0x001AA174
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_PatrolTransitThrottle_Aircraft()
		{
			return this.comboBox_9;
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x001ABF8C File Offset: 0x001AA18C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_211(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_122);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_9;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_9 = comboBox_117;
			comboBox = this.comboBox_9;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x001ABFD8 File Offset: 0x001AA1D8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_212()
		{
			return this.label_30;
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x000221FE File Offset: 0x000203FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_213(System.Windows.Forms.Label label_194)
		{
			this.label_30 = label_194;
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x001ABFF0 File Offset: 0x001AA1F0
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_AircraftFormationAttack_Strike()
		{
			return this.comboBox_10;
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x00022207 File Offset: 0x00020407
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_215(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_10 = comboBox_117;
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x001AC008 File Offset: 0x001AA208
		[CompilerGenerated]
		internal  System.Windows.Forms.Label GetLabel_PatrolStationAltitude_Aircraft()
		{
			return this.label_31;
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x00022210 File Offset: 0x00020410
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_217(System.Windows.Forms.Label label_194)
		{
			this.label_31 = label_194;
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x001AC020 File Offset: 0x001AA220
		[CompilerGenerated]
		internal  System.Windows.Forms.Label GetLabel_PatrolTransitAltitude_Aircraft()
		{
			return this.label_32;
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x00022219 File Offset: 0x00020419
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_219(System.Windows.Forms.Label label_194)
		{
			this.label_32 = label_194;
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x001AC038 File Offset: 0x001AA238
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_AircraftFormationCruise_Strike()
		{
			return this.comboBox_11;
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x00022222 File Offset: 0x00020422
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_221(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_11 = comboBox_117;
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x001AC050 File Offset: 0x001AA250
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_222()
		{
			return this.comboBox_12;
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x0002222B File Offset: 0x0002042B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_223(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_12 = comboBox_117;
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x001AC068 File Offset: 0x001AA268
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_224()
		{
			return this.comboBox_13;
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x00022234 File Offset: 0x00020434
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_225(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_13 = comboBox_117;
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x001AC080 File Offset: 0x001AA280
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_226()
		{
			return this.label_33;
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x0002223D File Offset: 0x0002043D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_227(System.Windows.Forms.Label label_194)
		{
			this.label_33 = label_194;
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x001AC098 File Offset: 0x001AA298
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_228()
		{
			return this.label_34;
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x00022246 File Offset: 0x00020446
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_229(System.Windows.Forms.Label label_194)
		{
			this.label_34 = label_194;
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x001AC0B0 File Offset: 0x001AA2B0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_230()
		{
			return this.label_35;
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x0002224F File Offset: 0x0002044F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_231(System.Windows.Forms.Label label_194)
		{
			this.label_35 = label_194;
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x001AC0C8 File Offset: 0x001AA2C8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_232()
		{
			return this.comboBox_14;
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x001AC0E0 File Offset: 0x001AA2E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_233(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_73);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_14;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_14 = comboBox_117;
			comboBox = this.comboBox_14;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x001AC12C File Offset: 0x001AA32C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_AircraftFormationCruise_Support()
		{
			return this.comboBox_15;
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x00022258 File Offset: 0x00020458
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_235(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_15 = comboBox_117;
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x001AC144 File Offset: 0x001AA344
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_236()
		{
			return this.label_36;
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x00022261 File Offset: 0x00020461
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_237(System.Windows.Forms.Label label_194)
		{
			this.label_36 = label_194;
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x001AC15C File Offset: 0x001AA35C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_238()
		{
			return this.label_37;
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x0002226A File Offset: 0x0002046A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_239(System.Windows.Forms.Label label_194)
		{
			this.label_37 = label_194;
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x001AC174 File Offset: 0x001AA374
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_FlightSize_Support()
		{
			return this.comboBox_16;
		}

		// Token: 0x06004547 RID: 17735 RVA: 0x001AC18C File Offset: 0x001AA38C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_241(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_74);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_16;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_16 = comboBox_117;
			comboBox = this.comboBox_16;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x001AC1D8 File Offset: 0x001AA3D8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_242()
		{
			return this.comboBox_17;
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x00022273 File Offset: 0x00020473
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_243(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_17 = comboBox_117;
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x001AC1F0 File Offset: 0x001AA3F0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_244()
		{
			return this.label_38;
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x0002227C File Offset: 0x0002047C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_245(System.Windows.Forms.Label label_194)
		{
			this.label_38 = label_194;
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x001AC208 File Offset: 0x001AA408
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_246()
		{
			return this.label_39;
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x00022285 File Offset: 0x00020485
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_247(System.Windows.Forms.Label label_194)
		{
			this.label_39 = label_194;
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x001AC220 File Offset: 0x001AA420
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_248()
		{
			return this.comboBox_18;
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x001AC238 File Offset: 0x001AA438
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_249(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_75);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_18;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_18 = comboBox_117;
			comboBox = this.comboBox_18;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x001AC284 File Offset: 0x001AA484
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_250()
		{
			return this.comboBox_19;
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x0002228E File Offset: 0x0002048E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_251(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_19 = comboBox_117;
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x001AC29C File Offset: 0x001AA49C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_252()
		{
			return this.comboBox_20;
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x00022297 File Offset: 0x00020497
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_253(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_20 = comboBox_117;
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x001AC2B4 File Offset: 0x001AA4B4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_254()
		{
			return this.label_40;
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x000222A0 File Offset: 0x000204A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_255(System.Windows.Forms.Label label_194)
		{
			this.label_40 = label_194;
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x001AC2CC File Offset: 0x001AA4CC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_256()
		{
			return this.label_41;
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x000222A9 File Offset: 0x000204A9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_257(System.Windows.Forms.Label label_194)
		{
			this.label_41 = label_194;
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x001AC2E4 File Offset: 0x001AA4E4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_258()
		{
			return this.label_42;
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x000222B2 File Offset: 0x000204B2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_259(System.Windows.Forms.Label label_194)
		{
			this.label_42 = label_194;
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x001AC2FC File Offset: 0x001AA4FC
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_260()
		{
			return this.comboBox_21;
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x001AC314 File Offset: 0x001AA514
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_261(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_76);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_21;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_21 = comboBox_117;
			comboBox = this.comboBox_21;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x001AC360 File Offset: 0x001AA560
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_262()
		{
			return this.comboBox_22;
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x000222BB File Offset: 0x000204BB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_263(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_22 = comboBox_117;
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x001AC378 File Offset: 0x001AA578
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_264()
		{
			return this.comboBox_23;
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x000222C4 File Offset: 0x000204C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_265(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_23 = comboBox_117;
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x001AC390 File Offset: 0x001AA590
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_266()
		{
			return this.label_43;
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x000222CD File Offset: 0x000204CD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_267(System.Windows.Forms.Label label_194)
		{
			this.label_43 = label_194;
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x001AC3A8 File Offset: 0x001AA5A8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_268()
		{
			return this.label_44;
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x000222D6 File Offset: 0x000204D6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_269(System.Windows.Forms.Label label_194)
		{
			this.label_44 = label_194;
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x001AC3C0 File Offset: 0x001AA5C0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_270()
		{
			return this.label_45;
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x000222DF File Offset: 0x000204DF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_271(System.Windows.Forms.Label label_194)
		{
			this.label_45 = label_194;
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x001AC3D8 File Offset: 0x001AA5D8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_272()
		{
			return this.comboBox_24;
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x001AC3F0 File Offset: 0x001AA5F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_273(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_77);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_24;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_24 = comboBox_117;
			comboBox = this.comboBox_24;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x001AC43C File Offset: 0x001AA63C
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_274()
		{
			return this.groupBox_3;
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x000222E8 File Offset: 0x000204E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_275(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_3 = groupBox_27;
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x001AC454 File Offset: 0x001AA654
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_276()
		{
			return this.comboBox_25;
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x000222F1 File Offset: 0x000204F1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_277(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_25 = comboBox_117;
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x001AC46C File Offset: 0x001AA66C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_278()
		{
			return this.comboBox_26;
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x000222FA File Offset: 0x000204FA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_279(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_26 = comboBox_117;
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x001AC484 File Offset: 0x001AA684
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_280()
		{
			return this.label_46;
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x00022303 File Offset: 0x00020503
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_281(System.Windows.Forms.Label label_194)
		{
			this.label_46 = label_194;
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x001AC49C File Offset: 0x001AA69C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_282()
		{
			return this.label_47;
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x0002230C File Offset: 0x0002050C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_283(System.Windows.Forms.Label label_194)
		{
			this.label_47 = label_194;
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x001AC4B4 File Offset: 0x001AA6B4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_284()
		{
			return this.label_48;
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x00022315 File Offset: 0x00020515
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_285(System.Windows.Forms.Label label_194)
		{
			this.label_48 = label_194;
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x001AC4CC File Offset: 0x001AA6CC
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_286()
		{
			return this.comboBox_27;
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x001AC4E4 File Offset: 0x001AA6E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_287(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_78);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_27;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_27 = comboBox_117;
			comboBox = this.comboBox_27;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x001AC530 File Offset: 0x001AA730
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_288()
		{
			return this.groupBox_4;
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x0002231E File Offset: 0x0002051E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_289(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_4 = groupBox_27;
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x001AC548 File Offset: 0x001AA748
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_290()
		{
			return this.groupBox_5;
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x00022327 File Offset: 0x00020527
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_291(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_5 = groupBox_27;
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x001AC560 File Offset: 0x001AA760
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_292()
		{
			return this.button_11;
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x001AC578 File Offset: 0x001AA778
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_293(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_24);
			System.Windows.Forms.Button button = this.button_11;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_11 = button_38;
			button = this.button_11;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x001AC5C4 File Offset: 0x001AA7C4
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_294()
		{
			return this.groupBox_6;
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x00022330 File Offset: 0x00020530
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_295(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_6 = groupBox_27;
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x001AC5DC File Offset: 0x001AA7DC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_296()
		{
			return this.label_49;
		}

		// Token: 0x0600457F RID: 17791 RVA: 0x00022339 File Offset: 0x00020539
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_297(System.Windows.Forms.Label label_194)
		{
			this.label_49 = label_194;
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x001AC5F4 File Offset: 0x001AA7F4
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_FerryThrottle_Aircraft()
		{
			return this.comboBox_28;
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x001AC60C File Offset: 0x001AA80C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_299(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_126);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_28;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_28 = comboBox_117;
			comboBox = this.comboBox_28;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x001AC658 File Offset: 0x001AA858
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_300()
		{
			return this.label_50;
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x00022342 File Offset: 0x00020542
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_301(System.Windows.Forms.Label label_194)
		{
			this.label_50 = label_194;
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x001AC670 File Offset: 0x001AA870
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_302()
		{
			return this.textBox_11;
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x001AC688 File Offset: 0x001AA888
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_303(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_101);
			EventHandler value2 = new EventHandler(this.method_102);
			System.Windows.Forms.TextBox textBox = this.textBox_11;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_11 = textBox_36;
			textBox = this.textBox_11;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x001AC6EC File Offset: 0x001AA8EC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_304()
		{
			return this.label_51;
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x0002234B File Offset: 0x0002054B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_305(System.Windows.Forms.Label label_194)
		{
			this.label_51 = label_194;
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x001AC704 File Offset: 0x001AA904
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_306()
		{
			return this.groupBox_7;
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x00022354 File Offset: 0x00020554
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_307(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_7 = groupBox_27;
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x001AC71C File Offset: 0x001AA91C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_308()
		{
			return this.label_52;
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x0002235D File Offset: 0x0002055D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_309(System.Windows.Forms.Label label_194)
		{
			this.label_52 = label_194;
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x001AC734 File Offset: 0x001AA934
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MiningStationThrottle_Aircraft()
		{
			return this.comboBox_29;
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x001AC74C File Offset: 0x001AA94C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_311(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_128);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_29;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_29 = comboBox_117;
			comboBox = this.comboBox_29;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x001AC798 File Offset: 0x001AA998
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_312()
		{
			return this.label_53;
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x00022366 File Offset: 0x00020566
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_313(System.Windows.Forms.Label label_194)
		{
			this.label_53 = label_194;
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x001AC7B0 File Offset: 0x001AA9B0
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MiningTransitThrottle_Aircraft()
		{
			return this.comboBox_30;
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x001AC7C8 File Offset: 0x001AA9C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_315(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_127);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_30;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_30 = comboBox_117;
			comboBox = this.comboBox_30;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x001AC814 File Offset: 0x001AAA14
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_316()
		{
			return this.label_54;
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x0002236F File Offset: 0x0002056F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_317(System.Windows.Forms.Label label_194)
		{
			this.label_54 = label_194;
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x001AC82C File Offset: 0x001AAA2C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_318()
		{
			return this.label_55;
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x00022378 File Offset: 0x00020578
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_319(System.Windows.Forms.Label label_194)
		{
			this.label_55 = label_194;
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x001AC844 File Offset: 0x001AAA44
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_320()
		{
			return this.label_56;
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x00022381 File Offset: 0x00020581
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_321(System.Windows.Forms.Label label_194)
		{
			this.label_56 = label_194;
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x001AC85C File Offset: 0x001AAA5C
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_322()
		{
			return this.textBox_12;
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x001AC874 File Offset: 0x001AAA74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_323(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_104);
			EventHandler value2 = new EventHandler(this.method_105);
			System.Windows.Forms.TextBox textBox = this.textBox_12;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_12 = textBox_36;
			textBox = this.textBox_12;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x001AC8D8 File Offset: 0x001AAAD8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_324()
		{
			return this.label_57;
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x0002238A File Offset: 0x0002058A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_325(System.Windows.Forms.Label label_194)
		{
			this.label_57 = label_194;
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x001AC8F0 File Offset: 0x001AAAF0
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_326()
		{
			return this.textBox_13;
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x001AC908 File Offset: 0x001AAB08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_327(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_107);
			EventHandler value2 = new EventHandler(this.method_108);
			System.Windows.Forms.TextBox textBox = this.textBox_13;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_13 = textBox_36;
			textBox = this.textBox_13;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x001AC96C File Offset: 0x001AAB6C
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_328()
		{
			return this.groupBox_8;
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x00022393 File Offset: 0x00020593
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_329(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_8 = groupBox_27;
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x001AC984 File Offset: 0x001AAB84
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_330()
		{
			return this.label_58;
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x0002239C File Offset: 0x0002059C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_331(System.Windows.Forms.Label label_194)
		{
			this.label_58 = label_194;
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x001AC99C File Offset: 0x001AAB9C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MineClearingStationThrottle_Aircraft()
		{
			return this.comboBox_31;
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x001AC9B4 File Offset: 0x001AABB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_333(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_130);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_31;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_31 = comboBox_117;
			comboBox = this.comboBox_31;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x001ACA00 File Offset: 0x001AAC00
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_334()
		{
			return this.label_59;
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x000223A5 File Offset: 0x000205A5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_335(System.Windows.Forms.Label label_194)
		{
			this.label_59 = label_194;
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x001ACA18 File Offset: 0x001AAC18
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MineClearingTransitThrottle_Aircraft()
		{
			return this.comboBox_32;
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x001ACA30 File Offset: 0x001AAC30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_337(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_129);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_32;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_32 = comboBox_117;
			comboBox = this.comboBox_32;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x001ACA7C File Offset: 0x001AAC7C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_338()
		{
			return this.label_60;
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x000223AE File Offset: 0x000205AE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_339(System.Windows.Forms.Label label_194)
		{
			this.label_60 = label_194;
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x001ACA94 File Offset: 0x001AAC94
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_340()
		{
			return this.label_61;
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x000223B7 File Offset: 0x000205B7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_341(System.Windows.Forms.Label label_194)
		{
			this.label_61 = label_194;
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x001ACAAC File Offset: 0x001AACAC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_342()
		{
			return this.label_62;
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x000223C0 File Offset: 0x000205C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_343(System.Windows.Forms.Label label_194)
		{
			this.label_62 = label_194;
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x001ACAC4 File Offset: 0x001AACC4
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_344()
		{
			return this.textBox_14;
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x001ACADC File Offset: 0x001AACDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_345(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_110);
			EventHandler value2 = new EventHandler(this.method_111);
			System.Windows.Forms.TextBox textBox = this.textBox_14;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_14 = textBox_36;
			textBox = this.textBox_14;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x001ACB40 File Offset: 0x001AAD40
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_346()
		{
			return this.label_63;
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x000223C9 File Offset: 0x000205C9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_347(System.Windows.Forms.Label label_194)
		{
			this.label_63 = label_194;
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x001ACB58 File Offset: 0x001AAD58
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_348()
		{
			return this.textBox_15;
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x001ACB70 File Offset: 0x001AAD70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_349(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_113);
			EventHandler value2 = new EventHandler(this.method_114);
			System.Windows.Forms.TextBox textBox = this.textBox_15;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_15 = textBox_36;
			textBox = this.textBox_15;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x001ACBD4 File Offset: 0x001AADD4
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_350()
		{
			return this.groupBox_9;
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x000223D2 File Offset: 0x000205D2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_351(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_9 = groupBox_27;
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x001ACBEC File Offset: 0x001AADEC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_352()
		{
			return this.label_64;
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x000223DB File Offset: 0x000205DB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_353(System.Windows.Forms.Label label_194)
		{
			this.label_64 = label_194;
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x001ACC04 File Offset: 0x001AAE04
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_354()
		{
			return this.comboBox_33;
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x001ACC1C File Offset: 0x001AAE1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_355(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_132);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_33;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_33 = comboBox_117;
			comboBox = this.comboBox_33;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x001ACC68 File Offset: 0x001AAE68
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_356()
		{
			return this.label_65;
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x000223E4 File Offset: 0x000205E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_357(System.Windows.Forms.Label label_194)
		{
			this.label_65 = label_194;
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x001ACC80 File Offset: 0x001AAE80
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_358()
		{
			return this.comboBox_34;
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x001ACC98 File Offset: 0x001AAE98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_359(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_131);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_34;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_34 = comboBox_117;
			comboBox = this.comboBox_34;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x001ACCE4 File Offset: 0x001AAEE4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_360()
		{
			return this.label_66;
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x000223ED File Offset: 0x000205ED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_361(System.Windows.Forms.Label label_194)
		{
			this.label_66 = label_194;
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x001ACCFC File Offset: 0x001AAEFC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_362()
		{
			return this.label_67;
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x000223F6 File Offset: 0x000205F6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_363(System.Windows.Forms.Label label_194)
		{
			this.label_67 = label_194;
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x001ACD14 File Offset: 0x001AAF14
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_364()
		{
			return this.label_68;
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x000223FF File Offset: 0x000205FF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_365(System.Windows.Forms.Label label_194)
		{
			this.label_68 = label_194;
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x001ACD2C File Offset: 0x001AAF2C
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_366()
		{
			return this.textBox_16;
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x001ACD44 File Offset: 0x001AAF44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_367(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_116);
			EventHandler value2 = new EventHandler(this.method_117);
			System.Windows.Forms.TextBox textBox = this.textBox_16;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_16 = textBox_36;
			textBox = this.textBox_16;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x001ACDA8 File Offset: 0x001AAFA8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_368()
		{
			return this.label_69;
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x00022408 File Offset: 0x00020608
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_369(System.Windows.Forms.Label label_194)
		{
			this.label_69 = label_194;
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x001ACDC0 File Offset: 0x001AAFC0
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_370()
		{
			return this.textBox_17;
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x001ACDD8 File Offset: 0x001AAFD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_371(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_119);
			EventHandler value2 = new EventHandler(this.method_120);
			System.Windows.Forms.TextBox textBox = this.textBox_17;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_17 = textBox_36;
			textBox = this.textBox_17;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x001ACE3C File Offset: 0x001AB03C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_PatrolStationThrottle_Aircraft()
		{
			return this.comboBox_35;
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x001ACE54 File Offset: 0x001AB054
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_373(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_123);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_35;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_35 = comboBox_117;
			comboBox = this.comboBox_35;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x001ACEA0 File Offset: 0x001AB0A0
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_374()
		{
			return this.textBox_18;
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x001ACEB8 File Offset: 0x001AB0B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_375(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_133);
			EventHandler value2 = new EventHandler(this.method_134);
			System.Windows.Forms.TextBox textBox = this.textBox_18;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_18 = textBox_36;
			textBox = this.textBox_18;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x001ACF1C File Offset: 0x001AB11C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_376()
		{
			return this.label_70;
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x00022411 File Offset: 0x00020611
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_377(System.Windows.Forms.Label label_194)
		{
			this.label_70 = label_194;
		}

		// Token: 0x060045D0 RID: 17872 RVA: 0x001ACF34 File Offset: 0x001AB134
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_378()
		{
			return this.label_71;
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x0002241A File Offset: 0x0002061A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_379(System.Windows.Forms.Label label_194)
		{
			this.label_71 = label_194;
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x001ACF4C File Offset: 0x001AB14C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_MinNumberOfStrikeAircraft()
		{
			return this.comboBox_36;
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x001ACF64 File Offset: 0x001AB164
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_381(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_136);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_36;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_36 = comboBox_117;
			comboBox = this.comboBox_36;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x001ACFB0 File Offset: 0x001AB1B0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_382()
		{
			return this.label_72;
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x00022423 File Offset: 0x00020623
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_383(System.Windows.Forms.Label label_194)
		{
			this.label_72 = label_194;
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x001ACFC8 File Offset: 0x001AB1C8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_384()
		{
			return this.comboBox_37;
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x001ACFE0 File Offset: 0x001AB1E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_385(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_137);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_37;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_37 = comboBox_117;
			comboBox = this.comboBox_37;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x001AD02C File Offset: 0x001AB22C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_386()
		{
			return this.label_73;
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x0002242C File Offset: 0x0002062C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_387(System.Windows.Forms.Label label_194)
		{
			this.label_73 = label_194;
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x001AD044 File Offset: 0x001AB244
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_SupportAircraftRequired()
		{
			return this.comboBox_38;
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x001AD05C File Offset: 0x001AB25C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_389(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_138);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_38;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_38 = comboBox_117;
			comboBox = this.comboBox_38;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x001AD0A8 File Offset: 0x001AB2A8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_390()
		{
			return this.label_74;
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x00022435 File Offset: 0x00020635
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_391(System.Windows.Forms.Label label_194)
		{
			this.label_74 = label_194;
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x001AD0C0 File Offset: 0x001AB2C0
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_392()
		{
			return this.comboBox_39;
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x001AD0D8 File Offset: 0x001AB2D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_393(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_139);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_39;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_39 = comboBox_117;
			comboBox = this.comboBox_39;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x001AD124 File Offset: 0x001AB324
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_394()
		{
			return this.label_75;
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x0002243E File Offset: 0x0002063E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_395(System.Windows.Forms.Label label_194)
		{
			this.label_75 = label_194;
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x001AD13C File Offset: 0x001AB33C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_396()
		{
			return this.comboBox_40;
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x001AD154 File Offset: 0x001AB354
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_397(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_140);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_40;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_40 = comboBox_117;
			comboBox = this.comboBox_40;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x001AD1A0 File Offset: 0x001AB3A0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_398()
		{
			return this.label_76;
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x00022447 File Offset: 0x00020647
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_399(System.Windows.Forms.Label label_194)
		{
			this.label_76 = label_194;
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x001AD1B8 File Offset: 0x001AB3B8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_400()
		{
			return this.comboBox_41;
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x001AD1D0 File Offset: 0x001AB3D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_401(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_141);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_41;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_41 = comboBox_117;
			comboBox = this.comboBox_41;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x001AD21C File Offset: 0x001AB41C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_402()
		{
			return this.label_77;
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x00022450 File Offset: 0x00020650
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_403(System.Windows.Forms.Label label_194)
		{
			this.label_77 = label_194;
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x001AD234 File Offset: 0x001AB434
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_MaxNumberOfStrikeAircraft()
		{
			return this.comboBox_42;
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x001AD24C File Offset: 0x001AB44C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_405(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_142);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_42;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_42 = comboBox_117;
			comboBox = this.comboBox_42;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x001AD298 File Offset: 0x001AB498
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_406()
		{
			return this.label_78;
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x00022459 File Offset: 0x00020659
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_407(System.Windows.Forms.Label label_194)
		{
			this.label_78 = label_194;
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x001AD2B0 File Offset: 0x001AB4B0
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_408()
		{
			return this.comboBox_43;
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x001AD2C8 File Offset: 0x001AB4C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_409(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_144);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_43;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_43 = comboBox_117;
			comboBox = this.comboBox_43;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x001AD314 File Offset: 0x001AB514
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_410()
		{
			return this.label_79;
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x00022462 File Offset: 0x00020662
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_411(System.Windows.Forms.Label label_194)
		{
			this.label_79 = label_194;
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x001AD32C File Offset: 0x001AB52C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_412()
		{
			return this.comboBox_44;
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x001AD344 File Offset: 0x001AB544
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_413(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_143);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_44;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_44 = comboBox_117;
			comboBox = this.comboBox_44;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x001AD390 File Offset: 0x001AB590
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_414()
		{
			return this.label_80;
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x0002246B File Offset: 0x0002066B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_415(System.Windows.Forms.Label label_194)
		{
			this.label_80 = label_194;
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x001AD3A8 File Offset: 0x001AB5A8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_MissionFuel()
		{
			return this.comboBox_45;
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x001AD3C0 File Offset: 0x001AB5C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_417(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_145);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_45;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_45 = comboBox_117;
			comboBox = this.comboBox_45;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x001AD40C File Offset: 0x001AB60C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_418()
		{
			return this.label_81;
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00022474 File Offset: 0x00020674
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_419(System.Windows.Forms.Label label_194)
		{
			this.label_81 = label_194;
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x001AD424 File Offset: 0x001AB624
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCB_TankerUsage()
		{
			return this.comboBox_46;
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x001AD43C File Offset: 0x001AB63C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_421(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_153);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_46;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_46 = comboBox_117;
			comboBox = this.comboBox_46;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x001AD488 File Offset: 0x001AB688
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_422()
		{
			return this.label_82;
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x0002247D File Offset: 0x0002067D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_423(System.Windows.Forms.Label label_194)
		{
			this.label_82 = label_194;
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x001AD4A0 File Offset: 0x001AB6A0
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox GetTB_MaxResponseRadius()
		{
			return this.textBox_19;
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x001AD4B8 File Offset: 0x001AB6B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_425(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_149);
			EventHandler value2 = new EventHandler(this.method_150);
			System.Windows.Forms.TextBox textBox = this.textBox_19;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_19 = textBox_36;
			textBox = this.textBox_19;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x001AD51C File Offset: 0x001AB71C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_426()
		{
			return this.label_83;
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00022486 File Offset: 0x00020686
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_427(System.Windows.Forms.Label label_194)
		{
			this.label_83 = label_194;
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x001AD534 File Offset: 0x001AB734
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox GetTB_MinResponseRadius()
		{
			return this.textBox_20;
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x001AD54C File Offset: 0x001AB74C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_429(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_146);
			EventHandler value2 = new EventHandler(this.method_147);
			System.Windows.Forms.TextBox textBox = this.textBox_20;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_20 = textBox_36;
			textBox = this.textBox_20;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x001AD5B0 File Offset: 0x001AB7B0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_430()
		{
			return this.label_84;
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x0002248F File Offset: 0x0002068F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_431(System.Windows.Forms.Label label_194)
		{
			this.label_84 = label_194;
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x001AD5C8 File Offset: 0x001AB7C8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCB_RadarUsage()
		{
			return this.comboBox_47;
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x001AD5E0 File Offset: 0x001AB7E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_433(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_152);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_47;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_47 = comboBox_117;
			comboBox = this.comboBox_47;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x001AD62C File Offset: 0x001AB82C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_434()
		{
			return this.label_85;
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x00022498 File Offset: 0x00020698
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_435(System.Windows.Forms.Label label_194)
		{
			this.label_85 = label_194;
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x001AD644 File Offset: 0x001AB844
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_436()
		{
			return this.label_86;
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x000224A1 File Offset: 0x000206A1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_437(System.Windows.Forms.Label label_194)
		{
			this.label_86 = label_194;
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x001AD65C File Offset: 0x001AB85C
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCB_PreplannedOnly()
		{
			return this.CB_PreplannedOnly;
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x001AD674 File Offset: 0x001AB874
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCB_PreplannedOnly(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.CB_PreplannedOnly_Click);
			System.Windows.Forms.CheckBox cB_PreplannedOnly = this.CB_PreplannedOnly;
			if (cB_PreplannedOnly != null)
			{
				cB_PreplannedOnly.Click -= value;
			}
			this.CB_PreplannedOnly = checkBox_57;
			cB_PreplannedOnly = this.CB_PreplannedOnly;
			if (cB_PreplannedOnly != null)
			{
				cB_PreplannedOnly.Click += value;
			}
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x001AD6C0 File Offset: 0x001AB8C0
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCB_OneTimeOnly()
		{
			return this.CB_OneTimeOnly;
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x001AD6D8 File Offset: 0x001AB8D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCB_OneTimeOnly(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.CB_OneTimeOnly_Click);
			System.Windows.Forms.CheckBox cB_OneTimeOnly = this.CB_OneTimeOnly;
			if (cB_OneTimeOnly != null)
			{
				cB_OneTimeOnly.Click -= value;
			}
			this.CB_OneTimeOnly = checkBox_57;
			cB_OneTimeOnly = this.CB_OneTimeOnly;
			if (cB_OneTimeOnly != null)
			{
				cB_OneTimeOnly.Click += value;
			}
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x001AD724 File Offset: 0x001AB924
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_442()
		{
			return this.groupBox_10;
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x000224AA File Offset: 0x000206AA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_443(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_10 = groupBox_27;
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x001AD73C File Offset: 0x001AB93C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_444()
		{
			return this.comboBox_48;
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x001AD754 File Offset: 0x001AB954
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_445(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_159);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_48;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_48 = comboBox_117;
			comboBox = this.comboBox_48;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x001AD7A0 File Offset: 0x001AB9A0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_446()
		{
			return this.label_87;
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x000224B3 File Offset: 0x000206B3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_447(System.Windows.Forms.Label label_194)
		{
			this.label_87 = label_194;
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x001AD7B8 File Offset: 0x001AB9B8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_448()
		{
			return this.label_88;
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x000224BC File Offset: 0x000206BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_449(System.Windows.Forms.Label label_194)
		{
			this.label_88 = label_194;
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x001AD7D0 File Offset: 0x001AB9D0
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_450()
		{
			return this.comboBox_49;
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x001AD7E8 File Offset: 0x001AB9E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_451(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_157);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_49;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_49 = comboBox_117;
			comboBox = this.comboBox_49;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x001AD834 File Offset: 0x001ABA34
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_452()
		{
			return this.comboBox_50;
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x001AD84C File Offset: 0x001ABA4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_453(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_158);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_50;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_50 = comboBox_117;
			comboBox = this.comboBox_50;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x001AD898 File Offset: 0x001ABA98
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_454()
		{
			return this.label_89;
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x000224C5 File Offset: 0x000206C5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_455(System.Windows.Forms.Label label_194)
		{
			this.label_89 = label_194;
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x001AD8B0 File Offset: 0x001ABAB0
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCB_UseFlightSizeHardLimit_Strike()
		{
			return this.checkBox_13;
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x001AD8C8 File Offset: 0x001ABAC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_457(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_160);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_13;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_13 = checkBox_57;
			checkBox = this.checkBox_13;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x001AD914 File Offset: 0x001ABB14
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_458()
		{
			return this.checkBox_14;
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x001AD92C File Offset: 0x001ABB2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_459(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_161);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_14;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_14 = checkBox_57;
			checkBox = this.checkBox_14;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x001AD978 File Offset: 0x001ABB78
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_460()
		{
			return this.checkBox_15;
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x001AD990 File Offset: 0x001ABB90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_461(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_162);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_15;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_15 = checkBox_57;
			checkBox = this.checkBox_15;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x001AD9DC File Offset: 0x001ABBDC
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCB_UseFlightSizeHardLimit_Support()
		{
			return this.checkBox_16;
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x001AD9F4 File Offset: 0x001ABBF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_463(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_163);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_16;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_16 = checkBox_57;
			checkBox = this.checkBox_16;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x001ADA40 File Offset: 0x001ABC40
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_464()
		{
			return this.checkBox_17;
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x001ADA58 File Offset: 0x001ABC58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_465(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_164);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_17;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_17 = checkBox_57;
			checkBox = this.checkBox_17;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x001ADAA4 File Offset: 0x001ABCA4
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_466()
		{
			return this.checkBox_18;
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x001ADABC File Offset: 0x001ABCBC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_467(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_165);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_18;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_18 = checkBox_57;
			checkBox = this.checkBox_18;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x001ADB08 File Offset: 0x001ABD08
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_468()
		{
			return this.checkBox_19;
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x001ADB20 File Offset: 0x001ABD20
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_469(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_166);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_19;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_19 = checkBox_57;
			checkBox = this.checkBox_19;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x001ADB6C File Offset: 0x001ABD6C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCB_AttackMethod()
		{
			return this.comboBox_51;
		}

		// Token: 0x0600462D RID: 17965 RVA: 0x001ADB84 File Offset: 0x001ABD84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_471(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_320);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_51;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_51 = comboBox_117;
			comboBox = this.comboBox_51;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x001ADBD0 File Offset: 0x001ABDD0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_472()
		{
			return this.label_90;
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x000224CE File Offset: 0x000206CE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_473(System.Windows.Forms.Label label_194)
		{
			this.label_90 = label_194;
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x001ADBE8 File Offset: 0x001ABDE8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCB_TimeOfDay()
		{
			return this.comboBox_52;
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x001ADC00 File Offset: 0x001ABE00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_475(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_167);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_52;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_52 = comboBox_117;
			comboBox = this.comboBox_52;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x001ADC4C File Offset: 0x001ABE4C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_476()
		{
			return this.label_91;
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x000224D7 File Offset: 0x000206D7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_477(System.Windows.Forms.Label label_194)
		{
			this.label_91 = label_194;
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x001ADC64 File Offset: 0x001ABE64
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCB_Weather()
		{
			return this.comboBox_53;
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x001ADC7C File Offset: 0x001ABE7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_479(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_168);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_53;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_53 = comboBox_117;
			comboBox = this.comboBox_53;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x001ADCC8 File Offset: 0x001ABEC8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_480()
		{
			return this.label_92;
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x000224E0 File Offset: 0x000206E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_481(System.Windows.Forms.Label label_194)
		{
			this.label_92 = label_194;
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x001ADCE0 File Offset: 0x001ABEE0
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_482()
		{
			return this.comboBox_54;
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x000224E9 File Offset: 0x000206E9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_483(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_54 = comboBox_117;
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x001ADCF8 File Offset: 0x001ABEF8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_484()
		{
			return this.label_93;
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x000224F2 File Offset: 0x000206F2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_485(System.Windows.Forms.Label label_194)
		{
			this.label_93 = label_194;
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x001ADD10 File Offset: 0x001ABF10
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_486()
		{
			return this.label_94;
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x000224FB File Offset: 0x000206FB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_487(System.Windows.Forms.Label label_194)
		{
			this.label_94 = label_194;
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x001ADD28 File Offset: 0x001ABF28
		[CompilerGenerated]
		internal  System.Windows.Forms.Label GetLabel_PatrolAttackAltitude_Aircraft()
		{
			return this.label_95;
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x00022504 File Offset: 0x00020704
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_489(System.Windows.Forms.Label label_194)
		{
			this.label_95 = label_194;
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x001ADD40 File Offset: 0x001ABF40
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox GetTB_PatrolAttackAltitude_Aircraft()
		{
			return this.textBox_21;
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x001ADD58 File Offset: 0x001ABF58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_491(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_215);
			EventHandler value2 = new EventHandler(this.method_216);
			System.Windows.Forms.TextBox textBox = this.textBox_21;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_21 = textBox_36;
			textBox = this.textBox_21;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x001ADDBC File Offset: 0x001ABFBC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_492()
		{
			return this.label_96;
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x0002250D File Offset: 0x0002070D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_493(System.Windows.Forms.Label label_194)
		{
			this.label_96 = label_194;
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x001ADDD4 File Offset: 0x001ABFD4
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_PatrolAttackThrottle_Aircraft()
		{
			return this.comboBox_55;
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x001ADDEC File Offset: 0x001ABFEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_495(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_169);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_55;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_55 = comboBox_117;
			comboBox = this.comboBox_55;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x001ADE38 File Offset: 0x001AC038
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCheckBox_PatrolAttackTerrainFollowing_Aircraft()
		{
			return this.checkBox_20;
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x001ADE50 File Offset: 0x001AC050
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_497(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_221);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_20;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_20 = checkBox_57;
			checkBox = this.checkBox_20;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x001ADE9C File Offset: 0x001AC09C
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCheckBox_PatrolStationTerrainFollowing_Aircraft()
		{
			return this.checkBox_21;
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x001ADEB4 File Offset: 0x001AC0B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_499(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_220);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_21;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_21 = checkBox_57;
			checkBox = this.checkBox_21;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x001ADF00 File Offset: 0x001AC100
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCheckBox_PatrolTransitTerrainFollowing_Aircraft()
		{
			return this.checkBox_22;
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x001ADF18 File Offset: 0x001AC118
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_501(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_219);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_22;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_22 = checkBox_57;
			checkBox = this.checkBox_22;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x001ADF64 File Offset: 0x001AC164
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_502()
		{
			return this.checkBox_23;
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x001ADF7C File Offset: 0x001AC17C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_503(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_223);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_23;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_23 = checkBox_57;
			checkBox = this.checkBox_23;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x001ADFC8 File Offset: 0x001AC1C8
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_504()
		{
			return this.checkBox_24;
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x001ADFE0 File Offset: 0x001AC1E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_505(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_222);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_24;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_24 = checkBox_57;
			checkBox = this.checkBox_24;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x001AE02C File Offset: 0x001AC22C
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_506()
		{
			return this.checkBox_25;
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x001AE044 File Offset: 0x001AC244
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_507(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_224);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_25;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_25 = checkBox_57;
			checkBox = this.checkBox_25;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x001AE090 File Offset: 0x001AC290
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_508()
		{
			return this.checkBox_26;
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x001AE0A8 File Offset: 0x001AC2A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_509(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_226);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_26;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_26 = checkBox_57;
			checkBox = this.checkBox_26;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x001AE0F4 File Offset: 0x001AC2F4
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_510()
		{
			return this.checkBox_27;
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x001AE10C File Offset: 0x001AC30C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_511(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_225);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_27;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_27 = checkBox_57;
			checkBox = this.checkBox_27;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x001AE158 File Offset: 0x001AC358
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_512()
		{
			return this.checkBox_28;
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x001AE170 File Offset: 0x001AC370
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_513(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_228);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_28;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_28 = checkBox_57;
			checkBox = this.checkBox_28;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x001AE1BC File Offset: 0x001AC3BC
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_514()
		{
			return this.checkBox_29;
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x001AE1D4 File Offset: 0x001AC3D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_515(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_227);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_29;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_29 = checkBox_57;
			checkBox = this.checkBox_29;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x001AE220 File Offset: 0x001AC420
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_516()
		{
			return this.groupBox_11;
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x00022516 File Offset: 0x00020716
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_517(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_11 = groupBox_27;
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x001AE238 File Offset: 0x001AC438
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_PatrolStationThrottle_Submarine()
		{
			return this.comboBox_56;
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x001AE250 File Offset: 0x001AC450
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_519(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_171);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_56;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_56 = comboBox_117;
			comboBox = this.comboBox_56;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x001AE29C File Offset: 0x001AC49C
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_520()
		{
			return this.textBox_22;
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x001AE2B4 File Offset: 0x001AC4B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_521(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_201);
			EventHandler value2 = new EventHandler(this.method_202);
			System.Windows.Forms.TextBox textBox = this.textBox_22;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_22 = textBox_36;
			textBox = this.textBox_22;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x001AE318 File Offset: 0x001AC518
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_522()
		{
			return this.textBox_23;
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x001AE330 File Offset: 0x001AC530
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_523(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_199);
			EventHandler value2 = new EventHandler(this.method_200);
			System.Windows.Forms.TextBox textBox = this.textBox_23;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_23 = textBox_36;
			textBox = this.textBox_23;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x001AE394 File Offset: 0x001AC594
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_524()
		{
			return this.textBox_24;
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x001AE3AC File Offset: 0x001AC5AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_525(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_197);
			EventHandler value2 = new EventHandler(this.method_198);
			System.Windows.Forms.TextBox textBox = this.textBox_24;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_24 = textBox_36;
			textBox = this.textBox_24;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x001AE410 File Offset: 0x001AC610
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_526()
		{
			return this.label_97;
		}

		// Token: 0x06004665 RID: 18021 RVA: 0x0002251F File Offset: 0x0002071F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_527(System.Windows.Forms.Label label_194)
		{
			this.label_97 = label_194;
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x001AE428 File Offset: 0x001AC628
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_528()
		{
			return this.label_98;
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00022528 File Offset: 0x00020728
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_529(System.Windows.Forms.Label label_194)
		{
			this.label_98 = label_194;
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x001AE440 File Offset: 0x001AC640
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_530()
		{
			return this.label_99;
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x00022531 File Offset: 0x00020731
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_531(System.Windows.Forms.Label label_194)
		{
			this.label_99 = label_194;
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x001AE458 File Offset: 0x001AC658
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_PatrolAttackThrottle_Submarine()
		{
			return this.comboBox_57;
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x001AE470 File Offset: 0x001AC670
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_533(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_172);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_57;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_57 = comboBox_117;
			comboBox = this.comboBox_57;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600466C RID: 18028 RVA: 0x001AE4BC File Offset: 0x001AC6BC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_534()
		{
			return this.label_100;
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x0002253A File Offset: 0x0002073A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_535(System.Windows.Forms.Label label_194)
		{
			this.label_100 = label_194;
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x001AE4D4 File Offset: 0x001AC6D4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_536()
		{
			return this.label_101;
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x00022543 File Offset: 0x00020743
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_537(System.Windows.Forms.Label label_194)
		{
			this.label_101 = label_194;
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x001AE4EC File Offset: 0x001AC6EC
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_PatrolTransitThrottle_Submarine()
		{
			return this.comboBox_58;
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x001AE504 File Offset: 0x001AC704
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_539(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_170);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_58;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_58 = comboBox_117;
			comboBox = this.comboBox_58;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x001AE550 File Offset: 0x001AC750
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_540()
		{
			return this.label_102;
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x0002254C File Offset: 0x0002074C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_541(System.Windows.Forms.Label label_194)
		{
			this.label_102 = label_194;
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x001AE568 File Offset: 0x001AC768
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_542()
		{
			return this.label_103;
		}

		// Token: 0x06004675 RID: 18037 RVA: 0x00022555 File Offset: 0x00020755
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_543(System.Windows.Forms.Label label_194)
		{
			this.label_103 = label_194;
		}

		// Token: 0x06004676 RID: 18038 RVA: 0x001AE580 File Offset: 0x001AC780
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_544()
		{
			return this.label_104;
		}

		// Token: 0x06004677 RID: 18039 RVA: 0x0002255E File Offset: 0x0002075E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_545(System.Windows.Forms.Label label_194)
		{
			this.label_104 = label_194;
		}

		// Token: 0x06004678 RID: 18040 RVA: 0x001AE598 File Offset: 0x001AC798
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_546()
		{
			return this.label_105;
		}

		// Token: 0x06004679 RID: 18041 RVA: 0x00022567 File Offset: 0x00020767
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_547(System.Windows.Forms.Label label_194)
		{
			this.label_105 = label_194;
		}

		// Token: 0x0600467A RID: 18042 RVA: 0x001AE5B0 File Offset: 0x001AC7B0
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_548()
		{
			return this.groupBox_12;
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x00022570 File Offset: 0x00020770
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_549(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_12 = groupBox_27;
		}

		// Token: 0x0600467C RID: 18044 RVA: 0x001AE5C8 File Offset: 0x001AC7C8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_550()
		{
			return this.comboBox_59;
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x001AE5E0 File Offset: 0x001AC7E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_551(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_177);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_59;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_59 = comboBox_117;
			comboBox = this.comboBox_59;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600467E RID: 18046 RVA: 0x001AE62C File Offset: 0x001AC82C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_552()
		{
			return this.label_106;
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x00022579 File Offset: 0x00020779
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_553(System.Windows.Forms.Label label_194)
		{
			this.label_106 = label_194;
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x001AE644 File Offset: 0x001AC844
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_554()
		{
			return this.comboBox_60;
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x001AE65C File Offset: 0x001AC85C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_555(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_178);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_60;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_60 = comboBox_117;
			comboBox = this.comboBox_60;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x001AE6A8 File Offset: 0x001AC8A8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_556()
		{
			return this.label_107;
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x00022582 File Offset: 0x00020782
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_557(System.Windows.Forms.Label label_194)
		{
			this.label_107 = label_194;
		}

		// Token: 0x06004684 RID: 18052 RVA: 0x001AE6C0 File Offset: 0x001AC8C0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_558()
		{
			return this.label_108;
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x0002258B File Offset: 0x0002078B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_559(System.Windows.Forms.Label label_194)
		{
			this.label_108 = label_194;
		}

		// Token: 0x06004686 RID: 18054 RVA: 0x001AE6D8 File Offset: 0x001AC8D8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_560()
		{
			return this.comboBox_61;
		}

		// Token: 0x06004687 RID: 18055 RVA: 0x001AE6F0 File Offset: 0x001AC8F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_561(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_176);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_61;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_61 = comboBox_117;
			comboBox = this.comboBox_61;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x001AE73C File Offset: 0x001AC93C
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_562()
		{
			return this.groupBox_13;
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x00022594 File Offset: 0x00020794
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_563(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_13 = groupBox_27;
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x001AE754 File Offset: 0x001AC954
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_PatrolStationThrottle_Ship()
		{
			return this.comboBox_62;
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x001AE76C File Offset: 0x001AC96C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_565(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_174);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_62;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_62 = comboBox_117;
			comboBox = this.comboBox_62;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600468C RID: 18060 RVA: 0x001AE7B8 File Offset: 0x001AC9B8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_566()
		{
			return this.label_109;
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x0002259D File Offset: 0x0002079D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_567(System.Windows.Forms.Label label_194)
		{
			this.label_109 = label_194;
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x001AE7D0 File Offset: 0x001AC9D0
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_PatrolAttackThrottle_Ship()
		{
			return this.comboBox_63;
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x001AE7E8 File Offset: 0x001AC9E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_569(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_175);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_63;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_63 = comboBox_117;
			comboBox = this.comboBox_63;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x001AE834 File Offset: 0x001ACA34
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_570()
		{
			return this.label_110;
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x000225A6 File Offset: 0x000207A6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_571(System.Windows.Forms.Label label_194)
		{
			this.label_110 = label_194;
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x001AE84C File Offset: 0x001ACA4C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_572()
		{
			return this.label_111;
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x000225AF File Offset: 0x000207AF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_573(System.Windows.Forms.Label label_194)
		{
			this.label_111 = label_194;
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x001AE864 File Offset: 0x001ACA64
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_PatrolTransitThrottle_Ship()
		{
			return this.comboBox_64;
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x001AE87C File Offset: 0x001ACA7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_575(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_173);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_64;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_64 = comboBox_117;
			comboBox = this.comboBox_64;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x001AE8C8 File Offset: 0x001ACAC8
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_576()
		{
			return this.groupBox_14;
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x000225B8 File Offset: 0x000207B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_577(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_14 = groupBox_27;
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x001AE8E0 File Offset: 0x001ACAE0
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox GetTB_SupportTransitDepth_Submarine()
		{
			return this.textBox_25;
		}

		// Token: 0x06004699 RID: 18073 RVA: 0x001AE8F8 File Offset: 0x001ACAF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_579(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_203);
			EventHandler value2 = new EventHandler(this.method_204);
			System.Windows.Forms.TextBox textBox = this.textBox_25;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_25 = textBox_36;
			textBox = this.textBox_25;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x001AE95C File Offset: 0x001ACB5C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_SupportStationThrottle_Submarine()
		{
			return this.comboBox_65;
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x001AE974 File Offset: 0x001ACB74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_581(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_182);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_65;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_65 = comboBox_117;
			comboBox = this.comboBox_65;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x001AE9C0 File Offset: 0x001ACBC0
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_582()
		{
			return this.textBox_26;
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x001AE9D8 File Offset: 0x001ACBD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_583(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_205);
			EventHandler value2 = new EventHandler(this.method_206);
			System.Windows.Forms.TextBox textBox = this.textBox_26;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_26 = textBox_36;
			textBox = this.textBox_26;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x001AEA3C File Offset: 0x001ACC3C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_SupportTransitThrottle_Submarine()
		{
			return this.comboBox_66;
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x001AEA54 File Offset: 0x001ACC54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_585(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_181);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_66;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_66 = comboBox_117;
			comboBox = this.comboBox_66;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x001AEAA0 File Offset: 0x001ACCA0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_586()
		{
			return this.label_112;
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x000225C1 File Offset: 0x000207C1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_587(System.Windows.Forms.Label label_194)
		{
			this.label_112 = label_194;
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x001AEAB8 File Offset: 0x001ACCB8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_588()
		{
			return this.label_113;
		}

		// Token: 0x060046A3 RID: 18083 RVA: 0x000225CA File Offset: 0x000207CA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_589(System.Windows.Forms.Label label_194)
		{
			this.label_113 = label_194;
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x001AEAD0 File Offset: 0x001ACCD0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_590()
		{
			return this.label_114;
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x000225D3 File Offset: 0x000207D3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_591(System.Windows.Forms.Label label_194)
		{
			this.label_114 = label_194;
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x001AEAE8 File Offset: 0x001ACCE8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_592()
		{
			return this.label_115;
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x000225DC File Offset: 0x000207DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_593(System.Windows.Forms.Label label_194)
		{
			this.label_115 = label_194;
		}

		// Token: 0x060046A8 RID: 18088 RVA: 0x001AEB00 File Offset: 0x001ACD00
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_594()
		{
			return this.label_116;
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x000225E5 File Offset: 0x000207E5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_595(System.Windows.Forms.Label label_194)
		{
			this.label_116 = label_194;
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x001AEB18 File Offset: 0x001ACD18
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_596()
		{
			return this.label_117;
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x000225EE File Offset: 0x000207EE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_597(System.Windows.Forms.Label label_194)
		{
			this.label_117 = label_194;
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x001AEB30 File Offset: 0x001ACD30
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_598()
		{
			return this.groupBox_15;
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x000225F7 File Offset: 0x000207F7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_599(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_15 = groupBox_27;
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x001AEB48 File Offset: 0x001ACD48
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_SupportStationThrottle_Facility()
		{
			return this.comboBox_67;
		}

		// Token: 0x060046AF RID: 18095 RVA: 0x001AEB60 File Offset: 0x001ACD60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_601(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_184);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_67;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_67 = comboBox_117;
			comboBox = this.comboBox_67;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x001AEBAC File Offset: 0x001ACDAC
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_SupportTransitThrottle_Facility()
		{
			return this.comboBox_68;
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x001AEBC4 File Offset: 0x001ACDC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_603(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_183);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_68;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_68 = comboBox_117;
			comboBox = this.comboBox_68;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x001AEC10 File Offset: 0x001ACE10
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_604()
		{
			return this.label_118;
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x00022600 File Offset: 0x00020800
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_605(System.Windows.Forms.Label label_194)
		{
			this.label_118 = label_194;
		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x001AEC28 File Offset: 0x001ACE28
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_606()
		{
			return this.label_119;
		}

		// Token: 0x060046B5 RID: 18101 RVA: 0x00022609 File Offset: 0x00020809
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_607(System.Windows.Forms.Label label_194)
		{
			this.label_119 = label_194;
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x001AEC40 File Offset: 0x001ACE40
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_608()
		{
			return this.groupBox_16;
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x00022612 File Offset: 0x00020812
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_609(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_16 = groupBox_27;
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x001AEC58 File Offset: 0x001ACE58
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_SupportStationThrottle_Ship()
		{
			return this.comboBox_69;
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x001AEC70 File Offset: 0x001ACE70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_611(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_180);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_69;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_69 = comboBox_117;
			comboBox = this.comboBox_69;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046BA RID: 18106 RVA: 0x001AECBC File Offset: 0x001ACEBC
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_SupportTransitThrottle_Ship()
		{
			return this.comboBox_70;
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x001AECD4 File Offset: 0x001ACED4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_613(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_179);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_70;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_70 = comboBox_117;
			comboBox = this.comboBox_70;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046BC RID: 18108 RVA: 0x001AED20 File Offset: 0x001ACF20
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_614()
		{
			return this.label_120;
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x0002261B File Offset: 0x0002081B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_615(System.Windows.Forms.Label label_194)
		{
			this.label_120 = label_194;
		}

		// Token: 0x060046BE RID: 18110 RVA: 0x001AED38 File Offset: 0x001ACF38
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_616()
		{
			return this.label_121;
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x00022624 File Offset: 0x00020824
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_617(System.Windows.Forms.Label label_194)
		{
			this.label_121 = label_194;
		}

		// Token: 0x060046C0 RID: 18112 RVA: 0x001AED50 File Offset: 0x001ACF50
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_618()
		{
			return this.checkBox_30;
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x001AED68 File Offset: 0x001ACF68
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_619(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_218);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_30;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_30 = checkBox_57;
			checkBox = this.checkBox_30;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060046C2 RID: 18114 RVA: 0x001AEDB4 File Offset: 0x001ACFB4
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_620()
		{
			return this.checkBox_31;
		}

		// Token: 0x060046C3 RID: 18115 RVA: 0x001AEDCC File Offset: 0x001ACFCC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_621(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_217);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_31;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_31 = checkBox_57;
			checkBox = this.checkBox_31;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x001AEE18 File Offset: 0x001AD018
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_622()
		{
			return this.groupBox_17;
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x0002262D File Offset: 0x0002082D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_623(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_17 = groupBox_27;
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x001AEE30 File Offset: 0x001AD030
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_624()
		{
			return this.comboBox_71;
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x001AEE48 File Offset: 0x001AD048
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_625(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_190);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_71;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_71 = comboBox_117;
			comboBox = this.comboBox_71;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x001AEE94 File Offset: 0x001AD094
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_626()
		{
			return this.label_122;
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x00022636 File Offset: 0x00020836
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_627(System.Windows.Forms.Label label_194)
		{
			this.label_122 = label_194;
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x001AEEAC File Offset: 0x001AD0AC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_628()
		{
			return this.label_123;
		}

		// Token: 0x060046CB RID: 18123 RVA: 0x0002263F File Offset: 0x0002083F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_629(System.Windows.Forms.Label label_194)
		{
			this.label_123 = label_194;
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x001AEEC4 File Offset: 0x001AD0C4
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MiningTransitThrottle_Facility()
		{
			return this.comboBox_72;
		}

		// Token: 0x060046CD RID: 18125 RVA: 0x001AEEDC File Offset: 0x001AD0DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_631(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_189);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_72;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_72 = comboBox_117;
			comboBox = this.comboBox_72;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046CE RID: 18126 RVA: 0x001AEF28 File Offset: 0x001AD128
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_632()
		{
			return this.groupBox_18;
		}

		// Token: 0x060046CF RID: 18127 RVA: 0x00022648 File Offset: 0x00020848
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_633(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_18 = groupBox_27;
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x001AEF40 File Offset: 0x001AD140
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MiningStationThrottle_Ship()
		{
			return this.comboBox_73;
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x001AEF58 File Offset: 0x001AD158
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_635(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_188);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_73;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_73 = comboBox_117;
			comboBox = this.comboBox_73;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x001AEFA4 File Offset: 0x001AD1A4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_636()
		{
			return this.label_124;
		}

		// Token: 0x060046D3 RID: 18131 RVA: 0x00022651 File Offset: 0x00020851
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_637(System.Windows.Forms.Label label_194)
		{
			this.label_124 = label_194;
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x001AEFBC File Offset: 0x001AD1BC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_638()
		{
			return this.label_125;
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x0002265A File Offset: 0x0002085A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_639(System.Windows.Forms.Label label_194)
		{
			this.label_125 = label_194;
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x001AEFD4 File Offset: 0x001AD1D4
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MiningTransitThrottle_Ship()
		{
			return this.comboBox_74;
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x001AEFEC File Offset: 0x001AD1EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_641(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_187);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_74;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_74 = comboBox_117;
			comboBox = this.comboBox_74;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x001AF038 File Offset: 0x001AD238
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_642()
		{
			return this.groupBox_19;
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x00022663 File Offset: 0x00020863
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_643(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_19 = groupBox_27;
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x001AF050 File Offset: 0x001AD250
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_644()
		{
			return this.textBox_27;
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x001AF068 File Offset: 0x001AD268
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_645(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_209);
			EventHandler value2 = new EventHandler(this.method_210);
			System.Windows.Forms.TextBox textBox = this.textBox_27;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_27 = textBox_36;
			textBox = this.textBox_27;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x001AF0CC File Offset: 0x001AD2CC
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_646()
		{
			return this.textBox_28;
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x001AF0E4 File Offset: 0x001AD2E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_647(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_207);
			EventHandler value2 = new EventHandler(this.method_208);
			System.Windows.Forms.TextBox textBox = this.textBox_28;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_28 = textBox_36;
			textBox = this.textBox_28;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x001AF148 File Offset: 0x001AD348
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MiningStationThrottle_Submarine()
		{
			return this.comboBox_75;
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x001AF160 File Offset: 0x001AD360
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_649(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_186);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_75;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_75 = comboBox_117;
			comboBox = this.comboBox_75;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x001AF1AC File Offset: 0x001AD3AC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_650()
		{
			return this.label_126;
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x0002266C File Offset: 0x0002086C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_651(System.Windows.Forms.Label label_194)
		{
			this.label_126 = label_194;
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x001AF1C4 File Offset: 0x001AD3C4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_652()
		{
			return this.label_127;
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x00022675 File Offset: 0x00020875
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_653(System.Windows.Forms.Label label_194)
		{
			this.label_127 = label_194;
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x001AF1DC File Offset: 0x001AD3DC
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MiningTransitThrottle_Submarine()
		{
			return this.comboBox_76;
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x001AF1F4 File Offset: 0x001AD3F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_655(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_185);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_76;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_76 = comboBox_117;
			comboBox = this.comboBox_76;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x001AF240 File Offset: 0x001AD440
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_656()
		{
			return this.label_128;
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x0002267E File Offset: 0x0002087E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_657(System.Windows.Forms.Label label_194)
		{
			this.label_128 = label_194;
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x001AF258 File Offset: 0x001AD458
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_658()
		{
			return this.label_129;
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x00022687 File Offset: 0x00020887
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_659(System.Windows.Forms.Label label_194)
		{
			this.label_129 = label_194;
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x001AF270 File Offset: 0x001AD470
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_660()
		{
			return this.label_130;
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x00022690 File Offset: 0x00020890
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_661(System.Windows.Forms.Label label_194)
		{
			this.label_130 = label_194;
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x001AF288 File Offset: 0x001AD488
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_662()
		{
			return this.label_131;
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x00022699 File Offset: 0x00020899
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_663(System.Windows.Forms.Label label_194)
		{
			this.label_131 = label_194;
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x001AF2A0 File Offset: 0x001AD4A0
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_664()
		{
			return this.groupBox_20;
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x000226A2 File Offset: 0x000208A2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_665(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_20 = groupBox_27;
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x001AF2B8 File Offset: 0x001AD4B8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MineClearingStationThrottle_Facility()
		{
			return this.comboBox_77;
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x001AF2D0 File Offset: 0x001AD4D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_667(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_196);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_77;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_77 = comboBox_117;
			comboBox = this.comboBox_77;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x001AF31C File Offset: 0x001AD51C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_668()
		{
			return this.label_132;
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x000226AB File Offset: 0x000208AB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_669(System.Windows.Forms.Label label_194)
		{
			this.label_132 = label_194;
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x001AF334 File Offset: 0x001AD534
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_670()
		{
			return this.label_133;
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x000226B4 File Offset: 0x000208B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_671(System.Windows.Forms.Label label_194)
		{
			this.label_133 = label_194;
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x001AF34C File Offset: 0x001AD54C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MineClearingTransitThrottle_Facility()
		{
			return this.comboBox_78;
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x001AF364 File Offset: 0x001AD564
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_673(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_195);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_78;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_78 = comboBox_117;
			comboBox = this.comboBox_78;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x001AF3B0 File Offset: 0x001AD5B0
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_674()
		{
			return this.groupBox_21;
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x000226BD File Offset: 0x000208BD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_675(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_21 = groupBox_27;
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x001AF3C8 File Offset: 0x001AD5C8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MineClearingStationThrottle_Ship()
		{
			return this.comboBox_79;
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x001AF3E0 File Offset: 0x001AD5E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_677(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_194);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_79;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_79 = comboBox_117;
			comboBox = this.comboBox_79;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x001AF42C File Offset: 0x001AD62C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_678()
		{
			return this.label_134;
		}

		// Token: 0x060046FD RID: 18173 RVA: 0x000226C6 File Offset: 0x000208C6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_679(System.Windows.Forms.Label label_194)
		{
			this.label_134 = label_194;
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x001AF444 File Offset: 0x001AD644
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_680()
		{
			return this.label_135;
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x000226CF File Offset: 0x000208CF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_681(System.Windows.Forms.Label label_194)
		{
			this.label_135 = label_194;
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x001AF45C File Offset: 0x001AD65C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MineClearingTransitThrottle_Ship()
		{
			return this.comboBox_80;
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x001AF474 File Offset: 0x001AD674
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_683(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_193);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_80;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_80 = comboBox_117;
			comboBox = this.comboBox_80;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x001AF4C0 File Offset: 0x001AD6C0
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox vmethod_684()
		{
			return this.groupBox_22;
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x000226D8 File Offset: 0x000208D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_685(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_22 = groupBox_27;
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x001AF4D8 File Offset: 0x001AD6D8
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_686()
		{
			return this.textBox_29;
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x001AF4F0 File Offset: 0x001AD6F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_687(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_213);
			EventHandler value2 = new EventHandler(this.method_214);
			System.Windows.Forms.TextBox textBox = this.textBox_29;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_29 = textBox_36;
			textBox = this.textBox_29;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x001AF554 File Offset: 0x001AD754
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_688()
		{
			return this.textBox_30;
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x001AF56C File Offset: 0x001AD76C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_689(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_211);
			EventHandler value2 = new EventHandler(this.method_212);
			System.Windows.Forms.TextBox textBox = this.textBox_30;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_30 = textBox_36;
			textBox = this.textBox_30;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x001AF5D0 File Offset: 0x001AD7D0
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MineClearingStationThrottle_Submarine()
		{
			return this.comboBox_81;
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x001AF5E8 File Offset: 0x001AD7E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_691(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_192);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_81;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_81 = comboBox_117;
			comboBox = this.comboBox_81;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x001AF634 File Offset: 0x001AD834
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_692()
		{
			return this.label_136;
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x000226E1 File Offset: 0x000208E1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_693(System.Windows.Forms.Label label_194)
		{
			this.label_136 = label_194;
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x001AF64C File Offset: 0x001AD84C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_694()
		{
			return this.label_137;
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x000226EA File Offset: 0x000208EA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_695(System.Windows.Forms.Label label_194)
		{
			this.label_137 = label_194;
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x001AF664 File Offset: 0x001AD864
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCombo_MineClearingTransitThrottle_Submarine()
		{
			return this.comboBox_82;
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x001AF67C File Offset: 0x001AD87C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_697(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_191);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_82;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_82 = comboBox_117;
			comboBox = this.comboBox_82;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x001AF6C8 File Offset: 0x001AD8C8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_698()
		{
			return this.label_138;
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x000226F3 File Offset: 0x000208F3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_699(System.Windows.Forms.Label label_194)
		{
			this.label_138 = label_194;
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x001AF6E0 File Offset: 0x001AD8E0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_700()
		{
			return this.label_139;
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x000226FC File Offset: 0x000208FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_701(System.Windows.Forms.Label label_194)
		{
			this.label_139 = label_194;
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x001AF6F8 File Offset: 0x001AD8F8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_702()
		{
			return this.label_140;
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x00022705 File Offset: 0x00020905
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_703(System.Windows.Forms.Label label_194)
		{
			this.label_140 = label_194;
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x001AF710 File Offset: 0x001AD910
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_704()
		{
			return this.label_141;
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x0002270E File Offset: 0x0002090E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_705(System.Windows.Forms.Label label_194)
		{
			this.label_141 = label_194;
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x001AF728 File Offset: 0x001AD928
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox GetGroupBox_ActivationTime()
		{
			return this.groupBox_23;
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x00022717 File Offset: 0x00020917
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_707(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_23 = groupBox_27;
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x001AF740 File Offset: 0x001AD940
		[CompilerGenerated]
		internal  DateTimePicker GetDateTimePicker_ActivationTime()
		{
			return this.dateTimePicker_0;
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x001AF758 File Offset: 0x001AD958
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_709(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_231);
			EventHandler value2 = new EventHandler(this.method_232);
			DateTimePicker dateTimePicker = this.dateTimePicker_0;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
			}
			this.dateTimePicker_0 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_0;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
			}
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x001AF7BC File Offset: 0x001AD9BC
		[CompilerGenerated]
		internal  DateTimePicker GetDateTimePicker_ActivationDate()
		{
			return this.DateTimePicker_ActivationDate;
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x001AF7D4 File Offset: 0x001AD9D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetDateTimePicker_ActivationDate(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.DateTimePicker_ActivationDate_Enter);
			EventHandler value2 = new EventHandler(this.DateTimePicker_ActivationDate_Leave);
			EventHandler value3 = new EventHandler(this.DateTimePicker_ActivationDate_DropDown);
			EventHandler value4 = new EventHandler(this.DateTimePicker_ActivationDate_CloseUp);
			DateTimePicker dateTimePicker_ActivationDate = this.DateTimePicker_ActivationDate;
			if (dateTimePicker_ActivationDate != null)
			{
				dateTimePicker_ActivationDate.Enter -= value;
				dateTimePicker_ActivationDate.Leave -= value2;
				dateTimePicker_ActivationDate.DropDown -= value3;
				dateTimePicker_ActivationDate.CloseUp -= value4;
			}
			this.DateTimePicker_ActivationDate = dateTimePicker_8;
			dateTimePicker_ActivationDate = this.DateTimePicker_ActivationDate;
			if (dateTimePicker_ActivationDate != null)
			{
				dateTimePicker_ActivationDate.Enter += value;
				dateTimePicker_ActivationDate.Leave += value2;
				dateTimePicker_ActivationDate.DropDown += value3;
				dateTimePicker_ActivationDate.CloseUp += value4;
			}
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x001AF87C File Offset: 0x001ADA7C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_712()
		{
			return this.label_142;
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x00022720 File Offset: 0x00020920
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_713(System.Windows.Forms.Label label_194)
		{
			this.label_142 = label_194;
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x001AF894 File Offset: 0x001ADA94
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_714()
		{
			return this.label_143;
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x00022729 File Offset: 0x00020929
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_715(System.Windows.Forms.Label label_194)
		{
			this.label_143 = label_194;
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x001AF8AC File Offset: 0x001ADAAC
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox GetGroupBox_DeactivationTime()
		{
			return this.groupBox_24;
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x00022732 File Offset: 0x00020932
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_717(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_24 = groupBox_27;
		}

		// Token: 0x06004724 RID: 18212 RVA: 0x001AF8C4 File Offset: 0x001ADAC4
		[CompilerGenerated]
		internal  DateTimePicker GetDateTimePicker_DeactivationTime()
		{
			return this.dateTimePicker_2;
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x001AF8DC File Offset: 0x001ADADC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_719(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_235);
			EventHandler value2 = new EventHandler(this.method_236);
			DateTimePicker dateTimePicker = this.dateTimePicker_2;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
			}
			this.dateTimePicker_2 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_2;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
			}
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x001AF940 File Offset: 0x001ADB40
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_720()
		{
			return this.label_144;
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x0002273B File Offset: 0x0002093B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_721(System.Windows.Forms.Label label_194)
		{
			this.label_144 = label_194;
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x001AF958 File Offset: 0x001ADB58
		[CompilerGenerated]
		internal  DateTimePicker GetDateTimePicker_DeactivationDate()
		{
			return this.dateTimePicker_3;
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x001AF970 File Offset: 0x001ADB70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_723(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_233);
			EventHandler value2 = new EventHandler(this.method_234);
			EventHandler value3 = new EventHandler(this.method_258);
			EventHandler value4 = new EventHandler(this.method_260);
			DateTimePicker dateTimePicker = this.dateTimePicker_3;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
				dateTimePicker.DropDown -= value3;
				dateTimePicker.CloseUp -= value4;
			}
			this.dateTimePicker_3 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_3;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
				dateTimePicker.DropDown += value3;
				dateTimePicker.CloseUp += value4;
			}
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x001AFA18 File Offset: 0x001ADC18
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_724()
		{
			return this.label_145;
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x00022744 File Offset: 0x00020944
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_725(System.Windows.Forms.Label label_194)
		{
			this.label_145 = label_194;
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x001AFA30 File Offset: 0x001ADC30
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_726()
		{
			return this.button_12;
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x001AFA48 File Offset: 0x001ADC48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_727(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_263);
			System.Windows.Forms.Button button = this.button_12;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_12 = button_38;
			button = this.button_12;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x001AFA94 File Offset: 0x001ADC94
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_728()
		{
			return this.button_13;
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x001AFAAC File Offset: 0x001ADCAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_729(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_264);
			System.Windows.Forms.Button button = this.button_13;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_13 = button_38;
			button = this.button_13;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x001AFAF8 File Offset: 0x001ADCF8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_730()
		{
			return this.comboBox_83;
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x001AFB10 File Offset: 0x001ADD10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_731(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_269);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_83;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_83 = comboBox_117;
			comboBox = this.comboBox_83;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x001AFB5C File Offset: 0x001ADD5C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_732()
		{
			return this.label_146;
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x0002274D File Offset: 0x0002094D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_733(System.Windows.Forms.Label label_194)
		{
			this.label_146 = label_194;
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x001AFB74 File Offset: 0x001ADD74
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_734()
		{
			return this.button_14;
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x001AFB8C File Offset: 0x001ADD8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_735(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_265);
			System.Windows.Forms.Button button = this.button_14;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_14 = button_38;
			button = this.button_14;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x001AFBD8 File Offset: 0x001ADDD8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCB_TankerUsage_Support()
		{
			return this.comboBox_84;
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x001AFBF0 File Offset: 0x001ADDF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_737(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_270);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_84;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_84 = comboBox_117;
			comboBox = this.comboBox_84;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x001AFC3C File Offset: 0x001ADE3C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_738()
		{
			return this.label_147;
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x00022756 File Offset: 0x00020956
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_739(System.Windows.Forms.Label label_194)
		{
			this.label_147 = label_194;
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x001AFC54 File Offset: 0x001ADE54
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_740()
		{
			return this.button_15;
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x001AFC6C File Offset: 0x001ADE6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_741(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_266);
			System.Windows.Forms.Button button = this.button_15;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_15 = button_38;
			button = this.button_15;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x001AFCB8 File Offset: 0x001ADEB8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_742()
		{
			return this.comboBox_85;
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x001AFCD0 File Offset: 0x001ADED0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_743(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_271);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_85;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_85 = comboBox_117;
			comboBox = this.comboBox_85;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x001AFD1C File Offset: 0x001ADF1C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_744()
		{
			return this.label_148;
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x0002275F File Offset: 0x0002095F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_745(System.Windows.Forms.Label label_194)
		{
			this.label_148 = label_194;
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x001AFD34 File Offset: 0x001ADF34
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_746()
		{
			return this.button_16;
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x001AFD4C File Offset: 0x001ADF4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_747(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_267);
			System.Windows.Forms.Button button = this.button_16;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_16 = button_38;
			button = this.button_16;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004742 RID: 18242 RVA: 0x001AFD98 File Offset: 0x001ADF98
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_748()
		{
			return this.comboBox_86;
		}

		// Token: 0x06004743 RID: 18243 RVA: 0x001AFDB0 File Offset: 0x001ADFB0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_749(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_272);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_86;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_86 = comboBox_117;
			comboBox = this.comboBox_86;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x001AFDFC File Offset: 0x001ADFFC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_750()
		{
			return this.label_149;
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x00022768 File Offset: 0x00020968
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_751(System.Windows.Forms.Label label_194)
		{
			this.label_149 = label_194;
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x001AFE14 File Offset: 0x001AE014
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_752()
		{
			return this.button_17;
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x001AFE2C File Offset: 0x001AE02C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_753(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_268);
			System.Windows.Forms.Button button = this.button_17;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_17 = button_38;
			button = this.button_17;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x001AFE78 File Offset: 0x001AE078
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_754()
		{
			return this.comboBox_87;
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x001AFE90 File Offset: 0x001AE090
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_755(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_273);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_87;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_87 = comboBox_117;
			comboBox = this.comboBox_87;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x001AFEDC File Offset: 0x001AE0DC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_756()
		{
			return this.label_150;
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x00022771 File Offset: 0x00020971
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_757(System.Windows.Forms.Label label_194)
		{
			this.label_150 = label_194;
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x001AFEF4 File Offset: 0x001AE0F4
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_Clear_ActivationTime()
		{
			return this.button_18;
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x001AFF0C File Offset: 0x001AE10C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_759(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_253);
			System.Windows.Forms.Button button = this.button_18;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_18 = button_38;
			button = this.button_18;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x001AFF58 File Offset: 0x001AE158
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_Clear_DeactivationTime()
		{
			return this.button_19;
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x001AFF70 File Offset: 0x001AE170
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_761(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_254);
			System.Windows.Forms.Button button = this.button_19;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_19 = button_38;
			button = this.button_19;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x001AFFBC File Offset: 0x001AE1BC
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_762()
		{
			return this.comboBox_88;
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x0002277A File Offset: 0x0002097A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_763(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_88 = comboBox_117;
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x001AFFD4 File Offset: 0x001AE1D4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_764()
		{
			return this.label_151;
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x00022783 File Offset: 0x00020983
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_765(System.Windows.Forms.Label label_194)
		{
			this.label_151 = label_194;
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x001AFFEC File Offset: 0x001AE1EC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_766()
		{
			return this.label_152;
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x0002278C File Offset: 0x0002098C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_767(System.Windows.Forms.Label label_194)
		{
			this.label_152 = label_194;
		}

		// Token: 0x06004756 RID: 18262 RVA: 0x001B0004 File Offset: 0x001AE204
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_768()
		{
			return this.comboBox_89;
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x00022795 File Offset: 0x00020995
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_769(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_89 = comboBox_117;
		}

		// Token: 0x06004758 RID: 18264 RVA: 0x001B001C File Offset: 0x001AE21C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCB_TimeOfDay_Support()
		{
			return this.comboBox_90;
		}

		// Token: 0x06004759 RID: 18265 RVA: 0x0002279E File Offset: 0x0002099E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_771(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_90 = comboBox_117;
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x001B0034 File Offset: 0x001AE234
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_772()
		{
			return this.label_153;
		}

		// Token: 0x0600475B RID: 18267 RVA: 0x000227A7 File Offset: 0x000209A7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_773(System.Windows.Forms.Label label_194)
		{
			this.label_153 = label_194;
		}

		// Token: 0x0600475C RID: 18268 RVA: 0x001B004C File Offset: 0x001AE24C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_774()
		{
			return this.label_154;
		}

		// Token: 0x0600475D RID: 18269 RVA: 0x000227B0 File Offset: 0x000209B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_775(System.Windows.Forms.Label label_194)
		{
			this.label_154 = label_194;
		}

		// Token: 0x0600475E RID: 18270 RVA: 0x001B0064 File Offset: 0x001AE264
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCB_Weather_Support()
		{
			return this.comboBox_91;
		}

		// Token: 0x0600475F RID: 18271 RVA: 0x000227B9 File Offset: 0x000209B9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_777(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_91 = comboBox_117;
		}

		// Token: 0x06004760 RID: 18272 RVA: 0x001B007C File Offset: 0x001AE27C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_778()
		{
			return this.comboBox_92;
		}

		// Token: 0x06004761 RID: 18273 RVA: 0x000227C2 File Offset: 0x000209C2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_779(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_92 = comboBox_117;
		}

		// Token: 0x06004762 RID: 18274 RVA: 0x001B0094 File Offset: 0x001AE294
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_780()
		{
			return this.label_155;
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x000227CB File Offset: 0x000209CB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_781(System.Windows.Forms.Label label_194)
		{
			this.label_155 = label_194;
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x001B00AC File Offset: 0x001AE2AC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_782()
		{
			return this.label_156;
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x000227D4 File Offset: 0x000209D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_783(System.Windows.Forms.Label label_194)
		{
			this.label_156 = label_194;
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x001B00C4 File Offset: 0x001AE2C4
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_784()
		{
			return this.comboBox_93;
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x000227DD File Offset: 0x000209DD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_785(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_93 = comboBox_117;
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x001B00DC File Offset: 0x001AE2DC
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_786()
		{
			return this.comboBox_94;
		}

		// Token: 0x06004769 RID: 18281 RVA: 0x000227E6 File Offset: 0x000209E6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_787(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_94 = comboBox_117;
		}

		// Token: 0x0600476A RID: 18282 RVA: 0x001B00F4 File Offset: 0x001AE2F4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_788()
		{
			return this.label_157;
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x000227EF File Offset: 0x000209EF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_789(System.Windows.Forms.Label label_194)
		{
			this.label_157 = label_194;
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x001B010C File Offset: 0x001AE30C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_790()
		{
			return this.label_158;
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x000227F8 File Offset: 0x000209F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_791(System.Windows.Forms.Label label_194)
		{
			this.label_158 = label_194;
		}

		// Token: 0x0600476E RID: 18286 RVA: 0x001B0124 File Offset: 0x001AE324
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_792()
		{
			return this.comboBox_95;
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x00022801 File Offset: 0x00020A01
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_793(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_95 = comboBox_117;
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x001B013C File Offset: 0x001AE33C
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_794()
		{
			return this.comboBox_96;
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x0002280A File Offset: 0x00020A0A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_795(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_96 = comboBox_117;
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x001B0154 File Offset: 0x001AE354
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_796()
		{
			return this.label_159;
		}

		// Token: 0x06004773 RID: 18291 RVA: 0x00022813 File Offset: 0x00020A13
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_797(System.Windows.Forms.Label label_194)
		{
			this.label_159 = label_194;
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x001B016C File Offset: 0x001AE36C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_798()
		{
			return this.label_160;
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x0002281C File Offset: 0x00020A1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_799(System.Windows.Forms.Label label_194)
		{
			this.label_160 = label_194;
		}

		// Token: 0x06004776 RID: 18294 RVA: 0x001B0184 File Offset: 0x001AE384
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_800()
		{
			return this.comboBox_97;
		}

		// Token: 0x06004777 RID: 18295 RVA: 0x00022825 File Offset: 0x00020A25
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_801(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_97 = comboBox_117;
		}

		// Token: 0x06004778 RID: 18296 RVA: 0x001B019C File Offset: 0x001AE39C
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCB_OneA2AR()
		{
			return this.checkBox_32;
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x001B01B4 File Offset: 0x001AE3B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_803(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_283);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_32;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_32 = checkBox_57;
			checkBox = this.checkBox_32;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x001B0200 File Offset: 0x001AE400
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_804()
		{
			return this.textBox_31;
		}

		// Token: 0x0600477B RID: 18299 RVA: 0x001B0218 File Offset: 0x001AE418
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_805(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_277);
			EventHandler value2 = new EventHandler(this.method_278);
			System.Windows.Forms.TextBox textBox = this.textBox_31;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_31 = textBox_36;
			textBox = this.textBox_31;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x001B027C File Offset: 0x001AE47C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_806()
		{
			return this.label_161;
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x0002282E File Offset: 0x00020A2E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_807(System.Windows.Forms.Label label_194)
		{
			this.label_161 = label_194;
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x001B0294 File Offset: 0x001AE494
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_808()
		{
			return this.label_162;
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x00022837 File Offset: 0x00020A37
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_809(System.Windows.Forms.Label label_194)
		{
			this.label_162 = label_194;
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x001B02AC File Offset: 0x001AE4AC
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox GetTB_PatrolAttackDistance_Aircraft()
		{
			return this.textBox_32;
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x001B02C4 File Offset: 0x001AE4C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_811(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_274);
			EventHandler value2 = new EventHandler(this.method_275);
			System.Windows.Forms.TextBox textBox = this.textBox_32;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_32 = textBox_36;
			textBox = this.textBox_32;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x001B0328 File Offset: 0x001AE528
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_812()
		{
			return this.label_163;
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x00022840 File Offset: 0x00020A40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_813(System.Windows.Forms.Label label_194)
		{
			this.label_163 = label_194;
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x001B0340 File Offset: 0x001AE540
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_814()
		{
			return this.label_164;
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x00022849 File Offset: 0x00020A49
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_815(System.Windows.Forms.Label label_194)
		{
			this.label_164 = label_194;
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x001B0358 File Offset: 0x001AE558
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_816()
		{
			return this.textBox_33;
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x00022852 File Offset: 0x00020A52
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_817(System.Windows.Forms.TextBox textBox_36)
		{
			this.textBox_33 = textBox_36;
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x001B0370 File Offset: 0x001AE570
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_818()
		{
			return this.label_165;
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x0002285B File Offset: 0x00020A5B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_819(System.Windows.Forms.Label label_194)
		{
			this.label_165 = label_194;
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x001B0388 File Offset: 0x001AE588
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_820()
		{
			return this.label_166;
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x00022864 File Offset: 0x00020A64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_821(System.Windows.Forms.Label label_194)
		{
			this.label_166 = label_194;
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x001B03A0 File Offset: 0x001AE5A0
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox GetTB_PatrolAttackDistance_Ship()
		{
			return this.textBox_34;
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x001B03B8 File Offset: 0x001AE5B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_823(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_280);
			EventHandler value2 = new EventHandler(this.method_281);
			System.Windows.Forms.TextBox textBox = this.textBox_34;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_34 = textBox_36;
			textBox = this.textBox_34;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x001B041C File Offset: 0x001AE61C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_824()
		{
			return this.label_167;
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x0002286D File Offset: 0x00020A6D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_825(System.Windows.Forms.Label label_194)
		{
			this.label_167 = label_194;
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x001B0434 File Offset: 0x001AE634
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_826()
		{
			return this.label_168;
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x00022876 File Offset: 0x00020A76
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_827(System.Windows.Forms.Label label_194)
		{
			this.label_168 = label_194;
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x001B044C File Offset: 0x001AE64C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_828()
		{
			return this.label_169;
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x0002287F File Offset: 0x00020A7F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_829(System.Windows.Forms.Label label_194)
		{
			this.label_169 = label_194;
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x001B0464 File Offset: 0x001AE664
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox GetTB_NumberOfReceiversA2AR()
		{
			return this.textBox_35;
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x001B047C File Offset: 0x001AE67C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_831(System.Windows.Forms.TextBox textBox_36)
		{
			EventHandler value = new EventHandler(this.method_284);
			EventHandler value2 = new EventHandler(this.method_285);
			System.Windows.Forms.TextBox textBox = this.textBox_35;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_35 = textBox_36;
			textBox = this.textBox_35;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x001B04E0 File Offset: 0x001AE6E0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_832()
		{
			return this.label_170;
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x00022888 File Offset: 0x00020A88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_833(System.Windows.Forms.Label label_194)
		{
			this.label_170 = label_194;
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x001B04F8 File Offset: 0x001AE6F8
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCB_UseGroupSizeHardLimit_Strike()
		{
			return this.checkBox_33;
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x001B0510 File Offset: 0x001AE710
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_835(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_288);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_33;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_33 = checkBox_57;
			checkBox = this.checkBox_33;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x001B055C File Offset: 0x001AE75C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_836()
		{
			return this.label_171;
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x00022891 File Offset: 0x00020A91
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_837(System.Windows.Forms.Label label_194)
		{
			this.label_171 = label_194;
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x001B0574 File Offset: 0x001AE774
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_GroupSize_Strike()
		{
			return this.comboBox_98;
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x001B058C File Offset: 0x001AE78C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_839(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_287);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_98;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value;
			}
			this.comboBox_98 = comboBox_117;
			comboBox = this.comboBox_98;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x001B05D8 File Offset: 0x001AE7D8
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_840()
		{
			return this.checkBox_34;
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x001B05F0 File Offset: 0x001AE7F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_841(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_290);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_34;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_34 = checkBox_57;
			checkBox = this.checkBox_34;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x001B063C File Offset: 0x001AE83C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_842()
		{
			return this.label_172;
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x0002289A File Offset: 0x00020A9A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_843(System.Windows.Forms.Label label_194)
		{
			this.label_172 = label_194;
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x001B0654 File Offset: 0x001AE854
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_844()
		{
			return this.comboBox_99;
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x001B066C File Offset: 0x001AE86C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_845(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_289);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_99;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_99 = comboBox_117;
			comboBox = this.comboBox_99;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x001B06B8 File Offset: 0x001AE8B8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_846()
		{
			return this.label_173;
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x000228A3 File Offset: 0x00020AA3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_847(System.Windows.Forms.Label label_194)
		{
			this.label_173 = label_194;
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x001B06D0 File Offset: 0x001AE8D0
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_GroupSize_Support()
		{
			return this.comboBox_100;
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x001B06E8 File Offset: 0x001AE8E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_849(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_291);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_100;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_100 = comboBox_117;
			comboBox = this.comboBox_100;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x001B0734 File Offset: 0x001AE934
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_850()
		{
			return this.checkBox_35;
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x001B074C File Offset: 0x001AE94C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_851(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_294);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_35;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_35 = checkBox_57;
			checkBox = this.checkBox_35;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x001B0798 File Offset: 0x001AE998
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_852()
		{
			return this.label_174;
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x000228AC File Offset: 0x00020AAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_853(System.Windows.Forms.Label label_194)
		{
			this.label_174 = label_194;
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x001B07B0 File Offset: 0x001AE9B0
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_854()
		{
			return this.comboBox_101;
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x001B07C8 File Offset: 0x001AE9C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_855(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_293);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_101;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_101 = comboBox_117;
			comboBox = this.comboBox_101;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x001B0814 File Offset: 0x001AEA14
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_856()
		{
			return this.checkBox_36;
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x001B082C File Offset: 0x001AEA2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_857(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_296);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_36;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_36 = checkBox_57;
			checkBox = this.checkBox_36;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x001B0878 File Offset: 0x001AEA78
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_858()
		{
			return this.label_175;
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x000228B5 File Offset: 0x00020AB5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_859(System.Windows.Forms.Label label_194)
		{
			this.label_175 = label_194;
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x001B0890 File Offset: 0x001AEA90
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_860()
		{
			return this.comboBox_102;
		}

		// Token: 0x060047B3 RID: 18355 RVA: 0x001B08A8 File Offset: 0x001AEAA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_861(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_295);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_102;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_102 = comboBox_117;
			comboBox = this.comboBox_102;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x001B08F4 File Offset: 0x001AEAF4
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCB_UseGroupSizeHardLimit_Support()
		{
			return this.checkBox_37;
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x001B090C File Offset: 0x001AEB0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_863(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_292);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_37;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_37 = checkBox_57;
			checkBox = this.checkBox_37;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x001B0958 File Offset: 0x001AEB58
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_864()
		{
			return this.checkBox_38;
		}

		// Token: 0x060047B7 RID: 18359 RVA: 0x001B0970 File Offset: 0x001AEB70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_865(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_298);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_38;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_38 = checkBox_57;
			checkBox = this.checkBox_38;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x001B09BC File Offset: 0x001AEBBC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_866()
		{
			return this.label_176;
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x000228BE File Offset: 0x00020ABE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_867(System.Windows.Forms.Label label_194)
		{
			this.label_176 = label_194;
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x001B09D4 File Offset: 0x001AEBD4
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_868()
		{
			return this.comboBox_103;
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x001B09EC File Offset: 0x001AEBEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_869(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_297);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_103;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_103 = comboBox_117;
			comboBox = this.comboBox_103;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x001B0A38 File Offset: 0x001AEC38
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_870()
		{
			return this.checkBox_39;
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x001B0A50 File Offset: 0x001AEC50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_871(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_299);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_39;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_39 = checkBox_57;
			checkBox = this.checkBox_39;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x001B0A9C File Offset: 0x001AEC9C
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCheckBox_DeleteMission()
		{
			return this.checkBox_40;
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x001B0AB4 File Offset: 0x001AECB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_873(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_316);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_40;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_40 = checkBox_57;
			checkBox = this.checkBox_40;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x001B0B00 File Offset: 0x001AED00
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCheckBox_OrderRTB()
		{
			return this.checkBox_41;
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x001B0B18 File Offset: 0x001AED18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_875(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_315);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_41;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_41 = checkBox_57;
			checkBox = this.checkBox_41;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x001B0B64 File Offset: 0x001AED64
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCheckBox_UnassignUnits()
		{
			return this.checkBox_42;
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x001B0B7C File Offset: 0x001AED7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_877(System.Windows.Forms.CheckBox checkBox_57)
		{
			EventHandler value = new EventHandler(this.method_314);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_42;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_42 = checkBox_57;
			checkBox = this.checkBox_42;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x001B0BC8 File Offset: 0x001AEDC8
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCheckBox_IncludeInATO_Strike()
		{
			return this.checkBox_43;
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x000228C7 File Offset: 0x00020AC7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_879(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_43 = checkBox_57;
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x001B0BE0 File Offset: 0x001AEDE0
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCheckBox_PreGeneratedFlightPlansOnly_Strike()
		{
			return this.checkBox_44;
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x000228D0 File Offset: 0x00020AD0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_881(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_44 = checkBox_57;
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x001B0BF8 File Offset: 0x001AEDF8
		[CompilerGenerated]
		internal  System.Windows.Forms.TabControl vmethod_882()
		{
			return this.tabControl_1;
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x000228D9 File Offset: 0x00020AD9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_883(System.Windows.Forms.TabControl tabControl_8)
		{
			this.tabControl_1 = tabControl_8;
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x001B0C10 File Offset: 0x001AEE10
		[CompilerGenerated]
		internal  TabPage vmethod_884()
		{
			return this.tabPage_9;
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x000228E2 File Offset: 0x00020AE2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_885(TabPage tabPage_25)
		{
			this.tabPage_9 = tabPage_25;
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x001B0C28 File Offset: 0x001AEE28
		[CompilerGenerated]
		internal  TabPage vmethod_886()
		{
			return this.tabPage_10;
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x000228EB File Offset: 0x00020AEB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_887(TabPage tabPage_25)
		{
			this.tabPage_10 = tabPage_25;
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x001B0C40 File Offset: 0x001AEE40
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_ShipFormationAttack_Strike()
		{
			return this.comboBox_104;
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x000228F4 File Offset: 0x00020AF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_889(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_104 = comboBox_117;
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x001B0C58 File Offset: 0x001AEE58
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_ShipFormationCruise_Strike()
		{
			return this.comboBox_105;
		}

		// Token: 0x060047D1 RID: 18385 RVA: 0x000228FD File Offset: 0x00020AFD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_891(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_105 = comboBox_117;
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x001B0C70 File Offset: 0x001AEE70
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_892()
		{
			return this.label_177;
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x00022906 File Offset: 0x00020B06
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_893(System.Windows.Forms.Label label_194)
		{
			this.label_177 = label_194;
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x001B0C88 File Offset: 0x001AEE88
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_894()
		{
			return this.label_178;
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x0002290F File Offset: 0x00020B0F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_895(System.Windows.Forms.Label label_194)
		{
			this.label_178 = label_194;
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x001B0CA0 File Offset: 0x001AEEA0
		[CompilerGenerated]
		internal  System.Windows.Forms.TabControl vmethod_896()
		{
			return this.tabControl_2;
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x00022918 File Offset: 0x00020B18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_897(System.Windows.Forms.TabControl tabControl_8)
		{
			this.tabControl_2 = tabControl_8;
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x001B0CB8 File Offset: 0x001AEEB8
		[CompilerGenerated]
		internal  TabPage vmethod_898()
		{
			return this.tabPage_11;
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x00022921 File Offset: 0x00020B21
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_899(TabPage tabPage_25)
		{
			this.tabPage_11 = tabPage_25;
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x001B0CD0 File Offset: 0x001AEED0
		[CompilerGenerated]
		internal  TabPage vmethod_900()
		{
			return this.tabPage_12;
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x0002292A File Offset: 0x00020B2A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_901(TabPage tabPage_25)
		{
			this.tabPage_12 = tabPage_25;
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x001B0CE8 File Offset: 0x001AEEE8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_902()
		{
			return this.comboBox_106;
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x00022933 File Offset: 0x00020B33
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_903(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_106 = comboBox_117;
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x001B0D00 File Offset: 0x001AEF00
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_904()
		{
			return this.label_179;
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x0002293C File Offset: 0x00020B3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_905(System.Windows.Forms.Label label_194)
		{
			this.label_179 = label_194;
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x001B0D18 File Offset: 0x001AEF18
		[CompilerGenerated]
		internal  TabPage vmethod_906()
		{
			return this.tabPage_13;
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x00022945 File Offset: 0x00020B45
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_907(TabPage tabPage_25)
		{
			this.tabPage_13 = tabPage_25;
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x001B0D30 File Offset: 0x001AEF30
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_908()
		{
			return this.comboBox_107;
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x0002294E File Offset: 0x00020B4E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_909(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_107 = comboBox_117;
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x001B0D48 File Offset: 0x001AEF48
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_910()
		{
			return this.comboBox_108;
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x00022957 File Offset: 0x00020B57
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_911(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_108 = comboBox_117;
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x001B0D60 File Offset: 0x001AEF60
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_912()
		{
			return this.label_180;
		}

		// Token: 0x060047E7 RID: 18407 RVA: 0x00022960 File Offset: 0x00020B60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_913(System.Windows.Forms.Label label_194)
		{
			this.label_180 = label_194;
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x001B0D78 File Offset: 0x001AEF78
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_914()
		{
			return this.label_181;
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x00022969 File Offset: 0x00020B69
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_915(System.Windows.Forms.Label label_194)
		{
			this.label_181 = label_194;
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x001B0D90 File Offset: 0x001AEF90
		[CompilerGenerated]
		internal  ElementHost vmethod_916()
		{
			return this.elementHost_0;
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x00022972 File Offset: 0x00020B72
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_917(ElementHost elementHost_1)
		{
			this.elementHost_0 = elementHost_1;
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x001B0DA8 File Offset: 0x001AEFA8
		[CompilerGenerated]
		internal  System.Windows.Forms.TabControl vmethod_918()
		{
			return this.tabControl_3;
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x0002297B File Offset: 0x00020B7B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_919(System.Windows.Forms.TabControl tabControl_8)
		{
			this.tabControl_3 = tabControl_8;
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x001B0DC0 File Offset: 0x001AEFC0
		[CompilerGenerated]
		internal  TabPage vmethod_920()
		{
			return this.tabPage_14;
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x00022984 File Offset: 0x00020B84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_921(TabPage tabPage_25)
		{
			this.tabPage_14 = tabPage_25;
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x001B0DD8 File Offset: 0x001AEFD8
		[CompilerGenerated]
		internal  TabPage vmethod_922()
		{
			return this.tabPage_15;
		}

		// Token: 0x060047F1 RID: 18417 RVA: 0x0002298D File Offset: 0x00020B8D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_923(TabPage tabPage_25)
		{
			this.tabPage_15 = tabPage_25;
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x001B0DF0 File Offset: 0x001AEFF0
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_924()
		{
			return this.comboBox_109;
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x00022996 File Offset: 0x00020B96
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_925(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_109 = comboBox_117;
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x001B0E08 File Offset: 0x001AF008
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_926()
		{
			return this.comboBox_110;
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x0002299F File Offset: 0x00020B9F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_927(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_110 = comboBox_117;
		}

		// Token: 0x060047F6 RID: 18422 RVA: 0x001B0E20 File Offset: 0x001AF020
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_928()
		{
			return this.label_182;
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x000229A8 File Offset: 0x00020BA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_929(System.Windows.Forms.Label label_194)
		{
			this.label_182 = label_194;
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x001B0E38 File Offset: 0x001AF038
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_930()
		{
			return this.label_183;
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x000229B1 File Offset: 0x00020BB1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_931(System.Windows.Forms.Label label_194)
		{
			this.label_183 = label_194;
		}

		// Token: 0x060047FA RID: 18426 RVA: 0x001B0E50 File Offset: 0x001AF050
		[CompilerGenerated]
		internal  System.Windows.Forms.TabControl vmethod_932()
		{
			return this.tabControl_4;
		}

		// Token: 0x060047FB RID: 18427 RVA: 0x000229BA File Offset: 0x00020BBA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_933(System.Windows.Forms.TabControl tabControl_8)
		{
			this.tabControl_4 = tabControl_8;
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x001B0E68 File Offset: 0x001AF068
		[CompilerGenerated]
		internal  TabPage vmethod_934()
		{
			return this.tabPage_16;
		}

		// Token: 0x060047FD RID: 18429 RVA: 0x000229C3 File Offset: 0x00020BC3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_935(TabPage tabPage_25)
		{
			this.tabPage_16 = tabPage_25;
		}

		// Token: 0x060047FE RID: 18430 RVA: 0x001B0E80 File Offset: 0x001AF080
		[CompilerGenerated]
		internal  TabPage vmethod_936()
		{
			return this.tabPage_17;
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x000229CC File Offset: 0x00020BCC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_937(TabPage tabPage_25)
		{
			this.tabPage_17 = tabPage_25;
		}

		// Token: 0x06004800 RID: 18432 RVA: 0x001B0E98 File Offset: 0x001AF098
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetComboBox_ShipFormationCruise_Support()
		{
			return this.comboBox_111;
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x000229D5 File Offset: 0x00020BD5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_939(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_111 = comboBox_117;
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x001B0EB0 File Offset: 0x001AF0B0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_940()
		{
			return this.label_184;
		}

		// Token: 0x06004803 RID: 18435 RVA: 0x000229DE File Offset: 0x00020BDE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_941(System.Windows.Forms.Label label_194)
		{
			this.label_184 = label_194;
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x001B0EC8 File Offset: 0x001AF0C8
		[CompilerGenerated]
		internal  System.Windows.Forms.TabControl vmethod_942()
		{
			return this.tabControl_5;
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x000229E7 File Offset: 0x00020BE7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_943(System.Windows.Forms.TabControl tabControl_8)
		{
			this.tabControl_5 = tabControl_8;
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x001B0EE0 File Offset: 0x001AF0E0
		[CompilerGenerated]
		internal  TabPage vmethod_944()
		{
			return this.tabPage_18;
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x000229F0 File Offset: 0x00020BF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_945(TabPage tabPage_25)
		{
			this.tabPage_18 = tabPage_25;
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x001B0EF8 File Offset: 0x001AF0F8
		[CompilerGenerated]
		internal  TabPage vmethod_946()
		{
			return this.tabPage_19;
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x000229F9 File Offset: 0x00020BF9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_947(TabPage tabPage_25)
		{
			this.tabPage_19 = tabPage_25;
		}

		// Token: 0x0600480A RID: 18442 RVA: 0x001B0F10 File Offset: 0x001AF110
		[CompilerGenerated]
		internal  System.Windows.Forms.TabControl vmethod_948()
		{
			return this.tabControl_6;
		}

		// Token: 0x0600480B RID: 18443 RVA: 0x00022A02 File Offset: 0x00020C02
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_949(System.Windows.Forms.TabControl tabControl_8)
		{
			this.tabControl_6 = tabControl_8;
		}

		// Token: 0x0600480C RID: 18444 RVA: 0x001B0F28 File Offset: 0x001AF128
		[CompilerGenerated]
		internal  TabPage vmethod_950()
		{
			return this.tabPage_20;
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x00022A0B File Offset: 0x00020C0B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_951(TabPage tabPage_25)
		{
			this.tabPage_20 = tabPage_25;
		}

		// Token: 0x0600480E RID: 18446 RVA: 0x001B0F40 File Offset: 0x001AF140
		[CompilerGenerated]
		internal  TabPage vmethod_952()
		{
			return this.tabPage_21;
		}

		// Token: 0x0600480F RID: 18447 RVA: 0x00022A14 File Offset: 0x00020C14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_953(TabPage tabPage_25)
		{
			this.tabPage_21 = tabPage_25;
		}

		// Token: 0x06004810 RID: 18448 RVA: 0x001B0F58 File Offset: 0x001AF158
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_954()
		{
			return this.comboBox_112;
		}

		// Token: 0x06004811 RID: 18449 RVA: 0x00022A1D File Offset: 0x00020C1D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_955(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_112 = comboBox_117;
		}

		// Token: 0x06004812 RID: 18450 RVA: 0x001B0F70 File Offset: 0x001AF170
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_956()
		{
			return this.comboBox_113;
		}

		// Token: 0x06004813 RID: 18451 RVA: 0x00022A26 File Offset: 0x00020C26
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_957(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_113 = comboBox_117;
		}

		// Token: 0x06004814 RID: 18452 RVA: 0x001B0F88 File Offset: 0x001AF188
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_958()
		{
			return this.label_185;
		}

		// Token: 0x06004815 RID: 18453 RVA: 0x00022A2F File Offset: 0x00020C2F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_959(System.Windows.Forms.Label label_194)
		{
			this.label_185 = label_194;
		}

		// Token: 0x06004816 RID: 18454 RVA: 0x001B0FA0 File Offset: 0x001AF1A0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_960()
		{
			return this.label_186;
		}

		// Token: 0x06004817 RID: 18455 RVA: 0x00022A38 File Offset: 0x00020C38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_961(System.Windows.Forms.Label label_194)
		{
			this.label_186 = label_194;
		}

		// Token: 0x06004818 RID: 18456 RVA: 0x001B0FB8 File Offset: 0x001AF1B8
		[CompilerGenerated]
		internal  System.Windows.Forms.TabControl vmethod_962()
		{
			return this.tabControl_7;
		}

		// Token: 0x06004819 RID: 18457 RVA: 0x00022A41 File Offset: 0x00020C41
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_963(System.Windows.Forms.TabControl tabControl_8)
		{
			this.tabControl_7 = tabControl_8;
		}

		// Token: 0x0600481A RID: 18458 RVA: 0x001B0FD0 File Offset: 0x001AF1D0
		[CompilerGenerated]
		internal  TabPage vmethod_964()
		{
			return this.tabPage_22;
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x00022A4A File Offset: 0x00020C4A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_965(TabPage tabPage_25)
		{
			this.tabPage_22 = tabPage_25;
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x001B0FE8 File Offset: 0x001AF1E8
		[CompilerGenerated]
		internal  TabPage vmethod_966()
		{
			return this.tabPage_23;
		}

		// Token: 0x0600481D RID: 18461 RVA: 0x00022A53 File Offset: 0x00020C53
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_967(TabPage tabPage_25)
		{
			this.tabPage_23 = tabPage_25;
		}

		// Token: 0x0600481E RID: 18462 RVA: 0x001B1000 File Offset: 0x001AF200
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_968()
		{
			return this.comboBox_114;
		}

		// Token: 0x0600481F RID: 18463 RVA: 0x00022A5C File Offset: 0x00020C5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_969(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_114 = comboBox_117;
		}

		// Token: 0x06004820 RID: 18464 RVA: 0x001B1018 File Offset: 0x001AF218
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_970()
		{
			return this.comboBox_115;
		}

		// Token: 0x06004821 RID: 18465 RVA: 0x00022A65 File Offset: 0x00020C65
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_971(System.Windows.Forms.ComboBox comboBox_117)
		{
			this.comboBox_115 = comboBox_117;
		}

		// Token: 0x06004822 RID: 18466 RVA: 0x001B1030 File Offset: 0x001AF230
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_972()
		{
			return this.label_187;
		}

		// Token: 0x06004823 RID: 18467 RVA: 0x00022A6E File Offset: 0x00020C6E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_973(System.Windows.Forms.Label label_194)
		{
			this.label_187 = label_194;
		}

		// Token: 0x06004824 RID: 18468 RVA: 0x001B1048 File Offset: 0x001AF248
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_974()
		{
			return this.label_188;
		}

		// Token: 0x06004825 RID: 18469 RVA: 0x00022A77 File Offset: 0x00020C77
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_975(System.Windows.Forms.Label label_194)
		{
			this.label_188 = label_194;
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x001B1060 File Offset: 0x001AF260
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_FlightPlanEditor_Strike()
		{
			return this.Button_FlightPlanEditor_Strike;
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x001B1078 File Offset: 0x001AF278
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_FlightPlanEditor_Strike(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.Button_FlightPlanEditor_Strike_Click);
			System.Windows.Forms.Button button_FlightPlanEditor_Strike = this.Button_FlightPlanEditor_Strike;
			if (button_FlightPlanEditor_Strike != null)
			{
				button_FlightPlanEditor_Strike.Click -= value;
			}
			this.Button_FlightPlanEditor_Strike = button_38;
			button_FlightPlanEditor_Strike = this.Button_FlightPlanEditor_Strike;
			if (button_FlightPlanEditor_Strike != null)
			{
				button_FlightPlanEditor_Strike.Click += value;
			}
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x001B10C4 File Offset: 0x001AF2C4
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_FlightPlanList_Strike()
		{
			return this.button_21;
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x001B10DC File Offset: 0x001AF2DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_979(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_300);
			System.Windows.Forms.Button button = this.button_21;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_21 = button_38;
			button = this.button_21;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x001B1128 File Offset: 0x001AF328
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_980()
		{
			return this.button_22;
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x001B1140 File Offset: 0x001AF340
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_981(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_303);
			System.Windows.Forms.Button button = this.button_22;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_22 = button_38;
			button = this.button_22;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x001B118C File Offset: 0x001AF38C
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_982()
		{
			return this.button_23;
		}

		// Token: 0x0600482D RID: 18477 RVA: 0x001B11A4 File Offset: 0x001AF3A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_983(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_302);
			System.Windows.Forms.Button button = this.button_23;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_23 = button_38;
			button = this.button_23;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x001B11F0 File Offset: 0x001AF3F0
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_984()
		{
			return this.checkBox_45;
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x00022A80 File Offset: 0x00020C80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_985(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_45 = checkBox_57;
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x001B1208 File Offset: 0x001AF408
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_986()
		{
			return this.checkBox_46;
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x00022A89 File Offset: 0x00020C89
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_987(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_46 = checkBox_57;
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x001B1220 File Offset: 0x001AF420
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_988()
		{
			return this.button_24;
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x001B1238 File Offset: 0x001AF438
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_989(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_305);
			System.Windows.Forms.Button button = this.button_24;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_24 = button_38;
			button = this.button_24;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x001B1284 File Offset: 0x001AF484
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_990()
		{
			return this.button_25;
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x001B129C File Offset: 0x001AF49C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_991(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_304);
			System.Windows.Forms.Button button = this.button_25;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_25 = button_38;
			button = this.button_25;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x001B12E8 File Offset: 0x001AF4E8
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_992()
		{
			return this.checkBox_47;
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x00022A92 File Offset: 0x00020C92
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_993(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_47 = checkBox_57;
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x001B1300 File Offset: 0x001AF500
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_994()
		{
			return this.checkBox_48;
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x00022A9B File Offset: 0x00020C9B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_995(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_48 = checkBox_57;
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x001B1318 File Offset: 0x001AF518
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_FlightPlanEditor_Support()
		{
			return this.button_26;
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x001B1330 File Offset: 0x001AF530
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_997(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_307);
			System.Windows.Forms.Button button = this.button_26;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_26 = button_38;
			button = this.button_26;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x001B137C File Offset: 0x001AF57C
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_FlightPlanList_Support()
		{
			return this.button_27;
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x001B1394 File Offset: 0x001AF594
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_999(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_306);
			System.Windows.Forms.Button button = this.button_27;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_27 = button_38;
			button = this.button_27;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x001B13E0 File Offset: 0x001AF5E0
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCheckBox_IncludeInATO_Support()
		{
			return this.checkBox_49;
		}

		// Token: 0x0600483F RID: 18495 RVA: 0x00022AA4 File Offset: 0x00020CA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1001(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_49 = checkBox_57;
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x001B13F8 File Offset: 0x001AF5F8
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox GetCheckBox_PreGeneratedFlightPlansOnly_Support()
		{
			return this.checkBox_50;
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x00022AAD File Offset: 0x00020CAD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1003(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_50 = checkBox_57;
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x001B1410 File Offset: 0x001AF610
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_1004()
		{
			return this.button_28;
		}

		// Token: 0x06004843 RID: 18499 RVA: 0x001B1428 File Offset: 0x001AF628
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1005(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_309);
			System.Windows.Forms.Button button = this.button_28;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_28 = button_38;
			button = this.button_28;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x001B1474 File Offset: 0x001AF674
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_1006()
		{
			return this.button_29;
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x001B148C File Offset: 0x001AF68C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1007(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_308);
			System.Windows.Forms.Button button = this.button_29;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_29 = button_38;
			button = this.button_29;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x001B14D8 File Offset: 0x001AF6D8
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_1008()
		{
			return this.checkBox_51;
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x00022AB6 File Offset: 0x00020CB6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1009(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_51 = checkBox_57;
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x001B14F0 File Offset: 0x001AF6F0
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_1010()
		{
			return this.checkBox_52;
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x00022ABF File Offset: 0x00020CBF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1011(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_52 = checkBox_57;
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x001B1508 File Offset: 0x001AF708
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_1012()
		{
			return this.button_30;
		}

		// Token: 0x0600484B RID: 18507 RVA: 0x001B1520 File Offset: 0x001AF720
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1013(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_311);
			System.Windows.Forms.Button button = this.button_30;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_30 = button_38;
			button = this.button_30;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x001B156C File Offset: 0x001AF76C
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_1014()
		{
			return this.button_31;
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x001B1584 File Offset: 0x001AF784
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1015(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_310);
			System.Windows.Forms.Button button = this.button_31;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_31 = button_38;
			button = this.button_31;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x001B15D0 File Offset: 0x001AF7D0
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_1016()
		{
			return this.checkBox_53;
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x00022AC8 File Offset: 0x00020CC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1017(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_53 = checkBox_57;
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x001B15E8 File Offset: 0x001AF7E8
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_1018()
		{
			return this.checkBox_54;
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x00022AD1 File Offset: 0x00020CD1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1019(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_54 = checkBox_57;
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x001B1600 File Offset: 0x001AF800
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_1020()
		{
			return this.button_32;
		}

		// Token: 0x06004853 RID: 18515 RVA: 0x001B1618 File Offset: 0x001AF818
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1021(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_313);
			System.Windows.Forms.Button button = this.button_32;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_32 = button_38;
			button = this.button_32;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x001B1664 File Offset: 0x001AF864
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_1022()
		{
			return this.button_33;
		}

		// Token: 0x06004855 RID: 18517 RVA: 0x001B167C File Offset: 0x001AF87C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1023(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_312);
			System.Windows.Forms.Button button = this.button_33;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_33 = button_38;
			button = this.button_33;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004856 RID: 18518 RVA: 0x001B16C8 File Offset: 0x001AF8C8
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_1024()
		{
			return this.checkBox_55;
		}

		// Token: 0x06004857 RID: 18519 RVA: 0x00022ADA File Offset: 0x00020CDA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1025(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_55 = checkBox_57;
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x001B16E0 File Offset: 0x001AF8E0
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_1026()
		{
			return this.checkBox_56;
		}

		// Token: 0x06004859 RID: 18521 RVA: 0x00022AE3 File Offset: 0x00020CE3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1027(System.Windows.Forms.CheckBox checkBox_57)
		{
			this.checkBox_56 = checkBox_57;
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x001B16F8 File Offset: 0x001AF8F8
		[CompilerGenerated]
		internal  FlowLayoutPanel vmethod_1028()
		{
			return this.flowLayoutPanel_0;
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x00022AEC File Offset: 0x00020CEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1029(FlowLayoutPanel flowLayoutPanel_1)
		{
			this.flowLayoutPanel_0 = flowLayoutPanel_1;
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x001B1710 File Offset: 0x001AF910
		[CompilerGenerated]
		internal  System.Windows.Forms.Panel vmethod_1030()
		{
			return this.panel_7;
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x00022AF5 File Offset: 0x00020CF5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1031(System.Windows.Forms.Panel panel_8)
		{
			this.panel_7 = panel_8;
		}

		// Token: 0x0600485E RID: 18526 RVA: 0x001B1728 File Offset: 0x001AF928
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox GetGroupBox_TakeOffTime()
		{
			return this.groupBox_25;
		}

		// Token: 0x0600485F RID: 18527 RVA: 0x00022AFE File Offset: 0x00020CFE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1033(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_25 = groupBox_27;
		}

		// Token: 0x06004860 RID: 18528 RVA: 0x001B1740 File Offset: 0x001AF940
		[CompilerGenerated]
		internal  DateTimePicker GetDateTimePicker_TakeOffTime()
		{
			return this.dateTimePicker_4;
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x001B1758 File Offset: 0x001AF958
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1035(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_239);
			EventHandler value2 = new EventHandler(this.method_240);
			DateTimePicker dateTimePicker = this.dateTimePicker_4;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
			}
			this.dateTimePicker_4 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_4;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
			}
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x001B17BC File Offset: 0x001AF9BC
		[CompilerGenerated]
		internal  DateTimePicker GetDateTimePicker_TakeOffDate()
		{
			return this.dateTimePicker_5;
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x001B17D4 File Offset: 0x001AF9D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1037(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_237);
			EventHandler value2 = new EventHandler(this.method_238);
			EventHandler value3 = new EventHandler(this.method_261);
			DateTimePicker dateTimePicker = this.dateTimePicker_5;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
				dateTimePicker.CloseUp -= value3;
			}
			this.dateTimePicker_5 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_5;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
				dateTimePicker.CloseUp += value3;
			}
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x001B1854 File Offset: 0x001AFA54
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_1038()
		{
			return this.label_189;
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x00022B07 File Offset: 0x00020D07
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1039(System.Windows.Forms.Label label_194)
		{
			this.label_189 = label_194;
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x001B186C File Offset: 0x001AFA6C
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_1040()
		{
			return this.label_190;
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x00022B10 File Offset: 0x00020D10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1041(System.Windows.Forms.Label label_194)
		{
			this.label_190 = label_194;
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x001B1884 File Offset: 0x001AFA84
		[CompilerGenerated]
		internal  System.Windows.Forms.GroupBox GetGroupBox_TimeOnTarget()
		{
			return this.groupBox_26;
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x00022B19 File Offset: 0x00020D19
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1043(System.Windows.Forms.GroupBox groupBox_27)
		{
			this.groupBox_26 = groupBox_27;
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x001B189C File Offset: 0x001AFA9C
		[CompilerGenerated]
		internal  DateTimePicker GetDateTimePicker_TimeOnTargetTime()
		{
			return this.dateTimePicker_6;
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x001B18B4 File Offset: 0x001AFAB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1045(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_243);
			EventHandler value2 = new EventHandler(this.method_244);
			DateTimePicker dateTimePicker = this.dateTimePicker_6;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
			}
			this.dateTimePicker_6 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_6;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
			}
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x001B1918 File Offset: 0x001AFB18
		[CompilerGenerated]
		internal  DateTimePicker GetDateTimePicker_TimeOnTargetDate()
		{
			return this.dateTimePicker_7;
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x001B1930 File Offset: 0x001AFB30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1047(DateTimePicker dateTimePicker_8)
		{
			EventHandler value = new EventHandler(this.method_241);
			EventHandler value2 = new EventHandler(this.method_242);
			EventHandler value3 = new EventHandler(this.method_262);
			DateTimePicker dateTimePicker = this.dateTimePicker_7;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter -= value;
				dateTimePicker.Leave -= value2;
				dateTimePicker.CloseUp -= value3;
			}
			this.dateTimePicker_7 = dateTimePicker_8;
			dateTimePicker = this.dateTimePicker_7;
			if (dateTimePicker != null)
			{
				dateTimePicker.Enter += value;
				dateTimePicker.Leave += value2;
				dateTimePicker.CloseUp += value3;
			}
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x001B19B0 File Offset: 0x001AFBB0
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_1048()
		{
			return this.label_191;
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x00022B22 File Offset: 0x00020D22
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1049(System.Windows.Forms.Label label_194)
		{
			this.label_191 = label_194;
		}

		// Token: 0x06004870 RID: 18544 RVA: 0x001B19C8 File Offset: 0x001AFBC8
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_1050()
		{
			return this.label_192;
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x00022B2B File Offset: 0x00020D2B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1051(System.Windows.Forms.Label label_194)
		{
			this.label_192 = label_194;
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x001B19E0 File Offset: 0x001AFBE0
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_Clear_TakeOffTime()
		{
			return this.button_34;
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x001B19F8 File Offset: 0x001AFBF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1053(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_255);
			System.Windows.Forms.Button button = this.button_34;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_34 = button_38;
			button = this.button_34;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x001B1A44 File Offset: 0x001AFC44
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_Clear_TimeOnTarget()
		{
			return this.button_35;
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x001B1A5C File Offset: 0x001AFC5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1055(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.method_256);
			System.Windows.Forms.Button button = this.button_35;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_35 = button_38;
			button = this.button_35;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x001B1AA8 File Offset: 0x001AFCA8
		[CompilerGenerated]
		internal  TabPage vmethod_1056()
		{
			return this.tabPage_24;
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x00022B34 File Offset: 0x00020D34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1057(TabPage tabPage_25)
		{
			this.tabPage_24 = tabPage_25;
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x001B1AC0 File Offset: 0x001AFCC0
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_CreateFlightPlans_Strike()
		{
			return this.Button_CreateFlightPlans_Strike;
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x001B1AD8 File Offset: 0x001AFCD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_CreateFlightPlans_Strike(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.Button_CreateFlightPlans_Strike_Click);
			System.Windows.Forms.Button button_CreateFlightPlans_Strike = this.Button_CreateFlightPlans_Strike;
			if (button_CreateFlightPlans_Strike != null)
			{
				button_CreateFlightPlans_Strike.Click -= value;
			}
			this.Button_CreateFlightPlans_Strike = button_38;
			button_CreateFlightPlans_Strike = this.Button_CreateFlightPlans_Strike;
			if (button_CreateFlightPlans_Strike != null)
			{
				button_CreateFlightPlans_Strike.Click += value;
			}
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x001B1B24 File Offset: 0x001AFD24
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_FillEmptySlots_Strike()
		{
			return this.Button_FillEmptySlots_Strike;
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x001B1B3C File Offset: 0x001AFD3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_FillEmptySlots_Strike(System.Windows.Forms.Button button_38)
		{
			EventHandler value = new EventHandler(this.Button_FillEmptySlots_Strike_Click);
			System.Windows.Forms.Button button_FillEmptySlots_Strike = this.Button_FillEmptySlots_Strike;
			if (button_FillEmptySlots_Strike != null)
			{
				button_FillEmptySlots_Strike.Click -= value;
			}
			this.Button_FillEmptySlots_Strike = button_38;
			button_FillEmptySlots_Strike = this.Button_FillEmptySlots_Strike;
			if (button_FillEmptySlots_Strike != null)
			{
				button_FillEmptySlots_Strike.Click += value;
			}
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x001B1B88 File Offset: 0x001AFD88
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_1062()
		{
			return this.label_193;
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x00022B3D File Offset: 0x00020D3D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1063(System.Windows.Forms.Label label_194)
		{
			this.label_193 = label_194;
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x001B1BA0 File Offset: 0x001AFDA0
		[CompilerGenerated]
		internal  AreaEditor vmethod_1064()
		{
			return this.areaEditor_5;
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x00022B46 File Offset: 0x00020D46
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1065(AreaEditor areaEditor_6)
		{
			this.areaEditor_5 = areaEditor_6;
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x001B1BB8 File Offset: 0x001AFDB8
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox GetCB_SplitDistance()
		{
			return this.comboBox_116;
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x001B1BD0 File Offset: 0x001AFDD0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1067(System.Windows.Forms.ComboBox comboBox_117)
		{
			EventHandler value = new EventHandler(this.method_320);
			EventHandler value2 = new EventHandler(this.method_321);
			EventHandler value3 = new EventHandler(this.method_321);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_116;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
				comboBox.SelectionChangeCommitted -= value2;
				comboBox.SelectionChangeCommitted -= value3;
			}
			this.comboBox_116 = comboBox_117;
			comboBox = this.comboBox_116;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
				comboBox.SelectionChangeCommitted += value2;
				comboBox.SelectionChangeCommitted += value3;
			}
		}

		// Token: 0x06004882 RID: 18562 RVA: 0x001B1C50 File Offset: 0x001AFE50
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_DeleteAllFlightplans()
		{
			return this.Button_DeleteAllFlightplans;
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x001B1C68 File Offset: 0x001AFE68
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1069(System.Windows.Forms.Button button_40)
		{
			EventHandler value = new EventHandler(this.method_323);
			System.Windows.Forms.Button button_DeleteAllFlightplans = this.Button_DeleteAllFlightplans;
			if (button_DeleteAllFlightplans != null)
			{
				button_DeleteAllFlightplans.Click -= value;
			}
			this.Button_DeleteAllFlightplans = button_40;
			button_DeleteAllFlightplans = this.Button_DeleteAllFlightplans;
			if (button_DeleteAllFlightplans != null)
			{
				button_DeleteAllFlightplans.Click += value;
			}
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x001B1CB4 File Offset: 0x001AFEB4
		[CompilerGenerated]
		internal  System.Windows.Forms.Button GetButton_CreateAllFlightplans()
		{
			return this.Button_CreateAllFlightplans;
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x001B1CCC File Offset: 0x001AFECC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1071(System.Windows.Forms.Button button_40)
		{
			EventHandler value = new EventHandler(this.method_322);
			System.Windows.Forms.Button button_CreateAllFlightplans = this.Button_CreateAllFlightplans;
			if (button_CreateAllFlightplans != null)
			{
				button_CreateAllFlightplans.Click -= value;
			}
			this.Button_CreateAllFlightplans = button_40;
			button_CreateAllFlightplans = this.Button_CreateAllFlightplans;
			if (button_CreateAllFlightplans != null)
			{
				button_CreateAllFlightplans.Click += value;
			}
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x001B1D18 File Offset: 0x001AFF18
		[CompilerGenerated]
		public static void smethod_0(MissionEditor.Delegate64 delegate64_1)
		{
			MissionEditor.Delegate64 @delegate = MissionEditor.delegate64_0;
			MissionEditor.Delegate64 delegate2;
			do
			{
				delegate2 = @delegate;
				MissionEditor.Delegate64 value = (MissionEditor.Delegate64)Delegate.Combine(delegate2, delegate64_1);
				@delegate = Interlocked.CompareExchange<MissionEditor.Delegate64>(ref MissionEditor.delegate64_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x001B1D50 File Offset: 0x001AFF50
		[CompilerGenerated]
		public static void smethod_1(MissionEditor.Delegate64 delegate64_1)
		{
			MissionEditor.Delegate64 @delegate = MissionEditor.delegate64_0;
			MissionEditor.Delegate64 delegate2;
			do
			{
				delegate2 = @delegate;
				MissionEditor.Delegate64 value = (MissionEditor.Delegate64)Delegate.Remove(delegate2, delegate64_1);
				@delegate = Interlocked.CompareExchange<MissionEditor.Delegate64>(ref MissionEditor.delegate64_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x001B1D88 File Offset: 0x001AFF88
		public void method_1()
		{
			try
			{
				this.vmethod_6().Nodes.Clear();
				this.vmethod_22().Nodes.Clear();
				this.vmethod_20().Nodes.Clear();
				if (Information.IsNothing(this.SelectedMission))
				{
					if (Client.GetClientSide().GetMissionCollection().Count > 0)
					{
						this.method_5(Client.GetClientSide().GetMissionCollection()[0]);
					}
				}
				else if (!Client.GetClientSide().GetMissionCollection().Contains(this.SelectedMission))
				{
					if (Client.GetClientSide().GetMissionCollection().Count > 0)
					{
						this.method_5(Client.GetClientSide().GetMissionCollection()[0]);
					}
					else
					{
						this.method_5(null);
					}
				}
				this.method_9();
				this.GetCB_ScrubIfHuman().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
				this.GetButton_FillEmptySlots_Strike().Visible = true;
				this.GetButton_CreateFlightPlans_Strike().Visible = true;
				this.GetButton_FlightPlanEditor_Strike().Visible = true;
				this.GetButton_FlightPlanList_Strike().Visible = true;
				this.vmethod_988().Visible = false;
				this.vmethod_990().Visible = false;
				this.vmethod_980().Visible = false;
				this.vmethod_982().Visible = false;
				this.GetButton_FlightPlanEditor_Support().Visible = false;
				this.GetButton_FlightPlanList_Support().Visible = false;
				this.vmethod_1004().Visible = false;
				this.vmethod_1006().Visible = false;
				this.vmethod_1012().Visible = false;
				this.vmethod_1014().Visible = false;
				this.vmethod_1020().Visible = false;
				this.vmethod_1022().Visible = false;
				this.GetCB_AttackMethod().Enabled = false;
				this.GetCB_SplitDistance().Enabled = false;
				this.GetCheckBox_PreGeneratedFlightPlansOnly_Strike().Enabled = false;
				this.vmethod_986().Enabled = false;
				this.vmethod_994().Enabled = false;
				this.GetCheckBox_PreGeneratedFlightPlansOnly_Support().Enabled = false;
				this.vmethod_1010().Enabled = false;
				this.vmethod_1018().Enabled = false;
				this.vmethod_1026().Enabled = false;
				this.GetCheckBox_IncludeInATO_Strike().Enabled = false;
				this.vmethod_984().Enabled = false;
				this.vmethod_992().Enabled = false;
				this.GetCheckBox_IncludeInATO_Support().Enabled = false;
				this.vmethod_1008().Enabled = false;
				this.vmethod_1016().Enabled = false;
				this.vmethod_1024().Enabled = false;
				this.vmethod_482().Enabled = false;
				this.GetCheckBox_UnassignUnits().Visible = false;
				this.GetCheckBox_OrderRTB().Visible = false;
				this.GetCheckBox_DeleteMission().Visible = false;
				this.GetCheckBox_PreGeneratedFlightPlansOnly_Strike().Visible = false;
				this.GetCheckBox_IncludeInATO_Strike().Visible = false;
				if (this.vmethod_6().Nodes.Count > 0)
				{
					this.vmethod_6().SelectedNode = this.vmethod_6().Nodes[0];
					if (Information.IsNothing(this.GetSelectedMission()))
					{
						if (this.vmethod_6().Nodes.Count > 0)
						{
							this.method_5((Mission)this.vmethod_6().Nodes[0].Tag);
						}
					}
					else
					{
						IEnumerator enumerator = this.vmethod_6().Nodes.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								TreeNode treeNode = (TreeNode)enumerator.Current;
								if (treeNode.Tag == this.GetSelectedMission())
								{
									this.vmethod_6().SelectedNode = treeNode;
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
					this.method_10();
				}
				this.method_12();
				this.method_25();
				if (!Information.IsNothing(this.GetSelectedMission()) && this.vmethod_6().Nodes.Count > 0)
				{
					this.vmethod_6().Select();
					this.vmethod_6().EndUpdate();
					if (Operators.CompareString(this.GetTextBox_MissionName().Text, "", false) == 0)
					{
						this.GetTextBox_MissionName().Text = this.GetSelectedMission().Name;
					}
				}
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike)
				{
					this.vmethod_134().Enabled = true;
					this.vmethod_136().Enabled = true;
					this.vmethod_292().Enabled = true;
				}
				else
				{
					this.vmethod_134().Enabled = false;
					this.vmethod_136().Enabled = false;
					this.vmethod_292().Enabled = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200632", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x001B2284 File Offset: 0x001B0484
		private void method_2(Subject class137_0, bool? nullable_0, bool bool_33, bool bool_34, bool bool_35, bool bool_36)
		{
			if (!bool_36 && !Information.IsNothing(class137_0) && (class137_0.IsMission || class137_0.GetType() == typeof(Side)) && base.Visible)
			{
				if (class137_0.IsMission)
				{
					Client.SetClientSide(Client.GetClientScenario().GetCurrentSide());
					if (!Client.GetClientSide().GetMissionCollection().Contains((Mission)class137_0))
					{
						return;
					}
				}
				if (class137_0.GetType() != typeof(Side) || Client.GetClientScenario().GetSides().Contains((Side)class137_0))
				{
					try
					{
						if (!Information.IsNothing(nullable_0) && (this.GetSelectedMission() == class137_0 || class137_0.GetType() == typeof(Side)))
						{
							this.method_1();
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200392", ex2.Message);
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

		// Token: 0x0600488A RID: 18570 RVA: 0x00022B4F File Offset: 0x00020D4F
		private void method_3(Subject class137_0)
		{
			if (!Information.IsNothing(class137_0))
			{
				this.method_1();
			}
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x001B23C0 File Offset: 0x001B05C0
		public Mission GetSelectedMission()
		{
			return this.SelectedMission;
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x001B23D8 File Offset: 0x001B05D8
		public void method_5(Mission mission_1)
		{
			this.method_21();
			this.method_81();
			this.method_84();
			this.method_85();
			this.method_276();
			this.method_97();
			this.method_100();
			this.method_103();
			this.method_106();
			this.method_109();
			this.method_112();
			this.method_115();
			this.method_118();
			this.method_121();
			this.method_135();
			this.method_86();
			this.method_87();
			this.method_88();
			this.method_279();
			this.method_89();
			this.method_90();
			this.method_93();
			this.method_94();
			this.method_95();
			this.method_96();
			this.method_246();
			this.method_248();
			this.method_250();
			this.method_252();
			this.method_148();
			this.method_151();
			this.method_286();
			if (mission_1 != this.SelectedMission)
			{
				this.SelectedMission = mission_1;
			}
			Client.b_Completed = true;
			if (Information.IsNothing(mission_1))
			{
				this.GetLabel_MissionDescription().Visible = false;
				this.vmethod_54().Visible = false;
			}
			else
			{
				if (mission_1.category == Mission.MissionCategory.TaskPool)
				{
					this.GetLabel_MissionDescription().Visible = false;
					this.vmethod_54().Visible = false;
				}
				else
				{
					this.GetLabel_MissionDescription().Visible = true;
					this.vmethod_54().Visible = true;
				}
				switch (mission_1.category)
				{
				case Mission.MissionCategory.Mission:
					this.GetLabel_AssignedUnits().Text = "分配给任务的作战单元";
					this.vmethod_4().Text = "未分配任务的作战单元";
					break;
				case Mission.MissionCategory.Package:
					this.GetLabel_AssignedUnits().Text = "分配给任务（Task）包的作战单元";
					this.vmethod_4().Text = "任务（Task）池中的作战单元";
					break;
				case Mission.MissionCategory.TaskPool:
					this.GetLabel_AssignedUnits().Text = "分配给任务（Task）池的作战单元";
					this.vmethod_4().Text = "未分配任务的作战单元";
					break;
				}
				this.GetTextBox_MissionName().Text = mission_1.Name;
				this.GetCB_ScrubIfHuman().Checked = mission_1.SISIH;
				this.GetCombo_MissionStatus().SelectedIndex = (int)mission_1.GetMissionStatus(Client.GetClientScenario());
				this.method_25();
				switch (mission_1.MissionClass)
				{
				case Mission._MissionClass.Strike:
					this.GetTC_MissionOptions().SelectedIndex = 0;
					switch (((Strike)mission_1).strikeType)
					{
					case Strike.StrikeType.Air_Intercept:
						this.GetLabel_MissionDescription().Text = "空中截击";
						break;
					case Strike.StrikeType.Land_Strike:
						this.GetLabel_MissionDescription().Text = "对地突击";
						break;
					case Strike.StrikeType.Maritime_Strike:
						this.GetLabel_MissionDescription().Text = "海上对舰突击";
						break;
					case Strike.StrikeType.Sub_Strike:
						this.GetLabel_MissionDescription().Text = "反潜突击";
						break;
					}
					this.method_51();
					break;
				case Mission._MissionClass.Patrol:
					this.GetTC_MissionOptions().SelectedIndex = 2;
					this.GetLabel_MissionDescription().Text = ((Patrol)mission_1).GetTypeString(Client.GetClientScenario());
					break;
				case Mission._MissionClass.Support:
					this.GetTC_MissionOptions().SelectedIndex = 3;
					this.GetLabel_MissionDescription().Text = ((SupportMission)mission_1).GetTypeString(Client.GetClientScenario());
					break;
				case Mission._MissionClass.Ferry:
					this.GetTC_MissionOptions().SelectedIndex = 4;
					this.GetLabel_MissionDescription().Text = ((FerryMission)mission_1).GetTypeString(Client.GetClientScenario());
					break;
				case Mission._MissionClass.Mining:
					this.GetTC_MissionOptions().SelectedIndex = 5;
					this.GetLabel_MissionDescription().Text = ((MiningMission)mission_1).GetTypeString(Client.GetClientScenario());
					break;
				case Mission._MissionClass.MineClearing:
					this.GetTC_MissionOptions().SelectedIndex = 6;
					this.GetLabel_MissionDescription().Text = ((MineClearingMission)mission_1).GetTypeString(Client.GetClientScenario());
					break;
				case Mission._MissionClass.Escort:
					this.GetTC_MissionOptions().SelectedIndex = 1;
					this.GetLabel_MissionDescription().Text = ((TankerMission)mission_1).GetTypeString(Client.GetClientScenario());
					break;
				case Mission._MissionClass.Cargo:
					this.GetTC_MissionOptions().SelectedIndex = 7;
					this.GetLabel_MissionDescription().Text = ((CargoMission)mission_1).GetTypeString(Client.GetClientScenario());
					break;
				}
			}
			if (!Information.IsNothing(mission_1))
			{
				if (this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike)
				{
					this.vmethod_134().Enabled = true;
					this.vmethod_136().Enabled = true;
					this.vmethod_292().Enabled = true;
				}
				else
				{
					this.vmethod_134().Enabled = false;
					this.vmethod_136().Enabled = false;
					this.vmethod_292().Enabled = false;
				}
			}
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x001B2824 File Offset: 0x001B0A24
		private void method_6(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(e.Node.Tag)) && e.Node.Tag.GetType().BaseType == typeof(Mission))
			{
				this.method_5((Mission)e.Node.Tag);
				this.method_10();
				this.method_12();
			}
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x001B2898 File Offset: 0x001B0A98
		public void method_7(ref Aircraft aircraft_0, ref TreeNode treeNode_0)
		{
			if (aircraft_0.GetAircraftAI().IsEscort && !treeNode_0.Text.StartsWith("[Escort]"))
			{
				treeNode_0.Text = "[Escort] " + treeNode_0.Text;
			}
			if (!aircraft_0.IsOperating())
			{
				if (aircraft_0.GetAircraftAirOps().GetConditionTimer() == 0f)
				{
					Aircraft aircraft = aircraft_0;
					string text = null;
					if (aircraft.GetMaintenanceLevel(ref text) == Aircraft_AirOps._Maintenance.const_0)
					{
						treeNode_0.ForeColor = Color.DarkGreen;
						return;
					}
				}
				treeNode_0.ForeColor = Color.Red;
			}
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x001B2934 File Offset: 0x001B0B34
		public void method_8(ref ActiveUnit activeUnit_1, ref TreeNode treeNode_0)
		{
			if (activeUnit_1.GetAI().IsEscort)
			{
				treeNode_0.ForeColor = Color.Green;
				if (!treeNode_0.Text.StartsWith("[Escort]"))
				{
					treeNode_0.Text = "[Escort] " + treeNode_0.Text;
				}
			}
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x001B298C File Offset: 0x001B0B8C
		public void method_9()
		{
			try
			{
				this.vmethod_6().Nodes.Clear();
				IEnumerable<Mission> enumerable = Client.GetClientSide().GetPatrolMissionCollection(Client.GetClientScenario()).OrderBy(MissionEditor.MissionFunc0);
				foreach (Mission current in enumerable)
				{
					if (current.category != Mission.MissionCategory.Package)
					{
						if (current.category == Mission.MissionCategory.Mission)
						{
							TreeNode treeNode = this.vmethod_6().Nodes.Add(current.Name);
							if (current.IsActive())
							{
								treeNode.ForeColor = Color.Green;
							}
							else
							{
								treeNode.ForeColor = Color.Red;
								treeNode.NodeFont = new Font(this.Font, FontStyle.Italic);
								DateTime? startTime = current.GetStartTime();
								DateTime currentTime = Client.GetClientScenario().GetCurrentTime(false);
								if ((startTime.HasValue ? new bool?(DateTime.Compare(startTime.GetValueOrDefault(), currentTime) > 0) : null).GetValueOrDefault())
								{
									treeNode.Text = "[D] " + current.Name;
								}
							}
							treeNode.Tag = current;
						}
						else
						{
							TreeNode treeNode2 = this.vmethod_6().Nodes.Add(current.Name);
							treeNode2.Tag = current;
							TaskPool taskPool = (TaskPool)current;
							foreach (Mission current2 in taskPool.Packages)
							{
								treeNode2.Nodes.Add(current2.Name).Tag = current2;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200634", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x001B2BD4 File Offset: 0x001B0DD4
		public void method_10()
		{
			this.vmethod_22().Nodes.Clear();
			List<Aircraft> list = new List<Aircraft>();
			List<Aircraft> list2 = new List<Aircraft>();
			List<ActiveUnit> list3 = new List<ActiveUnit>();
			List<Mission.EmptySlot> list4 = new List<Mission.EmptySlot>();
			ActiveUnit[] activeUnitArray = Client.GetClientSide().ActiveUnitArray;
			int i = 0;
			checked
			{
				while (i < activeUnitArray.Length)
				{
					ActiveUnit activeUnit = activeUnitArray[i];
					if (!activeUnit.IsWeapon)
					{
						goto IL_64;
					}
					if (((Weapon)activeUnit).GetWeaponType() != Weapon._WeaponType.Sonobuoy)
					{
						goto IL_64;
					}
					bool arg_9B_0 = true;
					IL_9B:
					if (!arg_9B_0)
					{
						if (activeUnit.IsAircraft)
						{
							if (!Information.IsNothing(activeUnit.GetNavigator().GetFlight()))
							{
								if (activeUnit.HasParentGroup())
								{
									if (!Information.IsNothing(activeUnit.GetParentGroup(false)) && !list3.Contains(activeUnit.GetParentGroup(false)))
									{
										list3.Add(activeUnit.GetParentGroup(false));
									}
								}
								else
								{
									list2.Add((Aircraft)activeUnit);
								}
							}
							else if (activeUnit.HasParentGroup())
							{
								if (!Information.IsNothing(activeUnit.GetParentGroup(false)) && !list3.Contains(activeUnit.GetParentGroup(false)))
								{
									list3.Add(activeUnit.GetParentGroup(false));
								}
							}
							else
							{
								list.Add((Aircraft)activeUnit);
							}
						}
						else if ((!activeUnit.IsSubmarine || !((Submarine)activeUnit).IsROV()) && !list3.Contains(activeUnit))
						{
							list3.Add(activeUnit);
						}
					}
					i++;
					continue;
					IL_64:
					arg_9B_0 = (activeUnit.GetAssignedMission(false) != this.GetSelectedMission() && (!Information.IsNothing(activeUnit.GetAssignedMission(false)) || activeUnit.GetAssignedTaskPool() != this.GetSelectedMission()));
					goto IL_9B;
				}
				List<Aircraft> list5 = list.Select(MissionEditor.AircraftFunc1).OrderBy(MissionEditor.AircraftFunc2, new Class265<string[]>(true)).ToList<Aircraft>();
				List<Aircraft> list6 = list2.Select(MissionEditor.AircraftFunc3).OrderBy(MissionEditor.AircraftFunc4, new Class265<string[]>(true)).ToList<Aircraft>();
				List<ActiveUnit> list7 = list3.Select(MissionEditor.ActiveUnitFunc5).OrderBy(MissionEditor.ActiveUnitFunc6, new Class265<string[]>(true)).ToList<ActiveUnit>();
                Aircraft currentX;
                foreach (Aircraft current in list5)
				{
					TreeNode treeNode = null;
					string unitClass = current.UnitClass;
					IEnumerator enumerator2 = this.vmethod_22().Nodes.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							TreeNode treeNode2 = (TreeNode)enumerator2.Current;
							if (Operators.CompareString(treeNode2.Tag.ToString(), unitClass, false) == 0)
							{
								treeNode = treeNode2;
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
					if (Information.IsNothing(treeNode))
					{
						treeNode = this.vmethod_22().Nodes.Add(current.UnitClass);
						treeNode.Tag = current.UnitClass;
					}
					string text = this.method_11(current, false);
					TreeNode treeNode3 = treeNode.Nodes.Add(text);
					treeNode3.Tag = current;
                    currentX = current;

                    this.method_7(ref currentX, ref treeNode3);
					treeNode.Text = Conversions.ToString(treeNode.Nodes.Count) + "x " + Misc.smethod_11(Conversions.ToString(treeNode.Tag));
					treeNode = null;
				}
                ActiveUnit current2X;

                foreach (ActiveUnit current2 in list7)
				{
					string text2 = current2.Name;
					string text4;
					string text5;
					if (current2.IsGroup)
					{
						Group group = (Group)current2;
						if (group.GetGroupType() == Group.GroupType.AirGroup && group.GetUnitsInGroup().Values.Count > 0)
						{
							string text3 = "";
							if (group.GetUnitsInGroup().Values.ElementAtOrDefault(0).IsAircraft)
							{
								Aircraft aircraft = (Aircraft)group.GetUnitsInGroup().Values.ElementAtOrDefault(0);
								if (Information.IsNothing(aircraft.GetLoadout()))
								{
									text4 = "";
								}
								else
								{
									text4 = " (" + aircraft.GetLoadout().Name + ")";
								}
								if (aircraft.IsOperating())
								{
									text3 = " (Airborne)";
								}
								else
								{
									text3 = aircraft.GetAircraftAirOps().GetCurrentHostUnit().Name;
								}
							}
							else
							{
								text4 = "";
							}
							if (string.IsNullOrEmpty(group.GetUnitsInGroup().Values.ElementAtOrDefault(0).UnitClass))
							{
								text5 = "";
							}
							else
							{
								text5 = group.GetUnitsInGroup().Values.ElementAtOrDefault(0).UnitClass;
							}
							text2 = string.Concat(new string[]
							{
								text2,
								" (",
								Conversions.ToString(group.GetUnitsInGroup().Count),
								"x ",
								text5,
								text4,
								text3,
								")"
							});
						}
					}
					if (current2.IsAircraft)
					{
						Aircraft aircraft2 = (Aircraft)current2;
						if (Information.IsNothing(aircraft2.GetLoadout()))
						{
							text4 = "";
						}
						else
						{
							text4 = " (" + aircraft2.GetLoadout().Name + ")";
						}
					}
					else
					{
						text4 = "";
					}
					if (string.IsNullOrEmpty(current2.UnitClass))
					{
						text5 = "";
					}
					else
					{
						text5 = " (" + Misc.smethod_11(current2.UnitClass) + ")";
					}
					TreeNode treeNode4 = this.vmethod_22().Nodes.Add(text2 + text5 + text4);
                    current2X = current2;

                    this.method_8(ref current2X, ref treeNode4);
					treeNode4.Tag = current2;
					if (current2.IsGroup)
					{
						foreach (ActiveUnit current3 in ((Group)current2).GetUnitsInGroup().Values)
						{
							if (current3.IsAircraft)
							{
								text2 = this.method_11((Aircraft)current3, false);
							}
							else
							{
								text2 = current3.Name;
							}
							treeNode4.Nodes.Add(text2).Tag = current3;
						}
					}
				}
				if (this.GetSelectedMission().category == Mission.MissionCategory.Package && !Information.IsNothing(this.GetSelectedMission().EmptySlotsList))
				{
					foreach (Mission.EmptySlot current4 in this.GetSelectedMission().EmptySlotsList)
					{
						if (!Information.IsNothing(current4.GetFlight(Client.GetClientScenario())))
						{
							list4.Add(current4);
						}
						else
						{
							TreeNode treeNode5 = null;
							string unitClass2 = current4.UnitClass;
							IEnumerator enumerator6 = this.vmethod_22().Nodes.GetEnumerator();
							try
							{
								while (enumerator6.MoveNext())
								{
									TreeNode treeNode6 = (TreeNode)enumerator6.Current;
									if (Operators.CompareString(treeNode6.Tag.ToString(), unitClass2, false) == 0)
									{
										treeNode5 = treeNode6;
									}
								}
							}
							finally
							{
								if (enumerator6 is IDisposable)
								{
									(enumerator6 as IDisposable).Dispose();
								}
							}
							if (Information.IsNothing(treeNode5))
							{
								treeNode5 = this.vmethod_22().Nodes.Add(current4.UnitClass);
								treeNode5.Tag = current4.UnitClass;
							}
							string text6 = string.Concat(new string[]
							{
								"[EMPTY SLOT] (",
								current4.LoadoutName,
								") (",
								current4.CurrentHostUnit_Name,
								")"
							});
							if (current4.IsEscort && !text6.StartsWith("[Escort]"))
							{
								text6 = "[Escort] " + text6;
							}
							treeNode5.Nodes.Add(text6).Tag = current4;
							treeNode5.Text = Conversions.ToString(treeNode5.Nodes.Count) + "x " + Misc.smethod_11(Conversions.ToString(treeNode5.Tag));
							treeNode5 = null;
						}
					}
				}
                Aircraft current5X;

                foreach (Aircraft current5 in list6)
				{
					TreeNode treeNode7 = null;
					string callsign = current5.GetAircraftNavigator().GetFlight().Callsign;
					IEnumerator enumerator8 = this.vmethod_22().Nodes.GetEnumerator();
					try
					{
						while (enumerator8.MoveNext())
						{
							TreeNode treeNode8 = (TreeNode)enumerator8.Current;
							if (Operators.CompareString(treeNode8.Tag.ToString(), callsign, false) == 0)
							{
								treeNode7 = treeNode8;
							}
						}
					}
					finally
					{
						if (enumerator8 is IDisposable)
						{
							(enumerator8 as IDisposable).Dispose();
						}
					}
					if (Information.IsNothing(treeNode7))
					{
						treeNode7 = this.vmethod_22().Nodes.Add(current5.UnitClass);
						treeNode7.Tag = callsign;
					}
					string text7 = this.method_11(current5, false);
					string text8 = this.method_11(current5, true);
					TreeNode treeNode9 = treeNode7.Nodes.Add(text7);
					treeNode9.Tag = current5;
                    current5X = current5;

                    this.method_7(ref current5X, ref treeNode9);
					treeNode7.Text = string.Concat(new string[]
					{
						"Flight ",
						callsign,
						" (",
						Conversions.ToString(treeNode7.Nodes.Count),
						"x ",
						text8,
						")"
					});
					treeNode7 = null;
				}
				if (this.GetSelectedMission().category == Mission.MissionCategory.Package && !Information.IsNothing(this.GetSelectedMission().EmptySlotsList))
				{
					foreach (Mission.EmptySlot current6 in list4)
					{
						TreeNode treeNode10 = null;
						string callsign2 = current6.GetFlight(Client.GetClientScenario()).Callsign;
						IEnumerator enumerator10 = this.vmethod_22().Nodes.GetEnumerator();
						try
						{
							while (enumerator10.MoveNext())
							{
								TreeNode treeNode11 = (TreeNode)enumerator10.Current;
								if (Operators.CompareString(treeNode11.Tag.ToString(), callsign2, false) == 0)
								{
									treeNode10 = treeNode11;
								}
							}
						}
						finally
						{
							if (enumerator10 is IDisposable)
							{
								(enumerator10 as IDisposable).Dispose();
							}
						}
						if (Information.IsNothing(treeNode10))
						{
							treeNode10 = this.vmethod_22().Nodes.Add(current6.UnitClass);
							treeNode10.Tag = callsign2;
						}
						string text9 = string.Concat(new string[]
						{
							"[EMPTY SLOT] (",
							current6.LoadoutName,
							") (",
							current6.CurrentHostUnit_Name,
							")"
						});
						string text10 = string.Concat(new string[]
						{
							current6.UnitClass,
							" (",
							current6.LoadoutName,
							") (",
							current6.CurrentHostUnit_Name,
							")"
						});
						if (current6.IsEscort)
						{
							if (!text9.StartsWith("[Escort]"))
							{
								text9 = "[Escort] " + text9;
							}
							if (!text10.StartsWith("[Escort]"))
							{
								text10 = "[Escort] " + text10;
							}
						}
						treeNode10.Nodes.Add(text9).Tag = current6;
						treeNode10.Text = string.Concat(new string[]
						{
							"Flight ",
							callsign2,
							" ([HAS EMPTY SLOTS] ",
							Conversions.ToString(treeNode10.Nodes.Count),
							"x ",
							text10,
							")"
						});
						treeNode10 = null;
					}
				}
			}
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x001B38C0 File Offset: 0x001B1AC0
		private string method_11(Aircraft aircraft_0, bool bool_33)
		{
            string str = null;
            string name;
            string str4;
            if (aircraft_0.GetMaintenanceLevel(ref str) == Aircraft_AirOps._Maintenance.Unavailable)
            {
                if (bool_33)
                {
                    return ("[UNAVAILABLE] " + aircraft_0.UnitClass);
                }
                return ("[UNAVAILABLE] " + aircraft_0.Name);
            }
            if (aircraft_0.IsOperating())
            {
                name = "Airborne";
            }
            else
            {
                name = aircraft_0.GetAircraftAirOps().GetCurrentHostUnit().Name;
                string text1 = " (" + Misc.GetTimeString((long)Math.Round((double)aircraft_0.GetAircraftAirOps().GetConditionTimer()), Aircraft_AirOps._Maintenance.const_0, false, false) + ")";
            }
            if (Information.IsNothing(aircraft_0.GetLoadout()))
            {
                str4 = "";
            }
            else
            {
                str4 = " (" + aircraft_0.GetLoadout().Name + ")";
            }
            if (bool_33)
            {
                return (aircraft_0.UnitClass + str4 + " (" + name + ")");
            }
            return (aircraft_0.Name + str4 + " (" + name + ")");

        }

        // Token: 0x06004893 RID: 18579 RVA: 0x001B3A14 File Offset: 0x001B1C14
        public void method_12()
		{
			this.vmethod_20().Nodes.Clear();
			List<Aircraft> list = new List<Aircraft>();
			List<ActiveUnit> list2 = new List<ActiveUnit>();
			if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().category != Mission.MissionCategory.Mission && this.GetSelectedMission().category != Mission.MissionCategory.TaskPool)
			{
				if (string.IsNullOrEmpty(this.GetSelectedMission().GetTaskPoolID(Client.GetClientSide())))
				{
					return;
				}
				using (IEnumerator<Mission> enumerator = Client.GetClientSide().GetMissionCollection().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Mission current = enumerator.Current;
						if (Operators.CompareString(current.GetGuid(), this.GetSelectedMission().GetTaskPoolID(Client.GetClientSide()), false) == 0)
						{
							List<ActiveUnit> list3 = current.GetUnitsAssignedToMyTaskPool(Client.GetClientScenario()).Select(MissionEditor.ActiveUnitFunc11).OrderBy(MissionEditor.ActiveUnitFunc12, new Class265<string[]>(true)).ToList<ActiveUnit>();
							new Dictionary<TreeNode, int>();
							Dictionary<TreeNode, int> dictionary = new Dictionary<TreeNode, int>();
							List<Mission.Class131> list4 = new List<Mission.Class131>();
							foreach (ActiveUnit activeUnit in list3)
							{
								if (Information.IsNothing(activeUnit.GetAssignedMission(false)) || activeUnit.GetAssignedMission(false) != this.GetSelectedMission())
								{
									TreeNode treeNode = null;
									if (activeUnit.IsAircraft)
									{
										string unitClass = activeUnit.UnitClass;
										foreach (TreeNode current2 in dictionary.Keys)
										{
											if (Operators.CompareString(current2.Tag.ToString(), unitClass, false) == 0)
											{
												treeNode = current2;
											}
										}
										if (Information.IsNothing(activeUnit.GetAssignedMission(false)))
										{
											if (Information.IsNothing(treeNode))
											{
												treeNode = new TreeNode();
												treeNode.Tag = activeUnit.UnitClass;
												dictionary.Add(treeNode, 1);
											}
											else
											{
												Dictionary<TreeNode, int> dictionary2;
												TreeNode key;
												(dictionary2 = dictionary)[key = treeNode] = dictionary2[key] + 1;
											}
											string text = this.method_11((Aircraft)activeUnit, false);
											TreeNode treeNode2 = treeNode.Nodes.Add(text);
											treeNode2.Tag = activeUnit;
											Aircraft aircraft = (Aircraft)activeUnit;
											this.method_7(ref aircraft, ref treeNode2);
											//ZSP ERR activeUnit = aircraft;
										}
										else if (activeUnit.IsGroup)
										{
											string text2 = activeUnit.Name;
											if (((Group)activeUnit).GetGroupType() == Group.GroupType.AirGroup && ((Group)activeUnit).GetUnitsInGroup().Count > 0)
											{
												text2 = string.Concat(new string[]
												{
													text2,
													" (",
													Conversions.ToString(((Group)activeUnit).GetUnitsInGroup().Count),
													"x ",
													((Group)activeUnit).GetUnitsInGroup().Values.ElementAtOrDefault(0).UnitClass,
													")"
												});
											}
											TreeNode treeNode3 = this.vmethod_20().Nodes.Add(text2);
											treeNode3.Tag = activeUnit;
											foreach (ActiveUnit current3 in ((Group)activeUnit).GetUnitsInGroup().Values)
											{
												string str;
												if (current3.IsAircraft)
												{
													str = this.method_11((Aircraft)current3, false);
												}
												else
												{
													str = current3.Name;
												}
												string str2;
												if (string.IsNullOrEmpty(activeUnit.UnitClass))
												{
													str2 = "";
												}
												else
												{
													str2 = " (" + Misc.smethod_11(activeUnit.UnitClass) + ")";
												}
												treeNode3.Nodes.Add(str + str2).Tag = current3;
											}
										}
										if (!activeUnit.IsOperating())
										{
											bool flag = false;
											Aircraft aircraft2 = (Aircraft)activeUnit;
											foreach (Mission.Class131 current4 in list4)
											{
												if (current4.int_0 == activeUnit.DBID && activeUnit.IsAircraft && (!Information.IsNothing(aircraft2.GetLoadout()) || current4.int_1 != 0) && (Information.IsNothing(aircraft2.GetLoadout()) || current4.int_1 == aircraft2.GetLoadout().DBID) && Operators.CompareString(current4.string_0, aircraft2.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), false) == 0)
												{
													flag = true;
													break;
												}
											}
											if (!flag)
											{
												int int_ = 0;
												string string_ = "";
												if (!Information.IsNothing(aircraft2.GetLoadout()))
												{
													int_ = aircraft2.GetLoadout().DBID;
													string_ = aircraft2.GetLoadout().Name;
												}
												Mission.Class131 item = new Mission.Class131(aircraft2.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), aircraft2.GetAircraftAirOps().GetCurrentHostUnit().Name, aircraft2.DBID, aircraft2.UnitClass, int_, string_);
												list4.Add(item);
											}
										}
									}
								}
							}
							foreach (TreeNode current5 in dictionary.Keys)
							{
								current5.Text = Conversions.ToString(dictionary[current5]) + "x " + Misc.smethod_11(Conversions.ToString(current5.Tag));
								this.vmethod_20().Nodes.Add(current5);
							}
							IEnumerator enumerator7 = this.vmethod_20().Nodes.GetEnumerator();
							try
							{
								while (enumerator7.MoveNext())
								{
									TreeNode treeNode4 = (TreeNode)enumerator7.Current;
									if (treeNode4.Tag.GetType() == typeof(string) && treeNode4.Nodes.Count > 0)
									{
										treeNode4.Text = Conversions.ToString(treeNode4.Nodes.Count) + "x " + Misc.smethod_11(Conversions.ToString(treeNode4.Tag));
									}
								}
							}
							finally
							{
								if (enumerator7 is IDisposable)
								{
									(enumerator7 as IDisposable).Dispose();
								}
							}
							foreach (Mission.Class131 current6 in list4)
							{
								string takeOffLocation_HostUnitObjectName = current6.TakeOffLocation_HostUnitObjectName;
								string strLoadoutName = current6.strLoadoutName;
								TreeNode treeNode = new TreeNode();
								treeNode.Text = string.Concat(new string[]
								{
									current6.strAircraftType,
									" [EMPTY SLOTS] (",
									strLoadoutName,
									") (",
									takeOffLocation_HostUnitObjectName,
									")"
								});
								dictionary.Add(treeNode, 1);
								this.vmethod_20().Nodes.Add(treeNode);
								treeNode.Tag = treeNode.Text;
								ActiveUnit aircraft_ = null;
								int int_2 = current6.int_0;
								string strAircraftType = current6.strAircraftType;
								int int_3 = current6.int_1;
								string strLoadoutName2 = current6.strLoadoutName;
								ActiveUnit activeUnit2 = null;
								Mission.EmptySlot emptySlot = new Mission.EmptySlot(aircraft_, int_2, strAircraftType, int_3, strLoadoutName2, ref activeUnit2, current6.string_0, current6.TakeOffLocation_HostUnitObjectName);
								emptySlot.int_4 = 1;
								string text3 = string.Concat(new string[]
								{
									"[EMPTY SLOT x 1] (",
									strLoadoutName,
									") (",
									current6.TakeOffLocation_HostUnitObjectName,
									")"
								});
								treeNode.Nodes.Add(text3).Tag = emptySlot;
								ActiveUnit aircraft_2 = null;
								int int_4 = current6.int_0;
								string strAircraftType2 = current6.strAircraftType;
								int int_5 = current6.int_1;
								string strLoadoutName3 = current6.strLoadoutName;
								activeUnit2 = null;
								emptySlot = new Mission.EmptySlot(aircraft_2, int_4, strAircraftType2, int_5, strLoadoutName3, ref activeUnit2, current6.string_0, current6.TakeOffLocation_HostUnitObjectName);
								emptySlot.int_4 = 2;
								text3 = string.Concat(new string[]
								{
									"[EMPTY SLOT x 2] (",
									strLoadoutName,
									") (",
									current6.TakeOffLocation_HostUnitObjectName,
									")"
								});
								treeNode.Nodes.Add(text3).Tag = emptySlot;
								ActiveUnit aircraft_3 = null;
								int int_6 = current6.int_0;
								string strAircraftType3 = current6.strAircraftType;
								int int_7 = current6.int_1;
								string strLoadoutName4 = current6.strLoadoutName;
								activeUnit2 = null;
								emptySlot = new Mission.EmptySlot(aircraft_3, int_6, strAircraftType3, int_7, strLoadoutName4, ref activeUnit2, current6.string_0, current6.TakeOffLocation_HostUnitObjectName);
								emptySlot.int_4 = 3;
								text3 = string.Concat(new string[]
								{
									"[EMPTY SLOT x 3] (",
									strLoadoutName,
									") (",
									current6.TakeOffLocation_HostUnitObjectName,
									")"
								});
								treeNode.Nodes.Add(text3).Tag = emptySlot;
								ActiveUnit aircraft_4 = null;
								int int_8 = current6.int_0;
								string strAircraftType4 = current6.strAircraftType;
								int int_9 = current6.int_1;
								string strLoadoutName5 = current6.strLoadoutName;
								activeUnit2 = null;
								emptySlot = new Mission.EmptySlot(aircraft_4, int_8, strAircraftType4, int_9, strLoadoutName5, ref activeUnit2, current6.string_0, current6.TakeOffLocation_HostUnitObjectName);
								emptySlot.int_4 = 4;
								text3 = string.Concat(new string[]
								{
									"[EMPTY SLOT x 4] (",
									strLoadoutName,
									") (",
									current6.TakeOffLocation_HostUnitObjectName,
									")"
								});
								treeNode.Nodes.Add(text3).Tag = emptySlot;
								ActiveUnit aircraft_5 = null;
								int int_10 = current6.int_0;
								string strAircraftType5 = current6.strAircraftType;
								int int_11 = current6.int_1;
								string strLoadoutName6 = current6.strLoadoutName;
								activeUnit2 = null;
								emptySlot = new Mission.EmptySlot(aircraft_5, int_10, strAircraftType5, int_11, strLoadoutName6, ref activeUnit2, current6.string_0, current6.TakeOffLocation_HostUnitObjectName);
								emptySlot.int_4 = 6;
								text3 = string.Concat(new string[]
								{
									"[EMPTY SLOT x 6] (",
									strLoadoutName,
									") (",
									current6.TakeOffLocation_HostUnitObjectName,
									")"
								});
								treeNode.Nodes.Add(text3).Tag = emptySlot;
								ActiveUnit aircraft_6 = null;
								int int_12 = current6.int_0;
								string strAircraftType6 = current6.strAircraftType;
								int int_13 = current6.int_1;
								string strLoadoutName7 = current6.strLoadoutName;
								activeUnit2 = null;
								emptySlot = new Mission.EmptySlot(aircraft_6, int_12, strAircraftType6, int_13, strLoadoutName7, ref activeUnit2, current6.string_0, current6.TakeOffLocation_HostUnitObjectName);
								emptySlot.int_4 = 8;
								text3 = string.Concat(new string[]
								{
									"[EMPTY SLOT x 8] (",
									strLoadoutName,
									") (",
									current6.TakeOffLocation_HostUnitObjectName,
									")"
								});
								treeNode.Nodes.Add(text3).Tag = emptySlot;
								ActiveUnit aircraft_7 = null;
								int int_14 = current6.int_0;
								string strAircraftType7 = current6.strAircraftType;
								int int_15 = current6.int_1;
								string strLoadoutName8 = current6.strLoadoutName;
								activeUnit2 = null;
								emptySlot = new Mission.EmptySlot(aircraft_7, int_14, strAircraftType7, int_15, strLoadoutName8, ref activeUnit2, current6.string_0, current6.TakeOffLocation_HostUnitObjectName);
								emptySlot.int_4 = 12;
								text3 = string.Concat(new string[]
								{
									"[EMPTY SLOT x 12] (",
									strLoadoutName,
									") (",
									current6.TakeOffLocation_HostUnitObjectName,
									")"
								});
								treeNode.Nodes.Add(text3).Tag = emptySlot;
								ActiveUnit aircraft_8 = null;
								int int_16 = current6.int_0;
								string strAircraftType8 = current6.strAircraftType;
								int int_17 = current6.int_1;
								string strLoadoutName9 = current6.strLoadoutName;
								activeUnit2 = null;
								emptySlot = new Mission.EmptySlot(aircraft_8, int_16, strAircraftType8, int_17, strLoadoutName9, ref activeUnit2, current6.string_0, current6.TakeOffLocation_HostUnitObjectName);
								emptySlot.int_4 = 16;
								text3 = string.Concat(new string[]
								{
									"[EMPTY SLOT x 16] (",
									strLoadoutName,
									") (",
									current6.TakeOffLocation_HostUnitObjectName,
									")"
								});
								treeNode.Nodes.Add(text3).Tag = emptySlot;
								ActiveUnit aircraft_9 = null;
								int int_18 = current6.int_0;
								string strAircraftType9 = current6.strAircraftType;
								int int_19 = current6.int_1;
								string strLoadoutName10 = current6.strLoadoutName;
								activeUnit2 = null;
								emptySlot = new Mission.EmptySlot(aircraft_9, int_18, strAircraftType9, int_19, strLoadoutName10, ref activeUnit2, current6.string_0, current6.TakeOffLocation_HostUnitObjectName);
								emptySlot.int_4 = 24;
								text3 = string.Concat(new string[]
								{
									"[EMPTY SLOT x 24] (",
									strLoadoutName,
									") (",
									current6.TakeOffLocation_HostUnitObjectName,
									")"
								});
								treeNode.Nodes.Add(text3).Tag = emptySlot;
							}
							break;
						}
					}
					return;
				}
			}
			ActiveUnit[] activeUnitArray = Client.GetClientSide().ActiveUnitArray;
			List<Aircraft> list5;
			List<ActiveUnit> list6;
			Dictionary<TreeNode, int> dictionary3;
			checked
			{
				for (int i = 0; i < activeUnitArray.Length; i++)
				{
					ActiveUnit activeUnit3 = activeUnitArray[i];
					if (!activeUnit3.HasParentGroup() && !activeUnit3.IsWeapon && Information.IsNothing(activeUnit3.GetAssignedMission(false)) && Information.IsNothing(activeUnit3.GetAssignedTaskPool()))
					{
						if (activeUnit3.IsAircraft)
						{
							list.Add((Aircraft)activeUnit3);
						}
						else if (!activeUnit3.IsSubmarine || !((Submarine)activeUnit3).IsROV())
						{
							list2.Add(activeUnit3);
						}
					}
				}
				list5 = list.Select(MissionEditor.AircraftFunc7).OrderBy(MissionEditor.AircraftFunc8, new Class265<string[]>(true)).ToList<Aircraft>();
				list6 = list2.Select(MissionEditor.ActiveUnitFunc9).OrderBy(MissionEditor.ActiveUnitFunc10, new Class265<string[]>(true)).ToList<ActiveUnit>();
				dictionary3 = new Dictionary<TreeNode, int>();
			}
            Aircraft current7X;

            foreach (Aircraft current7 in list5)
			{
				TreeNode treeNode = null;
				string unitClass2 = current7.UnitClass;
				foreach (TreeNode current8 in dictionary3.Keys)
				{
					if (Operators.CompareString(current8.Tag.ToString(), unitClass2, false) == 0)
					{
						treeNode = current8;
					}
				}
				if (Information.IsNothing(treeNode))
				{
					treeNode = new TreeNode();
					treeNode.Tag = current7.UnitClass;
					dictionary3.Add(treeNode, 1);
				}
				else
				{
					Dictionary<TreeNode, int> dictionary2;
					TreeNode key;
					(dictionary2 = dictionary3)[key = treeNode] = dictionary2[key] + 1;
				}
				string text4 = this.method_11(current7, false);
				TreeNode treeNode5 = treeNode.Nodes.Add(text4);
				treeNode5.Tag = current7;
                current7X = current7;

                this.method_7(ref current7X, ref treeNode5);
			}
			foreach (TreeNode current9 in dictionary3.Keys)
			{
				current9.Text = Conversions.ToString(dictionary3[current9]) + "x " + Misc.smethod_11(Conversions.ToString(current9.Tag));
				this.vmethod_20().Nodes.Add(current9);
			}
			foreach (ActiveUnit current10 in list6)
			{
				if (current10.IsGroup)
				{
					string text5 = current10.Name;
					if (((Group)current10).GetGroupType() == Group.GroupType.AirGroup && ((Group)current10).GetUnitsInGroup().Count > 0)
					{
						text5 = string.Concat(new string[]
						{
							text5,
							" (",
							Conversions.ToString(((Group)current10).GetUnitsInGroup().Count),
							"x ",
							((Group)current10).GetUnitsInGroup().Values.ElementAtOrDefault(0).UnitClass,
							")"
						});
					}
					TreeNode treeNode6 = this.vmethod_20().Nodes.Add(text5);
					treeNode6.Tag = current10;
					using (IEnumerator<ActiveUnit> enumerator13 = ((Group)current10).GetUnitsInGroup().Values.GetEnumerator())
					{
						while (enumerator13.MoveNext())
						{
							ActiveUnit current11 = enumerator13.Current;
							string str3;
							if (current11.IsAircraft)
							{
								str3 = this.method_11((Aircraft)current11, false);
							}
							else
							{
								str3 = current11.Name;
							}
							string str2;
							if (string.IsNullOrEmpty(current10.UnitClass))
							{
								str2 = "";
							}
							else
							{
								str2 = " (" + Misc.smethod_11(current10.UnitClass) + ")";
							}
							treeNode6.Nodes.Add(str3 + str2).Tag = current11;
						}
						continue;
					}
				}
				if (!current10.HasParentGroup())
				{
					string name = current10.Name;
					this.vmethod_20().Nodes.Add(name + " (" + Misc.smethod_11(current10.UnitClass) + ")").Tag = current10;
				}
			}
			IEnumerator enumerator14 = this.vmethod_20().Nodes.GetEnumerator();
			try
			{
				while (enumerator14.MoveNext())
				{
					TreeNode treeNode7 = (TreeNode)enumerator14.Current;
					if (treeNode7.Tag.GetType() == typeof(string) && treeNode7.Nodes.Count > 0)
					{
						treeNode7.Text = Conversions.ToString(treeNode7.Nodes.Count) + "x " + Misc.smethod_11(Conversions.ToString(treeNode7.Tag));
					}
				}
			}
			finally
			{
				if (enumerator14 is IDisposable)
				{
					(enumerator14 as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x001B4D88 File Offset: 0x001B2F88
		private void method_13(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(e.Node.Tag)) && e.Node.Tag.GetType().BaseType.BaseType == typeof(ActiveUnit))
			{
				this.SelectedUnit = (ActiveUnit)e.Node.Tag;
				this.SelectedUnit.DeleteMission(false, this.GetSelectedMission());
				this.method_10();
				this.method_12();
			}
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x001B4E14 File Offset: 0x001B3014
		private void method_14(TreeNodeCollection treeNodeCollection_0, ref List<TreeNode> list_0)
		{
			IEnumerator enumerator = treeNodeCollection_0.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator.Current;
					if (treeNode.Tag.GetType() == typeof(string))
					{
						this.method_14(treeNode.Nodes, ref list_0);
					}
					else if (treeNode.Checked)
					{
						list_0.Add(treeNode);
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

		// Token: 0x06004896 RID: 18582 RVA: 0x001B4EAC File Offset: 0x001B30AC
		private void Button_AssignUnitsToMission_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				List<TreeNode> list = new List<TreeNode>();
				this.method_14(this.vmethod_20().Nodes, ref list);
				foreach (TreeNode current in list)
				{
					if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(current.Tag)))
					{
						if (current.Tag.GetType() == typeof(string))
						{
							if (current.Nodes.Count <= 0)
							{
								continue;
							}
							IEnumerator enumerator2 = current.Nodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									TreeNode treeNode = (TreeNode)enumerator2.Current;
									if (((Unit)treeNode.Tag).IsActiveUnit())
									{
										this.SelectedUnit = (ActiveUnit)treeNode.Tag;
										if (this.GetSelectedMission().MissionClass == Mission._MissionClass.Ferry && !this.SelectedUnit.IsAircraft && (!this.SelectedUnit.IsGroup || ((Group)this.SelectedUnit).GetGroupType() != Group.GroupType.AirGroup))
										{
											Interaction.MsgBox(this.SelectedUnit.Name + "不是飞机，不能执行转场任务.", MsgBoxStyle.OkOnly, null);
										}
										else if (this.SelectedUnit.IsAircraft && Information.IsNothing(((Aircraft)this.SelectedUnit).GetLoadout()))
										{
											Interaction.MsgBox("飞机：" + this.SelectedUnit.Name + "没有挂载，不能分配任何任务.", MsgBoxStyle.OkOnly, "飞机没有挂载!");
										}
										else
										{
											StrikePlanner.smethod_37(this.SelectedUnit.m_Scenario, this.GetSelectedMission(), ref this.SelectedUnit);
											this.SelectedUnit.DeleteMission(false, this.GetSelectedMission());
											this.SelectedUnit.m_Doctrine.Init();
											this.SelectedUnit.GetSensory().ScheduleEMCONEvent(this.SelectedUnit.GetAllNoneMCMSensors());
											if ((this.SelectedUnit.IsAircraft || ((Group)this.SelectedUnit).GetGroupType() == Group.GroupType.AirGroup) && this.SelectedUnit.IsOperating())
											{
												Collection<ActiveUnit> collection = new Collection<ActiveUnit>();
												collection.Add(this.SelectedUnit);
												StrikePlanner.smethod_0(Client.GetClientScenario(), this.GetSelectedMission(), ref collection, true);
												CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
											}
											if (this.GetSelectedMission().MissionClass == Mission._MissionClass.Cargo)
											{
												((CargoMissionViewModel)this.cargoMissionControl_0.DataContext).method_2(this.SelectedUnit);
											}
										}
									}
								}
								continue;
							}
							finally
							{
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
						if (current.Tag.GetType() == typeof(Mission.EmptySlot))
						{
							if (this.GetSelectedMission().category == Mission.MissionCategory.Package)
							{
								Mission.EmptySlot emptySlot = (Mission.EmptySlot)current.Tag;
								if (emptySlot.LoadoutDBID == 0)
								{
									Interaction.MsgBox("Empty slot " + emptySlot.UnitClass + "没有挂载，不能分配任何任务.", MsgBoxStyle.OkOnly, "Slot with no loadout!");
								}
								else
								{
									if (!Information.IsNothing(emptySlot.method_0(Client.GetClientScenario(), this.GetSelectedMission())))
									{
										Scenario clientScenario = Client.GetClientScenario();
										Mission selectedMission = this.GetSelectedMission();
										Mission.EmptySlot emptySlot2;
										Scenario clientScenario2;
										Mission selectedMission2;
										ActiveUnit activeUnit_ = (emptySlot2 = emptySlot).method_0(clientScenario2 = Client.GetClientScenario(), selectedMission2 = this.GetSelectedMission());
										StrikePlanner.smethod_37(clientScenario, selectedMission, ref activeUnit_);
										emptySlot2.method_1(clientScenario2, selectedMission2, activeUnit_);
									}
									int int_ = emptySlot.int_4;
									if (Information.IsNothing(this.GetSelectedMission().EmptySlotsList))
									{
										this.GetSelectedMission().EmptySlotsList = new List<Mission.EmptySlot>();
									}
									int num = int_;
									for (int i = 1; i <= num; i++)
									{
										ActiveUnit aircraft_ = emptySlot.method_0(Client.GetClientScenario(), null);
										int aircraftDBID = emptySlot.aircraftDBID;
										string unitClass = emptySlot.UnitClass;
										int loadoutDBID = emptySlot.LoadoutDBID;
										string loadoutName = emptySlot.LoadoutName;
										Mission.EmptySlot emptySlot2;
										Scenario clientScenario2;
										ActiveUnit activeUnit_ = (emptySlot2 = emptySlot).GetHostUnit(clientScenario2 = Client.GetClientScenario());
										Mission.EmptySlot emptySlot3 = new Mission.EmptySlot(aircraft_, aircraftDBID, unitClass, loadoutDBID, loadoutName, ref activeUnit_, emptySlot.CurrentHostUnit_ObjectID, emptySlot.CurrentHostUnit_Name);
										emptySlot2.SetHostUnit(clientScenario2, activeUnit_);
										Mission.EmptySlot item = emptySlot3;
										this.GetSelectedMission().EmptySlotsList.Add(item);
									}
								}
							}
						}
						else
						{
							this.SelectedUnit = (ActiveUnit)current.Tag;
							if (this.GetSelectedMission().MissionClass == Mission._MissionClass.Ferry && !this.SelectedUnit.IsAircraft && (!this.SelectedUnit.IsGroup || ((Group)this.SelectedUnit).GetGroupType() != Group.GroupType.AirGroup))
							{
								Interaction.MsgBox(this.SelectedUnit.Name + "不是飞机，不能执行转场任务.", MsgBoxStyle.OkOnly, null);
							}
							else if (this.SelectedUnit.IsAircraft && Information.IsNothing(((Aircraft)this.SelectedUnit).GetLoadout()))
							{
								Interaction.MsgBox("飞机:" + this.SelectedUnit.Name + "没有挂载,不能分配任何任务.", MsgBoxStyle.OkOnly, "飞机没挂载!");
							}
							else
							{
								StrikePlanner.smethod_37(this.SelectedUnit.m_Scenario, this.GetSelectedMission(), ref this.SelectedUnit);
								if (this.GetSelectedMission().category == Mission.MissionCategory.TaskPool)
								{
									this.SelectedUnit.SetAssignedTaskPool(this.GetSelectedMission());
								}
								else
								{
									this.SelectedUnit.DeleteMission(false, this.GetSelectedMission());
								}
								this.SelectedUnit.m_Doctrine.Init();
								this.SelectedUnit.GetSensory().ScheduleEMCONEvent(this.SelectedUnit.GetAllNoneMCMSensors());
								if ((this.SelectedUnit.IsAircraft || (this.SelectedUnit.IsGroup && ((Group)this.SelectedUnit).GetGroupType() == Group.GroupType.AirGroup)) && this.SelectedUnit.IsOperating())
								{
									Collection<ActiveUnit> collection2 = new Collection<ActiveUnit>();
									collection2.Add(this.SelectedUnit);
									StrikePlanner.smethod_0(Client.GetClientScenario(), this.GetSelectedMission(), ref collection2, true);
									CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
								}
								if (this.GetSelectedMission().MissionClass == Mission._MissionClass.Cargo)
								{
									((CargoMissionViewModel)this.cargoMissionControl_0.DataContext).method_2(this.SelectedUnit);
								}
							}
						}
					}
				}
				this.method_10();
				this.method_12();
				if (this.SelectedUnit != null)
				{
					this.SelectedUnit.m_Doctrine.method_1(this.SelectedUnit, new bool?(false), false, false, false, false);
					Scenario scenario = this.SelectedUnit.m_Scenario;
					Side side = null;
					Mission selectedMission2 = this.GetSelectedMission();
					List<string> list2 = scenario.FlightSizeHardLimitCheckInfo(ref side, ref selectedMission2);
					this.method_5(selectedMission2);
					List<string> list3 = list2;
					string text = "";
					if (list3.Count > 0)
					{
						text = "警告!由于编队规模限制，该任务行动中的某些飞机不能起飞!\r\n\r\n为解决这个问题，您可以改变编队规模，向任务行动中分配更多飞机，也可以改变现有飞机的挂载方案使得足够多的飞机具备相同的挂载.\r\n\r\n";
						foreach (string current2 in list3)
						{
							text = text + "\r\n" + current2;
						}
					}
					if (!string.IsNullOrEmpty(text))
					{
						Interaction.MsgBox(text, MsgBoxStyle.Exclamation, null);
					}
				}
				this.GetSelectedMission().int_0 = 1;
			}
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x001B564C File Offset: 0x001B384C
		private void Button_UnassignUnitsToMission_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				List<TreeNode> list = new List<TreeNode>();
				this.method_14(this.vmethod_22().Nodes, ref list);
				foreach (TreeNode current in list)
				{
					if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(current.Tag)))
					{
						if (current.Tag.GetType() == typeof(string))
						{
							IEnumerator enumerator2 = current.Nodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									TreeNode treeNode = (TreeNode)enumerator2.Current;
									if (treeNode.Tag.GetType().BaseType.BaseType == typeof(ActiveUnit))
									{
										this.SelectedUnit = (ActiveUnit)treeNode.Tag;
										this.SelectedUnit.DeleteMission(false, null);
										this.SelectedUnit.m_Doctrine.Init();
										this.SelectedUnit.GetSensory().ScheduleEMCONEvent(this.SelectedUnit.GetAllNoneMCMSensors());
										if (this.SelectedUnit.GetAI().IsEscort)
										{
											this.SelectedUnit.GetAI().IsEscort = false;
										}
										if (this.GetSelectedMission().MissionClass == Mission._MissionClass.Cargo)
										{
											((CargoMissionViewModel)this.cargoMissionControl_0.DataContext).method_1(this.SelectedUnit);
										}
									}
									else if (current.Tag.GetType() == typeof(Mission.EmptySlot) && this.GetSelectedMission().category == Mission.MissionCategory.Package)
									{
										Mission.EmptySlot item = (Mission.EmptySlot)current.Tag;
										this.GetSelectedMission().EmptySlotsList.Remove(item);
									}
								}
								continue;
							}
							finally
							{
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
						if (current.Tag.GetType() == typeof(Mission.EmptySlot))
						{
							if (this.GetSelectedMission().category == Mission.MissionCategory.Package)
							{
								Mission.EmptySlot item2 = (Mission.EmptySlot)current.Tag;
								this.GetSelectedMission().EmptySlotsList.Remove(item2);
							}
						}
						else
						{
							this.SelectedUnit = (ActiveUnit)current.Tag;
							this.SelectedUnit.DeleteMission(false, null);
							this.SelectedUnit.m_Doctrine.Init();
							this.SelectedUnit.GetSensory().ScheduleEMCONEvent(this.SelectedUnit.GetAllNoneMCMSensors());
							if (this.SelectedUnit.GetAI().IsEscort)
							{
								this.SelectedUnit.GetAI().IsEscort = false;
							}
							if (this.GetSelectedMission().MissionClass == Mission._MissionClass.Cargo)
							{
								((CargoMissionViewModel)this.cargoMissionControl_0.DataContext).method_1(this.SelectedUnit);
							}
						}
					}
				}
				this.method_10();
				this.method_12();
				this.GetSelectedMission().UnassignFlightRemove(Client.GetClientScenario(), Client.GetClientSide());
				if (this.SelectedUnit != null)
				{
					this.SelectedUnit.m_Doctrine.method_1(this.SelectedUnit, new bool?(false), false, false, false, false);
					Scenario scenario = this.SelectedUnit.m_Scenario;
					Side side = null;
					Mission selectedMission = this.GetSelectedMission();
					List<string> list2 = scenario.FlightSizeHardLimitCheckInfo(ref side, ref selectedMission);
					this.method_5(selectedMission);
					List<string> list3 = list2;
					string text = "";
					if (list3.Count > 0)
					{
						text = "警告!由于编队规模限制，该任务行动中的某些飞机不能起飞!\r\n\r\n为解决这个问题，您可以改变编队规模，向任务行动中分配更多飞机，也可以改变现有飞机的挂载方案使得足够多的飞机具备相同的挂载。\r\n\r\n";
						foreach (string current2 in list3)
						{
							text = text + "\r\n" + current2;
						}
					}
					if (!string.IsNullOrEmpty(text))
					{
						Interaction.MsgBox(text, MsgBoxStyle.Exclamation, null);
					}
				}
				this.GetSelectedMission().int_0 = 1;
			}
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x001B5A90 File Offset: 0x001B3C90
		private void Button_DeleteMission_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.vmethod_6().SelectedNode))
			{
				this.method_5((Mission)this.vmethod_6().SelectedNode.Tag);
				Scenario clientScenario = Client.GetClientScenario();
				Side clientSide = Client.GetClientSide();
				Mission selectedMission = this.GetSelectedMission();
				selectedMission.RemoveThisMission(ref clientScenario, ref clientSide);
				this.method_5(selectedMission);
				Client.SetClientSide(clientSide);
				this.method_9();
				this.method_10();
				this.method_12();
			}
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x00022B5F File Offset: 0x00020D5F
		private void method_18(object sender, EventArgs e)
		{
			Client.newMission.Show();
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x001B5B08 File Offset: 0x001B3D08
		private void MissionEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.method_21();
			this.method_81();
			this.method_84();
			this.method_85();
			this.method_276();
			this.method_86();
			this.method_87();
			this.method_88();
			this.method_279();
			this.method_97();
			this.method_100();
			this.method_89();
			this.method_90();
			this.method_103();
			this.method_106();
			this.method_109();
			this.method_112();
			this.method_115();
			this.method_118();
			this.method_121();
			this.method_135();
			this.method_93();
			this.method_94();
			this.method_95();
			this.method_96();
			this.method_246();
			this.method_248();
			this.method_250();
			this.method_252();
			this.method_148();
			this.method_151();
			this.method_286();
			CommandFactory.GetCommandMain().GetTankerPlanner().Close();
			base.Hide();
			this.GetTC_MissionOptions().Select();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x00022B6B File Offset: 0x00020D6B
		private void method_19(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x00022B74 File Offset: 0x00020D74
		private void method_20(object sender, EventArgs e)
		{
			this.method_21();
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x001B5C0C File Offset: 0x001B3E0C
		private void method_21()
		{
			if (this.bool_0)
			{
				this.bool_0 = false;
				if (!Information.IsNothing(this.GetSelectedMission()))
				{
					this.GetSelectedMission().Name = this.GetTextBox_MissionName().Text;
					this.method_9();
				}
			}
			else
			{
				this.bool_0 = false;
			}
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x001B5C60 File Offset: 0x001B3E60
		private void MissionEditor_Load(object sender, EventArgs e)
		{
			Scenario.AddUnitRemovedEvent(new Scenario.UnitRemovedEventHandler(this.method_22));
			Doctrine.smethod_0(new Doctrine.Delegate9(this.method_2));
			MissionEditor.smethod_0(new MissionEditor.Delegate64(this.method_3));
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.GetTC_MissionOptions().TabPages[0].Enabled = false;
			this.GetTC_MissionOptions().TabPages[1].Enabled = false;
			this.GetTC_MissionOptions().TabPages[2].Enabled = false;
			this.GetTC_MissionOptions().TabPages[3].Enabled = false;
			this.GetTC_MissionOptions().TabPages[4].Enabled = false;
			this.GetTC_MissionOptions().TabPages[5].Enabled = false;
			this.GetTC_MissionOptions().TabPages[6].Enabled = false;
			this.GetTC_MissionOptions().TabPages[7].Enabled = false;
			TabPage tabPage = this.GetTC_MissionOptions().TabPages[8];
			if (!Information.IsNothing(tabPage))
			{
				this.GetTC_MissionOptions().TabPages.Remove(tabPage);
			}
			this.GetGroupBox_TakeOffTime().Visible = false;
			this.GetGroupBox_TimeOnTarget().Visible = false;
			this.GetGroupBox_ActivationTime().Visible = false;
			this.GetGroupBox_DeactivationTime().Visible = false;
			this.GetCB_ScrubIfHuman().Text = "如果推演方由人扮演\r\n则清除任务";
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x001B5DDC File Offset: 0x001B3FDC
		private void method_22(Scenario scenario_0, ActiveUnit activeUnit_1)
		{
			if (scenario_0 == Client.GetClientScenario())
			{
				Class682 class682_ = Class739.smethod_5(this.vmethod_22());
				Class682 class682_2 = Class739.smethod_5(this.vmethod_20());
				ThreadSafeTreeNode threadSafeTreeNode = null;
				foreach (ThreadSafeTreeNode current in Class2529.smethod_6(class682_))
				{
					if (current.Tag == activeUnit_1)
					{
						threadSafeTreeNode = current;
						break;
					}
				}
				if (!Information.IsNothing(threadSafeTreeNode))
				{
					threadSafeTreeNode.method_1();
				}
				foreach (ThreadSafeTreeNode current2 in Class2529.smethod_6(class682_2))
				{
					if (current2.Tag == activeUnit_1)
					{
						threadSafeTreeNode = current2;
						break;
					}
				}
				if (!Information.IsNothing(threadSafeTreeNode))
				{
					threadSafeTreeNode.method_1();
				}
			}
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x001B5ED4 File Offset: 0x001B40D4
		private void MissionEditor_VisibleChanged(object sender, EventArgs e)
		{
			try
			{
				if (base.Visible)
				{
					this.method_1();
					if (this.vmethod_6().Nodes.Count > 0 && Information.IsNothing(this.GetSelectedMission()))
					{
						this.method_5((Mission)this.vmethod_6().Nodes[0].Tag);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200635", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x001B5F88 File Offset: 0x001B4188
		private void method_23(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				new DoctrineForm
				{
					subject = this.GetSelectedMission(),
					bool_5 = false
				}.Show();
			}
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x001B5FC4 File Offset: 0x001B41C4
		private void method_24(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike)
			{
				new DoctrineForm
				{
					subject = this.GetSelectedMission(),
					bool_5 = true
				}.Show();
			}
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x001B6014 File Offset: 0x001B4214
		private void method_25()
		{
			this.GetTC_MissionOptions().TabPages[0].Enabled = false;
			this.GetTC_MissionOptions().TabPages[1].Enabled = false;
			this.GetTC_MissionOptions().TabPages[2].Enabled = false;
			this.GetTC_MissionOptions().TabPages[3].Enabled = false;
			this.GetTC_MissionOptions().TabPages[4].Enabled = false;
			this.GetTC_MissionOptions().TabPages[5].Enabled = false;
			this.GetTC_MissionOptions().TabPages[6].Enabled = false;
			this.GetTC_MissionOptions().TabPages[7].Enabled = false;
			if (Information.IsNothing(this.GetSelectedMission()))
			{
				this.GetTC_MissionOptions().SelectedIndex = 0;
				this.GetCB_Strike_UseOffAxisAttack().Checked = false;
				this.vmethod_126().Items.Clear();
				this.GetCombo_Strike_MinimumContactStanceToTrigger().SelectedIndex = -1;
				this.GetTextBox_MissionName().Text = "";
				this.GetLabel_MissionDescription().Text = "";
				this.GetCB_ScrubIfHuman().Checked = false;
				this.GetCombo_MissionStatus().SelectedIndex = -1;
				this.vmethod_16().Enabled = false;
				this.vmethod_18().Enabled = false;
				this.GetDateTimePicker_ActivationDate().Enabled = false;
				this.GetDateTimePicker_ActivationTime().Enabled = false;
				this.GetDateTimePicker_DeactivationDate().Enabled = false;
				this.GetDateTimePicker_DeactivationTime().Enabled = false;
				this.GetButton_Clear_ActivationTime().Enabled = false;
				this.GetButton_Clear_DeactivationTime().Enabled = false;
				this.GetCB_ScrubIfHuman().Enabled = false;
				this.GetDateTimePicker_ActivationDate().CustomFormat = "None";
				this.GetDateTimePicker_ActivationDate().Format = DateTimePickerFormat.Custom;
				this.GetDateTimePicker_ActivationTime().CustomFormat = "None";
				this.GetDateTimePicker_ActivationTime().Format = DateTimePickerFormat.Custom;
				this.GetDateTimePicker_DeactivationDate().CustomFormat = "None";
				this.GetDateTimePicker_DeactivationDate().Format = DateTimePickerFormat.Custom;
				this.GetDateTimePicker_DeactivationTime().CustomFormat = "None";
				this.GetDateTimePicker_DeactivationTime().Format = DateTimePickerFormat.Custom;
			}
			else
			{
				if (this.GetSelectedMission().GetMissionStatus(Client.GetClientScenario()) == Mission._MissionStatus.Activation)
				{
					this.GetCombo_MissionStatus().SelectedIndex = 0;
				}
				else
				{
					this.GetCombo_MissionStatus().SelectedIndex = 1;
				}
				this.vmethod_16().Enabled = true;
				this.vmethod_18().Enabled = true;
				this.GetDateTimePicker_ActivationDate().Enabled = true;
				this.GetDateTimePicker_ActivationTime().Enabled = true;
				this.GetDateTimePicker_DeactivationDate().Enabled = true;
				this.GetDateTimePicker_DeactivationTime().Enabled = true;
				this.GetButton_Clear_ActivationTime().Enabled = true;
				this.GetButton_Clear_DeactivationTime().Enabled = true;
				this.GetCB_ScrubIfHuman().Enabled = true;
				switch (this.GetSelectedMission().category)
				{
				case Mission.MissionCategory.Mission:
					this.GetGroupBox_ActivationTime().Visible = true;
					this.GetGroupBox_DeactivationTime().Visible = true;
					this.GetGroupBox_TakeOffTime().Visible = false;
					this.GetGroupBox_TimeOnTarget().Visible = false;
					break;
				case Mission.MissionCategory.Package:
					this.GetGroupBox_ActivationTime().Visible = false;
					this.GetGroupBox_DeactivationTime().Visible = false;
					this.GetGroupBox_TakeOffTime().Visible = true;
					this.GetGroupBox_TimeOnTarget().Visible = true;
					break;
				case Mission.MissionCategory.TaskPool:
					this.GetGroupBox_ActivationTime().Visible = false;
					this.GetGroupBox_DeactivationTime().Visible = false;
					this.GetGroupBox_TakeOffTime().Visible = false;
					this.GetGroupBox_TimeOnTarget().Visible = false;
					break;
				}
				if (this.GetSelectedMission().GetStartTime().HasValue)
				{
					this.GetDateTimePicker_ActivationDate().Format = DateTimePickerFormat.Short;
					this.GetDateTimePicker_ActivationTime().Format = DateTimePickerFormat.Time;
					this.GetDateTimePicker_ActivationDate().Value = this.GetSelectedMission().GetStartTime().Value;
					this.GetDateTimePicker_ActivationTime().Value = this.GetSelectedMission().GetStartTime().Value;
				}
				else
				{
					this.GetDateTimePicker_ActivationDate().CustomFormat = "None";
					this.GetDateTimePicker_ActivationDate().Format = DateTimePickerFormat.Custom;
					this.GetDateTimePicker_ActivationTime().CustomFormat = "None";
					this.GetDateTimePicker_ActivationTime().Format = DateTimePickerFormat.Custom;
				}
				if (this.GetSelectedMission().GetEndTime().HasValue)
				{
					this.GetDateTimePicker_DeactivationDate().Format = DateTimePickerFormat.Short;
					this.GetDateTimePicker_DeactivationTime().Format = DateTimePickerFormat.Time;
					this.GetDateTimePicker_DeactivationDate().Value = this.GetSelectedMission().GetEndTime().Value;
					this.GetDateTimePicker_DeactivationTime().Value = this.GetSelectedMission().GetEndTime().Value;
				}
				else
				{
					this.GetDateTimePicker_DeactivationDate().CustomFormat = "None";
					this.GetDateTimePicker_DeactivationDate().Format = DateTimePickerFormat.Custom;
					this.GetDateTimePicker_DeactivationTime().CustomFormat = "None";
					this.GetDateTimePicker_DeactivationTime().Format = DateTimePickerFormat.Custom;
				}
				if (this.GetSelectedMission().GetTakeOffTime().HasValue)
				{
					this.GetDateTimePicker_TakeOffDate().Format = DateTimePickerFormat.Short;
					this.GetDateTimePicker_TakeOffTime().Format = DateTimePickerFormat.Time;
					this.GetDateTimePicker_TakeOffDate().Value = this.GetSelectedMission().GetTakeOffTime().Value;
					this.GetDateTimePicker_TakeOffTime().Value = this.GetSelectedMission().GetTakeOffTime().Value;
				}
				else
				{
					this.GetDateTimePicker_TakeOffDate().CustomFormat = "None";
					this.GetDateTimePicker_TakeOffDate().Format = DateTimePickerFormat.Custom;
					this.GetDateTimePicker_TakeOffTime().CustomFormat = "None";
					this.GetDateTimePicker_TakeOffTime().Format = DateTimePickerFormat.Custom;
				}
				if (this.GetSelectedMission().GetTimeOnTarget().HasValue)
				{
					this.GetDateTimePicker_TimeOnTargetDate().Format = DateTimePickerFormat.Short;
					this.GetDateTimePicker_TimeOnTargetTime().Format = DateTimePickerFormat.Time;
					this.GetDateTimePicker_TimeOnTargetDate().Value = this.GetSelectedMission().GetTimeOnTarget().Value;
					this.GetDateTimePicker_TimeOnTargetTime().Value = this.GetSelectedMission().GetTimeOnTarget().Value;
				}
				else
				{
					this.GetDateTimePicker_TimeOnTargetDate().CustomFormat = "None";
					this.GetDateTimePicker_TimeOnTargetDate().Format = DateTimePickerFormat.Custom;
					this.GetDateTimePicker_TimeOnTargetTime().CustomFormat = "None";
					this.GetDateTimePicker_TimeOnTargetTime().Format = DateTimePickerFormat.Custom;
				}
				this.method_317();
				this.GetCheckBox_UnassignUnits().Checked = this.GetSelectedMission().Deactivation_UnassignUnits;
				this.GetCheckBox_OrderRTB().Checked = this.GetSelectedMission().CheckBox_OrderRTB;
				this.GetCheckBox_DeleteMission().Checked = this.GetSelectedMission().CheckBox_DeleteMission;
				DataTable dataTable = new DataTable();
				DataTable dataTable2 = new DataTable();
				DataTable dataTable3 = new DataTable();
				DataTable dataTable4 = new DataTable();
				new DataTable();
				DataTable dataTable5 = new DataTable();
				DataTable dataTable6 = new DataTable();
				DataTable dataTable7 = new DataTable();
				DataTable dataTable8 = new DataTable();
				DataTable dataTable9 = new DataTable();
				DataTable dataTable10 = new DataTable();
				DataTable dataTable11 = new DataTable();
				DataTable dataTable12 = new DataTable();
				new DataTable();
				new DataTable();
				Mission.MissionCategory category = this.GetSelectedMission().category;
				if (category <= Mission.MissionCategory.Package)
				{
					switch (this.GetSelectedMission().MissionClass)
					{
					case Mission._MissionClass.Strike:
					{
						this.GetTC_MissionOptions().TabPages[0].Enabled = true;
						this.GetTC_MissionOptions().TabPages[1].Enabled = true;
						Strike strike = (Strike)this.GetSelectedMission();
						this.GetCB_Strike_UseOffAxisAttack().Checked = strike.UseAutoPlanner;
						this.GetCB_PreplannedOnly().Checked = strike.PrePlannedOnly;
						this.GetCB_OneTimeOnly().Checked = strike.OneTimeOnly;
						switch (strike.MinimumContactStanceToTrigger)
						{
						case Misc.PostureStance.Unfriendly:
							this.GetCombo_Strike_MinimumContactStanceToTrigger().SelectedIndex = 1;
							break;
						case Misc.PostureStance.Hostile:
							this.GetCombo_Strike_MinimumContactStanceToTrigger().SelectedIndex = 2;
							break;
						case Misc.PostureStance.Unknown:
							this.GetCombo_Strike_MinimumContactStanceToTrigger().SelectedIndex = 0;
							break;
						default:
							this.GetCombo_Strike_MinimumContactStanceToTrigger().SelectedIndex = -1;
							break;
						}
						System.Windows.Forms.ComboBox comboBox_ = this.GetComboBox_FlightSize_Strike();
						this.method_61(ref comboBox_, ref dataTable, strike.m_FlightSize);
						this.vmethod_209(comboBox_);
						comboBox_ = this.GetComboBox_GroupSize_Strike();
						this.method_62(ref comboBox_, ref dataTable2, strike.m_GroupSize);
						this.vmethod_839(comboBox_);
						comboBox_ = this.vmethod_286();
						this.method_61(ref comboBox_, ref dataTable3, strike.Escort_FlightSize_Shooter);
						this.vmethod_287(comboBox_);
						comboBox_ = this.vmethod_450();
						this.method_63(ref comboBox_, ref dataTable4, strike.Escort_FlightSize_NonShooter);
						this.vmethod_451(comboBox_);
						comboBox_ = this.GetComboBox_MinNumberOfStrikeAircraft();
						this.method_64(ref comboBox_, ref dataTable5, (int)strike.MinAircraftReq_Strikers, false, false);
						this.vmethod_381(comboBox_);
						comboBox_ = this.vmethod_412();
						this.method_64(ref comboBox_, ref dataTable6, (int)strike.MinAircraftReq_Escorts_Shooter, true, false);
						this.vmethod_413(comboBox_);
						comboBox_ = this.GetComboBox_MaxNumberOfStrikeAircraft();
						this.method_66(ref comboBox_, ref dataTable8, (int)strike.MaxAircraftToFly_Strikers, false, false);
						this.vmethod_405(comboBox_);
						comboBox_ = this.vmethod_408();
						this.method_66(ref comboBox_, ref dataTable9, (int)strike.MaxAircraftToFly_Escort_Shooter, true, false);
						this.vmethod_409(comboBox_);
						comboBox_ = this.vmethod_452();
						this.method_64(ref comboBox_, ref dataTable7, (int)strike.MinAircraftReq_Escorts_NonShooter, true, true);
						this.vmethod_453(comboBox_);
						comboBox_ = this.vmethod_444();
						this.method_66(ref comboBox_, ref dataTable10, (int)strike.MaxAircraftToFly_Escort_NonShooter, true, true);
						this.vmethod_445(comboBox_);
						if (strike.Escort_FlightSize_NonShooter == Mission._FlightSize.None)
						{
							this.vmethod_452().Enabled = false;
							this.vmethod_444().Enabled = false;
						}
						else
						{
							this.vmethod_452().Enabled = true;
							this.vmethod_444().Enabled = true;
						}
						comboBox_ = this.GetComboBox_MissionFuel();
						this.method_67(ref comboBox_, ref dataTable11, strike.Bingo);
						this.vmethod_417(comboBox_);
						if (Information.IsNothing(strike.Escort_TransitThrottle))
						{
							this.vmethod_358().SelectedIndex = 4;
						}
						else
						{
							this.vmethod_358().SelectedIndex = (int)(strike.Escort_TransitThrottle.Value - ActiveUnit.Throttle.Loiter);
						}
						if (Information.IsNothing(strike.Escort_StationThrottle))
						{
							this.vmethod_354().SelectedIndex = 4;
						}
						else
						{
							this.vmethod_354().SelectedIndex = (int)(strike.Escort_StationThrottle.Value - ActiveUnit.Throttle.Loiter);
						}
						this.GetCB_UseFlightSizeHardLimit_Strike().Checked = strike.UseFlightSizeHardLimit;
						this.GetCB_UseGroupSizeHardLimit_Strike().Checked = strike.UseGroupSizeHardLimit;
						this.vmethod_458().Checked = strike.UseFlightSizeHardLimit_Escort;
						this.vmethod_620().Checked = strike.Escort_TransitTerrainFollowing;
						this.vmethod_620().Enabled = strike.Escort_TransitAltitude.HasValue;
						this.vmethod_618().Checked = strike.Escort_AttackTerrainFollowing;
						this.vmethod_618().Enabled = strike.Escort_StationAltitude.HasValue;
						comboBox_ = this.GetCB_RadarUsage();
						this.method_154(ref comboBox_, ref dataTable12, (int)strike.RadarBehaviour);
						this.vmethod_433(comboBox_);
						Doctrine doctrine = this.GetSelectedMission().m_Doctrine;
						comboBox_ = this.GetCB_TankerUsage();
						Scenario clientScenario = Client.GetClientScenario();
						doctrine.method_289(ref comboBox_, ref clientScenario, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
						this.vmethod_421(comboBox_);
						if (strike.Escort_TransitAltitude.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_368().Text = "英尺";
								System.Windows.Forms.Control arg_B5C_0 = this.vmethod_366();
								float? num = strike.Escort_TransitAltitude;
								arg_B5C_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_368().Text = "米";
								this.vmethod_366().Text = Conversions.ToString(strike.Escort_TransitAltitude.Value);
							}
						}
						else
						{
							this.vmethod_366().Text = "未定";
							this.vmethod_368().Text = "";
						}
						if (strike.Escort_StationAltitude.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_364().Text = "英尺";
								System.Windows.Forms.Control arg_C30_0 = this.vmethod_370();
								float? num = strike.Escort_StationAltitude;
								arg_C30_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_364().Text = "米";
								this.vmethod_370().Text = Conversions.ToString(strike.Escort_StationAltitude.Value);
							}
						}
						else
						{
							this.vmethod_370().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_364().Text = "英尺";
							}
							else
							{
								this.vmethod_364().Text = "米";
							}
						}
						if (strike.Escort_TransitAltitude.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_368().Text = "英尺";
								System.Windows.Forms.Control arg_D25_0 = this.vmethod_366();
								float? num = strike.Escort_TransitAltitude;
								arg_D25_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_368().Text = "米";
								this.vmethod_366().Text = Conversions.ToString(strike.Escort_TransitAltitude.Value);
							}
						}
						else
						{
							this.vmethod_366().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_368().Text = "英尺";
							}
							else
							{
								this.vmethod_368().Text = "米";
							}
						}
						if (strike.Escort_StationAltitude.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_364().Text = "英尺";
								System.Windows.Forms.Control arg_E1A_0 = this.vmethod_370();
								float? num = strike.Escort_StationAltitude;
								arg_E1A_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_364().Text = "米";
								this.vmethod_370().Text = Conversions.ToString(strike.Escort_StationAltitude.Value);
							}
						}
						else
						{
							this.vmethod_370().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_364().Text = "英尺";
							}
							else
							{
								this.vmethod_364().Text = "米";
							}
						}
						this.vmethod_374().Text = Conversions.ToString(strike.Escort_ResponseRadius);
						this.GetTB_MinResponseRadius().Text = Conversions.ToString(strike.MinResponseRadius);
						this.GetTB_MaxResponseRadius().Text = Conversions.ToString(strike.MaxResponseRadius);
						this.GetTC_MissionOptions().SelectedIndex = 0;
						return;
					}
					case Mission._MissionClass.Patrol:
					{
						this.GetTC_MissionOptions().TabPages[2].Enabled = true;
						Patrol patrol = (Patrol)this.GetSelectedMission();
						this.GetCB_Patrol_13rule().Checked = patrol.OTR;
						this.GetCB_InvestigateOutsidePatrolArea().Checked = patrol.method_43(Client.GetClientScenario());
						this.vmethod_870().Checked = patrol.method_45(Client.GetClientScenario());
						this.vmethod_56().Checked = patrol.AEOIPA;
						this.vmethod_150().Checked = patrol.SAD;
						this.GetAreaEditor_PatrolArea().method_0("编辑巡逻区");
						this.GetAreaEditor_PatrolArea().list_0 = patrol.PatrolAreaVertices;
						this.GetAreaEditor_PatrolArea().method_1();
						this.GetAreaEditor_ProsecutionArea().method_0("编辑警戒区");
						this.GetAreaEditor_ProsecutionArea().list_0 = patrol.ProsecutionAreaVertices;
						this.GetAreaEditor_ProsecutionArea().method_1();
						if (patrol.MNOS > 0)
						{
							this.GetTB_Patrol_XUnitsOnStation().Text = Conversions.ToString(patrol.MNOS);
						}
						else
						{
							this.GetTB_Patrol_XUnitsOnStation().Text = Conversions.ToString(0);
						}
						if (Information.IsNothing(patrol.TransitThrottle_Aircraft))
						{
							this.GetCombo_PatrolTransitThrottle_Aircraft().SelectedIndex = 4;
						}
						else
						{
							this.GetCombo_PatrolTransitThrottle_Aircraft().SelectedIndex = (int)(patrol.TransitThrottle_Aircraft.Value - ActiveUnit.Throttle.Loiter);
						}
						if (Information.IsNothing(patrol.StationThrottle_Aircraft))
						{
							this.GetCombo_PatrolStationThrottle_Aircraft().SelectedIndex = 4;
						}
						else
						{
							this.GetCombo_PatrolStationThrottle_Aircraft().SelectedIndex = (int)(patrol.StationThrottle_Aircraft.Value - ActiveUnit.Throttle.Loiter);
						}
						if (Information.IsNothing(patrol.AttackThrottle_Aircraft))
						{
							this.GetCombo_PatrolAttackThrottle_Aircraft().SelectedIndex = 4;
						}
						else
						{
							this.GetCombo_PatrolAttackThrottle_Aircraft().SelectedIndex = (int)(patrol.AttackThrottle_Aircraft.Value - ActiveUnit.Throttle.Loiter);
						}
						this.GetCombo_PatrolTransitThrottle_Submarine().SelectedIndex = (int)(patrol.TransitThrottle_Submarine - ActiveUnit.Throttle.Loiter);
						this.GetCombo_PatrolStationThrottle_Submarine().SelectedIndex = (int)(patrol.StationThrottle_Submarine - ActiveUnit.Throttle.Loiter);
						if (Information.IsNothing(patrol.AttackThrottle_Submarine))
						{
							this.GetCombo_PatrolAttackThrottle_Submarine().SelectedIndex = 4;
						}
						else
						{
							this.GetCombo_PatrolAttackThrottle_Submarine().SelectedIndex = (int)(patrol.AttackThrottle_Submarine.Value - ActiveUnit.Throttle.Loiter);
						}
						this.GetCombo_PatrolTransitThrottle_Ship().SelectedIndex = (int)(patrol.TransitThrottle_Ship - ActiveUnit.Throttle.Loiter);
						this.GetCombo_PatrolStationThrottle_Ship().SelectedIndex = (int)(patrol.StationThrottle_Ship - ActiveUnit.Throttle.Loiter);
						if (Information.IsNothing(patrol.AttackThrottle_Ship))
						{
							this.GetCombo_PatrolAttackThrottle_Ship().SelectedIndex = 4;
						}
						else
						{
							this.GetCombo_PatrolAttackThrottle_Ship().SelectedIndex = (int)(patrol.AttackThrottle_Ship.Value - ActiveUnit.Throttle.Loiter);
						}
						if (patrol.AttackDistance_Ship.HasValue)
						{
							this.GetTB_PatrolAttackDistance_Ship().Text = Conversions.ToString((int)Math.Round((double)patrol.AttackDistance_Ship.Value));
						}
						else
						{
							this.GetTB_PatrolAttackDistance_Ship().Text = "未定";
						}
						this.GetCheckBox_PatrolTransitTerrainFollowing_Aircraft().Checked = patrol.TransitTerrainFollowing_Aircraft;
						this.GetCheckBox_PatrolTransitTerrainFollowing_Aircraft().Enabled = patrol.TransitAltitude_Aircraft.HasValue;
						this.GetCheckBox_PatrolStationTerrainFollowing_Aircraft().Checked = patrol.StationTerrainFollowing_Aircraft;
						this.GetCheckBox_PatrolStationTerrainFollowing_Aircraft().Enabled = patrol.StationAltitude_Aircraft.HasValue;
						this.GetCheckBox_PatrolAttackTerrainFollowing_Aircraft().Checked = patrol.AttackTerrainFollowing_Aircraft;
						this.GetCheckBox_PatrolAttackTerrainFollowing_Aircraft().Enabled = patrol.AttackAltitude_Aircraft.HasValue;
						this.vmethod_460().Checked = patrol.UseFlightSizeHardLimit;
						this.vmethod_840().Checked = patrol.UseGroupSizeHardLimit;
						if (patrol.TransitAltitude_Aircraft.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.GetLabel_PatrolTransitAltitude_Aircraft().Text = "英尺";
								System.Windows.Forms.Control arg_12EF_0 = this.GetTB_PatrolTransitAltitude_Aircraft();
								float? num = patrol.TransitAltitude_Aircraft;
								arg_12EF_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.GetLabel_PatrolTransitAltitude_Aircraft().Text = "米";
								this.GetTB_PatrolTransitAltitude_Aircraft().Text = Conversions.ToString(patrol.TransitAltitude_Aircraft.Value);
							}
						}
						else
						{
							this.GetTB_PatrolTransitAltitude_Aircraft().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.GetLabel_PatrolTransitAltitude_Aircraft().Text = "英尺";
							}
							else
							{
								this.GetLabel_PatrolTransitAltitude_Aircraft().Text = "米";
							}
						}
						if (patrol.StationAltitude_Aircraft.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.GetLabel_PatrolStationAltitude_Aircraft().Text = "英尺";
								System.Windows.Forms.Control arg_13E4_0 = this.GetTB_PatrolStationAltitude_Aircraft();
								float? num = patrol.StationAltitude_Aircraft;
								arg_13E4_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.GetLabel_PatrolStationAltitude_Aircraft().Text = "米";
								this.GetTB_PatrolStationAltitude_Aircraft().Text = Conversions.ToString(patrol.StationAltitude_Aircraft.Value);
							}
						}
						else
						{
							this.GetTB_PatrolStationAltitude_Aircraft().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.GetLabel_PatrolStationAltitude_Aircraft().Text = "英尺";
							}
							else
							{
								this.GetLabel_PatrolStationAltitude_Aircraft().Text = "米";
							}
						}
						if (patrol.AttackAltitude_Aircraft.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.GetLabel_PatrolAttackAltitude_Aircraft().Text = "英尺";
								System.Windows.Forms.Control arg_14D9_0 = this.GetTB_PatrolAttackAltitude_Aircraft();
								float? num = patrol.AttackAltitude_Aircraft;
								arg_14D9_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.GetLabel_PatrolAttackAltitude_Aircraft().Text = "米";
								this.GetTB_PatrolAttackAltitude_Aircraft().Text = Conversions.ToString(patrol.AttackAltitude_Aircraft.Value);
							}
						}
						else
						{
							this.GetTB_PatrolAttackAltitude_Aircraft().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.GetLabel_PatrolAttackAltitude_Aircraft().Text = "英尺";
							}
							else
							{
								this.GetLabel_PatrolAttackAltitude_Aircraft().Text = "米";
							}
						}
						if (patrol.AttackDistance_Aircraft.HasValue)
						{
							this.GetTB_PatrolAttackDistance_Aircraft().Text = Conversions.ToString((int)Math.Round((double)patrol.AttackDistance_Aircraft.Value));
						}
						else
						{
							this.GetTB_PatrolAttackDistance_Aircraft().Text = "未定";
						}
						if (patrol.TransitDepth_Submarine.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_546().Text = "英尺";
								System.Windows.Forms.Control arg_1614_0 = this.vmethod_524();
								float? num = patrol.TransitDepth_Submarine;
								arg_1614_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_546().Text = "米";
								this.vmethod_524().Text = Conversions.ToString(patrol.TransitDepth_Submarine.Value);
							}
						}
						else
						{
							this.vmethod_524().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_546().Text = "英尺";
							}
							else
							{
								this.vmethod_546().Text = "米";
							}
						}
						if (patrol.StationDepth_Submarine.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_544().Text = "英尺";
								System.Windows.Forms.Control arg_1709_0 = this.vmethod_522();
								float? num = patrol.StationDepth_Submarine;
								arg_1709_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_544().Text = "米";
								this.vmethod_522().Text = Conversions.ToString(patrol.StationDepth_Submarine.Value);
							}
						}
						else
						{
							this.vmethod_522().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_544().Text = "英尺";
							}
							else
							{
								this.vmethod_544().Text = "米";
							}
						}
						if (patrol.AttackDepth_Submarine.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_528().Text = "英尺";
								System.Windows.Forms.Control arg_17FE_0 = this.vmethod_520();
								float? num = patrol.AttackDepth_Submarine;
								arg_17FE_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_528().Text = "米";
								this.vmethod_520().Text = Conversions.ToString(patrol.AttackDepth_Submarine.Value);
							}
						}
						else
						{
							this.vmethod_520().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_528().Text = "英尺";
							}
							else
							{
								this.vmethod_528().Text = "米";
							}
						}
						if (patrol.AttackDistance_Submarine.HasValue)
						{
							this.vmethod_804().Text = Conversions.ToString((int)Math.Round((double)patrol.AttackDistance_Submarine.Value));
						}
						else
						{
							this.vmethod_804().Text = "未定";
						}
						System.Windows.Forms.ComboBox comboBox_ = this.vmethod_232();
						this.method_61(ref comboBox_, ref dataTable, patrol.m_FlightSize);
						this.vmethod_233(comboBox_);
						comboBox_ = this.vmethod_844();
						this.method_62(ref comboBox_, ref dataTable2, patrol.m_GroupSize);
						this.vmethod_845(comboBox_);
						comboBox_ = this.vmethod_384();
						this.method_64(ref comboBox_, ref dataTable5, (int)patrol.MinAircraftReq, false, false);
						this.vmethod_385(comboBox_);
						Doctrine doctrine2 = this.GetSelectedMission().m_Doctrine;
						comboBox_ = this.vmethod_730();
						Scenario clientScenario = Client.GetClientScenario();
						doctrine2.method_289(ref comboBox_, ref clientScenario, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
						this.vmethod_731(comboBox_);
						this.GetTC_MissionOptions().SelectedIndex = 2;
						return;
					}
					case Mission._MissionClass.Support:
					{
						this.GetTC_MissionOptions().TabPages[3].Enabled = true;
						SupportMission supportMission = (SupportMission)this.GetSelectedMission();
						this.vmethod_32().Checked = supportMission.OTR;
						this.vmethod_72().Checked = supportMission.OTO;
						this.vmethod_62().method_0("编辑支援航线");
						this.vmethod_62().list_0 = supportMission.NavigationCourseReferencePoints;
						this.vmethod_62().method_1();
						this.vmethod_36().SelectedIndex = (int)supportMission.NLT;
						if (Information.IsNothing(supportMission.TransitThrottle_Aircraft))
						{
							this.GetCombo_SupportTransitThrottle_Aircraft().SelectedIndex = 4;
						}
						else
						{
							this.GetCombo_SupportTransitThrottle_Aircraft().SelectedIndex = (int)(supportMission.TransitThrottle_Aircraft.Value - ActiveUnit.Throttle.Loiter);
						}
						if (Information.IsNothing(supportMission.StationThrottle_Aircraft))
						{
							this.GetCombo_SupportStationThrottle_Aircraft().SelectedIndex = 4;
						}
						else
						{
							this.GetCombo_SupportStationThrottle_Aircraft().SelectedIndex = (int)(supportMission.StationThrottle_Aircraft.Value - ActiveUnit.Throttle.Loiter);
						}
						this.GetCombo_SupportTransitThrottle_Submarine().SelectedIndex = (int)(supportMission.TransitThrottle_Submarine - ActiveUnit.Throttle.Loiter);
						this.GetCombo_SupportStationThrottle_Submarine().SelectedIndex = (int)(supportMission.StationThrottle_Submarine - ActiveUnit.Throttle.Loiter);
						this.GetCombo_SupportTransitThrottle_Ship().SelectedIndex = (int)(supportMission.TransitThrottle_Ship - ActiveUnit.Throttle.Loiter);
						this.GetCombo_SupportStationThrottle_Ship().SelectedIndex = (int)(supportMission.StationThrottle_Ship - ActiveUnit.Throttle.Loiter);
						this.vmethod_504().Checked = supportMission.TransitTerrainFollowing_Aircraft;
						this.vmethod_504().Enabled = supportMission.TransitAltitude_Aircraft.HasValue;
						this.vmethod_502().Checked = supportMission.StationTerrainFollowing_Aircraft;
						this.vmethod_502().Enabled = supportMission.StationAltitude_Aircraft.HasValue;
						this.GetCB_UseFlightSizeHardLimit_Support().Checked = supportMission.UseFlightSizeHardLimit;
						this.GetCB_UseGroupSizeHardLimit_Support().Checked = supportMission.UseGroupSizeHardLimit;
						this.GetCB_OneA2AR().Checked = supportMission.A2AR_OneTankingCycleOnly;
						this.GetTB_NumberOfReceiversA2AR().Text = Conversions.ToString(supportMission.A2AR_MaxNumberOfReceiversPerTanker);
						if (supportMission.MNOS > 0)
						{
							this.vmethod_180().Text = Conversions.ToString(supportMission.MNOS);
						}
						else
						{
							this.vmethod_180().Text = Conversions.ToString(0);
						}
						if (supportMission.TransitAltitude_Aircraft.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_172().Text = "英尺";
								System.Windows.Forms.Control arg_1C13_0 = this.vmethod_156();
								float? num = supportMission.TransitAltitude_Aircraft;
								arg_1C13_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_172().Text = "米";
								this.vmethod_156().Text = Conversions.ToString(supportMission.TransitAltitude_Aircraft.Value);
							}
						}
						else
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_172().Text = "英尺";
							}
							else
							{
								this.vmethod_172().Text = "米";
							}
							this.vmethod_156().Text = "未定";
						}
						if (supportMission.StationAltitude_Aircraft.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_170().Text = "英尺";
								System.Windows.Forms.Control arg_1D08_0 = this.vmethod_154();
								float? num = supportMission.StationAltitude_Aircraft;
								arg_1D08_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_170().Text = "米";
								this.vmethod_154().Text = Conversions.ToString(supportMission.StationAltitude_Aircraft.Value);
							}
						}
						else
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_170().Text = "英尺";
							}
							else
							{
								this.vmethod_170().Text = "米";
							}
							this.vmethod_154().Text = "未定";
						}
						if (supportMission.TransitDepth_Submarine.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_596().Text = "英尺";
								System.Windows.Forms.Control arg_1DFD_0 = this.GetTB_SupportTransitDepth_Submarine();
								float? num = supportMission.TransitDepth_Submarine;
								arg_1DFD_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_596().Text = "米";
								this.GetTB_SupportTransitDepth_Submarine().Text = Conversions.ToString(supportMission.TransitDepth_Submarine.Value);
							}
						}
						else
						{
							this.GetTB_SupportTransitDepth_Submarine().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_596().Text = "英尺";
							}
							else
							{
								this.vmethod_596().Text = "米";
							}
						}
						if (supportMission.StationDepth_Submarine.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_592().Text = "英尺";
								System.Windows.Forms.Control arg_1EF2_0 = this.vmethod_582();
								float? num = supportMission.StationDepth_Submarine;
								arg_1EF2_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_592().Text = "米";
								this.vmethod_582().Text = Conversions.ToString(supportMission.StationDepth_Submarine.Value);
							}
						}
						else
						{
							this.vmethod_582().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_592().Text = "英尺";
							}
							else
							{
								this.vmethod_592().Text = "米";
							}
						}
						this.vmethod_160().Checked = supportMission.AEOOS;
						System.Windows.Forms.ComboBox comboBox_ = this.GetComboBox_FlightSize_Support();
						this.method_61(ref comboBox_, ref dataTable, supportMission.m_FlightSize);
						this.vmethod_241(comboBox_);
						comboBox_ = this.GetComboBox_GroupSize_Support();
						this.method_62(ref comboBox_, ref dataTable2, supportMission.m_GroupSize);
						this.vmethod_849(comboBox_);
						comboBox_ = this.GetComboBox_SupportAircraftRequired();
						this.method_64(ref comboBox_, ref dataTable5, (int)supportMission.MinAircraftReq, false, false);
						this.vmethod_389(comboBox_);
						Doctrine doctrine3 = this.GetSelectedMission().m_Doctrine;
						comboBox_ = this.GetCB_TankerUsage_Support();
						Scenario clientScenario = Client.GetClientScenario();
						doctrine3.method_289(ref comboBox_, ref clientScenario, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
						this.vmethod_737(comboBox_);
						this.GetTC_MissionOptions().SelectedIndex = 3;
						return;
					}
					case Mission._MissionClass.Ferry:
					{
						this.GetTC_MissionOptions().TabPages[4].Enabled = true;
						FerryMission ferryMission = (FerryMission)this.GetSelectedMission();
						this.GetCombo_FerryBehavior().SelectedIndex = (int)ferryMission.GetFerryMissionBehavior();
						System.Windows.Forms.ComboBox comboBox_ = this.vmethod_248();
						this.method_61(ref comboBox_, ref dataTable, ferryMission.m_FlightSize);
						this.vmethod_249(comboBox_);
						this.vmethod_464().Checked = ferryMission.UseFlightSizeHardLimit;
						this.vmethod_506().Checked = ferryMission.FerryTerrainFollowing_Aircraft;
						this.vmethod_506().Enabled = ferryMission.FerryAltitude_Aircraft.HasValue;
						if (Information.IsNothing(ferryMission.FerryThrottle_Aircraft))
						{
							this.GetCombo_FerryThrottle_Aircraft().SelectedIndex = 4;
						}
						else
						{
							this.GetCombo_FerryThrottle_Aircraft().SelectedIndex = (int)(ferryMission.FerryThrottle_Aircraft.Value - ActiveUnit.Throttle.Loiter);
						}
						if (ferryMission.FerryAltitude_Aircraft.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_304().Text = "英尺";
								System.Windows.Forms.Control arg_2174_0 = this.vmethod_302();
								float? num = ferryMission.FerryAltitude_Aircraft;
								arg_2174_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_304().Text = "米";
								this.vmethod_302().Text = Conversions.ToString(ferryMission.FerryAltitude_Aircraft.Value);
							}
						}
						else
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_304().Text = "英尺";
							}
							else
							{
								this.vmethod_304().Text = "米";
							}
							this.vmethod_302().Text = "未定";
						}
						comboBox_ = this.vmethod_392();
						this.method_64(ref comboBox_, ref dataTable5, (int)ferryMission.MinAircraftReq, false, false);
						this.vmethod_393(comboBox_);
						Doctrine doctrine4 = this.GetSelectedMission().m_Doctrine;
						comboBox_ = this.vmethod_742();
						Scenario clientScenario = Client.GetClientScenario();
						doctrine4.method_289(ref comboBox_, ref clientScenario, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
						this.vmethod_743(comboBox_);
						this.GetTC_MissionOptions().SelectedIndex = 4;
						return;
					}
					case Mission._MissionClass.Mining:
					{
						this.GetTC_MissionOptions().TabPages[5].Enabled = true;
						MiningMission miningMission = (MiningMission)this.GetSelectedMission();
						System.Windows.Forms.ComboBox comboBox_ = this.vmethod_260();
						this.method_61(ref comboBox_, ref dataTable, miningMission.m_FlightSize);
						this.vmethod_261(comboBox_);
						comboBox_ = this.vmethod_854();
						this.method_62(ref comboBox_, ref dataTable2, miningMission.m_GroupSize);
						this.vmethod_855(comboBox_);
						this.vmethod_466().Checked = miningMission.UseFlightSizeHardLimit;
						this.vmethod_850().Checked = miningMission.UseGroupSizeHardLimit;
						comboBox_ = this.vmethod_396();
						this.method_64(ref comboBox_, ref dataTable5, (int)miningMission.MinAircraftReq, false, false);
						this.vmethod_397(comboBox_);
						if (Information.IsNothing(miningMission.TransitThrottle_Aircraft))
						{
							this.GetCombo_MiningTransitThrottle_Aircraft().SelectedIndex = 4;
						}
						else
						{
							this.GetCombo_MiningTransitThrottle_Aircraft().SelectedIndex = (int)(miningMission.TransitThrottle_Aircraft.Value - ActiveUnit.Throttle.Loiter);
						}
						if (Information.IsNothing(miningMission.StationThrottle_Aircraft))
						{
							this.GetCombo_MiningStationThrottle_Aircraft().SelectedIndex = 4;
						}
						else
						{
							this.GetCombo_MiningStationThrottle_Aircraft().SelectedIndex = (int)(miningMission.StationThrottle_Aircraft.Value - ActiveUnit.Throttle.Loiter);
						}
						this.GetCombo_MiningTransitThrottle_Submarine().SelectedIndex = (int)(miningMission.TransitThrottle_Submarine - ActiveUnit.Throttle.Loiter);
						this.GetCombo_MiningStationThrottle_Submarine().SelectedIndex = (int)(miningMission.StationThrottle_Submarine - ActiveUnit.Throttle.Loiter);
						this.GetCombo_MiningTransitThrottle_Ship().SelectedIndex = (int)(miningMission.TransitThrottle_Ship - ActiveUnit.Throttle.Loiter);
						this.GetCombo_MiningStationThrottle_Ship().SelectedIndex = (int)(miningMission.StationThrottle_Ship - ActiveUnit.Throttle.Loiter);
						Doctrine doctrine5 = this.GetSelectedMission().m_Doctrine;
						comboBox_ = this.vmethod_748();
						Scenario clientScenario = Client.GetClientScenario();
						doctrine5.method_289(ref comboBox_, ref clientScenario, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
						this.vmethod_749(comboBox_);
						this.vmethod_510().Checked = miningMission.TransitTerrainFollowing_Aircraft;
						this.vmethod_510().Enabled = miningMission.TransitAltitude_Aircraft.HasValue;
						this.vmethod_508().Checked = miningMission.StationTerrainFollowing_Aircraft;
						this.vmethod_508().Enabled = miningMission.StationAltitude_Aircraft.HasValue;
						if (miningMission.TransitAltitude_Aircraft.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_324().Text = "英尺";
								System.Windows.Forms.Control arg_24D6_0 = this.vmethod_322();
								float? num = miningMission.TransitAltitude_Aircraft;
								arg_24D6_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_324().Text = "米";
								this.vmethod_322().Text = Conversions.ToString(miningMission.TransitAltitude_Aircraft.Value);
							}
						}
						else
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_324().Text = "英尺";
							}
							else
							{
								this.vmethod_324().Text = "米";
							}
							this.vmethod_322().Text = "未定";
						}
						if (miningMission.StationAltitude_Aircraft.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_320().Text = "英尺";
								System.Windows.Forms.Control arg_25CB_0 = this.vmethod_326();
								float? num = miningMission.StationAltitude_Aircraft;
								arg_25CB_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_320().Text = "米";
								this.vmethod_326().Text = Conversions.ToString(miningMission.StationAltitude_Aircraft.Value);
							}
						}
						else
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_320().Text = "英尺";
							}
							else
							{
								this.vmethod_320().Text = "米";
							}
							this.vmethod_326().Text = "未定";
						}
						if (miningMission.TransitDepth_Submarine.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_662().Text = "英尺";
								System.Windows.Forms.Control arg_26C0_0 = this.vmethod_646();
								float? num = miningMission.TransitDepth_Submarine;
								arg_26C0_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_662().Text = "米";
								this.vmethod_646().Text = Conversions.ToString(miningMission.TransitDepth_Submarine.Value);
							}
						}
						else
						{
							this.vmethod_646().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_662().Text = "英尺";
							}
							else
							{
								this.vmethod_662().Text = "米";
							}
						}
						if (miningMission.StationDepth_Submarine.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_660().Text = "英尺";
								System.Windows.Forms.Control arg_27B5_0 = this.vmethod_644();
								float? num = miningMission.StationDepth_Submarine;
								arg_27B5_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_660().Text = "米";
								this.vmethod_644().Text = Conversions.ToString(miningMission.StationDepth_Submarine.Value);
							}
						}
						else
						{
							this.vmethod_644().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_660().Text = "英尺";
							}
							else
							{
								this.vmethod_660().Text = "米";
							}
						}
						this.GetTC_MissionOptions().SelectedIndex = 5;
						this.vmethod_76().method_0("编辑布雷区");
						this.vmethod_76().list_0 = miningMission.AreaVertices;
						this.vmethod_76().method_1();
						TimeSpan timeSpan = TimeSpan.FromSeconds((double)miningMission.AD);
						this.vmethod_92().Text = Conversions.ToString(timeSpan.Days);
						this.vmethod_88().Text = Conversions.ToString(timeSpan.Hours);
						this.vmethod_86().Text = Conversions.ToString(timeSpan.Minutes);
						this.vmethod_84().Text = Conversions.ToString(timeSpan.Seconds);
						this.vmethod_96().Checked = miningMission.bOTR;
						this.vmethod_92().TextChanged += new EventHandler(this.method_26);
						this.vmethod_88().TextChanged += new EventHandler(this.method_27);
						this.vmethod_86().TextChanged += new EventHandler(this.method_28);
						this.vmethod_84().TextChanged += new EventHandler(this.method_29);
						return;
					}
					case Mission._MissionClass.MineClearing:
					{
						this.GetTC_MissionOptions().TabPages[6].Enabled = true;
						MineClearingMission mineClearingMission = (MineClearingMission)this.GetSelectedMission();
						System.Windows.Forms.ComboBox comboBox_ = this.vmethod_272();
						this.method_61(ref comboBox_, ref dataTable, mineClearingMission.m_FlightSize);
						this.vmethod_273(comboBox_);
						comboBox_ = this.vmethod_860();
						this.method_62(ref comboBox_, ref dataTable2, mineClearingMission.m_GroupSize);
						this.vmethod_861(comboBox_);
						comboBox_ = this.vmethod_400();
						this.method_64(ref comboBox_, ref dataTable5, (int)mineClearingMission.MinAircraftReq, false, false);
						this.vmethod_401(comboBox_);
						if (Information.IsNothing(mineClearingMission.TransitThrottle_Aircraft))
						{
							this.GetCombo_MineClearingTransitThrottle_Aircraft().SelectedIndex = 4;
						}
						else
						{
							this.GetCombo_MineClearingTransitThrottle_Aircraft().SelectedIndex = (int)(mineClearingMission.TransitThrottle_Aircraft.Value - ActiveUnit.Throttle.Loiter);
						}
						if (Information.IsNothing(mineClearingMission.StationThrottle_Aircraft))
						{
							this.GetCombo_MineClearingStationThrottle_Aircraft().SelectedIndex = 4;
						}
						else
						{
							this.GetCombo_MineClearingStationThrottle_Aircraft().SelectedIndex = (int)(mineClearingMission.StationThrottle_Aircraft.Value - ActiveUnit.Throttle.Loiter);
						}
						this.GetCombo_MineClearingTransitThrottle_Submarine().SelectedIndex = (int)(mineClearingMission.TransitThrottle_Submarine - ActiveUnit.Throttle.Loiter);
						this.GetCombo_MineClearingStationThrottle_Submarine().SelectedIndex = (int)(mineClearingMission.StationThrottle_Submarine - ActiveUnit.Throttle.Loiter);
						this.GetCombo_MineClearingTransitThrottle_Ship().SelectedIndex = (int)(mineClearingMission.TransitThrottle_Ship - ActiveUnit.Throttle.Loiter);
						this.GetCombo_MineClearingStationThrottle_Ship().SelectedIndex = (int)(mineClearingMission.StationThrottle_Ship - ActiveUnit.Throttle.Loiter);
						Doctrine doctrine6 = this.GetSelectedMission().m_Doctrine;
						comboBox_ = this.vmethod_754();
						Scenario clientScenario = Client.GetClientScenario();
						doctrine6.method_289(ref comboBox_, ref clientScenario, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
						this.vmethod_755(comboBox_);
						this.vmethod_514().Checked = mineClearingMission.TransitTerrainFollowing_Aircraft;
						this.vmethod_514().Enabled = mineClearingMission.TransitAltitude_Aircraft.HasValue;
						this.vmethod_512().Checked = mineClearingMission.StationTerrainFollowing_Aircraft;
						this.vmethod_512().Enabled = mineClearingMission.StationAltitude_Aircraft.HasValue;
						this.vmethod_468().Checked = mineClearingMission.UseFlightSizeHardLimit;
						this.vmethod_856().Checked = mineClearingMission.UseGroupSizeHardLimit;
						if (mineClearingMission.TransitAltitude_Aircraft.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_346().Text = "英尺";
								System.Windows.Forms.Control arg_2BC5_0 = this.vmethod_344();
								float? num = mineClearingMission.TransitAltitude_Aircraft;
								arg_2BC5_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_346().Text = "米";
								this.vmethod_344().Text = Conversions.ToString(mineClearingMission.TransitAltitude_Aircraft.Value);
							}
						}
						else
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_346().Text = "英尺";
							}
							else
							{
								this.vmethod_346().Text = "米";
							}
							this.vmethod_344().Text = "未定";
						}
						if (mineClearingMission.StationAltitude_Aircraft.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_342().Text = "英尺";
								System.Windows.Forms.Control arg_2CBA_0 = this.vmethod_348();
								float? num = mineClearingMission.StationAltitude_Aircraft;
								arg_2CBA_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_342().Text = "米";
								this.vmethod_348().Text = Conversions.ToString(mineClearingMission.StationAltitude_Aircraft.Value);
							}
						}
						else
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_342().Text = "英尺";
							}
							else
							{
								this.vmethod_342().Text = "米";
							}
							this.vmethod_348().Text = "未定";
						}
						if (mineClearingMission.TransitDepth_Submarine.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_704().Text = "英尺";
								System.Windows.Forms.Control arg_2DAF_0 = this.vmethod_688();
								float? num = mineClearingMission.TransitDepth_Submarine;
								arg_2DAF_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_704().Text = "米";
								this.vmethod_688().Text = Conversions.ToString(mineClearingMission.TransitDepth_Submarine.Value);
							}
						}
						else
						{
							this.vmethod_688().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_704().Text = "英尺";
							}
							else
							{
								this.vmethod_704().Text = "米";
							}
						}
						if (mineClearingMission.StationDepth_Submarine.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_702().Text = "英尺";
								System.Windows.Forms.Control arg_2EA4_0 = this.vmethod_686();
								float? num = mineClearingMission.StationDepth_Submarine;
								arg_2EA4_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_702().Text = "米";
								this.vmethod_686().Text = Conversions.ToString(mineClearingMission.StationDepth_Submarine.Value);
							}
						}
						else
						{
							this.vmethod_686().Text = "未定";
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_702().Text = "英尺";
							}
							else
							{
								this.vmethod_702().Text = "米";
							}
						}
						this.GetTC_MissionOptions().SelectedIndex = 6;
						this.vmethod_102().method_0("编辑扫雷区");
						this.vmethod_102().list_0 = mineClearingMission.AreaVertices;
						this.vmethod_102().method_1();
						this.vmethod_100().Checked = mineClearingMission.OTR;
						return;
					}
					case Mission._MissionClass.Escort:
					{
						this.GetTC_MissionOptions().TabPages[1].Enabled = true;
						TankerMission tankerMission = (TankerMission)this.GetSelectedMission();
						System.Windows.Forms.ComboBox comboBox_ = this.vmethod_286();
						this.method_61(ref comboBox_, ref dataTable, tankerMission.m_FlightSize);
						this.vmethod_287(comboBox_);
						if (Information.IsNothing(tankerMission.TransitThrottle_Aircraft))
						{
							this.vmethod_358().SelectedIndex = 4;
						}
						else
						{
							this.vmethod_358().SelectedIndex = (int)(tankerMission.TransitThrottle_Aircraft.Value - ActiveUnit.Throttle.Loiter);
						}
						if (Information.IsNothing(tankerMission.StationThrottle_Aircraft))
						{
							this.vmethod_354().SelectedIndex = 4;
						}
						else
						{
							this.vmethod_354().SelectedIndex = (int)(tankerMission.StationThrottle_Aircraft.Value - ActiveUnit.Throttle.Loiter);
						}
						this.vmethod_458().Checked = tankerMission.UseFlightSizeHardLimit;
						this.vmethod_620().Checked = tankerMission.TransitTerrainFollowing_Aircraft;
						this.vmethod_620().Enabled = tankerMission.TransitAltitude_Aircraft.HasValue;
						this.vmethod_618().Checked = tankerMission.AttackTerrainFollowing_Aircraft;
						this.vmethod_618().Enabled = tankerMission.StationAltitude_Aircraft.HasValue;
						comboBox_ = this.vmethod_400();
						this.method_64(ref comboBox_, ref dataTable5, (int)tankerMission.MinAircraftReq, false, false);
						this.vmethod_401(comboBox_);
						if (tankerMission.TransitAltitude_Aircraft.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_368().Text = "英尺";
								System.Windows.Forms.Control arg_3131_0 = this.vmethod_366();
								float? num = tankerMission.TransitAltitude_Aircraft;
								arg_3131_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_368().Text = "米";
								this.vmethod_366().Text = Conversions.ToString(tankerMission.TransitAltitude_Aircraft.Value);
							}
						}
						else
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_368().Text = "英尺";
							}
							else
							{
								this.vmethod_368().Text = "米";
							}
							this.vmethod_366().Text = "未定";
						}
						if (tankerMission.StationAltitude_Aircraft.HasValue)
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_364().Text = "英尺";
								System.Windows.Forms.Control arg_3226_0 = this.vmethod_370();
								float? num = tankerMission.StationAltitude_Aircraft;
								arg_3226_0.Text = Conversions.ToString((int)Math.Round((double)(num.HasValue ? new float?(num.GetValueOrDefault() * 3.28084f) : null).Value));
							}
							else
							{
								this.vmethod_364().Text = "米";
								this.vmethod_370().Text = Conversions.ToString(tankerMission.StationAltitude_Aircraft.Value);
							}
						}
						else
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								this.vmethod_364().Text = "英尺";
							}
							else
							{
								this.vmethod_364().Text = "米";
							}
							this.vmethod_370().Text = "未定";
						}
						this.GetTC_MissionOptions().SelectedIndex = 1;
						this.vmethod_110().Items.Clear();
						this.vmethod_110().DisplayMember = "Content";
						using (IEnumerator<Mission> enumerator = Client.GetClientSide().GetMissionCollection().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								tankerMission = (TankerMission)enumerator.Current;
								if (tankerMission != this.GetSelectedMission())
								{
									ComboBoxItem comboBoxItem = new ComboBoxItem();
									comboBoxItem.Content = tankerMission.Name;
									comboBoxItem.Tag = tankerMission.GetGuid();
									this.vmethod_110().Items.Add(comboBoxItem);
								}
							}
						}
						IEnumerator enumerator2 = this.vmethod_110().Items.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								object objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
								if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, null, "Tag", new object[0], null, null, null), tankerMission.EscortTargetMissionID, false))
								{
									this.vmethod_110().SelectedItem = RuntimeHelpers.GetObjectValue(objectValue);
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
						this.vmethod_110().Items.Clear();
						this.vmethod_110().DisplayMember = "Content";
						using (IEnumerator<Mission> enumerator3 = Client.GetClientSide().GetMissionCollection().GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								tankerMission = (TankerMission)enumerator3.Current;
								if (tankerMission != this.GetSelectedMission())
								{
									ComboBoxItem comboBoxItem2 = new ComboBoxItem();
									comboBoxItem2.Content = tankerMission.Name;
									comboBoxItem2.Tag = tankerMission.GetGuid();
									this.vmethod_110().Items.Add(comboBoxItem2);
								}
							}
						}
						IEnumerator enumerator4 = this.vmethod_110().Items.GetEnumerator();
						try
						{
							while (enumerator4.MoveNext())
							{
								object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator4.Current);
								if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue2, null, "Tag", new object[0], null, null, null), tankerMission.EscortTargetMissionID, false))
								{
									this.vmethod_110().SelectedItem = RuntimeHelpers.GetObjectValue(objectValue2);
									break;
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
						this.vmethod_116().Items.Clear();
						this.vmethod_116().DisplayMember = "Content";
						ActiveUnit[] activeUnitArray = Client.GetClientSide().ActiveUnitArray;
						checked
						{
							for (int i = 0; i < activeUnitArray.Length; i++)
							{
								ActiveUnit activeUnit = activeUnitArray[i];
								ComboBoxItem comboBoxItem3 = new ComboBoxItem();
								comboBoxItem3.Content = activeUnit.Name;
								comboBoxItem3.Tag = activeUnit.GetGuid();
								this.vmethod_116().Items.Add(comboBoxItem3);
							}
							IEnumerator enumerator5 = this.vmethod_116().Items.GetEnumerator();
							try
							{
								while (enumerator5.MoveNext())
								{
									object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator5.Current);
									if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue3, null, "Tag", new object[0], null, null, null), tankerMission.string_4, false))
									{
										this.vmethod_116().SelectedItem = RuntimeHelpers.GetObjectValue(objectValue3);
										IL_35D6:
										return;
									}
								}
								return;
							}
							finally
							{
								if (enumerator5 is IDisposable)
								{
									(enumerator5 as IDisposable).Dispose();
								}
							}
							break;
						}
					}
					case Mission._MissionClass.Cargo:
						break;
					default:
						return;
					}
					if (Client.GetClientScenario().DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps))
					{
						this.GetTC_MissionOptions().TabPages[7].Enabled = true;
						CargoMission cargoMission = (CargoMission)this.GetSelectedMission();
						CargoMissionViewModel dataContext = new CargoMissionViewModel(cargoMission);
						this.vmethod_1064().method_0("编辑上岸区");
						this.vmethod_1064().list_0 = cargoMission.AreaPoints;
						this.vmethod_1064().method_1();
						this.cargoMissionControl_0.DataContext = dataContext;
						this.GetTC_MissionOptions().SelectedIndex = 7;
					}
				}
			}
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x001B96E0 File Offset: 0x001B78E0
		private void method_26(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_92().Text) && Versioned.IsNumeric(this.vmethod_88().Text) && Versioned.IsNumeric(this.vmethod_86().Text) && Versioned.IsNumeric(this.vmethod_84().Text))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(this.vmethod_92().Text), Conversions.ToInteger(this.vmethod_88().Text), Conversions.ToInteger(this.vmethod_86().Text), Conversions.ToInteger(this.vmethod_84().Text));
				if (!Information.IsNothing(this.GetSelectedMission()))
				{
					((MiningMission)this.GetSelectedMission()).AD = (long)Math.Round(timeSpan.TotalSeconds);
				}
			}
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x001B96E0 File Offset: 0x001B78E0
		private void method_27(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_92().Text) && Versioned.IsNumeric(this.vmethod_88().Text) && Versioned.IsNumeric(this.vmethod_86().Text) && Versioned.IsNumeric(this.vmethod_84().Text))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(this.vmethod_92().Text), Conversions.ToInteger(this.vmethod_88().Text), Conversions.ToInteger(this.vmethod_86().Text), Conversions.ToInteger(this.vmethod_84().Text));
				if (!Information.IsNothing(this.GetSelectedMission()))
				{
					((MiningMission)this.GetSelectedMission()).AD = (long)Math.Round(timeSpan.TotalSeconds);
				}
			}
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x001B96E0 File Offset: 0x001B78E0
		private void method_28(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_92().Text) && Versioned.IsNumeric(this.vmethod_88().Text) && Versioned.IsNumeric(this.vmethod_86().Text) && Versioned.IsNumeric(this.vmethod_84().Text))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(this.vmethod_92().Text), Conversions.ToInteger(this.vmethod_88().Text), Conversions.ToInteger(this.vmethod_86().Text), Conversions.ToInteger(this.vmethod_84().Text));
				if (!Information.IsNothing(this.GetSelectedMission()))
				{
					((MiningMission)this.GetSelectedMission()).AD = (long)Math.Round(timeSpan.TotalSeconds);
				}
			}
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x001B96E0 File Offset: 0x001B78E0
		private void method_29(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_92().Text) && Versioned.IsNumeric(this.vmethod_88().Text) && Versioned.IsNumeric(this.vmethod_86().Text) && Versioned.IsNumeric(this.vmethod_84().Text))
			{
				TimeSpan timeSpan = new TimeSpan(Conversions.ToInteger(this.vmethod_92().Text), Conversions.ToInteger(this.vmethod_88().Text), Conversions.ToInteger(this.vmethod_86().Text), Conversions.ToInteger(this.vmethod_84().Text));
				if (!Information.IsNothing(this.GetSelectedMission()))
				{
					((MiningMission)this.GetSelectedMission()).AD = (long)Math.Round(timeSpan.TotalSeconds);
				}
			}
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x00022B7C File Offset: 0x00020D7C
		private void method_30(object sender, EventArgs e)
		{
			((SupportMission)this.GetSelectedMission()).NLT = (SupportMission._NLT)this.vmethod_36().SelectedIndex;
		}

		// Token: 0x060048A9 RID: 18601 RVA: 0x00022B9A File Offset: 0x00020D9A
		private void method_31(object sender, EventArgs e)
		{
			((FerryMission)this.GetSelectedMission()).SetFerryMissionBehavior((FerryMission.FerryMissionBehavior)this.GetCombo_FerryBehavior().SelectedIndex);
		}

		// Token: 0x060048AA RID: 18602 RVA: 0x001B97AC File Offset: 0x001B79AC
		private void method_32(object sender, EventArgs e)
		{
			switch (this.GetCombo_Strike_MinimumContactStanceToTrigger().SelectedIndex)
			{
			case 0:
				((Strike)this.GetSelectedMission()).MinimumContactStanceToTrigger = Misc.PostureStance.Unknown;
				break;
			case 1:
				((Strike)this.GetSelectedMission()).MinimumContactStanceToTrigger = Misc.PostureStance.Unfriendly;
				break;
			case 2:
				((Strike)this.GetSelectedMission()).MinimumContactStanceToTrigger = Misc.PostureStance.Hostile;
				break;
			}
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x00022BB8 File Offset: 0x00020DB8
		private void method_33(object sender, EventArgs e)
		{
			this.method_35(this.vmethod_20());
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x00022BC6 File Offset: 0x00020DC6
		private void method_34(object sender, EventArgs e)
		{
			this.method_35(this.vmethod_22());
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x001B9810 File Offset: 0x001B7A10
		private void method_35(System.Windows.Forms.TreeView treeView_3)
		{
			List<TreeNode> list = new List<TreeNode>();
			this.method_14(treeView_3.Nodes, ref list);
			List<Aircraft> list2 = new List<Aircraft>();
			int num = 0;
			ActiveUnit activeUnit = null;
			bool flag = false;
			List<Mission.EmptySlot> list3 = new List<Mission.EmptySlot>();
			foreach (TreeNode current in list)
			{
				if (current.Tag.GetType() == typeof(Aircraft))
				{
					Aircraft aircraft = (Aircraft)current.Tag;
					if (!aircraft.IsOperating())
					{
						if (num == 0)
						{
							num = aircraft.DBID;
							activeUnit = aircraft.GetAircraftAirOps().GetCurrentHostUnit();
							list2.Add(aircraft);
						}
						else if (num == aircraft.DBID && aircraft.GetAircraftAirOps().GetCurrentHostUnit() == activeUnit)
						{
							list2.Add(aircraft);
						}
						else
						{
							flag = true;
						}
					}
				}
				else if (current.Tag.GetType() == typeof(Mission.EmptySlot) && this.GetSelectedMission().category == Mission.MissionCategory.Package)
				{
					Mission.EmptySlot emptySlot = (Mission.EmptySlot)current.Tag;
					if (num == 0)
					{
						num = emptySlot.aircraftDBID;
						activeUnit = emptySlot.GetHostUnit(Client.GetClientScenario());
						list3.Add(emptySlot);
					}
					else if (num == emptySlot.aircraftDBID && emptySlot.GetHostUnit(Client.GetClientScenario()) == activeUnit)
					{
						list3.Add(emptySlot);
					}
					else
					{
						flag = true;
					}
				}
			}
			if (list2.Count == 0 && list3.Count == 0)
			{
				Interaction.MsgBox("那么您没有选择飞机，要么您选择的飞机都已临空.", MsgBoxStyle.Exclamation, "选择无效!");
			}
			else
			{
				if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
				{
					List<Aircraft> list4 = new List<Aircraft>();
					foreach (Aircraft aircraft in list2)
					{
						Aircraft aircraft2 = aircraft;
						string text = null;
						if (aircraft2.GetMaintenanceLevel(ref text) == Aircraft_AirOps._Maintenance.Unavailable)
						{
							list4.Add(aircraft);
						}
					}
					if (list4.Count > 0)
					{
						Interaction.MsgBox(Conversions.ToString(list4.Count) + "架所选的飞机不满足战备条件，无法进行出动准备.", MsgBoxStyle.OkOnly, "所选飞机不可用!");
						foreach (Aircraft aircraft in list4)
						{
							list2.Remove(aircraft);
						}
					}
				}
				if (list2.Count != 0 || list3.Count != 0)
				{
					if (flag)
					{
						Interaction.MsgBox(string.Concat(new string[]
						{
							"您选择的飞机涉及多个机种或者多个机场。您将只能对所选的第一个机种(",
							Misc.smethod_11(list2[0].UnitClass),
							")且处于第一个机场(",
							list2[0].GetAircraftAirOps().GetCurrentHostUnit().Name,
							")的飞机进行出动准备."
						}), MsgBoxStyle.OkOnly, "多重选择");
					}
					CommandFactory.GetCommandMain().GetReadyAircraft().list_0 = list2;
					CommandFactory.GetCommandMain().GetReadyAircraft().list_1 = list3;
					CommandFactory.GetCommandMain().GetReadyAircraft().Show();
				}
			}
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x001B9BAC File Offset: 0x001B7DAC
		private void method_36(object sender, TreeNodeMouseClickEventArgs e)
		{
			IEnumerator enumerator = e.Node.Nodes.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((TreeNode)enumerator.Current).Checked = e.Node.Checked;
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

		// Token: 0x060048AF RID: 18607 RVA: 0x001B9BAC File Offset: 0x001B7DAC
		private void method_37(object sender, TreeNodeMouseClickEventArgs e)
		{
			IEnumerator enumerator = e.Node.Nodes.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((TreeNode)enumerator.Current).Checked = e.Node.Checked;
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

		// Token: 0x060048B0 RID: 18608 RVA: 0x00022BE0 File Offset: 0x00020DE0
		private void method_38(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				this.GetSelectedMission().SetMissionStatus(Client.GetClientScenario(), (Mission._MissionStatus)this.GetCombo_MissionStatus().SelectedIndex);
				this.method_1();
			}
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x001B9C1C File Offset: 0x001B7E1C
		private void method_39(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((TankerMission)this.GetSelectedMission()).EscortTargetMissionID = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_110().SelectedItem, null, "Tag", new object[0], null, null, null));
			}
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x001B9C6C File Offset: 0x001B7E6C
		private void method_40(object sender, EventArgs e)
		{
			this.vmethod_116().Enabled = this.vmethod_118().Checked;
			this.vmethod_110().Enabled = !this.vmethod_116().Enabled;
			if (this.vmethod_118().Checked && !Information.IsNothing(this.GetSelectedMission()))
			{
				((TankerMission)this.GetSelectedMission()).string_4 = Conversions.ToString(NewLateBinding.LateGet(this.vmethod_110().SelectedItem, null, "Tag", new object[0], null, null, null));
			}
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x00022C11 File Offset: 0x00020E11
		private void method_41(object sender, EventArgs e)
		{
			this.vmethod_110().Enabled = this.vmethod_114().Checked;
			this.vmethod_116().Enabled = !this.vmethod_110().Enabled;
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x00022C42 File Offset: 0x00020E42
		private void method_42(object sender, EventArgs e)
		{
			((Patrol)this.GetSelectedMission()).AEOIPA = this.vmethod_56().Checked;
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x00022C5F File Offset: 0x00020E5F
		private void method_43(object sender, EventArgs e)
		{
			((SupportMission)this.GetSelectedMission()).OTO = this.vmethod_72().Checked;
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x00022C7C File Offset: 0x00020E7C
		private void method_44(object sender, EventArgs e)
		{
			((SupportMission)this.GetSelectedMission()).OTR = this.vmethod_32().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x00022CA5 File Offset: 0x00020EA5
		private void method_45(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				this.GetSelectedMission().SISIH = this.GetCB_ScrubIfHuman().Checked;
			}
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x00022CCA File Offset: 0x00020ECA
		private void method_46(object sender, EventArgs e)
		{
			((Patrol)this.GetSelectedMission()).OTR = this.GetCB_Patrol_13rule().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x00022CF3 File Offset: 0x00020EF3
		private void method_47(object sender, EventArgs e)
		{
			((Patrol)this.GetSelectedMission()).method_44(Client.GetClientScenario(), this.GetCB_InvestigateOutsidePatrolArea().Checked);
			Client.b_Completed = true;
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x00022D1B File Offset: 0x00020F1B
		private void method_48(object sender, EventArgs e)
		{
			((MiningMission)this.GetSelectedMission()).bOTR = this.vmethod_96().Checked;
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x00022D38 File Offset: 0x00020F38
		private void method_49(object sender, EventArgs e)
		{
			((MineClearingMission)this.GetSelectedMission()).OTR = this.vmethod_100().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x001B9CFC File Offset: 0x001B7EFC
		private void Button_AddHighlighted_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike)
			{
				foreach (Unit current in Client.GetClientSide().GetUnitReadOnlyCollection())
				{
					if (current.GetSide(false) != Client.GetClientSide() && !Client.GetClientSide().IsFriendlyToSide(current.GetSide(false)))
					{
						if (current.IsGroup)
						{
							foreach (ActiveUnit current2 in ((Group)current).GetUnitsInGroup().Values)
							{
								((Strike)this.GetSelectedMission()).SpecificTargets.Add(current2);
							}
							if (this.GetSelectedMission().IsActive() && Client.GetClientSide().GetPostureStance(current.GetSide(false)) != Misc.PostureStance.Hostile)
							{
								Client.GetClientSide().SetPostureStance(current.GetSide(false), Misc.PostureStance.Hostile);
							}
						}
						else if (current.IsActiveUnit())
						{
							((Strike)this.GetSelectedMission()).SpecificTargets.Add(current);
							if (this.GetSelectedMission().IsActive() && Client.GetClientSide().GetPostureStance(current.GetSide(false)) != Misc.PostureStance.Hostile)
							{
								Client.GetClientSide().SetPostureStance(current.GetSide(false), Misc.PostureStance.Hostile);
							}
						}
						else
						{
							Contact contact = (Contact)current;
							if (!Information.IsNothing(contact.ActualUnit) && Client.GetClientSide().GetContactsObDictionary().ContainsKey(contact.ActualUnit.GetGuid()))
							{
								using (IEnumerator<ActiveUnit> enumerator3 = ((Group)contact.ActualUnit).GetUnitsInGroup().Values.GetEnumerator())
								{
									while (enumerator3.MoveNext())
									{
										ActiveUnit current3 = enumerator3.Current;
										((Strike)this.GetSelectedMission()).SpecificTargets.Add(current3);
									}
									goto IL_234;
								}
							}
							if (Client.GetClientSide().GetContactsObDictionary().ContainsKey(contact.ActualUnit.GetGuid()))
							{
								continue;
							}
							((Strike)this.GetSelectedMission()).SpecificTargets.Add(contact);
							IL_234:
							if (this.GetSelectedMission().IsActive() && contact.GetPostureStance(Client.GetClientSide()) != Misc.PostureStance.Hostile)
							{
								contact.MarkAs(Client.GetClientSide(), false, Misc.PostureStance.Hostile);
							}
						}
					}
				}
				this.method_51();
				this.GetSelectedMission().int_0 = 1;
				Client.b_Completed = true;
			}
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x001B9FEC File Offset: 0x001B81EC
		private void method_51()
		{
			this.vmethod_126().Items.Clear();
			foreach (Unit current in ((Strike)this.GetSelectedMission()).SpecificTargets.OrderBy(MissionEditor.UnitFunc13))
			{
				TreeNode treeNode = new TreeNode();
				treeNode.Name = current.Name;
				treeNode.Tag = current;
				this.vmethod_126().Items.Add(treeNode);
			}
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x001BA088 File Offset: 0x001B8288
		private void method_52(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike)
			{
				IEnumerator enumerator = this.vmethod_126().SelectedItems.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						TreeNode treeNode = (TreeNode)enumerator.Current;
						((Strike)this.GetSelectedMission()).SpecificTargets.Remove((Unit)treeNode.Tag);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.method_51();
				this.GetSelectedMission().int_0 = 1;
			}
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x001BA140 File Offset: 0x001B8340
		private void method_53(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike)
			{
				List<TreeNode> list = new List<TreeNode>();
				this.method_14(this.vmethod_22().Nodes, ref list);
                TreeNode currentX;

                foreach (TreeNode current in list)
				{
					if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(current.Tag)))
					{
						if (current.Tag.GetType() == typeof(string))
						{
							IEnumerator enumerator2 = current.Nodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									TreeNode treeNode = (TreeNode)enumerator2.Current;
									if (treeNode.Tag.GetType().BaseType.BaseType == typeof(ActiveUnit))
									{
										this.SelectedUnit = (ActiveUnit)treeNode.Tag;
										this.SelectedUnit.GetAI().IsEscort = true;
										if (this.SelectedUnit.IsAircraft)
										{
											Aircraft aircraft = (Aircraft)this.SelectedUnit;
											this.method_7(ref aircraft, ref treeNode);
										}
										else
										{
											this.method_8(ref this.SelectedUnit, ref treeNode);
										}
									}
								}
								continue;
							}
							finally
							{
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
						if (current.Tag.GetType() == typeof(Mission.EmptySlot))
						{
							if (this.GetSelectedMission().category == Mission.MissionCategory.Package)
							{
								((Mission.EmptySlot)current.Tag).IsEscort = true;
								if (!current.Text.StartsWith("[Escort]"))
								{
									current.Text = "[Escort] " + current.Text;
								}
							}
						}
						else
						{
							this.SelectedUnit = (ActiveUnit)current.Tag;
							if (this.SelectedUnit.IsGroup)
							{
								IEnumerator enumerator3 = current.Nodes.GetEnumerator();
								try
								{
									while (enumerator3.MoveNext())
									{
										TreeNode treeNode2 = (TreeNode)enumerator3.Current;
										if (treeNode2.Tag.GetType().BaseType.BaseType == typeof(ActiveUnit))
										{
											this.SelectedUnit = (ActiveUnit)treeNode2.Tag;
											this.SelectedUnit.GetAI().IsEscort = true;
											if (this.SelectedUnit.IsAircraft)
											{
												Aircraft aircraft = (Aircraft)this.SelectedUnit;
												this.method_7(ref aircraft, ref treeNode2);
											}
											else
											{
												this.method_8(ref this.SelectedUnit, ref treeNode2);
											}
										}
									}
									continue;
								}
								finally
								{
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
									}
								}
							}
							this.SelectedUnit.GetAI().IsEscort = true;
							if (this.SelectedUnit.IsAircraft)
							{
								Aircraft aircraft = (Aircraft)this.SelectedUnit;
                                currentX = current;

                                this.method_7(ref aircraft, ref currentX);
							}
							else
							{
                                currentX = current;
                                this.method_8(ref this.SelectedUnit, ref currentX);
							}
						}
					}
				}
				this.GetSelectedMission().int_0 = 1;
			}
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x001BA4C8 File Offset: 0x001B86C8
		private void method_54(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike)
			{
				List<TreeNode> list = new List<TreeNode>();
				this.method_14(this.vmethod_22().Nodes, ref list);
                TreeNode currentX;

                foreach (TreeNode current in list)
				{
					if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(current.Tag)))
					{
						if (current.Tag.GetType() == typeof(string))
						{
							IEnumerator enumerator2 = current.Nodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									TreeNode treeNode = (TreeNode)enumerator2.Current;
									if (treeNode.Tag.GetType().BaseType.BaseType == typeof(ActiveUnit))
									{
										this.SelectedUnit = (ActiveUnit)treeNode.Tag;
										this.SelectedUnit.GetAI().IsEscort = false;
										if (this.SelectedUnit.IsAircraft)
										{
											string text = this.method_11((Aircraft)this.SelectedUnit, false);
										}
										else
										{
											string text = this.SelectedUnit.Name;
										}
										treeNode.Text = this.SelectedUnit.Name + " (" + Misc.smethod_11(this.SelectedUnit.UnitClass) + ")";
										if (this.SelectedUnit.IsAircraft)
										{
											Aircraft aircraft = (Aircraft)this.SelectedUnit;
                                            currentX = current;

                                            this.method_7(ref aircraft, ref currentX);
										}
										else
										{
                                            currentX = current;
                                            this.method_8(ref this.SelectedUnit, ref currentX);
										}
									}
								}
								continue;
							}
							finally
							{
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
						if (current.Tag.GetType() == typeof(Mission.EmptySlot))
						{
							if (this.GetSelectedMission().category == Mission.MissionCategory.Package)
							{
								Mission.EmptySlot emptySlot = (Mission.EmptySlot)current.Tag;
								emptySlot.IsEscort = false;
								current.Text = string.Concat(new string[]
								{
									"[EMPTY SLOT] (",
									emptySlot.LoadoutName,
									") (",
									emptySlot.CurrentHostUnit_Name,
									")"
								});
							}
						}
						else
						{
							this.SelectedUnit = (ActiveUnit)current.Tag;
							string text;
							if (this.SelectedUnit.IsGroup)
							{
								IEnumerator enumerator3 = current.Nodes.GetEnumerator();
								try
								{
									while (enumerator3.MoveNext())
									{
										TreeNode treeNode2 = (TreeNode)enumerator3.Current;
										if (treeNode2.Tag.GetType().BaseType.BaseType == typeof(ActiveUnit))
										{
											this.SelectedUnit = (ActiveUnit)treeNode2.Tag;
											this.SelectedUnit.GetAI().IsEscort = false;
											if (this.SelectedUnit.IsAircraft)
											{
												text = this.method_11((Aircraft)this.SelectedUnit, false);
											}
											else
											{
												text = this.SelectedUnit.Name;
											}
											treeNode2.Text = this.SelectedUnit.Name + " (" + Misc.smethod_11(this.SelectedUnit.UnitClass) + ")";
											if (this.SelectedUnit.IsAircraft)
											{
												Aircraft aircraft = (Aircraft)this.SelectedUnit;
                                                currentX = current;

                                                this.method_7(ref aircraft, ref currentX);
											}
											else
											{
                                                currentX = current;
                                                this.method_8(ref this.SelectedUnit, ref currentX);
											}
										}
									}
									continue;
								}
								finally
								{
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
									}
								}
							}
							this.SelectedUnit.GetAI().IsEscort = false;
							if (this.SelectedUnit.IsAircraft)
							{
								text = this.method_11((Aircraft)this.SelectedUnit, false);
							}
							else
							{
								text = this.SelectedUnit.Name;
							}
							current.Text = text;
							if (this.SelectedUnit.IsAircraft)
							{
								Aircraft aircraft = (Aircraft)this.SelectedUnit;
                                currentX = current;

                                this.method_7(ref aircraft, ref currentX);
							}
							else
							{
                                currentX = current;
                                this.method_8(ref this.SelectedUnit, ref currentX);
							}
						}
					}
				}
				this.GetSelectedMission().int_0 = 1;
			}
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x001BA984 File Offset: 0x001B8B84
		private void MissionEditor_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				this.method_21();
				this.method_81();
				this.method_84();
				this.method_85();
				this.method_276();
				this.method_97();
				this.method_100();
				this.method_103();
				this.method_106();
				this.method_109();
				this.method_112();
				this.method_115();
				this.method_118();
				this.method_121();
				this.method_135();
				this.method_86();
				this.method_87();
				this.method_88();
				this.method_279();
				this.method_89();
				this.method_90();
				this.method_93();
				this.method_94();
				this.method_95();
				this.method_96();
				this.method_246();
				this.method_248();
				this.method_250();
				this.method_252();
				this.method_148();
				this.method_151();
				this.method_286();
				base.Close();
			}
			else if (e.KeyCode == Keys.F11 && base.Visible)
			{
				this.method_21();
				this.method_81();
				this.method_84();
				this.method_97();
				this.method_100();
				this.method_103();
				this.method_106();
				this.method_109();
				this.method_112();
				this.method_115();
				this.method_118();
				this.method_121();
				this.method_135();
				this.method_86();
				this.method_87();
				this.method_88();
				this.method_89();
				this.method_90();
				this.method_93();
				this.method_94();
				this.method_95();
				this.method_96();
				this.method_246();
				this.method_248();
				this.method_250();
				this.method_252();
				this.method_148();
				this.method_151();
				this.method_286();
				CommandFactory.GetCommandMain().GetTankerPlanner().Close();
				base.Close();
			}
			else if (!this.bool_0)
			{
				if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
				{
					CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
				if (e.KeyCode == Keys.Space)
				{
					CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x00022D61 File Offset: 0x00020F61
		private void method_55(object sender, EventArgs e)
		{
			((Strike)this.GetSelectedMission()).UseAutoPlanner = this.GetCB_Strike_UseOffAxisAttack().Checked;
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x001BAC20 File Offset: 0x001B8E20
		private void method_56(object sender, DrawItemEventArgs e)
		{
			Graphics graphics = e.Graphics;
			TabPage tabPage = this.GetTC_PatrolAndProsecutionZones().TabPages[e.Index];
			Rectangle tabRect = this.GetTC_PatrolAndProsecutionZones().GetTabRect(e.Index);
			Brush brush = new SolidBrush(Color.Black);
			if (e.State == DrawItemState.Selected)
			{
				graphics.FillRectangle(Brushes.White, e.Bounds);
			}
			else
			{
				graphics.FillRectangle(new SolidBrush(SystemColors.Control), e.Bounds);
			}
			Font font = this.GetTC_PatrolAndProsecutionZones().Font;
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			graphics.DrawString(tabPage.Text, font, brush, tabRect, new StringFormat(stringFormat));
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x00022D7E File Offset: 0x00020F7E
		private void method_57(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((Patrol)this.GetSelectedMission()).SAD = this.vmethod_150().Checked;
			}
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00022DA8 File Offset: 0x00020FA8
		private void method_58(object sender, EventArgs e)
		{
			((SupportMission)this.GetSelectedMission()).AEOOS = this.vmethod_160().Checked;
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x001BACE0 File Offset: 0x001B8EE0
		private void method_59(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.GetTB_Patrol_XUnitsOnStation().Text))
			{
				if (!Versioned.IsNumeric(this.GetTB_Patrol_XUnitsOnStation().Text))
				{
					((Patrol)this.GetSelectedMission()).MNOS = 0;
				}
				else if (!Information.IsNothing(this.GetSelectedMission()))
				{
					if (Conversions.ToInteger(this.GetTB_Patrol_XUnitsOnStation().Text) > 0)
					{
						((Patrol)this.GetSelectedMission()).MNOS = Conversions.ToInteger(this.GetTB_Patrol_XUnitsOnStation().Text);
					}
					else
					{
						((Patrol)this.GetSelectedMission()).MNOS = 0;
					}
				}
			}
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x001BAD7C File Offset: 0x001B8F7C
		private void method_60(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.vmethod_180().Text))
			{
				if (!Versioned.IsNumeric(this.vmethod_180().Text))
				{
					((SupportMission)this.GetSelectedMission()).MNOS = 0;
				}
				else if (!Information.IsNothing(this.GetSelectedMission()))
				{
					if (Conversions.ToInteger(this.vmethod_180().Text) > 0)
					{
						((SupportMission)this.GetSelectedMission()).MNOS = Conversions.ToInteger(this.vmethod_180().Text);
					}
					else
					{
						((SupportMission)this.GetSelectedMission()).MNOS = 0;
					}
				}
			}
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x001BAE18 File Offset: 0x001B9018
		private void MissionEditor_FormClosed(object sender, FormClosedEventArgs e)
		{
			Scenario.RemoveUnitRemovedEvent(new Scenario.UnitRemovedEventHandler(this.method_22));
			Doctrine.smethod_1(new Doctrine.Delegate9(this.method_2));
			MissionEditor.smethod_1(new MissionEditor.Delegate64(this.method_3));
			this.vmethod_92().TextChanged -= new EventHandler(this.method_26);
			this.vmethod_88().TextChanged -= new EventHandler(this.method_27);
			this.vmethod_86().TextChanged -= new EventHandler(this.method_28);
			this.vmethod_84().TextChanged -= new EventHandler(this.method_29);
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x001BAEB4 File Offset: 0x001B90B4
		private void method_61(ref System.Windows.Forms.ComboBox comboBox_117, ref DataTable dataTable_0, Mission._FlightSize _FlightSize_0)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				Mission.GetFlightSizeString(Mission._FlightSize.SingleAircraft)
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				Mission.GetFlightSizeString(Mission._FlightSize.TwoAircraft)
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				Mission.GetFlightSizeString(Mission._FlightSize.ThreeAircraft)
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				Mission.GetFlightSizeString(Mission._FlightSize.FourAircraft)
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				Mission.GetFlightSizeString(Mission._FlightSize.SixAircraft)
			});
			System.Windows.Forms.ComboBox comboBox = comboBox_117;
			comboBox.DataSource = dataTable_0;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (_FlightSize_0 == Mission._FlightSize.SingleAircraft)
			{
				comboBox.SelectedIndex = 0;
			}
			else if (_FlightSize_0 == Mission._FlightSize.TwoAircraft)
			{
				comboBox.SelectedIndex = 1;
			}
			else if (_FlightSize_0 == Mission._FlightSize.ThreeAircraft)
			{
				comboBox.SelectedIndex = 2;
			}
			else if (_FlightSize_0 == Mission._FlightSize.FourAircraft)
			{
				comboBox.SelectedIndex = 3;
			}
			else if (_FlightSize_0 == Mission._FlightSize.SixAircraft)
			{
				comboBox.SelectedIndex = 4;
			}
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x001BB05C File Offset: 0x001B925C
		private void method_62(ref System.Windows.Forms.ComboBox comboBox_117, ref DataTable dataTable_0, Mission._GroupSize enum61_0)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				Mission.GetShipGroupSizeString(Mission._GroupSize.const_1)
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				Mission.GetShipGroupSizeString(Mission._GroupSize.const_2)
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				Mission.GetShipGroupSizeString(Mission._GroupSize.const_3)
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				Mission.GetShipGroupSizeString(Mission._GroupSize.const_4)
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				Mission.GetShipGroupSizeString(Mission._GroupSize.const_5)
			});
			System.Windows.Forms.ComboBox comboBox = comboBox_117;
			comboBox.DataSource = dataTable_0;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (enum61_0 == Mission._GroupSize.const_1)
			{
				comboBox.SelectedIndex = 0;
			}
			else if (enum61_0 == Mission._GroupSize.const_2)
			{
				comboBox.SelectedIndex = 1;
			}
			else if (enum61_0 == Mission._GroupSize.const_3)
			{
				comboBox.SelectedIndex = 2;
			}
			else if (enum61_0 == Mission._GroupSize.const_4)
			{
				comboBox.SelectedIndex = 3;
			}
			else if (enum61_0 == Mission._GroupSize.const_5)
			{
				comboBox.SelectedIndex = 4;
			}
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x001BB204 File Offset: 0x001B9404
		private void method_63(ref System.Windows.Forms.ComboBox comboBox_117, ref DataTable dataTable_0, Mission._FlightSize _FlightSize_0)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				"使用与战斗机和压制敌防空相同设置"
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				"单机, 一般用于电子战、空中预警与侦查"
			});
			System.Windows.Forms.ComboBox comboBox = comboBox_117;
			comboBox.DataSource = dataTable_0;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			if (_FlightSize_0 == Mission._FlightSize.None)
			{
				comboBox.SelectedIndex = 0;
			}
			else if (_FlightSize_0 == Mission._FlightSize.SingleAircraft)
			{
				comboBox.SelectedIndex = 1;
			}
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x001BB300 File Offset: 0x001B9500
		private void method_64(ref System.Windows.Forms.ComboBox comboBox_117, ref DataTable dataTable_0, int int_0, bool bool_33, bool bool_34)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			if (!bool_34)
			{
				dataTable_0.Rows.Add(new object[]
				{
					0,
					"所有飞机编队出动"
				});
				if (bool_33)
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"无飞机"
					});
				}
				else
				{
					dataTable_0.Rows.Add(new object[]
					{
						1,
						"无偏好"
					});
				}
				dataTable_0.Rows.Add(new object[]
				{
					2,
					"1机编队"
				});
				dataTable_0.Rows.Add(new object[]
				{
					3,
					"2机编队"
				});
				dataTable_0.Rows.Add(new object[]
				{
					4,
					"3机编队"
				});
				dataTable_0.Rows.Add(new object[]
				{
					5,
					"4机编队"
				});
				dataTable_0.Rows.Add(new object[]
				{
					6,
					"6机编队"
				});
				dataTable_0.Rows.Add(new object[]
				{
					7,
					"8机编队"
				});
				dataTable_0.Rows.Add(new object[]
				{
					8,
					"12机编队"
				});
				System.Windows.Forms.ComboBox comboBox = comboBox_117;
				comboBox.DataSource = dataTable_0;
				comboBox.DisplayMember = "Description";
				comboBox.ValueMember = "ID";
				comboBox.SelectedIndex = this.GetSelectedMission().method_33(int_0, bool_34);
			}
			else
			{
				dataTable_0.Rows.Add(new object[]
				{
					0,
					"所有飞机单独出动"
				});
				dataTable_0.Rows.Add(new object[]
				{
					1,
					"无偏好"
				});
				System.Windows.Forms.ComboBox comboBox2 = comboBox_117;
				comboBox2.DataSource = dataTable_0;
				comboBox2.DisplayMember = "Description";
				comboBox2.ValueMember = "ID";
				comboBox2.SelectedIndex = this.GetSelectedMission().method_33(int_0, bool_34);
			}
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x001BB5B4 File Offset: 0x001B97B4
		private void method_65(int int_0, ref int int_1, bool bool_33)
		{
			Mission selectedMission = this.GetSelectedMission();
			object value = int_0;
			int num = selectedMission.method_32(ref value, bool_33);
			int_0 = Conversions.ToInteger(value);
			int_1 = num;
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x001BB5E4 File Offset: 0x001B97E4
		private void method_66(ref System.Windows.Forms.ComboBox comboBox_117, ref DataTable dataTable_0, int int_0, bool bool_33, bool bool_34)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			if (!bool_34)
			{
				dataTable_0.Rows.Add(new object[]
				{
					0,
					"无偏好"
				});
				dataTable_0.Rows.Add(new object[]
				{
					1,
					"1机编队"
				});
				dataTable_0.Rows.Add(new object[]
				{
					2,
					"2机编队"
				});
				dataTable_0.Rows.Add(new object[]
				{
					3,
					"3机编队"
				});
				dataTable_0.Rows.Add(new object[]
				{
					4,
					"4机编队"
				});
				dataTable_0.Rows.Add(new object[]
				{
					5,
					"6机编队"
				});
				dataTable_0.Rows.Add(new object[]
				{
					6,
					"8机编队"
				});
				dataTable_0.Rows.Add(new object[]
				{
					7,
					"12机编队"
				});
				System.Windows.Forms.ComboBox comboBox = comboBox_117;
				comboBox.DataSource = dataTable_0;
				comboBox.DisplayMember = "Description";
				comboBox.ValueMember = "ID";
				comboBox.SelectedIndex = this.GetSelectedMission().method_35(int_0, bool_34);
			}
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x001BB7BC File Offset: 0x001B99BC
		private void method_67(ref System.Windows.Forms.ComboBox comboBox_117, ref DataTable dataTable_0, Mission.Enum60 enum60_0)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				"根据每个挂载设置决定是投掷/抛弃还是带回空对地弹药"
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				"在最远距离上投掷/抛弃空对地弹药以满足最大打击半径"
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"如果目标不能打击则带回空对地弹药"
			});
			System.Windows.Forms.ComboBox comboBox = comboBox_117;
			comboBox.DataSource = dataTable_0;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			comboBox.SelectedIndex = (int)((Strike)this.GetSelectedMission()).Bingo;
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x001BB8D0 File Offset: 0x001B9AD0
		private void method_68(int int_0, ref int int_1, bool bool_33)
		{
			Mission selectedMission = this.GetSelectedMission();
			object value = int_0;
			int num = selectedMission.method_34(ref value, bool_33);
			int_0 = Conversions.ToInteger(value);
			int_1 = num;
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x001BB900 File Offset: 0x001B9B00
		private void method_69(ref int int_0, ref Mission._FlightSize _FlightSize_0)
		{
			if (int_0 == 0)
			{
				_FlightSize_0 = Mission._FlightSize.SingleAircraft;
			}
			else if (int_0 == 1)
			{
				_FlightSize_0 = Mission._FlightSize.TwoAircraft;
			}
			else if (int_0 == 2)
			{
				_FlightSize_0 = Mission._FlightSize.ThreeAircraft;
			}
			else if (int_0 == 3)
			{
				_FlightSize_0 = Mission._FlightSize.FourAircraft;
			}
			else if (int_0 == 4)
			{
				_FlightSize_0 = Mission._FlightSize.SixAircraft;
			}
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x001BB900 File Offset: 0x001B9B00
		private void method_70(ref int int_0, ref Mission._GroupSize enum61_0)
		{
			if (int_0 == 0)
			{
				enum61_0 = Mission._GroupSize.const_1;
			}
			else if (int_0 == 1)
			{
				enum61_0 = Mission._GroupSize.const_2;
			}
			else if (int_0 == 2)
			{
				enum61_0 = Mission._GroupSize.const_3;
			}
			else if (int_0 == 3)
			{
				enum61_0 = Mission._GroupSize.const_4;
			}
			else if (int_0 == 4)
			{
				enum61_0 = Mission._GroupSize.const_5;
			}
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x00022DC5 File Offset: 0x00020FC5
		private void method_71(ref int int_0, ref Mission._FlightSize _FlightSize_0)
		{
			if (int_0 == 0)
			{
				_FlightSize_0 = Mission._FlightSize.None;
			}
			else if (int_0 == 1)
			{
				_FlightSize_0 = Mission._FlightSize.SingleAircraft;
			}
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x001BB958 File Offset: 0x001B9B58
		private void method_72(object sender, EventArgs e)
		{
			System.Windows.Forms.ComboBox comboBox_FlightSize_Strike;
			int selectedIndex = (comboBox_FlightSize_Strike = this.GetComboBox_FlightSize_Strike()).SelectedIndex;
			this.method_69(ref selectedIndex, ref ((Strike)this.GetSelectedMission()).m_FlightSize);
			comboBox_FlightSize_Strike.SelectedIndex = selectedIndex;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x001BB9A0 File Offset: 0x001B9BA0
		private void method_73(object sender, EventArgs e)
		{
			System.Windows.Forms.ComboBox comboBox;
			int selectedIndex = (comboBox = this.vmethod_232()).SelectedIndex;
			this.method_69(ref selectedIndex, ref ((Patrol)this.GetSelectedMission()).m_FlightSize);
			comboBox.SelectedIndex = selectedIndex;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x001BB9E8 File Offset: 0x001B9BE8
		private void method_74(object sender, EventArgs e)
		{
			System.Windows.Forms.ComboBox comboBox_FlightSize_Support;
			int selectedIndex = (comboBox_FlightSize_Support = this.GetComboBox_FlightSize_Support()).SelectedIndex;
			this.method_69(ref selectedIndex, ref ((SupportMission)this.GetSelectedMission()).m_FlightSize);
			comboBox_FlightSize_Support.SelectedIndex = selectedIndex;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x001BBA30 File Offset: 0x001B9C30
		private void method_75(object sender, EventArgs e)
		{
			System.Windows.Forms.ComboBox comboBox;
			int selectedIndex = (comboBox = this.vmethod_248()).SelectedIndex;
			this.method_69(ref selectedIndex, ref ((FerryMission)this.GetSelectedMission()).m_FlightSize);
			comboBox.SelectedIndex = selectedIndex;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x001BBA78 File Offset: 0x001B9C78
		private void method_76(object sender, EventArgs e)
		{
			System.Windows.Forms.ComboBox comboBox;
			int selectedIndex = (comboBox = this.vmethod_260()).SelectedIndex;
			this.method_69(ref selectedIndex, ref ((MiningMission)this.GetSelectedMission()).m_FlightSize);
			comboBox.SelectedIndex = selectedIndex;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x001BBAC0 File Offset: 0x001B9CC0
		private void method_77(object sender, EventArgs e)
		{
			System.Windows.Forms.ComboBox comboBox;
			int selectedIndex = (comboBox = this.vmethod_272()).SelectedIndex;
			this.method_69(ref selectedIndex, ref ((MineClearingMission)this.GetSelectedMission()).m_FlightSize);
			comboBox.SelectedIndex = selectedIndex;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x001BBB08 File Offset: 0x001B9D08
		private void method_78(object sender, EventArgs e)
		{
			if (this.SelectedMission.MissionClass == Mission._MissionClass.Strike)
			{
				System.Windows.Forms.ComboBox comboBox;
				int selectedIndex = (comboBox = this.vmethod_286()).SelectedIndex;
				this.method_69(ref selectedIndex, ref ((Strike)this.GetSelectedMission()).Escort_FlightSize_Shooter);
				comboBox.SelectedIndex = selectedIndex;
			}
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060048DB RID: 18651 RVA: 0x00022DE3 File Offset: 0x00020FE3
		private void method_79(object sender, EventArgs e)
		{
			this.bool_5 = true;
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x00022DEC File Offset: 0x00020FEC
		private void method_80(object sender, EventArgs e)
		{
			this.method_81();
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x001BBB64 File Offset: 0x001B9D64
		private void method_81()
		{
			if (this.bool_5)
			{
				this.bool_5 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Patrol)
				{
					if (string.IsNullOrEmpty(this.GetTB_PatrolTransitAltitude_Aircraft().Text) || !Versioned.IsNumeric(this.GetTB_PatrolTransitAltitude_Aircraft().Text))
					{
						((Patrol)this.GetSelectedMission()).TransitAltitude_Aircraft = null;
						this.GetTB_PatrolTransitAltitude_Aircraft().Text = "未定";
						this.GetCheckBox_PatrolTransitTerrainFollowing_Aircraft().Enabled = false;
					}
					else if (Conversions.ToInteger(this.GetTB_PatrolTransitAltitude_Aircraft().Text) > 0)
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((Patrol)this.GetSelectedMission()).TransitAltitude_Aircraft = new float?((float)(Conversions.ToDouble(this.GetTB_PatrolTransitAltitude_Aircraft().Text) * 0.30480000376701355));
						}
						else
						{
							((Patrol)this.GetSelectedMission()).TransitAltitude_Aircraft = new float?(Conversions.ToSingle(this.GetTB_PatrolTransitAltitude_Aircraft().Text));
						}
						this.GetCheckBox_PatrolTransitTerrainFollowing_Aircraft().Enabled = true;
					}
					else
					{
						((Patrol)this.GetSelectedMission()).TransitAltitude_Aircraft = null;
						this.GetTB_PatrolTransitAltitude_Aircraft().Text = "未定";
						this.GetCheckBox_PatrolTransitTerrainFollowing_Aircraft().Enabled = false;
					}
				}
			}
			else
			{
				this.bool_5 = false;
			}
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x00022DF4 File Offset: 0x00020FF4
		private void method_82(object sender, EventArgs e)
		{
			this.bool_6 = true;
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x00022DFD File Offset: 0x00020FFD
		private void method_83(object sender, EventArgs e)
		{
			this.method_84();
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x001BBCD4 File Offset: 0x001B9ED4
		private void method_84()
		{
			if (this.bool_6)
			{
				this.bool_6 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Patrol)
				{
					if (string.IsNullOrEmpty(this.GetTB_PatrolStationAltitude_Aircraft().Text) || !Versioned.IsNumeric(this.GetTB_PatrolStationAltitude_Aircraft().Text))
					{
						((Patrol)this.GetSelectedMission()).StationAltitude_Aircraft = null;
						this.GetTB_PatrolStationAltitude_Aircraft().Text = "未定";
						this.GetCheckBox_PatrolStationTerrainFollowing_Aircraft().Enabled = false;
					}
					else if (Conversions.ToInteger(this.GetTB_PatrolStationAltitude_Aircraft().Text) > 0)
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((Patrol)this.GetSelectedMission()).StationAltitude_Aircraft = new float?((float)(Conversions.ToDouble(this.GetTB_PatrolStationAltitude_Aircraft().Text) * 0.30480000376701355));
						}
						else
						{
							((Patrol)this.GetSelectedMission()).StationAltitude_Aircraft = new float?(Conversions.ToSingle(this.GetTB_PatrolStationAltitude_Aircraft().Text));
						}
						this.GetCheckBox_PatrolStationTerrainFollowing_Aircraft().Enabled = true;
					}
					else
					{
						((Patrol)this.GetSelectedMission()).StationAltitude_Aircraft = null;
						this.GetTB_PatrolStationAltitude_Aircraft().Text = "未定";
						this.GetCheckBox_PatrolStationTerrainFollowing_Aircraft().Enabled = false;
					}
				}
			}
			else
			{
				this.bool_6 = false;
			}
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x001BBE44 File Offset: 0x001BA044
		private void method_85()
		{
			if (this.bool_7)
			{
				this.bool_7 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Patrol)
				{
					if (string.IsNullOrEmpty(this.GetTB_PatrolAttackAltitude_Aircraft().Text) || !Versioned.IsNumeric(this.GetTB_PatrolAttackAltitude_Aircraft().Text))
					{
						((Patrol)this.GetSelectedMission()).AttackAltitude_Aircraft = null;
						this.GetTB_PatrolAttackAltitude_Aircraft().Text = "未定";
						this.GetCheckBox_PatrolAttackTerrainFollowing_Aircraft().Enabled = false;
					}
					else if (Conversions.ToInteger(this.GetTB_PatrolAttackAltitude_Aircraft().Text) > 0)
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((Patrol)this.GetSelectedMission()).AttackAltitude_Aircraft = new float?((float)(Conversions.ToDouble(this.GetTB_PatrolAttackAltitude_Aircraft().Text) * 0.30480000376701355));
						}
						else
						{
							((Patrol)this.GetSelectedMission()).AttackAltitude_Aircraft = new float?(Conversions.ToSingle(this.GetTB_PatrolAttackAltitude_Aircraft().Text));
						}
						this.GetCheckBox_PatrolAttackTerrainFollowing_Aircraft().Enabled = true;
					}
					else
					{
						((Patrol)this.GetSelectedMission()).AttackAltitude_Aircraft = null;
						this.GetTB_PatrolAttackAltitude_Aircraft().Text = "未定";
						this.GetCheckBox_PatrolAttackTerrainFollowing_Aircraft().Enabled = false;
					}
				}
			}
			else
			{
				this.bool_7 = false;
			}
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x001BBFB4 File Offset: 0x001BA1B4
		private void method_86()
		{
			if (this.bool_9)
			{
				this.bool_9 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Patrol)
				{
					if (string.IsNullOrEmpty(this.vmethod_524().Text) || !Versioned.IsNumeric(this.vmethod_524().Text))
					{
						((Patrol)this.GetSelectedMission()).TransitDepth_Submarine = null;
						this.vmethod_524().Text = "未定";
					}
					else
					{
						float num = Conversions.ToSingle(this.vmethod_524().Text);
						if (num > 0f)
						{
							num *= -1f;
							this.vmethod_524().Text = Conversions.ToString(num);
						}
						if (num > 0f)
						{
							((Patrol)this.GetSelectedMission()).TransitDepth_Submarine = null;
							this.vmethod_524().Text = "未定";
						}
						else if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((Patrol)this.GetSelectedMission()).TransitDepth_Submarine = new float?(num * 0.3048f);
						}
						else
						{
							((Patrol)this.GetSelectedMission()).TransitDepth_Submarine = new float?(num);
						}
					}
				}
			}
			else
			{
				this.bool_9 = false;
			}
		}

		// Token: 0x060048E3 RID: 18659 RVA: 0x001BC108 File Offset: 0x001BA308
		private void method_87()
		{
			if (this.bool_10)
			{
				this.bool_10 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Patrol)
				{
					if (string.IsNullOrEmpty(this.vmethod_522().Text) || !Versioned.IsNumeric(this.vmethod_522().Text))
					{
						((Patrol)this.GetSelectedMission()).StationDepth_Submarine = null;
						this.vmethod_522().Text = "未定";
					}
					else
					{
						float num = Conversions.ToSingle(this.vmethod_522().Text);
						if (num > 0f)
						{
							num *= -1f;
							this.vmethod_522().Text = Conversions.ToString(num);
						}
						if (num > 0f)
						{
							((Patrol)this.GetSelectedMission()).StationDepth_Submarine = null;
							this.vmethod_522().Text = "未定";
						}
						else if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((Patrol)this.GetSelectedMission()).StationDepth_Submarine = new float?(num * 0.3048f);
						}
						else
						{
							((Patrol)this.GetSelectedMission()).StationDepth_Submarine = new float?(num);
						}
					}
				}
			}
			else
			{
				this.bool_10 = false;
			}
		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x001BC25C File Offset: 0x001BA45C
		private void method_88()
		{
			if (this.bool_11)
			{
				this.bool_11 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Patrol)
				{
					if (string.IsNullOrEmpty(this.vmethod_520().Text) || !Versioned.IsNumeric(this.vmethod_520().Text))
					{
						((Patrol)this.GetSelectedMission()).AttackDepth_Submarine = null;
						this.vmethod_520().Text = "未定";
					}
					else
					{
						float num = Conversions.ToSingle(this.vmethod_520().Text);
						if (num > 0f)
						{
							num *= -1f;
							this.vmethod_520().Text = Conversions.ToString(num);
						}
						if (num > 0f)
						{
							((Patrol)this.GetSelectedMission()).AttackDepth_Submarine = null;
							this.vmethod_520().Text = "未定";
						}
						else if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((Patrol)this.GetSelectedMission()).AttackDepth_Submarine = new float?(num * 0.3048f);
						}
						else
						{
							((Patrol)this.GetSelectedMission()).AttackDepth_Submarine = new float?(num);
						}
					}
				}
			}
			else
			{
				this.bool_11 = false;
			}
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x001BC3B0 File Offset: 0x001BA5B0
		private void method_89()
		{
			if (this.bool_3)
			{
				this.bool_3 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Support)
				{
					if (string.IsNullOrEmpty(this.GetTB_SupportTransitDepth_Submarine().Text) || !Versioned.IsNumeric(this.GetTB_SupportTransitDepth_Submarine().Text))
					{
						((SupportMission)this.GetSelectedMission()).TransitDepth_Submarine = null;
						this.GetTB_SupportTransitDepth_Submarine().Text = "未定";
					}
					else
					{
						float num = Conversions.ToSingle(this.GetTB_SupportTransitDepth_Submarine().Text);
						if (num > 0f)
						{
							num *= -1f;
							this.GetTB_SupportTransitDepth_Submarine().Text = Conversions.ToString(num);
						}
						if (num > 0f)
						{
							((SupportMission)this.GetSelectedMission()).TransitDepth_Submarine = null;
							this.GetTB_SupportTransitDepth_Submarine().Text = "未定";
						}
						else if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((SupportMission)this.GetSelectedMission()).TransitDepth_Submarine = new float?(num * 0.3048f);
						}
						else
						{
							((SupportMission)this.GetSelectedMission()).TransitDepth_Submarine = new float?(num);
						}
					}
				}
			}
			else
			{
				this.bool_3 = false;
			}
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x001BC504 File Offset: 0x001BA704
		private void method_90()
		{
			if (this.bool_4)
			{
				this.bool_4 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Support)
				{
					if (string.IsNullOrEmpty(this.vmethod_582().Text) || !Versioned.IsNumeric(this.vmethod_582().Text))
					{
						((SupportMission)this.GetSelectedMission()).StationDepth_Submarine = null;
						this.vmethod_582().Text = "未定";
					}
					else
					{
						float num = Conversions.ToSingle(this.vmethod_582().Text);
						if (num > 0f)
						{
							num *= -1f;
							this.vmethod_582().Text = Conversions.ToString(num);
						}
						if (num > 0f)
						{
							((SupportMission)this.GetSelectedMission()).StationDepth_Submarine = null;
							this.vmethod_582().Text = "未定";
						}
						else if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((SupportMission)this.GetSelectedMission()).StationDepth_Submarine = new float?(num * 0.3048f);
						}
						else
						{
							((SupportMission)this.GetSelectedMission()).StationDepth_Submarine = new float?(num);
						}
					}
				}
			}
			else
			{
				this.bool_4 = false;
			}
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x00022E05 File Offset: 0x00021005
		private void method_91(object sender, EventArgs e)
		{
			this.bool_1 = true;
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x00022E0E File Offset: 0x0002100E
		private void method_92(object sender, EventArgs e)
		{
			this.method_97();
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x001BC658 File Offset: 0x001BA858
		private void method_93()
		{
			if (this.bool_17)
			{
				this.bool_15 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Mining)
				{
					if (string.IsNullOrEmpty(this.vmethod_646().Text) || !Versioned.IsNumeric(this.vmethod_646().Text))
					{
						((MiningMission)this.GetSelectedMission()).TransitDepth_Submarine = null;
						this.vmethod_646().Text = "未定";
					}
					else
					{
						float num = Conversions.ToSingle(this.vmethod_646().Text);
						if (num > 0f)
						{
							num *= -1f;
							this.vmethod_646().Text = Conversions.ToString(num);
						}
						if (num > 0f)
						{
							((MiningMission)this.GetSelectedMission()).TransitDepth_Submarine = null;
							this.vmethod_646().Text = "未定";
						}
						else if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((MiningMission)this.GetSelectedMission()).TransitDepth_Submarine = new float?(num * 0.3048f);
						}
						else
						{
							((MiningMission)this.GetSelectedMission()).TransitDepth_Submarine = new float?(num);
						}
					}
				}
			}
			else
			{
				this.bool_15 = false;
			}
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x001BC7AC File Offset: 0x001BA9AC
		private void method_94()
		{
			if (this.bool_18)
			{
				this.bool_18 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Mining)
				{
					if (string.IsNullOrEmpty(this.vmethod_644().Text) || !Versioned.IsNumeric(this.vmethod_644().Text))
					{
						((MiningMission)this.GetSelectedMission()).StationDepth_Submarine = null;
						this.vmethod_644().Text = "未定";
					}
					else
					{
						float num = Conversions.ToSingle(this.vmethod_644().Text);
						if (num > 0f)
						{
							num *= -1f;
							this.vmethod_644().Text = Conversions.ToString(num);
						}
						if (num > 0f)
						{
							((MiningMission)this.GetSelectedMission()).StationDepth_Submarine = null;
							this.vmethod_644().Text = "未定";
						}
						else if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((MiningMission)this.GetSelectedMission()).StationDepth_Submarine = new float?(num * 0.3048f);
						}
						else
						{
							((MiningMission)this.GetSelectedMission()).StationDepth_Submarine = new float?(num);
						}
					}
				}
			}
			else
			{
				this.bool_18 = false;
			}
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x001BC900 File Offset: 0x001BAB00
		private void method_95()
		{
			if (this.bool_23)
			{
				this.bool_23 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.MineClearing)
				{
					if (string.IsNullOrEmpty(this.vmethod_688().Text) || !Versioned.IsNumeric(this.vmethod_688().Text))
					{
						((MineClearingMission)this.GetSelectedMission()).TransitDepth_Submarine = null;
						this.vmethod_688().Text = "未定";
					}
					else
					{
						float num = Conversions.ToSingle(this.vmethod_688().Text);
						if (num > 0f)
						{
							num *= -1f;
							this.vmethod_688().Text = Conversions.ToString(num);
						}
						if (num > 0f)
						{
							((MineClearingMission)this.GetSelectedMission()).TransitDepth_Submarine = null;
							this.vmethod_688().Text = "未定";
						}
						else if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((MineClearingMission)this.GetSelectedMission()).TransitDepth_Submarine = new float?(num * 0.3048f);
						}
						else
						{
							((MineClearingMission)this.GetSelectedMission()).TransitDepth_Submarine = new float?(num);
						}
					}
				}
			}
			else
			{
				this.bool_23 = false;
			}
		}

		// Token: 0x060048EC RID: 18668 RVA: 0x001BCA54 File Offset: 0x001BAC54
		private void method_96()
		{
			if (this.bool_24)
			{
				this.bool_24 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.MineClearing)
				{
					if (string.IsNullOrEmpty(this.vmethod_686().Text) || !Versioned.IsNumeric(this.vmethod_686().Text))
					{
						((MineClearingMission)this.GetSelectedMission()).StationDepth_Submarine = null;
						this.vmethod_686().Text = "未定";
					}
					else
					{
						float num = Conversions.ToSingle(this.vmethod_686().Text);
						if (num > 0f)
						{
							num *= -1f;
							this.vmethod_686().Text = Conversions.ToString(num);
						}
						if (num > 0f)
						{
							((MineClearingMission)this.GetSelectedMission()).StationDepth_Submarine = null;
							this.vmethod_686().Text = "未定";
						}
						else if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((MineClearingMission)this.GetSelectedMission()).StationDepth_Submarine = new float?(num * 0.3048f);
						}
						else
						{
							((MineClearingMission)this.GetSelectedMission()).StationDepth_Submarine = new float?(num);
						}
					}
				}
			}
			else
			{
				this.bool_24 = false;
			}
		}

		// Token: 0x060048ED RID: 18669 RVA: 0x001BCBA8 File Offset: 0x001BADA8
		private void method_97()
		{
			if (this.bool_1)
			{
				this.bool_1 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Support)
				{
					if (string.IsNullOrEmpty(this.vmethod_156().Text) || !Versioned.IsNumeric(this.vmethod_156().Text))
					{
						((SupportMission)this.GetSelectedMission()).TransitAltitude_Aircraft = null;
						this.vmethod_156().Text = "未定";
						this.vmethod_504().Enabled = false;
					}
					else if (Conversions.ToInteger(this.vmethod_156().Text) > 0)
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((SupportMission)this.GetSelectedMission()).TransitAltitude_Aircraft = new float?((float)(Conversions.ToDouble(this.vmethod_156().Text) * 0.30480000376701355));
						}
						else
						{
							((SupportMission)this.GetSelectedMission()).TransitAltitude_Aircraft = new float?(Conversions.ToSingle(this.vmethod_156().Text));
						}
						this.vmethod_504().Enabled = true;
					}
					else
					{
						((SupportMission)this.GetSelectedMission()).TransitAltitude_Aircraft = null;
						this.vmethod_156().Text = "未定";
						this.vmethod_504().Enabled = false;
					}
				}
			}
			else
			{
				this.bool_1 = false;
			}
		}

		// Token: 0x060048EE RID: 18670 RVA: 0x00022E16 File Offset: 0x00021016
		private void method_98(object sender, EventArgs e)
		{
			this.bool_2 = true;
		}

		// Token: 0x060048EF RID: 18671 RVA: 0x00022E1F File Offset: 0x0002101F
		private void method_99(object sender, EventArgs e)
		{
			this.method_100();
		}

		// Token: 0x060048F0 RID: 18672 RVA: 0x001BCD18 File Offset: 0x001BAF18
		private void method_100()
		{
			if (this.bool_2)
			{
				this.bool_2 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Support)
				{
					if (string.IsNullOrEmpty(this.vmethod_154().Text) || !Versioned.IsNumeric(this.vmethod_154().Text))
					{
						((SupportMission)this.GetSelectedMission()).StationAltitude_Aircraft = null;
						this.vmethod_154().Text = "未定";
						this.vmethod_502().Enabled = false;
					}
					else if (Conversions.ToInteger(this.vmethod_154().Text) > 0)
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((SupportMission)this.GetSelectedMission()).StationAltitude_Aircraft = new float?((float)(Conversions.ToDouble(this.vmethod_154().Text) * 0.30480000376701355));
						}
						else
						{
							((SupportMission)this.GetSelectedMission()).StationAltitude_Aircraft = new float?(Conversions.ToSingle(this.vmethod_154().Text));
						}
						this.vmethod_502().Enabled = true;
					}
					else
					{
						((SupportMission)this.GetSelectedMission()).StationAltitude_Aircraft = null;
						this.vmethod_154().Text = "未定";
						this.vmethod_502().Enabled = false;
					}
				}
			}
			else
			{
				this.bool_2 = false;
			}
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x00022E27 File Offset: 0x00021027
		private void method_101(object sender, EventArgs e)
		{
			this.bool_14 = true;
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x00022E30 File Offset: 0x00021030
		private void method_102(object sender, EventArgs e)
		{
			this.method_103();
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x001BCE88 File Offset: 0x001BB088
		private void method_103()
		{
			if (this.bool_14)
			{
				this.bool_14 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Ferry)
				{
					if (string.IsNullOrEmpty(this.vmethod_302().Text) || !Versioned.IsNumeric(this.vmethod_302().Text))
					{
						((FerryMission)this.GetSelectedMission()).FerryAltitude_Aircraft = null;
						this.vmethod_302().Text = "未定";
						this.vmethod_506().Enabled = false;
					}
					else if (Conversions.ToInteger(this.vmethod_302().Text) > 0)
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((FerryMission)this.GetSelectedMission()).FerryAltitude_Aircraft = new float?((float)(Conversions.ToDouble(this.vmethod_302().Text) * 0.30480000376701355));
						}
						else
						{
							((FerryMission)this.GetSelectedMission()).FerryAltitude_Aircraft = new float?(Conversions.ToSingle(this.vmethod_302().Text));
						}
						this.vmethod_506().Enabled = true;
					}
					else
					{
						((FerryMission)this.GetSelectedMission()).FerryAltitude_Aircraft = null;
						this.vmethod_302().Text = "未定";
						this.vmethod_506().Enabled = false;
					}
				}
			}
			else
			{
				this.bool_14 = false;
			}
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x00022E38 File Offset: 0x00021038
		private void method_104(object sender, EventArgs e)
		{
			this.bool_15 = true;
		}

		// Token: 0x060048F5 RID: 18677 RVA: 0x00022E41 File Offset: 0x00021041
		private void method_105(object sender, EventArgs e)
		{
			this.method_106();
		}

		// Token: 0x060048F6 RID: 18678 RVA: 0x001BCFF8 File Offset: 0x001BB1F8
		private void method_106()
		{
			if (this.bool_15)
			{
				this.bool_15 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Mining)
				{
					if (string.IsNullOrEmpty(this.vmethod_322().Text) || !Versioned.IsNumeric(this.vmethod_322().Text))
					{
						((MiningMission)this.GetSelectedMission()).TransitAltitude_Aircraft = null;
						this.vmethod_322().Text = "未定";
						this.vmethod_510().Enabled = false;
					}
					else if (Conversions.ToInteger(this.vmethod_322().Text) > 0)
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((MiningMission)this.GetSelectedMission()).TransitAltitude_Aircraft = new float?((float)(Conversions.ToDouble(this.vmethod_322().Text) * 0.30480000376701355));
						}
						else
						{
							((MiningMission)this.GetSelectedMission()).TransitAltitude_Aircraft = new float?(Conversions.ToSingle(this.vmethod_322().Text));
						}
						this.vmethod_510().Enabled = false;
					}
					else
					{
						((MiningMission)this.GetSelectedMission()).TransitAltitude_Aircraft = null;
						this.vmethod_322().Text = "未定";
						this.vmethod_510().Enabled = false;
					}
				}
			}
			else
			{
				this.bool_15 = false;
			}
		}

		// Token: 0x060048F7 RID: 18679 RVA: 0x00022E49 File Offset: 0x00021049
		private void method_107(object sender, EventArgs e)
		{
			this.bool_16 = true;
		}

		// Token: 0x060048F8 RID: 18680 RVA: 0x00022E52 File Offset: 0x00021052
		private void method_108(object sender, EventArgs e)
		{
			this.method_109();
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x001BD168 File Offset: 0x001BB368
		private void method_109()
		{
			if (this.bool_16)
			{
				this.bool_16 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Mining)
				{
					if (string.IsNullOrEmpty(this.vmethod_326().Text) || !Versioned.IsNumeric(this.vmethod_326().Text))
					{
						((MiningMission)this.GetSelectedMission()).StationAltitude_Aircraft = null;
						this.vmethod_326().Text = "未定";
						this.vmethod_508().Enabled = false;
					}
					else if (Conversions.ToInteger(this.vmethod_326().Text) > 0)
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((MiningMission)this.GetSelectedMission()).StationAltitude_Aircraft = new float?((float)(Conversions.ToDouble(this.vmethod_326().Text) * 0.30480000376701355));
						}
						else
						{
							((MiningMission)this.GetSelectedMission()).StationAltitude_Aircraft = new float?(Conversions.ToSingle(this.vmethod_326().Text));
						}
						this.vmethod_508().Enabled = true;
					}
					else
					{
						((MiningMission)this.GetSelectedMission()).StationAltitude_Aircraft = null;
						this.vmethod_326().Text = "未定";
						this.vmethod_508().Enabled = false;
					}
				}
			}
			else
			{
				this.bool_16 = false;
			}
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x00022E5A File Offset: 0x0002105A
		private void method_110(object sender, EventArgs e)
		{
			this.bool_21 = true;
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x00022E63 File Offset: 0x00021063
		private void method_111(object sender, EventArgs e)
		{
			this.method_112();
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x001BD2D8 File Offset: 0x001BB4D8
		private void method_112()
		{
			if (this.bool_21)
			{
				this.bool_21 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.MineClearing)
				{
					if (string.IsNullOrEmpty(this.vmethod_344().Text) || !Versioned.IsNumeric(this.vmethod_344().Text))
					{
						((MineClearingMission)this.GetSelectedMission()).TransitAltitude_Aircraft = null;
						this.vmethod_344().Text = "未定";
						this.vmethod_514().Enabled = false;
					}
					else if (Conversions.ToInteger(this.vmethod_344().Text) > 0)
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((MineClearingMission)this.GetSelectedMission()).TransitAltitude_Aircraft = new float?((float)(Conversions.ToDouble(this.vmethod_344().Text) * 0.30480000376701355));
						}
						else
						{
							((MineClearingMission)this.GetSelectedMission()).TransitAltitude_Aircraft = new float?(Conversions.ToSingle(this.vmethod_344().Text));
						}
						this.vmethod_514().Enabled = true;
					}
					else
					{
						((MineClearingMission)this.GetSelectedMission()).TransitAltitude_Aircraft = null;
						this.vmethod_344().Text = "未定";
						this.vmethod_514().Enabled = false;
					}
				}
			}
			else
			{
				this.bool_21 = false;
			}
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x00022E6B File Offset: 0x0002106B
		private void method_113(object sender, EventArgs e)
		{
			this.bool_22 = true;
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x00022E74 File Offset: 0x00021074
		private void method_114(object sender, EventArgs e)
		{
			this.method_115();
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x001BD448 File Offset: 0x001BB648
		private void method_115()
		{
			if (this.bool_22)
			{
				this.bool_22 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.MineClearing)
				{
					if (string.IsNullOrEmpty(this.vmethod_348().Text) || !Versioned.IsNumeric(this.vmethod_348().Text))
					{
						((MineClearingMission)this.GetSelectedMission()).StationAltitude_Aircraft = null;
						this.vmethod_348().Text = "未定";
						this.vmethod_512().Enabled = false;
					}
					else if (Conversions.ToInteger(this.vmethod_348().Text) > 0)
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((MineClearingMission)this.GetSelectedMission()).StationAltitude_Aircraft = new float?((float)(Conversions.ToDouble(this.vmethod_348().Text) * 0.30480000376701355));
						}
						else
						{
							((MineClearingMission)this.GetSelectedMission()).StationAltitude_Aircraft = new float?(Conversions.ToSingle(this.vmethod_348().Text));
						}
						this.vmethod_512().Enabled = true;
					}
					else
					{
						((MineClearingMission)this.GetSelectedMission()).StationAltitude_Aircraft = null;
						this.vmethod_348().Text = "未定";
						this.vmethod_512().Enabled = false;
					}
				}
			}
			else
			{
				this.bool_22 = false;
			}
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x00022E7C File Offset: 0x0002107C
		private void method_116(object sender, EventArgs e)
		{
			this.bool_19 = true;
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x00022E85 File Offset: 0x00021085
		private void method_117(object sender, EventArgs e)
		{
			this.method_118();
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x001BD5B8 File Offset: 0x001BB7B8
		private void method_118()
		{
			if (this.bool_19)
			{
				this.bool_19 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Escort)
				{
					if (string.IsNullOrEmpty(this.vmethod_366().Text) || !Versioned.IsNumeric(this.vmethod_366().Text))
					{
						((TankerMission)this.GetSelectedMission()).TransitAltitude_Aircraft = null;
						this.vmethod_366().Text = "未定";
						this.vmethod_620().Enabled = false;
					}
					else if (Conversions.ToInteger(this.vmethod_366().Text) > 0)
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((TankerMission)this.GetSelectedMission()).TransitAltitude_Aircraft = new float?((float)(Conversions.ToDouble(this.vmethod_366().Text) * 0.30480000376701355));
						}
						else
						{
							((TankerMission)this.GetSelectedMission()).TransitAltitude_Aircraft = new float?(Conversions.ToSingle(this.vmethod_366().Text));
						}
						this.vmethod_620().Enabled = true;
					}
					else
					{
						((TankerMission)this.GetSelectedMission()).TransitAltitude_Aircraft = null;
						this.vmethod_366().Text = "未定";
						this.vmethod_620().Enabled = false;
					}
				}
			}
			else
			{
				this.bool_19 = false;
			}
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x00022E8D File Offset: 0x0002108D
		private void method_119(object sender, EventArgs e)
		{
			this.bool_20 = true;
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x00022E96 File Offset: 0x00021096
		private void method_120(object sender, EventArgs e)
		{
			this.method_121();
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x001BD728 File Offset: 0x001BB928
		private void method_121()
		{
			if (this.bool_20)
			{
				this.bool_20 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Escort)
				{
					if (string.IsNullOrEmpty(this.vmethod_370().Text) || !Versioned.IsNumeric(this.vmethod_370().Text))
					{
						((TankerMission)this.GetSelectedMission()).StationAltitude_Aircraft = null;
						this.vmethod_370().Text = "未定";
						this.vmethod_618().Enabled = false;
					}
					else if (Conversions.ToInteger(this.vmethod_370().Text) > 0)
					{
						if (SimConfiguration.gameOptions.UseImperialUnit())
						{
							((TankerMission)this.GetSelectedMission()).StationAltitude_Aircraft = new float?((float)(Conversions.ToDouble(this.vmethod_370().Text) * 0.30480000376701355));
						}
						else
						{
							((TankerMission)this.GetSelectedMission()).StationAltitude_Aircraft = new float?(Conversions.ToSingle(this.vmethod_370().Text));
						}
						this.vmethod_618().Enabled = true;
					}
					else
					{
						((TankerMission)this.GetSelectedMission()).StationAltitude_Aircraft = null;
						this.vmethod_370().Text = "未定";
						this.vmethod_618().Enabled = false;
					}
				}
			}
			else
			{
				this.bool_20 = false;
			}
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x001BD898 File Offset: 0x001BBA98
		private void method_122(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				Patrol patrol = (Patrol)this.GetSelectedMission();
				ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.GetCombo_PatrolTransitThrottle_Aircraft().SelectedIndex + 1);
				if (throttle > ActiveUnit.Throttle.Flank)
				{
					patrol.TransitThrottle_Aircraft = null;
				}
				else
				{
					patrol.TransitThrottle_Aircraft = new ActiveUnit.Throttle?(throttle);
				}
			}
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x001BD8F0 File Offset: 0x001BBAF0
		private void method_123(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				Patrol patrol = (Patrol)this.GetSelectedMission();
				ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.GetCombo_PatrolStationThrottle_Aircraft().SelectedIndex + 1);
				if (throttle > ActiveUnit.Throttle.Flank)
				{
					patrol.StationThrottle_Aircraft = null;
				}
				else
				{
					patrol.StationThrottle_Aircraft = new ActiveUnit.Throttle?(throttle);
				}
			}
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x001BD948 File Offset: 0x001BBB48
		private void method_124(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				SupportMission supportMission = (SupportMission)this.GetSelectedMission();
				ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.GetCombo_SupportTransitThrottle_Aircraft().SelectedIndex + 1);
				if (throttle > ActiveUnit.Throttle.Flank)
				{
					supportMission.TransitThrottle_Aircraft = null;
				}
				else
				{
					supportMission.TransitThrottle_Aircraft = new ActiveUnit.Throttle?(throttle);
				}
			}
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x001BD9A0 File Offset: 0x001BBBA0
		private void method_125(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				SupportMission supportMission = (SupportMission)this.GetSelectedMission();
				ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.GetCombo_SupportStationThrottle_Aircraft().SelectedIndex + 1);
				if (throttle > ActiveUnit.Throttle.Flank)
				{
					supportMission.StationThrottle_Aircraft = null;
				}
				else
				{
					supportMission.StationThrottle_Aircraft = new ActiveUnit.Throttle?(throttle);
				}
			}
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x001BD9F8 File Offset: 0x001BBBF8
		private void method_126(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				FerryMission ferryMission = (FerryMission)this.GetSelectedMission();
				ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.GetCombo_FerryThrottle_Aircraft().SelectedIndex + 1);
				if (throttle > ActiveUnit.Throttle.Flank)
				{
					ferryMission.FerryThrottle_Aircraft = null;
				}
				else
				{
					ferryMission.FerryThrottle_Aircraft = new ActiveUnit.Throttle?(throttle);
				}
			}
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x001BDA50 File Offset: 0x001BBC50
		private void method_127(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				MiningMission miningMission = (MiningMission)this.GetSelectedMission();
				ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.GetCombo_MiningTransitThrottle_Aircraft().SelectedIndex + 1);
				if (throttle > ActiveUnit.Throttle.Flank)
				{
					miningMission.TransitThrottle_Aircraft = null;
				}
				else
				{
					miningMission.TransitThrottle_Aircraft = new ActiveUnit.Throttle?(throttle);
				}
			}
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x001BDAA8 File Offset: 0x001BBCA8
		private void method_128(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				MiningMission miningMission = (MiningMission)this.GetSelectedMission();
				ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.GetCombo_MiningStationThrottle_Aircraft().SelectedIndex + 1);
				if (throttle > ActiveUnit.Throttle.Flank)
				{
					miningMission.StationThrottle_Aircraft = null;
				}
				else
				{
					miningMission.StationThrottle_Aircraft = new ActiveUnit.Throttle?(throttle);
				}
			}
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x001BDB00 File Offset: 0x001BBD00
		private void method_129(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				MineClearingMission mineClearingMission = (MineClearingMission)this.GetSelectedMission();
				ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.GetCombo_MineClearingTransitThrottle_Aircraft().SelectedIndex + 1);
				if (throttle > ActiveUnit.Throttle.Flank)
				{
					mineClearingMission.TransitThrottle_Aircraft = null;
				}
				else
				{
					mineClearingMission.TransitThrottle_Aircraft = new ActiveUnit.Throttle?(throttle);
				}
			}
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x001BDB58 File Offset: 0x001BBD58
		private void method_130(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				MineClearingMission mineClearingMission = (MineClearingMission)this.GetSelectedMission();
				ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.GetCombo_MineClearingStationThrottle_Aircraft().SelectedIndex + 1);
				if (throttle > ActiveUnit.Throttle.Flank)
				{
					mineClearingMission.StationThrottle_Aircraft = null;
				}
				else
				{
					mineClearingMission.StationThrottle_Aircraft = new ActiveUnit.Throttle?(throttle);
				}
			}
		}

		// Token: 0x0600490F RID: 18703 RVA: 0x001BDBB0 File Offset: 0x001BBDB0
		private void method_131(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				if (this.GetSelectedMission().MissionClass == Mission._MissionClass.Escort)
				{
					if (!Information.IsNothing(this.GetSelectedMission()))
					{
						TankerMission tankerMission = (TankerMission)this.GetSelectedMission();
						ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.vmethod_358().SelectedIndex + 1);
						if (throttle > ActiveUnit.Throttle.Flank)
						{
							tankerMission.TransitThrottle_Aircraft = null;
						}
						else
						{
							tankerMission.TransitThrottle_Aircraft = new ActiveUnit.Throttle?(throttle);
						}
					}
				}
				else if (this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike && !Information.IsNothing(this.GetSelectedMission()))
				{
					Strike strike = (Strike)this.GetSelectedMission();
					ActiveUnit.Throttle throttle2 = (ActiveUnit.Throttle)(this.vmethod_358().SelectedIndex + 1);
					if (throttle2 > ActiveUnit.Throttle.Flank)
					{
						strike.Escort_TransitThrottle = null;
					}
					else
					{
						strike.Escort_TransitThrottle = new ActiveUnit.Throttle?(throttle2);
					}
				}
			}
		}

		// Token: 0x06004910 RID: 18704 RVA: 0x001BDC8C File Offset: 0x001BBE8C
		private void method_132(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				if (this.GetSelectedMission().MissionClass == Mission._MissionClass.Escort)
				{
					if (!Information.IsNothing(this.GetSelectedMission()))
					{
						TankerMission tankerMission = (TankerMission)this.GetSelectedMission();
						ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.vmethod_354().SelectedIndex + 1);
						if (throttle > ActiveUnit.Throttle.Flank)
						{
							tankerMission.StationThrottle_Aircraft = null;
						}
						else
						{
							tankerMission.StationThrottle_Aircraft = new ActiveUnit.Throttle?(throttle);
						}
					}
				}
				else if (this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike && !Information.IsNothing(this.GetSelectedMission()))
				{
					Strike strike = (Strike)this.GetSelectedMission();
					ActiveUnit.Throttle throttle2 = (ActiveUnit.Throttle)(this.vmethod_354().SelectedIndex + 1);
					if (throttle2 > ActiveUnit.Throttle.Flank)
					{
						strike.Escort_StationThrottle = null;
					}
					else
					{
						strike.Escort_StationThrottle = new ActiveUnit.Throttle?(throttle2);
					}
				}
			}
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x00022E9E File Offset: 0x0002109E
		private void method_133(object sender, EventArgs e)
		{
			this.bool_27 = true;
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00022EA7 File Offset: 0x000210A7
		private void method_134(object sender, EventArgs e)
		{
			this.method_135();
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x001BDD68 File Offset: 0x001BBF68
		private void method_135()
		{
			if (this.bool_27)
			{
				this.bool_27 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike && !string.IsNullOrEmpty(this.vmethod_374().Text))
				{
					if (!Versioned.IsNumeric(this.vmethod_374().Text))
					{
						((Strike)this.GetSelectedMission()).Escort_ResponseRadius = 0;
					}
					else if (Conversions.ToInteger(this.vmethod_374().Text) >= 0)
					{
						((Strike)this.GetSelectedMission()).Escort_ResponseRadius = Conversions.ToInteger(this.vmethod_374().Text);
					}
					else
					{
						((Strike)this.GetSelectedMission()).Escort_ResponseRadius = 0;
					}
				}
			}
			else
			{
				this.bool_27 = false;
			}
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x001BDE30 File Offset: 0x001BC030
		private void method_136(object sender, EventArgs e)
		{
			int selectedIndex = this.GetComboBox_MinNumberOfStrikeAircraft().SelectedIndex;
			Strike strike = (Strike)this.GetSelectedMission();
			int minAircraftReq_Strikers = (int)strike.MinAircraftReq_Strikers;
			this.method_65(selectedIndex, ref minAircraftReq_Strikers, false);
			strike.MinAircraftReq_Strikers = (Mission._FlightQty)minAircraftReq_Strikers;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x001BDE7C File Offset: 0x001BC07C
		private void method_137(object sender, EventArgs e)
		{
			int selectedIndex = this.vmethod_384().SelectedIndex;
			Patrol patrol = (Patrol)this.GetSelectedMission();
			int minAircraftReq = (int)patrol.MinAircraftReq;
			this.method_65(selectedIndex, ref minAircraftReq, false);
			patrol.MinAircraftReq = (Mission._FlightQty)minAircraftReq;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x001BDEC8 File Offset: 0x001BC0C8
		private void method_138(object sender, EventArgs e)
		{
			int selectedIndex = this.GetComboBox_SupportAircraftRequired().SelectedIndex;
			SupportMission supportMission = (SupportMission)this.GetSelectedMission();
			int minAircraftReq = (int)supportMission.MinAircraftReq;
			this.method_65(selectedIndex, ref minAircraftReq, false);
			supportMission.MinAircraftReq = (Mission._FlightQty)minAircraftReq;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x001BDF14 File Offset: 0x001BC114
		private void method_139(object sender, EventArgs e)
		{
			int selectedIndex = this.vmethod_392().SelectedIndex;
			FerryMission ferryMission = (FerryMission)this.GetSelectedMission();
			int minAircraftReq = (int)ferryMission.MinAircraftReq;
			this.method_65(selectedIndex, ref minAircraftReq, false);
			ferryMission.MinAircraftReq = (Mission._FlightQty)minAircraftReq;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x001BDF60 File Offset: 0x001BC160
		private void method_140(object sender, EventArgs e)
		{
			int selectedIndex = this.vmethod_396().SelectedIndex;
			MiningMission miningMission = (MiningMission)this.GetSelectedMission();
			int minAircraftReq = (int)miningMission.MinAircraftReq;
			this.method_65(selectedIndex, ref minAircraftReq, false);
			miningMission.MinAircraftReq = (Mission._FlightQty)minAircraftReq;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x001BDFAC File Offset: 0x001BC1AC
		private void method_141(object sender, EventArgs e)
		{
			int selectedIndex = this.vmethod_400().SelectedIndex;
			MineClearingMission mineClearingMission = (MineClearingMission)this.GetSelectedMission();
			int minAircraftReq = (int)mineClearingMission.MinAircraftReq;
			this.method_65(selectedIndex, ref minAircraftReq, false);
			mineClearingMission.MinAircraftReq = (Mission._FlightQty)minAircraftReq;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x001BDFF8 File Offset: 0x001BC1F8
		private void method_142(object sender, EventArgs e)
		{
			int selectedIndex = this.GetComboBox_MaxNumberOfStrikeAircraft().SelectedIndex;
			Strike strike = (Strike)this.GetSelectedMission();
			int maxAircraftToFly_Strikers = (int)strike.MaxAircraftToFly_Strikers;
			this.method_68(selectedIndex, ref maxAircraftToFly_Strikers, false);
			strike.MaxAircraftToFly_Strikers = (Mission._FlightQty)maxAircraftToFly_Strikers;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x001BE044 File Offset: 0x001BC244
		private void method_143(object sender, EventArgs e)
		{
			int selectedIndex = this.vmethod_412().SelectedIndex;
			Strike strike = (Strike)this.GetSelectedMission();
			int minAircraftReq_Escorts_Shooter = (int)strike.MinAircraftReq_Escorts_Shooter;
			this.method_65(selectedIndex, ref minAircraftReq_Escorts_Shooter, false);
			strike.MinAircraftReq_Escorts_Shooter = (Mission._FlightQty)minAircraftReq_Escorts_Shooter;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x001BE090 File Offset: 0x001BC290
		private void method_144(object sender, EventArgs e)
		{
			int selectedIndex = this.vmethod_408().SelectedIndex;
			Strike strike = (Strike)this.GetSelectedMission();
			int maxAircraftToFly_Escort_Shooter = (int)strike.MaxAircraftToFly_Escort_Shooter;
			this.method_68(selectedIndex, ref maxAircraftToFly_Escort_Shooter, false);
			strike.MaxAircraftToFly_Escort_Shooter = (Mission._FlightQty)maxAircraftToFly_Escort_Shooter;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600491D RID: 18717 RVA: 0x00022EAF File Offset: 0x000210AF
		private void method_145(object sender, EventArgs e)
		{
			((Strike)this.GetSelectedMission()).Bingo = (Mission.Enum60)this.GetComboBox_MissionFuel().SelectedIndex;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x00022ED9 File Offset: 0x000210D9
		private void method_146(object sender, EventArgs e)
		{
			this.bool_26 = true;
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x00022EE2 File Offset: 0x000210E2
		private void method_147(object sender, EventArgs e)
		{
			this.method_148();
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004920 RID: 18720 RVA: 0x001BE0DC File Offset: 0x001BC2DC
		private void method_148()
		{
			if (this.bool_26)
			{
				this.bool_26 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike && !string.IsNullOrEmpty(this.GetTB_MinResponseRadius().Text))
				{
					if (!Versioned.IsNumeric(this.GetTB_MinResponseRadius().Text))
					{
						((Strike)this.GetSelectedMission()).MinResponseRadius = 0;
					}
					else if (Conversions.ToInteger(this.GetTB_MinResponseRadius().Text) >= 0)
					{
						((Strike)this.GetSelectedMission()).MinResponseRadius = Conversions.ToInteger(this.GetTB_MinResponseRadius().Text);
					}
					else
					{
						((Strike)this.GetSelectedMission()).MinResponseRadius = 0;
					}
				}
			}
			else
			{
				this.bool_26 = false;
			}
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x00022EF6 File Offset: 0x000210F6
		private void method_149(object sender, EventArgs e)
		{
			this.bool_25 = true;
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x00022EFF File Offset: 0x000210FF
		private void method_150(object sender, EventArgs e)
		{
			this.method_151();
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x001BE1A4 File Offset: 0x001BC3A4
		private void method_151()
		{
			if (this.bool_25)
			{
				this.bool_25 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike && !string.IsNullOrEmpty(this.GetTB_MaxResponseRadius().Text))
				{
					if (!Versioned.IsNumeric(this.GetTB_MaxResponseRadius().Text))
					{
						((Strike)this.GetSelectedMission()).MaxResponseRadius = 0;
					}
					else if (Conversions.ToInteger(this.GetTB_MaxResponseRadius().Text) >= 0)
					{
						((Strike)this.GetSelectedMission()).MaxResponseRadius = Conversions.ToInteger(this.GetTB_MaxResponseRadius().Text);
					}
					else
					{
						((Strike)this.GetSelectedMission()).MaxResponseRadius = 0;
					}
				}
			}
			else
			{
				this.bool_25 = false;
			}
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x00022F13 File Offset: 0x00021113
		private void method_152(object sender, EventArgs e)
		{
			((Strike)this.GetSelectedMission()).RadarBehaviour = this.GetCB_RadarUsage().SelectedIndex + Mission._RadarBehaviour.Land;
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x001BE26C File Offset: 0x001BC46C
		private void method_153(object sender, EventArgs e)
		{
			if (this.GetCB_TankerUsage().SelectedIndex == 0)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_2));
			}
			else if (this.GetCB_TankerUsage().SelectedIndex == 1)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
			}
			else if (this.GetCB_TankerUsage().SelectedIndex == 2)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_1));
			}
			else
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, null);
			}
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x001BE348 File Offset: 0x001BC548
		private void method_154(ref System.Windows.Forms.ComboBox comboBox_117, ref DataTable dataTable_0, int int_0)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				"整个飞行计划遵循任务电磁管控规则"
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				"从初始点到Winchester武器状态点打开雷达"
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				"从进入攻击航线段到Winchester武器状态点打开雷达"
			});
			System.Windows.Forms.ComboBox comboBox = comboBox_117;
			comboBox.DataSource = dataTable_0;
			comboBox.DisplayMember = "Description";
			comboBox.ValueMember = "ID";
			comboBox.SelectedIndex = int_0 - 1;
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x001BE450 File Offset: 0x001BC650
		private void CB_OneTimeOnly_Click(object sender, EventArgs e)
		{
			Strike strike = (Strike)this.GetSelectedMission();
			strike.OneTimeOnly = this.GetCB_OneTimeOnly().Checked;
			strike.OneTimeOnlyFlown = false;
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x00022F32 File Offset: 0x00021132
		private void CB_PreplannedOnly_Click(object sender, EventArgs e)
		{
			((Strike)this.GetSelectedMission()).PrePlannedOnly = this.GetCB_PreplannedOnly().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x001BE484 File Offset: 0x001BC684
		private void method_157(object sender, EventArgs e)
		{
			if (this.SelectedMission.MissionClass == Mission._MissionClass.Strike)
			{
				System.Windows.Forms.ComboBox comboBox;
				int selectedIndex = (comboBox = this.vmethod_450()).SelectedIndex;
				this.method_71(ref selectedIndex, ref ((Strike)this.GetSelectedMission()).Escort_FlightSize_NonShooter);
				comboBox.SelectedIndex = selectedIndex;
			}
			if (((Strike)this.GetSelectedMission()).Escort_FlightSize_Shooter == Mission._FlightSize.None)
			{
				this.vmethod_452().Enabled = false;
				this.vmethod_444().Enabled = false;
			}
			else
			{
				this.vmethod_452().Enabled = true;
				this.vmethod_444().Enabled = true;
			}
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x001BE528 File Offset: 0x001BC728
		private void method_158(object sender, EventArgs e)
		{
			int selectedIndex = this.vmethod_452().SelectedIndex;
			Strike strike = (Strike)this.GetSelectedMission();
			int minAircraftReq_Escorts_NonShooter = (int)strike.MinAircraftReq_Escorts_NonShooter;
			this.method_65(selectedIndex, ref minAircraftReq_Escorts_NonShooter, true);
			strike.MinAircraftReq_Escorts_NonShooter = (Mission._FlightQty)minAircraftReq_Escorts_NonShooter;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x001BE574 File Offset: 0x001BC774
		private void method_159(object sender, EventArgs e)
		{
			int selectedIndex = this.vmethod_444().SelectedIndex;
			Strike strike = (Strike)this.GetSelectedMission();
			int maxAircraftToFly_Escort_NonShooter = (int)strike.MaxAircraftToFly_Escort_NonShooter;
			this.method_68(selectedIndex, ref maxAircraftToFly_Escort_NonShooter, true);
			strike.MaxAircraftToFly_Escort_NonShooter = (Mission._FlightQty)maxAircraftToFly_Escort_NonShooter;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x00022F5B File Offset: 0x0002115B
		private void method_160(object sender, EventArgs e)
		{
			this.GetSelectedMission().UseFlightSizeHardLimit = this.GetCB_UseFlightSizeHardLimit_Strike().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x00022F7F File Offset: 0x0002117F
		private void method_161(object sender, EventArgs e)
		{
			if (this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike)
			{
				((Strike)this.GetSelectedMission()).UseFlightSizeHardLimit_Escort = this.vmethod_458().Checked;
			}
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x00022FBB File Offset: 0x000211BB
		private void method_162(object sender, EventArgs e)
		{
			this.GetSelectedMission().UseFlightSizeHardLimit = this.vmethod_460().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x00022FDF File Offset: 0x000211DF
		private void method_163(object sender, EventArgs e)
		{
			this.GetSelectedMission().UseFlightSizeHardLimit = this.GetCB_UseFlightSizeHardLimit_Support().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x00023003 File Offset: 0x00021203
		private void method_164(object sender, EventArgs e)
		{
			this.GetSelectedMission().UseFlightSizeHardLimit = this.vmethod_464().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x00023027 File Offset: 0x00021227
		private void method_165(object sender, EventArgs e)
		{
			this.GetSelectedMission().UseFlightSizeHardLimit = this.vmethod_466().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x0002304B File Offset: 0x0002124B
		private void method_166(object sender, EventArgs e)
		{
			this.GetSelectedMission().UseFlightSizeHardLimit = this.vmethod_468().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x0002306F File Offset: 0x0002126F
		private void method_167(object sender, EventArgs e)
		{
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x0002306F File Offset: 0x0002126F
		private void method_168(object sender, EventArgs e)
		{
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x001BE5C0 File Offset: 0x001BC7C0
		private void method_169(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				Patrol patrol = (Patrol)this.GetSelectedMission();
				ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.GetCombo_PatrolAttackThrottle_Aircraft().SelectedIndex + 1);
				if (throttle > ActiveUnit.Throttle.Flank)
				{
					patrol.AttackThrottle_Aircraft = null;
				}
				else
				{
					patrol.AttackThrottle_Aircraft = new ActiveUnit.Throttle?(throttle);
				}
			}
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x0002307D File Offset: 0x0002127D
		private void method_170(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((Patrol)this.GetSelectedMission()).TransitThrottle_Submarine = (ActiveUnit.Throttle)(this.GetCombo_PatrolTransitThrottle_Submarine().SelectedIndex + 1);
			}
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x000230AA File Offset: 0x000212AA
		private void method_171(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((Patrol)this.GetSelectedMission()).StationThrottle_Submarine = (ActiveUnit.Throttle)(this.GetCombo_PatrolStationThrottle_Submarine().SelectedIndex + 1);
			}
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x001BE618 File Offset: 0x001BC818
		private void method_172(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				Patrol patrol = (Patrol)this.GetSelectedMission();
				ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.GetCombo_PatrolAttackThrottle_Submarine().SelectedIndex + 1);
				if (throttle > ActiveUnit.Throttle.Flank)
				{
					patrol.AttackThrottle_Submarine = null;
				}
				else
				{
					patrol.AttackThrottle_Submarine = new ActiveUnit.Throttle?(throttle);
				}
			}
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x000230D7 File Offset: 0x000212D7
		private void method_173(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((Patrol)this.GetSelectedMission()).TransitThrottle_Ship = (ActiveUnit.Throttle)(this.GetCombo_PatrolTransitThrottle_Ship().SelectedIndex + 1);
			}
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x00023104 File Offset: 0x00021304
		private void method_174(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((Patrol)this.GetSelectedMission()).StationThrottle_Ship = (ActiveUnit.Throttle)(this.GetCombo_PatrolStationThrottle_Ship().SelectedIndex + 1);
			}
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x001BE670 File Offset: 0x001BC870
		private void method_175(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				Patrol patrol = (Patrol)this.GetSelectedMission();
				ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)(this.GetCombo_PatrolAttackThrottle_Ship().SelectedIndex + 1);
				if (throttle > ActiveUnit.Throttle.Flank)
				{
					patrol.AttackThrottle_Ship = null;
				}
				else
				{
					patrol.AttackThrottle_Ship = new ActiveUnit.Throttle?(throttle);
				}
			}
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_176(object sender, EventArgs e)
		{
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_177(object sender, EventArgs e)
		{
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_178(object sender, EventArgs e)
		{
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x00023131 File Offset: 0x00021331
		private void method_179(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((SupportMission)this.GetSelectedMission()).TransitThrottle_Ship = (ActiveUnit.Throttle)(this.GetCombo_SupportTransitThrottle_Ship().SelectedIndex + 1);
			}
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x0002315E File Offset: 0x0002135E
		private void method_180(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((SupportMission)this.GetSelectedMission()).StationThrottle_Ship = (ActiveUnit.Throttle)(this.GetCombo_SupportStationThrottle_Ship().SelectedIndex + 1);
			}
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x0002318B File Offset: 0x0002138B
		private void method_181(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((SupportMission)this.GetSelectedMission()).TransitThrottle_Submarine = (ActiveUnit.Throttle)(this.GetCombo_SupportTransitThrottle_Submarine().SelectedIndex + 1);
			}
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x000231B8 File Offset: 0x000213B8
		private void method_182(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((SupportMission)this.GetSelectedMission()).StationThrottle_Submarine = (ActiveUnit.Throttle)(this.GetCombo_SupportStationThrottle_Submarine().SelectedIndex + 1);
			}
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_183(object sender, EventArgs e)
		{
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_184(object sender, EventArgs e)
		{
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x000231E5 File Offset: 0x000213E5
		private void method_185(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((MiningMission)this.GetSelectedMission()).TransitThrottle_Submarine = (ActiveUnit.Throttle)(this.GetCombo_MiningTransitThrottle_Submarine().SelectedIndex + 1);
			}
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x00023212 File Offset: 0x00021412
		private void method_186(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((MiningMission)this.GetSelectedMission()).StationThrottle_Submarine = (ActiveUnit.Throttle)(this.GetCombo_MiningStationThrottle_Submarine().SelectedIndex + 1);
			}
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x0002323F File Offset: 0x0002143F
		private void method_187(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((MiningMission)this.GetSelectedMission()).TransitThrottle_Ship = (ActiveUnit.Throttle)(this.GetCombo_MiningTransitThrottle_Ship().SelectedIndex + 1);
			}
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x0002326C File Offset: 0x0002146C
		private void method_188(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((MiningMission)this.GetSelectedMission()).StationThrottle_Ship = (ActiveUnit.Throttle)(this.GetCombo_MiningStationThrottle_Ship().SelectedIndex + 1);
			}
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_189(object sender, EventArgs e)
		{
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_190(object sender, EventArgs e)
		{
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x00023299 File Offset: 0x00021499
		private void method_191(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((MineClearingMission)this.GetSelectedMission()).TransitThrottle_Submarine = (ActiveUnit.Throttle)(this.GetCombo_MineClearingTransitThrottle_Submarine().SelectedIndex + 1);
			}
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x000232C6 File Offset: 0x000214C6
		private void method_192(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((MineClearingMission)this.GetSelectedMission()).StationThrottle_Submarine = (ActiveUnit.Throttle)(this.GetCombo_MineClearingStationThrottle_Submarine().SelectedIndex + 1);
			}
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x000232F3 File Offset: 0x000214F3
		private void method_193(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((MineClearingMission)this.GetSelectedMission()).TransitThrottle_Ship = (ActiveUnit.Throttle)(this.GetCombo_MineClearingTransitThrottle_Ship().SelectedIndex + 1);
			}
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x00023320 File Offset: 0x00021520
		private void method_194(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((MineClearingMission)this.GetSelectedMission()).StationThrottle_Ship = (ActiveUnit.Throttle)(this.GetCombo_MineClearingStationThrottle_Ship().SelectedIndex + 1);
			}
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_195(object sender, EventArgs e)
		{
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_196(object sender, EventArgs e)
		{
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x0002334D File Offset: 0x0002154D
		private void method_197(object sender, EventArgs e)
		{
			this.bool_9 = true;
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x00023356 File Offset: 0x00021556
		private void method_198(object sender, EventArgs e)
		{
			this.method_86();
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x0002335E File Offset: 0x0002155E
		private void method_199(object sender, EventArgs e)
		{
			this.bool_10 = true;
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x00023367 File Offset: 0x00021567
		private void method_200(object sender, EventArgs e)
		{
			this.method_87();
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x0002336F File Offset: 0x0002156F
		private void method_201(object sender, EventArgs e)
		{
			this.bool_11 = true;
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x00023378 File Offset: 0x00021578
		private void method_202(object sender, EventArgs e)
		{
			this.method_88();
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x00023380 File Offset: 0x00021580
		private void method_203(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x06004958 RID: 18776 RVA: 0x00023389 File Offset: 0x00021589
		private void method_204(object sender, EventArgs e)
		{
			this.method_89();
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x00023391 File Offset: 0x00021591
		private void method_205(object sender, EventArgs e)
		{
			this.bool_4 = true;
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x0002339A File Offset: 0x0002159A
		private void method_206(object sender, EventArgs e)
		{
			this.method_90();
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x000233A2 File Offset: 0x000215A2
		private void method_207(object sender, EventArgs e)
		{
			this.bool_17 = true;
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x000233AB File Offset: 0x000215AB
		private void method_208(object sender, EventArgs e)
		{
			this.method_93();
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x000233B3 File Offset: 0x000215B3
		private void method_209(object sender, EventArgs e)
		{
			this.bool_18 = true;
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x000233BC File Offset: 0x000215BC
		private void method_210(object sender, EventArgs e)
		{
			this.method_94();
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x000233C4 File Offset: 0x000215C4
		private void method_211(object sender, EventArgs e)
		{
			this.bool_23 = true;
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x000233CD File Offset: 0x000215CD
		private void method_212(object sender, EventArgs e)
		{
			this.method_95();
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x000233D5 File Offset: 0x000215D5
		private void method_213(object sender, EventArgs e)
		{
			this.bool_24 = true;
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x000233DE File Offset: 0x000215DE
		private void method_214(object sender, EventArgs e)
		{
			this.method_96();
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x000233E6 File Offset: 0x000215E6
		private void method_215(object sender, EventArgs e)
		{
			this.bool_7 = true;
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x000233EF File Offset: 0x000215EF
		private void method_216(object sender, EventArgs e)
		{
			this.method_85();
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x000233F7 File Offset: 0x000215F7
		private void method_217(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((Strike)this.GetSelectedMission()).Escort_TransitTerrainFollowing = this.vmethod_620().Checked;
			}
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x00023421 File Offset: 0x00021621
		private void method_218(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((Strike)this.GetSelectedMission()).Escort_AttackTerrainFollowing = this.vmethod_618().Checked;
			}
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x0002344B File Offset: 0x0002164B
		private void method_219(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((Patrol)this.GetSelectedMission()).TransitTerrainFollowing_Aircraft = this.GetCheckBox_PatrolTransitTerrainFollowing_Aircraft().Checked;
			}
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x00023475 File Offset: 0x00021675
		private void method_220(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((Patrol)this.GetSelectedMission()).StationTerrainFollowing_Aircraft = this.GetCheckBox_PatrolStationTerrainFollowing_Aircraft().Checked;
			}
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x0002349F File Offset: 0x0002169F
		private void method_221(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((Patrol)this.GetSelectedMission()).AttackTerrainFollowing_Aircraft = this.GetCheckBox_PatrolAttackTerrainFollowing_Aircraft().Checked;
			}
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x000234C9 File Offset: 0x000216C9
		private void method_222(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((SupportMission)this.GetSelectedMission()).TransitTerrainFollowing_Aircraft = this.vmethod_504().Checked;
			}
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x000234F3 File Offset: 0x000216F3
		private void method_223(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((SupportMission)this.GetSelectedMission()).StationTerrainFollowing_Aircraft = this.vmethod_502().Checked;
			}
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x0002351D File Offset: 0x0002171D
		private void method_224(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((FerryMission)this.GetSelectedMission()).FerryTerrainFollowing_Aircraft = this.vmethod_506().Checked;
			}
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x00023547 File Offset: 0x00021747
		private void method_225(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((MiningMission)this.GetSelectedMission()).TransitTerrainFollowing_Aircraft = this.vmethod_510().Checked;
			}
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x00023571 File Offset: 0x00021771
		private void method_226(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((MiningMission)this.GetSelectedMission()).StationTerrainFollowing_Aircraft = this.vmethod_508().Checked;
			}
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x0002359B File Offset: 0x0002179B
		private void method_227(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((MineClearingMission)this.GetSelectedMission()).TransitTerrainFollowing_Aircraft = this.vmethod_514().Checked;
			}
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x000235C5 File Offset: 0x000217C5
		private void method_228(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((MineClearingMission)this.GetSelectedMission()).StationTerrainFollowing_Aircraft = this.vmethod_512().Checked;
			}
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x000235EF File Offset: 0x000217EF
		private void DateTimePicker_ActivationDate_Enter(object sender, EventArgs e)
		{
			this.bool_28 = true;
			this.method_245();
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x000235FE File Offset: 0x000217FE
		private void DateTimePicker_ActivationDate_Leave(object sender, EventArgs e)
		{
			this.method_246();
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x000235EF File Offset: 0x000217EF
		private void method_231(object sender, EventArgs e)
		{
			this.bool_28 = true;
			this.method_245();
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x000235FE File Offset: 0x000217FE
		private void method_232(object sender, EventArgs e)
		{
			this.method_246();
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x00023606 File Offset: 0x00021806
		private void method_233(object sender, EventArgs e)
		{
			this.bool_29 = true;
			this.method_247();
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x00023615 File Offset: 0x00021815
		private void method_234(object sender, EventArgs e)
		{
			this.method_248();
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x00023606 File Offset: 0x00021806
		private void method_235(object sender, EventArgs e)
		{
			this.bool_29 = true;
			this.method_247();
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x00023615 File Offset: 0x00021815
		private void method_236(object sender, EventArgs e)
		{
			this.method_248();
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x0002361D File Offset: 0x0002181D
		private void method_237(object sender, EventArgs e)
		{
			this.bool_30 = true;
			this.method_249();
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x0002362C File Offset: 0x0002182C
		private void method_238(object sender, EventArgs e)
		{
			this.method_250();
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x0002361D File Offset: 0x0002181D
		private void method_239(object sender, EventArgs e)
		{
			this.bool_30 = true;
			this.method_249();
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x0002362C File Offset: 0x0002182C
		private void method_240(object sender, EventArgs e)
		{
			this.method_250();
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x00023634 File Offset: 0x00021834
		private void method_241(object sender, EventArgs e)
		{
			this.bool_31 = true;
			this.method_251();
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x00023643 File Offset: 0x00021843
		private void method_242(object sender, EventArgs e)
		{
			this.method_252();
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x00023634 File Offset: 0x00021834
		private void method_243(object sender, EventArgs e)
		{
			this.bool_31 = true;
			this.method_251();
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x00023643 File Offset: 0x00021843
		private void method_244(object sender, EventArgs e)
		{
			this.method_252();
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x001BE6C8 File Offset: 0x001BC8C8
		private void method_245()
		{
			if (!Information.IsNothing(this.GetSelectedMission()) && Information.IsNothing(this.GetSelectedMission().GetStartTime()))
			{
				this.GetDateTimePicker_ActivationDate().Value = Client.GetClientScenario().GetStartTime();
				this.GetDateTimePicker_ActivationTime().Value = Client.GetClientScenario().GetStartTime();
			}
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x001BE72C File Offset: 0x001BC92C
		private void method_246()
		{
			if (this.bool_28 && !Information.IsNothing(this.GetSelectedMission()))
			{
				this.GetDateTimePicker_ActivationDate().Format = DateTimePickerFormat.Short;
				this.GetDateTimePicker_ActivationTime().Format = DateTimePickerFormat.Time;
				this.GetSelectedMission().SetStartTime(new DateTime?(new DateTime(this.GetDateTimePicker_ActivationDate().Value.Year, this.GetDateTimePicker_ActivationDate().Value.Month, this.GetDateTimePicker_ActivationDate().Value.Day, this.GetDateTimePicker_ActivationTime().Value.Hour, this.GetDateTimePicker_ActivationTime().Value.Minute, this.GetDateTimePicker_ActivationTime().Value.Second)));
				bool? flag;
				if (!Information.IsNothing(this.GetSelectedMission().GetStartTime()))
				{
					DateTime? dateTime = this.GetSelectedMission().GetStartTime();
					DateTime currentTime = Client.GetClientScenario().GetCurrentTime(false);
					flag = (dateTime.HasValue ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), currentTime) < 0) : null);
				}
				else
				{
					flag = new bool?(true);
				}
				bool? flag3;
				bool? flag2 = flag3 = flag;
				bool? flag4;
				bool? flag6;
				if (flag2.HasValue && !flag3.GetValueOrDefault())
				{
					flag4 = new bool?(false);
				}
				else
				{
					bool? flag5;
					if (!Information.IsNothing(this.GetSelectedMission().GetEndTime()))
					{
						DateTime? dateTime = this.GetSelectedMission().GetEndTime();
						DateTime currentTime = Client.GetClientScenario().GetCurrentTime(false);
						flag5 = (dateTime.HasValue ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), currentTime) > 0) : null);
					}
					else
					{
						flag5 = new bool?(true);
					}
					flag2 = (flag6 = flag5);
					flag4 = (flag2.HasValue ? (flag3 & flag6.GetValueOrDefault()) : null);
				}
				flag6 = flag4;
				if (flag6.GetValueOrDefault())
				{
					this.GetSelectedMission().SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.Activation);
				}
				else
				{
					this.GetSelectedMission().SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.DeActivation);
				}
				this.method_9();
				this.method_25();
			}
			this.bool_28 = false;
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x001BE960 File Offset: 0x001BCB60
		private void method_247()
		{
			if (!Information.IsNothing(this.GetSelectedMission()) && Information.IsNothing(this.GetSelectedMission().GetEndTime()))
			{
				this.GetDateTimePicker_DeactivationDate().Value = Client.GetClientScenario().GetStartTime().Add(Client.GetClientScenario().GetDuration());
				this.GetDateTimePicker_DeactivationTime().Value = Client.GetClientScenario().GetStartTime().Add(Client.GetClientScenario().GetDuration());
			}
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x001BE9E8 File Offset: 0x001BCBE8
		private void method_248()
		{
			if (this.bool_29 && !Information.IsNothing(this.GetSelectedMission()))
			{
				this.GetDateTimePicker_DeactivationDate().Format = DateTimePickerFormat.Short;
				this.GetDateTimePicker_DeactivationTime().Format = DateTimePickerFormat.Time;
				this.GetSelectedMission().SetEndTime(new DateTime?(new DateTime(this.GetDateTimePicker_DeactivationDate().Value.Year, this.GetDateTimePicker_DeactivationDate().Value.Month, this.GetDateTimePicker_DeactivationDate().Value.Day, this.GetDateTimePicker_DeactivationTime().Value.Hour, this.GetDateTimePicker_DeactivationTime().Value.Minute, this.GetDateTimePicker_DeactivationTime().Value.Second)));
				bool? flag;
				if (!Information.IsNothing(this.GetSelectedMission().GetStartTime()))
				{
					DateTime? dateTime = this.GetSelectedMission().GetStartTime();
					DateTime currentTime = Client.GetClientScenario().GetCurrentTime(false);
					flag = (dateTime.HasValue ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), currentTime) < 0) : null);
				}
				else
				{
					flag = new bool?(true);
				}
				bool? flag3;
				bool? flag2 = flag3 = flag;
				bool? flag4;
				bool? flag6;
				if (flag2.HasValue && !flag3.GetValueOrDefault())
				{
					flag4 = new bool?(false);
				}
				else
				{
					bool? flag5;
					if (!Information.IsNothing(this.GetSelectedMission().GetEndTime()))
					{
						DateTime? dateTime = this.GetSelectedMission().GetEndTime();
						DateTime currentTime = Client.GetClientScenario().GetCurrentTime(false);
						flag5 = (dateTime.HasValue ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), currentTime) > 0) : null);
					}
					else
					{
						flag5 = new bool?(true);
					}
					flag2 = (flag6 = flag5);
					flag4 = (flag2.HasValue ? (flag3 & flag6.GetValueOrDefault()) : null);
				}
				flag6 = flag4;
				if (flag6.GetValueOrDefault())
				{
					this.GetSelectedMission().SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.Activation);
				}
				else
				{
					this.GetSelectedMission().SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.DeActivation);
				}
				this.method_9();
				this.method_25();
			}
			this.bool_29 = false;
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x001BEC1C File Offset: 0x001BCE1C
		private void method_249()
		{
			if (!Information.IsNothing(this.GetSelectedMission()) && Information.IsNothing(this.GetSelectedMission().GetTakeOffTime()))
			{
				this.GetDateTimePicker_TakeOffDate().Value = Client.GetClientScenario().GetStartTime().AddMinutes(30.0);
				this.GetDateTimePicker_TakeOffTime().Value = Client.GetClientScenario().GetStartTime().AddMinutes(30.0);
			}
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x001BECA0 File Offset: 0x001BCEA0
		private void method_250()
		{
			if (this.bool_30 && !Information.IsNothing(this.GetSelectedMission()))
			{
				this.GetDateTimePicker_TakeOffDate().Format = DateTimePickerFormat.Short;
				this.GetDateTimePicker_TakeOffTime().Format = DateTimePickerFormat.Time;
				this.GetSelectedMission().SetTakeOffTime(new DateTime?(new DateTime(this.GetDateTimePicker_TakeOffDate().Value.Year, this.GetDateTimePicker_TakeOffDate().Value.Month, this.GetDateTimePicker_TakeOffDate().Value.Day, this.GetDateTimePicker_TakeOffTime().Value.Hour, this.GetDateTimePicker_TakeOffTime().Value.Minute, this.GetDateTimePicker_TakeOffTime().Value.Second)));
				this.method_9();
				this.method_25();
			}
			this.bool_30 = false;
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x001BED7C File Offset: 0x001BCF7C
		private void method_251()
		{
			if (!Information.IsNothing(this.GetSelectedMission()) && Information.IsNothing(this.GetSelectedMission().GetTimeOnTarget()))
			{
				this.GetDateTimePicker_TimeOnTargetDate().Value = Client.GetClientScenario().GetStartTime().AddHours(3.0);
				this.GetDateTimePicker_TimeOnTargetTime().Value = Client.GetClientScenario().GetStartTime().AddHours(3.0);
			}
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x001BEE00 File Offset: 0x001BD000
		private void method_252()
		{
			if (this.bool_31 && !Information.IsNothing(this.GetSelectedMission()))
			{
				this.GetDateTimePicker_TimeOnTargetDate().Format = DateTimePickerFormat.Short;
				this.GetDateTimePicker_TimeOnTargetTime().Format = DateTimePickerFormat.Time;
				this.GetSelectedMission().SetTimeOnTarget(new DateTime?(new DateTime(this.GetDateTimePicker_TimeOnTargetDate().Value.Year, this.GetDateTimePicker_TimeOnTargetDate().Value.Month, this.GetDateTimePicker_TimeOnTargetTime().Value.Day, this.GetDateTimePicker_TimeOnTargetTime().Value.Hour, this.GetDateTimePicker_TimeOnTargetTime().Value.Minute, this.GetDateTimePicker_TimeOnTargetTime().Value.Second)));
				this.method_9();
				this.method_25();
			}
			this.bool_31 = false;
		}

		// Token: 0x06004989 RID: 18825 RVA: 0x001BEEDC File Offset: 0x001BD0DC
		private void method_253(object sender, EventArgs e)
		{
			this.GetSelectedMission().SetStartTime(null);
			this.GetSelectedMission().SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.Activation);
			this.method_25();
			this.method_9();
		}

		// Token: 0x0600498A RID: 18826 RVA: 0x001BEF1C File Offset: 0x001BD11C
		private void method_254(object sender, EventArgs e)
		{
			this.GetSelectedMission().SetEndTime(null);
			this.GetSelectedMission().SetMissionStatus(Client.GetClientScenario(), Mission._MissionStatus.Activation);
			this.method_25();
			this.method_9();
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x001BEF5C File Offset: 0x001BD15C
		private void method_255(object sender, EventArgs e)
		{
			this.GetSelectedMission().SetTakeOffTime(null);
			this.method_25();
			this.method_9();
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x001BEF8C File Offset: 0x001BD18C
		private void method_256(object sender, EventArgs e)
		{
			this.GetSelectedMission().SetTimeOnTarget(null);
			this.method_25();
			this.method_9();
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void DateTimePicker_ActivationDate_DropDown(object sender, EventArgs e)
		{
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_258(object sender, EventArgs e)
		{
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x0002364B File Offset: 0x0002184B
		private void DateTimePicker_ActivationDate_CloseUp(object sender, EventArgs e)
		{
			this.bool_28 = true;
			this.method_246();
		}

		// Token: 0x06004990 RID: 18832 RVA: 0x0002365A File Offset: 0x0002185A
		private void method_260(object sender, EventArgs e)
		{
			this.bool_29 = true;
			this.method_248();
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x00023669 File Offset: 0x00021869
		private void method_261(object sender, EventArgs e)
		{
			this.bool_30 = true;
			this.method_250();
		}

		// Token: 0x06004992 RID: 18834 RVA: 0x00023678 File Offset: 0x00021878
		private void method_262(object sender, EventArgs e)
		{
			this.bool_31 = true;
			this.method_252();
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x00023687 File Offset: 0x00021887
		private void method_263(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				CommandFactory.GetCommandMain().GetTankerPlanner().mission_0 = this.GetSelectedMission();
				CommandFactory.GetCommandMain().GetTankerPlanner().Show();
			}
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x00023687 File Offset: 0x00021887
		private void method_264(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				CommandFactory.GetCommandMain().GetTankerPlanner().mission_0 = this.GetSelectedMission();
				CommandFactory.GetCommandMain().GetTankerPlanner().Show();
			}
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x00023687 File Offset: 0x00021887
		private void method_265(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				CommandFactory.GetCommandMain().GetTankerPlanner().mission_0 = this.GetSelectedMission();
				CommandFactory.GetCommandMain().GetTankerPlanner().Show();
			}
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x00023687 File Offset: 0x00021887
		private void method_266(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				CommandFactory.GetCommandMain().GetTankerPlanner().mission_0 = this.GetSelectedMission();
				CommandFactory.GetCommandMain().GetTankerPlanner().Show();
			}
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x00023687 File Offset: 0x00021887
		private void method_267(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				CommandFactory.GetCommandMain().GetTankerPlanner().mission_0 = this.GetSelectedMission();
				CommandFactory.GetCommandMain().GetTankerPlanner().Show();
			}
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x00023687 File Offset: 0x00021887
		private void method_268(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				CommandFactory.GetCommandMain().GetTankerPlanner().mission_0 = this.GetSelectedMission();
				CommandFactory.GetCommandMain().GetTankerPlanner().Show();
			}
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x001BEFBC File Offset: 0x001BD1BC
		private void method_269(object sender, EventArgs e)
		{
			if (this.vmethod_730().SelectedIndex == 0)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_2));
			}
			else if (this.vmethod_730().SelectedIndex == 1)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
			}
			else if (this.vmethod_730().SelectedIndex == 2)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_1));
			}
			else
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, null);
			}
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x001BF098 File Offset: 0x001BD298
		private void method_270(object sender, EventArgs e)
		{
			if (this.GetCB_TankerUsage_Support().SelectedIndex == 0)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_2));
			}
			else if (this.GetCB_TankerUsage_Support().SelectedIndex == 1)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
			}
			else if (this.GetCB_TankerUsage_Support().SelectedIndex == 2)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_1));
			}
			else
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, null);
			}
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x001BF174 File Offset: 0x001BD374
		private void method_271(object sender, EventArgs e)
		{
			if (this.vmethod_742().SelectedIndex == 0)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_2));
			}
			else if (this.vmethod_742().SelectedIndex == 1)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
			}
			else if (this.vmethod_742().SelectedIndex == 2)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_1));
			}
			else
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, null);
			}
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x001BF250 File Offset: 0x001BD450
		private void method_272(object sender, EventArgs e)
		{
			if (this.vmethod_748().SelectedIndex == 0)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_2));
			}
			else if (this.vmethod_748().SelectedIndex == 1)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
			}
			else if (this.vmethod_748().SelectedIndex == 2)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_1));
			}
			else
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, null);
			}
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x001BF32C File Offset: 0x001BD52C
		private void method_273(object sender, EventArgs e)
		{
			if (this.vmethod_754().SelectedIndex == 0)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_2));
			}
			else if (this.vmethod_754().SelectedIndex == 1)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_0));
			}
			else if (this.vmethod_754().SelectedIndex == 2)
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_1));
			}
			else
			{
				this.GetSelectedMission().m_Doctrine.SetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false, null);
			}
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x000236BA File Offset: 0x000218BA
		private void method_274(object sender, EventArgs e)
		{
			this.bool_8 = true;
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x000236C3 File Offset: 0x000218C3
		private void method_275(object sender, EventArgs e)
		{
			this.method_276();
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x001BF408 File Offset: 0x001BD608
		private void method_276()
		{
			if (this.bool_8)
			{
				this.bool_8 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Patrol)
				{
					if (string.IsNullOrEmpty(this.GetTB_PatrolAttackDistance_Aircraft().Text))
					{
						((Patrol)this.GetSelectedMission()).AttackDistance_Aircraft = null;
						this.GetTB_PatrolAttackDistance_Aircraft().Text = "未定";
					}
					else if (!Versioned.IsNumeric(this.GetTB_PatrolAttackDistance_Aircraft().Text))
					{
						((Patrol)this.GetSelectedMission()).AttackDistance_Aircraft = null;
						this.GetTB_PatrolAttackDistance_Aircraft().Text = "未定";
					}
					else if (Conversions.ToInteger(this.GetTB_PatrolAttackDistance_Aircraft().Text) > 0)
					{
						((Patrol)this.GetSelectedMission()).AttackDistance_Aircraft = new float?(Conversions.ToSingle(this.GetTB_PatrolAttackDistance_Aircraft().Text));
					}
					else
					{
						((Patrol)this.GetSelectedMission()).AttackDistance_Aircraft = null;
						this.GetTB_PatrolAttackDistance_Aircraft().Text = "未定";
					}
				}
			}
			else
			{
				this.bool_8 = false;
			}
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x000236CB File Offset: 0x000218CB
		private void method_277(object sender, EventArgs e)
		{
			this.bool_12 = true;
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x000236D4 File Offset: 0x000218D4
		private void method_278(object sender, EventArgs e)
		{
			this.method_279();
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x001BF538 File Offset: 0x001BD738
		private void method_279()
		{
			if (this.bool_12)
			{
				this.bool_12 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Patrol)
				{
					if (string.IsNullOrEmpty(this.vmethod_804().Text))
					{
						((Patrol)this.GetSelectedMission()).AttackDistance_Submarine = null;
						this.vmethod_804().Text = "未定";
					}
					else if (!Versioned.IsNumeric(this.vmethod_804().Text))
					{
						((Patrol)this.GetSelectedMission()).AttackDistance_Submarine = null;
						this.vmethod_804().Text = "未定";
					}
					else if (Conversions.ToInteger(this.vmethod_804().Text) > 0)
					{
						((Patrol)this.GetSelectedMission()).AttackDistance_Submarine = new float?(Conversions.ToSingle(this.vmethod_804().Text));
					}
					else
					{
						((Patrol)this.GetSelectedMission()).AttackDistance_Submarine = null;
						this.vmethod_804().Text = "未定";
					}
				}
			}
			else
			{
				this.bool_12 = false;
			}
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x000236DC File Offset: 0x000218DC
		private void method_280(object sender, EventArgs e)
		{
			this.bool_13 = true;
		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x000236E5 File Offset: 0x000218E5
		private void method_281(object sender, EventArgs e)
		{
			this.method_282();
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x001BF668 File Offset: 0x001BD868
		private void method_282()
		{
			if (this.bool_13)
			{
				this.bool_13 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Patrol)
				{
					if (string.IsNullOrEmpty(this.GetTB_PatrolAttackDistance_Ship().Text))
					{
						((Patrol)this.GetSelectedMission()).AttackDistance_Ship = null;
						this.GetTB_PatrolAttackDistance_Ship().Text = "未定";
					}
					else if (!Versioned.IsNumeric(this.GetTB_PatrolAttackDistance_Ship().Text))
					{
						((Patrol)this.GetSelectedMission()).AttackDistance_Ship = null;
						this.GetTB_PatrolAttackDistance_Ship().Text = "未定";
					}
					else if (Conversions.ToInteger(this.GetTB_PatrolAttackDistance_Ship().Text) != 0)
					{
						((Patrol)this.GetSelectedMission()).AttackDistance_Ship = new float?(Conversions.ToSingle(this.GetTB_PatrolAttackDistance_Ship().Text));
					}
					else
					{
						((Patrol)this.GetSelectedMission()).AttackDistance_Ship = null;
						this.GetTB_PatrolAttackDistance_Ship().Text = "未定";
					}
				}
			}
			else
			{
				this.bool_13 = false;
			}
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x000236ED File Offset: 0x000218ED
		private void method_283(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((SupportMission)this.GetSelectedMission()).A2AR_OneTankingCycleOnly = this.GetCB_OneA2AR().Checked;
			}
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x00023717 File Offset: 0x00021917
		private void method_284(object sender, EventArgs e)
		{
			this.bool_32 = true;
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x00023720 File Offset: 0x00021920
		private void method_285(object sender, EventArgs e)
		{
			this.method_286();
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x001BF798 File Offset: 0x001BD998
		private void method_286()
		{
			if (this.bool_32)
			{
				this.bool_32 = false;
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().MissionClass == Mission._MissionClass.Support)
				{
					if (string.IsNullOrEmpty(this.GetTB_NumberOfReceiversA2AR().Text))
					{
						((SupportMission)this.GetSelectedMission()).A2AR_MaxNumberOfReceiversPerTanker = 0;
						this.GetTB_NumberOfReceiversA2AR().Text = "0";
					}
					else if (!Versioned.IsNumeric(this.GetTB_NumberOfReceiversA2AR().Text))
					{
						((SupportMission)this.GetSelectedMission()).A2AR_MaxNumberOfReceiversPerTanker = 0;
						this.GetTB_NumberOfReceiversA2AR().Text = "0";
					}
					else
					{
						((SupportMission)this.GetSelectedMission()).A2AR_MaxNumberOfReceiversPerTanker = (int)Math.Round((double)Conversions.ToSingle(this.GetTB_NumberOfReceiversA2AR().Text));
					}
				}
			}
			else
			{
				this.bool_32 = false;
			}
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x001BF880 File Offset: 0x001BDA80
		private void method_287(object sender, EventArgs e)
		{
			System.Windows.Forms.ComboBox comboBox_GroupSize_Strike;
			int selectedIndex = (comboBox_GroupSize_Strike = this.GetComboBox_GroupSize_Strike()).SelectedIndex;
			this.method_70(ref selectedIndex, ref ((Strike)this.GetSelectedMission()).m_GroupSize);
			comboBox_GroupSize_Strike.SelectedIndex = selectedIndex;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x00023728 File Offset: 0x00021928
		private void method_288(object sender, EventArgs e)
		{
			this.GetSelectedMission().UseGroupSizeHardLimit = this.GetCB_UseGroupSizeHardLimit_Strike().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x001BF8C8 File Offset: 0x001BDAC8
		private void method_289(object sender, EventArgs e)
		{
			System.Windows.Forms.ComboBox comboBox;
			int selectedIndex = (comboBox = this.vmethod_844()).SelectedIndex;
			this.method_70(ref selectedIndex, ref ((Patrol)this.GetSelectedMission()).m_GroupSize);
			comboBox.SelectedIndex = selectedIndex;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x0002374C File Offset: 0x0002194C
		private void method_290(object sender, EventArgs e)
		{
			this.GetSelectedMission().UseGroupSizeHardLimit = this.vmethod_840().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x001BF910 File Offset: 0x001BDB10
		private void method_291(object sender, EventArgs e)
		{
			System.Windows.Forms.ComboBox comboBox_GroupSize_Support;
			int selectedIndex = (comboBox_GroupSize_Support = this.GetComboBox_GroupSize_Support()).SelectedIndex;
			this.method_70(ref selectedIndex, ref ((SupportMission)this.GetSelectedMission()).m_GroupSize);
			comboBox_GroupSize_Support.SelectedIndex = selectedIndex;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x00023770 File Offset: 0x00021970
		private void method_292(object sender, EventArgs e)
		{
			this.GetSelectedMission().UseGroupSizeHardLimit = this.GetCB_UseGroupSizeHardLimit_Support().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x001BF958 File Offset: 0x001BDB58
		private void method_293(object sender, EventArgs e)
		{
			System.Windows.Forms.ComboBox comboBox;
			int selectedIndex = (comboBox = this.vmethod_854()).SelectedIndex;
			this.method_70(ref selectedIndex, ref ((MiningMission)this.GetSelectedMission()).m_GroupSize);
			comboBox.SelectedIndex = selectedIndex;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x00023794 File Offset: 0x00021994
		private void method_294(object sender, EventArgs e)
		{
			this.GetSelectedMission().UseGroupSizeHardLimit = this.vmethod_850().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x001BF9A0 File Offset: 0x001BDBA0
		private void method_295(object sender, EventArgs e)
		{
			System.Windows.Forms.ComboBox comboBox;
			int selectedIndex = (comboBox = this.vmethod_860()).SelectedIndex;
			this.method_70(ref selectedIndex, ref ((MineClearingMission)this.GetSelectedMission()).m_GroupSize);
			comboBox.SelectedIndex = selectedIndex;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049B4 RID: 18868 RVA: 0x000237B8 File Offset: 0x000219B8
		private void method_296(object sender, EventArgs e)
		{
			this.GetSelectedMission().UseGroupSizeHardLimit = this.vmethod_856().Checked;
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049B5 RID: 18869 RVA: 0x001BF9E8 File Offset: 0x001BDBE8
		private void method_297(object sender, EventArgs e)
		{
			if (this.SelectedMission.MissionClass == Mission._MissionClass.Strike)
			{
				System.Windows.Forms.ComboBox comboBox;
				int selectedIndex = (comboBox = this.vmethod_868()).SelectedIndex;
				this.method_70(ref selectedIndex, ref ((Strike)this.GetSelectedMission()).Escort_GroupSize);
				comboBox.SelectedIndex = selectedIndex;
			}
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049B6 RID: 18870 RVA: 0x000237DC File Offset: 0x000219DC
		private void method_298(object sender, EventArgs e)
		{
			if (this.GetSelectedMission().MissionClass == Mission._MissionClass.Strike)
			{
				((Strike)this.GetSelectedMission()).UseGroupSizeHardLimit_Escort = this.vmethod_864().Checked;
			}
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049B7 RID: 18871 RVA: 0x00023818 File Offset: 0x00021A18
		private void method_299(object sender, EventArgs e)
		{
			((Patrol)this.GetSelectedMission()).method_46(Client.GetClientScenario(), this.vmethod_870().Checked);
			Client.b_Completed = true;
		}

		// Token: 0x060049B8 RID: 18872 RVA: 0x00023840 File Offset: 0x00021A40
		private void method_300(object sender, EventArgs e)
		{
			Client.flightPlans.mission_0 = this.GetSelectedMission();
			Client.flightPlans.Show();
		}

		// Token: 0x060049B9 RID: 18873 RVA: 0x001BFA44 File Offset: 0x001BDC44
		private void Button_FlightPlanEditor_Strike_Click(object sender, EventArgs e)
		{
			Client.flightPlanEditor.m_mission = this.GetSelectedMission();
			if (this.GetSelectedMission().FlightList.Count > 0)
			{
				Client.flightPlanEditor.m_Flight = this.GetSelectedMission().FlightList[0];
			}
			else
			{
				Client.flightPlanEditor.m_Flight = null;
			}
			Client.flightPlanEditor.Show();
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x00023840 File Offset: 0x00021A40
		private void method_302(object sender, EventArgs e)
		{
			Client.flightPlans.mission_0 = this.GetSelectedMission();
			Client.flightPlans.Show();
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x001BFAAC File Offset: 0x001BDCAC
		private void method_303(object sender, EventArgs e)
		{
			Client.flightPlanEditor.m_mission = this.GetSelectedMission();
			if (this.GetSelectedMission().HasFlights())
			{
				Client.flightPlanEditor.m_Flight = this.GetSelectedMission().FlightList[0];
			}
			else
			{
				Client.flightPlanEditor.m_Flight = null;
			}
			Client.flightPlanEditor.Show();
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x00023840 File Offset: 0x00021A40
		private void method_304(object sender, EventArgs e)
		{
			Client.flightPlans.mission_0 = this.GetSelectedMission();
			Client.flightPlans.Show();
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x001BFAAC File Offset: 0x001BDCAC
		private void method_305(object sender, EventArgs e)
		{
			Client.flightPlanEditor.m_mission = this.GetSelectedMission();
			if (this.GetSelectedMission().HasFlights())
			{
				Client.flightPlanEditor.m_Flight = this.GetSelectedMission().FlightList[0];
			}
			else
			{
				Client.flightPlanEditor.m_Flight = null;
			}
			Client.flightPlanEditor.Show();
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x00023840 File Offset: 0x00021A40
		private void method_306(object sender, EventArgs e)
		{
			Client.flightPlans.mission_0 = this.GetSelectedMission();
			Client.flightPlans.Show();
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x001BFAAC File Offset: 0x001BDCAC
		private void method_307(object sender, EventArgs e)
		{
			Client.flightPlanEditor.m_mission = this.GetSelectedMission();
			if (this.GetSelectedMission().HasFlights())
			{
				Client.flightPlanEditor.m_Flight = this.GetSelectedMission().FlightList[0];
			}
			else
			{
				Client.flightPlanEditor.m_Flight = null;
			}
			Client.flightPlanEditor.Show();
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x00023840 File Offset: 0x00021A40
		private void method_308(object sender, EventArgs e)
		{
			Client.flightPlans.mission_0 = this.GetSelectedMission();
			Client.flightPlans.Show();
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x001BFAAC File Offset: 0x001BDCAC
		private void method_309(object sender, EventArgs e)
		{
			Client.flightPlanEditor.m_mission = this.GetSelectedMission();
			if (this.GetSelectedMission().HasFlights())
			{
				Client.flightPlanEditor.m_Flight = this.GetSelectedMission().FlightList[0];
			}
			else
			{
				Client.flightPlanEditor.m_Flight = null;
			}
			Client.flightPlanEditor.Show();
		}

		// Token: 0x060049C2 RID: 18882 RVA: 0x00023840 File Offset: 0x00021A40
		private void method_310(object sender, EventArgs e)
		{
			Client.flightPlans.mission_0 = this.GetSelectedMission();
			Client.flightPlans.Show();
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x001BFAAC File Offset: 0x001BDCAC
		private void method_311(object sender, EventArgs e)
		{
			Client.flightPlanEditor.m_mission = this.GetSelectedMission();
			if (this.GetSelectedMission().HasFlights())
			{
				Client.flightPlanEditor.m_Flight = this.GetSelectedMission().FlightList[0];
			}
			else
			{
				Client.flightPlanEditor.m_Flight = null;
			}
			Client.flightPlanEditor.Show();
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x00023840 File Offset: 0x00021A40
		private void method_312(object sender, EventArgs e)
		{
			Client.flightPlans.mission_0 = this.GetSelectedMission();
			Client.flightPlans.Show();
		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x001BFAAC File Offset: 0x001BDCAC
		private void method_313(object sender, EventArgs e)
		{
			Client.flightPlanEditor.m_mission = this.GetSelectedMission();
			if (this.GetSelectedMission().HasFlights())
			{
				Client.flightPlanEditor.m_Flight = this.GetSelectedMission().FlightList[0];
			}
			else
			{
				Client.flightPlanEditor.m_Flight = null;
			}
			Client.flightPlanEditor.Show();
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x0002385C File Offset: 0x00021A5C
		private void method_314(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				this.GetSelectedMission().Deactivation_UnassignUnits = this.GetCheckBox_UnassignUnits().Checked;
			}
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x00023881 File Offset: 0x00021A81
		private void method_315(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				this.GetSelectedMission().CheckBox_OrderRTB = this.GetCheckBox_OrderRTB().Checked;
			}
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x000238A6 File Offset: 0x00021AA6
		private void method_316(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				this.GetSelectedMission().CheckBox_DeleteMission = this.GetCheckBox_DeleteMission().Checked;
			}
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x001BFB0C File Offset: 0x001BDD0C
		private void method_317()
		{
			if (this.GetSelectedMission().GetTimeOnTarget().HasValue)
			{
				this.GetDateTimePicker_TakeOffDate().Enabled = false;
				this.GetDateTimePicker_TakeOffTime().Enabled = false;
				this.GetButton_Clear_TakeOffTime().Enabled = false;
				this.GetDateTimePicker_TimeOnTargetDate().Enabled = true;
				this.GetDateTimePicker_TimeOnTargetTime().Enabled = true;
				this.GetButton_Clear_TimeOnTarget().Enabled = true;
			}
			else if (this.GetSelectedMission().GetTakeOffTime().HasValue)
			{
				this.GetDateTimePicker_TakeOffDate().Enabled = true;
				this.GetDateTimePicker_TakeOffTime().Enabled = true;
				this.GetButton_Clear_TakeOffTime().Enabled = true;
				this.GetDateTimePicker_TimeOnTargetDate().Enabled = false;
				this.GetDateTimePicker_TimeOnTargetTime().Enabled = false;
				this.GetButton_Clear_TimeOnTarget().Enabled = false;
			}
			else
			{
				this.GetDateTimePicker_TakeOffDate().Enabled = true;
				this.GetDateTimePicker_TakeOffTime().Enabled = true;
				this.GetButton_Clear_TakeOffTime().Enabled = true;
				this.GetDateTimePicker_TimeOnTargetDate().Enabled = true;
				this.GetDateTimePicker_TimeOnTargetTime().Enabled = true;
				this.GetButton_Clear_TimeOnTarget().Enabled = true;
			}
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x001BFC28 File Offset: 0x001BDE28
		private void Button_FillEmptySlots_Strike_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				Mission selectedMission = this.GetSelectedMission();
				Scenario clientScenario = Client.GetClientScenario();
				Side clientSide = Client.GetClientSide();
				Mission selectedMission2 = this.GetSelectedMission();
				bool flag = true;
				selectedMission.method_21(ref clientScenario, ref clientSide, ref selectedMission2, ref flag);
				this.method_5(selectedMission2);
				Client.SetClientSide(clientSide);
				this.method_10();
				this.method_12();
				this.GetSelectedMission().int_0 = 1;
			}
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x001BFC94 File Offset: 0x001BDE94
		private void Button_CreateFlightPlans_Strike_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				if (this.GetSelectedMission().category == Mission.MissionCategory.Package)
				{
					if (Information.IsNothing(this.GetSelectedMission().GetTakeOffTime()) && Information.IsNothing(this.GetSelectedMission().GetTimeOnTarget()) && Interaction.MsgBox("No Take-Off Time or Time-On-Target (TOT) Time has been set for this package. Do you want to create flights without waypoint times? If not, press 'No' and enter times before trying again.", MsgBoxStyle.YesNo, "No times set!") == MsgBoxResult.No)
					{
						return;
					}
					if (!Information.IsNothing(this.GetSelectedMission().GetTakeOffTime()))
					{
						DateTime? dateTime = this.GetSelectedMission().GetTakeOffTime();
						DateTime currentTime = Client.GetClientScenario().GetCurrentTime(false);
						if ((dateTime.HasValue ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), currentTime) < 0) : null).GetValueOrDefault())
						{
							Interaction.MsgBox("任务（Task）包的起飞时间早于当前想定时间。请修改起飞时间重试。", MsgBoxStyle.OkOnly, "时间错误!");
							return;
						}
					}
					if (!Information.IsNothing(this.GetSelectedMission().GetTimeOnTarget()))
					{
						DateTime? dateTime = this.GetSelectedMission().GetTimeOnTarget();
						DateTime currentTime = Client.GetClientScenario().GetCurrentTime(false);
						if ((dateTime.HasValue ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), currentTime) <= 0) : null).GetValueOrDefault())
						{
							Interaction.MsgBox("任务（Task）包的到达目标时间早于当前想定时间。请修改时间重试。", MsgBoxStyle.OkOnly, "时间错误!");
							return;
						}
					}
				}
				if (!Information.IsNothing(this.GetSelectedMission().list_0))
				{
					this.GetSelectedMission().list_0.Clear();
				}
				Scenario clientScenario = Client.GetClientScenario();
				Side clientSide = Client.GetClientSide();
				Mission selectedMission = this.GetSelectedMission();
				GameGeneral.smethod_24(ref clientScenario, ref clientSide, ref selectedMission, true, false, false);
				this.method_5(selectedMission);
				Client.SetClientSide(clientSide);
				this.method_10();
				this.method_12();
				if (Client.flightPlans.Visible)
				{
					Client.flightPlans.method_2();
				}
				this.GetSelectedMission().int_0 = 1;
			}
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x001BFE94 File Offset: 0x001BE094
		private void method_320(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((Strike)this.GetSelectedMission()).AttackMethod = (Mission._AttackMethod)this.GetCB_AttackMethod().SelectedIndex;
			}
			if (this.GetCB_AttackMethod().SelectedIndex <= 1)
			{
				this.GetCB_SplitDistance().Enabled = false;
			}
			else
			{
				this.GetCB_SplitDistance().Enabled = true;
			}
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x000238CB File Offset: 0x00021ACB
		private void method_321(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()))
			{
				((Strike)this.GetSelectedMission()).SplitDistance = (Mission._SplitDistance)this.GetCB_SplitDistance().SelectedIndex;
			}
			this.GetSelectedMission().int_0 = 1;
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x001BFF00 File Offset: 0x001BE100
		private void method_322(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().category == Mission.MissionCategory.TaskPool)
			{
				TaskPool taskPool = (TaskPool)this.GetSelectedMission();
				Scenario clientScenario;
				Side clientSide;
				foreach (Mission current in taskPool.Packages)
				{
					clientScenario = Client.GetClientScenario();
					clientSide = Client.GetClientSide();
					current.SetTakeOffOrTOTTime(ref clientScenario, ref clientSide);
					Client.SetClientSide(clientSide);
					current.int_0 = 1;
				}
				clientScenario = Client.GetClientScenario();
				clientSide = Client.GetClientSide();
				Mission selectedMission = this.GetSelectedMission();
				GameGeneral.smethod_24(ref clientScenario, ref clientSide, ref selectedMission, true, false, false);
				this.method_5(selectedMission);
				Client.SetClientSide(clientSide);
				this.method_10();
				this.method_12();
				if (Client.flightPlans.Visible)
				{
					Client.flightPlans.method_2();
				}
				Client.b_Completed = true;
			}
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x001C0000 File Offset: 0x001BE200
		private void method_323(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.vmethod_6().SelectedNode))
			{
				this.method_5((Mission)this.vmethod_6().SelectedNode.Tag);
				if (!Information.IsNothing(this.GetSelectedMission()) && this.GetSelectedMission().category == Mission.MissionCategory.TaskPool)
				{
					TaskPool taskPool = (TaskPool)this.GetSelectedMission();
					foreach (Mission current in taskPool.Packages)
					{
						Scenario clientScenario = Client.GetClientScenario();
						Side clientSide = Client.GetClientSide();
						current.method_43(ref clientScenario, ref clientSide);
						Client.SetClientSide(clientSide);
					}
					this.method_9();
					this.method_10();
					this.method_12();
					Client.b_Completed = true;
				}
			}
		}

		// Token: 0x0400204E RID: 8270
		public static Func<Mission, string> MissionFunc0 = (Mission mission_0) => mission_0.Name;

		// Token: 0x0400204F RID: 8271
		public static Func<Aircraft, Aircraft> AircraftFunc1 = (Aircraft aircraft_0) => aircraft_0;

		// Token: 0x04002050 RID: 8272
		public static Func<Aircraft, string> AircraftFunc2 = (Aircraft aircraft_0) => aircraft_0.Name;

		// Token: 0x04002051 RID: 8273
		public static Func<Aircraft, Aircraft> AircraftFunc3 = (Aircraft aircraft_0) => aircraft_0;

		// Token: 0x04002052 RID: 8274
		public static Func<Aircraft, string> AircraftFunc4 = (Aircraft aircraft_0) => aircraft_0.GetAircraftNavigator().GetFlight().Callsign;

		// Token: 0x04002053 RID: 8275
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc5 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04002054 RID: 8276
		public static Func<ActiveUnit, string> ActiveUnitFunc6 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x04002055 RID: 8277
		public static Func<Aircraft, Aircraft> AircraftFunc7 = (Aircraft aircraft_0) => aircraft_0;

		// Token: 0x04002056 RID: 8278
		public static Func<Aircraft, string> AircraftFunc8 = (Aircraft aircraft_0) => aircraft_0.Name;

		// Token: 0x04002057 RID: 8279
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc9 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04002058 RID: 8280
		public static Func<ActiveUnit, string> ActiveUnitFunc10 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x04002059 RID: 8281
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc11 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x0400205A RID: 8282
		public static Func<ActiveUnit, string> ActiveUnitFunc12 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x0400205B RID: 8283
		public static Func<Unit, string> UnitFunc13 = (Unit unit_0) => unit_0.Name;

		// Token: 0x0400205D RID: 8285
		[CompilerGenerated]
		private System.Windows.Forms.Label label_0;

		// Token: 0x0400205E RID: 8286
		[CompilerGenerated]
		private System.Windows.Forms.Label label_1;

		// Token: 0x0400205F RID: 8287
		[CompilerGenerated]
		private System.Windows.Forms.Label label_2;

		// Token: 0x04002060 RID: 8288
		[CompilerGenerated]
		private System.Windows.Forms.TreeView treeView_0;

		// Token: 0x04002061 RID: 8289
		[CompilerGenerated]
		private System.Windows.Forms.Button Button_UnassignUnitsToMission;

		// Token: 0x04002062 RID: 8290
		[CompilerGenerated]
		private System.Windows.Forms.Button Button_AssignUnitsToMission;

		// Token: 0x04002063 RID: 8291
		[CompilerGenerated]
		private System.Windows.Forms.Button Button_DeleteMission;

		// Token: 0x04002064 RID: 8292
		[CompilerGenerated]
		private System.Windows.Forms.Button button_3;

		// Token: 0x04002065 RID: 8293
		[CompilerGenerated]
		private System.Windows.Forms.Button button_4;

		// Token: 0x04002066 RID: 8294
		[CompilerGenerated]
		private System.Windows.Forms.Button button_5;

		// Token: 0x04002067 RID: 8295
		[CompilerGenerated]
		private System.Windows.Forms.TreeView treeView_1;

		// Token: 0x04002068 RID: 8296
		[CompilerGenerated]
		private System.Windows.Forms.TreeView treeView_2;

		// Token: 0x04002069 RID: 8297
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x0400206A RID: 8298
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_0;

		// Token: 0x0400206B RID: 8299
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x0400206C RID: 8300
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x0400206D RID: 8301
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_1;

		// Token: 0x0400206E RID: 8302
		[CompilerGenerated]
		private Control1 control1_0;

		// Token: 0x0400206F RID: 8303
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_0;

		// Token: 0x04002070 RID: 8304
		[CompilerGenerated]
		private System.Windows.Forms.Label label_3;

		// Token: 0x04002071 RID: 8305
		[CompilerGenerated]
		private TabPage tabPage_3;

		// Token: 0x04002072 RID: 8306
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_1;

		// Token: 0x04002073 RID: 8307
		[CompilerGenerated]
		private System.Windows.Forms.Label label_4;

		// Token: 0x04002074 RID: 8308
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_2;

		// Token: 0x04002075 RID: 8309
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_2;

		// Token: 0x04002076 RID: 8310
		[CompilerGenerated]
		private System.Windows.Forms.Label label_5;

		// Token: 0x04002077 RID: 8311
		[CompilerGenerated]
		private System.Windows.Forms.Button button_6;

		// Token: 0x04002078 RID: 8312
		[CompilerGenerated]
		private System.Windows.Forms.Label label_6;

		// Token: 0x04002079 RID: 8313
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_3;

		// Token: 0x0400207A RID: 8314
		[CompilerGenerated]
		private AreaEditor areaEditor_0;

		// Token: 0x0400207B RID: 8315
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_4;

		// Token: 0x0400207C RID: 8316
		[CompilerGenerated]
		private AreaEditor areaEditor_1;

		// Token: 0x0400207D RID: 8317
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_3;

		// Token: 0x0400207E RID: 8318
		[CompilerGenerated]
		private System.Windows.Forms.Label label_7;

		// Token: 0x0400207F RID: 8319
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_4;

		// Token: 0x04002080 RID: 8320
		[CompilerGenerated]
		private System.Windows.Forms.Label label_8;

		// Token: 0x04002081 RID: 8321
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_5;

		// Token: 0x04002082 RID: 8322
		[CompilerGenerated]
		private TabPage tabPage_4;

		// Token: 0x04002083 RID: 8323
		[CompilerGenerated]
		private AreaEditor areaEditor_2;

		// Token: 0x04002084 RID: 8324
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_0;

		// Token: 0x04002085 RID: 8325
		[CompilerGenerated]
		private System.Windows.Forms.Label label_9;

		// Token: 0x04002086 RID: 8326
		[CompilerGenerated]
		private System.Windows.Forms.Label label_10;

		// Token: 0x04002087 RID: 8327
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_0;

		// Token: 0x04002088 RID: 8328
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_1;

		// Token: 0x04002089 RID: 8329
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_2;

		// Token: 0x0400208A RID: 8330
		[CompilerGenerated]
		private System.Windows.Forms.Label label_11;

		// Token: 0x0400208B RID: 8331
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_3;

		// Token: 0x0400208C RID: 8332
		[CompilerGenerated]
		private System.Windows.Forms.Label label_12;

		// Token: 0x0400208D RID: 8333
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_6;

		// Token: 0x0400208E RID: 8334
		[CompilerGenerated]
		private TabPage tabPage_5;

		// Token: 0x0400208F RID: 8335
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_7;

		// Token: 0x04002090 RID: 8336
		[CompilerGenerated]
		private AreaEditor areaEditor_3;

		// Token: 0x04002091 RID: 8337
		[CompilerGenerated]
		private System.Windows.Forms.Label label_13;

		// Token: 0x04002092 RID: 8338
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_5;

		// Token: 0x04002093 RID: 8339
		[CompilerGenerated]
		private TabPage tabPage_6;

		// Token: 0x04002094 RID: 8340
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_6;

		// Token: 0x04002095 RID: 8341
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_1;

		// Token: 0x04002096 RID: 8342
		[CompilerGenerated]
		private System.Windows.Forms.RadioButton radioButton_0;

		// Token: 0x04002097 RID: 8343
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_7;

		// Token: 0x04002098 RID: 8344
		[CompilerGenerated]
		private System.Windows.Forms.RadioButton radioButton_1;

		// Token: 0x04002099 RID: 8345
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_2;

		// Token: 0x0400209A RID: 8346
		[CompilerGenerated]
		private System.Windows.Forms.Button button_7;

		// Token: 0x0400209B RID: 8347
		[CompilerGenerated]
		private System.Windows.Forms.Button Button_AddHighlighted;

		// Token: 0x0400209C RID: 8348
		[CompilerGenerated]
		private System.Windows.Forms.ListBox listBox_0;

		// Token: 0x0400209D RID: 8349
		[CompilerGenerated]
		private System.Windows.Forms.Label label_14;

		// Token: 0x0400209E RID: 8350
		[CompilerGenerated]
		private System.Windows.Forms.Label label_15;

		// Token: 0x0400209F RID: 8351
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_4;

		// Token: 0x040020A0 RID: 8352
		[CompilerGenerated]
		private System.Windows.Forms.Button button_9;

		// Token: 0x040020A1 RID: 8353
		[CompilerGenerated]
		private System.Windows.Forms.Button button_10;

		// Token: 0x040020A2 RID: 8354
		[CompilerGenerated]
		private System.Windows.Forms.Label label_16;

		// Token: 0x040020A3 RID: 8355
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_8;

		// Token: 0x040020A4 RID: 8356
		[CompilerGenerated]
		private System.Windows.Forms.TabControl tabControl_0;

		// Token: 0x040020A5 RID: 8357
		[CompilerGenerated]
		private TabPage tabPage_7;

		// Token: 0x040020A6 RID: 8358
		[CompilerGenerated]
		private TabPage tabPage_8;

		// Token: 0x040020A7 RID: 8359
		[CompilerGenerated]
		private AreaEditor areaEditor_4;

		// Token: 0x040020A8 RID: 8360
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_9;

		// Token: 0x040020A9 RID: 8361
		[CompilerGenerated]
		private System.Windows.Forms.Label label_17;

		// Token: 0x040020AA RID: 8362
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_5;

		// Token: 0x040020AB RID: 8363
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_6;

		// Token: 0x040020AC RID: 8364
		[CompilerGenerated]
		private System.Windows.Forms.Label label_18;

		// Token: 0x040020AD RID: 8365
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_10;

		// Token: 0x040020AE RID: 8366
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_7;

		// Token: 0x040020AF RID: 8367
		[CompilerGenerated]
		private System.Windows.Forms.Label label_19;

		// Token: 0x040020B0 RID: 8368
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_8;

		// Token: 0x040020B1 RID: 8369
		[CompilerGenerated]
		private System.Windows.Forms.Label label_20;

		// Token: 0x040020B2 RID: 8370
		[CompilerGenerated]
		private System.Windows.Forms.Label label_21;

		// Token: 0x040020B3 RID: 8371
		[CompilerGenerated]
		private System.Windows.Forms.Label label_22;

		// Token: 0x040020B4 RID: 8372
		[CompilerGenerated]
		private System.Windows.Forms.Label label_23;

		// Token: 0x040020B5 RID: 8373
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_9;

		// Token: 0x040020B6 RID: 8374
		[CompilerGenerated]
		private System.Windows.Forms.Label label_24;

		// Token: 0x040020B7 RID: 8375
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_10;

		// Token: 0x040020B8 RID: 8376
		[CompilerGenerated]
		private System.Windows.Forms.Label label_25;

		// Token: 0x040020B9 RID: 8377
		[CompilerGenerated]
		private System.Windows.Forms.Label label_26;

		// Token: 0x040020BA RID: 8378
		[CompilerGenerated]
		private TableLayoutPanel tableLayoutPanel_0;

		// Token: 0x040020BB RID: 8379
		[CompilerGenerated]
		private System.Windows.Forms.Panel panel_0;

		// Token: 0x040020BC RID: 8380
		[CompilerGenerated]
		private System.Windows.Forms.Panel panel_1;

		// Token: 0x040020BD RID: 8381
		[CompilerGenerated]
		private System.Windows.Forms.Panel panel_2;

		// Token: 0x040020BE RID: 8382
		[CompilerGenerated]
		private System.Windows.Forms.Panel panel_3;

		// Token: 0x040020BF RID: 8383
		[CompilerGenerated]
		private System.Windows.Forms.Panel panel_4;

		// Token: 0x040020C0 RID: 8384
		[CompilerGenerated]
		private System.Windows.Forms.Panel panel_5;

		// Token: 0x040020C1 RID: 8385
		[CompilerGenerated]
		private System.Windows.Forms.Panel panel_6;

		// Token: 0x040020C2 RID: 8386
		[CompilerGenerated]
		private System.Windows.Forms.Label label_27;

		// Token: 0x040020C3 RID: 8387
		[CompilerGenerated]
		private System.Windows.Forms.Label label_28;

		// Token: 0x040020C4 RID: 8388
		[CompilerGenerated]
		private System.Windows.Forms.Label label_29;

		// Token: 0x040020C5 RID: 8389
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_8;

		// Token: 0x040020C6 RID: 8390
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_9;

		// Token: 0x040020C7 RID: 8391
		[CompilerGenerated]
		private System.Windows.Forms.Label label_30;

		// Token: 0x040020C8 RID: 8392
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_10;

		// Token: 0x040020C9 RID: 8393
		[CompilerGenerated]
		private System.Windows.Forms.Label label_31;

		// Token: 0x040020CA RID: 8394
		[CompilerGenerated]
		private System.Windows.Forms.Label label_32;

		// Token: 0x040020CB RID: 8395
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_11;

		// Token: 0x040020CC RID: 8396
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_12;

		// Token: 0x040020CD RID: 8397
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_13;

		// Token: 0x040020CE RID: 8398
		[CompilerGenerated]
		private System.Windows.Forms.Label label_33;

		// Token: 0x040020CF RID: 8399
		[CompilerGenerated]
		private System.Windows.Forms.Label label_34;

		// Token: 0x040020D0 RID: 8400
		[CompilerGenerated]
		private System.Windows.Forms.Label label_35;

		// Token: 0x040020D1 RID: 8401
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_14;

		// Token: 0x040020D2 RID: 8402
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_15;

		// Token: 0x040020D3 RID: 8403
		[CompilerGenerated]
		private System.Windows.Forms.Label label_36;

		// Token: 0x040020D4 RID: 8404
		[CompilerGenerated]
		private System.Windows.Forms.Label label_37;

		// Token: 0x040020D5 RID: 8405
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_16;

		// Token: 0x040020D6 RID: 8406
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_17;

		// Token: 0x040020D7 RID: 8407
		[CompilerGenerated]
		private System.Windows.Forms.Label label_38;

		// Token: 0x040020D8 RID: 8408
		[CompilerGenerated]
		private System.Windows.Forms.Label label_39;

		// Token: 0x040020D9 RID: 8409
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_18;

		// Token: 0x040020DA RID: 8410
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_19;

		// Token: 0x040020DB RID: 8411
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_20;

		// Token: 0x040020DC RID: 8412
		[CompilerGenerated]
		private System.Windows.Forms.Label label_40;

		// Token: 0x040020DD RID: 8413
		[CompilerGenerated]
		private System.Windows.Forms.Label label_41;

		// Token: 0x040020DE RID: 8414
		[CompilerGenerated]
		private System.Windows.Forms.Label label_42;

		// Token: 0x040020DF RID: 8415
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_21;

		// Token: 0x040020E0 RID: 8416
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_22;

		// Token: 0x040020E1 RID: 8417
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_23;

		// Token: 0x040020E2 RID: 8418
		[CompilerGenerated]
		private System.Windows.Forms.Label label_43;

		// Token: 0x040020E3 RID: 8419
		[CompilerGenerated]
		private System.Windows.Forms.Label label_44;

		// Token: 0x040020E4 RID: 8420
		[CompilerGenerated]
		private System.Windows.Forms.Label label_45;

		// Token: 0x040020E5 RID: 8421
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_24;

		// Token: 0x040020E6 RID: 8422
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_3;

		// Token: 0x040020E7 RID: 8423
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_25;

		// Token: 0x040020E8 RID: 8424
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_26;

		// Token: 0x040020E9 RID: 8425
		[CompilerGenerated]
		private System.Windows.Forms.Label label_46;

		// Token: 0x040020EA RID: 8426
		[CompilerGenerated]
		private System.Windows.Forms.Label label_47;

		// Token: 0x040020EB RID: 8427
		[CompilerGenerated]
		private System.Windows.Forms.Label label_48;

		// Token: 0x040020EC RID: 8428
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_27;

		// Token: 0x040020ED RID: 8429
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_4;

		// Token: 0x040020EE RID: 8430
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_5;

		// Token: 0x040020EF RID: 8431
		[CompilerGenerated]
		private System.Windows.Forms.Button button_11;

		// Token: 0x040020F0 RID: 8432
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_6;

		// Token: 0x040020F1 RID: 8433
		[CompilerGenerated]
		private System.Windows.Forms.Label label_49;

		// Token: 0x040020F2 RID: 8434
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_28;

		// Token: 0x040020F3 RID: 8435
		[CompilerGenerated]
		private System.Windows.Forms.Label label_50;

		// Token: 0x040020F4 RID: 8436
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_11;

		// Token: 0x040020F5 RID: 8437
		[CompilerGenerated]
		private System.Windows.Forms.Label label_51;

		// Token: 0x040020F6 RID: 8438
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_7;

		// Token: 0x040020F7 RID: 8439
		[CompilerGenerated]
		private System.Windows.Forms.Label label_52;

		// Token: 0x040020F8 RID: 8440
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_29;

		// Token: 0x040020F9 RID: 8441
		[CompilerGenerated]
		private System.Windows.Forms.Label label_53;

		// Token: 0x040020FA RID: 8442
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_30;

		// Token: 0x040020FB RID: 8443
		[CompilerGenerated]
		private System.Windows.Forms.Label label_54;

		// Token: 0x040020FC RID: 8444
		[CompilerGenerated]
		private System.Windows.Forms.Label label_55;

		// Token: 0x040020FD RID: 8445
		[CompilerGenerated]
		private System.Windows.Forms.Label label_56;

		// Token: 0x040020FE RID: 8446
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_12;

		// Token: 0x040020FF RID: 8447
		[CompilerGenerated]
		private System.Windows.Forms.Label label_57;

		// Token: 0x04002100 RID: 8448
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_13;

		// Token: 0x04002101 RID: 8449
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_8;

		// Token: 0x04002102 RID: 8450
		[CompilerGenerated]
		private System.Windows.Forms.Label label_58;

		// Token: 0x04002103 RID: 8451
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_31;

		// Token: 0x04002104 RID: 8452
		[CompilerGenerated]
		private System.Windows.Forms.Label label_59;

		// Token: 0x04002105 RID: 8453
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_32;

		// Token: 0x04002106 RID: 8454
		[CompilerGenerated]
		private System.Windows.Forms.Label label_60;

		// Token: 0x04002107 RID: 8455
		[CompilerGenerated]
		private System.Windows.Forms.Label label_61;

		// Token: 0x04002108 RID: 8456
		[CompilerGenerated]
		private System.Windows.Forms.Label label_62;

		// Token: 0x04002109 RID: 8457
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_14;

		// Token: 0x0400210A RID: 8458
		[CompilerGenerated]
		private System.Windows.Forms.Label label_63;

		// Token: 0x0400210B RID: 8459
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_15;

		// Token: 0x0400210C RID: 8460
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_9;

		// Token: 0x0400210D RID: 8461
		[CompilerGenerated]
		private System.Windows.Forms.Label label_64;

		// Token: 0x0400210E RID: 8462
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_33;

		// Token: 0x0400210F RID: 8463
		[CompilerGenerated]
		private System.Windows.Forms.Label label_65;

		// Token: 0x04002110 RID: 8464
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_34;

		// Token: 0x04002111 RID: 8465
		[CompilerGenerated]
		private System.Windows.Forms.Label label_66;

		// Token: 0x04002112 RID: 8466
		[CompilerGenerated]
		private System.Windows.Forms.Label label_67;

		// Token: 0x04002113 RID: 8467
		[CompilerGenerated]
		private System.Windows.Forms.Label label_68;

		// Token: 0x04002114 RID: 8468
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_16;

		// Token: 0x04002115 RID: 8469
		[CompilerGenerated]
		private System.Windows.Forms.Label label_69;

		// Token: 0x04002116 RID: 8470
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_17;

		// Token: 0x04002117 RID: 8471
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_35;

		// Token: 0x04002118 RID: 8472
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_18;

		// Token: 0x04002119 RID: 8473
		[CompilerGenerated]
		private System.Windows.Forms.Label label_70;

		// Token: 0x0400211A RID: 8474
		[CompilerGenerated]
		private System.Windows.Forms.Label label_71;

		// Token: 0x0400211B RID: 8475
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_36;

		// Token: 0x0400211C RID: 8476
		[CompilerGenerated]
		private System.Windows.Forms.Label label_72;

		// Token: 0x0400211D RID: 8477
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_37;

		// Token: 0x0400211E RID: 8478
		[CompilerGenerated]
		private System.Windows.Forms.Label label_73;

		// Token: 0x0400211F RID: 8479
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_38;

		// Token: 0x04002120 RID: 8480
		[CompilerGenerated]
		private System.Windows.Forms.Label label_74;

		// Token: 0x04002121 RID: 8481
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_39;

		// Token: 0x04002122 RID: 8482
		[CompilerGenerated]
		private System.Windows.Forms.Label label_75;

		// Token: 0x04002123 RID: 8483
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_40;

		// Token: 0x04002124 RID: 8484
		[CompilerGenerated]
		private System.Windows.Forms.Label label_76;

		// Token: 0x04002125 RID: 8485
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_41;

		// Token: 0x04002126 RID: 8486
		[CompilerGenerated]
		private System.Windows.Forms.Label label_77;

		// Token: 0x04002127 RID: 8487
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_42;

		// Token: 0x04002128 RID: 8488
		[CompilerGenerated]
		private System.Windows.Forms.Label label_78;

		// Token: 0x04002129 RID: 8489
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_43;

		// Token: 0x0400212A RID: 8490
		[CompilerGenerated]
		private System.Windows.Forms.Label label_79;

		// Token: 0x0400212B RID: 8491
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_44;

		// Token: 0x0400212C RID: 8492
		[CompilerGenerated]
		private System.Windows.Forms.Label label_80;

		// Token: 0x0400212D RID: 8493
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_45;

		// Token: 0x0400212E RID: 8494
		[CompilerGenerated]
		private System.Windows.Forms.Label label_81;

		// Token: 0x0400212F RID: 8495
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_46;

		// Token: 0x04002130 RID: 8496
		[CompilerGenerated]
		private System.Windows.Forms.Label label_82;

		// Token: 0x04002131 RID: 8497
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_19;

		// Token: 0x04002132 RID: 8498
		[CompilerGenerated]
		private System.Windows.Forms.Label label_83;

		// Token: 0x04002133 RID: 8499
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_20;

		// Token: 0x04002134 RID: 8500
		[CompilerGenerated]
		private System.Windows.Forms.Label label_84;

		// Token: 0x04002135 RID: 8501
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_47;

		// Token: 0x04002136 RID: 8502
		[CompilerGenerated]
		private System.Windows.Forms.Label label_85;

		// Token: 0x04002137 RID: 8503
		[CompilerGenerated]
		private System.Windows.Forms.Label label_86;

		// Token: 0x04002138 RID: 8504
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox CB_PreplannedOnly;

		// Token: 0x04002139 RID: 8505
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox CB_OneTimeOnly;

		// Token: 0x0400213A RID: 8506
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_10;

		// Token: 0x0400213B RID: 8507
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_48;

		// Token: 0x0400213C RID: 8508
		[CompilerGenerated]
		private System.Windows.Forms.Label label_87;

		// Token: 0x0400213D RID: 8509
		[CompilerGenerated]
		private System.Windows.Forms.Label label_88;

		// Token: 0x0400213E RID: 8510
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_49;

		// Token: 0x0400213F RID: 8511
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_50;

		// Token: 0x04002140 RID: 8512
		[CompilerGenerated]
		private System.Windows.Forms.Label label_89;

		// Token: 0x04002141 RID: 8513
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_13;

		// Token: 0x04002142 RID: 8514
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_14;

		// Token: 0x04002143 RID: 8515
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_15;

		// Token: 0x04002144 RID: 8516
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_16;

		// Token: 0x04002145 RID: 8517
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_17;

		// Token: 0x04002146 RID: 8518
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_18;

		// Token: 0x04002147 RID: 8519
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_19;

		// Token: 0x04002148 RID: 8520
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_51;

		// Token: 0x04002149 RID: 8521
		[CompilerGenerated]
		private System.Windows.Forms.Label label_90;

		// Token: 0x0400214A RID: 8522
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_52;

		// Token: 0x0400214B RID: 8523
		[CompilerGenerated]
		private System.Windows.Forms.Label label_91;

		// Token: 0x0400214C RID: 8524
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_53;

		// Token: 0x0400214D RID: 8525
		[CompilerGenerated]
		private System.Windows.Forms.Label label_92;

		// Token: 0x0400214E RID: 8526
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_54;

		// Token: 0x0400214F RID: 8527
		[CompilerGenerated]
		private System.Windows.Forms.Label label_93;

		// Token: 0x04002150 RID: 8528
		[CompilerGenerated]
		private System.Windows.Forms.Label label_94;

		// Token: 0x04002151 RID: 8529
		[CompilerGenerated]
		private System.Windows.Forms.Label label_95;

		// Token: 0x04002152 RID: 8530
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_21;

		// Token: 0x04002153 RID: 8531
		[CompilerGenerated]
		private System.Windows.Forms.Label label_96;

		// Token: 0x04002154 RID: 8532
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_55;

		// Token: 0x04002155 RID: 8533
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_20;

		// Token: 0x04002156 RID: 8534
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_21;

		// Token: 0x04002157 RID: 8535
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_22;

		// Token: 0x04002158 RID: 8536
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_23;

		// Token: 0x04002159 RID: 8537
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_24;

		// Token: 0x0400215A RID: 8538
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_25;

		// Token: 0x0400215B RID: 8539
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_26;

		// Token: 0x0400215C RID: 8540
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_27;

		// Token: 0x0400215D RID: 8541
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_28;

		// Token: 0x0400215E RID: 8542
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_29;

		// Token: 0x0400215F RID: 8543
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_11;

		// Token: 0x04002160 RID: 8544
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_56;

		// Token: 0x04002161 RID: 8545
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_22;

		// Token: 0x04002162 RID: 8546
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_23;

		// Token: 0x04002163 RID: 8547
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_24;

		// Token: 0x04002164 RID: 8548
		[CompilerGenerated]
		private System.Windows.Forms.Label label_97;

		// Token: 0x04002165 RID: 8549
		[CompilerGenerated]
		private System.Windows.Forms.Label label_98;

		// Token: 0x04002166 RID: 8550
		[CompilerGenerated]
		private System.Windows.Forms.Label label_99;

		// Token: 0x04002167 RID: 8551
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_57;

		// Token: 0x04002168 RID: 8552
		[CompilerGenerated]
		private System.Windows.Forms.Label label_100;

		// Token: 0x04002169 RID: 8553
		[CompilerGenerated]
		private System.Windows.Forms.Label label_101;

		// Token: 0x0400216A RID: 8554
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_58;

		// Token: 0x0400216B RID: 8555
		[CompilerGenerated]
		private System.Windows.Forms.Label label_102;

		// Token: 0x0400216C RID: 8556
		[CompilerGenerated]
		private System.Windows.Forms.Label label_103;

		// Token: 0x0400216D RID: 8557
		[CompilerGenerated]
		private System.Windows.Forms.Label label_104;

		// Token: 0x0400216E RID: 8558
		[CompilerGenerated]
		private System.Windows.Forms.Label label_105;

		// Token: 0x0400216F RID: 8559
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_12;

		// Token: 0x04002170 RID: 8560
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_59;

		// Token: 0x04002171 RID: 8561
		[CompilerGenerated]
		private System.Windows.Forms.Label label_106;

		// Token: 0x04002172 RID: 8562
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_60;

		// Token: 0x04002173 RID: 8563
		[CompilerGenerated]
		private System.Windows.Forms.Label label_107;

		// Token: 0x04002174 RID: 8564
		[CompilerGenerated]
		private System.Windows.Forms.Label label_108;

		// Token: 0x04002175 RID: 8565
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_61;

		// Token: 0x04002176 RID: 8566
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_13;

		// Token: 0x04002177 RID: 8567
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_62;

		// Token: 0x04002178 RID: 8568
		[CompilerGenerated]
		private System.Windows.Forms.Label label_109;

		// Token: 0x04002179 RID: 8569
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_63;

		// Token: 0x0400217A RID: 8570
		[CompilerGenerated]
		private System.Windows.Forms.Label label_110;

		// Token: 0x0400217B RID: 8571
		[CompilerGenerated]
		private System.Windows.Forms.Label label_111;

		// Token: 0x0400217C RID: 8572
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_64;

		// Token: 0x0400217D RID: 8573
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_14;

		// Token: 0x0400217E RID: 8574
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_25;

		// Token: 0x0400217F RID: 8575
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_65;

		// Token: 0x04002180 RID: 8576
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_26;

		// Token: 0x04002181 RID: 8577
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_66;

		// Token: 0x04002182 RID: 8578
		[CompilerGenerated]
		private System.Windows.Forms.Label label_112;

		// Token: 0x04002183 RID: 8579
		[CompilerGenerated]
		private System.Windows.Forms.Label label_113;

		// Token: 0x04002184 RID: 8580
		[CompilerGenerated]
		private System.Windows.Forms.Label label_114;

		// Token: 0x04002185 RID: 8581
		[CompilerGenerated]
		private System.Windows.Forms.Label label_115;

		// Token: 0x04002186 RID: 8582
		[CompilerGenerated]
		private System.Windows.Forms.Label label_116;

		// Token: 0x04002187 RID: 8583
		[CompilerGenerated]
		private System.Windows.Forms.Label label_117;

		// Token: 0x04002188 RID: 8584
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_15;

		// Token: 0x04002189 RID: 8585
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_67;

		// Token: 0x0400218A RID: 8586
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_68;

		// Token: 0x0400218B RID: 8587
		[CompilerGenerated]
		private System.Windows.Forms.Label label_118;

		// Token: 0x0400218C RID: 8588
		[CompilerGenerated]
		private System.Windows.Forms.Label label_119;

		// Token: 0x0400218D RID: 8589
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_16;

		// Token: 0x0400218E RID: 8590
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_69;

		// Token: 0x0400218F RID: 8591
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_70;

		// Token: 0x04002190 RID: 8592
		[CompilerGenerated]
		private System.Windows.Forms.Label label_120;

		// Token: 0x04002191 RID: 8593
		[CompilerGenerated]
		private System.Windows.Forms.Label label_121;

		// Token: 0x04002192 RID: 8594
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_30;

		// Token: 0x04002193 RID: 8595
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_31;

		// Token: 0x04002194 RID: 8596
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_17;

		// Token: 0x04002195 RID: 8597
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_71;

		// Token: 0x04002196 RID: 8598
		[CompilerGenerated]
		private System.Windows.Forms.Label label_122;

		// Token: 0x04002197 RID: 8599
		[CompilerGenerated]
		private System.Windows.Forms.Label label_123;

		// Token: 0x04002198 RID: 8600
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_72;

		// Token: 0x04002199 RID: 8601
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_18;

		// Token: 0x0400219A RID: 8602
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_73;

		// Token: 0x0400219B RID: 8603
		[CompilerGenerated]
		private System.Windows.Forms.Label label_124;

		// Token: 0x0400219C RID: 8604
		[CompilerGenerated]
		private System.Windows.Forms.Label label_125;

		// Token: 0x0400219D RID: 8605
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_74;

		// Token: 0x0400219E RID: 8606
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_19;

		// Token: 0x0400219F RID: 8607
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_27;

		// Token: 0x040021A0 RID: 8608
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_28;

		// Token: 0x040021A1 RID: 8609
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_75;

		// Token: 0x040021A2 RID: 8610
		[CompilerGenerated]
		private System.Windows.Forms.Label label_126;

		// Token: 0x040021A3 RID: 8611
		[CompilerGenerated]
		private System.Windows.Forms.Label label_127;

		// Token: 0x040021A4 RID: 8612
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_76;

		// Token: 0x040021A5 RID: 8613
		[CompilerGenerated]
		private System.Windows.Forms.Label label_128;

		// Token: 0x040021A6 RID: 8614
		[CompilerGenerated]
		private System.Windows.Forms.Label label_129;

		// Token: 0x040021A7 RID: 8615
		[CompilerGenerated]
		private System.Windows.Forms.Label label_130;

		// Token: 0x040021A8 RID: 8616
		[CompilerGenerated]
		private System.Windows.Forms.Label label_131;

		// Token: 0x040021A9 RID: 8617
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_20;

		// Token: 0x040021AA RID: 8618
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_77;

		// Token: 0x040021AB RID: 8619
		[CompilerGenerated]
		private System.Windows.Forms.Label label_132;

		// Token: 0x040021AC RID: 8620
		[CompilerGenerated]
		private System.Windows.Forms.Label label_133;

		// Token: 0x040021AD RID: 8621
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_78;

		// Token: 0x040021AE RID: 8622
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_21;

		// Token: 0x040021AF RID: 8623
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_79;

		// Token: 0x040021B0 RID: 8624
		[CompilerGenerated]
		private System.Windows.Forms.Label label_134;

		// Token: 0x040021B1 RID: 8625
		[CompilerGenerated]
		private System.Windows.Forms.Label label_135;

		// Token: 0x040021B2 RID: 8626
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_80;

		// Token: 0x040021B3 RID: 8627
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_22;

		// Token: 0x040021B4 RID: 8628
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_29;

		// Token: 0x040021B5 RID: 8629
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_30;

		// Token: 0x040021B6 RID: 8630
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_81;

		// Token: 0x040021B7 RID: 8631
		[CompilerGenerated]
		private System.Windows.Forms.Label label_136;

		// Token: 0x040021B8 RID: 8632
		[CompilerGenerated]
		private System.Windows.Forms.Label label_137;

		// Token: 0x040021B9 RID: 8633
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_82;

		// Token: 0x040021BA RID: 8634
		[CompilerGenerated]
		private System.Windows.Forms.Label label_138;

		// Token: 0x040021BB RID: 8635
		[CompilerGenerated]
		private System.Windows.Forms.Label label_139;

		// Token: 0x040021BC RID: 8636
		[CompilerGenerated]
		private System.Windows.Forms.Label label_140;

		// Token: 0x040021BD RID: 8637
		[CompilerGenerated]
		private System.Windows.Forms.Label label_141;

		// Token: 0x040021BE RID: 8638
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_23;

		// Token: 0x040021BF RID: 8639
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_0;

		// Token: 0x040021C0 RID: 8640
		[CompilerGenerated]
		private DateTimePicker DateTimePicker_ActivationDate;

		// Token: 0x040021C1 RID: 8641
		[CompilerGenerated]
		private System.Windows.Forms.Label label_142;

		// Token: 0x040021C2 RID: 8642
		[CompilerGenerated]
		private System.Windows.Forms.Label label_143;

		// Token: 0x040021C3 RID: 8643
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_24;

		// Token: 0x040021C4 RID: 8644
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_2;

		// Token: 0x040021C5 RID: 8645
		[CompilerGenerated]
		private System.Windows.Forms.Label label_144;

		// Token: 0x040021C6 RID: 8646
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_3;

		// Token: 0x040021C7 RID: 8647
		[CompilerGenerated]
		private System.Windows.Forms.Label label_145;

		// Token: 0x040021C8 RID: 8648
		[CompilerGenerated]
		private System.Windows.Forms.Button button_12;

		// Token: 0x040021C9 RID: 8649
		[CompilerGenerated]
		private System.Windows.Forms.Button button_13;

		// Token: 0x040021CA RID: 8650
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_83;

		// Token: 0x040021CB RID: 8651
		[CompilerGenerated]
		private System.Windows.Forms.Label label_146;

		// Token: 0x040021CC RID: 8652
		[CompilerGenerated]
		private System.Windows.Forms.Button button_14;

		// Token: 0x040021CD RID: 8653
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_84;

		// Token: 0x040021CE RID: 8654
		[CompilerGenerated]
		private System.Windows.Forms.Label label_147;

		// Token: 0x040021CF RID: 8655
		[CompilerGenerated]
		private System.Windows.Forms.Button button_15;

		// Token: 0x040021D0 RID: 8656
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_85;

		// Token: 0x040021D1 RID: 8657
		[CompilerGenerated]
		private System.Windows.Forms.Label label_148;

		// Token: 0x040021D2 RID: 8658
		[CompilerGenerated]
		private System.Windows.Forms.Button button_16;

		// Token: 0x040021D3 RID: 8659
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_86;

		// Token: 0x040021D4 RID: 8660
		[CompilerGenerated]
		private System.Windows.Forms.Label label_149;

		// Token: 0x040021D5 RID: 8661
		[CompilerGenerated]
		private System.Windows.Forms.Button button_17;

		// Token: 0x040021D6 RID: 8662
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_87;

		// Token: 0x040021D7 RID: 8663
		[CompilerGenerated]
		private System.Windows.Forms.Label label_150;

		// Token: 0x040021D8 RID: 8664
		[CompilerGenerated]
		private System.Windows.Forms.Button button_18;

		// Token: 0x040021D9 RID: 8665
		[CompilerGenerated]
		private System.Windows.Forms.Button button_19;

		// Token: 0x040021DA RID: 8666
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_88;

		// Token: 0x040021DB RID: 8667
		[CompilerGenerated]
		private System.Windows.Forms.Label label_151;

		// Token: 0x040021DC RID: 8668
		[CompilerGenerated]
		private System.Windows.Forms.Label label_152;

		// Token: 0x040021DD RID: 8669
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_89;

		// Token: 0x040021DE RID: 8670
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_90;

		// Token: 0x040021DF RID: 8671
		[CompilerGenerated]
		private System.Windows.Forms.Label label_153;

		// Token: 0x040021E0 RID: 8672
		[CompilerGenerated]
		private System.Windows.Forms.Label label_154;

		// Token: 0x040021E1 RID: 8673
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_91;

		// Token: 0x040021E2 RID: 8674
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_92;

		// Token: 0x040021E3 RID: 8675
		[CompilerGenerated]
		private System.Windows.Forms.Label label_155;

		// Token: 0x040021E4 RID: 8676
		[CompilerGenerated]
		private System.Windows.Forms.Label label_156;

		// Token: 0x040021E5 RID: 8677
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_93;

		// Token: 0x040021E6 RID: 8678
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_94;

		// Token: 0x040021E7 RID: 8679
		[CompilerGenerated]
		private System.Windows.Forms.Label label_157;

		// Token: 0x040021E8 RID: 8680
		[CompilerGenerated]
		private System.Windows.Forms.Label label_158;

		// Token: 0x040021E9 RID: 8681
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_95;

		// Token: 0x040021EA RID: 8682
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_96;

		// Token: 0x040021EB RID: 8683
		[CompilerGenerated]
		private System.Windows.Forms.Label label_159;

		// Token: 0x040021EC RID: 8684
		[CompilerGenerated]
		private System.Windows.Forms.Label label_160;

		// Token: 0x040021ED RID: 8685
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_97;

		// Token: 0x040021EE RID: 8686
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_32;

		// Token: 0x040021EF RID: 8687
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_31;

		// Token: 0x040021F0 RID: 8688
		[CompilerGenerated]
		private System.Windows.Forms.Label label_161;

		// Token: 0x040021F1 RID: 8689
		[CompilerGenerated]
		private System.Windows.Forms.Label label_162;

		// Token: 0x040021F2 RID: 8690
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_32;

		// Token: 0x040021F3 RID: 8691
		[CompilerGenerated]
		private System.Windows.Forms.Label label_163;

		// Token: 0x040021F4 RID: 8692
		[CompilerGenerated]
		private System.Windows.Forms.Label label_164;

		// Token: 0x040021F5 RID: 8693
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_33;

		// Token: 0x040021F6 RID: 8694
		[CompilerGenerated]
		private System.Windows.Forms.Label label_165;

		// Token: 0x040021F7 RID: 8695
		[CompilerGenerated]
		private System.Windows.Forms.Label label_166;

		// Token: 0x040021F8 RID: 8696
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_34;

		// Token: 0x040021F9 RID: 8697
		[CompilerGenerated]
		private System.Windows.Forms.Label label_167;

		// Token: 0x040021FA RID: 8698
		[CompilerGenerated]
		private System.Windows.Forms.Label label_168;

		// Token: 0x040021FB RID: 8699
		[CompilerGenerated]
		private System.Windows.Forms.Label label_169;

		// Token: 0x040021FC RID: 8700
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_35;

		// Token: 0x040021FD RID: 8701
		[CompilerGenerated]
		private System.Windows.Forms.Label label_170;

		// Token: 0x040021FE RID: 8702
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_33;

		// Token: 0x040021FF RID: 8703
		[CompilerGenerated]
		private System.Windows.Forms.Label label_171;

		// Token: 0x04002200 RID: 8704
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_98;

		// Token: 0x04002201 RID: 8705
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_34;

		// Token: 0x04002202 RID: 8706
		[CompilerGenerated]
		private System.Windows.Forms.Label label_172;

		// Token: 0x04002203 RID: 8707
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_99;

		// Token: 0x04002204 RID: 8708
		[CompilerGenerated]
		private System.Windows.Forms.Label label_173;

		// Token: 0x04002205 RID: 8709
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_100;

		// Token: 0x04002206 RID: 8710
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_35;

		// Token: 0x04002207 RID: 8711
		[CompilerGenerated]
		private System.Windows.Forms.Label label_174;

		// Token: 0x04002208 RID: 8712
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_101;

		// Token: 0x04002209 RID: 8713
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_36;

		// Token: 0x0400220A RID: 8714
		[CompilerGenerated]
		private System.Windows.Forms.Label label_175;

		// Token: 0x0400220B RID: 8715
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_102;

		// Token: 0x0400220C RID: 8716
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_37;

		// Token: 0x0400220D RID: 8717
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_38;

		// Token: 0x0400220E RID: 8718
		[CompilerGenerated]
		private System.Windows.Forms.Label label_176;

		// Token: 0x0400220F RID: 8719
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_103;

		// Token: 0x04002210 RID: 8720
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_39;

		// Token: 0x04002211 RID: 8721
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_40;

		// Token: 0x04002212 RID: 8722
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_41;

		// Token: 0x04002213 RID: 8723
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_42;

		// Token: 0x04002214 RID: 8724
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_43;

		// Token: 0x04002215 RID: 8725
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_44;

		// Token: 0x04002216 RID: 8726
		[CompilerGenerated]
		private System.Windows.Forms.TabControl tabControl_1;

		// Token: 0x04002217 RID: 8727
		[CompilerGenerated]
		private TabPage tabPage_9;

		// Token: 0x04002218 RID: 8728
		[CompilerGenerated]
		private TabPage tabPage_10;

		// Token: 0x04002219 RID: 8729
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_104;

		// Token: 0x0400221A RID: 8730
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_105;

		// Token: 0x0400221B RID: 8731
		[CompilerGenerated]
		private System.Windows.Forms.Label label_177;

		// Token: 0x0400221C RID: 8732
		[CompilerGenerated]
		private System.Windows.Forms.Label label_178;

		// Token: 0x0400221D RID: 8733
		[CompilerGenerated]
		private System.Windows.Forms.TabControl tabControl_2;

		// Token: 0x0400221E RID: 8734
		[CompilerGenerated]
		private TabPage tabPage_11;

		// Token: 0x0400221F RID: 8735
		[CompilerGenerated]
		private TabPage tabPage_12;

		// Token: 0x04002220 RID: 8736
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_106;

		// Token: 0x04002221 RID: 8737
		[CompilerGenerated]
		private System.Windows.Forms.Label label_179;

		// Token: 0x04002222 RID: 8738
		[CompilerGenerated]
		private TabPage tabPage_13;

		// Token: 0x04002223 RID: 8739
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_107;

		// Token: 0x04002224 RID: 8740
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_108;

		// Token: 0x04002225 RID: 8741
		[CompilerGenerated]
		private System.Windows.Forms.Label label_180;

		// Token: 0x04002226 RID: 8742
		[CompilerGenerated]
		private System.Windows.Forms.Label label_181;

		// Token: 0x04002227 RID: 8743
		[CompilerGenerated]
		private ElementHost elementHost_0;

		// Token: 0x04002228 RID: 8744
		[CompilerGenerated]
		private System.Windows.Forms.TabControl tabControl_3;

		// Token: 0x04002229 RID: 8745
		[CompilerGenerated]
		private TabPage tabPage_14;

		// Token: 0x0400222A RID: 8746
		[CompilerGenerated]
		private TabPage tabPage_15;

		// Token: 0x0400222B RID: 8747
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_109;

		// Token: 0x0400222C RID: 8748
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_110;

		// Token: 0x0400222D RID: 8749
		[CompilerGenerated]
		private System.Windows.Forms.Label label_182;

		// Token: 0x0400222E RID: 8750
		[CompilerGenerated]
		private System.Windows.Forms.Label label_183;

		// Token: 0x0400222F RID: 8751
		[CompilerGenerated]
		private System.Windows.Forms.TabControl tabControl_4;

		// Token: 0x04002231 RID: 8753
		[CompilerGenerated]
		private TabPage tabPage_16;

		// Token: 0x04002232 RID: 8754
		[CompilerGenerated]
		private TabPage tabPage_17;

		// Token: 0x04002233 RID: 8755
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_111;

		// Token: 0x04002234 RID: 8756
		[CompilerGenerated]
		private System.Windows.Forms.Label label_184;

		// Token: 0x04002235 RID: 8757
		[CompilerGenerated]
		private System.Windows.Forms.TabControl tabControl_5;

		// Token: 0x04002236 RID: 8758
		[CompilerGenerated]
		private TabPage tabPage_18;

		// Token: 0x04002237 RID: 8759
		[CompilerGenerated]
		private TabPage tabPage_19;

		// Token: 0x04002238 RID: 8760
		[CompilerGenerated]
		private System.Windows.Forms.TabControl tabControl_6;

		// Token: 0x04002239 RID: 8761
		[CompilerGenerated]
		private TabPage tabPage_20;

		// Token: 0x0400223A RID: 8762
		[CompilerGenerated]
		private TabPage tabPage_21;

		// Token: 0x0400223B RID: 8763
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_112;

		// Token: 0x0400223C RID: 8764
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_113;

		// Token: 0x0400223D RID: 8765
		[CompilerGenerated]
		private System.Windows.Forms.Label label_185;

		// Token: 0x0400223E RID: 8766
		[CompilerGenerated]
		private System.Windows.Forms.Label label_186;

		// Token: 0x0400223F RID: 8767
		[CompilerGenerated]
		private System.Windows.Forms.TabControl tabControl_7;

		// Token: 0x04002240 RID: 8768
		[CompilerGenerated]
		private TabPage tabPage_22;

		// Token: 0x04002241 RID: 8769
		[CompilerGenerated]
		private TabPage tabPage_23;

		// Token: 0x04002242 RID: 8770
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_114;

		// Token: 0x04002243 RID: 8771
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_115;

		// Token: 0x04002244 RID: 8772
		[CompilerGenerated]
		private System.Windows.Forms.Label label_187;

		// Token: 0x04002245 RID: 8773
		[CompilerGenerated]
		private System.Windows.Forms.Label label_188;

		// Token: 0x04002246 RID: 8774
		[CompilerGenerated]
		private System.Windows.Forms.Button Button_FlightPlanEditor_Strike;

		// Token: 0x04002247 RID: 8775
		[CompilerGenerated]
		private System.Windows.Forms.Button button_21;

		// Token: 0x04002248 RID: 8776
		[CompilerGenerated]
		private System.Windows.Forms.Button button_22;

		// Token: 0x04002249 RID: 8777
		[CompilerGenerated]
		private System.Windows.Forms.Button button_23;

		// Token: 0x0400224A RID: 8778
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_45;

		// Token: 0x0400224B RID: 8779
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_46;

		// Token: 0x0400224C RID: 8780
		[CompilerGenerated]
		private System.Windows.Forms.Button button_24;

		// Token: 0x0400224D RID: 8781
		[CompilerGenerated]
		private System.Windows.Forms.Button button_25;

		// Token: 0x0400224E RID: 8782
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_47;

		// Token: 0x0400224F RID: 8783
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_48;

		// Token: 0x04002250 RID: 8784
		[CompilerGenerated]
		private System.Windows.Forms.Button button_26;

		// Token: 0x04002251 RID: 8785
		[CompilerGenerated]
		private System.Windows.Forms.Button button_27;

		// Token: 0x04002252 RID: 8786
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_49;

		// Token: 0x04002253 RID: 8787
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_50;

		// Token: 0x04002254 RID: 8788
		[CompilerGenerated]
		private System.Windows.Forms.Button button_28;

		// Token: 0x04002255 RID: 8789
		[CompilerGenerated]
		private System.Windows.Forms.Button button_29;

		// Token: 0x04002256 RID: 8790
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_51;

		// Token: 0x04002257 RID: 8791
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_52;

		// Token: 0x04002258 RID: 8792
		[CompilerGenerated]
		private System.Windows.Forms.Button button_30;

		// Token: 0x04002259 RID: 8793
		[CompilerGenerated]
		private System.Windows.Forms.Button button_31;

		// Token: 0x0400225A RID: 8794
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_53;

		// Token: 0x0400225B RID: 8795
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_54;

		// Token: 0x0400225C RID: 8796
		[CompilerGenerated]
		private System.Windows.Forms.Button button_32;

		// Token: 0x0400225D RID: 8797
		[CompilerGenerated]
		private System.Windows.Forms.Button button_33;

		// Token: 0x0400225E RID: 8798
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_55;

		// Token: 0x0400225F RID: 8799
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_56;

		// Token: 0x04002260 RID: 8800
		[CompilerGenerated]
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x04002261 RID: 8801
		[CompilerGenerated]
		private System.Windows.Forms.Panel panel_7;

		// Token: 0x04002262 RID: 8802
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_25;

		// Token: 0x04002263 RID: 8803
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_4;

		// Token: 0x04002264 RID: 8804
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_5;

		// Token: 0x04002265 RID: 8805
		[CompilerGenerated]
		private System.Windows.Forms.Label label_189;

		// Token: 0x04002266 RID: 8806
		[CompilerGenerated]
		private System.Windows.Forms.Label label_190;

		// Token: 0x04002267 RID: 8807
		[CompilerGenerated]
		private System.Windows.Forms.GroupBox groupBox_26;

		// Token: 0x04002268 RID: 8808
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_6;

		// Token: 0x04002269 RID: 8809
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_7;

		// Token: 0x0400226A RID: 8810
		[CompilerGenerated]
		private System.Windows.Forms.Label label_191;

		// Token: 0x0400226B RID: 8811
		[CompilerGenerated]
		private System.Windows.Forms.Label label_192;

		// Token: 0x0400226C RID: 8812
		[CompilerGenerated]
		private System.Windows.Forms.Button button_34;

		// Token: 0x0400226D RID: 8813
		[CompilerGenerated]
		private System.Windows.Forms.Button button_35;

		// Token: 0x0400226E RID: 8814
		[CompilerGenerated]
		private TabPage tabPage_24;

		// Token: 0x0400226F RID: 8815
		[CompilerGenerated]
		private System.Windows.Forms.Button Button_CreateFlightPlans_Strike;

		// Token: 0x04002270 RID: 8816
		[CompilerGenerated]
		private System.Windows.Forms.Button Button_FillEmptySlots_Strike;

		// Token: 0x04002271 RID: 8817
		[CompilerGenerated]
		private System.Windows.Forms.Label label_193;

		// Token: 0x04002272 RID: 8818
		[CompilerGenerated]
		private AreaEditor areaEditor_5;

		// Token: 0x04002273 RID: 8819
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_116;

		// Token: 0x04002274 RID: 8820
		[AccessedThroughProperty("Button_DeleteAllFlightplans"), CompilerGenerated]
		private System.Windows.Forms.Button Button_DeleteAllFlightplans;

		// Token: 0x04002275 RID: 8821
		[AccessedThroughProperty("Button_CreateAllFlightplans"), CompilerGenerated]
		private System.Windows.Forms.Button Button_CreateAllFlightplans;

		// Token: 0x04002276 RID: 8822
		private ActiveUnit SelectedUnit;

		// Token: 0x04002277 RID: 8823
		private Mission SelectedMission;

		// Token: 0x04002278 RID: 8824
		private bool bool_0;

		// Token: 0x04002279 RID: 8825
		private bool bool_1;

		// Token: 0x0400227A RID: 8826
		private bool bool_2 = false;

		// Token: 0x0400227B RID: 8827
		private bool bool_3;

		// Token: 0x0400227C RID: 8828
		private bool bool_4;

		// Token: 0x0400227D RID: 8829
		private bool bool_5;

		// Token: 0x0400227E RID: 8830
		private bool bool_6;

		// Token: 0x0400227F RID: 8831
		private bool bool_7;

		// Token: 0x04002280 RID: 8832
		private bool bool_8;

		// Token: 0x04002281 RID: 8833
		private bool bool_9;

		// Token: 0x04002282 RID: 8834
		private bool bool_10;

		// Token: 0x04002283 RID: 8835
		private bool bool_11;

		// Token: 0x04002284 RID: 8836
		private bool bool_12;

		// Token: 0x04002285 RID: 8837
		private bool bool_13;

		// Token: 0x04002286 RID: 8838
		private bool bool_14;

		// Token: 0x04002287 RID: 8839
		private bool bool_15;

		// Token: 0x04002288 RID: 8840
		private bool bool_16;

		// Token: 0x04002289 RID: 8841
		private bool bool_17;

		// Token: 0x0400228A RID: 8842
		private bool bool_18;

		// Token: 0x0400228B RID: 8843
		private bool bool_19;

		// Token: 0x0400228C RID: 8844
		private bool bool_20;

		// Token: 0x0400228D RID: 8845
		private bool bool_21;

		// Token: 0x0400228E RID: 8846
		private bool bool_22;

		// Token: 0x0400228F RID: 8847
		private bool bool_23;

		// Token: 0x04002290 RID: 8848
		private bool bool_24;

		// Token: 0x04002291 RID: 8849
		private bool bool_25;

		// Token: 0x04002292 RID: 8850
		private bool bool_26;

		// Token: 0x04002293 RID: 8851
		private bool bool_27;

		// Token: 0x04002294 RID: 8852
		private bool bool_28;

		// Token: 0x04002295 RID: 8853
		private bool bool_29;

		// Token: 0x04002296 RID: 8854
		private bool bool_30;

		// Token: 0x04002297 RID: 8855
		private bool bool_31;

		// Token: 0x04002298 RID: 8856
		private bool bool_32;

		// Token: 0x04002299 RID: 8857
		[CompilerGenerated]
		private static MissionEditor.Delegate64 delegate64_0;

		// Token: 0x020009D5 RID: 2517
		// (Invoke) Token: 0x060049E0 RID: 18912
		public delegate void Delegate64(Subject theSubject);
	}
}

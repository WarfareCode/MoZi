using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns2;
using ns3;
using ns32;
using ns33;
using ns4;

namespace Command
{
	// Token: 0x02000AEA RID: 2794
	[DesignerGenerated]
	public sealed partial class AttackTarget : CommandForm
	{
		// Token: 0x060059A0 RID: 22944 RVA: 0x0027A940 File Offset: 0x00278B40
		public AttackTarget()
		{
			base.FormClosing += new FormClosingEventHandler(this.AttackTarget_FormClosing);
			base.Load += new EventHandler(this.AttackTarget_Load);
			base.KeyDown += new KeyEventHandler(this.AttackTarget_KeyDown);
			this.TargetList = new List<Contact>();
			this.list_1 = new List<ActiveUnit>();
			this.list_2 = new List<ActiveUnit>();
			this.list_3 = new List<Contact>();
			this.bool_1 = true;
			this.InitializeComponent();
		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x0027A9CC File Offset: 0x00278BCC
		private void AttackTarget_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.bool_0 && Client.GetCommandOrder() != Client._CommandOrder.AddNewWeaponWaypoint)
			{
				Client.GetConfiguration().SetSimRunMode();
			}
			CommandFactory.GetCommandMain().GetMainForm().GetMapBox().Focus();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x060059A2 RID: 22946 RVA: 0x0027AA20 File Offset: 0x00278C20
		private void AttackTarget_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F1 && e.Modifiers == Keys.Shift && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060059A3 RID: 22947 RVA: 0x000286E2 File Offset: 0x000268E2
		private void AttackTarget_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_16().Interval = 1000;
			this.vmethod_16().Start();
			this.method_1();
		}

		// Token: 0x060059A6 RID: 22950 RVA: 0x0027C718 File Offset: 0x0027A918
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x060059A7 RID: 22951 RVA: 0x0002871D File Offset: 0x0002691D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_5)
		{
			this.label_0 = label_5;
		}

		// Token: 0x060059A8 RID: 22952 RVA: 0x0027C730 File Offset: 0x0027A930
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_1;
		}

		// Token: 0x060059A9 RID: 22953 RVA: 0x00028726 File Offset: 0x00026926
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_5)
		{
			this.label_1 = label_5;
		}

		// Token: 0x060059AA RID: 22954 RVA: 0x0027C748 File Offset: 0x0027A948
		[CompilerGenerated]
		internal  TabControl vmethod_4()
		{
			return this.tabControl_0;
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x0027C760 File Offset: 0x0027A960
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TabControl tabControl_2)
		{
			EventHandler value = new EventHandler(this.method_41);
			TabControl tabControl = this.tabControl_0;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged -= value;
			}
			this.tabControl_0 = tabControl_2;
			tabControl = this.tabControl_0;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged += value;
			}
		}

		// Token: 0x060059AC RID: 22956 RVA: 0x0027C7AC File Offset: 0x0027A9AC
		[CompilerGenerated]
		internal  TabPage GetTab_Target_BySelected()
		{
			return this.tabPage_0;
		}

		// Token: 0x060059AD RID: 22957 RVA: 0x0002872F File Offset: 0x0002692F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TabPage tabPage_4)
		{
			this.tabPage_0 = tabPage_4;
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x0027C7C4 File Offset: 0x0027A9C4
		[CompilerGenerated]
		internal  TabPage GetTab_Target_ByAnyone()
		{
			return this.tabPage_1;
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x00028738 File Offset: 0x00026938
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TabPage tabPage_4)
		{
			this.tabPage_1 = tabPage_4;
		}

		// Token: 0x060059B0 RID: 22960 RVA: 0x0027C7DC File Offset: 0x0027A9DC
		[CompilerGenerated]
		internal  ListBox vmethod_10()
		{
			return this.listBox_0;
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x0027C7F4 File Offset: 0x0027A9F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ListBox listBox_2)
		{
			EventHandler value = new EventHandler(this.method_15);
			ListBox listBox = this.listBox_0;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value;
			}
			this.listBox_0 = listBox_2;
			listBox = this.listBox_0;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x0027C840 File Offset: 0x0027AA40
		[CompilerGenerated]
		internal  TreeView GetTV_Allocations_ByAttackersOnly()
		{
			return this.TV_Allocations_ByAttackersOnl;
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x0027C858 File Offset: 0x0027AA58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetTV_Allocations_ByAttackersOnly(TreeView treeView_5)
		{
			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.TV_Allocations_ByAttackersOnly_NodeMouseDoubleClick);
			TreeViewEventHandler value2 = new TreeViewEventHandler(this.TV_Allocations_ByAttackersOnly_AfterSelect);
			MouseEventHandler value3 = new MouseEventHandler(this.TV_Allocations_ByAttackersOnly_MouseClick);
			TreeView tV_Allocations_ByAttackersOnl = this.TV_Allocations_ByAttackersOnl;
			if (tV_Allocations_ByAttackersOnl != null)
			{
				tV_Allocations_ByAttackersOnl.NodeMouseDoubleClick -= value;
				tV_Allocations_ByAttackersOnl.AfterSelect -= value2;
				tV_Allocations_ByAttackersOnl.MouseClick -= value3;
			}
			this.TV_Allocations_ByAttackersOnl = treeView_5;
			tV_Allocations_ByAttackersOnl = this.TV_Allocations_ByAttackersOnl;
			if (tV_Allocations_ByAttackersOnl != null)
			{
				tV_Allocations_ByAttackersOnl.NodeMouseDoubleClick += value;
				tV_Allocations_ByAttackersOnl.AfterSelect += value2;
				tV_Allocations_ByAttackersOnl.MouseClick += value3;
			}
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x0027C8D8 File Offset: 0x0027AAD8
		[CompilerGenerated]
		internal  TreeView GetTV_Allocations_ByAnyone()
		{
			return this.TV_Allocations_ByAnyone;
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x0027C8F0 File Offset: 0x0027AAF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetTV_Allocations_ByAnyone(TreeView treeView_5)
		{
			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.method_39);
			TreeViewEventHandler value2 = new TreeViewEventHandler(this.method_45);
			MouseEventHandler value3 = new MouseEventHandler(this.method_54);
			TreeView tV_Allocations_ByAnyone = this.TV_Allocations_ByAnyone;
			if (tV_Allocations_ByAnyone != null)
			{
				tV_Allocations_ByAnyone.NodeMouseDoubleClick -= value;
				tV_Allocations_ByAnyone.AfterSelect -= value2;
				tV_Allocations_ByAnyone.MouseClick -= value3;
			}
			this.TV_Allocations_ByAnyone = treeView_5;
			tV_Allocations_ByAnyone = this.TV_Allocations_ByAnyone;
			if (tV_Allocations_ByAnyone != null)
			{
				tV_Allocations_ByAnyone.NodeMouseDoubleClick += value;
				tV_Allocations_ByAnyone.AfterSelect += value2;
				tV_Allocations_ByAnyone.MouseClick += value3;
			}
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x0027C970 File Offset: 0x0027AB70
		[CompilerGenerated]
		internal  Timer vmethod_16()
		{
			return this.timer_0;
		}

		// Token: 0x060059B7 RID: 22967 RVA: 0x0027C988 File Offset: 0x0027AB88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_3);
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

		// Token: 0x060059B8 RID: 22968 RVA: 0x0027C9D4 File Offset: 0x0027ABD4
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_2;
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x00028741 File Offset: 0x00026941
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_5)
		{
			this.label_2 = label_5;
		}

		// Token: 0x060059BA RID: 22970 RVA: 0x0027C9EC File Offset: 0x0027ABEC
		[CompilerGenerated]
		internal  TabControl vmethod_20()
		{
			return this.tabControl_1;
		}

		// Token: 0x060059BB RID: 22971 RVA: 0x0027CA04 File Offset: 0x0027AC04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(TabControl tabControl_2)
		{
			EventHandler value = new EventHandler(this.method_17);
			TabControl tabControl = this.tabControl_1;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged -= value;
			}
			this.tabControl_1 = tabControl_2;
			tabControl = this.tabControl_1;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged += value;
			}
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x0027CA50 File Offset: 0x0027AC50
		[CompilerGenerated]
		internal  TabPage GetTab_Attacker_ToSelectedOnly()
		{
			return this.tabPage_2;
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x0002874A File Offset: 0x0002694A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(TabPage tabPage_4)
		{
			this.tabPage_2 = tabPage_4;
		}

		// Token: 0x060059BE RID: 22974 RVA: 0x0027CA68 File Offset: 0x0027AC68
		[CompilerGenerated]
		internal  TreeView GetTV_Allocations_ToTargetsOnly()
		{
			return this.treeView_2;
		}

		// Token: 0x060059BF RID: 22975 RVA: 0x0027CA80 File Offset: 0x0027AC80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(TreeView treeView_5)
		{
			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.method_33);
			TreeViewEventHandler value2 = new TreeViewEventHandler(this.method_42);
			MouseEventHandler value3 = new MouseEventHandler(this.method_57);
			TreeView treeView = this.treeView_2;
			if (treeView != null)
			{
				treeView.NodeMouseDoubleClick -= value;
				treeView.AfterSelect -= value2;
				treeView.MouseClick -= value3;
			}
			this.treeView_2 = treeView_5;
			treeView = this.treeView_2;
			if (treeView != null)
			{
				treeView.NodeMouseDoubleClick += value;
				treeView.AfterSelect += value2;
				treeView.MouseClick += value3;
			}
		}

		// Token: 0x060059C0 RID: 22976 RVA: 0x0027CB00 File Offset: 0x0027AD00
		[CompilerGenerated]
		internal  TabPage GetTab_Attacker_ToAnyone()
		{
			return this.tabPage_3;
		}

		// Token: 0x060059C1 RID: 22977 RVA: 0x00028753 File Offset: 0x00026953
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(TabPage tabPage_4)
		{
			this.tabPage_3 = tabPage_4;
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x0027CB18 File Offset: 0x0027AD18
		[CompilerGenerated]
		internal  TreeView GetTV_Allocations_ToAnyone()
		{
			return this.treeView_3;
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x0027CB30 File Offset: 0x0027AD30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(TreeView treeView_5)
		{
			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.method_35);
			TreeViewEventHandler value2 = new TreeViewEventHandler(this.method_43);
			MouseEventHandler value3 = new MouseEventHandler(this.method_56);
			TreeView treeView = this.treeView_3;
			if (treeView != null)
			{
				treeView.NodeMouseDoubleClick -= value;
				treeView.AfterSelect -= value2;
				treeView.MouseClick -= value3;
			}
			this.treeView_3 = treeView_5;
			treeView = this.treeView_3;
			if (treeView != null)
			{
				treeView.NodeMouseDoubleClick += value;
				treeView.AfterSelect += value2;
				treeView.MouseClick += value3;
			}
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x0027CBB0 File Offset: 0x0027ADB0
		[CompilerGenerated]
		internal  Label vmethod_30()
		{
			return this.label_3;
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x0002875C File Offset: 0x0002695C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Label label_5)
		{
			this.label_3 = label_5;
		}

		// Token: 0x060059C6 RID: 22982 RVA: 0x0027CBC8 File Offset: 0x0027ADC8
		[CompilerGenerated]
		internal  ListBox vmethod_32()
		{
			return this.listBox_1;
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x0027CBE0 File Offset: 0x0027ADE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(ListBox listBox_2)
		{
			EventHandler value = new EventHandler(this.method_14);
			ListBox listBox = this.listBox_1;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value;
			}
			this.listBox_1 = listBox_2;
			listBox = this.listBox_1;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x0027CC2C File Offset: 0x0027AE2C
		[CompilerGenerated]
		internal  Label vmethod_34()
		{
			return this.label_4;
		}

		// Token: 0x060059C9 RID: 22985 RVA: 0x00028765 File Offset: 0x00026965
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Label label_5)
		{
			this.label_4 = label_5;
		}

		// Token: 0x060059CA RID: 22986 RVA: 0x0027CC44 File Offset: 0x0027AE44
		[CompilerGenerated]
		internal  TreeView GetTV_AvailableWeapons()
		{
			return this.TV_AvailableWeapons;
		}

		// Token: 0x060059CB RID: 22987 RVA: 0x0027CC5C File Offset: 0x0027AE5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetTV_AvailableWeapons(TreeView treeView_5)
		{
			TreeViewEventHandler value = new TreeViewEventHandler(this.TV_AvailableWeapons_AfterSelect);
			MouseEventHandler value2 = new MouseEventHandler(this.TV_AvailableWeapons_MouseDoubleClick);
			TreeView tV_AvailableWeapons = this.TV_AvailableWeapons;
			if (tV_AvailableWeapons != null)
			{
				tV_AvailableWeapons.AfterSelect -= value;
				tV_AvailableWeapons.MouseDoubleClick -= value2;
			}
			this.TV_AvailableWeapons = treeView_5;
			tV_AvailableWeapons = this.TV_AvailableWeapons;
			if (tV_AvailableWeapons != null)
			{
				tV_AvailableWeapons.AfterSelect += value;
				tV_AvailableWeapons.MouseDoubleClick += value2;
			}
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x0027CCC0 File Offset: 0x0027AEC0
		[CompilerGenerated]
		internal  Button GetButton_Allocate()
		{
			return this.button_0;
		}

		// Token: 0x060059CD RID: 22989 RVA: 0x0027CCD8 File Offset: 0x0027AED8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_27);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_14;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060059CE RID: 22990 RVA: 0x0027CD24 File Offset: 0x0027AF24
		[CompilerGenerated]
		internal  Button GetButton_AllocateAllWeapons()
		{
			return this.button_1;
		}

		// Token: 0x060059CF RID: 22991 RVA: 0x0027CD3C File Offset: 0x0027AF3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_29);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_14;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060059D0 RID: 22992 RVA: 0x0027CD88 File Offset: 0x0027AF88
		[CompilerGenerated]
		internal  NumericUpDown GetNUD_NumberOfWeapons()
		{
			return this.numericUpDown_0;
		}

		// Token: 0x060059D1 RID: 22993 RVA: 0x0002876E File Offset: 0x0002696E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(NumericUpDown numericUpDown_1)
		{
			this.numericUpDown_0 = numericUpDown_1;
		}

		// Token: 0x060059D2 RID: 22994 RVA: 0x0027CDA0 File Offset: 0x0027AFA0
		[CompilerGenerated]
		internal  Button GetButton_UnitWRA()
		{
			return this.button_2;
		}

		// Token: 0x060059D3 RID: 22995 RVA: 0x0027CDB8 File Offset: 0x0027AFB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_20);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_14;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060059D4 RID: 22996 RVA: 0x0027CE04 File Offset: 0x0027B004
		[CompilerGenerated]
		internal  Button GetButton_AddAttacker()
		{
			return this.button_3;
		}

		// Token: 0x060059D5 RID: 22997 RVA: 0x0027CE1C File Offset: 0x0027B01C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_21);
			Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_14;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060059D6 RID: 22998 RVA: 0x0027CE68 File Offset: 0x0027B068
		[CompilerGenerated]
		internal  Button GetButton_AddTarget()
		{
			return this.button_4;
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x0027CE80 File Offset: 0x0027B080
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_23);
			Button button = this.button_4;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_4 = button_14;
			button = this.button_4;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060059D8 RID: 23000 RVA: 0x0027CECC File Offset: 0x0027B0CC
		[CompilerGenerated]
		internal  Button GetButton_RemoveAttacker()
		{
			return this.Button_RemoveAttacker;
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x0027CEE4 File Offset: 0x0027B0E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_RemoveAttacker(Button button_14)
		{
			EventHandler value = new EventHandler(this.Button_RemoveAttacker_Click);
			Button button_RemoveAttacker = this.Button_RemoveAttacker;
			if (button_RemoveAttacker != null)
			{
				button_RemoveAttacker.Click -= value;
			}
			this.Button_RemoveAttacker = button_14;
			button_RemoveAttacker = this.Button_RemoveAttacker;
			if (button_RemoveAttacker != null)
			{
				button_RemoveAttacker.Click += value;
			}
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x0027CF30 File Offset: 0x0027B130
		[CompilerGenerated]
		internal  Button GetButton_RemoveTargets()
		{
			return this.button_6;
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x0027CF48 File Offset: 0x0027B148
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_24);
			Button button = this.button_6;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_6 = button_14;
			button = this.button_6;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x0027CF94 File Offset: 0x0027B194
		[CompilerGenerated]
		internal  Button GetButton_AllocateSalvo()
		{
			return this.Button_AllocateSalvo;
		}

		// Token: 0x060059DD RID: 23005 RVA: 0x0027CFAC File Offset: 0x0027B1AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_AllocateSalvo(Button button_14)
		{
			EventHandler value = new EventHandler(this.Button_AllocateSalvo_Click);
			Button button_AllocateSalvo = this.Button_AllocateSalvo;
			if (button_AllocateSalvo != null)
			{
				button_AllocateSalvo.Click -= value;
			}
			this.Button_AllocateSalvo = button_14;
			button_AllocateSalvo = this.Button_AllocateSalvo;
			if (button_AllocateSalvo != null)
			{
				button_AllocateSalvo.Click += value;
			}
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x0027CFF8 File Offset: 0x0027B1F8
		[CompilerGenerated]
		internal  Button GetButton_RemoveWeapons_Target()
		{
			return this.Button_RemoveWeapons_Target;
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x0027D010 File Offset: 0x0027B210
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_RemoveWeapons_Target(Button button_14)
		{
			EventHandler value = new EventHandler(this.Button_RemoveWeapons_Target_Click);
			Button button_RemoveWeapons_Target = this.Button_RemoveWeapons_Target;
			if (button_RemoveWeapons_Target != null)
			{
				button_RemoveWeapons_Target.Click -= value;
			}
			this.Button_RemoveWeapons_Target = button_14;
			button_RemoveWeapons_Target = this.Button_RemoveWeapons_Target;
			if (button_RemoveWeapons_Target != null)
			{
				button_RemoveWeapons_Target.Click += value;
			}
		}

		// Token: 0x060059E0 RID: 23008 RVA: 0x0027D05C File Offset: 0x0027B25C
		[CompilerGenerated]
		internal  Button GetButton_RemoveWeapons_Attacker()
		{
			return this.Button_RemoveWeapons_Attacker;
		}

		// Token: 0x060059E1 RID: 23009 RVA: 0x0027D074 File Offset: 0x0027B274
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_RemoveWeapons_Attacker(Button button_14)
		{
			EventHandler value = new EventHandler(this.Button_RemoveWeapons_Attacker_Click);
			Button button_RemoveWeapons_Attacker = this.Button_RemoveWeapons_Attacker;
			if (button_RemoveWeapons_Attacker != null)
			{
				button_RemoveWeapons_Attacker.Click -= value;
			}
			this.Button_RemoveWeapons_Attacker = button_14;
			button_RemoveWeapons_Attacker = this.Button_RemoveWeapons_Attacker;
			if (button_RemoveWeapons_Attacker != null)
			{
				button_RemoveWeapons_Attacker.Click += value;
			}
		}

		// Token: 0x060059E2 RID: 23010 RVA: 0x0027D0C0 File Offset: 0x0027B2C0
		[CompilerGenerated]
		internal  TableLayoutPanel vmethod_60()
		{
			return this.tableLayoutPanel_0;
		}

		// Token: 0x060059E3 RID: 23011 RVA: 0x00028777 File Offset: 0x00026977
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(TableLayoutPanel tableLayoutPanel_1)
		{
			this.tableLayoutPanel_0 = tableLayoutPanel_1;
		}

		// Token: 0x060059E4 RID: 23012 RVA: 0x0027D0D8 File Offset: 0x0027B2D8
		[CompilerGenerated]
		internal  Panel vmethod_62()
		{
			return this.panel_0;
		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x00028780 File Offset: 0x00026980
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(Panel panel_5)
		{
			this.panel_0 = panel_5;
		}

		// Token: 0x060059E6 RID: 23014 RVA: 0x0027D0F0 File Offset: 0x0027B2F0
		[CompilerGenerated]
		internal  Panel vmethod_64()
		{
			return this.panel_1;
		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x00028789 File Offset: 0x00026989
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(Panel panel_5)
		{
			this.panel_1 = panel_5;
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x0027D108 File Offset: 0x0027B308
		[CompilerGenerated]
		internal  Panel vmethod_66()
		{
			return this.panel_2;
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x00028792 File Offset: 0x00026992
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(Panel panel_5)
		{
			this.panel_2 = panel_5;
		}

		// Token: 0x060059EA RID: 23018 RVA: 0x0027D120 File Offset: 0x0027B320
		[CompilerGenerated]
		internal  Panel vmethod_68()
		{
			return this.panel_3;
		}

		// Token: 0x060059EB RID: 23019 RVA: 0x0002879B File Offset: 0x0002699B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(Panel panel_5)
		{
			this.panel_3 = panel_5;
		}

		// Token: 0x060059EC RID: 23020 RVA: 0x0027D138 File Offset: 0x0027B338
		[CompilerGenerated]
		internal  Panel vmethod_70()
		{
			return this.panel_4;
		}

		// Token: 0x060059ED RID: 23021 RVA: 0x000287A4 File Offset: 0x000269A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(Panel panel_5)
		{
			this.panel_4 = panel_5;
		}

		// Token: 0x060059EE RID: 23022 RVA: 0x0027D150 File Offset: 0x0027B350
		[CompilerGenerated]
		internal  CheckBox GetCB_AllowTimeout()
		{
			return this.checkBox_0;
		}

		// Token: 0x060059EF RID: 23023 RVA: 0x0027D168 File Offset: 0x0027B368
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(CheckBox checkBox_2)
		{
			EventHandler value = new EventHandler(this.method_46);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_0 = checkBox_2;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x060059F0 RID: 23024 RVA: 0x0027D1B4 File Offset: 0x0027B3B4
		[CompilerGenerated]
		internal  CheckBox GetCB_ShowAutomaticFireInfo()
		{
			return this.checkBox_1;
		}

		// Token: 0x060059F1 RID: 23025 RVA: 0x0027D1CC File Offset: 0x0027B3CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(CheckBox checkBox_2)
		{
			EventHandler value = new EventHandler(this.method_47);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_1 = checkBox_2;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x060059F2 RID: 23026 RVA: 0x0027D218 File Offset: 0x0027B418
		[CompilerGenerated]
		internal  Button GetButton_ClearCourse_Attacker()
		{
			return this.button_10;
		}

		// Token: 0x060059F3 RID: 23027 RVA: 0x0027D230 File Offset: 0x0027B430
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_49);
			Button button = this.button_10;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_10 = button_14;
			button = this.button_10;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060059F4 RID: 23028 RVA: 0x0027D27C File Offset: 0x0027B47C
		[CompilerGenerated]
		internal  Button GetButton_PlotCourse_Attacker()
		{
			return this.button_11;
		}

		// Token: 0x060059F5 RID: 23029 RVA: 0x0027D294 File Offset: 0x0027B494
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_48);
			Button button = this.button_11;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_11 = button_14;
			button = this.button_11;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x0027D2E0 File Offset: 0x0027B4E0
		[CompilerGenerated]
		internal  Button GetButton_ClearCourse_Target()
		{
			return this.button_12;
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x0027D2F8 File Offset: 0x0027B4F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(Button button_14)
		{
			EventHandler value = new EventHandler(this.method_51);
			Button button = this.button_12;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_12 = button_14;
			button = this.button_12;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060059F8 RID: 23032 RVA: 0x0027D344 File Offset: 0x0027B544
		[CompilerGenerated]
		internal  Button GetButton_PlotCourse_Target()
		{
			return this.Button_PlotCourse_Target;
		}

		// Token: 0x060059F9 RID: 23033 RVA: 0x0027D35C File Offset: 0x0027B55C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_PlotCourse_Target(Button button_14)
		{
			EventHandler value = new EventHandler(this.Button_PlotCourse_Target_Click);
			Button button_PlotCourse_Target = this.Button_PlotCourse_Target;
			if (button_PlotCourse_Target != null)
			{
				button_PlotCourse_Target.Click -= value;
			}
			this.Button_PlotCourse_Target = button_14;
			button_PlotCourse_Target = this.Button_PlotCourse_Target;
			if (button_PlotCourse_Target != null)
			{
				button_PlotCourse_Target.Click += value;
			}
		}

		// Token: 0x060059FA RID: 23034 RVA: 0x0027D3A8 File Offset: 0x0027B5A8
		[CompilerGenerated]
		internal  ContextMenuStrip vmethod_84()
		{
			return this.contextMenuStrip_0;
		}

		// Token: 0x060059FB RID: 23035 RVA: 0x000287AD File Offset: 0x000269AD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(ContextMenuStrip contextMenuStrip_1)
		{
			this.contextMenuStrip_0 = contextMenuStrip_1;
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x0027D3C0 File Offset: 0x0027B5C0
		[CompilerGenerated]
		internal  ToolStripMenuItem GetTSMI_HighAltitudeDetonation()
		{
			return this.TSMI_HighAltitudeDetonation;
		}

		// Token: 0x060059FD RID: 23037 RVA: 0x0027D3D8 File Offset: 0x0027B5D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetTSMI_HighAltitudeDetonation(ToolStripMenuItem toolStripMenuItem_1)
		{
			EventHandler value = new EventHandler(this.TSMI_HighAltitudeDetonation_Click);
			ToolStripMenuItem tSMI_HighAltitudeDetonation = this.TSMI_HighAltitudeDetonation;
			if (tSMI_HighAltitudeDetonation != null)
			{
				tSMI_HighAltitudeDetonation.Click -= value;
			}
			this.TSMI_HighAltitudeDetonation = toolStripMenuItem_1;
			tSMI_HighAltitudeDetonation = this.TSMI_HighAltitudeDetonation;
			if (tSMI_HighAltitudeDetonation != null)
			{
				tSMI_HighAltitudeDetonation.Click += value;
			}
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x0027D424 File Offset: 0x0027B624
		public void method_1()
		{
			this.bool_0 = (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Run);
			if (this.bool_0)
			{
				Client.GetConfiguration().SetSimStopMode();
			}
			this.method_6();
			this.method_7();
			if (this.TargetList.Count > 0 && this.list_1.Count > 0 && this.GetTV_AvailableWeapons().Nodes.Count > 0)
			{
				this.bool_1 = false;
				this.GetTV_AvailableWeapons().SelectedNode = this.GetTV_AvailableWeapons().Nodes[0];
				this.GetTV_AvailableWeapons().Select();
				this.GetTV_AvailableWeapons().EndUpdate();
				this.bool_1 = true;
			}
			this.bool_1 = false;
			this.GetCB_AllowTimeout().Checked = SimConfiguration.gameOptions.IsSalvoTimeout();
			this.GetCB_ShowAutomaticFireInfo().Checked = SimConfiguration.gameOptions.IsShowAutomaticFireInfo();
			this.bool_1 = true;
		}

		// Token: 0x060059FF RID: 23039 RVA: 0x0027D514 File Offset: 0x0027B714
		private void method_10()
		{
			List<ActiveUnit>.Enumerator enumerator = default(List<ActiveUnit>.Enumerator);
			List<WeaponSalvo>.Enumerator enumerator2 = default(List<WeaponSalvo>.Enumerator);
			this.GetTV_Allocations_ByAttackersOnly().Nodes.Clear();
			if (this.list_3.Count == 1)
			{
				try
				{
					enumerator = this.list_2.GetEnumerator();
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						TreeNode treeNode = new TreeNode
						{
							Text = "打击平台: " + current.Name,
							Tag = current
						};
						this.GetTV_Allocations_ByAttackersOnly().Nodes.Add(treeNode);
						Side side = current.GetSide(false);
						List<Contact> list = this.list_3;
						List<Contact> list2 = list;
						Contact value = list[0];
						List<WeaponSalvo> weaponSalvosForTarget = side.GetWeaponSalvosForTarget(ref current, ref value);
						list2[0] = value;
						List<WeaponSalvo> list3 = weaponSalvosForTarget;
						try
						{
							enumerator2 = list3.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								WeaponSalvo current2 = enumerator2.Current;
								WeaponSalvo.Shooter[] shooters = current2.m_Shooters;
								for (int i = 0; i < shooters.Length; i++)
								{
									WeaponSalvo.Shooter shooter = shooters[i];
									if (Operators.CompareString(current.GetGuid(), shooter.ShooterObjectID, false) == 0)
									{
										if (shooter.QuantityAssigned - shooter.QuantityFired > 0)
										{
											string str = (shooter.QuantityAssigned <= 2147473647) ? (Conversions.ToString(shooter.QuantityAssigned - shooter.QuantityFired) + "x ") : "All weapons ";
											this.string_0 = "";
											if (current2.ASMode == Weapon._ASMode.HighAltitudeDetonation)
											{
												this.string_0 += "[高空爆破]";
											}
											if (current2.PlottedCourse.Count<Waypoint>() > 0)
											{
												this.string_0 = this.string_0 + "[" + Conversions.ToString(current2.PlottedCourse.Count<Waypoint>()) + " 航线段]";
											}
											TreeNode node = new TreeNode
											{
												Text = "分配: " + this.string_0 + str + current2.GetWeapon(current.m_Scenario).Name,
												Tag = current2
											};
											treeNode.Nodes.Add(node);
										}
										if (shooter.QuantityFired > 0)
										{
											TreeNode node2 = new TreeNode
											{
												Text = "开火: " + Conversions.ToString(shooter.QuantityFired) + "x " + current2.GetWeapon(current.m_Scenario).Name
											};
											treeNode.Nodes.Add(node2);
										}
									}
								}
							}
						}
						finally
						{
							((IDisposable)enumerator2).Dispose();
						}
						treeNode.Expand();
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06005A00 RID: 23040 RVA: 0x0027D81C File Offset: 0x0027BA1C
		private void method_11()
		{
			List<ActiveUnit>.Enumerator enumerator = default(List<ActiveUnit>.Enumerator);
			List<WeaponSalvo>.Enumerator enumerator2 = default(List<WeaponSalvo>.Enumerator);
			this.GetTV_Allocations_ByAnyone().Nodes.Clear();
			try
			{
				enumerator = Client.GetClientScenario().GetActiveUnitList().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ActiveUnit current = enumerator.Current;
					if (!current.IsWeapon && !current.IsGroup)
					{
						Side side = current.GetSide(false);
						List<Contact> list = this.list_3;
						List<Contact> list2 = list;
						Contact value = list[0];
						List<WeaponSalvo> weaponSalvosForTarget = side.GetWeaponSalvosForTarget(ref current, ref value);
						list2[0] = value;
						List<WeaponSalvo> list3 = weaponSalvosForTarget;
						if (list3.Count > 0)
						{
							TreeNode treeNode = new TreeNode
							{
								Text = "打击平台: " + current.Name,
								Tag = current
							};
							this.GetTV_Allocations_ByAnyone().Nodes.Add(treeNode);
							try
							{
								enumerator2 = list3.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									WeaponSalvo current2 = enumerator2.Current;
									WeaponSalvo.Shooter[] shooters = current2.m_Shooters;
									for (int i = 0; i < shooters.Length; i++)
									{
										WeaponSalvo.Shooter shooter = shooters[i];
										if (Operators.CompareString(current.GetGuid(), shooter.ShooterObjectID, false) == 0)
										{
											if (shooter.QuantityAssigned - shooter.QuantityFired > 0)
											{
												string str = (shooter.QuantityAssigned <= 2147473647) ? (Conversions.ToString(shooter.QuantityAssigned - shooter.QuantityFired) + "x ") : "所有武器 ";
												this.string_0 = "";
												if (current2.ASMode == Weapon._ASMode.HighAltitudeDetonation)
												{
													this.string_0 += "[高空爆破]";
												}
												if (current2.PlottedCourse.Count<Waypoint>() > 0)
												{
													this.string_0 = this.string_0 + "[" + Conversions.ToString(current2.PlottedCourse.Count<Waypoint>()) + " 航线段]";
												}
												TreeNode node = new TreeNode
												{
													Text = "分配: " + this.string_0 + str + current2.GetWeapon(current.m_Scenario).Name,
													Tag = current2
												};
												treeNode.Nodes.Add(node);
											}
											if (shooter.QuantityFired > 0)
											{
												TreeNode node2 = new TreeNode
												{
													Text = "开火: " + Conversions.ToString(shooter.QuantityFired) + "x " + current2.GetWeapon(current.m_Scenario).Name
												};
												treeNode.Nodes.Add(node2);
											}
										}
									}
								}
							}
							finally
							{
								((IDisposable)enumerator2).Dispose();
							}
							treeNode.Expand();
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06005A01 RID: 23041 RVA: 0x0027DB3C File Offset: 0x0027BD3C
		private void method_12()
		{
			Weapon weapon = null;
			if (Information.IsNothing(this.GetTV_AvailableWeapons().SelectedNode))
			{
				this.GetButton_Allocate().Enabled = false;
				this.GetButton_AllocateAllWeapons().Enabled = false;
				this.GetButton_AllocateSalvo().Enabled = false;
			}
			else if (this.list_2.Count <= 0)
			{
				this.GetButton_Allocate().Enabled = false;
				this.GetButton_AllocateAllWeapons().Enabled = false;
				this.GetButton_AllocateSalvo().Enabled = false;
			}
			else
			{
				if (this.list_3.Count != 1)
				{
					this.GetButton_AllocateAllWeapons().Enabled = false;
				}
				else
				{
					this.GetButton_AllocateAllWeapons().Enabled = true;
				}
				weapon = ((this.GetTV_AvailableWeapons().SelectedNode.Tag.GetType() != typeof(string)) ? ((Weapon)this.GetTV_AvailableWeapons().SelectedNode.Tag) : ((Weapon)this.GetTV_AvailableWeapons().SelectedNode.Parent.Tag));
				if (this.list_3.Count <= 0)
				{
					this.GetButton_AllocateSalvo().Enabled = false;
					this.GetButton_Allocate().Enabled = false;
				}
				else
				{
					if (!this.list_2[0].m_Doctrine.IsLethalWeapon(ref weapon))
					{
						this.GetButton_AllocateSalvo().Enabled = false;
					}
					else
					{
						this.GetButton_AllocateSalvo().Enabled = true;
					}
					this.GetButton_Allocate().Enabled = true;
				}
			}
		}

		// Token: 0x06005A02 RID: 23042 RVA: 0x0027DCAC File Offset: 0x0027BEAC
		private void UpdateAvaibleWeaponInfo()
		{
			Contact_Base.ContactType contactType = Contact_Base.ContactType.Air;
			List<Contact>.Enumerator enumerator = default(List<Contact>.Enumerator);
			List<ActiveUnit>.Enumerator enumerator2 = default(List<ActiveUnit>.Enumerator);
			short? num = null;
			Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = null;
			Dictionary<string, int>.Enumerator enumerator3 = default(Dictionary<string, int>.Enumerator);
			IEnumerator enumerator4 = null;
			IEnumerator enumerator5 = null;
			this.GetTV_AvailableWeapons().Nodes.Clear();
			this.method_12();
			if (this.list_2.Count != 1)
			{
				this.GetTV_AvailableWeapons().Enabled = false;
			}
			else if (this.list_3.Count == 0)
			{
				this.GetTV_AvailableWeapons().Enabled = false;
			}
			else
			{
				if (this.list_3.Count > 1)
				{
					int num2 = 0;
					try
					{
						enumerator = this.list_3.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Contact current = enumerator.Current;
							if (num2 == 0)
							{
								contactType = current.contactType;
							}
							else if (contactType != current.contactType)
							{
								this.GetTV_AvailableWeapons().Enabled = false;
								return;
							}
							num2++;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				this.GetTV_AvailableWeapons().Enabled = true;
				try
				{
					enumerator2 = this.list_2.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						ActiveUnit current2 = enumerator2.Current;
						bool manualFire = true;
						Weapon[] availableWeapons = current2.GetWeaponry().GetAvailableWeapons(false);
						for (int i = 0; i < availableWeapons.Length; i++)
						{
							Weapon weapon = availableWeapons[i];
							int dBID = weapon.DBID;
							Scenario scenario = current2.m_Scenario;
							List<Contact> list = this.list_3;
							List<Contact> list2 = list;
							Contact value = list[0];
							bool flag = weapon.IsSuitableForTarget(scenario, ref value);
							list2[0] = value;
							if (flag)
							{
								int currentLoadForWeapon = current2.GetWeaponry().GetCurrentLoadForWeapon(dBID, true);
								int quantityToFireForTheWeapon = current2.GetSide(false).GetQuantityToFireForTheWeapon(ref current2, dBID);
								string text = Conversions.ToString(currentLoadForWeapon) + "x " + Misc.smethod_11(weapon.Name);
								if (quantityToFireForTheWeapon > 2147473647)
								{
									text += " (所有分配的武器)";
								}
								else if (quantityToFireForTheWeapon > 0)
								{
									text = text + " (" + Conversions.ToString(quantityToFireForTheWeapon) + "x 已分配)";
								}
								TreeNode treeNode = new TreeNode(text);
								Dictionary<string, int> dictionary = new Dictionary<string, int>();
								treeNode.Tag = weapon;
								this.GetTV_AvailableWeapons().Nodes.Add(treeNode);
								if (quantityToFireForTheWeapon != currentLoadForWeapon)
								{
									Mount[] mounts = current2.m_Mounts;
									for (int j = 0; j < mounts.Length; j++)
									{
										Mount mount = mounts[j];
										int weaponLoadsOnMount = current2.GetWeaponry().GetWeaponLoadsOnMount(mount, dBID);
										if (weaponLoadsOnMount > 0)
										{
											Sensor sensor = null;
											string key = current2.GetWeaponry().CheckWeaponAttackCondition(weapon, this.list_3[0], ref num, manualFire, false, mount, ref sensor);
											if (!dictionary.ContainsKey(key))
											{
												dictionary.Add(key, weaponLoadsOnMount);
											}
											else
											{
												dictionary[key] += weaponLoadsOnMount;
											}
										}
									}
									if (current2.IsAircraft && !Information.IsNothing(((Aircraft)current2).GetLoadout()))
									{
										int num3 = current2.GetWeaponry().vmethod_7(((Aircraft)current2).GetLoadout(), dBID);
										if (num3 > 0)
										{
											Sensor sensor = null;
											string key2 = current2.GetWeaponry().CheckWeaponAttackCondition(weapon, this.list_3[0], ref num, manualFire, false, null, ref sensor);
											if (!dictionary.ContainsKey(key2))
											{
												dictionary.Add(key2, num3);
											}
											else
											{
												dictionary[key2] += num3;
											}
										}
									}
									int weaponLoadsInMagazines = current2.GetWeaponry().GetWeaponLoadsInMagazines(dBID);
									if (weaponLoadsInMagazines > 0)
									{
										dictionary.Add("武器尚在弹药库内", weaponLoadsInMagazines);
									}
									if (SimConfiguration.gameOptions.IsShowAutomaticFireInfo())
									{
										bool flag2 = true;
										string text2 = "禁止自动开火";
										Doctrine._WeaponControlStatus weaponControlStatusFor = current2.GetWeaponry().GetWeaponControlStatusFor(this.list_3[0].contactType);
										string str;
										if (weaponControlStatusFor != Doctrine._WeaponControlStatus.Free)
										{
											str = ((weaponControlStatusFor != Doctrine._WeaponControlStatus.Tight) ? "武器谨慎开火" : "武器限制开火");
										}
										else
										{
											str = "武器自由开火";
										}
										Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType2;
										if (!weapon.weaponTarget.IsRadar)
										{
											Doctrine doctrine = current2.m_Doctrine;
											List<Contact> list3 = this.list_3;
											list2 = list3;
											value = list3[0];
											Doctrine._WRA_WeaponTargetType wRA_WeaponTargetType = doctrine.GetWRA_WeaponTargetType(ref value);
											list2[0] = value;
											wRA_WeaponTargetType2 = wRA_WeaponTargetType;
										}
										else
										{
											wRA_WeaponTargetType2 = Doctrine._WRA_WeaponTargetType.Radar_Unspecified;
										}
										string str2 = "目标类型:" + current2.m_Doctrine.GetWRA_WeaponTargetTypeString(wRA_WeaponTargetType2);
										int? num4 = null;
										int? num5 = null;
										int? firingRange = current2.m_Doctrine.GetFiringRange(current2.m_Scenario, dBID, wRA_WeaponTargetType2, false, ref num4, ref num5);
										if (Information.IsNothing(firingRange))
										{
											firingRange = new int?(-99);
										}
										num5 = firingRange;
										bool? flag3;
										if (num5.HasValue)
										{
											flag3 = new bool?(num5.GetValueOrDefault() == 0);
										}
										else
										{
											flag3 = null;
										}
										bool? flag4 = flag3;
										int? num6;
										if (!(flag4.HasValue ? new bool?(!flag4.GetValueOrDefault()) : flag4).GetValueOrDefault())
										{
											num6 = new int?(0);
										}
										else
										{
											num5 = null;
											num4 = null;
											num6 = current2.m_Doctrine.GetWeaponQty(current2.m_Scenario, weapon, wRA_WeaponTargetType2, false, ref num5, ref num4);
											if (Information.IsNothing(num6))
											{
												num6 = new int?(0);
											}
										}
										string str3;
										string text3;
										if (!Information.IsNothing(num6))
										{
											num4 = firingRange;
											bool? flag5;
											if (num4.HasValue)
											{
												flag5 = new bool?(num4.GetValueOrDefault() == 0);
											}
											else
											{
												flag5 = null;
											}
											flag4 = flag5;
											str3 = ((!flag4.GetValueOrDefault()) ? (current2.m_Doctrine.method_205(num6, current2, this.list_3[0], weapon) + ". ") : "");
											num4 = num6;
											bool? flag6;
											if (num4.HasValue)
											{
												flag6 = new bool?(num4.GetValueOrDefault() == 0);
											}
											else
											{
												flag6 = null;
											}
											flag4 = flag6;
											bool? flag8;
											if (flag4.GetValueOrDefault())
											{
												num4 = firingRange;
												bool? flag7;
												if (num4.HasValue)
												{
													flag7 = new bool?(num4.GetValueOrDefault() == 0);
												}
												else
												{
													flag7 = null;
												}
												flag4 = flag7;
												flag8 = (flag4.HasValue ? new bool?(!flag4.GetValueOrDefault()) : flag4);
											}
											else
											{
												flag8 = new bool?(false);
											}
											flag4 = flag8;
											text3 = ((!flag4.GetValueOrDefault()) ? (current2.m_Doctrine.method_206(firingRange) + ". ") : "");
										}
										else
										{
											str3 = "不要对该类目标使用此类武器";
											text3 = "";
										}
										Misc.PostureStance postureStance = this.list_3[0].GetPostureStance(current2.GetSide(false));
										if (Information.IsNothing(postureStance))
										{
											flag2 = false;
											text2 = "不能确定目标的敌友属性!";
										}
										else if (postureStance == Misc.PostureStance.Hostile)
										{
											if (weaponControlStatusFor == Doctrine._WeaponControlStatus.Hold)
											{
												flag2 = false;
												text2 = "禁止自动开火, 武器控制状态为限制开火";
											}
										}
										else if (postureStance == Misc.PostureStance.Unknown || postureStance == Misc.PostureStance.Unfriendly)
										{
											if (weaponControlStatusFor == Doctrine._WeaponControlStatus.Tight)
											{
												flag2 = false;
												text2 = "禁止自动开火,武器控制状态为谨慎开火而目标经查证非敌方";
											}
											else if (weaponControlStatusFor == Doctrine._WeaponControlStatus.Hold)
											{
												flag2 = false;
												text2 = "禁止自动开火, 武器控制状态为限制开火";
											}
										}
										if (flag2)
										{
											num4 = firingRange;
											bool? flag9;
											if (num4.HasValue)
											{
												flag9 = new bool?(num4.GetValueOrDefault() == 0);
											}
											else
											{
												flag9 = null;
											}
											flag4 = flag9;
											if (!flag4.GetValueOrDefault())
											{
												num4 = num6;
												bool? flag10;
												if (num4.HasValue)
												{
													flag10 = new bool?(num4.GetValueOrDefault() == 0);
												}
												else
												{
													flag10 = null;
												}
												flag4 = flag10;
												if (flag4.GetValueOrDefault())
												{
													flag2 = false;
													text2 = "禁止自动开火, 武器使用规则规定:" + str3;
												}
											}
											else
											{
												flag2 = false;
												text2 = "禁止自动开火, 武器使用规则规定: " + text3;
											}
										}
										if (current2.IsAircraft && weapon.GetWeaponType() == Weapon._WeaponType.Gun && this.list_3[0].IsSurfaceOrLandTarget())
										{
											if (Information.IsNothing(gunStrafeGroundTargets))
											{
												gunStrafeGroundTargets = current2.m_Doctrine.GetGunStrafeGroundTargetsDoctrine(current2.m_Scenario, false, false, false);
											}
											byte? b;
											if (gunStrafeGroundTargets.HasValue)
											{
												b = new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault());
											}
											else
											{
												b = null;
											}
											byte? b2 = b;
											bool? flag11;
											if (b2.HasValue)
											{
												flag11 = new bool?(b2.GetValueOrDefault() == 0);
											}
											else
											{
												flag11 = null;
											}
											flag4 = flag11;
											if (flag4.GetValueOrDefault())
											{
												flag2 = false;
												text2 = "禁止自动开火, 作战条令规定'不准对地面或水面目标进行火炮攻击'";
											}
										}
										if (flag2)
										{
											if (!dictionary.ContainsKey("OK"))
											{
												flag2 = false;
												text2 = "禁止自动开火, " + dictionary.Keys.ElementAtOrDefault(0);
											}
											else
											{
												text2 = "允许自动开火.";
											}
										}
										TreeNode treeNode2 = new TreeNode
										{
											Text = text2,
											Tag = ""
										};
										if (!flag2)
										{
											treeNode2.ForeColor = Color.Red;
										}
										else
										{
											treeNode2.ForeColor = Color.DarkGreen;
										}
										treeNode.Nodes.Add(treeNode2);
										TreeNode node = new TreeNode
										{
											Text = "武器控制状态: " + str,
											Tag = "",
											ForeColor = Color.DarkGray
										};
										treeNode.Nodes.Add(node);
										TreeNode node2 = new TreeNode
										{
											Text = "武器使用规则: " + str3 + text3 + str2,
											Tag = "",
											ForeColor = Color.DarkGray
										};
										treeNode.Nodes.Add(node2);
									}
									try
									{
										enumerator3 = dictionary.GetEnumerator();
										while (enumerator3.MoveNext())
										{
											KeyValuePair<string, int> current3 = enumerator3.Current;
											TreeNode treeNode3 = new TreeNode();
											string key3 = current3.Key;
											string str4 = Conversions.ToString(current3.Value);
											if (string.CompareOrdinal(key3, "OK") != 0)
											{
												treeNode3.Text = str4 + "x 不能开火. " + key3;
												treeNode3.ForeColor = Color.Red;
											}
											else
											{
												treeNode3.Text = str4 + "x 可以开火(人工分配武器)";
												treeNode3.ForeColor = Color.DarkGreen;
											}
											treeNode3.Tag = key3;
											treeNode.Nodes.Add(treeNode3);
										}
									}
									finally
									{
										((IDisposable)enumerator3).Dispose();
									}
									treeNode.Expand();
								}
							}
						}
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
				}
				if (!Information.IsNothing(this.nullable_0) && Information.IsNothing(this.GetTV_AvailableWeapons().SelectedNode))
				{
					enumerator4 = this.GetTV_AvailableWeapons().Nodes.GetEnumerator();
					try
					{
						while (enumerator4.MoveNext())
						{
							TreeNode treeNode4 = (TreeNode)enumerator4.Current;
							if (treeNode4.Index == this.int_2)
							{
								enumerator5 = treeNode4.Nodes.GetEnumerator();
								try
								{
									while (enumerator5.MoveNext())
									{
										TreeNode treeNode5 = (TreeNode)enumerator5.Current;
										if (treeNode5.Index == this.nullable_0.Value)
										{
											this.bool_1 = false;
											this.GetTV_AvailableWeapons().SelectedNode = treeNode5;
											this.bool_1 = true;
											if (!Information.IsNothing(this.GetTV_AvailableWeapons().SelectedNode))
											{
												return;
											}
										}
									}
								}
								finally
								{
									if (enumerator5 is IDisposable)
									{
										(enumerator5 as IDisposable).Dispose();
									}
								}
							}
							if (!Information.IsNothing(this.GetTV_AvailableWeapons().SelectedNode))
							{
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
				}
			}
		}

		// Token: 0x06005A03 RID: 23043 RVA: 0x0027E934 File Offset: 0x0027CB34
		private void method_14(object sender, EventArgs e)
		{
			IEnumerator enumerator = null;
			this.list_2.Clear();
			try
			{
				enumerator = this.vmethod_32().SelectedItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem listViewItem = (ListViewItem)enumerator.Current;
					this.list_2.Add((ActiveUnit)listViewItem.Tag);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (this.list_2.Count != 1)
			{
				this.GetButton_UnitWRA().Enabled = false;
			}
			else
			{
				this.GetButton_UnitWRA().Enabled = true;
			}
			if (this.bool_1)
			{
				this.int_0 = this.vmethod_32().SelectedIndex;
				this.UpdateAvaibleWeaponInfo();
				this.method_5();
			}
		}

		// Token: 0x06005A04 RID: 23044 RVA: 0x0027EA0C File Offset: 0x0027CC0C
		private void method_15(object sender, EventArgs e)
		{
			IEnumerator enumerator = null;
			this.list_3.Clear();
			try
			{
				enumerator = this.vmethod_10().SelectedItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem listViewItem = (ListViewItem)enumerator.Current;
					this.list_3.Add((Contact)listViewItem.Tag);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (this.bool_1)
			{
				this.int_1 = this.vmethod_10().SelectedIndex;
				this.UpdateAvaibleWeaponInfo();
				this.method_5();
			}
		}

		// Token: 0x06005A05 RID: 23045 RVA: 0x0027EAB8 File Offset: 0x0027CCB8
		private void TV_AvailableWeapons_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (this.bool_1 && !Information.IsNothing(this.GetTV_AvailableWeapons().SelectedNode))
			{
				this.nullable_0 = new int?(this.GetTV_AvailableWeapons().SelectedNode.Index);
				if (!Information.IsNothing(this.GetTV_AvailableWeapons().SelectedNode.Parent))
				{
					this.int_2 = this.GetTV_AvailableWeapons().SelectedNode.Parent.Index;
				}
			}
			this.method_12();
		}

		// Token: 0x06005A06 RID: 23046 RVA: 0x000287B6 File Offset: 0x000269B6
		private void method_17(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x06005A07 RID: 23047 RVA: 0x0027EB38 File Offset: 0x0027CD38
		private void method_18()
		{
			try
			{
				AttackTarget.SendMessage(base.Handle, 11, new IntPtr(0), IntPtr.Zero);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200372", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005A08 RID: 23048 RVA: 0x0027EBB0 File Offset: 0x0027CDB0
		private void method_19(bool Refresh = true)
		{
			try
			{
				AttackTarget.SendMessage(base.Handle, 11, new IntPtr(-1), IntPtr.Zero);
				if (Refresh)
				{
					this.Refresh();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200373", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005A09 RID: 23049 RVA: 0x0027EC34 File Offset: 0x0027CE34
		public void method_2()
		{
			List<ActiveUnit>.Enumerator enumerator = default(List<ActiveUnit>.Enumerator);
			List<ActiveUnit>.Enumerator enumerator2 = default(List<ActiveUnit>.Enumerator);
			List<Contact>.Enumerator enumerator3 = default(List<Contact>.Enumerator);
			List<Contact>.Enumerator enumerator4 = default(List<Contact>.Enumerator);
			if (!base.IsDisposed)
			{
				this.method_18();
				this.UpdateAvaibleWeaponInfo();
				this.method_5();
				if (Information.IsNothing(this.list_2) && this.list_1.Count > 0)
				{
					this.list_2.Add(this.list_1[0]);
					this.list_3.Add(this.TargetList[0]);
				}
				List<ActiveUnit> list = new List<ActiveUnit>();
				try
				{
					enumerator = this.list_1.GetEnumerator();
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						if (Information.IsNothing(current) || current.IsNotActive() || (current.IsShip && ((Ship)current).IsDestroyed()))
						{
							list.Add(current);
						}
						if (!current.IsOperating())
						{
							list.Add(current);
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				if (list.Count > 0)
				{
					try
					{
						enumerator2 = list.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							ActiveUnit current2 = enumerator2.Current;
							this.list_1.Remove(current2);
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
					}
					this.method_6();
				}
				List<Contact> list2 = new List<Contact>();
				try
				{
					enumerator3 = this.TargetList.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						Contact current3 = enumerator3.Current;
						if (Information.IsNothing(current3) || (!Information.IsNothing(current3.ActualUnit) && current3.ActualUnit.IsNotActive()))
						{
							list2.Add(current3);
						}
					}
				}
				finally
				{
					((IDisposable)enumerator3).Dispose();
				}
				if (list2.Count > 0)
				{
					try
					{
						enumerator4 = list2.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							Contact current4 = enumerator4.Current;
							this.TargetList.Remove(current4);
							this.method_7();
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
					}
				}
				this.method_19(true);
			}
		}

		// Token: 0x06005A0A RID: 23050 RVA: 0x0027EE94 File Offset: 0x0027D094
		private void method_20(object sender, EventArgs e)
		{
			if (this.list_2.Count == 1)
			{
				DoctrineForm doctrineForm = new DoctrineForm
				{
					subject = this.list_2[0]
				};
				doctrineForm.Show();
				doctrineForm.vmethod_0().SelectedIndex = 2;
			}
		}

		// Token: 0x06005A0B RID: 23051 RVA: 0x0027EEE0 File Offset: 0x0027D0E0
		private void method_21(object sender, EventArgs e)
		{
			IEnumerator<Unit> enumerator = null;
			if (!Information.IsNothing(Client.GetHookedUnit()) && !Information.IsNothing(Client.GetHookedUnit().GetSide(false)) && ((Client.GetClientSide().GetUnitReadOnlyCollection().Count > 0 && !Information.IsNothing(Client.GetHookedUnit())) || (Client.GetClientSide().GetUnitReadOnlyCollection().Count == 0 && !Information.IsNothing(Client.GetHookedUnit()) && Information.IsNothing(Client.GetWayPointSelected()))))
			{
				using (enumerator)
				{
					enumerator = Client.GetClientSide().GetUnitReadOnlyCollection().GetEnumerator();
					while (enumerator.MoveNext())
					{
						Unit current = enumerator.Current;
						if (current.IsActiveUnit() && !current.IsWeapon && current.GetSide(false) == Client.GetClientSide())
						{
							ActiveUnit item = (ActiveUnit)current;
							if (!this.list_1.Contains(item))
							{
								this.list_1.Add(item);
							}
						}
					}
				}
				this.method_6();
			}
		}

		// Token: 0x06005A0C RID: 23052 RVA: 0x0027EFF0 File Offset: 0x0027D1F0
		private void Button_RemoveAttacker_Click(object sender, EventArgs e)
		{
			List<ActiveUnit>.Enumerator enumerator = default(List<ActiveUnit>.Enumerator);
			List<ActiveUnit>.Enumerator enumerator2 = default(List<ActiveUnit>.Enumerator);
			List<ActiveUnit> list = new List<ActiveUnit>();
			if (this.list_2.Count > 0)
			{
				try
				{
					enumerator = this.list_2.GetEnumerator();
					while (enumerator.MoveNext())
					{
						list.Add(enumerator.Current);
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			try
			{
				enumerator2 = list.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					ActiveUnit current = enumerator2.Current;
					this.list_1.Remove(current);
				}
			}
			finally
			{
				((IDisposable)enumerator2).Dispose();
			}
			this.list_2.Clear();
			this.method_6();
			this.UpdateAvaibleWeaponInfo();
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x0027F0C4 File Offset: 0x0027D2C4
		private void method_23(object sender, EventArgs e)
		{
			IEnumerator<Unit> enumerator = null;
			if (!Information.IsNothing(Client.GetHookedUnit()) && Client.GetClientSide().GetUnitReadOnlyCollection().Count > 0 && !Information.IsNothing(Client.GetHookedUnit()))
			{
				using (enumerator)
				{
					enumerator = Client.GetClientSide().GetUnitReadOnlyCollection().GetEnumerator();
					while (enumerator.MoveNext())
					{
						Unit current = enumerator.Current;
						if (current.IsContact())
						{
							Contact item = (Contact)current;
							if (!this.TargetList.Contains(item))
							{
								this.TargetList.Add(item);
							}
						}
					}
				}
				this.method_7();
			}
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x0027F174 File Offset: 0x0027D374
		private void method_24(object sender, EventArgs e)
		{
			List<Contact>.Enumerator enumerator = default(List<Contact>.Enumerator);
			List<Contact>.Enumerator enumerator2 = default(List<Contact>.Enumerator);
			List<Contact> list = new List<Contact>();
			if (this.list_3.Count > 0)
			{
				try
				{
					enumerator = this.list_3.GetEnumerator();
					while (enumerator.MoveNext())
					{
						list.Add(enumerator.Current);
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			try
			{
				enumerator2 = list.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Contact current = enumerator2.Current;
					this.TargetList.Remove(current);
				}
			}
			finally
			{
				((IDisposable)enumerator2).Dispose();
			}
			this.list_3.Clear();
			this.method_7();
			this.UpdateAvaibleWeaponInfo();
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x0027F248 File Offset: 0x0027D448
		private void Button_AllocateSalvo_Click(object sender, EventArgs e)
		{
			Weapon weapon = null;
			List<Contact>.Enumerator enumerator = default(List<Contact>.Enumerator);
			if (!Information.IsNothing(this.GetTV_AvailableWeapons().SelectedNode))
			{
				TreeNode selectedNode = this.GetTV_AvailableWeapons().SelectedNode;
				weapon = ((selectedNode.Tag.GetType() != typeof(string)) ? ((Weapon)selectedNode.Tag) : ((Weapon)selectedNode.Parent.Tag));
				try
				{
					enumerator = this.list_3.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Contact current = enumerator.Current;
						List<ActiveUnit> list = this.list_2;
						List<ActiveUnit> list2 = list;
						ActiveUnit value = list[0];
						this.method_26(ref value, ref current, ref weapon);
						list2[0] = value;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				this.UpdateAvaibleWeaponInfo();
				this.method_5();
			}
		}

		// Token: 0x06005A10 RID: 23056 RVA: 0x0027F32C File Offset: 0x0027D52C
		private void method_26(ref ActiveUnit activeUnitPointer, ref Contact contactPointer, ref Weapon weaponPointer)
		{
			try
			{
				Doctrine._WRA_WeaponTargetType selectedNodeTargetType = (!weaponPointer.weaponTarget.IsRadar) ? activeUnitPointer.m_Doctrine.GetWRA_WeaponTargetType(ref contactPointer) : Doctrine._WRA_WeaponTargetType.Radar_Unspecified;
				int? num = null;
				int? num2 = null;
				int? num3 = activeUnitPointer.m_Doctrine.GetWeaponQty(activeUnitPointer.m_Scenario, weaponPointer, selectedNodeTargetType, false, ref num, ref num2);
				if (!Information.IsNothing(num3))
				{
					num2 = num3;
					bool? flag;
					if (num2.HasValue)
					{
						flag = new bool?(num2.GetValueOrDefault() == 0);
					}
					else
					{
						flag = null;
					}
					bool? flag2 = flag;
					if (!flag2.GetValueOrDefault())
					{
						num2 = num3;
						bool? flag3;
						if (num2.HasValue)
						{
							flag3 = new bool?(num2.GetValueOrDefault() == -99);
						}
						else
						{
							flag3 = null;
						}
						flag2 = flag3;
						if (!flag2.GetValueOrDefault())
						{
							num2 = num3;
							bool? flag4;
							if (num2.HasValue)
							{
								flag4 = new bool?(num2.GetValueOrDefault() < 0);
							}
							else
							{
								flag4 = null;
							}
							flag2 = flag4;
							if (flag2.GetValueOrDefault())
							{
								num3 = activeUnitPointer.GetSide(false).GetWeaponQuantity(num3, ref activeUnitPointer, ref contactPointer, ref weaponPointer);
							}
						}
						else
						{
							num3 = new int?(2147483647);
						}
						int num4 = activeUnitPointer.GetWeaponry().GetCurrentLoadForWeapon(weaponPointer.DBID, false);
						num4 -= activeUnitPointer.GetSide(false).GetQuantityToFireForTheWeapon(ref activeUnitPointer, weaponPointer.DBID);
						num2 = num3;
						bool? flag5;
						if (num2.HasValue)
						{
							flag5 = new bool?(num2.GetValueOrDefault() > num4);
						}
						else
						{
							flag5 = null;
						}
						flag2 = flag5;
						if (flag2.GetValueOrDefault())
						{
							num3 = new int?(num4);
						}
						num2 = num3;
						bool? flag6;
						if (num2.HasValue)
						{
							flag6 = new bool?(num2.GetValueOrDefault() > 0);
						}
						else
						{
							flag6 = null;
						}
						flag2 = flag6;
						if (flag2.GetValueOrDefault())
						{
							activeUnitPointer.GetWeaponry().method_14(contactPointer, weaponPointer.DBID, num3.Value, true, DateTime.MinValue);
							CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101234", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005A11 RID: 23057 RVA: 0x0027F5B4 File Offset: 0x0027D7B4
		private void method_27(object sender, EventArgs e)
		{
			Weapon weapon = null;
			List<Contact>.Enumerator enumerator = default(List<Contact>.Enumerator);
			int num = Convert.ToInt32(this.GetNUD_NumberOfWeapons().Value);
			if (Versioned.IsNumeric(this.GetNUD_NumberOfWeapons().Value) && decimal.Compare(this.GetNUD_NumberOfWeapons().Value, 0m) > 0 && !Information.IsNothing(this.GetTV_AvailableWeapons().SelectedNode))
			{
				TreeNode selectedNode = this.GetTV_AvailableWeapons().SelectedNode;
				weapon = ((selectedNode.Tag.GetType() != typeof(string)) ? ((Weapon)selectedNode.Tag) : ((Weapon)selectedNode.Parent.Tag));
				try
				{
					enumerator = this.list_3.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Contact current = enumerator.Current;
						List<ActiveUnit> list = this.list_2;
						List<ActiveUnit> list2 = list;
						ActiveUnit value = list[0];
						this.method_28(ref value, ref current, ref weapon, ref num);
						list2[0] = value;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				this.UpdateAvaibleWeaponInfo();
				this.method_5();
			}
		}

		// Token: 0x06005A12 RID: 23058 RVA: 0x0027F6E0 File Offset: 0x0027D8E0
		private void method_28(ref ActiveUnit activeUnitPointer, ref Contact contactPointer, ref Weapon weaponPointer, ref int numPointer)
		{
			try
			{
				int num = activeUnitPointer.GetWeaponry().GetCurrentLoadForWeapon(weaponPointer.DBID, false);
				num -= activeUnitPointer.GetSide(false).GetQuantityToFireForTheWeapon(ref activeUnitPointer, weaponPointer.DBID);
				if (numPointer > num)
				{
					numPointer = num;
				}
				if (numPointer > 0)
				{
					activeUnitPointer.GetWeaponry().method_14(contactPointer, weaponPointer.DBID, numPointer, true, DateTime.MinValue);
					CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101235", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005A13 RID: 23059 RVA: 0x0027F7B0 File Offset: 0x0027D9B0
		private void method_29(object sender, EventArgs e)
		{
			try
			{
				if (!Information.IsNothing(this.GetTV_AvailableWeapons().SelectedNode))
				{
					TreeNode selectedNode = this.GetTV_AvailableWeapons().SelectedNode;
					Weapon weapon = (selectedNode.Tag.GetType() != typeof(string)) ? ((Weapon)selectedNode.Tag) : ((Weapon)selectedNode.Parent.Tag);
					int num = this.list_2[0].GetWeaponry().GetCurrentLoadForWeapon(weapon.DBID, false);
					Side side = this.list_2[0].GetSide(false);
					List<ActiveUnit> list = this.list_2;
					List<ActiveUnit> list2 = list;
					ActiveUnit value = list[0];
					int quantityToFireForTheWeapon = side.GetQuantityToFireForTheWeapon(ref value, weapon.DBID);
					list2[0] = value;
					num -= quantityToFireForTheWeapon;
					if (num > 0)
					{
						this.list_2[0].GetWeaponry().method_14(this.list_3[0], weapon.DBID, num, true, DateTime.MinValue);
						CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
					}
					this.UpdateAvaibleWeaponInfo();
					this.method_5();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101236", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005A14 RID: 23060 RVA: 0x000287BE File Offset: 0x000269BE
		private void method_3(object sender, EventArgs e)
		{
			if (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Run)
			{
				this.method_2();
			}
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x000287D8 File Offset: 0x000269D8
		private void Button_RemoveWeapons_Attacker_Click(object sender, EventArgs e)
		{
			if (this.vmethod_20().SelectedIndex == 0)
			{
				this.method_34(true);
			}
			else
			{
				this.method_36(true);
			}
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x000287FD File Offset: 0x000269FD
		private void Button_RemoveWeapons_Target_Click(object sender, EventArgs e)
		{
			if (this.vmethod_4().SelectedIndex == 0)
			{
				this.method_38(true);
			}
			else
			{
				this.method_40(true);
			}
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x0027F930 File Offset: 0x0027DB30
		private void TV_AvailableWeapons_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			try
			{
				if (!Information.IsNothing(this.GetTV_AvailableWeapons().SelectedNode) && this.list_3.Count <= 1)
				{
					Weapon weapon = (this.GetTV_AvailableWeapons().SelectedNode.Tag.GetType() != typeof(string)) ? ((Weapon)this.GetTV_AvailableWeapons().SelectedNode.Tag) : ((Weapon)this.GetTV_AvailableWeapons().SelectedNode.Parent.Tag);
					if (!this.list_2[0].GetAI().GetTargets().Contains(this.list_3[0]))
					{
						this.list_2[0].GetAI().TargetingContact(this.list_3[0], true, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc);
					}
					this.list_2[0].GetWeaponry().method_14(this.list_3[0], weapon.DBID, 1, true, DateTime.MinValue);
					CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
					this.UpdateAvaibleWeaponInfo();
					this.method_5();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				ex.Data.Add("Error at 101237", "");
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x00028822 File Offset: 0x00026A22
		private void method_33(object sender, TreeNodeMouseClickEventArgs e)
		{
			this.method_34(false);
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x0027FAA4 File Offset: 0x0027DCA4
		private void method_34(bool flag)
		{
			List<ActiveUnit>.Enumerator enumerator = default(List<ActiveUnit>.Enumerator);
			if (!Information.IsNothing(this.GetTV_Allocations_ToTargetsOnly().SelectedNode) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ToTargetsOnly().SelectedNode.Tag)) && this.GetTV_Allocations_ToTargetsOnly().SelectedNode.Tag.GetType() == typeof(WeaponSalvo))
			{
				WeaponSalvo weaponSalvo = (WeaponSalvo)this.GetTV_Allocations_ToTargetsOnly().SelectedNode.Tag;
				if (!Information.IsNothing(weaponSalvo))
				{
					WeaponSalvo.Shooter[] shooters = weaponSalvo.m_Shooters;
					for (int i = 0; i < shooters.Length; i++)
					{
						WeaponSalvo.Shooter shooter = shooters[i];
						try
						{
							enumerator = this.list_2.GetEnumerator();
							while (enumerator.MoveNext())
							{
								ActiveUnit current = enumerator.Current;
								if (Operators.CompareString(shooter.ShooterObjectID, current.GetGuid(), false) == 0 && shooter.QuantityAssigned - shooter.QuantityFired > 0)
								{
									if (flag)
									{
										shooter.QuantityAssigned = shooter.QuantityFired;
									}
									else
									{
										shooter.QuantityAssigned--;
									}
									this.list_2[0].GetSide(false).RemoveWeaponSalvo(weaponSalvo);
								}
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					this.UpdateAvaibleWeaponInfo();
					this.method_5();
				}
			}
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x0002882B File Offset: 0x00026A2B
		private void method_35(object sender, TreeNodeMouseClickEventArgs e)
		{
			this.method_36(false);
		}

		// Token: 0x06005A1B RID: 23067 RVA: 0x0027FC0C File Offset: 0x0027DE0C
		private void method_36(bool flag)
		{
			List<ActiveUnit>.Enumerator enumerator = default(List<ActiveUnit>.Enumerator);
			if (!Information.IsNothing(this.GetTV_Allocations_ToAnyone().SelectedNode) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ToAnyone().SelectedNode.Tag)) && this.GetTV_Allocations_ToAnyone().SelectedNode.Tag.GetType() == typeof(WeaponSalvo))
			{
				WeaponSalvo weaponSalvo = (WeaponSalvo)this.GetTV_Allocations_ToAnyone().SelectedNode.Tag;
				if (!Information.IsNothing(weaponSalvo))
				{
					WeaponSalvo.Shooter[] shooters = weaponSalvo.m_Shooters;
					for (int i = 0; i < shooters.Length; i++)
					{
						WeaponSalvo.Shooter shooter = shooters[i];
						try
						{
							enumerator = this.list_2.GetEnumerator();
							while (enumerator.MoveNext())
							{
								ActiveUnit current = enumerator.Current;
								if (Operators.CompareString(shooter.ShooterObjectID, current.GetGuid(), false) == 0 && shooter.QuantityAssigned - shooter.QuantityFired > 0)
								{
									if (flag)
									{
										shooter.QuantityAssigned = shooter.QuantityFired;
									}
									else
									{
										shooter.QuantityAssigned--;
									}
									this.list_2[0].GetSide(false).RemoveWeaponSalvo(weaponSalvo);
								}
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					this.UpdateAvaibleWeaponInfo();
					this.method_5();
				}
			}
		}

		// Token: 0x06005A1C RID: 23068 RVA: 0x00028834 File Offset: 0x00026A34
		private void TV_Allocations_ByAttackersOnly_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			this.method_38(false);
		}

		// Token: 0x06005A1D RID: 23069 RVA: 0x0027FD74 File Offset: 0x0027DF74
		private void method_38(bool flag)
		{
			if (!Information.IsNothing(this.GetTV_Allocations_ByAttackersOnly().SelectedNode) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ByAttackersOnly().SelectedNode.Tag)) && this.GetTV_Allocations_ByAttackersOnly().SelectedNode.Tag.GetType() == typeof(WeaponSalvo))
			{
				WeaponSalvo weaponSalvo = (WeaponSalvo)this.GetTV_Allocations_ByAttackersOnly().SelectedNode.Tag;
				if (!Information.IsNothing(weaponSalvo))
				{
					WeaponSalvo.Shooter[] shooters = weaponSalvo.m_Shooters;
					for (int i = 0; i < shooters.Length; i++)
					{
						WeaponSalvo.Shooter shooter = shooters[i];
						if (Operators.CompareString(shooter.ShooterObjectID, this.list_2[0].GetGuid(), false) == 0 && shooter.QuantityAssigned - shooter.QuantityFired > 0)
						{
							if (flag)
							{
								shooter.QuantityAssigned = shooter.QuantityFired;
							}
							else
							{
								shooter.QuantityAssigned--;
							}
							this.list_2[0].GetSide(false).RemoveWeaponSalvo(weaponSalvo);
						}
					}
					this.UpdateAvaibleWeaponInfo();
					this.method_5();
				}
			}
		}

		// Token: 0x06005A1E RID: 23070 RVA: 0x0002883D File Offset: 0x00026A3D
		private void method_39(object sender, TreeNodeMouseClickEventArgs e)
		{
			this.method_40(false);
		}

		// Token: 0x06005A1F RID: 23071 RVA: 0x0027FE98 File Offset: 0x0027E098
		private void method_4()
		{
			if (this.vmethod_20().SelectedIndex != 0)
			{
				if (!Information.IsNothing(this.GetTV_Allocations_ToAnyone().SelectedNode) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ToAnyone().SelectedNode.Tag)) && this.GetTV_Allocations_ToAnyone().SelectedNode.Tag.GetType() == typeof(WeaponSalvo))
				{
					this.GetButton_RemoveWeapons_Attacker().Enabled = true;
					WeaponSalvo weaponSalvo = (WeaponSalvo)this.GetTV_Allocations_ToAnyone().SelectedNode.Tag;
					bool flag = weaponSalvo.PlottedCourse.Count<Waypoint>() > 0;
					bool flag2 = weaponSalvo.GetWeapon(Client.GetClientScenario()).method_136();
					this.GetButton_PlotCourse_Attacker().Enabled = flag2;
					this.GetButton_ClearCourse_Attacker().Enabled = (flag2 & flag);
				}
				else
				{
					this.GetButton_RemoveWeapons_Attacker().Enabled = false;
					this.GetButton_PlotCourse_Attacker().Enabled = false;
					this.GetButton_ClearCourse_Attacker().Enabled = false;
				}
			}
			else if (!Information.IsNothing(this.GetTV_Allocations_ToTargetsOnly().SelectedNode) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ToTargetsOnly().SelectedNode.Tag)) && this.GetTV_Allocations_ToTargetsOnly().SelectedNode.Tag.GetType() == typeof(WeaponSalvo))
			{
				this.GetButton_RemoveWeapons_Attacker().Enabled = true;
				WeaponSalvo weaponSalvo2 = (WeaponSalvo)this.GetTV_Allocations_ToTargetsOnly().SelectedNode.Tag;
				bool flag = weaponSalvo2.PlottedCourse.Count<Waypoint>() > 0;
				bool flag2 = weaponSalvo2.GetWeapon(Client.GetClientScenario()).method_136();
				this.GetButton_PlotCourse_Attacker().Enabled = flag2;
				this.GetButton_ClearCourse_Attacker().Enabled = (flag2 & flag);
			}
			else
			{
				this.GetButton_RemoveWeapons_Attacker().Enabled = false;
				this.GetButton_PlotCourse_Attacker().Enabled = false;
				this.GetButton_ClearCourse_Attacker().Enabled = false;
			}
			if (this.vmethod_4().SelectedIndex == 0)
			{
				if (!Information.IsNothing(this.GetTV_Allocations_ByAttackersOnly().SelectedNode) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ByAttackersOnly().SelectedNode.Tag)) && this.GetTV_Allocations_ByAttackersOnly().SelectedNode.Tag.GetType() == typeof(WeaponSalvo))
				{
					this.GetButton_RemoveWeapons_Target().Enabled = true;
					WeaponSalvo weaponSalvo3 = (WeaponSalvo)this.GetTV_Allocations_ByAttackersOnly().SelectedNode.Tag;
					bool flag = weaponSalvo3.PlottedCourse.Count<Waypoint>() > 0;
					bool flag2 = weaponSalvo3.GetWeapon(Client.GetClientScenario()).method_136();
					this.GetButton_PlotCourse_Target().Enabled = flag2;
					this.GetButton_ClearCourse_Target().Enabled = (flag2 & flag);
				}
				else
				{
					this.GetButton_RemoveWeapons_Target().Enabled = false;
					this.GetButton_PlotCourse_Target().Enabled = false;
					this.GetButton_ClearCourse_Target().Enabled = false;
				}
			}
			else if (!Information.IsNothing(this.GetTV_Allocations_ByAnyone().SelectedNode) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ByAnyone().SelectedNode.Tag)) && this.GetTV_Allocations_ByAnyone().SelectedNode.Tag.GetType() == typeof(WeaponSalvo))
			{
				this.GetButton_RemoveWeapons_Target().Enabled = true;
				WeaponSalvo weaponSalvo4 = (WeaponSalvo)this.GetTV_Allocations_ByAnyone().SelectedNode.Tag;
				bool flag = weaponSalvo4.PlottedCourse.Count<Waypoint>() > 0;
				bool flag2 = weaponSalvo4.GetWeapon(Client.GetClientScenario()).method_136();
				this.GetButton_PlotCourse_Target().Enabled = flag2;
				this.GetButton_ClearCourse_Target().Enabled = (flag2 & flag);
			}
			else
			{
				this.GetButton_RemoveWeapons_Target().Enabled = false;
				this.GetButton_PlotCourse_Target().Enabled = false;
				this.GetButton_ClearCourse_Target().Enabled = false;
			}
		}

		// Token: 0x06005A20 RID: 23072 RVA: 0x00280250 File Offset: 0x0027E450
		private void method_40(bool flag)
		{
			if (!Information.IsNothing(this.GetTV_Allocations_ByAnyone().SelectedNode) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ByAnyone().SelectedNode.Tag)) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ByAnyone().SelectedNode.Parent.Tag)) && this.GetTV_Allocations_ByAnyone().SelectedNode.Tag.GetType() == typeof(WeaponSalvo))
			{
				WeaponSalvo weaponSalvo = (WeaponSalvo)this.GetTV_Allocations_ByAnyone().SelectedNode.Tag;
				if (!Information.IsNothing(weaponSalvo))
				{
					WeaponSalvo.Shooter[] shooters = weaponSalvo.m_Shooters;
					for (int i = 0; i < shooters.Length; i++)
					{
						WeaponSalvo.Shooter shooter = shooters[i];
						if (Operators.CompareString(shooter.ShooterObjectID, ((ActiveUnit)this.GetTV_Allocations_ByAnyone().SelectedNode.Parent.Tag).GetGuid(), false) == 0 && shooter.QuantityAssigned - shooter.QuantityFired > 0)
						{
							if (flag)
							{
								shooter.QuantityAssigned = shooter.QuantityFired;
							}
							else
							{
								shooter.QuantityAssigned--;
							}
							this.list_2[0].GetSide(false).RemoveWeaponSalvo(weaponSalvo);
						}
					}
					this.UpdateAvaibleWeaponInfo();
					this.method_5();
				}
			}
		}

		// Token: 0x06005A21 RID: 23073 RVA: 0x000287B6 File Offset: 0x000269B6
		private void method_41(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x06005A22 RID: 23074 RVA: 0x00028846 File Offset: 0x00026A46
		private void method_42(object sender, TreeViewEventArgs e)
		{
			this.method_4();
		}

		// Token: 0x06005A23 RID: 23075 RVA: 0x00028846 File Offset: 0x00026A46
		private void method_43(object sender, TreeViewEventArgs e)
		{
			this.method_4();
		}

		// Token: 0x06005A24 RID: 23076 RVA: 0x00028846 File Offset: 0x00026A46
		private void TV_Allocations_ByAttackersOnly_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.method_4();
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x00028846 File Offset: 0x00026A46
		private void method_45(object sender, TreeViewEventArgs e)
		{
			this.method_4();
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x0002884E File Offset: 0x00026A4E
		private void method_46(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				SimConfiguration.gameOptions.SetSalvoTimeout(this.GetCB_AllowTimeout().Checked);
			}
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x00028870 File Offset: 0x00026A70
		private void method_47(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				SimConfiguration.gameOptions.SetShowAutomaticFireInfo(this.GetCB_ShowAutomaticFireInfo().Checked);
				this.UpdateAvaibleWeaponInfo();
			}
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x002803A8 File Offset: 0x0027E5A8
		private void method_48(object sender, EventArgs e)
		{
			if (this.vmethod_20().SelectedIndex == 0)
			{
				if (!Information.IsNothing(this.GetTV_Allocations_ToTargetsOnly().SelectedNode) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ToTargetsOnly().SelectedNode.Tag)) && this.GetTV_Allocations_ToTargetsOnly().SelectedNode.Tag.GetType() == typeof(WeaponSalvo))
				{
					WeaponSalvo weaponSalvo = (WeaponSalvo)this.GetTV_Allocations_ToTargetsOnly().SelectedNode.Tag;
					if (!Information.IsNothing(weaponSalvo))
					{
						Client.weaponSalvo = weaponSalvo;
						Client.IssueOrdersToUnit(Client._CommandOrder.AddNewWeaponWaypoint);
					}
				}
			}
			else if (!Information.IsNothing(this.GetTV_Allocations_ToAnyone().SelectedNode) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ToAnyone().SelectedNode.Tag)) && this.GetTV_Allocations_ToAnyone().SelectedNode.Tag.GetType() == typeof(WeaponSalvo))
			{
				WeaponSalvo weaponSalvo = (WeaponSalvo)this.GetTV_Allocations_ToAnyone().SelectedNode.Tag;
				if (!Information.IsNothing(weaponSalvo))
				{
					Client.weaponSalvo = weaponSalvo;
					Client.IssueOrdersToUnit(Client._CommandOrder.AddNewWeaponWaypoint);
				}
			}
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x002804DC File Offset: 0x0027E6DC
		private void method_49(object sender, EventArgs e)
		{
			WeaponSalvo weaponSalvo;
			if (this.vmethod_20().SelectedIndex == 0)
			{
				if (Information.IsNothing(this.GetTV_Allocations_ToTargetsOnly().SelectedNode) || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ToTargetsOnly().SelectedNode.Tag)) || this.GetTV_Allocations_ToTargetsOnly().SelectedNode.Tag.GetType() != typeof(WeaponSalvo))
				{
					return;
				}
				weaponSalvo = (WeaponSalvo)this.GetTV_Allocations_ToTargetsOnly().SelectedNode.Tag;
				if (Information.IsNothing(weaponSalvo))
				{
					return;
				}
			}
			else
			{
				if (Information.IsNothing(this.GetTV_Allocations_ToAnyone().SelectedNode) || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ToAnyone().SelectedNode.Tag)) || this.GetTV_Allocations_ToAnyone().SelectedNode.Tag.GetType() != typeof(WeaponSalvo))
				{
					return;
				}
				weaponSalvo = (WeaponSalvo)this.GetTV_Allocations_ToAnyone().SelectedNode.Tag;
				if (Information.IsNothing(weaponSalvo))
				{
					return;
				}
			}
			if (!Information.IsNothing(weaponSalvo))
			{
				ScenarioArrayUtil.ClearWaypoints(ref weaponSalvo.PlottedCourse);
				this.method_2();
			}
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x00280608 File Offset: 0x0027E808
		private void method_5()
		{
			if (this.vmethod_20().SelectedIndex != 0)
			{
				this.method_9();
			}
			else
			{
				this.method_8();
			}
			if (this.vmethod_4().SelectedIndex != 0)
			{
				this.method_11();
			}
			else
			{
				this.method_10();
			}
			this.method_4();
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x00280658 File Offset: 0x0027E858
		private void Button_PlotCourse_Target_Click(object sender, EventArgs e)
		{
			if (this.vmethod_4().SelectedIndex == 0)
			{
				if (!Information.IsNothing(this.GetTV_Allocations_ByAttackersOnly().SelectedNode) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ByAttackersOnly().SelectedNode.Tag)) && this.GetTV_Allocations_ByAttackersOnly().SelectedNode.Tag.GetType() == typeof(WeaponSalvo))
				{
					WeaponSalvo weaponSalvo = (WeaponSalvo)this.GetTV_Allocations_ByAttackersOnly().SelectedNode.Tag;
					if (!Information.IsNothing(weaponSalvo))
					{
						Client.weaponSalvo = weaponSalvo;
						Client.IssueOrdersToUnit(Client._CommandOrder.AddNewWeaponWaypoint);
					}
				}
			}
			else if (!Information.IsNothing(this.GetTV_Allocations_ByAnyone().SelectedNode) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ByAnyone().SelectedNode.Tag)) && this.GetTV_Allocations_ByAnyone().SelectedNode.Tag.GetType() == typeof(WeaponSalvo))
			{
				WeaponSalvo weaponSalvo = (WeaponSalvo)this.GetTV_Allocations_ByAnyone().SelectedNode.Tag;
				if (!Information.IsNothing(weaponSalvo))
				{
					Client.weaponSalvo = weaponSalvo;
					Client.IssueOrdersToUnit(Client._CommandOrder.AddNewWeaponWaypoint);
				}
			}
		}

		// Token: 0x06005A2C RID: 23084 RVA: 0x0028078C File Offset: 0x0027E98C
		private void method_51(object sender, EventArgs e)
		{
			WeaponSalvo weaponSalvo;
			if (this.vmethod_4().SelectedIndex == 0)
			{
				if (Information.IsNothing(this.GetTV_Allocations_ByAttackersOnly().SelectedNode) || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ByAttackersOnly().SelectedNode.Tag)) || this.GetTV_Allocations_ByAttackersOnly().SelectedNode.Tag.GetType() != typeof(WeaponSalvo))
				{
					return;
				}
				weaponSalvo = (WeaponSalvo)this.GetTV_Allocations_ByAttackersOnly().SelectedNode.Tag;
				if (Information.IsNothing(weaponSalvo))
				{
					return;
				}
			}
			else
			{
				if (Information.IsNothing(this.GetTV_Allocations_ByAnyone().SelectedNode) || Information.IsNothing(RuntimeHelpers.GetObjectValue(this.GetTV_Allocations_ByAnyone().SelectedNode.Tag)) || this.GetTV_Allocations_ByAnyone().SelectedNode.Tag.GetType() != typeof(WeaponSalvo))
				{
					return;
				}
				weaponSalvo = (WeaponSalvo)this.GetTV_Allocations_ByAnyone().SelectedNode.Tag;
				if (Information.IsNothing(weaponSalvo))
				{
					return;
				}
			}
			if (!Information.IsNothing(weaponSalvo))
			{
				ScenarioArrayUtil.ClearWaypoints(ref weaponSalvo.PlottedCourse);
				this.method_2();
			}
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x002808B8 File Offset: 0x0027EAB8
		private void TSMI_HighAltitudeDetonation_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.WeaponSalvo_))
			{
				this.GetTSMI_HighAltitudeDetonation().Checked = !this.GetTSMI_HighAltitudeDetonation().Checked;
				if (this.GetTSMI_HighAltitudeDetonation().Checked)
				{
					this.WeaponSalvo_.ASMode = Weapon._ASMode.HighAltitudeDetonation;
				}
				else
				{
					this.WeaponSalvo_.ASMode = Weapon._ASMode.const_0;
				}
			}
		}

		// Token: 0x06005A2E RID: 23086 RVA: 0x00280918 File Offset: 0x0027EB18
		private void method_53()
		{
			Weapon weapon = this.WeaponSalvo_.GetWeapon(Client.GetClientScenario());
			this.GetTSMI_HighAltitudeDetonation().Enabled = weapon.list_3.Contains(Weapon._ASMode.HighAltitudeDetonation);
			this.GetTSMI_HighAltitudeDetonation().Checked = (this.WeaponSalvo_.ASMode == Weapon._ASMode.HighAltitudeDetonation);
		}

		// Token: 0x06005A2F RID: 23087 RVA: 0x00028898 File Offset: 0x00026A98
		private void method_54(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.method_58(this.GetTV_Allocations_ByAnyone(), e);
			}
		}

		// Token: 0x06005A30 RID: 23088 RVA: 0x000288B9 File Offset: 0x00026AB9
		private void TV_Allocations_ByAttackersOnly_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.method_58(this.GetTV_Allocations_ByAttackersOnly(), e);
			}
		}

		// Token: 0x06005A31 RID: 23089 RVA: 0x000288DA File Offset: 0x00026ADA
		private void method_56(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.method_58(this.GetTV_Allocations_ToAnyone(), e);
			}
		}

		// Token: 0x06005A32 RID: 23090 RVA: 0x000288FB File Offset: 0x00026AFB
		private void method_57(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.method_58(this.GetTV_Allocations_ToTargetsOnly(), e);
			}
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x00280968 File Offset: 0x0027EB68
		private void method_58(TreeView treeView, MouseEventArgs mouseEventArg)
		{
			if (!Information.IsNothing(treeView.SelectedNode) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(treeView.SelectedNode.Tag)) && treeView.SelectedNode.Tag.GetType() == typeof(WeaponSalvo))
			{
				this.WeaponSalvo_ = (WeaponSalvo)treeView.SelectedNode.Tag;
				this.method_53();
				this.vmethod_84().Show(treeView, mouseEventArg.X, mouseEventArg.Y);
			}
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x002809F4 File Offset: 0x0027EBF4
		private void method_6()
		{
			List<ActiveUnit>.Enumerator enumerator = default(List<ActiveUnit>.Enumerator);
			IEnumerator<ActiveUnit> enumerator2 = null;
			List<ActiveUnit>.Enumerator enumerator3 = default(List<ActiveUnit>.Enumerator);
			List<ActiveUnit>.Enumerator enumerator4 = default(List<ActiveUnit>.Enumerator);
			List<ActiveUnit>.Enumerator enumerator5 = default(List<ActiveUnit>.Enumerator);
			this.vmethod_32().Items.Clear();
			List<ActiveUnit> list = new List<ActiveUnit>();
			List<ActiveUnit> list2 = new List<ActiveUnit>();
			List<ActiveUnit> source = this.list_1;
			this.list_1 = source.OrderBy(AttackTarget.ActiveUnitFunc0).ToList<ActiveUnit>();
			try
			{
				enumerator = this.list_1.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ActiveUnit current = enumerator.Current;
					if (current.IsGroup)
					{
						using (enumerator2)
						{
							enumerator2 = ((Group)current).GetUnitsInGroup().Values.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								ActiveUnit current2 = enumerator2.Current;
								string text = null;
								if (GameGeneral.CanIssueOrdersToUnit(Client.GetClientSide(), current2, false, ref text) && !this.list_1.Contains(current2))
								{
									list.Add(current2);
								}
							}
						}
						list2.Add(current);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				enumerator3 = list2.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					ActiveUnit current3 = enumerator3.Current;
					this.list_1.Remove(current3);
				}
			}
			finally
			{
				((IDisposable)enumerator3).Dispose();
			}
			try
			{
				enumerator4 = list.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					ActiveUnit current4 = enumerator4.Current;
					this.list_1.Add(current4);
				}
			}
			finally
			{
				((IDisposable)enumerator4).Dispose();
			}
			try
			{
				enumerator5 = this.list_1.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					ActiveUnit current5 = enumerator5.Current;
					ListViewItem item = new ListViewItem
					{
						Text = current5.Name + " (" + Misc.smethod_11(current5.UnitClass) + ")",
						Tag = current5
					};
					this.vmethod_32().Items.Add(item);
				}
			}
			finally
			{
				((IDisposable)enumerator5).Dispose();
			}
			if (this.vmethod_32().Items.Count > 0)
			{
				if (this.int_0 <= this.vmethod_32().Items.Count - 1)
				{
					this.vmethod_32().SelectedIndex = this.int_0;
				}
				else
				{
					this.vmethod_32().SelectedIndex = this.vmethod_32().Items.Count - 1;
				}
			}
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x00280CAC File Offset: 0x0027EEAC
		private void method_7()
		{
			List<Contact>.Enumerator enumerator = default(List<Contact>.Enumerator);
			this.vmethod_10().Items.Clear();
			List<Contact> targetList = this.TargetList;
			this.TargetList = targetList.OrderBy(AttackTarget.ContactFunc1).ToList<Contact>();
			try
			{
				enumerator = this.TargetList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Contact current = enumerator.Current;
					ListViewItem item = new ListViewItem
					{
						Text = current.Name,
						Tag = current
					};
					this.vmethod_10().Items.Add(item);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			if (this.vmethod_10().Items.Count > 0)
			{
				if (this.int_1 <= this.vmethod_10().Items.Count - 1)
				{
					this.vmethod_10().SelectedIndex = this.int_1;
				}
				else
				{
					this.vmethod_10().SelectedIndex = this.vmethod_10().Items.Count - 1;
				}
			}
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x00280DC0 File Offset: 0x0027EFC0
		private void method_8()
		{
			List<ActiveUnit>.Enumerator enumerator = default(List<ActiveUnit>.Enumerator);
			List<WeaponSalvo>.Enumerator enumerator2 = default(List<WeaponSalvo>.Enumerator);
			this.GetTV_Allocations_ToTargetsOnly().Nodes.Clear();
			if (this.list_3.Count == 1)
			{
				try
				{
					enumerator = this.list_2.GetEnumerator();
					while (enumerator.MoveNext())
					{
						ActiveUnit current = enumerator.Current;
						TreeNode treeNode = new TreeNode
						{
							Text = "打击平台: " + current.Name,
							Tag = current
						};
						this.GetTV_Allocations_ToTargetsOnly().Nodes.Add(treeNode);
						Side side = current.GetSide(false);
						List<Contact> list = this.list_3;
						List<Contact> list2 = list;
						Contact value = list[0];
						List<WeaponSalvo> weaponSalvosForTarget = side.GetWeaponSalvosForTarget(ref current, ref value);
						list2[0] = value;
						List<WeaponSalvo> list3 = weaponSalvosForTarget;
						try
						{
							enumerator2 = list3.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								WeaponSalvo current2 = enumerator2.Current;
								WeaponSalvo.Shooter[] shooters = current2.m_Shooters;
								for (int i = 0; i < shooters.Length; i++)
								{
									WeaponSalvo.Shooter shooter = shooters[i];
									if (Operators.CompareString(current.GetGuid(), shooter.ShooterObjectID, false) == 0)
									{
										if (shooter.QuantityAssigned - shooter.QuantityFired > 0)
										{
											string text = (shooter.QuantityAssigned <= 2147473647) ? (Conversions.ToString(shooter.QuantityAssigned - shooter.QuantityFired) + "x ") : "All weapons ";
											TreeNode treeNode2 = new TreeNode();
											this.string_0 = "";
											if (current2.ASMode == Weapon._ASMode.HighAltitudeDetonation)
											{
												this.string_0 += "[高空爆破]";
											}
											if (current2.PlottedCourse.Count<Waypoint>() > 0)
											{
												this.string_0 = this.string_0 + "[" + Conversions.ToString(current2.PlottedCourse.Count<Waypoint>()) + " 航线段]";
											}
											treeNode2.Text = string.Concat(new string[]
											{
												"分配: ",
												this.string_0,
												" ",
												text,
												current2.GetWeapon(current.m_Scenario).Name
											});
											treeNode2.Tag = current2;
											treeNode.Nodes.Add(treeNode2);
										}
										if (shooter.QuantityFired > 0)
										{
											TreeNode node = new TreeNode
											{
												Text = "开火: " + Conversions.ToString(shooter.QuantityFired) + "x " + current2.GetWeapon(current.m_Scenario).Name
											};
											treeNode.Nodes.Add(node);
										}
									}
								}
							}
						}
						finally
						{
							((IDisposable)enumerator2).Dispose();
						}
						treeNode.Expand();
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x002810E8 File Offset: 0x0027F2E8
		private void method_9()
		{
			List<ActiveUnit>.Enumerator enumerator = default(List<ActiveUnit>.Enumerator);
			List<WeaponSalvo>.Enumerator enumerator2 = default(List<WeaponSalvo>.Enumerator);
			this.GetTV_Allocations_ToAnyone().Nodes.Clear();
			try
			{
				enumerator = this.list_2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ActiveUnit current = enumerator.Current;
					TreeNode treeNode = new TreeNode
					{
						Text = "打击平台: " + current.Name,
						Tag = current
					};
					this.GetTV_Allocations_ToAnyone().Nodes.Add(treeNode);
					List<WeaponSalvo> weaponSalvoList = current.GetSide(false).GetWeaponSalvoList(ref current);
					try
					{
						enumerator2 = weaponSalvoList.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							WeaponSalvo current2 = enumerator2.Current;
							WeaponSalvo.Shooter[] shooters = current2.m_Shooters;
							for (int i = 0; i < shooters.Length; i++)
							{
								WeaponSalvo.Shooter shooter = shooters[i];
								if (Operators.CompareString(current.GetGuid(), shooter.ShooterObjectID, false) == 0)
								{
									if (shooter.QuantityAssigned - shooter.QuantityFired > 0)
									{
										string text = (shooter.QuantityAssigned <= 2147473647) ? (Conversions.ToString(shooter.QuantityAssigned - shooter.QuantityFired) + "x ") : "所有武器";
										TreeNode node = new TreeNode
										{
											Text = string.Concat(new string[]
											{
												"分配到 ",
												current2.Target.Name,
												": ",
												text,
												current2.GetWeapon(current.m_Scenario).Name
											}),
											Tag = current2
										};
										treeNode.Nodes.Add(node);
									}
									if (shooter.QuantityFired > 0)
									{
										TreeNode node2 = new TreeNode
										{
											Text = string.Concat(new string[]
											{
												"攻击目标",
												current2.Target.Name,
												": ",
												Conversions.ToString(shooter.QuantityFired),
												"x ",
												current2.GetWeapon(current.m_Scenario).Name
											})
										};
										treeNode.Nodes.Add(node2);
									}
								}
							}
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
					}
					treeNode.Expand();
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06005A38 RID: 23096
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SendMessage(IntPtr intPtr_0, int int_, IntPtr IntPtr_1, IntPtr IntPtr_2);

		// Token: 0x04002C8E RID: 11406
		public static Func<ActiveUnit, string> ActiveUnitFunc0 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x04002C8F RID: 11407
		public static Func<Contact, string> ContactFunc1 = (Contact contact_0) => contact_0.Name;

		// Token: 0x04002C90 RID: 11408
		private Label label_0;

		// Token: 0x04002C91 RID: 11409
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04002C92 RID: 11410
		[CompilerGenerated]
		private TabControl tabControl_0;

		// Token: 0x04002C93 RID: 11411
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x04002C94 RID: 11412
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x04002C95 RID: 11413
		[CompilerGenerated]
		private ListBox listBox_0;

		// Token: 0x04002C96 RID: 11414
		[CompilerGenerated]
		private TreeView TV_Allocations_ByAttackersOnl;

		// Token: 0x04002C97 RID: 11415
		[CompilerGenerated]
		private TreeView TV_Allocations_ByAnyone;

		// Token: 0x04002C98 RID: 11416
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x04002C99 RID: 11417
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04002C9A RID: 11418
		[CompilerGenerated]
		private TabControl tabControl_1;

		// Token: 0x04002C9B RID: 11419
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x04002C9C RID: 11420
		[CompilerGenerated]
		private TreeView treeView_2;

		// Token: 0x04002C9D RID: 11421
		[CompilerGenerated]
		private TabPage tabPage_3;

		// Token: 0x04002C9E RID: 11422
		[CompilerGenerated]
		private TreeView treeView_3;

		// Token: 0x04002C9F RID: 11423
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04002CA0 RID: 11424
		[CompilerGenerated]
		private ListBox listBox_1;

		// Token: 0x04002CA1 RID: 11425
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04002CA2 RID: 11426
		[CompilerGenerated]
		private TreeView TV_AvailableWeapons;

		// Token: 0x04002CA3 RID: 11427
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04002CA4 RID: 11428
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04002CA5 RID: 11429
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x04002CA6 RID: 11430
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04002CA7 RID: 11431
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04002CA8 RID: 11432
		[CompilerGenerated]
		private Button button_4;

		// Token: 0x04002CA9 RID: 11433
		[CompilerGenerated]
		private Button Button_RemoveAttacker;

		// Token: 0x04002CAA RID: 11434
		[CompilerGenerated]
		private Button button_6;

		// Token: 0x04002CAB RID: 11435
		[CompilerGenerated]
		private Button Button_AllocateSalvo;

		// Token: 0x04002CAC RID: 11436
		[CompilerGenerated]
		private Button Button_RemoveWeapons_Target;

		// Token: 0x04002CAD RID: 11437
		[CompilerGenerated]
		private Button Button_RemoveWeapons_Attacker;

		// Token: 0x04002CAE RID: 11438
		[CompilerGenerated]
		private TableLayoutPanel tableLayoutPanel_0;

		// Token: 0x04002CAF RID: 11439
		[CompilerGenerated]
		private Panel panel_0;

		// Token: 0x04002CB0 RID: 11440
		[CompilerGenerated]
		private Panel panel_1;

		// Token: 0x04002CB1 RID: 11441
		[CompilerGenerated]
		private Panel panel_2;

		// Token: 0x04002CB2 RID: 11442
		[CompilerGenerated]
		private Panel panel_3;

		// Token: 0x04002CB3 RID: 11443
		[CompilerGenerated]
		private Panel panel_4;

		// Token: 0x04002CB4 RID: 11444
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04002CB5 RID: 11445
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x04002CB6 RID: 11446
		[CompilerGenerated]
		private Button button_10;

		// Token: 0x04002CB7 RID: 11447
		[CompilerGenerated]
		private Button button_11;

		// Token: 0x04002CB8 RID: 11448
		[CompilerGenerated]
		private Button button_12;

		// Token: 0x04002CB9 RID: 11449
		[CompilerGenerated]
		private Button Button_PlotCourse_Target;

		// Token: 0x04002CBA RID: 11450
		[CompilerGenerated]
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x04002CBB RID: 11451
		[CompilerGenerated]
		private ToolStripMenuItem TSMI_HighAltitudeDetonation;

		// Token: 0x04002CBD RID: 11453
		public List<Contact> TargetList;

		// Token: 0x04002CBE RID: 11454
		public List<ActiveUnit> list_1;

		// Token: 0x04002CBF RID: 11455
		private List<ActiveUnit> list_2;

		// Token: 0x04002CC0 RID: 11456
		private int int_0;

		// Token: 0x04002CC1 RID: 11457
		private List<Contact> list_3;

		// Token: 0x04002CC2 RID: 11458
		private int int_1;

		// Token: 0x04002CC3 RID: 11459
		private int? nullable_0;

		// Token: 0x04002CC4 RID: 11460
		private int int_2 = 0;

		// Token: 0x04002CC5 RID: 11461
		private bool bool_0;

		// Token: 0x04002CC6 RID: 11462
		private bool bool_1;

		// Token: 0x04002CC7 RID: 11463
		private string string_0;

		// Token: 0x04002CC8 RID: 11464
		private WeaponSalvo WeaponSalvo_;
	}
}

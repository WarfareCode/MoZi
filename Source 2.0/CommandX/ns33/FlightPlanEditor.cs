using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns32;
using ns4;

namespace ns33
{
	// Token: 0x02000A27 RID: 2599
	[DesignerGenerated]
	public sealed partial class FlightPlanEditor : CommandForm
	{
		// Token: 0x060050F7 RID: 20727 RVA: 0x0020EA90 File Offset: 0x0020CC90
		public FlightPlanEditor()
		{
			base.FormClosing += new FormClosingEventHandler(this.FlightPlanEditor_FormClosing);
			base.FormClosed += new FormClosedEventHandler(this.FlightPlanEditor_FormClosed);
			base.Load += new EventHandler(this.FlightPlanEditor_Load);
			base.VisibleChanged += new EventHandler(this.FlightPlanEditor_VisibleChanged);
			base.KeyDown += new KeyEventHandler(this.FlightPlanEditor_KeyDown);
			base.Shown += new EventHandler(this.FlightPlanEditor_Shown);
			this.bool_0 = true;
			this.int_0 = 0;
			this.bool_1 = false;
			this.dataTable_0 = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x060050FA RID: 20730 RVA: 0x0020FC78 File Offset: 0x0020DE78
		[CompilerGenerated]
		internal  TabControl GetTabControl_Aircraft()
		{
			return this.TabControl_Aircraft;
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x0020FC90 File Offset: 0x0020DE90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetTabControl_Aircraft(TabControl tabControl_1)
		{
			EventHandler value = new EventHandler(this.TabControl_Aircraft_SelectedIndexChanged);
			TabControl tabControl_Aircraft = this.TabControl_Aircraft;
			if (tabControl_Aircraft != null)
			{
				tabControl_Aircraft.SelectedIndexChanged -= value;
			}
			this.TabControl_Aircraft = tabControl_1;
			tabControl_Aircraft = this.TabControl_Aircraft;
			if (tabControl_Aircraft != null)
			{
				tabControl_Aircraft.SelectedIndexChanged += value;
			}
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x0020FCDC File Offset: 0x0020DEDC
		[CompilerGenerated]
		internal  TabPage GetTabPage1()
		{
			return this.tabPage_0;
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x00025E09 File Offset: 0x00024009
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TabPage tabPage_6)
		{
			this.tabPage_0 = tabPage_6;
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x0020FCF4 File Offset: 0x0020DEF4
		[CompilerGenerated]
		internal  TabPage GetTabPage2()
		{
			return this.tabPage_1;
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x00025E12 File Offset: 0x00024012
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TabPage tabPage_6)
		{
			this.tabPage_1 = tabPage_6;
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x0020FD0C File Offset: 0x0020DF0C
		[CompilerGenerated]
		internal  TabPage GetTabPage3()
		{
			return this.tabPage_2;
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x00025E1B File Offset: 0x0002401B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TabPage tabPage_6)
		{
			this.tabPage_2 = tabPage_6;
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x0020FD24 File Offset: 0x0020DF24
		[CompilerGenerated]
		internal  TabPage GetTabPage4()
		{
			return this.tabPage_3;
		}

		// Token: 0x06005103 RID: 20739 RVA: 0x00025E24 File Offset: 0x00024024
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(TabPage tabPage_6)
		{
			this.tabPage_3 = tabPage_6;
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x0020FD3C File Offset: 0x0020DF3C
		[CompilerGenerated]
		internal  TabPage GetTabPage5()
		{
			return this.tabPage_4;
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x00025E2D File Offset: 0x0002402D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TabPage tabPage_6)
		{
			this.tabPage_4 = tabPage_6;
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x0020FD54 File Offset: 0x0020DF54
		[CompilerGenerated]
		internal  TabPage GetTabPage6()
		{
			return this.tabPage_5;
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x00025E36 File Offset: 0x00024036
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(TabPage tabPage_6)
		{
			this.tabPage_5 = tabPage_6;
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x0020FD6C File Offset: 0x0020DF6C
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_0;
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x00025E3F File Offset: 0x0002403F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_8)
		{
			this.label_0 = label_8;
		}

		// Token: 0x0600510A RID: 20746 RVA: 0x0020FD84 File Offset: 0x0020DF84
		[CompilerGenerated]
		internal  Label vmethod_16()
		{
			return this.label_1;
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x00025E48 File Offset: 0x00024048
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_8)
		{
			this.label_1 = label_8;
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x0020FD9C File Offset: 0x0020DF9C
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_2;
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x00025E51 File Offset: 0x00024051
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_8)
		{
			this.label_2 = label_8;
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x0020FDB4 File Offset: 0x0020DFB4
		[CompilerGenerated]
		internal  Label vmethod_20()
		{
			return this.label_3;
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x00025E5A File Offset: 0x0002405A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Label label_8)
		{
			this.label_3 = label_8;
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x0020FDCC File Offset: 0x0020DFCC
		[CompilerGenerated]
		internal  ComboBox GetCombo_CurrentPackage()
		{
			return this.comboBox_0;
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x0020FDE4 File Offset: 0x0020DFE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCombo_CurrentPackage(ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.Combo_CurrentPackage_SelectionChangeCommitted);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_5;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x0020FE30 File Offset: 0x0020E030
		[CompilerGenerated]
		internal  ComboBox GetCombo_CurrentFlightPlan()
		{
			return this.Combo_CurrentFlightPlan;
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x0020FE48 File Offset: 0x0020E048
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCombo_CurrentFlightPlan(ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.Combo_CurrentFlightPlan_SelectionChangeCommitted);
			ComboBox combo_CurrentFlightPlan = this.Combo_CurrentFlightPlan;
			if (combo_CurrentFlightPlan != null)
			{
				combo_CurrentFlightPlan.SelectionChangeCommitted -= value;
			}
			this.Combo_CurrentFlightPlan = comboBox_5;
			combo_CurrentFlightPlan = this.Combo_CurrentFlightPlan;
			if (combo_CurrentFlightPlan != null)
			{
				combo_CurrentFlightPlan.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x0020FE94 File Offset: 0x0020E094
		[CompilerGenerated]
		internal  ComboBox GetCombo_FlightTask()
		{
			return this.Combo_FlightTask;
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x0020FEAC File Offset: 0x0020E0AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCombo_FlightTask(ComboBox comboBox_5)
		{
			EventHandler value = new EventHandler(this.Combo_FlightTask_SelectionChangeCommitted);
			ComboBox combo_FlightTask = this.Combo_FlightTask;
			if (combo_FlightTask != null)
			{
				combo_FlightTask.SelectionChangeCommitted -= value;
			}
			this.Combo_FlightTask = comboBox_5;
			combo_FlightTask = this.Combo_FlightTask;
			if (combo_FlightTask != null)
			{
				combo_FlightTask.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x0020FEF8 File Offset: 0x0020E0F8
		[CompilerGenerated]
		internal  TextBox GetTextBox_FlightCallsign()
		{
			return this.TextBox_FlightCallsign;
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x0020FF10 File Offset: 0x0020E110
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetTextBox_FlightCallsign(TextBox textBox_1)
		{
			KeyPressEventHandler value = new KeyPressEventHandler(this.TextBox_FlightCallsign_KeyPress);
			EventHandler value2 = new EventHandler(this.TextBox_FlightCallsign_Enter);
			EventHandler value3 = new EventHandler(this.TextBox_FlightCallsign_Leave);
			TextBox textBox_FlightCallsign = this.TextBox_FlightCallsign;
			if (textBox_FlightCallsign != null)
			{
				textBox_FlightCallsign.KeyPress -= value;
				textBox_FlightCallsign.Enter -= value2;
				textBox_FlightCallsign.Leave -= value3;
			}
			this.TextBox_FlightCallsign = textBox_1;
			textBox_FlightCallsign = this.TextBox_FlightCallsign;
			if (textBox_FlightCallsign != null)
			{
				textBox_FlightCallsign.KeyPress += value;
				textBox_FlightCallsign.Enter += value2;
				textBox_FlightCallsign.Leave += value3;
			}
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x0020FF90 File Offset: 0x0020E190
		[CompilerGenerated]
		internal  Button GetButton_CreateCopy()
		{
			return this.Button_CreateCopy;
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x0020FFA8 File Offset: 0x0020E1A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_CreateCopy(Button button_2)
		{
			EventHandler value = new EventHandler(this.Button_CreateCopy_Click);
			Button button_CreateCopy = this.Button_CreateCopy;
			if (button_CreateCopy != null)
			{
				button_CreateCopy.Click -= value;
			}
			this.Button_CreateCopy = button_2;
			button_CreateCopy = this.Button_CreateCopy;
			if (button_CreateCopy != null)
			{
				button_CreateCopy.Click += value;
			}
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x0020FFF4 File Offset: 0x0020E1F4
		[CompilerGenerated]
		internal  Button GetButton_Reset()
		{
			return this.Button_Reset;
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x0021000C File Offset: 0x0020E20C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_Reset(Button button_2)
		{
			EventHandler value = new EventHandler(this.Button_Reset_Click);
			Button button_Reset = this.Button_Reset;
			if (button_Reset != null)
			{
				button_Reset.Click -= value;
			}
			this.Button_Reset = button_2;
			button_Reset = this.Button_Reset;
			if (button_Reset != null)
			{
				button_Reset.Click += value;
			}
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x00210058 File Offset: 0x0020E258
		[CompilerGenerated]
		internal  Label GetLabel_FlightDate()
		{
			return this.label_4;
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x00025E63 File Offset: 0x00024063
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(Label label_8)
		{
			this.label_4 = label_8;
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x00210070 File Offset: 0x0020E270
		[CompilerGenerated]
		internal  CheckBox GetCheckBox_OneTimeOnly()
		{
			return this.CheckBox_OneTimeOnly;
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x00025E6C File Offset: 0x0002406C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(CheckBox checkBox_2)
		{
			this.CheckBox_OneTimeOnly = checkBox_2;
		}

		// Token: 0x06005120 RID: 20768 RVA: 0x00210088 File Offset: 0x0020E288
		[CompilerGenerated]
		internal  CheckBox GetCheckBox_TimeBound()
		{
			return this.checkBox_1;
		}

		// Token: 0x06005121 RID: 20769 RVA: 0x00025E75 File Offset: 0x00024075
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(CheckBox checkBox_2)
		{
			this.checkBox_1 = checkBox_2;
		}

		// Token: 0x06005122 RID: 20770 RVA: 0x002100A0 File Offset: 0x0020E2A0
		[CompilerGenerated]
		internal  ComboBox GetCombo_AircraftType()
		{
			return this.comboBox_3;
		}

		// Token: 0x06005123 RID: 20771 RVA: 0x00025E7E File Offset: 0x0002407E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(ComboBox comboBox_5)
		{
			this.comboBox_3 = comboBox_5;
		}

		// Token: 0x06005124 RID: 20772 RVA: 0x002100B8 File Offset: 0x0020E2B8
		[CompilerGenerated]
		internal  Label vmethod_42()
		{
			return this.label_5;
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x00025E87 File Offset: 0x00024087
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(Label label_8)
		{
			this.label_5 = label_8;
		}

		// Token: 0x06005126 RID: 20774 RVA: 0x002100D0 File Offset: 0x0020E2D0
		[CompilerGenerated]
		internal  ComboBox GetComboBox_Loadout()
		{
			return this.comboBox_4;
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x00025E90 File Offset: 0x00024090
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(ComboBox comboBox_5)
		{
			this.comboBox_4 = comboBox_5;
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x002100E8 File Offset: 0x0020E2E8
		[CompilerGenerated]
		internal  Label vmethod_46()
		{
			return this.label_6;
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x00025E99 File Offset: 0x00024099
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(Label label_8)
		{
			this.label_6 = label_8;
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x00210100 File Offset: 0x0020E300
		[CompilerGenerated]
		internal  FlightPlanWaypoints GetFlightPlanWaypoints1()
		{
			return this.FlightPlanWaypoints1;
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x00025EA2 File Offset: 0x000240A2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(FlightPlanWaypoints flightPlanWaypoints_7)
		{
			this.FlightPlanWaypoints1 = flightPlanWaypoints_7;
		}

		// Token: 0x0600512C RID: 20780 RVA: 0x00210118 File Offset: 0x0020E318
		[CompilerGenerated]
		internal  Label vmethod_50()
		{
			return this.Label_Date;
		}

		// Token: 0x0600512D RID: 20781 RVA: 0x00025EAB File Offset: 0x000240AB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(Label label_8)
		{
			this.Label_Date = label_8;
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x00210130 File Offset: 0x0020E330
		[CompilerGenerated]
		internal  FlightPlanWaypoints GetFlightPlanWaypoints2()
		{
			return this.FlightPlanWaypoints2;
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x00025EB4 File Offset: 0x000240B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(FlightPlanWaypoints flightPlanWaypoints_7)
		{
			this.FlightPlanWaypoints2 = flightPlanWaypoints_7;
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x00210148 File Offset: 0x0020E348
		[CompilerGenerated]
		internal  FlightPlanWaypoints GetFlightPlanWaypoints3()
		{
			return this.FlightPlanWaypoints3;
		}

		// Token: 0x06005131 RID: 20785 RVA: 0x00025EBD File Offset: 0x000240BD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(FlightPlanWaypoints flightPlanWaypoints_7)
		{
			this.FlightPlanWaypoints3 = flightPlanWaypoints_7;
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x00210160 File Offset: 0x0020E360
		[CompilerGenerated]
		internal  FlightPlanWaypoints GetFlightPlanWaypoints4()
		{
			return this.FlightPlanWaypoints4;
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x00025EC6 File Offset: 0x000240C6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(FlightPlanWaypoints flightPlanWaypoints_7)
		{
			this.FlightPlanWaypoints4 = flightPlanWaypoints_7;
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x00210178 File Offset: 0x0020E378
		[CompilerGenerated]
		internal  FlightPlanWaypoints GetFlightPlanWaypoints5()
		{
			return this.FlightPlanWaypoints5;
		}

		// Token: 0x06005135 RID: 20789 RVA: 0x00025ECF File Offset: 0x000240CF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(FlightPlanWaypoints flightPlanWaypoints_7)
		{
			this.FlightPlanWaypoints5 = flightPlanWaypoints_7;
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x00210190 File Offset: 0x0020E390
		[CompilerGenerated]
		internal  FlightPlanWaypoints GetFlightPlanWaypoints6()
		{
			return this.FlightPlanWaypoints6;
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x00025ED8 File Offset: 0x000240D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(FlightPlanWaypoints flightPlanWaypoints_7)
		{
			this.FlightPlanWaypoints6 = flightPlanWaypoints_7;
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x002101A8 File Offset: 0x0020E3A8
		private void method_1(Subject Subject_, bool? nullable_0, bool bool_2, bool bool_3, bool bool_4, bool bool_5)
		{
			if (!Information.IsNothing(Subject_) && Subject_.GetType() == typeof(Waypoint) && base.Visible && !bool_4 && (bool_3 || bool_5))
			{
				this.method_7();
			}
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x002101A8 File Offset: 0x0020E3A8
		private void method_2(Subject Subject_, bool? nullable_0, bool bool_2, bool bool_3, bool bool_4, bool bool_5)
		{
			if (!Information.IsNothing(Subject_) && Subject_.GetType() == typeof(Waypoint) && base.Visible && !bool_4 && (bool_3 || bool_5))
			{
				this.method_7();
			}
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x00025EE1 File Offset: 0x000240E1
		private void FlightPlanEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x00025EFF File Offset: 0x000240FF
		private void FlightPlanEditor_FormClosed(object sender, FormClosedEventArgs e)
		{
			Doctrine.smethod_1(new Doctrine.Delegate9(this.method_1));
			Doctrine.smethod_3(new Doctrine.Delegate10(this.method_2));
			MissionEditor.smethod_1(new MissionEditor.Delegate64(this.method_3));
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x00025F34 File Offset: 0x00024134
		private void FlightPlanEditor_Load(object sender, EventArgs e)
		{
			Doctrine.smethod_0(new Doctrine.Delegate9(this.method_1));
			Doctrine.smethod_2(new Doctrine.Delegate10(this.method_2));
			MissionEditor.smethod_0(new MissionEditor.Delegate64(this.method_3));
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x002101F8 File Offset: 0x0020E3F8
		private void FlightPlanEditor_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				this.method_6();
				this.method_5();
				if (Client.flightPlanTime.Visible)
				{
					Client.flightPlanTime.method_2();
				}
			}
			Client.b_Completed = true;
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x0021024C File Offset: 0x0020E44C
		private void method_3(Subject Subject_)
		{
			try
			{
				if (!Information.IsNothing(Subject_))
				{
					this.method_6();
					this.method_5();
					if (Client.flightPlanTime.Visible)
					{
						Client.flightPlanTime.method_2();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200630", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x002102D8 File Offset: 0x0020E4D8
		private string GetThrottleString(ref ActiveUnit.Throttle throttle_)
		{
			string result;
			switch (throttle_)
			{
			case ActiveUnit.Throttle.FullStop:
				result = "停车";
				break;
			case ActiveUnit.Throttle.Loiter:
				result = "低速";
				break;
			case ActiveUnit.Throttle.Cruise:
				result = "巡航";
				break;
			case ActiveUnit.Throttle.Full:
				result = "军用";
				break;
			case ActiveUnit.Throttle.Flank:
				result = "加力";
				break;
			default:
				throw new NotImplementedException();
			}
			return result;
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x00210334 File Offset: 0x0020E534
		internal void method_5()
		{
			this.GetCombo_CurrentPackage().Items.Clear();
			int num = 0;
			foreach (Mission current in Client.GetClientSide().GetMissionCollection())
			{
				this.GetCombo_CurrentPackage().Items.Insert(num, current.Name);
				if (current == this.m_mission)
				{
					this.GetCombo_CurrentPackage().SelectedIndex = num;
				}
				num++;
			}
			this.GetCombo_CurrentFlightPlan().Items.Clear();
			num = 0;
			foreach (Mission.Flight current2 in this.m_mission.FlightList)
			{
				this.GetCombo_CurrentFlightPlan().Items.Insert(num, current2.Callsign);
				if (!Information.IsNothing(this.m_Flight))
				{
					if (current2 == this.m_Flight)
					{
						this.GetCombo_CurrentFlightPlan().SelectedIndex = num;
					}
					num++;
				}
			}
			if (Information.IsNothing(this.m_Flight))
			{
				this.GetCombo_CurrentFlightPlan().SelectedIndex = -1;
				this.GetCombo_CurrentFlightPlan().Text = "";
				this.GetTextBox_FlightCallsign().Text = "";
			}
			else
			{
				this.GetTextBox_FlightCallsign().Text = this.m_Flight.Callsign;
			}
			if (Information.IsNothing(this.m_Flight))
			{
				this.GetCombo_FlightTask().DataSource = null;
				this.GetCombo_FlightTask().Items.Clear();
				this.GetCombo_FlightTask().SelectedIndex = -1;
				this.GetCheckBox_TimeBound().Checked = false;
				this.GetCheckBox_OneTimeOnly().Checked = false;
			}
			else
			{
				DataTable dataSource = new DataTable();
				Mission.Flight.LoadTaskDataTable(ref dataSource);
				ComboBox combo_FlightTask = this.GetCombo_FlightTask();
				combo_FlightTask.DataSource = dataSource;
				combo_FlightTask.DisplayMember = "Description";
				combo_FlightTask.ValueMember = "ID";
				combo_FlightTask.DropDownWidth = 500;
				this.GetCombo_FlightTask().SelectedIndex = Mission.Flight.GetTaskIndex(this.m_Flight.Task);
				this.GetCheckBox_TimeBound().Checked = this.m_Flight.TimeBound;
				this.GetCheckBox_OneTimeOnly().Checked = this.m_Flight.OneTime;
			}
			if (!Information.IsNothing(this.m_Flight) && this.m_Flight.GetFlightCourse().Count<Waypoint>() != 0)
			{
				if (Information.IsNothing(this.m_Flight.GetFlightCourse()[0].ArrivalTime_Zulu))
				{
					this.GetLabel_FlightDate().Text = "日期: -";
				}
				else
				{
					this.GetLabel_FlightDate().Text = Conversions.ToString(this.m_Flight.GetFlightCourse()[0].ArrivalTime_Zulu.Value.Date);
				}
			}
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x00210620 File Offset: 0x0020E820
		internal void method_6()
		{
			if (Information.IsNothing(this.m_mission))
			{
				this.dataTable_0.Clear();
				this.method_5();
			}
			else if (Information.IsNothing(this.m_Flight))
			{
				this.dataTable_0.Clear();
				this.method_5();
			}
			else if (!this.m_mission.HasFlights())
			{
				this.dataTable_0.Clear();
				this.method_5();
			}
			else
			{
				switch (this.m_Flight.DesiredAircraftQty)
				{
				case Mission._FlightSize.SingleAircraft:
					this.GetTabControl_Aircraft().TabPages[0].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[1].Enabled = false;
					this.GetTabControl_Aircraft().TabPages[2].Enabled = false;
					this.GetTabControl_Aircraft().TabPages[3].Enabled = false;
					this.GetTabControl_Aircraft().TabPages[4].Enabled = false;
					this.GetTabControl_Aircraft().TabPages[5].Enabled = false;
					if (this.GetTabControl_Aircraft().SelectedIndex > 0)
					{
						this.GetTabControl_Aircraft().SelectedIndex = 0;
					}
					break;
				case Mission._FlightSize.TwoAircraft:
					this.GetTabControl_Aircraft().TabPages[0].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[1].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[2].Enabled = false;
					this.GetTabControl_Aircraft().TabPages[3].Enabled = false;
					this.GetTabControl_Aircraft().TabPages[4].Enabled = false;
					this.GetTabControl_Aircraft().TabPages[5].Enabled = false;
					if (this.GetTabControl_Aircraft().SelectedIndex > 1)
					{
						this.GetTabControl_Aircraft().SelectedIndex = 0;
					}
					break;
				case Mission._FlightSize.ThreeAircraft:
					this.GetTabControl_Aircraft().TabPages[0].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[1].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[2].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[3].Enabled = false;
					this.GetTabControl_Aircraft().TabPages[4].Enabled = false;
					this.GetTabControl_Aircraft().TabPages[5].Enabled = false;
					if (this.GetTabControl_Aircraft().SelectedIndex > 2)
					{
						this.GetTabControl_Aircraft().SelectedIndex = 0;
					}
					break;
				case Mission._FlightSize.FourAircraft:
					this.GetTabControl_Aircraft().TabPages[0].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[1].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[2].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[3].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[4].Enabled = false;
					this.GetTabControl_Aircraft().TabPages[5].Enabled = false;
					if (this.GetTabControl_Aircraft().SelectedIndex > 3)
					{
						this.GetTabControl_Aircraft().SelectedIndex = 0;
					}
					break;
				case (Mission._FlightSize)5:
					return;
				case Mission._FlightSize.SixAircraft:
					this.GetTabControl_Aircraft().TabPages[0].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[1].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[2].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[3].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[4].Enabled = true;
					this.GetTabControl_Aircraft().TabPages[5].Enabled = true;
					break;
				default:
					return;
				}
				if (this.GetTabControl_Aircraft().SelectedIndex == 0)
				{
					this.SelectedFlightPlanWaypoints = this.GetFlightPlanWaypoints1();
				}
				else if (this.GetTabControl_Aircraft().SelectedIndex == 1)
				{
					this.SelectedFlightPlanWaypoints = this.GetFlightPlanWaypoints2();
				}
				else if (this.GetTabControl_Aircraft().SelectedIndex == 2)
				{
					this.SelectedFlightPlanWaypoints = this.GetFlightPlanWaypoints3();
				}
				else if (this.GetTabControl_Aircraft().SelectedIndex == 3)
				{
					this.SelectedFlightPlanWaypoints = this.GetFlightPlanWaypoints4();
				}
				else if (this.GetTabControl_Aircraft().SelectedIndex == 4)
				{
					this.SelectedFlightPlanWaypoints = this.GetFlightPlanWaypoints5();
				}
				else
				{
					if (this.GetTabControl_Aircraft().SelectedIndex != 5)
					{
						return;
					}
					this.SelectedFlightPlanWaypoints = this.GetFlightPlanWaypoints6();
				}
				this.GetFlightPlanWaypoints1().enum70_0 = Mission.Flight._FlightRole.const_1;
				this.GetFlightPlanWaypoints2().enum70_0 = Mission.Flight._FlightRole.const_2;
				this.GetFlightPlanWaypoints3().enum70_0 = Mission.Flight._FlightRole.const_3;
				this.GetFlightPlanWaypoints4().enum70_0 = Mission.Flight._FlightRole.const_4;
				this.GetFlightPlanWaypoints5().enum70_0 = Mission.Flight._FlightRole.const_5;
				this.GetFlightPlanWaypoints6().enum70_0 = Mission.Flight._FlightRole.const_6;
				if (this.SelectedFlightPlanWaypoints.vmethod_0().SelectedRows.Count > 0)
				{
					this.int_0 = this.SelectedFlightPlanWaypoints.vmethod_0().SelectedRows[0].Index;
				}
				this.dataTable_0.Clear();
				if (!this.dataTable_0.Columns.Contains("ID"))
				{
					this.dataTable_0.Columns.Add("ID", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("ObjectID"))
				{
					this.dataTable_0.Columns.Add("ObjectID", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("Type"))
				{
					this.dataTable_0.Columns.Add("Type", typeof(int));
				}
				if (!this.dataTable_0.Columns.Contains("Time_Zulu"))
				{
					this.dataTable_0.Columns.Add("Time_Zulu", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("Time_Local"))
				{
					this.dataTable_0.Columns.Add("Time_Local", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("TimeFixed"))
				{
					this.dataTable_0.Columns.Add("TimeFixed", typeof(int));
				}
				if (!this.dataTable_0.Columns.Contains("TimeFixedImg"))
				{
					this.dataTable_0.Columns.Add("TimeFixedImg", typeof(Image));
				}
				if (!this.dataTable_0.Columns.Contains("DesiredSpeed"))
				{
					this.dataTable_0.Columns.Add("DesiredSpeed", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("SpeedFixed"))
				{
					this.dataTable_0.Columns.Add("SpeedFixed", typeof(int));
				}
				if (!this.dataTable_0.Columns.Contains("SpeedFixedImg"))
				{
					this.dataTable_0.Columns.Add("SpeedFixedImg", typeof(Image));
				}
				if (!this.dataTable_0.Columns.Contains("DesiredAltitude"))
				{
					this.dataTable_0.Columns.Add("DesiredAltitude", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("Leg_FuelRequired"))
				{
					this.dataTable_0.Columns.Add("Leg_FuelRequired", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("Leg_FuelRemaining"))
				{
					this.dataTable_0.Columns.Add("Leg_FuelRemaining", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("Leg_Time"))
				{
					this.dataTable_0.Columns.Add("Leg_Time", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("Hold_Time"))
				{
					this.dataTable_0.Columns.Add("Hold_Time", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("Leg_TotalTime"))
				{
					this.dataTable_0.Columns.Add("Leg_TotalTime", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("Leg_Distance"))
				{
					this.dataTable_0.Columns.Add("Leg_Distance", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("Leg_TotalDistance"))
				{
					this.dataTable_0.Columns.Add("Leg_TotalDistance", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("Formation"))
				{
					this.dataTable_0.Columns.Add("Formation", typeof(int));
				}
				if (!this.dataTable_0.Columns.Contains("AARSettings"))
				{
					this.dataTable_0.Columns.Add("AARSettings", typeof(int));
				}
				if (!this.dataTable_0.Columns.Contains("AARUsage"))
				{
					this.dataTable_0.Columns.Add("AARUsage", typeof(int));
				}
				if (!this.dataTable_0.Columns.Contains("AARSelection"))
				{
					this.dataTable_0.Columns.Add("AARSelection", typeof(int));
				}
				if (!this.dataTable_0.Columns.Contains("TurnRate"))
				{
					this.dataTable_0.Columns.Add("TurnRate", typeof(int));
				}
				if (!this.dataTable_0.Columns.Contains("Doctrine"))
				{
					this.dataTable_0.Columns.Add("Doctrine", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("SensorUsage"))
				{
					this.dataTable_0.Columns.Add("SensorUsage", typeof(string));
				}
				if (!this.dataTable_0.Columns.Contains("Coordinates"))
				{
					this.dataTable_0.Columns.Add("Coordinates", typeof(string));
				}
				this.bool_0 = false;
				Waypoint[] flightCourse = this.m_Flight.GetFlightCourse();
				int count;
				int num;
				checked
				{
					for (int i = 0; i < flightCourse.Length; i++)
					{
						DataRow row = this.dataTable_0.NewRow();
						this.dataTable_0.Rows.Add(row);
					}
					this.bool_0 = true;
					this.method_7();
					DataTable dataSource = new DataTable();
					DataTable dataSource2 = new DataTable();
					DataTable dataSource3 = new DataTable();
					DataTable dataSource4 = new DataTable();
					DataTable dataSource5 = new DataTable();
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn = (DataGridViewComboBoxColumn)this.SelectedFlightPlanWaypoints.vmethod_0().Columns[this.SelectedFlightPlanWaypoints.vmethod_0().Columns["Type"].Index];
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn2 = (DataGridViewComboBoxColumn)this.SelectedFlightPlanWaypoints.vmethod_0().Columns[this.SelectedFlightPlanWaypoints.vmethod_0().Columns["AARUsage"].Index];
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn3 = (DataGridViewComboBoxColumn)this.SelectedFlightPlanWaypoints.vmethod_0().Columns[this.SelectedFlightPlanWaypoints.vmethod_0().Columns["AARSelection"].Index];
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn4 = (DataGridViewComboBoxColumn)this.SelectedFlightPlanWaypoints.vmethod_0().Columns[this.SelectedFlightPlanWaypoints.vmethod_0().Columns["Formation"].Index];
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn5 = (DataGridViewComboBoxColumn)this.SelectedFlightPlanWaypoints.vmethod_0().Columns[this.SelectedFlightPlanWaypoints.vmethod_0().Columns["TurnRate"].Index];
					Waypoint.smethod_12(ref dataSource);
					this.m_mission.m_Doctrine.method_52(ref dataSource2, Client.GetClientScenario(), new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_1));
					this.m_mission.m_Doctrine.method_53(ref dataSource3, Client.GetClientScenario(), new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
					Waypoint.smethod_16(ref dataSource4);
					Waypoint.smethod_17(ref dataSource5);
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn6 = dataGridViewComboBoxColumn;
					dataGridViewComboBoxColumn6.DataSource = dataSource;
					dataGridViewComboBoxColumn6.DisplayMember = "Description";
					dataGridViewComboBoxColumn6.ValueMember = "ID";
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn7 = dataGridViewComboBoxColumn2;
					dataGridViewComboBoxColumn7.DataSource = dataSource2;
					dataGridViewComboBoxColumn7.DisplayMember = "Description";
					dataGridViewComboBoxColumn7.ValueMember = "ID";
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn8 = dataGridViewComboBoxColumn3;
					dataGridViewComboBoxColumn8.DataSource = dataSource3;
					dataGridViewComboBoxColumn8.DisplayMember = "Description";
					dataGridViewComboBoxColumn8.ValueMember = "ID";
					DataGridViewComboBoxColumn dataGridViewComboBoxColumn9 = dataGridViewComboBoxColumn4;
					dataGridViewComboBoxColumn9.DataSource = dataSource4;
					dataGridViewComboBoxColumn9.DisplayMember = "Description";
					dataGridViewComboBoxColumn9.ValueMember = "ID";
					dataGridViewComboBoxColumn5.DataSource = dataSource5;
					dataGridViewComboBoxColumn5.DisplayMember = "Description";
					dataGridViewComboBoxColumn5.ValueMember = "ID";
					this.bool_0 = false;
					this.SelectedFlightPlanWaypoints.vmethod_0().DataSource = new DataView(this.dataTable_0);
					this.bool_0 = true;
					this.SelectedFlightPlanWaypoints.vmethod_0().Tag = this.m_Flight;
					count = this.SelectedFlightPlanWaypoints.vmethod_0().Rows.Count;
					num = this.m_Flight.GetFlightCourse().Count<Waypoint>();
				}
				for (int j = count - 1; j >= 0; j += -1)
				{
					if (j <= num - 1)
					{
						Waypoint expression = this.m_Flight.GetFlightCourse()[j];
						if (!Information.IsNothing(expression))
						{
							Waypoint tag = FlightPlanWaypoints.smethod_0(ref expression, this.SelectedFlightPlanWaypoints.enum70_0);
							this.SelectedFlightPlanWaypoints.vmethod_0().Rows[j].Tag = tag;
						}
					}
				}
				if (this.SelectedFlightPlanWaypoints.vmethod_0().RowCount > 0)
				{
					if (this.int_0 > this.SelectedFlightPlanWaypoints.vmethod_0().RowCount - 1)
					{
						this.SelectedFlightPlanWaypoints.vmethod_0().Rows[0].Selected = true;
					}
					else
					{
						this.SelectedFlightPlanWaypoints.vmethod_0().Rows[this.int_0].Selected = true;
					}
				}
				this.SelectedFlightPlanWaypoints.method_15();
			}
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x00211500 File Offset: 0x0020F700
		internal void method_7()
		{
			if (!Information.IsNothing(this.m_mission) && !Information.IsNothing(this.m_Flight) && this.m_mission.HasFlights())
			{
				int num = 1;
				DateTime currentTime = Client.GetClientScenario().GetCurrentTime(false);
				bool flag = Client.GetClientScenario().IsUseDaylightSavingTime();
				string daylightSavingTime_Start = Client.GetClientScenario().GetDaylightSavingTime_Start();
				string daylightSavingTime_End = Client.GetClientScenario().GetDaylightSavingTime_End();
				int num2 = this.m_Flight.GetFlightCourse().Count<Waypoint>() - 1;
				for (int i = 0; i <= num2; i++)
				{
					Waypoint waypoint = this.m_Flight.GetFlightCourse()[i];
					if (this.GetTabControl_Aircraft().SelectedIndex == 0)
					{
						waypoint = this.m_Flight.GetFlightCourse()[i];
					}
					else if (this.GetTabControl_Aircraft().SelectedIndex == 1)
					{
						if (Information.IsNothing(this.m_Flight.GetFlightCourse()[i].WP_LeadElementWingman))
						{
							waypoint = this.m_Flight.GetFlightCourse()[i];
						}
						else if (!Information.IsNothing(this.m_Flight.GetFlightCourse()[i].WP_LeadElementWingman) && this.m_Flight.GetFlightCourse()[i].FlightFormation != Waypoint._FlightFormation.Split)
						{
							waypoint = this.m_Flight.GetFlightCourse()[i];
						}
						else
						{
							waypoint = this.m_Flight.GetFlightCourse()[i].WP_LeadElementWingman;
						}
					}
					else if (this.GetTabControl_Aircraft().SelectedIndex == 2)
					{
						if (Information.IsNothing(this.m_Flight.GetFlightCourse()[i].WP_SecondElement))
						{
							waypoint = this.m_Flight.GetFlightCourse()[i];
						}
						else if (!Information.IsNothing(this.m_Flight.GetFlightCourse()[i].WP_SecondElement) && this.m_Flight.GetFlightCourse()[i].FlightFormation != Waypoint._FlightFormation.Split)
						{
							waypoint = this.m_Flight.GetFlightCourse()[i];
						}
						else
						{
							waypoint = this.m_Flight.GetFlightCourse()[i].WP_SecondElement;
						}
					}
					else if (this.GetTabControl_Aircraft().SelectedIndex == 3)
					{
						if (Information.IsNothing(this.m_Flight.GetFlightCourse()[i].WP_SecondElementWingman))
						{
							waypoint = this.m_Flight.GetFlightCourse()[i];
						}
						else if (!Information.IsNothing(this.m_Flight.GetFlightCourse()[i].WP_SecondElementWingman) && this.m_Flight.GetFlightCourse()[i].FlightFormation != Waypoint._FlightFormation.Split)
						{
							waypoint = this.m_Flight.GetFlightCourse()[i];
						}
						else
						{
							waypoint = this.m_Flight.GetFlightCourse()[i].WP_SecondElementWingman;
						}
					}
					else if (this.GetTabControl_Aircraft().SelectedIndex == 4)
					{
						if (Information.IsNothing(this.m_Flight.GetFlightCourse()[i].WP_ThirdElement))
						{
							waypoint = this.m_Flight.GetFlightCourse()[i];
						}
						else if (!Information.IsNothing(this.m_Flight.GetFlightCourse()[i].WP_ThirdElement) && this.m_Flight.GetFlightCourse()[i].FlightFormation != Waypoint._FlightFormation.Split)
						{
							waypoint = this.m_Flight.GetFlightCourse()[i];
						}
						else
						{
							waypoint = this.m_Flight.GetFlightCourse()[i].WP_ThirdElement;
						}
					}
					else
					{
						if (this.GetTabControl_Aircraft().SelectedIndex != 5)
						{
							break;
						}
						if (Information.IsNothing(this.m_Flight.GetFlightCourse()[i].WP_ThirdElementWingman))
						{
							waypoint = this.m_Flight.GetFlightCourse()[i];
						}
						else if (!Information.IsNothing(this.m_Flight.GetFlightCourse()[i].WP_ThirdElementWingman) && this.m_Flight.GetFlightCourse()[i].FlightFormation != Waypoint._FlightFormation.Split)
						{
							waypoint = this.m_Flight.GetFlightCourse()[i];
						}
						else
						{
							waypoint = this.m_Flight.GetFlightCourse()[i].WP_ThirdElementWingman;
						}
					}
					DataRow dataRow = this.dataTable_0.AsEnumerable().ElementAtOrDefault(i);
					if (string.IsNullOrEmpty(waypoint.Description))
					{
						dataRow["ID"] = num;
					}
					else
					{
						dataRow["ID"] = waypoint.Description;
					}
					num++;
					dataRow["ObjectID"] = waypoint.GetGuid();
					if (waypoint.waypointType == Waypoint.WaypointType.WeaponTarget)
					{
						dataRow["Time_Zulu"] = "-";
						dataRow["Time_Local"] = "-";
						dataRow["Type"] = Waypoint.smethod_14(waypoint.waypointType);
						dataRow["TimeFixed"] = Waypoint.Enum52.const_3;
						dataRow["DesiredSpeed"] = "-";
						dataRow["SpeedFixed"] = Waypoint.Enum52.const_3;
						dataRow["DesiredAltitude"] = "-";
						dataRow["Formation"] = Waypoint.smethod_20(waypoint.FlightFormation);
						dataRow["AARUsage"] = 3;
						dataRow["AARSelection"] = 3;
						dataRow["AARSettings"] = waypoint.TankerMaxDistance_Airborne;
						dataRow["TurnRate"] = waypoint.TurnRate;
						dataRow["Doctrine"] = "-";
						dataRow["SensorUsage"] = "-";
						dataRow["Coordinates"] = Misc.GetGeoLocationString(waypoint.GetLatitude(), waypoint.GetLongitude());
						dataRow["Leg_FuelRequired"] = "-";
						dataRow["Leg_FuelRemaining"] = "-";
						dataRow["Leg_Time"] = "-";
						dataRow["Leg_TotalTime"] = "-";
						dataRow["Leg_Distance"] = "-";
						dataRow["Leg_TotalDistance"] = "-";
						dataRow["Hold_Time"] = "-";
					}
					else
					{
						string text;
						if (!Information.IsNothing(waypoint.ArrivalTime_Zulu))
						{
							if (waypoint.ArrivalTime_Zulu.Value.Hour < 10)
							{
								text = "0" + waypoint.ArrivalTime_Zulu.Value.Hour.ToString() + ":";
							}
							else
							{
								text = waypoint.ArrivalTime_Zulu.Value.Hour.ToString() + ":";
							}
							if (waypoint.ArrivalTime_Zulu.Value.Minute < 10)
							{
								text = text + "0" + waypoint.ArrivalTime_Zulu.Value.Minute.ToString() + ":";
							}
							else
							{
								text = text + waypoint.ArrivalTime_Zulu.Value.Minute.ToString() + ":";
							}
							if (waypoint.ArrivalTime_Zulu.Value.Second < 10)
							{
								text = text + "0" + waypoint.ArrivalTime_Zulu.Value.Second.ToString();
							}
							else
							{
								text += waypoint.ArrivalTime_Zulu.Value.Second.ToString();
							}
						}
						else
						{
							text = "-";
						}
						dataRow["Time_Zulu"] = text;
						string text2;
						if (!Information.IsNothing(waypoint.ArrivalTime_Local))
						{
							if (waypoint.ArrivalTime_Local.Value.Hour < 10)
							{
								text2 = "0" + waypoint.ArrivalTime_Local.Value.Hour.ToString() + ":";
							}
							else
							{
								text2 = waypoint.ArrivalTime_Local.Value.Hour.ToString() + ":";
							}
							if (waypoint.ArrivalTime_Local.Value.Minute < 10)
							{
								text2 = text2 + "0" + waypoint.ArrivalTime_Local.Value.Minute.ToString() + ":";
							}
							else
							{
								text2 = text2 + waypoint.ArrivalTime_Local.Value.Minute.ToString() + ":";
							}
							if (waypoint.ArrivalTime_Local.Value.Second < 10)
							{
								text2 = text2 + "0" + waypoint.ArrivalTime_Local.Value.Second.ToString();
							}
							else
							{
								text2 += waypoint.ArrivalTime_Local.Value.Second.ToString();
							}
							waypoint.TimeOfDay = Class240.GetTimeOfDay(waypoint.ArrivalTime_Zulu.Value.Year, waypoint.ArrivalTime_Zulu.Value.Month, waypoint.ArrivalTime_Zulu.Value.Day, waypoint.ArrivalTime_Zulu.Value.Hour, waypoint.ArrivalTime_Zulu.Value.Minute, waypoint.ArrivalTime_Zulu.Value.Second, waypoint.GetLatitude(), waypoint.GetLongitude(), 0.0);
							waypoint.ArrivalTime_Local = new DateTime?(Misc.GetLocalTime(waypoint.ArrivalTime_Zulu.Value, waypoint.GetLongitude(), flag, daylightSavingTime_Start, daylightSavingTime_End));
							text2 = text2 + ", (" + Class240.GetTimeOfDayString(waypoint.TimeOfDay, currentTime, waypoint.GetLongitude(), flag, daylightSavingTime_Start, daylightSavingTime_End) + ")";
						}
						else
						{
							text2 = "-";
						}
						dataRow["Time_Local"] = text2;
						dataRow["Type"] = Waypoint.smethod_14(waypoint.waypointType);
						if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
						{
							dataRow["TimeFixed"] = Waypoint.Enum52.const_3;
						}
						else
						{
							dataRow["TimeFixed"] = waypoint.TimeFixed;
						}
						string text3;
						if (!Information.IsNothing(waypoint.GetDSO()) && !Information.IsNothing(waypoint.DesiredSpeed))
						{
							float? desiredSpeed;
							float? num3 = desiredSpeed = waypoint.DesiredSpeed;
							text3 = (num3.HasValue ? Conversions.ToString(desiredSpeed.GetValueOrDefault()) : null) + " kt";
							if (!Information.IsNothing(this.m_Flight.GetReferenceUnit(Client.GetClientScenario())) && waypoint.GetDAO())
							{
								if (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
								{
									string str = text3;
									string str2 = " (";
									ActiveUnit.Throttle throttle = this.m_Flight.GetReferenceUnit(Client.GetClientScenario()).GetKinematics().vmethod_38(waypoint.DesiredAltitude_TerrainFollowing.Value, waypoint.DesiredSpeed.Value);
									text3 = str + str2 + this.GetThrottleString(ref throttle) + ")";
								}
								else if (!Information.IsNothing(waypoint.DesiredAltitude))
								{
									string str3 = text3;
									string str4 = " (";
									ActiveUnit.Throttle throttle = this.m_Flight.GetReferenceUnit(Client.GetClientScenario()).GetKinematics().vmethod_38(waypoint.DesiredAltitude.Value, waypoint.DesiredSpeed.Value);
									text3 = str3 + str4 + this.GetThrottleString(ref throttle) + ")";
								}
							}
						}
						else if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
						{
							ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)waypoint.GetThrottlePreset();
							text3 = this.GetThrottleString(ref throttle);
							if (waypoint.GetDAO())
							{
								string str5 = text3;
								string str6 = " (";
								float? desiredSpeed;
								float? num3 = desiredSpeed = waypoint.DesiredSpeed;
								text3 = str5 + str6 + (num3.HasValue ? Conversions.ToString(desiredSpeed.GetValueOrDefault()) : null) + " kt)";
							}
						}
						else
						{
							text3 = "速度未设定!";
						}
						dataRow["DesiredSpeed"] = text3;
						dataRow["SpeedFixed"] = waypoint.SpeedFixed;
						string value = "";
						if (!Information.IsNothing(waypoint.GetDAO()) && (!Information.IsNothing(waypoint.DesiredAltitude) || (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))))
						{
							if (SimConfiguration.gameOptions.UseImperialUnit())
							{
								if (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
								{
									if ((int)Math.Round((double)waypoint.DesiredAltitude_TerrainFollowing.Value) == 0)
									{
										value = "Minimum";
									}
									else
									{
										float? num4 = waypoint.DesiredAltitude_TerrainFollowing;
										value = Conversions.ToString((int)Math.Round((double)(num4.HasValue ? new float?(num4.GetValueOrDefault() * 3.28084f) : null).Value)) + "英尺(真高)";
									}
								}
								else if (!Information.IsNothing(waypoint.DesiredAltitude))
								{
									if ((int)Math.Round((double)waypoint.DesiredAltitude.Value) == 0)
									{
										value = "Minimum";
									}
									else
									{
										float? num4 = waypoint.DesiredAltitude;
										value = Conversions.ToString((int)Math.Round((double)(num4.HasValue ? new float?(num4.GetValueOrDefault() * 3.28084f) : null).Value)) + "英尺(海高)";
									}
								}
							}
							else if (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
							{
								if ((int)Math.Round((double)waypoint.DesiredAltitude_TerrainFollowing.Value) == 0)
								{
									value = "Minimum";
								}
								else
								{
									value = Conversions.ToString((int)Math.Round((double)waypoint.DesiredAltitude_TerrainFollowing.Value)) + "米(真高)";
								}
							}
							else if (!Information.IsNothing(waypoint.DesiredAltitude))
							{
								if ((int)Math.Round((double)waypoint.DesiredAltitude.Value) == 0)
								{
									value = "Minimum";
								}
								else
								{
									value = Conversions.ToString((int)Math.Round((double)waypoint.DesiredAltitude.Value)) + "米(海高)";
								}
							}
						}
						else if (!Information.IsNothing(waypoint.GetAltitudePreset()) && waypoint.GetAltitudePreset() != ActiveUnit_AI._AltitudePreset.None)
						{
							switch (waypoint.GetAltitudePreset())
							{
							case ActiveUnit_AI._AltitudePreset.MinAltitude:
								value = "Minimum";
								break;
							case ActiveUnit_AI._AltitudePreset.LowAltitude1000:
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									if (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
									{
										value = Conversions.ToString(305) + "英尺(真高)";
									}
									else if (!Information.IsNothing(waypoint.DesiredAltitude))
									{
										value = Conversions.ToString(305) + "英尺(海高)";
									}
								}
								else if (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
								{
									value = Conversions.ToString(305) + "米(真高)";
								}
								else if (!Information.IsNothing(waypoint.DesiredAltitude))
								{
									value = Conversions.ToString(305) + "米(海高)";
								}
								break;
							case ActiveUnit_AI._AltitudePreset.LowAltitude2000:
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									if (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
									{
										value = Conversions.ToString(610) + "英尺(真高)";
									}
									else if (!Information.IsNothing(waypoint.DesiredAltitude))
									{
										value = Conversions.ToString(610) + "英尺(海高)";
									}
								}
								else if (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
								{
									value = Conversions.ToString(610) + "米(真高)";
								}
								else if (!Information.IsNothing(waypoint.DesiredAltitude))
								{
									value = Conversions.ToString(610) + "米(海高)";
								}
								break;
							case ActiveUnit_AI._AltitudePreset.MediumAltitude12000:
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									if (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
									{
										value = Conversions.ToString(3658) + "英尺(真高)";
									}
									else if (!Information.IsNothing(waypoint.DesiredAltitude))
									{
										value = Conversions.ToString(3658) + "英尺(海高)";
									}
								}
								else if (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
								{
									value = Conversions.ToString(3658) + "米(真高)";
								}
								else if (!Information.IsNothing(waypoint.DesiredAltitude))
								{
									value = Conversions.ToString(3658) + "米(海高)";
								}
								break;
							case ActiveUnit_AI._AltitudePreset.HighAltitude25000:
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									if (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
									{
										value = Conversions.ToString(7620) + "英尺(真高)";
									}
									else if (!Information.IsNothing(waypoint.DesiredAltitude))
									{
										value = Conversions.ToString(7620) + "英尺(海高)";
									}
								}
								else if (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
								{
									value = Conversions.ToString(7620) + "米(真高)";
								}
								else if (!Information.IsNothing(waypoint.DesiredAltitude))
								{
									value = Conversions.ToString(7620) + "米(海高)";
								}
								break;
							case ActiveUnit_AI._AltitudePreset.HighAltitude36000:
								if (SimConfiguration.gameOptions.UseImperialUnit())
								{
									if (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
									{
										value = Conversions.ToString(10973) + "英尺(真高)";
									}
									else if (!Information.IsNothing(waypoint.DesiredAltitude))
									{
										value = Conversions.ToString(10973) + "英尺(海高)";
									}
								}
								else if (waypoint.IsTerrainFollowing() && !Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
								{
									value = Conversions.ToString(10973) + "米(真高)";
								}
								else if (!Information.IsNothing(waypoint.DesiredAltitude))
								{
									value = Conversions.ToString(10973) + "米(海高)";
								}
								break;
							case ActiveUnit_AI._AltitudePreset.MaxAltitude:
								value = "Maximum";
								break;
							}
						}
						else
						{
							value = "高度未设定!";
						}
						dataRow["DesiredAltitude"] = value;
						dataRow["Formation"] = Waypoint.smethod_20(waypoint.FlightFormation);
						if (waypoint.m_Doctrine.UseRefuelHasNoValue())
						{
							dataRow["AARUsage"] = 3;
						}
						else
						{
							switch (waypoint.m_Doctrine.GetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false).Value)
							{
							case Doctrine._UseRefuel.const_0:
								dataRow["AARUsage"] = 1;
								break;
							case Doctrine._UseRefuel.const_1:
								dataRow["AARUsage"] = 2;
								break;
							case Doctrine._UseRefuel.const_2:
								dataRow["AARUsage"] = 0;
								break;
							}
						}
						if (waypoint.m_Doctrine.UseRefuelHasNoValue())
						{
							dataRow["AARSelection"] = 3;
						}
						else
						{
							switch (waypoint.m_Doctrine.GetRefuelSelectionDoctrine(Client.GetClientScenario(), false, false, false, false).Value)
							{
							case Doctrine._RefuelSelection.const_0:
								dataRow["AARSelection"] = 0;
								break;
							case Doctrine._RefuelSelection.const_1:
								dataRow["AARSelection"] = 1;
								break;
							case Doctrine._RefuelSelection.const_2:
								dataRow["AARSelection"] = 2;
								break;
							}
						}
						dataRow["AARSettings"] = waypoint.TankerMaxDistance_Airborne;
						dataRow["TurnRate"] = waypoint.TurnRate;
						dataRow["Doctrine"] = "Something whatever";
						if (waypoint.m_Doctrine.EMCON_SettingsHasNoValue())
						{
							dataRow["SensorUsage"] = "采用任务设置";
						}
						else
						{
							string text4 = "";
							if (waypoint.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar() == Doctrine.EMCON_Settings.Enum36.const_1)
							{
								text4 = "雷达打开";
							}
							else if (waypoint.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForRadar() == Doctrine.EMCON_Settings.Enum36.const_0)
							{
								text4 = "雷达静默";
							}
							if (waypoint.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar() == Doctrine.EMCON_Settings.Enum36.const_1)
							{
								if (!string.IsNullOrEmpty(text4))
								{
									text4 += ", ";
								}
								text4 += "声纳打开";
							}
							else if (waypoint.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForSonar() == Doctrine.EMCON_Settings.Enum36.const_0)
							{
								if (!string.IsNullOrEmpty(text4))
								{
									text4 += ", ";
								}
								text4 += "声纳静默";
							}
							if (waypoint.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM() == Doctrine.EMCON_Settings.Enum36.const_1)
							{
								if (!string.IsNullOrEmpty(text4))
								{
									text4 += ", ";
								}
								text4 += "干扰机打开";
							}
							else if (waypoint.m_Doctrine.GetEMCON_Settings(Client.GetClientScenario()).GetEMCON_SettingsForOECM() == Doctrine.EMCON_Settings.Enum36.const_0)
							{
								if (!string.IsNullOrEmpty(text4))
								{
									text4 += ", ";
								}
								text4 += "干扰机静默";
							}
							if (string.IsNullOrEmpty(text4))
							{
								text4 = "未配";
							}
							dataRow["SensorUsage"] = text4;
						}
						dataRow["Coordinates"] = Misc.GetGeoLocationString(waypoint.GetLatitude(), waypoint.GetLongitude());
						if (waypoint.waypointType == Waypoint.WaypointType.TakeOff)
						{
							dataRow["Leg_FuelRequired"] = "-";
							dataRow["Leg_FuelRemaining"] = Conversions.ToString((int)Math.Round((double)waypoint.Leg_FuelRemaining)) + " kg";
							dataRow["Leg_Time"] = "-";
							dataRow["Leg_TotalTime"] = "-";
							dataRow["Leg_Distance"] = "-";
							dataRow["Leg_TotalDistance"] = "-";
							dataRow["Hold_Time"] = "-";
							Doctrine._UseRefuel? useRefuel = waypoint.m_Doctrine.GetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false);
						}
						else
						{
							dataRow["Leg_FuelRequired"] = Conversions.ToString((int)Math.Round((double)waypoint.Leg_FuelRequired)) + " kg";
							Doctrine._UseRefuel? useRefuel = null;
							byte? b = useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null;
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								dataRow["Leg_FuelRemaining"] = Conversions.ToString((int)Math.Round((double)waypoint.Leg_FuelRemaining)) + " kg";
							}
							else
							{
								dataRow["Leg_FuelRemaining"] = "未知，允许空中加油";
							}
							useRefuel = waypoint.m_Doctrine.GetUseRefuelDoctrine(Client.GetClientScenario(), false, false, false, false);
							dataRow["Leg_Time"] = Misc.GetTimeString((long)Math.Round((double)waypoint.Leg_Time), Aircraft_AirOps._Maintenance.const_0, false, true);
							dataRow["Leg_TotalTime"] = Misc.GetTimeString((long)Math.Round((double)waypoint.Leg_TotalTime), Aircraft_AirOps._Maintenance.const_0, false, true);
							dataRow["Leg_Distance"] = Conversions.ToString((int)Math.Round((double)(waypoint.Leg_Distance + waypoint.float_10))) + " nm";
							dataRow["Leg_TotalDistance"] = Conversions.ToString((int)Math.Round((double)waypoint.Leg_TotalDistance)) + " nm";
							if (waypoint.Hold_Time > 0f)
							{
								if (!Information.IsNothing(waypoint.ArrivalTime_Zulu))
								{
									dataRow["Hold_Time"] = Misc.GetTimeString((long)Math.Round((double)waypoint.Hold_Time), Aircraft_AirOps._Maintenance.const_0, false, true);
								}
								else
								{
									dataRow["Hold_Time"] = "N/A";
								}
							}
							else
							{
								dataRow["Hold_Time"] = "-";
							}
						}
					}
				}
			}
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void Button_CreateCopy_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void Button_Reset_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x00212F54 File Offset: 0x00211154
		private void Combo_CurrentPackage_SelectionChangeCommitted(object sender, EventArgs e)
		{
			foreach (Mission current in Client.GetClientSide().GetMissionCollection())
			{
				if (Operators.CompareString(current.Name, Conversions.ToString(this.GetCombo_CurrentPackage().SelectedItem), false) == 0)
				{
					this.m_mission = current;
					break;
				}
			}
			if (this.m_mission.HasFlights())
			{
				this.m_Flight = this.m_mission.FlightList[0];
			}
			this.method_6();
			this.method_5();
			if (Client.flightPlanTime.Visible)
			{
				Client.flightPlanTime.method_2();
			}
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x0021301C File Offset: 0x0021121C
		private void Combo_CurrentFlightPlan_SelectionChangeCommitted(object sender, EventArgs e)
		{
			foreach (Mission.Flight current in this.m_mission.FlightList)
			{
				if (Operators.CompareString(current.Callsign, Conversions.ToString(this.GetCombo_CurrentFlightPlan().SelectedItem), false) == 0)
				{
					this.m_Flight = current;
					break;
				}
			}
			this.method_6();
			this.method_5();
			if (Client.flightPlanTime.Visible)
			{
				Client.flightPlanTime.method_2();
			}
		}

		// Token: 0x06005147 RID: 20807 RVA: 0x00025F69 File Offset: 0x00024169
		private void Combo_FlightTask_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.m_Flight))
			{
				this.m_Flight.Task = Mission.Flight.GetTask(this.GetCombo_FlightTask().SelectedIndex);
			}
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x002130C0 File Offset: 0x002112C0
		private void FlightPlanEditor_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Hide();
			}
			else if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void FlightPlanEditor_Shown(object sender, EventArgs e)
		{
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x00025F98 File Offset: 0x00024198
		private void TabControl_Aircraft_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_6();
			if (Client.flightPlanTime.Visible)
			{
				Client.flightPlanTime.method_2();
			}
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x00025FB9 File Offset: 0x000241B9
		private void TextBox_FlightCallsign_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x00025FD4 File Offset: 0x000241D4
		private void TextBox_FlightCallsign_Enter(object sender, EventArgs e)
		{
			this.bool_1 = true;
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x00025FDD File Offset: 0x000241DD
		private void TextBox_FlightCallsign_Leave(object sender, EventArgs e)
		{
			this.method_17();
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x00025FE5 File Offset: 0x000241E5
		private void method_17()
		{
			if (this.bool_1)
			{
				this.m_Flight.Callsign = this.GetTextBox_FlightCallsign().Text;
			}
			this.bool_1 = false;
			this.method_5();
		}

		// Token: 0x04002612 RID: 9746
		[CompilerGenerated]
		private TabControl TabControl_Aircraft;

		// Token: 0x04002613 RID: 9747
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x04002614 RID: 9748
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x04002615 RID: 9749
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x04002616 RID: 9750
		[CompilerGenerated]
		private TabPage tabPage_3;

		// Token: 0x04002617 RID: 9751
		[CompilerGenerated]
		private TabPage tabPage_4;

		// Token: 0x04002618 RID: 9752
		[CompilerGenerated]
		private TabPage tabPage_5;

		// Token: 0x04002619 RID: 9753
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x0400261A RID: 9754
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x0400261B RID: 9755
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x0400261C RID: 9756
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x0400261D RID: 9757
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x0400261E RID: 9758
		[CompilerGenerated]
		private ComboBox Combo_CurrentFlightPlan;

		// Token: 0x0400261F RID: 9759
		[CompilerGenerated]
		private ComboBox Combo_FlightTask;

		// Token: 0x04002620 RID: 9760
		[CompilerGenerated]
		private TextBox TextBox_FlightCallsign;

		// Token: 0x04002621 RID: 9761
		[CompilerGenerated]
		private Button Button_CreateCopy;

		// Token: 0x04002622 RID: 9762
		[CompilerGenerated]
		private Button Button_Reset;

		// Token: 0x04002623 RID: 9763
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04002624 RID: 9764
		[CompilerGenerated]
		private CheckBox CheckBox_OneTimeOnly;

		// Token: 0x04002625 RID: 9765
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x04002626 RID: 9766
		[CompilerGenerated]
		private ComboBox comboBox_3;

		// Token: 0x04002627 RID: 9767
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x04002628 RID: 9768
		[CompilerGenerated]
		private ComboBox comboBox_4;

		// Token: 0x04002629 RID: 9769
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x0400262A RID: 9770
		[CompilerGenerated]
		private FlightPlanWaypoints FlightPlanWaypoints1;

		// Token: 0x0400262B RID: 9771
		[CompilerGenerated]
		private Label Label_Date;

		// Token: 0x0400262C RID: 9772
		[CompilerGenerated]
		private FlightPlanWaypoints FlightPlanWaypoints2;

		// Token: 0x0400262D RID: 9773
		[CompilerGenerated]
		private FlightPlanWaypoints FlightPlanWaypoints3;

		// Token: 0x0400262E RID: 9774
		[CompilerGenerated]
		private FlightPlanWaypoints FlightPlanWaypoints4;

		// Token: 0x0400262F RID: 9775
		[CompilerGenerated]
		private FlightPlanWaypoints FlightPlanWaypoints5;

		// Token: 0x04002630 RID: 9776
		[CompilerGenerated]
		private FlightPlanWaypoints FlightPlanWaypoints6;

		// Token: 0x04002631 RID: 9777
		public bool bool_0;

		// 任务使命
		public Mission m_mission;

		// Token: 0x04002633 RID: 9779
		public Mission.Flight m_Flight;

		// Token: 0x04002634 RID: 9780
		private int int_0;

		// Token: 0x04002635 RID: 9781
		private bool bool_1;

		// 飞行计划路径点
		public FlightPlanWaypoints SelectedFlightPlanWaypoints;

		// Token: 0x04002637 RID: 9783
		private DataTable dataTable_0;
	}
}

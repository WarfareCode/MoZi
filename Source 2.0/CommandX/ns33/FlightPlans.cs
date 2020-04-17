using System;
using System.Collections;
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
using ns32;
using ns4;

namespace ns33
{
	// Token: 0x02000A2B RID: 2603
	[DesignerGenerated]
	public sealed partial class FlightPlans : CommandForm
	{
		// Token: 0x06005199 RID: 20889 RVA: 0x00214D54 File Offset: 0x00212F54
		public FlightPlans()
		{
			base.FormClosing += new FormClosingEventHandler(this.FlightPlans_FormClosing);
			base.FormClosed += new FormClosedEventHandler(this.FlightPlans_FormClosed);
			base.Load += new EventHandler(this.FlightPlans_Load);
			base.VisibleChanged += new EventHandler(this.FlightPlans_VisibleChanged);
			base.KeyDown += new KeyEventHandler(this.FlightPlans_KeyDown);
			this.dataTable_0 = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x00215E60 File Offset: 0x00214060
		[CompilerGenerated]
		internal  DataGridView GetDGV_FlightPlans()
		{
			return this.dataGridView_0;
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x00215E78 File Offset: 0x00214078
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_4);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_5);
			EventHandler value3 = new EventHandler(this.method_6);
			EventHandler value4 = new EventHandler(this.method_9);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value;
				dataGridView.CellValueChanged -= value2;
				dataGridView.CurrentCellDirtyStateChanged -= value3;
				dataGridView.SelectionChanged -= value4;
			}
			this.dataGridView_0 = dataGridView_1;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value;
				dataGridView.CellValueChanged += value2;
				dataGridView.CurrentCellDirtyStateChanged += value3;
				dataGridView.SelectionChanged += value4;
			}
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x00215F20 File Offset: 0x00214120
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x0002618F File Offset: 0x0002438F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_2)
		{
			this.label_0 = label_2;
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x00215F38 File Offset: 0x00214138
		[CompilerGenerated]
		internal  ComboBox GetComboBox_PlannedFlightPlanVisibility()
		{
			return this.ComboBox_PlannedFlightPlanVisibility;
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x00215F50 File Offset: 0x00214150
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetComboBox_PlannedFlightPlanVisibility(ComboBox comboBox_2)
		{
			EventHandler value = new EventHandler(this.ComboBox_PlannedFlightPlanVisibility_SelectionChangeCommitted);
			ComboBox comboBox_PlannedFlightPlanVisibility = this.ComboBox_PlannedFlightPlanVisibility;
			if (comboBox_PlannedFlightPlanVisibility != null)
			{
				comboBox_PlannedFlightPlanVisibility.SelectionChangeCommitted -= value;
			}
			this.ComboBox_PlannedFlightPlanVisibility = comboBox_2;
			comboBox_PlannedFlightPlanVisibility = this.ComboBox_PlannedFlightPlanVisibility;
			if (comboBox_PlannedFlightPlanVisibility != null)
			{
				comboBox_PlannedFlightPlanVisibility.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x00215F9C File Offset: 0x0021419C
		[CompilerGenerated]
		internal  Button GetButton_CreateFlightPlan()
		{
			return this.Button_CreateFlightPlan;
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x00215FB4 File Offset: 0x002141B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_CreateFlightPlan(Button button_4)
		{
			EventHandler value = new EventHandler(this.Button_CreateFlightPlan_Click);
			Button button_CreateFlightPlan = this.Button_CreateFlightPlan;
			if (button_CreateFlightPlan != null)
			{
				button_CreateFlightPlan.Click -= value;
			}
			this.Button_CreateFlightPlan = button_4;
			button_CreateFlightPlan = this.Button_CreateFlightPlan;
			if (button_CreateFlightPlan != null)
			{
				button_CreateFlightPlan.Click += value;
			}
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x00216000 File Offset: 0x00214200
		[CompilerGenerated]
		internal  Button GetButton_FlightPlanEditor()
		{
			return this.Button_FlightPlanEditor;
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x00216018 File Offset: 0x00214218
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_FlightPlanEditor(Button button_4)
		{
			EventHandler value = new EventHandler(this.Button_FlightPlanEditor_Click);
			Button button_FlightPlanEditor = this.Button_FlightPlanEditor;
			if (button_FlightPlanEditor != null)
			{
				button_FlightPlanEditor.Click -= value;
			}
			this.Button_FlightPlanEditor = button_4;
			button_FlightPlanEditor = this.Button_FlightPlanEditor;
			if (button_FlightPlanEditor != null)
			{
				button_FlightPlanEditor.Click += value;
			}
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x00216064 File Offset: 0x00214264
		[CompilerGenerated]
		internal  Button GetButton_EditAssignedAircraft()
		{
			return this.Button_EditAssignedAircraft;
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x0021607C File Offset: 0x0021427C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_EditAssignedAircraft(Button button_4)
		{
			EventHandler value = new EventHandler(this.Button_EditAssignedAircraft_Click);
			Button button_EditAssignedAircraft = this.Button_EditAssignedAircraft;
			if (button_EditAssignedAircraft != null)
			{
				button_EditAssignedAircraft.Click -= value;
			}
			this.Button_EditAssignedAircraft = button_4;
			button_EditAssignedAircraft = this.Button_EditAssignedAircraft;
			if (button_EditAssignedAircraft != null)
			{
				button_EditAssignedAircraft.Click += value;
			}
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x002160C8 File Offset: 0x002142C8
		[CompilerGenerated]
		internal  Button GetButton_DeleteFlightPlan()
		{
			return this.Button_DeleteFlightPlan;
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x002160E0 File Offset: 0x002142E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_DeleteFlightPlan(Button button_4)
		{
			EventHandler value = new EventHandler(this.Button_DeleteFlightPlan_Click);
			Button button_DeleteFlightPlan = this.Button_DeleteFlightPlan;
			if (button_DeleteFlightPlan != null)
			{
				button_DeleteFlightPlan.Click -= value;
			}
			this.Button_DeleteFlightPlan = button_4;
			button_DeleteFlightPlan = this.Button_DeleteFlightPlan;
			if (button_DeleteFlightPlan != null)
			{
				button_DeleteFlightPlan.Click += value;
			}
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x0021612C File Offset: 0x0021432C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetID()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x00026198 File Offset: 0x00024398
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051AC RID: 20908 RVA: 0x00216144 File Offset: 0x00214344
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetCallsign()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060051AD RID: 20909 RVA: 0x000261A1 File Offset: 0x000243A1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x0021615C File Offset: 0x0021435C
		[CompilerGenerated]
		internal  DataGridViewComboBoxColumn GetTask()
		{
			return this.dataGridViewComboBoxColumn_0;
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x000261AA File Offset: 0x000243AA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_0 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x060051B0 RID: 20912 RVA: 0x00216174 File Offset: 0x00214374
		[CompilerGenerated]
		internal  DataGridViewComboBoxColumn GetPriority()
		{
			return this.dataGridViewComboBoxColumn_1;
		}

		// Token: 0x060051B1 RID: 20913 RVA: 0x000261B3 File Offset: 0x000243B3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_1 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x060051B2 RID: 20914 RVA: 0x0021618C File Offset: 0x0021438C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetStatus()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060051B3 RID: 20915 RVA: 0x000261BC File Offset: 0x000243BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x002161A4 File Offset: 0x002143A4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetReferenceUnit()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x060051B5 RID: 20917 RVA: 0x000261C5 File Offset: 0x000243C5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051B6 RID: 20918 RVA: 0x002161BC File Offset: 0x002143BC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetLoadout()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x000261CE File Offset: 0x000243CE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051B8 RID: 20920 RVA: 0x002161D4 File Offset: 0x002143D4
		[CompilerGenerated]
		internal  DataGridViewComboBoxColumn GetDesiredAircraftQty()
		{
			return this.dataGridViewComboBoxColumn_2;
		}

		// Token: 0x060051B9 RID: 20921 RVA: 0x000261D7 File Offset: 0x000243D7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_2 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x060051BA RID: 20922 RVA: 0x002161EC File Offset: 0x002143EC
		[CompilerGenerated]
		internal  DataGridViewComboBoxColumn GetMinimumAircraftQty()
		{
			return this.dataGridViewComboBoxColumn_3;
		}

		// Token: 0x060051BB RID: 20923 RVA: 0x000261E0 File Offset: 0x000243E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4)
		{
			this.dataGridViewComboBoxColumn_3 = dataGridViewComboBoxColumn_4;
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x00216204 File Offset: 0x00214404
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetAssignedAircraftQty()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x060051BD RID: 20925 RVA: 0x000261E9 File Offset: 0x000243E9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051BE RID: 20926 RVA: 0x0021621C File Offset: 0x0021441C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetReadyAircraftQty()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x000261F2 File Offset: 0x000243F2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051C0 RID: 20928 RVA: 0x00216234 File Offset: 0x00214434
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn GetOneTime()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x060051C1 RID: 20929 RVA: 0x000261FB File Offset: 0x000243FB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x060051C2 RID: 20930 RVA: 0x0021624C File Offset: 0x0021444C
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn GetTimeBound()
		{
			return this.dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x060051C3 RID: 20931 RVA: 0x00026204 File Offset: 0x00024404
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_1 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x00216264 File Offset: 0x00214464
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetTakeOffLocation()
		{
			return this.dataGridViewTextBoxColumn_7;
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x0002620D File Offset: 0x0002440D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_7 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x0021627C File Offset: 0x0021447C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetLandingLocation()
		{
			return this.dataGridViewTextBoxColumn_8;
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x00026216 File Offset: 0x00024416
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_8 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x00216294 File Offset: 0x00214494
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetAlternativeLandingLocation()
		{
			return this.dataGridViewTextBoxColumn_9;
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x0002621F File Offset: 0x0002441F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_9 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x002162AC File Offset: 0x002144AC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetEarliestTaskingTime()
		{
			return this.dataGridViewTextBoxColumn_10;
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x00026228 File Offset: 0x00024428
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_10 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x002162C4 File Offset: 0x002144C4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetLatestTaskingTime()
		{
			return this.dataGridViewTextBoxColumn_11;
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x00026231 File Offset: 0x00024431
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_11 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x002162DC File Offset: 0x002144DC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetEarliestLaunchTime()
		{
			return this.dataGridViewTextBoxColumn_12;
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x0002623A File Offset: 0x0002443A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_12 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x002162F4 File Offset: 0x002144F4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetLatestLaunchTime()
		{
			return this.dataGridViewTextBoxColumn_13;
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x00026243 File Offset: 0x00024443
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_13 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x0021630C File Offset: 0x0021450C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetMaxReadyTime()
		{
			return this.dataGridViewTextBoxColumn_14;
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x0002624C File Offset: 0x0002444C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_14 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x00216324 File Offset: 0x00214524
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetTaskPool_Name()
		{
			return this.dataGridViewTextBoxColumn_15;
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x00026255 File Offset: 0x00024455
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_15 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x0021633C File Offset: 0x0021453C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetTaskPool_PreferredLoadoutName()
		{
			return this.dataGridViewTextBoxColumn_16;
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x0002625E File Offset: 0x0002445E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_16 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x00216354 File Offset: 0x00214554
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetPostTaskPool_Name()
		{
			return this.dataGridViewTextBoxColumn_17;
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x00026267 File Offset: 0x00024467
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_17 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051DA RID: 20954 RVA: 0x0021636C File Offset: 0x0021456C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetPostTaskPool_PreferredLoadoutName()
		{
			return this.dataGridViewTextBoxColumn_18;
		}

		// Token: 0x060051DB RID: 20955 RVA: 0x00026270 File Offset: 0x00024470
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_18 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051DC RID: 20956 RVA: 0x00216384 File Offset: 0x00214584
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetCreatedBy()
		{
			return this.dataGridViewTextBoxColumn_19;
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x00026279 File Offset: 0x00024479
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_19 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x0021639C File Offset: 0x0021459C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetEditedBy()
		{
			return this.dataGridViewTextBoxColumn_20;
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x00026282 File Offset: 0x00024482
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21)
		{
			this.dataGridViewTextBoxColumn_20 = dataGridViewTextBoxColumn_21;
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x002163B4 File Offset: 0x002145B4
		[CompilerGenerated]
		internal  Label vmethod_68()
		{
			return this.label_1;
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x0002628B File Offset: 0x0002448B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(Label label_2)
		{
			this.label_1 = label_2;
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x002163CC File Offset: 0x002145CC
		[CompilerGenerated]
		internal  ComboBox GetComboBox_AirborneFlightPlanVisibility()
		{
			return this.ComboBox_AirborneFlightPlanVisibility;
		}

		// Token: 0x060051E3 RID: 20963 RVA: 0x002163E4 File Offset: 0x002145E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetComboBox_AirborneFlightPlanVisibility(ComboBox comboBox_2)
		{
			EventHandler value = new EventHandler(this.ComboBox_AirborneFlightPlanVisibility_Click);
			ComboBox comboBox_AirborneFlightPlanVisibility = this.ComboBox_AirborneFlightPlanVisibility;
			if (comboBox_AirborneFlightPlanVisibility != null)
			{
				comboBox_AirborneFlightPlanVisibility.SelectionChangeCommitted -= value;
			}
			this.ComboBox_AirborneFlightPlanVisibility = comboBox_2;
			comboBox_AirborneFlightPlanVisibility = this.ComboBox_AirborneFlightPlanVisibility;
			if (comboBox_AirborneFlightPlanVisibility != null)
			{
				comboBox_AirborneFlightPlanVisibility.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060051E4 RID: 20964 RVA: 0x00216430 File Offset: 0x00214630
		private void method_1(Subject class137_0)
		{
			try
			{
				if (!Information.IsNothing(class137_0))
				{
					this.method_2();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200631", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060051E5 RID: 20965 RVA: 0x00025EE1 File Offset: 0x000240E1
		private void FlightPlans_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x060051E6 RID: 20966 RVA: 0x00026294 File Offset: 0x00024494
		private void FlightPlans_FormClosed(object sender, FormClosedEventArgs e)
		{
			MissionEditor.smethod_1(new MissionEditor.Delegate64(this.method_1));
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x000262A7 File Offset: 0x000244A7
		private void FlightPlans_Load(object sender, EventArgs e)
		{
			MissionEditor.smethod_0(new MissionEditor.Delegate64(this.method_1));
		}

		// Token: 0x060051E8 RID: 20968 RVA: 0x000262BA File Offset: 0x000244BA
		private void FlightPlans_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				this.method_2();
			}
			Client.b_Completed = true;
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

		// Token: 0x060051E9 RID: 20969 RVA: 0x000262E2 File Offset: 0x000244E2
		public void method_2()
		{
			this.UpdateFlightList();
			this.GetComboBox_AirborneFlightPlanVisibility().SelectedIndex = (int)SimConfiguration.gameOptions.GetShowFlightPlans_Airborne();
			this.GetComboBox_PlannedFlightPlanVisibility().SelectedIndex = (int)SimConfiguration.gameOptions.GetShowFlightPlans_Planned();
		}

		// Token: 0x060051EA RID: 20970 RVA: 0x0021649C File Offset: 0x0021469C
		private void UpdateFlightList()
		{
			try
			{
				if (!Information.IsNothing(this.mission_0))
				{
					this.dataTable_0.Clear();
					if (!this.dataTable_0.Columns.Contains("ID"))
					{
						this.dataTable_0.Columns.Add("ID", typeof(string));
					}
					if (!this.dataTable_0.Columns.Contains("Callsign"))
					{
						this.dataTable_0.Columns.Add("Callsign", typeof(string));
					}
					if (!this.dataTable_0.Columns.Contains("Task"))
					{
						this.dataTable_0.Columns.Add("Task", typeof(int));
					}
					if (!this.dataTable_0.Columns.Contains("TakeOffLocation"))
					{
						this.dataTable_0.Columns.Add("TakeOffLocation", typeof(string));
					}
					if (!this.dataTable_0.Columns.Contains("LandingLocation"))
					{
						this.dataTable_0.Columns.Add("LandingLocation", typeof(string));
					}
					if (!this.dataTable_0.Columns.Contains("AlternativeLandingLocation"))
					{
						this.dataTable_0.Columns.Add("AlternativeLandingLocation", typeof(string));
					}
					if (!this.dataTable_0.Columns.Contains("OneTime"))
					{
						this.dataTable_0.Columns.Add("OneTime", typeof(bool));
					}
					if (!this.dataTable_0.Columns.Contains("TimeBound"))
					{
						this.dataTable_0.Columns.Add("TimeBound", typeof(bool));
					}
					if (!this.dataTable_0.Columns.Contains("EarliestTaskingTime"))
					{
						this.dataTable_0.Columns.Add("EarliestTaskingTime", typeof(DateTime));
					}
					if (!this.dataTable_0.Columns.Contains("LatestTaskingTime"))
					{
						this.dataTable_0.Columns.Add("LatestTaskingTime", typeof(DateTime));
					}
					if (!this.dataTable_0.Columns.Contains("EarliestLaunchTime"))
					{
						this.dataTable_0.Columns.Add("EarliestLaunchTime", typeof(DateTime));
					}
					if (!this.dataTable_0.Columns.Contains("LatestLaunchTime"))
					{
						this.dataTable_0.Columns.Add("LatestLaunchTime", typeof(DateTime));
					}
					if (!this.dataTable_0.Columns.Contains("MaxReadyTime"))
					{
						this.dataTable_0.Columns.Add("MaxReadyTime", typeof(short));
					}
					if (!this.dataTable_0.Columns.Contains("Priority"))
					{
						this.dataTable_0.Columns.Add("Priority", typeof(int));
					}
					if (!this.dataTable_0.Columns.Contains("Status"))
					{
						this.dataTable_0.Columns.Add("Status", typeof(int));
					}
					if (!this.dataTable_0.Columns.Contains("CreatedBy"))
					{
						this.dataTable_0.Columns.Add("CreatedBy", typeof(string));
					}
					if (!this.dataTable_0.Columns.Contains("EditedBy"))
					{
						this.dataTable_0.Columns.Add("EditedBy", typeof(string));
					}
					if (!this.dataTable_0.Columns.Contains("DesiredAircraftQty"))
					{
						this.dataTable_0.Columns.Add("DesiredAircraftQty", typeof(int));
					}
					if (!this.dataTable_0.Columns.Contains("MinimumAircraftQty"))
					{
						this.dataTable_0.Columns.Add("MinimumAircraftQty", typeof(int));
					}
					if (!this.dataTable_0.Columns.Contains("AssignedAircraftQty"))
					{
						this.dataTable_0.Columns.Add("AssignedAircraftQty", typeof(int));
					}
					if (!this.dataTable_0.Columns.Contains("ReadyAircraftQty"))
					{
						this.dataTable_0.Columns.Add("ReadyAircraftQty", typeof(int));
					}
					if (!this.dataTable_0.Columns.Contains("ReferenceUnit_Name"))
					{
						this.dataTable_0.Columns.Add("ReferenceUnit_Name", typeof(string));
					}
					if (!this.dataTable_0.Columns.Contains("LoadoutName"))
					{
						this.dataTable_0.Columns.Add("LoadoutName", typeof(string));
					}
					if (!this.dataTable_0.Columns.Contains("TaskPool_Name"))
					{
						this.dataTable_0.Columns.Add("TaskPool_Name", typeof(string));
					}
					if (!this.dataTable_0.Columns.Contains("TaskPool_PreferredLoadoutName"))
					{
						this.dataTable_0.Columns.Add("TaskPool_PreferredLoadoutName", typeof(string));
					}
					if (!this.dataTable_0.Columns.Contains("PostTaskPool_Name"))
					{
						this.dataTable_0.Columns.Add("PostTaskPool_Name", typeof(string));
					}
					if (!this.dataTable_0.Columns.Contains("PostTaskPool_PreferredLoadoutName"))
					{
						this.dataTable_0.Columns.Add("PostTaskPool_PreferredLoadoutName", typeof(string));
					}
					if (this.mission_0.HasFlights())
					{
						foreach (Mission.Flight current in this.mission_0.FlightList)
						{
							DataRow dataRow = this.dataTable_0.NewRow();
							dataRow["ID"] = current.GetGuid();
							dataRow["Callsign"] = current.Callsign;
							dataRow["Task"] = Mission.Flight.GetTaskIndex(current.Task);
							dataRow["TakeOffLocation"] = current.TakeOffLocation_HostUnitObjectName;
							dataRow["LandingLocation"] = current.LandingLocation_HostUnitObjectName;
							dataRow["AlternativeLandingLocation"] = current.AlternativeLandingLocation_HostUnitObjectName;
							dataRow["OneTime"] = current.OneTime;
							dataRow["TimeBound"] = current.TimeBound;
							if (!Information.IsNothing(current.EarliestLaunchTime))
							{
								dataRow["EarliestTaskingTime"] = current.EarliestLaunchTime;
							}
							if (!Information.IsNothing(current.EarliestLaunchTime))
							{
								dataRow["LatestTaskingTime"] = current.LatestTaskingTime;
							}
							if (!Information.IsNothing(current.EarliestLaunchTime))
							{
								dataRow["EarliestLaunchTime"] = current.EarliestLaunchTime;
							}
							if (!Information.IsNothing(current.EarliestLaunchTime))
							{
								dataRow["LatestLaunchTime"] = current.LatestLaunchTime;
							}
							dataRow["MaxReadyTime"] = current.MaxReadyTime;
							dataRow["Priority"] = Mission.Flight.GetPriortiyCons(current.Priority);
							dataRow["Status"] = current.Status;
							dataRow["CreatedBy"] = current.CreatedBy;
							dataRow["EditedBy"] = current.EditedBy;
							dataRow["DesiredAircraftQty"] = Mission.Flight.AircraftQtyToIndex(current.DesiredAircraftQty);
							dataRow["MinimumAircraftQty"] = Mission.Flight.AircraftQtyToIndex(current.MinimumAircraftQty);
							dataRow["AssignedAircraftQty"] = current.AssignedAircraftQty;
							dataRow["ReadyAircraftQty"] = current.ReadyAircraftQty;
							dataRow["ReferenceUnit_Name"] = current.ReferenceUnit_Name;
							dataRow["LoadoutName"] = current.LoadoutName;
							dataRow["TaskPool_Name"] = current.TaskPool_Name;
							dataRow["TaskPool_PreferredLoadoutName"] = current.TaskPool_PreferredLoadoutName;
							dataRow["PostTaskPool_Name"] = current.PostTaskPool_Name;
							dataRow["PostTaskPool_PreferredLoadoutName"] = current.PostTaskPool_PreferredLoadoutName;
							this.dataTable_0.Rows.Add(dataRow);
						}
						DataTable dataSource = new DataTable();
						DataTable dataSource2 = new DataTable();
						DataTable dataSource3 = new DataTable();
						DataTable dataSource4 = new DataTable();
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = (DataGridViewComboBoxColumn)this.GetDGV_FlightPlans().Columns[this.GetDGV_FlightPlans().Columns["Task"].Index];
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn2 = (DataGridViewComboBoxColumn)this.GetDGV_FlightPlans().Columns[this.GetDGV_FlightPlans().Columns["Priority"].Index];
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn3 = (DataGridViewComboBoxColumn)this.GetDGV_FlightPlans().Columns[this.GetDGV_FlightPlans().Columns["DesiredAircraftQty"].Index];
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn4 = (DataGridViewComboBoxColumn)this.GetDGV_FlightPlans().Columns[this.GetDGV_FlightPlans().Columns["MinimumAircraftQty"].Index];
						Mission.Flight.LoadTaskDataTable(ref dataSource);
						Mission.Flight.SetDataTablePriorityData(ref dataSource2);
						Mission.Flight.SetDataTableFlightSize(ref dataSource3);
						Mission.Flight.SetDataTableFlightSize(ref dataSource4);
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn5 = dataGridViewComboBoxColumn;
						dataGridViewComboBoxColumn5.DataSource = dataSource;
						dataGridViewComboBoxColumn5.DisplayMember = "Description";
						dataGridViewComboBoxColumn5.ValueMember = "ID";
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn6 = dataGridViewComboBoxColumn2;
						dataGridViewComboBoxColumn6.DataSource = dataSource2;
						dataGridViewComboBoxColumn6.DisplayMember = "Description";
						dataGridViewComboBoxColumn6.ValueMember = "ID";
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn7 = dataGridViewComboBoxColumn3;
						dataGridViewComboBoxColumn7.DataSource = dataSource3;
						dataGridViewComboBoxColumn7.DisplayMember = "Description";
						dataGridViewComboBoxColumn7.ValueMember = "ID";
						dataGridViewComboBoxColumn4.DataSource = dataSource4;
						dataGridViewComboBoxColumn4.DisplayMember = "Description";
						dataGridViewComboBoxColumn4.ValueMember = "ID";
						this.GetDGV_FlightPlans().DataSource = new DataView(this.dataTable_0);
						IEnumerator enumerator2 = ((IEnumerable)this.GetDGV_FlightPlans().Rows).GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator2.Current;
								foreach (Mission.Flight current2 in this.mission_0.FlightList)
								{
									if (Operators.CompareString(current2.GetGuid(), Conversions.ToString(dataGridViewRow.Cells["ID"].Value), false) == 0)
									{
										dataGridViewRow.Tag = current2;
										break;
									}
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
						if (Information.IsNothing(this.string_0))
						{
							this.string_0 = Conversions.ToString(this.GetDGV_FlightPlans().Rows[0].Cells["ID"].Value);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200583", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x002170CC File Offset: 0x002152CC
		private void method_4(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				IEnumerator enumerator = ((IEnumerable)this.GetDGV_FlightPlans().Rows).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
						if (dataGridViewRow.Selected)
						{
							DataTable dataSource = new DataTable();
							DataTable dataSource2 = new DataTable();
							DataTable dataSource3 = new DataTable();
							DataTable dataSource4 = new DataTable();
							DataGridViewColumn dataGridViewColumn = this.GetDGV_FlightPlans().Columns[e.ColumnIndex];
							if (Operators.CompareString(dataGridViewColumn.Name, "Task", false) != 0)
							{
								if (Operators.CompareString(dataGridViewColumn.Name, "Priority", false) != 0)
								{
									if (Operators.CompareString(dataGridViewColumn.Name, "DesiredAircraftQty", false) != 0)
									{
										if (Operators.CompareString(dataGridViewColumn.Name, "MinimumAircraftQty", false) != 0)
										{
											continue;
										}
										DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.GetDGV_FlightPlans()[dataGridViewColumn.Index, dataGridViewRow.Index];
										Mission.Flight.SetDataTableFlightSize(ref dataSource4);
										dataGridViewComboBoxCell.DataSource = dataSource4;
										dataGridViewComboBoxCell.DropDownWidth = 500;
										dataGridViewComboBoxCell.DisplayMember = "Description";
										dataGridViewComboBoxCell.ValueMember = "ID";
										this.GetDGV_FlightPlans().BeginEdit(true);
										((DataGridViewComboBoxEditingControl)this.GetDGV_FlightPlans().EditingControl).DroppedDown = true;
									}
									else
									{
										DataGridViewComboBoxCell dataGridViewComboBoxCell2 = (DataGridViewComboBoxCell)this.GetDGV_FlightPlans()[dataGridViewColumn.Index, dataGridViewRow.Index];
										Mission.Flight.SetDataTableFlightSize(ref dataSource3);
										dataGridViewComboBoxCell2.DataSource = dataSource3;
										dataGridViewComboBoxCell2.DropDownWidth = 500;
										dataGridViewComboBoxCell2.DisplayMember = "Description";
										dataGridViewComboBoxCell2.ValueMember = "ID";
										this.GetDGV_FlightPlans().BeginEdit(true);
										((DataGridViewComboBoxEditingControl)this.GetDGV_FlightPlans().EditingControl).DroppedDown = true;
									}
								}
								else
								{
									DataGridViewComboBoxCell dataGridViewComboBoxCell3 = (DataGridViewComboBoxCell)this.GetDGV_FlightPlans()[dataGridViewColumn.Index, dataGridViewRow.Index];
									Mission.Flight.SetDataTablePriorityData(ref dataSource2);
									dataGridViewComboBoxCell3.DataSource = dataSource2;
									dataGridViewComboBoxCell3.DisplayMember = "Description";
									dataGridViewComboBoxCell3.ValueMember = "ID";
									dataGridViewComboBoxCell3.DropDownWidth = 500;
									this.GetDGV_FlightPlans().BeginEdit(true);
									((DataGridViewComboBoxEditingControl)this.GetDGV_FlightPlans().EditingControl).DroppedDown = true;
								}
							}
							else
							{
								DataGridViewComboBoxCell dataGridViewComboBoxCell4 = (DataGridViewComboBoxCell)this.GetDGV_FlightPlans()[dataGridViewColumn.Index, dataGridViewRow.Index];
								Mission.Flight.LoadTaskDataTable(ref dataSource);
								dataGridViewComboBoxCell4.DataSource = dataSource;
								dataGridViewComboBoxCell4.DisplayMember = "Description";
								dataGridViewComboBoxCell4.ValueMember = "ID";
								dataGridViewComboBoxCell4.DropDownWidth = 500;
								this.GetDGV_FlightPlans().BeginEdit(true);
								if (this.GetDGV_FlightPlans().Rows[e.RowIndex].Cells[this.GetTask().Name].Selected)
								{
									((DataGridViewComboBoxEditingControl)this.GetDGV_FlightPlans().EditingControl).DroppedDown = true;
								}
							}
							break;
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
				Client.b_Completed = true;
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200583", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x00026314 File Offset: 0x00024514
		private void method_5(object sender, DataGridViewCellEventArgs e)
		{
			if (this.bool_0 && this.GetDGV_FlightPlans().SelectedRows.Count != 0)
			{
				this.method_7(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x00026343 File Offset: 0x00024543
		private void method_6(object sender, EventArgs e)
		{
			this.bool_0 = true;
			if (this.GetDGV_FlightPlans().IsCurrentCellDirty)
			{
				this.GetDGV_FlightPlans().CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x00217478 File Offset: 0x00215678
		private void method_7(object sender, DataGridViewCellEventArgs e)
		{
			Mission.Flight flight = (Mission.Flight)this.GetDGV_FlightPlans().Rows[e.RowIndex].Tag;
			if (!Information.IsNothing(flight))
			{
				if (e.RowIndex != -1 && e.ColumnIndex == this.GetDGV_FlightPlans().Columns["Task"].Index)
				{
					flight.Task = Mission.Flight.GetTask(RuntimeHelpers.GetObjectValue(this.GetDGV_FlightPlans()[e.ColumnIndex, e.RowIndex].Value));
				}
				if (e.RowIndex != -1 && e.ColumnIndex == this.GetDGV_FlightPlans().Columns["Priority"].Index)
				{
					flight.Priority = Mission.Flight.GetPriority(RuntimeHelpers.GetObjectValue(this.GetDGV_FlightPlans()[e.ColumnIndex, e.RowIndex].Value));
				}
				if (e.RowIndex != -1 && e.ColumnIndex == this.GetDGV_FlightPlans().Columns["DesiredAircraftQty"].Index)
				{
					flight.DesiredAircraftQty = Mission.Flight.GetAircraftQty(RuntimeHelpers.GetObjectValue(this.GetDGV_FlightPlans()[e.ColumnIndex, e.RowIndex].Value));
				}
				if (e.RowIndex != -1 && e.ColumnIndex == this.GetDGV_FlightPlans().Columns["MinimumAircraftQty"].Index)
				{
					flight.MinimumAircraftQty = Mission.Flight.GetAircraftQty(RuntimeHelpers.GetObjectValue(this.GetDGV_FlightPlans()[e.ColumnIndex, e.RowIndex].Value));
				}
				this.bool_0 = false;
			}
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x00217634 File Offset: 0x00215834
		private void Button_FlightPlanEditor_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.mission_0) && !Information.IsNothing(this.string_0))
			{
				Client.flightPlanEditor.m_mission = this.mission_0;
				Client.flightPlanEditor.m_Flight = this.mission_0.FlightList.Where(new Func<Mission.Flight, bool>(this.method_15)).ElementAtOrDefault(0);
				Client.flightPlanEditor.Show();
			}
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x002176A4 File Offset: 0x002158A4
		private void method_9(object sender, EventArgs e)
		{
			if (this.GetDGV_FlightPlans().SelectedRows.Count != 0)
			{
				this.string_0 = Conversions.ToString(this.GetDGV_FlightPlans().SelectedRows[0].Cells["ID"].Value);
			}
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x002176F8 File Offset: 0x002158F8
		private void Button_CreateFlightPlan_Click(object sender, EventArgs e)
		{
			Scenario clientScenario = Client.GetClientScenario();
			Mission.Flight flight = null;
			Mission.Flight item = new Mission.Flight(ref clientScenario, ref this.mission_0, ref flight, "New Flight", "", "", 0, null, null);
			this.mission_0.FlightList.Add(item);
			this.UpdateFlightList();
			if (Client.GetMissionEditor().Visible)
			{
				Client.GetMissionEditor().method_10();
				Client.GetMissionEditor().method_12();
			}
		}

		// Token: 0x060051F2 RID: 20978 RVA: 0x0021776C File Offset: 0x0021596C
		private void Button_DeleteFlightPlan_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.string_0))
			{
				Mission.Flight expression = this.mission_0.FlightList.Where(new Func<Mission.Flight, bool>(this.method_16)).ElementAtOrDefault(0);
				if (Information.IsNothing(expression))
				{
					this.UpdateFlightList();
				}
				else
				{
					Mission mission = this.mission_0;
					Scenario clientScenario = Client.GetClientScenario();
					Side clientSide = Client.GetClientSide();
					mission.method_40(ref clientScenario, ref clientSide, ref expression, this.string_0);
					Client.SetClientSide(clientSide);
					this.UpdateFlightList();
					if (Client.flightPlanEditor.Visible)
					{
						Client.flightPlanEditor.m_Flight = null;
						Client.flightPlanEditor.method_6();
					}
					if (Client.GetMissionEditor().Visible)
					{
						Client.GetMissionEditor().method_10();
						Client.GetMissionEditor().method_12();
					}
					CommandFactory.GetCommandMain().GetMainForm().method_157();
					Client.b_Completed = true;
					CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
				}
			}
		}

		// Token: 0x060051F3 RID: 20979 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void Button_EditAssignedAircraft_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x0002636D File Offset: 0x0002456D
		private void ComboBox_PlannedFlightPlanVisibility_SelectionChangeCommitted(object sender, EventArgs e)
		{
			SimConfiguration.gameOptions.SetShowFlightPlans_Planned((Configuration.GameOptions._ShowFlightPlans_Planned)this.GetComboBox_PlannedFlightPlanVisibility().SelectedIndex);
			Client.b_Completed = true;
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void FlightPlans_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060051F6 RID: 20982 RVA: 0x0002639A File Offset: 0x0002459A
		private void ComboBox_AirborneFlightPlanVisibility_Click(object sender, EventArgs e)
		{
			SimConfiguration.gameOptions.SetShowFlightPlans_Airborne((Configuration.GameOptions._ShowFlightPlans_Airborne)this.GetComboBox_AirborneFlightPlanVisibility().SelectedIndex);
			Client.b_Completed = true;
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x000263C7 File Offset: 0x000245C7
		[CompilerGenerated]
		private bool method_15(Mission.Flight class168_0)
		{
			return Operators.CompareString(class168_0.GetGuid(), this.string_0, false) == 0;
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x000263C7 File Offset: 0x000245C7
		[CompilerGenerated]
		private bool method_16(Mission.Flight class168_0)
		{
			return Operators.CompareString(class168_0.GetGuid(), this.string_0, false) == 0;
		}

		// Token: 0x0400265A RID: 9818
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x0400265B RID: 9819
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x0400265C RID: 9820
		[CompilerGenerated]
		private ComboBox ComboBox_PlannedFlightPlanVisibility;

		// Token: 0x0400265D RID: 9821
		[CompilerGenerated]
		private Button Button_CreateFlightPlan;

		// Token: 0x0400265E RID: 9822
		[CompilerGenerated]
		private Button Button_FlightPlanEditor;

		// Token: 0x0400265F RID: 9823
		[CompilerGenerated]
		private Button Button_EditAssignedAircraft;

		// Token: 0x04002660 RID: 9824
		[CompilerGenerated]
		private Button Button_DeleteFlightPlan;

		// Token: 0x04002661 RID: 9825
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04002662 RID: 9826
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04002663 RID: 9827
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

		// Token: 0x04002664 RID: 9828
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;

		// Token: 0x04002665 RID: 9829
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04002666 RID: 9830
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04002667 RID: 9831
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04002668 RID: 9832
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;

		// Token: 0x04002669 RID: 9833
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_3;

		// Token: 0x0400266A RID: 9834
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x0400266B RID: 9835
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x0400266C RID: 9836
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x0400266D RID: 9837
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		// Token: 0x0400266E RID: 9838
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		// Token: 0x0400266F RID: 9839
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		// Token: 0x04002670 RID: 9840
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		// Token: 0x04002671 RID: 9841
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		// Token: 0x04002672 RID: 9842
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		// Token: 0x04002673 RID: 9843
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		// Token: 0x04002674 RID: 9844
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		// Token: 0x04002675 RID: 9845
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		// Token: 0x04002676 RID: 9846
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		// Token: 0x04002677 RID: 9847
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		// Token: 0x04002678 RID: 9848
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		// Token: 0x04002679 RID: 9849
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		// Token: 0x0400267A RID: 9850
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		// Token: 0x0400267B RID: 9851
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		// Token: 0x0400267C RID: 9852
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x0400267D RID: 9853
		[CompilerGenerated]
		private ComboBox ComboBox_AirborneFlightPlanVisibility;

		// Token: 0x0400267E RID: 9854
		public Mission mission_0;

		// Token: 0x0400267F RID: 9855
		public string string_0;

		// Token: 0x04002680 RID: 9856
		private DataTable dataTable_0;

		// Token: 0x04002681 RID: 9857
		private bool bool_0;
	}
}

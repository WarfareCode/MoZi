using System;
using System.Collections;
using System.Collections.ObjectModel;
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
using ns4;

namespace ns32
{
	// 飞行计划路径点
	[DesignerGenerated]
	public sealed class FlightPlanWaypoints : UserControl
	{
		// Token: 0x060028D3 RID: 10451 RVA: 0x000167DD File Offset: 0x000149DD
		public FlightPlanWaypoints()
		{
			this.InitializeComponent();
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x000F7714 File Offset: 0x000F5914
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x000F7758 File Offset: 0x000F5958
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
			this.vmethod_1(new DataGridView());
			this.vmethod_43(new DataGridViewTextBoxColumn());
			this.vmethod_45(new DataGridViewTextBoxColumn());
			this.vmethod_47(new DataGridViewComboBoxColumn());
			this.vmethod_49(new DataGridViewTextBoxColumn());
			this.vmethod_51(new DataGridViewTextBoxColumn());
			this.vmethod_53(new DataGridViewImageColumn());
			this.vmethod_55(new DataGridViewTextBoxColumn());
			this.vmethod_57(new DataGridViewTextBoxColumn());
			this.vmethod_59(new DataGridViewImageColumn());
			this.vmethod_61(new DataGridViewTextBoxColumn());
			this.vmethod_63(new DataGridViewTextBoxColumn());
			this.vmethod_65(new DataGridViewTextBoxColumn());
			this.vmethod_67(new DataGridViewTextBoxColumn());
			this.vmethod_69(new DataGridViewTextBoxColumn());
			this.vmethod_71(new DataGridViewTextBoxColumn());
			this.vmethod_73(new DataGridViewTextBoxColumn());
			this.vmethod_75(new DataGridViewTextBoxColumn());
			this.vmethod_77(new DataGridViewTextBoxColumn());
			this.vmethod_79(new DataGridViewComboBoxColumn());
			this.vmethod_81(new DataGridViewComboBoxColumn());
			this.vmethod_83(new DataGridViewComboBoxColumn());
			this.vmethod_85(new DataGridViewTextBoxColumn());
			this.vmethod_87(new DataGridViewTextBoxColumn());
			this.vmethod_89(new DataGridViewTextBoxColumn());
			this.vmethod_91(new DataGridViewTextBoxColumn());
			this.vmethod_93(new DataGridViewComboBoxColumn());
			this.vmethod_3(new Button());
			this.SetButton_DeleteWaypoint(new Button());
			this.vmethod_7(new Label());
			this.SetButton_ChangeAssignedAircraft(new Button());
			this.SetButton_EditTime(new Button());
			this.SetButton_EditSpeedAltitude(new Button());
			this.SetButton_EditDoctrine(new Button());
			this.vmethod_95(new Button());
			this.SetButton_EditAAR(new Button());
			this.vmethod_19(new DataGridViewTextBoxColumn());
			this.vmethod_21(new DataGridViewTextBoxColumn());
			this.vmethod_23(new DataGridViewTextBoxColumn());
			this.vmethod_25(new DataGridViewTextBoxColumn());
			this.vmethod_27(new DataGridViewTextBoxColumn());
			this.vmethod_29(new DataGridViewTextBoxColumn());
			this.vmethod_31(new DataGridViewTextBoxColumn());
			this.vmethod_33(new DataGridViewTextBoxColumn());
			this.vmethod_35(new DataGridViewTextBoxColumn());
			this.vmethod_37(new DataGridViewTextBoxColumn());
			this.vmethod_39(new DataGridViewTextBoxColumn());
			this.vmethod_41(new Button());
			((ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AllowUserToResizeColumns = false;
			this.vmethod_0().AllowUserToResizeRows = false;
			this.vmethod_0().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().ColumnHeadersHeight = 18;
			this.vmethod_0().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_42(),
				this.vmethod_44(),
				this.vmethod_46(),
				this.vmethod_48(),
				this.vmethod_50(),
				this.vmethod_52(),
				this.vmethod_54(),
				this.vmethod_56(),
				this.vmethod_58(),
				this.vmethod_60(),
				this.vmethod_62(),
				this.vmethod_64(),
				this.vmethod_66(),
				this.vmethod_68(),
				this.vmethod_70(),
				this.vmethod_72(),
				this.vmethod_74(),
				this.vmethod_76(),
				this.vmethod_78(),
				this.vmethod_80(),
				this.vmethod_82(),
				this.vmethod_84(),
				this.vmethod_86(),
				this.vmethod_88(),
				this.vmethod_90(),
				this.GetTurnRate()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_0().Location = new Point(0, 23);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DGV_Waypoints";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.vmethod_0().RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().RowHeadersWidth = 10;
			this.vmethod_0().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new Size(492, 227);
			this.vmethod_0().TabIndex = 10;
			this.vmethod_42().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.vmethod_42().DataPropertyName = "ID";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_42().DefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_42().Frozen = true;
			this.vmethod_42().HeaderText = "#";
			this.vmethod_42().Name = "ID";
			this.vmethod_42().ReadOnly = true;
			this.vmethod_42().Width = 5;
			this.vmethod_44().DataPropertyName = "ObjectID";
			this.vmethod_44().HeaderText = "ObjectID";
			this.vmethod_44().Name = "ObjectID";
			this.vmethod_44().Visible = false;
			this.vmethod_46().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_46().DataPropertyName = "Type";
			this.vmethod_46().FlatStyle = FlatStyle.Flat;
			this.vmethod_46().Frozen = true;
			this.vmethod_46().HeaderText = "类型";
			this.vmethod_46().MaxDropDownItems = 20;
			this.vmethod_46().Name = "Type";
			this.vmethod_46().Resizable = DataGridViewTriState.True;
			this.vmethod_46().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_46().Width = 54;
			this.vmethod_48().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_48().DataPropertyName = "Time_Zulu";
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.BottomCenter;
			this.vmethod_48().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_48().HeaderText = "Zulu时间";
			this.vmethod_48().Name = "Time_Zulu";
			this.vmethod_48().ReadOnly = true;
			this.vmethod_48().Width = 77;
			this.vmethod_50().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_50().DataPropertyName = "Time_Local";
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.BottomCenter;
			this.vmethod_50().DefaultCellStyle = dataGridViewCellStyle6;
			this.vmethod_50().HeaderText = "本地时间";
			this.vmethod_50().Name = "Time_Local";
			this.vmethod_50().ReadOnly = true;
			this.vmethod_50().Width = 82;
			this.vmethod_52().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.vmethod_52().DataPropertyName = "TimeFixedImg";
			this.vmethod_52().HeaderText = " ";
			this.vmethod_52().Name = "TimeFixedImg";
			this.vmethod_52().Width = 5;
			this.vmethod_54().DataPropertyName = "TimeFixed";
			this.vmethod_54().HeaderText = "固定时间";
			this.vmethod_54().Name = "TimeFixed";
			this.vmethod_54().Resizable = DataGridViewTriState.True;
			this.vmethod_54().Visible = false;
			this.vmethod_54().Width = 5;
			this.vmethod_56().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_56().DataPropertyName = "DesiredSpeed";
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_56().DefaultCellStyle = dataGridViewCellStyle7;
			this.vmethod_56().HeaderText = " 航速";
			this.vmethod_56().Name = "DesiredSpeed";
			this.vmethod_56().ReadOnly = true;
			this.vmethod_56().Width = 64;
			this.vmethod_58().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.vmethod_58().DataPropertyName = "SpeedFixedImg";
			this.vmethod_58().HeaderText = " ";
			this.vmethod_58().Name = "SpeedFixedImg";
			this.vmethod_58().Width = 5;
			this.vmethod_60().DataPropertyName = "SpeedFixed";
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_60().DefaultCellStyle = dataGridViewCellStyle8;
			this.vmethod_60().HeaderText = "固定航速";
			this.vmethod_60().Name = "SpeedFixed";
			this.vmethod_60().Resizable = DataGridViewTriState.True;
			this.vmethod_60().Visible = false;
			this.vmethod_60().Width = 5;
			this.vmethod_62().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_62().DataPropertyName = "DesiredAltitude";
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_62().DefaultCellStyle = dataGridViewCellStyle9;
			this.vmethod_62().HeaderText = "高度";
			this.vmethod_62().Name = "DesiredAltitude";
			this.vmethod_62().ReadOnly = true;
			this.vmethod_62().Width = 65;
			this.vmethod_64().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_64().DataPropertyName = "Leg_FuelRequired";
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_64().DefaultCellStyle = dataGridViewCellStyle10;
			this.vmethod_64().HeaderText = "航线段油量";
			this.vmethod_64().Name = "Leg_FuelRequired";
			this.vmethod_64().ToolTipText = "飞完本航线段所需油量.";
			this.vmethod_64().Width = 71;
			this.vmethod_66().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_66().DataPropertyName = "Leg_FuelRemaining";
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_66().DefaultCellStyle = dataGridViewCellStyle11;
			this.vmethod_66().HeaderText = "剩余油量";
			this.vmethod_66().Name = "Leg_FuelRemaining";
			this.vmethod_66().ToolTipText = "飞完本航线段的剩余任务油量(即总油量减去储备油量)";
			this.vmethod_66().Width = 103;
			this.vmethod_68().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_68().DataPropertyName = "Leg_Time";
			dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_68().DefaultCellStyle = dataGridViewCellStyle12;
			this.vmethod_68().HeaderText = "航线段时间";
			this.vmethod_68().Name = "Leg_Time";
			this.vmethod_68().ToolTipText = "飞完本航线段所需时间.";
			this.vmethod_68().Width = 74;
			this.vmethod_70().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_70().DataPropertyName = "Hold_Time";
			dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_70().DefaultCellStyle = dataGridViewCellStyle13;
			this.vmethod_70().HeaderText = "集结时间";
			this.vmethod_70().Name = "Hold_Time";
			this.vmethod_70().ToolTipText = "航路点上等待飞行编队集结所需的徘徊时间";
			this.vmethod_70().Width = 78;
			this.vmethod_72().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_72().DataPropertyName = "Leg_TotalTime";
			dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_72().DefaultCellStyle = dataGridViewCellStyle14;
			this.vmethod_72().HeaderText = "总时间";
			this.vmethod_72().Name = "Leg_TotalTime";
			this.vmethod_72().Width = 80;
			this.vmethod_74().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_74().DataPropertyName = "Leg_Distance";
			dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_74().DefaultCellStyle = dataGridViewCellStyle15;
			this.vmethod_74().HeaderText = "航线段距离";
			this.vmethod_74().Name = "Leg_Distance";
			this.vmethod_74().Width = 93;
			this.vmethod_76().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_76().DataPropertyName = "Leg_TotalDistance";
			dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleRight;
			this.vmethod_76().DefaultCellStyle = dataGridViewCellStyle16;
			this.vmethod_76().HeaderText = "总距离";
			this.vmethod_76().Name = "Leg_TotalDistance";
			this.vmethod_76().Width = 99;
			this.vmethod_78().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_78().DataPropertyName = "AARUsage";
			this.vmethod_78().FlatStyle = FlatStyle.Flat;
			this.vmethod_78().HeaderText = "加油机使用";
			this.vmethod_78().Name = "AARUsage";
			this.vmethod_78().Resizable = DataGridViewTriState.True;
			this.vmethod_78().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_80().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_80().DataPropertyName = "AARSelection";
			this.vmethod_80().FlatStyle = FlatStyle.Flat;
			this.vmethod_80().HeaderText = "加油机选择";
			this.vmethod_80().Name = "AARSelection";
			this.vmethod_80().Resizable = DataGridViewTriState.True;
			this.vmethod_80().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_80().Width = 111;
			this.vmethod_82().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_82().DataPropertyName = "Formation";
			this.vmethod_82().FlatStyle = FlatStyle.Flat;
			this.vmethod_82().HeaderText = "编队";
			this.vmethod_82().Name = "Formation";
			this.vmethod_82().Resizable = DataGridViewTriState.True;
			this.vmethod_82().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_82().Width = 76;
			this.vmethod_84().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_84().DataPropertyName = "AARSettings";
			this.vmethod_84().HeaderText = "空中加油规划设置";
			this.vmethod_84().Name = "AARSettings";
			this.vmethod_84().ReadOnly = true;
			this.vmethod_84().Width = 144;
			this.vmethod_86().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_86().DataPropertyName = "Doctrine";
			this.vmethod_86().HeaderText = "作战条令/电磁管控/武器使用规则";
			this.vmethod_86().Name = "Doctrine";
			this.vmethod_86().Width = 157;
			this.vmethod_88().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_88().DataPropertyName = "SensorUsage";
			this.vmethod_88().HeaderText = "传感器运用";
			this.vmethod_88().Name = "SensorUsage";
			this.vmethod_88().Width = 97;
			this.vmethod_90().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_90().DataPropertyName = "Coordinates";
			this.vmethod_90().HeaderText = "坐标系";
			this.vmethod_90().Name = "Coordinates";
			this.vmethod_90().Width = 86;
			this.GetTurnRate().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.GetTurnRate().DataPropertyName = "TurnRate";
			this.GetTurnRate().FlatStyle = FlatStyle.Flat;
			this.GetTurnRate().HeaderText = "转弯速率";
			this.GetTurnRate().Name = "TurnRate";
			this.GetTurnRate().Width = 59;
			this.GetButton_InsertWaypoint().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.GetButton_InsertWaypoint().Location = new Point(-1, 251);
			this.GetButton_InsertWaypoint().Name = "Button_InsertWaypoint";
			this.GetButton_InsertWaypoint().Size = new Size(95, 24);
			this.GetButton_InsertWaypoint().TabIndex = 12;
			this.GetButton_InsertWaypoint().Text = "插入航路点";
			this.GetButton_InsertWaypoint().UseVisualStyleBackColor = true;
			this.GetButton_DeleteWaypoint().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.GetButton_DeleteWaypoint().Location = new Point(100, 251);
			this.GetButton_DeleteWaypoint().Name = "Button_DeleteWaypoint";
			this.GetButton_DeleteWaypoint().Size = new Size(95, 24);
			this.GetButton_DeleteWaypoint().TabIndex = 13;
			this.GetButton_DeleteWaypoint().Text = "删除航路点";
			this.GetButton_DeleteWaypoint().UseVisualStyleBackColor = true;
			this.GetLabel_AssignedAircrarft().AutoSize = true;
			this.GetLabel_AssignedAircrarft().Location = new Point(-3, 4);
			this.GetLabel_AssignedAircrarft().Name = "Label_AssignedAircrarft";
			this.GetLabel_AssignedAircrarft().Size = new Size(116, 13);
			this.GetLabel_AssignedAircrarft().TabIndex = 14;
			this.GetLabel_AssignedAircrarft().Text = "Unit: <Callsign><Type>";
			this.GetButton_ChangeAssignedAircraft().Location = new Point(125, -1);
			this.GetButton_ChangeAssignedAircraft().Name = "Button_ChangeAssignedAircraft";
			this.GetButton_ChangeAssignedAircraft().Size = new Size(75, 23);
			this.GetButton_ChangeAssignedAircraft().TabIndex = 15;
			this.GetButton_ChangeAssignedAircraft().Text = "修改";
			this.GetButton_ChangeAssignedAircraft().UseVisualStyleBackColor = true;
			this.GetButton_EditTime().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.GetButton_EditTime().Location = new Point(0, 281);
			this.GetButton_EditTime().Name = "Button_EditTime";
			this.GetButton_EditTime().Size = new Size(95, 24);
			this.GetButton_EditTime().TabIndex = 16;
			this.GetButton_EditTime().Text = "编辑时间";
			this.GetButton_EditTime().UseVisualStyleBackColor = true;
			this.GetButton_EditSpeedAltitude().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.GetButton_EditSpeedAltitude().Location = new Point(269, 281);
			this.GetButton_EditSpeedAltitude().Name = "Button_EditSpeedAltitude";
			this.GetButton_EditSpeedAltitude().Size = new Size(118, 24);
			this.GetButton_EditSpeedAltitude().TabIndex = 17;
			this.GetButton_EditSpeedAltitude().Text = "编辑航速与高度";
			this.GetButton_EditSpeedAltitude().UseVisualStyleBackColor = true;
			this.GetButton_EditDoctrine().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.GetButton_EditDoctrine().Location = new Point(-1, 311);
			this.GetButton_EditDoctrine().Name = "Button_EditDoctrine";
			this.GetButton_EditDoctrine().Size = new Size(174, 24);
			this.GetButton_EditDoctrine().TabIndex = 18;
			this.GetButton_EditDoctrine().Text = "编辑条令/电磁管控/武器使用规则";
			this.GetButton_EditDoctrine().UseVisualStyleBackColor = true;
			this.GetButton_EditSensorUsage().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.GetButton_EditSensorUsage().Location = new Point(315, 311);
			this.GetButton_EditSensorUsage().Name = "Button_EditSensorUsage";
			this.GetButton_EditSensorUsage().Size = new Size(174, 24);
			this.GetButton_EditSensorUsage().TabIndex = 19;
			this.GetButton_EditSensorUsage().Text = "编辑传感器运用";
			this.GetButton_EditSensorUsage().UseVisualStyleBackColor = true;
			this.GetButton_EditAAR().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.GetButton_EditAAR().Location = new Point(166, 311);
			this.GetButton_EditAAR().Name = "Button_EditAAR";
			this.GetButton_EditAAR().Size = new Size(174, 24);
			this.GetButton_EditAAR().TabIndex = 20;
			this.GetButton_EditAAR().Text = "编辑空中加油设置";
			this.GetButton_EditAAR().UseVisualStyleBackColor = true;
			this.GetDataGridViewTextBoxColumn1().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.GetDataGridViewTextBoxColumn1().DataPropertyName = "ID";
			this.GetDataGridViewTextBoxColumn1().Frozen = true;
			this.GetDataGridViewTextBoxColumn1().HeaderText = "航路点";
			this.GetDataGridViewTextBoxColumn1().Name = "DataGridViewTextBoxColumn1";
			this.GetDataGridViewTextBoxColumn1().ReadOnly = true;
			this.vmethod_20().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_20().DataPropertyName = "Time_Zulu";
			dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.BottomCenter;
			this.vmethod_20().DefaultCellStyle = dataGridViewCellStyle17;
			this.vmethod_20().HeaderText = "Zulu";
			this.vmethod_20().Name = "DataGridViewTextBoxColumn2";
			this.vmethod_20().ReadOnly = true;
			this.vmethod_22().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_22().DataPropertyName = "Time_Local";
			dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.BottomCenter;
			this.vmethod_22().DefaultCellStyle = dataGridViewCellStyle18;
			this.vmethod_22().HeaderText = "Local";
			this.vmethod_22().Name = "DataGridViewTextBoxColumn3";
			this.vmethod_22().ReadOnly = true;
			this.GetTimeFixed().DataPropertyName = "TimeFixed";
			this.GetTimeFixed().HeaderText = "固定时间";
			this.GetTimeFixed().Name = "DataGridViewTextBoxColumn4";
			this.GetTimeFixed().Resizable = DataGridViewTriState.True;
			this.GetTimeFixed().Visible = false;
			this.GetTimeFixed().Width = 5;
			this.GetDesiredSpeed().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.GetDesiredSpeed().DataPropertyName = "期望航速";
			this.GetDesiredSpeed().HeaderText = " ";
			this.GetDesiredSpeed().Name = "DataGridViewTextBoxColumn5";
			this.GetDesiredSpeed().ReadOnly = true;
			this.GetSpeedFixed().DataPropertyName = "SpeedFixed";
			this.GetSpeedFixed().HeaderText = "固定速度";
			this.GetSpeedFixed().Name = "DataGridViewTextBoxColumn6";
			this.GetSpeedFixed().Resizable = DataGridViewTriState.True;
			this.GetSpeedFixed().Visible = false;
			this.GetSpeedFixed().Width = 5;
			this.GetDesiredAltitude().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.GetDesiredAltitude().DataPropertyName = "DesiredAltitude";
			this.GetDesiredAltitude().HeaderText = "期望高度";
			this.GetDesiredAltitude().Name = "DataGridViewTextBoxColumn7";
			this.GetDesiredAltitude().ReadOnly = true;
			this.GetAARSettings().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.GetAARSettings().DataPropertyName = "AARSettings";
			this.GetAARSettings().HeaderText = "空中加油设置";
			this.GetAARSettings().Name = "DataGridViewTextBoxColumn8";
			this.GetAARSettings().ReadOnly = true;
			this.GetDoctrine().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.GetDoctrine().DataPropertyName = "Doctrine";
			this.GetDoctrine().HeaderText = "作战条令/电磁管控/武器使用规则";
			this.GetDoctrine().Name = "DataGridViewTextBoxColumn9";
			this.GetSensorUsage().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.GetSensorUsage().DataPropertyName = "SensorUsage";
			this.GetSensorUsage().HeaderText = "传感器运用";
			this.GetSensorUsage().Name = "DataGridViewTextBoxColumn10";
			this.GetCoordinates().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.GetCoordinates().DataPropertyName = "Coordinates";
			this.GetCoordinates().HeaderText = "坐标系";
			this.GetCoordinates().Name = "DataGridViewTextBoxColumn11";
			this.GetButton_ClearTime().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.GetButton_ClearTime().Location = new Point(100, 281);
			this.GetButton_ClearTime().Name = "Button_ClearTime";
			this.GetButton_ClearTime().Size = new Size(163, 24);
			this.GetButton_ClearTime().TabIndex = 21;
			this.GetButton_ClearTime().Text = "清除所有航路点时间";
			this.GetButton_ClearTime().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.GetButton_ClearTime());
			base.Controls.Add(this.GetButton_EditAAR());
			base.Controls.Add(this.GetButton_EditSensorUsage());
			base.Controls.Add(this.GetButton_EditDoctrine());
			base.Controls.Add(this.GetButton_EditSpeedAltitude());
			base.Controls.Add(this.GetButton_EditTime());
			base.Controls.Add(this.GetButton_ChangeAssignedAircraft());
			base.Controls.Add(this.GetLabel_AssignedAircrarft());
			base.Controls.Add(this.GetButton_DeleteWaypoint());
			base.Controls.Add(this.GetButton_InsertWaypoint());
			base.Controls.Add(this.vmethod_0());
			base.Name = "FlightPlanWaypoints";
			base.Size = new Size(492, 352);
			((ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000F8FA0 File Offset: 0x000F71A0
		[CompilerGenerated]
		internal  DataGridView vmethod_0()
		{
			return this.dataGridView_0;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000F8FB8 File Offset: 0x000F71B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(DataGridView dataGridView_1)
		{
			DataGridViewCellPaintingEventHandler value = new DataGridViewCellPaintingEventHandler(this.method_8);
			DataGridViewColumnEventHandler value2 = new DataGridViewColumnEventHandler(this.method_9);
			PaintEventHandler value3 = new PaintEventHandler(this.method_10);
			ScrollEventHandler value4 = new ScrollEventHandler(this.method_11);
			EventHandler value5 = new EventHandler(this.method_12);
			EventHandler value6 = new EventHandler(this.method_13);
			EventHandler value7 = new EventHandler(this.method_14);
			DataGridViewCellEventHandler value8 = new DataGridViewCellEventHandler(this.method_16);
			DataGridViewCellEventHandler value9 = new DataGridViewCellEventHandler(this.method_18);
			EventHandler value10 = new EventHandler(this.method_19);
			EventHandler value11 = new EventHandler(this.method_21);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellPainting -= value;
				dataGridView.ColumnWidthChanged -= value2;
				dataGridView.Paint -= value3;
				dataGridView.Scroll -= value4;
				dataGridView.MouseHover -= value5;
				dataGridView.Enter -= value6;
				dataGridView.SelectionChanged -= value7;
				dataGridView.CellClick -= value8;
				dataGridView.CellValueChanged -= value9;
				dataGridView.CurrentCellDirtyStateChanged -= value10;
				dataGridView.SelectionChanged -= value11;
			}
			this.dataGridView_0 = dataGridView_1;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.CellPainting += value;
				dataGridView.ColumnWidthChanged += value2;
				dataGridView.Paint += value3;
				dataGridView.Scroll += value4;
				dataGridView.MouseHover += value5;
				dataGridView.Enter += value6;
				dataGridView.SelectionChanged += value7;
				dataGridView.CellClick += value8;
				dataGridView.CellValueChanged += value9;
				dataGridView.CurrentCellDirtyStateChanged += value10;
				dataGridView.SelectionChanged += value11;
			}
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000F9140 File Offset: 0x000F7340
		[CompilerGenerated]
		internal  Button GetButton_InsertWaypoint()
		{
			return this.button_0;
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x000F9158 File Offset: 0x000F7358
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Button button_9)
		{
			EventHandler value = new EventHandler(this.method_1);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_9;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x000F91A4 File Offset: 0x000F73A4
		[CompilerGenerated]
		internal  Button GetButton_DeleteWaypoint()
		{
			return this.Button_DeleteWaypoint;
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x000F91BC File Offset: 0x000F73BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_DeleteWaypoint(Button button_9)
		{
			EventHandler value = new EventHandler(this.Button_DeleteWaypoint_Click);
			Button button_DeleteWaypoint = this.Button_DeleteWaypoint;
			if (button_DeleteWaypoint != null)
			{
				button_DeleteWaypoint.Click -= value;
			}
			this.Button_DeleteWaypoint = button_9;
			button_DeleteWaypoint = this.Button_DeleteWaypoint;
			if (button_DeleteWaypoint != null)
			{
				button_DeleteWaypoint.Click += value;
			}
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x000F9208 File Offset: 0x000F7408
		[CompilerGenerated]
		internal  Label GetLabel_AssignedAircrarft()
		{
			return this.label_0;
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x000167EB File Offset: 0x000149EB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x000F9220 File Offset: 0x000F7420
		[CompilerGenerated]
		internal  Button GetButton_ChangeAssignedAircraft()
		{
			return this.Button_ChangeAssignedAircraft;
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x000F9238 File Offset: 0x000F7438
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_ChangeAssignedAircraft(Button button_9)
		{
			EventHandler value = new EventHandler(this.Button_ChangeAssignedAircraft_Click);
			Button button_ChangeAssignedAircraft = this.Button_ChangeAssignedAircraft;
			if (button_ChangeAssignedAircraft != null)
			{
				button_ChangeAssignedAircraft.Click -= value;
			}
			this.Button_ChangeAssignedAircraft = button_9;
			button_ChangeAssignedAircraft = this.Button_ChangeAssignedAircraft;
			if (button_ChangeAssignedAircraft != null)
			{
				button_ChangeAssignedAircraft.Click += value;
			}
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x000F9284 File Offset: 0x000F7484
		[CompilerGenerated]
		internal  Button GetButton_EditTime()
		{
			return this.Button_EditTime;
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x000F929C File Offset: 0x000F749C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_EditTime(Button button_9)
		{
			EventHandler value = new EventHandler(this.Button_EditTime_Click);
			Button button_EditTime = this.Button_EditTime;
			if (button_EditTime != null)
			{
				button_EditTime.Click -= value;
			}
			this.Button_EditTime = button_9;
			button_EditTime = this.Button_EditTime;
			if (button_EditTime != null)
			{
				button_EditTime.Click += value;
			}
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x000F92E8 File Offset: 0x000F74E8
		[CompilerGenerated]
		internal  Button GetButton_EditSpeedAltitude()
		{
			return this.Button_EditSpeedAltitude;
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x000F9300 File Offset: 0x000F7500
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_EditSpeedAltitude(Button button_9)
		{
			EventHandler value = new EventHandler(this.Button_EditSpeedAltitude_Click);
			Button button_EditSpeedAltitude = this.Button_EditSpeedAltitude;
			if (button_EditSpeedAltitude != null)
			{
				button_EditSpeedAltitude.Click -= value;
			}
			this.Button_EditSpeedAltitude = button_9;
			button_EditSpeedAltitude = this.Button_EditSpeedAltitude;
			if (button_EditSpeedAltitude != null)
			{
				button_EditSpeedAltitude.Click += value;
			}
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x000F934C File Offset: 0x000F754C
		[CompilerGenerated]
		internal  Button GetButton_EditDoctrine()
		{
			return this.Button_EditDoctrine;
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x000F9364 File Offset: 0x000F7564
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_EditDoctrine(Button button_9)
		{
			EventHandler value = new EventHandler(this.Button_EditDoctrine_Click);
			Button button_EditDoctrine = this.Button_EditDoctrine;
			if (button_EditDoctrine != null)
			{
				button_EditDoctrine.Click -= value;
			}
			this.Button_EditDoctrine = button_9;
			button_EditDoctrine = this.Button_EditDoctrine;
			if (button_EditDoctrine != null)
			{
				button_EditDoctrine.Click += value;
			}
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x000F93B0 File Offset: 0x000F75B0
		[CompilerGenerated]
		internal  Button GetButton_EditAAR()
		{
			return this.Button_EditAAR;
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x000F93C8 File Offset: 0x000F75C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_EditAAR(Button button_9)
		{
			EventHandler value = new EventHandler(this.Button_EditAAR_Click);
			Button button_EditAAR = this.Button_EditAAR;
			if (button_EditAAR != null)
			{
				button_EditAAR.Click -= value;
			}
			this.Button_EditAAR = button_9;
			button_EditAAR = this.Button_EditAAR;
			if (button_EditAAR != null)
			{
				button_EditAAR.Click += value;
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x000F9414 File Offset: 0x000F7614
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetDataGridViewTextBoxColumn1()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000167F4 File Offset: 0x000149F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000F942C File Offset: 0x000F762C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_20()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x000167FD File Offset: 0x000149FD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x000F9444 File Offset: 0x000F7644
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_22()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x00016806 File Offset: 0x00014A06
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x000F945C File Offset: 0x000F765C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetTimeFixed()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x0001680F File Offset: 0x00014A0F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x000F9474 File Offset: 0x000F7674
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetDesiredSpeed()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x00016818 File Offset: 0x00014A18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000F948C File Offset: 0x000F768C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetSpeedFixed()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00016821 File Offset: 0x00014A21
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x000F94A4 File Offset: 0x000F76A4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetDesiredAltitude()
		{
			return this.dataGridViewTextBoxColumn_6;
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0001682A File Offset: 0x00014A2A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_6 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x000F94BC File Offset: 0x000F76BC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetAARSettings()
		{
			return this.dataGridViewTextBoxColumn_7;
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x00016833 File Offset: 0x00014A33
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_7 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x000F94D4 File Offset: 0x000F76D4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetDoctrine()
		{
			return this.dataGridViewTextBoxColumn_8;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x0001683C File Offset: 0x00014A3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_8 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000F94EC File Offset: 0x000F76EC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetSensorUsage()
		{
			return this.dataGridViewTextBoxColumn_9;
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x00016845 File Offset: 0x00014A45
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_9 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x000F9504 File Offset: 0x000F7704
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn GetCoordinates()
		{
			return this.dataGridViewTextBoxColumn_10;
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x0001684E File Offset: 0x00014A4E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_10 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x000F951C File Offset: 0x000F771C
		[CompilerGenerated]
		internal  Button GetButton_ClearTime()
		{
			return this.button_7;
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x000F9534 File Offset: 0x000F7734
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Button button_9)
		{
			EventHandler value = new EventHandler(this.method_22);
			Button button = this.button_7;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_7 = button_9;
			button = this.button_7;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x000F9580 File Offset: 0x000F7780
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_42()
		{
			return this.dataGridViewTextBoxColumn_11;
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x00016857 File Offset: 0x00014A57
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_11 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x000F9598 File Offset: 0x000F7798
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_44()
		{
			return this.dataGridViewTextBoxColumn_12;
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00016860 File Offset: 0x00014A60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_12 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x000F95B0 File Offset: 0x000F77B0
		[CompilerGenerated]
		internal  DataGridViewComboBoxColumn vmethod_46()
		{
			return this.dataGridViewComboBoxColumn_0;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00016869 File Offset: 0x00014A69
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5)
		{
			this.dataGridViewComboBoxColumn_0 = dataGridViewComboBoxColumn_5;
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x000F95C8 File Offset: 0x000F77C8
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_48()
		{
			return this.dataGridViewTextBoxColumn_13;
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x00016872 File Offset: 0x00014A72
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_13 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x000F95E0 File Offset: 0x000F77E0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_50()
		{
			return this.dataGridViewTextBoxColumn_14;
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x0001687B File Offset: 0x00014A7B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_14 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x000F95F8 File Offset: 0x000F77F8
		[CompilerGenerated]
		internal  DataGridViewImageColumn vmethod_52()
		{
			return this.dataGridViewImageColumn_0;
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x00016884 File Offset: 0x00014A84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(DataGridViewImageColumn dataGridViewImageColumn_2)
		{
			this.dataGridViewImageColumn_0 = dataGridViewImageColumn_2;
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x000F9610 File Offset: 0x000F7810
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_54()
		{
			return this.dataGridViewTextBoxColumn_15;
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x0001688D File Offset: 0x00014A8D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_55(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_15 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000F9628 File Offset: 0x000F7828
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_56()
		{
			return this.dataGridViewTextBoxColumn_16;
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00016896 File Offset: 0x00014A96
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_57(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_16 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x000F9640 File Offset: 0x000F7840
		[CompilerGenerated]
		internal  DataGridViewImageColumn vmethod_58()
		{
			return this.dataGridViewImageColumn_1;
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x0001689F File Offset: 0x00014A9F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_59(DataGridViewImageColumn dataGridViewImageColumn_2)
		{
			this.dataGridViewImageColumn_1 = dataGridViewImageColumn_2;
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000F9658 File Offset: 0x000F7858
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_60()
		{
			return this.dataGridViewTextBoxColumn_17;
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000168A8 File Offset: 0x00014AA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_61(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_17 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000F9670 File Offset: 0x000F7870
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_62()
		{
			return this.dataGridViewTextBoxColumn_18;
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000168B1 File Offset: 0x00014AB1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_63(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_18 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000F9688 File Offset: 0x000F7888
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_64()
		{
			return this.dataGridViewTextBoxColumn_19;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000168BA File Offset: 0x00014ABA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_65(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_19 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000F96A0 File Offset: 0x000F78A0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_66()
		{
			return this.dataGridViewTextBoxColumn_20;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x000168C3 File Offset: 0x00014AC3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_67(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_20 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x000F96B8 File Offset: 0x000F78B8
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_68()
		{
			return this.dataGridViewTextBoxColumn_21;
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x000168CC File Offset: 0x00014ACC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_69(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_21 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x000F96D0 File Offset: 0x000F78D0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_70()
		{
			return this.dataGridViewTextBoxColumn_22;
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x000168D5 File Offset: 0x00014AD5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_71(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_22 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x000F96E8 File Offset: 0x000F78E8
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_72()
		{
			return this.dataGridViewTextBoxColumn_23;
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000168DE File Offset: 0x00014ADE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_73(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_23 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x000F9700 File Offset: 0x000F7900
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_74()
		{
			return this.dataGridViewTextBoxColumn_24;
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x000168E7 File Offset: 0x00014AE7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_75(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_24 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x000F9718 File Offset: 0x000F7918
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_76()
		{
			return this.dataGridViewTextBoxColumn_25;
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x000168F0 File Offset: 0x00014AF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_77(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_25 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x000F9730 File Offset: 0x000F7930
		[CompilerGenerated]
		internal  DataGridViewComboBoxColumn vmethod_78()
		{
			return this.dataGridViewComboBoxColumn_1;
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x000168F9 File Offset: 0x00014AF9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_79(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5)
		{
			this.dataGridViewComboBoxColumn_1 = dataGridViewComboBoxColumn_5;
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x000F9748 File Offset: 0x000F7948
		[CompilerGenerated]
		internal  DataGridViewComboBoxColumn vmethod_80()
		{
			return this.dataGridViewComboBoxColumn_2;
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x00016902 File Offset: 0x00014B02
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_81(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5)
		{
			this.dataGridViewComboBoxColumn_2 = dataGridViewComboBoxColumn_5;
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000F9760 File Offset: 0x000F7960
		[CompilerGenerated]
		internal  DataGridViewComboBoxColumn vmethod_82()
		{
			return this.dataGridViewComboBoxColumn_3;
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x0001690B File Offset: 0x00014B0B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_83(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5)
		{
			this.dataGridViewComboBoxColumn_3 = dataGridViewComboBoxColumn_5;
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x000F9778 File Offset: 0x000F7978
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_84()
		{
			return this.dataGridViewTextBoxColumn_26;
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x00016914 File Offset: 0x00014B14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_85(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_26 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000F9790 File Offset: 0x000F7990
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_86()
		{
			return this.dataGridViewTextBoxColumn_27;
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x0001691D File Offset: 0x00014B1D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_87(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_27 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x000F97A8 File Offset: 0x000F79A8
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_88()
		{
			return this.dataGridViewTextBoxColumn_28;
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x00016926 File Offset: 0x00014B26
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_89(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_28 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x000F97C0 File Offset: 0x000F79C0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_90()
		{
			return this.dataGridViewTextBoxColumn_29;
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x0001692F File Offset: 0x00014B2F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_91(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30)
		{
			this.dataGridViewTextBoxColumn_29 = dataGridViewTextBoxColumn_30;
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x000F97D8 File Offset: 0x000F79D8
		[CompilerGenerated]
		internal  DataGridViewComboBoxColumn GetTurnRate()
		{
			return this.dataGridViewComboBoxColumn_4;
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00016938 File Offset: 0x00014B38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_93(DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5)
		{
			this.dataGridViewComboBoxColumn_4 = dataGridViewComboBoxColumn_5;
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x000F97F0 File Offset: 0x000F79F0
		[CompilerGenerated]
		internal  Button GetButton_EditSensorUsage()
		{
			return this.button_8;
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x000F9808 File Offset: 0x000F7A08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_95(Button button_9)
		{
			EventHandler value = new EventHandler(this.method_7);
			Button button = this.button_8;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_8 = button_9;
			button = this.button_8;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void Button_ChangeAssignedAircraft_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x000F9854 File Offset: 0x000F7A54
		private void method_1(object sender, EventArgs e)
		{
			bool flag = false;
			int count = this.vmethod_0().Rows.Count;
			int num = count - 1;
			float num2 = 0f;
			Waypoint waypoint = null;
			Waypoint waypoint2 = null;
			Waypoint[] array = null;
			Scenario clientScenario2;
			Mission mission;
			ActiveUnit referenceUnit;
			Mission.Flight flight2;
			Mission.Flight flight3;
			Mission.Enum60 bingo;
			for (int i = 0; i <= num; i++)
			{
				DataGridViewRow dataGridViewRow = this.vmethod_0().Rows[i];
				if (dataGridViewRow.Selected)
				{
					waypoint = (Waypoint)dataGridViewRow.Tag;
					if (this.enum70_0 != Mission.Flight._FlightRole.const_1)
					{
						waypoint = Client.flightPlanEditor.m_Flight.GetFlightCourse()[i];
					}
					Waypoint.WaypointType waypointType;
					switch (waypoint.waypointType)
					{
					case Waypoint.WaypointType.ManualPlottedCourseWaypoint:
						waypointType = Waypoint.WaypointType.ManualPlottedCourseWaypoint;
						goto IL_37E;
					case Waypoint.WaypointType.PatrolStation:
					case Waypoint.WaypointType.Assemble:
					case Waypoint.WaypointType.LandingMarshal:
					case Waypoint.WaypointType.Refuel:
					case Waypoint.WaypointType.TakeOff:
					case Waypoint.WaypointType.Marshal:
					case Waypoint.WaypointType.Land:
						waypointType = Waypoint.WaypointType.TurningPoint;
						goto IL_37E;
					case Waypoint.WaypointType.TurningPoint:
						waypointType = Waypoint.WaypointType.TurningPoint;
						goto IL_37E;
					case Waypoint.WaypointType.InitialPoint:
					case Waypoint.WaypointType.Split:
					case Waypoint.WaypointType.WeaponLaunch:
						waypointType = Waypoint.WaypointType.StrikeIngress;
						goto IL_37E;
					case Waypoint.WaypointType.Formate:
					case Waypoint.WaypointType.Target:
					case Waypoint.WaypointType.WeaponTarget:
						waypointType = Waypoint.WaypointType.StrikeEgress;
						goto IL_37E;
					case Waypoint.WaypointType.StrikeIngress:
						waypointType = Waypoint.WaypointType.StrikeIngress;
						goto IL_37E;
					case Waypoint.WaypointType.StrikeEgress:
						waypointType = Waypoint.WaypointType.StrikeEgress;
						goto IL_37E;
					}
					waypointType = Waypoint.WaypointType.ManualPlottedCourseWaypoint;
					IL_37E:
					GeoPoint geoPoint = new GeoPoint();
					GeoPoint geoPoint2 = new GeoPoint();
					GeoPoint geoPoint3 = new GeoPoint();
					GeoPoint geoPoint4 = new GeoPoint();
					GeoPoint geoPoint5 = new GeoPoint();
					GeoPoint geoPoint6 = new GeoPoint();
					if (i + 1 <= count - 1)
					{
						Waypoint waypoint3 = Client.flightPlanEditor.m_Flight.GetFlightCourse()[i + 1];
						double angle = (double)Math2.GetAzimuth(waypoint.GetLatitude(), waypoint.GetLongitude(), waypoint3.GetLatitude(), waypoint3.GetLongitude());
						double num3 = (double)Math2.GetDistance(waypoint.GetLatitude(), waypoint.GetLongitude(), waypoint3.GetLatitude(), waypoint3.GetLongitude());
						double longitude = waypoint.GetLongitude();
						double latitude = waypoint.GetLatitude();
						GeoPoint geoPoint7;
						double num4 = (geoPoint7 = geoPoint).GetLongitude();
						GeoPoint geoPoint8;
						double num5 = (geoPoint8 = geoPoint).GetLatitude();
						GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref num4, ref num5, num3 / 2.0, Math2.Normalize(angle));
						geoPoint8.SetLatitude(num5);
						geoPoint7.SetLongitude(num4);
						if (!Information.IsNothing(waypoint.WP_LeadElementWingman))
						{
							Waypoint wP_LeadElementWingman = waypoint.WP_LeadElementWingman;
							Waypoint waypoint4;
							if (Information.IsNothing(waypoint3.WP_LeadElementWingman))
							{
								waypoint4 = waypoint3;
							}
							else
							{
								waypoint4 = waypoint3.WP_LeadElementWingman;
							}
							angle = (double)Math2.GetAzimuth(wP_LeadElementWingman.GetLatitude(), wP_LeadElementWingman.GetLongitude(), waypoint4.GetLatitude(), waypoint4.GetLongitude());
							num3 = (double)Math2.GetDistance(wP_LeadElementWingman.GetLatitude(), wP_LeadElementWingman.GetLongitude(), waypoint4.GetLatitude(), waypoint4.GetLongitude());
							double longitude2 = wP_LeadElementWingman.GetLongitude();
							double latitude2 = wP_LeadElementWingman.GetLatitude();
							num5 = (geoPoint8 = geoPoint2).GetLongitude();
							num4 = (geoPoint7 = geoPoint2).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude2, latitude2, ref num5, ref num4, num3 / 2.0, Math2.Normalize(angle));
							geoPoint7.SetLatitude(num4);
							geoPoint8.SetLongitude(num5);
						}
						if (!Information.IsNothing(waypoint.WP_SecondElement))
						{
							Waypoint wP_SecondElement = waypoint.WP_SecondElement;
							Waypoint waypoint5;
							if (Information.IsNothing(waypoint3.WP_SecondElement))
							{
								waypoint5 = waypoint3;
							}
							else
							{
								waypoint5 = waypoint3.WP_SecondElement;
							}
							angle = (double)Math2.GetAzimuth(wP_SecondElement.GetLatitude(), wP_SecondElement.GetLongitude(), waypoint5.GetLatitude(), waypoint5.GetLongitude());
							num3 = (double)Math2.GetDistance(wP_SecondElement.GetLatitude(), wP_SecondElement.GetLongitude(), waypoint5.GetLatitude(), waypoint5.GetLongitude());
							double longitude3 = wP_SecondElement.GetLongitude();
							double latitude3 = wP_SecondElement.GetLatitude();
							num4 = (geoPoint7 = geoPoint).GetLongitude();
							num5 = (geoPoint8 = geoPoint).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude3, latitude3, ref num4, ref num5, num3 / 2.0, Math2.Normalize(angle));
							geoPoint8.SetLatitude(num5);
							geoPoint7.SetLongitude(num4);
						}
						if (!Information.IsNothing(waypoint.WP_SecondElementWingman))
						{
							Waypoint wP_SecondElement2 = waypoint.WP_SecondElement;
							Waypoint waypoint6;
							if (Information.IsNothing(waypoint3.WP_SecondElement))
							{
								waypoint6 = waypoint3;
							}
							else
							{
								waypoint6 = waypoint3.WP_SecondElement;
							}
							angle = (double)Math2.GetAzimuth(wP_SecondElement2.GetLatitude(), wP_SecondElement2.GetLongitude(), waypoint6.GetLatitude(), waypoint6.GetLongitude());
							num3 = (double)Math2.GetDistance(wP_SecondElement2.GetLatitude(), wP_SecondElement2.GetLongitude(), waypoint6.GetLatitude(), waypoint6.GetLongitude());
							double longitude4 = wP_SecondElement2.GetLongitude();
							double latitude4 = wP_SecondElement2.GetLatitude();
							num5 = (geoPoint8 = geoPoint).GetLongitude();
							num4 = (geoPoint7 = geoPoint).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude4, latitude4, ref num5, ref num4, num3 / 2.0, Math2.Normalize(angle));
							geoPoint7.SetLatitude(num4);
							geoPoint8.SetLongitude(num5);
						}
						if (!Information.IsNothing(waypoint.WP_ThirdElement))
						{
							Waypoint wP_SecondElement3 = waypoint.WP_SecondElement;
							Waypoint waypoint7;
							if (Information.IsNothing(waypoint3.WP_SecondElement))
							{
								waypoint7 = waypoint3;
							}
							else
							{
								waypoint7 = waypoint3.WP_SecondElement;
							}
							angle = (double)Math2.GetAzimuth(wP_SecondElement3.GetLatitude(), wP_SecondElement3.GetLongitude(), waypoint7.GetLatitude(), waypoint7.GetLongitude());
							num3 = (double)Math2.GetDistance(wP_SecondElement3.GetLatitude(), wP_SecondElement3.GetLongitude(), waypoint7.GetLatitude(), waypoint7.GetLongitude());
							double longitude5 = wP_SecondElement3.GetLongitude();
							double latitude5 = wP_SecondElement3.GetLatitude();
							num4 = (geoPoint7 = geoPoint).GetLongitude();
							num5 = (geoPoint8 = geoPoint).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude5, latitude5, ref num4, ref num5, num3 / 2.0, Math2.Normalize(angle));
							geoPoint8.SetLatitude(num5);
							geoPoint7.SetLongitude(num4);
						}
						if (!Information.IsNothing(waypoint.WP_ThirdElementWingman))
						{
							Waypoint wP_SecondElement4 = waypoint.WP_SecondElement;
							Waypoint waypoint8;
							if (Information.IsNothing(waypoint3.WP_SecondElement))
							{
								waypoint8 = waypoint3;
							}
							else
							{
								waypoint8 = waypoint3.WP_SecondElement;
							}
							angle = (double)Math2.GetAzimuth(wP_SecondElement4.GetLatitude(), wP_SecondElement4.GetLongitude(), waypoint8.GetLatitude(), waypoint8.GetLongitude());
							num3 = (double)Math2.GetDistance(wP_SecondElement4.GetLatitude(), wP_SecondElement4.GetLongitude(), waypoint8.GetLatitude(), waypoint8.GetLongitude());
							double longitude6 = wP_SecondElement4.GetLongitude();
							double latitude6 = wP_SecondElement4.GetLatitude();
							num5 = (geoPoint8 = geoPoint).GetLongitude();
							num4 = (geoPoint7 = geoPoint).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude6, latitude6, ref num5, ref num4, num3 / 2.0, Math2.Normalize(angle));
							geoPoint7.SetLatitude(num4);
							geoPoint8.SetLongitude(num5);
						}
					}
					else
					{
						double longitude7 = waypoint.GetLongitude();
						double latitude7 = waypoint.GetLatitude();
						GeoPoint geoPoint7;
						double num4 = (geoPoint7 = geoPoint).GetLongitude();
						GeoPoint geoPoint8;
						double num5 = (geoPoint8 = geoPoint).GetLatitude();
						GeoPointGenerator.GetOtherGeoPoint(longitude7, latitude7, ref num4, ref num5, 10.0, 0.0);
						geoPoint8.SetLatitude(num5);
						geoPoint7.SetLongitude(num4);
						if (!Information.IsNothing(waypoint.WP_LeadElementWingman))
						{
							double longitude8 = waypoint.WP_LeadElementWingman.GetLongitude();
							double latitude8 = waypoint.WP_LeadElementWingman.GetLatitude();
							num5 = (geoPoint8 = geoPoint).GetLongitude();
							num4 = (geoPoint7 = geoPoint).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude8, latitude8, ref num5, ref num4, 10.0, 0.0);
							geoPoint7.SetLatitude(num4);
							geoPoint8.SetLongitude(num5);
						}
						if (!Information.IsNothing(waypoint.WP_SecondElement))
						{
							double longitude9 = waypoint.WP_SecondElement.GetLongitude();
							double latitude9 = waypoint.WP_SecondElement.GetLatitude();
							num4 = (geoPoint7 = geoPoint).GetLongitude();
							num5 = (geoPoint8 = geoPoint).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude9, latitude9, ref num4, ref num5, 10.0, 0.0);
							geoPoint8.SetLatitude(num5);
							geoPoint7.SetLongitude(num4);
						}
						if (!Information.IsNothing(waypoint.WP_SecondElementWingman))
						{
							double longitude10 = waypoint.WP_SecondElementWingman.GetLongitude();
							double latitude10 = waypoint.WP_SecondElementWingman.GetLatitude();
							num5 = (geoPoint8 = geoPoint).GetLongitude();
							num4 = (geoPoint7 = geoPoint).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude10, latitude10, ref num5, ref num4, 10.0, 0.0);
							geoPoint7.SetLatitude(num4);
							geoPoint8.SetLongitude(num5);
						}
						if (!Information.IsNothing(waypoint.WP_ThirdElement))
						{
							double longitude11 = waypoint.WP_ThirdElement.GetLongitude();
							double latitude11 = waypoint.WP_ThirdElement.GetLatitude();
							num4 = (geoPoint7 = geoPoint).GetLongitude();
							num5 = (geoPoint8 = geoPoint).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude11, latitude11, ref num4, ref num5, 10.0, 0.0);
							geoPoint8.SetLatitude(num5);
							geoPoint7.SetLongitude(num4);
						}
						if (!Information.IsNothing(waypoint.WP_ThirdElementWingman))
						{
							double longitude12 = waypoint.WP_ThirdElementWingman.GetLongitude();
							double latitude12 = waypoint.WP_ThirdElementWingman.GetLatitude();
							num5 = (geoPoint8 = geoPoint).GetLongitude();
							num4 = (geoPoint7 = geoPoint).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude12, latitude12, ref num5, ref num4, 10.0, 0.0);
							geoPoint7.SetLatitude(num4);
							geoPoint8.SetLongitude(num5);
						}
					}
					Waypoint waypoint9 = waypoint;
					Scenario clientScenario = Client.GetClientScenario();
					waypoint2 = waypoint9.method_23(ref clientScenario, ref waypoint, true, false);
					waypoint2.waypointType = waypointType;
					waypoint2.SetLatitude(geoPoint.GetLatitude());
					waypoint2.SetLongitude(geoPoint.GetLongitude());
					waypoint2.Hold_Time = 0f;
					if (!Information.IsNothing(waypoint2.WP_LeadElementWingman))
					{
						Waypoint wP_LeadElementWingman2 = waypoint2.WP_LeadElementWingman;
						wP_LeadElementWingman2.waypointType = waypointType;
						wP_LeadElementWingman2.SetLatitude(geoPoint2.GetLatitude());
						wP_LeadElementWingman2.SetLongitude(geoPoint2.GetLongitude());
					}
					if (!Information.IsNothing(waypoint2.WP_SecondElement))
					{
						Waypoint wP_SecondElement5 = waypoint2.WP_SecondElement;
						wP_SecondElement5.waypointType = waypointType;
						wP_SecondElement5.SetLatitude(geoPoint3.GetLatitude());
						wP_SecondElement5.SetLongitude(geoPoint3.GetLongitude());
					}
					if (!Information.IsNothing(waypoint2.WP_SecondElementWingman))
					{
						Waypoint wP_SecondElementWingman = waypoint2.WP_SecondElementWingman;
						wP_SecondElementWingman.waypointType = waypointType;
						wP_SecondElementWingman.SetLatitude(geoPoint4.GetLatitude());
						wP_SecondElementWingman.SetLongitude(geoPoint4.GetLongitude());
					}
					if (!Information.IsNothing(waypoint2.WP_ThirdElement))
					{
						Waypoint wP_ThirdElement = waypoint2.WP_ThirdElement;
						wP_ThirdElement.waypointType = waypointType;
						wP_ThirdElement.SetLatitude(geoPoint5.GetLatitude());
						wP_ThirdElement.SetLongitude(geoPoint5.GetLongitude());
					}
					if (!Information.IsNothing(waypoint2.WP_ThirdElementWingman))
					{
						Waypoint wP_ThirdElementWingman = waypoint2.WP_ThirdElementWingman;
						wP_ThirdElementWingman.waypointType = waypointType;
						wP_ThirdElementWingman.SetLatitude(geoPoint6.GetLatitude());
						wP_ThirdElementWingman.SetLongitude(geoPoint6.GetLongitude());
					}
					Mission.Flight flight = (Mission.Flight)this.vmethod_0().Tag;
					array = flight.GetFlightCourse();
					ActiveUnit_Navigator.InsertWayPoint(ref array, i + 1, waypoint2);
					flight.SetFlightCourse(array);
					if (!Information.IsNothing(waypoint) && !Information.IsNothing(waypoint2))
					{
						for (int j = Client.GetClientScenario().GetActiveUnitList().Count - 1; j >= 0; j += -1)
						{
							ActiveUnit activeUnit = Client.GetClientScenario().GetActiveUnitList()[j];
							if (activeUnit.IsOperating())
							{
								if ((activeUnit.IsAircraft || (activeUnit.IsGroup && ((Group)activeUnit).GetGroupType() == Group.GroupType.AirGroup)) && activeUnit.GetNavigator().HasFlightCourse() && !Information.IsNothing(activeUnit.GetSide(false)) && activeUnit.GetSide(false) == Client.GetClientSide())
								{
									int num6 = activeUnit.GetNavigator().GetPlottedCourse().Count<Waypoint>() - 1;
									for (int k = 0; k <= num6; k++)
									{
										if (activeUnit.GetNavigator().GetPlottedCourse()[k] == waypoint && k >= 0)
										{
											ActiveUnit_Navigator navigator = activeUnit.GetNavigator();
											array = navigator.GetPlottedCourse();
											ActiveUnit_Navigator.InsertWayPoint(ref array, k + 1, waypoint2);
											navigator.SetPlottedCourse(array);
											flag = true;
										}
										if (flag)
										{
											break;
										}
									}
								}
								if (flag)
								{
									break;
								}
							}
						}
					}
					clientScenario2 = Client.GetClientScenario();
					mission = Client.flightPlanEditor.m_mission;
					referenceUnit = Client.flightPlanEditor.m_Flight.GetReferenceUnit(Client.GetClientScenario());
					flight2 = Client.flightPlanEditor.m_Flight;
					array = (flight3 = Client.flightPlanEditor.m_Flight).GetFlightCourse();
					bingo = ((Strike)Client.flightPlanEditor.m_mission).Bingo;
					num2 = 0f;
					StrikePlanner.smethod_8(clientScenario2, mission, referenceUnit, flight2, ref array, bingo, ref num2, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
					flight3.SetFlightCourse(array);
					CommandFactory.GetCommandMain().GetMainForm().method_157();
					Client.b_Completed = true;
					CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
					Client.flightPlanEditor.bool_0 = false;
					Client.flightPlanEditor.method_5();
					Client.flightPlanEditor.method_6();
					Client.flightPlanEditor.bool_0 = true;
					if (Client.flightPlanTime.Visible)
					{
						Client.flightPlanTime.method_2();
					}
					return;
				}
			}
			if (!Information.IsNothing(waypoint) && !Information.IsNothing(waypoint2))
			{
				for (int j = Client.GetClientScenario().GetActiveUnitList().Count - 1; j >= 0; j += -1)
				{
					ActiveUnit activeUnit = Client.GetClientScenario().GetActiveUnitList()[j];
					if (activeUnit.IsOperating())
					{
						if ((activeUnit.IsAircraft || (activeUnit.IsGroup && ((Group)activeUnit).GetGroupType() == Group.GroupType.AirGroup)) && activeUnit.GetNavigator().HasFlightCourse() && !Information.IsNothing(activeUnit.GetSide(false)) && activeUnit.GetSide(false) == Client.GetClientSide())
						{
							int num6 = activeUnit.GetNavigator().GetPlottedCourse().Count<Waypoint>() - 1;
							for (int k = 0; k <= num6; k++)
							{
								if (activeUnit.GetNavigator().GetPlottedCourse()[k] == waypoint && k >= 0)
								{
									ActiveUnit_Navigator navigator = activeUnit.GetNavigator();
									array = navigator.GetPlottedCourse();
									ActiveUnit_Navigator.InsertWayPoint(ref array, k + 1, waypoint2);
									navigator.SetPlottedCourse(array);
									flag = true;
								}
								if (flag)
								{
									break;
								}
							}
						}
						if (flag)
						{
							break;
						}
					}
				}
			}
			clientScenario2 = Client.GetClientScenario();
			mission = Client.flightPlanEditor.m_mission;
			referenceUnit = Client.flightPlanEditor.m_Flight.GetReferenceUnit(Client.GetClientScenario());
			flight2 = Client.flightPlanEditor.m_Flight;
			array = (flight3 = Client.flightPlanEditor.m_Flight).GetFlightCourse();
			bingo = ((Strike)Client.flightPlanEditor.m_mission).Bingo;
			num2 = 0f;
			StrikePlanner.smethod_8(clientScenario2, mission, referenceUnit, flight2, ref array, bingo, ref num2, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
			flight3.SetFlightCourse(array);
			CommandFactory.GetCommandMain().GetMainForm().method_157();
			Client.b_Completed = true;
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			Client.flightPlanEditor.bool_0 = false;
			Client.flightPlanEditor.method_5();
			Client.flightPlanEditor.method_6();
			Client.flightPlanEditor.bool_0 = true;
			if (Client.flightPlanTime.Visible)
			{
				Client.flightPlanTime.method_2();
				return;
			}
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x000FA7C0 File Offset: 0x000F89C0
		private void Button_DeleteWaypoint_Click(object sender, EventArgs e)
		{
			int num = this.vmethod_0().Rows.Count - 1;
			float num2 = 0f;
			Waypoint[] flightCourse = null;
			Mission.Flight flight2;
			Scenario clientScenario2;
			Mission mission2;
			ActiveUnit referenceUnit;
			Mission.Flight flight3;
			Mission.Enum60 bingo;
			for (int i = 0; i <= num; i++)
			{
				DataGridViewRow dataGridViewRow = this.vmethod_0().Rows[i];
				checked
				{
					if (dataGridViewRow.Selected)
					{
						Waypoint waypoint = (Waypoint)dataGridViewRow.Tag;
						if (this.enum70_0 != Mission.Flight._FlightRole.const_1)
						{
							waypoint = Client.flightPlanEditor.m_Flight.GetFlightCourse()[i];
						}
						if (!Information.IsNothing(waypoint))
						{
							ActiveUnit[] activeUnitArray = Client.GetClientSide().ActiveUnitArray;
							for (int j = 0; j < activeUnitArray.Length; j++)
							{
								ActiveUnit activeUnit = activeUnitArray[j];
								if (activeUnit.GetNavigator().HasPlottedCourse())
								{
									if (activeUnit.GetNavigator().GetPlottedCourse().Contains(waypoint))
									{
										activeUnit.GetNavigator().RemoveWaypoint(waypoint, true);
									}
									else if (!Information.IsNothing(waypoint.WP_LeadElementWingman) && activeUnit.GetNavigator().GetPlottedCourse().Contains(waypoint.WP_LeadElementWingman))
									{
										activeUnit.GetNavigator().RemoveWaypoint(waypoint.WP_LeadElementWingman, false);
									}
									else if (!Information.IsNothing(waypoint.WP_SecondElement) && activeUnit.GetNavigator().GetPlottedCourse().Contains(waypoint.WP_SecondElement))
									{
										activeUnit.GetNavigator().RemoveWaypoint(waypoint.WP_SecondElement, false);
									}
									else if (!Information.IsNothing(waypoint.WP_SecondElementWingman) && activeUnit.GetNavigator().GetPlottedCourse().Contains(waypoint.WP_SecondElementWingman))
									{
										activeUnit.GetNavigator().RemoveWaypoint(waypoint.WP_SecondElementWingman, false);
									}
									else if (!Information.IsNothing(waypoint.WP_ThirdElement) && activeUnit.GetNavigator().GetPlottedCourse().Contains(waypoint.WP_ThirdElement))
									{
										activeUnit.GetNavigator().RemoveWaypoint(waypoint.WP_ThirdElement, false);
									}
									else if (!Information.IsNothing(waypoint.WP_ThirdElementWingman) && activeUnit.GetNavigator().GetPlottedCourse().Contains(waypoint.WP_ThirdElementWingman))
									{
										activeUnit.GetNavigator().RemoveWaypoint(waypoint.WP_ThirdElementWingman, false);
									}
								}
							}
						}
						Scenario clientScenario = Client.GetClientScenario();
						Mission mission = Client.flightPlanEditor.m_mission;
						Mission.Flight flight = Client.flightPlanEditor.m_Flight;
						flightCourse = (flight2 = Client.flightPlanEditor.m_Flight).GetFlightCourse();
						ActiveUnit_Navigator.smethod_2(clientScenario, mission, flight, ref flightCourse, waypoint);
						flight2.SetFlightCourse(flightCourse);
						clientScenario2 = Client.GetClientScenario();
						mission2 = Client.flightPlanEditor.m_mission;
						referenceUnit = Client.flightPlanEditor.m_Flight.GetReferenceUnit(Client.GetClientScenario());
						flight3 = Client.flightPlanEditor.m_Flight;
						flightCourse = (flight2 = Client.flightPlanEditor.m_Flight).GetFlightCourse();
						bingo = ((Strike)Client.flightPlanEditor.m_mission).Bingo;
						num2 = 0f;
						StrikePlanner.smethod_8(clientScenario2, mission2, referenceUnit, flight3, ref flightCourse, bingo, ref num2, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
						flight2.SetFlightCourse(flightCourse);
						CommandFactory.GetCommandMain().GetMainForm().method_157();
						Client.b_Completed = true;
						CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
						Client.flightPlanEditor.bool_0 = false;
						Client.flightPlanEditor.method_5();
						Client.flightPlanEditor.method_6();
						Client.flightPlanEditor.bool_0 = true;
						if (Client.flightPlanTime.Visible)
						{
							Client.flightPlanTime.method_2();
						}
						return;
					}
				}
			}
			clientScenario2 = Client.GetClientScenario();
			mission2 = Client.flightPlanEditor.m_mission;
			referenceUnit = Client.flightPlanEditor.m_Flight.GetReferenceUnit(Client.GetClientScenario());
			flight3 = Client.flightPlanEditor.m_Flight;
			flightCourse = (flight2 = Client.flightPlanEditor.m_Flight).GetFlightCourse();
			bingo = ((Strike)Client.flightPlanEditor.m_mission).Bingo;
			num2 = 0f;
			StrikePlanner.smethod_8(clientScenario2, mission2, referenceUnit, flight3, ref flightCourse, bingo, ref num2, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
			flight2.SetFlightCourse(flightCourse);
			CommandFactory.GetCommandMain().GetMainForm().method_157();
			Client.b_Completed = true;
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			Client.flightPlanEditor.bool_0 = false;
			Client.flightPlanEditor.method_5();
			Client.flightPlanEditor.method_6();
			Client.flightPlanEditor.bool_0 = true;
			if (Client.flightPlanTime.Visible)
			{
				Client.flightPlanTime.method_2();
				return;
			}
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x00016941 File Offset: 0x00014B41
		private void Button_EditTime_Click(object sender, EventArgs e)
		{
			Client.flightPlanTime.method_2();
			Client.flightPlanTime.Show();
			Client.flightPlanTime.BringToFront();
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x000FACB0 File Offset: 0x000F8EB0
		private void Button_EditSpeedAltitude_Click(object sender, EventArgs e)
		{
			int num = this.vmethod_0().Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				DataGridViewRow dataGridViewRow = this.vmethod_0().Rows[i];
				if (dataGridViewRow.Selected)
				{
					Waypoint waypoint_ = (Waypoint)dataGridViewRow.Tag;
					CommandFactory.GetCommandMain().GetSpeedAlt().waypoint_0 = waypoint_;
					CommandFactory.GetCommandMain().GetSpeedAlt().HookedUnit = null;
					CommandFactory.GetCommandMain().GetSpeedAlt().m_Flight = Client.flightPlanEditor.m_Flight;
					CommandFactory.GetCommandMain().GetSpeedAlt().m_Mission = Client.flightPlanEditor.m_mission;
					CommandFactory.GetCommandMain().GetSpeedAlt().Show();
					return;
				}
			}
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x000FAD70 File Offset: 0x000F8F70
		private void Button_EditDoctrine_Click(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count > 0)
			{
				Waypoint waypoint = (Waypoint)this.vmethod_0().SelectedRows[0].Tag;
				if (!Information.IsNothing(waypoint))
				{
					MainForm mainForm = CommandFactory.GetCommandMain().GetMainForm();
					Subject class137_ = waypoint;
					ReadOnlyCollection<Unit> readOnlyCollection = null;
					Collection<ActiveUnit> collection = null;
					mainForm.method_254(class137_, ref readOnlyCollection, ref collection, false);
				}
			}
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void Button_EditAAR_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x000FADD8 File Offset: 0x000F8FD8
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count > 0)
			{
				Waypoint waypoint = (Waypoint)this.vmethod_0().SelectedRows[0].Tag;
				if (!Information.IsNothing(waypoint))
				{
					DoctrineForm doctrineForm = new DoctrineForm();
					doctrineForm.subject = waypoint;
					doctrineForm.bool_5 = false;
					doctrineForm.Show();
					doctrineForm.vmethod_0().SelectedIndex = 1;
				}
			}
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x000FAE48 File Offset: 0x000F9048
		private void method_8(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex == 0 && e.ColumnIndex == this.vmethod_0().Columns["Time_Zulu"].Index)
			{
				Rectangle cellBounds = e.CellBounds;
				cellBounds.Y = (int)Math.Round((double)cellBounds.Y + (double)e.CellBounds.Height / 2.0);
				cellBounds.Height = (int)Math.Round((double)e.CellBounds.Height / 2.0);
				e.PaintBackground(cellBounds, true);
				e.PaintContent(cellBounds);
			}
			else if (e.RowIndex == 0 && this.vmethod_0().Columns["DesiredSpeed"].Index != 0)
			{
				Rectangle cellBounds2 = e.CellBounds;
				cellBounds2.Y = (int)Math.Round((double)cellBounds2.Y + (double)e.CellBounds.Height / 2.0);
				cellBounds2.Height = (int)Math.Round((double)e.CellBounds.Height / 2.0);
				e.PaintBackground(cellBounds2, true);
				e.PaintContent(cellBounds2);
			}
			else if (e.RowIndex == 0)
			{
				bool arg_15A_0 = e.ColumnIndex == 2 | e.ColumnIndex == 3;
			}
			if (this.vmethod_0().Columns["Time_Local"].Index == e.ColumnIndex && e.RowIndex >= 0)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
				if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == e.RowIndex)
				{
					ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.SelectionBackColor, 1, ButtonBorderStyle.Solid, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None);
				}
				else
				{
					ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None);
				}
				Rectangle cellBounds3 = e.CellBounds;
				int width = this.vmethod_0().GetCellDisplayRectangle(this.vmethod_0().Columns["TimeFixedImg"].Index, e.RowIndex, true).Width;
				cellBounds3.Width += width;
				ControlPaint.DrawBorder(e.Graphics, cellBounds3, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, Color.Red, 0, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
				e.Handled = true;
			}
			else if (this.vmethod_0().Columns["DesiredSpeed"].Index == e.ColumnIndex && e.RowIndex >= 0)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
				if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == e.RowIndex)
				{
					ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.SelectionBackColor, 1, ButtonBorderStyle.Solid, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None);
				}
				else
				{
					ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None);
				}
				Rectangle cellBounds4 = e.CellBounds;
				int width2 = this.vmethod_0().GetCellDisplayRectangle(this.vmethod_0().Columns["SpeedFixedImg"].Index, e.RowIndex, true).Width;
				cellBounds4.Width += width2;
				ControlPaint.DrawBorder(e.Graphics, cellBounds4, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, Color.Red, 0, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
				e.Handled = true;
			}
			else if (this.vmethod_0().Columns["Time_Local"].Index == e.ColumnIndex && e.RowIndex == -1)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
				ControlPaint.DrawBorder(e.Graphics, e.CellBounds, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, e.CellStyle.BackColor, 1, ButtonBorderStyle.None);
				Rectangle cellBounds5 = e.CellBounds;
				cellBounds5.Width++;
				ControlPaint.DrawBorder(e.Graphics, cellBounds5, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
				cellBounds5.Y++;
				cellBounds5.Height -= 2;
				ControlPaint.DrawBorder(e.Graphics, cellBounds5, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 2, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.Solid);
				e.Handled = true;
			}
			else if (this.vmethod_0().Columns["DesiredSpeed"].Index == e.ColumnIndex && e.RowIndex == -1)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
				ControlPaint.DrawBorder(e.Graphics, e.CellBounds, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, e.CellStyle.BackColor, 1, ButtonBorderStyle.None);
				Rectangle cellBounds6 = e.CellBounds;
				cellBounds6.Width++;
				ControlPaint.DrawBorder(e.Graphics, cellBounds6, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
				cellBounds6.Y++;
				cellBounds6.Height -= 2;
				ControlPaint.DrawBorder(e.Graphics, cellBounds6, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 2, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.Solid);
				e.Handled = true;
			}
			else if (this.vmethod_0().Columns["TimeFixedImg"].Index == e.ColumnIndex && e.RowIndex == -1)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
				ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.None);
				Rectangle cellBounds7 = e.CellBounds;
				cellBounds7.Width++;
				ControlPaint.DrawBorder(e.Graphics, cellBounds7, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
				cellBounds7.Height -= 2;
				cellBounds7.Y++;
				ControlPaint.DrawBorder(e.Graphics, cellBounds7, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 2, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.Solid);
				e.Handled = true;
			}
			else if (this.vmethod_0().Columns["SpeedFixedImg"].Index == e.ColumnIndex && e.RowIndex == -1)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
				ControlPaint.DrawBorder(e.Graphics, e.CellBounds, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.Solid, e.CellStyle.BackColor, 1, ButtonBorderStyle.None, this.vmethod_0().DefaultCellStyle.BackColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.None);
				Rectangle cellBounds8 = e.CellBounds;
				cellBounds8.Width++;
				ControlPaint.DrawBorder(e.Graphics, cellBounds8, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, this.vmethod_0().GridColor, 1, ButtonBorderStyle.Solid);
				cellBounds8.Y++;
				cellBounds8.Height -= 2;
				ControlPaint.DrawBorder(e.Graphics, cellBounds8, this.vmethod_0().GridColor, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 2, ButtonBorderStyle.Solid, Color.Red, 1, ButtonBorderStyle.None, e.CellStyle.BackColor, 1, ButtonBorderStyle.Solid);
				e.Handled = true;
			}
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x000FB808 File Offset: 0x000F9A08
		private void method_9(object sender, DataGridViewColumnEventArgs e)
		{
			Rectangle displayRectangle = this.vmethod_0().DisplayRectangle;
			this.vmethod_0().Invalidate(displayRectangle);
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_10(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x000FB808 File Offset: 0x000F9A08
		private void method_11(object sender, ScrollEventArgs e)
		{
			Rectangle displayRectangle = this.vmethod_0().DisplayRectangle;
			this.vmethod_0().Invalidate(displayRectangle);
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_12(object sender, EventArgs e)
		{
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void method_13(object sender, EventArgs e)
		{
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x00016961 File Offset: 0x00014B61
		private void method_14(object sender, EventArgs e)
		{
			if (Client.flightPlanEditor.bool_0)
			{
				this.method_15();
			}
			this.vmethod_0().Invalidate();
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x000FB830 File Offset: 0x000F9A30
		public void method_15()
		{
			Image value = Image.FromFile(Application.StartupPath + "\\symbols\\menu\\Locked_16.png");
			Image value2 = Image.FromFile(Application.StartupPath + "\\symbols\\menu\\Locked_Highlighted_16.png");
			Image value3 = Image.FromFile(Application.StartupPath + "\\symbols\\menu\\Unlocked_16.png");
			Image value4 = Image.FromFile(Application.StartupPath + "\\symbols\\menu\\Unlocked_Highlighted_16.png");
			Image value5 = Image.FromFile(Application.StartupPath + "\\symbols\\menu\\NotConfigured_16.png");
			Image value6 = Image.FromFile(Application.StartupPath + "\\symbols\\menu\\NotConfigured_Highlighted_16.png");
			Image value7 = Image.FromFile(Application.StartupPath + "\\symbols\\menu\\NotLockable_16.png");
			Image value8 = Image.FromFile(Application.StartupPath + "\\symbols\\menu\\NotLockable_Highlighted_16.png");
			IEnumerator enumerator = ((IEnumerable)this.vmethod_0().Rows).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
					if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["TimeFixed"].Value, 1, false))
					{
						if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == dataGridViewRow.Index)
						{
							dataGridViewRow.Cells["TimeFixedImg"].Value = value2;
						}
						else
						{
							dataGridViewRow.Cells["TimeFixedImg"].Value = value;
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["TimeFixed"].Value, 0, false))
					{
						if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == dataGridViewRow.Index)
						{
							dataGridViewRow.Cells["TimeFixedImg"].Value = value4;
						}
						else
						{
							dataGridViewRow.Cells["TimeFixedImg"].Value = value3;
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["TimeFixed"].Value, 2, false))
					{
						if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == dataGridViewRow.Index)
						{
							dataGridViewRow.Cells["TimeFixedImg"].Value = value8;
						}
						else
						{
							dataGridViewRow.Cells["TimeFixedImg"].Value = value7;
						}
					}
					else if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == dataGridViewRow.Index)
					{
						dataGridViewRow.Cells["TimeFixedImg"].Value = value6;
					}
					else
					{
						dataGridViewRow.Cells["TimeFixedImg"].Value = value5;
					}
					if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["SpeedFixed"].Value, 1, false))
					{
						if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == dataGridViewRow.Index)
						{
							dataGridViewRow.Cells["SpeedFixedImg"].Value = value2;
						}
						else
						{
							dataGridViewRow.Cells["SpeedFixedImg"].Value = value;
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["SpeedFixed"].Value, 0, false))
					{
						if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == dataGridViewRow.Index)
						{
							dataGridViewRow.Cells["SpeedFixedImg"].Value = value4;
						}
						else
						{
							dataGridViewRow.Cells["SpeedFixedImg"].Value = value3;
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["SpeedFixed"].Value, 2, false))
					{
						if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == dataGridViewRow.Index)
						{
							dataGridViewRow.Cells["SpeedFixedImg"].Value = value8;
						}
						else
						{
							dataGridViewRow.Cells["SpeedFixedImg"].Value = value7;
						}
					}
					else if (this.vmethod_0().SelectedRows.Count > 0 && this.vmethod_0().SelectedRows[0].Index == dataGridViewRow.Index)
					{
						dataGridViewRow.Cells["SpeedFixedImg"].Value = value6;
					}
					else
					{
						dataGridViewRow.Cells["SpeedFixedImg"].Value = value5;
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

		// Token: 0x06002946 RID: 10566 RVA: 0x000FBDC4 File Offset: 0x000F9FC4
		private void method_16(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				bool flag = false;
				DataGridViewRow dataGridViewRow = null;
				IEnumerator enumerator = ((IEnumerable)this.vmethod_0().Rows).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)enumerator.Current;
						if (dataGridViewRow2.Selected)
						{
							dataGridViewRow = dataGridViewRow2;
							DataGridViewColumn dataGridViewColumn = this.vmethod_0().Columns[e.ColumnIndex];
							if (Operators.CompareString(dataGridViewColumn.Name, "Type", false) != 0)
							{
								if (Operators.CompareString(dataGridViewColumn.Name, "Formation", false) != 0)
								{
									if (Operators.CompareString(dataGridViewColumn.Name, "AARUsage", false) == 0)
									{
										Waypoint waypoint = (Waypoint)dataGridViewRow2.Tag;
										DataTable dataSource = new DataTable();
										if (!Information.IsNothing(waypoint))
										{
											waypoint.m_Doctrine.method_52(ref dataSource, Client.GetClientScenario(), null);
											DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow2.Index];
											dataGridViewComboBoxCell.DataSource = dataSource;
											dataGridViewComboBoxCell.DisplayMember = "Description";
											dataGridViewComboBoxCell.ValueMember = "ID";
											dataGridViewComboBoxCell.DropDownWidth = 500;
											this.vmethod_0().BeginEdit(true);
											if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_46().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
											{
												((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
												break;
											}
											break;
										}
									}
									if (Operators.CompareString(dataGridViewColumn.Name, "AARSelection", false) == 0)
									{
										Waypoint waypoint2 = (Waypoint)dataGridViewRow2.Tag;
										DataTable dataSource2 = new DataTable();
										if (!Information.IsNothing(waypoint2))
										{
											waypoint2.m_Doctrine.method_53(ref dataSource2, Client.GetClientScenario(), null);
											DataGridViewComboBoxCell dataGridViewComboBoxCell2 = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow2.Index];
											dataGridViewComboBoxCell2.DataSource = dataSource2;
											dataGridViewComboBoxCell2.DisplayMember = "Description";
											dataGridViewComboBoxCell2.ValueMember = "ID";
											dataGridViewComboBoxCell2.DropDownWidth = 500;
											this.vmethod_0().BeginEdit(true);
											if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_46().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
											{
												((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
												break;
											}
											break;
										}
									}
									if (Operators.CompareString(dataGridViewColumn.Name, "TurnRate", false) != 0)
									{
										if (Operators.CompareString(dataGridViewColumn.Name, "TimeFixedImg", false) == 0)
										{
											Waypoint waypoint3 = (Waypoint)dataGridViewRow2.Tag;
											if (waypoint3.TimeFixed == Waypoint.Enum52.const_1)
											{
												waypoint3.TimeFixed = Waypoint.Enum52.const_0;
												dataGridViewRow2.Cells["TimeFixed"].Value = waypoint3.TimeFixed;
											}
											else if (waypoint3.TimeFixed == Waypoint.Enum52.const_0)
											{
												waypoint3.TimeFixed = Waypoint.Enum52.const_1;
												dataGridViewRow2.Cells["TimeFixed"].Value = waypoint3.TimeFixed;
											}
											flag = true;
										}
										if (Operators.CompareString(dataGridViewColumn.Name, "SpeedFixedImg", false) != 0)
										{
											continue;
										}
										Waypoint waypoint4 = (Waypoint)dataGridViewRow2.Tag;
										if (waypoint4.SpeedFixed == Waypoint.Enum52.const_1)
										{
											if (waypoint4.waypointType == Waypoint.WaypointType.TakeOff || waypoint4.waypointType == Waypoint.WaypointType.Land)
											{
												waypoint4.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Loiter);
												waypoint4.DesiredSpeed = null;
												waypoint4.SetDSO(null);
												waypoint4.SpeedFixed = Waypoint.Enum52.const_1;
											}
											else
											{
												waypoint4.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
												waypoint4.DesiredSpeed = null;
												waypoint4.SetDSO(null);
												waypoint4.SpeedFixed = Waypoint.Enum52.const_0;
											}
											flag = true;
											continue;
										}
										if (waypoint4.SpeedFixed == Waypoint.Enum52.const_0 && (!Information.IsNothing(waypoint4.DesiredSpeed) || waypoint4.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None))
										{
											waypoint4.SpeedFixed = Waypoint.Enum52.const_1;
											flag = true;
											continue;
										}
										continue;
									}
									else
									{
										DataTable dataSource3 = new DataTable();
										DataGridViewComboBoxCell dataGridViewComboBoxCell3 = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow2.Index];
										Waypoint.smethod_17(ref dataSource3);
										dataGridViewComboBoxCell3.DataSource = dataSource3;
										dataGridViewComboBoxCell3.DisplayMember = "Description";
										dataGridViewComboBoxCell3.ValueMember = "ID";
										dataGridViewComboBoxCell3.DropDownWidth = 500;
										this.vmethod_0().BeginEdit(true);
										if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_46().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
										{
											((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
										}
									}
								}
								else
								{
									DataTable dataSource4 = new DataTable();
									DataGridViewComboBoxCell dataGridViewComboBoxCell4 = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow2.Index];
									Waypoint.smethod_16(ref dataSource4);
									dataGridViewComboBoxCell4.DataSource = dataSource4;
									dataGridViewComboBoxCell4.DisplayMember = "Description";
									dataGridViewComboBoxCell4.ValueMember = "ID";
									dataGridViewComboBoxCell4.DropDownWidth = 500;
									this.vmethod_0().BeginEdit(true);
									if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_46().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
									{
										((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
									}
								}
							}
							else
							{
								DataTable dataSource5 = new DataTable();
								DataGridViewComboBoxCell dataGridViewComboBoxCell5 = (DataGridViewComboBoxCell)this.vmethod_0()[dataGridViewColumn.Index, dataGridViewRow2.Index];
								Waypoint.smethod_12(ref dataSource5);
								dataGridViewComboBoxCell5.DataSource = dataSource5;
								dataGridViewComboBoxCell5.DisplayMember = "Description";
								dataGridViewComboBoxCell5.ValueMember = "ID";
								dataGridViewComboBoxCell5.DropDownWidth = 500;
								this.vmethod_0().BeginEdit(true);
								if (this.vmethod_0().Rows[e.RowIndex].Cells[this.vmethod_46().Name].Selected && !Information.IsNothing(this.vmethod_0().EditingControl))
								{
									((DataGridViewComboBoxEditingControl)this.vmethod_0().EditingControl).DroppedDown = true;
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
				if (!Information.IsNothing(dataGridViewRow))
				{
					this.GetButton_InsertWaypoint().Enabled = true;
					this.GetButton_DeleteWaypoint().Enabled = true;
					Waypoint waypoint5 = (Waypoint)dataGridViewRow.Tag;
					if (FlightPlanWaypoints.smethod_0(ref waypoint5, this.enum70_0).waypointType == Waypoint.WaypointType.WeaponTarget)
					{
						this.GetButton_EditTime().Enabled = false;
						this.GetButton_ClearTime().Enabled = false;
						this.GetButton_EditSpeedAltitude().Enabled = false;
						this.GetButton_EditDoctrine().Enabled = false;
						this.GetButton_EditAAR().Enabled = false;
						this.GetButton_EditSensorUsage().Enabled = false;
					}
					else
					{
						this.GetButton_EditTime().Enabled = true;
						this.GetButton_ClearTime().Enabled = true;
						this.GetButton_EditSpeedAltitude().Enabled = true;
						this.GetButton_EditDoctrine().Enabled = true;
						this.GetButton_EditAAR().Enabled = true;
						this.GetButton_EditSensorUsage().Enabled = true;
					}
				}
				else
				{
					this.GetButton_InsertWaypoint().Enabled = false;
					this.GetButton_DeleteWaypoint().Enabled = false;
					this.GetButton_EditTime().Enabled = false;
					this.GetButton_ClearTime().Enabled = false;
					this.GetButton_EditSpeedAltitude().Enabled = false;
					this.GetButton_EditDoctrine().Enabled = false;
					this.GetButton_EditAAR().Enabled = false;
					this.GetButton_EditSensorUsage().Enabled = false;
				}
				this.method_15();
				if (flag)
				{
					this.method_17();
				}
				if (Client.flightPlanTime.Visible)
				{
					Client.flightPlanTime.method_2();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200588", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x000FC698 File Offset: 0x000FA898
		public static Waypoint smethod_0(ref Waypoint waypoint_0, Mission.Flight._FlightRole enum70_1)
		{
			Waypoint waypoint;
			Waypoint result;
			if (enum70_1 == Mission.Flight._FlightRole.const_1)
			{
				waypoint = waypoint_0;
			}
			else if (waypoint_0.FlightFormation == Waypoint._FlightFormation.Spread)
			{
				waypoint = waypoint_0;
			}
			else
			{
				if (enum70_1 == Mission.Flight._FlightRole.const_2)
				{
					if (!Information.IsNothing(waypoint_0.WP_LeadElementWingman))
					{
						waypoint = waypoint_0.WP_LeadElementWingman;
						result = waypoint;
						return result;
					}
				}
				else if (enum70_1 == Mission.Flight._FlightRole.const_3)
				{
					if (!Information.IsNothing(waypoint_0.WP_SecondElement))
					{
						waypoint = waypoint_0.WP_SecondElement;
						result = waypoint;
						return result;
					}
				}
				else if (enum70_1 == Mission.Flight._FlightRole.const_4)
				{
					if (!Information.IsNothing(waypoint_0.WP_SecondElementWingman))
					{
						waypoint = waypoint_0.WP_SecondElementWingman;
						result = waypoint;
						return result;
					}
				}
				else if (enum70_1 == Mission.Flight._FlightRole.const_5)
				{
					if (!Information.IsNothing(waypoint_0.WP_ThirdElement))
					{
						waypoint = waypoint_0.WP_ThirdElement;
						result = waypoint;
						return result;
					}
				}
				else if (enum70_1 == Mission.Flight._FlightRole.const_6 && !Information.IsNothing(waypoint_0.WP_ThirdElementWingman))
				{
					waypoint = waypoint_0.WP_ThirdElementWingman;
					result = waypoint;
					return result;
				}
				waypoint = waypoint_0;
			}
			result = waypoint;
			return result;
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x000FC788 File Offset: 0x000FA988
		private void method_17()
		{
			if (!Information.IsNothing(Client.flightPlanEditor.m_Flight))
			{
				Scenario clientScenario = Client.GetClientScenario();
				Mission mission = Client.flightPlanEditor.m_mission;
				ActiveUnit referenceUnit = Client.flightPlanEditor.m_Flight.GetReferenceUnit(Client.GetClientScenario());
				Mission.Flight flight = Client.flightPlanEditor.m_Flight;
				Mission.Flight flight2;
				Waypoint[] flightCourse = (flight2 = Client.flightPlanEditor.m_Flight).GetFlightCourse();
				Mission.Enum60 bingo = ((Strike)Client.flightPlanEditor.m_mission).Bingo;
				float num = 0f;
				StrikePlanner.smethod_8(clientScenario, mission, referenceUnit, flight, ref flightCourse, bingo, ref num, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
				flight2.SetFlightCourse(flightCourse);
			}
			CommandFactory.GetCommandMain().GetMainForm().method_157();
			Client.flightPlanEditor.method_5();
			Client.flightPlanEditor.method_6();
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00016983 File Offset: 0x00014B83
		private void method_18(object sender, DataGridViewCellEventArgs e)
		{
			if (this.vmethod_0().SelectedRows.Count != 0 && Client.flightPlanEditor.bool_0)
			{
				this.method_20(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x000169B6 File Offset: 0x00014BB6
		private void method_19(object sender, EventArgs e)
		{
			Client.flightPlanEditor.bool_0 = true;
			if (this.vmethod_0().IsCurrentCellDirty)
			{
				this.vmethod_0().CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x000FC878 File Offset: 0x000FAA78
		private void method_20(object sender, DataGridViewCellEventArgs e)
		{
			Waypoint waypoint = (Waypoint)this.vmethod_0().Rows[e.RowIndex].Tag;
			if (!Information.IsNothing(waypoint))
			{
				if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["Type"].Index)
				{
					Waypoint waypoint2 = waypoint;
					DataGridViewCell dataGridViewCell = this.vmethod_0()[e.ColumnIndex, e.RowIndex];
					object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value);
					int? num = Waypoint.smethod_13(ref objectValue);
					dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(objectValue);
					waypoint2.waypointType = (Waypoint.WaypointType)num.Value;
				}
				if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["Formation"].Index)
				{
					Waypoint waypoint3 = waypoint;
					DataGridViewCell dataGridViewCell2 = this.vmethod_0()[e.ColumnIndex, e.RowIndex];
					object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value);
					int? num = Waypoint.smethod_18(ref objectValue);
					dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(objectValue);
					waypoint3.FlightFormation = (Waypoint._FlightFormation)num.Value;
				}
				if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["TurnRate"].Index)
				{
					Waypoint waypoint4 = waypoint;
					DataGridViewCell dataGridViewCell3 = this.vmethod_0()[e.ColumnIndex, e.RowIndex];
					object objectValue = RuntimeHelpers.GetObjectValue(dataGridViewCell3.Value);
					int? num = Waypoint.smethod_19(ref objectValue);
					dataGridViewCell3.Value = RuntimeHelpers.GetObjectValue(objectValue);
					waypoint4.TurnRate = (Waypoint._TurnRate)num.Value;
					if (!Information.IsNothing(Client.flightPlanEditor.m_Flight))
					{
						Scenario clientScenario = Client.GetClientScenario();
						Mission mission = Client.flightPlanEditor.m_mission;
						ActiveUnit referenceUnit = Client.flightPlanEditor.m_Flight.GetReferenceUnit(Client.GetClientScenario());
						Mission.Flight flight = Client.flightPlanEditor.m_Flight;
						Mission.Flight flight2;
						Waypoint[] flightCourse = (flight2 = Client.flightPlanEditor.m_Flight).GetFlightCourse();
						Mission.Enum60 bingo = ((Strike)Client.flightPlanEditor.m_mission).Bingo;
						float num2 = 0f;
						StrikePlanner.smethod_8(clientScenario, mission, referenceUnit, flight, ref flightCourse, bingo, ref num2, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
						flight2.SetFlightCourse(flightCourse);
					}
					CommandFactory.GetCommandMain().GetMainForm().method_157();
					Client.b_Completed = true;
					CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
				}
				if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["AARUsage"].Index)
				{
					Doctrine doctrine = waypoint.m_Doctrine;
					DataGridViewCell dataGridViewCell4;
					int num3 = Conversions.ToInteger((dataGridViewCell4 = this.vmethod_0()[e.ColumnIndex, e.RowIndex]).Value);
					Scenario clientScenario2 = Client.GetClientScenario();
					int num4 = 0;
					doctrine.method_290(ref num3, ref clientScenario2, ref num4, false, false, false);
					dataGridViewCell4.Value = num3;
					if (!Information.IsNothing(Client.flightPlanEditor.m_Flight))
					{
						Scenario clientScenario3 = Client.GetClientScenario();
						Mission mission2 = Client.flightPlanEditor.m_mission;
						ActiveUnit referenceUnit2 = Client.flightPlanEditor.m_Flight.GetReferenceUnit(Client.GetClientScenario());
						Mission.Flight flight3 = Client.flightPlanEditor.m_Flight;
						Mission.Flight flight2;
						Waypoint[] flightCourse = (flight2 = Client.flightPlanEditor.m_Flight).GetFlightCourse();
						Mission.Enum60 bingo2 = ((Strike)Client.flightPlanEditor.m_mission).Bingo;
						float num2 = 0f;
						StrikePlanner.smethod_8(clientScenario3, mission2, referenceUnit2, flight3, ref flightCourse, bingo2, ref num2, 0f, false, true, true, true, false, true, true, null, 0f, 0f, 0f, Misc.Enum102.const_0, null, false);
						flight2.SetFlightCourse(flightCourse);
					}
					CommandFactory.GetCommandMain().GetMainForm().method_157();
					Client.flightPlanEditor.method_7();
				}
				if (e.RowIndex != -1 && e.ColumnIndex == this.vmethod_0().Columns["AARSelection"].Index)
				{
					Doctrine doctrine2 = waypoint.m_Doctrine;
					DataGridViewCell dataGridViewCell4;
					int num4 = Conversions.ToInteger((dataGridViewCell4 = this.vmethod_0()[e.ColumnIndex, e.RowIndex]).Value);
					Scenario clientScenario2 = Client.GetClientScenario();
					int num3 = 0;
					doctrine2.method_292(ref num4, ref clientScenario2, ref num3, false, false, false);
					dataGridViewCell4.Value = num4;
				}
				Client.flightPlanEditor.bool_0 = false;
			}
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x000169E4 File Offset: 0x00014BE4
		private void method_21(object sender, EventArgs e)
		{
			if (Client.flightPlanEditor.bool_0)
			{
				int arg_1F_0 = this.vmethod_0().SelectedRows.Count;
			}
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x000FCD20 File Offset: 0x000FAF20
		private void method_22(object sender, EventArgs e)
		{
			if (!Information.IsNothing(Client.flightPlanEditor.m_mission) && Client.flightPlanEditor.m_mission.category == Mission.MissionCategory.Package)
			{
				Interaction.MsgBox("Flightplans in packages must always have waypoint times set!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				int num = this.vmethod_0().Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					Waypoint waypoint = (Waypoint)this.vmethod_0().Rows[i].Tag;
					if (this.enum70_0 != Mission.Flight._FlightRole.const_1)
					{
						waypoint = Client.flightPlanEditor.m_Flight.GetFlightCourse()[i];
					}
					waypoint.ArrivalTime_Zulu = null;
					waypoint.TimeFixed = Waypoint.Enum52.const_0;
					if (!Information.IsNothing(waypoint.WP_LeadElementWingman))
					{
						waypoint.WP_LeadElementWingman.ArrivalTime_Zulu = null;
						waypoint.WP_LeadElementWingman.TimeFixed = Waypoint.Enum52.const_0;
					}
					if (!Information.IsNothing(waypoint.WP_SecondElement))
					{
						waypoint.WP_SecondElement.ArrivalTime_Zulu = null;
						waypoint.WP_SecondElement.TimeFixed = Waypoint.Enum52.const_0;
					}
					if (!Information.IsNothing(waypoint.WP_SecondElementWingman))
					{
						waypoint.WP_SecondElementWingman.ArrivalTime_Zulu = null;
						waypoint.WP_SecondElementWingman.TimeFixed = Waypoint.Enum52.const_0;
					}
					if (!Information.IsNothing(waypoint.WP_ThirdElement))
					{
						waypoint.WP_ThirdElement.ArrivalTime_Zulu = null;
						waypoint.WP_ThirdElement.TimeFixed = Waypoint.Enum52.const_0;
					}
					if (!Information.IsNothing(waypoint.WP_ThirdElementWingman))
					{
						waypoint.WP_ThirdElementWingman.ArrivalTime_Zulu = null;
						waypoint.WP_ThirdElementWingman.TimeFixed = Waypoint.Enum52.const_0;
					}
				}
				this.method_15();
				this.method_17();
				Client.b_Completed = true;
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
		}

		// Token: 0x04001397 RID: 5015
		private IContainer icontainer_0;

		// Token: 0x04001398 RID: 5016
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04001399 RID: 5017
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x0400139A RID: 5018
		[CompilerGenerated]
		private Button Button_DeleteWaypoint;

		// Token: 0x0400139B RID: 5019
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x0400139C RID: 5020
		[CompilerGenerated]
		private Button Button_ChangeAssignedAircraft;

		// Token: 0x0400139D RID: 5021
		[CompilerGenerated]
		private Button Button_EditTime;

		// Token: 0x0400139E RID: 5022
		[CompilerGenerated]
		private Button Button_EditSpeedAltitude;

		// Token: 0x0400139F RID: 5023
		[CompilerGenerated]
		private Button Button_EditDoctrine;

		// Token: 0x040013A0 RID: 5024
		[CompilerGenerated]
		private Button Button_EditAAR;

		// Token: 0x040013A1 RID: 5025
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x040013A2 RID: 5026
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x040013A3 RID: 5027
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x040013A4 RID: 5028
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x040013A5 RID: 5029
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x040013A6 RID: 5030
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x040013A7 RID: 5031
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		// Token: 0x040013A8 RID: 5032
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		// Token: 0x040013A9 RID: 5033
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		// Token: 0x040013AA RID: 5034
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		// Token: 0x040013AB RID: 5035
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		// Token: 0x040013AC RID: 5036
		[CompilerGenerated]
		private Button button_7;

		// Token: 0x040013AD RID: 5037
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		// Token: 0x040013AE RID: 5038
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		// Token: 0x040013AF RID: 5039
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

		// Token: 0x040013B0 RID: 5040
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		// Token: 0x040013B1 RID: 5041
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		// Token: 0x040013B2 RID: 5042
		[CompilerGenerated]
		private DataGridViewImageColumn dataGridViewImageColumn_0;

		// Token: 0x040013B3 RID: 5043
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		// Token: 0x040013B4 RID: 5044
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		// Token: 0x040013B5 RID: 5045
		[CompilerGenerated]
		private DataGridViewImageColumn dataGridViewImageColumn_1;

		// Token: 0x040013B6 RID: 5046
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		// Token: 0x040013B7 RID: 5047
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		// Token: 0x040013B8 RID: 5048
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		// Token: 0x040013B9 RID: 5049
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		// Token: 0x040013BA RID: 5050
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		// Token: 0x040013BB RID: 5051
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

		// Token: 0x040013BC RID: 5052
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

		// Token: 0x040013BD RID: 5053
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

		// Token: 0x040013BE RID: 5054
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

		// Token: 0x040013BF RID: 5055
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;

		// Token: 0x040013C0 RID: 5056
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;

		// Token: 0x040013C1 RID: 5057
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_3;

		// Token: 0x040013C2 RID: 5058
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

		// Token: 0x040013C3 RID: 5059
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

		// Token: 0x040013C4 RID: 5060
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

		// Token: 0x040013C5 RID: 5061
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

		// Token: 0x040013C6 RID: 5062
		[CompilerGenerated]
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4;

		// Token: 0x040013C7 RID: 5063
		[CompilerGenerated]
		private Button button_8;

		// Token: 0x040013C8 RID: 5064
		public Mission.Flight._FlightRole enum70_0;
	}
}

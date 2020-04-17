namespace ns33
{
	// Token: 0x02000A2B RID: 2603
	
	public sealed partial class FlightPlans : global::ns33.CommandForm
	{
		// Token: 0x0600519A RID: 20890 RVA: 0x00214DD4 File Offset: 0x00212FD4
		[global::System.Diagnostics.DebuggerNonUserCode]
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

		// Token: 0x0600519B RID: 20891 RVA: 0x00214E18 File Offset: 0x00213018
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.SetButton_DeleteFlightPlan(new global::System.Windows.Forms.Button());
			this.SetButton_EditAssignedAircraft(new global::System.Windows.Forms.Button());
			this.SetButton_FlightPlanEditor(new global::System.Windows.Forms.Button());
			this.SetButton_CreateFlightPlan(new global::System.Windows.Forms.Button());
			this.SetComboBox_AirborneFlightPlanVisibility(new global::System.Windows.Forms.ComboBox());
			this.SetComboBox_PlannedFlightPlanVisibility(new global::System.Windows.Forms.ComboBox());
			this.vmethod_69(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_1(new global::System.Windows.Forms.DataGridView());
			this.vmethod_15(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_17(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_19(new global::System.Windows.Forms.DataGridViewComboBoxColumn());
			this.vmethod_21(new global::System.Windows.Forms.DataGridViewComboBoxColumn());
			this.vmethod_23(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_25(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_27(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_29(new global::System.Windows.Forms.DataGridViewComboBoxColumn());
			this.vmethod_31(new global::System.Windows.Forms.DataGridViewComboBoxColumn());
			this.vmethod_33(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_35(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_37(new global::System.Windows.Forms.DataGridViewCheckBoxColumn());
			this.vmethod_39(new global::System.Windows.Forms.DataGridViewCheckBoxColumn());
			this.vmethod_41(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_43(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_45(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_47(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_49(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_51(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_53(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_55(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_57(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_59(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_61(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_63(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_65(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_67(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			((global::System.ComponentModel.ISupportInitialize)this.GetDGV_FlightPlans()).BeginInit();
			base.SuspendLayout();
			this.GetButton_DeleteFlightPlan().Location = new global::System.Drawing.Point(164, 651);
			this.GetButton_DeleteFlightPlan().Name = "Button_DeleteFlightPlan";
			this.GetButton_DeleteFlightPlan().Size = new global::System.Drawing.Size(146, 28);
			this.GetButton_DeleteFlightPlan().TabIndex = 15;
			this.GetButton_DeleteFlightPlan().Text = "删除飞行计划";
			this.GetButton_DeleteFlightPlan().UseVisualStyleBackColor = true;
			this.GetButton_EditAssignedAircraft().Location = new global::System.Drawing.Point(464, 651);
			this.GetButton_EditAssignedAircraft().Name = "Button_EditAssignedAircraft";
			this.GetButton_EditAssignedAircraft().Size = new global::System.Drawing.Size(146, 28);
			this.GetButton_EditAssignedAircraft().TabIndex = 14;
			this.GetButton_EditAssignedAircraft().Text = "编辑分配的飞机";
			this.GetButton_EditAssignedAircraft().UseVisualStyleBackColor = true;
			this.GetButton_FlightPlanEditor().Location = new global::System.Drawing.Point(312, 651);
			this.GetButton_FlightPlanEditor().Name = "Button_FlightPlanEditor";
			this.GetButton_FlightPlanEditor().Size = new global::System.Drawing.Size(146, 28);
			this.GetButton_FlightPlanEditor().TabIndex = 13;
			this.GetButton_FlightPlanEditor().Text = "编辑飞行计划";
			this.GetButton_FlightPlanEditor().UseVisualStyleBackColor = true;
			this.GetButton_CreateFlightPlan().Location = new global::System.Drawing.Point(12, 651);
			this.GetButton_CreateFlightPlan().Name = "Button_CreateFlightPlan";
			this.GetButton_CreateFlightPlan().Size = new global::System.Drawing.Size(146, 28);
			this.GetButton_CreateFlightPlan().TabIndex = 12;
			this.GetButton_CreateFlightPlan().Text = "创建飞行计划";
			this.GetButton_CreateFlightPlan().UseVisualStyleBackColor = true;
			this.GetComboBox_AirborneFlightPlanVisibility().FormattingEnabled = true;
			this.GetComboBox_AirborneFlightPlanVisibility().Items.AddRange(new object[]
			{
				"所有单元",
				"所选单元",
				"不显示"
			});
			this.GetComboBox_AirborneFlightPlanVisibility().Location = new global::System.Drawing.Point(635, 3);
			this.GetComboBox_AirborneFlightPlanVisibility().Name = "ComboBox_AirborneFlightPlanVisibility";
			this.GetComboBox_AirborneFlightPlanVisibility().Size = new global::System.Drawing.Size(214, 21);
			this.GetComboBox_AirborneFlightPlanVisibility().TabIndex = 11;
			this.GetComboBox_PlannedFlightPlanVisibility().FormattingEnabled = true;
			this.GetComboBox_PlannedFlightPlanVisibility().Items.AddRange(new object[]
			{
				"所有",
				"所选任务（Task）池(或作战任务) ",
				"所选任务（Task）包(或作战任务)",
				"所选航线",
				"不显示"
			});
			this.GetComboBox_PlannedFlightPlanVisibility().Location = new global::System.Drawing.Point(208, 3);
			this.GetComboBox_PlannedFlightPlanVisibility().Name = "ComboBox_PlannedFlightPlanVisibility";
			this.GetComboBox_PlannedFlightPlanVisibility().Size = new global::System.Drawing.Size(214, 21);
			this.GetComboBox_PlannedFlightPlanVisibility().TabIndex = 11;
			this.vmethod_68().AutoSize = true;
			this.vmethod_68().Location = new global::System.Drawing.Point(428, 7);
			this.vmethod_68().Name = "Label2";
			this.vmethod_68().Size = new global::System.Drawing.Size(203, 13);
			this.vmethod_68().TabIndex = 10;
			this.vmethod_68().Text = "地图上显示在空的飞行计划";
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().Location = new global::System.Drawing.Point(1, 7);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new global::System.Drawing.Size(203, 13);
			this.vmethod_2().TabIndex = 10;
			this.vmethod_2().Text = "地图上显示规划的飞行计划";
			this.GetDGV_FlightPlans().AllowUserToAddRows = false;
			this.GetDGV_FlightPlans().AllowUserToDeleteRows = false;
			this.GetDGV_FlightPlans().AllowUserToResizeRows = false;
			this.GetDGV_FlightPlans().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.GetDGV_FlightPlans().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.GetDGV_FlightPlans().ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GetDGV_FlightPlans().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.GetID(),
				this.GetCallsign(),
				this.GetTask(),
				this.GetPriority(),
				this.GetStatus(),
				this.GetReferenceUnit(),
				this.GetLoadout(),
				this.GetDesiredAircraftQty(),
				this.GetMinimumAircraftQty(),
				this.GetAssignedAircraftQty(),
				this.GetReadyAircraftQty(),
				this.GetOneTime(),
				this.GetTimeBound(),
				this.GetTakeOffLocation(),
				this.GetLandingLocation(),
				this.GetAlternativeLandingLocation(),
				this.GetEarliestTaskingTime(),
				this.GetLatestTaskingTime(),
				this.GetEarliestLaunchTime(),
				this.GetLatestLaunchTime(),
				this.GetMaxReadyTime(),
				this.GetTaskPool_Name(),
				this.GetTaskPool_PreferredLoadoutName(),
				this.GetPostTaskPool_Name(),
				this.GetPostTaskPool_PreferredLoadoutName(),
				this.GetCreatedBy(),
				this.GetEditedBy()
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.GetDGV_FlightPlans().DefaultCellStyle = dataGridViewCellStyle2;
			this.GetDGV_FlightPlans().EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.GetDGV_FlightPlans().Location = new global::System.Drawing.Point(0, 27);
			this.GetDGV_FlightPlans().MultiSelect = false;
			this.GetDGV_FlightPlans().Name = "DGV_FlightPlans";
			this.GetDGV_FlightPlans().RowHeadersVisible = false;
			this.GetDGV_FlightPlans().RowHeadersWidth = 10;
			this.GetDGV_FlightPlans().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GetDGV_FlightPlans().Size = new global::System.Drawing.Size(1008, 414);
			this.GetDGV_FlightPlans().TabIndex = 9;
			this.GetID().DataPropertyName = "ID";
			this.GetID().HeaderText = "ID";
			this.GetID().Name = "ID";
			this.GetID().Visible = false;
			this.GetCallsign().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.GetCallsign().DataPropertyName = "Callsign";
			this.GetCallsign().HeaderText = "呼号";
			this.GetCallsign().Name = "Callsign";
			this.GetCallsign().Width = 66;
			this.GetTask().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.GetTask().DataPropertyName = "Task";
			this.GetTask().FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.GetTask().HeaderText = "任务";
			this.GetTask().Name = "Task";
			this.GetTask().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.GetTask().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.GetTask().Width = 54;
			this.GetPriority().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.GetPriority().DataPropertyName = "Priority";
			this.GetPriority().FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.GetPriority().HeaderText = "优先级";
			this.GetPriority().Name = "Priority";
			this.GetPriority().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.GetPriority().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.GetPriority().Width = 61;
			this.GetStatus().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.GetStatus().DataPropertyName = "Status";
			this.GetStatus().HeaderText = "状态";
			this.GetStatus().Name = "Status";
			this.GetStatus().Width = 60;
			this.GetReferenceUnit().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.GetReferenceUnit().DataPropertyName = "ReferenceUnit";
			this.GetReferenceUnit().HeaderText = "参考单元";
			this.GetReferenceUnit().Name = "ReferenceUnit";
			this.GetReferenceUnit().ReadOnly = true;
			this.GetReferenceUnit().Width = 99;
			this.GetLoadout().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.GetLoadout().DataPropertyName = "Loadout";
			this.GetLoadout().HeaderText = "挂载";
			this.GetLoadout().Name = "Loadout";
			this.GetLoadout().Width = 69;
			this.GetDesiredAircraftQty().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.GetDesiredAircraftQty().DataPropertyName = "DesiredAircraftQty";
			this.GetDesiredAircraftQty().FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.GetDesiredAircraftQty().HeaderText = "期望飞机数";
			this.GetDesiredAircraftQty().Name = "DesiredAircraftQty";
			this.GetDesiredAircraftQty().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.GetDesiredAircraftQty().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.GetDesiredAircraftQty().Width = 115;
			this.GetMinimumAircraftQty().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.GetMinimumAircraftQty().DataPropertyName = "MinimumAircraftQty";
			this.GetMinimumAircraftQty().FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.GetMinimumAircraftQty().HeaderText = "最少飞机数";
			this.GetMinimumAircraftQty().Name = "MinimumAircraftQty";
			this.GetMinimumAircraftQty().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.GetMinimumAircraftQty().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.GetMinimumAircraftQty().Width = 120;
			this.GetAssignedAircraftQty().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.GetAssignedAircraftQty().DataPropertyName = "AssignedAircraftQty";
			this.GetAssignedAircraftQty().HeaderText = "分配飞机数";
			this.GetAssignedAircraftQty().Name = "AssignedAircraftQty";
			this.GetAssignedAircraftQty().ReadOnly = true;
			this.GetAssignedAircraftQty().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.GetAssignedAircraftQty().Width = 122;
			this.GetReadyAircraftQty().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.GetReadyAircraftQty().DataPropertyName = "ReadyAircraftQty";
			this.GetReadyAircraftQty().HeaderText = "就绪飞机数";
			this.GetReadyAircraftQty().Name = "ReadyAircraftQty";
			this.GetReadyAircraftQty().ReadOnly = true;
			this.GetReadyAircraftQty().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.GetReadyAircraftQty().Width = 110;
			this.GetOneTime().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.GetOneTime().DataPropertyName = "OneTime";
			this.GetOneTime().HeaderText = "一次性";
			this.GetOneTime().Name = "OneTime";
			this.GetOneTime().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.GetOneTime().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.GetOneTime().Width = 73;
			this.GetTimeBound().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.GetTimeBound().DataPropertyName = "TimeBound";
			this.GetTimeBound().HeaderText = "时限";
			this.GetTimeBound().Name = "TimeBound";
			this.GetTimeBound().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.GetTimeBound().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.GetTimeBound().Width = 84;
			this.GetTakeOffLocation().DataPropertyName = "TakeOffLocation";
			this.GetTakeOffLocation().HeaderText = "起飞位置";
			this.GetTakeOffLocation().Name = "TakeOffLocation";
			this.GetLandingLocation().DataPropertyName = "LandingLocation";
			this.GetLandingLocation().HeaderText = "降落位置";
			this.GetLandingLocation().Name = "LandingLocation";
			this.GetAlternativeLandingLocation().DataPropertyName = "AlternativeLandingLocation";
			this.GetAlternativeLandingLocation().HeaderText = "备用降落点";
			this.GetAlternativeLandingLocation().Name = "AlternativeLandingLocation";
			this.GetEarliestTaskingTime().DataPropertyName = "EarliestTaskingTime";
			this.GetEarliestTaskingTime().HeaderText = "最早任务执行时间";
			this.GetEarliestTaskingTime().Name = "EarliestTaskingTime";
			this.GetLatestTaskingTime().DataPropertyName = "LatestTaskingTime";
			this.GetLatestTaskingTime().HeaderText = "最迟任务执行时间";
			this.GetLatestTaskingTime().Name = "LatestTaskingTime";
			this.GetEarliestLaunchTime().DataPropertyName = "EarliestLaunchTime";
			this.GetEarliestLaunchTime().HeaderText = "最早出动时间";
			this.GetEarliestLaunchTime().Name = "EarliestLaunchTime";
			this.GetLatestLaunchTime().DataPropertyName = "LatestLaunchTime";
			this.GetLatestLaunchTime().HeaderText = "最迟出动时间";
			this.GetLatestLaunchTime().Name = "LatestLaunchTime";
			this.GetMaxReadyTime().DataPropertyName = "MaxReadyTime";
			this.GetMaxReadyTime().HeaderText = "最长准备时间";
			this.GetMaxReadyTime().Name = "MaxReadyTime";
			this.GetTaskPool_Name().DataPropertyName = "TaskPool_Name";
			this.GetTaskPool_Name().HeaderText = "任务（Task）池名称";
			this.GetTaskPool_Name().Name = "TaskPool_Name";
			this.GetTaskPool_PreferredLoadoutName().DataPropertyName = "TaskPool_PreferredLoadoutName";
			this.GetTaskPool_PreferredLoadoutName().HeaderText = "任务（Task）池_推荐加载方案";
			this.GetTaskPool_PreferredLoadoutName().Name = "TaskPool_PreferredLoadoutName";
			this.GetPostTaskPool_Name().DataPropertyName = "PostTaskPool_Name";
			this.GetPostTaskPool_Name().HeaderText = "PostTaskPool_Name";
			this.GetPostTaskPool_Name().Name = "PostTaskPool_Name";
			this.GetPostTaskPool_PreferredLoadoutName().DataPropertyName = "PostTaskPool_PreferredLoadoutName";
			this.GetPostTaskPool_PreferredLoadoutName().HeaderText = "后任务（Task）池_推荐加载方案";
			this.GetPostTaskPool_PreferredLoadoutName().Name = "PostTaskPool_PreferredLoadoutName";
			this.GetCreatedBy().DataPropertyName = "CreatedBy";
			this.GetCreatedBy().HeaderText = "创建者";
			this.GetCreatedBy().Name = "CreatedBy";
			this.GetEditedBy().DataPropertyName = "EditedBy";
			this.GetEditedBy().HeaderText = "编辑者";
			this.GetEditedBy().Name = "EditedBy";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1008, 691);
			base.Controls.Add(this.GetButton_DeleteFlightPlan());
			base.Controls.Add(this.GetButton_EditAssignedAircraft());
			base.Controls.Add(this.GetButton_FlightPlanEditor());
			base.Controls.Add(this.GetButton_CreateFlightPlan());
			base.Controls.Add(this.GetComboBox_AirborneFlightPlanVisibility());
			base.Controls.Add(this.GetComboBox_PlannedFlightPlanVisibility());
			base.Controls.Add(this.vmethod_68());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.GetDGV_FlightPlans());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FlightPlans";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "飞行计划";
			((global::System.ComponentModel.ISupportInitialize)this.GetDGV_FlightPlans()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002659 RID: 9817
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

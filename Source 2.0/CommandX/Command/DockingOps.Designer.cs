namespace Command
{
	// Token: 0x020009C1 RID: 2497

	public sealed partial class DockingOps : global::ns33.CommandForm
	{
		// Token: 0x060042E1 RID: 17121 RVA: 0x001868C8 File Offset: 0x00184AC8
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

		// Token: 0x060042E2 RID: 17122 RVA: 0x0018690C File Offset: 0x00184B0C
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Command.DockingOps));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_1(new global::System.Windows.Forms.TabControl());
			this.vmethod_3(new global::System.Windows.Forms.TabPage());
			this.vmethod_5(new global::System.Windows.Forms.ToolStrip());
			this.SetTSB_LaunchIndividually(new global::System.Windows.Forms.ToolStripButton());
			this.SetTSB_LaunchAsGroup(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_21(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_23(new global::System.Windows.Forms.ToolStripSeparator());
			this.vmethod_25(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_27(new global::System.Windows.Forms.ToolStripDropDownButton());
			this.vmethod_43(new global::System.Windows.Forms.ToolStripSeparator());
			this.vmethod_59(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_11(new global::System.Windows.Forms.SplitContainer());
			this.vmethod_13(new global::AdvancedDataGridView.TreeGridView());
			this.vmethod_61(new global::ns29.TreeGridViewTextBoxColumn());
			this.vmethod_63(new global::System.Windows.Forms.DataGridViewLinkColumn());
			this.vmethod_65(new global::System.Windows.Forms.DataGridViewLinkColumn());
			this.vmethod_67(new global::System.Windows.Forms.DataGridViewLinkColumn());
			this.vmethod_69(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_71(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_73(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_75(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_29(new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0));
			this.vmethod_31(new global::System.Windows.Forms.ToolStripMenuItem());
			this.vmethod_33(new global::System.Windows.Forms.ToolStripMenuItem());
			this.vmethod_35(new global::System.Windows.Forms.ToolStripMenuItem());
			this.vmethod_37(new global::System.Windows.Forms.ToolStripSeparator());
			this.vmethod_39(new global::System.Windows.Forms.ToolStripMenuItem());
			this.vmethod_41(new global::System.Windows.Forms.ToolStripMenuItem());
			this.vmethod_51(new global::System.Windows.Forms.ToolStripSeparator());
			this.vmethod_53(new global::System.Windows.Forms.ToolStripMenuItem());
			this.vmethod_55(new global::System.Windows.Forms.ToolStripMenuItem());
			this.vmethod_57(new global::System.Windows.Forms.ToolStripMenuItem());
			this.vmethod_15(new global::System.Windows.Forms.TabPage());
			this.vmethod_17(new global::System.Windows.Forms.TreeView());
			this.vmethod_45(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_47(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_49(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_19(new global::System.Windows.Forms.Timer(this.icontainer_0));
			this.vmethod_0().SuspendLayout();
			this.vmethod_2().SuspendLayout();
			this.vmethod_4().SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_10()).BeginInit();
			this.vmethod_10().Panel1.SuspendLayout();
			this.vmethod_10().SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_12()).BeginInit();
			this.vmethod_28().SuspendLayout();
			this.vmethod_14().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Controls.Add(this.vmethod_14());
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Name = "TabControl1";
			this.vmethod_0().SelectedIndex = 0;
			this.vmethod_0().Size = new global::System.Drawing.Size(852, 531);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_2().Controls.Add(this.vmethod_4());
			this.vmethod_2().Controls.Add(this.vmethod_10());
			this.vmethod_2().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_2().Name = "TabPage1";
			this.vmethod_2().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_2().Size = new global::System.Drawing.Size(844, 505);
			this.vmethod_2().TabIndex = 0;
			this.vmethod_2().Text = "舰船状态";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.vmethod_4().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_4().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.GetTSB_LaunchIndividually(),
				this.GetTSB_LaunchAsGroup(),
				this.GetTSB_AbortLaunch(),
				this.vmethod_22(),
				this.GetTSB_Doctrine(),
				this.GetTSB_AssignToMission(),
				this.vmethod_42(),
				this.GetTSB_Cargo()
			});
			this.vmethod_4().Location = new global::System.Drawing.Point(3, 477);
			this.vmethod_4().Name = "ToolStrip1";
			this.vmethod_4().Size = new global::System.Drawing.Size(838, 25);
			this.vmethod_4().TabIndex = 1;
			this.vmethod_4().Text = "ToolStrip1";
            //ZSP ERR IMG this.GetTSB_LaunchIndividually().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton1.Image");
            this.GetTSB_LaunchIndividually().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.GetTSB_LaunchIndividually().Name = "ToolStripButton1";
			this.GetTSB_LaunchIndividually().Size = new global::System.Drawing.Size(130, 22);
			this.GetTSB_LaunchIndividually().Text = "单独出航";
            //ZSP ERR IMG this.GetTSB_LaunchAsGroup().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton3.Image");
            this.GetTSB_LaunchAsGroup().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.GetTSB_LaunchAsGroup().Name = "ToolStripButton3";
			this.GetTSB_LaunchAsGroup().Size = new global::System.Drawing.Size(128, 22);
			this.GetTSB_LaunchAsGroup().Text = "编队出航";
			this.GetTSB_AbortLaunch().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.GetTSB_AbortLaunch().Name = "TSB_AbortLaunch";
			this.GetTSB_AbortLaunch().Size = new global::System.Drawing.Size(83, 22);
			this.GetTSB_AbortLaunch().Text = "终止出航";
			this.vmethod_22().Name = "ToolStripSeparator1";
			this.vmethod_22().Size = new global::System.Drawing.Size(6, 25);
			this.GetTSB_Doctrine().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.GetTSB_Doctrine().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.GetTSB_Doctrine().Name = "TSB_Doctrine";
			this.GetTSB_Doctrine().Size = new global::System.Drawing.Size(56, 22);
			this.GetTSB_Doctrine().Text = "条件规则";
			this.GetTSB_AssignToMission().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.GetTSB_AssignToMission().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.GetTSB_AssignToMission().Name = "TSB_AssignToMission";
			this.GetTSB_AssignToMission().Size = new global::System.Drawing.Size(113, 22);
			this.GetTSB_AssignToMission().Text = "设置使命";
			this.vmethod_42().Name = "ToolStripSeparator3";
			this.vmethod_42().Size = new global::System.Drawing.Size(6, 25);
			this.GetTSB_Cargo().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //ZSP ERR IMG this.GetTSB_Cargo().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_Cargo.Image");
            this.GetTSB_Cargo().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.GetTSB_Cargo().Name = "TSB_Cargo";
			this.GetTSB_Cargo().Size = new global::System.Drawing.Size(72, 22);
			this.GetTSB_Cargo().Text = "装载货物";
			this.vmethod_10().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_10().FixedPanel = global::System.Windows.Forms.FixedPanel.Panel2;
			this.vmethod_10().Location = new global::System.Drawing.Point(3, 3);
			this.vmethod_10().Name = "SplitContainer1";
			this.vmethod_10().Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.vmethod_10().Panel1.Controls.Add(this.vmethod_12());
			this.vmethod_10().Size = new global::System.Drawing.Size(838, 499);
			this.vmethod_10().SplitterDistance = 374;
			this.vmethod_10().TabIndex = 0;
			this.vmethod_12().AllowUserToAddRows = false;
			this.vmethod_12().AllowUserToDeleteRows = false;
			this.vmethod_12().AllowUserToOrderColumns = true;
			this.vmethod_12().AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.vmethod_12().AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.vmethod_12().CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.vmethod_12().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_60(),
				this.vmethod_62(),
				this.vmethod_64(),
				this.vmethod_66(),
				this.vmethod_68(),
				this.vmethod_70(),
				this.vmethod_72(),
				this.vmethod_74()
			});
			this.vmethod_12().ContextMenuStrip = this.vmethod_28();
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.vmethod_12().DefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_12().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_12().EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.vmethod_12().method_8(null);
			this.vmethod_12().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_12().Name = "TGV_Boats";
			this.vmethod_12().RowHeadersVisible = false;
			this.vmethod_12().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_12().method_6(false);
			this.vmethod_12().Size = new global::System.Drawing.Size(838, 374);
			this.vmethod_12().TabIndex = 5;
			this.vmethod_60().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.Blue;
			this.vmethod_60().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_60().SetImage(null);
			this.vmethod_60().HeaderText = "舰艇(点击查看数据库信息)";
			this.vmethod_60().Name = "Boat";
			this.vmethod_60().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_60().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_62().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.Padding = new global::System.Windows.Forms.Padding(1);
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_62().DefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_62().HeaderText = "毁伤(点击查看详情)";
			this.vmethod_62().Name = "Damage";
			this.vmethod_62().ReadOnly = true;
			this.vmethod_64().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.Padding = new global::System.Windows.Forms.Padding(1);
			dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_64().DefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_64().HeaderText = "武器(点击查看详情)";
			this.vmethod_64().Name = "Weapons";
			this.vmethod_64().ReadOnly = true;
			this.vmethod_66().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle5.Padding = new global::System.Windows.Forms.Padding(1);
			dataGridViewCellStyle5.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_66().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_66().HeaderText = "弹药库(点击查看详情)";
			this.vmethod_66().Name = "Magazines";
			this.vmethod_66().ReadOnly = true;
			this.vmethod_68().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_68().HeaderText = "燃料";
			this.vmethod_68().Name = "Fuel";
			this.vmethod_68().ReadOnly = true;
			this.vmethod_68().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_68().Width = 33;
			this.vmethod_70().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_70().HeaderText = "任务";
			this.vmethod_70().Name = "Mission";
			this.vmethod_70().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_70().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_72().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_72().HeaderText = "状态";
			this.vmethod_72().Name = "Status";
			this.vmethod_72().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_72().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_72().Width = 43;
			this.vmethod_74().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_74().HeaderText = "就绪时间";
			this.vmethod_74().MinimumWidth = 77;
			this.vmethod_74().Name = "TimeToReady";
			this.vmethod_74().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_74().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_74().Width = 77;
			this.vmethod_28().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_30(),
				this.vmethod_32(),
				this.vmethod_34(),
				this.vmethod_36(),
				this.vmethod_38(),
				this.vmethod_40(),
				this.vmethod_50(),
				this.vmethod_52(),
				this.vmethod_54(),
				this.vmethod_56()
			});
			this.vmethod_28().Name = "CMenu_BoatOps";
			this.vmethod_28().Size = new global::System.Drawing.Size(178, 192);
			this.vmethod_30().Name = "LaunchIndividuallyToolStripMenuItem";
			this.vmethod_30().Size = new global::System.Drawing.Size(177, 22);
			this.vmethod_30().Text = "独立出航";
			this.vmethod_32().Name = "LaunchAsGroupsToolStripMenuItem";
			this.vmethod_32().Size = new global::System.Drawing.Size(177, 22);
			this.vmethod_32().Text = "编队出航";
			this.vmethod_34().Name = "AbortLaunchToolStripMenuItem";
			this.vmethod_34().Size = new global::System.Drawing.Size(177, 22);
			this.vmethod_34().Text = "终止出航";
			this.vmethod_36().Name = "ToolStripSeparator2";
			this.vmethod_36().Size = new global::System.Drawing.Size(174, 6);
			this.vmethod_38().Name = "DoctrineToolStripMenuItem";
			this.vmethod_38().Size = new global::System.Drawing.Size(177, 22);
			this.vmethod_38().Text = "条令规则";
			this.vmethod_40().Name = "AssignToMissionToolStripMenuItem";
			this.vmethod_40().Size = new global::System.Drawing.Size(177, 22);
			this.vmethod_40().Text = "设置使命";
			this.vmethod_50().Name = "ToolStripSeparator4";
			this.vmethod_50().Size = new global::System.Drawing.Size(174, 6);
			this.vmethod_52().Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.vmethod_52().ForeColor = global::System.Drawing.Color.Red;
			this.vmethod_52().Name = "SetTimeToReadyToolStripMenuItem";
			this.vmethod_52().Size = new global::System.Drawing.Size(177, 22);
			this.vmethod_52().Text = "设置准备时间";
			this.vmethod_54().Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.vmethod_54().ForeColor = global::System.Drawing.Color.Red;
			this.vmethod_54().Name = "RenameToolStripMenuItem";
			this.vmethod_54().Size = new global::System.Drawing.Size(177, 22);
			this.vmethod_54().Text = "重命名";
			this.vmethod_56().Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.vmethod_56().ForeColor = global::System.Drawing.Color.Red;
			this.vmethod_56().Name = "RemoveToolStripMenuItem";
			this.vmethod_56().Size = new global::System.Drawing.Size(177, 22);
			this.vmethod_56().Text = "删除";
			this.vmethod_14().Controls.Add(this.vmethod_16());
			this.vmethod_14().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_14().Name = "TabPage2";
			this.vmethod_14().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_14().Size = new global::System.Drawing.Size(844, 505);
			this.vmethod_14().TabIndex = 1;
			this.vmethod_14().Text = "停泊设施";
			this.vmethod_14().UseVisualStyleBackColor = true;
			this.vmethod_16().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_16().Font = new global::System.Drawing.Font("Verdana", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_16().Location = new global::System.Drawing.Point(3, 3);
			this.vmethod_16().Name = "TV_Facilities";
			this.vmethod_16().Size = new global::System.Drawing.Size(838, 499);
			this.vmethod_16().TabIndex = 7;
			this.GetTSB_SetReadyTime().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.GetTSB_SetReadyTime().Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.GetTSB_SetReadyTime().ForeColor = global::System.Drawing.Color.Red;
			this.GetTSB_SetReadyTime().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.GetTSB_SetReadyTime().Name = "TSB_SetReadyTime";
			this.GetTSB_SetReadyTime().Size = new global::System.Drawing.Size(108, 22);
			this.GetTSB_SetReadyTime().Text = "设置准备时间";
			this.GetTSB_Rename().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.GetTSB_Rename().Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.GetTSB_Rename().ForeColor = global::System.Drawing.Color.Red;
			this.GetTSB_Rename().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.GetTSB_Rename().Name = "TSB_Rename";
			this.GetTSB_Rename().Size = new global::System.Drawing.Size(57, 22);
			this.GetTSB_Rename().Text = "重命名";
			this.GetTSB_Delete().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.GetTSB_Delete().Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.GetTSB_Delete().ForeColor = global::System.Drawing.Color.Red;
			this.GetTSB_Delete().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.GetTSB_Delete().Name = "TSB_Delete";
			this.GetTSB_Delete().Size = new global::System.Drawing.Size(58, 22);
			this.GetTSB_Delete().Text = "删除";
			this.vmethod_18().Interval = 1000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(852, 531);
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DockingOps";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "停泊行动";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_4().PerformLayout();
			this.vmethod_10().Panel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_10()).EndInit();
			this.vmethod_10().ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_12()).EndInit();
			this.vmethod_28().ResumeLayout(false);
			this.vmethod_14().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04001F51 RID: 8017
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

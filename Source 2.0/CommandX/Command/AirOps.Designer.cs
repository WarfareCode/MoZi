using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Command
{
	// Token: 0x020009A3 RID: 2467
	
	public sealed partial class AirOps : global::ns33.CommandForm
	{
		// Token: 0x0600402B RID: 16427 RVA: 0x0015A3A8 File Offset: 0x001585A8
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

		// Token: 0x0600402C RID: 16428 RVA: 0x0015A3EC File Offset: 0x001585EC
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Command.AirOps));
			this.treeGridView_0 = new global::AdvancedDataGridView.TreeGridView();this.treeGridView_0.CellContentClick += new DataGridViewCellEventHandler(this.method_25);
			this.Aircraft_TreeGridViewTextBoxColumn  = new global::ns29.TreeGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CMenu_Unit = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);this.CMenu_Unit.Opening += new CancelEventHandler(this.CMenu_Unit_Opening);
			this.toolStripMenuItem_2 = new global::System.Windows.Forms.ToolStripMenuItem();this.toolStripMenuItem_2.Click += new EventHandler(this.method_53);
			this.toolStripMenuItem_3 = new global::System.Windows.Forms.ToolStripMenuItem();this.toolStripMenuItem_3.Click += new EventHandler(this.method_54);
			this.toolStripMenuItem_4 = new global::System.Windows.Forms.ToolStripMenuItem();this.toolStripMenuItem_4.Click += new EventHandler(this.method_55);
			this.toolStripMenuItem_5 = new global::System.Windows.Forms.ToolStripMenuItem();this.toolStripMenuItem_5.Click += new EventHandler(this.method_56);
			this.toolStripSeparator_2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_0 = new global::System.Windows.Forms.ToolStripMenuItem();this.toolStripMenuItem_0.Click += new EventHandler(this.method_57);
			this.TSMI_AssignToMission = new global::System.Windows.Forms.ToolStripMenuItem();this.TSMI_AssignToMission.Click += new EventHandler(this.TSMI_AssignToMission_Click);this.TSMI_AssignToMission.DropDownItemClicked += new ToolStripItemClickedEventHandler(this.TSMI_AssignToMission_DropDownItemClicked);
			this.toolStripSeparator_3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_6 = new global::System.Windows.Forms.ToolStripMenuItem();this.toolStripMenuItem_6.Click += new EventHandler(this.method_59);
			this.toolStripMenuItem_7 = new global::System.Windows.Forms.ToolStripMenuItem();this.toolStripMenuItem_7.Click += new EventHandler(this.method_60);
			this.toolStripMenuItem_8 = new global::System.Windows.Forms.ToolStripMenuItem();this.toolStripMenuItem_8.Click += new EventHandler(this.method_61);
			this.TGVTBC_Facilities  = new global::ns29.TreeGridViewTextBoxColumn();
			this.TGVTBC_Status  = new global::ns29.TreeGridViewTextBoxColumn();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);this.timer_0.Tick += new EventHandler(this.method_9);
			this.timer_1 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.tabControl_0 = new global::System.Windows.Forms.TabControl();this.tabControl_0.SelectedIndexChanged += new EventHandler(this.method_19);
			this.tabPage_0 = new global::System.Windows.Forms.TabPage();
			this.label_9 = new global::System.Windows.Forms.Label();
			this.label_8 = new global::System.Windows.Forms.Label();
			this.comboBox_0 = new global::System.Windows.Forms.ComboBox();this.comboBox_0.SelectedIndexChanged += new EventHandler(this.method_43);
			this.checkBox_0 = new global::System.Windows.Forms.CheckBox();this.checkBox_0.CheckedChanged += new EventHandler(this.method_46);
			this.label_6 = new global::System.Windows.Forms.Label();
			this.label_7 = new global::System.Windows.Forms.Label();
			this.label_5 = new global::System.Windows.Forms.Label();
			this.label_4 = new global::System.Windows.Forms.Label();
			this.label_0 = new global::System.Windows.Forms.Label();
			this.label_1 = new global::System.Windows.Forms.Label();
			this.label_2 = new global::System.Windows.Forms.Label();
			this.label_3 = new global::System.Windows.Forms.Label();
			this.dataGridView_0 = new global::System.Windows.Forms.DataGridView();this.dataGridView_0.CellContentClick += new DataGridViewCellEventHandler(this.method_4);
			this.dataGridViewTextBoxColumn_5 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewLinkColumn_0 = new global::System.Windows.Forms.DataGridViewLinkColumn();
			this.dataGridViewTextBoxColumn_6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip_0 = new global::System.Windows.Forms.ToolStrip();
			this.toolStripButton_0 = new global::System.Windows.Forms.ToolStripButton();this.toolStripButton_0.Click += new EventHandler(this.method_20);
			this.toolStripButton_2 = new global::System.Windows.Forms.ToolStripButton();this.toolStripButton_2.Click += new EventHandler(this.method_28);
			this.toolStripButton_1 = new global::System.Windows.Forms.ToolStripButton();this.toolStripButton_1.Click += new EventHandler(this.method_23);
			this.toolStripButton_3 = new global::System.Windows.Forms.ToolStripButton();this.toolStripButton_3.Click += new EventHandler(this.method_32);
			this.toolStripSeparator_1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton_7 = new global::System.Windows.Forms.ToolStripButton();this.toolStripButton_7.Click += new EventHandler(this.method_52);
			this.TSB_AssignToMission = new global::System.Windows.Forms.ToolStripDropDownButton();this.TSB_AssignToMission.Click += new EventHandler(this.TSB_AssignToMission_Click);this.TSB_AssignToMission.DropDownOpening += new EventHandler(this.TSB_AssignToMission_DropDownOpening);this.TSB_AssignToMission.DropDownItemClicked += new ToolStripItemClickedEventHandler(this.TSB_AssignToMission_DropDownItemClicked);
			this.toolStripSeparator_0 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton_4 = new global::System.Windows.Forms.ToolStripButton();this.toolStripButton_4.Click += new EventHandler(this.method_39);
			this.toolStripButton_5 = new global::System.Windows.Forms.ToolStripButton();this.toolStripButton_5.Click += new EventHandler(this.method_37);
			this.toolStripButton_6 = new global::System.Windows.Forms.ToolStripButton();this.toolStripButton_6.Click += new EventHandler(this.method_41);
			this.tabPage_1 = new global::System.Windows.Forms.TabPage();
			this.treeView_0 = new global::System.Windows.Forms.TreeView();
			this.TSB_Cargo = new global::System.Windows.Forms.ToolStripButton();this.TSB_Cargo.Click += new EventHandler(this.TSB_Cargo_Click);
			((global::System.ComponentModel.ISupportInitialize)this.treeGridView_0).BeginInit();
			this.CMenu_Unit.SuspendLayout();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView_0).BeginInit();
			this.toolStrip_0.SuspendLayout();
			this.tabPage_1.SuspendLayout();
			base.SuspendLayout();
			this.treeGridView_0.AllowUserToAddRows = false;
			this.treeGridView_0.AllowUserToDeleteRows = false;
			this.treeGridView_0.AllowUserToOrderColumns = true;
			this.treeGridView_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.treeGridView_0.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.treeGridView_0.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.treeGridView_0.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.treeGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.treeGridView_0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Aircraft_TreeGridViewTextBoxColumn,
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4
			});
			this.treeGridView_0.ContextMenuStrip = this.CMenu_Unit;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.treeGridView_0.DefaultCellStyle = dataGridViewCellStyle2;
			this.treeGridView_0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.treeGridView_0.method_8(null);
			this.treeGridView_0.Location = new global::System.Drawing.Point(3, 3);
			this.treeGridView_0.Name = "TGV_Aircraft";
			this.treeGridView_0.RowHeadersVisible = false;
			this.treeGridView_0.RowHeadersWidth = 20;
			this.treeGridView_0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.treeGridView_0.method_6(false);
			this.treeGridView_0.Size = new global::System.Drawing.Size(1080, 320);
			this.treeGridView_0.TabIndex = 7;
			this.Aircraft_TreeGridViewTextBoxColumn.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.Blue;
			this.Aircraft_TreeGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.Aircraft_TreeGridViewTextBoxColumn.SetImage(null);
			this.Aircraft_TreeGridViewTextBoxColumn.FillWeight = 60f;
			this.Aircraft_TreeGridViewTextBoxColumn.HeaderText = "飞机(点击查看信息)";
			this.Aircraft_TreeGridViewTextBoxColumn.Name = "Aircraft";
			this.Aircraft_TreeGridViewTextBoxColumn.ReadOnly = true;
			this.Aircraft_TreeGridViewTextBoxColumn.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_0.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.dataGridViewTextBoxColumn_0.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewTextBoxColumn_0.HeaderText = "状态";
			this.dataGridViewTextBoxColumn_0.MinimumWidth = 43;
			this.dataGridViewTextBoxColumn_0.Name = "Status";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_0.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_0.Width = 43;
			this.dataGridViewTextBoxColumn_1.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.dataGridViewTextBoxColumn_1.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTextBoxColumn_1.FillWeight = 50f;
			this.dataGridViewTextBoxColumn_1.HeaderText = "任务";
			this.dataGridViewTextBoxColumn_1.Name = "Mission";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_1.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_2.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.dataGridViewTextBoxColumn_2.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTextBoxColumn_2.HeaderText = "挂载";
			this.dataGridViewTextBoxColumn_2.Name = "Loadout";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_2.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle7.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.dataGridViewTextBoxColumn_3.DefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewTextBoxColumn_3.HeaderText = "完成准备时间";
			this.dataGridViewTextBoxColumn_3.MinimumWidth = 77;
			this.dataGridViewTextBoxColumn_3.Name = "TimeToReady";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_3.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_3.Width = 77;
			this.dataGridViewTextBoxColumn_4.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.dataGridViewTextBoxColumn_4.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewTextBoxColumn_4.HeaderText = "快速出动";
			this.dataGridViewTextBoxColumn_4.MinimumWidth = 97;
			this.dataGridViewTextBoxColumn_4.Name = "QuickTurnaroundDescription";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_4.Width = 99;
			this.CMenu_Unit.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_2,
				this.toolStripMenuItem_3,
				this.toolStripMenuItem_4,
				this.toolStripMenuItem_5,
				this.toolStripSeparator_2,
				this.toolStripMenuItem_0,
				this.TSMI_AssignToMission,
				this.toolStripSeparator_3,
				this.toolStripMenuItem_6,
				this.toolStripMenuItem_7,
				this.toolStripMenuItem_8
			});
			this.CMenu_Unit.Name = "CMenu_Unit";
			this.CMenu_Unit.Size = new global::System.Drawing.Size(178, 214);
			this.toolStripMenuItem_2.Name = "LaunchIndividuallyToolStripMenuItem";
			this.toolStripMenuItem_2.Size = new global::System.Drawing.Size(177, 22);
			this.toolStripMenuItem_2.Text = "单机出动";
			this.toolStripMenuItem_3.Name = "LaunchAsGroupsToolStripMenuItem";
			this.toolStripMenuItem_3.Size = new global::System.Drawing.Size(177, 22);
			this.toolStripMenuItem_3.Text = "作为编队出动";
			this.toolStripMenuItem_4.Name = "ReadyArmToolStripMenuItem";
			this.toolStripMenuItem_4.Size = new global::System.Drawing.Size(177, 22);
			this.toolStripMenuItem_4.Text = "就绪 / 装备";
			this.toolStripMenuItem_5.Name = "AbortLaunchToolStripMenuItem";
			this.toolStripMenuItem_5.Size = new global::System.Drawing.Size(177, 22);
			this.toolStripMenuItem_5.Text = "终止起飞";
			this.toolStripSeparator_2.Name = "ToolStripSeparator3";
			this.toolStripSeparator_2.Size = new global::System.Drawing.Size(174, 6);
			this.toolStripMenuItem_0.Name = "TSMI_Doctrine";
			this.toolStripMenuItem_0.Size = new global::System.Drawing.Size(177, 22);
			this.toolStripMenuItem_0.Text = "作战条令";
			this.TSMI_AssignToMission.Name = "TSMI_AssignToMission";
			this.TSMI_AssignToMission.Size = new global::System.Drawing.Size(177, 22);
			this.TSMI_AssignToMission.Text = "分配到任务";
			this.toolStripSeparator_3.Name = "ToolStripSeparator4";
			this.toolStripSeparator_3.Size = new global::System.Drawing.Size(174, 6);
			this.toolStripMenuItem_6.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripMenuItem_6.ForeColor = global::System.Drawing.Color.Red;
			this.toolStripMenuItem_6.Name = "SetTimeToReadyToolStripMenuItem";
			this.toolStripMenuItem_6.Size = new global::System.Drawing.Size(177, 22);
			this.toolStripMenuItem_6.Text = "设置准备时间";
			this.toolStripMenuItem_7.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripMenuItem_7.ForeColor = global::System.Drawing.Color.Red;
			this.toolStripMenuItem_7.Name = "RenameToolStripMenuItem";
			this.toolStripMenuItem_7.Size = new global::System.Drawing.Size(177, 22);
			this.toolStripMenuItem_7.Text = "重命名";
			this.toolStripMenuItem_8.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripMenuItem_8.ForeColor = global::System.Drawing.Color.Red;
			this.toolStripMenuItem_8.Name = "RemoveToolStripMenuItem";
			this.toolStripMenuItem_8.Size = new global::System.Drawing.Size(177, 22);
			this.toolStripMenuItem_8.Text = "删除";
			this.TGVTBC_Facilities.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.TGVTBC_Facilities.SetImage(null);
			this.TGVTBC_Facilities.HeaderText = "设施与飞机";
			this.TGVTBC_Facilities.Name = "Facilities";
			this.TGVTBC_Facilities.ReadOnly = true;
			this.TGVTBC_Facilities.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.TGVTBC_Facilities.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.TGVTBC_Status.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TGVTBC_Status.SetImage(null);
			this.TGVTBC_Status.HeaderText = "状态";
			this.TGVTBC_Status.Name = "theStatus";
			this.TGVTBC_Status.ReadOnly = true;
			this.TGVTBC_Status.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.timer_0.Interval = 1000;
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabControl_0.Location = new global::System.Drawing.Point(0, 0);
			this.tabControl_0.Name = "TabControl1";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new global::System.Drawing.Size(1094, 571);
			this.tabControl_0.TabIndex = 0;
			this.tabPage_0.BackColor = global::System.Drawing.SystemColors.Control;
			this.tabPage_0.Controls.Add(this.label_9);
			this.tabPage_0.Controls.Add(this.label_8);
			this.tabPage_0.Controls.Add(this.comboBox_0);
			this.tabPage_0.Controls.Add(this.checkBox_0);
			this.tabPage_0.Controls.Add(this.label_6);
			this.tabPage_0.Controls.Add(this.label_7);
			this.tabPage_0.Controls.Add(this.label_5);
			this.tabPage_0.Controls.Add(this.label_4);
			this.tabPage_0.Controls.Add(this.label_0);
			this.tabPage_0.Controls.Add(this.label_1);
			this.tabPage_0.Controls.Add(this.label_2);
			this.tabPage_0.Controls.Add(this.label_3);
			this.tabPage_0.Controls.Add(this.dataGridView_0);
			this.tabPage_0.Controls.Add(this.treeGridView_0);
			this.tabPage_0.Controls.Add(this.toolStrip_0);
			this.tabPage_0.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage_0.Name = "TabPage1";
			this.tabPage_0.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage_0.Size = new global::System.Drawing.Size(1086, 545);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "飞机状态";
			this.label_9.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label_9.AutoSize = true;
			this.label_9.Location = new global::System.Drawing.Point(655, 416);
			this.label_9.MaximumSize = new global::System.Drawing.Size(400, 40);
			this.label_9.MinimumSize = new global::System.Drawing.Size(400, 40);
			this.label_9.Name = "Label3";
			this.label_9.Size = new global::System.Drawing.Size(400, 40);
			this.label_9.TabIndex = 35;
			this.label_9.Text = "武器状态";
			this.label_8.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label_8.AutoSize = true;
			this.label_8.Location = new global::System.Drawing.Point(277, 328);
			this.label_8.Name = "Label_QuickTurnaroundInfo";
			this.label_8.Size = new global::System.Drawing.Size(39, 13);
			this.label_8.TabIndex = 34;
			this.label_8.Text = "Label1";
			this.comboBox_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new global::System.Drawing.Point(154, 325);
			this.comboBox_0.Name = "Combo_NumberOfSorties";
			this.comboBox_0.Size = new global::System.Drawing.Size(121, 21);
			this.comboBox_0.TabIndex = 33;
			this.checkBox_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.checkBox_0.Location = new global::System.Drawing.Point(3, 328);
			this.checkBox_0.Name = "CB_QuickTurnaround";
			this.checkBox_0.Size = new global::System.Drawing.Size(148, 17);
			this.checkBox_0.TabIndex = 32;
			this.checkBox_0.Text = "支持快速出动";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.label_6.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label_6.AutoSize = true;
			this.label_6.Location = new global::System.Drawing.Point(655, 487);
			this.label_6.Name = "Label7";
			this.label_6.Size = new global::System.Drawing.Size(123, 13);
			this.label_6.TabIndex = 31;
			this.label_6.Text = "总挂载数";
			this.label_7.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label_7.AutoSize = true;
			this.label_7.Location = new global::System.Drawing.Point(655, 502);
			this.label_7.Name = "Label8";
			this.label_7.Size = new global::System.Drawing.Size(200, 13);
			this.label_7.TabIndex = 30;
			this.label_7.Text = "总挂载数(条令)";
			this.label_5.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label_5.AutoSize = true;
			this.label_5.Location = new global::System.Drawing.Point(655, 472);
			this.label_5.Name = "Label6";
			this.label_5.Size = new global::System.Drawing.Size(137, 13);
			this.label_5.TabIndex = 29;
			this.label_5.Text = "基地挂载数";
			this.label_4.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label_4.AutoSize = true;
			this.label_4.Location = new global::System.Drawing.Point(655, 377);
			this.label_4.MaximumSize = new global::System.Drawing.Size(400, 38);
			this.label_4.MinimumSize = new global::System.Drawing.Size(400, 38);
			this.label_4.Name = "Label1";
			this.label_4.Size = new global::System.Drawing.Size(400, 38);
			this.label_4.TabIndex = 28;
			this.label_4.Text = "距离剖面";
			this.label_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label_0.AutoSize = true;
			this.label_0.Location = new global::System.Drawing.Point(655, 457);
			this.label_0.Name = "Label5";
			this.label_0.Size = new global::System.Drawing.Size(73, 13);
			this.label_0.TabIndex = 27;
			this.label_0.Text = "攻击高度";
			this.label_1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label_1.AutoSize = true;
			this.label_1.Location = new global::System.Drawing.Point(655, 362);
			this.label_1.Name = "Label4";
			this.label_1.Size = new global::System.Drawing.Size(60, 13);
			this.label_1.TabIndex = 26;
			this.label_1.Text = "当日时间";
			this.label_2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label_2.AutoSize = true;
			this.label_2.Location = new global::System.Drawing.Point(655, 347);
			this.label_2.Name = "Label2";
			this.label_2.Size = new global::System.Drawing.Size(121, 13);
			this.label_2.TabIndex = 24;
			this.label_2.Text = "挂载作用描述";
			this.label_3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label_3.AutoSize = true;
			this.label_3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.label_3.Location = new global::System.Drawing.Point(3, 347);
			this.label_3.Name = "Label_Loadout";
			this.label_3.Size = new global::System.Drawing.Size(100, 13);
			this.label_3.TabIndex = 23;
			this.label_3.Text = "挂载方案具体内容:";
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.dataGridView_0.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView_0.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_0.BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.dataGridView_0.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dataGridView_0.CausesValidation = false;
			this.dataGridView_0.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle9.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle9.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewLinkColumn_0,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7
			});
			dataGridViewCellStyle10.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = global::System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle10.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle10.SelectionBackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.SelectionForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle10.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridView_0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView_0.EnableHeadersVisualStyles = false;
			this.dataGridView_0.Location = new global::System.Drawing.Point(3, 363);
			this.dataGridView_0.MultiSelect = false;
			this.dataGridView_0.Name = "DGV_LoadoutItems";
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.RowHeadersWidth = 20;
			this.dataGridView_0.RowTemplate.DefaultCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			this.dataGridView_0.RowTemplate.Height = 15;
			this.dataGridView_0.RowTemplate.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_0.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView_0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new global::System.Drawing.Size(650, 153);
			this.dataGridView_0.TabIndex = 22;
			this.dataGridViewTextBoxColumn_5.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "ComponentID";
			this.dataGridViewTextBoxColumn_5.HeaderText = "ID";
			this.dataGridViewTextBoxColumn_5.Name = "ComponentID";
			this.dataGridViewTextBoxColumn_5.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewLinkColumn_0.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewLinkColumn_0.DataPropertyName = "Item";
			dataGridViewCellStyle11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.dataGridViewLinkColumn_0.DefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridViewLinkColumn_0.HeaderText = "可挂载武器(点击查看信息)";
			this.dataGridViewLinkColumn_0.LinkBehavior = global::System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.dataGridViewLinkColumn_0.MinimumWidth = 470;
			this.dataGridViewLinkColumn_0.Name = "Description";
			this.dataGridViewLinkColumn_0.ReadOnly = true;
			this.dataGridViewLinkColumn_0.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewLinkColumn_0.TrackVisitedState = false;
			this.dataGridViewLinkColumn_0.Width = 470;
			this.dataGridViewTextBoxColumn_6.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "Available";
			dataGridViewCellStyle12.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle12.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.dataGridViewTextBoxColumn_6.DefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridViewTextBoxColumn_6.HeaderText = "#可用武器数 [弹药库]";
			this.dataGridViewTextBoxColumn_6.MinimumWidth = 90;
			this.dataGridViewTextBoxColumn_6.Name = "Available";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_6.ToolTipText = "基地弹药库中可用武器数";
			this.dataGridViewTextBoxColumn_7.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "AvailableTotal";
			dataGridViewCellStyle13.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle13.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.dataGridViewTextBoxColumn_7.DefaultCellStyle = dataGridViewCellStyle13;
			this.dataGridViewTextBoxColumn_7.HeaderText = "#可用武器数 [弹药库+飞机]";
			this.dataGridViewTextBoxColumn_7.MinimumWidth = 90;
			this.dataGridViewTextBoxColumn_7.Name = "AvailableTotal";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_7.ToolTipText = "基地弹药库中可用武器数加上飞机挂载的武器数";
			this.toolStrip_0.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip_0.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip_0.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_2,
				this.toolStripButton_1,
				this.toolStripButton_3,
				this.toolStripSeparator_1,
				this.toolStripButton_7,
				this.TSB_AssignToMission,
				this.toolStripSeparator_0,
				this.toolStripButton_4,
				this.toolStripButton_5,
				this.toolStripButton_6,
				this.TSB_Cargo
			});
			this.toolStrip_0.Location = new global::System.Drawing.Point(3, 517);
			this.toolStrip_0.Name = "ToolStrip1";
			this.toolStrip_0.Size = new global::System.Drawing.Size(1080, 25);
			this.toolStrip_0.TabIndex = 1;
			this.toolStrip_0.Text = "ToolStrip1";
			this.toolStripButton_0.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton_0.Name = "ToolStripButton1";
			this.toolStripButton_0.Size = new global::System.Drawing.Size(114, 22);
			this.toolStripButton_0.Text = "单机出动";
			this.toolStripButton_2.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton_2.Name = "ToolStripButton3";
			this.toolStripButton_2.Size = new global::System.Drawing.Size(112, 22);
			this.toolStripButton_2.Text = "编队出动";
			this.toolStripButton_1.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton_1.Name = "ToolStripButton2";
			this.toolStripButton_1.Size = new global::System.Drawing.Size(77, 22);
			this.toolStripButton_1.Text = "出动准备";
			this.toolStripButton_3.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton_3.Name = "TSB_AbortLaunch";
			this.toolStripButton_3.Size = new global::System.Drawing.Size(83, 22);
			this.toolStripButton_3.Text = "终止出动";
			this.toolStripSeparator_1.Name = "ToolStripSeparator2";
			this.toolStripSeparator_1.Size = new global::System.Drawing.Size(6, 25);
			this.toolStripButton_7.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton_7.Name = "TSB_Doctrine";
			this.toolStripButton_7.Size = new global::System.Drawing.Size(56, 22);
			this.toolStripButton_7.Text = "作战条令";
			this.TSB_AssignToMission.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.TSB_AssignToMission.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.TSB_AssignToMission.Name = "TSB_AssignToMission";
			this.TSB_AssignToMission.Size = new global::System.Drawing.Size(113, 22);
			this.TSB_AssignToMission.Text = "分配到任务";
			this.toolStripSeparator_0.Name = "ToolStripSeparator1";
			this.toolStripSeparator_0.Size = new global::System.Drawing.Size(6, 25);
			this.toolStripButton_4.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton_4.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.toolStripButton_4.ForeColor = global::System.Drawing.Color.Red;
			this.toolStripButton_4.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton_4.Name = "TSB_SetReadyTime";
			this.toolStripButton_4.Size = new global::System.Drawing.Size(108, 22);
			this.toolStripButton_4.Text = "设置出动准备时间";
			this.toolStripButton_5.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton_5.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.toolStripButton_5.ForeColor = global::System.Drawing.Color.Red;
			this.toolStripButton_5.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton_5.Name = "TSB_Rename";
			this.toolStripButton_5.Size = new global::System.Drawing.Size(57, 22);
			this.toolStripButton_5.Text = "重命名";
			this.toolStripButton_6.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton_6.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.toolStripButton_6.ForeColor = global::System.Drawing.Color.Red;
			this.toolStripButton_6.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton_6.Name = "TSB_Delete";
			this.toolStripButton_6.Size = new global::System.Drawing.Size(58, 22);
			this.toolStripButton_6.Text = "删除";
			this.tabPage_1.Controls.Add(this.treeView_0);
			this.tabPage_1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage_1.Name = "TabPage2";
			this.tabPage_1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage_1.Size = new global::System.Drawing.Size(1086, 545);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "航空设施";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.treeView_0.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treeView_0.Font = new global::System.Drawing.Font("Verdana", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			this.treeView_0.Location = new global::System.Drawing.Point(3, 3);
			this.treeView_0.Name = "TV_Facilities";
			this.treeView_0.Size = new global::System.Drawing.Size(1080, 539);
			this.treeView_0.TabIndex = 7;
			this.TSB_Cargo.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			//ZSP ERR IMG this.TSB_Cargo.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_Cargo.Image");
			this.TSB_Cargo.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.TSB_Cargo.Name = "TSB_Cargo";
			this.TSB_Cargo.Size = new global::System.Drawing.Size(121, 22);
			this.TSB_Cargo.Text = "货物装载/卸载";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1094, 571);
			base.Controls.Add(this.tabControl_0);
			this.DoubleBuffered = true;
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AirOps";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "空中行动";
			((global::System.ComponentModel.ISupportInitialize)this.treeGridView_0).EndInit();
			this.CMenu_Unit.ResumeLayout(false);
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.tabPage_0.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView_0).EndInit();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.tabPage_1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04001D83 RID: 7555
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

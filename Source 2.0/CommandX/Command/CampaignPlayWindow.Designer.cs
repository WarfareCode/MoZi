using System;

namespace Command
{
	// Token: 0x0200097A RID: 2426

	public sealed partial class CampaignPlayWindow : global::ns33.CommandForm
	{
		// Token: 0x06003C02 RID: 15362 RVA: 0x00129AE8 File Offset: 0x00127CE8
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

		// Token: 0x06003C03 RID: 15363 RVA: 0x00129B2C File Offset: 0x00127D2C
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.button_0 = new global::System.Windows.Forms.Button();this.button_0.Click += new EventHandler(this.method_3);
			this.webBrowser_0 = new global::System.Windows.Forms.WebBrowser();
			this.tabControl_0 = new global::System.Windows.Forms.TabControl();
			this.tabPage_0 = new global::System.Windows.Forms.TabPage();
			this.button_3 = new global::System.Windows.Forms.Button();this.button_3.Click += new EventHandler(this.method_11);
			this.label_0 = new global::System.Windows.Forms.Label();
			this.flowLayoutPanel_0 = new global::System.Windows.Forms.FlowLayoutPanel();
			this.tabPage_1 = new global::System.Windows.Forms.TabPage();
			this.button_1 = new global::System.Windows.Forms.Button();this.button_1.Click += new EventHandler(this.method_6);
			this.button_2 = new global::System.Windows.Forms.Button();this.button_2.Click += new EventHandler(this.method_4);
			this.treeGridView_0 = new global::AdvancedDataGridView.TreeGridView();this.treeGridView_0.SelectionChanged += new EventHandler(this.method_5);
			this.class2383_0 = new global::ns29.TreeGridViewTextBoxColumn();
			this.class2383_1 = new global::ns29.TreeGridViewTextBoxColumn();
			this.class2383_2 = new global::ns29.TreeGridViewTextBoxColumn();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.tabPage_1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.treeGridView_0).BeginInit();
			base.SuspendLayout();
			this.button_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.button_0.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button_0.Location = new global::System.Drawing.Point(316, 508);
			this.button_0.Name = "Button1";
			this.button_0.Size = new global::System.Drawing.Size(253, 48);
			this.button_0.TabIndex = 17;
			this.button_0.Text = "启动新战役推演";
			this.button_0.UseVisualStyleBackColor = true;
			this.webBrowser_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.webBrowser_0.Location = new global::System.Drawing.Point(316, 3);
			this.webBrowser_0.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser_0.Name = "WebBrowser1";
			this.webBrowser_0.Size = new global::System.Drawing.Size(687, 502);
			this.webBrowser_0.TabIndex = 16;
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabControl_0.Location = new global::System.Drawing.Point(0, 0);
			this.tabControl_0.Name = "TabControl1";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new global::System.Drawing.Size(1014, 588);
			this.tabControl_0.TabIndex = 19;
			this.tabPage_0.BackColor = global::System.Drawing.SystemColors.Control;
			this.tabPage_0.Controls.Add(this.button_3);
			this.tabPage_0.Controls.Add(this.label_0);
			this.tabPage_0.Controls.Add(this.flowLayoutPanel_0);
			this.tabPage_0.Controls.Add(this.webBrowser_0);
			this.tabPage_0.Controls.Add(this.button_0);
			this.tabPage_0.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage_0.Name = "TabPage1";
			this.tabPage_0.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage_0.Size = new global::System.Drawing.Size(1006, 562);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "启动新战役推演";
			this.button_3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button_3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button_3.Location = new global::System.Drawing.Point(750, 508);
			this.button_3.Name = "Button2";
			this.button_3.Size = new global::System.Drawing.Size(253, 48);
			this.button_3.TabIndex = 20;
			this.button_3.Text = "取消";
			this.button_3.UseVisualStyleBackColor = true;
			this.label_0.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			this.label_0.Location = new global::System.Drawing.Point(317, 4);
			this.label_0.Name = "Label_SelectCampaign";
			this.label_0.Size = new global::System.Drawing.Size(442, 40);
			this.label_0.TabIndex = 19;
			this.label_0.Text = "从列表中选择一个新战役进行推演, \r\n或从保存的战役推演进程中恢复。";
			this.flowLayoutPanel_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.flowLayoutPanel_0.BackColor = global::System.Drawing.SystemColors.ActiveBorder;
			this.flowLayoutPanel_0.Location = new global::System.Drawing.Point(0, 0);
			this.flowLayoutPanel_0.Name = "FlowLayoutPanel1";
			this.flowLayoutPanel_0.Size = new global::System.Drawing.Size(305, 562);
			this.flowLayoutPanel_0.TabIndex = 18;
			this.tabPage_1.BackColor = global::System.Drawing.SystemColors.Control;
			this.tabPage_1.Controls.Add(this.button_1);
			this.tabPage_1.Controls.Add(this.button_2);
			this.tabPage_1.Controls.Add(this.treeGridView_0);
			this.tabPage_1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage_1.Name = "TabPage2";
			this.tabPage_1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage_1.Size = new global::System.Drawing.Size(1006, 562);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "恢复战役推演";
			this.button_1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button_1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button_1.Location = new global::System.Drawing.Point(742, 498);
			this.button_1.Name = "Button4";
			this.button_1.Size = new global::System.Drawing.Size(225, 33);
			this.button_1.TabIndex = 10;
			this.button_1.Text = "删除所选的想定文件";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.button_2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button_2.Location = new global::System.Drawing.Point(6, 498);
			this.button_2.Name = "Button3";
			this.button_2.Size = new global::System.Drawing.Size(223, 33);
			this.button_2.TabIndex = 9;
			this.button_2.Text = "恢复战役推演";
			this.button_2.UseVisualStyleBackColor = true;
			this.treeGridView_0.AllowUserToAddRows = false;
			this.treeGridView_0.AllowUserToDeleteRows = false;
			this.treeGridView_0.AllowUserToOrderColumns = true;
			this.treeGridView_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.treeGridView_0.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.treeGridView_0.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.treeGridView_0.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.treeGridView_0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.class2383_0,
				this.class2383_1,
				this.class2383_2
			});
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.treeGridView_0.DefaultCellStyle = dataGridViewCellStyle;
			this.treeGridView_0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.treeGridView_0.method_8(null);
			this.treeGridView_0.Location = new global::System.Drawing.Point(3, 3);
			this.treeGridView_0.Name = "TGV_CampaignSaves";
			this.treeGridView_0.RowHeadersVisible = false;
			this.treeGridView_0.RowHeadersWidth = 20;
			this.treeGridView_0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.treeGridView_0.method_6(false);
			this.treeGridView_0.Size = new global::System.Drawing.Size(967, 489);
			this.treeGridView_0.TabIndex = 8;
			this.class2383_0.SetImage(null);
			this.class2383_0.HeaderText = "名称";
			this.class2383_0.Name = "Column_Name";
			this.class2383_0.ReadOnly = true;
			this.class2383_0.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.class2383_0.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.class2383_1.SetImage(null);
			this.class2383_1.HeaderText = "想定时间";
			this.class2383_1.Name = "Column_ScenTime";
			this.class2383_1.ReadOnly = true;
			this.class2383_1.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.class2383_1.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.class2383_2.SetImage(null);
			this.class2383_2.HeaderText = "保存时间";
			this.class2383_2.Name = "Column_SaveTime";
			this.class2383_2.ReadOnly = true;
			this.class2383_2.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.class2383_2.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1014, 588);
			base.Controls.Add(this.tabControl_0);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CampaignPlayWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "战役";
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.tabPage_0.PerformLayout();
			this.tabPage_1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.treeGridView_0).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001B64 RID: 7012
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

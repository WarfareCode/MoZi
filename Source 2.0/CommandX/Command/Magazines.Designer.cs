namespace Command
{
	// Token: 0x02000A70 RID: 2672
	public sealed partial class Magazines : global::ns33.CommandForm
	{
		// Token: 0x06005484 RID: 21636 RVA: 0x002325FC File Offset: 0x002307FC
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

		// Token: 0x06005485 RID: 21637 RVA: 0x00232640 File Offset: 0x00230840
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Command.Magazines));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_1(new global::AdvancedDataGridView.TreeGridView());
			this.vmethod_3(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_19(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_21(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_15(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_5(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_7(new global::System.Windows.Forms.ToolStripLabel());
			this.vmethod_9(new global::System.Windows.Forms.ToolStripTextBox());
			this.vmethod_11(new global::System.Windows.Forms.ToolStripLabel());
			this.vmethod_13(new global::System.Windows.Forms.ToolStripComboBox());
			this.vmethod_17(new global::System.Windows.Forms.Timer(this.icontainer_0));
			this.vmethod_23(new global::ns29.TreeGridViewTextBoxColumn());
			this.vmethod_25(new global::ns29.TreeGridViewTextBoxColumn());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_2().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AllowUserToOrderColumns = true;
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.vmethod_0().AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.vmethod_0().CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.vmethod_0().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_22(),
				this.vmethod_24()
			});
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.vmethod_0().method_8(null);
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Name = "TGV_Mags";
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().method_6(false);
			this.vmethod_0().Size = new global::System.Drawing.Size(815, 300);
			this.vmethod_0().TabIndex = 5;
			this.vmethod_2().Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.vmethod_2().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_18(),
				this.vmethod_20(),
				this.vmethod_14(),
				this.vmethod_4(),
				this.vmethod_6(),
				this.vmethod_8(),
				this.vmethod_10(),
				this.vmethod_12()
			});
			this.vmethod_2().Location = new global::System.Drawing.Point(0, 303);
			this.vmethod_2().Name = "TS_Edit";
			this.vmethod_2().Size = new global::System.Drawing.Size(815, 25);
			this.vmethod_2().TabIndex = 6;
			this.vmethod_2().Text = "ToolStrip1";
            //ZSP ERR IMG this.vmethod_18().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_AddMag.Image");
            this.vmethod_18().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_18().Name = "TSB_AddMag";
			this.vmethod_18().Size = new global::System.Drawing.Size(103, 22);
			this.vmethod_18().Text = "添加弹药库";
            //ZSP ERR IMG this.vmethod_20().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_RemoveMag.Image");
            this.vmethod_20().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_20().Name = "TSB_RemoveMag";
			this.vmethod_20().Size = new global::System.Drawing.Size(124, 22);
			this.vmethod_20().Text = "删除弹药库";
            //ZSP ERR IMG this.vmethod_14().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_AddRec.Image");
            this.vmethod_14().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_14().Name = "TSB_AddRec";
			this.vmethod_14().Size = new global::System.Drawing.Size(101, 22);
			this.vmethod_14().Text = "添加武器";
            //ZSP ERR IMG this.vmethod_4().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_RemoveRec.Image");
            this.vmethod_4().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_4().Name = "TSB_RemoveRec";
			this.vmethod_4().Size = new global::System.Drawing.Size(122, 22);
			this.vmethod_4().Text = "删除武器";
			this.vmethod_6().Name = "ToolStripLabel1";
			this.vmethod_6().Size = new global::System.Drawing.Size(90, 22);
			this.vmethod_6().Text = "武器数量:";
			this.vmethod_8().BackColor = global::System.Drawing.Color.Gainsboro;
			this.vmethod_8().Name = "TSTB_RecCount";
			this.vmethod_8().Size = new global::System.Drawing.Size(50, 25);
			this.vmethod_10().Name = "ToolStripLabel2";
			this.vmethod_10().Size = new global::System.Drawing.Size(42, 22);
			this.vmethod_10().Text = "状态:";
			//this.vmethod_12().Items.AddRange(new object[]
			//{
			//	"Operational",
			//	"Damaged (Light)",
			//	"Damaged (Medium)",
			//	"Damaged (Heavy)",
			//	"Destroyed"
			//});
            this.vmethod_12().Items.AddRange(new object[]
            {
                "正常运转",
                "轻度毁伤",
                "中度毁伤",
                "重度毁伤",
                "摧毁"
            });
            this.vmethod_12().Name = "TSC_MagStatus";
			this.vmethod_12().Size = new global::System.Drawing.Size(121, 25);
			this.vmethod_16().Interval = 1000;
			this.vmethod_22().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_22().DataPropertyName = "Name";
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_22().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_22().SetImage(null);
			this.vmethod_22().HeaderText = "弹药库";
			this.vmethod_22().Name = "Magazine";
			this.vmethod_22().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_22().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_22().Width = 57;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_24().DefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_24().SetImage(null);
			this.vmethod_24().HeaderText = "状态";
			this.vmethod_24().Name = "Status";
			this.vmethod_24().ReadOnly = true;
			this.vmethod_24().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(815, 328);
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Magazines";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "弹药库";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040028DF RID: 10463
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

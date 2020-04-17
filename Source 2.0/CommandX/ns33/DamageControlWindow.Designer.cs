namespace ns33
{
	// Token: 0x02000996 RID: 2454
	public sealed partial class DamageControlWindow : global::ns33.CommandForm
	{
		// Token: 0x06003E2D RID: 15917 RVA: 0x00144D5C File Offset: 0x00142F5C
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

		// Token: 0x06003E2E RID: 15918 RVA: 0x00144DA0 File Offset: 0x00142FA0
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_1(new global::AdvancedDataGridView.TreeGridView());
			this.vmethod_7(new global::ns29.TreeGridViewTextBoxColumn());
			this.vmethod_3(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_5(new global::System.Windows.Forms.ToolStripLabel());
			this.vmethod_9(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_11(new global::System.Windows.Forms.ToolStripLabel());
			this.vmethod_13(new global::System.Windows.Forms.ToolStripComboBox());
			this.vmethod_15(new global::System.Windows.Forms.ToolStripLabel());
			this.vmethod_17(new global::System.Windows.Forms.ToolStripTextBox());
			this.vmethod_19(new global::System.Windows.Forms.Timer(this.icontainer_0));
			this.vmethod_21(new global::ns29.TreeGridViewTextBoxColumn());
			this.vmethod_23(new global::ns29.TreeGridViewTextBoxColumn());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_2().SuspendLayout();
			this.vmethod_8().SuspendLayout();
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
				this.vmethod_20(),
				this.vmethod_22()
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
			this.vmethod_0().Location = new global::System.Drawing.Point(2, 28);
			this.vmethod_0().Name = "TGV_Damage";
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().method_6(false);
			this.vmethod_0().Size = new global::System.Drawing.Size(471, 233);
			this.vmethod_0().TabIndex = 5;
			this.vmethod_6().SetImage(null);
			this.vmethod_6().HeaderText = "状态";
			this.vmethod_6().Name = "Status";
			this.vmethod_6().ReadOnly = true;
			this.vmethod_6().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_6().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_2().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_4()
			});
			this.vmethod_2().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_2().Name = "ToolStrip1";
			this.vmethod_2().Size = new global::System.Drawing.Size(475, 25);
			this.vmethod_2().TabIndex = 6;
			this.vmethod_2().Text = "ToolStrip1";
			this.vmethod_4().Name = "ToolStripLabel1";
			this.vmethod_4().Size = new global::System.Drawing.Size(54, 22);
			this.vmethod_4().Text = "毁伤:";
			this.vmethod_8().Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.vmethod_8().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_8().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_10(),
				this.vmethod_12(),
				this.vmethod_14(),
				this.vmethod_16()
			});
			this.vmethod_8().Location = new global::System.Drawing.Point(0, 264);
			this.vmethod_8().Name = "TS_EditDamage";
			this.vmethod_8().Size = new global::System.Drawing.Size(475, 25);
			this.vmethod_8().TabIndex = 7;
			this.vmethod_8().Text = "ToolStrip2";
			this.vmethod_10().Name = "ToolStripLabel2";
			this.vmethod_10().Size = new global::System.Drawing.Size(42, 22);
			this.vmethod_10().Text = "状态:";
			this.vmethod_12().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_12().Items.AddRange(new object[]
			{
				"正常运行",
				"轻度毁伤",
				"中度毁伤",
				"重度毁伤",
				"完全摧毁"
			});
			this.vmethod_12().Name = "TSC_ComponentStatus";
			this.vmethod_12().Size = new global::System.Drawing.Size(121, 25);
			this.vmethod_14().Name = "ToolStripLabel3";
			this.vmethod_14().Size = new global::System.Drawing.Size(94, 22);
			this.vmethod_14().Text = "总体毁伤:";
			this.vmethod_16().Name = "TSTB_Damage";
			this.vmethod_16().Size = new global::System.Drawing.Size(100, 25);
			this.vmethod_20().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_20().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_20().SetImage(null);
			this.vmethod_20().HeaderText = "名称";
			this.vmethod_20().Name = "ComponentName";
			this.vmethod_20().ReadOnly = true;
			this.vmethod_20().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_20().Width = 39;
			this.vmethod_22().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_22().DefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_22().SetImage(null);
			this.vmethod_22().HeaderText = "状态";
			this.vmethod_22().Name = "ComponentStatus";
			this.vmethod_22().ReadOnly = true;
			this.vmethod_22().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(475, 289);
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DamageControlWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "损管面板";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_8().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001C95 RID: 7317
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

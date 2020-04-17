namespace Command
{
	// Token: 0x02000AC5 RID: 2757
	public sealed partial class UnitSensors : global::ns33.CommandForm
	{
		// Token: 0x06005804 RID: 22532 RVA: 0x00027DF1 File Offset: 0x00025FF1
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool flag)
		{
			if (flag && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(flag);
		}

		// Token: 0x06005805 RID: 22533 RVA: 0x0026B074 File Offset: 0x00269274
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Command.UnitSensors));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_1(new global::System.Windows.Forms.CheckBox());
			this.vmethod_3(new global::System.Windows.Forms.CheckBox());
			this.vmethod_5(new global::System.Windows.Forms.CheckBox());
			this.vmethod_7(new global::System.Windows.Forms.CheckBox());
			this.vmethod_9(new global::System.Windows.Forms.Label());
			this.vmethod_11(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_13(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_15(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_17(new global::System.Windows.Forms.Timer(this.icontainer_0));
			this.vmethod_19(new global::System.Windows.Forms.DataGridView());
			this.vmethod_21(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_23(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_25(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_27(new global::System.Windows.Forms.DataGridViewCheckBoxColumn());
			this.vmethod_29(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_10().SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_18()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().AutoSize = true;
			this.vmethod_0().Location = new global::System.Drawing.Point(3, 2);
			this.vmethod_0().Name = "CB_ObeyEMCON";
			this.vmethod_0().Size = new global::System.Drawing.Size(350, 17);
			this.vmethod_0().TabIndex = 9;
			this.vmethod_0().Text = "作战单元遵循电磁管控规则(不手动调整传感器控制)";
			this.vmethod_0().UseVisualStyleBackColor = true;
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().CheckAlign = global::System.Drawing.ContentAlignment.BottomRight;
			this.vmethod_2().Location = new global::System.Drawing.Point(279, 26);
			this.vmethod_2().Name = "CB_ECM";
			this.vmethod_2().RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.vmethod_2().Size = new global::System.Drawing.Size(97, 17);
			this.vmethod_2().TabIndex = 12;
			this.vmethod_2().Text = "电子干扰";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().CheckAlign = global::System.Drawing.ContentAlignment.BottomRight;
			this.vmethod_4().Location = new global::System.Drawing.Point(116, 26);
			this.vmethod_4().Name = "CB_radar";
			this.vmethod_4().RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.vmethod_4().Size = new global::System.Drawing.Size(60, 17);
			this.vmethod_4().TabIndex = 10;
			this.vmethod_4().Text = "雷达";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_6().AutoSize = true;
			this.vmethod_6().CheckAlign = global::System.Drawing.ContentAlignment.BottomRight;
			this.vmethod_6().Location = new global::System.Drawing.Point(200, 26);
			this.vmethod_6().Name = "CB_Sonar";
			this.vmethod_6().RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.vmethod_6().Size = new global::System.Drawing.Size(59, 17);
			this.vmethod_6().TabIndex = 11;
			this.vmethod_6().Text = "声纳";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_8().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_8().Location = new global::System.Drawing.Point(3, 27);
			this.vmethod_8().Name = "Label1";
			this.vmethod_8().Size = new global::System.Drawing.Size(99, 13);
			this.vmethod_8().TabIndex = 13;
			this.vmethod_8().Text = "分类选择:";
			this.vmethod_10().Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.vmethod_10().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_10().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_12(),
				this.vmethod_14()
			});
			this.vmethod_10().Location = new global::System.Drawing.Point(0, 313);
			this.vmethod_10().Name = "TS_Edit";
			this.vmethod_10().Size = new global::System.Drawing.Size(681, 25);
			this.vmethod_10().TabIndex = 14;
			this.vmethod_10().Text = "ToolStrip1";
            //ZSP ERR IMG this.vmethod_12().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_AddSensor.Image");
            this.vmethod_12().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_12().Name = "TSB_AddSensor";
			this.vmethod_12().Size = new global::System.Drawing.Size(87, 22);
			this.vmethod_12().Text = "添加传感器";
            //ZSP ERR IMG this.vmethod_14().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_RemoveSensor.Image");
            this.vmethod_14().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_14().Name = "TSB_RemoveSensor";
			this.vmethod_14().Size = new global::System.Drawing.Size(108, 22);
			this.vmethod_14().Text = "删除传感器";
			this.vmethod_18().AllowUserToAddRows = false;
			this.vmethod_18().AllowUserToDeleteRows = false;
			this.vmethod_18().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_18().AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.vmethod_18().AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.vmethod_18().CausesValidation = false;
			this.vmethod_18().ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_18().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_20(),
				this.vmethod_22(),
				this.vmethod_24(),
				this.vmethod_26(),
				this.vmethod_28()
			});
			this.vmethod_18().Location = new global::System.Drawing.Point(0, 50);
			this.vmethod_18().MultiSelect = false;
			this.vmethod_18().Name = "DGV_Sensors";
			this.vmethod_18().RowHeadersVisible = false;
			this.vmethod_18().RowHeadersWidth = 4;
			this.vmethod_18().RowTemplate.DefaultCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_18().RowTemplate.DefaultCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_18().RowTemplate.Height = 20;
			this.vmethod_18().RowTemplate.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.vmethod_18().ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.vmethod_18().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_18().Size = new global::System.Drawing.Size(681, 263);
			this.vmethod_18().TabIndex = 8;
			this.vmethod_20().DataPropertyName = "ObjectID";
			this.vmethod_20().HeaderText = "对象标识";
			this.vmethod_20().Name = "ObjectID";
			this.vmethod_20().ReadOnly = true;
			this.vmethod_20().Visible = false;

			this.vmethod_22().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_22().DataPropertyName = "Sensor";
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_22().DefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_22().FillWeight = 92.72417f;
			this.vmethod_22().HeaderText = "传感器";
			this.vmethod_22().Name = "SensorColumn";
			this.vmethod_22().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

			this.vmethod_24().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_24().DataPropertyName = "SensorType";
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_24().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_24().FillWeight = 92.72417f;
			this.vmethod_24().HeaderText = "传感器类型";
			this.vmethod_24().Name = "SensorType";
			this.vmethod_24().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

			this.vmethod_26().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.vmethod_26().DataPropertyName = "Active";
			this.vmethod_26().FillWeight = 121.8274f;
			this.vmethod_26().HeaderText = "开关";
			this.vmethod_26().MinimumWidth = 60;
			this.vmethod_26().Name = "Active";
			this.vmethod_26().Width = 90;
			this.vmethod_28().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_28().DataPropertyName = "Status";
			this.vmethod_28().FillWeight = 92.72417f;
			this.vmethod_28().HeaderText = "工作状态";
			this.vmethod_28().Name = "Status";
			this.vmethod_28().Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_28().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(681, 338);
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "UnitSensors";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "传感器: ";
			this.vmethod_10().ResumeLayout(false);
			this.vmethod_10().PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_18()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002B58 RID: 11096
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

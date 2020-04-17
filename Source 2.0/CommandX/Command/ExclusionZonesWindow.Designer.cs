namespace Command
{
	// Token: 0x02000A0D RID: 2573
	public sealed partial class ExclusionZonesWindow : global::ns33.CommandForm
	{
		// Token: 0x06004ED3 RID: 20179 RVA: 0x001FB3FC File Offset: 0x001F95FC
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

		// Token: 0x06004ED4 RID: 20180 RVA: 0x001FB440 File Offset: 0x001F9640
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_24(new global::System.Windows.Forms.ColorDialog());
			this.vmethod_34(new global::System.Windows.Forms.CheckBox());
			this.vmethod_30(new global::System.Windows.Forms.Button());
			this.vmethod_32(new global::System.Windows.Forms.Button());
			this.vmethod_28(new global::System.Windows.Forms.Label());
			this.vmethod_26(new global::ns33.AreaEditor());
			this.vmethod_15(new global::System.Windows.Forms.CheckBox());
			this.vmethod_17(new global::System.Windows.Forms.CheckBox());
			this.vmethod_1(new global::System.Windows.Forms.DataGridView());
			this.vmethod_19(new global::System.Windows.Forms.CheckBox());
			this.vmethod_9(new global::System.Windows.Forms.Label());
			this.vmethod_21(new global::System.Windows.Forms.CheckBox());
			this.vmethod_23(new global::System.Windows.Forms.Label());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_13(new global::System.Windows.Forms.Button());
			this.vmethod_3(new global::System.Windows.Forms.ComboBox());
			this.vmethod_11(new global::System.Windows.Forms.Button());
			this.vmethod_7(new global::System.Windows.Forms.TextBox());
			this.vmethod_36(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_38(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_40(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_42(new global::System.Windows.Forms.DataGridViewCheckBoxColumn());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_33().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_33().Location = new global::System.Drawing.Point(304, 496);
			this.vmethod_33().Name = "CB_VisibleRP";
			this.vmethod_33().Size = new global::System.Drawing.Size(141, 17);
			this.vmethod_33().TabIndex = 32;
			this.vmethod_33().Text = "可见参考点";
			this.vmethod_33().UseVisualStyleBackColor = true;
			this.vmethod_29().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_29().Location = new global::System.Drawing.Point(511, 521);
			this.vmethod_29().Name = "ImportZone";
			this.vmethod_29().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_29().TabIndex = 31;
			this.vmethod_29().Text = "导入";
			this.vmethod_29().UseVisualStyleBackColor = true;
			this.vmethod_31().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_31().Location = new global::System.Drawing.Point(432, 521);
			this.vmethod_31().Name = "ExportZone";
			this.vmethod_31().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_31().TabIndex = 30;
			this.vmethod_31().Text = "导出";
			this.vmethod_31().UseVisualStyleBackColor = true;
			this.vmethod_27().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_27().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_27().Location = new global::System.Drawing.Point(8, 379);
			this.vmethod_27().Name = "Label4";
			this.vmethod_27().Size = new global::System.Drawing.Size(116, 18);
			this.vmethod_27().TabIndex = 13;
			this.vmethod_27().Text = "所选区域";
			this.vmethod_25().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_25().Location = new global::System.Drawing.Point(297, 367);
			this.vmethod_25().Name = "AreaEditor1";
			this.vmethod_25().Size = new global::System.Drawing.Size(351, 124);
			this.vmethod_25().TabIndex = 12;
			this.vmethod_25().method_0(null);
			this.vmethod_14().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Location = new global::System.Drawing.Point(72, 446);
			this.vmethod_14().Name = "CB_Facility";
			this.vmethod_14().Size = new global::System.Drawing.Size(75, 17);
			this.vmethod_14().TabIndex = 11;
			this.vmethod_14().Text = "地面单元";
			this.vmethod_14().UseVisualStyleBackColor = true;
			this.vmethod_16().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_16().AutoSize = true;
			this.vmethod_16().Location = new global::System.Drawing.Point(16, 446);
			this.vmethod_16().Name = "CB_Submarine";
			this.vmethod_16().Size = new global::System.Drawing.Size(81, 17);
			this.vmethod_16().TabIndex = 10;
			this.vmethod_16().Text = "潜艇";
			this.vmethod_16().UseVisualStyleBackColor = true;
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().BackgroundColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_35(),
				this.vmethod_37(),
				this.vmethod_39(),
				this.vmethod_41()
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.vmethod_0().Location = new global::System.Drawing.Point(-3, 1);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DataGridView1";
			this.vmethod_0().ReadOnly = true;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_0().RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().ShowCellToolTips = false;
			this.vmethod_0().ShowEditingIcon = false;
			this.vmethod_0().ShowRowErrors = false;
			this.vmethod_0().Size = new global::System.Drawing.Size(662, 365);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_18().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_18().AutoSize = true;
			this.vmethod_18().Location = new global::System.Drawing.Point(72, 423);
			this.vmethod_18().Name = "CB_Ship";
			this.vmethod_18().Size = new global::System.Drawing.Size(52, 17);
			this.vmethod_18().TabIndex = 9;
			this.vmethod_18().Text = "水面舰艇";
			this.vmethod_18().UseVisualStyleBackColor = true;
			this.vmethod_8().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_8().Location = new global::System.Drawing.Point(9, 477);
			this.vmethod_8().Name = "Label1";
			this.vmethod_8().Size = new global::System.Drawing.Size(63, 13);
			this.vmethod_8().TabIndex = 0;
			this.vmethod_8().Text = "说明:";
			this.vmethod_20().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_20().AutoSize = true;
			this.vmethod_20().Location = new global::System.Drawing.Point(16, 423);
			this.vmethod_20().Name = "CB_Aircraft";
			this.vmethod_20().Size = new global::System.Drawing.Size(59, 17);
			this.vmethod_20().TabIndex = 8;
			this.vmethod_20().Text = "飞机";
			this.vmethod_20().UseVisualStyleBackColor = true;
			this.vmethod_22().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_22().Location = new global::System.Drawing.Point(15, 408);
			this.vmethod_22().Name = "Label3";
			this.vmethod_22().Size = new global::System.Drawing.Size(60, 13);
			this.vmethod_22().TabIndex = 7;
			this.vmethod_22().Text = "应用于:";
			this.vmethod_4().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_4().Location = new global::System.Drawing.Point(9, 503);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new global::System.Drawing.Size(90, 13);
			this.vmethod_4().TabIndex = 3;
			this.vmethod_4().Text = "闯入者视为:";
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_12().Location = new global::System.Drawing.Point(300, 522);
			this.vmethod_12().Name = "Button_SetDescription";
			this.vmethod_12().Size = new global::System.Drawing.Size(47, 21);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_12().Text = "保存";
			this.vmethod_12().UseVisualStyleBackColor = true;
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_2().FormattingEnabled = true;
			this.vmethod_2().Items.AddRange(new object[]
			{
				"非友方",
				"敌对方"
			});
			this.vmethod_2().Location = new global::System.Drawing.Point(105, 500);
			this.vmethod_2().Name = "CB_MarkViolatorAs";
			this.vmethod_2().Size = new global::System.Drawing.Size(178, 21);
			this.vmethod_2().TabIndex = 4;
			this.vmethod_10().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_10().BackColor = global::System.Drawing.Color.Red;
			this.vmethod_10().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_10().Location = new global::System.Drawing.Point(353, 519);
			this.vmethod_10().Name = "Button2";
			this.vmethod_10().Size = new global::System.Drawing.Size(75, 27);
			this.vmethod_10().TabIndex = 5;
			this.vmethod_10().Text = "删除";
			this.vmethod_10().UseVisualStyleBackColor = false;
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_6().Location = new global::System.Drawing.Point(105, 474);
			this.vmethod_6().Name = "TB_Description";
			this.vmethod_6().Size = new global::System.Drawing.Size(178, 20);
			this.vmethod_6().TabIndex = 1;
			this.vmethod_35().DataPropertyName = "ID";
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_35().DefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_35().HeaderText = "ID";
			this.vmethod_35().Name = "ID";
			this.vmethod_35().ReadOnly = true;
			this.vmethod_35().Visible = false;
			this.vmethod_37().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_37().DataPropertyName = "Description";
			dataGridViewCellStyle5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_37().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_37().HeaderText = "说明";
			this.vmethod_37().Name = "Description";
			this.vmethod_37().ReadOnly = true;
			this.vmethod_39().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_39().DataPropertyName = "MarkViolatorAs";
			dataGridViewCellStyle6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_39().DefaultCellStyle = dataGridViewCellStyle6;
			this.vmethod_39().HeaderText = "闯入者视为:";
			this.vmethod_39().Name = "Points";
			this.vmethod_39().ReadOnly = true;
			this.vmethod_41().DataPropertyName = "IsActive";
			dataGridViewCellStyle7.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			dataGridViewCellStyle7.NullValue = false;
			this.vmethod_41().DefaultCellStyle = dataGridViewCellStyle7;
			this.vmethod_41().HeaderText = "启用";
			this.vmethod_41().Name = "Active";
			this.vmethod_41().ReadOnly = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(655, 548);
			base.Controls.Add(this.vmethod_33());
			base.Controls.Add(this.vmethod_29());
			base.Controls.Add(this.vmethod_31());
			base.Controls.Add(this.vmethod_27());
			base.Controls.Add(this.vmethod_25());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_10());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ExclusionZonesWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "编辑封锁区";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002536 RID: 9526
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace Command
{
	// Token: 0x02000A11 RID: 2577
	
	public sealed partial class NoNavZonesWindow : global::ns33.CommandForm
	{
		// Token: 0x06004F4A RID: 20298 RVA: 0x001FE8F8 File Offset: 0x001FCAF8
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

		// Token: 0x06004F4B RID: 20299 RVA: 0x001FE93C File Offset: 0x001FCB3C
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_1(new global::System.Windows.Forms.DataGridView());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.CheckBox());
			this.vmethod_9(new global::System.Windows.Forms.CheckBox());
			this.vmethod_11(new global::System.Windows.Forms.CheckBox());
			this.vmethod_13(new global::System.Windows.Forms.Label());
			this.vmethod_15(new global::System.Windows.Forms.CheckBox());
			this.vmethod_17(new global::System.Windows.Forms.TextBox());
			this.vmethod_19(new global::System.Windows.Forms.Label());
			this.vmethod_21(new global::System.Windows.Forms.Button());
			this.vmethod_23(new global::System.Windows.Forms.Button());
			this.vmethod_25(new global::System.Windows.Forms.CheckBox());
			this.vmethod_5(new global::ns33.AreaEditor());
			this.vmethod_27(new global::System.Windows.Forms.Button());
			this.vmethod_29(new global::System.Windows.Forms.Button());
			this.vmethod_31(new global::System.Windows.Forms.CheckBox());
			this.vmethod_33(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_35(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_37(new global::System.Windows.Forms.DataGridViewCheckBoxColumn());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
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
				this.vmethod_32(),
				this.vmethod_34(),
				this.vmethod_36()
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
			this.vmethod_0().Location = new global::System.Drawing.Point(0, -1);
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
			this.vmethod_0().Size = new global::System.Drawing.Size(654, 373);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_2().Location = new global::System.Drawing.Point(6, 385);
			this.vmethod_2().Name = "Label4";
			this.vmethod_2().Size = new global::System.Drawing.Size(116, 18);
			this.vmethod_2().TabIndex = 26;
			this.vmethod_2().Text = "选定区域";
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_6().AutoSize = true;
			this.vmethod_6().Location = new global::System.Drawing.Point(70, 452);
			this.vmethod_6().Name = "CB_Facility";
			this.vmethod_6().Size = new global::System.Drawing.Size(75, 17);
			this.vmethod_6().TabIndex = 24;
			this.vmethod_6().Text = "地面单元";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_8().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_8().AutoSize = true;
			this.vmethod_8().Location = new global::System.Drawing.Point(14, 452);
			this.vmethod_8().Name = "CB_Submarine";
			this.vmethod_8().Size = new global::System.Drawing.Size(81, 17);
			this.vmethod_8().TabIndex = 23;
			this.vmethod_8().Text = "潜艇";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(70, 429);
			this.vmethod_10().Name = "CB_Ship";
			this.vmethod_10().Size = new global::System.Drawing.Size(52, 17);
			this.vmethod_10().TabIndex = 22;
			this.vmethod_10().Text = "水面舰艇";
			this.vmethod_10().UseVisualStyleBackColor = true;
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Location = new global::System.Drawing.Point(11, 510);
			this.vmethod_12().Name = "Label1";
			this.vmethod_12().Size = new global::System.Drawing.Size(63, 13);
			this.vmethod_12().TabIndex = 14;
			this.vmethod_12().Text = "描述:";
			this.vmethod_14().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Location = new global::System.Drawing.Point(14, 429);
			this.vmethod_14().Name = "CB_Aircraft";
			this.vmethod_14().Size = new global::System.Drawing.Size(59, 17);
			this.vmethod_14().TabIndex = 21;
			this.vmethod_14().Text = "飞机";
			this.vmethod_14().UseVisualStyleBackColor = true;
			this.vmethod_16().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_16().Location = new global::System.Drawing.Point(107, 507);
			this.vmethod_16().Name = "TB_Description";
			this.vmethod_16().Size = new global::System.Drawing.Size(178, 20);
			this.vmethod_16().TabIndex = 15;
			this.vmethod_18().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_18().AutoSize = true;
			this.vmethod_18().Location = new global::System.Drawing.Point(13, 414);
			this.vmethod_18().Name = "Label3";
			this.vmethod_18().Size = new global::System.Drawing.Size(60, 13);
			this.vmethod_18().TabIndex = 20;
			this.vmethod_18().Text = "应用于:";
			this.vmethod_20().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_20().Location = new global::System.Drawing.Point(297, 526);
			this.vmethod_20().Name = "Button_SetDescription";
			this.vmethod_20().Size = new global::System.Drawing.Size(47, 21);
			this.vmethod_20().TabIndex = 19;
			this.vmethod_20().Text = "保存";
			this.vmethod_20().UseVisualStyleBackColor = true;
			this.vmethod_22().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_22().BackColor = global::System.Drawing.Color.Red;
			this.vmethod_22().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_22().Location = new global::System.Drawing.Point(350, 523);
			this.vmethod_22().Name = "Button2";
			this.vmethod_22().Size = new global::System.Drawing.Size(75, 27);
			this.vmethod_22().TabIndex = 18;
			this.vmethod_22().Text = "删除";
			this.vmethod_22().UseVisualStyleBackColor = false;
			this.vmethod_24().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_24().AutoSize = true;
			this.vmethod_24().Location = new global::System.Drawing.Point(14, 482);
			this.vmethod_24().Name = "CB_IsLocked";
			this.vmethod_24().Size = new global::System.Drawing.Size(194, 17);
			this.vmethod_24().TabIndex = 27;
			this.vmethod_24().Text = "区域已锁定(对阵人员不能编辑)";
			this.vmethod_24().UseVisualStyleBackColor = true;
			this.vmethod_4().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_4().Location = new global::System.Drawing.Point(295, 373);
			this.vmethod_4().Name = "AreaEditor1";
			this.vmethod_4().Size = new global::System.Drawing.Size(351, 124);
			this.vmethod_4().TabIndex = 25;
			this.vmethod_4().method_0(null);
			this.vmethod_26().Location = new global::System.Drawing.Point(428, 525);
			this.vmethod_26().Name = "ExportZone";
			this.vmethod_26().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_26().TabIndex = 28;
			this.vmethod_26().Text = "导出";
			this.vmethod_26().UseVisualStyleBackColor = true;
			this.vmethod_28().Location = new global::System.Drawing.Point(507, 525);
			this.vmethod_28().Name = "ImportZone";
			this.vmethod_28().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_28().TabIndex = 29;
			this.vmethod_28().Text = "导入";
			this.vmethod_28().UseVisualStyleBackColor = true;
			this.vmethod_30().AutoSize = true;
			this.vmethod_30().Location = new global::System.Drawing.Point(303, 502);
			this.vmethod_30().Name = "CB_VisibleRP";
			this.vmethod_30().Size = new global::System.Drawing.Size(141, 17);
			this.vmethod_30().TabIndex = 30;
			this.vmethod_30().Text = "可见参考点";
			this.vmethod_30().UseVisualStyleBackColor = true;
			this.vmethod_32().DataPropertyName = "ID";
			this.vmethod_32().HeaderText = "标识";
			this.vmethod_32().Name = "ID";
			this.vmethod_32().ReadOnly = true;
			this.vmethod_32().Visible = false;
			this.vmethod_34().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_34().DataPropertyName = "Description";
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_34().DefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_34().HeaderText = "说明";
			this.vmethod_34().Name = "Description";
			this.vmethod_34().ReadOnly = true;
			this.vmethod_36().DataPropertyName = "IsActive";
			dataGridViewCellStyle5.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			dataGridViewCellStyle5.NullValue = false;
			this.vmethod_36().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_36().HeaderText = "启用";
			this.vmethod_36().Name = "Active";
			this.vmethod_36().ReadOnly = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(655, 552);
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "NoNavZonesWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "编辑禁航区";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002563 RID: 9571
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

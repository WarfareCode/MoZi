namespace Command
{
	// Token: 0x02000985 RID: 2437
	public sealed partial class ListSpecialActions : global::ns33.CommandForm
	{
		// Token: 0x06003D24 RID: 15652 RVA: 0x0013AEBC File Offset: 0x001390BC
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

		// Token: 0x06003D25 RID: 15653 RVA: 0x0013AF00 File Offset: 0x00139100
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_1(new global::System.Windows.Forms.DataGridView());
			this.vmethod_13(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_15(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_17(new global::System.Windows.Forms.DataGridViewCheckBoxColumn());
			this.vmethod_19(new global::System.Windows.Forms.DataGridViewCheckBoxColumn());
			this.vmethod_3(new global::System.Windows.Forms.Button());
			this.vmethod_5(new global::System.Windows.Forms.Button());
			this.vmethod_7(new global::System.Windows.Forms.Button());
			this.vmethod_9(new global::System.Windows.Forms.Button());
			this.vmethod_11(new global::System.Windows.Forms.Label());
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
				this.vmethod_12(),
				this.vmethod_14(),
				this.vmethod_16(),
				this.vmethod_18()
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
			this.vmethod_0().Location = new global::System.Drawing.Point(3, 3);
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
			this.vmethod_0().Size = new global::System.Drawing.Size(496, 365);
			this.vmethod_0().TabIndex = 3;
			this.vmethod_12().DataPropertyName = "ID";
			this.vmethod_12().HeaderText = "ID";
			this.vmethod_12().Name = "ID";
			this.vmethod_12().ReadOnly = true;
			this.vmethod_12().Visible = false;
			this.vmethod_14().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_14().DataPropertyName = "Name";
			this.vmethod_14().HeaderText = "名称";
			this.vmethod_14().Name = "ActionName";
			this.vmethod_14().ReadOnly = true;
			this.vmethod_16().DataPropertyName = "IsActive";
			this.vmethod_16().HeaderText = "启用";
			this.vmethod_16().Name = "IsActive";
			this.vmethod_16().ReadOnly = true;
			this.vmethod_18().DataPropertyName = "IsRepeatable";
			this.vmethod_18().HeaderText = "可重复";
			this.vmethod_18().Name = "IsRepeatable";
			this.vmethod_18().ReadOnly = true;
			this.GetButton_EditSelected().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.GetButton_EditSelected().Location = new global::System.Drawing.Point(276, 373);
			this.GetButton_EditSelected().Name = "Button_EditSelected";
			this.GetButton_EditSelected().Size = new global::System.Drawing.Size(110, 21);
			this.GetButton_EditSelected().TabIndex = 14;
			this.GetButton_EditSelected().Text = "编辑所选";
			this.GetButton_EditSelected().UseVisualStyleBackColor = true;
			this.GetButton_DeleteSelected().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.GetButton_DeleteSelected().Location = new global::System.Drawing.Point(392, 373);
			this.GetButton_DeleteSelected().Name = "Button_DeleteSelected";
			this.GetButton_DeleteSelected().Size = new global::System.Drawing.Size(105, 21);
			this.GetButton_DeleteSelected().TabIndex = 13;
			this.GetButton_DeleteSelected().Text = "删除所选";
			this.GetButton_DeleteSelected().UseVisualStyleBackColor = true;
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_6().Location = new global::System.Drawing.Point(3, 373);
			this.vmethod_6().Name = "Button1";
			this.vmethod_6().Size = new global::System.Drawing.Size(145, 21);
			this.vmethod_6().TabIndex = 12;
			this.vmethod_6().Text = "创建新的特殊事件";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.GetButton_CloneSelected().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.GetButton_CloneSelected().Location = new global::System.Drawing.Point(154, 373);
			this.GetButton_CloneSelected().Name = "Button_CloneSelected";
			this.GetButton_CloneSelected().Size = new global::System.Drawing.Size(116, 21);
			this.GetButton_CloneSelected().TabIndex = 16;
			this.GetButton_CloneSelected().Text = "克隆所选";
			this.GetButton_CloneSelected().UseVisualStyleBackColor = true;
			this.vmethod_10().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(505, 9);
			this.vmethod_10().MaximumSize = new global::System.Drawing.Size(185, 0);
			this.vmethod_10().Name = "Label_ActionDescription";
			this.vmethod_10().Size = new global::System.Drawing.Size(39, 13);
			this.vmethod_10().TabIndex = 17;
			this.vmethod_10().Text = "Label1";
			this.vmethod_10().Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(693, 397);
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.GetButton_CloneSelected());
			base.Controls.Add(this.GetButton_EditSelected());
			base.Controls.Add(this.GetButton_DeleteSelected());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ListSpecialActions";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "本方特殊事件";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001BDC RID: 7132
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace Command
{
	// Token: 0x02000997 RID: 2455
	public sealed partial class ListEvents : global::ns33.CommandForm
	{
		// Token: 0x06003E58 RID: 15960 RVA: 0x001468B0 File Offset: 0x00144AB0
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

		// Token: 0x06003E59 RID: 15961 RVA: 0x001468F4 File Offset: 0x00144AF4
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_1(new global::System.Windows.Forms.DataGridView());
			this.vmethod_9(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_11(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_13(new global::System.Windows.Forms.DataGridViewCheckBoxColumn());
			this.vmethod_15(new global::System.Windows.Forms.DataGridViewCheckBoxColumn());
			this.vmethod_17(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_3(new global::System.Windows.Forms.Button());
			this.vmethod_5(new global::System.Windows.Forms.Button());
			this.vmethod_7(new global::System.Windows.Forms.Button());
			this.vmethod_19(new global::System.Windows.Forms.Button());
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
				this.vmethod_8(),
				this.vmethod_10(),
				this.vmethod_12(),
				this.vmethod_14(),
				this.vmethod_16()
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
			this.vmethod_0().Location = new global::System.Drawing.Point(2, 2);
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
			this.vmethod_0().Size = new global::System.Drawing.Size(678, 361);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_8().DataPropertyName = "ID";
			this.vmethod_8().HeaderText = "ID";
			this.vmethod_8().Name = "ID";
			this.vmethod_8().ReadOnly = true;
			this.vmethod_8().Visible = false;
			this.vmethod_10().DataPropertyName = "Description";
			this.vmethod_10().HeaderText = "说明";
			this.vmethod_10().Name = "Description";
			this.vmethod_10().ReadOnly = true;
			this.vmethod_10().Width = 335;
			this.vmethod_12().DataPropertyName = "IsRepeatable";
			this.vmethod_12().HeaderText = "可重复";
			this.vmethod_12().Name = "IsRepeatable";
			this.vmethod_12().ReadOnly = true;
			this.vmethod_14().DataPropertyName = "IsActive";
			this.vmethod_14().HeaderText = "启用";
			this.vmethod_14().Name = "IsActive";
			this.vmethod_14().ReadOnly = true;
			this.vmethod_16().DataPropertyName = "Probability";
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.vmethod_16().DefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_16().HeaderText = "发生概率(%)";
			this.vmethod_16().Name = "Probability";
			this.vmethod_16().ReadOnly = true;
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_2().Location = new global::System.Drawing.Point(432, 369);
			this.vmethod_2().Name = "Button_EditSelected";
			this.vmethod_2().Size = new global::System.Drawing.Size(121, 21);
			this.vmethod_2().TabIndex = 7;
			this.vmethod_2().Text = "编辑所选";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_4().Location = new global::System.Drawing.Point(559, 369);
			this.vmethod_4().Name = "Button_DeleteSelected";
			this.vmethod_4().Size = new global::System.Drawing.Size(121, 21);
			this.vmethod_4().TabIndex = 6;
			this.vmethod_4().Text = "删除所选";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_6().Location = new global::System.Drawing.Point(2, 369);
			this.vmethod_6().Name = "Button1";
			this.vmethod_6().Size = new global::System.Drawing.Size(133, 21);
			this.vmethod_6().TabIndex = 5;
			this.vmethod_6().Text = "创建新事件";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_18().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_18().Location = new global::System.Drawing.Point(305, 369);
			this.vmethod_18().Name = "Button_CloneSelected";
			this.vmethod_18().Size = new global::System.Drawing.Size(121, 21);
			this.vmethod_18().TabIndex = 8;
			this.vmethod_18().Text = "克隆所选";
			this.vmethod_18().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(682, 392);
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ListEvents";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "事件";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001CA9 RID: 7337
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

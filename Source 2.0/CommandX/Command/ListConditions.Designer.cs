namespace Command
{
	// Token: 0x02000B6F RID: 2927
	
	public sealed partial class ListConditions : global::ns33.CommandForm
	{
		// Token: 0x060060D8 RID: 24792 RVA: 0x002E0D28 File Offset: 0x002DEF28
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

		// Token: 0x060060D9 RID: 24793 RVA: 0x002E0D6C File Offset: 0x002DEF6C
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_1(new global::System.Windows.Forms.DataGridView());
			this.vmethod_3(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_5(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_7(new global::System.Windows.Forms.ComboBox());
			this.vmethod_9(new global::System.Windows.Forms.Button());
			this.vmethod_11(new global::System.Windows.Forms.Button());
			this.vmethod_13(new global::System.Windows.Forms.Button());
			this.vmethod_15(new global::System.Windows.Forms.Button());
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
				this.vmethod_2(),
				this.vmethod_4()
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
			this.vmethod_0().Size = new global::System.Drawing.Size(655, 365);
			this.vmethod_0().TabIndex = 3;
			this.vmethod_2().DataPropertyName = "ID";
			this.vmethod_2().HeaderText = "ID";
			this.vmethod_2().Name = "ID";
			this.vmethod_2().ReadOnly = true;
			this.vmethod_2().Visible = false;
			this.vmethod_4().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_4().DataPropertyName = "Description";
			this.vmethod_4().HeaderText = "描述";
			this.vmethod_4().Name = "Description";
			this.vmethod_4().ReadOnly = true;
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_6().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_6().FormattingEnabled = true;
			this.vmethod_6().Items.AddRange(new object[]
			{
				"Side Posture",
				"Scenario Has Started",
				"Lua Script"
			});
			this.vmethod_6().Location = new global::System.Drawing.Point(115, 374);
			this.vmethod_6().Name = "CB_ConditionType";
			this.vmethod_6().Size = new global::System.Drawing.Size(173, 21);
			this.vmethod_6().TabIndex = 15;
			this.vmethod_8().Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.vmethod_8().Location = new global::System.Drawing.Point(435, 373);
			this.vmethod_8().Name = "Button_EditSelected";
			this.vmethod_8().Size = new global::System.Drawing.Size(107, 21);
			this.vmethod_8().TabIndex = 14;
			this.vmethod_8().Text = "编辑选定条件";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_10().Location = new global::System.Drawing.Point(548, 373);
			this.vmethod_10().Name = "Button_DeleteSelected";
			this.vmethod_10().Size = new global::System.Drawing.Size(110, 21);
			this.vmethod_10().TabIndex = 13;
			this.vmethod_10().Text = "删除所选";
			this.vmethod_10().UseVisualStyleBackColor = true;
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_12().Location = new global::System.Drawing.Point(3, 374);
			this.vmethod_12().Name = "Button1";
			this.vmethod_12().Size = new global::System.Drawing.Size(106, 21);
			this.vmethod_12().TabIndex = 12;
			this.vmethod_12().Text = "创建新条件:";
			this.vmethod_12().UseVisualStyleBackColor = true;
			this.vmethod_14().Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.vmethod_14().Location = new global::System.Drawing.Point(318, 373);
			this.vmethod_14().Name = "Button_CloneSelected";
			this.vmethod_14().Size = new global::System.Drawing.Size(111, 21);
			this.vmethod_14().TabIndex = 16;
			this.vmethod_14().Text = "克隆所选";
			this.vmethod_14().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(661, 397);
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ListConditions";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "事件条件";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400341D RID: 13341
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

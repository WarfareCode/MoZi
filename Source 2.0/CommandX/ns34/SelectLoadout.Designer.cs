namespace ns34
{
	// Token: 0x02000A45 RID: 2629
	
	public sealed partial class SelectLoadout : global::ns33.CommandForm
	{
		// Token: 0x0600537A RID: 21370 RVA: 0x00222FD4 File Offset: 0x002211D4
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

		// Token: 0x0600537B RID: 21371 RVA: 0x00223018 File Offset: 0x00221218
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_1(new global::System.Windows.Forms.DataGridView());
			this.vmethod_3(new global::System.Windows.Forms.DataGridView());
			this.vmethod_11(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_13(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_15(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_17(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_19(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_21(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.Button());
			this.vmethod_9(new global::System.Windows.Forms.Button());
			this.vmethod_23(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_25(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_27(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_2()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AllowUserToResizeRows = false;
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
				this.vmethod_22(),
				this.vmethod_24(),
				this.vmethod_26()
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Top;
			this.vmethod_0().EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DGV_Loadouts";
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_0().RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().RowHeadersWidth = 10;
			this.vmethod_0().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new global::System.Drawing.Size(442, 279);
			this.vmethod_0().TabIndex = 7;
			this.vmethod_2().AllowUserToAddRows = false;
			this.vmethod_2().AllowUserToDeleteRows = false;
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_2().AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.vmethod_2().AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.vmethod_2().BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_2().BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.vmethod_2().CausesValidation = false;
			this.vmethod_2().CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_2().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_2().ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_2().ColumnHeadersVisible = false;
			this.vmethod_2().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_10(),
				this.vmethod_12(),
				this.vmethod_14(),
				this.vmethod_16(),
				this.vmethod_18(),
				this.vmethod_20()
			});
			dataGridViewCellStyle5.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = global::System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle5.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.SelectionForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle5.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.vmethod_2().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_2().EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.vmethod_2().Enabled = false;
			this.vmethod_2().EnableHeadersVisualStyles = false;
			this.vmethod_2().Location = new global::System.Drawing.Point(3, 302);
			this.vmethod_2().MultiSelect = false;
			this.vmethod_2().Name = "DGV_LoadoutItems";
			dataGridViewCellStyle6.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle6.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_2().RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.vmethod_2().RowHeadersVisible = false;
			this.vmethod_2().RowHeadersWidth = 4;
			this.vmethod_2().RowTemplate.DefaultCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_2().RowTemplate.Height = 15;
			this.vmethod_2().RowTemplate.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.vmethod_2().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_2().Size = new global::System.Drawing.Size(427, 115);
			this.vmethod_2().TabIndex = 9;
			this.vmethod_10().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_10().DataPropertyName = "ID";
			this.vmethod_10().HeaderText = "ID";
			this.vmethod_10().Name = "DataGridViewTextBoxColumn1";
			this.vmethod_10().Visible = false;
			this.vmethod_12().DataPropertyName = "ComponentID";
			this.vmethod_12().HeaderText = "ComponentID";
			this.vmethod_12().Name = "ComponentID";
			this.vmethod_12().Visible = false;
			this.vmethod_12().Width = 5;
			this.vmethod_14().DataPropertyName = "Quantity";
			this.vmethod_14().HeaderText = "数量";
			this.vmethod_14().Name = "Quantity";
			this.vmethod_14().Visible = false;
			this.vmethod_14().Width = 5;
			this.vmethod_16().DataPropertyName = "Fill";
			this.vmethod_16().HeaderText = "Item";
			this.vmethod_16().Name = "Item";
			this.vmethod_16().Width = 5;
			this.vmethod_18().DataPropertyName = "Internal";
			this.vmethod_18().HeaderText = "Internal";
			this.vmethod_18().Name = "Internal";
			this.vmethod_18().Visible = false;
			this.vmethod_18().Width = 5;
			this.vmethod_20().DataPropertyName = "Optional";
			this.vmethod_20().HeaderText = "可选武器";
			this.vmethod_20().Name = "OptionalWeapon";
			this.vmethod_20().Visible = false;
			this.vmethod_20().Width = 5;
			this.vmethod_4().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_4().Location = new global::System.Drawing.Point(0, 286);
			this.vmethod_4().Name = "Label1";
			this.vmethod_4().Size = new global::System.Drawing.Size(90, 13);
			this.vmethod_4().TabIndex = 10;
			this.vmethod_4().Text = "挂载项:";
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_6().Location = new global::System.Drawing.Point(12, 432);
			this.vmethod_6().Name = "Button1";
			this.vmethod_6().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_6().TabIndex = 11;
			this.vmethod_6().Text = "确认";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_8().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_8().DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.vmethod_8().Location = new global::System.Drawing.Point(355, 429);
			this.vmethod_8().Name = "Button2";
			this.vmethod_8().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_8().TabIndex = 12;
			this.vmethod_8().Text = "取消";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_22().DataPropertyName = "ID";
			this.vmethod_22().HeaderText = "ID";
			this.vmethod_22().Name = "ID";
			this.vmethod_22().ReadOnly = true;
			this.vmethod_22().Visible = false;
			this.vmethod_24().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_24().DataPropertyName = "Name";
			dataGridViewCellStyle7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_24().DefaultCellStyle = dataGridViewCellStyle7;
			this.vmethod_24().HeaderText = "挂载";
			this.vmethod_24().Name = "Loadout";
			this.vmethod_24().ReadOnly = true;
			this.vmethod_26().DataPropertyName = "AttackAltitude";
			dataGridViewCellStyle8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_26().DefaultCellStyle = dataGridViewCellStyle8;
			this.vmethod_26().HeaderText = "攻击高度";
			this.vmethod_26().Name = "AttackAltitude";
			this.vmethod_26().ReadOnly = true;
			base.AcceptButton = this.vmethod_6();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.vmethod_8();
			base.ClientSize = new global::System.Drawing.Size(442, 464);
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SelectLoadout";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "选择挂载";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_2()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400272E RID: 10030
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace Command
{
	// Token: 0x020009C5 RID: 2501

	public sealed partial class EditBoats : global::ns33.CommandForm
	{
		// Token: 0x0600438C RID: 17292 RVA: 0x0018B944 File Offset: 0x00189B44
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

		// Token: 0x0600438D RID: 17293 RVA: 0x0018B988 File Offset: 0x00189B88
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_1(new global::System.Windows.Forms.GroupBox());
			this.vmethod_47(new global::System.Windows.Forms.ComboBox());
			this.vmethod_49(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.ComboBox());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.Label());
			this.vmethod_9(new global::System.Windows.Forms.TextBox());
			this.vmethod_11(new global::System.Windows.Forms.DataGridView());
			this.vmethod_33(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_35(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_37(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_39(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_41(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_43(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_45(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_13(new global::System.Windows.Forms.Button());
			this.vmethod_15(new global::System.Windows.Forms.GroupBox());
			this.vmethod_17(new global::System.Windows.Forms.NumericUpDown());
			this.vmethod_19(new global::System.Windows.Forms.Button());
			this.vmethod_21(new global::System.Windows.Forms.TextBox());
			this.vmethod_23(new global::System.Windows.Forms.Label());
			this.vmethod_25(new global::System.Windows.Forms.Button());
			this.vmethod_27(new global::System.Windows.Forms.Label());
			this.vmethod_29(new global::System.Windows.Forms.Label());
			this.vmethod_31(new global::System.Windows.Forms.ListView());
			this.vmethod_0().SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_10()).BeginInit();
			this.vmethod_14().SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_16()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Controls.Add(this.vmethod_46());
			this.vmethod_0().Controls.Add(this.vmethod_48());
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Controls.Add(this.vmethod_4());
			this.vmethod_0().Controls.Add(this.vmethod_6());
			this.vmethod_0().Controls.Add(this.vmethod_8());
			this.vmethod_0().Location = new global::System.Drawing.Point(296, 29);
			this.vmethod_0().Name = "GroupBox1";
			this.vmethod_0().Size = new global::System.Drawing.Size(584, 66);
			this.vmethod_0().TabIndex = 34;
			this.vmethod_0().TabStop = false;
			this.vmethod_0().Text = "Filter by...";
			this.vmethod_46().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_46().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_46().FormattingEnabled = true;
			this.vmethod_46().Items.AddRange(new object[]
			{
				"Ship",
				"Submarine"
			});
			this.vmethod_46().Location = new global::System.Drawing.Point(51, 43);
			this.vmethod_46().Name = "ComboBox1";
			this.vmethod_46().Size = new global::System.Drawing.Size(256, 21);
			this.vmethod_46().TabIndex = 15;
			this.vmethod_48().Location = new global::System.Drawing.Point(6, 47);
			this.vmethod_48().Name = "Label4";
			this.vmethod_48().Size = new global::System.Drawing.Size(34, 13);
			this.vmethod_48().TabIndex = 14;
			this.vmethod_48().Text = "Type:";
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_2().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_2().FormattingEnabled = true;
			this.vmethod_2().Items.AddRange(new object[]
			{
				"Aircraft"
			});
			this.vmethod_2().Location = new global::System.Drawing.Point(365, 16);
			this.vmethod_2().Name = "CB_Country";
			this.vmethod_2().Size = new global::System.Drawing.Size(213, 21);
			this.vmethod_2().TabIndex = 13;
			this.vmethod_4().Location = new global::System.Drawing.Point(313, 20);
			this.vmethod_4().Name = "Label3";
			this.vmethod_4().Size = new global::System.Drawing.Size(46, 13);
			this.vmethod_4().TabIndex = 12;
			this.vmethod_4().Text = "Country:";
			this.vmethod_6().Location = new global::System.Drawing.Point(7, 20);
			this.vmethod_6().Name = "Label6";
			this.vmethod_6().Size = new global::System.Drawing.Size(35, 13);
			this.vmethod_6().TabIndex = 11;
			this.vmethod_6().Text = "Class:";
			this.vmethod_8().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_8().Location = new global::System.Drawing.Point(51, 17);
			this.vmethod_8().Name = "TB_Class";
			this.vmethod_8().Size = new global::System.Drawing.Size(256, 20);
			this.vmethod_8().TabIndex = 10;
			this.vmethod_10().AllowUserToAddRows = false;
			this.vmethod_10().AllowUserToDeleteRows = false;
			this.vmethod_10().AllowUserToResizeColumns = false;
			this.vmethod_10().AllowUserToResizeRows = false;
			this.vmethod_10().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_10().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_10().ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_10().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_32(),
				this.vmethod_34(),
				this.vmethod_36(),
				this.vmethod_38(),
				this.vmethod_40(),
				this.vmethod_42(),
				this.vmethod_44()
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.vmethod_10().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_10().EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.vmethod_10().Location = new global::System.Drawing.Point(297, 101);
			this.vmethod_10().MultiSelect = false;
			this.vmethod_10().Name = "DataGridView1";
			this.vmethod_10().ReadOnly = true;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_10().RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_10().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_10().Size = new global::System.Drawing.Size(583, 525);
			this.vmethod_10().TabIndex = 33;
			this.vmethod_32().DataPropertyName = "ID";
			this.vmethod_32().HeaderText = "ID";
			this.vmethod_32().Name = "DataGridViewTextBoxColumn1";
			this.vmethod_32().ReadOnly = true;
			this.vmethod_32().Visible = false;
			this.vmethod_34().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_34().DataPropertyName = "LongName";
			this.vmethod_34().HeaderText = "Class";
			this.vmethod_34().Name = "DataGridViewTextBoxColumn2";
			this.vmethod_34().ReadOnly = true;
			this.vmethod_36().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_36().DataPropertyName = "CountryString";
			this.vmethod_36().HeaderText = "Country";
			this.vmethod_36().Name = "Country";
			this.vmethod_36().ReadOnly = true;
			this.vmethod_36().Width = 66;
			this.vmethod_38().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_38().DataPropertyName = "YearCommissioned";
			this.vmethod_38().HeaderText = "From";
			this.vmethod_38().Name = "IOC";
			this.vmethod_38().ReadOnly = true;
			this.vmethod_38().Width = 53;
			this.vmethod_40().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_40().DataPropertyName = "YearDecommissioned";
			this.vmethod_40().HeaderText = "Until";
			this.vmethod_40().Name = "Retired";
			this.vmethod_40().ReadOnly = true;
			this.vmethod_40().Width = 51;
			this.vmethod_42().DataPropertyName = "OperatorCountry";
			this.vmethod_42().HeaderText = "Column1";
			this.vmethod_42().Name = "CountryNumber";
			this.vmethod_42().ReadOnly = true;
			this.vmethod_42().Visible = false;
			this.vmethod_44().DataPropertyName = "Name";
			this.vmethod_44().HeaderText = "Column2";
			this.vmethod_44().Name = "Column2";
			this.vmethod_44().ReadOnly = true;
			this.vmethod_44().Visible = false;
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_12().BackColor = global::System.Drawing.Color.Red;
			this.vmethod_12().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_12().ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.vmethod_12().Location = new global::System.Drawing.Point(190, 636);
			this.vmethod_12().Name = "Button_RemoveBoat";
			this.vmethod_12().Size = new global::System.Drawing.Size(100, 37);
			this.vmethod_12().TabIndex = 32;
			this.vmethod_12().Text = "Remove selected";
			this.vmethod_12().UseVisualStyleBackColor = false;
			this.vmethod_14().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_14().Controls.Add(this.vmethod_16());
			this.vmethod_14().Controls.Add(this.vmethod_18());
			this.vmethod_14().Location = new global::System.Drawing.Point(12, 632);
			this.vmethod_14().Name = "Quantity";
			this.vmethod_14().Size = new global::System.Drawing.Size(155, 41);
			this.vmethod_14().TabIndex = 31;
			this.vmethod_14().TabStop = false;
			this.vmethod_14().Text = "Quantity";
			this.vmethod_16().Location = new global::System.Drawing.Point(6, 16);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.vmethod_16();
			int[] array = new int[4];
			array[0] = 99999999;
			numericUpDown.Maximum = new decimal(array);
			this.vmethod_16().Name = "NUD1";
			this.vmethod_16().Size = new global::System.Drawing.Size(74, 20);
			this.vmethod_16().TabIndex = 10;
			this.vmethod_18().Location = new global::System.Drawing.Point(85, 15);
			this.vmethod_18().Name = "Button2";
			this.vmethod_18().Size = new global::System.Drawing.Size(65, 22);
			this.vmethod_18().TabIndex = 16;
			this.vmethod_18().Text = "Apply";
			this.vmethod_18().UseVisualStyleBackColor = true;
			this.vmethod_20().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_20().Location = new global::System.Drawing.Point(624, 646);
			this.vmethod_20().Name = "TB_Quantity";
			this.vmethod_20().Size = new global::System.Drawing.Size(114, 20);
			this.vmethod_20().TabIndex = 30;
			this.vmethod_22().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_22().Location = new global::System.Drawing.Point(564, 650);
			this.vmethod_22().Name = "Label5";
			this.vmethod_22().Size = new global::System.Drawing.Size(60, 13);
			this.vmethod_22().TabIndex = 29;
			this.vmethod_22().Text = "How many:";
			this.vmethod_24().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_24().Location = new global::System.Drawing.Point(769, 644);
			this.vmethod_24().Name = "Button1";
			this.vmethod_24().Size = new global::System.Drawing.Size(111, 20);
			this.vmethod_24().TabIndex = 28;
			this.vmethod_24().Text = "Add Selected";
			this.vmethod_24().UseVisualStyleBackColor = true;
			this.vmethod_26().Location = new global::System.Drawing.Point(294, 10);
			this.vmethod_26().Name = "Label2";
			this.vmethod_26().Size = new global::System.Drawing.Size(70, 13);
			this.vmethod_26().TabIndex = 25;
			this.vmethod_26().Text = "Boats to add:";
			this.vmethod_28().Location = new global::System.Drawing.Point(12, 10);
			this.vmethod_28().Name = "Label1";
			this.vmethod_28().Size = new global::System.Drawing.Size(87, 13);
			this.vmethod_28().TabIndex = 24;
			this.vmethod_28().Text = "Current inventory";
			this.vmethod_30().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_30().HideSelection = false;
			this.vmethod_30().Location = new global::System.Drawing.Point(12, 29);
			this.vmethod_30().MultiSelect = false;
			this.vmethod_30().Name = "ListView1";
			this.vmethod_30().Size = new global::System.Drawing.Size(278, 597);
			this.vmethod_30().TabIndex = 23;
			this.vmethod_30().UseCompatibleStateImageBehavior = false;
			this.vmethod_30().View = global::System.Windows.Forms.View.List;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(892, 679);
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_30());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditBoats";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "编辑停靠的舰船";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_0().PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_10()).EndInit();
			this.vmethod_14().ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_16()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001FA1 RID: 8097
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

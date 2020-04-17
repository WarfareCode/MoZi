using System;
using System.Windows.Forms;

namespace Command
{
	// Token: 0x020009A6 RID: 2470
	public sealed partial class EditAC : global::ns33.CommandForm
	{
		// Token: 0x060040F4 RID: 16628 RVA: 0x001624E4 File Offset: 0x001606E4
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

		// Token: 0x060040F5 RID: 16629 RVA: 0x00162528 File Offset: 0x00160728
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.listView_0 = new global::System.Windows.Forms.ListView();this.listView_0.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(this.method_2);
			this.label_0 = new global::System.Windows.Forms.Label();
			this.label_1 = new global::System.Windows.Forms.Label();
			this.numericUpDown_0 = new global::System.Windows.Forms.NumericUpDown();
			this.textBox_0 = new global::System.Windows.Forms.TextBox();
			this.label_2 = new global::System.Windows.Forms.Label();
			this.button_0 = new global::System.Windows.Forms.Button();this.button_0.Click += new EventHandler(this.method_3);
			this.label_3 = new global::System.Windows.Forms.Label();
			this.textBox_1 = new global::System.Windows.Forms.TextBox();
			this.button_1 = new global::System.Windows.Forms.Button();this.button_1.Click += new EventHandler(this.method_4);
			this.groupBox_0 = new global::System.Windows.Forms.GroupBox();
			this.button_2 = new global::System.Windows.Forms.Button();this.button_2.Click += new EventHandler(this.method_5);
			this.dataGridView_0 = new global::System.Windows.Forms.DataGridView();this.dataGridView_0.KeyPress += new KeyPressEventHandler(this.method_6);
			this.dataGridViewTextBoxColumn_0 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn_0 = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox_1 = new global::System.Windows.Forms.GroupBox();
			this.comboBox_1 = new global::System.Windows.Forms.ComboBox();this.comboBox_1.SelectionChangeCommitted += new EventHandler(this.method_10);
			this.label_6 = new global::System.Windows.Forms.Label();
			this.checkBox_0 = new global::System.Windows.Forms.CheckBox();
			this.comboBox_0 = new global::System.Windows.Forms.ComboBox();this.comboBox_0.SelectedIndexChanged += new EventHandler(this.method_9);
			this.label_4 = new global::System.Windows.Forms.Label();
			this.label_5 = new global::System.Windows.Forms.Label();
			this.textBox_2 = new global::System.Windows.Forms.TextBox();this.textBox_2.TextChanged += new EventHandler(this.method_7);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown_0).BeginInit();
			this.groupBox_0.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView_0).BeginInit();
			this.groupBox_1.SuspendLayout();
			base.SuspendLayout();
			this.listView_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.listView_0.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.listView_0.HideSelection = false;
			this.listView_0.Location = new global::System.Drawing.Point(12, 34);
			this.listView_0.MultiSelect = false;
			this.listView_0.Name = "ListView1";
			this.listView_0.Size = new global::System.Drawing.Size(278, 583);
			this.listView_0.TabIndex = 0;
			this.listView_0.UseCompatibleStateImageBehavior = false;
			this.listView_0.View = global::System.Windows.Forms.View.List;
			this.label_0.Location = new global::System.Drawing.Point(12, 15);
			this.label_0.Name = "Label1";
			this.label_0.Size = new global::System.Drawing.Size(100, 13);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "当前飞机";
			this.label_1.Location = new global::System.Drawing.Point(294, 15);
			this.label_1.Name = "Label2";
			this.label_1.Size = new global::System.Drawing.Size(100, 13);
			this.label_1.TabIndex = 8;
			this.label_1.Text = "可添加的飞机:";
			this.numericUpDown_0.Location = new global::System.Drawing.Point(6, 16);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown_0;
			int[] array = new int[4];
			array[0] = 99999999;
            this.numericUpDown_0.Maximum = new decimal(array);
			this.numericUpDown_0.Name = "NUD1";
			this.numericUpDown_0.Size = new global::System.Drawing.Size(74, 20);
			this.numericUpDown_0.TabIndex = 10;
			this.textBox_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.textBox_0.Location = new global::System.Drawing.Point(423, 638);
			this.textBox_0.Name = "TB_Callsign";
			this.textBox_0.Size = new global::System.Drawing.Size(135, 20);
			this.textBox_0.TabIndex = 11;
			this.label_2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label_2.Location = new global::System.Drawing.Point(376, 642);
			this.label_2.Name = "Label4";
			this.label_2.Size = new global::System.Drawing.Size(46, 13);
			this.label_2.TabIndex = 12;
			this.label_2.Text = "呼号:";
			this.button_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.button_0.Location = new global::System.Drawing.Point(769, 638);
			this.button_0.Name = "Button1";
			this.button_0.Size = new global::System.Drawing.Size(111, 20);
			this.button_0.TabIndex = 13;
			this.button_0.Text = "添加所选";
			this.button_0.UseVisualStyleBackColor = true;
			this.label_3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label_3.Location = new global::System.Drawing.Point(564, 642);
			this.label_3.Name = "Label5";
			this.label_3.Size = new global::System.Drawing.Size(60, 13);
			this.label_3.TabIndex = 14;
			this.label_3.Text = "数量:";
			this.textBox_1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.textBox_1.Location = new global::System.Drawing.Point(624, 638);
			this.textBox_1.Name = "TB_Quantity";
			this.textBox_1.Size = new global::System.Drawing.Size(114, 20);
			this.textBox_1.TabIndex = 15;
			this.button_1.Location = new global::System.Drawing.Point(85, 15);
			this.button_1.Name = "Button2";
			this.button_1.Size = new global::System.Drawing.Size(65, 22);
			this.button_1.TabIndex = 16;
			this.button_1.Text = "应用";
			this.button_1.UseVisualStyleBackColor = true;
			this.groupBox_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.groupBox_0.Controls.Add(this.numericUpDown_0);
			this.groupBox_0.Controls.Add(this.button_1);
			this.groupBox_0.Location = new global::System.Drawing.Point(12, 624);
			this.groupBox_0.Name = "Quantity";
			this.groupBox_0.Size = new global::System.Drawing.Size(155, 41);
			this.groupBox_0.TabIndex = 17;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "数量";
			this.button_2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.button_2.BackColor = global::System.Drawing.Color.Red;
			this.button_2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.button_2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.button_2.Location = new global::System.Drawing.Point(190, 628);
			this.button_2.Name = "Button_RemoveAC";
			this.button_2.Size = new global::System.Drawing.Size(100, 37);
			this.button_2.TabIndex = 18;
			this.button_2.Text = "删除所选";
			this.button_2.UseVisualStyleBackColor = false;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToResizeColumns = false;
			this.dataGridView_0.AllowUserToResizeRows = false;
			this.dataGridView_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewCheckBoxColumn_0,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView_0.Location = new global::System.Drawing.Point(297, 131);
			this.dataGridView_0.MultiSelect = false;
			this.dataGridView_0.Name = "DataGridView1";
			this.dataGridView_0.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new global::System.Drawing.Size(658, 486);
			this.dataGridView_0.TabIndex = 21;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "ID";
			this.dataGridViewTextBoxColumn_0.HeaderText = "ID";
			this.dataGridViewTextBoxColumn_0.Name = "DataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "LongName";
			this.dataGridViewTextBoxColumn_1.HeaderText = "飞机";
			this.dataGridViewTextBoxColumn_1.Name = "DataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "CountryString";
			this.dataGridViewTextBoxColumn_2.HeaderText = "国家";
			this.dataGridViewTextBoxColumn_2.Name = "Country";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Width = 66;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "YearCommissioned";
			this.dataGridViewTextBoxColumn_3.HeaderText = "服役";
			this.dataGridViewTextBoxColumn_3.Name = "IOC";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Width = 53;
			this.dataGridViewTextBoxColumn_4.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "YearDecommissioned";
			this.dataGridViewTextBoxColumn_4.HeaderText = "退役";
			this.dataGridViewTextBoxColumn_4.Name = "Retired";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Width = 51;
			this.dataGridViewCheckBoxColumn_0.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewCheckBoxColumn_0.DataPropertyName = "Hypothetical";
			this.dataGridViewCheckBoxColumn_0.FalseValue = "False";
			this.dataGridViewCheckBoxColumn_0.HeaderText = "类别";
			this.dataGridViewCheckBoxColumn_0.Name = "Hypothetical";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.TrueValue = "True";
			this.dataGridViewCheckBoxColumn_0.Width = 36;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "OperatorCountry";
			this.dataGridViewTextBoxColumn_5.HeaderText = "Column1";
			this.dataGridViewTextBoxColumn_5.Name = "CountryNumber";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_6.HeaderText = "Column2";
			this.dataGridViewTextBoxColumn_6.Name = "Column2";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.groupBox_1.Controls.Add(this.comboBox_1);
			this.groupBox_1.Controls.Add(this.label_6);
			this.groupBox_1.Controls.Add(this.checkBox_0);
			this.groupBox_1.Controls.Add(this.comboBox_0);
			this.groupBox_1.Controls.Add(this.label_4);
			this.groupBox_1.Controls.Add(this.label_5);
			this.groupBox_1.Controls.Add(this.textBox_2);
			this.groupBox_1.Location = new global::System.Drawing.Point(296, 34);
			this.groupBox_1.Name = "GroupBox1";
			this.groupBox_1.Size = new global::System.Drawing.Size(659, 91);
			this.groupBox_1.TabIndex = 22;
			this.groupBox_1.TabStop = false;
			this.groupBox_1.Text = "过滤条件";
			this.comboBox_1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.comboBox_1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Items.AddRange(new object[]
			{
				"Aircraft"
			});
			this.comboBox_1.Location = new global::System.Drawing.Point(77, 41);
			this.comboBox_1.Name = "CB_Hypothetical";
			this.comboBox_1.Size = new global::System.Drawing.Size(258, 21);
			this.comboBox_1.TabIndex = 16;
			this.label_6.Location = new global::System.Drawing.Point(6, 45);
			this.label_6.Name = "Label7";
			this.label_6.Size = new global::System.Drawing.Size(69, 13);
			this.label_6.TabIndex = 15;
			this.label_6.Text = "类别:";
			this.checkBox_0.Location = new global::System.Drawing.Point(10, 69);
			this.checkBox_0.Name = "CB_FilterSizeAndTODLAD";
			this.checkBox_0.Size = new global::System.Drawing.Size(239, 17);
			this.checkBox_0.TabIndex = 14;
			this.checkBox_0.Text = "Only show aircraft able to take off / land here";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_0.Visible = false;
			this.comboBox_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.comboBox_0.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Items.AddRange(new object[]
			{
				"Aircraft"
			});
			this.comboBox_0.Location = new global::System.Drawing.Point(389, 16);
			this.comboBox_0.Name = "CB_Country";
			this.comboBox_0.Size = new global::System.Drawing.Size(264, 21);
			this.comboBox_0.TabIndex = 13;
			this.label_4.Location = new global::System.Drawing.Point(341, 20);
			this.label_4.Name = "Label3";
			this.label_4.Size = new global::System.Drawing.Size(46, 13);
			this.label_4.TabIndex = 12;
			this.label_4.Text = "国别:";
			this.label_5.Location = new global::System.Drawing.Point(7, 20);
			this.label_5.Name = "Label6";
			this.label_5.Size = new global::System.Drawing.Size(35, 13);
			this.label_5.TabIndex = 11;
			this.label_5.Text = "型号:";
			this.textBox_2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBox_2.Location = new global::System.Drawing.Point(77, 17);
			this.textBox_2.Name = "TB_Class";
			this.textBox_2.Size = new global::System.Drawing.Size(258, 20);
			this.textBox_2.TabIndex = 10;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(967, 673);
			base.Controls.Add(this.groupBox_1);
			base.Controls.Add(this.dataGridView_0);
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.groupBox_0);
			base.Controls.Add(this.textBox_1);
			base.Controls.Add(this.label_3);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.listView_0);
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditAC";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "编辑飞机:";
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown_0).EndInit();
			this.groupBox_0.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView_0).EndInit();
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001DDB RID: 7643
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

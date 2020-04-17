using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x02000A2D RID: 2605
	[DesignerGenerated]
	public sealed partial class AddNewUnit : CommandForm
	{
		// Token: 0x06005218 RID: 21016 RVA: 0x00218AF4 File Offset: 0x00216CF4
		public AddNewUnit()
		{
			base.FormClosing += new FormClosingEventHandler(this.Form3_FormClosing);
			base.Shown += new EventHandler(this.Form3_Shown);
			base.KeyDown += new KeyEventHandler(this.Form3_KeyDown);
			base.FormClosed += new FormClosedEventHandler(this.Form3_FormClosed);
			base.Load += new EventHandler(this.Form3_Load);
			this.dataTable_0 = new DataTable();
			this.dateTime_0 = default(DateTime);
			this.string_0 = null;
			this.method_1();
		}

		// Token: 0x0600521A RID: 21018 RVA: 0x00218B88 File Offset: 0x00216D88
		private void method_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			this.vmethod_1(new Label());
			this.vmethod_3(new ComboBox());
			this.vmethod_5(new Label());
			this.vmethod_7(new Button());
			this.vmethod_9(new Button());
			this.vmethod_11(new DataGridView());
			this.vmethod_35(new DataGridViewTextBoxColumn());
			this.vmethod_37(new DataGridViewLinkColumn());
			this.vmethod_39(new DataGridViewTextBoxColumn());
			this.vmethod_41(new DataGridViewTextBoxColumn());
			this.vmethod_43(new DataGridViewTextBoxColumn());
			this.vmethod_45(new DataGridViewTextBoxColumn());
			this.vmethod_47(new DataGridViewCheckBoxColumn());
			this.vmethod_49(new DataGridViewTextBoxColumn());
			this.vmethod_13(new Label());
			this.vmethod_15(new ComboBox());
			this.vmethod_17(new Button());
			this.vmethod_19(new TextBox());
			this.vmethod_21(new GroupBox());
			this.vmethod_31(new ComboBox());
			this.vmethod_33(new Label());
			this.vmethod_27(new ComboBox());
			this.vmethod_23(new Label());
			this.vmethod_25(new Label());
			this.vmethod_29(new TextBox());
			this.vmethod_51(new Label());
			this.vmethod_53(new TextBox());
			((ISupportInitialize)this.vmethod_10()).BeginInit();
			this.vmethod_20().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Location = new Point(9, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new Size(45, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "类型";
			this.GetCB_Type().DropDownStyle = ComboBoxStyle.DropDownList;
			this.GetCB_Type().FormattingEnabled = true;
			this.GetCB_Type().Items.AddRange(new object[]
			{
				"飞机",
				"水面舰艇",
				"潜艇",
				"战场设施"
			});
			this.GetCB_Type().Location = new Point(54, 10);
			this.GetCB_Type().Name = "CB_Type";
			this.GetCB_Type().Size = new Size(326, 21);
			this.GetCB_Type().TabIndex = 1;
			this.vmethod_4().Location = new Point(9, 67);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new Size(45, 13);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "名称";
			this.vmethod_6().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.vmethod_6().Location = new Point(12, 585);
			this.vmethod_6().Name = "Button1";
			this.vmethod_6().Size = new Size(75, 23);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_6().Text = "确认";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_8().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.vmethod_8().Location = new Point(394, 585);
			this.vmethod_8().Name = "Button2";
			this.vmethod_8().Size = new Size(75, 23);
			this.vmethod_8().TabIndex = 5;
			this.vmethod_8().Text = "取消";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().AllowUserToAddRows = false;
			this.vmethod_10().AllowUserToDeleteRows = false;
			this.vmethod_10().AllowUserToResizeColumns = false;
			this.vmethod_10().AllowUserToResizeRows = false;
			this.vmethod_10().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.vmethod_10().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_10().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_10().Columns.AddRange(new DataGridViewColumn[]
			{
				this.vmethod_34(),
				this.vmethod_36(),
				this.vmethod_38(),
				this.vmethod_40(),
				this.vmethod_42(),
				this.vmethod_44(),
				this.vmethod_46(),
				this.vmethod_48()
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.vmethod_10().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_10().EditMode = DataGridViewEditMode.EditProgrammatically;
			this.vmethod_10().Location = new Point(12, 190);
			this.vmethod_10().MultiSelect = false;
			this.vmethod_10().Name = "DataGridView1";
			this.vmethod_10().ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.vmethod_10().RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_10().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_10().Size = new Size(457, 389);
			this.vmethod_10().TabIndex = 6;
			this.vmethod_34().DataPropertyName = "ID";
			this.vmethod_34().HeaderText = "ID";
			this.vmethod_34().Name = "ID";
			this.vmethod_34().ReadOnly = true;
			this.vmethod_34().Visible = false;
			this.vmethod_36().AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.vmethod_36().DataPropertyName = "LongName";
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_36().DefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_36().HeaderText = "平台";
			this.vmethod_36().Name = "FullName";
			this.vmethod_36().ReadOnly = true;
			this.vmethod_36().Resizable = DataGridViewTriState.True;
			this.vmethod_36().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_36().Width = 230;
			this.vmethod_38().DataPropertyName = "Name";
			this.vmethod_38().HeaderText = "ShortName";
			this.vmethod_38().Name = "Name";
			this.vmethod_38().ReadOnly = true;
			this.vmethod_38().Visible = false;
			this.vmethod_40().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_40().DataPropertyName = "CountryString";
			dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_40().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_40().HeaderText = "国家";
			this.vmethod_40().Name = "Country";
			this.vmethod_40().ReadOnly = true;
			this.vmethod_40().Width = 68;
			this.vmethod_42().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_42().DataPropertyName = "YearCommissioned";
			dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_42().DefaultCellStyle = dataGridViewCellStyle6;
			this.vmethod_42().HeaderText = "服役";
			this.vmethod_42().Name = "IOC";
			this.vmethod_42().ReadOnly = true;
			this.vmethod_42().Width = 55;
			this.vmethod_44().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_44().DataPropertyName = "YearDecommissioned";
			dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_44().DefaultCellStyle = dataGridViewCellStyle7;
			this.vmethod_44().HeaderText = "退役";
			this.vmethod_44().Name = "Retired";
			this.vmethod_44().ReadOnly = true;
			this.vmethod_44().Width = 53;
			this.vmethod_46().AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.vmethod_46().DataPropertyName = "Hypothetical";
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25f);
			dataGridViewCellStyle8.NullValue = false;
			this.vmethod_46().DefaultCellStyle = dataGridViewCellStyle8;
			this.vmethod_46().FalseValue = "False";
			this.vmethod_46().HeaderText = "假想";
			this.vmethod_46().Name = "Hypothetical";
			this.vmethod_46().ReadOnly = true;
			this.vmethod_46().Resizable = DataGridViewTriState.True;
			this.vmethod_46().SortMode = DataGridViewColumnSortMode.Automatic;
			this.vmethod_46().TrueValue = "True";
			this.vmethod_46().Width = 57;
			this.vmethod_48().DataPropertyName = "OperatorCountry";
			this.vmethod_48().HeaderText = "Operator";
			this.vmethod_48().Name = "CountryNumber";
			this.vmethod_48().ReadOnly = true;
			this.vmethod_48().Visible = false;
			this.vmethod_12().Location = new Point(9, 40);
			this.vmethod_12().Name = "Label3";
			this.vmethod_12().Size = new Size(45, 13);
			this.vmethod_12().TabIndex = 7;
			this.vmethod_12().Text = "推演方";
			this.vmethod_14().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_14().FormattingEnabled = true;
			this.vmethod_14().Items.AddRange(new object[]
			{
				"飞机"
			});
			this.vmethod_14().Location = new Point(54, 37);
			this.vmethod_14().Name = "CB_Sides";
			this.vmethod_14().Size = new Size(326, 21);
			this.vmethod_14().TabIndex = 8;
			this.vmethod_16().Location = new Point(386, 37);
			this.vmethod_16().Name = "Button3";
			this.vmethod_16().Size = new Size(83, 21);
			this.vmethod_16().TabIndex = 9;
			this.vmethod_16().Text = "编辑推演方...";
			this.vmethod_16().UseVisualStyleBackColor = true;
			this.GetTB_Class().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.GetTB_Class().Location = new Point(77, 17);
			this.GetTB_Class().Name = "TB_Class";
			this.GetTB_Class().Size = new Size(151, 20);
			this.GetTB_Class().TabIndex = 10;
			this.vmethod_20().Controls.Add(this.vmethod_30());
			this.vmethod_20().Controls.Add(this.vmethod_32());
			this.vmethod_20().Controls.Add(this.GetCB_Country());
			this.vmethod_20().Controls.Add(this.vmethod_22());
			this.vmethod_20().Controls.Add(this.vmethod_24());
			this.vmethod_20().Controls.Add(this.GetTB_Class());
			this.vmethod_20().Location = new Point(12, 89);
			this.vmethod_20().Name = "GroupBox1";
			this.vmethod_20().Size = new Size(457, 71);
			this.vmethod_20().TabIndex = 12;
			this.vmethod_20().TabStop = false;
			this.vmethod_20().Text = "过滤条件...";
			this.vmethod_30().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.vmethod_30().DropDownStyle = ComboBoxStyle.DropDownList;
			this.vmethod_30().FormattingEnabled = true;
			this.vmethod_30().Items.AddRange(new object[]
			{
				"飞机"
			});
			this.vmethod_30().Location = new Point(77, 41);
			this.vmethod_30().Name = "CB_Hypothetical";
			this.vmethod_30().Size = new Size(374, 21);
			this.vmethod_30().TabIndex = 18;
			this.vmethod_32().Location = new Point(6, 45);
			this.vmethod_32().Name = "Label7";
			this.vmethod_32().Size = new Size(69, 13);
			this.vmethod_32().TabIndex = 17;
			this.vmethod_32().Text = "假想";
			this.GetCB_Country().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.GetCB_Country().DropDownStyle = ComboBoxStyle.DropDownList;
			this.GetCB_Country().FormattingEnabled = true;
			this.GetCB_Country().Items.AddRange(new object[]
			{
				"飞机"
			});
			this.GetCB_Country().Location = new Point(278, 16);
			this.GetCB_Country().Name = "CB_Country";
			this.GetCB_Country().Size = new Size(173, 21);
			this.GetCB_Country().TabIndex = 13;
			this.vmethod_22().Location = new Point(226, 20);
			this.vmethod_22().Name = "Label5";
			this.vmethod_22().Size = new Size(46, 13);
			this.vmethod_22().TabIndex = 12;
			this.vmethod_22().Text = "国家";
			this.vmethod_24().Location = new Point(7, 20);
			this.vmethod_24().Name = "Label4";
			this.vmethod_24().Size = new Size(35, 13);
			this.vmethod_24().TabIndex = 11;
			this.vmethod_24().Text = "型号";
			this.vmethod_28().Location = new Point(54, 64);
			this.vmethod_28().Name = "TextBox1";
			this.vmethod_28().Size = new Size(415, 20);
			this.vmethod_28().TabIndex = 3;
			this.vmethod_50().AutoSize = true;
			this.vmethod_50().Location = new Point(12, 171);
			this.vmethod_50().Name = "Label6";
			this.vmethod_50().Size = new Size(75, 13);
			this.vmethod_50().TabIndex = 13;
			this.vmethod_50().Text = "自定义GUID";
			this.vmethod_52().Location = new Point(89, 164);
			this.vmethod_52().Name = "TB_CustomGUID";
			this.vmethod_52().Size = new Size(380, 20);
			this.vmethod_52().TabIndex = 14;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(481, 620);
			base.Controls.Add(this.vmethod_52());
			base.Controls.Add(this.vmethod_50());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.GetCB_Type());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "添加新作战单元";
			((ISupportInitialize)this.vmethod_10()).EndInit();
			this.vmethod_20().ResumeLayout(false);
			this.vmethod_20().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600521B RID: 21019 RVA: 0x00219C30 File Offset: 0x00217E30
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x0002647F File Offset: 0x0002467F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_7)
		{
			this.label_0 = label_7;
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x00219C48 File Offset: 0x00217E48
		[CompilerGenerated]
		internal  ComboBox GetCB_Type()
		{
			return this.comboBox_0;
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x00219C60 File Offset: 0x00217E60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ComboBox comboBox_4)
		{
			EventHandler value = new EventHandler(this.method_11);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_4;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600521F RID: 21023 RVA: 0x00219CAC File Offset: 0x00217EAC
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_1;
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x00026488 File Offset: 0x00024688
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_7)
		{
			this.label_1 = label_7;
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x00219CC4 File Offset: 0x00217EC4
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_0;
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x00219CDC File Offset: 0x00217EDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_2);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_3;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005223 RID: 21027 RVA: 0x00219D28 File Offset: 0x00217F28
		[CompilerGenerated]
		internal  Button vmethod_8()
		{
			return this.button_1;
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x00219D40 File Offset: 0x00217F40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_4);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_3;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x00219D8C File Offset: 0x00217F8C
		[CompilerGenerated]
		internal  DataGridView vmethod_10()
		{
			return this.dataGridView_0;
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x00219DA4 File Offset: 0x00217FA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(DataGridView dataGridView_1)
		{
			KeyPressEventHandler value = new KeyPressEventHandler(this.method_7);
			EventHandler value2 = new EventHandler(this.method_10);
			DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.method_13);
			DataGridView dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.KeyPress -= value;
				dataGridView.SelectionChanged -= value2;
				dataGridView.CellContentClick -= value3;
			}
			this.dataGridView_0 = dataGridView_1;
			dataGridView = this.dataGridView_0;
			if (dataGridView != null)
			{
				dataGridView.KeyPress += value;
				dataGridView.SelectionChanged += value2;
				dataGridView.CellContentClick += value3;
			}
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x00219E24 File Offset: 0x00218024
		[CompilerGenerated]
		internal  Label vmethod_12()
		{
			return this.label_2;
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x00026491 File Offset: 0x00024691
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Label label_7)
		{
			this.label_2 = label_7;
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x00219E3C File Offset: 0x0021803C
		[CompilerGenerated]
		internal  ComboBox vmethod_14()
		{
			return this.comboBox_1;
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x0002649A File Offset: 0x0002469A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ComboBox comboBox_4)
		{
			this.comboBox_1 = comboBox_4;
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x00219E54 File Offset: 0x00218054
		[CompilerGenerated]
		internal  Button vmethod_16()
		{
			return this.button_2;
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x00219E6C File Offset: 0x0021806C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_5);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_3;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x0600522D RID: 21037 RVA: 0x00219EB8 File Offset: 0x002180B8
		[CompilerGenerated]
		internal  TextBox GetTB_Class()
		{
			return this.textBox_0;
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x000264A3 File Offset: 0x000246A3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(TextBox textBox_3)
		{
			this.textBox_0 = textBox_3;
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x00219ED0 File Offset: 0x002180D0
		[CompilerGenerated]
		internal  GroupBox vmethod_20()
		{
			return this.groupBox_0;
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x000264AC File Offset: 0x000246AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(GroupBox groupBox_1)
		{
			this.groupBox_0 = groupBox_1;
		}

		// Token: 0x06005231 RID: 21041 RVA: 0x00219EE8 File Offset: 0x002180E8
		[CompilerGenerated]
		internal  Label vmethod_22()
		{
			return this.label_3;
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x000264B5 File Offset: 0x000246B5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Label label_7)
		{
			this.label_3 = label_7;
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x00219F00 File Offset: 0x00218100
		[CompilerGenerated]
		internal  Label vmethod_24()
		{
			return this.label_4;
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x000264BE File Offset: 0x000246BE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Label label_7)
		{
			this.label_4 = label_7;
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x00219F18 File Offset: 0x00218118
		[CompilerGenerated]
		internal  ComboBox GetCB_Country()
		{
			return this.comboBox_2;
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x00219F30 File Offset: 0x00218130
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(ComboBox comboBox_4)
		{
			EventHandler value = new EventHandler(this.method_12);
			ComboBox comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_2 = comboBox_4;
			comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x00219F7C File Offset: 0x0021817C
		[CompilerGenerated]
		internal  TextBox vmethod_28()
		{
			return this.textBox_1;
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x00219F94 File Offset: 0x00218194
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(TextBox textBox_3)
		{
			EventHandler value = new EventHandler(this.method_3);
			TextBox textBox = this.textBox_1;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
			}
			this.textBox_1 = textBox_3;
			textBox = this.textBox_1;
			if (textBox != null)
			{
				textBox.TextChanged += value;
			}
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x00219FE0 File Offset: 0x002181E0
		[CompilerGenerated]
		internal  ComboBox vmethod_30()
		{
			return this.comboBox_3;
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x00219FF8 File Offset: 0x002181F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(ComboBox comboBox_4)
		{
			EventHandler value = new EventHandler(this.method_14);
			ComboBox comboBox = this.comboBox_3;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_3 = comboBox_4;
			comboBox = this.comboBox_3;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x0021A044 File Offset: 0x00218244
		[CompilerGenerated]
		internal  Label vmethod_32()
		{
			return this.label_5;
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x000264C7 File Offset: 0x000246C7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(Label label_7)
		{
			this.label_5 = label_7;
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x0021A05C File Offset: 0x0021825C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_34()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x000264D0 File Offset: 0x000246D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x0021A074 File Offset: 0x00218274
		[CompilerGenerated]
		internal  DataGridViewLinkColumn vmethod_36()
		{
			return this.dataGridViewLinkColumn_0;
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x000264D9 File Offset: 0x000246D9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(DataGridViewLinkColumn dataGridViewLinkColumn_1)
		{
			this.dataGridViewLinkColumn_0 = dataGridViewLinkColumn_1;
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x0021A08C File Offset: 0x0021828C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_38()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x000264E2 File Offset: 0x000246E2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x0021A0A4 File Offset: 0x002182A4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_40()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x000264EB File Offset: 0x000246EB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x0021A0BC File Offset: 0x002182BC
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_42()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x000264F4 File Offset: 0x000246F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x0021A0D4 File Offset: 0x002182D4
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_44()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x000264FD File Offset: 0x000246FD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x0021A0EC File Offset: 0x002182EC
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn vmethod_46()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x00026506 File Offset: 0x00024706
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x0021A104 File Offset: 0x00218304
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_48()
		{
			return this.dataGridViewTextBoxColumn_5;
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x0002650F File Offset: 0x0002470F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_49(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6)
		{
			this.dataGridViewTextBoxColumn_5 = dataGridViewTextBoxColumn_6;
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x0021A11C File Offset: 0x0021831C
		[CompilerGenerated]
		internal  Label vmethod_50()
		{
			return this.label_6;
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x00026518 File Offset: 0x00024718
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_51(Label label_7)
		{
			this.label_6 = label_7;
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x0021A134 File Offset: 0x00218334
		[CompilerGenerated]
		internal  TextBox vmethod_52()
		{
			return this.textBox_2;
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x00026521 File Offset: 0x00024721
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_53(TextBox textBox_3)
		{
			this.textBox_2 = textBox_3;
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x0021A14C File Offset: 0x0021834C
		private void method_2(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.vmethod_28().Text, "", false) == 0)
			{
				Interaction.MsgBox("请为新添加的作战单元取名.", MsgBoxStyle.Critical, "没有名称?");
			}
			else if (this.vmethod_10().SelectedRows.Count != 0)
			{
				if (!string.IsNullOrEmpty(this.vmethod_52().Text))
				{
					this.string_0 = this.vmethod_52().Text;
				}
				GeoPoint geoPoint_ = CommandFactory.GetCommandMain().GetMainForm().geoPoint_0;
				switch (this.GetCB_Type().SelectedIndex)
				{
				case 0:
				{
					new DataTable();
					int aircraftID = Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString());
					Dictionary<int, int> selectedAircraftTotalWeaponQty = null;
					SQLiteConnection sQLiteConnection = Client.GetClientScenario().GetSQLiteConnection();
					Scenario clientScenario = Client.GetClientScenario();
					bool flag = false;
					Scenario scenario = null;
					Aircraft aircraft = null;
					int num = 0;
					bool flag2 = false;
					if (DBFunctions.smethod_42(aircraftID, selectedAircraftTotalWeaponQty, ref sQLiteConnection, clientScenario, ref flag, ref scenario, ref aircraft, ref num, ref flag2).Rows.Count == 0)
					{
						Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[this.vmethod_14().SelectedIndex], this.vmethod_28().Text, geoPoint_.GetLongitude(), geoPoint_.GetLatitude(), Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString()), 0, 1000f, this.string_0);
						base.Close();
						return;
					}
					CommandFactory.GetCommandMain().GetSelectLoadout().string_0 = this.vmethod_28().Text;
					CommandFactory.GetCommandMain().GetSelectLoadout().int_0 = Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString());
					CommandFactory.GetCommandMain().GetSelectLoadout().side_0 = Client.GetClientScenario().GetSides()[this.vmethod_14().SelectedIndex];
					CommandFactory.GetCommandMain().GetSelectLoadout().Show();
					return;
				}
				case 1:
					try
					{
						Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[this.vmethod_14().SelectedIndex], Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString()), this.vmethod_28().Text, geoPoint_.GetLongitude(), geoPoint_.GetLatitude(), false, this.string_0);
						goto IL_424;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Interaction.MsgBox("Error: " + ex2.Message, MsgBoxStyle.OkOnly, null);
						ProjectData.ClearProjectError();
						return;
					}
					break;
				case 2:
					break;
				case 3:
					goto IL_386;
				case 4:
				case 5:
					goto IL_424;
				default:
					goto IL_424;
				}
				try
				{
					Client.GetClientScenario().AddSubmarine(Client.GetClientScenario().GetSides()[this.vmethod_14().SelectedIndex], Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString()), this.vmethod_28().Text, geoPoint_.GetLongitude(), geoPoint_.GetLatitude(), false, this.string_0);
					goto IL_424;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Interaction.MsgBox("Error: " + ex4.Message, MsgBoxStyle.OkOnly, null);
					ProjectData.ClearProjectError();
					return;
				}
				IL_386:
				try
				{
					Client.GetClientScenario().AddFacility(Client.GetClientScenario().GetSides()[this.vmethod_14().SelectedIndex], Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString()), this.vmethod_28().Text, geoPoint_.GetLongitude(), geoPoint_.GetLatitude(), false, this.string_0);
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					Interaction.MsgBox("Error: " + ex6.Message, MsgBoxStyle.OkOnly, null);
					ProjectData.ClearProjectError();
					return;
				}
				IL_424:
				if (Client.GetClientScenario().GetSides().Count<Side>() == 1)
				{
					Client.SetClientSide(Client.GetClientScenario().GetSides()[0]);
				}
				base.Close();
			}
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x0002652A File Offset: 0x0002472A
		private void Form3_FormClosing(object sender, FormClosingEventArgs e)
		{
			Client.IssueOrdersToUnit(Client._CommandOrder.None);
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x00026551 File Offset: 0x00024751
		private void method_3(object sender, EventArgs e)
		{
			this.vmethod_6().Enabled = (Operators.CompareString(this.vmethod_28().Text, "", false) != 0);
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_4(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x0002657A File Offset: 0x0002477A
		private void method_5(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetSides().Show();
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x0021A5D4 File Offset: 0x002187D4
		public void method_6()
		{
			this.vmethod_14().Items.Clear();
			Side[] sides = Client.GetClientScenario().GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					this.vmethod_14().Items.Add(side.GetSideName());
				}
				if (this.vmethod_14().Items.Count > 0)
				{
					this.vmethod_14().SelectedIndex = Array.IndexOf<Side>(Client.GetClientScenario().GetSides(), Client.GetClientSide());
				}
				this.vmethod_6().Enabled = (this.vmethod_14().Items.Count > 0 & !Information.IsNothing(this.vmethod_14().SelectedIndex));
			}
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x0021A698 File Offset: 0x00218898
		private void method_7(object sender, KeyPressEventArgs e)
		{
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "LongName ASC";
			dataView.RowFilter = "LongName LIKE '" + Conversions.ToString(e.KeyChar) + "%'";
			if (dataView.Count > 0)
			{
				int num = Conversions.ToInteger(dataView[0][0].ToString());
				int firstDisplayedScrollingRowIndex = 0;
				IEnumerator enumerator = ((IEnumerable)this.vmethod_10().Rows).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
						if (Conversions.ToInteger(dataGridViewRow.Cells[0].Value) == num)
						{
							firstDisplayedScrollingRowIndex = dataGridViewRow.Index;
							break;
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.vmethod_10().FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
			}
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x0002658B File Offset: 0x0002478B
		private void method_8(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x0021A794 File Offset: 0x00218994
		private void method_9()
		{
			Client.Type = new byte?((byte)this.GetCB_Type().SelectedIndex);
			Client.CountryID = new int?(Conversions.ToInteger(this.GetCB_Country().SelectedValue));
			Client.strClass = this.GetTB_Class().Text.Replace("'", "''");
			switch (this.GetCB_Type().SelectedIndex)
			{
			case 0:
				this.dataTable_0 = Client.GetClientScenario().Cache_Aircraft_DT;
				break;
			case 1:
				this.dataTable_0 = Client.GetClientScenario().Cache_Ships_DT;
				break;
			case 2:
				this.dataTable_0 = Client.GetClientScenario().Cache_Subs_DT;
				break;
			case 3:
				this.dataTable_0 = Client.GetClientScenario().Cache_Facilities_DT;
				break;
			default:
				return;
			}
			DataView dataView = new DataView(this.dataTable_0);
			dataView.Sort = "LongName ASC";
			if (Operators.CompareString(this.GetTB_Class().Text, "", false) != 0 || this.GetCB_Country().SelectedIndex != 0 || this.vmethod_30().SelectedIndex != 0)
			{
				string text = "1=1 ";
				if (Operators.CompareString(this.GetTB_Class().Text, "", false) != 0)
				{
					string str = this.GetTB_Class().Text.Replace("'", "''");
					text = text + " AND LongName LIKE '%" + str + "%' ";
				}
				if (this.GetCB_Country().SelectedIndex > 0)
				{
					text = text + " AND OperatorCountry=" + Conversions.ToString(Conversions.ToInteger(this.GetCB_Country().SelectedValue));
				}
				if (this.vmethod_30().SelectedIndex == 1)
				{
					text += " AND Hypothetical=FALSE";
				}
				else if (this.vmethod_30().SelectedIndex == 2)
				{
					text += " AND Hypothetical=TRUE";
				}
				text = text.Replace("[", "[[");
				text = text.Replace("]", "]]");
				text = text.Replace("[[", "[[]");
				text = text.Replace("]]", "[]]");
				dataView.RowFilter = text;
			}
			this.vmethod_10().SuspendLayout();
			this.vmethod_10().Enabled = false;
			this.vmethod_10().DataSource = dataView;
			this.vmethod_10().Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_10().Refresh();
			this.vmethod_10().Enabled = true;
			this.vmethod_10().ResumeLayout();
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x0021AA1C File Offset: 0x00218C1C
		private void method_10(object sender, EventArgs e)
		{
			if (this.vmethod_10().SelectedRows.Count > 0)
			{
				this.vmethod_28().Text = Misc.smethod_11(Conversions.ToString(this.vmethod_10().SelectedRows[0].Cells[2].Value));
			}
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x0021AA78 File Offset: 0x00218C78
		private void Form3_Shown(object sender, EventArgs e)
		{
			this.dateTime_0 = DateTime.UtcNow;
			this.GetTB_Class().TextChanged += new EventHandler(this.method_8);
			this.vmethod_10().AutoGenerateColumns = false;
			DataTable cache_OperatorCountries_DT = Client.GetClientScenario().Cache_OperatorCountries_DT;
			this.GetCB_Country().DataSource = cache_OperatorCountries_DT;
			this.GetCB_Country().DisplayMember = "Description";
			this.GetCB_Country().ValueMember = "ID";
			this.GetCB_Country().SelectedIndex = 0;
			this.vmethod_30().Items.Clear();
			this.vmethod_30().Items.Add("显示所有平台，包括已列装平台与假想平台");
			this.vmethod_30().Items.Add("仅显示已列装的平台");
			this.vmethod_30().Items.Add("仅显示假想的平台");
			this.vmethod_30().SelectedIndex = 0;
			this.vmethod_6().Enabled = (Operators.CompareString(this.vmethod_28().Text, "", false) != 0);
			this.GetCB_Type().SelectedIndex = 0;
			base.AcceptButton = this.vmethod_6();
			base.CancelButton = this.vmethod_8();
			this.vmethod_6().Enabled = false;
			this.method_6();
			if (Client.CountryID.HasValue | !string.IsNullOrEmpty(Client.strClass) | Client.Type.HasValue)
			{
				if (Client.CountryID.HasValue)
				{
					this.GetCB_Country().SelectedValue = Client.CountryID;
				}
				if (Client.Type.HasValue)
				{
					this.GetCB_Type().SelectedIndex = (int)Client.Type.Value;
				}
				if (!string.IsNullOrEmpty(Client.strClass))
				{
					this.GetTB_Class().Text = Client.strClass;
				}
			}
			this.method_9();
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x00026593 File Offset: 0x00024793
		private void method_11(object sender, EventArgs e)
		{
			this.GetTB_Class().Clear();
			this.method_9();
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x0002658B File Offset: 0x0002478B
		private void method_12(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		private void Form3_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x0021AC44 File Offset: 0x00218E44
		private void method_13(object sender, DataGridViewCellEventArgs e)
		{
			if (!(DateTime.UtcNow - this.dateTime_0 < TimeSpan.FromMilliseconds(500.0)) && e.RowIndex != -1 && this.vmethod_10().Columns[e.ColumnIndex].CellType == typeof(DataGridViewLinkCell))
			{
				int dBID = Conversions.ToInteger(this.vmethod_10().SelectedRows[0].Cells["ID"].Value.ToString());
				string strUnitType = "";
				switch (this.GetCB_Type().SelectedIndex)
				{
				case 0:
					strUnitType = "飞机";
					break;
				case 1:
					strUnitType = "水面舰艇";
					break;
				case 2:
					strUnitType = "潜艇";
					break;
				case 3:
					strUnitType = "战场设施";
					break;
				}
				Client.ShowDBInfo(strUnitType, dBID);
			}
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x000265A6 File Offset: 0x000247A6
		private void Form3_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.GetTB_Class().TextChanged -= new EventHandler(this.method_8);
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x0002658B File Offset: 0x0002478B
		private void method_14(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void Form3_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x0400268C RID: 9868
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x0400268D RID: 9869
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x0400268E RID: 9870
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x0400268F RID: 9871
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04002690 RID: 9872
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04002691 RID: 9873
		[CompilerGenerated]
		private DataGridView dataGridView_0;

		// Token: 0x04002692 RID: 9874
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04002693 RID: 9875
		[CompilerGenerated]
		private ComboBox comboBox_1;

		// Token: 0x04002694 RID: 9876
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04002695 RID: 9877
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04002696 RID: 9878
		[CompilerGenerated]
		private GroupBox groupBox_0;

		// Token: 0x04002697 RID: 9879
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04002698 RID: 9880
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04002699 RID: 9881
		[CompilerGenerated]
		private ComboBox comboBox_2;

		// Token: 0x0400269A RID: 9882
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x0400269B RID: 9883
		[CompilerGenerated]
		private ComboBox comboBox_3;

		// Token: 0x0400269C RID: 9884
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x0400269D RID: 9885
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x0400269E RID: 9886
		[CompilerGenerated]
		private DataGridViewLinkColumn dataGridViewLinkColumn_0;

		// Token: 0x0400269F RID: 9887
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x040026A0 RID: 9888
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x040026A1 RID: 9889
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x040026A2 RID: 9890
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x040026A3 RID: 9891
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x040026A4 RID: 9892
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		// Token: 0x040026A5 RID: 9893
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x040026A6 RID: 9894
		[CompilerGenerated]
		private TextBox textBox_2;

		// Token: 0x040026A7 RID: 9895
		private DataTable dataTable_0;

		// Token: 0x040026A8 RID: 9896
		private DateTime dateTime_0;

		// Token: 0x040026A9 RID: 9897
		public string string_0;
	}
}

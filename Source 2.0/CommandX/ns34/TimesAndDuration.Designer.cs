namespace ns34
{
	// Token: 0x02000A0A RID: 2570
	
	public sealed partial class TimesAndDuration : global::ns33.CommandForm
	{
		// Token: 0x06004E6E RID: 20078 RVA: 0x001F8EE8 File Offset: 0x001F70E8
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

		// Token: 0x06004E6F RID: 20079 RVA: 0x001F8F2C File Offset: 0x001F712C
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.TextBox());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.TextBox());
			this.vmethod_9(new global::System.Windows.Forms.Label());
			this.vmethod_11(new global::System.Windows.Forms.DateTimePicker());
			this.vmethod_13(new global::System.Windows.Forms.Label());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_17(new global::System.Windows.Forms.TextBox());
			this.vmethod_19(new global::System.Windows.Forms.Button());
			this.vmethod_21(new global::System.Windows.Forms.Button());
			this.vmethod_23(new global::System.Windows.Forms.DateTimePicker());
			this.vmethod_25(new global::System.Windows.Forms.DateTimePicker());
			this.vmethod_27(new global::System.Windows.Forms.Label());
			this.vmethod_29(new global::System.Windows.Forms.DateTimePicker());
			this.vmethod_31(new global::System.Windows.Forms.Label());
			this.vmethod_33(new global::System.Windows.Forms.NumericUpDown());
			this.vmethod_35(new global::System.Windows.Forms.Label());
			this.vmethod_37(new global::System.Windows.Forms.Label());
			this.vmethod_39(new global::System.Windows.Forms.TextBox());
			this.vmethod_41(new global::System.Windows.Forms.NumericUpDown());
			this.vmethod_43(new global::System.Windows.Forms.CheckBox());
			this.vmethod_45(new global::System.Windows.Forms.Label());
			this.vmethod_47(new global::System.Windows.Forms.Label());
			this.vmethod_49(new global::System.Windows.Forms.MaskedTextBox());
			this.vmethod_51(new global::System.Windows.Forms.MaskedTextBox());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_32()).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_40()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().AutoSize = true;
			this.vmethod_0().Location = new global::System.Drawing.Point(211, 240);
			this.vmethod_0().Name = "Label4";
			this.vmethod_0().Size = new global::System.Drawing.Size(28, 13);
			this.vmethod_0().TabIndex = 15;
			this.vmethod_0().Text = "分钟";
			this.vmethod_2().Location = new global::System.Drawing.Point(83, 237);
			this.vmethod_2().Name = "TB_Hours";
			this.vmethod_2().Size = new global::System.Drawing.Size(39, 20);
			this.vmethod_2().TabIndex = 14;
			this.vmethod_2().Text = "0";
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().Location = new global::System.Drawing.Point(127, 240);
			this.vmethod_4().Name = "Label3";
			this.vmethod_4().Size = new global::System.Drawing.Size(33, 13);
			this.vmethod_4().TabIndex = 13;
			this.vmethod_4().Text = "小时";
			this.vmethod_6().Location = new global::System.Drawing.Point(12, 238);
			this.vmethod_6().Name = "TB_Days";
			this.vmethod_6().Size = new global::System.Drawing.Size(35, 20);
			this.vmethod_6().TabIndex = 12;
			this.vmethod_6().Text = "0";
			this.vmethod_8().AutoSize = true;
			this.vmethod_8().Location = new global::System.Drawing.Point(48, 241);
			this.vmethod_8().Name = "Label2";
			this.vmethod_8().Size = new global::System.Drawing.Size(29, 13);
			this.vmethod_8().TabIndex = 11;
			this.vmethod_8().Text = "天";
			this.vmethod_10().Location = new global::System.Drawing.Point(12, 167);
			this.vmethod_10().Name = "DTP_StartDate";
			this.vmethod_10().Size = new global::System.Drawing.Size(305, 20);
			this.vmethod_10().TabIndex = 10;
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Location = new global::System.Drawing.Point(12, 151);
			this.vmethod_12().Name = "Label1";
			this.vmethod_12().Size = new global::System.Drawing.Size(95, 13);
			this.vmethod_12().TabIndex = 16;
			this.vmethod_12().Text = "想定开始时间:";
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Location = new global::System.Drawing.Point(9, 222);
			this.vmethod_14().Name = "Label5";
			this.vmethod_14().Size = new global::System.Drawing.Size(68, 13);
			this.vmethod_14().TabIndex = 17;
			this.vmethod_14().Text = "想定持续时间:";
			this.vmethod_16().Location = new global::System.Drawing.Point(166, 237);
			this.vmethod_16().Name = "TB_Mins";
			this.vmethod_16().Size = new global::System.Drawing.Size(39, 20);
			this.vmethod_16().TabIndex = 18;
			this.vmethod_16().Text = "0";
			this.vmethod_18().Location = new global::System.Drawing.Point(12, 345);
			this.vmethod_18().Name = "Button1";
			this.vmethod_18().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_18().TabIndex = 19;
			this.vmethod_18().Text = "确认";
			this.vmethod_18().UseVisualStyleBackColor = true;
			this.vmethod_20().Location = new global::System.Drawing.Point(242, 345);
			this.vmethod_20().Name = "Button2";
			this.vmethod_20().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_20().TabIndex = 20;
			this.vmethod_20().Text = "取消";
			this.vmethod_20().UseVisualStyleBackColor = true;
			this.vmethod_22().Format = global::System.Windows.Forms.DateTimePickerFormat.Time;
			this.vmethod_22().Location = new global::System.Drawing.Point(12, 193);
			this.vmethod_22().Name = "DTP_StartTime";
			this.vmethod_22().Size = new global::System.Drawing.Size(305, 20);
			this.vmethod_22().TabIndex = 21;
			this.vmethod_24().Location = new global::System.Drawing.Point(12, 22);
			this.vmethod_24().Name = "DTP_CurrentDate";
			this.vmethod_24().Size = new global::System.Drawing.Size(305, 20);
			this.vmethod_24().TabIndex = 22;
			this.vmethod_26().AutoSize = true;
			this.vmethod_26().Location = new global::System.Drawing.Point(12, 6);
			this.vmethod_26().Name = "Label6";
			this.vmethod_26().Size = new global::System.Drawing.Size(110, 13);
			this.vmethod_26().TabIndex = 23;
			this.vmethod_26().Text = "想定当前时间:";
			this.vmethod_28().Format = global::System.Windows.Forms.DateTimePickerFormat.Time;
			this.vmethod_28().Location = new global::System.Drawing.Point(12, 48);
			this.vmethod_28().Name = "DTP_CurrentTime";
			this.vmethod_28().Size = new global::System.Drawing.Size(305, 20);
			this.vmethod_28().TabIndex = 24;
			this.vmethod_30().AutoSize = true;
			this.vmethod_30().Location = new global::System.Drawing.Point(9, 286);
			this.vmethod_30().Name = "Label7";
			this.vmethod_30().Size = new global::System.Drawing.Size(60, 13);
			this.vmethod_30().TabIndex = 25;
			this.vmethod_30().Text = "复杂度:";
			this.vmethod_32().Location = new global::System.Drawing.Point(75, 284);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.vmethod_32();
			int[] array = new int[4];
			array[0] = 5;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.vmethod_32();
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.vmethod_32().Name = "NUD_Complexity";
			this.vmethod_32().Size = new global::System.Drawing.Size(47, 20);
			this.vmethod_32().TabIndex = 26;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.vmethod_32();
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.vmethod_34().AutoSize = true;
			this.vmethod_34().Location = new global::System.Drawing.Point(9, 314);
			this.vmethod_34().Name = "Label8";
			this.vmethod_34().Size = new global::System.Drawing.Size(50, 13);
			this.vmethod_34().TabIndex = 27;
			this.vmethod_34().Text = "难  度:";
			this.vmethod_36().AutoSize = true;
			this.vmethod_36().Location = new global::System.Drawing.Point(143, 286);
			this.vmethod_36().Name = "Label9";
			this.vmethod_36().Size = new global::System.Drawing.Size(89, 13);
			this.vmethod_36().TabIndex = 29;
			this.vmethod_36().Text = "发生地点:";
			this.vmethod_38().Location = new global::System.Drawing.Point(146, 311);
			this.vmethod_38().Name = "TextBox1";
			this.vmethod_38().Size = new global::System.Drawing.Size(171, 20);
			this.vmethod_38().TabIndex = 30;
			this.vmethod_40().Location = new global::System.Drawing.Point(75, 311);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.vmethod_40();
			int[] array4 = new int[4];
			array4[0] = 5;
			numericUpDown4.Maximum = new decimal(array4);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.vmethod_40();
			int[] array5 = new int[4];
			array5[0] = 1;
			numericUpDown5.Minimum = new decimal(array5);
			this.vmethod_40().Name = "NUD_Difficulty";
			this.vmethod_40().Size = new global::System.Drawing.Size(47, 20);
			this.vmethod_40().TabIndex = 31;
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.vmethod_40();
			int[] array6 = new int[4];
			array6[0] = 1;
			numericUpDown6.Value = new decimal(array6);
			this.vmethod_42().AutoSize = true;
			this.vmethod_42().Location = new global::System.Drawing.Point(12, 75);
			this.vmethod_42().Name = "CB_DaylightSavingTime";
			this.vmethod_42().Size = new global::System.Drawing.Size(261, 17);
			this.vmethod_42().TabIndex = 32;
			this.vmethod_42().Text = "夏令时";
			this.vmethod_42().UseVisualStyleBackColor = true;
			this.vmethod_44().AutoSize = true;
			this.vmethod_44().Location = new global::System.Drawing.Point(11, 97);
			this.vmethod_44().Name = "Label10";
			this.vmethod_44().Size = new global::System.Drawing.Size(118, 13);
			this.vmethod_44().TabIndex = 34;
			this.vmethod_44().Text = "夏令时开始时间(天月)";
			this.vmethod_46().AutoSize = true;
			this.vmethod_46().Location = new global::System.Drawing.Point(11, 120);
			this.vmethod_46().Name = "Label11";
			this.vmethod_46().Size = new global::System.Drawing.Size(115, 13);
			this.vmethod_46().TabIndex = 35;
			this.vmethod_46().Text = "夏令时结束时间(天月)";
			this.vmethod_48().Location = new global::System.Drawing.Point(130, 94);
			this.vmethod_48().Mask = "00.00";
			this.vmethod_48().Name = "TB_DaylightSavingTime_Start";
			this.vmethod_48().Size = new global::System.Drawing.Size(47, 20);
			this.vmethod_48().TabIndex = 36;
			this.vmethod_50().Location = new global::System.Drawing.Point(130, 117);
			this.vmethod_50().Mask = "00.00";
			this.vmethod_50().Name = "TB_DaylightSavingTime_End";
			this.vmethod_50().Size = new global::System.Drawing.Size(47, 20);
			this.vmethod_50().TabIndex = 36;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(329, 378);
			base.Controls.Add(this.vmethod_50());
			base.Controls.Add(this.vmethod_48());
			base.Controls.Add(this.vmethod_46());
			base.Controls.Add(this.vmethod_44());
			base.Controls.Add(this.vmethod_42());
			base.Controls.Add(this.vmethod_40());
			base.Controls.Add(this.vmethod_38());
			base.Controls.Add(this.vmethod_36());
			base.Controls.Add(this.vmethod_34());
			base.Controls.Add(this.vmethod_32());
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "TimesAndDuration";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "时间 - 持续 - 一般信息";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_32()).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_40()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400250F RID: 9487
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace Command
{
	// Token: 0x02000B55 RID: 2901
	
	public sealed partial class EditCondition : global::ns33.CommandForm
	{
		// Token: 0x06005F9E RID: 24478 RVA: 0x002D2E4C File Offset: 0x002D104C
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

		// Token: 0x06005F9F RID: 24479 RVA: 0x002D2E90 File Offset: 0x002D1090
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.TextBox());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.Button());
			this.vmethod_9(new global::System.Windows.Forms.Button());
			this.vmethod_11(new global::System.Windows.Forms.TabPage());
			this.vmethod_19(new global::System.Windows.Forms.ComboBox());
			this.vmethod_21(new global::System.Windows.Forms.Label());
			this.vmethod_23(new global::System.Windows.Forms.ComboBox());
			this.vmethod_25(new global::System.Windows.Forms.Label());
			this.vmethod_27(new global::System.Windows.Forms.CheckBox());
			this.vmethod_13(new global::System.Windows.Forms.ComboBox());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_17(new global::ns15.Control1());
			this.vmethod_29(new global::System.Windows.Forms.TabPage());
			this.vmethod_31(new global::System.Windows.Forms.CheckBox());
			this.vmethod_33(new global::System.Windows.Forms.TabPage());
			this.vmethod_35(new global::System.Windows.Forms.NumericUpDown());
			this.vmethod_37(new global::System.Windows.Forms.Label());
			this.vmethod_39(new global::System.Windows.Forms.Button());
			this.vmethod_41(new global::System.Windows.Forms.ComboBox());
			this.vmethod_43(new global::System.Windows.Forms.Label());
			this.vmethod_45(new global::System.Windows.Forms.TextBox());
			this.vmethod_10().SuspendLayout();
			this.vmethod_16().SuspendLayout();
			this.vmethod_28().SuspendLayout();
			this.vmethod_32().SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_34()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(90, 12);
			this.vmethod_0().Name = "TextBox1";
			this.vmethod_0().Size = new global::System.Drawing.Size(632, 20);
			this.vmethod_0().TabIndex = 6;
			this.vmethod_2().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_2().Location = new global::System.Drawing.Point(4, 16);
			this.vmethod_2().Name = "Label2";
			this.vmethod_2().Size = new global::System.Drawing.Size(75, 13);
			this.vmethod_2().TabIndex = 5;
			this.vmethod_2().Text = "说明:";
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_4().Location = new global::System.Drawing.Point(3, 48);
			this.vmethod_4().Name = "Label3";
			this.vmethod_4().Size = new global::System.Drawing.Size(128, 13);
			this.vmethod_4().TabIndex = 21;
			this.vmethod_4().Text = "条件设置";
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_6().Location = new global::System.Drawing.Point(651, 448);
			this.vmethod_6().Name = "Button2";
			this.vmethod_6().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_6().TabIndex = 24;
			this.vmethod_6().Text = "取消";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_8().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_8().Location = new global::System.Drawing.Point(4, 448);
			this.vmethod_8().Name = "Button1";
			this.vmethod_8().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_8().TabIndex = 23;
			this.vmethod_8().Text = "确认";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_10().Controls.Add(this.vmethod_18());
			this.vmethod_10().Controls.Add(this.vmethod_20());
			this.vmethod_10().Controls.Add(this.vmethod_22());
			this.vmethod_10().Controls.Add(this.vmethod_24());
			this.vmethod_10().Controls.Add(this.vmethod_26());
			this.vmethod_10().Controls.Add(this.vmethod_12());
			this.vmethod_10().Controls.Add(this.vmethod_14());
			this.vmethod_10().Location = new global::System.Drawing.Point(4, 23);
			this.vmethod_10().Name = "TabPage1";
			this.vmethod_10().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_10().Size = new global::System.Drawing.Size(714, 355);
			this.vmethod_10().TabIndex = 0;
			this.vmethod_10().Text = "推演方关系属性";
			this.vmethod_18().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_18().FormattingEnabled = true;
			this.vmethod_18().Items.AddRange(new object[]
			{
				"中立方",
				"友方",
				"非友方",
				"敌方",
				"不明"
			});
			this.vmethod_18().Location = new global::System.Drawing.Point(557, 56);
			this.vmethod_18().Name = "CB_Postures";
			this.vmethod_18().Size = new global::System.Drawing.Size(130, 21);
			this.vmethod_18().TabIndex = 13;
			this.vmethod_20().Location = new global::System.Drawing.Point(530, 59);
			this.vmethod_20().Name = "Label7";
			this.vmethod_20().Size = new global::System.Drawing.Size(21, 13);
			this.vmethod_20().TabIndex = 12;
			this.vmethod_20().Text = "作为:";
			this.vmethod_22().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_22().FormattingEnabled = true;
			this.vmethod_22().Location = new global::System.Drawing.Point(332, 56);
			this.vmethod_22().Name = "CB_TargetSides";
			this.vmethod_22().Size = new global::System.Drawing.Size(192, 21);
			this.vmethod_22().TabIndex = 11;
			this.vmethod_24().Location = new global::System.Drawing.Point(249, 59);
			this.vmethod_24().Name = "Label6";
			this.vmethod_24().Size = new global::System.Drawing.Size(77, 13);
			this.vmethod_24().TabIndex = 10;
			this.vmethod_24().Text = "考虑推演方:";
			this.vmethod_26().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_26().Name = "CB_SidePosture_ModifierNOT";
			this.vmethod_26().Size = new global::System.Drawing.Size(92, 17);
			this.vmethod_26().TabIndex = 9;
			this.vmethod_26().Text = "修饰符: 否";
			this.vmethod_26().UseVisualStyleBackColor = true;
			this.vmethod_12().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_12().FormattingEnabled = true;
			this.vmethod_12().Location = new global::System.Drawing.Point(51, 56);
			this.vmethod_12().Name = "CB_ObserverSides";
			this.vmethod_12().Size = new global::System.Drawing.Size(192, 21);
			this.vmethod_12().TabIndex = 2;
			this.vmethod_14().Location = new global::System.Drawing.Point(14, 59);
			this.vmethod_14().Name = "Label1";
			this.vmethod_14().Size = new global::System.Drawing.Size(31, 13);
			this.vmethod_14().TabIndex = 0;
			this.vmethod_14().Text = "推演方:";
			this.vmethod_16().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_16().Controls.Add(this.vmethod_10());
			this.vmethod_16().Controls.Add(this.vmethod_28());
			this.vmethod_16().Controls.Add(this.vmethod_32());
			this.vmethod_16().Location = new global::System.Drawing.Point(4, 64);
			this.vmethod_16().Multiline = true;
			this.vmethod_16().Name = "TC_ConditionOptions";
			this.vmethod_16().SelectedIndex = 0;
			this.vmethod_16().Size = new global::System.Drawing.Size(722, 382);
			this.vmethod_16().TabIndex = 22;
			this.vmethod_28().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_28().Controls.Add(this.vmethod_30());
			this.vmethod_28().Location = new global::System.Drawing.Point(4, 23);
			this.vmethod_28().Name = "TabPage2";
			this.vmethod_28().Size = new global::System.Drawing.Size(714, 355);
			this.vmethod_28().TabIndex = 1;
			this.vmethod_28().Text = "想定已启动";
			this.vmethod_30().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_30().Name = "CB_ScenHasStarted_ModifierNOT";
			this.vmethod_30().Size = new global::System.Drawing.Size(92, 17);
			this.vmethod_30().TabIndex = 10;
			this.vmethod_30().Text = "修饰字: 否";
			this.vmethod_30().UseVisualStyleBackColor = true;
			this.vmethod_32().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_32().Controls.Add(this.vmethod_34());
			this.vmethod_32().Controls.Add(this.vmethod_36());
			this.vmethod_32().Controls.Add(this.vmethod_38());
			this.vmethod_32().Controls.Add(this.vmethod_40());
			this.vmethod_32().Controls.Add(this.vmethod_42());
			this.vmethod_32().Controls.Add(this.vmethod_44());
			this.vmethod_32().Location = new global::System.Drawing.Point(4, 23);
			this.vmethod_32().Name = "TabPage3";
			this.vmethod_32().Size = new global::System.Drawing.Size(714, 355);
			this.vmethod_32().TabIndex = 2;
			this.vmethod_32().Text = "Lua脚本";
			this.vmethod_34().Location = new global::System.Drawing.Point(661, 8);
			this.vmethod_34().Name = "NUD_LuaScript";
			this.vmethod_34().Size = new global::System.Drawing.Size(45, 20);
			this.vmethod_34().TabIndex = 11;
			this.vmethod_36().Location = new global::System.Drawing.Point(609, 10);
			this.vmethod_36().Name = "Label13";
			this.vmethod_36().Size = new global::System.Drawing.Size(54, 13);
			this.vmethod_36().TabIndex = 10;
			this.vmethod_36().Text = "文字大小:";
			this.vmethod_38().Location = new global::System.Drawing.Point(533, 6);
			this.vmethod_38().Name = "Button_AddLuaScript";
			this.vmethod_38().Size = new global::System.Drawing.Size(75, 21);
			this.vmethod_38().TabIndex = 9;
			this.vmethod_38().Text = "添加";
			this.vmethod_38().UseVisualStyleBackColor = true;
			this.vmethod_40().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_40().FormattingEnabled = true;
			this.vmethod_40().Location = new global::System.Drawing.Point(110, 6);
			this.vmethod_40().Name = "CB_LuaTemplate";
			this.vmethod_40().Size = new global::System.Drawing.Size(417, 21);
			this.vmethod_40().TabIndex = 8;
			this.vmethod_42().Location = new global::System.Drawing.Point(7, 9);
			this.vmethod_42().Name = "Label12";
			this.vmethod_42().Size = new global::System.Drawing.Size(100, 13);
			this.vmethod_42().TabIndex = 7;
			this.vmethod_42().Text = "添加脚本模板:";
			this.vmethod_44().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_44().Location = new global::System.Drawing.Point(7, 36);
			this.vmethod_44().MaxLength = 999999999;
			this.vmethod_44().Multiline = true;
			this.vmethod_44().Name = "TextBox2";
			this.vmethod_44().ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.vmethod_44().Size = new global::System.Drawing.Size(701, 315);
			this.vmethod_44().TabIndex = 6;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(727, 473);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditCondition";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "编辑事件条件";
			this.vmethod_10().ResumeLayout(false);
			this.vmethod_10().PerformLayout();
			this.vmethod_16().ResumeLayout(false);
			this.vmethod_28().ResumeLayout(false);
			this.vmethod_28().PerformLayout();
			this.vmethod_32().ResumeLayout(false);
			this.vmethod_32().PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_34()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04003293 RID: 12947
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

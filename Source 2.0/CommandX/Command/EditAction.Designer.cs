namespace Command
{
	// Token: 0x02000B53 RID: 2899

	public sealed partial class EditAction : global::ns33.CommandForm
	{
		// Token: 0x06005F3F RID: 24383 RVA: 0x002D0244 File Offset: 0x002CE444
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

		// Token: 0x06005F40 RID: 24384 RVA: 0x002D0288 File Offset: 0x002CE488
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.TextBox());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_5(new global::ns15.Control1());
			this.vmethod_7(new global::System.Windows.Forms.TabPage());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_17(new global::System.Windows.Forms.NumericUpDown());
			this.vmethod_19(new global::System.Windows.Forms.ComboBox());
			this.vmethod_21(new global::System.Windows.Forms.Label());
			this.vmethod_23(new global::System.Windows.Forms.Label());
			this.vmethod_25(new global::System.Windows.Forms.TabPage());
			this.vmethod_27(new global::System.Windows.Forms.TabPage());
			this.vmethod_33(new global::ns33.AreaEditor());
			this.vmethod_29(new global::System.Windows.Forms.ListBox());
			this.vmethod_31(new global::System.Windows.Forms.Label());
			this.vmethod_35(new global::System.Windows.Forms.TabPage());
			this.vmethod_73(new global::System.Windows.Forms.Button());
			this.vmethod_57(new global::MSDN.Html.Editor.HtmlEditorControl());
			this.vmethod_37(new global::System.Windows.Forms.ComboBox());
			this.vmethod_39(new global::System.Windows.Forms.Label());
			this.vmethod_41(new global::System.Windows.Forms.Label());
			this.vmethod_43(new global::System.Windows.Forms.TabPage());
			this.vmethod_55(new global::System.Windows.Forms.ComboBox());
			this.vmethod_45(new global::System.Windows.Forms.Label());
			this.vmethod_47(new global::System.Windows.Forms.ComboBox());
			this.vmethod_49(new global::System.Windows.Forms.ComboBox());
			this.vmethod_51(new global::System.Windows.Forms.Label());
			this.vmethod_53(new global::System.Windows.Forms.Label());
			this.vmethod_59(new global::System.Windows.Forms.TabPage());
			this.vmethod_69(new global::System.Windows.Forms.NumericUpDown());
			this.vmethod_71(new global::System.Windows.Forms.Label());
			this.vmethod_61(new global::System.Windows.Forms.Button());
			this.vmethod_63(new global::System.Windows.Forms.ComboBox());
			this.vmethod_65(new global::System.Windows.Forms.Label());
			this.vmethod_67(new global::System.Windows.Forms.TextBox());
			this.vmethod_9(new global::System.Windows.Forms.Label());
			this.vmethod_11(new global::System.Windows.Forms.Button());
			this.vmethod_13(new global::System.Windows.Forms.Button());
			this.vmethod_4().SuspendLayout();
			this.vmethod_6().SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_16()).BeginInit();
			this.vmethod_26().SuspendLayout();
			this.vmethod_34().SuspendLayout();
			this.vmethod_42().SuspendLayout();
			this.vmethod_58().SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_68()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(90, 12);
			this.vmethod_0().Name = "TextBox1";
			this.vmethod_0().Size = new global::System.Drawing.Size(632, 20);
			this.vmethod_0().TabIndex = 6;
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_2().Location = new global::System.Drawing.Point(4, 16);
			this.vmethod_2().Name = "Label2";
			this.vmethod_2().Size = new global::System.Drawing.Size(75, 13);
			this.vmethod_2().TabIndex = 5;
			this.vmethod_2().Text = "描述:";
			this.vmethod_4().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_4().Controls.Add(this.vmethod_6());
			this.vmethod_4().Controls.Add(this.vmethod_24());
			this.vmethod_4().Controls.Add(this.vmethod_26());
			this.vmethod_4().Controls.Add(this.vmethod_34());
			this.vmethod_4().Controls.Add(this.vmethod_42());
			this.vmethod_4().Controls.Add(this.vmethod_58());
			this.vmethod_4().Location = new global::System.Drawing.Point(4, 64);
			this.vmethod_4().Multiline = true;
			this.vmethod_4().Name = "TC_ActionOptions";
			this.vmethod_4().SelectedIndex = 0;
			this.vmethod_4().Size = new global::System.Drawing.Size(722, 382);
			this.vmethod_4().TabIndex = 22;
			this.vmethod_6().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_6().Controls.Add(this.vmethod_14());
			this.vmethod_6().Controls.Add(this.vmethod_16());
			this.vmethod_6().Controls.Add(this.vmethod_18());
			this.vmethod_6().Controls.Add(this.vmethod_20());
			this.vmethod_6().Controls.Add(this.vmethod_22());
			this.vmethod_6().Location = new global::System.Drawing.Point(4, 23);
			this.vmethod_6().Name = "TabPage1";
			this.vmethod_6().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_6().Size = new global::System.Drawing.Size(714, 355);
			this.vmethod_6().TabIndex = 0;
			this.vmethod_6().Text = "评分   ";
			this.vmethod_14().Location = new global::System.Drawing.Point(372, 115);
			this.vmethod_14().Name = "Label5";
			this.vmethod_14().Size = new global::System.Drawing.Size(107, 13);
			this.vmethod_14().TabIndex = 4;
			this.vmethod_14().Text = "(负号为减)";
			this.vmethod_16().Location = new global::System.Drawing.Point(174, 113);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.vmethod_16();
			int[] array = new int[4];
			array[0] = 999999;
			numericUpDown.Maximum = new decimal(array);
			this.vmethod_16().Minimum = new decimal(new int[]
			{
				999999,
				0,
				0,
				-2147483648
			});
			this.vmethod_16().Name = "NUD_Points";
			this.vmethod_16().Size = new global::System.Drawing.Size(192, 20);
			this.vmethod_16().TabIndex = 3;
			this.vmethod_18().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_18().FormattingEnabled = true;
			this.vmethod_18().Location = new global::System.Drawing.Point(174, 85);
			this.vmethod_18().Name = "CB_Points_Sides";
			this.vmethod_18().Size = new global::System.Drawing.Size(192, 21);
			this.vmethod_18().TabIndex = 2;
			this.vmethod_20().Location = new global::System.Drawing.Point(94, 115);
			this.vmethod_20().Name = "Label4";
			this.vmethod_20().Size = new global::System.Drawing.Size(80, 13);
			this.vmethod_20().TabIndex = 1;
			this.vmethod_20().Text = "变化评分:";
			this.vmethod_22().Location = new global::System.Drawing.Point(137, 88);
			this.vmethod_22().Name = "Label1";
			this.vmethod_22().Size = new global::System.Drawing.Size(50, 13);
			this.vmethod_22().TabIndex = 0;
			this.vmethod_22().Text = "推演方:";
			this.vmethod_24().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_24().Location = new global::System.Drawing.Point(4, 23);
			this.vmethod_24().Name = "TabPage2";
			this.vmethod_24().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_24().Size = new global::System.Drawing.Size(714, 355);
			this.vmethod_24().TabIndex = 1;
			this.vmethod_24().Text = "终止想定    ";
			this.vmethod_26().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_26().Controls.Add(this.vmethod_32());
			this.vmethod_26().Controls.Add(this.vmethod_28());
			this.vmethod_26().Controls.Add(this.vmethod_30());
			this.vmethod_26().Location = new global::System.Drawing.Point(4, 23);
			this.vmethod_26().Name = "TabPage3";
			this.vmethod_26().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_26().Size = new global::System.Drawing.Size(714, 355);
			this.vmethod_26().TabIndex = 2;
			this.vmethod_26().Text = "瞬时移动    ";
			this.vmethod_32().Location = new global::System.Drawing.Point(173, 7);
			this.vmethod_32().Name = "AreaEditor1";
			this.vmethod_32().Size = new global::System.Drawing.Size(351, 124);
			this.vmethod_32().TabIndex = 2;
			this.vmethod_32().method_0("Edit teleport area");
			this.vmethod_28().DisplayMember = "Name";
			this.vmethod_28().FormattingEnabled = true;
			this.vmethod_28().Location = new global::System.Drawing.Point(10, 23);
			this.vmethod_28().Name = "ListBox_UnitsToTeleport";
			this.vmethod_28().SelectionMode = global::System.Windows.Forms.SelectionMode.MultiSimple;
			this.vmethod_28().Size = new global::System.Drawing.Size(157, 212);
			this.vmethod_28().TabIndex = 1;
			this.vmethod_30().Location = new global::System.Drawing.Point(7, 7);
			this.vmethod_30().Name = "Label6";
			this.vmethod_30().Size = new global::System.Drawing.Size(132, 13);
			this.vmethod_30().TabIndex = 0;
			this.vmethod_30().Text = "点选要瞬间移动的作战单元:";
			this.vmethod_34().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_34().Controls.Add(this.vmethod_72());
			this.vmethod_34().Controls.Add(this.vmethod_56());
			this.vmethod_34().Controls.Add(this.vmethod_36());
			this.vmethod_34().Controls.Add(this.vmethod_38());
			this.vmethod_34().Controls.Add(this.vmethod_40());
			this.vmethod_34().Location = new global::System.Drawing.Point(4, 23);
			this.vmethod_34().Name = "TabPage4";
			this.vmethod_34().Size = new global::System.Drawing.Size(714, 355);
			this.vmethod_34().TabIndex = 3;
			this.vmethod_34().Text = "消息  ";
			this.vmethod_72().Location = new global::System.Drawing.Point(636, 18);
			this.vmethod_72().Name = "Button3";
			this.vmethod_72().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_72().TabIndex = 29;
			this.vmethod_72().Text = "编辑HTML";
			this.vmethod_72().UseVisualStyleBackColor = true;
			this.vmethod_56().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_56().InnerText = null;
			this.vmethod_56().Location = new global::System.Drawing.Point(72, 47);
			this.vmethod_56().Name = "Editor_Message_Text";
			this.vmethod_56().Size = new global::System.Drawing.Size(639, 308);
			this.vmethod_56().TabIndex = 28;
			this.vmethod_36().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_36().FormattingEnabled = true;
			this.vmethod_36().Location = new global::System.Drawing.Point(73, 14);
			this.vmethod_36().Name = "CB_Message_Side";
			this.vmethod_36().Size = new global::System.Drawing.Size(231, 21);
			this.vmethod_36().TabIndex = 7;
			this.vmethod_38().Location = new global::System.Drawing.Point(13, 47);
			this.vmethod_38().Name = "Label8";
			this.vmethod_38().Size = new global::System.Drawing.Size(45, 13);
			this.vmethod_38().TabIndex = 6;
			this.vmethod_38().Text = "消息:";
			this.vmethod_40().Location = new global::System.Drawing.Point(13, 17);
			this.vmethod_40().Name = "Label9";
			this.vmethod_40().Size = new global::System.Drawing.Size(50, 13);
			this.vmethod_40().TabIndex = 5;
			this.vmethod_40().Text = "推演方:";
			this.vmethod_42().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_42().Controls.Add(this.vmethod_54());
			this.vmethod_42().Controls.Add(this.vmethod_44());
			this.vmethod_42().Controls.Add(this.vmethod_46());
			this.vmethod_42().Controls.Add(this.vmethod_48());
			this.vmethod_42().Controls.Add(this.vmethod_50());
			this.vmethod_42().Controls.Add(this.vmethod_52());
			this.vmethod_42().Location = new global::System.Drawing.Point(4, 23);
			this.vmethod_42().Name = "TabPage5";
			this.vmethod_42().Size = new global::System.Drawing.Size(714, 355);
			this.vmethod_42().TabIndex = 4;
			this.vmethod_42().Text = "任务状态";
			this.vmethod_54().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_54().FormattingEnabled = true;
			this.vmethod_54().Items.AddRange(new object[]
			{
				"Active",
				"Inactive"
			});
			this.vmethod_54().Location = new global::System.Drawing.Point(73, 68);
			this.vmethod_54().Name = "CB_MissionStatus_Status";
			this.vmethod_54().Size = new global::System.Drawing.Size(231, 21);
			this.vmethod_54().TabIndex = 14;
			this.vmethod_44().Location = new global::System.Drawing.Point(13, 71);
			this.vmethod_44().Name = "Label11";
			this.vmethod_44().Size = new global::System.Drawing.Size(63, 13);
			this.vmethod_44().TabIndex = 13;
			this.vmethod_44().Text = "新状态:";
			this.vmethod_46().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_46().FormattingEnabled = true;
			this.vmethod_46().Location = new global::System.Drawing.Point(73, 41);
			this.vmethod_46().Name = "CB_MissionStatus_Mission";
			this.vmethod_46().Size = new global::System.Drawing.Size(231, 21);
			this.vmethod_46().TabIndex = 12;
			this.vmethod_48().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_48().FormattingEnabled = true;
			this.vmethod_48().Location = new global::System.Drawing.Point(73, 14);
			this.vmethod_48().Name = "CB_MissionStatus_Side";
			this.vmethod_48().Size = new global::System.Drawing.Size(231, 21);
			this.vmethod_48().TabIndex = 11;
			this.vmethod_50().Location = new global::System.Drawing.Point(13, 44);
			this.vmethod_50().Name = "Label7";
			this.vmethod_50().Size = new global::System.Drawing.Size(45, 13);
			this.vmethod_50().TabIndex = 10;
			this.vmethod_50().Text = "任务:";
			this.vmethod_52().Location = new global::System.Drawing.Point(13, 17);
			this.vmethod_52().Name = "Label10";
			this.vmethod_52().Size = new global::System.Drawing.Size(40, 13);
			this.vmethod_52().TabIndex = 9;
			this.vmethod_52().Text = "推演方:";
			this.vmethod_58().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_58().Controls.Add(this.vmethod_68());
			this.vmethod_58().Controls.Add(this.vmethod_70());
			this.vmethod_58().Controls.Add(this.vmethod_60());
			this.vmethod_58().Controls.Add(this.vmethod_62());
			this.vmethod_58().Controls.Add(this.vmethod_64());
			this.vmethod_58().Controls.Add(this.vmethod_66());
			this.vmethod_58().Location = new global::System.Drawing.Point(4, 23);
			this.vmethod_58().Name = "TabPage6";
			this.vmethod_58().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_58().Size = new global::System.Drawing.Size(714, 355);
			this.vmethod_58().TabIndex = 5;
			this.vmethod_58().Text = "Lua脚本  ";
			this.vmethod_68().Location = new global::System.Drawing.Point(660, 9);
			this.vmethod_68().Name = "NUD_LuaScript";
			this.vmethod_68().Size = new global::System.Drawing.Size(45, 20);
			this.vmethod_68().TabIndex = 5;
			this.vmethod_70().Location = new global::System.Drawing.Point(608, 11);
			this.vmethod_70().Name = "Label13";
			this.vmethod_70().Size = new global::System.Drawing.Size(54, 13);
			this.vmethod_70().TabIndex = 4;
			this.vmethod_70().Text = "文字大小:";
			this.vmethod_60().Location = new global::System.Drawing.Point(532, 7);
			this.vmethod_60().Name = "Button_AddLuaScript";
			this.vmethod_60().Size = new global::System.Drawing.Size(75, 21);
			this.vmethod_60().TabIndex = 3;
			this.vmethod_60().Text = "添加";
			this.vmethod_60().UseVisualStyleBackColor = true;
			this.vmethod_62().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_62().FormattingEnabled = true;
			this.vmethod_62().Location = new global::System.Drawing.Point(109, 7);
			this.vmethod_62().Name = "CB_LuaTemplate";
			this.vmethod_62().Size = new global::System.Drawing.Size(417, 21);
			this.vmethod_62().TabIndex = 2;
			this.vmethod_64().Location = new global::System.Drawing.Point(6, 10);
			this.vmethod_64().Name = "Label12";
			this.vmethod_64().Size = new global::System.Drawing.Size(100, 13);
			this.vmethod_64().TabIndex = 1;
			this.vmethod_64().Text = "添加脚本模板:";
			this.vmethod_66().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_66().Location = new global::System.Drawing.Point(6, 37);
			this.vmethod_66().MaxLength = 999999999;
			this.vmethod_66().Multiline = true;
			this.vmethod_66().Name = "TextBox2";
			this.vmethod_66().ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.vmethod_66().Size = new global::System.Drawing.Size(701, 315);
			this.vmethod_66().TabIndex = 0;
			this.vmethod_8().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_8().Location = new global::System.Drawing.Point(3, 48);
			this.vmethod_8().Name = "Label3";
			this.vmethod_8().Size = new global::System.Drawing.Size(111, 15);
			this.vmethod_8().TabIndex = 21;
			this.vmethod_8().Text = "动作设置";
			this.vmethod_10().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_10().Location = new global::System.Drawing.Point(651, 448);
			this.vmethod_10().Name = "Button2";
			this.vmethod_10().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_10().TabIndex = 24;
			this.vmethod_10().Text = "取消";
			this.vmethod_10().UseVisualStyleBackColor = true;
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_12().Location = new global::System.Drawing.Point(4, 448);
			this.vmethod_12().Name = "Button1";
			this.vmethod_12().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_12().TabIndex = 23;
			this.vmethod_12().Text = "确认";
			this.vmethod_12().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(727, 473);
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditAction";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "编辑事件动作";
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_6().ResumeLayout(false);
			this.vmethod_6().PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_16()).EndInit();
			this.vmethod_26().ResumeLayout(false);
			this.vmethod_26().PerformLayout();
			this.vmethod_34().ResumeLayout(false);
			this.vmethod_34().PerformLayout();
			this.vmethod_42().ResumeLayout(false);
			this.vmethod_42().PerformLayout();
			this.vmethod_58().ResumeLayout(false);
			this.vmethod_58().PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_68()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04003266 RID: 12902
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

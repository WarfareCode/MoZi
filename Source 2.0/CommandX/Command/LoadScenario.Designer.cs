namespace Command
{
	// Token: 0x02000A04 RID: 2564
	public sealed partial class LoadScenario : global::ns33.CommandForm
	{
		// Token: 0x06004DE6 RID: 19942 RVA: 0x001F4720 File Offset: 0x001F2920
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

		// Token: 0x06004DE7 RID: 19943 RVA: 0x001F4764 File Offset: 0x001F2964
		private void InitializeComponent()
		{
			this.SetButton_LoadSelected(new global::System.Windows.Forms.Button());
			this.vmethod_3(new global::System.Windows.Forms.TreeView());
			this.vmethod_5(new global::System.Windows.Forms.TabControl());
			this.vmethod_7(new global::System.Windows.Forms.TabPage());
			this.vmethod_9(new global::System.Windows.Forms.TabPage());
			this.vmethod_11(new global::System.Windows.Forms.TreeView());
			this.vmethod_13(new global::System.Windows.Forms.Button());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_17(new global::System.Windows.Forms.ProgressBar());
			this.vmethod_19(new global::System.Windows.Forms.Label());
			this.vmethod_21(new global::System.Windows.Forms.WebBrowser());
			this.vmethod_23(new global::System.Windows.Forms.Label());
			this.vmethod_25(new global::System.Windows.Forms.Label());
			this.vmethod_27(new global::System.Windows.Forms.ProgressBar());
			this.vmethod_29(new global::System.Windows.Forms.ProgressBar());
			this.vmethod_31(new global::System.Windows.Forms.Label());
			this.vmethod_33(new global::System.Windows.Forms.Label());
			this.vmethod_35(new global::System.Windows.Forms.ComboBox());
			this.vmethod_4().SuspendLayout();
			this.vmethod_6().SuspendLayout();
			this.vmethod_8().SuspendLayout();
			base.SuspendLayout();
			this.GetButton_LoadSelected().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.GetButton_LoadSelected().DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.GetButton_LoadSelected().Location = new global::System.Drawing.Point(420, 566);
			this.GetButton_LoadSelected().Name = "Button2";
			this.GetButton_LoadSelected().Size = new global::System.Drawing.Size(135, 23);
			this.GetButton_LoadSelected().TabIndex = 2;
			this.GetButton_LoadSelected().Text = "加载想定";
			this.GetButton_LoadSelected().UseVisualStyleBackColor = true;
			this.vmethod_2().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_2().Location = new global::System.Drawing.Point(3, 3);
			this.vmethod_2().Name = "TV_Scens";
			this.vmethod_2().Size = new global::System.Drawing.Size(388, 514);
			this.vmethod_2().TabIndex = 5;
			this.vmethod_4().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_4().Controls.Add(this.vmethod_6());
			this.vmethod_4().Controls.Add(this.vmethod_8());
			this.vmethod_4().Location = new global::System.Drawing.Point(12, 43);
			this.vmethod_4().Name = "TabControl1";
			this.vmethod_4().SelectedIndex = 0;
			this.vmethod_4().Size = new global::System.Drawing.Size(402, 546);
			this.vmethod_4().TabIndex = 6;
			this.vmethod_6().Controls.Add(this.vmethod_2());
			this.vmethod_6().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_6().Name = "TabPage1";
			this.vmethod_6().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_6().Size = new global::System.Drawing.Size(394, 520);
			this.vmethod_6().TabIndex = 0;
			this.vmethod_6().Text = "作战想定";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_8().Controls.Add(this.vmethod_10());
			this.vmethod_8().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_8().Name = "TabPage2";
			this.vmethod_8().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_8().Size = new global::System.Drawing.Size(394, 520);
			this.vmethod_8().TabIndex = 1;
			this.vmethod_8().Text = "保存推演";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_10().Location = new global::System.Drawing.Point(3, 3);
			this.vmethod_10().Name = "TV_Saves";
			this.vmethod_10().Size = new global::System.Drawing.Size(388, 514);
			this.vmethod_10().TabIndex = 6;
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_12().Location = new global::System.Drawing.Point(892, 566);
			this.vmethod_12().Name = "Button1";
			this.vmethod_12().Size = new global::System.Drawing.Size(104, 23);
			this.vmethod_12().TabIndex = 9;
			this.vmethod_12().Text = "取消";
			this.vmethod_12().UseVisualStyleBackColor = true;
			this.vmethod_14().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Regular);
			this.vmethod_14().ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 0, 0);
			this.vmethod_14().Location = new global::System.Drawing.Point(419, 12);
			this.vmethod_14().Name = "Label_Title";
			this.vmethod_14().Size = new global::System.Drawing.Size(113, 19);
			this.vmethod_14().TabIndex = 10;
			this.vmethod_14().Text = "想定名称：";
			this.vmethod_14().TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.vmethod_14().Visible = true;
			this.vmethod_16().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_16().Location = new global::System.Drawing.Point(480, 546);
			this.vmethod_16().Name = "PB_PercentComplete";
			this.vmethod_16().Size = new global::System.Drawing.Size(516, 12);
			this.vmethod_16().TabIndex = 13;
			this.vmethod_18().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_18().Location = new global::System.Drawing.Point(420, 545);
			this.vmethod_18().Name = "Label_Loading";
			this.vmethod_18().Size = new global::System.Drawing.Size(54, 13);
			this.vmethod_18().TabIndex = 14;
			this.vmethod_18().Text = "作战想定加载中...";
			this.vmethod_20().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_20().Location = new global::System.Drawing.Point(423, 89);
			this.vmethod_20().MinimumSize = new global::System.Drawing.Size(20, 20);
			this.vmethod_20().Name = "WebBrowser1";
			this.vmethod_20().Size = new global::System.Drawing.Size(573, 450);
			this.vmethod_20().TabIndex = 15;
			this.vmethod_20().Visible = false;
			this.vmethod_22().ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 0, 0);
			this.vmethod_22().Location = new global::System.Drawing.Point(420, 43);
			this.vmethod_22().Name = "Label1";
			this.vmethod_22().Size = new global::System.Drawing.Size(70, 16);
			this.vmethod_22().TabIndex = 16;
			this.vmethod_22().Text = "难度:";
			this.vmethod_22().Visible = false;
			this.vmethod_24().ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 0, 0);
			this.vmethod_24().Location = new global::System.Drawing.Point(635, 45);
			this.vmethod_24().Name = "Label2";
			this.vmethod_24().Size = new global::System.Drawing.Size(70, 16);
			this.vmethod_24().TabIndex = 17;
			this.vmethod_24().Text = "复杂度:";
			this.vmethod_24().Visible = false;
			this.vmethod_26().ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 0, 0);
			this.vmethod_26().Location = new global::System.Drawing.Point(504, 45);
			this.vmethod_26().Name = "PB_Difficulty";
			this.vmethod_26().Size = new global::System.Drawing.Size(100, 16);
			this.vmethod_26().TabIndex = 19;
			this.vmethod_26().Visible = false;
			this.vmethod_28().ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 0, 0);
			this.vmethod_28().Location = new global::System.Drawing.Point(722, 45);
			this.vmethod_28().Name = "PB_Complexity";
			this.vmethod_28().Size = new global::System.Drawing.Size(100, 16);
			this.vmethod_28().TabIndex = 20;
			this.vmethod_28().Visible = false;
			this.vmethod_30().ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 0, 0);
			this.vmethod_30().Location = new global::System.Drawing.Point(420, 65);
			this.vmethod_30().Name = "Label4";
			this.vmethod_30().Size = new global::System.Drawing.Size(571, 18);
			this.vmethod_30().TabIndex = 21;
			this.vmethod_30().Text = "位置 / 设置:";
			this.vmethod_30().Visible = false;
			this.vmethod_32().Location = new global::System.Drawing.Point(12, 17);
			this.vmethod_32().Name = "Label5";
			this.vmethod_32().Size = new global::System.Drawing.Size(98, 13);
			this.vmethod_32().TabIndex = 23;
			this.vmethod_32().Text = "作战想定排序条件:";
			this.vmethod_34().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_34().FormattingEnabled = true;
			this.vmethod_34().Items.AddRange(new object[]
			{
				"名称",
				"日期",
				"难度",
				"复杂度"
			});
			this.vmethod_34().Location = new global::System.Drawing.Point(117, 12);
			this.vmethod_34().Name = "CB_ScenOrder";
			this.vmethod_34().Size = new global::System.Drawing.Size(159, 21);
			this.vmethod_34().TabIndex = 24;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.GetButton_LoadSelected();
			base.ClientSize = new global::System.Drawing.Size(1008, 601);
			base.Controls.Add(this.vmethod_28());
			base.Controls.Add(this.vmethod_26());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_30());
			base.Controls.Add(this.vmethod_34());
			base.Controls.Add(this.vmethod_32());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.GetButton_LoadSelected());
			base.Controls.Add(this.vmethod_14());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "LoadScenario";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "加载作战想定";
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_6().ResumeLayout(false);
			this.vmethod_8().ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040024CD RID: 9421
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace ns34
{
	// Token: 0x02000A03 RID: 2563
	
	public sealed partial class Evaluation : global::ns33.CommandForm
	{
		// Token: 0x06004DC2 RID: 19906 RVA: 0x001F317C File Offset: 0x001F137C
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

		// Token: 0x06004DC3 RID: 19907 RVA: 0x001F31C0 File Offset: 0x001F13C0
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_5(new global::System.Windows.Forms.TabControl());
			this.vmethod_7(new global::System.Windows.Forms.TabPage());
			this.vmethod_17(new global::System.Windows.Forms.Label());
			this.vmethod_15(new global::System.Windows.Forms.Button());
			this.vmethod_13(new global::System.Windows.Forms.Button());
			this.vmethod_9(new global::System.Windows.Forms.TabPage());
			this.vmethod_11(new global::System.Windows.Forms.TextBox());
			this.vmethod_19(new global::System.Windows.Forms.TabPage());
			this.vmethod_21(new global::System.Windows.Forms.TextBox());
			this.vmethod_4().SuspendLayout();
			this.vmethod_6().SuspendLayout();
			this.vmethod_8().SuspendLayout();
			this.vmethod_18().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().AutoSize = true;
			this.vmethod_0().Font = new global::System.Drawing.Font("Times New Roman", 64f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_0().Location = new global::System.Drawing.Point(8, 12);
			this.vmethod_0().Name = "Label_Evaluation";
			this.vmethod_0().Size = new global::System.Drawing.Size(651, 98);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "Label_Evaluation";
			this.vmethod_0().TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 32f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_2().Location = new global::System.Drawing.Point(16, 135);
			this.vmethod_2().Name = "Label_Score";
			this.vmethod_2().Size = new global::System.Drawing.Size(265, 51);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Label_Score";
			this.vmethod_4().Controls.Add(this.vmethod_6());
			this.vmethod_4().Controls.Add(this.vmethod_8());
			this.vmethod_4().Controls.Add(this.vmethod_18());
			this.vmethod_4().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_4().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_4().Name = "TabControl1";
			this.vmethod_4().SelectedIndex = 0;
			this.vmethod_4().Size = new global::System.Drawing.Size(707, 422);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_6().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_6().Controls.Add(this.vmethod_16());
			this.vmethod_6().Controls.Add(this.vmethod_14());
			this.vmethod_6().Controls.Add(this.vmethod_12());
			this.vmethod_6().Controls.Add(this.vmethod_0());
			this.vmethod_6().Controls.Add(this.vmethod_2());
			this.vmethod_6().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_6().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_6().Name = "TabPage1";
			this.vmethod_6().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_6().Size = new global::System.Drawing.Size(699, 396);
			this.vmethod_6().TabIndex = 0;
			this.vmethod_6().Text = "评估";
			this.vmethod_16().AutoSize = true;
			this.vmethod_16().Location = new global::System.Drawing.Point(5, 303);
			this.vmethod_16().Name = "Label_PassScoreReached";
			this.vmethod_16().Size = new global::System.Drawing.Size(156, 13);
			this.vmethod_16().TabIndex = 4;
			this.vmethod_16().Text = "Label_PassScoreReached";
			this.vmethod_14().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_14().Location = new global::System.Drawing.Point(514, 341);
			this.vmethod_14().Name = "Button_ContinueCampaign";
			this.vmethod_14().Size = new global::System.Drawing.Size(177, 47);
			this.vmethod_14().TabIndex = 3;
			this.vmethod_14().Text = "继续进行战役推演";
			this.vmethod_14().UseVisualStyleBackColor = true;
			this.vmethod_12().Location = new global::System.Drawing.Point(8, 341);
			this.vmethod_12().Name = "Button1";
			this.vmethod_12().Size = new global::System.Drawing.Size(177, 47);
			this.vmethod_12().TabIndex = 2;
			this.vmethod_12().Text = "立即终止推演(退出)";
			this.vmethod_12().UseVisualStyleBackColor = true;
			this.vmethod_8().Controls.Add(this.vmethod_10());
			this.vmethod_8().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_8().Name = "TabPage2";
			this.vmethod_8().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_8().Size = new global::System.Drawing.Size(699, 396);
			this.vmethod_8().TabIndex = 1;
			this.vmethod_8().Text = "战损与消耗";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_10().Location = new global::System.Drawing.Point(3, 3);
			this.vmethod_10().Multiline = true;
			this.vmethod_10().Name = "TextBox1";
			this.vmethod_10().ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.vmethod_10().Size = new global::System.Drawing.Size(693, 390);
			this.vmethod_10().TabIndex = 0;
			this.vmethod_18().Controls.Add(this.vmethod_20());
			this.vmethod_18().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_18().Name = "TabPage3";
			this.vmethod_18().Size = new global::System.Drawing.Size(699, 396);
			this.vmethod_18().TabIndex = 2;
			this.vmethod_18().Text = "评分记录";
			this.vmethod_18().UseVisualStyleBackColor = true;
			this.vmethod_20().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_20().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_20().Multiline = true;
			this.vmethod_20().Name = "TextBox_ScoringLog";
			this.vmethod_20().ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.vmethod_20().Size = new global::System.Drawing.Size(699, 396);
			this.vmethod_20().TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(707, 422);
			base.Controls.Add(this.vmethod_4());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Evaluation";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "参演方评估";
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_6().ResumeLayout(false);
			this.vmethod_6().PerformLayout();
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_8().PerformLayout();
			this.vmethod_18().ResumeLayout(false);
			this.vmethod_18().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040024B9 RID: 9401
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

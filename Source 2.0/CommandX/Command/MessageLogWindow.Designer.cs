namespace Command
{
	// Token: 0x02000A10 RID: 2576
	public sealed partial class MessageLogWindow : global::ns33.CommandForm
	{
		// Token: 0x06004F31 RID: 20273 RVA: 0x001FE0D0 File Offset: 0x001FC2D0
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

		// Token: 0x06004F32 RID: 20274 RVA: 0x001FE114 File Offset: 0x001FC314
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.WebBrowser());
			this.vmethod_3(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_5(new global::System.Windows.Forms.ToolStripLabel());
			this.vmethod_7(new global::System.Windows.Forms.ToolStripTextBox());
			this.vmethod_2().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 27);
			this.vmethod_0().Margin = new global::System.Windows.Forms.Padding(0);
			this.vmethod_0().MinimumSize = new global::System.Drawing.Size(20, 20);
			this.vmethod_0().Name = "WebBrowser1";
			this.vmethod_0().Size = new global::System.Drawing.Size(1040, 705);
			this.vmethod_0().TabIndex = 24;
			this.vmethod_2().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_4(),
				this.vmethod_6()
			});
			this.vmethod_2().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_2().Name = "ToolStrip1";
			this.vmethod_2().Size = new global::System.Drawing.Size(1040, 25);
			this.vmethod_2().TabIndex = 25;
			this.vmethod_2().Text = "ToolStrip1";
			this.vmethod_4().Name = "ToolStripLabel1";
			this.vmethod_4().Size = new global::System.Drawing.Size(36, 22);
			this.vmethod_4().Text = "过滤:";
			this.vmethod_6().Name = "TSTB_Filter";
			this.vmethod_6().Size = new global::System.Drawing.Size(500, 25);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1040, 732);
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			this.DoubleBuffered = true;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MessageLogWindow";
			base.ShowIcon = false;
			this.Text = "消息日志";
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002559 RID: 9561
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace ns34
{
	// Token: 0x02000A0E RID: 2574
	
	public sealed partial class Losses : global::ns33.CommandForm
	{
		// Token: 0x06004F1A RID: 20250 RVA: 0x001FD658 File Offset: 0x001FB858
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

		// Token: 0x06004F1B RID: 20251 RVA: 0x001FD69C File Offset: 0x001FB89C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns34.Losses));
			this.vmethod_1(new global::System.Windows.Forms.TextBox());
			this.vmethod_3(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_5(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_7(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_2().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 28);
			this.vmethod_0().Multiline = true;
			this.vmethod_0().Name = "TextBox1";
			this.vmethod_0().ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.vmethod_0().Size = new global::System.Drawing.Size(500, 316);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_4(),
				this.vmethod_6()
			});
			this.vmethod_2().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_2().Name = "TS1";
			this.vmethod_2().Size = new global::System.Drawing.Size(500, 25);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "ToolStrip1";
			this.vmethod_4().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //ZSP ERR IMG this.vmethod_4().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_ResetAll.Image");
            this.vmethod_4().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_4().Name = "TSB_ResetAll";
			this.vmethod_4().Size = new global::System.Drawing.Size(165, 22);
			this.vmethod_4().Text = "重置所有战损/消耗";
			this.vmethod_6().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //ZSP ERR IMG this.vmethod_6().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSMI_ResetScore.Image");
            this.vmethod_6().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_6().Name = "TSMI_ResetScore";
			this.vmethod_6().Size = new global::System.Drawing.Size(118, 22);
			this.vmethod_6().Text = "重置所有推演方分数";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(500, 344);
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Losses";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "战损与消耗";
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002551 RID: 9553
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace ns34
{
	// Token: 0x020009E5 RID: 2533
	
	public sealed partial class NewMessageForm : global::ns33.CommandForm
	{
		// Token: 0x06004AE3 RID: 19171 RVA: 0x001D3724 File Offset: 0x001D1924
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

		// Token: 0x06004AE4 RID: 19172 RVA: 0x001D3768 File Offset: 0x001D1968
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns34.NewMessageForm));
			this.vmethod_1(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_9(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_11(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_3(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_5(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_7(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_13(new global::System.Windows.Forms.WebBrowser());
			this.vmethod_0().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.vmethod_0().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_0().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_8(),
				this.vmethod_10(),
				this.vmethod_2(),
				this.vmethod_4(),
				this.vmethod_6()
			});
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 167);
			this.vmethod_0().Name = "ToolStrip1";
			this.vmethod_0().Size = new global::System.Drawing.Size(434, 25);
			this.vmethod_0().Stretch = true;
			this.vmethod_0().TabIndex = 4;
			this.vmethod_0().Text = "ToolStrip1";
            //ZSP ERR IMG this.vmethod_8().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_PrevMessage.Image");
            this.vmethod_8().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_8().Name = "TSB_PrevMessage";
			this.vmethod_8().Size = new global::System.Drawing.Size(72, 22);
			this.vmethod_8().Text = "前一条";
            //ZSP ERR IMG this.vmethod_10().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_NextMessage.Image");
            this.vmethod_10().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_10().Name = "TSB_NextMessage";
			this.vmethod_10().Size = new global::System.Drawing.Size(51, 22);
			this.vmethod_10().Text = "下一条";
            //ZSP ERR IMG this.vmethod_2().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton1.Image");
            this.vmethod_2().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_2().Name = "ToolStripButton1";
			this.vmethod_2().Size = new global::System.Drawing.Size(119, 22);
			this.vmethod_2().Text = "跳到位置";
            //ZSP ERR IMG this.vmethod_4().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton2.Image");
            this.vmethod_4().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_4().Name = "ToolStripButton2";
			this.vmethod_4().Size = new global::System.Drawing.Size(56, 22);
			this.vmethod_4().Text = "关闭";
            //ZSP ERR IMG this.vmethod_6().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton3.Image");
            this.vmethod_6().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_6().Name = "ToolStripButton3";
			this.vmethod_6().Size = new global::System.Drawing.Size(112, 22);
			this.vmethod_6().Text = "关闭 + 恢复";
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_12().Location = new global::System.Drawing.Point(0, 2);
			this.vmethod_12().MinimumSize = new global::System.Drawing.Size(20, 20);
			this.vmethod_12().Name = "WebBrowser1";
			this.vmethod_12().Size = new global::System.Drawing.Size(434, 162);
			this.vmethod_12().TabIndex = 16;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(434, 192);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "NewMessageForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "新消息";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_0().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002328 RID: 9000
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace ns33
{
	// Token: 0x020009C0 RID: 2496
	
	public sealed partial class CustomLayersForm : global::ns33.CommandForm
	{
		// Token: 0x060042CF RID: 17103 RVA: 0x001862D0 File Offset: 0x001844D0
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

		// Token: 0x060042D0 RID: 17104 RVA: 0x00186314 File Offset: 0x00184514
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns33.CustomLayersForm));
			this.vmethod_1(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_3(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_5(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_7(new global::System.Windows.Forms.ListBox());
			this.vmethod_0().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_0().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_2(),
				this.vmethod_4()
			});
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Name = "ToolStrip1";
			this.vmethod_0().Size = new global::System.Drawing.Size(727, 25);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "ToolStrip1";
            //ZSP ERR IMG this.vmethod_2().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton1.Image");
            this.vmethod_2().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_2().Name = "ToolStripButton1";
			this.vmethod_2().Size = new global::System.Drawing.Size(80, 22);
			this.vmethod_2().Text = "添加图层";
            //ZSP ERR IMG this.vmethod_4().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton2.Image");
            this.vmethod_4().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_4().Name = "ToolStripButton2";
			this.vmethod_4().Size = new global::System.Drawing.Size(117, 22);
			this.vmethod_4().Text = "删除选定图层";
			this.vmethod_6().DisplayMember = "Name";
			this.vmethod_6().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_6().FormattingEnabled = true;
			this.vmethod_6().Location = new global::System.Drawing.Point(0, 25);
			this.vmethod_6().Name = "ListBox1";
			this.vmethod_6().Size = new global::System.Drawing.Size(727, 282);
			this.vmethod_6().TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(727, 307);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CustomLayersForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "自定义图层管理器";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_0().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001F33 RID: 7987
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

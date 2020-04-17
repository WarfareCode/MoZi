namespace ns34
{
	// Token: 0x020009F7 RID: 2551
	
	public sealed partial class RegressionTests : global::ns33.CommandForm
	{
		// Token: 0x06004C9F RID: 19615 RVA: 0x001E6620 File Offset: 0x001E4820
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

		// Token: 0x06004CA0 RID: 19616 RVA: 0x001E6664 File Offset: 0x001E4864
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.TextBox());
			base.SuspendLayout();
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Multiline = true;
			this.vmethod_0().Name = "TextBox1";
			this.vmethod_0().ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.vmethod_0().Size = new global::System.Drawing.Size(544, 378);
			this.vmethod_0().TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(544, 378);
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RegressionTests";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Regression Tests";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400241F RID: 9247
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace ns34
{
	// Token: 0x020009A2 RID: 2466
	
	public sealed partial class LoadSaveProgress : global::ns33.CommandForm
	{
		// Token: 0x06004024 RID: 16420 RVA: 0x0015A148 File Offset: 0x00158348
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

		// Token: 0x06004025 RID: 16421 RVA: 0x0015A18C File Offset: 0x0015838C
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Label());
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().AutoSize = true;
			this.vmethod_0().Location = new global::System.Drawing.Point(12, 9);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new global::System.Drawing.Size(39, 13);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_0().Text = "Label1";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(216, 31);
			base.ControlBox = false;
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "LoadSaveProgress";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001D78 RID: 7544
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

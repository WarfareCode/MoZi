namespace ns34
{
	// Token: 0x020009FC RID: 2556
	
	public sealed partial class ResumeFromSave : global::ns33.CommandForm
	{
		// Token: 0x06004D13 RID: 19731 RVA: 0x001EB0EC File Offset: 0x001E92EC
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

		// Token: 0x06004D14 RID: 19732 RVA: 0x001EB130 File Offset: 0x001E9330
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.ProgressBar());
			base.SuspendLayout();
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Name = "PB_PercentComplete";
			this.vmethod_0().Size = new global::System.Drawing.Size(298, 65);
			this.vmethod_0().TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(298, 65);
			base.ControlBox = false;
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ResumeFromSave";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Resuming from save...";
			base.ResumeLayout(false);
		}

		// Token: 0x04002473 RID: 9331
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

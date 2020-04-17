namespace ns34
{
	// Token: 0x02000CF4 RID: 3316
	
	public sealed partial class VideoWindow : global::System.Windows.Forms.Form
	{
		// Token: 0x060072EC RID: 29420 RVA: 0x004186F4 File Offset: 0x004168F4
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

		// Token: 0x060072ED RID: 29421 RVA: 0x00418738 File Offset: 0x00416938
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(646, 429);
			base.ControlBox = false;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "VideoWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.ResumeLayout(false);
		}

		// Token: 0x04004158 RID: 16728
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

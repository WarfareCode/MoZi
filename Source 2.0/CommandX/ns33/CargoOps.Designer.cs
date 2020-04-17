namespace ns33
{
	// Token: 0x02000CE7 RID: 3303
	
	public sealed partial class CargoOps : global::System.Windows.Forms.Form
	{
		// Token: 0x06006C4B RID: 27723 RVA: 0x003CE410 File Offset: 0x003CC610
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

		// Token: 0x06006C4C RID: 27724 RVA: 0x003CE454 File Offset: 0x003CC654
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Integration.ElementHost());
			this.cargoOpsControl_0 = new global::Command.CargoOpsControl();
			base.SuspendLayout();
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Name = "ElementHost1";
			this.vmethod_0().Size = new global::System.Drawing.Size(784, 261);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "ElementHost1";
			this.vmethod_0().Child = this.cargoOpsControl_0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(784, 261);
			base.Controls.Add(this.vmethod_0());
			base.Name = "CargoOps";
			this.Text = "货物对话框";
			base.ResumeLayout(false);
		}

		// Token: 0x04003E64 RID: 15972
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04003E66 RID: 15974
		internal global::Command.CargoOpsControl cargoOpsControl_0;
	}
}

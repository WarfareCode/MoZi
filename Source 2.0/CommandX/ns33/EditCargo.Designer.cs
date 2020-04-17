namespace ns33
{
	// Token: 0x02000CE8 RID: 3304
	public sealed partial class EditCargo : global::System.Windows.Forms.Form
	{
		// Token: 0x06006C51 RID: 27729 RVA: 0x003CE56C File Offset: 0x003CC76C
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

		// Token: 0x06006C52 RID: 27730 RVA: 0x003CE5B0 File Offset: 0x003CC7B0
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Integration.ElementHost());
			this.editCargoControl_0 = new global::Command.EditCargoControl();
			base.SuspendLayout();
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Name = "ElementHost1";
			this.vmethod_0().Size = new global::System.Drawing.Size(746, 328);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "ElementHost1";
			this.vmethod_0().Child = this.editCargoControl_0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(746, 328);
			base.Controls.Add(this.vmethod_0());
			base.Name = "EditCargo";
			this.Text = "EditCargo";
			base.ResumeLayout(false);
		}

		// Token: 0x04003E69 RID: 15977
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04003E6B RID: 15979
		internal global::Command.EditCargoControl editCargoControl_0;
	}
}

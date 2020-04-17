namespace ns33
{
	// Token: 0x02000CEA RID: 3306
	
	public sealed partial class RealismDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06006CA9 RID: 27817 RVA: 0x003D0578 File Offset: 0x003CE778
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

		// Token: 0x06006CAA RID: 27818 RVA: 0x003D05BC File Offset: 0x003CE7BC
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Integration.ElementHost());
			this.realismDialogControl_0 = new global::Command.RealismDialogControl();
			base.SuspendLayout();
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Name = "ElementHost1";
			this.vmethod_0().Size = new global::System.Drawing.Size(475, 377);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "ElementHost1";
			this.vmethod_0().Child = this.realismDialogControl_0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(475, 757);
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RealismDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "仿真精细度设置";
			base.TopMost = true;
			base.ResumeLayout(false);
		}

		// Token: 0x04003EAB RID: 16043
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04003EAD RID: 16045
		internal global::Command.RealismDialogControl realismDialogControl_0;
	}
}

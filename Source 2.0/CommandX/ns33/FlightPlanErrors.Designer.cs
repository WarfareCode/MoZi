namespace ns33
{
	// Token: 0x02000A28 RID: 2600
	
	public sealed partial class FlightPlanErrors : global::ns33.CommandForm
	{
		// Token: 0x06005150 RID: 20816 RVA: 0x002131D8 File Offset: 0x002113D8
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

		// Token: 0x06005151 RID: 20817 RVA: 0x0021321C File Offset: 0x0021141C
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.ListBox());
			base.SuspendLayout();
			this.vmethod_0().BackColor = global::System.Drawing.Color.Salmon;
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_0().FormattingEnabled = true;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Name = "LB_Errors";
			this.vmethod_0().Size = new global::System.Drawing.Size(1111, 96);
			this.vmethod_0().TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1111, 96);
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FlightPlanErrors";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FlightPlanErrors";
			base.ResumeLayout(false);
		}

		// Token: 0x04002638 RID: 9784
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

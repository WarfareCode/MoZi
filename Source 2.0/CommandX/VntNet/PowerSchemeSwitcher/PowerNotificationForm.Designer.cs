namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x02000CE6 RID: 3302
	public sealed partial class PowerNotificationForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06006C48 RID: 27720 RVA: 0x0002E657 File Offset: 0x0002C857
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x003CE378 File Offset: 0x003CC578
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 262);
			base.Name = "PowerNotificationForm";
			this.Text = "PowerNotificationForm";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.PowerNotificationForm_FormClosing);
			base.Load += new global::System.EventHandler(this.PowerNotificationForm_Load);
			base.Shown += new global::System.EventHandler(this.PowerNotificationForm_Shown);
			base.ResumeLayout(false);
		}

		// Token: 0x04003E62 RID: 15970
		private global::System.ComponentModel.IContainer components;
	}
}

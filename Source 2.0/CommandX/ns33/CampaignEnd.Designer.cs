namespace ns33
{
	// Token: 0x02000CEB RID: 3307
	public sealed partial class CampaignEnd : global::System.Windows.Forms.Form
	{
		// Token: 0x06006CAF RID: 27823 RVA: 0x003D0744 File Offset: 0x003CE944
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

		// Token: 0x06006CB0 RID: 27824 RVA: 0x003D0788 File Offset: 0x003CE988
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.WebBrowser());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			base.SuspendLayout();
			this.vmethod_0().AllowNavigation = false;
			this.vmethod_0().AllowWebBrowserDrop = false;
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().IsWebBrowserContextMenuEnabled = false;
			this.vmethod_0().Location = new global::System.Drawing.Point(-1, -1);
			this.vmethod_0().MinimumSize = new global::System.Drawing.Size(20, 20);
			this.vmethod_0().Name = "WebBrowser1";
			this.vmethod_0().Size = new global::System.Drawing.Size(1083, 609);
			this.vmethod_0().TabIndex = 18;
			this.vmethod_2().Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_2().Location = new global::System.Drawing.Point(479, 614);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new global::System.Drawing.Size(129, 13);
			this.vmethod_2().TabIndex = 19;
			this.vmethod_2().Text = "按任意键继续";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1085, 653);
			base.ControlBox = false;
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CampaignEnd";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "战役结束";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04003EAE RID: 16046
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

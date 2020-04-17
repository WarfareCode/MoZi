namespace ns34
{
	// Token: 0x02000A39 RID: 2617
	
	public sealed partial class FixedFacilityOrientation : global::ns33.CommandForm
	{
		// Token: 0x06005338 RID: 21304 RVA: 0x00220A64 File Offset: 0x0021EC64
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

		// Token: 0x06005339 RID: 21305 RVA: 0x00220AA8 File Offset: 0x0021ECA8
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.TrackBar());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(4, 3);
			this.vmethod_0().Maximum = 359;
			this.vmethod_0().Name = "TrackBar1";
			this.vmethod_0().Size = new global::System.Drawing.Size(210, 45);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().Location = new global::System.Drawing.Point(220, 13);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new global::System.Drawing.Size(44, 13);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Current:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(304, 35);
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FixedFacilityOrientation";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Set orientation for fixed facility";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002704 RID: 9988
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

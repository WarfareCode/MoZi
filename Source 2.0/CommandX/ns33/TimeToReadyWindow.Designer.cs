namespace ns33
{
	// Token: 0x020009BF RID: 2495
	
	public sealed partial class TimeToReadyWindow : global::ns33.CommandForm
	{
		// Token: 0x060042C1 RID: 17089 RVA: 0x00185D90 File Offset: 0x00183F90
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

		// Token: 0x060042C2 RID: 17090 RVA: 0x00185DD4 File Offset: 0x00183FD4
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.MaskedTextBox());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_5(new global::System.Windows.Forms.Button());
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(91, 6);
			this.vmethod_0().Mask = "00:00:00";
			this.vmethod_0().Name = "MaskedTextBox1";
			this.vmethod_0().Size = new global::System.Drawing.Size(100, 20);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().Location = new global::System.Drawing.Point(3, 9);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new global::System.Drawing.Size(87, 13);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "天:小时:分钟";
			this.vmethod_4().Location = new global::System.Drawing.Point(197, 6);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().Size = new global::System.Drawing.Size(81, 20);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "确认";
			this.vmethod_4().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 31);
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "TimeToReadyWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "出动准备时间";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001F2E RID: 7982
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

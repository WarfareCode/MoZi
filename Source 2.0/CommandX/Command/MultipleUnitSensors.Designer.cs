namespace Command
{
	// Token: 0x02000A53 RID: 2643
	public sealed partial class MultipleUnitSensors : global::ns33.CommandForm
	{
		// Token: 0x06005400 RID: 21504 RVA: 0x0022752C File Offset: 0x0022572C
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

		// Token: 0x06005401 RID: 21505 RVA: 0x00227570 File Offset: 0x00225770
		private void InitializeComponent()
		{
			this.SetCB_radar(new global::System.Windows.Forms.CheckBox());
			this.SetCB_Sonar(new global::System.Windows.Forms.CheckBox());
			this.SetCB_ECM(new global::System.Windows.Forms.CheckBox());
			this.SetCB_Active(new global::System.Windows.Forms.Label());
			base.SuspendLayout();
			this.GetCB_radar().AutoSize = true;
			this.GetCB_radar().CheckAlign = global::System.Drawing.ContentAlignment.BottomRight;
			this.GetCB_radar().Location = new global::System.Drawing.Point(8, 31);
			this.GetCB_radar().Name = "CB_radar";
			this.GetCB_radar().RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.GetCB_radar().Size = new global::System.Drawing.Size(60, 17);
			this.GetCB_radar().TabIndex = 4;
			this.GetCB_radar().Text = "雷达";
			this.GetCB_radar().UseVisualStyleBackColor = true;
			this.GetCB_Sonar().AutoSize = true;
			this.GetCB_Sonar().CheckAlign = global::System.Drawing.ContentAlignment.BottomRight;
			this.GetCB_Sonar().Location = new global::System.Drawing.Point(83, 31);
			this.GetCB_Sonar().Name = "CB_Sonar";
			this.GetCB_Sonar().RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.GetCB_Sonar().Size = new global::System.Drawing.Size(59, 17);
			this.GetCB_Sonar().TabIndex = 5;
			this.GetCB_Sonar().Text = "声纳";
			this.GetCB_Sonar().UseVisualStyleBackColor = true;
			this.GetCB_ECM().AutoSize = true;
			this.GetCB_ECM().CheckAlign = global::System.Drawing.ContentAlignment.BottomRight;
			this.GetCB_ECM().Location = new global::System.Drawing.Point(151, 31);
			this.GetCB_ECM().Name = "CB_ECM";
			this.GetCB_ECM().RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.GetCB_ECM().Size = new global::System.Drawing.Size(97, 17);
			this.GetCB_ECM().TabIndex = 6;
			this.GetCB_ECM().Text = "电子干扰";
			this.GetCB_ECM().UseVisualStyleBackColor = true;
			this.GetCB_Active().Location = new global::System.Drawing.Point(5, 5);
			this.GetCB_Active().Name = "Label1";
			this.GetCB_Active().Size = new global::System.Drawing.Size(120, 13);
			this.GetCB_Active().TabIndex = 7;
			this.GetCB_Active().Text = "(打开=开机)";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(251, 81);
			base.Controls.Add(this.GetCB_Active());
			base.Controls.Add(this.GetCB_ECM());
			base.Controls.Add(this.GetCB_radar());
			base.Controls.Add(this.GetCB_Sonar());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MultipleUnitSensors";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "作战单元所有传感器";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002787 RID: 10119
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

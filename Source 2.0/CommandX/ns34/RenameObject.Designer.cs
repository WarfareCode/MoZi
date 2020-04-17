namespace ns34
{
	// Token: 0x02000A38 RID: 2616
	
	public sealed partial class RenameObject : global::ns33.CommandForm
	{
		// Token: 0x0600532A RID: 21290 RVA: 0x00220624 File Offset: 0x0021E824
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

		// Token: 0x0600532B RID: 21291 RVA: 0x00220668 File Offset: 0x0021E868
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.TextBox());
			this.vmethod_3(new global::System.Windows.Forms.Button());
			this.vmethod_5(new global::System.Windows.Forms.Button());
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().Location = new global::System.Drawing.Point(12, 12);
			this.vmethod_0().Name = "TextBox1";
			this.vmethod_0().Size = new global::System.Drawing.Size(317, 20);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.vmethod_2().Location = new global::System.Drawing.Point(42, 44);
			this.vmethod_2().Name = "Button1";
			this.vmethod_2().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "确认";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.vmethod_4().Location = new global::System.Drawing.Point(216, 44);
			this.vmethod_4().Name = "Button2";
			this.vmethod_4().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "取消";
			this.vmethod_4().UseVisualStyleBackColor = true;
			base.AcceptButton = this.vmethod_2();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.vmethod_4();
			base.ClientSize = new global::System.Drawing.Size(341, 77);
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RenameObject";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "重命名对象";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040026FF RID: 9983
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace ns34
{
	// Token: 0x02000A14 RID: 2580
	
	public sealed partial class RenameSide : global::ns33.CommandForm
	{
		// Token: 0x06004FD7 RID: 20439 RVA: 0x00203520 File Offset: 0x00201720
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

		// Token: 0x06004FD8 RID: 20440 RVA: 0x00203564 File Offset: 0x00201764
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.TextBox());
			this.vmethod_5(new global::System.Windows.Forms.Button());
			this.vmethod_7(new global::System.Windows.Forms.Button());
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(13, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new global::System.Drawing.Size(61, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "新名称:";
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_2().Location = new global::System.Drawing.Point(16, 30);
			this.vmethod_2().Name = "TextBox1";
			this.vmethod_2().Size = new global::System.Drawing.Size(298, 20);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().Location = new global::System.Drawing.Point(16, 66);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "确认";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_6().DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.vmethod_6().Location = new global::System.Drawing.Point(239, 66);
			this.vmethod_6().Name = "Button2";
			this.vmethod_6().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "取消";
			this.vmethod_6().UseVisualStyleBackColor = true;
			base.AcceptButton = this.vmethod_4();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.vmethod_6();
			base.ClientSize = new global::System.Drawing.Size(326, 95);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RenameSide";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "重命名推演方";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040025AE RID: 9646
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

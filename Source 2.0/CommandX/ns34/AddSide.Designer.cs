namespace ns34
{
	// Token: 0x02000A0B RID: 2571
	
	public sealed partial class AddSide : global::ns33.CommandForm
	{
		// Token: 0x06004EAC RID: 20140 RVA: 0x001FA680 File Offset: 0x001F8880
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

		// Token: 0x06004EAD RID: 20141 RVA: 0x001FA6C4 File Offset: 0x001F88C4
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.TextBox());
			this.vmethod_5(new global::System.Windows.Forms.Button());
			this.vmethod_7(new global::System.Windows.Forms.Button());
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(13, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new global::System.Drawing.Size(38, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "名称:";
			this.vmethod_2().Location = new global::System.Drawing.Point(57, 10);
			this.vmethod_2().Name = "TextBox1";
			this.vmethod_2().Size = new global::System.Drawing.Size(212, 20);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().Location = new global::System.Drawing.Point(57, 59);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "确认";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_6().DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.vmethod_6().Location = new global::System.Drawing.Point(194, 59);
			this.vmethod_6().Name = "Button2";
			this.vmethod_6().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "取消";
			this.vmethod_6().UseVisualStyleBackColor = true;
			base.AcceptButton = this.vmethod_4();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.vmethod_6();
			base.ClientSize = new global::System.Drawing.Size(287, 125);
			base.ControlBox = false;
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddSide";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "创建一个推演方";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400252A RID: 9514
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace Command
{
	// Token: 0x02000A13 RID: 2579
	
	public sealed partial class Postures : global::ns33.CommandForm
	{
		// Token: 0x06004FC5 RID: 20421 RVA: 0x00202F30 File Offset: 0x00201130
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

		// Token: 0x06004FC6 RID: 20422 RVA: 0x00202F74 File Offset: 0x00201174
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.ListBox());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.ComboBox());
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().FormattingEnabled = true;
			this.vmethod_0().Location = new global::System.Drawing.Point(12, 25);
			this.vmethod_0().Name = "LB_Sides";
			this.vmethod_0().Size = new global::System.Drawing.Size(214, 147);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().Location = new global::System.Drawing.Point(9, 9);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new global::System.Drawing.Size(92, 13);
			this.vmethod_2().TabIndex = 4;
			this.vmethod_2().Text = "设置推演方:";
			this.vmethod_4().Location = new global::System.Drawing.Point(9, 188);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new global::System.Drawing.Size(125, 13);
			this.vmethod_4().TabIndex = 5;
			this.vmethod_4().Text = "将此推演方视为：";
			this.vmethod_6().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_6().FormattingEnabled = true;
			this.vmethod_6().Items.AddRange(new object[]
			{
				"中立",
				"友好",
				"非友",
				"敌对"
			});
			this.vmethod_6().Location = new global::System.Drawing.Point(12, 204);
			this.vmethod_6().Name = "ComboBox1";
			this.vmethod_6().Size = new global::System.Drawing.Size(216, 21);
			this.vmethod_6().TabIndex = 6;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(238, 233);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Postures";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "推演方关系";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040025A6 RID: 9638
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

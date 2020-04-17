namespace ns34
{
	// Token: 0x02000A31 RID: 2609
	
	public sealed partial class Form_QuickTurnaround : global::ns33.CommandForm
	{
		// Token: 0x06005301 RID: 21249 RVA: 0x0021F260 File Offset: 0x0021D460
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

		// Token: 0x06005302 RID: 21250 RVA: 0x0021F2A4 File Offset: 0x0021D4A4
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.CheckBox());
			this.vmethod_3(new global::System.Windows.Forms.ComboBox());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			base.SuspendLayout();
			this.vmethod_0().AutoSize = true;
			this.vmethod_0().Location = new global::System.Drawing.Point(11, 12);
			this.vmethod_0().Name = "CB_QuickTurnaround";
			this.vmethod_0().Size = new global::System.Drawing.Size(148, 17);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "支持快速出动";
			this.vmethod_0().UseVisualStyleBackColor = true;
			this.vmethod_2().FormattingEnabled = true;
			this.vmethod_2().Location = new global::System.Drawing.Point(162, 11);
			this.vmethod_2().Name = "Combo_NumberOfSorties";
			this.vmethod_2().Size = new global::System.Drawing.Size(121, 21);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().Location = new global::System.Drawing.Point(288, 16);
			this.vmethod_4().Name = "Label_QuickTurnaroundInfo";
			this.vmethod_4().Size = new global::System.Drawing.Size(140, 13);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "Label_QuickTurnaroundInfo";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(692, 83);
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Form_QuickTurnaround";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quick Turnaround configuration for airborne aircraft for";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040026EA RID: 9962
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

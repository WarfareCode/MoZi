namespace ns34
{
	// Token: 0x02000A0C RID: 2572
	
	public sealed partial class EditBriefing : global::ns33.CommandForm
	{
		// Token: 0x06004EBE RID: 20158 RVA: 0x001FAC64 File Offset: 0x001F8E64
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

		// Token: 0x06004EBF RID: 20159 RVA: 0x001FACA8 File Offset: 0x001F8EA8
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.SplitContainer());
			this.vmethod_7(new global::MSDN.Html.Editor.HtmlEditorControl());
			this.vmethod_9(new global::System.Windows.Forms.Button());
			this.vmethod_3(new global::System.Windows.Forms.Button());
			this.vmethod_5(new global::System.Windows.Forms.Button());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_0().Panel1.SuspendLayout();
			this.vmethod_0().Panel2.SuspendLayout();
			this.vmethod_0().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_0().FixedPanel = global::System.Windows.Forms.FixedPanel.Panel2;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Name = "SplitContainer1";
			this.vmethod_0().Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.vmethod_0().Panel1.Controls.Add(this.vmethod_6());
			this.vmethod_0().Panel2.Controls.Add(this.vmethod_8());
			this.vmethod_0().Panel2.Controls.Add(this.vmethod_2());
			this.vmethod_0().Panel2.Controls.Add(this.vmethod_4());
			this.vmethod_0().Size = new global::System.Drawing.Size(709, 516);
			this.vmethod_0().SplitterDistance = 476;
			this.vmethod_0().TabIndex = 0;
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_6().InnerText = null;
			this.vmethod_6().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_6().Name = "Editor1";
			this.vmethod_6().Size = new global::System.Drawing.Size(709, 476);
			this.vmethod_6().TabIndex = 28;
			this.vmethod_8().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_8().Location = new global::System.Drawing.Point(278, 7);
			this.vmethod_8().Name = "Button_EditHTML";
			this.vmethod_8().Size = new global::System.Drawing.Size(144, 23);
			this.vmethod_8().TabIndex = 2;
			this.vmethod_8().Text = "Edit HTML";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_2().DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.vmethod_2().Location = new global::System.Drawing.Point(629, 7);
			this.vmethod_2().Name = "Button2";
			this.vmethod_2().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "Cancel";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().Location = new global::System.Drawing.Point(9, 7);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_4().TabIndex = 0;
			this.vmethod_4().Text = "OK";
			this.vmethod_4().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.vmethod_2();
			base.ClientSize = new global::System.Drawing.Size(709, 516);
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditBriefing";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Briefing";
			this.vmethod_0().Panel1.ResumeLayout(false);
			this.vmethod_0().Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			this.vmethod_0().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400252F RID: 9519
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

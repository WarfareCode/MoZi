namespace ns33
{
	// Token: 0x0200096D RID: 2413
	
	public sealed partial class TitleAndDescription : global::ns33.CommandForm
	{
		// Token: 0x06003B3B RID: 15163 RVA: 0x00124A40 File Offset: 0x00122C40
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

		// Token: 0x06003B3C RID: 15164 RVA: 0x00124A84 File Offset: 0x00122C84
		private void InitializeComponent()
		{
			this.vmethod_1(new global::MSDN.Html.Editor.HtmlEditorControl());
			this.vmethod_3(new global::System.Windows.Forms.Button());
			this.vmethod_5(new global::System.Windows.Forms.Button());
			this.vmethod_7(new global::System.Windows.Forms.Label());
			this.vmethod_9(new global::System.Windows.Forms.TextBox());
			this.vmethod_11(new global::System.Windows.Forms.Label());
			this.vmethod_13(new global::System.Windows.Forms.Button());
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().InnerText = null;
			this.vmethod_0().Location = new global::System.Drawing.Point(6, 67);
			this.vmethod_0().Name = "Editor1";
			this.vmethod_0().Size = new global::System.Drawing.Size(869, 414);
			this.vmethod_0().TabIndex = 33;
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_2().Location = new global::System.Drawing.Point(800, 487);
			this.vmethod_2().Name = "Button2";
			this.vmethod_2().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_2().TabIndex = 32;
			this.vmethod_2().Text = "取消";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_4().Location = new global::System.Drawing.Point(6, 487);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_4().TabIndex = 31;
			this.vmethod_4().Text = "确认";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_6().Location = new global::System.Drawing.Point(3, 51);
			this.vmethod_6().Name = "Label2";
			this.vmethod_6().Size = new global::System.Drawing.Size(63, 13);
			this.vmethod_6().TabIndex = 30;
			this.vmethod_6().Text = "描述:";
			this.vmethod_8().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_8().Location = new global::System.Drawing.Point(43, 12);
			this.vmethod_8().Name = "TextBox1";
			this.vmethod_8().Size = new global::System.Drawing.Size(832, 20);
			this.vmethod_8().TabIndex = 29;
			this.vmethod_10().Location = new global::System.Drawing.Point(3, 15);
			this.vmethod_10().Name = "Label1";
			this.vmethod_10().Size = new global::System.Drawing.Size(30, 13);
			this.vmethod_10().TabIndex = 28;
			this.vmethod_10().Text = "标题:";
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_12().Location = new global::System.Drawing.Point(768, 41);
			this.vmethod_12().Name = "Button_EditHTML";
			this.vmethod_12().Size = new global::System.Drawing.Size(107, 23);
			this.vmethod_12().TabIndex = 34;
			this.vmethod_12().Text = "编辑HTML源码";
			this.vmethod_12().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(878, 513);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "TitleAndDescription";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "想定标题与描述";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001AFF RID: 6911
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

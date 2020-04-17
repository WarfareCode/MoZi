namespace ns34
{
	// Token: 0x02000A09 RID: 2569
	
	public sealed partial class ScenarioTitle : global::ns33.CommandForm
	{
		// Token: 0x06004E53 RID: 20051 RVA: 0x00024F09 File Offset: 0x00023109
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06004E54 RID: 20052 RVA: 0x001F81CC File Offset: 0x001F63CC
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.TextBox());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.Button());
			this.vmethod_9(new global::System.Windows.Forms.Button());
			this.vmethod_11(new global::MSDN.Html.Editor.HtmlEditorControl());
			this.vmethod_13(new global::System.Windows.Forms.Button());
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(9, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new global::System.Drawing.Size(40, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "标题:";
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_2().Location = new global::System.Drawing.Point(49, 10);
			this.vmethod_2().Name = "TextBox1";
			this.vmethod_2().Size = new global::System.Drawing.Size(601, 20);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().Location = new global::System.Drawing.Point(9, 49);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new global::System.Drawing.Size(63, 13);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "描述:";
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_6().Location = new global::System.Drawing.Point(12, 458);
			this.vmethod_6().Name = "Button1";
			this.vmethod_6().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_6().Text = "确认";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_8().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_8().Location = new global::System.Drawing.Point(575, 458);
			this.vmethod_8().Name = "Button2";
			this.vmethod_8().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_8().TabIndex = 5;
			this.vmethod_8().Text = "取消";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_10().InnerText = null;
			this.vmethod_10().Location = new global::System.Drawing.Point(12, 65);
			this.vmethod_10().Name = "Editor1";
			this.vmethod_10().Size = new global::System.Drawing.Size(638, 387);
			this.vmethod_10().TabIndex = 27;
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_12().Location = new global::System.Drawing.Point(575, 44);
			this.vmethod_12().Name = "Button3";
			this.vmethod_12().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_12().TabIndex = 28;
			this.vmethod_12().Text = "编辑HTML";
			this.vmethod_12().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(662, 485);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ScenarioTitle";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "创建一个新想定";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002506 RID: 9478
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace ns33
{
	// Token: 0x0200097C RID: 2428
	
	public sealed partial class CampaignScenarioWindow : global::ns33.CommandForm
	{
		// Token: 0x06003C70 RID: 15472 RVA: 0x0012C7B0 File Offset: 0x0012A9B0
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

		// Token: 0x06003C71 RID: 15473 RVA: 0x0012C7F4 File Offset: 0x0012A9F4
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			this.vmethod_13(new global::System.Windows.Forms.Timer(this.icontainer_0));
			this.vmethod_9(new global::System.Windows.Forms.ProgressBar());
			this.vmethod_11(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.Button());
			this.vmethod_5(new global::System.Windows.Forms.Button());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_1(new global::System.Windows.Forms.WebBrowser());
			base.SuspendLayout();
			this.vmethod_12().Interval = 50;
			this.vmethod_8().Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.vmethod_8().Location = new global::System.Drawing.Point(312, 577);
			this.vmethod_8().Name = "PB_PercentComplete";
			this.vmethod_8().Size = new global::System.Drawing.Size(359, 12);
			this.vmethod_8().TabIndex = 21;
			this.vmethod_10().Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.vmethod_10().Location = new global::System.Drawing.Point(459, 561);
			this.vmethod_10().Name = "Label_Loading";
			this.vmethod_10().Size = new global::System.Drawing.Size(54, 13);
			this.vmethod_10().TabIndex = 22;
			this.vmethod_10().Text = "加载...";
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_6().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_6().Location = new global::System.Drawing.Point(731, 562);
			this.vmethod_6().Name = "Button2";
			this.vmethod_6().Size = new global::System.Drawing.Size(249, 29);
			this.vmethod_6().TabIndex = 20;
			this.vmethod_6().Text = "取消(返回战役想定)";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_4().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_4().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_4().Location = new global::System.Drawing.Point(4, 562);
			this.vmethod_4().Name = "Button1";
			this.vmethod_4().Size = new global::System.Drawing.Size(249, 29);
			this.vmethod_4().TabIndex = 19;
			this.vmethod_4().Text = "启动阶段想定推演";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.vmethod_2().Font = new global::System.Drawing.Font("Times New Roman", 36f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_2().Location = new global::System.Drawing.Point(3, 3);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new global::System.Drawing.Size(284, 55);
			this.vmethod_2().TabIndex = 18;
			this.vmethod_2().Text = "想定标题";
			this.vmethod_0().AllowNavigation = false;
			this.vmethod_0().AllowWebBrowserDrop = false;
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().IsWebBrowserContextMenuEnabled = false;
			this.vmethod_0().Location = new global::System.Drawing.Point(1, 61);
			this.vmethod_0().MinimumSize = new global::System.Drawing.Size(20, 20);
			this.vmethod_0().Name = "WebBrowser1";
			this.vmethod_0().Size = new global::System.Drawing.Size(983, 497);
			this.vmethod_0().TabIndex = 17;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(985, 618);
			base.ControlBox = false;
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CampaignScenarioWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "战役想定";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001B8A RID: 7050
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

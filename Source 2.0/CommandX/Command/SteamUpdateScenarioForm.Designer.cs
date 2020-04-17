namespace Command
{
	// Token: 0x0200096C RID: 2412
	public sealed partial class SteamUpdateScenarioForm : global::ns33.CommandForm
	{
		// Token: 0x06003B2C RID: 15148 RVA: 0x00124674 File Offset: 0x00122874
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

		// Token: 0x06003B2D RID: 15149 RVA: 0x001246B8 File Offset: 0x001228B8
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Button());
			this.vmethod_3(new global::System.Windows.Forms.Button());
			this.vmethod_5(new global::System.Windows.Forms.ListView());
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_0().Location = new global::System.Drawing.Point(6, 322);
			this.vmethod_0().Name = "Button1";
			this.vmethod_0().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_0().Text = "更新";
			this.vmethod_0().UseVisualStyleBackColor = true;
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_2().Location = new global::System.Drawing.Point(359, 322);
			this.vmethod_2().Name = "Button2";
			this.vmethod_2().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_2().TabIndex = 2;
			this.vmethod_2().Text = "取消";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_4().Location = new global::System.Drawing.Point(6, 5);
			this.vmethod_4().Name = "ListView1";
			this.vmethod_4().Size = new global::System.Drawing.Size(428, 311);
			this.vmethod_4().TabIndex = 3;
			this.vmethod_4().UseCompatibleStateImageBehavior = false;
			this.vmethod_4().View = global::System.Windows.Forms.View.List;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(437, 348);
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SteamUpdateScenarioForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			//this.Text = "Steam Workshop Update Selection";
            this.Text = "选择要更新的想定组";
            base.ResumeLayout(false);
		}

		// Token: 0x04001AF9 RID: 6905
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

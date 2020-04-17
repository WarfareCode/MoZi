namespace ns33
{
	// Token: 0x02000CEC RID: 3308
	
	public sealed partial class InsufficientLicenseWindow : global::System.Windows.Forms.Form
	{
		// Token: 0x06006CBD RID: 27837 RVA: 0x003D0AEC File Offset: 0x003CECEC
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

		// Token: 0x06006CBE RID: 27838 RVA: 0x003D0B30 File Offset: 0x003CED30
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns33.InsufficientLicenseWindow));
			this.vmethod_1(new global::Microsoft.VisualBasic.PowerPacks.ShapeContainer());
			this.vmethod_3(new global::Microsoft.VisualBasic.PowerPacks.RectangleShape());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.Panel());
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Margin = new global::System.Windows.Forms.Padding(0);
			this.vmethod_0().Name = "ShapeContainer1";
			this.vmethod_0().Shapes.AddRange(new global::Microsoft.VisualBasic.PowerPacks.Shape[]
			{
				this.vmethod_2()
			});
			this.vmethod_0().Size = new global::System.Drawing.Size(784, 561);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_0().TabStop = false;
            //ZSP ERR IMG this.vmethod_2().BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("RectangleShape1.BackgroundImage");
            this.vmethod_2().BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.vmethod_2().BorderColor = global::System.Drawing.Color.Transparent;
			this.vmethod_2().Location = new global::System.Drawing.Point(309, 477);
			this.vmethod_2().Name = "RectangleShape1";
			this.vmethod_2().Size = new global::System.Drawing.Size(190, 38);
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().BackColor = global::System.Drawing.Color.Transparent;
			this.vmethod_4().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_4().ForeColor = global::System.Drawing.Color.LightSkyBlue;
			this.vmethod_4().Location = new global::System.Drawing.Point(12, 97);
			this.vmethod_4().MaximumSize = new global::System.Drawing.Size(700, 0);
			this.vmethod_4().Name = "Label1";
			this.vmethod_4().Size = new global::System.Drawing.Size(216, 29);
			this.vmethod_4().TabIndex = 3;
			this.vmethod_4().Text = "没有足够的软件许可";
			this.vmethod_6().BackColor = global::System.Drawing.Color.White;
			this.vmethod_6().Location = new global::System.Drawing.Point(11, 93);
			this.vmethod_6().Name = "Panel1";
			this.vmethod_6().Size = new global::System.Drawing.Size(735, 44);
			this.vmethod_6().TabIndex = 4;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            //ZSP ERR IMG this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
            this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(784, 561);
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_6());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "InsufficientLicenseWindow";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04003EB2 RID: 16050
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

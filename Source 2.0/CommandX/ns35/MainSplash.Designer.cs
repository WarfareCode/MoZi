namespace ns35
{
	// Token: 0x02000CF6 RID: 3318
	
	public sealed partial class MainSplash : global::System.Windows.Forms.Form
	{
		// Token: 0x06007317 RID: 29463 RVA: 0x00419750 File Offset: 0x00417950
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

		// Token: 0x06007318 RID: 29464 RVA: 0x00419794 File Offset: 0x00417994
		private void InitializeComponent()
		{
			new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns35.MainSplash));
			this.vmethod_1(new global::System.Windows.Forms.PictureBox());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_0().Image = global::System.Drawing.Image.FromFile(global::System.IO.Path.Combine(global::ns32.CommandFactory.GetCommandApp().Info.DirectoryPath, "Symbols\\splash.jpg"));
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Name = "PictureBox1";
			this.vmethod_0().Size = new global::System.Drawing.Size(483, 292);
			this.vmethod_0().TabIndex = 6;
			this.vmethod_0().TabStop = false;
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().ForeColor = global::System.Drawing.Color.Red;
			this.vmethod_2().Location = new global::System.Drawing.Point(12, 9);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new global::System.Drawing.Size(10, 13);
			this.vmethod_2().TabIndex = 7;
			this.vmethod_2().Text = " ";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			base.ClientSize = new global::System.Drawing.Size(483, 292);
			base.ControlBox = false;
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MainSplash";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CommandX";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400416C RID: 16748
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

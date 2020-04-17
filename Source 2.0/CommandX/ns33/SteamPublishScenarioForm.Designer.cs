namespace ns33
{
	// Token: 0x02000991 RID: 2449
	
	public sealed partial class SteamPublishScenarioForm : global::ns33.CommandForm
	{
		// Token: 0x06003DDF RID: 15839 RVA: 0x0014317C File Offset: 0x0014137C
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

		// Token: 0x06003DE0 RID: 15840 RVA: 0x001431C0 File Offset: 0x001413C0
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.PictureBox());
			this.vmethod_3(new global::System.Windows.Forms.Button());
			this.vmethod_5(new global::System.Windows.Forms.Button());
			this.vmethod_7(new global::System.Windows.Forms.Button());
			this.vmethod_9(new global::System.Windows.Forms.TextBox());
			this.vmethod_11(new global::System.Windows.Forms.TextBox());
			this.vmethod_13(new global::System.Windows.Forms.TextBox());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_17(new global::System.Windows.Forms.Label());
			this.vmethod_19(new global::System.Windows.Forms.OpenFileDialog());
			this.vmethod_21(new global::System.Windows.Forms.Button());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().Location = new global::System.Drawing.Point(422, 13);
			this.vmethod_0().Name = "PictureBox1";
			this.vmethod_0().Size = new global::System.Drawing.Size(256, 256);
			this.vmethod_0().SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.vmethod_0().TabIndex = 1;
			this.vmethod_0().TabStop = false;
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_2().Location = new global::System.Drawing.Point(423, 283);
			this.vmethod_2().Name = "Button1";
			this.vmethod_2().Size = new global::System.Drawing.Size(255, 23);
			this.vmethod_2().TabIndex = 2;
			this.vmethod_2().Text = "Select Preview Image";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_4().Location = new global::System.Drawing.Point(422, 313);
			this.vmethod_4().Name = "Button_MapScreenshot";
			this.vmethod_4().Size = new global::System.Drawing.Size(256, 23);
			this.vmethod_4().TabIndex = 3;
			this.vmethod_4().Text = "Use Screenshot";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_6().Location = new global::System.Drawing.Point(422, 343);
			this.vmethod_6().Name = "Button3";
			this.vmethod_6().Size = new global::System.Drawing.Size(256, 23);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_6().Text = "Publish New Item";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_8().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_8().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_8().Location = new global::System.Drawing.Point(90, 13);
			this.vmethod_8().Name = "TextBox1";
			this.vmethod_8().Size = new global::System.Drawing.Size(326, 24);
			this.vmethod_8().TabIndex = 5;
			this.vmethod_8().TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.vmethod_10().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_10().Location = new global::System.Drawing.Point(12, 67);
			this.vmethod_10().Multiline = true;
			this.vmethod_10().Name = "TextBox2";
			this.vmethod_10().ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.vmethod_10().Size = new global::System.Drawing.Size(404, 380);
			this.vmethod_10().TabIndex = 6;
			this.vmethod_12().Location = new global::System.Drawing.Point(90, 41);
			this.vmethod_12().Name = "TextBox3";
			this.vmethod_12().Size = new global::System.Drawing.Size(326, 20);
			this.vmethod_12().TabIndex = 7;
			this.vmethod_14().Location = new global::System.Drawing.Point(12, 20);
			this.vmethod_14().Name = "Label1";
			this.vmethod_14().Size = new global::System.Drawing.Size(75, 13);
			this.vmethod_14().TabIndex = 8;
			this.vmethod_14().Text = "Scenario Title:";
			this.vmethod_16().Location = new global::System.Drawing.Point(12, 44);
			this.vmethod_16().Name = "Label2";
			this.vmethod_16().Size = new global::System.Drawing.Size(52, 13);
			this.vmethod_16().TabIndex = 9;
			this.vmethod_16().Text = "Filename:";
			this.vmethod_20().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_20().Location = new global::System.Drawing.Point(423, 373);
			this.vmethod_20().Name = "Button2";
			this.vmethod_20().Size = new global::System.Drawing.Size(255, 23);
			this.vmethod_20().TabIndex = 10;
			this.vmethod_20().Text = "Update Existing Workshop Item";
			this.vmethod_20().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(684, 455);
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SteamPublishScenarioForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Steam Workshop Publishing";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001C60 RID: 7264
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

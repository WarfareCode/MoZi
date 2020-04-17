namespace ns34
{
	// Token: 0x02000A02 RID: 2562
	
	public sealed partial class EditWeather : global::ns33.CommandForm
	{
		// Token: 0x06004D90 RID: 19856 RVA: 0x001F1EEC File Offset: 0x001F00EC
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

		// Token: 0x06004D91 RID: 19857 RVA: 0x001F1F30 File Offset: 0x001F0130
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns34.EditWeather));
			this.vmethod_1(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_3(new global::System.Windows.Forms.ToolStripLabel());
			this.vmethod_5(new global::System.Windows.Forms.ToolStripDropDownButton());
			this.vmethod_7(new global::ns15.Control1());
			this.vmethod_9(new global::System.Windows.Forms.TabPage());
			this.vmethod_33(new global::System.Windows.Forms.Label());
			this.vmethod_35(new global::System.Windows.Forms.Label());
			this.vmethod_37(new global::System.Windows.Forms.TrackBar());
			this.vmethod_39(new global::System.Windows.Forms.Label());
			this.vmethod_29(new global::System.Windows.Forms.Label());
			this.vmethod_31(new global::System.Windows.Forms.TrackBar());
			this.vmethod_17(new global::System.Windows.Forms.Label());
			this.vmethod_19(new global::System.Windows.Forms.Label());
			this.vmethod_21(new global::System.Windows.Forms.Label());
			this.vmethod_23(new global::System.Windows.Forms.Label());
			this.vmethod_25(new global::System.Windows.Forms.TrackBar());
			this.SetTrackBar_FUR(new global::System.Windows.Forms.TrackBar());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_11(new global::System.Windows.Forms.Label());
			this.vmethod_13(new global::System.Windows.Forms.Label());
			this.vmethod_0().SuspendLayout();
			this.vmethod_6().SuspendLayout();
			this.vmethod_8().SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_36()).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_30()).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_24()).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetTrackBar_FUR()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_0().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_2(),
				this.vmethod_4()
			});
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Name = "ToolStrip1";
			this.vmethod_0().Size = new global::System.Drawing.Size(563, 25);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "ToolStrip1";
			this.vmethod_2().Name = "ToolStripLabel1";
			this.vmethod_2().Size = new global::System.Drawing.Size(138, 22);
			this.vmethod_2().Text = "气象建模层次:";
			this.vmethod_4().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //ZSP ERR IMG this.vmethod_4().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSDD_WeatherLevel.Image");
            this.vmethod_4().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_4().Name = "TSDD_WeatherLevel";
			this.vmethod_4().Size = new global::System.Drawing.Size(56, 22);
			this.vmethod_4().Text = "第0层";
			this.vmethod_6().Controls.Add(this.vmethod_8());
			this.vmethod_6().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_6().Location = new global::System.Drawing.Point(0, 25);
			this.vmethod_6().Multiline = true;
			this.vmethod_6().Name = "TC_WeatherLevel";
			this.vmethod_6().SelectedIndex = 0;
			this.vmethod_6().Size = new global::System.Drawing.Size(563, 172);
			this.vmethod_6().TabIndex = 19;
			this.vmethod_8().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_8().Controls.Add(this.vmethod_32());
			this.vmethod_8().Controls.Add(this.vmethod_34());
			this.vmethod_8().Controls.Add(this.vmethod_36());
			this.vmethod_8().Controls.Add(this.vmethod_38());
			this.vmethod_8().Controls.Add(this.vmethod_28());
			this.vmethod_8().Controls.Add(this.vmethod_30());
			this.vmethod_8().Controls.Add(this.vmethod_16());
			this.vmethod_8().Controls.Add(this.vmethod_18());
			this.vmethod_8().Controls.Add(this.vmethod_20());
			this.vmethod_8().Controls.Add(this.vmethod_22());
			this.vmethod_8().Controls.Add(this.vmethod_24());
			this.vmethod_8().Controls.Add(this.GetTrackBar_FUR());
			this.vmethod_8().Controls.Add(this.vmethod_14());
			this.vmethod_8().Controls.Add(this.vmethod_10());
			this.vmethod_8().Controls.Add(this.vmethod_12());
			this.vmethod_8().Location = new global::System.Drawing.Point(4, 23);
			this.vmethod_8().Name = "TabPage1";
			this.vmethod_8().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_8().Size = new global::System.Drawing.Size(555, 145);
			this.vmethod_8().TabIndex = 0;
			this.vmethod_8().Text = "第0层";
			this.vmethod_32().AutoSize = true;
			this.vmethod_32().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_32().Location = new global::System.Drawing.Point(410, 113);
			this.vmethod_32().Name = "Label9";
			this.vmethod_32().Size = new global::System.Drawing.Size(62, 13);
			this.vmethod_32().TabIndex = 14;
			this.vmethod_32().Text = "飓风";
			this.vmethod_34().AutoSize = true;
			this.vmethod_34().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_34().Location = new global::System.Drawing.Point(144, 111);
			this.vmethod_34().Name = "Label10";
			this.vmethod_34().Size = new global::System.Drawing.Size(34, 13);
			this.vmethod_34().TabIndex = 13;
			this.vmethod_34().Text = "平静";
			this.vmethod_36().AutoSize = false;
			this.vmethod_36().LargeChange = 10;
			this.vmethod_36().Location = new global::System.Drawing.Point(177, 109);
			this.vmethod_36().Maximum = 9;
			this.vmethod_36().Name = "TrackBar_SeaState";
			this.vmethod_36().Size = new global::System.Drawing.Size(239, 31);
			this.vmethod_36().TabIndex = 12;
			this.vmethod_38().AutoSize = true;
			this.vmethod_38().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_38().Location = new global::System.Drawing.Point(8, 109);
			this.vmethod_38().Name = "Label8";
			this.vmethod_38().Size = new global::System.Drawing.Size(130, 20);
			this.vmethod_38().TabIndex = 11;
			this.vmethod_38().Text = "风力/海况:";
			this.vmethod_28().AutoSize = true;
			this.vmethod_28().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_28().Location = new global::System.Drawing.Point(410, 20);
			this.vmethod_28().Name = "Label_AverageTemp";
			this.vmethod_28().Size = new global::System.Drawing.Size(24, 13);
			this.vmethod_28().TabIndex = 10;
			this.vmethod_28().Text = "°C";
			this.vmethod_30().AutoSize = false;
			this.vmethod_30().LargeChange = 10;
			this.vmethod_30().Location = new global::System.Drawing.Point(177, 15);
			this.vmethod_30().Maximum = 50;
			this.vmethod_30().Minimum = -50;
			this.vmethod_30().Name = "TrackBar_AverageTemp";
			this.vmethod_30().Size = new global::System.Drawing.Size(239, 31);
			this.vmethod_30().SmallChange = 5;
			this.vmethod_30().TabIndex = 9;
			this.vmethod_16().AutoSize = true;
			this.vmethod_16().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_16().Location = new global::System.Drawing.Point(410, 82);
			this.vmethod_16().Name = "Label7";
			this.vmethod_16().Size = new global::System.Drawing.Size(127, 13);
			this.vmethod_16().TabIndex = 8;
			this.vmethod_16().Text = "多云";
			this.vmethod_18().AutoSize = true;
			this.vmethod_18().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_18().Location = new global::System.Drawing.Point(142, 82);
			this.vmethod_18().Name = "Label6";
			this.vmethod_18().Size = new global::System.Drawing.Size(36, 13);
			this.vmethod_18().TabIndex = 7;
			this.vmethod_18().Text = "晴朗";
			this.vmethod_20().AutoSize = true;
			this.vmethod_20().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_20().Location = new global::System.Drawing.Point(410, 51);
			this.vmethod_20().Name = "Label5";
			this.vmethod_20().Size = new global::System.Drawing.Size(77, 13);
			this.vmethod_20().TabIndex = 6;
			this.vmethod_20().Text = "暴雨";
			this.vmethod_22().AutoSize = true;
			this.vmethod_22().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_22().Location = new global::System.Drawing.Point(130, 49);
			this.vmethod_22().Name = "Label4";
			this.vmethod_22().Size = new global::System.Drawing.Size(48, 13);
			this.vmethod_22().TabIndex = 5;
			this.vmethod_22().Text = "无雨";
			this.vmethod_24().AutoSize = false;
			this.vmethod_24().LargeChange = 10;
			this.vmethod_24().Location = new global::System.Drawing.Point(177, 46);
			this.vmethod_24().Maximum = 50;
			this.vmethod_24().Name = "TrackBar_Rainfall";
			this.vmethod_24().Size = new global::System.Drawing.Size(239, 31);
			this.vmethod_24().SmallChange = 5;
			this.vmethod_24().TabIndex = 4;
			this.GetTrackBar_FUR().AutoSize = false;
			this.GetTrackBar_FUR().LargeChange = 10;
			this.GetTrackBar_FUR().Location = new global::System.Drawing.Point(177, 80);
			this.GetTrackBar_FUR().Name = "TrackBar_FUR";
			this.GetTrackBar_FUR().Size = new global::System.Drawing.Size(239, 31);
			this.GetTrackBar_FUR().TabIndex = 3;
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_14().Location = new global::System.Drawing.Point(8, 77);
			this.vmethod_14().Name = "Label3";
			this.vmethod_14().Size = new global::System.Drawing.Size(82, 20);
			this.vmethod_14().TabIndex = 2;
			this.vmethod_14().Text = "天空云量:";
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_10().Location = new global::System.Drawing.Point(8, 46);
			this.vmethod_10().Name = "Label2";
			this.vmethod_10().Size = new global::System.Drawing.Size(98, 20);
			this.vmethod_10().TabIndex = 1;
			this.vmethod_10().Text = "降水量:";
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_12().Location = new global::System.Drawing.Point(8, 15);
			this.vmethod_12().Name = "Label1";
			this.vmethod_12().Size = new global::System.Drawing.Size(163, 20);
			this.vmethod_12().TabIndex = 0;
			this.vmethod_12().Text = "平均气温:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(563, 197);
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditWeather";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "气象环境配置";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_0().PerformLayout();
			this.vmethod_6().ResumeLayout(false);
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_8().PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_36()).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_30()).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_24()).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetTrackBar_FUR()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040024A3 RID: 9379
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

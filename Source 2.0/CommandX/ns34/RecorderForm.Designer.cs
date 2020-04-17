namespace ns34
{
	// Token: 0x020009F5 RID: 2549
	
	public sealed partial class RecorderForm : global::ns33.CommandForm
	{
		// Token: 0x06004C57 RID: 19543 RVA: 0x001E4004 File Offset: 0x001E2204
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

		// Token: 0x06004C58 RID: 19544 RVA: 0x001E4048 File Offset: 0x001E2248
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns34.RecorderForm));
			this.SetTB_Snapshots(new global::System.Windows.Forms.TrackBar());
			this.vmethod_3(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_5(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_19(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_7(new global::System.Windows.Forms.ToolStripSeparator());
			this.vmethod_9(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_11(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_13(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_15(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_17(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_21(new global::System.Windows.Forms.OpenFileDialog());
			this.vmethod_23(new global::System.Windows.Forms.Timer(this.icontainer_0));
			this.vmethod_25(new global::System.Windows.Forms.StatusStrip());
			this.vmethod_27(new global::System.Windows.Forms.ToolStripStatusLabel());
			this.vmethod_31(new global::System.Windows.Forms.ToolStripStatusLabel());
			this.vmethod_29(new global::System.Windows.Forms.Timer(this.icontainer_0));
			((global::System.ComponentModel.ISupportInitialize)this.GetTB_Snapshots()).BeginInit();
			this.vmethod_2().SuspendLayout();
			this.vmethod_24().SuspendLayout();
			base.SuspendLayout();
			this.GetTB_Snapshots().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GetTB_Snapshots().Location = new global::System.Drawing.Point(0, 28);
			this.GetTB_Snapshots().Name = "TB_Snapshots";
			this.GetTB_Snapshots().Size = new global::System.Drawing.Size(472, 45);
			this.GetTB_Snapshots().TabIndex = 0;
			this.vmethod_2().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_4(),
				this.vmethod_18(),
				this.vmethod_6(),
				this.vmethod_8(),
				this.vmethod_10(),
				this.vmethod_12(),
				this.vmethod_14(),
				this.vmethod_16()
			});
			this.vmethod_2().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_2().Name = "ToolStrip1";
			this.vmethod_2().Size = new global::System.Drawing.Size(464, 25);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "ToolStrip1";
            //ZSP ERR IMG this.vmethod_4().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_LoadRecording.Image");
            this.vmethod_4().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_4().Name = "TSB_LoadRecording";
			this.vmethod_4().Size = new global::System.Drawing.Size(53, 22);
			this.vmethod_4().Text = "加载";
            //ZSP ERR IMG this.vmethod_18().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_LoadMostRecent.Image");
            this.vmethod_18().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_18().Name = "TSB_LoadMostRecent";
			this.vmethod_18().Size = new global::System.Drawing.Size(119, 22);
			this.vmethod_18().Text = "最近";
			this.vmethod_6().Name = "ToolStripSeparator1";
			this.vmethod_6().Size = new global::System.Drawing.Size(6, 25);
			this.vmethod_8().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            //ZSP ERR IMG this.vmethod_8().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_GoToStart.Image");
            this.vmethod_8().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_8().Name = "TSB_GoToStart";
			this.vmethod_8().Size = new global::System.Drawing.Size(23, 22);
			this.vmethod_8().Text = "TSB_GoToStart";
			this.vmethod_8().ToolTipText = "跳到开头";
			this.vmethod_10().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            //ZSP ERR IMG this.vmethod_10().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_StepBack.Image");
            this.vmethod_10().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_10().Name = "TSB_StepBack";
			this.vmethod_10().Size = new global::System.Drawing.Size(23, 22);
			this.vmethod_10().Text = "TSB_Reverse";
			this.vmethod_10().ToolTipText = "步退";
			this.vmethod_12().CheckOnClick = true;
			this.vmethod_12().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            //ZSP ERR IMG this.vmethod_12().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_Play.Image");
            this.vmethod_12().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_12().Name = "TSB_Play";
			this.vmethod_12().Size = new global::System.Drawing.Size(23, 22);
			this.vmethod_12().Text = "播放/暂停";
			this.vmethod_12().ToolTipText = "暂停";
			this.vmethod_14().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            //ZSP ERR IMG this.vmethod_14().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_StepForward.Image");
            this.vmethod_14().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_14().Name = "TSB_StepForward";
			this.vmethod_14().Size = new global::System.Drawing.Size(23, 22);
			this.vmethod_14().Text = "TSB_Play";
			this.vmethod_14().ToolTipText = "步进";
			this.vmethod_16().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            //ZSP ERR IMG this.vmethod_16().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_GoToEnd.Image");
            this.vmethod_16().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_16().Name = "TSB_GoToEnd";
			this.vmethod_16().Size = new global::System.Drawing.Size(23, 22);
			this.vmethod_16().Text = "TSB_GoToEnd";
			this.vmethod_16().ToolTipText = "跳到结尾";
			this.vmethod_20().FileName = "OpenFileDialog1";
			this.vmethod_22().Interval = 500;
			this.vmethod_24().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_26(),
				this.vmethod_30()
			});
			this.vmethod_24().Location = new global::System.Drawing.Point(0, 54);
			this.vmethod_24().Name = "StatusStrip1";
			this.vmethod_24().Size = new global::System.Drawing.Size(464, 22);
			this.vmethod_24().TabIndex = 2;
			this.vmethod_24().Text = "StatusStrip1";
			this.vmethod_26().Name = "TSSL_ScenLoading";
			this.vmethod_26().Size = new global::System.Drawing.Size(93, 17);
			this.vmethod_26().Text = "加载视频帧...";
			this.vmethod_26().Visible = false;
			this.vmethod_30().Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
            //ZSP ERR IMG this.vmethod_30().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSSL_BadFrame.Image");
            this.vmethod_30().Name = "TSSL_BadFrame";
			this.vmethod_30().Size = new global::System.Drawing.Size(137, 17);
			this.vmethod_30().Text = "跳过坏帧!";
			this.vmethod_30().Visible = false;
			this.vmethod_28().Interval = 50;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(464, 76);
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.GetTB_Snapshots());
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RecorderForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "复盘推演播放器";
			((global::System.ComponentModel.ISupportInitialize)this.GetTB_Snapshots()).EndInit();
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			this.vmethod_24().ResumeLayout(false);
			this.vmethod_24().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002403 RID: 9219
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace Command
{
	// Token: 0x02000A15 RID: 2581
	public sealed partial class Sides : global::ns33.CommandForm
	{
		// Token: 0x06004FE9 RID: 20457 RVA: 0x000255E1 File Offset: 0x000237E1
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x00203BD4 File Offset: 0x00201DD4
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			this.vmethod_1(new global::System.Windows.Forms.ListBox());
			this.vmethod_3(new global::System.Windows.Forms.Button());
			this.vmethod_5(new global::System.Windows.Forms.Button());
			this.vmethod_7(new global::System.Windows.Forms.Button());
			this.vmethod_9(new global::System.Windows.Forms.ImageList(this.icontainer_0));
			this.vmethod_11(new global::System.Windows.Forms.CheckBox());
			this.vmethod_13(new global::System.Windows.Forms.Button());
			this.vmethod_15(new global::System.Windows.Forms.Button());
			this.vmethod_17(new global::System.Windows.Forms.StatusStrip());
			this.vmethod_19(new global::System.Windows.Forms.ToolStripStatusLabel());
			this.vmethod_21(new global::System.Windows.Forms.Label());
			this.SetCB_Awareness(new global::System.Windows.Forms.ComboBox());
			this.vmethod_25(new global::System.Windows.Forms.CheckBox());
			this.vmethod_27(new global::System.Windows.Forms.Label());
			this.vmethod_29(new global::System.Windows.Forms.TrackBar());
			this.vmethod_31(new global::System.Windows.Forms.CheckBox());
			this.vmethod_16().SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetTrackBar_Proficiency()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_0().FormattingEnabled = true;
			this.vmethod_0().Location = new global::System.Drawing.Point(1, 9);
			this.vmethod_0().Name = "LB_Sides";
			this.vmethod_0().Size = new global::System.Drawing.Size(213, 394);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().Location = new global::System.Drawing.Point(220, 9);
			this.vmethod_2().Name = "Button1";
			this.vmethod_2().Size = new global::System.Drawing.Size(134, 23);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "添加";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().Location = new global::System.Drawing.Point(220, 38);
			this.vmethod_4().Name = "Button2";
			this.vmethod_4().Size = new global::System.Drawing.Size(133, 23);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "删除";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_6().Location = new global::System.Drawing.Point(220, 112);
			this.vmethod_6().Name = "Button3";
			this.vmethod_6().Size = new global::System.Drawing.Size(133, 23);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "对抗关系属性";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_8().ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			this.vmethod_8().ImageSize = new global::System.Drawing.Size(16, 16);
			this.vmethod_8().TransparentColor = global::System.Drawing.Color.Transparent;
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Enabled = false;
			this.vmethod_10().Location = new global::System.Drawing.Point(221, 170);
			this.vmethod_10().Name = "CB_AIOnly";
			this.vmethod_10().Size = new global::System.Drawing.Size(126, 17);
			this.vmethod_10().TabIndex = 4;
			this.vmethod_10().Text = "推演方只由计算机扮演";
			this.vmethod_10().UseVisualStyleBackColor = true;
			this.vmethod_12().Location = new global::System.Drawing.Point(221, 83);
			this.vmethod_12().Name = "Button4";
			this.vmethod_12().Size = new global::System.Drawing.Size(132, 23);
			this.vmethod_12().TabIndex = 5;
			this.vmethod_12().Text = "重命名";
			this.vmethod_12().UseVisualStyleBackColor = true;
			this.vmethod_14().Location = new global::System.Drawing.Point(220, 141);
			this.vmethod_14().Name = "Button5";
			this.vmethod_14().Size = new global::System.Drawing.Size(133, 23);
			this.vmethod_14().TabIndex = 6;
			this.vmethod_14().Text = "作战条令/交战规则";
			this.vmethod_14().UseVisualStyleBackColor = true;
			this.vmethod_16().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_18()
			});
			this.vmethod_16().Location = new global::System.Drawing.Point(0, 399);
			this.vmethod_16().Name = "StatusStrip1";
			this.vmethod_16().Size = new global::System.Drawing.Size(366, 22);
			this.vmethod_16().TabIndex = 7;
			this.vmethod_16().Text = "StatusStrip1";
			this.vmethod_18().Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Italic);
			this.vmethod_18().Name = "ToolStripStatusLabel1";
			this.vmethod_18().Size = new global::System.Drawing.Size(309, 17);
			this.vmethod_18().Text = "双击推演方选取并关闭窗口";
			this.vmethod_20().Location = new global::System.Drawing.Point(217, 233);
			this.vmethod_20().Name = "Label1";
			this.vmethod_20().Size = new global::System.Drawing.Size(91, 13);
			this.vmethod_20().TabIndex = 8;
			this.vmethod_20().Text = "认知对手水平:";
			this.GetCB_Awareness().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GetCB_Awareness().FormattingEnabled = true;
			this.GetCB_Awareness().Items.AddRange(new object[]
			{
				"一无所知",
				"普通水平",
				"知其属方",
				"知其属方与单元",
				"无所不知"
			});
			this.GetCB_Awareness().Location = new global::System.Drawing.Point(220, 249);
			this.GetCB_Awareness().Name = "CB_Awareness";
			this.GetCB_Awareness().Size = new global::System.Drawing.Size(133, 21);
			this.GetCB_Awareness().TabIndex = 9;
			this.GetCB_CollectiveResponse().AutoSize = true;
			this.GetCB_CollectiveResponse().Location = new global::System.Drawing.Point(221, 190);
			this.GetCB_CollectiveResponse().Name = "CB_CollRespons";
			this.GetCB_CollectiveResponse().Size = new global::System.Drawing.Size(134, 17);
			this.GetCB_CollectiveResponse().TabIndex = 10;
			this.GetCB_CollectiveResponse().Text = "集体反应";
			this.GetCB_CollectiveResponse().UseVisualStyleBackColor = true;
			this.GetLabel_Proficiency().AutoSize = true;
			this.GetLabel_Proficiency().Location = new global::System.Drawing.Point(219, 280);
			this.GetLabel_Proficiency().Name = "Label_Proficiency";
			this.GetLabel_Proficiency().Size = new global::System.Drawing.Size(62, 13);
			this.GetLabel_Proficiency().TabIndex = 11;
			this.GetLabel_Proficiency().Text = "训练水平:";
			this.GetTrackBar_Proficiency().Location = new global::System.Drawing.Point(220, 296);
			this.GetTrackBar_Proficiency().Maximum = 4;
			this.GetTrackBar_Proficiency().Name = "TrackBar_Proficiency";
			this.GetTrackBar_Proficiency().Size = new global::System.Drawing.Size(133, 45);
			this.GetTrackBar_Proficiency().TabIndex = 12;
			this.GetCB_AutoTrackCivilians().Location = new global::System.Drawing.Point(221, 209);
			this.GetCB_AutoTrackCivilians().Name = "CB_AutoTrackCivs";
			this.GetCB_AutoTrackCivilians().Size = new global::System.Drawing.Size(136, 17);
			this.GetCB_AutoTrackCivilians().TabIndex = 13;
			this.GetCB_AutoTrackCivilians().Text = "自动跟踪非作战单元";
			this.GetCB_AutoTrackCivilians().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			base.ClientSize = new global::System.Drawing.Size(366, 421);
			base.Controls.Add(this.GetCB_AutoTrackCivilians());
			base.Controls.Add(this.GetTrackBar_Proficiency());
			base.Controls.Add(this.GetLabel_Proficiency());
			base.Controls.Add(this.GetCB_CollectiveResponse());
			base.Controls.Add(this.GetCB_Awareness());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Sides";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "编辑推演方";
			this.vmethod_16().ResumeLayout(false);
			this.vmethod_16().PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetTrackBar_Proficiency()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040025B6 RID: 9654
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

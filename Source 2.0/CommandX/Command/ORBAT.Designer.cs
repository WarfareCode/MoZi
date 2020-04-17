namespace Command
{
	// Token: 0x02000A12 RID: 2578
	public sealed partial class ORBAT : global::ns33.CommandForm
	{
		// Token: 0x06004F8D RID: 20365 RVA: 0x00200AD0 File Offset: 0x001FECD0
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

		// Token: 0x06004F8E RID: 20366 RVA: 0x00200B14 File Offset: 0x001FED14
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.TabControl());
			this.vmethod_3(new global::System.Windows.Forms.TabPage());
			this.vmethod_19(new global::ns15.CommandTreeView());
			this.vmethod_5(new global::System.Windows.Forms.TabPage());
			this.SetTV_ByMission(new global::ns15.CommandTreeView());
			this.vmethod_7(new global::System.Windows.Forms.StatusStrip());
			this.vmethod_9(new global::System.Windows.Forms.ToolStripStatusLabel());
			this.vmethod_11(new global::System.Windows.Forms.Label());
			this.vmethod_13(new global::System.Windows.Forms.Label());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.SetCB_Proficiency(new global::System.Windows.Forms.ComboBox());
			this.vmethod_0().SuspendLayout();
			this.vmethod_2().SuspendLayout();
			this.vmethod_4().SuspendLayout();
			this.vmethod_6().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Controls.Add(this.vmethod_4());
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 1);
			this.vmethod_0().Name = "TabControl1";
			this.vmethod_0().SelectedIndex = 0;
			this.vmethod_0().Size = new global::System.Drawing.Size(582, 334);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().Controls.Add(this.vmethod_18());
			this.vmethod_2().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_2().Name = "TabPage1";
			this.vmethod_2().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_2().Size = new global::System.Drawing.Size(574, 308);
			this.vmethod_2().TabIndex = 0;
			this.vmethod_2().Text = "作战编成";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_18().BackColor = global::System.Drawing.Color.Black;
			this.vmethod_18().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_18().ForeColor = global::System.Drawing.Color.White;
			this.vmethod_18().Location = new global::System.Drawing.Point(3, 3);
			this.vmethod_18().Name = "TV_ByGroup";
			this.vmethod_18().method_8(global::System.Drawing.SystemColors.Highlight);
			this.vmethod_18().method_6(global::ns15.Enum145.const_3);
			this.vmethod_18().Size = new global::System.Drawing.Size(568, 302);
			this.vmethod_18().TabIndex = 0;
			this.vmethod_4().Controls.Add(this.GetTV_ByMission());
			this.vmethod_4().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_4().Name = "TabPage2";
			this.vmethod_4().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_4().Size = new global::System.Drawing.Size(574, 308);
			this.vmethod_4().TabIndex = 1;
			this.vmethod_4().Text = "任务编成";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.GetTV_ByMission().BackColor = global::System.Drawing.Color.Black;
			this.GetTV_ByMission().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GetTV_ByMission().ForeColor = global::System.Drawing.Color.White;
			this.GetTV_ByMission().Location = new global::System.Drawing.Point(3, 3);
			this.GetTV_ByMission().Name = "TV_ByMission";
			this.GetTV_ByMission().method_8(global::System.Drawing.SystemColors.Highlight);
			this.GetTV_ByMission().method_6(global::ns15.Enum145.const_3);
			this.GetTV_ByMission().Size = new global::System.Drawing.Size(568, 302);
			this.GetTV_ByMission().TabIndex = 0;
			this.vmethod_6().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_8()
			});
			this.vmethod_6().Location = new global::System.Drawing.Point(0, 356);
			this.vmethod_6().Name = "StatusStrip1";
			this.vmethod_6().Size = new global::System.Drawing.Size(582, 22);
			this.vmethod_6().TabIndex = 2;
			this.vmethod_6().Text = "StatusStrip1";
			this.vmethod_8().Name = "ToolStripStatusLabel1";
			this.vmethod_8().Size = new global::System.Drawing.Size(276, 17);
			this.vmethod_8().Text = "点击选择作战单元并在地图置中显示。";
			this.vmethod_10().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_10().Location = new global::System.Drawing.Point(4, 339);
			this.vmethod_10().Name = "Label1";
			this.vmethod_10().Size = new global::System.Drawing.Size(92, 13);
			this.vmethod_10().TabIndex = 3;
			this.vmethod_10().Text = "推演方训练水平:";
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_12().Location = new global::System.Drawing.Point(90, 339);
			this.vmethod_12().Name = "Label_Proficiency";
			this.vmethod_12().Size = new global::System.Drawing.Size(51, 13);
			this.vmethod_12().TabIndex = 4;
			this.vmethod_12().Text = "一般";
			this.vmethod_14().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_14().Location = new global::System.Drawing.Point(282, 339);
			this.vmethod_14().Name = "Label_SetUnitProficiency";
			this.vmethod_14().Size = new global::System.Drawing.Size(132, 13);
			this.vmethod_14().TabIndex = 5;
			this.vmethod_14().Text = "设置作战编组/任务编组训练水平:";
			this.GetCB_Proficiency().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.GetCB_Proficiency().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GetCB_Proficiency().FormattingEnabled = true;
			this.GetCB_Proficiency().Items.AddRange(new object[]
			{
				"新手",
				"实习",
				"普通",
				"老手",
				"顶级",
				"与推演方一致"
			});
			this.GetCB_Proficiency().Location = new global::System.Drawing.Point(413, 334);
			this.GetCB_Proficiency().Name = "CB_Proficiency";
			this.GetCB_Proficiency().Size = new global::System.Drawing.Size(167, 21);
			this.GetCB_Proficiency().TabIndex = 6;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(582, 378);
			base.Controls.Add(this.GetCB_Proficiency());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ORBAT";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Show;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "作战编组/任务编组";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_6().ResumeLayout(false);
			this.vmethod_6().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400258A RID: 9610
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

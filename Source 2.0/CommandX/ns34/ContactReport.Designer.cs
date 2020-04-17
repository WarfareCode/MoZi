namespace ns34
{
	// Token: 0x02000A30 RID: 2608
	
	public sealed partial class ContactReport : global::ns33.CommandForm
	{
		// Token: 0x060052E0 RID: 21216 RVA: 0x0021E000 File Offset: 0x0021C200
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

		// Token: 0x060052E1 RID: 21217 RVA: 0x0021E044 File Offset: 0x0021C244
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.ListBox());
			this.vmethod_9(new global::System.Windows.Forms.ListBox());
			this.vmethod_11(new global::System.Windows.Forms.Label());
			this.vmethod_13(new global::System.Windows.Forms.TabControl());
			this.vmethod_15(new global::System.Windows.Forms.TabPage());
			this.vmethod_21(new global::System.Windows.Forms.SplitContainer());
			this.vmethod_17(new global::System.Windows.Forms.TabPage());
			this.vmethod_19(new global::System.Windows.Forms.Label());
			this.vmethod_12().SuspendLayout();
			this.vmethod_14().SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_20()).BeginInit();
			this.vmethod_20().Panel1.SuspendLayout();
			this.vmethod_20().Panel2.SuspendLayout();
			this.vmethod_20().SuspendLayout();
			this.vmethod_16().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(2, 9);
			this.vmethod_0().Name = "Label_UnitType";
			this.vmethod_0().Size = new global::System.Drawing.Size(80, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "作战单元类型:";
			this.vmethod_2().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_2().Location = new global::System.Drawing.Point(3, 0);
			this.vmethod_2().Name = "Label1";
			this.vmethod_2().Size = new global::System.Drawing.Size(250, 15);
			this.vmethod_2().TabIndex = 3;
			this.vmethod_2().Text = "探测到的电磁辐射:";
			this.vmethod_4().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_4().Location = new global::System.Drawing.Point(3, 0);
			this.vmethod_4().Name = "Label3";
			this.vmethod_4().Size = new global::System.Drawing.Size(130, 15);
			this.vmethod_4().TabIndex = 4;
			this.vmethod_4().Text = "潜在匹配结果:";
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_6().FormattingEnabled = true;
			this.vmethod_6().Location = new global::System.Drawing.Point(6, 20);
			this.vmethod_6().Name = "LB_Emissions";
			this.vmethod_6().Size = new global::System.Drawing.Size(606, 147);
			this.vmethod_6().TabIndex = 5;
			this.vmethod_8().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_8().FormattingEnabled = true;
			this.vmethod_8().Location = new global::System.Drawing.Point(6, 20);
			this.vmethod_8().Name = "LB_Matches";
			this.vmethod_8().Size = new global::System.Drawing.Size(606, 199);
			this.vmethod_8().TabIndex = 6;
			this.vmethod_10().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_10().Location = new global::System.Drawing.Point(121, 0);
			this.vmethod_10().Name = "Label2";
			this.vmethod_10().Size = new global::System.Drawing.Size(123, 13);
			this.vmethod_10().TabIndex = 7;
			this.vmethod_10().Text = "(双击查看数据库信息)";
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_12().Controls.Add(this.vmethod_14());
			this.vmethod_12().Controls.Add(this.vmethod_16());
			this.vmethod_12().Location = new global::System.Drawing.Point(5, 36);
			this.vmethod_12().Name = "TabControl1";
			this.vmethod_12().SelectedIndex = 0;
			this.vmethod_12().Size = new global::System.Drawing.Size(630, 435);
			this.vmethod_12().TabIndex = 8;
			this.vmethod_14().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_14().Controls.Add(this.vmethod_20());
			this.vmethod_14().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_14().Name = "TabPage1";
			this.vmethod_14().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_14().Size = new global::System.Drawing.Size(622, 409);
			this.vmethod_14().TabIndex = 0;
			this.vmethod_14().Text = "电磁辐射";
			this.vmethod_20().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_20().Location = new global::System.Drawing.Point(3, 3);
			this.vmethod_20().Name = "SplitContainer1";
			this.vmethod_20().Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.vmethod_20().Panel1.Controls.Add(this.vmethod_2());
			this.vmethod_20().Panel1.Controls.Add(this.vmethod_6());
			this.vmethod_20().Panel2.Controls.Add(this.vmethod_10());
			this.vmethod_20().Panel2.Controls.Add(this.vmethod_8());
			this.vmethod_20().Panel2.Controls.Add(this.vmethod_4());
			this.vmethod_20().Size = new global::System.Drawing.Size(616, 403);
			this.vmethod_20().SplitterDistance = 173;
			this.vmethod_20().TabIndex = 8;
			this.vmethod_16().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_16().Controls.Add(this.vmethod_18());
			this.vmethod_16().Location = new global::System.Drawing.Point(4, 22);
			this.vmethod_16().Name = "TabPage2";
			this.vmethod_16().Padding = new global::System.Windows.Forms.Padding(3);
			this.vmethod_16().Size = new global::System.Drawing.Size(622, 409);
			this.vmethod_16().TabIndex = 1;
			this.vmethod_16().Text = "识别出的辐射源平台";
			this.vmethod_18().AutoSize = true;
			this.vmethod_18().Location = new global::System.Drawing.Point(6, 3);
			this.vmethod_18().Name = "Label_HostedUnits";
			this.vmethod_18().Size = new global::System.Drawing.Size(110, 13);
			this.vmethod_18().TabIndex = 0;
			this.vmethod_18().Text = "Label_HostedUnits";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(636, 475);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ContactReport";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "目标报告";
			this.vmethod_12().ResumeLayout(false);
			this.vmethod_14().ResumeLayout(false);
			this.vmethod_20().Panel1.ResumeLayout(false);
			this.vmethod_20().Panel1.PerformLayout();
			this.vmethod_20().Panel2.ResumeLayout(false);
			this.vmethod_20().Panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_20()).EndInit();
			this.vmethod_20().ResumeLayout(false);
			this.vmethod_16().ResumeLayout(false);
			this.vmethod_16().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040026DC RID: 9948
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

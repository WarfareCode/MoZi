namespace ns33
{
	// Token: 0x0200098E RID: 2446
	
	public sealed partial class ScenAttachmentsWindow : global::ns33.CommandForm
	{
		// Token: 0x06003DAD RID: 15789 RVA: 0x0014192C File Offset: 0x0013FB2C
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

		// Token: 0x06003DAE RID: 15790 RVA: 0x00141970 File Offset: 0x0013FB70
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns33.ScenAttachmentsWindow));
			this.vmethod_1(new global::System.Windows.Forms.ListBox());
			this.vmethod_3(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_5(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_9(new global::System.Windows.Forms.ToolStripComboBox());
			this.vmethod_11(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_7(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_13(new global::System.Windows.Forms.PropertyGrid());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_2().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().DisplayMember = "Name";
			this.vmethod_0().FormattingEnabled = true;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 25);
			this.vmethod_0().Name = "ListBox1";
			this.vmethod_0().Size = new global::System.Drawing.Size(530, 264);
			this.vmethod_0().TabIndex = 3;
			this.vmethod_2().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_4(),
				this.vmethod_8(),
				this.vmethod_10(),
				this.vmethod_6()
			});
			this.vmethod_2().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_2().Name = "ToolStrip1";
			this.vmethod_2().Size = new global::System.Drawing.Size(742, 25);
			this.vmethod_2().TabIndex = 2;
			this.vmethod_2().Text = "ToolStrip1";
			this.vmethod_4().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_4().Name = "ToolStripButton1";
			this.vmethod_4().Size = new global::System.Drawing.Size(119, 22);
			this.vmethod_4().Text = "创建新附件，类型:";
			this.vmethod_8().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_8().Items.AddRange(new object[]
			{
				"地图图层(单一图片)",
				"Lua脚本",
				"Inst导入",
				"本地视频"
			});
			this.vmethod_8().Name = "TSCB1";
			this.vmethod_8().Size = new global::System.Drawing.Size(180, 25);
            //ZSP ERR IMG this.vmethod_10().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton3.Image");
            this.vmethod_10().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_10().Name = "ToolStripButton3";
			this.vmethod_10().Size = new global::System.Drawing.Size(92, 22);
			this.vmethod_10().Text = "添加现有附件";
            //ZSP ERR IMG this.vmethod_6().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton2.Image");
            this.vmethod_6().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_6().Name = "ToolStripButton2";
			this.vmethod_6().Size = new global::System.Drawing.Size(117, 22);
			this.vmethod_6().Text = "删除所选附件";
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_12().CategoryForeColor = global::System.Drawing.SystemColors.InactiveCaptionText;
			this.vmethod_12().Location = new global::System.Drawing.Point(536, 25);
			this.vmethod_12().Name = "PropertyGrid1";
			this.vmethod_12().Size = new global::System.Drawing.Size(206, 264);
			this.vmethod_12().TabIndex = 4;
			this.vmethod_14().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_14().BackColor = global::System.Drawing.Color.Transparent;
			this.vmethod_14().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_14().Location = new global::System.Drawing.Point(535, 4);
			this.vmethod_14().Name = "Label1";
			this.vmethod_14().Size = new global::System.Drawing.Size(128, 15);
			this.vmethod_14().TabIndex = 5;
			this.vmethod_14().Text = "所选附件属性:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(742, 288);
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ScenAttachmentsWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "想定附件";
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001C4D RID: 7245
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

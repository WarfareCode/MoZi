namespace ns33
{
	// Token: 0x02000977 RID: 2423
	
	public sealed partial class CampaignEditorWindow : global::ns33.CommandForm
	{
		// Token: 0x06003BA4 RID: 15268 RVA: 0x001271D4 File Offset: 0x001253D4
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

		// Token: 0x06003BA5 RID: 15269 RVA: 0x00127218 File Offset: 0x00125418
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns33.CampaignEditorWindow));
			this.vmethod_1(new global::System.Windows.Forms.DataGridView());
			this.vmethod_33(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_35(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_3(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_5(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_21(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_7(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_9(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_11(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_19(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_23(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_13(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_15(new global::System.Windows.Forms.OpenFileDialog());
			this.vmethod_17(new global::System.Windows.Forms.SaveFileDialog());
			this.vmethod_25(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_27(new global::System.Windows.Forms.ToolStripLabel());
			this.vmethod_29(new global::System.Windows.Forms.ToolStripTextBox());
			this.vmethod_31(new global::System.Windows.Forms.ToolStripButton());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_2().SuspendLayout();
			this.vmethod_24().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AllowUserToResizeRows = false;
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_0().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_32(),
				this.vmethod_34()
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 161);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.vmethod_0().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_0().EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.vmethod_0().GridColor = global::System.Drawing.SystemColors.ControlText;
			this.vmethod_0().Location = new global::System.Drawing.Point(2, 28);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DGV_CampaignItems";
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().RowHeadersWidth = 10;
			this.vmethod_0().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new global::System.Drawing.Size(905, 376);
			this.vmethod_0().TabIndex = 9;
			this.vmethod_32().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_32().HeaderText = "名称";
			this.vmethod_32().Name = "Column1";
			this.vmethod_32().ReadOnly = true;
			this.vmethod_32().Width = 58;
			this.vmethod_34().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_34().HeaderText = "转阶段条件";
			this.vmethod_34().Name = "Column2";
			this.vmethod_34().ReadOnly = true;
			this.vmethod_2().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_2().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_4(),
				this.vmethod_20(),
				this.vmethod_6(),
				this.vmethod_8(),
				this.vmethod_10(),
				this.vmethod_18(),
				this.vmethod_22(),
				this.vmethod_12()
			});
			this.vmethod_2().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_2().Name = "ToolStrip1";
			this.vmethod_2().Size = new global::System.Drawing.Size(907, 25);
			this.vmethod_2().TabIndex = 10;
			this.vmethod_2().Text = "ToolStrip1";
            //ZSP ERR IMG this.vmethod_4().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_AddScenario.Image");
            this.vmethod_4().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_4().Name = "TSB_AddScenario";
			this.vmethod_4().Size = new global::System.Drawing.Size(97, 22);
			this.vmethod_4().Text = "添加想定";
            //ZSP ERR IMG this.vmethod_20().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_AddAttachment.Image");
            this.vmethod_20().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_20().Name = "TSB_AddAttachment";
			this.vmethod_20().Size = new global::System.Drawing.Size(115, 22);
			this.vmethod_20().Text = "添加附件";
            //ZSP ERR IMG this.vmethod_6().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_RemoveSelected.Image");
            this.vmethod_6().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_6().Name = "TSB_RemoveSelected";
			this.vmethod_6().Size = new global::System.Drawing.Size(117, 22);
			this.vmethod_6().Text = "删除所选";
            //ZSP ERR IMG this.vmethod_8().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_MoveUp.Image");
            this.vmethod_8().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_8().Name = "TSB_MoveUp";
			this.vmethod_8().Size = new global::System.Drawing.Size(75, 22);
			this.vmethod_8().Text = "上移";
            //ZSP ERR IMG this.vmethod_10().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_MoveDown.Image");
            this.vmethod_10().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_10().Name = "TSB_MoveDown";
			this.vmethod_10().Size = new global::System.Drawing.Size(91, 22);
			this.vmethod_10().Text = "下移";
            //ZSP ERR IMG this.vmethod_18().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_Description.Image");
            this.vmethod_18().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_18().Name = "TSB_Description";
			this.vmethod_18().Size = new global::System.Drawing.Size(124, 22);
			this.vmethod_18().Text = "想定标题与描述";
            //ZSP ERR IMG this.vmethod_22().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_CampaignEnding.Image");
            this.vmethod_22().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_22().Name = "TSB_CampaignEnding";
			this.vmethod_22().Size = new global::System.Drawing.Size(89, 22);
			this.vmethod_22().Text = "战役目标描述";
            //ZSP ERR IMG this.vmethod_12().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_Save.Image");
            this.vmethod_12().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_12().Name = "TSB_Save";
			this.vmethod_12().Size = new global::System.Drawing.Size(109, 22);
			this.vmethod_12().Text = "保存战役";
			this.vmethod_24().Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.vmethod_24().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_24().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_26(),
				this.vmethod_28(),
				this.vmethod_30()
			});
			this.vmethod_24().Location = new global::System.Drawing.Point(0, 407);
			this.vmethod_24().Name = "TS_PassScore";
			this.vmethod_24().Size = new global::System.Drawing.Size(907, 25);
			this.vmethod_24().TabIndex = 12;
			this.vmethod_24().Text = "ToolStrip2";
			this.vmethod_26().Name = "TSL_PassScore";
			this.vmethod_26().Size = new global::System.Drawing.Size(160, 22);
			this.vmethod_26().Text = "所选想定的转阶段条件:";
			this.vmethod_28().Name = "TSTB_PassScore";
			this.vmethod_28().Size = new global::System.Drawing.Size(100, 25);
			this.vmethod_30().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //ZSP ERR IMG this.vmethod_30().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSL_SetScore.Image");
            this.vmethod_30().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_30().Name = "TSL_SetScore";
			this.vmethod_30().Size = new global::System.Drawing.Size(30, 22);
			this.vmethod_30().Text = "设置";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(907, 432);
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_2());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CampaignEditorWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "战役编辑器";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			this.vmethod_2().ResumeLayout(false);
			this.vmethod_2().PerformLayout();
			this.vmethod_24().ResumeLayout(false);
			this.vmethod_24().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001B3C RID: 6972
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

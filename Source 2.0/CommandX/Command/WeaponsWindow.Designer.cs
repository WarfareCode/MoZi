namespace Command
{
	// Token: 0x02000AD9 RID: 2777
	public sealed partial class WeaponsWindow : global::ns33.CommandForm
	{
		// Token: 0x060058BD RID: 22717 RVA: 0x0026F678 File Offset: 0x0026D878
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool flag)
		{
			try
			{
				if (flag && this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(flag);
			}
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x0026F6BC File Offset: 0x0026D8BC
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Command.WeaponsWindow));
			this.vmethod_1(new global::ns29.TreeGridViewTextBoxColumn());
			this.vmethod_3(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_5(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_7(new global::AdvancedDataGridView.TreeGridView());
			this.vmethod_35(new global::ns29.TreeGridViewTextBoxColumn());
			this.vmethod_37(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_39(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_41(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_43(new global::System.Windows.Forms.DataGridViewCheckBoxColumn());
			this.vmethod_45(new global::System.Windows.Forms.DataGridViewCheckBoxColumn());
			this.vmethod_9(new global::System.Windows.Forms.ImageList(this.icontainer_0));
			this.vmethod_11(new global::System.Windows.Forms.Timer(this.icontainer_0));
			this.vmethod_13(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_15(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_17(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_31(new global::System.Windows.Forms.ToolStripSeparator());
			this.vmethod_23(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_25(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_33(new global::System.Windows.Forms.ToolStripSeparator());
			this.vmethod_19(new global::System.Windows.Forms.ToolStripLabel());
			this.vmethod_27(new global::System.Windows.Forms.ToolStripLabel());
			this.vmethod_21(new global::System.Windows.Forms.ToolStripTextBox());
			this.vmethod_29(new global::System.Windows.Forms.ToolStripButton());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_6()).BeginInit();
			this.vmethod_12().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_0().SetImage(null);
			this.vmethod_0().HeaderText = "挂架";
			this.vmethod_0().Name = "Mount";
			this.vmethod_0().ReadOnly = true;
			this.vmethod_0().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_2().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_2().HeaderText = "类型";
			this.vmethod_2().Name = "WeaponType";
			this.vmethod_2().ReadOnly = true;
			this.vmethod_2().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_4().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_4().HeaderText = "状态";
			this.vmethod_4().Name = "Status";
			this.vmethod_4().ReadOnly = true;
			this.vmethod_4().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_6().AllowUserToAddRows = false;
			this.vmethod_6().AllowUserToDeleteRows = false;
			this.vmethod_6().AllowUserToOrderColumns = true;
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_6().AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.vmethod_6().AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.vmethod_6().CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.vmethod_6().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_34(),
				this.vmethod_36(),
				this.vmethod_38(),
				this.vmethod_40(),
				this.vmethod_42(),
				this.vmethod_44()
			});
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.vmethod_6().DefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_6().EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.vmethod_6().method_8(null);
			this.vmethod_6().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_6().MultiSelect = false;
			this.vmethod_6().Name = "TGV_Weapons";
			this.vmethod_6().RowHeadersVisible = false;
			this.vmethod_6().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_6().method_6(false);
			this.vmethod_6().Size = new global::System.Drawing.Size(732, 333);
			this.vmethod_6().TabIndex = 4;
			this.vmethod_34().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.Blue;
			this.vmethod_34().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_34().SetImage(null);
			this.vmethod_34().HeaderText = "挂架(点击武器查看数据库信息)";
			this.vmethod_34().MinimumWidth = 250;
			this.vmethod_34().Name = "Column1";
			this.vmethod_34().ReadOnly = true;
			this.vmethod_34().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_36().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_36().DefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_36().FillWeight = 10f;
			this.vmethod_36().HeaderText = "";
			this.vmethod_36().MinimumWidth = 75;
			this.vmethod_36().Name = "Type";
			this.vmethod_36().ReadOnly = true;
			this.vmethod_36().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_38().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_38().DefaultCellStyle = dataGridViewCellStyle4;
			this.vmethod_38().HeaderText = "开火时间";
			this.vmethod_38().Name = "TimeToFire";
			this.vmethod_38().ReadOnly = true;
			this.vmethod_38().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_38().Width = 63;
			this.vmethod_40().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_40().DefaultCellStyle = dataGridViewCellStyle5;
			this.vmethod_40().FillWeight = 10f;
			this.vmethod_40().HeaderText = "状态";
			this.vmethod_40().MinimumWidth = 75;
			this.vmethod_40().Name = "Column3";
			this.vmethod_40().ReadOnly = true;
			this.vmethod_40().SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.vmethod_42().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle6.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			dataGridViewCellStyle6.NullValue = false;
			this.vmethod_42().DefaultCellStyle = dataGridViewCellStyle6;
			this.vmethod_42().HeaderText = "重新装载优先级";
			this.vmethod_42().Name = "ReloadPriority";
			this.vmethod_42().Width = 79;
			this.vmethod_44().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle7.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			dataGridViewCellStyle7.NullValue = false;
			this.vmethod_44().DefaultCellStyle = dataGridViewCellStyle7;
			this.vmethod_44().HeaderText = "显示火力覆盖";
			this.vmethod_44().Name = "ShowArcs";
			this.vmethod_44().Width = 62;
			this.vmethod_8().ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			this.vmethod_8().ImageSize = new global::System.Drawing.Size(16, 16);
			this.vmethod_8().TransparentColor = global::System.Drawing.Color.Transparent;
			this.vmethod_10().Interval = 500;
			this.vmethod_12().Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.vmethod_12().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_12().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_14(),
				this.vmethod_16(),
				this.vmethod_30(),
				this.vmethod_22(),
				this.vmethod_24(),
				this.vmethod_32(),
				this.vmethod_18(),
				this.vmethod_26(),
				this.vmethod_20(),
				this.vmethod_28()
			});
			this.vmethod_12().Location = new global::System.Drawing.Point(0, 336);
			this.vmethod_12().Name = "TS_Edit";
			this.vmethod_12().Size = new global::System.Drawing.Size(732, 25);
			this.vmethod_12().TabIndex = 7;
			this.vmethod_12().Text = "ToolStrip1";
            //ZSP ERR IMG this.vmethod_14().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_AddRec.Image");
            this.vmethod_14().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_14().Name = "TSB_AddRec";
			this.vmethod_14().Size = new global::System.Drawing.Size(136, 22);
			this.vmethod_14().Text = "添加武器系统";
            //ZSP ERR IMG this.vmethod_16().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_RemoveRec.Image");
            this.vmethod_16().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_16().Name = "TSB_RemoveRec";
			this.vmethod_16().Size = new global::System.Drawing.Size(170, 22);
			this.vmethod_16().Text = "删除武器系统";
			this.vmethod_30().Name = "ToolStripSeparator1";
			this.vmethod_30().Size = new global::System.Drawing.Size(6, 25);
            //ZSP ERR IMG this.vmethod_22().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_AddMount.Image");
            this.vmethod_22().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_22().Name = "TSB_AddMount";
			this.vmethod_22().Size = new global::System.Drawing.Size(88, 22);
			this.vmethod_22().Text = "添加武器挂架";
            //ZSP ERR IMG this.vmethod_24().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_RemoveMount.Image");
            this.vmethod_24().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_24().Name = "TSB_RemoveMount";
			this.vmethod_24().Size = new global::System.Drawing.Size(109, 22);
			this.vmethod_24().Text = "删除武器挂架";
			this.vmethod_24().ToolTipText = "Remove Mount";
			this.vmethod_32().Name = "ToolStripSeparator2";
			this.vmethod_32().Size = new global::System.Drawing.Size(6, 25);
			this.vmethod_18().Name = "TSL_WeaponCount1";
			this.vmethod_18().Size = new global::System.Drawing.Size(59, 22);
			this.vmethod_18().Text = "武器:";
			this.vmethod_26().Name = "TSL_WeaponCount2";
			this.vmethod_26().Size = new global::System.Drawing.Size(37, 22);
			this.vmethod_26().Text = "12345";
			this.vmethod_20().BackColor = global::System.Drawing.Color.Gainsboro;
			this.vmethod_20().Name = "TSTB_RecCount";
			this.vmethod_20().Size = new global::System.Drawing.Size(40, 25);
			this.vmethod_20().Visible = false;
			this.vmethod_28().BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.vmethod_28().DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //ZSP ERR IMG this.vmethod_28().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TSB_ChangeWeaponCount.Image");
            this.vmethod_28().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_28().Name = "TSB_ChangeWeaponCount";
			this.vmethod_28().Size = new global::System.Drawing.Size(52, 22);
			this.vmethod_28().Text = "改变";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(732, 361);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_6());
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "WeaponsWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "武器";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_6()).EndInit();
			this.vmethod_12().ResumeLayout(false);
			this.vmethod_12().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002BD8 RID: 11224
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

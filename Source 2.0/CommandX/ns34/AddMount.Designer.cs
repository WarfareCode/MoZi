namespace ns34
{
	// Token: 0x02000A26 RID: 2598
	
	public sealed partial class AddMount : global::ns33.CommandForm
	{
		// Token: 0x060050D4 RID: 20692 RVA: 0x0020DF50 File Offset: 0x0020C150
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

		// Token: 0x060050D5 RID: 20693 RVA: 0x0020DF94 File Offset: 0x0020C194
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_1(new global::System.Windows.Forms.DataGridView());
			this.vmethod_3(new global::System.ComponentModel.BackgroundWorker());
			this.vmethod_5(new global::System.Windows.Forms.StatusStrip());
			this.vmethod_7(new global::System.Windows.Forms.ToolStripStatusLabel());
			this.vmethod_9(new global::System.Windows.Forms.Button());
			this.vmethod_11(new global::System.Windows.Forms.CheckBox());
			this.vmethod_13(new global::System.Windows.Forms.TextBox());
			this.vmethod_15(new global::ns33.PlatformComponentArcControl());
			this.vmethod_17(new global::System.Windows.Forms.Label());
			this.vmethod_19(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_21(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_4().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_18(),
				this.vmethod_20()
			});
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 110);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DataGridView1";
			this.vmethod_0().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new global::System.Drawing.Size(503, 379);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_4().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_6()
			});
			this.vmethod_4().Location = new global::System.Drawing.Point(0, 492);
			this.vmethod_4().Name = "StatusStrip1";
			this.vmethod_4().Size = new global::System.Drawing.Size(503, 22);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "StatusStrip1";
			this.vmethod_6().Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.vmethod_6().Name = "ToolStripStatusLabel1";
			this.vmethod_6().Size = new global::System.Drawing.Size(128, 17);
			this.vmethod_6().Text = "ToolStripStatusLabel1";
			this.vmethod_8().Location = new global::System.Drawing.Point(7, 5);
			this.vmethod_8().Name = "Button1";
			this.vmethod_8().Size = new global::System.Drawing.Size(89, 23);
			this.vmethod_8().TabIndex = 3;
			this.vmethod_8().Text = "增加所选挂架";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(7, 62);
			this.vmethod_10().Name = "CB_Filter1";
			this.vmethod_10().Size = new global::System.Drawing.Size(108, 17);
			this.vmethod_10().TabIndex = 13;
			this.vmethod_10().Text = "关键字过滤:";
			this.vmethod_10().UseVisualStyleBackColor = true;
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_12().Location = new global::System.Drawing.Point(7, 85);
			this.vmethod_12().Name = "TB_Find";
			this.vmethod_12().Size = new global::System.Drawing.Size(386, 20);
			this.vmethod_12().TabIndex = 12;
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Location = new global::System.Drawing.Point(399, 4);
			this.vmethod_14().Name = "ArcControl1";
			this.vmethod_14().Size = new global::System.Drawing.Size(103, 100);
			this.vmethod_14().TabIndex = 14;
			this.vmethod_16().Location = new global::System.Drawing.Point(179, 10);
			this.vmethod_16().Name = "Label3";
			this.vmethod_16().Size = new global::System.Drawing.Size(226, 13);
			this.vmethod_16().TabIndex = 19;
			//this.vmethod_16().Text = "Tips: Double-click to select or deselect all arcs";
            this.vmethod_16().Text = "提示: 双击全选或全不选所有角度";
            this.vmethod_18().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_18().DataPropertyName = "ID";
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_18().DefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_18().HeaderText = "ID";
			this.vmethod_18().Name = "ID";
			this.vmethod_18().ReadOnly = true;
			this.vmethod_18().Width = 41;
			this.vmethod_20().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_20().DataPropertyName = "Name";
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_20().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_20().HeaderText = "名称";
			this.vmethod_20().Name = "Description";
			this.vmethod_20().ReadOnly = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(503, 514);
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddMount";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            //this.Text = "Add Weapon Mount";
            this.Text = "添加武器挂架";
            ((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_4().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002601 RID: 9729
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

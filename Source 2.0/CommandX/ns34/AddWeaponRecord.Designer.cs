namespace ns34
{
	// Token: 0x02000A2E RID: 2606
	
	public sealed partial class AddWeaponRecord : global::ns33.CommandForm
	{
		// Token: 0x06005264 RID: 21092 RVA: 0x0021AD94 File Offset: 0x00218F94
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

		// Token: 0x06005265 RID: 21093 RVA: 0x0021ADD8 File Offset: 0x00218FD8
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_1(new global::System.Windows.Forms.DataGridView());
			this.vmethod_2(new global::System.ComponentModel.BackgroundWorker());
			this.vmethod_4(new global::System.Windows.Forms.StatusStrip());
			this.vmethod_6(new global::System.Windows.Forms.ToolStripStatusLabel());
			this.vmethod_8(new global::System.Windows.Forms.Button());
			this.vmethod_10(new global::System.Windows.Forms.CheckBox());
			this.vmethod_12(new global::System.Windows.Forms.TextBox());
			this.vmethod_14(new global::System.Windows.Forms.CheckBox());
			this.vmethod_16(new global::System.Windows.Forms.Button());
			this.vmethod_18(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_20(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_3().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_17(),
				this.vmethod_19()
			});
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 93);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DataGridView1";
			this.vmethod_0().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new global::System.Drawing.Size(331, 388);
			this.vmethod_0().TabIndex = 1;
			this.vmethod_3().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_5()
			});
			this.vmethod_3().Location = new global::System.Drawing.Point(0, 484);
			this.vmethod_3().Name = "StatusStrip1";
			this.vmethod_3().Size = new global::System.Drawing.Size(331, 22);
			this.vmethod_3().TabIndex = 2;
			this.vmethod_3().Text = "StatusStrip1";
			this.vmethod_5().Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.vmethod_5().Name = "ToolStripStatusLabel1";
			this.vmethod_5().Size = new global::System.Drawing.Size(128, 17);
			this.vmethod_5().Text = "ToolStripStatusLabel1";
			this.vmethod_7().Location = new global::System.Drawing.Point(7, 12);
			this.vmethod_7().Name = "Button1";
			this.vmethod_7().Size = new global::System.Drawing.Size(89, 23);
			this.vmethod_7().TabIndex = 3;
			this.vmethod_7().Text = "添加";
			this.vmethod_7().UseVisualStyleBackColor = true;
			this.vmethod_9().AutoSize = true;
			this.vmethod_9().Location = new global::System.Drawing.Point(7, 47);
			this.vmethod_9().Name = "CB_Filter1";
			this.vmethod_9().Size = new global::System.Drawing.Size(108, 17);
			this.vmethod_9().TabIndex = 13;
			this.vmethod_9().Text = "过滤:";
			this.vmethod_9().UseVisualStyleBackColor = true;
			this.vmethod_11().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_11().Location = new global::System.Drawing.Point(121, 45);
			this.vmethod_11().Name = "TB_Find";
			this.vmethod_11().Size = new global::System.Drawing.Size(198, 20);
			this.vmethod_11().TabIndex = 12;
			this.vmethod_13().AutoSize = true;
			this.vmethod_13().Location = new global::System.Drawing.Point(7, 70);
			this.vmethod_13().Name = "CB_Filter2";
			this.vmethod_13().Size = new global::System.Drawing.Size(314, 17);
			this.vmethod_13().TabIndex = 14;
			this.vmethod_13().Text = "Show only weapons compatible with aircraft hosted by parent";
			this.vmethod_13().UseVisualStyleBackColor = true;
			this.vmethod_15().Location = new global::System.Drawing.Point(121, 12);
			this.vmethod_15().Name = "Button_Add10K";
			this.vmethod_15().Size = new global::System.Drawing.Size(198, 23);
			this.vmethod_15().TabIndex = 15;
			this.vmethod_15().Text = "增加 '10000' 所选武器";
			this.vmethod_15().UseVisualStyleBackColor = true;
			this.vmethod_17().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_17().DataPropertyName = "ID";
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_17().DefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_17().HeaderText = "ID";
			this.vmethod_17().Name = "ID";
			this.vmethod_17().ReadOnly = true;
			this.vmethod_17().Width = 41;
			this.vmethod_19().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_19().DataPropertyName = "Description";
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_19().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_19().HeaderText = "描述";
			this.vmethod_19().Name = "Description";
			this.vmethod_19().ReadOnly = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(331, 506);
			base.Controls.Add(this.vmethod_15());
			base.Controls.Add(this.vmethod_13());
			base.Controls.Add(this.vmethod_9());
			base.Controls.Add(this.vmethod_11());
			base.Controls.Add(this.vmethod_7());
			base.Controls.Add(this.vmethod_3());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddWeaponRecord";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "增加武器";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			this.vmethod_3().ResumeLayout(false);
			this.vmethod_3().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040026AA RID: 9898
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

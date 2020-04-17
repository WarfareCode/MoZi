namespace ns34
{
	// Token: 0x02000A2A RID: 2602
	
	public sealed partial class AddSensor : global::ns33.CommandForm
	{
		// Token: 0x06005170 RID: 20848 RVA: 0x002140B4 File Offset: 0x002122B4
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

		// Token: 0x06005171 RID: 20849 RVA: 0x002140F8 File Offset: 0x002122F8
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
			this.vmethod_17(new global::System.Windows.Forms.Label());
			this.vmethod_15(new global::ns33.PlatformComponentArcControl());
			this.vmethod_19(new global::ns33.PlatformComponentArcControl());
			this.vmethod_21(new global::System.Windows.Forms.Label());
			this.vmethod_23(new global::System.Windows.Forms.Label());
			this.vmethod_25(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_27(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			this.vmethod_4().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_24(),
				this.vmethod_26()
			});
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 159);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DataGridView1";
			this.vmethod_0().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new global::System.Drawing.Size(503, 330);
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
			this.vmethod_8().Text = "添加所选传感器";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(7, 111);
			this.vmethod_10().Name = "CB_Filter1";
			this.vmethod_10().Size = new global::System.Drawing.Size(108, 17);
			this.vmethod_10().TabIndex = 13;
			this.vmethod_10().Text = "关键字过滤:";
			this.vmethod_10().UseVisualStyleBackColor = true;
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_12().Location = new global::System.Drawing.Point(6, 134);
			this.vmethod_12().Name = "TB_Find";
			this.vmethod_12().Size = new global::System.Drawing.Size(386, 20);
			this.vmethod_12().TabIndex = 12;
			this.vmethod_16().Location = new global::System.Drawing.Point(309, 1);
			this.vmethod_16().Name = "Label1";
			this.vmethod_16().Size = new global::System.Drawing.Size(53, 13);
			this.vmethod_16().TabIndex = 15;
			this.vmethod_16().Text = "探测";
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Location = new global::System.Drawing.Point(394, 13);
			this.vmethod_14().Name = "ArcControl_Illumination";
			this.vmethod_14().Size = new global::System.Drawing.Size(103, 100);
			this.vmethod_14().TabIndex = 14;
			this.vmethod_18().AutoSize = true;
			this.vmethod_18().Location = new global::System.Drawing.Point(288, 12);
			this.vmethod_18().Name = "ArcControl_Detection";
			this.vmethod_18().Size = new global::System.Drawing.Size(103, 100);
			this.vmethod_18().TabIndex = 16;
			this.vmethod_20().Location = new global::System.Drawing.Point(386, 2);
			this.vmethod_20().Name = "Label2";
			this.vmethod_20().Size = new global::System.Drawing.Size(112, 13);
			this.vmethod_20().TabIndex = 17;
			this.vmethod_20().Text = "跟踪 / 照射";
			this.vmethod_22().Location = new global::System.Drawing.Point(271, 111);
			this.vmethod_22().Name = "Label3";
			this.vmethod_22().Size = new global::System.Drawing.Size(226, 13);
			this.vmethod_22().TabIndex = 18;
			this.vmethod_22().Text = "提示: 双击全选或全部取消所选角度";
			this.vmethod_24().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_24().DataPropertyName = "ID";
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_24().DefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_24().HeaderText = "ID";
			this.vmethod_24().Name = "ID";
			this.vmethod_24().ReadOnly = true;
			this.vmethod_24().Width = 41;
			this.vmethod_26().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_26().DataPropertyName = "Name";
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.vmethod_26().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_26().HeaderText = "名称";
			this.vmethod_26().Name = "Description";
			this.vmethod_26().ReadOnly = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(503, 514);
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_18());
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
			base.Name = "AddSensor";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "添加传感器";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			this.vmethod_4().ResumeLayout(false);
			this.vmethod_4().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002646 RID: 9798
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

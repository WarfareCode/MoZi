namespace Command
{
	// Token: 0x02000CEE RID: 3310
	public sealed partial class SatPredictionForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06006CE4 RID: 27876 RVA: 0x003D1BF0 File Offset: 0x003CFDF0
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

		// Token: 0x06006CE5 RID: 27877 RVA: 0x003D1C34 File Offset: 0x003CFE34
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.DataGridView());
			this.vmethod_19(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_21(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_23(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_25(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_3(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_5(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_7(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_9(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_11(new global::System.Windows.Forms.Label());
			this.vmethod_13(new global::System.Windows.Forms.NumericUpDown());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_17(new global::System.Windows.Forms.Button());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_12()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AllowUserToOrderColumns = true;
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_18(),
				this.vmethod_20(),
				this.vmethod_22(),
				this.vmethod_24()
			});
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 23);
			this.vmethod_0().Name = "DataGridView1";
			this.vmethod_0().ReadOnly = true;
			this.vmethod_0().Size = new global::System.Drawing.Size(804, 461);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_18().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_18().HeaderText = "卫星";
			this.vmethod_18().Name = "Satellite";
			this.vmethod_18().ReadOnly = true;
			this.vmethod_18().Width = 67;
			this.vmethod_20().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_20().HeaderText = "方";
			this.vmethod_20().Name = "Side";
			this.vmethod_20().ReadOnly = true;
			this.vmethod_20().Width = 51;
			this.vmethod_22().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.vmethod_22().HeaderText = "覆盖开始:";
			this.vmethod_22().Name = "CoverageStart";
			this.vmethod_22().ReadOnly = true;
			this.vmethod_22().Width = 102;
			this.vmethod_24().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_24().HeaderText = "过顶时间";
			this.vmethod_24().Name = "DwellTime";
			this.vmethod_24().ReadOnly = true;
			this.vmethod_2().HeaderText = "卫星";
			this.vmethod_2().Name = "DataGridViewTextBoxColumn1";
			this.vmethod_2().ReadOnly = true;
			this.vmethod_4().HeaderText = "方";
			this.vmethod_4().Name = "DataGridViewTextBoxColumn2";
			this.vmethod_4().ReadOnly = true;
			this.vmethod_6().HeaderText = "覆盖开始:";
			this.vmethod_6().Name = "DataGridViewTextBoxColumn3";
			this.vmethod_6().ReadOnly = true;
			this.vmethod_8().HeaderText = "过顶时间";
			this.vmethod_8().Name = "DataGridViewTextBoxColumn4";
			this.vmethod_8().ReadOnly = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(3, 5);
			this.vmethod_10().Name = "Label1";
			this.vmethod_10().Size = new global::System.Drawing.Size(96, 13);
			this.vmethod_10().TabIndex = 1;
			this.vmethod_10().Text = "预测下一个";
			this.vmethod_12().Location = new global::System.Drawing.Point(100, 2);
			this.vmethod_12().Name = "NumericUpDown1";
			this.vmethod_12().Size = new global::System.Drawing.Size(44, 20);
			this.vmethod_12().TabIndex = 2;
			this.vmethod_14().Location = new global::System.Drawing.Point(146, 5);
			this.vmethod_14().Name = "Label2";
			this.vmethod_14().Size = new global::System.Drawing.Size(29, 13);
			this.vmethod_14().TabIndex = 3;
			this.vmethod_14().Text = "天";
			this.vmethod_16().Location = new global::System.Drawing.Point(201, 2);
			this.vmethod_16().Name = "Button1";
			this.vmethod_16().Size = new global::System.Drawing.Size(75, 20);
			this.vmethod_16().TabIndex = 4;
			this.vmethod_16().Text = "重新计算";
			this.vmethod_16().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(804, 484);
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_0());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SatPredictionForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "卫星过顶预测";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_12()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04003EC4 RID: 16068
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

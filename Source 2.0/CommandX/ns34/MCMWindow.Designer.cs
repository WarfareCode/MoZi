namespace ns34
{
	// Token: 0x02000A40 RID: 2624
	
	public sealed partial class MCMWindow : global::ns33.CommandForm
	{
		// Token: 0x0600535D RID: 21341 RVA: 0x00221DE0 File Offset: 0x0021FFE0
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

		// Token: 0x0600535E RID: 21342 RVA: 0x00221E24 File Offset: 0x00220024
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.vmethod_1(new global::System.Windows.Forms.DataGridView());
			this.vmethod_3(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			this.vmethod_5(new global::System.Windows.Forms.DataGridViewTextBoxColumn());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().AllowUserToAddRows = false;
			this.vmethod_0().AllowUserToDeleteRows = false;
			this.vmethod_0().AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.vmethod_0().AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.vmethod_0().CausesValidation = false;
			this.vmethod_0().ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vmethod_0().Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.vmethod_2(),
				this.vmethod_4()
			});
			this.vmethod_0().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().MultiSelect = false;
			this.vmethod_0().Name = "DGV_Sensors";
			this.vmethod_0().RowHeadersVisible = false;
			this.vmethod_0().RowHeadersWidth = 4;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.Color.Blue;
			this.vmethod_0().RowsDefaultCellStyle = dataGridViewCellStyle;
			this.vmethod_0().RowTemplate.DefaultCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_0().RowTemplate.DefaultCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_0().RowTemplate.Height = 15;
			this.vmethod_0().RowTemplate.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.vmethod_0().SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.vmethod_0().Size = new global::System.Drawing.Size(523, 205);
			this.vmethod_0().TabIndex = 9;
			this.vmethod_2().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_2().DataPropertyName = "Sensor";
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_2().DefaultCellStyle = dataGridViewCellStyle2;
			this.vmethod_2().HeaderText = "传感器";
			this.vmethod_2().Name = "Sensor";
			this.vmethod_4().AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.vmethod_4().DataPropertyName = "SensorType";
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.vmethod_4().DefaultCellStyle = dataGridViewCellStyle3;
			this.vmethod_4().HeaderText = "传感器类型";
			this.vmethod_4().Name = "SensorType";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(523, 205);
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.Name = "MCMWindow";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "水雷对抗";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_0()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04002718 RID: 10008
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

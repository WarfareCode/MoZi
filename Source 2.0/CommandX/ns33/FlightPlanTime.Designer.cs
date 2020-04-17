namespace ns33
{
	// Token: 0x02000A2C RID: 2604
	
	public sealed partial class FlightPlanTime : global::ns33.CommandForm
	{
		// Token: 0x060051FA RID: 20986 RVA: 0x002178B8 File Offset: 0x00215AB8
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

		// Token: 0x060051FB RID: 20987 RVA: 0x002178FC File Offset: 0x00215AFC
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.DateTimePicker());
			this.vmethod_3(new global::System.Windows.Forms.DateTimePicker());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.Label());
			this.vmethod_9(new global::System.Windows.Forms.DateTimePicker());
			this.vmethod_11(new global::System.Windows.Forms.Label());
			base.SuspendLayout();
			this.vmethod_0().Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.vmethod_0().Location = new global::System.Drawing.Point(198, 43);
			this.vmethod_0().Name = "DateTimePicker1";
			this.vmethod_0().Size = new global::System.Drawing.Size(115, 20);
			this.vmethod_0().TabIndex = 2;
			this.vmethod_2().CustomFormat = "HH:mm:ss";
			this.vmethod_2().Format = global::System.Windows.Forms.DateTimePickerFormat.Time;
			this.vmethod_2().Location = new global::System.Drawing.Point(198, 67);
			this.vmethod_2().Name = "DateTimePicker2";
			this.vmethod_2().ShowUpDown = true;
			this.vmethod_2().Size = new global::System.Drawing.Size(115, 20);
			this.vmethod_2().TabIndex = 3;
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_4().Location = new global::System.Drawing.Point(13, 13);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new global::System.Drawing.Size(45, 13);
			this.vmethod_4().TabIndex = 10;
			this.vmethod_4().Text = "Label2";
			this.vmethod_6().AutoSize = true;
			this.vmethod_6().Location = new global::System.Drawing.Point(13, 43);
			this.vmethod_6().Name = "Label1";
			this.vmethod_6().Size = new global::System.Drawing.Size(160, 13);
			this.vmethod_6().TabIndex = 12;
			this.vmethod_6().Text = "开始日期和时间(Z):";
			this.vmethod_8().CustomFormat = "HH:mm:ss";
			this.vmethod_8().Format = global::System.Windows.Forms.DateTimePickerFormat.Time;
			this.vmethod_8().Location = new global::System.Drawing.Point(198, 93);
			this.vmethod_8().Name = "DateTimePicker3";
			this.vmethod_8().ShowUpDown = true;
			this.vmethod_8().Size = new global::System.Drawing.Size(115, 20);
			this.vmethod_8().TabIndex = 13;
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(13, 97);
			this.vmethod_10().Name = "Label3";
			this.vmethod_10().Size = new global::System.Drawing.Size(54, 13);
			this.vmethod_10().TabIndex = 14;
			this.vmethod_10().Text = "持续时间:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(541, 127);
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FlightPlanTime";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "航路点时间";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002682 RID: 9858
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

namespace ns34
{
	// Token: 0x02000A4C RID: 2636
	
	public sealed partial class Form_SetFuelAndAirborneTime : global::ns33.CommandForm
	{
		// Token: 0x060053CF RID: 21455 RVA: 0x00225D50 File Offset: 0x00223F50
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

		// Token: 0x060053D0 RID: 21456 RVA: 0x00225D94 File Offset: 0x00223F94
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.TextBox());
			this.vmethod_5(new global::System.Windows.Forms.MaskedTextBox());
			this.vmethod_7(new global::System.Windows.Forms.Label());
			this.vmethod_9(new global::System.Windows.Forms.CheckBox());
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(9, 36);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new global::System.Drawing.Size(150, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "剩余燃油(单位):";
			this.vmethod_2().Location = new global::System.Drawing.Point(152, 33);
			this.vmethod_2().Name = "TB_RemainingFuel";
			this.vmethod_2().Size = new global::System.Drawing.Size(64, 20);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().Location = new global::System.Drawing.Point(152, 11);
			this.vmethod_4().Mask = "00:00:00";
			this.vmethod_4().Name = "TB_AirborneTime";
			this.vmethod_4().Size = new global::System.Drawing.Size(64, 20);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_6().Location = new global::System.Drawing.Point(10, 14);
			this.vmethod_6().Name = "Label2";
			this.vmethod_6().Size = new global::System.Drawing.Size(140, 13);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_6().Text = "留空时间(时 : 分 : 秒):";
			this.vmethod_8().AutoSize = true;
			this.vmethod_8().Location = new global::System.Drawing.Point(223, 14);
			this.vmethod_8().Name = "CheckBox1";
			this.vmethod_8().Size = new global::System.Drawing.Size(256, 17);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_8().Text = "自动调整燃油(最优高度 + 10%)";
			this.vmethod_8().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(509, 106);
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Form_SetFuelAndAirborneTime";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "设置燃油与留空时间：";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400276A RID: 10090
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

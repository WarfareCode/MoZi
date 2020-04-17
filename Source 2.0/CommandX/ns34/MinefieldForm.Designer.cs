namespace ns34
{
	// Token: 0x02000A4A RID: 2634
	
	public sealed partial class MinefieldForm : global::ns33.CommandForm
	{
		// Token: 0x060053B3 RID: 21427 RVA: 0x00224B50 File Offset: 0x00222D50
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

		// Token: 0x060053B4 RID: 21428 RVA: 0x00224B94 File Offset: 0x00222D94
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.ComboBox());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.NumericUpDown());
			this.vmethod_9(new global::System.Windows.Forms.Button());
			this.vmethod_11(new global::System.Windows.Forms.ProgressBar());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_6()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(13, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new global::System.Drawing.Size(34, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "类型:";
			this.vmethod_2().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_2().FormattingEnabled = true;
			this.vmethod_2().Location = new global::System.Drawing.Point(53, 10);
			this.vmethod_2().Name = "CB_Weapon";
			this.vmethod_2().Size = new global::System.Drawing.Size(421, 21);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().Location = new global::System.Drawing.Point(13, 39);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new global::System.Drawing.Size(60, 13);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "数量:";
			this.vmethod_6().Location = new global::System.Drawing.Point(82, 37);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.vmethod_6();
			int[] array = new int[4];
			array[0] = 1316134911;
			array[1] = 2328;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.vmethod_6();
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.vmethod_6().Name = "NumericUpDown1";
			this.vmethod_6().Size = new global::System.Drawing.Size(124, 20);
			this.vmethod_6().TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.vmethod_6();
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.vmethod_8().Location = new global::System.Drawing.Point(270, 37);
			this.vmethod_8().Name = "Button1";
			this.vmethod_8().Size = new global::System.Drawing.Size(75, 20);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_8().Text = "添加";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(16, 63);
			this.vmethod_10().Name = "ProgressBar1";
			this.vmethod_10().Size = new global::System.Drawing.Size(458, 21);
			this.vmethod_10().Style = global::System.Windows.Forms.ProgressBarStyle.Marquee;
			this.vmethod_10().TabIndex = 5;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(486, 95);
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MinefieldForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "在指定区域布雷";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_6()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002756 RID: 10070
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

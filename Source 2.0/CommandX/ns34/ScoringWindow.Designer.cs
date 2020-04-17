namespace ns34
{
	// Token: 0x020009FD RID: 2557
	
	public sealed partial class ScoringWindow : global::ns33.CommandForm
	{
		// Token: 0x06004D1F RID: 19743 RVA: 0x001EB584 File Offset: 0x001E9784
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

		// Token: 0x06004D20 RID: 19744 RVA: 0x001EB5C8 File Offset: 0x001E97C8
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.NumericUpDown());
			this.vmethod_9(new global::System.Windows.Forms.NumericUpDown());
			this.vmethod_11(new global::System.Windows.Forms.Label());
			this.vmethod_13(new global::System.Windows.Forms.Label());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_17(new global::System.Windows.Forms.Label());
			this.vmethod_19(new global::System.Windows.Forms.Label());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_6()).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_8()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_0().Location = new global::System.Drawing.Point(13, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new global::System.Drawing.Size(217, 20);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "胜败阈值";
			this.vmethod_2().Location = new global::System.Drawing.Point(14, 56);
			this.vmethod_2().Name = "Label2";
			this.vmethod_2().Size = new global::System.Drawing.Size(48, 13);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_2().Text = "完败:";
			this.vmethod_4().Location = new global::System.Drawing.Point(14, 228);
			this.vmethod_4().Name = "Label8";
			this.vmethod_4().Size = new global::System.Drawing.Size(48, 13);
			this.vmethod_4().TabIndex = 11;
			this.vmethod_4().Text = "完胜:";
			this.vmethod_6().Location = new global::System.Drawing.Point(68, 54);
			this.vmethod_6().Maximum = new decimal(new int[]
			{
				-159383553,
				46653770,
				5421,
				0
			});
			this.vmethod_6().Minimum = new decimal(new int[]
			{
				-1593835521,
				466537709,
				54210,
				-2147483648
			});
			this.vmethod_6().Name = "NUD_Disaster";
			this.vmethod_6().Size = new global::System.Drawing.Size(162, 20);
			this.vmethod_6().TabIndex = 17;
			this.vmethod_8().Location = new global::System.Drawing.Point(68, 226);
			this.vmethod_8().Maximum = new decimal(new int[]
			{
				-159383553,
				46653770,
				5421,
				0
			});
			this.vmethod_8().Minimum = new decimal(new int[]
			{
				-1593835521,
				466537709,
				54210,
				-2147483648
			});
			this.vmethod_8().Name = "NUD_Triumph";
			this.vmethod_8().Size = new global::System.Drawing.Size(162, 20);
			this.vmethod_8().TabIndex = 23;
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(14, 199);
			this.vmethod_10().Name = "Label_MajorVictory";
			this.vmethod_10().Size = new global::System.Drawing.Size(71, 13);
			this.vmethod_10().TabIndex = 10;
			this.vmethod_10().Text = "大胜:";
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Location = new global::System.Drawing.Point(14, 171);
			this.vmethod_12().Name = "Label_MinorVictory";
			this.vmethod_12().Size = new global::System.Drawing.Size(71, 13);
			this.vmethod_12().TabIndex = 9;
			this.vmethod_12().Text = "小胜:";
			this.vmethod_14().AutoSize = true;
			this.vmethod_14().Location = new global::System.Drawing.Point(14, 142);
			this.vmethod_14().Name = "Label_Average";
			this.vmethod_14().Size = new global::System.Drawing.Size(50, 13);
			this.vmethod_14().TabIndex = 7;
			this.vmethod_14().Text = "Average:";
			this.vmethod_16().AutoSize = true;
			this.vmethod_16().Location = new global::System.Drawing.Point(14, 114);
			this.vmethod_16().Name = "Label_MinorDefeat";
			this.vmethod_16().Size = new global::System.Drawing.Size(71, 13);
			this.vmethod_16().TabIndex = 5;
			this.vmethod_16().Text = "小败:";
			this.vmethod_18().AutoSize = true;
			this.vmethod_18().Location = new global::System.Drawing.Point(14, 87);
			this.vmethod_18().Name = "Label_MajorDefeat";
			this.vmethod_18().Size = new global::System.Drawing.Size(71, 13);
			this.vmethod_18().TabIndex = 3;
			this.vmethod_18().Text = "大败:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(243, 260);
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ScoringWindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "评分";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_6()).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_8()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400247C RID: 9340
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

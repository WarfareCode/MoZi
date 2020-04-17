namespace ns33
{
	// Token: 0x02000986 RID: 2438
	
	public sealed partial class Hotkeys : global::ns33.CommandForm
	{
		// Token: 0x06003D48 RID: 15688 RVA: 0x0013BFD4 File Offset: 0x0013A1D4
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

		// Token: 0x06003D49 RID: 15689 RVA: 0x0013C018 File Offset: 0x0013A218
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns33.Hotkeys));
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.Label());
			this.vmethod_9(new global::System.Windows.Forms.Label());
			this.vmethod_11(new global::System.Windows.Forms.Label());
			this.vmethod_13(new global::System.Windows.Forms.Label());
			this.vmethod_15(new global::System.Windows.Forms.RichTextBox());
			this.vmethod_17(new global::System.Windows.Forms.RichTextBox());
			this.vmethod_19(new global::System.Windows.Forms.RichTextBox());
			this.vmethod_21(new global::System.Windows.Forms.RichTextBox());
			this.vmethod_23(new global::System.Windows.Forms.RichTextBox());
			this.vmethod_25(new global::System.Windows.Forms.RichTextBox());
			this.vmethod_27(new global::System.Windows.Forms.RichTextBox());
			base.SuspendLayout();
			this.vmethod_0().AutoSize = true;
			this.vmethod_0().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_0().Location = new global::System.Drawing.Point(15, 17);
			this.vmethod_0().Name = "Label3";
			this.vmethod_0().Size = new global::System.Drawing.Size(50, 18);
			this.vmethod_0().TabIndex = 9;
			this.vmethod_0().Text = "基础操作";
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_2().Location = new global::System.Drawing.Point(398, 616);
			this.vmethod_2().Name = "Label5";
			this.vmethod_2().Size = new global::System.Drawing.Size(76, 18);
			this.vmethod_2().TabIndex = 12;
			this.vmethod_2().Text = "探测目标";
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_4().Location = new global::System.Drawing.Point(398, 313);
			this.vmethod_4().Name = "Label4";
			this.vmethod_4().Size = new global::System.Drawing.Size(86, 18);
			this.vmethod_4().TabIndex = 11;
			this.vmethod_4().Text = "本方单元";
			this.vmethod_6().AutoSize = true;
			this.vmethod_6().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_6().Location = new global::System.Drawing.Point(15, 534);
			this.vmethod_6().Name = "Label6";
			this.vmethod_6().Size = new global::System.Drawing.Size(125, 18);
			this.vmethod_6().TabIndex = 10;
			this.vmethod_6().Text = "想定编辑";
			this.vmethod_8().AutoSize = true;
			this.vmethod_8().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_8().Location = new global::System.Drawing.Point(15, 148);
			this.vmethod_8().Name = "Label2";
			this.vmethod_8().Size = new global::System.Drawing.Size(104, 18);
			this.vmethod_8().TabIndex = 15;
			this.vmethod_8().Text = "战术地图";
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_10().Location = new global::System.Drawing.Point(840, 17);
			this.vmethod_10().Name = "Label7";
			this.vmethod_10().Size = new global::System.Drawing.Size(185, 18);
			this.vmethod_10().TabIndex = 14;
			this.vmethod_10().Text = "技巧与提示";
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_12().Location = new global::System.Drawing.Point(398, 17);
			this.vmethod_12().Name = "Label1";
			this.vmethod_12().Size = new global::System.Drawing.Size(115, 18);
			this.vmethod_12().TabIndex = 13;
			this.vmethod_12().Text = "功能键";
			this.vmethod_14().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_14().BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.vmethod_14().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.vmethod_14().Location = new global::System.Drawing.Point(840, 38);
			this.vmethod_14().Name = "RichTextBox7";
			this.vmethod_14().Size = new global::System.Drawing.Size(405, 246);
			this.vmethod_14().TabIndex = 4;
			this.vmethod_14().Text = componentResourceManager.GetString("RichTextBox7.Text");
			this.vmethod_16().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_16().BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.vmethod_16().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.vmethod_16().Location = new global::System.Drawing.Point(18, 38);
			this.vmethod_16().Name = "RichTextBox3";
			this.vmethod_16().Size = new global::System.Drawing.Size(380, 106);
			this.vmethod_16().TabIndex = 5;
			this.vmethod_16().Text = componentResourceManager.GetString("RichTextBox3.Text");
			this.vmethod_18().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_18().BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.vmethod_18().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.vmethod_18().Location = new global::System.Drawing.Point(400, 637);
			this.vmethod_18().Name = "RichTextBox5";
			this.vmethod_18().Size = new global::System.Drawing.Size(435, 105);
			this.vmethod_18().TabIndex = 2;
			this.vmethod_18().Text = "P, PgDn , Num 3\t放弃目标(s)\nH\t\t\t标定为敌对方\nCtrl + H\t\t标定为非友方\nN\t\t\t标定为中立方\nF\t\t\t标定为友方\nR\t\t\t重命名";
			this.vmethod_20().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_20().BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.vmethod_20().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.vmethod_20().Location = new global::System.Drawing.Point(18, 555);
			this.vmethod_20().Name = "RichTextBox6";
			this.vmethod_20().Size = new global::System.Drawing.Size(380, 187);
			this.vmethod_20().TabIndex = 3;
			this.vmethod_20().Text = componentResourceManager.GetString("RichTextBox6.Text");
			this.vmethod_22().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_22().BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.vmethod_22().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.vmethod_22().Location = new global::System.Drawing.Point(400, 334);
			this.vmethod_22().Name = "RichTextBox4";
			this.vmethod_22().Size = new global::System.Drawing.Size(435, 286);
			this.vmethod_22().TabIndex = 8;
			this.vmethod_22().Text = componentResourceManager.GetString("RichTextBox4.Text");
			this.vmethod_24().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_24().BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.vmethod_24().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.vmethod_24().Location = new global::System.Drawing.Point(18, 170);
			this.vmethod_24().Name = "RichTextBox2";
			this.vmethod_24().Size = new global::System.Drawing.Size(380, 362);
			this.vmethod_24().TabIndex = 7;
			this.vmethod_24().Text = componentResourceManager.GetString("RichTextBox2.Text");
			this.vmethod_26().BackColor = global::System.Drawing.SystemColors.Control;
			this.vmethod_26().BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.vmethod_26().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.vmethod_26().Location = new global::System.Drawing.Point(400, 38);
			this.vmethod_26().Name = "RichTextBox1";
			this.vmethod_26().Size = new global::System.Drawing.Size(435, 277);
			this.vmethod_26().TabIndex = 6;
			this.vmethod_26().Text = componentResourceManager.GetString("RichTextBox1.Text");
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1258, 741);
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_26());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Hotkeys";
			base.Padding = new global::System.Windows.Forms.Padding(9);
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "热键";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001BEB RID: 7147
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

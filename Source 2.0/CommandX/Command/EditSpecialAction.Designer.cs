namespace Command
{
	// Token: 0x02000983 RID: 2435
	public sealed partial class EditSpecialAction : global::ns33.CommandForm
	{
		// Token: 0x06003CFD RID: 15613 RVA: 0x0013A184 File Offset: 0x00138384
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

		// Token: 0x06003CFE RID: 15614 RVA: 0x0013A1C8 File Offset: 0x001383C8
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.TextBox());
			this.vmethod_3(new global::System.Windows.Forms.Label());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.Button());
			this.vmethod_9(new global::System.Windows.Forms.Button());
			this.vmethod_11(new global::System.Windows.Forms.TextBox());
			this.vmethod_13(new global::System.Windows.Forms.Label());
			this.vmethod_15(new global::System.Windows.Forms.NumericUpDown());
			this.vmethod_17(new global::System.Windows.Forms.Label());
			this.vmethod_19(new global::System.Windows.Forms.Button());
			this.vmethod_21(new global::System.Windows.Forms.ComboBox());
			this.vmethod_23(new global::System.Windows.Forms.Label());
			this.vmethod_25(new global::System.Windows.Forms.TextBox());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_14()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(90, 12);
			this.vmethod_0().Name = "TB_Name";
			this.vmethod_0().Size = new global::System.Drawing.Size(632, 20);
			this.vmethod_0().TabIndex = 6;
			this.vmethod_2().AutoSize = true;
			this.vmethod_2().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_2().Location = new global::System.Drawing.Point(4, 16);
			this.vmethod_2().Name = "Label2";
			this.vmethod_2().Size = new global::System.Drawing.Size(43, 13);
			this.vmethod_2().TabIndex = 5;
			this.vmethod_2().Text = "名称:";
			this.vmethod_4().AutoSize = true;
			this.vmethod_4().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_4().Location = new global::System.Drawing.Point(4, 48);
			this.vmethod_4().Name = "Label3";
			this.vmethod_4().Size = new global::System.Drawing.Size(75, 13);
			this.vmethod_4().TabIndex = 21;
			this.vmethod_4().Text = "描述:";
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_6().Location = new global::System.Drawing.Point(650, 614);
			this.vmethod_6().Name = "Button2";
			this.vmethod_6().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_6().TabIndex = 24;
			this.vmethod_6().Text = "取消";
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_8().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.vmethod_8().Location = new global::System.Drawing.Point(4, 614);
			this.vmethod_8().Name = "Button1";
			this.vmethod_8().Size = new global::System.Drawing.Size(75, 23);
			this.vmethod_8().TabIndex = 23;
			this.vmethod_8().Text = "确认";
			this.vmethod_8().UseVisualStyleBackColor = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(7, 64);
			this.vmethod_10().Multiline = true;
			this.vmethod_10().Name = "TB_Description";
			this.vmethod_10().ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.vmethod_10().Size = new global::System.Drawing.Size(715, 96);
			this.vmethod_10().TabIndex = 25;
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_12().Location = new global::System.Drawing.Point(4, 174);
			this.vmethod_12().Name = "Label1";
			this.vmethod_12().Size = new global::System.Drawing.Size(69, 13);
			this.vmethod_12().TabIndex = 21;
			this.vmethod_12().Text = "Lua脚本:";
			this.vmethod_14().Location = new global::System.Drawing.Point(658, 195);
			this.vmethod_14().Name = "NUD_LuaScript";
			this.vmethod_14().Size = new global::System.Drawing.Size(45, 20);
			this.vmethod_14().TabIndex = 31;
			this.vmethod_16().Location = new global::System.Drawing.Point(606, 197);
			this.vmethod_16().Name = "Label13";
			this.vmethod_16().Size = new global::System.Drawing.Size(54, 13);
			this.vmethod_16().TabIndex = 30;
			this.vmethod_16().Text = "文字大小:";
			this.vmethod_18().Location = new global::System.Drawing.Point(530, 193);
			this.vmethod_18().Name = "Button_AddLuaScript";
			this.vmethod_18().Size = new global::System.Drawing.Size(75, 21);
			this.vmethod_18().TabIndex = 29;
			this.vmethod_18().Text = "添加";
			this.vmethod_18().UseVisualStyleBackColor = true;
			this.vmethod_20().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_20().FormattingEnabled = true;
			this.vmethod_20().Location = new global::System.Drawing.Point(107, 193);
			this.vmethod_20().Name = "CB_LuaTemplate";
			this.vmethod_20().Size = new global::System.Drawing.Size(417, 21);
			this.vmethod_20().TabIndex = 28;
			this.vmethod_22().Location = new global::System.Drawing.Point(4, 196);
			this.vmethod_22().Name = "Label12";
			this.vmethod_22().Size = new global::System.Drawing.Size(100, 13);
			this.vmethod_22().TabIndex = 27;
			this.vmethod_22().Text = "添加脚本模板:";
			this.vmethod_24().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_24().Location = new global::System.Drawing.Point(4, 221);
			this.vmethod_24().MaxLength = 999999999;
			this.vmethod_24().Multiline = true;
			this.vmethod_24().Name = "TB_Script";
			this.vmethod_24().ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.vmethod_24().Size = new global::System.Drawing.Size(718, 387);
			this.vmethod_24().TabIndex = 26;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(726, 639);
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_20());
			base.Controls.Add(this.vmethod_22());
			base.Controls.Add(this.vmethod_24());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_2());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditSpecialAction";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "编辑特殊事件";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_14()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001BC7 RID: 7111
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

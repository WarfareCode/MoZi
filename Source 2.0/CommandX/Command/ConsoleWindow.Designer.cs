namespace Command
{
	// Token: 0x02000CF5 RID: 3317

	public sealed partial class ConsoleWindow : global::System.Windows.Forms.Form
	{
		// Token: 0x060072F7 RID: 29431 RVA: 0x00418A1C File Offset: 0x00416C1C
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

		// Token: 0x060072F8 RID: 29432 RVA: 0x00418A60 File Offset: 0x00416C60
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.TextBox());
			this.vmethod_3(new global::System.Windows.Forms.TextBox());
			this.SetButton_RunScript(new global::System.Windows.Forms.Button());
			this.vmethod_7(new global::System.Windows.Forms.NumericUpDown());
			this.vmethod_9(new global::System.Windows.Forms.Label());
			this.vmethod_11(new global::System.Windows.Forms.ComboBox());
			this.vmethod_13(new global::System.Windows.Forms.Button());
			this.vmethod_15(new global::System.Windows.Forms.ComboBox());
			this.vmethod_17(new global::System.Windows.Forms.Button());
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_6()).BeginInit();
			base.SuspendLayout();
			this.vmethod_0().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_0().BackColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.vmethod_0().Font = new global::System.Drawing.Font("Lucida Console", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 4);
			this.vmethod_0().Multiline = true;
			this.vmethod_0().Name = "TextBox1";
			this.vmethod_0().ReadOnly = true;
			this.vmethod_0().ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.vmethod_0().Size = new global::System.Drawing.Size(1077, 256);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_2().Font = new global::System.Drawing.Font("Lucida Console", 8.25f);
			this.vmethod_2().Location = new global::System.Drawing.Point(0, 291);
			this.vmethod_2().Multiline = true;
			this.vmethod_2().Name = "TextBox2";
			this.vmethod_2().ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.vmethod_2().Size = new global::System.Drawing.Size(944, 110);
			this.vmethod_2().TabIndex = 1;
			this.GetButton_RunScript().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.GetButton_RunScript().Location = new global::System.Drawing.Point(951, 345);
			this.GetButton_RunScript().Name = "Button1";
			this.GetButton_RunScript().Size = new global::System.Drawing.Size(126, 21);
			this.GetButton_RunScript().TabIndex = 2;
			this.GetButton_RunScript().Text = "执行脚本";
			this.GetButton_RunScript().UseVisualStyleBackColor = true;
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_6().Location = new global::System.Drawing.Point(1022, 376);
			this.vmethod_6().Name = "NumericUpDown1";
			this.vmethod_6().Size = new global::System.Drawing.Size(55, 20);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_8().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_8().Location = new global::System.Drawing.Point(962, 378);
			this.vmethod_8().Name = "Label1";
			this.vmethod_8().Size = new global::System.Drawing.Size(80, 13);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_8().Text = "文字大小:";
			this.vmethod_10().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_10().DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vmethod_10().Font = new global::System.Drawing.Font("Lucida Console", 8.25f);
			this.vmethod_10().FormattingEnabled = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(0, 266);
			this.vmethod_10().Name = "ComboBox1";
			this.vmethod_10().Size = new global::System.Drawing.Size(944, 19);
			this.vmethod_10().TabIndex = 5;
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_12().Location = new global::System.Drawing.Point(951, 266);
			this.vmethod_12().Name = "Button2";
			this.vmethod_12().Size = new global::System.Drawing.Size(126, 21);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_12().Text = "插入脚本";
			this.vmethod_12().UseVisualStyleBackColor = true;
			this.vmethod_14().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_14().Font = new global::System.Drawing.Font("Lucida Console", 8.25f);
			this.vmethod_14().FormattingEnabled = true;
			this.vmethod_14().Location = new global::System.Drawing.Point(951, 293);
			this.vmethod_14().Name = "ComboBox2";
			this.vmethod_14().Size = new global::System.Drawing.Size(126, 19);
			this.vmethod_14().TabIndex = 7;
			this.vmethod_16().Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_16().Location = new global::System.Drawing.Point(951, 318);
			this.vmethod_16().Name = "Button3";
			this.vmethod_16().Size = new global::System.Drawing.Size(126, 21);
			this.vmethod_16().TabIndex = 8;
			this.vmethod_16().Text = "读入Lua脚本";
			this.vmethod_16().UseVisualStyleBackColor = true;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Inherit;
			base.ClientSize = new global::System.Drawing.Size(1081, 405);
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.GetButton_RunScript());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.Name = "ConsoleWindow";
			this.Text = "Lua脚本编辑";
			((global::System.ComponentModel.ISupportInitialize)this.vmethod_6()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400415F RID: 16735
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

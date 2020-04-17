namespace ns34
{
	// Token: 0x02000A08 RID: 2568
	
	public sealed partial class Migration : global::ns33.CommandForm
	{
		// Token: 0x06004E32 RID: 20018 RVA: 0x001F6E30 File Offset: 0x001F5030
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

		// Token: 0x06004E33 RID: 20019 RVA: 0x001F6E74 File Offset: 0x001F5074
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns34.Migration));
			this.vmethod_1(new global::System.Windows.Forms.GroupBox());
			this.vmethod_3(new global::System.Windows.Forms.Button());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.TextBox());
			this.vmethod_9(new global::System.Windows.Forms.GroupBox());
			this.vmethod_11(new global::System.Windows.Forms.CheckBox());
			this.vmethod_13(new global::System.Windows.Forms.CheckBox());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_17(new global::System.Windows.Forms.Label());
			this.vmethod_19(new global::System.Windows.Forms.Label());
			this.vmethod_21(new global::System.Windows.Forms.Button());
			this.vmethod_0().SuspendLayout();
			this.vmethod_8().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Controls.Add(this.vmethod_4());
			this.vmethod_0().Location = new global::System.Drawing.Point(12, 241);
			this.vmethod_0().Name = "MigrationAllScenarios";
			this.vmethod_0().Size = new global::System.Drawing.Size(532, 84);
			this.vmethod_0().TabIndex = 7;
			this.vmethod_0().TabStop = false;
			this.vmethod_0().Text = "重建多个想定";
			this.vmethod_2().Location = new global::System.Drawing.Point(9, 44);
			this.vmethod_2().Name = "Button2";
			this.vmethod_2().Size = new global::System.Drawing.Size(202, 23);
			this.vmethod_2().TabIndex = 4;
			this.vmethod_2().Text = "深度重建列表中的想定";
			this.vmethod_2().UseVisualStyleBackColor = true;
			this.vmethod_4().Location = new global::System.Drawing.Point(6, 16);
			this.vmethod_4().Name = "Label3";
			this.vmethod_4().Size = new global::System.Drawing.Size(428, 23);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "执行深度重建并将INI文件应用到“想定列表”中列出的所有想定。";
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_6().Location = new global::System.Drawing.Point(0, 331);
			this.vmethod_6().Multiline = true;
			this.vmethod_6().Name = "TextBox1";
			this.vmethod_6().Size = new global::System.Drawing.Size(556, 316);
			this.vmethod_6().TabIndex = 6;
			this.vmethod_8().Controls.Add(this.vmethod_10());
			this.vmethod_8().Controls.Add(this.vmethod_12());
			this.vmethod_8().Controls.Add(this.vmethod_14());
			this.vmethod_8().Controls.Add(this.vmethod_16());
			this.vmethod_8().Controls.Add(this.vmethod_18());
			this.vmethod_8().Controls.Add(this.vmethod_20());
			this.vmethod_8().Location = new global::System.Drawing.Point(12, 11);
			this.vmethod_8().Name = "MigrationSingleScenario";
			this.vmethod_8().Size = new global::System.Drawing.Size(532, 224);
			this.vmethod_8().TabIndex = 8;
			this.vmethod_8().TabStop = false;
			this.vmethod_8().Text = "重建当前想定";
			this.vmethod_10().AutoSize = true;
			this.vmethod_10().Location = new global::System.Drawing.Point(335, 189);
			this.vmethod_10().Name = "CB_ApplyINI";
			this.vmethod_10().Size = new global::System.Drawing.Size(88, 17);
			this.vmethod_10().TabIndex = 4;
			this.vmethod_10().Text = "应用INI文件";
			this.vmethod_10().UseVisualStyleBackColor = true;
			this.vmethod_12().AutoSize = true;
			this.vmethod_12().Location = new global::System.Drawing.Point(217, 189);
			this.vmethod_12().Name = "CB_DeepRebuild";
			this.vmethod_12().Size = new global::System.Drawing.Size(121, 17);
			this.vmethod_12().TabIndex = 3;
			this.vmethod_12().Text = "强制深度重建";
			this.vmethod_12().UseVisualStyleBackColor = true;
			this.vmethod_14().Location = new global::System.Drawing.Point(6, 16);
			this.vmethod_14().Name = "Label1";
			this.vmethod_14().Size = new global::System.Drawing.Size(520, 55);
			this.vmethod_14().TabIndex = 1;
			this.vmethod_14().Text = componentResourceManager.GetString("Label1.Text");
			this.vmethod_16().Location = new global::System.Drawing.Point(6, 130);
			this.vmethod_16().Name = "Label5";
			this.vmethod_16().Size = new global::System.Drawing.Size(520, 49);
			this.vmethod_16().TabIndex = 2;
			this.vmethod_16().Text = componentResourceManager.GetString("Label5.Text");
			this.vmethod_18().Location = new global::System.Drawing.Point(6, 79);
			this.vmethod_18().Name = "Label2";
			this.vmethod_18().Size = new global::System.Drawing.Size(520, 47);
			this.vmethod_18().TabIndex = 2;
			this.vmethod_18().Text = componentResourceManager.GetString("Label2.Text");
			this.vmethod_20().Location = new global::System.Drawing.Point(9, 185);
			this.vmethod_20().Name = "Button1";
			this.vmethod_20().Size = new global::System.Drawing.Size(202, 23);
			this.vmethod_20().TabIndex = 3;
			this.vmethod_20().Text = "我明白—深度重建当前想定";
			this.vmethod_20().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(556, 644);
			base.Controls.Add(this.vmethod_0());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_8());
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Migration";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "想定迁移";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_8().ResumeLayout(false);
			this.vmethod_8().PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040024F8 RID: 9464
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

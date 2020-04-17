namespace Command
{
	// Token: 0x020009A1 RID: 2465
	
	public sealed partial class SaveGroup : global::ns33.CommandForm
	{
		// Token: 0x06004003 RID: 16387 RVA: 0x00159490 File Offset: 0x00157690
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

		// Token: 0x06004004 RID: 16388 RVA: 0x001594D4 File Offset: 0x001576D4
		private void InitializeComponent()
		{
			this.vmethod_1(new global::System.Windows.Forms.Label());
			this.vmethod_3(new global::System.Windows.Forms.TextBox());
			this.vmethod_5(new global::System.Windows.Forms.Label());
			this.vmethod_7(new global::System.Windows.Forms.TextBox());
			this.vmethod_9(new global::System.Windows.Forms.Label());
			this.vmethod_11(new global::System.Windows.Forms.TextBox());
			this.vmethod_13(new global::System.Windows.Forms.TextBox());
			this.vmethod_15(new global::System.Windows.Forms.Label());
			this.vmethod_17(new global::System.Windows.Forms.Button());
			this.vmethod_19(new global::System.Windows.Forms.Button());
			this.vmethod_21(new global::System.Windows.Forms.SaveFileDialog());
			base.SuspendLayout();
			this.vmethod_0().Location = new global::System.Drawing.Point(5, 13);
			this.vmethod_0().Name = "Label1";
			this.vmethod_0().Size = new global::System.Drawing.Size(38, 13);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().Text = "名称:";
			this.vmethod_2().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_2().Location = new global::System.Drawing.Point(78, 10);
			this.vmethod_2().Name = "TB_Name";
			this.vmethod_2().Size = new global::System.Drawing.Size(439, 20);
			this.vmethod_2().TabIndex = 1;
			this.vmethod_4().Location = new global::System.Drawing.Point(5, 39);
			this.vmethod_4().Name = "Label2";
			this.vmethod_4().Size = new global::System.Drawing.Size(66, 13);
			this.vmethod_4().TabIndex = 2;
			this.vmethod_4().Text = "有效期开始于:";
			this.vmethod_6().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_6().Location = new global::System.Drawing.Point(78, 36);
			this.vmethod_6().Name = "TB_ValidFrom";
			this.vmethod_6().Size = new global::System.Drawing.Size(439, 20);
			this.vmethod_6().TabIndex = 3;
			this.vmethod_8().Location = new global::System.Drawing.Point(5, 65);
			this.vmethod_8().Name = "Label3";
			this.vmethod_8().Size = new global::System.Drawing.Size(66, 13);
			this.vmethod_8().TabIndex = 4;
			this.vmethod_8().Text = "有效期岂止于:";
			this.vmethod_10().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_10().Location = new global::System.Drawing.Point(78, 62);
			this.vmethod_10().Name = "TB_ValidUntil";
			this.vmethod_10().Size = new global::System.Drawing.Size(438, 20);
			this.vmethod_10().TabIndex = 5;
			this.vmethod_12().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_12().Location = new global::System.Drawing.Point(78, 89);
			this.vmethod_12().Multiline = true;
			this.vmethod_12().Name = "TB_Notes";
			this.vmethod_12().Size = new global::System.Drawing.Size(438, 113);
			this.vmethod_12().TabIndex = 6;
			this.vmethod_14().Location = new global::System.Drawing.Point(5, 89);
			this.vmethod_14().Name = "Label4";
			this.vmethod_14().Size = new global::System.Drawing.Size(38, 13);
			this.vmethod_14().TabIndex = 7;
			this.vmethod_14().Text = "说明:";
			this.vmethod_16().DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.vmethod_16().Location = new global::System.Drawing.Point(78, 208);
			this.vmethod_16().Name = "Button1";
			this.vmethod_16().Size = new global::System.Drawing.Size(70, 37);
			this.vmethod_16().TabIndex = 8;
			this.vmethod_16().Text = "保存";
			this.vmethod_16().UseVisualStyleBackColor = true;
			this.vmethod_18().Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.vmethod_18().DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.vmethod_18().Location = new global::System.Drawing.Point(426, 208);
			this.vmethod_18().Name = "Button2";
			this.vmethod_18().Size = new global::System.Drawing.Size(91, 37);
			this.vmethod_18().TabIndex = 9;
			this.vmethod_18().Text = "取消";
			this.vmethod_18().UseVisualStyleBackColor = true;
			this.vmethod_20().DefaultExt = "inst";
			this.vmethod_20().Filter = "Import/Export file (*.inst)|*.inst|All Files (*.*)|*.*";
			this.vmethod_20().InitialDirectory = "Installations";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.vmethod_18();
			base.ClientSize = new global::System.Drawing.Size(529, 257);
			base.Controls.Add(this.vmethod_18());
			base.Controls.Add(this.vmethod_16());
			base.Controls.Add(this.vmethod_14());
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_10());
			base.Controls.Add(this.vmethod_8());
			base.Controls.Add(this.vmethod_6());
			base.Controls.Add(this.vmethod_4());
			base.Controls.Add(this.vmethod_2());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SaveGroup";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			//this.Text = "Export units/groups to file";
            this.Text = "导出单元/编组到文件";
            base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001D6A RID: 7530
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

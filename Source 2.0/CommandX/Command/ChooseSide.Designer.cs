using System;

namespace Command
{
	// Token: 0x02000A01 RID: 2561

	public sealed partial class ChooseSide : global::ns33.CommandForm
	{
		// Token: 0x06004D7A RID: 19834 RVA: 0x001F15E8 File Offset: 0x001EF7E8
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool flag)
		{
			try
			{
				if (flag && this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(flag);
			}
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x001F162C File Offset: 0x001EF82C
		private void InitializeComponent()
		{
			this.label_0 = new global::System.Windows.Forms.Label();
			this.comboBox_0 = new global::System.Windows.Forms.ComboBox();this.comboBox_0.SelectionChangeCommitted += new EventHandler(this.method_4);
			this.label_1 = new global::System.Windows.Forms.Label();
			this.button_0 = new global::System.Windows.Forms.Button();this.button_0.Click += new EventHandler(this.method_1);
			this.button_1 = new global::System.Windows.Forms.Button();this.button_1.Click += new EventHandler(this.method_5);
			this.webBrowser_0 = new global::System.Windows.Forms.WebBrowser();
			base.SuspendLayout();
			this.label_0.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label_0.Location = new global::System.Drawing.Point(9, 13);
			this.label_0.Name = "Label1";
			this.label_0.Size = new global::System.Drawing.Size(98, 15);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "可选推演方:";
			this.comboBox_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.comboBox_0.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new global::System.Drawing.Point(117, 10);
			this.comboBox_0.Name = "ComboBox1";
			this.comboBox_0.Size = new global::System.Drawing.Size(556, 21);
			this.comboBox_0.TabIndex = 1;
			this.label_1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label_1.Location = new global::System.Drawing.Point(9, 45);
			this.label_1.Name = "Label2";
			this.label_1.Size = new global::System.Drawing.Size(152, 15);
			this.label_1.TabIndex = 2;
			this.label_1.Text = "任务简报:";
			this.button_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.button_0.Location = new global::System.Drawing.Point(12, 433);
			this.button_0.Name = "Button1";
			this.button_0.Size = new global::System.Drawing.Size(169, 27);
			this.button_0.TabIndex = 4;
			this.button_0.Text = "进入推演想定";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button_1.Location = new global::System.Drawing.Point(482, 433);
			this.button_1.Name = "Button2";
			this.button_1.Size = new global::System.Drawing.Size(191, 27);
			this.button_1.TabIndex = 5;
			this.button_1.Text = "取消 (返回主界面)";
			this.button_1.UseVisualStyleBackColor = true;
			this.webBrowser_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.webBrowser_0.Location = new global::System.Drawing.Point(12, 64);
			this.webBrowser_0.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser_0.Name = "WebBrowser1";
			this.webBrowser_0.Size = new global::System.Drawing.Size(661, 363);
			this.webBrowser_0.TabIndex = 16;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(685, 472);
			base.Controls.Add(this.webBrowser_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.label_0);
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ChooseSide";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "选择推演方并查看任务简报";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002498 RID: 9368
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

using System;
using System.Windows.Forms;

namespace Command
{
	// Token: 0x02000998 RID: 2456

	public sealed partial class DBViewer : global::ns33.CommandForm
	{
		// Token: 0x06003E7C RID: 15996 RVA: 0x00147914 File Offset: 0x00145B14
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

		// Token: 0x06003E7D RID: 15997 RVA: 0x00147958 File Offset: 0x00145B58
		private void InitializeComponent()
		{
			this.groupBox_0 = new global::System.Windows.Forms.GroupBox();
			this.comboBox_2 = new global::System.Windows.Forms.ComboBox();this.comboBox_2.SelectionChangeCommitted += new EventHandler(this.method_45);
			this.label_3 = new global::System.Windows.Forms.Label();
			this.comboBox_0 = new global::System.Windows.Forms.ComboBox();this.comboBox_0.SelectionChangeCommitted += new EventHandler(this.method_6);
			this.label_0 = new global::System.Windows.Forms.Label();
			this.label_1 = new global::System.Windows.Forms.Label();
			this.textBox_0 = new global::System.Windows.Forms.TextBox();this.textBox_0.TextChanged += new EventHandler(this.method_2);
			this.comboBox_1 = new global::System.Windows.Forms.ComboBox();this.comboBox_1.SelectionChangeCommitted += new EventHandler(this.method_5);
			this.listBox_0 = new global::System.Windows.Forms.ListBox();this.listBox_0.SelectedIndexChanged += new EventHandler(this.method_4);this.listBox_0.MouseWheel += new MouseEventHandler(this.method_42);this.listBox_0.MouseEnter += new EventHandler(this.method_43);this.listBox_0.MouseLeave += new EventHandler(this.method_44);
			this.label_2 = new global::System.Windows.Forms.Label();
			this.webBrowser_0 = new global::System.Windows.Forms.WebBrowser();this.webBrowser_0.PreviewKeyDown += new PreviewKeyDownEventHandler(this.method_46);
			this.groupBox_0.SuspendLayout();
			base.SuspendLayout();
			this.groupBox_0.Controls.Add(this.comboBox_2);
			this.groupBox_0.Controls.Add(this.label_3);
			this.groupBox_0.Controls.Add(this.comboBox_0);
			this.groupBox_0.Controls.Add(this.label_0);
			this.groupBox_0.Controls.Add(this.label_1);
			this.groupBox_0.Controls.Add(this.textBox_0);
			this.groupBox_0.Location = new global::System.Drawing.Point(4, 39);
			this.groupBox_0.Name = "GroupBox1";
			this.groupBox_0.Size = new global::System.Drawing.Size(281, 93);
			this.groupBox_0.TabIndex = 21;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "过滤条件";
			this.comboBox_2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.comboBox_2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Items.AddRange(new object[]
			{
				"飞机"
			});
			this.comboBox_2.Location = new global::System.Drawing.Point(74, 66);
			this.comboBox_2.Name = "CB_Hypothetical";
			this.comboBox_2.Size = new global::System.Drawing.Size(201, 21);
			this.comboBox_2.TabIndex = 18;
			this.label_3.Location = new global::System.Drawing.Point(7, 70);
			this.label_3.Name = "Label7";
			this.label_3.Size = new global::System.Drawing.Size(69, 13);
			this.label_3.TabIndex = 17;
			this.label_3.Text = "类别:";
			this.comboBox_0.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Items.AddRange(new object[]
			{
				"飞机"
			});
			this.comboBox_0.Location = new global::System.Drawing.Point(74, 41);
			this.comboBox_0.Name = "CB_Country";
			this.comboBox_0.Size = new global::System.Drawing.Size(201, 21);
			this.comboBox_0.TabIndex = 13;
			this.label_0.Location = new global::System.Drawing.Point(7, 45);
			this.label_0.Name = "Label5";
			this.label_0.Size = new global::System.Drawing.Size(46, 13);
			this.label_0.TabIndex = 12;
			this.label_0.Text = "国家:";
			this.label_1.Location = new global::System.Drawing.Point(7, 21);
			this.label_1.Name = "Label4";
			this.label_1.Size = new global::System.Drawing.Size(35, 13);
			this.label_1.TabIndex = 11;
			this.label_1.Text = "型号:";
			this.textBox_0.Location = new global::System.Drawing.Point(74, 17);
			this.textBox_0.Name = "TB_Class";
			this.textBox_0.Size = new global::System.Drawing.Size(201, 20);
			this.textBox_0.TabIndex = 10;
			this.comboBox_1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Items.AddRange(new object[]
			{
				"飞机",
				"水面舰艇",
				"潜艇",
				"战场设施",
				"卫星",
				"武器"
			});
			this.comboBox_1.Location = new global::System.Drawing.Point(59, 12);
			this.comboBox_1.Name = "CB_ObjectType";
			this.comboBox_1.Size = new global::System.Drawing.Size(226, 21);
			this.comboBox_1.TabIndex = 14;
			this.listBox_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listBox_0.FormattingEnabled = true;
			this.listBox_0.Location = new global::System.Drawing.Point(291, 12);
			this.listBox_0.Name = "ListBox1";
			this.listBox_0.Size = new global::System.Drawing.Size(712, 121);
			this.listBox_0.TabIndex = 0;
			this.label_2.Location = new global::System.Drawing.Point(7, 15);
			this.label_2.Name = "Label1";
			this.label_2.Size = new global::System.Drawing.Size(31, 13);
			this.label_2.TabIndex = 22;
			this.label_2.Text = "类型";
			this.webBrowser_0.AllowWebBrowserDrop = false;
			this.webBrowser_0.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.webBrowser_0.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser_0.Location = new global::System.Drawing.Point(4, 139);
			this.webBrowser_0.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser_0.Name = "WebBrowser1";
			this.webBrowser_0.Size = new global::System.Drawing.Size(999, 583);
			this.webBrowser_0.TabIndex = 23;
			this.webBrowser_0.WebBrowserShortcutsEnabled = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1008, 727);
			base.Controls.Add(this.webBrowser_0);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.groupBox_0);
			base.Controls.Add(this.comboBox_1);
			base.Controls.Add(this.listBox_0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DBViewer";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "数据库浏览器";
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001CC7 RID: 7367
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

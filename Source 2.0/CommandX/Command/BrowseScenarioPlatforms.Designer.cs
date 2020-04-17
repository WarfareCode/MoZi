using System.Windows.Forms;

namespace Command
{
	// Token: 0x020009FE RID: 2558
	
	public sealed partial class BrowseScenarioPlatforms : global::ns33.CommandForm
	{
		// Token: 0x06004D3E RID: 19774 RVA: 0x001EC2C0 File Offset: 0x001EA4C0
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

		// Token: 0x06004D3F RID: 19775 RVA: 0x001EC304 File Offset: 0x001EA504
		private void InitializeComponent()
		{
			this.toolStripContainer_0 = new global::System.Windows.Forms.ToolStripContainer();
			this.treeView_0 = new global::System.Windows.Forms.TreeView();this.treeView_0.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(this.method_3);
			this.toolStrip_0 = new global::System.Windows.Forms.ToolStrip();
			this.toolStripLabel_0 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripComboBox_0 = new global::System.Windows.Forms.ToolStripComboBox();
			this.toolStripLabel_1 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripContainer_0.ContentPanel.SuspendLayout();
			this.toolStripContainer_0.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer_0.SuspendLayout();
			this.toolStrip_0.SuspendLayout();
			base.SuspendLayout();
			this.toolStripContainer_0.ContentPanel.Controls.Add(this.treeView_0);
			this.toolStripContainer_0.ContentPanel.Size = new global::System.Drawing.Size(517, 344);
			this.toolStripContainer_0.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer_0.Location = new global::System.Drawing.Point(0, 0);
			this.toolStripContainer_0.Name = "ToolStripContainer1";
			this.toolStripContainer_0.Size = new global::System.Drawing.Size(517, 369);
			this.toolStripContainer_0.TabIndex = 0;
			this.toolStripContainer_0.Text = "ToolStripContainer1";
			this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_0);
			this.treeView_0.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treeView_0.Location = new global::System.Drawing.Point(0, 0);
			this.treeView_0.Name = "TreeView1";
			this.treeView_0.Size = new global::System.Drawing.Size(517, 344);
			this.treeView_0.TabIndex = 0;
			this.toolStrip_0.Dock = global::System.Windows.Forms.DockStyle.None;
			this.toolStrip_0.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip_0.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripLabel_0,
				this.toolStripComboBox_0,
				this.toolStripLabel_1
			});
			this.toolStrip_0.Location = new global::System.Drawing.Point(3, 0);
			this.toolStrip_0.Name = "ToolStrip1";
			this.toolStrip_0.Size = new global::System.Drawing.Size(443, 25);
			this.toolStrip_0.TabIndex = 0;
			this.toolStripLabel_0.Name = "ToolStripLabel1";
			this.toolStripLabel_0.Size = new global::System.Drawing.Size(32, 22);
			this.toolStripLabel_0.Text = "推演方:";
			this.toolStripComboBox_0.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBox_0.Name = "TSCB_Side";
			this.toolStripComboBox_0.Size = new global::System.Drawing.Size(200, 25);
			this.toolStripLabel_1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Italic);
			this.toolStripLabel_1.Name = "ToolStripLabel2";
			this.toolStripLabel_1.Size = new global::System.Drawing.Size(206, 22);
			this.toolStripLabel_1.Text = "(双击查看装备数据库信息)";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(517, 369);
			base.Controls.Add(this.toolStripContainer_0);
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "BrowseScenarioPlatforms";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "浏览想定平台";
			this.toolStripContainer_0.ContentPanel.ResumeLayout(false);
			this.toolStripContainer_0.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer_0.TopToolStripPanel.PerformLayout();
			this.toolStripContainer_0.ResumeLayout(false);
			this.toolStripContainer_0.PerformLayout();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400248A RID: 9354
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

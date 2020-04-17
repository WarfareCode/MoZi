namespace ns34
{
	// Token: 0x0200099F RID: 2463
	
	public sealed partial class FormationEditor : global::ns33.CommandForm
	{
		// Token: 0x06003FB2 RID: 16306 RVA: 0x00157154 File Offset: 0x00155354
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

		// Token: 0x06003FB3 RID: 16307 RVA: 0x00157198 File Offset: 0x00155398
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns34.FormationEditor));
			global::System.Windows.Forms.TreeNode treeNode = new global::System.Windows.Forms.TreeNode("Formation Units");
			this.vmethod_1(new global::System.Windows.Forms.ToolStrip());
			this.vmethod_3(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_5(new global::System.Windows.Forms.ToolStripSeparator());
			this.vmethod_15(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_17(new global::System.Windows.Forms.ToolStripButton());
			this.vmethod_7(new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0));
			this.vmethod_9(new global::System.Windows.Forms.ToolStripMenuItem());
			this.vmethod_11(new global::System.Windows.Forms.ToolStripMenuItem());
			this.vmethod_13(new global::System.Windows.Forms.TreeView());
			this.vmethod_0().SuspendLayout();
			this.GetCMenu_ThreatAxis().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.vmethod_0().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.vmethod_2(),
				this.vmethod_4(),
				this.vmethod_14(),
				this.vmethod_16()
			});
			this.vmethod_0().Location = new global::System.Drawing.Point(0, 0);
			this.vmethod_0().Name = "ToolStrip1";
			this.vmethod_0().Size = new global::System.Drawing.Size(590, 25);
			this.vmethod_0().TabIndex = 7;
			this.vmethod_0().Text = "ToolStrip1";
            //ZSP ERR IMG this.vmethod_2().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton1.Image");
            this.vmethod_2().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_2().Name = "ToolStripButton1";
			this.vmethod_2().Size = new global::System.Drawing.Size(107, 22);
			this.vmethod_2().Text = "设置编队领队";
			this.vmethod_4().Name = "ToolStripSeparator1";
			this.vmethod_4().Size = new global::System.Drawing.Size(6, 25);
            //ZSP ERR IMG this.vmethod_14().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton2.Image");
            this.vmethod_14().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_14().Name = "ToolStripButton2";
			this.vmethod_14().Size = new global::System.Drawing.Size(174, 22);
			this.vmethod_14().Text = "设置阵位(相对方位)";
            //ZSP ERR IMG this.vmethod_16().Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton3.Image");
            this.vmethod_16().ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.vmethod_16().Name = "ToolStripButton3";
			this.vmethod_16().Size = new global::System.Drawing.Size(161, 22);
			this.vmethod_16().Text = "设置阵位(固定方位)";
			this.GetCMenu_ThreatAxis().Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.GetTSMI_AssignToPatrol(),
				this.GetTSMI_RemoveFromPatrol()
			});
			this.GetCMenu_ThreatAxis().Name = "CMenu_ThreatAxis";
			this.GetCMenu_ThreatAxis().Size = new global::System.Drawing.Size(181, 48);
			this.GetTSMI_AssignToPatrol().Name = "AssignToPatrol_TSMI";
			this.GetTSMI_AssignToPatrol().Size = new global::System.Drawing.Size(180, 22);
			this.GetTSMI_AssignToPatrol().Text = "分配巡逻任务...";
			this.GetTSMI_RemoveFromPatrol().Name = "RemoveFromPatrol_TSMI";
			this.GetTSMI_RemoveFromPatrol().Size = new global::System.Drawing.Size(180, 22);
			this.GetTSMI_RemoveFromPatrol().Text = "解除巡逻任务";
			this.vmethod_12().AllowDrop = true;
			this.vmethod_12().Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vmethod_12().Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161);
			this.vmethod_12().Location = new global::System.Drawing.Point(0, 25);
			this.vmethod_12().Name = "TV_Units";
			treeNode.Name = "Node0";
			treeNode.NodeFont = new global::System.Drawing.Font("Microsoft Sans Serif", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 161, false);
			treeNode.Text = "编队作战单元";
			this.vmethod_12().Nodes.AddRange(new global::System.Windows.Forms.TreeNode[]
			{
				treeNode
			});
			this.vmethod_12().Size = new global::System.Drawing.Size(590, 433);
			this.vmethod_12().TabIndex = 12;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(590, 458);
			base.Controls.Add(this.vmethod_12());
			base.Controls.Add(this.vmethod_0());
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormationEditor";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormationEditor2";
			this.vmethod_0().ResumeLayout(false);
			this.vmethod_0().PerformLayout();
			this.GetCMenu_ThreatAxis().ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001D4A RID: 7498
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

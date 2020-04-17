using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using ns16;
using ns32;

namespace ns33
{
	// Token: 0x020009C0 RID: 2496
	[DesignerGenerated]
	public sealed partial class CustomLayersForm : CommandForm
	{
		// Token: 0x060042CE RID: 17102 RVA: 0x0018626C File Offset: 0x0018446C
		public CustomLayersForm()
		{
			base.Shown += new EventHandler(this.CustomLayersForm_Shown);
			base.KeyDown += new KeyEventHandler(this.CustomLayersForm_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.CustomLayersForm_FormClosing);
			base.Load += new EventHandler(this.CustomLayersForm_Load);
			this.InitializeComponent();
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x001865E8 File Offset: 0x001847E8
		[CompilerGenerated]
		internal  ToolStrip vmethod_0()
		{
			return this.toolStrip_0;
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x00021968 File Offset: 0x0001FB68
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x00186600 File Offset: 0x00184800
		[CompilerGenerated]
		internal  ToolStripButton vmethod_2()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x00186618 File Offset: 0x00184818
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStripButton toolStripButton_2)
		{
			EventHandler value = new EventHandler(this.method_2);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_2;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x00186664 File Offset: 0x00184864
		[CompilerGenerated]
		internal  ToolStripButton vmethod_4()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x0018667C File Offset: 0x0018487C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_2)
		{
			EventHandler value = new EventHandler(this.method_3);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_2;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x001866C8 File Offset: 0x001848C8
		[CompilerGenerated]
		internal  ListBox vmethod_6()
		{
			return this.listBox_0;
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x00021971 File Offset: 0x0001FB71
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ListBox listBox_1)
		{
			this.listBox_0 = listBox_1;
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x001866E0 File Offset: 0x001848E0
		public void method_1()
		{
			this.vmethod_6().Items.Clear();
			foreach (RenderableObject current in Client.RenderableObjectList)
			{
				TreeNode treeNode = new TreeNode();
				treeNode.Name = current.GetName();
				treeNode.Tag = current;
				this.vmethod_6().Items.Add(treeNode);
			}
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x0002197A File Offset: 0x0001FB7A
		private void CustomLayersForm_Shown(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x00021982 File Offset: 0x0001FB82
		private void method_2(object sender, EventArgs e)
		{
			Client.AddImageLayerList();
			this.method_1();
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x00186768 File Offset: 0x00184968
		private void method_3(object sender, EventArgs e)
		{
			IEnumerator enumerator = this.vmethod_6().SelectedItems.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator.Current;
					Client.m_WorldWindow.method_2().GetRenderableObjectList().Remove(((RenderableObject)treeNode.Tag).GetName());
					Client.RenderableObjectList.Remove((RenderableObject)treeNode.Tag);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			CommandFactory.GetCommandMain().GetMainForm().MapBoxResize();
			this.method_1();
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x000200A8 File Offset: 0x0001E2A8
		private void CustomLayersForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x00004D83 File Offset: 0x00002F83
		private void CustomLayersForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x060042DF RID: 17119 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void CustomLayersForm_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001F34 RID: 7988
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x04001F35 RID: 7989
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04001F36 RID: 7990
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04001F37 RID: 7991
		[CompilerGenerated]
		private ListBox listBox_0;
	}
}

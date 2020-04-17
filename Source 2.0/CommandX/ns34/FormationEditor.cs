using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns32;
using ns33;
using ns35;

namespace ns34
{
	// Token: 0x0200099F RID: 2463
	[DesignerGenerated]
	public sealed partial class FormationEditor : CommandForm
	{
		// Token: 0x06003FB1 RID: 16305 RVA: 0x001570E8 File Offset: 0x001552E8
		public FormationEditor()
		{
			base.FormClosing += new FormClosingEventHandler(this.FormationEditor_FormClosing);
			base.Load += new EventHandler(this.FormationEditor_Load);
			base.KeyDown += new KeyEventHandler(this.FormationEditor_KeyDown);
			base.FormClosed += new FormClosedEventHandler(this.FormationEditor_FormClosed);
			this.CB_SprintAndDrift = new CheckBox();
			this.InitializeComponent();
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x00157690 File Offset: 0x00155890
		[CompilerGenerated]
		internal  ToolStrip vmethod_0()
		{
			return this.toolStrip_0;
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x00020B54 File Offset: 0x0001ED54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x001576A8 File Offset: 0x001558A8
		[CompilerGenerated]
		internal  ToolStripButton vmethod_2()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x001576C0 File Offset: 0x001558C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStripButton toolStripButton_3)
		{
			EventHandler value = new EventHandler(this.method_3);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_3;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x0015770C File Offset: 0x0015590C
		[CompilerGenerated]
		internal  ToolStripSeparator vmethod_4()
		{
			return this.toolStripSeparator_0;
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x00020B5D File Offset: 0x0001ED5D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripSeparator toolStripSeparator_1)
		{
			this.toolStripSeparator_0 = toolStripSeparator_1;
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x00157724 File Offset: 0x00155924
		[CompilerGenerated]
		internal  ContextMenuStrip GetCMenu_ThreatAxis()
		{
			return this.contextMenuStrip_0;
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x00020B66 File Offset: 0x0001ED66
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ContextMenuStrip contextMenuStrip_1)
		{
			this.contextMenuStrip_0 = contextMenuStrip_1;
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x0015773C File Offset: 0x0015593C
		[CompilerGenerated]
		internal  ToolStripMenuItem GetTSMI_AssignToPatrol()
		{
			return this.toolStripMenuItem_0;
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x00157754 File Offset: 0x00155954
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripMenuItem toolStripMenuItem_2)
		{
			EventHandler value = new EventHandler(this.method_5);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_0;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value;
			}
			this.toolStripMenuItem_0 = toolStripMenuItem_2;
			toolStripMenuItem = this.toolStripMenuItem_0;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value;
			}
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x001577A0 File Offset: 0x001559A0
		[CompilerGenerated]
		internal  ToolStripMenuItem GetTSMI_RemoveFromPatrol()
		{
			return this.toolStripMenuItem_1;
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x00020B6F File Offset: 0x0001ED6F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripMenuItem toolStripMenuItem_2)
		{
			this.toolStripMenuItem_1 = toolStripMenuItem_2;
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x001577B8 File Offset: 0x001559B8
		[CompilerGenerated]
		internal  TreeView vmethod_12()
		{
			return this.treeView_0;
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x001577D0 File Offset: 0x001559D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(TreeView treeView_1)
		{
			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.method_6);
			TreeView treeView = this.treeView_0;
			if (treeView != null)
			{
				treeView.NodeMouseClick -= value;
			}
			this.treeView_0 = treeView_1;
			treeView = this.treeView_0;
			if (treeView != null)
			{
				treeView.NodeMouseClick += value;
			}
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x0015781C File Offset: 0x00155A1C
		[CompilerGenerated]
		internal  ToolStripButton vmethod_14()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x00157834 File Offset: 0x00155A34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ToolStripButton toolStripButton_3)
		{
			EventHandler value = new EventHandler(this.method_7);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_3;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x00157880 File Offset: 0x00155A80
		[CompilerGenerated]
		internal  ToolStripButton vmethod_16()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x00157898 File Offset: 0x00155A98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(ToolStripButton toolStripButton_3)
		{
			EventHandler value = new EventHandler(this.method_8);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_3;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x001578E4 File Offset: 0x00155AE4
		public void method_1()
		{
			base.SuspendLayout();
			this.vmethod_12().Nodes[0].Nodes.Clear();
			foreach (ActiveUnit current in this.group.GetUnitsInGroup().Values)
			{
				string text = current.Name;
				if (current.IsGroupLead())
				{
					text = "[领队] " + text;
				}
				string str;
				if (current.IsAircraft)
				{
					Aircraft aircraft = (Aircraft)current;
					if (Information.IsNothing(aircraft.GetLoadout()))
					{
						str = "";
					}
					else
					{
						str = " (" + aircraft.GetLoadout().Name + ")";
					}
				}
				else
				{
					str = "";
				}
				string str2;
				if (string.IsNullOrEmpty(current.UnitClass))
				{
					str2 = "";
				}
				else
				{
					str2 = " (" + Misc.smethod_11(current.UnitClass) + ")";
				}
				TreeNode treeNode = this.vmethod_12().Nodes[0].Nodes.Add(text + str2 + str);
				treeNode.Tag = current;
				treeNode.NodeFont = new Font(this.vmethod_12().Font, FontStyle.Regular);
			}
			this.vmethod_12().Nodes[0].ExpandAll();
			base.ResumeLayout();
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x00020B78 File Offset: 0x0001ED78
		private void FormationEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			Client.GetMap().ViewMode = MapProfile._ViewMode.GroupMode;
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x00157A74 File Offset: 0x00155C74
		private void FormationEditor_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.Text = "编队编辑器 - " + this.group.Name;
			this.CB_SprintAndDrift.Text = "高低速交替航行";
			this.CB_SprintAndDrift.BackColor = Color.Transparent;
			this.CB_SprintAndDrift.Click += new EventHandler(this.checkBox_0_Click);
			ToolStripControlHost value = new ToolStripControlHost(this.CB_SprintAndDrift);
			this.vmethod_0().Items.Add(value);
			Client.smethod_15(new Client.Delegate50(this.method_2));
			this.method_1();
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x00157B20 File Offset: 0x00155D20
		private void method_2(Unit unit_0)
		{
			foreach (TreeNode current in Class2529.smethod_5(this.vmethod_12()))
			{
				if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(current.Tag)) && current.Tag == unit_0)
				{
					this.vmethod_12().SelectedNode = current;
					if (((ActiveUnit)unit_0).IsGroupLead())
					{
						this.CB_SprintAndDrift.Enabled = false;
					}
					else
					{
						this.CB_SprintAndDrift.Enabled = true;
						this.CB_SprintAndDrift.Checked = ((ActiveUnit)unit_0).GetNavigator().GetFormationStation().SprintAndDrift;
					}
					if (base.Visible)
					{
						base.Focus();
					}
					break;
				}
			}
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x00157BFC File Offset: 0x00155DFC
		private void checkBox_0_Click(object sender, EventArgs e)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_12().SelectedNode.Tag)))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.vmethod_12().SelectedNode.Tag);
				if (objectValue.GetType().BaseType == typeof(Platform))
				{
					ActiveUnit activeUnit = (ActiveUnit)objectValue;
					if (!activeUnit.IsGroupLead())
					{
						activeUnit.GetNavigator().GetFormationStation().SprintAndDrift = this.CB_SprintAndDrift.Checked;
					}
				}
			}
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x00157C84 File Offset: 0x00155E84
		private void method_3(object sender, EventArgs e)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_12().SelectedNode.Tag)))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.vmethod_12().SelectedNode.Tag);
				if (objectValue.GetType().BaseType == typeof(Platform))
				{
					ActiveUnit groupLead = (ActiveUnit)objectValue;
					this.group.SetGroupLead(groupLead);
					this.method_1();
					CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
				}
			}
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x00157D0C File Offset: 0x00155F0C
		private void method_4(ActiveUnit activeUnit_0)
		{
			if (Information.IsNothing(activeUnit_0.GetAssignedMission(false)))
			{
				this.GetTSMI_RemoveFromPatrol().Enabled = false;
			}
			else
			{
				this.GetTSMI_RemoveFromPatrol().Enabled = (activeUnit_0.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol);
			}
			this.GetTSMI_AssignToPatrol().DropDownItems.Clear();
			foreach (Patrol current in this.group.GetPatrols())
			{
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(current.Name);
				toolStripMenuItem.Tag = current;
				toolStripMenuItem.MouseDown += new MouseEventHandler(this.method_5);
				this.GetTSMI_AssignToPatrol().DropDownItems.Add(toolStripMenuItem);
			}
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x00157DDC File Offset: 0x00155FDC
		private void method_5(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(toolStripMenuItem.Tag)) && toolStripMenuItem.Tag.GetType() == typeof(Patrol))
			{
				foreach (Patrol current in this.group.GetPatrols())
				{
					if (Operators.CompareString(current.Name, toolStripMenuItem.Text, false) == 0)
					{
						((ActiveUnit)Client.GetHookedUnit()).DeleteMission(false, current);
						this.method_1();
						break;
					}
				}
			}
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x00157E9C File Offset: 0x0015609C
		private void method_6(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(e.Node.Tag)))
			{
				if (e.Node.Tag.GetType().BaseType.BaseType == typeof(ActiveUnit))
				{
					CommandFactory.GetCommandMain().GetMainForm().method_18((Unit)e.Node.Tag, true);
					Client.SetHookedUnit(true, (Unit)e.Node.Tag);
					if (e.Button == MouseButtons.Right)
					{
						this.method_4((ActiveUnit)e.Node.Tag);
						this.GetCMenu_ThreatAxis().Show(this.vmethod_12(), e.X, e.Y);
					}
				}
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x00157F7C File Offset: 0x0015617C
		private void method_7(object sender, EventArgs e)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_12().SelectedNode.Tag)))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.vmethod_12().SelectedNode.Tag);
				if (objectValue.GetType().BaseType == typeof(Platform) && !((ActiveUnit)objectValue).IsGroupLead())
				{
					Client.orientationType_0 = ReferencePoint.OrientationType.Rotating;
					Client.IssueOrdersToUnit(Client._CommandOrder.SetFormationStation);
				}
			}
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x00157FF4 File Offset: 0x001561F4
		private void method_8(object sender, EventArgs e)
		{
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.vmethod_12().SelectedNode.Tag)))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.vmethod_12().SelectedNode.Tag);
				if (objectValue.GetType().BaseType == typeof(Platform) && !((ActiveUnit)objectValue).IsGroupLead())
				{
					Client.orientationType_0 = ReferencePoint.OrientationType.Fixed;
					Client.IssueOrdersToUnit(Client._CommandOrder.SetFormationStation);
				}
			}
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x00020B94 File Offset: 0x0001ED94
		private void FormationEditor_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			if (e.KeyCode == Keys.F4 && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x0015806C File Offset: 0x0015626C
		private void FormationEditor_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.CB_SprintAndDrift.Click -= new EventHandler(this.checkBox_0_Click);
			Client.smethod_16(new Client.Delegate50(this.method_2));
			IEnumerator enumerator = this.GetTSMI_AssignToPatrol().DropDownItems.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((ToolStripMenuItem)enumerator.Current).MouseDown -= new MouseEventHandler(this.method_5);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x04001D4B RID: 7499
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x04001D4C RID: 7500
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04001D4D RID: 7501
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x04001D4E RID: 7502
		[CompilerGenerated]
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x04001D4F RID: 7503
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04001D50 RID: 7504
		[CompilerGenerated]
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04001D51 RID: 7505
		[CompilerGenerated]
		private TreeView treeView_0;

		// Token: 0x04001D52 RID: 7506
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04001D53 RID: 7507
		[CompilerGenerated]
		private ToolStripButton toolStripButton_2;

		// Token: 0x04001D54 RID: 7508
		public Group group;

		// Token: 0x04001D55 RID: 7509
		private CheckBox CB_SprintAndDrift;
	}
}

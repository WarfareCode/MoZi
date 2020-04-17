using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x020009FE RID: 2558
	[DesignerGenerated]
	public sealed partial class BrowseScenarioPlatforms : CommandForm
	{
		// Token: 0x06004D3A RID: 19770 RVA: 0x001EC0D4 File Offset: 0x001EA2D4
		public BrowseScenarioPlatforms()
		{
			base.Load += new EventHandler(this.BrowseScenarioPlatforms_Load);
			base.KeyDown += new KeyEventHandler(this.BrowseScenarioPlatforms_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.BrowseScenarioPlatforms_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x00004D83 File Offset: 0x00002F83
		private void BrowseScenarioPlatforms_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x001EC124 File Offset: 0x001EA324
		private void BrowseScenarioPlatforms_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (!base.Visible || (e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.End && e.KeyCode != Keys.Home && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract))
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x001EC1E0 File Offset: 0x001EA3E0
		private void BrowseScenarioPlatforms_Load(object sender, EventArgs e)
		{
			if (Information.IsNothing(Client.GetClientSide()))
			{
				base.Close();
			}
			else
			{
				if (Client.float_0 == 1f)
				{
					base.AutoScaleMode = AutoScaleMode.None;
				}
				this.side_0 = Client.GetClientSide();
				this.comboBox_0 = this.toolStripComboBox_0.ComboBox;this.comboBox_0.SelectionChangeCommitted += new EventHandler(this.method_2);
				Side[] sides = Client.GetClientScenario().GetSides();
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					ComboBoxItem item = new ComboBoxItem
					{
						Content = side.GetSideName(),
						Tag = side.GetGuid()
					};
					this.comboBox_0.Items.Add(item);
				}
				this.comboBox_0.DisplayMember = "Content";
				this.comboBox_0.ValueMember = "Tag";
				this.comboBox_0.SelectedIndex = 0;
				this.method_1();
			}
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x001EC6D0 File Offset: 0x001EA8D0
//		[CompilerGenerated]
//		internal  ToolStripContainer vmethod_0()
//		{
//			return this.toolStripContainer_0;
//		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x00024A10 File Offset: 0x00022C10
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_1(ToolStripContainer toolStripContainer_1)
//		{
//			this.toolStripContainer_0 = toolStripContainer_1;
//		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x001EC6E8 File Offset: 0x001EA8E8
//		[CompilerGenerated]
//		internal  ToolStrip vmethod_2()
//		{
//			return this.toolStrip_0;
//		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x00024A19 File Offset: 0x00022C19
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_3(ToolStrip toolStrip_1)
//		{
//			this.toolStrip_0 = toolStrip_1;
//		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x001EC700 File Offset: 0x001EA900
//		[CompilerGenerated]
//		internal  ToolStripLabel vmethod_4()
//		{
//			return this.toolStripLabel_0;
//		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x00024A22 File Offset: 0x00022C22
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_5(ToolStripLabel toolStripLabel_2)
//		{
//			this.toolStripLabel_0 = toolStripLabel_2;
//		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x001EC718 File Offset: 0x001EA918
//		[CompilerGenerated]
//		internal  ToolStripComboBox vmethod_6()
//		{
//			return this.toolStripComboBox_0;
//		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x00024A2B File Offset: 0x00022C2B
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_7(ToolStripComboBox toolStripComboBox_1)
//		{
//			this.toolStripComboBox_0 = toolStripComboBox_1;
//		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x001EC730 File Offset: 0x001EA930
//		[CompilerGenerated]
//		internal  ToolStripLabel vmethod_8()
//		{
//			return this.toolStripLabel_1;
//		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x00024A34 File Offset: 0x00022C34
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_9(ToolStripLabel toolStripLabel_2)
//		{
//			this.toolStripLabel_1 = toolStripLabel_2;
//		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x001EC748 File Offset: 0x001EA948
//		[CompilerGenerated]
//		internal  System.Windows.Forms.TreeView vmethod_10()
//		{
//			return this.treeView_0;
//		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x001EC760 File Offset: 0x001EA960
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_11(System.Windows.Forms.TreeView treeView_1)
//		{
//			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.method_3);
//			System.Windows.Forms.TreeView treeView = this.treeView_0;
//			if (treeView != null)
//			{
//				treeView.NodeMouseDoubleClick -= value;
//			}
//			this.treeView_0 = treeView_1;
//			treeView = this.treeView_0;
//			if (treeView != null)
//			{
//				treeView.NodeMouseDoubleClick += value;
//			}
//		}

		// Token: 0x06004D4C RID: 19788 RVA: 0x001EC7AC File Offset: 0x001EA9AC
//		[CompilerGenerated]
//		internal  System.Windows.Forms.ComboBox vmethod_12()
//		{
//			return this.comboBox_0;
//		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x001EC7C4 File Offset: 0x001EA9C4
//		[CompilerGenerated]
//		[MethodImpl(MethodImplOptions.Synchronized)]
//		internal void vmethod_13(System.Windows.Forms.ComboBox comboBox_1)
//		{
//			EventHandler value = new EventHandler(this.method_2);
//			System.Windows.Forms.ComboBox comboBox = this.comboBox_0;
//			if (comboBox != null)
//			{
//				comboBox.SelectionChangeCommitted -= value;
//			}
//			this.comboBox_0 = comboBox_1;
//			comboBox = this.comboBox_0;
//			if (comboBox != null)
//			{
//				comboBox.SelectionChangeCommitted += value;
//			}
//		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x001EC810 File Offset: 0x001EAA10
		private void method_1()
		{
			this.treeView_0.Nodes.Clear();
			IEnumerable<IGrouping<string, ActiveUnit>> enumerable = Client.GetClientScenario().GetActiveUnitList().Where(new Func<ActiveUnit, bool>(this.method_4)).GroupBy(BrowseScenarioPlatforms.ActiveUnitFunc0).Select(BrowseScenarioPlatforms.IGroupingFunc1);
			foreach (IGrouping<string, ActiveUnit> current in enumerable)
			{
				string text;
				if (current.ElementAtOrDefault(0).IsAircraft)
				{
					text = "飞机";
				}
				else if (current.ElementAtOrDefault(0).IsShip)
				{
					text = "水面舰艇";
				}
				else if (current.ElementAtOrDefault(0).IsSubmarine)
				{
					text = "潜艇";
				}
				else if (current.ElementAtOrDefault(0).IsFacility)
				{
					text = "战场设施";
				}
				else
				{
					if (!current.ElementAtOrDefault(0).IsSatellite())
					{
						throw new NotImplementedException();
					}
					text = "卫星";
				}
				TreeNode treeNode = this.treeView_0.Nodes.Add(text);
				foreach (IGrouping<int, ActiveUnit> current2 in current.GroupBy(BrowseScenarioPlatforms.ActiveUnitFunc2))
				{
					TreeNode treeNode2 = new TreeNode(current2.ElementAtOrDefault(0).UnitClass);
					treeNode2.Tag = text + "_" + Conversions.ToString(current2.ElementAtOrDefault(0).DBID);
					treeNode.Nodes.Add(treeNode2);
				}
			}
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x00024A3D File Offset: 0x00022C3D
		private void method_2(object sender, EventArgs e)
		{
			this.side_0 = Client.GetClientScenario().GetSides().Where(new Func<Side, bool>(this.method_5)).ElementAtOrDefault(0);
			this.method_1();
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x001EC9DC File Offset: 0x001EABDC
		private void method_3(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (!string.IsNullOrEmpty(Conversions.ToString(e.Node.Tag)))
			{
				string strUnitType = e.Node.Tag.ToString().Split(new char[]
				{
					'_'
				})[0];
				int dBID = Conversions.ToInteger(e.Node.Tag.ToString().Split(new char[]
				{
					'_'
				})[1]);
				Client.ShowDBInfo(strUnitType, dBID);
			}
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x00024A6C File Offset: 0x00022C6C
		[CompilerGenerated]
		private bool method_4(ActiveUnit activeUnit_0)
		{
			return activeUnit_0.IsPlatform() & activeUnit_0.GetSide(false) == this.side_0;
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x00024A84 File Offset: 0x00022C84
		[CompilerGenerated]
		private bool method_5(Side side_1)
		{
			return Operators.ConditionalCompareObjectEqual(side_1.GetGuid(), NewLateBinding.LateGet(this.comboBox_0.SelectedItem, null, "Tag", new object[0], null, null, null), false);
		}

		// Token: 0x04002487 RID: 9351
		public static Func<ActiveUnit, string> ActiveUnitFunc0 = (ActiveUnit activeUnit_0) => activeUnit_0.GetType().ToString();

		// Token: 0x04002488 RID: 9352
		public static Func<IGrouping<string, ActiveUnit>, IGrouping<string, ActiveUnit>> IGroupingFunc1 = (IGrouping<string, ActiveUnit> igrouping_0) => igrouping_0;

		// Token: 0x04002489 RID: 9353
		public static Func<ActiveUnit, int> ActiveUnitFunc2 = (ActiveUnit activeUnit_0) => activeUnit_0.DBID;

		// Token: 0x0400248B RID: 9355
		[CompilerGenerated]
		private ToolStripContainer toolStripContainer_0;

		// Token: 0x0400248C RID: 9356
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x0400248D RID: 9357
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x0400248E RID: 9358
		[CompilerGenerated]
		private ToolStripComboBox toolStripComboBox_0;

		// Token: 0x0400248F RID: 9359
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_1;

		// Token: 0x04002490 RID: 9360
		[CompilerGenerated]
		private System.Windows.Forms.TreeView treeView_0;

		// Token: 0x04002491 RID: 9361
		private Side side_0;

		// Token: 0x04002492 RID: 9362
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_0;
	}
}

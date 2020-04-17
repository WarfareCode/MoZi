using System;
using System.Windows.Forms;
using ThreadSafeControls;

namespace ns15
{
	// Token: 0x0200059B RID: 1435
	internal static class Class739
	{
		// Token: 0x060024C7 RID: 9415 RVA: 0x000E2D90 File Offset: 0x000E0F90
		public static Class677<TControl> smethod_0<TControl>(TControl gparam_0) where TControl : Control
		{
			return new Class677<TControl>(gparam_0);
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x000E2DA8 File Offset: 0x000E0FA8
		public static Class681 smethod_1(ComboBox comboBox_0)
		{
			return new Class681(comboBox_0);
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x000E2DC0 File Offset: 0x000E0FC0
		internal static Class791 smethod_2(ColumnHeader columnHeader_0, Class680 class680_0)
		{
			return new Class791(columnHeader_0, class680_0);
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x000E2DD8 File Offset: 0x000E0FD8
		internal static ThreadSafeListViewItem smethod_3(ListViewItem listViewItem_0, Class680 class680_0)
		{
			return new ThreadSafeListViewItem(listViewItem_0, class680_0);
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x000E2DF0 File Offset: 0x000E0FF0
		internal static ThreadSafeListViewItem.ListViewSubItem smethod_4(ListViewItem.ListViewSubItem listViewSubItem_0, Class680 class680_0)
		{
			return new ThreadSafeListViewItem.ListViewSubItem(listViewSubItem_0, class680_0);
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x000E2E08 File Offset: 0x000E1008
		public static Class682 smethod_5(TreeView treeView_0)
		{
			return new Class682(treeView_0);
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x000E2E20 File Offset: 0x000E1020
		internal static ThreadSafeTreeNode smethod_6(TreeNode treeNode_0, Class682 class682_0)
		{
			return new ThreadSafeTreeNode(treeNode_0, class682_0);
		}
	}
}

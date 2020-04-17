using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns15;

namespace ThreadSafeControls
{
	// Token: 0x020005AB RID: 1451
	public sealed class ThreadSafeTreeNode
	{
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x000E36F8 File Offset: 0x000E18F8
		public Class813 Nodes
		{
			get
			{
				return this.class813_0;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x000E3710 File Offset: 0x000E1910
		// (set) Token: 0x0600250C RID: 9484 RVA: 0x000E3738 File Offset: 0x000E1938
		public object Tag
		{
			get
			{
				return this.class682_0.method_5<object>(new Func<TreeView, object>(this.method_2));
			}
			set
			{
				ThreadSafeTreeNode.Class751 @class = new ThreadSafeTreeNode.Class751();
				@class.value = value;
				@class.threadSafeTreeNode_0 = this;
				this.class682_0.method_4(new Action<TreeView>(@class.method_0));
			}
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x000E3770 File Offset: 0x000E1970
		internal ThreadSafeTreeNode(TreeNode treeNode_1, Class682 class682_1)
		{
			if (treeNode_1 == null)
			{
				throw new ArgumentNullException("treeNode");
			}
			if (class682_1 == null)
			{
				throw new ArgumentNullException("treeView");
			}
			this.treeNode_0 = treeNode_1;
			this.class682_0 = class682_1;
			this.class813_0 = new Class813(this.treeNode_0.Nodes, this.class682_0);
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x000E37D8 File Offset: 0x000E19D8
		internal TreeNode method_0()
		{
			return this.treeNode_0;
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x000152AA File Offset: 0x000134AA
		public void method_1()
		{
			this.class682_0.method_4(new Action<TreeView>(this.method_3));
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x000E37F0 File Offset: 0x000E19F0
		[CompilerGenerated]
		private object method_2(TreeView treeView_0)
		{
			return this.treeNode_0.Tag;
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x000152C3 File Offset: 0x000134C3
		[CompilerGenerated]
		private void method_3(TreeView treeView_0)
		{
			this.treeNode_0.Remove();
		}

		// Token: 0x040011D3 RID: 4563
		private readonly TreeNode treeNode_0;

		// Token: 0x040011D4 RID: 4564
		private readonly Class682 class682_0;

		// Token: 0x040011D5 RID: 4565
		private readonly Class813 class813_0;

		// Token: 0x020005AC RID: 1452
		[CompilerGenerated]
		private sealed class Class751
		{
			// Token: 0x06002512 RID: 9490 RVA: 0x000152D0 File Offset: 0x000134D0
			public void method_0(TreeView treeView_0)
			{
				this.threadSafeTreeNode_0.treeNode_0.Tag = this.value;
			}

			// Token: 0x040011D6 RID: 4566
			public ThreadSafeTreeNode threadSafeTreeNode_0;

			// Token: 0x040011D7 RID: 4567
			public object value;
		}
	}
}

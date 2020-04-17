using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ThreadSafeControls;

namespace ns15
{
	// Token: 0x02000617 RID: 1559
	public sealed class Class813 : IEnumerable, IList<ThreadSafeTreeNode>, ICollection<ThreadSafeTreeNode>, IEnumerable<ThreadSafeTreeNode>, ICollection, IList
	{
		// Token: 0x170002D7 RID: 727
		public ThreadSafeTreeNode this[int index]
		{
			get
			{
				Class813.Class814 @class = new Class813.Class814();
				@class.int_0 = index;
				@class.class813_0 = this;
				return Class739.smethod_6(this.class682_0.method_5<TreeNode>(new Func<TreeView, TreeNode>(@class.method_0)), this.class682_0);
			}
			set
			{
				Class813.Class815 @class = new Class813.Class815();
				@class.int_0 = index;
				@class.value = value;
				@class.class813_0 = this;
				this.class682_0.method_4(new Action<TreeView>(@class.method_0));
			}
		}

		// Token: 0x170002D8 RID: 728
		public ThreadSafeTreeNode this[string string_0]
		{
			get
			{
				Class813.Class816 @class = new Class813.Class816();
				@class.string_0 = string_0;
				@class.class813_0 = this;
				return Class739.smethod_6(this.class682_0.method_5<TreeNode>(new Func<TreeView, TreeNode>(@class.method_0)), this.class682_0);
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x000F12C8 File Offset: 0x000EF4C8
		public int Count
		{
			get
			{
				return this.class682_0.method_5<int>(new Func<TreeView, int>(this.method_5));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x00016147 File Offset: 0x00014347
		public bool IsReadOnly
		{
			get
			{
				return this.treeNodeCollection_0.IsReadOnly;
			}
		}

		// Token: 0x170002DB RID: 731
		object IList.this[int index]
		{
			get
			{
				Class813.Class824 @class = new Class813.Class824();
				@class.int_0 = index;
				@class.class813_0 = this;
				return this.class682_0.method_5<object>(new Func<TreeView, object>(@class.method_0));
			}
			set
			{
				Class813.Class825 @class = new Class813.Class825();
				@class.int_0 = index;
				@class.value = value;
				@class.class813_0 = this;
				this.class682_0.method_4(new Action<TreeView>(@class.method_0));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x00016154 File Offset: 0x00014354
		bool IList.IsFixedSize
		{
			get
			{
				return ((IList)this.treeNodeCollection_0).IsFixedSize;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x00016161 File Offset: 0x00014361
		bool ICollection.IsSynchronized
		{
			get
			{
				return ((ICollection)this.treeNodeCollection_0).IsSynchronized;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x000F136C File Offset: 0x000EF56C
		object ICollection.SyncRoot
		{
			get
			{
				return ((ICollection)this.treeNodeCollection_0).SyncRoot;
			}
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x0001616E File Offset: 0x0001436E
		internal Class813(TreeNodeCollection treeNodeCollection_1, Class682 class682_1)
		{
			if (treeNodeCollection_1 == null)
			{
				throw new ArgumentNullException("nodes");
			}
			if (class682_1 == null)
			{
				throw new ArgumentNullException("treeView");
			}
			this.treeNodeCollection_0 = treeNodeCollection_1;
			this.class682_0 = class682_1;
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x000F1388 File Offset: 0x000EF588
		public ThreadSafeTreeNode method_0(string string_0)
		{
			Class813.Class817 @class = new Class813.Class817();
			@class.string_0 = string_0;
			@class.class813_0 = this;
			return Class739.smethod_6(this.class682_0.method_5<TreeNode>(new Func<TreeView, TreeNode>(@class.method_0)), this.class682_0);
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x000F13D0 File Offset: 0x000EF5D0
		public int method_1(TreeNode treeNode_0)
		{
			Class813.Class818 @class = new Class813.Class818();
			@class.treeNode_0 = treeNode_0;
			@class.class813_0 = this;
			return this.class682_0.method_5<int>(new Func<TreeView, int>(@class.method_0));
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x000F140C File Offset: 0x000EF60C
		public int method_2(ThreadSafeTreeNode threadSafeTreeNode_0)
		{
			return this.method_1(threadSafeTreeNode_0.method_0());
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x000161AC File Offset: 0x000143AC
		public void Clear()
		{
			this.class682_0.method_4(new Action<TreeView>(this.method_6));
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x000F1428 File Offset: 0x000EF628
		public bool Contains(TreeNode treeNode_0)
		{
			Class813.Class819 @class = new Class813.Class819();
			@class.treeNode_0 = treeNode_0;
			@class.class813_0 = this;
			return this.class682_0.method_5<bool>(new Func<TreeView, bool>(@class.method_0));
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x000161C5 File Offset: 0x000143C5
		public bool Contains(ThreadSafeTreeNode item)
		{
			return this.Contains(item.method_0());
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x000F1460 File Offset: 0x000EF660
		public void CopyTo(ThreadSafeTreeNode[] array, int arrayIndex)
		{
			ThreadSafeTreeNode[] array2 = this.method_4().ToArray<ThreadSafeTreeNode>();
			array2.CopyTo(array, arrayIndex);
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x000F1484 File Offset: 0x000EF684
		public int IndexOf(TreeNode treeNode_0)
		{
			Class813.Class820 @class = new Class813.Class820();
			@class.treeNode_0 = treeNode_0;
			@class.class813_0 = this;
			return this.class682_0.method_5<int>(new Func<TreeView, int>(@class.method_0));
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x000F14C0 File Offset: 0x000EF6C0
		public int IndexOf(ThreadSafeTreeNode item)
		{
			return this.IndexOf(item.method_0());
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x000F14DC File Offset: 0x000EF6DC
		public void Insert(int int_0, TreeNode treeNode_0)
		{
			Class813.Class821 @class = new Class813.Class821();
			@class.int_0 = int_0;
			@class.treeNode_0 = treeNode_0;
			@class.class813_0 = this;
			this.class682_0.method_4(new Action<TreeView>(@class.method_0));
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x000161D3 File Offset: 0x000143D3
		public void Insert(int index, ThreadSafeTreeNode item)
		{
			this.Insert(index, item.method_0());
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x000F151C File Offset: 0x000EF71C
		public void method_3(TreeNode treeNode_0)
		{
			Class813.Class822 @class = new Class813.Class822();
			@class.treeNode_0 = treeNode_0;
			@class.class813_0 = this;
			this.class682_0.method_4(new Action<TreeView>(@class.method_0));
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x000161E2 File Offset: 0x000143E2
		public bool Remove(ThreadSafeTreeNode item)
		{
			this.method_3(item.method_0());
			return true;
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x000F1554 File Offset: 0x000EF754
		public void RemoveAt(int index)
		{
			Class813.Class823 @class = new Class813.Class823();
			@class.int_0 = index;
			@class.class813_0 = this;
			this.class682_0.method_4(new Action<TreeView>(@class.method_0));
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x000F158C File Offset: 0x000EF78C
		public IEnumerator<ThreadSafeTreeNode> GetEnumerator()
		{
			return this.method_4().GetEnumerator();
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x000F15A8 File Offset: 0x000EF7A8
		private IEnumerable<ThreadSafeTreeNode> method_4()
		{
			return this.class682_0.method_5<TreeNodeCollection>(new Func<TreeView, TreeNodeCollection>(this.method_7)).Cast<TreeNode>().Select(new Func<TreeNode, ThreadSafeTreeNode>(this.method_8));
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x000161F1 File Offset: 0x000143F1
		void ICollection<ThreadSafeTreeNode>.Add(ThreadSafeTreeNode item)
		{
			this.method_2(item);
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x000F15E4 File Offset: 0x000EF7E4
		int IList.Add(object value)
		{
			Class813.Class826 @class = new Class813.Class826();
			@class.value = value;
			@class.class813_0 = this;
			return this.class682_0.method_5<int>(new Func<TreeView, int>(@class.method_0));
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x000F1620 File Offset: 0x000EF820
		bool IList.Contains(object value)
		{
			Class813.Class827 @class = new Class813.Class827();
			@class.value = value;
			@class.class813_0 = this;
			return this.class682_0.method_5<bool>(new Func<TreeView, bool>(@class.method_0));
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x000F1460 File Offset: 0x000EF660
		void ICollection.CopyTo(Array array, int index)
		{
			ThreadSafeTreeNode[] array2 = this.method_4().ToArray<ThreadSafeTreeNode>();
			array2.CopyTo(array, index);
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x000F1658 File Offset: 0x000EF858
		int IList.IndexOf(object value)
		{
			Class813.Class828 @class = new Class813.Class828();
			@class.value = value;
			@class.class813_0 = this;
			return this.class682_0.method_5<int>(new Func<TreeView, int>(@class.method_0));
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x000F1694 File Offset: 0x000EF894
		void IList.Insert(int index, object value)
		{
			Class813.Class829 @class = new Class813.Class829();
			@class.int_0 = index;
			@class.value = value;
			@class.class813_0 = this;
			this.class682_0.method_4(new Action<TreeView>(@class.method_0));
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x000F16D4 File Offset: 0x000EF8D4
		void IList.Remove(object value)
		{
			Class813.Class830 @class = new Class813.Class830();
			@class.value = value;
			@class.class813_0 = this;
			this.class682_0.method_4(new Action<TreeView>(@class.method_0));
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x000F170C File Offset: 0x000EF90C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x000F1724 File Offset: 0x000EF924
		[CompilerGenerated]
		private int method_5(TreeView treeView_0)
		{
			return this.treeNodeCollection_0.Count;
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x000161FB File Offset: 0x000143FB
		[CompilerGenerated]
		private void method_6(TreeView treeView_0)
		{
			this.treeNodeCollection_0.Clear();
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x000F1740 File Offset: 0x000EF940
		[CompilerGenerated]
		private TreeNodeCollection method_7(TreeView treeView_0)
		{
			return this.treeNodeCollection_0;
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x000F1758 File Offset: 0x000EF958
		[CompilerGenerated]
		private ThreadSafeTreeNode method_8(TreeNode treeNode_0)
		{
			return Class739.smethod_6(treeNode_0, this.class682_0);
		}

		// Token: 0x04001315 RID: 4885
		private readonly TreeNodeCollection treeNodeCollection_0;

		// Token: 0x04001316 RID: 4886
		private readonly Class682 class682_0;

		// Token: 0x02000618 RID: 1560
		[CompilerGenerated]
		private sealed class Class814
		{
			// Token: 0x060027D8 RID: 10200 RVA: 0x000F1774 File Offset: 0x000EF974
			public TreeNode method_0(TreeView treeView_0)
			{
				return this.class813_0.treeNodeCollection_0[this.int_0];
			}

			// Token: 0x04001317 RID: 4887
			public Class813 class813_0;

			// Token: 0x04001318 RID: 4888
			public int int_0;
		}

		// Token: 0x02000619 RID: 1561
		[CompilerGenerated]
		private sealed class Class815
		{
			// Token: 0x060027DA RID: 10202 RVA: 0x00016208 File Offset: 0x00014408
			public void method_0(TreeView treeView_0)
			{
				this.class813_0.treeNodeCollection_0[this.int_0] = this.value.method_0();
			}

			// Token: 0x04001319 RID: 4889
			public Class813 class813_0;

			// Token: 0x0400131A RID: 4890
			public int int_0;

			// Token: 0x0400131B RID: 4891
			public ThreadSafeTreeNode value;
		}

		// Token: 0x0200061A RID: 1562
		[CompilerGenerated]
		private sealed class Class816
		{
			// Token: 0x060027DC RID: 10204 RVA: 0x000F179C File Offset: 0x000EF99C
			public TreeNode method_0(TreeView treeView_0)
			{
				return this.class813_0.treeNodeCollection_0[this.string_0];
			}

			// Token: 0x0400131C RID: 4892
			public Class813 class813_0;

			// Token: 0x0400131D RID: 4893
			public string string_0;
		}

		// Token: 0x0200061B RID: 1563
		[CompilerGenerated]
		private sealed class Class817
		{
			// Token: 0x060027DE RID: 10206 RVA: 0x000F17C4 File Offset: 0x000EF9C4
			public TreeNode method_0(TreeView treeView_0)
			{
				return this.class813_0.treeNodeCollection_0.Add(this.string_0);
			}

			// Token: 0x0400131E RID: 4894
			public Class813 class813_0;

			// Token: 0x0400131F RID: 4895
			public string string_0;
		}

		// Token: 0x0200061C RID: 1564
		[CompilerGenerated]
		private sealed class Class818
		{
			// Token: 0x060027E0 RID: 10208 RVA: 0x000F17EC File Offset: 0x000EF9EC
			public int method_0(TreeView treeView_0)
			{
				return this.class813_0.treeNodeCollection_0.Add(this.treeNode_0);
			}

			// Token: 0x04001320 RID: 4896
			public Class813 class813_0;

			// Token: 0x04001321 RID: 4897
			public TreeNode treeNode_0;
		}

		// Token: 0x0200061D RID: 1565
		[CompilerGenerated]
		private sealed class Class819
		{
			// Token: 0x060027E2 RID: 10210 RVA: 0x0001622B File Offset: 0x0001442B
			public bool method_0(TreeView treeView_0)
			{
				return this.class813_0.treeNodeCollection_0.Contains(this.treeNode_0);
			}

			// Token: 0x04001322 RID: 4898
			public Class813 class813_0;

			// Token: 0x04001323 RID: 4899
			public TreeNode treeNode_0;
		}

		// Token: 0x0200061E RID: 1566
		[CompilerGenerated]
		private sealed class Class820
		{
			// Token: 0x060027E4 RID: 10212 RVA: 0x000F1814 File Offset: 0x000EFA14
			public int method_0(TreeView treeView_0)
			{
				return this.class813_0.treeNodeCollection_0.IndexOf(this.treeNode_0);
			}

			// Token: 0x04001324 RID: 4900
			public Class813 class813_0;

			// Token: 0x04001325 RID: 4901
			public TreeNode treeNode_0;
		}

		// Token: 0x0200061F RID: 1567
		[CompilerGenerated]
		private sealed class Class821
		{
			// Token: 0x060027E6 RID: 10214 RVA: 0x00016243 File Offset: 0x00014443
			public void method_0(TreeView treeView_0)
			{
				this.class813_0.treeNodeCollection_0.Insert(this.int_0, this.treeNode_0);
			}

			// Token: 0x04001326 RID: 4902
			public Class813 class813_0;

			// Token: 0x04001327 RID: 4903
			public int int_0;

			// Token: 0x04001328 RID: 4904
			public TreeNode treeNode_0;
		}

		// Token: 0x02000620 RID: 1568
		[CompilerGenerated]
		private sealed class Class822
		{
			// Token: 0x060027E8 RID: 10216 RVA: 0x00016261 File Offset: 0x00014461
			public void method_0(TreeView treeView_0)
			{
				this.class813_0.treeNodeCollection_0.Remove(this.treeNode_0);
			}

			// Token: 0x04001329 RID: 4905
			public Class813 class813_0;

			// Token: 0x0400132A RID: 4906
			public TreeNode treeNode_0;
		}

		// Token: 0x02000621 RID: 1569
		[CompilerGenerated]
		private sealed class Class823
		{
			// Token: 0x060027EA RID: 10218 RVA: 0x00016279 File Offset: 0x00014479
			public void method_0(TreeView treeView_0)
			{
				this.class813_0.treeNodeCollection_0.RemoveAt(this.int_0);
			}

			// Token: 0x0400132B RID: 4907
			public Class813 class813_0;

			// Token: 0x0400132C RID: 4908
			public int int_0;
		}

		// Token: 0x02000622 RID: 1570
		[CompilerGenerated]
		private sealed class Class824
		{
			// Token: 0x060027EC RID: 10220 RVA: 0x000F183C File Offset: 0x000EFA3C
			public object method_0(TreeView treeView_0)
			{
				return ((IList)this.class813_0.treeNodeCollection_0)[this.int_0];
			}

			// Token: 0x0400132D RID: 4909
			public Class813 class813_0;

			// Token: 0x0400132E RID: 4910
			public int int_0;
		}

		// Token: 0x02000623 RID: 1571
		[CompilerGenerated]
		private sealed class Class825
		{
			// Token: 0x060027EE RID: 10222 RVA: 0x00016291 File Offset: 0x00014491
			public void method_0(TreeView treeView_0)
			{
				((IList)this.class813_0.treeNodeCollection_0)[this.int_0] = this.value;
			}

			// Token: 0x0400132F RID: 4911
			public Class813 class813_0;

			// Token: 0x04001330 RID: 4912
			public int int_0;

			// Token: 0x04001331 RID: 4913
			public object value;
		}

		// Token: 0x02000624 RID: 1572
		[CompilerGenerated]
		private sealed class Class826
		{
			// Token: 0x060027F0 RID: 10224 RVA: 0x000F1864 File Offset: 0x000EFA64
			public int method_0(TreeView treeView_0)
			{
				return ((IList)this.class813_0.treeNodeCollection_0).Add(this.value);
			}

			// Token: 0x04001332 RID: 4914
			public Class813 class813_0;

			// Token: 0x04001333 RID: 4915
			public object value;
		}

		// Token: 0x02000625 RID: 1573
		[CompilerGenerated]
		private sealed class Class827
		{
			// Token: 0x060027F2 RID: 10226 RVA: 0x000162AF File Offset: 0x000144AF
			public bool method_0(TreeView treeView_0)
			{
				return ((IList)this.class813_0.treeNodeCollection_0).Contains(this.value);
			}

			// Token: 0x04001334 RID: 4916
			public Class813 class813_0;

			// Token: 0x04001335 RID: 4917
			public object value;
		}

		// Token: 0x02000626 RID: 1574
		[CompilerGenerated]
		private sealed class Class828
		{
			// Token: 0x060027F4 RID: 10228 RVA: 0x000F188C File Offset: 0x000EFA8C
			public int method_0(TreeView treeView_0)
			{
				return ((IList)this.class813_0.treeNodeCollection_0).IndexOf(this.value);
			}

			// Token: 0x04001336 RID: 4918
			public Class813 class813_0;

			// Token: 0x04001337 RID: 4919
			public object value;
		}

		// Token: 0x02000627 RID: 1575
		[CompilerGenerated]
		private sealed class Class829
		{
			// Token: 0x060027F6 RID: 10230 RVA: 0x000162C7 File Offset: 0x000144C7
			public void method_0(TreeView treeView_0)
			{
				((IList)this.class813_0.treeNodeCollection_0).Insert(this.int_0, this.value);
			}

			// Token: 0x04001338 RID: 4920
			public Class813 class813_0;

			// Token: 0x04001339 RID: 4921
			public int int_0;

			// Token: 0x0400133A RID: 4922
			public object value;
		}

		// Token: 0x02000628 RID: 1576
		[CompilerGenerated]
		private sealed class Class830
		{
			// Token: 0x060027F8 RID: 10232 RVA: 0x000162E5 File Offset: 0x000144E5
			public void method_0(TreeView treeView_0)
			{
				((IList)this.class813_0.treeNodeCollection_0).Remove(this.value);
			}

			// Token: 0x0400133B RID: 4923
			public Class813 class813_0;

			// Token: 0x0400133C RID: 4924
			public object value;
		}
	}
}

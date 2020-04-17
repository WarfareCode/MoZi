using System;
using System.Collections;
using System.Collections.Generic;

namespace ns29
{
	// Token: 0x0200017F RID: 383
	public sealed class TreeGridViewRowNodes : IList<TreeGridViewRow>, ICollection<TreeGridViewRow>, IEnumerable<TreeGridViewRow>, IEnumerable, ICollection, IList
	{
		// Token: 0x170000CA RID: 202
		public TreeGridViewRow this[int index]
		{
			get
			{
				return this._nodes[index];
			}
			set
			{
				throw new Exception("The method or operation is not implemented.");
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x0006B2DC File Offset: 0x000694DC
		public int Count
		{
			get
			{
				return this._nodes.Count;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x000081A2 File Offset: 0x000063A2
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00008956 File Offset: 0x00006B56
		bool IList.IsReadOnly
		{
			get
			{
				return this.IsReadOnly;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x000081A2 File Offset: 0x000063A2
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x0006B2F8 File Offset: 0x000694F8
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		// Token: 0x170000D0 RID: 208
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				throw new Exception("The method or operation is not implemented.");
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0000894A File Offset: 0x00006B4A
		bool ICollection.IsSynchronized
		{
			get
			{
				throw new Exception("The method or operation is not implemented.");
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0000894A File Offset: 0x00006B4A
		object ICollection.SyncRoot
		{
			get
			{
				throw new Exception("The method or operation is not implemented.");
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0000895E File Offset: 0x00006B5E
		internal TreeGridViewRowNodes(TreeGridViewRow class2384_1)
		{
			this._TreeGridViewRow = class2384_1;
			this._nodes = new List<TreeGridViewRow>();
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0006B328 File Offset: 0x00069528
		public void Add(TreeGridViewRow item)
		{
			item.treeGridView_0 = this._TreeGridViewRow.treeGridView_0;
			bool flag = this._TreeGridViewRow.vmethod_2();
			item.class2378_0 = this;
			this._nodes.Add(item);
			this._TreeGridViewRow.vmethod_6(item);
			if (!flag && this._TreeGridViewRow.method_8())
			{
				this._TreeGridViewRow.treeGridView_0.InvalidateRow(this._TreeGridViewRow.method_0());
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0006B3A4 File Offset: 0x000695A4
		public TreeGridViewRow method_0(string string_0)
		{
			TreeGridViewRow treeGridViewRow = new TreeGridViewRow();
			this.Add(treeGridViewRow);
			treeGridViewRow.Cells[0].Value = string_0;
			return treeGridViewRow;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0006B3D4 File Offset: 0x000695D4
		public TreeGridViewRow method_1(object[] object_0)
		{
			TreeGridViewRow treeGridViewRow = new TreeGridViewRow();
			this.Add(treeGridViewRow);
			int num = 0;
			if (object_0.Length > treeGridViewRow.Cells.Count)
			{
				throw new ArgumentOutOfRangeException("values");
			}
			for (int i = 0; i < object_0.Length; i++)
			{
				object value = object_0[i];
				treeGridViewRow.Cells[num].Value = value;
				num++;
			}
			return treeGridViewRow;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00008978 File Offset: 0x00006B78
		public void Insert(int index, TreeGridViewRow item)
		{
			item.treeGridView_0 = this._TreeGridViewRow.treeGridView_0;
			item.class2378_0 = this;
			this._nodes.Insert(index, item);
			this._TreeGridViewRow.vmethod_5(index, item);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000089AD File Offset: 0x00006BAD
		public bool Remove(TreeGridViewRow item)
		{
			this._TreeGridViewRow.vmethod_7(item);
			item.treeGridView_0 = null;
			return this._nodes.Remove(item);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0006B440 File Offset: 0x00069640
		public void RemoveAt(int index)
		{
			TreeGridViewRow treeGridViewRow = this._nodes[index];
			this._TreeGridViewRow.vmethod_7(treeGridViewRow);
			treeGridViewRow.treeGridView_0 = null;
			this._nodes.RemoveAt(index);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000089CF File Offset: 0x00006BCF
		public void Clear()
		{
			this._TreeGridViewRow.vmethod_8();
			this._nodes.Clear();
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0006B47C File Offset: 0x0006967C
		public int IndexOf(TreeGridViewRow item)
		{
			return this._nodes.IndexOf(item);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000089E8 File Offset: 0x00006BE8
		public bool Contains(TreeGridViewRow item)
		{
			return this._nodes.Contains(item);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0000894A File Offset: 0x00006B4A
		public void CopyTo(TreeGridViewRow[] array, int arrayIndex)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000089F6 File Offset: 0x00006BF6
		void IList.Remove(object value)
		{
			this.Remove(value as TreeGridViewRow);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0006B498 File Offset: 0x00069698
		int IList.Add(object value)
		{
			TreeGridViewRow treeGridViewRow = value as TreeGridViewRow;
			this.Add(treeGridViewRow);
			return treeGridViewRow.method_1();
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00008A05 File Offset: 0x00006C05
		void IList.RemoveAt(int index)
		{
			this.RemoveAt(index);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00008A0E File Offset: 0x00006C0E
		void IList.Clear()
		{
			this.Clear();
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0006B4BC File Offset: 0x000696BC
		int IList.IndexOf(object value)
		{
			return this.IndexOf(value as TreeGridViewRow);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00008A16 File Offset: 0x00006C16
		void IList.Insert(int index, object value)
		{
			this.Insert(index, value as TreeGridViewRow);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00008A25 File Offset: 0x00006C25
		bool IList.Contains(object value)
		{
			return this.Contains(value as TreeGridViewRow);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0000894A File Offset: 0x00006B4A
		void ICollection.CopyTo(Array array, int index)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0006B4D8 File Offset: 0x000696D8
		public IEnumerator<TreeGridViewRow> GetEnumerator()
		{
			return this._nodes.GetEnumerator();
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0006B4F8 File Offset: 0x000696F8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000399 RID: 921
		internal List<TreeGridViewRow> _nodes;

		// Token: 0x0400039A RID: 922
		internal TreeGridViewRow _TreeGridViewRow;
	}
}

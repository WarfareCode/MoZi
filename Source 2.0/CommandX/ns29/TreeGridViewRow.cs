using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using AdvancedDataGridView;

namespace ns29
{
	// Token: 0x02000180 RID: 384
	public sealed class TreeGridViewRow : DataGridViewRow
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0006B510 File Offset: 0x00069710
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public TreeGridViewRowNodes Nodes
		{
			get
			{
				if (this.class2378_1 == null)
				{
					this.class2378_1 = new TreeGridViewRowNodes(this);
				}
				return this.class2378_1;
			}
			set
			{
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0006B540 File Offset: 0x00069740
		public new DataGridViewCellCollection Cells
		{
			get
			{
				DataGridViewCellCollection result;
				if (!this.bool_5 && base.DataGridView == null)
				{
					if (this.treeGridView_0 == null)
					{
						result = null;
						return result;
					}
					base.CreateCells(this.treeGridView_0);
					this.bool_5 = true;
				}
				result = base.Cells;
				return result;
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00008A33 File Offset: 0x00006C33
		internal TreeGridViewRow(TreeGridView treeGridView_1) : this()
		{
			this.treeGridView_0 = treeGridView_1;
			this.bool_0 = true;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0006B594 File Offset: 0x00069794
		public TreeGridViewRow()
		{
			this.int_2 = -1;
			this.int_3 = -1;
			this.bool_0 = false;
			this.int_1 = this.random_0.Next();
			this.bool_2 = false;
			this.bool_3 = false;
			this.bool_4 = false;
			this.int_0 = -1;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0006B610 File Offset: 0x00069810
		public override object Clone()
		{
			TreeGridViewRow treeGridViewRow = (TreeGridViewRow)base.Clone();
			treeGridViewRow.int_1 = -1;
			treeGridViewRow.int_3 = this.int_3;
			treeGridViewRow.treeGridView_0 = this.treeGridView_0;
			treeGridViewRow.class2384_0 = this.method_7();
			treeGridViewRow.int_0 = this.int_0;
			if (treeGridViewRow.int_0 == -1)
			{
				treeGridViewRow.method_4(this.method_3());
			}
			treeGridViewRow.bool_0 = this.bool_0;
			return treeGridViewRow;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0006B68C File Offset: 0x0006988C
		protected internal void vmethod_0()
		{
            IEnumerator enumerator = this.Cells.GetEnumerator();
			{
				while (enumerator.MoveNext())
				{
					TreeGridViewTextBoxCell treeGridViewTextBoxCell = ((DataGridViewCell)enumerator.Current) as TreeGridViewTextBoxCell;
					if (treeGridViewTextBoxCell != null)
					{
						treeGridViewTextBoxCell.vmethod_0();
					}
				}
			}
			this.bool_2 = false;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0006B6FC File Offset: 0x000698FC
		protected internal void vmethod_1()
		{
			this.bool_2 = true;
			this.bool_5 = true;
            IEnumerator enumerator = this.Cells.GetEnumerator();
			{
				while (enumerator.MoveNext())
				{
					TreeGridViewTextBoxCell treeGridViewTextBoxCell = ((DataGridViewCell)enumerator.Current) as TreeGridViewTextBoxCell;
					if (treeGridViewTextBoxCell != null)
					{
						treeGridViewTextBoxCell.vmethod_1();
					}
				}
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0006B774 File Offset: 0x00069974
		public int method_0()
		{
			return base.Index;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0006B78C File Offset: 0x0006998C
		public int method_1()
		{
			if (this.int_2 == -1)
			{
				this.int_2 = this.class2378_0.IndexOf(this);
			}
			return this.int_2;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0006B7C4 File Offset: 0x000699C4
		public ImageList method_2()
		{
			ImageList result;
			if (this.treeGridView_0 != null)
			{
				result = this.treeGridView_0.method_7();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0006B7F0 File Offset: 0x000699F0
		public Image method_3()
		{
			Image result;
			if (this.image_0 != null || this.int_0 == -1)
			{
				result = this.image_0;
			}
			else if (this.method_2() != null && this.int_0 < this.method_2().Images.Count)
			{
				result = this.method_2().Images[this.int_0];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0006B864 File Offset: 0x00069A64
		public void method_4(Image image_1)
		{
			this.image_0 = image_1;
			if (this.image_0 != null)
			{
				this.int_0 = -1;
			}
			if (this.bool_2)
			{
				this.class2382_0.vmethod_2();
				if (this.Displayed)
				{
					this.treeGridView_0.InvalidateRow(this.method_0());
				}
			}
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0006B8BC File Offset: 0x00069ABC
		protected override DataGridViewCellCollection CreateCellsInstance()
		{
			DataGridViewCellCollection dataGridViewCellCollection = base.CreateCellsInstance();
			dataGridViewCellCollection.CollectionChanged += new CollectionChangeEventHandler(this.method_5);
			return dataGridViewCellCollection;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0006B8E8 File Offset: 0x00069AE8
		private void method_5(object sender, CollectionChangeEventArgs e)
		{
			if (this.class2382_0 == null && (e.Action == CollectionChangeAction.Add || e.Action == CollectionChangeAction.Refresh))
			{
				TreeGridViewTextBoxCell treeGridViewTextBoxCell = null;
				if (e.Element == null)
				{
                    IEnumerator enumerator = base.Cells.GetEnumerator();					{
						while (enumerator.MoveNext())
						{
							DataGridViewCell dataGridViewCell = (DataGridViewCell)enumerator.Current;
							if (dataGridViewCell.GetType().IsAssignableFrom(typeof(TreeGridViewTextBoxCell)))
							{
								treeGridViewTextBoxCell = (TreeGridViewTextBoxCell)dataGridViewCell;
								IL_81:
								goto IL_A3;
							}
						}
						goto IL_A3;
					}
				}
				treeGridViewTextBoxCell = (e.Element as TreeGridViewTextBoxCell);
				IL_A3:
				if (treeGridViewTextBoxCell != null)
				{
					this.class2382_0 = treeGridViewTextBoxCell;
				}
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0006B9B8 File Offset: 0x00069BB8
		public int method_6()
		{
			if (this.int_3 == -1)
			{
				int num = 0;
				for (TreeGridViewRow treeGridViewRow = this.method_7(); treeGridViewRow != null; treeGridViewRow = treeGridViewRow.method_7())
				{
					num++;
				}
				this.int_3 = num;
			}
			return this.int_3;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0006BA04 File Offset: 0x00069C04
		public TreeGridViewRow method_7()
		{
			return this.class2384_0;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00008A49 File Offset: 0x00006C49
		public   bool vmethod_2()
		{
			return this.class2378_1 != null && this.Nodes.Count != 0;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00008A67 File Offset: 0x00006C67
		public bool method_8()
		{
			return this.bool_2;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00008A6F File Offset: 0x00006C6F
		public bool method_9()
		{
			return this.method_1() == 0;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0006BA1C File Offset: 0x00069C1C
		public bool method_10()
		{
			TreeGridViewRow treeGridViewRow = this.method_7();
			return treeGridViewRow == null || !treeGridViewRow.vmethod_2() || this.method_1() == treeGridViewRow.Nodes.Count - 1;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00008A7A File Offset: 0x00006C7A
		public   bool vmethod_3()
		{
			return this.treeGridView_0.vmethod_1(this);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0006BA54 File Offset: 0x00069C54
		public   bool vmethod_4()
		{
			bool result;
			if (this.treeGridView_0 != null)
			{
				result = this.treeGridView_0.vmethod_4(this);
			}
			else
			{
				this.bool_0 = true;
				result = true;
			}
			return result;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0006BA88 File Offset: 0x00069C88
		protected internal  bool vmethod_5(int int_4, TreeGridViewRow class2384_1)
		{
			class2384_1.class2384_0 = this;
			class2384_1.treeGridView_0 = this.treeGridView_0;
			if (this.treeGridView_0 != null)
			{
				this.method_11(class2384_1);
			}
			if ((this.bool_2 || this.bool_1) && this.bool_0)
			{
				this.treeGridView_0.vmethod_2(class2384_1);
			}
			return true;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0006BAE8 File Offset: 0x00069CE8
		protected internal  bool vmethod_6(TreeGridViewRow class2384_1)
		{
			class2384_1.class2384_0 = this;
			class2384_1.treeGridView_0 = this.treeGridView_0;
			if (this.treeGridView_0 != null)
			{
				this.method_11(class2384_1);
			}
			if ((this.bool_2 || this.bool_1) && this.bool_0 && !class2384_1.bool_2)
			{
				this.treeGridView_0.vmethod_2(class2384_1);
			}
			return true;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00008A88 File Offset: 0x00006C88
		protected internal  bool vmethod_7(TreeGridViewRow class2384_1)
		{
			if ((this.bool_1 || this.bool_2) && this.bool_0)
			{
				this.treeGridView_0.vmethod_0(class2384_1);
			}
			class2384_1.treeGridView_0 = null;
			class2384_1.class2384_0 = null;
			return true;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0006BB4C File Offset: 0x00069D4C
		protected internal  bool vmethod_8()
		{
			if (this.vmethod_2())
			{
				for (int i = this.Nodes.Count - 1; i >= 0; i--)
				{
					this.Nodes.RemoveAt(i);
				}
			}
			return true;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0006BB90 File Offset: 0x00069D90
		private void method_11(TreeGridViewRow class2384_1)
		{
			if (class2384_1.vmethod_2())
			{
				foreach (TreeGridViewRow current in class2384_1.Nodes)
				{
					current.treeGridView_0 = class2384_1.treeGridView_0;
					this.method_11(current);
				}
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0006BBF8 File Offset: 0x00069DF8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(36);
			stringBuilder.Append("TreeGridNode { Index=");
			stringBuilder.Append(this.method_0().ToString(CultureInfo.CurrentCulture));
			stringBuilder.Append(" }");
			return stringBuilder.ToString();
		}

		// Token: 0x0400039B RID: 923
		internal TreeGridView treeGridView_0;

		// Token: 0x0400039C RID: 924
		internal TreeGridViewRow class2384_0;

		// Token: 0x0400039D RID: 925
		internal TreeGridViewRowNodes class2378_0;

		// Token: 0x0400039E RID: 926
		internal bool bool_0;

		// Token: 0x0400039F RID: 927
		internal bool bool_1;

		// Token: 0x040003A0 RID: 928
		internal bool bool_2 = false;

		// Token: 0x040003A1 RID: 929
		internal bool bool_3;

		// Token: 0x040003A2 RID: 930
		internal bool bool_4;

		// Token: 0x040003A3 RID: 931
		internal Image image_0;

		// Token: 0x040003A4 RID: 932
		internal int int_0;

		// Token: 0x040003A5 RID: 933
		private Random random_0 = new Random();

		// Token: 0x040003A6 RID: 934
		public int int_1 = -1;

		// Token: 0x040003A7 RID: 935
		private TreeGridViewTextBoxCell class2382_0;

		// Token: 0x040003A8 RID: 936
		private TreeGridViewRowNodes class2378_1;

		// Token: 0x040003A9 RID: 937
		private int int_2 = 0;

		// Token: 0x040003AA RID: 938
		private int int_3 = 0;

		// Token: 0x040003AB RID: 939
		private bool bool_5;
	}
}

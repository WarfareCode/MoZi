using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns29;

namespace AdvancedDataGridView
{
	// Token: 0x02000213 RID: 531
	[ComplexBindingProperties]
	public sealed class TreeGridView : DataGridView
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x0007905C File Offset: 0x0007725C
		public TreeGridViewRowNodes Nodes
		{
			get
			{
				return this._TreeGridViewRow.Nodes;
			}
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00079078 File Offset: 0x00077278
		public TreeGridView()
		{
			base.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.method_1(new TreeGridViewRow());
			base.AllowUserToAddRows = false;
			base.AllowUserToDeleteRows = false;
			this._TreeGridViewRow = new TreeGridViewRow(this);
			this._TreeGridViewRow.bool_1 = true;
			DataGridViewRowCollection arg_52_0 = base.Rows;
			base.Rows.CollectionChanged += delegate(object sender, CollectionChangeEventArgs e)
			{
			};
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00079100 File Offset: 0x00077300
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!e.Handled)
			{
				if (e.KeyCode == Keys.F2 && base.CurrentCellAddress.X > -1 && base.CurrentCellAddress.Y > -1)
				{
					if (!base.CurrentCell.Displayed)
					{
						base.FirstDisplayedScrollingRowIndex = base.CurrentCellAddress.Y;
					}
					base.SelectionMode = DataGridViewSelectionMode.CellSelect;
					this.BeginEdit(true);
				}
				else if (e.KeyCode == Keys.Return && !base.IsCurrentCellInEditMode)
				{
					base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					base.CurrentCell.OwningRow.Selected = true;
				}
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x000791B4 File Offset: 0x000773B4
		public DataGridViewRowCollection GetRows()
		{
			return base.Rows;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0000A650 File Offset: 0x00008850
		public void method_1(DataGridViewRow dataGridViewRow_0)
		{
			base.RowTemplate = dataGridViewRow_0;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x000791CC File Offset: 0x000773CC
		public TreeGridViewRow GetCurrentRow()
		{
			return base.CurrentRow as TreeGridViewRow;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0000A659 File Offset: 0x00008859
		public bool method_3()
		{
			return this.bool_4;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x000791E8 File Offset: 0x000773E8
		public TreeGridViewRow method_4()
		{
			return this.GetCurrentRow();
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0000A661 File Offset: 0x00008861
		public bool method_5()
		{
			return this.bool_3;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0000A669 File Offset: 0x00008869
		public void method_6(bool bool_5)
		{
			if (bool_5 != this.bool_3)
			{
				this.bool_3 = bool_5;
				base.Invalidate();
			}
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00079200 File Offset: 0x00077400
		public ImageList method_7()
		{
			return this.imageList_0;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0000A683 File Offset: 0x00008883
		public void method_8(ImageList imageList_1)
		{
			this.imageList_0 = imageList_1;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00079218 File Offset: 0x00077418
		protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
		{
			base.OnRowsAdded(e);
			TreeGridViewRow treeGridViewRow = base.Rows[e.RowIndex] as TreeGridViewRow;
			if (treeGridViewRow != null)
			{
				treeGridViewRow.vmethod_1();
			}
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0000A68C File Offset: 0x0000888C
		protected internal void method_9()
		{
			this.vmethod_0(this._TreeGridViewRow);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00079250 File Offset: 0x00077450
		protected internal void vmethod_0(TreeGridViewRow TreeGridViewRow_)
		{
			try
			{
				if (TreeGridViewRow_.method_8() || TreeGridViewRow_.bool_1)
				{
					foreach (TreeGridViewRow current in TreeGridViewRow_.Nodes)
					{
						this.vmethod_0(current);
					}
					if (!TreeGridViewRow_.bool_1)
					{
						base.Rows.Remove(TreeGridViewRow_);
						TreeGridViewRow_.vmethod_0();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000792E4 File Offset: 0x000774E4
		protected internal  bool vmethod_1(TreeGridViewRow TreeGridViewRow_)
		{
			bool result;
			if (TreeGridViewRow_.bool_0)
			{
				EventArgs5 eventArgs = new EventArgs5(TreeGridViewRow_);
				this.vmethod_7(eventArgs);
				if (!eventArgs.Cancel)
				{
					this.method_14(true);
					base.SuspendLayout();
					this.bool_1 = true;
					TreeGridViewRow_.bool_0 = false;
					foreach (TreeGridViewRow current in TreeGridViewRow_.Nodes)
					{
						this.vmethod_0(current);
					}
					Class2380 class2380_ = new Class2380(TreeGridViewRow_);
					this.vmethod_8(class2380_);
					this.bool_1 = false;
					this.method_14(false);
					base.ResumeLayout(true);
					base.InvalidateCell(TreeGridViewRow_.Cells[0]);
				}
				result = !eventArgs.Cancel;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000793C0 File Offset: 0x000775C0
		protected internal void vmethod_2(TreeGridViewRow TreeGridViewRow_)
		{
			TreeGridViewRow_.treeGridView_0 = this;
			TreeGridViewRow treeGridViewRow;
			if (TreeGridViewRow_.method_7() != null && !TreeGridViewRow_.method_7().bool_1)
			{
				if (TreeGridViewRow_.method_1() > 0)
				{
					treeGridViewRow = TreeGridViewRow_.method_7().Nodes[TreeGridViewRow_.method_1() - 1];
				}
				else
				{
					treeGridViewRow = TreeGridViewRow_.method_7();
				}
			}
			else if (TreeGridViewRow_.method_1() > 0)
			{
				treeGridViewRow = TreeGridViewRow_.method_7().Nodes[TreeGridViewRow_.method_1() - 1];
			}
			else
			{
				treeGridViewRow = null;
			}
			int int_;
			if (treeGridViewRow != null)
			{
				while (treeGridViewRow.method_6() >= TreeGridViewRow_.method_6() && treeGridViewRow.method_0() < base.Rows.Count - 1)
				{
					treeGridViewRow = (base.Rows[treeGridViewRow.method_0() + 1] as TreeGridViewRow);
				}
				if (treeGridViewRow == TreeGridViewRow_.method_7())
				{
					int_ = treeGridViewRow.method_0() + 1;
				}
				else if (treeGridViewRow.method_6() < TreeGridViewRow_.method_6())
				{
					int_ = treeGridViewRow.method_0();
				}
				else
				{
					int_ = treeGridViewRow.method_0() + 1;
				}
			}
			else
			{
				int_ = 0;
			}
			this.vmethod_3(TreeGridViewRow_, int_);
			if (TreeGridViewRow_.bool_0)
			{
				foreach (TreeGridViewRow current in TreeGridViewRow_.Nodes)
				{
					this.vmethod_2(current);
				}
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0000A69A File Offset: 0x0000889A
		protected internal void vmethod_3(TreeGridViewRow TreeGridViewRow_, int int_0)
		{
			if (int_0 < base.Rows.Count)
			{
				base.Rows.Insert(int_0, TreeGridViewRow_);
			}
			else
			{
				base.Rows.Add(TreeGridViewRow_);
			}
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00079534 File Offset: 0x00077734
		protected internal  bool vmethod_4(TreeGridViewRow TreeGridViewRow_)
		{
			bool result;
			if (TreeGridViewRow_.bool_0 && !this.bool_4)
			{
				result = false;
			}
			else
			{
				EventArgs6 eventArgs = new EventArgs6(TreeGridViewRow_);
				this.vmethod_5(eventArgs);
				if (!eventArgs.Cancel)
				{
					this.method_14(true);
					base.SuspendLayout();
					this.bool_1 = true;
					TreeGridViewRow_.bool_0 = true;
					foreach (TreeGridViewRow current in TreeGridViewRow_.Nodes)
					{
						this.vmethod_2(current);
					}
					Class2381 class2381_ = new Class2381(TreeGridViewRow_);
					this.vmethod_6(class2381_);
					this.bool_1 = false;
					this.method_14(false);
					base.ResumeLayout(true);
					base.InvalidateCell(TreeGridViewRow_.Cells[0]);
				}
				result = !eventArgs.Cancel;
			}
			return result;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0000A6CB File Offset: 0x000088CB
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.bool_2 = false;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0000A6DB File Offset: 0x000088DB
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (!this.bool_2)
			{
				base.OnMouseMove(e);
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00079618 File Offset: 0x00077818
		[CompilerGenerated]
		public void method_10(Delegate41 delegate41_1)
		{
			Delegate41 @delegate = this.delegate41_0;
			Delegate41 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate41 value = (Delegate41)Delegate.Combine(delegate2, delegate41_1);
				@delegate = Interlocked.CompareExchange<Delegate41>(ref this.delegate41_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00079654 File Offset: 0x00077854
		[CompilerGenerated]
		public void method_11(Delegate41 delegate41_1)
		{
			Delegate41 @delegate = this.delegate41_0;
			Delegate41 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate41 value = (Delegate41)Delegate.Remove(delegate2, delegate41_1);
				@delegate = Interlocked.CompareExchange<Delegate41>(ref this.delegate41_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00079690 File Offset: 0x00077890
		[CompilerGenerated]
		public void method_12(Delegate43 delegate43_1)
		{
			Delegate43 @delegate = this.delegate43_0;
			Delegate43 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate43 value = (Delegate43)Delegate.Combine(delegate2, delegate43_1);
				@delegate = Interlocked.CompareExchange<Delegate43>(ref this.delegate43_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x000796CC File Offset: 0x000778CC
		[CompilerGenerated]
		public void method_13(Delegate43 delegate43_1)
		{
			Delegate43 @delegate = this.delegate43_0;
			Delegate43 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate43 value = (Delegate43)Delegate.Remove(delegate2, delegate43_1);
				@delegate = Interlocked.CompareExchange<Delegate43>(ref this.delegate43_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0000A6EC File Offset: 0x000088EC
		protected  void vmethod_5(EventArgs6 eventArgs6_0)
		{
			if (this.delegate41_0 != null)
			{
				this.delegate41_0(this, eventArgs6_0);
			}
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0000A706 File Offset: 0x00008906
		protected  void vmethod_6(Class2381 class2381_0)
		{
			if (this.delegate42_0 != null)
			{
				this.delegate42_0(this, class2381_0);
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0000A720 File Offset: 0x00008920
		protected  void vmethod_7(EventArgs5 eventArgs5_0)
		{
			if (this.delegate43_0 != null)
			{
				this.delegate43_0(this, eventArgs5_0);
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0000A73A File Offset: 0x0000893A
		protected  void vmethod_8(Class2380 class2380_0)
		{
			if (this.delegate44_0 != null)
			{
				this.delegate44_0(this, class2380_0);
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0000A754 File Offset: 0x00008954
		protected override void Dispose(bool disposing)
		{
			this.bool_0 = true;
			base.Dispose(base.Disposing);
			this.method_9();
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00079708 File Offset: 0x00077908
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			this.control_0 = new Control();
			this.control_0.Visible = false;
			this.control_0.Enabled = false;
			this.control_0.TabStop = false;
			base.Controls.Add(this.control_0);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0007975C File Offset: 0x0007795C
		protected override void OnRowEnter(DataGridViewCellEventArgs e)
		{
			base.OnRowEnter(e);
			if (base.SelectionMode == DataGridViewSelectionMode.CellSelect || (base.SelectionMode == DataGridViewSelectionMode.FullRowSelect && !base.Rows[e.RowIndex].Selected))
			{
				base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				base.Rows[e.RowIndex].Selected = true;
			}
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0000A76F File Offset: 0x0000896F
		private void method_14(bool bool_5)
		{
			if (!this.bool_1)
			{
				if (bool_5)
				{
					base.VerticalScrollBar.Parent = this.control_0;
				}
				else
				{
					base.VerticalScrollBar.Parent = this;
				}
			}
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000797C0 File Offset: 0x000779C0
		protected override void OnColumnAdded(DataGridViewColumnEventArgs e)
		{
			if (typeof(TreeGridViewTextBoxColumn).IsAssignableFrom(e.Column.GetType()) && this._TreeGridViewTextBoxColumn == null)
			{
				this._TreeGridViewTextBoxColumn = (TreeGridViewTextBoxColumn)e.Column;
			}
			e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
			base.OnColumnAdded(e);
		}

		// Token: 0x04000558 RID: 1368
		private TreeGridViewRow _TreeGridViewRow;

		// Token: 0x04000559 RID: 1369
		private TreeGridViewTextBoxColumn _TreeGridViewTextBoxColumn;

		// Token: 0x0400055A RID: 1370
		private bool bool_0;

		// Token: 0x0400055B RID: 1371
		internal ImageList imageList_0;

		// Token: 0x0400055C RID: 1372
		private bool bool_1;

		// Token: 0x0400055D RID: 1373
		internal bool bool_2 = false;

		// Token: 0x0400055E RID: 1374
		private Control control_0;

		// Token: 0x0400055F RID: 1375
		private bool bool_3 = true;

		// Token: 0x04000560 RID: 1376
		private bool bool_4;

		// Token: 0x04000561 RID: 1377
		[CompilerGenerated]
		private Delegate41 delegate41_0;

		// Token: 0x04000562 RID: 1378
		[CompilerGenerated]
		private Delegate42 delegate42_0;

		// Token: 0x04000563 RID: 1379
		[CompilerGenerated]
		private Delegate43 delegate43_0;

		// Token: 0x04000564 RID: 1380
		[CompilerGenerated]
		private Delegate44 delegate44_0;
	}
}

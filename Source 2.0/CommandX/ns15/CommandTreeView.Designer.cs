using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns15
{
	// Token: 0x020004A2 RID: 1186
	public sealed class CommandTreeView : TreeView
	{
		// Token: 0x06001EBE RID: 7870 RVA: 0x00012966 File Offset: 0x00010B66
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void method_0(TreeViewEventHandler treeViewEventHandler_2)
		{
			this.treeViewEventHandler_0 = (TreeViewEventHandler)Delegate.Combine(this.treeViewEventHandler_0, treeViewEventHandler_2);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x0001297F File Offset: 0x00010B7F
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void method_1(TreeViewEventHandler treeViewEventHandler_2)
		{
			this.treeViewEventHandler_0 = (TreeViewEventHandler)Delegate.Remove(this.treeViewEventHandler_0, treeViewEventHandler_2);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00012998 File Offset: 0x00010B98
		protected void method_2(TreeNode treeNode_5)
		{
			if (this.treeViewEventHandler_0 != null)
			{
				this.treeViewEventHandler_0(this, new TreeViewEventArgs(treeNode_5));
			}
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x000129B7 File Offset: 0x00010BB7
		protected void method_3(TreeNode treeNode_5)
		{
			if (this.treeViewEventHandler_1 != null)
			{
				this.treeViewEventHandler_1(this, new TreeViewEventArgs(treeNode_5));
			}
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x000129D6 File Offset: 0x00010BD6
		protected void method_4()
		{
			if (this.bool_1 && this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs());
			}
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x000129FF File Offset: 0x00010BFF
		public void method_5(TreeNode treeNode_5)
		{
			if (!this.bool_0)
			{
				throw new NotSupportedException("Use SelectedNodes instead of SelectedNode.");
			}
			base.SelectedNode = treeNode_5;
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x00012A1B File Offset: 0x00010C1B
		public void method_6(Enum145 enum145_1)
		{
			this.enum145_0 = enum145_1;
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x000CA9E8 File Offset: 0x000C8BE8
		public Color method_7()
		{
			return this.color_0;
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00012A24 File Offset: 0x00010C24
		public void method_8(Color color_1)
		{
			this.color_0 = color_1;
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x000CAA00 File Offset: 0x000C8C00
		public Class675 method_9()
		{
			Class675 @class = new Class675();
			foreach (TreeNode treeNode in this.hashtable_0.Values)
			{
				@class.method_4(treeNode);
			}
			@class.method_0(new Delegate35(this.method_10));
			@class.method_2(new Delegate35(this.method_11));
			@class.method_1(new Delegate35(this.method_12));
			@class.method_3(new EventHandler(this.method_13));
			return @class;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00012A2D File Offset: 0x00010C2D
		private void method_10(TreeNode treeNode_5)
		{
			this.bool_1 = false;
			this.method_21(treeNode_5, true, TreeViewAction.Unknown);
			this.method_4();
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00012A2D File Offset: 0x00010C2D
		private void method_11(TreeNode treeNode_5)
		{
			this.bool_1 = false;
			this.method_21(treeNode_5, true, TreeViewAction.Unknown);
			this.method_4();
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00012A46 File Offset: 0x00010C46
		private void method_12(TreeNode treeNode_5)
		{
			this.bool_1 = false;
			this.method_21(treeNode_5, false, TreeViewAction.Unknown);
			this.method_4();
			if (this.treeNode_2 == treeNode_5)
			{
				this.treeNode_2 = null;
			}
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00012A74 File Offset: 0x00010C74
		private void method_13(object sender, EventArgs e)
		{
			this.bool_1 = false;
			this.method_14(TreeViewAction.Unknown);
			this.method_4();
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00012A8A File Offset: 0x00010C8A
		private void method_14(TreeViewAction treeViewAction_0)
		{
			this.method_18(null, treeViewAction_0);
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x000CAAB8 File Offset: 0x000C8CB8
		private void method_15(int int_1, TreeViewAction treeViewAction_0)
		{
			ArrayList arrayList = new ArrayList();
			foreach (TreeNode treeNode in this.hashtable_0.Values)
			{
				if (this.method_26(treeNode) != int_1)
				{
					arrayList.Add(treeNode);
				}
			}
			foreach (TreeNode treeNode_ in arrayList)
			{
				this.method_21(treeNode_, false, treeViewAction_0);
			}
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x000CAB7C File Offset: 0x000C8D7C
		private void method_16(TreeNode treeNode_5, TreeViewAction treeViewAction_0)
		{
			ArrayList arrayList = new ArrayList();
			foreach (TreeNode treeNode in this.hashtable_0.Values)
			{
				if (treeNode.Parent != treeNode_5)
				{
					arrayList.Add(treeNode);
				}
			}
			foreach (TreeNode treeNode_6 in arrayList)
			{
				this.method_21(treeNode_6, false, treeViewAction_0);
			}
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x000CAC3C File Offset: 0x000C8E3C
		private void method_17(TreeNode treeNode_5, TreeViewAction treeViewAction_0)
		{
			ArrayList arrayList = new ArrayList();
			foreach (TreeNode treeNode in this.hashtable_0.Values)
			{
				if (!this.method_27(treeNode, treeNode_5))
				{
					arrayList.Add(treeNode);
				}
			}
			foreach (TreeNode treeNode_6 in arrayList)
			{
				this.method_21(treeNode_6, false, treeViewAction_0);
			}
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x000CACFC File Offset: 0x000C8EFC
		private void method_18(TreeNode treeNode_5, TreeViewAction treeViewAction_0)
		{
			ArrayList arrayList = new ArrayList();
			foreach (TreeNode treeNode in this.hashtable_0.Values)
			{
				if (treeNode_5 == null)
				{
					arrayList.Add(treeNode);
				}
				else if (treeNode_5 != null && treeNode != treeNode_5)
				{
					arrayList.Add(treeNode);
				}
			}
			foreach (TreeNode treeNode_6 in arrayList)
			{
				this.method_21(treeNode_6, false, treeViewAction_0);
			}
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00012A94 File Offset: 0x00010C94
		protected override void OnBeforeSelect(TreeViewCancelEventArgs e)
		{
			e.Cancel = true;
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00012A9D File Offset: 0x00010C9D
		private bool method_19(TreeNode treeNode_5)
		{
			return treeNode_5 != null && this.hashtable_0.ContainsKey(treeNode_5.GetHashCode());
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x000CADD0 File Offset: 0x000C8FD0
		private void method_20(TreeNode treeNode_5)
		{
			if (treeNode_5 != null && !this.hashtable_1.ContainsKey(treeNode_5.GetHashCode()))
			{
				this.hashtable_1.Add(treeNode_5.GetHashCode(), new Color[]
				{
					treeNode_5.BackColor,
					treeNode_5.ForeColor
				});
			}
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x000CAE40 File Offset: 0x000C9040
		private bool method_21(TreeNode treeNode_5, bool bool_4, TreeViewAction treeViewAction_0)
		{
			bool flag = false;
			bool flag2;
			bool result;
			if (treeNode_5 == null)
			{
				flag2 = false;
			}
			else
			{
				if (bool_4)
				{
					if (!this.method_19(treeNode_5))
					{
						TreeViewCancelEventArgs treeViewCancelEventArgs = new TreeViewCancelEventArgs(treeNode_5, false, treeViewAction_0);
						base.OnBeforeSelect(treeViewCancelEventArgs);
						if (treeViewCancelEventArgs.Cancel)
						{
							result = false;
							return result;
						}
						this.method_20(treeNode_5);
						treeNode_5.BackColor = this.method_7();
						treeNode_5.ForeColor = this.BackColor;
						this.hashtable_0.Add(treeNode_5.GetHashCode(), treeNode_5);
						flag = true;
						this.bool_1 = true;
						base.OnAfterSelect(new TreeViewEventArgs(treeNode_5, treeViewAction_0));
					}
					this.treeNode_1 = treeNode_5;
				}
				else if (this.method_19(treeNode_5))
				{
					this.method_3(treeNode_5);
					Color[] array = (Color[])this.hashtable_1[treeNode_5.GetHashCode()];
					if (array != null)
					{
						this.hashtable_0.Remove(treeNode_5.GetHashCode());
						this.bool_1 = true;
						this.hashtable_1.Remove(treeNode_5.GetHashCode());
						treeNode_5.BackColor = array[0];
						treeNode_5.ForeColor = array[1];
					}
					this.method_2(treeNode_5);
				}
				flag2 = flag;
			}
			result = flag2;
			return result;
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x000CAF8C File Offset: 0x000C918C
		private void method_22(TreeNode treeNode_5, TreeNode treeNode_6, TreeViewAction treeViewAction_0)
		{
			TreeNode treeNode;
			TreeNode treeNode2;
			if (treeNode_5.Bounds.Y < treeNode_6.Bounds.Y)
			{
				treeNode = treeNode_5;
				treeNode2 = treeNode_6;
			}
			else
			{
				treeNode = treeNode_6;
				treeNode2 = treeNode_5;
			}
			this.method_21(treeNode, true, treeViewAction_0);
			TreeNode treeNode3 = treeNode;
			while (treeNode3 != treeNode2)
			{
				treeNode3 = treeNode3.NextVisibleNode;
				if (treeNode3 != null)
				{
					this.method_21(treeNode3, true, treeViewAction_0);
				}
			}
			this.method_21(treeNode2, true, treeViewAction_0);
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x000CB000 File Offset: 0x000C9200
		private void method_23(TreeNode treeNode_5, TreeNode treeNode_6, TreeViewAction treeViewAction_0)
		{
			TreeNode treeNode;
			TreeNode treeNode2;
			if (treeNode_5.Bounds.Y < treeNode_6.Bounds.Y)
			{
				treeNode = treeNode_5;
				treeNode2 = treeNode_6;
			}
			else
			{
				treeNode = treeNode_6;
				treeNode2 = treeNode_5;
			}
			TreeNode treeNode3 = treeNode;
			while (treeNode3 != null)
			{
				treeNode3 = treeNode3.PrevVisibleNode;
				if (treeNode3 != null)
				{
					this.method_21(treeNode3, false, treeViewAction_0);
				}
			}
			treeNode3 = treeNode2;
			while (treeNode3 != null)
			{
				treeNode3 = treeNode3.NextVisibleNode;
				if (treeNode3 != null)
				{
					this.method_21(treeNode3, false, treeViewAction_0);
				}
			}
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x000CB084 File Offset: 0x000C9284
		private void method_24(TreeNode treeNode_5, TreeViewAction treeViewAction_0)
		{
			this.method_21(treeNode_5, false, treeViewAction_0);
			foreach (TreeNode treeNode_6 in treeNode_5.Nodes)
			{
				this.method_24(treeNode_6, treeViewAction_0);
			}
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x000CB0EC File Offset: 0x000C92EC
		private bool method_25(TreeNode treeNode_5, MouseEventArgs mouseEventArgs_0)
		{
			bool result;
			if (treeNode_5 == null)
			{
				result = false;
			}
			else
			{
				int num = treeNode_5.Bounds.X + treeNode_5.Bounds.Width;
				result = (treeNode_5 != null && mouseEventArgs_0.X < num);
			}
			return result;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x000CB138 File Offset: 0x000C9338
		public int method_26(TreeNode treeNode_5)
		{
			int num = 0;
			while ((treeNode_5 = treeNode_5.Parent) != null)
			{
				num++;
			}
			return num;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x000CB164 File Offset: 0x000C9364
		private bool method_27(TreeNode treeNode_5, TreeNode treeNode_6)
		{
			bool flag = false;
			bool result;
			for (TreeNode treeNode = treeNode_5; treeNode != null; treeNode = treeNode.Parent)
			{
				if (treeNode == treeNode_6)
				{
					result = true;
					return result;
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x000CB19C File Offset: 0x000C939C
		public TreeNode method_28(TreeNode treeNode_5)
		{
			TreeNode treeNode = treeNode_5;
			while (treeNode.Parent != null)
			{
				treeNode = treeNode.Parent;
			}
			return treeNode;
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x000CB1C8 File Offset: 0x000C93C8
		private int method_29()
		{
			int num = 0;
			for (TreeNode treeNode = base.Nodes[0]; treeNode != null; treeNode = treeNode.NextVisibleNode)
			{
				if (treeNode.IsVisible)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x000CB208 File Offset: 0x000C9408
		private TreeNode method_30()
		{
			TreeNode treeNode = base.Nodes[0];
			while (treeNode.NextVisibleNode != null)
			{
				treeNode = treeNode.NextVisibleNode;
			}
			return treeNode;
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x000CB23C File Offset: 0x000C943C
		private TreeNode method_31(TreeNode treeNode_5, bool bool_4, int int_1)
		{
			int i = 0;
			TreeNode treeNode = treeNode_5;
			while (i < int_1)
			{
				if (bool_4)
				{
					if (treeNode.NextVisibleNode == null)
					{
						break;
					}
					treeNode = treeNode.NextVisibleNode;
				}
				else
				{
					if (treeNode.PrevVisibleNode == null)
					{
						break;
					}
					treeNode = treeNode.PrevVisibleNode;
				}
				i++;
			}
			return treeNode;
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x000CB290 File Offset: 0x000C9490
		private void method_32(TreeNode treeNode_5, bool bool_4)
		{
			Graphics graphics = base.CreateGraphics();
			Rectangle rectangle = new Rectangle(treeNode_5.Bounds.X, treeNode_5.Bounds.Y, treeNode_5.Bounds.Width, treeNode_5.Bounds.Height);
			if (bool_4)
			{
				base.Invalidate(rectangle, false);
				base.Update();
				if (treeNode_5.BackColor != this.method_7())
				{
					graphics.DrawRectangle(new Pen(new SolidBrush(this.method_7()), 1f), rectangle);
				}
			}
			else
			{
				if (treeNode_5.BackColor != this.method_7())
				{
					graphics.DrawRectangle(new Pen(new SolidBrush(this.BackColor), 1f), this.treeNode_1.Bounds.X, this.treeNode_1.Bounds.Y, this.treeNode_1.Bounds.Width, this.treeNode_1.Bounds.Height);
				}
				base.Invalidate(rectangle, false);
				base.Update();
			}
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x00012ABB File Offset: 0x00010CBB
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.container_0 != null)
			{
				this.container_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x000CB3BC File Offset: 0x000C95BC
		protected override void OnMouseUp(MouseEventArgs e)
		{
			try
			{
				if (!this.bool_3)
				{
					TreeNode nodeAt = base.GetNodeAt(e.X, e.Y);
					if (this.method_25(nodeAt, e))
					{
						this.method_36(this.treeNode_1, nodeAt, e, Control.ModifierKeys, TreeViewAction.ByMouse, true);
					}
				}
				this.bool_3 = false;
				base.OnMouseUp(e);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.ToString());
			}
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x000CB438 File Offset: 0x000C9638
		private bool method_33(TreeNode treeNode_5, MouseEventArgs mouseEventArgs_0)
		{
			int num = this.method_26(treeNode_5);
			bool result = false;
			if (mouseEventArgs_0.X < 20 + num * 20)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x000CB468 File Offset: 0x000C9668
		protected override void OnMouseDown(MouseEventArgs e)
		{
			this.treeNode_4 = null;
			this.int_0 = e.Clicks;
			TreeNode nodeAt = base.GetNodeAt(e.X, e.Y);
			if (nodeAt != null)
			{
				this.method_20(nodeAt);
				if (!this.method_33(nodeAt, e) && nodeAt != null && this.method_25(nodeAt, e) && !this.method_19(nodeAt))
				{
					this.treeNode_3 = nodeAt;
					Thread thread = new Thread(new ThreadStart(this.method_34));
					thread.Start();
					this.bool_3 = true;
					this.method_36(this.treeNode_1, nodeAt, e, Control.ModifierKeys, TreeViewAction.ByMouse, true);
				}
				base.OnMouseDown(e);
			}
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x000CB510 File Offset: 0x000C9710
		private void method_34()
		{
			MethodInvoker methodInvoker = null;
			if (base.InvokeRequired)
			{
				if (methodInvoker == null)
				{
					methodInvoker = new MethodInvoker(this.method_37);
				}
				base.Invoke(methodInvoker);
			}
			else
			{
				TreeNode treeNode = this.treeNode_3;
				if (!this.method_19(treeNode))
				{
					treeNode.BackColor = this.method_7();
					treeNode.ForeColor = this.BackColor;
					base.Invalidate();
					this.Refresh();
					Application.DoEvents();
					Thread.Sleep(200);
				}
				if (!this.method_19(treeNode))
				{
					treeNode.BackColor = this.BackColor;
					treeNode.ForeColor = this.ForeColor;
				}
			}
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x000CB5B0 File Offset: 0x000C97B0
		private void method_35()
		{
			Thread.Sleep(200);
			if (!this.bool_2)
			{
				this.bool_0 = true;
				this.method_5(this.treeNode_0);
				this.bool_0 = false;
				this.treeNode_0.BeginEdit();
			}
			else
			{
				this.bool_2 = false;
			}
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x000CB600 File Offset: 0x000C9800
		private void method_36(TreeNode treeNode_5, TreeNode treeNode_6, MouseEventArgs mouseEventArgs_0, Keys keys_0, TreeViewAction treeViewAction_0, bool bool_4)
		{
			this.bool_1 = false;
			if (mouseEventArgs_0.Button == MouseButtons.Left)
			{
				this.bool_2 = (this.int_0 == 2);
				if ((keys_0 & Keys.Control) == Keys.None && (keys_0 & Keys.Shift) == Keys.None)
				{
					this.treeNode_2 = treeNode_6;
					int count = this.method_9().Count;
					if (this.bool_2)
					{
						base.OnMouseDown(mouseEventArgs_0);
						return;
					}
					if (!this.method_33(treeNode_6, mouseEventArgs_0))
					{
						bool flag = false;
						if (this.method_19(treeNode_6))
						{
							flag = true;
						}
						this.method_18(treeNode_6, treeViewAction_0);
						this.method_21(treeNode_6, true, treeViewAction_0);
						if (flag && base.LabelEdit && bool_4 && !this.bool_2 && count <= 1)
						{
							this.treeNode_0 = treeNode_6;
							Thread thread = new Thread(new ThreadStart(this.method_35));
							thread.Start();
						}
					}
				}
				else if ((keys_0 & Keys.Control) != Keys.None && (keys_0 & Keys.Shift) == Keys.None)
				{
					this.treeNode_2 = null;
					if (!this.method_19(treeNode_6))
					{
						switch (this.enum145_0)
						{
						case Enum145.const_0:
							this.method_18(treeNode_6, treeViewAction_0);
							break;
						case Enum145.const_2:
						{
							TreeNode treeNode_7 = this.method_28(treeNode_6);
							this.method_17(treeNode_7, treeViewAction_0);
							break;
						}
						case Enum145.const_3:
							this.method_15(this.method_26(treeNode_6), treeViewAction_0);
							break;
						case Enum145.const_4:
						{
							TreeNode treeNode = this.method_28(treeNode_6);
							this.method_17(treeNode, treeViewAction_0);
							this.method_15(this.method_26(treeNode_6), treeViewAction_0);
							break;
						}
						case Enum145.const_5:
						{
							TreeNode parent = treeNode_6.Parent;
							this.method_16(parent, treeViewAction_0);
							break;
						}
						}
						this.method_21(treeNode_6, true, treeViewAction_0);
					}
					else
					{
						this.method_21(treeNode_6, false, treeViewAction_0);
					}
				}
				else if ((keys_0 & Keys.Control) == Keys.None && (keys_0 & Keys.Shift) != Keys.None)
				{
					if (treeNode_5 == null)
					{
						this.method_18(treeNode_6, treeViewAction_0);
						this.method_21(treeNode_6, true, treeViewAction_0);
					}
					else
					{
						if (this.treeNode_2 == null)
						{
							this.treeNode_2 = treeNode_5;
						}
						switch (this.enum145_0)
						{
						case Enum145.const_0:
							this.method_18(treeNode_6, treeViewAction_0);
							this.method_21(treeNode_6, true, treeViewAction_0);
							break;
						case Enum145.const_1:
							this.method_22(this.treeNode_2, treeNode_6, treeViewAction_0);
							this.method_23(this.treeNode_2, treeNode_6, treeViewAction_0);
							break;
						case Enum145.const_2:
						{
							TreeNode treeNode2 = this.method_28(treeNode_5);
							TreeNode treeNode3 = treeNode_5;
							while (treeNode3 != null && treeNode3 != treeNode_6)
							{
								if (treeNode_5.Bounds.Y > treeNode_6.Bounds.Y)
								{
									treeNode3 = treeNode3.PrevVisibleNode;
								}
								else
								{
									treeNode3 = treeNode3.NextVisibleNode;
								}
								if (treeNode3 != null)
								{
									TreeNode treeNode = this.method_28(treeNode3);
									if (treeNode == treeNode2)
									{
										this.method_21(treeNode3, true, treeViewAction_0);
									}
								}
							}
							this.method_17(treeNode2, treeViewAction_0);
							this.method_23(this.treeNode_2, treeNode_6, treeViewAction_0);
							break;
						}
						case Enum145.const_3:
						{
							int num = this.method_26(treeNode_5);
							TreeNode treeNode3 = treeNode_5;
							while (treeNode3 != null && treeNode3 != treeNode_6)
							{
								if (treeNode_5.Bounds.Y > treeNode_6.Bounds.Y)
								{
									treeNode3 = treeNode3.PrevVisibleNode;
								}
								else
								{
									treeNode3 = treeNode3.NextVisibleNode;
								}
								if (treeNode3 != null)
								{
									int num2 = this.method_26(treeNode3);
									if (num2 == num)
									{
										this.method_21(treeNode3, true, treeViewAction_0);
									}
								}
							}
							this.method_15(num, treeViewAction_0);
							this.method_23(this.treeNode_2, treeNode_6, treeViewAction_0);
							break;
						}
						case Enum145.const_4:
						{
							TreeNode treeNode4 = this.method_28(treeNode_5);
							int num = this.method_26(treeNode_5);
							TreeNode treeNode3 = treeNode_5;
							while (treeNode3 != null && treeNode3 != treeNode_6)
							{
								if (treeNode_5.Bounds.Y > treeNode_6.Bounds.Y)
								{
									treeNode3 = treeNode3.PrevVisibleNode;
								}
								else
								{
									treeNode3 = treeNode3.NextVisibleNode;
								}
								if (treeNode3 != null)
								{
									int num2 = this.method_26(treeNode3);
									TreeNode treeNode = this.method_28(treeNode3);
									if (num2 == num && treeNode == treeNode4)
									{
										this.method_21(treeNode3, true, treeViewAction_0);
									}
								}
							}
							this.method_17(treeNode4, treeViewAction_0);
							this.method_15(num, treeViewAction_0);
							this.method_23(this.treeNode_2, treeNode_6, treeViewAction_0);
							break;
						}
						case Enum145.const_5:
						{
							TreeNode parent2 = treeNode_5.Parent;
							TreeNode treeNode3 = treeNode_5;
							while (treeNode3 != null && treeNode3 != treeNode_6)
							{
								if (treeNode_5.Bounds.Y > treeNode_6.Bounds.Y)
								{
									treeNode3 = treeNode3.PrevVisibleNode;
								}
								else
								{
									treeNode3 = treeNode3.NextVisibleNode;
								}
								if (treeNode3 != null)
								{
									TreeNode parent = treeNode3.Parent;
									if (parent == parent2)
									{
										this.method_21(treeNode3, true, treeViewAction_0);
									}
								}
							}
							this.method_16(parent2, treeViewAction_0);
							this.method_23(this.treeNode_2, treeNode_6, treeViewAction_0);
							break;
						}
						}
					}
				}
				else if ((keys_0 & Keys.Control) != Keys.None && (keys_0 & Keys.Shift) != Keys.None)
				{
					switch (this.enum145_0)
					{
					case Enum145.const_0:
						this.method_18(treeNode_6, treeViewAction_0);
						this.method_21(treeNode_6, true, treeViewAction_0);
						break;
					case Enum145.const_1:
					{
						TreeNode treeNode3 = treeNode_5;
						while (treeNode3 != null && treeNode3 != treeNode_6)
						{
							if (treeNode_5.Bounds.Y > treeNode_6.Bounds.Y)
							{
								treeNode3 = treeNode3.PrevVisibleNode;
							}
							else
							{
								treeNode3 = treeNode3.NextVisibleNode;
							}
							if (treeNode3 != null)
							{
								this.method_21(treeNode3, true, treeViewAction_0);
							}
						}
						break;
					}
					case Enum145.const_2:
					{
						TreeNode treeNode2 = this.method_28(treeNode_5);
						TreeNode treeNode3 = treeNode_5;
						while (treeNode3 != null && treeNode3 != treeNode_6)
						{
							if (treeNode_5.Bounds.Y > treeNode_6.Bounds.Y)
							{
								treeNode3 = treeNode3.PrevVisibleNode;
							}
							else
							{
								treeNode3 = treeNode3.NextVisibleNode;
							}
							if (treeNode3 != null)
							{
								TreeNode treeNode = this.method_28(treeNode3);
								if (treeNode == treeNode2)
								{
									this.method_21(treeNode3, true, treeViewAction_0);
								}
							}
						}
						this.method_17(treeNode2, treeViewAction_0);
						break;
					}
					case Enum145.const_3:
					{
						int num = this.method_26(treeNode_5);
						TreeNode treeNode3 = treeNode_5;
						while (treeNode3 != null && treeNode3 != treeNode_6)
						{
							if (treeNode_5.Bounds.Y > treeNode_6.Bounds.Y)
							{
								treeNode3 = treeNode3.PrevVisibleNode;
							}
							else
							{
								treeNode3 = treeNode3.NextVisibleNode;
							}
							if (treeNode3 != null)
							{
								int num2 = this.method_26(treeNode3);
								if (num2 == num)
								{
									this.method_21(treeNode3, true, treeViewAction_0);
								}
							}
						}
						this.method_15(num, treeViewAction_0);
						break;
					}
					case Enum145.const_4:
					{
						TreeNode treeNode4 = this.method_28(treeNode_5);
						int num = this.method_26(treeNode_5);
						TreeNode treeNode3 = treeNode_5;
						while (treeNode3 != null && treeNode3 != treeNode_6)
						{
							if (treeNode_5.Bounds.Y > treeNode_6.Bounds.Y)
							{
								treeNode3 = treeNode3.PrevVisibleNode;
							}
							else
							{
								treeNode3 = treeNode3.NextVisibleNode;
							}
							if (treeNode3 != null)
							{
								int num2 = this.method_26(treeNode3);
								TreeNode treeNode = this.method_28(treeNode3);
								if (num2 == num && treeNode == treeNode4)
								{
									this.method_21(treeNode3, true, treeViewAction_0);
								}
							}
						}
						this.method_17(treeNode4, treeViewAction_0);
						this.method_15(num, treeViewAction_0);
						break;
					}
					case Enum145.const_5:
					{
						TreeNode parent2 = treeNode_5.Parent;
						TreeNode treeNode3 = treeNode_5;
						while (treeNode3 != null && treeNode3 != treeNode_6)
						{
							if (treeNode_5.Bounds.Y > treeNode_6.Bounds.Y)
							{
								treeNode3 = treeNode3.PrevVisibleNode;
							}
							else
							{
								treeNode3 = treeNode3.NextVisibleNode;
							}
							if (treeNode3 != null)
							{
								TreeNode parent = treeNode3.Parent;
								if (parent == parent2)
								{
									this.method_21(treeNode3, true, treeViewAction_0);
								}
							}
						}
						this.method_16(parent2, treeViewAction_0);
						break;
					}
					}
				}
			}
			else if (mouseEventArgs_0.Button == MouseButtons.Right && !this.method_19(treeNode_6))
			{
				this.method_14(treeViewAction_0);
				this.method_21(treeNode_6, true, treeViewAction_0);
			}
			this.method_4();
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00012AE0 File Offset: 0x00010CE0
		protected override void OnBeforeLabelEdit(NodeLabelEditEventArgs e)
		{
			this.bool_1 = false;
			this.method_21(e.Node, true, TreeViewAction.ByMouse);
			this.method_18(e.Node, TreeViewAction.ByMouse);
			this.method_4();
			base.OnBeforeLabelEdit(e);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x000CBEC4 File Offset: 0x000CA0C4
		protected override void OnKeyDown(KeyEventArgs e)
		{
			Keys keys_ = Keys.None;
			Keys modifiers = e.Modifiers;
			if (modifiers != Keys.Shift && modifiers != Keys.Control && modifiers != (Keys.Shift | Keys.Control))
			{
				this.treeNode_4 = null;
			}
			else
			{
				keys_ = Keys.Shift;
				if (this.treeNode_4 == null)
				{
					this.treeNode_4 = this.treeNode_1;
				}
			}
			int num = 0;
			TreeNode treeNode = null;
			switch (e.KeyCode)
			{
			case Keys.Prior:
				num = this.method_29();
				treeNode = this.method_31(this.treeNode_1, false, num);
				break;
			case Keys.Next:
				num = this.method_29();
				treeNode = this.method_31(this.treeNode_1, true, num);
				break;
			case Keys.End:
				treeNode = this.method_30();
				break;
			case Keys.Home:
				treeNode = base.Nodes[0];
				break;
			case Keys.Left:
				if (this.treeNode_1.IsExpanded)
				{
					this.treeNode_1.Collapse();
				}
				else
				{
					treeNode = this.treeNode_1.Parent;
				}
				break;
			case Keys.Up:
				treeNode = this.treeNode_1.PrevVisibleNode;
				break;
			case Keys.Right:
				if (!this.treeNode_1.IsExpanded)
				{
					this.treeNode_1.Expand();
				}
				else if (this.treeNode_1.Nodes != null)
				{
					treeNode = this.treeNode_1.Nodes[0];
				}
				break;
			case Keys.Down:
				treeNode = this.treeNode_1.NextVisibleNode;
				break;
			default:
				base.OnKeyDown(e);
				return;
			}
			if (treeNode != null)
			{
				this.method_32(this.treeNode_1, false);
				this.method_36(this.treeNode_4, treeNode, new MouseEventArgs(MouseButtons.Left, 1, Cursor.Position.X, Cursor.Position.Y, 0), keys_, TreeViewAction.ByKeyboard, false);
				this.treeNode_1 = treeNode;
				this.method_32(this.treeNode_1, true);
			}
			if (this.treeNode_1 != null)
			{
				TreeNode treeNode2 = null;
				switch (e.KeyCode)
				{
				case Keys.Prior:
					treeNode2 = this.method_31(this.treeNode_1, false, num - 2);
					break;
				case Keys.Next:
					treeNode2 = this.method_31(this.treeNode_1, true, num - 2);
					break;
				case Keys.End:
				case Keys.Home:
					treeNode2 = this.treeNode_1;
					break;
				case Keys.Left:
				case Keys.Up:
					treeNode2 = this.method_31(this.treeNode_1, false, 5);
					break;
				case Keys.Right:
				case Keys.Down:
					treeNode2 = this.method_31(this.treeNode_1, true, 5);
					break;
				}
				if (treeNode2 != null)
				{
					treeNode2.EnsureVisible();
				}
			}
			base.OnKeyDown(e);
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000CC148 File Offset: 0x000CA348
		protected override void OnAfterCollapse(TreeViewEventArgs e)
		{
			this.bool_1 = false;
			bool flag = false;
			foreach (TreeNode treeNode_ in e.Node.Nodes)
			{
				if (this.method_19(treeNode_))
				{
					flag = true;
				}
				this.method_24(treeNode_, TreeViewAction.Collapse);
			}
			if (flag)
			{
				this.method_21(e.Node, true, TreeViewAction.Collapse);
			}
			this.method_4();
			base.OnAfterCollapse(e);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00012B12 File Offset: 0x00010D12
		protected override void OnItemDrag(ItemDragEventArgs e)
		{
			e = new ItemDragEventArgs(MouseButtons.Left, this.method_9());
			base.OnItemDrag(e);
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x00012B2D File Offset: 0x00010D2D
		[CompilerGenerated]
		private void method_37()
		{
			this.method_34();
		}

		// Token: 0x04000E27 RID: 3623
		private TreeViewEventHandler treeViewEventHandler_0;

		// Token: 0x04000E28 RID: 3624
		private TreeViewEventHandler treeViewEventHandler_1;

		// Token: 0x04000E29 RID: 3625
		private EventHandler eventHandler_0;

		// Token: 0x04000E2A RID: 3626
		private Container container_0 = null;

		// Token: 0x04000E2B RID: 3627
		private bool bool_0 = false;

		// Token: 0x04000E2C RID: 3628
		private Hashtable hashtable_0 = new Hashtable();

		// Token: 0x04000E2D RID: 3629
		private bool bool_1 = false;

		// Token: 0x04000E2E RID: 3630
		private Hashtable hashtable_1 = new Hashtable();

		// Token: 0x04000E2F RID: 3631
		private TreeNode treeNode_0 = null;

		// Token: 0x04000E30 RID: 3632
		private bool bool_2 = false;

		// Token: 0x04000E31 RID: 3633
		private TreeNode treeNode_1 = null;

		// Token: 0x04000E32 RID: 3634
		private TreeNode treeNode_2 = null;

		// Token: 0x04000E33 RID: 3635
		private int int_0 = 0;

		// Token: 0x04000E34 RID: 3636
		private Enum145 enum145_0 = Enum145.const_0;

		// Token: 0x04000E35 RID: 3637
		private Color color_0 = SystemColors.Highlight;

		// Token: 0x04000E36 RID: 3638
		private bool bool_3 = false;

		// Token: 0x04000E37 RID: 3639
		private TreeNode treeNode_3 = null;

		// Token: 0x04000E38 RID: 3640
		private TreeNode treeNode_4 = null;
	}
}

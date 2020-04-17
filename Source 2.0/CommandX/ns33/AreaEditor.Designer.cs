using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;

namespace ns33
{
	// Token: 0x02000974 RID: 2420
	[DesignerGenerated]
	public sealed class AreaEditor : UserControl
	{
		// Token: 0x06003B80 RID: 15232 RVA: 0x0001F8DA File Offset: 0x0001DADA
		public AreaEditor()
		{
			base.Load += new EventHandler(this.AreaEditor_Load);
			this.InitializeComponent();
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x00126460 File Offset: 0x00124660
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x001264A4 File Offset: 0x001246A4
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AreaEditor));
			this.vmethod_1(new GroupBox());
			this.vmethod_15(new Button());
			this.vmethod_13(new Button());
			this.vmethod_11(new Button());
			this.vmethod_9(new Button());
			this.vmethod_7(new Button());
			this.vmethod_5(new Button());
			this.vmethod_3(new ListBox());
			this.vmethod_0().SuspendLayout();
			base.SuspendLayout();
			this.vmethod_0().Controls.Add(this.vmethod_14());
			this.vmethod_0().Controls.Add(this.vmethod_12());
			this.vmethod_0().Controls.Add(this.vmethod_10());
			this.vmethod_0().Controls.Add(this.vmethod_8());
			this.vmethod_0().Controls.Add(this.vmethod_6());
			this.vmethod_0().Controls.Add(this.vmethod_4());
			this.vmethod_0().Controls.Add(this.vmethod_2());
			this.vmethod_0().Dock = DockStyle.Fill;
			this.vmethod_0().Location = new Point(0, 0);
			this.vmethod_0().Name = "GroupBox1";
			this.vmethod_0().Size = new Size(351, 124);
			this.vmethod_0().TabIndex = 0;
			this.vmethod_0().TabStop = false;
			this.vmethod_0().Text = "标题";
			this.vmethod_14().Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_14().Location = new Point(223, 99);
			this.vmethod_14().Name = "Button1";
			this.vmethod_14().Size = new Size(125, 22);
			this.vmethod_14().TabIndex = 6;
			this.vmethod_14().Text = "验证区域";
			this.vmethod_14().UseVisualStyleBackColor = true;
			this.vmethod_12().Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_12().Location = new Point(223, 65);
			this.vmethod_12().Name = "Button_HighLightCenterOnSelected";
			this.vmethod_12().Size = new Size(125, 34);
			this.vmethod_12().TabIndex = 5;
			this.vmethod_12().Text = "将列表中选择参考点置中显示";
			this.vmethod_12().UseVisualStyleBackColor = true;
			this.vmethod_10().Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_10().Location = new Point(223, 43);
			this.vmethod_10().Name = "Button_RemoveSelected";
			this.vmethod_10().Size = new Size(125, 22);
			this.vmethod_10().TabIndex = 4;
			this.vmethod_10().Text = "删除列表里中选择参考点";
			this.vmethod_10().UseVisualStyleBackColor = true;
			//ZSP ERR IMG this.vmethod_8().Image = (Image)componentResourceManager.GetObject("Button_ListDown.Image");
			this.vmethod_8().Location = new Point(178, 49);
			this.vmethod_8().Name = "Button_ListDown";
			this.vmethod_8().Size = new Size(27, 24);
			this.vmethod_8().TabIndex = 3;
			this.vmethod_8().UseVisualStyleBackColor = true;
            //ZSP ERR IMG this.vmethod_6().Image = (Image)componentResourceManager.GetObject("Button_ListUp.Image");
            this.vmethod_6().Location = new Point(178, 19);
			this.vmethod_6().Name = "Button_ListUp";
			this.vmethod_6().Size = new Size(27, 24);
			this.vmethod_6().TabIndex = 2;
			this.vmethod_6().UseVisualStyleBackColor = true;
			this.vmethod_4().Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 161);
			this.vmethod_4().Location = new Point(223, 8);
			this.vmethod_4().Name = "Button_AddHighlighted";
			this.vmethod_4().Size = new Size(125, 35);
			this.vmethod_4().TabIndex = 1;
			this.vmethod_4().Text = "添加地图中选择的参考点";
			this.vmethod_4().UseVisualStyleBackColor = true;
			this.vmethod_2().DisplayMember = "Name";
			this.vmethod_2().FormattingEnabled = true;
			this.vmethod_2().Location = new Point(6, 19);
			this.vmethod_2().Name = "ListBox1";
			this.vmethod_2().SelectionMode = SelectionMode.MultiExtended;
			this.vmethod_2().Size = new Size(166, 95);
			this.vmethod_2().TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.vmethod_0());
			base.Name = "AreaEditor";
			base.Size = new Size(351, 124);
			this.vmethod_0().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x001269E8 File Offset: 0x00124BE8
		[CompilerGenerated]
		internal  GroupBox vmethod_0()
		{
			return this.groupBox_0;
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x0001F8FA File Offset: 0x0001DAFA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(GroupBox groupBox_1)
		{
			this.groupBox_0 = groupBox_1;
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x00126A00 File Offset: 0x00124C00
		[CompilerGenerated]
		internal  ListBox vmethod_2()
		{
			return this.listBox_0;
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x0001F903 File Offset: 0x0001DB03
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ListBox listBox_1)
		{
			this.listBox_0 = listBox_1;
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x00126A18 File Offset: 0x00124C18
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_0;
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x00126A30 File Offset: 0x00124C30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_6)
		{
			EventHandler value = new EventHandler(this.method_3);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_6;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x00126A7C File Offset: 0x00124C7C
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_1;
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x00126A94 File Offset: 0x00124C94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_6)
		{
			EventHandler value = new EventHandler(this.method_5);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_6;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x00126AE0 File Offset: 0x00124CE0
		[CompilerGenerated]
		internal  Button vmethod_8()
		{
			return this.button_2;
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x00126AF8 File Offset: 0x00124CF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_6)
		{
			EventHandler value = new EventHandler(this.method_6);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_6;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x00126B44 File Offset: 0x00124D44
		[CompilerGenerated]
		internal  Button vmethod_10()
		{
			return this.button_3;
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x00126B5C File Offset: 0x00124D5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Button button_6)
		{
			EventHandler value = new EventHandler(this.method_4);
			Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_6;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x00126BA8 File Offset: 0x00124DA8
		[CompilerGenerated]
		internal  Button vmethod_12()
		{
			return this.button_4;
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x00126BC0 File Offset: 0x00124DC0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_6)
		{
			EventHandler value = new EventHandler(this.method_7);
			Button button = this.button_4;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_4 = button_6;
			button = this.button_4;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x00126C0C File Offset: 0x00124E0C
		[CompilerGenerated]
		internal  Button vmethod_14()
		{
			return this.button_5;
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x00126C24 File Offset: 0x00124E24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Button button_6)
		{
			EventHandler value = new EventHandler(this.method_8);
			Button button = this.button_5;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_5 = button_6;
			button = this.button_5;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x0001F90C File Offset: 0x0001DB0C
		public void method_0(string string_1)
		{
			this.string_0 = string_1;
			this.vmethod_0().Text = string_1;
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x0001F921 File Offset: 0x0001DB21
		public void method_1()
		{
			this.method_2();
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x00126C70 File Offset: 0x00124E70
		private void method_2()
		{
			if (!Information.IsNothing(this.list_0))
			{
				this.vmethod_2().Items.Clear();
				foreach (ReferencePoint current in this.list_0)
				{
					TreeNode treeNode = new TreeNode();
					treeNode.Name = current.Name;
					treeNode.Tag = current;
					this.vmethod_2().Items.Add(treeNode);
				}
			}
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x00126D04 File Offset: 0x00124F04
		private void method_3(object sender, EventArgs e)
		{
			foreach (ReferencePoint current in Client.GetClientSide().GetReferencePoints())
			{
				if (current.IsSelected() && !Information.IsNothing(this.list_0) && !this.list_0.Contains(current))
				{
					TreeNode treeNode = new TreeNode();
					this.list_0.Add(current);
					treeNode.Name = current.Name;
					treeNode.Tag = current;
					this.vmethod_2().Items.Add(treeNode);
				}
			}
			Client.b_Completed = true;
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x00126DB8 File Offset: 0x00124FB8
		private void method_4(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.list_0))
			{
				IEnumerator enumerator = this.vmethod_2().SelectedItems.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						TreeNode treeNode = (TreeNode)enumerator.Current;
						this.list_0.Remove((ReferencePoint)treeNode.Tag);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.method_2();
				Client.b_Completed = true;
			}
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x00126E4C File Offset: 0x0012504C
		private void method_5(object sender, EventArgs e)
		{
			if (this.vmethod_2().SelectedItems.Count > 1)
			{
				Interaction.MsgBox("Only one reference point can be re-arranged at a time", MsgBoxStyle.OkOnly, "One point a time!");
			}
			else
			{
				int num = this.vmethod_2().SelectedIndex;
				if (num != -1 && num > 0)
				{
					TreeNode item = (TreeNode)this.vmethod_2().Items[num];
					ReferencePoint item2 = this.list_0[num];
					this.vmethod_2().Items.RemoveAt(num);
					this.list_0.RemoveAt(num);
					num--;
					this.list_0.Insert(num, item2);
					this.vmethod_2().Items.Insert(num, item);
					this.vmethod_2().SelectedIndex = num;
					Client.b_Completed = true;
				}
			}
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x00126F1C File Offset: 0x0012511C
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_2().SelectedItems.Count > 1)
			{
				Interaction.MsgBox("Only one reference point can be re-arranged at a time", MsgBoxStyle.OkOnly, "One point a time!");
			}
			else
			{
				int num = this.vmethod_2().SelectedIndex;
				if (num != -1 && num < this.vmethod_2().Items.Count - 1)
				{
					TreeNode item = (TreeNode)this.vmethod_2().Items[num];
					ReferencePoint item2 = this.list_0[num];
					this.vmethod_2().Items.RemoveAt(num);
					this.list_0.RemoveAt(num);
					num++;
					this.list_0.Insert(num, item2);
					this.vmethod_2().Items.Insert(num, item);
					this.vmethod_2().SelectedIndex = num;
					Client.b_Completed = true;
				}
			}
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x00126FFC File Offset: 0x001251FC
		private void method_7(object sender, EventArgs e)
		{
			List<ReferencePoint> list = new List<ReferencePoint>();
			if (!Information.IsNothing(this.list_0))
			{
				IEnumerator enumerator = this.vmethod_2().SelectedItems.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						TreeNode treeNode = (TreeNode)enumerator.Current;
						list.Add((ReferencePoint)treeNode.Tag);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				int count = list.Count;
				if (count != 0)
				{
					if (count == 1)
					{
						CommandFactory.GetCommandMain().GetMainForm().method_14(true, list[0]);
					}
					else
					{
						GeoPoint value = Misc.smethod_51(list);
						CommandFactory.GetCommandMain().GetMainForm().method_14(true, value);
					}
					using (List<ReferencePoint>.Enumerator enumerator2 = list.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.SetIsSelected(true);
						}
					}
					Client.b_Completed = true;
				}
			}
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x00127110 File Offset: 0x00125310
		private void method_8(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.list_0))
			{
				string prompt = "";
				if (!ActiveUnit_Navigator.smethod_6(ref this.list_0, ref prompt, "", ""))
				{
					Interaction.MsgBox(prompt, MsgBoxStyle.OkOnly, null);
				}
				else
				{
					Interaction.MsgBox("区域验证有效！", MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void AreaEditor_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001B30 RID: 6960
		private IContainer icontainer_0;

		// Token: 0x04001B31 RID: 6961
		[CompilerGenerated]
		private GroupBox groupBox_0;

		// Token: 0x04001B32 RID: 6962
		[CompilerGenerated]
		private ListBox listBox_0;

		// Token: 0x04001B33 RID: 6963
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001B34 RID: 6964
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001B35 RID: 6965
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04001B36 RID: 6966
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x04001B37 RID: 6967
		[CompilerGenerated]
		private Button button_4;

		// Token: 0x04001B38 RID: 6968
		[CompilerGenerated]
		private Button button_5;

		// Token: 0x04001B39 RID: 6969
		public List<ReferencePoint> list_0;

		// Token: 0x04001B3A RID: 6970
		private string string_0;
	}
}

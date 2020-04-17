using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using ns32;
using ns33;
using ns35;

namespace ns34
{
	// Token: 0x020009A0 RID: 2464
	[DesignerGenerated]
	public sealed partial class LoadGroup : CommandForm
	{
		// Token: 0x06003FD3 RID: 16339 RVA: 0x00158108 File Offset: 0x00156308
		public LoadGroup()
		{
			base.FormClosing += new FormClosingEventHandler(this.LoadGroup_FormClosing);
			base.Load += new EventHandler(this.LoadGroup_Load);
			base.VisibleChanged += new EventHandler(this.LoadGroup_VisibleChanged);
			base.KeyDown += new KeyEventHandler(this.LoadGroup_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x00158B44 File Offset: 0x00156D44
		[CompilerGenerated]
		internal  TreeView vmethod_0()
		{
			return this.treeView_0;
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x00158B5C File Offset: 0x00156D5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TreeView treeView_1)
		{
			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.method_3);
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

		// Token: 0x06003FD8 RID: 16344 RVA: 0x00158BA8 File Offset: 0x00156DA8
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x06003FD9 RID: 16345 RVA: 0x00020BD2 File Offset: 0x0001EDD2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_9)
		{
			this.label_0 = label_9;
		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x00158BC0 File Offset: 0x00156DC0
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_1;
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x00020BDB File Offset: 0x0001EDDB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_9)
		{
			this.label_1 = label_9;
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x00158BD8 File Offset: 0x00156DD8
		[CompilerGenerated]
		internal  Label vmethod_6()
		{
			return this.label_2;
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x00020BE4 File Offset: 0x0001EDE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Label label_9)
		{
			this.label_2 = label_9;
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x00158BF0 File Offset: 0x00156DF0
		[CompilerGenerated]
		internal  Label vmethod_8()
		{
			return this.label_3;
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x00020BED File Offset: 0x0001EDED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Label label_9)
		{
			this.label_3 = label_9;
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x00158C08 File Offset: 0x00156E08
		[CompilerGenerated]
		internal  Label vmethod_10()
		{
			return this.label_4;
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x00020BF6 File Offset: 0x0001EDF6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_9)
		{
			this.label_4 = label_9;
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x00158C20 File Offset: 0x00156E20
		[CompilerGenerated]
		internal  Label vmethod_12()
		{
			return this.label_5;
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x00020BFF File Offset: 0x0001EDFF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Label label_9)
		{
			this.label_5 = label_9;
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x00158C38 File Offset: 0x00156E38
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_6;
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x00020C08 File Offset: 0x0001EE08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_9)
		{
			this.label_6 = label_9;
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x00158C50 File Offset: 0x00156E50
		[CompilerGenerated]
		internal  FlowLayoutPanel vmethod_16()
		{
			return this.flowLayoutPanel_0;
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x00020C11 File Offset: 0x0001EE11
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(FlowLayoutPanel flowLayoutPanel_1)
		{
			this.flowLayoutPanel_0 = flowLayoutPanel_1;
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x00158C68 File Offset: 0x00156E68
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_7;
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x00020C1A File Offset: 0x0001EE1A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_9)
		{
			this.label_7 = label_9;
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x00158C80 File Offset: 0x00156E80
		[CompilerGenerated]
		internal  Label vmethod_20()
		{
			return this.label_8;
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x00020C23 File Offset: 0x0001EE23
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Label label_9)
		{
			this.label_8 = label_9;
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x00158C98 File Offset: 0x00156E98
		[CompilerGenerated]
		internal  ListView vmethod_22()
		{
			return this.listView_0;
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x00020C2C File Offset: 0x0001EE2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(ListView listView_1)
		{
			this.listView_0 = listView_1;
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x00158CB0 File Offset: 0x00156EB0
		[CompilerGenerated]
		internal  Button vmethod_24()
		{
			return this.button_0;
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x00158CC8 File Offset: 0x00156EC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_6);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_2;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x00158D14 File Offset: 0x00156F14
		[CompilerGenerated]
		internal  Button vmethod_26()
		{
			return this.button_1;
		}

		// Token: 0x06003FF1 RID: 16369 RVA: 0x00158D2C File Offset: 0x00156F2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_4);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_2;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06003FF2 RID: 16370 RVA: 0x00158D78 File Offset: 0x00156F78
		[CompilerGenerated]
		internal  ToolStrip vmethod_28()
		{
			return this.toolStrip_0;
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x00020C35 File Offset: 0x0001EE35
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x00158D90 File Offset: 0x00156F90
		[CompilerGenerated]
		internal  ToolStripLabel vmethod_30()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x00020C3E File Offset: 0x0001EE3E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(ToolStripLabel toolStripLabel_1)
		{
			this.toolStripLabel_0 = toolStripLabel_1;
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x00158DA8 File Offset: 0x00156FA8
		[CompilerGenerated]
		internal  CheckBox vmethod_32()
		{
			return this.checkBox_0;
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x00020C47 File Offset: 0x0001EE47
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(CheckBox checkBox_1)
		{
			this.checkBox_0 = checkBox_1;
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x00020C50 File Offset: 0x0001EE50
		private void LoadGroup_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x00020C71 File Offset: 0x0001EE71
		private void LoadGroup_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.method_1();
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x00158DC0 File Offset: 0x00156FC0
		private void method_1()
		{
			TreeNode treeNode = this.vmethod_0().Nodes.Add("Main");
			treeNode.Tag = "";
			this.method_2(ref treeNode, Application.StartupPath + "\\ImportExport");
			this.vmethod_30().Visible = false;
		}

		// Token: 0x06003FFB RID: 16379 RVA: 0x00158E14 File Offset: 0x00157014
		private void method_2(ref TreeNode treeNode_0, string string_0)
		{
			TreeNode treeNode = treeNode_0.Nodes.Add(Path.GetFullPath(string_0), Path.GetFileName(string_0));
			treeNode.Tag = string_0;
			string[] directories = Directory.GetDirectories(string_0);
			checked
			{
				for (int i = 0; i < directories.Length; i++)
				{
					string string_ = directories[i];
					this.method_2(ref treeNode, string_);
				}
				string[] files = Directory.GetFiles(string_0);
				for (int j = 0; j < files.Length; j++)
				{
					string text = files[j];
					treeNode.Nodes.Add(Path.GetFullPath(text), Path.GetFileName(text)).Tag = text;
				}
			}
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x00158EAC File Offset: 0x001570AC
		private void method_3(object sender, TreeNodeMouseClickEventArgs e)
		{
			try
			{
				if (Conversions.ToString(e.Node.Tag).Contains(".inst"))
				{
					this.vmethod_22().Clear();
					StreamReader streamReader = new StreamReader(Conversions.ToString(e.Node.Tag));
					using (streamReader)
					{
						string text = streamReader.ReadToEnd().Replace("\\\"", "");
						text = text.Replace("\\", "/");
						this.importExportRecord_0 = (ImportExportRecord)JsonConvert.DeserializeObject(text, typeof(ImportExportRecord));
					}
					if (this.importExportRecord_0.DB_ID != Client.GetDBRecord().DBID && !this.vmethod_32().Checked)
					{
						this.vmethod_4().Text = "CANNOT USE - INCOMPATIBLE DB";
						e.Node.Checked = false;
						goto IL_2E4;
					}
					this.vmethod_4().Text = this.importExportRecord_0.Name;
					this.vmethod_10().Text = this.importExportRecord_0.ValidFrom;
					this.vmethod_12().Text = this.importExportRecord_0.ValidUntil;
					this.vmethod_18().Text = this.importExportRecord_0.Comments;
					using (IEnumerator<ImportExportRecord.MemberRecord> enumerator = this.importExportRecord_0.MemberRecords.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							ImportExportRecord.MemberRecord current = enumerator.Current;
							ListViewItem value = new ListViewItem(current.MemberName);
							this.vmethod_22().Items.Add(value);
						}
						goto IL_2E4;
					}
				}
				if (e.Node.Checked)
				{
					IEnumerator enumerator2 = e.Node.Nodes.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							TreeNode treeNode = (TreeNode)enumerator2.Current;
							StreamReader streamReader3 = new StreamReader(Conversions.ToString(treeNode.Tag));
							using (streamReader3)
							{
								string text2 = streamReader3.ReadToEnd().Replace("\\\"", "");
								text2 = text2.Replace("\\", "/");
								this.importExportRecord_0 = (ImportExportRecord)JsonConvert.DeserializeObject(text2, typeof(ImportExportRecord));
							}
							if (this.importExportRecord_0.DB_ID != Client.GetDBRecord().DBID && !this.vmethod_32().Checked)
							{
								treeNode.Checked = false;
							}
							else
							{
								treeNode.Checked = true;
							}
						}
						goto IL_2E4;
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
				IEnumerator enumerator3 = e.Node.Nodes.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						((TreeNode)enumerator3.Current).Checked = false;
					}
				}
				finally
				{
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				IL_2E4:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200272", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_4(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x00159278 File Offset: 0x00157478
		private void method_5(ref TreeNode treeNode_0)
		{
			IEnumerator enumerator = treeNode_0.Nodes.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator.Current;
					if (Conversions.ToString(treeNode.Tag).Contains(".inst"))
					{
						if (treeNode.Checked)
						{
							this.vmethod_30().Visible = true;
							this.vmethod_30().Text = "加载: " + treeNode.Text;
							Application.DoEvents();
							Client.GetClientScenario().ImportUnits(Conversions.ToString(treeNode.Tag), Client.GetClientSide());
							CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
						}
					}
					else
					{
						this.method_5(ref treeNode);
					}
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

		// Token: 0x06003FFF RID: 16383 RVA: 0x00159360 File Offset: 0x00157560
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_0().Nodes.Count != 0)
			{
				TreeNodeCollection nodes;
				TreeNode value = (nodes = this.vmethod_0().Nodes)[0];
				this.method_5(ref value);
				nodes[0] = value;
				this.vmethod_30().Text = "完毕!";
				foreach (TreeNode current in Class2529.smethod_5(this.vmethod_0()))
				{
					if (current.Checked)
					{
						current.Checked = false;
					}
				}
				this.vmethod_0().Nodes.Remove(this.vmethod_0().Nodes[this.vmethod_0().Nodes.Count - 1]);
			}
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x00020C91 File Offset: 0x0001EE91
		private void LoadGroup_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				CommandFactory.GetCommandMain().GetMainForm().Enabled = false;
			}
			else
			{
				CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			}
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		private void LoadGroup_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x04001D57 RID: 7511
		[CompilerGenerated]
		private TreeView treeView_0;

		// Token: 0x04001D58 RID: 7512
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001D59 RID: 7513
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001D5A RID: 7514
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04001D5B RID: 7515
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04001D5C RID: 7516
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04001D5D RID: 7517
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x04001D5E RID: 7518
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x04001D5F RID: 7519
		[CompilerGenerated]
		private FlowLayoutPanel flowLayoutPanel_0;

		// Token: 0x04001D60 RID: 7520
		[CompilerGenerated]
		private Label label_7;

		// Token: 0x04001D61 RID: 7521
		[CompilerGenerated]
		private Label label_8;

		// Token: 0x04001D62 RID: 7522
		[CompilerGenerated]
		private ListView listView_0;

		// Token: 0x04001D63 RID: 7523
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001D64 RID: 7524
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001D65 RID: 7525
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x04001D66 RID: 7526
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x04001D67 RID: 7527
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x04001D68 RID: 7528
		private ImportExportRecord importExportRecord_0;
	}
}

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
using ns0;
using ns32;

namespace ns33
{
	// Token: 0x0200098E RID: 2446
	[DesignerGenerated]
	public sealed partial class ScenAttachmentsWindow : CommandForm
	{
		// Token: 0x06003DAC RID: 15788 RVA: 0x000201D5 File Offset: 0x0001E3D5
		public ScenAttachmentsWindow()
		{
			base.Shown += new EventHandler(this.ScenAttachmentsWindow_Shown);
			base.Load += new EventHandler(this.ScenAttachmentsWindow_Load);
			this.InitializeComponent();
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x00141E44 File Offset: 0x00140044
		[CompilerGenerated]
		internal  ListBox vmethod_0()
		{
			return this.listBox_0;
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x00141E5C File Offset: 0x0014005C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ListBox listBox_1)
		{
			EventHandler value = new EventHandler(this.method_7);
			ListBox listBox = this.listBox_0;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value;
			}
			this.listBox_0 = listBox_1;
			listBox = this.listBox_0;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x00141EA8 File Offset: 0x001400A8
		[CompilerGenerated]
		internal  ToolStrip vmethod_2()
		{
			return this.toolStrip_0;
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x00020207 File Offset: 0x0001E407
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x00141EC0 File Offset: 0x001400C0
		[CompilerGenerated]
		internal  ToolStripButton vmethod_4()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x00141ED8 File Offset: 0x001400D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_3)
		{
			EventHandler value = new EventHandler(this.method_2);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_3;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x00141F24 File Offset: 0x00140124
		[CompilerGenerated]
		internal  ToolStripButton vmethod_6()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x00141F3C File Offset: 0x0014013C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripButton toolStripButton_3)
		{
			EventHandler value = new EventHandler(this.method_4);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_3;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x00141F88 File Offset: 0x00140188
		[CompilerGenerated]
		internal  ToolStripComboBox vmethod_8()
		{
			return this.toolStripComboBox_0;
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x00020210 File Offset: 0x0001E410
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripComboBox toolStripComboBox_1)
		{
			this.toolStripComboBox_0 = toolStripComboBox_1;
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x00141FA0 File Offset: 0x001401A0
		[CompilerGenerated]
		internal  ToolStripButton vmethod_10()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x00141FB8 File Offset: 0x001401B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripButton toolStripButton_3)
		{
			EventHandler value = new EventHandler(this.method_6);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_3;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00142004 File Offset: 0x00140204
		[CompilerGenerated]
		internal  PropertyGrid vmethod_12()
		{
			return this.propertyGrid_0;
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x00020219 File Offset: 0x0001E419
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(PropertyGrid propertyGrid_1)
		{
			this.propertyGrid_0 = propertyGrid_1;
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x0014201C File Offset: 0x0014021C
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_0;
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x00020222 File Offset: 0x0001E422
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x0002022B File Offset: 0x0001E42B
		private void ScenAttachmentsWindow_Shown(object sender, EventArgs e)
		{
			this.vmethod_8().SelectedIndex = 0;
			this.method_1();
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x00142034 File Offset: 0x00140234
		public void method_1()
		{
			this.vmethod_0().Items.Clear();
			foreach (KeyValuePair<string, ScenAttachmentObject> current in Client.GetClientScenario().GetScenAttachments())
			{
				TreeNode treeNode = new TreeNode();
				treeNode.Name = current.Value.string_1;
				treeNode.Tag = current.Key;
				this.vmethod_0().Items.Add(treeNode);
			}
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x0002023F File Offset: 0x0001E43F
		private void method_2(object sender, EventArgs e)
		{
			this.method_3();
			this.method_1();
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x001420CC File Offset: 0x001402CC
		public void method_3()
		{
			switch (this.vmethod_8().SelectedIndex)
			{
			case 0:
				CommandFactory.GetCommandMain().GetMainForm().vmethod_108().InitialDirectory = Application.StartupPath;
				if (CommandFactory.GetCommandMain().GetMainForm().vmethod_108().ShowDialog() != DialogResult.OK)
				{
					return;
				}
				try
				{
					string fileName = CommandFactory.GetCommandMain().GetMainForm().vmethod_108().FileName;
					SAO_OverlaySingle sAO_OverlaySingle = new SAO_OverlaySingle();
					sAO_OverlaySingle.ImageFileName = Path.GetFileName(fileName);
					sAO_OverlaySingle.string_1 = "地图图层: " + sAO_OverlaySingle.ImageFileName;
					sAO_OverlaySingle.vmethod_0(fileName);
					sAO_OverlaySingle.vmethod_2(Path.Combine(GameGeneral.strAttachmentRepoDir, sAO_OverlaySingle.method_0()));
					Client.GetClientScenario().GetScenAttachments().Add(sAO_OverlaySingle.method_0(), sAO_OverlaySingle);
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200395", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
					return;
				}
				break;
			case 1:
				break;
			case 2:
				goto IL_227;
			case 3:
				goto IL_33B;
			default:
				return;
			}
			CommandFactory.GetCommandMain().GetMainForm().vmethod_108().InitialDirectory = Application.StartupPath;
			CommandFactory.GetCommandMain().GetMainForm().vmethod_108().Filter = "Lua脚本文件(*.lua)|*.lua";
			if (CommandFactory.GetCommandMain().GetMainForm().vmethod_108().ShowDialog() != DialogResult.OK)
			{
				return;
			}
			try
			{
				string fileName2 = CommandFactory.GetCommandMain().GetMainForm().vmethod_108().FileName;
				SAO_LuaScript sAO_LuaScript = new SAO_LuaScript();
				sAO_LuaScript.ScriptFileName = Path.GetFileName(fileName2);
				sAO_LuaScript.string_1 = "Lua script: " + sAO_LuaScript.ScriptFileName;
				sAO_LuaScript.vmethod_0(fileName2);
				sAO_LuaScript.vmethod_2(Path.Combine(GameGeneral.strAttachmentRepoDir, sAO_LuaScript.method_0()));
				Client.GetClientScenario().GetScenAttachments().Add(sAO_LuaScript.method_0(), sAO_LuaScript);
				return;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 200396", ex4.Message);
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
				return;
			}
			IL_227:
			CommandFactory.GetCommandMain().GetMainForm().vmethod_108().InitialDirectory = Application.StartupPath;
			CommandFactory.GetCommandMain().GetMainForm().vmethod_108().Filter = "Inst Import file (*.inst)|*.inst";
			if (CommandFactory.GetCommandMain().GetMainForm().vmethod_108().ShowDialog() != DialogResult.OK)
			{
				return;
			}
			try
			{
				string fileName3 = CommandFactory.GetCommandMain().GetMainForm().vmethod_108().FileName;
				SAO_Inst sAO_Inst = new SAO_Inst();
				sAO_Inst.InstFileName = Path.GetFileName(fileName3);
				sAO_Inst.string_1 = "Inst File: " + sAO_Inst.InstFileName;
				sAO_Inst.vmethod_0(fileName3);
				sAO_Inst.vmethod_2(Path.Combine(GameGeneral.strAttachmentRepoDir, sAO_Inst.method_0()));
				Client.GetClientScenario().GetScenAttachments().Add(sAO_Inst.method_0(), sAO_Inst);
				return;
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 200397", ex6.Message);
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
				return;
			}
			IL_33B:
			CommandFactory.GetCommandMain().GetMainForm().vmethod_108().InitialDirectory = Application.StartupPath;
			CommandFactory.GetCommandMain().GetMainForm().vmethod_108().Filter = "Video file (*.*)|*.*";
			if (CommandFactory.GetCommandMain().GetMainForm().vmethod_108().ShowDialog() == DialogResult.OK)
			{
				try
				{
					string fileName4 = CommandFactory.GetCommandMain().GetMainForm().vmethod_108().FileName;
					SAO_LocalVideo sAO_LocalVideo = new SAO_LocalVideo();
					sAO_LocalVideo.VideoFileName = Path.GetFileName(fileName4);
					sAO_LocalVideo.string_1 = "Local Video: " + sAO_LocalVideo.VideoFileName;
					sAO_LocalVideo.vmethod_0(fileName4);
					sAO_LocalVideo.vmethod_2(Path.Combine(GameGeneral.strAttachmentRepoDir, sAO_LocalVideo.method_0()));
					Client.GetClientScenario().GetScenAttachments().Add(sAO_LocalVideo.method_0(), sAO_LocalVideo);
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ex8.Data.Add("Error at 200398", ex8.Message);
					GameGeneral.LogException(ref ex8);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x0014255C File Offset: 0x0014075C
		private void method_4(object sender, EventArgs e)
		{
			IEnumerator enumerator = this.vmethod_0().SelectedItems.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator.Current;
					Client.GetClientScenario().GetScenAttachments().Remove(treeNode.Tag.ToString());
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.method_1();
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x0002024D File Offset: 0x0001E44D
		public void method_5()
		{
			this.method_1();
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x001425E0 File Offset: 0x001407E0
		private void method_6(object sender, EventArgs e)
		{
			if (CommandFactory.GetCommandMain().method_64().ShowDialog() == DialogResult.OK)
			{
				List<ScenAttachmentObject>.Enumerator enumerator = CommandFactory.GetCommandMain().method_64().ScenAttachmentObjects.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ScenAttachmentObject current = enumerator.Current;
						if (!Client.GetClientScenario().GetScenAttachments().ContainsKey(current.method_0()))
						{
							Client.GetClientScenario().GetScenAttachments().Add(current.method_0(), current);
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x00142680 File Offset: 0x00140880
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_0().SelectedItems.Count > 0)
			{
				this.vmethod_12().SelectedObject = Client.GetClientScenario().GetScenAttachments()[Conversions.ToString(NewLateBinding.LateGet(this.vmethod_0().SelectedItems[0], null, "Tag", new object[0], null, null, null)).ToString()];
			}
			else
			{
				this.vmethod_12().SelectedObject = null;
			}
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void ScenAttachmentsWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001C4E RID: 7246
		[CompilerGenerated]
		private ListBox listBox_0;

		// Token: 0x04001C4F RID: 7247
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x04001C50 RID: 7248
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04001C51 RID: 7249
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04001C52 RID: 7250
		[CompilerGenerated]
		private ToolStripComboBox toolStripComboBox_0;

		// Token: 0x04001C53 RID: 7251
		[CompilerGenerated]
		private ToolStripButton toolStripButton_2;

		// Token: 0x04001C54 RID: 7252
		[CompilerGenerated]
		private PropertyGrid propertyGrid_0;

		// Token: 0x04001C55 RID: 7253
		[CompilerGenerated]
		private Label label_0;
	}
}

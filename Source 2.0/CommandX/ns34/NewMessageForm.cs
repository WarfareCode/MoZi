using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
using ns33;
using ns35;

namespace ns34
{
	// Token: 0x020009E5 RID: 2533
	[DesignerGenerated]
	public sealed partial class NewMessageForm : CommandForm
	{
		// Token: 0x06004AE2 RID: 19170 RVA: 0x001D36C8 File Offset: 0x001D18C8
		public NewMessageForm()
		{
			base.FormClosing += new FormClosingEventHandler(this.NewMessageForm_FormClosing);
			base.Load += new EventHandler(this.NewMessageForm_Load);
			base.KeyDown += new KeyEventHandler(this.NewMessageForm_KeyDown);
			this.vmethod_15(new ObservableCollection<LoggedMessage>());
			this.InitializeComponent();
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x001D3BA8 File Offset: 0x001D1DA8
		[CompilerGenerated]
		internal  ToolStrip vmethod_0()
		{
			return this.toolStrip_0;
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x00023DFF File Offset: 0x00021FFF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x001D3BC0 File Offset: 0x001D1DC0
		[CompilerGenerated]
		internal  ToolStripButton vmethod_2()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x001D3BD8 File Offset: 0x001D1DD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_2);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_5;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x001D3C24 File Offset: 0x001D1E24
		[CompilerGenerated]
		internal  ToolStripButton vmethod_4()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x001D3C3C File Offset: 0x001D1E3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_3);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_5;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x001D3C88 File Offset: 0x001D1E88
		[CompilerGenerated]
		internal  ToolStripButton vmethod_6()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x001D3CA0 File Offset: 0x001D1EA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_4);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_5;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x001D3CEC File Offset: 0x001D1EEC
		[CompilerGenerated]
		internal  ToolStripButton vmethod_8()
		{
			return this.toolStripButton_3;
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x001D3D04 File Offset: 0x001D1F04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_6);
			ToolStripButton toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_3 = toolStripButton_5;
			toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x001D3D50 File Offset: 0x001D1F50
		[CompilerGenerated]
		internal  ToolStripButton vmethod_10()
		{
			return this.toolStripButton_4;
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x001D3D68 File Offset: 0x001D1F68
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_7);
			ToolStripButton toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_4 = toolStripButton_5;
			toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x001D3DB4 File Offset: 0x001D1FB4
		[CompilerGenerated]
		internal  WebBrowser vmethod_12()
		{
			return this.webBrowser_0;
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x001D3DCC File Offset: 0x001D1FCC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(WebBrowser webBrowser_1)
		{
			PreviewKeyDownEventHandler value = new PreviewKeyDownEventHandler(this.method_8);
			WebBrowser webBrowser = this.webBrowser_0;
			if (webBrowser != null)
			{
				webBrowser.PreviewKeyDown -= value;
			}
			this.webBrowser_0 = webBrowser_1;
			webBrowser = this.webBrowser_0;
			if (webBrowser != null)
			{
				webBrowser.PreviewKeyDown += value;
			}
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x001D3E18 File Offset: 0x001D2018
		[CompilerGenerated]
		public  ObservableCollection<LoggedMessage> vmethod_14()
		{
			return this.observableCollection_0;
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x001D3E30 File Offset: 0x001D2030
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void vmethod_15(ObservableCollection<LoggedMessage> observableCollection_1)
		{
			NotifyCollectionChangedEventHandler value = new NotifyCollectionChangedEventHandler(this.method_5);
			ObservableCollection<LoggedMessage> observableCollection = this.observableCollection_0;
			if (observableCollection != null)
			{
				observableCollection.CollectionChanged -= value;
			}
			this.observableCollection_0 = observableCollection_1;
			observableCollection = this.observableCollection_0;
			if (observableCollection != null)
			{
				observableCollection.CollectionChanged += value;
			}
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x001D3E7C File Offset: 0x001D207C
		private void NewMessageForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				Client.MessageTypeFormDictionary.Remove(this.vmethod_14()[0].messageType);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200393", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x001D3F04 File Offset: 0x001D2104
		private void NewMessageForm_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (this.vmethod_14().Count == 0)
			{
				base.Close();
			}
			this.loggedMessage_0 = this.vmethod_14()[0];
			this.method_1(this.loggedMessage_0);
			this.vmethod_8().Enabled = false;
			this.vmethod_10().Enabled = (this.vmethod_14().Count > 1);
			base.BringToFront();
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x001D3F8C File Offset: 0x001D218C
		private void method_1(LoggedMessage loggedMessage_1)
		{
			Class2529.smethod_7(this.vmethod_12(), "<span style='font:Arial'>" + loggedMessage_1.Text + "<span>", default(Color));
			this.vmethod_2().Visible = !Information.IsNothing(loggedMessage_1.Location);
			this.vmethod_8().Enabled = (this.vmethod_14().IndexOf(this.loggedMessage_0) != 0);
			this.vmethod_10().Enabled = (this.vmethod_14().IndexOf(this.loggedMessage_0) != this.vmethod_14().Count - 1);
			base.BringToFront();
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x00023E08 File Offset: 0x00022008
		private void method_2(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.loggedMessage_0.Location))
			{
				CommandFactory.GetCommandMain().GetMainForm().method_14(true, this.loggedMessage_0.Location);
			}
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x00023E37 File Offset: 0x00022037
		private void method_4(object sender, EventArgs e)
		{
			Client.GetConfiguration().SetSimRunMode();
			base.Close();
		}

		// Token: 0x06004AFB RID: 19195 RVA: 0x00023E49 File Offset: 0x00022049
		private void method_5(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.Text = Conversions.ToString(this.vmethod_14().Count) + "条消息，类型为: " + Misc.GetMessageTypeString(((LoggedMessage)e.NewItems[0]).messageType);
		}

		// Token: 0x06004AFC RID: 19196 RVA: 0x001D4034 File Offset: 0x001D2234
		private void method_6(object sender, EventArgs e)
		{
			if (this.vmethod_14().IndexOf(this.loggedMessage_0) != 0)
			{
				this.loggedMessage_0 = this.vmethod_14()[this.vmethod_14().IndexOf(this.loggedMessage_0) - 1];
				this.method_1(this.loggedMessage_0);
			}
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x001D4088 File Offset: 0x001D2288
		private void method_7(object sender, EventArgs e)
		{
			if (this.vmethod_14().IndexOf(this.loggedMessage_0) != this.vmethod_14().Count - 1)
			{
				this.loggedMessage_0 = this.vmethod_14()[this.vmethod_14().IndexOf(this.loggedMessage_0) + 1];
				this.method_1(this.loggedMessage_0);
			}
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x001D40E8 File Offset: 0x001D22E8
		private void NewMessageForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				Client.GetConfiguration().SetSimRunMode();
				base.Close();
			}
			else if (e.KeyCode == Keys.F12 && base.Visible)
			{
				base.Close();
				Client.GetConfiguration().SetSimRunMode();
			}
			else
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x001D4160 File Offset: 0x001D2360
		private void method_8(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				Client.GetConfiguration().SetSimRunMode();
				base.Close();
			}
			else if (e.KeyCode == Keys.F12 && base.Visible)
			{
				base.Close();
				Client.GetConfiguration().SetSimRunMode();
			}
			else
			{
				KeyEventArgs e2 = new KeyEventArgs(e.KeyCode);
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e2);
			}
		}

		// Token: 0x04002329 RID: 9001
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x0400232A RID: 9002
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x0400232B RID: 9003
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x0400232C RID: 9004
		[CompilerGenerated]
		private ToolStripButton toolStripButton_2;

		// Token: 0x0400232D RID: 9005
		[CompilerGenerated]
		private ToolStripButton toolStripButton_3;

		// Token: 0x0400232E RID: 9006
		[CompilerGenerated]
		private ToolStripButton toolStripButton_4;

		// Token: 0x0400232F RID: 9007
		[CompilerGenerated]
		private WebBrowser webBrowser_0;

		// Token: 0x04002330 RID: 9008
		[CompilerGenerated]
		private ObservableCollection<LoggedMessage> observableCollection_0;

		// Token: 0x04002331 RID: 9009
		private LoggedMessage loggedMessage_0;
	}
}

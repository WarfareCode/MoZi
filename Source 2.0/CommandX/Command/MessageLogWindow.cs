using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;
using ns35;
using ns4;

namespace Command
{
	// Token: 0x02000A10 RID: 2576
	[DesignerGenerated]
	public sealed partial class MessageLogWindow : CommandForm
	{
		// Token: 0x06004F30 RID: 20272 RVA: 0x001FE05C File Offset: 0x001FC25C
		public MessageLogWindow()
		{
			base.FormClosing += new FormClosingEventHandler(this.MessageLogWindow_FormClosing);
			base.Load += new EventHandler(this.MessageLogWindow_Load);
			base.Resize += new EventHandler(this.MessageLogWindow_Resize);
			base.Shown += new EventHandler(this.MessageLogWindow_Shown);
			base.KeyDown += new KeyEventHandler(this.MessageLogWindow_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x001FE374 File Offset: 0x001FC574
		[CompilerGenerated]
		internal  WebBrowser vmethod_0()
		{
			return this.webBrowser_0;
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x000252DE File Offset: 0x000234DE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(WebBrowser webBrowser_1)
		{
			this.webBrowser_0 = webBrowser_1;
		}

		// Token: 0x06004F35 RID: 20277 RVA: 0x001FE38C File Offset: 0x001FC58C
		[CompilerGenerated]
		internal  ToolStrip vmethod_2()
		{
			return this.toolStrip_0;
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x000252E7 File Offset: 0x000234E7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x001FE3A4 File Offset: 0x001FC5A4
		[CompilerGenerated]
		internal  ToolStripLabel vmethod_4()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x000252F0 File Offset: 0x000234F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripLabel toolStripLabel_1)
		{
			this.toolStripLabel_0 = toolStripLabel_1;
		}

		// Token: 0x06004F39 RID: 20281 RVA: 0x001FE3BC File Offset: 0x001FC5BC
		[CompilerGenerated]
		internal  ToolStripTextBox vmethod_6()
		{
			return this.toolStripTextBox_0;
		}

		// Token: 0x06004F3A RID: 20282 RVA: 0x001FE3D4 File Offset: 0x001FC5D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripTextBox toolStripTextBox_1)
		{
			EventHandler value = new EventHandler(this.method_3);
			EventHandler value2 = new EventHandler(this.method_4);
			EventHandler value3 = new EventHandler(this.method_5);
			ToolStripTextBox toolStripTextBox = this.toolStripTextBox_0;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.TextChanged -= value;
				toolStripTextBox.Enter -= value2;
				toolStripTextBox.Leave -= value3;
			}
			this.toolStripTextBox_0 = toolStripTextBox_1;
			toolStripTextBox = this.toolStripTextBox_0;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.TextChanged += value;
				toolStripTextBox.Enter += value2;
				toolStripTextBox.Leave += value3;
			}
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x000252F9 File Offset: 0x000234F9
		private void MessageLogWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing & !Client.bool_6)
			{
				SimConfiguration.gameOptions.SetMessageLogInWindow(false);
				SimConfiguration.SaveConfig();
			}
			Client.b_Completed = true;
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void MessageLogWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x00025337 File Offset: 0x00023537
		private void MessageLogWindow_Resize(object sender, EventArgs e)
		{
			this.method_2(false);
		}

		// Token: 0x06004F3E RID: 20286 RVA: 0x00025340 File Offset: 0x00023540
		private void MessageLogWindow_Shown(object sender, EventArgs e)
		{
			Client.b_Completed = true;
			this.method_2(false);
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x001FE454 File Offset: 0x001FC654
		public void method_1()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<div style='margin:-20 -10 -10 -10; padding:10 5 5 5;font-family:Verdana;height:" + Conversions.ToString(this.vmethod_0().Height) + ";background-color:black;font-size:9pt;'></div>");
			string theHTML = stringBuilder.ToString();
			Class2529.smethod_7(this.vmethod_0(), theHTML, Color.Black);
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x001FE4A8 File Offset: 0x001FC6A8
		public void method_2(bool bool_1)
		{
			if (Information.IsNothing(Client.GetClientSide()))
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("<div style='margin:-20 -10 -10 -10; padding:10 5 5 5;font-family:Verdana;height:" + Conversions.ToString(this.vmethod_0().Height) + ";background-color:black;font-size:9pt;'>");
				stringBuilder.Append("</div>");
				string theHTML = stringBuilder.ToString();
				Class2529.smethod_7(this.vmethod_0(), theHTML, Color.Black);
			}
			else
			{
				List<LoggedMessage> list = Client.GetClientSide().GetLoggedMessageList(Client.GetClientScenario()).OrderByDescending(MessageLogWindow.LoggedMessageFunc0).ThenByDescending(MessageLogWindow.LoggedMessageFunc1).ToList<LoggedMessage>();
				if (bool_1)
				{
					if (list.Count <= 0 || this.long_0 == list[0].Increment)
					{
						return;
					}
					this.long_0 = list[0].Increment;
				}
				if (!string.IsNullOrEmpty(this.vmethod_6().Text))
				{
					list = list.Where(new Func<LoggedMessage, bool>(this.method_6)).ToList<LoggedMessage>();
				}
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("<div style='margin:-20 -10 -10 -10; padding:10 5 5 5;font-family:Verdana;height:" + Conversions.ToString(this.vmethod_0().Height) + ";background-color:black;font-size:9pt;'>");
				foreach (LoggedMessage current in list)
				{
					Color color = current.method_11();
					if (current.method_12(this.Font).Style == FontStyle.Italic)
					{
						stringBuilder.Append("<i>");
					}
					stringBuilder.Append(string.Concat(new string[]
					{
						"<div style='color:#",
						color.R.ToString("X2"),
						color.G.ToString("X2"),
						color.B.ToString("X2"),
						"'>"
					}));
					stringBuilder.Append(current.TStamp.ToLongTimeString() + " - " + current.Text);
					stringBuilder.Append("</div>");
					if (current.method_12(this.Font).Style == FontStyle.Italic)
					{
						stringBuilder.Append("</i>");
					}
				}
				stringBuilder.Append("</div>");
				string theHTML = stringBuilder.ToString();
				Class2529.smethod_7(this.vmethod_0(), theHTML, Color.Black);
				if (!this.bool_0)
				{
					this.vmethod_2().Select();
				}
			}
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x00025337 File Offset: 0x00023537
		private void method_3(object sender, EventArgs e)
		{
			this.method_2(false);
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x001FE754 File Offset: 0x001FC954
		private void MessageLogWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.bool_0)
			{
				bool arg_30_0;
				if (e.KeyValue != 13)
				{
					if (e.KeyValue != 27)
					{
						arg_30_0 = true;
						goto IL_30;
					}
				}
				arg_30_0 = !base.Visible;
				IL_30:
				if (!arg_30_0)
				{
					this.vmethod_2().Select();
				}
				if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
				{
					CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
			if (!this.bool_0)
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x0002534F File Offset: 0x0002354F
		private void method_4(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x00025358 File Offset: 0x00023558
		private void method_5(object sender, EventArgs e)
		{
			this.bool_0 = false;
			this.vmethod_2().Select();
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x0002536C File Offset: 0x0002356C
		[CompilerGenerated]
		private bool method_6(LoggedMessage loggedMessage_)
		{
			return loggedMessage_.Text.ToLower().Contains(this.vmethod_6().Text.ToLower());
		}

		// Token: 0x04002557 RID: 9559
		public static Func<LoggedMessage, DateTime> LoggedMessageFunc0 = (LoggedMessage loggedMessage_0) => loggedMessage_0.TStamp;

		// Token: 0x04002558 RID: 9560
		public static Func<LoggedMessage, long> LoggedMessageFunc1 = (LoggedMessage loggedMessage_0) => loggedMessage_0.Increment;

		// Token: 0x0400255A RID: 9562
		[CompilerGenerated]
		private WebBrowser webBrowser_0;

		// Token: 0x0400255B RID: 9563
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x0400255C RID: 9564
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x0400255D RID: 9565
		[CompilerGenerated]
		private ToolStripTextBox toolStripTextBox_0;

		// Token: 0x0400255E RID: 9566
		private long long_0;

		// Token: 0x0400255F RID: 9567
		private bool bool_0;
	}
}

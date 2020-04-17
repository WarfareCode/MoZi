using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns32;
using ns35;

namespace ns33
{
	// Token: 0x02000CEB RID: 3307
	[DesignerGenerated]
	public sealed partial class CampaignEnd : Form
	{
		// Token: 0x06006CAE RID: 27822 RVA: 0x003D06F4 File Offset: 0x003CE8F4
		public CampaignEnd()
		{
			base.Shown += new EventHandler(this.CampaignEnd_Shown);
			base.KeyDown += new KeyEventHandler(this.CampaignEnd_KeyDown);
			base.Load += new EventHandler(this.CampaignEnd_Load);
			this.InitializeComponent();
		}

		// Token: 0x06006CB1 RID: 27825 RVA: 0x003D0970 File Offset: 0x003CEB70
		[CompilerGenerated]
		internal  WebBrowser vmethod_0()
		{
			return this.webBrowser_0;
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x003D0988 File Offset: 0x003CEB88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(WebBrowser webBrowser_1)
		{
			PreviewKeyDownEventHandler value = new PreviewKeyDownEventHandler(this.method_2);
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

		// Token: 0x06006CB3 RID: 27827 RVA: 0x003D09D4 File Offset: 0x003CEBD4
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x0002E87C File Offset: 0x0002CA7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x003D09EC File Offset: 0x003CEBEC
		private void CampaignEnd_Shown(object sender, EventArgs e)
		{
			if (!this.method_1(this.vmethod_0(), this.class111_0.strEndingText, this.class111_0.campaignDir))
			{
				Class2529.smethod_7(this.vmethod_0(), this.class111_0.strEndingText, default(Color));
			}
			this.method_0();
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x0002E885 File Offset: 0x0002CA85
		private void method_0()
		{
			base.TopMost = true;
			base.FormBorderStyle = FormBorderStyle.None;
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x06006CB7 RID: 27831 RVA: 0x0012B2FC File Offset: 0x001294FC
		private bool method_1(WebBrowser webBrowser_1, string string_0, string string_1)
		{
			bool result;
			if (string_0.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_0, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_0, "[/LOADDOC]", CompareMethod.Binary);
				string path = string_0.Substring(num, string_0.Length - num - (string_0.Length - num2 + 1));
				webBrowser_1.Navigate(Path.Combine(string_1, path));
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x0002E89C File Offset: 0x0002CA9C
		private void CampaignEnd_KeyDown(object sender, KeyEventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06006CB9 RID: 27833 RVA: 0x0002E89C File Offset: 0x0002CA9C
		private void method_2(object sender, PreviewKeyDownEventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06006CBA RID: 27834 RVA: 0x003D0A44 File Offset: 0x003CEC44
		private void method_3()
		{
			IEnumerator enumerator = CommandFactory.GetCommandApp().OpenForms.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Form form = (Form)enumerator.Current;
					if (form != this && form != CommandFactory.GetCommandMain().mainForm_0 && form != CommandFactory.GetCommandMain().messageLogWindow_0 && form.Visible)
					{
						form.Hide();
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
			CommandFactory.GetCommandMain().GetStartGame().Show();
			base.Close();
		}

		// Token: 0x06006CBB RID: 27835 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void CampaignEnd_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04003EAF RID: 16047
		[CompilerGenerated]
		private WebBrowser webBrowser_0;

		// Token: 0x04003EB0 RID: 16048
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04003EB1 RID: 16049
		public Campaign class111_0;
	}
}

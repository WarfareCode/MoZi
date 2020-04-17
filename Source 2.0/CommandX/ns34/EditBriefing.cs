using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MSDN.Html.Editor;
using ns2;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x02000A0C RID: 2572
	[DesignerGenerated]
	public sealed partial class EditBriefing : CommandForm
	{
		// Token: 0x06004EBD RID: 20157 RVA: 0x001FAC00 File Offset: 0x001F8E00
		public EditBriefing()
		{
			base.Load += new EventHandler(this.EditBriefing_Load);
			base.Shown += new EventHandler(this.EditBriefing_Shown);
			base.ResizeEnd += new EventHandler(this.EditBriefing_ResizeEnd);
			base.FormClosing += new FormClosingEventHandler(this.EditBriefing_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x001FB094 File Offset: 0x001F9294
		[CompilerGenerated]
		internal  SplitContainer vmethod_0()
		{
			return this.splitContainer_0;
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x00025119 File Offset: 0x00023319
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(SplitContainer splitContainer_1)
		{
			this.splitContainer_0 = splitContainer_1;
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x001FB0AC File Offset: 0x001F92AC
		[CompilerGenerated]
		internal  Button vmethod_2()
		{
			return this.button_0;
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x001FB0C4 File Offset: 0x001F92C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_1);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_3;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x001FB110 File Offset: 0x001F9310
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_1;
		}

		// Token: 0x06004EC5 RID: 20165 RVA: 0x001FB128 File Offset: 0x001F9328
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_2);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_3;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x001FB174 File Offset: 0x001F9374
		[CompilerGenerated]
		internal  HtmlEditorControl vmethod_6()
		{
			return this.htmlEditorControl_0;
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x00025122 File Offset: 0x00023322
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(HtmlEditorControl htmlEditorControl_1)
		{
			this.htmlEditorControl_0 = htmlEditorControl_1;
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x001FB18C File Offset: 0x001F938C
		[CompilerGenerated]
		internal  Button vmethod_8()
		{
			return this.button_2;
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x001FB1A4 File Offset: 0x001F93A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_3);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_3;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x001FB1F0 File Offset: 0x001F93F0
		private void EditBriefing_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit)
			{
				this.Text = "Edit Briefing for side: " + Client.GetClientSide().GetSideName();
				this.vmethod_2().Visible = true;
				this.vmethod_8().Visible = true;
			}
			else
			{
				this.Text = "Side Briefing";
				this.vmethod_2().Visible = false;
				this.vmethod_8().Visible = false;
			}
			if (!string.IsNullOrEmpty(Client.GetClientSide().Briefing))
			{
				if (!string.IsNullOrEmpty(Client.string_0))
				{
					if (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit)
					{
						this.vmethod_6().BodyHtml = Client.GetClientSide().Briefing.ToString();
					}
					else if (!this.method_4(this.vmethod_6(), Client.GetClientSide().Briefing.ToString(), Path.GetDirectoryName(Client.string_0)))
					{
						this.vmethod_6().BodyHtml = Client.GetClientSide().Briefing.ToString();
					}
				}
				else
				{
					this.vmethod_6().BodyHtml = Client.GetClientSide().Briefing.ToString();
				}
			}
			this.vmethod_6().ToolbarVisible = true;
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x0002512B File Offset: 0x0002332B
		private void method_2(object sender, EventArgs e)
		{
			if (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit)
			{
				Client.GetClientSide().Briefing = this.vmethod_6().BodyHtml;
			}
			base.Close();
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x00024FBB File Offset: 0x000231BB
		private void EditBriefing_Shown(object sender, EventArgs e)
		{
			if (base.Height != 510)
			{
				base.Width--;
				base.Width++;
			}
		}

		// Token: 0x06004ECE RID: 20174 RVA: 0x00024FE8 File Offset: 0x000231E8
		private void EditBriefing_ResizeEnd(object sender, EventArgs e)
		{
			base.Width--;
			base.Width++;
		}

		// Token: 0x06004ECF RID: 20175 RVA: 0x00004D83 File Offset: 0x00002F83
		private void EditBriefing_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x0002515A File Offset: 0x0002335A
		private void method_3(object sender, EventArgs e)
		{
			this.vmethod_6().HtmlContentsEdit();
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x001FB338 File Offset: 0x001F9538
		private bool method_4(HtmlEditorControl htmlEditorControl_1, string string_0, string string_1)
		{
			bool result;
			if (string_0.Contains("[LOADDOC]"))
			{
				int num = Strings.InStr(string_0, "[LOADDOC]", CompareMethod.Binary) + "[LOADDOC]".Length - 1;
				int num2 = Strings.InStr(string_0, "[/LOADDOC]", CompareMethod.Binary);
				string path = string_0.Substring(num, string_0.Length - num - (string_0.Length - num2 + 1));
				htmlEditorControl_1.NavigateToUrl(Path.Combine(string_1, path));
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04002530 RID: 9520
		[CompilerGenerated]
		private SplitContainer splitContainer_0;

		// Token: 0x04002531 RID: 9521
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04002532 RID: 9522
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04002533 RID: 9523
		[CompilerGenerated]
		private HtmlEditorControl htmlEditorControl_0;

		// Token: 0x04002534 RID: 9524
		[CompilerGenerated]
		private Button button_2;
	}
}

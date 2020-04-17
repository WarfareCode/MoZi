using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x02000A38 RID: 2616
	[DesignerGenerated]
	public sealed partial class RenameObject : CommandForm
	{
		// Token: 0x06005329 RID: 21289 RVA: 0x002205D4 File Offset: 0x0021E7D4
		public RenameObject()
		{
			base.FormClosing += new FormClosingEventHandler(this.RenameObject_FormClosing);
			base.Load += new EventHandler(this.RenameObject_Load);
			base.KeyDown += new KeyEventHandler(this.RenameObject_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x00220898 File Offset: 0x0021EA98
		[CompilerGenerated]
		internal  TextBox vmethod_0()
		{
			return this.textBox_0;
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x00026998 File Offset: 0x00024B98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TextBox textBox_1)
		{
			this.textBox_0 = textBox_1;
		}

		// Token: 0x0600532E RID: 21294 RVA: 0x002208B0 File Offset: 0x0021EAB0
		[CompilerGenerated]
		internal  Button vmethod_2()
		{
			return this.button_0;
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x002208C8 File Offset: 0x0021EAC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_1);
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

		// Token: 0x06005330 RID: 21296 RVA: 0x00220914 File Offset: 0x0021EB14
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_1;
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x0022092C File Offset: 0x0021EB2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_2);
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

		// Token: 0x06005332 RID: 21298 RVA: 0x00220978 File Offset: 0x0021EB78
		private void RenameObject_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			Client.b_Completed = true;
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			if (!Information.IsNothing(CommandFactory.GetCommandMain().GetAirOps()) && CommandFactory.GetCommandMain().GetAirOps().Visible)
			{
				CommandFactory.GetCommandMain().GetAirOps().method_6();
			}
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
			if (CommandFactory.GetCommandMain().GetScenAttachmentsWindow().Visible)
			{
				CommandFactory.GetCommandMain().GetScenAttachmentsWindow().method_5();
			}
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x000269A1 File Offset: 0x00024BA1
		private void RenameObject_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			CommandFactory.GetCommandMain().GetMainForm().Enabled = false;
			this.vmethod_0().Text = this.string_0;
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x000269DC File Offset: 0x00024BDC
		private void method_1(object sender, EventArgs e)
		{
			this.string_0 = this.vmethod_0().Text;
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			base.Close();
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_2(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		private void RenameObject_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x04002700 RID: 9984
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04002701 RID: 9985
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04002702 RID: 9986
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04002703 RID: 9987
		public string string_0;
	}
}

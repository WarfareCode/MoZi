using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x020009A2 RID: 2466
	[DesignerGenerated]
	public sealed partial class LoadSaveProgress : CommandForm
	{
		// Token: 0x06004023 RID: 16419 RVA: 0x00020D87 File Offset: 0x0001EF87
		public LoadSaveProgress()
		{
			base.Load += new EventHandler(this.LoadSaveProgress_Load);
			base.FormClosing += new FormClosingEventHandler(this.LoadSaveProgress_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x0015A298 File Offset: 0x00158498
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x00020DB9 File Offset: 0x0001EFB9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x00020DC2 File Offset: 0x0001EFC2
		private void LoadSaveProgress_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_0().Text = this.string_0;
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x00004D83 File Offset: 0x00002F83
		private void LoadSaveProgress_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x04001D79 RID: 7545
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001D7A RID: 7546
		public string string_0;
	}
}

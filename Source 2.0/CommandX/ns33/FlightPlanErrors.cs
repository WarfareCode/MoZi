using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns32;

namespace ns33
{
	// Token: 0x02000A28 RID: 2600
	[DesignerGenerated]
	public sealed partial class FlightPlanErrors : CommandForm
	{
		// Token: 0x0600514F RID: 20815 RVA: 0x00213188 File Offset: 0x00211388
		public FlightPlanErrors()
		{
			base.FormClosing += new FormClosingEventHandler(this.FlightPlanErrors_FormClosing);
			base.FormClosed += new FormClosedEventHandler(this.FlightPlanErrors_FormClosed);
			base.KeyDown += new KeyEventHandler(this.FlightPlanErrors_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x06005152 RID: 20818 RVA: 0x00213330 File Offset: 0x00211530
		[CompilerGenerated]
		internal  ListBox vmethod_0()
		{
			return this.listBox_0;
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x00026015 File Offset: 0x00024215
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ListBox listBox_1)
		{
			this.listBox_0 = listBox_1;
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x00025EE1 File Offset: 0x000240E1
		private void FlightPlanErrors_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			base.Hide();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void FlightPlanErrors_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x06005156 RID: 20822 RVA: 0x0002601E File Offset: 0x0002421E
		private void FlightPlanErrors_KeyDown(object sender, KeyEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x04002639 RID: 9785
		[CompilerGenerated]
		private ListBox listBox_0;
	}
}

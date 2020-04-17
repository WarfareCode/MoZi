using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x020009F7 RID: 2551
	[DesignerGenerated]
	public sealed partial class RegressionTests : CommandForm
	{
		// Token: 0x06004C9E RID: 19614 RVA: 0x001E65D0 File Offset: 0x001E47D0
		public RegressionTests()
		{
			base.Load += new EventHandler(this.RegressionTests_Load);
			base.KeyDown += new KeyEventHandler(this.RegressionTests_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.RegressionTests_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x001E6780 File Offset: 0x001E4980
		[CompilerGenerated]
		internal  TextBox vmethod_0()
		{
			return this.textBox_0;
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x000247FA File Offset: 0x000229FA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TextBox textBox_1)
		{
			this.textBox_0 = textBox_1;
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x001E6798 File Offset: 0x001E4998
		private void RegressionTests_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_0().Text = "Running regression tests...\r\n\r\n";
			Application.DoEvents();
			this.vmethod_0().Text = this.vmethod_0().Text + "Test 1 (Issue #1122): ";
			Application.DoEvents();
			this.vmethod_0().Text = this.vmethod_0().Text + this.method_1();
			this.vmethod_0().Text = this.vmethod_0().Text + "\r\n\r\nAll regression tests have finished.";
		}

		// Token: 0x06004CA4 RID: 19620 RVA: 0x001E6838 File Offset: 0x001E4A38
		public string method_1()
		{
			string result;
			try
			{
				Class260.SaveTempScenarioFile(Client.GetClientScenario(), Client.GetClientSide(), Application.StartupPath + "\\RT1.scen", false, false);
				Class260.smethod_1(Application.StartupPath + "\\RT1.scen");
				result = "PASS";
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = "FAIL";
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004CA5 RID: 19621 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		private void RegressionTests_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x00004D83 File Offset: 0x00002F83
		private void RegressionTests_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x04002420 RID: 9248
		[CompilerGenerated]
		private TextBox textBox_0;
	}
}

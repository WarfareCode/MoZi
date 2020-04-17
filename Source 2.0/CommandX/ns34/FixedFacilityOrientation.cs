using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x02000A39 RID: 2617
	[DesignerGenerated]
	public sealed partial class FixedFacilityOrientation : CommandForm
	{
		// Token: 0x06005337 RID: 21303 RVA: 0x00220A14 File Offset: 0x0021EC14
		public FixedFacilityOrientation()
		{
			base.Load += new EventHandler(this.FixedFacilityOrientation_Load);
			base.KeyDown += new KeyEventHandler(this.FixedFacilityOrientation_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.FixedFacilityOrientation_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x00220C4C File Offset: 0x0021EE4C
		[CompilerGenerated]
		internal  TrackBar vmethod_0()
		{
			return this.trackBar_0;
		}

		// Token: 0x0600533B RID: 21307 RVA: 0x00220C64 File Offset: 0x0021EE64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TrackBar trackBar_1)
		{
			EventHandler value = new EventHandler(this.method_1);
			TrackBar trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.ValueChanged -= value;
			}
			this.trackBar_0 = trackBar_1;
			trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.ValueChanged += value;
			}
		}

		// Token: 0x0600533C RID: 21308 RVA: 0x00220CB0 File Offset: 0x0021EEB0
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x0600533D RID: 21309 RVA: 0x00026A05 File Offset: 0x00024C05
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x00026A0E File Offset: 0x00024C0E
		private void FixedFacilityOrientation_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_0().Value = (int)Math.Round((double)this.activeUnit_0.GetCurrentHeading());
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x00220CC8 File Offset: 0x0021EEC8
		private void method_1(object sender, EventArgs e)
		{
			this.activeUnit_0.SetCurrentHeading((float)this.vmethod_0().Value);
			this.activeUnit_0.SetDesiredHeading(ActiveUnit._TurnRate.const_0, (float)this.vmethod_0().Value);
			this.vmethod_2().Text = "Current: " + Conversions.ToString(this.vmethod_0().Value);
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x000200A8 File Offset: 0x0001E2A8
		private void FixedFacilityOrientation_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x00004D83 File Offset: 0x00002F83
		private void FixedFacilityOrientation_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x04002705 RID: 9989
		[CompilerGenerated]
		private TrackBar trackBar_0;

		// Token: 0x04002706 RID: 9990
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04002707 RID: 9991
		public ActiveUnit activeUnit_0;
	}
}

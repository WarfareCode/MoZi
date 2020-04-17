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
	// Token: 0x020009FD RID: 2557
	[DesignerGenerated]
	public sealed partial class ScoringWindow : CommandForm
	{
		// Token: 0x06004D1E RID: 19742 RVA: 0x001EB534 File Offset: 0x001E9734
		public ScoringWindow()
		{
			base.Load += new EventHandler(this.ScoringWindow_Load);
			base.KeyDown += new KeyEventHandler(this.ScoringWindow_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.ScoringWindow_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x001EBBC4 File Offset: 0x001E9DC4
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x000249C8 File Offset: 0x00022BC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_8)
		{
			this.label_0 = label_8;
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x001EBBDC File Offset: 0x001E9DDC
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_1;
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x000249D1 File Offset: 0x00022BD1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_8)
		{
			this.label_1 = label_8;
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x001EBBF4 File Offset: 0x001E9DF4
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_2;
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x000249DA File Offset: 0x00022BDA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_8)
		{
			this.label_2 = label_8;
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x001EBC0C File Offset: 0x001E9E0C
		[CompilerGenerated]
		internal  NumericUpDown vmethod_6()
		{
			return this.numericUpDown_0;
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x001EBC24 File Offset: 0x001E9E24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(NumericUpDown numericUpDown_2)
		{
			EventHandler value = new EventHandler(this.method_1);
			NumericUpDown numericUpDown = this.numericUpDown_0;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged -= value;
			}
			this.numericUpDown_0 = numericUpDown_2;
			numericUpDown = this.numericUpDown_0;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged += value;
			}
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x001EBC70 File Offset: 0x001E9E70
		[CompilerGenerated]
		internal  NumericUpDown vmethod_8()
		{
			return this.numericUpDown_1;
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x001EBC88 File Offset: 0x001E9E88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(NumericUpDown numericUpDown_2)
		{
			EventHandler value = new EventHandler(this.method_2);
			NumericUpDown numericUpDown = this.numericUpDown_1;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged -= value;
			}
			this.numericUpDown_1 = numericUpDown_2;
			numericUpDown = this.numericUpDown_1;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged += value;
			}
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x001EBCD4 File Offset: 0x001E9ED4
		[CompilerGenerated]
		internal  Label vmethod_10()
		{
			return this.label_3;
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x000249E3 File Offset: 0x00022BE3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_8)
		{
			this.label_3 = label_8;
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x001EBCEC File Offset: 0x001E9EEC
		[CompilerGenerated]
		internal  Label vmethod_12()
		{
			return this.label_4;
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x000249EC File Offset: 0x00022BEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Label label_8)
		{
			this.label_4 = label_8;
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x001EBD04 File Offset: 0x001E9F04
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_5;
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x000249F5 File Offset: 0x00022BF5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_8)
		{
			this.label_5 = label_8;
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x001EBD1C File Offset: 0x001E9F1C
		[CompilerGenerated]
		internal  Label vmethod_16()
		{
			return this.label_6;
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x000249FE File Offset: 0x00022BFE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_8)
		{
			this.label_6 = label_8;
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x001EBD34 File Offset: 0x001E9F34
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_7;
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x00024A07 File Offset: 0x00022C07
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_8)
		{
			this.label_7 = label_8;
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x001EBD4C File Offset: 0x001E9F4C
		private void ScoringWindow_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			if (!Client.GetClientSide().Scoring_Disaster.HasValue)
			{
				Client.GetClientSide().Scoring_Disaster = new int?(-100);
			}
			this.vmethod_6().Value = new decimal(Client.GetClientSide().Scoring_Disaster.Value);
			if (!Client.GetClientSide().Scoring_Triumph.HasValue)
			{
				Client.GetClientSide().Scoring_Triumph = new int?(100);
			}
			this.vmethod_8().Value = new decimal(Client.GetClientSide().Scoring_Triumph.Value);
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x001EBDF4 File Offset: 0x001E9FF4
		private void method_1(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_6().Value))
			{
				Client.GetClientSide().Scoring_Disaster = new int?(Convert.ToInt32(this.vmethod_6().Value));
				this.vmethod_18().Text = "大败: " + Conversions.ToString(Client.GetClientSide().ScoringMode5());
				this.vmethod_16().Text = "小败: " + Conversions.ToString(Client.GetClientSide().ScoringMode4());
				this.vmethod_14().Text = "平局: " + Conversions.ToString(Client.GetClientSide().ScoringMode1());
				this.vmethod_12().Text = "小胜: " + Conversions.ToString(Client.GetClientSide().ScoringMode2());
				this.vmethod_10().Text = "大胜: " + Conversions.ToString(Client.GetClientSide().ScoringMode3());
			}
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x001EBEF4 File Offset: 0x001EA0F4
		private void method_2(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.vmethod_8().Value))
			{
				Client.GetClientSide().Scoring_Triumph = new int?(Convert.ToInt32(this.vmethod_8().Value));
				this.vmethod_18().Text = "大败: " + Conversions.ToString(Client.GetClientSide().ScoringMode5());
				this.vmethod_16().Text = "小败: " + Conversions.ToString(Client.GetClientSide().ScoringMode4());
				this.vmethod_14().Text = "平局: " + Conversions.ToString(Client.GetClientSide().ScoringMode1());
				this.vmethod_12().Text = "小胜: " + Conversions.ToString(Client.GetClientSide().ScoringMode2());
				this.vmethod_10().Text = "大胜: " + Conversions.ToString(Client.GetClientSide().ScoringMode3());
			}
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x001EBFF4 File Offset: 0x001EA1F4
		private void ScoringWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (!base.Visible || (e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.End && e.KeyCode != Keys.Home && (e.KeyCode != Keys.C || e.Modifiers != Keys.Control) && (e.KeyCode != Keys.X || e.Modifiers != Keys.Control) && (e.KeyCode != Keys.V || e.Modifiers != Keys.Control)))
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06004D39 RID: 19769 RVA: 0x00004D83 File Offset: 0x00002F83
		private void ScoringWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x0400247D RID: 9341
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x0400247E RID: 9342
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x0400247F RID: 9343
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04002480 RID: 9344
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x04002481 RID: 9345
		[CompilerGenerated]
		private NumericUpDown numericUpDown_1;

		// Token: 0x04002482 RID: 9346
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04002483 RID: 9347
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04002484 RID: 9348
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x04002485 RID: 9349
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x04002486 RID: 9350
		[CompilerGenerated]
		private Label label_7;
	}
}

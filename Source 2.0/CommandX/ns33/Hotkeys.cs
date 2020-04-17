using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Microsoft.VisualBasic.CompilerServices;
using ns32;

namespace ns33
{
	// Token: 0x02000986 RID: 2438
	[DesignerGenerated]
	public sealed partial class Hotkeys : CommandForm
	{
		// Token: 0x06003D47 RID: 15687 RVA: 0x0013BF84 File Offset: 0x0013A184
		public Hotkeys()
		{
			base.KeyDown += new KeyEventHandler(this.Hotkeys_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.Hotkeys_FormClosing);
			base.Load += new EventHandler(this.Hotkeys_Load);
			this.InitializeComponent();
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x0013CA04 File Offset: 0x0013AC04
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x0002002A File Offset: 0x0001E22A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_7)
		{
			this.label_0 = label_7;
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x0013CA1C File Offset: 0x0013AC1C
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_1;
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x00020033 File Offset: 0x0001E233
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_7)
		{
			this.label_1 = label_7;
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x0013CA34 File Offset: 0x0013AC34
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_2;
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x0002003C File Offset: 0x0001E23C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_7)
		{
			this.label_2 = label_7;
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x0013CA4C File Offset: 0x0013AC4C
		[CompilerGenerated]
		internal  Label vmethod_6()
		{
			return this.label_3;
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x00020045 File Offset: 0x0001E245
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Label label_7)
		{
			this.label_3 = label_7;
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x0013CA64 File Offset: 0x0013AC64
		[CompilerGenerated]
		internal  Label vmethod_8()
		{
			return this.label_4;
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x0002004E File Offset: 0x0001E24E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Label label_7)
		{
			this.label_4 = label_7;
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x0013CA7C File Offset: 0x0013AC7C
		[CompilerGenerated]
		internal  Label vmethod_10()
		{
			return this.label_5;
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x00020057 File Offset: 0x0001E257
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_7)
		{
			this.label_5 = label_7;
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x0013CA94 File Offset: 0x0013AC94
		[CompilerGenerated]
		internal  Label vmethod_12()
		{
			return this.label_6;
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00020060 File Offset: 0x0001E260
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Label label_7)
		{
			this.label_6 = label_7;
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x0013CAAC File Offset: 0x0013ACAC
		[CompilerGenerated]
		internal  RichTextBox vmethod_14()
		{
			return this.richTextBox_0;
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x00020069 File Offset: 0x0001E269
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(RichTextBox richTextBox_7)
		{
			this.richTextBox_0 = richTextBox_7;
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x0013CAC4 File Offset: 0x0013ACC4
		[CompilerGenerated]
		internal  RichTextBox vmethod_16()
		{
			return this.richTextBox_1;
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x00020072 File Offset: 0x0001E272
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(RichTextBox richTextBox_7)
		{
			this.richTextBox_1 = richTextBox_7;
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x0013CADC File Offset: 0x0013ACDC
		[CompilerGenerated]
		internal  RichTextBox vmethod_18()
		{
			return this.richTextBox_2;
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x0002007B File Offset: 0x0001E27B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(RichTextBox richTextBox_7)
		{
			this.richTextBox_2 = richTextBox_7;
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x0013CAF4 File Offset: 0x0013ACF4
		[CompilerGenerated]
		internal  RichTextBox vmethod_20()
		{
			return this.richTextBox_3;
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x00020084 File Offset: 0x0001E284
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(RichTextBox richTextBox_7)
		{
			this.richTextBox_3 = richTextBox_7;
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x0013CB0C File Offset: 0x0013AD0C
		[CompilerGenerated]
		internal  RichTextBox vmethod_22()
		{
			return this.richTextBox_4;
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x0002008D File Offset: 0x0001E28D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(RichTextBox richTextBox_7)
		{
			this.richTextBox_4 = richTextBox_7;
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x0013CB24 File Offset: 0x0013AD24
		[CompilerGenerated]
		internal  RichTextBox vmethod_24()
		{
			return this.richTextBox_5;
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x00020096 File Offset: 0x0001E296
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(RichTextBox richTextBox_7)
		{
			this.richTextBox_5 = richTextBox_7;
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x0013CB3C File Offset: 0x0013AD3C
		[CompilerGenerated]
		internal  RichTextBox vmethod_26()
		{
			return this.richTextBox_6;
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x0002009F File Offset: 0x0001E29F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(RichTextBox richTextBox_7)
		{
			this.richTextBox_6 = richTextBox_7;
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x000200A8 File Offset: 0x0001E2A8
		private void Hotkeys_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06003D67 RID: 15719 RVA: 0x00004D83 File Offset: 0x00002F83
		private void Hotkeys_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void Hotkeys_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x04001BEC RID: 7148
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001BED RID: 7149
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001BEE RID: 7150
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04001BEF RID: 7151
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04001BF0 RID: 7152
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04001BF1 RID: 7153
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x04001BF2 RID: 7154
		[CompilerGenerated]
		private Label label_6;

		// Token: 0x04001BF3 RID: 7155
		[CompilerGenerated]
		private RichTextBox richTextBox_0;

		// Token: 0x04001BF4 RID: 7156
		[CompilerGenerated]
		private RichTextBox richTextBox_1;

		// Token: 0x04001BF5 RID: 7157
		[CompilerGenerated]
		private RichTextBox richTextBox_2;

		// Token: 0x04001BF6 RID: 7158
		[CompilerGenerated]
		private RichTextBox richTextBox_3;

		// Token: 0x04001BF7 RID: 7159
		[CompilerGenerated]
		private RichTextBox richTextBox_4;

		// Token: 0x04001BF8 RID: 7160
		[CompilerGenerated]
		private RichTextBox richTextBox_5;

		// Token: 0x04001BF9 RID: 7161
		[CompilerGenerated]
		private RichTextBox richTextBox_6;
	}
}

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
	// Token: 0x02000A14 RID: 2580
	[DesignerGenerated]
	public sealed partial class RenameSide : CommandForm
	{
		// Token: 0x06004FD6 RID: 20438 RVA: 0x00025559 File Offset: 0x00023759
		public RenameSide()
		{
			base.Load += new EventHandler(this.RenameSide_Load);
			base.KeyDown += new KeyEventHandler(this.RenameSide_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x06004FD9 RID: 20441 RVA: 0x00203800 File Offset: 0x00201A00
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06004FDA RID: 20442 RVA: 0x0002558B File Offset: 0x0002378B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x00203818 File Offset: 0x00201A18
		[CompilerGenerated]
		internal  TextBox vmethod_2()
		{
			return this.textBox_0;
		}

		// Token: 0x06004FDC RID: 20444 RVA: 0x00203830 File Offset: 0x00201A30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TextBox textBox_1)
		{
			EventHandler value = new EventHandler(this.method_2);
			EventHandler value2 = new EventHandler(this.method_4);
			EventHandler value3 = new EventHandler(this.method_5);
			TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
				textBox.Enter -= value2;
				textBox.Leave -= value3;
			}
			this.textBox_0 = textBox_1;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged += value;
				textBox.Enter += value2;
				textBox.Leave += value3;
			}
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x002038B0 File Offset: 0x00201AB0
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_0;
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x002038C8 File Offset: 0x00201AC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_2)
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

		// Token: 0x06004FDF RID: 20447 RVA: 0x00203914 File Offset: 0x00201B14
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_1;
		}

		// Token: 0x06004FE0 RID: 20448 RVA: 0x0020392C File Offset: 0x00201B2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_3);
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

		// Token: 0x06004FE1 RID: 20449 RVA: 0x00203978 File Offset: 0x00201B78
		private void method_1(object sender, EventArgs e)
		{
			this.side_0.SetSideName(this.vmethod_2().Text);
			if (CommandFactory.GetCommandMain().GetSides().Visible)
			{
				CommandFactory.GetCommandMain().GetSides().method_2();
			}
			CommandFactory.GetCommandMain().GetMainForm().method_261();
			base.Close();
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x002039D4 File Offset: 0x00201BD4
		private void method_2(object sender, EventArgs e)
		{
			this.vmethod_4().Enabled = (Operators.CompareString(this.vmethod_2().Text, "", false) != 0);
			Side[] sides = Client.GetClientScenario().GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					if (string.Compare(sides[i].GetSideName(), this.vmethod_2().Text, false) == 0)
					{
						this.vmethod_4().Enabled = false;
					}
				}
			}
		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06004FE4 RID: 20452 RVA: 0x00025594 File Offset: 0x00023794
		private void RenameSide_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_2().Text = this.side_0.GetSideName();
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x00203A50 File Offset: 0x00201C50
		private void RenameSide_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else
			{
				if (this.bool_0)
				{
					if (e.KeyValue == 13 && base.Visible)
					{
						this.vmethod_0().Select();
						return;
					}
					if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
					{
						CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
					}
				}
				if (!this.bool_0 && (e.KeyValue != 32 || !base.Visible))
				{
					CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x000255C4 File Offset: 0x000237C4
		private void method_4(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x06004FE7 RID: 20455 RVA: 0x000255CD File Offset: 0x000237CD
		private void method_5(object sender, EventArgs e)
		{
			this.bool_0 = false;
			this.vmethod_0().Select();
		}

		// Token: 0x040025AF RID: 9647
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x040025B0 RID: 9648
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x040025B1 RID: 9649
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x040025B2 RID: 9650
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x040025B3 RID: 9651
		private bool bool_0;

		// Token: 0x040025B4 RID: 9652
		public Side side_0;
	}
}

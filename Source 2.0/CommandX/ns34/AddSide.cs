using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace ns34
{
	// Token: 0x02000A0B RID: 2571
	[DesignerGenerated]
	public sealed partial class AddSide : CommandForm
	{
		// Token: 0x06004EAB RID: 20139 RVA: 0x001FA630 File Offset: 0x001F8830
		public AddSide()
		{
			base.FormClosing += new FormClosingEventHandler(this.AddSide_FormClosing);
			base.Load += new EventHandler(this.AddSide_Load);
			base.KeyDown += new KeyEventHandler(this.AddSide_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x001FA954 File Offset: 0x001F8B54
		[CompilerGenerated]
		internal  Label vmethod_0()
		{
			return this.label_0;
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x00025110 File Offset: 0x00023310
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x001FA96C File Offset: 0x001F8B6C
		[CompilerGenerated]
		internal  TextBox vmethod_2()
		{
			return this.textBox_0;
		}

		// Token: 0x06004EB1 RID: 20145 RVA: 0x001FA984 File Offset: 0x001F8B84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TextBox textBox_1)
		{
			EventHandler value = new EventHandler(this.method_3);
			TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
			}
			this.textBox_0 = textBox_1;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged += value;
			}
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x001FA9D0 File Offset: 0x001F8BD0
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_0;
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x001FA9E8 File Offset: 0x001F8BE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_1);
			EventHandler value2 = new EventHandler(this.method_2);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
				button.DoubleClick -= value2;
			}
			this.button_0 = button_2;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
				button.DoubleClick += value2;
			}
		}

		// Token: 0x06004EB4 RID: 20148 RVA: 0x001FAA4C File Offset: 0x001F8C4C
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_1;
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x001FAA64 File Offset: 0x001F8C64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_2)
		{
			EventHandler value = new EventHandler(this.method_4);
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

		// Token: 0x06004EB6 RID: 20150 RVA: 0x001FAAB0 File Offset: 0x001F8CB0
		private void method_1(object sender, EventArgs e)
		{
			string text = this.vmethod_2().Text;
			Scenario clientScenario = Client.GetClientScenario();
			Client.AddSide(text, ref clientScenario);
			CommandFactory.GetCommandMain().GetMainForm().method_261();
			base.Close();
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x001FAAEC File Offset: 0x001F8CEC
		private void method_2(object sender, EventArgs e)
		{
			string text = this.vmethod_2().Text;
			Scenario clientScenario = Client.GetClientScenario();
			Client.AddSide(text, ref clientScenario);
			base.Close();
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x001FAB1C File Offset: 0x001F8D1C
		private void method_3(object sender, EventArgs e)
		{
			this.vmethod_4().Enabled = (Operators.CompareString(this.vmethod_2().Text, "", false) != 0);
			Side[] sides = Client.GetClientScenario().GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					if (Operators.CompareString(Strings.LCase(sides[i].GetSideName()), Strings.LCase(this.vmethod_2().Text), false) == 0)
					{
						this.vmethod_4().Enabled = false;
					}
				}
			}
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x00004D83 File Offset: 0x00002F83
		private void AddSide_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x001FABA4 File Offset: 0x001F8DA4
		private void AddSide_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			CommandFactory.GetCommandMain().GetMainForm().Enabled = false;
			this.vmethod_4().Enabled = (Operators.CompareString(this.vmethod_2().Text, "", false) != 0);
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_4(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		private void AddSide_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
		}

		// Token: 0x0400252B RID: 9515
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x0400252C RID: 9516
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x0400252D RID: 9517
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x0400252E RID: 9518
		[CompilerGenerated]
		private Button button_1;
	}
}

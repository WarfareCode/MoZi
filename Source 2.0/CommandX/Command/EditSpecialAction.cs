using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x02000983 RID: 2435
	[DesignerGenerated]
	public sealed partial class EditSpecialAction : CommandForm
	{
		// Token: 0x06003CFC RID: 15612 RVA: 0x0013A134 File Offset: 0x00138334
		public EditSpecialAction()
		{
			base.FormClosing += new FormClosingEventHandler(this.EditSpecialAction_FormClosing);
			base.Load += new EventHandler(this.EditSpecialAction_Load);
			base.KeyDown += new KeyEventHandler(this.EditSpecialAction_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x0013A93C File Offset: 0x00138B3C
		[CompilerGenerated]
		internal  TextBox vmethod_0()
		{
			return this.textBox_0;
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x0013A954 File Offset: 0x00138B54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TextBox textBox_3)
		{
			EventHandler value = new EventHandler(this.method_3);
			TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
			}
			this.textBox_0 = textBox_3;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged += value;
			}
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x0013A9A0 File Offset: 0x00138BA0
		[CompilerGenerated]
		internal  Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x0001FEC3 File Offset: 0x0001E0C3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Label label_5)
		{
			this.label_0 = label_5;
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x0013A9B8 File Offset: 0x00138BB8
		[CompilerGenerated]
		internal  Label vmethod_4()
		{
			return this.label_1;
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x0001FECC File Offset: 0x0001E0CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Label label_5)
		{
			this.label_1 = label_5;
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x0013A9D0 File Offset: 0x00138BD0
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_0;
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x0013A9E8 File Offset: 0x00138BE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_3)
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

		// Token: 0x06003D07 RID: 15623 RVA: 0x0013AA34 File Offset: 0x00138C34
		[CompilerGenerated]
		internal  Button vmethod_8()
		{
			return this.button_1;
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x0013AA4C File Offset: 0x00138C4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Button button_3)
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

		// Token: 0x06003D09 RID: 15625 RVA: 0x0013AA98 File Offset: 0x00138C98
		[CompilerGenerated]
		internal  TextBox vmethod_10()
		{
			return this.textBox_1;
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x0001FED5 File Offset: 0x0001E0D5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TextBox textBox_3)
		{
			this.textBox_1 = textBox_3;
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x0013AAB0 File Offset: 0x00138CB0
		[CompilerGenerated]
		internal  Label vmethod_12()
		{
			return this.label_2;
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x0001FEDE File Offset: 0x0001E0DE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Label label_5)
		{
			this.label_2 = label_5;
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x0013AAC8 File Offset: 0x00138CC8
		[CompilerGenerated]
		internal  NumericUpDown vmethod_14()
		{
			return this.numericUpDown_0;
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x0013AAE0 File Offset: 0x00138CE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(NumericUpDown numericUpDown_1)
		{
			EventHandler value = new EventHandler(this.method_5);
			NumericUpDown numericUpDown = this.numericUpDown_0;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged -= value;
			}
			this.numericUpDown_0 = numericUpDown_1;
			numericUpDown = this.numericUpDown_0;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged += value;
			}
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x0013AB2C File Offset: 0x00138D2C
		[CompilerGenerated]
		internal  Label vmethod_16()
		{
			return this.label_3;
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x0001FEE7 File Offset: 0x0001E0E7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Label label_5)
		{
			this.label_3 = label_5;
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x0013AB44 File Offset: 0x00138D44
		[CompilerGenerated]
		internal  Button vmethod_18()
		{
			return this.button_2;
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x0013AB5C File Offset: 0x00138D5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_4);
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

		// Token: 0x06003D13 RID: 15635 RVA: 0x0013ABA8 File Offset: 0x00138DA8
		[CompilerGenerated]
		internal  ComboBox vmethod_20()
		{
			return this.comboBox_0;
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(ComboBox comboBox_1)
		{
			this.comboBox_0 = comboBox_1;
		}

		// Token: 0x06003D15 RID: 15637 RVA: 0x0013ABC0 File Offset: 0x00138DC0
		[CompilerGenerated]
		internal  Label vmethod_22()
		{
			return this.label_4;
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x0001FEF9 File Offset: 0x0001E0F9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(Label label_5)
		{
			this.label_4 = label_5;
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x0013ABD8 File Offset: 0x00138DD8
		[CompilerGenerated]
		internal  TextBox vmethod_24()
		{
			return this.textBox_2;
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x0001FF02 File Offset: 0x0001E102
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(TextBox textBox_3)
		{
			this.textBox_2 = textBox_3;
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x0001FF0B File Offset: 0x0001E10B
		private void EditSpecialAction_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetListSpecialActions().ShowListSpecialActions();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x0013ABF0 File Offset: 0x00138DF0
		private void EditSpecialAction_Load(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.specialAction_0))
			{
				base.Close();
			}
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_0().Text = this.specialAction_0.Name;
			this.vmethod_10().Text = this.specialAction_0.Description;
			this.vmethod_8().Visible = true;
			this.vmethod_6().Visible = this.vmethod_8().Visible;
			if (!string.IsNullOrEmpty(this.specialAction_0.ScriptText))
			{
				this.vmethod_24().Text = this.specialAction_0.ScriptText;
			}
			this.vmethod_14().Value = new decimal(this.vmethod_24().Font.Size);
			this.vmethod_20().Items.AddRange(LuaSandBox.LuaMethods.OrderBy(EditSpecialAction.stringFunc).ToArray<string>());
			this.vmethod_20().SelectedIndex = 0;
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x0013ACF4 File Offset: 0x00138EF4
		private void method_2(object sender, EventArgs e)
		{
			this.specialAction_0.Name = this.vmethod_0().Text;
			this.specialAction_0.ScriptText = this.vmethod_24().Text;
			this.specialAction_0.Description = this.vmethod_10().Text;
			EditSpecialAction.Enum183 @enum = this.enum183_0;
			if (@enum != EditSpecialAction.Enum183.const_0)
			{
				if (@enum != EditSpecialAction.Enum183.const_1)
				{
				}
			}
			else
			{
				Client.GetClientSide().SpecialActions.Add(this.specialAction_0.GetGuid(), this.specialAction_0);
			}
			base.Close();
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x0001FF2B File Offset: 0x0001E12B
		private void method_3(object sender, EventArgs e)
		{
			this.specialAction_0.Name = this.vmethod_0().Text;
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void EditSpecialAction_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x0001FF43 File Offset: 0x0001E143
		private void method_4(object sender, EventArgs e)
		{
			this.vmethod_24().Text = this.vmethod_24().Text.Insert(this.vmethod_24().SelectionStart, Conversions.ToString(this.vmethod_20().SelectedItem));
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x0001FF7B File Offset: 0x0001E17B
		private void method_5(object sender, EventArgs e)
		{
			this.vmethod_24().Font = new Font(this.vmethod_24().Font.FontFamily, Convert.ToSingle(this.vmethod_14().Value));
		}

		// Token: 0x04001BC6 RID: 7110
		public static Func<string, string> stringFunc = (string string_0) => string_0;

		// Token: 0x04001BC8 RID: 7112
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04001BC9 RID: 7113
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04001BCA RID: 7114
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04001BCB RID: 7115
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x04001BCC RID: 7116
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04001BCD RID: 7117
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x04001BCE RID: 7118
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04001BCF RID: 7119
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x04001BD0 RID: 7120
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x04001BD1 RID: 7121
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04001BD2 RID: 7122
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04001BD3 RID: 7123
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x04001BD4 RID: 7124
		[CompilerGenerated]
		private TextBox textBox_2;

		// Token: 0x04001BD5 RID: 7125
		public SpecialAction specialAction_0;

		// Token: 0x04001BD6 RID: 7126
		public EditSpecialAction.Enum183 enum183_0;

		// Token: 0x02000984 RID: 2436
		public enum Enum183 : byte
		{
			// Token: 0x04001BD9 RID: 7129
			const_0,
			// Token: 0x04001BDA RID: 7130
			const_1
		}
	}
}

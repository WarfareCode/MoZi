using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua.Exceptions;
using ns32;

namespace Command
{
	// 控制台窗体
	[DesignerGenerated]
	public sealed partial class ConsoleWindow : Form
	{
		// Token: 0x060072F6 RID: 29430 RVA: 0x00030210 File Offset: 0x0002E410
		public ConsoleWindow()
		{
			base.Load += new EventHandler(this.ConsoleWindow_Load);
			base.FormClosed += new FormClosedEventHandler(this.ConsoleWindow_FormClosed);
			this.string_0 = "COMMAND_PIPE";
			this.InitializeComponent();
		}

		// Token: 0x060072F9 RID: 29433 RVA: 0x00419010 File Offset: 0x00417210
		[CompilerGenerated]
		internal  TextBox vmethod_0()
		{
			return this.textBox_0;
		}

		// Token: 0x060072FA RID: 29434 RVA: 0x0003024D File Offset: 0x0002E44D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TextBox textBox_2)
		{
			this.textBox_0 = textBox_2;
		}

		// Token: 0x060072FB RID: 29435 RVA: 0x00419028 File Offset: 0x00417228
		[CompilerGenerated]
		internal  TextBox vmethod_2()
		{
			return this.textBox_1;
		}

		// Token: 0x060072FC RID: 29436 RVA: 0x00419040 File Offset: 0x00417240
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TextBox textBox_2)
		{
			EventHandler value = new EventHandler(this.method_3);
			TextBox textBox = this.textBox_1;
			if (textBox != null)
			{
				textBox.Enter -= value;
			}
			this.textBox_1 = textBox_2;
			textBox = this.textBox_1;
			if (textBox != null)
			{
				textBox.Enter += value;
			}
		}

		// Token: 0x060072FD RID: 29437 RVA: 0x0041908C File Offset: 0x0041728C
		[CompilerGenerated]
		internal  Button GetButton_RunScript()
		{
			return this.Button_RunScript;
		}

		// Token: 0x060072FE RID: 29438 RVA: 0x004190A4 File Offset: 0x004172A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetButton_RunScript(Button button_3)
		{
			EventHandler value = new EventHandler(this.Button_RunScript_Click);
			Button button_RunScript = this.Button_RunScript;
			if (button_RunScript != null)
			{
				button_RunScript.Click -= value;
			}
			this.Button_RunScript = button_3;
			button_RunScript = this.Button_RunScript;
			if (button_RunScript != null)
			{
				button_RunScript.Click += value;
			}
		}

		// Token: 0x060072FF RID: 29439 RVA: 0x004190F0 File Offset: 0x004172F0
		[CompilerGenerated]
		internal  NumericUpDown vmethod_6()
		{
			return this.numericUpDown_0;
		}

		// Token: 0x06007300 RID: 29440 RVA: 0x00419108 File Offset: 0x00417308
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(NumericUpDown numericUpDown_1)
		{
			EventHandler value = new EventHandler(this.method_2);
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

		// Token: 0x06007301 RID: 29441 RVA: 0x00419154 File Offset: 0x00417354
		[CompilerGenerated]
		internal  Label vmethod_8()
		{
			return this.label_0;
		}

		// Token: 0x06007302 RID: 29442 RVA: 0x00030256 File Offset: 0x0002E456
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(Label label_1)
		{
			this.label_0 = label_1;
		}

		// Token: 0x06007303 RID: 29443 RVA: 0x0041916C File Offset: 0x0041736C
		[CompilerGenerated]
		internal  ComboBox vmethod_10()
		{
			return this.comboBox_0;
		}

		// Token: 0x06007304 RID: 29444 RVA: 0x0003025F File Offset: 0x0002E45F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ComboBox comboBox_2)
		{
			this.comboBox_0 = comboBox_2;
		}

		// Token: 0x06007305 RID: 29445 RVA: 0x00419184 File Offset: 0x00417384
		[CompilerGenerated]
		internal  Button vmethod_12()
		{
			return this.button_1;
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x0041919C File Offset: 0x0041739C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_4);
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

		// Token: 0x06007307 RID: 29447 RVA: 0x004191E8 File Offset: 0x004173E8
		[CompilerGenerated]
		internal  ComboBox vmethod_14()
		{
			return this.comboBox_1;
		}

		// Token: 0x06007308 RID: 29448 RVA: 0x00030268 File Offset: 0x0002E468
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ComboBox comboBox_2)
		{
			this.comboBox_1 = comboBox_2;
		}

		// Token: 0x06007309 RID: 29449 RVA: 0x00419200 File Offset: 0x00417400
		[CompilerGenerated]
		internal  Button vmethod_16()
		{
			return this.button_2;
		}

		// Token: 0x0600730A RID: 29450 RVA: 0x00419218 File Offset: 0x00417418
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Button button_3)
		{
			EventHandler value = new EventHandler(this.method_5);
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

		// Token: 0x0600730B RID: 29451 RVA: 0x00419264 File Offset: 0x00417464
		private void ConsoleWindow_Load(object sender, EventArgs e)
		{
			this.luaSandBox_0 = Client.GetClientScenario().GetLuaSandBox();
			this.vmethod_0().AppendText("Lua版本: " + this.luaSandBox_0.RunScript("_VERSION", true, null)[0].ToString());
			this.vmethod_10().Items.AddRange(LuaSandBox.LuaMethods.OrderBy(ConsoleWindow.stringFunc).ToArray<string>());
			this.vmethod_10().SelectedIndex = 0;
			if (Directory.Exists("Lua"))
			{
				try
				{
					this.vmethod_14().Items.AddRange(Directory.EnumerateFiles("Lua\\").ToArray<string>());
					this.vmethod_14().SelectedIndex = 0;
					goto IL_C4;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					goto IL_C4;
				}
			}
			Directory.CreateDirectory("Lua");
			IL_C4:
			this.vmethod_6().Value = new decimal(this.vmethod_2().Font.Size);
			this.luaSandBox_0.LuaPrint += new LuaSandBox.LuaPrintEventHandler(this.luaSandBox_0_LuaPrint);
			Client.smethod_13(new Client.Delegate49(this.method_0));
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_0()
		{
			base.Close();
		}

		// Token: 0x0600730D RID: 29453 RVA: 0x00419390 File Offset: 0x00417590
		private void luaSandBox_0_LuaPrint(object object_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(object_0)));
			if (LuaSandBox.Singleton().RunInteractive)
			{
				this.vmethod_0().AppendText("\r\n" + stringBuilder.ToString());
			}
			string text = "";
			object obj = stringBuilder.ToString();
			LuaUtility.smethod_30(ref text, ref obj, false);
		}

		// Token: 0x0600730E RID: 29454 RVA: 0x004193F8 File Offset: 0x004175F8
		private void Button_RunScript_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.vmethod_2().Text.ToString(), "", false) != 0)
			{
				TextBox textBox;
				(textBox = this.vmethod_0()).Text = textBox.Text + "\r\n>> " + this.vmethod_2().Text;
				StringBuilder stringBuilder = new StringBuilder();
				if (this.vmethod_2().Text.Length != 0)
				{
					stringBuilder.Append(this.vmethod_2().Text);
					string text = "Console: ";
					object obj = stringBuilder.ToString();
					LuaUtility.smethod_30(ref text, ref obj, true);
					stringBuilder.Clear();
				}
				object[] array = null;
				try
				{
					array = this.luaSandBox_0.RunScript(this.vmethod_2().Text, true, "Console");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					this.vmethod_0().AppendText("\r\nInternal ERROR: " + ex2.Message);
					stringBuilder.Append("Internal ERROR: " + ex2.Message).Append("\r\n");
					ProjectData.ClearProjectError();
				}
				if (!Information.IsNothing(array) && array[0] != null)
				{
					if (array[0].GetType() == typeof(LuaScriptException))
					{
						if (!Information.IsNothing(((LuaScriptException)array[0]).InnerException))
						{
							this.vmethod_0().AppendText("\r\nERROR: " + ((LuaScriptException)array[0]).InnerException.Message);
							stringBuilder.Append("ERROR: " + ((LuaScriptException)array[0]).InnerException.Message).Append("\r\n");
						}
						else
						{
							this.vmethod_0().AppendText("\r\nERROR: " + ((LuaScriptException)array[0]).Source + " " + ((LuaScriptException)array[0]).Message);
							stringBuilder.Append("ERROR: " + ((LuaScriptException)array[0]).Source + " " + ((LuaScriptException)array[0]).Message).Append("\r\n");
						}
					}
					else
					{
						this.vmethod_0().AppendText("\r\n" + LuaUtility.smethod_29(array));
						stringBuilder.Append(LuaUtility.smethod_29(array));
					}
				}
				this.vmethod_0().Select(this.vmethod_0().TextLength, 0);
				this.vmethod_0().ScrollToCaret();
				Client.b_Completed = true;
				if (stringBuilder != null)
				{
					string text = "";
					if (stringBuilder.Length != 0)
					{
						text = "";
						object obj = stringBuilder.ToString();
						LuaUtility.smethod_30(ref text, ref obj, false);
					}
					else
					{
						text = "...";
						object obj = "";
						LuaUtility.smethod_30(ref text, ref obj, false);
					}
				}
			}
		}

		// Token: 0x0600730F RID: 29455 RVA: 0x00030271 File Offset: 0x0002E471
		private void method_2(object sender, EventArgs e)
		{
			this.vmethod_2().Font = new Font(this.vmethod_2().Font.FontFamily, Convert.ToSingle(this.vmethod_6().Value));
		}

		// Token: 0x06007310 RID: 29456 RVA: 0x000302A3 File Offset: 0x0002E4A3
		private void method_3(object sender, EventArgs e)
		{
			if (CommandFactory.GetComputer().Keyboard.ShiftKeyDown)
			{
				this.Button_RunScript_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06007311 RID: 29457 RVA: 0x000302C6 File Offset: 0x0002E4C6
		private void method_4(object sender, EventArgs e)
		{
			this.vmethod_2().SelectedText = Conversions.ToString(this.vmethod_10().SelectedItem);
		}

		// Token: 0x06007312 RID: 29458 RVA: 0x004196D4 File Offset: 0x004178D4
		private void method_5(object sender, EventArgs e)
		{
			try
			{
				this.vmethod_2().Text = File.ReadAllText(Conversions.ToString(this.vmethod_14().SelectedItem));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200417", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06007313 RID: 29459 RVA: 0x000302E3 File Offset: 0x0002E4E3
		private void ConsoleWindow_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.luaSandBox_0.LuaPrint -= new LuaSandBox.LuaPrintEventHandler(this.luaSandBox_0_LuaPrint);
			Client.smethod_14(new Client.Delegate49(this.method_0));
		}

		// Token: 0x0400415E RID: 16734
		public static Func<string, string> stringFunc = (string string_0) => string_0;

		// Token: 0x04004160 RID: 16736
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x04004161 RID: 16737
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x04004162 RID: 16738
		[CompilerGenerated]
		private Button Button_RunScript;

		// Token: 0x04004163 RID: 16739
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x04004164 RID: 16740
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04004165 RID: 16741
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04004166 RID: 16742
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x04004167 RID: 16743
		[CompilerGenerated]
		private ComboBox comboBox_1;

		// Token: 0x04004168 RID: 16744
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x04004169 RID: 16745
		private string string_0;

		// Token: 0x0400416A RID: 16746
		private LuaSandBox luaSandBox_0;
	}
}

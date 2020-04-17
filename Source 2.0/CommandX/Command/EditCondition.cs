using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns15;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x02000B55 RID: 2901
	[DesignerGenerated]
	public sealed partial class EditCondition : CommandForm
	{
		// Token: 0x06005F9D RID: 24477 RVA: 0x002D2DFC File Offset: 0x002D0FFC
		public EditCondition()
		{
			base.FormClosing += new FormClosingEventHandler(this.EditCondition_FormClosing);
			base.Load += new EventHandler(this.EditCondition_Load);
			base.KeyDown += new KeyEventHandler(this.EditCondition_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x002D3BCC File Offset: 0x002D1DCC
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_0()
		{
			return this.textBox_0;
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x002D3BE4 File Offset: 0x002D1DE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(System.Windows.Forms.TextBox textBox_2)
		{
			EventHandler value = new EventHandler(this.method_6);
			System.Windows.Forms.TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
			}
			this.textBox_0 = textBox_2;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.TextChanged += value;
			}
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x002D3C30 File Offset: 0x002D1E30
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_2()
		{
			return this.label_0;
		}

		// Token: 0x06005FA3 RID: 24483 RVA: 0x0002A6FE File Offset: 0x000288FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(System.Windows.Forms.Label label_7)
		{
			this.label_0 = label_7;
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x002D3C48 File Offset: 0x002D1E48
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_4()
		{
			return this.label_1;
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x0002A707 File Offset: 0x00028907
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(System.Windows.Forms.Label label_7)
		{
			this.label_1 = label_7;
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x002D3C60 File Offset: 0x002D1E60
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_6()
		{
			return this.button_0;
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x002D3C78 File Offset: 0x002D1E78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(System.Windows.Forms.Button button_3)
		{
			EventHandler value = new EventHandler(this.method_1);
			System.Windows.Forms.Button button = this.button_0;
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

		// Token: 0x06005FA8 RID: 24488 RVA: 0x002D3CC4 File Offset: 0x002D1EC4
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_8()
		{
			return this.button_1;
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x002D3CDC File Offset: 0x002D1EDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(System.Windows.Forms.Button button_3)
		{
			EventHandler value = new EventHandler(this.method_2);
			System.Windows.Forms.Button button = this.button_1;
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

		// Token: 0x06005FAA RID: 24490 RVA: 0x002D3D28 File Offset: 0x002D1F28
		[CompilerGenerated]
		internal  TabPage vmethod_10()
		{
			return this.tabPage_0;
		}

		// Token: 0x06005FAB RID: 24491 RVA: 0x0002A710 File Offset: 0x00028910
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(TabPage tabPage_3)
		{
			this.tabPage_0 = tabPage_3;
		}

		// Token: 0x06005FAC RID: 24492 RVA: 0x002D3D40 File Offset: 0x002D1F40
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_12()
		{
			return this.comboBox_0;
		}

		// Token: 0x06005FAD RID: 24493 RVA: 0x002D3D58 File Offset: 0x002D1F58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(System.Windows.Forms.ComboBox comboBox_4)
		{
			EventHandler value = new EventHandler(this.method_3);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_4;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x002D3DA4 File Offset: 0x002D1FA4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_14()
		{
			return this.label_2;
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x0002A719 File Offset: 0x00028919
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(System.Windows.Forms.Label label_7)
		{
			this.label_2 = label_7;
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x002D3DBC File Offset: 0x002D1FBC
		[CompilerGenerated]
		internal  Control1 vmethod_16()
		{
			return this.control1_0;
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x0002A722 File Offset: 0x00028922
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Control1 control1_1)
		{
			this.control1_0 = control1_1;
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x002D3DD4 File Offset: 0x002D1FD4
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_18()
		{
			return this.comboBox_1;
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x002D3DEC File Offset: 0x002D1FEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(System.Windows.Forms.ComboBox comboBox_4)
		{
			EventHandler value = new EventHandler(this.method_5);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_1 = comboBox_4;
			comboBox = this.comboBox_1;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x002D3E38 File Offset: 0x002D2038
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_20()
		{
			return this.label_3;
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x0002A72B File Offset: 0x0002892B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(System.Windows.Forms.Label label_7)
		{
			this.label_3 = label_7;
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x002D3E50 File Offset: 0x002D2050
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_22()
		{
			return this.comboBox_2;
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x002D3E68 File Offset: 0x002D2068
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(System.Windows.Forms.ComboBox comboBox_4)
		{
			EventHandler value = new EventHandler(this.method_4);
			System.Windows.Forms.ComboBox comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_2 = comboBox_4;
			comboBox = this.comboBox_2;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x002D3EB4 File Offset: 0x002D20B4
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_24()
		{
			return this.label_4;
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x0002A734 File Offset: 0x00028934
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(System.Windows.Forms.Label label_7)
		{
			this.label_4 = label_7;
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x002D3ECC File Offset: 0x002D20CC
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_26()
		{
			return this.checkBox_0;
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x002D3EE4 File Offset: 0x002D20E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(System.Windows.Forms.CheckBox checkBox_2)
		{
			EventHandler value = new EventHandler(this.method_7);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_0 = checkBox_2;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x002D3F30 File Offset: 0x002D2130
		[CompilerGenerated]
		internal  TabPage vmethod_28()
		{
			return this.tabPage_1;
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x0002A73D File Offset: 0x0002893D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(TabPage tabPage_3)
		{
			this.tabPage_1 = tabPage_3;
		}

		// Token: 0x06005FBE RID: 24510 RVA: 0x002D3F48 File Offset: 0x002D2148
		[CompilerGenerated]
		internal  System.Windows.Forms.CheckBox vmethod_30()
		{
			return this.checkBox_1;
		}

		// Token: 0x06005FBF RID: 24511 RVA: 0x002D3F60 File Offset: 0x002D2160
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(System.Windows.Forms.CheckBox checkBox_2)
		{
			EventHandler value = new EventHandler(this.method_8);
			System.Windows.Forms.CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click -= value;
			}
			this.checkBox_1 = checkBox_2;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.Click += value;
			}
		}

		// Token: 0x06005FC0 RID: 24512 RVA: 0x002D3FAC File Offset: 0x002D21AC
		[CompilerGenerated]
		internal  TabPage vmethod_32()
		{
			return this.tabPage_2;
		}

		// Token: 0x06005FC1 RID: 24513 RVA: 0x0002A746 File Offset: 0x00028946
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(TabPage tabPage_3)
		{
			this.tabPage_2 = tabPage_3;
		}

		// Token: 0x06005FC2 RID: 24514 RVA: 0x002D3FC4 File Offset: 0x002D21C4
		[CompilerGenerated]
		internal  NumericUpDown vmethod_34()
		{
			return this.numericUpDown_0;
		}

		// Token: 0x06005FC3 RID: 24515 RVA: 0x002D3FDC File Offset: 0x002D21DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(NumericUpDown numericUpDown_1)
		{
			EventHandler value = new EventHandler(this.method_10);
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

		// Token: 0x06005FC4 RID: 24516 RVA: 0x002D4028 File Offset: 0x002D2228
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_36()
		{
			return this.label_5;
		}

		// Token: 0x06005FC5 RID: 24517 RVA: 0x0002A74F File Offset: 0x0002894F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(System.Windows.Forms.Label label_7)
		{
			this.label_5 = label_7;
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x002D4040 File Offset: 0x002D2240
		[CompilerGenerated]
		internal  System.Windows.Forms.Button vmethod_38()
		{
			return this.button_2;
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x002D4058 File Offset: 0x002D2258
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(System.Windows.Forms.Button button_3)
		{
			EventHandler value = new EventHandler(this.method_9);
			System.Windows.Forms.Button button = this.button_2;
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

		// Token: 0x06005FC8 RID: 24520 RVA: 0x002D40A4 File Offset: 0x002D22A4
		[CompilerGenerated]
		internal  System.Windows.Forms.ComboBox vmethod_40()
		{
			return this.comboBox_3;
		}

		// Token: 0x06005FC9 RID: 24521 RVA: 0x0002A758 File Offset: 0x00028958
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(System.Windows.Forms.ComboBox comboBox_4)
		{
			this.comboBox_3 = comboBox_4;
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x002D40BC File Offset: 0x002D22BC
		[CompilerGenerated]
		internal  System.Windows.Forms.Label vmethod_42()
		{
			return this.label_6;
		}

		// Token: 0x06005FCB RID: 24523 RVA: 0x0002A761 File Offset: 0x00028961
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(System.Windows.Forms.Label label_7)
		{
			this.label_6 = label_7;
		}

		// Token: 0x06005FCC RID: 24524 RVA: 0x002D40D4 File Offset: 0x002D22D4
		[CompilerGenerated]
		internal  System.Windows.Forms.TextBox vmethod_44()
		{
			return this.textBox_1;
		}

		// Token: 0x06005FCD RID: 24525 RVA: 0x0002A76A File Offset: 0x0002896A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(System.Windows.Forms.TextBox textBox_2)
		{
			this.textBox_1 = textBox_2;
		}

		// Token: 0x06005FCE RID: 24526 RVA: 0x0002A773 File Offset: 0x00028973
		private void EditCondition_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetListConditions().ShowListConditions();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x002D40EC File Offset: 0x002D22EC
		private void EditCondition_Load(object sender, EventArgs e)
		{
			if (Information.IsNothing(this.eventCondition_0))
			{
				base.Close();
			}
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_0().Text = this.eventCondition_0.strDescription;
			this.vmethod_8().Visible = true;
			this.vmethod_6().Visible = this.vmethod_8().Visible;
			checked
			{
				switch (this.eventCondition_0.eventConditionType)
				{
				case EventCondition.EventConditionType.SidePosture:
				{
					this.vmethod_16().SelectedIndex = 0;
					this.vmethod_12().Items.Clear();
					this.vmethod_12().DisplayMember = "Content";
					this.vmethod_26().Checked = ((EventCondition_SidePosture)this.eventCondition_0).NOT;
					Side[] sides = Client.GetClientScenario().GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						ComboBoxItem comboBoxItem = new ComboBoxItem();
						comboBoxItem.Content = side.GetSideName();
						comboBoxItem.Tag = side.GetGuid();
						this.vmethod_12().Items.Add(comboBoxItem);
					}
					IEnumerator enumerator = this.vmethod_12().Items.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ComboBoxItem comboBoxItem2 = (ComboBoxItem)enumerator.Current;
							if (Operators.ConditionalCompareObjectEqual(comboBoxItem2.Tag, ((EventCondition_SidePosture)this.eventCondition_0).ObserverSideID, false))
							{
								this.vmethod_12().SelectedItem = comboBoxItem2;
								break;
							}
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					this.vmethod_22().Items.Clear();
					this.vmethod_22().DisplayMember = "Content";
					Side[] sides2 = Client.GetClientScenario().GetSides();
					for (int j = 0; j < sides2.Length; j++)
					{
						Side side2 = sides2[j];
						ComboBoxItem comboBoxItem3 = new ComboBoxItem();
						comboBoxItem3.Content = side2.GetSideName();
						comboBoxItem3.Tag = side2.GetGuid();
						this.vmethod_22().Items.Add(comboBoxItem3);
					}
					IEnumerator enumerator2 = this.vmethod_22().Items.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							ComboBoxItem comboBoxItem4 = (ComboBoxItem)enumerator2.Current;
							if (Operators.ConditionalCompareObjectEqual(comboBoxItem4.Tag, ((EventCondition_SidePosture)this.eventCondition_0).TargetSideID, false))
							{
								this.vmethod_22().SelectedItem = comboBoxItem4;
								break;
							}
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					this.vmethod_18().SelectedIndex = (int)((EventCondition_SidePosture)this.eventCondition_0).TargetPosture;
					break;
				}
				case EventCondition.EventConditionType.ScenHasStarted:
					this.vmethod_16().SelectedIndex = 1;
					this.vmethod_30().Checked = ((EventCondition_ScenHasStarted)this.eventCondition_0).NOT;
					break;
				case EventCondition.EventConditionType.LuaScript:
					this.vmethod_16().SelectedIndex = 2;
					this.vmethod_34().Value = new decimal(this.vmethod_44().Font.Size);
					this.vmethod_44().Text = ((EventCondition_LuaScript)this.eventCondition_0).ScriptText;
					this.vmethod_40().Items.AddRange(LuaSandBox.LuaMethods.OrderBy(EditCondition.stringFunc).ToArray<string>());
					this.vmethod_40().SelectedIndex = 0;
					break;
				}
				this.vmethod_16().TabPages[0].Enabled = false;
				this.vmethod_16().TabPages[1].Enabled = false;
				this.vmethod_16().TabPages[2].Enabled = false;
				this.vmethod_16().TabPages[this.vmethod_16().SelectedIndex].Enabled = true;
			}
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x0001F6B5 File Offset: 0x0001D8B5
		private void method_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x002D44D4 File Offset: 0x002D26D4
		private void method_2(object sender, EventArgs e)
		{
			EventCondition.EventConditionType eventConditionType = this.eventCondition_0.eventConditionType;
			if (eventConditionType == EventCondition.EventConditionType.LuaScript)
			{
				((EventCondition_LuaScript)this.eventCondition_0).ScriptText = this.vmethod_44().Text;
			}
			EditCondition.Enum185 @enum = this.enum185_0;
			if (@enum != EditCondition.Enum185.const_0)
			{
				if (@enum != EditCondition.Enum185.const_1)
				{
				}
			}
			else
			{
				Client.GetClientScenario().GetEventConditions().Add(this.eventCondition_0.GetGuid(), this.eventCondition_0);
			}
			base.Close();
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x0002A793 File Offset: 0x00028993
		private void method_3(object sender, EventArgs e)
		{
			((EventCondition_SidePosture)this.eventCondition_0).ObserverSideID = Conversions.ToString(((ComboBoxItem)this.vmethod_12().SelectedItem).Tag);
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x0002A7BF File Offset: 0x000289BF
		private void method_4(object sender, EventArgs e)
		{
			((EventCondition_SidePosture)this.eventCondition_0).TargetSideID = Conversions.ToString(((ComboBoxItem)this.vmethod_22().SelectedItem).Tag);
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x0002A7EB File Offset: 0x000289EB
		private void method_5(object sender, EventArgs e)
		{
			((EventCondition_SidePosture)this.eventCondition_0).TargetPosture = (Misc.PostureStance)this.vmethod_18().SelectedIndex;
		}

		// Token: 0x06005FD5 RID: 24533 RVA: 0x0002A809 File Offset: 0x00028A09
		private void method_6(object sender, EventArgs e)
		{
			this.eventCondition_0.strDescription = this.vmethod_0().Text;
		}

		// Token: 0x06005FD6 RID: 24534 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void EditCondition_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x06005FD7 RID: 24535 RVA: 0x0002A821 File Offset: 0x00028A21
		private void method_7(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventCondition_0) && this.eventCondition_0.eventConditionType == EventCondition.EventConditionType.SidePosture)
			{
				((EventCondition_SidePosture)this.eventCondition_0).NOT = this.vmethod_26().Checked;
			}
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x0002A861 File Offset: 0x00028A61
		private void method_8(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.eventCondition_0) && this.eventCondition_0.eventConditionType == EventCondition.EventConditionType.ScenHasStarted)
			{
				((EventCondition_ScenHasStarted)this.eventCondition_0).NOT = this.vmethod_30().Checked;
			}
		}

		// Token: 0x06005FD9 RID: 24537 RVA: 0x0002A8A1 File Offset: 0x00028AA1
		private void method_9(object sender, EventArgs e)
		{
			this.vmethod_44().Text = this.vmethod_44().Text.Insert(this.vmethod_44().SelectionStart, Conversions.ToString(this.vmethod_40().SelectedItem));
		}

		// Token: 0x06005FDA RID: 24538 RVA: 0x0002A8D9 File Offset: 0x00028AD9
		private void method_10(object sender, EventArgs e)
		{
			this.vmethod_44().Font = new Font(this.vmethod_44().Font.FontFamily, Convert.ToSingle(this.vmethod_34().Value));
		}

		// Token: 0x04003292 RID: 12946
		public static Func<string, string> stringFunc = (string string_0) => string_0;

		// Token: 0x04003294 RID: 12948
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_0;

		// Token: 0x04003295 RID: 12949
		[CompilerGenerated]
		private System.Windows.Forms.Label label_0;

		// Token: 0x04003296 RID: 12950
		[CompilerGenerated]
		private System.Windows.Forms.Label label_1;

		// Token: 0x04003297 RID: 12951
		[CompilerGenerated]
		private System.Windows.Forms.Button button_0;

		// Token: 0x04003298 RID: 12952
		[CompilerGenerated]
		private System.Windows.Forms.Button button_1;

		// Token: 0x04003299 RID: 12953
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x0400329A RID: 12954
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_0;

		// Token: 0x0400329B RID: 12955
		[CompilerGenerated]
		private System.Windows.Forms.Label label_2;

		// Token: 0x0400329C RID: 12956
		[CompilerGenerated]
		private Control1 control1_0;

		// Token: 0x0400329D RID: 12957
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_1;

		// Token: 0x0400329E RID: 12958
		[CompilerGenerated]
		private System.Windows.Forms.Label label_3;

		// Token: 0x0400329F RID: 12959
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_2;

		// Token: 0x040032A0 RID: 12960
		[CompilerGenerated]
		private System.Windows.Forms.Label label_4;

		// Token: 0x040032A1 RID: 12961
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_0;

		// Token: 0x040032A2 RID: 12962
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x040032A3 RID: 12963
		[CompilerGenerated]
		private System.Windows.Forms.CheckBox checkBox_1;

		// Token: 0x040032A4 RID: 12964
		[CompilerGenerated]
		private TabPage tabPage_2;

		// Token: 0x040032A5 RID: 12965
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x040032A6 RID: 12966
		[CompilerGenerated]
		private System.Windows.Forms.Label label_5;

		// Token: 0x040032A7 RID: 12967
		[CompilerGenerated]
		private System.Windows.Forms.Button button_2;

		// Token: 0x040032A8 RID: 12968
		[CompilerGenerated]
		private System.Windows.Forms.ComboBox comboBox_3;

		// Token: 0x040032A9 RID: 12969
		[CompilerGenerated]
		private System.Windows.Forms.Label label_6;

		// Token: 0x040032AA RID: 12970
		[CompilerGenerated]
		private System.Windows.Forms.TextBox textBox_1;

		// Token: 0x040032AB RID: 12971
		public EventCondition eventCondition_0;

		// Token: 0x040032AC RID: 12972
		public EditCondition.Enum185 enum185_0;

		// Token: 0x02000B56 RID: 2902
		public enum Enum185 : byte
		{
			// Token: 0x040032AF RID: 12975
			const_0,
			// Token: 0x040032B0 RID: 12976
			const_1
		}
	}
}

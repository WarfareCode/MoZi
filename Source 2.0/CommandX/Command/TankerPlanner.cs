using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x02000A2F RID: 2607
	[DesignerGenerated]
	public sealed partial class TankerPlanner : CommandForm
	{
		// Token: 0x0600528B RID: 21131 RVA: 0x0021BD90 File Offset: 0x00219F90
		public TankerPlanner()
		{
			base.VisibleChanged += new EventHandler(this.TankerPlanner_VisibleChanged);
			base.FormClosing += new FormClosingEventHandler(this.TankerPlanner_FormClosing);
			base.KeyDown += new KeyEventHandler(this.TankerPlanner_KeyDown);
			base.Load += new EventHandler(this.TankerPlanner_Load);
			this.bool_0 = false;
			this.bool_1 = false;
			this.bool_2 = false;
			this.bool_3 = false;
			this.bool_4 = false;
			this.bool_5 = false;
			this.InitializeComponent();
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x0021CBB0 File Offset: 0x0021ADB0
		[CompilerGenerated]
		internal  RadioButton vmethod_0()
		{
			return this.radioButton_0;
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x0021CBC8 File Offset: 0x0021ADC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_20);
			RadioButton radioButton = this.radioButton_0;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_0 = radioButton_7;
			radioButton = this.radioButton_0;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x0021CC14 File Offset: 0x0021AE14
		[CompilerGenerated]
		internal  RadioButton vmethod_2()
		{
			return this.radioButton_1;
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x0021CC2C File Offset: 0x0021AE2C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_19);
			RadioButton radioButton = this.radioButton_1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_1 = radioButton_7;
			radioButton = this.radioButton_1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x0021CC78 File Offset: 0x0021AE78
		[CompilerGenerated]
		internal  GroupBox vmethod_4()
		{
			return this.groupBox_0;
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x000266D1 File Offset: 0x000248D1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(GroupBox groupBox_3)
		{
			this.groupBox_0 = groupBox_3;
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x0021CC90 File Offset: 0x0021AE90
		[CompilerGenerated]
		internal  RadioButton vmethod_6()
		{
			return this.radioButton_2;
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x0021CCA8 File Offset: 0x0021AEA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_25);
			RadioButton radioButton = this.radioButton_2;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_2 = radioButton_7;
			radioButton = this.radioButton_2;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x0021CCF4 File Offset: 0x0021AEF4
		[CompilerGenerated]
		internal  RadioButton vmethod_8()
		{
			return this.radioButton_3;
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x0021CD0C File Offset: 0x0021AF0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_24);
			RadioButton radioButton = this.radioButton_3;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_3 = radioButton_7;
			radioButton = this.radioButton_3;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x0021CD58 File Offset: 0x0021AF58
		[CompilerGenerated]
		internal  RadioButton vmethod_10()
		{
			return this.radioButton_4;
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x0021CD70 File Offset: 0x0021AF70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_23);
			RadioButton radioButton = this.radioButton_4;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_4 = radioButton_7;
			radioButton = this.radioButton_4;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x0021CDBC File Offset: 0x0021AFBC
		[CompilerGenerated]
		internal  RadioButton vmethod_12()
		{
			return this.radioButton_5;
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x0021CDD4 File Offset: 0x0021AFD4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_22);
			RadioButton radioButton = this.radioButton_5;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_5 = radioButton_7;
			radioButton = this.radioButton_5;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x0021CE20 File Offset: 0x0021B020
		[CompilerGenerated]
		internal  RadioButton vmethod_14()
		{
			return this.radioButton_6;
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x0021CE38 File Offset: 0x0021B038
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(RadioButton radioButton_7)
		{
			EventHandler value = new EventHandler(this.method_21);
			RadioButton radioButton = this.radioButton_6;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.radioButton_6 = radioButton_7;
			radioButton = this.radioButton_6;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x0021CE84 File Offset: 0x0021B084
		[CompilerGenerated]
		internal  TextBox vmethod_16()
		{
			return this.textBox_0;
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x0021CE9C File Offset: 0x0021B09C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(TextBox textBox_5)
		{
			EventHandler value = new EventHandler(this.method_4);
			EventHandler value2 = new EventHandler(this.method_5);
			TextBox textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_0 = textBox_5;
			textBox = this.textBox_0;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x0021CF00 File Offset: 0x0021B100
		[CompilerGenerated]
		internal  Label vmethod_18()
		{
			return this.label_0;
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x000266DA File Offset: 0x000248DA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(Label label_6)
		{
			this.label_0 = label_6;
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x0021CF18 File Offset: 0x0021B118
		[CompilerGenerated]
		internal  Label vmethod_20()
		{
			return this.label_1;
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x000266E3 File Offset: 0x000248E3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Label label_6)
		{
			this.label_1 = label_6;
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x0021CF30 File Offset: 0x0021B130
		[CompilerGenerated]
		internal  TextBox vmethod_22()
		{
			return this.textBox_1;
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x0021CF48 File Offset: 0x0021B148
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(TextBox textBox_5)
		{
			EventHandler value = new EventHandler(this.method_6);
			EventHandler value2 = new EventHandler(this.method_7);
			TextBox textBox = this.textBox_1;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_1 = textBox_5;
			textBox = this.textBox_1;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x0021CFAC File Offset: 0x0021B1AC
		[CompilerGenerated]
		internal  Label vmethod_24()
		{
			return this.label_2;
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x000266EC File Offset: 0x000248EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(Label label_6)
		{
			this.label_2 = label_6;
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x0021CFC4 File Offset: 0x0021B1C4
		[CompilerGenerated]
		internal  TextBox vmethod_26()
		{
			return this.textBox_2;
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x0021CFDC File Offset: 0x0021B1DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(TextBox textBox_5)
		{
			EventHandler value = new EventHandler(this.method_8);
			EventHandler value2 = new EventHandler(this.method_9);
			TextBox textBox = this.textBox_2;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_2 = textBox_5;
			textBox = this.textBox_2;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x0021D040 File Offset: 0x0021B240
		[CompilerGenerated]
		internal  ListBox vmethod_28()
		{
			return this.listBox_0;
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x0021D058 File Offset: 0x0021B258
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(ListBox listBox_1)
		{
			EventHandler value = new EventHandler(this.method_3);
			ListBox listBox = this.listBox_0;
			if (listBox != null)
			{
				listBox.Click -= value;
			}
			this.listBox_0 = listBox_1;
			listBox = this.listBox_0;
			if (listBox != null)
			{
				listBox.Click += value;
			}
		}

		// Token: 0x060052AC RID: 21164 RVA: 0x0021D0A4 File Offset: 0x0021B2A4
		[CompilerGenerated]
		internal  Label vmethod_30()
		{
			return this.label_3;
		}

		// Token: 0x060052AD RID: 21165 RVA: 0x000266F5 File Offset: 0x000248F5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(Label label_6)
		{
			this.label_3 = label_6;
		}

		// Token: 0x060052AE RID: 21166 RVA: 0x0021D0BC File Offset: 0x0021B2BC
		[CompilerGenerated]
		internal  TextBox vmethod_32()
		{
			return this.textBox_3;
		}

		// Token: 0x060052AF RID: 21167 RVA: 0x0021D0D4 File Offset: 0x0021B2D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(TextBox textBox_5)
		{
			EventHandler value = new EventHandler(this.method_10);
			EventHandler value2 = new EventHandler(this.method_11);
			TextBox textBox = this.textBox_3;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_3 = textBox_5;
			textBox = this.textBox_3;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x0021D138 File Offset: 0x0021B338
		[CompilerGenerated]
		internal  CheckBox vmethod_34()
		{
			return this.checkBox_0;
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x0021D150 File Offset: 0x0021B350
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(CheckBox checkBox_1)
		{
			EventHandler value = new EventHandler(this.method_26);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_0 = checkBox_1;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x0021D19C File Offset: 0x0021B39C
		[CompilerGenerated]
		internal  GroupBox vmethod_36()
		{
			return this.groupBox_1;
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x000266FE File Offset: 0x000248FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(GroupBox groupBox_3)
		{
			this.groupBox_1 = groupBox_3;
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x0021D1B4 File Offset: 0x0021B3B4
		[CompilerGenerated]
		internal  GroupBox vmethod_38()
		{
			return this.groupBox_2;
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x00026707 File Offset: 0x00024907
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(GroupBox groupBox_3)
		{
			this.groupBox_2 = groupBox_3;
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x0021D1CC File Offset: 0x0021B3CC
		[CompilerGenerated]
		internal  Label vmethod_40()
		{
			return this.label_4;
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x00026710 File Offset: 0x00024910
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(Label label_6)
		{
			this.label_4 = label_6;
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x0021D1E4 File Offset: 0x0021B3E4
		[CompilerGenerated]
		internal  TextBox vmethod_42()
		{
			return this.textBox_4;
		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x0021D1FC File Offset: 0x0021B3FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(TextBox textBox_5)
		{
			EventHandler value = new EventHandler(this.method_12);
			EventHandler value2 = new EventHandler(this.method_13);
			TextBox textBox = this.textBox_4;
			if (textBox != null)
			{
				textBox.Enter -= value;
				textBox.Leave -= value2;
			}
			this.textBox_4 = textBox_5;
			textBox = this.textBox_4;
			if (textBox != null)
			{
				textBox.Enter += value;
				textBox.Leave += value2;
			}
		}

		// Token: 0x060052BA RID: 21178 RVA: 0x0021D260 File Offset: 0x0021B460
		[CompilerGenerated]
		internal  Label vmethod_44()
		{
			return this.label_5;
		}

		// Token: 0x060052BB RID: 21179 RVA: 0x00026719 File Offset: 0x00024919
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(Label label_6)
		{
			this.label_5 = label_6;
		}

		// Token: 0x060052BC RID: 21180 RVA: 0x0021D278 File Offset: 0x0021B478
		[CompilerGenerated]
		internal  CheckBox vmethod_46()
		{
			return this.checkBox_1;
		}

		// Token: 0x060052BD RID: 21181 RVA: 0x0021D290 File Offset: 0x0021B490
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_47(CheckBox checkBox_2)
		{
			EventHandler value = new EventHandler(this.method_26);
			EventHandler value2 = new EventHandler(this.method_27);
			EventHandler value3 = new EventHandler(this.method_27);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
				checkBox.CheckedChanged -= value2;
				checkBox.CheckedChanged -= value3;
			}
			this.checkBox_1 = checkBox_2;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
				checkBox.CheckedChanged += value2;
				checkBox.CheckedChanged += value3;
			}
		}

		// Token: 0x060052BE RID: 21182 RVA: 0x0021D310 File Offset: 0x0021B510
		private void method_1()
		{
			this.vmethod_28().Items.Clear();
			Side[] sides = Client.GetClientScenario().GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					if (side == Client.GetClientSide() || side.IsFriendlyToSide(Client.GetClientSide()))
					{
						foreach (Mission current in side.GetMissionCollection().OrderBy(TankerPlanner.MissionFunc0))
						{
							if (current.MissionClass == Mission._MissionClass.Support || current.MissionClass == Mission._MissionClass.Ferry)
							{
								TreeNode treeNode = new TreeNode();
								if (side == Client.GetClientSide())
								{
									treeNode.Name = current.Name;
								}
								else
								{
									treeNode.Name = current.Name + " (" + side.GetSideName() + ")";
								}
								treeNode.Tag = current;
								this.vmethod_28().Items.Add(treeNode);
							}
						}
					}
				}
			}
			int num = this.vmethod_28().Items.Count - 1;
			for (int j = 0; j <= num; j++)
			{
				if (this.mission_0.TankerMissionList.Contains((Mission)NewLateBinding.LateGet(this.vmethod_28().Items[j], null, "Tag", new object[0], null, null, null)))
				{
					this.vmethod_28().SetSelected(j, true);
				}
				else
				{
					this.vmethod_28().SetSelected(j, false);
				}
			}
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x0021D4C8 File Offset: 0x0021B6C8
		private void TankerPlanner_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				Mission.TankerMethod tankerUsage = this.mission_0.TankerUsage;
				if (tankerUsage != Mission.TankerMethod.Automatic)
				{
					if (tankerUsage == Mission.TankerMethod.Mission)
					{
						this.vmethod_2().Checked = false;
						this.vmethod_0().Checked = true;
					}
				}
				else
				{
					this.vmethod_2().Checked = true;
					this.vmethod_0().Checked = false;
				}
				this.method_2();
			}
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x0021D534 File Offset: 0x0021B734
		private void TankerPlanner_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.method_14();
			this.method_15();
			this.method_16();
			this.method_17();
			this.method_18();
			if (this.mission_0.TankerUsage == Mission.TankerMethod.Mission && this.mission_0.TankerMissionList.Count == 0)
			{
				this.mission_0.TankerUsage = Mission.TankerMethod.Automatic;
			}
			base.Hide();
			this.vmethod_28().Select();
			Client.GetMissionEditor().BringToFront();
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x0021D5B8 File Offset: 0x0021B7B8
		private void method_2()
		{
			Mission.TankerMethod tankerUsage = this.mission_0.TankerUsage;
			if (tankerUsage != Mission.TankerMethod.Automatic)
			{
				if (tankerUsage == Mission.TankerMethod.Mission)
				{
					this.vmethod_4().Enabled = true;
					this.vmethod_36().Enabled = true;
					if (this.mission_0.MissionClass == Mission._MissionClass.Strike)
					{
						this.vmethod_34().Enabled = true;
					}
					else
					{
						this.vmethod_34().Enabled = false;
					}
					this.vmethod_38().Enabled = true;
					this.vmethod_28().Enabled = true;
					this.method_1();
				}
			}
			else
			{
				this.vmethod_4().Enabled = true;
				this.vmethod_36().Enabled = false;
				this.vmethod_38().Enabled = true;
				this.vmethod_28().Enabled = false;
				this.vmethod_28().Items.Clear();
			}
			if (this.mission_0.TankerUsage == Mission.TankerMethod.Mission)
			{
				if (this.mission_0.TankerMinNumber_Total <= 0)
				{
					this.vmethod_16().Text = "未定";
				}
				else
				{
					this.vmethod_16().Text = Conversions.ToString(this.mission_0.TankerMinNumber_Total);
				}
				if (this.mission_0.TankerMinNumber_Airborne <= 0)
				{
					this.vmethod_22().Text = "未定";
				}
				else
				{
					this.vmethod_22().Text = Conversions.ToString(this.mission_0.TankerMinNumber_Airborne);
				}
				if (this.mission_0.TankerMinNumber_Station <= 0)
				{
					this.vmethod_26().Text = "未定";
				}
				else
				{
					this.vmethod_26().Text = Conversions.ToString(this.mission_0.TankerMinNumber_Station);
				}
				this.vmethod_34().Checked = this.mission_0.LaunchMissionWithoutTankersInPlace;
			}
			this.vmethod_46().Checked = this.mission_0.bTankerFollowsReceivers;
			if (this.mission_0.MaxReceiversInQueuePerTanker_Airborne <= 0)
			{
				this.vmethod_32().Text = "未定";
			}
			else
			{
				this.vmethod_32().Text = Conversions.ToString(this.mission_0.MaxReceiversInQueuePerTanker_Airborne);
			}
			if (this.mission_0.FuelQtyToStartLookingForTanker_Airborne <= 0)
			{
				this.vmethod_42().Text = "None";
			}
			else
			{
				this.vmethod_42().Text = Conversions.ToString(this.mission_0.FuelQtyToStartLookingForTanker_Airborne);
			}
			if (this.mission_0.TankerMaxDistance_Airborne == 2147483647)
			{
				this.vmethod_14().Checked = true;
				this.vmethod_12().Checked = false;
				this.vmethod_10().Checked = false;
				this.vmethod_8().Checked = false;
				this.vmethod_6().Checked = false;
			}
			else if (this.mission_0.TankerMaxDistance_Airborne == 500)
			{
				this.vmethod_14().Checked = false;
				this.vmethod_12().Checked = true;
				this.vmethod_10().Checked = false;
				this.vmethod_8().Checked = false;
				this.vmethod_6().Checked = false;
			}
			else if (this.mission_0.TankerMaxDistance_Airborne == 250)
			{
				this.vmethod_14().Checked = false;
				this.vmethod_12().Checked = false;
				this.vmethod_10().Checked = true;
				this.vmethod_8().Checked = false;
				this.vmethod_6().Checked = false;
			}
			else if (this.mission_0.TankerMaxDistance_Airborne == 100)
			{
				this.vmethod_14().Checked = false;
				this.vmethod_12().Checked = false;
				this.vmethod_10().Checked = false;
				this.vmethod_8().Checked = true;
				this.vmethod_6().Checked = false;
			}
			else if (this.mission_0.TankerMaxDistance_Airborne == 50)
			{
				this.vmethod_14().Checked = false;
				this.vmethod_12().Checked = false;
				this.vmethod_10().Checked = false;
				this.vmethod_8().Checked = false;
				this.vmethod_6().Checked = true;
			}
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x0013AD80 File Offset: 0x00138F80
		private void TankerPlanner_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x060052C3 RID: 21187 RVA: 0x0021D9A8 File Offset: 0x0021BBA8
		private void method_3(object sender, EventArgs e)
		{
			int num = this.vmethod_28().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (this.vmethod_28().GetSelected(i))
				{
					if (!this.mission_0.TankerMissionList.Contains((Mission)NewLateBinding.LateGet(this.vmethod_28().Items[i], null, "Tag", new object[0], null, null, null)))
					{
						this.mission_0.TankerMissionList.Add((Mission)NewLateBinding.LateGet(this.vmethod_28().Items[i], null, "Tag", new object[0], null, null, null));
					}
				}
				else if (this.mission_0.TankerMissionList.Contains((Mission)NewLateBinding.LateGet(this.vmethod_28().Items[i], null, "Tag", new object[0], null, null, null)))
				{
					this.mission_0.TankerMissionList.Remove((Mission)NewLateBinding.LateGet(this.vmethod_28().Items[i], null, "Tag", new object[0], null, null, null));
				}
			}
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00026722 File Offset: 0x00024922
		private void method_4(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x0002672B File Offset: 0x0002492B
		private void method_5(object sender, EventArgs e)
		{
			this.method_14();
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x00026733 File Offset: 0x00024933
		private void method_6(object sender, EventArgs e)
		{
			this.bool_1 = true;
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x0002673C File Offset: 0x0002493C
		private void method_7(object sender, EventArgs e)
		{
			this.method_15();
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x00026744 File Offset: 0x00024944
		private void method_8(object sender, EventArgs e)
		{
			this.bool_2 = true;
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x0002674D File Offset: 0x0002494D
		private void method_9(object sender, EventArgs e)
		{
			this.method_16();
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x00026755 File Offset: 0x00024955
		private void method_10(object sender, EventArgs e)
		{
			this.bool_4 = true;
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x0002675E File Offset: 0x0002495E
		private void method_11(object sender, EventArgs e)
		{
			this.method_17();
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x00026766 File Offset: 0x00024966
		private void method_12(object sender, EventArgs e)
		{
			this.bool_5 = true;
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x0002676F File Offset: 0x0002496F
		private void method_13(object sender, EventArgs e)
		{
			this.method_18();
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x0021DAE8 File Offset: 0x0021BCE8
		private void method_14()
		{
			if (this.bool_0)
			{
				if (Information.IsNothing(this.mission_0))
				{
					return;
				}
				if (string.IsNullOrEmpty(this.vmethod_16().Text))
				{
					this.mission_0.TankerMinNumber_Total = 0;
					this.vmethod_16().Text = "未定";
				}
				if (!Versioned.IsNumeric(this.vmethod_16().Text))
				{
					return;
				}
				int num = Conversions.ToInteger(this.vmethod_16().Text);
				if (num < 0)
				{
					num = 0;
				}
				this.mission_0.TankerMinNumber_Total = num;
				if (num == 0)
				{
					this.vmethod_16().Text = "未定";
				}
				else
				{
					this.vmethod_16().Text = Conversions.ToString(num);
				}
			}
			this.bool_0 = false;
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x0021DBB4 File Offset: 0x0021BDB4
		private void method_15()
		{
			if (this.bool_1)
			{
				if (Information.IsNothing(this.mission_0))
				{
					return;
				}
				if (string.IsNullOrEmpty(this.vmethod_22().Text))
				{
					this.mission_0.TankerMinNumber_Airborne = 0;
					this.vmethod_22().Text = "未定";
				}
				if (!Versioned.IsNumeric(this.vmethod_22().Text))
				{
					return;
				}
				int num = Conversions.ToInteger(this.vmethod_22().Text);
				if (num < 0)
				{
					num = 0;
				}
				this.mission_0.TankerMinNumber_Airborne = num;
				if (num == 0)
				{
					this.vmethod_22().Text = "未定";
				}
				else
				{
					this.vmethod_22().Text = Conversions.ToString(num);
				}
			}
			this.bool_1 = false;
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x0021DC80 File Offset: 0x0021BE80
		private void method_16()
		{
			if (this.bool_2)
			{
				if (Information.IsNothing(this.mission_0))
				{
					return;
				}
				if (string.IsNullOrEmpty(this.vmethod_26().Text))
				{
					this.mission_0.TankerMinNumber_Station = 0;
					this.vmethod_26().Text = "未定";
				}
				if (!Versioned.IsNumeric(this.vmethod_26().Text))
				{
					return;
				}
				int num = Conversions.ToInteger(this.vmethod_26().Text);
				if (num < 0)
				{
					num = 0;
				}
				this.mission_0.TankerMinNumber_Station = num;
				if (num == 0)
				{
					this.vmethod_26().Text = "未定";
				}
				else
				{
					this.vmethod_26().Text = Conversions.ToString(num);
				}
			}
			this.bool_2 = false;
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x0021DD4C File Offset: 0x0021BF4C
		private void method_17()
		{
			if (this.bool_4)
			{
				if (Information.IsNothing(this.mission_0))
				{
					return;
				}
				if (string.IsNullOrEmpty(this.vmethod_32().Text))
				{
					this.mission_0.MaxReceiversInQueuePerTanker_Airborne = 0;
					this.vmethod_32().Text = "未定";
				}
				if (!Versioned.IsNumeric(this.vmethod_32().Text))
				{
					return;
				}
				int num = Conversions.ToInteger(this.vmethod_32().Text);
				if (num < 0)
				{
					num = 0;
				}
				this.mission_0.MaxReceiversInQueuePerTanker_Airborne = num;
				if (num == 0)
				{
					this.vmethod_32().Text = "未定";
				}
				else
				{
					this.vmethod_32().Text = Conversions.ToString(num);
				}
			}
			this.bool_4 = false;
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x0021DE18 File Offset: 0x0021C018
		private void method_18()
		{
			if (this.bool_5)
			{
				if (Information.IsNothing(this.mission_0))
				{
					return;
				}
				if (string.IsNullOrEmpty(this.vmethod_42().Text))
				{
					if (this.mission_0.MissionClass == Mission._MissionClass.Strike)
					{
						this.mission_0.FuelQtyToStartLookingForTanker_Airborne = 85;
						this.vmethod_42().Text = "85";
					}
					else if (this.mission_0.MissionClass == Mission._MissionClass.Ferry)
					{
						this.mission_0.FuelQtyToStartLookingForTanker_Airborne = 80;
						this.vmethod_42().Text = "80";
					}
					else if (this.mission_0.MissionClass == Mission._MissionClass.Support)
					{
						this.mission_0.FuelQtyToStartLookingForTanker_Airborne = 0;
						this.vmethod_42().Text = "0";
					}
					else
					{
						this.mission_0.FuelQtyToStartLookingForTanker_Airborne = 60;
						this.vmethod_42().Text = "60";
					}
				}
				if (!Versioned.IsNumeric(this.vmethod_42().Text))
				{
					return;
				}
				int num = Conversions.ToInteger(this.vmethod_42().Text);
				if (num > 90)
				{
					this.vmethod_42().Text = "90";
					this.mission_0.FuelQtyToStartLookingForTanker_Airborne = 90;
				}
				else if (num < 0)
				{
					this.vmethod_42().Text = "0";
					this.mission_0.FuelQtyToStartLookingForTanker_Airborne = 0;
				}
				else
				{
					this.mission_0.FuelQtyToStartLookingForTanker_Airborne = num;
				}
			}
			this.bool_5 = false;
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00026777 File Offset: 0x00024977
		private void method_19(object sender, EventArgs e)
		{
			if (this.vmethod_2().Checked)
			{
				this.mission_0.TankerUsage = Mission.TankerMethod.Automatic;
				this.method_2();
			}
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x0002679B File Offset: 0x0002499B
		private void method_20(object sender, EventArgs e)
		{
			if (this.vmethod_0().Checked)
			{
				this.mission_0.TankerUsage = Mission.TankerMethod.Mission;
				this.method_2();
			}
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x000267BF File Offset: 0x000249BF
		private void method_21(object sender, EventArgs e)
		{
			this.mission_0.TankerMaxDistance_Airborne = 2147483647;
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x000267D1 File Offset: 0x000249D1
		private void method_22(object sender, EventArgs e)
		{
			this.mission_0.TankerMaxDistance_Airborne = 500;
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x000267E3 File Offset: 0x000249E3
		private void method_23(object sender, EventArgs e)
		{
			this.mission_0.TankerMaxDistance_Airborne = 250;
		}

		// Token: 0x060052D8 RID: 21208 RVA: 0x000267F5 File Offset: 0x000249F5
		private void method_24(object sender, EventArgs e)
		{
			this.mission_0.TankerMaxDistance_Airborne = 100;
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x00026804 File Offset: 0x00024A04
		private void method_25(object sender, EventArgs e)
		{
			this.mission_0.TankerMaxDistance_Airborne = 50;
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x00026813 File Offset: 0x00024A13
		private void method_26(object sender, EventArgs e)
		{
			this.mission_0.LaunchMissionWithoutTankersInPlace = this.vmethod_34().Checked;
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x0001F6BD File Offset: 0x0001D8BD
		private void TankerPlanner_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x0002682B File Offset: 0x00024A2B
		private void method_27(object sender, EventArgs e)
		{
			this.mission_0.bTankerFollowsReceivers = this.vmethod_46().Checked;
		}

		// Token: 0x040026BA RID: 9914
		public static Func<Mission, string> MissionFunc0 = (Mission mission_0) => mission_0.Name;

		// Token: 0x040026BC RID: 9916
		[CompilerGenerated]
		private RadioButton radioButton_0;

		// Token: 0x040026BD RID: 9917
		[CompilerGenerated]
		private RadioButton radioButton_1;

		// Token: 0x040026BE RID: 9918
		[CompilerGenerated]
		private GroupBox groupBox_0;

		// Token: 0x040026BF RID: 9919
		[CompilerGenerated]
		private RadioButton radioButton_2;

		// Token: 0x040026C0 RID: 9920
		[CompilerGenerated]
		private RadioButton radioButton_3;

		// Token: 0x040026C1 RID: 9921
		[CompilerGenerated]
		private RadioButton radioButton_4;

		// Token: 0x040026C2 RID: 9922
		[CompilerGenerated]
		private RadioButton radioButton_5;

		// Token: 0x040026C3 RID: 9923
		[CompilerGenerated]
		private RadioButton radioButton_6;

		// Token: 0x040026C4 RID: 9924
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x040026C5 RID: 9925
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x040026C6 RID: 9926
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x040026C7 RID: 9927
		[CompilerGenerated]
		private TextBox textBox_1;

		// Token: 0x040026C8 RID: 9928
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x040026C9 RID: 9929
		[CompilerGenerated]
		private TextBox textBox_2;

		// Token: 0x040026CA RID: 9930
		[CompilerGenerated]
		private ListBox listBox_0;

		// Token: 0x040026CB RID: 9931
		[CompilerGenerated]
		private Label label_3;

		// Token: 0x040026CC RID: 9932
		[CompilerGenerated]
		private TextBox textBox_3;

		// Token: 0x040026CD RID: 9933
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x040026CE RID: 9934
		[CompilerGenerated]
		private GroupBox groupBox_1;

		// Token: 0x040026CF RID: 9935
		[CompilerGenerated]
		private GroupBox groupBox_2;

		// Token: 0x040026D0 RID: 9936
		[CompilerGenerated]
		private Label label_4;

		// Token: 0x040026D1 RID: 9937
		[CompilerGenerated]
		private TextBox textBox_4;

		// Token: 0x040026D2 RID: 9938
		[CompilerGenerated]
		private Label label_5;

		// Token: 0x040026D3 RID: 9939
		[AccessedThroughProperty("CB_FollowReceivers"), CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x040026D4 RID: 9940
		public Mission mission_0;

		// Token: 0x040026D5 RID: 9941
		private bool bool_0;

		// Token: 0x040026D6 RID: 9942
		private bool bool_1;

		// Token: 0x040026D7 RID: 9943
		private bool bool_2 = false;

		// Token: 0x040026D8 RID: 9944
		private bool bool_3;

		// Token: 0x040026D9 RID: 9945
		private bool bool_4;

		// Token: 0x040026DA RID: 9946
		private bool bool_5;
	}
}

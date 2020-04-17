using System;
using System.Collections.ObjectModel;
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
using ns34;

namespace Command
{
	// 设置作战方窗口
	[DesignerGenerated]
	public sealed partial class Sides : CommandForm
	{
		// Token: 0x06004FE8 RID: 20456 RVA: 0x00203B84 File Offset: 0x00201D84
		public Sides()
		{
			base.FormClosing += new FormClosingEventHandler(this.Sides_FormClosing);
			base.Load += new EventHandler(this.Sides_Load);
			base.KeyDown += new KeyEventHandler(this.Sides_KeyDown);
			this.InitializeComponent();
		}

		// Token: 0x06004FEB RID: 20459 RVA: 0x002044D8 File Offset: 0x002026D8
		[CompilerGenerated]
		internal  ListBox vmethod_0()
		{
			return this.listBox_0;
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x002044F0 File Offset: 0x002026F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(ListBox listBox_1)
		{
			MouseEventHandler value = new MouseEventHandler(this.method_3);
			EventHandler value2 = new EventHandler(this.method_4);
			ListBox listBox = this.listBox_0;
			if (listBox != null)
			{
				listBox.MouseDoubleClick -= value;
				listBox.SelectedIndexChanged -= value2;
			}
			this.listBox_0 = listBox_1;
			listBox = this.listBox_0;
			if (listBox != null)
			{
				listBox.MouseDoubleClick += value;
				listBox.SelectedIndexChanged += value2;
			}
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x00204554 File Offset: 0x00202754
		[CompilerGenerated]
		internal  Button vmethod_2()
		{
			return this.button_0;
		}

		// Token: 0x06004FEE RID: 20462 RVA: 0x0020456C File Offset: 0x0020276C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_1);
			Button button = this.button_0;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_0 = button_5;
			button = this.button_0;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x002045B8 File Offset: 0x002027B8
		[CompilerGenerated]
		internal  Button vmethod_4()
		{
			return this.button_1;
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x002045D0 File Offset: 0x002027D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_5);
			Button button = this.button_1;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_1 = button_5;
			button = this.button_1;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x0020461C File Offset: 0x0020281C
		[CompilerGenerated]
		internal  Button vmethod_6()
		{
			return this.button_2;
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x00204634 File Offset: 0x00202834
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_6);
			Button button = this.button_2;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_2 = button_5;
			button = this.button_2;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x00204680 File Offset: 0x00202880
		[CompilerGenerated]
		internal  ImageList vmethod_8()
		{
			return this.imageList_0;
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x00025606 File Offset: 0x00023806
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ImageList imageList_1)
		{
			this.imageList_0 = imageList_1;
		}

		// Token: 0x06004FF5 RID: 20469 RVA: 0x00204698 File Offset: 0x00202898
		[CompilerGenerated]
		internal  CheckBox vmethod_10()
		{
			return this.checkBox_0;
		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x002046B0 File Offset: 0x002028B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(CheckBox checkBox_3)
		{
			EventHandler value = new EventHandler(this.method_7);
			CheckBox checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_0 = checkBox_3;
			checkBox = this.checkBox_0;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06004FF7 RID: 20471 RVA: 0x002046FC File Offset: 0x002028FC
		[CompilerGenerated]
		internal  Button vmethod_12()
		{
			return this.button_3;
		}

		// Token: 0x06004FF8 RID: 20472 RVA: 0x00204714 File Offset: 0x00202914
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_8);
			Button button = this.button_3;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_3 = button_5;
			button = this.button_3;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x00204760 File Offset: 0x00202960
		[CompilerGenerated]
		internal  Button vmethod_14()
		{
			return this.button_4;
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x00204778 File Offset: 0x00202978
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Button button_5)
		{
			EventHandler value = new EventHandler(this.method_9);
			Button button = this.button_4;
			if (button != null)
			{
				button.Click -= value;
			}
			this.button_4 = button_5;
			button = this.button_4;
			if (button != null)
			{
				button.Click += value;
			}
		}

		// Token: 0x06004FFB RID: 20475 RVA: 0x002047C4 File Offset: 0x002029C4
		[CompilerGenerated]
		internal  StatusStrip vmethod_16()
		{
			return this.statusStrip_0;
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x0002560F File Offset: 0x0002380F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(StatusStrip statusStrip_1)
		{
			this.statusStrip_0 = statusStrip_1;
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x002047DC File Offset: 0x002029DC
		[CompilerGenerated]
		internal  ToolStripStatusLabel vmethod_18()
		{
			return this.toolStripStatusLabel_0;
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x00025618 File Offset: 0x00023818
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(ToolStripStatusLabel toolStripStatusLabel_1)
		{
			this.toolStripStatusLabel_0 = toolStripStatusLabel_1;
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x002047F4 File Offset: 0x002029F4
		[CompilerGenerated]
		internal  Label vmethod_20()
		{
			return this.label_0;
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x00025621 File Offset: 0x00023821
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(Label label_2)
		{
			this.label_0 = label_2;
		}

		// Token: 0x06005001 RID: 20481 RVA: 0x0020480C File Offset: 0x00202A0C
		[CompilerGenerated]
		internal  ComboBox GetCB_Awareness()
		{
			return this.CB_Awareness;
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x00204824 File Offset: 0x00202A24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCB_Awareness(ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.CB_Awareness_SelectionChangeCommitted);
			EventHandler value2 = new EventHandler(this.CB_Awareness_Enter);
			EventHandler value3 = new EventHandler(this.CB_Awareness_Leave);
			ComboBox cB_Awareness = this.CB_Awareness;
			if (cB_Awareness != null)
			{
				cB_Awareness.SelectionChangeCommitted -= value;
				cB_Awareness.Enter -= value2;
				cB_Awareness.Leave -= value3;
			}
			this.CB_Awareness = comboBox_1;
			cB_Awareness = this.CB_Awareness;
			if (cB_Awareness != null)
			{
				cB_Awareness.SelectionChangeCommitted += value;
				cB_Awareness.Enter += value2;
				cB_Awareness.Leave += value3;
			}
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x002048A4 File Offset: 0x00202AA4
		[CompilerGenerated]
		internal  CheckBox GetCB_CollectiveResponse()
		{
			return this.checkBox_1;
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x002048BC File Offset: 0x00202ABC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(CheckBox checkBox_3)
		{
			EventHandler value = new EventHandler(this.method_11);
			CheckBox checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_1 = checkBox_3;
			checkBox = this.checkBox_1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06005005 RID: 20485 RVA: 0x00204908 File Offset: 0x00202B08
		[CompilerGenerated]
		internal  Label GetLabel_Proficiency()
		{
			return this.label_1;
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x0002562A File Offset: 0x0002382A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(Label label_2)
		{
			this.label_1 = label_2;
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x00204920 File Offset: 0x00202B20
		[CompilerGenerated]
		internal  TrackBar GetTrackBar_Proficiency()
		{
			return this.trackBar_0;
		}

		// Token: 0x06005008 RID: 20488 RVA: 0x00204938 File Offset: 0x00202B38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(TrackBar trackBar_1)
		{
			EventHandler value = new EventHandler(this.method_12);
			TrackBar trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.Scroll -= value;
			}
			this.trackBar_0 = trackBar_1;
			trackBar = this.trackBar_0;
			if (trackBar != null)
			{
				trackBar.Scroll += value;
			}
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x00204984 File Offset: 0x00202B84
		[CompilerGenerated]
		internal  CheckBox GetCB_AutoTrackCivilians()
		{
			return this.checkBox_2;
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x0020499C File Offset: 0x00202B9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(CheckBox checkBox_3)
		{
			EventHandler value = new EventHandler(this.method_15);
			CheckBox checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.checkBox_2 = checkBox_3;
			checkBox = this.checkBox_2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x00025633 File Offset: 0x00023833
		private void Sides_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!CommandFactory.GetCommandMain().GetAddNewUnit().Visible)
			{
				CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			}
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x0600500C RID: 20492 RVA: 0x00025665 File Offset: 0x00023865
		private void Sides_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.method_2();
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x00025685 File Offset: 0x00023885
		private void method_1(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetAddSide().Show();
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x002049E8 File Offset: 0x00202BE8
		public void method_2()
		{
			this.vmethod_0().Items.Clear();
			foreach (Side current in Client.GetClientScenario().GetSides().OrderBy(Sides.SideFunc0))
			{
				this.vmethod_0().Items.Add(current.GetSideName());
			}
			this.vmethod_4().Enabled = (this.vmethod_0().Items.Count > 0 & this.vmethod_0().SelectedIndex > -1);
			this.vmethod_6().Enabled = (this.vmethod_0().Items.Count > 0 & this.vmethod_0().SelectedIndex > -1);
			this.GetLabel_Proficiency().Visible = (this.vmethod_0().Items.Count > 0 & this.vmethod_0().SelectedIndex > -1);
			this.GetTrackBar_Proficiency().Visible = (this.vmethod_0().Items.Count > 0 & this.vmethod_0().SelectedIndex > -1);
			if (CommandFactory.GetCommandMain().GetAddNewUnit().Visible)
			{
				CommandFactory.GetCommandMain().GetAddNewUnit().method_6();
			}
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x00204B40 File Offset: 0x00202D40
		private void method_3(object sender, MouseEventArgs e)
		{
			checked
			{
				if (this.vmethod_0().SelectedIndex >= 0)
				{
					Side[] sides = Client.GetClientScenario().GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						if (Operators.ConditionalCompareObjectEqual(side.GetSideName(), this.vmethod_0().SelectedItem, false))
						{
							Client.SetClientSide(side);
							base.Close();
							return;
						}
					}
					base.Close();
				}
			}
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x00204BAC File Offset: 0x00202DAC
		private void method_4(object sender, EventArgs e)
		{
			checked
			{
				if (this.vmethod_0().SelectedIndex != -1)
				{
					Side[] sides = Client.GetClientScenario().GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						if (Operators.ConditionalCompareObjectEqual(side.GetSideName(), this.vmethod_0().SelectedItem, false))
						{
							this.side_0 = side;
							this.vmethod_4().Enabled = (this.vmethod_0().Items.Count > 0);
							this.vmethod_6().Enabled = (this.vmethod_0().Items.Count > 0);
							this.vmethod_10().Enabled = (this.vmethod_0().Items.Count > 0);
							this.GetCB_CollectiveResponse().Enabled = (this.vmethod_0().Items.Count > 0);
							this.vmethod_10().Checked = this.side_0.IsAIOnly();
							this.GetCB_CollectiveResponse().Checked = this.side_0.CollectiveResponsibility;
							this.GetCB_AutoTrackCivilians().Checked = this.side_0.CATC;
							switch (this.side_0.GetAwarenessLevel())
							{
							case Side.AwarenessLevel.Blind:
								this.GetCB_Awareness().SelectedIndex = 0;
								break;
							case Side.AwarenessLevel.Normal:
								this.GetCB_Awareness().SelectedIndex = 1;
								break;
							case Side.AwarenessLevel.AutoSideID:
								this.GetCB_Awareness().SelectedIndex = 2;
								break;
							case Side.AwarenessLevel.AutoSideAndUnitID:
								this.GetCB_Awareness().SelectedIndex = 3;
								break;
							case Side.AwarenessLevel.Omniscient:
								this.GetCB_Awareness().SelectedIndex = 4;
								break;
							}
							this.GetLabel_Proficiency().Visible = true;
							this.GetTrackBar_Proficiency().Visible = true;
							this.GetLabel_Proficiency().Text = "训练水平: " + Misc.GetProficiencyLevelString(this.side_0.GetProficiencyLevel());
							this.GetTrackBar_Proficiency().Value = (int)this.side_0.GetProficiencyLevel();
							return;
						}
					}
					this.vmethod_4().Enabled = (this.vmethod_0().Items.Count > 0);
					this.vmethod_6().Enabled = (this.vmethod_0().Items.Count > 0);
					this.vmethod_10().Enabled = (this.vmethod_0().Items.Count > 0);
					this.GetCB_CollectiveResponse().Enabled = (this.vmethod_0().Items.Count > 0);
					this.vmethod_10().Checked = this.side_0.IsAIOnly();
					this.GetCB_CollectiveResponse().Checked = this.side_0.CollectiveResponsibility;
					this.GetCB_AutoTrackCivilians().Checked = this.side_0.CATC;
					switch (this.side_0.GetAwarenessLevel())
					{
					case Side.AwarenessLevel.Blind:
						this.GetCB_Awareness().SelectedIndex = 0;
						break;
					case Side.AwarenessLevel.Normal:
						this.GetCB_Awareness().SelectedIndex = 1;
						break;
					case Side.AwarenessLevel.AutoSideID:
						this.GetCB_Awareness().SelectedIndex = 2;
						break;
					case Side.AwarenessLevel.AutoSideAndUnitID:
						this.GetCB_Awareness().SelectedIndex = 3;
						break;
					case Side.AwarenessLevel.Omniscient:
						this.GetCB_Awareness().SelectedIndex = 4;
						break;
					}
					this.GetLabel_Proficiency().Visible = true;
					this.GetTrackBar_Proficiency().Visible = true;
					this.GetLabel_Proficiency().Text = "训练水平: " + Misc.GetProficiencyLevelString(this.side_0.GetProficiencyLevel());
					this.GetTrackBar_Proficiency().Value = (int)this.side_0.GetProficiencyLevel();
				}
			}
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x00204F0C File Offset: 0x0020310C
		private void method_5(object sender, EventArgs e)
		{
			checked
			{
				if (Interaction.MsgBox("Are you sure? All units, missions and any other object of that side will be deleted!", MsgBoxStyle.OkCancel, "Remove Side: " + this.side_0.GetSideName()) == MsgBoxResult.Ok)
				{
					Collection<ActiveUnit> collection = new Collection<ActiveUnit>();
					ActiveUnit[] activeUnitArray = this.side_0.ActiveUnitArray;
					for (int i = 0; i < activeUnitArray.Length; i++)
					{
						ActiveUnit item = activeUnitArray[i];
						collection.Add(item);
					}
					foreach (ActiveUnit current in collection)
					{
						Scenario clientScenario = Client.GetClientScenario();
						GameGeneral.RemoveUnit(ref clientScenario, current.GetGuid());
					}
					Client.GetClientScenario().RemoveSide(this.side_0);
					CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
					Client.b_Completed = true;
					this.method_2();
				}
			}
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x00025696 File Offset: 0x00023896
		private void method_6(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetPostures().side_0 = this.side_0;
			CommandFactory.GetCommandMain().GetPostures().Show();
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x000256BC File Offset: 0x000238BC
		private void method_7(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				this.side_0.SetIsAIOnly(this.vmethod_10().Checked);
			}
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x00204FF0 File Offset: 0x002031F0
		private void method_8(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				new RenameSide
				{
					side_0 = this.side_0
				}.Show();
			}
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x00205024 File Offset: 0x00203224
		private void method_9(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				new DoctrineForm
				{
					subject = this.side_0
				}.Show();
			}
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x00205058 File Offset: 0x00203258
		private void CB_Awareness_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				switch (this.GetCB_Awareness().SelectedIndex)
				{
				case 0:
					this.side_0.SetAwarenessLevel(Side.AwarenessLevel.Blind);
					break;
				case 1:
					this.side_0.SetAwarenessLevel(Side.AwarenessLevel.Normal);
					break;
				case 2:
					this.side_0.SetAwarenessLevel(Side.AwarenessLevel.AutoSideID);
					break;
				case 3:
					this.side_0.SetAwarenessLevel(Side.AwarenessLevel.AutoSideAndUnitID);
					break;
				case 4:
					this.side_0.SetAwarenessLevel(Side.AwarenessLevel.Omniscient);
					break;
				}
			}
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x000256E1 File Offset: 0x000238E1
		private void method_11(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				this.side_0.CollectiveResponsibility = this.GetCB_CollectiveResponse().Checked;
			}
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x002050E0 File Offset: 0x002032E0
		private void method_12(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				this.side_0.SetProficiencyLevel((GlobalVariables.ProficiencyLevel)this.GetTrackBar_Proficiency().Value);
				this.GetLabel_Proficiency().Text = "训练水平: " + Misc.GetProficiencyLevelString(this.side_0.GetProficiencyLevel());
			}
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x00205138 File Offset: 0x00203338
		private void Sides_KeyDown(object sender, KeyEventArgs e)
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
						this.GetCB_CollectiveResponse().Select();
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

		// Token: 0x0600501A RID: 20506 RVA: 0x00025706 File Offset: 0x00023906
		private void CB_Awareness_Enter(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x0002570F File Offset: 0x0002390F
		private void CB_Awareness_Leave(object sender, EventArgs e)
		{
			this.bool_0 = false;
			this.GetCB_CollectiveResponse().Select();
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x00025723 File Offset: 0x00023923
		private void method_15(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.side_0))
			{
				this.side_0.CATC = this.GetCB_AutoTrackCivilians().Checked;
			}
		}

		// Token: 0x040025B5 RID: 9653
		public static Func<Side, string> SideFunc0 = (Side side_0) => side_0.GetSideName();

		// Token: 0x040025B7 RID: 9655
		[CompilerGenerated]
		private ListBox listBox_0;

		// Token: 0x040025B8 RID: 9656
		[CompilerGenerated]
		private Button button_0;

		// Token: 0x040025B9 RID: 9657
		[CompilerGenerated]
		private Button button_1;

		// Token: 0x040025BA RID: 9658
		[CompilerGenerated]
		private Button button_2;

		// Token: 0x040025BB RID: 9659
		[CompilerGenerated]
		private ImageList imageList_0;

		// Token: 0x040025BC RID: 9660
		[CompilerGenerated]
		private CheckBox checkBox_0;

		// Token: 0x040025BD RID: 9661
		[CompilerGenerated]
		private Button button_3;

		// Token: 0x040025BE RID: 9662
		[CompilerGenerated]
		private Button button_4;

		// Token: 0x040025BF RID: 9663
		[CompilerGenerated]
		private StatusStrip statusStrip_0;

		// Token: 0x040025C0 RID: 9664
		[CompilerGenerated]
		private ToolStripStatusLabel toolStripStatusLabel_0;

		// Token: 0x040025C1 RID: 9665
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x040025C2 RID: 9666
		[CompilerGenerated]
		private ComboBox CB_Awareness;

		// Token: 0x040025C3 RID: 9667
		[CompilerGenerated]
		private CheckBox checkBox_1;

		// Token: 0x040025C4 RID: 9668
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x040025C5 RID: 9669
		[CompilerGenerated]
		private TrackBar trackBar_0;

		// Token: 0x040025C6 RID: 9670
		[CompilerGenerated]
		private CheckBox checkBox_2;

		// Token: 0x040025C7 RID: 9671
		private Side side_0;

		// Token: 0x040025C8 RID: 9672
		private bool bool_0;
	}
}

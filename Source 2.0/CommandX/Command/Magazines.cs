using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AdvancedDataGridView;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns29;
using ns3;
using ns32;
using ns33;

namespace Command
{
	// 弹药库窗体
	[DesignerGenerated]
	public sealed partial class Magazines : CommandForm
	{
		// 构造函数
		public Magazines()
		{
			base.Load += new EventHandler(this.Magazines_Load);
			base.KeyDown += new KeyEventHandler(this.Magazines_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.Magazines_FormClosing);
			base.FormClosed += new FormClosedEventHandler(this.Magazines_FormClosed);
			this.class2472_0 = new Class2472();
			this.InitializeComponent();
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x00232DB8 File Offset: 0x00230FB8
		[CompilerGenerated]
		internal  TreeGridView vmethod_0()
		{
			return this.treeGridView_0;
		}

		// Token: 0x06005487 RID: 21639 RVA: 0x00232DD0 File Offset: 0x00230FD0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TreeGridView treeGridView_1)
		{
			DataGridViewCellMouseEventHandler value = new DataGridViewCellMouseEventHandler(this.method_6);
			TreeGridView treeGridView = this.treeGridView_0;
			if (treeGridView != null)
			{
				treeGridView.CellMouseClick -= value;
			}
			this.treeGridView_0 = treeGridView_1;
			treeGridView = this.treeGridView_0;
			if (treeGridView != null)
			{
				treeGridView.CellMouseClick += value;
			}
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x00232E1C File Offset: 0x0023101C
		[CompilerGenerated]
		internal  ToolStrip vmethod_2()
		{
			return this.toolStrip_0;
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x00026EE4 File Offset: 0x000250E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x00232E34 File Offset: 0x00231034
		[CompilerGenerated]
		internal  ToolStripButton vmethod_4()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x0600548B RID: 21643 RVA: 0x00232E4C File Offset: 0x0023104C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(ToolStripButton toolStripButton_4)
		{
			EventHandler value = new EventHandler(this.method_8);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_4;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x00232E98 File Offset: 0x00231098
		[CompilerGenerated]
		internal  ToolStripLabel vmethod_6()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x00026EED File Offset: 0x000250ED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(ToolStripLabel toolStripLabel_2)
		{
			this.toolStripLabel_0 = toolStripLabel_2;
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x00232EB0 File Offset: 0x002310B0
		[CompilerGenerated]
		internal  ToolStripTextBox vmethod_8()
		{
			return this.toolStripTextBox_0;
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x00232EC8 File Offset: 0x002310C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripTextBox toolStripTextBox_1)
		{
			EventHandler value = new EventHandler(this.method_9);
			EventHandler value2 = new EventHandler(this.method_13);
			EventHandler value3 = new EventHandler(this.method_14);
			ToolStripTextBox toolStripTextBox = this.toolStripTextBox_0;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.TextChanged -= value;
				toolStripTextBox.Enter -= value2;
				toolStripTextBox.Leave -= value3;
			}
			this.toolStripTextBox_0 = toolStripTextBox_1;
			toolStripTextBox = this.toolStripTextBox_0;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.TextChanged += value;
				toolStripTextBox.Enter += value2;
				toolStripTextBox.Leave += value3;
			}
		}

		// Token: 0x06005490 RID: 21648 RVA: 0x00232F48 File Offset: 0x00231148
		[CompilerGenerated]
		internal  ToolStripLabel vmethod_10()
		{
			return this.toolStripLabel_1;
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x00026EF6 File Offset: 0x000250F6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(ToolStripLabel toolStripLabel_2)
		{
			this.toolStripLabel_1 = toolStripLabel_2;
		}

		// Token: 0x06005492 RID: 21650 RVA: 0x00232F60 File Offset: 0x00231160
		[CompilerGenerated]
		internal  ToolStripComboBox vmethod_12()
		{
			return this.toolStripComboBox_0;
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x00026EFF File Offset: 0x000250FF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ToolStripComboBox toolStripComboBox_1)
		{
			this.toolStripComboBox_0 = toolStripComboBox_1;
		}

		// Token: 0x06005494 RID: 21652 RVA: 0x00232F78 File Offset: 0x00231178
		[CompilerGenerated]
		internal  ToolStripButton vmethod_14()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x06005495 RID: 21653 RVA: 0x00232F90 File Offset: 0x00231190
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ToolStripButton toolStripButton_4)
		{
			EventHandler value = new EventHandler(this.method_7);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_4;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x00232FDC File Offset: 0x002311DC
		[CompilerGenerated]
		internal  Timer vmethod_16()
		{
			return this.timer_0;
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x00232FF4 File Offset: 0x002311F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(Timer timer_1)
		{
			EventHandler value = new EventHandler(this.method_11);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.timer_0 = timer_1;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x00233040 File Offset: 0x00231240
		[CompilerGenerated]
		internal  ToolStripButton vmethod_18()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x00233058 File Offset: 0x00231258
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(ToolStripButton toolStripButton_4)
		{
			EventHandler value = new EventHandler(this.method_15);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_4;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x002330A4 File Offset: 0x002312A4
		[CompilerGenerated]
		internal  ToolStripButton vmethod_20()
		{
			return this.toolStripButton_3;
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x002330BC File Offset: 0x002312BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(ToolStripButton toolStripButton_4)
		{
			EventHandler value = new EventHandler(this.method_16);
			ToolStripButton toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_3 = toolStripButton_4;
			toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x00233108 File Offset: 0x00231308
		[CompilerGenerated]
		internal  TreeGridViewTextBoxColumn vmethod_22()
		{
			return this.class2383_0;
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x00026F08 File Offset: 0x00025108
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(TreeGridViewTextBoxColumn class2383_2)
		{
			this.class2383_0 = class2383_2;
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x00233120 File Offset: 0x00231320
		[CompilerGenerated]
		internal  TreeGridViewTextBoxColumn vmethod_24()
		{
			return this.class2383_1;
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x00026F11 File Offset: 0x00025111
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(TreeGridViewTextBoxColumn class2383_2)
		{
			this.class2383_1 = class2383_2;
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x00233138 File Offset: 0x00231338
		[CompilerGenerated]
		internal  ComboBox vmethod_26()
		{
			return this.comboBox_0;
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x00233150 File Offset: 0x00231350
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.method_10);
			ComboBox comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted -= value;
			}
			this.comboBox_0 = comboBox_1;
			comboBox = this.comboBox_0;
			if (comboBox != null)
			{
				comboBox.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x060054A2 RID: 21666 RVA: 0x0023319C File Offset: 0x0023139C
		private void Magazines_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.vmethod_2().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.method_3();
			this.Text = "弹药库状态 - " + this.activeUnit_0.Name;
			if (this.vmethod_0().Nodes.Count > 0)
			{
				this.magazine_0 = (Magazine)this.vmethod_0().Nodes[0].Tag;
				this.vmethod_14().Enabled = true;
				this.vmethod_4().Enabled = true;
			}
			else
			{
				this.vmethod_14().Enabled = false;
				this.vmethod_4().Enabled = false;
			}
			this.vmethod_27(this.vmethod_12().ComboBox);
			this.vmethod_16().Start();
			PlatformComponent.smethod_0(new PlatformComponent.Delegate21(this.method_2));
			WeaponRec.smethod_0(new WeaponRec.Delegate24(this.method_1));
			this.vmethod_18().Visible = !this.activeUnit_0.IsGroup;
		}

		// Token: 0x060054A3 RID: 21667 RVA: 0x002332BC File Offset: 0x002314BC
		private void method_1(WeaponRec weaponRec_1)
		{
			Mount[] mounts = this.activeUnit_0.m_Mounts;
			checked
			{
				for (int i = 0; i < mounts.Length; i++)
				{
					Mount mount = mounts[i];
					if (mount.GetMagazineForMount().GetWeaponRecCollection().Contains(weaponRec_1) | mount.GetWeaponRecCollection().Contains(weaponRec_1))
					{
						this.method_12();
						return;
					}
				}
				Magazine[] magazines = this.activeUnit_0.GetMagazines();
				for (int j = 0; j < magazines.Length; j++)
				{
					if (magazines[j].GetWeaponRecCollection().Contains(weaponRec_1))
					{
						this.method_12();
						break;
					}
				}
			}
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x00233350 File Offset: 0x00231550
		private void method_2(PlatformComponent platformComponent_0)
		{
			if (!Information.IsNothing(platformComponent_0.GetParentPlatform()))
			{
				bool flag = false;
				if (platformComponent_0.IsMagazine())
				{
					if (platformComponent_0.GetParentPlatform() == this.activeUnit_0)
					{
						flag = true;
					}
					if (platformComponent_0.GetParentPlatform().IsActiveUnit() && platformComponent_0.GetParentPlatform().HasParentGroup() && platformComponent_0.GetParentPlatform().GetParentGroup(false).HasFixedFacility() && platformComponent_0.GetParentPlatform().GetParentGroup(false) == this.activeUnit_0)
					{
						flag = true;
					}
				}
				if (flag)
				{
					this.method_12();
				}
			}
		}

		// Token: 0x060054A5 RID: 21669 RVA: 0x002333E4 File Offset: 0x002315E4
		private void method_3()
		{
			this.vmethod_0().Nodes.Clear();
			Mount[] mounts = this.activeUnit_0.m_Mounts;
			checked
			{
				for (int i = 0; i < mounts.Length; i++)
				{
					Mount mount = mounts[i];
					if (mount.GetMagazineForMount().GetWeaponRecCollection().Count > 0)
					{
						PlatformComponent._ComponentStatus componentStatus = mount.GetMagazineForMount().GetComponentStatus();
						string text = "";
						if (componentStatus == PlatformComponent._ComponentStatus.Operational)
						{
							text = "正常工作";
						}
						if (componentStatus == PlatformComponent._ComponentStatus.Damaged)
						{
							text = "受到毁伤";
						}
						if (componentStatus == PlatformComponent._ComponentStatus.Destroyed)
						{
							text = "已被摧毁";
						}
						TreeGridViewRow treeGridViewRow = this.vmethod_0().Nodes.method_1(new object[]
						{
							Misc.smethod_11(mount.GetMagazineForMount().Name),
							text
						});
						treeGridViewRow.DefaultCellStyle.BackColor = base.GetComponentColor(mount);
						treeGridViewRow.Tag = mount.GetMagazineForMount();
						treeGridViewRow.vmethod_4();
						List<WeaponRec> list = mount.GetMagazineForMount().GetWeaponRecCollection().OrderBy(Magazines.WeaponRecFunc0, new Class265<string[]>(true)).ToList<WeaponRec>();
						foreach (WeaponRec current in list)
						{
							TreeGridViewRow treeGridViewRow2 = treeGridViewRow.Nodes.method_0(string.Concat(new string[]
							{
								Conversions.ToString(current.GetCurrentLoad()),
								"/",
								Conversions.ToString(current.MaxLoad),
								" ",
								Misc.smethod_11(Strings.Trim(current.GetWeapon(Client.GetClientScenario()).Name))
							}));
							treeGridViewRow2.Tag = current;
							treeGridViewRow2.DefaultCellStyle.BackColor = base.GetComponentColor(mount);
						}
					}
				}
				Magazine[] magazines = this.activeUnit_0.GetMagazines();
				for (int j = 0; j < magazines.Length; j++)
				{
					Magazine magazine_ = magazines[j];
					this.method_4(magazine_);
				}
			}
		}

		// Token: 0x060054A6 RID: 21670 RVA: 0x00233604 File Offset: 0x00231804
		private void method_4(Magazine magazine_1)
		{
			string text;
			if (this.activeUnit_0.IsGroup && ((Group)this.activeUnit_0).HasFixedFacility())
			{
				text = Misc.smethod_11(magazine_1.Name) + " [" + magazine_1.GetParentPlatform().Name + "]";
			}
			else
			{
				text = Misc.smethod_11(magazine_1.Name);
			}
			Color componentColor = base.GetComponentColor(magazine_1);
			string text2 = magazine_1.GetComponentStatus().ToString();
			if (magazine_1.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
			{
				text2 = "正常工作";
			}
			if (magazine_1.GetComponentStatus() == PlatformComponent._ComponentStatus.Damaged)
			{
				text2 = "受到毁伤";
			}
			if (magazine_1.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
			{
				text2 = "已被摧毁";
			}
			TreeGridViewRow treeGridViewRow = this.vmethod_0().Nodes.method_1(new object[]
			{
				text,
				text2
			});
			treeGridViewRow.DefaultCellStyle.BackColor = componentColor;
			treeGridViewRow.Tag = magazine_1;
			treeGridViewRow.vmethod_4();
			List<WeaponRec> list = magazine_1.GetWeaponRecCollection().Where(Magazines.WeaponRecFunc1).OrderBy(Magazines.WeaponRecFunc2, new Class265<string[]>(true)).ToList<WeaponRec>();
			List<WeaponRec> list2 = magazine_1.GetWeaponRecCollection().Where(Magazines.WeaponRecFunc3).OrderBy(Magazines.WeaponRecFunc4, new Class265<string[]>(true)).ToList<WeaponRec>();
			foreach (WeaponRec current in list)
			{
				TreeGridViewRow treeGridViewRow2 = treeGridViewRow.Nodes.method_0(string.Concat(new string[]
				{
					Conversions.ToString(current.GetCurrentLoad()),
					"/",
					Conversions.ToString(current.MaxLoad),
					" ",
					Misc.smethod_11(Strings.Trim(current.GetWeapon(this.activeUnit_0.m_Scenario).Name))
				}));
				treeGridViewRow2.Tag = current;
				treeGridViewRow2.DefaultCellStyle.BackColor = componentColor;
			}
			foreach (WeaponRec current2 in list2)
			{
				TreeGridViewRow treeGridViewRow3 = treeGridViewRow.Nodes.method_0(string.Concat(new string[]
				{
					Conversions.ToString(current2.GetCurrentLoad()),
					"/",
					Conversions.ToString(current2.MaxLoad),
					" ",
					Misc.smethod_11(Strings.Trim(current2.GetWeapon(this.activeUnit_0.m_Scenario).Name))
				}));
				treeGridViewRow3.Tag = current2;
				treeGridViewRow3.DefaultCellStyle.BackColor = componentColor;
			}
		}

		// Token: 0x060054A7 RID: 21671 RVA: 0x002338E8 File Offset: 0x00231AE8
		private void method_5()
		{
			Collection<TreeGridViewRow> collection = new Collection<TreeGridViewRow>();
			foreach (TreeGridViewRow current in this.vmethod_0().Nodes)
			{
				if (!Client.GetClientScenario().GetActiveUnits().ContainsKey(((PlatformComponent)current.Tag).GetParentPlatform().GetGuid()))
				{
					collection.Add(current);
				}
				if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(current.Tag)) && current.Tag.GetType() == typeof(Magazine))
				{
					Magazine magazine = (Magazine)current.Tag;
					if (!this.activeUnit_0.GetMagazinesForAllMounts().Contains(magazine))
					{
						collection.Add(current);
					}
				}
			}
			foreach (TreeGridViewRow current2 in collection)
			{
				current2.method_7().Nodes.Remove(current2);
			}
			Magazine[] magazines = this.activeUnit_0.GetMagazines();
			checked
			{
				for (int i = 0; i < magazines.Length; i++)
				{
					Magazine magazine = magazines[i];
					bool flag = false;
					using (IEnumerator<TreeGridViewRow> enumerator3 = this.vmethod_0().Nodes.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							if (enumerator3.Current.Tag == magazine)
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						this.method_4(magazine);
					}
				}
				foreach (TreeGridViewRow current3 in this.vmethod_0().Nodes)
				{
					if (current3.Tag.GetType() == typeof(Magazine))
					{
						Magazine magazine = (Magazine)current3.Tag;
						Color componentColor = base.GetComponentColor(magazine);
						string text = magazine.GetComponentStatus().ToString();
						if (magazine.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							text = "正常工作";
						}
						if (magazine.GetComponentStatus() == PlatformComponent._ComponentStatus.Damaged)
						{
							text = "受到毁伤";
						}
						if (magazine.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
						{
							text = "已被摧毁";
						}
						current3.SetValues(new object[]
						{
							Misc.smethod_11(magazine.Name),
							text
						});
						current3.DefaultCellStyle.BackColor = componentColor;
						current3.Nodes.Clear();
						List<WeaponRec> list = magazine.GetWeaponRecCollection().Where(Magazines.WeaponRecFunc5).OrderBy(Magazines.WeaponRecFunc6, new Class265<string[]>(true)).ToList<WeaponRec>();
						List<WeaponRec> list2 = magazine.GetWeaponRecCollection().Where(Magazines.WeaponRecFunc7).OrderBy(Magazines.WeaponRecFunc8, new Class265<string[]>(true)).ToList<WeaponRec>();
						foreach (WeaponRec current4 in list)
						{
							TreeGridViewRow treeGridViewRow = current3.Nodes.method_0(string.Concat(new string[]
							{
								Conversions.ToString(current4.GetCurrentLoad()),
								"/",
								Conversions.ToString(current4.MaxLoad),
								" ",
								Misc.smethod_11(Strings.Trim(current4.GetWeapon(this.activeUnit_0.m_Scenario).Name))
							}));
							treeGridViewRow.Tag = current4;
							treeGridViewRow.DefaultCellStyle.BackColor = componentColor;
						}
						foreach (WeaponRec current5 in list2)
						{
							TreeGridViewRow treeGridViewRow2 = current3.Nodes.method_0(string.Concat(new string[]
							{
								Conversions.ToString(current5.GetCurrentLoad()),
								"/",
								Conversions.ToString(current5.MaxLoad),
								" ",
								Misc.smethod_11(Strings.Trim(current5.GetWeapon(this.activeUnit_0.m_Scenario).Name))
							}));
							treeGridViewRow2.Tag = current5;
							treeGridViewRow2.DefaultCellStyle.BackColor = componentColor;
						}
					}
					current3.vmethod_4();
				}
				if (this.vmethod_0().Nodes.Count > 0)
				{
					this.vmethod_14().Enabled = true;
					this.vmethod_4().Enabled = true;
				}
				else
				{
					this.vmethod_14().Enabled = false;
					this.vmethod_4().Enabled = false;
				}
			}
		}

		// Token: 0x060054A8 RID: 21672 RVA: 0x00233E34 File Offset: 0x00232034
		private void method_6(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex != -1 && !Information.IsNothing(this.vmethod_0().method_4()))
			{
				if (this.vmethod_0().method_4().Tag.GetType() == typeof(Magazine))
				{
					this.magazine_0 = (Magazine)this.vmethod_0().method_4().Tag;
					this.vmethod_4().Enabled = false;
					this.vmethod_8().Enabled = false;
					this.vmethod_12().Enabled = true;
				}
				if (this.vmethod_0().method_4().Tag.GetType() == typeof(WeaponRec))
				{
					this.magazine_0 = (Magazine)this.vmethod_0().method_4().method_7().Tag;
					this.weaponRec_0 = (WeaponRec)this.vmethod_0().method_4().Tag;
					this.vmethod_4().Enabled = true;
					this.vmethod_8().Enabled = true;
					this.vmethod_12().Enabled = false;
				}
				switch (this.magazine_0.GetComponentStatus())
				{
				case PlatformComponent._ComponentStatus.Operational:
					this.vmethod_12().SelectedIndex = 0;
					break;
				case PlatformComponent._ComponentStatus.Damaged:
					this.vmethod_12().SelectedIndex = 1;
					break;
				case PlatformComponent._ComponentStatus.Destroyed:
					this.vmethod_12().SelectedIndex = 2;
					break;
				}
			}
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x00026F1A File Offset: 0x0002511A
		private void method_7(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetAddWeaponRecord().form_0 = this;
			CommandFactory.GetCommandMain().GetAddWeaponRecord().Show();
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x00233F9C File Offset: 0x0023219C
		private void method_8(object sender, EventArgs e)
		{
			int count = this.vmethod_0().SelectedRows.Count;
			if (count != 0)
			{
				if (count == 1)
				{
					this.magazine_0.GetWeaponRecCollection().Remove(this.weaponRec_0);
				}
				else
				{
					IEnumerable<DataGridViewRow> enumerable = this.vmethod_0().SelectedRows.Cast<object>().Select(Magazines.objectFunc9).Where(Magazines.DataGridViewRowFunc10);
					if (Interaction.MsgBox("Are you sure?", MsgBoxStyle.OkCancel, "Remove " + Conversions.ToString(enumerable.Count<DataGridViewRow>()) + " weapon records") == MsgBoxResult.Ok)
					{
						foreach (DataGridViewRow current in enumerable)
						{
							this.magazine_0.GetWeaponRecCollection().Remove((WeaponRec)current.Tag);
						}
					}
				}
			}
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x00234090 File Offset: 0x00232290
		private void method_9(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.weaponRec_0) && (Operators.CompareString(this.vmethod_8().Text, "", false) != 0 & Versioned.IsNumeric(this.vmethod_8().Text)))
			{
				int num = Conversions.ToInteger(this.vmethod_8().Text);
				if (num < 0)
				{
					num = 0;
				}
				if (num > this.weaponRec_0.MaxLoad)
				{
					num = this.weaponRec_0.MaxLoad;
				}
				if ((double)num / (double)this.weaponRec_0.Multiple > (double)this.weaponRec_0.MaxLoad)
				{
					num = this.weaponRec_0.MaxLoad;
				}
				this.weaponRec_0.SetCurrentLoad(0);
				Magazine magazine = this.magazine_0;
				int num2 = 0;
				int num3 = 0;
				int num4 = magazine.method_29(ref num2, ref num3);
				if ((double)num / (double)this.weaponRec_0.Multiple > (double)(this.magazine_0.MagazineCapacity - num4))
				{
					num = this.magazine_0.MagazineCapacity - num4 * this.weaponRec_0.Multiple;
				}
				if (num < 0)
				{
					num = 0;
				}
				this.weaponRec_0.SetCurrentLoad(num);
				foreach (TreeGridViewRow current in this.vmethod_0().Nodes)
				{
					foreach (TreeGridViewRow current2 in current.Nodes)
					{
						if (current2.Tag == this.weaponRec_0)
						{
							current2.SetValues(new object[]
							{
								string.Concat(new string[]
								{
									Conversions.ToString(this.weaponRec_0.GetCurrentLoad()),
									"/",
									Conversions.ToString(this.weaponRec_0.MaxLoad),
									" ",
									Misc.smethod_11(Strings.Trim(this.weaponRec_0.GetWeapon(Client.GetClientScenario()).Name))
								})
							});
							return;
						}
					}
				}
			}
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x002342F0 File Offset: 0x002324F0
		private void method_10(object sender, EventArgs e)
		{
			switch (this.vmethod_26().SelectedIndex)
			{
			case 0:
				this.magazine_0.method_25(true);
				break;
			case 1:
				this.magazine_0.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Light);
				break;
			case 2:
				this.magazine_0.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Medium);
				break;
			case 3:
				this.magazine_0.StopIlluminateAndTurnOff(PlatformComponent._DamageSeverityFactor.Heavy);
				break;
			case 4:
				this.magazine_0.BeDestroyed(this.activeUnit_0.GetSide(false), true, this.magazine_0.GetParentPlatform().MountsAreAimpoints());
				break;
			}
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x00026F3B File Offset: 0x0002513B
		private void method_11(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.method_5();
				this.bool_0 = false;
			}
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x00026F55 File Offset: 0x00025155
		public void method_12()
		{
			this.bool_0 = true;
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x00234388 File Offset: 0x00232588
		private void Magazines_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F5 && base.Visible)
			{
				base.Close();
			}
			else
			{
				if (this.bool_1 && (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12))
				{
					CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
				if (!this.bool_1 && (e.KeyValue != 32 || !base.Visible))
				{
					CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x00004D83 File Offset: 0x00002F83
		private void Magazines_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x060054B1 RID: 21681 RVA: 0x00026F5E File Offset: 0x0002515E
		private void method_13(object sender, EventArgs e)
		{
			this.bool_1 = true;
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x00026F67 File Offset: 0x00025167
		private void method_14(object sender, EventArgs e)
		{
			this.bool_1 = false;
			this.vmethod_10().Select();
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x00026F7B File Offset: 0x0002517B
		private void Magazines_FormClosed(object sender, FormClosedEventArgs e)
		{
			PlatformComponent.smethod_1(new PlatformComponent.Delegate21(this.method_2));
			WeaponRec.smethod_1(new WeaponRec.Delegate24(this.method_1));
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x00026F9F File Offset: 0x0002519F
		private void method_15(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) && !this.activeUnit_0.IsGroup)
			{
				CommandFactory.GetCommandMain().GetAddMagazine().form_0 = this;
				CommandFactory.GetCommandMain().GetAddMagazine().Show();
			}
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x002344B8 File Offset: 0x002326B8
		private void method_16(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.activeUnit_0) & !Information.IsNothing(this.magazine_0))
			{
				if (this.activeUnit_0.IsPlatform())
				{
					ScenarioArrayUtil.RemoveMagazine(ref ((Platform)this.activeUnit_0).m_Magazines, this.magazine_0);
					this.method_12();
				}
				else if (this.activeUnit_0.IsGroup)
				{
					foreach (ActiveUnit current in ((Group)this.activeUnit_0).GetUnitsInGroup().Values)
					{
						if (current.IsPlatform() && ((Platform)current).m_Magazines.Contains(this.magazine_0))
						{
							ScenarioArrayUtil.RemoveMagazine(ref ((Platform)current).m_Magazines, this.magazine_0);
							this.method_12();
							break;
						}
					}
				}
			}
		}

		// Token: 0x040028D4 RID: 10452
		public static Func<WeaponRec, string> WeaponRecFunc0 = (WeaponRec weaponRec_0) => weaponRec_0.GetWeapon(Client.GetClientScenario()).Name;

		// Token: 0x040028D5 RID: 10453
		public static Func<WeaponRec, bool> WeaponRecFunc1 = (WeaponRec weaponRec_0) => weaponRec_0.GetCurrentLoad() > 0;

		// Token: 0x040028D6 RID: 10454
		public static Func<WeaponRec, string> WeaponRecFunc2 = (WeaponRec weaponRec_0) => weaponRec_0.GetWeapon(Client.GetClientScenario()).Name;

		// Token: 0x040028D7 RID: 10455
		public static Func<WeaponRec, bool> WeaponRecFunc3 = (WeaponRec weaponRec_0) => weaponRec_0.GetCurrentLoad() == 0;

		// Token: 0x040028D8 RID: 10456
		public static Func<WeaponRec, string> WeaponRecFunc4 = (WeaponRec weaponRec_0) => weaponRec_0.GetWeapon(Client.GetClientScenario()).Name;

		// Token: 0x040028D9 RID: 10457
		public static Func<WeaponRec, bool> WeaponRecFunc5 = (WeaponRec weaponRec_0) => weaponRec_0.GetCurrentLoad() > 0;

		// Token: 0x040028DA RID: 10458
		public static Func<WeaponRec, string> WeaponRecFunc6 = (WeaponRec weaponRec_0) => weaponRec_0.GetWeapon(Client.GetClientScenario()).Name;

		// Token: 0x040028DB RID: 10459
		public static Func<WeaponRec, bool> WeaponRecFunc7 = (WeaponRec weaponRec_0) => weaponRec_0.GetCurrentLoad() == 0;

		// Token: 0x040028DC RID: 10460
		public static Func<WeaponRec, string> WeaponRecFunc8 = (WeaponRec weaponRec_0) => weaponRec_0.GetWeapon(Client.GetClientScenario()).Name;

		// Token: 0x040028DD RID: 10461
		public static Func<object, DataGridViewRow> objectFunc9 = (object object_0) => (DataGridViewRow)object_0;

		// Token: 0x040028DE RID: 10462
		public static Func<DataGridViewRow, bool> DataGridViewRowFunc10 = (DataGridViewRow dataGridViewRow_0) => dataGridViewRow_0.Tag.GetType() == typeof(WeaponRec);

		// Token: 0x040028E0 RID: 10464
		[CompilerGenerated]
		private TreeGridView treeGridView_0;

		// Token: 0x040028E1 RID: 10465
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x040028E2 RID: 10466
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x040028E3 RID: 10467
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x040028E4 RID: 10468
		[CompilerGenerated]
		private ToolStripTextBox toolStripTextBox_0;

		// Token: 0x040028E5 RID: 10469
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_1;

		// Token: 0x040028E6 RID: 10470
		[CompilerGenerated]
		private ToolStripComboBox toolStripComboBox_0;

		// Token: 0x040028E7 RID: 10471
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x040028E8 RID: 10472
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x040028E9 RID: 10473
		[CompilerGenerated]
		private ToolStripButton toolStripButton_2;

		// Token: 0x040028EA RID: 10474
		[CompilerGenerated]
		private ToolStripButton toolStripButton_3;

		// Token: 0x040028EB RID: 10475
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn class2383_0;

		// Token: 0x040028EC RID: 10476
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn class2383_1;

		// Token: 0x040028ED RID: 10477
		public ActiveUnit activeUnit_0;

		// Token: 0x040028EE RID: 10478
		public Magazine magazine_0;

		// Token: 0x040028EF RID: 10479
		private WeaponRec weaponRec_0;

		// Token: 0x040028F0 RID: 10480
		private Class2472 class2472_0;

		// Token: 0x040028F1 RID: 10481
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x040028F2 RID: 10482
		private bool bool_0;

		// Token: 0x040028F3 RID: 10483
		private bool bool_1;
	}
}

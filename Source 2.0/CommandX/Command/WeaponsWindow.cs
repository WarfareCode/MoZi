using System;
using System.Collections.Generic;
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
using ns35;

namespace Command
{
	// 武器窗口
	[DesignerGenerated]
	public sealed partial class WeaponsWindow : CommandForm
	{
		// Token: 0x060058BC RID: 22716 RVA: 0x0026F5EC File Offset: 0x0026D7EC
		public WeaponsWindow()
		{
			base.FormClosing += new FormClosingEventHandler(this.WeaponsWindow_FormClosing);
			base.VisibleChanged += new EventHandler(this.WeaponsWindow_VisibleChanged);
			base.Load += new EventHandler(this.WeaponsWindow_Load);
			base.KeyDown += new KeyEventHandler(this.WeaponsWindow_KeyDown);
			base.FormClosed += new FormClosedEventHandler(this.WeaponsWindow_FormClosed);
			this.string_0 = "";
			this.bool_2 = false;
			this.InitializeComponent();
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x002702B0 File Offset: 0x0026E4B0
		[CompilerGenerated]
		internal  TreeGridViewTextBoxColumn vmethod_0()
		{
			return this.class2383_0;
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x0002821A File Offset: 0x0002641A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TreeGridViewTextBoxColumn class2383_2)
		{
			this.class2383_0 = class2383_2;
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x002702C8 File Offset: 0x0026E4C8
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_2()
		{
			return this.dataGridViewTextBoxColumn_0;
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x00028223 File Offset: 0x00026423
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5)
		{
			this.dataGridViewTextBoxColumn_0 = dataGridViewTextBoxColumn_5;
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x002702E0 File Offset: 0x0026E4E0
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_4()
		{
			return this.dataGridViewTextBoxColumn_1;
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x0002822C File Offset: 0x0002642C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5)
		{
			this.dataGridViewTextBoxColumn_1 = dataGridViewTextBoxColumn_5;
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x002702F8 File Offset: 0x0026E4F8
		[CompilerGenerated]
		internal  TreeGridView vmethod_6()
		{
			return this.treeGridView_0;
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x00270310 File Offset: 0x0026E510
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(TreeGridView treeGridView_1)
		{
			DataGridViewCellEventHandler value = new DataGridViewCellEventHandler(this.method_14);
			Delegate41 delegate41_ = new Delegate41(this.method_15);
			DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_17);
			EventHandler value3 = new EventHandler(this.method_20);
			TreeGridView treeGridView = this.treeGridView_0;
			if (treeGridView != null)
			{
				treeGridView.CellClick -= value;
				treeGridView.method_11(delegate41_);
				treeGridView.CellContentClick -= value2;
				treeGridView.SelectionChanged -= value3;
			}
			this.treeGridView_0 = treeGridView_1;
			treeGridView = this.treeGridView_0;
			if (treeGridView != null)
			{
				treeGridView.CellClick += value;
				treeGridView.method_10(delegate41_);
				treeGridView.CellContentClick += value2;
				treeGridView.SelectionChanged += value3;
			}
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x002703B8 File Offset: 0x0026E5B8
		[CompilerGenerated]
		internal  ImageList vmethod_8()
		{
			return this.imageList_0;
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x00028235 File Offset: 0x00026435
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ImageList imageList_1)
		{
			this.imageList_0 = imageList_1;
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x002703D0 File Offset: 0x0026E5D0
		[CompilerGenerated]
		internal  Timer vmethod_10()
		{
			return this.timer_0;
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x002703E8 File Offset: 0x0026E5E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Timer timer_1)
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

		// Token: 0x060058CB RID: 22731 RVA: 0x00270434 File Offset: 0x0026E634
		[CompilerGenerated]
		internal  ToolStrip vmethod_12()
		{
			return this.toolStrip_0;
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x0002823E File Offset: 0x0002643E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(ToolStrip toolStrip_1)
		{
			this.toolStrip_0 = toolStrip_1;
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x0027044C File Offset: 0x0026E64C
		[CompilerGenerated]
		internal  ToolStripButton vmethod_14()
		{
			return this.toolStripButton_0;
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x00270464 File Offset: 0x0026E664
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_12);
			ToolStripButton toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_0 = toolStripButton_5;
			toolStripButton = this.toolStripButton_0;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x002704B0 File Offset: 0x0026E6B0
		[CompilerGenerated]
		internal  ToolStripButton vmethod_16()
		{
			return this.toolStripButton_1;
		}

		// Token: 0x060058D0 RID: 22736 RVA: 0x002704C8 File Offset: 0x0026E6C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_17(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_13);
			ToolStripButton toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_1 = toolStripButton_5;
			toolStripButton = this.toolStripButton_1;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x00270514 File Offset: 0x0026E714
		[CompilerGenerated]
		internal  ToolStripLabel vmethod_18()
		{
			return this.toolStripLabel_0;
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x00028247 File Offset: 0x00026447
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(ToolStripLabel toolStripLabel_2)
		{
			this.toolStripLabel_0 = toolStripLabel_2;
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x0027052C File Offset: 0x0026E72C
		[CompilerGenerated]
		internal  ToolStripTextBox vmethod_20()
		{
			return this.toolStripTextBox_0;
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x00270544 File Offset: 0x0026E744
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_21(ToolStripTextBox toolStripTextBox_1)
		{
			EventHandler value = new EventHandler(this.method_21);
			EventHandler value2 = new EventHandler(this.method_22);
			ToolStripTextBox toolStripTextBox = this.toolStripTextBox_0;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.Enter -= value;
				toolStripTextBox.Leave -= value2;
			}
			this.toolStripTextBox_0 = toolStripTextBox_1;
			toolStripTextBox = this.toolStripTextBox_0;
			if (toolStripTextBox != null)
			{
				toolStripTextBox.Enter += value;
				toolStripTextBox.Leave += value2;
			}
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x002705A8 File Offset: 0x0026E7A8
		[CompilerGenerated]
		internal  ToolStripButton vmethod_22()
		{
			return this.toolStripButton_2;
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x002705C0 File Offset: 0x0026E7C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_23(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_16);
			ToolStripButton toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_2 = toolStripButton_5;
			toolStripButton = this.toolStripButton_2;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x0027060C File Offset: 0x0026E80C
		[CompilerGenerated]
		internal  ToolStripButton vmethod_24()
		{
			return this.toolStripButton_3;
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x00270624 File Offset: 0x0026E824
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_25(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_18);
			ToolStripButton toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_3 = toolStripButton_5;
			toolStripButton = this.toolStripButton_3;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x00270670 File Offset: 0x0026E870
		[CompilerGenerated]
		internal  ToolStripLabel vmethod_26()
		{
			return this.toolStripLabel_1;
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x00028250 File Offset: 0x00026450
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_27(ToolStripLabel toolStripLabel_2)
		{
			this.toolStripLabel_1 = toolStripLabel_2;
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x00270688 File Offset: 0x0026E888
		[CompilerGenerated]
		internal  ToolStripButton vmethod_28()
		{
			return this.toolStripButton_4;
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x002706A0 File Offset: 0x0026E8A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_29(ToolStripButton toolStripButton_5)
		{
			EventHandler value = new EventHandler(this.method_19);
			ToolStripButton toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value;
			}
			this.toolStripButton_4 = toolStripButton_5;
			toolStripButton = this.toolStripButton_4;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value;
			}
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x002706EC File Offset: 0x0026E8EC
		[CompilerGenerated]
		internal  ToolStripSeparator vmethod_30()
		{
			return this.toolStripSeparator_0;
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x00028259 File Offset: 0x00026459
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_31(ToolStripSeparator toolStripSeparator_2)
		{
			this.toolStripSeparator_0 = toolStripSeparator_2;
		}

		// Token: 0x060058DF RID: 22751 RVA: 0x00270704 File Offset: 0x0026E904
		[CompilerGenerated]
		internal  ToolStripSeparator vmethod_32()
		{
			return this.toolStripSeparator_1;
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x00028262 File Offset: 0x00026462
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_33(ToolStripSeparator toolStripSeparator_2)
		{
			this.toolStripSeparator_1 = toolStripSeparator_2;
		}

		// Token: 0x060058E1 RID: 22753 RVA: 0x0027071C File Offset: 0x0026E91C
		[CompilerGenerated]
		internal  TreeGridViewTextBoxColumn vmethod_34()
		{
			return this.class2383_1;
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x0002826B File Offset: 0x0002646B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_35(TreeGridViewTextBoxColumn class2383_2)
		{
			this.class2383_1 = class2383_2;
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x00270734 File Offset: 0x0026E934
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_36()
		{
			return this.dataGridViewTextBoxColumn_2;
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x00028274 File Offset: 0x00026474
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_37(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5)
		{
			this.dataGridViewTextBoxColumn_2 = dataGridViewTextBoxColumn_5;
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x0027074C File Offset: 0x0026E94C
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_38()
		{
			return this.dataGridViewTextBoxColumn_3;
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x0002827D File Offset: 0x0002647D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_39(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5)
		{
			this.dataGridViewTextBoxColumn_3 = dataGridViewTextBoxColumn_5;
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x00270764 File Offset: 0x0026E964
		[CompilerGenerated]
		internal  DataGridViewTextBoxColumn vmethod_40()
		{
			return this.dataGridViewTextBoxColumn_4;
		}

		// Token: 0x060058E8 RID: 22760 RVA: 0x00028286 File Offset: 0x00026486
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_41(DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5)
		{
			this.dataGridViewTextBoxColumn_4 = dataGridViewTextBoxColumn_5;
		}

		// Token: 0x060058E9 RID: 22761 RVA: 0x0027077C File Offset: 0x0026E97C
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn vmethod_42()
		{
			return this.dataGridViewCheckBoxColumn_0;
		}

		// Token: 0x060058EA RID: 22762 RVA: 0x0002828F File Offset: 0x0002648F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_43(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_0 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x00270794 File Offset: 0x0026E994
		[CompilerGenerated]
		internal  DataGridViewCheckBoxColumn vmethod_44()
		{
			return this.dataGridViewCheckBoxColumn_1;
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x00028298 File Offset: 0x00026498
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_45(DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2)
		{
			this.dataGridViewCheckBoxColumn_1 = dataGridViewCheckBoxColumn_2;
		}

		// Token: 0x060058ED RID: 22765 RVA: 0x000282A1 File Offset: 0x000264A1
		public void method_1(WeaponRec weaponRec)
		{
			if (!Information.IsNothing(this.mount_0))
			{
				this.mount_0.GetWeaponRecCollection().Add(weaponRec);
			}
			else if (!Information.IsNothing(this.loadout_0))
			{
				this.loadout_0.AddWeaponRec(weaponRec);
			}
		}

		// Token: 0x060058EE RID: 22766 RVA: 0x002707AC File Offset: 0x0026E9AC
		public void method_10()
		{
			Func<Mount, string> keySelector = (Mount argument0) => argument0.Name;
			if (Information.IsNothing(this.activeUnit_0))
			{
				if (!Client.GetHookedUnit().IsActiveUnit())
				{
					return;
				}
				this.activeUnit_0 = (ActiveUnit)Client.GetHookedUnit();
			}
			this.vmethod_6().SuspendLayout();
			this.vmethod_6().Nodes.Clear();
			this.vmethod_12().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.Text = "武器—" + this.activeUnit_0.Name;
			string text = "";
			this.vmethod_6().GetRows().Clear();
			IEnumerable<Mount> enumerable = this.activeUnit_0.m_Mounts.OrderBy(keySelector);
			foreach (Mount current in enumerable)
			{
				this.class2384_0 = null;
				int num = 0;
				foreach (WeaponRec current2 in current.GetWeaponRecCollection())
				{
					num += current2.MaxLoad;
				}
				if (current.ReloadStatus == Mount._ReloadStatus.const_0)
				{
					text = Misc.GetTimeString((long)Math.Round((double)current.GetTimeToFire()), Aircraft_AirOps._Maintenance.const_0, false, false);
				}
				else
				{
					float num2 = 0f;
					if (current.GetTimeToFire() > 0f)
					{
						num2 = current.GetTimeToFire();
					}
					if (current.GetMagazineForMount().GetTimeToFire() > 0f && current.GetMagazineForMount().GetTimeToFire() > num2)
					{
						num2 = current.GetMagazineForMount().GetTimeToFire();
					}
					foreach (WeaponRec current3 in current.GetWeaponRecCollection())
					{
						if (current3.TimeToFire > num2)
						{
							num2 = current3.TimeToFire;
						}
					}
					foreach (WeaponRec current4 in current.GetMagazineForMount().GetWeaponRecCollection())
					{
						if (current4.TimeToFire > num2)
						{
							num2 = current4.TimeToFire;
						}
					}
					if (num2 == 0f)
					{
						text = Misc.GetTimeString((long)Math.Round((double)current.GetTimeToFire()), Aircraft_AirOps._Maintenance.const_0, false, false);
					}
					else if (current.ReloadStatus == Mount._ReloadStatus.Reloading)
					{
						text = "重装载: " + Misc.GetTimeString((long)Math.Round((double)num2), Aircraft_AirOps._Maintenance.const_0, false, false);
					}
					else if (current.ReloadStatus == Mount._ReloadStatus.Unloading)
					{
						text = "卸载: " + Misc.GetTimeString((long)Math.Round((double)num2), Aircraft_AirOps._Maintenance.const_0, false, false);
					}
				}
				TreeGridViewRowNodes nodes = this.vmethod_6().Nodes;
				object[] array = new object[4];
				array[0] = Misc.smethod_11(current.Name);
				string[] array2 = new string[5];
				array2[0] = "(";
				Mount mount = current;
				int i = 0;
				int j = 0;
				array2[1] = Conversions.ToString(mount.method_35(ref i, ref j));
				array2[2] = "/";
				array2[3] = Conversions.ToString(current.Capacity);
				array2[4] = ")";
				array[1] = string.Concat(array2);
				array[2] = text;
				array[3] = current.GetComponentStatus().ToString();
				if (current.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
				{
					array[3] = "正常工作";
				}
				if (current.GetComponentStatus() == PlatformComponent._ComponentStatus.Damaged)
				{
					array[3] = "受到毁伤";
				}
				if (current.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
				{
					array[3] = "已被摧毁";
				}
				this.class2384_0 = nodes.method_1(array);
				this.class2384_0.Tag = current;
				this.class2384_0.DefaultCellStyle.ForeColor = Color.Black;
				this.class2384_0.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Regular);
				this.class2384_0.DefaultCellStyle.BackColor = base.GetComponentColor(current);
				foreach (WeaponRec current5 in current.GetWeaponRecCollection())
				{
					int num3 = this.activeUnit_0.GetWeaponry().method_34(current, current5.WeapID);
					string text2 = "";
					if (num3 > 0)
					{
						text2 = " (" + Conversions.ToString(num3) + " on mount mag)";
					}
					if (this.bool_1)
					{
						text = " (开火时间:" + Misc.GetTimeString((long)Math.Round((double)current5.TimeToFire), Aircraft_AirOps._Maintenance.const_0, false, false) + ") ";
					}
					else
					{
						text = "";
					}
					this.class2384_1 = null;
					this.class2384_1 = this.class2384_0.Nodes.method_1(new object[]
					{
						string.Concat(new string[]
						{
							Conversions.ToString(current5.GetCurrentLoad()),
							"/",
							Conversions.ToString(current5.MaxLoad),
							text,
							"  ",
							Misc.smethod_11(Strings.Trim(current5.GetWeapon(Client.GetClientScenario()).Name)),
							text2
						}),
						Misc.GetWeaponTypeString(current5.GetWeapon(Client.GetClientScenario()).GetWeaponType()),
						null,
						null,
						current.RPrioritySet.Contains(current5.WeapID)
					});
					this.class2384_1.Tag = current5;
					if (current5.GetCurrentLoad() == 0)
					{
						this.class2384_1.DefaultCellStyle.ForeColor = Color.DarkGray;
					}
					else
					{
						this.class2384_1.DefaultCellStyle.ForeColor = Color.Blue;
					}
				}
				this.class2384_0.vmethod_4();
			}
			checked
			{
				if (this.activeUnit_0.IsAircraft && !Information.IsNothing(((Aircraft)this.activeUnit_0).GetLoadout()))
				{
					Loadout loadout = ((Aircraft)this.activeUnit_0).GetLoadout();
					int num4 = 0;
					WeaponRec[] weaponRecArray = loadout.WeaponRecArray;
					for (int j = 0; j < weaponRecArray.Length; j++)
					{
						WeaponRec weaponRec = weaponRecArray[j];
						unchecked
						{
							num4 += weaponRec.MaxLoad;
						}
					}
					this.class2384_0 = this.vmethod_6().Nodes.method_1(new object[]
					{
						"挂载: " + Misc.smethod_11(loadout.Name),
						string.Concat(new string[]
						{
							"(",
							Conversions.ToString(loadout.method_16()),
							"/",
							Conversions.ToString(num4),
							")"
						})
					});
					this.class2384_0.Tag = loadout;
					this.class2384_0.DefaultCellStyle.ForeColor = Color.Black;
					this.class2384_0.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Regular);
					WeaponRec[] weaponRecArray2 = loadout.WeaponRecArray;
					for (int i = 0; i < weaponRecArray2.Length; i++)
					{
						WeaponRec weaponRec2 = weaponRecArray2[i];
						if (this.bool_1)
						{
							text = " (开火时间:" + Misc.GetTimeString(unchecked((long)Math.Round((double)weaponRec2.TimeToFire)), Aircraft_AirOps._Maintenance.const_0, false, false) + ") ";
						}
						else
						{
							text = "";
						}
						this.class2384_1 = this.class2384_0.Nodes.method_1(new object[]
						{
							string.Concat(new string[]
							{
								Conversions.ToString(weaponRec2.GetCurrentLoad()),
								"/",
								Conversions.ToString(weaponRec2.MaxLoad),
								text,
								"  ",
								Misc.smethod_11(Strings.Trim(weaponRec2.GetWeapon(Client.GetClientScenario()).Name))
							}),
							Misc.GetWeaponTypeString(weaponRec2.GetWeapon(Client.GetClientScenario()).GetWeaponType())
						});
						this.class2384_1.Tag = weaponRec2;
						if (weaponRec2.GetCurrentLoad() == 0)
						{
							this.class2384_1.DefaultCellStyle.ForeColor = Color.DarkGray;
						}
						else
						{
							this.class2384_1.DefaultCellStyle.ForeColor = Color.Blue;
						}
					}
					this.class2384_0.vmethod_4();
				}
				this.vmethod_6().ResumeLayout();
				this.vmethod_14().Visible = (this.vmethod_6().Nodes.Count > 0);
				this.vmethod_16().Visible = this.vmethod_14().Visible;
			}
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x000282DC File Offset: 0x000264DC
		private void method_11(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.method_9();
			}
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x00026F1A File Offset: 0x0002511A
		private void method_12(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetAddWeaponRecord().form_0 = this;
			CommandFactory.GetCommandMain().GetAddWeaponRecord().Show();
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x00271100 File Offset: 0x0026F300
		private void method_13(object sender, EventArgs e)
		{
			IEnumerator<DataGridViewRow> enumerator = null;
			int count = this.vmethod_6().SelectedRows.Count;
			if (count != 0)
			{
				if (count != 1)
				{
					IEnumerable<object> source = this.vmethod_6().SelectedRows.Cast<object>();
					IEnumerable<DataGridViewRow> source2 = source.Select(WeaponsWindow.func);
					IEnumerable<DataGridViewRow> enumerable = source2.Where(WeaponsWindow.type);
					if (Interaction.MsgBox("您确定吗?", MsgBoxStyle.OkCancel, "Remove " + Conversions.ToString(enumerable.Count<DataGridViewRow>()) + " weapon records") != MsgBoxResult.Ok)
					{
						goto IL_C1;
					}
					try
					{
						enumerator = enumerable.GetEnumerator();
						while (enumerator.MoveNext())
						{
							this.method_2((WeaponRec)enumerator.Current.Tag);
						}
						goto IL_C1;
					}
					finally
					{
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				this.method_2(this.weaponRec_0);
			}
			IL_C1:
			this.method_6();
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x002711E4 File Offset: 0x0026F3E4
		private void method_14(object sender, DataGridViewCellEventArgs e)
		{
			Mount mount = null;
			WeaponRec weaponRec = null;
			WeaponRec weaponRec2 = null;
			IEnumerator<TreeGridViewRow> enumerator = null;
			if (e.RowIndex != -1 && e.ColumnIndex != -1)
			{
				DataGridViewColumn dataGridViewColumn = this.vmethod_6().Columns[e.ColumnIndex];
				if (!Information.IsNothing(this.vmethod_6().method_4()))
				{
					if (this.vmethod_6().method_4().Tag.GetType() == typeof(WeaponRec) && Operators.CompareString(dataGridViewColumn.Name, "ReloadPriority", false) == 0 && !Information.IsNothing(this.mount_0))
					{
						DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)this.vmethod_6()[e.ColumnIndex, e.RowIndex];
						WeaponRec weaponRec3 = (WeaponRec)this.vmethod_6().method_4().Tag;
						Mount mount2 = (Mount)this.vmethod_6().method_4().method_7().Tag;
						if (!mount2.RPrioritySet.Contains(weaponRec3.WeapID))
						{
							mount2.RPrioritySet.Add(weaponRec3.WeapID);
							dataGridViewCheckBoxCell.Value = true;
						}
						else
						{
							mount2.RPrioritySet.Remove(weaponRec3.WeapID);
							dataGridViewCheckBoxCell.Value = false;
						}
					}
					if (Operators.CompareString(dataGridViewColumn.Name, "ShowArcs", false) == 0 && !Information.IsNothing(this.mount_0))
					{
						using (enumerator)
						{
							enumerator = Class2529.smethod_10(this.vmethod_6()).GetEnumerator();
							while (enumerator.MoveNext())
							{
								TreeGridViewRow current = enumerator.Current;
								DataGridViewCheckBoxCell dataGridViewCheckBoxCell2 = (DataGridViewCheckBoxCell)current.Cells[e.ColumnIndex];
								if (Operators.ConditionalCompareObjectEqual(dataGridViewCheckBoxCell2.Value, true, false))
								{
									if (current.Tag.GetType() == typeof(Mount))
									{
										mount = (Mount)current.Tag;
									}
									else if (current.Tag.GetType() == typeof(WeaponRec))
									{
										weaponRec = (WeaponRec)current.Tag;
									}
								}
								dataGridViewCheckBoxCell2.Value = false;
							}
						}
						Mount mount3;
						if (this.vmethod_6().method_4().Tag.GetType() == typeof(Mount))
						{
							mount3 = (Mount)this.vmethod_6().method_4().Tag;
						}
						else if (this.vmethod_6().method_4().Tag.GetType() != typeof(WeaponRec))
						{
							mount3 = null;
						}
						else
						{
							mount3 = (Mount)this.vmethod_6().method_4().method_7().Tag;
							weaponRec2 = (WeaponRec)this.vmethod_6().method_4().Tag;
						}
						if (!Information.IsNothing(mount3))
						{
							DataGridViewCheckBoxCell dataGridViewCheckBoxCell2 = (DataGridViewCheckBoxCell)this.vmethod_6()[e.ColumnIndex, e.RowIndex];
							if (!Information.IsNothing(mount3) && !Information.IsNothing(mount) && mount == mount3)
							{
								Client.m_Mount = null;
							}
							else if (Information.IsNothing(weaponRec2) || Information.IsNothing(weaponRec) || weaponRec != weaponRec2)
							{
								dataGridViewCheckBoxCell2.Value = true;
								Client.m_Mount = mount3;
							}
							else
							{
								Client.m_Mount = null;
							}
							Client.b_Completed = true;
						}
					}
				}
			}
		}

		// Token: 0x060058F3 RID: 22771 RVA: 0x0027155C File Offset: 0x0026F75C
		private void method_15(object sender, EventArgs6 e)
		{
			if (e.method_0().Tag.GetType() == typeof(Mount))
			{
				this.mount_0 = (Mount)e.method_0().Tag;
				this.vmethod_16().Visible = false;
			}
			if (e.method_0().Tag.GetType() == typeof(Loadout))
			{
				this.vmethod_14().Visible = false;
				this.vmethod_16().Visible = false;
			}
		}

		// Token: 0x060058F4 RID: 22772 RVA: 0x000282EF File Offset: 0x000264EF
		private void method_16(object sender, EventArgs e)
		{
			CommandFactory.GetCommandMain().GetAddMount().form_0 = this;
			CommandFactory.GetCommandMain().GetAddMount().Show();
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x002715E8 File Offset: 0x0026F7E8
		private void method_17(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{
				try
				{
					TreeGridViewRow treeGridViewRow = null;
					foreach (TreeGridViewRow current in Class2529.smethod_10(this.vmethod_6()))
					{
						if (current.Selected)
						{
							treeGridViewRow = current;
							break;
						}
					}
					if (!Information.IsNothing(treeGridViewRow) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(treeGridViewRow.Tag)) && treeGridViewRow.Tag.GetType() == typeof(WeaponRec))
					{
						int weapID = ((WeaponRec)treeGridViewRow.Tag).WeapID;
						Client.ShowDBInfo("武器", weapID);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200104", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x00271704 File Offset: 0x0026F904
		private void method_18(object sender, EventArgs e)
		{
			this.mount_0 = null;
			if (!Information.IsNothing(this.vmethod_6().method_4()))
			{
				if (this.vmethod_6().method_4().Tag.GetType() == typeof(Mount))
				{
					this.mount_0 = (Mount)this.vmethod_6().method_4().Tag;
				}
				else if (this.vmethod_6().method_4().method_7().Tag.GetType() == typeof(Mount))
				{
					this.mount_0 = (Mount)this.vmethod_6().method_4().method_7().Tag;
				}
			}
			if (Information.IsNothing(this.mount_0))
			{
				Interaction.MsgBox("没有选择挂架!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				this.vmethod_6().method_4().method_7().Nodes.Remove(this.vmethod_6().method_4());
				if (!Information.IsNothing(this.activeUnit_0))
				{
					ScenarioArrayUtil.RemoveMount(ref this.activeUnit_0.m_Mounts, this.mount_0);
				}
				this.method_6();
			}
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x0027182C File Offset: 0x0026FA2C
		private void method_19(object sender, EventArgs e)
		{
			bool flag;
			if (!(flag = this.bool_2))
			{
				this.bool_2 = true;
				this.vmethod_28().Text = "设置";
				this.vmethod_20().Visible = true;
				this.vmethod_26().Visible = false;
			}
			else if (flag)
			{
				this.bool_2 = false;
				this.vmethod_28().Text = "改变";
				this.vmethod_20().Visible = false;
				this.vmethod_26().Visible = true;
				if (!Information.IsNothing(this.weaponRec_0))
				{
					if (Operators.CompareString(this.vmethod_20().Text, "", false) != 0 & Versioned.IsNumeric(this.vmethod_20().Text))
					{
						int num = Conversions.ToInteger(this.vmethod_20().Text);
						if (num < 0)
						{
							num = 0;
						}
						if ((double)num / (double)this.weaponRec_0.Multiple > (double)this.weaponRec_0.MaxLoad)
						{
							num = this.weaponRec_0.MaxLoad;
						}
						if (!Information.IsNothing(this.mount_0))
						{
							this.weaponRec_0.SetCurrentLoad(0);
							Mount mount = this.mount_0;
							int num2 = 0;
							int num3 = 0;
							int num4 = mount.method_35(ref num2, ref num3);
							if ((double)num / (double)this.weaponRec_0.Multiple > (double)(this.mount_0.Capacity - num4))
							{
								num = this.mount_0.Capacity - num4 * this.weaponRec_0.Multiple;
							}
						}
						if (num < 0)
						{
							num = 0;
						}
						this.weaponRec_0.SetCurrentLoad(num);
						this.vmethod_26().Text = Conversions.ToString(num);
						foreach (TreeGridViewRow current in this.vmethod_6().Nodes)
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
											"  ",
											Misc.smethod_11(Strings.Trim(this.weaponRec_0.GetWeapon(Client.GetClientScenario()).Name))
										})
									});
								}
							}
						}
						if (!Information.IsNothing(this.activeUnit_0) && this.activeUnit_0.IsAircraft)
						{
							Aircraft aircraft = (Aircraft)this.activeUnit_0;
							if (!Information.IsNothing(aircraft.GetLoadout()))
							{
								aircraft.GetAircraftWeaponry().method_43();
							}
						}
					}
					this.activeUnit_0.GetWeaponry().method_4();
					Client.b_Completed = true;
					CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
				}
			}
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x00028310 File Offset: 0x00026510
		public void method_2(WeaponRec weaponRec)
		{
			if (!Information.IsNothing(this.mount_0))
			{
				this.mount_0.GetWeaponRecCollection().Remove(weaponRec);
			}
			else if (!Information.IsNothing(this.loadout_0))
			{
				this.loadout_0.RemoveWeaponRec(weaponRec);
			}
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x00271B70 File Offset: 0x0026FD70
		private void method_20(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.vmethod_6().method_4()))
			{
				this.vmethod_22().Visible = true;
				this.vmethod_18().Visible = false;
				this.bool_2 = false;
				this.vmethod_18().Visible = true;
				this.vmethod_26().Visible = true;
				this.vmethod_20().Visible = false;
				this.vmethod_28().Text = "变更";
				if (this.vmethod_6().method_4().Tag.GetType() == typeof(WeaponRec))
				{
					this.weaponRec_0 = (WeaponRec)this.vmethod_6().method_4().Tag;
					if (this.vmethod_6().method_4().method_7().Tag.GetType() == typeof(Mount))
					{
						this.mount_0 = (Mount)this.vmethod_6().method_4().method_7().Tag;
						this.loadout_0 = null;
					}
					else if (this.vmethod_6().method_4().method_7().Tag.GetType() == typeof(Loadout))
					{
						this.mount_0 = null;
						this.loadout_0 = (Loadout)this.vmethod_6().method_4().method_7().Tag;
					}
					this.vmethod_14().Visible = true;
					this.vmethod_16().Visible = true;
					this.vmethod_20().Text = Conversions.ToString(this.weaponRec_0.GetCurrentLoad());
					this.vmethod_26().Text = Conversions.ToString(this.weaponRec_0.GetCurrentLoad());
					this.vmethod_24().Visible = true;
					this.vmethod_18().Visible = true;
					this.vmethod_26().Visible = true;
					this.vmethod_28().Visible = true;
				}
				if (this.vmethod_6().method_4().Tag.GetType() == typeof(Mount))
				{
					this.mount_0 = (Mount)this.vmethod_6().method_4().Tag;
					this.loadout_0 = null;
					this.vmethod_14().Visible = true;
					this.vmethod_16().Visible = false;
					this.vmethod_24().Visible = true;
					this.vmethod_26().Visible = false;
					this.vmethod_18().Visible = false;
					this.vmethod_28().Visible = false;
				}
				if (this.vmethod_6().method_4().Tag.GetType() == typeof(Loadout))
				{
					this.loadout_0 = (Loadout)this.vmethod_6().method_4().Tag;
					this.vmethod_14().Visible = false;
					this.vmethod_16().Visible = false;
					this.vmethod_24().Visible = false;
					this.vmethod_26().Visible = false;
					this.vmethod_18().Visible = false;
					this.vmethod_28().Visible = false;
				}
			}
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x0002834C File Offset: 0x0002654C
		private void method_21(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x00028355 File Offset: 0x00026555
		private void method_22(object sender, EventArgs e)
		{
			this.bool_3 = false;
			this.vmethod_28().Select();
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x00028369 File Offset: 0x00026569
		private void method_3(Mount mount)
		{
			if (mount.GetParentPlatform() == this.activeUnit_0)
			{
				this.method_6();
			}
		}

		// Token: 0x060058FD RID: 22781 RVA: 0x00028384 File Offset: 0x00026584
		private void method_4(PlatformComponent platformComponent)
		{
			if (platformComponent.IsMount() && platformComponent.GetParentPlatform() == this.activeUnit_0)
			{
				this.method_6();
			}
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x00271E68 File Offset: 0x00270068
		private void method_5(WeaponRec weaponRec)
		{
			if (!Information.IsNothing(this.activeUnit_0))
			{
				Mount[] mounts = this.activeUnit_0.m_Mounts;
				for (int i = 0; i < mounts.Length; i++)
				{
					if (mounts[i].GetWeaponRecCollection().Contains(weaponRec))
					{
						this.method_6();
						break;
					}
				}
			}
		}

		// Token: 0x060058FF RID: 22783 RVA: 0x000283AA File Offset: 0x000265AA
		public void method_6()
		{
			this.bool_0 = true;
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x00271EBC File Offset: 0x002700BC
		public void method_7(TreeGridViewRow TreeGridViewRow_, IEnumerable<WeaponRec> ienumerable_)
		{
			List<TreeGridViewRow> list = new List<TreeGridViewRow>();
			foreach (TreeGridViewRow current in TreeGridViewRow_.Nodes)
			{
				if (!ienumerable_.Contains((WeaponRec)current.Tag))
				{
					list.Add(current);
				}
			}
			foreach (TreeGridViewRow current2 in list)
			{
				TreeGridViewRow_.Nodes.Remove(current2);
			}
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x00271F6C File Offset: 0x0027016C
		public void method_8(TreeGridViewRow class2384_2, IEnumerable<WeaponRec> ienumerable_0)
		{
			if (!Information.IsNothing(this.activeUnit_0))
			{
				foreach (WeaponRec current in ienumerable_0)
				{
					bool flag = false;
					foreach (TreeGridViewRow current2 in class2384_2.Nodes)
					{
						if ((WeaponRec)current2.Tag == current)
						{
							flag = true;
							this.class2384_1 = current2;
						}
					}
					if (!flag)
					{
						if (class2384_2.Tag.GetType() == typeof(Mount))
						{
							Mount mount = (Mount)class2384_2.Tag;
							int num = this.activeUnit_0.GetWeaponry().method_34(mount, current.WeapID);
							string text = "";
							if (num > 0)
							{
								text = " (" + Conversions.ToString(num) + " on mount mag)";
							}
							if (this.bool_1)
							{
								this.string_0 = " (开火时间:" + Misc.GetTimeString((long)Math.Round((double)current.TimeToFire), Aircraft_AirOps._Maintenance.const_0, false, false) + ") ";
							}
							else
							{
								this.string_0 = "";
							}
							this.class2384_1 = null;
							this.class2384_1 = this.class2384_0.Nodes.method_1(new object[]
							{
								string.Concat(new string[]
								{
									Conversions.ToString(current.GetCurrentLoad()),
									"/",
									Conversions.ToString(current.MaxLoad),
									this.string_0,
									"  ",
									Misc.smethod_11(Strings.Trim(current.GetWeapon(Client.GetClientScenario()).Name)),
									text
								}),
								Misc.GetWeaponTypeString(current.GetWeapon(Client.GetClientScenario()).GetWeaponType()),
								null,
								null,
								mount.RPrioritySet.Contains(current.WeapID)
							});
							this.class2384_1.Tag = current;
							if (current.GetCurrentLoad() == 0)
							{
								this.class2384_1.DefaultCellStyle.ForeColor = Color.DarkGray;
							}
							else
							{
								this.class2384_1.DefaultCellStyle.ForeColor = Color.Blue;
							}
						}
						if (class2384_2.Tag.GetType() == typeof(Loadout))
						{
							if (this.bool_1)
							{
								this.string_0 = " (开火时间:" + Misc.GetTimeString((long)Math.Round((double)current.TimeToFire), Aircraft_AirOps._Maintenance.const_0, false, false) + ") ";
							}
							else
							{
								this.string_0 = "";
							}
							this.class2384_1 = this.class2384_0.Nodes.method_1(new object[]
							{
								string.Concat(new string[]
								{
									Conversions.ToString(current.GetCurrentLoad()),
									"/",
									Conversions.ToString(current.MaxLoad),
									this.string_0,
									"  ",
									Misc.smethod_11(Strings.Trim(current.GetWeapon(Client.GetClientScenario()).Name))
								}),
								Misc.GetWeaponTypeString(current.GetWeapon(Client.GetClientScenario()).GetWeaponType())
							});
							this.class2384_1.Tag = current;
							if (current.GetCurrentLoad() == 0)
							{
								this.class2384_1.DefaultCellStyle.ForeColor = Color.DarkGray;
							}
							else
							{
								this.class2384_1.DefaultCellStyle.ForeColor = Color.Blue;
							}
						}
					}
					if (flag)
					{
						if (class2384_2.Tag.GetType() == typeof(Mount))
						{
							Mount mount2 = (Mount)class2384_2.Tag;
							int num2 = this.activeUnit_0.GetWeaponry().method_34(mount2, current.WeapID);
							string text2 = "";
							if (num2 > 0)
							{
								text2 = " (" + Conversions.ToString(num2) + " on mount mag)";
							}
							if (this.bool_1)
							{
								this.string_0 = " (开火时间:" + Misc.GetTimeString((long)Math.Round((double)current.TimeToFire), Aircraft_AirOps._Maintenance.const_0, false, false) + ") ";
							}
							else
							{
								this.string_0 = "";
							}
							this.class2384_1.SetValues(new object[]
							{
								string.Concat(new string[]
								{
									Conversions.ToString(current.GetCurrentLoad()),
									"/",
									Conversions.ToString(current.MaxLoad),
									this.string_0,
									"  ",
									Misc.smethod_11(Strings.Trim(current.GetWeapon(Client.GetClientScenario()).Name)),
									text2
								}),
								Misc.GetWeaponTypeString(current.GetWeapon(Client.GetClientScenario()).GetWeaponType()),
								null,
								null,
								mount2.RPrioritySet.Contains(current.WeapID)
							});
							this.class2384_1.Tag = current;
							if (current.GetCurrentLoad() == 0)
							{
								this.class2384_1.DefaultCellStyle.ForeColor = Color.DarkGray;
							}
							else
							{
								this.class2384_1.DefaultCellStyle.ForeColor = Color.Blue;
							}
						}
						if (class2384_2.Tag.GetType() == typeof(Loadout))
						{
							if (this.bool_1)
							{
								this.string_0 = " (开火时间:" + Misc.GetTimeString((long)Math.Round((double)current.TimeToFire), Aircraft_AirOps._Maintenance.const_0, false, false) + ") ";
							}
							else
							{
								this.string_0 = "";
							}
							this.class2384_1.SetValues(new object[]
							{
								string.Concat(new string[]
								{
									Conversions.ToString(current.GetCurrentLoad()),
									"/",
									Conversions.ToString(current.MaxLoad),
									this.string_0,
									"  ",
									Misc.smethod_11(Strings.Trim(current.GetWeapon(Client.GetClientScenario()).Name))
								}),
								Misc.GetWeaponTypeString(current.GetWeapon(Client.GetClientScenario()).GetWeaponType())
							});
							this.class2384_1.Tag = current;
							if (current.GetCurrentLoad() == 0)
							{
								this.class2384_1.DefaultCellStyle.ForeColor = Color.DarkGray;
							}
							else
							{
								this.class2384_1.DefaultCellStyle.ForeColor = Color.Blue;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x00272658 File Offset: 0x00270858
		public void method_9()
		{
			IEnumerator<WeaponRec> enumerator = null;
			IEnumerator<WeaponRec> enumerator2 = null;
			if (Information.IsNothing(this.activeUnit_0))
			{
				if (!Client.GetHookedUnit().IsActiveUnit())
				{
					base.Close();
					return;
				}
				this.activeUnit_0 = (ActiveUnit)Client.GetHookedUnit();
			}
			this.vmethod_6().SuspendLayout();
			this.vmethod_12().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.bool_0 = false;
			Mount[] mounts = this.activeUnit_0.m_Mounts;
			IEnumerable<Mount> source = ((IEnumerable<Mount>)mounts).OrderBy(WeaponsWindow.stringFunc);
			try
			{
				int num = source.Count<Mount>() - 1;
				for (int i = 0; i <= num; i++)
				{
					this.class2384_0 = this.vmethod_6().Nodes[i];
					Mount mount = source.ElementAtOrDefault(i);
					if (mount.ReloadStatus != Mount._ReloadStatus.const_0)
					{
						float num2 = 0f;
						if (mount.GetTimeToFire() > 0f)
						{
							num2 = mount.GetTimeToFire();
						}
						if (mount.GetMagazineForMount().GetTimeToFire() > 0f && mount.GetMagazineForMount().GetTimeToFire() > num2)
						{
							num2 = mount.GetMagazineForMount().GetTimeToFire();
						}
						using (enumerator)
						{
							enumerator = mount.GetWeaponRecCollection().GetEnumerator();
							while (enumerator.MoveNext())
							{
								WeaponRec current = enumerator.Current;
								if (current.TimeToFire > num2)
								{
									num2 = current.TimeToFire;
								}
							}
						}
						using (enumerator2)
						{
							enumerator2 = mount.GetMagazineForMount().GetWeaponRecCollection().GetEnumerator();
							while (enumerator2.MoveNext())
							{
								WeaponRec current2 = enumerator2.Current;
								if (current2.TimeToFire > num2)
								{
									num2 = current2.TimeToFire;
								}
							}
						}
						if (num2 == 0f)
						{
							this.string_0 = Misc.GetTimeString((long)Math.Round((double)mount.GetTimeToFire()), Aircraft_AirOps._Maintenance.const_0, false, false);
						}
						else if (mount.ReloadStatus == Mount._ReloadStatus.Reloading)
						{
							this.string_0 = "重装载: " + Misc.GetTimeString((long)Math.Round((double)num2), Aircraft_AirOps._Maintenance.const_0, false, false);
						}
						else if (mount.ReloadStatus == Mount._ReloadStatus.Unloading)
						{
							this.string_0 = "卸载: " + Misc.GetTimeString((long)Math.Round((double)num2), Aircraft_AirOps._Maintenance.const_0, false, false);
						}
					}
					else
					{
						this.string_0 = Misc.GetTimeString((long)Math.Round((double)mount.GetTimeToFire()), Aircraft_AirOps._Maintenance.const_0, false, false);
					}
					TreeGridViewRow treeGridViewRow = this.class2384_0;
					object[] array = new object[4];
					array[0] = Misc.smethod_11(mount.Name);
					object[] array2 = array;
					string[] array3 = new string[5];
					array3[0] = "(";
					string[] array4 = array3;
					int num3 = 0;
					int num4 = 0;
					array4[1] = Conversions.ToString(mount.method_35(ref num3, ref num4));
					array4[2] = "/";
					array4[3] = Conversions.ToString(mount.Capacity);
					array4[4] = ")";
					array2[1] = string.Concat(array4);
					array2[2] = this.string_0;
					array2[3] = mount.GetComponentStatus().ToString();
					if (mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
					{
						array2[3] = "正常工作";
					}
					if (mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Damaged)
					{
						array2[3] = "受到毁伤";
					}
					if (mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
					{
						array2[3] = "已被摧毁";
					}
					treeGridViewRow.SetValues(array2);
					this.class2384_0.Tag = mount;
					this.class2384_0.DefaultCellStyle.BackColor = base.GetComponentColor(mount);
					this.method_7(this.class2384_0, mount.GetWeaponRecCollection());
					this.method_8(this.class2384_0, mount.GetWeaponRecCollection());
				}
				if (this.activeUnit_0.IsAircraft && !Information.IsNothing(((Aircraft)this.activeUnit_0).GetLoadout()))
				{
					Loadout loadout = ((Aircraft)this.activeUnit_0).GetLoadout();
					this.class2384_0 = this.vmethod_6().Nodes[this.vmethod_6().Nodes.Count - 1];
					TreeGridViewRow treeGridViewRow2 = this.class2384_0;
					object[] array = new object[2];
					array[0] = "Loadout: " + Misc.smethod_11(loadout.Name);
					object[] array5 = array;
					array5[1] = string.Concat(new string[]
					{
						"(",
						Conversions.ToString(loadout.method_16()),
						"/",
						Conversions.ToString(loadout.MaxCapacity),
						")"
					});
					treeGridViewRow2.SetValues(array5);
					this.class2384_0.Tag = loadout;
					this.method_7(this.class2384_0, loadout.WeaponRecArray);
					this.method_8(this.class2384_0, loadout.WeaponRecArray);
				}
				Application.DoEvents();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200103", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			this.vmethod_6().ResumeLayout();
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x00272BDC File Offset: 0x00270DDC
		private void WeaponsWindow_FormClosed(object sender, FormClosedEventArgs e)
		{
			PlatformComponent.smethod_1(new PlatformComponent.Delegate21(this.method_4));
			WeaponRec.smethod_1(new WeaponRec.Delegate24(this.method_5));
			Mount.smethod_3(new Mount.Delegate20(this.method_3));
			Client.smethod_22(delegate(Scenario argument0)
			{
				this.method_6();
			});
			Client.m_Mount = null;
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x000283B3 File Offset: 0x000265B3
		private void WeaponsWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Client.m_Mount = null;
			e.Cancel = true;
			this.vmethod_10().Stop();
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
			base.Hide();
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x00272C34 File Offset: 0x00270E34
		private void WeaponsWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (e.KeyCode == Keys.F8 && base.Visible)
			{
				base.Close();
			}
			else
			{
				if (this.bool_3)
				{
					if (e.KeyValue == 13 && base.Visible)
					{
						this.vmethod_28().Select();
						return;
					}
					if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12)
					{
						CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
					}
				}
				if (!this.bool_3 && e.KeyValue != 32)
				{
					CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
				}
			}
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x00272D80 File Offset: 0x00270F80
		private void WeaponsWindow_Load(object sender, EventArgs e)
		{
			this.bool_1 = false;
			PlatformComponent.smethod_0(new PlatformComponent.Delegate21(this.method_4));
			WeaponRec.smethod_0(new WeaponRec.Delegate24(this.method_5));
			Mount.smethod_2(new Mount.Delegate20(this.method_3));
			Client.smethod_21(delegate(Scenario argument0)
			{
				this.method_6();
			});
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x00272DF0 File Offset: 0x00270FF0
		private void WeaponsWindow_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				if (Information.IsNothing(this.activeUnit_0) && Client.GetHookedUnit().IsActiveUnit())
				{
					this.activeUnit_0 = (ActiveUnit)Client.GetHookedUnit();
				}
				if (Information.IsNothing(this.activeUnit_0) || !this.activeUnit_0.IsActiveUnit())
				{
					base.Hide();
				}
				else
				{
					this.method_10();
					this.vmethod_10().Start();
					if ((this.vmethod_6().Nodes.Count > 0 && !Information.IsNothing(this.activeUnit_0)) & this.activeUnit_0.m_Mounts.Length > 0)
					{
						this.mount_0 = (Mount)this.vmethod_6().Nodes[0].Tag;
					}
				}
			}
		}

		// Token: 0x04002BD5 RID: 11221
		public static Func<object, DataGridViewRow> func = (object argument0) => (DataGridViewRow)argument0;

		// Token: 0x04002BD6 RID: 11222
		public static Func<DataGridViewRow, bool> type = (DataGridViewRow argument1) => argument1.Tag.GetType() == typeof(WeaponRec);

		// Token: 0x04002BD7 RID: 11223
		public static Func<Mount, string> stringFunc = (Mount argument0) => argument0.Name;

		// Token: 0x04002BD9 RID: 11225
		private TreeGridViewTextBoxColumn class2383_0;

		// Token: 0x04002BDA RID: 11226
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		// Token: 0x04002BDB RID: 11227
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		// Token: 0x04002BDC RID: 11228
		[CompilerGenerated]
		private TreeGridView treeGridView_0;

		// Token: 0x04002BDD RID: 11229
		[CompilerGenerated]
		private ImageList imageList_0;

		// Token: 0x04002BDE RID: 11230
		[CompilerGenerated]
		private Timer timer_0;

		// Token: 0x04002BDF RID: 11231
		[CompilerGenerated]
		private ToolStrip toolStrip_0;

		// Token: 0x04002BE0 RID: 11232
		[CompilerGenerated]
		private ToolStripButton toolStripButton_0;

		// Token: 0x04002BE1 RID: 11233
		[CompilerGenerated]
		private ToolStripButton toolStripButton_1;

		// Token: 0x04002BE2 RID: 11234
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_0;

		// Token: 0x04002BE3 RID: 11235
		[CompilerGenerated]
		private ToolStripTextBox toolStripTextBox_0;

		// Token: 0x04002BE4 RID: 11236
		[CompilerGenerated]
		private ToolStripButton toolStripButton_2;

		// Token: 0x04002BE5 RID: 11237
		[CompilerGenerated]
		private ToolStripButton toolStripButton_3;

		// Token: 0x04002BE6 RID: 11238
		[CompilerGenerated]
		private ToolStripLabel toolStripLabel_1;

		// Token: 0x04002BE7 RID: 11239
		[CompilerGenerated]
		private ToolStripButton toolStripButton_4;

		// Token: 0x04002BE8 RID: 11240
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x04002BE9 RID: 11241
		[CompilerGenerated]
		private ToolStripSeparator toolStripSeparator_1;

		// Token: 0x04002BEA RID: 11242
		[CompilerGenerated]
		private TreeGridViewTextBoxColumn class2383_1;

		// Token: 0x04002BEB RID: 11243
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		// Token: 0x04002BEC RID: 11244
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		// Token: 0x04002BED RID: 11245
		[CompilerGenerated]
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		// Token: 0x04002BEE RID: 11246
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		// Token: 0x04002BEF RID: 11247
		[CompilerGenerated]
		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		// Token: 0x04002BF0 RID: 11248
		private TreeGridViewRow class2384_0;

		// Token: 0x04002BF1 RID: 11249
		private TreeGridViewRow class2384_1;

		// Token: 0x04002BF2 RID: 11250
		internal ActiveUnit activeUnit_0;

		// Token: 0x04002BF3 RID: 11251
		private bool bool_0;

		// Token: 0x04002BF4 RID: 11252
		private WeaponRec weaponRec_0;

		// Token: 0x04002BF5 RID: 11253
		private Mount mount_0;

		// Token: 0x04002BF6 RID: 11254
		private Loadout loadout_0;

		// Token: 0x04002BF7 RID: 11255
		private bool bool_1;

		// Token: 0x04002BF8 RID: 11256
		private string string_0;

		// Token: 0x04002BF9 RID: 11257
		private bool bool_2 = false;

		// Token: 0x04002BFA RID: 11258
		private bool bool_3;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns15;
using ns2;
using ns3;
using ns32;
using ns33;

namespace Command
{
	// Token: 0x02000A12 RID: 2578
	[DesignerGenerated]
	public sealed partial class ORBAT : CommandForm
	{
		// Token: 0x06004F8C RID: 20364 RVA: 0x00200A80 File Offset: 0x001FEC80
		public ORBAT()
		{
			base.Load += new EventHandler(this.ORBAT_Load);
			base.KeyDown += new KeyEventHandler(this.ORBAT_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.ORBAT_FormClosing);
			this.InitializeComponent();
		}

		// Token: 0x06004F8F RID: 20367 RVA: 0x00201284 File Offset: 0x001FF484
		[CompilerGenerated]
		internal  TabControl vmethod_0()
		{
			return this.tabControl_0;
		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x000254BB File Offset: 0x000236BB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_1(TabControl tabControl_1)
		{
			this.tabControl_0 = tabControl_1;
		}

		// Token: 0x06004F91 RID: 20369 RVA: 0x0020129C File Offset: 0x001FF49C
		[CompilerGenerated]
		internal  TabPage vmethod_2()
		{
			return this.tabPage_0;
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x000254C4 File Offset: 0x000236C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_3(TabPage tabPage_2)
		{
			this.tabPage_0 = tabPage_2;
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x002012B4 File Offset: 0x001FF4B4
		[CompilerGenerated]
		internal  TabPage vmethod_4()
		{
			return this.tabPage_1;
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x000254CD File Offset: 0x000236CD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_5(TabPage tabPage_2)
		{
			this.tabPage_1 = tabPage_2;
		}

		// Token: 0x06004F95 RID: 20373 RVA: 0x002012CC File Offset: 0x001FF4CC
		[CompilerGenerated]
		internal  StatusStrip vmethod_6()
		{
			return this.statusStrip_0;
		}

		// Token: 0x06004F96 RID: 20374 RVA: 0x000254D6 File Offset: 0x000236D6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_7(StatusStrip statusStrip_1)
		{
			this.statusStrip_0 = statusStrip_1;
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x002012E4 File Offset: 0x001FF4E4
		[CompilerGenerated]
		internal  ToolStripStatusLabel vmethod_8()
		{
			return this.toolStripStatusLabel_0;
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x000254DF File Offset: 0x000236DF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_9(ToolStripStatusLabel toolStripStatusLabel_1)
		{
			this.toolStripStatusLabel_0 = toolStripStatusLabel_1;
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x002012FC File Offset: 0x001FF4FC
		[CompilerGenerated]
		internal  Label vmethod_10()
		{
			return this.label_0;
		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x000254E8 File Offset: 0x000236E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_11(Label label_3)
		{
			this.label_0 = label_3;
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x00201314 File Offset: 0x001FF514
		[CompilerGenerated]
		internal  Label vmethod_12()
		{
			return this.label_1;
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x000254F1 File Offset: 0x000236F1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_13(Label label_3)
		{
			this.label_1 = label_3;
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x0020132C File Offset: 0x001FF52C
		[CompilerGenerated]
		internal  Label vmethod_14()
		{
			return this.label_2;
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x000254FA File Offset: 0x000236FA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_15(Label label_3)
		{
			this.label_2 = label_3;
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x00201344 File Offset: 0x001FF544
		[CompilerGenerated]
		internal  ComboBox GetCB_Proficiency()
		{
			return this.CB_Proficiency;
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x0020135C File Offset: 0x001FF55C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetCB_Proficiency(ComboBox comboBox_1)
		{
			EventHandler value = new EventHandler(this.CB_Proficiency_SelectionChangeCommitted);
			ComboBox cB_Proficiency = this.CB_Proficiency;
			if (cB_Proficiency != null)
			{
				cB_Proficiency.SelectionChangeCommitted -= value;
			}
			this.CB_Proficiency = comboBox_1;
			cB_Proficiency = this.CB_Proficiency;
			if (cB_Proficiency != null)
			{
				cB_Proficiency.SelectionChangeCommitted += value;
			}
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x002013A8 File Offset: 0x001FF5A8
		[CompilerGenerated]
		internal  CommandTreeView vmethod_18()
		{
			return this.class674_0;
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x002013C0 File Offset: 0x001FF5C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void vmethod_19(CommandTreeView class674_2)
		{
			TreeViewEventHandler treeViewEventHandler_ = new TreeViewEventHandler(this.method_4);
			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.method_5);
			CommandTreeView commandTreeView = this.class674_0;
			if (commandTreeView != null)
			{
				commandTreeView.method_1(treeViewEventHandler_);
				commandTreeView.NodeMouseClick -= value;
			}
			this.class674_0 = class674_2;
			commandTreeView = this.class674_0;
			if (commandTreeView != null)
			{
				commandTreeView.method_0(treeViewEventHandler_);
				commandTreeView.NodeMouseClick += value;
			}
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x00201424 File Offset: 0x001FF624
		[CompilerGenerated]
		internal  CommandTreeView GetTV_ByMission()
		{
			return this.TV_ByMission;
		}

		// Token: 0x06004FA4 RID: 20388 RVA: 0x0020143C File Offset: 0x001FF63C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal  void SetTV_ByMission(CommandTreeView tv_)
		{
			TreeViewEventHandler treeViewEventHandler_ = new TreeViewEventHandler(this.method_9);
			TreeNodeMouseClickEventHandler value = new TreeNodeMouseClickEventHandler(this.method_10);
			CommandTreeView tV_ByMission = this.TV_ByMission;
			if (tV_ByMission != null)
			{
				tV_ByMission.method_1(treeViewEventHandler_);
				tV_ByMission.NodeMouseClick -= value;
			}
			this.TV_ByMission = tv_;
			tV_ByMission = this.TV_ByMission;
			if (tV_ByMission != null)
			{
				tV_ByMission.method_0(treeViewEventHandler_);
				tV_ByMission.NodeMouseClick += value;
			}
		}

		// Token: 0x06004FA5 RID: 20389 RVA: 0x00025503 File Offset: 0x00023703
		private void ORBAT_Load(object sender, EventArgs e)
		{
			if (Client.float_0 == 1f)
			{
				base.AutoScaleMode = AutoScaleMode.None;
			}
			this.method_1();
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x002014A0 File Offset: 0x001FF6A0
		public void method_1()
		{
			this.method_3();
			this.method_6();
			if (!Information.IsNothing(Client.GetClientSide()))
			{
				this.vmethod_12().Text = Misc.GetProficiencyLevelString(Client.GetClientSide().GetProficiencyLevel());
			}
			this.vmethod_14().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			this.GetCB_Proficiency().Visible = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x00201510 File Offset: 0x001FF710
		public Color method_2(ActiveUnit activeUnit_0)
		{
			GlobalVariables.ProficiencyLevel? proficiencyLevel = activeUnit_0.GetProficiencyLevel();
			int? num = proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
			Color result = Color.Green;
			if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
			{
				result = Color.Green;
			}
			else
			{
				num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					result = Color.Lime;
				}
				else
				{
					num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						result = Color.Yellow;
					}
					else
					{
						num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
						{
							result = Color.Orange;
						}
						else
						{
							num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
							{
								result = Color.Red;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x00201700 File Offset: 0x001FF900
		private void method_3()
		{
			this.vmethod_18().Nodes.Clear();
			List<ActiveUnit> list = Client.GetClientSide().ActiveUnitArray.Select(ORBAT.ActiveUnitFunc0).OrderBy(ORBAT.ActiveUnitFunc1, new Class265<string[]>(true)).ToList<ActiveUnit>();
			foreach (ActiveUnit current in list)
			{
				if (current.IsGroup)
				{
					TreeNode treeNode = this.vmethod_18().Nodes.Add(current.Name);
					treeNode.Tag = current;
					List<ActiveUnit> list2 = ((Group)current).GetUnitsInGroup().Values.Select(ORBAT.ActiveUnitFunc2).OrderBy(ORBAT.ActiveUnitFunc3, new Class265<string[]>(true)).ToList<ActiveUnit>();
					foreach (ActiveUnit current2 in list2)
					{
						TreeNode treeNode2 = treeNode.Nodes.Add(current2.Name + " (" + Misc.smethod_11(current2.UnitClass) + ")");
						treeNode2.NodeFont = new Font(this.vmethod_18().Font, FontStyle.Regular);
						treeNode2.ForeColor = this.method_2(current2);
						treeNode2.Tag = current2;
						IEnumerable<ActiveUnit> enumerable = current2.GetDockingOps().GetDockedUnits().OrderBy(ORBAT.ActiveUnitFunc4, new Class265<string[]>(true)).Select(ORBAT.ActiveUnitFunc5);
						foreach (ActiveUnit current3 in enumerable)
						{
							TreeNode treeNode3 = treeNode2.Nodes.Add(current3.Name + " (" + Misc.smethod_11(current3.UnitClass) + ")");
							treeNode3.NodeFont = new Font(this.vmethod_18().Font, FontStyle.Regular);
							treeNode3.ForeColor = this.method_2(current3);
							treeNode3.Tag = current3;
						}
						IEnumerable<Aircraft> enumerable2 = current2.GetAirOps().GetHostedAircrafts().OrderBy(ORBAT.AircraftFunc6, new Class265<string[]>(true)).Select(ORBAT.AircraftFunc7);
						foreach (Aircraft current4 in enumerable2)
						{
							TreeNode treeNode4 = treeNode2.Nodes.Add(current4.Name + " (" + Misc.smethod_11(current4.UnitClass) + ")");
							treeNode4.NodeFont = new Font(this.vmethod_18().Font, FontStyle.Regular);
							treeNode4.ForeColor = this.method_2(current4);
							treeNode4.Tag = current4;
						}
					}
					treeNode.ExpandAll();
				}
				if (current.IsOperating() && current.IsPlatform() && !current.IsGroup && !current.HasParentGroup())
				{
					TreeNode treeNode2 = this.vmethod_18().Nodes.Add(current.Name + " (" + Misc.smethod_11(current.UnitClass) + ")");
					treeNode2.NodeFont = new Font(this.vmethod_18().Font, FontStyle.Regular);
					treeNode2.ForeColor = this.method_2(current);
					treeNode2.Tag = current;
					IEnumerable<ActiveUnit> enumerable = current.GetDockingOps().GetDockedUnits().OrderBy(ORBAT.ActiveUnitFunc8, new Class265<string[]>(true)).Select(ORBAT.ActiveUnitFunc9);
					foreach (ActiveUnit current5 in enumerable)
					{
						TreeNode treeNode5 = treeNode2.Nodes.Add(current5.Name + " (" + Misc.smethod_11(current5.UnitClass) + ")");
						treeNode5.NodeFont = new Font(this.vmethod_18().Font, FontStyle.Regular);
						treeNode5.ForeColor = this.method_2(current5);
						treeNode5.Tag = current5;
					}
					IEnumerable<Aircraft> enumerable2 = current.GetAirOps().GetHostedAircrafts().OrderBy(ORBAT.AircraftFunc10, new Class265<string[]>(true)).Select(ORBAT.AircraftFunc11);
					foreach (Aircraft current6 in enumerable2)
					{
						TreeNode treeNode6 = treeNode2.Nodes.Add(current6.Name + " (" + Misc.smethod_11(current6.UnitClass) + ")");
						treeNode6.NodeFont = new Font(this.vmethod_18().Font, FontStyle.Regular);
						treeNode6.ForeColor = this.method_2(current6);
						treeNode6.Tag = current6;
					}
					treeNode2.ExpandAll();
				}
			}
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x00201C68 File Offset: 0x001FFE68
		private void method_4(object sender, TreeViewEventArgs e)
		{
			try
			{
				ActiveUnit activeUnit_ = (ActiveUnit)e.Node.Tag;
				e.Node.ForeColor = this.method_2(activeUnit_);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200398", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x00201CE8 File Offset: 0x001FFEE8
		private void method_5(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Node.Bounds.Contains(e.Location))
			{
				ActiveUnit activeUnit = (ActiveUnit)e.Node.Tag;
				if (activeUnit.IsOperating())
				{
					CommandFactory.GetCommandMain().GetMainForm().method_14(true, new GeoPoint(activeUnit.GetLongitude(null), activeUnit.GetLatitude(null)));
					CommandFactory.GetCommandMain().GetMainForm().method_18(activeUnit, true);
				}
				GlobalVariables.ProficiencyLevel? proficiencyLevel = activeUnit.GetProficiencyLevel();
				int? num = proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					this.GetCB_Proficiency().SelectedIndex = 0;
				}
				else
				{
					num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						this.GetCB_Proficiency().SelectedIndex = 1;
					}
					else
					{
						num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							this.GetCB_Proficiency().SelectedIndex = 2;
						}
						else
						{
							num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								this.GetCB_Proficiency().SelectedIndex = 3;
							}
							else
							{
								num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									this.GetCB_Proficiency().SelectedIndex = 4;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x00201F6C File Offset: 0x0020016C
		private void method_6()
		{
			this.GetTV_ByMission().Nodes.Clear();
			checked
			{
				if (!Information.IsNothing(Client.GetClientSide()))
				{
					IEnumerable<Mission> enumerable = Client.GetClientSide().GetPatrolMissionCollection(Client.GetClientScenario()).OrderBy(ORBAT.MissionFunc12);
					foreach (Mission current in enumerable)
					{
						TreeNode treeNode = this.GetTV_ByMission().Nodes.Add(current.Name);
						if (current.IsActive())
						{
							treeNode.ForeColor = Color.Green;
						}
						else
						{
							treeNode.ForeColor = Color.Red;
							treeNode.NodeFont = new Font(this.Font, FontStyle.Italic);
						}
						treeNode.Tag = current;
						List<Aircraft> list = new List<Aircraft>();
						List<ActiveUnit> list2 = new List<ActiveUnit>();
						ActiveUnit[] activeUnitArray = Client.GetClientSide().ActiveUnitArray;
						for (int i = 0; i < activeUnitArray.Length; i++)
						{
							ActiveUnit activeUnit = activeUnitArray[i];
							if (!(activeUnit.HasParentGroup() | (activeUnit.IsWeapon && ((Weapon)activeUnit).GetWeaponType() == Weapon._WeaponType.Sonobuoy)) && activeUnit.GetAssignedMission(false) == current)
							{
								if (activeUnit.IsAircraft)
								{
									list.Add((Aircraft)activeUnit);
								}
								else if (!activeUnit.IsSubmarine || !((Submarine)activeUnit).IsROV())
								{
									list2.Add(activeUnit);
								}
							}
						}
						IEnumerable<Aircraft> enumerable2 = list.OrderBy(ORBAT.AircraftFunc13).ThenBy(new Func<Aircraft, string>(this.method_12));
						IEnumerable<ActiveUnit> enumerable3 = list2.OrderBy(ORBAT.ActiveUnitFunc14);
						foreach (Aircraft current2 in enumerable2)
						{
							TreeNode treeNode2 = null;
							string unitClass = current2.UnitClass;
							IEnumerator enumerator3 = treeNode.Nodes.GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									TreeNode treeNode3 = (TreeNode)enumerator3.Current;
									if (Operators.CompareString(treeNode3.Tag.ToString(), unitClass, false) == 0)
									{
										treeNode2 = treeNode3;
									}
								}
							}
							finally
							{
								if (enumerator3 is IDisposable)
								{
									(enumerator3 as IDisposable).Dispose();
								}
							}
							if (Information.IsNothing(treeNode2))
							{
								treeNode2 = treeNode.Nodes.Add(current2.UnitClass);
								treeNode2.Tag = current2.UnitClass;
							}
							string text = this.method_8(current2);
							TreeNode treeNode4 = treeNode2.Nodes.Add(text);
							treeNode4.Tag = current2;
							treeNode4.ForeColor = this.method_2(current2);
							treeNode2.Text = Conversions.ToString(treeNode2.Nodes.Count) + "x " + Misc.smethod_11(Conversions.ToString(treeNode2.Tag));
							treeNode2 = null;
						}
						foreach (ActiveUnit current3 in enumerable3)
						{
							string name = current3.Name;
							TreeNode treeNode5 = treeNode.Nodes.Add(name + " (" + Misc.smethod_11(current3.UnitClass) + ")");
							treeNode5.ForeColor = this.method_2(current3);
							treeNode5.Tag = current3;
							if (current3.IsGroup)
							{
								foreach (ActiveUnit current4 in ((Group)current3).GetUnitsInGroup().Values)
								{
									TreeNode treeNode6 = treeNode5.Nodes.Add(current4.Name + " (" + Misc.smethod_11(current4.UnitClass) + ")");
									treeNode6.ForeColor = this.method_2(current4);
									treeNode6.Tag = current4;
								}
							}
						}
						treeNode.Expand();
					}
				}
			}
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x002023EC File Offset: 0x002005EC
		private string method_7(Aircraft aircraft_0)
		{
			ActiveUnit currentHostUnit = aircraft_0.GetAircraftAirOps().GetCurrentHostUnit();
			string result;
			if (Information.IsNothing(currentHostUnit))
			{
				result = "Airborne";
			}
			else
			{
				result = currentHostUnit.Name;
			}
			return result;
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x00202428 File Offset: 0x00200628
		private string method_8(Aircraft aircraft_0)
		{
			string text = null;
			string result;
			if (aircraft_0.GetMaintenanceLevel(ref text) == Aircraft_AirOps._Maintenance.Unavailable)
			{
				result = "[UNAVAILABLE] " + aircraft_0.Name;
			}
			else
			{
				string text2;
				if (aircraft_0.IsOperating())
				{
					text2 = "Airborne";
				}
				else
				{
					text2 = aircraft_0.GetAircraftAirOps().GetCurrentHostUnit().Name;
				}
				string text3;
				if (Information.IsNothing(aircraft_0.GetLoadout()))
				{
					text3 = "";
				}
				else
				{
					text3 = " (" + aircraft_0.GetLoadout().Name + ")";
				}
				result = string.Concat(new string[]
				{
					aircraft_0.Name,
					text3,
					" (",
					text2,
					")"
				});
			}
			return result;
		}

		// Token: 0x06004FAE RID: 20398 RVA: 0x002024F8 File Offset: 0x002006F8
		private void method_9(object sender, TreeViewEventArgs e)
		{
			try
			{
				ActiveUnit activeUnit_ = (ActiveUnit)e.Node.Tag;
				e.Node.ForeColor = this.method_2(activeUnit_);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200400", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004FAF RID: 20399 RVA: 0x00202578 File Offset: 0x00200778
		private void method_10(object sender, TreeNodeMouseClickEventArgs e)
		{
			try
			{
				if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(e.Node.Tag)))
				{
					try
					{
						if (((Unit)e.Node.Tag).IsActiveUnit())
						{
							ActiveUnit activeUnit = (ActiveUnit)e.Node.Tag;
							CommandFactory.GetCommandMain().GetMainForm().method_14(true, new GeoPoint(activeUnit.GetLongitude(null), activeUnit.GetLatitude(null)));
							CommandFactory.GetCommandMain().GetMainForm().method_18(activeUnit, true);
							GlobalVariables.ProficiencyLevel? proficiencyLevel = activeUnit.GetProficiencyLevel();
							int? num = proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								this.GetCB_Proficiency().SelectedIndex = 0;
							}
							else
							{
								num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									this.GetCB_Proficiency().SelectedIndex = 1;
								}
								else
								{
									num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										this.GetCB_Proficiency().SelectedIndex = 2;
									}
									else
									{
										num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											this.GetCB_Proficiency().SelectedIndex = 3;
										}
										else
										{
											num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
											if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												this.GetCB_Proficiency().SelectedIndex = 4;
											}
										}
									}
								}
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200401", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004FB0 RID: 20400 RVA: 0x001F42C4 File Offset: 0x001F24C4
		private void ORBAT_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape && base.Visible)
			{
				base.Close();
			}
			else if (!base.Visible || (e.KeyCode != Keys.Prior && e.KeyCode != Keys.Next && e.KeyCode != Keys.End && e.KeyCode != Keys.Home && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Add && e.KeyCode != Keys.Subtract && (e.KeyCode != Keys.C || e.Modifiers != Keys.Control) && (e.KeyCode != Keys.X || e.Modifiers != Keys.Control)))
			{
				CommandFactory.GetCommandMain().GetMainForm().MainForm_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06004FB1 RID: 20401 RVA: 0x0020288C File Offset: 0x00200A8C
		private void CB_Proficiency_SelectionChangeCommitted(object sender, EventArgs e)
		{
			GlobalVariables.ProficiencyLevel? proficiencyLevel = null;
			switch (this.GetCB_Proficiency().SelectedIndex)
			{
			case 0:
				proficiencyLevel = new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Novice);
				break;
			case 1:
				proficiencyLevel = new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Cadet);
				break;
			case 2:
				proficiencyLevel = new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Regular);
				break;
			case 3:
				proficiencyLevel = new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Veteran);
				break;
			case 4:
				proficiencyLevel = new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Ace);
				break;
			case 5:
				proficiencyLevel = null;
				break;
			}
			int selectedIndex = this.vmethod_0().SelectedIndex;
			if (selectedIndex != 0)
			{
				if (selectedIndex != 1)
				{
					return;
				}
				IEnumerator enumerator = this.GetTV_ByMission().method_9().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						try
						{
							if (((Unit)NewLateBinding.LateGet(objectValue, null, "Tag", new object[0], null, null, null)).IsActiveUnit())
							{
								((ActiveUnit)NewLateBinding.LateGet(objectValue, null, "Tag", new object[0], null, null, null)).SetProficiencyLevel(proficiencyLevel);
								NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[]
								{
									this.method_2((ActiveUnit)NewLateBinding.LateGet(objectValue, null, "Tag", new object[0], null, null, null))
								}, null, null);
								if (((ActiveUnit)NewLateBinding.LateGet(objectValue, null, "Tag", new object[0], null, null, null)).IsGroup)
								{
									IEnumerator enumerator2 = ((IEnumerable)NewLateBinding.LateGet(objectValue, null, "Nodes", new object[0], null, null, null)).GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
											NewLateBinding.LateSet(objectValue2, null, "forecolor", new object[]
											{
												this.method_2((ActiveUnit)NewLateBinding.LateGet(objectValue2, null, "tag", new object[0], null, null, null))
											}, null, null);
										}
									}
									finally
									{
										if (enumerator2 is IDisposable)
										{
											(enumerator2 as IDisposable).Dispose();
										}
									}
								}
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200402", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
					}
					return;
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			IEnumerator enumerator3 = this.vmethod_18().method_9().GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator3.Current;
					((ActiveUnit)treeNode.Tag).SetProficiencyLevel(proficiencyLevel);
					treeNode.ForeColor = this.method_2((ActiveUnit)treeNode.Tag);
					if (((ActiveUnit)treeNode.Tag).IsGroup)
					{
						IEnumerator enumerator4 = treeNode.Nodes.GetEnumerator();
						try
						{
							while (enumerator4.MoveNext())
							{
								object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator4.Current);
								NewLateBinding.LateSet(objectValue3, null, "forecolor", new object[]
								{
									this.method_2((ActiveUnit)NewLateBinding.LateGet(objectValue3, null, "tag", new object[0], null, null, null))
								}, null, null);
							}
						}
						finally
						{
							if (enumerator4 is IDisposable)
							{
								(enumerator4 as IDisposable).Dispose();
							}
						}
					}
				}
			}
			finally
			{
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06004FB2 RID: 20402 RVA: 0x00004D83 File Offset: 0x00002F83
		private void ORBAT_FormClosing(object sender, FormClosingEventArgs e)
		{
			CommandFactory.GetCommandMain().GetMainForm().BringToFront();
		}

		// Token: 0x06004FB3 RID: 20403 RVA: 0x00202CA4 File Offset: 0x00200EA4
		[CompilerGenerated]
		private string method_12(Aircraft aircraft_0)
		{
			return this.method_7(aircraft_0);
		}

		// Token: 0x0400257B RID: 9595
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc0 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x0400257C RID: 9596
		public static Func<ActiveUnit, string> ActiveUnitFunc1 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x0400257D RID: 9597
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc2 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x0400257E RID: 9598
		public static Func<ActiveUnit, string> ActiveUnitFunc3 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x0400257F RID: 9599
		public static Func<ActiveUnit, string> ActiveUnitFunc4 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x04002580 RID: 9600
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc5 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04002581 RID: 9601
		public static Func<Aircraft, string> AircraftFunc6 = (Aircraft aircraft_0) => aircraft_0.Name;

		// Token: 0x04002582 RID: 9602
		public static Func<Aircraft, Aircraft> AircraftFunc7 = (Aircraft aircraft_0) => aircraft_0;

		// Token: 0x04002583 RID: 9603
		public static Func<ActiveUnit, string> ActiveUnitFunc8 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x04002584 RID: 9604
		public static Func<ActiveUnit, ActiveUnit> ActiveUnitFunc9 = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04002585 RID: 9605
		public static Func<Aircraft, string> AircraftFunc10 = (Aircraft aircraft_0) => aircraft_0.Name;

		// Token: 0x04002586 RID: 9606
		public static Func<Aircraft, Aircraft> AircraftFunc11 = (Aircraft aircraft_0) => aircraft_0;

		// Token: 0x04002587 RID: 9607
		public static Func<Mission, string> MissionFunc12 = (Mission mission_0) => mission_0.Name;

		// Token: 0x04002588 RID: 9608
		public static Func<Aircraft, string> AircraftFunc13 = (Aircraft aircraft_0) => aircraft_0.UnitClass;

		// Token: 0x04002589 RID: 9609
		public static Func<ActiveUnit, string> ActiveUnitFunc14 = (ActiveUnit activeUnit_0) => activeUnit_0.Name;

		// Token: 0x0400258B RID: 9611
		[CompilerGenerated]
		private TabControl tabControl_0;

		// Token: 0x0400258C RID: 9612
		[CompilerGenerated]
		private TabPage tabPage_0;

		// Token: 0x0400258D RID: 9613
		[CompilerGenerated]
		private TabPage tabPage_1;

		// Token: 0x0400258E RID: 9614
		[CompilerGenerated]
		private StatusStrip statusStrip_0;

		// Token: 0x0400258F RID: 9615
		[CompilerGenerated]
		private ToolStripStatusLabel toolStripStatusLabel_0;

		// Token: 0x04002590 RID: 9616
		[CompilerGenerated]
		private Label label_0;

		// Token: 0x04002591 RID: 9617
		[CompilerGenerated]
		private Label label_1;

		// Token: 0x04002592 RID: 9618
		[CompilerGenerated]
		private Label label_2;

		// Token: 0x04002593 RID: 9619
		[CompilerGenerated]
		private ComboBox CB_Proficiency;

		// Token: 0x04002594 RID: 9620
		[CompilerGenerated]
		private CommandTreeView class674_0;

		// Token: 0x04002595 RID: 9621
		[CompilerGenerated]
		private CommandTreeView TV_ByMission;
	}
}

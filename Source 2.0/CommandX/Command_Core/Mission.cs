using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 使命
	public abstract class Mission : Subject
	{
		// Token: 0x06005416 RID: 21526 RVA: 0x00228678 File Offset: 0x00226878
		public virtual void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Mission");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("Category", ((byte)this.category).ToString());
				this.m_Doctrine.Save(ref xmlWriter_0, ref scenario_0, "Doctrine");
				if (this.START.HasValue)
				{
					xmlWriter_0.WriteElementString("START", this.START.Value.ToBinary().ToString());
				}
				if (this.END.HasValue)
				{
					xmlWriter_0.WriteElementString("END", this.END.Value.ToBinary().ToString());
				}
				if (this.START.HasValue)
				{
					xmlWriter_0.WriteElementString("TakeOffTime", this.TakeOffTime.Value.ToBinary().ToString());
				}
				if (this.END.HasValue)
				{
					xmlWriter_0.WriteElementString("TimeOnTarget", this.TimeOnTarget.Value.ToBinary().ToString());
				}
				xmlWriter_0.WriteElementString("Deactivation_UnassignUnits", this.Deactivation_UnassignUnits.ToString());
				xmlWriter_0.WriteElementString("CheckBox_OrderRTB", this.CheckBox_OrderRTB.ToString());
				xmlWriter_0.WriteElementString("CheckBox_DeleteMission", this.CheckBox_DeleteMission.ToString());
				xmlWriter_0.WriteElementString("SISIH", this.SISIH.ToString());
				byte tankerUsage;
				if (this.missionStatus != Mission._MissionStatus.Activation)
				{
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Status";
					tankerUsage = (byte)this.missionStatus;
					xmlWriter.WriteElementString(localName, tankerUsage.ToString());
				}
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "TankerUsage";
				tankerUsage = (byte)this.TankerUsage;
				xmlWriter2.WriteElementString(localName2, tankerUsage.ToString());
				xmlWriter_0.WriteStartElement("TankerMissionList");
				foreach (Mission current in this.TankerMissionList)
				{
					if (!Information.IsNothing(current))
					{
						xmlWriter_0.WriteElementString("ID", current.GetGuid());
					}
				}
				xmlWriter_0.WriteEndElement();
				if (this.LaunchMissionWithoutTankersInPlace)
				{
					xmlWriter_0.WriteElementString("LaunchMissionWithoutTankersInPlace", this.LaunchMissionWithoutTankersInPlace.ToString());
				}
				xmlWriter_0.WriteElementString("TankerMinNumber_Total", this.TankerMinNumber_Total.ToString());
				xmlWriter_0.WriteElementString("TankerMinNumber_Airborne", this.TankerMinNumber_Airborne.ToString());
				xmlWriter_0.WriteElementString("TankerMinNumber_Station", this.TankerMinNumber_Station.ToString());
				xmlWriter_0.WriteElementString("MaxReceiversInQueuePerTanker_Airborne", this.MaxReceiversInQueuePerTanker_Airborne.ToString());
				xmlWriter_0.WriteElementString("FuelQtyToStartLookingForTanker_Airborne", this.FuelQtyToStartLookingForTanker_Airborne.ToString());
				xmlWriter_0.WriteElementString("TankerMaxDistance_Airborne", this.TankerMaxDistance_Airborne.ToString());
				xmlWriter_0.WriteElementString("TankerFollowsReceivers", this.bTankerFollowsReceivers.ToString());
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "FlightSize";
				int num = (int)this.m_FlightSize;
				xmlWriter3.WriteElementString(localName3, num.ToString());
				XmlWriter xmlWriter4 = xmlWriter_0;
				string localName4 = "GroupSize";
				num = (int)this.m_GroupSize;
				xmlWriter4.WriteElementString(localName4, num.ToString());
				if (this.HasFlights())
				{
					Mission.Flight.Save(ref xmlWriter_0, ref hashSet_0, ref scenario_0, ref this.FlightList);
				}
				if (!Information.IsNothing(this.EmptySlotsList) && this.EmptySlotsList.Count > 0)
				{
					Mission.EmptySlot.Save(ref xmlWriter_0, ref hashSet_0, ref scenario_0, ref this.EmptySlotsList);
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100639", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005417 RID: 21527 RVA: 0x00228A9C File Offset: 0x00226C9C
		public static Mission Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			Mission result = null;
			try
			{
				string name = xmlNode_0.Name;
				uint num = Class382.smethod_0(name);
				if (num <= 2699781355u)
				{
					if (num <= 1487674855u)
					{
						if (num != 211262994u)
						{
							if (num == 1487674855u && Operators.CompareString(name, "CargoMission", false) == 0)
							{
								result = CargoMission.smethod_7(ref xmlNode_0, ref dictionary_0, ref scenario_0);
							}
						}
						else if (Operators.CompareString(name, "TaskPool", false) == 0)
						{
							result = TaskPool.Load(ref xmlNode_0, ref dictionary_0, ref scenario_0);
						}
					}
					else if (num != 1849856623u)
					{
						if (num == 2699781355u && Operators.CompareString(name, "FerryMission", false) == 0)
						{
							result = FerryMission.Load(ref xmlNode_0, ref dictionary_0, scenario_0);
						}
					}
					else if (Operators.CompareString(name, "Strike", false) == 0)
					{
						result = Strike.Load(ref xmlNode_0, ref dictionary_0, scenario_0);
					}
				}
				else if (num <= 3100519701u)
				{
					if (num != 2895700795u)
					{
						if (num == 3100519701u && Operators.CompareString(name, "MiningMission", false) == 0)
						{
							result = MiningMission.Load(ref xmlNode_0, ref dictionary_0, ref scenario_0);
						}
					}
					else if (Operators.CompareString(name, "Patrol", false) == 0)
					{
						result = Patrol.Load(ref xmlNode_0, ref dictionary_0, ref scenario_0);
					}
				}
				else if (num != 3599814949u)
				{
					if (num == 3891038774u && Operators.CompareString(name, "SupportMission", false) == 0)
					{
						result = SupportMission.Load(ref xmlNode_0, ref dictionary_0, ref scenario_0);
					}
				}
				else if (Operators.CompareString(name, "MineClearingMission", false) == 0)
				{
					result = MineClearingMission.Load(ref xmlNode_0, ref dictionary_0, ref scenario_0);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100640", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Patrol(null, scenario_0, "ERROR", Mission.MissionCategory.Mission, null, GlobalVariables.PatrolType.AAW, false);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005418 RID: 21528 RVA: 0x00228CC4 File Offset: 0x00226EC4
		public float? GetTransitAltitude(ref Aircraft aircraft_, ref bool bTerrainFollowing)
		{
			float? result = null;
			switch (this.MissionClass)
			{
			case Mission._MissionClass.Strike:
				if (aircraft_.GetAircraftAI().IsEscort)
				{
					Strike strike = (Strike)this;
					bTerrainFollowing = strike.Escort_TransitTerrainFollowing;
					result = strike.Escort_TransitAltitude;
				}
				else if (!Information.IsNothing(aircraft_.GetLoadout()))
				{
					if (aircraft_.GetLoadout().GetMissionProfile(aircraft_.m_Scenario).CruiseAtOptimumAltitude)
					{
						bTerrainFollowing = false;
						result = new float?(aircraft_.GetAircraftAI().method_78(ref aircraft_, ActiveUnit.Throttle.Cruise, ref bTerrainFollowing));
					}
					else
					{
						bTerrainFollowing = aircraft_.GetLoadout().GetMissionProfile(aircraft_.m_Scenario).CruiseAltitudeEgressTerrainFollowing;
						result = new float?(aircraft_.GetLoadout().GetMissionProfile(aircraft_.m_Scenario).CruiseAltitudeEgress);
					}
				}
				else
				{
					bTerrainFollowing = false;
					result = new float?(aircraft_.GetAircraftAI().method_78(ref aircraft_, ActiveUnit.Throttle.Cruise, ref bTerrainFollowing));
				}
				break;
			case Mission._MissionClass.Patrol:
			{
				Patrol patrol = (Patrol)this;
				bTerrainFollowing = patrol.TransitTerrainFollowing_Aircraft;
				result = patrol.TransitAltitude_Aircraft;
				break;
			}
			case Mission._MissionClass.Support:
			{
				SupportMission supportMission = (SupportMission)this;
				bTerrainFollowing = supportMission.TransitTerrainFollowing_Aircraft;
				result = supportMission.TransitAltitude_Aircraft;
				break;
			}
			case Mission._MissionClass.Ferry:
			{
				FerryMission ferryMission = (FerryMission)this;
				bTerrainFollowing = false;
				result = ferryMission.FerryAltitude_Aircraft;
				break;
			}
			case Mission._MissionClass.Mining:
			{
				MiningMission miningMission = (MiningMission)this;
				bTerrainFollowing = miningMission.TransitTerrainFollowing_Aircraft;
				result = miningMission.TransitAltitude_Aircraft;
				break;
			}
			case Mission._MissionClass.MineClearing:
			{
				MineClearingMission mineClearingMission = (MineClearingMission)this;
				bTerrainFollowing = mineClearingMission.TransitTerrainFollowing_Aircraft;
				result = mineClearingMission.TransitAltitude_Aircraft;
				break;
			}
			case Mission._MissionClass.Escort:
			{
				TankerMission tankerMission = (TankerMission)this;
				bTerrainFollowing = tankerMission.TransitTerrainFollowing_Aircraft;
				result = tankerMission.TransitAltitude_Aircraft;
				break;
			}
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06005419 RID: 21529 RVA: 0x00228E80 File Offset: 0x00227080
		public ActiveUnit.Throttle? GetTransitThrottle(ref Aircraft aircraft_)
		{
			ActiveUnit.Throttle? result = null;
			switch (this.MissionClass)
			{
			case Mission._MissionClass.Strike:
				if (aircraft_.GetAircraftAI().IsEscort)
				{
					result = ((Strike)this).Escort_TransitThrottle;
				}
				else if (!Information.IsNothing(aircraft_.GetLoadout()))
				{
					result = new ActiveUnit.Throttle?(aircraft_.GetLoadout().GetMissionProfile(aircraft_.m_Scenario).CruiseThrottleSettingEgress);
				}
				else
				{
					result = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
				}
				break;
			case Mission._MissionClass.Patrol:
				result = ((Patrol)this).TransitThrottle_Aircraft;
				break;
			case Mission._MissionClass.Support:
				result = ((SupportMission)this).TransitThrottle_Aircraft;
				break;
			case Mission._MissionClass.Ferry:
				result = ((FerryMission)this).FerryThrottle_Aircraft;
				break;
			case Mission._MissionClass.Mining:
				result = ((MiningMission)this).TransitThrottle_Aircraft;
				break;
			case Mission._MissionClass.MineClearing:
				result = ((MineClearingMission)this).TransitThrottle_Aircraft;
				break;
			case Mission._MissionClass.Escort:
				result = ((TankerMission)this).TransitThrottle_Aircraft;
				break;
			default:
				result = new ActiveUnit.Throttle?(ActiveUnit.Throttle.FullStop);
				break;
			}
			return result;
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x00228F80 File Offset: 0x00227180
		public Mission._MissionStatus GetMissionStatus(Scenario scenario_)
		{
			return this.missionStatus;
		}

		// 设置使命状态
		public void SetMissionStatus(Scenario scenario_, Mission._MissionStatus MissionStatus_)
		{
			try
			{
				bool flag = MissionStatus_ != this.missionStatus;
				this.missionStatus = MissionStatus_;
				if (flag)
				{
					foreach (ActiveUnit current in scenario_.GetActiveUnits().Values)
					{
						if (!Information.IsNothing(current.GetAssignedMission(false)) && current.GetAssignedMission(false) == this && current.IsOperating())
						{
							current.GetAI().TargetingContacts(0f, false, false);
							current.GetAI().ThreatAssessment();
							current.GetAI().UpdateUnitStatus(0f, false, false);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100641", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x00026DD8 File Offset: 0x00024FD8
		public bool IsActive()
		{
			return this.missionStatus == Mission._MissionStatus.Activation;
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x002290A8 File Offset: 0x002272A8
		public string GetTaskPoolID(Side side_)
		{
			if (this.category == Mission.MissionCategory.Package && string.IsNullOrEmpty(this.TaskPoolID))
			{
				foreach (Mission current in side_.GetMissionCollection())
				{
					if (current.category == Mission.MissionCategory.TaskPool && ((TaskPool)current).Packages.Contains(this))
					{
						this.TaskPoolID = current.GetGuid();
						break;
					}
				}
			}
			return this.TaskPoolID;
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x00026DE3 File Offset: 0x00024FE3
		public void SetTaskPoolID(Side side_, string value)
		{
			this.TaskPoolID = value;
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x00229148 File Offset: 0x00227348
		public List<ActiveUnit> GetUnitsAssignedToMe(Scenario scenario_)
		{
			List<ActiveUnit> result = null;
			try
			{
				int count = scenario_.GetActiveUnitList().Count;
				List<ActiveUnit> list = new List<ActiveUnit>();
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					ActiveUnit activeUnit = scenario_.GetActiveUnitList()[i];
					if (activeUnit.GetAssignedMission(false) == this)
					{
						list.Add(activeUnit);
					}
				}
				result = list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100642", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x00229208 File Offset: 0x00227408
		public List<ActiveUnit> GetUnitsAssignedToMyTaskPool(Scenario scenario_)
		{
			List<ActiveUnit> result = null;
			try
			{
				int count = scenario_.GetActiveUnitList().Count;
				List<ActiveUnit> list = new List<ActiveUnit>();
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					ActiveUnit activeUnit = scenario_.GetActiveUnitList()[i];
					if (activeUnit.GetAssignedTaskPool() == this)
					{
						list.Add(activeUnit);
					}
				}
				result = list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200643", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005421 RID: 21537 RVA: 0x002292C4 File Offset: 0x002274C4
		public void method_20(Scenario scenario_, ref List<int> list_5, ref List<int> list_6, ref List<Aircraft> list_7, ref List<Aircraft> list_8, ref List<Aircraft> list_9, ref List<Aircraft> list_10, ref List<ActiveUnit> list_11, ref int int_7, ref int int_8, ref int int_9, ref int int_10, ref int int_11, ref int int_12, ref List<int> list_12, ref List<ActiveUnit> list_13, ref List<ActiveUnit> list_14, List<ActiveUnit> list_15, ref List<Aircraft> list_16, ref List<Aircraft> list_17, ref List<Aircraft> list_18, ref int int_13, ref int int_14, ref int int_15, ref List<Mission.Flight> list_19, ref List<Mission.Flight> list_20, ref List<Mission.Flight> list_21, bool bool_15, bool bool_16)
		{
			try
			{
				int num = scenario_.GetActiveUnitList().Count - 1;
				for (int i = 0; i <= num; i++)
				{
					ActiveUnit activeUnit = scenario_.GetActiveUnitList()[i];
					if (!activeUnit.IsGroup && activeUnit.GetAssignedMission(false) == this)
					{
						if (activeUnit.IsAircraft)
						{
							Aircraft aircraft = (Aircraft)activeUnit;
							list_7.Add(aircraft);
							if (!Information.IsNothing(aircraft.GetAircraftNavigator().GetFlight()))
							{
								list_9.Add(aircraft);
								Aircraft aircraft2 = aircraft;
								string text = null;
								if (aircraft2.GetMaintenanceLevel(ref text) == Aircraft_AirOps._Maintenance.const_0 && aircraft.IsParkedInPlace() && !Information.IsNothing(aircraft.GetLoadout()))
								{
									list_10.Add(aircraft);
									list_19.Add(aircraft.GetAircraftNavigator().GetFlight());
								}
								else
								{
									list_20.Add(aircraft.GetAircraftNavigator().GetFlight());
								}
							}
							else
							{
								Aircraft_AirOps aircraftAirOps = aircraft.GetAircraftAirOps();
								if (!list_6.Contains(aircraft.DBID))
								{
									list_6.Add(aircraft.DBID);
								}
								if (!Information.IsNothing(aircraftAirOps.GetCurrentHostUnit()))
								{
									if (!list_11.Contains(aircraftAirOps.GetCurrentHostUnit()))
									{
										list_11.Add(aircraftAirOps.GetCurrentHostUnit());
									}
									Aircraft aircraft3 = aircraft;
									string text = null;
									if (aircraft3.GetMaintenanceLevel(ref text) == Aircraft_AirOps._Maintenance.const_0 && (aircraft.IsParkedInPlace() || (!bool_15 && aircraft.IsParking())))
									{
										if (!Information.IsNothing(aircraft.GetLoadout()))
										{
											list_8.Add(aircraft);
											if (!list_5.Contains(aircraft.GetLoadout().DBID))
											{
												list_5.Add(aircraft.GetLoadout().DBID);
											}
											if (aircraft.GetAircraftAI().IsEscort)
											{
												if (aircraft.GetLoadout().method_15())
												{
													int_12++;
												}
												else
												{
													int_11++;
												}
											}
											else
											{
												int_10++;
											}
										}
									}
									else if (aircraftAirOps.method_24())
									{
										if (aircraft.GetAircraftAI().IsEscort)
										{
											if (aircraft.GetLoadout().method_15())
											{
												int_9++;
											}
											else
											{
												int_8++;
											}
										}
										else
										{
											int_7++;
										}
									}
								}
								else if (aircraft.GetAircraftAI().IsEscort)
								{
									if (aircraft.GetLoadout().method_15())
									{
										int_9++;
									}
									else
									{
										int_8++;
									}
								}
								else
								{
									int_7++;
								}
							}
						}
						else if (activeUnit.IsShip || activeUnit.IsSubmarine)
						{
							list_13.Add(activeUnit);
							if (!list_12.Contains(activeUnit.DBID))
							{
								list_12.Add(activeUnit.DBID);
							}
							if (!Information.IsNothing(activeUnit.GetDockingOps().GetCurrentHostUnit()))
							{
								if (!list_15.Contains(activeUnit.GetDockingOps().GetCurrentHostUnit()))
								{
									list_15.Add(activeUnit.GetDockingOps().GetCurrentHostUnit());
								}
								if (activeUnit.GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.Docked)
								{
									list_14.Add(activeUnit);
								}
							}
						}
					}
				}
				if (bool_16 && list_16.Count > 0)
				{
					int num2 = list_16.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						ActiveUnit activeUnit = list_16[j];
						Aircraft aircraft4 = (Aircraft)activeUnit;
						list_7.Add(aircraft4);
						if (!Information.IsNothing(aircraft4.GetAircraftNavigator().GetFlight()))
						{
							list_18.Add(aircraft4);
							list_21.Add(aircraft4.GetAircraftNavigator().GetFlight());
						}
						else
						{
							list_8.Add(aircraft4);
							Aircraft_AirOps aircraftAirOps2 = aircraft4.GetAircraftAirOps();
							if (!list_6.Contains(aircraft4.DBID))
							{
								list_6.Add(aircraft4.DBID);
							}
							if (!Information.IsNothing(aircraftAirOps2.GetCurrentHostUnit()))
							{
								if (!list_11.Contains(aircraftAirOps2.GetCurrentHostUnit()))
								{
									list_11.Add(aircraftAirOps2.GetCurrentHostUnit());
								}
								if (!Information.IsNothing(aircraft4.GetLoadout()))
								{
									list_17.Add(aircraft4);
									if (!list_5.Contains(aircraft4.GetLoadout().DBID))
									{
										list_5.Add(aircraft4.GetLoadout().DBID);
									}
									if (aircraft4.GetAircraftAI().IsEscort)
									{
										if (aircraft4.GetLoadout().method_15())
										{
											int_15++;
										}
										else
										{
											int_14++;
										}
									}
									else
									{
										int_13++;
									}
								}
							}
						}
					}
				}
				foreach (Mission.Flight current in list_20)
				{
					if (list_19.Contains(current))
					{
						list_19.Remove(current);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101241", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x00229820 File Offset: 0x00227A20
		public void method_21(ref Scenario scenario_, ref Side side_, ref Mission mission_, ref bool bool_15)
		{
			try
			{
				if (!Information.IsNothing(this.EmptySlotsList) && this.EmptySlotsList.Count != 0 && this.category == Mission.MissionCategory.Package)
				{
					new List<ActiveUnit>();
					new List<ActiveUnit>();
					new List<ActiveUnit>();
					Mission mission = null;
					foreach (Mission current in side_.GetMissionCollection())
					{
						if (Operators.CompareString(current.GetGuid(), this.GetTaskPoolID(side_), false) == 0)
						{
							mission = current;
							break;
						}
					}
					if (Information.IsNothing(mission))
					{
						Interaction.MsgBox("没有发现该任务的任务（Task）池!", MsgBoxStyle.OkOnly, "无任务（Task）池!");
					}
					else
					{
						List<ActiveUnit> list = mission.GetUnitsAssignedToMyTaskPool(scenario_).Where(Mission.UnassignedAndInActiveUnitFilter).ToList<ActiveUnit>();
						if (list.Count == 0)
						{
							if (bool_15)
							{
								Interaction.MsgBox("Could not find any available aircraft in the Task Pool!", MsgBoxStyle.OkOnly, "No available aircraft!");
							}
							else if (mission_.int_0 == 1)
							{
								scenario_.LogMessage("Package " + mission_.Name + " could not find any available aircraft in the Task Pool!", LoggedMessage.MessageType.AirOps, 0, null, side_, null);
							}
						}
						else
						{
							for (int i = this.EmptySlotsList.Count - 1; i >= 0; i += -1)
							{
								Mission.EmptySlot emptySlot = this.EmptySlotsList[i];
								foreach (ActiveUnit current2 in list)
								{
									if (current2.DBID == emptySlot.aircraftDBID)
									{
										Aircraft aircraft = (Aircraft)current2;
										if (aircraft.GetLoadoutDBID() == emptySlot.LoadoutDBID && !Information.IsNothing(aircraft.GetAircraftAirOps().GetCurrentHostUnit()) && Operators.CompareString(aircraft.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), emptySlot.CurrentHostUnit_ObjectID, false) == 0 && aircraft.GetAircraftAirOps().GetConditionTimer() <= 0f && (aircraft.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Parked || aircraft.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Readying))
										{
											aircraft.GetAircraftNavigator().SetFlight(emptySlot.GetFlight(scenario_));
											aircraft.FlightRole = emptySlot.MissionFlight_Role;
											this.EmptySlotsList.Remove(emptySlot);
											aircraft.DeleteMission(false, this);
											aircraft.m_Doctrine.Init();
											list.Remove(aircraft);
											break;
										}
									}
								}
							}
							list = mission.GetUnitsAssignedToMyTaskPool(scenario_).Where(Mission.UnassignedAndInActiveUnitFilter).ToList<ActiveUnit>();
							if (list.Count != 0 && this.EmptySlotsList.Count != 0)
							{
								for (int j = this.EmptySlotsList.Count - 1; j >= 0; j += -1)
								{
									Mission.EmptySlot emptySlot = this.EmptySlotsList[j];
									foreach (ActiveUnit current3 in list)
									{
										if (current3.DBID == emptySlot.aircraftDBID)
										{
											Aircraft aircraft2 = (Aircraft)current3;
											if (aircraft2.GetLoadoutDBID() == emptySlot.LoadoutDBID && !Information.IsNothing(aircraft2.GetAircraftAirOps().GetCurrentHostUnit()) && Operators.CompareString(aircraft2.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), emptySlot.CurrentHostUnit_ObjectID, false) == 0 && aircraft2.GetAircraftAirOps().GetConditionTimer() < (float)aircraft2.GetLoadout().ReadyTime && (aircraft2.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Parked || aircraft2.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Readying))
											{
												aircraft2.GetAircraftNavigator().SetFlight(emptySlot.GetFlight(scenario_));
												aircraft2.FlightRole = emptySlot.MissionFlight_Role;
												this.EmptySlotsList.Remove(emptySlot);
												aircraft2.DeleteMission(false, this);
												aircraft2.m_Doctrine.Init();
												list.Remove(aircraft2);
												break;
											}
										}
									}
								}
								list = mission.GetUnitsAssignedToMyTaskPool(scenario_).Where(Mission.UnassignedAndInActiveUnitFilter).ToList<ActiveUnit>();
								if (list.Count != 0 && this.EmptySlotsList.Count != 0)
								{
									for (int k = this.EmptySlotsList.Count - 1; k >= 0; k += -1)
									{
										Mission.EmptySlot emptySlot = this.EmptySlotsList[k];
										foreach (ActiveUnit current4 in list)
										{
											if (current4.DBID == emptySlot.aircraftDBID)
											{
												Aircraft aircraft3 = (Aircraft)current4;
												if (!Information.IsNothing(aircraft3.GetAircraftAirOps().GetCurrentHostUnit()) && Operators.CompareString(aircraft3.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), emptySlot.CurrentHostUnit_ObjectID, false) == 0 && aircraft3.GetLoadout().loadoutRole != Loadout.LoadoutRole.Unavailable)
												{
													Loadout loadout = new Loadout(emptySlot.LoadoutDBID, "tempLoadout", 1, 1, 1, 1, Loadout.LoadoutRole.None, Loadout._LoadoutDayNight.DayOnly, Loadout._WeatherProfile.None, 0f, 0, 0, false, false, false, 0, 0, 0, 0, Loadout._LoadoutDayNight.DayNight, Doctrine._WeaponState.LoadoutSetting);
													DBFunctions.smethod_49(ref scenario_, ref loadout, emptySlot.LoadoutDBID, false);
													if (aircraft3.GetAircraftAirOps().GetConditionTimer() <= (float)loadout.ReadyTime && (aircraft3.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Parked || aircraft3.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Readying) && Operators.CompareString(aircraft3.GetAircraftAirOps().RearmAircraft(ref aircraft3, emptySlot.LoadoutDBID, aircraft3.GetLoadoutDBID(), false, emptySlot.Loadout_ExcludeOptionalWeapons, true, false, false), "OK", false) == 0)
													{
														aircraft3.GetAircraftNavigator().SetFlight(emptySlot.GetFlight(scenario_));
														aircraft3.FlightRole = emptySlot.MissionFlight_Role;
														this.EmptySlotsList.Remove(emptySlot);
														aircraft3.DeleteMission(false, this);
														aircraft3.m_Doctrine.Init();
														list.Remove(aircraft3);
														break;
													}
												}
											}
										}
									}
									list = mission.GetUnitsAssignedToMyTaskPool(scenario_).Where(Mission.UnassignedAndInActiveUnitFilter).ToList<ActiveUnit>();
									if (list.Count != 0 && this.EmptySlotsList.Count != 0)
									{
										for (int l = this.EmptySlotsList.Count - 1; l >= 0; l += -1)
										{
											Mission.EmptySlot emptySlot = this.EmptySlotsList[l];
											foreach (ActiveUnit current5 in list)
											{
												if (current5.DBID == emptySlot.aircraftDBID)
												{
													Aircraft aircraft4 = (Aircraft)current5;
													if (!Information.IsNothing(aircraft4.GetAircraftAirOps().GetCurrentHostUnit()) && Operators.CompareString(aircraft4.GetAircraftAirOps().GetCurrentHostUnit().GetGuid(), emptySlot.CurrentHostUnit_ObjectID, false) == 0 && aircraft4.GetLoadout().loadoutRole != Loadout.LoadoutRole.Unavailable)
													{
														Loadout loadout2 = new Loadout(emptySlot.LoadoutDBID, "tempLoadout", 1, 1, 1, 1, Loadout.LoadoutRole.None, Loadout._LoadoutDayNight.DayOnly, Loadout._WeatherProfile.None, 0f, 0, 0, false, false, false, 0, 0, 0, 0, Loadout._LoadoutDayNight.DayNight, Doctrine._WeaponState.LoadoutSetting);
														DBFunctions.smethod_49(ref scenario_, ref loadout2, emptySlot.LoadoutDBID, false);
														if (aircraft4.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Parked)
														{
															goto IL_793;
														}
														if (aircraft4.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Readying)
														{
															goto IL_793;
														}
														bool arg_7CB_0 = true;
														IL_7CB:
														if (arg_7CB_0)
														{
															continue;
														}
														aircraft4.GetAircraftNavigator().SetFlight(emptySlot.GetFlight(scenario_));
														aircraft4.FlightRole = emptySlot.MissionFlight_Role;
														this.EmptySlotsList.Remove(emptySlot);
														aircraft4.DeleteMission(false, this);
														aircraft4.m_Doctrine.Init();
														list.Remove(aircraft4);
														break;
														IL_793:
														arg_7CB_0 = (Operators.CompareString(aircraft4.GetAircraftAirOps().RearmAircraft(ref aircraft4, emptySlot.LoadoutDBID, aircraft4.GetLoadoutDBID(), false, emptySlot.Loadout_ExcludeOptionalWeapons, true, false, false), "OK", false) != 0);
														goto IL_7CB;
													}
												}
											}
										}
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
				ex2.Data.Add("Error at 200644", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x0022A150 File Offset: 0x00228350
		public Dictionary<string, Dictionary<string, Dictionary<string, int>>> method_22(ref Scenario scenario_0, bool bool_15, bool bool_16)
		{
			Dictionary<string, Dictionary<string, Dictionary<string, int>>> result;
			try
			{
				Dictionary<string, Dictionary<string, Dictionary<string, int>>> dictionary = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
				Dictionary<string, Dictionary<string, string>> dictionary2 = new Dictionary<string, Dictionary<string, string>>();
				int num = scenario_0.GetActiveUnitList().Count - 1;
				for (int i = 0; i <= num; i++)
				{
					ActiveUnit activeUnit = scenario_0.GetActiveUnitList()[i];
					if (!activeUnit.IsGroup && activeUnit.GetAssignedMission(false) == this && activeUnit.IsAircraft && (!bool_15 || activeUnit.GetAI().IsEscort) && (!bool_16 || activeUnit.GetAI().IsEscort) && (bool_15 || bool_16 || !activeUnit.GetAI().IsEscort) && (!bool_15 || bool_16 || this.MissionClass != Mission._MissionClass.Strike || ((Strike)this).Escort_FlightSize_NonShooter == Mission._FlightSize.None))
					{
						Aircraft aircraft = (Aircraft)activeUnit;
						Aircraft_AirOps aircraftAirOps = aircraft.GetAircraftAirOps();
						if (!Information.IsNothing(aircraft.GetLoadout()))
						{
                            //ZSP if (!Information.IsNothing(aircraftAirOps.GetCurrentHostUnit()))
                            if (!Information.IsNothing(aircraftAirOps.GetAssignedHostUnit()))
                            {
								Dictionary<string, int> dictionary3 = null;
								Dictionary<string, Dictionary<string, int>> dictionary4 = null;
                                //ZSP if (!dictionary.ContainsKey(aircraftAirOps.GetCurrentHostUnit().Name))
                                if (!dictionary.ContainsKey(aircraftAirOps.GetAssignedHostUnit().Name))
                                {
                                    //ZSP dictionary.Add(aircraftAirOps.GetCurrentHostUnit().Name, null);
                                    dictionary.Add(aircraftAirOps.GetAssignedHostUnit().Name, null);
                                }
                                //ZSP dictionary.TryGetValue(aircraftAirOps.GetCurrentHostUnit().Name, out dictionary4);
                                dictionary.TryGetValue(aircraftAirOps.GetAssignedHostUnit().Name, out dictionary4);
                                if (Information.IsNothing(dictionary4))
								{
									dictionary4 = new Dictionary<string, Dictionary<string, int>>();
									dictionary4.Add(aircraft.UnitClass, null);
                                    //ZSP dictionary[aircraftAirOps.GetCurrentHostUnit().Name] = dictionary4;
                                    dictionary[aircraftAirOps.GetAssignedHostUnit().Name] = dictionary4;
                                }
								dictionary4.TryGetValue(aircraft.UnitClass, out dictionary3);
								if (Information.IsNothing(dictionary3))
								{
									dictionary3 = new Dictionary<string, int>();
									dictionary3.Add(aircraft.GetLoadout().Name, 1);
									dictionary4[aircraft.UnitClass] = dictionary3;
								}
								else
								{
									int num2 = 0;
									dictionary3.TryGetValue(aircraft.GetLoadout().Name, out num2);
									if (num2 == 0)
									{
										dictionary3.Add(aircraft.GetLoadout().Name, 1);
									}
									else
									{
										Dictionary<string, int> dictionary5;
										string key;
										(dictionary5 = dictionary3)[key = aircraft.GetLoadout().Name] = dictionary5[key] + 1;
									}
								}
							}
							else if (!Information.IsNothing(aircraftAirOps.GetAssignedHostUnit(false)))
							{
								Dictionary<string, string> dictionary6 = null;
								if (!dictionary2.ContainsKey(aircraftAirOps.GetAssignedHostUnit(false).Name))
								{
									dictionary2.Add(aircraftAirOps.GetAssignedHostUnit(false).Name, null);
								}
								dictionary2.TryGetValue(aircraftAirOps.GetAssignedHostUnit(false).Name, out dictionary6);
								if (Information.IsNothing(dictionary6))
								{
									dictionary6 = new Dictionary<string, string>();
									dictionary6.Add(aircraft.UnitClass, aircraft.GetLoadout().Name);
									dictionary2[aircraftAirOps.GetAssignedHostUnit(false).Name] = dictionary6;
								}
								else
								{
									string expression;
									dictionary6.TryGetValue(aircraft.UnitClass, out expression);
									if (Information.IsNothing(expression))
									{
										dictionary6.Add(aircraft.UnitClass, aircraft.GetLoadout().Name);
									}
								}
							}
						}
					}
				}
				if (!Information.IsNothing(this.EmptySlotsList))
				{
					int num3 = this.EmptySlotsList.Count - 1;
					for (int j = 0; j <= num3; j++)
					{
						Mission.EmptySlot emptySlot = this.EmptySlotsList[j];
						if ((!bool_15 || emptySlot.IsEscort) && (!bool_16 || emptySlot.IsEscort) && (bool_15 || bool_16 || !emptySlot.IsEscort) && (!bool_15 || bool_16 || this.MissionClass != Mission._MissionClass.Strike || ((Strike)this).Escort_FlightSize_NonShooter == Mission._FlightSize.None))
						{
							Dictionary<string, int> dictionary7 = null;
							Dictionary<string, Dictionary<string, int>> dictionary8 = null;
							if (!dictionary.ContainsKey(emptySlot.CurrentHostUnit_Name))
							{
								dictionary.Add(emptySlot.CurrentHostUnit_Name, null);
							}
							dictionary.TryGetValue(emptySlot.CurrentHostUnit_Name, out dictionary8);
							if (Information.IsNothing(dictionary8))
							{
								dictionary8 = new Dictionary<string, Dictionary<string, int>>();
								dictionary8.Add(emptySlot.UnitClass, null);
								dictionary[emptySlot.CurrentHostUnit_Name] = dictionary8;
							}
							dictionary8.TryGetValue(emptySlot.UnitClass, out dictionary7);
							if (Information.IsNothing(dictionary7))
							{
								dictionary7 = new Dictionary<string, int>();
								dictionary7.Add(emptySlot.LoadoutName, 1);
								dictionary8[emptySlot.UnitClass] = dictionary7;
							}
							else
							{
								int num4 = 0;
								dictionary7.TryGetValue(emptySlot.LoadoutName, out num4);
								if (num4 == 0)
								{
									dictionary7.Add(emptySlot.LoadoutName, 1);
								}
								else
								{
									Dictionary<string, int> dictionary5;
									string key;
									(dictionary5 = dictionary7)[key = emptySlot.LoadoutName] = dictionary5[key] + 1;
								}
							}
						}
					}
				}
				foreach (KeyValuePair<string, Dictionary<string, string>> current in dictionary2)
				{
					Dictionary<string, string> value = current.Value;
					foreach (KeyValuePair<string, string> current2 in value)
					{
						string value2 = current2.Value;
						List<string> list = new List<string>();
						foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, int>>> current3 in dictionary)
						{
							List<string> list2 = new List<string>();
							Dictionary<string, Dictionary<string, int>> value3 = current3.Value;
							foreach (KeyValuePair<string, Dictionary<string, int>> current4 in value3)
							{
								List<string> list3 = new List<string>();
								Dictionary<string, int> value4 = current4.Value;
								foreach (KeyValuePair<string, int> current5 in value4)
								{
									if (Operators.CompareString(current5.Key, value2, false) == 0)
									{
										list3.Add(value2);
									}
								}
								foreach (string current6 in list3)
								{
									value4.Remove(current6);
								}
								if (current4.Value.Count == 0)
								{
									list2.Add(current4.Key);
								}
							}
							foreach (string current7 in list2)
							{
								value3.Remove(current7);
							}
							if (current3.Value.Count == 0)
							{
								list.Add(current3.Key);
							}
						}
						foreach (string current8 in list)
						{
							dictionary.Remove(current8);
						}
					}
				}
				result = dictionary;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101251", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005424 RID: 21540 RVA: 0x0022A954 File Offset: 0x00228B54
		public DateTime? GetStartTime()
		{
			return this.START;
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x0022A96C File Offset: 0x00228B6C
		public void SetStartTime(DateTime? nullable_4)
		{
			bool flag = false;
			if (Information.IsNothing(this.START) && !Information.IsNothing(nullable_4))
			{
				flag = true;
			}
			else if (Information.IsNothing(nullable_4) && !Information.IsNothing(this.START))
			{
				flag = true;
			}
			else
			{
				DateTime? sTART = this.START;
				bool? flag2 = (sTART.HasValue & nullable_4.HasValue) ? new bool?(DateTime.Compare(sTART.GetValueOrDefault(), nullable_4.GetValueOrDefault()) == 0) : null;
				if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
				{
					flag = true;
				}
			}
			this.START = nullable_4;
			if (flag)
			{
				Mission.Delegate16 @delegate = Mission.delegate16_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x0022AA58 File Offset: 0x00228C58
		public DateTime? GetEndTime()
		{
			return this.END;
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x0022AA70 File Offset: 0x00228C70
		public void SetEndTime(DateTime? value)
		{
			bool flag = false;
			if (Information.IsNothing(this.END) && !Information.IsNothing(value))
			{
				flag = true;
			}
			else if (Information.IsNothing(value) && !Information.IsNothing(this.END))
			{
				flag = true;
			}
			else
			{
				DateTime? eND = this.END;
				bool? flag2 = (eND.HasValue & value.HasValue) ? new bool?(DateTime.Compare(eND.GetValueOrDefault(), value.GetValueOrDefault()) == 0) : null;
				if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
				{
					flag = true;
				}
			}
			this.END = value;
			if (flag)
			{
				Mission.Delegate17 @delegate = Mission.delegate17_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
		}

		// 取起飞时间
		public DateTime? GetTakeOffTime()
		{
			return this.TakeOffTime;
		}

		// 设置起飞时间
		public void SetTakeOffTime(DateTime? value)
		{
			bool flag = false;
			if (Information.IsNothing(this.TakeOffTime) && !Information.IsNothing(value))
			{
				flag = true;
			}
			else if (Information.IsNothing(value) && !Information.IsNothing(this.TakeOffTime))
			{
				flag = true;
			}
			else
			{
				DateTime? takeOffTime = this.TakeOffTime;
				bool? flag2 = (takeOffTime.HasValue & value.HasValue) ? new bool?(DateTime.Compare(takeOffTime.GetValueOrDefault(), value.GetValueOrDefault()) == 0) : null;
				if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
				{
					flag = true;
				}
			}
			this.TakeOffTime = value;
			if (flag)
			{
				Mission.Delegate18 @delegate = Mission.delegate18_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x0022AC60 File Offset: 0x00228E60
		public DateTime? GetTimeOnTarget()
		{
			return this.TimeOnTarget;
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x0022AC78 File Offset: 0x00228E78
		public void SetTimeOnTarget(DateTime? value)
		{
			bool flag = false;
			if (Information.IsNothing(this.TimeOnTarget) && !Information.IsNothing(value))
			{
				flag = true;
			}
			else if (Information.IsNothing(value) && !Information.IsNothing(this.TimeOnTarget))
			{
				flag = true;
			}
			else
			{
				DateTime? timeOnTarget = this.TimeOnTarget;
				bool? flag2 = (timeOnTarget.HasValue & value.HasValue) ? new bool?(DateTime.Compare(timeOnTarget.GetValueOrDefault(), value.GetValueOrDefault()) == 0) : null;
				if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
				{
					flag = true;
				}
			}
			this.TimeOnTarget = value;
			if (flag)
			{
				Mission.Delegate19 @delegate = Mission.delegate19_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
		}

		// Token: 0x0600542C RID: 21548 RVA: 0x0022AD64 File Offset: 0x00228F64
		public int? GetFlightQty(ref Mission._FlightSize _FlightSize_1, ref Mission._FlightQty _FlightQty_0)
		{
			int? result = null;
			switch (_FlightQty_0)
			{
			case Mission._FlightQty.Flight_x1:
				result = new int?((int)_FlightSize_1);
				break;
			case Mission._FlightQty.Flight_x2:
				result = new int?((int)(((int)_FlightSize_1) * ((int)Mission._FlightSize.TwoAircraft)));
				break;
			case Mission._FlightQty.Flight_x3:
				result = new int?((int)(((int)_FlightSize_1) * (int)Mission._FlightSize.ThreeAircraft));
				break;
			case Mission._FlightQty.Flight_x4:
				result = new int?((int)(((int)_FlightSize_1) * (int)Mission._FlightSize.FourAircraft));
				break;
			case Mission._FlightQty.Flight_x6:
				result = new int?((int)(((int)_FlightSize_1) * (int)Mission._FlightSize.SixAircraft));
				break;
			case Mission._FlightQty.Flight_x8:
				result = new int?((int)(((int)_FlightSize_1) * (int)(Mission._FlightSize)8));
				break;
			case Mission._FlightQty.Flight_x12:
				result = new int?((int)(((int)_FlightSize_1) * (int)(Mission._FlightSize)12));
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600542D RID: 21549 RVA: 0x0022AE08 File Offset: 0x00229008
		public int method_32(ref object object_0, bool bool_15)
		{
			int result = 0;
			try
			{
				if (!bool_15)
				{
					switch (Conversions.ToInteger(object_0))
					{
					case 0:
						result = (int)_FlightQty.All;
						break;
					case 1:
						result = 0;
						break;
					case 2:
						result = (int)_FlightQty.Flight_x1;
						break;
					case 3:
						result = (int)_FlightQty.Flight_x2;
						break;
					case 4:
						result = (int)_FlightQty.Flight_x3;
						break;
					case 5:
						result = (int)_FlightQty.Flight_x4;
						break;
					case 6:
						result = (int)_FlightQty.Flight_x6;
						break;
					case 7:
						result = (int)_FlightQty.Flight_x8;
						break;
					case 8:
						result = (int)_FlightQty.Flight_x12;
						break;
					default:
						result = 0;
						break;
					}
				}
				else
				{
					int num = Conversions.ToInteger(object_0);
					if (num != 0)
					{
						if (num != 1)
						{
							result = 0;
						}
						else
						{
							result = 0;
						}
					}
					else
					{
						result = (int)_FlightQty.All;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101242", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = (int)_FlightQty.All;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x0022AEF4 File Offset: 0x002290F4
		public int method_33(int int_7, bool bool_15)
		{
			int num = 0;
			int result;
			try
			{
				if (!bool_15)
				{
					switch (int_7)
					{
					case (int)_FlightQty.All:
						num = 0;
						result = 0;
						return result;
					case -98:
						break;
					case (int)_FlightQty.Flight_x1:
						num = 2;
						result = 2;
						return result;
					case (int)_FlightQty.Flight_x2:
						num = 3;
						result = 3;
						return result;
					case (int)_FlightQty.Flight_x3:
						num = 4;
						result = 4;
						return result;
					case (int)_FlightQty.Flight_x4:
						num = 5;
						result = 5;
						return result;
					case (int)_FlightQty.Flight_x6:
						num = 6;
						result = 6;
						return result;
					case (int)_FlightQty.Flight_x8:
						num = 7;
						result = 7;
						return result;
					case (int)_FlightQty.Flight_x12:
						num = 8;
						result = 8;
						return result;
					default:
						if (int_7 == 0)
						{
							num = 1;
							result = 1;
							return result;
						}
						break;
					}
					num = 1;
				}
				else if (int_7 != (int)_FlightQty.All)
				{
					if (int_7 != 0)
					{
						num = 1;
					}
					else
					{
						num = 1;
					}
				}
				else
				{
					num = 0;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101243", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num = 0;
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x0022AFEC File Offset: 0x002291EC
		public int method_34(ref object object_0, bool bool_15)
		{
			int result = 0;
			try
			{
				if (!bool_15)
				{
					switch (Conversions.ToInteger(object_0))
					{
					case 0:
						result = 0;
						break;
					case 1:
						result = (int)_FlightQty.Flight_x1;
						break;
					case 2:
						result = (int)_FlightQty.Flight_x2;
						break;
					case 3:
						result = (int)_FlightQty.Flight_x3;
						break;
					case 4:
						result = (int)_FlightQty.Flight_x4;
						break;
					case 5:
						result = (int)_FlightQty.Flight_x6;
						break;
					case 6:
						result = (int)_FlightQty.Flight_x8;
						break;
					case 7:
						result = (int)_FlightQty.Flight_x12;
						break;
					default:
						result = 0;
						break;
					}
				}
				else
				{
					switch (Conversions.ToInteger(object_0))
					{
					case 0:
						result = 0;
						break;
					case 1:
						result = -87;
						break;
					case 2:
						result = -86;
						break;
					case 3:
						result = -85;
						break;
					case 4:
						result = -84;
						break;
					case 5:
						result = -83;
						break;
					case 6:
						result = -82;
						break;
					case 7:
						result = -81;
						break;
					default:
						result = 0;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101245", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x0022B104 File Offset: 0x00229304
		public int method_35(int int_7, bool bool_15)
		{
			int result = 0;
			try
			{
				if (!bool_15)
				{
					switch (int_7)
					{
					case (int)_FlightQty.Flight_x1:
						result = 1;
						break;
					case (int)_FlightQty.Flight_x2:
						result = 2;
						break;
					case (int)_FlightQty.Flight_x3:
						result = 3;
						break;
					case (int)_FlightQty.Flight_x4:
						result = 4;
						break;
					case (int)_FlightQty.Flight_x6:
						result = 5;
						break;
					case (int)_FlightQty.Flight_x8:
						result = 6;
						break;
					case (int)_FlightQty.Flight_x12:
						result = 7;
						break;
					default:
						result = 0;
						break;
					}
				}
				else
				{
					switch (int_7)
					{
					case -87:
						result = 1;
						break;
					case -86:
						result = 2;
						break;
					case -85:
						result = 3;
						break;
					case -84:
						result = 4;
						break;
					case -83:
						result = 5;
						break;
					case -82:
						result = 6;
						break;
					case -81:
						result = 7;
						break;
					default:
						result = 0;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101244", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x0022B1F8 File Offset: 0x002293F8
		public void PreparingToLaunch(List<Group> list_5, List<Aircraft> list_6, List<Aircraft> list_7, List<Aircraft> list_8)
		{
			if (!Information.IsNothing(list_5))
			{
				foreach (Group current in list_5)
				{
					if (current.GetUnitsInGroup().Values.Count == 1)
					{
						ActiveUnit activeUnit = current.GetUnitsInGroup().Values.ElementAtOrDefault(0);
						Mission.Flight flight = activeUnit.GetNavigator().GetFlight();
						current.GetUnitsInGroup().Values.ElementAtOrDefault(0).SetParentGroup(true, null);
						current.DestroyUnit(false, false, true);
						activeUnit.GetNavigator().SetFlight(flight);
					}
				}
			}
			if (!Information.IsNothing(list_7))
			{
				using (List<Aircraft>.Enumerator enumerator2 = list_7.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Aircraft_AirOps aircraftAirOps = enumerator2.Current.GetAircraftAirOps();
						if (aircraftAirOps.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Parked)
						{
							aircraftAirOps.PreparingToLaunch();
						}
					}
				}
			}
			if (!Information.IsNothing(list_8))
			{
				using (List<Aircraft>.Enumerator enumerator3 = list_8.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						Aircraft_AirOps aircraftAirOps2 = enumerator3.Current.GetAircraftAirOps();
						if (aircraftAirOps2.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Parked)
						{
							aircraftAirOps2.PreparingToLaunch();
						}
					}
				}
			}
			if (!Information.IsNothing(list_6))
			{
				using (List<Aircraft>.Enumerator enumerator4 = list_6.GetEnumerator())
				{
					while (enumerator4.MoveNext())
					{
						Aircraft_AirOps aircraftAirOps3 = enumerator4.Current.GetAircraftAirOps();
						if (aircraftAirOps3.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Parked)
						{
							aircraftAirOps3.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
							if (!aircraftAirOps3.method_67())
							{
								aircraftAirOps3.PreparingToLaunch();
							}
						}
					}
				}
				if (list_6.Count > 0 && this.MissionClass == Mission._MissionClass.Strike)
				{
					((Strike)this).OneTimeOnlyFlown = true;
				}
			}
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x0022B3F8 File Offset: 0x002295F8
		public virtual string GetTypeString(Scenario scenario_0)
		{
			return "";
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x0022B40C File Offset: 0x0022960C
		public Mission(Side side_0, Scenario scenario_0)
		{
			Collection<ActiveUnit> collection = null;
			this.m_Doctrine = new Doctrine(this, ref collection);
			this.category = Mission.MissionCategory.Mission;
			this.int_0 = 0;
			this.list_0 = new List<Mission.Flight>();
			this.FlightList = new List<Mission.Flight>();
			this.TankerMissionNameList = new List<string>();
			this.TankerMissionList = new List<Mission>();
			this.MaxReceiversInQueuePerTanker_Airborne = 0;
			this.TankerMaxDistance_Airborne = 2147483647;
			this.bTankerFollowsReceivers = true;
			this.Deactivation_UnassignUnits = false;
			this.CheckBox_OrderRTB = false;
			this.CheckBox_DeleteMission = false;
			this.IsMission = true;
			if (!Information.IsNothing(side_0))
			{
				side_0.AddMission(this);
			}
			collection = null;
			this.m_Doctrine = new Doctrine(this, ref collection);
			if (this.MissionClass == Mission._MissionClass.Strike)
			{
				this.FuelQtyToStartLookingForTanker_Airborne = 85;
			}
			else if (this.MissionClass == Mission._MissionClass.Ferry)
			{
				this.FuelQtyToStartLookingForTanker_Airborne = 80;
			}
			else if (this.MissionClass == Mission._MissionClass.Support)
			{
				this.FuelQtyToStartLookingForTanker_Airborne = 0;
			}
			else
			{
				this.FuelQtyToStartLookingForTanker_Airborne = 60;
			}
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x0022B528 File Offset: 0x00229728
		public static string GetFlightSizeString(Mission._FlightSize _FlightSize_1)
		{
			string text;
			string result;
			switch (_FlightSize_1)
			{
			case Mission._FlightSize.SingleAircraft:
				text = "单机";
				result = text;
				return result;
			case Mission._FlightSize.TwoAircraft:
				text = "2机编队, 常用于战斗机";
				result = text;
				return result;
			case Mission._FlightSize.ThreeAircraft:
				text = "3机编队, 常用于轰炸机";
				result = text;
				return result;
			case Mission._FlightSize.FourAircraft:
				text = "4机编队, 常用于攻击机";
				result = text;
				return result;
			case Mission._FlightSize.SixAircraft:
				text = "6机编队, 常用于中/重型攻击机";
				result = text;
				return result;
			}
			text = "None";
			result = text;
			return result;
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x0022B59C File Offset: 0x0022979C
		public static string GetShipGroupSizeString(Mission._GroupSize enum61_1)
		{
			string text;
			string result;
			switch (enum61_1)
			{
			case Mission._GroupSize.const_1:
				text = "单艇";
				result = text;
				return result;
			case Mission._GroupSize.const_2:
				text = "2x艇";
				result = text;
				return result;
			case Mission._GroupSize.const_3:
				text = "3x艇";
				result = text;
				return result;
			case Mission._GroupSize.const_4:
				text = "4x艇";
				result = text;
				return result;
			case Mission._GroupSize.const_5:
				text = "6x艇";
				result = text;
				return result;
			}
			text = "None";
			result = text;
			return result;
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x0022B610 File Offset: 0x00229810
		public static string GetTaskString(Mission._Task Task_)
		{
			string text;
			string result;
			switch (Task_)
			{
			case Mission._Task.Strike_Land:
				text = "对地攻击";
				result = text;
				return result;
			case Mission._Task.Strike_Maritime:
				text = "对海攻击";
				result = text;
				return result;
			case Mission._Task.Strike_OffensiveCounterAir:
				text = "进攻性制空攻击";
				result = text;
				return result;
			case Mission._Task.Strike_SEAD:
				text = "压制敌防空攻击";
				result = text;
				return result;
			case Mission._Task.FighterSweep_CounterAir:
				text = "制空战斗扫荡";
				result = text;
				return result;
			case Mission._Task.SEADSweep:
				text = "压制敌防空扫荡";
				result = text;
				return result;
			case Mission._Task.BattlefieldAirInterdiction:
				text = "战场空中截击";
				result = text;
				return result;
			case Mission._Task.CloseAirSupport:
				text = "近距空中支援";
				result = text;
				return result;
			case Mission._Task.CombatAirPatrol:
				text = "战斗空中巡逻";
				result = text;
				return result;
			case Mission._Task.TargetCombatAirPatrol:
				text = "目标战斗空中巡逻";
				result = text;
				return result;
			case Mission._Task.BarrierCombatAirPatrol:
				text = "空中阻拦战斗巡逻";
				result = text;
				return result;
			case Mission._Task.GroundLaunchedIntercept:
				text = "地基拦截";
				result = text;
				return result;
			case Mission._Task.DeckLaunchedIntercept:
				text = "舰基拦截";
				result = text;
				return result;
			case Mission._Task.Escort_FighterSweep:
				text = "护航,战斗扫荡";
				result = text;
				return result;
			case Mission._Task.Escort_TARCAP:
				text = "护航, 目标战斗空中巡逻";
				result = text;
				return result;
			case Mission._Task.Escort_SEADSweep:
				text = "护航, 压制敌防空扫荡";
				result = text;
				return result;
			case Mission._Task.AntiSatellite:
				text = "反卫作战";
				result = text;
				return result;
			case Mission._Task.AirborneLaser:
				text = "空基激光器";
				result = text;
				return result;
			case Mission._Task.BuddyIllumination:
				text = "协同支援照射";
				result = text;
				return result;
			case Mission._Task.OffensiveECM:
				text = "电子干扰";
				result = text;
				return result;
			case Mission._Task.AirborneEarlyWarning:
				text = "空中预警";
				result = text;
				return result;
			case Mission._Task.AirborneCommandPost:
				text = "空中指挥";
				result = text;
				return result;
			case Mission._Task.ChaffLaying:
				text = "布撒箔条";
				result = text;
				return result;
			case Mission._Task.SearchAndRescue:
				text = "搜救";
				result = text;
				return result;
			case Mission._Task.CombatSearchAndRescue:
				text = "战斗搜救";
				result = text;
				return result;
			case Mission._Task.MineSweeping:
				text = "扫雷";
				result = text;
				return result;
			case Mission._Task.MineRecon:
				text = "探雷";
				result = text;
				return result;
			case Mission._Task.NavalMineLaying:
				text = "海上布雷";
				result = text;
				return result;
			case Mission._Task.ASW:
				text = "反潜作战";
				result = text;
				return result;
			case Mission._Task.ForwardAirController:
				text = "前进空中领航";
				result = text;
				return result;
			case Mission._Task.Surveillance:
				text = "侦察";
				result = text;
				return result;
			case Mission._Task.ArmedRecon:
				text = "武装监视";
				result = text;
				return result;
			case Mission._Task.UnarmedRecon:
				text = "无人监视";
				result = text;
				return result;
			case Mission._Task.MaritimeSurveillance:
				text = "海上侦察";
				result = text;
				return result;
			case Mission._Task.ParaDrop:
				text = "空投";
				result = text;
				return result;
			case Mission._Task.TroopTransport:
				text = "运兵";
				result = text;
				return result;
			case Mission._Task.Cargo:
				text = "货物";
				result = text;
				return result;
			case Mission._Task.AirRefuelling:
				text = "空中加油";
				result = text;
				return result;
			case Mission._Task.Training:
				text = "训练";
				result = text;
				return result;
			case Mission._Task.TargetTow:
				text = "拖靶";
				result = text;
				return result;
			case Mission._Task.TargetDrone:
				text = "靶机";
				result = text;
				return result;
			case Mission._Task.Ferry:
				text = "转场";
				result = text;
				return result;
			case Mission._Task.HighValueAssetCombatAirPatrol:
				text = "高价值目标战斗空中巡逻";
				result = text;
				return result;
			case Mission._Task.RescueCombatAirPatrol:
				text = "救援战斗空中巡逻";
				result = text;
				return result;
			case Mission._Task.Strike_Interdiction:
				text = "打击, 对后勤补给截击";
				result = text;
				return result;
			case Mission._Task.Support:
				text = "保障";
				result = text;
				return result;
			case Mission._Task.Escort_Support:
				text = "护航, 保障";
				result = text;
				return result;
			}
			text = "未分配任务";
			result = text;
			return result;
		}

		// Token: 0x06005437 RID: 21559 RVA: 0x0022B93C File Offset: 0x00229B3C
		public static string GetMandatoryPriority(Mission._Priority Priority_)
		{
			string result;
			if (Priority_ == Mission._Priority.Mandatory)
			{
				result = "Mandatory";
			}
			else
			{
				result = "None";
			}
			return result;
		}

		// Token: 0x06005438 RID: 21560 RVA: 0x0022B96C File Offset: 0x00229B6C
		public virtual void vmethod_6(ref Scenario scenario_0, Side side_0, bool bool_15)
		{
			checked
			{
				if (this.TankerMissionNameList.Count > 0)
				{
					Side[] sides = scenario_0.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						foreach (Mission current in side.GetMissionCollection())
						{
							if (this.TankerMissionNameList.Contains(current.GetGuid()))
							{
								this.TankerMissionList.Add(current);
							}
						}
					}
				}
				if (this.HasFlights())
				{
					foreach (Mission.Flight current2 in this.FlightList)
					{
						if (scenario_0.GetActiveUnits().ContainsKey(current2.ReferenceUnit_ObjectID))
						{
							current2.SetReferenceUnit(null, scenario_0.GetActiveUnits()[current2.ReferenceUnit_ObjectID]);
						}
						Side[] sides2 = scenario_0.GetSides();
						for (int j = 0; j < sides2.Length; j++)
						{
							Side side2 = sides2[j];
							foreach (Mission current3 in side2.GetMissionCollection())
							{
								if (current2.TaskPool_ID.Contains(current3.GetGuid()))
								{
									current2.TaskPool = current3;
								}
								if (current2.PostTaskPool_ID.Contains(current3.GetGuid()))
								{
									current2.PostTaskPool = current3;
								}
							}
						}
						Side[] sides3 = scenario_0.GetSides();
						for (int k = 0; k < sides3.Length; k++)
						{
							Side side3 = sides3[k];
							if (side3.GetContactObservableDictionary().ContainsKey(current2.PrimaryTarget_ID))
							{
								current2.PrimaryTarget = side3.GetContactObservableDictionary()[current2.PrimaryTarget_ID];
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005439 RID: 21561 RVA: 0x00026DEC File Offset: 0x00024FEC
		public bool HasFlights()
		{
			return !Information.IsNothing(this.FlightList) && this.FlightList.Count != 0;
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x0022BBB8 File Offset: 0x00229DB8
		public bool HasFlightCourse()
		{
			bool flag;
			bool result;
			if (!this.HasFlights())
			{
				flag = false;
			}
			else
			{
				foreach (Mission.Flight current in this.FlightList)
				{
					if (!Information.IsNothing(current.GetFlightCourse()) && current.GetFlightCourse().Count<Waypoint>() > 0)
					{
						result = true;
						return result;
					}
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x0022BC40 File Offset: 0x00229E40
		public void UnassignFlightRemove(Scenario scenario_0, Side side_0)
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			ActiveUnit[] activeUnitArray = side_0.ActiveUnitArray;
			checked
			{
				for (int i = 0; i < activeUnitArray.Length; i++)
				{
					ActiveUnit activeUnit = activeUnitArray[i];
					if (!activeUnit.HasParentGroup() && (!activeUnit.IsWeapon || ((Weapon)activeUnit).GetWeaponType() != Weapon._WeaponType.Sonobuoy) && activeUnit.GetAssignedMission(false) == this && activeUnit.IsAircraft && !Information.IsNothing(activeUnit.GetNavigator().GetFlight()))
					{
						list.Add(activeUnit);
					}
				}
				bool flag = false;
				List<Mission.Flight> list2 = new List<Mission.Flight>();
				foreach (Mission.Flight current in this.FlightList)
				{
					flag = false;
					foreach (ActiveUnit current2 in list)
					{
						if (current2.GetNavigator().GetFlight() == current)
						{
							flag = true;
							list.Remove(current2);
							break;
						}
					}
					if (!flag)
					{
						if (!Information.IsNothing(this.EmptySlotsList))
						{
							foreach (Mission.EmptySlot current3 in this.EmptySlotsList)
							{
								if (!Information.IsNothing(current3.GetFlight(scenario_0)) && current3.GetFlight(scenario_0) == current)
								{
									flag = true;
									break;
								}
							}
						}
						if (!flag)
						{
							list2.Add(current);
						}
					}
				}
				foreach (Mission.Flight current4 in list2)
				{
					this.FlightListRemove(current4);
				}
			}
		}

		// Token: 0x0600543C RID: 21564 RVA: 0x0022BE34 File Offset: 0x0022A034
		public void method_40(ref Scenario scenario_0, ref Side side_0, ref Mission.Flight Flight_, string string_3)
		{
			if (!Information.IsNothing(Flight_))
			{
				ActiveUnit[] activeUnitArray = side_0.ActiveUnitArray;
				checked
				{
					for (int i = 0; i < activeUnitArray.Length; i++)
					{
						ActiveUnit activeUnit = activeUnitArray[i];
						if (activeUnit.GetNavigator().HasFlight() && Operators.CompareString(activeUnit.GetNavigator().GetFlight().GetGuid(), string_3, false) == 0)
						{
							activeUnit.GetNavigator().vmethod_3();
						}
					}
					if (!Information.IsNothing(this.EmptySlotsList) && this.EmptySlotsList.Count > 0)
					{
						foreach (Mission.EmptySlot current in this.EmptySlotsList)
						{
							if (current.GetFlight(scenario_0) == Flight_)
							{
								current.SetFlight(scenario_0, null);
							}
						}
					}
				}
				for (int j = scenario_0.MissionPlannerErrorList.Count - 1; j >= 0; j += -1)
				{
					string text = scenario_0.MissionPlannerErrorList[j];
					if (text.Contains(Flight_.Callsign))
					{
						scenario_0.MissionPlannerErrorList.Remove(text);
					}
				}
				this.FlightListRemove(Flight_);
			}
		}

		// Token: 0x0600543D RID: 21565 RVA: 0x00026E0F File Offset: 0x0002500F
		public void FlightListRemove(Mission.Flight Flight_)
		{
			this.FlightList.Remove(Flight_);
			Flight_ = null;
		}

		// Token: 0x0600543E RID: 21566 RVA: 0x0022BF80 File Offset: 0x0022A180
		public void RemoveThisMission(ref Scenario scenario_0, ref Side side_0)
		{
			ActiveUnit[] activeUnitArray = side_0.ActiveUnitArray;
			checked
			{
				for (int i = 0; i < activeUnitArray.Length; i++)
				{
					ActiveUnit activeUnit = activeUnitArray[i];
					if (activeUnit.GetAssignedMission(false) == this)
					{
						activeUnit.DeleteMission(false, null);
					}
				}
				if (this.category == Mission.MissionCategory.TaskPool)
				{
					TaskPool taskPool = (TaskPool)this;
					foreach (Mission arg_5F_0 in taskPool.Packages)
					{
						this.RemoveThisMission(ref scenario_0, ref side_0);
					}
				}
				this.method_43(ref scenario_0, ref side_0);
				side_0.RemoveMission(this);
			}
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x0022C030 File Offset: 0x0022A230
		public void method_43(ref Scenario scenario_0, ref Side side_0)
		{
			for (int i = this.FlightList.Count - 1; i >= 0; i += -1)
			{
				Mission.Flight flight = this.FlightList[i];
				this.method_40(ref scenario_0, ref side_0, ref flight, flight.GetGuid());
			}
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x0022C078 File Offset: 0x0022A278
		public void SetTakeOffOrTOTTime(ref Scenario scenario_0, ref Side side_0)
		{
			try
			{
				if (this.category == Mission.MissionCategory.Package)
				{
					if (Information.IsNothing(this.GetTakeOffTime()) && Information.IsNothing(this.GetTimeOnTarget()) && Interaction.MsgBox(this.Name + ": No Take-Off Time or Time-On-Target (TOT) Time has been set for this package. Do you want to create flights without waypoint times? If not, press 'No' and enter times before trying again.", MsgBoxStyle.YesNo, "No times set!") == MsgBoxResult.No)
					{
						return;
					}
					if (!Information.IsNothing(this.GetTakeOffTime()))
					{
						DateTime? dateTime = this.GetTakeOffTime();
						DateTime currentTime = scenario_0.GetCurrentTime(false);
						if ((dateTime.HasValue ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), currentTime) < 0) : null).GetValueOrDefault())
						{
							Interaction.MsgBox(this.Name + ": The package's Take-Off Time is earlier than the current scenario time. Please correct the time and try again.", MsgBoxStyle.OkOnly, "Time error!");
							return;
						}
					}
					if (!Information.IsNothing(this.GetTimeOnTarget()))
					{
						DateTime? dateTime = this.GetTimeOnTarget();
						DateTime currentTime = scenario_0.GetCurrentTime(false);
						if ((dateTime.HasValue ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), currentTime) <= 0) : null).GetValueOrDefault())
						{
							Interaction.MsgBox(this.Name + ": The package's Time-On-Target Time is earlier than the current scenario time. Please correct the time and try again.", MsgBoxStyle.OkOnly, "Time error!");
							return;
						}
					}
				}
				if (!Information.IsNothing(this.list_0))
				{
					this.list_0.Clear();
				}
				this.int_0 = 1;
				Mission mission = this;
				GameGeneral.smethod_24(ref scenario_0, ref side_0, ref mission, true, false, false);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101382", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x0022C264 File Offset: 0x0022A464
		public Aircraft GetReferenceUnit(ref Scenario scenario_, ref Side side_, int ReferenceUnit_DBID, int LoadoutDBID_, ref ActiveUnit TakeOffLocation_HostUnit, ref Mission.Flight Flight_, bool bIsEscort, int int_9)
		{
			Aircraft aircraft = new Aircraft(ref scenario_, null);
			DBFunctions.smethod_19(ref scenario_, ref aircraft, ReferenceUnit_DBID, true);
			aircraft.Name = string.Concat(new string[]
			{
				"Empty Slot ",
				Conversions.ToString(int_9),
				" (",
				aircraft.UnitClass,
				")"
			});
			aircraft.SetSide(false, side_);
			aircraft.GetAircraftAirOps().SetCurrentHostUnit(TakeOffLocation_HostUnit);
			aircraft.GetAircraftAI().IsEscort = bIsEscort;
			if (!Information.IsNothing(aircraft.GetAircraftAirOps().GetCurrentHostUnit()))
			{
				aircraft.SetLatitude(null, aircraft.GetAircraftAirOps().GetCurrentHostUnit().GetLatitude(null));
				aircraft.SetLongitude(null, aircraft.GetAircraftAirOps().GetCurrentHostUnit().GetLongitude(null));
			}
			Loadout loadout = DBFunctions.smethod_47(ref scenario_, LoadoutDBID_, false);
			aircraft.SetLoadout(loadout);
			aircraft.DeleteMission(true, this);
			aircraft.GetAircraftNavigator().SetFlight(Flight_);
			return aircraft;
		}

		// Token: 0x04002795 RID: 10133
		public static Func<ActiveUnit, bool> UnassignedAndInActiveUnitFilter = (ActiveUnit activeUnit_0) => Information.IsNothing(activeUnit_0.GetAssignedMission(false)) && !activeUnit_0.IsOperating();

		// Token: 0x04002796 RID: 10134
		public Doctrine m_Doctrine;

		// Token: 0x04002797 RID: 10135
		public Mission.MissionCategory category;

		// Token: 0x04002798 RID: 10136
		public Mission._MissionClass MissionClass;

		// Token: 0x04002799 RID: 10137
		protected DateTime? START;

		// Token: 0x0400279A RID: 10138
		protected DateTime? END;

		// Token: 0x0400279B RID: 10139
		protected DateTime? TakeOffTime;

		// Token: 0x0400279C RID: 10140
		protected DateTime? TimeOnTarget;

		// Token: 0x0400279D RID: 10141
        //是否由人扮演
		public bool SISIH;

		// Token: 0x0400279E RID: 10142
		private Mission._MissionStatus missionStatus;

		// Token: 0x0400279F RID: 10143
		public bool UseFlightSizeHardLimit;

		// Token: 0x040027A0 RID: 10144
		public bool UseGroupSizeHardLimit;

		// Token: 0x040027A1 RID: 10145
		public int int_0;

		// Token: 0x040027A2 RID: 10146
		public List<Mission.Flight> list_0;

		// Token: 0x040027A3 RID: 10147
		public List<Mission.Flight> FlightList;

		// Token: 0x040027A4 RID: 10148
		public Mission._FlightSize m_FlightSize;

		// Token: 0x040027A5 RID: 10149
		public Mission._GroupSize m_GroupSize;

		// Token: 0x040027A6 RID: 10150
		private string TaskPoolID = "";

		// Token: 0x040027A7 RID: 10151
		public List<Mission.EmptySlot> EmptySlotsList;

		// Token: 0x040027A8 RID: 10152
		public Mission.TankerMethod TankerUsage;

		// Token: 0x040027A9 RID: 10153
		public List<string> TankerMissionNameList;

		// Token: 0x040027AA RID: 10154
		public List<Mission> TankerMissionList;

		// Token: 0x040027AB RID: 10155
		public int TankerMinNumber_Total;

		// Token: 0x040027AC RID: 10156
		public int TankerMinNumber_Airborne = 0;

		// Token: 0x040027AD RID: 10157
		public int TankerMinNumber_Station = 0;

		// Token: 0x040027AE RID: 10158
		public bool LaunchMissionWithoutTankersInPlace;

		// Token: 0x040027AF RID: 10159
		public int MaxReceiversInQueuePerTanker_Airborne;

		// Token: 0x040027B0 RID: 10160
		public int FuelQtyToStartLookingForTanker_Airborne;

		// Token: 0x040027B1 RID: 10161
		public int TankerMaxDistance_Airborne;

		// Token: 0x040027B2 RID: 10162
		public bool bTankerFollowsReceivers;

		// Token: 0x040027B3 RID: 10163
		public bool Deactivation_UnassignUnits;

		// Token: 0x040027B4 RID: 10164
		public bool CheckBox_OrderRTB;

		// Token: 0x040027B5 RID: 10165
		public bool CheckBox_DeleteMission;

		// Token: 0x040027B6 RID: 10166
		[CompilerGenerated]
		private static Mission.Delegate16 delegate16_0;

		// Token: 0x040027B7 RID: 10167
		[CompilerGenerated]
		private static Mission.Delegate17 delegate17_0;

		// Token: 0x040027B8 RID: 10168
		[CompilerGenerated]
		private static Mission.Delegate18 delegate18_0;

		// Token: 0x040027B9 RID: 10169
		[CompilerGenerated]
		private static Mission.Delegate19 delegate19_0;

		// Token: 0x02000A55 RID: 2645
		public enum TankerMethod : byte
		{
			// Token: 0x040027BC RID: 10172
			Automatic,
			// Token: 0x040027BD RID: 10173
			Mission
		}

		// Token: 0x02000A56 RID: 2646
		public enum MissionCategory
		{
			// Token: 0x040027BF RID: 10175
			Mission,
			// Token: 0x040027C0 RID: 10176
			Package,
			// Token: 0x040027C1 RID: 10177
			TaskPool
		}

		// Token: 0x02000A57 RID: 2647
		// (Invoke) Token: 0x06005445 RID: 21573
		public delegate void Delegate16(Mission theM);

		// Token: 0x02000A58 RID: 2648
		// (Invoke) Token: 0x06005449 RID: 21577
		public delegate void Delegate17(Mission theM);

		// Token: 0x02000A59 RID: 2649
		// (Invoke) Token: 0x0600544D RID: 21581
		public delegate void Delegate18(Mission theM);

		// Token: 0x02000A5A RID: 2650
		// (Invoke) Token: 0x06005451 RID: 21585
		public delegate void Delegate19(Mission theM);

		// Token: 0x02000A5B RID: 2651
		public enum _FlightQty
		{
			// Token: 0x040027C3 RID: 10179
			All = -99,
			// Token: 0x040027C4 RID: 10180
			NoPreferences = 0,
			// Token: 0x040027C5 RID: 10181
			Flight_x1 = -97,
			// Token: 0x040027C6 RID: 10182
			Flight_x2,
			// Token: 0x040027C7 RID: 10183
			Flight_x3,
			// Token: 0x040027C8 RID: 10184
			Flight_x4,
			// Token: 0x040027C9 RID: 10185
			Flight_x6,
			// Token: 0x040027CA RID: 10186
			Flight_x8,
			// Token: 0x040027CB RID: 10187
			Flight_x12,
			// Token: 0x040027CC RID: 10188
			Aircraft_x1 = -87,
			// Token: 0x040027CD RID: 10189
			Aircraft_x2,
			// Token: 0x040027CE RID: 10190
			Aircraft_x3,
			// Token: 0x040027CF RID: 10191
			Aircraft_x4,
			// Token: 0x040027D0 RID: 10192
			Aircraft_x6,
			// Token: 0x040027D1 RID: 10193
			Aircraft_x8,
			// Token: 0x040027D2 RID: 10194
			Aircraft_x12
		}

		// Token: 0x02000A5C RID: 2652
		public enum _MissionClass : byte
		{
			// Token: 0x040027D4 RID: 10196
			None,
			// Token: 0x040027D5 RID: 10197
			Strike,
			// Token: 0x040027D6 RID: 10198
			Patrol,
			// Token: 0x040027D7 RID: 10199
			Support,
			// Token: 0x040027D8 RID: 10200
			Ferry,
			// Token: 0x040027D9 RID: 10201
			Mining,
			// Token: 0x040027DA RID: 10202
			MineClearing,
			// Token: 0x040027DB RID: 10203
			Escort,
			// Token: 0x040027DC RID: 10204
			Cargo
		}

		// Token: 0x02000A5D RID: 2653
		public enum _MissionStatus : byte
		{
			// Token: 0x040027DE RID: 10206
			Activation,
			// Token: 0x040027DF RID: 10207
			DeActivation
		}

		// Token: 0x02000A5E RID: 2654
		public enum Enum60 : byte
		{
			// Token: 0x040027E1 RID: 10209
			const_0,
			// Token: 0x040027E2 RID: 10210
			const_1,
			// Token: 0x040027E3 RID: 10211
			const_2
		}

		// Token: 0x02000A5F RID: 2655
		public enum _FlightSize
		{
			// Token: 0x040027E5 RID: 10213
			None,
			// Token: 0x040027E6 RID: 10214
			SingleAircraft,
			// Token: 0x040027E7 RID: 10215
			TwoAircraft,
			// Token: 0x040027E8 RID: 10216
			ThreeAircraft,
			// Token: 0x040027E9 RID: 10217
			FourAircraft,
			// Token: 0x040027EA RID: 10218
			SixAircraft = 6
		}

		// Token: 0x02000A60 RID: 2656
		public enum _GroupSize
		{
			// Token: 0x040027EC RID: 10220
			const_0,
			// Token: 0x040027ED RID: 10221
			const_1,
			// Token: 0x040027EE RID: 10222
			const_2,
			// Token: 0x040027EF RID: 10223
			const_3,
			// Token: 0x040027F0 RID: 10224
			const_4,
			// Token: 0x040027F1 RID: 10225
			const_5 = 6
		}

		// Token: 0x02000A61 RID: 2657
		public enum _Formation
		{
			// Token: 0x040027F3 RID: 10227
			const_0 = 1
		}

		// Token: 0x02000A62 RID: 2658
		public enum _RadarBehaviour
		{
			// Token: 0x040027F5 RID: 10229
			const_0,
			// Token: 0x040027F6 RID: 10230
			Land,
			// Token: 0x040027F7 RID: 10231
			const_2,
			// Token: 0x040027F8 RID: 10232
			Maritime
		}

		// Token: 0x02000A63 RID: 2659
		public enum _Task
		{
			// Token: 0x040027FA RID: 10234
			const_0,
			// Token: 0x040027FB RID: 10235
			Strike_Land,
			// Token: 0x040027FC RID: 10236
			Strike_Maritime,
			// Token: 0x040027FD RID: 10237
			Strike_OffensiveCounterAir,
			// Token: 0x040027FE RID: 10238
			Strike_SEAD,
			// Token: 0x040027FF RID: 10239
			FighterSweep_CounterAir,
			// Token: 0x04002800 RID: 10240
			SEADSweep,
			// Token: 0x04002801 RID: 10241
			BattlefieldAirInterdiction,
			// Token: 0x04002802 RID: 10242
			CloseAirSupport,
			// Token: 0x04002803 RID: 10243
			CombatAirPatrol,
			// Token: 0x04002804 RID: 10244
			TargetCombatAirPatrol,
			// Token: 0x04002805 RID: 10245
			BarrierCombatAirPatrol,
			// Token: 0x04002806 RID: 10246
			GroundLaunchedIntercept,
			// Token: 0x04002807 RID: 10247
			DeckLaunchedIntercept,
			// Token: 0x04002808 RID: 10248
			Escort_FighterSweep,
			// Token: 0x04002809 RID: 10249
			Escort_TARCAP,
			// Token: 0x0400280A RID: 10250
			Escort_SEADSweep,
			// Token: 0x0400280B RID: 10251
			AntiSatellite,
			// Token: 0x0400280C RID: 10252
			AirborneLaser,
			// Token: 0x0400280D RID: 10253
			BuddyIllumination,
			// Token: 0x0400280E RID: 10254
			OffensiveECM,
			// Token: 0x0400280F RID: 10255
			AirborneEarlyWarning,
			// Token: 0x04002810 RID: 10256
			AirborneCommandPost,
			// Token: 0x04002811 RID: 10257
			ChaffLaying,
			// Token: 0x04002812 RID: 10258
			SearchAndRescue,
			// Token: 0x04002813 RID: 10259
			CombatSearchAndRescue,
			// Token: 0x04002814 RID: 10260
			MineSweeping,
			// Token: 0x04002815 RID: 10261
			MineRecon,
			// Token: 0x04002816 RID: 10262
			NavalMineLaying,
			// Token: 0x04002817 RID: 10263
			ASW,
			// Token: 0x04002818 RID: 10264
			ForwardAirController,
			// Token: 0x04002819 RID: 10265
			Surveillance,
			// Token: 0x0400281A RID: 10266
			ArmedRecon,
			// Token: 0x0400281B RID: 10267
			UnarmedRecon,
			// Token: 0x0400281C RID: 10268
			MaritimeSurveillance,
			// Token: 0x0400281D RID: 10269
			ParaDrop,
			// Token: 0x0400281E RID: 10270
			TroopTransport,
			// Token: 0x0400281F RID: 10271
			Cargo,
			// Token: 0x04002820 RID: 10272
			AirRefuelling,
			// Token: 0x04002821 RID: 10273
			Training,
			// Token: 0x04002822 RID: 10274
			TargetTow,
			// Token: 0x04002823 RID: 10275
			TargetDrone,
			// Token: 0x04002824 RID: 10276
			Ferry,
			// Token: 0x04002825 RID: 10277
			HighValueAssetCombatAirPatrol = 44,
			// Token: 0x04002826 RID: 10278
			RescueCombatAirPatrol,
			// Token: 0x04002827 RID: 10279
			Strike_Interdiction,
			// Token: 0x04002828 RID: 10280
			Support,
			// Token: 0x04002829 RID: 10281
			Escort_Support
		}

		// Token: 0x02000A64 RID: 2660
		public enum _AttackMethod
		{
			// Token: 0x0400282B RID: 10283
			const_0,
			// Token: 0x0400282C RID: 10284
			const_1,
			// Token: 0x0400282D RID: 10285
			const_2,
			// Token: 0x0400282E RID: 10286
			const_3,
			// Token: 0x0400282F RID: 10287
			const_4,
			// Token: 0x04002830 RID: 10288
			const_5,
			// Token: 0x04002831 RID: 10289
			const_6,
			// Token: 0x04002832 RID: 10290
			const_7,
			// Token: 0x04002833 RID: 10291
			const_8,
			// Token: 0x04002834 RID: 10292
			const_9,
			// Token: 0x04002835 RID: 10293
			const_10,
			// Token: 0x04002836 RID: 10294
			const_11
		}

		// Token: 0x02000A65 RID: 2661
		public enum _SplitDistance
		{
			// Token: 0x04002838 RID: 10296
			const_0,
			// Token: 0x04002839 RID: 10297
			const_1,
			// Token: 0x0400283A RID: 10298
			const_2
		}

		// Token: 0x02000A66 RID: 2662
		public enum _Priority
		{
			// Token: 0x0400283C RID: 10300
			const_0,
			// Token: 0x0400283D RID: 10301
			Mandatory
		}

		// Token: 0x02000A67 RID: 2663
		public enum Enum68
		{
			// Token: 0x0400283F RID: 10303
			const_0,
			// Token: 0x04002840 RID: 10304
			const_1,
			// Token: 0x04002841 RID: 10305
			const_2,
			// Token: 0x04002842 RID: 10306
			const_3,
			// Token: 0x04002843 RID: 10307
			const_4,
			// Token: 0x04002844 RID: 10308
			const_5,
			// Token: 0x04002845 RID: 10309
			const_6,
			// Token: 0x04002846 RID: 10310
			const_7
		}

		// Token: 0x02000A68 RID: 2664
		public enum Enum69
		{
			// Token: 0x04002848 RID: 10312
			const_0,
			// Token: 0x04002849 RID: 10313
			const_1,
			// Token: 0x0400284A RID: 10314
			const_2
		}

		// Token: 0x02000A69 RID: 2665
		public sealed class Flight : Subject
		{
            // Token: 0x06005454 RID: 21588 RVA: 0x0022C374 File Offset: 0x0022A574
            //梯队
            public Flight()
			{
				this.UsedByFlight = false;
				this.FlightCourse = new Waypoint[0];
				this.waypoint_1 = new Waypoint[0];
				this.waypoint_2 = new Waypoint[0];
				this.bool_11 = false;
				this.bool_12 = false;
				this.bool_13 = false;
				this.bool_14 = false;
				this.Reason = "";
			}

			// Token: 0x06005455 RID: 21589 RVA: 0x0022C408 File Offset: 0x0022A608
			public Flight(ref Scenario scenario_0, ref Mission mission_2, ref Mission.Flight Flight_, string string_20, string string_21, string string_22, int int_5, Contact contact_1, ActiveUnit activeUnit_1)
			{
				this.UsedByFlight = false;
				this.FlightCourse = new Waypoint[0];
				this.waypoint_1 = new Waypoint[0];
				this.waypoint_2 = new Waypoint[0];
				this.bool_11 = false;
				this.bool_12 = false;
				this.bool_13 = false;
				this.bool_14 = false;
				this.Reason = "";
				this.Callsign = string_20;
				this.TakeOffLocation_HostUnitObjectID = string_21;
				this.TakeOffLocation_HostUnitObjectName = string_22;
				this.LandingLocation_HostUnitObjectID = string_21;
				this.LandingLocation_HostUnitObjectName = string_22;
				this.LoadoutDBID = int_5;
				this.PrimaryTarget = contact_1;
				this.SetReferenceUnit(scenario_0, activeUnit_1);
				this.DesiredAircraftQty = mission_2.m_FlightSize;
				this.Priority = Mission._Priority.Mandatory;
				if (mission_2.UseFlightSizeHardLimit)
				{
					this.MinimumAircraftQty = mission_2.m_FlightSize;
				}
				else
				{
					this.MinimumAircraftQty = Mission._FlightSize.None;
				}
				checked
				{
					if (!Information.IsNothing(Flight_))
					{
						Waypoint[] flightCourse = Flight_.GetFlightCourse();
						for (int i = 0; i < flightCourse.Length; i++)
						{
							Waypoint waypoint = flightCourse[i];
							Waypoint[] flightCourse2 = this.GetFlightCourse();
							ScenarioArrayUtil.AddWaypoint(ref flightCourse2, waypoint.method_23(ref scenario_0, ref waypoint, true, true));
							this.SetFlightCourse(flightCourse2);
						}
					}
					switch (mission_2.MissionClass)
					{
					case Mission._MissionClass.Strike:
						switch (((Strike)mission_2).strikeType)
						{
						case Strike.StrikeType.Air_Intercept:
							this.Task = Mission._Task.GroundLaunchedIntercept;
							break;
						case Strike.StrikeType.Land_Strike:
							this.Task = Mission._Task.Strike_Land;
							break;
						case Strike.StrikeType.Maritime_Strike:
							this.Task = Mission._Task.Strike_Maritime;
							break;
						case Strike.StrikeType.Sub_Strike:
							this.Task = Mission._Task.ASW;
							break;
						}
						break;
					case Mission._MissionClass.Patrol:
						switch (((Patrol)mission_2).patrolType)
						{
						case GlobalVariables.PatrolType.ASW:
							this.Task = Mission._Task.ASW;
							break;
						case GlobalVariables.PatrolType.ASuW_Naval:
							this.Task = Mission._Task.MaritimeSurveillance;
							break;
						case GlobalVariables.PatrolType.AAW:
							this.Task = Mission._Task.CombatAirPatrol;
							break;
						case GlobalVariables.PatrolType.ASuW_Land:
							this.Task = Mission._Task.Surveillance;
							break;
						case GlobalVariables.PatrolType.ASuW_Mixed:
							this.Task = Mission._Task.Surveillance;
							break;
						case GlobalVariables.PatrolType.SEAD:
							this.Task = Mission._Task.Strike_SEAD;
							break;
						case GlobalVariables.PatrolType.SeaControl:
							this.Task = Mission._Task.MaritimeSurveillance;
							break;
						}
						break;
					case Mission._MissionClass.Support:
						this.Task = Mission._Task.Support;
						break;
					case Mission._MissionClass.Ferry:
						this.Task = Mission._Task.Ferry;
						break;
					case Mission._MissionClass.Mining:
						this.Task = Mission._Task.NavalMineLaying;
						break;
					case Mission._MissionClass.MineClearing:
						this.Task = Mission._Task.MineSweeping;
						break;
					case Mission._MissionClass.Escort:
						this.Task = Mission._Task.Escort_Support;
						break;
					}
				}
			}

			// Token: 0x06005456 RID: 21590 RVA: 0x0022C690 File Offset: 0x0022A890
			public Waypoint[] GetFlightCourse()
			{
				return this.FlightCourse;
			}

			// Token: 0x06005457 RID: 21591 RVA: 0x00026E61 File Offset: 0x00025061
			public void SetFlightCourse(Waypoint[] value)
			{
				this.FlightCourse = value;
			}

			// Token: 0x06005458 RID: 21592 RVA: 0x0022C6A8 File Offset: 0x0022A8A8
			public Waypoint[] GetWaypoint1()
			{
				return this.waypoint_1;
			}

			// Token: 0x06005459 RID: 21593 RVA: 0x00026E6A File Offset: 0x0002506A
			public void SetWaypoint1(Waypoint[] waypoint_3)
			{
				this.waypoint_1 = waypoint_3;
			}

			// Token: 0x0600545A RID: 21594 RVA: 0x0022C6C0 File Offset: 0x0022A8C0
			public Waypoint[] GetWaypoint2()
			{
				return this.waypoint_2;
			}

			// Token: 0x0600545B RID: 21595 RVA: 0x00026E73 File Offset: 0x00025073
			public void SetWaypoint2(Waypoint[] waypoint_3)
			{
				this.waypoint_2 = waypoint_3;
			}

			// Token: 0x0600545C RID: 21596 RVA: 0x0022C6D8 File Offset: 0x0022A8D8
			public void SetMissionPlannerErrorList(ref Scenario scenario_, ref Mission.Flight Flight_, string string_20, int AircraftDBID, int LoadoutDBID)
			{
				try
				{
					if (!Information.IsNothing(scenario_) && !Information.IsNothing(scenario_.MissionPlannerErrorList) && scenario_.MissionPlannerErrorList.Count > 0)
					{
						string text = "Master Flightplan AircraftDBID: " + Conversions.ToString(AircraftDBID) + " LoadoutDBID: " + Conversions.ToString(LoadoutDBID);
						if (!string.IsNullOrEmpty(Flight_.Callsign) && Operators.CompareString(Flight_.Callsign, text, false) == 0)
						{
							for (int i = scenario_.MissionPlannerErrorList.Count - 1; i >= 0; i += -1)
							{
								string text2 = scenario_.MissionPlannerErrorList[i];
								if (string.IsNullOrEmpty(text2))
								{
									scenario_.MissionPlannerErrorList.Remove(scenario_.MissionPlannerErrorList[i]);
								}
								else if (text2.Contains(text))
								{
									scenario_.MissionPlannerErrorList[i] = text2.Replace(text, string_20);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101383", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}

			// Token: 0x0600545D RID: 21597 RVA: 0x0022C820 File Offset: 0x0022AA20
			public void SetFlight0ToFlight1(ref Scenario scenario_, ref Mission.Flight Flight_0, ref Mission.Flight Flight_1, bool bool_15, ref Mission mission_, ref int int_5, ref int int_6)
			{
				checked
				{
					if (!Information.IsNothing(Flight_0) && !Information.IsNothing(Flight_1))
					{
						string text = CallsignGenerator.GenerateCallsignString(ref mission_);
						this.SetMissionPlannerErrorList(ref scenario_, ref Flight_0, text, Flight_0.ReferenceUnit_DBID, Flight_0.LoadoutDBID);
						Flight_1.Callsign = text;
						Flight_1.Task = Flight_0.Task;
						Flight_1.Priority = Flight_0.Priority;
						Flight_1.TakeOffLocation_HostUnitObjectID = Flight_0.TakeOffLocation_HostUnitObjectID;
						Flight_1.TakeOffLocation_HostUnitObjectName = Flight_0.TakeOffLocation_HostUnitObjectName;
						Flight_1.LandingLocation_HostUnitObjectID = Flight_0.LandingLocation_HostUnitObjectID;
						Flight_1.LandingLocation_HostUnitObjectName = Flight_0.LandingLocation_HostUnitObjectName;
						Flight_1.AlternativeLandingLocation_HostUnitObjectID = Flight_0.AlternativeLandingLocation_HostUnitObjectID;
						Flight_1.AlternativeLandingLocation_HostUnitObjectName = Flight_0.AlternativeLandingLocation_HostUnitObjectName;
						if (bool_15)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						else
						{
							Flight_1.OneTime = Flight_0.OneTime;
							Flight_1.TimeBound = Flight_0.TimeBound;
							Flight_1.DesiredAircraftQty = Flight_0.DesiredAircraftQty;
						}
						Flight_1.EarliestTaskingTime = Flight_0.EarliestTaskingTime;
						Flight_1.LatestTaskingTime = Flight_0.LatestTaskingTime;
						Flight_1.MaxReadyTime = Flight_0.MaxReadyTime;
						Flight_1.EarliestLaunchTime = Flight_0.EarliestLaunchTime;
						Flight_1.LatestLaunchTime = Flight_0.LatestLaunchTime;
						Flight_1.Priority = Flight_0.Priority;
						Flight_1.Status = Flight_0.Status;
						Flight_1.CreatedBy = Flight_0.CreatedBy;
						Flight_1.EditedBy = Flight_0.EditedBy;
						Flight_1.MinimumAircraftQty = Flight_0.MinimumAircraftQty;
						Flight_1.AssignedAircraftQty = Flight_0.AssignedAircraftQty;
						Flight_1.ReadyAircraftQty = Flight_0.ReadyAircraftQty;
						Flight_1.UsedByFlight = false;
						Flight_1.SetReferenceUnit(null, null);
						Flight_1.ReferenceUnit_DBID = Flight_0.ReferenceUnit_DBID;
						Flight_1.ReferenceUnit_ObjectID = Flight_0.ReferenceUnit_ObjectID;
						Flight_1.ReferenceUnit_Name = Flight_0.ReferenceUnit_Name;
						Flight_1.LoadoutDBID = Flight_0.LoadoutDBID;
						Flight_1.LoadoutName = Flight_0.LoadoutName;
						if (!Information.IsNothing(Flight_0.GetFlightCourse()) && Flight_0.GetFlightCourse().Count<Waypoint>() > 0)
						{
							Waypoint[] flightCourse = Flight_0.GetFlightCourse();
							for (int i = 0; i < flightCourse.Length; i++)
							{
								Waypoint waypoint = flightCourse[i];
								Mission.Flight flight = Flight_1;
								Waypoint[] array = flight.GetFlightCourse();
								ScenarioArrayUtil.AddWaypoint(ref array, waypoint.method_23(ref scenario_, ref waypoint, true, true));
								flight.SetFlightCourse(array);
							}
						}
						if (!Information.IsNothing(Flight_0.GetWaypoint1()) && Flight_0.GetWaypoint1().Count<Waypoint>() > 0)
						{
							Waypoint[] array = Flight_0.GetWaypoint1();
							for (int j = 0; j < array.Length; j++)
							{
								Waypoint waypoint2 = array[j];
								Mission.Flight flight2 = Flight_1;
								Waypoint[] array2 = flight2.GetWaypoint1();
								ScenarioArrayUtil.AddWaypoint(ref array2, waypoint2.method_23(ref scenario_, ref waypoint2, true, true));
								flight2.SetWaypoint1(array2);
							}
						}
						if (!Information.IsNothing(Flight_0.GetWaypoint2()) && Flight_0.GetWaypoint2().Count<Waypoint>() > 0)
						{
							Waypoint[] array2 = Flight_0.GetWaypoint2();
							for (int k = 0; k < array2.Length; k++)
							{
								Waypoint waypoint3 = array2[k];
								Mission.Flight flight3 = Flight_1;
								Waypoint[] waypoint_ = flight3.GetWaypoint2();
								ScenarioArrayUtil.AddWaypoint(ref waypoint_, waypoint3.method_23(ref scenario_, ref waypoint3, true, true));
								flight3.SetWaypoint2(waypoint_);
							}
						}
						Flight_1.TaskPool = Flight_0.TaskPool;
						Flight_1.TaskPool_PreferredLoadoutDBID = Flight_0.TaskPool_PreferredLoadoutDBID;
						Flight_1.PostTaskPool = Flight_0.PostTaskPool;
						Flight_1.PostTaskPool_PreferredLoadoutDBID = Flight_0.PostTaskPool_PreferredLoadoutDBID;
						Flight_1.Age = 0;
						Flight_1.PrimaryTarget = Flight_0.PrimaryTarget;
						Flight_1.bool_11 = false;
						Flight_1.bool_12 = false;
						Flight_1.bool_13 = false;
						Flight_1.bool_14 = false;
						Flight_1.Reason = "";
					}
				}
			}

			// Token: 0x0600545E RID: 21598 RVA: 0x0022CBE8 File Offset: 0x0022ADE8
			public ActiveUnit GetReferenceUnit(Scenario scenario_)
			{
				checked
				{
					if (Information.IsNothing(this.ReferenceUnit) && !Information.IsNothing(scenario_))
					{
						if (!string.IsNullOrEmpty(this.ReferenceUnit_ObjectID))
						{
							if (scenario_.GetActiveUnits().ContainsKey(this.ReferenceUnit_ObjectID))
							{
								this.ReferenceUnit = scenario_.GetActiveUnits()[this.ReferenceUnit_ObjectID];
							}
						}
						else
						{
							foreach (ActiveUnit current in scenario_.GetActiveUnits().Values)
							{
								if (current.GetNavigator().HasFlightCourse() && current.GetNavigator().GetFlight() == this)
								{
									this.SetReferenceUnit(scenario_, current);
									break;
								}
							}
						}
						if (Information.IsNothing(this.ReferenceUnit) && this.ReferenceUnit_DBID > 0 && this.LoadoutDBID > 0)
						{
							bool flag = false;
							Side[] sides = scenario_.GetSides();
							int i = 0;
							while (i < sides.Length)
							{
								Side side = sides[i];
								using (IEnumerator<Mission> enumerator2 = side.GetMissionCollection().GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										Mission current2 = enumerator2.Current;
										if (current2.HasFlights())
										{
                                            Mission.Flight current3X;
                                            foreach (Mission.Flight current3 in current2.FlightList)
											{
												if (current3 == this)
												{
                                                    current3X = current3;
                                                    Mission mission = current2;
													int referenceUnit_DBID = this.ReferenceUnit_DBID;
													int loadoutDBID = this.LoadoutDBID;
													ObservableDictionary<string, ActiveUnit> activeUnits;
													string takeOffLocation_HostUnitObjectID;
													ActiveUnit value = (activeUnits = scenario_.GetActiveUnits())[takeOffLocation_HostUnitObjectID = this.TakeOffLocation_HostUnitObjectID];
													ActiveUnit referenceUnit = mission.GetReferenceUnit(ref scenario_, ref side, referenceUnit_DBID, loadoutDBID, ref value, ref current3X, false, 1);
													activeUnits[takeOffLocation_HostUnitObjectID] = value;
													this.ReferenceUnit = referenceUnit;
													flag = true;
													break;
												}
											}
										}
										if (flag)
										{
											break;
										}
									}
									if (flag)
									{
										break;
									}
									i++;
								}
							}
						}
					}
					return this.ReferenceUnit;
				}
			}

			// Token: 0x0600545F RID: 21599 RVA: 0x0022CE28 File Offset: 0x0022B028
			public void SetReferenceUnit(Scenario scenario_0, ActiveUnit activeUnit_1)
			{
				this.ReferenceUnit = activeUnit_1;
				if (!Information.IsNothing(activeUnit_1))
				{
					this.ReferenceUnit_DBID = this.ReferenceUnit.DBID;
					this.ReferenceUnit_ObjectID = this.ReferenceUnit.GetGuid();
					this.ReferenceUnit_Name = this.ReferenceUnit.UnitClass;
				}
			}

			// Token: 0x06005460 RID: 21600 RVA: 0x0022CE78 File Offset: 0x0022B078
			public static List<Mission.Flight> Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
			{
				List<Mission.Flight> list = new List<Mission.Flight>();
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "Flight", false) == 0)
						{
							Mission.Flight flight = new Mission.Flight();
							IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
									string name2 = xmlNode2.Name;
									uint num = Class382.smethod_0(name2);
									if (num <= 1902930894u)
									{
										if (num <= 709636896u)
										{
											if (num <= 549423346u)
											{
												if (num <= 66428795u)
												{
													if (num != 6222351u)
													{
														if (num == 66428795u && Operators.CompareString(name2, "MinimumAircraftQty", false) == 0)
														{
															flight.MinimumAircraftQty = (Mission._FlightSize)Conversions.ToByte(xmlNode2.InnerText);
														}
													}
													else if (Operators.CompareString(name2, "Status", false) == 0)
													{
														flight.Status = (Mission.Enum68)Conversions.ToByte(xmlNode2.InnerText);
													}
												}
												else if (num != 211111892u)
												{
													if (num != 436022125u)
													{
														if (num == 549423346u && Operators.CompareString(name2, "LandingLocation_HostUnitObjectID", false) == 0)
														{
															flight.LandingLocation_HostUnitObjectID = xmlNode2.InnerText;
														}
													}
													else if (Operators.CompareString(name2, "TakeOffLocation_HostUnitObjectName", false) == 0)
													{
														flight.TakeOffLocation_HostUnitObjectName = xmlNode2.InnerText;
													}
												}
												else if (Operators.CompareString(name2, "TaskPool_Name", false) == 0)
												{
													flight.TaskPool_Name = xmlNode2.InnerText;
												}
											}
											else if (num <= 600539979u)
											{
												if (num != 556417012u)
												{
													if (num == 600539979u && Operators.CompareString(name2, "UsedByFlight", false) == 0)
													{
														flight.UsedByFlight = Conversions.ToBoolean(xmlNode2.InnerText);
													}
												}
												else if (Operators.CompareString(name2, "PostTaskPool_ID", false) == 0)
												{
													flight.PostTaskPool_ID = xmlNode2.InnerText;
												}
											}
											else if (num != 648502632u)
											{
												if (num != 666462942u)
												{
													if (num == 709636896u && Operators.CompareString(name2, "LoadoutDBID", false) == 0)
													{
														flight.LoadoutDBID = Conversions.ToInteger(xmlNode2.InnerText);
													}
												}
												else if (Operators.CompareString(name2, "OneTime", false) == 0)
												{
													flight.OneTime = Conversions.ToBoolean(xmlNode2.InnerText);
												}
											}
											else if (Operators.CompareString(name2, "LoadoutName", false) == 0)
											{
												flight.LoadoutName = xmlNode2.InnerText;
											}
										}
										else if (num <= 1458105184u)
										{
											if (num <= 814615482u)
											{
												if (num != 777311749u)
												{
													if (num == 814615482u && Operators.CompareString(name2, "PostTaskPool_Name", false) == 0)
													{
														flight.PostTaskPool_Name = xmlNode2.InnerText;
													}
												}
												else if (Operators.CompareString(name2, "EditedBy", false) == 0)
												{
													flight.EditedBy = (Mission.Enum69)Conversions.ToByte(xmlNode2.InnerText);
												}
											}
											else if (num != 868649010u)
											{
												if (num != 1095917180u)
												{
													if (num == 1458105184u && Operators.CompareString(name2, "ID", false) == 0)
													{
														flight.SetGuid(xmlNode2.InnerText);
													}
												}
												else if (Operators.CompareString(name2, "LatestTaskingTime", false) == 0)
												{
													DateTime value = DateTime.FromBinary(Conversions.ToLong(xmlNode2.InnerText));
													flight.LatestTaskingTime = new DateTime?(value);
												}
											}
											else if (Operators.CompareString(name2, "ReferenceUnit_Name", false) == 0)
											{
												flight.ReferenceUnit_Name = xmlNode2.InnerText;
											}
										}
										else if (num <= 1490959268u)
										{
											if (num != 1459831884u)
											{
												if (num == 1490959268u && Operators.CompareString(name2, "TimeBound", false) == 0)
												{
													flight.TimeBound = Conversions.ToBoolean(xmlNode2.InnerText);
												}
											}
											else if (Operators.CompareString(name2, "PrimaryTarget_ID", false) == 0)
											{
												flight.PrimaryTarget_ID = xmlNode2.InnerText;
											}
										}
										else if (num != 1533607987u)
										{
											if (num != 1581646654u)
											{
												if (num == 1902930894u && Operators.CompareString(name2, "EarliestLaunchTime", false) == 0)
												{
													DateTime value2 = DateTime.FromBinary(Conversions.ToLong(xmlNode2.InnerText));
													flight.EarliestLaunchTime = new DateTime?(value2);
												}
											}
											else if (Operators.CompareString(name2, "EarliestTaskingTime", false) == 0)
											{
												DateTime value3 = DateTime.FromBinary(Conversions.ToLong(xmlNode2.InnerText));
												flight.EarliestTaskingTime = new DateTime?(value3);
											}
										}
										else if (Operators.CompareString(name2, "AlternativeLandingLocation_HostUnitObjectID", false) == 0)
										{
											flight.AlternativeLandingLocation_HostUnitObjectID = xmlNode2.InnerText;
										}
									}
									else if (num <= 2781397394u)
									{
										if (num <= 2379306221u)
										{
											if (num <= 2084398725u)
											{
												if (num != 1995390348u)
												{
													if (num == 2084398725u && Operators.CompareString(name2, "PostTaskPool_PreferredLoadoutName", false) == 0)
													{
														flight.PostTaskPool_PreferredLoadoutName = xmlNode2.InnerText;
													}
												}
												else if (Operators.CompareString(name2, "Task", false) == 0)
												{
													flight.Task = (Mission._Task)Conversions.ToByte(xmlNode2.InnerText);
												}
											}
											else if (num != 2220975494u)
											{
												if (num != 2364794209u)
												{
													if (num == 2379306221u && Operators.CompareString(name2, "AlternativeLandingLocation_HostUnitObjectName", false) == 0)
													{
														flight.AlternativeLandingLocation_HostUnitObjectName = xmlNode2.InnerText;
													}
												}
												else if (Operators.CompareString(name2, "PostTaskPool_PreferredLoadoutDBID", false) == 0)
												{
													flight.PostTaskPool_PreferredLoadoutDBID = Conversions.ToInteger(xmlNode2.InnerText);
												}
											}
											else if (Operators.CompareString(name2, "CreatedBy", false) == 0)
											{
												flight.CreatedBy = (Mission.Enum69)Conversions.ToByte(xmlNode2.InnerText);
											}
										}
										else if (num <= 2457162696u)
										{
											if (num != 2395726140u)
											{
												if (num == 2457162696u && Operators.CompareString(name2, "LatestLaunchTime", false) == 0)
												{
													DateTime value4 = DateTime.FromBinary(Conversions.ToLong(xmlNode2.InnerText));
													flight.LatestLaunchTime = new DateTime?(value4);
												}
											}
											else if (Operators.CompareString(name2, "Age", false) == 0)
											{
												flight.Age = Conversions.ToInteger(xmlNode2.InnerText);
											}
										}
										else if (num != 2497091493u)
										{
											if (num != 2645056075u)
											{
												if (num == 2781397394u && Operators.CompareString(name2, "ReferenceUnit_DBID", false) == 0)
												{
													flight.ReferenceUnit_DBID = Conversions.ToInteger(xmlNode2.InnerText);
												}
											}
											else if (Operators.CompareString(name2, "ReferenceUnit_ObjectID", false) == 0)
											{
												flight.ReferenceUnit_ObjectID = xmlNode2.InnerText;
											}
										}
										else if (Operators.CompareString(name2, "AssignedAircraftQty", false) == 0)
										{
											flight.AssignedAircraftQty = (Mission._FlightSize)Conversions.ToByte(xmlNode2.InnerText);
										}
									}
									else if (num <= 3459419260u)
									{
										if (num <= 2845207279u)
										{
											if (num != 2788569304u)
											{
												if (num == 2845207279u && Operators.CompareString(name2, "TaskPool_PreferredLoadoutName", false) == 0)
												{
													flight.TaskPool_PreferredLoadoutName = xmlNode2.InnerText;
												}
											}
											else if (Operators.CompareString(name2, "Callsign", false) == 0)
											{
												flight.Callsign = xmlNode2.InnerText;
											}
										}
										else if (num != 2889503411u)
										{
											if (num != 3404178554u)
											{
												if (num != 3459419260u || Operators.CompareString(name2, "FlightPlan", false) != 0)
												{
													continue;
												}
												IEnumerator enumerator3 = xmlNode2.ChildNodes.GetEnumerator();
												try
												{
													while (enumerator3.MoveNext())
													{
														XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
														Waypoint waypoint = Waypoint.smethod_9(ref xmlNode3, ref dictionary_0);
														Mission.Flight flight2 = flight;
														Waypoint[] flightCourse = flight2.GetFlightCourse();
														ScenarioArrayUtil.AddWaypoint(ref flightCourse, waypoint);
														flight2.SetFlightCourse(flightCourse);
													}
													continue;
												}
												finally
												{
													if (enumerator3 is IDisposable)
													{
														(enumerator3 as IDisposable).Dispose();
													}
												}
											}
											if (Operators.CompareString(name2, "ReadyAircraftQty", false) == 0)
											{
												flight.ReadyAircraftQty = (Mission._FlightSize)Conversions.ToByte(xmlNode2.InnerText);
											}
										}
										else if (Operators.CompareString(name2, "TakeOffLocation_HostUnitObjectID", false) == 0)
										{
											flight.TakeOffLocation_HostUnitObjectID = xmlNode2.InnerText;
										}
									}
									else if (num <= 3791178810u)
									{
										if (num != 3597454893u)
										{
											if (num != 3779853785u)
											{
												if (num == 3791178810u && Operators.CompareString(name2, "TaskPool_ID", false) == 0)
												{
													flight.TaskPool_ID = xmlNode2.InnerText;
												}
											}
											else if (Operators.CompareString(name2, "MaxReadyTime", false) == 0)
											{
												flight.MaxReadyTime = (float)Conversions.ToShort(xmlNode2.InnerText);
											}
										}
										else if (Operators.CompareString(name2, "DesiredAircraftQty", false) == 0)
										{
											flight.DesiredAircraftQty = (Mission._FlightSize)Conversions.ToByte(xmlNode2.InnerText);
										}
									}
									else if (num != 3868041001u)
									{
										if (num != 3973949212u)
										{
											if (num == 4036838091u && Operators.CompareString(name2, "TaskPool_PreferredLoadoutDBID", false) == 0)
											{
												flight.TaskPool_PreferredLoadoutDBID = Conversions.ToInteger(xmlNode2.InnerText);
											}
										}
										else if (Operators.CompareString(name2, "LandingLocation_HostUnitObjectName", false) == 0)
										{
											flight.LandingLocation_HostUnitObjectName = xmlNode2.InnerText;
										}
									}
									else if (Operators.CompareString(name2, "Priority", false) == 0)
									{
										flight.Priority = (Mission._Priority)Conversions.ToByte(xmlNode2.InnerText);
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
							list.Add(flight);
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
				return list;
			}

			// Token: 0x06005461 RID: 21601 RVA: 0x0022DA68 File Offset: 0x0022BC68
			public static void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0, ref List<Mission.Flight> FlightList)
			{
				xmlWriter_0.WriteStartElement("FlightList");
				foreach (Mission.Flight current in FlightList)
				{
					xmlWriter_0.WriteStartElement("Flight");
					xmlWriter_0.WriteElementString("ID", current.GetGuid());
					xmlWriter_0.WriteElementString("Callsign", current.Callsign);
					xmlWriter_0.WriteElementString("Task", ((byte)current.Task).ToString());
					xmlWriter_0.WriteElementString("TakeOffLocation_HostUnitObjectID", current.TakeOffLocation_HostUnitObjectID);
					xmlWriter_0.WriteElementString("TakeOffLocation_HostUnitObjectName", current.TakeOffLocation_HostUnitObjectName);
					xmlWriter_0.WriteElementString("LandingLocation_HostUnitObjectID", current.LandingLocation_HostUnitObjectID);
					xmlWriter_0.WriteElementString("LandingLocation_HostUnitObjectName", current.LandingLocation_HostUnitObjectName);
					xmlWriter_0.WriteElementString("AlternativeLandingLocation_HostUnitObjectID", current.AlternativeLandingLocation_HostUnitObjectID);
					xmlWriter_0.WriteElementString("AlternativeLandingLocation_HostUnitObjectName", current.AlternativeLandingLocation_HostUnitObjectName);
					xmlWriter_0.WriteElementString("OneTime", current.OneTime.ToString());
					xmlWriter_0.WriteElementString("TimeBound", current.TimeBound.ToString());
					if (current.EarliestTaskingTime.HasValue)
					{
						xmlWriter_0.WriteElementString("EarliestTaskingTime", current.EarliestTaskingTime.Value.ToBinary().ToString());
					}
					if (current.LatestTaskingTime.HasValue)
					{
						xmlWriter_0.WriteElementString("LatestTaskingTime", current.LatestTaskingTime.Value.ToBinary().ToString());
					}
					if (current.EarliestLaunchTime.HasValue)
					{
						xmlWriter_0.WriteElementString("EarliestLaunchTime", current.EarliestLaunchTime.Value.ToBinary().ToString());
					}
					if (current.LatestLaunchTime.HasValue)
					{
						xmlWriter_0.WriteElementString("LatestLaunchTime", current.LatestLaunchTime.Value.ToBinary().ToString());
					}
					xmlWriter_0.WriteElementString("MaxReadyTime", current.MaxReadyTime.ToString());
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Priority";
					int num = (int)current.Priority;
					xmlWriter.WriteElementString(localName, num.ToString());
					XmlWriter xmlWriter2 = xmlWriter_0;
					string localName2 = "Status";
					num = (int)current.Status;
					xmlWriter2.WriteElementString(localName2, num.ToString());
					XmlWriter xmlWriter3 = xmlWriter_0;
					string localName3 = "CreatedBy";
					num = (int)current.CreatedBy;
					xmlWriter3.WriteElementString(localName3, num.ToString());
					XmlWriter xmlWriter4 = xmlWriter_0;
					string localName4 = "EditedBy";
					num = (int)current.EditedBy;
					xmlWriter4.WriteElementString(localName4, num.ToString());
					XmlWriter xmlWriter5 = xmlWriter_0;
					string localName5 = "DesiredAircraftQty";
					num = (int)current.DesiredAircraftQty;
					xmlWriter5.WriteElementString(localName5, num.ToString());
					XmlWriter xmlWriter6 = xmlWriter_0;
					string localName6 = "MinimumAircraftQty";
					num = (int)current.MinimumAircraftQty;
					xmlWriter6.WriteElementString(localName6, num.ToString());
					XmlWriter xmlWriter7 = xmlWriter_0;
					string localName7 = "AssignedAircraftQty";
					num = (int)current.AssignedAircraftQty;
					xmlWriter7.WriteElementString(localName7, num.ToString());
					XmlWriter xmlWriter8 = xmlWriter_0;
					string localName8 = "ReadyAircraftQty";
					num = (int)current.ReadyAircraftQty;
					xmlWriter8.WriteElementString(localName8, num.ToString());
					xmlWriter_0.WriteElementString("ReferenceUnit_DBID", current.ReferenceUnit_DBID.ToString());
					xmlWriter_0.WriteElementString("ReferenceUnit_ObjectID", current.ReferenceUnit_ObjectID);
					xmlWriter_0.WriteElementString("ReferenceUnit_Name", current.ReferenceUnit_Name);
					xmlWriter_0.WriteElementString("LoadoutDBID", current.LoadoutDBID.ToString());
					xmlWriter_0.WriteElementString("LoadoutName", current.LoadoutName);
					xmlWriter_0.WriteElementString("UsedByFlight", current.UsedByFlight.ToString());
					if (!Information.IsNothing(current.TaskPool))
					{
						xmlWriter_0.WriteElementString("TaskPool_ID", current.TaskPool.GetGuid());
					}
					if (!Information.IsNothing(current.PostTaskPool))
					{
						xmlWriter_0.WriteElementString("PostTaskPool_ID", current.PostTaskPool.GetGuid());
					}
					if (!Information.IsNothing(current.PrimaryTarget))
					{
						xmlWriter_0.WriteElementString("PrimaryTarget_ID", current.PrimaryTarget.GetGuid());
					}
					xmlWriter_0.WriteElementString("TaskPool_Name", current.TaskPool_Name);
					xmlWriter_0.WriteElementString("TaskPool_PreferredLoadoutDBID", current.TaskPool_PreferredLoadoutDBID.ToString());
					xmlWriter_0.WriteElementString("TaskPool_PreferredLoadoutName", current.TaskPool_PreferredLoadoutName);
					xmlWriter_0.WriteElementString("PostTaskPool_Name", current.PostTaskPool_Name);
					xmlWriter_0.WriteElementString("PostTaskPool_PreferredLoadoutDBID", current.PostTaskPool_PreferredLoadoutDBID.ToString());
					xmlWriter_0.WriteElementString("PostTaskPool_PreferredLoadoutName", current.PostTaskPool_PreferredLoadoutName);
					xmlWriter_0.WriteElementString("Age", current.Age.ToString());
					if (!Information.IsNothing(current.GetFlightCourse()) && current.GetFlightCourse().Count<Waypoint>() > 0)
					{
						xmlWriter_0.WriteStartElement("FlightPlan");
						List<Waypoint> list = new List<Waypoint>();
						list.AddRange(current.GetFlightCourse());
						foreach (Waypoint current2 in list)
						{
							if (!Information.IsNothing(current2))
							{
								current2.Save(ref xmlWriter_0, ref hashSet_0);
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteEndElement();
				}
				xmlWriter_0.WriteEndElement();
			}

			// Token: 0x06005462 RID: 21602 RVA: 0x0022DFE4 File Offset: 0x0022C1E4
			public static string SetFlightPlanWaypointTimes(ref Scenario scenario_0, ref Mission mission_2, Mission.Flight class168_0, Waypoint[] waypoint_3, DateTime dateTime_0, ref ActiveUnit activeUnit_1)
			{
				string text = "";
				Waypoint waypoint = null;
				checked
				{
					string result;
					try
					{
						if (waypoint_3.Count<Waypoint>() == 0)
						{
							text = null;
						}
						else
						{
							bool flag = false;
							DateTime value = mission_2.GetTakeOffTime().Value;
							if (!Information.IsNothing(mission_2.GetTakeOffTime()))
							{
								value = mission_2.GetTakeOffTime().Value;
								flag = true;
							}
							else if (!Information.IsNothing(mission_2.GetTimeOnTarget()))
							{
								value = mission_2.GetTimeOnTarget().Value;
								flag = false;
							}
							if (!Information.IsNothing(mission_2.GetTakeOffTime()) || !Information.IsNothing(mission_2.GetTimeOnTarget()))
							{
								int i = 0;
								while (i < waypoint_3.Length)
								{
									Waypoint waypoint2 = waypoint_3[i];
									if (!flag || waypoint2.waypointType != Waypoint.WaypointType.TakeOff)
									{
										if (waypoint2.waypointType != Waypoint.WaypointType.Target && waypoint2.waypointType != Waypoint.WaypointType.WeaponTarget)
										{
											i++;
											continue;
										}
										waypoint = waypoint2;
									}
									else
									{
										waypoint = waypoint2;
									}
									if (!Information.IsNothing(waypoint))
									{
										waypoint.ArrivalTime_Zulu = new DateTime?(value);
										waypoint.TimeFixed = Waypoint.Enum52.const_1;
										text = "OK";
										result = text;
										return result;
									}
									if (flag)
									{
										text = "Could not find the take-off waypoint, so could not set flightplan waypoint times.";
										result = text;
										return result;
									}
									text = "Could not find the target waypoint, so could not set flightplan waypoint times.";
									result = text;
									return result;
								}
								if (!Information.IsNothing(waypoint))
								{
									waypoint.ArrivalTime_Zulu = new DateTime?(value);
									waypoint.TimeFixed = Waypoint.Enum52.const_1;
									text = "OK";
									result = text;
									return result;
								}
								if (flag)
								{
									text = "Could not find the take-off waypoint, so could not set flightplan waypoint times.";
									result = text;
									return result;
								}
								text = "Could not find the target waypoint, so could not set flightplan waypoint times.";
								result = text;
								return result;
							}
							else
							{
								text = "OK";
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200645", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
					result = text;
					return result;
				}
			}

			// Token: 0x06005463 RID: 21603 RVA: 0x0022E1E8 File Offset: 0x0022C3E8
			public static void LoadTaskDataTable(ref DataTable TaskDataTable)
			{
				if (!TaskDataTable.Columns.Contains("ID"))
				{
					TaskDataTable.Columns.Add("ID", typeof(int));
				}
				if (!TaskDataTable.Columns.Contains("Description"))
				{
					TaskDataTable.Columns.Add("Description", typeof(string));
				}
				TaskDataTable.Rows.Add(new object[]
				{
					0,
					Mission.GetTaskString(Mission._Task.Strike_Land)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					1,
					Mission.GetTaskString(Mission._Task.Strike_OffensiveCounterAir)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					2,
					Mission.GetTaskString(Mission._Task.Strike_Interdiction)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					3,
					Mission.GetTaskString(Mission._Task.Strike_SEAD)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					4,
					Mission.GetTaskString(Mission._Task.Strike_Maritime)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					5,
					Mission.GetTaskString(Mission._Task.BattlefieldAirInterdiction)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					6,
					Mission.GetTaskString(Mission._Task.CloseAirSupport)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					7,
					Mission.GetTaskString(Mission._Task.BuddyIllumination)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					8,
					Mission.GetTaskString(Mission._Task.CombatAirPatrol)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					9,
					Mission.GetTaskString(Mission._Task.BarrierCombatAirPatrol)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					10,
					Mission.GetTaskString(Mission._Task.TargetCombatAirPatrol)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					11,
					Mission.GetTaskString(Mission._Task.HighValueAssetCombatAirPatrol)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					12,
					Mission.GetTaskString(Mission._Task.RescueCombatAirPatrol)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					13,
					Mission.GetTaskString(Mission._Task.GroundLaunchedIntercept)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					14,
					Mission.GetTaskString(Mission._Task.DeckLaunchedIntercept)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					15,
					Mission.GetTaskString(Mission._Task.FighterSweep_CounterAir)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					16,
					Mission.GetTaskString(Mission._Task.SEADSweep)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					17,
					Mission.GetTaskString(Mission._Task.Escort_TARCAP)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					18,
					Mission.GetTaskString(Mission._Task.Escort_FighterSweep)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					19,
					Mission.GetTaskString(Mission._Task.Escort_SEADSweep)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					20,
					Mission.GetTaskString(Mission._Task.Escort_Support)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					21,
					Mission.GetTaskString(Mission._Task.AntiSatellite)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					22,
					Mission.GetTaskString(Mission._Task.AirborneLaser)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					23,
					Mission.GetTaskString(Mission._Task.OffensiveECM)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					24,
					Mission.GetTaskString(Mission._Task.AirborneEarlyWarning)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					25,
					Mission.GetTaskString(Mission._Task.AirborneCommandPost)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					26,
					Mission.GetTaskString(Mission._Task.ChaffLaying)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					27,
					Mission.GetTaskString(Mission._Task.SearchAndRescue)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					28,
					Mission.GetTaskString(Mission._Task.CombatSearchAndRescue)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					29,
					Mission.GetTaskString(Mission._Task.MineSweeping)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					30,
					Mission.GetTaskString(Mission._Task.MineRecon)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					31,
					Mission.GetTaskString(Mission._Task.NavalMineLaying)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					32,
					Mission.GetTaskString(Mission._Task.ASW)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					33,
					Mission.GetTaskString(Mission._Task.ForwardAirController)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					34,
					Mission.GetTaskString(Mission._Task.Surveillance)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					35,
					Mission.GetTaskString(Mission._Task.ArmedRecon)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					36,
					Mission.GetTaskString(Mission._Task.UnarmedRecon)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					37,
					Mission.GetTaskString(Mission._Task.MaritimeSurveillance)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					38,
					Mission.GetTaskString(Mission._Task.ParaDrop)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					39,
					Mission.GetTaskString(Mission._Task.TroopTransport)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					40,
					Mission.GetTaskString(Mission._Task.Cargo)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					41,
					Mission.GetTaskString(Mission._Task.AirRefuelling)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					42,
					Mission.GetTaskString(Mission._Task.Support)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					43,
					Mission.GetTaskString(Mission._Task.Training)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					44,
					Mission.GetTaskString(Mission._Task.TargetTow)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					45,
					Mission.GetTaskString(Mission._Task.TargetDrone)
				});
				TaskDataTable.Rows.Add(new object[]
				{
					46,
					Mission.GetTaskString(Mission._Task.Ferry)
				});
			}

			// Token: 0x06005464 RID: 21604 RVA: 0x0022E9CC File Offset: 0x0022CBCC
			public static Mission._Task GetTask(object object_0)
			{
				Mission._Task result = Mission._Task.const_0;
				try
				{
					switch (Conversions.ToInteger(object_0))
					{
					case 0:
						result = Mission._Task.Strike_Land;
						break;
					case 1:
						result = Mission._Task.Strike_OffensiveCounterAir;
						break;
					case 2:
						result = Mission._Task.Strike_Interdiction;
						break;
					case 3:
						result = Mission._Task.Strike_SEAD;
						break;
					case 4:
						result = Mission._Task.Strike_Maritime;
						break;
					case 5:
						result = Mission._Task.BattlefieldAirInterdiction;
						break;
					case 6:
						result = Mission._Task.CloseAirSupport;
						break;
					case 7:
						result = Mission._Task.BuddyIllumination;
						break;
					case 8:
						result = Mission._Task.CombatAirPatrol;
						break;
					case 9:
						result = Mission._Task.BarrierCombatAirPatrol;
						break;
					case 10:
						result = Mission._Task.TargetCombatAirPatrol;
						break;
					case 11:
						result = Mission._Task.HighValueAssetCombatAirPatrol;
						break;
					case 12:
						result = Mission._Task.RescueCombatAirPatrol;
						break;
					case 13:
						result = Mission._Task.GroundLaunchedIntercept;
						break;
					case 14:
						result = Mission._Task.DeckLaunchedIntercept;
						break;
					case 15:
						result = Mission._Task.FighterSweep_CounterAir;
						break;
					case 16:
						result = Mission._Task.SEADSweep;
						break;
					case 17:
						result = Mission._Task.Escort_TARCAP;
						break;
					case 18:
						result = Mission._Task.Escort_FighterSweep;
						break;
					case 19:
						result = Mission._Task.Escort_SEADSweep;
						break;
					case 20:
						result = Mission._Task.Escort_Support;
						break;
					case 21:
						result = Mission._Task.AntiSatellite;
						break;
					case 22:
						result = Mission._Task.AirborneLaser;
						break;
					case 23:
						result = Mission._Task.OffensiveECM;
						break;
					case 24:
						result = Mission._Task.AirborneEarlyWarning;
						break;
					case 25:
						result = Mission._Task.AirborneCommandPost;
						break;
					case 26:
						result = Mission._Task.ChaffLaying;
						break;
					case 27:
						result = Mission._Task.SearchAndRescue;
						break;
					case 28:
						result = Mission._Task.CombatSearchAndRescue;
						break;
					case 29:
						result = Mission._Task.MineSweeping;
						break;
					case 30:
						result = Mission._Task.MineRecon;
						break;
					case 31:
						result = Mission._Task.NavalMineLaying;
						break;
					case 32:
						result = Mission._Task.ASW;
						break;
					case 33:
						result = Mission._Task.ForwardAirController;
						break;
					case 34:
						result = Mission._Task.Surveillance;
						break;
					case 35:
						result = Mission._Task.ArmedRecon;
						break;
					case 36:
						result = Mission._Task.UnarmedRecon;
						break;
					case 37:
						result = Mission._Task.MaritimeSurveillance;
						break;
					case 38:
						result = Mission._Task.ParaDrop;
						break;
					case 39:
						result = Mission._Task.TroopTransport;
						break;
					case 40:
						result = Mission._Task.Cargo;
						break;
					case 41:
						result = Mission._Task.AirRefuelling;
						break;
					case 42:
						result = Mission._Task.Support;
						break;
					case 43:
						result = Mission._Task.Training;
						break;
					case 44:
						result = Mission._Task.TargetTow;
						break;
					case 45:
						result = Mission._Task.TargetDrone;
						break;
					case 46:
						result = Mission._Task.Ferry;
						break;
					default:
						result = Mission._Task.const_0;
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101297", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x06005465 RID: 21605 RVA: 0x0022EC2C File Offset: 0x0022CE2C
			public static int GetTaskIndex(object object_0)
			{
				int num = 0;
				int result;
				try
				{
					switch (Conversions.ToInteger(object_0))
					{
					case 1:
						num = 0;
						result = 0;
						return result;
					case 2:
						num = 4;
						result = 4;
						return result;
					case 3:
						num = 1;
						result = 1;
						return result;
					case 4:
						num = 3;
						result = 3;
						return result;
					case 5:
						num = 15;
						result = 15;
						return result;
					case 6:
						num = 16;
						result = 16;
						return result;
					case 7:
						num = 5;
						result = 5;
						return result;
					case 8:
						num = 6;
						result = 6;
						return result;
					case 9:
						num = 8;
						result = 8;
						return result;
					case 10:
						num = 10;
						result = 10;
						return result;
					case 11:
						num = 9;
						result = 9;
						return result;
					case 12:
						num = 13;
						result = 13;
						return result;
					case 13:
						num = 14;
						result = 14;
						return result;
					case 14:
						num = 18;
						result = 18;
						return result;
					case 15:
						num = 17;
						result = 17;
						return result;
					case 16:
						num = 19;
						result = 19;
						return result;
					case 17:
						num = 21;
						result = 21;
						return result;
					case 18:
						num = 22;
						result = 22;
						return result;
					case 19:
						num = 7;
						result = 7;
						return result;
					case 20:
						num = 23;
						result = 23;
						return result;
					case 21:
						num = 24;
						result = 24;
						return result;
					case 22:
						num = 25;
						result = 25;
						return result;
					case 23:
						num = 26;
						result = 26;
						return result;
					case 24:
						num = 27;
						result = 27;
						return result;
					case 25:
						num = 28;
						result = 28;
						return result;
					case 26:
						num = 29;
						result = 29;
						return result;
					case 27:
						num = 30;
						result = 30;
						return result;
					case 28:
						num = 31;
						result = 31;
						return result;
					case 29:
						num = 32;
						result = 32;
						return result;
					case 30:
						num = 33;
						result = 33;
						return result;
					case 31:
						num = 34;
						result = 34;
						return result;
					case 32:
						num = 35;
						result = 35;
						return result;
					case 33:
						num = 36;
						result = 36;
						return result;
					case 34:
						num = 37;
						result = 37;
						return result;
					case 35:
						num = 38;
						result = 38;
						return result;
					case 36:
						num = 39;
						result = 39;
						return result;
					case 37:
						num = 40;
						result = 40;
						return result;
					case 38:
						num = 41;
						result = 41;
						return result;
					case 39:
						num = 43;
						result = 43;
						return result;
					case 40:
						num = 44;
						result = 44;
						return result;
					case 41:
						num = 45;
						result = 45;
						return result;
					case 42:
						num = 46;
						result = 46;
						return result;
					case 44:
						num = 11;
						result = 11;
						return result;
					case 45:
						num = 12;
						result = 12;
						return result;
					case 46:
						num = 2;
						result = 2;
						return result;
					case 47:
						num = 42;
						result = 42;
						return result;
					case 48:
						num = 20;
						result = 20;
						return result;
					}
					num = 0;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101307", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				result = num;
				return result;
			}

			// Token: 0x06005466 RID: 21606 RVA: 0x0022EF4C File Offset: 0x0022D14C
			public static void SetDataTablePriorityData(ref DataTable dataTable_0)
			{
				if (!dataTable_0.Columns.Contains("ID"))
				{
					dataTable_0.Columns.Add("ID", typeof(int));
				}
				if (!dataTable_0.Columns.Contains("Description"))
				{
					dataTable_0.Columns.Add("Description", typeof(string));
				}
				dataTable_0.Rows.Add(new object[]
				{
					0,
					Mission.GetMandatoryPriority(Mission._Priority.Mandatory)
				});
				dataTable_0.Rows.Add(new object[]
				{
					1,
					Mission.GetMandatoryPriority(Mission._Priority.const_0)
				});
			}

			// Token: 0x06005467 RID: 21607 RVA: 0x0022F008 File Offset: 0x0022D208
			public static Mission._Priority GetPriority(object object_0)
			{
				Mission._Priority result = Mission._Priority.const_0;
				try
				{
					int num = Conversions.ToInteger(object_0);
					if (num != 0)
					{
						if (num != 1)
						{
							result = Mission._Priority.const_0;
						}
						else
						{
							result = Mission._Priority.const_0;
						}
					}
					else
					{
						result = Mission._Priority.Mandatory;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101298", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x06005468 RID: 21608 RVA: 0x0022F088 File Offset: 0x0022D288
			public static int GetPriortiyCons(object object_0)
			{
				int result = 0;
				try
				{
					int num = Conversions.ToInteger(object_0);
					if (num != 0)
					{
						if (num == 1)
						{
							result = 0;
						}
						else
						{
							result = 1;
						}
					}
					else
					{
						result = 1;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101308", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x06005469 RID: 21609 RVA: 0x0022F10C File Offset: 0x0022D30C
			public static void SetDataTableFlightSize(ref DataTable dataTable_0)
			{
				if (!dataTable_0.Columns.Contains("ID"))
				{
					dataTable_0.Columns.Add("ID", typeof(int));
				}
				if (!dataTable_0.Columns.Contains("Description"))
				{
					dataTable_0.Columns.Add("Description", typeof(string));
				}
				dataTable_0.Rows.Add(new object[]
				{
					0,
					Mission.GetFlightSizeString(Mission._FlightSize.SingleAircraft)
				});
				dataTable_0.Rows.Add(new object[]
				{
					1,
					Mission.GetFlightSizeString(Mission._FlightSize.TwoAircraft)
				});
				dataTable_0.Rows.Add(new object[]
				{
					2,
					Mission.GetFlightSizeString(Mission._FlightSize.ThreeAircraft)
				});
				dataTable_0.Rows.Add(new object[]
				{
					3,
					Mission.GetFlightSizeString(Mission._FlightSize.FourAircraft)
				});
				dataTable_0.Rows.Add(new object[]
				{
					4,
					Mission.GetFlightSizeString(Mission._FlightSize.SixAircraft)
				});
			}

			// Token: 0x0600546A RID: 21610 RVA: 0x0022F23C File Offset: 0x0022D43C
			public static Mission._FlightSize GetAircraftQty(object object_0)
			{
				Mission._FlightSize result = Mission._FlightSize.None;
				try
				{
					switch (Conversions.ToInteger(object_0))
					{
					case 0:
						result = Mission._FlightSize.SingleAircraft;
						break;
					case 1:
						result = Mission._FlightSize.TwoAircraft;
						break;
					case 2:
						result = Mission._FlightSize.ThreeAircraft;
						break;
					case 3:
						result = Mission._FlightSize.FourAircraft;
						break;
					case 4:
						result = Mission._FlightSize.SixAircraft;
						break;
					default:
						result = Mission._FlightSize.SingleAircraft;
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101299", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x0600546B RID: 21611 RVA: 0x0022F2D4 File Offset: 0x0022D4D4
			public static int AircraftQtyToIndex(object object_0)
			{
				int num = 0;
				int result;
				try
				{
					switch (Conversions.ToInteger(object_0))
					{
					case 1:
						num = 0;
						result = 0;
						return result;
					case 2:
						num = 1;
						result = 1;
						return result;
					case 3:
						num = 2;
						result = 2;
						return result;
					case 4:
						num = 3;
						result = 3;
						return result;
					case 6:
						num = 4;
						result = 4;
						return result;
					}
					num = 0;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101310", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				result = num;
				return result;
			}

			// Token: 0x0400284B RID: 10315
			public string Callsign = "";

			// Token: 0x0400284C RID: 10316
			public Mission._Task Task;

			// Token: 0x0400284D RID: 10317
			public string TakeOffLocation_HostUnitObjectID = "";

			// Token: 0x0400284E RID: 10318
			public string TakeOffLocation_HostUnitObjectName = "";

			// Token: 0x0400284F RID: 10319
			public string LandingLocation_HostUnitObjectID;

			// Token: 0x04002850 RID: 10320
			public string LandingLocation_HostUnitObjectName;

			// Token: 0x04002851 RID: 10321
			public string AlternativeLandingLocation_HostUnitObjectID;

			// Token: 0x04002852 RID: 10322
			public string AlternativeLandingLocation_HostUnitObjectName;

			// Token: 0x04002853 RID: 10323
			public bool OneTime;

			// Token: 0x04002854 RID: 10324
			public bool TimeBound;

			// Token: 0x04002855 RID: 10325
			public DateTime? EarliestTaskingTime;

			// Token: 0x04002856 RID: 10326
			public DateTime? LatestTaskingTime;

			// Token: 0x04002857 RID: 10327
			public float MaxReadyTime;

			// Token: 0x04002858 RID: 10328
			public DateTime? EarliestLaunchTime;

			// Token: 0x04002859 RID: 10329
			public DateTime? LatestLaunchTime;

			// Token: 0x0400285A RID: 10330
			public Mission._Priority Priority;

			// Token: 0x0400285B RID: 10331
			public Mission.Enum68 Status;

			// Token: 0x0400285C RID: 10332
			public Mission.Enum69 CreatedBy;

			// Token: 0x0400285D RID: 10333
			public Mission.Enum69 EditedBy;

			// Token: 0x0400285E RID: 10334
			public Mission._FlightSize DesiredAircraftQty;

			// Token: 0x0400285F RID: 10335
			public Mission._FlightSize MinimumAircraftQty;

			// Token: 0x04002860 RID: 10336
			public Mission._FlightSize AssignedAircraftQty;

			// Token: 0x04002861 RID: 10337
			public Mission._FlightSize ReadyAircraftQty;

			// Token: 0x04002862 RID: 10338
			public bool UsedByFlight;

			// Token: 0x04002863 RID: 10339
			private ActiveUnit ReferenceUnit;

			// Token: 0x04002864 RID: 10340
			public int ReferenceUnit_DBID;

			// Token: 0x04002865 RID: 10341
			public string ReferenceUnit_ObjectID;

			// Token: 0x04002866 RID: 10342
			public string ReferenceUnit_Name;

			// Token: 0x04002867 RID: 10343
			public int LoadoutDBID;

			// Token: 0x04002868 RID: 10344
			public string LoadoutName;

			// Token: 0x04002869 RID: 10345
			protected Waypoint[] FlightCourse;

			// Token: 0x0400286A RID: 10346
			protected Waypoint[] waypoint_1;

			// Token: 0x0400286B RID: 10347
			protected Waypoint[] waypoint_2;

			// Token: 0x0400286C RID: 10348
			public Mission TaskPool;

			// Token: 0x0400286D RID: 10349
			public string TaskPool_ID;

			// Token: 0x0400286E RID: 10350
			public string TaskPool_Name;

			// Token: 0x0400286F RID: 10351
			public int TaskPool_PreferredLoadoutDBID = 0;

			// Token: 0x04002870 RID: 10352
			public string TaskPool_PreferredLoadoutName;

			// Token: 0x04002871 RID: 10353
			public Mission PostTaskPool;

			// Token: 0x04002872 RID: 10354
			public string PostTaskPool_ID;

			// Token: 0x04002873 RID: 10355
			public string PostTaskPool_Name;

			// Token: 0x04002874 RID: 10356
			public int PostTaskPool_PreferredLoadoutDBID = 0;

			// Token: 0x04002875 RID: 10357
			public string PostTaskPool_PreferredLoadoutName;

			// Token: 0x04002876 RID: 10358
			public int Age;

			// Token: 0x04002877 RID: 10359
			public Contact PrimaryTarget;

			// Token: 0x04002878 RID: 10360
			public string PrimaryTarget_ID;

			// Token: 0x04002879 RID: 10361
			public bool bool_11;

			// Token: 0x0400287A RID: 10362
			public bool bool_12;

			// Token: 0x0400287B RID: 10363
			public bool bool_13;

			// Token: 0x0400287C RID: 10364
			public bool bool_14;

			// Token: 0x0400287D RID: 10365
			public string Reason;

			// Token: 0x02000A6A RID: 2666
			public enum _FlightRole : byte
			{
				// Token: 0x0400287F RID: 10367
				const_0,
				// Token: 0x04002880 RID: 10368
				const_1,
				// Token: 0x04002881 RID: 10369
				const_2,
				// Token: 0x04002882 RID: 10370
				const_3,
				// Token: 0x04002883 RID: 10371
				const_4,
				// Token: 0x04002884 RID: 10372
				const_5,
				// Token: 0x04002885 RID: 10373
				const_6,
				// Token: 0x04002886 RID: 10374
				const_7
			}
		}

		// Token: 0x02000A6B RID: 2667
		public sealed class Class131
		{
			// Token: 0x0600546C RID: 21612 RVA: 0x0022F380 File Offset: 0x0022D580
			public Class131(string string_4, string string_5, int int_2, string string_6, int int_3, string string_7)
			{
				this.string_0 = string_4;
				this.TakeOffLocation_HostUnitObjectName = string_5;
				this.int_0 = int_2;
				this.strAircraftType = string_6;
				this.int_1 = int_3;
				this.strLoadoutName = string_7;
			}

			// Token: 0x04002887 RID: 10375
			public string string_0;

			// Token: 0x04002888 RID: 10376
			public string TakeOffLocation_HostUnitObjectName;

			// Token: 0x04002889 RID: 10377
			public int int_0;

			// Token: 0x0400288A RID: 10378
			public string strAircraftType = "";

			// Token: 0x0400288B RID: 10379
			public int int_1;

			// Token: 0x0400288C RID: 10380
			public string strLoadoutName = "";
		}

		// Token: 0x02000A6C RID: 2668
		public sealed class EmptySlot
		{
			// Token: 0x0600546D RID: 21613 RVA: 0x0022F3D8 File Offset: 0x0022D5D8
			public EmptySlot()
			{
				this.Loadout_ExcludeOptionalWeapons = false;
			}

			// Token: 0x0600546E RID: 21614 RVA: 0x0022F428 File Offset: 0x0022D628
			public EmptySlot(ActiveUnit aircraft_, int aircraftDBID_, string UnitClass_, int LoadoutDBID_, string LoadoutName_, ref ActiveUnit HostUnit_, string HostUnitID_, string CurrentHostUnit_Name_)
			{
				this.Loadout_ExcludeOptionalWeapons = false;
				this.aircraft = aircraft_;
				this.aircraftDBID = aircraftDBID_;
				this.UnitClass = UnitClass_;
				this.LoadoutDBID = LoadoutDBID_;
				this.LoadoutName = LoadoutName_;
				this.HostUnit = HostUnit_;
				this.CurrentHostUnit_ObjectID = HostUnitID_;
				this.CurrentHostUnit_Name = CurrentHostUnit_Name_;
			}

			// Token: 0x0600546F RID: 21615 RVA: 0x0022F4B8 File Offset: 0x0022D6B8
			public ActiveUnit method_0(Scenario scenario_, Mission AssignedTaskPool)
			{
				if (Information.IsNothing(this.aircraft) && this.aircraftDBID > 0)
				{
					foreach (ActiveUnit current in scenario_.GetActiveUnits().Values)
					{
						if (current.IsAircraft && current.DBID == this.aircraftDBID)
						{
							Aircraft aircraft = (Aircraft)current;
							if (!Information.IsNothing(aircraft.GetLoadout()) && aircraft.GetLoadout().DBID == this.LoadoutDBID && !Information.IsNothing(aircraft.GetAircraftAirOps().GetCurrentHostUnit()) && (Information.IsNothing(this.HostUnit) || aircraft.GetAircraftAirOps().GetCurrentHostUnit() == this.HostUnit) && !Information.IsNothing(current.GetAssignedTaskPool()) && current.GetAssignedTaskPool() == AssignedTaskPool)
							{
								this.aircraft = current;
								break;
							}
						}
					}
				}
				return this.aircraft;
			}

			// Token: 0x06005470 RID: 21616 RVA: 0x00026E7C File Offset: 0x0002507C
			public void method_1(Scenario scenario_, Mission mission_, ActiveUnit activeUnit_)
			{
				this.aircraft = activeUnit_;
				if (!Information.IsNothing(activeUnit_))
				{
					this.aircraftDBID = this.aircraft.DBID;
					this.UnitClass = this.aircraft.UnitClass;
				}
			}

			// Token: 0x06005471 RID: 21617 RVA: 0x0022F5D4 File Offset: 0x0022D7D4
			public ActiveUnit GetHostUnit(Scenario scenario_)
			{
				if (Information.IsNothing(this.HostUnit) && !string.IsNullOrEmpty(this.CurrentHostUnit_ObjectID))
				{
					foreach (ActiveUnit current in scenario_.GetActiveUnits().Values)
					{
						if (Operators.CompareString(current.GetGuid(), this.CurrentHostUnit_ObjectID, false) == 0)
						{
							this.HostUnit = current;
							break;
						}
					}
				}
				return this.HostUnit;
			}

			// Token: 0x06005472 RID: 21618 RVA: 0x00026EAF File Offset: 0x000250AF
			public void SetHostUnit(Scenario scenario_, ActiveUnit activeUnit_)
			{
				this.HostUnit = activeUnit_;
			}

			// Token: 0x06005473 RID: 21619 RVA: 0x0022F66C File Offset: 0x0022D86C
			public Mission.Flight GetFlight(Scenario scenario_)
			{
				checked
				{
					if (Information.IsNothing(this.flight) && !string.IsNullOrEmpty(this.MissionFlight_ObjectID))
					{
						bool flag = false;
						Side[] sides = scenario_.GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							Side side = sides[i];
							foreach (Mission current in side.GetMissionCollection())
							{
								if (current.HasFlights())
								{
									foreach (Mission.Flight current2 in current.FlightList)
									{
										if (Operators.CompareString(current2.GetGuid(), this.MissionFlight_ObjectID, false) == 0)
										{
											this.flight = current2;
											flag = true;
											break;
										}
									}
								}
								if (flag)
								{
									break;
								}
							}
							if (flag)
							{
								break;
							}
						}
					}
					return this.flight;
				}
			}

			// Token: 0x06005474 RID: 21620 RVA: 0x00026EB8 File Offset: 0x000250B8
			public void SetFlight(Scenario scenario_, Mission.Flight Flight_)
			{
				this.flight = Flight_;
				if (!Information.IsNothing(Flight_))
				{
					this.MissionFlight_ObjectID = this.flight.GetGuid();
				}
			}

			// Token: 0x06005475 RID: 21621 RVA: 0x0022F788 File Offset: 0x0022D988
			public static void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_, ref List<Mission.EmptySlot> EmptySlotsList_)
			{
				try
				{
					xmlWriter_0.WriteStartElement("EmptySlotsList");
					foreach (Mission.EmptySlot current in EmptySlotsList_)
					{
						xmlWriter_0.WriteStartElement("EmptySlot");
						xmlWriter_0.WriteElementString("DBID", current.aircraftDBID.ToString());
						xmlWriter_0.WriteElementString("UnitClass", current.UnitClass.ToString());
						xmlWriter_0.WriteElementString("LoadoutDBID", current.LoadoutDBID.ToString());
						xmlWriter_0.WriteElementString("LoadoutName", current.LoadoutName.ToString());
						xmlWriter_0.WriteElementString("Loadout_ExcludeOptionalWeapons", current.Loadout_ExcludeOptionalWeapons.ToString());
						xmlWriter_0.WriteElementString("Loadout_QuickTurnaround", current.Loadout_QuickTurnaround.ToString());
						xmlWriter_0.WriteElementString("Loadout_QuickTurnaround_NumberOfSorties", current.Loadout_QuickTurnaround_NumberOfSorties.ToString());
						xmlWriter_0.WriteElementString("Loadout_QuickTurnaround_MaxSorties", current.Loadout_QuickTurnaround_MaxSorties.ToString());
						xmlWriter_0.WriteElementString("CurrentHostUnit_ObjectID", current.CurrentHostUnit_ObjectID.ToString());
						xmlWriter_0.WriteElementString("CurrentHostUnit_Name", current.CurrentHostUnit_Name.ToString());
						xmlWriter_0.WriteElementString("IsEscort", current.IsEscort.ToString());
						if (!string.IsNullOrEmpty(current.MissionFlight_ObjectID))
						{
							xmlWriter_0.WriteElementString("MissionFlight_ObjectID", current.MissionFlight_ObjectID.ToString());
						}
						XmlWriter xmlWriter = xmlWriter_0;
						string localName = "MissionFlight_Role";
						byte missionFlight_Role = (byte)current.MissionFlight_Role;
						xmlWriter.WriteElementString(localName, missionFlight_Role.ToString());
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteEndElement();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200646", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}

			// Token: 0x06005476 RID: 21622 RVA: 0x0022F9A4 File Offset: 0x0022DBA4
			public static List<Mission.EmptySlot> Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
			{
				List<Mission.EmptySlot> result = null;
				try
				{
					List<Mission.EmptySlot> list = new List<Mission.EmptySlot>();
					IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							XmlNode xmlNode = (XmlNode)enumerator.Current;
							string name = xmlNode.Name;
							if (Operators.CompareString(name, "EmptySlot", false) == 0)
							{
								Mission.EmptySlot emptySlot = new Mission.EmptySlot();
								IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
										string name2 = xmlNode2.Name;
										uint num = Class382.smethod_0(name2);
										if (num <= 1848783177u)
										{
											if (num <= 772711297u)
											{
												if (num != 648502632u)
												{
													if (num != 709636896u)
													{
														if (num == 772711297u && Operators.CompareString(name2, "CurrentHostUnit_ObjectID", false) == 0)
														{
															emptySlot.CurrentHostUnit_ObjectID = xmlNode2.InnerText;
														}
													}
													else if (Operators.CompareString(name2, "LoadoutDBID", false) == 0)
													{
														emptySlot.LoadoutDBID = Conversions.ToInteger(xmlNode2.InnerText);
													}
												}
												else if (Operators.CompareString(name2, "LoadoutName", false) == 0)
												{
													emptySlot.LoadoutName = xmlNode2.InnerText;
												}
											}
											else if (num != 1275478188u)
											{
												if (num != 1535121917u)
												{
													if (num == 1848783177u && Operators.CompareString(name2, "UnitClass", false) == 0)
													{
														emptySlot.UnitClass = xmlNode2.InnerText;
													}
												}
												else if (Operators.CompareString(name2, "Loadout_QuickTurnaround_NumberOfSorties", false) == 0)
												{
													emptySlot.Loadout_QuickTurnaround_NumberOfSorties = Conversions.ToInteger(xmlNode2.InnerText);
												}
											}
											else if (Operators.CompareString(name2, "CurrentHostUnit_Name", false) == 0)
											{
												emptySlot.CurrentHostUnit_Name = xmlNode2.InnerText;
											}
										}
										else if (num <= 2275586905u)
										{
											if (num != 2107721701u)
											{
												if (num != 2187602126u)
												{
													if (num == 2275586905u && Operators.CompareString(name2, "Loadout_QuickTurnaround", false) == 0)
													{
														emptySlot.Loadout_QuickTurnaround = Conversions.ToBoolean(xmlNode2.InnerText);
													}
												}
												else if (Operators.CompareString(name2, "DBID", false) == 0)
												{
													emptySlot.aircraftDBID = Conversions.ToInteger(xmlNode2.InnerText);
												}
											}
											else if (Operators.CompareString(name2, "IsEscort", false) == 0)
											{
												emptySlot.IsEscort = Conversions.ToBoolean(xmlNode2.InnerText);
											}
										}
										else if (num <= 3678242795u)
										{
											if (num != 2584924008u)
											{
												if (num == 3678242795u && Operators.CompareString(name2, "Loadout_QuickTurnaround_MaxSorties", false) == 0)
												{
													emptySlot.Loadout_QuickTurnaround_MaxSorties = Conversions.ToInteger(xmlNode2.InnerText);
												}
											}
											else if (Operators.CompareString(name2, "MissionFlight_Role", false) == 0)
											{
												emptySlot.MissionFlight_Role = (Mission.Flight._FlightRole)Conversions.ToByte(xmlNode2.InnerText);
											}
										}
										else if (num != 3767094375u)
										{
											if (num == 4045740866u && Operators.CompareString(name2, "MissionFlight_ObjectID", false) == 0)
											{
												emptySlot.MissionFlight_ObjectID = xmlNode2.InnerText;
											}
										}
										else if (Operators.CompareString(name2, "Loadout_ExcludeOptionalWeapons", false) == 0)
										{
											emptySlot.Loadout_ExcludeOptionalWeapons = Conversions.ToBoolean(xmlNode2.InnerText);
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
								list.Add(emptySlot);
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
					result = list;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200647", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x06005477 RID: 21623 RVA: 0x0022FE44 File Offset: 0x0022E044
			public void method_6(Scenario scenario_0, Mission.Flight Flight_, int int_5, int int_6)
			{
				switch (int_5)
				{
				case 0:
					this.MissionFlight_Role = Mission.Flight._FlightRole.const_0;
					break;
				case 1:
					this.MissionFlight_Role = Mission.Flight._FlightRole.const_1;
					break;
				case 2:
					this.MissionFlight_Role = Mission.Flight._FlightRole.const_2;
					break;
				case 3:
					this.MissionFlight_Role = Mission.Flight._FlightRole.const_3;
					break;
				case 4:
					this.MissionFlight_Role = Mission.Flight._FlightRole.const_4;
					break;
				case 5:
					this.MissionFlight_Role = Mission.Flight._FlightRole.const_5;
					break;
				case 6:
					this.MissionFlight_Role = Mission.Flight._FlightRole.const_6;
					break;
				default:
					this.MissionFlight_Role = Mission.Flight._FlightRole.const_7;
					break;
				}
				this.SetFlight(scenario_0, Flight_);
			}

			// Token: 0x0400288D RID: 10381
			private ActiveUnit aircraft;

			// Token: 0x0400288E RID: 10382
			public int aircraftDBID;

			// Token: 0x0400288F RID: 10383
			public string UnitClass;

			// Token: 0x04002890 RID: 10384
			public int LoadoutDBID;

			// Token: 0x04002891 RID: 10385
			public string LoadoutName;

			// Token: 0x04002892 RID: 10386
			public bool Loadout_ExcludeOptionalWeapons;

			// Token: 0x04002893 RID: 10387
			public bool Loadout_QuickTurnaround;

			// Token: 0x04002894 RID: 10388
			public int Loadout_QuickTurnaround_NumberOfSorties = 0;

			// Token: 0x04002895 RID: 10389
			public int Loadout_QuickTurnaround_MaxSorties = 0;

			// Token: 0x04002896 RID: 10390
			private Mission.Flight flight;

			// Token: 0x04002897 RID: 10391
			public string MissionFlight_ObjectID = "";

			// Token: 0x04002898 RID: 10392
			public Mission.Flight._FlightRole MissionFlight_Role;

			// Token: 0x04002899 RID: 10393
			private ActiveUnit HostUnit;

			// Token: 0x0400289A RID: 10394
			public string CurrentHostUnit_ObjectID = "";

			// Token: 0x0400289B RID: 10395
			public string CurrentHostUnit_Name = "";

			// Token: 0x0400289C RID: 10396
			public int int_4;

			// Token: 0x0400289D RID: 10397
			public bool IsEscort = false;
		}
	}
}

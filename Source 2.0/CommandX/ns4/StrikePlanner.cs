using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns3;

namespace ns4
{
	// Token: 0x02000CB9 RID: 3257
	public sealed class StrikePlanner
	{
		// Token: 0x06006B6F RID: 27503 RVA: 0x003AA38C File Offset: 0x003A858C
		public static void smethod_0(Scenario scenario_, Mission mission_, ref Collection<ActiveUnit> ActiveUnitCollection_, bool bFeedback)
		{
			StrikePlanner.StrikeMission strikeMission = new StrikePlanner.StrikeMission(null);
			strikeMission.theInstance = mission_;
			try
			{
				if (strikeMission.theInstance.MissionClass == Mission._MissionClass.Strike)
				{
					Strike strike = (Strike)strikeMission.theInstance;
					if (strike.strikeType != Strike.StrikeType.Air_Intercept)
					{
						Doctrine._UseRefuel? useRefuelDoctrine = strikeMission.theInstance.m_Doctrine.GetUseRefuelDoctrine(scenario_, false, false, false, false);
						StrikePlanner.UsePathfinderToFindRoute = null;
						List<Aircraft> list = new List<Aircraft>();
						foreach (ActiveUnit current in ActiveUnitCollection_)
						{
							StrikePlanner.TargetFilter targetFilter = new StrikePlanner.TargetFilter(null);
							targetFilter.strikeMission = strikeMission;
							if (!Information.IsNothing(current) && (current.IsAircraft || current.IsGroup))
							{
								current.GetKinematics().SetBingoJokerFuel();
								if (current.IsAircraft && current.GetAI().IsEscort)
								{
									list.Add((Aircraft)current);
								}
								else
								{
									float num = 0f;
									targetFilter.aircraft = null;
									Group group = null;
									if (current.IsGroup)
									{
										Group group2 = (Group)current;
										if (Information.IsNothing(group2.GetGroupLead()) || !group2.GetGroupLead().IsAircraft)
										{
											continue;
										}
										targetFilter.aircraft = (Aircraft)group2.GetGroupLead();
										group = group2;
										using (IEnumerator<ActiveUnit> enumerator2 = group2.GetUnitsInGroup().Values.GetEnumerator())
										{
											while (enumerator2.MoveNext())
											{
												ActiveUnit current2 = enumerator2.Current;
												list.Add((Aircraft)current2);
											}
											goto IL_1F2;
										}
									}
									if (current.HasParentGroup())
									{
										if (!current.IsGroupLead())
										{
											continue;
										}
										targetFilter.aircraft = (Aircraft)current;
										group = current.GetParentGroup(false);
										list.Add(targetFilter.aircraft);
									}
									else
									{
										targetFilter.aircraft = (Aircraft)current;
										list.Add(targetFilter.aircraft);
									}
									IL_1F2:
									if (!Information.IsNothing(targetFilter.aircraft))
									{
										float num2 = 0f;
										bool flag = true;
										targetFilter.ShootTouristsDoc = targetFilter.aircraft.m_Doctrine.GetShootTouristsDoctrine(targetFilter.aircraft.m_Scenario, false, false, false);
										List<Contact> list2 = new List<Contact>();
										list2.AddRange(targetFilter.aircraft.GetSide(false).GetContactObservableDictionary().Values);
										if (!strike.PrePlannedOnly || strike.SpecificTargets.Count != 0)
										{
											if (Information.IsNothing(targetFilter.aircraft.GetAircraftAirOps().GetAssignedHostUnit(false)))
											{
												targetFilter.aircraft.GetAircraftAirOps().AssignNewHostUnit();
												if (Information.IsNothing(targetFilter.aircraft.GetAircraftAirOps().GetAssignedHostUnit(false)))
												{
													if (bFeedback)
													{
														Interaction.MsgBox("Could not find a suitable host base/ship for " + targetFilter.aircraft.Name + " and can therefore not create a flight plan for strike mission.", MsgBoxStyle.OkOnly, null);
														continue;
													}
													continue;
												}
											}
											Mission.Flight flight = null;
											string text = "";
											if (strike.SpecificTargets.Count > 0)
											{
												using (List<Contact>.Enumerator enumerator3 = list2.GetEnumerator())
												{
													while (enumerator3.MoveNext())
													{
														Contact current3 = enumerator3.Current;
														if (current3.IsSpecificTargetForStikeMission(strike) && targetFilter.aircraft.GetAircraftAI().method_23(ref strike, current3.GetPostureStance(targetFilter.aircraft.GetSide(false))))
														{
															Aircraft_AirOps aircraftAirOps = targetFilter.aircraft.GetAircraftAirOps();
															StrikePlanner.StrikeMission strikeMission2 = targetFilter.strikeMission;
															Mission.Flight flight2 = null;
															flight = new Mission.Flight(ref scenario_, ref strikeMission2.theInstance, ref flight2, CallsignGenerator.GenerateCallsignString(ref targetFilter.strikeMission.theInstance), aircraftAirOps.GetAssignedHostUnit(false).GetGuid(), aircraftAirOps.GetAssignedHostUnit(false).Name, targetFilter.aircraft.GetLoadout().DBID, current3, targetFilter.aircraft);
															ActiveUnit_AI aircraftAI = targetFilter.aircraft.GetAircraftAI();
															StrikePlanner.TargetFilter targetFilter2 = targetFilter;
															Strike.StrikeType strikeType = Strike.StrikeType.Land_Strike;
															int minResponseRadius = strike.MinResponseRadius;
															int maxResponseRadius = strike.MaxResponseRadius;
															Doctrine._UseRefuel? useRefuel_ = useRefuelDoctrine;
															bool launchMissionWithoutTankersInPlace = targetFilter.strikeMission.theInstance.LaunchMissionWithoutTankersInPlace;
															Mission._RadarBehaviour radarBehaviour = strike.RadarBehaviour;
															bool useAutoPlanner = strike.UseAutoPlanner;
															Mission mission = null;
															if (aircraftAI.method_22(ref flight, ref targetFilter2.aircraft, ref current3, ref strikeType, minResponseRadius, maxResponseRadius, useRefuel_, launchMissionWithoutTankersInPlace, radarBehaviour, true, true, true, useAutoPlanner, ref num2, ref text, ref mission))
															{
																flag = false;
															}
															if (!flag)
															{
																break;
															}
														}
													}
													goto IL_619;
												}
												goto IL_4A8;
											}
											goto IL_4A8;
											IL_619:
											Waypoint[] array;
											if (flag || Information.IsNothing(null))
											{
												if (bFeedback)
												{
													targetFilter.aircraft.DeleteMission(false, null);
													Interaction.MsgBox(string.Concat(new string[]
													{
														"Aircraft ",
														targetFilter.aircraft.Name,
														" has not been added to mission. Reason: ",
														text,
														" Check that there are not No-Navigation Zones too close to the target or the landing marshal point."
													}), MsgBoxStyle.OkOnly, null);
													continue;
												}
												Aircraft_Navigator aircraftNavigator = targetFilter.aircraft.GetAircraftNavigator();
												array = aircraftNavigator.GetPlottedCourse();
												ScenarioArrayUtil.ClearWaypoints(ref array);
												aircraftNavigator.SetPlottedCourse(array);
											}
											if (flight.GetFlightCourse().Count<Waypoint>() != 0 || flight.GetWaypoint1().Count<Waypoint>() <= 0 || flight.GetWaypoint1().Count<Waypoint>() != 0)
											{
												if (!Information.IsNothing(group))
												{
													bool flag2 = true;
													foreach (ActiveUnit current4 in group.GetUnitsInGroup().Values)
													{
														if (current4 != targetFilter.aircraft)
														{
															FuelRec[] fuelRecs = current4.GetFuelRecs();
															float num3 = 0f;
															for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
															{
																FuelRec fuelRec = fuelRecs[i];
																num3 += fuelRec.CurrentQuantity;
															}
															float reserveFuel = current4.GetKinematics().GetReserveFuel();
															if (num3 - reserveFuel < num2 && Interaction.MsgBox("Not all members of group " + group.Name + " have enough fuel for flightplan. The units have been added to mission but will likely bingo before reaching target. Do you want create a flight plan for the group? WARNING! Only do this if the aircraft are air refuelling capable and you have enough tankers available!", MsgBoxStyle.YesNo, null) == MsgBoxResult.No)
															{
																flag2 = false;
																break;
															}
														}
													}
													if (!flag2)
													{
														continue;
													}
												}
												int num4;
												checked
												{
													if (flight.GetWaypoint1().Count<Waypoint>() > 0 && flight.GetFlightCourse().Count<Waypoint>() == 0)
													{
														array = flight.GetWaypoint1();
														Waypoint[] array2;
														for (int j = 0; j < array.Length; j++)
														{
															Waypoint waypoint = array[j];
															Mission.Flight flight3 = flight;
															array2 = flight3.GetFlightCourse();
															ScenarioArrayUtil.AddWaypoint(ref array2, waypoint.method_23(ref scenario_, ref waypoint, true, true));
															flight3.SetFlightCourse(array2);
														}
														Mission.Flight flight4 = flight;
														array2 = flight4.GetWaypoint1();
														ScenarioArrayUtil.ClearWaypoints(ref array2);
														flight4.SetWaypoint1(array2);
													}
													if (flight.GetFlightCourse().Count<Waypoint>() > 0)
													{
														Aircraft_Navigator aircraftNavigator2 = targetFilter.aircraft.GetAircraftNavigator();
														Waypoint[] array3 = aircraftNavigator2.GetPlottedCourse();
														ScenarioArrayUtil.ClearWaypoints(ref array3);
														aircraftNavigator2.SetPlottedCourse(array3);
														array3 = flight.GetFlightCourse();
														for (int k = 0; k < array3.Length; k++)
														{
															Waypoint waypoint2 = array3[k];
															if (waypoint2.waypointType != Waypoint.WaypointType.TakeOff && waypoint2.waypointType != Waypoint.WaypointType.Assemble)
															{
																Aircraft_Navigator aircraftNavigator3 = targetFilter.aircraft.GetAircraftNavigator();
																Waypoint[] plottedCourse = aircraftNavigator3.GetPlottedCourse();
																ScenarioArrayUtil.AddWaypoint(ref plottedCourse, waypoint2);
																aircraftNavigator3.SetPlottedCourse(plottedCourse);
															}
														}
													}
													targetFilter.strikeMission.theInstance.FlightList.Add(flight);
													num4 = 2;
												}
												if (targetFilter.aircraft.HasParentGroup())
												{
													using (IEnumerator<ActiveUnit> enumerator5 = targetFilter.aircraft.GetParentGroup(false).GetUnitsInGroup().Values.GetEnumerator())
													{
														while (enumerator5.MoveNext())
														{
															ActiveUnit current5 = enumerator5.Current;
															if (current5.IsGroupLead())
															{
																current5.method_114(flight, 1);
																targetFilter.aircraft.GetParentGroup(false).Name = "Flight " + flight.Callsign;
															}
															else
															{
																current5.method_114(flight, num4);
																num4++;
															}
														}
														targetFilter.aircraft.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_, false, new bool?(false), false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
														continue;
													}
												}
												targetFilter.aircraft.GetAircraftNavigator().SetFlight(flight);
												targetFilter.aircraft.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_, false, new bool?(false), false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
												continue;
											}
											if (bFeedback)
											{
												targetFilter.aircraft.DeleteMission(false, null);
												Interaction.MsgBox("Attempt to create a flight plan around No-Navigation Zones for " + targetFilter.aircraft.Name + " failed.", MsgBoxStyle.OkOnly, null);
											}
											Aircraft_Navigator aircraftNavigator4 = targetFilter.aircraft.GetAircraftNavigator();
											array = aircraftNavigator4.GetPlottedCourse();
											ScenarioArrayUtil.ClearWaypoints(ref array);
											aircraftNavigator4.SetPlottedCourse(array);
											continue;
                                        IL_4A8:
                                            List<Contact> list3 = list2.Where(new Func<Contact, bool>(targetFilter.IsTargetForMyMission)).ToList<Contact>();
                                            Contact current6X;
                                            foreach (Contact current6 in list3)
											{
												if (targetFilter.aircraft.GetAircraftAI().method_23(ref strike, current6.GetPostureStance(targetFilter.aircraft.GetSide(false))))
												{
													Aircraft_AirOps aircraftAirOps2 = targetFilter.aircraft.GetAircraftAirOps();
													StrikePlanner.StrikeMission strikeMission3 = targetFilter.strikeMission;
													Mission.Flight flight5 = null;
													flight = new Mission.Flight(ref scenario_, ref strikeMission3.theInstance, ref flight5, CallsignGenerator.GenerateCallsignString(ref targetFilter.strikeMission.theInstance), aircraftAirOps2.GetAssignedHostUnit(false).GetGuid(), aircraftAirOps2.GetAssignedHostUnit(false).Name, targetFilter.aircraft.GetLoadout().DBID, current6, targetFilter.aircraft);
													ActiveUnit_AI aircraftAI2 = targetFilter.aircraft.GetAircraftAI();
													StrikePlanner.TargetFilter targetFilter3 = targetFilter;
													Strike.StrikeType strikeType = Strike.StrikeType.Land_Strike;
													int minResponseRadius2 = strike.MinResponseRadius;
													int maxResponseRadius2 = strike.MaxResponseRadius;
													Doctrine._UseRefuel? useRefuel_2 = useRefuelDoctrine;
													bool launchMissionWithoutTankersInPlace2 = targetFilter.strikeMission.theInstance.LaunchMissionWithoutTankersInPlace;
													Mission._RadarBehaviour radarBehaviour2 = strike.RadarBehaviour;
													bool useAutoPlanner2 = strike.UseAutoPlanner;
													Mission mission = null;
                                                    current6X = current6;

                                                    if (aircraftAI2.method_22(ref flight, ref targetFilter3.aircraft, ref current6X, ref strikeType, minResponseRadius2, maxResponseRadius2, useRefuel_2, launchMissionWithoutTankersInPlace2, radarBehaviour2, true, true, true, useAutoPlanner2, ref num, ref text, ref mission))
													{
														flag = false;
													}
													if (!flag)
													{
														break;
													}
												}
											}
											goto IL_619;
										}
										if (bFeedback)
										{
											Interaction.MsgBox("Aircraft " + targetFilter.aircraft.Name + " has not been added to mission. Reason: The mission is only allowed to attack pre-planned targets, and no targets remain. To resolve this issue, either remove the 'Pre-Planned Targets Only' flag, or add targets to the mission's target list.", MsgBoxStyle.OkOnly, null);
										}
									}
								}
							}
						}
						foreach (Aircraft current7 in list)
						{
							if (current7.IsGroupLead())
							{
								current7.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
								current7.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
								current7.GetAircraftAI().UpdateUnitStatus(0f, false, false);
							}
						}
						foreach (Aircraft current8 in list)
						{
							if (!current8.IsGroupLead())
							{
								current8.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
								current8.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
								current8.GetAircraftAI().UpdateUnitStatus(0f, false, false);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200628", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B70 RID: 27504 RVA: 0x003AB008 File Offset: 0x003A9208
		public static bool CreateFlightplan(ref Mission.Flight Flight_, ref Aircraft aircraft_, bool? nullable_1, Contact contact_0, Mission._RadarBehaviour enum63_0, ref bool bool_0, bool bool_1, bool bool_2, bool bool_3, ref float float_0, ref string string_0, ref Mission mission_0)
		{
			bool flag = false;
			bool result;
			if (Information.IsNothing(aircraft_.GetAssignedMission(false)))
			{
				string_0 = "The aircraft's assigned mission does not exist. No flightplan has been created.";
				flag = false;
			}
			else if (aircraft_.GetAssignedMission(false).MissionClass != Mission._MissionClass.Strike)
			{
				string_0 = "The mission is not a strike mission. No flightplan has been created.";
				flag = false;
			}
			else
			{
				try
				{
					if (!Information.IsNothing(aircraft_.GetLoadout()) && !Information.IsNothing(aircraft_.GetLoadout().GetMissionProfile(aircraft_.m_Scenario)))
					{
						Weapon weapon = aircraft_.GetAircraftWeaponry().method_19(contact_0, false, true, aircraft_.m_Doctrine);
						if (Information.IsNothing(weapon))
						{
							string_0 = "Could not determine the most suitable weapon. Are the aircraft loaded with correct weapons for the mission type? No flightplan has been created.";
							flag = false;
							result = false;
							return result;
						}
						Strike strike = (Strike)aircraft_.GetAssignedMission(false);
						if (strike.strikeType == Strike.StrikeType.Sub_Strike)
						{
							flag = true;
							result = true;
							return result;
						}
						float num = 0.2f;
						float horizontalRange = aircraft_.GetHorizontalRange(contact_0);
						LoadoutMissionProfile missionProfile = aircraft_.GetLoadout().GetMissionProfile(aircraft_.m_Scenario);
						float maxRangeToTarget = weapon.GetMaxRangeToTarget(aircraft_, contact_0, true, aircraft_.m_Doctrine, false);
						float num2 = Math.Max(5f, maxRangeToTarget);
						float num3 = (float)GameGeneral.GetRandom().Next(-45, 45);
						float maxRangeToTarget2 = weapon.GetMaxRangeToTarget(aircraft_, contact_0, true, aircraft_.m_Doctrine, false);
						float num4 = horizontalRange - Math.Max(maxRangeToTarget2, 5f);
						Waypoint._FlightFormation flightFormation = Waypoint._FlightFormation.Spread;
						float num5 = 0f;
						float num6 = 0f;
						float float_ = 0f;
						switch (strike.AttackMethod)
						{
						case Mission._AttackMethod.const_2:
						case Mission._AttackMethod.const_3:
							num5 = 0f;
							num6 = 0f;
							float_ = 6f;
							break;
						case Mission._AttackMethod.const_4:
						case Mission._AttackMethod.const_5:
						case Mission._AttackMethod.const_6:
						case Mission._AttackMethod.const_7:
						case Mission._AttackMethod.const_8:
						case Mission._AttackMethod.const_9:
						case Mission._AttackMethod.const_10:
							switch (strike.SplitDistance)
							{
							case Mission._SplitDistance.const_0:
								num5 = 10f;
								num6 = 5f;
								break;
							case Mission._SplitDistance.const_1:
								num5 = 20f;
								num6 = 10f;
								break;
							case Mission._SplitDistance.const_2:
								num5 = 50f;
								num6 = 20f;
								break;
							}
							float_ = StrikePlanner.smethod_44(strike.AttackMethod);
							break;
						case Mission._AttackMethod.const_11:
							num5 = 15f;
							num6 = 8f;
							float_ = StrikePlanner.smethod_44(strike.AttackMethod);
							break;
						default:
							num5 = 0f;
							num6 = 0f;
							float_ = 0f;
							break;
						}
						bool flag2 = false;
						Misc.Enum102 @enum = (Misc.Enum102)0;
						float float_2 = 0f;
						if (Flight_.GetWaypoint1().Count<Waypoint>() == 0)
						{
							Aircraft_AirOps aircraftAirOps = aircraft_.GetAircraftAirOps();
							GeoPoint geoPoint;
							if (!aircraft_.IsRotaryWingAircraft())
							{
								if (!Information.IsNothing(aircraftAirOps.GetAssignedHostUnit()))
								{
									geoPoint = aircraftAirOps.GetAssignedHostUnit().GetAirOps().method_5();
								}
								else
								{
									geoPoint = new GeoPoint(aircraft_.GetLongitude(null), aircraft_.GetLatitude(null));
								}
							}
							else if (!Information.IsNothing(aircraftAirOps.GetAssignedHostUnit()))
							{
								geoPoint = new GeoPoint(aircraftAirOps.GetAssignedHostUnit().GetLongitude(null), aircraftAirOps.GetAssignedHostUnit().GetLatitude(null));
							}
							else
							{
								geoPoint = new GeoPoint(aircraft_.GetLongitude(null), aircraft_.GetLatitude(null));
							}
							GeoPoint geoPoint2;
							if (!Information.IsNothing(aircraftAirOps.GetAssignedHostUnit()))
							{
								geoPoint2 = new GeoPoint(aircraftAirOps.GetAssignedHostUnit().GetLongitude(null), aircraftAirOps.GetAssignedHostUnit().GetLatitude(null));
							}
							else
							{
								geoPoint2 = new GeoPoint(aircraft_.GetLongitude(null), aircraft_.GetLatitude(null));
							}
							GeoPoint geoPoint3;
							if (!Information.IsNothing(aircraftAirOps.GetAssignedHostUnit()))
							{
								geoPoint3 = new GeoPoint(aircraftAirOps.GetAssignedHostUnit().GetLongitude(null), aircraftAirOps.GetAssignedHostUnit().GetLatitude(null));
							}
							else
							{
								geoPoint3 = new GeoPoint(aircraft_.GetLongitude(null), aircraft_.GetLatitude(null));
							}
							float num7;
							float num8;
							if (bool_3)
							{
								if (maxRangeToTarget < 6f)
								{
									num7 = (float)GameGeneral.GetRandom().Next(-85, 85);
									num8 = (float)GameGeneral.GetRandom().Next(-85, 85);
								}
								else if (maxRangeToTarget < 15f)
								{
									num7 = (float)GameGeneral.GetRandom().Next(-65, 65);
									if (num7 > 0f)
									{
										num8 = num7 - 5f;
									}
									else
									{
										num8 = num7 + 5f;
									}
								}
								else if (maxRangeToTarget < 60f)
								{
									num7 = (float)GameGeneral.GetRandom().Next(-45, 45);
									if (num7 > 0f)
									{
										num8 = num7 - 5f;
									}
									else
									{
										num8 = num7 + 5f;
									}
								}
								else if (maxRangeToTarget < 150f)
								{
									num7 = (float)GameGeneral.GetRandom().Next(-30, 30);
									if (num7 > 0f)
									{
										num8 = num7 - 5f;
									}
									else
									{
										num8 = num7 + 5f;
									}
								}
								else
								{
									num7 = (float)GameGeneral.GetRandom().Next(-20, 20);
									if (num7 > 0f)
									{
										num8 = num7 - 5f;
									}
									else
									{
										num8 = num7 + 5f;
									}
								}
								if (maxRangeToTarget < 6f)
								{
									if (num7 * num8 > 0f)
									{
										num8 = -num8;
									}
								}
								else if (num7 * num8 <= 0f)
								{
									num8 = -num8;
								}
								if (num7 > 0f)
								{
									if (num7 < 2f)
									{
										num7 = 2f;
									}
								}
								else if (num7 > -2f)
								{
									num7 = -2f;
								}
								if (num8 > 0f)
								{
									if (num8 < 2f)
									{
										num8 = 2f;
									}
								}
								else if (num8 > -2f)
								{
									num8 = -2f;
								}
							}
							else
							{
								int num9 = GameGeneral.GetRandom().Next(1, 2);
								if (num9 == 1)
								{
									num7 = -2f;
									num8 = 2f;
								}
								else
								{
									num7 = 2f;
									num8 = -2f;
								}
							}
							if (num4 < (float)missionProfile.AttackDistanceIngress)
							{
								while (!flag2)
								{
									Mission.Flight flight = Flight_;
									Waypoint[] array = flight.GetFlightCourse();
									ScenarioArrayUtil.ClearWaypoints(ref array);
									flight.SetFlightCourse(array);
									float num10;
									if (num4 < 20f && num4 > 0f)
									{
										num10 = num4 / 2f;
									}
									else
									{
										num10 = 10f;
									}
									float azimuth;
									if (bool_2)
									{
										azimuth = Math2.GetAzimuth(aircraft_.GetLatitude(null), aircraft_.GetLongitude(null), contact_0.GetLatitude(null), contact_0.GetLongitude(null));
									}
									else
									{
										azimuth = Math2.GetAzimuth(geoPoint2.GetLatitude(), geoPoint2.GetLongitude(), contact_0.GetLatitude(null), contact_0.GetLongitude(null));
									}
									Waypoint waypoint_ = null;
									Aircraft aircraft_2 = aircraft_;
									Mission.Flight flight2;
									array = (flight2 = Flight_).GetFlightCourse();
									float num11 = 0f;
									float num12 = 0f;
									bool flag3 = false;
									ActiveUnit_Kinematics._SpeedPreset speedPreset = ActiveUnit_Kinematics._SpeedPreset.FullStop;
									float num13 = 0f;
									StrikePlanner.smethod_30(waypoint_, aircraft_2, ref array, geoPoint2.GetLatitude(), geoPoint2.GetLongitude(), missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
									flight2.SetFlightCourse(array);
									double num14 = 0.0;
									double num15 = 0.0;
									if (num4 > 0f)
									{
										GeoPointGenerator.GetOtherGeoPoint(geoPoint2.GetLongitude(), geoPoint2.GetLatitude(), ref num14, ref num15, (double)num10, (double)Math2.Normalize(azimuth + num3));
									}
									else
									{
										GeoPointGenerator.GetOtherGeoPoint(geoPoint2.GetLongitude(), geoPoint2.GetLatitude(), ref num14, ref num15, (double)num10, (double)Math2.Normalize(azimuth + 180f + num3));
									}
									Waypoint waypoint_2 = null;
									Aircraft aircraft_3 = aircraft_;
									array = (flight2 = Flight_).GetFlightCourse();
									StrikePlanner.smethod_21(waypoint_2, aircraft_3, ref array, num15, num14, missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
									flight2.SetFlightCourse(array);
									if (bool_2)
									{
										azimuth = Math2.GetAzimuth(aircraft_.GetLatitude(null), aircraft_.GetLongitude(null), contact_0.GetLatitude(null), contact_0.GetLongitude(null));
									}
									else
									{
										azimuth = Math2.GetAzimuth(num15, num14, contact_0.GetLatitude(null), contact_0.GetLongitude(null));
									}
									float azimuth2 = Math2.GetAzimuth(contact_0.GetLatitude(null), contact_0.GetLongitude(null), geoPoint.GetLatitude(), geoPoint.GetLongitude());
									float distance;
									if (bool_2)
									{
										distance = Math2.GetDistance(aircraft_.GetLatitude(null), aircraft_.GetLongitude(null), contact_0.GetLatitude(null), contact_0.GetLongitude(null));
									}
									else
									{
										distance = Math2.GetDistance(num15, num14, contact_0.GetLatitude(null), contact_0.GetLongitude(null));
									}
									if (num4 > 0f)
									{
										if (distance < num2)
										{
											if (distance < 20f)
											{
												num2 = distance / 2f;
											}
											else
											{
												num2 = 10f;
											}
										}
									}
									else if (distance < 20f)
									{
										num2 = distance / 2f;
									}
									else
									{
										num2 = distance - 10f;
									}
									double num16 = 0.0;
									double num17 = 0.0;
									GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num16, ref num17, (double)num2, (double)Math2.Normalize(azimuth + 180f + num7));
									float num18 = distance - num2;
									float num19;
									if (num18 < 40f)
									{
										num19 = num18 / 2f;
									}
									else
									{
										num19 = num18 - 20f;
									}
									bool flag5;
									if (num5 > 0f && num5 >= num19)
									{
										array = (flight2 = Flight_).GetFlightCourse();
										float float_3 = num5;
										float float_4 = num6;
										float float_5 = azimuth;
										float float_6 = num2;
										Mission._RadarBehaviour enum63_ = enum63_0;
										float float_7 = num7;
										LoadoutMissionProfile class85_ = missionProfile;
										float float_8 = maxRangeToTarget;
										Waypoint waypoint = null;
										Waypoint waypoint2 = null;
										bool flag4 = StrikePlanner.smethod_4(ref strike, ref Flight_, ref array, ref aircraft_, ref contact_0, ref num4, float_3, float_4, float_5, float_6, ref flightFormation, ref num13, enum63_, ref num11, ref num12, ref flag3, ref speedPreset, float_7, class85_, float_8, bool_2, true, true, ref waypoint, ref waypoint2);
										flight2.SetFlightCourse(array);
										flag5 = flag4;
									}
									else
									{
										flag5 = false;
									}
									double num20 = 0.0;
									double num21 = 0.0;
									if (!flag5)
									{
										if (bool_2)
										{
											num20 = aircraft_.GetLatitude(null);
											num21 = aircraft_.GetLongitude(null);
										}
										else
										{
											float num22 = Math2.GetDistance(num15, num14, num17, num16);
											if (num22 < 40f)
											{
												num22 /= 2f;
											}
											else
											{
												num22 = 20f;
											}
											GeoPointGenerator.GetOtherGeoPoint(num14, num15, ref num21, ref num20, (double)num22, (double)Math2.Normalize(azimuth + num3));
										}
										Waypoint waypoint_3 = null;
										Aircraft aircraft_4 = aircraft_;
										array = (flight2 = Flight_).GetFlightCourse();
										StrikePlanner.smethod_22(waypoint_3, aircraft_4, ref array, num20, num21, missionProfile, enum63_0, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
										flight2.SetFlightCourse(array);
									}
									if (!flag5)
									{
										array = (flight2 = Flight_).GetFlightCourse();
										float float_9 = num5;
										float float_10 = num6;
										float float_11 = azimuth;
										float float_12 = num2;
										Mission._RadarBehaviour enum63_2 = enum63_0;
										float float_13 = num7;
										LoadoutMissionProfile class85_2 = missionProfile;
										float float_14 = maxRangeToTarget;
										Waypoint waypoint2 = null;
										Waypoint waypoint = null;
										bool flag6 = StrikePlanner.smethod_4(ref strike, ref Flight_, ref array, ref aircraft_, ref contact_0, ref num4, float_9, float_10, float_11, float_12, ref flightFormation, ref num13, enum63_2, ref num11, ref num12, ref flag3, ref speedPreset, float_13, class85_2, float_14, bool_2, true, false, ref waypoint2, ref waypoint);
										flight2.SetFlightCourse(array);
										flag5 = flag6;
									}
									Waypoint waypoint_4 = null;
									Aircraft aircraft_5 = aircraft_;
									array = (flight2 = Flight_).GetFlightCourse();
									StrikePlanner.smethod_25(waypoint_4, aircraft_5, ref array, num17, num16, missionProfile, enum63_0, maxRangeToTarget, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref strike.AttackMethod, ref flightFormation);
									flight2.SetFlightCourse(array);
									Waypoint waypoint_5 = null;
									Aircraft aircraft_6 = aircraft_;
									array = (flight2 = Flight_).GetFlightCourse();
									StrikePlanner.smethod_26(waypoint_5, aircraft_6, ref array, contact_0.GetLatitude(null), contact_0.GetLongitude(null), missionProfile, enum63_0, maxRangeToTarget, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref strike.AttackMethod, ref flightFormation);
									flight2.SetFlightCourse(array);
									float distance2 = Math2.GetDistance(contact_0.GetLatitude(null), contact_0.GetLongitude(null), geoPoint.GetLatitude(), geoPoint.GetLongitude());
									float azimuth3 = Math2.GetAzimuth(contact_0.GetLatitude(null), contact_0.GetLongitude(null), geoPoint.GetLatitude(), geoPoint.GetLongitude());
									float num23;
									if (bool_2 && distance2 > (float)(missionProfile.AttackDistanceEgress + 10))
									{
										num23 = (float)missionProfile.AttackDistanceEgress;
									}
									else
									{
										num23 = num19;
									}
									float num24;
									if (bool_2)
									{
										num24 = Math2.Normalize(Math2.GetAzimuth(geoPoint.GetLatitude(), geoPoint.GetLongitude(), contact_0.GetLatitude(null), contact_0.GetLongitude(null)) + 180f);
									}
									else
									{
										num24 = Math2.Normalize(azimuth2 + 180f);
									}
									double num25 = 0.0;
									double num26 = 0.0;
									if (maxRangeToTarget < 6f)
									{
										GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num25, ref num26, (double)num23, (double)Math2.Normalize(num24 + 180f + num8));
									}
									else
									{
										GeoPointGenerator.GetOtherGeoPoint(num16, num17, ref num25, ref num26, (double)num23, (double)Math2.Normalize(num24 + 180f + num8));
									}
									float num27 = 0f;
									if (strike.AttackMethod >= Mission._AttackMethod.const_2)
									{
										float azimuth4 = Math2.GetAzimuth(geoPoint2.GetLatitude(), geoPoint2.GetLongitude(), num20, num21);
										float azimuth5 = Math2.GetAzimuth(num20, num21, num26, num25);
										@enum = Misc.smethod_63(azimuth4, azimuth5);
										if (@enum != Misc.Enum102.const_0)
										{
											if (@enum == Misc.Enum102.const_1)
											{
												num27 = 270f;
											}
										}
										else
										{
											num27 = 90f;
										}
									}
									bool flag8;
									if (num5 > 0f && num5 < num23 && flag5)
									{
										array = (flight2 = Flight_).GetFlightCourse();
										double double_ = num17;
										double double_2 = num16;
										float float_15 = num23;
										float float_16 = maxRangeToTarget;
										float float_17 = azimuth2;
										float float_18 = num4;
										float float_19 = num5;
										float float_20 = num6;
										float float_21 = num27;
										float float_22 = num8;
										LoadoutMissionProfile class85_3 = missionProfile;
										Waypoint waypoint = null;
										Waypoint waypoint2 = null;
										bool flag7 = StrikePlanner.smethod_5(ref strike, ref Flight_, ref array, ref aircraft_, ref contact_0, double_, double_2, float_15, float_16, float_17, float_18, float_19, float_20, ref flightFormation, ref num13, ref num11, ref num12, ref flag3, ref speedPreset, float_21, float_22, class85_3, bool_2, false, ref waypoint, ref waypoint2);
										flight2.SetFlightCourse(array);
										flag8 = flag7;
									}
									else
									{
										flag8 = false;
									}
									if (num5 == 0f || num5 < num23)
									{
										if (bool_2)
										{
											if (distance2 > num23 + num2)
											{
												if (maxRangeToTarget < 6f)
												{
													GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num25, ref num26, (double)num23, (double)Math2.Normalize(azimuth3));
												}
												else
												{
													GeoPointGenerator.GetOtherGeoPoint(num16, num17, ref num25, ref num26, (double)num23, (double)Math2.Normalize(azimuth3));
												}
												Waypoint waypoint_6 = null;
												Aircraft aircraft_7 = aircraft_;
												array = (flight2 = Flight_).GetFlightCourse();
												StrikePlanner.smethod_33(waypoint_6, aircraft_7, ref array, num26, num25, missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
												flight2.SetFlightCourse(array);
											}
											else
											{
												Waypoint waypoint_7 = null;
												Aircraft aircraft_8 = aircraft_;
												array = (flight2 = Flight_).GetFlightCourse();
												StrikePlanner.smethod_33(waypoint_7, aircraft_8, ref array, geoPoint.GetLatitude(), geoPoint.GetLongitude(), missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
												flight2.SetFlightCourse(array);
											}
										}
										else if (num4 < num23)
										{
											GeoPointGenerator.GetOtherGeoPoint(geoPoint.GetLongitude(), geoPoint.GetLatitude(), ref num25, ref num26, (double)(distance2 - num2), (double)Math2.Normalize(num24 + num8));
											Waypoint waypoint_8 = null;
											Aircraft aircraft_9 = aircraft_;
											array = (flight2 = Flight_).GetFlightCourse();
											StrikePlanner.smethod_33(waypoint_8, aircraft_9, ref array, num26, num25, missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
											flight2.SetFlightCourse(array);
										}
										else
										{
											if (maxRangeToTarget < 6f)
											{
												GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num25, ref num26, (double)num23, (double)Math2.Normalize(num24 + num8 + 180f));
											}
											else
											{
												GeoPointGenerator.GetOtherGeoPoint(num16, num17, ref num25, ref num26, (double)num23, (double)Math2.Normalize(num24 + 180f + num8));
											}
											Waypoint waypoint_9 = null;
											Aircraft aircraft_10 = aircraft_;
											array = (flight2 = Flight_).GetFlightCourse();
											StrikePlanner.smethod_33(waypoint_9, aircraft_10, ref array, num26, num25, missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
											flight2.SetFlightCourse(array);
										}
									}
									if (!flag8 && flag5)
									{
										array = (flight2 = Flight_).GetFlightCourse();
										double double_3 = num17;
										double double_4 = num16;
										float float_23 = num23;
										float float_24 = maxRangeToTarget;
										float float_25 = azimuth2;
										float float_26 = num4;
										float float_27 = num5;
										float float_28 = num6;
										float float_29 = num27;
										float float_30 = num8;
										LoadoutMissionProfile class85_4 = missionProfile;
										Waypoint waypoint2 = null;
										Waypoint waypoint = null;
										StrikePlanner.smethod_5(ref strike, ref Flight_, ref array, ref aircraft_, ref contact_0, double_3, double_4, float_23, float_24, float_25, float_26, float_27, float_28, ref flightFormation, ref num13, ref num11, ref num12, ref flag3, ref speedPreset, float_29, float_30, class85_4, bool_2, true, ref waypoint2, ref waypoint);
										flight2.SetFlightCourse(array);
									}
									Waypoint waypoint_10 = null;
									Aircraft aircraft_11 = aircraft_;
									array = (flight2 = Flight_).GetFlightCourse();
									StrikePlanner.smethod_29(waypoint_10, aircraft_11, ref array, geoPoint.GetLatitude(), geoPoint.GetLongitude(), missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
									flight2.SetFlightCourse(array);
									Waypoint waypoint_11 = null;
									Aircraft aircraft_12 = aircraft_;
									array = (flight2 = Flight_).GetFlightCourse();
									StrikePlanner.smethod_31(waypoint_11, aircraft_12, ref array, geoPoint3.GetLatitude(), geoPoint3.GetLongitude(), missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
									flight2.SetFlightCourse(array);
									StrikePlanner.smethod_7(aircraft_, Flight_.GetFlightCourse());
									Scenario scenario = aircraft_.m_Scenario;
									Mission assignedMission = aircraft_.GetAssignedMission(false);
									ActiveUnit theFlightReferenceUnit_ = aircraft_;
									Mission.Flight theFlight_ = null;
									array = (flight2 = Flight_).GetFlightCourse();
									bool flag9 = StrikePlanner.smethod_8(scenario, assignedMission, theFlightReferenceUnit_, theFlight_, ref array, strike.Bingo, ref float_0, float_2, true, false, true, true, true, true, false, null, 0f, 0f, 0f, @enum, new bool?(bool_3), bool_2);
									flight2.SetFlightCourse(array);
									if (!flag9)
									{
										bool? flag10 = nullable_1;
										if (!(flag10.HasValue ? new bool?(flag10.GetValueOrDefault()) : null).GetValueOrDefault())
										{
											if (Information.IsNothing(nullable_1))
											{
												Aircraft_Navigator aircraftNavigator = aircraft_.GetAircraftNavigator();
												bool flag11 = false;
												float transitAltitude = aircraftNavigator.GetTransitAltitude(ref flag11);
												nullable_1 = new bool?(aircraft_.GetAircraftAI().method_19(aircraft_, contact_0, (float)aircraft_.GetLoadout().CombatRadius, new float?(transitAltitude)));
											}
											if (!(Information.IsNothing(nullable_1) ? new bool?(true) : (nullable_1.HasValue ? new bool?(!nullable_1.GetValueOrDefault()) : nullable_1)).GetValueOrDefault())
											{
												continue;
											}
											if (num7 == 0f && num8 == 0f)
											{
												Mission.Flight flight3 = Flight_;
												array = flight3.GetFlightCourse();
												ScenarioArrayUtil.ClearWaypoints(ref array);
												flight3.SetFlightCourse(array);
												break;
											}
											if (num7 != 0f)
											{
												if (num7 > 0f)
												{
													if (num7 > 5f)
													{
														num7 -= 5f;
													}
													else
													{
														num7 = 0f;
													}
												}
												else if (num7 < -5f)
												{
													num7 += 5f;
												}
												else
												{
													num7 = 0f;
												}
											}
											if (num8 == 0f)
											{
												continue;
											}
											if (num8 > 0f)
											{
												if (num8 > 5f)
												{
													num8 -= 5f;
													continue;
												}
												num8 = 0f;
												continue;
											}
											else
											{
												if (num8 < -5f)
												{
													num8 += 5f;
													continue;
												}
												num8 = 0f;
												continue;
											}
										}
									}
									flag2 = true;
									break;
								}
							}
							else
							{
								aircraft_.GetSide(false).ActiveUnitArray.ToList<ActiveUnit>();
								while (!flag2)
								{
									Mission.Flight flight4 = Flight_;
									Waypoint[] flightCourse = flight4.GetFlightCourse();
									ScenarioArrayUtil.ClearWaypoints(ref flightCourse);
									flight4.SetFlightCourse(flightCourse);
									float azimuth6;
									if (bool_2)
									{
										azimuth6 = Math2.GetAzimuth(aircraft_.GetLatitude(null), aircraft_.GetLongitude(null), contact_0.GetLatitude(null), contact_0.GetLongitude(null));
									}
									else
									{
										azimuth6 = Math2.GetAzimuth(geoPoint2.GetLatitude(), geoPoint2.GetLongitude(), contact_0.GetLatitude(null), contact_0.GetLongitude(null));
									}
									float num28;
									if (num4 < 20f && num4 > 0f)
									{
										num28 = num4 / 2f;
									}
									else
									{
										num28 = 10f;
									}
									Waypoint waypoint_12 = null;
									Aircraft aircraft_13 = aircraft_;
									Mission.Flight flight2;
									flightCourse = (flight2 = Flight_).GetFlightCourse();
									float num11 = 0f;
									float num12 = 0f;
									bool flag3 = false;
									ActiveUnit_Kinematics._SpeedPreset speedPreset = ActiveUnit_Kinematics._SpeedPreset.FullStop;
									float num13 = 0f;
									StrikePlanner.smethod_30(waypoint_12, aircraft_13, ref flightCourse, geoPoint2.GetLatitude(), geoPoint2.GetLongitude(), missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
									flight2.SetFlightCourse(flightCourse);
									double num14 = 0.0;
									double num15 = 0.0;
									if (num4 > 0f)
									{
										GeoPointGenerator.GetOtherGeoPoint(geoPoint2.GetLongitude(), geoPoint2.GetLatitude(), ref num14, ref num15, (double)num28, (double)Math2.Normalize(azimuth6 + num3));
									}
									else
									{
										GeoPointGenerator.GetOtherGeoPoint(geoPoint2.GetLongitude(), geoPoint2.GetLatitude(), ref num14, ref num15, (double)num28, (double)Math2.Normalize(azimuth6 + 180f + num3));
									}
									Waypoint waypoint_13 = null;
									Aircraft aircraft_14 = aircraft_;
									flightCourse = (flight2 = Flight_).GetFlightCourse();
									StrikePlanner.smethod_21(waypoint_13, aircraft_14, ref flightCourse, num15, num14, missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
									flight2.SetFlightCourse(flightCourse);
									if (bool_2)
									{
										Waypoint waypoint3 = new Waypoint(aircraft_.GetLongitude(null), aircraft_.GetLatitude(null), Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
										Mission.Flight flight5 = Flight_;
										flightCourse = flight5.GetFlightCourse();
										ScenarioArrayUtil.AddWaypoint(ref flightCourse, waypoint3);
										flight5.SetFlightCourse(flightCourse);
										Waypoint waypoint_14 = waypoint3;
										Aircraft aircraft_15 = aircraft_;
										flightCourse = (flight2 = Flight_).GetFlightCourse();
										StrikePlanner.smethod_32(waypoint_14, aircraft_15, ref flightCourse, aircraft_.GetLatitude(null), aircraft_.GetLongitude(null), missionProfile, Mission._RadarBehaviour.const_0, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
										flight2.SetFlightCourse(flightCourse);
									}
									if (!bool_2)
									{
										azimuth6 = Math2.GetAzimuth(num15, num14, contact_0.GetLatitude(null), contact_0.GetLongitude(null));
									}
									float azimuth7 = Math2.GetAzimuth(contact_0.GetLatitude(null), contact_0.GetLongitude(null), geoPoint.GetLatitude(), geoPoint.GetLongitude());
									double num16 = 0.0;
									double num17 = 0.0;
									bool flag5 = false;
									double num20 = 0.0;
									double num21 = 0.0;
									if (missionProfile.AttackDistanceIngress > 0)
									{
										if (num5 > 0f && num5 >= (float)missionProfile.AttackDistanceIngress)
										{
											flightCourse = (flight2 = Flight_).GetFlightCourse();
											float float_31 = num5;
											float float_32 = num6;
											float float_33 = azimuth6;
											float float_34 = num2;
											Mission._RadarBehaviour enum63_3 = enum63_0;
											float float_35 = num7;
											LoadoutMissionProfile class85_5 = missionProfile;
											float float_36 = maxRangeToTarget;
											Waypoint waypoint = null;
											Waypoint waypoint2 = null;
											bool flag12 = StrikePlanner.smethod_4(ref strike, ref Flight_, ref flightCourse, ref aircraft_, ref contact_0, ref num4, float_31, float_32, float_33, float_34, ref flightFormation, ref num13, enum63_3, ref num11, ref num12, ref flag3, ref speedPreset, float_35, class85_5, float_36, bool_2, false, true, ref waypoint, ref waypoint2);
											flight2.SetFlightCourse(flightCourse);
											flag5 = flag12;
										}
										else
										{
											flag5 = false;
										}
										if (maxRangeToTarget < 6f)
										{
											GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num21, ref num20, (double)missionProfile.AttackDistanceIngress, (double)Math2.Normalize(azimuth6 + 180f + num7));
										}
										else
										{
											GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num21, ref num20, (double)((float)missionProfile.AttackDistanceIngress + num2), (double)Math2.Normalize(azimuth6 + 180f + num7));
										}
										if (!flag5)
										{
											Waypoint waypoint_15 = null;
											Aircraft aircraft_16 = aircraft_;
											flightCourse = (flight2 = Flight_).GetFlightCourse();
											StrikePlanner.smethod_22(waypoint_15, aircraft_16, ref flightCourse, num20, num21, missionProfile, enum63_0, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
											flight2.SetFlightCourse(flightCourse);
											flightCourse = (flight2 = Flight_).GetFlightCourse();
											float float_37 = num5;
											float float_38 = num6;
											float float_39 = azimuth6;
											float float_40 = num2;
											Mission._RadarBehaviour enum63_4 = enum63_0;
											float float_41 = num7;
											LoadoutMissionProfile class85_6 = missionProfile;
											float float_42 = maxRangeToTarget;
											Waypoint waypoint2 = null;
											Waypoint waypoint = null;
											bool flag13 = StrikePlanner.smethod_4(ref strike, ref Flight_, ref flightCourse, ref aircraft_, ref contact_0, ref num4, float_37, float_38, float_39, float_40, ref flightFormation, ref num13, enum63_4, ref num11, ref num12, ref flag3, ref speedPreset, float_41, class85_6, float_42, bool_2, false, false, ref waypoint2, ref waypoint);
											flight2.SetFlightCourse(flightCourse);
											flag5 = flag13;
										}
										GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num16, ref num17, (double)num2, (double)Math2.Normalize(azimuth7 + num7));
										Waypoint waypoint_16 = null;
										Aircraft aircraft_17 = aircraft_;
										flightCourse = (flight2 = Flight_).GetFlightCourse();
										StrikePlanner.smethod_25(waypoint_16, aircraft_17, ref flightCourse, num17, num16, missionProfile, enum63_0, maxRangeToTarget, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref strike.AttackMethod, ref flightFormation);
										flight2.SetFlightCourse(flightCourse);
									}
									else
									{
										float distance3;
										if (bool_2)
										{
											distance3 = Math2.GetDistance(aircraft_.GetLatitude(null), aircraft_.GetLongitude(null), contact_0.GetLatitude(null), contact_0.GetLongitude(null));
										}
										else
										{
											distance3 = Math2.GetDistance(num15, num14, contact_0.GetLatitude(null), contact_0.GetLongitude(null));
										}
										if (distance3 < num2)
										{
											Interaction.MsgBox("Ooops we shouldn't even get here!", MsgBoxStyle.OkOnly, null);
											if (bool_2)
											{
												num16 = aircraft_.GetLongitude(null);
												num17 = aircraft_.GetLatitude(null);
											}
											else
											{
												num16 = num14;
												num17 = num15;
											}
											Waypoint waypoint_17 = null;
											Aircraft aircraft_18 = aircraft_;
											flightCourse = (flight2 = Flight_).GetFlightCourse();
											StrikePlanner.smethod_25(waypoint_17, aircraft_18, ref flightCourse, num17, num16, missionProfile, enum63_0, maxRangeToTarget, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref strike.AttackMethod, ref flightFormation);
											flight2.SetFlightCourse(flightCourse);
										}
										else
										{
											float num29;
											if (num4 > 50f)
											{
												num29 = 50f;
											}
											else
											{
												num29 = num4 / 2f;
											}
											if (num29 > 0f && num4 > num29)
											{
												if (num5 > 0f && num5 >= num29)
												{
													flightCourse = (flight2 = Flight_).GetFlightCourse();
													float float_43 = num5;
													float float_44 = num6;
													float float_45 = azimuth6;
													float float_46 = num2;
													Mission._RadarBehaviour enum63_5 = enum63_0;
													float float_47 = num7;
													LoadoutMissionProfile class85_7 = missionProfile;
													float float_48 = maxRangeToTarget;
													Waypoint waypoint = null;
													Waypoint waypoint2 = null;
													bool flag14 = StrikePlanner.smethod_4(ref strike, ref Flight_, ref flightCourse, ref aircraft_, ref contact_0, ref num4, float_43, float_44, float_45, float_46, ref flightFormation, ref num13, enum63_5, ref num11, ref num12, ref flag3, ref speedPreset, float_47, class85_7, float_48, bool_2, false, true, ref waypoint, ref waypoint2);
													flight2.SetFlightCourse(flightCourse);
													flag5 = flag14;
												}
												else
												{
													flag5 = false;
												}
												if (maxRangeToTarget < 6f)
												{
													GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num21, ref num20, (double)num29, (double)Math2.Normalize(azimuth6 + 180f + num7));
												}
												else
												{
													GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num21, ref num20, (double)(num29 + num2), (double)Math2.Normalize(azimuth6 + 180f + num7));
												}
												if (!flag5)
												{
													Waypoint waypoint_18 = null;
													Aircraft aircraft_19 = aircraft_;
													flightCourse = (flight2 = Flight_).GetFlightCourse();
													StrikePlanner.smethod_32(waypoint_18, aircraft_19, ref flightCourse, num20, num21, missionProfile, enum63_0, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
													flight2.SetFlightCourse(flightCourse);
													flightCourse = (flight2 = Flight_).GetFlightCourse();
													float float_49 = num5;
													float float_50 = num6;
													float float_51 = azimuth6;
													float float_52 = num2;
													Mission._RadarBehaviour enum63_6 = enum63_0;
													float float_53 = num7;
													LoadoutMissionProfile class85_8 = missionProfile;
													float float_54 = maxRangeToTarget;
													Waypoint waypoint2 = null;
													Waypoint waypoint = null;
													bool flag15 = StrikePlanner.smethod_4(ref strike, ref Flight_, ref flightCourse, ref aircraft_, ref contact_0, ref num4, float_49, float_50, float_51, float_52, ref flightFormation, ref num13, enum63_6, ref num11, ref num12, ref flag3, ref speedPreset, float_53, class85_8, float_54, bool_2, false, false, ref waypoint2, ref waypoint);
													flight2.SetFlightCourse(flightCourse);
													flag5 = flag15;
												}
												GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num16, ref num17, (double)num2, (double)Math2.Normalize(azimuth6 + 180f + num7));
												Waypoint waypoint_19 = null;
												Aircraft aircraft_20 = aircraft_;
												flightCourse = (flight2 = Flight_).GetFlightCourse();
												StrikePlanner.smethod_25(waypoint_19, aircraft_20, ref flightCourse, num17, num16, missionProfile, enum63_0, maxRangeToTarget, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref strike.AttackMethod, ref flightFormation);
												flight2.SetFlightCourse(flightCourse);
											}
											else
											{
												GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num16, ref num17, (double)num2, (double)Math2.Normalize(azimuth6 + 180f));
												Waypoint waypoint_20 = null;
												Aircraft aircraft_21 = aircraft_;
												flightCourse = (flight2 = Flight_).GetFlightCourse();
												StrikePlanner.smethod_25(waypoint_20, aircraft_21, ref flightCourse, num17, num16, missionProfile, enum63_0, maxRangeToTarget, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref strike.AttackMethod, ref flightFormation);
												flight2.SetFlightCourse(flightCourse);
											}
										}
									}
									Waypoint waypoint_21 = null;
									Aircraft aircraft_22 = aircraft_;
									flightCourse = (flight2 = Flight_).GetFlightCourse();
									StrikePlanner.smethod_26(waypoint_21, aircraft_22, ref flightCourse, contact_0.GetLatitude(null), contact_0.GetLongitude(null), missionProfile, enum63_0, maxRangeToTarget, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref strike.AttackMethod, ref flightFormation);
									flight2.SetFlightCourse(flightCourse);
									if (missionProfile.AttackDistanceEgress > 0)
									{
										double num25 = 0.0;
										double num26 = 0.0;
										if (maxRangeToTarget < 6f)
										{
											GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num25, ref num26, (double)missionProfile.AttackDistanceEgress, (double)Math2.Normalize(azimuth7 + num8));
										}
										else
										{
											GeoPointGenerator.GetOtherGeoPoint(num16, num17, ref num25, ref num26, (double)missionProfile.AttackDistanceEgress, (double)Math2.Normalize(azimuth7 + num8));
										}
										float num27 = 0f;
										if (strike.AttackMethod >= Mission._AttackMethod.const_2)
										{
											float azimuth8 = Math2.GetAzimuth(geoPoint2.GetLatitude(), geoPoint2.GetLongitude(), num20, num21);
											float azimuth9 = Math2.GetAzimuth(num20, num21, num26, num25);
											@enum = Misc.smethod_63(azimuth8, azimuth9);
											if (@enum != Misc.Enum102.const_0)
											{
												if (@enum == Misc.Enum102.const_1)
												{
													num27 = 270f;
												}
											}
											else
											{
												num27 = 90f;
											}
										}
										bool flag8;
										if (num5 > 0f && num5 < (float)missionProfile.AttackDistanceEgress && flag5)
										{
											flightCourse = (flight2 = Flight_).GetFlightCourse();
											double double_5 = num17;
											double double_6 = num16;
											float float_55 = (float)missionProfile.AttackDistanceEgress;
											float float_56 = maxRangeToTarget;
											float float_57 = azimuth7;
											float float_58 = num4;
											float float_59 = num5;
											float float_60 = num6;
											float float_61 = num27;
											float float_62 = num8;
											LoadoutMissionProfile class85_9 = missionProfile;
											Waypoint waypoint = null;
											Waypoint waypoint2 = null;
											bool flag16 = StrikePlanner.smethod_5(ref strike, ref Flight_, ref flightCourse, ref aircraft_, ref contact_0, double_5, double_6, float_55, float_56, float_57, float_58, float_59, float_60, ref flightFormation, ref num13, ref num11, ref num12, ref flag3, ref speedPreset, float_61, float_62, class85_9, bool_2, false, ref waypoint, ref waypoint2);
											flight2.SetFlightCourse(flightCourse);
											flag8 = flag16;
										}
										else
										{
											flag8 = false;
										}
										if (num5 == 0f || num5 < (float)missionProfile.AttackDistanceEgress)
										{
											Waypoint waypoint_22 = null;
											Aircraft aircraft_23 = aircraft_;
											flightCourse = (flight2 = Flight_).GetFlightCourse();
											StrikePlanner.smethod_33(waypoint_22, aircraft_23, ref flightCourse, num26, num25, missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
											flight2.SetFlightCourse(flightCourse);
										}
										if (!flag8 && flag5)
										{
											flightCourse = (flight2 = Flight_).GetFlightCourse();
											double double_7 = num17;
											double double_8 = num16;
											float float_63 = (float)missionProfile.AttackDistanceEgress;
											float float_64 = maxRangeToTarget;
											float float_65 = azimuth7;
											float float_66 = num4;
											float float_67 = num5;
											float float_68 = num6;
											float float_69 = num27;
											float float_70 = num8;
											LoadoutMissionProfile class85_10 = missionProfile;
											Waypoint waypoint2 = null;
											Waypoint waypoint = null;
											StrikePlanner.smethod_5(ref strike, ref Flight_, ref flightCourse, ref aircraft_, ref contact_0, double_7, double_8, float_63, float_64, float_65, float_66, float_67, float_68, ref flightFormation, ref num13, ref num11, ref num12, ref flag3, ref speedPreset, float_69, float_70, class85_10, bool_2, true, ref waypoint2, ref waypoint);
											flight2.SetFlightCourse(flightCourse);
										}
									}
									else
									{
										float distance4 = Math2.GetDistance(contact_0.GetLatitude(null), contact_0.GetLongitude(null), geoPoint.GetLatitude(), geoPoint.GetLongitude());
										float num30;
										if (distance4 > 50f)
										{
											num30 = 50f;
										}
										else
										{
											num30 = distance4 / 2f;
										}
										if (bool_2)
										{
											if (num30 > 0f && distance4 > num30 + num2)
											{
												float num31 = Math2.Normalize(Math2.GetAzimuth(geoPoint.GetLatitude(), geoPoint.GetLongitude(), contact_0.GetLatitude(null), contact_0.GetLongitude(null)));
												double num25 = 0.0;
												double num26 = 0.0;
												if (maxRangeToTarget < 6f)
												{
													GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num25, ref num26, (double)num30, (double)Math2.Normalize(num31 + 180f + num8));
												}
												else
												{
													GeoPointGenerator.GetOtherGeoPoint(num16, num17, ref num25, ref num26, (double)num30, (double)Math2.Normalize(num31 + 180f + num8));
												}
												float num27 = 0f;
												if (strike.AttackMethod >= Mission._AttackMethod.const_2)
												{
													float azimuth10 = Math2.GetAzimuth(geoPoint2.GetLatitude(), geoPoint2.GetLongitude(), num20, num21);
													float azimuth11 = Math2.GetAzimuth(num20, num21, num26, num25);
													@enum = Misc.smethod_63(azimuth10, azimuth11);
													if (@enum != Misc.Enum102.const_0)
													{
														if (@enum == Misc.Enum102.const_1)
														{
															num27 = 270f;
														}
													}
													else
													{
														num27 = 90f;
													}
												}
												bool flag8;
												if (num5 > 0f && num5 < num30 && flag5)
												{
													flightCourse = (flight2 = Flight_).GetFlightCourse();
													double double_9 = num17;
													double double_10 = num16;
													float float_71 = num30;
													float float_72 = maxRangeToTarget;
													float float_73 = azimuth7;
													float float_74 = num4;
													float float_75 = num5;
													float float_76 = num6;
													float float_77 = num27;
													float float_78 = num8;
													LoadoutMissionProfile class85_11 = missionProfile;
													Waypoint waypoint = null;
													Waypoint waypoint2 = null;
													bool flag17 = StrikePlanner.smethod_5(ref strike, ref Flight_, ref flightCourse, ref aircraft_, ref contact_0, double_9, double_10, float_71, float_72, float_73, float_74, float_75, float_76, ref flightFormation, ref num13, ref num11, ref num12, ref flag3, ref speedPreset, float_77, float_78, class85_11, bool_2, false, ref waypoint, ref waypoint2);
													flight2.SetFlightCourse(flightCourse);
													flag8 = flag17;
												}
												else
												{
													flag8 = false;
												}
												if (num5 == 0f || num5 < num30)
												{
													Waypoint waypoint_23 = null;
													Aircraft aircraft_24 = aircraft_;
													flightCourse = (flight2 = Flight_).GetFlightCourse();
													StrikePlanner.smethod_33(waypoint_23, aircraft_24, ref flightCourse, num26, num25, missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
													flight2.SetFlightCourse(flightCourse);
												}
												if (!flag8 && flag5)
												{
													flightCourse = (flight2 = Flight_).GetFlightCourse();
													double double_11 = num17;
													double double_12 = num16;
													float float_79 = num30;
													float float_80 = maxRangeToTarget;
													float float_81 = azimuth7;
													float float_82 = num4;
													float float_83 = num5;
													float float_84 = num6;
													float float_85 = num27;
													float float_86 = num8;
													LoadoutMissionProfile class85_12 = missionProfile;
													Waypoint waypoint2 = null;
													Waypoint waypoint = null;
													StrikePlanner.smethod_5(ref strike, ref Flight_, ref flightCourse, ref aircraft_, ref contact_0, double_11, double_12, float_79, float_80, float_81, float_82, float_83, float_84, ref flightFormation, ref num13, ref num11, ref num12, ref flag3, ref speedPreset, float_85, float_86, class85_12, bool_2, true, ref waypoint2, ref waypoint);
													flight2.SetFlightCourse(flightCourse);
												}
											}
										}
										else
										{
											float num32 = Math2.Normalize(azimuth7 + 180f);
											double num25 = 0.0;
											double num26 = 0.0;
											if (maxRangeToTarget < 6f)
											{
												GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num25, ref num26, (double)num30, (double)Math2.Normalize(num32 + 180f + num8));
											}
											else
											{
												GeoPointGenerator.GetOtherGeoPoint(num16, num17, ref num25, ref num26, (double)num30, (double)Math2.Normalize(num32 + 180f + num8));
											}
											float num27 = 0f;
											if (strike.AttackMethod >= Mission._AttackMethod.const_2)
											{
												float azimuth12 = Math2.GetAzimuth(geoPoint2.GetLatitude(), geoPoint2.GetLongitude(), num20, num21);
												float azimuth13 = Math2.GetAzimuth(num20, num21, num26, num25);
												@enum = Misc.smethod_63(azimuth12, azimuth13);
												if (@enum != Misc.Enum102.const_0)
												{
													if (@enum == Misc.Enum102.const_1)
													{
														num27 = 270f;
													}
												}
												else
												{
													num27 = 90f;
												}
											}
											bool flag8;
											if (num5 > 0f && num5 < num30 && flag5)
											{
												flightCourse = (flight2 = Flight_).GetFlightCourse();
												double double_13 = num17;
												double double_14 = num16;
												float float_87 = num30;
												float float_88 = maxRangeToTarget;
												float float_89 = azimuth7;
												float float_90 = num4;
												float float_91 = num5;
												float float_92 = num6;
												float float_93 = num27;
												float float_94 = num8;
												LoadoutMissionProfile class85_13 = missionProfile;
												Waypoint waypoint = null;
												Waypoint waypoint2 = null;
												bool flag18 = StrikePlanner.smethod_5(ref strike, ref Flight_, ref flightCourse, ref aircraft_, ref contact_0, double_13, double_14, float_87, float_88, float_89, float_90, float_91, float_92, ref flightFormation, ref num13, ref num11, ref num12, ref flag3, ref speedPreset, float_93, float_94, class85_13, bool_2, false, ref waypoint, ref waypoint2);
												flight2.SetFlightCourse(flightCourse);
												flag8 = flag18;
											}
											else
											{
												flag8 = false;
											}
											if (num5 == 0f || num5 < num30)
											{
												Waypoint waypoint_24 = null;
												Aircraft aircraft_25 = aircraft_;
												flightCourse = (flight2 = Flight_).GetFlightCourse();
												StrikePlanner.smethod_33(waypoint_24, aircraft_25, ref flightCourse, num26, num25, missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
												flight2.SetFlightCourse(flightCourse);
											}
											if (!flag8 && flag5)
											{
												flightCourse = (flight2 = Flight_).GetFlightCourse();
												double double_15 = num17;
												double double_16 = num16;
												float float_95 = num30;
												float float_96 = maxRangeToTarget;
												float float_97 = azimuth7;
												float float_98 = num4;
												float float_99 = num5;
												float float_100 = num6;
												float float_101 = num27;
												float float_102 = num8;
												LoadoutMissionProfile class85_14 = missionProfile;
												Waypoint waypoint2 = null;
												Waypoint waypoint = null;
												StrikePlanner.smethod_5(ref strike, ref Flight_, ref flightCourse, ref aircraft_, ref contact_0, double_15, double_16, float_95, float_96, float_97, float_98, float_99, float_100, ref flightFormation, ref num13, ref num11, ref num12, ref flag3, ref speedPreset, float_101, float_102, class85_14, bool_2, true, ref waypoint2, ref waypoint);
												flight2.SetFlightCourse(flightCourse);
											}
										}
									}
									Waypoint waypoint_25 = null;
									Aircraft aircraft_26 = aircraft_;
									flightCourse = (flight2 = Flight_).GetFlightCourse();
									StrikePlanner.smethod_29(waypoint_25, aircraft_26, ref flightCourse, geoPoint.GetLatitude(), geoPoint.GetLongitude(), missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
									flight2.SetFlightCourse(flightCourse);
									Waypoint waypoint_26 = null;
									Aircraft aircraft_27 = aircraft_;
									flightCourse = (flight2 = Flight_).GetFlightCourse();
									StrikePlanner.smethod_31(waypoint_26, aircraft_27, ref flightCourse, geoPoint3.GetLatitude(), geoPoint3.GetLongitude(), missionProfile, ref num11, ref num12, ref flag3, ref speedPreset, ref num13, ref flightFormation);
									flight2.SetFlightCourse(flightCourse);
									StrikePlanner.smethod_7(aircraft_, Flight_.GetFlightCourse());
									Scenario scenario2 = aircraft_.m_Scenario;
									Mission assignedMission2 = aircraft_.GetAssignedMission(false);
									ActiveUnit theFlightReferenceUnit_2 = aircraft_;
									Mission.Flight theFlight_2 = null;
									flightCourse = (flight2 = Flight_).GetFlightCourse();
									bool flag19 = StrikePlanner.smethod_8(scenario2, assignedMission2, theFlightReferenceUnit_2, theFlight_2, ref flightCourse, strike.Bingo, ref float_0, float_2, true, false, true, true, true, true, false, null, 0f, 0f, 0f, @enum, new bool?(bool_3), bool_2);
									flight2.SetFlightCourse(flightCourse);
									if (!flag19)
									{
										bool? flag10 = nullable_1;
										if (!(flag10.HasValue ? new bool?(flag10.GetValueOrDefault()) : null).GetValueOrDefault())
										{
											if (Information.IsNothing(nullable_1))
											{
												Aircraft_Navigator aircraftNavigator2 = aircraft_.GetAircraftNavigator();
												bool flag11 = false;
												float transitAltitude2 = aircraftNavigator2.GetTransitAltitude(ref flag11);
												nullable_1 = new bool?(aircraft_.GetAircraftAI().method_19(aircraft_, contact_0, (float)aircraft_.GetLoadout().CombatRadius, new float?(transitAltitude2)));
											}
											if (!(Information.IsNothing(nullable_1) ? new bool?(true) : (nullable_1.HasValue ? new bool?(!nullable_1.GetValueOrDefault()) : nullable_1)).GetValueOrDefault())
											{
												continue;
											}
											if (num7 == 0f && num8 == 0f)
											{
												Mission.Flight flight6 = Flight_;
												flightCourse = flight6.GetFlightCourse();
												ScenarioArrayUtil.ClearWaypoints(ref flightCourse);
												flight6.SetFlightCourse(flightCourse);
												break;
											}
											if (num7 != 0f)
											{
												if (num7 > 0f)
												{
													if (num7 > 5f)
													{
														num7 -= 5f;
													}
													else
													{
														num7 = 0f;
													}
												}
												else if (num7 < -5f)
												{
													num7 += 5f;
												}
												else
												{
													num7 = 0f;
												}
											}
											if (num8 == 0f)
											{
												continue;
											}
											if (num8 > 0f)
											{
												if (num8 > 5f)
												{
													num8 -= 5f;
													continue;
												}
												num8 = 0f;
												continue;
											}
											else
											{
												if (num8 < -5f)
												{
													num8 += 5f;
													continue;
												}
												num8 = 0f;
												continue;
											}
										}
									}
									flag2 = true;
									break;
								}
							}
						}
						if (!bool_0)
						{
							if (!flag2)
							{
								string_0 = "Waiting for Path Finder to create a flight plan around No-Navigation Zones.";
								flag = false;
								result = false;
								return result;
							}
							if (StrikePlanner.smethod_3(ref aircraft_, ref Flight_, num, false))
							{
								flag = false;
								result = false;
								return result;
							}
							Scenario scenario3 = aircraft_.m_Scenario;
							Mission assignedMission3 = aircraft_.GetAssignedMission(false);
							ActiveUnit theFlightReferenceUnit_3 = aircraft_;
							Mission.Flight theFlight_3 = null;
							Mission.Flight flight2;
							Waypoint[] array = (flight2 = Flight_).GetFlightCourse();
							StrikePlanner.smethod_8(scenario3, assignedMission3, theFlightReferenceUnit_3, theFlight_3, ref array, strike.Bingo, ref float_0, float_2, false, true, false, false, true, false, true, null, num5, num6, float_, @enum, new bool?(bool_3), bool_2);
							flight2.SetFlightCourse(array);
							flag = true;
							result = true;
							return result;
						}
						else
						{
							if ((flag2 || Flight_.GetWaypoint1().Count<Waypoint>() > 0) && aircraft_.GetSide(false).NoNavZoneList.Count > 0)
							{
								StrikePlanner.smethod_3(ref aircraft_, ref Flight_, num, true);
								if (Flight_.GetFlightCourse().Count<Waypoint>() == 0 || Flight_.GetWaypoint1().Count<Waypoint>() > 0)
								{
									ActiveUnit referenceUnit = Flight_.GetReferenceUnit(aircraft_.m_Scenario);
									Aircraft aircraft = null;
									if (Flight_.GetReferenceUnit(aircraft_.m_Scenario).IsAircraft)
									{
										aircraft = (Aircraft)Flight_.GetReferenceUnit(aircraft_.m_Scenario);
									}
									Aircraft_AirOps aircraftAirOps2 = aircraft.GetAircraftAirOps();
									GeoPoint geoPoint4;
									if (!aircraft_.IsRotaryWingAircraft())
									{
										if (!Information.IsNothing(aircraftAirOps2.GetAssignedHostUnit()))
										{
											geoPoint4 = aircraftAirOps2.GetAssignedHostUnit().GetAirOps().method_5();
										}
										else
										{
											geoPoint4 = new GeoPoint(aircraft.GetLongitude(null), aircraft.GetLatitude(null));
										}
									}
									else if (!Information.IsNothing(aircraftAirOps2.GetAssignedHostUnit()))
									{
										geoPoint4 = new GeoPoint(aircraftAirOps2.GetAssignedHostUnit().GetLongitude(null), aircraftAirOps2.GetAssignedHostUnit().GetLatitude(null));
									}
									else
									{
										geoPoint4 = new GeoPoint(aircraft.GetLongitude(null), aircraft.GetLatitude(null));
									}
									GeoPoint geoPoint5;
									if (!Information.IsNothing(aircraftAirOps2.GetAssignedHostUnit()))
									{
										geoPoint5 = new GeoPoint(aircraftAirOps2.GetAssignedHostUnit().GetLongitude(null), aircraftAirOps2.GetAssignedHostUnit().GetLatitude(null));
									}
									else
									{
										geoPoint5 = new GeoPoint(aircraft_.GetLongitude(null), aircraft_.GetLatitude(null));
									}
									GeoPoint geoPoint6;
									if (!Information.IsNothing(aircraftAirOps2.GetAssignedHostUnit()))
									{
										geoPoint6 = new GeoPoint(aircraftAirOps2.GetAssignedHostUnit().GetLongitude(null), aircraftAirOps2.GetAssignedHostUnit().GetLatitude(null));
									}
									else
									{
										geoPoint6 = new GeoPoint(aircraft_.GetLongitude(null), aircraft_.GetLatitude(null));
									}
									if (Flight_.GetWaypoint1().Count<Waypoint>() == 0)
									{
										if (!bool_2 && Information.IsNothing(mission_0))
										{
											Mission.Flight flight7 = Flight_;
											Waypoint[] array = flight7.GetWaypoint1();
											ScenarioArrayUtil.ClearWaypoints(ref array);
											flight7.SetWaypoint1(array);
											Mission.Flight flight8 = Flight_;
											array = flight8.GetWaypoint2();
											ScenarioArrayUtil.ClearWaypoints(ref array);
											flight8.SetWaypoint2(array);
											Flight_.bool_11 = true;
											Flight_.bool_13 = true;
											aircraft_.GetAircraftNavigator().method_12(null, null, Flight_, true, num, contact_0.GetLatitude(null), contact_0.GetLongitude(null), aircraft_.m_Scenario, false);
											if (bool_1 && !Information.IsNothing(Flight_.PrimaryTarget))
											{
												Flight_.bool_12 = true;
												aircraft_.GetAircraftNavigator().method_12(null, null, Flight_, false, num, geoPoint4.GetLatitude(), geoPoint4.GetLongitude(), aircraft_.m_Scenario, false);
											}
											flag = true;
											result = true;
											return result;
										}
										if (Information.IsNothing(StrikePlanner.UsePathfinderToFindRoute))
										{
											if (Interaction.MsgBox("The strike planner could not generate a direct-path flightplan for " + aircraft.Name + " due to the presense of No-Navigation Zones. Do you want the pathfinder to attempt finding a route? This may take several minutes. Please note that the pathfinder will not allow aircraft to fly closer than 0.2 degrees (12nm at the equator) to any No-Navigation Zones.", MsgBoxStyle.YesNo, "Attempt pathfinding around No-Navigation Zones?") == MsgBoxResult.Yes)
											{
												StrikePlanner.UsePathfinderToFindRoute = new bool?(true);
											}
											else
											{
												StrikePlanner.UsePathfinderToFindRoute = new bool?(false);
											}
										}
										if (!StrikePlanner.UsePathfinderToFindRoute.GetValueOrDefault())
										{
											string_0 = "Pathfinder is not allowed to create an egress leg for the flightplan. No flightplan has been created.";
											flag = false;
											result = false;
											return result;
										}
										Flight_.GetReferenceUnit(aircraft_.m_Scenario).GetNavigator().method_13(null, null, Flight_, true, num, contact_0.GetLatitude(null), contact_0.GetLongitude(null), aircraft_.m_Scenario, false);
										if (Flight_.GetWaypoint1().Count<Waypoint>() <= 0)
										{
											string_0 = "Could not create an ingress leg for the flightplan.";
											flag = false;
											result = false;
											return result;
										}
										if (bool_2)
										{
											Flight_.GetReferenceUnit(aircraft_.m_Scenario).GetNavigator().method_13(null, null, Flight_, false, num, geoPoint4.GetLatitude(), geoPoint4.GetLongitude(), aircraft_.m_Scenario, false);
											if (Flight_.GetWaypoint2().Count<Waypoint>() == 0)
											{
												string_0 = "Could not create an egress leg for the flightplan.";
												flag = false;
												result = false;
												return result;
											}
										}
									}
									if (Flight_.GetWaypoint1().Count<Waypoint>() > 0)
									{
										flag = (result = StrikePlanner.smethod_2(ref strike, ref Flight_, ref aircraft_, ref nullable_1, ref contact_0, ref string_0, ref enum63_0, bool_2, ref bool_3, ref float_0, ref referenceUnit, ref aircraft, ref num2, ref geoPoint5, ref geoPoint4, ref geoPoint6, ref missionProfile, ref flightFormation, ref num4, ref num3, ref @enum, ref num5, ref num6, ref float_, ref maxRangeToTarget, ref num, ref float_2, ref horizontalRange, ref maxRangeToTarget2));
										return result;
									}
									if (flag2)
									{
										Scenario scenario4 = aircraft_.m_Scenario;
										Mission assignedMission4 = aircraft_.GetAssignedMission(false);
										ActiveUnit theFlightReferenceUnit_4 = aircraft_;
										Mission.Flight theFlight_4 = null;
										Mission.Flight flight2;
										Waypoint[] flightCourse2 = (flight2 = Flight_).GetFlightCourse();
										StrikePlanner.smethod_8(scenario4, assignedMission4, theFlightReferenceUnit_4, theFlight_4, ref flightCourse2, strike.Bingo, ref float_0, float_2, false, true, false, false, true, false, true, null, num5, num6, float_, @enum, new bool?(bool_3), bool_2);
										flight2.SetFlightCourse(flightCourse2);
										flag = true;
										result = true;
										return result;
									}
								}
							}
							if (flag2)
							{
								Scenario scenario5 = aircraft_.m_Scenario;
								Mission assignedMission5 = aircraft_.GetAssignedMission(false);
								ActiveUnit theFlightReferenceUnit_5 = aircraft_;
								Mission.Flight theFlight_5 = null;
								Mission.Flight flight2;
								Waypoint[] array = (flight2 = Flight_).GetFlightCourse();
								StrikePlanner.smethod_8(scenario5, assignedMission5, theFlightReferenceUnit_5, theFlight_5, ref array, strike.Bingo, ref float_0, float_2, false, true, false, false, true, false, true, null, num5, num6, float_, @enum, new bool?(bool_3), bool_2);
								flight2.SetFlightCourse(array);
								flag = true;
								result = true;
								return result;
							}
						}
					}
					string_0 = "No flight plan could be generated. Reason unknown.";
					flag = false;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101108", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					flag = false;
					ProjectData.ClearProjectError();
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x003AE2A4 File Offset: 0x003AC4A4
		private static bool smethod_2(ref Strike strike_0, ref Mission.Flight Flight_, ref Aircraft aircraft_0, ref bool? nullable_1, ref Contact contact_0, ref string string_0, ref Mission._RadarBehaviour enum63_0, bool bool_0, ref bool bool_1, ref float float_0, ref ActiveUnit activeUnit_0, ref Aircraft aircraft_1, ref float float_1, ref GeoPoint geoPoint_0, ref GeoPoint geoPoint_1, ref GeoPoint geoPoint_2, ref LoadoutMissionProfile class85_0, ref Waypoint._FlightFormation enum53_0, ref float float_2, ref float float_3, ref Misc.Enum102 enum102_0, ref float float_4, ref float float_5, ref float float_6, ref float float_7, ref float float_8, ref float float_9, ref float float_10, ref float float_11)
		{
			bool flag = false;
			bool result;
			try
			{
				if (Information.IsNothing(Flight_.GetReferenceUnit(aircraft_0.m_Scenario)))
				{
					string_0 = "Could not find the flightplan's reference unit.";
					flag = false;
				}
				else if (Information.IsNothing(Flight_.PrimaryTarget))
				{
					string_0 = "Could not find the flightplan's primary target.";
					flag = false;
				}
				else
				{
					bool flag2 = false;
					double num = 1.0;
					double num2 = 1.0;
					int num3 = Flight_.GetWaypoint1().Count<Waypoint>();
					float num4 = 0f;
					Waypoint waypoint = Flight_.GetWaypoint1()[num3 - 1];
					double num5 = 0.0;
					double num6 = 0.0;
					Waypoint waypoint2;
					Waypoint[] array;
					if (num3 - 1 == 0)
					{
						float distance = Math2.GetDistance(Flight_.GetWaypoint1()[num3 - 1].GetLatitude(), Flight_.GetWaypoint1()[num3 - 1].GetLongitude(), activeUnit_0.GetLatitude(null), activeUnit_0.GetLongitude(null));
						if (float_1 > distance)
						{
							Math2.GetAzimuth(activeUnit_0.GetLatitude(null), activeUnit_0.GetLongitude(null), Flight_.GetWaypoint1()[num3 - 1].GetLatitude(), Flight_.GetWaypoint1()[num3 - 1].GetLongitude());
							waypoint2 = new Waypoint(activeUnit_0.GetLongitude(null), activeUnit_0.GetLatitude(null), Waypoint.WaypointType.InitialPoint, Waypoint._Creator.const_3, Waypoint._Category.const_1);
						}
						else
						{
							float azimuth = Math2.GetAzimuth(Flight_.GetWaypoint1()[num3 - 1].GetLatitude(), Flight_.GetWaypoint1()[num3 - 1].GetLongitude(), aircraft_1.GetLatitude(null), aircraft_1.GetLongitude(null));
							GeoPointGenerator.GetOtherGeoPoint(Flight_.GetWaypoint1()[num3 - 1].GetLongitude(), Flight_.GetWaypoint1()[num3 - 1].GetLatitude(), ref num5, ref num6, (double)float_1, (double)Math2.Normalize(azimuth));
							waypoint2 = new Waypoint(num5, num6, Waypoint.WaypointType.InitialPoint, Waypoint._Creator.const_3, Waypoint._Category.const_1);
							Mission.Flight flight = Flight_;
							array = flight.GetWaypoint1();
							ActiveUnit_Navigator.InsertWayPoint(ref array, num3 - 1, waypoint2);
							flight.SetWaypoint1(array);
						}
					}
					else if (Math2.GetDistance(Flight_.GetWaypoint1()[num3 - 1].GetLatitude(), Flight_.GetWaypoint1()[num3 - 1].GetLongitude(), Flight_.GetWaypoint1()[num3 - 2].GetLatitude(), Flight_.GetWaypoint1()[num3 - 2].GetLongitude()) > float_1)
					{
						float azimuth2 = Math2.GetAzimuth(Flight_.GetWaypoint1()[num3 - 1].GetLatitude(), Flight_.GetWaypoint1()[num3 - 1].GetLongitude(), Flight_.GetWaypoint1()[num3 - 2].GetLatitude(), Flight_.GetWaypoint1()[num3 - 2].GetLongitude());
						GeoPointGenerator.GetOtherGeoPoint(Flight_.GetWaypoint1()[num3 - 1].GetLongitude(), Flight_.GetWaypoint1()[num3 - 1].GetLatitude(), ref num5, ref num6, (double)float_1, (double)Math2.Normalize(azimuth2));
						waypoint2 = new Waypoint(num5, num6, Waypoint.WaypointType.InitialPoint, Waypoint._Creator.const_3, Waypoint._Category.const_1);
						Mission.Flight flight2 = Flight_;
						array = flight2.GetWaypoint1();
						ActiveUnit_Navigator.InsertWayPoint(ref array, num3 - 1, waypoint2);
						flight2.SetWaypoint1(array);
					}
					else
					{
						waypoint2 = Flight_.GetWaypoint1()[num3 - 2];
						waypoint2.waypointType = Waypoint.WaypointType.InitialPoint;
					}
					Waypoint waypoint_ = null;
					Aircraft aircraft_2 = aircraft_1;
					Mission.Flight flight3;
					array = (flight3 = Flight_).GetWaypoint1();
					float num7 = 0f;
					float num8 = 0f;
					bool flag3 = false;
					ActiveUnit_Kinematics._SpeedPreset speedPreset = ActiveUnit_Kinematics._SpeedPreset.FullStop;
					float num9 = 0f;
					StrikePlanner.smethod_30(waypoint_, aircraft_2, ref array, geoPoint_0.GetLatitude(), geoPoint_0.GetLongitude(), class85_0, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref enum53_0);
					flight3.SetWaypoint1(array);
					float azimuth3;
					if (bool_0)
					{
						azimuth3 = Math2.GetAzimuth(aircraft_0.GetLatitude(null), aircraft_0.GetLongitude(null), contact_0.GetLatitude(null), contact_0.GetLongitude(null));
					}
					else
					{
						azimuth3 = Math2.GetAzimuth(geoPoint_0.GetLatitude(), geoPoint_0.GetLongitude(), contact_0.GetLatitude(null), contact_0.GetLongitude(null));
					}
					float num10;
					if (float_2 < 20f && float_2 > 0f)
					{
						num10 = float_2 / 2f;
					}
					else
					{
						num10 = 10f;
					}
					double num11 = 0.0;
					double num12 = 0.0;
					if (float_2 > 0f)
					{
						GeoPointGenerator.GetOtherGeoPoint(geoPoint_0.GetLongitude(), geoPoint_0.GetLatitude(), ref num11, ref num12, (double)num10, (double)Math2.Normalize(azimuth3 + float_3));
					}
					else
					{
						GeoPointGenerator.GetOtherGeoPoint(geoPoint_0.GetLongitude(), geoPoint_0.GetLatitude(), ref num11, ref num12, (double)num10, (double)Math2.Normalize(azimuth3 + 180f + float_3));
					}
					Waypoint waypoint3 = new Waypoint(num11, num12, Waypoint.WaypointType.Assemble, Waypoint._Creator.const_3, Waypoint._Category.const_1);
					Mission.Flight flight4 = Flight_;
					array = flight4.GetWaypoint1();
					ActiveUnit_Navigator.InsertWayPoint(ref array, 1, waypoint3);
					flight4.SetWaypoint1(array);
					Waypoint waypoint_2 = waypoint3;
					Aircraft aircraft_3 = aircraft_1;
					array = (flight3 = Flight_).GetWaypoint1();
					StrikePlanner.smethod_21(waypoint_2, aircraft_3, ref array, num12, num11, class85_0, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref enum53_0);
					flight3.SetWaypoint1(array);
					if (bool_0)
					{
						Waypoint waypoint4 = new Waypoint(aircraft_1.GetLongitude(null), aircraft_1.GetLatitude(null), Waypoint.WaypointType.TurningPoint, Waypoint._Creator.const_3, Waypoint._Category.const_1);
						Mission.Flight flight5 = Flight_;
						array = flight5.GetWaypoint1();
						ActiveUnit_Navigator.InsertWayPoint(ref array, 2, waypoint4);
						flight5.SetWaypoint1(array);
						Waypoint waypoint_3 = waypoint4;
						Aircraft aircraft_4 = aircraft_1;
						array = (flight3 = Flight_).GetWaypoint1();
						StrikePlanner.smethod_32(waypoint_3, aircraft_4, ref array, aircraft_1.GetLatitude(null), aircraft_1.GetLongitude(null), class85_0, Mission._RadarBehaviour.const_0, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref enum53_0);
						flight3.SetWaypoint1(array);
					}
					num3 = Flight_.GetWaypoint1().Count<Waypoint>();
					int num13 = -1;
					while (true)
					{
						num13++;
						if (num13 > Flight_.GetWaypoint1().Count<Waypoint>() - 1)
						{
							break;
						}
						if (flag2)
						{
							Flight_.GetWaypoint1()[num13].FlightFormation = Waypoint._FlightFormation.Split;
						}
						if (Flight_.GetWaypoint1()[num13] != waypoint && Flight_.GetWaypoint1()[num13] != waypoint3 && Flight_.GetWaypoint1()[num13].waypointType != Waypoint.WaypointType.TakeOff)
						{
							if (class85_0.AttackDistanceIngress > 0)
							{
								if (Flight_.GetWaypoint1()[num13].waypointType != Waypoint.WaypointType.InitialPoint && Flight_.GetWaypoint1()[num13].waypointType != Waypoint.WaypointType.WeaponLaunch)
								{
									if (Flight_.GetWaypoint1()[num13].waypointType == Waypoint.WaypointType.PathfindingPoint)
									{
										Flight_.GetWaypoint1()[num13].waypointType = Waypoint.WaypointType.TurningPoint;
										Flight_.GetWaypoint1()[num13].Category = Waypoint._Category.const_1;
										Flight_.GetWaypoint1()[num13].FlightFormation = enum53_0;
									}
								}
								else
								{
									if (num13 == 0)
									{
										float distance2 = Math2.GetDistance(Flight_.GetWaypoint1()[num13].GetLatitude(), Flight_.GetWaypoint1()[num13].GetLongitude(), aircraft_1.GetLatitude(null), aircraft_1.GetLongitude(null));
										if ((float)class85_0.AttackDistanceIngress > distance2)
										{
											Math2.GetAzimuth(aircraft_1.GetLatitude(null), aircraft_1.GetLongitude(null), Flight_.GetWaypoint1()[num13].GetLatitude(), Flight_.GetWaypoint1()[num13].GetLongitude());
											Waypoint waypoint5 = new Waypoint(aircraft_1.GetLongitude(null), aircraft_1.GetLatitude(null), Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
											Mission.Flight flight6 = Flight_;
											array = flight6.GetWaypoint1();
											ActiveUnit_Navigator.InsertWayPoint(ref array, num13, waypoint5);
											flight6.SetWaypoint1(array);
											Waypoint waypoint_4 = waypoint5;
											Aircraft aircraft_5 = aircraft_1;
											array = (flight3 = Flight_).GetWaypoint1();
											double latitude = aircraft_1.GetLatitude(null);
											double longitude = aircraft_1.GetLongitude(null);
											LoadoutMissionProfile class85_ = class85_0;
											Mission._RadarBehaviour enum63_ = enum63_0;
											Waypoint._FlightFormation flightFormation = Waypoint._FlightFormation.Spread;
											StrikePlanner.smethod_22(waypoint_4, aircraft_5, ref array, latitude, longitude, class85_, enum63_, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref flightFormation);
											flight3.SetWaypoint1(array);
											num13++;
										}
										else
										{
											float azimuth4 = Math2.GetAzimuth(Flight_.GetWaypoint1()[num13].GetLatitude(), Flight_.GetWaypoint1()[num13].GetLongitude(), aircraft_1.GetLatitude(null), aircraft_1.GetLongitude(null));
											Waypoint._FlightFormation flightFormation;
											if (float_4 > 0f && float_4 < (float)class85_0.AttackDistanceIngress)
											{
												float azimuth5;
												if (bool_0)
												{
													azimuth5 = Math2.GetAzimuth(Flight_.GetWaypoint1()[num13].GetLatitude(), Flight_.GetWaypoint1()[num13].GetLongitude(), aircraft_0.GetLatitude(null), aircraft_0.GetLongitude(null));
												}
												else
												{
													azimuth5 = Math2.GetAzimuth(Flight_.GetWaypoint1()[num13].GetLatitude(), Flight_.GetWaypoint1()[num13].GetLongitude(), geoPoint_1.GetLatitude(), geoPoint_1.GetLongitude());
												}
												float num14 = Math2.Normalize(azimuth5 + 180f);
												array = (flight3 = Flight_).GetWaypoint1();
												float float_12 = float_4;
												float float_13 = float_5;
												float float_14 = num14;
												float float_15 = float_1;
												flightFormation = Waypoint._FlightFormation.Spread;
												Mission._RadarBehaviour enum63_2 = enum63_0;
												float float_16 = 0f;
												LoadoutMissionProfile class85_2 = class85_0;
												float float_17 = float_7;
												Waypoint waypoint6 = null;
												Waypoint waypoint7 = null;
												bool flag4 = StrikePlanner.smethod_4(ref strike_0, ref Flight_, ref array, ref aircraft_0, ref contact_0, ref float_2, float_12, float_13, float_14, float_15, ref flightFormation, ref num9, enum63_2, ref num7, ref num8, ref flag3, ref speedPreset, float_16, class85_2, float_17, bool_0, false, false, ref waypoint6, ref waypoint7);
												flight3.SetWaypoint1(array);
												flag2 = flag4;
												num13 += 2;
											}
											if (float_7 < 6f)
											{
												GeoPointGenerator.GetOtherGeoPoint(Flight_.GetWaypoint1()[num13 + 1].GetLongitude(), Flight_.GetWaypoint1()[num13 + 1].GetLatitude(), ref num2, ref num, (double)class85_0.AttackDistanceIngress, (double)Math2.Normalize(azimuth4));
											}
											else
											{
												GeoPointGenerator.GetOtherGeoPoint(Flight_.GetWaypoint1()[num13].GetLongitude(), Flight_.GetWaypoint1()[num13].GetLatitude(), ref num2, ref num, (double)class85_0.AttackDistanceIngress, (double)Math2.Normalize(azimuth4));
											}
											Waypoint waypoint8 = new Waypoint(num2, num, Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
											Mission.Flight flight7 = Flight_;
											array = flight7.GetWaypoint1();
											ActiveUnit_Navigator.InsertWayPoint(ref array, num13, waypoint8);
											flight7.SetWaypoint1(array);
											Waypoint waypoint_5 = waypoint8;
											Aircraft aircraft_6 = aircraft_1;
											array = (flight3 = Flight_).GetWaypoint1();
											double double_ = num;
											double double_2 = num2;
											LoadoutMissionProfile class85_3 = class85_0;
											Mission._RadarBehaviour enum63_3 = enum63_0;
											flightFormation = Waypoint._FlightFormation.Spread;
											StrikePlanner.smethod_22(waypoint_5, aircraft_6, ref array, double_, double_2, class85_3, enum63_3, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref flightFormation);
											flight3.SetWaypoint1(array);
											num13++;
										}
									}
									else
									{
										float distance3;
										if (float_7 < 6f && num13 < Flight_.GetWaypoint1().Count<Waypoint>() - 1)
										{
											distance3 = Math2.GetDistance(Flight_.GetWaypoint1()[num13 + 1].GetLatitude(), Flight_.GetWaypoint1()[num13 + 1].GetLongitude(), Flight_.GetWaypoint1()[num13 - 1].GetLatitude(), Flight_.GetWaypoint1()[num13 - 1].GetLongitude());
										}
										else
										{
											distance3 = Math2.GetDistance(Flight_.GetWaypoint1()[num13].GetLatitude(), Flight_.GetWaypoint1()[num13].GetLongitude(), Flight_.GetWaypoint1()[num13 - 1].GetLatitude(), Flight_.GetWaypoint1()[num13 - 1].GetLongitude());
										}
										float azimuth6 = Math2.GetAzimuth(Flight_.GetWaypoint1()[num13].GetLatitude(), Flight_.GetWaypoint1()[num13].GetLongitude(), Flight_.GetWaypoint1()[num13 - 1].GetLatitude(), Flight_.GetWaypoint1()[num13 - 1].GetLongitude());
										if (float_4 > 0f && float_4 < (float)class85_0.AttackDistanceIngress && float_4 < distance3)
										{
											Waypoint waypoint_6 = new Waypoint(num2, num, Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
											Waypoint waypoint_7 = new Waypoint(num2, num, Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
											Mission.Flight flight8 = Flight_;
											array = flight8.GetWaypoint1();
											ActiveUnit_Navigator.InsertWayPoint(ref array, num13, waypoint_6);
											flight8.SetWaypoint1(array);
											Mission.Flight flight9 = Flight_;
											array = flight9.GetWaypoint1();
											ActiveUnit_Navigator.InsertWayPoint(ref array, num13 + 1, waypoint_7);
											flight9.SetWaypoint1(array);
											array = (flight3 = Flight_).GetWaypoint1();
											bool flag5 = StrikePlanner.smethod_4(ref strike_0, ref Flight_, ref array, ref aircraft_0, ref contact_0, ref float_2, float_4, float_5, Math2.Normalize(azimuth6 + 180f), float_1, ref enum53_0, ref num9, enum63_0, ref num7, ref num8, ref flag3, ref speedPreset, 0f, class85_0, float_7, bool_0, false, true, ref Flight_.GetWaypoint1()[num13], ref Flight_.GetWaypoint1()[num13 + 1]);
											flight3.SetWaypoint1(array);
											flag2 = flag5;
											num13 += 2;
										}
										if (distance3 > (float)class85_0.AttackDistanceIngress)
										{
											if (float_7 < 6f)
											{
												GeoPointGenerator.GetOtherGeoPoint(Flight_.GetWaypoint1()[num13 + 1].GetLongitude(), Flight_.GetWaypoint1()[num13 + 1].GetLatitude(), ref num2, ref num, (double)class85_0.AttackDistanceIngress, (double)Math2.Normalize(azimuth6));
											}
											else
											{
												GeoPointGenerator.GetOtherGeoPoint(Flight_.GetWaypoint1()[num13].GetLongitude(), Flight_.GetWaypoint1()[num13].GetLatitude(), ref num2, ref num, (double)class85_0.AttackDistanceIngress, (double)Math2.Normalize(azimuth6));
											}
											Waypoint waypoint9 = new Waypoint(num2, num, Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
											if (!flag2)
											{
												Mission.Flight flight10 = Flight_;
												array = flight10.GetWaypoint1();
												ActiveUnit_Navigator.InsertWayPoint(ref array, num13, waypoint9);
												flight10.SetWaypoint1(array);
											}
											else
											{
												Mission.Flight flight11 = Flight_;
												array = flight11.GetWaypoint1();
												ActiveUnit_Navigator.InsertWayPoint(ref array, num13 - 2, waypoint9);
												flight11.SetWaypoint1(array);
											}
											Waypoint waypoint_8 = waypoint9;
											Aircraft aircraft_7 = aircraft_1;
											array = (flight3 = Flight_).GetWaypoint1();
											double double_3 = num;
											double double_4 = num2;
											LoadoutMissionProfile class85_4 = class85_0;
											Mission._RadarBehaviour enum63_4 = enum63_0;
											Waypoint._FlightFormation flightFormation = Waypoint._FlightFormation.Spread;
											StrikePlanner.smethod_22(waypoint_8, aircraft_7, ref array, double_3, double_4, class85_4, enum63_4, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref flightFormation);
											flight3.SetWaypoint1(array);
											num13++;
											if (!flag2)
											{
												Waypoint waypoint_9 = new Waypoint(num2, num, Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
												Waypoint waypoint_10 = new Waypoint(num2, num, Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
												Mission.Flight flight12 = Flight_;
												array = flight12.GetWaypoint1();
												ActiveUnit_Navigator.InsertWayPoint(ref array, num13, waypoint_9);
												flight12.SetWaypoint1(array);
												Mission.Flight flight13 = Flight_;
												array = flight13.GetWaypoint1();
												ActiveUnit_Navigator.InsertWayPoint(ref array, num13 + 1, waypoint_10);
												flight13.SetWaypoint1(array);
												array = (flight3 = Flight_).GetWaypoint1();
												bool flag6 = StrikePlanner.smethod_4(ref strike_0, ref Flight_, ref array, ref aircraft_0, ref contact_0, ref float_2, float_4, float_5, Math2.Normalize(azimuth6 + 180f), float_1, ref enum53_0, ref num9, enum63_0, ref num7, ref num8, ref flag3, ref speedPreset, 0f, class85_0, float_7, bool_0, false, false, ref Flight_.GetWaypoint1()[num13], ref Flight_.GetWaypoint1()[num13 + 1]);
												flight3.SetWaypoint1(array);
												flag2 = flag6;
												num13 += 2;
											}
											num4 = (float)class85_0.AttackDistanceIngress;
										}
										else
										{
											num4 = distance3;
										}
									}
									if (num4 < (float)class85_0.AttackDistanceIngress)
									{
										for (int i = num13 - 1; i >= 0; i += -1)
										{
											if (Flight_.GetWaypoint1()[i].waypointType != Waypoint.WaypointType.StrikeIngress)
											{
												Flight_.GetWaypoint1()[i].waypointType = Waypoint.WaypointType.StrikeIngress;
												float num15 = (float)class85_0.AttackDistanceIngress - num4;
												float azimuth7 = Math2.GetAzimuth(Flight_.GetWaypoint1()[i - 1].GetLatitude(), Flight_.GetWaypoint1()[i - 1].GetLongitude(), Flight_.GetWaypoint1()[i].GetLatitude(), Flight_.GetWaypoint1()[i].GetLongitude());
												float azimuth8 = Math2.GetAzimuth(Flight_.GetWaypoint1()[i].GetLatitude(), Flight_.GetWaypoint1()[i].GetLongitude(), Flight_.GetWaypoint1()[i + 1].GetLatitude(), Flight_.GetWaypoint1()[i + 1].GetLongitude());
												float num16 = Math.Abs(Class263.RelativeBearingTo(azimuth7, azimuth8));
												num16 = Math2.Normalize(num16 * 2f);
												Misc.Enum102 @enum = Misc.smethod_63(azimuth7, azimuth8);
												float value = 0f;
												if (@enum != Misc.Enum102.const_0)
												{
													if (@enum == Misc.Enum102.const_1)
													{
														value = 9f;
													}
												}
												else
												{
													value = -9f;
												}
												float num17;
												switch (Flight_.GetWaypoint1()[i - 1].TurnRate)
												{
												case Waypoint._TurnRate.Standard:
													num17 = 3f;
													break;
												case Waypoint._TurnRate.Half:
													num17 = 1.5f;
													break;
												case Waypoint._TurnRate.Double:
													num17 = 6f;
													break;
												default:
													num17 = 3f;
													break;
												}
												float num18 = Math.Abs(value) / num17;
												float num19 = num9 / 3600f * num18;
												float num20 = (float)((double)num9 / ((double)num17 * 3.14159265358979 * 20.0));
												float num21 = (float)((double)(2f * num20) * Math.Sin(0.5 * Class263.ToRadians((double)num16))) + num19 * 2f;
												if (num15 < num21)
												{
													num15 = num21 + 1f;
												}
												if (i == 0)
												{
													float distance4 = Math2.GetDistance(Flight_.GetWaypoint1()[i].GetLatitude(), Flight_.GetWaypoint1()[i].GetLongitude(), aircraft_1.GetLatitude(null), aircraft_1.GetLongitude(null));
													if (num15 > distance4)
													{
														Math2.GetAzimuth(aircraft_1.GetLatitude(null), aircraft_1.GetLongitude(null), Flight_.GetWaypoint1()[i].GetLatitude(), Flight_.GetWaypoint1()[i].GetLongitude());
														Waypoint waypoint10 = new Waypoint(aircraft_1.GetLongitude(null), aircraft_1.GetLatitude(null), Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
														Mission.Flight flight14 = Flight_;
														array = flight14.GetWaypoint1();
														ActiveUnit_Navigator.InsertWayPoint(ref array, i, waypoint10);
														flight14.SetWaypoint1(array);
														Waypoint waypoint_11 = waypoint10;
														Aircraft aircraft_8 = aircraft_1;
														array = (flight3 = Flight_).GetWaypoint1();
														double latitude2 = aircraft_1.GetLatitude(null);
														double longitude2 = aircraft_1.GetLongitude(null);
														LoadoutMissionProfile class85_5 = class85_0;
														Mission._RadarBehaviour enum63_5 = enum63_0;
														Waypoint._FlightFormation flightFormation = Waypoint._FlightFormation.Spread;
														StrikePlanner.smethod_22(waypoint_11, aircraft_8, ref array, latitude2, longitude2, class85_5, enum63_5, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref flightFormation);
														flight3.SetWaypoint1(array);
														num13++;
													}
													else
													{
														float azimuth9 = Math2.GetAzimuth(Flight_.GetWaypoint1()[i].GetLatitude(), Flight_.GetWaypoint1()[i].GetLongitude(), aircraft_1.GetLatitude(null), aircraft_1.GetLongitude(null));
														GeoPointGenerator.GetOtherGeoPoint(Flight_.GetWaypoint1()[i].GetLongitude(), Flight_.GetWaypoint1()[i].GetLatitude(), ref num2, ref num, (double)num15, (double)Math2.Normalize(azimuth9));
														Waypoint waypoint11 = new Waypoint(num2, num, Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
														Mission.Flight flight15 = Flight_;
														array = flight15.GetWaypoint1();
														ActiveUnit_Navigator.InsertWayPoint(ref array, i, waypoint11);
														flight15.SetWaypoint1(array);
														Waypoint waypoint_12 = waypoint11;
														Aircraft aircraft_9 = aircraft_1;
														array = (flight3 = Flight_).GetWaypoint1();
														double double_5 = num;
														double double_6 = num2;
														LoadoutMissionProfile class85_6 = class85_0;
														Mission._RadarBehaviour enum63_6 = enum63_0;
														Waypoint._FlightFormation flightFormation = Waypoint._FlightFormation.Spread;
														StrikePlanner.smethod_22(waypoint_12, aircraft_9, ref array, double_5, double_6, class85_6, enum63_6, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref flightFormation);
														flight3.SetWaypoint1(array);
														num13++;
													}
													num4 += (float)class85_0.AttackDistanceIngress;
												}
												else
												{
													float distance5 = Math2.GetDistance(Flight_.GetWaypoint1()[i].GetLatitude(), Flight_.GetWaypoint1()[i].GetLongitude(), Flight_.GetWaypoint1()[i - 1].GetLatitude(), Flight_.GetWaypoint1()[i - 1].GetLongitude());
													if (distance5 > (float)class85_0.AttackDistanceIngress)
													{
														float azimuth10 = Math2.GetAzimuth(Flight_.GetWaypoint1()[i].GetLatitude(), Flight_.GetWaypoint1()[i].GetLongitude(), Flight_.GetWaypoint1()[i - 1].GetLatitude(), Flight_.GetWaypoint1()[i - 1].GetLongitude());
														GeoPointGenerator.GetOtherGeoPoint(Flight_.GetWaypoint1()[i].GetLongitude(), Flight_.GetWaypoint1()[i].GetLatitude(), ref num2, ref num, (double)num15, (double)Math2.Normalize(azimuth10));
														Waypoint waypoint12 = new Waypoint(num2, num, Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
														Mission.Flight flight16 = Flight_;
														array = flight16.GetWaypoint1();
														ActiveUnit_Navigator.InsertWayPoint(ref array, i, waypoint12);
														flight16.SetWaypoint1(array);
														Waypoint waypoint_13 = waypoint12;
														Aircraft aircraft_10 = aircraft_1;
														array = (flight3 = Flight_).GetWaypoint1();
														double double_7 = num;
														double double_8 = num2;
														LoadoutMissionProfile class85_7 = class85_0;
														Mission._RadarBehaviour enum63_7 = enum63_0;
														Waypoint._FlightFormation flightFormation = Waypoint._FlightFormation.Spread;
														StrikePlanner.smethod_22(waypoint_13, aircraft_10, ref array, double_7, double_8, class85_7, enum63_7, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref flightFormation);
														flight3.SetWaypoint1(array);
														num13++;
														num4 = (float)class85_0.AttackDistanceIngress;
													}
													else
													{
														num4 += distance5;
													}
												}
												if (num4 >= (float)class85_0.AttackDistanceIngress)
												{
													break;
												}
											}
										}
									}
								}
							}
							else if (Flight_.GetWaypoint1()[num13].waypointType == Waypoint.WaypointType.PathfindingPoint)
							{
								Flight_.GetWaypoint1()[num13].waypointType = Waypoint.WaypointType.TurningPoint;
								Flight_.GetWaypoint1()[num13].Category = Waypoint._Category.const_1;
								Flight_.GetWaypoint1()[num13].FlightFormation = enum53_0;
							}
						}
					}
					Waypoint waypoint_14 = waypoint2;
					Aircraft aircraft_11 = aircraft_1;
					array = (flight3 = Flight_).GetWaypoint1();
					StrikePlanner.smethod_25(waypoint_14, aircraft_11, ref array, waypoint2.GetLatitude(), waypoint2.GetLongitude(), class85_0, enum63_0, float_7, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref strike_0.AttackMethod, ref enum53_0);
					flight3.SetWaypoint1(array);
					Waypoint waypoint_15 = waypoint;
					Aircraft aircraft_12 = aircraft_0;
					array = (flight3 = Flight_).GetWaypoint1();
					StrikePlanner.smethod_26(waypoint_15, aircraft_12, ref array, waypoint.GetLatitude(), waypoint.GetLongitude(), class85_0, enum63_0, float_7, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref strike_0.AttackMethod, ref enum53_0);
					flight3.SetWaypoint1(array);
					double num22 = 0.0;
					double num23 = 0.0;
					float num24 = 0f;
					if (strike_0.AttackMethod >= Mission._AttackMethod.const_2)
					{
						float azimuth11 = Math2.GetAzimuth(geoPoint_0.GetLatitude(), geoPoint_0.GetLongitude(), num, num2);
						float azimuth12 = Math2.GetAzimuth(num, num2, num22, num23);
						enum102_0 = Misc.smethod_63(azimuth11, azimuth12);
						Misc.Enum102 enum2 = enum102_0;
						if (enum2 != Misc.Enum102.const_0)
						{
							if (enum2 == Misc.Enum102.const_1)
							{
								num24 = 270f;
							}
						}
						else
						{
							num24 = 90f;
						}
					}
					if (Flight_.GetWaypoint2().Count<Waypoint>() == 0 && !bool_0)
					{
						num3 = Flight_.GetWaypoint1().Count<Waypoint>();
						for (int j = num3 - 1; j >= 0; j += -1)
						{
							if (Flight_.GetWaypoint1()[j].waypointType != Waypoint.WaypointType.InitialPoint && Flight_.GetWaypoint1()[j].waypointType != Waypoint.WaypointType.WeaponLaunch && Flight_.GetWaypoint1()[j].waypointType != Waypoint.WaypointType.Assemble && Flight_.GetWaypoint1()[j].waypointType != Waypoint.WaypointType.TakeOff && Flight_.GetWaypoint1()[j].waypointType != Waypoint.WaypointType.Target && Flight_.GetWaypoint1()[j].waypointType != Waypoint.WaypointType.WeaponTarget)
							{
								Flight_.GetWaypoint1()[j].GetLatitude();
								Flight_.GetWaypoint1()[j].GetLongitude();
								if (j < num3 - 1 && (Flight_.GetWaypoint1()[j + 1].waypointType == Waypoint.WaypointType.InitialPoint || Flight_.GetWaypoint1()[j + 1].waypointType == Waypoint.WaypointType.WeaponLaunch))
								{
									if (flag2 && j > 0)
									{
										float azimuth13 = Math2.GetAzimuth(num6, num5, waypoint.GetLatitude(), waypoint.GetLongitude());
										array = (flight3 = Flight_).GetWaypoint2();
										double double_9 = num6;
										double double_10 = num5;
										float float_18 = (float)class85_0.AttackDistanceEgress;
										float float_19 = float_7;
										float float_20 = Math2.Normalize(azimuth13 + 180f);
										float float_21 = float_2;
										float float_22 = float_4;
										float float_23 = float_5;
										float float_24 = num24;
										float float_25 = 0f;
										LoadoutMissionProfile class85_8 = class85_0;
										Waypoint waypoint7 = null;
										Waypoint waypoint6 = null;
										StrikePlanner.smethod_5(ref strike_0, ref Flight_, ref array, ref aircraft_0, ref contact_0, double_9, double_10, float_18, float_19, float_20, float_21, float_22, float_23, ref enum53_0, ref num9, ref num7, ref num8, ref flag3, ref speedPreset, float_24, float_25, class85_8, bool_0, false, ref waypoint7, ref waypoint6);
										flight3.SetWaypoint2(array);
										j--;
									}
								}
								else if (Flight_.GetWaypoint1()[j].waypointType == Waypoint.WaypointType.StrikeIngress && Flight_.GetWaypoint1()[j].Creator == Waypoint._Creator.const_0)
								{
									Waypoint waypoint13 = new Waypoint(Flight_.GetWaypoint1()[j].GetLongitude(), Flight_.GetWaypoint1()[j].GetLatitude(), Waypoint.WaypointType.StrikeEgress, Waypoint._Creator.const_0, Waypoint._Category.const_1);
									Mission.Flight flight17 = Flight_;
									array = flight17.GetWaypoint2();
									ScenarioArrayUtil.AddWaypoint(ref array, waypoint13);
									flight17.SetWaypoint2(array);
									waypoint13.FlightFormation = Flight_.GetWaypoint1()[j].FlightFormation;
								}
								else if (Flight_.GetWaypoint1()[j].waypointType == Waypoint.WaypointType.StrikeIngress && Flight_.GetWaypoint1()[j].Creator == Waypoint._Creator.const_3)
								{
									Waypoint waypoint_16 = null;
									Aircraft aircraft_13 = aircraft_1;
									array = (flight3 = Flight_).GetWaypoint2();
									StrikePlanner.smethod_33(waypoint_16, aircraft_13, ref array, Flight_.GetWaypoint1()[j].GetLatitude(), Flight_.GetWaypoint1()[j].GetLongitude(), class85_0, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref Flight_.GetWaypoint1()[j].FlightFormation);
									flight3.SetWaypoint2(array);
								}
								else if (Flight_.GetWaypoint1()[j].waypointType == Waypoint.WaypointType.TurningPoint)
								{
									Waypoint waypoint14 = new Waypoint(Flight_.GetWaypoint1()[j].GetLongitude(), Flight_.GetWaypoint1()[j].GetLatitude(), Waypoint.WaypointType.TurningPoint, Waypoint._Creator.const_3, Waypoint._Category.const_1);
									Mission.Flight flight18 = Flight_;
									array = flight18.GetWaypoint2();
									ScenarioArrayUtil.AddWaypoint(ref array, waypoint14);
									flight18.SetWaypoint2(array);
									waypoint14.FlightFormation = Flight_.GetWaypoint1()[j].FlightFormation;
								}
							}
						}
						Waypoint waypoint_17 = null;
						Aircraft aircraft_14 = aircraft_1;
						array = (flight3 = Flight_).GetWaypoint2();
						StrikePlanner.smethod_29(waypoint_17, aircraft_14, ref array, geoPoint_1.GetLatitude(), geoPoint_1.GetLongitude(), class85_0, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref enum53_0);
						flight3.SetWaypoint2(array);
					}
					else
					{
						Flight_.SetWaypoint2(Flight_.GetWaypoint2());
						num3 = Flight_.GetWaypoint2().Count<Waypoint>();
						for (int k = num3 - 1; k >= 0; k += -1)
						{
							if (k == num3 - 1)
							{
								Waypoint waypoint_18 = Flight_.GetWaypoint2()[k];
								Aircraft aircraft_15 = aircraft_1;
								array = (flight3 = Flight_).GetWaypoint2();
								StrikePlanner.smethod_29(waypoint_18, aircraft_15, ref array, geoPoint_1.GetLatitude(), geoPoint_1.GetLongitude(), class85_0, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref enum53_0);
								flight3.SetWaypoint2(array);
							}
							else if (Flight_.GetWaypoint2()[k].waypointType == Waypoint.WaypointType.PathfindingPoint)
							{
								Flight_.GetWaypoint2()[k].waypointType = Waypoint.WaypointType.TurningPoint;
								Flight_.GetWaypoint1()[k].Category = Waypoint._Category.const_1;
								Flight_.GetWaypoint1()[k].FlightFormation = enum53_0;
							}
						}
					}
					Waypoint[] array2;
					checked
					{
						if (Flight_.GetWaypoint2().Count<Waypoint>() > 0)
						{
							array = Flight_.GetWaypoint2();
							for (int l = 0; l < array.Length; l++)
							{
								Waypoint waypoint15 = array[l];
								Mission.Flight flight19 = Flight_;
								array2 = flight19.GetWaypoint1();
								ScenarioArrayUtil.AddWaypoint(ref array2, waypoint15.method_23(ref aircraft_0.m_Scenario, ref waypoint15, true, true));
								flight19.SetWaypoint1(array2);
							}
							Mission.Flight flight20 = Flight_;
							array2 = flight20.GetWaypoint2();
							ScenarioArrayUtil.ClearWaypoints(ref array2);
							flight20.SetWaypoint2(array2);
						}
						Waypoint waypoint_19 = null;
						Aircraft aircraft_16 = aircraft_1;
						array2 = (flight3 = Flight_).GetWaypoint1();
						StrikePlanner.smethod_31(waypoint_19, aircraft_16, ref array2, geoPoint_2.GetLatitude(), geoPoint_2.GetLongitude(), class85_0, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref enum53_0);
						flight3.SetWaypoint1(array2);
					}
					if (bool_0 && class85_0.AttackDistanceEgress > 0)
					{
						num4 = 0f;
						num3 = Flight_.GetWaypoint1().Count<Waypoint>();
						int num25 = num3 - 2;
						for (int m = 0; m <= num25; m++)
						{
							if (Flight_.GetWaypoint1()[m].waypointType == Waypoint.WaypointType.Target || Flight_.GetWaypoint1()[m].waypointType == Waypoint.WaypointType.WeaponTarget)
							{
								float distance6 = Math2.GetDistance(Flight_.GetWaypoint1()[m].GetLatitude(), Flight_.GetWaypoint1()[m].GetLongitude(), Flight_.GetWaypoint1()[m + 1].GetLatitude(), Flight_.GetWaypoint1()[m + 1].GetLongitude());
								if (distance6 > (float)class85_0.AttackDistanceEgress + float_1)
								{
									float azimuth14 = Math2.GetAzimuth(Flight_.GetWaypoint1()[m].GetLatitude(), Flight_.GetWaypoint1()[m].GetLongitude(), Flight_.GetWaypoint1()[m + 1].GetLatitude(), Flight_.GetWaypoint1()[m + 1].GetLongitude());
									if (float_7 < 6f)
									{
										GeoPointGenerator.GetOtherGeoPoint(Flight_.GetWaypoint1()[m].GetLongitude(), Flight_.GetWaypoint1()[m].GetLatitude(), ref num23, ref num22, (double)class85_0.AttackDistanceEgress, (double)Math2.Normalize(azimuth14));
									}
									else
									{
										GeoPointGenerator.GetOtherGeoPoint(Flight_.GetWaypoint1()[m].GetLongitude(), Flight_.GetWaypoint1()[m].GetLatitude(), ref num23, ref num22, (double)((float)class85_0.AttackDistanceEgress + float_1), (double)Math2.Normalize(azimuth14));
									}
									Waypoint waypoint16 = new Waypoint(num23, num22, Waypoint.WaypointType.StrikeEgress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
									Mission.Flight flight21 = Flight_;
									array2 = flight21.GetWaypoint1();
									ActiveUnit_Navigator.InsertWayPoint(ref array2, m + 1, waypoint16);
									flight21.SetWaypoint1(array2);
									Waypoint waypoint_20 = waypoint16;
									Aircraft aircraft_17 = aircraft_1;
									array2 = (flight3 = Flight_).GetWaypoint1();
									StrikePlanner.smethod_33(waypoint_20, aircraft_17, ref array2, num22, num23, class85_0, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref enum53_0);
									flight3.SetWaypoint1(array2);
									break;
								}
								num4 = distance6;
							}
							else if (num4 > 0f)
							{
								float distance7 = Math2.GetDistance(Flight_.GetWaypoint1()[m].GetLatitude(), Flight_.GetWaypoint1()[m].GetLongitude(), Flight_.GetWaypoint1()[m + 1].GetLatitude(), Flight_.GetWaypoint1()[m + 1].GetLongitude());
								num4 += distance7;
								if (num4 > (float)class85_0.AttackDistanceEgress + float_1)
								{
									float num26 = num4 - distance7;
									float num27;
									if (float_7 < 6f)
									{
										num27 = (float)class85_0.AttackDistanceEgress - num26;
									}
									else
									{
										num27 = (float)class85_0.AttackDistanceEgress + float_1 - num26;
									}
									float azimuth15 = Math2.GetAzimuth(Flight_.GetWaypoint1()[m].GetLatitude(), Flight_.GetWaypoint1()[m].GetLongitude(), Flight_.GetWaypoint1()[m + 1].GetLatitude(), Flight_.GetWaypoint1()[m + 1].GetLongitude());
									GeoPointGenerator.GetOtherGeoPoint(Flight_.GetWaypoint1()[m].GetLongitude(), Flight_.GetWaypoint1()[m].GetLatitude(), ref num23, ref num22, (double)num27, (double)Math2.Normalize(azimuth15));
									Waypoint waypoint17 = new Waypoint(num23, num22, Waypoint.WaypointType.StrikeEgress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
									Mission.Flight flight22 = Flight_;
									array2 = flight22.GetWaypoint1();
									ActiveUnit_Navigator.InsertWayPoint(ref array2, m + 1, waypoint17);
									flight22.SetWaypoint1(array2);
									Waypoint waypoint_21 = waypoint17;
									Aircraft aircraft_18 = aircraft_1;
									array2 = (flight3 = Flight_).GetWaypoint1();
									StrikePlanner.smethod_33(waypoint_21, aircraft_18, ref array2, num22, num23, class85_0, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref enum53_0);
									flight3.SetWaypoint1(array2);
									break;
								}
							}
						}
					}
					if (Information.IsNothing(nullable_1))
					{
						Aircraft_Navigator aircraftNavigator = aircraft_1.GetAircraftNavigator();
						bool flag7 = false;
						float transitAltitude = aircraftNavigator.GetTransitAltitude(ref flag7);
						nullable_1 = new bool?(aircraft_1.GetAircraftAI().method_19(aircraft_1, contact_0, (float)aircraft_0.GetLoadout().CombatRadius, new float?(transitAltitude)));
					}
					array2 = Flight_.GetWaypoint1();
					Waypoint[] waypoint_23;
					bool flag8;
					checked
					{
						for (int n = 0; n < array2.Length; n++)
						{
							Waypoint waypoint18 = array2[n];
							if (waypoint18.waypointType != Waypoint.WaypointType.TurningPoint && waypoint18.waypointType != Waypoint.WaypointType.TakeOff)
							{
								if (!Information.IsNothing(waypoint18.DesiredAltitude))
								{
									num7 = waypoint18.DesiredAltitude.Value;
								}
								else
								{
									num7 = 0f;
								}
								if (!Information.IsNothing(waypoint18.DesiredAltitude_TerrainFollowing))
								{
									num8 = waypoint18.DesiredAltitude_TerrainFollowing.Value;
								}
								else
								{
									num8 = 0f;
								}
								flag3 = waypoint18.IsTerrainFollowing();
								speedPreset = waypoint18.GetThrottlePreset();
							}
							else if (waypoint18.waypointType == Waypoint.WaypointType.TurningPoint)
							{
								Waypoint waypoint_22 = waypoint18;
								Aircraft aircraft_19 = aircraft_1;
								waypoint_23 = (flight3 = Flight_).GetWaypoint1();
								StrikePlanner.smethod_34(waypoint_22, aircraft_19, ref waypoint_23, waypoint18.GetLatitude(), waypoint18.GetLongitude(), class85_0, ref num7, ref num8, ref flag3, ref speedPreset, ref num9, ref enum53_0);
								flight3.SetWaypoint1(waypoint_23);
							}
						}
						StrikePlanner.smethod_7(aircraft_0, Flight_.GetWaypoint1());
						Scenario scenario = aircraft_0.m_Scenario;
						Mission assignedMission = aircraft_0.GetAssignedMission(false);
						ActiveUnit theFlightReferenceUnit_ = aircraft_1;
						Mission.Flight theFlight_ = null;
						waypoint_23 = (flight3 = Flight_).GetWaypoint1();
						flag8 = StrikePlanner.smethod_8(scenario, assignedMission, theFlightReferenceUnit_, theFlight_, ref waypoint_23, strike_0.Bingo, ref float_0, float_9, true, false, true, true, true, true, false, null, 0f, 0f, 0f, enum102_0, new bool?(bool_1), bool_0);
						flight3.SetWaypoint1(waypoint_23);
					}
					if (!flag8)
					{
						bool? flag9 = nullable_1;
						if (!(flag9.HasValue ? new bool?(flag9.GetValueOrDefault()) : null).GetValueOrDefault())
						{
							Mission.Flight flight23 = Flight_;
							waypoint_23 = flight23.GetWaypoint1();
							ScenarioArrayUtil.ClearWaypoints(ref waypoint_23);
							flight23.SetWaypoint1(waypoint_23);
							bool? flag10 = nullable_1;
							flag9 = (flag10.HasValue ? new bool?(flag10.GetValueOrDefault()) : null);
							if ((flag9.HasValue ? new bool?(!flag9.GetValueOrDefault()) : flag9).GetValueOrDefault())
							{
								if (!aircraft_1.BoomRefuelling && !aircraft_1.ProbeRefuelling)
								{
									string_0 = string.Concat(new string[]
									{
										"There is not enough fuel for flightplan. No flight plan has been generated. Mission fuel required: ",
										Conversions.ToString((int)Math.Round((double)float_0)),
										" kg. Mission fuel available on aircraft (reserve fuel subtracted): ",
										Conversions.ToString((int)Math.Round((double)float_9)),
										" kg."
									});
								}
								else
								{
									string_0 = string.Concat(new string[]
									{
										"No aerial tankers were found and there is not enough fuel for flightplan. The target is out of reach and no flight plan has been generated. Mission fuel required: ",
										Conversions.ToString((int)Math.Round((double)float_0)),
										" kg. Mission fuel available on aircraft (reserve fuel subtracted): ",
										Conversions.ToString((int)Math.Round((double)float_9)),
										" kg."
									});
								}
							}
							else
							{
								string_0 = string.Concat(new string[]
								{
									"Aerial tankers found but the distance to them is too long. The target is out of reach and no flightplan has been generated. Mission fuel required: ",
									Conversions.ToString((int)Math.Round((double)float_0)),
									" kg. Mission fuel available on aircraft (reserve fuel subtracted): ",
									Conversions.ToString((int)Math.Round((double)float_9)),
									" kg."
								});
							}
							flag = false;
							result = false;
							return result;
						}
					}
					Scenario scenario2 = aircraft_0.m_Scenario;
					Mission assignedMission2 = aircraft_0.GetAssignedMission(false);
					ActiveUnit theFlightReferenceUnit_2 = aircraft_0;
					Mission.Flight theFlight_2 = null;
					waypoint_23 = (flight3 = Flight_).GetWaypoint1();
					StrikePlanner.smethod_8(scenario2, assignedMission2, theFlightReferenceUnit_2, theFlight_2, ref waypoint_23, strike_0.Bingo, ref float_0, float_9, false, true, false, false, true, false, true, null, float_4, float_5, float_6, enum102_0, new bool?(bool_1), bool_0);
					flight3.SetWaypoint1(waypoint_23);
					flag = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200655", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x003B07A0 File Offset: 0x003AE9A0
		public static bool smethod_3(ref Aircraft aircraft_0, ref Mission.Flight class168_0, float float_0, bool bool_0)
		{
			bool flag = false;
			bool result;
			try
			{
				if (aircraft_0.GetSide(false).NoNavZoneList.Count > 0 && class168_0.GetFlightCourse().Count<Waypoint>() > 0)
				{
					int num = class168_0.GetFlightCourse().Count<Waypoint>() - 2;
					for (int i = 0; i <= num; i++)
					{
						if (class168_0.GetFlightCourse()[i].waypointType != Waypoint.WaypointType.Target && class168_0.GetFlightCourse()[i].waypointType != Waypoint.WaypointType.WeaponTarget)
						{
							double latitude = class168_0.GetFlightCourse()[i].GetLatitude();
							double longitude = class168_0.GetFlightCourse()[i].GetLongitude();
							double latitude2;
							double longitude2;
							if (class168_0.GetFlightCourse()[i].waypointType == Waypoint.WaypointType.InitialPoint || class168_0.GetFlightCourse()[i].waypointType == Waypoint.WaypointType.WeaponLaunch)
							{
								latitude2 = class168_0.GetFlightCourse()[i + 2].GetLatitude();
								longitude2 = class168_0.GetFlightCourse()[i + 2].GetLongitude();
							}
							else
							{
								latitude2 = class168_0.GetFlightCourse()[i + 1].GetLatitude();
								longitude2 = class168_0.GetFlightCourse()[i + 1].GetLongitude();
							}
							if (latitude != latitude2)
							{
								goto IL_119;
							}
							if (longitude != longitude2)
							{
								goto IL_119;
							}
							bool arg_139_0 = false;
							IL_139:
							if (!arg_139_0)
							{
								goto IL_13B;
							}
							Mission.Flight flight = class168_0;
							Waypoint[] flightCourse = flight.GetFlightCourse();
							ScenarioArrayUtil.ClearWaypoints(ref flightCourse);
							flight.SetFlightCourse(flightCourse);
							if (bool_0)
							{
								aircraft_0.m_Scenario.LogMessage(string.Concat(new string[]
								{
									aircraft_0.UnitClass,
									" with loadout ",
									aircraft_0.GetLoadout().Name,
									" on mission ",
									aircraft_0.GetAssignedMission(false).Name,
									" were unable to plot a multi-leg strike course because of No-Navigation Zones. Attempting to find an alternative route"
								}), LoggedMessage.MessageType.AirOps, 0, aircraft_0.GetGuid(), aircraft_0.GetSide(false), new GeoPoint(aircraft_0.GetLongitude(null), aircraft_0.GetLatitude(null)));
							}
							flag = true;
							result = true;
							return result;
							IL_119:
							arg_139_0 = aircraft_0.GetAircraftNavigator().vmethod_16(latitude, longitude, latitude2, longitude2, true, float_0, false, null);
							goto IL_139;
						}
						IL_13B:;
					}
				}
				flag = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200607", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x003B0A2C File Offset: 0x003AEC2C
		private static bool smethod_4(ref Strike strike_0, ref Mission.Flight class168_0, ref Waypoint[] waypoint_0, ref Aircraft aircraft_0, ref Contact contact_0, ref float float_0, float float_1, float float_2, float float_3, float float_4, ref Waypoint._FlightFormation enum53_0, ref float float_5, Mission._RadarBehaviour enum63_0, ref float float_6, ref float float_7, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, float float_8, LoadoutMissionProfile class85_0, float float_9, bool bool_1, bool bool_2, bool bool_3, ref Waypoint waypoint_1, ref Waypoint waypoint_2)
		{
			bool flag = false;
			bool result;
			try
			{
				if (bool_1)
				{
					if (!aircraft_0.HasParentGroup())
					{
						flag = false;
						result = false;
						return result;
					}
				}
				else if (aircraft_0.GetAssignedMission(false).m_FlightSize == Mission._FlightSize.SingleAircraft)
				{
					flag = false;
					result = false;
					return result;
				}
				Mission._FlightSize flightSize = Mission._FlightSize.None;
				if (bool_1)
				{
					if (!Information.IsNothing(aircraft_0.GetParentGroup(false)))
					{
						flightSize = (Mission._FlightSize)aircraft_0.GetParentGroup(false).GetUnitsInGroup().Count;
					}
				}
				else
				{
					flightSize = strike_0.m_FlightSize;
				}
				if (flightSize > Mission._FlightSize.SingleAircraft && strike_0.AttackMethod >= Mission._AttackMethod.const_2)
				{
					if (float_0 > float_1)
					{
						double num = 0.0;
						double num2 = 0.0;
						if (bool_2)
						{
							num = aircraft_0.GetLatitude(null);
							num2 = aircraft_0.GetLongitude(null);
						}
						else if (float_9 < 6f)
						{
							GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num2, ref num, (double)float_1, (double)Math2.Normalize(float_3 + 180f + float_8));
						}
						else
						{
							GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num2, ref num, (double)(float_4 + float_1), (double)Math2.Normalize(float_3 + 180f + float_8));
						}
						StrikePlanner.smethod_23(waypoint_1, aircraft_0, ref waypoint_0, num, num2, class85_0, enum63_0, ref float_6, ref float_7, ref bool_0, ref enum6_0, ref float_5, ref strike_0.AttackMethod, ref enum53_0);
						if (!Information.IsNothing(waypoint_1))
						{
							waypoint_1.SetLatitude(num);
							waypoint_1.SetLongitude(num2);
						}
						if (bool_3)
						{
							Waypoint waypoint;
							if (!Information.IsNothing(waypoint_1))
							{
								waypoint = waypoint_1;
							}
							else
							{
								waypoint = waypoint_0[waypoint_0.Count<Waypoint>() - 1];
							}
							Waypoint waypoint_3 = waypoint;
							Aircraft aircraft_ = aircraft_0;
							double double_ = num;
							double double_2 = num2;
							Waypoint._FlightFormation flightFormation = Waypoint._FlightFormation.Spread;
							StrikePlanner.smethod_22(waypoint_3, aircraft_, ref waypoint_0, double_, double_2, class85_0, enum63_0, ref float_6, ref float_7, ref bool_0, ref enum6_0, ref float_5, ref flightFormation);
						}
						double num3 = 0.0;
						double num4 = 0.0;
						if (float_9 < 6f)
						{
							GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num3, ref num4, (double)float_2, (double)Math2.Normalize(float_3 + 180f + float_8));
						}
						else
						{
							GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num3, ref num4, (double)(float_4 + float_2), (double)Math2.Normalize(float_3 + 180f + float_8));
						}
						StrikePlanner.smethod_24(waypoint_2, aircraft_0, ref waypoint_0, num4, num3, class85_0, enum63_0, ref float_6, ref float_7, ref bool_0, ref enum6_0, ref float_5, ref strike_0.AttackMethod, ref enum53_0);
						if (!Information.IsNothing(waypoint_2))
						{
							waypoint_2.SetLatitude(num4);
							waypoint_2.SetLongitude(num3);
						}
						flag = true;
						result = true;
						return result;
					}
					if (bool_1)
					{
						string text = "";
						if (Operators.CompareString(aircraft_0.Name, aircraft_0.UnitClass, false) != 0)
						{
							text = " (" + aircraft_0.UnitClass + ")";
						}
						string text2;
						if (aircraft_0.GetAssignedMission(false).category == Mission.MissionCategory.Package)
						{
							text2 = "";
						}
						else
						{
							text2 = "Mission ";
						}
						aircraft_0.m_Scenario.LogMessage(string.Concat(new string[]
						{
							text2,
							aircraft_0.GetAssignedMission(false).Name,
							" with aircraft type ",
							text,
							" is too close to the target and the mission planner could not generate a multi-axis stacked ToT flightplan. Using single-axis formation attack instead."
						}), LoggedMessage.MessageType.AirOps, 15, aircraft_0.GetGuid(), aircraft_0.GetSide(false), new GeoPoint(aircraft_0.GetLongitude(null), aircraft_0.GetLatitude(null)));
					}
				}
				flag = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 999999", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x003B0E88 File Offset: 0x003AF088
		private static bool smethod_5(ref Strike strike_0, ref Mission.Flight class168_0, ref Waypoint[] waypoint_0, ref Aircraft aircraft_0, ref Contact contact_0, double double_0, double double_1, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, ref Waypoint._FlightFormation enum53_0, ref float float_6, ref float float_7, ref float float_8, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, float float_9, float float_10, LoadoutMissionProfile class85_0, bool bool_1, bool bool_2, ref Waypoint waypoint_1, ref Waypoint waypoint_2)
		{
			bool flag = false;
			bool result;
			try
			{
				if (bool_1)
				{
					if (!aircraft_0.HasParentGroup())
					{
						flag = false;
						result = false;
						return result;
					}
				}
				else if (aircraft_0.GetAssignedMission(false).m_FlightSize == Mission._FlightSize.SingleAircraft)
				{
					flag = false;
					result = false;
					return result;
				}
				Mission._FlightSize flightSize = Mission._FlightSize.None;
				if (bool_1)
				{
					if (!Information.IsNothing(aircraft_0.GetParentGroup(false)))
					{
						flightSize = (Mission._FlightSize)aircraft_0.GetParentGroup(false).GetUnitsInGroup().Count;
					}
				}
				else
				{
					flightSize = strike_0.m_FlightSize;
				}
				if (flightSize > Mission._FlightSize.SingleAircraft && strike_0.AttackMethod >= Mission._AttackMethod.const_2 && float_3 > float_5)
				{
					Mission._AttackMethod attackMethod = strike_0.AttackMethod;
					float num;
					if (attackMethod == Mission._AttackMethod.const_2)
					{
						num = (float)((int)flightSize * (int)(Mission._FlightSize)7);
					}
					else
					{
						num = ((attackMethod == Mission._AttackMethod.const_3) ? ((float)((int)flightSize * (int)(Mission._FlightSize)25)) : ((float)((int)flightSize * (int)Mission._FlightSize.ThreeAircraft)));
					}
					float num2 = num * float_6 / 3600f;
					num2 = (float)Math.Sqrt(Math.Pow((double)(float_4 + num2 / 2f), 2.0) - Math.Pow((double)float_4, 2.0));
					double num3 = 0.0;
					double num4 = 0.0;
					if (float_1 < 6f)
					{
						GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num3, ref num4, (double)(float_4 / 2f), (double)(float_2 + float_10));
					}
					else
					{
						GeoPointGenerator.GetOtherGeoPoint(double_1, double_0, ref num3, ref num4, (double)(float_4 / 2f), (double)(float_2 + float_10));
					}
					GeoPointGenerator.GetOtherGeoPoint(num3, num4, ref num3, ref num4, (double)num2, (double)Math2.Normalize(float_2 + float_10 + float_9));
					StrikePlanner.smethod_28(waypoint_1, aircraft_0, ref waypoint_0, num4, num3, class85_0, ref float_7, ref float_8, ref bool_0, ref enum6_0, ref float_6, ref strike_0.AttackMethod, ref enum53_0);
					if (!Information.IsNothing(waypoint_1))
					{
						waypoint_1.SetLatitude(num4);
						waypoint_1.SetLongitude(num3);
					}
					double num5 = 0.0;
					double num6 = 0.0;
					if (float_1 < 6f)
					{
						GeoPointGenerator.GetOtherGeoPoint(contact_0.GetLongitude(null), contact_0.GetLatitude(null), ref num5, ref num6, (double)float_4, (double)Math2.Normalize(float_2 + float_10));
					}
					else
					{
						GeoPointGenerator.GetOtherGeoPoint(double_1, double_0, ref num5, ref num6, (double)float_4, (double)Math2.Normalize(float_2 + float_10));
					}
					StrikePlanner.smethod_27(waypoint_2, aircraft_0, ref waypoint_0, num6, num5, class85_0, ref float_7, ref float_8, ref bool_0, ref enum6_0, ref float_6, ref strike_0.AttackMethod, ref enum53_0);
					if (!Information.IsNothing(waypoint_2))
					{
						waypoint_2.SetLatitude(num4);
						waypoint_2.SetLongitude(num3);
					}
					if (bool_2)
					{
						Waypoint waypoint;
						if (!Information.IsNothing(waypoint_2))
						{
							waypoint = waypoint_2;
						}
						else
						{
							waypoint = waypoint_0[waypoint_0.Count<Waypoint>() - 1];
						}
						Waypoint waypoint_3 = waypoint;
						Aircraft aircraft_ = aircraft_0;
						double double_2 = num6;
						double double_3 = num5;
						Waypoint._FlightFormation flightFormation = Waypoint._FlightFormation.Spread;
						StrikePlanner.smethod_33(waypoint_3, aircraft_, ref waypoint_0, double_2, double_3, class85_0, ref float_7, ref float_8, ref bool_0, ref enum6_0, ref float_6, ref flightFormation);
					}
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 999999", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x003B11F0 File Offset: 0x003AF3F0
		public static float smethod_6(ref Aircraft aircraft_0)
		{
			float result = 0f;
			try
			{
				if (!Information.IsNothing(aircraft_0.GetLoadout()))
				{
					float formUpAltitude = aircraft_0.GetLoadout().GetMissionProfile(aircraft_0.m_Scenario).FormUpAltitude;
					int num = aircraft_0.GetLoadout().GetMissionProfile(aircraft_0.m_Scenario).FormUpTime * 60;
					if (num > 0 && formUpAltitude > 0f)
					{
						result = aircraft_0.GetAircraftKinematics().method_7(num, ActiveUnit.Throttle.Cruise, formUpAltitude, new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(formUpAltitude, ActiveUnit.Throttle.Cruise)), false);
					}
					else
					{
						result = 0f;
					}
				}
				else
				{
					result = 0f;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200608", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006B76 RID: 27510 RVA: 0x003B12EC File Offset: 0x003AF4EC
		private static void smethod_7(Aircraft aircraft_0, Waypoint[] waypoint_0)
		{
			try
			{
				int num = waypoint_0.Count<Waypoint>();
				bool flag = true;
				Doctrine._UseRefuel? useRefuelDoctrine = aircraft_0.GetAssignedMission(false).m_Doctrine.GetUseRefuelDoctrine(aircraft_0.m_Scenario, false, false, false, false);
				Doctrine._RefuelSelection? refuelSelectionDoctrine = aircraft_0.GetAssignedMission(false).m_Doctrine.GetRefuelSelectionDoctrine(aircraft_0.m_Scenario, false, false, false, false);
				int num2 = num - 1;
				int i = 0;
				while (i <= num2)
				{
					Waypoint waypoint = waypoint_0[i];
					switch (waypoint.waypointType)
					{
					case Waypoint.WaypointType.InitialPoint:
					case Waypoint.WaypointType.Target:
					case Waypoint.WaypointType.WeaponLaunch:
					case Waypoint.WaypointType.WeaponTarget:
						waypoint.m_Doctrine.SetUseRefuelDoctrine(aircraft_0.m_Scenario, false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_1));
						waypoint.m_Doctrine.SetRefuelSelectionDoctrine(aircraft_0.m_Scenario, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_1));
						flag = false;
						break;
					case Waypoint.WaypointType.Split:
					case Waypoint.WaypointType.StrikeIngress:
						waypoint.m_Doctrine.SetUseRefuelDoctrine(aircraft_0.m_Scenario, false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_1));
						waypoint.m_Doctrine.SetRefuelSelectionDoctrine(aircraft_0.m_Scenario, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_1));
						break;
					case Waypoint.WaypointType.Formate:
					case Waypoint.WaypointType.LandingMarshal:
					case Waypoint.WaypointType.Refuel:
					case Waypoint.WaypointType.Marshal:
						goto IL_168;
					case Waypoint.WaypointType.StrikeEgress:
						if (i + 1 <= num && waypoint_0[i + 1].waypointType != Waypoint.WaypointType.StrikeEgress)
						{
							waypoint.m_Doctrine.SetUseRefuelDoctrine(aircraft_0.m_Scenario, false, false, false, false, useRefuelDoctrine);
							waypoint.m_Doctrine.SetRefuelSelectionDoctrine(aircraft_0.m_Scenario, false, false, false, false, refuelSelectionDoctrine);
						}
						else
						{
							waypoint.m_Doctrine.SetUseRefuelDoctrine(aircraft_0.m_Scenario, false, false, false, false, new Doctrine._UseRefuel?(Doctrine._UseRefuel.const_1));
							waypoint.m_Doctrine.SetRefuelSelectionDoctrine(aircraft_0.m_Scenario, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_1));
						}
						break;
					case Waypoint.WaypointType.TakeOff:
					case Waypoint.WaypointType.Land:
						waypoint.m_Doctrine.SetUseRefuelDoctrine(aircraft_0.m_Scenario, false, false, false, false, useRefuelDoctrine);
						waypoint.m_Doctrine.SetRefuelSelectionDoctrine(aircraft_0.m_Scenario, false, false, false, false, refuelSelectionDoctrine);
						break;
					default:
						goto IL_168;
					}
					IL_29A:
					i++;
					continue;
					IL_168:
					if (Information.IsNothing(aircraft_0.GetAssignedMission(false)) || aircraft_0.GetAssignedMission(false).MissionClass != Mission._MissionClass.Strike)
					{
						waypoint.m_Doctrine.SetUseRefuelDoctrine(aircraft_0.m_Scenario, false, false, false, false, useRefuelDoctrine);
						waypoint.m_Doctrine.SetRefuelSelectionDoctrine(aircraft_0.m_Scenario, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_0));
						goto IL_29A;
					}
					if (flag)
					{
						waypoint.m_Doctrine.SetUseRefuelDoctrine(aircraft_0.m_Scenario, false, false, false, false, useRefuelDoctrine);
						waypoint.m_Doctrine.SetRefuelSelectionDoctrine(aircraft_0.m_Scenario, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_1));
						goto IL_29A;
					}
					waypoint.m_Doctrine.SetUseRefuelDoctrine(aircraft_0.m_Scenario, false, false, false, false, useRefuelDoctrine);
					waypoint.m_Doctrine.SetRefuelSelectionDoctrine(aircraft_0.m_Scenario, false, false, false, false, refuelSelectionDoctrine);
					goto IL_29A;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200609", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B77 RID: 27511 RVA: 0x003B1608 File Offset: 0x003AF808
		public static bool smethod_8(Scenario theScenario_, Mission theStrikeMission_, ActiveUnit theFlightReferenceUnit_, Mission.Flight theFlight_, ref Waypoint[] theFlightCourse_, Mission.Enum60 bingo_, ref float float_0, float float_1, bool bool_0, bool bool_1, bool bool_2, bool bool_3, bool bool_4, bool bool_5, bool bool_6, DateTime? nullable_1, float float_2, float float_3, float float_4, Misc.Enum102 enum102_0, bool? bUseAutoPlanner, bool bool_7)
		{
			bool flag = false;
			bool result;
			try
			{
				List<string> list_ = new List<string>();
				float float_5 = 0f;
				if (bool_5)
				{
					if (float_1 <= 0f)
					{
						FuelRec[] fuelRecs = theFlightReferenceUnit_.GetFuelRecs();
						float num = 0f;
						for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
						{
							FuelRec fuelRec = fuelRecs[i];
							num += (float)fuelRec.MaxQuantity;
						}
						float_1 = num - theFlightReferenceUnit_.GetKinematics().GetReserveFuel();
					}
					if (Information.IsNothing(bUseAutoPlanner))
					{
						if (!Information.IsNothing(theStrikeMission_) && theStrikeMission_.MissionClass == Mission._MissionClass.Strike && ((Strike)theStrikeMission_).UseAutoPlanner)
						{
							bUseAutoPlanner = new bool?(true);
						}
						else
						{
							bUseAutoPlanner = new bool?(false);
						}
					}
					try
					{
						StrikePlanner.smethod_10(ref theFlightCourse_, ref theFlightReferenceUnit_, false);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200610", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
					StrikePlanner.smethod_15(theFlightCourse_, ref theFlightReferenceUnit_, ref theFlight_, ref list_, ref float_5, false);
					if (bool_2)
					{
						StrikePlanner.smethod_16(ref theFlightCourse_, false);
					}
					StrikePlanner.smethod_14(ref theFlightCourse_, false);
					bool flag2 = true;
					StrikePlanner.smethod_13(ref theFlightCourse_, ref theFlightReferenceUnit_, ref float_0, ref float_1, ref flag2, false);
					if (bool_0 && float_0 > float_1)
					{
						flag = false;
						result = false;
						return result;
					}
					if (bool_3)
					{
						StrikePlanner.smethod_11(ref theScenario_, ref theStrikeMission_, ref theFlight_, ref theFlightCourse_, ref theFlightReferenceUnit_, nullable_1, false, bool_4);
					}
					StrikePlanner.smethod_12(ref theFlightCourse_, ref theFlightReferenceUnit_, false);
				}
				if (bool_6)
				{
					StrikePlanner.smethod_18(theScenario_, theFlightReferenceUnit_, theFlightReferenceUnit_.GetAssignedMission(false), theFlight_, ref theFlightCourse_, bool_4, float_5, float_1, list_, float_2, float_3, float_4, enum102_0, bUseAutoPlanner.Value, bool_7);
				}
				StrikePlanner.smethod_9(ref theFlightCourse_);
				if (bool_1)
				{
					StrikePlanner.smethod_43(ref theFlightReferenceUnit_.m_Scenario, ref theFlight_, ref list_);
				}
				flag = true;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 101304", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06006B78 RID: 27512 RVA: 0x003B185C File Offset: 0x003AFA5C
		private static void smethod_9(ref Waypoint[] theFlightCourse_)
		{
			int num = 1;
			int num2 = theFlightCourse_.Count<Waypoint>() - 1;
			for (int i = 0; i <= num2; i++)
			{
				Waypoint waypoint = theFlightCourse_[i];
				if (waypoint.waypointType == Waypoint.WaypointType.WeaponTarget)
				{
					waypoint.Description = "-";
					if (!Information.IsNothing(waypoint.WP_LeadElementWingman))
					{
						waypoint.WP_LeadElementWingman.Description = "-";
					}
					if (!Information.IsNothing(waypoint.WP_SecondElement))
					{
						waypoint.WP_SecondElement.Description = "-";
					}
					if (!Information.IsNothing(waypoint.WP_SecondElementWingman))
					{
						waypoint.WP_SecondElementWingman.Description = "-";
					}
					if (!Information.IsNothing(waypoint.WP_ThirdElement))
					{
						waypoint.WP_ThirdElement.Description = "-";
					}
					if (!Information.IsNothing(waypoint.WP_ThirdElementWingman))
					{
						waypoint.WP_ThirdElementWingman.Description = "-";
					}
				}
				else
				{
					waypoint.Description = Conversions.ToString(num);
					if (!Information.IsNothing(waypoint.WP_LeadElementWingman))
					{
						waypoint.WP_LeadElementWingman.Description = Conversions.ToString(num);
					}
					if (!Information.IsNothing(waypoint.WP_SecondElement))
					{
						waypoint.WP_SecondElement.Description = Conversions.ToString(num);
					}
					if (!Information.IsNothing(waypoint.WP_SecondElementWingman))
					{
						waypoint.WP_SecondElementWingman.Description = Conversions.ToString(num);
					}
					if (!Information.IsNothing(waypoint.WP_ThirdElement))
					{
						waypoint.WP_ThirdElement.Description = Conversions.ToString(num);
					}
					if (!Information.IsNothing(waypoint.WP_ThirdElementWingman))
					{
						waypoint.WP_ThirdElementWingman.Description = Conversions.ToString(num);
					}
					num++;
				}
			}
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x003B19F0 File Offset: 0x003AFBF0
		public static void smethod_10(ref Waypoint[] waypoint_0, ref ActiveUnit activeUnit_0, bool bool_0)
		{
			try
			{
				int num = waypoint_0.Count<Waypoint>();
				int num2 = num - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (!bool_0 || (i != 0 && i != num - 1))
					{
						Waypoint waypoint = waypoint_0[i];
						if (!Information.IsNothing(waypoint))
						{
							if (waypoint.SpeedFixed == Waypoint.Enum52.const_2 || waypoint.SpeedFixed == Waypoint.Enum52.const_3)
							{
								waypoint.SpeedFixed = Waypoint.Enum52.const_0;
							}
							if (waypoint.TimeFixed == Waypoint.Enum52.const_2 || waypoint.TimeFixed == Waypoint.Enum52.const_3)
							{
								waypoint.TimeFixed = Waypoint.Enum52.const_0;
							}
							if (waypoint.SpeedFixed == Waypoint.Enum52.const_0)
							{
								if (waypoint.waypointType != Waypoint.WaypointType.TakeOff && waypoint.waypointType != Waypoint.WaypointType.Land)
								{
									if (!bool_0)
									{
										waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
										waypoint.DesiredSpeed = null;
										waypoint.SetDSO(null);
									}
								}
								else
								{
									waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Loiter);
									waypoint.DesiredSpeed = null;
									waypoint.SetDSO(null);
								}
							}
							if (Information.IsNothing(waypoint.GetThrottlePreset()) || waypoint.GetThrottlePreset() == ActiveUnit_Kinematics._SpeedPreset.FullStop)
							{
								waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
							}
							if (Information.IsNothing(waypoint.DesiredSpeed) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
							{
								if (!Information.IsNothing(waypoint.DesiredAltitude))
								{
									waypoint.DesiredSpeed = new float?((float)activeUnit_0.GetKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
								}
								else if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing) && waypoint.IsTerrainFollowing())
								{
									waypoint.DesiredSpeed = new float?((float)activeUnit_0.GetKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
								}
								else
								{
									waypoint.DesiredSpeed = new float?((float)activeUnit_0.GetKinematics().GetSpeed(0f, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
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
				ex2.Data.Add("Error at 200611", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x003B1C54 File Offset: 0x003AFE54
		public static void smethod_11(ref Scenario scenario_, ref Mission mission_, ref Mission.Flight Flight_, ref Waypoint[] waypoint_0, ref ActiveUnit activeUnit_0, DateTime? nullable_1, bool bool_0, bool bool_1)
		{
			int num = -1;
			int num2 = waypoint_0.Count<Waypoint>();
			try
			{
				if (!bool_0 && bool_1 && mission_.category == Mission.MissionCategory.Package)
				{
					Mission.Flight.SetFlightPlanWaypointTimes(ref scenario_, ref mission_, Flight_, waypoint_0, scenario_.GetCurrentTime(false), ref activeUnit_0);
				}
				int num3 = num2 - 1;
				for (int i = 0; i <= num3; i++)
				{
					Waypoint waypoint = waypoint_0[i];
					if (!Information.IsNothing(waypoint) && (!bool_0 || (waypoint.FlightFormation == Waypoint._FlightFormation.Split && i != waypoint_0.Count<Waypoint>() - 1)) && !Information.IsNothing(waypoint.ArrivalTime_Zulu))
					{
						if (waypoint.waypointType == Waypoint.WaypointType.Target)
						{
							goto IL_A0;
						}
						if (waypoint.waypointType == Waypoint.WaypointType.WeaponTarget)
						{
							goto IL_A0;
						}
						bool arg_AF_0 = false;
						IL_AF:
						if (!arg_AF_0)
						{
							if (waypoint.TimeFixed != Waypoint.Enum52.const_1)
							{
								goto IL_DE;
							}
							num = i;
							waypoint.SetDSO(waypoint.DesiredSpeed);
							if (!Information.IsNothing(nullable_1))
							{
								goto IL_DE;
							}
						}
						else
						{
							waypoint.ArrivalTime_Zulu = nullable_1;
							waypoint.TimeFixed = Waypoint.Enum52.const_1;
							num = i;
							waypoint.SetDSO(waypoint.DesiredSpeed);
							if (waypoint.FlightFormation != Waypoint._FlightFormation.Split)
							{
								if (!Information.IsNothing(waypoint.WP_LeadElementWingman))
								{
									waypoint.WP_LeadElementWingman.ArrivalTime_Zulu = nullable_1;
									waypoint.WP_LeadElementWingman.TimeFixed = Waypoint.Enum52.const_1;
								}
								if (!Information.IsNothing(waypoint.WP_SecondElement))
								{
									waypoint.WP_SecondElement.ArrivalTime_Zulu = nullable_1;
									waypoint.WP_SecondElement.TimeFixed = Waypoint.Enum52.const_1;
								}
								if (!Information.IsNothing(waypoint.WP_SecondElementWingman))
								{
									waypoint.WP_SecondElementWingman.ArrivalTime_Zulu = nullable_1;
									waypoint.WP_SecondElementWingman.TimeFixed = Waypoint.Enum52.const_1;
								}
								if (!Information.IsNothing(waypoint.WP_ThirdElement))
								{
									waypoint.WP_ThirdElement.ArrivalTime_Zulu = nullable_1;
									waypoint.WP_ThirdElement.TimeFixed = Waypoint.Enum52.const_1;
								}
								if (!Information.IsNothing(waypoint.WP_ThirdElementWingman))
								{
									waypoint.WP_ThirdElementWingman.ArrivalTime_Zulu = nullable_1;
									waypoint.WP_ThirdElementWingman.TimeFixed = Waypoint.Enum52.const_1;
								}
							}
						}
						break;
						IL_A0:
						arg_AF_0 = !Information.IsNothing(nullable_1);
						goto IL_AF;
					}
					IL_DE:;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200612", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			try
			{
				if (num >= 0)
				{
					int j = num - 1;
					while (j >= 0)
					{
						Waypoint waypoint = waypoint_0[j];
						if (!bool_0)
						{
							goto IL_262;
						}
						if (waypoint.FlightFormation == Waypoint._FlightFormation.Split)
						{
							goto IL_262;
						}
						bool arg_282_0 = true;
						IL_282:
						if (!arg_282_0)
						{
							DateTime value = waypoint_0[j + 1].ArrivalTime_Zulu.Value.AddSeconds(-(double)(waypoint_0[j + 1].Leg_Time + waypoint_0[j + 1].Hold_Time));
							waypoint.ArrivalTime_Zulu = new DateTime?(value);
							if (waypoint.FlightFormation != Waypoint._FlightFormation.Split)
							{
								if (!Information.IsNothing(waypoint.WP_LeadElementWingman))
								{
									waypoint.WP_LeadElementWingman.ArrivalTime_Zulu = new DateTime?(value);
								}
								if (!Information.IsNothing(waypoint.WP_SecondElement))
								{
									waypoint.WP_SecondElement.ArrivalTime_Zulu = new DateTime?(value);
								}
								if (!Information.IsNothing(waypoint.WP_SecondElementWingman))
								{
									waypoint.WP_SecondElementWingman.ArrivalTime_Zulu = new DateTime?(value);
								}
								if (!Information.IsNothing(waypoint.WP_ThirdElement))
								{
									waypoint.WP_ThirdElement.ArrivalTime_Zulu = new DateTime?(value);
								}
								if (!Information.IsNothing(waypoint.WP_ThirdElementWingman))
								{
									waypoint.WP_ThirdElementWingman.ArrivalTime_Zulu = new DateTime?(value);
								}
							}
						}
						j += -1;
						continue;
						IL_262:
						if (j < num)
						{
							if (waypoint.TimeFixed != Waypoint.Enum52.const_1)
							{
								arg_282_0 = false;
								goto IL_282;
							}
						}
						arg_282_0 = Information.IsNothing(nullable_1);
						goto IL_282;
					}
					if (num <= num2 - 1)
					{
						int num4 = num + 1;
						int num5 = num2 - 1;
						int k = num4;
						while (k <= num5)
						{
							Waypoint waypoint = waypoint_0[k];
							if (!bool_0)
							{
								goto IL_3D5;
							}
							if (waypoint.FlightFormation == Waypoint._FlightFormation.Split && k != num - 1)
							{
								goto IL_3D5;
							}
							bool arg_3F5_0 = true;
							IL_3F5:
							if (!arg_3F5_0)
							{
								DateTime value2 = waypoint_0[k - 1].ArrivalTime_Zulu.Value.AddSeconds((double)(waypoint.Leg_Time + waypoint.Hold_Time));
								waypoint.ArrivalTime_Zulu = new DateTime?(value2);
								if (waypoint.FlightFormation != Waypoint._FlightFormation.Split)
								{
									if (!Information.IsNothing(waypoint.WP_LeadElementWingman))
									{
										waypoint.WP_LeadElementWingman.ArrivalTime_Zulu = new DateTime?(value2);
									}
									if (!Information.IsNothing(waypoint.WP_SecondElement))
									{
										waypoint.WP_SecondElement.ArrivalTime_Zulu = new DateTime?(value2);
									}
									if (!Information.IsNothing(waypoint.WP_SecondElementWingman))
									{
										waypoint.WP_SecondElementWingman.ArrivalTime_Zulu = new DateTime?(value2);
									}
									if (!Information.IsNothing(waypoint.WP_ThirdElement))
									{
										waypoint.WP_ThirdElement.ArrivalTime_Zulu = new DateTime?(value2);
									}
									if (!Information.IsNothing(waypoint.WP_ThirdElementWingman))
									{
										waypoint.WP_ThirdElementWingman.ArrivalTime_Zulu = new DateTime?(value2);
									}
								}
							}
							k++;
							continue;
							IL_3D5:
							if (k > num)
							{
								if (waypoint.TimeFixed != Waypoint.Enum52.const_1)
								{
									arg_3F5_0 = false;
									goto IL_3F5;
								}
							}
							arg_3F5_0 = Information.IsNothing(nullable_1);
							goto IL_3F5;
						}
					}
				}
				else if (bool_0)
				{
					int num6 = num2 - 1;
					for (int l = 0; l <= num6; l++)
					{
						Waypoint waypoint = waypoint_0[l];
						if (!Information.IsNothing(waypoint) && waypoint.FlightFormation == Waypoint._FlightFormation.Split && l > 0)
						{
							Information.IsNothing(waypoint_0[l - 1].ArrivalTime_Zulu);
							if (waypoint.TimeFixed != Waypoint.Enum52.const_1)
							{
								DateTime value3 = waypoint_0[l - 1].ArrivalTime_Zulu.Value.AddSeconds((double)(waypoint.Leg_Time + waypoint.Hold_Time));
								waypoint.ArrivalTime_Zulu = new DateTime?(value3);
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 200613", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x003B228C File Offset: 0x003B048C
		public static void smethod_12(ref Waypoint[] waypoint_0, ref ActiveUnit activeUnit_0, bool bool_0)
		{
			int num = waypoint_0.Count<Waypoint>() - 1;
			for (int i = 0; i <= num; i++)
			{
				Waypoint waypoint = waypoint_0[i];
				if (!Information.IsNothing(waypoint.ArrivalTime_Zulu))
				{
					bool bool_ = activeUnit_0.m_Scenario.IsUseDaylightSavingTime();
					string daylightSavingTime_Start = activeUnit_0.m_Scenario.GetDaylightSavingTime_Start();
					string daylightSavingTime_End = activeUnit_0.m_Scenario.GetDaylightSavingTime_End();
					waypoint.ArrivalTime_Local = new DateTime?(Misc.GetLocalTime(waypoint.ArrivalTime_Zulu.Value, waypoint.GetLongitude(), bool_, daylightSavingTime_Start, daylightSavingTime_End));
				}
				else
				{
					waypoint.ArrivalTime_Local = null;
				}
			}
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x003B232C File Offset: 0x003B052C
		public static void smethod_13(ref Waypoint[] waypoint_0, ref ActiveUnit activeUnit_0, ref float float_0, ref float float_1, ref bool bool_0, bool bool_1)
		{
			try
			{
				int num = waypoint_0.Count<Waypoint>();
				float num2 = 0f;
				Aircraft aircraft = (Aircraft)activeUnit_0;
				float_0 = 0f;
				ActiveUnit.Throttle throttle = ActiveUnit.Throttle.FullStop;
				float num3 = 0f;
				ActiveUnit.Throttle throttle_ = ActiveUnit.Throttle.FullStop;
				float num4 = 0f;
				int num5 = num - 1;
				for (int i = 0; i <= num5; i++)
				{
					Waypoint waypoint = waypoint_0[i];
					if (!Information.IsNothing(waypoint))
					{
						if (bool_1 && i != waypoint_0.Count<Waypoint>() - 1 && waypoint_0[i].FlightFormation != Waypoint._FlightFormation.Split)
						{
							if (i > 0 && waypoint.waypointType != Waypoint.WaypointType.TakeOff)
							{
								throttle_ = throttle;
								num4 = num3;
							}
							if (waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
							{
								throttle = (ActiveUnit.Throttle)waypoint.GetThrottlePreset();
							}
							else if (!Information.IsNothing(waypoint.DesiredSpeed))
							{
								throttle = activeUnit_0.GetKinematics().vmethod_38(num3, waypoint.DesiredSpeed.Value);
							}
							else
							{
								throttle = ActiveUnit.Throttle.Cruise;
							}
							if (!Information.IsNothing(waypoint.DesiredAltitude))
							{
								num3 = waypoint.DesiredAltitude.Value;
							}
							else if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing) && waypoint.IsTerrainFollowing())
							{
								num3 = waypoint.DesiredAltitude_TerrainFollowing.Value;
							}
							if (num3 == 0f)
							{
								ActiveUnit_AI aI = activeUnit_0.GetAI();
								bool flag = false;
								num3 = aI.method_78(ref aircraft, ActiveUnit.Throttle.Cruise, ref flag);
							}
							num2 = waypoint.Leg_TotalTime;
							float_0 = float_1 - waypoint.Leg_FuelRemaining;
						}
						else
						{
							Doctrine._UseRefuel? useRefuel = null;
							if (i > 0)
							{
								if (Information.IsNothing(waypoint_0[i]) || waypoint_0[i].waypointType == Waypoint.WaypointType.WeaponTarget)
								{
									goto IL_5B1;
								}
								float num6;
								if (!Information.IsNothing(waypoint.float_11) && waypoint.float_11 > 0f && waypoint.Leg_Distance > 0f)
								{
									num6 = activeUnit_0.GetKinematics().method_6(waypoint.Leg_Distance, throttle, num3, new float?(waypoint.float_11), !bool_0, true);
								}
								else
								{
									num6 = 0f;
								}
								if (!Information.IsNothing(waypoint.float_12) && waypoint.float_12 > 0f && waypoint.float_10 > 0f)
								{
									num6 += activeUnit_0.GetKinematics().method_6(waypoint.float_10, throttle_, num4, new float?(waypoint.float_12), !bool_0, true);
								}
								if (waypoint.Hold_Time > 0f)
								{
									float num7 = (float)activeUnit_0.GetKinematics().GetSpeed(num4, ActiveUnit.Throttle.Loiter);
									float float_2 = num7 * (waypoint.Hold_Time / 3600f);
									num6 += activeUnit_0.GetKinematics().method_6(float_2, ActiveUnit.Throttle.Loiter, num4, new float?(num7), !bool_0, true);
								}
								waypoint.Leg_FuelRequired = num6;
								float_0 += num6;
								byte? b = useRefuel.HasValue ? new byte?((byte)useRefuel.GetValueOrDefault()) : null;
								bool? flag2 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
								if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
								{
									float_0 = 0f;
								}
								waypoint.Leg_FuelRemaining = float_1 - float_0;
								if (!Information.IsNothing(waypoint.float_11) && waypoint.float_11 > 0f && waypoint.Leg_Distance > 0f)
								{
									waypoint.Leg_Time_Straight = waypoint.Leg_Distance / waypoint.float_11 * 3600f;
								}
								else
								{
									waypoint.Leg_Time_Straight = 0f;
								}
								if (!Information.IsNothing(waypoint.float_12) && waypoint.float_12 > 0f && waypoint.float_10 > 0f)
								{
									waypoint.Leg_Time_Turn = waypoint.float_10 / waypoint.float_12 * 3600f;
								}
								else
								{
									waypoint.Leg_Time_Turn = 0f;
								}
								waypoint.Leg_Time = waypoint.Leg_Time_Straight + waypoint.Leg_Time_Turn;
								num2 += waypoint.Leg_Time + waypoint.Hold_Time;
								waypoint.Leg_TotalTime = num2;
							}
							else if (waypoint.waypointType == Waypoint.WaypointType.TakeOff)
							{
								waypoint.Leg_FuelRemaining = float_1;
							}
							if (waypoint.waypointType == Waypoint.WaypointType.Target || waypoint.waypointType == Waypoint.WaypointType.WeaponTarget)
							{
								bool_0 = false;
							}
							if (i > 0 && waypoint.waypointType != Waypoint.WaypointType.TakeOff)
							{
								throttle_ = throttle;
								num4 = num3;
							}
							if (waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
							{
								throttle = (ActiveUnit.Throttle)waypoint.GetThrottlePreset();
							}
							else if (!Information.IsNothing(waypoint.DesiredSpeed))
							{
								throttle = activeUnit_0.GetKinematics().vmethod_38(num3, waypoint.DesiredSpeed.Value);
							}
							else
							{
								throttle = ActiveUnit.Throttle.Cruise;
							}
							useRefuel = waypoint.m_Doctrine.GetUseRefuelDoctrine(activeUnit_0.m_Scenario, false, false, false, false);
							if (!Information.IsNothing(waypoint.DesiredAltitude))
							{
								num3 = waypoint.DesiredAltitude.Value;
							}
							else if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing) && waypoint.IsTerrainFollowing())
							{
								num3 = waypoint.DesiredAltitude_TerrainFollowing.Value;
							}
							if (num3 == 0f)
							{
								ActiveUnit_AI aI2 = activeUnit_0.GetAI();
								bool flag = false;
								num3 = aI2.method_78(ref aircraft, ActiveUnit.Throttle.Cruise, ref flag);
							}
							if (waypoint.waypointType == Waypoint.WaypointType.TakeOff)
							{
								throttle_ = throttle;
								num4 = num3;
							}
						}
					}
					IL_5B1:;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200614", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B7D RID: 27517 RVA: 0x003B295C File Offset: 0x003B0B5C
		public static void smethod_14(ref Waypoint[] waypoint_0, bool bool_0)
		{
			int num = waypoint_0.Count<Waypoint>();
			try
			{
				int num2 = num - 1;
				for (int i = 0; i <= num2; i++)
				{
					Waypoint waypoint = waypoint_0[i];
					if (!Information.IsNothing(waypoint) && i + 1 <= num - 1)
					{
						Waypoint waypoint2 = waypoint_0[i + 1];
						if (!Information.IsNothing(waypoint2))
						{
							if (waypoint2.TimeFixed != Waypoint.Enum52.const_1)
							{
								if (waypoint.TimeFixed == Waypoint.Enum52.const_1)
								{
									goto IL_BB;
								}
								if (waypoint.TimeFixed == Waypoint.Enum52.const_2)
								{
									goto IL_BB;
								}
								bool arg_C7_0 = true;
								IL_C7:
								if (!arg_C7_0)
								{
									waypoint2.TimeFixed = Waypoint.Enum52.const_2;
									waypoint.SetDSO(waypoint.DesiredSpeed);
									goto IL_DD;
								}
								goto IL_DD;
								IL_BB:
								arg_C7_0 = (waypoint.SpeedFixed != Waypoint.Enum52.const_1);
								goto IL_C7;
							}
							waypoint.SetDSO(waypoint.DesiredSpeed);
							if (waypoint.TimeFixed == Waypoint.Enum52.const_1 && waypoint.SpeedFixed == Waypoint.Enum52.const_0)
							{
								waypoint.SpeedFixed = Waypoint.Enum52.const_2;
							}
							else if (waypoint.TimeFixed == Waypoint.Enum52.const_0 && waypoint.SpeedFixed == Waypoint.Enum52.const_1)
							{
								waypoint.TimeFixed = Waypoint.Enum52.const_2;
							}
						}
					}
					IL_DD:;
				}
				for (int j = num - 1; j >= 0; j += -1)
				{
					Waypoint waypoint = waypoint_0[j];
					if (!Information.IsNothing(waypoint) && j - 1 >= 0 && (waypoint.TimeFixed == Waypoint.Enum52.const_1 || waypoint.TimeFixed == Waypoint.Enum52.const_2))
					{
						Waypoint waypoint2 = waypoint_0[j - 1];
						if (!Information.IsNothing(waypoint2))
						{
							waypoint.SetDSO(waypoint.DesiredSpeed);
							if (waypoint2.TimeFixed == Waypoint.Enum52.const_1)
							{
								goto IL_163;
							}
							if (waypoint2.TimeFixed == Waypoint.Enum52.const_2)
							{
								goto IL_163;
							}
							bool arg_170_0 = true;
							IL_170:
							if (!arg_170_0)
							{
								waypoint2.SpeedFixed = Waypoint.Enum52.const_2;
								goto IL_1AC;
							}
							if (waypoint2.TimeFixed == Waypoint.Enum52.const_0 && (waypoint2.SpeedFixed == Waypoint.Enum52.const_1 || waypoint2.TimeFixed == Waypoint.Enum52.const_2))
							{
								waypoint2.TimeFixed = Waypoint.Enum52.const_2;
								goto IL_1AC;
							}
							goto IL_1AC;
							IL_163:
							arg_170_0 = (waypoint2.SpeedFixed != Waypoint.Enum52.const_0);
							goto IL_170;
						}
					}
					IL_1AC:;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200615", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B7E RID: 27518 RVA: 0x003B2B88 File Offset: 0x003B0D88
		public static void smethod_15(Waypoint[] waypoint_0, ref ActiveUnit activeUnit_0, ref Mission.Flight class168_0, ref List<string> list_0, ref float float_0, bool bool_0)
		{
			float num = 0f;
			float num2 = 0f;
			float float_ = 0f;
			if (!Information.IsNothing(waypoint_0) && waypoint_0.Count<Waypoint>() != 0)
			{
				float num3 = waypoint_0[0].Leg_TotalDistance;
				try
				{
					int num4 = waypoint_0.Count<Waypoint>() - 1;
					for (int i = 0; i <= num4; i++)
					{
						if (!Information.IsNothing(waypoint_0[i]))
						{
							if (bool_0 && i != waypoint_0.Count<Waypoint>() - 1 && waypoint_0[i].FlightFormation != Waypoint._FlightFormation.Split)
							{
								num2 = num;
								if (!Information.IsNothing(waypoint_0[i].DesiredSpeed))
								{
									num = waypoint_0[i].DesiredSpeed.Value;
								}
								num3 = waypoint_0[i].Leg_TotalDistance;
								if (i < waypoint_0.Count<Waypoint>() - 1 && !Information.IsNothing(waypoint_0[i + 1]) && waypoint_0[i + 1].FlightFormation == Waypoint._FlightFormation.Split && !Information.IsNothing(waypoint_0[i].FlightplanPointsList) && waypoint_0[i].FlightplanPointsList.Count > 0)
								{
									Waypoint.Class126 @class = waypoint_0[i].FlightplanPointsList[waypoint_0[i].FlightplanPointsList.Count - 1];
									float_ = Math2.GetAzimuth(@class.StartLatitude, @class.StartLongitude, @class.EndLatitude, @class.EndLongitude);
								}
							}
							else
							{
								List<Waypoint.Class126> list = new List<Waypoint.Class126>();
								if (i > 0 || waypoint_0[i].waypointType == Waypoint.WaypointType.TakeOff)
								{
									waypoint_0[i].Leg_Distance = 0f;
									waypoint_0[i].float_10 = 0f;
									waypoint_0[i].float_11 = 0f;
									waypoint_0[i].float_12 = 0f;
								}
								if (!bool_0 || i > 0)
								{
									waypoint_0[i].bool_11 = (waypoint_0[Math.Max(i - 1, 0)].SpeedFixed == Waypoint.Enum52.const_1);
									waypoint_0[i].bool_12 = (waypoint_0[Math.Max(i - 2, 0)].SpeedFixed == Waypoint.Enum52.const_1);
								}
								if (i == 0)
								{
									if (!Information.IsNothing(waypoint_0[i].DesiredSpeed))
									{
										num = waypoint_0[i].DesiredSpeed.Value;
										num2 = num;
									}
									if (!Information.IsNothing(waypoint_0[i].FlightplanPointsList) && waypoint_0[i].FlightplanPointsList.Count > 0)
									{
										Waypoint.Class126 class2 = waypoint_0[i].FlightplanPointsList[waypoint_0[i].FlightplanPointsList.Count - 1];
										float_ = Math2.GetAzimuth(class2.StartLatitude, class2.StartLongitude, class2.EndLatitude, class2.EndLongitude);
									}
								}
								if (i != 0)
								{
									if (i > 0 && waypoint_0[i].waypointType == Waypoint.WaypointType.WeaponTarget && waypoint_0[i - 1].waypointType == Waypoint.WaypointType.WeaponTarget)
									{
										waypoint_0[i].Leg_Distance = 0f;
										waypoint_0[i].float_10 = 0f;
										waypoint_0[i].float_11 = 0f;
										waypoint_0[i].float_12 = 0f;
										Waypoint waypoint = null;
										if (!Information.IsNothing(waypoint))
										{
											Waypoint waypoint2;
											double latitude = (waypoint2 = waypoint).GetLatitude();
											Waypoint.Class126 class3 = new Waypoint.Class126(ref latitude, waypoint.GetLongitude(), waypoint_0[i].GetLatitude(), waypoint_0[i].GetLongitude());
											waypoint2.SetLatitude(latitude);
											Waypoint.Class126 item = class3;
											list.Add(item);
										}
									}
									else if (num > 0f && num2 > 0f)
									{
										Waypoint waypoint3 = waypoint_0[i];
										Waypoint waypoint = waypoint_0[i - 1];
										float azimuth = Math2.GetAzimuth(waypoint.GetLatitude(), waypoint.GetLongitude(), waypoint3.GetLatitude(), waypoint3.GetLongitude());
										Misc.Enum102 @enum = Misc.smethod_63(float_, azimuth);
										if (@enum != Misc.Enum102.const_0)
										{
											if (@enum == Misc.Enum102.const_1)
											{
												float_0 = 9f;
											}
										}
										else
										{
											float_0 = -9f;
										}
										float float_2 = num2;
										float float_3 = float_0;
										Misc.Enum102 enum102_ = @enum;
										float float_4 = azimuth;
										bool flag = false;
										StrikePlanner.smethod_17(ref float_, ref list, ref waypoint3, ref waypoint, ref num, float_2, ref activeUnit_0, ref class168_0, ref list_0, float_3, enum102_, float_4, ref flag);
									}
									else
									{
										Waypoint waypoint3 = waypoint_0[i];
										if (waypoint3.waypointType == Waypoint.WaypointType.WeaponTarget)
										{
											float azimuth2 = Math2.GetAzimuth(waypoint_0[i - 1].GetLatitude(), waypoint_0[i - 1].GetLongitude(), waypoint3.GetLatitude(), waypoint3.GetLongitude());
											double double_ = 0.0;
											double double_2 = 0.0;
											GeoPointGenerator.GetOtherGeoPoint(waypoint_0[i - 1].GetLongitude(), waypoint_0[i - 1].GetLatitude(), ref double_, ref double_2, 5.0, (double)azimuth2);
											Waypoint waypoint2;
											double latitude = (waypoint2 = waypoint_0[i - 1]).GetLatitude();
											Waypoint.Class126 class4 = new Waypoint.Class126(ref latitude, waypoint_0[i - 1].GetLongitude(), double_2, double_);
											waypoint2.SetLatitude(latitude);
											Waypoint.Class126 item = class4;
											list.Add(item);
											waypoint3.Leg_Distance += 5f;
										}
										else
										{
											Waypoint waypoint2;
											double latitude = (waypoint2 = waypoint_0[i - 1]).GetLatitude();
											Waypoint.Class126 class5 = new Waypoint.Class126(ref latitude, waypoint_0[i - 1].GetLongitude(), waypoint3.GetLatitude(), waypoint3.GetLongitude());
											waypoint2.SetLatitude(latitude);
											Waypoint.Class126 item = class5;
											list.Add(item);
											waypoint3.Leg_Distance += Math2.GetDistance(waypoint_0[i - 1].GetLatitude(), waypoint_0[i - 1].GetLongitude(), waypoint3.GetLatitude(), waypoint3.GetLongitude());
											waypoint3.float_11 = num;
										}
									}
								}
								num2 = num;
								if (!Information.IsNothing(waypoint_0[i].DesiredSpeed))
								{
									num = waypoint_0[i].DesiredSpeed.Value;
								}
								num3 += waypoint_0[i].Leg_Distance + waypoint_0[i].float_10;
								if (i > 0)
								{
									waypoint_0[i].Leg_TotalDistance = num3;
									waypoint_0[i].float_1 = num;
								}
								if (i > 0)
								{
									waypoint_0[i].FlightplanPointsList = list;
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200616", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006B7F RID: 27519 RVA: 0x003B31D4 File Offset: 0x003B13D4
		public static bool smethod_16(ref Waypoint[] waypoint_0, bool bool_0)
		{
			bool result = false;
			try
			{
				List<Waypoint> list = new List<Waypoint>();
				int num = waypoint_0.Count<Waypoint>();
				Waypoint waypoint = null;
				int num2 = 0;
				bool flag = false;
				bool flag2 = false;
				int num3 = num - 1;
				for (int i = 0; i <= num3; i++)
				{
					Waypoint waypoint2 = waypoint_0[i];
					if (!Information.IsNothing(waypoint2))
					{
						list.Clear();
						float num4 = 0f;
						float num5 = 0f;
						float num6 = 0f;
						float num7 = 0f;
						if (i <= 0 || waypoint_0[i].waypointType != Waypoint.WaypointType.WeaponTarget)
						{
							goto IL_85;
						}
						if (waypoint_0[i - 1].waypointType != Waypoint.WaypointType.WeaponTarget)
						{
							goto IL_85;
						}
						bool arg_90_0 = true;
						IL_90:
						if (!arg_90_0)
						{
							int num8 = i;
							int num9 = num - 1;
							for (int j = num8; j <= num9; j++)
							{
								Waypoint waypoint3 = waypoint_0[j];
								if (!Information.IsNothing(waypoint3))
								{
									if (bool_0 && !Information.IsNothing(waypoint3.ArrivalTime_Zulu))
									{
										if (j == 0)
										{
											goto IL_3E2;
										}
										if (j == 1)
										{
											waypoint = waypoint3;
											flag = true;
											num2 = j;
											goto IL_3E2;
										}
									}
									if (j <= 0 || waypoint_0[i].waypointType != Waypoint.WaypointType.WeaponTarget || waypoint_0[i - 1].waypointType != Waypoint.WaypointType.WeaponTarget)
									{
										if (flag)
										{
											if (waypoint3.bool_11)
											{
												if (!Information.IsNothing(waypoint3.float_11) && waypoint3.float_11 > 0f && !Information.IsNothing(waypoint3.Leg_Distance) && waypoint3.Leg_Distance > 0f)
												{
													num5 += waypoint3.Leg_Distance / waypoint3.float_11 * 3600f;
												}
												if (!Information.IsNothing(waypoint3.float_12) && waypoint3.float_12 > 0f && !Information.IsNothing(waypoint3.float_10) && waypoint3.float_10 > 0f)
												{
													if (waypoint3.bool_12)
													{
														num5 += waypoint3.float_10 / waypoint3.float_12 * 3600f;
													}
													else
													{
														num6 += waypoint3.float_10 / waypoint3.float_12 * 3600f;
														num4 += waypoint3.float_10;
													}
												}
											}
											else
											{
												if (!Information.IsNothing(waypoint3.float_11) && waypoint3.float_11 > 0f && !Information.IsNothing(waypoint3.Leg_Distance) && waypoint3.Leg_Distance > 0f)
												{
													num4 += waypoint3.Leg_Distance;
													num6 += waypoint3.Leg_Distance / waypoint3.float_11 * 3600f;
												}
												if (!Information.IsNothing(waypoint3.float_12) && waypoint3.float_12 > 0f && !Information.IsNothing(waypoint3.float_10) && waypoint3.float_10 > 0f)
												{
													if (waypoint3.bool_12)
													{
														num5 += waypoint3.float_10 / waypoint3.float_12 * 3600f;
													}
													else
													{
														num6 += waypoint3.float_10 / waypoint3.float_12 * 3600f;
														num4 += waypoint3.float_10;
													}
												}
											}
											num7 += waypoint3.Hold_Time;
										}
										if (j >= i && (flag || j != i))
										{
											if (j >= i)
											{
												if (!flag)
												{
													i = j;
													break;
												}
												if ((waypoint3.TimeFixed == Waypoint.Enum52.const_1 && !Information.IsNothing(waypoint3.ArrivalTime_Zulu)) || (bool_0 && j == num - 1))
												{
													Waypoint waypoint4 = waypoint3;
													if (num6 > 0f)
													{
														double num10 = Math.Abs((waypoint4.ArrivalTime_Zulu.Value - waypoint.ArrivalTime_Zulu.Value).TotalSeconds);
														num10 = num10 - (double)num5 - (double)num7;
														int num11 = num2 + 1;
														int num12 = j;
														int k = num11;
														while (k <= num12)
														{
															Waypoint waypoint5 = waypoint_0[k];
															if (k <= 0 || waypoint_0[i].waypointType != Waypoint.WaypointType.WeaponTarget)
															{
																goto IL_48A;
															}
															if (waypoint_0[i - 1].waypointType != Waypoint.WaypointType.WeaponTarget)
															{
																goto IL_48A;
															}
															bool arg_491_0 = true;
															IL_491:
															if (!arg_491_0)
															{
																float num13 = (float)((double)num4 / (num10 / 3600.0));
																num13 = ActiveUnit_Kinematics.smethod_1(num13);
																if (k > 0 && num13 - waypoint_0[k - 1].DesiredSpeed.Value != 0f && Math.Abs(num13 - waypoint_0[k - 1].DesiredSpeed.Value) < 20f && k > 1 && Math.Abs(num13 - waypoint_0[k - 2].DesiredSpeed.Value) > 0f)
																{
																	num13 = waypoint_0[k - 1].DesiredSpeed.Value;
																}
																if (num10 > 0.0)
																{
																	if (!waypoint5.bool_12)
																	{
																		num10 -= (double)(waypoint_0[k].float_10 / num13 * 3600f);
																		num4 -= Math.Max(waypoint_0[k].float_10, 0f);
																	}
																	num4 -= Math.Max(waypoint5.Leg_Distance, 0f);
																	num10 -= (double)(waypoint5.Leg_Distance / num13 * 3600f);
																}
																else
																{
																	num13 = 10000f;
																}
																if (num13 != waypoint_0[k - 1].DesiredSpeed.Value)
																{
																	flag2 = true;
																}
																waypoint_0[k - 1].DesiredSpeed = new float?(num13);
																waypoint_0[k - 1].SetDSO(new float?(num13));
																waypoint_0[k - 1].SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.None);
																waypoint_0[k - 1].SpeedFixed = Waypoint.Enum52.const_2;
																if (waypoint_0.Count<Waypoint>() - 1 >= k + 1)
																{
																	waypoint_0[k + 1].float_12 = num13;
																}
																if (waypoint_0.Count<Waypoint>() - 1 >= k)
																{
																	waypoint_0[k].float_11 = num13;
																}
															}
															k++;
															continue;
															IL_48A:
															arg_491_0 = waypoint5.bool_11;
															goto IL_491;
														}
														waypoint = waypoint4;
														num2 = j;
													}
													i = j;
													break;
												}
											}
										}
										else if (waypoint3.TimeFixed == Waypoint.Enum52.const_1 && !Information.IsNothing(waypoint3.ArrivalTime_Zulu))
										{
											waypoint = waypoint3;
											flag = true;
											num2 = j;
										}
									}
								}
								IL_3E2:;
							}
							goto IL_66D;
						}
						goto IL_66D;
						IL_85:
						arg_90_0 = (waypoint2.waypointType == Waypoint.WaypointType.TakeOff);
						goto IL_90;
					}
					IL_66D:;
				}
				result = flag2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200617", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006B80 RID: 27520 RVA: 0x003B38C8 File Offset: 0x003B1AC8
		private static void smethod_17(ref float float_0, ref List<Waypoint.Class126> list_0, ref Waypoint waypoint_0, ref Waypoint waypoint_1, ref float float_1, float float_2, ref ActiveUnit activeUnit_0, ref Mission.Flight class168_0, ref List<string> list_1, float float_3, Misc.Enum102 enum102_0, float float_4, ref bool bool_0)
		{
			try
			{
				float num = float_0;
				float num2;
				switch (waypoint_1.TurnRate)
				{
				case Waypoint._TurnRate.Standard:
					num2 = 3f;
					break;
				case Waypoint._TurnRate.Half:
					num2 = 1.5f;
					break;
				case Waypoint._TurnRate.Double:
					num2 = 6f;
					break;
				default:
					num2 = 3f;
					break;
				}
				float angle = 0f;
				float angle2 = 0f;
				if (enum102_0 != Misc.Enum102.const_0)
				{
					if (enum102_0 == Misc.Enum102.const_1)
					{
						angle = Math2.Normalize(float_0 + 90f);
						angle2 = Math2.Normalize(float_4 + 90f);
					}
				}
				else
				{
					angle = Math2.Normalize(float_0 - 90f);
					angle2 = Math2.Normalize(float_4 - 90f);
				}
				float num3 = Math.Abs(Class263.RelativeBearingTo(angle, angle2));
				num3 = Math2.Normalize(num3 * 2f);
				float num4 = Math.Abs(float_3) / num2;
				float num5 = float_2 / 3600f * num4;
				float num6 = (float)((double)float_2 / ((double)num2 * 3.14159265358979 * 20.0));
				if (waypoint_1.waypointType == Waypoint.WaypointType.WeaponTarget && waypoint_1.FlightplanPointsList.Count > 0)
				{
					double endLatitude = waypoint_1.FlightplanPointsList[waypoint_1.FlightplanPointsList.Count - 1].EndLatitude;
					double endLongitude = waypoint_1.FlightplanPointsList[waypoint_1.FlightplanPointsList.Count - 1].EndLongitude;
					waypoint_1 = new Waypoint(endLongitude, endLatitude, Waypoint.WaypointType.WeaponTarget, Waypoint._Creator.const_3, Waypoint._Category.const_1);
				}
				float distance = Math2.GetDistance(waypoint_1.GetLatitude(), waypoint_1.GetLongitude(), waypoint_0.GetLatitude(), waypoint_0.GetLongitude());
				float num7 = (float)((double)(2f * num6) * Math.Sin(0.5 * Class263.ToRadians((double)num3))) + num5 * 2f;
				bool_0 = false;
				if (distance < num7)
				{
					bool_0 = true;
				}
				if (bool_0 && !Information.IsNothing(list_1) && !Information.IsNothing(activeUnit_0) && !Information.IsNothing(activeUnit_0.GetAssignedMission(false)) && !Information.IsNothing(class168_0))
				{
					list_1.Add(string.Concat(new string[]
					{
						"ERROR! Mission ",
						activeUnit_0.GetAssignedMission(false).Name,
						", Flight ",
						class168_0.Callsign,
						": Waypoint ",
						waypoint_0.Description,
						" is too close to the next waypoint"
					}));
				}
				float num8 = Math.Abs(Class263.RelativeBearingTo(float_0, float_4));
				float num9 = 0f;
				if (!bool_0 && num8 > Math.Abs(float_3 * 2f))
				{
					float num10 = Math2.Normalize(num + float_3);
					double num11 = waypoint_1.GetLatitude();
					double num12 = waypoint_1.GetLongitude();
					int num13 = 0;
					int num14 = (int)Math.Round((double)(360f / Math.Abs(float_3)));
					float num15 = num10;
					float num16 = Math2.Normalize(float_4);
					float num17 = num16;
					while (true)
					{
						if (enum102_0 == Misc.Enum102.const_0)
						{
							if (num10 > num16)
							{
								if (num15 <= num17 && num15 < num10)
								{
									num10 = num15;
									num16 = num17;
								}
							}
							else if (num15 <= num17 && num15 > num10)
							{
								num10 = num15;
								num16 = num17;
							}
						}
						else if (enum102_0 == Misc.Enum102.const_1)
						{
							if (num10 > num16)
							{
								if (num15 >= num17 && num15 < num10)
								{
									num10 = num15;
									num16 = num17;
								}
							}
							else if (num15 >= num17 && num15 > num10)
							{
								num10 = num15;
								num16 = num17;
							}
						}
						num13++;
						if ((int)Math.Round((double)num15) == (int)Math.Round((double)num17))
						{
							try
							{
								double num18 = 0.0;
								double num19 = 0.0;
								GeoPointGenerator.GetOtherGeoPoint(num12, num11, ref num18, ref num19, (double)num5, (double)num15);
								Waypoint.Class126 item = new Waypoint.Class126(ref num11, num12, num19, num18);
								list_0.Add(item);
								num9 += num4;
								num11 = num19;
								num12 = num18;
								break;
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
								goto IL_49A;
							}
							goto IL_3B5;
						}
						goto IL_3B5;
						IL_41B:
						if (Math.Abs(Class263.RelativeBearingTo(num15, num17)) <= 9f)
						{
							break;
						}
						continue;
						IL_3B5:
						try
						{
							double num20 = 0.0;
							double num21 = 0.0;
							GeoPointGenerator.GetOtherGeoPoint(num12, num11, ref num20, ref num21, (double)num5, (double)num15);
							Waypoint.Class126 item = new Waypoint.Class126(ref num11, num12, num21, num20);
							list_0.Add(item);
							num9 += num4;
							num11 = num21;
							num12 = num20;
							goto IL_49A;
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
							goto IL_49A;
						}
						goto IL_41B;
						IL_49A:
						num17 = Math2.GetAzimuth(num11, num12, waypoint_0.GetLatitude(), waypoint_0.GetLongitude());
						num15 = Math2.Normalize(num15 + float_3);
						if (num13 >= num14)
						{
							goto Block_30;
						}
						goto IL_41B;
					}
					goto IL_4D9;
					Block_30:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					IL_4D9:
					if (waypoint_0.waypointType == Waypoint.WaypointType.WeaponTarget)
					{
						Waypoint waypoint;
						double latitude = (waypoint = waypoint_0).GetLatitude();
						Waypoint.Class126 @class = new Waypoint.Class126(ref latitude, waypoint_0.GetLongitude(), num11, num12);
						waypoint.SetLatitude(latitude);
						Waypoint.Class126 item = @class;
						list_0.Add(item);
						float azimuth = Math2.GetAzimuth(num11, num12, waypoint_0.GetLatitude(), waypoint_0.GetLongitude());
						double double_ = 0.0;
						double double_2 = 0.0;
						GeoPointGenerator.GetOtherGeoPoint(num12, num11, ref double_, ref double_2, 5.0, (double)azimuth);
						item = new Waypoint.Class126(ref num11, num12, double_2, double_);
						list_0.Add(item);
						waypoint_0.Leg_Distance = 5f;
					}
					else
					{
						Waypoint.Class126 item = new Waypoint.Class126(ref num11, num12, waypoint_0.GetLatitude(), waypoint_0.GetLongitude());
						list_0.Add(item);
						waypoint_0.Leg_Distance = Math2.GetDistance(num11, num12, waypoint_0.GetLatitude(), waypoint_0.GetLongitude());
						waypoint_0.float_12 = float_2;
					}
					waypoint_0.float_10 = float_2 * num9 / 3600f;
					waypoint_0.float_11 = float_1;
				}
				else if (waypoint_0.waypointType == Waypoint.WaypointType.WeaponTarget)
				{
					Waypoint waypoint;
					double latitude = (waypoint = waypoint_0).GetLatitude();
					Waypoint.Class126 class2 = new Waypoint.Class126(ref latitude, waypoint_0.GetLongitude(), waypoint_1.GetLatitude(), waypoint_1.GetLongitude());
					waypoint.SetLatitude(latitude);
					Waypoint.Class126 item = class2;
					list_0.Add(item);
					float azimuth2 = Math2.GetAzimuth(waypoint_1.GetLatitude(), waypoint_1.GetLongitude(), waypoint_0.GetLatitude(), waypoint_0.GetLongitude());
					double double_3 = 0.0;
					double double_4 = 0.0;
					GeoPointGenerator.GetOtherGeoPoint(waypoint_1.GetLongitude(), waypoint_1.GetLatitude(), ref double_3, ref double_4, 5.0, (double)azimuth2);
					latitude = (waypoint = waypoint_1).GetLatitude();
					Waypoint.Class126 class3 = new Waypoint.Class126(ref latitude, waypoint_1.GetLongitude(), double_4, double_3);
					waypoint.SetLatitude(latitude);
					item = class3;
					list_0.Add(item);
					waypoint_0.Leg_Distance = 5f;
					waypoint_0.float_10 = 0f;
					waypoint_0.float_11 = float_1;
				}
				else
				{
					Waypoint waypoint;
					double latitude = (waypoint = waypoint_1).GetLatitude();
					Waypoint.Class126 class4 = new Waypoint.Class126(ref latitude, waypoint_1.GetLongitude(), waypoint_0.GetLatitude(), waypoint_0.GetLongitude());
					waypoint.SetLatitude(latitude);
					Waypoint.Class126 item = class4;
					list_0.Add(item);
					waypoint_0.Leg_Distance = Math2.GetDistance(waypoint_1.GetLatitude(), waypoint_1.GetLongitude(), waypoint_0.GetLatitude(), waypoint_0.GetLongitude());
					waypoint_0.float_10 = 0f;
					waypoint_0.float_11 = float_1;
				}
				float_0 = Math2.Normalize(Math2.GetAzimuth(waypoint_0.GetLatitude(), waypoint_0.GetLongitude(), list_0[list_0.Count - 1].StartLatitude, list_0[list_0.Count - 1].StartLongitude) + 180f);
				waypoint_0.Leg_Time_Turn = num9;
				waypoint_0.Leg_Time_Straight = waypoint_0.Leg_Distance / float_1 * 3600f;
				waypoint_0.Leg_Time = waypoint_0.Leg_Time_Straight + waypoint_0.Leg_Time_Turn;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200627", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B81 RID: 27521 RVA: 0x003B4168 File Offset: 0x003B2368
		private static void smethod_18(Scenario scenario_, ActiveUnit activeUnit_, Mission theStrikeMissionInstance, Mission.Flight theFlight_, ref Waypoint[] waypoint_0, bool bool_0, float float_0, float float_1, List<string> list_0, float float_2, float float_3, float float_4, Misc.Enum102 enum102_0, bool bool_1, bool bool_2)
		{
			try
			{
				bool flag = true;
				Mission._FlightSize flightSize = activeUnit_.GetAssignedMission(false).m_FlightSize;
				if (bool_0)
				{
					if (bool_2)
					{
						if (!activeUnit_.HasParentGroup())
						{
							return;
						}
					}
					else if (activeUnit_.GetAssignedMission(false).m_FlightSize == Mission._FlightSize.SingleAircraft)
					{
						return;
					}
					if (bool_2 && !Information.IsNothing(activeUnit_.GetParentGroup(false)))
					{
						flightSize = (Mission._FlightSize)activeUnit_.GetParentGroup(false).GetUnitsInGroup().Count;
					}
					int num = waypoint_0.Count<Waypoint>() - 1;
					for (int i = 0; i <= num; i++)
					{
						Waypoint waypoint = waypoint_0[i];
						if (waypoint.FlightFormation == Waypoint._FlightFormation.Split)
						{
							int num2 = i;
							int num3 = waypoint_0.Count<Waypoint>() - 1;
							for (int j = num2; j <= num3; j++)
							{
								Waypoint waypoint2 = waypoint_0[j];
								if (waypoint.FlightFormation != Waypoint._FlightFormation.Split)
								{
									i = j;
									break;
								}
								if (waypoint2.waypointType == Waypoint.WaypointType.Target || waypoint2.waypointType == Waypoint.WaypointType.WeaponTarget)
								{
									float num4 = waypoint2.Leg_Distance + waypoint2.float_10;
									float num5 = waypoint2.Leg_Distance + waypoint2.float_10;
									switch (flightSize)
									{
									case Mission._FlightSize.TwoAircraft:
										waypoint2.WP_LeadElementWingman = new Waypoint();
										waypoint2.WP_LeadElementWingman = waypoint2.method_23(ref activeUnit_.m_Scenario, ref waypoint2, false, false);
										waypoint2.WP_LeadElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
										if (!Information.IsNothing(waypoint2.WP_LeadElementWingman.ArrivalTime_Zulu))
										{
											if (waypoint2.TimeFixed == Waypoint.Enum52.const_1)
											{
												waypoint2.WP_LeadElementWingman.TimeFixed = Waypoint.Enum52.const_1;
											}
											waypoint2.WP_LeadElementWingman.ArrivalTime_Zulu = new DateTime?(waypoint2.WP_LeadElementWingman.ArrivalTime_Zulu.Value.AddSeconds((double)float_4));
										}
										break;
									case Mission._FlightSize.ThreeAircraft:
										waypoint2.WP_LeadElementWingman = new Waypoint();
										waypoint2.WP_SecondElement = new Waypoint();
										waypoint2.WP_LeadElementWingman = waypoint2.method_23(ref activeUnit_.m_Scenario, ref waypoint2, false, false);
										waypoint2.WP_SecondElement = waypoint2.method_23(ref activeUnit_.m_Scenario, ref waypoint2, false, false);
										waypoint2.WP_LeadElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
										waypoint2.WP_SecondElement.SpeedFixed = Waypoint.Enum52.const_0;
										if (!Information.IsNothing(waypoint2.WP_LeadElementWingman.ArrivalTime_Zulu))
										{
											if (waypoint2.TimeFixed == Waypoint.Enum52.const_1)
											{
												waypoint2.WP_LeadElementWingman.TimeFixed = Waypoint.Enum52.const_1;
											}
											waypoint2.WP_LeadElementWingman.ArrivalTime_Zulu = new DateTime?(waypoint2.WP_LeadElementWingman.ArrivalTime_Zulu.Value.AddSeconds((double)float_4));
										}
										if (!Information.IsNothing(waypoint2.WP_SecondElement.ArrivalTime_Zulu))
										{
											if (waypoint2.TimeFixed == Waypoint.Enum52.const_1)
											{
												waypoint2.WP_SecondElement.TimeFixed = Waypoint.Enum52.const_1;
											}
											waypoint2.WP_SecondElement.ArrivalTime_Zulu = new DateTime?(waypoint2.WP_SecondElement.ArrivalTime_Zulu.Value.AddSeconds((double)(float_4 * 2f)));
										}
										break;
									case Mission._FlightSize.FourAircraft:
										waypoint2.WP_LeadElementWingman = new Waypoint();
										waypoint2.WP_SecondElement = new Waypoint();
										waypoint2.WP_SecondElementWingman = new Waypoint();
										waypoint2.WP_LeadElementWingman = waypoint2.method_23(ref activeUnit_.m_Scenario, ref waypoint2, false, false);
										waypoint2.WP_SecondElement = waypoint2.method_23(ref activeUnit_.m_Scenario, ref waypoint2, false, false);
										waypoint2.WP_SecondElementWingman = waypoint2.method_23(ref activeUnit_.m_Scenario, ref waypoint2, false, false);
										waypoint2.WP_LeadElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
										waypoint2.WP_SecondElement.SpeedFixed = Waypoint.Enum52.const_0;
										waypoint2.WP_SecondElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
										if (!Information.IsNothing(waypoint2.WP_LeadElementWingman.ArrivalTime_Zulu))
										{
											if (waypoint2.TimeFixed == Waypoint.Enum52.const_1)
											{
												waypoint2.WP_LeadElementWingman.TimeFixed = Waypoint.Enum52.const_1;
											}
											waypoint2.WP_LeadElementWingman.ArrivalTime_Zulu = new DateTime?(waypoint2.WP_LeadElementWingman.ArrivalTime_Zulu.Value.AddSeconds((double)float_4));
										}
										if (!Information.IsNothing(waypoint2.WP_SecondElement.ArrivalTime_Zulu))
										{
											if (waypoint2.TimeFixed == Waypoint.Enum52.const_1)
											{
												waypoint2.WP_SecondElement.TimeFixed = Waypoint.Enum52.const_1;
											}
											waypoint2.WP_SecondElement.ArrivalTime_Zulu = new DateTime?(waypoint2.WP_SecondElement.ArrivalTime_Zulu.Value.AddSeconds((double)(float_4 * 2f)));
										}
										if (!Information.IsNothing(waypoint2.WP_SecondElementWingman.ArrivalTime_Zulu))
										{
											if (waypoint2.TimeFixed == Waypoint.Enum52.const_1)
											{
												waypoint2.WP_SecondElementWingman.TimeFixed = Waypoint.Enum52.const_1;
											}
											waypoint2.WP_SecondElementWingman.ArrivalTime_Zulu = new DateTime?(waypoint2.WP_SecondElementWingman.ArrivalTime_Zulu.Value.AddSeconds((double)(float_4 * 3f)));
										}
										break;
									case Mission._FlightSize.SixAircraft:
										waypoint2.WP_LeadElementWingman = new Waypoint();
										waypoint2.WP_SecondElement = new Waypoint();
										waypoint2.WP_SecondElementWingman = new Waypoint();
										waypoint2.WP_ThirdElement = new Waypoint();
										waypoint2.WP_ThirdElementWingman = new Waypoint();
										waypoint2.WP_LeadElementWingman = waypoint2.method_23(ref activeUnit_.m_Scenario, ref waypoint2, false, false);
										waypoint2.WP_SecondElement = waypoint2.method_23(ref activeUnit_.m_Scenario, ref waypoint2, false, false);
										waypoint2.WP_SecondElementWingman = waypoint2.method_23(ref activeUnit_.m_Scenario, ref waypoint2, false, false);
										waypoint2.WP_ThirdElement = waypoint2.method_23(ref activeUnit_.m_Scenario, ref waypoint2, false, false);
										waypoint2.WP_ThirdElementWingman = waypoint2.method_23(ref activeUnit_.m_Scenario, ref waypoint2, false, false);
										waypoint2.WP_LeadElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
										waypoint2.WP_SecondElement.SpeedFixed = Waypoint.Enum52.const_0;
										waypoint2.WP_SecondElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
										waypoint2.WP_ThirdElement.SpeedFixed = Waypoint.Enum52.const_0;
										waypoint2.WP_ThirdElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
										if (!Information.IsNothing(waypoint2.WP_LeadElementWingman.ArrivalTime_Zulu))
										{
											if (waypoint2.TimeFixed == Waypoint.Enum52.const_1)
											{
												waypoint2.WP_LeadElementWingman.TimeFixed = Waypoint.Enum52.const_1;
											}
											waypoint2.WP_LeadElementWingman.ArrivalTime_Zulu = new DateTime?(waypoint2.WP_LeadElementWingman.ArrivalTime_Zulu.Value.AddSeconds((double)float_4));
										}
										if (!Information.IsNothing(waypoint2.WP_SecondElement.ArrivalTime_Zulu))
										{
											if (waypoint2.TimeFixed == Waypoint.Enum52.const_1)
											{
												waypoint2.WP_SecondElement.TimeFixed = Waypoint.Enum52.const_1;
											}
											waypoint2.WP_SecondElement.ArrivalTime_Zulu = new DateTime?(waypoint2.WP_SecondElement.ArrivalTime_Zulu.Value.AddSeconds((double)(float_4 * 2f)));
										}
										if (!Information.IsNothing(waypoint2.WP_SecondElementWingman.ArrivalTime_Zulu))
										{
											if (waypoint2.TimeFixed == Waypoint.Enum52.const_1)
											{
												waypoint2.WP_SecondElementWingman.TimeFixed = Waypoint.Enum52.const_1;
											}
											waypoint2.WP_SecondElementWingman.ArrivalTime_Zulu = new DateTime?(waypoint2.WP_SecondElementWingman.ArrivalTime_Zulu.Value.AddSeconds((double)(float_4 * 3f)));
										}
										if (!Information.IsNothing(waypoint2.WP_ThirdElement.ArrivalTime_Zulu))
										{
											if (waypoint2.TimeFixed == Waypoint.Enum52.const_1)
											{
												waypoint2.WP_ThirdElement.TimeFixed = Waypoint.Enum52.const_1;
											}
											waypoint2.WP_ThirdElement.ArrivalTime_Zulu = new DateTime?(waypoint2.WP_ThirdElement.ArrivalTime_Zulu.Value.AddSeconds((double)(float_4 * 4f)));
										}
										if (!Information.IsNothing(waypoint2.WP_ThirdElementWingman.ArrivalTime_Zulu))
										{
											if (waypoint2.TimeFixed == Waypoint.Enum52.const_1)
											{
												waypoint2.WP_ThirdElementWingman.TimeFixed = Waypoint.Enum52.const_1;
											}
											waypoint2.WP_ThirdElementWingman.ArrivalTime_Zulu = new DateTime?(waypoint2.WP_ThirdElementWingman.ArrivalTime_Zulu.Value.AddSeconds((double)(float_4 * 5f)));
										}
										break;
									}
									float num6 = 0f;
									float num7 = 0f;
									int k = j - 1;
									while (k >= 0)
									{
										Waypoint waypoint3 = waypoint_0[k];
										Waypoint waypoint4 = null;
										Waypoint waypoint5 = null;
										if (k < j && waypoint_0[k].FlightFormation != Waypoint._FlightFormation.Split)
										{
											waypoint4 = waypoint3;
											waypoint5 = null;
											if (k > 0)
											{
												waypoint5 = waypoint_0[k - 1];
												goto IL_830;
											}
											goto IL_830;
										}
										else if (k == 0)
										{
											goto IL_830;
										}
										IL_F7C:
										k += -1;
										continue;
										IL_830:
										if (waypoint2.float_10 > 0f && waypoint2.float_12 > 0f)
										{
											num6 += waypoint2.Leg_Time_Straight + waypoint2.Leg_Time_Turn;
										}
										else if (waypoint2.Leg_Distance > 0f && waypoint2.float_11 > 0f)
										{
											num6 += waypoint2.Leg_Time_Straight;
										}
										if (waypoint2.waypointType == Waypoint.WaypointType.WeaponTarget && waypoint2.FlightplanPointsList.Count > 0 && waypoint2.float_1 > 0f)
										{
											float distance = Math2.GetDistance(waypoint2.GetLatitude(), waypoint2.GetLongitude(), waypoint2.FlightplanPointsList[waypoint2.FlightplanPointsList.Count - 1].EndLatitude, waypoint2.FlightplanPointsList[waypoint2.FlightplanPointsList.Count - 1].EndLongitude);
											if (distance > 0f)
											{
												num5 += distance;
												num4 += distance;
											}
										}
										int num8 = j + 1;
										int num9 = waypoint_0.Count<Waypoint>() - 1;
										int l = num8;
										while (l <= num9)
										{
											waypoint3 = waypoint_0[l];
											if (waypoint3.float_10 > 0f && waypoint3.float_12 > 0f)
											{
												num7 += waypoint3.Leg_Time_Straight + waypoint3.Leg_Time_Turn;
											}
											else if (waypoint3.Leg_Distance > 0f && waypoint3.float_11 > 0f)
											{
												num7 += waypoint3.Leg_Time_Straight;
											}
											switch (flightSize)
											{
											case Mission._FlightSize.TwoAircraft:
												waypoint3.WP_LeadElementWingman = new Waypoint();
												waypoint3.WP_LeadElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
												waypoint3.WP_LeadElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
												break;
											case Mission._FlightSize.ThreeAircraft:
												waypoint3.WP_LeadElementWingman = new Waypoint();
												waypoint3.WP_LeadElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
												waypoint3.WP_LeadElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
												waypoint3.WP_SecondElement = new Waypoint();
												waypoint3.WP_SecondElement = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
												waypoint3.WP_SecondElement.SpeedFixed = Waypoint.Enum52.const_0;
												break;
											case Mission._FlightSize.FourAircraft:
												waypoint3.WP_LeadElementWingman = new Waypoint();
												waypoint3.WP_LeadElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
												waypoint3.WP_LeadElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
												waypoint3.WP_SecondElement = new Waypoint();
												waypoint3.WP_SecondElement = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
												waypoint3.WP_SecondElement.SpeedFixed = Waypoint.Enum52.const_0;
												waypoint3.WP_SecondElementWingman = new Waypoint();
												waypoint3.WP_SecondElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
												waypoint3.WP_SecondElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
												break;
											case Mission._FlightSize.SixAircraft:
												waypoint3.WP_LeadElementWingman = new Waypoint();
												waypoint3.WP_LeadElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
												waypoint3.WP_LeadElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
												waypoint3.WP_SecondElement = new Waypoint();
												waypoint3.WP_SecondElement = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
												waypoint3.WP_SecondElement.SpeedFixed = Waypoint.Enum52.const_0;
												waypoint3.WP_SecondElementWingman = new Waypoint();
												waypoint3.WP_SecondElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
												waypoint3.WP_SecondElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
												waypoint3.WP_ThirdElement = new Waypoint();
												waypoint3.WP_ThirdElement = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
												waypoint3.WP_ThirdElement.SpeedFixed = Waypoint.Enum52.const_0;
												waypoint3.WP_ThirdElementWingman = new Waypoint();
												waypoint3.WP_ThirdElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
												waypoint3.WP_ThirdElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
												break;
											}
											Waypoint waypoint6 = null;
											if (waypoint3.FlightFormation == Waypoint._FlightFormation.Split)
											{
												Waypoint waypoint7 = waypoint3;
												l++;
												if (l != num9)
												{
													continue;
												}
											}
											else
											{
												waypoint6 = waypoint3;
												i = l - 1;
												j = l - 1;
											}
											num6 += float_4;
											float num10 = num6 + float_4;
											float num11 = num10 + float_4;
											float num12 = num11 + float_4;
											float float_5 = num12 + float_4;
											num7 -= float_4;
											float num13 = num7 - float_4;
											float num14 = num13 - float_4;
											float num15 = num14 - float_4;
											float float_6 = num15 - float_4;
											Waypoint waypoint8 = null;
											Math2.GetAzimuth(waypoint2.GetLatitude(), waypoint2.GetLongitude(), waypoint8.GetLatitude(), waypoint8.GetLongitude());
											Waypoint.Class126 @class = waypoint4.FlightplanPointsList[waypoint4.FlightplanPointsList.Count - 1];
											float azimuth = Math2.GetAzimuth(@class.StartLatitude, @class.StartLongitude, @class.EndLatitude, @class.EndLongitude);
											switch (flightSize)
											{
											case Mission._FlightSize.TwoAircraft:
											{
												int int_;
												int int_2;
												int int_3;
												if (enum102_0 == Misc.Enum102.const_1)
												{
													int_ = 359;
													int_2 = 180;
													int_3 = -1;
												}
												else
												{
													int_ = 1;
													int_2 = 180;
													int_3 = 1;
												}
												int num16 = 0;
												Waypoint waypoint9 = null;
												Waypoint waypoint7 = null;
												StrikePlanner.smethod_20(ref theStrikeMissionInstance, ref theFlight_, ref activeUnit_, ref waypoint5, ref waypoint4, ref waypoint8, ref waypoint8.WP_LeadElementWingman, ref waypoint9, ref waypoint9.WP_LeadElementWingman, ref waypoint2, ref waypoint2.WP_LeadElementWingman, ref waypoint7, ref waypoint7.WP_LeadElementWingman, ref waypoint6, ref waypoint6.WP_LeadElementWingman, enum102_0, azimuth, float_3, num4, num5, num6, num7, float_4, int_, int_2, int_3, ref num16, float_0, true, bool_1);
												goto IL_1740;
											}
											case Mission._FlightSize.ThreeAircraft:
											{
												int int_;
												int int_2;
												int int_3;
												if (enum102_0 == Misc.Enum102.const_1)
												{
													int_ = 1;
													int_2 = 120;
													int_3 = 1;
												}
												else
												{
													int_ = 359;
													int_2 = 240;
													int_3 = -1;
												}
												int num16 = 0;
												Waypoint waypoint9 = null;
												Waypoint waypoint7 = null;
												StrikePlanner.smethod_20(ref theStrikeMissionInstance, ref theFlight_, ref activeUnit_, ref waypoint5, ref waypoint4, ref waypoint8, ref waypoint8.WP_LeadElementWingman, ref waypoint9, ref waypoint9.WP_LeadElementWingman, ref waypoint2, ref waypoint2.WP_LeadElementWingman, ref waypoint7, ref waypoint7.WP_LeadElementWingman, ref waypoint6, ref waypoint6.WP_LeadElementWingman, enum102_0, azimuth, float_3, num4, num5, num6, num7, float_4, int_, int_2, int_3, ref num16, float_0, true, bool_1);
												Misc.Enum102 enum102_;
												if (enum102_0 == Misc.Enum102.const_1)
												{
													enum102_ = Misc.Enum102.const_0;
												}
												else
												{
													enum102_ = Misc.Enum102.const_1;
												}
												if (enum102_0 == Misc.Enum102.const_1)
												{
													int_ = 359;
													int_2 = 240;
													int_3 = -1;
												}
												else
												{
													int_ = 1;
													int_2 = 120;
													int_3 = 1;
												}
												num16 = 0;
												float float_7 = (float)((double)float_3 + (double)waypoint4.float_11 * ((double)float_4 * 0.9 / 3600.0));
												StrikePlanner.smethod_20(ref theStrikeMissionInstance, ref theFlight_, ref activeUnit_, ref waypoint5, ref waypoint4, ref waypoint8, ref waypoint8.WP_SecondElement, ref waypoint9, ref waypoint9.WP_SecondElement, ref waypoint2, ref waypoint2.WP_SecondElement, ref waypoint7, ref waypoint7.WP_SecondElement, ref waypoint6, ref waypoint6.WP_SecondElement, enum102_, azimuth, float_3, float_7, num5, num10, num13, float_4, int_, int_2, int_3, ref num16, float_0, false, bool_1);
												goto IL_168A;
											}
											case Mission._FlightSize.FourAircraft:
											{
												int int_;
												int int_2;
												int int_3;
												if (enum102_0 == Misc.Enum102.const_1)
												{
													int_ = 1;
													int_2 = 120;
													int_3 = 1;
												}
												else
												{
													int_ = 359;
													int_2 = 240;
													int_3 = -1;
												}
												int num16 = 0;
												Waypoint waypoint9 = null;
												Waypoint waypoint7 = null;
												StrikePlanner.smethod_20(ref theStrikeMissionInstance, ref theFlight_, ref activeUnit_, ref waypoint5, ref waypoint4, ref waypoint8, ref waypoint8.WP_LeadElementWingman, ref waypoint9, ref waypoint9.WP_LeadElementWingman, ref waypoint2, ref waypoint2.WP_LeadElementWingman, ref waypoint7, ref waypoint7.WP_LeadElementWingman, ref waypoint6, ref waypoint6.WP_LeadElementWingman, enum102_0, azimuth, float_3, num4, num5, num6, num7, float_4, int_, int_2, int_3, ref num16, float_0, true, bool_1);
												Misc.Enum102 enum102_2;
												if (enum102_0 == Misc.Enum102.const_1)
												{
													enum102_2 = Misc.Enum102.const_0;
												}
												else
												{
													enum102_2 = Misc.Enum102.const_1;
												}
												if (enum102_0 == Misc.Enum102.const_1)
												{
													int_ = 359;
													int_2 = 240;
													int_3 = -1;
												}
												else
												{
													int_ = 1;
													int_2 = 120;
													int_3 = 1;
												}
												num16 = 0;
												float float_8 = (float)((double)float_3 + (double)waypoint4.float_11 * ((double)float_4 * 0.9 / 3600.0));
												StrikePlanner.smethod_20(ref theStrikeMissionInstance, ref theFlight_, ref activeUnit_, ref waypoint5, ref waypoint4, ref waypoint8, ref waypoint8.WP_SecondElement, ref waypoint9, ref waypoint9.WP_SecondElement, ref waypoint2, ref waypoint2.WP_SecondElement, ref waypoint7, ref waypoint7.WP_SecondElement, ref waypoint6, ref waypoint6.WP_SecondElement, enum102_2, azimuth, float_3, float_8, num5, num10, num13, float_4, int_, int_2, int_3, ref num16, float_0, false, bool_1);
												float_8 = (float)((double)float_3 + (double)waypoint4.float_11 * ((double)float_4 * 1.4 / 3600.0));
												StrikePlanner.smethod_20(ref theStrikeMissionInstance, ref theFlight_, ref activeUnit_, ref waypoint5, ref waypoint4, ref waypoint8, ref waypoint8.WP_SecondElementWingman, ref waypoint9, ref waypoint9.WP_SecondElementWingman, ref waypoint2, ref waypoint2.WP_SecondElementWingman, ref waypoint7, ref waypoint7.WP_SecondElementWingman, ref waypoint6, ref waypoint6.WP_SecondElementWingman, enum102_2, azimuth, float_3, float_8, num5, num11, num14, float_4, int_, int_2, int_3, ref num16, float_0, false, bool_1);
												goto IL_168A;
											}
											case (Mission._FlightSize)5:
												goto IL_168A;
											case Mission._FlightSize.SixAircraft:
											{
												int int_;
												int int_2;
												int int_3;
												if (enum102_0 == Misc.Enum102.const_1)
												{
													int_ = 1;
													int_2 = 120;
													int_3 = 1;
												}
												else
												{
													int_ = 359;
													int_2 = 240;
													int_3 = -1;
												}
												int num16 = 0;
												Waypoint waypoint9 = null;
												Waypoint waypoint7 = null;
												StrikePlanner.smethod_20(ref theStrikeMissionInstance, ref theFlight_, ref activeUnit_, ref waypoint5, ref waypoint4, ref waypoint8, ref waypoint8.WP_LeadElementWingman, ref waypoint9, ref waypoint9.WP_LeadElementWingman, ref waypoint2, ref waypoint2.WP_LeadElementWingman, ref waypoint7, ref waypoint7.WP_LeadElementWingman, ref waypoint6, ref waypoint6.WP_LeadElementWingman, enum102_0, azimuth, float_3, float_3, num5, num6, num7, float_4, int_, int_2, int_3, ref num16, float_0, true, bool_1);
												Misc.Enum102 enum102_3;
												if (enum102_0 == Misc.Enum102.const_1)
												{
													enum102_3 = Misc.Enum102.const_0;
												}
												else
												{
													enum102_3 = Misc.Enum102.const_1;
												}
												if (enum102_0 == Misc.Enum102.const_1)
												{
													int_ = 359;
													int_2 = 240;
													int_3 = -1;
												}
												else
												{
													int_ = 1;
													int_2 = 120;
													int_3 = 1;
												}
												num16 = 0;
												float float_9 = (float)((double)float_3 + (double)waypoint4.float_11 * ((double)float_4 * 0.9 / 3600.0));
												StrikePlanner.smethod_20(ref theStrikeMissionInstance, ref theFlight_, ref activeUnit_, ref waypoint5, ref waypoint4, ref waypoint8, ref waypoint8.WP_SecondElement, ref waypoint9, ref waypoint9.WP_SecondElement, ref waypoint2, ref waypoint2.WP_SecondElement, ref waypoint7, ref waypoint7.WP_SecondElement, ref waypoint6, ref waypoint6.WP_SecondElement, enum102_3, azimuth, float_3, float_9, num5, num10, num13, float_4, int_, int_2, int_3, ref num16, float_0, false, bool_1);
												float_9 = (float)((double)float_3 + (double)waypoint4.float_11 * ((double)float_4 * 1.4 / 3600.0));
												StrikePlanner.smethod_20(ref theStrikeMissionInstance, ref theFlight_, ref activeUnit_, ref waypoint5, ref waypoint4, ref waypoint8, ref waypoint8.WP_SecondElementWingman, ref waypoint9, ref waypoint9.WP_SecondElementWingman, ref waypoint2, ref waypoint2.WP_SecondElementWingman, ref waypoint7, ref waypoint7.WP_SecondElementWingman, ref waypoint6, ref waypoint6.WP_SecondElementWingman, enum102_3, azimuth, float_3, float_9, num5, num11, num14, float_4, int_, int_2, int_3, ref num16, float_0, false, bool_1);
												if (enum102_0 == Misc.Enum102.const_1)
												{
													int_ = 1;
													int_2 = 120;
													int_3 = 1;
												}
												else
												{
													int_ = 359;
													int_2 = 240;
													int_3 = -1;
												}
												num16 = 0;
												float_9 = (float)((double)float_3 + (double)waypoint4.float_11 * ((double)float_4 * 2.5 / 3600.0));
												StrikePlanner.smethod_20(ref theStrikeMissionInstance, ref theFlight_, ref activeUnit_, ref waypoint5, ref waypoint4, ref waypoint8, ref waypoint8.WP_ThirdElement, ref waypoint9, ref waypoint9.WP_ThirdElement, ref waypoint2, ref waypoint2.WP_ThirdElement, ref waypoint7, ref waypoint7.WP_ThirdElement, ref waypoint6, ref waypoint6.WP_ThirdElement, enum102_0, azimuth, float_3, float_9, num5, num12, num15, float_4, int_, int_2, int_3, ref num16, float_0, bool_1, bool_1);
												float_9 = float_3 + waypoint4.float_11 * (float_4 * 3f / 3600f);
												StrikePlanner.smethod_20(ref theStrikeMissionInstance, ref theFlight_, ref activeUnit_, ref waypoint5, ref waypoint4, ref waypoint8, ref waypoint8.WP_ThirdElementWingman, ref waypoint9, ref waypoint9.WP_ThirdElementWingman, ref waypoint2, ref waypoint2.WP_ThirdElementWingman, ref waypoint7, ref waypoint7.WP_ThirdElementWingman, ref waypoint6, ref waypoint6.WP_ThirdElementWingman, enum102_0, azimuth, float_3, float_9, num5, float_5, float_6, float_4, int_, int_2, int_3, ref num16, float_0, bool_1, bool_1);
												goto IL_168A;
											}
											default:
												goto IL_168A;
											}
										}
										if (k > 0 && waypoint_0[k].FlightFormation == Waypoint._FlightFormation.Split)
										{
											Waypoint waypoint8 = waypoint3;
											if (waypoint3.float_10 > 0f && waypoint3.float_12 > 0f)
											{
												num6 += waypoint3.Leg_Time_Straight + waypoint3.Leg_Time_Turn;
											}
											else if (waypoint3.Leg_Distance > 0f && waypoint3.float_11 > 0f)
											{
												num6 += waypoint3.Leg_Time_Straight;
											}
										}
										switch (flightSize)
										{
										case Mission._FlightSize.TwoAircraft:
											waypoint3.WP_LeadElementWingman = new Waypoint();
											waypoint3.WP_LeadElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
											waypoint3.WP_LeadElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
											break;
										case Mission._FlightSize.ThreeAircraft:
											waypoint3.WP_LeadElementWingman = new Waypoint();
											waypoint3.WP_LeadElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
											waypoint3.WP_LeadElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
											waypoint3.WP_SecondElement = new Waypoint();
											waypoint3.WP_SecondElement = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
											waypoint3.WP_SecondElement.SpeedFixed = Waypoint.Enum52.const_0;
											break;
										case Mission._FlightSize.FourAircraft:
											waypoint3.WP_LeadElementWingman = new Waypoint();
											waypoint3.WP_LeadElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
											waypoint3.WP_LeadElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
											waypoint3.WP_SecondElement = new Waypoint();
											waypoint3.WP_SecondElement = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
											waypoint3.WP_SecondElement.SpeedFixed = Waypoint.Enum52.const_0;
											waypoint3.WP_SecondElementWingman = new Waypoint();
											waypoint3.WP_SecondElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
											waypoint3.WP_SecondElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
											break;
										case Mission._FlightSize.SixAircraft:
											waypoint3.WP_LeadElementWingman = new Waypoint();
											waypoint3.WP_LeadElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
											waypoint3.WP_LeadElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
											waypoint3.WP_SecondElement = new Waypoint();
											waypoint3.WP_SecondElement = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
											waypoint3.WP_SecondElement.SpeedFixed = Waypoint.Enum52.const_0;
											waypoint3.WP_SecondElementWingman = new Waypoint();
											waypoint3.WP_SecondElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
											waypoint3.WP_SecondElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
											waypoint3.WP_ThirdElement = new Waypoint();
											waypoint3.WP_ThirdElement = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
											waypoint3.WP_ThirdElement.SpeedFixed = Waypoint.Enum52.const_0;
											waypoint3.WP_ThirdElementWingman = new Waypoint();
											waypoint3.WP_ThirdElementWingman = waypoint3.method_23(ref activeUnit_.m_Scenario, ref waypoint3, false, false);
											waypoint3.WP_ThirdElementWingman.SpeedFixed = Waypoint.Enum52.const_0;
											break;
										}
										if (waypoint3.waypointType == Waypoint.WaypointType.InitialPoint || waypoint3.waypointType == Waypoint.WaypointType.WeaponLaunch)
										{
											num4 += waypoint3.Leg_Distance + waypoint3.float_10;
										}
										if (waypoint3.waypointType == Waypoint.WaypointType.InitialPoint || waypoint3.waypointType == Waypoint.WaypointType.WeaponLaunch)
										{
											Waypoint waypoint9 = waypoint3;
											goto IL_F7C;
										}
										goto IL_F7C;
									}
								}
								IL_168A:;
							}
						}
						IL_1740:;
					}
				}
				int num17 = waypoint_0.Count<Waypoint>() - 1;
				for (int m = 0; m <= num17; m++)
				{
					Waypoint waypoint = waypoint_0[m];
					if (waypoint.FlightFormation == Waypoint._FlightFormation.Split)
					{
						Waypoint[] expression = null;
						Waypoint[] expression2 = null;
						Waypoint[] expression3 = null;
						Waypoint[] expression4 = null;
						Waypoint[] expression5 = null;
						switch (flightSize)
						{
						case Mission._FlightSize.TwoAircraft:
							expression = new Waypoint[0];
							break;
						case Mission._FlightSize.ThreeAircraft:
							expression = new Waypoint[0];
							expression2 = new Waypoint[0];
							break;
						case Mission._FlightSize.FourAircraft:
							expression = new Waypoint[0];
							expression2 = new Waypoint[0];
							expression3 = new Waypoint[0];
							break;
						case Mission._FlightSize.SixAircraft:
							expression = new Waypoint[0];
							expression2 = new Waypoint[0];
							expression3 = new Waypoint[0];
							expression4 = new Waypoint[0];
							expression5 = new Waypoint[0];
							break;
						}
						if (!Information.IsNothing(expression) && m > 1)
						{
							ScenarioArrayUtil.AddWaypoint(ref expression, waypoint_0[m - 2]);
						}
						if (!Information.IsNothing(expression2) && m > 1)
						{
							ScenarioArrayUtil.AddWaypoint(ref expression2, waypoint_0[m - 2]);
						}
						if (!Information.IsNothing(expression3) && m > 1)
						{
							ScenarioArrayUtil.AddWaypoint(ref expression3, waypoint_0[m - 2]);
						}
						if (!Information.IsNothing(expression4) && m > 1)
						{
							ScenarioArrayUtil.AddWaypoint(ref expression4, waypoint_0[m - 2]);
						}
						if (!Information.IsNothing(expression5) && m > 1)
						{
							ScenarioArrayUtil.AddWaypoint(ref expression5, waypoint_0[m - 2]);
						}
						if (!Information.IsNothing(expression) && m > 0)
						{
							ScenarioArrayUtil.AddWaypoint(ref expression, waypoint_0[m - 1]);
						}
						if (!Information.IsNothing(expression2) && m > 0)
						{
							ScenarioArrayUtil.AddWaypoint(ref expression2, waypoint_0[m - 1]);
						}
						if (!Information.IsNothing(expression3) && m > 0)
						{
							ScenarioArrayUtil.AddWaypoint(ref expression3, waypoint_0[m - 1]);
						}
						if (!Information.IsNothing(expression4) && m > 0)
						{
							ScenarioArrayUtil.AddWaypoint(ref expression4, waypoint_0[m - 1]);
						}
						if (!Information.IsNothing(expression5) && m > 0)
						{
							ScenarioArrayUtil.AddWaypoint(ref expression5, waypoint_0[m - 1]);
						}
						int num18 = m;
						int num19 = waypoint_0.Count<Waypoint>() - 1;
						int n = num18;
						while (n <= num19)
						{
							Waypoint waypoint2 = waypoint_0[n];
							m = n;
							if (!Information.IsNothing(expression) && !Information.IsNothing(waypoint_0[m].WP_LeadElementWingman))
							{
								ScenarioArrayUtil.AddWaypoint(ref expression, waypoint_0[m].WP_LeadElementWingman);
							}
							if (!Information.IsNothing(expression2) && !Information.IsNothing(waypoint_0[m].WP_SecondElement))
							{
								ScenarioArrayUtil.AddWaypoint(ref expression2, waypoint_0[m].WP_SecondElement);
							}
							if (!Information.IsNothing(expression3) && !Information.IsNothing(waypoint_0[m].WP_SecondElementWingman))
							{
								ScenarioArrayUtil.AddWaypoint(ref expression3, waypoint_0[m].WP_SecondElementWingman);
							}
							if (!Information.IsNothing(expression4) && !Information.IsNothing(waypoint_0[m].WP_ThirdElement))
							{
								ScenarioArrayUtil.AddWaypoint(ref expression4, waypoint_0[m].WP_ThirdElement);
							}
							if (!Information.IsNothing(expression5) && !Information.IsNothing(waypoint_0[m].WP_ThirdElementWingman))
							{
								ScenarioArrayUtil.AddWaypoint(ref expression5, waypoint_0[m].WP_ThirdElementWingman);
							}
							if (waypoint2.FlightFormation == Waypoint._FlightFormation.Split)
							{
								n++;
							}
							else
							{
								if (!Information.IsNothing(waypoint2.WP_LeadElementWingman))
								{
									waypoint2.WP_LeadElementWingman.SetLatitude(waypoint2.GetLatitude());
									waypoint2.WP_LeadElementWingman.SetLongitude(waypoint2.GetLongitude());
								}
								if (!Information.IsNothing(waypoint2.WP_SecondElement))
								{
									waypoint2.WP_SecondElement.SetLatitude(waypoint2.GetLatitude());
									waypoint2.WP_SecondElement.SetLongitude(waypoint2.GetLongitude());
								}
								if (!Information.IsNothing(waypoint2.WP_SecondElementWingman))
								{
									waypoint2.WP_SecondElementWingman.SetLatitude(waypoint2.GetLatitude());
									waypoint2.WP_SecondElementWingman.SetLongitude(waypoint2.GetLongitude());
								}
								if (!Information.IsNothing(waypoint2.WP_ThirdElement))
								{
									waypoint2.WP_ThirdElement.SetLatitude(waypoint2.GetLatitude());
									waypoint2.WP_ThirdElement.SetLongitude(waypoint2.GetLongitude());
								}
								if (!Information.IsNothing(waypoint2.WP_ThirdElementWingman))
								{
									waypoint2.WP_ThirdElementWingman.SetLatitude(waypoint2.GetLatitude());
									waypoint2.WP_ThirdElementWingman.SetLongitude(waypoint2.GetLongitude());
								}
								if (!Information.IsNothing(expression))
								{
									StrikePlanner.smethod_19(ref scenario_, ref theStrikeMissionInstance, ref theFlight_, ref expression, ref activeUnit_, float_0, ref list_0, ref flag, ref float_1, bool_0);
								}
								if (!Information.IsNothing(expression2))
								{
									StrikePlanner.smethod_19(ref scenario_, ref theStrikeMissionInstance, ref theFlight_, ref expression2, ref activeUnit_, float_0, ref list_0, ref flag, ref float_1, bool_0);
								}
								if (!Information.IsNothing(expression3))
								{
									StrikePlanner.smethod_19(ref scenario_, ref theStrikeMissionInstance, ref theFlight_, ref expression3, ref activeUnit_, float_0, ref list_0, ref flag, ref float_1, bool_0);
								}
								if (!Information.IsNothing(expression4))
								{
									StrikePlanner.smethod_19(ref scenario_, ref theStrikeMissionInstance, ref theFlight_, ref expression4, ref activeUnit_, float_0, ref list_0, ref flag, ref float_1, bool_0);
								}
								if (!Information.IsNothing(expression5))
								{
									StrikePlanner.smethod_19(ref scenario_, ref theStrikeMissionInstance, ref theFlight_, ref expression5, ref activeUnit_, float_0, ref list_0, ref flag, ref float_1, bool_0);
									break;
								}
								break;
							}
						}
					}
				}
				float num20 = float_1;
				float num21 = float_1;
				float num22 = float_1;
				float num23 = float_1;
				float num24 = float_1;
				float num25 = 0f;
				float num26 = 0f;
				float num27 = 0f;
				float num28 = 0f;
				float num29 = 0f;
				int num30 = waypoint_0.Count<Waypoint>() - 1;
				for (int num31 = 0; num31 <= num30; num31++)
				{
					Waypoint waypoint = waypoint_0[num31];
					if (!Information.IsNothing(waypoint))
					{
						switch (flightSize)
						{
						case Mission._FlightSize.TwoAircraft:
							if (waypoint.FlightFormation == Waypoint._FlightFormation.Split)
							{
								if (!Information.IsNothing(waypoint.WP_LeadElementWingman))
								{
									Doctrine._UseRefuel? useRefuelDoctrine = waypoint.WP_LeadElementWingman.m_Doctrine.GetUseRefuelDoctrine(activeUnit_.m_Scenario, false, false, false, false);
									byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
									bool? flag2 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
									if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
									{
										num20 = float_1;
									}
									else
									{
										num20 -= waypoint.WP_LeadElementWingman.Leg_FuelRequired;
									}
									num25 += waypoint.WP_LeadElementWingman.Leg_Distance + waypoint.WP_LeadElementWingman.float_10;
								}
							}
							else
							{
								if (waypoint.Leg_FuelRemaining == float_1)
								{
									num20 = float_1;
								}
								else
								{
									num20 -= waypoint.Leg_FuelRequired;
								}
								num25 += waypoint.Leg_Distance + waypoint.float_10;
							}
							waypoint.Leg_FuelRemaining_LeadElementWingman = num20;
							waypoint.Leg_TotalDistance_LeadElementWingman = num25;
							break;
						case Mission._FlightSize.ThreeAircraft:
							if (waypoint.FlightFormation == Waypoint._FlightFormation.Split)
							{
								if (!Information.IsNothing(waypoint.WP_LeadElementWingman))
								{
									Doctrine._UseRefuel? useRefuelDoctrine = waypoint.WP_LeadElementWingman.m_Doctrine.GetUseRefuelDoctrine(activeUnit_.m_Scenario, false, false, false, false);
									byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
									bool? flag2 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
									if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
									{
										num20 = float_1;
									}
									else
									{
										num20 -= waypoint.WP_LeadElementWingman.Leg_FuelRequired;
									}
									num25 += waypoint.WP_LeadElementWingman.Leg_Distance + waypoint.WP_LeadElementWingman.float_10;
								}
								if (!Information.IsNothing(waypoint.WP_SecondElement))
								{
									Doctrine._UseRefuel? useRefuelDoctrine = waypoint.WP_SecondElement.m_Doctrine.GetUseRefuelDoctrine(activeUnit_.m_Scenario, false, false, false, false);
									byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
									bool? flag2 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
									if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
									{
										num21 = float_1;
									}
									else
									{
										num21 -= waypoint.WP_SecondElement.Leg_FuelRequired;
									}
									num26 += waypoint.WP_SecondElement.Leg_Distance + waypoint.WP_SecondElement.float_10;
								}
							}
							else
							{
								if (waypoint.Leg_FuelRemaining == float_1)
								{
									num20 = float_1;
								}
								else
								{
									num20 -= waypoint.Leg_FuelRequired;
								}
								if (waypoint.Leg_FuelRemaining == float_1)
								{
									num21 = float_1;
								}
								else
								{
									num21 -= waypoint.Leg_FuelRequired;
								}
								num25 += waypoint.Leg_Distance + waypoint.float_10;
								num26 += waypoint.Leg_Distance + waypoint.float_10;
							}
							waypoint.Leg_FuelRemaining_LeadElementWingman = num20;
							waypoint.Leg_FuelRemaining_SecondElement = num21;
							waypoint.Leg_TotalDistance_LeadElementWingman = num25;
							waypoint.Leg_TotalDistance_SecondElement = num26;
							break;
						case Mission._FlightSize.FourAircraft:
							if (waypoint.FlightFormation == Waypoint._FlightFormation.Split)
							{
								if (!Information.IsNothing(waypoint.WP_LeadElementWingman))
								{
									Doctrine._UseRefuel? useRefuelDoctrine = waypoint.WP_LeadElementWingman.m_Doctrine.GetUseRefuelDoctrine(activeUnit_.m_Scenario, false, false, false, false);
									byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
									bool? flag2 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
									if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
									{
										num20 = float_1;
									}
									else
									{
										num20 -= waypoint.WP_LeadElementWingman.Leg_FuelRequired;
									}
									num25 += waypoint.WP_LeadElementWingman.Leg_Distance + waypoint.WP_LeadElementWingman.float_10;
								}
								if (!Information.IsNothing(waypoint.WP_SecondElement))
								{
									Doctrine._UseRefuel? useRefuelDoctrine = waypoint.WP_SecondElement.m_Doctrine.GetUseRefuelDoctrine(activeUnit_.m_Scenario, false, false, false, false);
									byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
									bool? flag2 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
									if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
									{
										num21 = float_1;
									}
									else
									{
										num21 -= waypoint.WP_SecondElement.Leg_FuelRequired;
									}
									num26 += waypoint.WP_SecondElement.Leg_Distance + waypoint.WP_SecondElement.float_10;
								}
								if (!Information.IsNothing(waypoint.WP_SecondElementWingman))
								{
									Doctrine._UseRefuel? useRefuelDoctrine = waypoint.WP_SecondElementWingman.m_Doctrine.GetUseRefuelDoctrine(activeUnit_.m_Scenario, false, false, false, false);
									byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
									bool? flag2 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
									if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
									{
										num22 = float_1;
									}
									else
									{
										num22 -= waypoint.WP_SecondElementWingman.Leg_FuelRequired;
									}
									num27 += waypoint.WP_SecondElementWingman.float_8;
								}
							}
							else
							{
								if (waypoint.Leg_FuelRemaining == float_1)
								{
									num20 = float_1;
								}
								else
								{
									num20 -= waypoint.Leg_FuelRequired;
								}
								if (waypoint.Leg_FuelRemaining == float_1)
								{
									num21 = float_1;
								}
								else
								{
									num21 -= waypoint.Leg_FuelRequired;
								}
								if (waypoint.Leg_FuelRemaining == float_1)
								{
									num22 = float_1;
								}
								else
								{
									num22 -= waypoint.Leg_FuelRequired;
								}
								num25 += waypoint.Leg_Distance + waypoint.float_10;
								num26 += waypoint.Leg_Distance + waypoint.float_10;
								num27 += waypoint.Leg_Distance + waypoint.float_10;
							}
							waypoint.Leg_FuelRemaining_LeadElementWingman = num20;
							waypoint.Leg_FuelRemaining_SecondElement = num21;
							waypoint.Leg_FuelRemaining_SecondElementWingman = num22;
							waypoint.Leg_TotalDistance_LeadElementWingman = num25;
							waypoint.Leg_TotalDistance_SecondElement = num26;
							waypoint.Leg_TotalDistance_SecondElementWingman = num27;
							break;
						case Mission._FlightSize.SixAircraft:
							if (waypoint.FlightFormation == Waypoint._FlightFormation.Split)
							{
								if (!Information.IsNothing(waypoint.WP_LeadElementWingman))
								{
									Doctrine._UseRefuel? useRefuelDoctrine = waypoint.WP_LeadElementWingman.m_Doctrine.GetUseRefuelDoctrine(activeUnit_.m_Scenario, false, false, false, false);
									byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
									bool? flag2 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
									if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
									{
										num20 = float_1;
									}
									else
									{
										num20 -= waypoint.WP_LeadElementWingman.Leg_FuelRequired;
									}
									num25 += waypoint.WP_LeadElementWingman.Leg_Distance + waypoint.WP_LeadElementWingman.float_10;
								}
								if (!Information.IsNothing(waypoint.WP_SecondElement))
								{
									Doctrine._UseRefuel? useRefuelDoctrine = waypoint.WP_SecondElement.m_Doctrine.GetUseRefuelDoctrine(activeUnit_.m_Scenario, false, false, false, false);
									byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
									bool? flag2 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
									if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
									{
										num21 = float_1;
									}
									else
									{
										num21 -= waypoint.WP_SecondElement.Leg_FuelRequired;
									}
									num26 += waypoint.WP_SecondElement.Leg_Distance + waypoint.WP_SecondElement.float_10;
								}
								if (!Information.IsNothing(waypoint.WP_SecondElementWingman))
								{
									Doctrine._UseRefuel? useRefuelDoctrine = waypoint.WP_SecondElementWingman.m_Doctrine.GetUseRefuelDoctrine(activeUnit_.m_Scenario, false, false, false, false);
									byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
									bool? flag2 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
									if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
									{
										num22 = float_1;
									}
									else
									{
										num22 -= waypoint.WP_SecondElementWingman.Leg_FuelRequired;
									}
									num27 += waypoint.WP_SecondElementWingman.float_8;
								}
								if (!Information.IsNothing(waypoint.WP_ThirdElement))
								{
									Doctrine._UseRefuel? useRefuelDoctrine = waypoint.WP_ThirdElement.m_Doctrine.GetUseRefuelDoctrine(activeUnit_.m_Scenario, false, false, false, false);
									byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
									bool? flag2 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
									if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
									{
										num23 = float_1;
									}
									else
									{
										num23 -= waypoint.WP_ThirdElement.Leg_FuelRequired;
									}
									num28 += waypoint.WP_ThirdElement.float_8;
								}
								if (!Information.IsNothing(waypoint.WP_ThirdElementWingman))
								{
									Doctrine._UseRefuel? useRefuelDoctrine = waypoint.WP_ThirdElementWingman.m_Doctrine.GetUseRefuelDoctrine(activeUnit_.m_Scenario, false, false, false, false);
									byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
									bool? flag2 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
									if ((flag2.HasValue ? new bool?(!flag2.GetValueOrDefault()) : flag2).GetValueOrDefault())
									{
										num24 = float_1;
									}
									else
									{
										num24 -= waypoint.WP_ThirdElementWingman.Leg_FuelRequired;
									}
									num29 += waypoint.WP_ThirdElementWingman.float_8;
								}
							}
							else
							{
								if (waypoint.Leg_FuelRemaining == float_1)
								{
									num20 = float_1;
								}
								else
								{
									num20 -= waypoint.Leg_FuelRequired;
								}
								if (waypoint.Leg_FuelRemaining == float_1)
								{
									num21 = float_1;
								}
								else
								{
									num21 -= waypoint.Leg_FuelRequired;
								}
								if (waypoint.Leg_FuelRemaining == float_1)
								{
									num22 = float_1;
								}
								else
								{
									num22 -= waypoint.Leg_FuelRequired;
								}
								if (waypoint.Leg_FuelRemaining == float_1)
								{
									num23 = float_1;
								}
								else
								{
									num23 -= waypoint.Leg_FuelRequired;
								}
								if (waypoint.Leg_FuelRemaining == float_1)
								{
									num24 = float_1;
								}
								else
								{
									num24 -= waypoint.Leg_FuelRequired;
								}
								num25 += waypoint.Leg_Distance + waypoint.float_10;
								num26 += waypoint.Leg_Distance + waypoint.float_10;
								num27 += waypoint.Leg_Distance + waypoint.float_10;
								num28 += waypoint.Leg_Distance + waypoint.float_10;
								num29 += waypoint.Leg_Distance + waypoint.float_10;
							}
							waypoint.Leg_FuelRemaining_LeadElementWingman = num20;
							waypoint.Leg_FuelRemaining_SecondElement = num21;
							waypoint.Leg_FuelRemaining_SecondElementWingman = num22;
							waypoint.Leg_FuelRemaining_ThirdElement = num23;
							waypoint.Leg_FuelRemaining_ThirdElementWingman = num24;
							waypoint.Leg_TotalDistance_LeadElementWingman = num25;
							waypoint.Leg_TotalDistance_SecondElement = num26;
							waypoint.Leg_TotalDistance_SecondElementWingman = num27;
							waypoint.Leg_TotalDistance_ThirdElement = num28;
							waypoint.Leg_TotalDistance_ThirdElementWingman = num29;
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200618", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B82 RID: 27522 RVA: 0x003B6B68 File Offset: 0x003B4D68
		private static void smethod_19(ref Scenario scenario_0, ref Mission mission_0, ref Mission.Flight class168_0, ref Waypoint[] waypoint_0, ref ActiveUnit activeUnit_0, float float_0, ref List<string> list_0, ref bool bool_0, ref float float_1, bool bool_1)
		{
			StrikePlanner.smethod_10(ref waypoint_0, ref activeUnit_0, true);
			StrikePlanner.smethod_15(waypoint_0, ref activeUnit_0, ref class168_0, ref list_0, ref float_0, true);
			if (StrikePlanner.smethod_16(ref waypoint_0, true))
			{
				for (int i = 0; i <= 10; i++)
				{
					StrikePlanner.smethod_15(waypoint_0, ref activeUnit_0, ref class168_0, ref list_0, ref float_0, true);
					if (!StrikePlanner.smethod_16(ref waypoint_0, true))
					{
						break;
					}
				}
			}
			StrikePlanner.smethod_14(ref waypoint_0, true);
			float num = 0f;
			StrikePlanner.smethod_13(ref waypoint_0, ref activeUnit_0, ref num, ref float_1, ref bool_0, true);
			StrikePlanner.smethod_11(ref scenario_0, ref mission_0, ref class168_0, ref waypoint_0, ref activeUnit_0, null, true, bool_1);
			StrikePlanner.smethod_12(ref waypoint_0, ref activeUnit_0, true);
			waypoint_0 = null;
		}

		// Token: 0x06006B83 RID: 27523 RVA: 0x003B6C04 File Offset: 0x003B4E04
		private static void smethod_20(ref Mission mission_, ref Mission.Flight theFlight_, ref ActiveUnit activeUnit_, ref Waypoint waypoint_0, ref Waypoint waypoint_1, ref Waypoint waypoint_2, ref Waypoint waypoint_3, ref Waypoint waypoint_4, ref Waypoint waypoint_5, ref Waypoint waypoint_6, ref Waypoint waypoint_7, ref Waypoint waypoint_8, ref Waypoint waypoint_9, ref Waypoint waypoint_10, ref Waypoint waypoint_11, Misc.Enum102 enum102_0, float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, float float_6, int int_0, int int_1, int int_2, ref int int_3, float float_7, bool bool_0, bool bool_1)
		{
			try
			{
				float num = 0f;
				float num2 = 0f;
				double latitude = waypoint_3.GetLatitude();
				double longitude = waypoint_3.GetLongitude();
				double latitude2 = waypoint_5.GetLatitude();
				double longitude2 = waypoint_5.GetLongitude();
				double latitude3 = waypoint_9.GetLatitude();
				double longitude3 = waypoint_9.GetLongitude();
				float num3 = 3.40282347E+38f;
				float num4 = 3.40282347E+38f;
				bool flag = false;
				bool flag2 = false;
				float num5;
				if (int_3 == 0)
				{
					num5 = float_0;
				}
				else
				{
					num5 = float_0 + (float)int_3;
					int_0 += int_3;
				}
				int num6 = int_0;
				while ((int_2 >> 31 ^ num6) <= (int_2 >> 31 ^ int_1))
				{
					num5 = Math2.Normalize(num5 + (float)int_2);
					if (!flag)
					{
						double longitude4 = waypoint_1.GetLongitude();
						double latitude4 = waypoint_1.GetLatitude();
						Waypoint waypoint;
						double num7 = (waypoint = waypoint_3).GetLongitude();
						Waypoint waypoint2;
						double num8 = (waypoint2 = waypoint_3).GetLatitude();
						GeoPointGenerator.GetOtherGeoPoint(longitude4, latitude4, ref num7, ref num8, (double)float_2, (double)num5);
						waypoint2.SetLatitude(num8);
						waypoint.SetLongitude(num7);
					}
					float num9 = float_0;
					Waypoint waypoint3 = waypoint_3;
					Waypoint waypoint4 = waypoint_1;
					Waypoint waypoint5 = waypoint_0;
					float float_8 = waypoint4.float_1;
					float float_9 = waypoint5.float_1;
					List<Waypoint.Class126> flightplanPointsList = new List<Waypoint.Class126>();
					List<Waypoint.Class126> list = new List<Waypoint.Class126>();
					List<Waypoint.Class126> flightplanPointsList2 = new List<Waypoint.Class126>();
					float num10 = num5;
					Misc.Enum102 @enum = Misc.smethod_63(num9, num10);
					if (@enum != Misc.Enum102.const_0)
					{
						if (@enum == Misc.Enum102.const_1)
						{
							float_7 = 9f;
						}
					}
					else
					{
						float_7 = -9f;
					}
					float float_10 = float_9;
					List<string> list2 = null;
					bool flag3 = false;
					StrikePlanner.smethod_17(ref num9, ref flightplanPointsList, ref waypoint3, ref waypoint4, ref float_8, float_10, ref activeUnit_, ref theFlight_, ref list2, float_7, @enum, num10, ref flag3);
					if (!flag3)
					{
						waypoint3 = waypoint_5;
						waypoint4 = waypoint_3;
						waypoint5 = waypoint_1;
						float_8 = waypoint4.float_1;
						float_9 = waypoint5.float_1;
						num10 = Math2.GetAzimuth(waypoint4.GetLatitude(), waypoint4.GetLongitude(), waypoint_6.GetLatitude(), waypoint_6.GetLongitude());
						if (!flag)
						{
							double longitude5 = waypoint_6.GetLongitude();
							double latitude5 = waypoint_6.GetLatitude();
							Waypoint waypoint2;
							double num8 = (waypoint2 = waypoint3).GetLongitude();
							Waypoint waypoint;
							double num7 = (waypoint = waypoint3).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude5, latitude5, ref num8, ref num7, (double)float_3, (double)Math2.Normalize(num10 + 180f));
							waypoint.SetLatitude(num7);
							waypoint2.SetLongitude(num8);
						}
						@enum = Misc.smethod_63(num9, num10);
						if (@enum != Misc.Enum102.const_0)
						{
							if (@enum == Misc.Enum102.const_1)
							{
								float_7 = 9f;
							}
						}
						else
						{
							float_7 = -9f;
						}
						float num11 = num9;
						float float_11 = float_9;
						list2 = null;
						StrikePlanner.smethod_17(ref num9, ref list, ref waypoint3, ref waypoint4, ref float_8, float_11, ref activeUnit_, ref theFlight_, ref list2, float_7, @enum, num10, ref flag3);
						if (!flag && (flag3 || list.Count > 1))
						{
							num10 = Math2.GetAzimuth(waypoint4.GetLatitude(), waypoint4.GetLongitude(), waypoint3.GetLatitude(), waypoint3.GetLongitude());
							num9 = num11;
							list = new List<Waypoint.Class126>();
							float float_12 = float_9;
							list2 = null;
							StrikePlanner.smethod_17(ref num9, ref list, ref waypoint_7, ref waypoint4, ref float_8, float_12, ref activeUnit_, ref theFlight_, ref list2, float_7, @enum, num10, ref flag3);
							if (!flag3 && list.Count > 1)
							{
								float num12 = Math2.GetDistance(waypoint_7.GetLatitude(), waypoint_7.GetLongitude(), list[list.Count - 1].StartLatitude, list[list.Count - 1].StartLongitude);
								float num13;
								switch (waypoint4.TurnRate)
								{
								case Waypoint._TurnRate.Standard:
									num13 = 3f;
									break;
								case Waypoint._TurnRate.Half:
									num13 = 1.5f;
									break;
								case Waypoint._TurnRate.Double:
									num13 = 6f;
									break;
								default:
									num13 = 3f;
									break;
								}
								float num14 = Math.Abs(float_7) / num13;
								float num15 = float_9 / 3600f * num14;
								num12 -= 3f * num15;
								if (num12 > 0f)
								{
									float azimuth = Math2.GetAzimuth(waypoint_6.GetLatitude(), waypoint_6.GetLongitude(), list[list.Count - 1].StartLatitude, list[list.Count - 1].StartLongitude);
									if (num12 > float_3)
									{
										double longitude6 = waypoint_6.GetLongitude();
										double latitude6 = waypoint_6.GetLatitude();
										Waypoint waypoint;
										double num7 = (waypoint = waypoint3).GetLongitude();
										Waypoint waypoint2;
										double num8 = (waypoint2 = waypoint3).GetLatitude();
										GeoPointGenerator.GetOtherGeoPoint(longitude6, latitude6, ref num7, ref num8, (double)float_3, (double)azimuth);
										waypoint2.SetLatitude(num8);
										waypoint.SetLongitude(num7);
									}
									else
									{
										double longitude7 = waypoint_6.GetLongitude();
										double latitude7 = waypoint_6.GetLatitude();
										Waypoint waypoint2;
										double num8 = (waypoint2 = waypoint3).GetLongitude();
										Waypoint waypoint;
										double num7 = (waypoint = waypoint3).GetLatitude();
										GeoPointGenerator.GetOtherGeoPoint(longitude7, latitude7, ref num8, ref num7, (double)num12, (double)azimuth);
										waypoint.SetLatitude(num7);
										waypoint2.SetLongitude(num8);
									}
									num10 = Math2.GetAzimuth(waypoint4.GetLatitude(), waypoint4.GetLongitude(), waypoint3.GetLatitude(), waypoint3.GetLongitude());
									num9 = num11;
									list = new List<Waypoint.Class126>();
									float float_13 = float_9;
									list2 = null;
									StrikePlanner.smethod_17(ref num9, ref list, ref waypoint3, ref waypoint4, ref float_8, float_13, ref activeUnit_, ref theFlight_, ref list2, float_7, @enum, num10, ref flag3);
								}
								else
								{
									flag3 = true;
								}
							}
						}
					}
					if (!flag3)
					{
						waypoint3 = waypoint_7;
						waypoint4 = waypoint_5;
						waypoint5 = waypoint_3;
						float_8 = waypoint4.float_1;
						float_9 = waypoint5.float_1;
						num10 = Math2.GetAzimuth(waypoint4.GetLatitude(), waypoint4.GetLongitude(), waypoint3.GetLatitude(), waypoint3.GetLongitude());
						@enum = Misc.smethod_63(num9, num10);
						if (@enum != Misc.Enum102.const_0)
						{
							if (@enum == Misc.Enum102.const_1)
							{
								float_7 = 9f;
							}
						}
						else
						{
							float_7 = -9f;
						}
						float float_14 = float_9;
						list2 = null;
						StrikePlanner.smethod_17(ref num9, ref flightplanPointsList2, ref waypoint3, ref waypoint4, ref float_8, float_14, ref activeUnit_, ref theFlight_, ref list2, float_7, @enum, num10, ref flag3);
					}
					float num16 = waypoint5.Leg_Time_Straight + waypoint5.Leg_Time_Turn + waypoint4.Leg_Time_Straight + waypoint4.Leg_Time_Turn + waypoint3.Leg_Time_Straight + waypoint3.Leg_Time_Turn;
					bool flag4 = !flag3 && num16 > float_4 && (double)Math.Abs(num16 - float_4) > 0.5;
					if (num < num16)
					{
						num = num16;
					}
					if (flag || (!flag3 && !flag4 && num16 >= float_4))
					{
						waypoint5.FlightplanPointsList = flightplanPointsList;
						waypoint4.FlightplanPointsList = list;
						waypoint3.FlightplanPointsList = flightplanPointsList2;
						if (float_1 > 0f)
						{
							waypoint3 = waypoint_9;
							waypoint4 = waypoint_7;
							waypoint5 = waypoint_5;
							flightplanPointsList = new List<Waypoint.Class126>();
							List<Waypoint.Class126> flightplanPointsList3 = new List<Waypoint.Class126>();
							float_8 = waypoint4.float_1;
							float_9 = waypoint5.float_1;
							float azimuth2 = Math2.GetAzimuth(waypoint_7.GetLatitude(), waypoint_7.GetLongitude(), waypoint_10.GetLatitude(), waypoint_10.GetLongitude());
							Math2.Normalize(num9 - azimuth2);
							float num17 = num9;
							int num18;
							int num19;
							float num20;
							if (enum102_0 == Misc.Enum102.const_1)
							{
								if (bool_0)
								{
									num18 = 0;
									num19 = -135;
									num20 = -1f;
								}
								else
								{
									num18 = 0;
									num19 = 135;
									num20 = 1f;
								}
							}
							else if (bool_0)
							{
								num18 = 0;
								num19 = 135;
								num20 = 1f;
							}
							else
							{
								num18 = 0;
								num19 = -135;
								num20 = -1f;
							}
							num5 = azimuth2;
							float num21 = Math2.GetDistance(waypoint_7.GetLatitude(), waypoint_7.GetLongitude(), waypoint_10.GetLatitude(), waypoint_10.GetLongitude()) - float_1;
							int num22 = 10;
							int num23 = 0;
							float num24 = (float)num18;
							float num25 = (float)num19;
							float num26 = num20;
							bool flag5 = num26 >= 0f;
							float num27 = num24;
							while (flag5 ? (num27 <= num25) : (num27 >= num25))
							{
								num5 = Math2.Normalize(num5 + num20);
								if (!flag2)
								{
									double longitude8 = waypoint_7.GetLongitude();
									double latitude8 = waypoint_7.GetLatitude();
									Waypoint waypoint;
									double num7 = (waypoint = waypoint_9).GetLongitude();
									Waypoint waypoint2;
									double num8 = (waypoint2 = waypoint_9).GetLatitude();
									GeoPointGenerator.GetOtherGeoPoint(longitude8, latitude8, ref num7, ref num8, (double)num21, (double)num5);
									waypoint2.SetLatitude(num8);
									waypoint.SetLongitude(num7);
								}
								num9 = num17;
								waypoint3 = waypoint_9;
								waypoint4 = waypoint_7;
								waypoint5 = waypoint_5;
								float_8 = waypoint4.float_1;
								float_9 = waypoint5.float_1;
								flightplanPointsList = new List<Waypoint.Class126>();
								flightplanPointsList3 = new List<Waypoint.Class126>();
								num10 = num5;
								@enum = Misc.smethod_63(num9, num10);
								if (@enum != Misc.Enum102.const_0)
								{
									if (@enum == Misc.Enum102.const_1)
									{
										float_7 = 9f;
									}
								}
								else
								{
									float_7 = -9f;
								}
								float float_15 = float_9;
								list2 = null;
								StrikePlanner.smethod_17(ref num9, ref flightplanPointsList, ref waypoint3, ref waypoint4, ref float_8, float_15, ref activeUnit_, ref theFlight_, ref list2, float_7, @enum, num10, ref flag3);
								if (!flag3)
								{
									waypoint3 = waypoint_11;
									waypoint4 = waypoint_9;
									waypoint5 = waypoint_7;
									float_8 = waypoint4.float_1;
									float_9 = waypoint5.float_1;
									num10 = Math2.GetAzimuth(waypoint4.GetLatitude(), waypoint4.GetLongitude(), waypoint3.GetLatitude(), waypoint3.GetLongitude());
									@enum = Misc.smethod_63(num9, num10);
									if (@enum != Misc.Enum102.const_0)
									{
										if (@enum == Misc.Enum102.const_1)
										{
											float_7 = 9f;
										}
									}
									else
									{
										float_7 = -9f;
									}
									float float_16 = float_9;
									list2 = null;
									StrikePlanner.smethod_17(ref num9, ref flightplanPointsList3, ref waypoint3, ref waypoint4, ref float_8, float_16, ref activeUnit_, ref theFlight_, ref list2, float_7, @enum, num10, ref flag3);
								}
								float num28 = waypoint4.Leg_Time_Straight + waypoint4.Leg_Time_Turn + waypoint3.Leg_Time_Straight + waypoint3.Leg_Time_Turn;
								flag4 = (!flag3 && num28 > float_5 && (double)Math.Abs(num28 - float_5) > 0.5);
								if (num2 < num28)
								{
									num2 = num28;
								}
								if (flag2 || (!flag3 && !flag4 && num28 >= float_5))
								{
									waypoint4.FlightplanPointsList = flightplanPointsList;
									waypoint3.FlightplanPointsList = flightplanPointsList3;
									break;
								}
								if (!flag3 && Math.Abs(num28 - float_5) < num4)
								{
									latitude3 = waypoint_9.GetLatitude();
									longitude3 = waypoint_9.GetLongitude();
									num4 = Math.Abs(num28 - float_5);
								}
								if (num27 == (float)num19)
								{
									if (!flag3)
									{
										num21 += (float)((double)(Math.Abs((num28 - float_5) * float_8) / 3600f) * 0.5);
										num27 = (float)num18;
										num2 = 0f;
										num5 = azimuth2;
										num23++;
										if (num23 > num22)
										{
											flag2 = true;
											waypoint_9.SetLatitude(latitude3);
											waypoint_9.SetLongitude(longitude3);
										}
									}
									else if (flag3)
									{
										num21 -= (float)Math.Min((double)(Math.Abs(num28 - float_5) * float_8 / 3600f) * 0.5, 2.0);
										num27 = (float)num18;
										num2 = 0f;
										num5 = azimuth2;
										num23++;
										if (num23 > num22 || num21 < 0f)
										{
											flag2 = true;
											waypoint_9.SetLatitude(latitude3);
											waypoint_9.SetLongitude(longitude3);
										}
									}
								}
								else if (flag4)
								{
									if (Math.Abs(num27 - (float)num18) > 45f)
									{
										num21 -= (float)Math.Min(Math.Max((double)(Math.Abs(num28 - float_5) * float_8 / 3600f) * 0.5, 0.05), 2.0);
										num27 = (float)num18;
										num2 = 0f;
										num5 = azimuth2;
										num23++;
										if (num23 > num22 || num21 < 0f)
										{
											flag2 = true;
											waypoint_9.SetLatitude(latitude3);
											waypoint_9.SetLongitude(longitude3);
										}
									}
								}
								else if (num2 > num28 && num2 < float_5 && Math.Abs(num27 - (float)num18) > 45f)
								{
									num21 += (float)Math.Min((double)(Math.Abs(num28 - float_5) * float_8 / 3600f) * 0.5, 2.0);
									num27 = (float)num18;
									num2 = 0f;
									num5 = azimuth2;
									num23++;
									if (num23 > num22 || num21 < 0f)
									{
										flag2 = true;
										waypoint_9.SetLatitude(latitude3);
										waypoint_9.SetLongitude(longitude3);
									}
								}
								if (flag2)
								{
									string text = "";
									if (Operators.CompareString(activeUnit_.Name, activeUnit_.UnitClass, false) != 0)
									{
										text = " (" + activeUnit_.UnitClass + ")";
									}
									string text2;
									if (mission_.category == Mission.MissionCategory.Package)
									{
										text2 = "";
									}
									else
									{
										text2 = "Mission ";
									}
									activeUnit_.m_Scenario.LogMessage(string.Concat(new string[]
									{
										text2,
										mission_.Name,
										" with aircraft type ",
										text,
										" was not able to auto-generate an optimum multi-axis time-on-target (ToT) flightplan for one of the wingmen. A flightplan has been successfully created, but may need player attention. It is likely that one of the wingmen may be slighly early or slightly late for one or more waypoints on the egress leg where the flight splits."
									}), LoggedMessage.MessageType.AirOps, 15, activeUnit_.GetGuid(), activeUnit_.GetSide(false), new GeoPoint(activeUnit_.GetLongitude(null), activeUnit_.GetLatitude(null)));
								}
								num27 += num26;
							}
						}
						break;
					}
					if (!flag3 && Math.Abs(num16 - float_4) < num3)
					{
						latitude = waypoint_3.GetLatitude();
						longitude = waypoint_3.GetLongitude();
						latitude2 = waypoint_5.GetLatitude();
						longitude2 = waypoint_5.GetLongitude();
						num3 = Math.Abs(num16 - float_4);
					}
					if (num6 == int_1)
					{
						if (!flag3)
						{
							float_2 += (float)((double)(Math.Abs((num16 - float_4) * float_8) / 3600f) * 0.5);
							num6 = int_0;
							num = 0f;
							if (int_3 == 0)
							{
								num5 = float_0;
							}
							else
							{
								num5 = float_0 + (float)int_3;
								int_0 += int_3;
							}
						}
						else if (flag3)
						{
							float_2 -= (float)Math.Min((double)(Math.Abs(num16 - float_4) * float_8 / 3600f) * 0.5, 2.0);
							num6 = int_0;
							num = 0f;
							if (int_3 == 0)
							{
								num5 = float_0;
							}
							else
							{
								num5 = float_0 + (float)int_3;
							}
							if (float_2 < 0f)
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								flag = true;
								waypoint_3.SetLatitude(latitude);
								waypoint_3.SetLongitude(longitude);
								waypoint_5.SetLatitude(latitude2);
								waypoint_5.SetLongitude(longitude2);
							}
						}
					}
					else if (flag4)
					{
						float_2 -= (float)Math.Min((double)(Math.Abs(num16 - float_4) * float_8 / 3600f) * 0.5, 2.0);
						num6 = int_0;
						num = 0f;
						if (int_3 == 0)
						{
							num5 = float_0;
						}
						else
						{
							num5 = float_0 + (float)int_3;
						}
						if (float_2 < 0f)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							flag = true;
							waypoint_3.SetLatitude(latitude);
							waypoint_3.SetLongitude(longitude);
							waypoint_5.SetLatitude(latitude2);
							waypoint_5.SetLongitude(longitude2);
						}
					}
					else if (num > num16 && num < float_4 && Math.Abs(num6 - int_0) > 45)
					{
						float_2 += (float)Math.Min((double)(Math.Abs(num16 - float_4) * float_8 / 3600f) * 0.5, 2.0);
						num6 = int_0;
						num = 0f;
						if (int_3 == 0)
						{
							num5 = float_0;
						}
						else
						{
							num5 = float_0 + (float)int_3;
						}
						if (float_2 < 0f)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							flag = true;
							waypoint_3.SetLatitude(latitude);
							waypoint_3.SetLongitude(longitude);
							waypoint_5.SetLatitude(latitude2);
							waypoint_5.SetLongitude(longitude2);
						}
					}
					if (flag)
					{
						string text3 = "";
						if (Operators.CompareString(activeUnit_.Name, activeUnit_.UnitClass, false) != 0)
						{
							text3 = " (" + activeUnit_.UnitClass + ")";
						}
						string text4;
						if (mission_.category == Mission.MissionCategory.Package)
						{
							text4 = "";
						}
						else
						{
							text4 = "Mission ";
						}
						activeUnit_.m_Scenario.LogMessage(string.Concat(new string[]
						{
							text4,
							mission_.Name,
							" with aircraft type ",
							text3,
							" was not able to auto-generate an optimum multi-axis time-on-target (ToT) flightplan for one of the wingmen. A flightplan has been successfully created, but may need player attention. It is likely that one of the wingmen may be slighly early or slightly late for one or more waypoints on the ingress leg where the flight splits."
						}), LoggedMessage.MessageType.AirOps, 15, activeUnit_.GetGuid(), activeUnit_.GetSide(false), new GeoPoint(activeUnit_.GetLongitude(null), activeUnit_.GetLatitude(null)));
					}
					num6 += int_2;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200619", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B84 RID: 27524 RVA: 0x003B7D50 File Offset: 0x003B5F50
		private static void smethod_21(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, ref float float_0, ref float float_1, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_2, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, Waypoint.WaypointType.Assemble, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = Waypoint.WaypointType.Assemble;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(Waypoint.WaypointType.Assemble);
			waypoint.Category = Waypoint._Category.const_1;
			if (class85_0.CruiseAtOptimumAltitude)
			{
				Waypoint waypoint2 = waypoint;
				ActiveUnit_AI aircraftAI = aircraft_0.GetAircraftAI();
				bool flag = false;
				waypoint2.DesiredAltitude = new float?(aircraftAI.method_78(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref flag));
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			else if (class85_0.CruiseAltitudeIngressTerrainFollowing)
			{
				waypoint.SetIsTerrainFollowing(true);
				waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.CruiseAltitudeIngress);
				float_0 = 0f;
				float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
				bool_0 = waypoint.IsTerrainFollowing();
			}
			else
			{
				waypoint.DesiredAltitude = new float?(class85_0.CruiseAltitudeIngress);
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.CruiseThrottleSettingIngress);
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				enum6_0 = waypoint.GetThrottlePreset();
			}
			else if (!Information.IsNothing(enum6_0) && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.None && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.FullStop)
			{
				waypoint.SetThrottlePreset(enum6_0);
			}
			else
			{
				waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
				enum6_0 = waypoint.GetThrottlePreset();
			}
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_2 = waypoint.DesiredSpeed.Value;
			}
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			waypoint.FlightFormation = enum53_0;
			waypoint.SetDAO(true);
			if (class85_0.FormUpTime > 0)
			{
				waypoint.Hold_Time = (float)(class85_0.FormUpTime * 60);
			}
			if (Information.IsNothing(waypoint_0))
			{
				ScenarioArrayUtil.AddWaypoint(ref waypoint_1, waypoint);
			}
		}

		// Token: 0x06006B85 RID: 27525 RVA: 0x003B7FDC File Offset: 0x003B61DC
		private static void smethod_22(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, Mission._RadarBehaviour enum63_0, ref float float_0, ref float float_1, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_2, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = Waypoint.WaypointType.StrikeIngress;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(Waypoint.WaypointType.StrikeIngress);
			waypoint.Category = Waypoint._Category.const_1;
			if (class85_0.CruiseAtOptimumAltitude)
			{
				Waypoint waypoint2 = waypoint;
				ActiveUnit_AI aircraftAI = aircraft_0.GetAircraftAI();
				bool flag = false;
				waypoint2.DesiredAltitude = new float?(aircraftAI.method_78(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref flag));
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			else if (class85_0.AttackAltitudeIngress == 0f)
			{
				if (class85_0.CruiseAltitudeIngressTerrainFollowing)
				{
					waypoint.SetIsTerrainFollowing(true);
					waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.CruiseAltitudeIngress);
					float_0 = 0f;
					float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
					bool_0 = waypoint.IsTerrainFollowing();
				}
				else
				{
					waypoint.DesiredAltitude = new float?(class85_0.CruiseAltitudeIngress);
					float_0 = waypoint.DesiredAltitude.Value;
					float_1 = 0f;
					bool_0 = false;
				}
			}
			else if (class85_0.AttackAltitudeIngressTerrainFollowing)
			{
				waypoint.SetIsTerrainFollowing(true);
				waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.AttackAltitudeIngress);
				float_0 = 0f;
				float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
				bool_0 = waypoint.IsTerrainFollowing();
			}
			else
			{
				waypoint.DesiredAltitude = new float?(class85_0.AttackAltitudeIngress);
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			if (class85_0.AttackThrottleSetting != ActiveUnit.Throttle.FullStop)
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.AttackThrottleSetting);
			}
			else
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.CruiseThrottleSettingIngress);
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				enum6_0 = waypoint.GetThrottlePreset();
			}
			else if (!Information.IsNothing(enum6_0) && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.None && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.FullStop)
			{
				waypoint.SetThrottlePreset(enum6_0);
			}
			else
			{
				waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
				enum6_0 = waypoint.GetThrottlePreset();
			}
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_2 = waypoint.DesiredSpeed.Value;
			}
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			waypoint.FlightFormation = enum53_0;
			waypoint.SetDAO(true);
			if (!Information.IsNothing(enum63_0) && enum63_0 == Mission._RadarBehaviour.Maritime)
			{
				waypoint.m_Doctrine.method_174(Doctrine.EMCON_Settings.Enum36.const_1, Doctrine.EMCON_Settings.Enum36.const_3, Doctrine.EMCON_Settings.Enum36.const_3);
			}
			if (Information.IsNothing(waypoint_0))
			{
				ScenarioArrayUtil.AddWaypoint(ref waypoint_1, waypoint);
			}
		}

		// Token: 0x06006B86 RID: 27526 RVA: 0x003B831C File Offset: 0x003B651C
		private static void smethod_23(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, Mission._RadarBehaviour enum63_0, ref float float_0, ref float float_1, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_2, ref Mission._AttackMethod enum65_0, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = Waypoint.WaypointType.StrikeIngress;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(Waypoint.WaypointType.StrikeIngress);
			waypoint.Category = Waypoint._Category.const_1;
			if (class85_0.CruiseAtOptimumAltitude)
			{
				Waypoint waypoint2 = waypoint;
				ActiveUnit_AI aircraftAI = aircraft_0.GetAircraftAI();
				bool flag = false;
				waypoint2.DesiredAltitude = new float?(aircraftAI.method_78(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref flag));
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			else if (class85_0.AttackAltitudeIngress == 0f)
			{
				if (class85_0.CruiseAltitudeIngressTerrainFollowing)
				{
					waypoint.SetIsTerrainFollowing(true);
					waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.CruiseAltitudeIngress);
					float_0 = 0f;
					float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
					bool_0 = waypoint.IsTerrainFollowing();
				}
				else
				{
					waypoint.DesiredAltitude = new float?(class85_0.CruiseAltitudeIngress);
					float_0 = waypoint.DesiredAltitude.Value;
					float_1 = 0f;
					bool_0 = false;
				}
			}
			else if (class85_0.AttackAltitudeIngressTerrainFollowing)
			{
				waypoint.SetIsTerrainFollowing(true);
				waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.AttackAltitudeIngress);
				float_0 = 0f;
				float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
				bool_0 = waypoint.IsTerrainFollowing();
			}
			else
			{
				waypoint.DesiredAltitude = new float?(class85_0.AttackAltitudeIngress);
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			if (class85_0.AttackThrottleSetting != ActiveUnit.Throttle.FullStop)
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.AttackThrottleSetting);
			}
			else
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.CruiseThrottleSettingIngress);
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				enum6_0 = waypoint.GetThrottlePreset();
			}
			else if (!Information.IsNothing(enum6_0) && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.None && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.FullStop)
			{
				waypoint.SetThrottlePreset(enum6_0);
			}
			else
			{
				waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
				enum6_0 = waypoint.GetThrottlePreset();
			}
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_2 = waypoint.DesiredSpeed.Value;
			}
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			waypoint.FlightFormation = Waypoint._FlightFormation.Spread;
			Mission._AttackMethod attackMethod = enum65_0;
			if (attackMethod > Mission._AttackMethod.const_1)
			{
				if (attackMethod - Mission._AttackMethod.const_2 <= 2)
				{
					enum53_0 = Waypoint._FlightFormation.Split;
				}
			}
			else
			{
				enum53_0 = Waypoint._FlightFormation.Spread;
			}
			waypoint.SetDAO(true);
			if (!Information.IsNothing(enum63_0) && enum63_0 == Mission._RadarBehaviour.Maritime)
			{
				waypoint.m_Doctrine.method_174(Doctrine.EMCON_Settings.Enum36.const_1, Doctrine.EMCON_Settings.Enum36.const_3, Doctrine.EMCON_Settings.Enum36.const_3);
			}
			if (Information.IsNothing(waypoint_0))
			{
				ScenarioArrayUtil.AddWaypoint(ref waypoint_1, waypoint);
			}
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x003B867C File Offset: 0x003B687C
		private static void smethod_24(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, Mission._RadarBehaviour enum63_0, ref float float_0, ref float float_1, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_2, ref Mission._AttackMethod enum65_0, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = Waypoint.WaypointType.StrikeIngress;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(Waypoint.WaypointType.StrikeIngress);
			waypoint.Category = Waypoint._Category.const_1;
			if (class85_0.CruiseAtOptimumAltitude)
			{
				Waypoint waypoint2 = waypoint;
				ActiveUnit_AI aircraftAI = aircraft_0.GetAircraftAI();
				bool flag = false;
				waypoint2.DesiredAltitude = new float?(aircraftAI.method_78(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref flag));
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			else if (class85_0.AttackAltitudeIngress == 0f)
			{
				if (class85_0.CruiseAltitudeIngressTerrainFollowing)
				{
					waypoint.SetIsTerrainFollowing(true);
					waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.CruiseAltitudeIngress);
					float_0 = 0f;
					float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
					bool_0 = waypoint.IsTerrainFollowing();
				}
				else
				{
					waypoint.DesiredAltitude = new float?(class85_0.CruiseAltitudeIngress);
					float_0 = waypoint.DesiredAltitude.Value;
					float_1 = 0f;
					bool_0 = false;
				}
			}
			else if (class85_0.AttackAltitudeIngressTerrainFollowing)
			{
				waypoint.SetIsTerrainFollowing(true);
				waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.AttackAltitudeIngress);
				float_0 = 0f;
				float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
				bool_0 = waypoint.IsTerrainFollowing();
			}
			else
			{
				waypoint.DesiredAltitude = new float?(class85_0.AttackAltitudeIngress);
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			if (class85_0.AttackThrottleSetting != ActiveUnit.Throttle.FullStop)
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.AttackThrottleSetting);
			}
			else
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.CruiseThrottleSettingIngress);
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				enum6_0 = waypoint.GetThrottlePreset();
			}
			else if (!Information.IsNothing(enum6_0) && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.None && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.FullStop)
			{
				waypoint.SetThrottlePreset(enum6_0);
			}
			else
			{
				waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
				enum6_0 = waypoint.GetThrottlePreset();
			}
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_2 = waypoint.DesiredSpeed.Value;
			}
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			waypoint.FlightFormation = enum53_0;
			waypoint.SetDAO(true);
			if (!Information.IsNothing(enum63_0) && enum63_0 == Mission._RadarBehaviour.Maritime)
			{
				waypoint.m_Doctrine.method_174(Doctrine.EMCON_Settings.Enum36.const_1, Doctrine.EMCON_Settings.Enum36.const_3, Doctrine.EMCON_Settings.Enum36.const_3);
			}
			if (Information.IsNothing(waypoint_0))
			{
				ScenarioArrayUtil.AddWaypoint(ref waypoint_1, waypoint);
			}
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x003B89BC File Offset: 0x003B6BBC
		private static void smethod_25(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, Mission._RadarBehaviour enum63_0, float float_0, ref float float_1, ref float float_2, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_3, ref Mission._AttackMethod enum65_0, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint.WaypointType waypointType;
			if (float_0 < 6f)
			{
				waypointType = Waypoint.WaypointType.InitialPoint;
			}
			else
			{
				waypointType = Waypoint.WaypointType.WeaponLaunch;
			}
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, waypointType, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = waypointType;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(waypointType);
			waypoint.Category = Waypoint._Category.const_1;
			if (class85_0.CruiseAtOptimumAltitude)
			{
				Waypoint waypoint2 = waypoint;
				ActiveUnit_AI aircraftAI = aircraft_0.GetAircraftAI();
				bool flag = false;
				waypoint2.DesiredAltitude = new float?(aircraftAI.method_78(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref flag));
				float_1 = waypoint.DesiredAltitude.Value;
				float_2 = 0f;
				bool_0 = false;
			}
			else if (class85_0.AttackAltitudeIngress == 0f)
			{
				if (class85_0.CruiseAltitudeIngressTerrainFollowing)
				{
					waypoint.SetIsTerrainFollowing(true);
					waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.CruiseAltitudeIngress);
					float_1 = 0f;
					float_2 = waypoint.DesiredAltitude_TerrainFollowing.Value;
					bool_0 = waypoint.IsTerrainFollowing();
				}
				else
				{
					waypoint.DesiredAltitude = new float?(class85_0.CruiseAltitudeIngress);
					float_1 = waypoint.DesiredAltitude.Value;
					float_2 = 0f;
					bool_0 = false;
				}
			}
			else if (class85_0.AttackAltitudeIngressTerrainFollowing)
			{
				waypoint.SetIsTerrainFollowing(true);
				waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.AttackAltitudeIngress);
				float_1 = 0f;
				float_2 = waypoint.DesiredAltitude_TerrainFollowing.Value;
				bool_0 = waypoint.IsTerrainFollowing();
			}
			else
			{
				waypoint.DesiredAltitude = new float?(class85_0.AttackAltitudeIngress);
				float_1 = waypoint.DesiredAltitude.Value;
				float_2 = 0f;
				bool_0 = false;
			}
			if (class85_0.AttackThrottleSetting != ActiveUnit.Throttle.FullStop)
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.AttackThrottleSetting);
			}
			else
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.CruiseThrottleSettingIngress);
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				enum6_0 = waypoint.GetThrottlePreset();
			}
			else if (!Information.IsNothing(enum6_0) && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.None && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.FullStop)
			{
				waypoint.SetThrottlePreset(enum6_0);
			}
			else
			{
				waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
				enum6_0 = waypoint.GetThrottlePreset();
			}
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_3 = waypoint.DesiredSpeed.Value;
			}
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			waypoint.FlightFormation = enum53_0;
			waypoint.SetDAO(true);
			if (enum63_0 == Mission._RadarBehaviour.const_2 || enum63_0 == Mission._RadarBehaviour.Maritime)
			{
				waypoint.m_Doctrine.method_174(Doctrine.EMCON_Settings.Enum36.const_1, Doctrine.EMCON_Settings.Enum36.const_3, Doctrine.EMCON_Settings.Enum36.const_3);
			}
			if (Information.IsNothing(waypoint_0))
			{
				ScenarioArrayUtil.AddWaypoint(ref waypoint_1, waypoint);
			}
		}

		// Token: 0x06006B89 RID: 27529 RVA: 0x003B8D04 File Offset: 0x003B6F04
		private static void smethod_26(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, Mission._RadarBehaviour enum63_0, float float_0, ref float float_1, ref float float_2, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_3, ref Mission._AttackMethod enum65_0, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint.WaypointType waypointType;
			if (float_0 < 6f)
			{
				waypointType = Waypoint.WaypointType.Target;
			}
			else
			{
				waypointType = Waypoint.WaypointType.WeaponTarget;
			}
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, waypointType, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = waypointType;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(waypointType);
			waypoint.Category = Waypoint._Category.const_1;
			if (class85_0.CruiseAtOptimumAltitude)
			{
				Waypoint waypoint2 = waypoint;
				ActiveUnit_AI aircraftAI = aircraft_0.GetAircraftAI();
				bool flag = false;
				waypoint2.DesiredAltitude = new float?(aircraftAI.method_78(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref flag));
				float_1 = waypoint.DesiredAltitude.Value;
				float_2 = 0f;
				bool_0 = false;
			}
			else if (class85_0.AttackAltitudeEgress == 0f)
			{
				if (class85_0.CruiseAltitudeEgressTerrainFollowing)
				{
					waypoint.SetIsTerrainFollowing(true);
					waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.CruiseAltitudeEgress);
					float_1 = 0f;
					float_2 = waypoint.DesiredAltitude_TerrainFollowing.Value;
					bool_0 = waypoint.IsTerrainFollowing();
				}
				else
				{
					waypoint.DesiredAltitude = new float?(class85_0.CruiseAltitudeEgress);
					float_1 = waypoint.DesiredAltitude.Value;
					float_2 = 0f;
					bool_0 = false;
				}
			}
			else if (class85_0.AttackAltitudeEgressTerrainFollowing)
			{
				waypoint.SetIsTerrainFollowing(true);
				waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.AttackAltitudeEgress);
				float_1 = 0f;
				float_2 = waypoint.DesiredAltitude_TerrainFollowing.Value;
				bool_0 = waypoint.IsTerrainFollowing();
			}
			else
			{
				waypoint.DesiredAltitude = new float?(class85_0.AttackAltitudeEgress);
				float_1 = waypoint.DesiredAltitude.Value;
				float_2 = 0f;
				bool_0 = false;
			}
			if (class85_0.AttackThrottleSetting != ActiveUnit.Throttle.FullStop)
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.AttackThrottleSetting);
			}
			else
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.CruiseThrottleSettingIngress);
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				enum6_0 = waypoint.GetThrottlePreset();
			}
			else if (!Information.IsNothing(enum6_0) && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.None && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.FullStop)
			{
				waypoint.SetThrottlePreset(enum6_0);
			}
			else
			{
				waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
				enum6_0 = waypoint.GetThrottlePreset();
			}
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_3 = waypoint.DesiredSpeed.Value;
			}
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			waypoint.FlightFormation = enum53_0;
			waypoint.SetDAO(true);
			if (enum63_0 == Mission._RadarBehaviour.const_2 || enum63_0 == Mission._RadarBehaviour.Maritime)
			{
				waypoint.m_Doctrine.SetEMCON_Settings(true);
			}
			if (Information.IsNothing(waypoint_0))
			{
				ScenarioArrayUtil.AddWaypoint(ref waypoint_1, waypoint);
			}
		}

		// Token: 0x06006B8A RID: 27530 RVA: 0x003B904C File Offset: 0x003B724C
		private static void smethod_27(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, ref float float_0, ref float float_1, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_2, ref Mission._AttackMethod enum65_0, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, Waypoint.WaypointType.StrikeEgress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = Waypoint.WaypointType.StrikeEgress;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(Waypoint.WaypointType.StrikeEgress);
			waypoint.Category = Waypoint._Category.const_1;
			if (class85_0.CruiseAtOptimumAltitude)
			{
				Waypoint waypoint2 = waypoint;
				ActiveUnit_AI aircraftAI = aircraft_0.GetAircraftAI();
				bool flag = false;
				waypoint2.DesiredAltitude = new float?(aircraftAI.method_78(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref flag));
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			else if (class85_0.AttackAltitudeEgress == 0f)
			{
				if (class85_0.CruiseAltitudeEgressTerrainFollowing)
				{
					waypoint.SetIsTerrainFollowing(true);
					waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.CruiseAltitudeEgress);
					float_0 = 0f;
					float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
					bool_0 = waypoint.IsTerrainFollowing();
				}
				else
				{
					waypoint.DesiredAltitude = new float?(class85_0.CruiseAltitudeEgress);
					float_0 = waypoint.DesiredAltitude.Value;
					float_1 = 0f;
					bool_0 = false;
				}
			}
			else if (class85_0.AttackAltitudeEgressTerrainFollowing)
			{
				waypoint.SetIsTerrainFollowing(true);
				waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.AttackAltitudeEgress);
				float_0 = 0f;
				float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
				bool_0 = waypoint.IsTerrainFollowing();
			}
			else
			{
				waypoint.DesiredAltitude = new float?(class85_0.AttackAltitudeEgress);
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			if (class85_0.AttackThrottleSetting != ActiveUnit.Throttle.FullStop)
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.AttackThrottleSetting);
			}
			else
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.CruiseThrottleSettingIngress);
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				enum6_0 = waypoint.GetThrottlePreset();
			}
			else if (!Information.IsNothing(enum6_0) && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.None && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.FullStop)
			{
				waypoint.SetThrottlePreset(enum6_0);
			}
			else
			{
				waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
				enum6_0 = waypoint.GetThrottlePreset();
			}
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_2 = waypoint.DesiredSpeed.Value;
			}
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			waypoint.FlightFormation = Waypoint._FlightFormation.Spread;
			enum53_0 = waypoint.FlightFormation;
			waypoint.SetDAO(true);
			if (Information.IsNothing(waypoint_0))
			{
				ScenarioArrayUtil.AddWaypoint(ref waypoint_1, waypoint);
			}
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x003B9368 File Offset: 0x003B7568
		private static void smethod_28(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, ref float float_0, ref float float_1, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_2, ref Mission._AttackMethod enum65_0, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, Waypoint.WaypointType.StrikeEgress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = Waypoint.WaypointType.StrikeEgress;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(Waypoint.WaypointType.StrikeEgress);
			waypoint.Category = Waypoint._Category.const_1;
			if (class85_0.CruiseAtOptimumAltitude)
			{
				Waypoint waypoint2 = waypoint;
				ActiveUnit_AI aircraftAI = aircraft_0.GetAircraftAI();
				bool flag = false;
				waypoint2.DesiredAltitude = new float?(aircraftAI.method_78(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref flag));
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			else if (class85_0.AttackAltitudeEgress == 0f)
			{
				if (class85_0.CruiseAltitudeEgressTerrainFollowing)
				{
					waypoint.SetIsTerrainFollowing(true);
					waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.CruiseAltitudeEgress);
					float_0 = 0f;
					float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
					bool_0 = waypoint.IsTerrainFollowing();
				}
				else
				{
					waypoint.DesiredAltitude = new float?(class85_0.CruiseAltitudeEgress);
					float_0 = waypoint.DesiredAltitude.Value;
					float_1 = 0f;
					bool_0 = false;
				}
			}
			else if (class85_0.AttackAltitudeEgressTerrainFollowing)
			{
				waypoint.SetIsTerrainFollowing(true);
				waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.AttackAltitudeEgress);
				float_0 = 0f;
				float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
				bool_0 = waypoint.IsTerrainFollowing();
			}
			else
			{
				waypoint.DesiredAltitude = new float?(class85_0.AttackAltitudeEgress);
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			if (class85_0.AttackThrottleSetting != ActiveUnit.Throttle.FullStop)
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.AttackThrottleSetting);
			}
			else
			{
				waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.CruiseThrottleSettingIngress);
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				enum6_0 = waypoint.GetThrottlePreset();
			}
			else if (!Information.IsNothing(enum6_0) && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.None && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.FullStop)
			{
				waypoint.SetThrottlePreset(enum6_0);
			}
			else
			{
				waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
				enum6_0 = waypoint.GetThrottlePreset();
			}
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_2 = waypoint.DesiredSpeed.Value;
			}
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			waypoint.FlightFormation = enum53_0;
			waypoint.SetDAO(true);
			if (Information.IsNothing(waypoint_0))
			{
				ScenarioArrayUtil.AddWaypoint(ref waypoint_1, waypoint);
			}
		}

		// Token: 0x06006B8C RID: 27532 RVA: 0x003B9680 File Offset: 0x003B7880
		private static void smethod_29(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, ref float float_0, ref float float_1, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_2, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, Waypoint.WaypointType.LandingMarshal, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = Waypoint.WaypointType.LandingMarshal;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(Waypoint.WaypointType.LandingMarshal);
			waypoint.Category = Waypoint._Category.const_1;
			if (class85_0.CruiseAtOptimumAltitude)
			{
				Waypoint waypoint2 = waypoint;
				ActiveUnit_AI aircraftAI = aircraft_0.GetAircraftAI();
				bool flag = false;
				waypoint2.DesiredAltitude = new float?(aircraftAI.method_78(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref flag));
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			else if (class85_0.CruiseAltitudeEgressTerrainFollowing)
			{
				waypoint.SetIsTerrainFollowing(true);
				waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.CruiseAltitudeEgress);
				float_0 = 0f;
				float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
				bool_0 = waypoint.IsTerrainFollowing();
			}
			else
			{
				waypoint.DesiredAltitude = new float?(class85_0.CruiseAltitudeEgress);
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.CruiseThrottleSettingEgress);
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				enum6_0 = waypoint.GetThrottlePreset();
			}
			else if (!Information.IsNothing(enum6_0) && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.None && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.FullStop)
			{
				waypoint.SetThrottlePreset(enum6_0);
			}
			else
			{
				waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
				enum6_0 = waypoint.GetThrottlePreset();
			}
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_2 = waypoint.DesiredSpeed.Value;
			}
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			waypoint.FlightFormation = enum53_0;
			waypoint.SetDAO(true);
			if (Information.IsNothing(waypoint_0))
			{
				ScenarioArrayUtil.AddWaypoint(ref waypoint_1, waypoint);
			}
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x003B98F0 File Offset: 0x003B7AF0
		private static void smethod_30(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, ref float float_0, ref float float_1, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_2, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, Waypoint.WaypointType.TakeOff, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = Waypoint.WaypointType.TakeOff;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(Waypoint.WaypointType.TakeOff);
			waypoint.Category = Waypoint._Category.const_1;
			waypoint.DesiredAltitude = new float?(aircraft_0.GetAircraftAI().method_77(ref aircraft_0, ref double_0, ref double_1));
			float_0 = waypoint.DesiredAltitude.Value;
			float_1 = 0f;
			bool_0 = false;
			waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Loiter);
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_2 = waypoint.DesiredSpeed.Value;
			}
			waypoint.SetDAO(true);
			enum6_0 = waypoint.GetThrottlePreset();
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (waypoint.GetThrottlePreset() == ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			waypoint.FlightFormation = enum53_0;
			if (Information.IsNothing(waypoint_0))
			{
				ActiveUnit_Navigator.InsertWayPoint(ref waypoint_1, 0, waypoint);
			}
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x003B9A5C File Offset: 0x003B7C5C
		private static void smethod_31(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, ref float float_0, ref float float_1, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_2, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, Waypoint.WaypointType.Land, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = Waypoint.WaypointType.Land;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(Waypoint.WaypointType.Land);
			waypoint.Category = Waypoint._Category.const_1;
			waypoint.DesiredAltitude = new float?((float)Terrain.GetElevation(waypoint.GetLatitude(), waypoint.GetLongitude(), false));
			float? desiredAltitude = waypoint.DesiredAltitude;
			if ((desiredAltitude.HasValue ? new bool?(desiredAltitude.GetValueOrDefault() < 0f) : null).GetValueOrDefault())
			{
				waypoint.DesiredAltitude = new float?(0f);
			}
			waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Loiter);
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_2 = waypoint.DesiredSpeed.Value;
			}
			waypoint.SetDAO(true);
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (waypoint.GetThrottlePreset() == ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			waypoint.FlightFormation = enum53_0;
			if (Information.IsNothing(waypoint_0))
			{
				ScenarioArrayUtil.AddWaypoint(ref waypoint_1, waypoint);
			}
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x003B9BF4 File Offset: 0x003B7DF4
		private static void smethod_32(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, Mission._RadarBehaviour enum63_0, ref float float_0, ref float float_1, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_2, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, Waypoint.WaypointType.StrikeIngress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = Waypoint.WaypointType.StrikeIngress;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(Waypoint.WaypointType.StrikeIngress);
			waypoint.Category = Waypoint._Category.const_1;
			if (class85_0.CruiseAtOptimumAltitude)
			{
				Waypoint waypoint2 = waypoint;
				ActiveUnit_AI aircraftAI = aircraft_0.GetAircraftAI();
				bool flag = false;
				waypoint2.DesiredAltitude = new float?(aircraftAI.method_78(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref flag));
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			else if (class85_0.CruiseAltitudeIngressTerrainFollowing)
			{
				waypoint.SetIsTerrainFollowing(true);
				waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.CruiseAltitudeIngress);
				float_0 = 0f;
				float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
				bool_0 = waypoint.IsTerrainFollowing();
			}
			else
			{
				waypoint.DesiredAltitude = new float?(class85_0.CruiseAltitudeIngress);
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.CruiseThrottleSettingIngress);
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				enum6_0 = waypoint.GetThrottlePreset();
			}
			else if (!Information.IsNothing(enum6_0) && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.None && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.FullStop)
			{
				waypoint.SetThrottlePreset(enum6_0);
			}
			else
			{
				waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
				enum6_0 = waypoint.GetThrottlePreset();
			}
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_2 = waypoint.DesiredSpeed.Value;
			}
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			waypoint.FlightFormation = enum53_0;
			waypoint.SetDAO(true);
			if (!Information.IsNothing(enum63_0) && enum63_0 == Mission._RadarBehaviour.Maritime)
			{
				waypoint.m_Doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_1, aircraft_0.m_Scenario);
			}
			if (Information.IsNothing(waypoint_0))
			{
				ScenarioArrayUtil.AddWaypoint(ref waypoint_1, waypoint);
			}
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x003B9E90 File Offset: 0x003B8090
		private static void smethod_33(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, ref float float_0, ref float float_1, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_2, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, Waypoint.WaypointType.StrikeEgress, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = Waypoint.WaypointType.StrikeEgress;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(Waypoint.WaypointType.StrikeEgress);
			waypoint.Category = Waypoint._Category.const_1;
			if (class85_0.CruiseAtOptimumAltitude)
			{
				Waypoint waypoint2 = waypoint;
				ActiveUnit_AI aircraftAI = aircraft_0.GetAircraftAI();
				bool flag = false;
				waypoint2.DesiredAltitude = new float?(aircraftAI.method_78(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref flag));
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			else if (class85_0.CruiseAltitudeEgressTerrainFollowing)
			{
				waypoint.SetIsTerrainFollowing(true);
				waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.CruiseAltitudeEgress);
				float_0 = 0f;
				float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
				bool_0 = waypoint.IsTerrainFollowing();
			}
			else
			{
				waypoint.DesiredAltitude = new float?(class85_0.CruiseAltitudeEgress);
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			waypoint.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)class85_0.CruiseThrottleSettingEgress);
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				enum6_0 = waypoint.GetThrottlePreset();
			}
			else if (!Information.IsNothing(enum6_0) && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.None && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.FullStop)
			{
				waypoint.SetThrottlePreset(enum6_0);
			}
			else
			{
				waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
				enum6_0 = waypoint.GetThrottlePreset();
			}
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_2 = waypoint.DesiredSpeed.Value;
			}
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			waypoint.FlightFormation = enum53_0;
			waypoint.SetDAO(true);
			if (Information.IsNothing(waypoint_0))
			{
				ScenarioArrayUtil.AddWaypoint(ref waypoint_1, waypoint);
			}
		}

		// Token: 0x06006B91 RID: 27537 RVA: 0x003BA100 File Offset: 0x003B8300
		private static void smethod_34(Waypoint waypoint_0, Aircraft aircraft_0, ref Waypoint[] waypoint_1, double double_0, double double_1, LoadoutMissionProfile class85_0, ref float float_0, ref float float_1, ref bool bool_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref float float_2, ref Waypoint._FlightFormation enum53_0)
		{
			Waypoint waypoint;
			if (Information.IsNothing(waypoint_0))
			{
				waypoint = new Waypoint(double_1, double_0, Waypoint.WaypointType.TurningPoint, Waypoint._Creator.const_3, Waypoint._Category.const_1);
			}
			else
			{
				waypoint = waypoint_0;
				waypoint.waypointType = Waypoint.WaypointType.TurningPoint;
			}
			waypoint.Name = Waypoint.GetWaypointTypeString(Waypoint.WaypointType.TurningPoint);
			waypoint.Category = Waypoint._Category.const_1;
			if (class85_0.CruiseAtOptimumAltitude)
			{
				Waypoint waypoint2 = waypoint;
				ActiveUnit_AI aircraftAI = aircraft_0.GetAircraftAI();
				bool flag = false;
				waypoint2.DesiredAltitude = new float?(aircraftAI.method_78(ref aircraft_0, ActiveUnit.Throttle.Cruise, ref flag));
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			else if (class85_0.CruiseAltitudeIngressTerrainFollowing)
			{
				waypoint.SetIsTerrainFollowing(true);
				waypoint.DesiredAltitude_TerrainFollowing = new float?(class85_0.CruiseAltitudeIngress);
				float_0 = 0f;
				float_1 = waypoint.DesiredAltitude_TerrainFollowing.Value;
				bool_0 = waypoint.IsTerrainFollowing();
			}
			else
			{
				waypoint.DesiredAltitude = new float?(class85_0.CruiseAltitudeIngress);
				float_0 = waypoint.DesiredAltitude.Value;
				float_1 = 0f;
				bool_0 = false;
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				enum6_0 = waypoint.GetThrottlePreset();
			}
			else if (!Information.IsNothing(enum6_0) && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.None && enum6_0 != ActiveUnit_Kinematics._SpeedPreset.FullStop)
			{
				waypoint.SetThrottlePreset(enum6_0);
			}
			else
			{
				waypoint.SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset.Cruise);
				enum6_0 = waypoint.GetThrottlePreset();
			}
			if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude_TerrainFollowing.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			else
			{
				waypoint.DesiredSpeed = new float?((float)aircraft_0.GetAircraftKinematics().GetSpeed(waypoint.DesiredAltitude.Value, (ActiveUnit.Throttle)waypoint.GetThrottlePreset()));
			}
			if (!Information.IsNothing(waypoint.DesiredSpeed))
			{
				float_2 = waypoint.DesiredSpeed.Value;
			}
			if (Information.IsNothing(waypoint.ArrivalTime_Zulu))
			{
				waypoint.TimeFixed = Waypoint.Enum52.const_3;
			}
			if (!Information.IsNothing(waypoint.GetThrottlePreset()) && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None && waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.Cruise)
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_1;
			}
			else
			{
				waypoint.SpeedFixed = Waypoint.Enum52.const_0;
			}
			waypoint.FlightFormation = enum53_0;
			waypoint.SetDAO(true);
			if (Information.IsNothing(waypoint_0))
			{
				ScenarioArrayUtil.AddWaypoint(ref waypoint_1, waypoint);
			}
		}

		// Token: 0x06006B92 RID: 27538 RVA: 0x003BA360 File Offset: 0x003B8560
		public static void smethod_35(ref Scenario scenario_0, ref Side side_0, ref ActiveUnit activeUnit_0)
		{
			checked
			{
				try
				{
					if (!Information.IsNothing(side_0.GetMissionCollection()))
					{
						foreach (Mission current in side_0.GetPatrolMissionCollection(scenario_0))
						{
							if (!Information.IsNothing(current) && current.MissionClass == Mission._MissionClass.Strike && current.GetMissionStatus(scenario_0) == Mission._MissionStatus.Activation)
							{
								Strike strike = (Strike)current;
                                ActiveUnit current2X;

                                foreach (ActiveUnit current2 in scenario_0.GetActiveUnitList())
								{
									if (current2.IsAircraft && current2.GetAssignedMission(false) == current && (current2.IsGroupLead() || !current2.HasParentGroup()) && current2.GetNavigator().GetPlottedCourse().Count<Waypoint>() > 0)
									{
										Aircraft aircraft = (Aircraft)current2;
										Aircraft_AirOps aircraftAirOps = aircraft.GetAircraftAirOps();
										if (!Information.IsNothing(aircraftAirOps.GetAssignedHostUnit()))
										{
											Waypoint[] plottedCourse = current2.GetNavigator().GetPlottedCourse();
											for (int i = 0; i < plottedCourse.Length; i++)
											{
												Waypoint waypoint = plottedCourse[i];
												if (waypoint.waypointType == Waypoint.WaypointType.LandingMarshal)
												{
													GeoPoint geoPoint;
													if (!aircraft.IsRotaryWingAircraft())
													{
														geoPoint = aircraftAirOps.GetAssignedHostUnit().GetAirOps().method_5();
													}
													else
													{
														geoPoint = new GeoPoint(aircraftAirOps.GetAssignedHostUnit().GetLongitude(null), aircraftAirOps.GetAssignedHostUnit().GetLatitude(null));
													}
													waypoint.SetLatitude(geoPoint.GetLatitude());
													waypoint.SetLongitude(geoPoint.GetLongitude());
													break;
												}
											}
										}
										if (current2.GetNavigator().GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.Assemble && current2.GetNavigator().GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.StrikeIngress && current2.GetNavigator().GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.PathfindingPoint)
										{
											Waypoint waypoint2 = null;
											Waypoint waypoint3 = null;
											bool flag = false;
											List<Waypoint> list = new List<Waypoint>();
											Waypoint[] plottedCourse2 = current2.GetNavigator().GetPlottedCourse();
											int j = 0;
											float num = 0f;
											while (j < plottedCourse2.Length)
											{
												Waypoint waypoint4 = plottedCourse2[j];
												if (waypoint4.waypointType == Waypoint.WaypointType.StrikeIngress || waypoint4.waypointType == Waypoint.WaypointType.Split)
												{
													waypoint3 = waypoint4;
												}
												if (waypoint4.waypointType != Waypoint.WaypointType.InitialPoint && waypoint4.waypointType != Waypoint.WaypointType.WeaponLaunch)
												{
													goto IL_40A;
												}
												if (!Information.IsNothing(activeUnit_0))
												{
                                                    //ZSP ERE if (!Information.IsNothing(current2.GetAI().GetPrimaryTarget()) && activeUnit_0 != current2.GetAI().GetPrimaryTarget())
                                                    if (!Information.IsNothing(current2.GetAI().GetPrimaryTarget()) && activeUnit_0 != current2)
                                                    {
														goto IL_7C3;
													}
                                                    current2X = current2;

                                                    StrikePlanner.smethod_36(ref current2X, waypoint4, ref list);
													flag = true;
												}
												num = 0f;
												if (!Information.IsNothing(current2.GetAI().GetPrimaryTarget()))
												{
													if (current2.GetNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.InitialPoint || current2.GetNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.WeaponLaunch)
													{
														if (Information.IsNothing(aircraft.GetAircraftWeaponry().method_19(current2.GetAI().GetPrimaryTarget(), false, true, aircraft.m_Doctrine)))
														{
															goto IL_7C3;
														}
														num = Math2.GetDistance(current2.GetNavigator().GetPlottedCourse()[0].GetLatitude(), current2.GetNavigator().GetPlottedCourse()[0].GetLongitude(), current2.GetAI().GetPrimaryTarget().GetLatitude(null), current2.GetAI().GetPrimaryTarget().GetLongitude(null));
														float distance = Math2.GetDistance(current2.GetLatitude(null), current2.GetLongitude(null), current2.GetAI().GetPrimaryTarget().GetLatitude(null), current2.GetAI().GetPrimaryTarget().GetLongitude(null));
														if (num > distance)
														{
															current2.GetNavigator().method_27(waypoint4);
															current2.GetNavigator().method_28(waypoint4);
															list.Add(waypoint4);
														}
													}
													waypoint2 = waypoint4;
													goto IL_40A;
												}
												waypoint2 = waypoint4;
												goto IL_40A;
												IL_7C3:
												j++;
												continue;
												IL_40A:
												if (waypoint4.waypointType != Waypoint.WaypointType.Target && waypoint4.waypointType != Waypoint.WaypointType.WeaponTarget)
												{
													goto IL_7C3;
												}
												if (!flag && !Information.IsNothing(activeUnit_0))
												{
                                                    //ZSP ERR if (!Information.IsNothing(current2.GetAI().GetPrimaryTarget()) && activeUnit_0 != current2.GetAI().GetPrimaryTarget())
                                                    if (!Information.IsNothing(current2.GetAI().GetPrimaryTarget()) && activeUnit_0 != current2)
                                                    {
														goto IL_7C3;
													}
                                                    current2X = current2;

                                                    StrikePlanner.smethod_36(ref current2X, waypoint4, ref list);
												}
												if (!Information.IsNothing(current2.GetAI().GetPrimaryTarget()))
												{
													if (waypoint4.GetLatitude() == current2.GetAI().GetPrimaryTarget().GetLatitude(null) && waypoint4.GetLongitude() == current2.GetAI().GetPrimaryTarget().GetLongitude(null))
													{
														goto IL_7C3;
													}
													waypoint4.SetLatitude(current2.GetAI().GetPrimaryTarget().GetLatitude(null));
													waypoint4.SetLongitude(current2.GetAI().GetPrimaryTarget().GetLongitude(null));
													if (!Information.IsNothing(waypoint2) && Math2.GetDistance(waypoint2.GetLatitude(), waypoint2.GetLongitude(), current2.GetLatitude(null), current2.GetLongitude(null)) > 5f)
													{
														float azimuth;
														if (!Information.IsNothing(waypoint3))
														{
															azimuth = Math2.GetAzimuth(waypoint4.GetLatitude(), waypoint4.GetLongitude(), waypoint3.GetLatitude(), waypoint3.GetLongitude());
														}
														else
														{
															azimuth = Math2.GetAzimuth(waypoint4.GetLatitude(), waypoint4.GetLongitude(), current2.GetLatitude(null), current2.GetLongitude(null));
														}
														double num2 = 0.0;
														double num3 = 0.0;
														GeoPointGenerator.GetOtherGeoPoint(waypoint4.GetLongitude(), waypoint4.GetLatitude(), ref num2, ref num3, (double)num, (double)azimuth);
														if (waypoint4.Creator == Waypoint._Creator.const_0)
														{
															double latitude;
															double longitude;
															if (waypoint4 == current2.GetNavigator().GetPlottedCourse()[0])
															{
																latitude = current2.GetLatitude(null);
																longitude = current2.GetLongitude(null);
															}
															else
															{
																int num4 = unchecked(Array.IndexOf<Waypoint>(current2.GetNavigator().GetPlottedCourse(), waypoint4) - 1);
																latitude = current2.GetNavigator().GetPlottedCourse()[num4].GetLatitude();
																longitude = current2.GetNavigator().GetPlottedCourse()[num4].GetLongitude();
															}
															if (current2.GetNavigator().vmethod_16(num3, num2, latitude, longitude, true, 0f, false, null) || current2.GetNavigator().vmethod_16(num3, num2, current2.GetAI().GetPrimaryTarget().GetLatitude(null), current2.GetAI().GetPrimaryTarget().GetLongitude(null), true, 0f, false, null))
															{
																goto IL_7C3;
															}
														}
														waypoint2.SetLatitude(num3);
														waypoint2.SetLongitude(num2);
														goto IL_7C3;
													}
													goto IL_7C3;
												}
												else
												{
													if (!strike.PrePlannedOnly || strike.SpecificTargets.Count != 0)
													{
														goto IL_7C3;
													}
													if (!Information.IsNothing(waypoint2))
													{
														waypoint4.SetLatitude(waypoint2.GetLatitude());
														waypoint4.SetLongitude(waypoint2.GetLongitude());
														goto IL_7C3;
													}
													waypoint4.SetLatitude(current2.GetLatitude(null));
													waypoint4.SetLongitude(current2.GetLongitude(null));
													goto IL_7C3;
												}
											}
											foreach (Waypoint current3 in list)
											{
												if (current3.waypointType == Waypoint.WaypointType.InitialPoint || current3.waypointType == Waypoint.WaypointType.WeaponLaunch)
												{
													((Aircraft_Navigator)current2.GetNavigator()).method_56();
												}
												else if (current3.waypointType == Waypoint.WaypointType.Target || current3.waypointType == Waypoint.WaypointType.WeaponTarget)
												{
													((Aircraft_Navigator)current2.GetNavigator()).vmethod_5();
												}
												current2.GetNavigator().RemoveWaypoint(current3, false);
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
					ex2.Data.Add("Error at 101247", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x0002DFE5 File Offset: 0x0002C1E5
		public static void smethod_36(ref ActiveUnit activeUnit_0, Waypoint waypoint_0, ref List<Waypoint> list_0)
		{
			activeUnit_0.GetAI().SetPrimaryTarget(null);
			activeUnit_0.GetAI().ScheduleNextPrimaryTargetEvent(1, true);
			if (Information.IsNothing(activeUnit_0.GetAI().GetPrimaryTarget()))
			{
				list_0.Add(waypoint_0);
			}
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x003BACC0 File Offset: 0x003B8EC0
		public static void smethod_37(Scenario scenario_, Mission mission_, ref ActiveUnit activeUnit_)
		{
			StrikePlanner.StrikeMission strikeMission = new StrikePlanner.StrikeMission(null);
			strikeMission.theInstance = mission_;
			try
			{
				StrikePlanner.TargetFilter targetFilter = new StrikePlanner.TargetFilter(null);
				targetFilter.strikeMission = strikeMission;
				if (targetFilter.strikeMission.theInstance.MissionClass == Mission._MissionClass.Strike)
				{
					Strike strike = (Strike)targetFilter.strikeMission.theInstance;
					if (strike.strikeType != Strike.StrikeType.Air_Intercept && strike.SpecificTargets.Count != 0)
					{
						Doctrine._UseRefuel? useRefuelDoctrine = targetFilter.strikeMission.theInstance.m_Doctrine.GetUseRefuelDoctrine(scenario_, false, false, false, false);
						if (!Information.IsNothing(activeUnit_) && activeUnit_.IsAircraft && !activeUnit_.GetAI().IsEscort)
						{
							targetFilter.aircraft = null;
							targetFilter.aircraft = (Aircraft)activeUnit_;
							byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
							bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
							if (!(flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault() || (!targetFilter.aircraft.ProbeRefuelling && !targetFilter.aircraft.BoomRefuelling))
							{
								bool flag2 = true;
								targetFilter.ShootTouristsDoc = targetFilter.aircraft.m_Doctrine.GetShootTouristsDoctrine(targetFilter.aircraft.m_Scenario, false, false, false);
								List<Contact> list = new List<Contact>();
								list.AddRange(activeUnit_.GetSide(false).GetContactObservableDictionary().Values);
								float weaponRangeMax = targetFilter.aircraft.GetAircraftAI().GetWeaponRangeMax(ref targetFilter.aircraft, ref ((Strike)targetFilter.strikeMission.theInstance).strikeType);
								float num = 0f;
								if (targetFilter.aircraft.GetLoadout().CombatRadius > 0 && targetFilter.aircraft.GetLoadout().TimeOnStation_Minutes == 0)
								{
									num = (float)targetFilter.aircraft.GetLoadout().CombatRadius + weaponRangeMax;
								}
								else
								{
									num = targetFilter.aircraft.GetAircraftKinematics().vmethod_22();
									num += weaponRangeMax;
								}
								if (num > 0f)
								{
									float num2 = 0f;
									if (strike.SpecificTargets.Count > 0)
									{
										List<Contact>.Enumerator enumerator = list.GetEnumerator();
										try
										{
											while (enumerator.MoveNext())
											{
												Contact current = enumerator.Current;
												if (current.IsSpecificTargetForStikeMission(strike) && targetFilter.aircraft.GetAircraftAI().method_23(ref strike, current.GetPostureStance(targetFilter.aircraft.GetSide(false))))
												{
													num2 = activeUnit_.GetHorizontalRange(current);
													if (num2 <= num)
													{
														flag2 = false;
													}
													if (!flag2)
													{
														break;
													}
												}
											}
											goto IL_376;
										}
										finally
										{
											IDisposable disposable = enumerator;
											if (disposable != null)
											{
												disposable.Dispose();
											}
										}
									}
									List<Contact> list2 = list.Where(new Func<Contact, bool>(targetFilter.IsTargetForMyMission)).ToList<Contact>();
									foreach (Contact current2 in list2)
									{
										if (targetFilter.aircraft.GetAircraftAI().method_23(ref strike, current2.GetPostureStance(targetFilter.aircraft.GetSide(false))))
										{
											num2 = activeUnit_.GetHorizontalRange(current2);
											if (num2 <= num)
											{
												flag2 = false;
											}
											if (!flag2)
											{
												break;
											}
										}
									}
									IL_376:
									if (flag2)
									{
										Interaction.MsgBox(string.Concat(new string[]
										{
											"飞机",
											targetFilter.aircraft.Name,
											" 当前处于目标射程之外。与目标距离为",
											Conversions.ToString((int)Math.Round((double)num2)),
											"海里，打击半径为：",
											Conversions.ToString(num),
											"海里. 该作战单元已经分配对您目标的打击任务，但在与目标距离满足武器使用条件或者更换到更远射程的武器挂载之前不能发射武器."
										}), MsgBoxStyle.OkOnly, null);
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
				ex2.Data.Add("Error at 200620", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B95 RID: 27541 RVA: 0x003BB140 File Offset: 0x003B9340
		private static void smethod_38(ref Scenario scenario_0, ref Mission.Flight Flight_, ref Waypoint waypoint_, ref float? DesiredAltitude_, ref float? nullable_2, ref bool? nullable_3, ref float? nullable_4, ref ActiveUnit_Kinematics._SpeedPreset SpeedPreset_1, ref ActiveUnit_Kinematics._SpeedPreset SpeedPreset_2)
		{
			try
			{
				if (waypoint_.IsTerrainFollowing() && !Information.IsNothing(waypoint_.DesiredAltitude_TerrainFollowing))
				{
					DesiredAltitude_ = waypoint_.DesiredAltitude_TerrainFollowing;
				}
				else if (!Information.IsNothing(waypoint_.DesiredAltitude))
				{
					DesiredAltitude_ = waypoint_.DesiredAltitude;
				}
				else
				{
					bool? flag2;
					bool? flag = flag2 = nullable_3;
					if (((!flag.HasValue || flag2.GetValueOrDefault()) ? (flag2 & !Information.IsNothing(nullable_4)) : new bool?(false)).GetValueOrDefault())
					{
						DesiredAltitude_ = nullable_4;
					}
					else if (!Information.IsNothing(nullable_2))
					{
						DesiredAltitude_ = nullable_2;
					}
					else
					{
						DesiredAltitude_ = DesiredAltitude_;
					}
				}
				if (SpeedPreset_1 == ActiveUnit_Kinematics._SpeedPreset.None)
				{
					if (waypoint_.float_1 > 0f && !Information.IsNothing(DesiredAltitude_))
					{
						SpeedPreset_1 = (ActiveUnit_Kinematics._SpeedPreset)Flight_.GetReferenceUnit(scenario_0).GetKinematics().vmethod_38(DesiredAltitude_.Value, waypoint_.float_1);
					}
					else if (!Information.IsNothing(SpeedPreset_2))
					{
						SpeedPreset_1 = SpeedPreset_2;
					}
					else
					{
						SpeedPreset_1 = SpeedPreset_1;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200621", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x003BB2FC File Offset: 0x003B94FC
		private static void smethod_39(ref Scenario scenario_, ref Mission mission_, ref Mission.Flight Flight_, ref Waypoint NextWayPoint, ref Waypoint WayPoint_, int wayPointNo, string string_0)
		{
			try
			{
				if (!Information.IsNothing(WayPoint_) && !Information.IsNothing(NextWayPoint.ArrivalTime_Zulu))
				{
					bool flag = false;
					if (DateTime.Compare(WayPoint_.ArrivalTime_Zulu.Value, NextWayPoint.ArrivalTime_Zulu.Value) > 0)
					{
						scenario_.MissionPlannerErrorList.Add(string.Concat(new string[]
						{
							"ERROR! Mission ",
							mission_.Name,
							", Flight ",
							Flight_.Callsign,
							string_0,
							": Arrival time at Waypoint ",
							Conversions.ToString(wayPointNo),
							" is later than arrival time at Waypoint ",
							Conversions.ToString(wayPointNo + 1),
							". Check locked times and/or speeds."
						}));
						flag = true;
					}
					if (!flag && NextWayPoint.waypointType != Waypoint.WaypointType.TakeOff)
					{
						double totalSeconds = (WayPoint_.ArrivalTime_Zulu.Value.AddSeconds((double)(NextWayPoint.Leg_Time + NextWayPoint.Hold_Time)) - NextWayPoint.ArrivalTime_Zulu.Value).TotalSeconds;
						if (Math.Abs(totalSeconds) > 20.0)
						{
							double num = 0.0;
							double num2 = 0.0;
							if (!Information.IsNothing(NextWayPoint.Leg_Distance) && NextWayPoint.Leg_Distance > 0f && !Information.IsNothing(NextWayPoint.float_11) && NextWayPoint.float_11 > 0f)
							{
								num = (double)(NextWayPoint.Leg_Distance / NextWayPoint.float_11 * 3600f);
								num2 = (double)(NextWayPoint.Leg_Distance / (NextWayPoint.float_11 + 21f) * 3600f);
							}
							if (!Information.IsNothing(NextWayPoint.float_10) && NextWayPoint.float_10 > 0f && !Information.IsNothing(NextWayPoint.float_12) && NextWayPoint.float_12 > 0f)
							{
								num += (double)(NextWayPoint.float_10 / NextWayPoint.float_12 * 3600f);
								num2 += (double)(NextWayPoint.float_10 / (NextWayPoint.float_12 + 21f) * 3600f);
							}
							double num3 = Math.Abs(num - num2);
							if (totalSeconds > num3)
							{
								scenario_.MissionPlannerErrorList.Add(string.Concat(new string[]
								{
									"ERROR! Mission ",
									mission_.Name,
									", Flight ",
									Flight_.Callsign,
									string_0,
									": Arrival at Waypoint ",
									Conversions.ToString(wayPointNo + 1),
									" is later than expected. Check locked times and/or speeds."
								}));
							}
							else if (totalSeconds < -num3)
							{
								scenario_.MissionPlannerErrorList.Add(string.Concat(new string[]
								{
									"ERROR! Mission ",
									mission_.Name,
									", Flight ",
									Flight_.Callsign,
									string_0,
									": Arrival at Waypoint ",
									Conversions.ToString(wayPointNo + 1),
									" is earlier than expected. Check locked times and/or speeds."
								}));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200622", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x003BB694 File Offset: 0x003B9894
		private static void smethod_40(ref Scenario scenario_0, ref Mission mission_0, ref Mission.Flight class168_0, ref Waypoint waypoint_0, ref float? nullable_1, int int_0, string string_0)
		{
			try
			{
				if (!Information.IsNothing(waypoint_0.GetDSO()) && !Information.IsNothing(waypoint_0.DesiredSpeed) && !Information.IsNothing(nullable_1))
				{
					if (waypoint_0.DesiredSpeed.Value < (float)class168_0.GetReferenceUnit(scenario_0).GetKinematics().vmethod_29(nullable_1.Value, ActiveUnit.Throttle.Loiter))
					{
						scenario_0.MissionPlannerErrorList.Add(string.Concat(new string[]
						{
							"ERROR! Mission ",
							mission_0.Name,
							", Flight ",
							class168_0.Callsign,
							string_0,
							": Speed at waypoint ",
							Conversions.ToString(int_0 + 1),
							" is too low (",
							Conversions.ToString(waypoint_0.DesiredSpeed.Value),
							" kt vs ",
							Conversions.ToString(class168_0.GetReferenceUnit(scenario_0).GetKinematics().vmethod_29(nullable_1.Value, ActiveUnit.Throttle.Loiter)),
							" kt)"
						}));
					}
					if (waypoint_0.DesiredSpeed.Value > (float)class168_0.GetReferenceUnit(scenario_0).GetKinematics().GetSpeed(nullable_1.Value, ActiveUnit.Throttle.Flank))
					{
						scenario_0.MissionPlannerErrorList.Add(string.Concat(new string[]
						{
							"ERROR! Mission ",
							mission_0.Name,
							", Flight ",
							class168_0.Callsign,
							string_0,
							": Speed at waypoint ",
							Conversions.ToString(int_0 + 1),
							" is too high (",
							Conversions.ToString(waypoint_0.DesiredSpeed.Value),
							" kt vs ",
							Conversions.ToString(class168_0.GetReferenceUnit(scenario_0).GetKinematics().GetSpeed(nullable_1.Value, ActiveUnit.Throttle.Flank)),
							" kt)"
						}));
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200623", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x003BB8F0 File Offset: 0x003B9AF0
		private static void smethod_41(ref Scenario scenario_0, ref Mission mission_0, ref Mission.Flight class168_0, ref Waypoint waypoint_0, ref float? Altitude_ASL_, ref float? nullable_2, ref ActiveUnit_Kinematics._SpeedPreset enum6_0, ref ActiveUnit_Kinematics._SpeedPreset enum6_1, ref bool? nullable_3, ref float? nullable_4, int int_0, string string_0)
		{
			try
			{
				if (waypoint_0.waypointType != Waypoint.WaypointType.Assemble && waypoint_0.waypointType != Waypoint.WaypointType.Land && waypoint_0.float_1 > 0f && waypoint_0.float_11 > 0f && !Information.IsNothing(Altitude_ASL_) && !Information.IsNothing(enum6_0))
				{
					if (waypoint_0.float_1 != waypoint_0.float_11 && !Information.IsNothing(class168_0.GetReferenceUnit(scenario_0)) && !Information.IsNothing(waypoint_0.Leg_Time))
					{
						float num = waypoint_0.float_1 - waypoint_0.float_11;
						if (Math.Abs(num) > 1f)
						{
							if (num > 0f)
							{
								float num2 = waypoint_0.float_11;
								int num3 = 0;
								do
								{
									float num4 = class168_0.GetReferenceUnit(scenario_0).GetKinematics().vmethod_8((ActiveUnit.Throttle)enum6_0, Altitude_ASL_.Value, num2);
									if (num4 < 1f)
									{
										break;
									}
									num2 += num4;
									num3++;
									if ((float)num3 >= waypoint_0.Leg_Time)
									{
										goto IL_13C;
									}
								}
								while (waypoint_0.float_1 - 1f >= num2);
								goto IL_2D4;
								IL_13C:
								scenario_0.MissionPlannerErrorList.Add(string.Concat(new string[]
								{
									"ERROR! Mission ",
									mission_0.Name,
									", Flight ",
									class168_0.Callsign,
									string_0,
									": Waypoint ",
									Conversions.ToString(int_0),
									" is too close to Waypoint ",
									Conversions.ToString(int_0 + 1),
									". The distance is too short for speed change."
								}));
							}
							else
							{
								float num5 = waypoint_0.float_11;
								int num6 = 0;
								do
								{
									float num7 = class168_0.GetReferenceUnit(scenario_0).GetKinematics().vmethod_8((ActiveUnit.Throttle)enum6_1, Altitude_ASL_.Value, waypoint_0.float_1);
									if ((double)num7 * 1.5 < 1.0)
									{
										break;
									}
									num5 = (float)((double)num5 - (double)num7 * 1.5);
									num6++;
									if ((float)num6 >= waypoint_0.Leg_Time)
									{
										goto IL_256;
									}
								}
								while (waypoint_0.float_1 + 1f <= num5);
								goto IL_2D4;
								IL_256:
								scenario_0.MissionPlannerErrorList.Add(string.Concat(new string[]
								{
									"ERROR! Mission ",
									mission_0.Name,
									", Flight ",
									class168_0.Callsign,
									string_0,
									": Waypoint ",
									Conversions.ToString(int_0),
									" is too close to Waypoint ",
									Conversions.ToString(int_0 + 1),
									". The distance is too short for speed change."
								}));
							}
						}
					}
					IL_2D4:
					if (Altitude_ASL_.Value != nullable_2.Value && !Information.IsNothing(class168_0.GetReferenceUnit(scenario_0)) && !Information.IsNothing(waypoint_0.Leg_Time))
					{
						bool? flag2;
						bool? flag = flag2 = ((!Information.IsNothing(nullable_3)) ? nullable_3 : new bool?(false));
						float num8 = 0f;
						if (((!flag.HasValue || flag2.GetValueOrDefault()) ? (flag2 & !Information.IsNothing(nullable_4)) : new bool?(false)).GetValueOrDefault())
						{
							num8 = Altitude_ASL_.Value - nullable_4.Value;
						}
						else if (!Information.IsNothing(nullable_2))
						{
							num8 = Altitude_ASL_.Value - nullable_2.Value;
						}
						if (Math.Abs(num8) > 1f)
						{
							if (num8 > 0f)
							{
								float climbRate = class168_0.GetReferenceUnit(scenario_0).GetKinematics().GetClimbRate();
								float num9 = num8 / climbRate;
								if (waypoint_0.Leg_Time < num9)
								{
									scenario_0.MissionPlannerErrorList.Add(string.Concat(new string[]
									{
										"ERROR! Mission ",
										mission_0.Name,
										", Flight ",
										class168_0.Callsign,
										string_0,
										": Waypoint ",
										Conversions.ToString(int_0),
										" is too close to Waypoint ",
										Conversions.ToString(int_0 + 1),
										". The distance is too short for altitude change."
									}));
								}
							}
							else
							{
								float num10 = class168_0.GetReferenceUnit(scenario_0).GetKinematics().vmethod_19();
								float num11 = Math.Abs(num8 / num10);
								if (waypoint_0.Leg_Time < num11)
								{
									scenario_0.MissionPlannerErrorList.Add(string.Concat(new string[]
									{
										"ERROR! Mission ",
										mission_0.Name,
										", Flight ",
										class168_0.Callsign,
										string_0,
										": Waypoint ",
										Conversions.ToString(int_0),
										" is too close to Waypoint ",
										Conversions.ToString(int_0 + 1),
										". The distance is too short for altitude change."
									}));
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
				ex2.Data.Add("Error at 200624", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x003BBEA0 File Offset: 0x003BA0A0
		private static void smethod_42(ref Scenario scenario_0, ref Mission mission_0, ref Mission.Flight class168_0, ref Waypoint waypoint_0, ref bool bool_0, string string_0)
		{
			try
			{
				if (!bool_0 && waypoint_0.Leg_FuelRemaining < 0f)
				{
					scenario_0.MissionPlannerErrorList.Add(string.Concat(new string[]
					{
						"ERROR! Mission ",
						mission_0.Name,
						", Flight ",
						class168_0.Callsign,
						string_0,
						": Not enough fuel for flightplan."
					}));
					bool_0 = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200625", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x003BBF64 File Offset: 0x003BA164
		private static void smethod_43(ref Scenario scenario_0, ref Mission.Flight class168_0, ref List<string> list_0)
		{
			if (!Information.IsNothing(scenario_0))
			{
				try
				{
					if (Information.IsNothing(class168_0))
					{
						scenario_0.MissionPlannerErrorList.Clear();
					}
					else
					{
						for (int i = scenario_0.MissionPlannerErrorList.Count - 1; i >= 0; i += -1)
						{
							string text = scenario_0.MissionPlannerErrorList[i];
							if (text.Contains(class168_0.Callsign))
							{
								scenario_0.MissionPlannerErrorList.Remove(text);
							}
						}
					}
					if (!Information.IsNothing(list_0))
					{
						List<string>.Enumerator enumerator = list_0.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								string current = enumerator.Current;
								scenario_0.MissionPlannerErrorList.Add(current);
							}
						}
						finally
						{
							IDisposable disposable = enumerator;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
					}
					Side[] sides = scenario_0.GetSides();
					for (int j = 0; j < sides.Length; j = checked(j + 1))
					{
						Side side = sides[j];
                        Mission current2X;
                        Mission.Flight current3X;
                        foreach (Mission current2 in side.GetMissionCollection())
						{
                            current2X = current2;
                            foreach (Mission.Flight current3 in current2.FlightList)
							{
                                current3X = current3;

                                if (Information.IsNothing(class168_0) || class168_0 == current3)
								{
									int num = current3.GetFlightCourse().Count<Waypoint>();
									bool flag = false;
									bool flag2 = false;
									bool flag3 = false;
									bool flag4 = false;
									bool flag5 = false;
									bool flag6 = false;
									Waypoint waypoint = null;
									Waypoint waypoint2 = null;
									Waypoint waypoint3 = null;
									Waypoint waypoint4 = null;
									Waypoint waypoint5 = null;
									Waypoint waypoint6 = null;
									Waypoint waypoint7 = null;
									Waypoint waypoint8 = null;
									Waypoint waypoint9 = null;
									Waypoint waypoint10 = null;
									Waypoint waypoint11 = null;
									Waypoint waypoint12 = null;
									float? num2 = null;
									float? num3 = null;
									float? num4 = null;
									float? num5 = null;
									float? num6 = null;
									float? num7 = null;
									float? num8 = null;
									float? num9 = null;
									float? num10 = null;
									float? num11 = null;
									float? num12 = null;
									float? num13 = null;
									bool? flag7 = null;
									bool? flag8 = null;
									bool? flag9 = null;
									bool? flag10 = null;
									bool? flag11 = null;
									bool? flag12 = null;
									ActiveUnit_Kinematics._SpeedPreset speedPreset = ActiveUnit_Kinematics._SpeedPreset.None;
									ActiveUnit_Kinematics._SpeedPreset speedPreset2 = ActiveUnit_Kinematics._SpeedPreset.None;
									ActiveUnit_Kinematics._SpeedPreset speedPreset3 = ActiveUnit_Kinematics._SpeedPreset.None;
									ActiveUnit_Kinematics._SpeedPreset speedPreset4 = ActiveUnit_Kinematics._SpeedPreset.None;
									ActiveUnit_Kinematics._SpeedPreset speedPreset5 = ActiveUnit_Kinematics._SpeedPreset.None;
									ActiveUnit_Kinematics._SpeedPreset speedPreset6 = ActiveUnit_Kinematics._SpeedPreset.None;
									int num14 = num - 1;
									for (int k = 0; k <= num14; k++)
									{
										waypoint = current3.GetFlightCourse()[k];
										if (!Information.IsNothing(waypoint.WP_LeadElementWingman))
										{
											waypoint2 = waypoint.WP_LeadElementWingman;
										}
										else
										{
											waypoint2 = null;
										}
										if (!Information.IsNothing(waypoint.WP_SecondElement))
										{
											waypoint3 = waypoint.WP_SecondElement;
										}
										else
										{
											waypoint3 = null;
										}
										if (!Information.IsNothing(waypoint.WP_SecondElementWingman))
										{
											waypoint4 = waypoint.WP_SecondElementWingman;
										}
										else
										{
											waypoint4 = null;
										}
										if (!Information.IsNothing(waypoint.WP_ThirdElement))
										{
											waypoint5 = waypoint.WP_ThirdElement;
										}
										else
										{
											waypoint5 = null;
										}
										if (!Information.IsNothing(waypoint.WP_ThirdElementWingman))
										{
											waypoint6 = waypoint.WP_ThirdElementWingman;
										}
										else
										{
											waypoint6 = null;
										}
										if (waypoint.waypointType == Waypoint.WaypointType.TakeOff && Information.IsNothing(waypoint.DesiredSpeed) && waypoint.GetThrottlePreset() == ActiveUnit_Kinematics._SpeedPreset.None)
										{
											scenario_0.MissionPlannerErrorList.Add(string.Concat(new string[]
											{
												"ERROR! Mission ",
												current2.Name,
												", Flight ",
												current3.Callsign,
												": The take-off waypoint does not have speed settings."
											}));
										}
										float? num15 = null;
										float? num16 = null;
										float? num17 = null;
										float? num18 = null;
										float? num19 = null;
										float? num20 = null;
										ActiveUnit_Kinematics._SpeedPreset throttlePreset = waypoint.GetThrottlePreset();
										ActiveUnit_Kinematics._SpeedPreset speedPreset7 = ActiveUnit_Kinematics._SpeedPreset.None;
										ActiveUnit_Kinematics._SpeedPreset speedPreset8 = ActiveUnit_Kinematics._SpeedPreset.None;
										ActiveUnit_Kinematics._SpeedPreset speedPreset9 = ActiveUnit_Kinematics._SpeedPreset.None;
										ActiveUnit_Kinematics._SpeedPreset speedPreset10 = ActiveUnit_Kinematics._SpeedPreset.None;
										ActiveUnit_Kinematics._SpeedPreset speedPreset11 = ActiveUnit_Kinematics._SpeedPreset.None;
										StrikePlanner.smethod_38(ref scenario_0, ref current3X, ref waypoint, ref num15, ref num2, ref flag7, ref num8, ref throttlePreset, ref speedPreset);
										StrikePlanner.smethod_39(ref scenario_0, ref current2X, ref current3X, ref waypoint, ref waypoint7, k, "");
										StrikePlanner.smethod_40(ref scenario_0, ref current2X, ref current3X, ref waypoint, ref num15, k, "");
										StrikePlanner.smethod_41(ref scenario_0, ref current2X, ref current3X, ref waypoint, ref num15, ref num2, ref throttlePreset, ref speedPreset, ref flag7, ref num8, num, "");
										StrikePlanner.smethod_42(ref scenario_0, ref current2X, ref current3X, ref waypoint, ref flag, "");
										if (!Information.IsNothing(waypoint2))
										{
											speedPreset7 = waypoint2.GetThrottlePreset();
											StrikePlanner.smethod_38(ref scenario_0, ref current3X, ref waypoint2, ref num16, ref num3, ref flag8, ref num9, ref speedPreset7, ref speedPreset2);
											StrikePlanner.smethod_39(ref scenario_0, ref current2X, ref current3X, ref waypoint2, ref waypoint8, k, ", A/C #2");
											StrikePlanner.smethod_40(ref scenario_0, ref current2X, ref current3X, ref waypoint2, ref num16, k, ", A/C #2");
											StrikePlanner.smethod_41(ref scenario_0, ref current2X, ref current3X, ref waypoint2, ref num16, ref num3, ref speedPreset7, ref speedPreset2, ref flag8, ref num9, num, ", A/C #2");
											StrikePlanner.smethod_42(ref scenario_0, ref current2X, ref current3X, ref waypoint2, ref flag2, ", A/C #2");
										}
										if (!Information.IsNothing(waypoint3))
										{
											speedPreset8 = waypoint3.GetThrottlePreset();
											StrikePlanner.smethod_38(ref scenario_0, ref current3X, ref waypoint3, ref num17, ref num4, ref flag9, ref num10, ref speedPreset8, ref speedPreset3);
											StrikePlanner.smethod_39(ref scenario_0, ref current2X, ref current3X, ref waypoint3, ref waypoint9, k, ", A/C #3");
											StrikePlanner.smethod_40(ref scenario_0, ref current2X, ref current3X, ref waypoint3, ref num17, k, ", A/C #3");
											StrikePlanner.smethod_41(ref scenario_0, ref current2X, ref current3X, ref waypoint3, ref num17, ref num4, ref speedPreset8, ref speedPreset3, ref flag9, ref num10, num, ", A/C #3");
											StrikePlanner.smethod_42(ref scenario_0, ref current2X, ref current3X, ref waypoint3, ref flag3, ", A/C #3");
										}
										if (!Information.IsNothing(waypoint4))
										{
											speedPreset9 = waypoint4.GetThrottlePreset();
											StrikePlanner.smethod_38(ref scenario_0, ref current3X, ref waypoint4, ref num18, ref num5, ref flag10, ref num11, ref speedPreset9, ref speedPreset4);
											StrikePlanner.smethod_39(ref scenario_0, ref current2X, ref current3X, ref waypoint4, ref waypoint10, k, ", A/C #4");
											StrikePlanner.smethod_40(ref scenario_0, ref current2X, ref current3X, ref waypoint4, ref num18, k, ", A/C #4");
											StrikePlanner.smethod_41(ref scenario_0, ref current2X, ref current3X, ref waypoint4, ref num18, ref num5, ref speedPreset9, ref speedPreset4, ref flag10, ref num11, num, ", A/C #4");
											StrikePlanner.smethod_42(ref scenario_0, ref current2X, ref current3X, ref waypoint4, ref flag4, ", A/C #4");
										}
										if (!Information.IsNothing(waypoint5))
										{
											speedPreset10 = waypoint5.GetThrottlePreset();
											StrikePlanner.smethod_38(ref scenario_0, ref current3X, ref waypoint5, ref num19, ref num6, ref flag11, ref num12, ref speedPreset10, ref speedPreset5);
											StrikePlanner.smethod_39(ref scenario_0, ref current2X, ref current3X, ref waypoint5, ref waypoint11, k, ", A/C #5");
											StrikePlanner.smethod_40(ref scenario_0, ref current2X, ref current3X, ref waypoint5, ref num19, k, ", A/C #5");
											StrikePlanner.smethod_41(ref scenario_0, ref current2X, ref current3X, ref waypoint5, ref num19, ref num6, ref speedPreset10, ref speedPreset5, ref flag11, ref num12, num, ", A/C #5");
											StrikePlanner.smethod_42(ref scenario_0, ref current2X, ref current3X, ref waypoint5, ref flag5, ", A/C #5");
										}
										if (!Information.IsNothing(waypoint6))
										{
											speedPreset11 = waypoint6.GetThrottlePreset();
											StrikePlanner.smethod_38(ref scenario_0, ref current3X, ref waypoint6, ref num20, ref num7, ref flag12, ref num13, ref speedPreset11, ref speedPreset6);
											StrikePlanner.smethod_39(ref scenario_0, ref current2X, ref current3X, ref waypoint6, ref waypoint12, k, ", A/C #6");
											StrikePlanner.smethod_40(ref scenario_0, ref current2X, ref current3X, ref waypoint6, ref num20, k, ", A/C #6");
											StrikePlanner.smethod_41(ref scenario_0, ref current2X, ref current3X, ref waypoint6, ref num20, ref num7, ref speedPreset11, ref speedPreset6, ref flag12, ref num13, num, ", A/C #6");
											StrikePlanner.smethod_42(ref scenario_0, ref current2X, ref current3X, ref waypoint6, ref flag6, ", A/C #6");
										}
										if (!Information.IsNothing(waypoint))
										{
											waypoint7 = waypoint;
											if (!Information.IsNothing(waypoint.DesiredAltitude))
											{
												num2 = waypoint.DesiredAltitude;
											}
											if (!Information.IsNothing(waypoint.DesiredAltitude_TerrainFollowing))
											{
												num8 = waypoint.DesiredAltitude_TerrainFollowing;
											}
											if (!Information.IsNothing(waypoint.IsTerrainFollowing()))
											{
												flag7 = new bool?(waypoint.IsTerrainFollowing());
											}
											if (waypoint.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
											{
												speedPreset = waypoint.GetThrottlePreset();
											}
											if (!Information.IsNothing(waypoint2))
											{
												waypoint8 = waypoint2;
												if (!Information.IsNothing(waypoint2.DesiredAltitude))
												{
													num3 = waypoint2.DesiredAltitude;
												}
												if (!Information.IsNothing(waypoint2.DesiredAltitude_TerrainFollowing))
												{
													num9 = waypoint2.DesiredAltitude_TerrainFollowing;
												}
												if (!Information.IsNothing(waypoint2.IsTerrainFollowing()))
												{
													flag8 = new bool?(waypoint2.IsTerrainFollowing());
												}
												if (waypoint2.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
												{
													speedPreset2 = waypoint2.GetThrottlePreset();
												}
											}
											else
											{
												waypoint8 = waypoint;
												num3 = num2;
												num9 = num8;
												flag8 = flag7;
												speedPreset2 = speedPreset;
											}
											if (!Information.IsNothing(waypoint3))
											{
												waypoint9 = waypoint3;
												if (!Information.IsNothing(waypoint3.DesiredAltitude))
												{
													num4 = waypoint3.DesiredAltitude;
												}
												if (!Information.IsNothing(waypoint3.DesiredAltitude_TerrainFollowing))
												{
													num10 = waypoint3.DesiredAltitude_TerrainFollowing;
												}
												if (!Information.IsNothing(waypoint3.IsTerrainFollowing()))
												{
													flag9 = new bool?(waypoint3.IsTerrainFollowing());
												}
												if (waypoint3.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
												{
													speedPreset3 = waypoint3.GetThrottlePreset();
												}
											}
											else
											{
												waypoint9 = waypoint;
												num4 = num2;
												num10 = num8;
												flag9 = flag7;
												speedPreset3 = speedPreset;
											}
											if (!Information.IsNothing(waypoint4))
											{
												waypoint10 = waypoint4;
												if (!Information.IsNothing(waypoint4.DesiredAltitude))
												{
													num5 = waypoint4.DesiredAltitude;
												}
												if (!Information.IsNothing(waypoint4.DesiredAltitude_TerrainFollowing))
												{
													num11 = waypoint4.DesiredAltitude_TerrainFollowing;
												}
												if (!Information.IsNothing(waypoint4.IsTerrainFollowing()))
												{
													flag10 = new bool?(waypoint4.IsTerrainFollowing());
												}
												if (waypoint4.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
												{
													speedPreset4 = waypoint4.GetThrottlePreset();
												}
											}
											else
											{
												waypoint10 = waypoint;
												num5 = num2;
												num11 = num8;
												flag10 = flag7;
												speedPreset4 = speedPreset;
											}
											if (!Information.IsNothing(waypoint5))
											{
												waypoint11 = waypoint5;
												if (!Information.IsNothing(waypoint5.DesiredAltitude))
												{
													num6 = waypoint5.DesiredAltitude;
												}
												if (!Information.IsNothing(waypoint5.DesiredAltitude_TerrainFollowing))
												{
													num12 = waypoint5.DesiredAltitude_TerrainFollowing;
												}
												if (!Information.IsNothing(waypoint5.IsTerrainFollowing()))
												{
													flag11 = new bool?(waypoint5.IsTerrainFollowing());
												}
												if (waypoint5.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
												{
													speedPreset5 = waypoint5.GetThrottlePreset();
												}
											}
											else
											{
												waypoint11 = waypoint;
												num6 = num2;
												num12 = num8;
												flag11 = flag7;
												speedPreset5 = speedPreset;
											}
											if (!Information.IsNothing(waypoint6))
											{
												waypoint12 = waypoint6;
												if (!Information.IsNothing(waypoint6.DesiredAltitude))
												{
													num7 = waypoint6.DesiredAltitude;
												}
												if (!Information.IsNothing(waypoint6.DesiredAltitude_TerrainFollowing))
												{
													num13 = waypoint6.DesiredAltitude_TerrainFollowing;
												}
												if (!Information.IsNothing(waypoint6.IsTerrainFollowing()))
												{
													flag12 = new bool?(waypoint6.IsTerrainFollowing());
												}
												if (waypoint6.GetThrottlePreset() != ActiveUnit_Kinematics._SpeedPreset.None)
												{
													speedPreset6 = waypoint6.GetThrottlePreset();
												}
											}
											else
											{
												waypoint12 = waypoint;
												num7 = num2;
												num13 = num8;
												flag12 = flag7;
												speedPreset6 = speedPreset;
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
					ex2.Data.Add("Error at 200626", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006B9B RID: 27547 RVA: 0x003BCA68 File Offset: 0x003BAC68
		public static float smethod_44(Mission._AttackMethod attackMethod_)
		{
			float result;
			switch (attackMethod_)
			{
			case Mission._AttackMethod.const_4:
				result = 0f;
				break;
			case Mission._AttackMethod.const_5:
				result = 20f;
				break;
			case Mission._AttackMethod.const_6:
				result = 30f;
				break;
			case Mission._AttackMethod.const_7:
				result = 40f;
				break;
			case Mission._AttackMethod.const_8:
				result = 20f;
				break;
			case Mission._AttackMethod.const_9:
				result = 30f;
				break;
			case Mission._AttackMethod.const_10:
				result = 40f;
				break;
			case Mission._AttackMethod.const_11:
				result = 40f;
				break;
			default:
				result = 0f;
				break;
			}
			return result;
		}

		// Token: 0x04003D91 RID: 15761
		private static bool? UsePathfinderToFindRoute;

		// Token: 0x02000CBA RID: 3258
		[CompilerGenerated]
		public sealed class TargetFilter
		{
			// Token: 0x06006B9D RID: 27549 RVA: 0x0002E020 File Offset: 0x0002C220
			public TargetFilter(StrikePlanner.TargetFilter TargetFilter_)
			{
				if (TargetFilter_ != null)
				{
					this.aircraft = TargetFilter_.aircraft;
					this.ShootTouristsDoc = TargetFilter_.ShootTouristsDoc;
				}
			}

			// Token: 0x06006B9E RID: 27550 RVA: 0x003BCAF0 File Offset: 0x003BACF0
			internal bool IsTargetForMyMission(Contact target_)
			{
				ActiveUnit_AI aircraftAI = this.aircraft.GetAircraftAI();
				Mission theInstance = this.strikeMission.theInstance;
				Doctrine._ShootTourists? shootTouristsDoc = this.ShootTouristsDoc;
				string text = "";
				int num = 0;
				return aircraftAI.IsTargetForMission(target_, theInstance, shootTouristsDoc, false, false, true, ref text, ref num);
			}

			// Token: 0x04003D92 RID: 15762
			public Aircraft aircraft;

			// Token: 0x04003D93 RID: 15763
			public Doctrine._ShootTourists? ShootTouristsDoc;

			// Token: 0x04003D94 RID: 15764
			public StrikePlanner.StrikeMission strikeMission;
		}

		// Token: 0x02000CBB RID: 3259
		[CompilerGenerated]
		public sealed class StrikeMission
		{
			// Token: 0x06006B9F RID: 27551 RVA: 0x0002E046 File Offset: 0x0002C246
			public StrikeMission(StrikePlanner.StrikeMission StrikeMission_)
			{
				if (StrikeMission_ != null)
				{
					this.theInstance = StrikeMission_.theInstance;
				}
			}

			// Token: 0x04003D95 RID: 15765
			public Mission theInstance;
		}
	}
}

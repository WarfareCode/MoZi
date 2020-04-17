using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns18;
using ns19;
using ns2;
using ns3;
using ns4;

namespace ns0
{
	// Token: 0x020009FF RID: 2559
	public sealed class Aircraft_Navigator : ActiveUnit_Navigator
	{
		// Token: 0x06004D57 RID: 19799 RVA: 0x001ECAF8 File Offset: 0x001EACF8
		private Aircraft GetParentPlatform()
		{
			if (Information.IsNothing(this.aircraft))
			{
				this.aircraft = (Aircraft)this.ParentPlatform;
			}
			return this.aircraft;
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x001ECB30 File Offset: 0x001EAD30
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Navigator");
				if (base.GetPlottedCourse().Count<Waypoint>() > 0)
				{
					xmlWriter_0.WriteStartElement("PC");
					List<Waypoint> list = new List<Waypoint>();
					list.AddRange(base.GetPlottedCourse());
					foreach (Waypoint current in list)
					{
						if (!Information.IsNothing(current))
						{
							current.Save(ref xmlWriter_0, ref hashSet_0);
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (base.GetPlottedCourse_PrePlanned().Count<Waypoint>() > 0)
				{
					xmlWriter_0.WriteStartElement("PC_PP");
					List<Waypoint> list2 = new List<Waypoint>();
					list2.AddRange(base.GetPlottedCourse_PrePlanned());
					foreach (Waypoint current2 in list2)
					{
						if (!Information.IsNothing(current2))
						{
							current2.Save(ref xmlWriter_0, ref hashSet_0);
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (!Information.IsNothing(this.m_Flight))
				{
					xmlWriter_0.WriteElementString("Flight", this.m_Flight.GetGuid());
				}
				xmlWriter_0.WriteElementString("MPO", this.ManualPlotOverride.ToString());
				if (!Information.IsNothing(base.GetFormationStation()))
				{
					xmlWriter_0.WriteElementString("FS_B", XmlConvert.ToString(base.GetFormationStation().Bearing));
					xmlWriter_0.WriteElementString("FS_D", XmlConvert.ToString(base.GetFormationStation().Distance));
					xmlWriter_0.WriteElementString("FS_BT", XmlConvert.ToString((byte)base.GetFormationStation().BearingType));
					if (base.GetFormationStation().SprintAndDrift)
					{
						xmlWriter_0.WriteElementString("SAD", "True");
					}
				}
				if (!Information.IsNothing(this.SupportMission_NextRefPoint))
				{
					xmlWriter_0.WriteStartElement("SM_NRP");
					ReferencePoint supportMission_NextRefPoint = this.SupportMission_NextRefPoint;
					HashSet<string> hashSet = null;
					supportMission_NextRefPoint.Save(ref xmlWriter_0, ref hashSet);
					xmlWriter_0.WriteEndElement();
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100459", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x001ECDB8 File Offset: 0x001EAFB8
		public static Aircraft_Navigator Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Aircraft_Navigator result;
			try
			{
				Aircraft_Navigator aircraft_Navigator = new Aircraft_Navigator(ref activeUnit_1);
				aircraft_Navigator.ParentPlatform = activeUnit_1;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1857393043u)
						{
							if (num <= 758041653u)
							{
								if (num != 426765699u)
								{
									if (num != 527431413u)
									{
										if (num != 758041653u)
										{
											continue;
										}
										if (Operators.CompareString(name, "MPO", false) != 0)
										{
											continue;
										}
										goto IL_235;
									}
									else
									{
										if (Operators.CompareString(name, "FS_D", false) != 0)
										{
											continue;
										}
										goto IL_37D;
									}
								}
								else if (Operators.CompareString(name, "FS_B", false) != 0)
								{
									continue;
								}
							}
							else if (num != 771752996u)
							{
								if (num != 794818787u)
								{
									if (num != 1857393043u)
									{
										continue;
									}
									if (Operators.CompareString(name, "SupportMission_NextRefPoint", false) != 0)
									{
										continue;
									}
									goto IL_289;
								}
								else
								{
									if (Operators.CompareString(name, "Flight", false) == 0)
									{
										aircraft_Navigator.FlightName = xmlNode.InnerText;
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "PC", false) != 0)
								{
									continue;
								}
								goto IL_1BF;
							}
						}
						else if (num <= 3750830438u)
						{
							if (num == 2922860948u)
							{
								goto IL_21E;
							}
							if (num == 3189192397u)
							{
								if (Operators.CompareString(name, "FormationStation_Bearing", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (num == 3750830438u && Operators.CompareString(name, "PlottedCourse", false) == 0)
								{
									goto IL_1BF;
								}
								continue;
							}
						}
						else if (num <= 3808473706u)
						{
							if (num != 3795020149u)
							{
								if (num == 3808473706u && Operators.CompareString(name, "SM_NRP", false) == 0)
								{
									goto IL_289;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "FS_BT", false) == 0)
								{
									aircraft_Navigator.GetFormationStation().BearingType = (ReferencePoint.OrientationType)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (num != 4241447450u)
							{
								if (num != 4268443209u || Operators.CompareString(name, "PC_PP", false) != 0)
								{
									continue;
								}
								IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
										Waypoint waypoint_ = Waypoint.smethod_9(ref xmlNode2, ref dictionary_0);
										ScenarioArrayUtil.AddWaypoint(ref aircraft_Navigator.PlottedCourse_PrePlanned, waypoint_);
									}
									continue;
								}
								finally
								{
									if (enumerator2 is IDisposable)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
							}
							if (Operators.CompareString(name, "FormationStation_Distance", false) == 0)
							{
								goto IL_37D;
							}
							continue;
						}
						aircraft_Navigator.GetFormationStation().Bearing = XmlConvert.ToSingle(xmlNode.InnerText);
						continue;
						IL_1BF:
						IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
								Waypoint waypoint_2 = Waypoint.smethod_9(ref xmlNode3, ref dictionary_0);
								ScenarioArrayUtil.AddWaypoint(ref aircraft_Navigator.PlottedCourse, waypoint_2);
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
						IL_21E:
						if (Operators.CompareString(name, "ManualPlotOverride", false) != 0)
						{
							continue;
						}
						IL_235:
						aircraft_Navigator.ManualPlotOverride = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_289:
						ActiveUnit_Navigator activeUnit_Navigator = aircraft_Navigator;
						XmlNode xmlNode4 = xmlNode.ChildNodes[0];
						activeUnit_Navigator.SupportMission_NextRefPoint = ReferencePoint.Load(ref xmlNode4, ref dictionary_0);
						continue;
						IL_37D:
						aircraft_Navigator.GetFormationStation().Distance = XmlConvert.ToSingle(xmlNode.InnerText);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = aircraft_Navigator;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100460", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Aircraft_Navigator(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x001ED238 File Offset: 0x001EB438
		public override bool IsOnFormationStation()
		{
			return (double)Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), base.GetFormationStation().GetLatitude(this.ParentPlatform, this.ParentPlatform.GetParentGroup(false).GetGroupLead()), base.GetFormationStation().GetLongitude(this.ParentPlatform, this.ParentPlatform.GetParentGroup(false).GetGroupLead())) < 0.5;
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x00024AB1 File Offset: 0x00022CB1
		public Aircraft_Navigator(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
			this.int_0 = 100;
			this.int_1 = 1000;
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x001ED2C4 File Offset: 0x001EB4C4
		public override void AddWaypoint(double double_0, double double_1, Waypoint.WaypointType waypointType_0, Waypoint._Creator enum50_0, Waypoint._Category enum49_0)
		{
			try
			{
				base.AddWaypoint(double_0, double_1, waypointType_0, enum50_0, enum49_0);
				if (base.GetPlottedCourse().Count<Waypoint>() == 1)
				{
					this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Cruise, null);
				}
				if (waypointType_0 == Waypoint.WaypointType.ManualPlottedCourseWaypoint && this.ParentPlatform.IsRTB())
				{
					this.ParentPlatform.LogMessage("You'd better know what you're doing! I was on RTB!", LoggedMessage.MessageType.UI, 1, true, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100461", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x001ED3AC File Offset: 0x001EB5AC
		public override void SetDesiredHeading()
		{
			try
			{
				base.SetDesiredHeading();
				Aircraft_AirOps aircraftAirOps = this.GetParentPlatform().GetAircraftAirOps();
				this.method_59(false, aircraftAirOps.GetAirOpsCondition());
				this.method_58(false, aircraftAirOps.GetAirOpsCondition());
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100462", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x001ED434 File Offset: 0x001EB634
		public void method_56()
		{
			this.ParentPlatform.GetKinematics().SetDesiredAltitudeOverride(false);
			Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.ParentPlatform.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(this.ParentPlatform.m_Scenario, false, null, false, false);
			byte? b = ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null;
			bool? flag = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
			if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
			{
				this.ParentPlatform.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(this.ParentPlatform.m_Scenario, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_1));
			}
			if (this.ParentPlatform.IsGroupLead())
			{
				foreach (ActiveUnit current in this.ParentPlatform.GetParentGroup(false).GetUnitsInGroup().Values)
				{
					if (current != this.ParentPlatform && !current.GetNavigator().HasPlottedCourse())
					{
						current.GetKinematics().SetDesiredSpeedOverride(this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride());
						current.GetKinematics().SetSpeedPreset(this.ParentPlatform.GetKinematics().GetSpeedPreset());
						current.GetKinematics().SetDesiredAltitudeOverride(false);
						ignorePlottedCourseWhenAttackingDoctrine = current.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(current.m_Scenario, false, null, false, false);
						b = (ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null);
						flag = (b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null);
						if ((flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
						{
							current.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(current.m_Scenario, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_1));
						}
					}
				}
			}
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x001ED6A8 File Offset: 0x001EB8A8
		public override void vmethod_9(float float_3, ref bool bool_14)
		{
			checked
			{
				if (base.GetPlottedCourse().Count<Waypoint>() != 0)
				{
					try
					{
						Waypoint waypoint = base.GetPlottedCourse()[0];
						if (waypoint.waypointType == Waypoint.WaypointType.Assemble && this.ParentPlatform.IsGroupLead())
						{
							foreach (ActiveUnit current in this.ParentPlatform.GetParentGroup(false).GetUnitsInGroup().Values)
							{
								if (!current.IsGroupLead())
								{
									if (!current.IsOperating())
									{
										return;
									}
									if (!current.GetAI().bool_3)
									{
										return;
									}
								}
							}
							bool_14 = true;
						}
						if (waypoint.Hold_Time > 0f)
						{
							if (!Information.IsNothing(waypoint.ArrivalTime_Zulu))
							{
								DateTime? arrivalTime_Zulu = waypoint.ArrivalTime_Zulu;
								DateTime currentTime = this.ParentPlatform.m_Scenario.GetCurrentTime(false);
								if ((arrivalTime_Zulu.HasValue ? new bool?(DateTime.Compare(arrivalTime_Zulu.GetValueOrDefault(), currentTime) >= 0) : null).GetValueOrDefault())
								{
									return;
								}
							}
							if (waypoint.waypointType == Waypoint.WaypointType.Assemble && this.ParentPlatform.IsGroupLead() && bool_14)
							{
								this.ParentPlatform.LogMessage(this.ParentPlatform.GetParentGroup(false).Name + "完成集结，正奔赴下一航路点。.", LoggedMessage.MessageType.UI, 1, true, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
							}
						}
						if (this.vmethod_8(waypoint.GetLatitude(), waypoint.GetLongitude(), float_3) || bool_14)
						{
							base.method_27(base.GetPlottedCourse()[0]);
							base.method_28(base.GetPlottedCourse()[0]);
							base.RemoveWaypoint(base.GetPlottedCourse()[0], false);
							if (waypoint.waypointType == Waypoint.WaypointType.InitialPoint || waypoint.waypointType == Waypoint.WaypointType.WeaponLaunch)
							{
								this.method_56();
							}
							if (waypoint.waypointType == Waypoint.WaypointType.LandingMarshal)
							{
								if (this.ParentPlatform.IsGroupLead())
								{
									List<Aircraft> list = new List<Aircraft>();
									using (IEnumerator<ActiveUnit> enumerator2 = this.ParentPlatform.GetParentGroup(false).GetUnitsInGroup().Values.GetEnumerator())
									{
										while (enumerator2.MoveNext())
										{
											Aircraft aircraft = (Aircraft)enumerator2.Current;
											if (aircraft != this.ParentPlatform)
											{
												list.Add(aircraft);
											}
										}
									}
									foreach (Aircraft current2 in list)
									{
										current2.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
										current2.GetAircraftAI().vmethod_27(float_3);
									}
								}
								this.ParentPlatform.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
								this.GetParentPlatform().GetAircraftAI().vmethod_27(float_3);
							}
							if ((Information.IsNothing(this.GetParentPlatform().GetAssignedMission(false)) || this.GetParentPlatform().GetAssignedMission(false).MissionClass != Mission._MissionClass.Patrol || ((Patrol)this.GetParentPlatform().GetAssignedMission(false)).patrolType != GlobalVariables.PatrolType.ASW || !this.GetParentPlatform().GetAircraftSensory().HasOperationalDippingSonar() || !this.GetParentPlatform().GetAircraftAirOps().method_75()) && (waypoint.waypointType != Waypoint.WaypointType.LocalizationRun || !this.GetParentPlatform().GetAircraftSensory().HasOperationalDippingSonar() || this.GetParentPlatform().GetAircraftAI().GetPrimaryTargetType() != Contact_Base.ContactType.Submarine || !this.GetParentPlatform().GetAircraftAirOps().method_75()))
							{
								if (base.method_25() && base.GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.Target && base.GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.WeaponTarget && base.GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.InitialPoint && base.GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.WeaponLaunch && this.ParentPlatform.GetNavigator().method_9(base.GetPlottedCourse()[0].GetLatitude(), base.GetPlottedCourse()[0].GetLongitude(), 0f, 0f))
								{
									bool flag = true;
									this.vmethod_9(float_3, ref flag);
								}
								if (waypoint.waypointType == Waypoint.WaypointType.Assemble)
								{
									if (base.GetPlottedCourse().Count<Waypoint>() > 0)
									{
										this.ParentPlatform.SetCurrentHeading(Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), base.GetPlottedCourse()[0].GetLatitude(), base.GetPlottedCourse()[0].GetLongitude()));
									}
									if (this.ParentPlatform.IsGroupLead())
									{
										foreach (ActiveUnit current3 in this.ParentPlatform.GetParentGroup(false).GetUnitsInGroup().Values)
										{
											if (!current3.IsGroupLead() && current3.IsOperating())
											{
												current3.SetCurrentHeading(this.ParentPlatform.GetCurrentHeading());
											}
										}
									}
								}
								if (base.GetPlottedCourse().Count<Waypoint>() > 0)
								{
									base.method_16();
									if (this.ParentPlatform.IsGroupLead() && waypoint.FlightFormation != Waypoint._FlightFormation.Split && base.GetPlottedCourse()[0].FlightFormation == Waypoint._FlightFormation.Split)
									{
										using (IEnumerator<ActiveUnit> enumerator5 = this.ParentPlatform.GetParentGroup(false).GetUnitsInGroup().Values.GetEnumerator())
										{
											IL_82D:
											while (enumerator5.MoveNext())
											{
												ActiveUnit current4 = enumerator5.Current;
												if (!current4.IsGroupLead() && current4.IsOperating())
												{
													Waypoint[] array = new Waypoint[0];
													current4.GetNavigator().method_27(waypoint);
													current4.GetNavigator().method_28(waypoint);
													Waypoint[] plottedCourse = this.ParentPlatform.GetNavigator().GetPlottedCourse();
													int i = 0;
													while (i < plottedCourse.Length)
													{
														Waypoint waypoint2 = plottedCourse[i];
														if (current4.FlightRole == Mission.Flight._FlightRole.const_2)
														{
															if (waypoint2.FlightFormation == Waypoint._FlightFormation.Split)
															{
																if (!Information.IsNothing(waypoint2.WP_LeadElementWingman))
																{
																	ScenarioArrayUtil.AddWaypoint(ref array, waypoint2.WP_LeadElementWingman);
																}
															}
															else
															{
																if (!Information.IsNothing(waypoint2.WP_LeadElementWingman))
																{
																	ScenarioArrayUtil.AddWaypoint(ref array, waypoint2.WP_LeadElementWingman);
																	break;
																}
																break;
															}
														}
														else if (current4.FlightRole == Mission.Flight._FlightRole.const_3)
														{
															if (waypoint2.FlightFormation == Waypoint._FlightFormation.Split)
															{
																if (!Information.IsNothing(waypoint2.WP_SecondElement))
																{
																	ScenarioArrayUtil.AddWaypoint(ref array, waypoint2.WP_SecondElement);
																}
															}
															else
															{
																if (!Information.IsNothing(waypoint2.WP_SecondElement))
																{
																	ScenarioArrayUtil.AddWaypoint(ref array, waypoint2.WP_SecondElement);
																	break;
																}
																break;
															}
														}
														else if (current4.FlightRole == Mission.Flight._FlightRole.const_4)
														{
															if (waypoint2.FlightFormation == Waypoint._FlightFormation.Split)
															{
																if (!Information.IsNothing(waypoint2.WP_SecondElementWingman))
																{
																	ScenarioArrayUtil.AddWaypoint(ref array, waypoint2.WP_SecondElementWingman);
																}
															}
															else
															{
																if (!Information.IsNothing(waypoint2.WP_SecondElementWingman))
																{
																	ScenarioArrayUtil.AddWaypoint(ref array, waypoint2.WP_SecondElementWingman);
																	break;
																}
																break;
															}
														}
														else if (current4.FlightRole == Mission.Flight._FlightRole.const_5)
														{
															if (waypoint2.FlightFormation == Waypoint._FlightFormation.Split)
															{
																if (!Information.IsNothing(waypoint2.WP_ThirdElement))
																{
																	ScenarioArrayUtil.AddWaypoint(ref array, waypoint2.WP_ThirdElement);
																}
															}
															else
															{
																if (!Information.IsNothing(waypoint2.WP_ThirdElement))
																{
																	ScenarioArrayUtil.AddWaypoint(ref array, waypoint2.WP_ThirdElement);
																	break;
																}
																break;
															}
														}
														else if (current4.FlightRole == Mission.Flight._FlightRole.const_6)
														{
															if (waypoint2.FlightFormation == Waypoint._FlightFormation.Split)
															{
																if (!Information.IsNothing(waypoint2.WP_ThirdElementWingman))
																{
																	ScenarioArrayUtil.AddWaypoint(ref array, waypoint2.WP_ThirdElementWingman);
																}
															}
															else
															{
																if (!Information.IsNothing(waypoint2.WP_ThirdElementWingman))
																{
																	ScenarioArrayUtil.AddWaypoint(ref array, waypoint2.WP_ThirdElementWingman);
																	break;
																}
																break;
															}
														}
														i++;
														continue;
														IL_7FF:
														if (array.Count<Waypoint>() > 0)
														{
															current4.GetNavigator().SetPlottedCourse(array);
															((Aircraft)current4).GetAircraftNavigator().method_16();
															goto IL_82D;
														}
														goto IL_82D;
													}
                                                    if (array.Count<Waypoint>() > 0)
                                                    {
                                                        current4.GetNavigator().SetPlottedCourse(array);
                                                        ((Aircraft)current4).GetAircraftNavigator().method_16();
                                                        goto IL_82D;
                                                    }
                                                    goto IL_82D;
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
						ex2.Data.Add("Error at 100463", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x001EDFD8 File Offset: 0x001EC1D8
		public void method_57()
		{
			float num = 0f;
			bool flag = false;
			if (Information.IsNothing(this.GetParentPlatform().GetAssignedMission(false)))
			{
				if (this.GetParentPlatform().GetAircraftAI().GetPrimaryTargetType() == Contact_Base.ContactType.Submarine)
				{
					num = 304.800018f;
					flag = false;
				}
			}
			else if (this.GetParentPlatform().GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike)
			{
				Strike arg_73_0 = (Strike)this.ParentPlatform.GetAssignedMission(false);
				if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
				{
					if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAtOptimumAltitude)
					{
						ActiveUnit_AI aircraftAI = this.GetParentPlatform().GetAircraftAI();
						Aircraft parentPlatform = this.GetParentPlatform();
						num = aircraftAI.method_78(ref parentPlatform, ActiveUnit.Throttle.Loiter, ref flag);
					}
					else
					{
						Aircraft_AI aircraftAI2 = this.GetParentPlatform().GetAircraftAI();
						Aircraft parentPlatform = this.GetParentPlatform();
						num = aircraftAI2.GetStationAltitude(ref parentPlatform, ActiveUnit.Throttle.Cruise, true, ref flag);
					}
				}
				else if (((Strike)this.ParentPlatform.GetAssignedMission(false)).strikeType == Strike.StrikeType.Sub_Strike)
				{
					num = 304.800018f;
					flag = false;
				}
				else
				{
					ActiveUnit_AI aI = this.ParentPlatform.GetAI();
					Aircraft parentPlatform = this.GetParentPlatform();
					num = aI.method_78(ref parentPlatform, ActiveUnit.Throttle.Loiter, ref flag);
				}
			}
			this.ParentPlatform.SetIsTerrainFollowing(this.ParentPlatform, flag);
			if (flag)
			{
				this.ParentPlatform.SetDesiredAltitude_TerrainFollowing(num);
			}
			else
			{
				this.ParentPlatform.SetDesiredAltitude(num);
			}
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x001EE150 File Offset: 0x001EC350
		public void method_58(bool bool_14, Aircraft_AirOps._AirOpsCondition _AirOpsCondition_0)
		{
			if (!this.ParentPlatform.GetKinematics().GetDesiredAltitudeOverride() && _AirOpsCondition_0 != Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar && !Information.IsNothing(this.GetParentPlatform().GetAssignedMission(false)))
			{
				float num = 0f;
				bool flag = false;
				Aircraft aircraft = null;
				float? num2 = null;
				bool flag2 = false;
				if (this.GetParentPlatform().GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
				{
					Patrol patrol = (Patrol)this.ParentPlatform.GetAssignedMission(false);
					if (this.GetParentPlatform().HasAssignedPatrolMission() && (this.ParentPlatform.GetNavigator().method_17() || bool_14))
					{
						if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
						{
							if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).StationAltitude > 0f)
							{
								num = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).StationAltitude;
								flag = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).StationAltitudeTerrainFollowing;
							}
							else if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAtOptimumAltitude)
							{
								ActiveUnit_AI aircraftAI = this.GetParentPlatform().GetAircraftAI();
								aircraft = this.GetParentPlatform();
								num = aircraftAI.method_78(ref aircraft, ActiveUnit.Throttle.Loiter, ref flag);
							}
							else
							{
								Aircraft_AI aircraftAI2 = this.GetParentPlatform().GetAircraftAI();
								aircraft = this.GetParentPlatform();
								num = aircraftAI2.GetStationAltitude(ref aircraft, ActiveUnit.Throttle.Cruise, true, ref flag);
							}
						}
						else
						{
							num = 0f;
							flag = false;
						}
						num2 = patrol.StationAltitude_Aircraft;
						flag2 = patrol.StationTerrainFollowing_Aircraft;
					}
					else
					{
						if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
						{
							if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngress > 0f)
							{
								num = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngress;
								flag = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngressTerrainFollowing;
							}
							else if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAtOptimumAltitude)
							{
								ActiveUnit_AI aI = this.ParentPlatform.GetAI();
								aircraft = this.GetParentPlatform();
								num = aI.method_78(ref aircraft, ActiveUnit.Throttle.Cruise, ref flag);
							}
							else
							{
								num = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngress;
								flag = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngressTerrainFollowing;
							}
						}
						else
						{
							num = 0f;
							flag = false;
						}
						num2 = patrol.TransitAltitude_Aircraft;
						flag2 = patrol.TransitTerrainFollowing_Aircraft;
					}
				}
				else if (this.GetParentPlatform().GetAssignedMission(false).MissionClass == Mission._MissionClass.Mining)
				{
					MiningMission miningMission = (MiningMission)this.ParentPlatform.GetAssignedMission(false);
					if (this.GetParentPlatform().HasAssignedMiningMission() && (base.IsOnStation(ref miningMission.AreaVertices, ref miningMission.list_14, ref miningMission.list_9, 5, false, false) || bool_14))
					{
						if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
						{
							if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAtOptimumAltitude)
							{
								ActiveUnit_AI aircraftAI3 = this.GetParentPlatform().GetAircraftAI();
								aircraft = this.GetParentPlatform();
								num = aircraftAI3.method_78(ref aircraft, ActiveUnit.Throttle.Loiter, ref flag);
							}
							else
							{
								Aircraft_AI aircraftAI4 = this.GetParentPlatform().GetAircraftAI();
								aircraft = this.GetParentPlatform();
								num = aircraftAI4.GetStationAltitude(ref aircraft, ActiveUnit.Throttle.Cruise, true, ref flag);
							}
						}
						else
						{
							num = 0f;
							flag = false;
						}
						num2 = miningMission.StationAltitude_Aircraft;
						flag2 = miningMission.StationTerrainFollowing_Aircraft;
					}
					else
					{
						if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
						{
							if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAtOptimumAltitude)
							{
								ActiveUnit_AI aI2 = this.ParentPlatform.GetAI();
								aircraft = this.GetParentPlatform();
								num = aI2.method_78(ref aircraft, ActiveUnit.Throttle.Cruise, ref flag);
							}
							else
							{
								num = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngress;
								flag = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngressTerrainFollowing;
							}
						}
						else
						{
							num = 0f;
							flag = false;
						}
						num2 = miningMission.TransitAltitude_Aircraft;
						flag2 = miningMission.TransitTerrainFollowing_Aircraft;
					}
				}
				else if (this.GetParentPlatform().GetAssignedMission(false).MissionClass == Mission._MissionClass.MineClearing)
				{
					MineClearingMission mineClearingMission = (MineClearingMission)this.ParentPlatform.GetAssignedMission(false);
					if (this.GetParentPlatform().HasAssignedMineClearingMission() && (base.IsOnStation(ref mineClearingMission.AreaVertices, ref mineClearingMission.list_12, ref mineClearingMission.list_8, 5, false, false) || bool_14))
					{
						if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
						{
							if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).StationAltitude > 0f)
							{
								num = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).StationAltitude;
								flag = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).StationAltitudeTerrainFollowing;
							}
							else if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAtOptimumAltitude)
							{
								ActiveUnit_AI aircraftAI5 = this.GetParentPlatform().GetAircraftAI();
								aircraft = this.GetParentPlatform();
								num = aircraftAI5.method_78(ref aircraft, ActiveUnit.Throttle.Loiter, ref flag);
							}
							else
							{
								Aircraft_AI aircraftAI6 = this.GetParentPlatform().GetAircraftAI();
								aircraft = this.GetParentPlatform();
								num = aircraftAI6.GetStationAltitude(ref aircraft, ActiveUnit.Throttle.Cruise, true, ref flag);
							}
						}
						else
						{
							num = 0f;
							flag = false;
						}
						num2 = mineClearingMission.StationAltitude_Aircraft;
						flag2 = mineClearingMission.StationTerrainFollowing_Aircraft;
					}
					else
					{
						if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
						{
							if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngress > 0f)
							{
								num = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngress;
								flag = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngressTerrainFollowing;
							}
							else if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAtOptimumAltitude)
							{
								ActiveUnit_AI aircraftAI7 = this.GetParentPlatform().GetAircraftAI();
								aircraft = this.GetParentPlatform();
								num = aircraftAI7.method_78(ref aircraft, ActiveUnit.Throttle.Cruise, ref flag);
							}
							else
							{
								Aircraft_AI aircraftAI8 = this.GetParentPlatform().GetAircraftAI();
								aircraft = this.GetParentPlatform();
								num = aircraftAI8.GetStationAltitude(ref aircraft, ActiveUnit.Throttle.Cruise, true, ref flag);
							}
						}
						else
						{
							num = 0f;
							flag = false;
						}
						num2 = mineClearingMission.TransitAltitude_Aircraft;
						flag2 = mineClearingMission.TransitTerrainFollowing_Aircraft;
					}
				}
				aircraft = this.GetParentPlatform();
				this.method_64(ref num, ref flag, ref num2, ref flag2, ref aircraft);
			}
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x001EE8A4 File Offset: 0x001ECAA4
		public void method_59(bool bool_14, Aircraft_AirOps._AirOpsCondition AirOpsCondition_)
		{
			if (!this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().HasValue)
			{
				if (!this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().HasValue && !(AirOpsCondition_ == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar | AirOpsCondition_ == Aircraft_AirOps._AirOpsCondition.DeployingCargo) && !Information.IsNothing(this.GetParentPlatform().GetAssignedMission(false)))
				{
					ActiveUnit.Throttle throttle = ActiveUnit.Throttle.FullStop;
					ActiveUnit.Throttle? throttle2 = null;
					if (this.GetParentPlatform().GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
					{
						Patrol patrol = (Patrol)this.ParentPlatform.GetAssignedMission(false);
						if (this.GetParentPlatform().HasAssignedPatrolMission() && (this.ParentPlatform.GetNavigator().method_17() || bool_14))
						{
							if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
							{
								throttle = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).StationThrottleSetting;
								if (throttle == ActiveUnit.Throttle.FullStop)
								{
									throttle = ActiveUnit.Throttle.Loiter;
								}
							}
							else
							{
								throttle = ActiveUnit.Throttle.Loiter;
							}
							throttle2 = patrol.StationThrottle_Aircraft;
						}
						else
						{
							if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
							{
								throttle = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseThrottleSettingIngress;
							}
							else
							{
								throttle = ActiveUnit.Throttle.Cruise;
							}
							throttle2 = patrol.TransitThrottle_Aircraft;
						}
					}
					else if (this.GetParentPlatform().GetAssignedMission(false).MissionClass == Mission._MissionClass.Mining)
					{
						MiningMission miningMission = (MiningMission)this.ParentPlatform.GetAssignedMission(false);
						if (this.GetParentPlatform().HasAssignedMiningMission() && (base.IsOnStation(ref miningMission.AreaVertices, ref miningMission.list_14, ref miningMission.list_9, 5, false, false) || bool_14))
						{
							if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
							{
								throttle = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).StationThrottleSetting;
								if (throttle == ActiveUnit.Throttle.FullStop)
								{
									throttle = ActiveUnit.Throttle.Loiter;
								}
							}
							else
							{
								throttle = ActiveUnit.Throttle.Loiter;
							}
							throttle2 = miningMission.StationThrottle_Aircraft;
						}
						else
						{
							if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
							{
								throttle = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseThrottleSettingIngress;
							}
							else
							{
								throttle = ActiveUnit.Throttle.Cruise;
							}
							throttle2 = miningMission.TransitThrottle_Aircraft;
						}
					}
					else if (this.GetParentPlatform().GetAssignedMission(false).MissionClass == Mission._MissionClass.MineClearing)
					{
						MineClearingMission mineClearingMission = (MineClearingMission)this.ParentPlatform.GetAssignedMission(false);
						if (this.GetParentPlatform().HasAssignedMineClearingMission() && (base.IsOnStation(ref mineClearingMission.AreaVertices, ref mineClearingMission.list_12, ref mineClearingMission.list_8, 5, false, false) || bool_14))
						{
							if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
							{
								throttle = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).StationThrottleSetting;
								if (throttle == ActiveUnit.Throttle.FullStop)
								{
									throttle = ActiveUnit.Throttle.Loiter;
								}
							}
							else
							{
								throttle = ActiveUnit.Throttle.Loiter;
							}
							throttle2 = mineClearingMission.StationThrottle_Aircraft;
						}
						else
						{
							if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
							{
								throttle = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseThrottleSettingIngress;
							}
							else
							{
								throttle = ActiveUnit.Throttle.Cruise;
							}
							throttle2 = mineClearingMission.TransitThrottle_Aircraft;
						}
					}
					else if (this.GetParentPlatform().GetAssignedMission(false).MissionClass == Mission._MissionClass.Support)
					{
						SupportMission supportMission = (SupportMission)this.ParentPlatform.GetAssignedMission(false);
						if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
						{
							throttle = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseThrottleSettingIngress;
						}
						else
						{
							throttle = ActiveUnit.Throttle.Cruise;
						}
						throttle2 = supportMission.TransitThrottle_Aircraft;
					}
					else if (this.GetParentPlatform().GetAssignedMission(false).MissionClass == Mission._MissionClass.Cargo)
					{
						CargoMission cargoMission = (CargoMission)this.ParentPlatform.GetAssignedMission(false);
						if (this.GetParentPlatform().HasAssignedCargoMission() && (base.IsOnStation(ref cargoMission.AreaPoints, ref cargoMission.list_8, ref cargoMission.list_9, 5, false, false) || bool_14))
						{
							throttle2 = new ActiveUnit.Throttle?(cargoMission.StationThrottle_Aircraft);
						}
						else
						{
							throttle2 = new ActiveUnit.Throttle?(cargoMission.TransitThrottle_Aircraft);
						}
					}
					Aircraft parentPlatform = this.GetParentPlatform();
					this.method_65(ref throttle, ref throttle2, ref parentPlatform);
				}
			}
			else if (this.ParentPlatform.GetKinematics().GetSpeedPreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				this.ParentPlatform.SetThrottle((ActiveUnit.Throttle)this.ParentPlatform.GetKinematics().GetSpeedPreset(), new float?((float)((int)Math.Round((double)this.ParentPlatform.GetDesiredSpeed()))));
			}
			else
			{
				this.ParentPlatform.SetThrottle(this.ParentPlatform.GetKinematics().vmethod_38(this.ParentPlatform.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().Value))), this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride());
			}
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x001EEDB0 File Offset: 0x001ECFB0
		public void method_60(Aircraft_AirOps._AirOpsCondition _AirOpsCondition_0)
		{
			if (!this.ParentPlatform.GetKinematics().GetDesiredAltitudeOverride() && _AirOpsCondition_0 != Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar && _AirOpsCondition_0 != Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar && _AirOpsCondition_0 != Aircraft_AirOps._AirOpsCondition.BVRAttack && _AirOpsCondition_0 != Aircraft_AirOps._AirOpsCondition.Dogfight)
			{
				Aircraft aircraft = null;
				bool flag = false;
				float num = 0f;
				if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
				{
					if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAtOptimumAltitude)
					{
						ActiveUnit_AI aI = this.ParentPlatform.GetAI();
						aircraft = this.GetParentPlatform();
						num = aI.method_78(ref aircraft, ActiveUnit.Throttle.Loiter, ref flag);
					}
					else
					{
						num = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).StationAltitude;
						flag = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).StationAltitudeTerrainFollowing;
						if (num == 0f)
						{
							num = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).AttackAltitudeIngress;
							flag = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).AttackAltitudeIngressTerrainFollowing;
						}
						if (num == 0f)
						{
							num = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngress;
							flag = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngressTerrainFollowing;
						}
					}
				}
				else
				{
					num = 0f;
				}
				float? num2 = null;
				bool flag2 = false;
				if (!Information.IsNothing(this.GetParentPlatform().GetAssignedMission(false)) && this.GetParentPlatform().GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
				{
					Patrol patrol = (Patrol)this.ParentPlatform.GetAssignedMission(false);
					float? num3 = null;
					float num4;
					if (!Information.IsNothing(this.GetParentPlatform().GetAircraftAI().GetPrimaryTarget()))
					{
						Doctrine doctrine = this.ParentPlatform.m_Doctrine;
						Weapon weapon = this.ParentPlatform.GetWeaponry().method_19(this.GetParentPlatform().GetAircraftAI().GetPrimaryTarget(), false, true, doctrine);
						if (!Information.IsNothing(weapon))
						{
							num4 = weapon.GetMaxRangeToTarget(this.ParentPlatform, this.GetParentPlatform().GetAircraftAI().GetPrimaryTarget(), true, doctrine, false);
						}
						else
						{
							num4 = 0f;
						}
					}
					else
					{
						num4 = 0f;
					}
					patrol = (Patrol)this.ParentPlatform.GetAssignedMission(false);
					num3 = patrol.AttackDistance_Aircraft;
					float num5;
					if (Information.IsNothing(num3))
					{
						num5 = (float)Math.Max((double)(10f + num4), (double)num4 * 1.2);
					}
					else
					{
						float? num6 = num3;
						float num7 = num4;
						num5 = (num6.HasValue ? new float?(num6.GetValueOrDefault() + num7) : null).Value;
					}
					if (this.ParentPlatform.GetHorizontalRange(this.GetParentPlatform().GetAircraftAI().GetPrimaryTarget()) > num5)
					{
						num2 = patrol.TransitAltitude_Aircraft;
						flag2 = patrol.TransitTerrainFollowing_Aircraft;
					}
					else
					{
						num2 = patrol.AttackAltitude_Aircraft;
						flag2 = patrol.AttackTerrainFollowing_Aircraft;
					}
				}
				aircraft = this.GetParentPlatform();
				this.method_64(ref num, ref flag, ref num2, ref flag2, ref aircraft);
				if (this.ParentPlatform.GetAI().GetPrimaryTarget().IsAirSpace() && this.ParentPlatform.GetAI().GetPrimaryTarget().Altitude_Known && this.ParentPlatform.GetAI().GetPrimaryTarget().GetCurrentAltitude_ASL(false) > this.ParentPlatform.GetDesiredAltitude())
				{
					this.ParentPlatform.SetDesiredAltitude(this.ParentPlatform.GetAI().GetPrimaryTarget().GetCurrentAltitude_ASL(false));
				}
			}
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x001EF18C File Offset: 0x001ED38C
		public void method_61(float float_3, float? nullable_0, bool bool_14, Aircraft_AirOps._AirOpsCondition _AirOpsCondition_0)
		{
			try
			{
				if (this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().HasValue)
				{
					if (this.ParentPlatform.GetKinematics().GetSpeedPreset() != ActiveUnit_Kinematics._SpeedPreset.None)
					{
						this.ParentPlatform.SetThrottle((ActiveUnit.Throttle)this.ParentPlatform.GetKinematics().GetSpeedPreset(), new float?((float)((int)Math.Round((double)this.ParentPlatform.GetDesiredSpeed()))));
					}
					else
					{
						this.ParentPlatform.SetThrottle(this.ParentPlatform.GetKinematics().vmethod_38(this.ParentPlatform.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().Value))), this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride());
					}
				}
				else if (!this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().HasValue && _AirOpsCondition_0 != Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
				{
					ActiveUnit_AI aircraftAI = this.GetParentPlatform().GetAircraftAI();
					Unit primaryTarget = this.ParentPlatform.GetAI().GetPrimaryTarget();
					float? rangeToTargetUnit_ = null;
					float currentAltitude_ASL = this.ParentPlatform.GetCurrentAltitude_ASL(false);
					float? speed_ = null;
					float currentHeading = this.ParentPlatform.GetCurrentHeading();
					float? nullable_ = new float?(0f);
					bool flag = true;
					if (aircraftAI.CanReachTargetUnit(primaryTarget, rangeToTargetUnit_, currentAltitude_ASL, speed_, currentHeading, ActiveUnit.Throttle.Full, nullable_, false, false, ref flag))
					{
						this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Full, null);
						if (bool_14 && this.ParentPlatform.GetKinematics().HasFlankAltBand())
						{
							ActiveUnit_AI aircraftAI2 = this.GetParentPlatform().GetAircraftAI();
							Unit primaryTarget2 = this.ParentPlatform.GetAI().GetPrimaryTarget();
							float? rangeToTargetUnit_2 = null;
							float currentAltitude_ASL2 = this.ParentPlatform.GetCurrentAltitude_ASL(false);
							float? speed_2 = null;
							float currentHeading2 = this.ParentPlatform.GetCurrentHeading();
							float? nullable_2 = new float?(0f);
							flag = true;
							if (aircraftAI2.CanReachTargetUnit(primaryTarget2, rangeToTargetUnit_2, currentAltitude_ASL2, speed_2, currentHeading2, ActiveUnit.Throttle.Flank, nullable_2, false, false, ref flag))
							{
								this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Flank, null);
							}
						}
					}
					else
					{
						this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Cruise, null);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100390", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x001EF434 File Offset: 0x001ED634
		public ActiveUnit.Throttle method_62()
		{
			ActiveUnit.Throttle? throttle = null;
			if (!Information.IsNothing(this.GetParentPlatform().GetAssignedMission(false)))
			{
				Mission assignedMission = this.GetParentPlatform().GetAssignedMission(false);
				Aircraft parentPlatform = this.GetParentPlatform();
				throttle = assignedMission.GetTransitThrottle(ref parentPlatform);
			}
			if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
			{
				if (!Information.IsNothing(throttle))
				{
					byte? b = throttle.HasValue ? new byte?((byte)throttle.GetValueOrDefault()) : null;
					if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						goto IL_13D;
					}
				}
				throttle = new ActiveUnit.Throttle?(this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseThrottleSettingEgress);
			}
			else
			{
				if (!Information.IsNothing(throttle))
				{
					byte? b = throttle.HasValue ? new byte?((byte)throttle.GetValueOrDefault()) : null;
					if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						goto IL_13D;
					}
				}
				throttle = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
			}
			IL_13D:
			if (Information.IsNothing(throttle))
			{
				throttle = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
			}
			return throttle.Value;
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x001EF5A4 File Offset: 0x001ED7A4
		public float GetTransitAltitude(ref bool bool_14)
		{
			float? num = null;
			if (!Information.IsNothing(this.GetParentPlatform().GetAssignedMission(false)))
			{
				Mission assignedMission = this.GetParentPlatform().GetAssignedMission(false);
				Aircraft parentPlatform = this.GetParentPlatform();
				num = assignedMission.GetTransitAltitude(ref parentPlatform, ref bool_14);
			}
			if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
			{
				if (Information.IsNothing(num))
				{
					if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAtOptimumAltitude)
					{
						ActiveUnit_AI aI = this.ParentPlatform.GetAI();
						Aircraft parentPlatform = this.GetParentPlatform();
						num = new float?(aI.method_78(ref parentPlatform, ActiveUnit.Throttle.Cruise, ref bool_14));
					}
					else
					{
						num = new float?(this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeEgress);
						bool_14 = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeEgressTerrainFollowing;
					}
				}
				if (Information.IsNothing(num))
				{
					ActiveUnit_AI aI2 = this.ParentPlatform.GetAI();
					Aircraft parentPlatform = this.GetParentPlatform();
					num = new float?(aI2.method_78(ref parentPlatform, ActiveUnit.Throttle.Cruise, ref bool_14));
				}
			}
			else if (Information.IsNothing(num))
			{
				ActiveUnit_AI aI3 = this.ParentPlatform.GetAI();
				Aircraft parentPlatform = this.GetParentPlatform();
				num = new float?(aI3.method_78(ref parentPlatform, ActiveUnit.Throttle.Cruise, ref bool_14));
			}
			return num.Value;
		}

		// Token: 0x06004D67 RID: 19815 RVA: 0x001EF720 File Offset: 0x001ED920
		public override void vmethod_6(float float_3, bool bool_14)
		{
			if (!Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)) && this.ParentPlatform.GetAssignedMission(false).MissionClass == Mission._MissionClass.Support)
			{
				base.vmethod_6(float_3, bool_14);
				SupportMission supportMission = (SupportMission)this.ParentPlatform.GetAssignedMission(false);
				if (!this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().HasValue)
				{
					ActiveUnit.Throttle throttle;
					ActiveUnit.Throttle? throttle2;
					if (!bool_14)
					{
						if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
						{
							throttle = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).StationThrottleSetting;
							if (throttle == ActiveUnit.Throttle.FullStop)
							{
								throttle = ActiveUnit.Throttle.Loiter;
							}
						}
						else
						{
							throttle = ActiveUnit.Throttle.Loiter;
						}
						throttle2 = supportMission.StationThrottle_Aircraft;
					}
					else
					{
						if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
						{
							throttle = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseThrottleSettingIngress;
						}
						else
						{
							throttle = ActiveUnit.Throttle.Cruise;
						}
						throttle2 = supportMission.TransitThrottle_Aircraft;
					}
					Aircraft aircraft = this.GetParentPlatform();
					this.method_65(ref throttle, ref throttle2, ref aircraft);
				}
				if (!this.ParentPlatform.GetKinematics().GetDesiredAltitudeOverride())
				{
					Aircraft aircraft = null;
					bool flag = false;
					float num = 0f;
					bool flag2 = false;
					float? num2;
					if (!bool_14)
					{
						if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
						{
							if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAtOptimumAltitude)
							{
								ActiveUnit_AI aircraftAI = this.GetParentPlatform().GetAircraftAI();
								aircraft = this.GetParentPlatform();
								num = aircraftAI.method_78(ref aircraft, ActiveUnit.Throttle.Loiter, ref flag);
							}
							else
							{
								Aircraft_AI aircraftAI2 = this.GetParentPlatform().GetAircraftAI();
								aircraft = this.GetParentPlatform();
								num = aircraftAI2.GetStationAltitude(ref aircraft, ActiveUnit.Throttle.Cruise, true, ref flag);
							}
						}
						else
						{
							num = 0f;
							flag = false;
						}
						num2 = supportMission.StationAltitude_Aircraft;
						flag2 = supportMission.StationTerrainFollowing_Aircraft;
					}
					else
					{
						if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
						{
							if (this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAtOptimumAltitude)
							{
								ActiveUnit_AI aI = this.ParentPlatform.GetAI();
								aircraft = this.GetParentPlatform();
								num = aI.method_78(ref aircraft, ActiveUnit.Throttle.Cruise, ref flag);
							}
							else
							{
								num = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngress;
								flag = this.GetParentPlatform().GetLoadout().GetMissionProfile(this.ParentPlatform.m_Scenario).CruiseAltitudeIngressTerrainFollowing;
							}
						}
						else
						{
							num = 0f;
							flag = false;
						}
						num2 = supportMission.TransitAltitude_Aircraft;
						flag2 = supportMission.TransitTerrainFollowing_Aircraft;
					}
					aircraft = this.GetParentPlatform();
					this.method_64(ref num, ref flag, ref num2, ref flag2, ref aircraft);
				}
			}
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x001EF9DC File Offset: 0x001EDBDC
		public void method_64(ref float float_3, ref bool bool_14, ref float? nullable_0, ref bool bool_15, ref Aircraft aircraft_1)
		{
			if (!this.ParentPlatform.GetKinematics().GetDesiredAltitudeOverride() && aircraft_1.GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
			{
				if (nullable_0.HasValue)
				{
					this.ParentPlatform.SetIsTerrainFollowing(this.ParentPlatform, bool_15);
					if (bool_15)
					{
						this.ParentPlatform.SetDesiredAltitude_TerrainFollowing(nullable_0.Value);
					}
					else
					{
						this.ParentPlatform.SetDesiredAltitude(nullable_0.Value);
					}
				}
				else if (!Information.IsNothing(aircraft_1.GetLoadout()))
				{
					if (float_3 <= 0f)
					{
						Aircraft aircraft = aircraft_1;
						ActiveUnit_AI aI = this.ParentPlatform.GetAI();
						Aircraft parentPlatform = this.GetParentPlatform();
						ActiveUnit.Throttle throttle = this.ParentPlatform.GetThrottle();
						ActiveUnit parentPlatform2;
						ActiveUnit parentPlatform3;
						bool bool_16 = (parentPlatform2 = this.ParentPlatform).IsTerrainFollowing(parentPlatform3 = this.ParentPlatform);
						float desiredAltitude = aI.method_78(ref parentPlatform, throttle, ref bool_16);
						parentPlatform2.SetIsTerrainFollowing(parentPlatform3, bool_16);
						aircraft.SetDesiredAltitude(desiredAltitude);
					}
					else
					{
						this.ParentPlatform.SetIsTerrainFollowing(this.ParentPlatform, bool_14);
						if (bool_14)
						{
							aircraft_1.SetDesiredAltitude_TerrainFollowing(float_3);
						}
						else
						{
							aircraft_1.SetDesiredAltitude(float_3);
						}
					}
				}
				else
				{
					ActiveUnit parentPlatform4 = this.ParentPlatform;
					ActiveUnit_AI aI2 = this.ParentPlatform.GetAI();
					Aircraft parentPlatform = this.GetParentPlatform();
					ActiveUnit.Throttle throttle2 = this.ParentPlatform.GetThrottle();
					ActiveUnit parentPlatform2;
					ActiveUnit parentPlatform3;
					bool bool_16 = (parentPlatform3 = this.ParentPlatform).IsTerrainFollowing(parentPlatform2 = this.ParentPlatform);
					float desiredAltitude2 = aI2.method_78(ref parentPlatform, throttle2, ref bool_16);
					parentPlatform3.SetIsTerrainFollowing(parentPlatform2, bool_16);
					parentPlatform4.SetDesiredAltitude(desiredAltitude2);
				}
			}
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x001EFB7C File Offset: 0x001EDD7C
		public void method_65(ref ActiveUnit.Throttle Throttle1, ref ActiveUnit.Throttle? Throttle2, ref Aircraft aircraft_)
		{
			if (!this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().HasValue)
			{
				if (!this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().HasValue && aircraft_.GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
				{
					if (!Information.IsNothing(Throttle2))
					{
						aircraft_.SetThrottle(Throttle2.Value, null);
					}
					else if (!Information.IsNothing(aircraft_.GetLoadout()))
					{
						aircraft_.SetThrottle(Throttle1, null);
					}
					else
					{
						if (this.ParentPlatform.GetThrottle() < ActiveUnit.Throttle.Cruise)
						{
							this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Cruise, null);
						}
						float num = (float)aircraft_.GetAircraftKinematics().GetSpeed(aircraft_.GetCurrentAltitude_ASL(false), aircraft_.GetThrottle());
						if (this.ParentPlatform.GetCurrentSpeed() < num)
						{
							this.ParentPlatform.SetDesiredSpeed(num);
						}
					}
				}
			}
			else if (this.ParentPlatform.GetKinematics().GetSpeedPreset() != ActiveUnit_Kinematics._SpeedPreset.None)
			{
				this.ParentPlatform.SetThrottle((ActiveUnit.Throttle)this.ParentPlatform.GetKinematics().GetSpeedPreset(), new float?((float)((int)Math.Round((double)this.ParentPlatform.GetDesiredSpeed()))));
			}
			else
			{
				this.ParentPlatform.SetThrottle(this.ParentPlatform.GetKinematics().vmethod_38(this.ParentPlatform.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride().Value))), this.ParentPlatform.GetKinematics().GetDesiredSpeedOverride());
			}
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x00024ACD File Offset: 0x00022CCD
		public bool method_66(ActiveUnit activeUnit_)
		{
			return !Information.IsNothing(activeUnit_) && this.method_67(activeUnit_) < 3.0;
		}

		// Token: 0x06004D6B RID: 19819 RVA: 0x001EFD38 File Offset: 0x001EDF38
		public double method_67(ActiveUnit activeUnit_)
		{
			double result;
			if (this.GetParentPlatform().IsVerticalLaunchable())
			{
				result = (double)Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), activeUnit_.GetLatitude(null), activeUnit_.GetLongitude(null));
			}
			else
			{
				GeoPoint geoPoint = activeUnit_.GetAirOps().method_5();
				result = (double)Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), geoPoint.GetLatitude(), geoPoint.GetLongitude());
			}
			return result;
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x001EFDF8 File Offset: 0x001EDFF8
		public void method_68(ActiveUnit AssignedHostUnit_, float desiredSpeed_, float desireAltitude_, ref bool bTerrainFollowing_)
		{
			if (!Information.IsNothing(AssignedHostUnit_) && !Information.IsNothing(AssignedHostUnit_.GetAirOps()))
			{
				try
				{
					if (this.GetParentPlatform().IsVerticalLaunchable())
					{
						this.ParentPlatform.SetDesiredHeading(ActiveUnit._TurnRate.const_1, Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), AssignedHostUnit_.GetLatitude(null), AssignedHostUnit_.GetLongitude(null)));
						this.vmethod_4(AssignedHostUnit_.GetLatitude(null), AssignedHostUnit_.GetLongitude(null), 0f, 0f);
					}
					else
					{
						GeoPoint geoPoint = AssignedHostUnit_.GetAirOps().method_5();
						this.ParentPlatform.SetDesiredHeading(ActiveUnit._TurnRate.const_1, Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), geoPoint.GetLatitude(), geoPoint.GetLongitude()));
						this.vmethod_4(geoPoint.GetLatitude(), geoPoint.GetLongitude(), 0f, 0f);
					}
					this.ParentPlatform.SetDesiredSpeed(desiredSpeed_);
					this.ParentPlatform.SetThrottle(this.ParentPlatform.GetKinematics().vmethod_38(this.ParentPlatform.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.ParentPlatform.GetDesiredSpeed()))), null);
					this.ParentPlatform.SetIsTerrainFollowing(this.ParentPlatform, bTerrainFollowing_);
					if (bTerrainFollowing_)
					{
						this.ParentPlatform.SetDesiredAltitude_TerrainFollowing(desireAltitude_);
					}
					else
					{
						this.ParentPlatform.SetDesiredAltitude(desireAltitude_);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100464", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x001F0008 File Offset: 0x001EE208
		public override  void vmethod_5()
		{
			try
			{
				if (!this.GetParentPlatform().IsNotGroupLead() || (this.GetParentPlatform().IsNotGroupLead() && this.GetParentPlatform().GetAircraftNavigator().HasPlottedCourse()))
				{
					List<Waypoint> list = base.GetPlottedCourse().ToList<Waypoint>();
					List<Waypoint> list2 = new List<Waypoint>();
					bool flag = true;
					if (this.ParentPlatform.GetNavigator().method_23())
					{
						flag = false;
					}
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						Waypoint waypoint = list[i];
						if (waypoint.waypointType != Waypoint.WaypointType.PathfindingPoint)
						{
							if (waypoint.waypointType == Waypoint.WaypointType.Split || waypoint.waypointType == Waypoint.WaypointType.InitialPoint || waypoint.waypointType == Waypoint.WaypointType.WeaponLaunch || waypoint.waypointType == Waypoint.WaypointType.Target || waypoint.waypointType == Waypoint.WaypointType.WeaponTarget || waypoint.waypointType == Waypoint.WaypointType.StrikeIngress)
							{
								base.method_27(waypoint);
								base.method_28(waypoint);
								if (!list2.Contains(waypoint))
								{
									list2.Add(waypoint);
								}
							}
							if (waypoint.waypointType == Waypoint.WaypointType.Target || waypoint.waypointType == Waypoint.WaypointType.WeaponTarget)
							{
								float num2 = 0f;
								float num3 = 0f;
								Contact contact = null;
								foreach (ActiveUnit current in this.GetParentPlatform().m_Scenario.GetActiveUnits().Values)
								{
									if (current.IsWeapon)
									{
										Weapon weapon = (Weapon)current;
										if (weapon.GetFiringParent() == this.GetParentPlatform() && !Information.IsNothing(weapon.GetWeaponAI().GetPrimaryTarget()) && (weapon.GetWeaponAI().GetPrimaryTarget().IsSurface() || weapon.GetWeaponAI().GetPrimaryTarget().IsFacilityType()))
										{
											float distance = Math2.GetDistance(this.GetParentPlatform().GetLatitude(null), this.GetParentPlatform().GetLongitude(null), weapon.GetWeaponAI().GetPrimaryTarget().GetLatitude(null), weapon.GetWeaponAI().GetPrimaryTarget().GetLongitude(null));
											if (distance > num2)
											{
												num2 = distance;
												contact = weapon.GetWeaponAI().GetPrimaryTarget();
											}
										}
									}
								}
								if (num2 > 0f && !Information.IsNothing(contact))
								{
									foreach (Waypoint current2 in list)
									{
										if (current2.waypointType == Waypoint.WaypointType.StrikeEgress || current2.waypointType == Waypoint.WaypointType.Formate || current2.waypointType == Waypoint.WaypointType.TurningPoint)
										{
											float distance2 = Math2.GetDistance(current2.GetLatitude(), current2.GetLongitude(), contact.GetLatitude(null), contact.GetLongitude(null));
											float distance3 = Math2.GetDistance(this.GetParentPlatform().GetLatitude(null), this.GetParentPlatform().GetLongitude(null), current2.GetLatitude(), current2.GetLongitude());
											if (distance2 >= num2 || distance3 >= num2 + 10f)
											{
												break;
											}
											base.method_27(current2);
											base.method_28(current2);
											if (!list2.Contains(current2))
											{
												list2.Add(current2);
											}
										}
									}
								}
								if (i > 0)
								{
									int num4 = i - 1;
									for (int j = 0; j <= num4; j++)
									{
										Waypoint waypoint2 = list[j];
										if (waypoint2.waypointType == Waypoint.WaypointType.TurningPoint)
										{
											base.method_27(waypoint2);
											base.method_28(waypoint2);
											if (!list2.Contains(waypoint2))
											{
												list2.Add(waypoint2);
											}
										}
									}
								}
								if (!flag && !Information.IsNothing(this.GetParentPlatform().GetAircraftAI().GetPrimaryTarget()))
								{
									Contact primaryTarget = this.GetParentPlatform().GetAircraftAI().GetPrimaryTarget();
									if (num3 == 0f)
									{
										num3 = Math2.GetDistance(this.GetParentPlatform().GetLatitude(null), this.GetParentPlatform().GetLongitude(null), primaryTarget.GetLatitude(null), primaryTarget.GetLongitude(null));
									}
									foreach (Waypoint current3 in list)
									{
										if (current3.waypointType == Waypoint.WaypointType.StrikeEgress || current3.waypointType == Waypoint.WaypointType.Formate)
										{
											float distance4 = Math2.GetDistance(current3.GetLatitude(), current3.GetLongitude(), primaryTarget.GetLatitude(null), primaryTarget.GetLongitude(null));
											float distance5 = Math2.GetDistance(this.GetParentPlatform().GetLatitude(null), this.GetParentPlatform().GetLongitude(null), current3.GetLatitude(), current3.GetLongitude());
											if (distance4 >= num3 || distance5 >= num3 + 10f)
											{
												break;
											}
											base.method_27(current3);
											base.method_28(current3);
											if (!list2.Contains(current3))
											{
												list2.Add(current3);
											}
										}
									}
								}
								foreach (Waypoint current4 in list2)
								{
									base.RemoveWaypoint(current4, false);
								}
								base.method_16();
								goto IL_644;
							}
						}
						else
						{
							list2.Add(waypoint);
						}
					}
					foreach (Waypoint current4 in list2)
					{
						base.RemoveWaypoint(current4, false);
					}
					base.method_16();
				}
				else if (!this.GetParentPlatform().GetAircraftNavigator().HasPlottedCourse())
				{
					ActiveUnit_AI aircraftAI = this.GetParentPlatform().GetAircraftAI();
					Aircraft_AirOps aircraftAirOps = this.GetParentPlatform().GetAircraftAirOps();
					aircraftAI.method_16(ref aircraftAirOps);
				}
				IL_644:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100465", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x001F0730 File Offset: 0x001EE930
		public void method_69()
		{
			try
			{
				ActiveUnit assignedHostUnit = this.GetParentPlatform().GetAircraftAirOps().GetAssignedHostUnit();
				if (!Information.IsNothing(assignedHostUnit))
				{
					double num = (double)Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), assignedHostUnit.GetLatitude(null), assignedHostUnit.GetLongitude(null));
					double num2 = (double)assignedHostUnit.GetCurrentSpeed();
					if (this.GetParentPlatform().IsRotaryWingAircraft())
					{
						double num3 = (double)this.ParentPlatform.GetKinematics().GetSpeed(this.ParentPlatform.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Full);
						double num4 = num3 / 3.0;
						double val = Math.Max(num4, num2 + 30.0);
						this.ParentPlatform.SetDesiredSpeed((float)Math.Min(Math.Max(val, num3 * num), num3));
					}
					else
					{
						double num5 = (double)this.ParentPlatform.GetKinematics().GetSpeed(this.ParentPlatform.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter);
						double num4 = num5 * 0.7;
						this.ParentPlatform.SetDesiredSpeed((float)(num4 + num));
					}
					this.GetParentPlatform().SetThrottle(this.GetParentPlatform().GetAircraftKinematics().vmethod_38(this.GetParentPlatform().GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.GetParentPlatform().GetDesiredSpeed()))), null);
					this.ParentPlatform.SetDesiredHeading(ActiveUnit._TurnRate.const_1, Math2.GetAzimuth(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), assignedHostUnit.GetLatitude(null), assignedHostUnit.GetLongitude(null)));
					this.vmethod_4(assignedHostUnit.GetLatitude(null), assignedHostUnit.GetLongitude(null), 0f, 0f);
					float num6 = (float)((double)assignedHostUnit.GetCurrentAltitude_ASL(false) + 100.0 * num);
					if (this.ParentPlatform.GetDesiredAltitude() >= num6)
					{
						this.ParentPlatform.SetDesiredAltitude(num6);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100466", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x001F09BC File Offset: 0x001EEBBC
		public bool method_70(float elapsedTime_)
		{
			bool result = false;
			try
			{
				ActiveUnit assignedHostUnit = this.GetParentPlatform().GetAircraftAirOps().GetAssignedHostUnit();
				if (!Information.IsNothing(assignedHostUnit))
				{
					double num = (double)Math2.GetDistance(this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null), assignedHostUnit.GetLatitude(null), assignedHostUnit.GetLongitude(null));
					result = ((double)(2f * this.ParentPlatform.GetCurrentSpeed() * elapsedTime_ / 3600f) > num);
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100467", "");
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

		// Token: 0x06004D70 RID: 19824 RVA: 0x001F0AA8 File Offset: 0x001EECA8
		public override bool vmethod_16(double lat1, double lon1, double lat2, double lon2, bool bool_14, float float_3, bool bool_15, int? nullable_0)
		{
			bool flag = false;
			bool result;
			try
			{
				if (bool_15)
				{
					Unit parentPlatform = this.ParentPlatform;
					double latitude = this.ParentPlatform.GetLatitude(null);
					double longitude = this.ParentPlatform.GetLongitude(null);
					byte b = 0;
					bool flag2 = false;
					bool flag3 = false;
					float? nullable_ = new float?(0f);
					short? nullable_2 = null;
					List<ActiveUnit> list = null;
					if (!parentPlatform.vmethod_41(latitude, longitude, ref b, true, ref flag2, false, ref flag3, nullable_, nullable_2, ref list, 0f, false, false))
					{
						flag = false;
						result = false;
						return result;
					}
				}
				if (base.GetPlottedCourse().Count<Waypoint>() > 0 && (base.GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.Target || base.GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.WeaponTarget) && base.GetPlottedCourse()[0].Creator == Waypoint._Creator.const_0)
				{
					flag = false;
				}
				else
				{
					if (this.ParentPlatform.IsNotGroupLead() && !Information.IsNothing(this.ParentPlatform.IsGroupLead()))
					{
						ActiveUnit groupLead = this.ParentPlatform.GetParentGroup(false).GetGroupLead();
						if (groupLead.GetNavigator().GetPlottedCourse().Count<Waypoint>() > 0 && (groupLead.GetNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.Target || groupLead.GetNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.WeaponTarget || groupLead.GetNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.StrikeEgress || groupLead.GetNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.Formate) && groupLead.GetNavigator().GetPlottedCourse()[0].Creator == Waypoint._Creator.const_0)
						{
							flag = false;
							result = false;
							return result;
						}
					}
					if (base.method_52(lat1, lon1, lat2, lon2, float_3))
					{
						flag = true;
					}
					else
					{
						float distance = Math2.GetDistance(lat1, lon1, lat2, lon2);
						if (!float.IsNaN(distance) && distance != 0f)
						{
							float num;
							if (!this.ParentPlatform.IsAircraft)
							{
								if (distance < this.ParentPlatform.m_Scenario.Navigation_FinegrainedMaxDistance)
								{
									num = Class324.interface2_0.imethod_1();
								}
								else
								{
									num = Class324.interface2_0.imethod_0();
								}
							}
							else
							{
								num = Class324.interface2_0.imethod_0();
							}
							bool flag4 = false;
							Angle angle = default(Angle);
							angle.SetDegrees(lon1);
							Angle angle2 = default(Angle);
							angle2.SetDegrees(lat1);
							Angle angle3 = default(Angle);
							angle3.SetDegrees(lon2);
							Angle angle4 = default(Angle);
							angle4.SetDegrees(lat2);
							Angle d = World.ApproxAngularDistance(angle2, angle, angle4, angle3);
							float num2 = (float)d.GetDegrees();
							if (num2 < num * 2f)
							{
								flag = false;
								result = false;
								return result;
							}
							int num3 = (int)Math.Round((double)(num2 / num));
							Angle angle5 = default(Angle);
							Angle angle6 = default(Angle);
							int num4 = num3;
							for (int i = 1; i <= num4; i++)
							{
								World.IntermediateGCPoint(num * (float)i / num2, angle2, angle, angle4, angle3, d, out angle6, out angle5);
								double degrees = angle6.GetDegrees();
								double degrees2 = angle5.GetDegrees();
								Unit parentPlatform2 = this.ParentPlatform;
								double lat_ = degrees;
								double lon_ = degrees2;
								byte b = 0;
								bool bool_16 = true;
								bool flag3 = false;
								bool bool_17 = false;
								bool flag2 = false;
								float? nullable_3 = nullable_0.HasValue ? new float?((float)nullable_0.GetValueOrDefault()) : null;
								short? nullable_4 = null;
								List<ActiveUnit> list = null;
								if (!parentPlatform2.vmethod_41(lat_, lon_, ref b, bool_16, ref flag3, bool_17, ref flag2, nullable_3, nullable_4, ref list, float_3, false, false))
								{
									flag = true;
									result = true;
									return result;
								}
							}
							flag = (result = flag4);
							return result;
						}
						else
						{
							flag = false;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100468", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				flag = true;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x04002496 RID: 9366
		private Aircraft aircraft;
	}
}

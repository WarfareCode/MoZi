using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 0x020009D6 RID: 2518
	public sealed class Aircraft_AI : ActiveUnit_AI
	{
		// Token: 0x060049E3 RID: 18915 RVA: 0x001C02EC File Offset: 0x001BE4EC
		private Aircraft GetParentPlatform()
		{
			if (Information.IsNothing(this.ParentAircraft))
			{
				this.ParentAircraft = (Aircraft)this.m_ActiveUnit;
			}
			return this.ParentAircraft;
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x001C0324 File Offset: 0x001BE524
		public static Aircraft_AI Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_1, ref ActiveUnit activeUnit_1)
		{
			Aircraft_AI result;
			try
			{
				Aircraft_AI aircraft_AI = new Aircraft_AI(ref activeUnit_1);
				aircraft_AI.m_ActiveUnit = activeUnit_1;
				if (Operators.CompareString(xmlNode_0.ChildNodes[0].Name, "ActiveUnit_AI", false) == 0)
				{
					xmlNode_0 = xmlNode_0.ChildNodes[0];
				}
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1610968176u)
						{
							if (num <= 467450941u)
							{
								if (num <= 106934956u)
								{
									if (num != 94512562u)
									{
										if (num != 106934956u)
										{
											continue;
										}
										if (Operators.CompareString(name, "PrimaryTarget", false) != 0)
										{
											continue;
										}
									}
									else if (Operators.CompareString(name, "PTarget", false) != 0)
									{
										continue;
									}
									aircraft_AI.PrimaryTarget = Contact.GetContact(xmlNode.InnerText, ref dictionary_1);
									continue;
								}
								if (num != 357111700u)
								{
									if (num != 467450941u)
									{
										continue;
									}
									if (Operators.CompareString(name, "PrimaryThreat", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "IgnorePlottedCourse", false) != 0)
									{
										continue;
									}
									goto IL_4DD;
								}
							}
							else
							{
								if (num <= 864394351u)
								{
									if (num != 592141878u)
									{
										if (num == 864394351u && Operators.CompareString(name, "PThreat", false) == 0)
										{
											goto IL_179;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Threats", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator2.MoveNext())
											{
												XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
												Contact contact_ = Contact.Load(ref xmlNode2, ref dictionary_1);
												ScenarioArrayUtil.AddContact(ref aircraft_AI.Threats, contact_);
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
								}
								if (num != 987051924u)
								{
									if (num != 1474882803u)
									{
										if (num == 1610968176u && Operators.CompareString(name, "TTNPTE", false) == 0)
										{
											aircraft_AI.TimeToNextPrimaryTargetEvent = Conversions.ToShort(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "IE", false) == 0)
										{
											aircraft_AI.IsEscort = true;
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "AP", false) == 0)
									{
										aircraft_AI.SetAltitudePreset((ActiveUnit_AI._AltitudePreset)Conversions.ToByte(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							IL_179:
							aircraft_AI.PrimaryThreat = Contact.GetContact(xmlNode.InnerText, ref dictionary_1);
							continue;
						}
						if (num <= 2273311670u)
						{
							if (num <= 1966596370u)
							{
								if (num != 1925531877u)
								{
									if (num == 1966596370u && Operators.CompareString(name, "PrimaryTarget_LastKnown_Lon", false) == 0)
									{
										aircraft_AI.SetPrimaryTarget_LastKnown_Lon(XmlConvert.ToDouble(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "FerryCycleLegIsOutbound", false) != 0)
								{
									continue;
								}
							}
							else if (num != 2133975202u)
							{
								if (num != 2273311670u || Operators.CompareString(name, "FCLIO", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lat", false) == 0)
								{
									aircraft_AI.SetPrimaryTarget_LastKnown_Lat(XmlConvert.ToDouble(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							aircraft_AI.FerryCycleLegIsOutbound = Conversions.ToBoolean(xmlNode.InnerText);
							continue;
						}
						if (num <= 2722719197u)
						{
							if (num != 2276842832u)
							{
								if (num != 2722719197u)
								{
									continue;
								}
								if (Operators.CompareString(name, "PTOE", false) != 0)
								{
									continue;
								}
								goto IL_596;
							}
							else
							{
								if (Operators.CompareString(name, "TargetList", false) != 0)
								{
									continue;
								}
								IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
								try
								{
									while (enumerator3.MoveNext())
									{
										XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
										ActiveUnit_AI.TargetingEntry targetingEntry = ActiveUnit_AI.TargetingEntry.Load(ref xmlNode3, ref dictionary_1);
										if (!Information.IsNothing(targetingEntry.Target) && !aircraft_AI.GetTargetList().ContainsKey(targetingEntry.Target.GetGuid()))
										{
											aircraft_AI.GetTargetList().Add(targetingEntry.Target.GetGuid(), targetingEntry);
										}
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
						}
						if (num != 3761246852u)
						{
							if (num != 3957045325u)
							{
								if (num == 4076649232u && Operators.CompareString(name, "PrimaryTarget_LastKnown_Alt", false) == 0)
								{
									aircraft_AI.SetPrimaryTarget_LastKnown_Alt(XmlConvert.ToSingle(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "IPC", false) == 0)
								{
									goto IL_4DD;
								}
								continue;
							}
						}
						else if (Operators.CompareString(name, "PrimaryTargetOverrideExists", false) != 0)
						{
							continue;
						}
						IL_596:
						aircraft_AI.bPrimaryTargetOverride = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_4DD:
						bool flag = Conversions.ToBoolean(xmlNode.InnerText);
						if (!Information.IsNothing(activeUnit_1.m_Doctrine))
						{
							activeUnit_1.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(activeUnit_1.m_Scenario, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Conversions.ToBoolean(xmlNode.InnerText) ? Doctrine._IgnorePlottedCourseWhenAttacking.const_1 : Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
						}
						if (flag && !Information.IsNothing(activeUnit_1.GetAssignedMission(false)))
						{
							Mission assignedMission = activeUnit_1.GetAssignedMission(false);
							if (assignedMission.MissionClass == Mission._MissionClass.Patrol)
							{
								assignedMission.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(activeUnit_1.m_Scenario, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_1));
							}
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
				result = aircraft_AI;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100375", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Aircraft_AI(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x001C09B8 File Offset: 0x001BEBB8
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			try
			{
				if (!Information.IsNothing(this.GetPrimaryTarget()))
				{
					xmlWriter_0.WriteElementString("PrimaryTarget", this.GetPrimaryTarget().GetGuid());
				}
				if (!Information.IsNothing(this.PrimaryThreat))
				{
					xmlWriter_0.WriteElementString("PrimaryThreat", this.PrimaryThreat.GetGuid());
				}
				if (base.GetPrimaryTarget_LastKnown_Lat() != 0.0)
				{
					xmlWriter_0.WriteElementString("PrimaryTarget_LastKnown_Lat", XmlConvert.ToString(base.GetPrimaryTarget_LastKnown_Lat()));
				}
				if (base.GetPrimaryTarget_LastKnown_Lon() != 0.0)
				{
					xmlWriter_0.WriteElementString("PrimaryTarget_LastKnown_Lon", XmlConvert.ToString(base.GetPrimaryTarget_LastKnown_Lon()));
				}
				if (base.GetPrimaryTarget_LastKnown_Alt() != 0f)
				{
					xmlWriter_0.WriteElementString("PrimaryTarget_LastKnown_Alt", XmlConvert.ToString(base.GetPrimaryTarget_LastKnown_Alt()));
				}
				if (this.TimeToNextPrimaryTargetEvent != 0)
				{
					xmlWriter_0.WriteElementString("TTNPTE", this.TimeToNextPrimaryTargetEvent.ToString());
				}
				if (this.bPrimaryTargetOverride)
				{
					xmlWriter_0.WriteElementString("PTOE", this.bPrimaryTargetOverride.ToString());
				}
				if (this.FerryCycleLegIsOutbound)
				{
					xmlWriter_0.WriteElementString("FCLIO", this.FerryCycleLegIsOutbound.ToString());
				}
				xmlWriter_0.WriteElementString("AP", ((byte)this.GetAltitudePreset()).ToString());
				if (this.IsEscort)
				{
					xmlWriter_0.WriteElementString("IE", this.IsEscort.ToString());
				}
				if (!Information.IsNothing(this.LastKnownTargetLocation))
				{
					xmlWriter_0.WriteStartElement("LKTL");
					GeoPoint lastKnownTargetLocation = this.LastKnownTargetLocation;
					HashSet<string> hashSet = null;
					lastKnownTargetLocation.Save(ref xmlWriter_0, ref hashSet);
					xmlWriter_0.WriteEndElement();
				}
				if (this.GetTargetList().Count > 0)
				{
					xmlWriter_0.WriteStartElement("TargetList");
					foreach (ActiveUnit_AI.TargetingEntry current in this.GetTargetList().Values)
					{
						if (!Information.IsNothing(current.Target.ActualUnit))
						{
							current.Save(ref xmlWriter_0, this.m_ActiveUnit.GetSide(false));
							xmlWriter_0.Flush();
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (base.GetThreats().Length > 0)
				{
					xmlWriter_0.WriteStartElement("Threats");
					List<Contact> list = new List<Contact>();
					list.AddRange(this.Threats);
					foreach (Contact current2 in list)
					{
						if (!Information.IsNothing(current2))
						{
							current2.Save(ref xmlWriter_0, ref hashSet_1);
							xmlWriter_0.Flush();
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (!Information.IsNothing(this.SnakeAxis))
				{
					xmlWriter_0.WriteElementString("SnakeAxis", Conversions.ToString(this.SnakeAxis.Value));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100374", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x00023901 File Offset: 0x00021B01
		public Aircraft_AI(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}

		// Token: 0x060049E7 RID: 18919 RVA: 0x001C0D1C File Offset: 0x001BEF1C
		public override void EngagedDefensive(float elapsedTime_)
		{
			try
			{
				double num = Math.Round((double)Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.PrimaryThreat.GetLatitude(null), this.PrimaryThreat.GetLongitude(null)), 0);
				if (!double.IsNaN(num))
				{
					if (this.GetParentPlatform().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling)
					{
						this.GetParentPlatform().GetAircraftAirOps().A2ARefueling();
					}
					Contact_Base.ContactType contactType = this.PrimaryThreat.contactType;
					if (contactType == Contact_Base.ContactType.Missile)
					{
						base.RunPerpendicularTo((int)Math.Round(num));
						this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
						this.m_ActiveUnit.SetDesiredAltitude(0f);
					}
					Doctrine._JettisonOrdnance? jettisonOrdnanceDoctrine = this.GetParentPlatform().m_Doctrine.GetJettisonOrdnanceDoctrine(this.GetParentPlatform().m_Scenario, false, false, false);
					byte? b = jettisonOrdnanceDoctrine.HasValue ? new byte?((byte)jettisonOrdnanceDoctrine.GetValueOrDefault()) : null;
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						this.GetParentPlatform().GetAircraftWeaponry().JettisonExternalStores();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100376", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x001C0EE0 File Offset: 0x001BF0E0
		public override void ScheduleNextPrimaryTargetEvent(short short_1, bool bool_6)
		{
			try
			{
				if (!Information.IsNothing(this.m_ActiveUnit))
				{
					if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && !this.m_ActiveUnit.GetAssignedMission(false).IsActive())
					{
						this.SetPrimaryTarget(null);
					}
					else
					{
						if (!bool_6)
						{
							this.TimeToNextPrimaryTargetEvent -= short_1;
							if (this.TimeToNextPrimaryTargetEvent > 0)
							{
								return;
							}
							if (this.m_ActiveUnit.OODATargetingCycle == 0)
							{
								this.TimeToNextPrimaryTargetEvent = (short)GameGeneral.GetRandom().Next(10, 21);
							}
							else
							{
								this.TimeToNextPrimaryTargetEvent = (short)Math.Round(Math.Min(20.0, (double)((int)this.m_ActiveUnit.OODATargetingCycle * GameGeneral.GetRandom().Next(10, 21)) / 10.0));
							}
						}
						List<Contact> list = new List<Contact>();
						if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()) && this.GetParentPlatform().GetLoadout().loadoutRole == Loadout.LoadoutRole.AntiSatellite_Intercept)
						{
							list = base.GetTargets().Where(Aircraft_AI.OrbitalTargetFilter).ToList<Contact>();
						}
						else
						{
							list = base.GetTargets().Where(Aircraft_AI.ContactFunc1).ToList<Contact>();
						}
						if (list.Count != 0)
						{
							Collection<Contact> collection = new Collection<Contact>();
							if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()) && this.GetParentPlatform().GetLoadout().loadoutRole == Loadout.LoadoutRole.AntiSatellite_Intercept)
							{
								using (List<Contact>.Enumerator enumerator = list.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										Contact current = enumerator.Current;
										ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = base.GetTargetingBehavior(current);
										if (targetingBehavior != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
										{
											if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted && current.contactType == Contact_Base.ContactType.Orbital)
											{
												collection.Add(current);
											}
										}
										else if (current.contactType == Contact_Base.ContactType.Orbital && base.ShouldIShootTheTarget(ref current))
										{
											collection.Add(current);
										}
									}
									goto IL_2B7;
								}
							}

                            Contact current2X;
                            foreach (Contact current2 in list)
							{
                                current2X = current2;
                                ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior2 = base.GetTargetingBehavior(current2);
								if (targetingBehavior2 != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
								{
									if (targetingBehavior2 == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted && (current2.method_97() || current2.IsSurface() || current2.IsSubSurface() || current2.IsFacilityType()))
									{
										collection.Add(current2);
									}
								}
								else if ((current2.method_97() || current2.IsSurface() || current2.IsSubSurface() || current2.IsFacilityType()) && base.ShouldIShootTheTarget(ref current2X))
								{
									collection.Add(current2);
								}
							}
							IL_2B7:
							if (collection.Count > 0)
							{
								if (collection.Count == 1)
								{
									this.SetPrimaryTarget(collection[0]);
								}
								else
								{
									List<Contact> list2 = collection.Select(Aircraft_AI.ContactFunc2).OrderBy(new Func<Contact, double>(this.GetAngularDistance)).ToList<Contact>();
									this.SetPrimaryTarget(list2[0]);
								}
							}
							else if (Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
							{
								this.SetPrimaryTarget(null);
							}
							else
							{
								if (this.m_ActiveUnit.HasAssignedStrikeMission())
								{
									if (!this.m_ActiveUnit.GetAI().IsEscort)
									{
										Aircraft_AI.StrikeMissionAI strikeMissionAI = new Aircraft_AI.StrikeMissionAI(null);
										strikeMissionAI.aircraft_AI = this;
										strikeMissionAI.strikeMission = (Strike)this.m_ActiveUnit.GetAssignedMission(false);
										if (strikeMissionAI.strikeMission.SpecificTargets.Count > 0)
										{
											if (Information.IsNothing(this.GetPrimaryTarget()))
											{
												List<Contact> list3 = list.Where(new Func<Contact, bool>(strikeMissionAI.HasWeaponToAttackTarget)).OrderByDescending(new Func<Contact, GlobalVariables.TargetVisualSizeClass>(this.GetTargetVisualSizeClass)).ToList<Contact>();
												if (list3.Count > 0)
												{
													this.SetPrimaryTarget(list3[0]);
													return;
												}
											}
										}
										else if (strikeMissionAI.strikeMission.PrePlannedOnly && strikeMissionAI.strikeMission.SpecificTargets.Count == 0)
										{
											this.SetPrimaryTarget(null);
											return;
										}
										if (strikeMissionAI.strikeMission.strikeType == Strike.StrikeType.Air_Intercept)
										{
											Aircraft_AI.TargetMan targetMan = new Aircraft_AI.TargetMan(null);
											Contact contact = null;
											List<Contact> list4 = list.Select(Aircraft_AI.ContactFunc3).OrderBy(new Func<Contact, double>(this.GetAngularDistance)).ToList<Contact>();
											List<ActiveUnit> source = this.m_ActiveUnit.GetSide(false).ActiveUnitArray.ToList<ActiveUnit>();
											using (List<Contact>.Enumerator enumerator3 = list4.GetEnumerator())
											{
												while (enumerator3.MoveNext())
												{
													Aircraft_AI.DistanceMeasurer distanceMeasurer = new Aircraft_AI.DistanceMeasurer(null);
													distanceMeasurer._Target = enumerator3.Current;
													targetMan.TargetID = distanceMeasurer._Target.GetGuid();
													List<ActiveUnit> list5 = source.Where((targetMan.TargetFilterFunc == null) ? (targetMan.TargetFilterFunc = new Func<ActiveUnit, bool>(targetMan.IsTargetOf)) : targetMan.TargetFilterFunc).OrderBy(new Func<ActiveUnit, double>(distanceMeasurer.GetAngularDistance)).ToList<ActiveUnit>();
													if (list5.Count != 0)
													{
														if (list5[0] != this.m_ActiveUnit)
														{
															continue;
														}
														contact = distanceMeasurer._Target;
													}
													else
													{
														contact = distanceMeasurer._Target;
													}
													break;
												}
											}
											if (Information.IsNothing(contact))
											{
												List<Contact> list6;
												if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
												{
													list6 = list.AsParallel<Contact>().Select(Aircraft_AI.ContactFunc4).OrderBy(new Func<Contact, int>(this.method_115)).ThenBy(new Func<Contact, double>(this.GetAngularDistance)).ToList<Contact>();
												}
												else
												{
													list6 = list.Select(Aircraft_AI.ContactFunc6).OrderBy(new Func<Contact, double>(this.GetAngularDistance)).ToList<Contact>();
												}
												this.SetPrimaryTarget(list6[0]);
											}
											else
											{
												this.SetPrimaryTarget(contact);
											}
										}
										else if (Information.IsNothing(this.GetPrimaryTarget()))
										{
											List<Contact> list7 = list.Where(new Func<Contact, bool>(this.method_118)).OrderBy(new Func<Contact, double>(this.method_119)).ToList<Contact>();
											if (list7.Count > 0)
											{
												this.SetPrimaryTarget(list7[0]);
											}
										}
									}
									else
									{
										this.method_93(list);
									}
								}
								else if (this.m_ActiveUnit.HasAssignedPatrolMission())
								{
									GlobalVariables.PatrolType patrolType = ((Patrol)this.m_ActiveUnit.GetAssignedMission(false)).patrolType;
									if (patrolType == GlobalVariables.PatrolType.SEAD)
									{
										base.method_37();
									}
									else
									{
										Aircraft_AI.WeaponTargetMatcher weaponTargetMatcher = new Aircraft_AI.WeaponTargetMatcher(null);
										weaponTargetMatcher.aircraft_AI = this;
										weaponTargetMatcher.bool_0 = base.IsOnPatrolStation();
										IEnumerable<Contact> source2 = list.Where(new Func<Contact, bool>(weaponTargetMatcher.HasWeaponsToAttackTarget));
										if (source2.Count<Contact>() > 0)
										{
											List<Contact> list8;
											if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
											{
												list8 = source2.OrderBy(new Func<Contact, int>(this.method_120)).ThenBy(new Func<Contact, double>(this.method_121)).ToList<Contact>();
											}
											else
											{
												list8 = source2.OrderBy(new Func<Contact, double>(this.method_122)).ToList<Contact>();
											}
											this.SetPrimaryTarget(list8[0]);
										}
										else
										{
											List<Contact> list9;
											if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
											{
												list9 = list.Where(new Func<Contact, bool>(weaponTargetMatcher.IsTargetForAssignedMission)).OrderBy(new Func<Contact, int>(this.method_123)).ThenBy(new Func<Contact, double>(this.method_124)).ToList<Contact>();
											}
											else
											{
												list9 = list.Where(new Func<Contact, bool>(weaponTargetMatcher.IsTargetForMission)).OrderBy(new Func<Contact, double>(this.method_125)).ToList<Contact>();
											}
											if (list9.Count > 0)
											{
												this.SetPrimaryTarget(list9[0]);
											}
											else
											{
												this.SetPrimaryTarget(null);
											}
										}
									}
								}
								else if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
								{
									if (this.GetParentPlatform().GetLoadout().method_13())
									{
										Aircraft_AI.Class91 @class = new Aircraft_AI.Class91(null);
										Contact contact2 = null;
										List<Contact> list10 = list.Select(Aircraft_AI.ContactFunc7).OrderBy(new Func<Contact, double>(this.method_126)).ToList<Contact>();
										List<ActiveUnit> source3 = this.m_ActiveUnit.GetSide(false).ActiveUnitArray.ToList<ActiveUnit>();
										using (List<Contact>.Enumerator enumerator4 = list10.GetEnumerator())
										{
											while (enumerator4.MoveNext())
											{
												Aircraft_AI.Class92 class2 = new Aircraft_AI.Class92(null);
												class2.contact_0 = enumerator4.Current;
												@class.string_0 = class2.contact_0.GetGuid();
												List<ActiveUnit> list11 = source3.Where((@class.func_0 == null) ? (@class.func_0 = new Func<ActiveUnit, bool>(@class.method_0)) : @class.func_0).OrderBy(new Func<ActiveUnit, double>(class2.method_0)).ToList<ActiveUnit>();
												if (list11.Count != 0)
												{
													if (list11[0] != this.m_ActiveUnit)
													{
														continue;
													}
													contact2 = class2.contact_0;
												}
												else
												{
													contact2 = class2.contact_0;
												}
												break;
											}
										}
										if (Information.IsNothing(contact2))
										{
											List<Contact> list12;
											if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
											{
												list12 = list.AsParallel<Contact>().Select(Aircraft_AI.ContactFunc8).OrderBy(new Func<Contact, int>(this.method_127)).ThenBy(new Func<Contact, double>(this.method_128)).ToList<Contact>();
											}
											else
											{
												list12 = list.AsParallel<Contact>().Select(Aircraft_AI.ContactFunc10).OrderBy(new Func<Contact, double>(this.method_129)).ToList<Contact>();
											}
											this.SetPrimaryTarget(list12[0]);
										}
										else
										{
											this.SetPrimaryTarget(contact2);
										}
									}
									else
									{
										List<Contact> list13 = list.Where(Aircraft_AI.ContactFunc11).OrderByDescending(new Func<Contact, GlobalVariables.TargetVisualSizeClass>(this.method_130)).ToList<Contact>();
										if (list13.Count > 0)
										{
											this.SetPrimaryTarget(list13[0]);
										}
									}
								}
								if (!Information.IsNothing(this.m_ActiveUnit))
								{
									Collection<Contact> collection2 = new Collection<Contact>();
									foreach (Contact current3 in list)
									{
										if (base.GetThreats().Contains(current3) && this.m_ActiveUnit.GetSlantRange(current3, 0f) < 5f)
										{
											collection2.Add(current3);
										}
										if (collection2.Count == 1)
										{
											this.SetPrimaryTarget(collection2[0]);
										}
										double num = 20000.0;
										foreach (Contact current4 in collection2)
										{
											double num2 = (double)this.m_ActiveUnit.GetSlantRange(current4, 0f);
											if (num2 < num)
											{
												this.SetPrimaryTarget(current4);
												num = num2;
											}
										}
									}
									collection2 = null;
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
				ex2.Data.Add("Error at 100377", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060049E9 RID: 18921 RVA: 0x001C1B20 File Offset: 0x001BFD20
		private void method_89(double double_4, Doctrine._RefuelSelection RefuelSelection_)
		{
			if (!this.GetParentPlatform().IsNotGroupLead())
			{
				Doctrine._UseRefuel? useRefuelDoctrine = this.GetParentPlatform().m_Doctrine.GetUseRefuelDoctrine(this.GetParentPlatform().m_Scenario, false, false, false, false);
				byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
				if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && (this.GetParentPlatform().BoomRefuelling || this.GetParentPlatform().ProbeRefuelling))
				{
					try
					{
						float num = 3.40282347E+38f;
						ActiveUnit activeUnit = this.m_ActiveUnit;
						if (this.m_ActiveUnit.HasParentGroup())
						{
							foreach (ActiveUnit current in this.m_ActiveUnit.GetParentGroup(false).GetUnitsInGroup().Values)
							{
								if ((float)current.GetCurrentFuelQuantity() < num)
								{
									num = (float)current.GetCurrentFuelQuantity();
									activeUnit = current;
								}
							}
						}
						ActiveUnit activeUnit2 = activeUnit;
						double num2 = 0.0;
						double num3 = 0.0;
						if (activeUnit2.GetFuelLeft(ref num2, ref num3, true) < double_4)
						{
							GeoPoint intermediateTargetPoint = base.GetIntermediateTargetPoint();
							if (!Information.IsNothing(intermediateTargetPoint))
							{
								Aircraft_AirOps aircraftAirOps = this.GetParentPlatform().GetAircraftAirOps();
								GeoPoint geoPoint_ = intermediateTargetPoint;
								bool flag = false;
								ActiveUnit activeUnit3 = null;
								List<Mission> list = null;
								string text = "";
								bool flag2 = false;
								aircraftAirOps.method_78(geoPoint_, RefuelSelection_, ref flag, ref activeUnit3, ref list, ref text, ref flag2);
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100378", "");
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

		// Token: 0x060049EA RID: 18922 RVA: 0x001C1D2C File Offset: 0x001BFF2C
		public override void UpdateUnitStatus(float float_1, bool bool_6, bool bool_7)
		{
			try
			{
				if (!Information.IsNothing(this.m_ActiveUnit))
				{
					bool flag = base.IsOnPatrolStation();
					Aircraft_AirOps aircraftAirOps = this.GetParentPlatform().GetAircraftAirOps();
					if (aircraftAirOps.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.EmergencyLanding)
					{
						bool flag2 = false;
						if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
						{
							flag2 = true;
						}
						else if (this.m_ActiveUnit.IsNotGroupLead() && !Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()) && this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().HasWaypointOtherPathfindingPoint())
						{
							flag2 = true;
						}
						Doctrine._AutomaticEvasion? automaticEvasionDoctrine = this.m_ActiveUnit.m_Doctrine.GetAutomaticEvasionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
						byte? b = automaticEvasionDoctrine.HasValue ? new byte?((byte)automaticEvasionDoctrine.GetValueOrDefault()) : null;
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							if (!Information.IsNothing(this.PrimaryThreat))
							{
								if (Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) || this.m_ActiveUnit.GetAssignedMission(false).MissionClass != Mission._MissionClass.Strike || (!this.GetParentPlatform().GetAircraftNavigator().method_20() && (!this.m_ActiveUnit.IsNotGroupLead() || Information.IsNothing(this.m_ActiveUnit.IsGroupLead()) || !this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().method_20())))
								{
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
									return;
								}
							}
							else if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
							{
								this.m_ActiveUnit.SetUnitStatus(this.m_ActiveUnit.SBEngagedDefensive);
							}
						}
						if (this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && aircraftAirOps.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel)
						{
							if (this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Refuelling || aircraftAirOps.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.Refuelling)
							{
								if (aircraftAirOps.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown)
								{
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB_Manual);
								}
								else
								{
									if (this.m_ActiveUnit.m_Scenario.MinuteIsChangingOnThisPulse)
									{
										Unit activeUnit = this.m_ActiveUnit;
										double latitude = this.m_ActiveUnit.GetLatitude(null);
										double longitude = this.m_ActiveUnit.GetLongitude(null);
										byte b2 = 0;
										bool flag3 = true;
										bool flag4 = true;
										float? nullable_ = null;
										short? nullable_2 = null;
										List<ActiveUnit> list = null;
										if (!activeUnit.vmethod_41(latitude, longitude, ref b2, true, ref flag3, true, ref flag4, nullable_, nullable_2, ref list, 0f, false, true))
										{
											if (!this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
											{
												ActiveUnit_Navigator navigator = this.m_ActiveUnit.GetNavigator();
												double latitude2 = this.m_ActiveUnit.GetLatitude(null);
												double longitude2 = this.m_ActiveUnit.GetLongitude(null);
												list = null;
												Waypoint waypoint = navigator.method_6(latitude2, longitude2, ref list);
												if (!Information.IsNothing(waypoint))
												{
													ActiveUnit_Navigator navigator2 = this.m_ActiveUnit.GetNavigator();
													Waypoint[] plottedCourse = navigator2.GetPlottedCourse();
													ScenarioArrayUtil.InsertWayPoint(ref plottedCourse, 0, waypoint);
													navigator2.SetPlottedCourse(plottedCourse);
													this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
													return;
												}
											}
											else
											{
												Waypoint waypoint2 = this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0];
												if (waypoint2.waypointType != Waypoint.WaypointType.PathfindingPoint)
												{
													ActiveUnit_Navigator navigator3 = this.m_ActiveUnit.GetNavigator();
													double latitude3 = this.m_ActiveUnit.GetLatitude(null);
													double longitude3 = this.m_ActiveUnit.GetLongitude(null);
													list = null;
													Waypoint waypoint3 = navigator3.method_6(latitude3, longitude3, ref list);
													Unit activeUnit2 = this.m_ActiveUnit;
													double latitude4 = waypoint2.GetLatitude();
													double longitude4 = waypoint2.GetLongitude();
													b2 = 0;
													flag4 = true;
													flag3 = true;
													float? nullable_3 = null;
													short? nullable_4 = null;
													list = null;
													if (!activeUnit2.vmethod_41(latitude4, longitude4, ref b2, true, ref flag4, true, ref flag3, nullable_3, nullable_4, ref list, 0f, false, true))
													{
														ActiveUnit_Navigator navigator4 = this.m_ActiveUnit.GetNavigator();
														Waypoint[] plottedCourse = navigator4.GetPlottedCourse();
														ScenarioArrayUtil.InsertWayPoint(ref plottedCourse, 0, waypoint3);
														navigator4.SetPlottedCourse(plottedCourse);
														this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
														return;
													}
													if (this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(waypoint3) + 0.2 < this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(waypoint2))
													{
														ActiveUnit_Navigator navigator5 = this.m_ActiveUnit.GetNavigator();
														Waypoint[] plottedCourse = navigator5.GetPlottedCourse();
														ScenarioArrayUtil.InsertWayPoint(ref plottedCourse, 0, waypoint3);
														navigator5.SetPlottedCourse(plottedCourse);
													}
													this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
													return;
												}
											}
										}
									}
									if (this.m_ActiveUnit.m_Scenario.FifteenthSecondIsChangingOnThisPulse || bool_6)
									{
										if (this.GetParentPlatform().GetFuelState() != ActiveUnit._ActiveUnitFuelState.IgnoreBingoAndJoker && !this.m_ActiveUnit.GetNavigator().method_18() && !this.m_ActiveUnit.GetNavigator().method_24() && (!this.m_ActiveUnit.IsNotGroupLead() || Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()) || (!this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().method_18() && !this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().method_24())))
										{
											ActiveUnit._ActiveUnitFuelState fuelState = this.GetParentPlatform().GetFuelState(null);
											bool arg_5DA_0;
											if (this.GetParentPlatform().GetFuelState() != ActiveUnit._ActiveUnitFuelState.IsBingo)
											{
												if (this.GetParentPlatform().GetFuelState() != ActiveUnit._ActiveUnitFuelState.IsJoker)
												{
													arg_5DA_0 = true;
													goto IL_5DA;
												}
											}
											arg_5DA_0 = (aircraftAirOps.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue);
											IL_5DA:
											if (!arg_5DA_0)
											{
												bool flag5 = this.GetParentPlatform().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.RTB_Manual || this.GetParentPlatform().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.RTB_MissionOver || (this.GetParentPlatform().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.RTB && this.m_ActiveUnit.GetFuelState() == ActiveUnit._ActiveUnitFuelState.None) || this.GetParentPlatform().SBR == ActiveUnit._ActiveUnitStatus.RTB_Manual || this.GetParentPlatform().SBR == ActiveUnit._ActiveUnitStatus.RTB_MissionOver || (this.GetParentPlatform().SBR == ActiveUnit._ActiveUnitStatus.RTB && this.m_ActiveUnit.GetFuelState() == ActiveUnit._ActiveUnitFuelState.None);
												this.GetParentPlatform().SetFuelState(fuelState);
												if (!this.m_ActiveUnit.HasTrackingAndDirectingSensor() && !this.m_ActiveUnit.HasTerminalIlluminatorForGuidedWeaponsInAir())
												{
													GeoPoint intermediateTargetPoint = base.GetIntermediateTargetPoint();
													if (flag5)
													{
														Aircraft_AirOps aircraft_AirOps = aircraftAirOps;
														GeoPoint geoPoint_ = intermediateTargetPoint;
														bool flag3 = false;
														ActiveUnit activeUnit3 = null;
														List<Mission> list2 = null;
														string text = "";
														bool flag4 = true;
														if (aircraft_AirOps.method_78(geoPoint_, Doctrine._RefuelSelection.const_2, ref flag3, ref activeUnit3, ref list2, ref text, ref flag4))
														{
															return;
														}
													}
													else if (!Information.IsNothing(intermediateTargetPoint))
													{
														if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Ferry && this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne > 0)
														{
															float num = 3.40282347E+38f;
															ActiveUnit activeUnit4 = this.m_ActiveUnit;
															if (this.m_ActiveUnit.HasParentGroup())
															{
																foreach (ActiveUnit current in this.m_ActiveUnit.GetParentGroup(false).GetUnitsInGroup().Values)
																{
																	if ((float)current.GetCurrentFuelQuantity() < num)
																	{
																		num = (float)current.GetCurrentFuelQuantity();
																		activeUnit4 = current;
																	}
																}
															}
															ActiveUnit activeUnit5 = activeUnit4;
															double num2 = 0.0;
															double num3 = 0.0;
															if (activeUnit5.GetFuelLeft(ref num2, ref num3, true) > (double)((float)((double)this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne / 100.0)))
															{
																return;
															}
														}
														if (!this.m_ActiveUnit.GetNavigator().method_23() && (!this.m_ActiveUnit.IsNotGroupLead() || Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()) || !this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().method_23()))
														{
															Aircraft_AirOps aircraft_AirOps2 = aircraftAirOps;
															GeoPoint geoPoint_2 = intermediateTargetPoint;
															Doctrine._RefuelSelection value = this.m_ActiveUnit.m_Doctrine.GetRefuelSelectionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false, false).Value;
															bool flag4 = false;
															ActiveUnit activeUnit3 = null;
															List<Mission> list2 = null;
															string text = "";
															bool flag3 = false;
															if (aircraft_AirOps2.method_78(geoPoint_2, value, ref flag4, ref activeUnit3, ref list2, ref text, ref flag3))
															{
																return;
															}
														}
													}
													else if (this.GetParentPlatform().GetUnitStatus() != ActiveUnit._ActiveUnitStatus.RTB_Manual && this.GetParentPlatform().GetUnitStatus() != ActiveUnit._ActiveUnitStatus.RTB_MissionOver && this.GetParentPlatform().GetUnitStatus() != ActiveUnit._ActiveUnitStatus.RTB && this.GetParentPlatform().SBR != ActiveUnit._ActiveUnitStatus.RTB_MissionOver && this.GetParentPlatform().SBR != ActiveUnit._ActiveUnitStatus.RTB && this.GetParentPlatform().GetFuelState() != ActiveUnit._ActiveUnitFuelState.IsBingo && this.GetParentPlatform().GetFuelState() != ActiveUnit._ActiveUnitFuelState.IsJoker)
													{
														Aircraft_AirOps aircraft_AirOps3 = aircraftAirOps;
														GeoPoint geoPoint_3 = null;
														Doctrine._RefuelSelection value2 = this.m_ActiveUnit.m_Doctrine.GetRefuelSelectionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false, false).Value;
														bool flag3 = false;
														ActiveUnit activeUnit3 = null;
														List<Mission> list2 = null;
														string text = "";
														bool flag4 = false;
														if (aircraft_AirOps3.method_78(geoPoint_3, value2, ref flag3, ref activeUnit3, ref list2, ref text, ref flag4))
														{
															return;
														}
													}
													else
													{
														Aircraft_AirOps aircraft_AirOps4 = aircraftAirOps;
														GeoPoint geoPoint_4 = null;
														bool flag4 = false;
														ActiveUnit activeUnit3 = null;
														List<Mission> list2 = null;
														string text = "";
														bool flag3 = true;
														if (aircraft_AirOps4.method_78(geoPoint_4, Doctrine._RefuelSelection.const_2, ref flag4, ref activeUnit3, ref list2, ref text, ref flag3))
														{
															return;
														}
													}
													if ((aircraftAirOps.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.RTB || !this.m_ActiveUnit.IsRTB()) && !this.m_ActiveUnit.GetNavigator().method_25() && (!this.m_ActiveUnit.IsNotGroupLead() || Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()) || !this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().method_25()))
													{
														Doctrine._FuelStateRTB? bingoJokerRTBDoctrine = this.m_ActiveUnit.m_Doctrine.GetBingoJokerRTBDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
														if (!this.m_ActiveUnit.HasParentGroup())
														{
															b = (bingoJokerRTBDoctrine.HasValue ? new byte?((byte)bingoJokerRTBDoctrine.GetValueOrDefault()) : null);
															bool? flag6 = b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null;
															if ((flag6.HasValue ? new bool?(!flag6.GetValueOrDefault()) : flag6).GetValueOrDefault())
															{
																this.GetParentPlatform().GetAircraftAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
															}
														}
														else
														{
															b = (bingoJokerRTBDoctrine.HasValue ? new byte?((byte)bingoJokerRTBDoctrine.GetValueOrDefault()) : null);
															if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
															{
																this.GetParentPlatform().GetAircraftAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
															}
															else
															{
																b = (bingoJokerRTBDoctrine.HasValue ? new byte?((byte)bingoJokerRTBDoctrine.GetValueOrDefault()) : null);
																if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
																{
																	this.GetParentPlatform().GetAircraftAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB, true, ActiveUnit._ActiveUnitStatus.RTB_Group, false, true);
																}
																else
																{
																	b = (bingoJokerRTBDoctrine.HasValue ? new byte?((byte)bingoJokerRTBDoctrine.GetValueOrDefault()) : null);
																	if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
																	{
																		bool flag7 = true;
																		using (IEnumerator<ActiveUnit> enumerator2 = this.m_ActiveUnit.GetParentGroup(false).GetUnitsInGroup().Values.GetEnumerator())
																		{
																			while (enumerator2.MoveNext())
																			{
																				if (enumerator2.Current.GetFuelState() == ActiveUnit._ActiveUnitFuelState.None)
																				{
																					flag7 = false;
																					break;
																				}
																			}
																		}
																		if (flag7)
																		{
																			this.GetParentPlatform().GetAircraftAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB, true, ActiveUnit._ActiveUnitStatus.RTB_Group, false, true);
																		}
																	}
																}
															}
														}
														return;
													}
												}
											}
											else if (this.GetParentPlatform().GetFuelState() != fuelState)
											{
												this.GetParentPlatform().SetFuelState(fuelState);
											}
										}
										if (this.GetParentPlatform().GetAircraftNavigator().HasPlottedCourse() && this.GetParentPlatform().m_Scenario.MinuteIsChangingOnThisPulse)
										{
											if (this.m_ActiveUnit.GetNavigator().method_23())
											{
												float num4;
												if (!Information.IsNothing(this.GetParentPlatform().GetAssignedMission(false)))
												{
													if (this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne > 0)
													{
														num4 = (float)((double)this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne / 100.0);
													}
													else
													{
														num4 = 0f;
													}
												}
												else
												{
													num4 = 0.85f;
												}
												this.method_89((double)num4, this.m_ActiveUnit.m_Doctrine.GetRefuelSelectionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false, false).Value);
											}
											else if (this.GetParentPlatform().GetAircraftNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.PatrolStation)
											{
												float num5;
												if (!Information.IsNothing(this.GetParentPlatform().GetAssignedMission(false)))
												{
													if (this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne > 0)
													{
														num5 = (float)((double)this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne / 100.0);
													}
													else
													{
														num5 = 0f;
													}
												}
												else
												{
													num5 = 0.6f;
												}
												if (num5 > 0f)
												{
													this.method_89((double)num5, this.m_ActiveUnit.m_Doctrine.GetRefuelSelectionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false, false).Value);
												}
											}
										}
										if (this.IsEscort && this.m_ActiveUnit.IsRTB())
										{
											bool flag8 = false;
											bool flag9 = false;
											List<ActiveUnit> list3 = this.m_ActiveUnit.GetSide(false).ActiveUnitArray.ToList<ActiveUnit>();
											if (!Information.IsNothing(this.GetParentPlatform().GetAssignedMission(false)) && this.GetParentPlatform().GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike)
											{
												foreach (ActiveUnit current2 in list3)
												{
													if (!current2.IsGroup && !Information.IsNothing(current2.GetAssignedMission(false)) && current2.GetAssignedMission(false) == this.m_ActiveUnit.GetAssignedMission(false))
													{
														if (current2.IsOperating())
														{
															if (!current2.GetAI().IsEscort)
															{
																flag8 = true;
																break;
															}
														}
														else if (!current2.GetAI().IsEscort)
														{
															Aircraft_AirOps aircraftAirOps2 = ((Aircraft)current2).GetAircraftAirOps();
															if (aircraftAirOps2.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.Readying && aircraftAirOps2.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.TaxyingToPark && aircraftAirOps2.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown && aircraftAirOps2.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck)
															{
																flag9 = true;
															}
														}
													}
												}
											}
											if (!flag9 && !flag8)
											{
												this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
												this.vmethod_27(float_1);
											}
										}
									}
									if (this.m_ActiveUnit.IsRTB())
									{
										if (this.m_ActiveUnit.HasTrackingAndDirectingSensor())
										{
											this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
											return;
										}
										if (aircraftAirOps.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue && aircraftAirOps.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.RTB)
										{
											aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.RTB);
										}
									}
									if (!(aircraftAirOps.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar | aircraftAirOps.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.DeployingCargo))
									{
										if (this.GetParentPlatform().GetWeaponState() != ActiveUnit._ActiveUnitWeaponState.IgnoreWinchesterAndShotgun)
										{
											ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState = this.GetParentPlatform().GetAircraftWeaponry().vmethod_3();
											if (activeUnitWeaponState != ActiveUnit._ActiveUnitWeaponState.IsWinchester && activeUnitWeaponState != ActiveUnit._ActiveUnitWeaponState.IsShotgun)
											{
												if (this.m_ActiveUnit.m_Scenario.MinuteIsChangingOnThisPulse && this.m_ActiveUnit.GetNavigator().method_22())
												{
													Doctrine._UseRefuel? useRefuelDoctrine = this.GetParentPlatform().m_Doctrine.GetUseRefuelDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false, false);
													b = (useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null);
													bool? flag6 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
													if ((flag6.HasValue ? new bool?(!flag6.GetValueOrDefault()) : flag6).GetValueOrDefault())
													{
														Aircraft_Navigator aircraft_Navigator = (Aircraft_Navigator)this.m_ActiveUnit.GetNavigator();
														ActiveUnit.Throttle throttle = aircraft_Navigator.method_62();
														bool flag4 = false;
														float transitAltitude = aircraft_Navigator.GetTransitAltitude(ref flag4);
														float num6 = 3.40282347E+38f;
														ActiveUnit activeUnit6 = this.m_ActiveUnit;
														if (this.m_ActiveUnit.HasParentGroup())
														{
															foreach (ActiveUnit current3 in this.m_ActiveUnit.GetParentGroup(false).GetUnitsInGroup().Values)
															{
																if ((float)current3.GetCurrentFuelQuantity() < num6)
																{
																	num6 = (float)current3.GetCurrentFuelQuantity();
																	activeUnit6 = current3;
																}
															}
														}
														ActiveUnit assignedHostUnit = ((Aircraft_AirOps)activeUnit6.GetAirOps()).GetAssignedHostUnit();
														if (!Information.IsNothing(assignedHostUnit) && (double)activeUnit6.GetKinematics().method_6(activeUnit6.GetHorizontalRange(assignedHostUnit), throttle, transitAltitude, new float?((float)activeUnit6.GetKinematics().GetSpeed(transitAltitude, throttle)), false, false) > (double)((float)activeUnit6.GetCurrentFuelQuantity() - activeUnit6.GetKinematics().GetReserveFuel()) * 0.9)
														{
															float num7;
															if (!Information.IsNothing(this.GetParentPlatform().GetAssignedMission(false)))
															{
																if (this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne > 0)
																{
																	num7 = (float)((double)this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne / 100.0);
																}
																else
																{
																	num7 = 0f;
																}
															}
															else
															{
																num7 = 0.85f;
															}
															if (num7 > 0f)
															{
																this.method_89((double)num7, this.m_ActiveUnit.m_Doctrine.GetRefuelSelectionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false, false).Value);
															}
														}
													}
												}
												if (this.GetParentPlatform().GetWeaponState() != activeUnitWeaponState)
												{
													this.GetParentPlatform().SetWeaponState(activeUnitWeaponState);
												}
											}
											else
											{
												this.m_ActiveUnit.SetWeaponState(activeUnitWeaponState);
												if (!this.m_ActiveUnit.HasTrackingAndDirectingSensor() && !this.m_ActiveUnit.HasTerminalIlluminatorForGuidedWeaponsInAir())
												{
													if (this.m_ActiveUnit.GetNavigator().method_19())
													{
														this.m_ActiveUnit.GetNavigator().vmethod_5();
														this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
														return;
													}
													if (this.m_ActiveUnit.GetNavigator().method_21())
													{
														if (this.m_ActiveUnit.GetNavigator().method_22() && this.m_ActiveUnit.m_Scenario.MinuteIsChangingOnThisPulse)
														{
															bool? flag6;
															bool? flag10;
															if (Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
															{
																flag10 = new bool?(false);
															}
															else
															{
																Doctrine._UseRefuel? useRefuelDoctrine = this.GetParentPlatform().m_Doctrine.GetUseRefuelDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false, false);
																b = (useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null);
																flag6 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null);
																flag10 = (flag6.HasValue ? new bool?(!flag6.GetValueOrDefault()) : flag6);
															}
															flag6 = flag10;
															if (flag6.GetValueOrDefault())
															{
																ActiveUnit.Throttle throttle2 = this.GetParentPlatform().GetAircraftNavigator().method_62();
																Aircraft_Navigator aircraftNavigator = this.GetParentPlatform().GetAircraftNavigator();
																bool flag3 = false;
																float transitAltitude2 = aircraftNavigator.GetTransitAltitude(ref flag3);
																float num8 = 3.40282347E+38f;
																Aircraft aircraft = this.GetParentPlatform();
																if (this.m_ActiveUnit.HasParentGroup())
																{
																	foreach (ActiveUnit current4 in this.m_ActiveUnit.GetParentGroup(false).GetUnitsInGroup().Values)
																	{
																		if ((float)current4.GetCurrentFuelQuantity() < num8)
																		{
																			num8 = (float)current4.GetCurrentFuelQuantity();
																			aircraft = (Aircraft)current4;
																		}
																	}
																}
																ActiveUnit assignedHostUnit2 = aircraft.GetAircraftAirOps().GetAssignedHostUnit();
																if (!Information.IsNothing(assignedHostUnit2) && (double)aircraft.GetAircraftKinematics().method_6(aircraft.GetHorizontalRange(assignedHostUnit2), throttle2, transitAltitude2, new float?((float)aircraft.GetAircraftKinematics().GetSpeed(transitAltitude2, throttle2)), false, false) > (double)((float)aircraft.GetCurrentFuelQuantity() - aircraft.GetAircraftKinematics().GetReserveFuel()) * 0.9)
																{
																	GeoPoint intermediateTargetPoint2 = base.GetIntermediateTargetPoint();
																	Aircraft_AirOps aircraft_AirOps5 = aircraftAirOps;
																	GeoPoint geoPoint_5 = intermediateTargetPoint2;
																	Doctrine._RefuelSelection value3 = this.m_ActiveUnit.m_Doctrine.GetRefuelSelectionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false, false).Value;
																	flag3 = false;
																	ActiveUnit activeUnit3 = null;
																	List<Mission> list2 = null;
																	string text = "";
																	bool flag4 = true;
																	if (aircraft_AirOps5.method_78(geoPoint_5, value3, ref flag3, ref activeUnit3, ref list2, ref text, ref flag4))
																	{
																		return;
																	}
																}
															}
														}
														this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
														return;
													}
													if (this.m_ActiveUnit.IsNotGroupLead() && !Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()) && this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().method_25())
													{
														Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.m_ActiveUnit.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
														b = (ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null);
														if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
														{
															this.m_ActiveUnit.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
														}
														if (!Information.IsNothing(this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride()))
														{
															this.m_ActiveUnit.GetKinematics().SetDesiredSpeedOverride(null);
														}
														if (this.m_ActiveUnit.GetKinematics().GetSpeedPreset() != ActiveUnit_Kinematics._SpeedPreset.None)
														{
															this.m_ActiveUnit.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.None);
														}
														if (Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()) || this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
														{
															this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
															return;
														}
													}
													else if (aircraftAirOps.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.RTB || (!this.m_ActiveUnit.IsRTB() && this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Refuelling))
													{
														Doctrine._WeaponStateRTB? winchesterShotgunRTBDoctrine = this.m_ActiveUnit.m_Doctrine.GetWinchesterShotgunRTBDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
														if (!this.m_ActiveUnit.HasParentGroup())
														{
															b = (winchesterShotgunRTBDoctrine.HasValue ? new byte?((byte)winchesterShotgunRTBDoctrine.GetValueOrDefault()) : null);
															bool? flag6 = b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null;
															if ((flag6.HasValue ? new bool?(!flag6.GetValueOrDefault()) : flag6).GetValueOrDefault() && this.GetParentPlatform().GetAircraftAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true))
															{
																return;
															}
														}
														else
														{
															b = (winchesterShotgunRTBDoctrine.HasValue ? new byte?((byte)winchesterShotgunRTBDoctrine.GetValueOrDefault()) : null);
															if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
															{
																if (this.GetParentPlatform().GetAircraftAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true))
																{
																	return;
																}
															}
															else
															{
																b = (winchesterShotgunRTBDoctrine.HasValue ? new byte?((byte)winchesterShotgunRTBDoctrine.GetValueOrDefault()) : null);
																if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
																{
																	if (this.GetParentPlatform().GetAircraftAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB, true, ActiveUnit._ActiveUnitStatus.RTB_Group, false, true))
																	{
																		return;
																	}
																}
																else
																{
																	b = (winchesterShotgunRTBDoctrine.HasValue ? new byte?((byte)winchesterShotgunRTBDoctrine.GetValueOrDefault()) : null);
																	if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
																	{
																		bool flag11 = true;
																		foreach (ActiveUnit current5 in this.m_ActiveUnit.GetParentGroup(false).GetUnitsInGroup().Values)
																		{
																			if (current5.GetWeaponState() == ActiveUnit._ActiveUnitWeaponState.None || current5.GetWeaponState() == ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO || current5.GetWeaponState() == ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO)
																			{
																				flag11 = false;
																				break;
																			}
																		}
																		if (flag11 && this.GetParentPlatform().GetAircraftAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB, true, ActiveUnit._ActiveUnitStatus.RTB_Group, false, true))
																		{
																			return;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
										if (!this.m_ActiveUnit.IsRTB())
										{
											if (this.m_ActiveUnit.GetAI().GetPrimaryTarget() == null && aircraftAirOps.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.BVRAttack)
											{
												aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
												this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
											}
											if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
											{
												if (!Information.IsNothing(this.GetPrimaryTarget()))
												{
													Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.m_ActiveUnit.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
													b = (ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null);
													if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
													{
														ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
														Contact primaryTarget = this.GetPrimaryTarget();
														Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
														string text = "";
														int num9 = 0;
														if (weaponry.HasWeaponsInConditionToAttackTarget(primaryTarget, true, doctrine, ref text, ref num9, null))
														{
															if (this.GetParentPlatform().HasAssignedPatrolMission())
															{
																Doctrine._ShootTourists? shootTouristsDoctrine = this.m_ActiveUnit.m_Doctrine.GetShootTouristsDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
																Contact primaryTarget2 = this.GetPrimaryTarget();
																Mission assignedMission = this.GetParentPlatform().GetAssignedMission(false);
																Doctrine._ShootTourists? shootTourists = shootTouristsDoctrine;
																bool onPatrolStation_ = flag;
																text = "";
																num9 = 0;
																if (base.IsTargetForMission(primaryTarget2, assignedMission, shootTourists, false, onPatrolStation_, true, ref text, ref num9))
																{
																	this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
																}
																else
																{
																	this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPatrol);
																}
															}
															else
															{
																this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
															}
														}
														else if (this.GetParentPlatform().HasAssignedPatrolMission())
														{
															if (this.GetPrimaryTarget().GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass)
															{
																this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
															}
															else
															{
																this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPatrol);
															}
														}
														return;
													}
												}
												if (!Information.IsNothing(this.GetPrimaryTarget()) && this.m_ActiveUnit.GetNavigator().method_20())
												{
													this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												}
												else if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol && !Information.IsNothing(this.GetPrimaryTarget()))
												{
													this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												}
												else if (aircraftAirOps.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel)
												{
													this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
												}
												else if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse() && this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.Assemble && this.m_ActiveUnit.HasParentGroup() && this.m_ActiveUnit.GetParentGroup(false).method_138())
												{
													this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.FormingUp);
												}
												else
												{
													this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
												}
											}
											else
											{
												if (this.m_ActiveUnit.HasParentGroup() && !Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()))
												{
													if (this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
													{
														if (this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
														{
															this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
														}
														return;
													}
													if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
													{
														this.m_ActiveUnit.SetUnitStatus(this.m_ActiveUnit.SBR);
													}
													else if (this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling)
													{
														if (this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Refuelling)
														{
															ActiveUnit activeUnit7 = this.m_ActiveUnit;
															double num3 = 0.0;
															double num2 = 0.0;
															if (activeUnit7.GetFuelLeft(ref num3, ref num2, false) < 0.95)
															{
																this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
															}
														}
														return;
													}
												}
												if (this.m_ActiveUnit.HasParentGroup())
												{
													if (this.m_ActiveUnit.GetParentGroup(false).GetGroupType() == Group.GroupType.AirGroup && this.m_ActiveUnit.GetParentGroup(false).method_138())
													{
														this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.FormingUp);
														return;
													}
													if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.FormingUp)
													{
														this.TargetingContacts(float_1, false, true);
													}
												}
												if (this.m_ActiveUnit.GetAssignedMission(false) != null && this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.RTB_MissionOver && this.m_ActiveUnit.GetAssignedMission(false).IsActive())
												{
													switch (this.m_ActiveUnit.GetAssignedMission(false).MissionClass)
													{
													case Mission._MissionClass.Strike:
														if (this.GetTargetList().Count == 0)
														{
															if (this.IsEscort)
															{
																List<Aircraft> list4 = new List<Aircraft>();
																List<ActiveUnit> list5 = this.m_ActiveUnit.GetSide(false).ActiveUnitArray.ToList<ActiveUnit>();
																foreach (ActiveUnit current6 in list5)
																{
																	if (current6.IsAircraft && current6 != this.GetParentPlatform() && !Information.IsNothing(current6.GetAssignedMission(false)) && current6.GetAssignedMission(false) == this.GetParentPlatform().GetAssignedMission(false) && !current6.GetAI().IsEscort)
																	{
																		if (current6.IsOperating())
																		{
																			list4.Add((Aircraft)current6);
																		}
																		else if (((Aircraft)current6).GetAircraftAirOps().method_24())
																		{
																			list4.Add((Aircraft)current6);
																		}
																	}
																}
																if (list4.Count > 0)
																{
																	if (this.m_ActiveUnit.m_Scenario.MinuteIsChangingOnThisPulse)
																	{
																		Doctrine._RefuelSelection refuelSelection = Doctrine._RefuelSelection.const_1;
																		bool flag12 = false;
																		GeoPoint geoPoint = null;
																		foreach (Aircraft current7 in list4)
																		{
																			if (!current7.GetAircraftAI().IsEscort)
																			{
																				if (current7.IsGroupLead() || !current7.HasParentGroup())
																				{
																					if (!current7.GetAircraftNavigator().method_23())
																					{
																						refuelSelection = Doctrine._RefuelSelection.const_2;
																					}
																					else if (Information.IsNothing(geoPoint))
																					{
																						geoPoint = current7.GetAircraftAI().GetIntermediateTargetPoint();
																					}
																					if (current7.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || current7.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling)
																					{
																						flag12 = true;
																					}
																				}
																				if (flag12 && refuelSelection == Doctrine._RefuelSelection.const_2)
																				{
																					break;
																				}
																			}
																		}
																		if (flag12 && this.GetParentPlatform().m_Doctrine.GetUseRefuelDoctrine(this.GetParentPlatform().m_Scenario, false, false, false, false).Value != Doctrine._UseRefuel.const_1)
																		{
																			Aircraft_AirOps aircraft_AirOps6 = aircraftAirOps;
																			GeoPoint geoPoint_6 = geoPoint;
																			Doctrine._RefuelSelection refuelSelection_ = refuelSelection;
																			bool flag4 = false;
																			ActiveUnit activeUnit3 = null;
																			List<Mission> list2 = null;
																			string text = "";
																			bool flag3 = false;
																			if (aircraft_AirOps6.method_78(geoPoint_6, refuelSelection_, ref flag4, ref activeUnit3, ref list2, ref text, ref flag3))
																			{
																				return;
																			}
																		}
																	}
																	this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
																}
																else
																{
																	this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
																}
															}
															else if (!flag2)
															{
																this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
															}
															else
															{
																this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
															}
														}
														else if (this.IsEscort)
														{
															if (Information.IsNothing(this.GetPrimaryTarget()))
															{
																List<Aircraft> list6 = new List<Aircraft>();
																List<ActiveUnit> list7 = this.m_ActiveUnit.GetSide(false).ActiveUnitArray.ToList<ActiveUnit>();
																foreach (ActiveUnit current8 in list7)
																{
																	if (current8.IsAircraft && current8 != this.GetParentPlatform() && !Information.IsNothing(current8.GetAssignedMission(false)) && current8.GetAssignedMission(false) == this.GetParentPlatform().GetAssignedMission(false) && !current8.GetAI().IsEscort)
																	{
																		if (current8.IsOperating())
																		{
																			list6.Add((Aircraft)current8);
																		}
																		else if (((Aircraft)current8).GetAircraftAirOps().method_24())
																		{
																			list6.Add((Aircraft)current8);
																		}
																	}
																}
																if (this.m_ActiveUnit.m_Scenario.MinuteIsChangingOnThisPulse)
																{
																	Doctrine._RefuelSelection refuelSelection2 = Doctrine._RefuelSelection.const_1;
																	bool flag13 = false;
																	GeoPoint geoPoint2 = null;
																	foreach (Aircraft current9 in list6)
																	{
																		if (!current9.GetAircraftAI().IsEscort)
																		{
																			if (current9.IsGroupLead() || !current9.HasParentGroup())
																			{
																				if (!current9.GetAircraftNavigator().method_23())
																				{
																					refuelSelection2 = Doctrine._RefuelSelection.const_2;
																				}
																				else if (Information.IsNothing(geoPoint2))
																				{
																					geoPoint2 = current9.GetAircraftAI().GetIntermediateTargetPoint();
																				}
																				if (current9.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || current9.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling)
																				{
																					flag13 = true;
																				}
																			}
																			if (flag13 && refuelSelection2 == Doctrine._RefuelSelection.const_2)
																			{
																				break;
																			}
																		}
																	}
																	if (flag13 && this.GetParentPlatform().m_Doctrine.GetUseRefuelDoctrine(this.GetParentPlatform().m_Scenario, false, false, false, false).Value != Doctrine._UseRefuel.const_1)
																	{
																		Aircraft_AirOps aircraft_AirOps7 = aircraftAirOps;
																		GeoPoint geoPoint_7 = geoPoint2;
																		Doctrine._RefuelSelection refuelSelection_2 = refuelSelection2;
																		bool flag3 = false;
																		ActiveUnit activeUnit3 = null;
																		List<Mission> list2 = null;
																		string text = "";
																		bool flag4 = false;
																		if (aircraft_AirOps7.method_78(geoPoint_7, refuelSelection_2, ref flag3, ref activeUnit3, ref list2, ref text, ref flag4))
																		{
																			return;
																		}
																	}
																}
																this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
															}
															else
															{
																this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
															}
														}
														else if (!flag2)
														{
															Aircraft_AI.StrikeTargetMan strikeTargetMan = new Aircraft_AI.StrikeTargetMan(null);
															strikeTargetMan.strikeMission = (Strike)this.m_ActiveUnit.GetAssignedMission(false);
															if (strikeTargetMan.strikeMission.SpecificTargets.Count > 0)
															{
																List<Contact> list8 = new List<Contact>();
																list8.AddRange(base.GetTargets());
																if (list8.Where(new Func<Contact, bool>(strikeTargetMan.IsSpecificTargetForStikeMission)).ToList<Contact>().Count == 0)
																{
																	this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
																	return;
																}
															}
															else
															{
																if (strikeTargetMan.strikeMission.PrePlannedOnly && strikeTargetMan.strikeMission.SpecificTargets.Count == 0)
																{
																	this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
																	return;
																}
																if (!Information.IsNothing(this.GetPrimaryTarget()))
																{
																	bool flag14 = false;
																	Doctrine._ShootTourists? shootTourists = this.m_ActiveUnit.m_Doctrine.GetShootTouristsDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
																	Contact primaryTarget2 = this.GetPrimaryTarget();
																	Mission assignedMission = this.GetParentPlatform().GetAssignedMission(false);
																	Doctrine._ShootTourists? shootTouristsDoc_ = shootTourists;
																	bool onPatrolStation_2 = flag;
																	string text = "";
																	int num9 = 0;
																	if (base.IsTargetForMission(primaryTarget2, assignedMission, shootTouristsDoc_, true, onPatrolStation_2, true, ref text, ref num9))
																	{
																		flag14 = true;
																	}
																	if (!flag14)
																	{
																		this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
																		return;
																	}
																}
															}
															Weapon weapon = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), true, true, this.m_ActiveUnit.m_Doctrine);
															if (!Information.IsNothing(weapon))
															{
																double num10 = (double)weapon.GetMaxRangeToTarget(this.m_ActiveUnit, this.GetPrimaryTarget(), false, null, false);
																double num11 = (double)this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
																if (num10 * 2.0 > num11)
																{
																	this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
																	return;
																}
															}
															this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
														}
														else if (!Information.IsNothing(this.GetPrimaryTarget()) && this.GetParentPlatform().HasParentGroup() && !Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()) && (this.GetParentPlatform().GetParentGroup(false).GetGroupLead().GetNavigator().method_20() || this.GetParentPlatform().GetParentGroup(false).GetGroupLead().GetNavigator().method_21()))
														{
															this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
														}
														else
														{
															this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
														}
														if (this.m_ActiveUnit.m_Scenario.MinuteIsChangingOnThisPulse && this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne > 0)
														{
															this.method_89((double)((float)((double)this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne / 100.0)), this.m_ActiveUnit.m_Doctrine.GetRefuelSelectionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false, false).Value);
														}
														return;
													case Mission._MissionClass.Patrol:
														if (!Information.IsNothing(this.GetPrimaryTarget()))
														{
															ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
															Contact primaryTarget3 = this.GetPrimaryTarget();
															Doctrine doctrine2 = this.m_ActiveUnit.m_Doctrine;
															string text = "";
															int num9 = 0;
															if (weaponry.HasWeaponsInConditionToAttackTarget(primaryTarget3, true, doctrine2, ref text, ref num9, null))
															{
																this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
															}
															else
															{
																this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPatrol);
															}
														}
														else
														{
															this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPatrol);
														}
														if (this.m_ActiveUnit.m_Scenario.MinuteIsChangingOnThisPulse && this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne > 0)
														{
															this.method_89((double)((float)((double)this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne / 100.0)), this.m_ActiveUnit.m_Doctrine.GetRefuelSelectionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false, false).Value);
														}
														return;
													case Mission._MissionClass.Support:
														if (!Information.IsNothing(this.GetPrimaryTarget()))
														{
															Doctrine._ShootTourists? shootTouristsDoctrine2 = this.m_ActiveUnit.m_Doctrine.GetShootTouristsDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
															b = (shootTouristsDoctrine2.HasValue ? new byte?((byte)shootTouristsDoctrine2.GetValueOrDefault()) : null);
															if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
															{
																this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
																return;
															}
														}
														if (this.m_ActiveUnit.GetNavigator().method_10(float_1))
														{
															this.GetParentPlatform().GetAircraftAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, false, true);
														}
														else
														{
															this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnSupportMission);
														}
														if (this.m_ActiveUnit.m_Scenario.MinuteIsChangingOnThisPulse && this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne > 0)
														{
															this.method_89((double)((float)((double)this.m_ActiveUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne / 100.0)), this.m_ActiveUnit.m_Doctrine.GetRefuelSelectionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false, false).Value);
														}
														return;
													case Mission._MissionClass.Ferry:
													{
														if (!Information.IsNothing(this.GetPrimaryTarget()))
														{
															Doctrine._ShootTourists? shootTouristsDoctrine2 = this.m_ActiveUnit.m_Doctrine.GetShootTouristsDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
															b = (shootTouristsDoctrine2.HasValue ? new byte?((byte)shootTouristsDoctrine2.GetValueOrDefault()) : null);
															if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
															{
																this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
																return;
															}
														}
														ActiveUnit activeUnit5 = this.GetParentPlatform().GetAircraftAirOps().GetAssignedHostUnit();
														if (this.GetParentPlatform().GetAircraftNavigator().method_66(activeUnit5))
														{
															this.GetParentPlatform().GetAircraftAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
														}
														else
														{
															this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnFerryMission);
														}
														return;
													}
													case Mission._MissionClass.Mining:
														this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
														return;
													case Mission._MissionClass.MineClearing:
														this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
														return;
													case Mission._MissionClass.Cargo:
														this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
														return;
													}
												}
												if (!Information.IsNothing(this.GetPrimaryTarget()))
												{
													this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												}
												else if (this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
												{
													if (this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Unassigned)
													{
														this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
													}
												}
											}
										}
									}
								}
							}
						}
						else if (this.m_ActiveUnit.IsNotGroupLead() && !Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()) && this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Refuelling)
						{
							this.m_ActiveUnit.SetUnitStatus(this.m_ActiveUnit.SBR);
							aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
						}
						else
						{
							this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200344", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060049EB RID: 18923 RVA: 0x001C4AD8 File Offset: 0x001C2CD8
		public ActiveUnit_AI._AltitudePreset GetAltitudePreset()
		{
			return this.altitudePreset;
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x0002390B File Offset: 0x00021B0B
		public void SetAltitudePreset(ActiveUnit_AI._AltitudePreset preset_)
		{
			this.altitudePreset = preset_;
			if (preset_ != ActiveUnit_AI._AltitudePreset.None)
			{
				this.m_ActiveUnit.GetKinematics().SetDesiredAltitudeOverride(true);
			}
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x001C4AF0 File Offset: 0x001C2CF0
		public override void ThreatAssessment()
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && !Information.IsNothing(this.m_ActiveUnit.GetSide(false)))
			{
				base.AddThreats();
				this.m_ActiveUnit.GetSide(false);
				List<Contact> contactList = this.m_ActiveUnit.GetSensory().GetContactList();
				try
				{
					foreach (Contact current in contactList)
					{
						try
						{
							if (this.IsThreatToMe(current))
							{
								this.AddThreat(current);
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 100381", "");
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 100382", "");
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060049EE RID: 18926 RVA: 0x001C4C2C File Offset: 0x001C2E2C
		private Weapon[] GetAvailableWeapons()
		{
			return this.m_ActiveUnit.GetWeaponry().GetAvailableWeapons(false);
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x001C4C4C File Offset: 0x001C2E4C
		private void method_93(List<Contact> targets_)
		{
			List<Contact> list;
			if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
			{
				list = targets_.Where(new Func<Contact, bool>(this.method_131)).OrderBy(new Func<Contact, double>(this.method_132)).ToList<Contact>();
			}
			else
			{
				list = targets_.Where(Aircraft_AI.ContactFunc12).OrderByDescending(new Func<Contact, GlobalVariables.TargetVisualSizeClass>(this.method_133)).ToList<Contact>();
			}
			if (list.Count > 0)
			{
				this.SetPrimaryTarget(list[0]);
			}
			else
			{
				this.SetPrimaryTarget(null);
			}
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x001C4CDC File Offset: 0x001C2EDC
		public override void TargetingContacts(float float_1, bool bool_6, bool bool_7)
		{
			if (!Information.IsNothing(this.m_ActiveUnit))
			{
				Side side = this.m_ActiveUnit.GetSide(false);
				try
				{
					checked
					{
						if (this.m_ActiveUnit.m_Mounts.Length == 0 && this.m_ActiveUnit.GetAllNoneMCMSensors().Length == 0 && (Information.IsNothing(this.GetParentPlatform().GetLoadout()) || this.GetParentPlatform().GetLoadout().WeaponRecArray.Length == 0))
						{
							if (!Information.IsNothing(this.GetPrimaryTarget()))
							{
								this.DropTargeting(this.GetPrimaryTarget(), true);
							}
							if (base.GetTargets().Length <= 0)
							{
								goto IL_9CF;
							}
							Collection<Contact> collection = new Collection<Contact>();
							Contact[] targets = base.GetTargets();
							for (int i = 0; i < targets.Length; i++)
							{
								Contact item = targets[i];
								collection.Add(item);
							}
							using (IEnumerator<Contact> enumerator = collection.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									Contact current = enumerator.Current;
									this.DropTargeting(current, true);
								}
								goto IL_9CF;
							}
						}
						base.TargetingContacts(float_1, bool_6, bool_7);
					}
					if (!Information.IsNothing(this.m_ActiveUnit))
					{
						Mission assignedMission = this.m_ActiveUnit.GetAssignedMission(false);
						Contact[] targets2 = base.GetTargets();
						bool flag = base.IsOnPatrolStation();
						List<Contact> list = new List<Contact>();
						if (side.NoNavZoneList.Count > 0)
						{
							for (int j = targets2.Length - 1; j >= 0; j += -1)
							{
								Contact contact = targets2[j];
								if (!Information.IsNothing(contact) && (side.GetQuantityToFireForTheTarget(ref this.m_ActiveUnit, ref contact) <= 0 || base.GetTargetingBehavior(contact) != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc))
								{
									foreach (NoNavZone current2 in side.NoNavZoneList.Where(new Func<NoNavZone, bool>(this.method_134)))
									{
										if (current2.Area.Count != 0 && contact.vmethod_40(current2.Area, this.m_ActiveUnit.m_Scenario, true))
										{
											list.Add(contact);
										}
									}
								}
							}
							foreach (Contact current3 in list)
							{
								this.DropTargeting(current3, true);
							}
						}
						Lazy<Weapon[]> lazy = new Lazy<Weapon[]>(new Func<Weapon[]>(this.GetAvailableWeapons));
						List<Contact> contactList = this.m_ActiveUnit.GetSensory().GetContactList();
						Doctrine._ShootTourists? shootTouristsDoctrine = this.m_ActiveUnit.m_Doctrine.GetShootTouristsDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
						if (!Information.IsNothing(assignedMission) && assignedMission.IsActive())
						{
							foreach (Contact current4 in contactList)
							{
								if (bool_7 || current4.contactType == Contact_Base.ContactType.Missile || this.m_ActiveUnit.m_Scenario.FifthSecondIsChangingOnThisPulse)
								{
									string guid = current4.GetGuid();
									if (!ScenarioArrayUtil.IsContactExists(ref targets2, current4) && !list.Contains(current4))
									{
										Contact._BattleDamageAssessment? battleDamageAssessment = current4.GetBattleDamageAssessment(side);
										byte? b = battleDamageAssessment.HasValue ? new byte?((byte)battleDamageAssessment.GetValueOrDefault()) : null;
										if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
										{
											Misc.PostureStance postureStance;
											if (!this.PostureStanceDictionary.TryGetValue(guid, out postureStance))
											{
												postureStance = current4.GetPostureStance(side);
												this.PostureStanceDictionary.Add(guid, postureStance);
											}
											switch (postureStance)
											{
											case Misc.PostureStance.Unfriendly:
											case Misc.PostureStance.Hostile:
											{
												Contact theContact = current4;
												Mission mission_ = assignedMission;
												Doctrine._ShootTourists? shootTouristsDoc_ = shootTouristsDoctrine;
												bool onPatrolStation_ = flag;
												string text = "";
												int num = 0;
												if (base.IsTargetForMission(theContact, mission_, shootTouristsDoc_, bool_6, onPatrolStation_, true, ref text, ref num))
												{
													if (current4.contactType == Contact_Base.ContactType.Submarine)
													{
														if (!current4.IsBiologics())
														{
															this.TargetingContact(current4, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
														}
													}
													else
													{
														ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
														Contact theTarget = current4;
														Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
														text = "";
														num = 0;
														if (weaponry.HasWeaponsInConditionToAttackTarget(theTarget, true, doctrine, ref text, ref num, lazy.Value))
														{
															this.TargetingContact(current4, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
														}
													}
												}
												break;
											}
											case Misc.PostureStance.Unknown:
											{
												Contact theContact2 = current4;
												Mission mission_2 = assignedMission;
												Doctrine._ShootTourists? shootTouristsDoc_2 = shootTouristsDoctrine;
												bool onPatrolStation_2 = flag;
												string text = "";
												int num = 0;
												if (base.IsTargetForMission(theContact2, mission_2, shootTouristsDoc_2, bool_6, onPatrolStation_2, true, ref text, ref num))
												{
													this.TargetingContact(current4, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
												}
												break;
											}
											}
										}
									}
								}
							}
						}
						if (!this.m_ActiveUnit.HasAssignedPatrolMission() || ((Patrol)assignedMission).method_45(this.m_ActiveUnit.m_Scenario))
						{
							Weapon aAWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetAAWWeapon_RangeMax();
							Weapon aSUWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetASUWWeapon_RangeMax(false);
							Weapon landWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetLandWeapon_RangeMax(false);
							Weapon aSWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetASWWeapon_RangeMax();
							bool flag2 = this.m_ActiveUnit.HasAssignedPatrolMission() && ((Patrol)assignedMission).method_42();
							foreach (Contact current5 in contactList)
							{
								if (bool_7 || current5.contactType == Contact_Base.ContactType.Missile || this.m_ActiveUnit.m_Scenario.FifthSecondIsChangingOnThisPulse)
								{
									string guid2 = current5.GetGuid();
									Misc.PostureStance postureStance2;
									if (!this.PostureStanceDictionary.TryGetValue(guid2, out postureStance2))
									{
										postureStance2 = current5.GetPostureStance(side);
										this.PostureStanceDictionary.Add(guid2, postureStance2);
									}
									if (postureStance2 != Misc.PostureStance.Friendly && !ScenarioArrayUtil.IsContactExists(ref targets2, current5) && !list.Contains(current5) && postureStance2 != Misc.PostureStance.Neutral)
									{
										Contact._BattleDamageAssessment? battleDamageAssessment2 = current5.GetBattleDamageAssessment(side);
										byte? b = battleDamageAssessment2.HasValue ? new byte?((byte)battleDamageAssessment2.GetValueOrDefault()) : null;
										if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
										{
											if (!flag2 && !Information.IsNothing(assignedMission) && assignedMission.MissionClass == Mission._MissionClass.Patrol && !current5.method_98() && !((Patrol)assignedMission).method_43(this.m_ActiveUnit.m_Scenario))
											{
												Patrol patrol = (Patrol)assignedMission;
												if (!current5.vmethod_40(patrol.PatrolAreaVertices, this.m_ActiveUnit.m_Scenario, true) && base.GetTargetingBehavior(current5) != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc && !this.m_ActiveUnit.GetSensory().HasTrackingSensorForTarget(current5))
												{
													continue;
												}
											}
											switch (current5.contactType)
											{
											case Contact_Base.ContactType.Air:
											case Contact_Base.ContactType.Missile:
												if (!Information.IsNothing(aAWWeapon_RangeMax) && this.m_ActiveUnit.GetSlantRange(current5, 0f) < (float)current5.method_72() * aAWWeapon_RangeMax.RangeAAWMax)
												{
													this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
												}
												break;
											case Contact_Base.ContactType.Surface:
											case Contact_Base.ContactType.UndeterminedNaval:
												b = (shootTouristsDoctrine.HasValue ? new byte?((byte)shootTouristsDoctrine.GetValueOrDefault()) : null);
												if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && !Information.IsNothing(aSUWWeapon_RangeMax) && this.m_ActiveUnit.GetHorizontalRange(current5) < (float)current5.method_72() * aSUWWeapon_RangeMax.RangeASUWMax)
												{
													this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
												}
												break;
											case Contact_Base.ContactType.Submarine:
												if (!Information.IsNothing(aSWWeapon_RangeMax) && !current5.IsBiologics() && this.m_ActiveUnit.GetHorizontalRange(current5) < (float)current5.method_72() * aSWWeapon_RangeMax.RangeASWMax)
												{
													this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
												}
												break;
											case Contact_Base.ContactType.Aimpoint:
											case Contact_Base.ContactType.Facility_Fixed:
											case Contact_Base.ContactType.Facility_Mobile:
												b = (shootTouristsDoctrine.HasValue ? new byte?((byte)shootTouristsDoctrine.GetValueOrDefault()) : null);
												if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && !Information.IsNothing(landWeapon_RangeMax) && this.m_ActiveUnit.GetHorizontalRange(current5) < (float)current5.method_72() * landWeapon_RangeMax.RangeLandMax)
												{
													this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
												}
												break;
											case Contact_Base.ContactType.Orbital:
												b = (shootTouristsDoctrine.HasValue ? new byte?((byte)shootTouristsDoctrine.GetValueOrDefault()) : null);
												if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
												{
													ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
													Contact theTarget2 = current5;
													Doctrine doctrine2 = this.m_ActiveUnit.m_Doctrine;
													string text = "";
													int num = 0;
													if (weaponry.HasWeaponsInConditionToAttackTarget(theTarget2, true, doctrine2, ref text, ref num, null) && !Information.IsNothing(aAWWeapon_RangeMax) && this.m_ActiveUnit.GetSlantRange(current5, 0f) < (float)current5.method_72() * aAWWeapon_RangeMax.RangeAAWMax)
													{
														this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
													}
												}
												break;
											}
										}
									}
								}
							}
						}
					}
					IL_9CF:;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100383", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x001C5790 File Offset: 0x001C3990
		private bool IsThreatToMe(Contact theTarget)
		{
			bool result;
			if (Information.IsNothing(theTarget))
			{
				result = false;
			}
			else if (!theTarget.IsMissileOrTorpedo())
			{
				result = false;
			}
			else if (Information.IsNothing(theTarget.ActualUnit))
			{
				result = false;
			}
			else if (theTarget.IsDestroyed(this.m_ActiveUnit.m_Scenario))
			{
				result = false;
			}
			else
			{
				Misc.PostureStance postureStance;
				if (!this.PostureStanceDictionary.TryGetValue(theTarget.GetGuid(), out postureStance))
				{
					postureStance = theTarget.GetPostureStance(this.m_ActiveUnit.GetSide(false));
					this.PostureStanceDictionary.Add(theTarget.GetGuid(), postureStance);
				}
				if (postureStance == Misc.PostureStance.Friendly)
				{
					result = false;
				}
				else
				{
					Weapon weapon = (Weapon)theTarget.ActualUnit;
					result = (weapon.weaponTarget.IsAircraft && weapon.GetWeaponType() != Weapon._WeaponType.Decoy_Vehicle && Math.Abs(base.GetRelativeBearing(ref theTarget)) <= 90f && this.m_ActiveUnit.GetSlantRange(theTarget, 0f) <= 15f);
				}
			}
			return result;
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x001C5898 File Offset: 0x001C3A98
		private void method_95(float elapsedTime_)
		{
			if (this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget().ActualUnit) > 4f && Math.Abs(this.GetPrimaryTarget().RelativeBearingTo(this.m_ActiveUnit, true)) < 90f)
			{
				this.method_96(elapsedTime_);
			}
			else
			{
				this.method_97(elapsedTime_);
			}
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x001C58F8 File Offset: 0x001C3AF8
		private void method_96(float elapsedTime_)
		{
			try
			{
				if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride() || Information.IsNothing(this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride()))
				{
					Aircraft_AirOps aircraftAirOps = this.GetParentPlatform().GetAircraftAirOps();
					aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.BVRAttack);
					Weapon weapon = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), true, true, this.m_ActiveUnit.m_Doctrine);
					if (!Information.IsNothing(weapon))
					{
						if (weapon.IsLongRangeAAWWeapon())
						{
							aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.BVRAttack);
						}
						else
						{
							aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
						}
					}
					else
					{
						aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
					}
					Weapon aAWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetAAWWeapon_RangeMax();
					ActiveUnit_Sensory sensory = this.m_ActiveUnit.GetSensory();
					Sensor[] array = null;
					Sensor sensor = sensory.GetMaxRangeCoverageAirSpaceSensorList(true, true, true, false, ref array).FirstOrDefault<Sensor>();
					float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
					float num;
					if (Information.IsNothing(aAWWeapon_RangeMax))
					{
						num = 0f;
					}
					else
					{
						num = aAWWeapon_RangeMax.RangeAAWMax;
					}
					float? num2 = null;
					ActiveUnit.Throttle? throttle = null;
					float? num3 = null;
					Patrol patrol = null;
					float num4;
					if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
					{
						patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
						num3 = patrol.AttackDistance_Aircraft;
						if (Information.IsNothing(num3))
						{
							num4 = (float)Math.Max((double)(10f + num), (double)num * 1.2);
						}
						else
						{
							float? num5 = num3;
							float num6 = num;
							num4 = (num5.HasValue ? new float?(num5.GetValueOrDefault() + num6) : null).Value;
						}
					}
					else
					{
						num4 = (float)Math.Max((double)(10f + num), (double)num * 1.2);
					}
					if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
					{
						this.m_ActiveUnit.GetDesiredAltitude();
						if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
						{
							if (Information.IsNothing(patrol))
							{
								patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
							}
							if (!Information.IsNothing(num3) && horizontalRange > num4)
							{
								num2 = patrol.TransitAltitude_Aircraft;
							}
							else
							{
								num2 = patrol.AttackAltitude_Aircraft;
							}
						}
						if (!Information.IsNothing(num2))
						{
							this.m_ActiveUnit.SetDesiredAltitude(num2.Value);
						}
						else if (horizontalRange > num4)
						{
							if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
							{
								this.GetParentPlatform().GetAircraftNavigator().method_60(aircraftAirOps.GetAirOpsCondition());
							}
						}
						else if (this.GetPrimaryTarget().Altitude_Known && this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) < this.GetParentPlatform().GetCurrentAltitude_ASL(false) && !this.GetParentPlatform().GetAircraftSensory().HasLPIRadar() && !Information.IsNothing(sensor) && horizontalRange < sensor.MaxRange)
						{
							if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
							{
								this.m_ActiveUnit.SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) - 30.48f);
							}
						}
						else if (this.GetPrimaryTarget().Altitude_Known && horizontalRange < (float)Math.Max((double)num * 0.75, 10.0))
						{
							if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
							{
								float num7 = Math.Abs(this.GetParentPlatform().GetCurrentAltitude_ASL(false) - this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
								if (num7 == 0f)
								{
									this.m_ActiveUnit.SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
								}
								else if (this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) > this.GetParentPlatform().GetCurrentAltitude_ASL(false))
								{
									float estimatedTimeOfArrivalToTarget = this.GetParentPlatform().GetEstimatedTimeOfArrivalToTarget(this.GetPrimaryTarget());
									this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false) + num7 / estimatedTimeOfArrivalToTarget * elapsedTime_);
								}
								else
								{
									float estimatedTimeOfArrivalToTarget2 = this.GetParentPlatform().GetEstimatedTimeOfArrivalToTarget(this.GetPrimaryTarget());
									this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false) - num7 / estimatedTimeOfArrivalToTarget2 * elapsedTime_);
								}
							}
						}
						else if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
						{
							this.GetParentPlatform().GetAircraftNavigator().method_60(aircraftAirOps.GetAirOpsCondition());
						}
						if (!Information.IsNothing(aAWWeapon_RangeMax) && aAWWeapon_RangeMax.GetWeaponType() == Weapon._WeaponType.GuidedWeapon)
						{
							float val = (float)this.GetPrimaryTarget().GetTerrainElevation(true, false, false);
							float val2 = (float)this.m_ActiveUnit.GetTerrainElevation(true, false, false);
							float val3 = (float)this.m_ActiveUnit.GetAltitude_ASL(true, elapsedTime_);
							float num8 = Math.Max(Math.Max(val2, val), val3);
							float num9 = 0f;
							float num10 = 0f;
							if (aAWWeapon_RangeMax.LaunchAltitudeMax != 0f && aAWWeapon_RangeMax.LaunchAltitudeMax_ASL == 0f)
							{
								num9 = aAWWeapon_RangeMax.LaunchAltitudeMax + num8;
								num10 = aAWWeapon_RangeMax.LaunchAltitudeMax;
							}
							else if (aAWWeapon_RangeMax.LaunchAltitudeMax == 0f && aAWWeapon_RangeMax.LaunchAltitudeMax_ASL != 0f)
							{
								num9 = aAWWeapon_RangeMax.LaunchAltitudeMax_ASL;
								num10 = aAWWeapon_RangeMax.LaunchAltitudeMax_ASL - num8;
							}
							else if (aAWWeapon_RangeMax.LaunchAltitudeMax != 0f && aAWWeapon_RangeMax.LaunchAltitudeMax_ASL != 0f)
							{
								num9 = Math.Min(aAWWeapon_RangeMax.LaunchAltitudeMax + num8, aAWWeapon_RangeMax.LaunchAltitudeMax_ASL);
								num10 = Math.Min(aAWWeapon_RangeMax.LaunchAltitudeMax_ASL - num8, aAWWeapon_RangeMax.LaunchAltitudeMax);
							}
							float num11 = 0f;
							float num12 = 0f;
							if (aAWWeapon_RangeMax.LaunchAltitudeMin != 0f && aAWWeapon_RangeMax.LaunchAltitudeMin_ASL == 0f)
							{
								num11 = aAWWeapon_RangeMax.LaunchAltitudeMin + num8;
								num12 = aAWWeapon_RangeMax.LaunchAltitudeMin;
							}
							else if (aAWWeapon_RangeMax.LaunchAltitudeMin == 0f && aAWWeapon_RangeMax.LaunchAltitudeMin_ASL != 0f)
							{
								num11 = aAWWeapon_RangeMax.LaunchAltitudeMin_ASL;
								num12 = aAWWeapon_RangeMax.LaunchAltitudeMin_ASL - num8;
							}
							else if (aAWWeapon_RangeMax.LaunchAltitudeMin != 0f && aAWWeapon_RangeMax.LaunchAltitudeMin_ASL != 0f)
							{
								num11 = Math.Max(aAWWeapon_RangeMax.LaunchAltitudeMin + num8, aAWWeapon_RangeMax.LaunchAltitudeMin_ASL);
								num12 = Math.Max(aAWWeapon_RangeMax.LaunchAltitudeMin_ASL - num8, aAWWeapon_RangeMax.LaunchAltitudeMin);
							}
							if (num11 > this.m_ActiveUnit.GetDesiredAltitude())
							{
								this.m_ActiveUnit.SetDesiredAltitude(num11);
							}
							else if (num9 < this.m_ActiveUnit.GetDesiredAltitude())
							{
								this.m_ActiveUnit.SetDesiredAltitude(num9);
							}
							else
							{
								if (this.m_ActiveUnit.GetDesiredAltitude() > num9)
								{
									this.m_ActiveUnit.SetDesiredAltitude(num9);
								}
								if (this.m_ActiveUnit.GetDesiredAltitude() < num11)
								{
									this.m_ActiveUnit.SetDesiredAltitude(num11);
								}
							}
							if (num12 > this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing())
							{
								this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num12);
							}
							else if (num10 < this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing())
							{
								this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num10);
							}
							else
							{
								if (this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing() > num10)
								{
									this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num10);
								}
								if (this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing() < num12)
								{
									this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num12);
								}
							}
						}
					}
					if (Information.IsNothing(this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride()))
					{
						if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
						{
							if (Information.IsNothing(patrol))
							{
								patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
							}
							if (!Information.IsNothing(num3) && horizontalRange > num4)
							{
								throttle = patrol.TransitThrottle_Aircraft;
							}
							else
							{
								throttle = patrol.AttackThrottle_Aircraft;
							}
						}
						if (!Information.IsNothing(throttle))
						{
							this.m_ActiveUnit.SetThrottle(throttle.Value, null);
						}
						else
						{
							this.GetParentPlatform().GetAircraftNavigator().method_61(this.m_ActiveUnit.GetDesiredAltitude(), null, true, aircraftAirOps.GetAirOpsCondition());
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100384", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x001C6228 File Offset: 0x001C4428
		private void method_97(float elapsedTime_)
		{
			try
			{
				base.method_52(0f, 0f);
				Doctrine doctrine = null;
				Weapon weapon = null;
				if (Information.IsNothing(this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride()))
				{
					float angleBetween = Class263.GetAngleBetween(this.m_ActiveUnit.GetCurrentHeading(), base.GetAzimuth(this.GetPrimaryTarget()));
					if (angleBetween <= 330f && angleBetween >= 30f)
					{
						float num = (float)this.GetParentPlatform().GetAircraftKinematics().method_21();
						if (this.m_ActiveUnit.GetCurrentSpeed() < num)
						{
							this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
						}
						else
						{
							this.m_ActiveUnit.SetDesiredSpeed(num);
						}
					}
					else
					{
						doctrine = this.m_ActiveUnit.m_Doctrine;
						weapon = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), true, true, doctrine);
						if (!Information.IsNothing(weapon))
						{
							ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
							Weapon theWeapon = weapon;
							Contact primaryTarget = this.GetPrimaryTarget();
							Mount theMount = null;
							Sensor sensor = null;
							short? num2 = null;
							if (Operators.CompareString(weaponry.CheckWeaponAttackCondition(theWeapon, primaryTarget, ref num2, false, false, theMount, ref sensor), "OK", false) == 0)
							{
								if ((double)this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget()) > (double)weapon.GetMaxRangeToTarget(this.m_ActiveUnit, this.GetPrimaryTarget(), true, doctrine, false) * 0.5)
								{
									this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
									goto IL_24F;
								}
								bool flag = false;
								checked
								{
									if (this.GetPrimaryTarget().GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownClass)
									{
										Mount[] mounts = this.GetPrimaryTarget().ActualUnit.m_Mounts;
										for (int i = 0; i < mounts.Length; i++)
										{
											Mount mount = mounts[i];
											if (mount.HasGun() && mount.IsTargetInCoverageArc(this.m_ActiveUnit, new float?(this.GetPrimaryTarget().GetCurrentHeading())))
											{
												flag = true;
												break;
											}
										}
									}
									if (flag)
									{
										this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
										goto IL_24F;
									}
									this.m_ActiveUnit.SetDesiredSpeed(this.GetPrimaryTarget().GetCurrentSpeed());
									goto IL_24F;
								}
							}
						}
						this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
					}
				}
				IL_24F:
				if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride() && this.GetPrimaryTarget().Altitude_Known)
				{
					float num3 = Math.Abs(this.GetParentPlatform().GetCurrentAltitude_ASL(false) - this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
					if (num3 == 0f)
					{
						this.m_ActiveUnit.SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
					}
					else if (this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) > this.GetParentPlatform().GetCurrentAltitude_ASL(false))
					{
						float estimatedTimeOfArrivalToTarget = this.GetParentPlatform().GetEstimatedTimeOfArrivalToTarget(this.GetPrimaryTarget());
						this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false) + num3 / estimatedTimeOfArrivalToTarget * elapsedTime_);
					}
					else
					{
						float estimatedTimeOfArrivalToTarget2 = this.GetParentPlatform().GetEstimatedTimeOfArrivalToTarget(this.GetPrimaryTarget());
						this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false) - num3 / estimatedTimeOfArrivalToTarget2 * elapsedTime_);
					}
					if (Information.IsNothing(doctrine))
					{
						doctrine = this.m_ActiveUnit.m_Doctrine;
					}
					if (Information.IsNothing(weapon))
					{
						weapon = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), true, true, doctrine);
					}
					if (!Information.IsNothing(weapon) && weapon.GetWeaponType() == Weapon._WeaponType.GuidedWeapon)
					{
						float val = (float)this.GetPrimaryTarget().GetTerrainElevation(true, false, false);
						float val2 = (float)this.m_ActiveUnit.GetTerrainElevation(true, false, false);
						float val3 = (float)this.m_ActiveUnit.GetAltitude_ASL(true, elapsedTime_);
						float num4 = Math.Max(Math.Max(val2, val), val3);
						float num5 = 0f;
						float num6 = 0f;
						if (weapon.LaunchAltitudeMax != 0f && weapon.LaunchAltitudeMax_ASL == 0f)
						{
							num5 = weapon.LaunchAltitudeMax + num4;
							num6 = weapon.LaunchAltitudeMax;
						}
						else if (weapon.LaunchAltitudeMax == 0f && weapon.LaunchAltitudeMax_ASL != 0f)
						{
							num5 = weapon.LaunchAltitudeMax_ASL;
							num6 = weapon.LaunchAltitudeMax_ASL - num4;
						}
						else if (weapon.LaunchAltitudeMax != 0f && weapon.LaunchAltitudeMax_ASL != 0f)
						{
							num5 = Math.Min(weapon.LaunchAltitudeMax + num4, weapon.LaunchAltitudeMax_ASL);
							num6 = Math.Min(weapon.LaunchAltitudeMax_ASL - num4, weapon.LaunchAltitudeMax);
						}
						float num7 = 0f;
						float num8 = 0f;
						if (weapon.LaunchAltitudeMin != 0f && weapon.LaunchAltitudeMin_ASL == 0f)
						{
							num7 = weapon.LaunchAltitudeMin + num4;
							num8 = weapon.LaunchAltitudeMin;
						}
						else if (weapon.LaunchAltitudeMin == 0f && weapon.LaunchAltitudeMin_ASL != 0f)
						{
							num7 = weapon.LaunchAltitudeMin_ASL;
							num8 = weapon.LaunchAltitudeMin_ASL - num4;
						}
						else if (weapon.LaunchAltitudeMin != 0f && weapon.LaunchAltitudeMin_ASL != 0f)
						{
							num7 = Math.Max(weapon.LaunchAltitudeMin + num4, weapon.LaunchAltitudeMin_ASL);
							num8 = Math.Max(weapon.LaunchAltitudeMin_ASL - num4, weapon.LaunchAltitudeMin);
						}
						if (num7 > this.m_ActiveUnit.GetDesiredAltitude())
						{
							this.m_ActiveUnit.SetDesiredAltitude(num7);
						}
						else if (num5 < this.m_ActiveUnit.GetDesiredAltitude())
						{
							this.m_ActiveUnit.SetDesiredAltitude(num5);
						}
						else
						{
							if (this.m_ActiveUnit.GetDesiredAltitude() > num5)
							{
								this.m_ActiveUnit.SetDesiredAltitude(num5);
							}
							if (this.m_ActiveUnit.GetDesiredAltitude() < num7)
							{
								this.m_ActiveUnit.SetDesiredAltitude(num7);
							}
						}
						if (num8 > this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing())
						{
							this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
						}
						else if (num6 < this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing())
						{
							this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num6);
						}
						else
						{
							if (this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing() > num6)
							{
								this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num6);
							}
							if (this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing() < num8)
							{
								this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100385", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x001C6914 File Offset: 0x001C4B14
		public override void vmethod_27(float elapsedTime_)
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && !Information.IsNothing(this.m_ActiveUnit.GetNavigator()))
			{
				try
				{
					if (this.m_ActiveUnit.m_Scenario.FifthMinuteIsChangingOnThisPulse)
					{
						this.CheckHostCondition(elapsedTime_);
					}
					if (this.m_ActiveUnit.GetFuelState() == ActiveUnit._ActiveUnitFuelState.IgnoreBingoAndJoker)
					{
						this.m_ActiveUnit.SetFuelState(ActiveUnit._ActiveUnitFuelState.None);
					}
					Aircraft_AirOps aircraftAirOps = this.GetParentPlatform().GetAircraftAirOps();
					ActiveUnit assignedHostUnit = aircraftAirOps.GetAssignedHostUnit();
					if (Information.IsNothing(assignedHostUnit))
					{
						if (this.GetParentPlatform().GetAircraftNavigator().HasPlottedCourse())
						{
							this.GetParentPlatform().GetAircraftNavigator().vmethod_7(elapsedTime_);
						}
						else
						{
							this.GetParentPlatform().GetAircraftKinematics().vmethod_23(elapsedTime_, false, false);
						}
					}
					else
					{
						Aircraft_Navigator aircraftNavigator = this.GetParentPlatform().GetAircraftNavigator();
						if (aircraftNavigator.bUpdated && !aircraftNavigator.HasPathfindingCourse() && !aircraftNavigator.bool_2)
						{
							double latitude = this.m_ActiveUnit.GetLatitude(null);
							double longitude = this.m_ActiveUnit.GetLongitude(null);
							double latitude2 = assignedHostUnit.GetLatitude(null);
							double longitude2 = assignedHostUnit.GetLongitude(null);
							if (aircraftNavigator.vmethod_16(latitude, longitude, latitude2, longitude2, true, 0f, true, null))
							{
								aircraftNavigator.method_12(null, this.m_ActiveUnit, null, false, 0.15f, latitude2, longitude2, this.m_ActiveUnit.m_Scenario, false);
							}
						}
						if (!aircraftNavigator.method_66(assignedHostUnit))
						{
							if (this.m_ActiveUnit.GetFuelState() == ActiveUnit._ActiveUnitFuelState.IsBingo)
							{
								if (!Information.IsNothing(this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride()) || this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
								{
									this.m_ActiveUnit.GetKinematics().SetDesiredSpeedOverride(null);
									this.m_ActiveUnit.GetKinematics().SetDesiredAltitudeOverride(false);
									string str = "";
									if (this.GetParentPlatform().IsAircraft && Operators.CompareString(this.GetParentPlatform().Name, this.GetParentPlatform().UnitClass, false) != 0)
									{
										str = " (" + this.GetParentPlatform().UnitClass + ")";
									}
									this.GetParentPlatform().LogMessage(this.GetParentPlatform().Name + str + " has reached Bingo fuel and cancels altitude and speed overrides. If you want to manually control the speed or altitude for this aircraft, unassign it from the current Bingo fuel state (U hotkey). Please note that if you do, all safety measures will be disabled and you are be responsible for bringing the aircraft safely back to base yourself.", LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetParentPlatform().GetLongitude(null), this.GetParentPlatform().GetLatitude(null)));
								}
								bool flag = false;
								float transitAltitude = aircraftNavigator.GetTransitAltitude(ref flag);
								float desiredSpeed_ = (float)this.m_ActiveUnit.GetKinematics().GetSpeed(this.m_ActiveUnit.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Cruise);
								aircraftNavigator.method_68(assignedHostUnit, desiredSpeed_, transitAltitude, ref flag);
							}
							else if (this.GetParentPlatform().IsNotGroupLead())
							{
								base.method_16(ref aircraftAirOps);
							}
							else
							{
								float desiredSpeed_2;
								if (Information.IsNothing(this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride()))
								{
									desiredSpeed_2 = (float)this.m_ActiveUnit.GetKinematics().GetSpeed(this.GetParentPlatform().GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Full);
								}
								else
								{
									desiredSpeed_2 = this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().Value;
								}
								bool flag = false;
								float desireAltitude_;
								if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
								{
									desireAltitude_ = aircraftNavigator.GetTransitAltitude(ref flag);
								}
								else
								{
									desireAltitude_ = this.m_ActiveUnit.GetDesiredAltitude();
								}
								aircraftNavigator.method_68(assignedHostUnit, desiredSpeed_2, desireAltitude_, ref flag);
							}
						}
						else
						{
							if (this.m_ActiveUnit.HasParentGroup())
							{
								this.m_ActiveUnit.method_121(false, true);
							}
							this.GetParentPlatform().SetThrottle(ActiveUnit.Throttle.Loiter, null);
							this.GetParentPlatform().SetDesiredSpeed((float)this.GetParentPlatform().GetAircraftKinematics().GetSpeed(this.GetParentPlatform().GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter));
							this.GetParentPlatform().SetIsTerrainFollowing(this.GetParentPlatform(), false);
							this.GetParentPlatform().GetAircraftAirOps().method_49(assignedHostUnit);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100386", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x001C6DA8 File Offset: 0x001C4FA8
		private void CheckHostCondition(float elapsedTime_)
		{
			try
			{
				ActiveUnit assignedHostUnit = this.GetParentPlatform().GetAircraftAirOps().GetAssignedHostUnit();
				if (Information.IsNothing(assignedHostUnit))
				{
					this.GetParentPlatform().GetAircraftAirOps().AssignNewHostUnit();
				}
				else
				{
					string text = this.GetParentPlatform().GetAircraftAirOps().CheckHostCondition(assignedHostUnit);
					if (assignedHostUnit.IsNotActive() || Operators.CompareString(text, "OK", false) != 0)
					{
						string text2 = "";
						if (this.GetParentPlatform().IsAircraft && Operators.CompareString(this.GetParentPlatform().Name, this.GetParentPlatform().UnitClass, false) != 0)
						{
							text2 = " (" + this.GetParentPlatform().UnitClass + ")";
						}
						this.GetParentPlatform().LogMessage(string.Concat(new string[]
						{
							this.GetParentPlatform().Name,
							text2,
							" cannot be hosted by its current assigned base (",
							assignedHostUnit.Name,
							"). Reason: ",
							text
						}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetParentPlatform().GetLongitude(null), this.GetParentPlatform().GetLatitude(null)));
						this.GetParentPlatform().GetAircraftAirOps().method_29(assignedHostUnit);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100387", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x001C6F54 File Offset: 0x001C5154
		private void method_99(float float_1, ref Weapon weapon_0)
		{
			try
			{
				if (!Information.IsNothing(this.GetPrimaryTarget()) && (this.GetPrimaryTarget().IsFixed() || this.GetPrimaryTarget().IsSurface()))
				{
					if (this.GetParentPlatform().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_135)).Count<WeaponRec>() > 0)
					{
						float num = 50f;
						IEnumerable<Weapon> enumerable = this.GetParentPlatform().GetAircraftWeaponry().GetAvailableWeapons(false).Where(Aircraft_AI.WeaponFunc13);
						if (!Information.IsNothing(enumerable) && enumerable.Count<Weapon>() > 0)
						{
							float num2 = enumerable.Select(Aircraft_AI.WeaponFunc14).Max();
							float horizontalRange = this.GetParentPlatform().GetHorizontalRange(this.GetPrimaryTarget());
							if (horizontalRange > num)
							{
								return;
							}
							if ((double)horizontalRange > (double)num2 * 0.75)
							{
								return;
							}
						}
					}
					bool flag = false;
					foreach (Weapon current in this.m_ActiveUnit.m_Scenario.GetGuidedWeaponsInAir())
					{
						if (current.GetWeaponAI().GetPrimaryTarget() == this.GetPrimaryTarget() && current.GetFiringParent() == this.GetParentPlatform())
						{
							flag = true;
							if (!current.weaponCode.TerminalIllumination && !current.weaponCode.IlluminateAtLaunch)
							{
								if (current.GetGuidanceMethod() == Weapon._GuidanceMethod.CommandGuided)
								{
									weapon_0 = current;
								}
							}
							else
							{
								weapon_0 = current;
							}
							break;
						}
						if (this.GetParentPlatform().HasParentGroup() && current.GetFiringParent().HasParentGroup() && current.GetFiringParent().GetParentGroup(false) == this.GetParentPlatform().GetParentGroup(false))
						{
							flag = true;
						}
					}
					if (flag)
					{
						bool flag2 = false;
						WeaponSalvo[] weaponSalvos = this.m_ActiveUnit.GetSide(false).WeaponSalvos;
						int i = 0;
						IL_26D:
						checked
						{
							while (i < weaponSalvos.Length)
							{
								WeaponSalvo.Shooter[] shooters = weaponSalvos[i].m_Shooters;
								int j = 0;
								while (j < shooters.Length)
								{
									WeaponSalvo.Shooter shooter = shooters[j];
									if (Operators.CompareString(shooter.ShooterObjectID, this.m_ActiveUnit.GetGuid(), false) != 0)
									{
										j++;
									}
									else
									{
										if (unchecked(shooter.QuantityAssigned - shooter.QuantityFired) > 0)
										{
											flag2 = true;
										}
										if (!flag2)
										{
											i++;
											goto IL_26D;
										}
										goto IL_277;
									}
								}
								if (flag2)
								{
									break;
								}
								i++;
							}
							IL_277:;
						}
						if (!flag2 || !this.GetParentPlatform().GetAircraftWeaponry().method_13(this.GetPrimaryTarget(), true))
						{
							float num3 = this.GetPrimaryTarget().AzimuthTo(this.GetParentPlatform());
							float num4 = Math2.Normalize(num3 + 90f);
							float num5 = Math2.Normalize(num3 - 90f);
							if (!this.m_ActiveUnit.GetNavigator().HasPlottedCourse() && (!this.m_ActiveUnit.HasParentGroup() || !this.m_ActiveUnit.GetParentGroup(false).GetNavigator().HasPlottedCourse()))
							{
								if (Math.Abs(Class263.RelativeBearingTo(this.GetParentPlatform().GetCurrentHeading(), num4)) < Math.Abs(Class263.RelativeBearingTo(this.GetParentPlatform().GetCurrentHeading(), num5)))
								{
									this.GetParentPlatform().SetDesiredHeading(ActiveUnit._TurnRate.const_0, num4);
								}
								else
								{
									this.GetParentPlatform().SetDesiredHeading(ActiveUnit._TurnRate.const_0, num5);
								}
							}
							else
							{
								Waypoint waypoint;
								if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
								{
									waypoint = this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0];
								}
								else
								{
									waypoint = this.m_ActiveUnit.GetParentGroup(false).GetNavigator().GetPlottedCourse()[0];
								}
								float angle = this.m_ActiveUnit.AzimuthTo(waypoint.GetLatitude(), waypoint.GetLongitude());
								if (Math.Abs(Class263.RelativeBearingTo(angle, num4)) < Math.Abs(Class263.RelativeBearingTo(angle, num5)))
								{
									this.GetParentPlatform().SetDesiredHeading(ActiveUnit._TurnRate.const_0, num4);
								}
								else
								{
									this.GetParentPlatform().SetDesiredHeading(ActiveUnit._TurnRate.const_0, num5);
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
				ex2.Data.Add("Error at 1007843634777711", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x001C73DC File Offset: 0x001C55DC
		public override void vmethod_18(float float_1)
		{
			Aircraft_AI.Class94 @class = new Aircraft_AI.Class94();
			@class.aircraft_AI_0 = this;
			@class.float_0 = float_1;
			try
			{
				if (!Information.IsNothing(this.GetPrimaryTarget()))
				{
					if (this.GetPrimaryTarget().contactType == Contact_Base.ContactType.Air && this.method_101())
					{
						this.method_110();
					}
					else
					{
						Weapon weapon = null;
						float float_2 = 0f;
						if (!Information.IsNothing(this.GetPrimaryTarget()))
						{
							weapon = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), true, true, this.m_ActiveUnit.m_Doctrine);
							if (!Information.IsNothing(weapon))
							{
								float_2 = weapon.GetDomainRangeMin(this.GetPrimaryTarget());
							}
						}
						if (this.GetPrimaryTarget().Heading_Known && this.GetPrimaryTarget().GetCurrentSpeed() > 0f)
						{
							if (Math.Abs(Math.Abs(Class263.RelativeBearingTo(this.GetPrimaryTarget().GetCurrentHeading(), this.GetPrimaryTarget().AzimuthTo(this.m_ActiveUnit)))) <= 90f)
							{
								if (this.GetParentPlatform().GetAircraftWeaponry().method_57(this.GetPrimaryTarget()))
								{
									base.method_52(10f, float_2);
								}
								else
								{
									base.method_53(null);
								}
							}
							else
							{
								base.method_52(10f, float_2);
							}
						}
						else
						{
							base.method_52(10f, float_2);
						}
						base.method_44(ref weapon);
						Weapon weapon2 = null;
						if (base.method_63(this.GetPrimaryTarget()))
						{
							Doctrine._MaintainStandoff? maintainStandoffDoctrine = this.m_ActiveUnit.m_Doctrine.GetMaintainStandoffDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
							byte? b = maintainStandoffDoctrine.HasValue ? new byte?((byte)maintainStandoffDoctrine.GetValueOrDefault()) : null;
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								this.method_99(@class.float_0, ref weapon2);
							}
						}
						if (this.m_ActiveUnit.GetNavigator().bUpdated && !this.bool_5)
						{
							Task.Factory.StartNew(new Action(@class.method_0));
						}
						else if (this.m_ActiveUnit.GetNavigator().HasPathfindingCourse())
						{
							this.m_ActiveUnit.GetNavigator().vmethod_7(@class.float_0);
						}
						if (this.GetPrimaryTarget().contactType == Contact_Base.ContactType.Submarine && !Information.IsNothing(this.GetPrimaryTarget().GetUncertaintyArea()) && !this.GetParentPlatform().GetAircraftWeaponry().method_20(this.GetPrimaryTarget(), false))
						{
							this.GetParentPlatform().GetAircraftNavigator().Localization();
							this.GetParentPlatform().GetAircraftNavigator().vmethod_7(@class.float_0);
							Aircraft_AirOps aircraftAirOps = this.GetParentPlatform().GetAircraftAirOps();
							if (Information.IsNothing(this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride()) && aircraftAirOps.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
							{
								this.GetParentPlatform().SetThrottle(ActiveUnit.Throttle.Full, null);
							}
							if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
							{
								if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
								{
									if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass != Mission._MissionClass.Patrol && this.m_ActiveUnit.GetAssignedMission(false).MissionClass != Mission._MissionClass.Mining && this.m_ActiveUnit.GetAssignedMission(false).MissionClass != Mission._MissionClass.MineClearing)
									{
										this.GetParentPlatform().GetAircraftNavigator().method_57();
									}
									else
									{
										this.GetParentPlatform().GetAircraftNavigator().method_58(true, aircraftAirOps.GetAirOpsCondition());
									}
								}
								else
								{
									this.GetParentPlatform().GetAircraftNavigator().method_57();
								}
							}
							this.vmethod_22(@class.float_0, ref weapon2);
						}
						else
						{
							if (base.method_63(this.GetPrimaryTarget()))
							{
								this.vmethod_22(@class.float_0, ref weapon2);
							}
							else if (this.GetPrimaryTarget().GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass)
							{
								this.method_102();
							}
							else
							{
								Aircraft_AirOps aircraftAirOps2 = this.GetParentPlatform().GetAircraftAirOps();
								this.GetParentPlatform().GetAircraftNavigator().method_60(aircraftAirOps2.GetAirOpsCondition());
							}
							if (Math.Abs(Class263.RelativeBearingTo(this.GetParentPlatform().GetCurrentHeading(), this.GetParentPlatform().GetDesiredHeading(ActiveUnit._TurnRate.const_0))) > 90f)
							{
								int num = this.GetParentPlatform().GetAircraftKinematics().method_21();
								if (this.GetParentPlatform().GetCurrentSpeed() > (float)num)
								{
									this.GetParentPlatform().SetDesiredSpeed((float)num);
									this.GetParentPlatform().SetThrottle(this.GetParentPlatform().GetAircraftKinematics().vmethod_38(this.GetParentPlatform().GetCurrentSpeed(), (float)num), null);
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
				ex2.Data.Add("Error at 100388", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x001C78F4 File Offset: 0x001C5AF4
		public bool method_100(Contact contact_8)
		{
			bool flag;
			bool result;
			if (Information.IsNothing(contact_8.ActualUnit))
			{
				flag = false;
			}
			else if (Information.IsNothing(this.GetParentPlatform().GetLoadout()))
			{
				flag = false;
			}
			else
			{
				Loadout loadout = this.GetParentPlatform().GetLoadout();
				switch (contact_8.contactType)
				{
				case Contact_Base.ContactType.Air:
				{
					Loadout.LoadoutRole loadoutRole = loadout.loadoutRole;
					result = (loadoutRole - Loadout.LoadoutRole.Intercept_BVR <= 6);
					return result;
				}
				case Contact_Base.ContactType.Surface:
				{
					Loadout.LoadoutRole loadoutRole2 = loadout.loadoutRole;
					if (loadoutRole2 <= Loadout.LoadoutRole.NavalOnly_SEAD_ARM)
					{
						if (loadoutRole2 - Loadout.LoadoutRole.LandNaval_Strike <= 2 || loadoutRole2 == Loadout.LoadoutRole.LandNaval_DEAD || loadoutRole2 - Loadout.LoadoutRole.NavalOnly_Strike <= 2)
						{
							result = true;
							return result;
						}
					}
					else
					{
						if (loadoutRole2 == Loadout.LoadoutRole.NavalOnly_DEAD || loadoutRole2 == Loadout.LoadoutRole.BAI_CAS)
						{
							result = true;
							return result;
						}
						if (loadoutRole2 == Loadout.LoadoutRole.Forward_Observer)
						{
							result = true;
							return result;
						}
					}
					result = false;
					return result;
				}
				case Contact_Base.ContactType.Submarine:
				{
					Loadout.LoadoutRole loadoutRole3 = loadout.loadoutRole;
					result = (loadoutRole3 - Loadout.LoadoutRole.ASW_Patrol <= 1);
					return result;
				}
				case Contact_Base.ContactType.Facility_Fixed:
				case Contact_Base.ContactType.Facility_Mobile:
				{
					Loadout.LoadoutRole loadoutRole4 = loadout.loadoutRole;
					if (loadoutRole4 <= Loadout.LoadoutRole.LandOnly_SEAD_ARM)
					{
						if (loadoutRole4 - Loadout.LoadoutRole.LandNaval_Standoff > 1 && loadoutRole4 != Loadout.LoadoutRole.LandNaval_DEAD && loadoutRole4 - Loadout.LoadoutRole.LandOnly_Strike > 2)
						{
							goto IL_1A6;
						}
					}
					else if (loadoutRole4 != Loadout.LoadoutRole.LandOnly_DEAD && loadoutRole4 != Loadout.LoadoutRole.BAI_CAS && loadoutRole4 != Loadout.LoadoutRole.Forward_Observer)
					{
						goto IL_1A6;
					}
					result = true;
					return result;
					IL_1A6:
					result = false;
					return result;
				}
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x001C7AB0 File Offset: 0x001C5CB0
		private bool method_101()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (base.GetTargets().Length == 0)
					{
						flag = false;
					}
					else if (this.GetParentPlatform().m_Scenario.GetGuidedWeaponsInAir().Count == 0)
					{
						flag = false;
					}
					else if (this.GetParentPlatform().m_Scenario.GetGuidedWeaponsInAir().Where(new Func<Weapon, bool>(this.method_136)).Count<Weapon>() == 0)
					{
						flag = false;
					}
					else
					{
						bool flag2 = false;
						foreach (Contact current in this.m_ActiveUnit.GetSide(false).GetContactList())
						{
							if (current.GetPostureStance(this.m_ActiveUnit.GetSide(false)) != Misc.PostureStance.Friendly && current.GetPostureStance(this.m_ActiveUnit.GetSide(false)) != Misc.PostureStance.Neutral && current.contactType == Contact_Base.ContactType.Air && Math.Abs(this.m_ActiveUnit.RelativeBearingTo(current, true)) < 70f)
							{
								Math.Abs(current.RelativeBearingTo(this.m_ActiveUnit, true));
								Sensor[] allNoneMCMSensors = this.GetParentPlatform().GetAllNoneMCMSensors();
								for (int i = 0; i < allNoneMCMSensors.Length; i++)
								{
									Sensor sensor = allNoneMCMSensors[i];
									if (sensor.sensorType == Sensor.SensorType.Radar && sensor.IsTargetInCoverageArc(current, null))
									{
										flag2 = true;
										break;
									}
								}
							}
							if (flag2)
							{
								break;
							}
						}
						if (this.GetParentPlatform().GetLoadout().WeaponRecArray.Where(new Func<WeaponRec, bool>(this.method_137)).Count<WeaponRec>() == 0 && flag2)
						{
							flag = true;
						}
						else
						{
							IEnumerable<Weapon> source = this.GetParentPlatform().GetAircraftWeaponry().GetAvailableWeapons(false).Where(Aircraft_AI.WeaponFunc15);
							if (source.Count<Weapon>() == 0)
							{
								flag = true;
							}
							else
							{
								float num = source.Select(Aircraft_AI.WeaponFunc16).Max();
								WeaponSalvo[] weaponSalvos = this.m_ActiveUnit.GetSide(false).WeaponSalvos;
								for (int j = 0; j < weaponSalvos.Length; j++)
								{
									WeaponSalvo weaponSalvo = weaponSalvos[j];
									WeaponSalvo.Shooter[] shooters = weaponSalvo.m_Shooters;
									for (int k = 0; k < shooters.Length; k++)
									{
										WeaponSalvo.Shooter shooter = shooters[k];
										if (Operators.CompareString(shooter.ShooterObjectID, this.m_ActiveUnit.GetGuid(), false) == 0)
										{
											if (this.GetParentPlatform().GetHorizontalRange(weaponSalvo.Target) < num)
											{
												flag = false;
												result = false;
												return result;
											}
											if (unchecked(shooter.QuantityAssigned - shooter.QuantityFired) > 0)
											{
												flag = false;
												result = false;
												return result;
											}
										}
									}
								}
								flag = flag2;
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100389", "");
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
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x001C7DF4 File Offset: 0x001C5FF4
		private void method_102()
		{
			try
			{
				if (Information.IsNothing(this.GetPrimaryTarget().ActualUnit))
				{
					ActiveUnit activeUnit = this.m_ActiveUnit;
					Aircraft parentPlatform = this.GetParentPlatform();
					ActiveUnit activeUnit2;
					ActiveUnit activeUnit3;
					bool bool_ = (activeUnit2 = this.m_ActiveUnit).IsTerrainFollowing(activeUnit3 = this.m_ActiveUnit);
					float desiredAltitude = base.method_78(ref parentPlatform, ActiveUnit.Throttle.Cruise, ref bool_);
					activeUnit2.SetIsTerrainFollowing(activeUnit3, bool_);
					activeUnit.SetDesiredAltitude(desiredAltitude);
				}
				else
				{
					IEnumerable<Sensor> source = this.GetParentPlatform().GetNoneMCMSensors().Where(new Func<Sensor, bool>(this.method_138)).OrderByDescending(new Func<Sensor, float>(this.method_139));
					if (source.Count<Sensor>() != 0)
					{
						float num = source.ElementAtOrDefault(0).GetDetectionRange(this.GetParentPlatform(), this.GetPrimaryTarget().ActualUnit);
						if (num > 20f)
						{
							num = 20f;
						}
						float horizontalRange = this.GetParentPlatform().GetHorizontalRange(this.GetPrimaryTarget());
						if (this.GetPrimaryTarget().Altitude_Known && horizontalRange < num)
						{
							this.GetParentPlatform().SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
							this.m_ActiveUnit.SetIsTerrainFollowing(this.m_ActiveUnit, false);
						}
						else if ((this.GetPrimaryTarget().IsSurfaceOrLandTarget() || this.GetPrimaryTarget().IsSubSurface()) && horizontalRange < num)
						{
							this.GetParentPlatform().SetDesiredAltitude(304.800018f);
							this.m_ActiveUnit.SetIsTerrainFollowing(this.m_ActiveUnit, false);
						}
						else
						{
							Aircraft_Navigator aircraftNavigator = this.GetParentPlatform().GetAircraftNavigator();
							Aircraft_AirOps aircraftAirOps = this.GetParentPlatform().GetAircraftAirOps();
							aircraftNavigator.method_60(aircraftAirOps.GetAirOpsCondition());
							aircraftNavigator.method_61(this.m_ActiveUnit.GetDesiredAltitude(), new float?((float)this.m_ActiveUnit.GetKinematics().GetSpeed(this.m_ActiveUnit.GetDesiredAltitude(), ActiveUnit.Throttle.Cruise)), false, aircraftAirOps.GetAirOpsCondition());
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100391", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x001C803C File Offset: 0x001C623C
		public override void Navigate(float elapsedTime_)
		{
			if (!Information.IsNothing(this.m_ActiveUnit))
			{
				try
				{
					Aircraft_AirOps aircraftAirOps = this.GetParentPlatform().GetAircraftAirOps();
					ActiveUnit._ActiveUnitStatus unitStatus = this.m_ActiveUnit.GetUnitStatus();
					Aircraft_AirOps._AirOpsCondition airOpsCondition = aircraftAirOps.GetAirOpsCondition();
					if (airOpsCondition != Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
					{
						if (airOpsCondition != Aircraft_AirOps._AirOpsCondition.DeployingCargo)
						{
							switch (unitStatus)
							{
							case ActiveUnit._ActiveUnitStatus.Unassigned:
								if (this.m_ActiveUnit.IsGroupLead())
								{
									this.GetParentPlatform().GetAircraftKinematics().vmethod_23(elapsedTime_, false, false);
								}
								else if (this.m_ActiveUnit.HasParentGroup())
								{
									if (this.m_ActiveUnit.GetParentGroup(false).GetGroupType() == Group.GroupType.AirGroup)
									{
										base.method_16(ref aircraftAirOps);
									}
									else
									{
										this.GetParentPlatform().GetAircraftKinematics().vmethod_23(elapsedTime_, false, false);
									}
								}
								else
								{
									if (this.GetParentPlatform().IsRotaryWingAircraft() && this.m_ActiveUnit.GetSensory().HasOperationalDippingSonar() && this.m_ActiveUnit.GetCurrentAltitude_ASL(false) <= 45.72f && this.m_ActiveUnit.GetDesiredAltitude() <= 45.72f && this.m_ActiveUnit.GetAltitude_ASL(false, elapsedTime_) < 0)
									{
										Doctrine._UseDippingSonar? useDippingSonarDoctrine = this.m_ActiveUnit.m_Doctrine.GetUseDippingSonarDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
										byte? b = useDippingSonarDoctrine.HasValue ? new byte?((byte)useDippingSonarDoctrine.GetValueOrDefault()) : null;
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											this.m_ActiveUnit.GetKinematics().SetDesiredSpeedOverride(null);
											this.m_ActiveUnit.SetDesiredSpeed(0f);
											aircraftAirOps.SetConditionTimer(240f);
											goto IL_259;
										}
									}
									if (!this.GetParentPlatform().IsRotaryWingAircraft() || this.m_ActiveUnit.GetDesiredSpeed() != 0f)
									{
										this.GetParentPlatform().GetAircraftKinematics().vmethod_23(elapsedTime_, false, false);
									}
								}
								IL_259:
								if (this.GetParentPlatform().IsAirRefuelingCapable())
								{
									this.method_108();
								}
								break;
							case ActiveUnit._ActiveUnitStatus.OnPlottedCourse:
								if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass != Mission._MissionClass.Strike && this.m_ActiveUnit.HasAssignedPatrolMission())
								{
									Patrol patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
									if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
									{
										if (!this.m_ActiveUnit.GetNavigator().HasManualPlottedCourse() && this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0].waypointType != Waypoint.WaypointType.LocalizationRun && !this.m_ActiveUnit.GetNavigator().method_30(ref patrol.PatrolAreaVertices, ref patrol.list_14, ref patrol.list_10, 30f, false))
										{
											this.m_ActiveUnit.GetNavigator().ClearPlottedCourse();
											this.m_ActiveUnit.GetNavigator().SetDesiredHeading();
										}
									}
									else
									{
										this.m_ActiveUnit.GetNavigator().SetDesiredHeading();
									}
								}
								this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
								if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
								{
									if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass != Mission._MissionClass.Strike)
									{
										if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass != Mission._MissionClass.Ferry)
										{
											if (!this.m_ActiveUnit.IsNotGroupLead())
											{
												Aircraft_Navigator aircraftNavigator = this.GetParentPlatform().GetAircraftNavigator();
												aircraftNavigator.method_59(false, aircraftAirOps.GetAirOpsCondition());
												aircraftNavigator.method_58(false, aircraftAirOps.GetAirOpsCondition());
											}
										}
										else
										{
											FerryMission ferryMission = (FerryMission)this.m_ActiveUnit.GetAssignedMission(false);
											if (!this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
											{
												if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
												{
													if (!Information.IsNothing(ferryMission.FerryThrottle_Aircraft))
													{
														this.m_ActiveUnit.SetThrottle(ferryMission.FerryThrottle_Aircraft.Value, null);
													}
													else
													{
														this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
													}
												}
												else
												{
													this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
												}
											}
											else
											{
												this.m_ActiveUnit.SetThrottle(this.m_ActiveUnit.GetThrottle(), null);
											}
											if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
											{
												if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
												{
													if (!Information.IsNothing(ferryMission.FerryAltitude_Aircraft))
													{
														this.m_ActiveUnit.SetDesiredAltitude(ferryMission.FerryAltitude_Aircraft.Value);
													}
													else
													{
														ActiveUnit activeUnit = this.m_ActiveUnit;
														Aircraft parentPlatform = this.GetParentPlatform();
														ActiveUnit.Throttle throttle = this.m_ActiveUnit.GetThrottle();
														ActiveUnit activeUnit2;
														ActiveUnit activeUnit3;
														bool bool_ = (activeUnit2 = this.m_ActiveUnit).IsTerrainFollowing(activeUnit3 = this.m_ActiveUnit);
														float desiredAltitude = base.method_78(ref parentPlatform, throttle, ref bool_);
														activeUnit2.SetIsTerrainFollowing(activeUnit3, bool_);
														activeUnit.SetDesiredAltitude(desiredAltitude);
													}
												}
												else
												{
													ActiveUnit activeUnit4 = this.m_ActiveUnit;
													Aircraft aircraft = this.GetParentPlatform();
													ActiveUnit.Throttle throttle2 = this.m_ActiveUnit.GetThrottle();
													ActiveUnit activeUnit2;
													ActiveUnit activeUnit3;
													bool bool_2 = (activeUnit3 = this.m_ActiveUnit).IsTerrainFollowing(activeUnit2 = this.m_ActiveUnit);
													float desiredAltitude2 = base.method_78(ref aircraft, throttle2, ref bool_2);
													activeUnit3.SetIsTerrainFollowing(activeUnit2, bool_2);
													activeUnit4.SetDesiredAltitude(desiredAltitude2);
												}
											}
											else
											{
												this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetDesiredAltitude());
											}
											if (this.GetParentPlatform().IsAirRefuelingCapable())
											{
												this.method_108();
											}
										}
									}
									else if (this.m_ActiveUnit.m_Scenario.MinuteIsChangingOnThisPulse && this.m_ActiveUnit.GetNavigator().method_24())
									{
										if (this.m_ActiveUnit.HasParentGroup())
										{
											using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnit.GetParentGroup(false).GetUnitsInGroup().Values.GetEnumerator())
											{
												while (enumerator.MoveNext())
												{
													if (enumerator.Current.GetFuelState(null) == ActiveUnit._ActiveUnitFuelState.IsBingo)
													{
														if (Information.IsNothing(this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride()) && this.m_ActiveUnit.GetThrottle() > ActiveUnit.Throttle.Cruise)
														{
															this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
														}
														break;
													}
												}
												goto IL_73E;
											}
										}
										if (this.m_ActiveUnit.GetFuelState(null) == ActiveUnit._ActiveUnitFuelState.IsBingo && Information.IsNothing(this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride()) && this.m_ActiveUnit.GetThrottle() > ActiveUnit.Throttle.Cruise)
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
										}
									}
								}
								IL_73E:
								if (this.m_ActiveUnit.GetNavigator().GetPlottedCourse().Count<Waypoint>() != 0 && this.m_ActiveUnit.GetNavigator().GetPlottedCourse().First<Waypoint>().waypointType == Waypoint.WaypointType.LocalizationRun && this.m_ActiveUnit.GetUnitType() == GlobalVariables.ActiveUnitType.Aircraft && !Information.IsNothing(this.GetPrimaryTarget()) && this.GetPrimaryTargetType() == Contact_Base.ContactType.Submarine)
								{
									if (!Information.IsNothing(this.GetPrimaryTarget().GetUncertaintyArea()))
									{
										GeoPoint geoPoint = this.m_ActiveUnit.GetNavigator().GetPlottedCourse().First<Waypoint>();
										Contact primaryTarget;
										List<GeoPoint> uncertaintyArea = (primaryTarget = this.GetPrimaryTarget()).GetUncertaintyArea();
										bool flag = geoPoint.method_21(ref uncertaintyArea, true);
										primaryTarget.SetUncertaintyArea(uncertaintyArea);
										if (!flag)
										{
											this.m_ActiveUnit.GetNavigator().ClearPlottedCourse();
										}
									}
									else
									{
										this.m_ActiveUnit.GetNavigator().ClearPlottedCourse();
									}
								}
								break;
							case ActiveUnit._ActiveUnitStatus.EngagedOffensive:
								if (Information.IsNothing(this.GetPrimaryTarget()))
								{
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
								}
								else if (this.m_ActiveUnit.HasParentGroup())
								{
									if (this.m_ActiveUnit.GetParentGroup(false).GetNavigator().HasWaypointOtherPathfindingPoint())
									{
										if (this.m_ActiveUnit.IsGroupLead())
										{
											Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.m_ActiveUnit.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
											byte? b = ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null;
											if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
											{
												this.vmethod_18(elapsedTime_);
											}
											else
											{
												this.GetParentPlatform().GetAircraftNavigator().vmethod_7(elapsedTime_);
											}
										}
										else if (!this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().method_20() && !this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().method_21())
										{
											Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.m_ActiveUnit.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
											byte? b = ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null;
											if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && (this.m_ActiveUnit.GetWeaponState() == ActiveUnit._ActiveUnitWeaponState.None || this.m_ActiveUnit.GetWeaponState() == ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO || this.m_ActiveUnit.GetWeaponState() == ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO))
											{
												this.vmethod_18(elapsedTime_);
											}
											else
											{
												base.method_16(ref aircraftAirOps);
											}
										}
										else
										{
											this.vmethod_18(elapsedTime_);
										}
									}
									else
									{
										this.vmethod_18(elapsedTime_);
									}
								}
								else
								{
									this.vmethod_18(elapsedTime_);
								}
								break;
							case ActiveUnit._ActiveUnitStatus.EngagedDefensive:
								if (!Information.IsNothing(this.PrimaryThreat))
								{
									this.m_ActiveUnit.GetKinematics().SetDesiredSpeedOverride(null);
									if (this.m_ActiveUnit.method_49(this.m_ActiveUnit.GetDesiredSpeed(this.PrimaryThreat, this.m_ActiveUnit.GetCurrentSpeed(), this.m_ActiveUnit.GetCurrentHeading()), base.DistanceBetween(this.m_ActiveUnit, ref this.PrimaryThreat)) > 20f)
									{
										if (aircraftAirOps.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.RTB)
										{
											this.vmethod_27(elapsedTime_);
										}
										else
										{
											if (this.m_ActiveUnit.GetThrottle() < ActiveUnit.Throttle.Full)
											{
												this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Full, null);
											}
											this.vmethod_18(elapsedTime_);
										}
									}
									else
									{
										this.EngagedDefensive(elapsedTime_);
									}
								}
								break;
							case ActiveUnit._ActiveUnitStatus.OnPatrol:
								if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
								{
									Patrol patrol2 = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
									if (aircraftAirOps.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
									{
										this.GetParentPlatform().GetAircraftNavigator().ClearPlottedCourse();
										aircraftAirOps.method_75();
									}
									else if (!Information.IsNothing(patrol2))
									{
										if (this.m_ActiveUnit.HasParentGroup())
										{
											if (this.m_ActiveUnit.IsGroupLead())
											{
												if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
												{
													if (!this.m_ActiveUnit.GetParentGroup(false).GetNavigator().method_30(ref patrol2.PatrolAreaVertices, ref patrol2.list_14, ref patrol2.list_10, 30f, false))
													{
														this.m_ActiveUnit.GetParentGroup(false).GetNavigator().SetDesiredHeading();
													}
													this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
												}
												else
												{
													this.m_ActiveUnit.GetParentGroup(false).GetNavigator().SetDesiredHeading();
												}
											}
											else
											{
												base.method_16(ref aircraftAirOps);
											}
										}
										else if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
										{
											if (this.m_ActiveUnit.GetNavigator().HasManualPlottedCourse())
											{
												this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
											}
											else if (this.m_ActiveUnit.GetNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.PatrolStation)
											{
												if (!this.m_ActiveUnit.GetNavigator().method_30(ref patrol2.PatrolAreaVertices, ref patrol2.list_14, ref patrol2.list_10, 30f, false))
												{
													this.m_ActiveUnit.GetNavigator().SetDesiredHeading();
												}
												this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
											}
										}
										else
										{
											this.m_ActiveUnit.GetNavigator().SetDesiredHeading();
										}
									}
								}
								break;
							case ActiveUnit._ActiveUnitStatus.RTB:
							case ActiveUnit._ActiveUnitStatus.RTB_Manual:
							case ActiveUnit._ActiveUnitStatus.RTB_MissionOver:
							case ActiveUnit._ActiveUnitStatus.RTB_Group:
							{
								Aircraft_AirOps._AirOpsCondition airOpsCondition2 = aircraftAirOps.GetAirOpsCondition();
								if (airOpsCondition2 <= Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown)
								{
									if (airOpsCondition2 == Aircraft_AirOps._AirOpsCondition.Airborne)
									{
										aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.RTB);
										break;
									}
									if (airOpsCondition2 != Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown)
									{
										break;
									}
								}
								else
								{
									if (airOpsCondition2 == Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue)
									{
										this.vmethod_27(elapsedTime_);
										this.GetParentPlatform().SetThrottle(ActiveUnit.Throttle.Loiter, null);
										break;
									}
									if (airOpsCondition2 != Aircraft_AirOps._AirOpsCondition.RTB)
									{
										if (airOpsCondition2 != Aircraft_AirOps._AirOpsCondition.EmergencyLanding)
										{
											break;
										}
									}
									else
									{
										if (this.m_ActiveUnit.m_Scenario.MinuteIsChangingOnThisPulse && !Information.IsNothing(aircraftAirOps.GetAssignedHostUnit()))
										{
											bool bool_2 = false;
											bool flag2 = false;
											string text = "";
											if (this.m_ActiveUnit.GetFuelState() != ActiveUnit._ActiveUnitFuelState.IsBingo && this.m_ActiveUnit.GetFuelState() != ActiveUnit._ActiveUnitFuelState.IsJoker)
											{
												Aircraft_Navigator aircraftNavigator2 = this.GetParentPlatform().GetAircraftNavigator();
												ActiveUnit.Throttle throttle3 = aircraftNavigator2.method_62();
												flag2 = false;
												float transitAltitude = aircraftNavigator2.GetTransitAltitude(ref flag2);
												if ((double)this.GetParentPlatform().GetAircraftKinematics().method_6(this.GetParentPlatform().GetHorizontalRange(aircraftAirOps.GetAssignedHostUnit()), throttle3, transitAltitude, new float?((float)this.GetParentPlatform().GetAircraftKinematics().GetSpeed(transitAltitude, throttle3)), false, false) > (double)this.GetParentPlatform().GetCurrentFuelQuantity() * 0.9)
												{
													Aircraft_AirOps aircraft_AirOps = aircraftAirOps;
													GeoPoint geoPoint_ = null;
													flag2 = false;
													ActiveUnit activeUnit3 = null;
													List<Mission> list = null;
													text = "";
													bool_2 = true;
													if (aircraft_AirOps.method_78(geoPoint_, Doctrine._RefuelSelection.const_2, ref flag2, ref activeUnit3, ref list, ref text, ref bool_2))
													{
														break;
													}
												}
											}
											else
											{
												Aircraft_AirOps aircraft_AirOps2 = aircraftAirOps;
												GeoPoint geoPoint_2 = null;
												bool_2 = false;
												ActiveUnit activeUnit3 = null;
												List<Mission> list = null;
												text = "";
												flag2 = true;
												if (aircraft_AirOps2.method_78(geoPoint_2, Doctrine._RefuelSelection.const_2, ref bool_2, ref activeUnit3, ref list, ref text, ref flag2))
												{
													break;
												}
											}
										}
										if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
										{
											this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
										}
										else
										{
											this.vmethod_27(elapsedTime_);
										}
										if (!this.m_ActiveUnit.HasParentGroup() || this.m_ActiveUnit.GetParentGroup(false).GetGroupType() != Group.GroupType.AirGroup)
										{
											break;
										}
										Doctrine._WeaponState? winchesterShotgunDoctrine = this.m_ActiveUnit.m_Doctrine.GetWinchesterShotgunDoctrine(this.m_ActiveUnit.m_Scenario, false, true, false, false);
										int? num = winchesterShotgunDoctrine.HasValue ? new int?((int)winchesterShotgunDoctrine.GetValueOrDefault()) : null;
										if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											this.m_ActiveUnit.method_121(false, true);
											break;
										}
										break;
									}
								}
								if (!this.GetParentPlatform().GetAircraftNavigator().method_70(elapsedTime_))
								{
									this.GetParentPlatform().GetAircraftNavigator().method_69();
								}
								else
								{
									aircraftAirOps.SetConditionTimer(0f);
								}
								break;
							}
							case ActiveUnit._ActiveUnitStatus.Tasked:
								if (this.m_ActiveUnit.HasAssignedCargoMission())
								{
									this.method_111(elapsedTime_);
								}
								else if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
								{
									if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Mining)
									{
										MiningMission miningMission = (MiningMission)this.m_ActiveUnit.GetAssignedMission(false);
										if (this.m_ActiveUnit.HasParentGroup())
										{
											if (this.m_ActiveUnit.IsGroupLead())
											{
												if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
												{
													if (!this.m_ActiveUnit.GetParentGroup(false).GetNavigator().method_30(ref miningMission.AreaVertices, ref miningMission.list_16, ref miningMission.list_11, 30f, false))
													{
														this.m_ActiveUnit.GetParentGroup(false).GetNavigator().HeadingToTheArea(miningMission.AreaVertices);
													}
													this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
												}
												else
												{
													this.m_ActiveUnit.GetParentGroup(false).GetNavigator().HeadingToTheArea(miningMission.AreaVertices);
												}
											}
											else
											{
												base.method_16(ref aircraftAirOps);
											}
										}
										else if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
										{
											if (!this.m_ActiveUnit.GetNavigator().method_30(ref miningMission.AreaVertices, ref miningMission.list_16, ref miningMission.list_11, 30f, false))
											{
												this.m_ActiveUnit.GetNavigator().HeadingToTheArea(miningMission.AreaVertices);
											}
											this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
										}
										else
										{
											this.m_ActiveUnit.GetNavigator().HeadingToTheArea(miningMission.AreaVertices);
										}
										if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride() && this.m_ActiveUnit.GetNavigator().IsOnStation(ref miningMission.AreaVertices, ref miningMission.list_13, ref miningMission.list_8, 2, false, false))
										{
											base.method_42();
										}
									}
									else if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.MineClearing)
									{
										Aircraft_AI.MineClearingAI mineClearingAI = new Aircraft_AI.MineClearingAI(null);
										mineClearingAI.m_AI = this;
										MineClearingMission mineClearingMission = (MineClearingMission)this.m_ActiveUnit.GetAssignedMission(false);
										mineClearingAI.UnguidedWeapons = this.m_ActiveUnit.m_Scenario.GetUnguidedWeapons();
										mineClearingAI.MineClearingAreaVertices = mineClearingMission.AreaVertices;
										mineClearingAI.UnguidedWeaponBag = new ConcurrentBag<UnguidedWeapon>();
										if (this.GetParentPlatform().HaveMineCounterMeasures())
										{
											Parallel.ForEach<string>(this.m_ActiveUnit.GetSide(false).Contacts_NonAU, new Action<string>(mineClearingAI.AddWeapon));
										}
										if (mineClearingAI.UnguidedWeaponBag.Count > 0)
										{
											UnguidedWeapon unguidedWeapon = mineClearingAI.UnguidedWeaponBag.ToList<UnguidedWeapon>().Where(Aircraft_AI.UnguidedWeaponFunc17).OrderBy(new Func<UnguidedWeapon, double>(this.method_140)).ElementAtOrDefault(0);
											float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(unguidedWeapon);
											base.NavigateToClearTheMine(unguidedWeapon, horizontalRange);
											this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
										}
										else if (this.m_ActiveUnit.HasParentGroup())
										{
											if (this.m_ActiveUnit.IsGroupLead())
											{
												if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
												{
													if (!this.m_ActiveUnit.GetParentGroup(false).GetNavigator().method_30(ref mineClearingMission.AreaVertices, ref mineClearingMission.list_14, ref mineClearingMission.list_10, 30f, false))
													{
														this.m_ActiveUnit.GetParentGroup(false).GetNavigator().HeadingToTheArea(mineClearingMission.AreaVertices);
													}
													this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
												}
												else
												{
													this.m_ActiveUnit.GetParentGroup(false).GetNavigator().HeadingToTheArea(mineClearingMission.AreaVertices);
												}
											}
											else if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
											{
												this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
											}
										}
										else if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
										{
											if (!this.m_ActiveUnit.GetNavigator().method_30(ref mineClearingMission.AreaVertices, ref mineClearingMission.list_14, ref mineClearingMission.list_10, 30f, false))
											{
												this.m_ActiveUnit.GetNavigator().HeadingToTheArea(mineClearingMission.AreaVertices);
											}
											this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
										}
										else
										{
											this.m_ActiveUnit.GetNavigator().HeadingToTheArea(mineClearingMission.AreaVertices);
										}
									}
									else
									{
										if (Information.IsNothing(this.GetPrimaryTarget()) && !this.m_ActiveUnit.GetAI().IsEscort && !this.m_ActiveUnit.IsNotGroupLead() && !this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Loiter, null);
										}
										if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike)
										{
											Strike.StrikeType strikeType = ((Strike)this.m_ActiveUnit.GetAssignedMission(false)).strikeType;
											if (strikeType != Strike.StrikeType.Air_Intercept)
											{
												if (strikeType - Strike.StrikeType.Land_Strike <= 2)
												{
													if (Information.IsNothing(this.GetPrimaryTarget()) && !this.m_ActiveUnit.IsNotGroupLead())
													{
														List<Aircraft> list2 = new List<Aircraft>();
														List<ActiveUnit> list3 = this.m_ActiveUnit.GetSide(false).ActiveUnitArray.ToList<ActiveUnit>();
														foreach (ActiveUnit current in list3)
														{
															if (current.IsAircraft && current.IsOperating() && current != this.GetParentPlatform() && current.GetAssignedMission(false) == this.GetParentPlatform().GetAssignedMission(false) && !current.GetAI().IsEscort)
															{
																list2.Add((Aircraft)current);
															}
														}
														if (list2.Count != 0)
														{
															GeoPoint geoPoint2 = new GeoPoint();
															int num2 = 0;
															float num3 = 0f;
															int count = list2.Count;
															if (count == 1)
															{
																geoPoint2.SetLongitude(list2[0].GetLongitude(null));
																geoPoint2.SetLatitude(list2[0].GetLatitude(null));
															}
															else
															{
																geoPoint2.SetLongitude(list2.Select(Aircraft_AI.AircraftFunc18).Sum() / (double)list2.Count);
																geoPoint2.SetLatitude(list2.Select(Aircraft_AI.AircraftFunc19).Sum() / (double)list2.Count);
															}
															this.GetParentPlatform().SetDesiredHeading(ActiveUnit._TurnRate.const_1, Math2.GetAzimuth(this.GetParentPlatform().GetLatitude(null), this.GetParentPlatform().GetLongitude(null), geoPoint2.GetLatitude(), geoPoint2.GetLongitude()));
															foreach (Aircraft current2 in list2)
															{
																num2 = (int)Math.Round((double)((float)num2 + current2.GetCurrentSpeed()));
																num3 += current2.GetCurrentAltitude_ASL(false);
															}
															if (!this.GetParentPlatform().GetAircraftKinematics().GetDesiredSpeedOverride().HasValue)
															{
																float num4 = (float)((double)num2 / (double)list2.Count);
																this.GetParentPlatform().SetThrottle(this.GetParentPlatform().GetAircraftKinematics().vmethod_38(this.GetParentPlatform().GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)num4))), null);
																this.GetParentPlatform().SetDesiredSpeed(num4);
															}
															if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
															{
																float num5 = 0f;
																float num6 = 9999999f;
																Mount[] mounts = this.m_ActiveUnit.m_Mounts;
																float num7;
																checked
																{
																	for (int i = 0; i < mounts.Length; i++)
																	{
																		Mount mount = mounts[i];
																		if (mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
																		{
																			using (IEnumerator<WeaponRec> enumerator4 = mount.GetWeaponRecCollection().GetEnumerator())
																			{
																				while (enumerator4.MoveNext())
																				{
																					WeaponRec current3;
																					Weapon weapon = (current3 = enumerator4.Current).GetWeapon(this.m_ActiveUnit.m_Scenario);
																					if (!weapon.IsNotSensorPod() && !weapon.IsTank() && !weapon.IsSensorPod() && current3.GetCurrentLoad() != 0)
																					{
																						if (weapon.HasNuclearWarhead())
																						{
																							Doctrine._UseNuclear? useNuclearDoctrine = this.m_ActiveUnit.m_Doctrine.GetUseNuclearDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
																							byte? b = useNuclearDoctrine.HasValue ? new byte?((byte)useNuclearDoctrine.GetValueOrDefault()) : null;
																							bool? flag3 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
																							if ((flag3.HasValue ? new bool?(!flag3.GetValueOrDefault()) : flag3).GetValueOrDefault())
																							{
																								continue;
																							}
																						}
																						if (weapon.LaunchAltitudeMin != 0f && weapon.LaunchAltitudeMin > num5)
																						{
																							num5 = weapon.LaunchAltitudeMin;
																						}
																						if (weapon.LaunchAltitudeMax != 0f && weapon.LaunchAltitudeMax < num6)
																						{
																							num6 = weapon.LaunchAltitudeMax;
																						}
																					}
																				}
																			}
																		}
																	}
																	if (this.m_ActiveUnit.IsAircraft && !Information.IsNothing(((Aircraft)this.m_ActiveUnit).GetLoadout()))
																	{
																		WeaponRec[] weaponRecArray = ((Aircraft)this.m_ActiveUnit).GetLoadout().WeaponRecArray;
																		for (int j = 0; j < weaponRecArray.Length; j++)
																		{
																			WeaponRec weaponRec;
																			Weapon weapon2 = (weaponRec = weaponRecArray[j]).GetWeapon(this.m_ActiveUnit.m_Scenario);
																			if (!weapon2.IsNotSensorPod() && !weapon2.IsTank() && !weapon2.IsSensorPod() && weaponRec.GetCurrentLoad() != 0)
																			{
																				if (weapon2.HasNuclearWarhead())
																				{
																					Doctrine._UseNuclear? useNuclearDoctrine = this.m_ActiveUnit.m_Doctrine.GetUseNuclearDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
																					byte? b = useNuclearDoctrine.HasValue ? new byte?((byte)useNuclearDoctrine.GetValueOrDefault()) : null;
																					bool? flag3 = b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null;
																					if ((flag3.HasValue ? new bool?(!flag3.GetValueOrDefault()) : flag3).GetValueOrDefault())
																					{
																						goto IL_1851;
																					}
																				}
																				if (weapon2.LaunchAltitudeMin != 0f && weapon2.LaunchAltitudeMin > num5)
																				{
																					num5 = weapon2.LaunchAltitudeMin;
																				}
																				if (weapon2.LaunchAltitudeMax != 0f && weapon2.LaunchAltitudeMax < num6)
																				{
																					num6 = weapon2.LaunchAltitudeMax;
																				}
																			}
																			IL_1851:;
																		}
																	}
																	num7 = num3 / (float)list2.Count;
																}
																if (num5 > num6)
																{
																	if (num7 < num5)
																	{
																		num7 = num5;
																		float num8 = (float)Math.Max(0, this.m_ActiveUnit.GetTerrainElevation(false, false, false));
																		if (num8 > 0f)
																		{
																			num7 += num8;
																		}
																	}
																}
																else
																{
																	if (num7 < num5)
																	{
																		num7 = num5;
																		float num9 = (float)Math.Max(0, this.m_ActiveUnit.GetTerrainElevation(false, false, false));
																		if (num9 > 0f)
																		{
																			num7 += num9;
																		}
																	}
																	if (num7 < num5)
																	{
																		num7 = num5;
																	}
																}
																this.m_ActiveUnit.SetDesiredAltitude(num7);
															}
														}
														else
														{
															if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
															{
																ActiveUnit activeUnit5 = this.m_ActiveUnit;
																Aircraft aircraft = this.GetParentPlatform();
																ActiveUnit activeUnit2;
																ActiveUnit activeUnit3;
																bool bool_2 = (activeUnit3 = this.m_ActiveUnit).IsTerrainFollowing(activeUnit2 = this.m_ActiveUnit);
																float desiredAltitude3 = base.method_78(ref aircraft, ActiveUnit.Throttle.Loiter, ref bool_2);
																activeUnit3.SetIsTerrainFollowing(activeUnit2, bool_2);
																activeUnit5.SetDesiredAltitude(desiredAltitude3);
															}
															this.m_ActiveUnit.GetKinematics().vmethod_23(elapsedTime_, false, false);
														}
													}
													else if (this.m_ActiveUnit.HasParentGroup())
													{
														if (this.m_ActiveUnit.IsGroupLead())
														{
															this.vmethod_18(elapsedTime_);
														}
														else
														{
															base.method_16(ref aircraftAirOps);
														}
													}
													else
													{
														this.vmethod_18(elapsedTime_);
													}
												}
											}
											else if (!Information.IsNothing(this.GetPrimaryTarget()))
											{
												this.vmethod_18(elapsedTime_);
											}
											else
											{
												if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
												{
													ActiveUnit activeUnit6 = this.m_ActiveUnit;
													Aircraft parentPlatform2 = this.GetParentPlatform();
													Aircraft aircraft = null;
													ActiveUnit activeUnit3;
													bool bool_2 = (aircraft = this.GetParentPlatform()).IsTerrainFollowing(activeUnit3 = this.GetParentPlatform());
													float desiredAltitude4 = base.method_78(ref parentPlatform2, ActiveUnit.Throttle.Loiter, ref bool_2);
													aircraft.SetIsTerrainFollowing(activeUnit3, bool_2);
													activeUnit6.SetDesiredAltitude(desiredAltitude4);
												}
												this.m_ActiveUnit.GetKinematics().vmethod_23(elapsedTime_, false, false);
											}
										}
									}
								}
								break;
							case ActiveUnit._ActiveUnitStatus.FormingUp:
								if (this.m_ActiveUnit.IsGroupLead())
								{
									if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
									{
										this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
									}
									else
									{
										this.GetParentPlatform().GetAircraftKinematics().vmethod_23(elapsedTime_, false, false);
									}
								}
								else if (this.m_ActiveUnit.HasParentGroup())
								{
									if (this.m_ActiveUnit.GetParentGroup(false).GetGroupType() == Group.GroupType.AirGroup)
									{
										base.method_16(ref aircraftAirOps);
									}
									else
									{
										this.GetParentPlatform().GetAircraftKinematics().vmethod_23(elapsedTime_, false, false);
									}
								}
								else
								{
									this.GetParentPlatform().GetAircraftKinematics().vmethod_23(elapsedTime_, true, false);
								}
								break;
							case ActiveUnit._ActiveUnitStatus.OnSupportMission:
								if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Support)
								{
									if (this.m_ActiveUnit.HasParentGroup())
									{
										if (this.m_ActiveUnit.IsGroupLead())
										{
											this.m_ActiveUnit.GetNavigator().vmethod_6(elapsedTime_, this.m_ActiveUnit.GetNavigator().method_11());
										}
										else
										{
											base.method_16(ref aircraftAirOps);
										}
									}
									else
									{
										this.m_ActiveUnit.GetNavigator().vmethod_6(elapsedTime_, this.m_ActiveUnit.GetNavigator().method_11());
										if (this.GetParentPlatform().IsAirRefuelingCapable())
										{
											this.method_108();
										}
									}
								}
								break;
							case ActiveUnit._ActiveUnitStatus.OnFerryMission:
								if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Ferry)
								{
									FerryMission ferryMission2 = (FerryMission)this.m_ActiveUnit.GetAssignedMission(false);
									ActiveUnit.Throttle throttle4;
									if (!this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
									{
										if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
										{
											if (!Information.IsNothing(ferryMission2.FerryThrottle_Aircraft))
											{
												throttle4 = ferryMission2.FerryThrottle_Aircraft.Value;
											}
											else
											{
												throttle4 = ActiveUnit.Throttle.Cruise;
											}
										}
										else
										{
											throttle4 = ActiveUnit.Throttle.Cruise;
										}
									}
									else
									{
										throttle4 = this.m_ActiveUnit.GetThrottle();
									}
									float num10;
									if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
									{
										if (!Information.IsNothing(this.GetParentPlatform().GetLoadout()))
										{
											if (!Information.IsNothing(ferryMission2.FerryAltitude_Aircraft))
											{
												num10 = ferryMission2.FerryAltitude_Aircraft.Value;
											}
											else
											{
												Aircraft aircraft = this.GetParentPlatform();
												ActiveUnit.Throttle throttle_ = throttle4;
												ActiveUnit activeUnit2;
												Aircraft parentPlatform2;
												bool bool_2 = (parentPlatform2 = this.GetParentPlatform()).IsTerrainFollowing(activeUnit2 = this.GetParentPlatform());
												float num11 = base.method_78(ref aircraft, throttle_, ref bool_2);
												parentPlatform2.SetIsTerrainFollowing(activeUnit2, bool_2);
												num10 = num11;
											}
										}
										else
										{
											Aircraft parentPlatform2 = this.GetParentPlatform();
											ActiveUnit.Throttle throttle_2 = throttle4;
											Aircraft aircraft = null;
											ActiveUnit activeUnit2;
											bool bool_2 = (aircraft = this.GetParentPlatform()).IsTerrainFollowing(activeUnit2 = this.GetParentPlatform());
											float num12 = base.method_78(ref parentPlatform2, throttle_2, ref bool_2);
											aircraft.SetIsTerrainFollowing(activeUnit2, bool_2);
											num10 = num12;
										}
									}
									else
									{
										num10 = this.m_ActiveUnit.GetDesiredAltitude();
									}
									if (!this.m_ActiveUnit.IsNotGroupLead())
									{
										if (!Information.IsNothing(aircraftAirOps.GetAssignedHostUnit()))
										{
											Aircraft_Navigator aircraftNavigator3 = this.GetParentPlatform().GetAircraftNavigator();
											ActiveUnit assignedHostUnit = aircraftAirOps.GetAssignedHostUnit();
											float desiredSpeed_ = (float)this.m_ActiveUnit.GetKinematics().GetSpeed(this.GetParentPlatform().GetCurrentAltitude_ASL(false), throttle4);
											float desireAltitude_ = num10;
											bool bool_2 = false;
											aircraftNavigator3.method_68(assignedHostUnit, desiredSpeed_, desireAltitude_, ref bool_2);
										}
										else
										{
											string str = "";
											if (Operators.CompareString(this.m_ActiveUnit.Name, this.m_ActiveUnit.UnitClass, false) != 0)
											{
												str = " (" + this.m_ActiveUnit.UnitClass + ")";
											}
											this.m_ActiveUnit.m_Scenario.LogMessage("Aircraft " + this.m_ActiveUnit.Name + str + " is assigned to a ferry mission but it cannot land at the desired destination. Unassigning aircraft and returning to nearest base.", LoggedMessage.MessageType.AirOps, 0, null, this.m_ActiveUnit.GetSide(false), null);
											this.m_ActiveUnit.DeleteMission(false, null);
											this.m_ActiveUnit.GetAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
										}
									}
									else
									{
										base.method_16(ref aircraftAirOps);
									}
									if (this.GetParentPlatform().IsAirRefuelingCapable())
									{
										this.method_108();
									}
								}
								break;
							case ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint:
							{
								if (this.GetParentPlatform().IsNotGroupLead() && this.GetParentPlatform().GetParentGroup(false).GetGroupType() == Group.GroupType.AirGroup && !Information.IsNothing(this.GetParentPlatform().IsGroupLead()))
								{
									ActiveUnit groupLead = this.GetParentPlatform().GetParentGroup(false).GetGroupLead();
									if (groupLead.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || groupLead.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling)
									{
										base.method_16(ref aircraftAirOps);
										break;
									}
								}
								bool flag4 = true;
								if (this.m_ActiveUnit.m_Scenario.MinuteIsChangingOnThisPulse || Information.IsNothing(aircraftAirOps.GetA2ARefuelingDestinationAircraft()))
								{
									GeoPoint intermediateTargetPoint = base.GetIntermediateTargetPoint();
									Aircraft_AirOps aircraft_AirOps3 = aircraftAirOps;
									bool bool_2 = false;
									ActiveUnit activeUnit3 = null;
									List<Mission> missionList = null;
									string text = "";
									List<Aircraft> tankersForMe = aircraft_AirOps3.GetTankersForMe(ref bool_2, ref activeUnit3, true, missionList, ref text);
									if (!Information.IsNothing(aircraftAirOps.GetA2ARefuelingDestinationAircraft()) && tankersForMe.Contains(aircraftAirOps.GetA2ARefuelingDestinationAircraft()))
									{
										if (aircraftAirOps.CanRendezvousWith(aircraftAirOps.GetA2ARefuelingDestinationAircraft()))
										{
											flag4 = true;
										}
										else
										{
											Aircraft_AirOps aircraft_AirOps4 = aircraftAirOps;
											GeoPoint geoPoint_3 = intermediateTargetPoint;
											Doctrine._RefuelSelection value = this.m_ActiveUnit.m_Doctrine.GetRefuelSelectionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false, false).Value;
											bool_2 = false;
											activeUnit3 = null;
											List<Mission> list = null;
											text = "";
											bool flag2 = false;
											flag4 = aircraft_AirOps4.method_78(geoPoint_3, value, ref bool_2, ref activeUnit3, ref list, ref text, ref flag2);
										}
									}
									else if (tankersForMe.Count > 0)
									{
										Aircraft_AirOps aircraft_AirOps5 = aircraftAirOps;
										GeoPoint geoPoint_4 = intermediateTargetPoint;
										Doctrine._RefuelSelection value2 = this.m_ActiveUnit.m_Doctrine.GetRefuelSelectionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false, false).Value;
										bool flag2 = false;
										activeUnit3 = null;
										List<Mission> list = null;
										text = "";
										bool_2 = false;
										flag4 = aircraft_AirOps5.method_78(geoPoint_4, value2, ref flag2, ref activeUnit3, ref list, ref text, ref bool_2);
									}
									else
									{
										if (!Information.IsNothing(aircraftAirOps.GetA2ARefuelingDestinationAircraft()))
										{
											aircraftAirOps.A2ARefueling();
										}
										flag4 = false;
									}
								}
								if (!Information.IsNothing(aircraftAirOps.GetA2ARefuelingDestinationAircraft()) && flag4)
								{
									Aircraft a2ARefuelingDestinationAircraft = aircraftAirOps.GetA2ARefuelingDestinationAircraft();
									float horizontalRange = this.GetParentPlatform().GetHorizontalRange(a2ARefuelingDestinationAircraft);
									if (a2ARefuelingDestinationAircraft.GetAircraftCommStuff().IsNotOutOfComms())
									{
										this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.AzimuthTo(a2ARefuelingDestinationAircraft));
									}
									else
									{
										this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.AzimuthTo(a2ARefuelingDestinationAircraft.GetLatitudeLR().Value, a2ARefuelingDestinationAircraft.GetLongitudeLR().Value));
									}
									if ((double)horizontalRange < 0.1)
									{
										this.GetParentPlatform().SetDesiredSpeed(a2ARefuelingDestinationAircraft.GetCurrentSpeed());
										this.GetParentPlatform().SetDesiredAltitude(a2ARefuelingDestinationAircraft.GetCurrentAltitude_ASL(false));
										this.GetParentPlatform().SetThrottle(this.GetParentPlatform().GetAircraftKinematics().vmethod_38(a2ARefuelingDestinationAircraft.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.GetParentPlatform().GetDesiredSpeed()))), null);
									}
									else
									{
										this.GetParentPlatform().SetDesiredSpeed((float)this.GetParentPlatform().GetAircraftKinematics().GetSpeed(this.GetParentPlatform().GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Cruise));
										this.GetParentPlatform().SetThrottle(ActiveUnit.Throttle.Cruise, null);
										if (horizontalRange > 5f)
										{
											if (this.GetParentPlatform().IsTerrainFollowing(this.GetParentPlatform()))
											{
												ActiveUnit parentPlatform3 = this.GetParentPlatform();
												Aircraft_Navigator aircraftNavigator4 = this.GetParentPlatform().GetAircraftNavigator();
												bool bool_2 = false;
												parentPlatform3.SetDesiredAltitude_TerrainFollowing(aircraftNavigator4.GetTransitAltitude(ref bool_2));
											}
											else
											{
												Aircraft parentPlatform4 = this.GetParentPlatform();
												Aircraft_Navigator aircraftNavigator5 = this.GetParentPlatform().GetAircraftNavigator();
												bool bool_2 = false;
												parentPlatform4.SetDesiredAltitude(aircraftNavigator5.GetTransitAltitude(ref bool_2));
											}
										}
										else
										{
											this.GetParentPlatform().SetDesiredAltitude(a2ARefuelingDestinationAircraft.GetCurrentAltitude_ASL(false));
											this.GetParentPlatform().SetIsTerrainFollowing(this.GetParentPlatform(), false);
										}
									}
								}
								else
								{
									if (this.GetParentPlatform().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || this.GetParentPlatform().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling)
									{
										this.GetParentPlatform().SetUnitStatus(this.GetParentPlatform().SBR);
									}
									if (aircraftAirOps.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel || aircraftAirOps.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Refuelling)
									{
										aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
									}
								}
								break;
							}
							}
						}
						else
						{
							this.m_ActiveUnit.GetKinematics().SetDesiredSpeedOverride(null);
							this.GetParentPlatform().SetThrottle(ActiveUnit.Throttle.FullStop, null);
							this.GetParentPlatform().SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.GetParentPlatform().GetCurrentHeading());
							this.GetParentPlatform().SetDesiredAltitude(0f);
							this.GetParentPlatform().SetDesiredAltitude_TerrainFollowing(0f);
							if (!this.GetParentPlatform().IsOnLand())
							{
								aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
								aircraftAirOps.SetConditionTimer(0f);
							}
							else if (this.m_ActiveUnit.GetAltitude_AGL() > 45.72f | this.m_ActiveUnit.GetCurrentSpeed() > 10f)
							{
								aircraftAirOps.SetConditionTimer(120f);
							}
							else
							{
								aircraftAirOps.method_87();
								aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
								aircraftAirOps.SetConditionTimer(0f);
							}
						}
					}
					else
					{
						this.m_ActiveUnit.GetKinematics().SetDesiredSpeedOverride(null);
						this.GetParentPlatform().SetThrottle(ActiveUnit.Throttle.FullStop, null);
						this.GetParentPlatform().SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.GetParentPlatform().GetCurrentHeading());
						this.GetParentPlatform().SetDesiredAltitude(45.72f);
						if (!this.GetParentPlatform().IsOnLand() && !ArcticSeaIce.IsNearMarginalIceZone(this.GetParentPlatform().GetLongitude(null), this.GetParentPlatform().GetLatitude(null)))
						{
							if (this.m_ActiveUnit.GetCurrentAltitude_ASL(false) > 45.72f)
							{
								aircraftAirOps.SetConditionTimer(240f);
							}
						}
						else
						{
							aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
							aircraftAirOps.SetConditionTimer(0f);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100392", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x001CA88C File Offset: 0x001C8A8C
		public float GetStationAltitude(ref Aircraft aircraft_, ActiveUnit.Throttle throttle_, bool bool_6, ref bool bStationAltitudeTerrainFollowing)
		{
			float num = 0f;
			float num2 = 0f;
			float result;
			try
			{
				if (!Information.IsNothing(aircraft_.GetLoadout()))
				{
					LoadoutMissionProfile missionProfile = aircraft_.GetLoadout().GetMissionProfile(this.m_ActiveUnit.m_Scenario);
					num = missionProfile.StationAltitude;
					bStationAltitudeTerrainFollowing = missionProfile.StationAltitudeTerrainFollowing;
					if (num > 0f)
					{
						num2 = num;
						result = num2;
						return result;
					}
					num = missionProfile.AttackAltitudeIngress;
					bStationAltitudeTerrainFollowing = missionProfile.AttackAltitudeIngressTerrainFollowing;
					if (num > 0f)
					{
						num2 = num;
						result = num2;
						return result;
					}
					num = missionProfile.CruiseAltitudeIngress;
					bStationAltitudeTerrainFollowing = missionProfile.CruiseAltitudeIngressTerrainFollowing;
					if (num > 0f)
					{
						num2 = num;
						result = num2;
						return result;
					}
				}
				if (!bool_6)
				{
					if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike && ((Strike)this.m_ActiveUnit.GetAssignedMission(false)).strikeType == Strike.StrikeType.Sub_Strike)
					{
						num = 304.800018f;
						bStationAltitudeTerrainFollowing = false;
					}
					else
					{
						num = base.method_78(ref aircraft_, throttle_, ref bStationAltitudeTerrainFollowing);
					}
				}
				num2 = num;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = num2;
			return result;
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x001CA9E4 File Offset: 0x001C8BE4
		private bool method_104()
		{
			bool result;
			try
			{
				if (Information.IsNothing(this.m_ActiveUnit))
				{
					result = false;
				}
				else if (this.GetParentPlatform().GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
				{
					bool flag = false;
					bool flag2 = false;
					if (Information.IsNothing(this.GetPrimaryTarget()) || this.GetPrimaryTarget().IsSubSurface())
					{
						bool flag3 = false;
						CommDevice[] commDevices = this.m_ActiveUnit.GetCommDevices();
						for (int i = 0; i < commDevices.Length; i++)
						{
							CommDevice commDevice = commDevices[i];
							if (commDevice.IsSonobuoyLink() && commDevice.GetOccupiedChannels() < commDevice.MaxChannels)
							{
								flag3 = true;
								break;
							}
						}
						if (flag3)
						{
							Weapon[] availableWeapons = this.GetParentPlatform().GetAircraftWeaponry().GetAvailableWeapons(false);
							for (int j = 0; j < availableWeapons.Length; j++)
							{
								Weapon weapon = availableWeapons[j];
								if (weapon.GetWeaponType() == Weapon._WeaponType.Sonobuoy && this.GetParentPlatform().GetAircraftWeaponry().GetCurrentLoadForWeapon(weapon.DBID, false) > 0)
								{
									flag = true;
									break;
								}
							}
							if (flag)
							{
								if ((float)this.m_ActiveUnit.GetTerrainElevation(false, false, false) <= -20f)
								{
									Contact primaryTarget = this.GetPrimaryTarget();
									if (!Information.IsNothing(primaryTarget))
									{
										if (!Information.IsNothing(primaryTarget.GetUncertaintyArea()))
										{
											ActiveUnit_Navigator navigator = this.m_ActiveUnit.GetNavigator();
											Contact contact = primaryTarget;
											Contact contact2 = contact;
											List<GeoPoint> list = contact.GetUncertaintyArea();
											Contact contact3 = primaryTarget;
											Contact contact4 = contact3;
											List<GeoPoint> list_ = contact3.method_106();
											Contact contact5 = primaryTarget;
											Contact contact6 = contact5;
											List<GeoPoint> list2 = contact5.method_110();
											bool flag4 = navigator.method_34(ref list, ref list_, ref list2, 1f);
											contact6.method_111(list2);
											contact4.method_107(list_);
											contact2.SetUncertaintyArea(list);
											if (flag4)
											{
												flag2 = true;
											}
										}
										else if (!primaryTarget.GetIsPreciselyLocatedOnThisPulse() && this.GetParentPlatform().GetHorizontalRange(primaryTarget) < 2f)
										{
											flag2 = true;
										}
									}
									if (!flag2)
									{
										Mission assignedMission = this.GetParentPlatform().GetAssignedMission(false);
										if (!Information.IsNothing(assignedMission) && assignedMission.MissionClass == Mission._MissionClass.Patrol)
										{
											Patrol patrol = (Patrol)assignedMission;
											GlobalVariables.PatrolType patrolType = patrol.patrolType;
											if (patrolType != GlobalVariables.PatrolType.ASW && patrolType != GlobalVariables.PatrolType.SeaControl)
											{
												flag2 = false;
											}
											else if (!Information.IsNothing(patrol.PatrolAreaVertices))
											{
												if (!Information.IsNothing(primaryTarget))
												{
													if (!Information.IsNothing(primaryTarget.GetUncertaintyArea()))
													{
														ActiveUnit_Navigator navigator2 = this.m_ActiveUnit.GetNavigator();
														Contact contact7 = primaryTarget;
														Contact contact6 = contact7;
														List<GeoPoint> list2 = contact7.GetUncertaintyArea();
														Contact contact8 = primaryTarget;
														Contact contact4 = contact8;
														List<GeoPoint> list_ = contact8.method_108();
														Contact contact9 = primaryTarget;
														Contact contact2 = contact9;
														List<GeoPoint> list = contact9.method_110();
														bool flag5 = navigator2.method_34(ref list2, ref list_, ref list, 5f);
														contact2.method_111(list);
														contact4.method_109(list_);
														contact6.SetUncertaintyArea(list2);
														if (flag5)
														{
															flag2 = true;
														}
													}
												}
												else if (this.GetParentPlatform().GetAircraftAI().method_31())
												{
													flag2 = true;
												}
											}
										}
									}
								}
								else
								{
									flag2 = false;
								}
							}
							result = flag2;
						}
						else
						{
							result = false;
						}
					}
					else
					{
						result = false;
					}
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
				ex2.Data.Add("Error at 100393", "");
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

		// Token: 0x060049FF RID: 18943 RVA: 0x001CAD7C File Offset: 0x001C8F7C
		public override void UpdateMissionStatus(float elapsedTime)
		{
			try
			{
				if (this.method_104())
				{
					Aircraft_AI.SonobuoysDropMan sonobuoysDropMan = new Aircraft_AI.SonobuoysDropMan();
					sonobuoysDropMan.aircraft_AI = this;
					sonobuoysDropMan.bEnableDrop = true;
					List<Weapon> list = new List<Weapon>();
					list.AddRange(this.GetParentPlatform().m_Scenario.GetSonobuoysInWater());
					Parallel.ForEach<Weapon>(list, new Action<Weapon, ParallelLoopState>(sonobuoysDropMan.CheckDropCondition));
					if (sonobuoysDropMan.bEnableDrop)
					{
						this.GetParentPlatform().GetAircraftWeaponry().DropSonobuoys(elapsedTime, null, null);
					}
				}
				base.UpdateMissionStatus(elapsedTime);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100395", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x001CAE60 File Offset: 0x001C9060
		public override void vmethod_22(float elapsedTime_, ref Weapon weapon_)
		{
			if (Information.IsNothing(this.GetPrimaryTarget().ActualUnit))
			{
				ActiveUnit activeUnit = this.m_ActiveUnit;
				Aircraft parentPlatform = this.GetParentPlatform();
				ActiveUnit activeUnit2;
				ActiveUnit activeUnit3;
				bool bool_ = (activeUnit2 = this.m_ActiveUnit).IsTerrainFollowing(activeUnit3 = this.m_ActiveUnit);
				float desiredAltitude = base.method_78(ref parentPlatform, ActiveUnit.Throttle.Cruise, ref bool_);
				activeUnit2.SetIsTerrainFollowing(activeUnit3, bool_);
				activeUnit.SetDesiredAltitude(desiredAltitude);
			}
			else
			{
				try
				{
					switch (this.GetPrimaryTarget().contactType)
					{
					case Contact_Base.ContactType.Air:
					case Contact_Base.ContactType.Missile:
					case Contact_Base.ContactType.Orbital:
					case Contact_Base.ContactType.Decoy_Air:
						if (this.GetPrimaryTarget().ActualUnit.IsAircraft && ((Aircraft)this.GetPrimaryTarget().ActualUnit).IsAirship())
						{
							this.method_106(elapsedTime_, this.GetPrimaryTarget().contactType, weapon_);
						}
						else
						{
							this.method_95(elapsedTime_);
						}
						break;
					case Contact_Base.ContactType.Surface:
					case Contact_Base.ContactType.UndeterminedNaval:
					case Contact_Base.ContactType.Aimpoint:
					case Contact_Base.ContactType.Facility_Fixed:
					case Contact_Base.ContactType.Facility_Mobile:
					case Contact_Base.ContactType.Mine:
					case Contact_Base.ContactType.Decoy_Surface:
					case Contact_Base.ContactType.Decoy_Land:
					case Contact_Base.ContactType.Sonobuoy:
					case Contact_Base.ContactType.Installation:
					case Contact_Base.ContactType.AirBase:
					case Contact_Base.ContactType.NavalBase:
					case Contact_Base.ContactType.MobileGroup:
					case Contact_Base.ContactType.ActivationPoint:
						this.method_106(elapsedTime_, this.GetPrimaryTarget().contactType, weapon_);
						break;
					case Contact_Base.ContactType.Submarine:
					case Contact_Base.ContactType.Torpedo:
					case Contact_Base.ContactType.Decoy_Sub:
						this.method_106(elapsedTime_, this.GetPrimaryTarget().contactType, weapon_);
						break;
					case Contact_Base.ContactType.Explosion:
					case Contact_Base.ContactType.Undetermined:
						throw new NotImplementedException();
					default:
						throw new NotImplementedException();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100397", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x001CB010 File Offset: 0x001C9210
		private void method_106(float float_1, Contact_Base.ContactType contactType_, Weapon weapon_)
		{
			if (Information.IsNothing(this.GetPrimaryTarget()))
			{
				ActiveUnit activeUnit = this.m_ActiveUnit;
				Aircraft parentPlatform = this.GetParentPlatform();
				bool bool_ = false;
				activeUnit.SetDesiredAltitude(this.GetStationAltitude(ref parentPlatform, ActiveUnit.Throttle.Cruise, false, ref bool_));
				if (!this.m_ActiveUnit.IsNotGroupLead())
				{
					this.m_ActiveUnit.SetIsTerrainFollowing(this.m_ActiveUnit, bool_);
				}
			}
			else
			{
				try
				{
					Aircraft_AI.WeaponRange weaponRange = new Aircraft_AI.WeaponRange();
					weaponRange.aircraft_AI = this;
					weaponRange.doctrine = this.m_ActiveUnit.m_Doctrine;
					Weapon weapon = weapon_;
					if (Information.IsNothing(weapon))
					{
						Side side = this.m_ActiveUnit.GetSide(false);
						Contact primaryTarget = this.GetPrimaryTarget();
						List<Weapon> weaponsForTarget = side.GetWeaponsForTarget(ref this.m_ActiveUnit, ref primaryTarget);
						this.SetPrimaryTarget(primaryTarget);
						List<Weapon> list = weaponsForTarget;
						if (list.Count > 0)
						{
							weapon = list.OrderByDescending(new Func<Weapon, float>(weaponRange.GetMaxRangeToPrimaryTarget)).ElementAtOrDefault(0);
						}
						else
						{
							weapon = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), true, true, weaponRange.doctrine);
						}
					}
					if (Information.IsNothing(weapon))
					{
						weapon = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), false, true, weaponRange.doctrine);
					}
					if (Information.IsNothing(weapon))
					{
						ActiveUnit activeUnit2 = this.m_ActiveUnit;
						Aircraft parentPlatform = this.GetParentPlatform();
						bool bool_2 = false;
						activeUnit2.SetDesiredAltitude(this.GetStationAltitude(ref parentPlatform, ActiveUnit.Throttle.Cruise, false, ref bool_2));
						if (!this.m_ActiveUnit.IsNotGroupLead())
						{
							this.m_ActiveUnit.SetIsTerrainFollowing(this.m_ActiveUnit, bool_2);
						}
					}
					else
					{
						float maxRangeToTarget = weapon.GetMaxRangeToTarget(this.m_ActiveUnit, this.GetPrimaryTarget(), true, weaponRange.doctrine, false);
						float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
						float? num = null;
						bool flag = false;
						ActiveUnit.Throttle? throttle = null;
						float? num2 = null;
						Patrol patrol = null;
						float num3;
						if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
						{
							patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
							num2 = patrol.AttackDistance_Aircraft;
							if (Information.IsNothing(num2))
							{
								num3 = (float)Math.Max((double)(10f + maxRangeToTarget), (double)maxRangeToTarget * 1.2);
							}
							else
							{
								float? num4 = num2;
								float num5 = maxRangeToTarget;
								num3 = (num4.HasValue ? new float?(num4.GetValueOrDefault() + num5) : null).Value;
							}
						}
						else
						{
							num3 = (float)Math.Max((double)(10f + maxRangeToTarget), (double)maxRangeToTarget * 1.2);
						}
						Aircraft_Navigator aircraft_Navigator = null;
						Aircraft_AirOps aircraft_AirOps = null;
						if (!this.m_ActiveUnit.HasTrackingAndDirectingSensor())
						{
							float val = (float)this.GetPrimaryTarget().GetTerrainElevation(true, false, false);
							float val2 = (float)this.m_ActiveUnit.GetTerrainElevation(true, false, false);
							float val3 = (float)this.m_ActiveUnit.GetAltitude_ASL(true, float_1);
							float num6 = Math.Max(Math.Max(val2, val), val3);
							float num7 = this.m_ActiveUnit.GetDesiredAltitude();
							float num8 = this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing();
							bool bool_3 = false;
							if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride() && !Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
							{
								if (Information.IsNothing(patrol))
								{
									patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
								}
								if (!Information.IsNothing(num2) && horizontalRange > num3)
								{
									num = patrol.TransitAltitude_Aircraft;
									flag = patrol.TransitTerrainFollowing_Aircraft;
								}
								else
								{
									num = patrol.AttackAltitude_Aircraft;
									flag = patrol.AttackTerrainFollowing_Aircraft;
								}
							}
							bool flag2 = false;
							float num9 = 0f;
							float num10;
							float num11;
							if (!Information.IsNothing(num))
							{
								num10 = num.Value;
								num11 = num.Value;
								if (flag2 = flag)
								{
									num9 = num10;
								}
								if (flag2)
								{
									num11 += num6;
								}
							}
							else
							{
								Aircraft parentPlatform = this.GetParentPlatform();
								num10 = this.GetStationAltitude(ref parentPlatform, ActiveUnit.Throttle.Cruise, true, ref flag2);
								num11 = num10;
								if (flag2)
								{
									num9 = num10;
								}
								if (flag2)
								{
									num11 += num6;
								}
							}
							float? num12 = null;
							Weapon._WeaponType weaponType = weapon.GetWeaponType();
							float num13 = 0f;
							float num14 = 0f;
							if (weaponType != Weapon._WeaponType.Rocket && weaponType != Weapon._WeaponType.Gun)
							{
								if (weapon.LaunchAltitudeMax > 0f && weapon.LaunchAltitudeMax_ASL == 0f)
								{
									num13 = weapon.LaunchAltitudeMax + num6;
									num14 = weapon.LaunchAltitudeMax;
								}
								else if (weapon.LaunchAltitudeMax == 0f && weapon.LaunchAltitudeMax_ASL > 0f)
								{
									num13 = weapon.LaunchAltitudeMax_ASL;
									num14 = weapon.LaunchAltitudeMax_ASL - num6;
								}
								else if (weapon.LaunchAltitudeMax > 0f && weapon.LaunchAltitudeMax_ASL > 0f)
								{
									num13 = Math.Min(weapon.LaunchAltitudeMax + num6, weapon.LaunchAltitudeMax_ASL);
									num14 = Math.Min(weapon.LaunchAltitudeMax_ASL - num6, weapon.LaunchAltitudeMax);
								}
							}
							else if (this.m_ActiveUnit.GetSlantRange(this.GetPrimaryTarget(), 0f) > maxRangeToTarget)
							{
								num13 = (float)(Math.Sqrt(2.0) / 2.0 * (double)maxRangeToTarget * 1852.0 + (double)num6);
								num14 = (float)(Math.Sqrt(2.0) / 2.0 * (double)maxRangeToTarget * 1852.0);
							}
							float num15 = 0f;
							float num16 = 0f;
							if (weapon.LaunchAltitudeMin > 0f && weapon.LaunchAltitudeMin_ASL == 0f)
							{
								num15 = weapon.LaunchAltitudeMin + num6;
								num16 = weapon.LaunchAltitudeMin;
							}
							else if (weapon.LaunchAltitudeMin == 0f && weapon.LaunchAltitudeMin_ASL > 0f)
							{
								num15 = weapon.LaunchAltitudeMin_ASL;
								num16 = weapon.LaunchAltitudeMin_ASL - num6;
							}
							else if (weapon.LaunchAltitudeMin > 0f && weapon.LaunchAltitudeMin_ASL > 0f)
							{
								num15 = Math.Max(weapon.LaunchAltitudeMin + num6, weapon.LaunchAltitudeMin_ASL);
								num16 = Math.Max(weapon.LaunchAltitudeMin_ASL - num6, weapon.LaunchAltitudeMin);
							}
							else if (weapon.LaunchAltitudeMin == 0f && weapon.LaunchAltitudeMin_ASL < 0f)
							{
								num15 = weapon.LaunchAltitudeMin + num6;
								num16 = weapon.LaunchAltitudeMin;
							}
							bool flag3;
							if (!Information.IsNothing(num))
							{
								flag3 = true;
							}
							else if (num11 > 0f)
							{
								if (!flag2 && num13 >= num11 && num15 <= num11)
								{
									flag3 = (this.m_ActiveUnit.GetDesiredAltitude() == num10 && this.m_ActiveUnit.IsTerrainFollowing(this.m_ActiveUnit) == flag2);
								}
								else
								{
									flag3 = (flag2 && num14 + num6 >= num11 && num16 + num6 <= num11 && this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing() == num9 && this.m_ActiveUnit.IsTerrainFollowing(this.m_ActiveUnit) == flag2);
								}
							}
							else
							{
								flag3 = false;
							}
							if (flag3)
							{
								num7 = num11;
								num8 = num9;
								bool_3 = flag2;
								if (!Information.IsNothing(weapon_))
								{
									if (num7 < num6 + this.GetParentPlatform().GetAllowedMinAltitude())
									{
										num7 += num6;
									}
									if (num8 < num6 + this.GetParentPlatform().GetAllowedMinAltitude())
									{
										num8 += num6;
									}
								}
								if (num11 <= 0f && num9 <= 0f)
								{
									if (num7 > num13)
									{
										num7 = num13;
									}
									if (num7 < num15)
									{
										num7 = num15;
									}
									if (num8 > num14)
									{
										num8 = num14;
									}
									if (num8 < num16)
									{
										num8 = num16;
									}
								}
								else
								{
									if (num15 > num7)
									{
										num7 = num15;
									}
									else if (num13 < num7)
									{
										num7 = num13;
									}
									else
									{
										if (num7 > num13)
										{
											num7 = num13;
										}
										if (num7 < num15)
										{
											num7 = num15;
										}
									}
									if (num16 > num8)
									{
										num8 = num16;
									}
									else if (num14 < num8)
									{
										num8 = num14;
									}
									else
									{
										if (num8 > num14)
										{
											num8 = num14;
										}
										if (num8 < num16)
										{
											num8 = num16;
										}
									}
								}
								if (weapon.method_132(this.GetPrimaryTarget().IsSurfaceOrLandTarget()))
								{
									num12 = this.method_107(2.14748365E+09f);
								}
								if (!Information.IsNothing(num12))
								{
									if ((num12.HasValue ? new bool?(num15 > num12.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										if (this.m_ActiveUnit.m_Scenario.ThirtiethSecondIsChangingOnThisPulse)
										{
											string str = "";
											if (Operators.CompareString(this.GetParentPlatform().Name, this.GetParentPlatform().UnitClass, false) != 0)
											{
												str = " (" + this.GetParentPlatform().UnitClass + ")";
											}
											this.GetParentPlatform().LogMessage(this.GetParentPlatform().Name + str + "不能打击地面目标，这是由于云层太低，没有足够的高度间隔来部署武器.", LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetParentPlatform().GetLongitude(null), this.GetParentPlatform().GetLatitude(null)));
										}
									}
									else if ((num12.HasValue ? new bool?(num7 > num12.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										num7 = num12.Value;
										float? num4 = num12;
										float num5 = num6;
										num8 = (num4.HasValue ? new float?(num4.GetValueOrDefault() - num5) : null).Value;
										num13 = num7;
										num14 = num8;
									}
								}
								if (this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
								{
									if (this.m_ActiveUnit.GetDesiredAltitude() > num13)
									{
										this.m_ActiveUnit.SetDesiredAltitude(num13);
									}
									if (this.m_ActiveUnit.GetDesiredAltitude() < num15)
									{
										this.m_ActiveUnit.SetDesiredAltitude(num15);
									}
									if (this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing() > num14)
									{
										this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num14);
									}
									if (this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing() < num16)
									{
										this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num16);
									}
								}
								else if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike && (this.GetParentPlatform().GetAircraftNavigator().method_25() || (this.m_ActiveUnit.IsNotGroupLead() && !Information.IsNothing(this.m_ActiveUnit.IsGroupLead()) && this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().method_25())))
								{
									if (num7 != this.m_ActiveUnit.GetCurrentAltitude_ASL(false))
									{
										this.m_ActiveUnit.SetDesiredAltitude(num7);
										this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
									}
									else
									{
										this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false));
										this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
									}
								}
								else if (!Information.IsNothing(num))
								{
									this.m_ActiveUnit.SetDesiredAltitude(num7);
									this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
									this.m_ActiveUnit.SetIsTerrainFollowing(this.m_ActiveUnit, bool_3);
								}
								else
								{
									float num17 = Math.Abs(this.m_ActiveUnit.GetKinematics().method_16(this.m_ActiveUnit, num7, 0f));
									if (horizontalRange <= num3 + num17)
									{
										if (num7 != this.m_ActiveUnit.GetCurrentAltitude_ASL(false))
										{
											this.m_ActiveUnit.SetDesiredAltitude(num7);
											this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
										}
										else
										{
											this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false));
											this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
										}
									}
									else if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike)
									{
										ActiveUnit activeUnit3 = this.m_ActiveUnit;
										ActiveUnit_AI aI = this.m_ActiveUnit.GetAI();
										Aircraft parentPlatform = this.GetParentPlatform();
										ActiveUnit activeUnit4;
										ActiveUnit activeUnit5;
										bool bool_4 = (activeUnit4 = this.m_ActiveUnit).IsTerrainFollowing(activeUnit5 = this.m_ActiveUnit);
										float desiredAltitude = aI.method_78(ref parentPlatform, ActiveUnit.Throttle.Cruise, ref bool_4);
										activeUnit4.SetIsTerrainFollowing(activeUnit5, bool_4);
										activeUnit3.SetDesiredAltitude(desiredAltitude);
									}
									else if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
									{
										if (!Information.IsNothing(num2) && horizontalRange > num3)
										{
											if (Information.IsNothing(aircraft_Navigator))
											{
												aircraft_Navigator = this.GetParentPlatform().GetAircraftNavigator();
											}
											if (Information.IsNothing(aircraft_AirOps))
											{
												aircraft_AirOps = this.GetParentPlatform().GetAircraftAirOps();
											}
											aircraft_Navigator.method_58(false, aircraft_AirOps.GetAirOpsCondition());
										}
										else
										{
											Aircraft parentPlatform = this.GetParentPlatform();
											ActiveUnit activeUnit4;
											ActiveUnit activeUnit5;
											bool bool_4 = (activeUnit5 = this.m_ActiveUnit).IsTerrainFollowing(activeUnit4 = this.m_ActiveUnit);
											float stationAltitude = this.GetStationAltitude(ref parentPlatform, ActiveUnit.Throttle.Cruise, false, ref bool_4);
											activeUnit5.SetIsTerrainFollowing(activeUnit4, bool_4);
											num7 = stationAltitude;
											this.m_ActiveUnit.SetDesiredAltitude(num7);
											this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num7);
										}
									}
									else
									{
										if (Information.IsNothing(aircraft_Navigator))
										{
											aircraft_Navigator = this.GetParentPlatform().GetAircraftNavigator();
										}
										Aircraft_Navigator aircraft_Navigator2 = aircraft_Navigator;
										ActiveUnit activeUnit4;
										ActiveUnit activeUnit5;
										bool bool_4 = (activeUnit4 = this.m_ActiveUnit).IsTerrainFollowing(activeUnit5 = this.m_ActiveUnit);
										float transitAltitude = aircraft_Navigator2.GetTransitAltitude(ref bool_4);
										activeUnit4.SetIsTerrainFollowing(activeUnit5, bool_4);
										num7 = transitAltitude;
										this.m_ActiveUnit.SetDesiredAltitude(num7);
										this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num7);
										this.m_ActiveUnit.SetIsTerrainFollowing(this.m_ActiveUnit, bool_3);
									}
								}
							}
							else
							{
								if (!Information.IsNothing(weapon_))
								{
									if (num7 < num6 + this.GetParentPlatform().GetAllowedMinAltitude())
									{
										num7 += num6;
									}
									if (num8 < num6 + this.GetParentPlatform().GetAllowedMinAltitude())
									{
										num8 += num6;
									}
								}
								if (num7 > num13)
								{
									num7 = num13;
								}
								if (num7 < num15)
								{
									num7 = num15;
								}
								if (num8 > num14)
								{
									num8 = num14;
								}
								if (num8 < num16)
								{
									num8 = num16;
								}
								if (weapon.method_132(this.GetPrimaryTarget().IsSurfaceOrLandTarget()))
								{
									num12 = this.method_107(2.14748365E+09f);
								}
								if (!Information.IsNothing(num12))
								{
									if ((num12.HasValue ? new bool?(num15 > num12.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										if (this.m_ActiveUnit.m_Scenario.ThirtiethSecondIsChangingOnThisPulse)
										{
											string str2 = "";
											if (Operators.CompareString(this.GetParentPlatform().Name, this.GetParentPlatform().UnitClass, false) != 0)
											{
												str2 = " (" + this.GetParentPlatform().UnitClass + ")";
											}
											this.GetParentPlatform().LogMessage(this.GetParentPlatform().Name + str2 + " cannot engage ground targets because the cloud cover is too low. There will not be enough altitude clearance to deploy weapon.", LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetParentPlatform().GetLongitude(null), this.GetParentPlatform().GetLatitude(null)));
										}
									}
									else if ((num12.HasValue ? new bool?(num7 > num12.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										num7 = num12.Value;
										float? num4 = num12;
										float num5 = num6;
										num8 = (num4.HasValue ? new float?(num4.GetValueOrDefault() - num5) : null).Value;
										num13 = num7;
										num14 = num8;
									}
								}
								if (this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
								{
									if (this.m_ActiveUnit.GetDesiredAltitude() > num13)
									{
										this.m_ActiveUnit.SetDesiredAltitude(num13);
									}
									if (this.m_ActiveUnit.GetDesiredAltitude() < num15)
									{
										this.m_ActiveUnit.SetDesiredAltitude(num15);
									}
									if (this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing() > num14)
									{
										this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num14);
									}
									if (this.m_ActiveUnit.GetDesiredAltitude_TerrainFollowing() < num16)
									{
										this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num16);
									}
								}
								else if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike && (this.GetParentPlatform().GetAircraftNavigator().method_25() || (this.m_ActiveUnit.IsNotGroupLead() && !Information.IsNothing(this.m_ActiveUnit.IsGroupLead()) && this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetNavigator().method_25())))
								{
									if (num7 != this.m_ActiveUnit.GetCurrentAltitude_ASL(false))
									{
										this.m_ActiveUnit.SetDesiredAltitude(num7);
										this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
									}
									else
									{
										this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false));
										this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
									}
								}
								else if (!Information.IsNothing(num))
								{
									this.m_ActiveUnit.SetDesiredAltitude(num7);
									this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
									this.m_ActiveUnit.SetIsTerrainFollowing(this.m_ActiveUnit, bool_3);
								}
								else
								{
									float num17 = Math.Abs(this.m_ActiveUnit.GetKinematics().method_16(this.m_ActiveUnit, num7, 0f));
									if (horizontalRange <= num3 + num17)
									{
										if (num7 != this.m_ActiveUnit.GetCurrentAltitude_ASL(false))
										{
											this.m_ActiveUnit.SetDesiredAltitude(num7);
											this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
										}
										else
										{
											this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false));
											this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
										}
									}
									else if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike)
									{
										ActiveUnit activeUnit6 = this.m_ActiveUnit;
										ActiveUnit_AI aI2 = this.m_ActiveUnit.GetAI();
										Aircraft parentPlatform = this.GetParentPlatform();
										ActiveUnit activeUnit4;
										ActiveUnit activeUnit5;
										bool bool_4 = (activeUnit5 = this.m_ActiveUnit).IsTerrainFollowing(activeUnit4 = this.m_ActiveUnit);
										float desiredAltitude2 = aI2.method_78(ref parentPlatform, ActiveUnit.Throttle.Cruise, ref bool_4);
										activeUnit5.SetIsTerrainFollowing(activeUnit4, bool_4);
										activeUnit6.SetDesiredAltitude(desiredAltitude2);
									}
									else if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
									{
										if (!Information.IsNothing(num2) && horizontalRange > num3)
										{
											if (Information.IsNothing(aircraft_Navigator))
											{
												aircraft_Navigator = this.GetParentPlatform().GetAircraftNavigator();
											}
											if (Information.IsNothing(aircraft_AirOps))
											{
												aircraft_AirOps = this.GetParentPlatform().GetAircraftAirOps();
											}
											aircraft_Navigator.method_58(false, aircraft_AirOps.GetAirOpsCondition());
										}
										else
										{
											Aircraft parentPlatform = this.GetParentPlatform();
											ActiveUnit activeUnit4;
											ActiveUnit activeUnit5;
											bool bool_4 = (activeUnit4 = this.m_ActiveUnit).IsTerrainFollowing(activeUnit5 = this.m_ActiveUnit);
											float stationAltitude2 = this.GetStationAltitude(ref parentPlatform, ActiveUnit.Throttle.Cruise, false, ref bool_4);
											activeUnit4.SetIsTerrainFollowing(activeUnit5, bool_4);
											num7 = stationAltitude2;
											this.m_ActiveUnit.SetDesiredAltitude(num7);
											this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
										}
									}
									else
									{
										if (Information.IsNothing(aircraft_Navigator))
										{
											aircraft_Navigator = this.GetParentPlatform().GetAircraftNavigator();
										}
										Aircraft_Navigator aircraft_Navigator3 = aircraft_Navigator;
										ActiveUnit activeUnit4;
										ActiveUnit activeUnit5;
										bool bool_4 = (activeUnit5 = this.m_ActiveUnit).IsTerrainFollowing(activeUnit4 = this.m_ActiveUnit);
										float transitAltitude2 = aircraft_Navigator3.GetTransitAltitude(ref bool_4);
										activeUnit5.SetIsTerrainFollowing(activeUnit4, bool_4);
										num7 = transitAltitude2;
										this.m_ActiveUnit.SetDesiredAltitude(num7);
										this.m_ActiveUnit.SetDesiredAltitude_TerrainFollowing(num8);
										this.m_ActiveUnit.SetIsTerrainFollowing(this.m_ActiveUnit, bool_3);
									}
								}
							}
						}
						if (!this.GetParentPlatform().GetAircraftKinematics().GetDesiredSpeedOverride().HasValue)
						{
							if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
							{
								if (Information.IsNothing(patrol))
								{
									patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
								}
								if (!Information.IsNothing(num2) && horizontalRange > num3)
								{
									throttle = patrol.TransitThrottle_Aircraft;
								}
								else
								{
									throttle = patrol.AttackThrottle_Aircraft;
								}
							}
							if (!Information.IsNothing(throttle))
							{
								this.m_ActiveUnit.SetThrottle(throttle.Value, null);
							}
							else if (horizontalRange > num3)
							{
								this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
							}
							else
							{
								if (Information.IsNothing(aircraft_Navigator))
								{
									aircraft_Navigator = this.GetParentPlatform().GetAircraftNavigator();
								}
								if (Information.IsNothing(aircraft_AirOps))
								{
									aircraft_AirOps = this.GetParentPlatform().GetAircraftAirOps();
								}
								aircraft_Navigator.method_61(this.m_ActiveUnit.GetDesiredAltitude(), new float?((float)this.m_ActiveUnit.GetKinematics().GetSpeed(this.m_ActiveUnit.GetDesiredAltitude(), ActiveUnit.Throttle.Cruise)), false, aircraft_AirOps.GetAirOpsCondition());
								if (weapon.LaunchSpeedMax != 0 && (float)weapon.LaunchSpeedMax < this.m_ActiveUnit.GetDesiredSpeed())
								{
									this.m_ActiveUnit.SetDesiredSpeed((float)weapon.LaunchSpeedMax);
								}
								if (weapon.LaunchSpeedMin != 0 && (float)weapon.LaunchSpeedMin > this.m_ActiveUnit.GetDesiredSpeed())
								{
									this.m_ActiveUnit.SetDesiredSpeed((float)weapon.LaunchSpeedMin);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200351", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x001CC768 File Offset: 0x001CA968
		private float? method_107(float float_1)
		{
			Weather.WeatherProfile weatherProfile = Weather.GetWeatherProfile(this.m_ActiveUnit.m_Scenario, this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), (int)Math.Round((double)this.m_ActiveUnit.GetCurrentAltitude_ASL(false)));
			float? num = null;
			float? num2 = null;
			float? result;
			if (weatherProfile.struct31_0.int_8 > 0 && float_1 >= (float)weatherProfile.struct31_0.int_6)
			{
				if ((float)weatherProfile.struct31_0.int_7 > float_1)
				{
					num2 = num;
					result = num2;
					return result;
				}
				num = new float?((float)weatherProfile.struct31_0.int_6);
			}
			if (weatherProfile.struct31_0.int_5 > 0 && float_1 >= (float)weatherProfile.struct31_0.int_3)
			{
				if (Information.IsNothing(num) && (float)weatherProfile.struct31_0.int_4 > float_1)
				{
					num = null;
				}
				else
				{
					num = new float?((float)weatherProfile.struct31_0.int_3);
				}
			}
			if (weatherProfile.struct31_0.int_2 > 0 && float_1 >= (float)weatherProfile.struct31_0.int_0)
			{
				if (Information.IsNothing(num) && (float)weatherProfile.struct31_0.int_1 > float_1)
				{
					num = null;
				}
				else
				{
					num = new float?((float)weatherProfile.struct31_0.int_0);
				}
			}
			num2 = num;
			result = num2;
			return result;
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x001CC8F4 File Offset: 0x001CAAF4
		private void method_108()
		{
			try
			{
				List<Aircraft> list = new List<Aircraft>();
				if (this.GetParentPlatform().GetAircraftAirOps().GetRefuellingQueue().Count > 0)
				{
                    string currentX;
                    foreach (string current in this.GetParentPlatform().GetAircraftAirOps().GetRefuellingQueue())
					{
						if (Information.IsNothing(current))
						{
                            currentX = current;
                            this.GetParentPlatform().GetAircraftAirOps().GetRefuellingQueue().TryTake(out currentX);
						}
						else
						{
							Aircraft aircraft = (Aircraft)this.GetParentPlatform().m_Scenario.GetActiveUnits()[current];
							if (Information.IsNothing(aircraft))
							{
                                currentX = current;
                                this.GetParentPlatform().GetAircraftAirOps().GetRefuellingQueue().TryTake(out currentX);
							}
							else if (!Information.IsNothing(aircraft))
							{
								ActiveUnit activeUnit = aircraft;
								double num = 0.0;
								double num2 = 0.0;
								if (activeUnit.GetFuelLeft(ref num, ref num2, false) < 0.15)
								{
									list.Add(aircraft);
								}
							}
						}
					}
				}
				if (list.Count > 0)
				{
					if (this.GetParentPlatform().GetHorizontalRange(list[0]) > 10f)
					{
						this.GetParentPlatform().SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.GetAzimuth(this.GetParentPlatform().GetLatitude(null), this.GetParentPlatform().GetLongitude(null), list[0].GetLatitude(null), list[0].GetLongitude(null)));
					}
					if (this.GetParentPlatform().GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.OffloadingFuel && this.GetParentPlatform().GetThrottle() < ActiveUnit.Throttle.Cruise)
					{
						this.GetParentPlatform().SetThrottle(ActiveUnit.Throttle.Cruise, null);
					}
				}
				else if (this.GetParentPlatform().GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.OffloadingFuel)
				{
					List<KeyValuePair<string, Aircraft_AirOps._RefuellingConnection>> list2 = new List<KeyValuePair<string, Aircraft_AirOps._RefuellingConnection>>();
					list2.AddRange(this.GetParentPlatform().GetAircraftAirOps().GetA2ARCDictionary());
					foreach (KeyValuePair<string, Aircraft_AirOps._RefuellingConnection> current2 in list2)
					{
						if (this.GetParentPlatform().m_Scenario.GetActiveUnits().ContainsKey(current2.Key))
						{
							Aircraft aircraft2 = (Aircraft)this.GetParentPlatform().m_Scenario.GetActiveUnits()[current2.Key];
							if (!aircraft2.IsNotGroupLead() && !Information.IsNothing(aircraft2.GetAssignedMission(false)) && aircraft2.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike && aircraft2.GetAssignedMission(false).bTankerFollowsReceivers && aircraft2.GetAircraftNavigator().HasPlottedCourse())
							{
								this.GetParentPlatform().SetDesiredHeading(ActiveUnit._TurnRate.const_1, aircraft2.GetDesiredHeading(ActiveUnit._TurnRate.const_1));
								break;
							}
						}
						else
						{
							ConcurrentDictionary<string, Aircraft_AirOps._RefuellingConnection> a2ARCDictionary = this.GetParentPlatform().GetAircraftAirOps().GetA2ARCDictionary();
							string key = current2.Key;
							Aircraft_AirOps._RefuellingConnection refuellingConnection = Aircraft_AirOps._RefuellingConnection.Probe;
							a2ARCDictionary.TryRemove(key, out refuellingConnection);
						}
					}
				}
				if (this.GetParentPlatform().GetAircraftAirOps().GetRefuellingQueue().Count > 0)
				{
                    string current3X;
                    foreach (string current3 in this.GetParentPlatform().GetAircraftAirOps().GetRefuellingQueue())
					{
						if (Information.IsNothing(current3))
						{
                            current3X = current3;
                            this.GetParentPlatform().GetAircraftAirOps().GetRefuellingQueue().TryTake(out current3X);
						}
						else
						{
							Aircraft aircraft2 = (Aircraft)this.GetParentPlatform().m_Scenario.GetActiveUnits()[current3];
							if (Information.IsNothing(aircraft2))
							{
                                current3X = current3;
                                this.GetParentPlatform().GetAircraftAirOps().GetRefuellingQueue().TryTake(out current3X);
							}
							else
							{
								if (this.GetParentPlatform().GetCurrentAltitude_ASL(false) > aircraft2.GetAircraftKinematics().GetMaxAltitude())
								{
									this.GetParentPlatform().SetDesiredAltitude(aircraft2.GetAircraftKinematics().GetMaxAltitude() - 100f);
								}
								if (this.GetParentPlatform().GetThrottle() > ActiveUnit.Throttle.Loiter)
								{
									float num3 = aircraft2.RelativeBearingTo(this.GetParentPlatform(), false);
									if (num3 <= 315f && num3 >= 135f)
									{
										if (this.GetParentPlatform().GetHorizontalRange(aircraft2) < 25f)
										{
											this.GetParentPlatform().SetThrottle(ActiveUnit.Throttle.Loiter, null);
										}
										else if (aircraft2.GetAircraftNavigator().method_25())
										{
											this.GetParentPlatform().SetThrottle(ActiveUnit.Throttle.Loiter, null);
										}
										else if (!Information.IsNothing(this.GetParentPlatform().GetAssignedMission(false)) && this.GetParentPlatform().GetAssignedMission(false).MissionClass == Mission._MissionClass.Ferry)
										{
											this.GetParentPlatform().SetThrottle(ActiveUnit.Throttle.Loiter, null);
										}
									}
								}
							}
						}
					}
				}
				if (this.GetParentPlatform().GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.OffloadingFuel && this.GetParentPlatform().GetThrottle() > ActiveUnit.Throttle.Loiter)
				{
					this.GetParentPlatform().SetThrottle(ActiveUnit.Throttle.Loiter, null);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100401", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x001CCF04 File Offset: 0x001CB104
		private void method_109(float float_1, bool bool_6)
		{
			this.bool_5 = true;
			if (!Information.IsNothing(this.GetPrimaryTarget()))
			{
				try
				{
					if (!this.m_ActiveUnit.GetNavigator().bool_2)
					{
						if (this.m_ActiveUnit.GetNavigator().vmethod_16(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), true, 0f, false, null))
						{
							Aircraft_AI.Class98 @class = new Aircraft_AI.Class98();
							@class.list_0 = new List<Waypoint>();
							@class.list_0.AddRange(this.m_ActiveUnit.GetNavigator().GetPlottedCourse());
							if (!this.m_ActiveUnit.GetNavigator().bool_2)
							{
								if (this.m_ActiveUnit.GetNavigator().HasPathfindingCourse())
								{
									Waypoint waypoint = @class.list_0.Where(Aircraft_AI.WaypointFunc20).OrderByDescending(new Func<Waypoint, int>(@class.method_0)).ElementAtOrDefault(0);
									Weapon maxRangeWeaponFor = this.m_ActiveUnit.GetWeaponry().GetMaxRangeWeaponFor(this.GetPrimaryTarget());
									float num;
									if (Information.IsNothing(maxRangeWeaponFor))
									{
										num = 1f;
									}
									else
									{
										num = maxRangeWeaponFor.GetMaxRangeToTarget(this.m_ActiveUnit, this.GetPrimaryTarget(), false, null, false);
									}
									if (Math2.GetDistance(waypoint.GetLatitude(), waypoint.GetLongitude(), this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null)) > num)
									{
										this.m_ActiveUnit.GetNavigator().method_12(waypoint, this.m_ActiveUnit, null, false, 0.15f, this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), this.m_ActiveUnit.m_Scenario, bool_6);
									}
									else
									{
										this.m_ActiveUnit.GetNavigator().vmethod_7(float_1);
									}
								}
								else
								{
									this.m_ActiveUnit.GetNavigator().method_12(null, this.m_ActiveUnit, null, false, 0.15f, this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), this.m_ActiveUnit.m_Scenario, bool_6);
								}
							}
						}
						else if (this.m_ActiveUnit.GetNavigator().HasPathfindingCourse())
						{
							this.m_ActiveUnit.GetNavigator().method_14();
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100402", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				this.bool_5 = false;
			}
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x001CD210 File Offset: 0x001CB410
		private void method_110()
		{
			try
			{
				if (base.GetTargets().Length != 0 && this.GetParentPlatform().m_Scenario.GetGuidedWeaponsInAir().Count != 0)
				{
					this.GetParentPlatform().GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.BVRCrank);
					List<Weapon> first = this.GetParentPlatform().m_Scenario.GetGuidedWeaponsInAir().Where(new Func<Weapon, bool>(this.method_141)).ToList<Weapon>();
					List<Contact> list = new List<Contact>();
					Contact[] targets = base.GetTargets();
					checked
					{
						for (int i = 0; i < targets.Length; i++)
						{
							Contact contact = targets[i];
							Weapon[] second = contact.method_92();
							if (first.Intersect(second).Count<Weapon>() > 0)
							{
								list.Add(contact);
							}
						}
					}
					if (list.Count != 0)
					{
						Contact contact2;
						if (Information.IsNothing(this.GetPrimaryTarget()))
						{
							contact2 = base.GetTargets()[0];
						}
						else
						{
							contact2 = this.GetPrimaryTarget();
						}
						int num = (int)Math.Round((double)Math2.GetAzimuth(this.GetParentPlatform().GetLatitude(null), this.GetParentPlatform().GetLongitude(null), contact2.GetLatitude(null), contact2.GetLongitude(null)));
						int num2 = 1;
						int num3 = 0;
						do
						{
							int num4 = Math2.Normalize(num - num2);
							int num5 = 0;
							foreach (Contact current in list)
							{
								Sensor[] allNoneMCMSensors = this.GetParentPlatform().GetAllNoneMCMSensors();
								for (int j = 0; j < allNoneMCMSensors.Length; j = checked(j + 1))
								{
									Sensor sensor = allNoneMCMSensors[j];
									if (sensor.sensorType == Sensor.SensorType.Radar && sensor.IsTargetInCoverageArc(current, new float?((float)num4)))
									{
										num5++;
										break;
									}
								}
							}
							if (num5 == list.Count)
							{
								num3 = num4;
							}
							num2 += 5;
						}
						while (num2 <= 360);
						num3++;
						this.GetParentPlatform().SetDesiredHeading(ActiveUnit._TurnRate.const_0, (float)num3);
						if (Information.IsNothing(this.GetParentPlatform().GetAircraftKinematics().GetDesiredSpeedOverride()))
						{
							this.GetParentPlatform().SetThrottle(ActiveUnit.Throttle.Loiter, null);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100403", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x001CD4E4 File Offset: 0x001CB6E4
		private void method_111(float float_1)
		{
			CargoMission cargoMission = (CargoMission)this.m_ActiveUnit.GetAssignedMission(false);
			Aircraft aircraft = (Aircraft)this.m_ActiveUnit;
			if (this.m_ActiveUnit.m_OnboardCargos.Count<Cargo>() == 0)
			{
				this.m_ActiveUnit.GetAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB_MissionOver, true, ActiveUnit._ActiveUnitStatus.RTB_Group, true, true);
			}
			else if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref cargoMission.AreaPoints, ref cargoMission.list_8, ref cargoMission.list_9, 1, false, false) && (this.m_ActiveUnit.IsOnLand() | this.m_ActiveUnit.IsAboveSeaLevel(float_1)))
			{
				if (aircraft.GetLoadout().Cargo_ParadropCapable)
				{
					aircraft.GetAircraftAirOps().method_86();
				}
				if (aircraft.m_OnboardCargos.Count<Cargo>() != 0)
				{
					if (aircraft.IsRotaryWingAircraft())
					{
						aircraft.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.DeployingCargo);
						aircraft.GetAircraftAirOps().SetConditionTimer(120f);
					}
					else
					{
						aircraft.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB_MissionOver);
					}
				}
			}
			else
			{
				if (this.m_ActiveUnit.HasParentGroup())
				{
					if (this.m_ActiveUnit.IsGroupLead())
					{
						if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
						{
							if (!this.m_ActiveUnit.GetParentGroup(false).GetNavigator().method_30(ref cargoMission.AreaPoints, ref cargoMission.list_7, ref cargoMission.list_6, 30f, false))
							{
								this.m_ActiveUnit.GetParentGroup(false).GetNavigator().HeadingToTheArea(cargoMission.AreaPoints);
							}
							this.m_ActiveUnit.GetNavigator().vmethod_7(float_1);
						}
						else
						{
							this.m_ActiveUnit.GetParentGroup(false).GetNavigator().HeadingToTheArea(cargoMission.AreaPoints);
						}
					}
					else if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
					{
						this.m_ActiveUnit.GetNavigator().FollowGroupLead(float_1);
					}
				}
				else if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
				{
					if (!this.m_ActiveUnit.GetNavigator().method_30(ref cargoMission.AreaPoints, ref cargoMission.list_7, ref cargoMission.list_6, 30f, false))
					{
						this.m_ActiveUnit.GetNavigator().HeadingToTheArea(cargoMission.AreaPoints);
					}
					this.m_ActiveUnit.GetNavigator().vmethod_7(float_1);
				}
				else
				{
					this.m_ActiveUnit.GetNavigator().HeadingToTheArea(cargoMission.AreaPoints);
				}
				if (!this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
				{
					if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref cargoMission.AreaPoints, ref cargoMission.list_8, ref cargoMission.list_9, 1, false, false))
					{
						this.m_ActiveUnit.SetThrottle(cargoMission.StationThrottle_Aircraft, null);
					}
					else
					{
						this.m_ActiveUnit.SetThrottle(cargoMission.TransitThrottle_Aircraft, null);
					}
				}
				if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
				{
					if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref cargoMission.AreaPoints, ref cargoMission.list_8, ref cargoMission.list_9, 1, false, false))
					{
						this.m_ActiveUnit.SetDesiredAltitude(cargoMission.StationAltitude_Aircraft);
					}
					else
					{
						this.m_ActiveUnit.SetDesiredAltitude(cargoMission.TransitAltitude_Aircraft);
					}
				}
			}
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double GetAngularDistance(Contact theTarget)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(theTarget);
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x001CD854 File Offset: 0x001CBA54
		[CompilerGenerated]
		private GlobalVariables.TargetVisualSizeClass GetTargetVisualSizeClass(Contact contact_)
		{
			return contact_.GetTargetVisualSizeClass(this.m_ActiveUnit.m_Scenario);
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x001CD874 File Offset: 0x001CBA74
		[CompilerGenerated]
		private int method_115(Contact theTarget)
		{
			return theTarget.method_112(this.m_ActiveUnit.m_Scenario, this.m_ActiveUnit.GetSide(false), this.m_ActiveUnit).Values.Where(Aircraft_AI.AircraftFilterFunc).Count<ActiveUnit>();
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x001CD8BC File Offset: 0x001CBABC
		[CompilerGenerated]
		private bool method_118(Contact target)
		{
			bool result;
			if (!target.IsAirSpace())
			{
				Mission assignedMission = this.GetParentPlatform().GetAssignedMission(false);
				Doctrine._ShootTourists? shootTouristsDoctrine = this.m_ActiveUnit.m_Doctrine.GetShootTouristsDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
				string text = "";
				int num = 0;
				if (base.IsTargetForMission(target, assignedMission, shootTouristsDoctrine, false, false, true, ref text, ref num))
				{
					ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
					Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
					text = "";
					num = 0;
					result = weaponry.HasWeaponsInConditionToAttackTarget(target, true, doctrine, ref text, ref num, null);
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double method_119(Contact contact_8)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(contact_8);
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x001CD958 File Offset: 0x001CBB58
		[CompilerGenerated]
		private int method_120(Contact contact_8)
		{
			return contact_8.method_112(this.m_ActiveUnit.m_Scenario, this.m_ActiveUnit.GetSide(false), this.m_ActiveUnit).Count;
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double method_121(Contact contact_8)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(contact_8);
		}

		// Token: 0x06004A0E RID: 18958 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double method_122(Contact contact_8)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(contact_8);
		}

		// Token: 0x06004A0F RID: 18959 RVA: 0x001CD958 File Offset: 0x001CBB58
		[CompilerGenerated]
		private int method_123(Contact contact_8)
		{
			return contact_8.method_112(this.m_ActiveUnit.m_Scenario, this.m_ActiveUnit.GetSide(false), this.m_ActiveUnit).Count;
		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double method_124(Contact contact_8)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(contact_8);
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double method_125(Contact contact_8)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(contact_8);
		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double method_126(Contact contact_8)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(contact_8);
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x001CD990 File Offset: 0x001CBB90
		[CompilerGenerated]
		private int method_127(Contact contact_8)
		{
			return contact_8.method_112(this.m_ActiveUnit.m_Scenario, this.m_ActiveUnit.GetSide(false), this.m_ActiveUnit).Values.Where(Aircraft_AI.ActiveUnitFunc9).Count<ActiveUnit>();
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double method_128(Contact contact_8)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(contact_8);
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double method_129(Contact contact_8)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(contact_8);
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x001CD854 File Offset: 0x001CBA54
		[CompilerGenerated]
		private GlobalVariables.TargetVisualSizeClass method_130(Contact contact_8)
		{
			return contact_8.GetTargetVisualSizeClass(this.m_ActiveUnit.m_Scenario);
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x000B078C File Offset: 0x000AE98C
		[CompilerGenerated]
		private bool method_131(Contact contact_8)
		{
			ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
			Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
			string text = "";
			int num = 0;
			return weaponry.HasWeaponsInConditionToAttackTarget(contact_8, true, doctrine, ref text, ref num, null) && base.method_29(contact_8);
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double method_132(Contact contact_8)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(contact_8);
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x001CD854 File Offset: 0x001CBA54
		[CompilerGenerated]
		private GlobalVariables.TargetVisualSizeClass method_133(Contact contact_8)
		{
			return contact_8.GetTargetVisualSizeClass(this.m_ActiveUnit.m_Scenario);
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x0002392B File Offset: 0x00021B2B
		[CompilerGenerated]
		private bool method_134(NoNavZone noNavZone_0)
		{
			return noNavZone_0.IsAffected(this.m_ActiveUnit);
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x00023939 File Offset: 0x00021B39
		[CompilerGenerated]
		private bool method_135(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.m_ActiveUnit.m_Scenario).IsGuidedWeapon_RV_HGV() && weaponRec_0.GetWeapon(this.m_ActiveUnit.m_Scenario).method_176() && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x00023977 File Offset: 0x00021B77
		[CompilerGenerated]
		private bool method_136(Weapon weapon_0)
		{
			return weapon_0.GetFiringParent() == this.GetParentPlatform() && weapon_0.IsLongRangeAAWWeapon();
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x00023990 File Offset: 0x00021B90
		[CompilerGenerated]
		private bool method_137(WeaponRec weaponRec_0)
		{
			return weaponRec_0.GetWeapon(this.m_ActiveUnit.m_Scenario).IsGuidedWeapon_RV_HGV() && weaponRec_0.GetWeapon(this.m_ActiveUnit.m_Scenario).IsLongRangeAAWWeapon() && weaponRec_0.GetCurrentLoad() > 0;
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x000239CE File Offset: 0x00021BCE
		[CompilerGenerated]
		private bool method_138(Sensor sensor_0)
		{
			return sensor_0.sensorCode.Classification_BrilliantWeapon && sensor_0.IsTargetDetectableByMe(this.GetPrimaryTarget().ActualUnit);
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x001CD9D8 File Offset: 0x001CBBD8
		[CompilerGenerated]
		private float method_139(Sensor sensor_0)
		{
			return sensor_0.GetDetectionRange(this.GetParentPlatform(), this.GetPrimaryTarget().ActualUnit);
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double method_140(UnguidedWeapon unguidedWeapon_0)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(unguidedWeapon_0);
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x00023977 File Offset: 0x00021B77
		[CompilerGenerated]
		private bool method_141(Weapon weapon_0)
		{
			return weapon_0.GetFiringParent() == this.GetParentPlatform() && weapon_0.IsLongRangeAAWWeapon();
		}

		// Token: 0x040022A8 RID: 8872
		public static Func<Contact, bool> OrbitalTargetFilter = (Contact contact_0) => contact_0.contactType == Contact_Base.ContactType.Orbital;

		// Token: 0x040022A9 RID: 8873
		public static Func<Contact, bool> ContactFunc1 = (Contact contact_0) => contact_0.method_97() || contact_0.IsSurface() || contact_0.IsSubSurface() || contact_0.IsFacilityType();

		// Token: 0x040022AA RID: 8874
		public static Func<Contact, Contact> ContactFunc2 = (Contact contact_0) => contact_0;

		// Token: 0x040022AB RID: 8875
		public new static Func<Contact, Contact> ContactFunc3 = (Contact contact_0) => contact_0;

		// Token: 0x040022AC RID: 8876
		public new static Func<Contact, Contact> ContactFunc4 = (Contact contact_0) => contact_0;

		// Token: 0x040022AD RID: 8877
		public static Func<ActiveUnit, bool> AircraftFilterFunc = (ActiveUnit activeUnit_0) => activeUnit_0.IsAircraft;

		// Token: 0x040022AE RID: 8878
		public static Func<Contact, Contact> ContactFunc6 = (Contact contact_0) => contact_0;

		// Token: 0x040022AF RID: 8879
		public static Func<Contact, Contact> ContactFunc7 = (Contact contact_0) => contact_0;

		// Token: 0x040022B0 RID: 8880
		public static Func<Contact, Contact> ContactFunc8 = (Contact contact_0) => contact_0;

		// Token: 0x040022B1 RID: 8881
		public static Func<ActiveUnit, bool> ActiveUnitFunc9 = (ActiveUnit activeUnit_0) => activeUnit_0.IsAircraft;

		// Token: 0x040022B2 RID: 8882
		public static Func<Contact, Contact> ContactFunc10 = (Contact contact_0) => contact_0;

		// Token: 0x040022B3 RID: 8883
		public new static Func<Contact, bool> ContactFunc11 = (Contact contact_0) => !contact_0.IsAirSpace();

		// Token: 0x040022B4 RID: 8884
		public new static Func<Contact, bool> ContactFunc12 = (Contact contact_0) => !contact_0.IsAirSpace();

		// Token: 0x040022B5 RID: 8885
		public static Func<Weapon, bool> WeaponFunc13 = (Weapon weapon_0) => weapon_0.IsGuidedWeapon_RV_HGV() && weapon_0.method_176();

		// Token: 0x040022B6 RID: 8886
		public static Func<Weapon, float> WeaponFunc14 = (Weapon weapon_0) => weapon_0.GetLargestRangeMaxOfAllDomains();

		// Token: 0x040022B7 RID: 8887
		public static Func<Weapon, bool> WeaponFunc15 = (Weapon weapon_0) => weapon_0.WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() && !weapon_0.IsLongRangeAAWWeapon();

		// Token: 0x040022B8 RID: 8888
		public static Func<Weapon, float> WeaponFunc16 = (Weapon weapon_0) => weapon_0.RangeAAWMax;

		// Token: 0x040022B9 RID: 8889
		public static Func<UnguidedWeapon, bool> UnguidedWeaponFunc17 = (UnguidedWeapon unguidedWeapon_0) => !Information.IsNothing(unguidedWeapon_0);

		// Token: 0x040022BA RID: 8890
		public static Func<Aircraft, double> AircraftFunc18 = (Aircraft aircraft_0) => aircraft_0.GetLongitude(null);

		// Token: 0x040022BB RID: 8891
		public static Func<Aircraft, double> AircraftFunc19 = (Aircraft aircraft_0) => aircraft_0.GetLatitude(null);

		// Token: 0x040022BC RID: 8892
		public static Func<Waypoint, bool> WaypointFunc20 = (Waypoint waypoint_0) => waypoint_0.waypointType == Waypoint.WaypointType.PathfindingPoint;

		// Token: 0x040022BD RID: 8893
		private Aircraft ParentAircraft;

		// Token: 0x040022BE RID: 8894
		private ActiveUnit_AI._AltitudePreset altitudePreset;

		// Token: 0x020009D7 RID: 2519
		[CompilerGenerated]
		public sealed class StrikeMissionAI
		{
			// Token: 0x06004A38 RID: 19000 RVA: 0x00023A5B File Offset: 0x00021C5B
			public StrikeMissionAI(Aircraft_AI.StrikeMissionAI StrikeMissionAI_)
			{
				if (StrikeMissionAI_ != null)
				{
					this.strikeMission = StrikeMissionAI_.strikeMission;
				}
			}

			// Token: 0x06004A39 RID: 19001 RVA: 0x001CDD18 File Offset: 0x001CBF18
			internal bool HasWeaponToAttackTarget(Contact theTarget)
			{
				bool result;
				if (theTarget.IsSpecificTargetForStikeMission(this.strikeMission))
				{
					ActiveUnit_Weaponry weaponry = this.aircraft_AI.m_ActiveUnit.GetWeaponry();
					Doctrine doctrine = this.aircraft_AI.m_ActiveUnit.m_Doctrine;
					string text = "";
					int num = 0;
					result = weaponry.HasWeaponsInConditionToAttackTarget(theTarget, true, doctrine, ref text, ref num, null);
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x040022D4 RID: 8916
			public Strike strikeMission;

			// Token: 0x040022D5 RID: 8917
			public Aircraft_AI aircraft_AI;
		}

		// Token: 0x020009D8 RID: 2520
		[CompilerGenerated]
		public sealed class TargetMan
		{
			// Token: 0x06004A3A RID: 19002 RVA: 0x00023A75 File Offset: 0x00021C75
			public TargetMan(Aircraft_AI.TargetMan class88_0)
			{
				if (class88_0 != null)
				{
					this.TargetID = class88_0.TargetID;
				}
			}

			// Token: 0x06004A3B RID: 19003 RVA: 0x00023A8F File Offset: 0x00021C8F
			internal bool IsTargetOf(ActiveUnit activeUnit_)
			{
				return !activeUnit_.IsGroup && activeUnit_.IsOperating() && activeUnit_.GetAI().GetTargetIDSet().Contains(this.TargetID);
			}

			// Token: 0x040022D6 RID: 8918
			public string TargetID;

			// Token: 0x040022D7 RID: 8919
			public Func<ActiveUnit, bool> TargetFilterFunc;
		}

		// Token: 0x020009D9 RID: 2521
		[CompilerGenerated]
		public sealed class DistanceMeasurer
		{
			// Token: 0x06004A3C RID: 19004 RVA: 0x00023ABA File Offset: 0x00021CBA
			public DistanceMeasurer(Aircraft_AI.DistanceMeasurer DistanceMeasurer_)
			{
				if (DistanceMeasurer_ != null)
				{
					this._Target = DistanceMeasurer_._Target;
				}
			}

			// Token: 0x06004A3D RID: 19005 RVA: 0x001CDD78 File Offset: 0x001CBF78
			internal double GetAngularDistance(ActiveUnit activeUnit_)
			{
				return activeUnit_.GetApproxAngularDistanceInDegrees(this._Target);
			}

			// Token: 0x040022D8 RID: 8920
			public Contact _Target;
		}

		// Token: 0x020009DA RID: 2522
		[CompilerGenerated]
		public sealed class WeaponTargetMatcher
		{
			// Token: 0x06004A3E RID: 19006 RVA: 0x00023AD4 File Offset: 0x00021CD4
			public WeaponTargetMatcher(Aircraft_AI.WeaponTargetMatcher Matcher_)
			{
				if (Matcher_ != null)
				{
					this.bool_0 = Matcher_.bool_0;
				}
			}

			// Token: 0x06004A3F RID: 19007 RVA: 0x001CDD94 File Offset: 0x001CBF94
			internal bool HasWeaponsToAttackTarget(Contact theTarget)
			{
				ActiveUnit_AI activeUnit_AI = this.aircraft_AI;
				Mission assignedMission = this.aircraft_AI.GetParentPlatform().GetAssignedMission(false);
				Doctrine._ShootTourists? shootTouristsDoctrine = this.aircraft_AI.m_ActiveUnit.m_Doctrine.GetShootTouristsDoctrine(this.aircraft_AI.m_ActiveUnit.m_Scenario, false, false, false);
				bool onPatrolStation_ = this.bool_0;
				string text = "";
				int num = 0;
				bool result;
				if (activeUnit_AI.IsTargetForMission(theTarget, assignedMission, shootTouristsDoctrine, false, onPatrolStation_, true, ref text, ref num) && this.aircraft_AI.m_ActiveUnit.GetAI().method_63(theTarget))
				{
					ActiveUnit_Weaponry weaponry = this.aircraft_AI.m_ActiveUnit.GetWeaponry();
					Doctrine doctrine = this.aircraft_AI.m_ActiveUnit.m_Doctrine;
					text = "";
					num = 0;
					result = weaponry.HasWeaponsInConditionToAttackTarget(theTarget, true, doctrine, ref text, ref num, null);
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x06004A40 RID: 19008 RVA: 0x001CDE6C File Offset: 0x001CC06C
			internal bool IsTargetForAssignedMission(Contact contact_)
			{
				bool result;
				if (contact_.GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass)
				{
					ActiveUnit_AI activeUnit_AI = this.aircraft_AI;
					Mission assignedMission = this.aircraft_AI.GetParentPlatform().GetAssignedMission(false);
					Doctrine._ShootTourists? shootTouristsDoctrine = this.aircraft_AI.m_ActiveUnit.m_Doctrine.GetShootTouristsDoctrine(this.aircraft_AI.m_ActiveUnit.m_Scenario, false, false, false);
					bool onPatrolStation_ = this.bool_0;
					string text = "";
					int num = 0;
					result = activeUnit_AI.IsTargetForMission(contact_, assignedMission, shootTouristsDoctrine, false, onPatrolStation_, true, ref text, ref num);
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x06004A41 RID: 19009 RVA: 0x001CDE6C File Offset: 0x001CC06C
			internal bool IsTargetForMission(Contact contact_)
			{
				bool result;
				if (contact_.GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass)
				{
					ActiveUnit_AI activeUnit_AI = this.aircraft_AI;
					Mission assignedMission = this.aircraft_AI.GetParentPlatform().GetAssignedMission(false);
					Doctrine._ShootTourists? shootTouristsDoctrine = this.aircraft_AI.m_ActiveUnit.m_Doctrine.GetShootTouristsDoctrine(this.aircraft_AI.m_ActiveUnit.m_Scenario, false, false, false);
					bool onPatrolStation_ = this.bool_0;
					string text = "";
					int num = 0;
					result = activeUnit_AI.IsTargetForMission(contact_, assignedMission, shootTouristsDoctrine, false, onPatrolStation_, true, ref text, ref num);
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x040022D9 RID: 8921
			public bool bool_0;

			// Token: 0x040022DA RID: 8922
			public Aircraft_AI aircraft_AI;
		}

		// Token: 0x020009DB RID: 2523
		[CompilerGenerated]
		public sealed class Class91
		{
			// Token: 0x06004A42 RID: 19010 RVA: 0x00023AEE File Offset: 0x00021CEE
			public Class91(Aircraft_AI.Class91 class91_0)
			{
				if (class91_0 != null)
				{
					this.string_0 = class91_0.string_0;
				}
			}

			// Token: 0x06004A43 RID: 19011 RVA: 0x00023B08 File Offset: 0x00021D08
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return !activeUnit_0.IsGroup && activeUnit_0.IsOperating() && activeUnit_0.GetAI().GetTargetIDSet().Contains(this.string_0);
			}

			// Token: 0x040022DB RID: 8923
			public string string_0;

			// Token: 0x040022DC RID: 8924
			public Func<ActiveUnit, bool> func_0;
		}

		// Token: 0x020009DC RID: 2524
		[CompilerGenerated]
		public sealed class Class92
		{
			// Token: 0x06004A44 RID: 19012 RVA: 0x00023B33 File Offset: 0x00021D33
			public Class92(Aircraft_AI.Class92 class92_0)
			{
				if (class92_0 != null)
				{
					this.contact_0 = class92_0.contact_0;
				}
			}

			// Token: 0x06004A45 RID: 19013 RVA: 0x001CDEF4 File Offset: 0x001CC0F4
			internal double method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.GetApproxAngularDistanceInDegrees(this.contact_0);
			}

			// Token: 0x040022DD RID: 8925
			public Contact contact_0;
		}

		// Token: 0x020009DD RID: 2525
		[CompilerGenerated]
		public sealed class StrikeTargetMan
		{
			// Token: 0x06004A46 RID: 19014 RVA: 0x00023B4D File Offset: 0x00021D4D
			public StrikeTargetMan(Aircraft_AI.StrikeTargetMan StrikeTargetMan_)
			{
				if (StrikeTargetMan_ != null)
				{
					this.strikeMission = StrikeTargetMan_.strikeMission;
				}
			}

			// Token: 0x06004A47 RID: 19015 RVA: 0x00023B67 File Offset: 0x00021D67
			internal bool IsSpecificTargetForStikeMission(Contact theTarget)
			{
				return theTarget.IsSpecificTargetForStikeMission(this.strikeMission);
			}

			// Token: 0x040022DE RID: 8926
			public Strike strikeMission;
		}

		// Token: 0x020009DE RID: 2526
		[CompilerGenerated]
		public sealed class Class94
		{
			// Token: 0x06004A48 RID: 19016 RVA: 0x00023B75 File Offset: 0x00021D75
			internal void method_0()
			{
				this.aircraft_AI_0.method_109(this.float_0, true);
			}

			// Token: 0x040022DF RID: 8927
			public float float_0;

			// Token: 0x040022E0 RID: 8928
			public Aircraft_AI aircraft_AI_0;
		}

		// Token: 0x020009DF RID: 2527
		[CompilerGenerated]
		public sealed class MineClearingAI
		{
			// Token: 0x06004A4A RID: 19018 RVA: 0x00023B89 File Offset: 0x00021D89
			public MineClearingAI(Aircraft_AI.MineClearingAI MineClearingAI_)
			{
				if (MineClearingAI_ != null)
				{
					this.UnguidedWeapons = MineClearingAI_.UnguidedWeapons;
					this.MineClearingAreaVertices = MineClearingAI_.MineClearingAreaVertices;
					this.UnguidedWeaponBag = MineClearingAI_.UnguidedWeaponBag;
				}
			}

			// Token: 0x06004A4B RID: 19019 RVA: 0x001CDF10 File Offset: 0x001CC110
			internal void AddWeapon(string WeaponGUID)
			{
				UnguidedWeapon unguidedWeapon = null;
				this.UnguidedWeapons.TryGetValue(WeaponGUID, ref unguidedWeapon);
				if (!Information.IsNothing(unguidedWeapon) && unguidedWeapon.IsMine() && unguidedWeapon.vmethod_40(this.MineClearingAreaVertices, this.m_AI.m_ActiveUnit.m_Scenario, true))
				{
					this.UnguidedWeaponBag.Add(unguidedWeapon);
				}
			}

			// Token: 0x040022E1 RID: 8929
			public ObservableDictionary<string, UnguidedWeapon> UnguidedWeapons;

			// Token: 0x040022E2 RID: 8930
			public List<ReferencePoint> MineClearingAreaVertices;

			// Token: 0x040022E3 RID: 8931
			public ConcurrentBag<UnguidedWeapon> UnguidedWeaponBag;

			// Token: 0x040022E4 RID: 8932
			public Aircraft_AI m_AI;
		}

		// Token: 0x020009E0 RID: 2528
		[CompilerGenerated]
		public sealed class SonobuoysDropMan
		{
			// Token: 0x06004A4C RID: 19020 RVA: 0x001CDF70 File Offset: 0x001CC170
			internal void CheckDropCondition(Weapon weapon_, ParallelLoopState parallelLoopState_)
			{
				if (weapon_.GetWeaponType() == Weapon._WeaponType.Sonobuoy && weapon_.GetNoneMCMSensors().Length > 0 && (this.aircraft_AI.GetParentPlatform().GetSide(false) == weapon_.GetSide(false) || this.aircraft_AI.GetParentPlatform().GetSide(false).IsFriendlyToSide(weapon_.GetSide(false))) && this.aircraft_AI.GetParentPlatform().GetHorizontalRange(weapon_) < weapon_.GetNoneMCMSensors()[0].MaxRange * 2f)
				{
					this.bEnableDrop = false;
					parallelLoopState_.Stop();
				}
			}

			// Token: 0x040022E5 RID: 8933
			public bool bEnableDrop;

			// Token: 0x040022E6 RID: 8934
			public Aircraft_AI aircraft_AI;
		}

		// Token: 0x020009E1 RID: 2529
		[CompilerGenerated]
		public sealed class WeaponRange
		{
			// Token: 0x06004A4E RID: 19022 RVA: 0x001CE00C File Offset: 0x001CC20C
			internal float GetMaxRangeToPrimaryTarget(Weapon weapon_)
			{
				return weapon_.GetMaxRangeToTarget(this.aircraft_AI.m_ActiveUnit, this.aircraft_AI.GetPrimaryTarget(), true, this.doctrine, false);
			}

			// Token: 0x040022E7 RID: 8935
			public Doctrine doctrine;

			// Token: 0x040022E8 RID: 8936
			public Aircraft_AI aircraft_AI;
		}

		// Token: 0x020009E2 RID: 2530
		[CompilerGenerated]
		public sealed class Class98
		{
			// Token: 0x06004A50 RID: 19024 RVA: 0x001CE040 File Offset: 0x001CC240
			internal int method_0(Waypoint waypoint_0)
			{
				return this.list_0.IndexOf(waypoint_0);
			}

			// Token: 0x040022E9 RID: 8937
			public List<Waypoint> list_0;
		}
	}
}

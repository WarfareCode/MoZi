using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;

namespace ns1
{
	// Token: 0x02000AB8 RID: 2744
	public sealed class Facility_AI : ActiveUnit_AI
	{
		// Token: 0x060056E6 RID: 22246 RVA: 0x00257174 File Offset: 0x00255374
		private Facility GetParentPlatform()
		{
			if (Information.IsNothing(this.ParentPlatform))
			{
				this.ParentPlatform = (Facility)this.m_ActiveUnit;
			}
			return this.ParentPlatform;
		}

		// Token: 0x060056E7 RID: 22247 RVA: 0x002571AC File Offset: 0x002553AC
		public static Facility_AI Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_1, ref ActiveUnit activeUnit_1)
		{
			Facility_AI result;
			try
			{
				Facility_AI facility_AI = new Facility_AI(ref activeUnit_1);
				facility_AI.m_ActiveUnit = activeUnit_1;
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
									facility_AI.PrimaryTarget = Contact.GetContact(xmlNode.InnerText, ref dictionary_1);
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
									goto IL_4AB;
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
												ScenarioArrayUtil.AddContact(ref facility_AI.Threats, contact_);
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
								if (num != 1474882803u)
								{
									if (num == 1610968176u && Operators.CompareString(name, "TTNPTE", false) == 0)
									{
										facility_AI.TimeToNextPrimaryTargetEvent = Conversions.ToShort(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "IE", false) == 0)
									{
										facility_AI.IsEscort = true;
										continue;
									}
									continue;
								}
							}
							IL_179:
							facility_AI.PrimaryThreat = Contact.GetContact(xmlNode.InnerText, ref dictionary_1);
							continue;
						}
						if (num <= 2722719197u)
						{
							if (num <= 2133975202u)
							{
								if (num != 1966596370u)
								{
									if (num == 2133975202u && Operators.CompareString(name, "PrimaryTarget_LastKnown_Lat", false) == 0)
									{
										facility_AI.SetPrimaryTarget_LastKnown_Lat(XmlConvert.ToDouble(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lon", false) == 0)
									{
										facility_AI.SetPrimaryTarget_LastKnown_Lon(XmlConvert.ToDouble(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num != 2276842832u)
							{
								if (num != 2722719197u)
								{
									continue;
								}
								if (Operators.CompareString(name, "PTOE", false) != 0)
								{
									continue;
								}
								goto IL_40B;
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
										if (!Information.IsNothing(targetingEntry.Target) && !facility_AI.GetTargetList().ContainsKey(targetingEntry.Target.GetGuid()))
										{
											facility_AI.GetTargetList().Add(targetingEntry.Target.GetGuid(), targetingEntry);
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
						if (num <= 3761246852u)
						{
							if (num != 2783884855u)
							{
								if (num != 3761246852u || Operators.CompareString(name, "PrimaryTargetOverrideExists", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "HPos", false) == 0)
								{
									facility_AI.HoldPosition = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num != 3957045325u)
						{
							if (num == 4076649232u && Operators.CompareString(name, "PrimaryTarget_LastKnown_Alt", false) == 0)
							{
								facility_AI.SetPrimaryTarget_LastKnown_Alt(XmlConvert.ToSingle(xmlNode.InnerText));
								continue;
							}
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "IPC", false) == 0)
							{
								goto IL_4AB;
							}
							continue;
						}
						IL_40B:
						facility_AI.bPrimaryTargetOverride = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_4AB:
						bool flag = Conversions.ToBoolean(xmlNode.InnerText);
						if (!Information.IsNothing(activeUnit_1.m_Doctrine))
						{
							byte value = 0;
							if (Conversions.ToBoolean(xmlNode.InnerText))
							{
								value = 1;
							}
							activeUnit_1.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(activeUnit_1.m_Scenario, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?((Doctrine._IgnorePlottedCourseWhenAttacking)value));
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
				result = facility_AI;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100545", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Facility_AI(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060056E8 RID: 22248 RVA: 0x00023901 File Offset: 0x00021B01
		public Facility_AI(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}

		// Token: 0x060056E9 RID: 22249 RVA: 0x002577F0 File Offset: 0x002559F0
		public override void UpdateUnitStatus(float float_1, bool bool_6, bool bool_7)
		{
			if (!Information.IsNothing(this.m_ActiveUnit))
			{
				try
				{
					Doctrine._AutomaticEvasion? automaticEvasionDoctrine = this.m_ActiveUnit.m_Doctrine.GetAutomaticEvasionDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
					byte? b = automaticEvasionDoctrine.HasValue ? new byte?((byte)automaticEvasionDoctrine.GetValueOrDefault()) : null;
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						if (!Information.IsNothing(this.PrimaryThreat))
						{
							this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
							return;
						}
						if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
						{
							this.m_ActiveUnit.SetUnitStatus(this.m_ActiveUnit.SBEngagedDefensive);
						}
					}
					if (!this.m_ActiveUnit.IsRTB() && (!this.GetParentPlatform().IsMobile() || !this.m_ActiveUnit.m_Scenario.FifteenthSecondIsChangingOnThisPulse || this.m_ActiveUnit.IsRTB() || !base.method_74()))
					{
						bool? flag;
						bool? flag3;
						if (!this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
						{
							flag = new bool?(false);
						}
						else
						{
							bool? flag2;
							if (Information.IsNothing(this.GetPrimaryTarget()))
							{
								flag2 = new bool?(false);
							}
							else
							{
								Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.m_ActiveUnit.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
								b = (ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null);
								flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null);
							}
							flag3 = flag2;
							flag = (flag3.HasValue ? new bool?(!flag3.GetValueOrDefault()) : flag3);
						}
						flag3 = flag;
						if (flag3.GetValueOrDefault())
						{
							this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
						}
						else
						{
							if (!Information.IsNothing(this.GetPrimaryTarget()))
							{
								Contact_Base.ContactType contactType = this.GetPrimaryTarget().contactType;
								if (contactType > Contact_Base.ContactType.Missile)
								{
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
									return;
								}
							}
							if (this.m_ActiveUnit.HasParentGroup())
							{
								if (this.m_ActiveUnit.GetParentGroup(false).GetGroupType() == Group.GroupType.AirGroup && this.m_ActiveUnit.GetParentGroup(false).GetUnitStatus() == ActiveUnit._ActiveUnitStatus.FormingUp)
								{
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.FormingUp);
									return;
								}
								if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.FormingUp)
								{
									this.TargetingContacts(float_1, false, true);
								}
							}
							if (this.m_ActiveUnit.GetAssignedMission(false) != null && this.m_ActiveUnit.GetAssignedMission(false).IsActive())
							{
								switch (this.m_ActiveUnit.GetAssignedMission(false).MissionClass)
								{
								case Mission._MissionClass.Strike:
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
									return;
								case Mission._MissionClass.Patrol:
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPatrol);
									return;
								case Mission._MissionClass.Support:
									if (!Information.IsNothing(this.GetPrimaryTarget()))
									{
										this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
										return;
									}
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnSupportMission);
									return;
								default:
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
									break;
								}
							}
							if (this.m_ActiveUnit.GetFuelState() != ActiveUnit._ActiveUnitFuelState.IgnoreBingoAndJoker && this.m_ActiveUnit.GetWeaponState() != ActiveUnit._ActiveUnitWeaponState.IgnoreWinchesterAndShotgun && this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Unassigned)
							{
								this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200346", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060056EA RID: 22250 RVA: 0x001C4C2C File Offset: 0x001C2E2C
		private Weapon[] GetAvailableWeapons()
		{
			return this.m_ActiveUnit.GetWeaponry().GetAvailableWeapons(false);
		}

		// Token: 0x060056EB RID: 22251 RVA: 0x00257BEC File Offset: 0x00255DEC
		public override void TargetingContacts(float float_1, bool bool_6, bool bool_7)
		{
			checked
			{
				if (!Information.IsNothing(this.m_ActiveUnit))
				{
					try
					{
						if (this.m_ActiveUnit.m_Mounts.Length == 0 && this.m_ActiveUnit.GetAllNoneMCMSensors().Length == 0)
						{
							if (!Information.IsNothing(this.GetPrimaryTarget()))
							{
								this.DropTargeting(this.GetPrimaryTarget(), true);
							}
							if (base.GetTargets().Length <= 0)
							{
								goto IL_B17;
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
								goto IL_B17;
							}
						}
						base.TargetingContacts(float_1, bool_6, false);
						if (!Information.IsNothing(this.m_ActiveUnit) && (!this.m_ActiveUnit.IsFixedFacility() || this.m_ActiveUnit.m_Mounts.Length != 0))
						{
							Mission assignedMission = this.m_ActiveUnit.GetAssignedMission(false);
							Weapon[] availableWeapons = this.m_ActiveUnit.GetWeaponry().GetAvailableWeapons(false);
							Weapon weapon = null;
							Weapon weapon2 = null;
							Weapon weapon3 = null;
							Weapon weapon4 = null;
							for (int j = 0; j < availableWeapons.Length; j++)
							{
								Weapon weapon5 = availableWeapons[j];
								if (Information.IsNothing(weapon))
								{
									if (weapon5.RangeAAWMax > 0f)
									{
										weapon = weapon5;
									}
								}
								else if (weapon5.RangeAAWMax > weapon.RangeAAWMax)
								{
									weapon = weapon5;
								}
								if (Information.IsNothing(weapon2))
								{
									if (weapon5.RangeASUWMax > 0f)
									{
										weapon2 = weapon5;
									}
								}
								else if (weapon5.RangeASUWMax > weapon2.RangeASUWMax)
								{
									weapon2 = weapon5;
								}
								if (Information.IsNothing(weapon3))
								{
									if (weapon5.RangeLandMax > 0f)
									{
										weapon3 = weapon5;
									}
								}
								else if (weapon5.RangeLandMax > weapon3.RangeLandMax)
								{
									weapon3 = weapon5;
								}
								if (Information.IsNothing(weapon4))
								{
									if (weapon5.RangeASWMax > 0f)
									{
										weapon4 = weapon5;
									}
								}
								else if (weapon5.RangeASWMax > weapon4.RangeASWMax)
								{
									weapon4 = weapon5;
								}
							}
							unchecked
							{
								if (!Information.IsNothing(weapon) || !Information.IsNothing(weapon2) || !Information.IsNothing(weapon4) || !Information.IsNothing(weapon3) || (!this.m_ActiveUnit.IsFixedFacility() && !this.HoldPosition))
								{
									Contact[] targets2 = base.GetTargets();
									bool flag = base.IsOnPatrolStation();
									Collection<Contact> collection2 = new Collection<Contact>();
									if (this.m_ActiveUnit.GetSide(false).NoNavZoneList.Count > 0)
									{
										for (int k = targets2.Count<Contact>() - 1; k >= 0; k += -1)
										{
											Contact contact = targets2[k];
											if (!Information.IsNothing(contact) && (this.m_ActiveUnit.GetSide(false).GetQuantityToFireForTheTarget(ref this.m_ActiveUnit, ref contact) <= 0 || base.GetTargetingBehavior(contact) != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc))
											{
												foreach (NoNavZone current2 in this.m_ActiveUnit.GetSide(false).NoNavZoneList.Where(new Func<NoNavZone, bool>(this.method_91)))
												{
													if (current2.Area.Count != 0 && contact.vmethod_40(current2.Area, this.m_ActiveUnit.m_Scenario, true))
													{
														collection2.Add(contact);
													}
												}
											}
										}
										foreach (Contact current3 in collection2)
										{
											this.DropTargeting(current3, true);
										}
									}
									Lazy<Weapon[]> lazy = new Lazy<Weapon[]>(new Func<Weapon[]>(this.GetAvailableWeapons));
									Doctrine._ShootTourists? shootTouristsDoctrine = this.m_ActiveUnit.m_Doctrine.GetShootTouristsDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
									List<Contact> contactList = this.m_ActiveUnit.GetSensory().GetContactList();
									if (!Information.IsNothing(assignedMission) && assignedMission.IsActive())
									{
										foreach (Contact current4 in contactList)
										{
											if ((bool_7 || current4.contactType == Contact_Base.ContactType.Missile || (current4.contactType == Contact_Base.ContactType.Air && this.m_ActiveUnit.m_Scenario.FifthSecondIsChangingOnThisPulse) || this.m_ActiveUnit.m_Scenario.FifteenthSecondIsChangingOnThisPulse) && !ScenarioArrayUtil.IsContactExists(ref targets2, current4) && !collection2.Contains(current4))
											{
												Contact._BattleDamageAssessment? battleDamageAssessment = current4.GetBattleDamageAssessment(this.m_ActiveUnit.GetSide(false));
												byte? b = battleDamageAssessment.HasValue ? new byte?((byte)battleDamageAssessment.GetValueOrDefault()) : null;
												if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
												{
													Contact theContact = current4;
													Mission mission_ = assignedMission;
													Doctrine._ShootTourists? shootTouristsDoc_ = shootTouristsDoctrine;
													bool onPatrolStation_ = flag;
													string text = "";
													int num = 0;
													if (base.IsTargetForMission(theContact, mission_, shootTouristsDoc_, bool_6, onPatrolStation_, true, ref text, ref num))
													{
														Misc.PostureStance postureStance;
														if (!this.PostureStanceDictionary.TryGetValue(current4.GetGuid(), out postureStance))
														{
															postureStance = current4.GetPostureStance(this.m_ActiveUnit.GetSide(false));
															this.PostureStanceDictionary.Add(current4.GetGuid(), postureStance);
														}
														switch (postureStance)
														{
														case Misc.PostureStance.Unfriendly:
														case Misc.PostureStance.Hostile:
															if (current4.contactType != Contact_Base.ContactType.Submarine || !current4.IsBiologics())
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
															break;
														case Misc.PostureStance.Unknown:
															this.TargetingContact(current4, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
															break;
														}
													}
												}
											}
										}
									}
									if (!this.m_ActiveUnit.HasAssignedPatrolMission() || ((Patrol)assignedMission).method_45(this.m_ActiveUnit.m_Scenario))
									{
										bool flag2 = this.m_ActiveUnit.HasAssignedPatrolMission() && ((Patrol)assignedMission).method_42();
										foreach (Contact current5 in contactList)
										{
											if (!Information.IsNothing(this.m_ActiveUnit) && !Information.IsNothing(current5) && (bool_7 || current5.contactType == Contact_Base.ContactType.Missile || (current5.contactType == Contact_Base.ContactType.Air && this.m_ActiveUnit.m_Scenario.FifthSecondIsChangingOnThisPulse) || this.m_ActiveUnit.m_Scenario.FifteenthSecondIsChangingOnThisPulse) && !ScenarioArrayUtil.IsContactExists(ref targets2, current5) && !collection2.Contains(current5))
											{
												Misc.PostureStance postureStance2;
												if (!this.PostureStanceDictionary.TryGetValue(current5.GetGuid(), out postureStance2))
												{
													postureStance2 = current5.GetPostureStance(this.m_ActiveUnit.GetSide(false));
													this.PostureStanceDictionary.Add(current5.GetGuid(), postureStance2);
												}
												if (postureStance2 != Misc.PostureStance.Neutral)
												{
													Contact._BattleDamageAssessment? battleDamageAssessment = current5.GetBattleDamageAssessment(this.m_ActiveUnit.GetSide(false));
													byte? b = battleDamageAssessment.HasValue ? new byte?((byte)battleDamageAssessment.GetValueOrDefault()) : null;
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
															if (!Information.IsNothing(weapon) && this.m_ActiveUnit.GetSlantRange(current5, 0f) < (float)current5.method_72() * weapon.RangeAAWMax)
															{
																this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
															}
															break;
														case Contact_Base.ContactType.Surface:
														case Contact_Base.ContactType.UndeterminedNaval:
															b = (shootTouristsDoctrine.HasValue ? new byte?((byte)shootTouristsDoctrine.GetValueOrDefault()) : null);
															if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && !Information.IsNothing(weapon2) && this.m_ActiveUnit.GetHorizontalRange(current5) < weapon2.RangeASUWMax)
															{
																this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
															}
															break;
														case Contact_Base.ContactType.Submarine:
															if (!Information.IsNothing(weapon4) && !current5.IsBiologics() && this.m_ActiveUnit.GetHorizontalRange(current5) < weapon4.RangeASWMax)
															{
																this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
															}
															break;
														case Contact_Base.ContactType.Aimpoint:
														case Contact_Base.ContactType.Facility_Fixed:
														case Contact_Base.ContactType.Facility_Mobile:
															b = (shootTouristsDoctrine.HasValue ? new byte?((byte)shootTouristsDoctrine.GetValueOrDefault()) : null);
															if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && !Information.IsNothing(weapon3) && this.m_ActiveUnit.GetHorizontalRange(current5) < weapon3.RangeLandMax)
															{
																this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
															}
															break;
														case Contact_Base.ContactType.Orbital:
															b = (shootTouristsDoctrine.HasValue ? new byte?((byte)shootTouristsDoctrine.GetValueOrDefault()) : null);
															if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
															{
																ActiveUnit_Weaponry weaponry2 = this.m_ActiveUnit.GetWeaponry();
																Contact theTarget2 = current5;
																Doctrine doctrine2 = this.m_ActiveUnit.m_Doctrine;
																string text = "";
																int num = 0;
																if (weaponry2.HasWeaponsInConditionToAttackTarget(theTarget2, true, doctrine2, ref text, ref num, null) && !Information.IsNothing(weapon) && this.m_ActiveUnit.GetSlantRange(current5, 0f) < (float)current5.method_72() * weapon.RangeAAWMax)
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
							}
						}
						IL_B17:;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100547", "");
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

		// Token: 0x060056EC RID: 22252 RVA: 0x002587E8 File Offset: 0x002569E8
		public override void ThreatAssessment()
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && !this.m_ActiveUnit.IsFixedFacility() && !this.HoldPosition)
			{
				try
				{
					base.AddThreats();
					this.m_ActiveUnit.m_Scenario.GetActiveUnits();
					Weapon[] availableWeapons = this.m_ActiveUnit.GetWeaponry().GetAvailableWeapons(false);
					List<Contact> contactList = this.m_ActiveUnit.GetSensory().GetContactList();
					foreach (Contact current in contactList)
					{
						ActiveUnit actualUnit;
						try
						{
							actualUnit = current.ActualUnit;
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200027", ex2.Message);
							GameGeneral.LogException(ref ex2);
							ProjectData.ClearProjectError();
							continue;
						}
						if (!Information.IsNothing(actualUnit) && actualUnit.IsWeapon)
						{
							string guid = current.GetGuid();
							Misc.PostureStance postureStance;
							if (!this.PostureStanceDictionary.TryGetValue(guid, out postureStance))
							{
								postureStance = current.GetPostureStance(this.m_ActiveUnit.GetSide(false));
								this.PostureStanceDictionary.Add(guid, postureStance);
							}
							if (postureStance != Misc.PostureStance.Friendly && ((Weapon)actualUnit).weaponTarget.IsSurfaceShip)
							{
								this.AddThreat(current);
								Weapon._WeaponType weaponType = ((Weapon)actualUnit).GetWeaponType();
								if (weaponType == Weapon._WeaponType.GuidedWeapon)
								{
									Weapon aAWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetAAWWeapon_RangeMax();
									if (!Information.IsNothing(aAWWeapon_RangeMax))
									{
										ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
										Contact theTarget = current;
										Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
										string text = "";
										int num = 0;
										if (weaponry.HasWeaponsInConditionToAttackTarget(theTarget, true, doctrine, ref text, ref num, availableWeapons) && (double)this.m_ActiveUnit.GetSlantRange(current, 0f) < 1.5 * (double)aAWWeapon_RangeMax.RangeAAWMax)
										{
											this.TargetingContact(current, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
										}
									}
								}
							}
						}
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 100548", "");
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x00258A80 File Offset: 0x00256C80
		public override void UpdateMissionStatus(float float_1)
		{
			if (!Information.IsNothing(this.m_ActiveUnit))
			{
				try
				{
					if (this.GetParentPlatform().method_129() || (int)Math.Round((double)this.GetParentPlatform().GetCurrentSpeed()) <= 0)
					{
						base.UpdateMissionStatus(float_1);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100549", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x00258B18 File Offset: 0x00256D18
		public void method_90(float float_1)
		{
			try
			{
				Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
				Weapon weapon = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), false, true, doctrine);
				if (!Information.IsNothing(weapon))
				{
					float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
					float maxRangeToTarget = weapon.GetMaxRangeToTarget(this.m_ActiveUnit, this.GetPrimaryTarget(), true, doctrine, false);
					float num = horizontalRange / maxRangeToTarget;
					Facility._MobileUnitCategory mobileUnitCategory = this.GetParentPlatform().GetMobileUnitCategory();
					float num2 = 0f;
					if (mobileUnitCategory - Facility._MobileUnitCategory.Infrantry > 1)
					{
						if (mobileUnitCategory - Facility._MobileUnitCategory.ArtilleryGun <= 1)
						{
							num2 = 0.95f;
						}
					}
					else
					{
						num2 = 0.5f;
					}
					if (num > num2)
					{
						this.m_ActiveUnit.GetKinematics().SetDesiredSpeedOverride(null);
						if (this.m_ActiveUnit.GetThrottle() < ActiveUnit.Throttle.Full)
						{
							this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Full, null);
						}
						this.vmethod_18(float_1);
					}
					else
					{
						this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.FullStop, null);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100550", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x00258C8C File Offset: 0x00256E8C
		public override void Navigate(float elapsedTime_)
		{
			if (!Information.IsNothing(this.m_ActiveUnit))
			{
				try
				{
					if (!this.m_ActiveUnit.IsFixedFacility())
					{
						ActiveUnit._ActiveUnitStatus unitStatus = this.m_ActiveUnit.GetUnitStatus();
						switch (unitStatus)
						{
						case ActiveUnit._ActiveUnitStatus.OnPlottedCourse:
							if (this.m_ActiveUnit.HasAssignedPatrolMission() && !this.m_ActiveUnit.GetNavigator().HasManualPlottedCourse())
							{
								Patrol patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
								if (!this.m_ActiveUnit.GetNavigator().method_30(ref patrol.PatrolAreaVertices, ref patrol.PatrolAreaVertices, ref patrol.list_6, 0f, false))
								{
									this.m_ActiveUnit.GetNavigator().ClearPlottedCourse();
									this.m_ActiveUnit.GetNavigator().SetDesiredHeading();
								}
							}
							this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
							if (!this.m_ActiveUnit.GetNavigator().HasPlottedCourse() && this.m_ActiveUnit.GetKinematics().GetSpeedPreset() != ActiveUnit_Kinematics._SpeedPreset.FullStop && this.m_ActiveUnit.GetDesiredSpeed() != 0f)
							{
								this.m_ActiveUnit.GetKinematics().SetDesiredSpeedOverride(null);
								this.m_ActiveUnit.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.None);
								this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.FullStop, null);
								return;
							}
							if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse() && this.m_ActiveUnit.GetDesiredSpeed() == 0f)
							{
								if (!this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
								{
									this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
								}
								else
								{
									this.m_ActiveUnit.SetDesiredSpeed(this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().Value);
									this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, new float?((float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))));
								}
							}
							return;
						case ActiveUnit._ActiveUnitStatus.EngagedOffensive:
						{
							if (Information.IsNothing(this.GetPrimaryTarget()))
							{
								return;
							}
							Contact_Base.ContactType contactType = this.GetPrimaryTarget().contactType;
							if (contactType <= Contact_Base.ContactType.Missile)
							{
								this.m_ActiveUnit.SetDesiredSpeed(0f);
							}
							else
							{
								this.method_90(elapsedTime_);
							}
							return;
						}
						case ActiveUnit._ActiveUnitStatus.EngagedDefensive:
						case ActiveUnit._ActiveUnitStatus.OnAttackRun:
						case ActiveUnit._ActiveUnitStatus.RTB:
							break;
						case ActiveUnit._ActiveUnitStatus.OnPatrol:
						{
							Patrol patrol2 = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
							if (Information.IsNothing(patrol2))
							{
								this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
							}
							else
							{
								if (!this.m_ActiveUnit.HasParentGroup())
								{
									if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
									{
										ActiveUnit_Navigator navigator = this.m_ActiveUnit.GetNavigator();
										Patrol patrol = patrol2;
										List<ReferencePoint> list = null;
										List<ReferencePoint> list2 = null;
										if (!navigator.method_30(ref patrol.PatrolAreaVertices, ref list, ref list2, 30f, false))
										{
											this.m_ActiveUnit.GetNavigator().SetDesiredHeading();
										}
										this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
									}
									else
									{
										this.m_ActiveUnit.GetNavigator().SetDesiredHeading();
									}
									return;
								}
								if (this.m_ActiveUnit.IsGroupLead())
								{
									if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
									{
										ActiveUnit_Navigator navigator = this.m_ActiveUnit.GetParentGroup(false).GetNavigator();
										Patrol patrol = patrol2;
										List<ReferencePoint> list2 = null;
										List<ReferencePoint> list = null;
										if (!navigator.method_30(ref patrol.PatrolAreaVertices, ref list2, ref list, 0f, false))
										{
											this.m_ActiveUnit.GetParentGroup(false).GetNavigator().SetDesiredHeading();
										}
										this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
									}
									else
									{
										this.m_ActiveUnit.GetParentGroup(false).GetNavigator().SetDesiredHeading();
									}
									return;
								}
								if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
								{
									this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
									return;
								}
							}
							break;
						}
						case ActiveUnit._ActiveUnitStatus.Tasked:
							if (this.IsEscort)
							{
								base.method_15();
							}
							break;
						default:
							if (unitStatus != ActiveUnit._ActiveUnitStatus.OnSupportMission)
							{
								if (unitStatus != ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
								{
								}
							}
							else if (Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
							{
								this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
							}
							else if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Support)
							{
								if (!this.m_ActiveUnit.HasParentGroup())
								{
									this.m_ActiveUnit.GetNavigator().vmethod_6(elapsedTime_, this.m_ActiveUnit.GetNavigator().method_11());
									return;
								}
								if (this.m_ActiveUnit.IsGroupLead())
								{
									this.m_ActiveUnit.GetNavigator().vmethod_6(elapsedTime_, this.m_ActiveUnit.GetNavigator().method_11());
									return;
								}
								if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
								{
									this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
									return;
								}
							}
							break;
						}
						if (this.m_ActiveUnit.HasParentGroup() && this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
						{
							this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
						}
						else if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Unassigned)
						{
							this.m_ActiveUnit.SetDesiredSpeed(0f);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100551", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x0002392B File Offset: 0x00021B2B
		[CompilerGenerated]
		private bool method_91(NoNavZone noNavZone_0)
		{
			return noNavZone_0.IsAffected(this.m_ActiveUnit);
		}

		// Token: 0x04002ADA RID: 10970
		private Facility ParentPlatform;
	}
}

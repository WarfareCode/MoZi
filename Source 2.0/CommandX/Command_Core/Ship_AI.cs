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
	// Token: 0x02000B70 RID: 2928
	public sealed class Ship_AI : ActiveUnit_AI
	{
		// Token: 0x060060F6 RID: 24822 RVA: 0x002E1BF4 File Offset: 0x002DFDF4
		public static Ship_AI Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_1, ref ActiveUnit activeUnit_1)
		{
			Ship_AI result = null;
			try
			{
				Ship_AI ship_AI = new Ship_AI(ref activeUnit_1);
				ship_AI.m_ActiveUnit = activeUnit_1;
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
								if (num != 106934956u)
								{
									if (num != 357111700u)
									{
										if (num == 467450941u && Operators.CompareString(name, "PrimaryThreat", false) == 0)
										{
											ship_AI.PrimaryThreat = Contact.GetContact(xmlNode.InnerText, ref dictionary_1);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "IgnorePlottedCourse", false) != 0)
										{
											continue;
										}
										goto IL_446;
									}
								}
								else
								{
									if (Operators.CompareString(name, "PrimaryTarget", false) == 0)
									{
										ship_AI.PrimaryTarget = Contact.GetContact(xmlNode.InnerText, ref dictionary_1);
										continue;
									}
									continue;
								}
							}
							else if (num != 592141878u)
							{
								if (num != 1474882803u)
								{
									if (num == 1610968176u && Operators.CompareString(name, "TTNPTE", false) == 0)
									{
										ship_AI.TimeToNextPrimaryTargetEvent = Conversions.ToShort(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "IE", false) == 0)
									{
										ship_AI.IsEscort = true;
										continue;
									}
									continue;
								}
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
										ScenarioArrayUtil.AddContact(ref ship_AI.Threats, contact_);
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
						if (num <= 2276842832u)
						{
							if (num != 1966596370u)
							{
								if (num != 2133975202u)
								{
									if (num != 2276842832u || Operators.CompareString(name, "TargetList", false) != 0)
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
											if (!Information.IsNothing(targetingEntry.Target))
											{
												try
												{
													ship_AI.GetTargetList().Add(targetingEntry.Target.GetGuid(), targetingEntry);
												}
												catch (Exception ex)
												{
													ProjectData.SetProjectError(ex);
													Exception ex2 = ex;
													ex2.Data.Add("Error at 200037", ex2.Message);
													GameGeneral.LogException(ref ex2);
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
													ProjectData.ClearProjectError();
												}
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
								if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lat", false) == 0)
								{
									ship_AI.SetPrimaryTarget_LastKnown_Lat(XmlConvert.ToDouble(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lon", false) == 0)
								{
									ship_AI.SetPrimaryTarget_LastKnown_Lon(XmlConvert.ToDouble(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else
						{
							if (num <= 3761246852u)
							{
								if (num != 2722719197u)
								{
									if (num != 3761246852u)
									{
										continue;
									}
									if (Operators.CompareString(name, "PrimaryTargetOverrideExists", false) != 0)
									{
										continue;
									}
								}
								else if (Operators.CompareString(name, "PTOE", false) != 0)
								{
									continue;
								}
								ship_AI.bPrimaryTargetOverride = Conversions.ToBoolean(xmlNode.InnerText);
								continue;
							}
							if (num != 3957045325u)
							{
								if (num == 4076649232u && Operators.CompareString(name, "PrimaryTarget_LastKnown_Alt", false) == 0)
								{
									ship_AI.SetPrimaryTarget_LastKnown_Alt(XmlConvert.ToSingle(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "IPC", false) != 0)
							{
								continue;
							}
						}
						IL_446:
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
				result = ship_AI;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100773", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

        // Token: 0x060060F7 RID: 24823 RVA: 0x002E21DC File Offset: 0x002E03DC
        public override bool vmethod_9()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (!Information.IsNothing(this.m_ActiveUnit))
					{
						Contact[] threats = base.GetThreats();
						for (int i = 0; i < threats.Length; i++)
						{
							Contact contact = threats[i];
							if (!Information.IsNothing(contact.ActualUnit) && !Information.IsNothing(contact.ActualUnit.GetAI().GetPrimaryTarget()) && !Information.IsNothing(contact.ActualUnit.GetAI().GetPrimaryTarget().ActualUnit) && contact.ActualUnit.GetAI().GetPrimaryTarget().ActualUnit == this.m_ActiveUnit)
							{
								flag = true;
								break;
							}
							if (base.method_14(contact))
							{
								flag = true;
								break;
							}
							if (this.m_ActiveUnit.HasParentGroup())
							{
								using (IEnumerator<ActiveUnit> enumerator = this.m_ActiveUnit.GetParentGroup(false).GetUnitsInGroup().Values.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										if (enumerator.Current.GetAI().method_14(contact))
										{
											flag = true;
											result = true;
											return result;
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
					ex2.Data.Add("Error at 100774", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x00023901 File Offset: 0x00021B01
		public Ship_AI(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x002E237C File Offset: 0x002E057C
		public override void EngagedDefensive(float elapsedTime_)
		{
			try
			{
				if (!Information.IsNothing(this.PrimaryThreat))
				{
					double num = Math.Round((double)Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.PrimaryThreat.GetLatitude(null), this.PrimaryThreat.GetLongitude(null)), 0);
					if (!double.IsNaN(num))
					{
						Contact_Base.ContactType contactType = this.PrimaryThreat.contactType;
						if (contactType != Contact_Base.ContactType.Missile && contactType == Contact_Base.ContactType.Torpedo)
						{
							int num2 = (int)Math.Round(num);
							base.RunOppositeTo(ref num2);
							this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100775", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x001C4C2C File Offset: 0x001C2E2C
		private Weapon[] GetAvailableWeapons()
		{
			return this.m_ActiveUnit.GetWeaponry().GetAvailableWeapons(false);
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x002E2494 File Offset: 0x002E0694
		public override void TargetingContacts(float float_1, bool bool_6, bool bool_7)
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && !this.m_ActiveUnit.IsNotActive())
			{
				Side side = this.m_ActiveUnit.GetSide(false);
				try
				{
					checked
					{
						if (this.m_ActiveUnit.m_Mounts.Length == 0 && this.m_ActiveUnit.GetAllNoneMCMSensors().Length == 0)
						{
							if (!Information.IsNothing(this.GetPrimaryTarget()))
							{
								this.DropTargeting(this.GetPrimaryTarget(), true);
							}
							if (base.GetTargets().Length <= 0)
							{
								goto IL_AE7;
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
								goto IL_AE7;
							}
						}
						base.TargetingContacts(float_1, bool_6, bool_7);
					}
					if (!Information.IsNothing(this.m_ActiveUnit))
					{
						Mission assignedMission = this.m_ActiveUnit.GetAssignedMission(false);
						Contact[] targets2 = base.GetTargets();
						bool flag = base.IsOnPatrolStation();
						Collection<Contact> collection2 = new Collection<Contact>();
						if (this.m_ActiveUnit.GetSide(false).NoNavZoneList.Count > 0)
						{
							for (int j = targets2.Count<Contact>() - 1; j >= 0; j += -1)
							{
								Contact contact = targets2[j];
								if (!Information.IsNothing(contact) && (side.GetQuantityToFireForTheTarget(ref this.m_ActiveUnit, ref contact) <= 0 || base.GetTargetingBehavior(contact) != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc))
								{
									foreach (NoNavZone current2 in side.NoNavZoneList.Where(new Func<NoNavZone, bool>(this.method_95)))
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
						List<Contact> contactList = this.m_ActiveUnit.GetSensory().GetContactList();
						Doctrine._ShootTourists? shootTouristsDoctrine = this.m_ActiveUnit.m_Doctrine.GetShootTouristsDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
						if (!Information.IsNothing(assignedMission) && assignedMission.IsActive())
						{
							foreach (Contact current4 in contactList)
							{
								if ((bool_7 || current4.contactType == Contact_Base.ContactType.Missile || (current4.contactType == Contact_Base.ContactType.Air && this.m_ActiveUnit.m_Scenario.FifthSecondIsChangingOnThisPulse) || this.m_ActiveUnit.m_Scenario.FifteenthSecondIsChangingOnThisPulse) && !ScenarioArrayUtil.IsContactExists(ref targets2, current4) && !collection2.Contains(current4))
								{
									Contact._BattleDamageAssessment? battleDamageAssessment = current4.GetBattleDamageAssessment(side);
									byte? b = battleDamageAssessment.HasValue ? new byte?((byte)battleDamageAssessment.GetValueOrDefault()) : null;
									if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										Contact theContact = current4;
										Mission mission_ = assignedMission;
										Doctrine._ShootTourists? shootTouristsDoc_ = shootTouristsDoctrine;
										bool onPatrolStation_ = flag;
										string text = "";
										int k = 0;
										if (base.IsTargetForMission(theContact, mission_, shootTouristsDoc_, bool_6, onPatrolStation_, true, ref text, ref k))
										{
											string guid = current4.GetGuid();
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
												if (current4.contactType != Contact_Base.ContactType.Submarine || !current4.IsBiologics())
												{
													ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
													Contact theTarget = current4;
													Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
													text = "";
													k = 0;
													if (weaponry.HasWeaponsInConditionToAttackTarget(theTarget, true, doctrine, ref text, ref k, lazy.Value))
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
							Weapon aAWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetAAWWeapon_RangeMax();
							Weapon aSUWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetASUWWeapon_RangeMax(false);
							Weapon landWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetLandWeapon_RangeMax(false);
							Weapon aSWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetASWWeapon_RangeMax();
							bool flag2 = this.m_ActiveUnit.HasAssignedPatrolMission() && ((Patrol)assignedMission).method_42();
							foreach (Contact current5 in contactList)
							{
								if ((bool_7 || current5.contactType == Contact_Base.ContactType.Missile || (current5.contactType == Contact_Base.ContactType.Air && this.m_ActiveUnit.m_Scenario.FifthSecondIsChangingOnThisPulse) || this.m_ActiveUnit.m_Scenario.FifteenthSecondIsChangingOnThisPulse) && !ScenarioArrayUtil.IsContactExists(ref targets2, current5) && !collection2.Contains(current5))
								{
									string guid2 = current5.GetGuid();
									Misc.PostureStance postureStance2;
									if (!this.PostureStanceDictionary.TryGetValue(guid2, out postureStance2))
									{
										postureStance2 = current5.GetPostureStance(side);
										this.PostureStanceDictionary.Add(guid2, postureStance2);
									}
									if (postureStance2 != Misc.PostureStance.Neutral)
									{
										Contact._BattleDamageAssessment? battleDamageAssessment = current5.GetBattleDamageAssessment(side);
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
												if (!Information.IsNothing(aAWWeapon_RangeMax) && this.m_ActiveUnit.GetSlantRange(current5, 0f) < (float)current5.method_72() * aAWWeapon_RangeMax.RangeAAWMax)
												{
													this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
												}
												break;
											case Contact_Base.ContactType.Surface:
											case Contact_Base.ContactType.UndeterminedNaval:
												b = (shootTouristsDoctrine.HasValue ? new byte?((byte)shootTouristsDoctrine.GetValueOrDefault()) : null);
												if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && !Information.IsNothing(aSUWWeapon_RangeMax) && this.m_ActiveUnit.GetHorizontalRange(current5) < aSUWWeapon_RangeMax.RangeASUWMax)
												{
													this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
												}
												break;
											case Contact_Base.ContactType.Submarine:
												if (!Information.IsNothing(aSWWeapon_RangeMax) && !current5.IsBiologics() && this.m_ActiveUnit.GetHorizontalRange(current5) < aSWWeapon_RangeMax.RangeASWMax)
												{
													this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
												}
												break;
											case Contact_Base.ContactType.Aimpoint:
											case Contact_Base.ContactType.Facility_Fixed:
											case Contact_Base.ContactType.Facility_Mobile:
												b = (shootTouristsDoctrine.HasValue ? new byte?((byte)shootTouristsDoctrine.GetValueOrDefault()) : null);
												if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && !Information.IsNothing(landWeapon_RangeMax) && this.m_ActiveUnit.GetHorizontalRange(current5) < landWeapon_RangeMax.RangeLandMax)
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
													int k = 0;
													if (weaponry2.HasWeaponsInConditionToAttackTarget(theTarget2, true, doctrine2, ref text, ref k, null) && !Information.IsNothing(aAWWeapon_RangeMax) && this.m_ActiveUnit.GetSlantRange(current5, 0f) < (float)current5.method_72() * aAWWeapon_RangeMax.RangeAAWMax)
													{
														this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
													}
												}
												break;
											case Contact_Base.ContactType.Torpedo:
												if (!Information.IsNothing(aSWWeapon_RangeMax) && this.m_ActiveUnit.GetSlantRange(current5, 0f) < aSWWeapon_RangeMax.RangeASWMax * 2f)
												{
													this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
												}
												break;
											}
										}
									}
								}
							}
							checked
							{
								if (this.GetPrimaryTarget() != null && this.GetPrimaryTarget() is Aimpoint)
								{
									Side side2 = side;
									Contact primaryTarget = this.GetPrimaryTarget();
									List<Weapon> weaponsForTarget = side2.GetWeaponsForTarget(ref this.m_ActiveUnit, ref primaryTarget);
									this.SetPrimaryTarget(primaryTarget);
									List<Weapon> list = weaponsForTarget;
									bool flag3 = false;
									Mount[] mounts = this.m_ActiveUnit.m_Mounts;
									for (int k = 0; k < mounts.Length; k++)
									{
										Mount mount = mounts[k];
										using (IEnumerator<WeaponRec> enumerator6 = mount.GetWeaponRecCollection().GetEnumerator())
										{
											while (enumerator6.MoveNext())
											{
												int weapID = enumerator6.Current.WeapID;
												using (List<Weapon>.Enumerator enumerator7 = list.GetEnumerator())
												{
													while (enumerator7.MoveNext())
													{
														if (enumerator7.Current.DBID == weapID)
														{
															flag3 = true;
															break;
														}
													}
												}
												if (flag3)
												{
													break;
												}
											}
										}
										if (flag3)
										{
											break;
										}
									}
									if (!flag3)
									{
										this.DropTargeting(this.GetPrimaryTarget(), true);
									}
								}
								if (base.method_35())
								{
									this.method_89();
								}
							}
						}
					}
					IL_AE7:;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100776", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060060FC RID: 24828 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public void method_89()
		{
		}

		// Token: 0x060060FD RID: 24829 RVA: 0x002E3090 File Offset: 0x002E1290
		public override void ThreatAssessment()
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && !this.m_ActiveUnit.IsNotActive())
			{
				try
				{
					base.AddThreats();
					Weapon[] availableWeapons = this.m_ActiveUnit.GetWeaponry().GetAvailableWeapons(false);
					List<Contact> contactList = this.m_ActiveUnit.GetSensory().GetContactList();
					foreach (Contact current in contactList)
					{
						bool flag = false;
						if (!Information.IsNothing(current.ActualUnit) && !flag && current.ActualUnit.IsWeapon)
						{
							Misc.PostureStance postureStance;
							if (!this.PostureStanceDictionary.TryGetValue(current.GetGuid(), out postureStance))
							{
								postureStance = current.GetPostureStance(this.m_ActiveUnit.GetSide(false));
								this.PostureStanceDictionary.Add(current.GetGuid(), postureStance);
							}
							if (postureStance != Misc.PostureStance.Friendly && ((Weapon)current.ActualUnit).weaponTarget.IsSurfaceShip)
							{
								this.AddThreat(current);
								Weapon._WeaponType weaponType = ((Weapon)current.ActualUnit).GetWeaponType();
								if (weaponType == Weapon._WeaponType.Torpedo)
								{
									Weapon aSUWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetASUWWeapon_RangeMax(false);
									if (!Information.IsNothing(aSUWWeapon_RangeMax))
									{
										ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
										Contact theTarget = current;
										Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
										string text = "";
										int num = 0;
										if (weaponry.HasWeaponsInConditionToAttackTarget(theTarget, true, doctrine, ref text, ref num, availableWeapons) && (double)this.m_ActiveUnit.GetSlantRange(current, 0f) < 1.5 * (double)aSUWWeapon_RangeMax.RangeASWMax)
										{
											this.TargetingContact(current, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
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
					ex2.Data.Add("Error at 100777", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x002E32D0 File Offset: 0x002E14D0
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
							if (this.PrimaryThreat.contactType == Contact_Base.ContactType.Torpedo)
							{
								if (this.m_ActiveUnit.GetHorizontalRange(this.PrimaryThreat) < 3f)
								{
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
									return;
								}
								if (this.m_ActiveUnit.GetHorizontalRange(this.PrimaryThreat) < 10f && base.GetRelativeBearing(ref this.PrimaryThreat) < 90f)
								{
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedDefensive);
									return;
								}
							}
						}
						else if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
						{
							this.m_ActiveUnit.SetUnitStatus(this.m_ActiveUnit.SBEngagedDefensive);
						}
					}
					if (this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Refuelling && !this.m_ActiveUnit.IsRTB() && (!this.m_ActiveUnit.m_Scenario.FifthSecondIsChangingOnThisPulse || this.m_ActiveUnit.IsRTB() || this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || !base.method_74()))
					{
						if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
						{
							Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.m_ActiveUnit.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
							b = (ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null);
							bool? flag2;
							bool? flag = flag2 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null);
							if (((!flag.HasValue || flag2.GetValueOrDefault()) ? (flag2 & !Information.IsNothing(this.GetPrimaryTarget())) : new bool?(false)).GetValueOrDefault())
							{
								this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
							}
							else
							{
								this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.OnPlottedCourse);
							}
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
								if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
								{
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
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
								if (this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
								{
									switch (this.m_ActiveUnit.GetAssignedMission(false).MissionClass)
									{
									case Mission._MissionClass.Strike:
										this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Tasked);
										return;
									case Mission._MissionClass.Patrol:
										if (!Information.IsNothing(this.GetPrimaryTarget()))
										{
											Contact_Base.ContactType contactType2 = this.GetPrimaryTarget().contactType;
											if (contactType2 > Contact_Base.ContactType.Missile)
											{
												this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
												return;
											}
											if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
											{
												this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
											}
										}
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
								else
								{
									this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
								}
							}
							if (this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.RTB_MissionOver && this.m_ActiveUnit.GetFuelState() != ActiveUnit._ActiveUnitFuelState.IgnoreBingoAndJoker && this.m_ActiveUnit.GetWeaponState() != ActiveUnit._ActiveUnitWeaponState.IgnoreWinchesterAndShotgun && this.m_ActiveUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Unassigned)
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
					ex2.Data.Add("Error at 200348", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060060FF RID: 24831 RVA: 0x002E3854 File Offset: 0x002E1A54
		public override void Navigate(float elapsedTime_)
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && !this.m_ActiveUnit.IsNotActive())
			{
				try
				{
					ActiveUnit._ActiveUnitStatus activeUnitStatus = this.m_ActiveUnit.GetUnitStatus();
					this.m_ActiveUnit.GetKinematics().bool_1 = false;
					if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
					{
						this.m_ActiveUnit.GetKinematics().SetDesiredSpeedOverride(null);
						this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
						this.EngagedDefensive(elapsedTime_);
					}
					else if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
					{
						bool flag = true;
						GeoPoint intermediateTargetPoint = base.GetIntermediateTargetPoint();
						ActiveUnit_DockingOps dockingOps = this.m_ActiveUnit.GetDockingOps();
						List<Mission> theSelectedMissions = null;
						string text = "";
						List<ActiveUnit> uNREPUnits = dockingOps.GetUNREPUnits(true, theSelectedMissions, ref text);
						if (this.m_ActiveUnit.m_Scenario.MinuteIsChangingOnThisPulse || Information.IsNothing(this.m_ActiveUnit.GetDockingOps().GetUNREPDestinationUnit()))
						{
							if (!Information.IsNothing(this.m_ActiveUnit.GetDockingOps().GetUNREPDestinationUnit()) && uNREPUnits.Contains(this.m_ActiveUnit.GetDockingOps().GetUNREPDestinationUnit()))
							{
								flag = (this.m_ActiveUnit.GetDockingOps().ManoeuverToRefuelFrom(this.m_ActiveUnit.GetDockingOps().GetUNREPDestinationUnit()) || this.m_ActiveUnit.GetDockingOps().method_51(intermediateTargetPoint, null, null, "", new int?(100)));
							}
							else if (uNREPUnits.Count > 0)
							{
								flag = this.m_ActiveUnit.GetDockingOps().method_51(intermediateTargetPoint, null, null, "", new int?(100));
							}
							else
							{
								if (!Information.IsNothing(this.m_ActiveUnit.GetDockingOps().GetUNREPDestinationUnit()))
								{
									this.m_ActiveUnit.GetDockingOps().FinishUNREP();
								}
								flag = false;
							}
						}
						if (!Information.IsNothing(this.m_ActiveUnit.GetDockingOps().GetUNREPDestinationUnit()) && flag)
						{
							ActiveUnit uNREPDestinationUnit = this.m_ActiveUnit.GetDockingOps().GetUNREPDestinationUnit();
							if (this.m_ActiveUnit.IsGroupLead() && uNREPDestinationUnit.HasParentGroup() && this.m_ActiveUnit.GetParentGroup(false) == uNREPDestinationUnit.GetParentGroup(false))
							{
								uNREPDestinationUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_1, uNREPDestinationUnit.AzimuthTo(this.m_ActiveUnit));
								uNREPDestinationUnit.SetThrottle(ActiveUnit.Throttle.Full, null);
								this.m_ActiveUnit.SetDesiredSpeed(Math.Max(5f, uNREPDestinationUnit.GetCurrentSpeed() - 10f));
								this.m_ActiveUnit.SetThrottle(this.m_ActiveUnit.GetKinematics().vmethod_38(0f, (float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))), new float?((float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))));
							}
							else
							{
								if (uNREPDestinationUnit.GetCommStuff().IsNotOutOfComms())
								{
									this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_1, this.m_ActiveUnit.AzimuthTo(uNREPDestinationUnit));
								}
								else
								{
									this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_1, this.m_ActiveUnit.AzimuthTo(uNREPDestinationUnit.GetLatitudeLR().Value, uNREPDestinationUnit.GetLongitudeLR().Value));
								}
								if ((double)this.m_ActiveUnit.GetHorizontalRange(uNREPDestinationUnit) < 0.1)
								{
									this.m_ActiveUnit.SetDesiredSpeed(uNREPDestinationUnit.GetCurrentSpeed());
									this.m_ActiveUnit.SetThrottle(this.m_ActiveUnit.GetKinematics().vmethod_38(0f, (float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))), new float?((float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))));
								}
								else if ((float)(this.m_ActiveUnit.GetKinematics().GetSpeed(0f, ActiveUnit.Throttle.Cruise) - 5) < uNREPDestinationUnit.GetDesiredSpeed())
								{
									float num = (float)this.m_ActiveUnit.GetKinematics().GetSpeed(0f, ActiveUnit.Throttle.Full);
									ActiveUnit.Throttle newThrottleSetting = ActiveUnit.Throttle.Full;
									if (num - 5f < uNREPDestinationUnit.GetDesiredSpeed())
									{
										newThrottleSetting = ActiveUnit.Throttle.Flank;
									}
									this.m_ActiveUnit.SetThrottle(newThrottleSetting, null);
								}
								else
								{
									this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
								}
							}
						}
						else
						{
							if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling)
							{
								this.m_ActiveUnit.SetUnitStatus(this.m_ActiveUnit.SBR);
							}
							if (this.m_ActiveUnit.GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.ManoeuveringToRefuel || this.m_ActiveUnit.GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.Replenishing)
							{
								this.m_ActiveUnit.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
							}
						}
					}
					else if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.Refuelling)
					{
						this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.GetDockingOps().GetUNREPDestinationUnit().GetDesiredHeading(ActiveUnit._TurnRate.const_0));
						this.m_ActiveUnit.SetDesiredSpeed(this.m_ActiveUnit.GetDockingOps().GetUNREPDestinationUnit().GetDesiredSpeed());
						this.m_ActiveUnit.SetThrottle(this.m_ActiveUnit.GetKinematics().vmethod_38(0f, (float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))), new float?((float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))));
					}
					else if (activeUnitStatus != ActiveUnit._ActiveUnitStatus.RTB && activeUnitStatus != ActiveUnit._ActiveUnitStatus.RTB_Manual && activeUnitStatus != ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
					{
						if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
						{
							if (!Information.IsNothing(this.GetPrimaryTarget()))
							{
								if (this.m_ActiveUnit.HasParentGroup())
								{
									if (this.m_ActiveUnit.IsGroupLead())
									{
										Contact_Base.ContactType contactType = this.GetPrimaryTarget().contactType;
										if (contactType > Contact_Base.ContactType.Missile && contactType != Contact_Base.ContactType.Orbital)
										{
											this.vmethod_18(elapsedTime_);
										}
										else
										{
											this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
										}
									}
									else if (this.m_ActiveUnit.GetAssignedMission(false) == this.m_ActiveUnit.GetParentGroup(false).GetAssignedMission(false))
									{
										if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
										{
											this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
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
								if (!this.m_ActiveUnit.IsNotGroupLead() && !this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
								{
									float? num2 = null;
									ActiveUnit.Throttle? throttle = null;
									if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
									{
										Patrol patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
										if (!Information.IsNothing(patrol.AttackThrottle_Ship))
										{
											num2 = patrol.AttackDistance_Ship;
											if (!Information.IsNothing(num2))
											{
												float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
												if ((num2.HasValue ? new bool?(horizontalRange > num2.GetValueOrDefault()) : null).GetValueOrDefault())
												{
													throttle = new ActiveUnit.Throttle?(patrol.TransitThrottle_Ship);
												}
												else
												{
													throttle = patrol.AttackThrottle_Ship;
												}
											}
											else
											{
												throttle = patrol.AttackThrottle_Ship;
											}
										}
									}
									if (!Information.IsNothing(throttle))
									{
										this.m_ActiveUnit.SetThrottle(throttle.Value, null);
									}
									else if (this.GetPrimaryTarget().contactType == Contact_Base.ContactType.Submarine)
									{
										ActiveUnit_AI aI = this.m_ActiveUnit.GetAI();
										Unit primaryTarget = this.GetPrimaryTarget();
										float? rangeToTargetUnit_ = null;
										float transitAltitude_ = 0f;
										float? speed_ = null;
										float currentHeading = this.m_ActiveUnit.GetCurrentHeading();
										float? nullable_ = new float?(0.1f);
										bool flag2 = false;
										if (aI.CanReachTargetUnit(primaryTarget, rangeToTargetUnit_, transitAltitude_, speed_, currentHeading, ActiveUnit.Throttle.Loiter, nullable_, false, false, ref flag2))
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Loiter, null);
										}
										else
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
											this.m_ActiveUnit.GetKinematics().method_13();
										}
									}
									else
									{
										if (this.m_ActiveUnit.GetThrottle() != ActiveUnit.Throttle.Full)
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Full, null);
										}
										ActiveUnit_AI aI2 = this.m_ActiveUnit.GetAI();
										Unit primaryTarget = this.GetPrimaryTarget();
										float? rangeToTargetUnit_2 = null;
										float transitAltitude_2 = 0f;
										float? speed_2 = null;
										float currentHeading = this.m_ActiveUnit.GetCurrentHeading();
										float? nullable_2 = new float?(0.1f);
										bool flag2 = false;
										if (!aI2.CanReachTargetUnit(primaryTarget, rangeToTargetUnit_2, transitAltitude_2, speed_2, currentHeading, ActiveUnit.Throttle.Full, nullable_2, false, false, ref flag2))
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
										}
									}
								}
							}
						}
						else if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnPlottedCourse)
						{
							if (this.m_ActiveUnit.HasAssignedPatrolMission() && !this.m_ActiveUnit.GetNavigator().HasManualPlottedCourse())
							{
								Patrol patrol2 = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
								if (!this.m_ActiveUnit.GetNavigator().method_30(ref patrol2.PatrolAreaVertices, ref patrol2.list_14, ref patrol2.list_10, 30f, false))
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
								this.m_ActiveUnit.SetUnitStatus(this.m_ActiveUnit.m_ActiveUnitStatus);
							}
							else
							{
								if (!this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
								{
									if (this.m_ActiveUnit.HasAssignedPatrolMission())
									{
										Patrol patrol2 = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
										if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref patrol2.PatrolAreaVertices, ref patrol2.list_11, ref patrol2.list_7, 2, false, false))
										{
											this.m_ActiveUnit.SetThrottle(patrol2.StationThrottle_Ship, null);
										}
										else
										{
											this.m_ActiveUnit.SetThrottle(patrol2.TransitThrottle_Ship, null);
										}
									}
									else if (this.m_ActiveUnit.HasAssignedMiningMission())
									{
										MiningMission miningMission = (MiningMission)this.m_ActiveUnit.GetAssignedMission(false);
										if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref miningMission.AreaVertices, ref miningMission.list_13, ref miningMission.list_8, 2, false, false))
										{
											this.m_ActiveUnit.SetThrottle(miningMission.StationThrottle_Ship, null);
										}
										else
										{
											this.m_ActiveUnit.SetThrottle(miningMission.TransitThrottle_Ship, null);
										}
									}
									else if (this.m_ActiveUnit.HasAssignedMineClearingMission())
									{
										MineClearingMission mineClearingMission = (MineClearingMission)this.m_ActiveUnit.GetAssignedMission(false);
										if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref mineClearingMission.AreaVertices, ref mineClearingMission.list_11, ref mineClearingMission.list_7, 2, false, false))
										{
											this.m_ActiveUnit.SetThrottle(mineClearingMission.StationThrottle_Ship, null);
										}
										else
										{
											this.m_ActiveUnit.SetThrottle(mineClearingMission.TransitThrottle_Ship, null);
										}
									}
									else
									{
										this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
									}
								}
								if (this.m_ActiveUnit.GetAI().IsRegroupNeeded())
								{
									float num3 = 3.40282347E+38f;
									foreach (ActiveUnit current in this.m_ActiveUnit.GetParentGroup(false).GetUnitsInGroup().Values)
									{
										if (current.GetDesiredSpeed() > 0f)
										{
											if (current.GetKinematics().bool_1 && !current.IsGroupLead())
											{
												if ((double)current.GetDesiredSpeed() * 0.8 < (double)num3)
												{
													num3 = (float)((double)current.GetDesiredSpeed() * 0.8);
												}
											}
											else if (current.GetDesiredSpeed() / 2f < num3)
											{
												num3 = current.GetDesiredSpeed() / 2f;
											}
										}
									}
									this.m_ActiveUnit.SetDesiredSpeed(num3);
								}
								else if (!this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue && this.m_ActiveUnit.HasParentGroup())
								{
									if (this.m_ActiveUnit.IsGroupLead())
									{
										float num4 = 3.40282347E+38f;
										foreach (ActiveUnit current2 in this.m_ActiveUnit.GetParentGroup(false).GetUnitsInGroup().Values)
										{
											if (current2.GetKinematics().bool_1)
											{
												num4 = current2.GetDesiredSpeed();
											}
											else
											{
												float num5 = (float)current2.GetKinematics().GetSpeed(current2.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Cruise);
												if (num5 < num4)
												{
													num4 = num5;
												}
											}
										}
										this.m_ActiveUnit.SetDesiredSpeed(num4);
									}
									else
									{
										this.m_ActiveUnit.SetDesiredSpeed(this.m_ActiveUnit.GetParentGroup(false).GetDesiredSpeed());
									}
								}
								if (this.m_ActiveUnit.HasAssignedMiningMission())
								{
									this.NavigateToExecuteMiningMission(elapsedTime_);
								}
								this.m_ActiveUnit.SetThrottle(this.m_ActiveUnit.GetKinematics().vmethod_38(this.m_ActiveUnit.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))), new float?((float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))));
								if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.MineClearing)
								{
									if (this.m_ActiveUnit.m_Scenario.FifteenthSecondIsChangingOnThisPulse)
									{
										Ship_AI.MineClearingMissionAI0 mineClearingMissionAI = new Ship_AI.MineClearingMissionAI0(null);
										mineClearingMissionAI.ship_AI = this;
										MineClearingMission mineClearingMission = (MineClearingMission)this.m_ActiveUnit.GetAssignedMission(false);
										mineClearingMissionAI.MineClearingArea = mineClearingMission.AreaVertices;
										mineClearingMissionAI.MineBag = new ConcurrentBag<UnguidedWeapon>();
										mineClearingMissionAI.MinesDictionary = this.m_ActiveUnit.m_Scenario.GetUnguidedWeapons();
										Parallel.ForEach<string>(this.m_ActiveUnit.GetSide(false).Contacts_NonAU, new Action<string>(mineClearingMissionAI.TryAddToMineBag));
										if (mineClearingMissionAI.MineBag.Count > 0)
										{
											UnguidedWeapon unguidedWeapon = mineClearingMissionAI.MineBag.ToList<UnguidedWeapon>().Where(Ship_AI.UnguidedWeaponFunc0).OrderBy(new Func<UnguidedWeapon, double>(this.GetAngularDistance)).ElementAtOrDefault(0);
											float horizontalRange2 = this.m_ActiveUnit.GetHorizontalRange(unguidedWeapon);
											base.NavigateToClearTheMine(unguidedWeapon, horizontalRange2);
											if (horizontalRange2 < 3f)
											{
												this.m_ActiveUnit.SetDesiredSpeed(horizontalRange2 + 1f);
											}
										}
										else if (Information.IsNothing(this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride()))
										{
											this.m_ActiveUnit.SetDesiredSpeed(3f);
											this.m_ActiveUnit.SetThrottle(this.m_ActiveUnit.GetKinematics().vmethod_38(this.m_ActiveUnit.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))), new float?((float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))));
										}
									}
									foreach (ActiveUnit current3 in this.m_ActiveUnit.m_Scenario.GetActiveUnitList())
									{
										if (current3.IsSubmarine && (((Submarine)current3).Type == Submarine._SubmarineType.ROV || ((Submarine)current3).Type == Submarine._SubmarineType.UUV) && current3.IsOperating() && current3.GetDockingOps().GetAssignedHostUnit(false) == this.m_ActiveUnit)
										{
											ActiveUnit._ActiveUnitFuelState fuelState = current3.GetFuelState(null);
											if (fuelState == ActiveUnit._ActiveUnitFuelState.IsBingo || fuelState == ActiveUnit._ActiveUnitFuelState.IsJoker)
											{
												if ((float)current3.GetKinematics().GetSpeed(current3.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Cruise) >= 5f)
												{
													this.m_ActiveUnit.SetDesiredSpeed((float)(0.5 * (double)current3.GetKinematics().GetSpeed(current3.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Cruise)));
												}
												else
												{
													this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
												}
												this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.AzimuthTo(current3));
												break;
											}
										}
									}
								}
							}
						}
						else
						{
							if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnPatrol)
							{
								if (Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
								{
									activeUnitStatus = ActiveUnit._ActiveUnitStatus.Unassigned;
								}
								else if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
								{
									Patrol patrol3 = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
									if (!Information.IsNothing(patrol3))
									{
										if (this.m_ActiveUnit.HasParentGroup())
										{
											if (this.m_ActiveUnit.IsGroupLead())
											{
												if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
												{
													if (!this.m_ActiveUnit.GetParentGroup(false).GetNavigator().method_30(ref patrol3.PatrolAreaVertices, ref patrol3.list_14, ref patrol3.list_10, 30f, false))
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
											else if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
											{
												this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
											}
										}
										else if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
										{
											if (!this.m_ActiveUnit.GetNavigator().method_30(ref patrol3.PatrolAreaVertices, ref patrol3.list_14, ref patrol3.list_10, 30f, false))
											{
												this.m_ActiveUnit.GetNavigator().SetDesiredHeading();
											}
											this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
										}
										else
										{
											this.m_ActiveUnit.GetNavigator().SetDesiredHeading();
										}
										if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
										{
											GlobalVariables.PatrolType patrolType = ((Patrol)this.m_ActiveUnit.GetAssignedMission(false)).patrolType;
											if (patrolType == GlobalVariables.PatrolType.ASW || patrolType == GlobalVariables.PatrolType.SeaControl)
											{
												Patrol patrol4 = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
												if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref patrol4.PatrolAreaVertices, ref patrol4.list_11, ref patrol4.list_7, 2, false, false))
												{
													this.m_ActiveUnit.GetKinematics().method_13();
												}
											}
										}
									}
									return;
								}
							}
							if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnSupportMission)
							{
								if (Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
								{
									activeUnitStatus = ActiveUnit._ActiveUnitStatus.Unassigned;
								}
								else if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Support)
								{
									if (Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
									{
										activeUnitStatus = ActiveUnit._ActiveUnitStatus.Unassigned;
									}
									else
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
								}
							}
							if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.Tasked)
							{
								if (this.IsEscort)
								{
									base.method_15();
									return;
								}
								if (this.m_ActiveUnit.HasAssignedMiningMission())
								{
									this.NavigateToExecuteMiningMission(elapsedTime_);
									return;
								}
								if (this.m_ActiveUnit.HasAssignedCargoMission())
								{
									this.NavigateToExecuteCargoMission(elapsedTime_);
									return;
								}
								if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.MineClearing)
								{
									Ship_AI.MineClearingMissionAI mineClearingMissionAI2 = new Ship_AI.MineClearingMissionAI(null);
									mineClearingMissionAI2.ship_AI = this;
									MineClearingMission mineClearingMission = (MineClearingMission)this.m_ActiveUnit.GetAssignedMission(false);
									mineClearingMissionAI2.UnguidedWeapons = this.m_ActiveUnit.m_Scenario.GetUnguidedWeapons();
									mineClearingMissionAI2.MineClearingArea = mineClearingMission.AreaVertices;
									mineClearingMissionAI2.MineBag = new ConcurrentBag<UnguidedWeapon>();
									Parallel.ForEach<string>(this.m_ActiveUnit.GetSide(false).Contacts_NonAU, new Action<string>(mineClearingMissionAI2.TryAddToMineBag));
									if (mineClearingMissionAI2.MineBag.Count > 0)
									{
										UnguidedWeapon unguidedWeapon = mineClearingMissionAI2.MineBag.ToList<UnguidedWeapon>().Where(Ship_AI.UnguidedWeaponFunc1).OrderBy(new Func<UnguidedWeapon, double>(this.GetAngularDistance)).ElementAtOrDefault(0);
										float horizontalRange3 = this.m_ActiveUnit.GetHorizontalRange(unguidedWeapon);
										base.NavigateToClearTheMine(unguidedWeapon, horizontalRange3);
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
									if (!this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
									{
										if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref mineClearingMission.AreaVertices, ref mineClearingMission.list_11, ref mineClearingMission.list_7, 2, false, false))
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Loiter, null);
										}
										else
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
										}
									}
									return;
								}
								if (Information.IsNothing(this.GetPrimaryTarget()) && !this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
								{
									this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.FullStop, null);
								}
							}
							if (this.m_ActiveUnit.HasParentGroup())
							{
								if (!this.m_ActiveUnit.IsGroupLead() && !Information.IsNothing(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()) && this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetDockingOps().GetUNREPDestinationUnit() == this.m_ActiveUnit)
								{
									ActiveUnit._ActiveUnitStatus unitStatus = this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetUnitStatus();
									if (unitStatus != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
									{
										if (unitStatus != ActiveUnit._ActiveUnitStatus.Refuelling)
										{
											if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
											{
												this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
											}
										}
										else
										{
											this.m_ActiveUnit.SetDesiredHeading(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetDesiredTurnRate(), this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetDesiredHeading(ActiveUnit._TurnRate.const_0));
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
										}
									}
									else
									{
										this.m_ActiveUnit.SetDesiredHeading(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead().GetDesiredTurnRate(), this.m_ActiveUnit.AzimuthTo(this.m_ActiveUnit.GetParentGroup(false).GetGroupLead()));
										this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Full, null);
									}
								}
								else if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
								{
									this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
								}
							}
							else if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Unassigned)
							{
								this.m_ActiveUnit.SetDesiredSpeed(0f);
							}
						}
					}
					else
					{
						ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = this.m_ActiveUnit.GetDockingOps().GetDockingOpsCondition();
						if (dockingOpsCondition != ActiveUnit_DockingOps._DockingOpsCondition.Underway)
						{
							if (dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.RTB)
							{
								if (this.m_ActiveUnit.HasParentGroup())
								{
									this.m_ActiveUnit.method_121(false, true);
								}
								this.vmethod_27(elapsedTime_);
							}
						}
						else
						{
							this.m_ActiveUnit.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.RTB);
							this.vmethod_27(elapsedTime_);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100780", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006100 RID: 24832 RVA: 0x002E5350 File Offset: 0x002E3550
		private void NavigateToExecuteMiningMission(float float_1)
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
						this.m_ActiveUnit.GetNavigator().vmethod_7(float_1);
					}
					else
					{
						this.m_ActiveUnit.GetParentGroup(false).GetNavigator().HeadingToTheArea(miningMission.AreaVertices);
					}
				}
				else if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
				{
					this.m_ActiveUnit.GetNavigator().FollowGroupLead(float_1);
				}
			}
			else if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
			{
				if (!this.m_ActiveUnit.GetNavigator().method_30(ref miningMission.AreaVertices, ref miningMission.list_16, ref miningMission.list_11, 30f, false))
				{
					this.m_ActiveUnit.GetNavigator().HeadingToTheArea(miningMission.AreaVertices);
				}
				this.m_ActiveUnit.GetNavigator().vmethod_7(float_1);
			}
			else
			{
				this.m_ActiveUnit.GetNavigator().HeadingToTheArea(miningMission.AreaVertices);
			}
			if (!this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
			{
				if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref miningMission.AreaVertices, ref miningMission.list_13, ref miningMission.list_8, 2, false, false))
				{
					this.m_ActiveUnit.SetThrottle(miningMission.StationThrottle_Ship, null);
				}
				else
				{
					this.m_ActiveUnit.SetThrottle(miningMission.TransitThrottle_Ship, null);
				}
			}
		}

		// Token: 0x06006101 RID: 24833 RVA: 0x002E5550 File Offset: 0x002E3750
		private bool method_91(GeoPoint geoPoint_, CargoMission CargoMission_)
		{
			List<GeoPoint> list = this.method_92(geoPoint_, CargoMission_);
			return list != null && list.Any<GeoPoint>();
		}

		// Token: 0x06006102 RID: 24834 RVA: 0x002E5574 File Offset: 0x002E3774
		private List<GeoPoint> method_92(GeoPoint geoPoint_, CargoMission CargoMission_)
		{
			List<GeoPoint> result;
			if (!geoPoint_.method_22(ref CargoMission_.AreaPoints, true))
			{
				result = null;
			}
			else
			{
				GeoPoint geoPoint = new GeoPoint();
				List<GeoPoint> list = new List<GeoPoint>();
				short elevation = Terrain.GetElevation(geoPoint_.GetLatitude(), geoPoint_.GetLongitude(), false);
				if (elevation < 0 && elevation > -20)
				{
					int num = 1;
					do
					{
						float num2 = 0f;
						do
						{
							double longitude = geoPoint_.GetLongitude();
							double latitude = geoPoint_.GetLatitude();
							GeoPoint geoPoint2;
							double longitude2 = (geoPoint2 = geoPoint).GetLongitude();
							GeoPoint geoPoint3;
							double latitude2 = (geoPoint3 = geoPoint).GetLatitude();
							GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref longitude2, ref latitude2, (double)num2, (double)num);
							geoPoint3.SetLatitude(latitude2);
							geoPoint2.SetLongitude(longitude2);
							if (geoPoint.method_22(ref CargoMission_.AreaPoints, true))
							{
								short elevation2 = Terrain.GetElevation(geoPoint.GetLatitude(), geoPoint.GetLongitude(), false);
								if (elevation2 > 0 && elevation2 < 50)
								{
									list.Add(geoPoint);
								}
							}
							num2 += 0.1f;
						}
						while (num2 <= 2f);
						num++;
					}
					while (num <= 360);
					result = list;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06006103 RID: 24835 RVA: 0x002E56B4 File Offset: 0x002E38B4
		private void NavigateToExecuteCargoMission(float float_1)
		{
			CargoMission cargoMission = (CargoMission)this.m_ActiveUnit.GetAssignedMission(false);
			if (this.m_ActiveUnit.m_OnboardCargos.Count<Cargo>() == 0)
			{
				this.m_ActiveUnit.GetDockingOps().method_7(false, ActiveUnit._ActiveUnitStatus.RTB_MissionOver, true, ActiveUnit._ActiveUnitStatus.RTB_Group, true, true);
			}
			else if (!this.m_ActiveUnit.GetNavigator().IsOnStation(ref cargoMission.AreaPoints, ref cargoMission.list_8, ref cargoMission.list_9, 1, false, false))
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
						this.m_ActiveUnit.SetThrottle(cargoMission.StationThrottle_Ship, null);
					}
					else
					{
						this.m_ActiveUnit.SetThrottle(cargoMission.TransitThrottle_Ship, null);
					}
				}
			}
			else if (this.m_ActiveUnit.IsOnLand() | this.m_ActiveUnit.IsAboveSeaLevel(float_1))
			{
				this.m_ActiveUnit.GetDockingOps().method_21();
			}
			else if (this.method_91(new GeoPoint(this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetLatitude(null)), cargoMission))
			{
				this.m_ActiveUnit.GetDockingOps().method_21();
			}
			else
			{
				Ship_AI.DistanceMeasurer distanceMeasurer = new Ship_AI.DistanceMeasurer(null);
				distanceMeasurer.Location = new GeoPoint();
				int num = 0;
				GeoPoint geoPoint = new GeoPoint();
				List<GeoPoint> list = new List<GeoPoint>();
				while (true)
				{
					num++;
					distanceMeasurer.Location = Math2.PickSuitablePointInsideArea(cargoMission.AreaPoints);
					if (num > 1000)
					{
						break;
					}
					short elevation = Terrain.GetElevation(distanceMeasurer.Location.GetLatitude(), distanceMeasurer.Location.GetLongitude(), false);
					if (elevation > 0 && elevation < 50)
					{
						int num2 = 1;
						do
						{
							float num3 = 0f;
							do
							{
								GeoPoint geoPoint2 = new GeoPoint();
								double longitude = distanceMeasurer.Location.GetLongitude();
								double latitude = distanceMeasurer.Location.GetLatitude();
								GeoPoint geoPoint3;
								double longitude2 = (geoPoint3 = geoPoint2).GetLongitude();
								GeoPoint geoPoint4;
								double latitude2 = (geoPoint4 = geoPoint2).GetLatitude();
								GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref longitude2, ref latitude2, (double)num3, (double)num2);
								geoPoint4.SetLatitude(latitude2);
								geoPoint3.SetLongitude(longitude2);
								if (geoPoint2.method_22(ref cargoMission.AreaPoints, true))
								{
									short elevation2 = Terrain.GetElevation(geoPoint2.GetLatitude(), geoPoint2.GetLongitude(), false);
									if (elevation2 < 0 && elevation2 > -20)
									{
										list.Add(geoPoint2);
									}
								}
								num3 += 0.1f;
							}
							while (num3 <= 2f);
							num2++;
						}
						while (num2 <= 360);
						if (list.Any<GeoPoint>())
						{
							goto IL_48F;
						}
					}
				}
				this.m_ActiveUnit.LogMessage(this.m_ActiveUnit.Name + " is unable to pick a suitable point inside cargo landing area defined by Ref. Points", LoggedMessage.MessageType.DockingOps, 1, true, distanceMeasurer.Location);
				return;
				IL_48F:
				geoPoint = list.OrderByDescending((distanceMeasurer.MeasureFunc == null) ? (distanceMeasurer.MeasureFunc = new Func<GeoPoint, double>(distanceMeasurer.GetAngularDistance)) : distanceMeasurer.MeasureFunc).ThenBy(Ship_AI.UnguidedWeaponFunc2).First<GeoPoint>();
				this.m_ActiveUnit.GetNavigator().ClearPlottedCourse();
				this.m_ActiveUnit.GetNavigator().AddWaypoint(geoPoint.GetLatitude(), geoPoint.GetLongitude(), Waypoint.WaypointType.PatrolStation, Waypoint._Creator.const_1, Waypoint._Category.const_0);
				this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), geoPoint.GetLatitude(), geoPoint.GetLongitude()));
			}
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x002E5C08 File Offset: 0x002E3E08
		public override  void vmethod_18(float float_1)
		{
			base.vmethod_18(float_1);
			bool flag = false;
			if (base.method_63(this.GetPrimaryTarget()))
			{
				Doctrine._MaintainStandoff? maintainStandoffDoctrine = this.m_ActiveUnit.m_Doctrine.GetMaintainStandoffDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
				byte? b = maintainStandoffDoctrine.HasValue ? new byte?((byte)maintainStandoffDoctrine.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					flag = this.method_94(float_1);
				}
			}
			if (!flag)
			{
				Weapon weapon = null;
				if (!Information.IsNothing(this.GetPrimaryTarget()))
				{
					weapon = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), true, true, this.m_ActiveUnit.m_Doctrine);
				}
				if (!Information.IsNothing(weapon) && base.method_63(this.GetPrimaryTarget()) && this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget()) <= weapon.GetMaxRangeToTarget(this.m_ActiveUnit, this.GetPrimaryTarget(), true, this.m_ActiveUnit.m_Doctrine, false))
				{
					base.method_44(ref weapon);
				}
			}
		}

		// Token: 0x06006105 RID: 24837 RVA: 0x002E5D3C File Offset: 0x002E3F3C
		public bool method_94(float float_1)
		{
			bool flag = false;
			bool result;
			try
			{
				if (Information.IsNothing(this.GetPrimaryTarget()))
				{
					flag = false;
				}
				else if (this.GetPrimaryTarget().contactType != Contact_Base.ContactType.Air && this.GetPrimaryTarget().contactType != Contact_Base.ContactType.Missile)
				{
					Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
					Weapon weapon = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), true, true, doctrine);
					if (Information.IsNothing(weapon))
					{
						flag = false;
						result = false;
						return result;
					}
					float maxRangeToTarget = weapon.GetMaxRangeToTarget(this.m_ActiveUnit, this.GetPrimaryTarget(), true, doctrine, false);
					float? rangeMax = this.GetPrimaryTarget().GetRangeMax(this.GetPrimaryTarget().contactType);
					float num;
					if (rangeMax.HasValue)
					{
						num = rangeMax.Value;
					}
					else
					{
						num = 0f;
					}
					if (num >= maxRangeToTarget)
					{
						flag = false;
						result = false;
						return result;
					}
					float num2 = num + (maxRangeToTarget - num) / 4f;
					GeoPoint geoPoint = new GeoPoint();
					double longitude = this.GetPrimaryTarget().GetLongitude(null);
					double latitude = this.GetPrimaryTarget().GetLatitude(null);
					GeoPoint geoPoint2;
					double longitude2 = (geoPoint2 = geoPoint).GetLongitude();
					GeoPoint geoPoint3;
					double latitude2 = (geoPoint3 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref longitude2, ref latitude2, (double)num2, (double)Math2.GetAzimuth(this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null)));
					geoPoint3.SetLatitude(latitude2);
					geoPoint2.SetLongitude(longitude2);
					this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), geoPoint.GetLatitude(), geoPoint.GetLongitude()));
					flag = true;
					result = true;
					return result;
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
				ex2.Data.Add("Error at 100781", "");
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

		// Token: 0x06006106 RID: 24838 RVA: 0x0002392B File Offset: 0x00021B2B
		[CompilerGenerated]
		private bool method_95(NoNavZone noNavZone_0)
		{
			return noNavZone_0.IsAffected(this.m_ActiveUnit);
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double GetAngularDistance(UnguidedWeapon unguidedWeapon_0)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(unguidedWeapon_0);
		}

		// Token: 0x0400342A RID: 13354
		public static Func<UnguidedWeapon, bool> UnguidedWeaponFunc0 = (UnguidedWeapon unguidedWeapon_0) => !Information.IsNothing(unguidedWeapon_0);

		// Token: 0x0400342B RID: 13355
		public static Func<UnguidedWeapon, bool> UnguidedWeaponFunc1 = (UnguidedWeapon unguidedWeapon_0) => !Information.IsNothing(unguidedWeapon_0);

		// Token: 0x0400342C RID: 13356
		public static Func<GeoPoint, short> UnguidedWeaponFunc2 = (GeoPoint geoPoint_0) => Terrain.GetElevation(geoPoint_0.GetLatitude(), geoPoint_0.GetLongitude(), false);

		// Token: 0x02000B71 RID: 2929
		[CompilerGenerated]
		public sealed class MineClearingMissionAI0
		{
			// Token: 0x0600610C RID: 24844 RVA: 0x0002AF96 File Offset: 0x00029196
			public MineClearingMissionAI0(Ship_AI.MineClearingMissionAI0 MineClearingMissionAI0_)
			{
				if (MineClearingMissionAI0_ != null)
				{
					this.MinesDictionary = MineClearingMissionAI0_.MinesDictionary;
					this.MineClearingArea = MineClearingMissionAI0_.MineClearingArea;
					this.MineBag = MineClearingMissionAI0_.MineBag;
				}
			}

			// Token: 0x0600610D RID: 24845 RVA: 0x002E604C File Offset: 0x002E424C
			internal void TryAddToMineBag(string WeaponGUID)
			{
				UnguidedWeapon unguidedWeapon = null;
				this.MinesDictionary.TryGetValue(WeaponGUID, ref unguidedWeapon);
				if (!Information.IsNothing(unguidedWeapon) && unguidedWeapon.IsMine() && unguidedWeapon.vmethod_40(this.MineClearingArea, this.ship_AI.m_ActiveUnit.m_Scenario, true))
				{
					this.MineBag.Add(unguidedWeapon);
				}
			}

			// Token: 0x04003430 RID: 13360
			public ObservableDictionary<string, UnguidedWeapon> MinesDictionary;

			// Token: 0x04003431 RID: 13361
			public List<ReferencePoint> MineClearingArea;

			// Token: 0x04003432 RID: 13362
			public ConcurrentBag<UnguidedWeapon> MineBag;

			// Token: 0x04003433 RID: 13363
			public Ship_AI ship_AI;
		}

		// Token: 0x02000B72 RID: 2930
		[CompilerGenerated]
		public sealed class MineClearingMissionAI
		{
			// Token: 0x0600610E RID: 24846 RVA: 0x0002AFC8 File Offset: 0x000291C8
			public MineClearingMissionAI(Ship_AI.MineClearingMissionAI MineClearingMissionAI_)
			{
				if (MineClearingMissionAI_ != null)
				{
					this.UnguidedWeapons = MineClearingMissionAI_.UnguidedWeapons;
					this.MineClearingArea = MineClearingMissionAI_.MineClearingArea;
					this.MineBag = MineClearingMissionAI_.MineBag;
				}
			}

			// Token: 0x0600610F RID: 24847 RVA: 0x002E60AC File Offset: 0x002E42AC
			internal void TryAddToMineBag(string weaponGUID_)
			{
				UnguidedWeapon unguidedWeapon = null;
				this.UnguidedWeapons.TryGetValue(weaponGUID_, ref unguidedWeapon);
				if (!Information.IsNothing(unguidedWeapon) && unguidedWeapon.IsMine() && unguidedWeapon.vmethod_40(this.MineClearingArea, this.ship_AI.m_ActiveUnit.m_Scenario, true))
				{
					this.MineBag.Add(unguidedWeapon);
				}
			}

			// Token: 0x04003434 RID: 13364
			public ObservableDictionary<string, UnguidedWeapon> UnguidedWeapons;

			// Token: 0x04003435 RID: 13365
			public List<ReferencePoint> MineClearingArea;

			// Token: 0x04003436 RID: 13366
			public ConcurrentBag<UnguidedWeapon> MineBag;

			// Token: 0x04003437 RID: 13367
			public Ship_AI ship_AI;
		}

		// Token: 0x02000B73 RID: 2931
		[CompilerGenerated]
		public sealed class DistanceMeasurer
		{
			// Token: 0x06006110 RID: 24848 RVA: 0x0002AFFA File Offset: 0x000291FA
			public DistanceMeasurer(Ship_AI.DistanceMeasurer DistanceMeasurer_)
			{
				if (DistanceMeasurer_ != null)
				{
					this.Location = DistanceMeasurer_.Location;
				}
			}

			// Token: 0x06006111 RID: 24849 RVA: 0x002E610C File Offset: 0x002E430C
			internal double GetAngularDistance(GeoPoint geoPoint_)
			{
				return Math2.ApproxAngularDistance(geoPoint_.GetLatitude(), geoPoint_.GetLongitude(), this.Location.GetLatitude(), this.Location.GetLongitude());
			}

			// Token: 0x04003438 RID: 13368
			public GeoPoint Location;

			// Token: 0x04003439 RID: 13369
			public Func<GeoPoint, double> MeasureFunc;
		}
	}
}

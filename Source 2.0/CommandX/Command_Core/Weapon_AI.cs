using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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
	// 武器的AI
	public class Weapon_AI : ActiveUnit_AI
	{
		// 取所在的武器
		protected Weapon GetParentWeapon()
		{
			if (Information.IsNothing(this.theWeapon))
			{
				this.theWeapon = (Weapon)this.m_ActiveUnit;
			}
			return this.theWeapon;
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x0024E22C File Offset: 0x0024C42C
		public static void smethod_1(XmlNode xmlNode_0, Dictionary<string, Subject> dictionary_1, Weapon weapon_1)
		{
			try
			{
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
						try
						{
							string name = xmlNode.Name;
							uint num = Class382.smethod_0(name);
							if (num <= 1641464439u)
							{
								if (num <= 467450941u)
								{
									if (num != 106934956u)
									{
										if (num != 402376870u)
										{
											if (num == 467450941u && Operators.CompareString(name, "PrimaryThreat", false) == 0)
											{
												weapon_1.GetWeaponAI().PrimaryThreat = Contact.GetContact(xmlNode.InnerText, ref dictionary_1);
											}
										}
										else if (Operators.CompareString(name, "SnakeAxis", false) == 0)
										{
											weapon_1.GetWeaponAI().SnakeAxis = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										}
									}
									else if (Operators.CompareString(name, "PrimaryTarget", false) == 0)
									{
										if (xmlNode.InnerText.Contains("Aimpoint"))
										{
											weapon_1.GetWeaponAI().SetPrimaryTarget(Aimpoint.GetAimpoint(xmlNode.InnerText));
										}
										else if (xmlNode.InnerText.Contains("ActivationPoint"))
										{
											weapon_1.GetWeaponAI().SetPrimaryTarget(ActivationPoint_BOL.GetActivationPoint_BOL(xmlNode.InnerText));
										}
										else
										{
											weapon_1.GetWeaponAI().SetPrimaryTarget(Contact.GetContact(xmlNode.InnerText, ref dictionary_1));
										}
									}
								}
								else
								{
									if (num <= 1103999922u)
									{
										if (num != 592141878u)
										{
											if (num != 1103999922u)
											{
												continue;
											}
											if (Operators.CompareString(name, "VirtualTargetVelocity", false) == 0)
											{
												weapon_1.GetWeaponAI().VirtualTargetVelocity = XmlConvert.ToSingle(xmlNode.InnerText);
												continue;
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
													Contact contact = Contact.Load(ref xmlNode2, ref dictionary_1);
													if (!Information.IsNothing(contact))
													{
														ScenarioArrayUtil.AddContact(ref weapon_1.GetWeaponAI().Threats, contact);
													}
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
										if (num == 1641464439u && Operators.CompareString(name, "VirtualTargetAltitude", false) == 0)
										{
											weapon_1.GetWeaponAI().VirtualTargetAltitude = XmlConvert.ToSingle(xmlNode.InnerText);
										}
									}
									else if (Operators.CompareString(name, "IE", false) == 0)
									{
										weapon_1.GetWeaponAI().IsEscort = true;
									}
								}
							}
							else if (num <= 2276842832u)
							{
								if (num != 1966596370u)
								{
									if (num != 2133975202u)
									{
										if (num != 2276842832u)
										{
											continue;
										}
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
												if (!Information.IsNothing(targetingEntry.Target))
												{
													weapon_1.GetWeaponAI().GetTargetList().Add(targetingEntry.Target.GetGuid(), targetingEntry);
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
										weapon_1.GetWeaponAI().SetPrimaryTarget_LastKnown_Lat(XmlConvert.ToDouble(xmlNode.InnerText));
									}
								}
								else if (Operators.CompareString(name, "PrimaryTarget_LastKnown_Lon", false) == 0)
								{
									weapon_1.GetWeaponAI().SetPrimaryTarget_LastKnown_Lon(XmlConvert.ToDouble(xmlNode.InnerText));
								}
							}
							else if (num <= 3761246852u)
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
								weapon_1.GetWeaponAI().bPrimaryTargetOverride = Conversions.ToBoolean(xmlNode.InnerText);
							}
							else if (num != 4025372673u)
							{
								if (num == 4076649232u && Operators.CompareString(name, "PrimaryTarget_LastKnown_Alt", false) == 0)
								{
									weapon_1.GetWeaponAI().SetPrimaryTarget_LastKnown_Alt(XmlConvert.ToSingle(xmlNode.InnerText));
								}
							}
							else if (Operators.CompareString(name, "PrimaryTarget_Type", false) == 0)
							{
								if (Versioned.IsNumeric(xmlNode.InnerText))
								{
									weapon_1.GetWeaponAI().PrimaryTargetType = (Contact_Base.ContactType)Conversions.ToByte(xmlNode.InnerText);
								}
								else
								{
									weapon_1.GetWeaponAI().PrimaryTargetType = (Contact_Base.ContactType)Enum.Parse(typeof(Contact_Base.ContactType), xmlNode.InnerText, true);
								}
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200049", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
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
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100964", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x0024E8A4 File Offset: 0x0024CAA4
		public void method_89(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			try
			{
				if (!Information.IsNothing(this.GetPrimaryTarget()))
				{
					xmlWriter_0.WriteElementString("PrimaryTarget", this.GetPrimaryTarget().GetGuid());
				}
				if (!Information.IsNothing(this.PrimaryTargetType))
				{
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "PrimaryTarget_Type";
					int primaryTargetType = (int)this.PrimaryTargetType;
					xmlWriter.WriteElementString(localName, primaryTargetType.ToString());
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
				if (this.VirtualTargetAltitude != 0f)
				{
					xmlWriter_0.WriteElementString("VirtualTargetAltitude", XmlConvert.ToString(this.VirtualTargetAltitude));
				}
				if (this.VirtualTargetVelocity != 0f)
				{
					xmlWriter_0.WriteElementString("VirtualTargetVelocity", XmlConvert.ToString(this.VirtualTargetVelocity));
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
				if (this.HoldPosition)
				{
					xmlWriter_0.WriteElementString("HPos", this.HoldPosition.ToString());
				}
				if (this.FerryCycleLegIsOutbound)
				{
					xmlWriter_0.WriteElementString("FCLIO", this.FerryCycleLegIsOutbound.ToString());
				}
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
				if (this.HoldPosition)
				{
					xmlWriter_0.WriteElementString("HP", this.HoldPosition.ToString());
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
				ex2.Data.Add("Error at 100021", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x0002781F File Offset: 0x00025A1F
		public Weapon_AI(Weapon weapon_1) : base(weapon_1)
		{
		}

		// 目标
		public override void TargetingContacts(float float_3, bool bool_7, bool bool_8)
		{
		}

		// 威胁评估
		public override void ThreatAssessment()
		{
		}

		// 取首要目标
		public override Contact GetPrimaryTarget()
		{
			return this.PrimaryTarget;
		}

		// 设置首要目标
		public override void SetPrimaryTarget(Contact target)
		{
			try
			{
				if (target != this.PrimaryTarget)
				{
					if (!Information.IsNothing(this.PrimaryTarget) && Information.IsNothing(target))
					{
						this.LastKnownTargetLocation = new GeoPoint(this.PrimaryTarget.GetLongitude(null), this.PrimaryTarget.GetLatitude(null), this.PrimaryTarget.GetCurrentAltitude_ASL(false));
					}
					if (Information.IsNothing(target) && !Information.IsNothing(this.PrimaryTarget) && this.PrimaryTarget.IsAirSpace() && this.PrimaryTarget.Altitude_Known)
					{
						this.m_ActiveUnit.SetDesiredAltitude(this.PrimaryTarget.GetCurrentAltitude_ASL(false));
					}
				}
				if (Information.IsNothing(target) && !Information.IsNothing(this.PrimaryTarget) && this.PrimaryTarget.IsFacilityType() && !this.GetParentWeapon().weaponTarget.IsRadar && this.GetParentWeapon().GetCommDevices().Count<CommDevice>() == 0)
				{
					this.GetParentWeapon().method_219(true);
				}
				else if (Information.IsNothing(target) && !Information.IsNothing(this.PrimaryTarget) && this.PrimaryTarget.IsSurface() && !this.GetParentWeapon().weaponTarget.IsRadar && this.GetParentWeapon().GetCommDevices().Count<CommDevice>() == 0)
				{
					if (this.GetParentWeapon().GetGuidanceMethod() == Weapon._GuidanceMethod.SemiActive)
					{
						this.GetParentWeapon().method_219(true);
					}
					else
					{
						this.PrimaryTarget = target;
					}
				}
				else
				{
					this.PrimaryTarget = target;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100965", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005646 RID: 22086 RVA: 0x0024EEB0 File Offset: 0x0024D0B0
		public void method_90()
		{
			if (this.GetParentWeapon().weaponCode.BallisticMissile && this.GetParentWeapon().weaponCode.Warhead_MultipleIndependentReEntryVehicles && this.GetParentWeapon().m_Warheads.Length >= 2 && !Information.IsNothing(this.GetPrimaryTarget()) && !Information.IsNothing(this.GetPrimaryTarget().ActualUnit))
			{
				try
				{
					Weapon_AI.Class224 @class = new Weapon_AI.Class224(null);
					@class.weapon_AI_0 = this;
					int arg_75_0 = this.GetParentWeapon().m_Warheads.Length;
					List<Contact> list = new List<Contact>();
					List<Contact> source = new List<Contact>();
					@class.list_0 = new List<Contact>();
					@class.list_1 = new List<Contact>();
					List<Contact> collection = new List<Contact>();
					source = this.GetParentWeapon().GetSide(false).GetContactList().Where(new Func<Contact, bool>(this.method_98)).ToList<Contact>();
					@class.list_0 = source.Where(new Func<Contact, bool>(this.method_99)).OrderBy(new Func<Contact, double>(this.method_100)).ToList<Contact>();
					@class.list_1 = source.Where(new Func<Contact, bool>(this.method_101)).OrderBy(new Func<Contact, double>(this.method_102)).ToList<Contact>();
					collection = source.Where(new Func<Contact, bool>(@class.method_0)).OrderBy(new Func<Contact, double>(this.method_103)).ToList<Contact>();
					list.AddRange(@class.list_0);
					list.AddRange(@class.list_1);
					list.AddRange(collection);
					if (list.Count > 0)
					{
						int num = this.GetParentWeapon().m_Warheads.Length - 1;
						for (int num2 = 1; num2 <= num; num2++)
						{
							try
							{
								if (num2 > list.Count)
								{
									this.TargetingContact(@class.list_0[GameGeneral.GetRandom().Next(0, @class.list_0.Count)], false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
								}
								else
								{
									this.TargetingContact(list[num2 - 1], false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
								}
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ex2.Data.Add("Error at 200050", ex2.Message);
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
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 100966", "");
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x0024F170 File Offset: 0x0024D370
		public override void ScheduleNextPrimaryTargetEvent(short short_1, bool bool_7)
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && (this.GetParentWeapon().GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided || (!this.m_ActiveUnit.IsTorpedo() && !this.GetParentWeapon().IsRVorHGV())))
			{
				try
				{
					this.TimeToNextPrimaryTargetEvent -= short_1;
					if (this.TimeToNextPrimaryTargetEvent <= 0)
					{
						this.TimeToNextPrimaryTargetEvent = (short)GameGeneral.GetRandom().Next(10, 21);
						if (!Information.IsNothing(this.GetPrimaryTarget()))
						{
							base.SetPrimaryTarget_LastKnown_Lat(this.GetPrimaryTarget().GetLatitude(null));
							base.SetPrimaryTarget_LastKnown_Lon(this.GetPrimaryTarget().GetLongitude(null));
							base.SetPrimaryTarget_LastKnown_Alt(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
						}
						if (base.GetTargets().Length != 0)
						{
							List<Contact> list = new List<Contact>();
							list.AddRange(base.GetTargets());
							if (this.GetParentWeapon().method_187())
							{
								if (!this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
								{
									if (!Information.IsNothing(this.GetPrimaryTarget()))
									{
										if (this.GetParentWeapon().weaponTarget.IsRadar)
										{
											this.SetPrimaryTarget(null);
										}
										else
										{
											foreach (Contact current in list)
											{
												if (current.ActualUnit == this.GetPrimaryTarget().ActualUnit)
												{
													this.SetPrimaryTarget(current);
													return;
												}
											}
										}
										if (!this.GetParentWeapon().HasDatalinkParentForGuidance() && !this.GetParentWeapon().HasSensorWithCodeOfClassification_BrilliantWeapon() && (Information.IsNothing(this.GetPrimaryTarget()) || !this.GetPrimaryTarget().ActualUnit.IsFixedFacility()))
										{
											IEnumerable<Contact> source = list.OrderBy(new Func<Contact, double>(this.method_104));
											this.SetPrimaryTarget(source.ElementAtOrDefault(0));
										}
										if (this.GetParentWeapon().weaponTarget.IsRadar && Information.IsNothing(this.GetParentWeapon().ARM_SpecifiedEmission))
										{
											Weapon parentWeapon = this.GetParentWeapon();
											ObservableDictionary<int, EmissionContainer> emissionContainerObDictionary = this.GetPrimaryTarget().GetEmissionContainerObDictionary();
											Side side = this.m_ActiveUnit.GetSide(false);
											Contact primaryTarget = this.GetPrimaryTarget();
											Random random = GameGeneral.GetRandom();
											parentWeapon.HasARM_SpecifiedEmission(emissionContainerObDictionary, side, primaryTarget, false, ref random);
										}
									}
									else
									{
										IEnumerable<Contact> source2 = list.Select(Weapon_AI.ContactFunc).OrderBy(new Func<Contact, double>(this.method_105));
										if (source2.Count<Contact>() > 0)
										{
											this.SetPrimaryTarget(source2.ElementAtOrDefault(0));
										}
									}
								}
							}
							else
							{
								Weapon._GuidanceMethod guidanceMethod = this.GetParentWeapon().GetGuidanceMethod();
								if (guidanceMethod != Weapon._GuidanceMethod.PassiveTerminalGuidance)
								{
									if (guidanceMethod != Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance)
									{
										if (guidanceMethod == Weapon._GuidanceMethod.TimeSharedSemiActiveMidCoursePlusActiveTerminalGuidance && Information.IsNothing(this.GetParentWeapon().GetDataLinkParent()) && list.Count > 0)
										{
											if (list.Count == 1)
											{
												this.SetPrimaryTarget(list[0]);
											}
											else
											{
												if (!Information.IsNothing(this.GetPrimaryTarget()))
												{
													foreach (Contact current2 in list)
													{
														if (!Information.IsNothing(current2) && !Information.IsNothing(current2.ActualUnit) && !Information.IsNothing(this.GetPrimaryTarget()) && !Information.IsNothing(this.GetPrimaryTarget().ActualUnit) && Operators.CompareString(current2.ActualUnit.GetGuid(), this.GetPrimaryTarget().ActualUnit.GetGuid(), false) == 0)
														{
															return;
														}
													}
												}
												IEnumerable<Contact> source3 = list.OrderBy(new Func<Contact, float>(this.method_106));
												this.SetPrimaryTarget(source3.ElementAtOrDefault(0));
											}
										}
									}
									else if (this.m_ActiveUnit.GetNoneMCMSensors()[0].IsEmmitting() && list.Count > 0)
									{
										if (base.GetTargets().Length == 1)
										{
											this.SetPrimaryTarget(list[0]);
										}
										else
										{
											if (!Information.IsNothing(this.GetPrimaryTarget()))
											{
												foreach (Contact current3 in list)
												{
													if (!Information.IsNothing(current3) && !Information.IsNothing(current3.ActualUnit) && !Information.IsNothing(this.GetPrimaryTarget()) && !Information.IsNothing(this.GetPrimaryTarget().ActualUnit) && Operators.CompareString(current3.ActualUnit.GetGuid(), this.GetPrimaryTarget().ActualUnit.GetGuid(), false) == 0)
													{
														return;
													}
												}
											}
											IEnumerable<Contact> source4 = list.OrderBy(new Func<Contact, float>(this.method_107));
											this.SetPrimaryTarget(source4.ElementAtOrDefault(0));
										}
									}
								}
								else if ((Information.IsNothing(this.GetPrimaryTarget()) || (this.GetParentWeapon().weaponTarget.IsRadar && !list.Contains(this.GetPrimaryTarget()))) && (this.GetParentWeapon().WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon() || this.GetParentWeapon().weaponTarget.IsSurfaceShip || this.GetParentWeapon().weaponTarget.IsRadar))
								{
									if (this.GetParentWeapon().weaponTarget.IsRadar && !Information.IsNothing(this.GetParentWeapon().ARM_SpecifiedEmission))
									{
										list = list.Where(new Func<Contact, bool>(this.method_108)).ToList<Contact>();
									}
									if (list.Count > 0)
									{
										if (list.Count == 1)
										{
											this.SetPrimaryTarget(list[0]);
										}
										else
										{
											IEnumerable<Contact> source5 = list.OrderBy(new Func<Contact, float>(this.method_109));
											this.SetPrimaryTarget(source5.ElementAtOrDefault(0));
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
					ex2.Data.Add("Error at 100967", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005648 RID: 22088 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void UpdateMissionStatus(float float_3)
		{
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x0024F818 File Offset: 0x0024DA18
		protected void method_91()
		{
			try
			{
				if (this.GetParentWeapon().IsTorpedo())
				{
					this.int_0 = 15;
				}
				else
				{
					this.int_0 = 8;
				}
				if (Information.IsNothing(this.SnakeAxis))
				{
					if (!Information.IsNothing(this.GetPrimaryTarget()))
					{
						this.SnakeAxis = new float?(Math2.GetAzimuth(this.GetParentWeapon().GetLatitude(null), this.GetParentWeapon().GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null)));
					}
					else
					{
						this.SnakeAxis = new float?(this.m_ActiveUnit.GetCurrentHeading());
					}
				}
				if (Information.IsNothing(this.nullable_5))
				{
					this.nullable_5 = new Weapon_AI.Enum92?((Weapon_AI.Enum92)GameGeneral.GetRandom().Next(0, 1));
				}
				float value = Math2.Normalize(this.SnakeAxis.Value - (float)this.int_0);
				float value2 = Math2.Normalize(this.SnakeAxis.Value + (float)this.int_0);
				Weapon_AI.Enum92? @enum = this.nullable_5;
				byte? b = @enum.HasValue ? new byte?((byte)@enum.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					if (Math.Abs(Class263.RelativeBearingTo(this.m_ActiveUnit.GetCurrentHeading(), this.SnakeAxis.Value)) >= (float)this.int_0)
					{
						this.nullable_5 = new Weapon_AI.Enum92?(Weapon_AI.Enum92.const_1);
						this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, value2);
					}
					else
					{
						this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, value);
					}
				}
				else
				{
					b = (@enum.HasValue ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						if (Math.Abs(Class263.RelativeBearingTo(this.m_ActiveUnit.GetCurrentHeading(), this.SnakeAxis.Value)) >= (float)this.int_0)
						{
							this.nullable_5 = new Weapon_AI.Enum92?(Weapon_AI.Enum92.const_0);
							this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, value);
						}
						else
						{
							this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, value2);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100968", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void PickPrimaryThreat()
		{
		}

        // Token: 0x0600564B RID: 22091 RVA: 0x0024FAFC File Offset: 0x0024DCFC
        public override void vmethod_18(float float_3)
		{
			if (!Information.IsNothing(this.GetPrimaryTarget()))
			{
				try
				{
					this.m_ActiveUnit.GetCurrentHeading();
					float azimuth = Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null));
					if (this.m_ActiveUnit.GetCurrentHeading() != azimuth)
					{
						float angleBetween = Class263.GetAngleBetween(this.m_ActiveUnit.GetCurrentHeading(), Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null)));
						if (315f > angleBetween && angleBetween > 45f && this.m_ActiveUnit.GetCurrentSpeed() > this.GetPrimaryTarget().GetCurrentSpeed())
						{
							base.method_52(0f, 0f);
						}
						else
						{
							Weapon._GuidanceMethod guidanceMethod = this.GetParentWeapon().GetGuidanceMethod();
							if (guidanceMethod == Weapon._GuidanceMethod.BeamRiding)
							{
								base.method_52(0f, 0f);
							}
							else
							{
								base.method_53(new float?(this.m_ActiveUnit.GetDesiredSpeed()));
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100969", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void UpdateUnitStatus(float float_3, bool bool_7, bool bool_8)
		{
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x0024FCD4 File Offset: 0x0024DED4
		private void method_92(float float_3)
		{
			try
			{
				Weapon parentWeapon = this.GetParentWeapon();
				if (!base.method_59(ref parentWeapon))
				{
					if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
					{
						this.m_ActiveUnit.GetNavigator().vmethod_7(float_3);
						this.vmethod_28(float_3);
					}
					else
					{
						if (!Information.IsNothing(this.GetPrimaryTarget()))
						{
							if (!Information.IsNothing(this.GetPrimaryTarget().ActualUnit))
							{
								if (!this.GetParentWeapon().bPrimaryTargetAttackable)
								{
									this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, base.GetHeadingToPredicatedTargetLocation(this.GetPrimaryTarget().ActualUnit));
								}
								else
								{
									this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.GetCurrentHeading());
								}
							}
							else
							{
								this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, base.GetAzimuth(this.GetPrimaryTarget()));
							}
						}
						else
						{
							this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.GetCurrentHeading());
						}
						this.vmethod_28(float_3);
					}
				}
				else
				{
					this.vmethod_28(float_3);
					if (!Information.IsNothing(this.GetPrimaryTarget()) && this.GetPrimaryTarget().contactType != Contact_Base.ContactType.Aimpoint && this.GetPrimaryTarget().contactType != Contact_Base.ContactType.ActivationPoint)
					{
						base.SetPrimaryTarget_LastKnown_Lat(this.GetPrimaryTarget().GetLatitude(null));
						base.SetPrimaryTarget_LastKnown_Lon(this.GetPrimaryTarget().GetLongitude(null));
					}
					if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint() && !Information.IsNothing(this.GetParentWeapon().GetDataLinkParent()))
					{
						if (!this.GetPrimaryTarget().IsFixedFacility())
						{
							Weapon._GuidanceMethod guidanceMethod = this.GetParentWeapon().GetGuidanceMethod();
							if (guidanceMethod <= Weapon._GuidanceMethod.const_5)
							{
								if (guidanceMethod != Weapon._GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance && guidanceMethod != Weapon._GuidanceMethod.const_5)
								{
									goto IL_22B;
								}
							}
							else if (guidanceMethod != Weapon._GuidanceMethod.const_7 && guidanceMethod != Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance)
							{
								goto IL_22B;
							}
							((Weapon_Navigator)this.m_ActiveUnit.GetNavigator()).method_57((float)this.m_ActiveUnit.GetKinematics().GetSpeed(this.m_ActiveUnit.GetCurrentAltitude_ASL(false), this.m_ActiveUnit.GetMaxThrottleAvailable()), !Information.IsNothing(this.GetParentWeapon().GetDataLinkParent()) && this.GetParentWeapon().GetDataLinkParent().IsAircraft && this.GetParentWeapon().IsTorpedo());
						}
						IL_22B:
						this.m_ActiveUnit.GetNavigator().vmethod_7(float_3);
					}
					else if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
					{
						this.m_ActiveUnit.GetNavigator().vmethod_7(float_3);
					}
					else
					{
						if (!Information.IsNothing(this.GetPrimaryTarget()) && this.GetPrimaryTarget().contactType == Contact_Base.ContactType.ActivationPoint)
						{
							return;
						}
						if (this.GetParentWeapon().GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided)
						{
							this.vmethod_18(float_3);
						}
					}
					if (!Information.IsNothing(this.GetPrimaryTarget()))
					{
						Contact_Base.ContactType contactType = this.GetPrimaryTarget().contactType;
						if (contactType <= Contact_Base.ContactType.Missile || contactType == Contact_Base.ContactType.Orbital || contactType == Contact_Base.ContactType.Decoy_Air)
						{
							float num = Math.Abs(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) - this.m_ActiveUnit.GetCurrentAltitude_ASL(false));
							float num2 = Conversions.ToSingle(Interaction.IIf(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) >= this.m_ActiveUnit.GetCurrentAltitude_ASL(false), this.m_ActiveUnit.GetKinematics().GetClimbRate(), this.m_ActiveUnit.GetKinematics().vmethod_19()));
							float num3 = num / num2;
							float desiredSpeed = this.m_ActiveUnit.GetDesiredSpeed(this.GetPrimaryTarget(), this.m_ActiveUnit.GetCurrentSpeed(), this.m_ActiveUnit.AzimuthTo(this.GetPrimaryTarget()));
							float num4 = (float)((long)Math.Round((double)(this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget()) / desiredSpeed * 3600f)));
							if (num4 < num3)
							{
								float climbRate = num / num4;
								this.GetParentWeapon().GetWeaponKinematics().SetClimbRate(climbRate);
							}
						}
					}
				}
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
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x002500EC File Offset: 0x0024E2EC
		public override void Navigate(float elapsedTime_)
		{
			try
			{
				if (this.GetParentWeapon().GetWeaponType() != Weapon._WeaponType.Sonobuoy && this.GetParentWeapon().GetBlindTime() <= 0f)
				{
					if (this.GetParentWeapon().weaponCode.BallisticMissile)
					{
						this.method_92(elapsedTime_);
					}
					else
					{
						Weapon parentWeapon = this.GetParentWeapon();
						if (!base.method_59(ref parentWeapon))
						{
							if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
							{
								this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
								this.vmethod_28(elapsedTime_);
							}
							else if (!this.m_ActiveUnit.IsTorpedo() || this.GetParentWeapon().GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided)
							{
								if (this.GetParentWeapon().weaponCode.SearchPattern)
								{
									if (!Information.IsNothing(this.GetPrimaryTarget()) && !Information.IsNothing(this.GetPrimaryTarget().ActualUnit) && !this.GetPrimaryTarget().ActualUnit.IsFixedFacility())
									{
										if (this.GetParentWeapon().searchPatternType == Weapon._SearchPatternType.const_2)
										{
											this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.Normalize(this.m_ActiveUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0) + 10f * elapsedTime_));
											if (this.m_ActiveUnit.GetKinematics().method_9())
											{
												this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Loiter, null);
											}
											else
											{
												this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
											}
										}
										else if (this.GetParentWeapon().searchPatternType == Weapon._SearchPatternType.const_1)
										{
											this.method_91();
										}
										else
										{
											this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.GetCurrentHeading());
										}
									}
									else if (this.GetParentWeapon().IsTorpedo() && !this.GetParentWeapon().GetWeaponNavigator().HasPlottedCourse() && this.GetParentWeapon().weaponCode.SearchPattern && this.GetParentWeapon().searchPatternType == Weapon._SearchPatternType.const_2)
									{
										this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, Math2.Normalize(this.m_ActiveUnit.GetDesiredHeading(ActiveUnit._TurnRate.const_0) + 10f * elapsedTime_));
										if (this.m_ActiveUnit.GetKinematics().method_9())
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Loiter, null);
										}
										else
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
										}
									}
									else if (!Information.IsNothing(this.GetPrimaryTarget()) && this.GetPrimaryTarget().ActualUnit.IsFixedFacility())
									{
										this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, base.GetAzimuth(this.GetPrimaryTarget()));
									}
									else
									{
										this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.GetCurrentHeading());
									}
								}
								else if (!Information.IsNothing(this.GetPrimaryTarget()))
								{
									if (!Information.IsNothing(this.GetPrimaryTarget().ActualUnit))
									{
										if (!this.GetParentWeapon().bPrimaryTargetAttackable)
										{
											this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, base.GetHeadingToPredicatedTargetLocation(this.GetPrimaryTarget().ActualUnit));
										}
										else
										{
											this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.GetCurrentHeading());
										}
									}
									else
									{
										this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, base.GetAzimuth(this.GetPrimaryTarget()));
									}
								}
								else
								{
									this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.GetCurrentHeading());
								}
								this.vmethod_28(elapsedTime_);
							}
						}
						else
						{
							this.vmethod_28(elapsedTime_);
							if (!Information.IsNothing(this.GetPrimaryTarget()) && this.GetPrimaryTarget().contactType != Contact_Base.ContactType.Aimpoint && this.GetPrimaryTarget().contactType != Contact_Base.ContactType.ActivationPoint)
							{
								base.SetPrimaryTarget_LastKnown_Lat(this.GetPrimaryTarget().GetLatitude(null));
								base.SetPrimaryTarget_LastKnown_Lon(this.GetPrimaryTarget().GetLongitude(null));
								base.SetPrimaryTarget_LastKnown_Alt(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
							}
							if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint() && !Information.IsNothing(this.GetParentWeapon().GetDataLinkParent()))
							{
								if (!this.GetPrimaryTarget().IsFixedFacility())
								{
									Weapon._GuidanceMethod guidanceMethod = this.GetParentWeapon().GetGuidanceMethod();
									if (guidanceMethod <= Weapon._GuidanceMethod.const_5)
									{
										if (guidanceMethod != Weapon._GuidanceMethod.DatalinkMidCoursePlusSemiActiveTerminalGuidance && guidanceMethod != Weapon._GuidanceMethod.const_5)
										{
											goto IL_4CD;
										}
									}
									else if (guidanceMethod != Weapon._GuidanceMethod.const_7 && guidanceMethod != Weapon._GuidanceMethod.SemiActiveMidCoursePlusActiveTerminalGuidance)
									{
										goto IL_4CD;
									}
									((Weapon_Navigator)this.m_ActiveUnit.GetNavigator()).method_57((float)this.m_ActiveUnit.GetKinematics().GetSpeed(this.m_ActiveUnit.GetCurrentAltitude_ASL(false), this.m_ActiveUnit.GetMaxThrottleAvailable()), !Information.IsNothing(this.GetParentWeapon().GetDataLinkParent()) && this.GetParentWeapon().GetDataLinkParent().IsAircraft && this.GetParentWeapon().IsTorpedo());
								}
								IL_4CD:
								this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
							}
							else if (this.m_ActiveUnit.GetNavigator().HasPlottedCourse())
							{
								this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
							}
							else
							{
								if (!Information.IsNothing(this.GetPrimaryTarget()) && this.GetPrimaryTarget().contactType == Contact_Base.ContactType.ActivationPoint)
								{
									return;
								}
								if (this.GetParentWeapon().GetGuidanceMethod() != Weapon._GuidanceMethod.InertiallyGuided)
								{
									this.vmethod_18(elapsedTime_);
								}
								else if (!Information.IsNothing(this.GetPrimaryTarget()))
								{
									this.GetParentWeapon().GetWeaponNavigator().AddWaypoint(new Waypoint(this.GetPrimaryTarget().GetLongitude(null), this.GetPrimaryTarget().GetLatitude(null), Waypoint.WaypointType.WeaponTerminalPoint, Waypoint._Creator.const_1, Waypoint._Category.const_0));
								}
							}
							if (this.GetParentWeapon().GetCurrentAltitude_ASL(false) != this.GetParentWeapon().GetCruiseAltitude_ASL() && !Information.IsNothing(this.GetPrimaryTarget()))
							{
								Contact_Base.ContactType contactType = this.GetPrimaryTarget().contactType;
								if (contactType <= Contact_Base.ContactType.Missile || contactType == Contact_Base.ContactType.Orbital || contactType == Contact_Base.ContactType.Decoy_Air)
								{
									float num = Math.Abs(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) - this.m_ActiveUnit.GetCurrentAltitude_ASL(false));
									float num2 = Conversions.ToSingle(Interaction.IIf(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) >= this.m_ActiveUnit.GetCurrentAltitude_ASL(false), this.m_ActiveUnit.GetKinematics().GetClimbRate(), this.m_ActiveUnit.GetKinematics().vmethod_19()));
									float num3 = num / num2;
									float desiredSpeed = this.m_ActiveUnit.GetDesiredSpeed(this.GetPrimaryTarget(), this.m_ActiveUnit.GetCurrentSpeed(), this.m_ActiveUnit.AzimuthTo(this.GetPrimaryTarget()));
									float num4 = (float)((long)Math.Round((double)(this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget()) / desiredSpeed * 3600f)));
									if (num4 < num3)
									{
										float climbRate = num / num4;
										this.GetParentWeapon().GetWeaponKinematics().SetClimbRate(climbRate);
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
				ex2.Data.Add("Error at 100970", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x0025083C File Offset: 0x0024EA3C
		private void method_93(GeoPoint geoPoint_2, float float_3)
		{
			if (this.GetParentWeapon().IsOfAirLaunchedGuidedWeapon())
			{
				if (Information.IsNothing(geoPoint_2))
				{
					float num = Math.Abs(this.GetParentWeapon().GetDesiredAltitude() - this.GetParentWeapon().GetCurrentAltitude_ASL(false));
					if (this.m_ActiveUnit.GetDesiredAltitude() > this.m_ActiveUnit.GetCurrentAltitude_ASL(false))
					{
						if (num < 2000f)
						{
							this.m_ActiveUnit.vmethod_20(num / 2000f * 60f);
						}
						else
						{
							this.m_ActiveUnit.vmethod_20(60f);
						}
					}
					else if (num < 2000f)
					{
						this.m_ActiveUnit.vmethod_20(num / 2000f * -80f);
					}
					else
					{
						this.m_ActiveUnit.vmethod_20(-80f);
					}
				}
				else
				{
					this.method_94(geoPoint_2.GetLatitude(), geoPoint_2.GetLongitude(), float_3);
				}
			}
		}

		// Token: 0x06005650 RID: 22096 RVA: 0x0025092C File Offset: 0x0024EB2C
		private void method_94(double double_4, double double_5, float float_3)
		{
			if (this.GetParentWeapon().IsOfAirLaunchedGuidedWeapon())
			{
				if (this.VirtualTargetAltitude == 0f)
				{
					this.VirtualTargetAltitude = this.GetParentWeapon().GetCurrentAltitude_ASL(false);
					this.VirtualTargetVelocity = 0f;
				}
				this.VirtualTargetVelocity += -9.81f * float_3;
				this.VirtualTargetAltitude += this.VirtualTargetVelocity * float_3;
				if (this.VirtualTargetAltitude < this.GetParentWeapon().GetDesiredAltitude())
				{
					this.VirtualTargetAltitude = this.GetParentWeapon().GetDesiredAltitude();
					this.VirtualTargetVelocity = 0f;
				}
				float num = Math.Abs(this.VirtualTargetAltitude - this.GetParentWeapon().GetCurrentAltitude_ASL(false));
				if (this.bool_6 || this.GetParentWeapon().WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
				{
					num = Math.Abs(this.GetParentWeapon().GetDesiredAltitude() - this.GetParentWeapon().GetCurrentAltitude_ASL(false));
				}
				double x = (double)(this.m_ActiveUnit.HorizontalRangeTo(double_4, double_5) * 1852f);
				double num2 = Math.Atan2((double)num, x) * 57.2957795130823;
				if (this.m_ActiveUnit.GetDesiredAltitude() > this.m_ActiveUnit.GetCurrentAltitude_ASL(false))
				{
					this.m_ActiveUnit.vmethod_20((float)num2);
				}
				else
				{
					this.m_ActiveUnit.vmethod_20(-(float)num2);
				}
			}
		}

		// Token: 0x06005651 RID: 22097 RVA: 0x00250A90 File Offset: 0x0024EC90
		private void method_95(float float_3)
		{
			float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
			float num = this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) + (float)this.GetParentWeapon().method_188(this.m_ActiveUnit.GetAI().GetPrimaryTarget().ActualUnit) - this.m_ActiveUnit.GetCurrentAltitude_ASL(false);
			bool arg_7E_0;
			if (this.GetPrimaryTarget().contactType != Contact_Base.ContactType.Air)
			{
				if (this.GetPrimaryTarget().contactType != Contact_Base.ContactType.Missile)
				{
					arg_7E_0 = true;
					goto IL_7E;
				}
			}
			arg_7E_0 = this.GetParentWeapon().weaponCode.IlluminateAtLaunch;
			IL_7E:
			if (!arg_7E_0)
			{
				this.m_ActiveUnit.SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
				this.method_94(this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), float_3);
			}
			else if (this.GetParentWeapon().WeaponIsNotDecoyAndTargetIsAircraftOrGuideWeapon())
			{
				float num2 = this.m_ActiveUnit.GetCurrentSpeed() * float_3 / 3600f;
				if ((this.GetPrimaryTarget().IsSubmarine || this.GetPrimaryTarget().IsFixed()) && this.GetParentWeapon().LaunchPoint.GetHeightAboveElevation() <= 50f && Math.Abs(num) < horizontalRange / 4f * 1852f)
				{
					if (!this.bool_6)
					{
						this.m_ActiveUnit.SetDesiredAltitude(this.GetParentWeapon().GetWeaponKinematics().GetMaxAltitude());
						this.method_93(null, float_3);
					}
				}
				else if (this.GetParentWeapon().IsOfAirLaunchedGuidedWeapon())
				{
					this.GetParentWeapon().SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
					this.method_94(this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), float_3);
				}
				else if (num < 0f)
				{
					this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false) - num2 * Math.Abs(num) / horizontalRange);
				}
				else
				{
					this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false) + num2 * Math.Abs(num) / horizontalRange);
				}
			}
			else if (this.GetParentWeapon().IsOfAirLaunchedGuidedWeapon())
			{
				this.GetParentWeapon().SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
				this.method_94(this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), float_3);
			}
			else
			{
				float num3 = horizontalRange / this.m_ActiveUnit.GetCurrentSpeed() * 3600f;
				float num4 = Math.Abs(this.m_ActiveUnit.GetCurrentAltitude_ASL(false) - this.GetPrimaryTarget().GetCurrentAltitude_ASL(false)) / num3;
				if (num < 0f)
				{
					this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false) - num4 * float_3);
					if (this.GetParentWeapon().IsGuidedWeapon())
					{
						this.GetParentWeapon().GetWeaponKinematics().SetClimbRate(num4);
					}
				}
				else
				{
					this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false) + num4);
					if (this.GetParentWeapon().IsGuidedWeapon())
					{
						this.GetParentWeapon().GetWeaponKinematics().SetClimbRate(num4);
					}
				}
			}
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x00250DE4 File Offset: 0x0024EFE4
		public  virtual  void vmethod_28(float float_3)
		{
			try
			{
				if ((this.GetParentWeapon().weaponCode.BallisticMissile || this.GetParentWeapon().IsRVorHGV()) && this.GetParentWeapon().method_204())
				{
					if (this.GetParentWeapon().GetWeaponNavigator().HasPlottedCourse())
					{
						this.GetParentWeapon().SetDesiredAltitude(this.GetParentWeapon().GetWeaponNavigator().GetPlottedCourse().First<Waypoint>().GetAltitude());
					}
					else
					{
						this.GetParentWeapon().SetDesiredAltitude(0f);
					}
				}
				if (this.GetParentWeapon().weaponCode.BallisticMissile && this.GetParentWeapon().method_258())
				{
					this.GetParentWeapon().SetDesiredAltitude(this.GetParentWeapon().GetCruiseAltitude_ASL());
				}
				if (this.GetParentWeapon().IsTorpedo())
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					((Torpedo_AI)this.GetParentWeapon().GetWeaponAI()).vmethod_28(float_3);
				}
				else if (this.GetParentWeapon().CruiseAltitude != 0f && this.GetParentWeapon().GetCurrentAltitude_ASL(false) <= this.GetParentWeapon().GetWeaponKinematics().GetClimbRate())
				{
					if ((this.GetParentWeapon().weaponCode.BallisticMissile || this.GetParentWeapon().IsRVorHGV()) && this.GetParentWeapon().method_204())
					{
						this.GetParentWeapon().SetDesiredAltitude(0f);
					}
					else
					{
						this.m_ActiveUnit.SetDesiredAltitude(this.GetParentWeapon().CruiseAltitude);
					}
					this.method_93(null, float_3);
					return;
				}
				if (this.GetParentWeapon().CruiseAltitude != 0f && this.GetParentWeapon().GetCurrentAltitude_ASL(false) < 8850f)
				{
					int terrainElevation = this.m_ActiveUnit.GetTerrainElevation(false, false, false);
					if (terrainElevation > 0 && this.GetParentWeapon().GetCurrentAltitude_ASL(false) - (float)terrainElevation <= this.GetParentWeapon().GetWeaponKinematics().GetClimbRate())
					{
						this.m_ActiveUnit.SetDesiredAltitude(this.GetParentWeapon().CruiseAltitude);
						this.method_93(null, float_3);
						return;
					}
				}
				if (Information.IsNothing(this.GetPrimaryTarget()))
				{
					this.m_ActiveUnit.SetDesiredAltitude(base.GetPrimaryTarget_LastKnown_Alt());
					this.method_94(base.GetPrimaryTarget_LastKnown_Lat(), base.GetPrimaryTarget_LastKnown_Lon(), float_3);
				}
				else if (this.GetParentWeapon().CruiseAltitude == 0f && this.GetParentWeapon().GetCruiseAltitude_ASL() == 0f && this.m_ActiveUnit.GetCurrentAltitude_ASL(false) == this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) && !this.GetParentWeapon().IsDecoy())
				{
					this.m_ActiveUnit.SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
					this.method_94(this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), float_3);
				}
				else if (this.GetParentWeapon().CruiseAltitude == 0f && this.GetParentWeapon().GetCruiseAltitude_ASL() == 0f)
				{
					if (this.GetParentWeapon().IsDecoy())
					{
						this.GetParentWeapon().SetDesiredAltitude(this.GetParentWeapon().GetCurrentAltitude_ASL(false));
						this.method_93(null, float_3);
					}
					else if (this.m_ActiveUnit.GetCurrentAltitude_ASL(false) != this.GetPrimaryTarget().GetCurrentAltitude_ASL(false))
					{
						this.method_95(float_3);
					}
				}
				else
				{
					this.method_96(float_3);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100971", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x002511C0 File Offset: 0x0024F3C0
		private  void method_96(float float_3)
		{
			float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
			float float_4 = this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) + (float)this.GetParentWeapon().method_188(this.m_ActiveUnit.GetAI().GetPrimaryTarget().ActualUnit) - this.m_ActiveUnit.GetCurrentAltitude_ASL(false);
			float desiredSpeed = this.m_ActiveUnit.GetDesiredSpeed(this.GetPrimaryTarget(), 0f, this.m_ActiveUnit.GetCurrentHeading());
			float num = Math.Abs(this.m_ActiveUnit.GetKinematics().method_16(this.m_ActiveUnit, this.GetPrimaryTarget().GetCurrentAltitude_ASL(false), desiredSpeed));
			if (!this.GetParentWeapon().weaponCode.BallisticMissile && !this.GetParentWeapon().IsRVorHGV())
			{
				float num2 = Math.Max(this.GetParentWeapon().RangeAAWMax, this.GetParentWeapon().RangeASUWMax);
				num2 = Math.Max(num2, this.GetParentWeapon().RangeASWMax);
				if (horizontalRange <= num && (horizontalRange <= num2 / 4f || (this.GetPrimaryTarget().contactType != Contact_Base.ContactType.Air && this.GetPrimaryTarget().contactType != Contact_Base.ContactType.Missile) || !Information.IsNothing(this.GetParentWeapon().GetDataLinkParent())))
				{
					this.method_97(float_4, float_3);
				}
				else if (!this.bool_6)
				{
					if (this.GetParentWeapon().CruiseAltitude > 0f)
					{
						this.m_ActiveUnit.SetDesiredAltitude(this.GetParentWeapon().CruiseAltitude);
					}
					else
					{
						this.m_ActiveUnit.SetDesiredAltitude(this.GetParentWeapon().GetCruiseAltitude_ASL());
					}
					this.method_93(null, float_3);
				}
				else
				{
					this.method_97(float_4, float_3);
				}
			}
			else if (horizontalRange > num)
			{
				if (this.GetParentWeapon().CruiseAltitude > 0f)
				{
					this.m_ActiveUnit.SetDesiredAltitude(this.GetParentWeapon().CruiseAltitude);
				}
				else
				{
					this.m_ActiveUnit.SetDesiredAltitude(this.GetParentWeapon().GetCruiseAltitude_ASL());
				}
				this.method_93(null, float_3);
			}
			else if (this.GetParentWeapon().GetWeaponNavigator().HasPlottedCourse())
			{
				this.m_ActiveUnit.SetDesiredAltitude(this.GetParentWeapon().GetWeaponNavigator().GetPlottedCourse().First<Waypoint>().GetAltitude());
				this.method_93(this.GetParentWeapon().GetWeaponNavigator().GetPlottedCourse().First<Waypoint>(), float_3);
			}
			else
			{
				this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false) - float_3 * this.m_ActiveUnit.GetKinematics().vmethod_19());
				this.method_93(null, float_3);
			}
		}

		// Token: 0x06005654 RID: 22100 RVA: 0x00251458 File Offset: 0x0024F658
		private void method_97(float float_3, float float_4)
		{
			if (!this.bool_6)
			{
				this.bool_6 = true;
			}
			if (float_3 < 0f)
			{
				if (!this.GetParentWeapon().IsOfAirLaunchedGuidedWeapon())
				{
					float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
					float num = this.m_ActiveUnit.GetCurrentSpeed() * float_4 / 3600f;
					this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false) - num * Math.Abs(float_3) / horizontalRange);
				}
				else
				{
					this.m_ActiveUnit.SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
					this.method_94(this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), float_4);
				}
			}
			else if (!this.GetParentWeapon().IsOfAirLaunchedGuidedWeapon())
			{
				float horizontalRange2 = this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
				float num2 = this.m_ActiveUnit.GetCurrentSpeed() * float_4 / 3600f;
				this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetCurrentAltitude_ASL(false) + num2 * Math.Abs(float_3) / horizontalRange2);
			}
			else
			{
				this.m_ActiveUnit.SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
				this.method_94(this.GetPrimaryTarget().GetLatitude(null), this.GetPrimaryTarget().GetLongitude(null), float_4);
			}
		}

		// Token: 0x06005655 RID: 22101 RVA: 0x002515C8 File Offset: 0x0024F7C8
		[CompilerGenerated]
		private bool method_98(Contact contact_8)
		{
			return contact_8.SideIsKnown && contact_8 != this.GetPrimaryTarget() && !Information.IsNothing(contact_8.ActualUnit) && contact_8.GetSide(false) == this.GetPrimaryTarget().GetSide(false) && contact_8.GetHorizontalRange(this.GetPrimaryTarget()) < 125f && !Misc.HasNuclearWarhead(contact_8.method_92()) && this.GetParentWeapon().IsSuitableForTarget(this.m_ActiveUnit.m_Scenario, ref contact_8);
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x00027833 File Offset: 0x00025A33
		[CompilerGenerated]
		private bool method_99(Contact contact_8)
		{
			return contact_8.GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownClass && this.GetPrimaryTarget().ActualUnit.DBID == contact_8.ActualUnit.DBID;
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x00251644 File Offset: 0x0024F844
		[CompilerGenerated]
		private double method_100(Contact contact_8)
		{
			return contact_8.GetApproxAngularDistanceInDegrees(this.GetPrimaryTarget());
		}

		// Token: 0x06005658 RID: 22104 RVA: 0x00251660 File Offset: 0x0024F860
		[CompilerGenerated]
		private bool method_101(Contact contact_8)
		{
			bool result;
			if (contact_8.GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownClass && this.GetPrimaryTarget().ActualUnit.DBID != contact_8.ActualUnit.DBID && Operators.CompareString(this.GetPrimaryTarget().ActualUnit.GetUnitTypeDescription(), contact_8.ActualUnit.GetUnitTypeDescription(), false) == 0)
			{
				Weapon parentWeapon = this.GetParentWeapon();
				Scenario scenario = this.m_ActiveUnit.m_Scenario;
				Contact contact = contact_8;
				result = parentWeapon.IsSuitableForTarget(scenario, ref contact);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06005659 RID: 22105 RVA: 0x00251644 File Offset: 0x0024F844
		[CompilerGenerated]
		private double method_102(Contact contact_8)
		{
			return contact_8.GetApproxAngularDistanceInDegrees(this.GetPrimaryTarget());
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x00251644 File Offset: 0x0024F844
		[CompilerGenerated]
		private double method_103(Contact contact_8)
		{
			return contact_8.GetApproxAngularDistanceInDegrees(this.GetPrimaryTarget());
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x002516E4 File Offset: 0x0024F8E4
		[CompilerGenerated]
		private double method_104(Contact contact_8)
		{
			return contact_8.GetApproxAngularDistanceInDegrees(this.m_ActiveUnit);
		}

		// Token: 0x0600565C RID: 22108 RVA: 0x002516E4 File Offset: 0x0024F8E4
		[CompilerGenerated]
		private double method_105(Contact contact_8)
		{
			return contact_8.GetApproxAngularDistanceInDegrees(this.m_ActiveUnit);
		}

		// Token: 0x0600565D RID: 22109 RVA: 0x00251700 File Offset: 0x0024F900
		[CompilerGenerated]
		private float method_106(Contact contact_8)
		{
			return this.m_ActiveUnit.GetSlantRange(contact_8, 0f);
		}

		// Token: 0x0600565E RID: 22110 RVA: 0x00251700 File Offset: 0x0024F900
		[CompilerGenerated]
		private float method_107(Contact contact_8)
		{
			return this.m_ActiveUnit.GetSlantRange(contact_8, 0f);
		}

		// Token: 0x0600565F RID: 22111 RVA: 0x0002785E File Offset: 0x00025A5E
		[CompilerGenerated]
		private bool method_108(Contact contact_8)
		{
			return contact_8.GetEmissionContainerObDictionary().Keys.Contains(this.GetParentWeapon().ARM_SpecifiedEmission.Key);
		}

		// Token: 0x06005660 RID: 22112 RVA: 0x00251720 File Offset: 0x0024F920
		[CompilerGenerated]
		private float method_109(Contact contact_8)
		{
			return this.m_ActiveUnit.AzimuthTo(contact_8);
		}

		// Token: 0x04002A79 RID: 10873
		public static Func<Contact, Contact> ContactFunc = (Contact contact_0) => contact_0;

		// Token: 0x04002A7A RID: 10874
		private Weapon_AI.Enum92? nullable_5;

		// Token: 0x04002A7B RID: 10875
		public bool bool_6;

		// Token: 0x04002A7C RID: 10876
		private float VirtualTargetAltitude;

		// Token: 0x04002A7D RID: 10877
		private float VirtualTargetVelocity = 0f;

		// Token: 0x04002A7E RID: 10878
		private Weapon theWeapon;

		// Token: 0x02000AA2 RID: 2722
		public enum Enum92 : byte
		{
			// Token: 0x04002A81 RID: 10881
			const_0,
			// Token: 0x04002A82 RID: 10882
			const_1
		}

		// Token: 0x02000AA3 RID: 2723
		[CompilerGenerated]
		public sealed class Class224
		{
			// Token: 0x06005663 RID: 22115 RVA: 0x000278A4 File Offset: 0x00025AA4
			public Class224(Weapon_AI.Class224 class224_0)
			{
				if (class224_0 != null)
				{
					this.list_0 = class224_0.list_0;
					this.list_1 = class224_0.list_1;
				}
			}

			// Token: 0x06005664 RID: 22116 RVA: 0x0025173C File Offset: 0x0024F93C
			internal bool method_0(Contact contact_0)
			{
				bool result;
				if (contact_0.GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownClass && !this.list_0.Contains(contact_0) && !this.list_1.Contains(contact_0))
				{
					Weapon parentWeapon = this.weapon_AI_0.GetParentWeapon();
					Scenario scenario = this.weapon_AI_0.m_ActiveUnit.m_Scenario;
					Contact contact = contact_0;
					result = parentWeapon.IsSuitableForTarget(scenario, ref contact);
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x04002A83 RID: 10883
			public List<Contact> list_0;

			// Token: 0x04002A84 RID: 10884
			public List<Contact> list_1;

			// Token: 0x04002A85 RID: 10885
			public Weapon_AI weapon_AI_0;
		}
	}
}

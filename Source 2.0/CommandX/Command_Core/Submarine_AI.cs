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
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 潜艇决策模型
	public sealed class Submarine_AI : ActiveUnit_AI
	{
		// Token: 0x06005C35 RID: 23605 RVA: 0x002A23B8 File Offset: 0x002A05B8
		private Submarine GetParentPlatform()
		{
			if (Information.IsNothing(this.ParentSub))
			{
				this.ParentSub = (Submarine)this.m_ActiveUnit;
			}
			return this.ParentSub;
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x00023901 File Offset: 0x00021B01
		public Submarine_AI(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x002A23F0 File Offset: 0x002A05F0
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
				xmlWriter_0.WriteElementString("TTNPTE", this.TimeToNextPrimaryTargetEvent.ToString());
				xmlWriter_0.WriteElementString("PTOE", this.bPrimaryTargetOverride.ToString());
				xmlWriter_0.WriteElementString("FCLIO", this.FerryCycleLegIsOutbound.ToString());
				xmlWriter_0.WriteElementString("DP", ((byte)this.GetDepthPreset()).ToString());
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
				ex2.Data.Add("Error at 100815", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x002A2734 File Offset: 0x002A0934
		public static Submarine_AI Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_1, ref ActiveUnit activeUnit_1)
		{
			Submarine_AI result = null;
			try
			{
				Submarine_AI submarine_AI = new Submarine_AI(ref activeUnit_1);
				submarine_AI.m_ActiveUnit = activeUnit_1;
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
							if (num <= 592141878u)
							{
								if (num <= 357111700u)
								{
									if (num != 106934956u)
									{
										if (num != 357111700u)
										{
											continue;
										}
										if (Operators.CompareString(name, "IgnorePlottedCourse", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "PrimaryTarget", false) == 0)
										{
											submarine_AI.PrimaryTarget = Contact.GetContact(xmlNode.InnerText, ref dictionary_1);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (num != 467450941u)
									{
										if (num != 592141878u || Operators.CompareString(name, "Threats", false) != 0)
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
												ScenarioArrayUtil.AddContact(ref submarine_AI.Threats, contact_);
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
									if (Operators.CompareString(name, "PrimaryThreat", false) == 0)
									{
										submarine_AI.PrimaryThreat = Contact.GetContact(xmlNode.InnerText, ref dictionary_1);
										continue;
									}
									continue;
								}
							}
							else if (num <= 868927472u)
							{
								if (num != 684613497u)
								{
									if (num == 868927472u && Operators.CompareString(name, "LKTL", false) == 0)
									{
										submarine_AI.LastKnownTargetLocation = GeoPoint.Load(ref xmlNode, ref dictionary_1);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "DP", false) == 0)
									{
										submarine_AI.SetDepthPreset((ActiveUnit_AI._DepthPreset)Conversions.ToByte(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num != 1474882803u)
							{
								if (num != 1533721748u)
								{
									if (num == 1610968176u && Operators.CompareString(name, "TTNPTE", false) == 0)
									{
										submarine_AI.TimeToNextPrimaryTargetEvent = Conversions.ToShort(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "PrimaryTargetOverride", false) != 0)
									{
										continue;
									}
									goto IL_5C8;
								}
							}
							else
							{
								if (Operators.CompareString(name, "IE", false) == 0)
								{
									submarine_AI.IsEscort = true;
									continue;
								}
								continue;
							}
						}
						else
						{
							if (num <= 2273311670u)
							{
								if (num <= 1966596370u)
								{
									if (num != 1925531877u)
									{
										if (num == 1966596370u && Operators.CompareString(name, "PrimaryTarget_LastKnown_Lon", false) == 0)
										{
											submarine_AI.SetPrimaryTarget_LastKnown_Lon(XmlConvert.ToDouble(xmlNode.InnerText));
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
										submarine_AI.SetPrimaryTarget_LastKnown_Lat(XmlConvert.ToDouble(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								submarine_AI.FerryCycleLegIsOutbound = Conversions.ToBoolean(xmlNode.InnerText);
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
									goto IL_5C8;
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
											if (!Information.IsNothing(targetingEntry.Target) && !submarine_AI.GetTargetList().ContainsKey(targetingEntry.Target.GetGuid()))
											{
												submarine_AI.GetTargetList().Add(targetingEntry.Target.GetGuid(), targetingEntry);
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
										submarine_AI.SetPrimaryTarget_LastKnown_Alt(XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "IPC", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "PrimaryTargetOverrideExists", false) == 0)
								{
									goto IL_5C8;
								}
								continue;
							}
						}
						bool flag = Conversions.ToBoolean(xmlNode.InnerText);
						if (!Information.IsNothing(activeUnit_1.m_Doctrine))
						{
							activeUnit_1.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(activeUnit_1.m_Scenario, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Conversions.ToBoolean(xmlNode.InnerText) ? Doctrine._IgnorePlottedCourseWhenAttacking.const_1 : Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
						}
						if (!flag || Information.IsNothing(activeUnit_1.GetAssignedMission(false)))
						{
							continue;
						}
						Mission assignedMission = activeUnit_1.GetAssignedMission(false);
						if (assignedMission.MissionClass == Mission._MissionClass.Patrol)
						{
							assignedMission.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(activeUnit_1.m_Scenario, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_1));
							continue;
						}
						continue;
						IL_5C8:
						submarine_AI.bPrimaryTargetOverride = Conversions.ToBoolean(xmlNode.InnerText);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = submarine_AI;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100816", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Submarine_AI(ref activeUnit_1);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005C39 RID: 23609 RVA: 0x000A243C File Offset: 0x000A063C
		public override Contact GetPrimaryThreat()
		{
			return this.PrimaryThreat;
		}

		// Token: 0x06005C3A RID: 23610 RVA: 0x000293F3 File Offset: 0x000275F3
		public override void SetPrimaryThreat(Contact Threat)
		{
			if (this.PrimaryThreat != Threat)
			{
				this.LastPrimaryThreat = this.PrimaryThreat;
			}
			this.PrimaryThreat = Threat;
		}

		// Token: 0x06005C3B RID: 23611 RVA: 0x002A2DF8 File Offset: 0x002A0FF8
		public Contact GetLastPrimaryThreat()
		{
			return this.LastPrimaryThreat;
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x002A2E10 File Offset: 0x002A1010
		public ActiveUnit_AI._DepthPreset GetDepthPreset()
		{
			return this.m_DepthPreset;
		}

		// Token: 0x06005C3D RID: 23613 RVA: 0x00029413 File Offset: 0x00027613
		public void SetDepthPreset(ActiveUnit_AI._DepthPreset dp)
		{
			this.m_DepthPreset = dp;
			if (dp != ActiveUnit_AI._DepthPreset.None)
			{
				this.m_ActiveUnit.GetKinematics().SetDesiredAltitudeOverride(true);
			}
		}

		// Token: 0x06005C3E RID: 23614 RVA: 0x002A2E28 File Offset: 0x002A1028
		public FuelRec._FuelType GetFuelType(Engine engine_0)
		{
			Engine._PropulsionType propulsionType = engine_0.PropulsionType;
			FuelRec._FuelType result;
			if (propulsionType != Engine._PropulsionType.Diesel)
			{
				if (propulsionType != Engine._PropulsionType.Electric)
				{
					if (propulsionType != Engine._PropulsionType.AirIndependent)
					{
						result = FuelRec._FuelType.NoFuel;
					}
					else if (this.m_ActiveUnit.GetEngines().Where(Submarine_AI.IsElectricPropulsion).Count<Engine>() == 0)
					{
						result = FuelRec._FuelType.Battery;
					}
					else
					{
						result = FuelRec._FuelType.AirIndepedent;
					}
				}
				else
				{
					result = FuelRec._FuelType.Battery;
				}
			}
			else
			{
				result = FuelRec._FuelType.DieselFuel;
			}
			return result;
		}

		// Token: 0x06005C3F RID: 23615 RVA: 0x002A2EA8 File Offset: 0x002A10A8
		public Dictionary<int, Engine> method_93()
		{
			Dictionary<int, Engine> result;
			if (Information.IsNothing(this.m_ActiveUnit))
			{
				result = new Dictionary<int, Engine>();
			}
			else if (this.m_ActiveUnit.GetEngines().Count == 0)
			{
				result = new Dictionary<int, Engine>();
			}
			else
			{
				Dictionary<int, Engine> dictionary = new Dictionary<int, Engine>();
				if (this.m_ActiveUnit.GetEngines().Count == 1)
				{
					this.GetParentPlatform().SetEngine(this.m_ActiveUnit.GetEngines()[0]);
					this.GetParentPlatform().method_134(0);
					dictionary.Add(0, this.m_ActiveUnit.GetEngines()[0]);
					result = dictionary;
				}
				else
				{
					try
					{
						if (this.GetParentPlatform().GetCurrentAltitude_ASL(false) >= -20f)
						{
							if (this.method_95())
							{
								if (!Information.IsNothing(this.GetParentPlatform().GetEngines()) && this.GetParentPlatform().GetEngines().Count > 0)
								{
									int num = this.GetParentPlatform().GetEngines().Count - 1;
									for (int i = 0; i <= num; i++)
									{
										Engine engine = this.GetParentPlatform().GetEngines()[i];
										if (engine.PropulsionType == Engine._PropulsionType.Diesel)
										{
											dictionary.Add(i, engine);
											this.GetParentPlatform().SetEngine(engine);
											this.GetParentPlatform().method_134(i);
										}
										if (engine.PropulsionType == Engine._PropulsionType.Electric)
										{
											dictionary.Add(i, engine);
										}
									}
								}
							}
							else if (!Information.IsNothing(this.GetParentPlatform().GetEngines()) && this.GetParentPlatform().GetEngines().Count > 0)
							{
								int num2 = this.GetParentPlatform().GetEngines().Count - 1;
								for (int j = 0; j <= num2; j++)
								{
									Engine engine = this.GetParentPlatform().GetEngines()[j];
									if (engine.PropulsionType == Engine._PropulsionType.Electric)
									{
										dictionary.Add(j, engine);
										this.GetParentPlatform().SetEngine(engine);
										this.GetParentPlatform().method_134(j);
										break;
									}
								}
							}
						}
						else
						{
							if (!Information.IsNothing(this.GetParentPlatform().GetEngines()) && this.GetParentPlatform().GetEngines().Count > 0)
							{
								int num3 = this.GetParentPlatform().GetEngines().Count - 1;
								int k = 0;
								while (k <= num3)
								{
									Engine engine = this.GetParentPlatform().GetEngines()[k];
									if (engine.PropulsionType != Engine._PropulsionType.Electric)
									{
										k++;
									}
									else
									{
										dictionary.Add(k, engine);
										this.GetParentPlatform().SetEngine(engine);
										this.GetParentPlatform().method_134(k);
										if (dictionary.Count == 0)
										{
											int num4 = this.GetParentPlatform().GetEngines().Count - 1;
											for (int l = 0; l <= num4; l++)
											{
												engine = this.GetParentPlatform().GetEngines()[l];
												if (engine.PropulsionType == Engine._PropulsionType.AirIndependent)
												{
													dictionary.Add(l, engine);
													this.GetParentPlatform().SetEngine(engine);
													this.GetParentPlatform().method_134(l);
													break;
												}
											}
											goto IL_3F3;
										}
										goto IL_3F3;
									}
								}
								if (dictionary.Count == 0)
								{
									int num4 = this.GetParentPlatform().GetEngines().Count - 1;
									for (int l = 0; l <= num4; l++)
									{
										Engine engine = this.GetParentPlatform().GetEngines()[l];
										if (engine.PropulsionType == Engine._PropulsionType.AirIndependent)
										{
											dictionary.Add(l, engine);
											this.GetParentPlatform().SetEngine(engine);
											this.GetParentPlatform().method_134(l);
											break;
										}
									}
								}
							}
							IL_3F3:
							if (this.GetParentPlatform().method_155())
							{
								Doctrine._UseAIP? useAIPDoctrine = this.m_ActiveUnit.m_Doctrine.GetUseAIPDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
								byte? b = useAIPDoctrine.HasValue ? new byte?((byte)useAIPDoctrine.GetValueOrDefault()) : null;
								if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
								{
									if (!Information.IsNothing(this.GetParentPlatform().GetEngines()) && this.GetParentPlatform().GetEngines().Count > 0)
									{
										int num5 = this.GetParentPlatform().GetEngines().Count - 1;
										for (int m = 0; m <= num5; m++)
										{
											Engine engine = this.GetParentPlatform().GetEngines()[m];
											if (engine.PropulsionType == Engine._PropulsionType.AirIndependent)
											{
												dictionary.Add(m, engine);
												break;
											}
										}
									}
								}
								else if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedDefensive || this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
								{
									b = (useAIPDoctrine.HasValue ? new byte?((byte)useAIPDoctrine.GetValueOrDefault()) : null);
									if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && !Information.IsNothing(this.GetParentPlatform().GetEngines()) && this.GetParentPlatform().GetEngines().Count > 0)
									{
										int num6 = this.GetParentPlatform().GetEngines().Count - 1;
										for (int n = 0; n <= num6; n++)
										{
											Engine engine = this.GetParentPlatform().GetEngines()[n];
											if (engine.PropulsionType == Engine._PropulsionType.AirIndependent)
											{
												dictionary.Add(n, engine);
												break;
											}
										}
									}
								}
							}
						}
						if (Information.IsNothing(this.GetParentPlatform().GetEngine()))
						{
							this.GetParentPlatform().SetEngine(this.m_ActiveUnit.GetEngines()[0]);
						}
						result = dictionary;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100812", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						result = new Dictionary<int, Engine>();
						ProjectData.ClearProjectError();
					}
				}
			}
			return result;
		}

		// Token: 0x06005C40 RID: 23616 RVA: 0x002A3568 File Offset: 0x002A1768
		public override void UpdateUnitStatus(float elapsedTime, bool bool_6, bool bool_7)
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
							else
							{
								Submarine._SubmarineType type = this.GetParentPlatform().Type;
								if (type - Submarine._SubmarineType.SSB <= 1 && this.GetParentPlatform().GetHorizontalRange(this.PrimaryThreat) < 30f)
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
					if (!this.m_ActiveUnit.IsRTB() && (!this.m_ActiveUnit.m_Scenario.FifteenthSecondIsChangingOnThisPulse || this.m_ActiveUnit.IsRTB() || !base.method_74()))
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
									this.TargetingContacts(elapsedTime, false, true);
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
											this.m_ActiveUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.EngagedOffensive);
											return;
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
					ex2.Data.Add("Error at 200347", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005C41 RID: 23617 RVA: 0x002A3A90 File Offset: 0x002A1C90
		public override bool IsTargetReachable(double targetLat, double targetLon, float targetHeading, float targetSpeed, float parentAltitude_ASL, float parentSpeed, float parentHeading, float? nullable_5, bool bool_6, bool bool_7)
		{
			bool flag = false;
			bool result;
			try
			{
				if (Information.IsNothing(nullable_5))
				{
					nullable_5 = new float?(0.1f);
				}
				float num = this.m_ActiveUnit.HorizontalRangeTo(targetLat, targetLon);
				if (float.IsNaN(num))
				{
					flag = true;
				}
				else
				{
					float num2;
					if (bool_6)
					{
						num2 = parentSpeed;
						if (parentSpeed <= 0f || double.IsNaN((double)parentSpeed))
						{
							flag = false;
							result = false;
							return result;
						}
					}
					else
					{
						if (bool_7)
						{
							num2 = this.m_ActiveUnit.GetDesiredSpeed(targetLat, targetLon, targetHeading, targetSpeed, parentSpeed, parentHeading);
						}
						else
						{
							float azimuth = Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), targetLat, targetLon);
							num2 = this.m_ActiveUnit.GetDesiredSpeed(targetLat, targetLon, targetHeading, targetSpeed, parentSpeed, azimuth);
						}
						if (num2 <= 0f || double.IsNaN((double)num2))
						{
							flag = false;
							result = false;
							return result;
						}
					}
					long num3 = (long)Math.Round((double)(num / num2 * 3600f));
					float num4 = (float)this.GetParentPlatform().GetSubmarineKinematics().GetFuelBurnoutTime(parentSpeed, parentAltitude_ASL, true, false);
					float? num5 = nullable_5;
					num5 = (num5.HasValue ? new float?(1f + num5.GetValueOrDefault()) : null);
					float? num6 = num5.HasValue ? new float?(num4 * num5.GetValueOrDefault()) : null;
					float num7 = (float)num3;
					flag = (num6.HasValue ? new bool?(num6.GetValueOrDefault() > num7) : null).GetValueOrDefault();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100047", "");
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

		// Token: 0x06005C42 RID: 23618 RVA: 0x001C4C2C File Offset: 0x001C2E2C
		private Weapon[] GetAvailableWeapons()
		{
			return this.m_ActiveUnit.GetWeaponry().GetAvailableWeapons(false);
		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x002A3CB8 File Offset: 0x002A1EB8
		public override void TargetingContacts(float float_2, bool bool_6, bool bool_7)
		{
			try
			{
				if (!Information.IsNothing(this.m_ActiveUnit) && !this.GetParentPlatform().IsBiologics() && !this.GetParentPlatform().IsFalseTarget())
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
								goto IL_B43;
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
								goto IL_B43;
							}
						}
						base.TargetingContacts(float_2, bool_6, bool_7);
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
								if (!Information.IsNothing(contact) && (this.m_ActiveUnit.GetSide(false).GetQuantityToFireForTheTarget(ref this.m_ActiveUnit, ref contact) <= 0 || base.GetTargetingBehavior(contact) != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc))
								{
									foreach (NoNavZone current2 in this.m_ActiveUnit.GetSide(false).NoNavZoneList.Where(new Func<NoNavZone, bool>(this.IsAffectedBy)))
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
								if ((bool_7 || current4.contactType == Contact_Base.ContactType.Missile || current4.contactType == Contact_Base.ContactType.Torpedo || (current4.contactType == Contact_Base.ContactType.Air && this.m_ActiveUnit.m_Scenario.FifthSecondIsChangingOnThisPulse) || this.m_ActiveUnit.m_Scenario.FifteenthSecondIsChangingOnThisPulse) && !ScenarioArrayUtil.IsContactExists(ref targets2, current4) && !collection2.Contains(current4))
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
											{
												ActiveUnit_Weaponry weaponry = this.m_ActiveUnit.GetWeaponry();
												Contact theTarget = current4;
												Doctrine doctrine = this.m_ActiveUnit.m_Doctrine;
												text = "";
												num = 0;
												if (weaponry.HasWeaponsInConditionToAttackTarget(theTarget, true, doctrine, ref text, ref num, lazy.Value) && (current4.contactType != Contact_Base.ContactType.Submarine || !current4.IsBiologics()))
												{
													if (current4.Heading_Known && current4.Speed_Known && current4.GetCurrentSpeed() > 0f && this.m_ActiveUnit.GetCurrentSpeed() > 0f)
													{
														if (base.IsTargetReachable(current4, true))
														{
															this.TargetingContact(current4, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
														}
													}
													else
													{
														this.TargetingContact(current4, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
													}
												}
												break;
											}
											case Misc.PostureStance.Unknown:
												if (current4.Heading_Known && current4.Speed_Known && current4.GetCurrentSpeed() > 0f && this.m_ActiveUnit.GetCurrentSpeed() > 0f)
												{
													if (base.IsTargetReachable(current4, true))
													{
														this.TargetingContact(current4, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
													}
												}
												else
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
						if (!this.m_ActiveUnit.HasAssignedPatrolMission() || ((Patrol)assignedMission).method_45(this.m_ActiveUnit.m_Scenario))
						{
							Weapon aAWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetAAWWeapon_RangeMax();
							Weapon aSUWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetASUWWeapon_RangeMax(false);
							Weapon landWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetLandWeapon_RangeMax(false);
							Weapon aSWWeapon_RangeMax = this.m_ActiveUnit.GetWeaponry().GetASWWeapon_RangeMax();
							bool flag2 = this.m_ActiveUnit.HasAssignedPatrolMission() && ((Patrol)assignedMission).method_42();
							foreach (Contact current5 in contactList)
							{
								if ((bool_7 || current5.contactType == Contact_Base.ContactType.Missile || current5.contactType == Contact_Base.ContactType.Torpedo || (current5.contactType == Contact_Base.ContactType.Air && this.m_ActiveUnit.m_Scenario.FifthSecondIsChangingOnThisPulse) || this.m_ActiveUnit.m_Scenario.FifteenthSecondIsChangingOnThisPulse) && !ScenarioArrayUtil.IsContactExists(ref targets2, current5) && !collection2.Contains(current5))
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
										if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault() && base.IsTargetReachable(current5, true))
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
												if (!Information.IsNothing(current5.ActualUnit) && current5.ActualUnit.IsAircraft && current5.GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownType)
												{
													Aircraft._AircraftType type = ((Aircraft)current5.ActualUnit).Type;
													if (type - Aircraft._AircraftType.ASW <= 1 && (postureStance2 == Misc.PostureStance.Hostile || postureStance2 == Misc.PostureStance.Unfriendly) && !Information.IsNothing(aAWWeapon_RangeMax) && this.m_ActiveUnit.GetHorizontalRange(current5) < (float)current5.method_72() * aAWWeapon_RangeMax.RangeAAWMax)
													{
														this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
													}
												}
												break;
											case Contact_Base.ContactType.Surface:
											case Contact_Base.ContactType.UndeterminedNaval:
												b = (shootTouristsDoctrine.HasValue ? new byte?((byte)shootTouristsDoctrine.GetValueOrDefault()) : null);
												if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && !Information.IsNothing(aSUWWeapon_RangeMax) && this.m_ActiveUnit.GetHorizontalRange(current5) < aSUWWeapon_RangeMax.RangeASUWMax)
												{
													if (current5.Heading_Known && current5.Speed_Known)
													{
														this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
													}
													else
													{
														this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
													}
												}
												break;
											case Contact_Base.ContactType.Submarine:
												if (!Information.IsNothing(aSWWeapon_RangeMax) && !current5.IsBiologics() && this.m_ActiveUnit.GetHorizontalRange(current5) < aSWWeapon_RangeMax.RangeASWMax)
												{
													if (current5.Heading_Known && current5.Speed_Known)
													{
														this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
													}
													else
													{
														this.TargetingContact(current5, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
													}
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
													int num = 0;
													if (weaponry2.HasWeaponsInConditionToAttackTarget(theTarget2, true, doctrine2, ref text, ref num, null) && !Information.IsNothing(aAWWeapon_RangeMax) && this.m_ActiveUnit.GetSlantRange(current5, 0f) < (float)current5.method_72() * aAWWeapon_RangeMax.RangeAAWMax)
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
				IL_B43:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100815", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x002A48E0 File Offset: 0x002A2AE0
		public override void EngagedDefensive(float elapsedTime_)
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && !Information.IsNothing(this.GetPrimaryThreat()))
			{
				try
				{
					float num = (float)Math.Round((double)Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.GetPrimaryThreat().GetLatitude(null), this.GetPrimaryThreat().GetLongitude(null)), 0);
					if (!float.IsNegativeInfinity(num))
					{
						Contact_Base.ContactType contactType = this.GetPrimaryThreat().contactType;
						if (contactType - Contact_Base.ContactType.Surface > 1)
						{
							if (contactType == Contact_Base.ContactType.Torpedo)
							{
								int num2 = (int)Math.Round((double)num);
								base.RunOppositeTo(ref num2);
								if (this.GetParentPlatform().IsNuclearPropelled())
								{
									this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
									this.m_ActiveUnit.SetDesiredAltitude(this.m_ActiveUnit.GetKinematics().GetMinAltitude());
								}
							}
						}
						else
						{
							if (!Information.IsNothing(this.GetLastPrimaryThreat()) && (double)Math.Abs(this.GetLastPrimaryThreat().GetHorizontalRange(this.m_ActiveUnit) - this.GetPrimaryThreat().GetHorizontalRange(this.m_ActiveUnit)) < 0.5)
							{
								float num3 = (float)Math.Round((double)Math2.GetAzimuth(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.GetLastPrimaryThreat().GetLatitude(null), this.GetLastPrimaryThreat().GetLongitude(null)), 0);
								double x = Math.Cos(0.0174532925199433 * (double)num) + Math.Cos(0.0174532925199433 * (double)num3);
								double y = Math.Sin(0.0174532925199433 * (double)num) + Math.Sin(0.0174532925199433 * (double)num3);
								num = (float)(57.2957795130823 * Math.Atan2(y, x));
							}
							int num4 = (int)Math.Round((double)num);
							base.RunOppositeTo(ref num4);
							if (this.GetPrimaryThreat().Speed_Known && this.GetParentPlatform().IsNuclearPropelled())
							{
								this.GetParentPlatform().SetDesiredSpeed(this.GetPrimaryThreat().GetCurrentSpeed());
							}
							else
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
					ex2.Data.Add("Error at 100816", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x002A4BC0 File Offset: 0x002A2DC0
		public override void PickPrimaryThreat()
		{
			try
			{
				if (!Information.IsNothing(this.m_ActiveUnit))
				{
					if (base.GetThreats().Length == 0)
					{
						this.SetPrimaryThreat(null);
					}
					else
					{
						IEnumerable<Contact> source = base.GetThreats().Where(Submarine_AI.TargetIsWeapon).Select(Submarine_AI.IdentityMap).OrderBy(new Func<Contact, double>(this.GetAngularDistance));
						if (source.Count<Contact>() > 0)
						{
							this.SetPrimaryThreat(source.ElementAtOrDefault(0));
						}
						else
						{
							IEnumerable<Contact> source2 = base.GetThreats().Select(Submarine_AI.IdentityMap).OrderBy(new Func<Contact, double>(this.GetAngularDistance));
							this.SetPrimaryThreat(source2.ElementAtOrDefault(0));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100817", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x002A4CBC File Offset: 0x002A2EBC
		public override void ThreatAssessment()
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && !this.GetParentPlatform().IsBiologics() && !this.GetParentPlatform().IsFalseTarget())
			{
				try
				{
					base.AddThreats();
					List<Contact> contactList = this.m_ActiveUnit.GetSensory().GetContactList();
					foreach (Contact current in contactList)
					{
						if (!current.IsDestroyed(this.m_ActiveUnit.m_Scenario))
						{
							if (current.GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownType && !Information.IsNothing(current.ActualUnit) && current.ActualUnit.IsSubmarine)
							{
								Submarine submarine = (Submarine)current.ActualUnit;
								if (submarine.Type == Submarine._SubmarineType.Biologics || submarine.Type == Submarine._SubmarineType.FalseTarget)
								{
									continue;
								}
							}
							if (!Information.IsNothing(current.ActualUnit))
							{
								Misc.PostureStance postureStance;
								if (!this.PostureStanceDictionary.TryGetValue(current.GetGuid(), out postureStance))
								{
									postureStance = current.GetPostureStance(this.m_ActiveUnit.GetSide(false));
									this.PostureStanceDictionary.Add(current.GetGuid(), postureStance);
								}
								if (postureStance != Misc.PostureStance.Friendly && current.ActualUnit.IsWeapon)
								{
									Weapon._WeaponType weaponType = ((Weapon)current.ActualUnit).GetWeaponType();
									if (weaponType == Weapon._WeaponType.Torpedo)
									{
										this.AddThreat(current);
									}
								}
								Contact_Base.ContactType contactType = current.contactType;
								if (contactType != Contact_Base.ContactType.Surface)
								{
									if (contactType - Contact_Base.ContactType.Submarine <= 1 && !current.IsBiologics() && (postureStance == Misc.PostureStance.Hostile || postureStance == Misc.PostureStance.Unfriendly || postureStance == Misc.PostureStance.Unknown))
									{
										this.AddThreat(current);
									}
								}
								else
								{
									Ship ship = (Ship)current.ActualUnit;
									if (current.GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownType)
									{
										Ship._ShipCategory category = ship.Category;
										if ((category - Ship._ShipCategory.SurfaceCombatant <= 1 || category - Ship._ShipCategory.SurfaceCombatant_AviationCapable <= 1) && (postureStance == Misc.PostureStance.Hostile || postureStance == Misc.PostureStance.Unfriendly))
										{
											this.AddThreat(current);
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
					ex2.Data.Add("Error at 100818", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005C47 RID: 23623 RVA: 0x00281F84 File Offset: 0x00280184
		public static float GetJustOverLayerDepth(ActiveUnit activeUnit_)
		{
			return (float)(SonarEnvironment.GetLayer(activeUnit_.GetLatitude(null), activeUnit_.GetLongitude(null), activeUnit_.GetTerrainElevation(false, false, false)).Ceiling + 10);
		}

		// Token: 0x06005C48 RID: 23624 RVA: 0x00281FC8 File Offset: 0x002801C8
		public static float GetJustUnderLayerDepth(ActiveUnit activeUnit_)
		{
			return (float)(SonarEnvironment.GetLayer(activeUnit_.GetLatitude(null), activeUnit_.GetLongitude(null), activeUnit_.GetTerrainElevation(false, false, false)).Bottom - 10);
		}

		// Token: 0x06005C49 RID: 23625 RVA: 0x00029433 File Offset: 0x00027633
		public bool method_95()
		{
			return (int)Math.Round((double)this.GetParentPlatform().GetCurrentAltitude_ASL(false)) < -20 || this.GetParentPlatform().GetDesiredAltitude() >= -20f;
		}

		// Token: 0x06005C4A RID: 23626 RVA: 0x002A4F44 File Offset: 0x002A3144
		private bool NeedRechargeBattery(float RechargeBatteryPercentageDoctrine)
		{
			bool result = false;
			if (Information.IsNothing(this.m_ActiveUnit))
			{
				result = false;
			}
			else
			{
				try
				{
					if (this.GetParentPlatform().IsNuclearPropelled())
					{
						result = false;
					}
					else
					{
						FuelRec fuelRec = this.GetParentPlatform().GetFuelRecs().Where(Submarine_AI.IsDieselFuel).ElementAtOrDefault(0);
						if ((Information.IsNothing(fuelRec) || fuelRec.CurrentQuantity <= 0f) && this.GetParentPlatform().method_155())
						{
							fuelRec = this.GetParentPlatform().GetFuelRecs().Where(Submarine_AI.IsAirIndepedent).ElementAtOrDefault(0);
						}
						if (!Information.IsNothing(fuelRec) && fuelRec.CurrentQuantity > 0f)
						{
							FuelRec fuelRec2 = this.GetParentPlatform().GetFuelRecs().Where(Submarine_AI.IsBattery).ElementAtOrDefault(0);
							if (!Information.IsNothing(fuelRec2))
							{
								double num = (double)fuelRec2.GetRatioLeft();
								result = (num == 0.0 || num <= (double)(RechargeBatteryPercentageDoctrine / 100f));
							}
							else
							{
								result = false;
							}
						}
						else
						{
							this.GetParentPlatform().method_150();
							result = false;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100820", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06005C4B RID: 23627 RVA: 0x002A50BC File Offset: 0x002A32BC
		public bool NeedRecharge(bool bool_6, ActiveUnit_DockingOps._DockingOpsCondition? DockingOpsCondition_)
		{
			bool flag = false;
			bool result;
			if (Information.IsNothing(this.m_ActiveUnit))
			{
				flag = false;
			}
			else if (this.GetParentPlatform().IsNuclearPropelled())
			{
				flag = false;
			}
			else
			{
				try
				{
					double num = (double)this.m_ActiveUnit.m_Doctrine.GetRechargeBatteryPercentageDoc(this.m_ActiveUnit.m_Scenario, false, false, false).Value / 100.0;
					FuelRec fuelRec = this.GetParentPlatform().GetFuelRecs().Where(Submarine_AI.IsBattery).ElementAtOrDefault(0);
					if (Information.IsNothing(fuelRec))
					{
						this.GetParentPlatform().method_150();
						flag = false;
					}
					else
					{
						double num2 = (double)fuelRec.GetRatioLeft();
						if (num2 < num)
						{
							flag = true;
						}
						else
						{
							if (Information.IsNothing(DockingOpsCondition_))
							{
								DockingOpsCondition_ = new ActiveUnit_DockingOps._DockingOpsCondition?(this.GetParentPlatform().GetDockingOps().GetDockingOpsCondition());
							}
							byte? b = DockingOpsCondition_.HasValue ? new byte?((byte)DockingOpsCondition_.GetValueOrDefault()) : null;
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 9) : null).GetValueOrDefault())
							{
								double num3 = (double)this.m_ActiveUnit.m_Doctrine.GetRechargeBatteryPercentageDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false).Value / 100.0;
								if (num2 < num3)
								{
									flag = true;
									result = true;
									return result;
								}
							}
							flag = this.method_98(bool_6, DockingOpsCondition_, num, num2);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100822", "");
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

		// Token: 0x06005C4C RID: 23628 RVA: 0x002A52B4 File Offset: 0x002A34B4
		public bool method_98(bool IsEngaged, ActiveUnit_DockingOps._DockingOpsCondition? DockingOpsCondition_, double RechargeBatteryPercentage, double FuelRecRatioLeft)
		{
			bool flag = false;
			bool result;
			try
			{
				if (this.GetParentPlatform().IsBiologics())
				{
					flag = true;
				}
				else if (this.GetParentPlatform().IsFalseTarget())
				{
					flag = false;
				}
				else
				{
					if (!this.GetParentPlatform().IsNuclearPropelled())
					{
						if (RechargeBatteryPercentage < 0.0)
						{
							RechargeBatteryPercentage = (double)this.m_ActiveUnit.m_Doctrine.GetRechargeBatteryPercentageDoc(this.m_ActiveUnit.m_Scenario, false, false, false).Value / 100.0;
						}
						if (FuelRecRatioLeft < 0.0 && this.GetParentPlatform() != null && this.GetParentPlatform().GetFuelRecs() != null)
						{
							FuelRec fuelRec = this.GetParentPlatform().GetFuelRecs().Where(Submarine_AI.IsBattery).ElementAtOrDefault(0);
							if (fuelRec != null)
							{
								FuelRecRatioLeft = (double)fuelRec.GetRatioLeft();
							}
						}
					}
					Doctrine._DiveOnContact? diveOnContactDoctrine = this.m_ActiveUnit.m_Doctrine.GetDiveOnContactDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false);
					byte? b = diveOnContactDoctrine.HasValue ? new byte?((byte)diveOnContactDoctrine.GetValueOrDefault()) : null;
					bool? flag3;
					bool? flag2 = flag3 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null);
					bool? flag4;
					bool? flag5;
					if (flag2.HasValue && flag3.GetValueOrDefault())
					{
						flag4 = new bool?(true);
					}
					else
					{
						b = (diveOnContactDoctrine.HasValue ? new byte?((byte)diveOnContactDoctrine.GetValueOrDefault()) : null);
						flag2 = (flag5 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null));
						flag4 = (flag2.HasValue ? (flag3 | flag5.GetValueOrDefault()) : null);
					}
					flag5 = flag4;
					bool value = flag5.Value;
					b = (diveOnContactDoctrine.HasValue ? new byte?((byte)diveOnContactDoctrine.GetValueOrDefault()) : null);
					flag2 = (flag5 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null));
					bool? flag6;
					if (flag2.HasValue && flag5.GetValueOrDefault())
					{
						flag6 = new bool?(true);
					}
					else
					{
						b = (diveOnContactDoctrine.HasValue ? new byte?((byte)diveOnContactDoctrine.GetValueOrDefault()) : null);
						flag2 = (flag3 = (b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null));
						flag6 = (flag2.HasValue ? (flag5 | flag3.GetValueOrDefault()) : null);
					}
					flag3 = flag6;
					bool value2 = flag3.Value;
					if (this.m_ActiveUnit.float_19 < 1800f && value)
					{
						if (this.GetParentPlatform().IsNuclearPropelled())
						{
							flag = false;
							result = false;
							return result;
						}
						if (!IsEngaged && RechargeBatteryPercentage <= FuelRecRatioLeft)
						{
							this.GetParentPlatform().method_150();
							flag = false;
							result = false;
							return result;
						}
					}
					if (value2)
					{
						foreach (Contact current in this.GetParentPlatform().GetSide(false).GetContactList())
						{
							if (current.GetIdentificationStatus() > Contact_Base.IdentificationStatus.KnownType)
							{
								if (current.IsSubSurface() && !Information.IsNothing(current.ActualUnit) && current.ActualUnit.IsSubmarine)
								{
									Submarine submarine = (Submarine)current.ActualUnit;
									if (submarine.Type == Submarine._SubmarineType.Biologics || submarine.Type == Submarine._SubmarineType.FalseTarget)
									{
										continue;
									}
								}
								if (current.GetPostureStance(this.GetParentPlatform().GetSide(false)) != Misc.PostureStance.Friendly && current.GetPostureStance(this.GetParentPlatform().GetSide(false)) != Misc.PostureStance.Neutral)
								{
									Contact_Base.ContactType contactType = current.contactType;
									int num;
									if (contactType != Contact_Base.ContactType.Air)
									{
										if (contactType - Contact_Base.ContactType.Surface > 1 && contactType != Contact_Base.ContactType.Sonobuoy)
										{
											continue;
										}
										num = 20;
									}
									else
									{
										num = 30;
									}
									if (this.GetParentPlatform().GetHorizontalRange(current) < (float)num)
									{
										if (!this.GetParentPlatform().IsNuclearPropelled())
										{
											this.GetParentPlatform().method_150();
										}
										flag = false;
										result = false;
										return result;
									}
								}
							}
						}
					}
					flag = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101280", "");
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

		// Token: 0x06005C4D RID: 23629 RVA: 0x002A57D0 File Offset: 0x002A39D0
		public bool IsRechargingBatteries(float RechargeBatteryPercentageDoc, bool bool_6, bool bool_7)
		{
			ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = this.GetParentPlatform().GetDockingOps().GetDockingOpsCondition();
			bool result = false;
			if (dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
			{
				if (!this.NeedRecharge(bool_7, new ActiveUnit_DockingOps._DockingOpsCondition?(dockingOpsCondition)))
				{
					this.GetParentPlatform().SetDesiredAltitude(-40f);
					result = false;
				}
				else
				{
					if (this.GetParentPlatform().GetDesiredAltitude() < -20f)
					{
						this.GetParentPlatform().SetDesiredAltitude(-20f);
					}
					result = true;
				}
			}
			else
			{
				try
				{
					if (Information.IsNothing(this.m_ActiveUnit))
					{
						result = false;
					}
					else if (this.GetParentPlatform().IsNuclearPropelled())
					{
						result = false;
					}
					else
					{
						this.GetParentPlatform().GetDesiredAltitude();
						if (this.NeedRechargeBattery(RechargeBatteryPercentageDoc) && (bool_7 || this.NeedRecharge(bool_7, null)))
						{
							this.GetParentPlatform().GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries);
							if (this.GetParentPlatform().GetDesiredAltitude() < -20f)
							{
								this.GetParentPlatform().SetDesiredAltitude(-20f);
							}
							result = true;
						}
						else
						{
							result = false;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100823", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x002A5940 File Offset: 0x002A3B40
		private void SetPatrolDepth(float elapsedTime_)
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && !Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
			{
				try
				{
					if (this.GetParentPlatform().GetDockingOps().GetDockingOpsCondition() != ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
					{
						Patrol patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
						if (patrol.StationDepth_Submarine.HasValue)
						{
							float value = patrol.StationDepth_Submarine.Value;
							if (value >= -20f && !this.NeedRecharge(false, null))
							{
								this.m_ActiveUnit.SetDesiredAltitude(-40f);
							}
							else
							{
								this.m_ActiveUnit.SetDesiredAltitude(value);
							}
						}
						else
						{
							switch (patrol.patrolType)
							{
							case GlobalVariables.PatrolType.ASW:
							case GlobalVariables.PatrolType.SeaControl:
								this.timeToChangeDepth -= elapsedTime_;
								if (this.timeToChangeDepth <= 0f)
								{
									this.timeToChangeDepth = (float)GameGeneral.GetRandom().Next(1, 901);
									SonarEnvironment.Thermocline layer = SonarEnvironment.GetLayer(this.m_ActiveUnit.GetLatitude(null), this.m_ActiveUnit.GetLongitude(null), this.m_ActiveUnit.GetTerrainElevation(false, false, false));
									int num = -40;
									int num2;
									if (this.m_ActiveUnit.GetSensory().HasOperatingTowedArraySonar())
									{
										num2 = layer.Ceiling + 10;
									}
									else
									{
										num2 = layer.Bottom - 10;
									}
									if (num < num2)
									{
										num = num2 + 1;
									}
									if (GameGeneral.GetRandom().Next(1, 101) < 50)
									{
										this.m_ActiveUnit.SetDesiredAltitude((float)num);
									}
									else
									{
										this.m_ActiveUnit.SetDesiredAltitude((float)num2);
									}
								}
								break;
							case GlobalVariables.PatrolType.ASuW_Naval:
							case GlobalVariables.PatrolType.ASuW_Mixed:
							case GlobalVariables.PatrolType.SEAD:
								this.m_ActiveUnit.SetDesiredAltitude(-40f);
								break;
							case GlobalVariables.PatrolType.AAW:
							case GlobalVariables.PatrolType.ASuW_Land:
								if (patrol.StationDepth_Submarine.HasValue)
								{
									if (patrol.StationDepth_Submarine.Value >= -20f && !this.NeedRecharge(false, null))
									{
										this.m_ActiveUnit.SetDesiredAltitude(-40f);
									}
									else
									{
										this.m_ActiveUnit.SetDesiredAltitude(-20f);
									}
								}
								else
								{
									this.m_ActiveUnit.SetDesiredAltitude(-40f);
								}
								break;
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100824", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005C4F RID: 23631 RVA: 0x002A5C20 File Offset: 0x002A3E20
		public override void Navigate(float elapsedTime_)
		{
			if (!Information.IsNothing(this.m_ActiveUnit))
			{
				try
				{
					ActiveUnit._ActiveUnitStatus activeUnitStatus = this.m_ActiveUnit.GetUnitStatus();
					if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
					{
						int value = (int)this.m_ActiveUnit.m_Doctrine.GetRechargeBatteryPercentageDoc(this.m_ActiveUnit.m_Scenario, false, false, false).Value;
						if (!this.IsRechargingBatteries((float)value, true, true))
						{
							this.m_ActiveUnit.GetKinematics().SetDesiredSpeedOverride(null);
							this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Full, null);
						}
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
								uNREPDestinationUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, uNREPDestinationUnit.AzimuthTo(this.m_ActiveUnit));
								uNREPDestinationUnit.SetThrottle(ActiveUnit.Throttle.Full, null);
								this.m_ActiveUnit.SetDesiredSpeed(Math.Max(5f, uNREPDestinationUnit.GetCurrentSpeed() - 10f));
								this.m_ActiveUnit.SetThrottle(this.m_ActiveUnit.GetKinematics().vmethod_38(0f, (float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))), new float?((float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))));
							}
							else
							{
								if (uNREPDestinationUnit.GetCommStuff().IsNotOutOfComms())
								{
									this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.AzimuthTo(uNREPDestinationUnit));
								}
								else
								{
									this.m_ActiveUnit.SetDesiredHeading(ActiveUnit._TurnRate.const_0, this.m_ActiveUnit.AzimuthTo(uNREPDestinationUnit.GetLatitudeLR().Value, uNREPDestinationUnit.GetLongitudeLR().Value));
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
					else if (activeUnitStatus != ActiveUnit._ActiveUnitStatus.RTB && activeUnitStatus != ActiveUnit._ActiveUnitStatus.RTB_Manual && activeUnitStatus != ActiveUnit._ActiveUnitStatus.RTB_MissionOver)
					{
						if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
						{
							Doctrine._IgnorePlottedCourseWhenAttacking? ignorePlottedCourseWhenAttackingDoctrine = this.m_ActiveUnit.m_Doctrine.GetIgnorePlottedCourseWhenAttackingDoctrine(this.m_ActiveUnit.m_Scenario, false, null, false, false);
							byte? b = ignorePlottedCourseWhenAttackingDoctrine.HasValue ? new byte?((byte)ignorePlottedCourseWhenAttackingDoctrine.GetValueOrDefault()) : null;
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								if (this.m_ActiveUnit.HasAssignedPatrolMission())
								{
									Patrol patrol = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
									if (!this.m_ActiveUnit.GetNavigator().HasManualPlottedCourse() && !this.m_ActiveUnit.GetNavigator().method_30(ref patrol.PatrolAreaVertices, ref patrol.list_14, ref patrol.list_10, 30f, false))
									{
										this.m_ActiveUnit.GetNavigator().ClearPlottedCourse();
										this.m_ActiveUnit.GetNavigator().SetDesiredHeading();
									}
								}
								this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
								int value2 = (int)this.m_ActiveUnit.m_Doctrine.GetRechargeBatteryPercentageDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false).Value;
								if (!this.IsRechargingBatteries((float)value2, true, false))
								{
									if (Information.IsNothing(this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride()))
									{
										if (this.GetParentPlatform().HasAssignedPatrolMission())
										{
											if (base.IsOnPatrolStation())
											{
												this.m_ActiveUnit.SetThrottle(((Patrol)this.m_ActiveUnit.GetAssignedMission(false)).StationThrottle_Submarine, null);
											}
											else
											{
												this.m_ActiveUnit.SetThrottle(((Patrol)this.m_ActiveUnit.GetAssignedMission(false)).TransitThrottle_Submarine, null);
											}
										}
										else if (this.GetParentPlatform().HasAssignedMineClearingMission())
										{
											MineClearingMission mineClearingMission = (MineClearingMission)this.m_ActiveUnit.GetAssignedMission(false);
											if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref mineClearingMission.AreaVertices, ref mineClearingMission.list_11, ref mineClearingMission.list_7, 2, false, false))
											{
												this.m_ActiveUnit.SetThrottle(mineClearingMission.StationThrottle_Submarine, null);
											}
											else
											{
												this.m_ActiveUnit.SetThrottle(mineClearingMission.TransitThrottle_Submarine, null);
											}
										}
										else if (this.GetParentPlatform().IsROV())
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
										}
										else
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
										}
									}
									else
									{
										this.m_ActiveUnit.SetThrottle(this.GetParentPlatform().GetSubmarineKinematics().vmethod_38(this.m_ActiveUnit.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().Value))), new float?((float)((int)Math.Round((double)this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().Value))));
									}
								}
								if (this.GetParentPlatform().GetDockingOps().GetDockingOpsCondition() != ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
								{
									this.SetDesiredDepth(true);
								}
								return;
							}
						}
						if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
						{
							if (!Information.IsNothing(this.GetPrimaryTarget()))
							{
								Contact_Base.ContactType contactType = this.GetPrimaryTarget().contactType;
								if (contactType > Contact_Base.ContactType.Missile && contactType != Contact_Base.ContactType.Orbital)
								{
									this.vmethod_18(elapsedTime_);
								}
								float? num2 = null;
								float num3 = 3.40282347E+38f;
								int value3 = (int)this.m_ActiveUnit.m_Doctrine.GetRechargeBatteryPercentageDoc(this.m_ActiveUnit.m_Scenario, false, false, false).Value;
								Patrol patrol2 = null;
								if (!this.IsRechargingBatteries((float)value3, true, true) && !this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
								{
									ActiveUnit.Throttle? throttle = null;
									if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
									{
										patrol2 = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
										if (!Information.IsNothing(patrol2.AttackThrottle_Submarine))
										{
											num2 = patrol2.AttackDistance_Submarine;
											if (!Information.IsNothing(num2))
											{
												num3 = this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
												if ((num2.HasValue ? new bool?(num3 > num2.GetValueOrDefault()) : null).GetValueOrDefault())
												{
													throttle = new ActiveUnit.Throttle?(patrol2.TransitThrottle_Submarine);
												}
												else
												{
													throttle = patrol2.AttackThrottle_Submarine;
												}
											}
											else
											{
												throttle = patrol2.AttackThrottle_Submarine;
											}
										}
									}
									if (!Information.IsNothing(throttle))
									{
										this.m_ActiveUnit.SetThrottle(throttle.Value, null);
									}
									else if (!this.GetPrimaryTarget().IsSurface() && !this.GetPrimaryTarget().IsSubSurface())
									{
										this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
									}
									else
									{
										int? num4 = base.method_51(this.GetPrimaryTarget().ActualUnit);
										if (this.GetPrimaryTarget().Heading_Known && this.GetPrimaryTarget().Speed_Known)
										{
											float num5 = Math.Abs(Class263.GetAngleBetween(this.GetParentPlatform().AzimuthTo(this.GetPrimaryTarget()), this.GetPrimaryTarget().GetCurrentHeading()));
											if (num5 < 20f)
											{
												if (num4.HasValue)
												{
													this.m_ActiveUnit.SetDesiredSpeed(Math.Max((float)num4.Value, this.GetPrimaryTarget().GetCurrentSpeed() * 2f + 1f));
												}
												else
												{
													this.m_ActiveUnit.SetDesiredSpeed(this.GetPrimaryTarget().GetCurrentSpeed() * 2f + 1f);
												}
												this.m_ActiveUnit.SetThrottle(this.m_ActiveUnit.GetKinematics().vmethod_38(this.m_ActiveUnit.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))), null);
											}
											else if (num5 < 90f)
											{
												if (num4.HasValue)
												{
													this.m_ActiveUnit.SetDesiredSpeed(Math.Max((float)num4.Value, this.GetPrimaryTarget().GetCurrentSpeed() * 2f + 1f));
												}
												else
												{
													this.m_ActiveUnit.SetDesiredSpeed((float)((double)this.GetPrimaryTarget().GetCurrentSpeed() * 1.5) + 1f);
												}
												this.m_ActiveUnit.SetThrottle(this.m_ActiveUnit.GetKinematics().vmethod_38(this.m_ActiveUnit.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))), null);
											}
											else if (num4.HasValue)
											{
												this.m_ActiveUnit.SetDesiredSpeed((float)num4.Value);
												this.m_ActiveUnit.SetThrottle(this.m_ActiveUnit.GetKinematics().vmethod_38(this.m_ActiveUnit.GetCurrentAltitude_ASL(false), (float)((int)Math.Round((double)this.m_ActiveUnit.GetDesiredSpeed()))), null);
											}
											else
											{
												this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
											}
										}
										else if (this.m_ActiveUnit.GetDesiredSpeed(this.GetPrimaryTarget(), this.m_ActiveUnit.GetCurrentSpeed(), this.m_ActiveUnit.GetCurrentHeading()) > 0f)
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Loiter, null);
										}
										else
										{
											this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Full, null);
										}
									}
								}
								if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride() && this.GetParentPlatform().GetDockingOps().GetDockingOpsCondition() != ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
								{
									float? num6 = null;
									if (!Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)) && this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
									{
										if (Information.IsNothing(patrol2))
										{
											patrol2 = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
										}
										if (!Information.IsNothing(patrol2.AttackDepth_Submarine))
										{
											if (Information.IsNothing(num2))
											{
												num2 = patrol2.AttackDistance_Submarine;
											}
											if (!Information.IsNothing(num2))
											{
												if (num3 == 3.40282347E+38f)
												{
													num3 = this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
												}
												if ((num2.HasValue ? new bool?(num3 > num2.GetValueOrDefault()) : null).GetValueOrDefault())
												{
													num6 = patrol2.TransitDepth_Submarine;
												}
												else
												{
													num6 = patrol2.AttackDepth_Submarine;
												}
											}
											else
											{
												num6 = patrol2.AttackDepth_Submarine;
											}
										}
									}
									if (!Information.IsNothing(num6))
									{
										float value4 = num6.Value;
										if (value4 >= -20f && !this.NeedRecharge(false, null))
										{
											this.m_ActiveUnit.SetDesiredAltitude(-40f);
										}
										else
										{
											this.m_ActiveUnit.SetDesiredAltitude(value4);
										}
									}
									else
									{
										if ((float)this.m_ActiveUnit.GetKinematics().GetSpeed(this.m_ActiveUnit.GetCurrentAltitude_ASL(false), this.m_ActiveUnit.GetThrottle()) < this.m_ActiveUnit.GetDesiredSpeed())
										{
											if (this.m_ActiveUnit.float_19 < 1800f && !this.NeedRecharge(false, null))
											{
												this.m_ActiveUnit.SetDesiredAltitude(-40f);
											}
											else
											{
												int num7 = 1;
												do
												{
													ActiveUnit.Throttle throttle2 = (ActiveUnit.Throttle)num7;
													int? num8 = ((Submarine_Kinematics)this.m_ActiveUnit.GetKinematics()).method_17(this.m_ActiveUnit.GetDesiredSpeed(), throttle2);
													float? num9 = num8.HasValue ? new float?((float)num8.GetValueOrDefault()) : null;
													if (num9.HasValue)
													{
														this.m_ActiveUnit.SetThrottle(throttle2, null);
														float? num10 = num9;
														if ((num10.HasValue ? new bool?(num10.GetValueOrDefault() < -40f) : null).GetValueOrDefault())
														{
															this.m_ActiveUnit.SetDesiredAltitude(num9.Value);
														}
													}
													num7++;
												}
												while (num7 <= 4);
											}
										}
										else
										{
											Contact_Base.ContactType contactType2 = this.GetPrimaryTarget().contactType;
											if (contactType2 != Contact_Base.ContactType.Surface)
											{
												if (contactType2 != Contact_Base.ContactType.Submarine)
												{
													this.m_ActiveUnit.SetDesiredAltitude(-40f);
												}
												else if (this.GetPrimaryTarget().Altitude_Known)
												{
													if (this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) > -40f)
													{
														this.m_ActiveUnit.SetDesiredAltitude(-40f);
													}
													else
													{
														this.m_ActiveUnit.SetDesiredAltitude(this.GetPrimaryTarget().GetCurrentAltitude_ASL(false));
													}
												}
												else
												{
													this.m_ActiveUnit.SetDesiredAltitude(-40f);
												}
											}
											else
											{
												this.m_ActiveUnit.SetDesiredAltitude(-40f);
											}
										}
										Weapon weapon = null;
										this.vmethod_22(elapsedTime_, ref weapon);
									}
								}
								else if (this.GetParentPlatform().GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
								{
									if (this.NeedRecharge(false, null))
									{
										if (this.m_ActiveUnit.GetDesiredAltitude() < -20f)
										{
											this.m_ActiveUnit.SetDesiredAltitude(-20f);
										}
									}
									else
									{
										Weapon weapon = null;
										this.vmethod_22(elapsedTime_, ref weapon);
									}
								}
								else
								{
									this.SetDesiredDepth(true);
								}
							}
						}
						else if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnPlottedCourse)
						{
							this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
							if (!this.m_ActiveUnit.GetNavigator().HasPlottedCourse() && this.m_ActiveUnit.GetKinematics().GetSpeedPreset() != ActiveUnit_Kinematics._SpeedPreset.FullStop && this.m_ActiveUnit.GetDesiredSpeed() != 0f)
							{
								this.m_ActiveUnit.GetKinematics().SetDesiredSpeedOverride(null);
								this.m_ActiveUnit.GetKinematics().SetSpeedPreset(ActiveUnit_Kinematics._SpeedPreset.None);
								this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.FullStop, null);
								this.m_ActiveUnit.SetUnitStatus(this.m_ActiveUnit.m_ActiveUnitStatus);
							}
							else if (this.GetParentPlatform().HasAssignedMiningMission())
							{
								this.method_101(elapsedTime_);
							}
							else
							{
								Patrol patrol2 = null;
								bool flag2 = false;
								MineClearingMission mineClearingMission = null;
								if (this.GetParentPlatform().HasAssignedPatrolMission())
								{
									patrol2 = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
									flag2 = this.m_ActiveUnit.GetNavigator().IsOnStation(ref patrol2.PatrolAreaVertices, ref patrol2.list_11, ref patrol2.list_7, 2, false, false);
								}
								else if (this.GetParentPlatform().HasAssignedMineClearingMission())
								{
									mineClearingMission = (MineClearingMission)this.m_ActiveUnit.GetAssignedMission(false);
									flag2 = this.m_ActiveUnit.GetNavigator().IsOnStation(ref mineClearingMission.AreaVertices, ref mineClearingMission.list_11, ref mineClearingMission.list_7, 2, false, false);
								}
								if (this.GetParentPlatform().GetDockingOps().GetDockingOpsCondition() != ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries && !this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
								{
									if (this.GetParentPlatform().HasAssignedPatrolMission())
									{
										if (flag2)
										{
											this.m_ActiveUnit.SetThrottle(patrol2.StationThrottle_Submarine, null);
										}
										else
										{
											this.m_ActiveUnit.SetThrottle(patrol2.TransitThrottle_Submarine, null);
										}
									}
									else if (this.GetParentPlatform().HasAssignedMineClearingMission())
									{
										if (flag2)
										{
											this.m_ActiveUnit.SetThrottle(mineClearingMission.StationThrottle_Submarine, null);
										}
										else
										{
											this.m_ActiveUnit.SetThrottle(mineClearingMission.TransitThrottle_Submarine, null);
										}
									}
									else
									{
										this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
										this.m_ActiveUnit.GetKinematics().method_13();
									}
								}
								int value5 = (int)this.m_ActiveUnit.m_Doctrine.GetRechargeBatteryPercentageDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false).Value;
								if (this.GetParentPlatform().GetDockingOps().GetDockingOpsCondition() != ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
								{
									if (this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
									{
										this.SetDesiredDepth(true);
									}
									else if (this.m_ActiveUnit.HasAssignedPatrolMission())
									{
										if (flag2)
										{
											if (!this.IsRechargingBatteries((float)value5, false, false))
											{
												if (patrol2.StationDepth_Submarine.HasValue)
												{
													float value6 = patrol2.StationDepth_Submarine.Value;
													if (value6 >= -20f && !this.NeedRecharge(false, null))
													{
														this.m_ActiveUnit.SetDesiredAltitude(-40f);
													}
													else
													{
														this.m_ActiveUnit.SetDesiredAltitude(value6);
													}
												}
												else
												{
													this.m_ActiveUnit.SetDesiredAltitude(-40f);
												}
											}
										}
										else if (!this.IsRechargingBatteries((float)value5, false, false))
										{
											if (patrol2.TransitDepth_Submarine.HasValue)
											{
												float value7 = patrol2.TransitDepth_Submarine.Value;
												if (value7 >= -20f && !this.NeedRecharge(false, null))
												{
													this.m_ActiveUnit.SetDesiredAltitude(Submarine_AI.GetJustOverLayerDepth(this.GetParentPlatform()));
												}
												else
												{
													this.m_ActiveUnit.SetDesiredAltitude(value7);
												}
											}
											else
											{
												this.GetParentPlatform().SetDesiredAltitude(Submarine_AI.GetJustOverLayerDepth(this.GetParentPlatform()));
											}
										}
									}
									else if (this.GetParentPlatform().HasAssignedMineClearingMission())
									{
										if (flag2)
										{
											if (!this.IsRechargingBatteries((float)value5, false, false))
											{
												if (mineClearingMission.StationDepth_Submarine.HasValue)
												{
													float value8 = mineClearingMission.StationDepth_Submarine.Value;
													if (value8 >= -20f && !this.NeedRecharge(false, null))
													{
														this.m_ActiveUnit.SetDesiredAltitude(-40f);
													}
													else
													{
														this.m_ActiveUnit.SetDesiredAltitude(value8);
													}
												}
												else
												{
													this.m_ActiveUnit.SetDesiredAltitude(-40f);
												}
											}
										}
										else if (!this.IsRechargingBatteries((float)value5, false, false))
										{
											if (mineClearingMission.TransitDepth_Submarine.HasValue)
											{
												float value9 = mineClearingMission.TransitDepth_Submarine.Value;
												if (value9 >= -20f && !this.NeedRecharge(false, null))
												{
													this.m_ActiveUnit.SetDesiredAltitude(Submarine_AI.GetJustOverLayerDepth(this.GetParentPlatform()));
												}
												else
												{
													this.m_ActiveUnit.SetDesiredAltitude(value9);
												}
											}
											else
											{
												this.GetParentPlatform().SetDesiredAltitude(Submarine_AI.GetJustOverLayerDepth(this.GetParentPlatform()));
											}
										}
									}
									else
									{
										this.GetParentPlatform().SetDesiredAltitude(Submarine_AI.GetJustOverLayerDepth(this.GetParentPlatform()));
									}
								}
							}
						}
						else
						{
							if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.Tasked)
							{
								if (this.IsEscort)
								{
									base.method_15();
									return;
								}
								if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Mining)
								{
									this.method_101(elapsedTime_);
									return;
								}
								if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.MineClearing)
								{
									Submarine_AI.MineClearingMissionAI mineClearingMissionAI = new Submarine_AI.MineClearingMissionAI(null);
									mineClearingMissionAI.submarine_AI = this;
									MineClearingMission mineClearingMission2 = (MineClearingMission)this.m_ActiveUnit.GetAssignedMission(false);
									mineClearingMissionAI.MinesDictionary = this.m_ActiveUnit.m_Scenario.GetUnguidedWeapons();
									mineClearingMissionAI.MineClearingArea = mineClearingMission2.AreaVertices;
									if (this.m_ActiveUnit.HasMineNeutralizations())
									{
										Submarine_AI.MineClearingAI mineClearingAI = new Submarine_AI.MineClearingAI(null);
										mineClearingAI.mineClearingMissionAI = mineClearingMissionAI;
										mineClearingAI.mineBag = new ConcurrentBag<UnguidedWeapon>();
										Parallel.ForEach<string>(this.m_ActiveUnit.GetSide(false).Contacts_NonAU, new Action<string>(mineClearingAI.TryToAddMine));
										UnguidedWeapon unguidedWeapon = null;
										float num11 = 0f;
										if (mineClearingAI.mineBag.Count > 0)
										{
											unguidedWeapon = mineClearingAI.mineBag.ToList<UnguidedWeapon>().Where(Submarine_AI.UnNullMap).OrderBy(new Func<UnguidedWeapon, double>(this.GetAngularDistance)).ElementAtOrDefault(0);
											num11 = this.m_ActiveUnit.GetHorizontalRange(unguidedWeapon);
										}
										if (this.GetParentPlatform().IsROV())
										{
											if ((double)num11 > (double)this.GetParentPlatform().ROVRadius / 1852.0 * 2.0)
											{
												mineClearingAI.mineBag = new ConcurrentBag<UnguidedWeapon>();
											}
											else
											{
												ActiveUnit assignedHostUnit = this.m_ActiveUnit.GetDockingOps().GetAssignedHostUnit(false);
												if (!Information.IsNothing(assignedHostUnit) && (double)assignedHostUnit.GetHorizontalRange(this.GetParentPlatform()) > (double)this.GetParentPlatform().ROVRadius / 1852.0)
												{
													mineClearingAI.mineBag = new ConcurrentBag<UnguidedWeapon>();
												}
											}
										}
										if (mineClearingAI.mineBag.Count > 0)
										{
											if (this.m_ActiveUnit.HasMineNeutralizations())
											{
												base.TryToClearTheMine(unguidedWeapon, num11);
											}
											else
											{
												base.NavigateToClearTheMine(unguidedWeapon, num11);
											}
											if ((double)num11 > 0.5)
											{
												this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
											}
											else
											{
												this.m_ActiveUnit.SetDesiredSpeed(num11 * 10f);
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
														if (!this.m_ActiveUnit.GetParentGroup(false).GetNavigator().method_30(ref mineClearingMission2.AreaVertices, ref mineClearingMission2.list_14, ref mineClearingMission2.list_10, 30f, false))
														{
															this.m_ActiveUnit.GetParentGroup(false).GetNavigator().HeadingToTheArea(mineClearingMission2.AreaVertices);
														}
														this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
													}
													else
													{
														this.m_ActiveUnit.GetParentGroup(false).GetNavigator().HeadingToTheArea(mineClearingMission2.AreaVertices);
													}
												}
												else if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
												{
													this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
												}
											}
											else if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
											{
												if (!this.m_ActiveUnit.GetNavigator().method_30(ref mineClearingMission2.AreaVertices, ref mineClearingMission2.list_14, ref mineClearingMission2.list_10, 30f, false))
												{
													this.m_ActiveUnit.GetNavigator().HeadingToTheArea(mineClearingMission2.AreaVertices);
												}
												this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
											}
											else
											{
												if (this.GetParentPlatform().IsROV())
												{
													ActiveUnit assignedHostUnit2 = this.GetParentPlatform().GetDockingOps().GetAssignedHostUnit(false);
													if (Information.IsNothing(assignedHostUnit2))
													{
														goto IL_1BDE;
													}
													try
													{
														if (this.m_ActiveUnit.GetHorizontalRange(assignedHostUnit2) * 1852f > (float)((Submarine)this.m_ActiveUnit).ROVRadius)
														{
															this.GetParentPlatform().SetDesiredHeading(ActiveUnit._TurnRate.const_1, this.GetParentPlatform().AzimuthTo(assignedHostUnit2));
														}
														else if (this.m_ActiveUnit.m_Scenario.FifteenthMinuteIsChangingOnThisPulse)
														{
															int num12 = GameGeneral.GetRandom().Next((int)Math.Round((double)Math2.Normalize(assignedHostUnit2.GetCurrentHeading() - 45f)), (int)Math.Round((double)Math2.Normalize(assignedHostUnit2.GetCurrentHeading() + 46f)));
															double lon = 0.0;
															double lat = 0.0;
															GeoPointGenerator.GetOtherGeoPoint(assignedHostUnit2.GetLongitude(null), assignedHostUnit2.GetLatitude(null), ref lon, ref lat, (double)((float)((double)this.GetParentPlatform().ROVRadius / 1852.0)), (double)num12);
															this.GetParentPlatform().SetDesiredHeading(ActiveUnit._TurnRate.const_1, Math2.GetAzimuth(this.GetParentPlatform().GetLatitude(null), this.GetParentPlatform().GetLongitude(null), lat, lon));
														}
														goto IL_1BDE;
													}
													catch (Exception projectError)
													{
														ProjectData.SetProjectError(projectError);
														ProjectData.ClearProjectError();
														goto IL_1BDE;
													}
												}
												this.m_ActiveUnit.GetNavigator().HeadingToTheArea(mineClearingMission2.AreaVertices);
											}
											IL_1BDE:
											if (!this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
											{
												if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref mineClearingMission2.AreaVertices, ref mineClearingMission2.list_11, ref mineClearingMission2.list_7, 2, false, false))
												{
													if (this.GetParentPlatform().IsROV())
													{
														this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Flank, null);
													}
													else
													{
														this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Loiter, null);
													}
												}
												else
												{
													this.m_ActiveUnit.SetThrottle(ActiveUnit.Throttle.Cruise, null);
												}
											}
										}
									}
									else if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
									{
										if (!this.m_ActiveUnit.GetNavigator().method_30(ref mineClearingMission2.AreaVertices, ref mineClearingMission2.list_14, ref mineClearingMission2.list_10, 30f, false))
										{
											this.m_ActiveUnit.GetNavigator().HeadingToTheArea(mineClearingMission2.AreaVertices);
										}
										this.m_ActiveUnit.GetNavigator().vmethod_7(elapsedTime_);
									}
									else
									{
										this.m_ActiveUnit.GetNavigator().HeadingToTheArea(mineClearingMission2.AreaVertices);
									}
									return;
								}
							}
							if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnPatrol)
							{
								if (Information.IsNothing(this.m_ActiveUnit.GetAssignedMission(false)))
								{
									activeUnitStatus = ActiveUnit._ActiveUnitStatus.Unassigned;
								}
								else if (this.m_ActiveUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
								{
									Patrol patrol3 = (Patrol)this.m_ActiveUnit.GetAssignedMission(false);
									if (Information.IsNothing(patrol3))
									{
										activeUnitStatus = ActiveUnit._ActiveUnitStatus.Unassigned;
									}
									else
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
										if (!this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
										{
											this.m_ActiveUnit.GetKinematics().method_13();
										}
									}
									int value = (int)this.m_ActiveUnit.m_Doctrine.GetRechargeBatteryPercentageDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false).Value;
									if (!this.IsRechargingBatteries((float)value, false, false) && !this.GetParentPlatform().GetSubmarineKinematics().GetDesiredAltitudeOverride())
									{
										this.SetPatrolDepth(elapsedTime_);
									}
								}
							}
							if (activeUnitStatus == ActiveUnit._ActiveUnitStatus.OnSupportMission)
							{
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
											if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
											{
												this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
											}
											int value10 = (int)this.m_ActiveUnit.m_Doctrine.GetRechargeBatteryPercentageDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false).Value;
											this.IsRechargingBatteries((float)value10, false, false);
										}
									}
									else
									{
										this.m_ActiveUnit.GetNavigator().vmethod_6(elapsedTime_, this.m_ActiveUnit.GetNavigator().method_11());
									}
								}
							}
							else if (this.m_ActiveUnit.HasParentGroup())
							{
								if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
								{
									this.m_ActiveUnit.GetNavigator().FollowGroupLead(elapsedTime_);
								}
								int value11 = (int)this.m_ActiveUnit.m_Doctrine.GetRechargeBatteryPercentageDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false).Value;
								this.IsRechargingBatteries((float)value11, false, false);
							}
							else if (this.m_ActiveUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Unassigned)
							{
								if (!this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue)
								{
									this.m_ActiveUnit.SetDesiredSpeed(0f);
								}
								if (this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
								{
									this.SetDesiredDepth(true);
								}
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
								if (!Information.IsNothing(this.m_ActiveUnit))
								{
									int value = (int)this.m_ActiveUnit.m_Doctrine.GetRechargeBatteryPercentageDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false).Value;
									this.IsRechargingBatteries((float)value, true, false);
								}
							}
						}
						else
						{
							this.m_ActiveUnit.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.RTB);
							this.vmethod_27(elapsedTime_);
							int value12 = (int)this.m_ActiveUnit.m_Doctrine.GetRechargeBatteryPercentageDoctrine(this.m_ActiveUnit.m_Scenario, false, false, false).Value;
							this.IsRechargingBatteries((float)value12, true, false);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100825", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005C50 RID: 23632 RVA: 0x002A7E98 File Offset: 0x002A6098
		private void method_101(float float_2)
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
						this.m_ActiveUnit.GetNavigator().vmethod_7(float_2);
					}
					else
					{
						this.m_ActiveUnit.GetParentGroup(false).GetNavigator().HeadingToTheArea(miningMission.AreaVertices);
					}
				}
				else if (this.m_ActiveUnit.GetCommStuff().IsNotOutOfComms())
				{
					this.m_ActiveUnit.GetNavigator().FollowGroupLead(float_2);
				}
			}
			else if (this.m_ActiveUnit.GetNavigator().HasWaypointOtherPathfindingPoint())
			{
				if (!this.m_ActiveUnit.GetNavigator().method_30(ref miningMission.AreaVertices, ref miningMission.list_16, ref miningMission.list_11, 30f, false))
				{
					this.m_ActiveUnit.GetNavigator().HeadingToTheArea(miningMission.AreaVertices);
				}
				this.m_ActiveUnit.GetNavigator().vmethod_7(float_2);
			}
			else
			{
				this.m_ActiveUnit.GetNavigator().HeadingToTheArea(miningMission.AreaVertices);
			}
			if (Information.IsNothing(this.GetParentPlatform().GetSubmarineKinematics().GetDesiredSpeedOverride()))
			{
				if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref miningMission.AreaVertices, ref miningMission.list_13, ref miningMission.list_8, 2, false, false))
				{
					this.m_ActiveUnit.SetThrottle(miningMission.StationThrottle_Submarine, null);
				}
				else
				{
					this.m_ActiveUnit.SetThrottle(miningMission.TransitThrottle_Submarine, null);
				}
			}
			if (this.GetParentPlatform().GetSubmarineKinematics().GetDesiredAltitudeOverride())
			{
				this.GetParentPlatform().SetDesiredAltitude(Submarine_AI.GetJustOverLayerDepth(this.GetParentPlatform()));
			}
			else if (this.m_ActiveUnit.GetNavigator().IsOnStation(ref miningMission.AreaVertices, ref miningMission.list_13, ref miningMission.list_8, 2, false, false))
			{
				if (miningMission.StationDepth_Submarine.HasValue)
				{
					float value = miningMission.StationDepth_Submarine.Value;
					if (value >= -20f && !this.NeedRecharge(false, null))
					{
						this.m_ActiveUnit.SetDesiredAltitude(-40f);
					}
					else
					{
						this.m_ActiveUnit.SetDesiredAltitude(value);
					}
				}
				else if (this.m_ActiveUnit.float_19 < 1800f && !this.NeedRecharge(false, null))
				{
					this.m_ActiveUnit.SetDesiredAltitude(-40f);
				}
				else
				{
					this.m_ActiveUnit.SetDesiredAltitude(-20f);
				}
			}
			else if (!miningMission.TransitDepth_Submarine.HasValue)
			{
				this.GetParentPlatform().SetDesiredAltitude(Submarine_AI.GetJustOverLayerDepth(this.GetParentPlatform()));
			}
			else
			{
				float value2 = miningMission.TransitDepth_Submarine.Value;
				if (value2 >= -20f && !this.NeedRecharge(false, null))
				{
					this.m_ActiveUnit.SetDesiredAltitude(Submarine_AI.GetJustOverLayerDepth(this.GetParentPlatform()));
				}
				else
				{
					this.m_ActiveUnit.SetDesiredAltitude(value2);
				}
			}
		}

        // Token: 0x06005C51 RID: 23633 RVA: 0x002A821C File Offset: 0x002A641C
        public override void vmethod_22(float float_2, ref Weapon weapon_)
		{
			if (!Information.IsNothing(this.m_ActiveUnit) && !Information.IsNothing(this.GetPrimaryTarget()))
			{
				try
				{
					Submarine_AI.MaxWeaponRangeGetter maxWeaponRangeGetter = new Submarine_AI.MaxWeaponRangeGetter();
					maxWeaponRangeGetter.submarine_AI = this;
					maxWeaponRangeGetter.doctrine = this.m_ActiveUnit.m_Doctrine;
					if (Information.IsNothing(weapon_))
					{
						Side side = this.m_ActiveUnit.GetSide(false);
						Contact primaryTarget = this.GetPrimaryTarget();
						List<Weapon> weaponsForTarget = side.GetWeaponsForTarget(ref this.m_ActiveUnit, ref primaryTarget);
						this.SetPrimaryTarget(primaryTarget);
						List<Weapon> list = weaponsForTarget;
						if (list.Count > 0)
						{
							weapon_ = list.OrderByDescending(new Func<Weapon, float>(maxWeaponRangeGetter.GetMaxRangeToTarget)).ElementAtOrDefault(0);
						}
						else
						{
							weapon_ = this.m_ActiveUnit.GetWeaponry().method_19(this.GetPrimaryTarget(), false, true, maxWeaponRangeGetter.doctrine);
						}
					}
					if (!Information.IsNothing(weapon_))
					{
						float maxRangeToTarget = weapon_.GetMaxRangeToTarget(this.m_ActiveUnit, this.GetPrimaryTarget(), true, maxWeaponRangeGetter.doctrine, false);
						float horizontalRange = this.m_ActiveUnit.GetHorizontalRange(this.GetPrimaryTarget());
						if (!this.m_ActiveUnit.GetKinematics().GetDesiredAltitudeOverride())
						{
							float float_3;
							if (this.GetPrimaryTarget().GetCurrentSpeed() == 0f)
							{
								float_3 = this.m_ActiveUnit.GetCurrentSpeed();
							}
							else
							{
								float_3 = this.m_ActiveUnit.GetDesiredSpeed(this.GetPrimaryTarget(), this.m_ActiveUnit.GetCurrentSpeed(), this.m_ActiveUnit.GetCurrentHeading());
							}
							Weapon._WeaponType weaponType = weapon_.GetWeaponType();
							float num = 0f;
							if (weaponType != Weapon._WeaponType.Rocket && weaponType != Weapon._WeaponType.Gun)
							{
								if (weapon_.m_Scenario.FeatureCompatibility.get_WeaponAGL_ASL(weapon_.m_Scenario.GetSQLiteConnection()) && weapon_.LaunchAltitudeMin == 0f && weapon_.LaunchAltitudeMax == 0f)
								{
									num = weapon_.LaunchAltitudeMin_ASL;
								}
								else
								{
									num = weapon_.LaunchAltitudeMin;
								}
							}
							else if (this.m_ActiveUnit.GetSlantRange(this.GetPrimaryTarget(), 0f) > maxRangeToTarget)
							{
								num = (float)(Math.Sqrt(2.0) / 2.0 * (double)maxRangeToTarget * 1852.0);
							}
							float num2 = 0f;
							if (num < this.m_ActiveUnit.GetDesiredAltitude())
							{
								num2 = (this.m_ActiveUnit.GetDesiredAltitude() - num) / this.m_ActiveUnit.GetKinematics().vmethod_19();
							}
							float num3;
							if (horizontalRange > maxRangeToTarget)
							{
								float float_4 = horizontalRange - maxRangeToTarget;
								num3 = this.m_ActiveUnit.method_49(float_3, float_4);
							}
							else
							{
								num3 = 0f;
							}
							if (num3 < 0f)
							{
								return;
							}
							if (num2 >= num3)
							{
								if (num < this.m_ActiveUnit.GetDesiredAltitude())
								{
									if (this.GetPrimaryTarget().Altitude_Known)
									{
										if (this.GetPrimaryTarget().GetCurrentAltitude_ASL(false) < num && this.m_ActiveUnit.GetDesiredAltitude() < num)
										{
											this.m_ActiveUnit.SetDesiredAltitude(num);
										}
									}
									else if (this.m_ActiveUnit.GetDesiredAltitude() > -20f)
									{
										this.m_ActiveUnit.SetDesiredAltitude(-20f);
									}
								}
								else if (num > this.m_ActiveUnit.GetDesiredAltitude())
								{
									this.m_ActiveUnit.SetDesiredAltitude(num);
								}
							}
						}
						if (!this.m_ActiveUnit.GetKinematics().GetDesiredSpeedOverride().HasValue && (double)maxRangeToTarget * 1.2 < (double)horizontalRange)
						{
							if (weapon_.LaunchSpeedMax != 0 && (float)weapon_.LaunchSpeedMax < this.m_ActiveUnit.GetCurrentSpeed())
							{
								this.m_ActiveUnit.SetDesiredSpeed((float)weapon_.LaunchSpeedMax);
							}
							if (weapon_.LaunchSpeedMin != 0 && (float)weapon_.LaunchSpeedMin > this.m_ActiveUnit.GetCurrentSpeed())
							{
								this.m_ActiveUnit.SetDesiredSpeed((float)weapon_.LaunchSpeedMin);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100826", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005C52 RID: 23634 RVA: 0x0002392B File Offset: 0x00021B2B
		[CompilerGenerated]
		private bool IsAffectedBy(NoNavZone noNavZone_)
		{
			return noNavZone_.IsAffected(this.m_ActiveUnit);
		}

		// Token: 0x06005C53 RID: 23635 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double GetAngularDistance(Contact contact_)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(contact_);
		}

		// Token: 0x06005C54 RID: 23636 RVA: 0x001CD838 File Offset: 0x001CBA38
		[CompilerGenerated]
		private double GetAngularDistance(UnguidedWeapon unguidedWeapon_)
		{
			return this.m_ActiveUnit.GetApproxAngularDistanceInDegrees(unguidedWeapon_);
		}

		// Token: 0x0400309A RID: 12442
		public static Func<Engine, bool> IsElectricPropulsion = (Engine engine_0) => engine_0.PropulsionType == Engine._PropulsionType.Electric;

		// Token: 0x0400309B RID: 12443
		public static Func<Contact, bool> TargetIsWeapon = (Contact contact_0) => !Information.IsNothing(contact_0.ActualUnit) && contact_0.ActualUnit.IsWeapon;

		// Token: 0x0400309C RID: 12444
		public static Func<Contact, Contact> IdentityMap = (Contact contact_0) => contact_0;

		// Token: 0x0400309D RID: 12445
		public static Func<FuelRec, bool> IsDieselFuel = (FuelRec fuelRec_0) => fuelRec_0.FuelType == FuelRec._FuelType.DieselFuel;

		// Token: 0x0400309E RID: 12446
		public static Func<FuelRec, bool> IsAirIndepedent = (FuelRec fuelRec_0) => fuelRec_0.FuelType == FuelRec._FuelType.AirIndepedent;

		// Token: 0x0400309F RID: 12447
		public static Func<FuelRec, bool> IsBattery = (FuelRec fuelRec_0) => fuelRec_0.FuelType == FuelRec._FuelType.Battery;

		// Token: 0x040030A0 RID: 12448
		public static Func<UnguidedWeapon, bool> UnNullMap = (UnguidedWeapon unguidedWeapon_0) => !Information.IsNothing(unguidedWeapon_0);

		// Token: 0x040030A1 RID: 12449
		private float timeToChangeDepth;

		// Token: 0x040030A2 RID: 12450
		private ActiveUnit_AI._DepthPreset m_DepthPreset;

		// Token: 0x040030A3 RID: 12451
		private Submarine ParentSub;

		// Token: 0x040030A4 RID: 12452
		protected Contact LastPrimaryThreat;

		// Token: 0x02000B33 RID: 2867
		[CompilerGenerated]
		public sealed class MineClearingMissionAI
		{
			// Token: 0x06005C5D RID: 23645 RVA: 0x00029490 File Offset: 0x00027690
			public MineClearingMissionAI(Submarine_AI.MineClearingMissionAI MinesMan_)
			{
				if (MinesMan_ != null)
				{
					this.MinesDictionary = MinesMan_.MinesDictionary;
					this.MineClearingArea = MinesMan_.MineClearingArea;
				}
			}

			// Token: 0x040030AC RID: 12460
			public ObservableDictionary<string, UnguidedWeapon> MinesDictionary;

			// Token: 0x040030AD RID: 12461
			public List<ReferencePoint> MineClearingArea;

			// Token: 0x040030AE RID: 12462
			public Submarine_AI submarine_AI;
		}

		// Token: 0x02000B34 RID: 2868
		[CompilerGenerated]
		public sealed class MineClearingAI
		{
			// Token: 0x06005C5E RID: 23646 RVA: 0x000294B6 File Offset: 0x000276B6
			public MineClearingAI(Submarine_AI.MineClearingAI MineClearingAI_)
			{
				if (MineClearingAI_ != null)
				{
					this.mineBag = MineClearingAI_.mineBag;
				}
			}

			// Token: 0x06005C5F RID: 23647 RVA: 0x002A8788 File Offset: 0x002A6988
			internal void TryToAddMine(string MineGUID)
			{
				UnguidedWeapon unguidedWeapon = null;
				this.mineClearingMissionAI.MinesDictionary.TryGetValue(MineGUID, ref unguidedWeapon);
				if (!Information.IsNothing(unguidedWeapon) && unguidedWeapon.IsMine() && unguidedWeapon.vmethod_40(this.mineClearingMissionAI.MineClearingArea, this.mineClearingMissionAI.submarine_AI.m_ActiveUnit.m_Scenario, true))
				{
					this.mineBag.Add(unguidedWeapon);
				}
			}

			// Token: 0x040030AF RID: 12463
			public ConcurrentBag<UnguidedWeapon> mineBag;

			// Token: 0x040030B0 RID: 12464
			public Submarine_AI.MineClearingMissionAI mineClearingMissionAI;
		}

		// Token: 0x02000B35 RID: 2869
		[CompilerGenerated]
		public sealed class MaxWeaponRangeGetter
		{
			// Token: 0x06005C60 RID: 23648 RVA: 0x002A87F8 File Offset: 0x002A69F8
			internal float GetMaxRangeToTarget(Weapon theWeapon)
			{
				return theWeapon.GetMaxRangeToTarget(this.submarine_AI.m_ActiveUnit, this.submarine_AI.GetPrimaryTarget(), true, this.doctrine, false);
			}

			// Token: 0x040030B1 RID: 12465
			public Doctrine doctrine;

			// Token: 0x040030B2 RID: 12466
			public Submarine_AI submarine_AI;
		}
	}
}

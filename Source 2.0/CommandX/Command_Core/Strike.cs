using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace Command_Core
{
	// Token: 攻击使命
	public sealed class Strike : Mission
	{
		// Token: 0x06005B94 RID: 23444 RVA: 0x00291608 File Offset: 0x0028F808
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Strike");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("Category", ((byte)this.category).ToString());
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Type";
				int num = (int)this.strikeType;
				xmlWriter.WriteElementString(localName, num.ToString());
				this.m_Doctrine.Save(ref xmlWriter_0, ref scenario_0, "Doctrine");
				this.Doctrine_Escorts.Save(ref xmlWriter_0, ref scenario_0, "Doctrine_Escorts");
				if (this.START.HasValue)
				{
					xmlWriter_0.WriteElementString("START", this.START.Value.ToBinary().ToString());
				}
				if (this.END.HasValue)
				{
					xmlWriter_0.WriteElementString("END", this.END.Value.ToBinary().ToString());
				}
				if (this.TakeOffTime.HasValue)
				{
					xmlWriter_0.WriteElementString("TakeOffTime", this.TakeOffTime.Value.ToBinary().ToString());
				}
				if (this.TimeOnTarget.HasValue)
				{
					xmlWriter_0.WriteElementString("TimeOnTarget", this.TimeOnTarget.Value.ToBinary().ToString());
				}
				xmlWriter_0.WriteElementString("Deactivation_UnassignUnits", this.Deactivation_UnassignUnits.ToString());
				xmlWriter_0.WriteElementString("CheckBox_OrderRTB", this.CheckBox_OrderRTB.ToString());
				xmlWriter_0.WriteElementString("CheckBox_DeleteMission", this.CheckBox_DeleteMission.ToString());
				xmlWriter_0.WriteElementString("SISIH", this.SISIH.ToString());
				xmlWriter_0.WriteStartElement("SpecificTargets");
				foreach (Unit current in this.SpecificTargets)
				{
					if (!Information.IsNothing(current))
					{
						xmlWriter_0.WriteElementString("ID", current.GetGuid());
					}
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteElementString("MCSTT", Conversions.ToString((byte)this.MinimumContactStanceToTrigger));
				if (base.GetMissionStatus(scenario_0) != Mission._MissionStatus.Activation)
				{
					xmlWriter_0.WriteElementString("Status", ((byte)base.GetMissionStatus(scenario_0)).ToString());
				}
				if (this.UseAutoPlanner)
				{
					xmlWriter_0.WriteElementString("UP", this.UseAutoPlanner.ToString());
				}
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "FlightSize";
				num = (int)this.m_FlightSize;
				xmlWriter2.WriteElementString(localName2, num.ToString());
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "GroupSize";
				num = (int)this.m_GroupSize;
				xmlWriter3.WriteElementString(localName3, num.ToString());
				XmlWriter xmlWriter4 = xmlWriter_0;
				string localName4 = "Formation_Cruise";
				num = (int)this.Formation_Cruise;
				xmlWriter4.WriteElementString(localName4, num.ToString());
				XmlWriter xmlWriter5 = xmlWriter_0;
				string localName5 = "Formation_Attack";
				num = (int)this.Formation_Attack;
				xmlWriter5.WriteElementString(localName5, num.ToString());
				XmlWriter xmlWriter6 = xmlWriter_0;
				string localName6 = "Bingo";
				num = (int)this.Bingo;
				xmlWriter6.WriteElementString(localName6, num.ToString());
				XmlWriter xmlWriter7 = xmlWriter_0;
				string localName7 = "Escort_FlightSize_Shooter";
				num = (int)this.Escort_FlightSize_Shooter;
				xmlWriter7.WriteElementString(localName7, num.ToString());
				XmlWriter xmlWriter8 = xmlWriter_0;
				string localName8 = "Escort_FlightSize_NonShooter";
				num = (int)this.Escort_FlightSize_NonShooter;
				xmlWriter8.WriteElementString(localName8, num.ToString());
				XmlWriter xmlWriter9 = xmlWriter_0;
				string localName9 = "Escort_Formation_Cruise";
				num = (int)this.Escort_Formation_Cruise;
				xmlWriter9.WriteElementString(localName9, num.ToString());
				XmlWriter xmlWriter10 = xmlWriter_0;
				string localName10 = "Escort_Formation_Attack";
				num = (int)this.Escort_Formation_Attack;
				xmlWriter10.WriteElementString(localName10, num.ToString());
				if (this.Escort_TransitThrottle.HasValue)
				{
					xmlWriter_0.WriteElementString("Escort_TransitThrottle", ((byte)this.Escort_TransitThrottle.Value).ToString());
				}
				if (this.Escort_StationThrottle.HasValue)
				{
					xmlWriter_0.WriteElementString("Escort_StationThrottle", ((byte)this.Escort_StationThrottle.Value).ToString());
				}
				if (this.Escort_TransitAltitude.HasValue)
				{
					xmlWriter_0.WriteElementString("Escort_TransitAltitude", this.Escort_TransitAltitude.Value.ToString());
				}
				if (this.Escort_StationAltitude.HasValue)
				{
					xmlWriter_0.WriteElementString("Escort_StationAltitude", this.Escort_StationAltitude.Value.ToString());
				}
				xmlWriter_0.WriteElementString("Escort_TransitTerrainFollowing", this.Escort_TransitTerrainFollowing.ToString());
				xmlWriter_0.WriteElementString("Escort_AttackTerrainFollowing", this.Escort_AttackTerrainFollowing.ToString());
				xmlWriter_0.WriteElementString("Escort_ResponseRadius", this.Escort_ResponseRadius.ToString());
				XmlWriter xmlWriter11 = xmlWriter_0;
				string localName11 = "Escort_GroupSize";
				num = (int)this.Escort_GroupSize;
				xmlWriter11.WriteElementString(localName11, num.ToString());
				XmlWriter xmlWriter12 = xmlWriter_0;
				string localName12 = "MinAircraftReq_Strikers";
				num = (int)this.MinAircraftReq_Strikers;
				xmlWriter12.WriteElementString(localName12, num.ToString());
				XmlWriter xmlWriter13 = xmlWriter_0;
				string localName13 = "MaxAircraftToFly_Strikers";
				num = (int)this.MaxAircraftToFly_Strikers;
				xmlWriter13.WriteElementString(localName13, num.ToString());
				XmlWriter xmlWriter14 = xmlWriter_0;
				string localName14 = "MinAircraftReq_Escorts_Shooter";
				num = (int)this.MinAircraftReq_Escorts_Shooter;
				xmlWriter14.WriteElementString(localName14, num.ToString());
				XmlWriter xmlWriter15 = xmlWriter_0;
				string localName15 = "MaxAircraftToFly_Escort_Shooter";
				num = (int)this.MaxAircraftToFly_Escort_Shooter;
				xmlWriter15.WriteElementString(localName15, num.ToString());
				XmlWriter xmlWriter16 = xmlWriter_0;
				string localName16 = "MinAircraftReq_Escorts_NonShooter";
				num = (int)this.MinAircraftReq_Escorts_NonShooter;
				xmlWriter16.WriteElementString(localName16, num.ToString());
				XmlWriter xmlWriter17 = xmlWriter_0;
				string localName17 = "MaxAircraftToFly_Escort_NonShooter";
				num = (int)this.MaxAircraftToFly_Escort_NonShooter;
				xmlWriter17.WriteElementString(localName17, num.ToString());
				xmlWriter_0.WriteElementString("MinResponseRadius", this.MinResponseRadius.ToString());
				xmlWriter_0.WriteElementString("MaxResponseRadius", this.MaxResponseRadius.ToString());
				xmlWriter_0.WriteElementString("PrePlannedOnly", this.PrePlannedOnly.ToString());
				xmlWriter_0.WriteElementString("OneTimeOnly", this.OneTimeOnly.ToString());
				xmlWriter_0.WriteElementString("OneTimeOnlyFlown", this.OneTimeOnlyFlown.ToString());
				XmlWriter xmlWriter18 = xmlWriter_0;
				string localName18 = "RadarBehaviour";
				num = (int)this.RadarBehaviour;
				xmlWriter18.WriteElementString(localName18, num.ToString());
				XmlWriter xmlWriter19 = xmlWriter_0;
				string localName19 = "AttackMethod";
				num = (int)this.AttackMethod;
				xmlWriter19.WriteElementString(localName19, num.ToString());
				XmlWriter xmlWriter20 = xmlWriter_0;
				string localName20 = "SplitDistance";
				num = (int)this.SplitDistance;
				xmlWriter20.WriteElementString(localName20, num.ToString());
				xmlWriter_0.WriteElementString("UseFlightSizeHardLimit", this.UseFlightSizeHardLimit.ToString());
				xmlWriter_0.WriteElementString("UseFlightSizeHardLimit_Escort", this.UseFlightSizeHardLimit_Escort.ToString());
				xmlWriter_0.WriteElementString("UseGroupSizeHardLimit", this.UseGroupSizeHardLimit.ToString());
				xmlWriter_0.WriteElementString("UseGroupSizeHardLimit_Escort", this.UseGroupSizeHardLimit_Escort.ToString());
				XmlWriter xmlWriter21 = xmlWriter_0;
				string localName21 = "TankerUsage";
				byte tankerUsage = (byte)this.TankerUsage;
				xmlWriter21.WriteElementString(localName21, tankerUsage.ToString());
				xmlWriter_0.WriteStartElement("TankerMissionList");
				foreach (Mission current2 in this.TankerMissionList)
				{
					if (!Information.IsNothing(current2))
					{
						xmlWriter_0.WriteElementString("ID", current2.GetGuid());
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
				if (base.HasFlights())
				{
					Mission.Flight.Save(ref xmlWriter_0, ref hashSet_1, ref scenario_0, ref this.FlightList);
				}
				if (!Information.IsNothing(this.EmptySlotsList) && this.EmptySlotsList.Count > 0)
				{
					Mission.EmptySlot.Save(ref xmlWriter_0, ref hashSet_1, ref scenario_0, ref this.EmptySlotsList);
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100646", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x00291F24 File Offset: 0x00290124
		private Strike(Side side_0, Scenario scenario_0) : base(side_0, scenario_0)
		{
			this.SpecificTargets = new HashSet<Unit>();
			this.list_5 = new List<string>();
			Collection<ActiveUnit> collection = null;
			this.Doctrine_Escorts = new Doctrine(this, ref collection);
			this.AttackMethod = Mission._AttackMethod.const_0;
			this.SplitDistance = Mission._SplitDistance.const_1;
			this.IsMission = true;
			this.MissionClass = Mission._MissionClass.Strike;
		}

		// Token: 0x06005B96 RID: 23446 RVA: 0x00291F7C File Offset: 0x0029017C
		public static Strike Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			Strike strike2;
			Strike result;
			try
			{
				Strike strike = new Strike(null, scenario_0);
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 2367170728u)
						{
							if (num <= 1062263555u)
							{
								if (num <= 533572954u)
								{
									if (num <= 227845695u)
									{
										if (num <= 154642767u)
										{
											if (num != 6222351u)
											{
												if (num != 154642767u)
												{
													continue;
												}
												if (Operators.CompareString(name, "Escort_TransitAltitude", false) != 0)
												{
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name, "Status", false) == 0)
												{
													strike.SetMissionStatus(scenario_0, (Mission._MissionStatus)Conversions.ToByte(xmlNode.InnerText));
													continue;
												}
												continue;
											}
										}
										else if (num != 207389640u)
										{
											if (num == 227845695u && Operators.CompareString(name, "START", false) == 0)
											{
												DateTime value = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
												strike.SetStartTime(new DateTime?(value));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "OneTimeOnly", false) == 0)
											{
												strike.OneTimeOnly = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num <= 270724366u)
									{
										if (num != 266367750u)
										{
											if (num == 270724366u && Operators.CompareString(name, "RadarBehaviour", false) == 0)
											{
												strike.RadarBehaviour = (Mission._RadarBehaviour)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Name", false) == 0)
											{
												strike.Name = xmlNode.InnerText;
												continue;
											}
											continue;
										}
									}
									else if (num != 461095311u)
									{
										if (num == 533572954u && Operators.CompareString(name, "UseGroupSizeHardLimit", false) == 0)
										{
											strike.UseGroupSizeHardLimit = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "SISIH", false) == 0)
										{
											strike.SISIH = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 690973717u)
								{
									if (num <= 620569374u)
									{
										if (num != 540270923u)
										{
											if (num == 620569374u && Operators.CompareString(name, "TankerMinNumber_Airborne", false) == 0)
											{
												strike.TankerMinNumber_Airborne = Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name, "TAO", false) != 0)
										{
											continue;
										}
									}
									else if (num != 656819206u)
									{
										if (num == 690973717u && Operators.CompareString(name, "Escort_TransitTerrainFollowing", false) == 0)
										{
											strike.Escort_TransitTerrainFollowing = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "OAO", false) != 0)
										{
											continue;
										}
										goto IL_8E9;
									}
								}
								else if (num <= 721363522u)
								{
									if (num != 712696542u)
									{
										if (num == 721363522u && Operators.CompareString(name, "TankerMaxDistance_Airborne", false) == 0)
										{
											strike.TankerMaxDistance_Airborne = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Escort_FlightSize_Shooter", false) != 0)
										{
											continue;
										}
										goto IL_DF4;
									}
								}
								else if (num != 882301358u)
								{
									if (num != 1025497782u)
									{
										if (num == 1062263555u && Operators.CompareString(name, "EmptySlotsList", false) == 0)
										{
											strike.EmptySlotsList = Mission.EmptySlot.Load(ref xmlNode, ref dictionary_0, scenario_0);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TankerMinNumber_Total", false) == 0)
										{
											strike.TankerMinNumber_Total = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "LaunchMissionWithoutTankersInPlace", false) == 0)
									{
										strike.LaunchMissionWithoutTankersInPlace = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								strike.Escort_TransitAltitude = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
								continue;
							}
							if (num <= 1657676131u)
							{
								if (num <= 1299410445u)
								{
									if (num <= 1275005184u)
									{
										if (num != 1074512784u)
										{
											if (num == 1275005184u && Operators.CompareString(name, "Escort_GroupSize", false) == 0)
											{
												strike.Escort_GroupSize = (Mission._GroupSize)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "TimeOnTarget", false) == 0)
											{
												DateTime value2 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
												strike.SetTimeOnTarget(new DateTime?(value2));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (num != 1291489113u)
										{
											if (num != 1299410445u || Operators.CompareString(name, "SpecificTargets", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator2.MoveNext())
												{
													XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
													if (Operators.CompareString(xmlNode2.Name, "Contact", false) == 0)
													{
														Contact contact = Contact.GetContact(xmlNode2.InnerText, ref dictionary_0);
														strike.SpecificTargets.Add(contact);
													}
													else
													{
														strike.list_5.Add(xmlNode2.InnerText);
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
										if (Operators.CompareString(name, "Doctrine_Escorts", false) == 0)
										{
											strike.Doctrine_Escorts = Doctrine.SetDoctrineForMission(ref xmlNode, strike);
											continue;
										}
										continue;
									}
								}
								else if (num <= 1458105184u)
								{
									if (num != 1422437055u)
									{
										if (num != 1458105184u || Operators.CompareString(name, "ID", false) != 0)
										{
											continue;
										}
										if (!dictionary_0.ContainsKey(xmlNode.InnerText))
										{
											strike.SetGuid(xmlNode.InnerText);
											dictionary_0.Add(strike.GetGuid(), strike);
											continue;
										}
										strike2 = (Strike)dictionary_0[xmlNode.InnerText];
										result = strike2;
										return result;
									}
									else
									{
										if (Operators.CompareString(name, "Doctrine", false) == 0)
										{
											strike.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode, strike);
											continue;
										}
										continue;
									}
								}
								else if (num != 1579537194u)
								{
									if (num != 1606513349u)
									{
										if (num != 1657676131u)
										{
											continue;
										}
										if (Operators.CompareString(name, "PatrolThrottle", false) != 0)
										{
											continue;
										}
										goto IL_9BB;
									}
									else
									{
										if (Operators.CompareString(name, "Escort_TransitThrottle", false) == 0)
										{
											strike.Escort_TransitThrottle = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TakeOffTime", false) == 0)
									{
										DateTime value3 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										strike.SetTakeOffTime(new DateTime?(value3));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (num > 2104084864u)
								{
									if (num <= 2124323446u)
									{
										if (num != 2104796357u)
										{
											if (num != 2124323446u)
											{
												continue;
											}
											if (Operators.CompareString(name, "MCSTT", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "MinAircraftReq_Escorts", false) != 0)
											{
												continue;
											}
											goto IL_BC7;
										}
									}
									else if (num != 2180604875u)
									{
										if (num != 2235309636u)
										{
											if (num == 2367170728u && Operators.CompareString(name, "FuelQtyToStartLookingForTanker_Airborne", false) == 0)
											{
												strike.FuelQtyToStartLookingForTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name, "MinimumContactStanceToTrigger", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "FlightList", false) == 0)
										{
											strike.FlightList = Mission.Flight.Load(ref xmlNode, ref dictionary_0, scenario_0);
											continue;
										}
										continue;
									}
									strike.MinimumContactStanceToTrigger = (Misc.PostureStance)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								if (num <= 1688531320u)
								{
									if (num != 1660128160u)
									{
										if (num == 1688531320u && Operators.CompareString(name, "TankerMinNumber_Station", false) == 0)
										{
											strike.TankerMinNumber_Station = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "UP", false) == 0)
										{
											strike.UseAutoPlanner = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 1795334850u)
								{
									if (num != 2104084864u || Operators.CompareString(name, "Escort_StationAltitude", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "ST", false) != 0)
									{
										continue;
									}
									continue;
								}
							}
							IL_8E9:
							strike.Escort_StationAltitude = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
							continue;
						}
						if (num <= 3219336901u)
						{
							if (num <= 2667312101u)
							{
								if (num <= 2435049132u)
								{
									if (num <= 2409522962u)
									{
										if (num != 2398227942u)
										{
											if (num == 2409522962u && Operators.CompareString(name, "Escort_AttackTerrainFollowing", false) == 0)
											{
												strike.Escort_AttackTerrainFollowing = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name, "Escort_StationThrottle", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (num != 2423849325u)
										{
											if (num != 2435049132u || Operators.CompareString(name, "TankerMissionList", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator3.MoveNext())
												{
													XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
													strike.TankerMissionNameList.Add(xmlNode3.InnerText);
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
										if (Operators.CompareString(name, "MaxAircraftToFly_Strikers", false) == 0)
										{
											strike.MaxAircraftToFly_Strikers = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 2637572474u)
								{
									if (num != 2487526210u)
									{
										if (num == 2637572474u && Operators.CompareString(name, "MinResponseRadius", false) == 0)
										{
											strike.MinResponseRadius = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "FlightSize", false) == 0)
										{
											strike.m_FlightSize = (Mission._FlightSize)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 2649384959u)
								{
									if (num == 2667312101u && Operators.CompareString(name, "UseFlightSizeHardLimit", false) == 0)
									{
										strike.UseFlightSizeHardLimit = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Escort_ResponseRadius", false) == 0)
									{
										strike.Escort_ResponseRadius = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (num > 3031881553u)
								{
									if (num <= 3161520750u)
									{
										if (num != 3158266596u)
										{
											if (num == 3161520750u && Operators.CompareString(name, "MinAircraftReq_Escorts_Shooter", false) == 0)
											{
												goto IL_BC7;
											}
											continue;
										}
										else if (Operators.CompareString(name, "MaxAircraftToFly_Escort", false) != 0)
										{
											continue;
										}
									}
									else if (num != 3171215196u)
									{
										if (num != 3198166091u)
										{
											if (num == 3219336901u && Operators.CompareString(name, "Escort_Formation_Cruise", false) == 0)
											{
												strike.Escort_Formation_Cruise = (Mission._Formation)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name, "MaxAircraftToFly_Escort_Shooter", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "SplitDistance", false) == 0)
										{
											strike.SplitDistance = (Mission._SplitDistance)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									strike.MaxAircraftToFly_Escort_Shooter = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								if (num <= 2940441098u)
								{
									if (num != 2878265187u)
									{
										if (num == 2940441098u && Operators.CompareString(name, "END", false) == 0)
										{
											DateTime value4 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											strike.SetEndTime(new DateTime?(value4));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Escort_FlightSize_NonShooter", false) == 0)
										{
											strike.Escort_FlightSize_NonShooter = (Mission._FlightSize)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 2947802513u)
								{
									if (num == 3031881553u && Operators.CompareString(name, "Formation_Attack", false) == 0)
									{
										strike.Formation_Attack = (Mission._Formation)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Category", false) == 0)
									{
										strike.category = (Mission.MissionCategory)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
						}
						else if (num <= 3749943133u)
						{
							if (num <= 3512062061u)
							{
								if (num <= 3386238231u)
								{
									if (num != 3251257466u)
									{
										if (num == 3386238231u && Operators.CompareString(name, "Escort_FlightSize_Preferred", false) == 0)
										{
											goto IL_DF4;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Escort_Formation_Attack", false) == 0)
										{
											strike.Escort_Formation_Attack = (Mission._Formation)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 3426070594u)
								{
									if (num != 3512062061u || Operators.CompareString(name, "Type", false) != 0)
									{
										continue;
									}
									if (Versioned.IsNumeric(xmlNode.InnerText))
									{
										strike.strikeType = (Strike.StrikeType)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									strike.strikeType = (Strike.StrikeType)Enum.Parse(typeof(Strike.StrikeType), xmlNode.InnerText, true);
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "PrePlannedOnly", false) == 0)
									{
										strike.PrePlannedOnly = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 3591985774u)
							{
								if (num != 3563879251u)
								{
									if (num == 3591985774u && Operators.CompareString(name, "StartTime", false) != 0)
									{
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "MinAircraftReq_Escorts_NonShooter", false) == 0)
									{
										strike.MinAircraftReq_Escorts_NonShooter = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 3601981274u)
							{
								if (num != 3707977405u)
								{
									if (num == 3749943133u && Operators.CompareString(name, "TankerUsage", false) == 0)
									{
										strike.TankerUsage = (Mission.TankerMethod)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "MinAircraftReq_Strikers", false) == 0)
									{
										strike.MinAircraftReq_Strikers = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "OneTimeOnlyFlown", false) == 0)
								{
									strike.OneTimeOnlyFlown = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 3864926495u)
						{
							if (num <= 3857348560u)
							{
								if (num != 3790255292u)
								{
									if (num != 3802618614u)
									{
										if (num == 3857348560u && Operators.CompareString(name, "MaxResponseRadius", false) == 0)
										{
											strike.MaxResponseRadius = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TankerFollowsReceivers", false) == 0)
										{
											strike.bTankerFollowsReceivers = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "Bingo", false) == 0)
									{
										strike.Bingo = (Mission.Enum60)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 3863701925u)
							{
								if (num == 3864926495u && Operators.CompareString(name, "UseGroupSizeHardLimit_Escort", false) == 0)
								{
									strike.UseGroupSizeHardLimit_Escort = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "GroupSize", false) == 0)
								{
									strike.m_GroupSize = (Mission._GroupSize)Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 3988052812u)
						{
							if (num != 3905033942u)
							{
								if (num == 3988052812u && Operators.CompareString(name, "MaxAircraftToFly_Escort_NonShooter", false) == 0)
								{
									strike.MaxAircraftToFly_Escort_NonShooter = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Formation_Cruise", false) == 0)
								{
									strike.Formation_Cruise = (Mission._Formation)Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num != 4038753622u)
						{
							if (num != 4100651282u)
							{
								if (num == 4226137208u && Operators.CompareString(name, "AttackMethod", false) == 0)
								{
									strike.AttackMethod = (Mission._AttackMethod)Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "MaxReceiversInQueuePerTanker_Airborne", false) == 0)
								{
									strike.MaxReceiversInQueuePerTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "UseFlightSizeHardLimit_Escort", false) == 0)
							{
								strike.UseFlightSizeHardLimit_Escort = Conversions.ToBoolean(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						IL_9BB:
						strike.Escort_StationThrottle = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
						continue;
						IL_BC7:
						strike.MinAircraftReq_Escorts_Shooter = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
						continue;
						IL_DF4:
						strike.Escort_FlightSize_Shooter = (Mission._FlightSize)Conversions.ToInteger(xmlNode.InnerText);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (strike.m_FlightSize == Mission._FlightSize.None && strike.strikeType == Strike.StrikeType.Sub_Strike)
				{
					strike.m_Doctrine.SetWCS_SubmarineDoctrine(scenario_0, false, null, false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
				}
				if (strike.RadarBehaviour == Mission._RadarBehaviour.const_0)
				{
					if (strike.SpecificTargets.Count > 0 || strike.list_5.Count > 0)
					{
						strike.PrePlannedOnly = true;
					}
					strike.OneTimeOnly = false;
					strike.OneTimeOnlyFlown = false;
				}
				if (strike.RadarBehaviour == Mission._RadarBehaviour.const_0)
				{
					if (strike.strikeType == Strike.StrikeType.Maritime_Strike)
					{
						strike.RadarBehaviour = Mission._RadarBehaviour.Maritime;
					}
					else
					{
						strike.RadarBehaviour = Mission._RadarBehaviour.Land;
					}
				}
				if (strike.Escort_FlightSize_Shooter == Mission._FlightSize.None)
				{
					strike.Escort_FlightSize_Shooter = Mission._FlightSize.TwoAircraft;
					strike.Escort_FlightSize_NonShooter = Mission._FlightSize.SingleAircraft;
					strike.Doctrine_Escorts.SetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
					strike.Doctrine_Escorts.SetEMCON_Settings(false);
					strike.Doctrine_Escorts.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_1, scenario_0);
				}
				ActiveUnit.Throttle? throttle = strike.Escort_TransitThrottle;
				byte? b = throttle.HasValue ? new byte?((byte)throttle.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					strike.Escort_TransitThrottle = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
				}
				throttle = strike.Escort_StationThrottle;
				b = (throttle.HasValue ? new byte?((byte)throttle.GetValueOrDefault()) : null);
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					strike.Escort_StationThrottle = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Full);
				}
				if (strike.Escort_ResponseRadius == 0)
				{
					strike.Escort_ResponseRadius = 80;
				}
				if (strike.m_Doctrine.RefuelSelectionHasNoValue())
				{
					strike.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
				}
				strike2 = strike;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100648", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				strike2 = new Strike(null, scenario_0);
				ProjectData.ClearProjectError();
			}
			result = strike2;
			return result;
		}

		// Token: 0x06005B97 RID: 23447 RVA: 0x002934C8 File Offset: 0x002916C8
		public override string GetTypeString(Scenario scenario_0)
		{
			string result;
			switch (this.strikeType)
			{
			case Strike.StrikeType.Air_Intercept:
				result = "空中截击";
				break;
			case Strike.StrikeType.Land_Strike:
				result = "对陆打击";
				break;
			case Strike.StrikeType.Maritime_Strike:
				result = "对海打击";
				break;
			case Strike.StrikeType.Sub_Strike:
				result = "对潜突击";
				break;
			default:
				throw new NotImplementedException();
			}
			return result;
		}

		// Token: 0x06005B98 RID: 23448 RVA: 0x00293520 File Offset: 0x00291720
		public Strike(Side side_0, Scenario scenario_0, string string_3, Mission.MissionCategory enum58_1, Strike.StrikeType strikeType_1) : base(side_0, scenario_0)
		{
			this.SpecificTargets = new HashSet<Unit>();
			this.list_5 = new List<string>();
			Collection<ActiveUnit> collection = null;
			this.Doctrine_Escorts = new Doctrine(this, ref collection);
			this.AttackMethod = Mission._AttackMethod.const_0;
			this.SplitDistance = Mission._SplitDistance.const_1;
			this.IsMission = true;
			this.MissionClass = Mission._MissionClass.Strike;
			collection = null;
			this.Doctrine_Escorts = new Doctrine(this, ref collection);
			this.category = enum58_1;
			this.strikeType = strikeType_1;
			this.Name = string_3;
			this.UseFlightSizeHardLimit = true;
			Strike.StrikeType strikeType = this.strikeType;
			if (strikeType != Strike.StrikeType.Air_Intercept)
			{
				if (strikeType != Strike.StrikeType.Sub_Strike)
				{
					this.m_Doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_0, scenario_0);
					this.m_FlightSize = Mission._FlightSize.FourAircraft;
				}
				else
				{
					this.m_Doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_0, scenario_0);
					this.m_Doctrine.SetWCS_SubmarineDoctrine(scenario_0, false, null, false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
					this.m_FlightSize = Mission._FlightSize.SingleAircraft;
				}
			}
			else
			{
				this.m_Doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_1, scenario_0);
				this.m_FlightSize = Mission._FlightSize.TwoAircraft;
			}
			this.m_GroupSize = Mission._GroupSize.const_1;
			this.OneTimeOnly = false;
			this.OneTimeOnlyFlown = false;
			if (strikeType_1 == Strike.StrikeType.Maritime_Strike)
			{
				this.RadarBehaviour = Mission._RadarBehaviour.Maritime;
			}
			else
			{
				this.RadarBehaviour = Mission._RadarBehaviour.Land;
			}
			this.Escort_FlightSize_Shooter = Mission._FlightSize.TwoAircraft;
			this.Escort_FlightSize_NonShooter = Mission._FlightSize.SingleAircraft;
			this.Escort_TransitThrottle = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
			this.Escort_StationThrottle = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Full);
			this.Escort_TransitTerrainFollowing = false;
			this.Escort_AttackTerrainFollowing = false;
			this.Escort_ResponseRadius = 80;
			this.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
			this.Doctrine_Escorts.SetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
			this.Doctrine_Escorts.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_1, scenario_0);
			this.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
			this.Doctrine_Escorts.SetRefuelSelectionDoctrine(scenario_0, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
			this.MinimumContactStanceToTrigger = Misc.PostureStance.Unknown;
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x002936EC File Offset: 0x002918EC
		public override void vmethod_6(ref Scenario scenario_0, Side side_0, bool bool_23)
		{
			checked
			{
				try
				{
					if (this.list_5.Count > 0)
					{
						foreach (ActiveUnit current in scenario_0.GetActiveUnitList())
						{
							if (this.list_5.Contains(current.GetGuid()))
							{
								this.SpecificTargets.Add(current);
								if (base.IsActive() && side_0.GetPostureStance(current.GetSide(false)) != Misc.PostureStance.Hostile)
								{
									side_0.SetPostureStance(current.GetSide(false), Misc.PostureStance.Hostile);
								}
							}
						}
						foreach (Contact current2 in side_0.GetContactList())
						{
							if (this.list_5.Contains(current2.GetGuid()))
							{
								this.SpecificTargets.Add(current2);
								if (base.IsActive() && current2.GetPostureStance(side_0) != Misc.PostureStance.Hostile)
								{
									current2.MarkAs(side_0, false, Misc.PostureStance.Hostile);
								}
							}
						}
					}
					if (this.TankerMissionNameList.Count > 0)
					{
						Side[] sides = scenario_0.GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							Side side = sides[i];
							foreach (Mission current3 in side.GetMissionCollection())
							{
								if (this.TankerMissionNameList.Contains(current3.GetGuid()))
								{
									this.TankerMissionList.Add(current3);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100649", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x04002EE4 RID: 12004
		public Strike.StrikeType strikeType;

		// Token: 0x04002EE5 RID: 12005
		public HashSet<Unit> SpecificTargets;

		// Token: 0x04002EE6 RID: 12006
		private List<string> list_5;

		// Token: 0x04002EE7 RID: 12007
		public bool UseAutoPlanner;

		// Token: 0x04002EE8 RID: 12008
		public Doctrine Doctrine_Escorts;

		// Token: 0x04002EE9 RID: 12009
		public Mission._FlightQty MinAircraftReq_Strikers;

		// Token: 0x04002EEA RID: 12010
		public Mission._FlightQty MinAircraftReq_Escorts_Shooter;

		// Token: 0x04002EEB RID: 12011
		public Mission._FlightQty MinAircraftReq_Escorts_NonShooter;

		// Token: 0x04002EEC RID: 12012
		public Mission._FlightQty MaxAircraftToFly_Strikers;

		// Token: 0x04002EED RID: 12013
		public Mission._FlightQty MaxAircraftToFly_Escort_Shooter;

		// Token: 0x04002EEE RID: 12014
		public Mission._FlightQty MaxAircraftToFly_Escort_NonShooter;

		// Token: 0x04002EEF RID: 12015
		public Mission._Formation Formation_Cruise;

		// Token: 0x04002EF0 RID: 12016
		public Mission._Formation Formation_Attack;

		// Token: 0x04002EF1 RID: 12017
		public Mission.Enum60 Bingo;

		// Token: 0x04002EF2 RID: 12018
		public Mission._FlightSize Escort_FlightSize_Shooter;

		// Token: 0x04002EF3 RID: 12019
		public Mission._FlightSize Escort_FlightSize_NonShooter;

		// Token: 0x04002EF4 RID: 12020
		public Mission._Formation Escort_Formation_Cruise;

		// Token: 0x04002EF5 RID: 12021
		public Mission._Formation Escort_Formation_Attack;

		// Token: 0x04002EF6 RID: 12022
		public ActiveUnit.Throttle? Escort_TransitThrottle;

		// Token: 0x04002EF7 RID: 12023
		public ActiveUnit.Throttle? Escort_StationThrottle;

		// Token: 0x04002EF8 RID: 12024
		public bool Escort_TransitTerrainFollowing;

		// Token: 0x04002EF9 RID: 12025
		public bool Escort_AttackTerrainFollowing;

		// Token: 0x04002EFA RID: 12026
		public Mission._GroupSize Escort_GroupSize;

		// Token: 0x04002EFB RID: 12027
		public float? Escort_TransitAltitude;

		// Token: 0x04002EFC RID: 12028
		public float? Escort_StationAltitude;

		// Token: 0x04002EFD RID: 12029
		public int Escort_ResponseRadius;

		// Token: 0x04002EFE RID: 12030
		public int MinResponseRadius;

		// Token: 0x04002EFF RID: 12031
		public int MaxResponseRadius;

		// Token: 0x04002F00 RID: 12032
		public bool OneTimeOnly;

		// Token: 0x04002F01 RID: 12033
		public bool OneTimeOnlyFlown;

		// Token: 0x04002F02 RID: 12034
		public Mission._RadarBehaviour RadarBehaviour;

		// Token: 0x04002F03 RID: 12035
		public bool PrePlannedOnly;

		// Token: 0x04002F04 RID: 12036
		public bool UseFlightSizeHardLimit_Escort;

		// Token: 0x04002F05 RID: 12037
		public bool UseGroupSizeHardLimit_Escort;

		// Token: 0x04002F06 RID: 12038
		public Mission._AttackMethod AttackMethod;

		// Token: 0x04002F07 RID: 12039
		public Mission._SplitDistance SplitDistance;

		// Token: 0x04002F08 RID: 12040
		public Misc.PostureStance MinimumContactStanceToTrigger;

		// Token: 0x02000B1D RID: 2845
		public enum StrikeType
		{
			// Token: 0x04002F0A RID: 12042
			Air_Intercept,
			// Token: 0x04002F0B RID: 12043
			Land_Strike,
			// Token: 0x04002F0C RID: 12044
			Maritime_Strike,
			// Token: 0x04002F0D RID: 12045
			Sub_Strike
		}
	}
}

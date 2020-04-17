using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace ns1
{
	// Token: 0x02000A77 RID: 2679
	public sealed class MineClearingMission : Mission
	{
		// Token: 0x060054E1 RID: 21729 RVA: 0x002350F8 File Offset: 0x002332F8
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("MineClearingMission");
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
				xmlWriter_0.WriteStartElement("Area");
				using (List<ReferencePoint>.Enumerator enumerator = this.AreaVertices.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.Flush();
					}
				}
				xmlWriter_0.WriteEndElement();
				xmlWriter_0.WriteElementString("OTR", this.OTR.ToString());
				xmlWriter_0.WriteElementString("SISIH", this.SISIH.ToString());
				if (base.GetMissionStatus(scenario_0) != Mission._MissionStatus.Activation)
				{
					xmlWriter_0.WriteElementString("Status", ((byte)base.GetMissionStatus(scenario_0)).ToString());
				}
				this.m_Doctrine.Save(ref xmlWriter_0, ref scenario_0, "Doctrine");
				if (this.TransitThrottle_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("TransitThrottle_Aircraft", Conversions.ToString((int)this.TransitThrottle_Aircraft.Value));
				}
				if (this.StationThrottle_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("StationThrottle_Aircraft", Conversions.ToString((int)this.StationThrottle_Aircraft.Value));
				}
				if (this.TransitAltitude_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("TransitAltitude_Aircraft", this.TransitAltitude_Aircraft.Value.ToString());
				}
				if (this.StationAltitude_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("StationAltitude_Aircraft", this.StationAltitude_Aircraft.Value.ToString());
				}
				xmlWriter_0.WriteElementString("TransitTerrainFollowing_Aircraft", this.TransitTerrainFollowing_Aircraft.ToString());
				xmlWriter_0.WriteElementString("StationTerrainFollowing_Aircraft", this.StationTerrainFollowing_Aircraft.ToString());
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "TransitThrottle_Submarine";
				byte b = (byte)this.TransitThrottle_Submarine;
				xmlWriter.WriteElementString(localName, b.ToString());
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "StationThrottle_Submarine";
				b = (byte)this.StationThrottle_Submarine;
				xmlWriter2.WriteElementString(localName2, b.ToString());
				if (this.TransitDepth_Submarine.HasValue)
				{
					xmlWriter_0.WriteElementString("TransitDepth_Submarine", this.TransitDepth_Submarine.Value.ToString());
				}
				if (this.StationDepth_Submarine.HasValue)
				{
					xmlWriter_0.WriteElementString("StationDepth_Submarine", this.StationDepth_Submarine.Value.ToString());
				}
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "TransitThrottle_Ship";
				b = (byte)this.TransitThrottle_Ship;
				xmlWriter3.WriteElementString(localName3, b.ToString());
				XmlWriter xmlWriter4 = xmlWriter_0;
				string localName4 = "StationThrottle_Ship";
				b = (byte)this.StationThrottle_Ship;
				xmlWriter4.WriteElementString(localName4, b.ToString());
				XmlWriter xmlWriter5 = xmlWriter_0;
				string localName5 = "TransitThrottle_Facility";
				b = (byte)this.TransitThrottle_Facility;
				xmlWriter5.WriteElementString(localName5, b.ToString());
				XmlWriter xmlWriter6 = xmlWriter_0;
				string localName6 = "StationThrottle_Facility";
				b = (byte)this.StationThrottle_Facility;
				xmlWriter6.WriteElementString(localName6, b.ToString());
				XmlWriter xmlWriter7 = xmlWriter_0;
				string localName7 = "FlightSize";
				int num = (int)this.m_FlightSize;
				xmlWriter7.WriteElementString(localName7, num.ToString());
				XmlWriter xmlWriter8 = xmlWriter_0;
				string localName8 = "GroupSize";
				num = (int)this.m_GroupSize;
				xmlWriter8.WriteElementString(localName8, num.ToString());
				XmlWriter xmlWriter9 = xmlWriter_0;
				string localName9 = "Formation_Cruise";
				num = (int)this.Formation_Cruise;
				xmlWriter9.WriteElementString(localName9, num.ToString());
				XmlWriter xmlWriter10 = xmlWriter_0;
				string localName10 = "Formation_Attack";
				num = (int)this.Formation_Attack;
				xmlWriter10.WriteElementString(localName10, num.ToString());
				XmlWriter xmlWriter11 = xmlWriter_0;
				string localName11 = "MinAircraftReq";
				num = (int)this.MinAircraftReq;
				xmlWriter11.WriteElementString(localName11, num.ToString());
				xmlWriter_0.WriteElementString("UseFlightSizeHardLimit", this.UseFlightSizeHardLimit.ToString());
				xmlWriter_0.WriteElementString("UseGroupSizeHardLimit", this.UseGroupSizeHardLimit.ToString());
				XmlWriter xmlWriter12 = xmlWriter_0;
				string localName12 = "TankerUsage";
				b = (byte)this.TankerUsage;
				xmlWriter12.WriteElementString(localName12, b.ToString());
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
				if (base.HasFlights())
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
				ex2.Data.Add("Error at 100635", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060054E2 RID: 21730 RVA: 0x00235858 File Offset: 0x00233A58
		public new static MineClearingMission Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			MineClearingMission mineClearingMission = null;
			MineClearingMission result;
			try
			{
				MineClearingMission mineClearingMission2 = new MineClearingMission(null, scenario_0);
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1795334850u)
						{
							if (num <= 726807327u)
							{
								if (num <= 461095311u)
								{
									if (num <= 217340019u)
									{
										if (num != 6222351u)
										{
											if (num != 32648804u)
											{
												if (num == 217340019u && Operators.CompareString(name, "TransitTerrainFollowing_Aircraft", false) == 0)
												{
													mineClearingMission2.TransitTerrainFollowing_Aircraft = Conversions.ToBoolean(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else if (Operators.CompareString(name, "OTR", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "Status", false) == 0)
											{
												mineClearingMission2.SetMissionStatus(scenario_0, (Mission._MissionStatus)Conversions.ToByte(xmlNode.InnerText));
												continue;
											}
											continue;
										}
									}
									else if (num != 227845695u)
									{
										if (num != 266367750u)
										{
											if (num == 461095311u && Operators.CompareString(name, "SISIH", false) == 0)
											{
												mineClearingMission2.SISIH = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Name", false) == 0)
											{
												mineClearingMission2.Name = xmlNode.InnerText;
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "START", false) == 0)
										{
											DateTime value = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											mineClearingMission2.SetStartTime(new DateTime?(value));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (num <= 620569374u)
									{
										if (num != 498456164u)
										{
											if (num != 533572954u)
											{
												if (num == 620569374u && Operators.CompareString(name, "TankerMinNumber_Airborne", false) == 0)
												{
													mineClearingMission2.TankerMinNumber_Airborne = Conversions.ToInteger(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "UseGroupSizeHardLimit", false) == 0)
												{
													mineClearingMission2.UseGroupSizeHardLimit = Conversions.ToBoolean(xmlNode.InnerText);
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "Area", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator2.MoveNext())
												{
													XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
													mineClearingMission2.AreaVertices.Add(ReferencePoint.Load(ref xmlNode2, ref dictionary_0));
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
									if (num != 664721451u)
									{
										if (num != 721363522u)
										{
											if (num == 726807327u && Operators.CompareString(name, "TransitThrottle_Ship", false) == 0)
											{
												mineClearingMission2.TransitThrottle_Ship = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "TankerMaxDistance_Airborne", false) == 0)
											{
												mineClearingMission2.TankerMaxDistance_Airborne = Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "StationThrottle", false) != 0)
										{
											continue;
										}
										goto IL_AD1;
									}
								}
							}
							else if (num <= 1165144998u)
							{
								if (num <= 1025497782u)
								{
									if (num != 882301358u)
									{
										if (num != 919337238u)
										{
											if (num == 1025497782u && Operators.CompareString(name, "TankerMinNumber_Total", false) == 0)
											{
												mineClearingMission2.TankerMinNumber_Total = Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name, "OneThirdRule", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "LaunchMissionWithoutTankersInPlace", false) == 0)
										{
											mineClearingMission2.LaunchMissionWithoutTankersInPlace = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 1062263555u)
								{
									if (num != 1074512784u)
									{
										if (num == 1165144998u && Operators.CompareString(name, "StationThrottle_Ship", false) == 0)
										{
											mineClearingMission2.StationThrottle_Ship = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TimeOnTarget", false) == 0)
										{
											DateTime value2 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											mineClearingMission2.SetTimeOnTarget(new DateTime?(value2));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "EmptySlotsList", false) == 0)
									{
										mineClearingMission2.EmptySlotsList = Mission.EmptySlot.Load(ref xmlNode, ref dictionary_0, scenario_0);
										continue;
									}
									continue;
								}
							}
							else if (num <= 1458105184u)
							{
								if (num != 1241867210u)
								{
									if (num != 1422437055u)
									{
										if (num != 1458105184u || Operators.CompareString(name, "ID", false) != 0)
										{
											continue;
										}
										if (!dictionary_0.ContainsKey(xmlNode.InnerText))
										{
											mineClearingMission2.SetGuid(xmlNode.InnerText);
											dictionary_0.Add(mineClearingMission2.GetGuid(), mineClearingMission2);
											continue;
										}
										mineClearingMission = (MineClearingMission)dictionary_0[xmlNode.InnerText];
										result = mineClearingMission;
										return result;
									}
									else
									{
										if (Operators.CompareString(name, "Doctrine", false) == 0)
										{
											mineClearingMission2.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode, mineClearingMission2);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TransitAltitude", false) != 0)
									{
										continue;
									}
									goto IL_B45;
								}
							}
							else if (num <= 1688531320u)
							{
								if (num != 1579537194u)
								{
									if (num == 1688531320u && Operators.CompareString(name, "TankerMinNumber_Station", false) == 0)
									{
										mineClearingMission2.TankerMinNumber_Station = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TakeOffTime", false) == 0)
									{
										DateTime value3 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										mineClearingMission2.SetTakeOffTime(new DateTime?(value3));
										continue;
									}
									continue;
								}
							}
							else if (num != 1708848641u)
							{
								if (num == 1795334850u && Operators.CompareString(name, "ST", false) != 0)
								{
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "StationThrottle_Facility", false) == 0)
								{
									mineClearingMission2.StationThrottle_Facility = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							mineClearingMission2.OTR = Conversions.ToBoolean(xmlNode.InnerText);
							continue;
						}
						if (num <= 3749943133u)
						{
							if (num <= 2835485886u)
							{
								if (num <= 2435049132u)
								{
									if (num != 2180604875u)
									{
										if (num != 2367170728u)
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
													mineClearingMission2.TankerMissionNameList.Add(xmlNode3.InnerText);
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
										if (Operators.CompareString(name, "FuelQtyToStartLookingForTanker_Airborne", false) == 0)
										{
											mineClearingMission2.FuelQtyToStartLookingForTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "FlightList", false) == 0)
										{
											mineClearingMission2.FlightList = Mission.Flight.Load(ref xmlNode, ref dictionary_0, scenario_0);
											continue;
										}
										continue;
									}
								}
								else if (num != 2487526210u)
								{
									if (num != 2667312101u)
									{
										if (num == 2835485886u && Operators.CompareString(name, "TransitDepth_Submarine", false) == 0)
										{
											mineClearingMission2.TransitDepth_Submarine = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "UseFlightSizeHardLimit", false) == 0)
										{
											mineClearingMission2.UseFlightSizeHardLimit = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "FlightSize", false) == 0)
									{
										mineClearingMission2.m_FlightSize = (Mission._FlightSize)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 2947802513u)
							{
								if (num != 2926002968u)
								{
									if (num != 2940441098u)
									{
										if (num == 2947802513u && Operators.CompareString(name, "Category", false) == 0)
										{
											mineClearingMission2.category = (Mission.MissionCategory)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "END", false) == 0)
										{
											DateTime value4 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											mineClearingMission2.SetEndTime(new DateTime?(value4));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TransitThrottle_Facility", false) == 0)
									{
										mineClearingMission2.TransitThrottle_Facility = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 3591985774u)
							{
								if (num != 3031881553u)
								{
									if (num == 3591985774u && Operators.CompareString(name, "StartTime", false) != 0)
									{
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Formation_Attack", false) == 0)
									{
										mineClearingMission2.Formation_Attack = (Mission._Formation)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 3679663768u)
							{
								if (num == 3749943133u && Operators.CompareString(name, "TankerUsage", false) == 0)
								{
									mineClearingMission2.TankerUsage = (Mission.TankerMethod)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "TransitThrottle", false) != 0)
							{
								continue;
							}
						}
						else
						{
							if (num <= 3849994837u)
							{
								if (num <= 3798713884u)
								{
									if (num != 3753185556u)
									{
										if (num != 3753944794u)
										{
											if (num != 3798713884u)
											{
												if (num == 3802618614u && Operators.CompareString(name, "TankerFollowsReceivers", false) == 0)
												{
													mineClearingMission2.bTankerFollowsReceivers = Conversions.ToBoolean(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "StationThrottle_Submarine", false) == 0)
												{
													mineClearingMission2.StationThrottle_Submarine = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "StationThrottle_Aircraft", false) == 0)
											{
												goto IL_AD1;
											}
											continue;
										}
									}
									else if (Operators.CompareString(name, "StationAltitude_Aircraft", false) != 0)
									{
										continue;
									}
								}
								else if (num != 3830857333u)
								{
									if (num != 3838663019u)
									{
										if (num == 3849994837u && Operators.CompareString(name, "TransitAltitude_Aircraft", false) == 0)
										{
											goto IL_B45;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "MinAircraftReq", false) == 0)
										{
											mineClearingMission2.MinAircraftReq = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (Operators.CompareString(name, "StationAltitude", false) != 0)
								{
									continue;
								}
								mineClearingMission2.StationAltitude_Aircraft = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
								continue;
							}
							if (num <= 3913889015u)
							{
								if (num != 3863701925u)
								{
									if (num != 3905033942u)
									{
										if (num == 3913889015u && Operators.CompareString(name, "TransitThrottle_Submarine", false) == 0)
										{
											mineClearingMission2.TransitThrottle_Submarine = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Formation_Cruise", false) == 0)
										{
											mineClearingMission2.Formation_Cruise = (Mission._Formation)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "GroupSize", false) == 0)
									{
										mineClearingMission2.m_GroupSize = (Mission._GroupSize)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 4222584886u)
							{
								if (num != 4100651282u)
								{
									if (num == 4222584886u && Operators.CompareString(name, "StationTerrainFollowing_Aircraft", false) == 0)
									{
										mineClearingMission2.StationTerrainFollowing_Aircraft = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "MaxReceiversInQueuePerTanker_Airborne", false) == 0)
									{
										mineClearingMission2.MaxReceiversInQueuePerTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 4236299283u)
							{
								if (num == 4263428659u && Operators.CompareString(name, "StationDepth_Submarine", false) == 0)
								{
									mineClearingMission2.StationDepth_Submarine = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "TransitThrottle_Aircraft", false) != 0)
							{
								continue;
							}
						}
						mineClearingMission2.TransitThrottle_Aircraft = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
						continue;
						IL_AD1:
						mineClearingMission2.StationThrottle_Aircraft = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
						continue;
						IL_B45:
						mineClearingMission2.TransitAltitude_Aircraft = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (mineClearingMission2.TransitThrottle_Submarine == ActiveUnit.Throttle.FullStop)
				{
					mineClearingMission2.TransitTerrainFollowing_Aircraft = false;
					mineClearingMission2.StationTerrainFollowing_Aircraft = false;
					mineClearingMission2.TransitThrottle_Submarine = ActiveUnit.Throttle.Cruise;
					mineClearingMission2.StationThrottle_Submarine = ActiveUnit.Throttle.Loiter;
					mineClearingMission2.TransitThrottle_Ship = ActiveUnit.Throttle.Cruise;
					mineClearingMission2.StationThrottle_Ship = ActiveUnit.Throttle.Loiter;
					mineClearingMission2.TransitThrottle_Facility = ActiveUnit.Throttle.Cruise;
					mineClearingMission2.StationThrottle_Facility = ActiveUnit.Throttle.Loiter;
				}
				if (mineClearingMission2.m_Doctrine.RefuelSelectionHasNoValue())
				{
					mineClearingMission2.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
				}
				mineClearingMission = mineClearingMission2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100636", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = mineClearingMission;
			return result;
		}

		// Token: 0x060054E3 RID: 21731 RVA: 0x00236750 File Offset: 0x00234950
		private MineClearingMission(Side side_0, Scenario scenario_0) : base(side_0, scenario_0)
		{
			this.AreaVertices = new List<ReferencePoint>();
			this.list_6 = new List<ReferencePoint>();
			this.list_7 = new List<ReferencePoint>();
			this.list_8 = new List<ReferencePoint>();
			this.list_9 = new List<ReferencePoint>();
			this.list_10 = new List<ReferencePoint>();
			this.list_11 = new List<ReferencePoint>();
			this.list_12 = new List<ReferencePoint>();
			this.list_13 = new List<ReferencePoint>();
			this.list_14 = new List<ReferencePoint>();
			this.IsMission = true;
			this.MissionClass = Mission._MissionClass.MineClearing;
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x002367E4 File Offset: 0x002349E4
		public MineClearingMission(Side side_0, Scenario scenario_0, string string_3, Mission.MissionCategory enum58_1, List<ReferencePoint> list_15, bool bool_18) : base(side_0, scenario_0)
		{
			this.AreaVertices = new List<ReferencePoint>();
			this.list_6 = new List<ReferencePoint>();
			this.list_7 = new List<ReferencePoint>();
			this.list_8 = new List<ReferencePoint>();
			this.list_9 = new List<ReferencePoint>();
			this.list_10 = new List<ReferencePoint>();
			this.list_11 = new List<ReferencePoint>();
			this.list_12 = new List<ReferencePoint>();
			this.list_13 = new List<ReferencePoint>();
			this.list_14 = new List<ReferencePoint>();
			this.IsMission = true;
			this.Name = string_3;
			this.MissionClass = Mission._MissionClass.MineClearing;
			this.category = enum58_1;
			this.AreaVertices = list_15;
			this.OTR = true;
			this.StationThrottle_Aircraft = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Loiter);
			this.TransitThrottle_Aircraft = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
			this.TransitTerrainFollowing_Aircraft = false;
			this.StationTerrainFollowing_Aircraft = false;
			this.TransitThrottle_Submarine = ActiveUnit.Throttle.Cruise;
			this.StationThrottle_Submarine = ActiveUnit.Throttle.Loiter;
			this.TransitThrottle_Ship = ActiveUnit.Throttle.Cruise;
			this.StationThrottle_Ship = ActiveUnit.Throttle.Loiter;
			this.TransitThrottle_Facility = ActiveUnit.Throttle.Cruise;
			this.StationThrottle_Facility = ActiveUnit.Throttle.Loiter;
			this.m_Doctrine.SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.Enum36.const_1, scenario_0);
			this.m_FlightSize = Mission._FlightSize.SingleAircraft;
			this.UseFlightSizeHardLimit = true;
			string prompt = "";
			if (bool_18 && !ActiveUnit_Navigator.smethod_6(ref this.AreaVertices, ref prompt, "", "Mine Clearing Mission '" + this.Name + "'"))
			{
				Interaction.MsgBox(prompt, MsgBoxStyle.OkOnly, null);
			}
			this.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
			this.m_GroupSize = Mission._GroupSize.const_1;
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x0023695C File Offset: 0x00234B5C
		public override string GetTypeString(Scenario scenario_0)
		{
			return "扫雷";
		}

		// Token: 0x04002905 RID: 10501
		public List<ReferencePoint> AreaVertices;

		// Token: 0x04002906 RID: 10502
		public List<ReferencePoint> list_6;

		// Token: 0x04002907 RID: 10503
		public List<ReferencePoint> list_7;

		// Token: 0x04002908 RID: 10504
		public List<ReferencePoint> list_8;

		// Token: 0x04002909 RID: 10505
		public List<ReferencePoint> list_9;

		// Token: 0x0400290A RID: 10506
		public List<ReferencePoint> list_10;

		// Token: 0x0400290B RID: 10507
		public List<ReferencePoint> list_11;

		// Token: 0x0400290C RID: 10508
		public List<ReferencePoint> list_12;

		// Token: 0x0400290D RID: 10509
		public List<ReferencePoint> list_13;

		// Token: 0x0400290E RID: 10510
		public List<ReferencePoint> list_14;

		// Token: 0x0400290F RID: 10511
		public bool OTR;

		// Token: 0x04002910 RID: 10512
		public Mission._FlightQty MinAircraftReq;

		// Token: 0x04002911 RID: 10513
		public ActiveUnit.Throttle? TransitThrottle_Aircraft;

		// Token: 0x04002912 RID: 10514
		public ActiveUnit.Throttle? StationThrottle_Aircraft;

		// Token: 0x04002913 RID: 10515
		public float? TransitAltitude_Aircraft;

		// Token: 0x04002914 RID: 10516
		public float? StationAltitude_Aircraft;

		// Token: 0x04002915 RID: 10517
		public bool TransitTerrainFollowing_Aircraft;

		// Token: 0x04002916 RID: 10518
		public bool StationTerrainFollowing_Aircraft;

		// Token: 0x04002917 RID: 10519
		public ActiveUnit.Throttle TransitThrottle_Submarine;

		// Token: 0x04002918 RID: 10520
		public ActiveUnit.Throttle StationThrottle_Submarine;

		// Token: 0x04002919 RID: 10521
		public float? TransitDepth_Submarine;

		// Token: 0x0400291A RID: 10522
		public float? StationDepth_Submarine;

		// Token: 0x0400291B RID: 10523
		public ActiveUnit.Throttle TransitThrottle_Ship;

		// Token: 0x0400291C RID: 10524
		public ActiveUnit.Throttle StationThrottle_Ship;

		// Token: 0x0400291D RID: 10525
		public ActiveUnit.Throttle TransitThrottle_Facility;

		// Token: 0x0400291E RID: 10526
		public ActiveUnit.Throttle StationThrottle_Facility;

		// Token: 0x0400291F RID: 10527
		public Mission._Formation Formation_Cruise;

		// Token: 0x04002920 RID: 10528
		public Mission._Formation Formation_Attack;
	}
}

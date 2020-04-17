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
	// Token: 0x02000A6F RID: 2671
	public sealed class MiningMission : Mission
	{
		// Token: 0x0600547E RID: 21630 RVA: 0x00230C84 File Offset: 0x0022EE84
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("MiningMission");
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
				xmlWriter_0.WriteElementString("OTR", this.bOTR.ToString());
				xmlWriter_0.WriteElementString("AD", this.AD.ToString());
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
				ex2.Data.Add("Error at 100637", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600547F RID: 21631 RVA: 0x002313F8 File Offset: 0x0022F5F8
		public new static MiningMission Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			MiningMission miningMission = null;
			MiningMission result;
			try
			{
				MiningMission miningMission2 = new MiningMission(null, scenario_0);
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
													miningMission2.TransitTerrainFollowing_Aircraft = Conversions.ToBoolean(xmlNode.InnerText);
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
												miningMission2.SetMissionStatus(scenario_0, (Mission._MissionStatus)Conversions.ToByte(xmlNode.InnerText));
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
												miningMission2.SISIH = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Name", false) == 0)
											{
												miningMission2.Name = xmlNode.InnerText;
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
											miningMission2.SetStartTime(new DateTime?(value));
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
													miningMission2.TankerMinNumber_Airborne = Conversions.ToInteger(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "UseGroupSizeHardLimit", false) == 0)
												{
													miningMission2.UseGroupSizeHardLimit = Conversions.ToBoolean(xmlNode.InnerText);
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
													miningMission2.AreaVertices.Add(ReferencePoint.Load(ref xmlNode2, ref dictionary_0));
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
									if (num <= 664721451u)
									{
										if (num != 651499544u)
										{
											if (num != 664721451u)
											{
												continue;
											}
											if (Operators.CompareString(name, "StationThrottle", false) != 0)
											{
												continue;
											}
											goto IL_ADC;
										}
										else
										{
											if (Operators.CompareString(name, "AD", false) == 0)
											{
												miningMission2.AD = Conversions.ToLong(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num != 721363522u)
									{
										if (num == 726807327u && Operators.CompareString(name, "TransitThrottle_Ship", false) == 0)
										{
											miningMission2.TransitThrottle_Ship = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TankerMaxDistance_Airborne", false) == 0)
										{
											miningMission2.TankerMaxDistance_Airborne = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
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
												miningMission2.TankerMinNumber_Total = Conversions.ToInteger(xmlNode.InnerText);
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
											miningMission2.LaunchMissionWithoutTankersInPlace = Conversions.ToBoolean(xmlNode.InnerText);
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
											miningMission2.StationThrottle_Ship = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TimeOnTarget", false) == 0)
										{
											DateTime value2 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											miningMission2.SetTimeOnTarget(new DateTime?(value2));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "EmptySlotsList", false) == 0)
									{
										miningMission2.EmptySlotsList = Mission.EmptySlot.Load(ref xmlNode, ref dictionary_0, scenario_0);
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
											miningMission2.SetGuid(xmlNode.InnerText);
											dictionary_0.Add(miningMission2.GetGuid(), miningMission2);
											continue;
										}
										miningMission = (MiningMission)dictionary_0[xmlNode.InnerText];
										result = miningMission;
										return result;
									}
									else
									{
										if (Operators.CompareString(name, "Doctrine", false) == 0)
										{
											miningMission2.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode, miningMission2);
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
									goto IL_B8F;
								}
							}
							else if (num <= 1688531320u)
							{
								if (num != 1579537194u)
								{
									if (num == 1688531320u && Operators.CompareString(name, "TankerMinNumber_Station", false) == 0)
									{
										miningMission2.TankerMinNumber_Station = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TakeOffTime", false) == 0)
									{
										DateTime value3 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										miningMission2.SetTakeOffTime(new DateTime?(value3));
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
									miningMission2.StationThrottle_Facility = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							miningMission2.bOTR = Conversions.ToBoolean(xmlNode.InnerText);
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
													miningMission2.TankerMissionNameList.Add(xmlNode3.InnerText);
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
											miningMission2.FuelQtyToStartLookingForTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "FlightList", false) == 0)
										{
											miningMission2.FlightList = Mission.Flight.Load(ref xmlNode, ref dictionary_0, scenario_0);
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
											miningMission2.TransitDepth_Submarine = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "UseFlightSizeHardLimit", false) == 0)
										{
											miningMission2.UseFlightSizeHardLimit = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "FlightSize", false) == 0)
									{
										miningMission2.m_FlightSize = (Mission._FlightSize)Conversions.ToInteger(xmlNode.InnerText);
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
											miningMission2.category = (Mission.MissionCategory)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "END", false) == 0)
										{
											DateTime value4 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											miningMission2.SetEndTime(new DateTime?(value4));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TransitThrottle_Facility", false) == 0)
									{
										miningMission2.TransitThrottle_Facility = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
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
										miningMission2.Formation_Attack = (Mission._Formation)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 3679663768u)
							{
								if (num == 3749943133u && Operators.CompareString(name, "TankerUsage", false) == 0)
								{
									miningMission2.TankerUsage = (Mission.TankerMethod)Conversions.ToByte(xmlNode.InnerText);
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
											if (num == 3798713884u && Operators.CompareString(name, "StationThrottle_Submarine", false) == 0)
											{
												miningMission2.StationThrottle_Submarine = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "StationThrottle_Aircraft", false) == 0)
											{
												goto IL_ADC;
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
										if (num != 3849994837u)
										{
											if (num == 3802618614u && Operators.CompareString(name, "TankerFollowsReceivers", false) == 0)
											{
												miningMission2.bTankerFollowsReceivers = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "TransitAltitude_Aircraft", false) == 0)
											{
												goto IL_B8F;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "MinAircraftReq", false) == 0)
										{
											miningMission2.MinAircraftReq = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (Operators.CompareString(name, "StationAltitude", false) != 0)
								{
									continue;
								}
								miningMission2.StationAltitude_Aircraft = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
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
											miningMission2.TransitThrottle_Submarine = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Formation_Cruise", false) == 0)
										{
											miningMission2.Formation_Cruise = (Mission._Formation)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "GroupSize", false) == 0)
									{
										miningMission2.m_GroupSize = (Mission._GroupSize)Conversions.ToInteger(xmlNode.InnerText);
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
										miningMission2.StationTerrainFollowing_Aircraft = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "MaxReceiversInQueuePerTanker_Airborne", false) == 0)
									{
										miningMission2.MaxReceiversInQueuePerTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 4236299283u)
							{
								if (num == 4263428659u && Operators.CompareString(name, "StationDepth_Submarine", false) == 0)
								{
									miningMission2.StationDepth_Submarine = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "TransitThrottle_Aircraft", false) != 0)
							{
								continue;
							}
						}
						miningMission2.TransitThrottle_Aircraft = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
						continue;
						IL_ADC:
						miningMission2.StationThrottle_Aircraft = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
						continue;
						IL_B8F:
						miningMission2.TransitAltitude_Aircraft = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (miningMission2.TransitThrottle_Submarine == ActiveUnit.Throttle.FullStop)
				{
					miningMission2.TransitTerrainFollowing_Aircraft = false;
					miningMission2.StationTerrainFollowing_Aircraft = false;
					miningMission2.TransitThrottle_Submarine = ActiveUnit.Throttle.Cruise;
					miningMission2.StationThrottle_Submarine = ActiveUnit.Throttle.Loiter;
					miningMission2.TransitThrottle_Ship = ActiveUnit.Throttle.Cruise;
					miningMission2.StationThrottle_Ship = ActiveUnit.Throttle.Loiter;
					miningMission2.TransitThrottle_Facility = ActiveUnit.Throttle.Cruise;
					miningMission2.StationThrottle_Facility = ActiveUnit.Throttle.Loiter;
				}
				if (miningMission2.m_Doctrine.RefuelSelectionHasNoValue())
				{
					miningMission2.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
				}
				miningMission = miningMission2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100638", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				miningMission = new MiningMission(null, scenario_0);
				ProjectData.ClearProjectError();
			}
			result = miningMission;
			return result;
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x00232344 File Offset: 0x00230544
		private MiningMission(Side side_0, Scenario scenario_0) : base(side_0, scenario_0)
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
			this.list_15 = new List<ReferencePoint>();
			this.list_16 = new List<ReferencePoint>();
			this.IsMission = true;
			this.MissionClass = Mission._MissionClass.Mining;
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x002323EC File Offset: 0x002305EC
		public MiningMission(Side side_, Scenario scenario_, string name_, Mission.MissionCategory missionCategory_, List<ReferencePoint> list_17, bool bool_18) : base(side_, scenario_)
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
			this.list_15 = new List<ReferencePoint>();
			this.list_16 = new List<ReferencePoint>();
			this.IsMission = true;
			this.Name = name_;
			this.MissionClass = Mission._MissionClass.Mining;
			this.category = missionCategory_;
			this.AreaVertices = list_17;
			this.bOTR = true;
			this.AD = 7200L;
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
			this.m_FlightSize = Mission._FlightSize.FourAircraft;
			this.m_GroupSize = Mission._GroupSize.const_1;
			this.UseFlightSizeHardLimit = true;
			string prompt = "";
			if (bool_18 && !ActiveUnit_Navigator.smethod_6(ref this.AreaVertices, ref prompt, "", "Mining Mission '" + this.Name + "'"))
			{
				Interaction.MsgBox(prompt, MsgBoxStyle.OkOnly, null);
			}
			this.m_Doctrine.SetRefuelSelectionDoctrine(scenario_, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x0023257C File Offset: 0x0023077C
		public override string GetTypeString(Scenario scenario_0)
		{
			return "布雷";
		}

		// Token: 0x040028B5 RID: 10421
		public List<ReferencePoint> AreaVertices;

		// Token: 0x040028B6 RID: 10422
		public List<ReferencePoint> list_6;

		// Token: 0x040028B7 RID: 10423
		public List<ReferencePoint> list_7;

		// Token: 0x040028B8 RID: 10424
		public List<ReferencePoint> list_8;

		// Token: 0x040028B9 RID: 10425
		public List<ReferencePoint> list_9;

		// Token: 0x040028BA RID: 10426
		public List<ReferencePoint> list_10;

		// Token: 0x040028BB RID: 10427
		public List<ReferencePoint> list_11;

		// Token: 0x040028BC RID: 10428
		public List<ReferencePoint> list_12;

		// Token: 0x040028BD RID: 10429
		public List<ReferencePoint> list_13;

		// Token: 0x040028BE RID: 10430
		public List<ReferencePoint> list_14;

		// Token: 0x040028BF RID: 10431
		public List<ReferencePoint> list_15;

		// Token: 0x040028C0 RID: 10432
		public List<ReferencePoint> list_16;

		// Token: 0x040028C1 RID: 10433
		public bool bOTR;

		// Token: 0x040028C2 RID: 10434
		public long AD;

		// Token: 0x040028C3 RID: 10435
		public Mission._FlightQty MinAircraftReq;

		// Token: 0x040028C4 RID: 10436
		public ActiveUnit.Throttle? TransitThrottle_Aircraft;

		// Token: 0x040028C5 RID: 10437
		public ActiveUnit.Throttle? StationThrottle_Aircraft;

		// Token: 0x040028C6 RID: 10438
		public float? TransitAltitude_Aircraft;

		// Token: 0x040028C7 RID: 10439
		public float? StationAltitude_Aircraft;

		// Token: 0x040028C8 RID: 10440
		public bool TransitTerrainFollowing_Aircraft;

		// Token: 0x040028C9 RID: 10441
		public bool StationTerrainFollowing_Aircraft;

		// Token: 0x040028CA RID: 10442
		public ActiveUnit.Throttle TransitThrottle_Submarine;

		// Token: 0x040028CB RID: 10443
		public ActiveUnit.Throttle StationThrottle_Submarine;

		// Token: 0x040028CC RID: 10444
		public float? TransitDepth_Submarine;

		// Token: 0x040028CD RID: 10445
		public float? StationDepth_Submarine;

		// Token: 0x040028CE RID: 10446
		public ActiveUnit.Throttle TransitThrottle_Ship;

		// Token: 0x040028CF RID: 10447
		public ActiveUnit.Throttle StationThrottle_Ship;

		// Token: 0x040028D0 RID: 10448
		public ActiveUnit.Throttle TransitThrottle_Facility;

		// Token: 0x040028D1 RID: 10449
		public ActiveUnit.Throttle StationThrottle_Facility;

		// Token: 0x040028D2 RID: 10450
		public Mission._Formation Formation_Cruise;

		// Token: 0x040028D3 RID: 10451
		public Mission._Formation Formation_Attack;
	}
}

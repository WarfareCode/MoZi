using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace ns2
{
	// Token: 0x02000B1E RID: 2846
	public sealed class SupportMission : Mission
	{
		// Token: 0x06005B9A RID: 23450 RVA: 0x00293934 File Offset: 0x00291B34
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("SupportMission");
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
				xmlWriter_0.WriteElementString("SISIH", this.SISIH.ToString());
				xmlWriter_0.WriteStartElement("NavigationCourse");
				using (List<ReferencePoint>.Enumerator enumerator = this.NavigationCourseReferencePoints.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.Flush();
					}
				}
				xmlWriter_0.WriteEndElement();
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "NLT";
				int num = (int)this.NLT;
				xmlWriter.WriteElementString(localName, num.ToString());
				xmlWriter_0.WriteElementString("OTR", this.OTR.ToString());
				if (this.MNOS > 0)
				{
					xmlWriter_0.WriteElementString("MNOS", this.MNOS.ToString());
				}
				xmlWriter_0.WriteElementString("OTO", this.OTO.ToString());
				xmlWriter_0.WriteElementString("AEOOS", this.AEOOS.ToString());
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
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "TransitThrottle_Submarine";
				byte b = (byte)this.TransitThrottle_Submarine;
				xmlWriter2.WriteElementString(localName2, b.ToString());
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "StationThrottle_Submarine";
				b = (byte)this.StationThrottle_Submarine;
				xmlWriter3.WriteElementString(localName3, b.ToString());
				if (this.TransitDepth_Submarine.HasValue)
				{
					xmlWriter_0.WriteElementString("TransitDepth_Submarine", this.TransitDepth_Submarine.Value.ToString());
				}
				if (this.StationDepth_Submarine.HasValue)
				{
					xmlWriter_0.WriteElementString("StationDepth_Submarine", this.StationDepth_Submarine.Value.ToString());
				}
				XmlWriter xmlWriter4 = xmlWriter_0;
				string localName4 = "TransitThrottle_Ship";
				b = (byte)this.TransitThrottle_Ship;
				xmlWriter4.WriteElementString(localName4, b.ToString());
				XmlWriter xmlWriter5 = xmlWriter_0;
				string localName5 = "StationThrottle_Ship";
				b = (byte)this.StationThrottle_Ship;
				xmlWriter5.WriteElementString(localName5, b.ToString());
				XmlWriter xmlWriter6 = xmlWriter_0;
				string localName6 = "TransitThrottle_Facility";
				b = (byte)this.TransitThrottle_Facility;
				xmlWriter6.WriteElementString(localName6, b.ToString());
				XmlWriter xmlWriter7 = xmlWriter_0;
				string localName7 = "StationThrottle_Facility";
				b = (byte)this.StationThrottle_Facility;
				xmlWriter7.WriteElementString(localName7, b.ToString());
				if (base.GetMissionStatus(scenario_0) != Mission._MissionStatus.Activation)
				{
					xmlWriter_0.WriteElementString("Status", ((byte)base.GetMissionStatus(scenario_0)).ToString());
				}
				this.m_Doctrine.Save(ref xmlWriter_0, ref scenario_0, "Doctrine");
				XmlWriter xmlWriter8 = xmlWriter_0;
				string localName8 = "FlightSize";
				num = (int)this.m_FlightSize;
				xmlWriter8.WriteElementString(localName8, num.ToString());
				XmlWriter xmlWriter9 = xmlWriter_0;
				string localName9 = "GroupSize";
				num = (int)this.m_GroupSize;
				xmlWriter9.WriteElementString(localName9, num.ToString());
				XmlWriter xmlWriter10 = xmlWriter_0;
				string localName10 = "Formation_Cruise";
				num = (int)this.Formation_Cruise;
				xmlWriter10.WriteElementString(localName10, num.ToString());
				xmlWriter_0.WriteElementString("A2AR_MaxNumberOfReceiversPerTanker", this.A2AR_MaxNumberOfReceiversPerTanker.ToString());
				xmlWriter_0.WriteElementString("A2AR_OneTankingCycleOnly", this.A2AR_OneTankingCycleOnly.ToString());
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
				ex2.Data.Add("Error at 100650", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x00294114 File Offset: 0x00292314
		public new static SupportMission Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			SupportMission supportMission = null;
			SupportMission result;
			try
			{
				Side side = null;
				string string_ = "";
				List<ReferencePoint> list = null;
				SupportMission supportMission2 = new SupportMission(ref side, ref scenario_0, string_, Mission.MissionCategory.Mission, ref list, false);
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1899183862u)
						{
							if (num <= 800068950u)
							{
								if (num <= 461095311u)
								{
									if (num <= 116536899u)
									{
										if (num != 6222351u)
										{
											if (num != 32648804u)
											{
												if (num == 116536899u && Operators.CompareString(name, "OTO", false) == 0)
												{
													supportMission2.OTO = Conversions.ToBoolean(xmlNode.InnerText);
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
												supportMission2.SetMissionStatus(scenario_0, (Mission._MissionStatus)Conversions.ToByte(xmlNode.InnerText));
												continue;
											}
											continue;
										}
									}
									else if (num <= 227845695u)
									{
										if (num != 217340019u)
										{
											if (num == 227845695u && Operators.CompareString(name, "START", false) == 0)
											{
												DateTime value = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
												supportMission2.SetStartTime(new DateTime?(value));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "TransitTerrainFollowing_Aircraft", false) == 0)
											{
												supportMission2.TransitTerrainFollowing_Aircraft = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num != 266367750u)
									{
										if (num == 461095311u && Operators.CompareString(name, "SISIH", false) == 0)
										{
											supportMission2.SISIH = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Name", false) == 0)
										{
											supportMission2.Name = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num <= 620569374u)
								{
									if (num <= 540270923u)
									{
										if (num != 533572954u)
										{
											if (num != 540270923u)
											{
												continue;
											}
											if (Operators.CompareString(name, "TAO", false) != 0)
											{
												continue;
											}
											goto IL_E99;
										}
										else
										{
											if (Operators.CompareString(name, "UseGroupSizeHardLimit", false) == 0)
											{
												supportMission2.UseGroupSizeHardLimit = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num != 594002279u)
									{
										if (num == 620569374u && Operators.CompareString(name, "TankerMinNumber_Airborne", false) == 0)
										{
											supportMission2.TankerMinNumber_Airborne = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TTh", false) != 0)
										{
											continue;
										}
										goto IL_102B;
									}
								}
								else if (num <= 721363522u)
								{
									if (num != 664721451u)
									{
										if (num == 721363522u && Operators.CompareString(name, "TankerMaxDistance_Airborne", false) == 0)
										{
											supportMission2.TankerMaxDistance_Airborne = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "StationThrottle", false) != 0)
										{
											continue;
										}
										goto IL_D75;
									}
								}
								else if (num != 726807327u)
								{
									if (num == 800068950u && Operators.CompareString(name, "A2AR_MaxNumberOfReceiversPerTanker", false) == 0)
									{
										supportMission2.A2AR_MaxNumberOfReceiversPerTanker = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TransitThrottle_Ship", false) == 0)
									{
										supportMission2.TransitThrottle_Ship = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 1165144998u)
							{
								if (num <= 996573132u)
								{
									if (num != 882301358u)
									{
										if (num != 919337238u)
										{
											if (num == 996573132u && Operators.CompareString(name, "MNOS", false) == 0)
											{
												supportMission2.MNOS = Conversions.ToInteger(xmlNode.InnerText);
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
											supportMission2.LaunchMissionWithoutTankersInPlace = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 1062263555u)
								{
									if (num != 1025497782u)
									{
										if (num == 1062263555u && Operators.CompareString(name, "EmptySlotsList", false) == 0)
										{
											supportMission2.EmptySlotsList = Mission.EmptySlot.Load(ref xmlNode, ref dictionary_0, scenario_0);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TankerMinNumber_Total", false) == 0)
										{
											supportMission2.TankerMinNumber_Total = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 1074512784u)
								{
									if (num == 1165144998u && Operators.CompareString(name, "StationThrottle_Ship", false) == 0)
									{
										supportMission2.StationThrottle_Ship = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TimeOnTarget", false) == 0)
									{
										DateTime value2 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										supportMission2.SetTimeOnTarget(new DateTime?(value2));
										continue;
									}
									continue;
								}
							}
							else if (num <= 1579537194u)
							{
								if (num <= 1422437055u)
								{
									if (num != 1241867210u)
									{
										if (num == 1422437055u && Operators.CompareString(name, "Doctrine", false) == 0)
										{
											supportMission2.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode, supportMission2);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TransitAltitude", false) != 0)
										{
											continue;
										}
										goto IL_E99;
									}
								}
								else if (num != 1458105184u)
								{
									if (num == 1579537194u && Operators.CompareString(name, "TakeOffTime", false) == 0)
									{
										DateTime value3 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										supportMission2.SetTakeOffTime(new DateTime?(value3));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "ID", false) != 0)
									{
										continue;
									}
									if (!dictionary_0.ContainsKey(xmlNode.InnerText))
									{
										supportMission2.SetGuid(xmlNode.InnerText);
										dictionary_0.Add(supportMission2.GetGuid(), supportMission2);
										continue;
									}
									supportMission = (SupportMission)dictionary_0[xmlNode.InnerText];
									result = supportMission;
									return result;
								}
							}
							else if (num <= 1708848641u)
							{
								if (num != 1688531320u)
								{
									if (num == 1708848641u && Operators.CompareString(name, "StationThrottle_Facility", false) == 0)
									{
										supportMission2.StationThrottle_Facility = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TankerMinNumber_Station", false) == 0)
									{
										supportMission2.TankerMinNumber_Station = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (num != 1795334850u)
								{
									if (num != 1899183862u || Operators.CompareString(name, "NavigationCourse", false) != 0)
									{
										continue;
									}
									supportMission2.NavigationCourseReferencePoints = new List<ReferencePoint>();
									IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
											supportMission2.NavigationCourseReferencePoints.Add(ReferencePoint.Load(ref xmlNode2, ref dictionary_0));
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
								if (Operators.CompareString(name, "ST", false) != 0)
								{
									continue;
								}
								continue;
							}
							supportMission2.OTR = Conversions.ToBoolean(xmlNode.InnerText);
							continue;
						}
						if (num <= 3591985774u)
						{
							if (num <= 2587531459u)
							{
								if (num <= 2351662642u)
								{
									if (num != 2175559422u)
									{
										if (num != 2180604875u)
										{
											if (num == 2351662642u && Operators.CompareString(name, "A2AR_OneTankingCycleOnly", false) == 0)
											{
												supportMission2.A2AR_OneTankingCycleOnly = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "FlightList", false) == 0)
											{
												supportMission2.FlightList = Mission.Flight.Load(ref xmlNode, ref dictionary_0, scenario_0);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "AEOOS", false) == 0)
										{
											supportMission2.AEOOS = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 2435049132u)
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
												supportMission2.TankerMissionNameList.Add(xmlNode3.InnerText);
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
										supportMission2.FuelQtyToStartLookingForTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else if (num != 2487526210u)
								{
									if (num != 2587531459u)
									{
										continue;
									}
									if (Operators.CompareString(name, "LAO", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "FlightSize", false) == 0)
									{
										supportMission2.m_FlightSize = (Mission._FlightSize)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 2835485886u)
							{
								if (num <= 2649486089u)
								{
									if (num != 2641262815u)
									{
										if (num == 2649486089u && Operators.CompareString(name, "NLT", false) == 0)
										{
											supportMission2.NLT = (SupportMission._NLT)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "LTh", false) != 0)
										{
											continue;
										}
										goto IL_D75;
									}
								}
								else if (num != 2667312101u)
								{
									if (num == 2835485886u && Operators.CompareString(name, "TransitDepth_Submarine", false) == 0)
									{
										supportMission2.TransitDepth_Submarine = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "UseFlightSizeHardLimit", false) == 0)
									{
										supportMission2.UseFlightSizeHardLimit = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 2940441098u)
							{
								if (num != 2926002968u)
								{
									if (num == 2940441098u && Operators.CompareString(name, "END", false) == 0)
									{
										DateTime value4 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										supportMission2.SetEndTime(new DateTime?(value4));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TransitThrottle_Facility", false) == 0)
									{
										supportMission2.TransitThrottle_Facility = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 2947802513u)
							{
								if (num == 3591985774u && Operators.CompareString(name, "StartTime", false) != 0)
								{
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Category", false) == 0)
								{
									supportMission2.category = (Mission.MissionCategory)Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 3838663019u)
						{
							if (num <= 3753185556u)
							{
								if (num != 3679663768u)
								{
									if (num != 3749943133u)
									{
										if (num != 3753185556u)
										{
											continue;
										}
										if (Operators.CompareString(name, "StationAltitude_Aircraft", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "TankerUsage", false) == 0)
										{
											supportMission2.TankerUsage = (Mission.TankerMethod)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TransitThrottle", false) != 0)
									{
										continue;
									}
									goto IL_102B;
								}
							}
							else if (num <= 3798713884u)
							{
								if (num != 3753944794u)
								{
									if (num != 3798713884u)
									{
										if (num == 3802618614u && Operators.CompareString(name, "TankerFollowsReceivers", false) == 0)
										{
											supportMission2.bTankerFollowsReceivers = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "StationThrottle_Submarine", false) == 0)
										{
											supportMission2.StationThrottle_Submarine = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "StationThrottle_Aircraft", false) == 0)
									{
										goto IL_D75;
									}
									continue;
								}
							}
							else if (num != 3830857333u)
							{
								if (num == 3838663019u && Operators.CompareString(name, "MinAircraftReq", false) == 0)
								{
									supportMission2.MinAircraftReq = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "StationAltitude", false) != 0)
							{
								continue;
							}
						}
						else if (num <= 3913889015u)
						{
							if (num <= 3863701925u)
							{
								if (num != 3849994837u)
								{
									if (num == 3863701925u && Operators.CompareString(name, "GroupSize", false) == 0)
									{
										supportMission2.m_GroupSize = (Mission._GroupSize)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TransitAltitude_Aircraft", false) == 0)
									{
										goto IL_E99;
									}
									continue;
								}
							}
							else if (num != 3905033942u)
							{
								if (num == 3913889015u && Operators.CompareString(name, "TransitThrottle_Submarine", false) == 0)
								{
									supportMission2.TransitThrottle_Submarine = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Formation_Cruise", false) == 0)
								{
									supportMission2.Formation_Cruise = (Mission._Formation)Conversions.ToInteger(xmlNode.InnerText);
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
									supportMission2.StationTerrainFollowing_Aircraft = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "MaxReceiversInQueuePerTanker_Airborne", false) == 0)
								{
									supportMission2.MaxReceiversInQueuePerTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num != 4236299283u)
						{
							if (num == 4263428659u && Operators.CompareString(name, "StationDepth_Submarine", false) == 0)
							{
								supportMission2.StationDepth_Submarine = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
								continue;
							}
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "TransitThrottle_Aircraft", false) == 0)
							{
								goto IL_102B;
							}
							continue;
						}
						supportMission2.StationAltitude_Aircraft = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
						continue;
						IL_D75:
						supportMission2.StationThrottle_Aircraft = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
						continue;
						IL_E99:
						supportMission2.TransitAltitude_Aircraft = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
						continue;
						IL_102B:
						supportMission2.TransitThrottle_Aircraft = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (supportMission2.TransitThrottle_Submarine == ActiveUnit.Throttle.FullStop)
				{
					supportMission2.TransitTerrainFollowing_Aircraft = false;
					supportMission2.StationTerrainFollowing_Aircraft = false;
					supportMission2.TransitThrottle_Submarine = ActiveUnit.Throttle.Cruise;
					supportMission2.StationThrottle_Submarine = ActiveUnit.Throttle.Loiter;
					supportMission2.TransitThrottle_Ship = ActiveUnit.Throttle.Cruise;
					supportMission2.StationThrottle_Ship = ActiveUnit.Throttle.Loiter;
					supportMission2.TransitThrottle_Facility = ActiveUnit.Throttle.Cruise;
					supportMission2.StationThrottle_Facility = ActiveUnit.Throttle.Loiter;
				}
				if (supportMission2.m_Doctrine.RefuelSelectionHasNoValue())
				{
					supportMission2.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
				}
				supportMission = supportMission2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100651", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = supportMission;
			return result;
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x002952D0 File Offset: 0x002934D0
		public SupportMission(ref Side side_0, ref Scenario scenario_0, string string_3, Mission.MissionCategory enum58_1, ref List<ReferencePoint> list_11, bool bool_21) : base(side_0, scenario_0)
		{
			this.NavigationCourseReferencePoints = new List<ReferencePoint>();
			this.list_6 = new List<ReferencePoint>();
			this.list_7 = new List<ReferencePoint>();
			this.list_8 = new List<ReferencePoint>();
			this.list_9 = new List<ReferencePoint>();
			this.list_10 = new List<ReferencePoint>();
			this.IsMission = true;
			this.MissionClass = Mission._MissionClass.Support;
			this.Name = string_3;
			this.category = enum58_1;
			this.NavigationCourseReferencePoints = list_11;
			this.NLT = SupportMission._NLT.const_0;
			this.TransitThrottle_Aircraft = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
			this.StationThrottle_Aircraft = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Loiter);
			this.TransitTerrainFollowing_Aircraft = false;
			this.StationTerrainFollowing_Aircraft = false;
			this.TransitThrottle_Submarine = ActiveUnit.Throttle.Cruise;
			this.StationThrottle_Submarine = ActiveUnit.Throttle.Loiter;
			this.TransitThrottle_Ship = ActiveUnit.Throttle.Cruise;
			this.StationThrottle_Ship = ActiveUnit.Throttle.Loiter;
			this.TransitThrottle_Facility = ActiveUnit.Throttle.Cruise;
			this.StationThrottle_Facility = ActiveUnit.Throttle.Loiter;
			this.OTR = true;
			this.m_FlightSize = Mission._FlightSize.SingleAircraft;
			this.UseFlightSizeHardLimit = true;
			string prompt = "";
			if (bool_21 && !ActiveUnit_Navigator.smethod_6(ref list_11, ref prompt, "", "Support Mission '" + this.Name + "'"))
			{
				Interaction.MsgBox(prompt, MsgBoxStyle.OkOnly, null);
			}
			this.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
			this.m_GroupSize = Mission._GroupSize.const_1;
		}

		// Token: 0x06005B9D RID: 23453 RVA: 0x00295414 File Offset: 0x00293614
		public override string GetTypeString(Scenario scenario_0)
		{
			return "支援保障";
		}

		// Token: 0x04002F0E RID: 12046
		public SupportMission._NLT NLT;

		// Token: 0x04002F0F RID: 12047
		public List<ReferencePoint> NavigationCourseReferencePoints;

		// Token: 0x04002F10 RID: 12048
		public List<ReferencePoint> list_6;

		// Token: 0x04002F11 RID: 12049
		public List<ReferencePoint> list_7;

		// Token: 0x04002F12 RID: 12050
		public List<ReferencePoint> list_8;

		// Token: 0x04002F13 RID: 12051
		public List<ReferencePoint> list_9;

		// Token: 0x04002F14 RID: 12052
		public List<ReferencePoint> list_10;

		// Token: 0x04002F15 RID: 12053
		public bool OTR;

		// Token: 0x04002F16 RID: 12054
		public int MNOS;

		// Token: 0x04002F17 RID: 12055
		public bool OTO;

		// Token: 0x04002F18 RID: 12056
		public bool A2AR_OneTankingCycleOnly;

		// Token: 0x04002F19 RID: 12057
		public int A2AR_MaxNumberOfReceiversPerTanker;

		// Token: 0x04002F1A RID: 12058
		public Mission._FlightQty MinAircraftReq;

		// Token: 0x04002F1B RID: 12059
		public ActiveUnit.Throttle? TransitThrottle_Aircraft;

		// Token: 0x04002F1C RID: 12060
		public ActiveUnit.Throttle? StationThrottle_Aircraft;

		// Token: 0x04002F1D RID: 12061
		public float? TransitAltitude_Aircraft;

		// Token: 0x04002F1E RID: 12062
		public float? StationAltitude_Aircraft;

		// Token: 0x04002F1F RID: 12063
		public bool TransitTerrainFollowing_Aircraft;

		// Token: 0x04002F20 RID: 12064
		public bool StationTerrainFollowing_Aircraft;

		// Token: 0x04002F21 RID: 12065
		public ActiveUnit.Throttle TransitThrottle_Submarine;

		// Token: 0x04002F22 RID: 12066
		public ActiveUnit.Throttle StationThrottle_Submarine;

		// Token: 0x04002F23 RID: 12067
		public float? TransitDepth_Submarine;

		// Token: 0x04002F24 RID: 12068
		public float? StationDepth_Submarine;

		// Token: 0x04002F25 RID: 12069
		public ActiveUnit.Throttle TransitThrottle_Ship;

		// Token: 0x04002F26 RID: 12070
		public ActiveUnit.Throttle StationThrottle_Ship;

		// Token: 0x04002F27 RID: 12071
		public ActiveUnit.Throttle TransitThrottle_Facility;

		// Token: 0x04002F28 RID: 12072
		public ActiveUnit.Throttle StationThrottle_Facility;

		// Token: 0x04002F29 RID: 12073
		public bool AEOOS;

		// Token: 0x04002F2A RID: 12074
		public Mission._Formation Formation_Cruise;

		// Token: 0x02000B1F RID: 2847
		public enum _NLT : byte
		{
			// Token: 0x04002F2C RID: 12076
			const_0,
			// Token: 0x04002F2D RID: 12077
			const_1
		}
	}
}

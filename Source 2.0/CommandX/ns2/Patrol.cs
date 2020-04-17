using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace ns2
{
	// Token: 0x02000B1B RID: 2843
	public sealed class Patrol : Mission
	{
		// Token: 0x06005B8A RID: 23434 RVA: 0x0028EC6C File Offset: 0x0028CE6C
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Patrol");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("Category", ((byte)this.category).ToString());
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Type";
				int num = (int)this.patrolType;
				xmlWriter.WriteElementString(localName, num.ToString());
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
				if (this.PatrolAreaVertices.Count > 0)
				{
					xmlWriter_0.WriteStartElement("PatrolArea");
					using (List<ReferencePoint>.Enumerator enumerator = this.PatrolAreaVertices.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.Flush();
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (this.ProsecutionAreaVertices.Count > 0)
				{
					xmlWriter_0.WriteStartElement("ProsecutionArea");
					using (List<ReferencePoint>.Enumerator enumerator2 = this.ProsecutionAreaVertices.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.Flush();
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				xmlWriter_0.WriteElementString("OTR", this.OTR.ToString());
				if (this.MNOS > 0)
				{
					xmlWriter_0.WriteElementString("MNOS", this.MNOS.ToString());
				}
				xmlWriter_0.WriteElementString("IOPA", this.IOPA.ToString());
				xmlWriter_0.WriteElementString("IWWR", this.IWWR.ToString());
				xmlWriter_0.WriteElementString("AEOIPA", this.AEOIPA.ToString());
				xmlWriter_0.WriteElementString("SAD", this.SAD.ToString());
				if (this.TransitThrottle_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("TransitThrottle_Aircraft", ((byte)this.TransitThrottle_Aircraft.Value).ToString());
				}
				if (this.StationThrottle_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("StationThrottle_Aircraft", ((byte)this.StationThrottle_Aircraft.Value).ToString());
				}
				if (this.AttackThrottle_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("AttackThrottle_Aircraft", ((byte)this.AttackThrottle_Aircraft.Value).ToString());
				}
				if (this.TransitAltitude_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("TransitAltitude_Aircraft", this.TransitAltitude_Aircraft.Value.ToString());
				}
				if (this.StationAltitude_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("StationAltitude_Aircraft", this.StationAltitude_Aircraft.Value.ToString());
				}
				if (this.AttackAltitude_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("AttackAltitude_Aircraft", this.AttackAltitude_Aircraft.Value.ToString());
				}
				if (this.AttackDistance_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("AttackDistance_Aircraft", this.AttackDistance_Aircraft.Value.ToString());
				}
				xmlWriter_0.WriteElementString("TransitTerrainFollowing_Aircraft", this.TransitTerrainFollowing_Aircraft.ToString());
				xmlWriter_0.WriteElementString("StationTerrainFollowing_Aircraft", this.StationTerrainFollowing_Aircraft.ToString());
				xmlWriter_0.WriteElementString("AttackTerrainFollowing_Aircraft", this.AttackTerrainFollowing_Aircraft.ToString());
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "TransitThrottle_Submarine";
				byte b = (byte)this.TransitThrottle_Submarine;
				xmlWriter2.WriteElementString(localName2, b.ToString());
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "StationThrottle_Submarine";
				b = (byte)this.StationThrottle_Submarine;
				xmlWriter3.WriteElementString(localName3, b.ToString());
				if (this.AttackThrottle_Submarine.HasValue)
				{
					xmlWriter_0.WriteElementString("AttackThrottle_Submarine", ((byte)this.AttackThrottle_Submarine.Value).ToString());
				}
				if (this.TransitDepth_Submarine.HasValue)
				{
					xmlWriter_0.WriteElementString("TransitDepth_Submarine", this.TransitDepth_Submarine.Value.ToString());
				}
				if (this.StationDepth_Submarine.HasValue)
				{
					xmlWriter_0.WriteElementString("StationDepth_Submarine", this.StationDepth_Submarine.Value.ToString());
				}
				if (this.AttackDepth_Submarine.HasValue)
				{
					xmlWriter_0.WriteElementString("AttackDepth_Submarine", this.AttackDepth_Submarine.Value.ToString());
				}
				if (this.AttackDistance_Submarine.HasValue)
				{
					xmlWriter_0.WriteElementString("AttackDistance_Submarine", this.AttackDistance_Submarine.Value.ToString());
				}
				XmlWriter xmlWriter4 = xmlWriter_0;
				string localName4 = "TransitThrottle_Ship";
				b = (byte)this.TransitThrottle_Ship;
				xmlWriter4.WriteElementString(localName4, b.ToString());
				XmlWriter xmlWriter5 = xmlWriter_0;
				string localName5 = "StationThrottle_Ship";
				b = (byte)this.StationThrottle_Ship;
				xmlWriter5.WriteElementString(localName5, b.ToString());
				if (this.AttackThrottle_Ship.HasValue)
				{
					xmlWriter_0.WriteElementString("AttackThrottle_Ship", ((byte)this.AttackThrottle_Ship.Value).ToString());
				}
				if (this.AttackDistance_Ship.HasValue)
				{
					xmlWriter_0.WriteElementString("AttackDistance_Ship", this.AttackDistance_Ship.Value.ToString());
				}
				XmlWriter xmlWriter6 = xmlWriter_0;
				string localName6 = "TransitThrottle_Facility";
				b = (byte)this.TransitThrottle_Facility;
				xmlWriter6.WriteElementString(localName6, b.ToString());
				XmlWriter xmlWriter7 = xmlWriter_0;
				string localName7 = "StationThrottle_Facility";
				b = (byte)this.StationThrottle_Facility;
				xmlWriter7.WriteElementString(localName7, b.ToString());
				if (this.AttackThrottle_Facility.HasValue)
				{
					xmlWriter_0.WriteElementString("AttackThrottle_Facility", ((byte)this.AttackThrottle_Facility.Value).ToString());
				}
				xmlWriter_0.WriteElementString("SISIH", this.SISIH.ToString());
				if (base.GetMissionStatus(scenario_0) != Mission._MissionStatus.Activation)
				{
					xmlWriter_0.WriteElementString("Status", ((byte)base.GetMissionStatus(scenario_0)).ToString());
				}
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
				XmlWriter xmlWriter11 = xmlWriter_0;
				string localName11 = "Formation_Attack";
				num = (int)this.Formation_Attack;
				xmlWriter11.WriteElementString(localName11, num.ToString());
				XmlWriter xmlWriter12 = xmlWriter_0;
				string localName12 = "MinAircraftReq";
				num = (int)this.MinAircraftReq;
				xmlWriter12.WriteElementString(localName12, num.ToString());
				xmlWriter_0.WriteElementString("UseFlightSizeHardLimit", this.UseFlightSizeHardLimit.ToString());
				xmlWriter_0.WriteElementString("UseGroupSizeHardLimit", this.UseGroupSizeHardLimit.ToString());
				XmlWriter xmlWriter13 = xmlWriter_0;
				string localName13 = "TankerUsage";
				b = (byte)this.TankerUsage;
				xmlWriter13.WriteElementString(localName13, b.ToString());
				xmlWriter_0.WriteStartElement("TankerMissionList");
				xmlWriter_0.WriteElementString("TankerFollowsReceivers", this.bTankerFollowsReceivers.ToString());
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
				ex2.Data.Add("Error at 100643", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x0028F6B4 File Offset: 0x0028D8B4
		public new static Patrol Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			Patrol patrol = null;
			Patrol result;
			try
			{
				Patrol patrol2 = new Patrol(null, scenario_0);
				patrol2.StationThrottle_Aircraft = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Loiter);
				patrol2.IWWR = true;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num > 1726281922u)
						{
							if (num > 3082918148u)
							{
								if (num <= 3798713884u)
								{
									if (num <= 3679663768u)
									{
										if (num <= 3512062061u)
										{
											if (num != 3486864758u)
											{
												if (num != 3512062061u || Operators.CompareString(name, "Type", false) != 0)
												{
													continue;
												}
												if (Versioned.IsNumeric(xmlNode.InnerText))
												{
													patrol2.patrolType = (GlobalVariables.PatrolType)Conversions.ToByte(xmlNode.InnerText);
													continue;
												}
												patrol2.patrolType = (GlobalVariables.PatrolType)Enum.Parse(typeof(GlobalVariables.PatrolType), xmlNode.InnerText, true);
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "IOPA", false) == 0)
												{
													goto IL_670;
												}
												continue;
											}
										}
										else if (num != 3591985774u)
										{
											if (num != 3679663768u)
											{
												continue;
											}
											if (Operators.CompareString(name, "TransitThrottle", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "StartTime", false) != 0)
											{
												continue;
											}
											continue;
										}
									}
									else if (num <= 3749943133u)
									{
										if (num != 3717056185u)
										{
											if (num == 3749943133u && Operators.CompareString(name, "TankerUsage", false) == 0)
											{
												patrol2.TankerUsage = (Mission.TankerMethod)Conversions.ToByte(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "ActiveEMCONOnlyInPatrolArea", false) == 0)
											{
												goto IL_9E2;
											}
											continue;
										}
									}
									else if (num != 3753185556u)
									{
										if (num != 3753944794u)
										{
											if (num != 3798713884u)
											{
												if (num == 3802618614u && Operators.CompareString(name, "TankerFollowsReceivers", false) == 0)
												{
													patrol2.bTankerFollowsReceivers = Conversions.ToBoolean(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "StationThrottle_Submarine", false) == 0)
												{
													patrol2.StationThrottle_Submarine = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "StationThrottle_Aircraft", false) == 0)
											{
												goto IL_12E6;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "StationAltitude_Aircraft", false) != 0)
										{
											continue;
										}
										goto IL_CE2;
									}
								}
								else if (num <= 3905033942u)
								{
									if (num <= 3838663019u)
									{
										if (num != 3830857333u)
										{
											if (num == 3838663019u && Operators.CompareString(name, "MinAircraftReq", false) == 0)
											{
												patrol2.MinAircraftReq = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "StationAltitude", false) == 0)
											{
												goto IL_CE2;
											}
											continue;
										}
									}
									else if (num != 3849994837u)
									{
										if (num != 3863701925u)
										{
											if (num == 3905033942u && Operators.CompareString(name, "Formation_Cruise", false) == 0)
											{
												patrol2.Formation_Cruise = (Mission._Formation)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "GroupSize", false) == 0)
											{
												patrol2.m_GroupSize = (Mission._GroupSize)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "TransitAltitude_Aircraft", false) == 0)
										{
											goto IL_10EA;
										}
										continue;
									}
								}
								else if (num <= 4100651282u)
								{
									if (num != 3913889015u)
									{
										if (num == 4100651282u && Operators.CompareString(name, "MaxReceiversInQueuePerTanker_Airborne", false) == 0)
										{
											patrol2.MaxReceiversInQueuePerTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TransitThrottle_Submarine", false) == 0)
										{
											patrol2.TransitThrottle_Submarine = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 4222584886u)
								{
									if (num != 4236299283u)
									{
										if (num == 4263428659u && Operators.CompareString(name, "StationDepth_Submarine", false) == 0)
										{
											patrol2.StationDepth_Submarine = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
											continue;
										}
										continue;
									}
									else if (Operators.CompareString(name, "TransitThrottle_Aircraft", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "StationTerrainFollowing_Aircraft", false) == 0)
									{
										patrol2.StationTerrainFollowing_Aircraft = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								patrol2.TransitThrottle_Aircraft = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
								continue;
							}
							if (num <= 2667312101u)
							{
								if (num <= 2228373070u)
								{
									if (num <= 2171807205u)
									{
										if (num != 1795334850u)
										{
											if (num == 2171807205u && Operators.CompareString(name, "AttackDepth_Submarine", false) == 0)
											{
												patrol2.AttackDepth_Submarine = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
												continue;
											}
											continue;
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
									else if (num != 2180604875u)
									{
										if (num == 2228373070u && Operators.CompareString(name, "AttackAltitude_Aircraft", false) == 0)
										{
											patrol2.AttackAltitude_Aircraft = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "FlightList", false) == 0)
										{
											patrol2.FlightList = Mission.Flight.Load(ref xmlNode, ref dictionary_0, scenario_0);
											continue;
										}
										continue;
									}
								}
								else if (num <= 2380036936u)
								{
									if (num != 2367170728u)
									{
										if (num == 2380036936u && Operators.CompareString(name, "InvestigateOutsidePatrolArea", false) == 0)
										{
											goto IL_670;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "FuelQtyToStartLookingForTanker_Airborne", false) == 0)
										{
											patrol2.FuelQtyToStartLookingForTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 2435049132u)
								{
									if (num != 2487526210u)
									{
										if (num == 2667312101u && Operators.CompareString(name, "UseFlightSizeHardLimit", false) == 0)
										{
											patrol2.UseFlightSizeHardLimit = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "FlightSize", false) == 0)
										{
											patrol2.m_FlightSize = (Mission._FlightSize)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TankerMissionList", false) != 0)
									{
										continue;
									}
									IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
											patrol2.TankerMissionNameList.Add(xmlNode2.InnerText);
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
							if (num <= 2940441098u)
							{
								if (num <= 2835485886u)
								{
									if (num != 2733315973u)
									{
										if (num == 2835485886u && Operators.CompareString(name, "TransitDepth_Submarine", false) == 0)
										{
											patrol2.TransitDepth_Submarine = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "AttackDistance_Aircraft", false) == 0)
										{
											patrol2.AttackDistance_Aircraft = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
											continue;
										}
										continue;
									}
								}
								else if (num != 2926002968u)
								{
									if (num == 2940441098u && Operators.CompareString(name, "END", false) == 0)
									{
										DateTime value = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										patrol2.SetEndTime(new DateTime?(value));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TransitThrottle_Facility", false) == 0)
									{
										patrol2.TransitThrottle_Facility = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 2949330181u)
							{
								if (num != 2947802513u)
								{
									if (num == 2949330181u && Operators.CompareString(name, "AttackDistance_Ship", false) == 0)
									{
										patrol2.AttackDistance_Ship = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Category", false) == 0)
									{
										patrol2.category = (Mission.MissionCategory)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 3031881553u)
							{
								if (num != 3073470772u)
								{
									if (num == 3082918148u && Operators.CompareString(name, "AttackThrottle_Aircraft", false) == 0)
									{
										patrol2.AttackThrottle_Aircraft = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "AEOIPA", false) == 0)
									{
										goto IL_9E2;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Formation_Attack", false) == 0)
								{
									patrol2.Formation_Attack = (Mission._Formation)Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							IL_670:
							patrol2.IOPA = Conversions.ToBoolean(xmlNode.InnerText);
							continue;
							IL_9E2:
							patrol2.AEOIPA = Conversions.ToBoolean(xmlNode.InnerText);
							continue;
						}
						if (num <= 919337238u)
						{
							if (num <= 540270923u)
							{
								if (num <= 217340019u)
								{
									if (num <= 32648804u)
									{
										if (num != 6222351u)
										{
											if (num != 32648804u)
											{
												continue;
											}
											if (Operators.CompareString(name, "OTR", false) != 0)
											{
												continue;
											}
											goto IL_E54;
										}
										else
										{
											if (Operators.CompareString(name, "Status", false) == 0)
											{
												patrol2.SetMissionStatus(scenario_0, (Mission._MissionStatus)Conversions.ToByte(xmlNode.InnerText));
												continue;
											}
											continue;
										}
									}
									else if (num != 58957510u)
									{
										if (num == 217340019u && Operators.CompareString(name, "TransitTerrainFollowing_Aircraft", false) == 0)
										{
											patrol2.TransitTerrainFollowing_Aircraft = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "PatrolArea", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator3.MoveNext())
											{
												XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
												patrol2.PatrolAreaVertices.Add(ReferencePoint.Load(ref xmlNode3, ref dictionary_0));
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
								if (num <= 266367750u)
								{
									if (num != 227845695u)
									{
										if (num == 266367750u && Operators.CompareString(name, "Name", false) == 0)
										{
											patrol2.Name = xmlNode.InnerText;
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "START", false) == 0)
										{
											DateTime value2 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											patrol2.SetStartTime(new DateTime?(value2));
											continue;
										}
										continue;
									}
								}
								else if (num != 461095311u)
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
										goto IL_10EA;
									}
									else
									{
										if (Operators.CompareString(name, "UseGroupSizeHardLimit", false) == 0)
										{
											patrol2.UseGroupSizeHardLimit = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "SISIH", false) == 0)
									{
										patrol2.SISIH = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 687260455u)
							{
								if (num <= 656819206u)
								{
									if (num != 620569374u)
									{
										if (num == 656819206u && Operators.CompareString(name, "OAO", false) == 0)
										{
											goto IL_CE2;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TankerMinNumber_Airborne", false) == 0)
										{
											patrol2.TankerMinNumber_Airborne = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 664721451u)
								{
									if (num == 687260455u && Operators.CompareString(name, "SAD", false) == 0)
									{
										patrol2.SAD = Conversions.ToBoolean(xmlNode.InnerText);
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
									goto IL_12E6;
								}
							}
							else if (num <= 726807327u)
							{
								if (num != 721363522u)
								{
									if (num == 726807327u && Operators.CompareString(name, "TransitThrottle_Ship", false) == 0)
									{
										patrol2.TransitThrottle_Ship = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TankerMaxDistance_Airborne", false) == 0)
									{
										patrol2.TankerMaxDistance_Airborne = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 858345912u)
							{
								if (num != 882301358u)
								{
									if (num != 919337238u || Operators.CompareString(name, "OneThirdRule", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "LaunchMissionWithoutTankersInPlace", false) == 0)
									{
										patrol2.LaunchMissionWithoutTankersInPlace = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "IWWR", false) == 0)
								{
									patrol2.IWWR = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							IL_E54:
							patrol2.OTR = Conversions.ToBoolean(xmlNode.InnerText);
							continue;
						}
						if (num <= 1241867210u)
						{
							if (num <= 1032628039u)
							{
								if (num <= 996573132u)
								{
									if (num != 991723779u)
									{
										if (num == 996573132u && Operators.CompareString(name, "MNOS", false) == 0)
										{
											patrol2.MNOS = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "AttackThrottle_Facility", false) == 0)
										{
											patrol2.AttackThrottle_Facility = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (num != 1025497782u)
									{
										if (num != 1032628039u || Operators.CompareString(name, "ProsecutionArea", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator4 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator4.MoveNext())
											{
												XmlNode xmlNode4 = (XmlNode)enumerator4.Current;
												patrol2.ProsecutionAreaVertices.Add(ReferencePoint.Load(ref xmlNode4, ref dictionary_0));
											}
											continue;
										}
										finally
										{
											if (enumerator4 is IDisposable)
											{
												(enumerator4 as IDisposable).Dispose();
											}
										}
									}
									if (Operators.CompareString(name, "TankerMinNumber_Total", false) == 0)
									{
										patrol2.TankerMinNumber_Total = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 1074512784u)
							{
								if (num != 1062263555u)
								{
									if (num == 1074512784u && Operators.CompareString(name, "TimeOnTarget", false) == 0)
									{
										DateTime value3 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										patrol2.SetTimeOnTarget(new DateTime?(value3));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "EmptySlotsList", false) == 0)
									{
										patrol2.EmptySlotsList = Mission.EmptySlot.Load(ref xmlNode, ref dictionary_0, scenario_0);
										continue;
									}
									continue;
								}
							}
							else if (num != 1109639028u)
							{
								if (num != 1165144998u)
								{
									if (num == 1241867210u && Operators.CompareString(name, "TransitAltitude", false) == 0)
									{
										goto IL_10EA;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "StationThrottle_Ship", false) == 0)
									{
										patrol2.StationThrottle_Ship = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "AttackTerrainFollowing_Aircraft", false) == 0)
								{
									patrol2.AttackTerrainFollowing_Aircraft = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 1579537194u)
						{
							if (num <= 1458105184u)
							{
								if (num != 1422437055u)
								{
									if (num != 1458105184u || Operators.CompareString(name, "ID", false) != 0)
									{
										continue;
									}
									if (!dictionary_0.ContainsKey(xmlNode.InnerText))
									{
										patrol2.SetGuid(xmlNode.InnerText);
										dictionary_0.Add(patrol2.GetGuid(), patrol2);
										continue;
									}
									patrol = (Patrol)dictionary_0[xmlNode.InnerText];
									result = patrol;
									return result;
								}
								else
								{
									if (Operators.CompareString(name, "Doctrine", false) == 0)
									{
										patrol2.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode, patrol2);
										continue;
									}
									continue;
								}
							}
							else if (num != 1540130877u)
							{
								if (num == 1579537194u && Operators.CompareString(name, "TakeOffTime", false) == 0)
								{
									DateTime value4 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
									patrol2.SetTakeOffTime(new DateTime?(value4));
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "AttackDistance_Submarine", false) == 0)
								{
									patrol2.AttackDistance_Submarine = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									continue;
								}
								continue;
							}
						}
						else if (num <= 1657676131u)
						{
							if (num != 1650689636u)
							{
								if (num == 1657676131u && Operators.CompareString(name, "PatrolThrottle", false) == 0)
								{
									goto IL_12E6;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "AttackThrottle_Ship", false) == 0)
								{
									patrol2.AttackThrottle_Ship = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else if (num != 1688531320u)
						{
							if (num != 1708848641u)
							{
								if (num == 1726281922u && Operators.CompareString(name, "AttackThrottle_Submarine", false) == 0)
								{
									patrol2.AttackThrottle_Submarine = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "StationThrottle_Facility", false) == 0)
								{
									patrol2.StationThrottle_Facility = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "TankerMinNumber_Station", false) == 0)
							{
								patrol2.TankerMinNumber_Station = Conversions.ToInteger(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						IL_CE2:
						patrol2.StationAltitude_Aircraft = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
						continue;
						IL_10EA:
						patrol2.TransitAltitude_Aircraft = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
						continue;
						IL_12E6:
						patrol2.StationThrottle_Aircraft = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (patrol2.m_FlightSize == Mission._FlightSize.None)
				{
					Patrol patrol3 = patrol2;
					if (patrol3.patrolType == GlobalVariables.PatrolType.SEAD)
					{
						patrol2.m_Doctrine.SetShootTouristsDoctrine(scenario_0, false, false, false, new Doctrine._ShootTourists?(Doctrine._ShootTourists.const_0));
					}
					if (patrol3.patrolType == GlobalVariables.PatrolType.ASW || patrol3.patrolType == GlobalVariables.PatrolType.ASuW_Mixed || patrol3.patrolType == GlobalVariables.PatrolType.ASuW_Naval)
					{
						patrol2.m_Doctrine.SetWCS_SubmarineDoctrine(scenario_0, false, null, false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
					}
				}
				ActiveUnit.Throttle? transitThrottle_Aircraft = patrol2.TransitThrottle_Aircraft;
				byte? b = transitThrottle_Aircraft.HasValue ? new byte?((byte)transitThrottle_Aircraft.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					patrol2.TransitThrottle_Aircraft = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
				}
				if (patrol2.TransitThrottle_Submarine == ActiveUnit.Throttle.FullStop)
				{
					if (patrol2.patrolType == GlobalVariables.PatrolType.ASW)
					{
						patrol2.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.No));
						patrol2.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, false, false, false, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit));
					}
					else
					{
						patrol2.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
						patrol2.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, false, false, false, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit));
					}
					patrol2.AttackThrottle_Aircraft = null;
					patrol2.TransitTerrainFollowing_Aircraft = false;
					patrol2.StationTerrainFollowing_Aircraft = false;
					patrol2.AttackTerrainFollowing_Aircraft = false;
					patrol2.TransitThrottle_Submarine = ActiveUnit.Throttle.Cruise;
					patrol2.StationThrottle_Submarine = ActiveUnit.Throttle.Loiter;
					patrol2.AttackThrottle_Submarine = null;
					patrol2.TransitThrottle_Ship = ActiveUnit.Throttle.Cruise;
					patrol2.StationThrottle_Ship = ActiveUnit.Throttle.Loiter;
					patrol2.AttackThrottle_Ship = null;
					patrol2.TransitThrottle_Facility = ActiveUnit.Throttle.Cruise;
					patrol2.StationThrottle_Facility = ActiveUnit.Throttle.Loiter;
					patrol2.AttackThrottle_Facility = null;
				}
				if (patrol2.m_Doctrine.RefuelSelectionHasNoValue())
				{
					patrol2.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
				}
				patrol = patrol2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100644", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				patrol = new Patrol(null, scenario_0);
				ProjectData.ClearProjectError();
			}
			result = patrol;
			return result;
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x0002907D File Offset: 0x0002727D
		public bool method_42()
		{
			return this.ProsecutionAreaVertices.Count > 2;
		}

		// Token: 0x06005B8D RID: 23437 RVA: 0x0002908D File Offset: 0x0002728D
		public bool method_43(Scenario scenario_0)
		{
			return this.IOPA;
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x00290D94 File Offset: 0x0028EF94
		public void method_44(Scenario scenario_0, bool bool_23)
		{
			checked
			{
				try
				{
					this.IOPA = bool_23;
					if (!bool_23)
					{
						List<ActiveUnit> list = scenario_0.GetActiveUnitList().ToList<ActiveUnit>();
						foreach (ActiveUnit current in list)
						{
							if (!Information.IsNothing(current.GetAssignedMission(false)) && current.GetAssignedMission(false) == this)
							{
								Contact[] targets = current.GetAI().GetTargets();
								for (int i = 0; i < targets.Length; i++)
								{
									Contact contact = targets[i];
									if (!current.GetWeaponry().method_57(contact) && current.GetAI().GetTargetingBehavior(contact) == ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted && !contact.vmethod_40(this.PatrolAreaVertices, scenario_0, true))
									{
										current.GetAI().DropTargeting(contact, true);
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
					ex2.Data.Add("Error at 100645", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x00029095 File Offset: 0x00027295
		public bool method_45(Scenario scenario_0)
		{
			return this.IWWR;
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x00290ED0 File Offset: 0x0028F0D0
		public void method_46(Scenario scenario_0, bool bool_23)
		{
			checked
			{
				try
				{
					this.IWWR = bool_23;
					if (!bool_23)
					{
						bool flag = this.method_43(scenario_0);
						bool flag2 = this.method_42();
						if (!flag || flag2)
						{
							List<ActiveUnit> list = scenario_0.GetActiveUnitList().ToList<ActiveUnit>();
							foreach (ActiveUnit current in list)
							{
								if (!Information.IsNothing(current.GetAssignedMission(false)) && current.GetAssignedMission(false) == this)
								{
									Contact[] targets = current.GetAI().GetTargets();
									if (targets.Count<Contact>() > 0)
									{
										Contact[] array = targets;
										for (int i = 0; i < array.Length; i++)
										{
											Contact contact = array[i];
											if (current.GetAI().GetTargetingBehavior(contact) == ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted && !current.GetWeaponry().method_57(contact))
											{
												if (!flag)
												{
													if (contact.vmethod_40(this.PatrolAreaVertices, scenario_0, true))
													{
														goto IL_11C;
													}
												}
												else if (!flag2 || contact.vmethod_40(this.PatrolAreaVertices, scenario_0, true) || contact.vmethod_40(this.ProsecutionAreaVertices, scenario_0, true))
												{
													goto IL_11C;
												}
												current.GetAI().DropTargeting(contact, true);
											}
											IL_11C:;
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
					ex2.Data.Add("Error at 101296", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x0029109C File Offset: 0x0028F29C
		private Patrol(Side side_0, Scenario scenario_0) : base(side_0, scenario_0)
		{
			this.PatrolAreaVertices = new List<ReferencePoint>();
			this.list_6 = new List<ReferencePoint>();
			this.list_7 = new List<ReferencePoint>();
			this.list_8 = new List<ReferencePoint>();
			this.list_9 = new List<ReferencePoint>();
			this.list_10 = new List<ReferencePoint>();
			this.list_11 = new List<ReferencePoint>();
			this.list_12 = new List<ReferencePoint>();
			this.list_13 = new List<ReferencePoint>();
			this.list_14 = new List<ReferencePoint>();
			this.ProsecutionAreaVertices = new List<ReferencePoint>();
			this.list_16 = new List<ReferencePoint>();
			this.list_17 = new List<ReferencePoint>();
			this.list_18 = new List<ReferencePoint>();
			this.list_19 = new List<ReferencePoint>();
			this.list_20 = new List<ReferencePoint>();
			this.IsMission = true;
			this.MissionClass = Mission._MissionClass.Patrol;
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x00291170 File Offset: 0x0028F370
		public Patrol(Side side_0, Scenario scenario_0, string string_3, Mission.MissionCategory enum58_1, List<ReferencePoint> list_21, GlobalVariables.PatrolType patrolType_1, bool bool_23) : base(side_0, scenario_0)
		{
			this.PatrolAreaVertices = new List<ReferencePoint>();
			this.list_6 = new List<ReferencePoint>();
			this.list_7 = new List<ReferencePoint>();
			this.list_8 = new List<ReferencePoint>();
			this.list_9 = new List<ReferencePoint>();
			this.list_10 = new List<ReferencePoint>();
			this.list_11 = new List<ReferencePoint>();
			this.list_12 = new List<ReferencePoint>();
			this.list_13 = new List<ReferencePoint>();
			this.list_14 = new List<ReferencePoint>();
			this.ProsecutionAreaVertices = new List<ReferencePoint>();
			this.list_16 = new List<ReferencePoint>();
			this.list_17 = new List<ReferencePoint>();
			this.list_18 = new List<ReferencePoint>();
			this.list_19 = new List<ReferencePoint>();
			this.list_20 = new List<ReferencePoint>();
			this.IsMission = true;
			this.MissionClass = Mission._MissionClass.Patrol;
			this.Name = string_3;
			this.category = enum58_1;
			this.PatrolAreaVertices = list_21;
			this.patrolType = patrolType_1;
			this.OTR = true;
			this.StationThrottle_Aircraft = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Loiter);
			this.TransitThrottle_Aircraft = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
			this.AttackThrottle_Aircraft = null;
			this.TransitTerrainFollowing_Aircraft = false;
			this.StationTerrainFollowing_Aircraft = false;
			this.AttackTerrainFollowing_Aircraft = false;
			this.TransitThrottle_Submarine = ActiveUnit.Throttle.Cruise;
			this.StationThrottle_Submarine = ActiveUnit.Throttle.Loiter;
			this.AttackThrottle_Submarine = null;
			this.TransitThrottle_Ship = ActiveUnit.Throttle.Cruise;
			this.StationThrottle_Ship = ActiveUnit.Throttle.Loiter;
			this.AttackThrottle_Ship = null;
			this.TransitThrottle_Facility = ActiveUnit.Throttle.Cruise;
			this.StationThrottle_Facility = ActiveUnit.Throttle.Loiter;
			this.AttackThrottle_Facility = null;
			this.IOPA = true;
			this.IWWR = true;
			this.SAD = false;
			this.UseFlightSizeHardLimit = true;
			switch (this.patrolType)
			{
			case GlobalVariables.PatrolType.ASW:
				this.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.No));
				this.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, false, false, false, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit));
				this.m_Doctrine.SetWCS_SubmarineDoctrine(scenario_0, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
				this.SAD = true;
				this.m_FlightSize = Mission._FlightSize.SingleAircraft;
				break;
			case GlobalVariables.PatrolType.ASuW_Naval:
				this.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
				this.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, false, false, false, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit));
				this.m_Doctrine.SetWCS_SubmarineDoctrine(scenario_0, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
				this.m_FlightSize = Mission._FlightSize.SingleAircraft;
				break;
			case GlobalVariables.PatrolType.AAW:
				this.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
				this.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, false, false, false, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit));
				this.m_FlightSize = Mission._FlightSize.TwoAircraft;
				break;
			case GlobalVariables.PatrolType.ASuW_Land:
				this.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
				this.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, false, false, false, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit));
				this.m_FlightSize = Mission._FlightSize.TwoAircraft;
				break;
			case GlobalVariables.PatrolType.ASuW_Mixed:
				this.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
				this.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, false, false, false, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit));
				this.m_Doctrine.SetWCS_SubmarineDoctrine(scenario_0, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Free));
				this.m_FlightSize = Mission._FlightSize.TwoAircraft;
				break;
			case GlobalVariables.PatrolType.SEAD:
				this.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
				this.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, false, false, false, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit));
				this.m_FlightSize = Mission._FlightSize.TwoAircraft;
				break;
			default:
				this.m_Doctrine.SetWinchesterShotgunRTBDoctrine(scenario_0, false, false, false, new Doctrine._WeaponStateRTB?(Doctrine._WeaponStateRTB.YesLastUnit));
				this.m_Doctrine.SetBingoJokerRTBDoctrine(scenario_0, false, false, false, new Doctrine._FuelStateRTB?(Doctrine._FuelStateRTB.YesFirstUnit));
				this.m_FlightSize = Mission._FlightSize.SingleAircraft;
				break;
			}
			this.m_GroupSize = Mission._GroupSize.const_1;
			this.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(scenario_0, false, null, false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_1));
			this.m_Doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_1, scenario_0);
			this.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
			string prompt = "";
			if (bool_23 && !ActiveUnit_Navigator.smethod_6(ref this.PatrolAreaVertices, ref prompt, "", "Patrol Mission '" + this.Name + "'"))
			{
				Interaction.MsgBox(prompt, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x00291580 File Offset: 0x0028F780
		public override string GetTypeString(Scenario scenario_0)
		{
			string result;
			switch (this.patrolType)
			{
			case GlobalVariables.PatrolType.ASW:
				result = "反潜巡逻";
				break;
			case GlobalVariables.PatrolType.ASuW_Naval:
				result = "反舰巡逻(海上)";
				break;
			case GlobalVariables.PatrolType.AAW:
				result = "空空巡逻";
				break;
			case GlobalVariables.PatrolType.ASuW_Land:
				result = "反舰巡逻(地面)";
				break;
			case GlobalVariables.PatrolType.ASuW_Mixed:
				result = "反舰巡逻(混合)";
				break;
			case GlobalVariables.PatrolType.SEAD:
				result = "压制敌防空巡逻";
				break;
			case GlobalVariables.PatrolType.SeaControl:
				result = "海上控制巡逻";
				break;
			default:
				result = this.patrolType.ToString();
				break;
			}
			return result;
		}

		// Token: 0x04002EB2 RID: 11954
		public GlobalVariables.PatrolType patrolType;

		// Token: 0x04002EB3 RID: 11955
		public List<ReferencePoint> PatrolAreaVertices;

		// Token: 0x04002EB4 RID: 11956
		public List<ReferencePoint> list_6;

		// Token: 0x04002EB5 RID: 11957
		public List<ReferencePoint> list_7;

		// Token: 0x04002EB6 RID: 11958
		public List<ReferencePoint> list_8;

		// Token: 0x04002EB7 RID: 11959
		public List<ReferencePoint> list_9;

		// Token: 0x04002EB8 RID: 11960
		public List<ReferencePoint> list_10;

		// Token: 0x04002EB9 RID: 11961
		public List<ReferencePoint> list_11;

		// Token: 0x04002EBA RID: 11962
		public List<ReferencePoint> list_12;

		// Token: 0x04002EBB RID: 11963
		public List<ReferencePoint> list_13;

		// Token: 0x04002EBC RID: 11964
		public List<ReferencePoint> list_14;

		// Token: 0x04002EBD RID: 11965
		public List<ReferencePoint> ProsecutionAreaVertices;

		// Token: 0x04002EBE RID: 11966
		public List<ReferencePoint> list_16;

		// Token: 0x04002EBF RID: 11967
		public List<ReferencePoint> list_17;

		// Token: 0x04002EC0 RID: 11968
		public List<ReferencePoint> list_18;

		// Token: 0x04002EC1 RID: 11969
		public List<ReferencePoint> list_19;

		// Token: 0x04002EC2 RID: 11970
		public List<ReferencePoint> list_20;

		// Token: 0x04002EC3 RID: 11971
		public bool OTR;

		// Token: 0x04002EC4 RID: 11972
		public int MNOS;

		// Token: 0x04002EC5 RID: 11973
		private bool IOPA;

		// Token: 0x04002EC6 RID: 11974
		private bool IWWR;

		// Token: 0x04002EC7 RID: 11975
		public bool AEOIPA;

		// Token: 0x04002EC8 RID: 11976
		public bool SAD;

		// Token: 0x04002EC9 RID: 11977
		public Mission._FlightQty MinAircraftReq;

		// Token: 0x04002ECA RID: 11978
		public ActiveUnit.Throttle? TransitThrottle_Aircraft;

		// Token: 0x04002ECB RID: 11979
		public ActiveUnit.Throttle? StationThrottle_Aircraft;

		// Token: 0x04002ECC RID: 11980
		public ActiveUnit.Throttle? AttackThrottle_Aircraft;

		// Token: 0x04002ECD RID: 11981
		public float? TransitAltitude_Aircraft;

		// Token: 0x04002ECE RID: 11982
		public float? StationAltitude_Aircraft;

		// Token: 0x04002ECF RID: 11983
		public float? AttackAltitude_Aircraft;

		// Token: 0x04002ED0 RID: 11984
		public float? AttackDistance_Aircraft;

		// Token: 0x04002ED1 RID: 11985
		public bool TransitTerrainFollowing_Aircraft;

		// Token: 0x04002ED2 RID: 11986
		public bool StationTerrainFollowing_Aircraft;

		// Token: 0x04002ED3 RID: 11987
		public bool AttackTerrainFollowing_Aircraft;

		// Token: 0x04002ED4 RID: 11988
		public ActiveUnit.Throttle TransitThrottle_Submarine;

		// Token: 0x04002ED5 RID: 11989
		public ActiveUnit.Throttle StationThrottle_Submarine;

		// Token: 0x04002ED6 RID: 11990
		public ActiveUnit.Throttle? AttackThrottle_Submarine;

		// Token: 0x04002ED7 RID: 11991
		public float? TransitDepth_Submarine;

		// Token: 0x04002ED8 RID: 11992
		public float? StationDepth_Submarine;

		// Token: 0x04002ED9 RID: 11993
		public float? AttackDepth_Submarine;

		// Token: 0x04002EDA RID: 11994
		public float? AttackDistance_Submarine;

		// Token: 0x04002EDB RID: 11995
		public ActiveUnit.Throttle TransitThrottle_Ship;

		// Token: 0x04002EDC RID: 11996
		public ActiveUnit.Throttle StationThrottle_Ship;

		// Token: 0x04002EDD RID: 11997
		public ActiveUnit.Throttle? AttackThrottle_Ship;

		// Token: 0x04002EDE RID: 11998
		public float? AttackDistance_Ship;

		// Token: 0x04002EDF RID: 11999
		public ActiveUnit.Throttle TransitThrottle_Facility;

		// Token: 0x04002EE0 RID: 12000
		public ActiveUnit.Throttle StationThrottle_Facility;

		// Token: 0x04002EE1 RID: 12001
		public ActiveUnit.Throttle? AttackThrottle_Facility;

		// Token: 0x04002EE2 RID: 12002
		public Mission._Formation Formation_Cruise;

		// Token: 0x04002EE3 RID: 12003
		public Mission._Formation Formation_Attack;
	}
}

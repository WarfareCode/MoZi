using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace Command_Core
{
	// Token: 转场使命
	public sealed class FerryMission : Mission
	{
		// Token: 保存
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, ref Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("FerryMission");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("Name", this.Name);
				xmlWriter_0.WriteElementString("Category", ((byte)this.category).ToString());
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Behavior";
				byte tankerUsage = (byte)this.ferryMissionBehavior;
				xmlWriter.WriteElementString(localName, tankerUsage.ToString());
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
				xmlWriter_0.WriteElementString("NDH", this.NameOfDestinationHost);
				if (base.GetMissionStatus(scenario_0) != Mission._MissionStatus.Activation)
				{
					xmlWriter_0.WriteElementString("Status", ((byte)base.GetMissionStatus(scenario_0)).ToString());
				}
				if (this.FerryThrottle_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("FerryThrottle_Aircraft", Conversions.ToString((int)this.FerryThrottle_Aircraft.Value));
				}
				if (this.FerryAltitude_Aircraft.HasValue)
				{
					xmlWriter_0.WriteElementString("FerryAltitude_Aircraft", this.FerryAltitude_Aircraft.Value.ToString());
				}
				xmlWriter_0.WriteElementString("FerryTerrainFollowing_Aircraft", this.FerryTerrainFollowing_Aircraft.ToString());
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "FlightSize";
				int num = (int)this.m_FlightSize;
				xmlWriter2.WriteElementString(localName2, num.ToString());
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "Formation_Cruise";
				num = (int)this.Formation_Cruise;
				xmlWriter3.WriteElementString(localName3, num.ToString());
				XmlWriter xmlWriter4 = xmlWriter_0;
				string localName4 = "MinAircraftReq";
				num = (int)this.MinAircraftReq;
				xmlWriter4.WriteElementString(localName4, num.ToString());
				xmlWriter_0.WriteElementString("UseFlightSizeHardLimit", this.UseFlightSizeHardLimit.ToString());
				XmlWriter xmlWriter5 = xmlWriter_0;
				string localName5 = "TankerUsage";
				tankerUsage = (byte)this.TankerUsage;
				xmlWriter5.WriteElementString(localName5, tankerUsage.ToString());
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
				ex2.Data.Add("Error at 100633", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005B42 RID: 23362 RVA: 0x00028F80 File Offset: 0x00027180
		private FerryMission(Side side_0, Scenario scenario_0) : base(side_0, scenario_0)
		{
			this.IsMission = true;
			this.MissionClass = Mission._MissionClass.Ferry;
		}

		// Token: 0x06005B43 RID: 23363 RVA: 0x0028A064 File Offset: 0x00288264
		public static FerryMission Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, Scenario scenario_0)
		{
			FerryMission ferryMission = null;
			FerryMission result;
			try
			{
				FerryMission ferryMission2 = new FerryMission(null, scenario_0);
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num > 1908276361u)
						{
							if (num <= 2667312101u)
							{
								if (num <= 2284267453u)
								{
									if (num <= 2180604875u)
									{
										if (num != 2045435587u)
										{
											if (num == 2180604875u && Operators.CompareString(name, "FlightList", false) == 0)
											{
												ferryMission2.FlightList = Mission.Flight.Load(ref xmlNode, ref dictionary_0, scenario_0);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name, "FerryThrottle", false) != 0)
										{
											continue;
										}
									}
									else if (num != 2233408560u)
									{
										if (num != 2284267453u)
										{
											continue;
										}
										if (Operators.CompareString(name, "FerryAltitude", false) != 0)
										{
											continue;
										}
										goto IL_471;
									}
									else
									{
										if (Operators.CompareString(name, "Deactivation_UnassignUnits", false) == 0)
										{
											ferryMission2.Deactivation_UnassignUnits = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 2367170728u)
								{
									if (num != 2344440002u)
									{
										if (num == 2367170728u && Operators.CompareString(name, "FuelQtyToStartLookingForTanker_Airborne", false) == 0)
										{
											ferryMission2.FuelQtyToStartLookingForTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else if (Operators.CompareString(name, "FerryThrottle_Aircraft", false) != 0)
									{
										continue;
									}
								}
								else if (num != 2435049132u)
								{
									if (num != 2487526210u)
									{
										if (num == 2667312101u && Operators.CompareString(name, "UseFlightSizeHardLimit", false) == 0)
										{
											ferryMission2.UseFlightSizeHardLimit = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "FlightSize", false) == 0)
										{
											ferryMission2.m_FlightSize = (Mission._FlightSize)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TankerMissionList", false) == 0)
									{
										IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator2.MoveNext())
											{
												XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
												ferryMission2.TankerMissionNameList.Add(xmlNode2.InnerText);
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
										goto IL_2A6;
									}
									continue;
								}
								ferryMission2.FerryThrottle_Aircraft = new ActiveUnit.Throttle?((ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText));
								continue;
							}
							IL_2A6:
							if (num <= 3591985774u)
							{
								if (num <= 2947802513u)
								{
									if (num != 2940441098u)
									{
										if (num == 2947802513u && Operators.CompareString(name, "Category", false) == 0)
										{
											ferryMission2.category = (Mission.MissionCategory)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "END", false) == 0)
										{
											DateTime value = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											ferryMission2.SetEndTime(new DateTime?(value));
											continue;
										}
										continue;
									}
								}
								else if (num != 3107456787u)
								{
									if (num != 3322127180u)
									{
										if (num == 3591985774u && Operators.CompareString(name, "StartTime", false) != 0)
										{
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "CheckBox_DeleteMission", false) == 0)
										{
											ferryMission2.CheckBox_DeleteMission = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "NominalDestinationHost", false) == 0)
									{
										goto IL_86E;
									}
									continue;
								}
							}
							else if (num <= 3749943133u)
							{
								if (num != 3718927628u)
								{
									if (num != 3749943133u)
									{
										if (num == 3802618614u && Operators.CompareString(name, "TankerFollowsReceivers", false) == 0)
										{
											ferryMission2.bTankerFollowsReceivers = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TankerUsage", false) == 0)
										{
											ferryMission2.TankerUsage = (Mission.TankerMethod)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (Operators.CompareString(name, "FerryAltitude_Aircraft", false) != 0)
								{
									continue;
								}
							}
							else if (num != 3838663019u)
							{
								if (num != 3905033942u)
								{
									if (num == 4100651282u && Operators.CompareString(name, "MaxReceiversInQueuePerTanker_Airborne", false) == 0)
									{
										ferryMission2.MaxReceiversInQueuePerTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Formation_Cruise", false) == 0)
									{
										ferryMission2.Formation_Cruise = (Mission._Formation)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "MinAircraftReq", false) == 0)
								{
									ferryMission2.MinAircraftReq = (Mission._FlightQty)Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							IL_471:
							ferryMission2.FerryAltitude_Aircraft = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
							continue;
						}
						if (num <= 1025497782u)
						{
							if (num <= 461095311u)
							{
								if (num <= 227845695u)
								{
									if (num != 6222351u)
									{
										if (num == 227845695u && Operators.CompareString(name, "START", false) == 0)
										{
											DateTime value2 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
											ferryMission2.SetStartTime(new DateTime?(value2));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Status", false) == 0)
										{
											ferryMission2.SetMissionStatus(scenario_0, (Mission._MissionStatus)Conversions.ToByte(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else if (num != 266367750u)
								{
									if (num == 461095311u && Operators.CompareString(name, "SISIH", false) == 0)
									{
										ferryMission2.SISIH = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Name", false) == 0)
									{
										ferryMission2.Name = xmlNode.InnerText;
										continue;
									}
									continue;
								}
							}
							else if (num <= 620569374u)
							{
								if (num != 521774151u)
								{
									if (num == 620569374u && Operators.CompareString(name, "TankerMinNumber_Airborne", false) == 0)
									{
										ferryMission2.TankerMinNumber_Airborne = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Behavior", false) == 0)
									{
										ferryMission2.ferryMissionBehavior = (FerryMission.FerryMissionBehavior)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 721363522u)
							{
								if (num != 882301358u)
								{
									if (num == 1025497782u && Operators.CompareString(name, "TankerMinNumber_Total", false) == 0)
									{
										ferryMission2.TankerMinNumber_Total = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "LaunchMissionWithoutTankersInPlace", false) == 0)
									{
										ferryMission2.LaunchMissionWithoutTankersInPlace = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "TankerMaxDistance_Airborne", false) == 0)
								{
									ferryMission2.TankerMaxDistance_Airborne = Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 1507328069u)
						{
							if (num <= 1074512784u)
							{
								if (num != 1062263555u)
								{
									if (num == 1074512784u && Operators.CompareString(name, "TimeOnTarget", false) == 0)
									{
										DateTime value3 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										ferryMission2.SetTimeOnTarget(new DateTime?(value3));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "EmptySlotsList", false) == 0)
									{
										ferryMission2.EmptySlotsList = Mission.EmptySlot.Load(ref xmlNode, ref dictionary_0, scenario_0);
										continue;
									}
									continue;
								}
							}
							else if (num != 1422437055u)
							{
								if (num != 1458105184u)
								{
									if (num != 1507328069u || Operators.CompareString(name, "NDH", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "ID", false) != 0)
									{
										continue;
									}
									if (!dictionary_0.ContainsKey(xmlNode.InnerText))
									{
										ferryMission2.SetGuid(xmlNode.InnerText);
										dictionary_0.Add(ferryMission2.GetGuid(), ferryMission2);
										continue;
									}
									ferryMission = (FerryMission)dictionary_0[xmlNode.InnerText];
									result = ferryMission;
									return result;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Doctrine", false) == 0)
								{
									ferryMission2.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode, ferryMission2);
									continue;
								}
								continue;
							}
						}
						else if (num <= 1688531320u)
						{
							if (num != 1579537194u)
							{
								if (num == 1688531320u && Operators.CompareString(name, "TankerMinNumber_Station", false) == 0)
								{
									ferryMission2.TankerMinNumber_Station = Conversions.ToInteger(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "TakeOffTime", false) == 0)
								{
									DateTime value4 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
									ferryMission2.SetTakeOffTime(new DateTime?(value4));
									continue;
								}
								continue;
							}
						}
						else if (num != 1795334850u)
						{
							if (num != 1864098670u)
							{
								if (num == 1908276361u && Operators.CompareString(name, "CheckBox_OrderRTB", false) == 0)
								{
									ferryMission2.CheckBox_OrderRTB = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "FerryTerrainFollowing_Aircraft", false) == 0)
								{
									ferryMission2.FerryTerrainFollowing_Aircraft = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "ST", false) == 0)
							{
								continue;
							}
							continue;
						}
						IL_86E:
						ferryMission2.NameOfDestinationHost = xmlNode.InnerText;
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				ActiveUnit.Throttle? ferryThrottle_Aircraft = ferryMission2.FerryThrottle_Aircraft;
				byte? b = ferryThrottle_Aircraft.HasValue ? new byte?((byte)ferryThrottle_Aircraft.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					ferryMission2.FerryThrottle_Aircraft = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
				}
				if (ferryMission2.m_Doctrine.RefuelSelectionHasNoValue())
				{
					ferryMission2.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
				}
				ferryMission = ferryMission2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100634", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ferryMission = new FerryMission(null, scenario_0);
				ProjectData.ClearProjectError();
			}
			result = ferryMission;
			return result;
		}

		// Token: 0x06005B44 RID: 23364 RVA: 0x0028ABE4 File Offset: 0x00288DE4
		public FerryMission.FerryMissionBehavior GetFerryMissionBehavior()
		{
			return this.ferryMissionBehavior;
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x00028FA3 File Offset: 0x000271A3
		public void SetFerryMissionBehavior(FerryMission.FerryMissionBehavior ferryMissionBehavior_1)
		{
			this.ferryMissionBehavior = ferryMissionBehavior_1;
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x0028ABFC File Offset: 0x00288DFC
		public override string GetTypeString(Scenario scenario_0)
		{
			string str = "转场";
			if (!Information.IsNothing(this.GetDestinationHost(scenario_0)))
			{
				str = str + " - 目的地: " + this.GetDestinationHost(scenario_0).Name;
			}
			return str + " (" + this.ferryMissionBehavior.ToString() + ")";
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x0028AC58 File Offset: 0x00288E58
		public ActiveUnit GetDestinationHost(Scenario scenario_0)
		{
			ActiveUnit destinationHost;
			if (!Information.IsNothing(this.DestinationHost))
			{
				destinationHost = this.DestinationHost;
			}
			else
			{
				if (!string.IsNullOrEmpty(this.NameOfDestinationHost))
				{
					this.DestinationHost = scenario_0.GetActiveUnits()[this.NameOfDestinationHost];
				}
				destinationHost = this.DestinationHost;
			}
			return destinationHost;
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x00028FAC File Offset: 0x000271AC
		public void SetDestinationHost(Scenario scenario_0, ActiveUnit activeUnit_)
		{
			this.DestinationHost = activeUnit_;
			this.NameOfDestinationHost = this.DestinationHost.GetGuid();
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x0028ACAC File Offset: 0x00288EAC
		public FerryMission(Side side_0, Scenario scenario_0, string string_4, Mission.MissionCategory MissionCategory_, ActiveUnit activeUnit_1) : base(side_0, scenario_0)
		{
			this.IsMission = true;
			this.MissionClass = Mission._MissionClass.Ferry;
			this.Name = string_4;
			this.category = MissionCategory_;
			this.SetDestinationHost(scenario_0, activeUnit_1);
			this.FerryThrottle_Aircraft = new ActiveUnit.Throttle?(ActiveUnit.Throttle.Cruise);
			this.m_FlightSize = Mission._FlightSize.FourAircraft;
			this.UseFlightSizeHardLimit = true;
			this.m_Doctrine.SetRefuelSelectionDoctrine(scenario_0, false, false, false, false, new Doctrine._RefuelSelection?(Doctrine._RefuelSelection.const_2));
		}

		// Token: 0x04002E78 RID: 11896
		private FerryMission.FerryMissionBehavior ferryMissionBehavior;

		// Token: 0x04002E79 RID: 11897
		private ActiveUnit DestinationHost;

		// Token: 0x04002E7A RID: 11898
		private string NameOfDestinationHost = "";

		// Token: 0x04002E7B RID: 11899
		public Mission._FlightQty MinAircraftReq;

		// Token: 0x04002E7C RID: 11900
		public ActiveUnit.Throttle? FerryThrottle_Aircraft;

		// Token: 0x04002E7D RID: 11901
		public float? FerryAltitude_Aircraft;

		// Token: 0x04002E7E RID: 11902
		public bool FerryTerrainFollowing_Aircraft;

		// Token: 0x04002E7F RID: 11903
		public Mission._Formation Formation_Cruise;

		// Token: 0x02000B13 RID: 2835
		public enum FerryMissionBehavior : byte
		{
			// Token: 0x04002E81 RID: 11905
			OneWay,
			// Token: 0x04002E82 RID: 11906
			Cycle,
			// Token: 0x04002E83 RID: 11907
			Random
		}
	}
}

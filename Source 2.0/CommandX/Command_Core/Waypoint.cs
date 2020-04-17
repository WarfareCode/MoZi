using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace Command_Core
{
	// Token: 路径点
	public sealed class Waypoint : GeoPoint
	{
		// 保存
		public override void Save(ref XmlWriter theWriter, ref HashSet<string> ObjectsAlreadySerialized)
		{
			try
			{
				theWriter.WriteStartElement("WPoint");
				theWriter.WriteElementString("ID", base.GetGuid());
				if (!Information.IsNothing(ObjectsAlreadySerialized))
				{
					if (ObjectsAlreadySerialized.Contains(base.GetGuid()))
					{
						theWriter.WriteEndElement();
						return;
					}
					ObjectsAlreadySerialized.Add(base.GetGuid());
				}
				theWriter.WriteElementString("Lon", XmlConvert.ToString(base.GetLongitude()));
				theWriter.WriteElementString("Lat", XmlConvert.ToString(base.GetLatitude()));
				if (this.DesiredAltitude.HasValue)
				{
					theWriter.WriteElementString("DesiredAltitude", this.DesiredAltitude.ToString());
				}
				if (this.DesiredAltitude_TerrainFollowing.HasValue)
				{
					theWriter.WriteElementString("DesiredAltitude_TerrainFollowing", this.DesiredAltitude_TerrainFollowing.ToString());
				}
				if (this.DesiredSpeed.HasValue)
				{
					theWriter.WriteElementString("DesiredSpeed", this.DesiredSpeed.ToString());
				}
				theWriter.WriteElementString("Name", this.Name.ToString());
				XmlWriter xmlWriter = theWriter;
				string localName = "Creator";
				int num = (int)this.Creator;
				xmlWriter.WriteElementString(localName, num.ToString());
				XmlWriter xmlWriter2 = theWriter;
				string localName2 = "Type";
				num = (int)this.waypointType;
				xmlWriter2.WriteElementString(localName2, num.ToString());
				XmlWriter xmlWriter3 = theWriter;
				string localName3 = "Category";
				num = (int)this.Category;
				xmlWriter3.WriteElementString(localName3, num.ToString());
				if (!Information.IsNothing(this.Description))
				{
					theWriter.WriteElementString("Description", this.Description.ToString());
				}
				theWriter.WriteElementString("ThrottlePreset", ((byte)this.GetThrottlePreset()).ToString());
				theWriter.WriteElementString("AltitudePreset", ((byte)this.GetAltitudePreset()).ToString());
				theWriter.WriteElementString("DepthPreset", ((byte)this.GetDepthPreset()).ToString());
				XmlWriter xmlWriter4 = theWriter;
				string localName4 = "TurnRate"; // 转弯角速度
                byte b = (byte)this.TurnRate;
				xmlWriter4.WriteElementString(localName4, b.ToString());
				if (this.IsManualEditable)
				{
					theWriter.WriteElementString("IME", true.ToString());
				}
				theWriter.WriteElementString("TerrainFollowing", this.IsTerrainFollowing().ToString());
				if (this.DSO.HasValue)
				{
					theWriter.WriteElementString("DSO", this.DSO.ToString());
				}
				theWriter.WriteElementString("DAO", this.DAO.ToString());
				if (this.ArrivalTime_Zulu.HasValue)
				{
					theWriter.WriteElementString("Time_Zulu", this.ArrivalTime_Zulu.Value.ToBinary().ToString());
				}
				if (this.ArrivalTime_Local.HasValue)
				{
					theWriter.WriteElementString("Time_Local", this.ArrivalTime_Local.Value.ToBinary().ToString());
				}
				XmlWriter xmlWriter5 = theWriter;
				string localName5 = "TimeOfDay";
				b = (byte)this.TimeOfDay;
				xmlWriter5.WriteElementString(localName5, b.ToString());
				XmlWriter xmlWriter6 = theWriter;
				string localName6 = "TimeFixed";
				num = (int)this.TimeFixed;
				xmlWriter6.WriteElementString(localName6, num.ToString());
				XmlWriter xmlWriter7 = theWriter;
				string localName7 = "SpeedFixed";
				num = (int)this.SpeedFixed;
				xmlWriter7.WriteElementString(localName7, num.ToString());
				XmlWriter xmlWriter8 = theWriter;
				string localName8 = "FlightFormation";
				num = (int)this.FlightFormation;
				xmlWriter8.WriteElementString(localName8, num.ToString());
				XmlWriter xmlWriter9 = theWriter;
				string localName9 = "TankerUsage";
				b = (byte)this.TankerUsage;
				xmlWriter9.WriteElementString(localName9, b.ToString());
				theWriter.WriteStartElement("TankerMissionList");
				foreach (Mission current in this.TankerMissionList)
				{
					if (!Information.IsNothing(current))
					{
						theWriter.WriteElementString("ID", current.GetGuid());
					}
				}
				theWriter.WriteEndElement();
				if (this.LaunchMissionWithoutTankersInPlace)
				{
					theWriter.WriteElementString("LaunchMissionWithoutTankersInPlace", this.LaunchMissionWithoutTankersInPlace.ToString());
				}
				theWriter.WriteElementString("TankerMinNumber_Total", this.TankerMinNumber_Total.ToString());
				theWriter.WriteElementString("TankerMinNumber_Airborne", this.TankerMinNumber_Airborne.ToString());
				theWriter.WriteElementString("TankerMinNumber_Station", this.TankerMinNumber_Station.ToString());
				theWriter.WriteElementString("MaxReceiversInQueuePerTanker_Airborne", this.MaxReceiversInQueuePerTanker_Airborne.ToString());
				theWriter.WriteElementString("FuelQtyToStartLookingForTanker_Airborne", this.FuelQtyToStartLookingForTanker_Airborne.ToString());
				theWriter.WriteElementString("TankerMaxDistance_Airborne", this.TankerMaxDistance_Airborne.ToString());
				theWriter.WriteElementString("Leg_FuelRequired", this.Leg_FuelRequired.ToString());
				theWriter.WriteElementString("Leg_FuelRemaining", this.Leg_FuelRemaining.ToString());
				theWriter.WriteElementString("Leg_Time_Turn", this.Leg_Time_Turn.ToString());
				theWriter.WriteElementString("Leg_Time_Straight", this.Leg_Time_Straight.ToString());
				theWriter.WriteElementString("Leg_Time", this.Leg_Time.ToString());
				theWriter.WriteElementString("Leg_TotalTime", this.Leg_TotalTime.ToString());
				theWriter.WriteElementString("Leg_Distance", this.Leg_Distance.ToString());
				theWriter.WriteElementString("Leg_TotalDistance", this.Leg_TotalDistance.ToString());
				theWriter.WriteElementString("Hold_Time", this.Hold_Time.ToString());
				if (!Information.IsNothing(this.FlightplanPointsList) && this.FlightplanPointsList.Count > 0)
				{
					theWriter.WriteStartElement("FlightplanPointsList");
					foreach (Waypoint.Class126 current2 in this.FlightplanPointsList)
					{
						if (!Information.IsNothing(current2))
						{
							theWriter.WriteStartElement("FlightPlanSegment");
							theWriter.WriteElementString("StartLatitude", current2.StartLatitude.ToString());
							theWriter.WriteElementString("StartLongitude", current2.StartLongitude.ToString());
							theWriter.WriteElementString("EndLatitude", current2.EndLatitude.ToString());
							theWriter.WriteElementString("EndLongitude", current2.EndLongitude.ToString());
							theWriter.WriteEndElement();
						}
					}
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.WP_LeadElementWingman))
				{
					theWriter.WriteStartElement("WP_LeadElementWingman");
					this.WP_LeadElementWingman.Save(ref theWriter, ref ObjectsAlreadySerialized);
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.WP_SecondElement))
				{
					theWriter.WriteStartElement("WP_SecondElement");
					this.WP_SecondElement.Save(ref theWriter, ref ObjectsAlreadySerialized);
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.WP_SecondElementWingman))
				{
					theWriter.WriteStartElement("WP_SecondElementWingman");
					this.WP_SecondElementWingman.Save(ref theWriter, ref ObjectsAlreadySerialized);
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.WP_ThirdElement))
				{
					theWriter.WriteStartElement("WP_ThirdElement");
					this.WP_ThirdElement.Save(ref theWriter, ref ObjectsAlreadySerialized);
					theWriter.WriteEndElement();
				}
				if (!Information.IsNothing(this.WP_ThirdElementWingman))
				{
					theWriter.WriteStartElement("WP_ThirdElementWingman");
					this.WP_ThirdElementWingman.Save(ref theWriter, ref ObjectsAlreadySerialized);
					theWriter.WriteEndElement();
				}
				theWriter.WriteElementString("Leg_FuelRemaining_LeadElementWingman", this.Leg_FuelRemaining_LeadElementWingman.ToString());
				theWriter.WriteElementString("Leg_FuelRemaining_SecondElement", this.Leg_FuelRemaining_SecondElement.ToString());
				theWriter.WriteElementString("Leg_FuelRemaining_SecondElementWingman", this.Leg_FuelRemaining_SecondElementWingman.ToString());
				theWriter.WriteElementString("Leg_FuelRemaining_ThirdElement", this.Leg_FuelRemaining_ThirdElement.ToString());
				theWriter.WriteElementString("Leg_FuelRemaining_ThirdElementWingman", this.Leg_FuelRemaining_ThirdElementWingman.ToString());
				theWriter.WriteElementString("Leg_TotalDistance_LeadElementWingman", this.Leg_TotalDistance_LeadElementWingman.ToString());
				theWriter.WriteElementString("Leg_TotalDistance_SecondElement", this.Leg_TotalDistance_SecondElement.ToString());
				theWriter.WriteElementString("Leg_TotalDistance_SecondElementWingman", this.Leg_TotalDistance_SecondElementWingman.ToString());
				theWriter.WriteElementString("Leg_TotalDistance_ThirdElement", this.Leg_TotalDistance_ThirdElement.ToString());
				theWriter.WriteElementString("Leg_TotalDistance_ThirdElementWingman", this.Leg_TotalDistance_ThirdElementWingman.ToString());
				Doctrine doctrine = this.m_Doctrine;
				Scenario scenario = null;
				doctrine.Save(ref theWriter, ref scenario, "Doctrine");
				theWriter.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100587", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x00273840 File Offset: 0x00271A40
		public static Waypoint smethod_9(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0)
		{
			Waypoint waypoint = null;
			Waypoint result;
			try
			{
				Waypoint waypoint2 = new Waypoint();
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num > 2066337159u)
						{
							if (num <= 3001749054u)
							{
								if (num <= 2564648390u)
								{
									if (num <= 2435049132u)
									{
										if (num <= 2367170728u)
										{
											if (num != 2297250623u)
											{
												if (num == 2367170728u && Operators.CompareString(name, "FuelQtyToStartLookingForTanker_Airborne", false) == 0)
												{
													waypoint2.FuelQtyToStartLookingForTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "Time_Zulu", false) == 0)
												{
													DateTime value = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
													waypoint2.ArrivalTime_Zulu = new DateTime?(value);
													continue;
												}
												continue;
											}
										}
										else
										{
											if (num != 2409420443u)
											{
												if (num != 2435049132u || Operators.CompareString(name, "TankerMissionList", false) != 0)
												{
													continue;
												}
												IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
												try
												{
													while (enumerator2.MoveNext())
													{
														XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
														waypoint2.list_0.Add(xmlNode2.InnerText);
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
											if (Operators.CompareString(name, "IsManualEditable", false) != 0)
											{
												continue;
											}
										}
									}
									else if (num <= 2489793765u)
									{
										if (num != 2489335145u)
										{
											if (num == 2489793765u && Operators.CompareString(name, "Leg_FuelRequired", false) == 0)
											{
												waypoint2.Leg_FuelRequired = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Leg_TotalDistance", false) == 0)
											{
												waypoint2.Leg_TotalDistance = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
									}
									else if (num != 2527167325u)
									{
										if (num == 2564648390u && Operators.CompareString(name, "Lon", false) == 0)
										{
											waypoint2.SetLongitude(XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", ".")));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TerrainFollowing", false) == 0)
										{
											waypoint2.SetIsTerrainFollowing(Conversions.ToBoolean(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else if (num <= 2746357952u)
								{
									if (num <= 2691982084u)
									{
										if (num != 2600484162u)
										{
											if (num != 2691982084u || Operators.CompareString(name, "DesiredAltitude_TerrainFollowing", false) != 0)
											{
												continue;
											}
											if (Operators.CompareString(xmlNode.InnerText, false.ToString(), false) == 0)
											{
												waypoint2.DesiredAltitude_TerrainFollowing = null;
												continue;
											}
											waypoint2.DesiredAltitude_TerrainFollowing = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Leg_FuelRemaining_LeadElementWingman", false) == 0)
											{
												waypoint2.Leg_FuelRemaining_LeadElementWingman = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
									}
									else if (num != 2728089754u)
									{
										if (num == 2746357952u && Operators.CompareString(name, "AltitudePreset", false) == 0)
										{
											waypoint2.SetAltitudePreset((ActiveUnit_AI._AltitudePreset)Conversions.ToByte(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "SpeedFixed", false) == 0)
										{
											waypoint2.SpeedFixed = (Waypoint.Enum52)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num <= 2947802513u)
								{
									if (num != 2749693904u)
									{
										if (num == 2947802513u && Operators.CompareString(name, "Category", false) == 0)
										{
											waypoint2.Category = (Waypoint._Category)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "DesiredSpeed", false) != 0)
										{
											continue;
										}
										if (Operators.CompareString(xmlNode.InnerText, false.ToString(), false) == 0)
										{
											waypoint2.DesiredSpeed = null;
											continue;
										}
										waypoint2.DesiredSpeed = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
								}
								else if (num != 2969831622u)
								{
									if (num == 3001749054u && Operators.CompareString(name, "Lat", false) == 0)
									{
										waypoint2.SetLatitude(XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", ".")));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Leg_FuelRemaining_ThirdElement", false) == 0)
									{
										waypoint2.Leg_FuelRemaining_ThirdElement = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
										continue;
									}
									continue;
								}
							}
							else if (num <= 3749943133u)
							{
								if (num <= 3386968880u)
								{
									if (num <= 3377934495u)
									{
										if (num != 3126726711u)
										{
											if (num == 3377934495u && Operators.CompareString(name, "Leg_FuelRemaining_ThirdElementWingman", false) == 0)
											{
												waypoint2.Leg_FuelRemaining_ThirdElementWingman = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "DesiredAltitudeOverride", false) == 0)
											{
												goto IL_1181;
											}
											continue;
										}
									}
									else
									{
										if (num != 3384885066u)
										{
											if (num != 3386968880u || Operators.CompareString(name, "WP_LeadElementWingman", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator3.MoveNext())
												{
													XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
													waypoint2.WP_LeadElementWingman = Waypoint.smethod_9(ref xmlNode3, ref dictionary_0);
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
										if (Operators.CompareString(name, "IME", false) != 0)
										{
											continue;
										}
									}
								}
								else if (num <= 3607250409u)
								{
									if (num != 3512062061u)
									{
										if (num == 3607250409u && Operators.CompareString(name, "Leg_Time_Turn", false) == 0)
										{
											waypoint2.Leg_Time_Turn = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Type", false) != 0)
										{
											continue;
										}
										if (Versioned.IsNumeric(xmlNode.InnerText))
										{
											waypoint2.waypointType = (Waypoint.WaypointType)Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										waypoint2.waypointType = (Waypoint.WaypointType)Enum.Parse(typeof(Waypoint.WaypointType), xmlNode.InnerText, true);
										continue;
									}
								}
								else if (num != 3741050010u)
								{
									if (num == 3749943133u && Operators.CompareString(name, "TankerUsage", false) == 0)
									{
										waypoint2.TankerUsage = (Mission.TankerMethod)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "FlightFormation", false) == 0)
									{
										waypoint2.FlightFormation = (Waypoint._FlightFormation)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (num <= 3850654870u)
								{
									if (num <= 3784529633u)
									{
										if (num != 3752039926u)
										{
											if (num != 3784529633u || Operators.CompareString(name, "WP_SecondElement", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator4 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator4.MoveNext())
												{
													XmlNode xmlNode4 = (XmlNode)enumerator4.Current;
													waypoint2.WP_SecondElement = Waypoint.smethod_9(ref xmlNode4, ref dictionary_0);
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
										if (Operators.CompareString(name, "Leg_TotalDistance_ThirdElementWingman", false) == 0)
										{
											waypoint2.Leg_TotalDistance_ThirdElementWingman = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
									else if (num != 3828591074u)
									{
										if (num == 3850654870u && Operators.CompareString(name, "ThrottlePreset", false) == 0)
										{
											waypoint2.SetThrottlePreset((ActiveUnit_Kinematics._SpeedPreset)Conversions.ToByte(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "WP_SecondElementWingman", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator5 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator5.MoveNext())
											{
												XmlNode xmlNode5 = (XmlNode)enumerator5.Current;
												waypoint2.WP_SecondElementWingman = Waypoint.smethod_9(ref xmlNode5, ref dictionary_0);
											}
											continue;
										}
										finally
										{
											if (enumerator5 is IDisposable)
											{
												(enumerator5 as IDisposable).Dispose();
											}
										}
									}
								}
								if (num <= 3997566245u)
								{
									if (num != 3980133203u)
									{
										if (num == 3997566245u && Operators.CompareString(name, "Leg_TotalDistance_ThirdElement", false) == 0)
										{
											waypoint2.Leg_TotalDistance_ThirdElement = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Leg_Distance", false) == 0)
										{
											waypoint2.Leg_Distance = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
								}
								else if (num != 4051376797u)
								{
									if (num != 4100651282u)
									{
										if (num == 4277317284u && Operators.CompareString(name, "Leg_Time_Straight", false) == 0)
										{
											waypoint2.Leg_Time_Straight = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "MaxReceiversInQueuePerTanker_Airborne", false) == 0)
										{
											waypoint2.MaxReceiversInQueuePerTanker_Airborne = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "WP_ThirdElementWingman", false) == 0)
									{
										IEnumerator enumerator6 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator6.MoveNext())
											{
												XmlNode xmlNode6 = (XmlNode)enumerator6.Current;
												waypoint2.WP_ThirdElementWingman = Waypoint.smethod_9(ref xmlNode6, ref dictionary_0);
											}
											continue;
										}
										finally
										{
											if (enumerator6 is IDisposable)
											{
												(enumerator6 as IDisposable).Dispose();
											}
										}
										goto IL_B4F;
									}
									continue;
								}
							}
							waypoint2.IsManualEditable = true;
							continue;
						}
						IL_B4F:
						if (num <= 882301358u)
						{
							if (num <= 268485832u)
							{
								if (num <= 208007272u)
								{
									if (num <= 154738112u)
									{
										if (num != 143933886u)
										{
											if (num != 154738112u)
											{
												continue;
											}
											if (Operators.CompareString(name, "DesiredSpeedOverride", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "TimeFixed", false) == 0)
											{
												waypoint2.TimeFixed = (Waypoint.Enum52)Conversions.ToInteger(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num != 166317542u)
									{
										if (num == 208007272u && Operators.CompareString(name, "Leg_FuelRemaining", false) == 0)
										{
											waypoint2.Leg_FuelRemaining = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Leg_TotalDistance_SecondElement", false) == 0)
										{
											waypoint2.Leg_TotalDistance_SecondElement = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
											continue;
										}
										continue;
									}
								}
								else if (num <= 266367750u)
								{
									if (num != 237427752u)
									{
										if (num == 266367750u && Operators.CompareString(name, "Name", false) == 0)
										{
											waypoint2.Name = xmlNode.InnerText;
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TurnRate", false) == 0)
										{
											waypoint2.TurnRate = (Waypoint._TurnRate)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (num != 267447700u)
									{
										if (num != 268485832u || Operators.CompareString(name, "WP_ThirdElement", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator7 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator7.MoveNext())
											{
												XmlNode xmlNode7 = (XmlNode)enumerator7.Current;
												waypoint2.WP_ThirdElement = Waypoint.smethod_9(ref xmlNode7, ref dictionary_0);
											}
											continue;
										}
										finally
										{
											if (enumerator7 is IDisposable)
											{
												(enumerator7 as IDisposable).Dispose();
											}
										}
									}
									if (Operators.CompareString(name, "Time_Local", false) == 0)
									{
										DateTime value2 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
										waypoint2.ArrivalTime_Local = new DateTime?(value2);
										continue;
									}
									continue;
								}
							}
							else if (num <= 681906193u)
							{
								if (num <= 477337531u)
								{
									if (num != 316182301u)
									{
										if (num != 477337531u || Operators.CompareString(name, "FlightplanPointsList", false) != 0)
										{
											continue;
										}
										waypoint2.FlightplanPointsList = new List<Waypoint.Class126>();
										IEnumerator enumerator8 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator8.MoveNext())
											{
												XmlNode xmlNode8 = (XmlNode)enumerator8.Current;
												Waypoint.Class126 @class = new Waypoint.Class126();
												IEnumerator enumerator9 = xmlNode8.ChildNodes.GetEnumerator();
												try
												{
													while (enumerator9.MoveNext())
													{
														XmlNode xmlNode9 = (XmlNode)enumerator9.Current;
														string name2 = xmlNode9.Name;
														if (Operators.CompareString(name2, "StartLatitude", false) != 0)
														{
															if (Operators.CompareString(name2, "StartLongitude", false) != 0)
															{
																if (Operators.CompareString(name2, "EndLatitude", false) != 0)
																{
																	if (Operators.CompareString(name2, "EndLongitude", false) == 0)
																	{
																		@class.EndLongitude = XmlConvert.ToDouble(xmlNode9.InnerText.Replace(",", "."));
																	}
																}
																else
																{
																	@class.EndLatitude = XmlConvert.ToDouble(xmlNode9.InnerText.Replace(",", "."));
																}
															}
															else
															{
																@class.StartLongitude = XmlConvert.ToDouble(xmlNode9.InnerText.Replace(",", "."));
															}
														}
														else
														{
															@class.StartLatitude = XmlConvert.ToDouble(xmlNode9.InnerText.Replace(",", "."));
														}
													}
												}
												finally
												{
													if (enumerator9 is IDisposable)
													{
														(enumerator9 as IDisposable).Dispose();
													}
												}
												waypoint2.FlightplanPointsList.Add(@class);
											}
											continue;
										}
										finally
										{
											if (enumerator8 is IDisposable)
											{
												(enumerator8 as IDisposable).Dispose();
											}
										}
									}
									if (Operators.CompareString(name, "DSO", false) != 0)
									{
										continue;
									}
								}
								else if (num != 620569374u)
								{
									if (num == 681906193u && Operators.CompareString(name, "Leg_Time", false) == 0)
									{
										waypoint2.Leg_Time = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TankerMinNumber_Airborne", false) == 0)
									{
										waypoint2.TankerMinNumber_Airborne = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 801598975u)
							{
								if (num != 721363522u)
								{
									if (num == 801598975u && Operators.CompareString(name, "Leg_TotalDistance_SecondElementWingman", false) == 0)
									{
										waypoint2.Leg_TotalDistance_SecondElementWingman = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TankerMaxDistance_Airborne", false) == 0)
									{
										waypoint2.TankerMaxDistance_Airborne = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 856023323u)
							{
								if (num == 882301358u && Operators.CompareString(name, "LaunchMissionWithoutTankersInPlace", false) == 0)
								{
									waypoint2.LaunchMissionWithoutTankersInPlace = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "DAO", false) == 0)
								{
									goto IL_1181;
								}
								continue;
							}
							if (Operators.CompareString(xmlNode.InnerText, false.ToString(), false) == 0)
							{
								waypoint2.DSO = null;
								continue;
							}
							waypoint2.DSO = new float?(XmlConvert.ToSingle(xmlNode.InnerText));
							continue;
						}
						else if (num <= 1574042996u)
						{
							if (num <= 1422437055u)
							{
								if (num <= 1025497782u)
								{
									if (num != 946283062u)
									{
										if (num == 1025497782u && Operators.CompareString(name, "TankerMinNumber_Total", false) == 0)
										{
											waypoint2.TankerMinNumber_Total = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "SonarActive", false) == 0)
										{
											flag = true;
											flag2 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 1151347181u)
								{
									if (num == 1422437055u && Operators.CompareString(name, "Doctrine", false) == 0)
									{
										waypoint2.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode, waypoint2);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TimeOfDay", false) != 0)
									{
										continue;
									}
									if (Operators.CompareString(xmlNode.InnerText, "", false) == 0)
									{
										waypoint2.TimeOfDay = Weather._TimeOfDay.Day;
										continue;
									}
									waypoint2.TimeOfDay = (Weather._TimeOfDay)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
							}
							else if (num <= 1490777540u)
							{
								if (num != 1458105184u)
								{
									if (num == 1490777540u && Operators.CompareString(name, "Hold_Time", false) == 0)
									{
										waypoint2.Hold_Time = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
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
										waypoint2.SetGuid(xmlNode.InnerText);
										dictionary_0.Add(waypoint2.GetGuid(), waypoint2);
										continue;
									}
									waypoint = (Waypoint)dictionary_0[xmlNode.InnerText];
									result = waypoint;
									return result;
								}
							}
							else if (num != 1496416238u)
							{
								if (num == 1574042996u && Operators.CompareString(name, "Leg_FuelRemaining_SecondElementWingman", false) == 0)
								{
									waypoint2.Leg_FuelRemaining_SecondElementWingman = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "ECMActive", false) == 0)
								{
									flag = true;
									flag3 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 1929998051u)
						{
							if (num <= 1725856265u)
							{
								if (num != 1688531320u)
								{
									if (num == 1725856265u && Operators.CompareString(name, "Description", false) == 0)
									{
										waypoint2.Description = xmlNode.InnerText;
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TankerMinNumber_Station", false) == 0)
									{
										waypoint2.TankerMinNumber_Station = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 1873325951u)
							{
								if (num == 1929998051u && Operators.CompareString(name, "Leg_TotalTime", false) == 0)
								{
									waypoint2.Leg_TotalTime = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Leg_FuelRemaining_SecondElement", false) == 0)
								{
									waypoint2.Leg_FuelRemaining_SecondElement = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
									continue;
								}
								continue;
							}
						}
						else if (num <= 1976795605u)
						{
							if (num != 1956989133u)
							{
								if (num == 1976795605u && Operators.CompareString(name, "RadarActive", false) == 0)
								{
									flag = true;
									flag4 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Leg_TotalDistance_LeadElementWingman", false) == 0)
								{
									waypoint2.Leg_TotalDistance_LeadElementWingman = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
									continue;
								}
								continue;
							}
						}
						else if (num != 1993028513u)
						{
							if (num != 2066337159u || Operators.CompareString(name, "DesiredAltitude", false) != 0)
							{
								continue;
							}
							if (Operators.CompareString(xmlNode.InnerText, false.ToString(), false) == 0)
							{
								waypoint2.DesiredAltitude = null;
								continue;
							}
							waypoint2.DesiredAltitude = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "DepthPreset", false) == 0)
							{
								waypoint2.SetDepthPreset((ActiveUnit_AI._DepthPreset)Conversions.ToByte(xmlNode.InnerText));
								continue;
							}
							continue;
						}
						IL_1181:
						waypoint2.DAO = Conversions.ToBoolean(xmlNode.InnerText);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (waypoint2.IsTerrainFollowing() && Information.IsNothing(waypoint2.DesiredAltitude_TerrainFollowing))
				{
					waypoint2.DesiredAltitude_TerrainFollowing = new float?(60.96f);
				}
				if (flag)
				{
					if (flag4)
					{
						waypoint2.m_Doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_1, null);
					}
					else
					{
						waypoint2.m_Doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_0, null);
					}
					if (flag2)
					{
						waypoint2.m_Doctrine.SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.Enum36.const_1, null);
					}
					else
					{
						waypoint2.m_Doctrine.SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.Enum36.const_0, null);
					}
					if (flag3)
					{
						waypoint2.m_Doctrine.SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.Enum36.const_1, null);
					}
					else
					{
						waypoint2.m_Doctrine.SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.Enum36.const_0, null);
					}
				}
				waypoint = waypoint2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100588", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				waypoint = new Waypoint();
				ProjectData.ClearProjectError();
			}
			result = waypoint;
			return result;
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x002750C8 File Offset: 0x002732C8
		public Waypoint()
		{
			this.ThrottlePreset = ActiveUnit_Kinematics._SpeedPreset.None;
			this.AltitudePreset = ActiveUnit_AI._AltitudePreset.None;
			this.DepthPreset = ActiveUnit_AI._DepthPreset.None;
			this.Hold_Time = 0f;
			this.list_0 = new List<string>();
			this.TankerMissionList = new List<Mission>();
			this.MaxReceiversInQueuePerTanker_Airborne = 0;
			this.TankerMaxDistance_Airborne = 2147483647;
			Collection<ActiveUnit> collection = null;
			this.m_Doctrine = new Doctrine(this, ref collection);
			this.IsWayPoint = true;
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x00275180 File Offset: 0x00273380
		public Waypoint(double Longitude_, double Latitude_, Waypoint.WaypointType waypointType_, Waypoint._Creator Creator_, Waypoint._Category Category_)
		{
			this.ThrottlePreset = ActiveUnit_Kinematics._SpeedPreset.None;
			this.AltitudePreset = ActiveUnit_AI._AltitudePreset.None;
			this.DepthPreset = ActiveUnit_AI._DepthPreset.None;
			this.Hold_Time = 0f;
			this.list_0 = new List<string>();
			this.TankerMissionList = new List<Mission>();
			this.MaxReceiversInQueuePerTanker_Airborne = 0;
			this.TankerMaxDistance_Airborne = 2147483647;
			Collection<ActiveUnit> collection = null;
			this.m_Doctrine = new Doctrine(this, ref collection);
			this.IsWayPoint = true;
			base.SetLongitude(Longitude_);
			base.SetLatitude(Latitude_);
			this.waypointType = waypointType_;
			this.Creator = Creator_;
			this.Category = Category_;
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x0027525C File Offset: 0x0027345C
		public Waypoint method_23(ref Scenario scenario_0, ref Waypoint waypoint_5, bool bool_14, bool bool_15)
		{
			return new Waypoint(ref scenario_0, waypoint_5.waypointType, waypoint_5.Category, waypoint_5.Description, waypoint_5.m_Doctrine, waypoint_5.IsManualEditable, waypoint_5.ThrottlePreset, waypoint_5.AltitudePreset, waypoint_5.DepthPreset, waypoint_5.DesiredSpeed, waypoint_5.DesiredAltitude, waypoint_5.DSO, waypoint_5.DAO, waypoint_5.Name, waypoint_5.GetLongitude(), waypoint_5.GetLatitude(), waypoint_5.GetAltitude(), waypoint_5.Creator, waypoint_5.IsTerrainFollowing(), waypoint_5.DesiredAltitude_TerrainFollowing, waypoint_5.ArrivalTime_Zulu, waypoint_5.ArrivalTime_Local, waypoint_5.TimeOfDay, waypoint_5.TimeFixed, waypoint_5.SpeedFixed, waypoint_5.FlightFormation, waypoint_5.TankerUsage, this.list_0, waypoint_5.TankerMissionList, waypoint_5.TankerMinNumber_Total, waypoint_5.TankerMinNumber_Airborne, waypoint_5.TankerMinNumber_Station, waypoint_5.LaunchMissionWithoutTankersInPlace, waypoint_5.MaxReceiversInQueuePerTanker_Airborne, waypoint_5.FuelQtyToStartLookingForTanker_Airborne, waypoint_5.TankerMaxDistance_Airborne, waypoint_5.Leg_FuelRequired, waypoint_5.Leg_FuelRemaining, waypoint_5.Leg_Time, waypoint_5.Leg_Time_Straight, waypoint_5.Leg_Time_Turn, waypoint_5.Leg_TotalTime, waypoint_5.Leg_Distance, waypoint_5.Leg_TotalDistance, waypoint_5.Hold_Time, waypoint_5.float_10, waypoint_5.float_11, waypoint_5.float_12, waypoint_5.bool_11, waypoint_5.bool_12, waypoint_5.TurnRate, waypoint_5.FlightplanPointsList, waypoint_5.float_1, bool_14, waypoint_5.WP_LeadElementWingman, waypoint_5.WP_SecondElement, waypoint_5.WP_SecondElementWingman, waypoint_5.WP_ThirdElement, waypoint_5.WP_ThirdElementWingman, waypoint_5.Leg_FuelRemaining_LeadElementWingman, waypoint_5.Leg_FuelRemaining_SecondElement, waypoint_5.Leg_FuelRemaining_SecondElementWingman, waypoint_5.Leg_FuelRemaining_ThirdElement, waypoint_5.Leg_FuelRemaining_ThirdElementWingman, waypoint_5.Leg_TotalDistance_LeadElementWingman, waypoint_5.Leg_TotalDistance_SecondElement, waypoint_5.Leg_TotalDistance_SecondElementWingman, waypoint_5.Leg_TotalDistance_ThirdElement, waypoint_5.Leg_TotalDistance_ThirdElementWingman, bool_15);
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x00275448 File Offset: 0x00273648
		public Waypoint(ref Scenario scenario_0, Waypoint.WaypointType waypointType_1, Waypoint._Category enum49_1, string string_3, Doctrine doctrine_1, bool bool_14, ActiveUnit_Kinematics._SpeedPreset enum6_1, ActiveUnit_AI._AltitudePreset enum3_1, ActiveUnit_AI._DepthPreset enum2_1, float? nullable_6, float? nullable_7, float? nullable_8, bool bool_15, string string_4, double double_2, double double_3, float float_25, Waypoint._Creator enum50_1, bool bool_16, float? nullable_9, DateTime? nullable_10, DateTime? nullable_11, Weather._TimeOfDay enum95_1, Waypoint.Enum52 enum52_2, Waypoint.Enum52 enum52_3, Waypoint._FlightFormation enum53_1, Mission.TankerMethod tankerMethod_1, List<string> list_3, List<Mission> list_4, int int_6, int int_7, int int_8, bool bool_17, int int_9, int int_10, int int_11, float float_26, float float_27, float float_28, float float_29, float float_30, float float_31, float float_32, float float_33, float float_34, float float_35, float float_36, float float_37, bool bool_18, bool bool_19, Waypoint._TurnRate enum51_1, List<Waypoint.Class126> list_5, float float_38, bool bool_20, Waypoint waypoint_5, Waypoint waypoint_6, Waypoint waypoint_7, Waypoint waypoint_8, Waypoint waypoint_9, float float_39, float float_40, float float_41, float float_42, float float_43, float float_44, float float_45, float float_46, float float_47, float float_48, bool bool_21)
		{
			this.ThrottlePreset = ActiveUnit_Kinematics._SpeedPreset.None;
			this.AltitudePreset = ActiveUnit_AI._AltitudePreset.None;
			this.DepthPreset = ActiveUnit_AI._DepthPreset.None;
			this.Hold_Time = 0f;
			this.list_0 = new List<string>();
			this.TankerMissionList = new List<Mission>();
			this.MaxReceiversInQueuePerTanker_Airborne = 0;
			this.TankerMaxDistance_Airborne = 2147483647;
			Collection<ActiveUnit> collection = null;
			this.m_Doctrine = new Doctrine(this, ref collection);
			this.IsWayPoint = true;
			this.waypointType = waypointType_1;
			this.Category = enum49_1;
			this.Description = string_3;
			this.IsManualEditable = bool_14;
			this.ThrottlePreset = enum6_1;
			this.AltitudePreset = enum3_1;
			this.DepthPreset = enum2_1;
			this.DesiredSpeed = nullable_6;
			this.DesiredAltitude = nullable_7;
			this.DesiredAltitude_TerrainFollowing = nullable_9;
			this.DSO = nullable_8;
			this.DAO = bool_15;
			base.SetLongitude(double_2);
			base.SetLatitude(double_3);
			base.SetAltitude(float_25);
			this.Name = string_4;
			this.Creator = enum50_1;
			this.SetIsTerrainFollowing(bool_16);
			this.ArrivalTime_Zulu = nullable_10;
			this.ArrivalTime_Local = nullable_11;
			this.TimeOfDay = enum95_1;
			this.TimeFixed = enum52_2;
			this.SpeedFixed = enum52_3;
			this.FlightFormation = enum53_1;
			this.TankerUsage = tankerMethod_1;
			foreach (string current in list_3)
			{
				this.list_0.Add(current);
			}
			foreach (Mission current2 in list_4)
			{
				this.TankerMissionList.Add(current2);
			}
			this.TankerMinNumber_Total = int_6;
			this.TankerMinNumber_Airborne = int_7;
			this.TankerMinNumber_Station = int_8;
			this.LaunchMissionWithoutTankersInPlace = bool_17;
			this.MaxReceiversInQueuePerTanker_Airborne = int_9;
			this.FuelQtyToStartLookingForTanker_Airborne = int_10;
			this.TankerMaxDistance_Airborne = int_11;
			this.Leg_FuelRequired = float_26;
			this.Leg_FuelRemaining = float_27;
			this.Leg_Time = float_28;
			this.Leg_Time_Straight = float_29;
			this.Leg_Time_Turn = float_30;
			this.Leg_TotalTime = float_31;
			this.Leg_Distance = float_32;
			this.Leg_TotalDistance = float_33;
			this.float_10 = float_35;
			this.float_11 = float_36;
			this.float_12 = float_37;
			this.bool_11 = bool_18;
			this.bool_12 = bool_19;
			this.TurnRate = enum51_1;
			if (bool_21 && !Information.IsNothing(list_5))
			{
				this.FlightplanPointsList = new List<Waypoint.Class126>();
				foreach (Waypoint.Class126 current3 in list_5)
				{
					Waypoint.Class126 item = new Waypoint.Class126(ref current3.StartLatitude, current3.StartLongitude, current3.EndLatitude, current3.EndLongitude);
					this.FlightplanPointsList.Add(item);
				}
			}
			if (bool_20)
			{
				if (!Information.IsNothing(waypoint_5))
				{
					this.WP_LeadElementWingman = waypoint_5.method_23(ref scenario_0, ref waypoint_5, false, bool_21);
					this.Leg_FuelRemaining_LeadElementWingman = float_39;
					this.Leg_TotalDistance_LeadElementWingman = float_44;
				}
				if (!Information.IsNothing(waypoint_6))
				{
					this.WP_SecondElement = waypoint_6.method_23(ref scenario_0, ref waypoint_6, false, bool_21);
					this.Leg_FuelRemaining_SecondElement = float_40;
					this.Leg_TotalDistance_SecondElement = float_45;
				}
				if (!Information.IsNothing(waypoint_7))
				{
					this.WP_SecondElementWingman = waypoint_7.method_23(ref scenario_0, ref waypoint_7, false, bool_21);
					this.Leg_FuelRemaining_SecondElementWingman = float_41;
					this.Leg_TotalDistance_SecondElementWingman = float_46;
				}
				if (!Information.IsNothing(waypoint_8))
				{
					this.WP_ThirdElement = waypoint_8.method_23(ref scenario_0, ref waypoint_8, false, bool_21);
					this.Leg_FuelRemaining_ThirdElement = float_42;
					this.Leg_TotalDistance_ThirdElement = float_47;
				}
				if (!Information.IsNothing(waypoint_9))
				{
					this.WP_ThirdElementWingman = waypoint_9.method_23(ref scenario_0, ref waypoint_9, false, bool_21);
					this.Leg_FuelRemaining_ThirdElementWingman = float_43;
					this.Leg_TotalDistance_ThirdElementWingman = float_48;
				}
			}
			this.Hold_Time = float_34;
			this.float_1 = float_38;
			this.m_Doctrine = this.m_Doctrine.NewDoctrineEMCON(ref doctrine_1, this, ref scenario_0);
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x00275888 File Offset: 0x00273A88
		public void method_24()
		{
			if (!Information.IsNothing(this) && this.GetDAO())
			{
				switch (this.GetAltitudePreset())
				{
				case ActiveUnit_AI._AltitudePreset.None:
					this.DesiredAltitude = null;
					this.DesiredAltitude_TerrainFollowing = null;
					break;
				case ActiveUnit_AI._AltitudePreset.MinAltitude:
					this.DesiredAltitude = new float?(0f);
					this.DesiredAltitude_TerrainFollowing = new float?(0f);
					break;
				case ActiveUnit_AI._AltitudePreset.LowAltitude1000:
					if (this.IsTerrainFollowing())
					{
						this.DesiredAltitude = null;
						this.DesiredAltitude_TerrainFollowing = new float?(304.8f);
					}
					else
					{
						this.DesiredAltitude = new float?(304.8f);
						this.DesiredAltitude_TerrainFollowing = null;
					}
					break;
				case ActiveUnit_AI._AltitudePreset.LowAltitude2000:
					if (this.IsTerrainFollowing())
					{
						this.DesiredAltitude = null;
						this.DesiredAltitude_TerrainFollowing = new float?(609.6f);
					}
					else
					{
						this.DesiredAltitude = new float?(609.6f);
						this.DesiredAltitude_TerrainFollowing = null;
					}
					break;
				case ActiveUnit_AI._AltitudePreset.MediumAltitude12000:
					if (this.IsTerrainFollowing())
					{
						this.DesiredAltitude = null;
						this.DesiredAltitude_TerrainFollowing = new float?(3657.6f);
					}
					else
					{
						this.DesiredAltitude = new float?(3657.6f);
						this.DesiredAltitude_TerrainFollowing = null;
					}
					break;
				case ActiveUnit_AI._AltitudePreset.HighAltitude25000:
					if (this.IsTerrainFollowing())
					{
						this.DesiredAltitude = null;
						this.DesiredAltitude_TerrainFollowing = new float?(7620f);
					}
					else
					{
						this.DesiredAltitude = new float?(7620f);
						this.DesiredAltitude_TerrainFollowing = null;
					}
					break;
				case ActiveUnit_AI._AltitudePreset.HighAltitude36000:
					if (this.IsTerrainFollowing())
					{
						this.DesiredAltitude = null;
						this.DesiredAltitude_TerrainFollowing = new float?(10972.8f);
					}
					else
					{
						this.DesiredAltitude = new float?(10972.8f);
						this.DesiredAltitude_TerrainFollowing = null;
					}
					break;
				case ActiveUnit_AI._AltitudePreset.MaxAltitude:
					this.DesiredAltitude = null;
					this.DesiredAltitude_TerrainFollowing = null;
					break;
				}
			}
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x00275AB0 File Offset: 0x00273CB0
		public void method_25()
		{
			if (!Information.IsNothing(this) && this.GetDAO())
			{
				switch (this.GetDepthPreset())
				{
				case ActiveUnit_AI._DepthPreset.None:
					this.DesiredAltitude = null;
					break;
				case ActiveUnit_AI._DepthPreset.Periscope:
					this.DesiredAltitude = new float?(-20f);
					break;
				case ActiveUnit_AI._DepthPreset.Shallow:
					this.DesiredAltitude = new float?(-40f);
					break;
				case ActiveUnit_AI._DepthPreset.OverLayer:
					this.DesiredAltitude = new float?(Waypoint.smethod_10(this));
					break;
				case ActiveUnit_AI._DepthPreset.UnderLayer:
					this.DesiredAltitude = new float?(Waypoint.smethod_11(this));
					break;
				case ActiveUnit_AI._DepthPreset.MaxDepth:
					this.DesiredAltitude = new float?(0f);
					break;
				case ActiveUnit_AI._DepthPreset.Surface:
					this.DesiredAltitude = new float?(0f);
					break;
				}
			}
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x00275B7C File Offset: 0x00273D7C
		public static float smethod_10(Waypoint waypoint_5)
		{
			return (float)(SonarEnvironment.GetLayer(waypoint_5.GetLatitude(), waypoint_5.GetLongitude(), (int)Terrain.GetElevation(waypoint_5.GetLatitude(), waypoint_5.GetLongitude(), false)).Ceiling + 10);
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x00275BB8 File Offset: 0x00273DB8
		public static float smethod_11(Waypoint waypoint_5)
		{
			return (float)(SonarEnvironment.GetLayer(waypoint_5.GetLatitude(), waypoint_5.GetLongitude(), (int)Terrain.GetElevation(waypoint_5.GetLatitude(), waypoint_5.GetLongitude(), false)).Bottom - 10);
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x00275BF4 File Offset: 0x00273DF4
		public float? GetDSO()
		{
			return this.DSO;
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x00028403 File Offset: 0x00026603
		public void SetDSO(float? value)
		{
			this.DSO = value;
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x0002840C File Offset: 0x0002660C
		public bool GetDAO()
		{
			return this.DAO;
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x00028414 File Offset: 0x00026614
		public void SetDAO(bool value)
		{
			if (!value)
			{
				this.SetIsTerrainFollowing(false);
			}
			this.DAO = value;
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x00275C0C File Offset: 0x00273E0C
		public ActiveUnit_AI._AltitudePreset GetAltitudePreset()
		{
			return this.AltitudePreset;
		}

		// Token: 0x0600591E RID: 22814 RVA: 0x00028427 File Offset: 0x00026627
		public void SetAltitudePreset(ActiveUnit_AI._AltitudePreset enum3_1)
		{
			this.AltitudePreset = enum3_1;
			if (enum3_1 != ActiveUnit_AI._AltitudePreset.None)
			{
				this.SetDAO(true);
			}
		}

		// Token: 0x0600591F RID: 22815 RVA: 0x00275C24 File Offset: 0x00273E24
		public ActiveUnit_AI._DepthPreset GetDepthPreset()
		{
			return this.DepthPreset;
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x0002843D File Offset: 0x0002663D
		public void SetDepthPreset(ActiveUnit_AI._DepthPreset enum2_1)
		{
			this.DepthPreset = enum2_1;
			if (enum2_1 != ActiveUnit_AI._DepthPreset.None)
			{
				this.SetDAO(true);
			}
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x00275C3C File Offset: 0x00273E3C
		public ActiveUnit_Kinematics._SpeedPreset GetThrottlePreset()
		{
			return this.ThrottlePreset;
		}

		// Token: 0x06005922 RID: 22818 RVA: 0x00028453 File Offset: 0x00026653
		public void SetThrottlePreset(ActiveUnit_Kinematics._SpeedPreset enum6_1)
		{
			this.ThrottlePreset = enum6_1;
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x0002845C File Offset: 0x0002665C
		public bool IsTerrainFollowing()
		{
			return this.bTerrainFollowing;
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x00028464 File Offset: 0x00026664
		public void SetIsTerrainFollowing(bool bool_14)
		{
			if (bool_14 && !this.GetDAO())
			{
				this.SetDAO(true);
			}
			this.bTerrainFollowing = bool_14;
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x00275C54 File Offset: 0x00273E54
		public static void smethod_12(ref DataTable dataTable_0)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				Waypoint.GetWaypointTypeString(Waypoint.WaypointType.TakeOff)
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				Waypoint.GetWaypointTypeString(Waypoint.WaypointType.Assemble)
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				Waypoint.GetWaypointTypeString(Waypoint.WaypointType.TurningPoint)
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				Waypoint.GetWaypointTypeString(Waypoint.WaypointType.Refuel)
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				Waypoint.GetWaypointTypeString(Waypoint.WaypointType.StrikeIngress)
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				Waypoint.GetWaypointTypeString(Waypoint.WaypointType.InitialPoint)
			});
			dataTable_0.Rows.Add(new object[]
			{
				6,
				Waypoint.GetWaypointTypeString(Waypoint.WaypointType.WeaponLaunch)
			});
			dataTable_0.Rows.Add(new object[]
			{
				7,
				Waypoint.GetWaypointTypeString(Waypoint.WaypointType.Target)
			});
			dataTable_0.Rows.Add(new object[]
			{
				8,
				Waypoint.GetWaypointTypeString(Waypoint.WaypointType.WeaponTarget)
			});
			dataTable_0.Rows.Add(new object[]
			{
				9,
				Waypoint.GetWaypointTypeString(Waypoint.WaypointType.StrikeEgress)
			});
			dataTable_0.Rows.Add(new object[]
			{
				10,
				Waypoint.GetWaypointTypeString(Waypoint.WaypointType.Marshal)
			});
			dataTable_0.Rows.Add(new object[]
			{
				11,
				Waypoint.GetWaypointTypeString(Waypoint.WaypointType.LandingMarshal)
			});
			dataTable_0.Rows.Add(new object[]
			{
				12,
				Waypoint.GetWaypointTypeString(Waypoint.WaypointType.Land)
			});
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x00275EC8 File Offset: 0x002740C8
		public static int? smethod_13(ref object object_0)
		{
			int? result = null;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 0:
					result = new int?(15);
					break;
				case 1:
					result = new int?(5);
					break;
				case 2:
					result = new int?(6);
					break;
				case 3:
					result = new int?(14);
					break;
				case 4:
					result = new int?(12);
					break;
				case 5:
					result = new int?(7);
					break;
				case 6:
					result = new int?(17);
					break;
				case 7:
					result = new int?(10);
					break;
				case 8:
					result = new int?(19);
					break;
				case 9:
					result = new int?(13);
					break;
				case 10:
					result = new int?(16);
					break;
				case 11:
					result = new int?(11);
					break;
				case 12:
					result = new int?(18);
					break;
				default:
					result = null;
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101300", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x00275FF8 File Offset: 0x002741F8
		public static int smethod_14(object object_0)
		{
			int num = 0;
			int result;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 5:
					num = 1;
					result = 1;
					return result;
				case 6:
					num = 2;
					result = 2;
					return result;
				case 7:
					num = 5;
					result = 5;
					return result;
				case 10:
					num = 7;
					result = 7;
					return result;
				case 11:
					num = 11;
					result = 11;
					return result;
				case 12:
					num = 4;
					result = 4;
					return result;
				case 13:
					num = 9;
					result = 9;
					return result;
				case 14:
					num = 3;
					result = 3;
					return result;
				case 15:
					num = 0;
					result = 0;
					return result;
				case 16:
					num = 10;
					result = 10;
					return result;
				case 17:
					num = 6;
					result = 6;
					return result;
				case 18:
					num = 12;
					result = 12;
					return result;
				case 19:
					num = 8;
					result = 8;
					return result;
				}
				num = 0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101303", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = num;
			return result;
		}

		// 取路径点类型字符串
		public static string GetWaypointTypeString(Waypoint.WaypointType waypointType_1)
		{
			string result;
			switch (waypointType_1)
			{
			case Waypoint.WaypointType.Assemble:
				result = "集结";
				break;
			case Waypoint.WaypointType.TurningPoint:
				result = "转折点";
				break;
			case Waypoint.WaypointType.InitialPoint:
				result = "初始点";
				break;
			case Waypoint.WaypointType.Split:
				result = "分批";
				break;
			case Waypoint.WaypointType.Formate:
				result = "编队";
				break;
			case Waypoint.WaypointType.Target:
				result = "目标";
				break;
			case Waypoint.WaypointType.LandingMarshal:
				result = "降落排列点";
				break;
			case Waypoint.WaypointType.StrikeIngress:
				result = "进入突击区";
				break;
			case Waypoint.WaypointType.StrikeEgress:
				result = "退出突击区";
				break;
			case Waypoint.WaypointType.Refuel:
				result = "加油";
				break;
			case Waypoint.WaypointType.TakeOff:
				result = "起飞";
				break;
			case Waypoint.WaypointType.Marshal:
				result = "编列";
				break;
			case Waypoint.WaypointType.WeaponLaunch:
				result = "武器发射";
				break;
			case Waypoint.WaypointType.Land:
				result = "降落";
				break;
			case Waypoint.WaypointType.WeaponTarget:
				result = "武器分配目标";
				break;
			default:
				result = "None";
				break;
			}
			return result;
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x002761E8 File Offset: 0x002743E8
		public static void smethod_16(ref DataTable dataTable_0)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				Waypoint.GetFlightFormationString(Waypoint._FlightFormation.Spread)
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				Waypoint.GetFlightFormationString(Waypoint._FlightFormation.Trail_1nm)
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				Waypoint.GetFlightFormationString(Waypoint._FlightFormation.Split)
			});
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x002762CC File Offset: 0x002744CC
		public static void smethod_17(ref DataTable dataTable_0)
		{
			if (!dataTable_0.Columns.Contains("ID"))
			{
				dataTable_0.Columns.Add("ID", typeof(int));
			}
			if (!dataTable_0.Columns.Contains("Description"))
			{
				dataTable_0.Columns.Add("Description", typeof(string));
			}
			dataTable_0.Rows.Add(new object[]
			{
				0,
				Waypoint.GetTurnRateString(Waypoint._TurnRate.Standard)
			});
			dataTable_0.Rows.Add(new object[]
			{
				1,
				Waypoint.GetTurnRateString(Waypoint._TurnRate.Half)
			});
			dataTable_0.Rows.Add(new object[]
			{
				2,
				Waypoint.GetTurnRateString(Waypoint._TurnRate.Double)
			});
			dataTable_0.Rows.Add(new object[]
			{
				3,
				Waypoint.GetTurnRateString(Waypoint._TurnRate.Double)
			});
			dataTable_0.Rows.Add(new object[]
			{
				4,
				Waypoint.GetTurnRateString(Waypoint._TurnRate.const_4)
			});
			dataTable_0.Rows.Add(new object[]
			{
				5,
				Waypoint.GetTurnRateString(Waypoint._TurnRate.const_5)
			});
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x00276424 File Offset: 0x00274624
		public static int? smethod_18(ref object object_0)
		{
			int? result = null;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 0:
					result = new int?(0);
					break;
				case 1:
					result = new int?(1);
					break;
				case 2:
					result = new int?(100);
					break;
				default:
					result = null;
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101301", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x002764CC File Offset: 0x002746CC
		public static int? smethod_19(ref object object_0)
		{
			int? result = null;
			try
			{
				switch (Conversions.ToInteger(object_0))
				{
				case 0:
					result = new int?(0);
					break;
				case 1:
					result = new int?(1);
					break;
				case 2:
					result = new int?(2);
					break;
				default:
					result = null;
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200642", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x00276570 File Offset: 0x00274770
		public static int smethod_20(object object_0)
		{
			int result = 0;
			try
			{
				int num = Conversions.ToInteger(object_0);
				if (num != 0)
				{
					if (num != 1)
					{
						if (num != 100)
						{
							result = 0;
						}
						else
						{
							result = 2;
						}
					}
					else
					{
						result = 1;
					}
				}
				else
				{
					result = 0;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101301", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x002765FC File Offset: 0x002747FC
		public static string GetFlightFormationString(Waypoint._FlightFormation enum53_1)
		{
			string result;
			if (enum53_1 != Waypoint._FlightFormation.Spread)
			{
				if (enum53_1 != Waypoint._FlightFormation.Trail_1nm)
				{
					if (enum53_1 != Waypoint._FlightFormation.Split)
					{
						result = "None";
					}
					else
					{
						result = "Split";
					}
				}
				else
				{
					result = "1nm Trail";
				}
			}
			else
			{
				result = "Spread";
			}
			return result;
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x00276644 File Offset: 0x00274844
		public static string GetTurnRateString(Waypoint._TurnRate TurnRate_)
		{
			string result;
			switch (TurnRate_)
			{
			case Waypoint._TurnRate.Standard:
				result = "标准速率，3度/秒";
				break;
			case Waypoint._TurnRate.Half:
				result = "半倍速率, 1.5度/秒";
				break;
			case Waypoint._TurnRate.Double:
				result = "双倍速率，6度/秒";
				break;
			case Waypoint._TurnRate.const_4:
				result = "3G转弯, 70度倾斜角";
				break;
			case Waypoint._TurnRate.const_5:
				result = "4G转弯, 75度倾斜角";
				break;
			default:
				result = "None";
				break;
			}
			return result;
		}

		// Token: 0x04002BFF RID: 11263
		public Waypoint.WaypointType waypointType;

		// Token: 0x04002C00 RID: 11264
		public Waypoint._Category Category;

		// Token: 0x04002C01 RID: 11265
		public string Description = "";

		// Token: 0x04002C02 RID: 11266
		public bool IsManualEditable;

		// Token: 0x04002C03 RID: 11267
		private ActiveUnit_Kinematics._SpeedPreset ThrottlePreset;

		// Token: 0x04002C04 RID: 11268
		private ActiveUnit_AI._AltitudePreset AltitudePreset;

		// Token: 0x04002C05 RID: 11269
		private ActiveUnit_AI._DepthPreset DepthPreset;

		// Token: 0x04002C06 RID: 11270
		private bool bTerrainFollowing;

		// Token: 0x04002C07 RID: 11271
		public float? DesiredSpeed;

		// Token: 0x04002C08 RID: 11272
		public float float_1;

		// Token: 0x04002C09 RID: 11273
		public float? DesiredAltitude;

		// Token: 0x04002C0A RID: 11274
		public float? DesiredAltitude_TerrainFollowing;

		// Token: 0x04002C0B RID: 11275
		private float? DSO;

		// Token: 0x04002C0C RID: 11276
		private bool DAO;

		// Token: 0x04002C0D RID: 11277
		public Waypoint._Creator Creator;

		// Token: 0x04002C0E RID: 11278
		public DateTime? ArrivalTime_Zulu;

		// Token: 0x04002C0F RID: 11279
		public DateTime? ArrivalTime_Local;

		// Token: 0x04002C10 RID: 11280
		public Weather._TimeOfDay TimeOfDay;

		// Token: 0x04002C11 RID: 11281
		public Waypoint.Enum52 TimeFixed;

		// Token: 0x04002C12 RID: 11282
		public Waypoint.Enum52 SpeedFixed;

		// Token: 0x04002C13 RID: 11283
		public Waypoint._FlightFormation FlightFormation;

		// Token: 0x04002C14 RID: 11284
		public float Leg_FuelRequired = 0f;

		// Token: 0x04002C15 RID: 11285
		public float Leg_FuelRemaining;

		// Token: 0x04002C16 RID: 11286
		public float Leg_Time = 0f;

		// Token: 0x04002C17 RID: 11287
		public float Leg_Time_Straight = 0f;

		// Token: 0x04002C18 RID: 11288
		public float Leg_Time_Turn = 0f;

		// Token: 0x04002C19 RID: 11289
		public float Leg_TotalTime;

		// Token: 0x04002C1A RID: 11290
		public float float_8;

		// Token: 0x04002C1B RID: 11291
		public float Leg_Distance;

		// Token: 0x04002C1C RID: 11292
		public float float_10;

		// Token: 0x04002C1D RID: 11293
		public float float_11;

		// Token: 0x04002C1E RID: 11294
		public float float_12;

		// Token: 0x04002C1F RID: 11295
		public float Leg_TotalDistance;

		// Token: 0x04002C20 RID: 11296
		public bool bool_11;

		// Token: 0x04002C21 RID: 11297
		public bool bool_12;

		// Token: 0x04002C22 RID: 11298
		public Waypoint WP_LeadElementWingman;

		// Token: 0x04002C23 RID: 11299
		public Waypoint WP_SecondElement;

		// Token: 0x04002C24 RID: 11300
		public Waypoint WP_SecondElementWingman;

		// Token: 0x04002C25 RID: 11301
		public Waypoint WP_ThirdElement;

		// Token: 0x04002C26 RID: 11302
		public Waypoint WP_ThirdElementWingman;

		// Token: 0x04002C27 RID: 11303
		public float Leg_FuelRemaining_LeadElementWingman;

		// Token: 0x04002C28 RID: 11304
		public float Leg_FuelRemaining_SecondElement;

		// Token: 0x04002C29 RID: 11305
		public float Leg_FuelRemaining_SecondElementWingman;

		// Token: 0x04002C2A RID: 11306
		public float Leg_FuelRemaining_ThirdElement;

		// Token: 0x04002C2B RID: 11307
		public float Leg_FuelRemaining_ThirdElementWingman;

		// Token: 0x04002C2C RID: 11308
		public float Leg_TotalDistance_LeadElementWingman;

		// Token: 0x04002C2D RID: 11309
		public float Leg_TotalDistance_SecondElement;

		// Token: 0x04002C2E RID: 11310
		public float Leg_TotalDistance_SecondElementWingman;

		// Token: 0x04002C2F RID: 11311
		public float Leg_TotalDistance_ThirdElement;

		// Token: 0x04002C30 RID: 11312
		public float Leg_TotalDistance_ThirdElementWingman;

		// Token: 0x04002C31 RID: 11313
		public float Hold_Time;

		// Token: 0x04002C32 RID: 11314
		public Waypoint._TurnRate TurnRate;

		// Token: 0x04002C33 RID: 11315
		public Mission.TankerMethod TankerUsage;

		// Token: 0x04002C34 RID: 11316
		public List<string> list_0;

		// Token: 0x04002C35 RID: 11317
		public List<Mission> TankerMissionList;

		// Token: 0x04002C36 RID: 11318
		public int TankerMinNumber_Total;

		// Token: 0x04002C37 RID: 11319
		public int TankerMinNumber_Airborne;

		// Token: 0x04002C38 RID: 11320
		public int TankerMinNumber_Station = 0;

		// Token: 0x04002C39 RID: 11321
		public bool LaunchMissionWithoutTankersInPlace;

		// Token: 0x04002C3A RID: 11322
		public int MaxReceiversInQueuePerTanker_Airborne = 0;

		// Token: 0x04002C3B RID: 11323
		public int FuelQtyToStartLookingForTanker_Airborne;

		// Token: 0x04002C3C RID: 11324
		public int TankerMaxDistance_Airborne;

		// Token: 0x04002C3D RID: 11325
		public Doctrine m_Doctrine;

		// Token: 0x04002C3E RID: 11326
		public List<Waypoint.Class126> FlightplanPointsList;

		// Token: 0x02000ADB RID: 2779
		public sealed class Class126
		{
			// Token: 0x06005930 RID: 22832 RVA: 0x002766A4 File Offset: 0x002748A4
			public Class126(ref double double_4, double double_5, double double_6, double double_7)
			{
				this.StartLatitude = double_4;
				this.StartLongitude = double_5;
				this.EndLatitude = double_6;
				this.EndLongitude = double_7;
			}

			// Token: 0x06005931 RID: 22833 RVA: 0x00028482 File Offset: 0x00026682
			public Class126()
			{
			}

			// Token: 0x04002C3F RID: 11327
			public double StartLatitude;

			// Token: 0x04002C40 RID: 11328
			public double StartLongitude;

			// Token: 0x04002C41 RID: 11329
			public double EndLatitude = 0.0;

			// Token: 0x04002C42 RID: 11330
			public double EndLongitude = 0.0;
		}

		// Token: 0x02000ADC RID: 2780
		public enum WaypointType
		{
			// Token: 0x04002C44 RID: 11332
			ManualPlottedCourseWaypoint,
			// Token: 0x04002C45 RID: 11333
			PatrolStation,
			// Token: 0x04002C46 RID: 11334
			WeaponTerminalPoint,
			// Token: 0x04002C47 RID: 11335
			LocalizationRun,
			// Token: 0x04002C48 RID: 11336
			PathfindingPoint,
			// Token: 0x04002C49 RID: 11337
			Assemble,
			// Token: 0x04002C4A RID: 11338
			TurningPoint,
			// Token: 0x04002C4B RID: 11339
			InitialPoint,
			// Token: 0x04002C4C RID: 11340
			Split,
			// Token: 0x04002C4D RID: 11341
			Formate,
			// Token: 0x04002C4E RID: 11342
			Target,
			// Token: 0x04002C4F RID: 11343
			LandingMarshal,
			// Token: 0x04002C50 RID: 11344
			StrikeIngress,
			// Token: 0x04002C51 RID: 11345
			StrikeEgress,
			// Token: 0x04002C52 RID: 11346
			Refuel,
			// Token: 0x04002C53 RID: 11347
			TakeOff,
			// Token: 0x04002C54 RID: 11348
			Marshal,
			// Token: 0x04002C55 RID: 11349
			WeaponLaunch,
			// Token: 0x04002C56 RID: 11350
			Land,
			// Token: 0x04002C57 RID: 11351
			WeaponTarget
		}

		// Token: 0x02000ADD RID: 2781
		public enum _Category
		{
			// Token: 0x04002C59 RID: 11353
			const_0,
			// Token: 0x04002C5A RID: 11354
			const_1
		}

		// Token: 0x02000ADE RID: 2782
		public enum _Creator : byte
		{
			// Token: 0x04002C5C RID: 11356
			const_0,
			// Token: 0x04002C5D RID: 11357
			const_1,
			// Token: 0x04002C5E RID: 11358
			const_2,
			// Token: 0x04002C5F RID: 11359
			const_3
		}

		// Token: 0x02000ADF RID: 2783
		public enum _TurnRate : byte
		{
			// Token: 0x04002C61 RID: 11361
			Standard,
			// Token: 0x04002C62 RID: 11362
			Half,
			// Token: 0x04002C63 RID: 11363
			Double,
			// Token: 0x04002C64 RID: 11364
			const_3 = 2,
			// Token: 0x04002C65 RID: 11365
			const_4,
			// Token: 0x04002C66 RID: 11366
			const_5
		}

		// Token: 0x02000AE0 RID: 2784
		public enum Enum52
		{
			// Token: 0x04002C68 RID: 11368
			const_0,
			// Token: 0x04002C69 RID: 11369
			const_1,
			// Token: 0x04002C6A RID: 11370
			const_2,
			// Token: 0x04002C6B RID: 11371
			const_3
		}

		// Token: 0x02000AE1 RID: 2785
		public enum _FlightFormation
		{
			// Token: 0x04002C6D RID: 11373
			Spread,
			// Token: 0x04002C6E RID: 11374
			Trail_1nm,
			// Token: 0x04002C6F RID: 11375
			Split = 100
		}
	}
}

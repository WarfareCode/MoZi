using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 卫星
	public sealed class Satellite : Platform
	{
		// Token: 0x06005C23 RID: 23587 RVA: 0x002A0F70 File Offset: 0x0029F170
		public Satellite_Kinematics GetSatelliteKinematics()
		{
			if (Information.IsNothing(this.satellite_Kinematics))
			{
				ActiveUnit activeUnit = this;
				this.satellite_Kinematics = new Satellite_Kinematics(ref activeUnit);
			}
			return this.satellite_Kinematics;
		}

		// Token: 0x06005C24 RID: 23588 RVA: 0x002A0FA4 File Offset: 0x0029F1A4
		public Satellite_Damage GetSatelliteDamage()
		{
			if (Information.IsNothing(this.satellite_Damage))
			{
				ActiveUnit activeUnit = this;
				this.satellite_Damage = new Satellite_Damage(ref activeUnit);
			}
			return this.satellite_Damage;
		}

		// Token: 0x06005C25 RID: 23589 RVA: 0x002A0FD8 File Offset: 0x0029F1D8
		public override float GetArea()
		{
			return this.Length * this.Span;
		}

		// Token: 0x06005C26 RID: 23590 RVA: 0x00029388 File Offset: 0x00027588
		public bool method_129()
		{
			return this.GetSatelliteKinematics().method_17() < 40000000L && this.GetSatelliteKinematics().method_18() > 30000000L;
		}

		// Token: 0x06005C27 RID: 23591 RVA: 0x000293B9 File Offset: 0x000275B9
		public Satellite(ref Scenario scenario_1) : base(ref scenario_1, null)
		{
		}

		// Token: 0x06005C28 RID: 23592 RVA: 0x002A0FF4 File Offset: 0x0029F1F4
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					if (!Information.IsNothing(this.GetSide(false)))
					{
						xmlWriter_0.WriteStartElement("Satellite");
						xmlWriter_0.WriteElementString("ID", base.GetGuid());
						if (hashSet_0.Contains(base.GetGuid()))
						{
							xmlWriter_0.WriteEndElement();
						}
						else
						{
							hashSet_0.Add(base.GetGuid());
							xmlWriter_0.WriteElementString("Name", this.Name);
							xmlWriter_0.WriteElementString("SID", this.SID);
							if (base.GetRangeSymbols().Count > 0)
							{
								xmlWriter_0.WriteStartElement("RangeSymbols");
								using (List<RangeSymbol>.Enumerator enumerator = base.GetRangeSymbols().GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										enumerator.Current.Save(ref xmlWriter_0);
									}
								}
								xmlWriter_0.WriteEndElement();
							}
							xmlWriter_0.WriteElementString("Side", this.GetSide(false).GetSideName());
							if (!string.IsNullOrEmpty(this.Message))
							{
								xmlWriter_0.WriteElementString("Message", this.Message);
							}
							if (this.GetLongitude_UnitEntersAreaCheck().HasValue)
							{
								xmlWriter_0.WriteElementString("Longitude_UnitEntersAreaCheck", XmlConvert.ToString(this.GetLongitude_UnitEntersAreaCheck().Value));
							}
							if (this.GetLatitude_UnitEntersAreaCheck().HasValue)
							{
								xmlWriter_0.WriteElementString("Latitude_UnitEntersAreaCheck", XmlConvert.ToString(this.GetLatitude_UnitEntersAreaCheck().Value));
							}
							xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
							if (this.GetNoneMCMSensors().Length > 0)
							{
								xmlWriter_0.WriteStartElement("Sensors");
								Sensor[] sensors = this.m_Sensors;
								for (int i = 0; i < sensors.Length; i++)
								{
									sensors[i].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
									xmlWriter_0.Flush();
								}
								xmlWriter_0.WriteEndElement();
							}
							if (this.GetCommDevices().Length > 0)
							{
								xmlWriter_0.WriteStartElement("Comms");
								CommDevice[] commDevices = this.m_CommDevices;
								for (int j = 0; j < commDevices.Length; j++)
								{
									commDevices[j].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
									xmlWriter_0.Flush();
								}
								xmlWriter_0.WriteEndElement();
							}
							if (this.m_Mounts.Length > 0)
							{
								xmlWriter_0.WriteStartElement("Mounts");
								Mount[] mounts = this.m_Mounts;
								for (int k = 0; k < mounts.Length; k++)
								{
									mounts[k].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
									xmlWriter_0.Flush();
								}
								xmlWriter_0.WriteEndElement();
							}
							xmlWriter_0.WriteElementString("Status", ((byte)this.GetUnitStatus()).ToString());
							if (!Information.IsNothing(this.GetAssignedMission(false)))
							{
								xmlWriter_0.WriteElementString("AssignedMission", this.AssignedMission.GetGuid());
							}
							if (!Information.IsNothing(this.GetAssignedTaskPool()))
							{
								xmlWriter_0.WriteElementString("AssignedTaskPool", this.AssignedTaskPool.GetGuid());
							}
							if (!Information.IsNothing(this.GetParentGroup(false)))
							{
								xmlWriter_0.WriteElementString("ParentGroup", this.parentGroup.GetGuid());
							}
							if (base.IsAutoDetectable(null))
							{
								xmlWriter_0.WriteElementString("IsAD", base.IsAutoDetectable(null).ToString());
							}
							this.m_Doctrine.Save(ref xmlWriter_0, ref this.m_Scenario, "Doctrine");
							xmlWriter_0.WriteStartElement("ActiveUnit_AI");
							this.GetAI().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("ActiveUnit_Sensory");
							this.GetSensory().Save(ref xmlWriter_0);
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("ActiveUnit_CommStuff");
							this.GetCommStuff().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteEndElement();
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100753", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005C29 RID: 23593 RVA: 0x002A1434 File Offset: 0x0029F634
		public static Satellite smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_1)
		{
			Satellite satellite;
			try
			{
				satellite = Satellite.smethod_2(ref xmlNode_0, ref dictionary_0, ref scenario_1, scenario_1.LoadStockUnits);
			}
			catch (Exception0 projectError)
			{
				ProjectData.SetProjectError(projectError);
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				dictionary_0.Remove(innerText);
				satellite = Satellite.smethod_2(ref xmlNode_0, ref dictionary_0, ref scenario_1, true);
				string text = "";
				if (satellite.HasParentGroup())
				{
					text = "(member of group: [" + satellite.GetParentGroup(false).Name + "])";
				}
				scenario_1.LoadingNotices.Add(string.Concat(new string[]
				{
					"The following satellite:[",
					satellite.Name,
					"]",
					text,
					" failed to shallow-rebuild because of a component missing. The satellite was instead deep-rebuilt, and instantiated in its pristine DB-stock condition. All customizations present in the satellite's components (damaged components, weapon additions/removals etc. etc.) have been lost. Please re-apply any necessary customizations either manually or using an SBR script."
				}));
				ProjectData.ClearProjectError();
			}
			return satellite;
		}

		// Token: 0x06005C2A RID: 23594 RVA: 0x002A1518 File Offset: 0x0029F718
		private static Satellite smethod_2(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_1, bool bool_17)
		{
			Satellite satellite = null;
			Satellite result;
			try
			{
				Satellite satellite2 = new Satellite(ref scenario_1);
				satellite2.m_Scenario = scenario_1;
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					satellite = (Satellite)dictionary_0[innerText];
				}
				else
				{
					satellite2.SetGuid(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						satellite = satellite2;
					}
					else
					{
						dictionary_0.Add(satellite2.GetGuid(), satellite2);
						int num = Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "DBID").InnerText);
						int orbitNumber = Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "SID").InnerText.Split(new char[]
						{
							'_'
						})[1]);
						try
						{
							DBFunctions.LoadSatelliteData(ref scenario_1, ref satellite2, num, orbitNumber, bool_17);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							dictionary_0.Remove(satellite2.GetGuid());
							scenario_1.LoadingNotices.Add("Satellite with Database ID " + Conversions.ToString(num) + " is missing from the database and has not been loaded.");
							ProjectData.ClearProjectError();
							result = satellite;
							return result;
						}
						if (bool_17)
						{
							satellite2.LoadAirFacilities(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						}
						if (!bool_17)
						{
							IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									XmlNode xmlNode = (XmlNode)enumerator.Current;
									string name = xmlNode.Name;
									if (Operators.CompareString(name, "Sensors", false) != 0)
									{
										if (Operators.CompareString(name, "Comms", false) != 0)
										{
											if (Operators.CompareString(name, "Mounts", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator2.MoveNext())
												{
													XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
													Mount mount = Mount.Load(ref xmlNode2, ref dictionary_0, satellite2);
													ScenarioArrayUtil.AddMount(ref satellite2.m_Mounts, mount);
													mount.SetParentPlatform(satellite2);
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
										IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator3.MoveNext())
											{
												XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
												CommDevice commDevice = CommDevice.Load(ref xmlNode3, ref dictionary_0, satellite2);
												satellite2.AddCommDevice(commDevice);
												commDevice.SetParentPlatform(satellite2);
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
									IEnumerator enumerator4 = xmlNode.ChildNodes.GetEnumerator();
									try
									{
										while (enumerator4.MoveNext())
										{
											Sensor sensor = Sensor.Load((XmlNode)enumerator4.Current, dictionary_0, satellite2);
											ScenarioArrayUtil.AddSensor(ref satellite2.m_Sensors, sensor);
											sensor.SetParentPlatform(satellite2);
										}
									}
									finally
									{
										if (enumerator4 is IDisposable)
										{
											(enumerator4 as IDisposable).Dispose();
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
						}
						IEnumerator enumerator5 = xmlNode_0.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator5.MoveNext())
							{
								XmlNode xmlNode4 = (XmlNode)enumerator5.Current;
								string name2 = xmlNode4.Name;
								uint num2 = Class382.smethod_0(name2);
								if (num2 <= 2247649009u)
								{
									if (num2 <= 1406576475u)
									{
										if (num2 <= 266367750u)
										{
											if (num2 != 6222351u)
											{
												if (num2 == 266367750u && Operators.CompareString(name2, "Name", false) == 0)
												{
													satellite2.Name = xmlNode4.InnerText;
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Status", false) != 0)
												{
													continue;
												}
												if (Versioned.IsNumeric(xmlNode4.InnerText))
												{
													satellite2.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode4.InnerText));
												}
												else
												{
													satellite2.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode4.InnerText, true));
												}
												if (satellite2.GetUnitStatus() == (ActiveUnit._ActiveUnitStatus)9)
												{
													satellite2.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 485784328u)
										{
											if (num2 == 1406576475u && Operators.CompareString(name2, "ActiveUnit_Sensory", false) == 0)
											{
												ActiveUnit activeUnit = satellite2;
												ActiveUnit activeUnit2 = satellite2;
												((Satellite)activeUnit).m_Sensory = ActiveUnit_Sensory.GetSensoryByXmlNode(ref xmlNode4, ref dictionary_0, ref activeUnit2);
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name2, "IsAD", false) != 0)
										{
											continue;
										}
									}
									else if (num2 <= 1992083866u)
									{
										if (num2 != 1493866095u)
										{
											if (num2 == 1992083866u && Operators.CompareString(name2, "Latitude_UnitEntersAreaCheck", false) == 0)
											{
												satellite2.SetLatitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode4.InnerText)));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SID", false) == 0)
											{
												satellite2.SID = xmlNode4.InnerText;
												continue;
											}
											continue;
										}
									}
									else if (num2 != 2047910612u)
									{
										if (num2 == 2247649009u && Operators.CompareString(name2, "AssignedMission", false) == 0 && xmlNode4.HasChildNodes)
										{
											XmlNode xmlNode5 = xmlNode4.ChildNodes[0];
											satellite2.AssignedMissionName = xmlNode5.InnerText;
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name2, "ActiveUnit_AI", false) == 0)
										{
											ActiveUnit_AI.Load(xmlNode4, dictionary_0, satellite2);
											continue;
										}
										continue;
									}
								}
								else if (num2 <= 2874698282u)
								{
									if (num2 <= 2571339398u)
									{
										if (num2 != 2496321123u)
										{
											if (num2 == 2571339398u && Operators.CompareString(name2, "Aircraft_CommStuff", false) == 0)
											{
												ActiveUnit activeUnit3 = satellite2;
												ActiveUnit activeUnit2 = satellite2;
												((Satellite)activeUnit3).m_CommStuff = Aircraft_CommStuff.Load(ref xmlNode4, ref dictionary_0, ref activeUnit2);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "RangeSymbols", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator6 = xmlNode4.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator6.MoveNext())
												{
													RangeSymbol item = RangeSymbol.Load((XmlNode)enumerator6.Current, dictionary_0);
													satellite2.GetRangeSymbols().Add(item);
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
										}
									}
									if (num2 != 2590053246u)
									{
										if (num2 == 2874698282u && Operators.CompareString(name2, "AssignedTaskPool", false) == 0 && xmlNode4.HasChildNodes)
										{
											XmlNode xmlNode6 = xmlNode4.ChildNodes[0];
											satellite2.AssignedTaskPoolName = xmlNode6.InnerText;
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name2, "Side", false) == 0)
										{
											satellite2.strSide = xmlNode4.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num2 <= 3736393060u)
								{
									if (num2 != 2920208772u)
									{
										if (num2 == 3736393060u && Operators.CompareString(name2, "ParentGroup", false) == 0)
										{
											satellite2.ParentGroupName = xmlNode4.InnerText;
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name2, "Message", false) == 0)
										{
											satellite2.Message = xmlNode4.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num2 != 3792306253u)
								{
									if (num2 != 4080539297u || Operators.CompareString(name2, "IsAutoDetectable", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name2, "Longitude_UnitEntersAreaCheck", false) == 0)
									{
										satellite2.SetLongitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode4.InnerText)));
										continue;
									}
									continue;
								}
								satellite2.SetIsAutoDetectable(null, Conversions.ToBoolean(xmlNode4.InnerText));
							}
						}
						finally
						{
							if (enumerator5 is IDisposable)
							{
								(enumerator5 as IDisposable).Dispose();
							}
						}
						satellite2.GetSatelliteKinematics().UpdateUnitPositions(1f, false, false);
						satellite = satellite2;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100754", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = satellite;
			return result;
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool IsPlatform()
		{
			return true;
		}

		// Token: 0x06005C2C RID: 23596 RVA: 0x000293F0 File Offset: 0x000275F0
		public override GlobalVariables.ActiveUnitType GetUnitType()
		{
			return GlobalVariables.ActiveUnitType.Satellite;
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x002A1E38 File Offset: 0x002A0038
		public override bool IsOperating()
		{
			return DateTime.Compare(this.m_Scenario.GetCurrentTime(false), this.LaunchDate) >= 0 && (DateTime.Compare(this.m_Scenario.GetCurrentTime(false), this.DeOrbitingDate) <= 0 || DateTime.Compare(this.DeOrbitingDate, new DateTime(1900, 1, 1)) <= 0);
		}

		// Token: 0x0400307D RID: 12413
		public string SID;

		// Token: 0x0400307E RID: 12414
		public DateTime LaunchDate;

		// Token: 0x0400307F RID: 12415
		public DateTime DeOrbitingDate;

		// Token: 0x04003080 RID: 12416
		public Satellite._SatelliteCategory SatelliteCategory;

		// Token: 0x04003081 RID: 12417
		public Satellite._SatelliteType SatelliteType;

		// Token: 0x04003082 RID: 12418
		public GlobalVariables.ArmorRating armorRating;

		// Token: 0x04003083 RID: 12419
		public new double WeightEmpty = 0.0;

		// Token: 0x04003084 RID: 12420
		public new double WeightMax = 0.0;

		// Token: 0x04003085 RID: 12421
		public new double WeightPayload = 0.0;

		// Token: 0x04003086 RID: 12422
		public float Length;

		// Token: 0x04003087 RID: 12423
		public float Span;

		// Token: 0x04003088 RID: 12424
		public float Height;

		// Token: 0x04003089 RID: 12425
		public float DamagePoints;

		// Token: 0x0400308A RID: 12426
		private Satellite_Kinematics satellite_Kinematics;

		// Token: 0x0400308B RID: 12427
		private Satellite_Damage satellite_Damage;

		// Token: 0x02000B2F RID: 2863
		public enum _SatelliteCategory
		{
			// Token: 0x0400308D RID: 12429
			None = 1001,
			// Token: 0x0400308E RID: 12430
			GeoStationary = 2001
		}

		// Token: 0x02000B30 RID: 2864
		public enum _SatelliteType
		{
			// Token: 0x04003090 RID: 12432
			None = 1001,
			// Token: 0x04003091 RID: 12433
			IMGSAT = 2001,
			// Token: 0x04003092 RID: 12434
			RORSAT,
			// Token: 0x04003093 RID: 12435
			EORSAT,
			// Token: 0x04003094 RID: 12436
			SIGINT,
			// Token: 0x04003095 RID: 12437
			ELINT,
			// Token: 0x04003096 RID: 12438
			NOSS,
			// Token: 0x04003097 RID: 12439
			MASINT
		}
	}
}

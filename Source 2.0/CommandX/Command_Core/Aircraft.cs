using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 飞机
	public sealed class Aircraft : Platform, ICargo
	{
		// 保存
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				if (!Information.IsNothing(this.GetSide(false)))
				{
					try
					{
						xmlWriter_0.WriteStartElement("Aircraft");
						xmlWriter_0.WriteElementString("ID", base.GetGuid());
						if (hashSet_0.Contains(base.GetGuid()))
						{
							xmlWriter_0.WriteEndElement();
						}
						else
						{
							hashSet_0.Add(base.GetGuid());
							xmlWriter_0.WriteElementString("Name", this.Name);
							xmlWriter_0.WriteElementString("CH", XmlConvert.ToString(this.GetCurrentHeading()));
							xmlWriter_0.WriteElementString("CS", XmlConvert.ToString(this.GetCurrentSpeed()));
							xmlWriter_0.WriteElementString("CA", XmlConvert.ToString(this.GetCurrentAltitude_ASL(false)));
							xmlWriter_0.WriteElementString("Lon", XmlConvert.ToString(this.Longitude));
							xmlWriter_0.WriteElementString("Lat", XmlConvert.ToString(this.Latitude));
							if (base.GetLongitudeLR().HasValue)
							{
								xmlWriter_0.WriteElementString("LonLR", XmlConvert.ToString(base.GetLongitudeLR().Value));
							}
							if (base.GetLatitudeLR().HasValue)
							{
								xmlWriter_0.WriteElementString("LatLR", XmlConvert.ToString(base.GetLatitudeLR().Value));
							}
							if (this.GetLongitude_UnitEntersAreaCheck().HasValue)
							{
								xmlWriter_0.WriteElementString("Longitude_UnitEntersAreaCheck", XmlConvert.ToString(this.GetLongitude_UnitEntersAreaCheck().Value));
							}
							if (this.GetLatitude_UnitEntersAreaCheck().HasValue)
							{
								xmlWriter_0.WriteElementString("Latitude_UnitEntersAreaCheck", XmlConvert.ToString(this.GetLatitude_UnitEntersAreaCheck().Value));
							}
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
							xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
							xmlWriter_0.WriteElementString("DH", XmlConvert.ToString(this.GetDesiredHeading(ActiveUnit._TurnRate.const_0)));
							xmlWriter_0.WriteElementString("DS", XmlConvert.ToString(this.GetDesiredSpeed()));
							xmlWriter_0.WriteElementString("DA", XmlConvert.ToString(this.GetDesiredAltitude()));
							xmlWriter_0.WriteElementString("DT", ((byte)this.GetDesiredTurnRate()).ToString());
							xmlWriter_0.WriteElementString("DTN", ((byte)this.GetDesiredTurnRate_Navigation()).ToString());
							xmlWriter_0.WriteElementString("DesiredAltitude_TerrainFollowing", XmlConvert.ToString(this.GetDesiredAltitude_TerrainFollowing()));
							xmlWriter_0.WriteElementString("TerrainFollowing", this.IsTerrainFollowing(this).ToString());
							XmlWriter xmlWriter = xmlWriter_0;
							string localName = "FlightRole";
							byte b = (byte)this.FlightRole;
							xmlWriter.WriteElementString(localName, b.ToString());
							xmlWriter_0.WriteElementString("Thr", ((byte)this.GetThrottle()).ToString());
							xmlWriter_0.WriteElementString("AbnTime", XmlConvert.ToString(this.AbnTime));
							if (!Information.IsNothing(this.m_ProficiencyLevel))
							{
								xmlWriter_0.WriteElementString("Prof", ((int)this.m_ProficiencyLevel.Value).ToString());
							}
							if (this.GetNoneMCMSensors().Length > 0)
							{
								xmlWriter_0.WriteStartElement("Sensors");
								Sensor[] sensors = this.m_Sensors;
								for (int i = 0; i < sensors.Length; i++)
								{
									sensors[i].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
								}
								xmlWriter_0.WriteEndElement();
								if (!Information.IsNothing(this.GetLoadout()) && this.GetLoadout().GetPoddedSensors(this.m_Scenario).Length > 0)
								{
									xmlWriter_0.WriteStartElement("PoddedSensors");
									Sensor[] poddedSensors = this.GetLoadout().GetPoddedSensors(this.m_Scenario);
									for (int j = 0; j < poddedSensors.Length; j++)
									{
										Sensor sensor = poddedSensors[j];
										HashSet<string> hashSet = new HashSet<string>();
										sensor.Save(ref xmlWriter_0, ref hashSet, this.m_Scenario);
									}
									xmlWriter_0.WriteEndElement();
								}
							}
							if (this.GetCommDevices().Length > 0)
							{
								xmlWriter_0.WriteStartElement("Comms");
								CommDevice[] commDevices = this.m_CommDevices;
								for (int k = 0; k < commDevices.Length; k++)
								{
									commDevices[k].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
								}
								xmlWriter_0.WriteEndElement();
							}
							if (this.GetEngines().Count > 0)
							{
								xmlWriter_0.WriteStartElement("Propulsion");
								using (IEnumerator<Engine> enumerator2 = this.GetEngines().GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										enumerator2.Current.Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
									}
								}
								xmlWriter_0.WriteEndElement();
							}
							if (this.m_FuelRecs.Count<FuelRec>() > 0)
							{
								xmlWriter_0.WriteStartElement("Fuel");
								FuelRec[] fuelRecs = this.m_FuelRecs;
								for (int l = 0; l < fuelRecs.Length; l++)
								{
									fuelRecs[l].Save(ref xmlWriter_0);
								}
								xmlWriter_0.WriteEndElement();
							}
							if (this.m_Mounts.Length > 0)
							{
								xmlWriter_0.WriteStartElement("Mounts");
								Mount[] mounts = this.m_Mounts;
								for (int m = 0; m < mounts.Length; m++)
								{
									Mount mount = mounts[m];
									if (Information.IsNothing(mount.GetParentPlatform()))
									{
										mount.SetParentPlatform(this);
									}
									mount.Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
									xmlWriter_0.Flush();
								}
								xmlWriter_0.WriteEndElement();
							}
							if (this.m_OnboardCargos.Count<Cargo>() > 0)
							{
								xmlWriter_0.WriteStartElement("OnboardCargo");
								Cargo[] onboardCargos = this.m_OnboardCargos;
								for (int n = 0; n < onboardCargos.Length; n++)
								{
									onboardCargos[n].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
								}
								xmlWriter_0.WriteEndElement();
							}
							XmlWriter xmlWriter2 = xmlWriter_0;
							string localName2 = "Status";
							b = (byte)this.activeUnitStatus;
							xmlWriter2.WriteElementString(localName2, b.ToString());
							XmlWriter xmlWriter3 = xmlWriter_0;
							string localName3 = "FuelState";
							b = (byte)this.activeUnitFuelState;
							xmlWriter3.WriteElementString(localName3, b.ToString());
							XmlWriter xmlWriter4 = xmlWriter_0;
							string localName4 = "WeaponState";
							b = (byte)this.weaponState;
							xmlWriter4.WriteElementString(localName4, b.ToString());
							XmlWriter xmlWriter5 = xmlWriter_0;
							string localName5 = "SBR";
							b = (byte)this.SBR;
							xmlWriter5.WriteElementString(localName5, b.ToString());
							XmlWriter xmlWriter6 = xmlWriter_0;
							string localName6 = "SBED";
							b = (byte)this.SBEngagedDefensive;
							xmlWriter6.WriteElementString(localName6, b.ToString());
							XmlWriter xmlWriter7 = xmlWriter_0;
							string localName7 = "SBEO";
							b = (byte)this.SBEngagedOffensive;
							xmlWriter7.WriteElementString(localName7, b.ToString());
							XmlWriter xmlWriter8 = xmlWriter_0;
							string localName8 = "FSBR";
							b = (byte)this.FuelStateBR;
							xmlWriter8.WriteElementString(localName8, b.ToString());
							xmlWriter_0.WriteElementString("SBR_Altitude", XmlConvert.ToString(this.SBR_Altitude));
							xmlWriter_0.WriteElementString("SBR_Altitude_TF", XmlConvert.ToString(this.SBR_Altitude_TerrainFollowing));
							xmlWriter_0.WriteElementString("SBR_TF", XmlConvert.ToString(this.SBR_TerrainFollowing));
							XmlWriter xmlWriter9 = xmlWriter_0;
							string localName9 = "SBR_ThrottleSetting";
							b = (byte)this.SBR_ThrottleSetting;
							xmlWriter9.WriteElementString(localName9, b.ToString());
							xmlWriter_0.WriteElementString("SBED_Altitude", XmlConvert.ToString(this.SBEngagedDefensive_Altitude));
							xmlWriter_0.WriteElementString("SBED_Altitude_TF", XmlConvert.ToString(this.SBEngagedDefensive_Altitude_TerrainFollowing));
							xmlWriter_0.WriteElementString("SBED_TF", XmlConvert.ToString(this.SBEngagedDefensive_TerrainFollowing));
							XmlWriter xmlWriter10 = xmlWriter_0;
							string localName10 = "SBED_ThrottleSetting";
							b = (byte)this.SBEngagedDefensive_ThrottleSetting;
							xmlWriter10.WriteElementString(localName10, b.ToString());
							xmlWriter_0.WriteElementString("SBEO_Altitude", XmlConvert.ToString(this.SBEngagedOffensive_Altitude));
							xmlWriter_0.WriteElementString("SBEO_Altitude_TF", XmlConvert.ToString(this.SBEngagedOffensive_Altitude_TerrainFollowing));
							xmlWriter_0.WriteElementString("SBEO_TF", XmlConvert.ToString(this.SBEngagedOffensive_TerrainFollowing));
							XmlWriter xmlWriter11 = xmlWriter_0;
							string localName11 = "SBEO_ThrottleSetting";
							b = (byte)this.SBEngagedOffensive_ThrottleSetting;
							xmlWriter11.WriteElementString(localName11, b.ToString());
							xmlWriter_0.WriteElementString("DamagePts", XmlConvert.ToString(this.GetDamagePts(false)));
							if (this.m_AirFacilities.Length > 0)
							{
								xmlWriter_0.WriteStartElement("AirFacilities");
								AirFacility[] airFacilities = this.m_AirFacilities;
								for (int num = 0; num < airFacilities.Length; num++)
								{
									airFacilities[num].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
									xmlWriter_0.Flush();
								}
								xmlWriter_0.WriteEndElement();
							}
							if (this.m_DockFacilities.Count<DockFacility>() > 0)
							{
								xmlWriter_0.WriteStartElement("DockFacilities");
								DockFacility[] dockFacilities = this.m_DockFacilities;
								for (int num2 = 0; num2 < dockFacilities.Length; num2++)
								{
									dockFacilities[num2].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
									xmlWriter_0.Flush();
								}
								xmlWriter_0.WriteEndElement();
							}
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
							if (!Information.IsNothing(this.GetLoadout()))
							{
								xmlWriter_0.WriteStartElement("Loadout");
								this.m_Loadout.Save(ref xmlWriter_0, ref hashSet_0, ref this.m_Scenario);
								xmlWriter_0.WriteEndElement();
							}
							this.GetAircraftNavigator().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteStartElement("AI");
							if (Information.IsNothing(this.GetAircraftAI().m_ActiveUnit))
							{
								this.GetAircraftAI().m_ActiveUnit = this;
							}
							this.GetAircraftAI().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Kinematics");
							this.GetAircraftKinematics().Save(ref xmlWriter_0);
							xmlWriter_0.WriteEndElement();
							this.GetAircraftSensory().Save(ref xmlWriter_0);
							this.GetAircraftWeaponry().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteStartElement("CommStuff");
							this.GetAircraftCommStuff().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteEndElement();
							this.GetAircraftDamage().Save(ref xmlWriter_0);
							this.GetAircraftAirOps().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteEndElement();
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100348", "");
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

		// Token: 0x060043E9 RID: 17385 RVA: 0x0018E744 File Offset: 0x0018C944
		private Aircraft() : base(ref Aircraft.scenario, null)
		{
			this.AircraftCockpitArmor = GlobalVariables.ArmorRating.None;
			this.AircraftFuselageArmor = GlobalVariables.ArmorRating.None;
			this.AircraftEngineArmor = GlobalVariables.ArmorRating.None;
			this.FuelQuantityLeftToBingo = 0f;
			this.FuelQuantityLeftToJoker = 0f;
			this.ForwardCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Excellent;
			this.SidewaysCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Excellent;
			this.AftCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Excellent;
			this.IsAircraft = true;
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x0018E7D0 File Offset: 0x0018C9D0
		public static Aircraft ShallowRebuild(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_)
		{
			Aircraft aircraft = null;
			try
			{
				aircraft = Aircraft.smethod_2(ref xmlNode_0, ref dictionary_0, ref scenario_, scenario_.LoadStockUnits);
			}
			catch (Exception0 projectError)
			{
				ProjectData.SetProjectError(projectError);
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				dictionary_0.Remove(innerText);
				aircraft = Aircraft.smethod_2(ref xmlNode_0, ref dictionary_0, ref scenario_, true);
				string text = "";
				if (aircraft.HasParentGroup())
				{
					text = "(member of group: [" + aircraft.GetParentGroup(false).Name + "])";
				}
				scenario_.LoadingNotices.Add(string.Concat(new string[]
				{
					"The following aircraft:[",
					aircraft.Name,
					"]",
					text,
					" failed to shallow-rebuild because of a component missing. The aircraft was instead deep-rebuilt, and instantiated in its pristine DB-stock condition. All customizations present in the aircraft's components (damaged components, weapon additions/removals etc. etc.) have been lost. Please re-apply any necessary customizations either manually or using an SBR script."
				}));
				ProjectData.ClearProjectError();
			}
			return aircraft;
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x0018E8B4 File Offset: 0x0018CAB4
		private static Aircraft smethod_2(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_1, bool bool_32)
		{
			Aircraft aircraft = new Aircraft();
			Sensor[] array = new Sensor[0];
			Aircraft aircraft2 = null;
			Aircraft result;
			try
			{
				aircraft.m_Scenario = scenario_1;
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					aircraft2 = (Aircraft)dictionary_0[innerText];
				}
				else
				{
					aircraft.SetGuid(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						aircraft2 = aircraft;
					}
					else
					{
						dictionary_0.Add(aircraft.GetGuid(), aircraft);
						int num = Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "DBID").InnerText);
						try
						{
							DBFunctions.smethod_19(ref scenario_1, ref aircraft, num, bool_32);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							dictionary_0.Remove(aircraft.GetGuid());
							scenario_1.LoadingNotices.Add("Aircraft with Database ID " + Conversions.ToString(num) + " is missing from the database and has not been loaded.");
							ProjectData.ClearProjectError();
							result = aircraft2;
							return result;
						}
						if (bool_32)
						{
							aircraft.LoadAirFacilities(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						}
						if (!bool_32)
						{
							IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									XmlNode xmlNode = (XmlNode)enumerator.Current;
									string name = xmlNode.Name;
									uint num2 = Class382.smethod_0(name);
									if (num2 <= 2241118125u)
									{
										if (num2 <= 2008421230u)
										{
											if (num2 != 1305748348u)
											{
												if (num2 == 2008421230u && Operators.CompareString(name, "Comms", false) == 0)
												{
													int num3 = xmlNode.ChildNodes.Count - 1;
													int i = 0;
													while (i <= num3)
													{
														XmlNode xmlNode2 = xmlNode.ChildNodes[i];
														CommDevice commDevice = CommDevice.Load(ref xmlNode2, ref dictionary_0, aircraft);
														if (commDevice.DBID == 0)
														{
															Aircraft aircraft3 = new Aircraft(ref scenario_1, null);
															aircraft3.m_Scenario = scenario_1;
															DBFunctions.smethod_19(ref scenario_1, ref aircraft3, num, true);
															try
															{
																commDevice = aircraft3.GetCommDevices()[i];
																aircraft3 = null;
															}
															catch (Exception ex)
															{
																ProjectData.SetProjectError(ex);
																Exception ex2 = ex;
																ex2.Data.Add("Error at 200018", ex2.Message);
																GameGeneral.LogException(ref ex2);
																if (Debugger.IsAttached)
																{
																	Debugger.Break();
																}
																ProjectData.ClearProjectError();
																goto IL_268;
															}
															goto IL_248;
														}
														goto IL_248;
														IL_268:
														i++;
														continue;
														IL_248:
														dictionary_0.Add(commDevice.GetGuid(), commDevice);
														aircraft.AddCommDevice(commDevice);
														commDevice.SetParentPlatform(aircraft);
														goto IL_268;
													}
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "OnboardCargo", false) != 0)
												{
													continue;
												}
												IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
												try
												{
													while (enumerator2.MoveNext())
													{
														XmlNode xmlNode3 = (XmlNode)enumerator2.Current;
														Cargo cargo = Cargo.Load(ref xmlNode3, ref dictionary_0, aircraft);
														ScenarioArrayUtil.AddCargo(ref aircraft.m_OnboardCargos, cargo);
														cargo.SetParentPlatform(aircraft);
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
										if (num2 != 2096367071u)
										{
											if (num2 != 2241118125u || Operators.CompareString(name, "Fuel", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator3.MoveNext())
												{
													XmlNode xmlNode4 = (XmlNode)enumerator3.Current;
													FuelRec fuelRec_ = FuelRec.Load(ref xmlNode4, ref dictionary_0);
													ScenarioArrayUtil.AddFuelRec(ref aircraft.m_FuelRecs, fuelRec_);
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
										if (Operators.CompareString(name, "DockFacilities", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator4 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator4.MoveNext())
											{
												XmlNode xmlNode5 = (XmlNode)enumerator4.Current;
												DockFacility dockFacility = DockFacility.Load(ref xmlNode5, ref dictionary_0, ref scenario_1);
												aircraft.AddDockFacility(dockFacility);
												dockFacility.SetParentPlatform(aircraft);
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
									if (num2 <= 2424405304u)
									{
										if (num2 != 2246682072u)
										{
											if (num2 != 2424405304u || Operators.CompareString(name, "Sensors", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator5 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator5.MoveNext())
												{
													Sensor sensor = Sensor.Load((XmlNode)enumerator5.Current, dictionary_0, aircraft);
													ScenarioArrayUtil.AddSensor(ref aircraft.m_Sensors, sensor);
													sensor.SetParentPlatform(aircraft);
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
										if (Operators.CompareString(name, "Propulsion", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator6 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator6.MoveNext())
											{
												XmlNode xmlNode6 = (XmlNode)enumerator6.Current;
												ActiveUnit activeUnit = aircraft;
												Engine engine = Engine.Load(ref xmlNode6, ref dictionary_0, ref activeUnit);
												aircraft.GetEngines().Add(engine);
												engine.SetParentPlatform(aircraft);
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
									if (num2 != 3520996972u)
									{
										if (num2 != 3760177291u)
										{
											if (num2 != 3989581338u || Operators.CompareString(name, "AirFacilities", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator7 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator7.MoveNext())
												{
													XmlNode xmlNode7 = (XmlNode)enumerator7.Current;
													AirFacility airFacility = AirFacility.Load(ref xmlNode7, ref dictionary_0, ref scenario_1);
													aircraft.AddAirFacility(airFacility);
													airFacility.SetParentPlatform(aircraft);
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
										if (Operators.CompareString(name, "Mounts", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator8 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator8.MoveNext())
											{
												XmlNode xmlNode8 = (XmlNode)enumerator8.Current;
												Mount mount = Mount.Load(ref xmlNode8, ref dictionary_0, aircraft);
												ScenarioArrayUtil.AddMount(ref aircraft.m_Mounts, mount);
												mount.SetParentPlatform(aircraft);
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
									if (Operators.CompareString(name, "PoddedSensors", false) == 0)
									{
										IEnumerator enumerator9 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator9.MoveNext())
											{
												XmlNode xmlNode_ = (XmlNode)enumerator9.Current;
												Dictionary<string, Subject> dictionary_ = new Dictionary<string, Subject>();
												Sensor sensor_ = Sensor.Load(xmlNode_, dictionary_, aircraft);
												ScenarioArrayUtil.AddSensor(ref array, sensor_);
											}
										}
										finally
										{
											if (enumerator9 is IDisposable)
											{
												(enumerator9 as IDisposable).Dispose();
											}
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
						IEnumerator enumerator10 = xmlNode_0.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator10.MoveNext())
							{
								XmlNode xmlNode9 = (XmlNode)enumerator10.Current;
								string name2 = xmlNode9.Name;
								uint num2 = Class382.smethod_0(name2);
								if (num2 > 1738278884u)
								{
									if (num2 <= 2874698282u)
									{
										if (num2 <= 2450333180u)
										{
											if (num2 <= 2066337159u)
											{
												if (num2 <= 1953443573u)
												{
													if (num2 != 1836990821u)
													{
														if (num2 == 1953443573u && Operators.CompareString(name2, "Aircraft_Damage", false) == 0)
														{
															goto IL_180F;
														}
														continue;
													}
													else if (Operators.CompareString(name2, "Latitude", false) != 0)
													{
														continue;
													}
												}
												else if (num2 != 1992083866u)
												{
													if (num2 != 2010780873u)
													{
														if (num2 == 2066337159u && Operators.CompareString(name2, "DesiredAltitude", false) == 0)
														{
															goto IL_1A87;
														}
														continue;
													}
													else
													{
														if (Operators.CompareString(name2, "CA", false) == 0)
														{
															goto IL_1336;
														}
														continue;
													}
												}
												else
												{
													if (Operators.CompareString(name2, "Latitude_UnitEntersAreaCheck", false) == 0)
													{
														aircraft.SetLatitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode9.InnerText)));
														continue;
													}
													continue;
												}
											}
											else if (num2 <= 2128224206u)
											{
												if (num2 != 2077651438u)
												{
													if (num2 != 2128224206u)
													{
														continue;
													}
													if (Operators.CompareString(name2, "CH", false) != 0)
													{
														continue;
													}
													goto IL_1215;
												}
												else
												{
													if (Operators.CompareString(name2, "Aircraft_Kinematics", false) == 0)
													{
														goto IL_1974;
													}
													continue;
												}
											}
											else if (num2 != 2247649009u)
											{
												if (num2 != 2323739590u)
												{
													if (num2 == 2450333180u && Operators.CompareString(name2, "Aircraft_AirOps", false) == 0)
													{
														goto IL_138F;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Sensory", false) == 0)
													{
														goto IL_16C7;
													}
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "AssignedMission", false) == 0 && xmlNode9.HasChildNodes)
												{
													XmlNode xmlNode10 = xmlNode9.ChildNodes[0];
													aircraft.AssignedMissionName = xmlNode10.InnerText;
													continue;
												}
												continue;
											}
										}
										else if (num2 <= 2590053246u)
										{
											if (num2 <= 2527167325u)
											{
												if (num2 != 2496321123u)
												{
													if (num2 == 2527167325u && Operators.CompareString(name2, "TerrainFollowing", false) == 0)
													{
														aircraft.SetIsTerrainFollowing(aircraft, Conversions.ToBoolean(xmlNode9.InnerText));
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
													IEnumerator enumerator11 = xmlNode9.ChildNodes.GetEnumerator();
													try
													{
														while (enumerator11.MoveNext())
														{
															RangeSymbol item = RangeSymbol.Load((XmlNode)enumerator11.Current, dictionary_0);
															aircraft.GetRangeSymbols().Add(item);
														}
														continue;
													}
													finally
													{
														if (enumerator11 is IDisposable)
														{
															(enumerator11 as IDisposable).Dispose();
														}
													}
												}
											}
											if (num2 != 2564648390u)
											{
												if (num2 != 2571339398u)
												{
													if (num2 == 2590053246u && Operators.CompareString(name2, "Side", false) == 0)
													{
														aircraft.strSide = xmlNode9.InnerText;
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Aircraft_CommStuff", false) == 0)
													{
														goto IL_1E2E;
													}
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "Lon", false) == 0)
												{
													goto IL_1ED8;
												}
												continue;
											}
										}
										else if (num2 <= 2715347842u)
										{
											if (num2 != 2691982084u)
											{
												if (num2 == 2715347842u && Operators.CompareString(name2, "Aircraft_AI", false) == 0)
												{
													goto IL_178E;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "DesiredAltitude_TerrainFollowing", false) == 0)
												{
													aircraft.SetDesiredAltitude_TerrainFollowing(XmlConvert.ToSingle(xmlNode9.InnerText));
													continue;
												}
												continue;
											}
										}
										else if (num2 != 2749693904u)
										{
											if (num2 != 2844845263u)
											{
												if (num2 == 2874698282u && Operators.CompareString(name2, "AssignedTaskPool", false) == 0 && xmlNode9.HasChildNodes)
												{
													XmlNode xmlNode11 = xmlNode9.ChildNodes[0];
													aircraft.AssignedTaskPoolName = xmlNode11.InnerText;
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBEO_Altitude", false) == 0)
												{
													aircraft.SBEngagedOffensive_Altitude = XmlConvert.ToSingle(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "DesiredSpeed", false) == 0)
											{
												goto IL_1762;
											}
											continue;
										}
									}
									else if (num2 <= 3370184216u)
									{
										if (num2 <= 3070770765u)
										{
											if (num2 <= 2920208772u)
											{
												if (num2 != 2904824734u)
												{
													if (num2 == 2920208772u && Operators.CompareString(name2, "Message", false) == 0)
													{
														aircraft.Message = xmlNode9.InnerText;
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "SBEO_Altitude_TF", false) == 0)
													{
														aircraft.SBEngagedOffensive_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode9.InnerText);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 2923116889u)
											{
												if (num2 != 3001749054u)
												{
													if (num2 == 3070770765u && Operators.CompareString(name2, "SBR_Altitude", false) == 0)
													{
														aircraft.SBR_Altitude = XmlConvert.ToSingle(xmlNode9.InnerText);
														continue;
													}
													continue;
												}
												else if (Operators.CompareString(name2, "Lat", false) != 0)
												{
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "SBR_ThrottleSetting", false) != 0)
												{
													continue;
												}
												string innerText2 = xmlNode9.InnerText;
												if (Operators.CompareString(innerText2, "FullStop", false) == 0)
												{
													aircraft.SBR_ThrottleSetting = ActiveUnit.Throttle.FullStop;
													continue;
												}
												if (Operators.CompareString(innerText2, "Loiter", false) == 0)
												{
													aircraft.SBR_ThrottleSetting = ActiveUnit.Throttle.Loiter;
													continue;
												}
												if (Operators.CompareString(innerText2, "Cruise", false) == 0)
												{
													aircraft.SBR_ThrottleSetting = ActiveUnit.Throttle.Cruise;
													continue;
												}
												if (Operators.CompareString(innerText2, "Full", false) == 0)
												{
													aircraft.SBR_ThrottleSetting = ActiveUnit.Throttle.Full;
													continue;
												}
												if (Operators.CompareString(innerText2, "Flank", false) != 0)
												{
													aircraft.SBR_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode9.InnerText);
													continue;
												}
												aircraft.SBR_ThrottleSetting = ActiveUnit.Throttle.Flank;
												continue;
											}
										}
										else if (num2 <= 3204468496u)
										{
											if (num2 != 3189373444u)
											{
												if (num2 == 3204468496u && Operators.CompareString(name2, "SBEO", false) == 0)
												{
													aircraft.SBEngagedOffensive = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "LonLR", false) == 0)
												{
													aircraft.SetLongitudeLR(new double?(XmlConvert.ToDouble(xmlNode9.InnerText.Replace(",", "."))));
													continue;
												}
												continue;
											}
										}
										else if (num2 != 3251319825u)
										{
											if (num2 != 3283119613u)
											{
												if (num2 == 3370184216u && Operators.CompareString(name2, "DesiredTurnRate", false) == 0)
												{
													goto IL_1840;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "CurrentSpeed", false) == 0)
												{
													goto IL_1F0D;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "SBR_TF", false) == 0)
											{
												aircraft.SBR_TerrainFollowing = Conversions.ToBoolean(xmlNode9.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 3736393060u)
									{
										if (num2 <= 3533666526u)
										{
											if (num2 != 3389022305u)
											{
												if (num2 == 3533666526u && Operators.CompareString(name2, "Navigator", false) == 0)
												{
													goto IL_1DA5;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBED", false) == 0)
												{
													aircraft.SBEngagedDefensive = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 3559367371u)
										{
											if (num2 != 3636905136u)
											{
												if (num2 == 3736393060u && Operators.CompareString(name2, "ParentGroup", false) == 0)
												{
													aircraft.ParentGroupName = xmlNode9.InnerText;
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Weaponry", false) == 0)
												{
													goto IL_19D6;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "SBEO_ThrottleSetting", false) != 0)
											{
												continue;
											}
											string innerText3 = xmlNode9.InnerText;
											if (Operators.CompareString(innerText3, "FullStop", false) == 0)
											{
												aircraft.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.FullStop;
												continue;
											}
											if (Operators.CompareString(innerText3, "Loiter", false) == 0)
											{
												aircraft.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Loiter;
												continue;
											}
											if (Operators.CompareString(innerText3, "Cruise", false) == 0)
											{
												aircraft.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Cruise;
												continue;
											}
											if (Operators.CompareString(innerText3, "Full", false) == 0)
											{
												aircraft.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Full;
												continue;
											}
											if (Operators.CompareString(innerText3, "Flank", false) != 0)
											{
												aircraft.SBEngagedOffensive_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode9.InnerText);
												continue;
											}
											aircraft.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Flank;
											continue;
										}
									}
									else if (num2 <= 3792306253u)
									{
										if (num2 != 3766013955u)
										{
											if (num2 == 3792306253u && Operators.CompareString(name2, "Longitude_UnitEntersAreaCheck", false) == 0)
											{
												aircraft.SetLongitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode9.InnerText)));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "Loadout", false) == 0)
											{
												if (bool_32)
												{
													aircraft.SetLoadout(Loadout.Load(xmlNode9.ChildNodes[0], dictionary_0, ref aircraft, ref scenario_1));
													bool bool_33 = false;
													if (!Information.IsNothing(aircraft.GetLoadout()) && aircraft.GetLoadout().NOW)
													{
														bool_33 = true;
													}
													aircraft.SetLoadout(null);
													int int_ = Conversions.ToInteger(Misc.smethod_48(xmlNode9.ChildNodes[0].ChildNodes, "DBID").InnerText);
													DBFunctions.smethod_48(ref aircraft, int_, bool_33);
												}
												else
												{
													aircraft.SetLoadout(Loadout.Load(xmlNode9.ChildNodes[0], dictionary_0, ref aircraft, ref scenario_1));
												}
												aircraft.GetAircraftKinematics().SetBingoJokerFuel();
												continue;
											}
											continue;
										}
									}
									else if (num2 != 3956256525u)
									{
										if (num2 != 4080539297u)
										{
											if (num2 == 4152621540u && Operators.CompareString(name2, "CurrentHeading", false) == 0)
											{
												goto IL_1215;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "IsAutoDetectable", false) == 0)
											{
												goto IL_1618;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "AbnTime", false) == 0)
										{
											goto IL_12E6;
										}
										continue;
									}
									aircraft.Latitude = XmlConvert.ToDouble(xmlNode9.InnerText.Replace(",", "."));
									continue;
									IL_1215:
									aircraft.SetCurrentHeading(XmlConvert.ToSingle(xmlNode9.InnerText));
									continue;
								}
								if (num2 <= 771216480u)
								{
									if (num2 <= 441941816u)
									{
										if (num2 > 266367750u)
										{
											if (num2 <= 334092753u)
											{
												if (num2 != 276801030u)
												{
													if (num2 != 334092753u)
													{
														continue;
													}
													if (Operators.CompareString(name2, "DTN", false) != 0)
													{
														continue;
													}
												}
												else
												{
													if (Operators.CompareString(name2, "AirborneTime", false) == 0)
													{
														goto IL_12E6;
													}
													continue;
												}
											}
											else if (num2 != 392185441u)
											{
												if (num2 != 429749699u)
												{
													if (num2 == 441941816u && Operators.CompareString(name2, "CurrentAltitude", false) == 0)
													{
														goto IL_1336;
													}
													continue;
												}
												else if (Operators.CompareString(name2, "DesiredTurnRate_Navigation", false) != 0)
												{
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "AirOps", false) == 0)
												{
													goto IL_138F;
												}
												continue;
											}
											aircraft.SetDesiredTurnRate_Navigation((Waypoint._TurnRate)Conversions.ToByte(xmlNode9.InnerText));
											continue;
										}
										if (num2 <= 93925113u)
										{
											if (num2 != 6222351u)
											{
												if (num2 != 93925113u)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Thr", false) != 0)
												{
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "Status", false) != 0)
												{
													continue;
												}
												if (Versioned.IsNumeric(xmlNode9.InnerText))
												{
													aircraft.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode9.InnerText));
												}
												else
												{
													aircraft.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode9.InnerText, true));
												}
												if (aircraft.GetUnitStatus() == (ActiveUnit._ActiveUnitStatus)9)
												{
													aircraft.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB);
												}
												if (aircraft.activeUnitStatus != ActiveUnit._ActiveUnitStatus.Refuelling && aircraft.activeUnitStatus != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
												{
													if (aircraft.activeUnitStatus == ActiveUnit._ActiveUnitStatus.EngagedDefensive)
													{
														if (aircraft.SBEngagedDefensive == ActiveUnit._ActiveUnitStatus.Unassigned)
														{
															aircraft.SBEngagedDefensive = ActiveUnit._ActiveUnitStatus.Unassigned;
															aircraft.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Cruise;
															aircraft.SBEngagedDefensive_Altitude = aircraft.GetCurrentAltitude_ASL(false);
															aircraft.SBEngagedDefensive_Altitude_TerrainFollowing = 0f;
															aircraft.SBEngagedDefensive_TerrainFollowing = false;
															continue;
														}
														continue;
													}
													else
													{
														if (aircraft.activeUnitStatus == ActiveUnit._ActiveUnitStatus.EngagedOffensive && aircraft.SBEngagedOffensive == ActiveUnit._ActiveUnitStatus.Unassigned)
														{
															aircraft.SBEngagedOffensive = ActiveUnit._ActiveUnitStatus.Unassigned;
															aircraft.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Cruise;
															aircraft.SBEngagedOffensive_Altitude = aircraft.GetCurrentAltitude_ASL(false);
															aircraft.SBEngagedOffensive_Altitude_TerrainFollowing = 0f;
															aircraft.SBEngagedOffensive_TerrainFollowing = false;
															continue;
														}
														continue;
													}
												}
												else
												{
													if (aircraft.SBR == ActiveUnit._ActiveUnitStatus.Unassigned)
													{
														aircraft.SBR = ActiveUnit._ActiveUnitStatus.Unassigned;
														aircraft.SBR_ThrottleSetting = ActiveUnit.Throttle.Cruise;
														aircraft.SBR_Altitude = aircraft.GetCurrentAltitude_ASL(false);
														aircraft.SBR_Altitude_TerrainFollowing = 0f;
														aircraft.SBR_TerrainFollowing = false;
														continue;
													}
													continue;
												}
											}
										}
										else if (num2 != 263373746u)
										{
											if (num2 == 266367750u && Operators.CompareString(name2, "Name", false) == 0)
											{
												aircraft.Name = xmlNode9.InnerText;
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "FSBR", false) == 0)
											{
												aircraft.FuelStateBR = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode9.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 575329799u)
									{
										if (num2 <= 485784328u)
										{
											if (num2 != 468031071u)
											{
												if (num2 == 485784328u && Operators.CompareString(name2, "IsAD", false) == 0)
												{
													goto IL_1618;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBED_Altitude_TF", false) == 0)
												{
													aircraft.SBEngagedDefensive_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 506380204u)
										{
											if (num2 != 525186425u)
											{
												if (num2 == 575329799u && Operators.CompareString(name2, "FlightRole", false) == 0)
												{
													aircraft.FlightRole = (Mission.Flight._FlightRole)Conversions.ToByte(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Aircraft_Sensory", false) == 0)
												{
													goto IL_16C7;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "LatLR", false) == 0)
											{
												aircraft.SetLatitudeLR(new double?(XmlConvert.ToDouble(xmlNode9.InnerText.Replace(",", "."))));
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 634280640u)
									{
										if (num2 != 601166687u)
										{
											if (num2 == 634280640u && Operators.CompareString(name2, "DS", false) == 0)
											{
												goto IL_1762;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "AI", false) == 0)
											{
												goto IL_178E;
											}
											continue;
										}
									}
									else if (num2 != 664498478u)
									{
										if (num2 != 751723973u)
										{
											if (num2 == 771216480u && Operators.CompareString(name2, "Damage", false) == 0)
											{
												goto IL_180F;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "DT", false) == 0)
											{
												goto IL_1840;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "FuelState", false) == 0)
										{
											aircraft.activeUnitFuelState = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode9.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (num2 <= 1255847155u)
									{
										if (num2 <= 892023141u)
										{
											if (num2 <= 803760973u)
											{
												if (num2 != 788394383u)
												{
													if (num2 != 803760973u || Operators.CompareString(name2, "DamagePts", false) != 0)
													{
														continue;
													}
													if (Conversions.ToInteger(xmlNode9.InnerText) > 50 || Conversions.ToInteger(xmlNode9.InnerText) > aircraft.GetInitialDP())
													{
														aircraft.SetDamagePts(false, (float)aircraft.GetInitialDP());
														continue;
													}
													if (Conversions.ToInteger(xmlNode9.InnerText) == 0)
													{
														aircraft.SetDamagePts(false, (float)aircraft.GetInitialDP());
														continue;
													}
													aircraft.SetDamagePts(false, XmlConvert.ToSingle(xmlNode9.InnerText));
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Kinematics", false) == 0)
													{
														goto IL_1974;
													}
													continue;
												}
											}
											else if (num2 != 827630232u)
											{
												if (num2 != 877330709u)
												{
													if (num2 != 892023141u)
													{
														continue;
													}
													if (Operators.CompareString(name2, "DesiredHeading", false) != 0)
													{
														continue;
													}
												}
												else
												{
													if (Operators.CompareString(name2, "Aircraft_Weaponry", false) == 0)
													{
														goto IL_19D6;
													}
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "SBED_Altitude", false) == 0)
												{
													aircraft.SBEngagedDefensive_Altitude = XmlConvert.ToSingle(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num2 <= 1087276353u)
										{
											if (num2 != 936277782u)
											{
												if (num2 != 1087276353u || Operators.CompareString(name2, "DH", false) != 0)
												{
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "DA", false) == 0)
												{
													goto IL_1A87;
												}
												continue;
											}
										}
										else if (num2 != 1143797280u)
										{
											if (num2 != 1156592502u)
											{
												if (num2 == 1255847155u && Operators.CompareString(name2, "ThrottleSetting", false) == 0)
												{
													goto IL_1AE0;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBR", false) == 0)
												{
													aircraft.SBR = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "SBR_Altitude_TF", false) == 0)
											{
												aircraft.SBR_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode9.InnerText);
												continue;
											}
											continue;
										}
										aircraft.SetDesiredHeading(ActiveUnit._TurnRate.const_0, XmlConvert.ToSingle(xmlNode9.InnerText));
										continue;
									}
									if (num2 <= 1476905714u)
									{
										if (num2 <= 1422437055u)
										{
											if (num2 != 1259548010u)
											{
												if (num2 == 1422437055u && Operators.CompareString(name2, "Doctrine", false) == 0)
												{
													aircraft.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode9, aircraft);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBED_ThrottleSetting", false) != 0)
												{
													continue;
												}
												string innerText4 = xmlNode9.InnerText;
												if (Operators.CompareString(innerText4, "FullStop", false) == 0)
												{
													aircraft.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.FullStop;
													continue;
												}
												if (Operators.CompareString(innerText4, "Loiter", false) == 0)
												{
													aircraft.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Loiter;
													continue;
												}
												if (Operators.CompareString(innerText4, "Cruise", false) == 0)
												{
													aircraft.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Cruise;
													continue;
												}
												if (Operators.CompareString(innerText4, "Full", false) == 0)
												{
													aircraft.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Full;
													continue;
												}
												if (Operators.CompareString(innerText4, "Flank", false) != 0)
												{
													aircraft.SBEngagedDefensive_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode9.InnerText);
													continue;
												}
												aircraft.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Flank;
												continue;
											}
										}
										else if (num2 != 1444793274u)
										{
											if (num2 != 1459814733u)
											{
												if (num2 == 1476905714u && Operators.CompareString(name2, "WeaponState", false) == 0)
												{
													aircraft.weaponState = (ActiveUnit._ActiveUnitWeaponState)Conversions.ToByte(xmlNode9.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Aircraft_Navigator", false) == 0)
												{
													goto IL_1DA5;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "Prof", false) == 0)
											{
												aircraft.SetProficiencyLevel(new GlobalVariables.ProficiencyLevel?((GlobalVariables.ProficiencyLevel)Conversions.ToInteger(xmlNode9.InnerText)));
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 1614652377u)
									{
										if (num2 != 1488303767u)
										{
											if (num2 == 1614652377u && Operators.CompareString(name2, "CommStuff", false) == 0)
											{
												goto IL_1E2E;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SBEO_TF", false) == 0)
											{
												aircraft.SBEngagedOffensive_TerrainFollowing = Conversions.ToBoolean(xmlNode9.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 != 1708783731u)
									{
										if (num2 != 1729717486u)
										{
											if (num2 == 1738278884u && Operators.CompareString(name2, "SBED_TF", false) == 0)
											{
												aircraft.SBEngagedDefensive_TerrainFollowing = Conversions.ToBoolean(xmlNode9.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "Longitude", false) == 0)
											{
												goto IL_1ED8;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "CS", false) == 0)
										{
											goto IL_1F0D;
										}
										continue;
									}
								}
								IL_1AE0:
								string innerText5 = xmlNode9.InnerText;
								if (Operators.CompareString(innerText5, "FullStop", false) != 0)
								{
									if (Operators.CompareString(innerText5, "Loiter", false) != 0)
									{
										if (Operators.CompareString(innerText5, "Cruise", false) != 0)
										{
											if (Operators.CompareString(innerText5, "Full", false) != 0)
											{
												if (Operators.CompareString(innerText5, "Flank", false) != 0)
												{
													aircraft.currentThrottle = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode9.InnerText);
												}
												else
												{
													aircraft.currentThrottle = ActiveUnit.Throttle.Flank;
												}
											}
											else
											{
												aircraft.currentThrottle = ActiveUnit.Throttle.Full;
											}
										}
										else
										{
											aircraft.currentThrottle = ActiveUnit.Throttle.Cruise;
										}
									}
									else
									{
										aircraft.currentThrottle = ActiveUnit.Throttle.Loiter;
									}
								}
								else
								{
									aircraft.currentThrottle = ActiveUnit.Throttle.FullStop;
								}
								if (aircraft.currentThrottle == ActiveUnit.Throttle.FullStop && !aircraft.IsRotaryWing(false))
								{
									aircraft.currentThrottle = ActiveUnit.Throttle.Cruise;
									continue;
								}
								continue;
								IL_12E6:
								aircraft.AbnTime = XmlConvert.ToSingle(xmlNode9.InnerText);
								continue;
								IL_1336:
								aircraft.SetAltitude_ASL(true, XmlConvert.ToSingle(xmlNode9.InnerText));
								continue;
								IL_138F:
								Aircraft aircraft4 = aircraft;
								ActiveUnit activeUnit = aircraft;
								aircraft4.aircraft_AirOps = Aircraft_AirOps.smethod_5(ref xmlNode9, ref dictionary_0, ref activeUnit);
								continue;
								IL_1618:
								aircraft.SetIsAutoDetectable(null, Conversions.ToBoolean(xmlNode9.InnerText));
								continue;
								IL_16C7:
								Aircraft aircraft5 = aircraft;
								activeUnit = aircraft;
								aircraft5.aircraft_Sensory = Aircraft_Sensory.Load(ref xmlNode9, ref dictionary_0, ref activeUnit);
								continue;
								IL_1762:
								aircraft.SetDesiredSpeed(XmlConvert.ToSingle(xmlNode9.InnerText));
								continue;
								IL_178E:
								Aircraft aircraft6 = aircraft;
								activeUnit = aircraft;
								aircraft6.aircraft_AI = Aircraft_AI.Load(ref xmlNode9, ref dictionary_0, ref activeUnit);
								if (aircraft.IsTerrainFollowing(aircraft) && aircraft.GetDesiredAltitude_TerrainFollowing() == 0f)
								{
									aircraft.SetDesiredAltitude_TerrainFollowing(60.96f);
									continue;
								}
								continue;
								IL_180F:
								Aircraft aircraft7 = aircraft;
								activeUnit = aircraft;
								aircraft7.aircraft_Damage = Aircraft_Damage.Load(ref xmlNode9, ref dictionary_0, ref activeUnit);
								continue;
								IL_1840:
								aircraft.SetDesiredTurnRate((ActiveUnit._TurnRate)Conversions.ToByte(xmlNode9.InnerText));
								continue;
								IL_1974:
								ActiveUnit_Kinematics.Load(xmlNode9, dictionary_0, aircraft);
								continue;
								IL_19D6:
								Aircraft aircraft8 = aircraft;
								activeUnit = aircraft;
								aircraft8.aircraft_Weaponry = Aircraft_Weaponry.smethod_4(ref xmlNode9, ref dictionary_0, ref activeUnit);
								continue;
								IL_1A87:
								aircraft.SetDesiredAltitude(XmlConvert.ToSingle(xmlNode9.InnerText));
								continue;
								IL_1DA5:
								Aircraft aircraft9 = aircraft;
								activeUnit = aircraft;
								aircraft9.aircraft_Navigator = Aircraft_Navigator.Load(ref xmlNode9, ref dictionary_0, ref activeUnit);
								continue;
								IL_1E2E:
								Aircraft aircraft10 = aircraft;
								activeUnit = aircraft;
								aircraft10.aircraft_CommStuff = Aircraft_CommStuff.Load(ref xmlNode9, ref dictionary_0, ref activeUnit);
								continue;
								IL_1ED8:
								aircraft.Longitude = XmlConvert.ToDouble(xmlNode9.InnerText.Replace(",", "."));
								continue;
								IL_1F0D:
								aircraft.SetCurrentSpeed(XmlConvert.ToSingle(xmlNode9.InnerText));
							}
						}
						finally
						{
							if (enumerator10 is IDisposable)
							{
								(enumerator10 as IDisposable).Dispose();
							}
						}
						float maxAltitude = aircraft.GetAircraftKinematics().GetMaxAltitude();
						if (aircraft.GetCurrentAltitude_ASL(false) > maxAltitude)
						{
							aircraft.SetAltitude_ASL(false, maxAltitude);
						}
						if (aircraft.GetDesiredAltitude() > maxAltitude)
						{
							aircraft.SetDesiredAltitude(maxAltitude);
						}
						checked
						{
							if (!bool_32 && array.Length > 0)
							{
								try
								{
									Sensor[] array2 = array;
									for (int j = 0; j < array2.Length; j++)
									{
										Sensor sensor2 = array2[j];
										Sensor[] noneMCMSensors = aircraft.GetNoneMCMSensors();
										for (int k = 0; k < noneMCMSensors.Length; k++)
										{
											Sensor sensor3 = noneMCMSensors[k];
											if (sensor3.DBID == sensor2.DBID && sensor2.IsEmmitting())
											{
												sensor3.TurnOn();
											}
										}
									}
								}
								catch (Exception ex3)
								{
									ProjectData.SetProjectError(ex3);
									Exception ex4 = ex3;
									ex4.Data.Add("Error at 200019", ex4.Message);
									GameGeneral.LogException(ref ex4);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
								}
							}
							aircraft2 = aircraft;
						}
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ex6.Data.Add("Error at 100350", "");
				GameGeneral.LogException(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = aircraft2;
			return result;
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x00190AC0 File Offset: 0x0018ECC0
		public override float GetArea()
		{
			return this.Length * this.Span;
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x0000945D File Offset: 0x0000765D
		public override GlobalVariables.ActiveUnitType GetUnitType()
		{
			return GlobalVariables.ActiveUnitType.Aircraft;
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x00190ADC File Offset: 0x0018ECDC
		public override bool IsMineSweeper()
		{
			bool result;
			if (!Information.IsNothing(this.GetLoadout()))
			{
				result = (this.GetLoadout().loadoutRole == Loadout.LoadoutRole.MineSweeping);
			}
			else
			{
				result = (this.Type == Aircraft._AircraftType.MCM);
			}
			return result;
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x00021E31 File Offset: 0x00020031
		public override bool HasNavalMineLayingLoadout()
		{
			return !Information.IsNothing(this.GetLoadout()) && this.GetLoadout().loadoutRole == Loadout.LoadoutRole.NavalMineLaying;
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x00190B1C File Offset: 0x0018ED1C
		public override bool IsMoving()
		{
			bool flag;
			bool result;
			if (this.IsOperating())
			{
				flag = true;
			}
			else
			{
				Aircraft_AirOps._AirOpsCondition airOpsCondition = this.GetAircraftAirOps().GetAirOpsCondition();
				if (airOpsCondition != Aircraft_AirOps._AirOpsCondition.Parked && airOpsCondition != Aircraft_AirOps._AirOpsCondition.Readying)
				{
					result = true;
					return result;
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x00021E55 File Offset: 0x00020055
		public override bool vmethod_119()
		{
			return !this.IsOperating() && !Information.IsNothing(this.GetAircraftAirOps().GetHostAirFacility()) && this.GetAircraftAirOps().GetHostAirFacility().method_35();
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x000081A2 File Offset: 0x000063A2
		public override int GetMaxMineRange()
		{
			return 0;
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x000081A2 File Offset: 0x000063A2
		public override int GetMaxMineRange(Weapon._WeaponType _WeaponType_0)
		{
			return 0;
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x00190B60 File Offset: 0x0018ED60
		public override void vmethod_113(ref Scenario scenario_1, Dictionary<string, Subject> dictionary_0, bool bool_32)
		{
			try
			{
				base.vmethod_113(ref scenario_1, dictionary_0, bool_32);
				if (this.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Parked && Information.IsNothing(this.GetAircraftAirOps().GetCurrentHostUnit()) && Information.IsNothing(this.GetAircraftAirOps().GetHostAirFacility()))
				{
					ScenarioArrayUtil.RemoveActiveUnit(ref this.GetSide(false).ActiveUnitArray, this);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100351", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x00190C10 File Offset: 0x0018EE10
		public override ActiveUnit._ActiveUnitStatus GetUnitStatus()
		{
			return base.GetUnitStatus();
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x00190C28 File Offset: 0x0018EE28
		public override void SetUnitStatus(ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_5)
		{
			try
			{
				if (_ActiveUnitStatus_5 != this.GetUnitStatus() && _ActiveUnitStatus_5 == ActiveUnit._ActiveUnitStatus.RTB && (this.GetFuelState() == ActiveUnit._ActiveUnitFuelState.IsBingo || this.GetFuelState() == ActiveUnit._ActiveUnitFuelState.IsJoker) && this.aircraft_AirOps.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.OffloadingFuel)
				{
					List<KeyValuePair<string, Aircraft_AirOps._RefuellingConnection>> list = new List<KeyValuePair<string, Aircraft_AirOps._RefuellingConnection>>();
					list.AddRange(this.aircraft_AirOps.GetA2ARCDictionary());
					foreach (KeyValuePair<string, Aircraft_AirOps._RefuellingConnection> current in list)
					{
						if (this.m_Scenario.GetActiveUnits().ContainsKey(current.Key))
						{
							((Aircraft)this.m_Scenario.GetActiveUnits()[current.Key]).aircraft_AirOps.A2ARefueling();
						}
						else
						{
							ConcurrentDictionary<string, Aircraft_AirOps._RefuellingConnection> a2ARCDictionary = this.aircraft_AirOps.GetA2ARCDictionary();
							string key = current.Key;
							Aircraft_AirOps._RefuellingConnection refuellingConnection = Aircraft_AirOps._RefuellingConnection.Probe;
							a2ARCDictionary.TryRemove(key, out refuellingConnection);
						}
					}
					List<string> list2 = new List<string>();
					list2.AddRange(this.aircraft_AirOps.GetRefuellingQueue());
                    string current2X;

                    foreach (string current2 in list2)
					{
                        current2X = current2;
                        this.aircraft_AirOps.GetRefuellingQueue().TryTake(out current2X);
					}
				}
				base.SetUnitStatus(_ActiveUnitStatus_5);
				if (_ActiveUnitStatus_5 == ActiveUnit._ActiveUnitStatus.Refuelling)
				{
					this.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Refuelling);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100352", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x00190E1C File Offset: 0x0018F01C
		public bool HasBuddyStoreWeapon()
		{
			checked
			{
				bool flag;
				bool result;
				if (Information.IsNothing(this.GetLoadout()))
				{
					flag = false;
				}
				else
				{
					WeaponRec[] weaponRecArray = this.GetLoadout().WeaponRecArray;
					for (int i = 0; i < weaponRecArray.Length; i++)
					{
						if (weaponRecArray[i].GetWeapon(this.m_Scenario).GetWeaponType() == Weapon._WeaponType.BuddyStore)
						{
							result = true;
							return result;
						}
					}
					flag = false;
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x00190E88 File Offset: 0x0018F088
		public override bool CanRefuelOrUNREP(ActiveUnit targetAircraft_)
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (!targetAircraft_.IsAircraft)
					{
						flag = false;
					}
					else
					{
						Aircraft aircraft = (Aircraft)targetAircraft_;
						if (this.CenterlineBoom && aircraft.BoomRefuelling)
						{
							flag = true;
						}
						else if ((this.CenterlineDrogue || this.WingDrogue) && aircraft.ProbeRefuelling)
						{
							flag = true;
						}
						else
						{
							if (aircraft.ProbeRefuelling && !Information.IsNothing(this.GetLoadout()))
							{
								WeaponRec[] weaponRecArray = this.GetLoadout().WeaponRecArray;
								for (int i = 0; i < weaponRecArray.Length; i++)
								{
									if (weaponRecArray[i].GetWeapon(this.m_Scenario).GetWeaponType() == Weapon._WeaponType.BuddyStore)
									{
										flag = true;
										result = true;
										return result;
									}
								}
							}
							flag = false;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100353", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x00190FA4 File Offset: 0x0018F1A4
		public override bool HasEnoughFuelLeftAboardToServe(ActiveUnit Receiver_, Aircraft_AirOps aircraft_AirOps_, float ratio_, bool bInRefuellingQueue_)
		{
			bool result = false;
			try
			{
				FuelRec[] fuelRecs = this.GetFuelRecs();
				int num = 0;
				int num2;
				ActiveUnit assignedHostUnit;
				checked
				{
					for (int i = 0; i < fuelRecs.Length; i++)
					{
						FuelRec fuelRec = fuelRecs[i];
						num = unchecked((int)Math.Round((double)((float)num + fuelRec.CurrentQuantity)));
					}
					num2 = 0;
					assignedHostUnit = this.GetAircraftAirOps().GetAssignedHostUnit();
				}
				if (!Information.IsNothing(assignedHostUnit))
				{
					float horizontalRange = base.GetHorizontalRange(assignedHostUnit);
					Aircraft_Navigator aircraftNavigator = this.GetAircraftNavigator();
					bool flag = false;
					float transitAltitude = aircraftNavigator.GetTransitAltitude(ref flag);
					float value = (float)this.GetAircraftKinematics().GetSpeed(transitAltitude, ActiveUnit.Throttle.Cruise);
					num2 = (int)Math.Round((double)this.GetAircraftKinematics().method_6(horizontalRange, ActiveUnit.Throttle.Cruise, transitAltitude, new float?(value), false, false));
				}
				result = ((float)(num - num2 - (int)Math.Round((double)this.GetAircraftKinematics().GetReserveFuel()) - aircraft_AirOps_.method_25(Receiver_, bInRefuellingQueue_)) >= (float)Receiver_.GetFuelRecsMaxQuantity() * ratio_);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100354", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060043FA RID: 17402 RVA: 0x00021E84 File Offset: 0x00020084
		public bool IsAirship()
		{
			return this.Category == Aircraft._AircraftCategory.Airship;
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x00021E93 File Offset: 0x00020093
		public bool IsAirRefuelingCapable()
		{
			return this.Type == Aircraft._AircraftType.Tanker || (!Information.IsNothing(this.GetLoadout()) && this.GetLoadout().loadoutRole == Loadout.LoadoutRole.AirRefueling);
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x001910E4 File Offset: 0x0018F2E4
		public Aircraft_AirOps._Maintenance GetMaintenanceLevel(ref string string_9)
		{
			Aircraft_AirOps._Maintenance result;
			if (!Information.IsNothing(this.GetLoadout()))
			{
				if (this.GetLoadout().loadoutRole == Loadout.LoadoutRole.Unavailable)
				{
					result = Aircraft_AirOps._Maintenance.Unavailable;
				}
				else if (this.GetLoadout().loadoutRole == Loadout.LoadoutRole.Reserve)
				{
					result = Aircraft_AirOps._Maintenance.ReserveLoadout;
				}
				else
				{
					ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState = this.GetAircraftWeaponry().vmethod_3();
					if (activeUnitWeaponState != ActiveUnit._ActiveUnitWeaponState.None && activeUnitWeaponState != ActiveUnit._ActiveUnitWeaponState.IgnoreWinchesterAndShotgun)
					{
						result = Aircraft_AirOps._Maintenance.const_1;
					}
					else
					{
						result = Aircraft_AirOps._Maintenance.const_0;
					}
				}
			}
			else
			{
				result = Aircraft_AirOps._Maintenance.const_4;
			}
			return result;
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x0019115C File Offset: 0x0018F35C
		public string GetQuickTurnAroundInfo()
		{
			string text;
			string result;
			if (!Information.IsNothing(this.GetLoadout()))
			{
				if (this.GetLoadout().QuickTurnaround)
				{
					Doctrine._QuickTurnAround? quickTurnAroundDoctrine = this.m_Doctrine.GetQuickTurnAroundDoctrine(this.m_Scenario, false, false, false, false);
					byte? b = quickTurnAroundDoctrine.HasValue ? new byte?((byte)quickTurnAroundDoctrine.GetValueOrDefault()) : null;
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
					{
						text = "不允许(条令设置)";
					}
					else
					{
						quickTurnAroundDoctrine = this.m_Doctrine.GetQuickTurnAroundDoctrine(this.m_Scenario, false, false, false, false);
						b = (quickTurnAroundDoctrine.HasValue ? new byte?((byte)quickTurnAroundDoctrine.GetValueOrDefault()) : null);
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							Loadout loadout = this.GetLoadout();
							if (!loadout.method_13() && !loadout.method_15() && !loadout.LoadoutRoleIsASWPatrol())
							{
								text = "不允许(条令设置)";
								result = text;
								return result;
							}
						}
						Aircraft_AirOps aircraftAirOps = this.GetAircraftAirOps();
						if (aircraftAirOps.QuickTurnaround_Enabled)
						{
							text = string.Concat(new string[]
							{
								"支持, ",
								Misc.GetLoadoutDayNightString(this.GetLoadout().QT_TimeofDay),
								": ",
								Conversions.ToString(aircraftAirOps.QuickTurnaround_SortiesFlown),
								" / ",
								Conversions.ToString(aircraftAirOps.QuickTurnaround_SortiesTotal),
								"波次, ",
								Misc.GetTimeString((long)Math.Round((double)aircraftAirOps.QuickTurnaround_AirborneTime_Flown), Aircraft_AirOps._Maintenance.const_0, false, true),
								" / ",
								Misc.GetTimeString((long)(this.GetLoadout().QT_AirborneTime * 60), Aircraft_AirOps._Maintenance.const_0, true, false),
								"飞行时间, ",
								Misc.GetTimeString((long)(aircraftAirOps.QuickTurnaround_TimePentalty * 60), Aircraft_AirOps._Maintenance.const_0, true, false),
								"维修时间"
							});
						}
						else
						{
							text = "-";
						}
					}
				}
				else
				{
					text = "-";
				}
			}
			else
			{
				text = "-";
			}
			result = text;
			return result;
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x001913AC File Offset: 0x0018F5AC
		public override float GetDesiredAltitude()
		{
			return base.GetDesiredAltitude();
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x00021EC7 File Offset: 0x000200C7
		public override void SetDesiredAltitude(float float_29)
		{
			if (float_29 < 6.09599972f)
			{
				float_29 = 6.09599972f;
			}
			base.SetDesiredAltitude(float_29);
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x001913C4 File Offset: 0x0018F5C4
		public override double GetLongitude(bool? _HintIsOperating = null)
		{
			bool flag;
			if (_HintIsOperating.HasValue)
			{
				flag = _HintIsOperating.Value;
			}
			else
			{
				flag = this.IsOperating();
			}
			double result;
			if (flag)
			{
				result = this.Longitude;
			}
			else
			{
				ActiveUnit currentHostUnit = this.GetAircraftAirOps().GetCurrentHostUnit();
				if (Information.IsNothing(currentHostUnit))
				{
					result = 0.0;
				}
				else
				{
					result = currentHostUnit.GetLongitude(null);
				}
			}
			return result;
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x00021EE4 File Offset: 0x000200E4
		public override void SetLongitude(bool? _HintIsOperating, double value)
		{
			this.Longitude = value;
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x00191444 File Offset: 0x0018F644
		public override CommDevice[] GetCommDevices()
		{
			CommDevice[] result = null;
			try
			{
				if (Information.IsNothing(this.GetLoadout()))
				{
					result = this.m_CommDevices;
				}
				else
				{
					CommDevice[] array = new CommDevice[this.m_CommDevices.Length - 1 + 1];
					Array.Copy(this.m_CommDevices, array, this.m_CommDevices.Length);
					int num = this.GetLoadout().WeaponRecArray.Count<WeaponRec>() - 1;
					for (int i = 0; i <= num; i++)
					{
						WeaponRec weaponRec = this.GetLoadout().WeaponRecArray[i];
						if (weaponRec.GetWeapon(this.m_Scenario).GetWeaponType() == Weapon._WeaponType.SensorPod)
						{
							int num2 = weaponRec.GetWeapon(this.m_Scenario).GetCommDevices().Length - 1;
							for (int j = 0; j <= num2; j++)
							{
								CommDevice commDevice_ = weaponRec.GetWeapon(this.m_Scenario).GetCommDevices()[j];
								ScenarioArrayUtil.AddCommDevice(ref array, commDevice_);
							}
						}
					}
					result = array;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100355", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x00191590 File Offset: 0x0018F790
		public override ActiveUnit.Throttle GetMaxThrottleAvailable()
		{
			ActiveUnit.Throttle result;
			if (this.HasFlankAltBand())
			{
				result = ActiveUnit.Throttle.Flank;
			}
			else
			{
				result = ActiveUnit.Throttle.Full;
			}
			return result;
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x001915B4 File Offset: 0x0018F7B4
		public override GlobalVariables.TargetVisualSizeClass GetTargetVisualSizeClass()
		{
			float length = this.Length;
			GlobalVariables.TargetVisualSizeClass result;
			if (length > 40f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VLarge;
			}
			else if (length > 30f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Large;
			}
			else if (length > 25f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Medium;
			}
			else if (length > 10f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Small;
			}
			else if (length > 5f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VSmall;
			}
			else
			{
				result = GlobalVariables.TargetVisualSizeClass.Stealthy;
			}
			return result;
		}

		// Token: 0x06004405 RID: 17413 RVA: 0x00191624 File Offset: 0x0018F824
		public bool IsRotaryWing(bool value)
		{
			Aircraft._AircraftCategory category = this.Category;
			return category == Aircraft._AircraftCategory.Helicopter || category == Aircraft._AircraftCategory.Tiltrotor || (value && this.RunwayLengthCode == GlobalVariables._RunwayLengthCode.TOD_LAD_0m_VTOL);
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x00191660 File Offset: 0x0018F860
		public override float GetRoll()
		{
			float angleBetween = Class263.GetAngleBetween(this.GetCurrentHeading(), this.GetDesiredHeading(ActiveUnit._TurnRate.const_0));
			bool expression;
			if (base.GetAltitude_AGL() < 500f)
			{
				expression = false;
			}
			else
			{
				ActiveUnit._ActiveUnitStatus unitStatus = this.GetUnitStatus();
				expression = (unitStatus - ActiveUnit._ActiveUnitStatus.EngagedOffensive <= 1);
			}
			float num = 85f;
			float result;
			if ((int)Math.Round((double)angleBetween) == 0)
			{
				result = 0f;
			}
			else if (angleBetween > 0f && angleBetween <= 40f)
			{
				result = 2f * angleBetween;
			}
			else if (angleBetween > 40f && angleBetween <= 180f)
			{
				result = Conversions.ToSingle(Interaction.IIf(expression, 90, num));
			}
			else if (angleBetween > 180f && angleBetween <= 320f)
			{
				result = Conversions.ToSingle(Interaction.IIf(expression, -90, -num));
			}
			else
			{
				result = -2f * (360f - angleBetween);
			}
			return result;
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x00021EED File Offset: 0x000200ED
		public override void SetRoll(float value)
		{
			base.SetRoll(value);
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x0019176C File Offset: 0x0018F96C
		public override float GetPitch()
		{
			float num = this.GetCurrentAltitude_ASL(false) - base.GetPreviousAltitude_ASL();
			float result;
			if (num == 0f)
			{
				result = 0f;
			}
			else
			{
				double x = (double)this.GetCurrentSpeed() * 0.514444 * (double)this.m_Scenario.GetTimeStep();
				double num2 = Math.Atan2((double)Math.Abs(num), x) * 57.2957795130823;
				if (num > 0f)
				{
					result = (float)num2;
				}
				else
				{
					result = -(float)num2;
				}
			}
			return result;
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x00021EF6 File Offset: 0x000200F6
		public override void SetPitch(float value)
		{
			base.SetPitch(value);
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x001917F8 File Offset: 0x0018F9F8
		public override float GetCurrentSpeed()
		{
			return base.GetCurrentSpeed();
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x00021EFF File Offset: 0x000200FF
		public override void SetCurrentSpeed(float value)
		{
			base.SetCurrentSpeed(value);
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x00191810 File Offset: 0x0018FA10
		public override float GetCurrentAltitude_ASL(bool DoSanityCheck = false)
		{
			float result;
			if (!this.IsOperating())
			{
				if (!Information.IsNothing(this.GetAircraftAirOps().GetCurrentHostUnit()))
				{
					result = this.GetAircraftAirOps().GetCurrentHostUnit().GetCurrentAltitude_ASL(false);
				}
				else
				{
					result = (float)Terrain.GetElevation(this.GetLatitude(null), this.GetLongitude(null), false);
				}
			}
			else
			{
				result = base.GetCurrentAltitude_ASL(false);
			}
			return result;
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x00191884 File Offset: 0x0018FA84
		public override void SetAltitude_ASL(bool DoSanityCheck, float value)
		{
			checked
			{
				try
				{
					if (DoSanityCheck && value < 6.09599972f)
					{
						value = 6.09599972f;
					}
					base.SetAltitude_ASL(DoSanityCheck, value);
					if (!Information.IsNothing(this.GetLoadout()))
					{
						WeaponRec[] weaponRecArray = this.GetLoadout().WeaponRecArray;
						for (int i = 0; i < weaponRecArray.Length; i++)
						{
							weaponRecArray[i].GetWeapon(this.m_Scenario).SetAltitude_ASL(false, value);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101196", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00191940 File Offset: 0x0018FB40
		public override long GetTimeToBurnOut(ActiveUnit.Throttle throttle_, AltBand altBand_, float? Speed_, float? Altitude_ASL_)
		{
			long result = 0L;
			try
			{
				if (this.Type == Aircraft._AircraftType.Aerostat)
				{
					result = 9223372036854775807L;
				}
				else
				{
					FuelRec[] fuelRecs = this.GetFuelRecs();
					float num = 0f;
					for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
					{
						FuelRec fuelRec = fuelRecs[i];
						num += fuelRec.CurrentQuantity;
					}
					if (throttle_ == ActiveUnit.Throttle.FullStop)
					{
						result = 2147483647L;
					}
					else
					{
						float fuelConsumption = this.GetFuelConsumption(throttle_, altBand_, Speed_, Altitude_ASL_, false, false, false, false);
						if (fuelConsumption == 0f)
						{
							result = 9223372036854775807L;
						}
						else
						{
							result = (long)Math.Round((double)(num / fuelConsumption));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100356", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 2147483647L;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x00191A50 File Offset: 0x0018FC50
		public override void SetThrottle(ActiveUnit.Throttle theThrottleSetting, float? SpecificDesiredSpeed = null)
		{
			try
			{
				if (theThrottleSetting == ActiveUnit.Throttle.Flank && !this.HasFlankAltBand())
				{
					theThrottleSetting = ActiveUnit.Throttle.Full;
				}
				if (!this.IsRotaryWingAircraft() && theThrottleSetting == ActiveUnit.Throttle.FullStop)
				{
					theThrottleSetting = ActiveUnit.Throttle.Loiter;
				}
				base.SetThrottle(theThrottleSetting, SpecificDesiredSpeed);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100357", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x00191ADC File Offset: 0x0018FCDC
		private bool HasFlankAltBand()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					AltBand[] altBands = this.GetEngines()[0].altBands;
					for (int i = 0; i < altBands.Length; i++)
					{
						AltBand altBand = altBands[i];
						if (altBand.Consumption_Flank.HasValue && altBand.Speed_Flank.HasValue)
						{
							flag = true;
							result = true;
							return result;
						}
					}
					flag = false;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100358", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x00191B94 File Offset: 0x0018FD94
		public bool IsOnRTBOrFerry()
		{
			bool result = false;
			ActiveUnit._ActiveUnitStatus unitStatus = this.GetUnitStatus();
			if (unitStatus <= ActiveUnit._ActiveUnitStatus.RTB_Manual)
			{
				if (unitStatus == ActiveUnit._ActiveUnitStatus.RTB || unitStatus == ActiveUnit._ActiveUnitStatus.RTB_Manual)
				{
					result = true;
				}
			}
			else
			{
				if (unitStatus == ActiveUnit._ActiveUnitStatus.OnFerryMission)
				{
					result = true;
				}
				if (unitStatus == ActiveUnit._ActiveUnitStatus.RTB_Group)
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x00191BE0 File Offset: 0x0018FDE0
		public override ActiveUnit._ActiveUnitFuelState GetActiveUnitFuelState(ActiveUnit A2ARefuelingDestinationAircraft_, GeoPoint geoPoint_)
		{
			ActiveUnit._ActiveUnitFuelState activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.None;
			ActiveUnit._ActiveUnitFuelState result;
			try
			{
				if (this.GetFuelRecs().Count<FuelRec>() == 0)
				{
					activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.IsBingo;
				}
				else if (this.GetTimeToBurnOut(ActiveUnit.Throttle.Cruise, null, null, null) <= 900L)
				{
					activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.IsBingo;
				}
				else
				{
					int num = (int)Math.Round(Math.Min(2000.0, (double)this.GetFuelRecs()[0].MaxQuantity * 0.05));
					if (this.GetFuelRecs()[0].CurrentQuantity < (float)num)
					{
						activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.IsBingo;
					}
					else
					{
						if (Information.IsNothing(geoPoint_))
						{
							float num2;
							if (A2ARefuelingDestinationAircraft_.HasRunwaysOrLandingPads())
							{
								if (!this.IsRotaryWingAircraft())
								{
									GeoPoint geoPoint = A2ARefuelingDestinationAircraft_.GetAirOps().method_5();
									float distance = Math2.GetDistance(this.GetLatitude(null), this.GetLongitude(null), geoPoint.GetLatitude(), geoPoint.GetLongitude());
									float distance2 = Math2.GetDistance(A2ARefuelingDestinationAircraft_.GetLatitude(null), A2ARefuelingDestinationAircraft_.GetLongitude(null), geoPoint.GetLatitude(), geoPoint.GetLongitude());
									if (float.IsNaN(distance) || float.IsNaN(distance2))
									{
										activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.None;
										result = ActiveUnit._ActiveUnitFuelState.None;
										return result;
									}
									num2 = distance + distance2;
								}
								else
								{
									num2 = base.GetHorizontalRange(A2ARefuelingDestinationAircraft_);
									if (float.IsNaN(num2))
									{
										activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.None;
										result = ActiveUnit._ActiveUnitFuelState.None;
										return result;
									}
								}
							}
							else
							{
								num2 = base.GetHorizontalRange(A2ARefuelingDestinationAircraft_);
								if (float.IsNaN(num2))
								{
									activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.None;
									result = ActiveUnit._ActiveUnitFuelState.None;
									return result;
								}
							}
							this.DistanceToA2ARefuelingDestinationAircraft = num2;
							this.A2ARefuelingDestinationAircraft = A2ARefuelingDestinationAircraft_;
						}
						else
						{
							float num3;
							if (A2ARefuelingDestinationAircraft_.HasRunwaysOrLandingPads())
							{
								if (!this.IsRotaryWingAircraft())
								{
									GeoPoint geoPoint2 = A2ARefuelingDestinationAircraft_.GetAirOps().method_5();
									float distance3 = Math2.GetDistance(geoPoint_.GetLatitude(), geoPoint_.GetLongitude(), geoPoint2.GetLatitude(), geoPoint2.GetLongitude());
									float distance4 = Math2.GetDistance(A2ARefuelingDestinationAircraft_.GetLatitude(null), A2ARefuelingDestinationAircraft_.GetLongitude(null), geoPoint2.GetLatitude(), geoPoint2.GetLongitude());
									if (float.IsNaN(distance3) || float.IsNaN(distance4))
									{
										activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.None;
										result = ActiveUnit._ActiveUnitFuelState.None;
										return result;
									}
									num3 = distance3 + distance4;
								}
								else
								{
									num3 = Math2.GetDistance(geoPoint_.GetLatitude(), geoPoint_.GetLongitude(), A2ARefuelingDestinationAircraft_.GetLatitude(null), A2ARefuelingDestinationAircraft_.GetLongitude(null));
									if (float.IsNaN(num3))
									{
										activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.None;
										result = ActiveUnit._ActiveUnitFuelState.None;
										return result;
									}
								}
							}
							else
							{
								num3 = A2ARefuelingDestinationAircraft_.HorizontalRangeTo(geoPoint_);
								if (float.IsNaN(num3))
								{
									activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.None;
									result = ActiveUnit._ActiveUnitFuelState.None;
									return result;
								}
							}
							float num4 = base.HorizontalRangeTo(geoPoint_);
							this.DistanceToA2ARefuelingDestinationAircraft = num4 + num3;
							this.A2ARefuelingDestinationAircraft = A2ARefuelingDestinationAircraft_;
						}
						Doctrine._FuelState? bingoJokerDoctrine = this.m_Doctrine.GetBingoJokerDoctrine(this.m_Scenario, false, true, false, false);
						double num5 = (double)this.GetAircraftKinematics().vmethod_25(bingoJokerDoctrine);
						if (this.GetThrottle() == ActiveUnit.Throttle.Flank)
						{
							num5 *= 0.9;
						}
						else if (A2ARefuelingDestinationAircraft_.IsAircraft)
						{
							if (((Aircraft)A2ARefuelingDestinationAircraft_).IsAirRefuelingCapable())
							{
								num5 *= 0.7;
							}
						}
						else if (!Information.IsNothing(this.GetLoadout()) && this.GetLoadout().loadoutRole == Loadout.LoadoutRole.AirRefueling)
						{
							num5 *= 0.9;
						}
						if (num5 >= (double)this.DistanceToA2ARefuelingDestinationAircraft)
						{
							if (this.GetFuelState() == ActiveUnit._ActiveUnitFuelState.IsBingo)
							{
								if (num5 * 0.9 >= (double)this.DistanceToA2ARefuelingDestinationAircraft)
								{
									activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.None;
								}
							}
							else
							{
								activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.None;
							}
						}
						else
						{
							byte? b = bingoJokerDoctrine.HasValue ? new byte?((byte)bingoJokerDoctrine.GetValueOrDefault()) : null;
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.IsBingo;
							}
							else if (this.FuelQuantityLeftToBingo <= 0f)
							{
								activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.IsBingo;
							}
							else
							{
								activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.IsJoker;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100359", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = activeUnitFuelState;
			return result;
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x00192074 File Offset: 0x00190274
		public override ActiveUnit._ActiveUnitFuelState GetFuelState(GeoPoint geoPoint_0)
		{
			ActiveUnit._ActiveUnitFuelState result = ActiveUnit._ActiveUnitFuelState.None;
			try
			{
				Aircraft aircraft = null;
				bool? flag = null;
				ActiveUnit assignedHostUnit = this.GetAircraftAirOps().GetAssignedHostUnit();
				if (Information.IsNothing(assignedHostUnit))
				{
					result = ActiveUnit._ActiveUnitFuelState.None;
				}
				else if (assignedHostUnit.IsNotActive())
				{
					result = ActiveUnit._ActiveUnitFuelState.None;
				}
				else
				{
					if (!Information.IsNothing(this.GetAssignedMission(false)))
					{
						Doctrine._UseRefuel? useRefuelDoctrine = this.m_Doctrine.GetUseRefuelDoctrine(this.m_Scenario, false, false, false, false);
						byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
						if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							flag = new bool?(false);
						}
						else
						{
							useRefuelDoctrine = this.m_Doctrine.GetUseRefuelDoctrine(this.m_Scenario, false, false, false, false);
							b = (useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null);
							if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault() && this.Type == Aircraft._AircraftType.Tanker)
							{
								flag = new bool?(false);
							}
						}
					}
					if (Information.IsNothing(flag) && this.IsRefuellingSupported())
					{
						bool flag2 = false;
						if (this.Type == Aircraft._AircraftType.Tanker && !Information.IsNothing(this.GetAssignedMission(false)))
						{
							Mission._MissionClass missionClass = this.GetAssignedMission(false).MissionClass;
							if (missionClass != Mission._MissionClass.Strike)
							{
								flag2 = true;
							}
						}
						if (!flag2)
						{
							Aircraft_AirOps aircraftAirOps = this.GetAircraftAirOps();
							bool flag3 = false;
							ActiveUnit activeUnit = null;
							List<Mission> missionList = null;
							string text = "";
							List<Aircraft> tankersForMe = aircraftAirOps.GetTankersForMe(ref flag3, ref activeUnit, true, missionList, ref text);
							if (tankersForMe.Count == 0)
							{
								flag = new bool?(false);
							}
							else if (!this.GetAircraftNavigator().method_21() && (!base.HasParentGroup() || Information.IsNothing(this.GetParentGroup(false).GetGroupLead()) || !this.GetParentGroup(false).GetGroupLead().GetNavigator().method_21()))
							{
								aircraft = tankersForMe.OrderBy(new Func<Aircraft, double>(this.GetAngularDistance)).ElementAtOrDefault(0);
								if ((double)base.GetHorizontalRange(aircraft) * 0.7 < (double)base.GetHorizontalRange(assignedHostUnit))
								{
									flag = new bool?(true);
								}
								else
								{
									flag = new bool?(false);
								}
							}
							else
							{
								double approxAngularDistanceInDegrees = base.GetApproxAngularDistanceInDegrees(assignedHostUnit);
								flag = new bool?(false);
								aircraft = tankersForMe[0];
								if (tankersForMe.Count == 1)
								{
									if (base.GetApproxAngularDistanceInDegrees(tankersForMe[0]) < approxAngularDistanceInDegrees)
									{
										flag = new bool?(true);
									}
								}
								else
								{
									double approxAngularDistanceInDegrees2 = base.GetApproxAngularDistanceInDegrees(tankersForMe[0]);
									if (approxAngularDistanceInDegrees2 < approxAngularDistanceInDegrees)
									{
										flag = new bool?(true);
									}
									foreach (Aircraft current in tankersForMe)
									{
										if (current != tankersForMe[0])
										{
											double approxAngularDistanceInDegrees3 = base.GetApproxAngularDistanceInDegrees(current);
											if (approxAngularDistanceInDegrees3 <= approxAngularDistanceInDegrees && approxAngularDistanceInDegrees3 < approxAngularDistanceInDegrees2)
											{
												aircraft = current;
												flag = new bool?(true);
											}
										}
									}
								}
							}
							if (this.IsOnRTBOrFerry())
							{
								flag = new bool?(false);
							}
						}
					}
					if (flag.GetValueOrDefault())
					{
						result = this.GetActiveUnitFuelState(aircraft, null);
					}
					else
					{
						ActiveUnit._ActiveUnitFuelState activeUnitFuelState = this.GetActiveUnitFuelState(assignedHostUnit, null);
						if (activeUnitFuelState == ActiveUnit._ActiveUnitFuelState.IsBingo || activeUnitFuelState == ActiveUnit._ActiveUnitFuelState.IsJoker)
						{
							Aircraft_AirOps aircraftAirOps2 = this.GetAircraftAirOps();
							if (!Information.IsNothing(aircraftAirOps2.GetA2ARefuelingDestinationAircraft()))
							{
								aircraftAirOps2.A2ARefueling();
							}
						}
						result = activeUnitFuelState;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200329", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x001924C8 File Offset: 0x001906C8
		public override double GetLatitude(bool? _HintIsOperating = null)
		{
			bool flag;
			if (_HintIsOperating.HasValue)
			{
				flag = _HintIsOperating.Value;
			}
			else
			{
				flag = this.IsOperating();
			}
			double result;
			if (flag)
			{
				result = this.Latitude;
			}
			else
			{
				ActiveUnit currentHostUnit = this.GetAircraftAirOps().GetCurrentHostUnit();
				if (Information.IsNothing(currentHostUnit))
				{
					result = 0.0;
				}
				else
				{
					result = currentHostUnit.GetLatitude(null);
				}
			}
			return result;
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x00021F08 File Offset: 0x00020108
		public override void SetLatitude(bool? _HintIsOperating, double value)
		{
			this.Latitude = value;
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x00192548 File Offset: 0x00190748
		public bool IsVerticalLaunchable()
		{
			Aircraft._AircraftCategory category = this.Category;
			return category == Aircraft._AircraftCategory.Helicopter || category == Aircraft._AircraftCategory.Tiltrotor || this.RunwayLengthCode == GlobalVariables._RunwayLengthCode.TOD_LAD_0m_VTOL;
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x00021F11 File Offset: 0x00020111
		public bool IsRefuellingSupported()
		{
			return this.ProbeRefuelling || this.BoomRefuelling;
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x0019257C File Offset: 0x0019077C
		public override FuelRec[] GetFuelRecs()
		{
			FuelRec[] array = new FuelRec[0];
			checked
			{
				FuelRec[] result;
				try
				{
					FuelRec[] fuelRecs = this.m_FuelRecs;
					for (int i = 0; i < fuelRecs.Length; i++)
					{
						FuelRec fuelRec_ = fuelRecs[i];
						ScenarioArrayUtil.AddFuelRec(ref array, fuelRec_);
					}
					if (!Information.IsNothing(this.GetLoadout()))
					{
						WeaponRec[] weaponRecArray = this.GetLoadout().WeaponRecArray;
						for (int j = 0; j < weaponRecArray.Length; j++)
						{
							WeaponRec weaponRec = weaponRecArray[j];
							unchecked
							{
								if (weaponRec.GetWeapon(this.m_Scenario).IsTank())
								{
									int currentLoad = weaponRec.GetCurrentLoad();
									for (int k = 1; k <= currentLoad; k++)
									{
										ScenarioArrayUtil.AddFuelRec(ref array, weaponRec.GetWeapon(this.m_Scenario).GetFuelRecs()[0]);
									}
								}
							}
						}
					}
					result = array;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100361", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = array;
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x00192698 File Offset: 0x00190898
		public override int GetFuelRecsMaxQuantity()
		{
			int result = 0;
			try
			{
				FuelRec[] fuelRecs = this.GetFuelRecs();
				int num = 0;
				for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
				{
					FuelRec fuelRec = fuelRecs[i];
					num += fuelRec.MaxQuantity;
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100362", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x00192728 File Offset: 0x00190928
		public override int GetCurrentFuelQuantity()
		{
			int result = 0;
			checked
			{
				try
				{
					FuelRec[] fuelRecs = this.GetFuelRecs();
					int num = 0;
					for (int i = 0; i < fuelRecs.Length; i++)
					{
						FuelRec fuelRec = fuelRecs[i];
						num = unchecked((int)Math.Round((double)((float)num + fuelRec.CurrentQuantity)));
					}
					result = num;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100363", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x001927C0 File Offset: 0x001909C0
		public void SetFuelQuantity(float FuelQuantity_)
		{
			try
			{
				FuelRec fuelRec = this.m_FuelRecs[0];
				if (FuelQuantity_ >= (float)fuelRec.MaxQuantity)
				{
					fuelRec.CurrentQuantity = (float)fuelRec.MaxQuantity;
					FuelQuantity_ -= (float)fuelRec.MaxQuantity;
				}
				else
				{
					fuelRec.CurrentQuantity = FuelQuantity_;
					FuelQuantity_ = 0f;
				}
				if (!Information.IsNothing(this.GetLoadout()))
				{
					WeaponRec[] weaponRecArray = this.GetLoadout().WeaponRecArray;
					for (int i = 0; i < weaponRecArray.Length; i = checked(i + 1))
					{
						WeaponRec weaponRec = weaponRecArray[i];
						if (weaponRec.GetWeapon(this.m_Scenario).IsTank())
						{
							FuelRec fuelRec2 = weaponRec.GetWeapon(this.m_Scenario).GetFuelRecs()[0];
							FuelRec fuelRec3 = new FuelRec(0, (short)fuelRec2.FuelType);
							int currentLoad = weaponRec.GetCurrentLoad();
							fuelRec3.MaxQuantity = fuelRec2.MaxQuantity * currentLoad;
							if (FuelQuantity_ >= (float)fuelRec3.MaxQuantity)
							{
								fuelRec2.CurrentQuantity = (float)fuelRec2.MaxQuantity;
								FuelQuantity_ -= (float)fuelRec3.MaxQuantity;
							}
							else if (FuelQuantity_ > 0f)
							{
								fuelRec2.CurrentQuantity = FuelQuantity_ / (float)currentLoad;
								FuelQuantity_ = 0f;
							}
							else
							{
								fuelRec2.CurrentQuantity = 0f;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101227", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x00192950 File Offset: 0x00190B50
		public Aircraft_Navigator GetAircraftNavigator()
		{
			if (Information.IsNothing(this.aircraft_Navigator))
			{
				ActiveUnit activeUnit = this;
				this.aircraft_Navigator = new Aircraft_Navigator(ref activeUnit);
			}
			return this.aircraft_Navigator;
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x00192984 File Offset: 0x00190B84
		public Aircraft_AI GetAircraftAI()
		{
			if (Information.IsNothing(this.aircraft_AI))
			{
				ActiveUnit activeUnit = this;
				this.aircraft_AI = new Aircraft_AI(ref activeUnit);
			}
			return this.aircraft_AI;
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x001929B8 File Offset: 0x00190BB8
		public Aircraft_Kinematics GetAircraftKinematics()
		{
			if (Information.IsNothing(this.aircraft_Kinematics))
			{
				ActiveUnit activeUnit = this;
				this.aircraft_Kinematics = new Aircraft_Kinematics(ref activeUnit);
			}
			return this.aircraft_Kinematics;
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x001929EC File Offset: 0x00190BEC
		public Aircraft_Sensory GetAircraftSensory()
		{
			if (Information.IsNothing(this.aircraft_Sensory))
			{
				ActiveUnit activeUnit = this;
				this.aircraft_Sensory = new Aircraft_Sensory(ref activeUnit);
			}
			return this.aircraft_Sensory;
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x00192A20 File Offset: 0x00190C20
		public Aircraft_Weaponry GetAircraftWeaponry()
		{
			if (Information.IsNothing(this.aircraft_Weaponry))
			{
				ActiveUnit activeUnit = this;
				this.aircraft_Weaponry = new Aircraft_Weaponry(ref activeUnit);
			}
			return this.aircraft_Weaponry;
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x00192A54 File Offset: 0x00190C54
		public Aircraft_CommStuff GetAircraftCommStuff()
		{
			if (Information.IsNothing(this.aircraft_CommStuff))
			{
				ActiveUnit activeUnit = this;
				this.aircraft_CommStuff = new Aircraft_CommStuff(ref activeUnit);
			}
			return this.aircraft_CommStuff;
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x00192A88 File Offset: 0x00190C88
		public Aircraft_Damage GetAircraftDamage()
		{
			if (Information.IsNothing(this.aircraft_Damage))
			{
				ActiveUnit activeUnit = this;
				this.aircraft_Damage = new Aircraft_Damage(ref activeUnit);
			}
			return this.aircraft_Damage;
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x00192ABC File Offset: 0x00190CBC
		public Aircraft_AirOps GetAircraftAirOps()
		{
			if (Information.IsNothing(this.aircraft_AirOps))
			{
				ActiveUnit activeUnit = this;
				this.aircraft_AirOps = new Aircraft_AirOps(ref activeUnit);
			}
			return this.aircraft_AirOps;
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x00192AF0 File Offset: 0x00190CF0
		public string GetLoadoutName()
		{
			string result;
			if (Information.IsNothing(this.m_Loadout))
			{
				result = "Nothing";
			}
			else
			{
				result = this.m_Loadout.Name;
			}
			return result;
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x00192B2C File Offset: 0x00190D2C
		public int GetLoadoutDBID()
		{
			int result;
			if (Information.IsNothing(this.m_Loadout))
			{
				result = 0;
			}
			else
			{
				result = this.m_Loadout.DBID;
			}
			return result;
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x00192B60 File Offset: 0x00190D60
		public Loadout GetLoadout()
		{
			return this.m_Loadout;
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x00021F24 File Offset: 0x00020124
		public void SetLoadout(Loadout loadout_1)
		{
			this.m_Loadout = loadout_1;
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x00192B78 File Offset: 0x00190D78
		public override List<Sensor> GetMineCounterMeasures()
		{
			List<Sensor> result = null;
			checked
			{
				try
				{
					if (!this.IsMineSweeper())
					{
						result = new List<Sensor>();
					}
					else
					{
						List<Sensor> list = new List<Sensor>();
						list.AddRange(base.GetMineCounterMeasures());
						Mount[] mounts = this.m_Mounts;
						for (int i = 0; i < mounts.Length; i++)
						{
							Sensor[] sensors = mounts[i].GetSensors();
							for (int j = 0; j < sensors.Length; j++)
							{
								Sensor sensor = sensors[j];
								if (sensor.IsMineCounterMeasure())
								{
									list.Add(sensor);
								}
							}
						}
						if (!Information.IsNothing(this.GetLoadout()))
						{
							Sensor[] poddedSensors = this.GetLoadout().GetPoddedSensors(this.m_Scenario);
							if (poddedSensors.Length > 0)
							{
								list.AddRange(poddedSensors);
							}
							if (!Information.IsNothing(this.GetLoadout().WeaponRecArray))
							{
								WeaponRec[] weaponRecArray = this.GetLoadout().WeaponRecArray;
								for (int k = 0; k < weaponRecArray.Length; k++)
								{
									WeaponRec weaponRec = weaponRecArray[k];
									if (weaponRec.GetCurrentLoad() > 0)
									{
										foreach (Sensor current in weaponRec.GetWeapon(this.m_Scenario).GetMineCounterMeasures())
										{
											if (current.IsMineCounterMeasure())
											{
												list.Add(current);
											}
										}
									}
								}
							}
						}
						result = list;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100364", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x00192D50 File Offset: 0x00190F50
		public bool IsRotaryWingAircraft()
		{
			Aircraft._AircraftCategory category = this.Category;
			return category == Aircraft._AircraftCategory.Helicopter || category == Aircraft._AircraftCategory.Tiltrotor;
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x00192D78 File Offset: 0x00190F78
		public bool GetIsTerrainFollowing()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (!Information.IsNothing(this.GetLoadout()))
					{
						WeaponRec[] weaponRecArray = this.GetLoadout().WeaponRecArray;
						for (int i = 0; i < weaponRecArray.Length; i++)
						{
							WeaponRec weaponRec = weaponRecArray[i];
							if (weaponRec.GetWeapon(this.m_Scenario).GetWeaponType() == Weapon._WeaponType.SensorPod && weaponRec.GetWeapon(this.m_Scenario).weaponCode.Pod_TerrainFollowing)
							{
								flag = true;
								result = true;
								return result;
							}
						}
					}
					flag = this.terrainFollowing;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100365", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x00021F2D File Offset: 0x0002012D
		public void SetIsTerrainFollowing(bool value)
		{
			this.terrainFollowing = value;
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x00192E54 File Offset: 0x00191054
		public bool IsTerrainAvoidance()
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					if (!Information.IsNothing(this.GetLoadout()))
					{
						WeaponRec[] weaponRecArray = this.GetLoadout().WeaponRecArray;
						for (int i = 0; i < weaponRecArray.Length; i++)
						{
							WeaponRec weaponRec = weaponRecArray[i];
							if (weaponRec.GetWeapon(this.m_Scenario).GetWeaponType() == Weapon._WeaponType.SensorPod && weaponRec.GetWeapon(this.m_Scenario).weaponCode.Pod_TerrainAvoidance)
							{
								flag = true;
								result = true;
								return result;
							}
						}
					}
					flag = this.TerrainAvoidance;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100365", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				result = flag;
				return result;
			}
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x00021F36 File Offset: 0x00020136
		public void SetIsTerrainAvoidance(bool value)
		{
			this.TerrainAvoidance = value;
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x00021F3F File Offset: 0x0002013F
		public override bool IsTerrainFollowing(ActiveUnit activeUnit_1)
		{
			return this.TerrainFollowing;
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x00021F47 File Offset: 0x00020147
		public override void SetIsTerrainFollowing(ActiveUnit activeUnit_1, bool value)
		{
			this.TerrainFollowing = value;
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x00192F30 File Offset: 0x00191130
		public  float GetAllowedMinAltitude()
		{
			float result = 0f;
			try
			{
				int num = base.GetTerrainElevation(false, false, false);
				if (num < 0)
				{
					num = 0;
				}
				bool flag = num > 0;
				Weather.WeatherProfile weatherProfile = Weather.GetWeatherProfile(this.m_Scenario, this.GetLatitude(null), this.GetLongitude(null), (int)Math.Round((double)this.GetCurrentAltitude_ASL(false)));
				float num2 = 0f;
				if (flag)
				{
					DateTime currentTime = this.m_Scenario.GetCurrentTime(false);
					if (Class240.GetTimeOfDay(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, currentTime.Minute, currentTime.Second, this.GetLatitude(null), this.GetLongitude(null), 0.0) == Weather._TimeOfDay.Day)
					{
						Aircraft._AircraftCategory category = this.Category;
						if (category != Aircraft._AircraftCategory.Helicopter)
						{
							if (category != Aircraft._AircraftCategory.Tiltrotor)
							{
								if (this.IsTerrainAvoidance())
								{
									num2 = 91.44f;
								}
								else if (this.GetIsTerrainFollowing())
								{
									num2 = 60.96f;
								}
								else
								{
									num2 = 152.4f;
									switch (weatherProfile.SeaState)
									{
									case 0:
										if (weatherProfile.RainFallRate < 5f && this.aircraftSizeClass <= GlobalVariables.AircraftSizeClass.Large)
										{
											GlobalVariables.ProficiencyLevel? proficiencyLevel = this.GetProficiencyLevel();
											int? num3 = proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
											if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
											{
												num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
												if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
												{
													num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
													if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
													{
														num2 = 121.92f;
													}
													else
													{
														num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
														if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
														{
															num2 = 91.44f;
														}
														else
														{
															num3 = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
															if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
															{
																num2 = 60.96f;
															}
														}
													}
												}
											}
										}
										break;
									case 1:
										if (weatherProfile.RainFallRate < 5f && this.aircraftSizeClass <= GlobalVariables.AircraftSizeClass.Large)
										{
											GlobalVariables.ProficiencyLevel? proficiencyLevel2 = this.GetProficiencyLevel();
											int? num3 = proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null;
											if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
											{
												num3 = (proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
												if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
												{
													num3 = (proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
													if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
													{
														num2 = 121.92f;
													}
													else
													{
														num3 = (proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
														if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
														{
															num2 = 91.44f;
														}
														else
														{
															num3 = (proficiencyLevel2.HasValue ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
															if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
															{
																num2 = 60.96f;
															}
														}
													}
												}
											}
										}
										break;
									case 2:
										if (weatherProfile.RainFallRate < 5f && this.aircraftSizeClass <= GlobalVariables.AircraftSizeClass.Large)
										{
											GlobalVariables.ProficiencyLevel? proficiencyLevel3 = this.GetProficiencyLevel();
											int? num3 = proficiencyLevel3.HasValue ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null;
											if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
											{
												num3 = (proficiencyLevel3.HasValue ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
												if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
												{
													num3 = (proficiencyLevel3.HasValue ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
													if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
													{
														num2 = 121.92f;
													}
													else
													{
														num3 = (proficiencyLevel3.HasValue ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
														if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
														{
															num2 = 91.44f;
														}
														else
														{
															num3 = (proficiencyLevel3.HasValue ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
															if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
															{
																num2 = 60.96f;
															}
														}
													}
												}
											}
										}
										break;
									case 3:
										if (weatherProfile.RainFallRate < 5f && this.aircraftSizeClass <= GlobalVariables.AircraftSizeClass.Large)
										{
											GlobalVariables.ProficiencyLevel? proficiencyLevel4 = this.GetProficiencyLevel();
											int? num3 = proficiencyLevel4.HasValue ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null;
											if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
											{
												num3 = (proficiencyLevel4.HasValue ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
												if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
												{
													num3 = (proficiencyLevel4.HasValue ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
													if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
													{
														num2 = 121.92f;
													}
													else
													{
														num3 = (proficiencyLevel4.HasValue ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
														if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
														{
															num2 = 91.44f;
														}
														else
														{
															num3 = (proficiencyLevel4.HasValue ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
															if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
															{
																num2 = 60.96f;
															}
														}
													}
												}
											}
										}
										break;
									case 4:
										if (weatherProfile.RainFallRate < 5f && this.aircraftSizeClass <= GlobalVariables.AircraftSizeClass.Large)
										{
											GlobalVariables.ProficiencyLevel? proficiencyLevel5 = this.GetProficiencyLevel();
											int? num3 = proficiencyLevel5.HasValue ? new int?((int)proficiencyLevel5.GetValueOrDefault()) : null;
											if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
											{
												num3 = (proficiencyLevel5.HasValue ? new int?((int)proficiencyLevel5.GetValueOrDefault()) : null);
												if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
												{
													num3 = (proficiencyLevel5.HasValue ? new int?((int)proficiencyLevel5.GetValueOrDefault()) : null);
													if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
													{
														num2 = 121.92f;
													}
													else
													{
														num3 = (proficiencyLevel5.HasValue ? new int?((int)proficiencyLevel5.GetValueOrDefault()) : null);
														if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
														{
															num2 = 91.44f;
														}
														else
														{
															num3 = (proficiencyLevel5.HasValue ? new int?((int)proficiencyLevel5.GetValueOrDefault()) : null);
															if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
															{
																num2 = 60.96f;
															}
														}
													}
												}
											}
										}
										break;
									case 5:
										if (weatherProfile.RainFallRate < 5f && this.aircraftSizeClass <= GlobalVariables.AircraftSizeClass.Large)
										{
											GlobalVariables.ProficiencyLevel? proficiencyLevel6 = this.GetProficiencyLevel();
											int? num3 = proficiencyLevel6.HasValue ? new int?((int)proficiencyLevel6.GetValueOrDefault()) : null;
											if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
											{
												num3 = (proficiencyLevel6.HasValue ? new int?((int)proficiencyLevel6.GetValueOrDefault()) : null);
												if (!(num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
												{
													num3 = (proficiencyLevel6.HasValue ? new int?((int)proficiencyLevel6.GetValueOrDefault()) : null);
													if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
													{
														num2 = 121.92f;
													}
													else
													{
														num3 = (proficiencyLevel6.HasValue ? new int?((int)proficiencyLevel6.GetValueOrDefault()) : null);
														if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
														{
															num2 = 91.44f;
														}
														else
														{
															num3 = (proficiencyLevel6.HasValue ? new int?((int)proficiencyLevel6.GetValueOrDefault()) : null);
															if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
															{
																num2 = 60.96f;
															}
														}
													}
												}
											}
										}
										break;
									case 6:
									case 7:
									case 8:
									case 9:
									case 10:
										break;
									default:
										throw new NotImplementedException();
									}
								}
							}
							else
							{
								ActiveUnit.Throttle throttle = this.GetThrottle();
								if (throttle != ActiveUnit.Throttle.FullStop)
								{
									if (throttle == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else if (this.IsTerrainAvoidance())
									{
										num2 = 91.44f;
									}
									else if (this.GetIsTerrainFollowing())
									{
										num2 = 60.96f;
									}
									else
									{
										num2 = 152.4f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
							}
						}
						else
						{
							switch (weatherProfile.SeaState)
							{
							case 0:
							{
								ActiveUnit.Throttle throttle2 = this.GetThrottle();
								if (throttle2 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle2 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 1:
							{
								ActiveUnit.Throttle throttle3 = this.GetThrottle();
								if (throttle3 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle3 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 2:
							{
								ActiveUnit.Throttle throttle4 = this.GetThrottle();
								if (throttle4 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle4 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 3:
							{
								ActiveUnit.Throttle throttle5 = this.GetThrottle();
								if (throttle5 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle5 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 4:
							{
								ActiveUnit.Throttle throttle6 = this.GetThrottle();
								if (throttle6 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle6 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 5:
							{
								ActiveUnit.Throttle throttle7 = this.GetThrottle();
								if (throttle7 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle7 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 45.72f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 6:
							{
								ActiveUnit.Throttle throttle8 = this.GetThrottle();
								if (throttle8 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle8 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 45.72f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 7:
							{
								ActiveUnit.Throttle throttle9 = this.GetThrottle();
								if (throttle9 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle9 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 60.96f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 8:
							{
								ActiveUnit.Throttle throttle10 = this.GetThrottle();
								if (throttle10 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle10 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 60.96f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 9:
							{
								ActiveUnit.Throttle throttle11 = this.GetThrottle();
								if (throttle11 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle11 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 60.96f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 10:
							{
								ActiveUnit.Throttle throttle12 = this.GetThrottle();
								if (throttle12 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle12 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 60.96f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							}
						}
					}
					else
					{
						Aircraft._AircraftCategory category2 = this.Category;
						if (category2 == Aircraft._AircraftCategory.Helicopter || category2 == Aircraft._AircraftCategory.Tiltrotor)
						{
							ActiveUnit.Throttle throttle13 = this.GetThrottle();
							if (throttle13 != ActiveUnit.Throttle.FullStop)
							{
								if (throttle13 == ActiveUnit.Throttle.Loiter)
								{
									num2 = 15.24f;
								}
								else if (this.IsTerrainAvoidance())
								{
									num2 = 91.44f;
								}
								else if (this.GetIsTerrainFollowing())
								{
									num2 = 60.96f;
								}
								else
								{
									num2 = 152.4f;
								}
							}
							else
							{
								num2 = 15.24f;
							}
						}
						else if (this.IsTerrainAvoidance())
						{
							num2 = 91.44f;
						}
						else if (this.GetIsTerrainFollowing())
						{
							num2 = 60.96f;
						}
						else
						{
							num2 = 304.8f;
						}
					}
				}
				else
				{
					DateTime currentTime2 = this.m_Scenario.GetCurrentTime(false);
					if (Class240.GetTimeOfDay(currentTime2.Year, currentTime2.Month, currentTime2.Day, currentTime2.Hour, currentTime2.Minute, currentTime2.Second, this.GetLatitude(null), this.GetLongitude(null), 0.0) == Weather._TimeOfDay.Day)
					{
						Aircraft._AircraftCategory category3 = this.Category;
						if (category3 == Aircraft._AircraftCategory.Helicopter || category3 == Aircraft._AircraftCategory.Tiltrotor)
						{
							switch (weatherProfile.SeaState)
							{
							case 0:
								num2 = 15.24f;
								break;
							case 1:
								num2 = 15.24f;
								break;
							case 2:
								num2 = 15.24f;
								break;
							case 3:
								num2 = 15.24f;
								break;
							case 4:
								num2 = 15.24f;
								break;
							case 5:
								num2 = 15.24f;
								break;
							case 6:
							{
								ActiveUnit.Throttle throttle14 = this.GetThrottle();
								if (throttle14 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle14 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 7:
							{
								ActiveUnit.Throttle throttle15 = this.GetThrottle();
								if (throttle15 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle15 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 8:
							{
								ActiveUnit.Throttle throttle16 = this.GetThrottle();
								if (throttle16 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle16 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 60.96f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 9:
							{
								ActiveUnit.Throttle throttle17 = this.GetThrottle();
								if (throttle17 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle17 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 60.96f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 10:
							{
								ActiveUnit.Throttle throttle18 = this.GetThrottle();
								if (throttle18 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle18 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 60.96f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							}
						}
						else if (!this.IsTerrainAvoidance() && !this.GetIsTerrainFollowing())
						{
							num2 = 91.44f;
							switch (weatherProfile.SeaState)
							{
							case 0:
								if (weatherProfile.RainFallRate < 5f && this.aircraftSizeClass <= GlobalVariables.AircraftSizeClass.Large)
								{
									GlobalVariables.ProficiencyLevel? proficiencyLevel7 = this.GetProficiencyLevel();
									int? num3 = proficiencyLevel7.HasValue ? new int?((int)proficiencyLevel7.GetValueOrDefault()) : null;
									if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										num2 = 45.72f;
									}
									else
									{
										num3 = (proficiencyLevel7.HasValue ? new int?((int)proficiencyLevel7.GetValueOrDefault()) : null);
										if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											num2 = 30.48f;
										}
										else
										{
											num3 = (proficiencyLevel7.HasValue ? new int?((int)proficiencyLevel7.GetValueOrDefault()) : null);
											if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
											{
												num2 = 24.3839989f;
											}
											else
											{
												num3 = (proficiencyLevel7.HasValue ? new int?((int)proficiencyLevel7.GetValueOrDefault()) : null);
												if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
												{
													num2 = 24.3839989f;
												}
												else
												{
													num3 = (proficiencyLevel7.HasValue ? new int?((int)proficiencyLevel7.GetValueOrDefault()) : null);
													if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
													{
														num2 = 24.3839989f;
													}
												}
											}
										}
									}
								}
								break;
							case 1:
								if (weatherProfile.RainFallRate < 5f && this.aircraftSizeClass <= GlobalVariables.AircraftSizeClass.Large)
								{
									GlobalVariables.ProficiencyLevel? proficiencyLevel8 = this.GetProficiencyLevel();
									int? num3 = proficiencyLevel8.HasValue ? new int?((int)proficiencyLevel8.GetValueOrDefault()) : null;
									if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										num2 = 45.72f;
									}
									else
									{
										num3 = (proficiencyLevel8.HasValue ? new int?((int)proficiencyLevel8.GetValueOrDefault()) : null);
										if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											num2 = 30.48f;
										}
										else
										{
											num3 = (proficiencyLevel8.HasValue ? new int?((int)proficiencyLevel8.GetValueOrDefault()) : null);
											if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
											{
												num2 = 24.3839989f;
											}
											else
											{
												num3 = (proficiencyLevel8.HasValue ? new int?((int)proficiencyLevel8.GetValueOrDefault()) : null);
												if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
												{
													num2 = 24.3839989f;
												}
												else
												{
													num3 = (proficiencyLevel8.HasValue ? new int?((int)proficiencyLevel8.GetValueOrDefault()) : null);
													if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
													{
														num2 = 24.3839989f;
													}
												}
											}
										}
									}
								}
								break;
							case 2:
								if (weatherProfile.RainFallRate < 5f && this.aircraftSizeClass <= GlobalVariables.AircraftSizeClass.Large)
								{
									GlobalVariables.ProficiencyLevel? proficiencyLevel9 = this.GetProficiencyLevel();
									int? num3 = proficiencyLevel9.HasValue ? new int?((int)proficiencyLevel9.GetValueOrDefault()) : null;
									if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										num2 = 45.72f;
									}
									else
									{
										num3 = (proficiencyLevel9.HasValue ? new int?((int)proficiencyLevel9.GetValueOrDefault()) : null);
										if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											num2 = 30.48f;
										}
										else
										{
											num3 = (proficiencyLevel9.HasValue ? new int?((int)proficiencyLevel9.GetValueOrDefault()) : null);
											if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
											{
												num2 = 24.3839989f;
											}
											else
											{
												num3 = (proficiencyLevel9.HasValue ? new int?((int)proficiencyLevel9.GetValueOrDefault()) : null);
												if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
												{
													num2 = 24.3839989f;
												}
												else
												{
													num3 = (proficiencyLevel9.HasValue ? new int?((int)proficiencyLevel9.GetValueOrDefault()) : null);
													if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
													{
														num2 = 24.3839989f;
													}
												}
											}
										}
									}
								}
								break;
							case 3:
								if (weatherProfile.RainFallRate < 5f && this.aircraftSizeClass <= GlobalVariables.AircraftSizeClass.Large)
								{
									GlobalVariables.ProficiencyLevel? proficiencyLevel10 = this.GetProficiencyLevel();
									int? num3 = proficiencyLevel10.HasValue ? new int?((int)proficiencyLevel10.GetValueOrDefault()) : null;
									if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										num2 = 45.72f;
									}
									else
									{
										num3 = (proficiencyLevel10.HasValue ? new int?((int)proficiencyLevel10.GetValueOrDefault()) : null);
										if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											num2 = 30.48f;
										}
										else
										{
											num3 = (proficiencyLevel10.HasValue ? new int?((int)proficiencyLevel10.GetValueOrDefault()) : null);
											if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
											{
												num2 = 24.3839989f;
											}
											else
											{
												num3 = (proficiencyLevel10.HasValue ? new int?((int)proficiencyLevel10.GetValueOrDefault()) : null);
												if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
												{
													num2 = 24.3839989f;
												}
												else
												{
													num3 = (proficiencyLevel10.HasValue ? new int?((int)proficiencyLevel10.GetValueOrDefault()) : null);
													if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
													{
														num2 = 24.3839989f;
													}
												}
											}
										}
									}
								}
								break;
							case 4:
								if (weatherProfile.RainFallRate < 5f && this.aircraftSizeClass <= GlobalVariables.AircraftSizeClass.Large)
								{
									GlobalVariables.ProficiencyLevel? proficiencyLevel11 = this.GetProficiencyLevel();
									int? num3 = proficiencyLevel11.HasValue ? new int?((int)proficiencyLevel11.GetValueOrDefault()) : null;
									if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										num2 = 45.72f;
									}
									else
									{
										num3 = (proficiencyLevel11.HasValue ? new int?((int)proficiencyLevel11.GetValueOrDefault()) : null);
										if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											num2 = 30.48f;
										}
										else
										{
											num3 = (proficiencyLevel11.HasValue ? new int?((int)proficiencyLevel11.GetValueOrDefault()) : null);
											if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
											{
												num2 = 24.3839989f;
											}
											else
											{
												num3 = (proficiencyLevel11.HasValue ? new int?((int)proficiencyLevel11.GetValueOrDefault()) : null);
												if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
												{
													num2 = 24.3839989f;
												}
												else
												{
													num3 = (proficiencyLevel11.HasValue ? new int?((int)proficiencyLevel11.GetValueOrDefault()) : null);
													if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
													{
														num2 = 24.3839989f;
													}
												}
											}
										}
									}
								}
								break;
							case 5:
								if (weatherProfile.RainFallRate < 5f && this.aircraftSizeClass <= GlobalVariables.AircraftSizeClass.Large)
								{
									GlobalVariables.ProficiencyLevel? proficiencyLevel12 = this.GetProficiencyLevel();
									int? num3 = proficiencyLevel12.HasValue ? new int?((int)proficiencyLevel12.GetValueOrDefault()) : null;
									if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										num2 = 45.72f;
									}
									else
									{
										num3 = (proficiencyLevel12.HasValue ? new int?((int)proficiencyLevel12.GetValueOrDefault()) : null);
										if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											num2 = 45.72f;
										}
										else
										{
											num3 = (proficiencyLevel12.HasValue ? new int?((int)proficiencyLevel12.GetValueOrDefault()) : null);
											if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
											{
												num2 = 30.48f;
											}
											else
											{
												num3 = (proficiencyLevel12.HasValue ? new int?((int)proficiencyLevel12.GetValueOrDefault()) : null);
												if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
												{
													num2 = 30.48f;
												}
												else
												{
													num3 = (proficiencyLevel12.HasValue ? new int?((int)proficiencyLevel12.GetValueOrDefault()) : null);
													if ((num3.HasValue ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
													{
														num2 = 24.3839989f;
													}
												}
											}
										}
									}
								}
								break;
							case 6:
							case 7:
							case 8:
							case 9:
							case 10:
								break;
							default:
								throw new NotImplementedException();
							}
						}
						else
						{
							num2 = 30.48f;
							switch (weatherProfile.SeaState)
							{
							case 0:
							case 1:
							case 2:
							case 3:
							case 4:
							case 5:
							case 6:
							case 7:
								break;
							case 8:
								num2 = 60.96f;
								break;
							case 9:
								num2 = 60.96f;
								break;
							case 10:
								num2 = 60.96f;
								break;
							default:
								throw new NotImplementedException();
							}
						}
					}
					else
					{
						Aircraft._AircraftCategory category4 = this.Category;
						if (category4 == Aircraft._AircraftCategory.Helicopter || category4 == Aircraft._AircraftCategory.Tiltrotor)
						{
							switch (weatherProfile.SeaState)
							{
							case 0:
							{
								ActiveUnit.Throttle throttle19 = this.GetThrottle();
								if (throttle19 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle19 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 1:
							{
								ActiveUnit.Throttle throttle20 = this.GetThrottle();
								if (throttle20 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle20 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 2:
							{
								ActiveUnit.Throttle throttle21 = this.GetThrottle();
								if (throttle21 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle21 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 3:
							{
								ActiveUnit.Throttle throttle22 = this.GetThrottle();
								if (throttle22 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle22 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 4:
							{
								ActiveUnit.Throttle throttle23 = this.GetThrottle();
								if (throttle23 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle23 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 5:
							{
								ActiveUnit.Throttle throttle24 = this.GetThrottle();
								if (throttle24 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle24 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 6:
							{
								ActiveUnit.Throttle throttle25 = this.GetThrottle();
								if (throttle25 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle25 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 30.48f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 7:
							{
								ActiveUnit.Throttle throttle26 = this.GetThrottle();
								if (throttle26 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle26 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 60.96f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 8:
							{
								ActiveUnit.Throttle throttle27 = this.GetThrottle();
								if (throttle27 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle27 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 60.96f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 9:
							{
								ActiveUnit.Throttle throttle28 = this.GetThrottle();
								if (throttle28 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle28 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 60.96f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							case 10:
							{
								ActiveUnit.Throttle throttle29 = this.GetThrottle();
								if (throttle29 != ActiveUnit.Throttle.FullStop)
								{
									if (throttle29 == ActiveUnit.Throttle.Loiter)
									{
										num2 = 15.24f;
									}
									else
									{
										num2 = 60.96f;
									}
								}
								else
								{
									num2 = 15.24f;
								}
								break;
							}
							}
						}
						else if (!this.IsTerrainAvoidance() && !this.GetIsTerrainFollowing())
						{
							num2 = 91.44f;
							switch (weatherProfile.SeaState)
							{
							case 0:
							case 1:
							case 2:
							case 3:
							case 4:
							case 5:
							case 6:
							case 7:
							case 8:
							case 9:
							case 10:
								break;
							default:
								throw new NotImplementedException();
							}
						}
						else
						{
							num2 = 30.48f;
							switch (weatherProfile.SeaState)
							{
							case 0:
							case 1:
							case 2:
							case 3:
							case 4:
							case 5:
							case 6:
							case 7:
								break;
							case 8:
								num2 = 60.96f;
								break;
							case 9:
								num2 = 60.96f;
								break;
							case 10:
								num2 = 60.96f;
								break;
							default:
								throw new NotImplementedException();
							}
						}
					}
				}
				result = (float)num + num2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100366", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x001953B4 File Offset: 0x001935B4
		public Aircraft(ref Scenario theScen, string theGUID = null) : base(ref theScen, theGUID)
		{
			this.AircraftCockpitArmor = GlobalVariables.ArmorRating.None;
			this.AircraftFuselageArmor = GlobalVariables.ArmorRating.None;
			this.AircraftEngineArmor = GlobalVariables.ArmorRating.None;
			this.FuelQuantityLeftToBingo = 0f;
			this.FuelQuantityLeftToJoker = 0f;
			this.ForwardCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Excellent;
			this.SidewaysCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Excellent;
			this.AftCockpitVisibilityLevel = Aircraft._CockpitVisibilityLevel.Excellent;
			this.IsAircraft = true;
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x0019543C File Offset: 0x0019363C
		public static int GetInitialDP(int Length)
		{
			int result;
			if (Length < 20)
			{
				result = 100;
			}
			else if (Length < 50)
			{
				result = 200;
			}
			else if (Length < 100)
			{
				result = 400;
			}
			else if (Length < 120)
			{
				result = 800;
			}
			else if (Length < 150)
			{
				result = 1600;
			}
			else
			{
				result = 3200;
			}
			return result;
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x001954B0 File Offset: 0x001936B0
		public override void DestroyUnit(bool ScenEditAction, bool IsAimpointFacility, bool DestroyUnitNow = false)
		{
			try
			{
				this.isDestroyed = true;
				this.GetAircraftAirOps().SetHostAirFacility(null);
				if (this.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.OffloadingFuel)
				{
					List<KeyValuePair<string, Aircraft_AirOps._RefuellingConnection>> list = new List<KeyValuePair<string, Aircraft_AirOps._RefuellingConnection>>();
					list.AddRange(this.aircraft_AirOps.GetA2ARCDictionary());
					foreach (KeyValuePair<string, Aircraft_AirOps._RefuellingConnection> current in list)
					{
						Aircraft aircraft = (Aircraft)this.m_Scenario.GetActiveUnits()[current.Key];
						if (!Information.IsNothing(aircraft))
						{
							aircraft.aircraft_AirOps.A2ARefueling();
						}
					}
					List<string> list2 = new List<string>();
					list2.AddRange(this.aircraft_AirOps.GetRefuellingQueue());
                    string current2X;

                    foreach (string current2 in list2)
					{
                        current2X = current2;
                        this.aircraft_AirOps.GetRefuellingQueue().TryTake(out current2X);
					}
				}
				foreach (ActiveUnit current3 in this.m_Scenario.GetActiveUnitList())
				{
					if (current3.GetAirOps().GetLandingQueue().Contains(this))
					{
						current3.GetAirOps().RemoveAircraftFromLandingQueue(this);
					}
					if (current3.IsAircraft && !Information.IsNothing(((Aircraft)current3).GetAircraftAirOps().GetRefuellingQueue()))
					{
						ConcurrentBag<string> refuellingQueue = ((Aircraft)current3).GetAircraftAirOps().GetRefuellingQueue();
						string guid = base.GetGuid();
						refuellingQueue.TryTake(out guid);
					}
				}
				base.DestroyUnit(ScenEditAction, IsAimpointFacility, DestroyUnitNow);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100367", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x00021F50 File Offset: 0x00020150
		public override void ScheduleLifeCycleActivities(float elapsedTime_, ref Random random_)
		{
			this.GetAircraftAirOps().ScheduleAirOpsEvent(elapsedTime_);
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x00195704 File Offset: 0x00193904
		public override void SetHomeBase(ActiveUnit NewHostUnit_)
		{
			bool flag = !NewHostUnit_.IsGroup;
			bool flag2 = false;
			bool flag3 = false;
			if (NewHostUnit_.IsGroup)
			{
				if (((Group)NewHostUnit_).GetGroupType() == Group.GroupType.AirBase)
				{
					flag3 = true;
				}
				else
				{
					flag2 = true;
				}
			}
			string text = "";
			if (Operators.CompareString(this.Name, this.UnitClass, false) != 0)
			{
				text = " (" + this.UnitClass + ")";
			}
			if (flag || flag3)
			{
				string text2 = this.GetAircraftAirOps().CheckHostCondition(NewHostUnit_);
				if (Operators.CompareString(text2, "OK", false) == 0)
				{
					this.GetAircraftAirOps().SetAssignedHostUnit(false, NewHostUnit_);
					this.m_Scenario.LogMessage(NewHostUnit_.Name + "现已成为如下飞机的新基地：" + this.Name + text, LoggedMessage.MessageType.AirOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
				else
				{
					this.m_Scenario.LogMessage(string.Concat(new string[]
					{
						"无法将",
						NewHostUnit_.Name,
						"设置为如下飞机的新基地：",
						this.Name,
						text,
						". 原因: ",
						text2
					}), LoggedMessage.MessageType.AirOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
			}
			if (flag2)
			{
				Unit unit = null;
				foreach (ActiveUnit current in ((Group)NewHostUnit_).GetUnitsInGroup().Values)
				{
					if (Operators.CompareString(this.GetAircraftAirOps().CheckHostCondition(current), "OK", false) == 0)
					{
						this.GetAircraftAirOps().SetAssignedHostUnit(false, current);
						unit = current;
						break;
					}
				}
				if (unit == null)
				{
					this.m_Scenario.LogMessage(string.Concat(new string[]
					{
						"无法将",
						NewHostUnit_.Name,
						"设置为下面飞机的新基地：",
						this.Name,
						text
					}), LoggedMessage.MessageType.AirOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
				else
				{
					this.m_Scenario.LogMessage(NewHostUnit_.Name + "现已成为如下飞机的新基地：" + this.Name + text, LoggedMessage.MessageType.AirOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
			}
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x00195970 File Offset: 0x00193B70
		public override bool vmethod_41(double Lat_, double Lon_, ref byte byte_0, bool bool_32, ref bool bAboutToEnterNoNavZone, bool bool_34, ref bool bool_35, float? nullable_14, short? nullable_15, ref List<ActiveUnit> list_3, float float_29, bool bool_36, bool bool_37)
		{
			bool flag = false;
			bool result;
			try
			{
				byte_0 = 1;
				if (bool_36 && this.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedOffensive && !Information.IsNothing(this.GetAssignedMission(false)) && this.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
				{
					Patrol patrol = (Patrol)this.GetAssignedMission(false);
					GeoPoint geoPoint = new GeoPoint(Lon_, Lat_);
					if (this.vmethod_40(patrol.ProsecutionAreaVertices, this.m_Scenario, true) && !geoPoint.method_22(ref patrol.ProsecutionAreaVertices, true))
					{
						bAboutToEnterNoNavZone = false;
						bool_35 = false;
						flag = false;
						result = false;
						return result;
					}
				}
				if (bool_37)
				{
					bAboutToEnterNoNavZone = base.AboutToEnterNoNavZone();
				}
				if ((bAboutToEnterNoNavZone || bool_32) && base.method_122(Lat_, Lon_, float_29))
				{
					bAboutToEnterNoNavZone = true;
					bool_35 = false;
					flag = false;
				}
				else
				{
					bAboutToEnterNoNavZone = false;
					bool_35 = false;
					flag = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200284", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				bAboutToEnterNoNavZone = false;
				bool_35 = false;
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x00021F5E File Offset: 0x0002015E
		public bool IsParked()
		{
			return this.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Parked;
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x00021F6E File Offset: 0x0002016E
		public override bool IsParkedInPlace()
		{
			return this.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Parked && this.GetAircraftAirOps().GetConditionTimer() == 0f;
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x00021F93 File Offset: 0x00020193
		public override bool IsParking()
		{
			return this.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Parked && this.GetAircraftAirOps().GetConditionTimer() > 0f;
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x00195AA4 File Offset: 0x00193CA4
		public override bool IsOperating()
		{
			bool flag = false;
			bool result;
			try
			{
				switch (this.GetAircraftAirOps().GetAirOpsCondition())
				{
				case Aircraft_AirOps._AirOpsCondition.Airborne:
				case Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown:
				case Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue:
				case Aircraft_AirOps._AirOpsCondition.RTB:
				case Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel:
				case Aircraft_AirOps._AirOpsCondition.Refuelling:
				case Aircraft_AirOps._AirOpsCondition.OffloadingFuel:
				case Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar:
				case Aircraft_AirOps._AirOpsCondition.EmergencyLanding:
				case Aircraft_AirOps._AirOpsCondition.BVRAttack:
				case Aircraft_AirOps._AirOpsCondition.BVRCrank:
				case Aircraft_AirOps._AirOpsCondition.Dogfight:
				case Aircraft_AirOps._AirOpsCondition.DeployingCargo:
					flag = true;
					result = true;
					return result;
				case Aircraft_AirOps._AirOpsCondition.Parked:
				case Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff:
				case Aircraft_AirOps._AirOpsCondition.TaxyingToPark:
				case Aircraft_AirOps._AirOpsCondition.TakingOff:
				case Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown:
				case Aircraft_AirOps._AirOpsCondition.Readying:
				case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit:
				case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway:
				case Aircraft_AirOps._AirOpsCondition.PreparingToLaunch:
				case Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck:
					flag = false;
					result = false;
					return result;
				default:
					flag = false;
					result = false;
					return result;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
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

		// Token: 0x0600443B RID: 17467 RVA: 0x00195B68 File Offset: 0x00193D68
		public override float GetMaxFuelQuantityToFill()
		{
			float result = 0f;
			try
			{
				FuelRec[] fuelRecs = this.GetFuelRecs();
				float num = 0f;
				for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
				{
					FuelRec fuelRec = fuelRecs[i];
					num += (float)fuelRec.MaxQuantity - fuelRec.CurrentQuantity;
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100369", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x00195C0C File Offset: 0x00193E0C
		public override void ConsumeFuel(float FuelConsumption_, FuelRec._FuelType FuelType_)
		{
			try
			{
				float num = FuelConsumption_;
				if (!Information.IsNothing(this.GetLoadout()))
				{
					WeaponRec[] weaponRecArray = this.GetLoadout().WeaponRecArray;
					for (int i = 0; i < weaponRecArray.Length; i = checked(i + 1))
					{
						WeaponRec weaponRec = weaponRecArray[i];
						if (num == 0f)
						{
							break;
						}
						if (weaponRec.GetWeapon(this.m_Scenario).IsTank())
						{
							FuelRec fuelRec = weaponRec.GetWeapon(this.m_Scenario).GetFuelRecs()[0];
							FuelRec fuelRec2 = new FuelRec(0, (short)fuelRec.FuelType);
							int currentLoad = weaponRec.GetCurrentLoad();
							fuelRec2.CurrentQuantity = fuelRec.CurrentQuantity * (float)currentLoad;
							fuelRec2.MaxQuantity = fuelRec.MaxQuantity * currentLoad;
							if (fuelRec2.CurrentQuantity >= num)
							{
								fuelRec2.CurrentQuantity -= num;
								fuelRec.CurrentQuantity = fuelRec2.CurrentQuantity / (float)currentLoad;
								num = 0f;
								break;
							}
							num -= fuelRec2.CurrentQuantity;
							fuelRec2.CurrentQuantity = 0f;
							fuelRec.CurrentQuantity = 0f;
						}
					}
				}
				if (num != 0f)
				{
					FuelRec fuelRec3 = this.m_FuelRecs[0];
					if (fuelRec3.CurrentQuantity > num)
					{
						fuelRec3.CurrentQuantity -= num;
					}
					else
					{
						string str = "";
						if (Operators.CompareString(this.Name, this.UnitClass, false) != 0)
						{
							str = " (" + this.UnitClass + ")";
						}
						base.LogMessage(this.Name + str + "燃油耗光，坠毁!", LoggedMessage.MessageType.UnitLost, 1, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						this.m_Scenario.RemoveUnit(this);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100370", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x00195E38 File Offset: 0x00194038
		public override void TransferFuel(float FuelQuantity_, FuelRec._FuelType FuelType_)
		{
			try
			{
				FuelRec fuelRec = this.m_FuelRecs[0];
				float num = (float)fuelRec.MaxQuantity - fuelRec.CurrentQuantity;
				float num2;
				if (num > FuelQuantity_)
				{
					fuelRec.CurrentQuantity += FuelQuantity_;
					num2 = 0f;
				}
				else
				{
					fuelRec.CurrentQuantity = (float)fuelRec.MaxQuantity;
					num2 = FuelQuantity_ - num;
				}
				if (num2 != 0f && !Information.IsNothing(this.GetLoadout()))
				{
					WeaponRec[] weaponRecArray = this.GetLoadout().WeaponRecArray;
					for (int i = 0; i < weaponRecArray.Length; i = checked(i + 1))
					{
						WeaponRec weaponRec = weaponRecArray[i];
						if (weaponRec.GetWeapon(this.m_Scenario).IsTank() && num2 > 0f)
						{
							FuelRec fuelRec2 = weaponRec.GetWeapon(this.m_Scenario).GetFuelRecs()[0];
							FuelRec fuelRec3 = new FuelRec(0, (short)fuelRec2.FuelType);
							int currentLoad = weaponRec.GetCurrentLoad();
							fuelRec3.CurrentQuantity = fuelRec2.CurrentQuantity * (float)currentLoad;
							fuelRec3.MaxQuantity = fuelRec2.MaxQuantity * currentLoad;
							num = (float)fuelRec3.MaxQuantity - fuelRec3.CurrentQuantity;
							if (num > num2)
							{
								fuelRec3.CurrentQuantity += num2;
								num2 = 0f;
							}
							else
							{
								fuelRec3.CurrentQuantity = (float)fuelRec3.MaxQuantity;
								num2 -= num;
							}
							fuelRec2.CurrentQuantity = fuelRec3.CurrentQuantity / (float)currentLoad;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100371", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x0019600C File Offset: 0x0019420C
		public override void UpdatePropulsionState(float elapsedTime)
		{
			try
			{
				if (this.GetEngines().Where(Aircraft.IsEngineOperational).Count<Engine>() == 0)
				{
					base.LogMessage(this.Name + " (" + this.UnitClass + ")由于没有能够工作的引擎而放弃!", LoggedMessage.MessageType.UnitLost, 0, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
					this.m_Scenario.RemoveUnit(this);
				}
				float num = this.GetFuelConsumption(this.GetThrottle(), null, new float?((float)((int)Math.Round((double)this.GetDesiredSpeed()))), new float?(this.GetCurrentAltitude_ASL(false)), false, false, false, false) * elapsedTime;
				this.ConsumeFuel(num, FuelRec._FuelType.AviationFuel);
				base.ExportFuelConsumed(num, FuelRec._FuelType.AviationFuel);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100372", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool IsPlatform()
		{
			return true;
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x00196124 File Offset: 0x00194324
		public int GetPayloadAndFuelWeight()
		{
			int num = 0;
			if (!Information.IsNothing(this.GetLoadout()))
			{
				num = this.GetLoadout().PayloadWeight;
			}
			int num2 = 0;
			FuelRec[] fuelRecs = this.GetFuelRecs();
			for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
			{
				FuelRec fuelRec = fuelRecs[i];
				num2 += (int)Math.Round((double)fuelRec.CurrentQuantity);
			}
			return num + num2;
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x00196184 File Offset: 0x00194384
		public int GetWeightWith60PercentFuel()
		{
			int num = 0;
			FuelRec[] fuelRecs = this.m_FuelRecs;
			for (int i = 0; i < fuelRecs.Length; i = checked(i + 1))
			{
				FuelRec fuelRec = fuelRecs[i];
				num += (int)Math.Round((double)fuelRec.CurrentQuantity * 0.6);
			}
			return this.WeightEmpty + num;
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x001961D4 File Offset: 0x001943D4
		public float GetWeightFraction()
		{
			float result;
			if (this.GetPayloadAndFuelWeight() == 0)
			{
				result = 0f;
			}
			else
			{
				int num = this.WeightEmpty + this.GetPayloadAndFuelWeight();
				int num2 = this.WeightMax - this.GetWeightWith60PercentFuel();
				float num3 = (float)Math.Min(0.99, (double)(num - this.GetWeightWith60PercentFuel()) / (double)num2);
				if (num3 < 0f)
				{
					num3 = 0f;
				}
				result = num3;
			}
			return result;
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x00196250 File Offset: 0x00194450
		private float GetDamageThresholdToRTB()
		{
			Aircraft._AircraftType type = this.Type;
			float result;
			if (type != Aircraft._AircraftType.Fighter && type != Aircraft._AircraftType.Attack)
			{
				if (type != Aircraft._AircraftType.CAS)
				{
					result = 0.1f;
				}
				else
				{
					result = 0.5f;
				}
			}
			else
			{
				result = 0.3f;
			}
			return result;
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x001962A4 File Offset: 0x001944A4
		public override float GetDamagePts(bool ScenEditAction = false)
		{
			return base.GetDamagePts(ScenEditAction);
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x001962BC File Offset: 0x001944BC
		public override void SetDamagePts(bool ScenEditAction, float value)
		{
			bool flag = value != base.GetDamagePts(false);
			float damagePts = this.GetAircraftDamage().GetDamagePts();
			base.SetDamagePts(ScenEditAction, value);
			float damagePts2 = this.GetAircraftDamage().GetDamagePts();
			if (flag && !ScenEditAction)
			{
				float damageThresholdToRTB = this.GetDamageThresholdToRTB();
				if (damagePts < damageThresholdToRTB * 100f && damagePts2 >= damageThresholdToRTB * 100f && !this.isDestroyed && !base.IsNotActive())
				{
					this.GetAircraftAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.RTB_Group, true, true);
					this.GetAircraftWeaponry().JettisonExternalStores();
				}
			}
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x0019634C File Offset: 0x0019454C
		public override float GetFuelConsumption(ActiveUnit.Throttle throttle_, AltBand altBand_, float? desiredspeed_, float? Altitude, bool bool_32, bool bool_33, bool bool_34, bool bool_35)
		{
			Aircraft.AltBandChecker altBandChecker = new Aircraft.AltBandChecker();
			altBandChecker.altBand = null;
			float num = 0f;
			float result;
			if (this.GetEngines().Count == 0)
			{
				num = 0f;
			}
			else
			{
				try
				{
					IEnumerable<Engine> source = this.GetEngines().Where(Aircraft.IsEngineOperational);
					if (source.Count<Engine>() == 0)
					{
						num = 0f;
					}
					else
					{
						Engine engine = source.ElementAtOrDefault(0);
						if (engine.altBands.Length == 0)
						{
							num = 0f;
						}
						else
						{
							if (Information.IsNothing(altBand_))
							{
								if (!Information.IsNothing(Altitude))
								{
									altBandChecker.altBand = this.GetAircraftKinematics().GetAltBand(Altitude.Value, null);
								}
								else
								{
									altBandChecker.altBand = this.GetAircraftKinematics().vmethod_39();
								}
							}
							else
							{
								altBandChecker.altBand = altBand_;
							}
							if (Information.IsNothing(altBandChecker.altBand))
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								throw new Exception();
							}
							bool flag = false;
							float num2 = 0f;
							float num3;
							switch (throttle_)
							{
							case ActiveUnit.Throttle.FullStop:
								if (!altBandChecker.altBand.Speed_Full.HasValue)
								{
									throw new Exception("Aircraft has full throttle but no full-throttle consumption params exists in database!");
								}
								num3 = altBandChecker.altBand.Consumption_Full.Value;
								flag = true;
								break;
							case ActiveUnit.Throttle.Loiter:
								num3 = altBandChecker.altBand.Consumption_Loiter;
								if (!this.IsRotaryWing(false))
								{
									flag = true;
								}
								else
								{
									num2 = altBandChecker.altBand.Consumption_Full.Value;
								}
								break;
							case ActiveUnit.Throttle.Cruise:
								num3 = altBandChecker.altBand.Consumption_Cruise;
								num2 = altBandChecker.altBand.Consumption_Loiter;
								break;
							case ActiveUnit.Throttle.Full:
								if (altBandChecker.altBand.Speed_Full.HasValue)
								{
									num3 = altBandChecker.altBand.Consumption_Full.Value;
									float arg_1FB_0 = (float)altBandChecker.altBand.Speed_Full.Value;
									num2 = altBandChecker.altBand.Consumption_Cruise;
								}
								else
								{
									if (!bool_35)
									{
										throw new Exception("Aircraft has military throttle but no fuel consumption params exist in database!");
									}
									num3 = altBandChecker.altBand.Consumption_Cruise;
									num2 = altBandChecker.altBand.Consumption_Loiter;
									throttle_ = ActiveUnit.Throttle.Cruise;
								}
								break;
							case ActiveUnit.Throttle.Flank:
								if (altBandChecker.altBand.Speed_Flank.HasValue)
								{
									num3 = altBandChecker.altBand.Consumption_Flank.Value;
									float arg_277_0 = (float)altBandChecker.altBand.Speed_Flank.Value;
									if (altBandChecker.altBand.Speed_Full.HasValue)
									{
										num2 = altBandChecker.altBand.Consumption_Full.Value;
									}
									else
									{
										num2 = altBandChecker.altBand.Consumption_Cruise;
									}
								}
								else
								{
									if (!bool_35)
									{
										throw new Exception("Aircraft has afterburner throttle but no fuel consumption params exist in database!");
									}
									if (altBandChecker.altBand.Speed_Full.HasValue)
									{
										num3 = altBandChecker.altBand.Consumption_Full.Value;
										float arg_2FA_0 = (float)altBandChecker.altBand.Speed_Full.Value;
										num2 = altBandChecker.altBand.Consumption_Cruise;
										throttle_ = ActiveUnit.Throttle.Full;
									}
									else
									{
										num3 = altBandChecker.altBand.Consumption_Cruise;
										num2 = altBandChecker.altBand.Consumption_Loiter;
										throttle_ = ActiveUnit.Throttle.Cruise;
									}
								}
								break;
							default:
								num = 0f;
								result = num;
								return result;
							}
							float num4 = num3;
							if (!Information.IsNothing(desiredspeed_) && !Information.IsNothing(Altitude))
							{
								if (altBandChecker.altBand != this.GetAircraftKinematics().method_11(engine))
								{
									AltBand[] altBands = engine.altBands;
									if (altBands.Length == 0)
									{
										num = 0f;
										result = num;
										return result;
									}
									AltBand altBand = altBands.Where(new Func<AltBand, bool>(altBandChecker.IsHigherAltBand)).OrderBy(Aircraft.MaxAltitudeOfAltBand).ElementAtOrDefault(0);
									if (!Information.IsNothing(altBand))
									{
										float num5 = 0f;
										float num6 = 0f;
										switch (throttle_)
										{
										case ActiveUnit.Throttle.FullStop:
											if (!altBand.Speed_Full.HasValue)
											{
												throw new Exception("Helicopter is at Full Stop throttle but no full-throttle consumption params exists in database!");
											}
											num5 = altBandChecker.altBand.Consumption_Full.Value;
											break;
										case ActiveUnit.Throttle.Loiter:
											num5 = altBand.Consumption_Loiter;
											if (!flag)
											{
												num6 = altBand.Consumption_Full.Value;
											}
											break;
										case ActiveUnit.Throttle.Cruise:
											num5 = altBand.Consumption_Cruise;
											num6 = altBand.Consumption_Loiter;
											break;
										case ActiveUnit.Throttle.Full:
											if (altBand.Speed_Full.HasValue)
											{
												num5 = altBand.Consumption_Full.Value;
												float arg_48B_0 = (float)altBand.Speed_Full.Value;
												num6 = altBand.Consumption_Cruise;
											}
											else
											{
												if (!bool_35)
												{
													throw new Exception("Aircraft has military throttle but no fuel consumption params exist in database!");
												}
												num3 = altBandChecker.altBand.Consumption_Cruise;
												num2 = altBandChecker.altBand.Consumption_Loiter;
												throttle_ = ActiveUnit.Throttle.Cruise;
											}
											break;
										case ActiveUnit.Throttle.Flank:
											if (altBand.Speed_Flank.HasValue)
											{
												num5 = altBand.Consumption_Flank.Value;
												float arg_4F7_0 = (float)altBand.Speed_Flank.Value;
												if (altBand.Speed_Full.HasValue)
												{
													num6 = altBand.Consumption_Full.Value;
												}
												else
												{
													num6 = altBand.Consumption_Cruise;
												}
											}
											else
											{
												if (!bool_35)
												{
													throw new Exception("Aircraft has afterburner throttle but no fuel consumption params exist in database!");
												}
												if (altBandChecker.altBand.Speed_Full.HasValue)
												{
													num3 = altBandChecker.altBand.Consumption_Full.Value;
													float arg_56E_0 = (float)altBandChecker.altBand.Speed_Full.Value;
													num2 = altBandChecker.altBand.Consumption_Cruise;
													throttle_ = ActiveUnit.Throttle.Full;
												}
												else
												{
													num3 = altBandChecker.altBand.Consumption_Cruise;
													num2 = altBandChecker.altBand.Consumption_Loiter;
													throttle_ = ActiveUnit.Throttle.Cruise;
												}
											}
											break;
										default:
											num = 0f;
											result = num;
											return result;
										}
										if (num3 != num5)
										{
											float? num7 = Altitude;
											float minAltitude = altBandChecker.altBand.MinAltitude;
											if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() != minAltitude) : null).GetValueOrDefault())
											{
												float? num8 = Altitude;
												float num9 = altBandChecker.altBand.MinAltitude;
												num8 = (num8.HasValue ? new float?(num8.GetValueOrDefault() - num9) : null);
												num9 = altBandChecker.altBand.MaxAltitude - altBandChecker.altBand.MinAltitude;
												float num10 = (num8.HasValue ? new float?(num8.GetValueOrDefault() / num9) : null).Value;
												num10 = Math.Abs(num10);
												num3 += (num5 - num3) * num10;
												num4 = num3;
												if (!flag)
												{
													num2 += (num6 - num2) * num10;
												}
											}
										}
									}
								}
								if (!flag && (!this.IsRotaryWing(false) || this.GetDesiredSpeed() > (float)this.GetAircraftKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter)))
								{
									float num11 = (float)this.GetAircraftKinematics().GetSpeed(Altitude.Value, throttle_);
									float? num7 = desiredspeed_;
									if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() != num11) : null).GetValueOrDefault())
									{
										float num12 = (float)this.GetAircraftKinematics().GetSpeed(Altitude.Value, (ActiveUnit.Throttle)(throttle_ - ActiveUnit.Throttle.Loiter));
										num7 = desiredspeed_;
										float num13;
										if ((num7.HasValue ? new bool?(num7.GetValueOrDefault() >= num12) : null).GetValueOrDefault())
										{
											float? num8 = desiredspeed_;
											float num9 = num12;
											num8 = (num8.HasValue ? new float?(num8.GetValueOrDefault() - num9) : null);
											num9 = num11 - num12;
											num13 = (num8.HasValue ? new float?(num8.GetValueOrDefault() / num9) : null).Value;
											num13 = Math.Abs(num13);
										}
										else
										{
											num13 = 0f;
										}
										if (num12 == 0f)
										{
											num4 = num2 + (num3 - num2) * num13;
										}
										else
										{
											num4 = num2 + (num3 - num2) * num13;
										}
									}
								}
							}
							if (!Information.IsNothing(this.GetLoadout()))
							{
								float weightDragModifier = this.GetLoadout().WeightDragModifier;
								int payloadWeight = this.GetLoadout().PayloadWeight;
								int num14 = 0;
								if (payloadWeight > 0 && weightDragModifier > 0f)
								{
									if (bool_32 && this.GetLoadout().PayloadWeightDroppable > 0 && !Information.IsNothing(this.GetAssignedMission(false)) && this.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike && !this.GetAircraftAI().IsEscort)
									{
										Strike strike = (Strike)this.GetAssignedMission(false);
										if (strike.Bingo == Mission.Enum60.const_0)
										{
											if (!Information.IsNothing(this.GetLoadout()) && this.GetLoadout().GetMissionProfile(this.m_Scenario).DropBombsAtMaxRange)
											{
												num14 = this.GetLoadout().PayloadWeightDroppable;
											}
										}
										else if (strike.Bingo == Mission.Enum60.const_1)
										{
											num14 = this.GetLoadout().PayloadWeightDroppable;
										}
									}
									if (bool_33 && !Information.IsNothing(this.GetAssignedMission(false)) && this.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike && !this.GetAircraftAI().IsEscort)
									{
										Strike strike2 = (Strike)this.GetAssignedMission(false);
										if (strike2.Bingo == Mission.Enum60.const_0)
										{
											if (!Information.IsNothing(this.GetLoadout()) && this.GetLoadout().GetMissionProfile(this.m_Scenario).DropBombsAtMaxRange)
											{
												num14 = this.GetLoadout().PayloadWeightDroppable;
											}
										}
										else if (strike2.Bingo == Mission.Enum60.const_1)
										{
											num14 = this.GetLoadout().PayloadWeightDroppable;
										}
									}
									if (bool_34 && !Information.IsNothing(this.GetAssignedMission(false)) && this.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike && !this.GetAircraftAI().IsEscort)
									{
										Strike strike3 = (Strike)this.GetAssignedMission(false);
										if (strike3.Bingo == Mission.Enum60.const_0)
										{
											if (!Information.IsNothing(this.GetLoadout()) && this.GetLoadout().GetMissionProfile(this.m_Scenario).DropBombsAtMaxRange)
											{
												num14 = this.GetLoadout().PayloadWeightDroppable;
											}
										}
										else if (strike3.Bingo == Mission.Enum60.const_1)
										{
											num14 = this.GetLoadout().PayloadWeightDroppable;
										}
									}
									float num15 = weightDragModifier * (num4 * (float)(payloadWeight - num14)) / 100f;
									num4 += num15;
								}
							}
							double num16 = (double)this.GetEngines().Where(Aircraft.IsEngineOperational).Count<Engine>() / (double)this.GetEngines().Count;
							num4 = (float)((double)num4 * num16);
							num = num4 / 60f;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100373", "");
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					num = 0f;
					ProjectData.ClearProjectError();
				}
			}
			result = num;
			return result;
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x00196E70 File Offset: 0x00195070
		public static string GetWinchesterString(int DBID, int LoadoutRoleID, Loadout.LoadoutRole loadoutRole_, Scenario scenario_1)
		{
			string text;
			string result;
			if (LoadoutRoleID <= 4002)
			{
				if (LoadoutRoleID <= 2002)
				{
					if (LoadoutRoleID == 2001)
					{
						text = "Winchester: 当任务相关武器消耗完后返回基地。立即脱离战斗。";
						result = text;
						return result;
					}
					if (LoadoutRoleID == 2002)
					{
						if (loadoutRole_ - Loadout.LoadoutRole.Intercept_BVR <= 6)
						{
							text = "Winchester: 当任务相关武器消耗完后返回基地。允许使用空对空航炮接战临机出现目标。";
							result = text;
							return result;
						}
						text = "Winchester: 当任务相关武器消耗完后返回基地。立即脱离战斗。";
						result = text;
						return result;
					}
				}
				else
				{
					switch (LoadoutRoleID)
					{
					case 3001:
						if (loadoutRole_ - Loadout.LoadoutRole.Intercept_BVR <= 6)
						{
							text = "Shotgun: 当所有超视距武器消耗完后返回基地。立即脱离战斗。";
							result = text;
							return result;
						}
						text = "Shotgun: 当所有防区外打击武器消耗完后返回基地。立即脱离战斗。";
						result = text;
						return result;
					case 3002:
						if (loadoutRole_ - Loadout.LoadoutRole.Intercept_BVR <= 6)
						{
							text = "Shotgun: 当所有超视距武器消耗完后返回基地。允许使用视距内武器攻击临机出现的易打目标。 不使用空对空航炮。";
							result = text;
							return result;
						}
						text = "Shotgun: 所有防区外打击武器消耗完后返回基地。允许使用打击武器对临机出现的目标进行攻击。";
						result = text;
						return result;
					case 3003:
						if (loadoutRole_ - Loadout.LoadoutRole.Intercept_BVR <= 6)
						{
							text = "Shotgun: 当所有超视距武器消耗完后返回基地。允许使用视距内武器和空对空航炮攻击临机出现的易打目标。";
							result = text;
							return result;
						}
						text = "Shotgun: 所有防区外打击武器消耗完后返回基地。允许使用打击武器对临机出现的目标进行攻击。";
						result = text;
						return result;
					default:
						if (LoadoutRoleID == 4001)
						{
							text = "Shotgun: 当任务相关武器消耗25%后返回基地。立即脱离战斗。";
							result = text;
							return result;
						}
						if (LoadoutRoleID == 4002)
						{
							text = "Shotgun: 当任务相关武器消耗25%后返回基地。允许使用包括空对空航炮在内的武器对临机出现的目标进行攻击。.";
							result = text;
							return result;
						}
						break;
					}
				}
			}
			else if (LoadoutRoleID <= 4012)
			{
				if (LoadoutRoleID == 4011)
				{
					text = "Shotgun: 当任务相关武器消耗50%后返回基地。立即脱离战斗。";
					result = text;
					return result;
				}
				if (LoadoutRoleID == 4012)
				{
					text = "Shotgun: 当任务相关武器消耗50%后返回基地. 允许使用包括空对空航炮在内的武器对临机出现的目标进行攻击。";
					result = text;
					return result;
				}
			}
			else
			{
				if (LoadoutRoleID == 4021)
				{
					text = "Shotgun: 当任务相关武器消75%后返回基地。立即脱离战斗。";
					result = text;
					return result;
				}
				if (LoadoutRoleID == 4022)
				{
					text = "Shotgun: 当任务相关武器消耗75%后返回基地. 允许使用包括空对空航炮在内的武器对临机出现的目标进行攻击。";
					result = text;
					return result;
				}
				switch (LoadoutRoleID)
				{
				case 5001:
					if (loadoutRole_ - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						text = "Shotgun: 使用超视距武器进行一次格斗以后返回基地。立即脱离战斗。";
						result = text;
						return result;
					}
					text = "Shotgun: 使用防区外打击武器进行一次格斗以后返回基地。立即脱离战斗。";
					result = text;
					return result;
				case 5002:
					if (loadoutRole_ - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						text = "Shotgun: 使用超视距武器进行一次格斗以后返回基地。允许使用视距内武器攻击临机出现的易打目标。 不使用空对空航炮。";
						result = text;
						return result;
					}
					text = "Shotgun: 使用防区外打击武器进行一次格斗以后返回基地。允许使用打击武器对临机出现的目标进行攻击。";
					result = text;
					return result;
				case 5003:
					if (loadoutRole_ - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						text = "Shotgun: 使用超视距武器进行一次格斗以后返回基地。允许使用视距内武器和空对空航炮对临机出现的目标进行攻击。";
						result = text;
						return result;
					}
					text = "Shotgun: 使用防区外武器进行一次格斗后返回基地。允许使用打击武器对临机出现的目标进行攻击。";
					result = text;
					return result;
				case 5005:
					if (loadoutRole_ - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						text = "Shotgun: 使用超视距和视距内武器进行一次格斗后返回基地。不使用空对空航炮。";
						result = text;
						return result;
					}
					text = "Shotgun: 使用防区外和打击武器进行一次格斗后返回基地。";
					result = text;
					return result;
				case 5006:
					if (loadoutRole_ - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						text = "Shotgun: 使用超视距和视距内武器进行一次格斗后返回基地。允许使用空对空航炮对临机出现的目标进行攻击。";
						result = text;
						return result;
					}
					text = "Shotgun: 使用防区外和打击武器进行一次格斗后返回基地。";
					result = text;
					return result;
				case 5011:
					if (loadoutRole_ - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						text = "Shotgun:使用视距内武器进行一次格斗以后返回基地。立即脱离战斗。";
						result = text;
						return result;
					}
					text = "Shotgun:使用打击武器进行一次格斗以后返回基地。立即脱离战斗。";
					result = text;
					return result;
				case 5012:
					if (loadoutRole_ - Loadout.LoadoutRole.Intercept_BVR <= 6)
					{
						text = "Shotgun:使用视距内武器进行一次格斗以后返回基地。允许使用空对空航炮对临机出现的目标进行攻击。";
						result = text;
						return result;
					}
					text = "Shotgun: 使用打击武器进行一次格斗以后返回基地。";
					result = text;
					return result;
				}
			}
			SQLiteConnection sQLiteConnection = scenario_1.GetSQLiteConnection();
			text = DBFunctions.smethod_37(DBID, LoadoutRoleID, ref sQLiteConnection, scenario_1, true, loadoutRole_);
			result = text;
			return result;
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x00197174 File Offset: 0x00195374
		public float GetCargoCrew()
		{
			return this.GetLoadout().Cargo_Crew;
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x00197190 File Offset: 0x00195390
		public float GetCargoArea()
		{
			return this.GetLoadout().Cargo_Area;
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x001971AC File Offset: 0x001953AC
		public _CargoType GetCargoType()
		{
			return this.GetLoadout().Cargo_Type;
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x001971C8 File Offset: 0x001953C8
		public float GetCargoMass()
		{
			return this.GetLoadout().Cargo_Mass;
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x001971E4 File Offset: 0x001953E4
		public override Sensor[] GetNoneMCMSensors()
		{
			Sensor[] result = null;
			checked
			{
				try
				{
					LinkedList<Sensor> linkedList = new LinkedList<Sensor>();
					Sensor[] sensors = this.m_Sensors;
					for (int i = 0; i < sensors.Length; i++)
					{
						Sensor sensor = sensors[i];
						if (!sensor.IsMineCounterMeasure())
						{
							linkedList.AddLast(sensor);
						}
					}
					unchecked
					{
						int num = this.m_Mounts.Length - 1;
						for (int j = 0; j <= num; j++)
						{
							Sensor[] sensors2 = this.m_Mounts[j].GetSensors();
							checked
							{
								for (int k = 0; k < sensors2.Length; k++)
								{
									Sensor value = sensors2[k];
									linkedList.AddLast(value);
								}
							}
						}
					}
					if (!Information.IsNothing(this.GetLoadout()))
					{
						Sensor[] poddedSensors = this.GetLoadout().GetPoddedSensors(this.m_Scenario);
						for (int l = 0; l < poddedSensors.Length; l++)
						{
							Sensor value2 = poddedSensors[l];
							linkedList.AddLast(value2);
						}
						HashSet<int> hashSet = new HashSet<int>();
						if (!Information.IsNothing(this.GetLoadout().WeaponRecArray))
						{
							WeaponRec[] weaponRecArray = this.GetLoadout().WeaponRecArray;
							for (int m = 0; m < weaponRecArray.Length; m++)
							{
								WeaponRec weaponRec = weaponRecArray[m];
								if (weaponRec.GetCurrentLoad() > 0)
								{
									Weapon weapon = weaponRec.GetWeapon(this.m_Scenario);
									if (weapon.CanActAsSensor || weapon.GetWeaponType() == Weapon._WeaponType.HeliTowedPackage)
									{
										Sensor[] noneMCMSensors = weapon.GetNoneMCMSensors();
										for (int n = 0; n < noneMCMSensors.Length; n++)
										{
											Sensor sensor2 = noneMCMSensors[n];
											if (weapon.GetWeaponType() == Weapon._WeaponType.SensorPod || weapon.GetWeaponType() == Weapon._WeaponType.HeliTowedPackage)
											{
												linkedList.AddLast(sensor2);
											}
											else if (!hashSet.Contains(sensor2.DBID))
											{
												hashSet.Add(sensor2.DBID);
												linkedList.AddLast(sensor2);
												if (sensor2.GetScanInterval() < 10)
												{
													sensor2.SetScanInterval(10);
												}
											}
										}
									}
								}
							}
						}
					}
					int count = linkedList.Count;
					Sensor[] array;
					Sensor[] array2;
					unchecked
					{
						array = new Sensor[count - 1 + 1];
						int num2 = count - 1;
						for (int num3 = 0; num3 <= num2; num3++)
						{
							array[num3] = linkedList.ElementAtOrDefault(num3);
						}
						array2 = array;
					}
					for (int num4 = 0; num4 < array2.Length; num4++)
					{
					}
					result = array;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101185", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x001974AC File Offset: 0x001956AC
		[CompilerGenerated]
		private double GetAngularDistance(Aircraft aircraft_0)
		{
			return base.GetApproxAngularDistanceInDegrees(aircraft_0);
		}

		// Token: 0x04001FC9 RID: 8137
		public static Func<Engine, bool> IsEngineOperational = (Engine engine_0) => engine_0.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational;

		// Token: 0x04001FCA RID: 8138
		public static Func<AltBand, float> MaxAltitudeOfAltBand = (AltBand altBand_0) => altBand_0.MaxAltitude;

		// Token: 0x04001FCB RID: 8139
		public float Agility;

		// Token: 0x04001FCC RID: 8140
		public Aircraft._AircraftType Type;

		// Token: 0x04001FCD RID: 8141
		public Aircraft._AircraftCategory Category;

		// Token: 0x04001FCE RID: 8142
		public Aircraft._AircraftCode AircraftCode;

		// Token: 0x04001FCF RID: 8143
		public int TotalEndurance;

		// Token: 0x04001FD0 RID: 8144
		public float AbnTime;

		// Token: 0x04001FD1 RID: 8145
		public float Length;

		// Token: 0x04001FD2 RID: 8146
		public float Span;

		// Token: 0x04001FD3 RID: 8147
		public float Height;

		// Token: 0x04001FD4 RID: 8148
		private Loadout m_Loadout;

		// Token: 0x04001FD5 RID: 8149
		internal float FuelOffloadRate;

		// Token: 0x04001FD6 RID: 8150
		public GlobalVariables.ArmorRating AircraftCockpitArmor;

		// Token: 0x04001FD7 RID: 8151
		public GlobalVariables.ArmorRating AircraftFuselageArmor;

		// Token: 0x04001FD8 RID: 8152
		public GlobalVariables.ArmorRating AircraftEngineArmor;

		// Token: 0x04001FD9 RID: 8153
		public bool ProbeRefuelling;

		// Token: 0x04001FDA RID: 8154
		public bool BoomRefuelling;

		// Token: 0x04001FDB RID: 8155
		public bool CenterlineDrogue;

		// Token: 0x04001FDC RID: 8156
		public bool WingDrogue;

		// Token: 0x04001FDD RID: 8157
		public bool CenterlineBoom;

		// Token: 0x04001FDE RID: 8158
		private bool TerrainAvoidance;

		// Token: 0x04001FDF RID: 8159
		private bool terrainFollowing;

		// Token: 0x04001FE0 RID: 8160
		private bool TerrainFollowing;

		// Token: 0x04001FE1 RID: 8161
		public bool HIFRCapable;

		// Token: 0x04001FE2 RID: 8162
		public bool FlyByWire;

		// Token: 0x04001FE3 RID: 8163
		public bool BlipEnhance;

		// Token: 0x04001FE4 RID: 8164
		public bool HMD;

		// Token: 0x04001FE5 RID: 8165
		public GlobalVariables.AircraftSizeClass aircraftSizeClass;

		// Token: 0x04001FE6 RID: 8166
		public GlobalVariables._RunwayLengthCode RunwayLengthCode;

		// Token: 0x04001FE7 RID: 8167
		public Aircraft._Bombsight Bombsight;

		// Token: 0x04001FE8 RID: 8168
		public bool Supermanouverability;

		// Token: 0x04001FE9 RID: 8169
		public bool NightNavigation;

		// Token: 0x04001FEA RID: 8170
		public bool NightNavigationAndAttack;

		// Token: 0x04001FEB RID: 8171
		private double Longitude = 0.0;

		// Token: 0x04001FEC RID: 8172
		private double Latitude = 0.0;

		// Token: 0x04001FED RID: 8173
		public float DistanceToA2ARefuelingDestinationAircraft;

		// Token: 0x04001FEE RID: 8174
		public ActiveUnit A2ARefuelingDestinationAircraft;

		// Token: 0x04001FEF RID: 8175
		public float FuelQuantityLeftToBingo;

		// Token: 0x04001FF0 RID: 8176
		public float FuelQuantityLeftToJoker;

		// Token: 0x04001FF1 RID: 8177
		public Aircraft._CockpitVisibilityLevel ForwardCockpitVisibilityLevel;

		// Token: 0x04001FF2 RID: 8178
		public Aircraft._CockpitVisibilityLevel SidewaysCockpitVisibilityLevel;

		// Token: 0x04001FF3 RID: 8179
		public Aircraft._CockpitVisibilityLevel AftCockpitVisibilityLevel;

		// Token: 0x04001FF4 RID: 8180
		private Aircraft_Navigator aircraft_Navigator;

		// Token: 0x04001FF5 RID: 8181
		private Aircraft_AI aircraft_AI;

		// Token: 0x04001FF6 RID: 8182
		private Aircraft_Kinematics aircraft_Kinematics;

		// Token: 0x04001FF7 RID: 8183
		private Aircraft_Sensory aircraft_Sensory;

		// Token: 0x04001FF8 RID: 8184
		private Aircraft_Weaponry aircraft_Weaponry;

		// Token: 0x04001FF9 RID: 8185
		private Aircraft_CommStuff aircraft_CommStuff;

		// Token: 0x04001FFA RID: 8186
		private Aircraft_Damage aircraft_Damage;

		// Token: 0x04001FFB RID: 8187
		private Aircraft_AirOps aircraft_AirOps;

		// Token: 0x04001FFC RID: 8188
		private static Scenario scenario = null;

		// Token: 0x020009CE RID: 2510
		public enum _CockpitVisibilityLevel
		{
			// Token: 0x04002000 RID: 8192
			None,
			// Token: 0x04002001 RID: 8193
			Excellent,
			// Token: 0x04002002 RID: 8194
			Average,
			// Token: 0x04002003 RID: 8195
			Poor
		}

		// Token: 0x020009CF RID: 2511
		public enum _Bombsight : byte
		{
			// Token: 0x04002005 RID: 8197
			BasicTech,
			// Token: 0x04002006 RID: 8198
			BallisticTech,
			// Token: 0x04002007 RID: 8199
			ComputingTech,
			// Token: 0x04002008 RID: 8200
			AdvancedTech
		}

		// 飞机分类
		public enum _AircraftCategory : short
		{

			// 未知
			None = 1001,

			// 固定翼
			FixedWing = 2001,
			// Token: 0x0400200C RID: 8204
			FixedWing_CarrierCapable,

			// 直升机
			Helicopter,

			// 倾转旋翼机
			Tiltrotor,
			// Token: 0x0400200F RID: 8207
			const_5,

			// 飞艇
			Airship,

			// 水上飞机
			Seaplane,
			// 水陆两栖飞行器
			Amphibian
		}

		// Token: 0x020009D1 RID: 2513
		public enum _AircraftCode
		{
			// Token: 0x04002014 RID: 8212
			None,
			// Token: 0x04002015 RID: 8213
			FuselageStructure_Low_Subsonic_Fighter = 9101,
			// Token: 0x04002016 RID: 8214
			FuselageStructure_High_Subsonic_Fighter,
			// Token: 0x04002017 RID: 8215
			FuselageStructure_Low_Supersonic_Fighter,
			// Token: 0x04002018 RID: 8216
			FuselageStructure_High_Supersonic_Fighter,
			// Token: 0x04002019 RID: 8217
			FuselageStructure_Low_Subsonic_AttackAircraft = 9111,
			// Token: 0x0400201A RID: 8218
			FuselageStructure_High_Subsonic_AttackAircraft,
			// Token: 0x0400201B RID: 8219
			FuselageStructure_Low_Supersonic_AttackAircraft,
			// Token: 0x0400201C RID: 8220
			FuselageStructure_High_Supersonic_AttackAircraft,
			// Token: 0x0400201D RID: 8221
			FuselageStructure_Low_Subsonic_Bomber = 9121,
			// Token: 0x0400201E RID: 8222
			FuselageStructure_High_Subsonic_Bomber,
			// Token: 0x0400201F RID: 8223
			FuselageStructure_Low_Supersonic_Bomber,
			// Token: 0x04002020 RID: 8224
			FuselageStructure_High_Supersonic_Bomber,
			// Token: 0x04002021 RID: 8225
			FuselageStructure_HighAltitude_SlowSpeed_Recon = 9185,
			// Token: 0x04002022 RID: 8226
			FuselageStructure_HighAltitude_HighSpeed_Recon,
			// Token: 0x04002023 RID: 8227
			FuselageStructure_Low_Subsonic_CivilianStandards = 9191,
			// Token: 0x04002024 RID: 8228
			FuselageStructure_High_Subsonic_CivilianStandards,
			// Token: 0x04002025 RID: 8229
			FuselageStructure_Airship = 9199
		}

		// Token: 0x020009D2 RID: 2514
		public enum _AircraftType
		{
			// Token: 0x04002027 RID: 8231
			None = 1001,
			// 战斗机
			Fighter = 2001,
			// 多用途飞机
			Multirole,
			// Token: 0x0400202A RID: 8234
			ASAT = 2101,
			// 机载激光平台
			AirborneLaserPlatform,
			// Token: 0x0400202C RID: 8236
			Attack = 3001,
			// 野鼬鼠，反雷达飞机
			WildWeasel,
			// 轰炸机
			Bomber = 3101,
			// Token: 0x0400202F RID: 8239
			CAS = 3401,
			// 自卫干扰飞机？？
			OECM = 4001,
			// 预警机
			AEW,
			// Token: 0x04002032 RID: 8242
			AirborneCP,
	        // 搜救飞机？
	        SAR = 4101,
			// 反水雷
			MCM = 4201,
			// 反水面舰艇
			ASW = 6001,
			// Token: 0x04002036 RID: 8246
			MPA,
			// Token: 0x04002037 RID: 8247
			ForwardObserver = 7001,
			// Token: 0x04002038 RID: 8248
			AreaSurveillance,

			// 侦查机
			Recon,
			// Token: 0x0400203A RID: 8250
			ELINT,
			// Token: 0x0400203B RID: 8251
			SIGINT,
			// Token: 0x0400203C RID: 8252
			Transport = 7101,
			// Token: 0x0400203D RID: 8253
			Cargo = 7201,

			// 商业飞机
			Commercial = 7301,
			// Token: 0x0400203F RID: 8255
			Civilian,
			// Token: 0x04002040 RID: 8256
			Utility = 7401,
			// Token: 0x04002041 RID: 8257
			Utility_Naval,

			// 加油机
			Tanker = 8001,
		// Token: 0x04002043 RID: 8259
			// 教练机
			Trainer = 8101,
			// Token: 0x04002044 RID: 8260
			TargetTowing,
			// Token: 0x04002045 RID: 8261
			TargetDrone,

			// 无人机
			UAV = 8201,
			// Token: 0x04002047 RID: 8263
			UCAV,

			// 飞艇
			AirShip = 8901,
			// Token: 0x04002049 RID: 8265
			Aerostat,
			// Token: 0x0400204A RID: 8266
			IMGSAT = 9001,
			// Token: 0x0400204B RID: 8267
			RORSAT,
			// Token: 0x0400204C RID: 8268
			EORSAT
		}

		// Token: 0x020009D3 RID: 2515
		[CompilerGenerated]
		public sealed class AltBandChecker
		{
			// Token: 0x06004451 RID: 17489 RVA: 0x00021FB8 File Offset: 0x000201B8
			internal bool IsHigherAltBand(AltBand altBand_)
			{
				return altBand_.MinAltitude >= this.altBand.MaxAltitude;
			}

			// Token: 0x0400204D RID: 8269
			public AltBand altBand;
		}
	}
}

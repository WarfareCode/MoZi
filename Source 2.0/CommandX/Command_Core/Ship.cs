using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
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
	// Token: 舰船
	public sealed class Ship : Platform, ICargo
	{
		// Token: 0x06006018 RID: 24600 RVA: 0x002D8EAC File Offset: 0x002D70AC
		private Ship() : base(ref Ship.scenario, null)
		{
			this.ShipCode = default(Ship._ShipCode);
			this.m_Rudder = new Rudder(this);
			this.m_CommandPost = new CIC(this, "Bridge / CIC");
			this.IsShip = true;
		}

		// Token: 0x06006019 RID: 24601 RVA: 0x002D8F24 File Offset: 0x002D7124
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					if (!Information.IsNothing(this.GetSide(false)))
					{
						xmlWriter_0.WriteStartElement("Ship");
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
							xmlWriter_0.WriteElementString("Lon", XmlConvert.ToString(this.GetLongitude(null)));
							xmlWriter_0.WriteElementString("Lat", XmlConvert.ToString(this.GetLatitude(null)));
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
							if (!Information.IsNothing(this.m_ProficiencyLevel))
							{
								xmlWriter_0.WriteElementString("Prof", ((int)this.m_ProficiencyLevel.Value).ToString());
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
							xmlWriter_0.WriteElementString("TS", ((byte)this.GetThrottle()).ToString());
							xmlWriter_0.WriteStartElement("Sensors");
							Sensor[] sensors = this.m_Sensors;
							for (int i = 0; i < sensors.Length; i++)
							{
								sensors[i].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
							}
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Comms");
							CommDevice[] commDevices = this.m_CommDevices;
							for (int j = 0; j < commDevices.Length; j++)
							{
								commDevices[j].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
							}
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Propulsion");
							using (IEnumerator<Engine> enumerator2 = this.GetEngines().GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									enumerator2.Current.Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
								}
							}
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Fuel");
							FuelRec[] fuelRecs = this.m_FuelRecs;
							for (int k = 0; k < fuelRecs.Length; k++)
							{
								fuelRecs[k].Save(ref xmlWriter_0);
							}
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Mounts");
							Mount[] mounts = this.m_Mounts;
							for (int l = 0; l < mounts.Length; l++)
							{
								Mount mount = mounts[l];
								if (Information.IsNothing(mount.GetParentPlatform()))
								{
									mount.SetParentPlatform(this);
								}
								mount.Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
							}
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Magazines");
							Magazine[] magazines = this.m_Magazines;
							for (int m = 0; m < magazines.Length; m++)
							{
								magazines[m].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
							}
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("OnboardCargo");
							Cargo[] onboardCargos = this.m_OnboardCargos;
							for (int n = 0; n < onboardCargos.Length; n++)
							{
								onboardCargos[n].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
							}
							xmlWriter_0.WriteEndElement();
							XmlWriter xmlWriter = xmlWriter_0;
							string localName = "Status";
							byte b = (byte)this.activeUnitStatus;
							xmlWriter.WriteElementString(localName, b.ToString());
							XmlWriter xmlWriter2 = xmlWriter_0;
							string localName2 = "FuelState";
							b = (byte)this.activeUnitFuelState;
							xmlWriter2.WriteElementString(localName2, b.ToString());
							XmlWriter xmlWriter3 = xmlWriter_0;
							string localName3 = "WeaponState";
							b = (byte)this.weaponState;
							xmlWriter3.WriteElementString(localName3, b.ToString());
							XmlWriter xmlWriter4 = xmlWriter_0;
							string localName4 = "SBR";
							b = (byte)this.SBR;
							xmlWriter4.WriteElementString(localName4, b.ToString());
							XmlWriter xmlWriter5 = xmlWriter_0;
							string localName5 = "SBED";
							b = (byte)this.SBEngagedDefensive;
							xmlWriter5.WriteElementString(localName5, b.ToString());
							XmlWriter xmlWriter6 = xmlWriter_0;
							string localName6 = "SBEO";
							b = (byte)this.SBEngagedOffensive;
							xmlWriter6.WriteElementString(localName6, b.ToString());
							XmlWriter xmlWriter7 = xmlWriter_0;
							string localName7 = "FSBR";
							b = (byte)this.FuelStateBR;
							xmlWriter7.WriteElementString(localName7, b.ToString());
							xmlWriter_0.WriteElementString("SBR_Altitude", XmlConvert.ToString(this.SBR_Altitude));
							xmlWriter_0.WriteElementString("SBR_Altitude_TF", XmlConvert.ToString(this.SBR_Altitude_TerrainFollowing));
							xmlWriter_0.WriteElementString("SBR_TF", XmlConvert.ToString(this.SBR_TerrainFollowing));
							XmlWriter xmlWriter8 = xmlWriter_0;
							string localName8 = "SBR_ThrottleSetting";
							b = (byte)this.SBR_ThrottleSetting;
							xmlWriter8.WriteElementString(localName8, b.ToString());
							xmlWriter_0.WriteElementString("SBED_Altitude", XmlConvert.ToString(this.SBEngagedDefensive_Altitude));
							xmlWriter_0.WriteElementString("SBED_Altitude_TF", XmlConvert.ToString(this.SBEngagedDefensive_Altitude_TerrainFollowing));
							xmlWriter_0.WriteElementString("SBED_TF", XmlConvert.ToString(this.SBEngagedDefensive_TerrainFollowing));
							XmlWriter xmlWriter9 = xmlWriter_0;
							string localName9 = "SBED_ThrottleSetting";
							b = (byte)this.SBEngagedDefensive_ThrottleSetting;
							xmlWriter9.WriteElementString(localName9, b.ToString());
							xmlWriter_0.WriteElementString("SBEO_Altitude", XmlConvert.ToString(this.SBEngagedOffensive_Altitude));
							xmlWriter_0.WriteElementString("SBEO_Altitude_TF", XmlConvert.ToString(this.SBEngagedOffensive_Altitude_TerrainFollowing));
							xmlWriter_0.WriteElementString("SBEO_TF", XmlConvert.ToString(this.SBEngagedOffensive_TerrainFollowing));
							XmlWriter xmlWriter10 = xmlWriter_0;
							string localName10 = "SBEO_ThrottleSetting";
							b = (byte)this.SBEngagedOffensive_ThrottleSetting;
							xmlWriter10.WriteElementString(localName10, b.ToString());
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
							if (this.DEC)
							{
								xmlWriter_0.WriteElementString("DEC", this.DEC.ToString());
							}
							this.m_Doctrine.Save(ref xmlWriter_0, ref this.m_Scenario, "Doctrine");
							xmlWriter_0.WriteStartElement("Rudder");
							this.m_Rudder.Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("CIC");
							this.m_CommandPost.Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
							xmlWriter_0.WriteEndElement();
							this.GetShipNavigator().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteStartElement("Ship_AI");
							if (Information.IsNothing(this.GetShipAI().m_ActiveUnit))
							{
								this.GetShipAI().m_ActiveUnit = this;
							}
							this.GetShipAI().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Ship_Kinematics");
							this.GetShipKinematics().Save(ref xmlWriter_0);
							xmlWriter_0.WriteEndElement();
							this.GetShipSensory().Save(ref xmlWriter_0);
							this.GetShipWeaponry().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteStartElement("Ship_CommStuff");
							this.GetShipCommStuff().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteEndElement();
							this.GetShipDamage().Save(ref xmlWriter_0);
							this.GetAirOps().Save(ref xmlWriter_0, ref hashSet_0);
							this.GetDockingOps().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteEndElement();
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100761", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600601A RID: 24602 RVA: 0x002D99C8 File Offset: 0x002D7BC8
		public static Ship smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_1)
		{
			Ship ship;
			try
			{
				ship = Ship.smethod_2(ref xmlNode_0, ref dictionary_0, ref scenario_1, scenario_1.LoadStockUnits);
			}
			catch (Exception0 projectError)
			{
				ProjectData.SetProjectError(projectError);
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				dictionary_0.Remove(innerText);
				ship = Ship.smethod_2(ref xmlNode_0, ref dictionary_0, ref scenario_1, true);
				string text = "";
				if (ship.HasParentGroup())
				{
					text = "(member of group: [" + ship.GetParentGroup(false).Name + "])";
				}
				scenario_1.LoadingNotices.Add(string.Concat(new string[]
				{
					"The following ship:[",
					ship.Name,
					"]",
					text,
					" failed to shallow-rebuild because of a component missing. The ship was instead deep-rebuilt, and instantiated in its pristine DB-stock condition. All customizations present in the ship's components (damaged components, weapon additions/removals etc. etc.) have been lost. Please re-apply any necessary customizations either manually or using an SBR script."
				}));
				ProjectData.ClearProjectError();
			}
			return ship;
		}

		// Token: 0x0600601B RID: 24603 RVA: 0x002D9AAC File Offset: 0x002D7CAC
		private static Ship smethod_2(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_1, bool bool_17)
		{
			Ship ship = null;
			Ship result;
			try
			{
				Ship ship2 = new Ship();
				ship2.m_Scenario = scenario_1;
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					ship = (Ship)dictionary_0[innerText];
				}
				else
				{
					ship2.SetGuid(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						ship = ship2;
					}
					else
					{
						dictionary_0.Add(ship2.GetGuid(), ship2);
						int num = Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "DBID").InnerText);
						try
						{
							DBFunctions.smethod_51(ref scenario_1, ref ship2, num, bool_17);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							dictionary_0.Remove(ship2.GetGuid());
							scenario_1.LoadingNotices.Add("Ship with Database ID " + Conversions.ToString(num) + " is missing from the database and has not been loaded.");
							ship = null;
							ProjectData.ClearProjectError();
							result = ship;
							return result;
						}
						if (bool_17)
						{
							ship2.LoadAirFacilities(ref xmlNode_0, ref dictionary_0, ref scenario_1);
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
									uint num2 = Class382.smethod_0(name);
									if (num2 <= 2241118125u)
									{
										if (num2 <= 1717708934u)
										{
											if (num2 != 1305748348u)
											{
												if (num2 == 1717708934u && Operators.CompareString(name, "CIC", false) == 0)
												{
													ship2.m_CommandPost = CIC.Load(ref xmlNode, ref dictionary_0);
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
														XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
														Cargo cargo = Cargo.Load(ref xmlNode2, ref dictionary_0, ship2);
														ScenarioArrayUtil.AddCargo(ref ship2.m_OnboardCargos, cargo);
														cargo.SetParentPlatform(ship2);
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
										if (num2 != 2008421230u)
										{
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
														XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
														FuelRec fuelRec_ = FuelRec.Load(ref xmlNode3, ref dictionary_0);
														ScenarioArrayUtil.AddFuelRec(ref ship2.m_FuelRecs, fuelRec_);
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
													XmlNode xmlNode4 = (XmlNode)enumerator4.Current;
													DockFacility dockFacility = DockFacility.Load(ref xmlNode4, ref dictionary_0, ref scenario_1);
													ship2.AddDockFacility(dockFacility);
													dockFacility.SetParentPlatform(ship2);
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
										if (Operators.CompareString(name, "Comms", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator5 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator5.MoveNext())
											{
												XmlNode xmlNode5 = (XmlNode)enumerator5.Current;
												CommDevice commDevice = CommDevice.Load(ref xmlNode5, ref dictionary_0, ship2);
												ship2.AddCommDevice(commDevice);
												commDevice.SetParentPlatform(ship2);
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
									if (num2 <= 3109521583u)
									{
										if (num2 != 2246682072u)
										{
											if (num2 != 2424405304u)
											{
												if (num2 == 3109521583u && Operators.CompareString(name, "Rudder", false) == 0)
												{
													ship2.m_Rudder = Rudder.Load(ref xmlNode, ref dictionary_0);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "Sensors", false) != 0)
												{
													continue;
												}
												IEnumerator enumerator6 = xmlNode.ChildNodes.GetEnumerator();
												try
												{
													while (enumerator6.MoveNext())
													{
														Sensor sensor = Sensor.Load((XmlNode)enumerator6.Current, dictionary_0, ship2);
														ScenarioArrayUtil.AddSensor(ref ship2.m_Sensors, sensor);
														sensor.SetParentPlatform(ship2);
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
										if (Operators.CompareString(name, "Propulsion", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator7 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator7.MoveNext())
											{
												XmlNode xmlNode6 = (XmlNode)enumerator7.Current;
												ActiveUnit activeUnit = ship2;
												Engine engine = Engine.Load(ref xmlNode6, ref dictionary_0, ref activeUnit);
												ship2.GetEngines().Add(engine);
												engine.SetParentPlatform(ship2);
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
									if (num2 != 3760177291u)
									{
										if (num2 != 3847206928u)
										{
											if (num2 != 3989581338u || Operators.CompareString(name, "AirFacilities", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator8 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator8.MoveNext())
												{
													XmlNode xmlNode7 = (XmlNode)enumerator8.Current;
													AirFacility airFacility = AirFacility.Load(ref xmlNode7, ref dictionary_0, ref scenario_1);
													ship2.AddAirFacility(airFacility);
													airFacility.SetParentPlatform(ship2);
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
										if (Operators.CompareString(name, "Magazines", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator9 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator9.MoveNext())
											{
												XmlNode xmlNode8 = (XmlNode)enumerator9.Current;
												Magazine magazine = Magazine.smethod_2(ref xmlNode8, ref dictionary_0, ref scenario_1);
												ScenarioArrayUtil.AddMagazine(ref ship2.m_Magazines, magazine);
												magazine.SetParentPlatform(ship2);
											}
											continue;
										}
										finally
										{
											if (enumerator9 is IDisposable)
											{
												(enumerator9 as IDisposable).Dispose();
											}
										}
									}
									if (Operators.CompareString(name, "Mounts", false) == 0)
									{
										IEnumerator enumerator10 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator10.MoveNext())
											{
												XmlNode xmlNode9 = (XmlNode)enumerator10.Current;
												Mount mount = Mount.Load(ref xmlNode9, ref dictionary_0, ship2);
												ScenarioArrayUtil.AddMount(ref ship2.m_Mounts, mount);
												mount.SetParentPlatform(ship2);
											}
										}
										finally
										{
											if (enumerator10 is IDisposable)
											{
												(enumerator10 as IDisposable).Dispose();
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
						IEnumerator enumerator11 = xmlNode_0.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator11.MoveNext())
							{
								XmlNode xmlNode10 = (XmlNode)enumerator11.Current;
								string name2 = xmlNode10.Name;
								uint num2 = Class382.smethod_0(name2);
								ActiveUnit activeUnit = null;
								if (num2 > 1729717486u)
								{
									if (num2 <= 2923116889u)
									{
										if (num2 <= 2323739590u)
										{
											if (num2 <= 2010780873u)
											{
												if (num2 <= 1836990821u)
												{
													if (num2 != 1738278884u)
													{
														if (num2 != 1836990821u)
														{
															continue;
														}
														if (Operators.CompareString(name2, "Latitude", false) != 0)
														{
															continue;
														}
													}
													else
													{
														if (Operators.CompareString(name2, "SBED_TF", false) == 0)
														{
															ship2.SBEngagedDefensive_TerrainFollowing = Conversions.ToBoolean(xmlNode10.InnerText);
															continue;
														}
														continue;
													}
												}
												else if (num2 != 1992083866u)
												{
													if (num2 == 2010780873u && Operators.CompareString(name2, "CA", false) == 0)
													{
														goto IL_133A;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Latitude_UnitEntersAreaCheck", false) == 0)
													{
														ship2.SetLatitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode10.InnerText)));
														continue;
													}
													continue;
												}
											}
											else if (num2 <= 2128224206u)
											{
												if (num2 != 2066337159u)
												{
													if (num2 != 2128224206u)
													{
														continue;
													}
													if (Operators.CompareString(name2, "CH", false) != 0)
													{
														continue;
													}
													goto IL_1091;
												}
												else
												{
													if (Operators.CompareString(name2, "DesiredAltitude", false) == 0)
													{
														goto IL_168B;
													}
													continue;
												}
											}
											else if (num2 != 2247649009u)
											{
												if (num2 == 2323739590u && Operators.CompareString(name2, "Sensory", false) == 0)
												{
													goto IL_116E;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "AssignedMission", false) == 0 && xmlNode10.HasChildNodes)
												{
													XmlNode xmlNode11 = xmlNode10.ChildNodes[0];
													ship2.AssignedMissionName = xmlNode11.InnerText;
													continue;
												}
												continue;
											}
										}
										else if (num2 <= 2749693904u)
										{
											if (num2 <= 2564648390u)
											{
												if (num2 != 2496321123u)
												{
													if (num2 == 2564648390u && Operators.CompareString(name2, "Lon", false) == 0)
													{
														goto IL_1ABF;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "RangeSymbols", false) != 0)
													{
														continue;
													}
													IEnumerator enumerator12 = xmlNode10.ChildNodes.GetEnumerator();
													try
													{
														while (enumerator12.MoveNext())
														{
															RangeSymbol item = RangeSymbol.Load((XmlNode)enumerator12.Current, dictionary_0);
															ship2.GetRangeSymbols().Add(item);
														}
														continue;
													}
													finally
													{
														if (enumerator12 is IDisposable)
														{
															(enumerator12 as IDisposable).Dispose();
														}
													}
												}
											}
											if (num2 != 2590053246u)
											{
												if (num2 == 2749693904u && Operators.CompareString(name2, "DesiredSpeed", false) == 0)
												{
													goto IL_144E;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Side", false) == 0)
												{
													ship2.strSide = xmlNode10.InnerText;
													continue;
												}
												continue;
											}
										}
										else if (num2 <= 2874698282u)
										{
											if (num2 != 2844845263u)
											{
												if (num2 == 2874698282u && Operators.CompareString(name2, "AssignedTaskPool", false) == 0 && xmlNode10.HasChildNodes)
												{
													XmlNode xmlNode12 = xmlNode10.ChildNodes[0];
													ship2.AssignedTaskPoolName = xmlNode12.InnerText;
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBEO_Altitude", false) == 0)
												{
													ship2.SBEngagedOffensive_Altitude = XmlConvert.ToSingle(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 2904824734u)
										{
											if (num2 != 2920208772u)
											{
												if (num2 != 2923116889u || Operators.CompareString(name2, "SBR_ThrottleSetting", false) != 0)
												{
													continue;
												}
												string innerText2 = xmlNode10.InnerText;
												if (Operators.CompareString(innerText2, "FullStop", false) == 0)
												{
													ship2.SBR_ThrottleSetting = ActiveUnit.Throttle.FullStop;
													continue;
												}
												if (Operators.CompareString(innerText2, "Loiter", false) == 0)
												{
													ship2.SBR_ThrottleSetting = ActiveUnit.Throttle.Loiter;
													continue;
												}
												if (Operators.CompareString(innerText2, "Cruise", false) == 0)
												{
													ship2.SBR_ThrottleSetting = ActiveUnit.Throttle.Cruise;
													continue;
												}
												if (Operators.CompareString(innerText2, "Full", false) == 0)
												{
													ship2.SBR_ThrottleSetting = ActiveUnit.Throttle.Full;
													continue;
												}
												if (Operators.CompareString(innerText2, "Flank", false) != 0)
												{
													ship2.SBR_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
													continue;
												}
												ship2.SBR_ThrottleSetting = ActiveUnit.Throttle.Flank;
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Message", false) == 0)
												{
													ship2.Message = xmlNode10.InnerText;
													continue;
												}
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "SBEO_Altitude_TF", false) == 0)
											{
												ship2.SBEngagedOffensive_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 3251319825u)
									{
										if (num2 <= 3070770765u)
										{
											if (num2 <= 3020647921u)
											{
												if (num2 != 3001749054u)
												{
													if (num2 == 3020647921u && Operators.CompareString(name2, "ActiveUnit_DockingOps", false) == 0)
													{
														ActiveUnit activeUnit2 = ship2;
														activeUnit = ship2;
														((Ship)activeUnit2).m_DockingOps = ActiveUnit_DockingOps.Load(ref xmlNode10, ref dictionary_0, ref activeUnit);
														continue;
													}
													continue;
												}
												else if (Operators.CompareString(name2, "Lat", false) != 0)
												{
													continue;
												}
											}
											else if (num2 != 3045369646u)
											{
												if (num2 == 3070770765u && Operators.CompareString(name2, "SBR_Altitude", false) == 0)
												{
													ship2.SBR_Altitude = XmlConvert.ToSingle(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Ship_AI", false) == 0)
												{
													Ship ship3 = ship2;
													activeUnit = ship2;
													ship3.ship_AI = Ship_AI.Load(ref xmlNode10, ref dictionary_0, ref activeUnit);
													continue;
												}
												continue;
											}
										}
										else if (num2 <= 3189373444u)
										{
											if (num2 != 3137208970u)
											{
												if (num2 == 3189373444u && Operators.CompareString(name2, "LonLR", false) == 0)
												{
													ship2.SetLongitudeLR(new double?(XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", "."))));
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Ship_Kinematics", false) == 0)
												{
													ActiveUnit_Kinematics.Load(xmlNode10, dictionary_0, ship2);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 3204468496u)
										{
											if (num2 == 3251319825u && Operators.CompareString(name2, "SBR_TF", false) == 0)
											{
												ship2.SBR_TerrainFollowing = Conversions.ToBoolean(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SBEO", false) == 0)
											{
												ship2.SBEngagedOffensive = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 3559367371u)
									{
										if (num2 <= 3370184216u)
										{
											if (num2 != 3283119613u)
											{
												if (num2 == 3370184216u && Operators.CompareString(name2, "DesiredTurnRate", false) == 0)
												{
													goto IL_1584;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "CurrentSpeed", false) == 0)
												{
													goto IL_1AFE;
												}
												continue;
											}
										}
										else if (num2 != 3389022305u)
										{
											if (num2 != 3559367371u || Operators.CompareString(name2, "SBEO_ThrottleSetting", false) != 0)
											{
												continue;
											}
											string innerText3 = xmlNode10.InnerText;
											if (Operators.CompareString(innerText3, "FullStop", false) == 0)
											{
												ship2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.FullStop;
												continue;
											}
											if (Operators.CompareString(innerText3, "Loiter", false) == 0)
											{
												ship2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Loiter;
												continue;
											}
											if (Operators.CompareString(innerText3, "Cruise", false) == 0)
											{
												ship2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Cruise;
												continue;
											}
											if (Operators.CompareString(innerText3, "Full", false) == 0)
											{
												ship2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Full;
												continue;
											}
											if (Operators.CompareString(innerText3, "Flank", false) != 0)
											{
												ship2.SBEngagedOffensive_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											ship2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Flank;
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SBED", false) == 0)
											{
												ship2.SBEngagedDefensive = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 3736393060u)
									{
										if (num2 != 3561877201u)
										{
											if (num2 == 3736393060u && Operators.CompareString(name2, "ParentGroup", false) == 0)
											{
												ship2.ParentGroupName = xmlNode10.InnerText;
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "Ship_Damage", false) == 0)
											{
												Ship ship4 = ship2;
												activeUnit = ship2;
												ship4.ship_Damage = Ship_Damage.Load(ref xmlNode10, ref dictionary_0, ref activeUnit);
												continue;
											}
											continue;
										}
									}
									else if (num2 != 3792306253u)
									{
										if (num2 != 4080539297u)
										{
											if (num2 == 4152621540u && Operators.CompareString(name2, "CurrentHeading", false) == 0)
											{
												goto IL_1091;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "IsAutoDetectable", false) == 0)
											{
												goto IL_13EE;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "Longitude_UnitEntersAreaCheck", false) == 0)
										{
											ship2.SetLongitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode10.InnerText)));
											continue;
										}
										continue;
									}
									ship2.SetLatitude(null, XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", ".")));
									continue;
									IL_1091:
									ship2.SetCurrentHeading(XmlConvert.ToSingle(xmlNode10.InnerText.Replace(",", ".")));
									continue;
								}
								if (num2 <= 827630232u)
								{
									if (num2 <= 468031071u)
									{
										if (num2 <= 266367750u)
										{
											if (num2 <= 100238421u)
											{
												if (num2 != 6222351u)
												{
													if (num2 == 100238421u && Operators.CompareString(name2, "Ship_Sensory", false) == 0)
													{
														goto IL_116E;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Status", false) != 0)
													{
														continue;
													}
													if (Versioned.IsNumeric(xmlNode10.InnerText))
													{
														ship2.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText));
													}
													else
													{
														ship2.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode10.InnerText, true));
													}
													if (ship2.GetUnitStatus() == (ActiveUnit._ActiveUnitStatus)9)
													{
														ship2.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 263373746u)
											{
												if (num2 == 266367750u && Operators.CompareString(name2, "Name", false) == 0)
												{
													ship2.Name = xmlNode10.InnerText;
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "FSBR", false) == 0)
												{
													ship2.FuelStateBR = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else
										{
											if (num2 <= 429749699u)
											{
												if (num2 != 334092753u)
												{
													if (num2 != 429749699u)
													{
														continue;
													}
													if (Operators.CompareString(name2, "DesiredTurnRate_Navigation", false) != 0)
													{
														continue;
													}
												}
												else if (Operators.CompareString(name2, "DTN", false) != 0)
												{
													continue;
												}
												ship2.SetDesiredTurnRate_Navigation((Waypoint._TurnRate)Conversions.ToByte(xmlNode10.InnerText));
												continue;
											}
											if (num2 != 441941816u)
											{
												if (num2 == 468031071u && Operators.CompareString(name2, "SBED_Altitude_TF", false) == 0)
												{
													ship2.SBEngagedDefensive_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "CurrentAltitude", false) == 0)
												{
													goto IL_133A;
												}
												continue;
											}
										}
									}
									else if (num2 <= 636840496u)
									{
										if (num2 <= 506380204u)
										{
											if (num2 != 485784328u)
											{
												if (num2 == 506380204u && Operators.CompareString(name2, "LatLR", false) == 0)
												{
													ship2.SetLatitudeLR(new double?(XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", "."))));
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "IsAD", false) == 0)
												{
													goto IL_13EE;
												}
												continue;
											}
										}
										else if (num2 != 634280640u)
										{
											if (num2 != 636840496u)
											{
												continue;
											}
											if (Operators.CompareString(name2, "TS", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "DS", false) == 0)
											{
												goto IL_144E;
											}
											continue;
										}
									}
									else if (num2 <= 742107497u)
									{
										if (num2 != 664498478u)
										{
											if (num2 == 742107497u && Operators.CompareString(name2, "Ship_Navigator", false) == 0)
											{
												Ship ship5 = ship2;
												activeUnit = ship2;
												ship5.ship_Navigator = Ship_Navigator.Load(ref xmlNode10, ref dictionary_0, ref activeUnit);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "FuelState", false) == 0)
											{
												ship2.activeUnitFuelState = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 != 751723973u)
									{
										if (num2 != 803760973u)
										{
											if (num2 == 827630232u && Operators.CompareString(name2, "SBED_Altitude", false) == 0)
											{
												ship2.SBEngagedDefensive_Altitude = XmlConvert.ToSingle(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "DamagePts", false) == 0)
											{
												ship2.SetDamagePts(true, XmlConvert.ToSingle(xmlNode10.InnerText));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "DT", false) == 0)
										{
											goto IL_1584;
										}
										continue;
									}
								}
								else
								{
									if (num2 <= 1175569298u)
									{
										if (num2 <= 1078362002u)
										{
											if (num2 <= 892023141u)
											{
												if (num2 != 889154257u)
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
													if (Operators.CompareString(name2, "Ship_Weaponry", false) == 0)
													{
														Ship ship6 = ship2;
														activeUnit = ship2;
														ship6.ship_Weaponry = Ship_Weaponry.smethod_4(ref xmlNode10, ref dictionary_0, ref activeUnit);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 936277782u)
											{
												if (num2 == 1078362002u && Operators.CompareString(name2, "Ship_CommStuff", false) == 0)
												{
													Ship ship7 = ship2;
													activeUnit = ship2;
													ship7.ship_CommStuff = Ship_CommStuff.Load(ref xmlNode10, ref dictionary_0, ref activeUnit);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "DA", false) == 0)
												{
													goto IL_168B;
												}
												continue;
											}
										}
										else if (num2 <= 1143797280u)
										{
											if (num2 != 1087276353u)
											{
												if (num2 == 1143797280u && Operators.CompareString(name2, "SBR_Altitude_TF", false) == 0)
												{
													ship2.SBR_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else if (Operators.CompareString(name2, "DH", false) != 0)
											{
												continue;
											}
										}
										else if (num2 != 1156592502u)
										{
											if (num2 == 1175569298u && Operators.CompareString(name2, "ActiveUnit_AirOps", false) == 0)
											{
												ActiveUnit activeUnit3 = ship2;
												activeUnit = ship2;
												((Ship)activeUnit3).m_AirOps = ActiveUnit_AirOps.Load(ref xmlNode10, ref dictionary_0, ref activeUnit);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SBR", false) == 0)
											{
												ship2.SBR = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										ship2.SetDesiredHeading(ActiveUnit._TurnRate.const_0, XmlConvert.ToSingle(xmlNode10.InnerText));
										continue;
									}
									if (num2 <= 1422437055u)
									{
										if (num2 <= 1255847155u)
										{
											if (num2 != 1192164083u)
											{
												if (num2 != 1255847155u || Operators.CompareString(name2, "ThrottleSetting", false) != 0)
												{
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "DEC", false) == 0)
												{
													ship2.DEC = Conversions.ToBoolean(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 1259548010u)
										{
											if (num2 == 1422437055u && Operators.CompareString(name2, "Doctrine", false) == 0)
											{
												ship2.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode10, ship2);
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
											string innerText4 = xmlNode10.InnerText;
											if (Operators.CompareString(innerText4, "FullStop", false) == 0)
											{
												ship2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.FullStop;
												continue;
											}
											if (Operators.CompareString(innerText4, "Loiter", false) == 0)
											{
												ship2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Loiter;
												continue;
											}
											if (Operators.CompareString(innerText4, "Cruise", false) == 0)
											{
												ship2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Cruise;
												continue;
											}
											if (Operators.CompareString(innerText4, "Full", false) == 0)
											{
												ship2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Full;
												continue;
											}
											if (Operators.CompareString(innerText4, "Flank", false) != 0)
											{
												ship2.SBEngagedDefensive_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											ship2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Flank;
											continue;
										}
									}
									else if (num2 <= 1476905714u)
									{
										if (num2 != 1444793274u)
										{
											if (num2 == 1476905714u && Operators.CompareString(name2, "WeaponState", false) == 0)
											{
												ship2.weaponState = (ActiveUnit._ActiveUnitWeaponState)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "Prof", false) == 0)
											{
												ship2.SetProficiencyLevel(new GlobalVariables.ProficiencyLevel?((GlobalVariables.ProficiencyLevel)Conversions.ToInteger(xmlNode10.InnerText)));
												continue;
											}
											continue;
										}
									}
									else if (num2 != 1488303767u)
									{
										if (num2 != 1708783731u)
										{
											if (num2 == 1729717486u && Operators.CompareString(name2, "Longitude", false) == 0)
											{
												goto IL_1ABF;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "CS", false) == 0)
											{
												goto IL_1AFE;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "SBEO_TF", false) == 0)
										{
											ship2.SBEngagedOffensive_TerrainFollowing = Conversions.ToBoolean(xmlNode10.InnerText);
											continue;
										}
										continue;
									}
								}
								string innerText5 = xmlNode10.InnerText;
								if (Operators.CompareString(innerText5, "FullStop", false) == 0)
								{
									ship2.currentThrottle = ActiveUnit.Throttle.FullStop;
									continue;
								}
								if (Operators.CompareString(innerText5, "Loiter", false) == 0)
								{
									ship2.currentThrottle = ActiveUnit.Throttle.Loiter;
									continue;
								}
								if (Operators.CompareString(innerText5, "Cruise", false) == 0)
								{
									ship2.currentThrottle = ActiveUnit.Throttle.Cruise;
									continue;
								}
								if (Operators.CompareString(innerText5, "Full", false) == 0)
								{
									ship2.currentThrottle = ActiveUnit.Throttle.Full;
									continue;
								}
								if (Operators.CompareString(innerText5, "Flank", false) != 0)
								{
									ship2.currentThrottle = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
									continue;
								}
								ship2.currentThrottle = ActiveUnit.Throttle.Flank;
								continue;
								IL_116E:
								Ship ship8 = ship2;
								activeUnit = ship2;
								ship8.ship_Sensory = Ship_Sensory.smethod_8(ref xmlNode10, ref dictionary_0, ref activeUnit);
								continue;
								IL_133A:
								ship2.SetAltitude_ASL(false, XmlConvert.ToSingle(xmlNode10.InnerText.Replace(",", ".")));
								continue;
								IL_13EE:
								ship2.SetIsAutoDetectable(null, Conversions.ToBoolean(xmlNode10.InnerText));
								continue;
								IL_144E:
								ship2.SetDesiredSpeed(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_1584:
								ship2.SetDesiredTurnRate((ActiveUnit._TurnRate)Conversions.ToByte(xmlNode10.InnerText));
								continue;
								IL_168B:
								ship2.SetDesiredAltitude(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_1ABF:
								ship2.SetLongitude(null, XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", ".")));
								continue;
								IL_1AFE:
								ship2.SetCurrentSpeed(XmlConvert.ToSingle(xmlNode10.InnerText.Replace(",", ".")));
							}
						}
						finally
						{
							if (enumerator11 is IDisposable)
							{
								(enumerator11 as IDisposable).Dispose();
							}
						}
						ship = ship2;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100762", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ship = new Ship();
				ProjectData.ClearProjectError();
			}
			result = ship;
			return result;
		}

		// Token: 0x0600601C RID: 24604 RVA: 0x002DB7D0 File Offset: 0x002D99D0
		public override float GetArea()
		{
			return this.Length * this.Beam;
		}

		// Token: 0x0600601D RID: 24605 RVA: 0x00011AB0 File Offset: 0x0000FCB0
		public override GlobalVariables.ActiveUnitType GetUnitType()
		{
			return GlobalVariables.ActiveUnitType.Ship;
		}

		// Token: 0x0600601E RID: 24606 RVA: 0x002DB7EC File Offset: 0x002D99EC
		public override Mission GetAssignedMission(bool SetMissionOnly = false)
		{
			return base.GetAssignedMission(false);
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x002DB804 File Offset: 0x002D9A04
		public override void DeleteMission(bool SetMissionOnly, Mission value)
		{
			try
			{
				foreach (ActiveUnit current in this.m_Scenario.GetActiveUnitList())
				{
					if (current.IsSubmarine && ((Submarine)current).IsROV() && current.GetDockingOps().GetAssignedHostUnit(true) == this)
					{
						current.DeleteMission(SetMissionOnly, value);
					}
				}
				base.DeleteMission(SetMissionOnly, value);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100763", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x002DB8DC File Offset: 0x002D9ADC
		public override int GetMaxMineRange()
		{
			int result;
			if (this.IsMineSweeper())
			{
				result = (int)Math.Round((double)base.GetMaxMineRange() * 0.1);
			}
			else
			{
				result = base.GetMaxMineRange();
			}
			return result;
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x002DB91C File Offset: 0x002D9B1C
		public override bool IsMineSweeper()
		{
			Ship._ShipType type = this.Type;
			bool result;
			if (type != Ship._ShipType.MCDV)
			{
				switch (type)
				{
				case Ship._ShipType.MCD:
				case Ship._ShipType.MCM:
				case Ship._ShipType.MCS:
				case Ship._ShipType.MHC:
				case Ship._ShipType.MSC:
				case Ship._ShipType.MSF:
				case Ship._ShipType.MSI:
				case Ship._ShipType.MSO:
					result = true;
					break;
				case Ship._ShipType.ML:
				case (Ship._ShipType)6009:
					result = false;
					break;
				default:
					result = false;
					break;
				}
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool HasNavalMineLayingLoadout()
		{
			return true;
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x00190C10 File Offset: 0x0018EE10
		public override ActiveUnit._ActiveUnitStatus GetUnitStatus()
		{
			return base.GetUnitStatus();
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x0002ABFE File Offset: 0x00028DFE
		public override void SetUnitStatus(ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_5)
		{
			bool arg_0C_0 = _ActiveUnitStatus_5 != this.GetUnitStatus();
			base.SetUnitStatus(_ActiveUnitStatus_5);
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x0023D944 File Offset: 0x0023BB44
		public override float GetDesiredHeading(ActiveUnit._TurnRate enum0_1)
		{
			return base.GetDesiredHeading(enum0_1);
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x000273EA File Offset: 0x000255EA
		public override void SetDesiredHeading(ActiveUnit._TurnRate enum0_1, float float_27)
		{
			base.SetDesiredHeading(enum0_1, float_27);
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x0023DA38 File Offset: 0x0023BC38
		public override float GetDesiredSpeed()
		{
			return base.GetDesiredSpeed();
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x0002AC14 File Offset: 0x00028E14
		public override void SetDesiredSpeed(float float_27)
		{
			if (float_27 != this.GetDesiredSpeed())
			{
				base.SetDesiredSpeed(float_27);
			}
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x0002AC28 File Offset: 0x00028E28
		public bool method_127()
		{
			return this.Type != Ship._ShipType.LCAC && this.GetCurrentSpeed() >= (float)this.GetShipKinematics().method_8(0f);
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x002DB980 File Offset: 0x002D9B80
		public Ship._WakeDetected GetWakeDetected()
		{
			Ship._WakeDetected result;
			if (this.GetCurrentSpeed() == 0f)
			{
				result = Ship._WakeDetected.None;
			}
			else if (this.Type == Ship._ShipType.LCAC && !base.IsOnLand())
			{
				result = Ship._WakeDetected.VeryLarge;
			}
			else
			{
				float currentSpeed = this.GetCurrentSpeed();
				if (currentSpeed < 10f)
				{
					result = (Ship._WakeDetected)Math.Max(0, (int)(this.GetTargetVisualSizeClass() - GlobalVariables.TargetVisualSizeClass.VSmall));
				}
				else if (currentSpeed < 20f)
				{
					result = (Ship._WakeDetected)this.GetTargetVisualSizeClass();
				}
				else if (currentSpeed < 30f)
				{
					result = (Ship._WakeDetected)Math.Min(5, (int)((byte)(this.GetTargetVisualSizeClass() + 1)));
				}
				else if (currentSpeed < 40f)
				{
					result = (Ship._WakeDetected)Math.Min(5, (int)((byte)(this.GetTargetVisualSizeClass() + 2)));
				}
				else
				{
					result = (Ship._WakeDetected)Math.Min(5, (int)((byte)(this.GetTargetVisualSizeClass() + 3)));
				}
			}
			return result;
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x002DBA58 File Offset: 0x002D9C58
		public Ship_Navigator GetShipNavigator()
		{
			if (Information.IsNothing(this.ship_Navigator))
			{
				ActiveUnit activeUnit = this;
				this.ship_Navigator = new Ship_Navigator(ref activeUnit);
			}
			return this.ship_Navigator;
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x002DBA8C File Offset: 0x002D9C8C
		public Ship_AI GetShipAI()
		{
			if (Information.IsNothing(this.ship_AI))
			{
				ActiveUnit activeUnit = this;
				this.ship_AI = new Ship_AI(ref activeUnit);
			}
			return this.ship_AI;
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x002DBAC0 File Offset: 0x002D9CC0
		public Ship_Kinematics GetShipKinematics()
		{
			if (Information.IsNothing(this.ship_Kinematics))
			{
				ActiveUnit activeUnit = this;
				this.ship_Kinematics = new Ship_Kinematics(ref activeUnit);
			}
			return this.ship_Kinematics;
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x002DBAF4 File Offset: 0x002D9CF4
		public Ship_Sensory GetShipSensory()
		{
			if (Information.IsNothing(this.ship_Sensory))
			{
				ActiveUnit activeUnit = this;
				this.ship_Sensory = new Ship_Sensory(ref activeUnit);
			}
			return this.ship_Sensory;
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x002DBB28 File Offset: 0x002D9D28
		public Ship_Weaponry GetShipWeaponry()
		{
			if (Information.IsNothing(this.ship_Weaponry))
			{
				ActiveUnit activeUnit = this;
				this.ship_Weaponry = new Ship_Weaponry(ref activeUnit);
			}
			return this.ship_Weaponry;
		}

		// Token: 0x06006030 RID: 24624 RVA: 0x002DBB5C File Offset: 0x002D9D5C
		public Ship_CommStuff GetShipCommStuff()
		{
			if (Information.IsNothing(this.ship_CommStuff))
			{
				ActiveUnit activeUnit = this;
				this.ship_CommStuff = new Ship_CommStuff(ref activeUnit);
			}
			return this.ship_CommStuff;
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x002DBB90 File Offset: 0x002D9D90
		public Ship_Damage GetShipDamage()
		{
			if (Information.IsNothing(this.ship_Damage))
			{
				ActiveUnit activeUnit = this;
				this.ship_Damage = new Ship_Damage(ref activeUnit);
			}
			return this.ship_Damage;
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x002DBBC4 File Offset: 0x002D9DC4
		public override int GetMastHeight()
		{
			int result;
			switch (this.GetTargetVisualSizeClass())
			{
			case GlobalVariables.TargetVisualSizeClass.Stealthy:
				result = 3;
				break;
			case GlobalVariables.TargetVisualSizeClass.VSmall:
				result = 7;
				break;
			case GlobalVariables.TargetVisualSizeClass.Small:
				result = 14;
				break;
			case GlobalVariables.TargetVisualSizeClass.Medium:
				result = 25;
				break;
			case GlobalVariables.TargetVisualSizeClass.Large:
				result = 40;
				break;
			case GlobalVariables.TargetVisualSizeClass.VLarge:
				result = 50;
				break;
			default:
				result = 0;
				break;
			}
			return result;
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x002DBC1C File Offset: 0x002D9E1C
		public override int GetTargetVisualSize()
		{
			int result;
			switch (this.GetTargetVisualSizeClass())
			{
			case GlobalVariables.TargetVisualSizeClass.Stealthy:
				result = 2;
				break;
			case GlobalVariables.TargetVisualSizeClass.VSmall:
				result = 6;
				break;
			case GlobalVariables.TargetVisualSizeClass.Small:
				result = 10;
				break;
			case GlobalVariables.TargetVisualSizeClass.Medium:
				result = 15;
				break;
			case GlobalVariables.TargetVisualSizeClass.Large:
				result = 20;
				break;
			case GlobalVariables.TargetVisualSizeClass.VLarge:
				result = 25;
				break;
			default:
				result = 0;
				break;
			}
			return result;
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x002DBC74 File Offset: 0x002D9E74
		public bool IsNuclearPowered()
		{
			if (!this.bNuclearPowered.HasValue)
			{
				this.bNuclearPowered = new bool?(false);
				using (IEnumerator<Engine> enumerator = this.GetEngines().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.PropulsionType == Engine._PropulsionType.Nuclear)
						{
							this.bNuclearPowered = new bool?(true);
							break;
						}
					}
				}
			}
			return this.bNuclearPowered.Value;
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x0002AC56 File Offset: 0x00028E56
		public bool IsDestroyed()
		{
			return this.GetDamagePts(false) <= 0f;
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x002DBD00 File Offset: 0x002D9F00
		public override GlobalVariables.TargetVisualSizeClass GetTargetVisualSizeClass()
		{
			float length = this.Length;
			GlobalVariables.TargetVisualSizeClass result;
			if (length > 280f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VLarge;
			}
			else if (length > 220f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Large;
			}
			else if (length > 120f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Medium;
			}
			else if (length > 45f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Small;
			}
			else if (length > 10f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VSmall;
			}
			else
			{
				result = GlobalVariables.TargetVisualSizeClass.Stealthy;
			}
			return result;
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x0002AC69 File Offset: 0x00028E69
		public override void vmethod_113(ref Scenario scenario_1, Dictionary<string, Subject> dictionary_0, bool bool_17)
		{
			base.vmethod_113(ref scenario_1, dictionary_0, bool_17);
			this.GetDockingOps().method_1(ref scenario_1, dictionary_0, bool_17);
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x0002AC82 File Offset: 0x00028E82
		public override void ScheduleLifeCycleActivities(float float_27, ref Random random_1)
		{
			this.GetDockingOps().ScheduleDockingOpsEvent(float_27);
		}

		// Token: 0x06006039 RID: 24633 RVA: 0x002DBD70 File Offset: 0x002D9F70
		public override void SetThrottle(ActiveUnit.Throttle newThrottleSetting, float? SpecificDesiredSpeed = null)
		{
			try
			{
				if (this.GetThrottle() != newThrottleSetting || !Information.IsNothing(SpecificDesiredSpeed) || this.m_Scenario.MinuteIsChangingOnThisPulse)
				{
					if (newThrottleSetting > ActiveUnit.Throttle.Flank)
					{
						newThrottleSetting = ActiveUnit.Throttle.Flank;
					}
					if (newThrottleSetting < ActiveUnit.Throttle.FullStop)
					{
						newThrottleSetting = ActiveUnit.Throttle.FullStop;
					}
					if (newThrottleSetting > this.GetMaxThrottleAvailable())
					{
						newThrottleSetting = this.GetMaxThrottleAvailable();
					}
					this.currentThrottle = newThrottleSetting;
					if (!this.IsGroup)
					{
						if (Information.IsNothing(SpecificDesiredSpeed))
						{
							this.SetDesiredSpeed((float)this.GetShipKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), this.currentThrottle));
						}
						else if (!base.IsGroupLead() || !this.GetShipAI().IsRegroupNeeded())
						{
							if (this.GetShipKinematics().GetSpeedPreset() == ActiveUnit_Kinematics._SpeedPreset.None)
							{
								float? num = SpecificDesiredSpeed;
								float num2 = (float)this.GetShipKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), newThrottleSetting);
								bool? flag = num.HasValue ? new bool?(num.GetValueOrDefault() > num2) : null;
								bool? flag2;
								flag = (flag2 = (flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag));
								bool? flag3;
								bool? flag4;
								if (flag.HasValue && !flag2.GetValueOrDefault())
								{
									flag3 = new bool?(false);
								}
								else
								{
									num = SpecificDesiredSpeed;
									num2 = (float)this.GetShipKinematics().vmethod_29((float)((int)Math.Round((double)this.GetCurrentAltitude_ASL(false))), newThrottleSetting);
									flag = (num.HasValue ? new bool?(num.GetValueOrDefault() < num2) : null);
									flag = (flag4 = (flag.HasValue ? new bool?(!flag.GetValueOrDefault()) : flag));
									flag3 = (flag.HasValue ? (flag2 & flag4.GetValueOrDefault()) : null);
								}
								flag4 = flag3;
								if (flag4.GetValueOrDefault())
								{
									this.SetDesiredSpeed(SpecificDesiredSpeed.Value);
								}
								else
								{
									this.currentThrottle = this.GetShipKinematics().vmethod_38(this.GetCurrentAltitude_ASL(false), SpecificDesiredSpeed.Value);
									num = SpecificDesiredSpeed;
									num2 = (float)this.GetShipKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), this.currentThrottle);
									if ((num.HasValue ? new bool?(num.GetValueOrDefault() > num2) : null).GetValueOrDefault())
									{
										this.SetDesiredSpeed((float)this.GetShipKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), this.currentThrottle));
									}
								}
							}
							else
							{
								this.SetDesiredSpeed((float)this.GetShipKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), (ActiveUnit.Throttle)this.GetShipKinematics().GetSpeedPreset()));
							}
						}
					}
					base.method_101(this, this.currentThrottle);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100034957377", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600603A RID: 24634 RVA: 0x002DC098 File Offset: 0x002DA298
		public override bool vmethod_41(double double_5, double double_6, ref byte byte_1, bool bool_17, ref bool bAboutToEnterNoNavZone, bool bool_19, ref bool bool_20, float? nullable_15, short? nullable_16, ref List<ActiveUnit> list_3, float float_27, bool bool_21, bool bool_22)
		{
			Ship.Class181 @class = new Ship.Class181();
			@class.ship_0 = this;
			@class.double_0 = double_5;
			@class.double_1 = double_6;
			bool flag = false;
			bool result;
			try
			{
				Ship.Class182 class2 = new Ship.Class182();
				class2.class181_0 = @class;
				byte_1 = 1;
				bool flag2 = false;
				if (!double.IsNaN(class2.class181_0.double_0) && !double.IsNaN(class2.class181_0.double_1))
				{
					if (bool_21 && this.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedOffensive && !Information.IsNothing(this.GetAssignedMission(false)) && this.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
					{
						Patrol patrol = (Patrol)this.GetAssignedMission(false);
						GeoPoint geoPoint = new GeoPoint(class2.class181_0.double_1, class2.class181_0.double_0);
						if (this.vmethod_40(patrol.ProsecutionAreaVertices, this.m_Scenario, true) && !geoPoint.method_22(ref patrol.ProsecutionAreaVertices, true))
						{
							bAboutToEnterNoNavZone = false;
							bool_20 = false;
							flag = false;
							result = false;
							return result;
						}
					}
					if (!bool_17 && this.GetShipNavigator().HasPathfindingCourse())
					{
						float num;
						if (Information.IsNothing(nullable_15))
						{
							num = base.HorizontalRangeTo(class2.class181_0.double_0, class2.class181_0.double_1);
						}
						else
						{
							num = nullable_15.Value;
						}
						if (num <= base.GetMoveDistance(2f))
						{
							flag2 = true;
						}
					}
					if (!flag2)
					{
						if (bool_22)
						{
							bAboutToEnterNoNavZone = base.AboutToEnterNoNavZone();
						}
						if ((bAboutToEnterNoNavZone || bool_17) && base.method_122(class2.class181_0.double_0, class2.class181_0.double_1, float_27))
						{
							bAboutToEnterNoNavZone = true;
							bool_20 = false;
							flag = false;
							result = false;
							return result;
						}
						if (!this.method_139(class2.class181_0.double_0, class2.class181_0.double_1, bool_19, nullable_16, ref list_3))
						{
							bAboutToEnterNoNavZone = false;
							bool_20 = false;
							flag = false;
							result = false;
							return result;
						}
					}
					class2.bool_0 = false;
					if (this.GetSide(false).Contacts_NonAU.Count > 0)
					{
						Parallel.ForEach<string>(this.GetSide(false).Contacts_NonAU.ToList<string>(), new Action<string, ParallelLoopState>(class2.method_0));
						if (class2.bool_0)
						{
							bAboutToEnterNoNavZone = false;
							bool_20 = true;
							flag = false;
							result = false;
							return result;
						}
					}
					bAboutToEnterNoNavZone = false;
					bool_20 = false;
					flag = true;
				}
				else
				{
					bAboutToEnterNoNavZone = false;
					bool_20 = false;
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200285", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				bAboutToEnterNoNavZone = false;
				bool_20 = false;
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool IsPlatform()
		{
			return true;
		}

		// Token: 0x0600603C RID: 24636 RVA: 0x0002AC90 File Offset: 0x00028E90
		public bool IsAGB()
		{
			return this.Type == Ship._ShipType.AGB;
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x002DC374 File Offset: 0x002DA574
		private bool method_139(double double_5, double double_6, bool bool_17, short? nullable_15, ref List<ActiveUnit> list_3)
		{
			bool result = false;
			try
			{
				if (this.Type == Ship._ShipType.LCAC)
				{
					result = true;
				}
				else if (GeoPoint.smethod_7(double_5, double_6))
				{
					result = true;
				}
				else if ((Information.IsNothing(list_3) || list_3.Count > 0) && GeoPoint.smethod_6(double_5, double_6, this.m_Scenario, ref list_3))
				{
					result = true;
				}
				else if (bool_17 && !this.IsAGB() && ArcticSeaIce.IsNearMarginalIceZone(double_6, double_5))
				{
					result = false;
				}
				else
				{
					short num;
					if (Information.IsNothing(nullable_15))
					{
						num = Terrain.GetElevation(double_5, double_6, false);
					}
					else
					{
						num = nullable_15.Value;
					}
					result = (num < -2);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100765", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x002DC480 File Offset: 0x002DA680
		public override long GetTimeToBurnOut(ActiveUnit.Throttle throttle_4, AltBand altBand_0, float? nullable_15, float? nullable_16)
		{
			long result;
			try
			{
				if (this.GetFuelRecs().Count<FuelRec>() == 0)
				{
					result = 0L;
					return result;
				}
				FuelRec fuelRec = this.GetFuelRecs().Select(Ship.FuelRecFunc).Where(new Func<FuelRec, bool>(this.IsFuelSuitable)).ElementAtOrDefault(0);
				if (Information.IsNothing(fuelRec))
				{
					result = 0L;
					return result;
				}
				float currentQuantity = fuelRec.CurrentQuantity;
				if (currentQuantity == 0f)
				{
					result = 0L;
					return result;
				}
				if (throttle_4 == ActiveUnit.Throttle.FullStop)
				{
					result = 2147483647L;
					return result;
				}
				float fuelConsumption = this.GetFuelConsumption(throttle_4, altBand_0, nullable_15, nullable_16, false, false, false, false);
				if (fuelConsumption == 0f)
				{
					result = 9223372036854775807L;
					return result;
				}
				long num = (long)Math.Round((double)(currentQuantity / fuelConsumption));
				result = num;
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100766", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = 0L;
			return result;
		}

		// Token: 0x0600603F RID: 24639 RVA: 0x002DC614 File Offset: 0x002DA814
		public override ActiveUnit._ActiveUnitFuelState GetActiveUnitFuelState(ActiveUnit activeUnit_0, GeoPoint geoPoint_0)
		{
			ActiveUnit._ActiveUnitFuelState result;
			try
			{
				if (this.GetTimeToBurnOut(ActiveUnit.Throttle.Cruise, null, null, null) <= 900L)
				{
					result = ActiveUnit._ActiveUnitFuelState.IsBingo;
				}
				else
				{
					float horizontalRange = base.GetHorizontalRange(activeUnit_0);
					if ((double)this.GetShipKinematics().vmethod_25(null) >= (double)horizontalRange * 1.1)
					{
						result = ActiveUnit._ActiveUnitFuelState.None;
					}
					else
					{
						result = ActiveUnit._ActiveUnitFuelState.IsBingo;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100767", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = ActiveUnit._ActiveUnitFuelState.None;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006040 RID: 24640 RVA: 0x002DC6DC File Offset: 0x002DA8DC
		public override ActiveUnit._ActiveUnitFuelState GetFuelState(GeoPoint geoPoint_0)
		{
			ActiveUnit._ActiveUnitFuelState result;
			try
			{
				if (this.IsNuclearPowered())
				{
					result = ActiveUnit._ActiveUnitFuelState.None;
				}
				else
				{
					ActiveUnit assignedHostUnit = this.GetDockingOps().GetAssignedHostUnit();
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
						result = this.GetActiveUnitFuelState(assignedHostUnit, null);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100768", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = ActiveUnit._ActiveUnitFuelState.None;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006041 RID: 24641 RVA: 0x0002AC9F File Offset: 0x00028E9F
		public override bool CanRefuelOrUNREP(ActiveUnit targetUnit_)
		{
			return !targetUnit_.IsAircraft && (this.RefuelOrReplenish.RefuelToPort_Out > 0 || this.RefuelOrReplenish.RefuelToStarboard_Out > 0 || this.RefuelOrReplenish.RefuelToAstern_Out > 0);
		}

		// Token: 0x06006042 RID: 24642 RVA: 0x0002ACD9 File Offset: 0x00028ED9
		public override bool IsRefuel_Out()
		{
			return this.RefuelOrReplenish.RefuelToPort_Out > 0 || this.RefuelOrReplenish.RefuelToStarboard_Out > 0 || this.RefuelOrReplenish.RefuelToAstern_Out > 0;
		}

		// Token: 0x06006043 RID: 24643 RVA: 0x002DC780 File Offset: 0x002DA980
		public override bool IsRunOutOfFuel()
		{
			bool result = false;
			try
			{
				if (this.IsNuclearPowered())
				{
					result = false;
				}
				else if (this.GetEngines().Count == 0)
				{
					result = false;
				}
				else
				{
					FuelRec fuelRec = this.GetFuelRecs().Select(Ship.FuelRecFunc).Where(new Func<FuelRec, bool>(this.IsFuelSuitable)).ElementAtOrDefault(0);
					result = (Information.IsNothing(fuelRec) || fuelRec.CurrentQuantity == 0f || this.GetFuelRecs()[0].CurrentQuantity == 0f);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100769", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006044 RID: 24644 RVA: 0x002DC868 File Offset: 0x002DAA68
		public override void UpdatePropulsionState(float elapsedTime)
		{
			try
			{
				if (!this.IsNuclearPowered() && this.GetThrottle() != ActiveUnit.Throttle.FullStop && !this.IsRunOutOfFuel())
				{
					float num = this.GetFuelConsumption(this.GetThrottle(), null, null, null, false, false, false, false) * elapsedTime;
					FuelRec fuelRec = this.GetFuelRecs().Select(Ship.FuelRecFunc).Where(new Func<FuelRec, bool>(this.IsFuelSuitable)).ElementAtOrDefault(0);
					this.ConsumeFuel(num, fuelRec.FuelType);
					base.ExportFuelConsumed(num, fuelRec.FuelType);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100770", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x002DC948 File Offset: 0x002DAB48
		public override void ConsumeFuel(float FuelConsumption_, FuelRec._FuelType FuelType_)
		{
			Ship.FuelTypeComparator fuelTypeComparator = new Ship.FuelTypeComparator();
			fuelTypeComparator.FuelType = FuelType_;
			try
			{
				if (FuelConsumption_ != 0f)
				{
					FuelRec fuelRec = this.GetFuelRecs().Select(Ship.FuelRecFunc).Where(new Func<FuelRec, bool>(fuelTypeComparator.IsSame)).ElementAtOrDefault(0);
					if (fuelRec.CurrentQuantity > FuelConsumption_)
					{
						fuelRec.CurrentQuantity -= FuelConsumption_;
					}
					else
					{
						bool flag = fuelRec.CurrentQuantity > 0f;
						fuelRec.CurrentQuantity = 0f;
						this.SetThrottle(ActiveUnit.Throttle.FullStop, null);
						if (flag)
						{
							base.LogMessage(this.Name + " (" + Misc.smethod_11(this.UnitClass) + ")燃油耗光，不能继续航行!", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100771", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x002DCA84 File Offset: 0x002DAC84
		public override float GetFuelConsumption(ActiveUnit.Throttle throttle_, AltBand altBand_, float? desiredSpeed_, float? altitude_asl, bool bool_17, bool bool_18, bool bool_19, bool bool_20)
		{
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
					if (this.GetEngines()[0].GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
					{
						num = 0f;
					}
					else if (this.GetEngines()[0].altBands.Length == 0)
					{
						num = 0f;
					}
					else
					{
						AltBand altBand;
						if (Information.IsNothing(altBand_))
						{
							if (!Information.IsNothing(altitude_asl))
							{
								altBand = this.GetShipKinematics().GetAltBand(altitude_asl.Value, null);
							}
							else
							{
								altBand = this.GetShipKinematics().vmethod_39();
							}
						}
						else
						{
							altBand = altBand_;
						}
						if (Information.IsNothing(altBand))
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw new Exception();
						}
						float num2;
						float num3;
						switch (throttle_)
						{
						case ActiveUnit.Throttle.FullStop:
							num = 0f;
							result = num;
							return result;
						case ActiveUnit.Throttle.Loiter:
							num2 = altBand.Consumption_Loiter;
							num3 = 0f;
							break;
						case ActiveUnit.Throttle.Cruise:
							if (this.GetEngines()[0].altBands[0].Consumption_Cruise <= 0f)
							{
								num = this.GetFuelConsumption(ActiveUnit.Throttle.Loiter, altBand_, desiredSpeed_, altitude_asl, bool_17, bool_18, bool_19, false);
								result = num;
								return result;
							}
							num2 = altBand.Consumption_Cruise;
							num3 = altBand.Consumption_Loiter;
							break;
						case ActiveUnit.Throttle.Full:
							if (altBand.Speed_Full.HasValue)
							{
								float? num4 = this.GetEngines()[0].altBands[0].Consumption_Full;
								if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() > 0f) : null).GetValueOrDefault())
								{
									num2 = altBand.Consumption_Full.Value;
									float arg_1F8_0 = (float)altBand.Speed_Full.Value;
									num3 = altBand.Consumption_Cruise;
									break;
								}
							}
							num = this.GetFuelConsumption(ActiveUnit.Throttle.Cruise, altBand_, desiredSpeed_, altitude_asl, bool_17, bool_18, bool_19, false);
							result = num;
							return result;
						case ActiveUnit.Throttle.Flank:
							if (altBand.Speed_Flank.HasValue)
							{
								float? num4 = this.GetEngines()[0].altBands[0].Consumption_Flank;
								if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() > 0f) : null).GetValueOrDefault())
								{
									num2 = altBand.Consumption_Flank.Value;
									float arg_29F_0 = (float)altBand.Speed_Flank.Value;
									if (altBand.Speed_Full.HasValue)
									{
										num3 = altBand.Consumption_Full.Value;
										break;
									}
									num3 = altBand.Consumption_Cruise;
									break;
								}
							}
							num = this.GetFuelConsumption(ActiveUnit.Throttle.Full, altBand_, desiredSpeed_, altitude_asl, bool_17, bool_18, bool_19, false);
							result = num;
							return result;
						default:
							num = 0f;
							result = num;
							return result;
						}
						float num5 = num2;
						if (!Information.IsNothing(desiredSpeed_))
						{
							float num6 = (float)this.GetShipKinematics().GetSpeed(altitude_asl.Value, throttle_);
							float? num4 = desiredSpeed_;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() != num6) : null).GetValueOrDefault())
							{
								float num7 = (float)this.GetShipKinematics().GetSpeed(altitude_asl.Value, (ActiveUnit.Throttle)(throttle_ - ActiveUnit.Throttle.Loiter));
								num4 = desiredSpeed_;
								float num10;
								if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() >= num7) : null).GetValueOrDefault())
								{
									float? num8 = desiredSpeed_;
									float num9 = num7;
									num8 = (num8.HasValue ? new float?(num8.GetValueOrDefault() - num9) : null);
									num9 = num6 - num7;
									num10 = (num8.HasValue ? new float?(num8.GetValueOrDefault() / num9) : null).Value;
									num10 = Math.Abs(num10);
								}
								else
								{
									num10 = 0f;
								}
								num5 = num3 + (num2 - num3) * num10;
							}
						}
						num = num5 / 60f;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101253", "");
					GameGeneral.LogException(ref ex2);
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

		// Token: 0x06006047 RID: 24647 RVA: 0x002DCF24 File Offset: 0x002DB124
		public void method_140(float DamagePts)
		{
			base.LogMessage(this.Name + "正在沉没!!!", LoggedMessage.MessageType.UnitLost, 1, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
			this.isDestroyed = true;
			base.ApplyingDamage(false, true, DamagePts);
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x002DCF80 File Offset: 0x002DB180
		public override void DestroyUnit(bool ScenEditAction, bool IsAimpointFacility, bool DestroyUnitNow = false)
		{
			checked
			{
				try
				{
					this.isDestroyed = true;
					this.GetDockingOps().SetDockFacility(null);
					if (!this.IsOperating() && !ScenEditAction)
					{
						this.m_Scenario.LogMessage(this.Name + "已被摧毁!", LoggedMessage.MessageType.UnitLost, 0, base.GetGuid(), this.GetSide(false), new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
					}
					base.ApplyingDamage(ScenEditAction, false, this.GetShipDamage().GetDamagePts());
					Side[] sides = this.m_Scenario.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						sides[i].RemoveActiveUnits(this, ScenEditAction);
					}
					foreach (ActiveUnit current in this.m_Scenario.GetAllWeaponsAlive())
					{
						List<Contact> list = new List<Contact>();
						Contact[] targets = current.GetAI().GetTargets();
						for (int j = 0; j < targets.Length; j++)
						{
							Contact contact = targets[j];
							if (contact.ActualUnit == this)
							{
								list.Add(contact);
							}
						}
						foreach (Contact current2 in list)
						{
							current.GetAI().DropTargeting(current2, true);
						}
					}
					if (this.GetDockFacilities().Length > 0)
					{
						using (IEnumerator<ActiveUnit> enumerator3 = this.GetDockingOps().GetDockedUnits().GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.DestroyUnit(ScenEditAction, IsAimpointFacility, true);
							}
						}
					}
					if (this.GetAirFacilities().Length > 0)
					{
						using (List<Aircraft>.Enumerator enumerator4 = this.GetAirOps().GetHostedAircrafts().GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								enumerator4.Current.DestroyUnit(ScenEditAction, IsAimpointFacility, true);
							}
						}
					}
					if (base.HasParentGroup())
					{
						this.GetParentGroup(false).GetUnitsInGroup().Remove(base.GetGuid());
					}
					if (ScenEditAction)
					{
						base.Destroy();
					}
					else if (DestroyUnitNow)
					{
						this.m_Scenario.RemoveUnit(this);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100772", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006049 RID: 24649 RVA: 0x002DD290 File Offset: 0x002DB490
		public Ship(ref Scenario theScen, string theGUID = null) : base(ref theScen, theGUID)
		{
			this.ShipCode = default(Ship._ShipCode);
			this.m_Rudder = new Rudder(this);
			this.m_CommandPost = new CIC(this, "Bridge / CIC");
			this.IsShip = true;
		}

		// Token: 0x0600604A RID: 24650 RVA: 0x002DD304 File Offset: 0x002DB504
		public float GetCargoCrew()
		{
			return this.Cargo_Crew;
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x002DD31C File Offset: 0x002DB51C
		public float GetCargoArea()
		{
			return this.Cargo_Area;
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x002DD334 File Offset: 0x002DB534
		public _CargoType GetCargoType()
		{
			return this.Cargo_Type;
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x002DD34C File Offset: 0x002DB54C
		public float GetCargoMass()
		{
			return this.Cargo_Mass;
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x0002AD08 File Offset: 0x00028F08
		[CompilerGenerated]
		private bool IsFuelSuitable(FuelRec fuelRec_)
		{
			return this.GetEngines()[0].IsFueTypeSuitable(fuelRec_.FuelType);
		}

		// Token: 0x040032F2 RID: 13042
		public new static Func<FuelRec, FuelRec> FuelRecFunc = (FuelRec fuelRec_0) => fuelRec_0;

		// Token: 0x040032F3 RID: 13043
		public Ship._ShipCategory Category;

		// Token: 0x040032F4 RID: 13044
		public Ship._ShipType Type;

		// Token: 0x040032F5 RID: 13045
		public GlobalVariables.ArmorRating ArmorBridge;

		// Token: 0x040032F6 RID: 13046
		public GlobalVariables.ArmorRating ArmorEngineering;

		// Token: 0x040032F7 RID: 13047
		public GlobalVariables.ArmorRating ArmorBelt;

		// Token: 0x040032F8 RID: 13048
		public GlobalVariables.ArmorRating ArmorBulkheads;

		// Token: 0x040032F9 RID: 13049
		public GlobalVariables.ArmorRating ArmorDeck;

		// Token: 0x040032FA RID: 13050
		public GlobalVariables.ArmorRating ArmorCIC;

		// Token: 0x040032FB RID: 13051
		public GlobalVariables.ArmorRating ArmorRudder;

		// Token: 0x040032FC RID: 13052
		public float Length;

		// Token: 0x040032FD RID: 13053
		public DockFacility._DockFacilityPhysicalSizeCode physicalSizeCode;

		// Token: 0x040032FE RID: 13054
		public byte MaxSeaState;

		// Token: 0x040032FF RID: 13055
		public short RepairCapacity;

		// Token: 0x04003300 RID: 13056
		public short TroopCapacity;

		// Token: 0x04003301 RID: 13057
		public short CargoCapacity;

		// Token: 0x04003302 RID: 13058
		public short MissileDefense;

		// Token: 0x04003303 RID: 13059
		public double DisplacementEmpty = 0.0;

		// Token: 0x04003304 RID: 13060
		public double DisplacementStandard = 0.0;

		// Token: 0x04003305 RID: 13061
		public double DisplacementFull = 0.0;

		// Token: 0x04003306 RID: 13062
		public float Beam;

		// Token: 0x04003307 RID: 13063
		public float Draft;

		// Token: 0x04003308 RID: 13064
		public float Height;

		// Token: 0x04003309 RID: 13065
		public float Cargo_Crew;

		// Token: 0x0400330A RID: 13066
		public float Cargo_Area;

		// Token: 0x0400330B RID: 13067
		public _CargoType Cargo_Type;

		// Token: 0x0400330C RID: 13068
		public float Cargo_Mass;

		// Token: 0x0400330D RID: 13069
		public Ship._ShipCode ShipCode;

		// Token: 0x0400330E RID: 13070
		public Rudder m_Rudder;

		// Token: 0x0400330F RID: 13071
		public CIC m_CommandPost;

		// Token: 0x04003310 RID: 13072
		private Ship_Navigator ship_Navigator;

		// Token: 0x04003311 RID: 13073
		private Ship_AI ship_AI;

		// Token: 0x04003312 RID: 13074
		private Ship_Kinematics ship_Kinematics;

		// Token: 0x04003313 RID: 13075
		private Ship_Sensory ship_Sensory;

		// Token: 0x04003314 RID: 13076
		private Ship_Weaponry ship_Weaponry;

		// Token: 0x04003315 RID: 13077
		private Ship_CommStuff ship_CommStuff;

		// Token: 0x04003316 RID: 13078
		private Ship_Damage ship_Damage;

		// Token: 0x04003317 RID: 13079
		private bool? bNuclearPowered;

		// Token: 0x04003318 RID: 13080
		private static Scenario scenario = null;

		// Token: 0x02000B65 RID: 2917
		public struct _ShipCode
		{
			// Token: 0x0400331A RID: 13082
			public bool PassiveOrSingleStabilizers;

			// Token: 0x0400331B RID: 13083
			public bool DualOrTripleStabilizers;

			// Token: 0x0400331C RID: 13084
			public bool NuclearShockResistant;

			// Token: 0x0400331D RID: 13085
			public bool bool_3;

			// Token: 0x0400331E RID: 13086
			public bool bool_4;

			// Token: 0x0400331F RID: 13087
			public bool bool_5;

			// Token: 0x04003320 RID: 13088
			public bool bool_6;

			// Token: 0x04003321 RID: 13089
			public bool PrairieMasker;

			// Token: 0x04003322 RID: 13090
			public bool AdvancedQuieting;

			// Token: 0x04003323 RID: 13091
			public bool DegaussedSteelHull;

			// Token: 0x04003324 RID: 13092
			public bool OnboardDegaussingGear;

			// Token: 0x04003325 RID: 13093
			public bool WoodenHull;

			// Token: 0x04003326 RID: 13094
			public bool GlassReinforcedPolyesterHull;

			// Token: 0x04003327 RID: 13095
			public bool LowConstructionStandards;

			// Token: 0x04003328 RID: 13096
			public bool AllAluminumConstruction;

			// Token: 0x04003329 RID: 13097
			public bool AluminumSuperstructureOnly;

			// Token: 0x0400332A RID: 13098
			public bool WoodenHullConstruction;

			// Token: 0x0400332B RID: 13099
			public bool GlassReinforcedPolyesterConstruction;

			// Token: 0x0400332C RID: 13100
			public bool Hovercraft_SES;

			// Token: 0x0400332D RID: 13101
			public bool Catamaran_TrimaranMultihull;

			// Token: 0x0400332E RID: 13102
			public bool LaidDownBefore1930;

			// Token: 0x0400332F RID: 13103
			public bool BuiltToMercantileStandards;
		}

		// Token: 0x02000B66 RID: 2918
		public enum _ShipCategory
		{
			// Token: 0x04003331 RID: 13105
			None = 1001,
			// Token: 0x04003332 RID: 13106
			Carrier = 2002,
			// Token: 0x04003333 RID: 13107
			SurfaceCombatant = 2001,
			// Token: 0x04003334 RID: 13108
			Amphibious = 2003,
			// Token: 0x04003335 RID: 13109
			Auxiliary,
			// Token: 0x04003336 RID: 13110
			Merchant,
			// Token: 0x04003337 RID: 13111
			Civilian,
			// Token: 0x04003338 RID: 13112
			SurfaceCombatant_AviationCapable,
			// Token: 0x04003339 RID: 13113
			MobileOffshoreBase_AviationCapable
		}

		// Token: 0x02000B67 RID: 2919
		public enum _ShipType
		{
			// Token: 0x0400333B RID: 13115
			None = 1001,
			// Token: 0x0400333C RID: 13116
			CV = 2001,
			// Token: 0x0400333D RID: 13117
			CVA,
			// Token: 0x0400333E RID: 13118
			CVB,
			// Token: 0x0400333F RID: 13119
			CVE,
			// Token: 0x04003340 RID: 13120
			CVGH,
			// Token: 0x04003341 RID: 13121
			CVH,
			// Token: 0x04003342 RID: 13122
			CVL,
			// Token: 0x04003343 RID: 13123
			CVN,
			// Token: 0x04003344 RID: 13124
			SeaplaneCarrier,
			// Token: 0x04003345 RID: 13125
			CVS,
			// Token: 0x04003346 RID: 13126
			B = 3001,
			// Token: 0x04003347 RID: 13127
			BB,
			// Token: 0x04003348 RID: 13128
			BBC,
			// Token: 0x04003349 RID: 13129
			BBG,
			// Token: 0x0400334A RID: 13130
			BBH,
			// Token: 0x0400334B RID: 13131
			BCGN,
			// Token: 0x0400334C RID: 13132
			BM,
			// Token: 0x0400334D RID: 13133
			C = 3101,
			// Token: 0x0400334E RID: 13134
			CA,
			// Token: 0x0400334F RID: 13135
			CAG,
			// Token: 0x04003350 RID: 13136
			CB,
			// Token: 0x04003351 RID: 13137
			CBG,
			// Token: 0x04003352 RID: 13138
			CG,
			// Token: 0x04003353 RID: 13139
			CGH,
			// Token: 0x04003354 RID: 13140
			CGN,
			// Token: 0x04003355 RID: 13141
			CL,
			// Token: 0x04003356 RID: 13142
			CLAA,
			// Token: 0x04003357 RID: 13143
			CLC,
			// Token: 0x04003358 RID: 13144
			CLG,
			// Token: 0x04003359 RID: 13145
			CLH,
			// Token: 0x0400335A RID: 13146
			CS,
			// Token: 0x0400335B RID: 13147
			D = 3201,
			// Token: 0x0400335C RID: 13148
			DD,
			// Token: 0x0400335D RID: 13149
			DDG,
			// Token: 0x0400335E RID: 13150
			DDH,
			// Token: 0x0400335F RID: 13151
			DDK,
			// Token: 0x04003360 RID: 13152
			DDR,
			// Token: 0x04003361 RID: 13153
			DE,
			// Token: 0x04003362 RID: 13154
			DEG,
			// Token: 0x04003363 RID: 13155
			DER,
			// Token: 0x04003364 RID: 13156
			DL,
			// Token: 0x04003365 RID: 13157
			DLG,
			// Token: 0x04003366 RID: 13158
			DM,
			// Token: 0x04003367 RID: 13159
			F = 3301,
			// Token: 0x04003368 RID: 13160
			FF,
			// Token: 0x04003369 RID: 13161
			FFG,
			// Token: 0x0400336A RID: 13162
			FFL,
			// Token: 0x0400336B RID: 13163
			PF,
			// Token: 0x0400336C RID: 13164
			LCS,
			// Token: 0x0400336D RID: 13165
			OPV,
			// Token: 0x0400336E RID: 13166
			PB = 3401,
			// Token: 0x0400336F RID: 13167
			PC1,
			// Token: 0x04003370 RID: 13168
			PC2,
			// Token: 0x04003371 RID: 13169
			PCE,
			// Token: 0x04003372 RID: 13170
			PCF,
			// Token: 0x04003373 RID: 13171
			PCFG,
			// Token: 0x04003374 RID: 13172
			PG1,
			// Token: 0x04003375 RID: 13173
			PG2,
			// Token: 0x04003376 RID: 13174
			PGM,
			// Token: 0x04003377 RID: 13175
			PH,
			// Token: 0x04003378 RID: 13176
			PHM,
			// Token: 0x04003379 RID: 13177
			PHT,
			// Token: 0x0400337A RID: 13178
			PT,
			// Token: 0x0400337B RID: 13179
			PTS,
			// Token: 0x0400337C RID: 13180
			MTB,
			// Token: 0x0400337D RID: 13181
			WHEC,
			// Token: 0x0400337E RID: 13182
			WMEC,
			// Token: 0x0400337F RID: 13183
			WPB,
			// Token: 0x04003380 RID: 13184
			WPG,
			// Token: 0x04003381 RID: 13185
			MCDV,
			// Token: 0x04003382 RID: 13186
			AGC = 4001,
			// Token: 0x04003383 RID: 13187
			LCAC,
			// Token: 0x04003384 RID: 13188
			LCC,
			// Token: 0x04003385 RID: 13189
			LCM,
			// Token: 0x04003386 RID: 13190
			LCP,
			// Token: 0x04003387 RID: 13191
			LCT,
			// Token: 0x04003388 RID: 13192
			LCU,
			// Token: 0x04003389 RID: 13193
			LCVP,
			// Token: 0x0400338A RID: 13194
			LFR,
			// Token: 0x0400338B RID: 13195
			LHA,
			// Token: 0x0400338C RID: 13196
			LHD,
			// Token: 0x0400338D RID: 13197
			LKA,
			// Token: 0x0400338E RID: 13198
			LPD,
			// Token: 0x0400338F RID: 13199
			LPH,
			// Token: 0x04003390 RID: 13200
			LSD,
			// Token: 0x04003391 RID: 13201
			LSH,
			// Token: 0x04003392 RID: 13202
			LSL,
			// Token: 0x04003393 RID: 13203
			LSM,
			// Token: 0x04003394 RID: 13204
			LSMR,
			// Token: 0x04003395 RID: 13205
			LST,
			// Token: 0x04003396 RID: 13206
			LSU,
			// Token: 0x04003397 RID: 13207
			LSV,
			// Token: 0x04003398 RID: 13208
			A = 5001,
			// Token: 0x04003399 RID: 13209
			AD,
			// Token: 0x0400339A RID: 13210
			AE,
			// Token: 0x0400339B RID: 13211
			AF,
			// Token: 0x0400339C RID: 13212
			AFS,
			// Token: 0x0400339D RID: 13213
			AG,
			// Token: 0x0400339E RID: 13214
			AGB,
			// Token: 0x0400339F RID: 13215
			AGF,
			// Token: 0x040033A0 RID: 13216
			AGI,
			// Token: 0x040033A1 RID: 13217
			AGMR,
			// Token: 0x040033A2 RID: 13218
			AGOR,
			// Token: 0x040033A3 RID: 13219
			AGOS,
			// Token: 0x040033A4 RID: 13220
			AGR,
			// Token: 0x040033A5 RID: 13221
			AGS,
			// Token: 0x040033A6 RID: 13222
			AGTR,
			// Token: 0x040033A7 RID: 13223
			AH,
			// Token: 0x040033A8 RID: 13224
			AK,
			// Token: 0x040033A9 RID: 13225
			AKA,
			// Token: 0x040033AA RID: 13226
			AKE,
			// Token: 0x040033AB RID: 13227
			AKR,
			// Token: 0x040033AC RID: 13228
			AKS,
			// Token: 0x040033AD RID: 13229
			AO,
			// Token: 0x040033AE RID: 13230
			AOE,
			// Token: 0x040033AF RID: 13231
			AOL,
			// Token: 0x040033B0 RID: 13232
			AOR = 5024,
			// Token: 0x040033B1 RID: 13233
			AOT = 5026,
			// Token: 0x040033B2 RID: 13234
			APA,
			// Token: 0x040033B3 RID: 13235
			APD,
			// Token: 0x040033B4 RID: 13236
			AR,
			// Token: 0x040033B5 RID: 13237
			AS_,
			// Token: 0x040033B6 RID: 13238
			ATC,
			// Token: 0x040033B7 RID: 13239
			ATA,
			// Token: 0x040033B8 RID: 13240
			ATS,
			// Token: 0x040033B9 RID: 13241
			AV,
			// Token: 0x040033BA RID: 13242
			AX,
			// Token: 0x040033BB RID: 13243
			TAGOS = 5101,
			// Token: 0x040033BC RID: 13244
			TAH,
			// Token: 0x040033BD RID: 13245
			TAK,
			// Token: 0x040033BE RID: 13246
			TAKE,
			// Token: 0x040033BF RID: 13247
			TAKR,
			// Token: 0x040033C0 RID: 13248
			TAO1,
			// Token: 0x040033C1 RID: 13249
			TAO2,
			// Token: 0x040033C2 RID: 13250
			MCD = 6001,
			// Token: 0x040033C3 RID: 13251
			MCM,
			// Token: 0x040033C4 RID: 13252
			MCS,
			// Token: 0x040033C5 RID: 13253
			MHC,
			// Token: 0x040033C6 RID: 13254
			ML,
			// Token: 0x040033C7 RID: 13255
			MSC,
			// Token: 0x040033C8 RID: 13256
			MSF,
			// Token: 0x040033C9 RID: 13257
			MSI,
			// Token: 0x040033CA RID: 13258
			MSO = 6010,
			// Token: 0x040033CB RID: 13259
			MST,
			// Token: 0x040033CC RID: 13260
			YAG = 7001,
			// Token: 0x040033CD RID: 13261
			Civilian = 9001,
			// Token: 0x040033CE RID: 13262
			Merchant,
			// Token: 0x040033CF RID: 13263
			Platform,
			// Token: 0x040033D0 RID: 13264
			NGSBuoy,
			// Token: 0x040033D1 RID: 13265
			BottomFixedArraySonar,
			// Token: 0x040033D2 RID: 13266
			MooredSonobuoy,
			// Token: 0x040033D3 RID: 13267
			Special
		}

		// Token: 0x02000B68 RID: 2920
		public enum _WakeDetected : byte
		{
			// Token: 0x040033D5 RID: 13269
			None,
			// Token: 0x040033D6 RID: 13270
			VerySmall,
			// Token: 0x040033D7 RID: 13271
			Small,
			// Token: 0x040033D8 RID: 13272
			Medium,
			// Token: 0x040033D9 RID: 13273
			Large,
			// Token: 0x040033DA RID: 13274
			VeryLarge
		}

		// Token: 0x02000B69 RID: 2921
		[CompilerGenerated]
		public sealed class Class181
		{
			// Token: 0x040033DB RID: 13275
			public double double_0;

			// Token: 0x040033DC RID: 13276
			public double double_1;

			// Token: 0x040033DD RID: 13277
			public Ship ship_0;
		}

		// Token: 0x02000B6A RID: 2922
		[CompilerGenerated]
		public sealed class Class182
		{
			// Token: 0x06006052 RID: 24658 RVA: 0x002DD364 File Offset: 0x002DB564
			internal void method_0(string string_0, ParallelLoopState parallelLoopState_0)
			{
				UnguidedWeapon unguidedWeapon = null;
				this.class181_0.ship_0.m_Scenario.GetUnguidedWeapons().TryGetValue(string_0, ref unguidedWeapon);
				if (!Information.IsNothing(unguidedWeapon) && unguidedWeapon.IsMine())
				{
					short num = (short)this.class181_0.ship_0.GetMaxMineRange(unguidedWeapon.GetWeaponType());
					if (Math.Abs(unguidedWeapon.RelativeBearingTo(this.class181_0.ship_0, true)) <= 90f && Math2.GetDistance(this.class181_0.double_0, this.class181_0.double_1, unguidedWeapon.GetLatitude(null), unguidedWeapon.GetLongitude(null)) * 1852f < (float)num)
					{
						this.bool_0 = true;
						parallelLoopState_0.Stop();
					}
				}
			}

			// Token: 0x040033DE RID: 13278
			public bool bool_0;

			// Token: 0x040033DF RID: 13279
			public Ship.Class181 class181_0;
		}

		// Token: 0x02000B6B RID: 2923
		public sealed class FuelTypeComparator
		{
			// Token: 0x06006054 RID: 24660 RVA: 0x0002AD4B File Offset: 0x00028F4B
			internal bool IsSame(FuelRec fuelRec_)
			{
				return fuelRec_.FuelType == this.FuelType;
			}

			// Token: 0x040033E0 RID: 13280
			public FuelRec._FuelType FuelType;
		}
	}
}

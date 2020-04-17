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
	// Token: 潜艇平台
	public sealed class Submarine : Platform, ICargo
	{
		// Token: 0x06006242 RID: 25154 RVA: 0x002FC7D0 File Offset: 0x002FA9D0
		private Submarine() : base(ref Submarine.scenario, null)
		{
			this.submarineCode = default(Submarine._SubmarineCode);
			this.m_PressureHull = new PressureHull(this);
			this.m_Rudder = new Rudder(this);
			this.m_CIC = new CIC(this, "Conn / CIC");
			this.m_Cargo = new Cargo(this);
			this.IsSubmarine = true;
		}

		// Token: 0x06006243 RID: 25155 RVA: 0x0002B556 File Offset: 0x00029756
		public bool IsBiologics()
		{
			return this.Type == Submarine._SubmarineType.Biologics;
		}

		// Token: 0x06006244 RID: 25156 RVA: 0x0002B565 File Offset: 0x00029765
		public bool IsFalseTarget()
		{
			return this.Type == Submarine._SubmarineType.FalseTarget;
		}

		// Token: 0x06006245 RID: 25157 RVA: 0x002FC860 File Offset: 0x002FAA60
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					if (!Information.IsNothing(this.GetSide(false)))
					{
						xmlWriter_0.WriteStartElement("Submarine");
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
								List<RangeSymbol>.Enumerator enumerator = base.GetRangeSymbols().GetEnumerator();
								xmlWriter_0.WriteStartElement("RangeSymbols");
								try
								{
									while (enumerator.MoveNext())
									{
										enumerator.Current.Save(ref xmlWriter_0);
									}
								}
								finally
								{
									((IDisposable)enumerator).Dispose();
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
							xmlWriter_0.WriteElementString("DT", ((byte)this.GetDesiredTurnRate()).ToString());
							xmlWriter_0.WriteElementString("DTN", ((byte)this.GetDesiredTurnRate_Navigation()).ToString());
							xmlWriter_0.WriteElementString("DA", XmlConvert.ToString(this.GetDesiredAltitude()));
							if (!Information.IsNothing(this.m_ProficiencyLevel))
							{
								xmlWriter_0.WriteElementString("Prof", ((int)this.m_ProficiencyLevel.Value).ToString());
							}
							xmlWriter_0.WriteElementString("ThrottleSetting", ((byte)this.GetThrottle()).ToString());
							xmlWriter_0.WriteStartElement("Sensors");
							Sensor[] sensors = this.m_Sensors;
							for (int i = 0; i < sensors.Length; i++)
							{
								sensors[i].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
								xmlWriter_0.Flush();
							}
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Comms");
							CommDevice[] commDevices = this.m_CommDevices;
							for (int j = 0; j < commDevices.Length; j++)
							{
								commDevices[j].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
								xmlWriter_0.Flush();
							}
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Propulsion");
							using (IEnumerator<Engine> enumerator2 = this.GetEngines().GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									enumerator2.Current.Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
									xmlWriter_0.Flush();
								}
							}
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Fuel");
							FuelRec[] fuelRecs = this.m_FuelRecs;
							for (int k = 0; k < fuelRecs.Length; k++)
							{
								fuelRecs[k].Save(ref xmlWriter_0);
								xmlWriter_0.Flush();
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
								xmlWriter_0.Flush();
							}
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Magazines");
							Magazine[] magazines = this.m_Magazines;
							for (int m = 0; m < magazines.Length; m++)
							{
								magazines[m].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
								xmlWriter_0.Flush();
							}
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("OnboardCargo");
							Cargo[] onboardCargos = this.m_OnboardCargos;
							for (int n = 0; n < onboardCargos.Length; n++)
							{
								onboardCargos[n].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
								xmlWriter_0.Flush();
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
							if (this.GetAirFacilities().Length > 0)
							{
								xmlWriter_0.WriteStartElement("AirFacilities");
								AirFacility[] airFacilities = this.GetAirFacilities();
								for (int num = 0; num < airFacilities.Length; num++)
								{
									airFacilities[num].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
									xmlWriter_0.Flush();
								}
								xmlWriter_0.WriteEndElement();
							}
							if (this.GetDockFacilities().Length > 0)
							{
								xmlWriter_0.WriteStartElement("DockFacilities");
								DockFacility[] dockFacilities = this.GetDockFacilities();
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
							xmlWriter_0.WriteStartElement("PressureHull");
							this.m_PressureHull.Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Rudder");
							this.m_Rudder.Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("CIC");
							this.m_CIC.Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
							xmlWriter_0.WriteEndElement();
							this.GetSubmarineNavigator().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteStartElement("Submarine_AI");
							this.GetSubmarineAI().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Submarine_Kinematics");
							this.GetSubmarineKinematics().Save(ref xmlWriter_0);
							xmlWriter_0.WriteEndElement();
							this.GetSubmarineSensory().Save(ref xmlWriter_0);
							this.GetSubmarineWeaponry().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteStartElement("Submarine_CommStuff");
							this.GetSubmarineCommStuff().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteEndElement();
							this.GetSubmarineDamage().Save(ref xmlWriter_0);
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
					ex2.Data.Add("Error at 100799", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006246 RID: 25158 RVA: 0x002FD344 File Offset: 0x002FB544
		public static Submarine ShallowRebuild(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_1, ref Scenario scenario_1)
		{
			Submarine submarine = null;
			try
			{
				submarine = Submarine.smethod_2(ref xmlNode_0, ref dictionary_1, ref scenario_1, scenario_1.LoadStockUnits);
			}
			catch (Exception0 projectError)
			{
				ProjectData.SetProjectError(projectError);
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				dictionary_1.Remove(innerText);
				submarine = Submarine.smethod_2(ref xmlNode_0, ref dictionary_1, ref scenario_1, true);
				string text = "";
				if (submarine.HasParentGroup())
				{
					text = "(member of group: [" + submarine.GetParentGroup(false).Name + "])";
				}
				scenario_1.LoadingNotices.Add(string.Concat(new string[]
				{
					"The following submarine:[",
					submarine.Name,
					"]",
					text,
					" failed to shallow-rebuild because of a component missing. The submarine was instead deep-rebuilt, and instantiated in its pristine DB-stock condition. All customizations present in the submarine's components (damaged components, weapon additions/removals etc. etc.) have been lost. Please re-apply any necessary customizations either manually or using an SBR script."
				}));
				ProjectData.ClearProjectError();
			}
			return submarine;
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x002FD428 File Offset: 0x002FB628
		private static Submarine smethod_2(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_1, ref Scenario scenario_1, bool bool_17)
		{
			Submarine submarine = null;
			Submarine result;
			try
			{
				Submarine submarine2 = new Submarine();
				submarine2.m_Scenario = scenario_1;
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_1.ContainsKey(innerText))
				{
					submarine = (Submarine)dictionary_1[innerText];
				}
				else
				{
					submarine2.SetGuid(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						submarine = submarine2;
					}
					else
					{
						dictionary_1.Add(submarine2.GetGuid(), submarine2);
						int num = Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "DBID").InnerText);
						try
						{
							DBFunctions.LoadSubmarineData(ref scenario_1, ref submarine2, num, bool_17);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							dictionary_1.Remove(submarine2.GetGuid());
							scenario_1.LoadingNotices.Add("Submarine with Database ID " + Conversions.ToString(num) + " is missing from the database and has not been loaded.");
							ProjectData.ClearProjectError();
							result = submarine;
							return result;
						}
						if (bool_17)
						{
							submarine2.LoadAirFacilities(ref xmlNode_0, ref dictionary_1, ref scenario_1);
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
										if (num2 <= 2008421230u)
										{
											if (num2 != 1305748348u)
											{
												if (num2 != 1717708934u)
												{
													if (num2 != 2008421230u || Operators.CompareString(name, "Comms", false) != 0)
													{
														continue;
													}
													IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
													try
													{
														while (enumerator2.MoveNext())
														{
															XmlNode xmlNode2 = (XmlNode)enumerator2.Current;
															CommDevice commDevice = CommDevice.Load(ref xmlNode2, ref dictionary_1, submarine2);
															submarine2.AddCommDevice(commDevice);
															commDevice.SetParentPlatform(submarine2);
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
												if (Operators.CompareString(name, "CIC", false) == 0)
												{
													submarine2.m_CIC = CIC.Load(ref xmlNode, ref dictionary_1);
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
												IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
												try
												{
													while (enumerator3.MoveNext())
													{
														XmlNode xmlNode3 = (XmlNode)enumerator3.Current;
														Cargo cargo = Cargo.Load(ref xmlNode3, ref dictionary_1, submarine2);
														ScenarioArrayUtil.AddCargo(ref submarine2.m_OnboardCargos, cargo);
														cargo.SetParentPlatform(submarine2);
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
										if (num2 != 2096367071u)
										{
											if (num2 != 2171969073u)
											{
												if (num2 != 2241118125u || Operators.CompareString(name, "Fuel", false) != 0)
												{
													continue;
												}
												IEnumerator enumerator4 = xmlNode.ChildNodes.GetEnumerator();
												try
												{
													while (enumerator4.MoveNext())
													{
														XmlNode xmlNode4 = (XmlNode)enumerator4.Current;
														FuelRec fuelRec_ = FuelRec.Load(ref xmlNode4, ref dictionary_1);
														ScenarioArrayUtil.AddFuelRec(ref submarine2.m_FuelRecs, fuelRec_);
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
											if (Operators.CompareString(name, "PressureHull", false) == 0)
											{
												submarine2.m_PressureHull = PressureHull.Load(ref xmlNode, ref dictionary_1);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "DockFacilities", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator5 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator5.MoveNext())
												{
													XmlNode xmlNode5 = (XmlNode)enumerator5.Current;
													DockFacility dockFacility = DockFacility.Load(ref xmlNode5, ref dictionary_1, ref scenario_1);
													submarine2.AddDockFacility(dockFacility);
													dockFacility.SetParentPlatform(submarine2);
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
									if (num2 <= 3109521583u)
									{
										if (num2 != 2246682072u)
										{
											if (num2 != 2424405304u)
											{
												if (num2 == 3109521583u && Operators.CompareString(name, "Rudder", false) == 0)
												{
													submarine2.m_Rudder = Rudder.Load(ref xmlNode, ref dictionary_1);
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
														Sensor sensor = Sensor.Load((XmlNode)enumerator6.Current, dictionary_1, submarine2);
														ScenarioArrayUtil.AddSensor(ref submarine2.m_Sensors, sensor);
														sensor.SetParentPlatform(submarine2);
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
												ActiveUnit activeUnit = submarine2;
												Engine engine = Engine.Load(ref xmlNode6, ref dictionary_1, ref activeUnit);
												submarine2.GetEngines().Add(engine);
												engine.SetParentPlatform(submarine2);
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
													AirFacility airFacility = AirFacility.Load(ref xmlNode7, ref dictionary_1, ref scenario_1);
													submarine2.AddAirFacility(airFacility);
													airFacility.SetParentPlatform(submarine2);
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
												Magazine magazine = Magazine.smethod_2(ref xmlNode8, ref dictionary_1, ref scenario_1);
												ScenarioArrayUtil.AddMagazine(ref submarine2.m_Magazines, magazine);
												magazine.SetParentPlatform(submarine2);
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
												Mount mount = Mount.Load(ref xmlNode9, ref dictionary_1, submarine2);
												ScenarioArrayUtil.AddMount(ref submarine2.m_Mounts, mount);
												mount.SetParentPlatform(submarine2);
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
						bool flag = false;
						IEnumerator enumerator11 = xmlNode_0.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator11.MoveNext())
							{
								XmlNode xmlNode10 = (XmlNode)enumerator11.Current;
								string name2 = xmlNode10.Name;
								uint num2 = Class382.smethod_0(name2);
								if (num2 > 1738278884u)
								{
									if (num2 <= 2904824734u)
									{
										if (num2 <= 2247649009u)
										{
											if (num2 <= 2010780873u)
											{
												if (num2 <= 1907898041u)
												{
													if (num2 != 1836990821u)
													{
														if (num2 == 1907898041u && Operators.CompareString(name2, "Submarine_Weaponry", false) == 0)
														{
															Submarine submarine3 = submarine2;
															ActiveUnit activeUnit = submarine2;
															submarine3.submarine_Weaponry = Submarine_Weaponry.Read(ref xmlNode10, ref dictionary_1, ref activeUnit);
															continue;
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
													if (num2 == 2010780873u && Operators.CompareString(name2, "CA", false) == 0)
													{
														goto IL_1357;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Latitude_UnitEntersAreaCheck", false) == 0)
													{
														submarine2.SetLatitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode10.InnerText)));
														continue;
													}
													continue;
												}
											}
											else if (num2 <= 2066337159u)
											{
												if (num2 != 2030505933u)
												{
													if (num2 == 2066337159u && Operators.CompareString(name2, "DesiredAltitude", false) == 0)
													{
														goto IL_15CC;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Submarine_Sensory", false) == 0)
													{
														Submarine submarine4 = submarine2;
														ActiveUnit activeUnit = submarine2;
														submarine4.submarine_Sensory = Submarine_Sensory.Load(ref xmlNode10, ref dictionary_1, ref activeUnit);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 2128224206u)
											{
												if (num2 == 2247649009u && Operators.CompareString(name2, "AssignedMission", false) == 0 && xmlNode10.HasChildNodes)
												{
													XmlNode xmlNode11 = xmlNode10.ChildNodes[0];
													submarine2.AssignedMissionName = xmlNode11.InnerText;
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "CH", false) != 0)
												{
													continue;
												}
												goto IL_10A0;
											}
										}
										else if (num2 <= 2617265898u)
										{
											if (num2 <= 2564648390u)
											{
												if (num2 != 2496321123u)
												{
													if (num2 == 2564648390u && Operators.CompareString(name2, "Lon", false) == 0)
													{
														goto IL_1AA2;
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
															RangeSymbol item = RangeSymbol.Load((XmlNode)enumerator12.Current, dictionary_1);
															submarine2.GetRangeSymbols().Add(item);
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
												if (num2 == 2617265898u && Operators.CompareString(name2, "Submarine_CommStuff", false) == 0)
												{
													Submarine submarine5 = submarine2;
													ActiveUnit activeUnit = submarine2;
													submarine5.submarine_CommStuff = Submarine_CommStuff.Load(ref xmlNode10, ref dictionary_1, ref activeUnit);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Side", false) == 0)
												{
													submarine2.strSide = xmlNode10.InnerText;
													continue;
												}
												continue;
											}
										}
										else if (num2 <= 2844845263u)
										{
											if (num2 != 2749693904u)
											{
												if (num2 == 2844845263u && Operators.CompareString(name2, "SBEO_Altitude", false) == 0)
												{
													submarine2.SBEngagedOffensive_Altitude = XmlConvert.ToSingle(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "DesiredSpeed", false) == 0)
												{
													goto IL_1471;
												}
												continue;
											}
										}
										else if (num2 != 2874698282u)
										{
											if (num2 == 2904824734u && Operators.CompareString(name2, "SBEO_Altitude_TF", false) == 0)
											{
												submarine2.SBEngagedOffensive_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "AssignedTaskPool", false) == 0 && xmlNode10.HasChildNodes)
											{
												XmlNode xmlNode12 = xmlNode10.ChildNodes[0];
												submarine2.AssignedTaskPoolName = xmlNode12.InnerText;
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 3251319825u)
									{
										if (num2 <= 3020647921u)
										{
											if (num2 <= 2923116889u)
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
														submarine2.SBR_ThrottleSetting = ActiveUnit.Throttle.FullStop;
														continue;
													}
													if (Operators.CompareString(innerText2, "Loiter", false) == 0)
													{
														submarine2.SBR_ThrottleSetting = ActiveUnit.Throttle.Loiter;
														continue;
													}
													if (Operators.CompareString(innerText2, "Cruise", false) == 0)
													{
														submarine2.SBR_ThrottleSetting = ActiveUnit.Throttle.Cruise;
														continue;
													}
													if (Operators.CompareString(innerText2, "Full", false) == 0)
													{
														submarine2.SBR_ThrottleSetting = ActiveUnit.Throttle.Full;
														continue;
													}
													if (Operators.CompareString(innerText2, "Flank", false) != 0)
													{
														submarine2.SBR_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
														continue;
													}
													submarine2.SBR_ThrottleSetting = ActiveUnit.Throttle.Flank;
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "Message", false) == 0)
													{
														submarine2.Message = xmlNode10.InnerText;
														continue;
													}
													continue;
												}
											}
											else if (num2 != 3001749054u)
											{
												if (num2 == 3020647921u && Operators.CompareString(name2, "ActiveUnit_DockingOps", false) == 0)
												{
													ActiveUnit activeUnit2 = submarine2;
													ActiveUnit activeUnit = submarine2;
													((Submarine)activeUnit2).m_DockingOps = ActiveUnit_DockingOps.Load(ref xmlNode10, ref dictionary_1, ref activeUnit);
													continue;
												}
												continue;
											}
											else if (Operators.CompareString(name2, "Lat", false) != 0)
											{
												continue;
											}
										}
										else if (num2 <= 3189373444u)
										{
											if (num2 != 3070770765u)
											{
												if (num2 == 3189373444u && Operators.CompareString(name2, "LonLR", false) == 0)
												{
													submarine2.SetLongitudeLR(new double?(XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", "."))));
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBR_Altitude", false) == 0)
												{
													submarine2.SBR_Altitude = XmlConvert.ToSingle(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 3204468496u)
										{
											if (num2 == 3251319825u && Operators.CompareString(name2, "SBR_TF", false) == 0)
											{
												submarine2.SBR_TerrainFollowing = Conversions.ToBoolean(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SBEO", false) == 0)
											{
												submarine2.SBEngagedOffensive = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
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
													goto IL_14E8;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "CurrentSpeed", false) == 0)
												{
													goto IL_1A0E;
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
												submarine2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.FullStop;
												continue;
											}
											if (Operators.CompareString(innerText3, "Loiter", false) == 0)
											{
												submarine2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Loiter;
												continue;
											}
											if (Operators.CompareString(innerText3, "Cruise", false) == 0)
											{
												submarine2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Cruise;
												continue;
											}
											if (Operators.CompareString(innerText3, "Full", false) == 0)
											{
												submarine2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Full;
												continue;
											}
											if (Operators.CompareString(innerText3, "Flank", false) != 0)
											{
												submarine2.SBEngagedOffensive_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											submarine2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Flank;
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SBED", false) == 0)
											{
												submarine2.SBEngagedDefensive = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 3792306253u)
									{
										if (num2 != 3736393060u)
										{
											if (num2 == 3792306253u && Operators.CompareString(name2, "Longitude_UnitEntersAreaCheck", false) == 0)
											{
												submarine2.SetLongitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode10.InnerText)));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "ParentGroup", false) == 0)
											{
												submarine2.ParentGroupName = xmlNode10.InnerText;
												continue;
											}
											continue;
										}
									}
									else if (num2 != 4080539297u)
									{
										if (num2 != 4146159553u)
										{
											if (num2 == 4152621540u && Operators.CompareString(name2, "CurrentHeading", false) == 0)
											{
												goto IL_10A0;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "Submarine_Navigator", false) == 0)
											{
												Submarine submarine6 = submarine2;
												ActiveUnit activeUnit = submarine2;
												submarine6.submarine_Navigator = Submarine_Navigator.Load(ref xmlNode10, ref dictionary_1, ref activeUnit);
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "IsAutoDetectable", false) == 0)
										{
											goto IL_13FC;
										}
										continue;
									}
									submarine2.SetLatitude(null, XmlConvert.ToDouble(xmlNode10.InnerText));
									continue;
									IL_10A0:
									submarine2.SetCurrentHeading(XmlConvert.ToSingle(xmlNode10.InnerText));
									continue;
								}
								if (num2 <= 827630232u)
								{
									if (num2 <= 468031071u)
									{
										if (num2 <= 266367750u)
										{
											if (num2 <= 11523833u)
											{
												if (num2 != 6222351u)
												{
													if (num2 == 11523833u && Operators.CompareString(name2, "Submarine_Damage", false) == 0)
													{
														Submarine submarine7 = submarine2;
														ActiveUnit activeUnit = submarine2;
														submarine7.submarine_Damage = Submarine_Damage.Load(ref xmlNode10, ref dictionary_1, ref activeUnit);
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
													if (Versioned.IsNumeric(xmlNode10.InnerText))
													{
														if (Conversions.ToByte(xmlNode10.InnerText) == 18)
														{
															flag = true;
														}
														else
														{
															submarine2.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText));
														}
													}
													else
													{
														submarine2.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode10.InnerText, true));
													}
													if (submarine2.GetUnitStatus() == (ActiveUnit._ActiveUnitStatus)9)
													{
														submarine2.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 263373746u)
											{
												if (num2 == 266367750u && Operators.CompareString(name2, "Name", false) == 0)
												{
													submarine2.Name = xmlNode10.InnerText;
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "FSBR", false) == 0)
												{
													submarine2.FuelStateBR = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode10.InnerText);
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
												submarine2.SetDesiredTurnRate_Navigation((Waypoint._TurnRate)Conversions.ToByte(xmlNode10.InnerText));
												continue;
											}
											if (num2 != 441941816u)
											{
												if (num2 == 468031071u && Operators.CompareString(name2, "SBED_Altitude_TF", false) == 0)
												{
													submarine2.SBEngagedDefensive_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else if (Operators.CompareString(name2, "CurrentAltitude", false) != 0)
											{
												continue;
											}
										}
									}
									else if (num2 <= 664498478u)
									{
										if (num2 <= 506380204u)
										{
											if (num2 != 485784328u)
											{
												if (num2 == 506380204u && Operators.CompareString(name2, "LatLR", false) == 0)
												{
													submarine2.SetLatitudeLR(new double?(XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", "."))));
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "IsAD", false) == 0)
												{
													goto IL_13FC;
												}
												continue;
											}
										}
										else if (num2 != 634280640u)
										{
											if (num2 == 664498478u && Operators.CompareString(name2, "FuelState", false) == 0)
											{
												submarine2.activeUnitFuelState = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "DS", false) == 0)
											{
												goto IL_1471;
											}
											continue;
										}
									}
									else if (num2 <= 803468658u)
									{
										if (num2 != 751723973u)
										{
											if (num2 == 803468658u && Operators.CompareString(name2, "Submarine_Kinematics", false) == 0)
											{
												ActiveUnit_Kinematics.Load(xmlNode10, dictionary_1, submarine2);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "DT", false) == 0)
											{
												goto IL_14E8;
											}
											continue;
										}
									}
									else if (num2 != 803760973u)
									{
										if (num2 == 827630232u && Operators.CompareString(name2, "SBED_Altitude", false) == 0)
										{
											submarine2.SBEngagedDefensive_Altitude = XmlConvert.ToSingle(xmlNode10.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name2, "DamagePts", false) == 0)
										{
											submarine2.SetDamagePts(false, XmlConvert.ToSingle(xmlNode10.InnerText));
											continue;
										}
										continue;
									}
								}
								else if (num2 <= 1255847155u)
								{
									if (num2 <= 1087276353u)
									{
										if (num2 <= 936277782u)
										{
											if (num2 != 892023141u)
											{
												if (num2 == 936277782u && Operators.CompareString(name2, "DA", false) == 0)
												{
													goto IL_15CC;
												}
												continue;
											}
											else if (Operators.CompareString(name2, "DesiredHeading", false) != 0)
											{
												continue;
											}
										}
										else if (num2 != 944764534u)
										{
											if (num2 != 1087276353u || Operators.CompareString(name2, "DH", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name2, "Submarine_AI", false) == 0)
											{
												Submarine submarine8 = submarine2;
												ActiveUnit activeUnit = submarine2;
												submarine8.submarine_AI = Submarine_AI.Load(ref xmlNode10, ref dictionary_1, ref activeUnit);
												continue;
											}
											continue;
										}
										submarine2.SetDesiredHeading(ActiveUnit._TurnRate.const_0, XmlConvert.ToSingle(xmlNode10.InnerText));
										continue;
									}
									if (num2 <= 1156592502u)
									{
										if (num2 != 1143797280u)
										{
											if (num2 == 1156592502u && Operators.CompareString(name2, "SBR", false) == 0)
											{
												submarine2.SBR = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SBR_Altitude_TF", false) == 0)
											{
												submarine2.SBR_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 != 1175569298u)
									{
										if (num2 != 1255847155u || Operators.CompareString(name2, "ThrottleSetting", false) != 0)
										{
											continue;
										}
										string innerText4 = xmlNode10.InnerText;
										if (Operators.CompareString(innerText4, "FullStop", false) == 0)
										{
											submarine2.currentThrottle = ActiveUnit.Throttle.FullStop;
											continue;
										}
										if (Operators.CompareString(innerText4, "Loiter", false) == 0)
										{
											submarine2.currentThrottle = ActiveUnit.Throttle.Loiter;
											continue;
										}
										if (Operators.CompareString(innerText4, "Cruise", false) == 0)
										{
											submarine2.currentThrottle = ActiveUnit.Throttle.Cruise;
											continue;
										}
										if (Operators.CompareString(innerText4, "Full", false) == 0)
										{
											submarine2.currentThrottle = ActiveUnit.Throttle.Full;
											continue;
										}
										if (Operators.CompareString(innerText4, "Flank", false) != 0)
										{
											submarine2.currentThrottle = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
											continue;
										}
										submarine2.currentThrottle = ActiveUnit.Throttle.Flank;
										continue;
									}
									else
									{
										if (Operators.CompareString(name2, "ActiveUnit_AirOps", false) == 0)
										{
											ActiveUnit activeUnit3 = submarine2;
											ActiveUnit activeUnit = submarine2;
											((Submarine)activeUnit3).m_AirOps = ActiveUnit_AirOps.Load(ref xmlNode10, ref dictionary_1, ref activeUnit);
											continue;
										}
										continue;
									}
								}
								else if (num2 <= 1476905714u)
								{
									if (num2 <= 1422437055u)
									{
										if (num2 != 1259548010u)
										{
											if (num2 == 1422437055u && Operators.CompareString(name2, "Doctrine", false) == 0)
											{
												submarine2.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode10, submarine2);
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
											string innerText5 = xmlNode10.InnerText;
											if (Operators.CompareString(innerText5, "FullStop", false) == 0)
											{
												submarine2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.FullStop;
												continue;
											}
											if (Operators.CompareString(innerText5, "Loiter", false) == 0)
											{
												submarine2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Loiter;
												continue;
											}
											if (Operators.CompareString(innerText5, "Cruise", false) == 0)
											{
												submarine2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Cruise;
												continue;
											}
											if (Operators.CompareString(innerText5, "Full", false) == 0)
											{
												submarine2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Full;
												continue;
											}
											if (Operators.CompareString(innerText5, "Flank", false) != 0)
											{
												submarine2.SBEngagedDefensive_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											submarine2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Flank;
											continue;
										}
									}
									else if (num2 != 1444793274u)
									{
										if (num2 == 1476905714u && Operators.CompareString(name2, "WeaponState", false) == 0)
										{
											submarine2.weaponState = (ActiveUnit._ActiveUnitWeaponState)Conversions.ToByte(xmlNode10.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name2, "Prof", false) == 0)
										{
											submarine2.SetProficiencyLevel(new GlobalVariables.ProficiencyLevel?((GlobalVariables.ProficiencyLevel)Conversions.ToInteger(xmlNode10.InnerText)));
											continue;
										}
										continue;
									}
								}
								else if (num2 <= 1708783731u)
								{
									if (num2 != 1488303767u)
									{
										if (num2 == 1708783731u && Operators.CompareString(name2, "CS", false) == 0)
										{
											goto IL_1A0E;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name2, "SBEO_TF", false) == 0)
										{
											submarine2.SBEngagedOffensive_TerrainFollowing = Conversions.ToBoolean(xmlNode10.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num2 != 1729717486u)
								{
									if (num2 == 1738278884u && Operators.CompareString(name2, "SBED_TF", false) == 0)
									{
										submarine2.SBEngagedDefensive_TerrainFollowing = Conversions.ToBoolean(xmlNode10.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name2, "Longitude", false) == 0)
									{
										goto IL_1AA2;
									}
									continue;
								}
								IL_1357:
								submarine2.SetAltitude_ASL(false, XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_13FC:
								submarine2.SetIsAutoDetectable(null, Conversions.ToBoolean(xmlNode10.InnerText));
								continue;
								IL_1471:
								submarine2.SetDesiredSpeed(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_14E8:
								submarine2.SetDesiredTurnRate((ActiveUnit._TurnRate)Conversions.ToByte(xmlNode10.InnerText));
								continue;
								IL_15CC:
								submarine2.SetDesiredAltitude(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_1A0E:
								submarine2.SetCurrentSpeed(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_1AA2:
								submarine2.SetLongitude(null, XmlConvert.ToDouble(xmlNode10.InnerText));
							}
						}
						finally
						{
							if (enumerator11 is IDisposable)
							{
								(enumerator11 as IDisposable).Dispose();
							}
						}
						float maxAltitude = submarine2.GetSubmarineKinematics().GetMaxAltitude();
						float minAltitude = submarine2.GetSubmarineKinematics().GetMinAltitude();
						if (submarine2.GetCurrentAltitude_ASL(false) > maxAltitude)
						{
							submarine2.SetAltitude_ASL(false, maxAltitude);
						}
						else if (submarine2.GetCurrentAltitude_ASL(false) < minAltitude)
						{
							submarine2.SetAltitude_ASL(false, minAltitude);
						}
						if (submarine2.GetDesiredAltitude() > maxAltitude)
						{
							submarine2.SetDesiredAltitude(maxAltitude);
						}
						else if (submarine2.GetDesiredAltitude() < minAltitude)
						{
							submarine2.SetDesiredAltitude(minAltitude);
						}
						if (flag)
						{
							submarine2.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries);
						}
						submarine = submarine2;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100800", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = submarine;
			return result;
		}

		// Token: 0x06006248 RID: 25160 RVA: 0x002FF14C File Offset: 0x002FD34C
		public override float GetArea()
		{
			return this.Length * this.Beam;
		}

		// Token: 0x06006249 RID: 25161 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool IsPlatform()
		{
			return true;
		}

		// Token: 0x0600624A RID: 25162 RVA: 0x0002B574 File Offset: 0x00029774
		public override GlobalVariables.ActiveUnitType GetUnitType()
		{
			return GlobalVariables.ActiveUnitType.Submarine;
		}

		// Token: 0x0600624B RID: 25163 RVA: 0x002FF168 File Offset: 0x002FD368
		public override ActiveUnit._ActiveUnitFuelState GetFuelState(GeoPoint geoPoint_0)
		{
			ActiveUnit._ActiveUnitFuelState result = ActiveUnit._ActiveUnitFuelState.None;
			try
			{
				if (this.IsNuclearPropelled())
				{
					result = ActiveUnit._ActiveUnitFuelState.None;
				}
				else if (this.IsROV() && this.GetFuelRecs().Count<FuelRec>() == 0)
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
				ex2.Data.Add("Error at 100801", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600624C RID: 25164 RVA: 0x002FF230 File Offset: 0x002FD430
		public override ActiveUnit._ActiveUnitFuelState GetActiveUnitFuelState(ActiveUnit activeUnit_0, GeoPoint geoPoint_0)
		{
			ActiveUnit._ActiveUnitFuelState activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.None;
			ActiveUnit._ActiveUnitFuelState result;
			try
			{
				Engine._PropulsionType propulsionType;
				if (this.GetEngines().Where(Submarine.EngineFunc1).Count<Engine>() > 0)
				{
					propulsionType = Engine._PropulsionType.Diesel;
				}
				else
				{
					propulsionType = Engine._PropulsionType.Electric;
				}
				int num = this.GetEngines().Count - 1;
				int i = 0;
				int int_ = 0;
				Engine engine_ = null;
				float num2;
				float num3;
				float num4;
				float horizontalRange;
				while (i <= num)
				{
					Engine engine = this.GetEngines()[i];
					if (engine.PropulsionType != propulsionType)
					{
						i++;
					}
					else
					{
						engine_ = engine;
						int_ = i;
						num2 = Math.Max(-20f, this.GetSubmarineKinematics().GetMinAltitude());
						num3 = (float)this.GetSubmarineKinematics().GetSpeed(num2, ActiveUnit.Throttle.Cruise);
						num4 = (float)this.method_154(ActiveUnit.Throttle.Cruise, null, new float?(num3), new float?(num2), engine_, int_);
						if (num4 <= 900f)
						{
							activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.IsBingo;
							result = ActiveUnit._ActiveUnitFuelState.IsBingo;
							return result;
						}
						horizontalRange = base.GetHorizontalRange(activeUnit_0);
						if ((double)(num4 * (num3 / 3600f)) >= (double)horizontalRange * 1.1)
						{
							activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.None;
							result = ActiveUnit._ActiveUnitFuelState.None;
							return result;
						}
						activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.IsBingo;
						result = ActiveUnit._ActiveUnitFuelState.IsBingo;
						return result;
					}
				}
				num2 = Math.Max(-20f, this.GetSubmarineKinematics().GetMinAltitude());
				num3 = (float)this.GetSubmarineKinematics().GetSpeed(num2, ActiveUnit.Throttle.Cruise);
				num4 = (float)this.method_154(ActiveUnit.Throttle.Cruise, null, new float?(num3), new float?(num2), engine_, int_);
				if (num4 <= 900f)
				{
					activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.IsBingo;
					result = ActiveUnit._ActiveUnitFuelState.IsBingo;
					return result;
				}
				horizontalRange = base.GetHorizontalRange(activeUnit_0);
				if ((double)(num4 * (num3 / 3600f)) >= (double)horizontalRange * 1.1)
				{
					activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.None;
					result = ActiveUnit._ActiveUnitFuelState.None;
					return result;
				}
				activeUnitFuelState = ActiveUnit._ActiveUnitFuelState.IsBingo;
				result = ActiveUnit._ActiveUnitFuelState.IsBingo;
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100802", "");
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

		// Token: 0x0600624D RID: 25165 RVA: 0x002FF454 File Offset: 0x002FD654
		public Dictionary<int, Engine> method_129()
		{
			if (Information.IsNothing(this.dictionary_0))
			{
				this.dictionary_0 = this.GetSubmarineAI().method_93();
			}
			return this.dictionary_0;
		}

		// Token: 0x0600624E RID: 25166 RVA: 0x0002B577 File Offset: 0x00029777
		public void method_130(Dictionary<int, Engine> dictionary_1)
		{
			this.dictionary_0 = dictionary_1;
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x002FF48C File Offset: 0x002FD68C
		public Engine GetEngine()
		{
			if (Information.IsNothing(this.m_Engine))
			{
				this.GetSubmarineAI().method_93();
			}
			return this.m_Engine;
		}

		// Token: 0x06006250 RID: 25168 RVA: 0x0002B580 File Offset: 0x00029780
		public void SetEngine(Engine engine_1)
		{
			this.m_Engine = engine_1;
		}

		// Token: 0x06006251 RID: 25169 RVA: 0x002FF4C0 File Offset: 0x002FD6C0
		public int method_133()
		{
			if (Information.IsNothing(this.m_Engine))
			{
				this.GetSubmarineAI().method_93();
			}
			return this.int_7;
		}

		// Token: 0x06006252 RID: 25170 RVA: 0x0002B589 File Offset: 0x00029789
		public void method_134(int int_8)
		{
			this.int_7 = int_8;
		}

		// Token: 0x06006253 RID: 25171 RVA: 0x0023DA38 File Offset: 0x0023BC38
		public override float GetDesiredSpeed()
		{
			return base.GetDesiredSpeed();
		}

		// Token: 0x06006254 RID: 25172 RVA: 0x0002AC14 File Offset: 0x00028E14
		public override void SetDesiredSpeed(float value)
		{
			if (value != this.GetDesiredSpeed())
			{
				base.SetDesiredSpeed(value);
			}
		}

		// Token: 0x06006255 RID: 25173 RVA: 0x001913AC File Offset: 0x0018F5AC
		public override float GetDesiredAltitude()
		{
			return base.GetDesiredAltitude();
		}

		// Token: 0x06006256 RID: 25174 RVA: 0x002FF4F4 File Offset: 0x002FD6F4
		public override void SetDesiredAltitude(float value)
		{
			float desiredAltitude = this.GetDesiredAltitude();
			if (this.GetDesiredAltitude() < -20f && this.GetSubmarineDamage().GetFireIntensityLevel() > ActiveUnit_Damage.FireIntensityLevel.Minor)
			{
				value = -20f;
			}
			if (this.GetSubmarineDamage().GetFloodingIntensityLevel() > ActiveUnit_Damage.FloodingIntensityLevel.Minor)
			{
				value = 0f;
			}
			if (desiredAltitude != value && value < -20f)
			{
				this.method_150();
			}
			base.SetDesiredAltitude(value);
		}

		// Token: 0x06006257 RID: 25175 RVA: 0x0002B592 File Offset: 0x00029792
		public override bool IsRunOutOfFuel()
		{
			return !this.IsNuclearPropelled() && this.GetFuelRecs().Count<FuelRec>() != 0 && base.IsRunOutOfFuel();
		}

		// Token: 0x06006258 RID: 25176 RVA: 0x0002B5B2 File Offset: 0x000297B2
		public bool method_135()
		{
			return this.GetCurrentSpeed() >= (float)this.GetSubmarineKinematics().method_8(this.GetCurrentAltitude_ASL(false));
		}

		// Token: 0x06006259 RID: 25177 RVA: 0x002FF570 File Offset: 0x002FD770
		public Ship._WakeDetected GetWakeDetected()
		{
			Ship._WakeDetected result;
			if (this.GetCurrentSpeed() == 0f)
			{
				result = Ship._WakeDetected.None;
			}
			else if (this.IsShallowerThanPeriscopeDepth())
			{
				result = Ship._WakeDetected.Small;
			}
			else if (this.IsAtPeriscopeDepth())
			{
				result = Ship._WakeDetected.VerySmall;
			}
			else
			{
				result = Ship._WakeDetected.None;
			}
			return result;
		}

		// Token: 0x0600625A RID: 25178 RVA: 0x002FF5B8 File Offset: 0x002FD7B8
		public Submarine_Navigator GetSubmarineNavigator()
		{
			if (Information.IsNothing(this.submarine_Navigator))
			{
				ActiveUnit activeUnit = this;
				this.submarine_Navigator = new Submarine_Navigator(ref activeUnit);
			}
			return this.submarine_Navigator;
		}

		// Token: 0x0600625B RID: 25179 RVA: 0x002FF5EC File Offset: 0x002FD7EC
		public Submarine_AI GetSubmarineAI()
		{
			if (Information.IsNothing(this.submarine_AI))
			{
				ActiveUnit activeUnit = this;
				this.submarine_AI = new Submarine_AI(ref activeUnit);
			}
			return this.submarine_AI;
		}

		// Token: 0x0600625C RID: 25180 RVA: 0x002FF620 File Offset: 0x002FD820
		public Submarine_Kinematics GetSubmarineKinematics()
		{
			if (Information.IsNothing(this.submarine_Kinematics))
			{
				ActiveUnit activeUnit = this;
				this.submarine_Kinematics = new Submarine_Kinematics(ref activeUnit);
			}
			return this.submarine_Kinematics;
		}

		// Token: 0x0600625D RID: 25181 RVA: 0x002FF654 File Offset: 0x002FD854
		public Submarine_Sensory GetSubmarineSensory()
		{
			if (Information.IsNothing(this.submarine_Sensory))
			{
				ActiveUnit activeUnit = this;
				this.submarine_Sensory = new Submarine_Sensory(ref activeUnit);
			}
			return this.submarine_Sensory;
		}

		// Token: 0x0600625E RID: 25182 RVA: 0x002FF688 File Offset: 0x002FD888
		public Submarine_Weaponry GetSubmarineWeaponry()
		{
			if (Information.IsNothing(this.submarine_Weaponry))
			{
				ActiveUnit activeUnit = this;
				this.submarine_Weaponry = new Submarine_Weaponry(ref activeUnit);
			}
			return this.submarine_Weaponry;
		}

		// Token: 0x0600625F RID: 25183 RVA: 0x002FF6BC File Offset: 0x002FD8BC
		public Submarine_CommStuff GetSubmarineCommStuff()
		{
			if (Information.IsNothing(this.submarine_CommStuff))
			{
				ActiveUnit activeUnit = this;
				this.submarine_CommStuff = new Submarine_CommStuff(ref activeUnit);
			}
			return this.submarine_CommStuff;
		}

		// Token: 0x06006260 RID: 25184 RVA: 0x002FF6F0 File Offset: 0x002FD8F0
		public Submarine_Damage GetSubmarineDamage()
		{
			if (Information.IsNothing(this.submarine_Damage))
			{
				ActiveUnit activeUnit = this;
				this.submarine_Damage = new Submarine_Damage(ref activeUnit);
			}
			return this.submarine_Damage;
		}

		// Token: 0x06006261 RID: 25185 RVA: 0x0002B5D2 File Offset: 0x000297D2
		public bool IsROV()
		{
			return this.Type == Submarine._SubmarineType.ROV && this.ROVRadius > 0;
		}

		// Token: 0x06006262 RID: 25186 RVA: 0x002FF724 File Offset: 0x002FD924
		public bool IsNuclearPropelled()
		{
			bool result = false;
			try
			{
				if (!this.HasNuclearPropulsion.HasValue)
				{
					this.HasNuclearPropulsion = new bool?(false);
					using (IEnumerator<Engine> enumerator = this.GetEngines().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.PropulsionType == Engine._PropulsionType.Nuclear)
							{
								this.HasNuclearPropulsion = new bool?(true);
								break;
							}
						}
					}
				}
				result = this.HasNuclearPropulsion.Value;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100803", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006263 RID: 25187 RVA: 0x002FF800 File Offset: 0x002FDA00
		public override int GetMastHeight()
		{
			return (int)Math.Round((double)(22f + this.GetCurrentAltitude_ASL(false)));
		}

		// Token: 0x06006264 RID: 25188 RVA: 0x002FF800 File Offset: 0x002FDA00
		public override int GetTargetVisualSize()
		{
			return (int)Math.Round((double)(22f + this.GetCurrentAltitude_ASL(false)));
		}

		// Token: 0x06006265 RID: 25189 RVA: 0x002FF824 File Offset: 0x002FDA24
		public override ActiveUnit.Throttle GetMaxThrottleAvailable()
		{
			AltBand altBand = this.GetSubmarineKinematics().vmethod_39();
			ActiveUnit.Throttle result;
			if (altBand.Consumption_Flank.HasValue && altBand.Speed_Flank.HasValue)
			{
				result = ActiveUnit.Throttle.Flank;
			}
			else
			{
				result = ActiveUnit.Throttle.Full;
			}
			return result;
		}

		// Token: 0x06006266 RID: 25190 RVA: 0x0002B5ED File Offset: 0x000297ED
		public bool IsShallowerThanPeriscopeDepth()
		{
			return this.GetCurrentAltitude_ASL(false) >= -5f;
		}

		// Token: 0x06006267 RID: 25191 RVA: 0x0002B600 File Offset: 0x00029800
		public bool IsAtPeriscopeDepth()
		{
			return this.GetCurrentAltitude_ASL(false) >= -20f && this.GetCurrentAltitude_ASL(false) < -5f;
		}

		// Token: 0x06006268 RID: 25192 RVA: 0x002FF868 File Offset: 0x002FDA68
		public override GlobalVariables.TargetVisualSizeClass GetTargetVisualSizeClass()
		{
			GlobalVariables.TargetVisualSizeClass result = GlobalVariables.TargetVisualSizeClass.Stealthy;
			if (this.GetCurrentAltitude_ASL(false) >= -5f)
			{
				float length = this.Length;
				if (length > 150f)
				{
					result = GlobalVariables.TargetVisualSizeClass.VLarge;
				}
				else if (length > 100f)
				{
					result = GlobalVariables.TargetVisualSizeClass.Large;
				}
				else if (length > 60f)
				{
					result = GlobalVariables.TargetVisualSizeClass.Medium;
				}
				else if (length > 35f)
				{
					result = GlobalVariables.TargetVisualSizeClass.Small;
				}
				else
				{
					result = GlobalVariables.TargetVisualSizeClass.VSmall;
				}
			}
			else if (this.GetCurrentAltitude_ASL(false) >= -20f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Stealthy;
			}
			return result;
		}

		// Token: 0x06006269 RID: 25193 RVA: 0x002FF8EC File Offset: 0x002FDAEC
		public override void ScheduleLifeCycleActivities(float float_24, ref Random random_1)
		{
			try
			{
				if (this.Type == Submarine._SubmarineType.ROV && !Information.IsNothing(this.GetAssignedMission(false)) && this.GetAssignedMission(false).MissionClass == Mission._MissionClass.MineClearing && this.IsOperating() && base.HasMineNeutralizations())
				{
					bool flag = false;
					foreach (Sensor current in this.GetMineCounterMeasures())
					{
						if (current.IsMineNeutralization() && current.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						this.SetWeaponState(ActiveUnit._ActiveUnitWeaponState.IsWinchester);
						this.GetDockingOps().method_7(false, ActiveUnit._ActiveUnitStatus.RTB, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
					}
				}
				this.GetDockingOps().ScheduleDockingOpsEvent(float_24);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100804", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600626A RID: 25194 RVA: 0x0002AC69 File Offset: 0x00028E69
		public override void vmethod_113(ref Scenario scenario_1, Dictionary<string, Subject> dictionary_1, bool bool_17)
		{
			base.vmethod_113(ref scenario_1, dictionary_1, bool_17);
			this.GetDockingOps().method_1(ref scenario_1, dictionary_1, bool_17);
		}

		// Token: 0x0600626B RID: 25195 RVA: 0x002FFA0C File Offset: 0x002FDC0C
		public override void SetThrottle(ActiveUnit.Throttle ThrottleSetting, float? SpecificDesiredSpeed = null)
		{
			try
			{
				if (ThrottleSetting > ActiveUnit.Throttle.Flank)
				{
					ThrottleSetting = ActiveUnit.Throttle.Flank;
				}
				if (ThrottleSetting < ActiveUnit.Throttle.FullStop)
				{
					ThrottleSetting = ActiveUnit.Throttle.FullStop;
				}
				if (ThrottleSetting > this.GetMaxThrottleAvailable())
				{
					ThrottleSetting = this.GetMaxThrottleAvailable();
				}
				this.currentThrottle = ThrottleSetting;
				if (!this.IsGroup)
				{
					if (Information.IsNothing(SpecificDesiredSpeed))
					{
						this.SetDesiredSpeed((float)this.GetSubmarineKinematics().GetSpeed(this.GetCurrentAltitude_ASL(false), this.currentThrottle));
					}
					else
					{
						this.SetDesiredSpeed(SpecificDesiredSpeed.Value);
					}
				}
				base.method_101(this, this.currentThrottle);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200583", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600626C RID: 25196 RVA: 0x002FFAF0 File Offset: 0x002FDCF0
		public override bool vmethod_41(double Lat_, double Lon_, ref byte byte_0, bool bool_17, ref bool bAboutToEnterNoNavZone, bool bool_19, ref bool bool_20, float? nullable_15, short? nullable_16, ref List<ActiveUnit> list_3, float float_24, bool bool_21, bool bool_22)
		{
			bool flag = false;
			bool result;
			try
			{
				byte_0 = 1;
				if (!double.IsNaN(Lat_) && !double.IsNaN(Lon_))
				{
					if (bool_21 && this.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedOffensive && !Information.IsNothing(this.GetAssignedMission(false)) && this.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
					{
						Patrol patrol = (Patrol)this.GetAssignedMission(false);
						GeoPoint geoPoint = new GeoPoint(Lon_, Lat_);
						if (this.vmethod_40(patrol.ProsecutionAreaVertices, this.m_Scenario, true) && !geoPoint.method_22(ref patrol.ProsecutionAreaVertices, true))
						{
							bAboutToEnterNoNavZone = false;
							bool_20 = false;
							flag = false;
							result = false;
							return result;
						}
					}
					if (this.GetSubmarineNavigator().HasPathfindingCourse() && !bool_17 && this.GetSubmarineNavigator().GetPlottedCourse()[0].waypointType == Waypoint.WaypointType.PathfindingPoint)
					{
						bAboutToEnterNoNavZone = false;
						bool_20 = false;
						flag = true;
					}
					else
					{
						if (!bool_17 && this.GetSubmarineNavigator().HasPathfindingCourse() && this.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.EngagedOffensive)
						{
							float num;
							if (Information.IsNothing(nullable_15))
							{
								num = base.HorizontalRangeTo(Lat_, Lon_);
							}
							else
							{
								num = nullable_15.Value;
							}
							if (num <= base.GetMoveDistance(2f))
							{
								bAboutToEnterNoNavZone = false;
								bool_20 = false;
								flag = true;
								result = true;
								return result;
							}
						}
						if (bool_22)
						{
							bAboutToEnterNoNavZone = base.AboutToEnterNoNavZone();
						}
						if (GeoPoint.smethod_7(Lat_, Lon_))
						{
							bAboutToEnterNoNavZone = false;
							bool_20 = false;
							flag = true;
						}
						else if ((bAboutToEnterNoNavZone || bool_17) && base.method_122(Lat_, Lon_, float_24))
						{
							bAboutToEnterNoNavZone = true;
							bool_20 = false;
							flag = false;
						}
						else if ((Information.IsNothing(list_3) || list_3.Count > 0) && GeoPoint.smethod_6(Lat_, Lon_, this.m_Scenario, ref list_3))
						{
							bAboutToEnterNoNavZone = false;
							bool_20 = false;
							flag = true;
						}
						else if (!this.method_148(Lat_, Lon_, bool_19, ref bool_20, nullable_16))
						{
							bAboutToEnterNoNavZone = false;
							flag = false;
						}
						else
						{
							bAboutToEnterNoNavZone = false;
							bool_20 = false;
							flag = true;
						}
					}
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
				ex2.Data.Add("Error at 200283", ex2.Message);
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

		// Token: 0x0600626D RID: 25197 RVA: 0x002FFD68 File Offset: 0x002FDF68
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
						this.m_Scenario.LogMessage(this.Name + "已经被摧毁!", LoggedMessage.MessageType.UnitLost, 0, base.GetGuid(), this.GetSide(false), new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
					}
					base.ApplyingDamage(ScenEditAction, false, this.GetSubmarineDamage().GetDamagePts());
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
					if (base.HasParentGroup())
					{
						this.GetParentGroup(false).GetUnitsInGroup().Remove(base.GetGuid());
					}
					if (ScenEditAction)
					{
						base.Destroy();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100807", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600626E RID: 25198 RVA: 0x00300000 File Offset: 0x002FE200
		public override int GetMaxMineRange()
		{
			int result;
			if (this.Type == Submarine._SubmarineType.ROV)
			{
				result = 0;
			}
			else
			{
				result = base.GetMaxMineRange();
			}
			return result;
		}

		// Token: 0x0600626F RID: 25199 RVA: 0x00300030 File Offset: 0x002FE230
		private bool method_148(double double_5, double double_6, bool bool_17, ref bool bool_18, short? nullable_15)
		{
			Submarine.Class195 @class = new Submarine.Class195();
			@class.submarine_0 = this;
			@class.double_0 = double_5;
			@class.double_1 = double_6;
			short num;
			if (Information.IsNothing(nullable_15))
			{
				num = Terrain.GetElevation(@class.double_0, @class.double_1, false);
			}
			else
			{
				num = nullable_15.Value;
			}
			short num2 = -10;
			bool flag = false;
			bool result;
			try
			{
				if (num > num2)
				{
					flag = false;
				}
				else if (bool_17 && !this.IsNuclearPropelled() && ArcticSeaIce.IsNearMarginalIceZone(@class.double_1, @class.double_0))
				{
					flag = false;
				}
				else
				{
					if (bool_18)
					{
						Submarine.Class196 class2 = new Submarine.Class196();
						class2.class195_0 = @class;
						class2.bool_0 = false;
						class2.int_0 = this.GetMaxMineRange();
						if (class2.int_0 > 0 && this.GetSide(false).Contacts_NonAU.Count > 0)
						{
							Parallel.ForEach<string>(this.GetSide(false).Contacts_NonAU.ToList<string>(), new Action<string, ParallelLoopState>(class2.method_0));
						}
						if (class2.bool_0)
						{
							bool_18 = true;
							flag = false;
							result = false;
							return result;
						}
					}
					flag = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100808", "");
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

		// Token: 0x06006270 RID: 25200 RVA: 0x003001B4 File Offset: 0x002FE3B4
		public Submarine(ref Scenario theScen, string theGUID = null) : base(ref theScen, theGUID)
		{
			this.submarineCode = default(Submarine._SubmarineCode);
			this.m_PressureHull = new PressureHull(this);
			this.m_Rudder = new Rudder(this);
			this.m_CIC = new CIC(this, "Conn / CIC");
			this.m_Cargo = new Cargo(this);
			this.IsSubmarine = true;
		}

		// Token: 0x06006271 RID: 25201 RVA: 0x00300240 File Offset: 0x002FE440
		public override void UpdatePropulsionState(float elapsedTime)
		{
			try
			{
				if (!this.IsNuclearPropelled() && this.GetFuelRecs().Count<FuelRec>() != 0 && this.GetThrottle() != ActiveUnit.Throttle.FullStop)
				{
					this.method_130(this.GetSubmarineAI().method_93());
					foreach (KeyValuePair<int, Engine> current in this.method_129())
					{
						Submarine.Class197 @class = new Submarine.Class197(null);
						Engine value = current.Value;
						int key = current.Key;
						@class._FuelType_0 = this.GetSubmarineAI().GetFuelType(value);
						FuelRec fuelRec = null;
						if (@class._FuelType_0 != FuelRec._FuelType.Battery)
						{
							FuelRec fuelRec2 = this.GetFuelRecs().Where(new Func<FuelRec, bool>(@class.method_0)).Select(Submarine.FuelRecFunc1).ElementAtOrDefault(0);
							if (fuelRec2 == null || fuelRec2.CurrentQuantity == 0f)
							{
								continue;
							}
							if (Information.IsNothing(fuelRec))
							{
								fuelRec = this.GetFuelRecs().Where(Submarine.FuelRecFunc2).Select(Submarine.FuelRecFunc3).ElementAtOrDefault(0);
							}
							if (!Information.IsNothing(fuelRec) && fuelRec.GetRatioLeft() >= 1f)
							{
								continue;
							}
						}
						float num;
						if (@class._FuelType_0 == FuelRec._FuelType.AirIndepedent)
						{
							num = this.method_152(ActiveUnit.Throttle.Loiter, null, null, null, value, key);
						}
						else
						{
							num = this.method_152(this.GetThrottle(), null, new float?((float)((int)Math.Round((double)this.GetDesiredSpeed()))), new float?(this.GetCurrentAltitude_ASL(false)), value, key);
						}
						float num2 = num * elapsedTime;
						this.method_149(num2, @class._FuelType_0);
						if (value.PropulsionType == Engine._PropulsionType.Diesel)
						{
							this.method_151(value, fuelRec, elapsedTime);
						}
						else if (value.PropulsionType == Engine._PropulsionType.AirIndependent)
						{
							this.method_151(value, fuelRec, elapsedTime);
						}
						base.ExportFuelConsumed(num2, @class._FuelType_0);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100809", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006272 RID: 25202 RVA: 0x003004D8 File Offset: 0x002FE6D8
		public void method_149(float float_24, FuelRec._FuelType _FuelType_0)
		{
			Submarine.Class198 @class = new Submarine.Class198();
			@class._FuelType_0 = _FuelType_0;
			try
			{
				if (float_24 != 0f)
				{
					FuelRec fuelRec = this.GetFuelRecs().Where(new Func<FuelRec, bool>(@class.method_0)).Select(Submarine.FuelRecFunc4).ElementAtOrDefault(0);
					if (fuelRec != null)
					{
						if (fuelRec.CurrentQuantity > float_24)
						{
							fuelRec.CurrentQuantity -= float_24;
						}
						else
						{
							bool flag = fuelRec.CurrentQuantity > 0f;
							fuelRec.CurrentQuantity = 0f;
							if (this.GetFuelRecs().Where(Submarine.FuelRecFunc5).Count<FuelRec>() == 0)
							{
								this.SetThrottle(ActiveUnit.Throttle.FullStop, null);
								if (flag)
								{
									base.LogMessage(this.Name + " (" + Misc.smethod_11(this.UnitClass) + ") has run out of fuel and lies dead in the water!", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
									this.GetSubmarineKinematics().SetDesiredSpeedOverride(null);
								}
							}
							else if (flag)
							{
								this.SetThrottle(ActiveUnit.Throttle.Loiter, null);
								base.LogMessage(this.Name + " (" + Misc.smethod_11(this.UnitClass) + ") has run out of fuel, attempting to use alternative propulsion.", LoggedMessage.MessageType.UnitDamage, 1, false, new GeoPoint(this.GetLongitude(null), this.GetLatitude(null)));
								this.GetSubmarineKinematics().SetDesiredSpeedOverride(null);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100810", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006273 RID: 25203 RVA: 0x0002B621 File Offset: 0x00029821
		public void method_150()
		{
			if (this.GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
			{
				this.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
			}
		}

		// Token: 0x06006274 RID: 25204 RVA: 0x003006E0 File Offset: 0x002FE8E0
		public void method_151(Engine engine_1, FuelRec fuelRec_1, float float_24)
		{
			try
			{
				if (!Information.IsNothing(fuelRec_1) && (engine_1.PropulsionType != Engine._PropulsionType.Diesel || this.GetCurrentAltitude_ASL(false) >= -20f) && (engine_1.PropulsionType == Engine._PropulsionType.Diesel || engine_1.PropulsionType == Engine._PropulsionType.AirIndependent))
				{
					float num = 0f;
					if (engine_1.PropulsionType == Engine._PropulsionType.Diesel)
					{
						if (this.GetDockingOps().GetDockingOpsCondition() != ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
						{
							this.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries);
						}
						num = (float)((double)fuelRec_1.MaxQuantity / 60.0 / 8.0);
					}
					else if (engine_1.PropulsionType == Engine._PropulsionType.AirIndependent)
					{
						Engine engine = this.GetEngines().Where(Submarine.EngineFunc2).ElementAtOrDefault(0);
						if (Information.IsNothing(engine))
						{
							engine = this.GetEngines().Where(Submarine.EngineFunc3).ElementAtOrDefault(0);
						}
						if (Information.IsNothing(engine))
						{
							num = 1f;
						}
						else if (engine.altBands[0].Consumption_Loiter > 0f)
						{
							num = engine.altBands[0].Consumption_Loiter;
						}
						else
						{
							num = 1f;
						}
						if (fuelRec_1.CurrentQuantity <= 0f)
						{
							fuelRec_1.CurrentQuantity = 0.0001f;
						}
					}
					fuelRec_1.CurrentQuantity += num / 60f * float_24;
					if (fuelRec_1.CurrentQuantity > (float)fuelRec_1.MaxQuantity)
					{
						fuelRec_1.CurrentQuantity = (float)fuelRec_1.MaxQuantity;
					}
					if (fuelRec_1.CurrentQuantity == (float)fuelRec_1.MaxQuantity)
					{
						this.method_150();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100811", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006275 RID: 25205 RVA: 0x003008F0 File Offset: 0x002FEAF0
		public override float GetFuelConsumption(ActiveUnit.Throttle throttle_, AltBand altBand_, float? desiredSpeed_, float? altitude, bool bool_17, bool bool_18, bool bool_19, bool bool_20)
		{
			float result;
			if (!this.IsNuclearPropelled() && !this.IsBiologics())
			{
				result = this.method_152(throttle_, null, new float?((float)((int)Math.Round((double)this.GetDesiredSpeed()))), new float?(this.GetCurrentAltitude_ASL(false)), this.GetEngine(), this.method_133());
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x06006276 RID: 25206 RVA: 0x00300958 File Offset: 0x002FEB58
		public float method_152(ActiveUnit.Throttle throttle_4, AltBand altBand_0, float? nullable_15, float? nullable_16, Engine engine_1, int int_8)
		{
			Submarine.AltBandChecker altBandChecker = new Submarine.AltBandChecker();
			float num;
			float result;
			if (!this.IsNuclearPropelled() && !this.IsBiologics())
			{
				if (Information.IsNothing(engine_1))
				{
					num = 0f;
					result = num;
					return result;
				}
				if (this.GetEngines().Count == 0)
				{
					num = 0f;
					result = num;
					return result;
				}
				altBandChecker.altBand = null;
				try
				{
					if (engine_1.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
					{
						num = 0f;
						result = num;
						return result;
					}
					if (engine_1.altBands.Length == 0)
					{
						num = 0f;
						result = num;
						return result;
					}
					if (Information.IsNothing(altBand_0))
					{
						if (!Information.IsNothing(nullable_16))
						{
							altBandChecker.altBand = this.GetSubmarineKinematics().GetAltBand(nullable_16.Value, new int?(int_8));
						}
						else
						{
							altBandChecker.altBand = this.GetSubmarineKinematics().vmethod_39();
						}
					}
					else
					{
						altBandChecker.altBand = altBand_0;
					}
					if (Information.IsNothing(altBandChecker.altBand))
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new Exception();
					}
					float num2;
					float num3;
					switch (throttle_4)
					{
					case ActiveUnit.Throttle.FullStop:
						num = 0f;
						result = num;
						return result;
					case ActiveUnit.Throttle.Loiter:
						num2 = altBandChecker.altBand.Consumption_Loiter;
						num3 = 0f;
						break;
					case ActiveUnit.Throttle.Cruise:
						if (engine_1.altBands[0].Consumption_Cruise <= 0f)
						{
							num = this.method_152(ActiveUnit.Throttle.Loiter, altBand_0, nullable_15, nullable_16, engine_1, int_8);
							result = num;
							return result;
						}
						num2 = altBandChecker.altBand.Consumption_Cruise;
						num3 = altBandChecker.altBand.Consumption_Loiter;
						break;
					case ActiveUnit.Throttle.Full:
						if (altBandChecker.altBand.Speed_Full.HasValue)
						{
							float? num4 = engine_1.altBands[0].Consumption_Full;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() > 0f) : null).GetValueOrDefault())
							{
								num2 = altBandChecker.altBand.Consumption_Full.Value;
								float arg_23B_0 = (float)altBandChecker.altBand.Speed_Full.Value;
								num3 = altBandChecker.altBand.Consumption_Cruise;
								break;
							}
						}
						num = this.method_152(ActiveUnit.Throttle.Cruise, altBand_0, nullable_15, nullable_16, engine_1, int_8);
						result = num;
						return result;
					case ActiveUnit.Throttle.Flank:
						if (altBandChecker.altBand.Speed_Flank.HasValue)
						{
							float? num4 = engine_1.altBands[0].Consumption_Flank;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() > 0f) : null).GetValueOrDefault())
							{
								num2 = altBandChecker.altBand.Consumption_Flank.Value;
								float arg_2E8_0 = (float)altBandChecker.altBand.Speed_Flank.Value;
								if (altBandChecker.altBand.Speed_Full.HasValue)
								{
									num3 = altBandChecker.altBand.Consumption_Full.Value;
									break;
								}
								num3 = altBandChecker.altBand.Consumption_Cruise;
								break;
							}
						}
						num = this.method_152(ActiveUnit.Throttle.Full, altBand_0, nullable_15, nullable_16, engine_1, int_8);
						result = num;
						return result;
					default:
						num = 0f;
						result = num;
						return result;
					}
					float num5 = num2;
					if (!Information.IsNothing(nullable_15) && !Information.IsNothing(nullable_16))
					{
						float? num4;
						if (altBandChecker.altBand != this.GetSubmarineKinematics().method_11(engine_1))
						{
							AltBand[] altBands = engine_1.altBands;
							if (altBands.Length == 0)
							{
								num = 0f;
								result = num;
								return result;
							}
							AltBand altBand = altBands.Where(new Func<AltBand, bool>(altBandChecker.IsHigher)).OrderBy(Submarine.AltBandFunc1).ElementAtOrDefault(0);
							float num6;
							float num7;
							switch (throttle_4)
							{
							case ActiveUnit.Throttle.FullStop:
								num6 = 0f;
								num7 = 0f;
								break;
							case ActiveUnit.Throttle.Loiter:
								num6 = altBand.Consumption_Loiter;
								num7 = 0f;
								break;
							case ActiveUnit.Throttle.Cruise:
								num6 = altBand.Consumption_Cruise;
								num7 = altBand.Consumption_Loiter;
								break;
							case ActiveUnit.Throttle.Full:
							{
								if (!altBand.Speed_Full.HasValue)
								{
									throw new Exception("Submarine has full throttle but no fuel consumption params exist in database!");
								}
								num6 = altBand.Consumption_Full.Value;
								float arg_449_0 = (float)altBand.Speed_Full.Value;
								num7 = altBand.Consumption_Cruise;
								break;
							}
							case ActiveUnit.Throttle.Flank:
								if (altBand.Speed_Flank.HasValue)
								{
									num6 = altBand.Consumption_Flank.Value;
									float arg_481_0 = (float)altBand.Speed_Flank.Value;
									if (altBand.Speed_Full.HasValue)
									{
										num7 = altBand.Consumption_Full.Value;
									}
									else
									{
										num7 = altBand.Consumption_Cruise;
									}
								}
								else
								{
									num6 = num2;
									num7 = num3;
								}
								break;
							default:
								num = 0f;
								result = num;
								return result;
							}
							if (num6 != num2)
							{
								num4 = nullable_16;
								float minAltitude = altBandChecker.altBand.MinAltitude;
								if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() != minAltitude) : null).GetValueOrDefault())
								{
									float? num8 = nullable_16;
									float num9 = altBandChecker.altBand.MinAltitude;
									num8 = (num8.HasValue ? new float?(num8.GetValueOrDefault() - num9) : null);
									num9 = altBandChecker.altBand.MaxAltitude - altBandChecker.altBand.MinAltitude;
									float num10 = (num8.HasValue ? new float?(num8.GetValueOrDefault() / num9) : null).Value;
									num10 = Math.Abs(num10);
									num2 += (num6 - num2) * num10;
									num5 = num2;
									num3 += (num7 - num3) * num10;
								}
							}
						}
						float num11 = (float)this.GetSubmarineKinematics().GetSpeed(nullable_16.Value, throttle_4);
						num4 = nullable_15;
						if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() != num11) : null).GetValueOrDefault())
						{
							float num12 = (float)this.GetSubmarineKinematics().GetSpeed(nullable_16.Value, (ActiveUnit.Throttle)(throttle_4 - ActiveUnit.Throttle.Loiter));
							num4 = nullable_15;
							float num13;
							if ((num4.HasValue ? new bool?(num4.GetValueOrDefault() >= num12) : null).GetValueOrDefault())
							{
								float? num8 = nullable_15;
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
							num5 = num3 + (num2 - num3) * num13;
						}
					}
					num = num5 / 60f;
					result = num;
					return result;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200349", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					num = 0.001f;
					ProjectData.ClearProjectError();
					result = num;
					return result;
				}
			}
			num = 0f;
			result = num;
			return result;
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x000B1010 File Offset: 0x000AF210
		public float GetCargoCrew()
		{
			return 0f;
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x000B1010 File Offset: 0x000AF210
		public float GetCargoArea()
		{
			return 0f;
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x000081A2 File Offset: 0x000063A2
		public _CargoType GetCargoType()
		{
			return _CargoType.NoCargo;
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x000B1010 File Offset: 0x000AF210
		public float GetCargoMass()
		{
			return 0f;
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x003010D0 File Offset: 0x002FF2D0
		public long method_153(ActiveUnit.Throttle throttle_4, AltBand altBand_0, float? nullable_15, float? nullable_16)
		{
			long result;
			if (this.IsNuclearPropelled())
			{
				result = 9223372036854775807L;
			}
			else if (this.IsROV())
			{
				result = 9223372036854775807L;
			}
			else
			{
				if (Information.IsNothing(this.GetEngine()))
				{
					this.GetSubmarineAI().method_93();
				}
				if (!Information.IsNothing(this.GetEngine()))
				{
					result = this.method_154(throttle_4, altBand_0, nullable_15, nullable_16, this.GetEngine(), this.method_133());
				}
				else
				{
					result = 9223372036854775807L;
				}
			}
			return result;
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x00301168 File Offset: 0x002FF368
		public long method_154(ActiveUnit.Throttle throttle_4, AltBand altBand_0, float? nullable_15, float? nullable_16, Engine engine_1, int int_8)
		{
			Submarine.FuelChecker fuelChecker = new Submarine.FuelChecker();
			fuelChecker.Platform = this;
			fuelChecker.m_Engine = engine_1;
			long num;
			long result;
			if (this.IsNuclearPropelled())
			{
				num = 9223372036854775807L;
			}
			else if (this.Type != Submarine._SubmarineType.Biologics && this.Type != Submarine._SubmarineType.FalseTarget)
			{
				FuelRec fuelRec = this.GetFuelRecs().Where(new Func<FuelRec, bool>(fuelChecker.IsFuelSuitableForEngine)).OrderBy(Submarine.FuelRecFunc6).ElementAtOrDefault(0);
				if (throttle_4 == ActiveUnit.Throttle.FullStop)
				{
					result = 2147483647L;
					return result;
				}
				if (Information.IsNothing(fuelRec))
				{
					result = 0L;
					return result;
				}
				float num2 = this.method_152(throttle_4, altBand_0, nullable_15, nullable_16, fuelChecker.m_Engine, int_8);
				if (num2 != 0f)
				{
					num = (long)Math.Round((double)(fuelRec.CurrentQuantity / num2));
					result = num;
					return result;
				}
				if (fuelRec.CurrentQuantity == 0f)
				{
					result = 0L;
					return result;
				}
				result = 9223372036854775807L;
				return result;
			}
			else
			{
				num = 9223372036854775807L;
			}
			result = num;
			return result;
		}

		// Token: 0x0600627D RID: 25213 RVA: 0x003012C0 File Offset: 0x002FF4C0
		public bool method_155()
		{
			FuelRec[] fuelRecs = this.m_FuelRecs;
			checked
			{
				bool result;
				for (int i = 0; i < fuelRecs.Length; i++)
				{
					if (fuelRecs[i].FuelType == FuelRec._FuelType.AirIndepedent)
					{
						result = true;
						return result;
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool HasNavalMineLayingLoadout()
		{
			return true;
		}

		// Token: 0x04003575 RID: 13685
		public static Func<Engine, bool> EngineFunc1 = (Engine engine_0) => engine_0.PropulsionType == Engine._PropulsionType.Diesel;

		// Token: 0x04003576 RID: 13686
		public static Func<FuelRec, FuelRec> FuelRecFunc1 = (FuelRec fuelRec_0) => fuelRec_0;

		// Token: 0x04003577 RID: 13687
		public static Func<FuelRec, bool> FuelRecFunc2 = (FuelRec fuelRec_0) => fuelRec_0.FuelType == FuelRec._FuelType.Battery;

		// Token: 0x04003578 RID: 13688
		public static Func<FuelRec, FuelRec> FuelRecFunc3 = (FuelRec fuelRec_0) => fuelRec_0;

		// Token: 0x04003579 RID: 13689
		public static Func<FuelRec, FuelRec> FuelRecFunc4 = (FuelRec fuelRec_0) => fuelRec_0;

		// Token: 0x0400357A RID: 13690
		public static Func<FuelRec, bool> FuelRecFunc5 = (FuelRec fuelRec_0) => fuelRec_0.CurrentQuantity > 0f;

		// Token: 0x0400357B RID: 13691
		public static Func<Engine, bool> EngineFunc2 = (Engine engine_0) => engine_0.PropulsionType == Engine._PropulsionType.Electric;

		// Token: 0x0400357C RID: 13692
		public static Func<Engine, bool> EngineFunc3 = (Engine engine_0) => engine_0.PropulsionType == Engine._PropulsionType.AirIndependent;

		// Token: 0x0400357D RID: 13693
		public static Func<AltBand, float> AltBandFunc1 = (AltBand altBand_0) => altBand_0.MaxAltitude;

		// Token: 0x0400357E RID: 13694
		public static Func<FuelRec, float> FuelRecFunc6 = (FuelRec fuelRec_0) => fuelRec_0.CurrentQuantity;

		// Token: 0x0400357F RID: 13695
		public Submarine._SubmarineCode submarineCode;

		// Token: 0x04003580 RID: 13696
		public PressureHull m_PressureHull;

		// Token: 0x04003581 RID: 13697
		public Rudder m_Rudder;

		// Token: 0x04003582 RID: 13698
		public CIC m_CIC;

		// Token: 0x04003583 RID: 13699
		public Cargo m_Cargo;

		// Token: 0x04003584 RID: 13700
		public Submarine._SubmarineCategory Category;

		// Token: 0x04003585 RID: 13701
		public Submarine._SubmarineType Type;

		// Token: 0x04003586 RID: 13702
		public float Length;

		// Token: 0x04003587 RID: 13703
		public DockFacility._DockFacilityPhysicalSizeCode PhysicalSizeCode;

		// Token: 0x04003588 RID: 13704
		public int MaxDepth;

		// Token: 0x04003589 RID: 13705
		public float Beam;

		// Token: 0x0400358A RID: 13706
		public float Draft;

		// Token: 0x0400358B RID: 13707
		public float Height;

		// Token: 0x0400358C RID: 13708
		public double DisplacementEmpty = 0.0;

		// Token: 0x0400358D RID: 13709
		public double DisplacementStandard = 0.0;

		// Token: 0x0400358E RID: 13710
		public double DisplacementFull = 0.0;

		// Token: 0x0400358F RID: 13711
		public short ROVRadius;

		// Token: 0x04003590 RID: 13712
		private Dictionary<int, Engine> dictionary_0;

		// Token: 0x04003591 RID: 13713
		private Engine m_Engine;

		// Token: 0x04003592 RID: 13714
		private int int_7;

		// Token: 0x04003593 RID: 13715
		private Submarine_Navigator submarine_Navigator;

		// Token: 0x04003594 RID: 13716
		private Submarine_AI submarine_AI;

		// Token: 0x04003595 RID: 13717
		private Submarine_Kinematics submarine_Kinematics;

		// Token: 0x04003596 RID: 13718
		private Submarine_Sensory submarine_Sensory;

		// Token: 0x04003597 RID: 13719
		private Submarine_Weaponry submarine_Weaponry;

		// Token: 0x04003598 RID: 13720
		private Submarine_CommStuff submarine_CommStuff;

		// Token: 0x04003599 RID: 13721
		private Submarine_Damage submarine_Damage;

		// Token: 0x0400359A RID: 13722
		private bool? HasNuclearPropulsion;

		// Token: 0x0400359B RID: 13723
		private static Scenario scenario = null;

		// Token: 0x02000BA2 RID: 2978
		public struct _SubmarineCode
		{
			// Token: 0x040035A6 RID: 13734
			public bool None;

			// Token: 0x040035A7 RID: 13735
			public bool NonmagneticHull;

			// Token: 0x040035A8 RID: 13736
			public bool NoLaunchTransient;

			// Token: 0x040035A9 RID: 13737
			public bool ShroudedPropulsor;

			// Token: 0x040035AA RID: 13738
			public bool AdvancedPropulsor;

			// Token: 0x040035AB RID: 13739
			public bool DoubleHull;

			// Token: 0x040035AC RID: 13740
			public bool ShockResistant;

			// Token: 0x040035AD RID: 13741
			public bool Snorkel;
		}

		// Token: 0x02000BA3 RID: 2979
		public enum _SubmarineCategory
		{
			// Token: 0x040035AF RID: 13743
			None = 1001,
			// Token: 0x040035B0 RID: 13744
			Submarine = 2001,
			// Token: 0x040035B1 RID: 13745
			Biologics,
			// Token: 0x040035B2 RID: 13746
			FalseTarget
		}

		// Token: 0x02000BA4 RID: 2980
		public enum _SubmarineType
		{
			// Token: 0x040035B4 RID: 13748
			None = 1001,
			// Token: 0x040035B5 RID: 13749
			AGSS = 2001,
			// Token: 0x040035B6 RID: 13750
			APSS,
			// Token: 0x040035B7 RID: 13751
			SS,
			// Token: 0x040035B8 RID: 13752
			SSB,
			// Token: 0x040035B9 RID: 13753
			SSBN,
			// Token: 0x040035BA RID: 13754
			SSG,
			// Token: 0x040035BB RID: 13755
			SSGN,
			// Token: 0x040035BC RID: 13756
			SSK,
			// Token: 0x040035BD RID: 13757
			SSM,
			// Token: 0x040035BE RID: 13758
			SSN,
			// Token: 0x040035BF RID: 13759
			SSP,
			// Token: 0x040035C0 RID: 13760
			SSR,
			// Token: 0x040035C1 RID: 13761
			SSRN,
			// Token: 0x040035C2 RID: 13762
			SDV = 3001,
			// Token: 0x040035C3 RID: 13763
			ROV = 4001,
			// Token: 0x040035C4 RID: 13764
			UUV,
			// Token: 0x040035C5 RID: 13765
			Biologics = 9001,
			// Token: 0x040035C6 RID: 13766
			FalseTarget
		}

		// Token: 0x02000BA5 RID: 2981
		[CompilerGenerated]
		public sealed class Class195
		{
			// Token: 0x040035C7 RID: 13767
			public double double_0;

			// Token: 0x040035C8 RID: 13768
			public double double_1;

			// Token: 0x040035C9 RID: 13769
			public Submarine submarine_0;
		}

		// Token: 0x02000BA6 RID: 2982
		[CompilerGenerated]
		public sealed class Class196
		{
			// Token: 0x0600628B RID: 25227 RVA: 0x00301480 File Offset: 0x002FF680
			internal void method_0(string string_0, ParallelLoopState parallelLoopState_0)
			{
				UnguidedWeapon unguidedWeapon = this.class195_0.submarine_0.m_Scenario.GetUnguidedWeapons()[string_0];
				if (unguidedWeapon.IsMine() && Math2.GetDistance(this.class195_0.double_0, this.class195_0.double_1, unguidedWeapon.GetLatitude(null), unguidedWeapon.GetLongitude(null)) * 1852f < (float)this.int_0)
				{
					this.bool_0 = true;
					parallelLoopState_0.Stop();
				}
			}

			// Token: 0x040035CA RID: 13770
			public int int_0;

			// Token: 0x040035CB RID: 13771
			public bool bool_0;

			// Token: 0x040035CC RID: 13772
			public Submarine.Class195 class195_0;
		}

		// Token: 0x02000BA7 RID: 2983
		[CompilerGenerated]
		public sealed class Class197
		{
			// Token: 0x0600628D RID: 25229 RVA: 0x0002B670 File Offset: 0x00029870
			public Class197(Submarine.Class197 class197_0)
			{
				if (class197_0 != null)
				{
					this._FuelType_0 = class197_0._FuelType_0;
				}
			}

			// Token: 0x0600628E RID: 25230 RVA: 0x0002B68A File Offset: 0x0002988A
			internal bool method_0(FuelRec fuelRec_0)
			{
				return fuelRec_0.FuelType == this._FuelType_0;
			}

			// Token: 0x040035CD RID: 13773
			public FuelRec._FuelType _FuelType_0;
		}

		// Token: 0x02000BA8 RID: 2984
		[CompilerGenerated]
		public sealed class Class198
		{
			// Token: 0x0600628F RID: 25231 RVA: 0x0002B69A File Offset: 0x0002989A
			internal bool method_0(FuelRec fuelRec_0)
			{
				return fuelRec_0.FuelType == this._FuelType_0;
			}

			// Token: 0x040035CE RID: 13774
			public FuelRec._FuelType _FuelType_0;
		}

		// Token: 0x02000BA9 RID: 2985
		[CompilerGenerated]
		public sealed class AltBandChecker
		{
			// Token: 0x06006291 RID: 25233 RVA: 0x0002B6AA File Offset: 0x000298AA
			internal bool IsHigher(AltBand altBand_)
			{
				return altBand_.MinAltitude >= this.altBand.MaxAltitude;
			}

			// Token: 0x040035CF RID: 13775
			public AltBand altBand;
		}

		// Token: 0x02000BAA RID: 2986
		[CompilerGenerated]
		public sealed class FuelChecker
		{
			// Token: 0x06006293 RID: 25235 RVA: 0x0002B6C2 File Offset: 0x000298C2
			internal bool IsFuelSuitableForEngine(FuelRec fuelRec_)
			{
				return fuelRec_.FuelType == this.Platform.GetSubmarineAI().GetFuelType(this.m_Engine);
			}

			// Token: 0x040035D0 RID: 13776
			public Engine m_Engine;

			// Token: 0x040035D1 RID: 13777
			public Submarine Platform;
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
	// 设施
	public sealed class Facility : Platform, ICargo
	{
		// Token: 0x060066B8 RID: 26296 RVA: 0x00356C84 File Offset: 0x00354E84
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				if (!Information.IsNothing(this.GetSide(false)))
				{
					try
					{
						xmlWriter_0.WriteStartElement("Facility");
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
							xmlWriter_0.WriteElementString("DT", ((byte)this.GetDesiredTurnRate()).ToString());
							xmlWriter_0.WriteElementString("DTN", ((byte)this.GetDesiredTurnRate_Navigation()).ToString());
							if (!Information.IsNothing(this.m_ProficiencyLevel))
							{
								xmlWriter_0.WriteElementString("Prof", ((int)this.m_ProficiencyLevel.Value).ToString());
							}
							xmlWriter_0.WriteElementString("ThrottleSetting", ((byte)this.GetThrottle()).ToString());
							if (this.GetNoneMCMSensors().Length > 0)
							{
								xmlWriter_0.WriteStartElement("Sensors");
								Sensor[] sensors = this.m_Sensors;
								for (int i = 0; i < sensors.Length; i++)
								{
									sensors[i].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
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
								for (int k = 0; k < fuelRecs.Length; k++)
								{
									fuelRecs[k].Save(ref xmlWriter_0);
								}
								xmlWriter_0.WriteEndElement();
							}
							if (this.m_Mounts.Length > 0)
							{
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
							}
							if (this.m_Magazines.Count<Magazine>() > 0)
							{
								xmlWriter_0.WriteStartElement("Magazines");
								Magazine[] magazines = this.m_Magazines;
								for (int m = 0; m < magazines.Length; m++)
								{
									magazines[m].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
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
							this.m_Doctrine.Save(ref xmlWriter_0, ref this.m_Scenario, "Doctrine");
							xmlWriter_0.WriteStartElement("CIC");
							this.m_CommandPost.Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
							xmlWriter_0.WriteEndElement();
							this.GetFacilityNavigator().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteStartElement("AI");
							if (Information.IsNothing(this.GetFacilityAI().m_ActiveUnit))
							{
								this.GetFacilityAI().m_ActiveUnit = this;
							}
							this.GetFacilityAI().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteEndElement();
							xmlWriter_0.WriteStartElement("Kinematics");
							this.GetFacilityKinematics().Save(ref xmlWriter_0);
							xmlWriter_0.WriteEndElement();
							this.GetFacilitySensory().Save(ref xmlWriter_0);
							this.GetFacilityWeaponry().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteStartElement("CommStuff");
							this.GetFacilityCommStuff().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteEndElement();
							this.GetFacilityDamage().Save(ref xmlWriter_0);
							if (!Information.IsNothing(this.GetAirOps()))
							{
								this.m_AirOps.Save(ref xmlWriter_0, ref hashSet_0);
							}
							if (!Information.IsNothing(this.GetDockingOps()))
							{
								this.m_DockingOps.Save(ref xmlWriter_0, ref hashSet_0);
							}
							xmlWriter_0.WriteEndElement();
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 100540", "");
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

		// Token: 0x060066B9 RID: 26297 RVA: 0x00357744 File Offset: 0x00355944
		private Facility() : base(ref Facility.scenario, null)
		{
			this.m_CommandPost = new CIC(this, "Command Post");
			this.m_Cargo = new Cargo(this);
			this.IsFacility = true;
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x00357790 File Offset: 0x00355990
		public static List<Facility> smethod_1(List<Mount> list_3, Scenario scenario_1, Side side_1)
		{
			return null;
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x003577A0 File Offset: 0x003559A0
		public static Facility ShallowRebuild(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_1)
		{
			Facility facility;
			try
			{
				facility = Facility.smethod_3(ref xmlNode_0, ref dictionary_0, ref scenario_1, scenario_1.LoadStockUnits);
			}
			catch (Exception0 projectError)
			{
				ProjectData.SetProjectError(projectError);
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				dictionary_0.Remove(innerText);
				facility = Facility.smethod_3(ref xmlNode_0, ref dictionary_0, ref scenario_1, true);
				string text = "";
				if (facility.HasParentGroup())
				{
					text = "(member of group: [" + facility.GetParentGroup(false).Name + "])";
				}
				scenario_1.LoadingNotices.Add(string.Concat(new string[]
				{
					"The following facility:[",
					facility.Name,
					"]",
					text,
					" failed to shallow-rebuild because of a component missing. The facility was instead deep-rebuilt, and instantiated in its pristine DB-stock condition. All customizations present in the facility's components (damaged components, weapon additions/removals etc. etc.) have been lost. Please re-apply any necessary customizations either manually or using an SBR script."
				}));
				ProjectData.ClearProjectError();
			}
			return facility;
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x00357884 File Offset: 0x00355A84
		private static Facility smethod_3(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_1, bool bool_18)
		{
			Facility facility = null;
			Facility result;
			try
			{
				Facility facility2 = new Facility();
				facility2.m_Scenario = scenario_1;
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					facility = (Facility)dictionary_0[innerText];
				}
				else
				{
					facility2.SetGuid(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						facility = facility2;
					}
					else
					{
						dictionary_0.Add(facility2.GetGuid(), facility2);
						int num = Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "DBID").InnerText);
						try
						{
							DBFunctions.LoadFacilityData(ref scenario_1, ref facility2, num, bool_18);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							dictionary_0.Remove(facility2.GetGuid());
							scenario_1.LoadingNotices.Add("Facility with Database ID " + Conversions.ToString(num) + " is missing from the database and has not been loaded.");
							ProjectData.ClearProjectError();
							result = facility;
							return result;
						}
						if (bool_18)
						{
							facility2.LoadAirFacilities(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						}
						if (!bool_18)
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
														CommDevice commDevice = CommDevice.Load(ref xmlNode2, ref dictionary_0, facility2);
														facility2.AddCommDevice(commDevice);
														commDevice.SetParentPlatform(facility2);
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
													Cargo cargo = Cargo.Load(ref xmlNode3, ref dictionary_0, facility2);
													ScenarioArrayUtil.AddCargo(ref facility2.m_OnboardCargos, cargo);
													cargo.SetParentPlatform(facility2);
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
										if (num2 != 2096367071u)
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
													FuelRec fuelRec_ = FuelRec.Load(ref xmlNode4, ref dictionary_0);
													ScenarioArrayUtil.AddFuelRec(ref facility2.m_FuelRecs, fuelRec_);
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
												DockFacility dockFacility = DockFacility.Load(ref xmlNode5, ref dictionary_0, ref scenario_1);
												facility2.AddDockFacility(dockFacility);
												dockFacility.SetParentPlatform(facility2);
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
									if (num2 <= 2424405304u)
									{
										if (num2 != 2246682072u)
										{
											if (num2 != 2424405304u || Operators.CompareString(name, "Sensors", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator6 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator6.MoveNext())
												{
													Sensor sensor = Sensor.Load((XmlNode)enumerator6.Current, dictionary_0, facility2);
													ScenarioArrayUtil.AddSensor(ref facility2.m_Sensors, sensor);
													sensor.SetParentPlatform(facility2);
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
												ActiveUnit activeUnit = facility2;
												Engine engine = Engine.Load(ref xmlNode6, ref dictionary_0, ref activeUnit);
												facility2.GetEngines().Add(engine);
												engine.SetParentPlatform(facility2);
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
													facility2.AddAirFacility(airFacility);
													airFacility.SetParentPlatform(facility2);
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
												ScenarioArrayUtil.AddMagazine(ref facility2.m_Magazines, magazine);
												magazine.SetParentPlatform(facility2);
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
												Mount mount = Mount.Load(ref xmlNode9, ref dictionary_0, facility2);
												ScenarioArrayUtil.AddMount(ref facility2.m_Mounts, mount);
												mount.SetParentPlatform(facility2);
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
								if (num2 <= 1729717486u)
								{
									if (num2 > 827630232u)
									{
										if (num2 <= 1255847155u)
										{
											if (num2 <= 1156592502u)
											{
												if (num2 <= 1087276353u)
												{
													if (num2 != 892023141u)
													{
														if (num2 != 1087276353u)
														{
															continue;
														}
														if (Operators.CompareString(name2, "DH", false) != 0)
														{
															continue;
														}
													}
													else if (Operators.CompareString(name2, "DesiredHeading", false) != 0)
													{
														continue;
													}
													facility2.SetDesiredHeading(ActiveUnit._TurnRate.const_0, XmlConvert.ToSingle(xmlNode10.InnerText));
													continue;
												}
												if (num2 != 1143797280u)
												{
													if (num2 == 1156592502u && Operators.CompareString(name2, "SBR", false) == 0)
													{
														facility2.SBR = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
														continue;
													}
													continue;
												}
												else
												{
													if (Operators.CompareString(name2, "SBR_Altitude_TF", false) == 0)
													{
														facility2.SBR_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode10.InnerText);
														continue;
													}
													continue;
												}
											}
											else if (num2 <= 1199570758u)
											{
												if (num2 != 1175569298u)
												{
													if (num2 != 1199570758u)
													{
														continue;
													}
													if (Operators.CompareString(name2, "Facility_Sensory", false) != 0)
													{
														continue;
													}
													goto IL_115A;
												}
												else
												{
													if (Operators.CompareString(name2, "ActiveUnit_AirOps", false) == 0)
													{
														goto IL_D9A;
													}
													continue;
												}
											}
											else if (num2 != 1238311391u)
											{
												if (num2 != 1243601753u)
												{
													if (num2 != 1255847155u || Operators.CompareString(name2, "ThrottleSetting", false) != 0)
													{
														continue;
													}
													string innerText2 = xmlNode10.InnerText;
													if (Operators.CompareString(innerText2, "FullStop", false) == 0)
													{
														facility2.currentThrottle = ActiveUnit.Throttle.FullStop;
														continue;
													}
													if (Operators.CompareString(innerText2, "Loiter", false) == 0)
													{
														facility2.currentThrottle = ActiveUnit.Throttle.Loiter;
														continue;
													}
													if (Operators.CompareString(innerText2, "Cruise", false) == 0)
													{
														facility2.currentThrottle = ActiveUnit.Throttle.Cruise;
														continue;
													}
													if (Operators.CompareString(innerText2, "Full", false) == 0)
													{
														facility2.currentThrottle = ActiveUnit.Throttle.Full;
														continue;
													}
													if (Operators.CompareString(innerText2, "Flank", false) != 0)
													{
														facility2.currentThrottle = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
														continue;
													}
													facility2.currentThrottle = ActiveUnit.Throttle.Flank;
													continue;
												}
												else if (Operators.CompareString(name2, "Facility_CommStuff", false) != 0)
												{
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "Facility_AI", false) == 0)
												{
													goto IL_E67;
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
														facility2.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode10, facility2);
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
													string innerText3 = xmlNode10.InnerText;
													if (Operators.CompareString(innerText3, "FullStop", false) == 0)
													{
														facility2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.FullStop;
														continue;
													}
													if (Operators.CompareString(innerText3, "Loiter", false) == 0)
													{
														facility2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Loiter;
														continue;
													}
													if (Operators.CompareString(innerText3, "Cruise", false) == 0)
													{
														facility2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Cruise;
														continue;
													}
													if (Operators.CompareString(innerText3, "Full", false) == 0)
													{
														facility2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Full;
														continue;
													}
													if (Operators.CompareString(innerText3, "Flank", false) != 0)
													{
														facility2.SBEngagedDefensive_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
														continue;
													}
													facility2.SBEngagedDefensive_ThrottleSetting = ActiveUnit.Throttle.Flank;
													continue;
												}
											}
											else if (num2 != 1444793274u)
											{
												if (num2 == 1476905714u && Operators.CompareString(name2, "WeaponState", false) == 0)
												{
													facility2.weaponState = (ActiveUnit._ActiveUnitWeaponState)Conversions.ToByte(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Prof", false) == 0)
												{
													facility2.SetProficiencyLevel(new GlobalVariables.ProficiencyLevel?((GlobalVariables.ProficiencyLevel)Conversions.ToInteger(xmlNode10.InnerText)));
													continue;
												}
												continue;
											}
										}
										else if (num2 <= 1525674614u)
										{
											if (num2 != 1488303767u)
											{
												if (num2 != 1525674614u)
												{
													continue;
												}
												if (Operators.CompareString(name2, "DockingOps", false) != 0)
												{
													continue;
												}
												goto IL_145C;
											}
											else
											{
												if (Operators.CompareString(name2, "SBEO_TF", false) == 0)
												{
													facility2.SBEngagedOffensive_TerrainFollowing = Conversions.ToBoolean(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 1614652377u)
										{
											if (num2 != 1708783731u)
											{
												if (num2 != 1729717486u)
												{
													continue;
												}
												if (Operators.CompareString(name2, "Longitude", false) != 0)
												{
													continue;
												}
												goto IL_11E9;
											}
											else
											{
												if (Operators.CompareString(name2, "CS", false) != 0)
												{
													continue;
												}
												goto IL_17CE;
											}
										}
										else if (Operators.CompareString(name2, "CommStuff", false) != 0)
										{
											continue;
										}
										Facility facility3 = facility2;
										activeUnit = facility2;
										facility3.facility_CommStuff = Facility_CommStuff.Load(ref xmlNode10, ref dictionary_0, ref activeUnit);
										continue;
									}
									if (num2 <= 485784328u)
									{
										if (num2 <= 334092753u)
										{
											if (num2 <= 263373746u)
											{
												if (num2 != 6222351u)
												{
													if (num2 == 263373746u && Operators.CompareString(name2, "FSBR", false) == 0)
													{
														facility2.FuelStateBR = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode10.InnerText);
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
														facility2.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText));
													}
													else
													{
														facility2.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode10.InnerText, true));
													}
													if (facility2.GetUnitStatus() == (ActiveUnit._ActiveUnitStatus)9)
													{
														facility2.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 266367750u)
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
												if (Operators.CompareString(name2, "Name", false) == 0)
												{
													facility2.Name = xmlNode10.InnerText;
													continue;
												}
												continue;
											}
										}
										else if (num2 <= 429749699u)
										{
											if (num2 != 392185441u)
											{
												if (num2 != 429749699u || Operators.CompareString(name2, "DesiredTurnRate_Navigation", false) != 0)
												{
													continue;
												}
											}
											else
											{
												if (Operators.CompareString(name2, "AirOps", false) == 0)
												{
													goto IL_D9A;
												}
												continue;
											}
										}
										else if (num2 != 468031071u)
										{
											if (num2 != 485784328u)
											{
												continue;
											}
											if (Operators.CompareString(name2, "IsAD", false) != 0)
											{
												continue;
											}
											goto IL_1A5B;
										}
										else
										{
											if (Operators.CompareString(name2, "SBED_Altitude_TF", false) == 0)
											{
												facility2.SBEngagedDefensive_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										facility2.SetDesiredTurnRate_Navigation((Waypoint._TurnRate)Conversions.ToByte(xmlNode10.InnerText));
										continue;
									}
									if (num2 <= 664498478u)
									{
										if (num2 <= 601166687u)
										{
											if (num2 != 506380204u)
											{
												if (num2 == 601166687u && Operators.CompareString(name2, "AI", false) == 0)
												{
													goto IL_E67;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "LatLR", false) == 0)
												{
													facility2.SetLatitudeLR(new double?(XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", "."))));
													continue;
												}
												continue;
											}
										}
										else if (num2 != 634280640u)
										{
											if (num2 == 664498478u && Operators.CompareString(name2, "FuelState", false) == 0)
											{
												facility2.activeUnitFuelState = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "DS", false) != 0)
											{
												continue;
											}
											goto IL_12D5;
										}
									}
									else if (num2 <= 771216480u)
									{
										if (num2 != 751723973u)
										{
											if (num2 != 771216480u)
											{
												continue;
											}
											if (Operators.CompareString(name2, "Damage", false) != 0)
											{
												continue;
											}
											goto IL_15F1;
										}
										else
										{
											if (Operators.CompareString(name2, "DT", false) != 0)
											{
												continue;
											}
											goto IL_179F;
										}
									}
									else if (num2 != 788394383u)
									{
										if (num2 != 803760973u)
										{
											if (num2 == 827630232u && Operators.CompareString(name2, "SBED_Altitude", false) == 0)
											{
												facility2.SBEngagedDefensive_Altitude = XmlConvert.ToSingle(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "DamagePts", false) == 0)
											{
												facility2.SetDamagePts(false, XmlConvert.ToSingle(xmlNode10.InnerText));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "Kinematics", false) != 0)
										{
											continue;
										}
										goto IL_19EC;
									}
									IL_D9A:
									ActiveUnit activeUnit2 = facility2;
									activeUnit = facility2;
									((Facility)activeUnit2).m_AirOps = ActiveUnit_AirOps.Load(ref xmlNode10, ref dictionary_0, ref activeUnit);
									continue;
									IL_E67:
									Facility facility4 = facility2;
									activeUnit = facility2;
									facility4.facility_AI = Facility_AI.Load(ref xmlNode10, ref dictionary_0, ref activeUnit);
									continue;
								}
								if (num2 <= 3020647921u)
								{
									if (num2 <= 2564648390u)
									{
										if (num2 <= 2128224206u)
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
													goto IL_1492;
												}
												else
												{
													if (Operators.CompareString(name2, "SBED_TF", false) == 0)
													{
														facility2.SBEngagedDefensive_TerrainFollowing = Conversions.ToBoolean(xmlNode10.InnerText);
														continue;
													}
													continue;
												}
											}
											else if (num2 != 1992083866u)
											{
												if (num2 != 2128224206u)
												{
													continue;
												}
												if (Operators.CompareString(name2, "CH", false) != 0)
												{
													continue;
												}
												goto IL_1A32;
											}
											else
											{
												if (Operators.CompareString(name2, "Latitude_UnitEntersAreaCheck", false) == 0)
												{
													facility2.SetLatitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode10.InnerText)));
													continue;
												}
												continue;
											}
										}
										else if (num2 <= 2323739590u)
										{
											if (num2 != 2247649009u)
											{
												if (num2 == 2323739590u && Operators.CompareString(name2, "Sensory", false) == 0)
												{
													goto IL_115A;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "AssignedMission", false) == 0 && xmlNode10.HasChildNodes)
												{
													XmlNode xmlNode11 = xmlNode10.ChildNodes[0];
													facility2.AssignedMissionName = xmlNode11.InnerText;
													continue;
												}
												continue;
											}
										}
										else if (num2 != 2496321123u)
										{
											if (num2 == 2564648390u && Operators.CompareString(name2, "Lon", false) == 0)
											{
												goto IL_11E9;
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
													facility2.GetRangeSymbols().Add(item);
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
									if (num2 <= 2874698282u)
									{
										if (num2 <= 2749693904u)
										{
											if (num2 != 2590053246u)
											{
												if (num2 == 2749693904u && Operators.CompareString(name2, "DesiredSpeed", false) == 0)
												{
													goto IL_12D5;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "Side", false) == 0)
												{
													facility2.strSide = xmlNode10.InnerText;
													continue;
												}
												continue;
											}
										}
										else if (num2 != 2844845263u)
										{
											if (num2 == 2874698282u && Operators.CompareString(name2, "AssignedTaskPool", false) == 0 && xmlNode10.HasChildNodes)
											{
												XmlNode xmlNode12 = xmlNode10.ChildNodes[0];
												facility2.AssignedTaskPoolName = xmlNode12.InnerText;
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SBEO_Altitude", false) == 0)
											{
												facility2.SBEngagedOffensive_Altitude = XmlConvert.ToSingle(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 <= 2920208772u)
									{
										if (num2 != 2904824734u)
										{
											if (num2 == 2920208772u && Operators.CompareString(name2, "Message", false) == 0)
											{
												facility2.Message = xmlNode10.InnerText;
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SBEO_Altitude_TF", false) == 0)
											{
												facility2.SBEngagedOffensive_Altitude_TerrainFollowing = XmlConvert.ToSingle(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 != 2923116889u)
									{
										if (num2 != 3001749054u)
										{
											if (num2 == 3020647921u && Operators.CompareString(name2, "ActiveUnit_DockingOps", false) == 0)
											{
												goto IL_145C;
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
										string innerText4 = xmlNode10.InnerText;
										if (Operators.CompareString(innerText4, "FullStop", false) == 0)
										{
											facility2.SBR_ThrottleSetting = ActiveUnit.Throttle.FullStop;
											continue;
										}
										if (Operators.CompareString(innerText4, "Loiter", false) == 0)
										{
											facility2.SBR_ThrottleSetting = ActiveUnit.Throttle.Loiter;
											continue;
										}
										if (Operators.CompareString(innerText4, "Cruise", false) == 0)
										{
											facility2.SBR_ThrottleSetting = ActiveUnit.Throttle.Cruise;
											continue;
										}
										if (Operators.CompareString(innerText4, "Full", false) == 0)
										{
											facility2.SBR_ThrottleSetting = ActiveUnit.Throttle.Full;
											continue;
										}
										if (Operators.CompareString(innerText4, "Flank", false) != 0)
										{
											facility2.SBR_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
											continue;
										}
										facility2.SBR_ThrottleSetting = ActiveUnit.Throttle.Flank;
										continue;
									}
									IL_1492:
									facility2.SetLatitude(null, XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", ".")));
									continue;
								}
								if (num2 <= 3389022305u)
								{
									if (num2 <= 3189373444u)
									{
										if (num2 <= 3139717856u)
										{
											if (num2 != 3070770765u)
											{
												if (num2 == 3139717856u && Operators.CompareString(name2, "Facility_Damage", false) == 0)
												{
													goto IL_15F1;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name2, "SBR_Altitude", false) == 0)
												{
													facility2.SBR_Altitude = XmlConvert.ToSingle(xmlNode10.InnerText);
													continue;
												}
												continue;
											}
										}
										else if (num2 != 3162615902u)
										{
											if (num2 == 3189373444u && Operators.CompareString(name2, "LonLR", false) == 0)
											{
												facility2.SetLongitudeLR(new double?(XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", "."))));
												continue;
											}
											continue;
										}
										else if (Operators.CompareString(name2, "Facility_Navigator", false) != 0)
										{
											continue;
										}
									}
									else if (num2 <= 3251319825u)
									{
										if (num2 != 3204468496u)
										{
											if (num2 == 3251319825u && Operators.CompareString(name2, "SBR_TF", false) == 0)
											{
												facility2.SBR_TerrainFollowing = Conversions.ToBoolean(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "SBEO", false) == 0)
											{
												facility2.SBEngagedOffensive = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num2 != 3283119613u)
									{
										if (num2 != 3370184216u)
										{
											if (num2 == 3389022305u && Operators.CompareString(name2, "SBED", false) == 0)
											{
												facility2.SBEngagedDefensive = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode10.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name2, "DesiredTurnRate", false) == 0)
											{
												goto IL_179F;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name2, "CurrentSpeed", false) == 0)
										{
											goto IL_17CE;
										}
										continue;
									}
								}
								else if (num2 <= 3715915568u)
								{
									if (num2 > 3559367371u)
									{
										if (num2 != 3636905136u)
										{
											if (num2 != 3715915568u)
											{
												continue;
											}
											if (Operators.CompareString(name2, "Facility_Weaponry", false) != 0)
											{
												continue;
											}
										}
										else if (Operators.CompareString(name2, "Weaponry", false) != 0)
										{
											continue;
										}
										Facility facility5 = facility2;
										activeUnit = facility2;
										facility5.facility_Weaponry = Facility_Weaponry.Load(ref xmlNode10, ref dictionary_0, ref activeUnit);
										continue;
									}
									if (num2 != 3533666526u)
									{
										if (num2 != 3559367371u || Operators.CompareString(name2, "SBEO_ThrottleSetting", false) != 0)
										{
											continue;
										}
										string innerText5 = xmlNode10.InnerText;
										if (Operators.CompareString(innerText5, "FullStop", false) == 0)
										{
											facility2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.FullStop;
											continue;
										}
										if (Operators.CompareString(innerText5, "Loiter", false) == 0)
										{
											facility2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Loiter;
											continue;
										}
										if (Operators.CompareString(innerText5, "Cruise", false) == 0)
										{
											facility2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Cruise;
											continue;
										}
										if (Operators.CompareString(innerText5, "Full", false) == 0)
										{
											facility2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Full;
											continue;
										}
										if (Operators.CompareString(innerText5, "Flank", false) != 0)
										{
											facility2.SBEngagedOffensive_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode10.InnerText);
											continue;
										}
										facility2.SBEngagedOffensive_ThrottleSetting = ActiveUnit.Throttle.Flank;
										continue;
									}
									else if (Operators.CompareString(name2, "Navigator", false) != 0)
									{
										continue;
									}
								}
								else if (num2 <= 3736393060u)
								{
									if (num2 != 3726331919u)
									{
										if (num2 == 3736393060u && Operators.CompareString(name2, "ParentGroup", false) == 0)
										{
											facility2.ParentGroupName = xmlNode10.InnerText;
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name2, "Facility_Kinematics", false) == 0)
										{
											goto IL_19EC;
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
											goto IL_1A32;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name2, "IsAutoDetectable", false) == 0)
										{
											goto IL_1A5B;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name2, "Longitude_UnitEntersAreaCheck", false) == 0)
									{
										facility2.SetLongitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode10.InnerText)));
										continue;
									}
									continue;
								}
								Facility facility6 = facility2;
								activeUnit = facility2;
								facility6.facility_Navigator = Facility_Navigator.Load(ref xmlNode10, ref dictionary_0, ref activeUnit);
								continue;
								IL_1A32:
								facility2.SetCurrentHeading(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_115A:
								Facility facility7 = facility2;
								activeUnit = facility2;
								facility7.facility_Sensory = Facility_Sensory.Load(ref xmlNode10, ref dictionary_0, ref activeUnit);
								continue;
								IL_11E9:
								facility2.SetLongitude(null, XmlConvert.ToDouble(xmlNode10.InnerText.Replace(",", ".")));
								continue;
								IL_12D5:
								facility2.SetDesiredSpeed(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_145C:
								ActiveUnit activeUnit3 = facility2;
								activeUnit = facility2;
								((Facility)activeUnit3).m_DockingOps = ActiveUnit_DockingOps.Load(ref xmlNode10, ref dictionary_0, ref activeUnit);
								continue;
								IL_15F1:
								Facility facility8 = facility2;
								activeUnit = facility2;
								facility8.facility_Damage = Facility_Damage.smethod_1(ref xmlNode10, ref dictionary_0, ref activeUnit);
								continue;
								IL_179F:
								facility2.SetDesiredTurnRate((ActiveUnit._TurnRate)Conversions.ToByte(xmlNode10.InnerText));
								continue;
								IL_17CE:
								facility2.SetCurrentSpeed(XmlConvert.ToSingle(xmlNode10.InnerText));
								continue;
								IL_19EC:
								ActiveUnit_Kinematics.Load(xmlNode10, dictionary_0, facility2);
								continue;
								IL_1A5B:
								facility2.SetIsAutoDetectable(null, Conversions.ToBoolean(xmlNode10.InnerText));
							}
						}
						finally
						{
							if (enumerator11 is IDisposable)
							{
								(enumerator11 as IDisposable).Dispose();
							}
						}
						facility2.SetAltitude_ASL(false, (float)facility2.GetTerrainElevation(false, false, false));
						facility = facility2;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100541", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = facility;
			return result;
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x00359508 File Offset: 0x00357708
		public override float GetArea()
		{
			return (float)this.Area;
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool IsPlatform()
		{
			return true;
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x0002C525 File Offset: 0x0002A725
		public override GlobalVariables.ActiveUnitType GetUnitType()
		{
			return GlobalVariables.ActiveUnitType.Facility;
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x00359520 File Offset: 0x00357720
		public Facility._MobileUnitCategory GetMobileUnitCategory()
		{
			if (!this.MobileUnitCategory.HasValue)
			{
				string text = Misc.smethod_45(this.UnitClass);
				uint num = Class382.smethod_0(text);
				if (num <= 716611045u)
				{
					if (num <= 536261884u)
					{
						if (num != 108276744u)
						{
							if (num == 536261884u && Operators.CompareString(text, "SAM", false) == 0)
							{
								this.MobileUnitCategory = new Facility._MobileUnitCategory?(Facility._MobileUnitCategory.SAM);
								goto IL_1E5;
							}
						}
						else if (Operators.CompareString(text, "Inf", false) == 0)
						{
							this.MobileUnitCategory = new Facility._MobileUnitCategory?(Facility._MobileUnitCategory.Infrantry);
							goto IL_1E5;
						}
					}
					else if (num != 562859689u)
					{
						if (num == 716611045u && Operators.CompareString(text, "Armored", false) == 0)
						{
							this.MobileUnitCategory = new Facility._MobileUnitCategory?(Facility._MobileUnitCategory.Armor);
							goto IL_1E5;
						}
					}
					else if (Operators.CompareString(text, "Arty", false) == 0)
					{
						this.MobileUnitCategory = new Facility._MobileUnitCategory?(Facility._MobileUnitCategory.ArtilleryGun);
						goto IL_1E5;
					}
				}
				else if (num <= 1267298235u)
				{
					if (num != 1142521834u)
					{
						if (num == 1267298235u && Operators.CompareString(text, "Radar", false) == 0)
						{
							this.MobileUnitCategory = new Facility._MobileUnitCategory?(Facility._MobileUnitCategory.Surveillance);
							goto IL_1E5;
						}
					}
					else if (Operators.CompareString(text, "SSM", false) == 0)
					{
						this.MobileUnitCategory = new Facility._MobileUnitCategory?(Facility._MobileUnitCategory.ArtillerySSM);
						goto IL_1E5;
					}
				}
				else if (num != 3061902210u)
				{
					if (num == 3887666188u && Operators.CompareString(text, "Mech", false) == 0)
					{
						this.MobileUnitCategory = new Facility._MobileUnitCategory?(Facility._MobileUnitCategory.MechanizedInfantry);
						goto IL_1E5;
					}
				}
				else if (Operators.CompareString(text, "AAA", false) == 0)
				{
					this.MobileUnitCategory = new Facility._MobileUnitCategory?(Facility._MobileUnitCategory.AAA);
					goto IL_1E5;
				}
				this.MobileUnitCategory = new Facility._MobileUnitCategory?(Facility._MobileUnitCategory.None);
			}
			IL_1E5:
			return this.MobileUnitCategory.Value;
		}

		// Token: 0x060066C1 RID: 26305 RVA: 0x00359720 File Offset: 0x00357920
		public static Facility._MobileUnitCategory smethod_4(string string_9)
		{
			string text = Misc.smethod_45(string_9);
			uint num = Class382.smethod_0(text);
			Facility._MobileUnitCategory result;
			if (num <= 716611045u)
			{
				if (num <= 536261884u)
				{
					if (num != 108276744u)
					{
						if (num == 536261884u && Operators.CompareString(text, "SAM", false) == 0)
						{
							result = Facility._MobileUnitCategory.SAM;
							return result;
						}
					}
					else if (Operators.CompareString(text, "Inf", false) == 0)
					{
						result = Facility._MobileUnitCategory.Infrantry;
						return result;
					}
				}
				else if (num != 562859689u)
				{
					if (num == 716611045u && Operators.CompareString(text, "Armored", false) == 0)
					{
						result = Facility._MobileUnitCategory.Armor;
						return result;
					}
				}
				else if (Operators.CompareString(text, "Arty", false) == 0)
				{
					result = Facility._MobileUnitCategory.ArtilleryGun;
					return result;
				}
			}
			else if (num <= 1267298235u)
			{
				if (num != 1142521834u)
				{
					if (num == 1267298235u && Operators.CompareString(text, "Radar", false) == 0)
					{
						result = Facility._MobileUnitCategory.Surveillance;
						return result;
					}
				}
				else if (Operators.CompareString(text, "SSM", false) == 0)
				{
					result = Facility._MobileUnitCategory.ArtillerySSM;
					return result;
				}
			}
			else if (num != 3061902210u)
			{
				if (num == 3887666188u && Operators.CompareString(text, "Mech", false) == 0)
				{
					result = Facility._MobileUnitCategory.MechanizedInfantry;
					return result;
				}
			}
			else if (Operators.CompareString(text, "AAA", false) == 0)
			{
				result = Facility._MobileUnitCategory.AAA;
				return result;
			}
			result = Facility._MobileUnitCategory.None;
			return result;
		}

		// Token: 0x060066C2 RID: 26306 RVA: 0x0035989C File Offset: 0x00357A9C
		public string GetMobileUnitCategoryString()
		{
			switch (this.GetMobileUnitCategory())
			{
			case Facility._MobileUnitCategory.None:
			{
				string text = "None";
				string result = text;
				return result;
			}
			case Facility._MobileUnitCategory.Infrantry:
			{
				string text = "Infantry";
				string result = text;
				return result;
			}
			case Facility._MobileUnitCategory.Armor:
			{
				string text = "Armor";
				string result = text;
				return result;
			}
			case Facility._MobileUnitCategory.ArtilleryGun:
			{
				string text = "Artillery";
				string result = text;
				return result;
			}
			case Facility._MobileUnitCategory.ArtillerySSM:
			{
				string text = "Missile Artillery";
				string result = text;
				return result;
			}
			case Facility._MobileUnitCategory.AAA:
			{
				string text = "AAA";
				string result = text;
				return result;
			}
			case Facility._MobileUnitCategory.SAM:
			{
				string text = "SAM";
				string result = text;
				return result;
			}
			case Facility._MobileUnitCategory.Engineer:
			{
				string text = "Engineer";
				string result = text;
				return result;
			}
			case Facility._MobileUnitCategory.Surveillance:
			{
				string text = "Surveillance";
				string result = text;
				return result;
			}
			case Facility._MobileUnitCategory.MechanizedInfantry:
			{
				string text = "Mechanized Infantry";
				string result = text;
				return result;
			}
			}
			throw new NotImplementedException();
		}

		// Token: 0x060066C3 RID: 26307 RVA: 0x00359954 File Offset: 0x00357B54
		public bool method_129()
		{
			Facility._MobileUnitCategory mobileUnitCategory = this.GetMobileUnitCategory();
			return mobileUnitCategory - Facility._MobileUnitCategory.ArtilleryGun > 3 && mobileUnitCategory != Facility._MobileUnitCategory.Surveillance;
		}

		// Token: 0x060066C4 RID: 26308 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool IsRunOutOfFuel()
		{
			return false;
		}

		// Token: 0x060066C5 RID: 26309 RVA: 0x00359984 File Offset: 0x00357B84
		public override ActiveUnit.Throttle GetMaxThrottleAvailable()
		{
			ActiveUnit.Throttle result;
			if (base.IsFixedFacility())
			{
				result = ActiveUnit.Throttle.FullStop;
			}
			else
			{
				result = ActiveUnit.Throttle.Flank;
			}
			return result;
		}

		// Token: 0x060066C6 RID: 26310 RVA: 0x003599A8 File Offset: 0x00357BA8
		public override CommDevice[] GetCommDevices()
		{
			CommDevice[] result = null;
			try
			{
				if (!this.MountsAreAimpoints)
				{
					result = base.GetCommDevices();
				}
				else
				{
					CommDevice[] array = new CommDevice[this.m_CommDevices.Length - 1 + 1];
					Array.Copy(this.m_CommDevices, array, this.m_CommDevices.Length);
					int num = this.m_Mounts.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						Mount mount = this.m_Mounts[i];
						if (mount.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							int num2 = mount.m_CommDevices.Length - 1;
							for (int j = 0; j <= num2; j++)
							{
								CommDevice commDevice_ = mount.m_CommDevices[j];
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
				ex2.Data.Add("Error at 100542", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060066C7 RID: 26311 RVA: 0x00359AB8 File Offset: 0x00357CB8
		public override int GetMastHeight()
		{
			return this.MastHeight;
		}

		// Token: 0x060066C8 RID: 26312 RVA: 0x00359AD0 File Offset: 0x00357CD0
		public override int GetTargetVisualSize()
		{
			Facility._FacilityCategory category = this.Category;
			int num = 0;
			int result;
			if (category <= Facility._FacilityCategory.Building_Underground)
			{
				if (category != Facility._FacilityCategory.Building_Surface)
				{
					if (category == Facility._FacilityCategory.Building_Underground)
					{
						result = 0;
						return result;
					}
				}
				else
				{
					switch (this.GetTargetVisualSizeClass())
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
						result = 1;
						return result;
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						result = 4;
						return result;
					case GlobalVariables.TargetVisualSizeClass.Small:
						result = 6;
						return result;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						result = 20;
						return result;
					case GlobalVariables.TargetVisualSizeClass.Large:
						result = 30;
						return result;
					case GlobalVariables.TargetVisualSizeClass.VLarge:
						result = 40;
						return result;
					default:
						result = num;
						return result;
					}
				}
			}
			else
			{
				if (category == Facility._FacilityCategory.Mobile_Vehicle)
				{
					result = 4;
					return result;
				}
				if (category == Facility._FacilityCategory.Mobile_Personnel)
				{
					result = 2;
					return result;
				}
			}
			result = 0;
			return result;
		}

		// Token: 0x060066C9 RID: 26313 RVA: 0x00359B8C File Offset: 0x00357D8C
		public Facility_Navigator GetFacilityNavigator()
		{
			if (Information.IsNothing(this.facility_Navigator))
			{
				ActiveUnit activeUnit = this;
				this.facility_Navigator = new Facility_Navigator(ref activeUnit);
			}
			return this.facility_Navigator;
		}

		// Token: 0x060066CA RID: 26314 RVA: 0x00359BC0 File Offset: 0x00357DC0
		public Facility_AI GetFacilityAI()
		{
			if (Information.IsNothing(this.facility_AI))
			{
				ActiveUnit activeUnit = this;
				this.facility_AI = new Facility_AI(ref activeUnit);
			}
			return this.facility_AI;
		}

		// Token: 0x060066CB RID: 26315 RVA: 0x00359BF4 File Offset: 0x00357DF4
		public Facility_Kinematics GetFacilityKinematics()
		{
			if (Information.IsNothing(this.facility_Kinematics))
			{
				ActiveUnit activeUnit = this;
				this.facility_Kinematics = new Facility_Kinematics(ref activeUnit);
			}
			return this.facility_Kinematics;
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x00359C28 File Offset: 0x00357E28
		public Facility_Sensory GetFacilitySensory()
		{
			if (Information.IsNothing(this.facility_Sensory))
			{
				ActiveUnit activeUnit = this;
				this.facility_Sensory = new Facility_Sensory(ref activeUnit);
			}
			return this.facility_Sensory;
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x00359C5C File Offset: 0x00357E5C
		public Facility_Weaponry GetFacilityWeaponry()
		{
			if (Information.IsNothing(this.facility_Weaponry))
			{
				ActiveUnit activeUnit = this;
				this.facility_Weaponry = new Facility_Weaponry(ref activeUnit);
			}
			return this.facility_Weaponry;
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x00359C90 File Offset: 0x00357E90
		public Facility_CommStuff GetFacilityCommStuff()
		{
			if (Information.IsNothing(this.facility_CommStuff))
			{
				ActiveUnit activeUnit = this;
				this.facility_CommStuff = new Facility_CommStuff(ref activeUnit);
			}
			return this.facility_CommStuff;
		}

		// Token: 0x060066CF RID: 26319 RVA: 0x00359CC4 File Offset: 0x00357EC4
		public Facility_Damage GetFacilityDamage()
		{
			if (Information.IsNothing(this.facility_Damage))
			{
				ActiveUnit activeUnit = this;
				this.facility_Damage = new Facility_Damage(ref activeUnit);
			}
			return this.facility_Damage;
		}

		// Token: 0x060066D0 RID: 26320 RVA: 0x0002C528 File Offset: 0x0002A728
		public override bool IsUnderGround()
		{
			if (!this.bUnderGround.HasValue)
			{
				this.bUnderGround = new bool?(base.IsUnderGround());
			}
			return this.bUnderGround.Value;
		}

		// Token: 0x060066D1 RID: 26321 RVA: 0x0002C553 File Offset: 0x0002A753
		public override bool IsUnderWater()
		{
			if (!this.bUnderWater.HasValue)
			{
				this.bUnderWater = new bool?(base.IsUnderWater());
			}
			return this.bUnderWater.Value;
		}

		// Token: 0x060066D2 RID: 26322 RVA: 0x00359CF8 File Offset: 0x00357EF8
		public bool IsMobile()
		{
			Facility._FacilityCategory category = this.Category;
			return category - Facility._FacilityCategory.Mobile_Vehicle <= 1;
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x00359D1C File Offset: 0x00357F1C
		public override GlobalVariables.TargetVisualSizeClass GetTargetVisualSizeClass()
		{
			float damagePts = this.GetDamagePts(false);
			GlobalVariables.TargetVisualSizeClass result;
			if (damagePts > 5000f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VLarge;
			}
			else if (damagePts > 1000f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Large;
			}
			else if (damagePts > 500f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Medium;
			}
			else if (damagePts > 150f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Small;
			}
			else if (damagePts > 30f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VSmall;
			}
			else
			{
				result = GlobalVariables.TargetVisualSizeClass.Stealthy;
			}
			return result;
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x0002C57E File Offset: 0x0002A77E
		public Facility(ref Scenario theScen, string theGUID = null) : base(ref theScen, theGUID)
		{
			this.m_CommandPost = new CIC(this, "Command Post");
			this.m_Cargo = new Cargo(this);
			this.IsFacility = true;
		}

		// Token: 0x060066D5 RID: 26325 RVA: 0x0002AC82 File Offset: 0x00028E82
		public override void ScheduleLifeCycleActivities(float elapsedTime_, ref Random random_1)
		{
			this.GetDockingOps().ScheduleDockingOpsEvent(elapsedTime_);
		}

		// Token: 0x060066D6 RID: 26326 RVA: 0x00359D8C File Offset: 0x00357F8C
		public Mount method_138()
		{
			IEnumerable<Mount> source = this.m_Mounts.Where(Facility.MountFunc3);
			Mount result;
			if (source.Count<Mount>() > 0)
			{
				int index = GameGeneral.GetRandom().Next(0, source.Count<Mount>());
				result = source.ElementAtOrDefault(index);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060066D7 RID: 26327 RVA: 0x00359DDC File Offset: 0x00357FDC
		public override bool vmethod_41(double double_3, double double_4, ref byte byte_0, bool bool_18, ref bool bAboutToEnterNoNavZone, bool bool_20, ref bool bool_21, float? nullable_17, short? nullable_18, ref List<ActiveUnit> list_3, float float_22, bool bool_22, bool bool_23)
		{
			bool flag = false;
			bool result;
			try
			{
				byte_0 = 1;
				if (bool_22 && this.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.EngagedOffensive && !Information.IsNothing(this.GetAssignedMission(false)) && this.GetAssignedMission(false).MissionClass == Mission._MissionClass.Patrol)
				{
					Patrol patrol = (Patrol)this.GetAssignedMission(false);
					GeoPoint geoPoint = new GeoPoint(double_4, double_3);
					if (this.vmethod_40(patrol.ProsecutionAreaVertices, this.m_Scenario, true) && !geoPoint.method_22(ref patrol.ProsecutionAreaVertices, true))
					{
						bAboutToEnterNoNavZone = false;
						bool_21 = false;
						flag = false;
						result = false;
						return result;
					}
				}
				if (!bool_18 && this.GetFacilityNavigator().HasPathfindingCourse() && this.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.EngagedOffensive)
				{
					float num;
					if (Information.IsNothing(nullable_17))
					{
						num = base.HorizontalRangeTo(double_3, double_4);
					}
					else
					{
						num = nullable_17.Value;
					}
					if (num <= base.GetMoveDistance(2f))
					{
						bAboutToEnterNoNavZone = false;
						bool_21 = false;
						flag = true;
						result = true;
						return result;
					}
				}
				if (bool_23)
				{
					bAboutToEnterNoNavZone = base.AboutToEnterNoNavZone();
				}
				if ((bAboutToEnterNoNavZone || bool_18) && base.method_122(double_3, double_4, float_22))
				{
					bAboutToEnterNoNavZone = true;
					bool_21 = false;
					flag = false;
				}
				else if (!this.method_139(double_3, double_4, nullable_18))
				{
					bAboutToEnterNoNavZone = false;
					bool_21 = false;
					flag = false;
				}
				else
				{
					bAboutToEnterNoNavZone = false;
					bool_21 = false;
					flag = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200286", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				bAboutToEnterNoNavZone = false;
				bool_21 = false;
				flag = false;
				ProjectData.ClearProjectError();
			}
			result = flag;
			return result;
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x00359FA4 File Offset: 0x003581A4
		private bool method_139(double theLat, double theLon, short? ProvidedElevation = null)
		{
			bool result = false;
			try
			{
				short num;
				if (Information.IsNothing(ProvidedElevation))
				{
					num = Terrain.GetElevation(theLat, theLon, false);
				}
				else
				{
					num = ProvidedElevation.Value;
				}
				result = (num >= 0);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100544", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x0002C5BB File Offset: 0x0002A7BB
		public override void SetGeoLocation(ref Scenario scenario_, double Longitude_, double Latitude_)
		{
			base.SetGeoLocation(ref scenario_, Longitude_, Latitude_);
			this.SetAltitude_ASL(false, (float)base.GetTerrainElevation(false, false, true));
		}

		// Token: 0x060066DA RID: 26330 RVA: 0x0035A030 File Offset: 0x00358230
		public float GetCargoCrew()
		{
			return Math.Max(1000f, (float)this.Area);
		}

		// Token: 0x060066DB RID: 26331 RVA: 0x0035A030 File Offset: 0x00358230
		public float GetCargoArea()
		{
			return Math.Max(1000f, (float)this.Area);
		}

		// Token: 0x060066DC RID: 26332 RVA: 0x0002C5D7 File Offset: 0x0002A7D7
		public _CargoType GetCargoType()
		{
			return _CargoType.VeryLargeCargo;
		}

		// Token: 0x060066DD RID: 26333 RVA: 0x0035A030 File Offset: 0x00358230
		public float GetCargoMass()
		{
			return Math.Max(1000f, (float)this.Area);
		}

		// Token: 0x04003856 RID: 14422
		public static Func<Mount, Facility._MobileUnitCategory> MountFunc0 = (Mount mount_0) => mount_0.mobileUnitCategory;

		// Token: 0x04003857 RID: 14423
		public static Func<Mount, Mount> MountFunc1 = (Mount mount_0) => mount_0;

		// Token: 0x04003858 RID: 14424
		public static Func<Mount, bool> MountFunc3 = (Mount mount_0) => mount_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x04003859 RID: 14425
		public GlobalVariables.ArmorRating ArmorGeneral;

		// Token: 0x0400385A RID: 14426
		public Facility._FacilityCategory Category;

		// Token: 0x0400385B RID: 14427
		public float Length;

		// Token: 0x0400385C RID: 14428
		public float Width;

		// Token: 0x0400385D RID: 14429
		public double Area = 0.0;

		// Token: 0x0400385E RID: 14430
		public int MastHeight;

		// Token: 0x0400385F RID: 14431
		public int MissileDefense;

		// Token: 0x04003860 RID: 14432
		public new bool MountsAreAimpoints;

		// Token: 0x04003861 RID: 14433
		public int Radius;

		// Token: 0x04003862 RID: 14434
		public CIC m_CommandPost;

		// Token: 0x04003863 RID: 14435
		public Cargo m_Cargo;

		// Token: 0x04003864 RID: 14436
		private Facility_Navigator facility_Navigator;

		// Token: 0x04003865 RID: 14437
		private Facility_AI facility_AI;

		// Token: 0x04003866 RID: 14438
		private Facility_Kinematics facility_Kinematics;

		// Token: 0x04003867 RID: 14439
		private Facility_Sensory facility_Sensory;

		// Token: 0x04003868 RID: 14440
		private Facility_Weaponry facility_Weaponry;

		// Token: 0x04003869 RID: 14441
		private Facility_CommStuff facility_CommStuff;

		// Token: 0x0400386A RID: 14442
		private Facility_Damage facility_Damage;

		// Token: 0x0400386B RID: 14443
		private bool? bUnderGround;

		// Token: 0x0400386C RID: 14444
		private bool? bUnderWater;

		// Token: 0x0400386D RID: 14445
		private Facility._MobileUnitCategory? MobileUnitCategory;

		// Token: 0x0400386E RID: 14446
		private static Scenario scenario = null;

		// Token: 0x02000C0E RID: 3086
		public enum _FacilityCategory : short
		{
			// Token: 0x04003873 RID: 14451
			None = 1001,
			// Token: 0x04003874 RID: 14452
			Runway = 2001,
			// Token: 0x04003875 RID: 14453
			RunwayGrade_Taxiway,
			// Token: 0x04003876 RID: 14454
			RunwayAccessPoint,
			// Token: 0x04003877 RID: 14455
			Building_Surface = 3001,
			// Token: 0x04003878 RID: 14456
			Building_Reveted,
			// Token: 0x04003879 RID: 14457
			Building_Bunker,
			// Token: 0x0400387A RID: 14458
			Building_Underground,
			// Token: 0x0400387B RID: 14459
			Structure_Open,
			// Token: 0x0400387C RID: 14460
			Structure_Reveted,
			// Token: 0x0400387D RID: 14461
			Underwater = 4001,
			// Token: 0x0400387E RID: 14462
			Mobile_Vehicle = 5001,
			// Token: 0x0400387F RID: 14463
			Mobile_Personnel,
			// Token: 0x04003880 RID: 14464
			AerostatMooring = 6001,
			// Token: 0x04003881 RID: 14465
			AirBase = 9001
		}

		// Token: 0x02000C0F RID: 3087
		public enum _MobileUnitCategory : short
		{
			// Token: 0x04003883 RID: 14467
			None,
			// Token: 0x04003884 RID: 14468
			Infrantry,
			// Token: 0x04003885 RID: 14469
			Armor,
			// Token: 0x04003886 RID: 14470
			ArtilleryGun,
			// Token: 0x04003887 RID: 14471
			ArtillerySSM,
			// Token: 0x04003888 RID: 14472
			AAA,
			// Token: 0x04003889 RID: 14473
			SAM,
			// Token: 0x0400388A RID: 14474
			Engineer,
			// Token: 0x0400388B RID: 14475
			Supply,
			// Token: 0x0400388C RID: 14476
			Surveillance,
			// Token: 0x0400388D RID: 14477
			Recon,
			// Token: 0x0400388E RID: 14478
			MechanizedInfantry
		}
	}
}

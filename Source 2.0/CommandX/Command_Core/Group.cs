using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 组
	public sealed class Group : ActiveUnit
	{
		// Token: 0x06005944 RID: 22852 RVA: 0x0027683C File Offset: 0x00274A3C
		[CompilerGenerated]
		public  ObservableCollection<Patrol> GetPatrols()
		{
			return this.PatrolCollection;
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x00276854 File Offset: 0x00274A54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetPatrols(ObservableCollection<Patrol> observableCollection_2)
		{
			NotifyCollectionChangedEventHandler value = new NotifyCollectionChangedEventHandler(this.PatrolCollection_CollectionChanged);
			ObservableCollection<Patrol> patrolCollection = this.PatrolCollection;
			if (patrolCollection != null)
			{
				patrolCollection.CollectionChanged -= value;
			}
			this.PatrolCollection = observableCollection_2;
			patrolCollection = this.PatrolCollection;
			if (patrolCollection != null)
			{
				patrolCollection.CollectionChanged += value;
			}
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x002768A0 File Offset: 0x00274AA0
		[CompilerGenerated]
		public  ObservableDictionary<string, ActiveUnit> GetUnitsInGroup()
		{
			return this.UnitsInGroupDictionary;
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x002768B8 File Offset: 0x00274AB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetUnitsInGroup(ObservableDictionary<string, ActiveUnit> observableDictionary_1)
		{
			INotifyDictionaryChanged<string, ActiveUnit>.DictionaryChangedEventHandler value = new INotifyDictionaryChanged<string, ActiveUnit>.DictionaryChangedEventHandler(this.UnitsInGroupDictionary_DictionaryChanged);
			ObservableDictionary<string, ActiveUnit> unitsInGroupDictionary = this.UnitsInGroupDictionary;
			if (unitsInGroupDictionary != null)
			{
				unitsInGroupDictionary.DictionaryChanged -= value;
			}
			this.UnitsInGroupDictionary = observableDictionary_1;
			unitsInGroupDictionary = this.UnitsInGroupDictionary;
			if (unitsInGroupDictionary != null)
			{
				unitsInGroupDictionary.DictionaryChanged += value;
			}
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x00276904 File Offset: 0x00274B04
		[CompilerGenerated]
		public static void smethod_1(Group.Delegate14 delegate14_1)
		{
			Group.Delegate14 @delegate = Group.delegate14_0;
			Group.Delegate14 delegate2;
			do
			{
				delegate2 = @delegate;
				Group.Delegate14 value = (Group.Delegate14)Delegate.Combine(delegate2, delegate14_1);
				@delegate = Interlocked.CompareExchange<Group.Delegate14>(ref Group.delegate14_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x0027693C File Offset: 0x00274B3C
		[CompilerGenerated]
		public static void smethod_2(Group.Delegate14 delegate14_1)
		{
			Group.Delegate14 @delegate = Group.delegate14_0;
			Group.Delegate14 delegate2;
			do
			{
				delegate2 = @delegate;
				Group.Delegate14 value = (Group.Delegate14)Delegate.Remove(delegate2, delegate14_1);
				@delegate = Interlocked.CompareExchange<Group.Delegate14>(ref Group.delegate14_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x00276974 File Offset: 0x00274B74
		[CompilerGenerated]
		public static void smethod_3(Group.Delegate15 delegate15_1)
		{
			Group.Delegate15 @delegate = Group.delegate15_0;
			Group.Delegate15 delegate2;
			do
			{
				delegate2 = @delegate;
				Group.Delegate15 value = (Group.Delegate15)Delegate.Combine(delegate2, delegate15_1);
				@delegate = Interlocked.CompareExchange<Group.Delegate15>(ref Group.delegate15_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x002769AC File Offset: 0x00274BAC
		[CompilerGenerated]
		public static void smethod_4(Group.Delegate15 delegate15_1)
		{
			Group.Delegate15 @delegate = Group.delegate15_0;
			Group.Delegate15 delegate2;
			do
			{
				delegate2 = @delegate;
				Group.Delegate15 value = (Group.Delegate15)Delegate.Remove(delegate2, delegate15_1);
				@delegate = Interlocked.CompareExchange<Group.Delegate15>(ref Group.delegate15_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x002769E4 File Offset: 0x00274BE4
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("Group");
					xmlWriter_0.WriteElementString("ID", base.GetGuid());
					if (hashSet_0.Contains(base.GetGuid()))
					{
						xmlWriter_0.WriteEndElement();
					}
					else
					{
						hashSet_0.Add(base.GetGuid());
						xmlWriter_0.WriteElementString("Name", this.Name);
						if (!Information.IsNothing(this.groupType))
						{
							xmlWriter_0.WriteElementString("Type", ((int)this.groupType.Value).ToString());
						}
						xmlWriter_0.WriteElementString("CurrentHeading", XmlConvert.ToString(this.GetCurrentHeading()));
						xmlWriter_0.WriteElementString("CurrentSpeed", XmlConvert.ToString(this.GetCurrentSpeed()));
						xmlWriter_0.WriteElementString("CurrentAltitude", XmlConvert.ToString(this.GetCurrentAltitude_ASL(false)));
						xmlWriter_0.WriteElementString("Longitude", XmlConvert.ToString(this.GetLongitude(null)));
						xmlWriter_0.WriteElementString("Latitude", XmlConvert.ToString(this.GetLatitude(null)));
						xmlWriter_0.WriteElementString("UnitClass", this.UnitClass);
						xmlWriter_0.WriteStartElement("RangeSymbols");
						using (List<RangeSymbol>.Enumerator enumerator = base.GetRangeSymbols().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								enumerator.Current.Save(ref xmlWriter_0);
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteElementString("Side", this.GetSide(false).GetSideName());
						xmlWriter_0.WriteElementString("Message", this.Message);
						if (this.GetLongitude_UnitEntersAreaCheck().HasValue)
						{
							xmlWriter_0.WriteElementString("Longitude_UnitEntersAreaCheck", XmlConvert.ToString(this.GetLongitude_UnitEntersAreaCheck().Value));
						}
						if (this.GetLatitude_UnitEntersAreaCheck().HasValue)
						{
							xmlWriter_0.WriteElementString("Latitude_UnitEntersAreaCheck", XmlConvert.ToString(this.GetLatitude_UnitEntersAreaCheck().Value));
						}
						xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
						xmlWriter_0.WriteElementString("DesiredHeading", XmlConvert.ToString(this.GetDesiredHeading(ActiveUnit._TurnRate.const_0)));
						xmlWriter_0.WriteElementString("DesiredSpeed", XmlConvert.ToString(this.GetDesiredSpeed()));
						xmlWriter_0.WriteElementString("DesiredAltitude", XmlConvert.ToString(this.GetDesiredAltitude()));
						xmlWriter_0.WriteElementString("DesiredTurnRate", ((byte)this.GetDesiredTurnRate()).ToString());
						xmlWriter_0.WriteElementString("DesiredTurnRate_Navigation", ((byte)this.GetDesiredTurnRate_Navigation()).ToString());
						xmlWriter_0.WriteElementString("Weight", XmlConvert.ToString(this.WeightEmpty));
						xmlWriter_0.WriteElementString("ThrottleSetting", ((byte)this.GetThrottle()).ToString());
						this.m_Doctrine.Save(ref xmlWriter_0, ref this.m_Scenario, "Doctrine");
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
						xmlWriter_0.WriteStartElement("Mounts");
						Mount[] mounts = this.m_Mounts;
						for (int k = 0; k < mounts.Length; k++)
						{
							Mount mount = mounts[k];
							if (Information.IsNothing(mount.GetParentPlatform()))
							{
								mount.SetParentPlatform(this);
							}
							mount.Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("OnboardCargo");
						Cargo[] onboardCargos = this.m_OnboardCargos;
						for (int l = 0; l < onboardCargos.Length; l++)
						{
							onboardCargos[l].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
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
						xmlWriter_0.WriteStartElement("AirFacilities");
						AirFacility[] airFacilities = this.m_AirFacilities;
						for (int m = 0; m < airFacilities.Length; m++)
						{
							airFacilities[m].Save(ref xmlWriter_0, ref hashSet_0, this.m_Scenario);
						}
						xmlWriter_0.WriteEndElement();
						this.GetNavigator().Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("Group_AI");
						this.GetAI().Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Group_Kinematics");
						this.GetGroupKinematics().Save(ref xmlWriter_0);
						xmlWriter_0.WriteEndElement();
						this.GetSensory().Save(ref xmlWriter_0);
						this.GetWeaponry().Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteStartElement("Group_CommStuff");
						this.GetCommStuff().Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						this.GetAirOps().Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteElementString("Type", ((int)this.GetGroupType()).ToString());
						xmlWriter_0.WriteStartElement("Center");
						this.groupCenter.Save(ref xmlWriter_0, ref hashSet_0);
						xmlWriter_0.WriteEndElement();
						if (!Information.IsNothing(this.GetGroupLead()))
						{
							xmlWriter_0.WriteStartElement("GroupLead");
							this.GetGroupLead().Save(ref xmlWriter_0, ref hashSet_0);
							xmlWriter_0.WriteEndElement();
						}
						xmlWriter_0.WriteStartElement("Patrols");
						using (IEnumerator<Patrol> enumerator3 = this.GetPatrols().GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								enumerator3.Current.Save(ref xmlWriter_0, ref hashSet_0, ref this.m_Scenario);
							}
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteEndElement();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100589", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x002772BC File Offset: 0x002754BC
		private Group()
		{
			this.groupCenter = new GeoPoint();
			this.SetPatrols(new ObservableCollection<Patrol>());
			ActiveUnit activeUnit = this;
			this.group_Navigator = new Group_Navigator(ref activeUnit);
			activeUnit = this;
			this.group_AI = new Group_AI(ref activeUnit);
			activeUnit = this;
			this.group_Sensory = new Group_Sensory(ref activeUnit);
			activeUnit = this;
			this.group_Weaponry = new Group_Weaponry(ref activeUnit);
			activeUnit = this;
			this.group_CommStuff = new Group_CommStuff(ref activeUnit);
			activeUnit = this;
			this.group_AirOps = new Group_AirOps(ref activeUnit);
			this.SetUnitsInGroup(new ObservableDictionary<string, ActiveUnit>());
			this.IsGroup = true;
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x00277354 File Offset: 0x00275554
		public new static Group Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_1)
		{
			checked
			{
				Group group4;
				Group result;
				try
				{
					Group group = new Group();
					group.m_Scenario = scenario_1;
					string arg_25_0 = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
					IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							XmlNode xmlNode = (XmlNode)enumerator.Current;
							string name = xmlNode.Name;
							uint num = Class382.smethod_0(name);
							if (num <= 2066337159u)
							{
								if (num <= 1268760228u)
								{
									if (num <= 441941816u)
									{
										if (num <= 74041507u)
										{
											if (num != 6222351u)
											{
												if (num == 74041507u && Operators.CompareString(name, "Group_Kinematics", false) == 0)
												{
													Group group2 = group;
													ActiveUnit activeUnit = group;
													group2.group_Kinematics = Group_Kinematics.Load(ref xmlNode, ref dictionary_0, ref activeUnit);
												}
											}
											else if (Operators.CompareString(name, "Status", false) == 0)
											{
												if (Versioned.IsNumeric(xmlNode.InnerText))
												{
													group.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode.InnerText));
												}
												else
												{
													group.SetUnitStatus((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode.InnerText, true));
												}
											}
										}
										else if (num != 266367750u)
										{
											if (num != 429749699u)
											{
												if (num == 441941816u && Operators.CompareString(name, "CurrentAltitude", false) == 0)
												{
													group.SetAltitude_ASL(false, XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
												}
											}
											else if (Operators.CompareString(name, "DesiredTurnRate_Navigation", false) == 0)
											{
												group.SetDesiredTurnRate_Navigation((Waypoint._TurnRate)Conversions.ToByte(xmlNode.InnerText));
											}
										}
										else if (Operators.CompareString(name, "Name", false) == 0)
										{
											group.Name = xmlNode.InnerText;
										}
									}
									else if (num <= 803760973u)
									{
										if (num != 664498478u)
										{
											if (num == 803760973u && Operators.CompareString(name, "DamagePts", false) == 0)
											{
												group.SetDamagePts(false, XmlConvert.ToSingle(xmlNode.InnerText));
											}
										}
										else if (Operators.CompareString(name, "FuelState", false) == 0)
										{
											group.activeUnitFuelState = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode.InnerText);
										}
									}
									else if (num != 892023141u)
									{
										if (num != 1255847155u)
										{
											if (num == 1268760228u && Operators.CompareString(name, "Center", false) == 0)
											{
												Group group3 = group;
												XmlNode xmlNode2 = xmlNode.ChildNodes[0];
												group3.groupCenter = GeoPoint.Load(ref xmlNode2, ref dictionary_0);
											}
										}
										else if (Operators.CompareString(name, "ThrottleSetting", false) == 0)
										{
											string innerText = xmlNode.InnerText;
											if (Operators.CompareString(innerText, "FullStop", false) != 0)
											{
												if (Operators.CompareString(innerText, "Loiter", false) != 0)
												{
													if (Operators.CompareString(innerText, "Cruise", false) != 0)
													{
														if (Operators.CompareString(innerText, "Full", false) != 0)
														{
															if (Operators.CompareString(innerText, "Flank", false) != 0)
															{
																group.currentThrottle = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
															}
															else
															{
																group.currentThrottle = ActiveUnit.Throttle.Flank;
															}
														}
														else
														{
															group.currentThrottle = ActiveUnit.Throttle.Full;
														}
													}
													else
													{
														group.currentThrottle = ActiveUnit.Throttle.Cruise;
													}
												}
												else
												{
													group.currentThrottle = ActiveUnit.Throttle.Loiter;
												}
											}
											else
											{
												group.currentThrottle = ActiveUnit.Throttle.FullStop;
											}
										}
									}
									else if (Operators.CompareString(name, "DesiredHeading", false) == 0)
									{
										group.desiredHeading = XmlConvert.ToSingle(xmlNode.InnerText);
									}
								}
								else if (num <= 1729717486u)
								{
									if (num <= 1422437055u)
									{
										if (num != 1305748348u)
										{
											if (num == 1422437055u && Operators.CompareString(name, "Doctrine", false) == 0)
											{
												group.m_Doctrine = Doctrine.SetDoctrineForMission(ref xmlNode, group);
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
													Cargo cargo = Cargo.Load(ref xmlNode3, ref dictionary_0, group);
													ScenarioArrayUtil.AddCargo(ref group.m_OnboardCargos, cargo);
													cargo.SetParentPlatform(group);
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
									if (num != 1458105184u)
									{
										if (num != 1476905714u)
										{
											if (num == 1729717486u && Operators.CompareString(name, "Longitude", false) == 0)
											{
												group.SetLongitude(null, XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", ".")));
											}
										}
										else if (Operators.CompareString(name, "WeaponState", false) == 0)
										{
											group.weaponState = (ActiveUnit._ActiveUnitWeaponState)Conversions.ToByte(xmlNode.InnerText);
										}
									}
									else if (Operators.CompareString(name, "ID", false) == 0)
									{
										if (dictionary_0.ContainsKey(xmlNode.InnerText))
										{
											group4 = (Group)dictionary_0[xmlNode.InnerText];
											result = group4;
											return result;
										}
										group.SetGuid(xmlNode.InnerText);
										if (xmlNode_0.ChildNodes.Count == 1)
										{
											scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
											group4 = group;
											result = group4;
											return result;
										}
										dictionary_0.Add(group.GetGuid(), group);
									}
								}
								else if (num <= 1883345757u)
								{
									if (num != 1836990821u)
									{
										if (num != 1848783177u)
										{
											if (num == 1883345757u && Operators.CompareString(name, "Group_AirOps", false) == 0)
											{
												Group group5 = group;
												ActiveUnit activeUnit = group;
												group5.group_AirOps = Group_AirOps.smethod_1(ref xmlNode, ref dictionary_0, ref activeUnit);
											}
										}
										else if (Operators.CompareString(name, "UnitClass", false) == 0)
										{
											group.UnitClass = xmlNode.InnerText;
										}
									}
									else if (Operators.CompareString(name, "Latitude", false) == 0)
									{
										group.SetLatitude(null, XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", ".")));
									}
								}
								else
								{
									if (num != 1992083866u)
									{
										if (num != 2008421230u)
										{
											if (num == 2066337159u && Operators.CompareString(name, "DesiredAltitude", false) == 0)
											{
												group.desiredAltitude = XmlConvert.ToSingle(xmlNode.InnerText);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Comms", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator3.MoveNext())
												{
													XmlNode xmlNode4 = (XmlNode)enumerator3.Current;
													CommDevice commDevice = CommDevice.Load(ref xmlNode4, ref dictionary_0, group);
													group.AddCommDevice(commDevice);
													commDevice.SetParentPlatform(group);
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
									if (Operators.CompareString(name, "Latitude_UnitEntersAreaCheck", false) == 0)
									{
										group.SetLatitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode.InnerText)));
									}
								}
							}
							else if (num <= 3283119613u)
							{
								if (num <= 2570065113u)
								{
									if (num <= 2246682072u)
									{
										if (num != 2187602126u)
										{
											if (num != 2246682072u || Operators.CompareString(name, "Propulsion", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator4 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator4.MoveNext())
												{
													XmlNode xmlNode5 = (XmlNode)enumerator4.Current;
													ActiveUnit activeUnit = group;
													Engine engine = Engine.Load(ref xmlNode5, ref dictionary_0, ref activeUnit);
													group.GetEngines().Add(engine);
													engine.SetParentPlatform(group);
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
										if (Operators.CompareString(name, "DBID", false) == 0)
										{
											group.DBID = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (num != 2424405304u)
										{
											if (num != 2496321123u)
											{
												if (num == 2570065113u && Operators.CompareString(name, "Weight", false) == 0)
												{
													group.WeightEmpty = XmlConvert.ToInt32(xmlNode.InnerText);
													continue;
												}
												continue;
											}
											else
											{
												if (Operators.CompareString(name, "RangeSymbols", false) != 0)
												{
													continue;
												}
												IEnumerator enumerator5 = xmlNode.ChildNodes.GetEnumerator();
												try
												{
													while (enumerator5.MoveNext())
													{
														RangeSymbol item = RangeSymbol.Load((XmlNode)enumerator5.Current, dictionary_0);
														group.GetRangeSymbols().Add(item);
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
										if (Operators.CompareString(name, "Sensors", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator6 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator6.MoveNext())
											{
												Sensor sensor = Sensor.Load((XmlNode)enumerator6.Current, dictionary_0, group);
												ScenarioArrayUtil.AddSensor(ref group.m_Sensors, sensor);
												sensor.SetParentPlatform(group);
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
								if (num <= 2749693904u)
								{
									if (num != 2590053246u)
									{
										if (num != 2694467229u)
										{
											if (num == 2749693904u && Operators.CompareString(name, "DesiredSpeed", false) == 0)
											{
												group.desiredSpeed = XmlConvert.ToSingle(xmlNode.InnerText);
											}
										}
										else if (Operators.CompareString(name, "Group_CommStuff", false) == 0)
										{
											Group group6 = group;
											ActiveUnit activeUnit = group;
											group6.group_CommStuff = Group_CommStuff.Load(ref xmlNode, ref dictionary_0, ref activeUnit);
										}
									}
									else if (Operators.CompareString(name, "Side", false) == 0)
									{
										group.strSide = xmlNode.InnerText;
										Side[] sides = scenario_1.GetSides();
										for (int i = 0; i < sides.Length; i++)
										{
											Side side = sides[i];
											if (Operators.CompareString(side.GetSideName(), group.strSide, false) == 0)
											{
												group.SetSide(false, side);
											}
										}
									}
								}
								else if (num != 2824222426u)
								{
									if (num != 2920208772u)
									{
										if (num == 3283119613u && Operators.CompareString(name, "CurrentSpeed", false) == 0)
										{
											group.SetCurrentSpeed(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
										}
									}
									else if (Operators.CompareString(name, "Message", false) == 0)
									{
										group.Message = xmlNode.InnerText;
									}
								}
								else if (Operators.CompareString(name, "Group_Sensory", false) == 0)
								{
									Group group6 = group;
									ActiveUnit activeUnit = group;
									group6.group_Sensory = Group_Sensory.smethod_8(ref xmlNode, ref dictionary_0, ref activeUnit);
								}
							}
							else if (num <= 3544932644u)
							{
								if (num <= 3370184216u)
								{
									if (num != 3315194562u)
									{
										if (num == 3370184216u && Operators.CompareString(name, "DesiredTurnRate", false) == 0)
										{
											group.SetDesiredTurnRate((ActiveUnit._TurnRate)Conversions.ToByte(xmlNode.InnerText));
										}
									}
									else if (Operators.CompareString(name, "Group_Navigator", false) == 0)
									{
										Group group6 = group;
										ActiveUnit activeUnit = group;
										group6.group_Navigator = Group_Navigator.Load(ref xmlNode, ref dictionary_0, ref activeUnit);
									}
								}
								else if (num != 3474221763u)
								{
									if (num != 3512062061u)
									{
										if (num == 3544932644u && Operators.CompareString(name, "Group_Weaponry", false) == 0)
										{
											Group group6 = group;
											ActiveUnit activeUnit = group;
											group6.group_Weaponry = Group_Weaponry.Load(ref xmlNode, ref dictionary_0, ref activeUnit);
										}
									}
									else if (Operators.CompareString(name, "Type", false) == 0)
									{
										group.groupType = new Group.GroupType?((Group.GroupType)Conversions.ToByte(xmlNode.InnerText));
									}
								}
								else if (Operators.CompareString(name, "Group_AI", false) == 0)
								{
									Group group6 = group;
									ActiveUnit activeUnit = group;
									group6.group_AI = Group_AI.Load(ref xmlNode, ref dictionary_0, ref activeUnit);
								}
							}
							else
							{
								if (num <= 3989581338u)
								{
									if (num != 3760177291u)
									{
										if (num != 3792306253u)
										{
											if (num != 3989581338u || Operators.CompareString(name, "AirFacilities", false) != 0)
											{
												continue;
											}
											IEnumerator enumerator7 = xmlNode.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator7.MoveNext())
												{
													XmlNode xmlNode6 = (XmlNode)enumerator7.Current;
													AirFacility airFacility = AirFacility.Load(ref xmlNode6, ref dictionary_0, ref scenario_1);
													group.AddAirFacility(airFacility);
													airFacility.SetParentPlatform(group);
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
										if (Operators.CompareString(name, "Longitude_UnitEntersAreaCheck", false) == 0)
										{
											group.SetLongitude_UnitEntersAreaCheck(new double?(XmlConvert.ToDouble(xmlNode.InnerText)));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Mounts", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator8 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator8.MoveNext())
											{
												XmlNode xmlNode7 = (XmlNode)enumerator8.Current;
												Mount mount = Mount.Load(ref xmlNode7, ref dictionary_0, group);
												ScenarioArrayUtil.AddMount(ref group.m_Mounts, mount);
												mount.SetParentPlatform(group);
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
								}
								if (num != 4077412634u)
								{
									if (num != 4152621540u)
									{
										if (num != 4239247960u || Operators.CompareString(name, "Patrols", false) != 0)
										{
											continue;
										}
										IEnumerator enumerator9 = xmlNode.ChildNodes.GetEnumerator();
										try
										{
											while (enumerator9.MoveNext())
											{
												XmlNode xmlNode8 = (XmlNode)enumerator9.Current;
												Patrol item2 = Patrol.Load(ref xmlNode8, ref dictionary_0, ref scenario_1);
												group.GetPatrols().Add(item2);
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
									if (Operators.CompareString(name, "CurrentHeading", false) == 0)
									{
										group.SetCurrentHeading(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									}
								}
								else if (Operators.CompareString(name, "GroupLead", false) == 0 && xmlNode.HasChildNodes)
								{
									Group group6 = group;
									XmlNode xmlNode2 = xmlNode.ChildNodes[0];
									group6.GroupLead = ActiveUnit.Load(ref xmlNode2, ref dictionary_0, ref scenario_1);
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
					if (group.GetGroupType() == Group.GroupType.AirGroup && group.currentThrottle == ActiveUnit.Throttle.FullStop)
					{
						group.currentThrottle = ActiveUnit.Throttle.Cruise;
					}
					group4 = group;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100590", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					group4 = new Group();
					ProjectData.ClearProjectError();
				}
				result = group4;
				return result;
			}
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x0027846C File Offset: 0x0027666C
		public override GlobalVariables.ProficiencyLevel? GetProficiencyLevel()
		{
			return base.GetProficiencyLevel();
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x00278484 File Offset: 0x00276684
		public override void SetProficiencyLevel(GlobalVariables.ProficiencyLevel? value)
		{
			using (IEnumerator<ActiveUnit> enumerator = this.GetUnitsInGroup().Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.SetProficiencyLevel(value);
				}
			}
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x002784D8 File Offset: 0x002766D8
		public override ActiveUnit._ActiveUnitStatus GetUnitStatus()
		{
			ActiveUnit._ActiveUnitStatus result;
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				result = this.GetGroupLead().GetUnitStatus();
			}
			else
			{
				result = ActiveUnit._ActiveUnitStatus.Unassigned;
			}
			return result;
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x00028502 File Offset: 0x00026702
		public override void SetUnitStatus(ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_5)
		{
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				this.GetGroupLead().SetUnitStatus(_ActiveUnitStatus_5);
			}
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x00278508 File Offset: 0x00276708
		public override double GetLongitude(bool? _HintIsOperating = null)
		{
			double longitude;
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				longitude = this.GetGroupLead().GetLongitude(null);
			}
			else
			{
				longitude = base.GetLongitude(null);
			}
			return longitude;
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x00278558 File Offset: 0x00276758
		public override void SetLongitude(bool? _HintIsOperating, double value)
		{
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				this.GetGroupLead().SetLongitude(null, value);
			}
			else
			{
				base.SetLongitude(null, value);
			}
		}

		// Token: 0x06005955 RID: 22869 RVA: 0x0027859C File Offset: 0x0027679C
		public override double GetLatitude(bool? _HintIsOperating = null)
		{
			double latitude;
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				latitude = this.GetGroupLead().GetLatitude(null);
			}
			else
			{
				latitude = base.GetLatitude(null);
			}
			return latitude;
		}

		// Token: 0x06005956 RID: 22870 RVA: 0x002785EC File Offset: 0x002767EC
		public override void SetLatitude(bool? _HintIsOperating, double value)
		{
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				this.GetGroupLead().SetLatitude(null, value);
			}
			else
			{
				base.SetLatitude(null, value);
			}
		}

		// Token: 0x06005957 RID: 22871 RVA: 0x00278630 File Offset: 0x00276830
		public override float GetCurrentAltitude_ASL(bool DoSanityCheck = false)
		{
			float currentAltitude_ASL;
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				currentAltitude_ASL = this.GetGroupLead().GetCurrentAltitude_ASL(false);
			}
			else
			{
				currentAltitude_ASL = base.GetCurrentAltitude_ASL(false);
			}
			return currentAltitude_ASL;
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x0002851D File Offset: 0x0002671D
		public override void SetAltitude_ASL(bool DoSanityCheck, float value)
		{
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				this.GetGroupLead().SetAltitude_ASL(false, value);
			}
			else
			{
				base.SetAltitude_ASL(false, value);
			}
		}

		// Token: 0x06005959 RID: 22873 RVA: 0x0027866C File Offset: 0x0027686C
		public override Side GetSide(bool SetSideOnly = false)
		{
			if (Information.IsNothing(this.m_Side))
			{
				this.m_Side = this.GetUnitsInGroup().Values.ElementAtOrDefault(0).GetSide(false);
			}
			return this.m_Side;
		}

		// Token: 0x0600595A RID: 22874 RVA: 0x002786B0 File Offset: 0x002768B0
		public override void SetSide(bool SetSideOnly, Side value)
		{
			bool flag = value != this.m_Side;
			base.SetSide(false, value);
			if (flag && !Information.IsNothing(value))
			{
				List<ActiveUnit> list = this.GetUnitsInGroup().Values.ToList<ActiveUnit>();
				using (List<ActiveUnit>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.SetSide(false, value);
					}
				}
			}
		}

		// Token: 0x0600595B RID: 22875 RVA: 0x00278730 File Offset: 0x00276930
		public override float GetCurrentHeading()
		{
			float currentHeading;
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				currentHeading = this.GetGroupLead().GetCurrentHeading();
			}
			else
			{
				currentHeading = base.GetCurrentHeading();
			}
			return currentHeading;
		}

		// Token: 0x0600595C RID: 22876 RVA: 0x00028543 File Offset: 0x00026743
		public override void SetCurrentHeading(float float_20)
		{
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				this.GetGroupLead().SetCurrentHeading(float_20);
			}
			else
			{
				base.SetCurrentHeading(float_20);
			}
		}

		// Token: 0x0600595D RID: 22877 RVA: 0x00278768 File Offset: 0x00276968
		public override float GetCurrentSpeed()
		{
			float currentSpeed;
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				currentSpeed = this.GetGroupLead().GetCurrentSpeed();
			}
			else
			{
				currentSpeed = base.GetCurrentSpeed();
			}
			return currentSpeed;
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x00028567 File Offset: 0x00026767
		public override void SetCurrentSpeed(float float_20)
		{
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				this.GetGroupLead().SetCurrentSpeed(float_20);
			}
			else
			{
				base.SetCurrentSpeed(float_20);
			}
		}

		// Token: 0x0600595F RID: 22879 RVA: 0x002787A0 File Offset: 0x002769A0
		public override ActiveUnit.Throttle GetMaxThrottleAvailable()
		{
			return this.GetGroupLead().GetMaxThrottleAvailable();
		}

		// Token: 0x06005960 RID: 22880 RVA: 0x002787BC File Offset: 0x002769BC
		public bool HasFixedFacility()
		{
			List<ActiveUnit> list = this.GetUnitsInGroup().Values.ToList<ActiveUnit>();
			bool result;
			foreach (ActiveUnit current in list)
			{
				if (!Information.IsNothing(current) && current.IsFixedFacility())
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06005961 RID: 22881 RVA: 0x00278830 File Offset: 0x00276A30
		private bool HasAirBase()
		{
			checked
			{
				bool result;
				foreach (ActiveUnit current in this.GetUnitsInGroup().Values)
				{
					if (!Information.IsNothing(current.GetAirFacilities()))
					{
						AirFacility[] airFacilities = current.GetAirFacilities();
						for (int i = 0; i < airFacilities.Length; i++)
						{
							if (airFacilities[i].GetAirFacilityType() == AirFacility._AirFacilityType.Runway && current.IsFixedFacility())
							{
								result = true;
								return result;
							}
						}
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x06005962 RID: 22882 RVA: 0x002788CC File Offset: 0x00276ACC
		private bool HasFixedDockFacilities()
		{
			bool result;
			foreach (ActiveUnit current in this.GetUnitsInGroup().Values)
			{
				if (!Information.IsNothing(current.GetDockFacilities()) && current.IsFixedFacility() && current.GetDockFacilities().Length > 0)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06005963 RID: 22883 RVA: 0x0027894C File Offset: 0x00276B4C
		public Group.GroupType GetGroupType()
		{
			Group.GroupType value;
			if (this.groupType.HasValue)
			{
				value = this.groupType.Value;
			}
			else
			{
				this.groupType = new Group.GroupType?(this.method_135());
				value = this.groupType.Value;
			}
			return value;
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x00278998 File Offset: 0x00276B98
		public string GetGroupTypeString()
		{
			string result;
			switch (this.GetGroupType())
			{
			case Group.GroupType.AirGroup:
				result = "Air Group";
				break;
			case Group.GroupType.SurfaceGroup:
				result = "Surface Group";
				break;
			case Group.GroupType.SubGroup:
				result = "Underwater Group";
				break;
			case Group.GroupType.Installation:
				result = "Land Installation";
				break;
			case Group.GroupType.MobileGroup:
				result = "Mobile Group";
				break;
			case Group.GroupType.AirBase:
				result = "Airfield";
				break;
			case Group.GroupType.NavalBase:
				result = "Naval Base";
				break;
			default:
				throw new NotImplementedException();
			}
			return result;
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x00278A14 File Offset: 0x00276C14
		public override Mission GetAssignedMission(bool SetMissionOnly = false)
		{
			Mission result;
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				result = this.GetGroupLead().GetAssignedMission(false);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06005966 RID: 22886 RVA: 0x00278A44 File Offset: 0x00276C44
		public override void DeleteMission(bool SetMissionOnly, Mission value)
		{
			using (IEnumerator<ActiveUnit> enumerator = this.GetUnitsInGroup().Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.DeleteMission(SetMissionOnly, value);
				}
			}
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x00278A9C File Offset: 0x00276C9C
		public override Mission GetAssignedTaskPool()
		{
			Mission result;
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				result = this.GetGroupLead().GetAssignedTaskPool();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06005968 RID: 22888 RVA: 0x00278ACC File Offset: 0x00276CCC
		public override void SetAssignedTaskPool(Mission mission_2)
		{
			using (IEnumerator<ActiveUnit> enumerator = this.GetUnitsInGroup().Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.SetAssignedTaskPool(mission_2);
				}
			}
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x00278B20 File Offset: 0x00276D20
		public override ActiveUnit_Navigator GetNavigator()
		{
			return this.group_Navigator;
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x00278B38 File Offset: 0x00276D38
		public override ActiveUnit_AI GetAI()
		{
			return this.group_AI;
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x00278B50 File Offset: 0x00276D50
		public Group_Kinematics GetGroupKinematics()
		{
			if (Information.IsNothing(this.group_Kinematics))
			{
				ActiveUnit activeUnit = this;
				this.group_Kinematics = new Group_Kinematics(ref activeUnit);
			}
			return this.group_Kinematics;
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x00278B84 File Offset: 0x00276D84
		public override ActiveUnit_Sensory GetSensory()
		{
			return this.group_Sensory;
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x00278B9C File Offset: 0x00276D9C
		public override ActiveUnit_Weaponry GetWeaponry()
		{
			return this.group_Weaponry;
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x00278BB4 File Offset: 0x00276DB4
		public override ActiveUnit_CommStuff GetCommStuff()
		{
			return this.group_CommStuff;
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x00278BCC File Offset: 0x00276DCC
		public override ActiveUnit_AirOps GetAirOps()
		{
			return this.group_AirOps;
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x00278BE4 File Offset: 0x00276DE4
		public ActiveUnit_Damage method_133()
		{
			if (Information.IsNothing(this.m_Damage))
			{
				ActiveUnit activeUnit = this;
				this.m_Damage = new ActiveUnit_Damage(ref activeUnit);
			}
			return this.m_Damage;
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x00278C18 File Offset: 0x00276E18
		public ActiveUnit GetGroupLead()
		{
			if (Information.IsNothing(this.GroupLead))
			{
				this.SetGroupLead();
			}
			return this.GroupLead;
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x00278C44 File Offset: 0x00276E44
		public override float GetDesiredHeading(ActiveUnit._TurnRate enum0_1)
		{
			if (Information.IsNothing(this.GetGroupLead()))
			{
				this.SetGroupLead();
			}
			float result;
			if (Information.IsNothing(this.GetGroupLead()))
			{
				result = 0f;
			}
			else
			{
				result = this.GetGroupLead().GetDesiredHeading(enum0_1);
			}
			return result;
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x0002858B File Offset: 0x0002678B
		public override void SetDesiredHeading(ActiveUnit._TurnRate enum0_1, float float_20)
		{
			if (Information.IsNothing(this.GetGroupLead()))
			{
				this.SetGroupLead();
			}
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				this.GetGroupLead().SetDesiredHeading(enum0_1, float_20);
			}
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x00278C98 File Offset: 0x00276E98
		public override float GetDesiredAltitude()
		{
			if (Information.IsNothing(this.GetGroupLead()))
			{
				this.SetGroupLead();
			}
			float result;
			if (Information.IsNothing(this.GetGroupLead()))
			{
				result = 0f;
			}
			else
			{
				result = this.GetGroupLead().GetDesiredAltitude();
			}
			return result;
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x00278CE8 File Offset: 0x00276EE8
		public override void SetDesiredAltitude(float float_20)
		{
			try
			{
				if (Information.IsNothing(this.GetGroupLead()))
				{
					this.SetGroupLead();
				}
				if (!Information.IsNothing(this.GetGroupLead()))
				{
					this.GetGroupLead().SetDesiredAltitude(float_20);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100591", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x00278D74 File Offset: 0x00276F74
		public override float GetDesiredAltitude_TerrainFollowing()
		{
			if (Information.IsNothing(this.GetGroupLead()))
			{
				this.SetGroupLead();
			}
			float result;
			if (Information.IsNothing(this.GetGroupLead()))
			{
				result = 0f;
			}
			else
			{
				result = this.GetGroupLead().GetDesiredAltitude_TerrainFollowing();
			}
			return result;
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x00278DC4 File Offset: 0x00276FC4
		public override void SetDesiredAltitude_TerrainFollowing(float float_20)
		{
			try
			{
				if (Information.IsNothing(this.GetGroupLead()))
				{
					this.SetGroupLead();
				}
				if (!Information.IsNothing(this.GetGroupLead()))
				{
					this.GetGroupLead().SetDesiredAltitude_TerrainFollowing(float_20);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101257", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x000285BD File Offset: 0x000267BD
		public override bool IsTerrainFollowing(ActiveUnit activeUnit_1)
		{
			return this.GetGroupType() == Group.GroupType.AirGroup && !Information.IsNothing(this.GetGroupLead()) && this.GetGroupLead().IsTerrainFollowing(this.GetGroupLead());
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x000285E8 File Offset: 0x000267E8
		public override void SetIsTerrainFollowing(ActiveUnit activeUnit_1, bool bool_18)
		{
			if (this.GetGroupType() == Group.GroupType.AirGroup && !Information.IsNothing(this.GetGroupLead()))
			{
				this.GetGroupLead().SetIsTerrainFollowing(this.GetGroupLead(), bool_18);
			}
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x00278E50 File Offset: 0x00277050
		public override float GetDesiredSpeed()
		{
			if (Information.IsNothing(this.GetGroupLead()))
			{
				this.SetGroupLead();
			}
			float result;
			if (Information.IsNothing(this.GetGroupLead()))
			{
				result = 0f;
			}
			else
			{
				result = this.GetGroupLead().GetDesiredSpeed();
			}
			return result;
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x00028614 File Offset: 0x00026814
		public override void SetDesiredSpeed(float float_20)
		{
			if (Information.IsNothing(this.GetGroupLead()))
			{
				this.SetGroupLead();
			}
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				this.GetGroupLead().SetDesiredSpeed(float_20);
			}
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x00278EA0 File Offset: 0x002770A0
		public override ActiveUnit._TurnRate GetDesiredTurnRate()
		{
			if (Information.IsNothing(this.GetGroupLead()))
			{
				this.SetGroupLead();
			}
			ActiveUnit._TurnRate result;
			if (Information.IsNothing(this.GetGroupLead()))
			{
				result = ActiveUnit._TurnRate.const_0;
			}
			else
			{
				result = this.GetGroupLead().GetDesiredTurnRate();
			}
			return result;
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x00028645 File Offset: 0x00026845
		public override void SetDesiredTurnRate(ActiveUnit._TurnRate enum0_1)
		{
			if (Information.IsNothing(this.GetGroupLead()))
			{
				this.SetGroupLead();
			}
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				this.GetGroupLead().SetDesiredTurnRate(enum0_1);
			}
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x00278EE8 File Offset: 0x002770E8
		public override Waypoint._TurnRate GetDesiredTurnRate_Navigation()
		{
			if (Information.IsNothing(this.GetGroupLead()))
			{
				this.SetGroupLead();
			}
			Waypoint._TurnRate result;
			if (Information.IsNothing(this.GetGroupLead()))
			{
				result = Waypoint._TurnRate.Standard;
			}
			else
			{
				result = this.GetGroupLead().GetDesiredTurnRate_Navigation();
			}
			return result;
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x00028676 File Offset: 0x00026876
		public override void SetDesiredTurnRate_Navigation(Waypoint._TurnRate enum51_1)
		{
			if (Information.IsNothing(this.GetGroupLead()))
			{
				this.SetGroupLead();
			}
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				this.GetGroupLead().SetDesiredTurnRate_Navigation(enum51_1);
			}
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x00278F30 File Offset: 0x00277130
		public override AirFacility[] GetAirFacilities()
		{
			AirFacility[] result;
			try
			{
				int num = 0;
				foreach (ActiveUnit current in this.GetUnitsInGroup().Values)
				{
					num += current.GetAirFacilities().Length;
				}
				AirFacility[] array = new AirFacility[num - 1 + 1];
				num = 0;
				using (IEnumerator<ActiveUnit> enumerator2 = this.GetUnitsInGroup().Values.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						AirFacility[] airFacilities = enumerator2.Current.GetAirFacilities();
						for (int i = 0; i < airFacilities.Length; i = checked(i + 1))
						{
							AirFacility airFacility = airFacilities[i];
							array[num] = airFacility;
							num++;
						}
					}
				}
				result = array;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100592", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new AirFacility[0];
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x00279068 File Offset: 0x00277268
		public override DockFacility[] GetDockFacilities()
		{
			checked
			{
				DockFacility[] result;
				try
				{
					LinkedList<DockFacility> linkedList = new LinkedList<DockFacility>();
					using (IEnumerator<ActiveUnit> enumerator = this.GetUnitsInGroup().Values.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							DockFacility[] dockFacilities = enumerator.Current.GetDockFacilities();
							for (int i = 0; i < dockFacilities.Length; i++)
							{
								DockFacility value = dockFacilities[i];
								linkedList.AddLast(value);
							}
						}
					}
					result = linkedList.ToArray<DockFacility>();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100593", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new DockFacility[0];
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x00279148 File Offset: 0x00277348
		public override Magazine[] GetMagazines()
		{
			Magazine[] result;
			try
			{
				Group.GroupType groupType = this.GetGroupType();
				if (groupType - Group.GroupType.Installation <= 3)
				{
					List<Magazine> list = new List<Magazine>();
					checked
					{
						using (IEnumerator<ActiveUnit> enumerator = this.GetUnitsInGroup().Values.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Magazine[] magazines = ((Platform)enumerator.Current).m_Magazines;
								for (int i = 0; i < magazines.Length; i++)
								{
									Magazine item = magazines[i];
									list.Add(item);
								}
							}
						}
						result = list.ToArray();
					}
				}
				else
				{
					result = null;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100594", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x00279240 File Offset: 0x00277440
		public override Sensor[] GetNoneMCMSensors()
		{
			Sensor[] array = new Sensor[0];
			Sensor[] result;
			try
			{
				foreach (ActiveUnit current in this.GetUnitsInGroup().Values)
				{
					if (!Information.IsNothing(current))
					{
						Sensor[] allNoneMCMSensors = current.GetAllNoneMCMSensors();
						if (!Information.IsNothing(allNoneMCMSensors))
						{
							array = ScenarioArrayUtil.smethod_29(ref array, ref allNoneMCMSensors);
						}
					}
				}
				result = array;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100595", "");
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

		// Token: 0x06005984 RID: 22916 RVA: 0x00279314 File Offset: 0x00277514
		public override ActiveUnit.Throttle GetThrottle()
		{
			ActiveUnit.Throttle currentThrottle;
			if (this.GetGroupType() == Group.GroupType.AirGroup)
			{
				if (this.currentThrottle == ActiveUnit.Throttle.FullStop)
				{
					this.SetThrottle(ActiveUnit.Throttle.Cruise, null);
				}
				currentThrottle = this.currentThrottle;
			}
			else
			{
				currentThrottle = this.currentThrottle;
			}
			return currentThrottle;
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x00279360 File Offset: 0x00277560
		private Group.GroupType method_135()
		{
			Group.GroupType groupType;
			Group.GroupType result;
			try
			{
				if (this.GetUnitsInGroup().Count == 0)
				{
					groupType = Group.GroupType.AirGroup;
				}
				else if (this.HasFixedFacility() && this.HasFixedDockFacilities())
				{
					groupType = Group.GroupType.NavalBase;
				}
				else if (this.HasAirBase())
				{
					groupType = Group.GroupType.AirBase;
				}
				else if (this.HasFixedFacility())
				{
					groupType = Group.GroupType.Installation;
				}
				else
				{
					for (int i = this.GetUnitsInGroup().Count - 1; i >= 0; i += -1)
					{
						ActiveUnit activeUnit = this.GetUnitsInGroup().Values.ElementAtOrDefault(i);
						if (!Information.IsNothing(activeUnit) && activeUnit.IsShip)
						{
							groupType = Group.GroupType.SurfaceGroup;
							result = Group.GroupType.SurfaceGroup;
							return result;
						}
					}
					for (int j = this.GetUnitsInGroup().Count - 1; j >= 0; j += -1)
					{
						ActiveUnit activeUnit = this.GetUnitsInGroup().Values.ElementAtOrDefault(j);
						if (!Information.IsNothing(activeUnit) && activeUnit.IsSubmarine)
						{
							groupType = Group.GroupType.SubGroup;
							result = Group.GroupType.SubGroup;
							return result;
						}
					}
					for (int k = this.GetUnitsInGroup().Count - 1; k >= 0; k += -1)
					{
						ActiveUnit activeUnit = this.GetUnitsInGroup().Values.ElementAtOrDefault(k);
						if (!Information.IsNothing(activeUnit) && activeUnit.IsAircraft)
						{
							groupType = Group.GroupType.AirGroup;
							result = Group.GroupType.AirGroup;
							return result;
						}
					}
					groupType = Group.GroupType.MobileGroup;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100596", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				groupType = Group.GroupType.SurfaceGroup;
				ProjectData.ClearProjectError();
			}
			result = groupType;
			return result;
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x0027951C File Offset: 0x0027771C
		public Group(ref Scenario theScen, ref Side theSide, List<ActiveUnit> SelectedUnits, bool UsingStrikePlanner = false, string theGUID = null, Mission theMission = null) : base(ref theScen, theGUID)
		{
			this.groupCenter = new GeoPoint();
			this.SetPatrols(new ObservableCollection<Patrol>());
			ActiveUnit activeUnit = this;
			this.group_Navigator = new Group_Navigator(ref activeUnit);
			activeUnit = this;
			this.group_AI = new Group_AI(ref activeUnit);
			activeUnit = this;
			this.group_Sensory = new Group_Sensory(ref activeUnit);
			activeUnit = this;
			this.group_Weaponry = new Group_Weaponry(ref activeUnit);
			activeUnit = this;
			this.group_CommStuff = new Group_CommStuff(ref activeUnit);
			activeUnit = this;
			this.group_AirOps = new Group_AirOps(ref activeUnit);
			this.SetUnitsInGroup(new ObservableDictionary<string, ActiveUnit>());
			this.IsGroup = true;
			try
			{
				this.m_Scenario = theScen;
				theScen.UnitsAutoIncrement++;
				this.SetSide(false, theSide);
				if (!Information.IsNothing(SelectedUnits))
				{
					foreach (ActiveUnit current in SelectedUnits)
					{
						if (!current.IsShip || !((Ship)current).IsDestroyed())
						{
							current.SetParentGroup(UsingStrikePlanner, this);
						}
					}
				}
				this.SetGroupLead();
				this.GetGroupKinematics().method_19();
				if (!Information.IsNothing(this.GetGroupLead()))
				{
					this.SetDesiredSpeed(this.GetGroupLead().GetDesiredSpeed());
					this.SetDesiredHeading(this.GetGroupLead().GetDesiredTurnRate(), this.GetGroupLead().GetDesiredHeading(ActiveUnit._TurnRate.const_0));
					this.SetDesiredAltitude(this.GetGroupLead().GetDesiredAltitude());
					this.SetThrottle(this.GetGroupLead().GetThrottle(), null);
				}
				HashSet<Mission> hashSet = new HashSet<Mission>();
				HashSet<Mission.Flight> hashSet2 = new HashSet<Mission.Flight>();
				foreach (ActiveUnit current2 in this.GetUnitsInGroup().Values)
				{
					if (!Information.IsNothing(current2.GetAssignedMission(false)))
					{
						hashSet.Add(current2.GetAssignedMission(false));
						if (!Information.IsNothing(current2.GetNavigator().GetFlight()))
						{
							hashSet2.Add(current2.GetNavigator().GetFlight());
						}
					}
				}
				bool flag = false;
				if (hashSet.Count == 1)
				{
					this.DeleteMission(false, hashSet.ElementAtOrDefault(0));
					if (hashSet2.Count > 0 && hashSet.ElementAtOrDefault(0).HasFlights())
					{
						foreach (Mission.Flight current3 in hashSet.ElementAtOrDefault(0).FlightList)
						{
							foreach (Mission.Flight current4 in hashSet2)
							{
								if (current3 == current4)
								{
									flag = true;
									break;
								}
							}
							if (flag)
							{
								break;
							}
						}
					}
				}
				if (!flag)
				{
					using (IEnumerator<ActiveUnit> enumerator5 = this.GetUnitsInGroup().Values.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							enumerator5.Current.GetNavigator().vmethod_3();
						}
					}
				}
				foreach (ActiveUnit current5 in this.GetUnitsInGroup().Values)
				{
					if (!Information.IsNothing(current5.GetAssignedMission(false)))
					{
						hashSet.Add(current5.GetAssignedMission(false));
					}
				}
				bool flag2 = false;
				string text = null;
				if (!Information.IsNothing(SelectedUnits))
				{
					foreach (ActiveUnit current6 in SelectedUnits)
					{
						if (current6.IsAircraft && string.IsNullOrEmpty(text))
						{
							flag2 = true;
							if (current6.GetNavigator().HasFlight())
							{
								text = current6.GetNavigator().GetFlight().Callsign;
							}
						}
					}
				}
				if (flag2)
				{
					if (!string.IsNullOrEmpty(text))
					{
						this.Name = "Flight " + text;
					}
					else
					{
						this.Name = "Flight " + Conversions.ToString(theScen.UnitsAutoIncrement);
					}
				}
				else
				{
					this.Name = "Group " + Conversions.ToString(theScen.UnitsAutoIncrement);
				}
				activeUnit = this;
				GameGeneral.AddActiveUnit(ref activeUnit, ref theScen);
				theScen.Groups.Add(this);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100597", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x00279A78 File Offset: 0x00277C78
		internal void SetGroupLead()
		{
			try
			{
				this.groupType = new Group.GroupType?(this.method_135());
				if (this.GetUnitsInGroup().Count == 1)
				{
					this.SetGroupLead(this.GetUnitsInGroup().Values.ElementAtOrDefault(0));
				}
				else if (this.GetGroupType() != Group.GroupType.AirBase && this.GetGroupType() != Group.GroupType.Installation && this.GetGroupType() != Group.GroupType.MobileGroup && this.GetGroupType() != Group.GroupType.NavalBase)
				{
					double num = 0.0;
					ActiveUnit groupLead = null;
					foreach (ActiveUnit current in this.GetUnitsInGroup().Values)
					{
						if ((double)current.WeightEmpty > num)
						{
							groupLead = current;
							num = (double)current.WeightEmpty;
						}
					}
					this.SetGroupLead(groupLead);
				}
				else
				{
					this.SetGroupLead(this.GetUnitsInGroup().Values.ElementAtOrDefault(0));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100598", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005988 RID: 22920 RVA: 0x000286A7 File Offset: 0x000268A7
		internal void SetAsGroupLead(ActiveUnit activeUnit_)
		{
			this.SetGroupLead(activeUnit_);
		}

		// Token: 0x06005989 RID: 22921 RVA: 0x00279BC8 File Offset: 0x00277DC8
		public override void SetHomeBase(ActiveUnit activeUnit_)
		{
			bool flag = !activeUnit_.IsGroup;
			bool flag2 = false;
			bool flag3 = false;
			if (activeUnit_.IsGroup)
			{
				if (((Group)activeUnit_).GetGroupType() == Group.GroupType.AirBase)
				{
					flag3 = true;
				}
				else
				{
					flag2 = true;
				}
			}
			if (flag || flag3)
			{
				short num = (short)this.GetUnitsInGroup().Count;
				short num2 = 0;
				foreach (ActiveUnit current in this.GetUnitsInGroup().Values)
				{
					bool flag4;
					if (current.IsAircraft)
					{
						if (flag4 = (Operators.CompareString(((Aircraft)current).GetAircraftAirOps().CheckHostCondition(activeUnit_), "OK", false) == 0))
						{
							((Aircraft)current).GetAircraftAirOps().SetAssignedHostUnit(false, activeUnit_);
						}
					}
					else if (flag4 = (Operators.CompareString(current.GetDockingOps().method_42(activeUnit_), "OK", false) == 0))
					{
						current.GetDockingOps().SetAssignedHostUnit(false, activeUnit_);
					}
					if (flag4)
					{
						num2 += 1;
					}
				}
				if (this.GetGroupType() == Group.GroupType.AirGroup)
				{
					if (num2 == num)
					{
						this.m_Scenario.LogMessage("All units in group now have " + activeUnit_.Name + " as their home base.", LoggedMessage.MessageType.AirOps, 5, base.GetGuid(), this.GetSide(false), null);
					}
					else if (num2 == 0)
					{
						this.m_Scenario.LogMessage("No units in group have switched to " + activeUnit_.Name + " as their home base.", LoggedMessage.MessageType.AirOps, 5, base.GetGuid(), this.GetSide(false), null);
					}
					else
					{
						this.m_Scenario.LogMessage(string.Concat(new string[]
						{
							"Partial success: Only ",
							Conversions.ToString((int)num2),
							" out of ",
							Conversions.ToString((int)num),
							" units in this group have switched to ",
							activeUnit_.Name,
							" as their home base."
						}), LoggedMessage.MessageType.AirOps, 5, base.GetGuid(), this.GetSide(false), null);
					}
				}
				else if (num2 == num)
				{
					this.m_Scenario.LogMessage("All units in group now have " + activeUnit_.Name + " as their home base.", LoggedMessage.MessageType.DockingOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
				else if (num2 == 0)
				{
					this.m_Scenario.LogMessage("No units in group have switched to " + activeUnit_.Name + " as their home base.", LoggedMessage.MessageType.DockingOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
				else
				{
					this.m_Scenario.LogMessage(string.Concat(new string[]
					{
						"Partial success: Only ",
						Conversions.ToString((int)num2),
						" out of ",
						Conversions.ToString((int)num),
						" units in this group have switched to ",
						activeUnit_.Name,
						" as their home base."
					}), LoggedMessage.MessageType.DockingOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
			}
			if (flag2)
			{
				short num3 = (short)this.GetUnitsInGroup().Count;
				short num4 = 0;
				foreach (ActiveUnit current2 in this.GetUnitsInGroup().Values)
				{
					foreach (ActiveUnit current3 in ((Group)activeUnit_).GetUnitsInGroup().Values)
					{
						bool flag5;
						if (current2.IsAircraft)
						{
							if (flag5 = (Operators.CompareString(((Aircraft)current2).GetAircraftAirOps().CheckHostCondition(current3), "OK", false) == 0))
							{
								((Aircraft)current2).GetAircraftAirOps().SetAssignedHostUnit(false, current3);
							}
						}
						else if (flag5 = (Operators.CompareString(current2.GetDockingOps().method_42(current3), "OK", false) == 0))
						{
							current2.GetDockingOps().SetAssignedHostUnit(false, current3);
						}
						if (flag5)
						{
							num4 += 1;
						}
					}
				}
				if (this.GetGroupType() == Group.GroupType.AirGroup)
				{
					if (num4 == num3)
					{
						this.m_Scenario.LogMessage("All units in group now have " + activeUnit_.Name + " as their home base.", LoggedMessage.MessageType.AirOps, 5, base.GetGuid(), this.GetSide(false), null);
					}
					else if (num4 == 0)
					{
						this.m_Scenario.LogMessage("No units in group have switched to " + activeUnit_.Name + " as their home base.", LoggedMessage.MessageType.AirOps, 5, base.GetGuid(), this.GetSide(false), null);
					}
					else
					{
						this.m_Scenario.LogMessage(string.Concat(new string[]
						{
							"Partial success: Only ",
							Conversions.ToString((int)num4),
							" out of ",
							Conversions.ToString((int)num3),
							" units in this group have switched to  units in group: ",
							activeUnit_.Name,
							" as their home base."
						}), LoggedMessage.MessageType.AirOps, 5, base.GetGuid(), this.GetSide(false), null);
					}
				}
				else if (num4 == num3)
				{
					this.m_Scenario.LogMessage("All units in group now have various units in group " + activeUnit_.Name + " as their home base.", LoggedMessage.MessageType.DockingOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
				else if (num4 == 0)
				{
					this.m_Scenario.LogMessage("No units in group have switched to " + activeUnit_.Name + " as their home base.", LoggedMessage.MessageType.DockingOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
				else
				{
					this.m_Scenario.LogMessage(string.Concat(new string[]
					{
						"Partial success: Only ",
						Conversions.ToString((int)num4),
						" out of ",
						Conversions.ToString((int)num3),
						" units in this group have switched to units in group: ",
						activeUnit_.Name,
						" as their home base."
					}), LoggedMessage.MessageType.DockingOps, 5, base.GetGuid(), this.GetSide(false), null);
				}
			}
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x0027A220 File Offset: 0x00278420
		public override bool IsOperating()
		{
			Group.GroupType groupType = this.GetGroupType();
			return groupType > Group.GroupType.SubGroup || (!Information.IsNothing(this.GetGroupLead()) && this.GetGroupLead().IsOperating());
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x0027A258 File Offset: 0x00278458
		public bool method_138()
		{
			bool result = false;
			try
			{
				bool flag = false;
				if (this.GetGroupType() != Group.GroupType.AirBase || this.GetGroupType() == Group.GroupType.Installation)
				{
					if (this.GetGroupType() == Group.GroupType.SurfaceGroup || this.GetGroupType() == Group.GroupType.MobileGroup)
					{
						foreach (ActiveUnit current in this.GetUnitsInGroup().Values)
						{
							if (!current.IsAircraft && !current.IsOperating())
							{
								flag = true;
								break;
							}
						}
					}
					if (this.GetGroupType() == Group.GroupType.AirGroup)
					{
						using (IEnumerator<ActiveUnit> enumerator2 = this.GetUnitsInGroup().Values.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (!enumerator2.Current.IsOperating())
								{
									flag = true;
									break;
								}
							}
						}
					}
				}
				result = flag;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100599", "");
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

		// Token: 0x0600598C RID: 22924 RVA: 0x0027A3A8 File Offset: 0x002785A8
		public override void SetThrottle(ActiveUnit.Throttle ThrottleSetting, float? SpecificDesiredSpeed = null)
		{
			if (!Information.IsNothing(this.GetGroupLead()))
			{
				if (Information.IsNothing(SpecificDesiredSpeed))
				{
					this.GetGroupLead().SetDesiredSpeed((float)this.GetGroupKinematics().method_20(ThrottleSetting));
				}
				else
				{
					this.GetGroupLead().SetDesiredSpeed(SpecificDesiredSpeed.Value);
				}
				this.currentThrottle = ThrottleSetting;
				this.GetGroupLead().SetThrottle(ThrottleSetting, SpecificDesiredSpeed);
			}
		}

		// Token: 0x0600598D RID: 22925 RVA: 0x0027A414 File Offset: 0x00278614
		public List<Unit> GetUnitListInGroup()
		{
			return this.GetUnitsInGroup().Values.Select(Group.ActiveUnitFunc).ToList<Unit>();
		}

		// Token: 0x0600598E RID: 22926 RVA: 0x0027A440 File Offset: 0x00278640
		public override void SetGeoLocation(ref Scenario scenario_, double Longitude, double Latitude)
		{
			try
			{
				this.GetGroupLead().SetLatitude(null, Latitude);
				this.GetGroupLead().SetLongitude(null, Longitude);
				if (this.GetNavigator().HasPlottedCourse())
				{
					this.SetCurrentHeading(base.AzimuthTo(this.GetNavigator().GetPlottedCourse()[0].GetLatitude(), this.GetNavigator().GetPlottedCourse()[0].GetLongitude()));
				}
				foreach (ActiveUnit current in this.GetUnitsInGroup().Values)
				{
					if (!current.IsGroupLead())
					{
						ActiveUnit_Navigator.FormationStation formationStation = current.GetNavigator().GetFormationStation();
						current.SetLongitude(null, formationStation.GetLongitude(current, this.GetGroupLead()));
						current.SetLatitude(null, formationStation.GetLatitude(current, this.GetGroupLead()));
						current.SetCurrentHeading(this.GetCurrentHeading());
					}
				}
				this.SetLatitude(null, Latitude);
				this.SetLongitude(null, Longitude);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100600", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x0027A5D8 File Offset: 0x002787D8
		public void SetGroupLead(ActiveUnit activeUnit_)
		{
			this.GroupLead = activeUnit_;
			if (!Information.IsNothing(this.GroupLead))
			{
				this.SetLatitude(null, this.GroupLead.GetLatitude(null));
				this.SetLongitude(null, this.GroupLead.GetLongitude(null));
			}
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x0027A640 File Offset: 0x00278840
		public override void DestroyUnit(bool ScenEditAction, bool IsAimpointFacility, bool DestroyUnitNow = false)
		{
			checked
			{
				try
				{
					this.m_Scenario.Groups.Remove(this);
					List<ActiveUnit> list = new List<ActiveUnit>();
					list.AddRange(this.GetUnitsInGroup().Values);
					foreach (ActiveUnit current in list)
					{
						current.SetParentGroup(false, null);
						current.GetNavigator().ClearPlottedCourse();
						Waypoint[] plottedCourse = this.GetNavigator().GetPlottedCourse();
						for (int i = 0; i < plottedCourse.Length; i++)
						{
							Waypoint waypoint_ = plottedCourse[i];
							current.GetNavigator().AddWaypoint(waypoint_);
						}
					}
					base.DestroyUnit(ScenEditAction, IsAimpointFacility, DestroyUnitNow);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100601", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x0027A750 File Offset: 0x00278950
		private void method_141(ActiveUnit activeUnit_1)
		{
			this.groupType = null;
			if (!this.bool_17)
			{
				this.SetGroupLead();
			}
			Group.Delegate14 @delegate = Group.delegate14_0;
			if (@delegate != null)
			{
				@delegate(this, activeUnit_1);
			}
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x0027A78C File Offset: 0x0027898C
		private void method_142(ActiveUnit activeUnit_1)
		{
			this.groupType = null;
			try
			{
				if (!this.bool_17 && this.GetGroupLead() == activeUnit_1)
				{
					this.SetGroupLead();
				}
				if (this.GetUnitsInGroup().Count < 1)
				{
					this.m_Scenario.RemoveUnit(this);
					if (!string.IsNullOrEmpty(this.Name))
					{
						base.LogMessage(this.Name + "已经没有作战单元; 自行解体...", LoggedMessage.MessageType.UI, 5, true, new GeoPoint(0.0, 0.0));
					}
					GameGeneral.RemoveUnit(ref this.m_Scenario, base.GetGuid());
				}
				Group.Delegate15 @delegate = Group.delegate15_0;
				if (@delegate != null)
				{
					@delegate(this, activeUnit_1);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100602", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005993 RID: 22931 RVA: 0x0027A894 File Offset: 0x00278A94
		private void UnitsInGroupDictionary_DictionaryChanged(object sender, NotifyDictionaryChangedEventArgs<string, ActiveUnit> e)
		{
			NotifyCollectionChangedAction action = e.Action;
			if (action == NotifyCollectionChangedAction.Add)
			{
				this.method_141(e.NewItem.Value);
			}
			else if (action == NotifyCollectionChangedAction.Remove)
			{
				this.method_142(e.OldItem.Value);
			}
		}

		// Token: 0x06005994 RID: 22932 RVA: 0x000286B0 File Offset: 0x000268B0
		private void PatrolCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.GetSide(false).ClearPatrolMissions();
		}

		// Token: 0x06005995 RID: 22933 RVA: 0x0027A8E4 File Offset: 0x00278AE4
		public override bool vmethod_41(double double_2, double double_3, ref byte byte_0, bool bool_18, ref bool bool_19, bool bool_20, ref bool bool_21, float? nullable_15, short? nullable_16, ref List<ActiveUnit> list_3, float float_20, bool bool_22, bool bool_23)
		{
			return !Information.IsNothing(this.GetGroupLead()) && this.GetGroupLead().IsActiveUnit() && this.GetGroupLead().vmethod_41(double_2, double_3, ref byte_0, bool_18, ref bool_19, bool_20, ref bool_21, nullable_15, nullable_16, ref list_3, float_20, bool_22, bool_23);
		}

		// Token: 0x04002C75 RID: 11381
		public static Func<ActiveUnit, Unit> ActiveUnitFunc = (ActiveUnit activeUnit_0) => activeUnit_0;

		// Token: 0x04002C76 RID: 11382
		private Group.GroupType? groupType;

		// Token: 0x04002C77 RID: 11383
		public GeoPoint groupCenter;

		// Token: 0x04002C78 RID: 11384
		private ActiveUnit GroupLead;

		// Token: 0x04002C79 RID: 11385
		[CompilerGenerated]
		private ObservableCollection<Patrol> PatrolCollection;

		// Token: 0x04002C7A RID: 11386
		private Group_Navigator group_Navigator;

		// Token: 0x04002C7B RID: 11387
		private Group_AI group_AI;

		// Token: 0x04002C7C RID: 11388
		private Group_Kinematics group_Kinematics;

		// Token: 0x04002C7D RID: 11389
		private Group_Sensory group_Sensory;

		// Token: 0x04002C7E RID: 11390
		private Group_Weaponry group_Weaponry;

		// Token: 0x04002C7F RID: 11391
		private Group_CommStuff group_CommStuff;

		// Token: 0x04002C80 RID: 11392
		private Group_AirOps group_AirOps;

		// Token: 0x04002C81 RID: 11393
		[CompilerGenerated]
		private ObservableDictionary<string, ActiveUnit> UnitsInGroupDictionary;

		// Token: 0x04002C82 RID: 11394
		internal bool bool_17;

		// Token: 0x04002C83 RID: 11395
		[CompilerGenerated]
		private static Group.Delegate14 delegate14_0;

		// Token: 0x04002C84 RID: 11396
		[CompilerGenerated]
		private static Group.Delegate15 delegate15_0;

		// Token: 0x02000AE7 RID: 2791
		// (Invoke) Token: 0x06005999 RID: 22937
		public delegate void Delegate14(Group theGroup, ActiveUnit theUnit);

		// Token: 0x02000AE8 RID: 2792
		// (Invoke) Token: 0x0600599D RID: 22941
		public delegate void Delegate15(Group theGroup, ActiveUnit theUnit);

		// Token: 0x02000AE9 RID: 2793
		public enum GroupType : byte
		{
			// Token: 0x04002C87 RID: 11399
			AirGroup,
			// Token: 0x04002C88 RID: 11400
			SurfaceGroup,
			// Token: 0x04002C89 RID: 11401
			SubGroup,
			// Token: 0x04002C8A RID: 11402
			Installation,
			// Token: 0x04002C8B RID: 11403
			MobileGroup,
			// Token: 0x04002C8C RID: 11404
			AirBase,
			// Token: 0x04002C8D RID: 11405
			NavalBase
		}
	}
}

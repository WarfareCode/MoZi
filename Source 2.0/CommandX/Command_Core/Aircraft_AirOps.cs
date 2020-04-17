using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 0x020009E7 RID: 2535
	public sealed class Aircraft_AirOps : ActiveUnit_AirOps
	{
		// Token: 0x06004BCA RID: 19402 RVA: 0x001D9008 File Offset: 0x001D7208
		internal static double method_2(ActiveUnit activeUnit_0)
		{
			double num = 0.0;
			double num2 = 0.0;
			return activeUnit_0.GetFuelLeft(ref num, ref num2, false);
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x001D9038 File Offset: 0x001D7238
		[CompilerGenerated]
		public static void smethod_1(Aircraft_AirOps.Delegate6 delegate6_1)
		{
			Aircraft_AirOps.Delegate6 @delegate = Aircraft_AirOps.delegate6_0;
			Aircraft_AirOps.Delegate6 delegate2;
			do
			{
				delegate2 = @delegate;
				Aircraft_AirOps.Delegate6 value = (Aircraft_AirOps.Delegate6)Delegate.Combine(delegate2, delegate6_1);
				@delegate = Interlocked.CompareExchange<Aircraft_AirOps.Delegate6>(ref Aircraft_AirOps.delegate6_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x001D9070 File Offset: 0x001D7270
		[CompilerGenerated]
		public static void smethod_2(Aircraft_AirOps.Delegate6 delegate6_1)
		{
			Aircraft_AirOps.Delegate6 @delegate = Aircraft_AirOps.delegate6_0;
			Aircraft_AirOps.Delegate6 delegate2;
			do
			{
				delegate2 = @delegate;
				Aircraft_AirOps.Delegate6 value = (Aircraft_AirOps.Delegate6)Delegate.Remove(delegate2, delegate6_1);
				@delegate = Interlocked.CompareExchange<Aircraft_AirOps.Delegate6>(ref Aircraft_AirOps.delegate6_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06004BCD RID: 19405 RVA: 0x001D90A8 File Offset: 0x001D72A8
		[CompilerGenerated]
		public static void smethod_3(Aircraft_AirOps.Delegate7 delegate7_1)
		{
			Aircraft_AirOps.Delegate7 @delegate = Aircraft_AirOps.delegate7_0;
			Aircraft_AirOps.Delegate7 delegate2;
			do
			{
				delegate2 = @delegate;
				Aircraft_AirOps.Delegate7 value = (Aircraft_AirOps.Delegate7)Delegate.Combine(delegate2, delegate7_1);
				@delegate = Interlocked.CompareExchange<Aircraft_AirOps.Delegate7>(ref Aircraft_AirOps.delegate7_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x001D90E0 File Offset: 0x001D72E0
		[CompilerGenerated]
		public static void smethod_4(Aircraft_AirOps.Delegate7 delegate7_1)
		{
			Aircraft_AirOps.Delegate7 @delegate = Aircraft_AirOps.delegate7_0;
			Aircraft_AirOps.Delegate7 delegate2;
			do
			{
				delegate2 = @delegate;
				Aircraft_AirOps.Delegate7 value = (Aircraft_AirOps.Delegate7)Delegate.Remove(delegate2, delegate7_1);
				@delegate = Interlocked.CompareExchange<Aircraft_AirOps.Delegate7>(ref Aircraft_AirOps.delegate7_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x001D9118 File Offset: 0x001D7318
		private Aircraft GetAircraft()
		{
			if (Information.IsNothing(this.theAircraft))
			{
				this.theAircraft = (Aircraft)this.theUnit;
			}
			return this.theAircraft;
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x001D9150 File Offset: 0x001D7350
		public ConcurrentDictionary<string, Aircraft_AirOps._RefuellingConnection> GetA2ARCDictionary()
		{
			return this.lazyA2ARefuelingConnectionDictionary.Value;
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x001D916C File Offset: 0x001D736C
		public ConcurrentBag<string> GetRefuellingQueue()
		{
			return this.RefuellingQueue.Value;
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x001D9188 File Offset: 0x001D7388
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("AirOps");
					xmlWriter_0.WriteStartElement("LQ");
					Aircraft[] landingQueue = this.LandingQueue;
					for (int i = 0; i < landingQueue.Length; i++)
					{
						landingQueue[i].Save(ref xmlWriter_0, ref hashSet_0);
					}
					xmlWriter_0.WriteEndElement();
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Con";
					int airOpsCondition = (int)this.AirOpsCondition;
					xmlWriter.WriteElementString(localName, airOpsCondition.ToString());
					xmlWriter_0.WriteElementString("CT", XmlConvert.ToString(this.GetConditionTimer()));
					if (!Information.IsNothing(this.GetHostAirFacility()))
					{
						xmlWriter_0.WriteElementString("HAF", this.GetHostAirFacility().GetGuid());
					}
					if (!Information.IsNothing(this.GetCurrentHostUnit()))
					{
						xmlWriter_0.WriteElementString("CHU", this.GetCurrentHostUnit().GetGuid());
					}
					if (!Information.IsNothing(this.GetAssignedHostUnit(false)))
					{
						xmlWriter_0.WriteElementString("AHU", this.AssignedHostUnit.GetGuid());
					}
					if (!Information.IsNothing(this.GetA2ARefuelingDestinationAircraft()))
					{
						xmlWriter_0.WriteElementString("A2ARD", this.GetA2ARefuelingDestinationAircraft().GetGuid());
					}
					if (this.GetRefuellingQueue().Count > 0)
					{
						xmlWriter_0.WriteStartElement("RQ");
						foreach (string current in this.GetRefuellingQueue())
						{
							xmlWriter_0.WriteElementString("ID", current);
						}
						xmlWriter_0.WriteEndElement();
					}
					if (this.GetA2ARCDictionary().Count > 0)
					{
						xmlWriter_0.WriteStartElement("A2ARC");
						foreach (KeyValuePair<string, Aircraft_AirOps._RefuellingConnection> current2 in this.GetA2ARCDictionary())
						{
							if (Information.IsNothing(current2.Key))
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
							}
							else
							{
								xmlWriter_0.WriteElementString("Conn", current2.Key + "_" + Conversions.ToString((int)current2.Value));
							}
						}
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteElementString("A2AR_NumberOfReceiverHookups", this.A2AR_NumberOfReceiverHookups.ToString());
					xmlWriter_0.WriteElementString("QuickTurnaround_Enabled", this.QuickTurnaround_Enabled.ToString());
					xmlWriter_0.WriteElementString("QuickTurnaround_SortiesFlown", this.QuickTurnaround_SortiesFlown.ToString());
					xmlWriter_0.WriteElementString("QuickTurnaround_SortiesTotal", this.QuickTurnaround_SortiesTotal.ToString());
					xmlWriter_0.WriteElementString("QuickTurnaround_TimePentalty", this.QuickTurnaround_TimePentalty.ToString());
					xmlWriter_0.WriteElementString("QuickTurnaround_AirborneTime_Flown", this.QuickTurnaround_AirborneTime_Flown.ToString());
					xmlWriter_0.WriteElementString("QuickTurnaround_AirborneTime_SortieAverage", this.QuickTurnaround_AirborneTime_SortieAverage.ToString());
					xmlWriter_0.WriteEndElement();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100404", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x001D94E4 File Offset: 0x001D76E4
		public static Aircraft_AirOps smethod_5(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_3)
		{
			Aircraft_AirOps result = null;
			try
			{
				Aircraft_AirOps aircraft_AirOps = new Aircraft_AirOps(ref activeUnit_3);
				aircraft_AirOps.theUnit = activeUnit_3;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1812259564u)
						{
							if (num <= 1259866850u)
							{
								if (num <= 597234316u)
								{
									if (num != 1179485u)
									{
										if (num != 312808761u)
										{
											if (num != 597234316u)
											{
												continue;
											}
											if (Operators.CompareString(name, "HAF", false) != 0)
											{
												continue;
											}
											goto IL_7BD;
										}
										else
										{
											if (Operators.CompareString(name, "QuickTurnaround_AirborneTime_Flown", false) == 0)
											{
												aircraft_AirOps.QuickTurnaround_AirborneTime_Flown = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "QuickTurnaround_TimePentalty", false) == 0)
										{
											aircraft_AirOps.QuickTurnaround_TimePentalty = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 836103370u)
								{
									if (num != 1014590895u)
									{
										if (num == 1259866850u && Operators.CompareString(name, "A2AR_NumberOfReceiverHookups", false) == 0)
										{
											aircraft_AirOps.A2AR_NumberOfReceiverHookups = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "RefuellingQueue", false) != 0)
										{
											continue;
										}
										goto IL_334;
									}
								}
								else if (Operators.CompareString(name, "CurrentHostUnit", false) != 0)
								{
									continue;
								}
							}
							else if (num <= 1324455984u)
							{
								if (num != 1264355206u)
								{
									if (num != 1281343745u)
									{
										if (num == 1324455984u && Operators.CompareString(name, "QuickTurnaround_SortiesTotal", false) == 0)
										{
											aircraft_AirOps.QuickTurnaround_SortiesTotal = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else if (Operators.CompareString(name, "CHU", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "A2AR_Destination", false) != 0)
									{
										continue;
									}
									goto IL_58D;
								}
							}
							else
							{
								if (num == 1394108651u)
								{
									goto IL_38E;
								}
								if (num == 1792671826u)
								{
									if (Operators.CompareString(name, "CT", false) != 0)
									{
										continue;
									}
									goto IL_400;
								}
								else
								{
									if (num == 1812259564u && Operators.CompareString(name, "RQ", false) == 0)
									{
										goto IL_334;
									}
									continue;
								}
							}
							if (string.IsNullOrEmpty(xmlNode.ChildNodes[0].InnerXml))
							{
								aircraft_AirOps.ParentAircraftID = xmlNode.InnerXml;
								continue;
							}
							XmlNode xmlNode2 = xmlNode.ChildNodes[0];
							ActiveUnit activeUnit = ActiveUnit.Load(ref xmlNode2, ref dictionary_0, ref activeUnit_3.m_Scenario);
							if (!activeUnit_3.m_Scenario.GetActiveUnits().ContainsKey(activeUnit.GetGuid()))
							{
								activeUnit_3.m_Scenario.GetActiveUnits().Add(activeUnit.GetGuid(), activeUnit);
							}
							if (!activeUnit.GetAirFacilities().Contains(aircraft_AirOps.GetHostAirFacility()))
							{
								activeUnit.GetAirOps().method_18((Aircraft)activeUnit_3, false);
								continue;
							}
							continue;
							IL_334:
							IEnumerator enumerator2 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									XmlNode xmlNode3 = (XmlNode)enumerator2.Current;
									aircraft_AirOps.GetRefuellingQueue().Add(xmlNode3.InnerText);
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
							IL_38E:
							if (Operators.CompareString(name, "Con", false) != 0)
							{
								continue;
							}
							goto IL_706;
						}
						else
						{
							if (num <= 2760552332u)
							{
								if (num <= 2263481407u)
								{
									if (num != 1852486619u)
									{
										if (num != 2011325326u)
										{
											if (num == 2263481407u && Operators.CompareString(name, "ConditionTimer", false) == 0)
											{
												goto IL_400;
											}
											continue;
										}
										else if (Operators.CompareString(name, "LQ", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "AHU", false) != 0)
										{
											continue;
										}
										goto IL_6A0;
									}
								}
								else if (num != 2508349683u)
								{
									if (num != 2563465583u)
									{
										if (num == 2760552332u && Operators.CompareString(name, "QuickTurnaround_SortiesFlown", false) == 0)
										{
											aircraft_AirOps.QuickTurnaround_SortiesFlown = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "A2AR_Connections", false) != 0)
										{
											continue;
										}
										goto IL_5B3;
									}
								}
								else if (Operators.CompareString(name, "LandingQueue", false) != 0)
								{
									continue;
								}
								int num2 = xmlNode.ChildNodes.Count - 1;
								for (int i = 0; i <= num2; i++)
								{
									ScenarioArrayUtil.AddStringToArray(ref aircraft_AirOps.aircraftsToLanding, xmlNode.ChildNodes[i].InnerText);
								}
								continue;
							}
							if (num > 3225512471u)
							{
								goto IL_661;
							}
							if (num == 2851748968u)
							{
								if (Operators.CompareString(name, "QuickTurnaround_Enabled", false) == 0)
								{
									aircraft_AirOps.QuickTurnaround_Enabled = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else if (num != 3175179614u)
							{
								if (num == 3225512471u && Operators.CompareString(name, "A2ARD", false) == 0)
								{
									goto IL_58D;
								}
								continue;
							}
							else if (Operators.CompareString(name, "A2ARC", false) != 0)
							{
								continue;
							}
							IL_5B3:
							IEnumerator enumerator3 = xmlNode.ChildNodes.GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									string[] array = ((XmlNode)enumerator3.Current).InnerText.Split(new char[]
									{
										'_'
									});
									if (!Information.IsNothing(array[0]) && Operators.CompareString(array[0], "", false) != 0)
									{
										aircraft_AirOps.GetA2ARCDictionary().TryAdd(array[0], (Aircraft_AirOps._RefuellingConnection)Conversions.ToByte(array[1]));
									}
									else if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
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
							IL_661:
							if (num <= 3440622149u)
							{
								if (num != 3433242718u)
								{
									if (num != 3440622149u || Operators.CompareString(name, "AssignedHostUnit", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "Condition", false) == 0)
									{
										goto IL_706;
									}
									continue;
								}
							}
							else if (num != 3998375324u)
							{
								if (num == 4021522466u && Operators.CompareString(name, "QuickTurnaround_AirborneTime_SortieAverage", false) == 0)
								{
									aircraft_AirOps.QuickTurnaround_AirborneTime_SortieAverage = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "HostAirFacility", false) == 0)
								{
									goto IL_7BD;
								}
								continue;
							}
							IL_6A0:
							if (xmlNode.FirstChild.HasChildNodes)
							{
								XmlNode xmlNode2 = xmlNode.ChildNodes[0];
								ActiveUnit value = ActiveUnit.Load(ref xmlNode2, ref dictionary_0, ref activeUnit_3.m_Scenario);
								aircraft_AirOps.SetAssignedHostUnit(false, value);
								continue;
							}
							aircraft_AirOps.string_3 = xmlNode.InnerText;
							continue;
						}
						IL_400:
						aircraft_AirOps.SetConditionTimer(XmlConvert.ToSingle(xmlNode.InnerText));
						continue;
						IL_58D:
						aircraft_AirOps.A2AR_Destination = xmlNode.InnerText;
						continue;
						IL_706:
						if (Versioned.IsNumeric(xmlNode.InnerText))
						{
							aircraft_AirOps.SetAirOpsCondition((Aircraft_AirOps._AirOpsCondition)Conversions.ToByte(xmlNode.InnerText));
							continue;
						}
						aircraft_AirOps.SetAirOpsCondition((Aircraft_AirOps._AirOpsCondition)Enum.Parse(typeof(Aircraft_AirOps._AirOpsCondition), xmlNode.InnerText, true));
						continue;
						IL_7BD:
						if (!string.IsNullOrEmpty(xmlNode.ChildNodes[0].InnerXml))
						{
							Aircraft_AirOps aircraft_AirOps2 = aircraft_AirOps;
							XmlNode xmlNode2 = xmlNode.ChildNodes[0];
							aircraft_AirOps2.SetHostAirFacility(AirFacility.Load(ref xmlNode2, ref dictionary_0, ref activeUnit_3.m_Scenario));
							aircraft_AirOps.HostAirFacilityID = Misc.smethod_48(xmlNode.ChildNodes[0].ChildNodes, "ID").InnerText;
						}
						else
						{
							aircraft_AirOps.HostAirFacilityID = xmlNode.InnerText;
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
				result = aircraft_AirOps;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100405", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x001D9DF8 File Offset: 0x001D7FF8
		public ActiveUnit GetAssignedHostUnit()
		{
			ActiveUnit result = null;
			try
			{
				Mission assignedMission = this.theUnit.GetAssignedMission(false);
				if (Information.IsNothing(assignedMission))
				{
					result = this.GetAssignedHostUnit(true);
				}
				else if (assignedMission.MissionClass != Mission._MissionClass.Ferry)
				{
					result = this.GetAssignedHostUnit(true);
				}
				else if (Information.IsNothing(((FerryMission)assignedMission).GetDestinationHost(this.theUnit.m_Scenario)))
				{
					string text = "";
					if (Operators.CompareString(this.theUnit.Name, this.theUnit.UnitClass, false) != 0)
					{
						text = " (" + this.theUnit.UnitClass + ")";
					}
					this.theUnit.LogMessage(string.Concat(new string[]
					{
						this.theUnit.Name,
						text,
						"不能继续执行转场任务: ",
						assignedMission.Name,
						" (转场目的地似已消失). 作战单元从此任务中移除。"
					}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.theUnit.GetLongitude(null), this.theUnit.GetLatitude(null)));
					this.theUnit.DeleteMission(false, null);
					result = this.GetAssignedHostUnit(true);
				}
				else
				{
					switch (((FerryMission)assignedMission).GetFerryMissionBehavior())
					{
					case FerryMission.FerryMissionBehavior.OneWay:
					{
						ActiveUnit destinationHost = ((FerryMission)assignedMission).GetDestinationHost(this.theUnit.m_Scenario);
						if (Operators.CompareString(this.CheckHostCondition(destinationHost), "OK", false) == 0)
						{
							result = destinationHost;
						}
						else
						{
							result = null;
						}
						break;
					}
					case FerryMission.FerryMissionBehavior.Cycle:
						if (this.theUnit.GetAI().IsFerryCycleLegIsOutbound())
						{
							ActiveUnit destinationHost2 = ((FerryMission)assignedMission).GetDestinationHost(this.theUnit.m_Scenario);
							if (Operators.CompareString(this.CheckHostCondition(destinationHost2), "OK", false) == 0)
							{
								result = destinationHost2;
							}
							else
							{
								result = null;
							}
						}
						else
						{
							result = this.GetAssignedHostUnit(true);
						}
						break;
					case FerryMission.FerryMissionBehavior.Random:
						result = this.GetAssignedHostUnit(true);
						break;
					default:
						result = this.GetAssignedHostUnit(true);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100406", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004BD5 RID: 19413 RVA: 0x001DA068 File Offset: 0x001D8268
		public bool method_24()
		{
			Aircraft_AirOps._AirOpsCondition airOpsCondition = this.GetAirOpsCondition();
			bool result;
			if (airOpsCondition != Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff && airOpsCondition != Aircraft_AirOps._AirOpsCondition.TakingOff)
			{
				switch (airOpsCondition)
				{
				case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit:
					result = this.GetHostAirFacility().IsHangarOrOpenParking();
					return result;
				case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway:
				case Aircraft_AirOps._AirOpsCondition.PreparingToLaunch:
					goto IL_46;
				}
				result = false;
				return result;
			}
			IL_46:
			result = true;
			return result;
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x001DA0C0 File Offset: 0x001D82C0
		public int method_25(ActiveUnit Receiver_, bool bInRefuellingQueue_)
		{
			int result = 0;
			try
			{
				List<string> list = this.GetRefuellingQueue().ToList<string>();
                string currentX;

                foreach (string current in list)
				{
					Aircraft aircraft = (Aircraft)this.GetAircraft().m_Scenario.GetActiveUnits()[current];
					if (Information.IsNothing(aircraft) || aircraft.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
					{
                        currentX = current;
                        this.GetRefuellingQueue().TryTake(out currentX);
					}
				}
				list = this.GetRefuellingQueue().ToList<string>();
				if (!Information.IsNothing(Receiver_) && list.Contains(Receiver_.GetGuid()))
				{
					list.Remove(Receiver_.GetGuid());
				}
				int num = 0;
				foreach (string current2 in list)
				{
					Aircraft aircraft2 = (Aircraft)this.GetAircraft().m_Scenario.GetActiveUnits()[current2];
					if (!aircraft2.IsNotActive())
					{
						if (bInRefuellingQueue_)
						{
							num += (int)Math.Round((double)aircraft2.GetFuelRecsMaxQuantity() * 0.1);
						}
						else
						{
							num += aircraft2.GetFuelRecsMaxQuantity();
						}
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100407", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x001DA29C File Offset: 0x001D849C
		public Aircraft GetA2ARefuelingDestinationAircraft()
		{
			return this.A2ARefuelingDestinationAircraft;
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x001DA2B4 File Offset: 0x001D84B4
		public void method_27(Aircraft aircraft_)
		{
			try
			{
				if (aircraft_ != this.A2ARefuelingDestinationAircraft && !Information.IsNothing(this.A2ARefuelingDestinationAircraft) && !Information.IsNothing(this.A2ARefuelingDestinationAircraft.GetAircraftAirOps()))
				{
					try
					{
						ConcurrentBag<string> refuellingQueue = this.A2ARefuelingDestinationAircraft.GetAircraftAirOps().GetRefuellingQueue();
						string guid = this.GetAircraft().GetGuid();
						refuellingQueue.TryTake(out guid);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200020", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
				}
				this.A2ARefuelingDestinationAircraft = aircraft_;
				if (!Information.IsNothing(aircraft_) && !this.A2ARefuelingDestinationAircraft.GetAircraftAirOps().GetRefuellingQueue().Contains(this.GetAircraft().GetGuid()))
				{
					this.A2ARefuelingDestinationAircraft.GetAircraftAirOps().GetRefuellingQueue().Add(this.GetAircraft().GetGuid());
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 100408", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x001DA404 File Offset: 0x001D8604
		public string CheckHostCondition(ActiveUnit AssignedHostUnit_)
		{
			string result = "";
			try
			{
				if (AssignedHostUnit_.IsGroup && !AssignedHostUnit_.HasRunwaysOrLandingPads())
				{
					result = "所选编组没有找到机场跑道或者降落场";
				}
				else if (AssignedHostUnit_.GetAirOps().CanBeHostedOnAirFacility(this.GetAircraft()))
				{
					if (this.CanLand(AssignedHostUnit_, true))
					{
						result = "OK";
					}
					else
					{
						result = "不能在此降落";
					}
				}
				else
				{
					result = "此飞机不能在此任意一处空军设施驻扎";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100409", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x001DA4BC File Offset: 0x001D86BC
		public void method_29(ActiveUnit AssignedHostUnit_)
		{
			Aircraft_AirOps.MeasureDistanceFromAssignedHostUnit measureDistanceFromAssignedHostUnit = new Aircraft_AirOps.MeasureDistanceFromAssignedHostUnit(null);
			measureDistanceFromAssignedHostUnit.assignedHostUnit = AssignedHostUnit_;
			Collection<ActiveUnit> collection = new Collection<ActiveUnit>();
			try
			{
				if (!Information.IsNothing(this.GetCurrentHostUnit()))
				{
					this.SetAssignedHostUnit(false, this.GetCurrentHostUnit());
				}
				else
				{
					List<ActiveUnit> list = this.theUnit.GetSide(false).ActiveUnitArray.ToList<ActiveUnit>();
					foreach (ActiveUnit current in list)
					{
						if (Operators.CompareString(this.CheckHostCondition(current), "OK", false) == 0)
						{
							collection.Add(current);
						}
					}
					if (collection.Count > 0)
					{
						this.AssignedHostUnit = collection.OrderBy(new Func<ActiveUnit, double>(measureDistanceFromAssignedHostUnit.GetAngularDistanceTo)).ElementAtOrDefault(0);
						string text = "";
						if (Operators.CompareString(this.theUnit.Name, this.theUnit.UnitClass, false) != 0)
						{
							text = " (" + this.theUnit.UnitClass + ")";
						}
						this.GetAircraft().LogMessage(string.Concat(new string[]
						{
							this.GetAircraft().Name,
							text,
							" 选择新的降落机场: ",
							this.AssignedHostUnit.Name,
							"."
						}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetAircraft().GetLongitude(null), this.GetAircraft().GetLatitude(null)));
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100410", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x001DA6CC File Offset: 0x001D88CC
		public void AssignNewHostUnit()
		{
			Collection<ActiveUnit> collection = new Collection<ActiveUnit>();
			try
			{
				if (!Information.IsNothing(this.GetCurrentHostUnit()))
				{
					this.SetAssignedHostUnit(false, this.GetCurrentHostUnit());
				}
				else
				{
					List<ActiveUnit> list = this.theUnit.GetSide(false).ActiveUnitArray.ToList<ActiveUnit>();
					foreach (ActiveUnit current in list)
					{
						if (Operators.CompareString(this.CheckHostCondition(current), "OK", false) == 0)
						{
							collection.Add(current);
						}
					}
					if (collection.Count > 0)
					{
						this.AssignedHostUnit = collection.OrderBy(new Func<ActiveUnit, double>(this.GetAngularDistance)).ElementAtOrDefault(0);
						string text = "";
						if (Operators.CompareString(this.GetAircraft().Name, this.GetAircraft().UnitClass, false) != 0)
						{
							text = " (" + this.GetAircraft().UnitClass + ")";
						}
						this.GetAircraft().LogMessage(string.Concat(new string[]
						{
							this.GetAircraft().Name,
							text,
							"选择新的降落机场: ",
							this.AssignedHostUnit.Name,
							"."
						}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetAircraft().GetLongitude(null), this.GetAircraft().GetLatitude(null)));
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100411", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x001DA8CC File Offset: 0x001D8ACC
		public void method_31(ActiveUnit excludeUnit = null)
		{
			Collection<ActiveUnit> collection = new Collection<ActiveUnit>();
			try
			{
				double num = Math2.ApproxAngularDistance((double)this.theUnit.GetKinematics().vmethod_20(true, null, null));
				List<ActiveUnit> list = this.theUnit.GetSide(false).ActiveUnitArray.ToList<ActiveUnit>();
				foreach (ActiveUnit current in list)
				{
					if (!current.IsAircraft && !current.IsGroup && current.IsOperating() && current != this.theUnit && this.theUnit.GetApproxAngularDistanceInDegrees(current) <= num && Operators.CompareString(this.CheckHostCondition(current), "OK", false) == 0)
					{
						collection.Add(current);
					}
				}
				if (!Information.IsNothing(excludeUnit) && collection.Contains(excludeUnit))
				{
					collection.Remove(excludeUnit);
				}
				if (collection.Count > 0)
				{
					int index = GameGeneral.GetRandom().Next(collection.Count);
					this.AssignedHostUnit = collection[index];
					string text = "";
					if (Operators.CompareString(this.GetAircraft().Name, this.GetAircraft().UnitClass, false) != 0)
					{
						text = " (" + this.GetAircraft().UnitClass + ")";
					}
					this.GetAircraft().LogMessage(string.Concat(new string[]
					{
						this.GetAircraft().Name,
						text,
						"选择新的降落机场: ",
						this.AssignedHostUnit.Name,
						"."
					}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetAircraft().GetLongitude(null), this.GetAircraft().GetLatitude(null)));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100412", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x001DAB34 File Offset: 0x001D8D34
		public ActiveUnit GetCurrentHostUnit()
		{
			ActiveUnit activeUnit = null;
			ActiveUnit result;
			try
			{
				if (Information.IsNothing(this.CurrentHostUnit))
				{
					if (Information.IsNothing(this.GetHostAirFacility()))
					{
						activeUnit = null;
						result = activeUnit;
						return result;
					}
					List<ActiveUnit> activeUnitList = this.GetAircraft().m_Scenario.GetActiveUnitList();
					foreach (ActiveUnit current in activeUnitList)
					{
						if (current.GetAirFacilities().Contains(this.GetHostAirFacility()))
						{
							this.CurrentHostUnit = current;
							break;
						}
					}
				}
				if (this.CurrentHostUnit.HasParentGroup())
				{
					Group.GroupType groupType = this.CurrentHostUnit.GetParentGroup(false).GetGroupType();
					if (groupType == Group.GroupType.Installation || groupType - Group.GroupType.AirBase <= 1)
					{
						this.CurrentHostUnit = this.CurrentHostUnit.GetParentGroup(false);
					}
				}
				activeUnit = this.CurrentHostUnit;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100413", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = activeUnit;
			return result;
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x00024425 File Offset: 0x00022625
		public void SetCurrentHostUnit(ActiveUnit activeUnit_)
		{
			this.CurrentHostUnit = activeUnit_;
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x001DAC78 File Offset: 0x001D8E78
		public ActiveUnit GetAssignedHostUnit(bool PickNewAssignedHost = false)
		{
			ActiveUnit result = null;
			try
			{
				if (PickNewAssignedHost && (Information.IsNothing(this.AssignedHostUnit) || this.AssignedHostUnit.IsNotActive()))
				{
					this.AssignNewHostUnit();
				}
				result = this.AssignedHostUnit;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100414", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x0002442E File Offset: 0x0002262E
		public void SetAssignedHostUnit(bool PickNewAssignedHost, ActiveUnit value)
		{
			this.AssignedHostUnit = value;
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x001DAD0C File Offset: 0x001D8F0C
		public AirFacility GetHostAirFacility()
		{
			return this.HostAirFacility;
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x001DAD24 File Offset: 0x001D8F24
		public void SetHostAirFacility(AirFacility airFacility_)
		{
			try
			{
				if (!Information.IsNothing(this.HostAirFacility))
				{
					ConcurrentDictionary<string, Aircraft> hostedAircrafts = this.HostAirFacility.GetHostedAircrafts();
					string guid = this.theUnit.GetGuid();
					Aircraft aircraft = this.GetAircraft();
					hostedAircrafts.TryRemove(guid, out aircraft);
				}
				if (!Information.IsNothing(airFacility_) && !airFacility_.GetHostedAircrafts().ContainsKey(this.theUnit.GetGuid()))
				{
					airFacility_.GetHostedAircrafts().TryAdd(this.theUnit.GetGuid(), this.GetAircraft());
				}
				bool flag = this.HostAirFacility != airFacility_;
				AirFacility hostAirFacility = this.HostAirFacility;
				this.HostAirFacility = airFacility_;
				if (flag)
				{
					if (Information.IsNothing(this.HostAirFacility))
					{
						this.SetCurrentHostUnit(null);
					}
					else
					{
						this.SetCurrentHostUnit(this.HostAirFacility.GetParentPlatform());
					}
					if (!Information.IsNothing(hostAirFacility) && !Information.IsNothing(this.HostAirFacility) && ((this.HostAirFacility.method_35() & !hostAirFacility.method_35()) || (!this.HostAirFacility.method_35() & hostAirFacility.method_35())))
					{
						bool flag2 = false;
						Side[] sides = this.GetAircraft().m_Scenario.GetSides();
						for (int i = 0; i < sides.Length; i = checked(i + 1))
						{
							Side side = sides[i];
							if (flag2)
							{
								break;
							}
							if (side != this.GetAircraft().GetSide(false) && !side.IsFriendlyToSide(this.GetAircraft().GetSide(false)) && side.GetContactObservableDictionary().ContainsKey(this.HostAirFacility.GetParentPlatform().GetGuid()))
							{
								List<ActiveUnit> list = side.ActiveUnitArray.OrderBy(new Func<ActiveUnit, double>(this.GetAngularDistanceToHostAirFacility)).ToList<ActiveUnit>();
								for (int j = list.Count - 1; j >= 0; j += -1)
								{
									ActiveUnit activeUnit = list[j];
									if (!Information.IsNothing(activeUnit))
									{
										if (flag2)
										{
											break;
										}
										if (activeUnit.IsOperating())
										{
											float slantRange = activeUnit.GetSlantRange(this.HostAirFacility.GetParentPlatform(), 0f);
											IEnumerable<Sensor> enumerable = activeUnit.GetAllNoneMCMSensors().Where(Aircraft_AirOps.SensorFunc0);
											if (enumerable.Any<Sensor>())
											{
												float num = enumerable.Select(Aircraft_AirOps.SensorFunc1).Max();
												if (num > 0f && slantRange <= num)
												{
													foreach (Sensor current in enumerable)
													{
														if (flag2)
														{
															break;
														}
														Sensor sensor = current;
														ActiveUnit parentPlatform_ = activeUnit;
														ActiveUnit parentPlatform = this.HostAirFacility.GetParentPlatform();
														List<GeoPoint> list2 = null;
														float slantRange2 = slantRange;
														Lazy<ObservableDictionary<int, EmissionContainer>> lazy = null;
														List<ActiveUnit> affectingJammers = null;
														bool? flag3 = null;
														bool? flag4 = null;
														Unit._LOS_Exists_Visual? lOS_Exists_Visual = null;
														bool? flag5 = null;
														if (sensor.SensorDetectionAttempt(Sensor.DetectionAttemptType.Recon, parentPlatform_, parentPlatform, ref list2, slantRange2, ref lazy, affectingJammers, ref flag3, ref flag4, ref lOS_Exists_Visual, ref flag5) && current.GetDetectionRange(current.GetParentPlatform(), this.GetAircraft()) * 3f >= slantRange)
														{
															flag2 = true;
															Contact contact = side.GetContactObservableDictionary()[hostAirFacility.GetParentPlatform().GetGuid()];
															Contact contact_ = side.GetContactObservableDictionary()[this.HostAirFacility.GetParentPlatform().GetGuid()];
															if (!this.HostAirFacility.method_35() & hostAirFacility.method_35())
															{
																activeUnit.GetSensory().method_29(this.GetAircraft(), contact_, current);
																Contact.HostUnitOfRadarRadiation hostUnitOfRadarRadiation = null;
																foreach (Contact.HostUnitOfRadarRadiation current2 in contact.GetRadiationHostUnits(activeUnit.GetSide(false)))
																{
																	if (Operators.CompareString(current2.UID, this.GetAircraft().GetGuid(), false) == 0)
																	{
																		hostUnitOfRadarRadiation = current2;
																		break;
																	}
																}
																if (!Information.IsNothing(hostUnitOfRadarRadiation))
																{
																	contact.GetRadiationHostUnits(activeUnit.GetSide(false)).Remove(hostUnitOfRadarRadiation);
																}
															}
															if (this.HostAirFacility.method_35() & !hostAirFacility.method_35())
															{
																Contact.HostUnitOfRadarRadiation hostUnitOfRadarRadiation2 = null;
																foreach (Contact.HostUnitOfRadarRadiation current3 in contact.GetRadiationHostUnits(activeUnit.GetSide(false)))
																{
																	if (Operators.CompareString(current3.UID, this.GetAircraft().GetGuid(), false) == 0)
																	{
																		hostUnitOfRadarRadiation2 = current3;
																		break;
																	}
																}
																if (!Information.IsNothing(hostUnitOfRadarRadiation2))
																{
																	contact.GetRadiationHostUnits(activeUnit.GetSide(false)).Remove(hostUnitOfRadarRadiation2);
																}
															}
														}
													}
												}
											}
										}
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
				ex2.Data.Add("Error at 200569", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x001DB2B0 File Offset: 0x001D94B0
		public Aircraft_AirOps._AirOpsCondition GetAirOpsCondition()
		{
			return this.AirOpsCondition;
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x00024437 File Offset: 0x00022637
		public void SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition _AirOpsCondition_1)
		{
			if (this.AirOpsCondition != _AirOpsCondition_1 && _AirOpsCondition_1 == Aircraft_AirOps._AirOpsCondition.RTB && this.AirOpsCondition == Aircraft_AirOps._AirOpsCondition.Refuelling)
			{
				this.A2ARefueling();
			}
			this.AirOpsCondition = _AirOpsCondition_1;
		}

		// Token: 0x06004BE5 RID: 19429 RVA: 0x001DB2C8 File Offset: 0x001D94C8
		public float GetConditionTimer()
		{
			return this.ConditionTimer;
		}

		// Token: 0x06004BE6 RID: 19430 RVA: 0x00024466 File Offset: 0x00022666
		public void SetConditionTimer(float float_5)
		{
			this.ConditionTimer = float_5;
		}

		// Token: 0x06004BE7 RID: 19431 RVA: 0x001DB2E0 File Offset: 0x001D94E0
		public Aircraft_AirOps(ref ActiveUnit activeUnit_3) : base(ref activeUnit_3)
		{
			this.RefuellingQueue = new Lazy<ConcurrentBag<string>>();
			this.lazyA2ARefuelingConnectionDictionary = new Lazy<ConcurrentDictionary<string, Aircraft_AirOps._RefuellingConnection>>();
			this.float_3 = 0.5f;
			this.float_4 = 2f;
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x001DB368 File Offset: 0x001D9568
		public string GetAirOpsConditionString()
		{
			string result;
			switch (this.GetAirOpsCondition())
			{
			case Aircraft_AirOps._AirOpsCondition.Airborne:
				result = "在空";
				break;
			case Aircraft_AirOps._AirOpsCondition.Parked:
				if (!Information.IsNothing(this.GetHostAirFacility()) && !Information.IsNothing(this.GetHostAirFacility().GetParentPlatform()) && this.GetHostAirFacility().GetParentPlatform().IsShip)
				{
					if (this.GetHostAirFacility().GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking)
					{
						result = "停放在飞行甲板";
						break;
					}
					if (this.GetHostAirFacility().GetAirFacilityType() == AirFacility._AirFacilityType.Hangar)
					{
						result = "停放在机库";
						break;
					}
				}
				result = "停放状态";
				break;
			case Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff:
			{
				AirFacility._AirFacilityType airFacilityType = this.GetHostAirFacility().GetAirFacilityType();
				if (airFacilityType == AirFacility._AirFacilityType.Elevator)
				{
					result = "在升级机中，前往起飞";
				}
				else
				{
					result = "正在滑行准备起飞";
				}
				break;
			}
			case Aircraft_AirOps._AirOpsCondition.TaxyingToPark:
			{
				AirFacility._AirFacilityType airFacilityType2 = this.GetHostAirFacility().GetAirFacilityType();
				if (airFacilityType2 == AirFacility._AirFacilityType.Elevator)
				{
					result = "在升级机中，前往停机位";
				}
				else
				{
					result = "正在滑行到停机位";
				}
				break;
			}
			case Aircraft_AirOps._AirOpsCondition.TakingOff:
				result = "正在起飞";
				break;
			case Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown:
				result = "最终进场";
				break;
			case Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown:
				result = "正在完成降落";
				break;
			case Aircraft_AirOps._AirOpsCondition.Readying:
				result = "正在进行出动准备";
				break;
			case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit:
				result = "等待可用的滑行道/升降机";
				break;
			case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway:
				result = "等待跑道空闲";
				break;
			case Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue:
				result = "处于降落队列中";
				break;
			case Aircraft_AirOps._AirOpsCondition.RTB:
				result = "正在返回基地";
				break;
			case Aircraft_AirOps._AirOpsCondition.PreparingToLaunch:
				result = "准备出动";
				break;
			case Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel:
				result = "机动到加油阵位";
				break;
			case Aircraft_AirOps._AirOpsCondition.Refuelling:
				result = "正在加油";
				break;
			case Aircraft_AirOps._AirOpsCondition.OffloadingFuel:
				result = "卸载燃油";
				break;
			case Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar:
				result = "部署吊放声纳";
				break;
			case Aircraft_AirOps._AirOpsCondition.EmergencyLanding:
				result = "燃油量极低准备紧急降落";
				break;
			case Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck:
			{
				AirFacility._AirFacilityType airFacilityType3 = this.GetHostAirFacility().GetAirFacilityType();
				if (airFacilityType3 == AirFacility._AirFacilityType.Elevator)
				{
					result = "在升降机中，前往飞行甲板";
				}
				else
				{
					result = "移动到飞行甲板";
				}
				break;
			}
			case Aircraft_AirOps._AirOpsCondition.BVRAttack:
				result = "正在执行超视距攻击任务";
				break;
			case Aircraft_AirOps._AirOpsCondition.BVRCrank:
				result = "Cranking";
				break;
			case Aircraft_AirOps._AirOpsCondition.Dogfight:
				result = "近距空中格斗";
				break;
			case Aircraft_AirOps._AirOpsCondition.DeployingCargo:
				result = "正在部署货物";
				break;
			default:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = this.GetAirOpsCondition().ToString();
				break;
			}
			return result;
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x001DB5CC File Offset: 0x001D97CC
		private void method_43()
		{
			if (this.theUnit.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps) && this.theUnit.GetAssignedMission(false) != null && this.theUnit.GetAssignedMission(false).IsActive() && this.theUnit.GetAssignedMission(false) is CargoMission)
			{
				CargoMission cargoMission = (CargoMission)this.theUnit.GetAssignedMission(false);
				if (this.theUnit is Aircraft)
				{
					Aircraft aircraft = (Aircraft)this.theUnit;
					if (aircraft.GetLoadout().Cargo_Type != _CargoType.NoCargo)
					{
						if (aircraft.m_OnboardCargos.Count<Cargo>() > 0)
						{
							aircraft.GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.PreparingToLaunch);
						}
						else
						{
							List<ActiveUnit> list = new List<ActiveUnit>();
							if (this.GetAssignedHostUnit(false) is Ship)
							{
								list.Add(this.GetAssignedHostUnit(false));
							}
							else if (this.GetAssignedHostUnit(false) is Facility)
							{
								list.Add(this.GetAssignedHostUnit(false));
							}
							else if (this.GetAssignedHostUnit(false) is Group)
							{
								foreach (KeyValuePair<string, ActiveUnit> current in ((Group)this.GetAssignedHostUnit(false)).GetUnitsInGroup())
								{
									list.Add(current.Value);
								}
							}
							object object_ = ActiveUnit_DockingOps.object_0;
							ObjectFlowControl.CheckForSyncLockOnValueType(object_);
							lock (object_)
							{
								foreach (ActiveUnit current2 in list)
								{
									List<Cargo> list2 = new List<Cargo>();
									double num = (double)aircraft.GetLoadout().Cargo_Mass;
									double num2 = (double)aircraft.GetLoadout().Cargo_Area;
									double num3 = (double)aircraft.GetLoadout().Cargo_Crew;
									foreach (Cargo current3 in current2.m_OnboardCargos.OrderBy(Aircraft_AirOps.CargoFunc2))
									{
										if (current3.GetCurrentType() == Cargo._CargoType.const_1)
										{
											Mount mount = (Mount)current3.GetCargo();
											if (mount.Cargo_Type <= aircraft.GetLoadout().Cargo_Type && cargoMission.dictionary_MountsToUnload.ContainsKey(mount.DBID) && cargoMission.dictionary_MountsToUnload[mount.DBID] >= 1 && (num >= (double)mount.Cargo_Mass & num2 >= (double)mount.Cargo_Area & num3 >= (double)mount.Cargo_Crew))
											{
												list2.Add(current3);
												num -= (double)mount.Cargo_Mass;
												num2 -= (double)mount.Cargo_Area;
												num3 -= (double)mount.Cargo_Crew;
												Dictionary<int, int> dictionary_MountsToUnload;
												int dBID;
												(dictionary_MountsToUnload = cargoMission.dictionary_MountsToUnload)[dBID = mount.DBID] = dictionary_MountsToUnload[dBID] - 1;
											}
										}
									}
									if (list2.Count > 0)
									{
										current2.GetDockingOps().method_53(current2, aircraft, list2);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x001DB984 File Offset: 0x001D9B84
		public void ScheduleAirOpsEvent(float elapsedTime_)
		{
			if (this.GetAircraft().IsOperating())
			{
				this.GetAircraft().AbnTime += elapsedTime_;
			}
			try
			{
				this.SetConditionTimer(this.GetConditionTimer() - elapsedTime_);
				if (this.GetConditionTimer() < 0f)
				{
					this.SetConditionTimer(0f);
				}
				checked
				{
					if (this.GetConditionTimer() == 0f)
					{
						switch (this.GetAirOpsCondition())
						{
						case Aircraft_AirOps._AirOpsCondition.Parked:
							if (!Information.IsNothing(this.GetHostAirFacility()))
							{
								if (!this.GetHostAirFacility().IsRunwayAccessPointOrElevator() && (this.GetAircraft().IsRotaryWingAircraft() || !this.GetHostAirFacility().IsTakeOffOrLandingFacility()))
								{
									if (this.GetHostAirFacility().IsTakeOffOrLandingFacility())
									{
										List<AirFacility> list = new List<AirFacility>();
										AirFacility[] airFacilities = this.GetCurrentHostUnit().GetAirFacilities();
										for (int i = 0; i < airFacilities.Length; i++)
										{
											AirFacility airFacility = airFacilities[i];
											if (airFacility.IsTakeOffOrLandingFacility())
											{
												list.Add(airFacility);
											}
										}
										if (list.Count == 1 && this.GetHostAirFacility() == list[0])
										{
											this.Landing(true, false, false);
											break;
										}
									}
									if (this.theUnit.m_Scenario.FifthMinuteIsChangingOnThisPulse)
									{
										this.Readying();
									}
									this.method_43();
								}
								else
								{
									this.Landing(true, false, false);
								}
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff:
							if (!this.method_67())
							{
								this.PreparingToLaunch();
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.TaxyingToPark:
							this.Landing(true, true, false);
							break;
						case Aircraft_AirOps._AirOpsCondition.TakingOff:
							this.TakeOff(elapsedTime_);
							break;
						case Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown:
							if (this.GetAircraft().GetHorizontalRange(this.GetAssignedHostUnit()) > 20f)
							{
								this.vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
							}
							if (this.GetAircraft().GetAircraftNavigator().method_70(elapsedTime_))
							{
								this.method_60(elapsedTime_);
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown:
							this.Landing(true, true, false);
							break;
						case Aircraft_AirOps._AirOpsCondition.Readying:
							this.Readying();
							break;
						case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit:
							if (!this.method_67())
							{
								this.PreparingToLaunch();
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway:
							if (!this.method_67())
							{
								this.PreparingToLaunch();
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue:
							this.HoldingOnLandingQueue();
							break;
						case Aircraft_AirOps._AirOpsCondition.RTB:
							if (!Information.IsNothing(this.GetHostAirFacility()) && (this.GetHostAirFacility().IsRunwayAccessPointOrElevator() || (!this.GetAircraft().IsRotaryWingAircraft() && this.GetHostAirFacility().IsTakeOffOrLandingFacility())))
							{
								this.Landing(true, true, false);
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.PreparingToLaunch:
							if (!this.method_67())
							{
								this.PreparingToLaunch();
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel:
							this.ManoeuveringToRefuel(false);
							break;
						case Aircraft_AirOps._AirOpsCondition.Refuelling:
							if (!Information.IsNothing(this.GetA2ARefuelingDestinationAircraft()) && !this.GetA2ARefuelingDestinationAircraft().IsNotActive())
							{
								if (this.GetA2ARefuelingDestinationAircraft().GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.OffloadingFuel)
								{
									this.A2ARefueling();
								}
							}
							else
							{
								this.GetAircraft().SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
								this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.OffloadingFuel:
							this.OffloadFuel(elapsedTime_);
							if (this.GetA2ARCDictionary().IsEmpty && !this.theUnit.IsRTB())
							{
								this.GetAircraft().SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
								this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar:
							if (this.theUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Unassigned && !this.theUnit.GetNavigator().HasPlottedCourse())
							{
								this.SetConditionTimer(120f);
							}
							else
							{
								this.GetAircraft().GetAircraftAI().SetDesiredAltitude();
								if (!this.theUnit.GetKinematics().GetDesiredAltitudeOverride() && this.theUnit.GetDesiredAltitude() == (float)Math.Round(45.720001220703125, 1))
								{
									ActiveUnit theUnit = this.theUnit;
									ActiveUnit_AI aI = this.theUnit.GetAI();
									Aircraft aircraft = this.GetAircraft();
									ActiveUnit theUnit2;
									ActiveUnit theUnit3;
									bool bool_ = (theUnit2 = this.theUnit).IsTerrainFollowing(theUnit3 = this.theUnit);
									float desiredAltitude = aI.method_78(ref aircraft, ActiveUnit.Throttle.Cruise, ref bool_);
									theUnit2.SetIsTerrainFollowing(theUnit3, bool_);
									theUnit.SetDesiredAltitude(desiredAltitude);
								}
								this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.EmergencyLanding:
							if (this.GetAircraft().GetAircraftNavigator().method_70(elapsedTime_))
							{
								AirFacility[] airFacilities2 = this.GetAssignedHostUnit().GetAirFacilities();
								int j = 0;
								while (j < airFacilities2.Length)
								{
									AirFacility airFacility2 = airFacilities2[j];
									if (airFacility2.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational || !airFacility2.IsHangarOrOpenParking() || !airFacility2.method_40(this.GetAircraft()))
									{
										j++;
									}
									else
									{
										this.SetHostAirFacility(airFacility2);
										if (!Information.IsNothing(this.GetHostAirFacility()))
										{
											this.method_62(null, false);
											goto IL_643;
										}
										ActiveUnit assignedHostUnit = this.GetAssignedHostUnit();
										IEnumerable<AirFacility> enumerable = this.method_61(assignedHostUnit);
										if (!Information.IsNothing(enumerable) && enumerable.Count<AirFacility>() > 0)
										{
											AirFacility[] airFacilities3 = this.GetAssignedHostUnit().GetAirFacilities();
											for (int k = 0; k < airFacilities3.Length; k++)
											{
												AirFacility airFacility3 = airFacilities3[k];
												if (airFacility3.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && airFacility3.IsHangarOrOpenParking() && airFacility3.GetAircraftSizeClass() >= this.GetAircraft().aircraftSizeClass)
												{
													this.method_62(airFacility3, false);
													break;
												}
											}
											goto IL_643;
										}
										goto IL_643;
									}
								}
								if (!Information.IsNothing(this.GetHostAirFacility()))
								{
									this.method_62(null, false);
								}
								else
								{
									ActiveUnit assignedHostUnit = this.GetAssignedHostUnit();
									IEnumerable<AirFacility> enumerable = this.method_61(assignedHostUnit);
									if (!Information.IsNothing(enumerable) && enumerable.Count<AirFacility>() > 0)
									{
										AirFacility[] airFacilities3 = this.GetAssignedHostUnit().GetAirFacilities();
										for (int k = 0; k < airFacilities3.Length; k++)
										{
											AirFacility airFacility3 = airFacilities3[k];
											if (airFacility3.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational && airFacility3.IsHangarOrOpenParking() && airFacility3.GetAircraftSizeClass() >= this.GetAircraft().aircraftSizeClass)
											{
												this.method_62(airFacility3, false);
												break;
											}
										}
									}
								}
							}
							break;
						case Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck:
							if (!this.method_67())
							{
								this.Readying();
							}
							break;
						}
					}
					IL_643:;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100416", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x001DC034 File Offset: 0x001DA234
		private float method_45(Aircraft aircraft_3, Aircraft_AirOps._RefuellingConnection? A2ARC_)
		{
			if (Information.IsNothing(A2ARC_))
			{
				A2ARC_ = new Aircraft_AirOps._RefuellingConnection?(Aircraft_AirOps._RefuellingConnection.Boom);
			}
			float result;
			if (GameGeneral.bProfessionEdition && this.GetAircraft().FuelOffloadRate > 0f)
			{
				result = this.GetAircraft().FuelOffloadRate;
			}
			else
			{
				Aircraft_AirOps._RefuellingConnection? refuellingConnection = A2ARC_;
				byte? b = refuellingConnection.HasValue ? new byte?((byte)refuellingConnection.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					if (aircraft_3.aircraftSizeClass >= GlobalVariables.AircraftSizeClass.Medium)
					{
						result = 22.6f;
					}
					else
					{
						result = 12f;
					}
				}
				else
				{
					b = (refuellingConnection.HasValue ? new byte?((byte)refuellingConnection.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						result = 11f;
					}
					else
					{
						b = (refuellingConnection.HasValue ? new byte?((byte)refuellingConnection.GetValueOrDefault()) : null);
						if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							throw new NotImplementedException();
						}
						result = 8.33f;
					}
				}
			}
			return result;
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x001DC1C4 File Offset: 0x001DA3C4
		private void OffloadFuel(float float_5)
		{
			Aircraft_AirOps.Class100 @class = new Aircraft_AirOps.Class100(null);
			List<KeyValuePair<string, Aircraft_AirOps._RefuellingConnection>> list = new List<KeyValuePair<string, Aircraft_AirOps._RefuellingConnection>>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			try
			{
				list.AddRange(this.GetA2ARCDictionary());
				foreach (KeyValuePair<string, Aircraft_AirOps._RefuellingConnection> current in list)
				{
					if (!Information.IsNothing(current.Key))
					{
						@class.aircraft_0 = (Aircraft)this.GetAircraft().m_Scenario.GetActiveUnits()[current.Key];
						if (Information.IsNothing(@class.aircraft_0))
						{
							list2.Add(current.Key);
						}
						else if (@class.aircraft_0.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Refuelling)
						{
							@class.aircraft_0.GetAircraftAirOps().A2ARefueling();
						}
						else
						{
							float num = this.method_45(@class.aircraft_0, new Aircraft_AirOps._RefuellingConnection?(current.Value)) * float_5;
							if (!Information.IsNothing(@class.aircraft_0))
							{
								if (@class.aircraft_0.HasParentGroup())
								{
									if (!list3.Contains(@class.aircraft_0.GetParentGroup(false).GetGuid()))
									{
										List<ActiveUnit> list4 = @class.aircraft_0.GetParentGroup(false).GetUnitsInGroup().Values.Where((@class.func_0 == null) ? (@class.func_0 = new Func<ActiveUnit, bool>(@class.IsCloseTo)) : @class.func_0).OrderBy(Aircraft_AirOps.ActiveUnitFunc3).ToList<ActiveUnit>();
										if (list4.Count > 0)
										{
											Aircraft aircraft = (Aircraft)list4[0];
											if (aircraft.GetMaxFuelQuantityToFill() > num)
											{
												aircraft.TransferFuel(num, FuelRec._FuelType.AviationFuel);
												this.GetAircraft().ConsumeFuel(num, FuelRec._FuelType.AviationFuel);
												this.GetAircraft().ExportFuelTransfer(aircraft, num, FuelRec._FuelType.AviationFuel);
											}
											else
											{
												@class.aircraft_0.GetAircraftAirOps().A2ARefueling();
											}
											list3.Add(@class.aircraft_0.GetParentGroup(false).GetGuid());
										}
										else
										{
											@class.aircraft_0.GetAircraftAirOps().A2ARefueling();
										}
									}
								}
								else if (@class.aircraft_0.GetMaxFuelQuantityToFill() > num)
								{
									@class.aircraft_0.TransferFuel(num, FuelRec._FuelType.AviationFuel);
									this.GetAircraft().ConsumeFuel(num, FuelRec._FuelType.AviationFuel);
									this.GetAircraft().ExportFuelTransfer(@class.aircraft_0, num, FuelRec._FuelType.AviationFuel);
								}
								else
								{
									@class.aircraft_0.GetAircraftAirOps().A2ARefueling();
								}
							}
						}
					}
				}
				if (list2.Count > 0)
				{
					foreach (string current2 in list2)
					{
						ConcurrentDictionary<string, Aircraft_AirOps._RefuellingConnection> a2ARCDictionary = this.GetA2ARCDictionary();
						string key = current2;
						Aircraft_AirOps._RefuellingConnection refuellingConnection = Aircraft_AirOps._RefuellingConnection.Probe;
						a2ARCDictionary.TryRemove(key, out refuellingConnection);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100417", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BED RID: 19437 RVA: 0x001DC53C File Offset: 0x001DA73C
		public void A2ARefueling()
		{
			try
			{
				Aircraft aircraft = null;
				if (this.GetA2ARefuelingDestinationAircraft() != null)
				{
					aircraft = this.GetA2ARefuelingDestinationAircraft();
					ConcurrentDictionary<string, Aircraft_AirOps._RefuellingConnection> a2ARCDictionary = this.GetA2ARefuelingDestinationAircraft().GetAircraftAirOps().GetA2ARCDictionary();
					string guid = this.GetAircraft().GetGuid();
					Aircraft_AirOps._RefuellingConnection refuellingConnection = Aircraft_AirOps._RefuellingConnection.Probe;
					a2ARCDictionary.TryRemove(guid, out refuellingConnection);
					this.method_27(null);
				}
				else
				{
					foreach (Aircraft current in this.GetAircraft().m_Scenario.GetActiveUnitList().OfType<Aircraft>())
					{
						if (current.GetAircraftAirOps().GetA2ARCDictionary().ContainsKey(this.GetAircraft().GetGuid()))
						{
							aircraft = current;
							ConcurrentDictionary<string, Aircraft_AirOps._RefuellingConnection> a2ARCDictionary2 = current.GetAircraftAirOps().GetA2ARCDictionary();
							string guid2 = this.GetAircraft().GetGuid();
							Aircraft_AirOps._RefuellingConnection refuellingConnection2 = Aircraft_AirOps._RefuellingConnection.Probe;
							a2ARCDictionary2.TryRemove(guid2, out refuellingConnection2);
						}
					}
				}
				bool arg_DF_0 = Debugger.IsAttached;
				if (!Information.IsNothing(aircraft))
				{
					Aircraft_AirOps aircraftAirOps = aircraft.GetAircraftAirOps();
					if (this.GetAircraft().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling)
					{
						aircraftAirOps.A2AR_NumberOfReceiverHookups++;
					}
					if (this.GetAircraft().SBR == ActiveUnit._ActiveUnitStatus.RTB && (this.GetAircraft().FuelStateBR == ActiveUnit._ActiveUnitFuelState.IsBingo || this.GetAircraft().FuelStateBR == ActiveUnit._ActiveUnitFuelState.IsJoker))
					{
						this.GetAircraft().SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
					}
					else
					{
						this.GetAircraft().SetUnitStatus(this.GetAircraft().SBR);
					}
					this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
					this.GetAircraft().SetFuelState(this.GetAircraft().GetFuelState(null));
					if (!Information.IsNothing(aircraft) && !aircraft.IsRTB() && !Information.IsNothing(aircraft.GetAssignedMission(false)) && aircraft.GetAssignedMission(false).MissionClass == Mission._MissionClass.Support)
					{
						SupportMission supportMission = (SupportMission)aircraft.GetAssignedMission(false);
						if (supportMission.A2AR_OneTankingCycleOnly && aircraftAirOps.GetRefuellingQueue().Count == 0 && aircraftAirOps.GetA2ARCDictionary().IsEmpty)
						{
							string text = "";
							if (Operators.CompareString(aircraft.Name, aircraft.UnitClass, false) != 0)
							{
								text = " (" + aircraft.UnitClass + ")";
							}
							aircraft.m_Scenario.LogMessage(string.Concat(new string[]
							{
								"Aircraft ",
								aircraft.Name,
								text,
								" is returning to base. The mission ",
								aircraft.GetAssignedMission(false).Name,
								" allows one refuelling cycle only, and the tanker queue is now empty."
							}), LoggedMessage.MessageType.AirOps, 5, aircraft.GetGuid(), aircraft.GetSide(false), new GeoPoint(aircraft.GetLongitude(null), aircraft.GetLatitude(null)));
							aircraftAirOps.vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB_MissionOver, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
						}
						if (supportMission.A2AR_MaxNumberOfReceiversPerTanker > 0 && aircraftAirOps.A2AR_NumberOfReceiverHookups >= supportMission.A2AR_MaxNumberOfReceiversPerTanker && aircraftAirOps.GetRefuellingQueue().Count == 0 && aircraftAirOps.GetA2ARCDictionary().IsEmpty)
						{
							string text2 = "";
							if (Operators.CompareString(aircraft.Name, aircraft.UnitClass, false) != 0)
							{
								text2 = " (" + aircraft.UnitClass + ")";
							}
							aircraft.m_Scenario.LogMessage(string.Concat(new string[]
							{
								"Aircraft ",
								aircraft.Name,
								text2,
								" is returning to base. The mission ",
								aircraft.GetAssignedMission(false).Name,
								" allows ",
								Conversions.ToString(supportMission.A2AR_MaxNumberOfReceiversPerTanker),
								" receivers to be served (rounded up to nearest flight), and a total of ",
								Conversions.ToString(aircraftAirOps.A2AR_NumberOfReceiverHookups),
								" refuellings have taken place."
							}), LoggedMessage.MessageType.AirOps, 5, aircraft.GetGuid(), aircraft.GetSide(false), new GeoPoint(aircraft.GetLongitude(null), aircraft.GetLatitude(null)));
							aircraftAirOps.vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB_MissionOver, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
						}
					}
					if (this.theUnit.GetAssignedMission(false) != null && this.theUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike && this.theUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne > 0 && !this.theUnit.IsNotGroupLead())
					{
						ActiveUnit aircraft2 = this.GetAircraft();
						double num = 0.0;
						double num2 = 0.0;
						if (aircraft2.GetFuelLeft(ref num, ref num2, false) < (double)this.theUnit.GetAssignedMission(false).FuelQtyToStartLookingForTanker_Airborne / 100.0)
						{
							GeoPoint intermediateTargetPoint = this.GetAircraft().GetAircraftAI().GetIntermediateTargetPoint();
							GeoPoint geoPoint_ = intermediateTargetPoint;
							bool flag = false;
							ActiveUnit activeUnit = null;
							List<Mission> list = null;
							string text3 = "";
							bool flag2 = false;
							if (this.method_78(geoPoint_, Doctrine._RefuelSelection.const_2, ref flag, ref activeUnit, ref list, ref text3, ref flag2))
							{
								return;
							}
						}
					}
					this.method_48();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100418", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x001DCAAC File Offset: 0x001DACAC
		public void method_48()
		{
			checked
			{
				if (this.theUnit.GetNavigator().GetPlottedCourse().Count<Waypoint>() > 0)
				{
					double num = 1.7976931348623157E+308;
					int num2 = 0;
					Waypoint waypoint = null;
					if (!Information.IsNothing(this.theUnit.GetAssignedMission(false)) && this.theUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike)
					{
						if (this.GetAircraft().GetAircraftNavigator().method_23() || this.GetAircraft().GetAircraftNavigator().method_22())
						{
							Waypoint[] plottedCourse = this.theUnit.GetNavigator().GetPlottedCourse();
							for (int i = 0; i < plottedCourse.Length; i++)
							{
								Waypoint waypoint2 = plottedCourse[i];
								if (waypoint2.waypointType != Waypoint.WaypointType.TurningPoint)
								{
									break;
								}
								double num3 = Math2.ApproxAngularDistance(this.theUnit.GetLatitude(null), this.theUnit.GetLongitude(null), waypoint2.GetLatitude(), waypoint2.GetLongitude());
								if (num2 == 0)
								{
									waypoint = waypoint2;
									num = num3;
								}
								else
								{
									double num4 = Math2.ApproxAngularDistance(waypoint2.GetLatitude(), waypoint2.GetLongitude(), waypoint.GetLatitude(), waypoint.GetLongitude());
									if ((num > num3 || num3 <= num4) && !this.theUnit.GetNavigator().vmethod_16(this.theUnit.GetLatitude(null), this.theUnit.GetLongitude(null), waypoint2.GetLatitude(), waypoint2.GetLongitude(), false, 0f, false, null))
									{
										waypoint = waypoint2;
										num = num3;
									}
								}
								num2 = 1;
							}
						}
					}
					else
					{
						Waypoint[] plottedCourse2 = this.theUnit.GetNavigator().GetPlottedCourse();
						for (int j = 0; j < plottedCourse2.Length; j++)
						{
							Waypoint waypoint3 = plottedCourse2[j];
							if (waypoint3.waypointType != Waypoint.WaypointType.ManualPlottedCourseWaypoint)
							{
								break;
							}
							double num3 = Math2.ApproxAngularDistance(this.theUnit.GetLatitude(null), this.theUnit.GetLongitude(null), waypoint3.GetLatitude(), waypoint3.GetLongitude());
							if (num2 == 0)
							{
								waypoint = waypoint3;
								num = num3;
							}
							else
							{
								double num4 = Math2.ApproxAngularDistance(waypoint3.GetLatitude(), waypoint3.GetLongitude(), waypoint.GetLatitude(), waypoint.GetLongitude());
								if ((num > num3 || num3 <= num4) && !this.theUnit.GetNavigator().vmethod_16(this.theUnit.GetLatitude(null), this.theUnit.GetLongitude(null), waypoint3.GetLatitude(), waypoint3.GetLongitude(), false, 0f, false, null))
								{
									waypoint = waypoint3;
									num = num3;
								}
							}
							num2 = 1;
						}
					}
					if (!Information.IsNothing(waypoint))
					{
						List<Waypoint> list = new List<Waypoint>();
						Waypoint[] plottedCourse3 = this.theUnit.GetNavigator().GetPlottedCourse();
						for (int k = 0; k < plottedCourse3.Length; k++)
						{
							Waypoint waypoint4 = plottedCourse3[k];
							if (waypoint4 == waypoint)
							{
								break;
							}
							list.Add(waypoint4);
						}
						using (List<Waypoint>.Enumerator enumerator = list.GetEnumerator())
						{
							while (enumerator.MoveNext() && enumerator.Current != waypoint)
							{
								Aircraft_Navigator aircraftNavigator = this.GetAircraft().GetAircraftNavigator();
								float num5 = 0f;
								bool flag = true;
								aircraftNavigator.vmethod_9(num5, ref flag);
							}
						}
					}
				}
			}
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x0002446F File Offset: 0x0002266F
		public void method_49(ActiveUnit activeUnit_3)
		{
			this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingOnLandingQueue);
			if (!activeUnit_3.GetAirOps().GetLandingQueue().Contains(this.GetAircraft()))
			{
				activeUnit_3.GetAirOps().HoldOnLanding(this.GetAircraft());
			}
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x001DCE50 File Offset: 0x001DB050
		public void Landing(bool NormalLandingSequence = true, bool RearmRefuel = true, bool AbortLaunch = false)
		{
			try
			{
				if (!Information.IsNothing(this.GetCurrentHostUnit()))
				{
					if (Information.IsNothing(this.GetHostAirFacility()) && !Information.IsNothing(this.GetAssignedHostUnit(false)))
					{
						this.GetAssignedHostUnit(false).GetAirOps().method_18(this.GetAircraft(), true);
					}
					if (!NormalLandingSequence)
					{
						for (int i = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; i >= 0; i += -1)
						{
							AirFacility airFacility = this.GetCurrentHostUnit().GetAirFacilities()[i];
							if (airFacility.GetAirFacilityType() == AirFacility._AirFacilityType.Hangar && airFacility.method_40(this.GetAircraft()))
							{
								this.RearmRefuelOrAbortLaunch(airFacility, RearmRefuel, AbortLaunch);
								return;
							}
						}
						for (int j = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; j >= 0; j += -1)
						{
							AirFacility airFacility = this.GetCurrentHostUnit().GetAirFacilities()[j];
							if (airFacility.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking && airFacility.method_40(this.GetAircraft()))
							{
								this.RearmRefuelOrAbortLaunch(airFacility, RearmRefuel, AbortLaunch);
								return;
							}
						}
						for (int k = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; k >= 0; k += -1)
						{
							AirFacility airFacility = this.GetCurrentHostUnit().GetAirFacilities()[k];
							if (airFacility.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking || airFacility.GetAirFacilityType() == AirFacility._AirFacilityType.Hangar)
							{
								this.RearmRefuelOrAbortLaunch(airFacility, RearmRefuel, AbortLaunch);
								return;
							}
						}
						this.SetConditionTimer(5f);
					}
					else
					{
						AirFacility._AirFacilityType airFacilityType = this.GetHostAirFacility().GetAirFacilityType();
						if (airFacilityType <= AirFacility._AirFacilityType.PadWithHaulDown)
						{
							switch (airFacilityType)
							{
							case AirFacility._AirFacilityType.Runway:
							case AirFacility._AirFacilityType.RunwayWithArrest:
							case AirFacility._AirFacilityType.AircraftCarrierCatapult:
							case AirFacility._AirFacilityType.AircraftCarrierSkiJump:
							case AirFacility._AirFacilityType.AircraftCarrierArrestingGear:
								break;
							case AirFacility._AirFacilityType.RunwayGradeTaxiway:
							case AirFacility._AirFacilityType.RunwayAccessPoint:
								goto IL_6AB;
							default:
								if (airFacilityType - AirFacility._AirFacilityType.Pad > 1)
								{
									goto IL_80E;
								}
								break;
							}
							int l = this.GetCurrentHostUnit().GetAirFacilities().Length - 1;
							bool flag = false;
							while (l >= 0)
							{
								AirFacility airFacility2 = this.GetCurrentHostUnit().GetAirFacilities()[l];
								if (airFacility2.GetAirFacilityType() != AirFacility._AirFacilityType.Hangar || !airFacility2.method_40(this.GetAircraft()))
								{
									l += -1;
									if (l != 0)
									{
										continue;
									}
								}
								else
								{
									flag = true;
								}
								if (!flag)
								{
									for (int m = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; m >= 0; m += -1)
									{
										airFacility2 = this.GetCurrentHostUnit().GetAirFacilities()[m];
										if (airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking && airFacility2.method_40(this.GetAircraft()))
										{
											this.RearmRefuelOrAbortLaunch(airFacility2, RearmRefuel, AbortLaunch);
											return;
										}
									}
									for (int n = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; n >= 0; n += -1)
									{
										airFacility2 = this.GetCurrentHostUnit().GetAirFacilities()[n];
										if (airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking || airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.Hangar)
										{
											this.RearmRefuelOrAbortLaunch(airFacility2, RearmRefuel, AbortLaunch);
											return;
										}
									}
									this.SetConditionTimer(5f);
									goto IL_80E;
								}
								if (this.GetHostAirFacility().GetParentPlatform().IsShip)
								{
									Ship._ShipCategory category = ((Ship)this.GetHostAirFacility().GetParentPlatform()).Category;
									if (category != Ship._ShipCategory.SurfaceCombatant && category != Ship._ShipCategory.SurfaceCombatant_AviationCapable && category != Ship._ShipCategory.MobileOffshoreBase_AviationCapable)
									{
										for (int num = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; num >= 0; num += -1)
										{
											airFacility2 = this.GetCurrentHostUnit().GetAirFacilities()[num];
											if (airFacility2.IsHangarOrOpenParking() && airFacility2.method_40(this.GetAircraft()))
											{
												this.RearmRefuelOrAbortLaunch(airFacility2, RearmRefuel, AbortLaunch);
												return;
											}
										}
										for (int num2 = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; num2 >= 0; num2 += -1)
										{
											airFacility2 = this.GetCurrentHostUnit().GetAirFacilities()[num2];
											if (airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking || airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.Hangar)
											{
												this.RearmRefuelOrAbortLaunch(airFacility2, RearmRefuel, AbortLaunch);
												return;
											}
										}
									}
								}
								IEnumerable<AirFacility> enumerable = base.method_1(this.GetCurrentHostUnit()).OrderBy(Aircraft_AirOps.AirFacilityFunc4);
								if (!Information.IsNothing(enumerable) && enumerable.Count<AirFacility>() > 0)
								{
									IEnumerable<AirFacility> enumerable2 = base.method_0(new bool?(false), this.GetAircraft(), this.GetCurrentHostUnit(), enumerable);
									if (!Information.IsNothing(enumerable2) && enumerable2.Count<AirFacility>() > 0)
									{
										this.method_74(enumerable2.ElementAtOrDefault(0), Aircraft_AirOps.Enum13.const_1);
										return;
									}
									for (int num3 = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; num3 >= 0; num3 += -1)
									{
										airFacility2 = this.GetCurrentHostUnit().GetAirFacilities()[num3];
										if (airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking && airFacility2.method_40(this.GetAircraft()))
										{
											this.RearmRefuelOrAbortLaunch(airFacility2, RearmRefuel, AbortLaunch);
											return;
										}
									}
									for (int num4 = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; num4 >= 0; num4 += -1)
									{
										airFacility2 = this.GetCurrentHostUnit().GetAirFacilities()[num4];
										if (airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking || airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.Hangar)
										{
											this.RearmRefuelOrAbortLaunch(airFacility2, RearmRefuel, AbortLaunch);
											return;
										}
									}
									this.SetConditionTimer(5f);
									this.GetCurrentHostUnit().GetAirOps().method_11();
									goto IL_80E;
								}
								else
								{
									if (this.GetHostAirFacility().GetParentPlatform().IsShip)
									{
										for (int num5 = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; num5 >= 0; num5 += -1)
										{
											airFacility2 = this.GetCurrentHostUnit().GetAirFacilities()[num5];
											if (airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking && airFacility2.method_40(this.GetAircraft()))
											{
												this.RearmRefuelOrAbortLaunch(airFacility2, RearmRefuel, AbortLaunch);
												return;
											}
										}
										for (int num6 = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; num6 >= 0; num6 += -1)
										{
											airFacility2 = this.GetCurrentHostUnit().GetAirFacilities()[num6];
											if (airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking || airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.Hangar)
											{
												this.RearmRefuelOrAbortLaunch(airFacility2, RearmRefuel, AbortLaunch);
												return;
											}
										}
										this.SetConditionTimer(5f);
										goto IL_80E;
									}
									goto IL_80E;
								}
							}
						}
						if (airFacilityType - AirFacility._AirFacilityType.Hangar > 1)
						{
							if (airFacilityType != AirFacility._AirFacilityType.Elevator)
							{
								goto IL_80E;
							}
						}
						else
						{
							if (!AbortLaunch)
							{
								goto IL_80E;
							}
							if (!RearmRefuel)
							{
								this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Readying);
							}
							if (!Information.IsNothing(this.theUnit.GetParentGroup(false)))
							{
								this.theUnit.SetParentGroup(false, null);
								goto IL_80E;
							}
							goto IL_80E;
						}
						IL_6AB:
						for (int num7 = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; num7 >= 0; num7 += -1)
						{
							AirFacility airFacility3 = this.GetCurrentHostUnit().GetAirFacilities()[num7];
							if (airFacility3.GetAirFacilityType() == AirFacility._AirFacilityType.Hangar && airFacility3.method_40(this.GetAircraft()))
							{
								this.RearmRefuelOrAbortLaunch(airFacility3, RearmRefuel, AbortLaunch);
								return;
							}
						}
						for (int num8 = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; num8 >= 0; num8 += -1)
						{
							AirFacility airFacility3 = this.GetCurrentHostUnit().GetAirFacilities()[num8];
							if (airFacility3.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking && airFacility3.method_40(this.GetAircraft()))
							{
								this.RearmRefuelOrAbortLaunch(airFacility3, RearmRefuel, AbortLaunch);
								return;
							}
						}
						for (int num9 = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; num9 >= 0; num9 += -1)
						{
							AirFacility airFacility3 = this.GetCurrentHostUnit().GetAirFacilities()[num9];
							if (airFacility3.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking || airFacility3.GetAirFacilityType() == AirFacility._AirFacilityType.Hangar)
							{
								this.RearmRefuelOrAbortLaunch(airFacility3, RearmRefuel, AbortLaunch);
								return;
							}
						}
						this.SetConditionTimer(5f);
					}
				}
				IL_80E:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101191", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x000244A2 File Offset: 0x000226A2
		public void AddToQuickTurnaroundSorties(ref Aircraft aircraft_)
		{
			if (aircraft_.GetAircraftAirOps().QuickTurnaround_Enabled)
			{
				this.QuickTurnaround_SortiesFlown++;
			}
			else
			{
				this.QuickTurnaround_SortiesFlown = 0;
			}
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x000244CC File Offset: 0x000226CC
		public void AddToQuickTurnaroundAirborneTimeFlown(ref Aircraft aircraft_)
		{
			this.QuickTurnaround_AirborneTime_Flown += aircraft_.AbnTime;
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x001DD6CC File Offset: 0x001DB8CC
		public void method_53(ref Aircraft_AirOps aircraft_AirOps_0, ref Aircraft aircraft_3)
		{
			if (!Information.IsNothing(aircraft_3.GetLoadout()) && aircraft_AirOps_0.GetConditionTimer() < (float)(aircraft_AirOps_0.QuickTurnaround_TimePentalty * 60))
			{
				aircraft_AirOps_0.SetConditionTimer((float)(aircraft_AirOps_0.QuickTurnaround_TimePentalty * 60));
			}
			aircraft_AirOps_0.QuickTurnaround_SortiesFlown = 0;
			aircraft_AirOps_0.QuickTurnaround_TimePentalty = 0;
			aircraft_AirOps_0.QuickTurnaround_AirborneTime_Flown = 0f;
			aircraft_AirOps_0.QuickTurnaround_AirborneTime_SortieAverage = 0f;
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x001DD740 File Offset: 0x001DB940
		public void method_54(ref Aircraft_AirOps aircraft_AirOps_0, ref Aircraft aircraft_3)
		{
			if (!Information.IsNothing(aircraft_3.GetLoadout()))
			{
				aircraft_AirOps_0.SetConditionTimer((float)(aircraft_3.GetLoadout().QT_ReadyTime * 60));
			}
			aircraft_AirOps_0.QuickTurnaround_AirborneTime_SortieAverage = aircraft_AirOps_0.QuickTurnaround_AirborneTime_Flown / (float)aircraft_AirOps_0.QuickTurnaround_SortiesFlown;
			if (float.IsNaN(aircraft_AirOps_0.QuickTurnaround_AirborneTime_SortieAverage))
			{
				aircraft_AirOps_0.QuickTurnaround_AirborneTime_SortieAverage = 0f;
			}
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x000244E2 File Offset: 0x000226E2
		public void method_55(ref Aircraft_AirOps aircraft_AirOps_0)
		{
			if (aircraft_AirOps_0.QuickTurnaround_Enabled)
			{
				aircraft_AirOps_0.QuickTurnaround_Enabled = false;
				aircraft_AirOps_0.QuickTurnaround_SortiesFlown = 0;
				aircraft_AirOps_0.QuickTurnaround_TimePentalty = 0;
				aircraft_AirOps_0.QuickTurnaround_AirborneTime_Flown = 0f;
				aircraft_AirOps_0.QuickTurnaround_AirborneTime_SortieAverage = 0f;
			}
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x001DD7A8 File Offset: 0x001DB9A8
		public void Readying()
		{
			try
			{
				if (!Information.IsNothing(this.GetHostAirFacility()) && !Information.IsNothing(this.GetHostAirFacility().GetParentPlatform()))
				{
					bool flag = false;
					if (!this.GetHostAirFacility().GetParentPlatform().IsShip)
					{
						flag = true;
					}
					if (!flag)
					{
						Ship._ShipCategory category = ((Ship)this.GetHostAirFacility().GetParentPlatform()).Category;
						if (category != Ship._ShipCategory.SurfaceCombatant && category != Ship._ShipCategory.SurfaceCombatant_AviationCapable && category != Ship._ShipCategory.MobileOffshoreBase_AviationCapable)
						{
							flag = true;
						}
					}
					if (!flag && this.GetHostAirFacility().GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking)
					{
						flag = true;
					}
					if (flag)
					{
						if (this.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.Parked)
						{
							this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Parked);
							if (!Information.IsNothing(this.GetCurrentHostUnit()))
							{
								string str = "";
								if (Operators.CompareString(this.GetAircraft().Name, this.GetAircraft().UnitClass, false) != 0)
								{
									str = " (" + this.GetAircraft().UnitClass + ")";
								}
								this.GetAircraft().LogMessage(this.GetAircraft().Name + str + "完成出动准备，机场：" + this.GetCurrentHostUnit().Name, LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetCurrentHostUnit().GetLongitude(null), this.GetCurrentHostUnit().GetLatitude(null)));
							}
						}
					}
					else if (Information.IsNothing(this.GetAircraft().GetLoadout()))
					{
						if (this.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.Parked)
						{
							this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Parked);
							if (!Information.IsNothing(this.GetCurrentHostUnit()))
							{
								string str2 = "";
								if (Operators.CompareString(this.GetAircraft().Name, this.GetAircraft().UnitClass, false) != 0)
								{
									str2 = " (" + this.GetAircraft().UnitClass + ")";
								}
								this.GetAircraft().LogMessage(this.GetAircraft().Name + str2 + "完成出动准备，机场：" + this.GetCurrentHostUnit().Name, LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetCurrentHostUnit().GetLongitude(null), this.GetCurrentHostUnit().GetLatitude(null)));
							}
						}
					}
					else if (this.GetAircraft().GetLoadout().loadoutRole != Loadout.LoadoutRole.Reserve && this.GetAircraft().GetLoadout().loadoutRole != Loadout.LoadoutRole.Unavailable)
					{
						AirFacility._AirFacilityType airFacilityType = this.GetHostAirFacility().GetAirFacilityType();
						if (airFacilityType == AirFacility._AirFacilityType.Hangar)
						{
							if (!Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().GetLandingQueue()) && !Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().vmethod_5()))
							{
								List<AirFacility> list = this.GetCurrentHostUnit().GetAirFacilities().Where(Aircraft_AirOps.AirFacilityFunc5).ToList<AirFacility>();
								List<AirFacility> list2 = list.Where(Aircraft_AirOps.AirFacilityFunc6).ToList<AirFacility>();
								if (((this.GetCurrentHostUnit().GetAirOps().GetLandingQueue().Count<Aircraft>() > 0 || this.GetCurrentHostUnit().GetAirOps().vmethod_5().Count<Aircraft>() > 0) && list.Count - list2.Count <= 2) || (!Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().method_10()) && list.Count - list2.Count <= 2))
								{
									goto IL_889;
								}
							}
							int num = 0;
							for (int i = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; i >= 0; i += -1)
							{
								AirFacility airFacility = this.GetCurrentHostUnit().GetAirFacilities()[i];
								if (airFacility.GetAirFacilityType() == AirFacility._AirFacilityType.Elevator)
								{
									foreach (Aircraft current in airFacility.GetHostedAircrafts().Values)
									{
										if (current.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck)
										{
											num = (int)((byte)((byte)num + current.aircraftSizeClass));
										}
									}
								}
							}
							int j = this.GetCurrentHostUnit().GetAirFacilities().Length - 1;
							bool flag2 = false;
							while (j >= 0)
							{
								AirFacility airFacility = this.GetCurrentHostUnit().GetAirFacilities()[j];
								if (airFacility.GetAirFacilityType() != AirFacility._AirFacilityType.OpenParking || !airFacility.method_40(this.GetAircraft()) || airFacility.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed || (double)airFacility.method_39() / (double)airFacility.GetAircraftSizeClass() <= (double)(4 + num))
								{
									j += -1;
								}
								else
								{
									IEnumerable<AirFacility> enumerable = base.method_1(this.GetCurrentHostUnit()).OrderBy(Aircraft_AirOps.AirFacilityFunc7);
									if (Information.IsNothing(enumerable) || enumerable.Count<AirFacility>() <= 0)
									{
										goto IL_889;
									}
									IEnumerable<AirFacility> enumerable2 = base.method_0(null, this.GetAircraft(), this.GetCurrentHostUnit(), enumerable);
									if (!Information.IsNothing(enumerable2) && enumerable2.Count<AirFacility>() > 0)
									{
										if (this.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.Parked && !Information.IsNothing(this.GetCurrentHostUnit()))
										{
											string text = "";
											if (Operators.CompareString(this.GetAircraft().Name, this.GetAircraft().UnitClass, false) != 0)
											{
												text = " (" + this.GetAircraft().UnitClass + ")";
											}
											this.GetAircraft().LogMessage(string.Concat(new string[]
											{
												this.GetAircraft().Name,
												text,
												"完成出动准备，机场：",
												this.GetCurrentHostUnit().Name,
												", 移动到飞行甲板..."
											}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetCurrentHostUnit().GetLongitude(null), this.GetCurrentHostUnit().GetLatitude(null)));
										}
										this.method_74(enumerable2.ElementAtOrDefault(0), Aircraft_AirOps.Enum13.const_2);
										return;
									}
									goto IL_889;
								}
							}
							if (flag2)
							{
								IEnumerable<AirFacility> enumerable = base.method_1(this.GetCurrentHostUnit()).OrderBy(Aircraft_AirOps.AirFacilityFunc7);
								if (!Information.IsNothing(enumerable) && enumerable.Count<AirFacility>() > 0)
								{
									IEnumerable<AirFacility> enumerable2 = base.method_0(null, this.GetAircraft(), this.GetCurrentHostUnit(), enumerable);
									if (!Information.IsNothing(enumerable2) && enumerable2.Count<AirFacility>() > 0)
									{
										if (this.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.Parked && !Information.IsNothing(this.GetCurrentHostUnit()))
										{
											string text = "";
											if (Operators.CompareString(this.GetAircraft().Name, this.GetAircraft().UnitClass, false) != 0)
											{
												text = " (" + this.GetAircraft().UnitClass + ")";
											}
											this.GetAircraft().LogMessage(string.Concat(new string[]
											{
												this.GetAircraft().Name,
												text,
												"完成出动准备，机场：",
												this.GetCurrentHostUnit().Name,
												", 移动到飞行甲板..."
											}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetCurrentHostUnit().GetLongitude(null), this.GetCurrentHostUnit().GetLatitude(null)));
										}
										this.method_74(enumerable2.ElementAtOrDefault(0), Aircraft_AirOps.Enum13.const_2);
										return;
									}
								}
							}
						}
						else if (airFacilityType == AirFacility._AirFacilityType.Elevator)
						{
							for (int k = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; k >= 0; k += -1)
							{
								AirFacility airFacility2 = this.GetCurrentHostUnit().GetAirFacilities()[k];
								if (airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking && airFacility2.method_40(this.GetAircraft()) && airFacility2.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed && (double)airFacility2.method_39() / (double)airFacility2.GetAircraftSizeClass() > 4.0)
								{
									this.RearmRefuelOrAbortLaunch(airFacility2, false, false);
									this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Parked);
									return;
								}
							}
							for (int l = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; l >= 0; l += -1)
							{
								AirFacility airFacility2 = this.GetCurrentHostUnit().GetAirFacilities()[l];
								if (airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.Hangar && airFacility2.method_40(this.GetAircraft()))
								{
									this.RearmRefuelOrAbortLaunch(airFacility2, false, false);
									this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Parked);
									return;
								}
							}
						}
						IL_889:
						if (this.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.Parked)
						{
							this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Parked);
							if (!Information.IsNothing(this.GetCurrentHostUnit()))
							{
								string str3 = "";
								if (Operators.CompareString(this.GetAircraft().Name, this.GetAircraft().UnitClass, false) != 0)
								{
									str3 = " (" + this.GetAircraft().UnitClass + ")";
								}
								this.GetAircraft().LogMessage(this.GetAircraft().Name + str3 + "完成出动准备，机场：" + this.GetCurrentHostUnit().Name, LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetCurrentHostUnit().GetLongitude(null), this.GetCurrentHostUnit().GetLatitude(null)));
							}
						}
					}
					else if (this.GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.Parked)
					{
						this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Parked);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100419", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x00024520 File Offset: 0x00022720
		private void method_57()
		{
			this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
			this.SetConditionTimer(1f);
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x001DE190 File Offset: 0x001DC390
		private void HoldingOnLandingQueue()
		{
			try
			{
				ActiveUnit assignedHostUnit = this.GetAssignedHostUnit();
				if (Information.IsNothing(assignedHostUnit))
				{
					this.method_57();
				}
				else if (assignedHostUnit.GetAirOps().GetLandingQueue().Count<Aircraft>() == 0 || assignedHostUnit.GetAirOps().GetLandingQueue()[0] == this.theUnit)
				{
					IEnumerable<AirFacility> enumerable = this.method_69(false, true, this.GetAssignedHostUnit(), this.GetAircraft().IsVerticalLaunchable()).OrderBy(Aircraft_AirOps.AirFacilityFunc8).ThenBy(Aircraft_AirOps.AirFacilityFunc9);
					IEnumerable<AirFacility> enumerable2 = null;
					if (!Information.IsNothing(enumerable) && enumerable.Count<AirFacility>() > 0)
					{
						enumerable2 = base.method_2(false, false, this.GetAircraft(), this.GetAssignedHostUnit(), this.GetAircraft().IsVerticalLaunchable(), enumerable);
					}
					if (!Information.IsNothing(enumerable2) && enumerable2.Count<AirFacility>() != 0)
					{
						using (IEnumerator<AirFacility> enumerator = enumerable.GetEnumerator())
						{
							if (enumerator.MoveNext())
							{
								AirFacility current = enumerator.Current;
								this.method_59(current);
								return;
							}
						}
						this.SetConditionTimer(10f);
					}
					else
					{
						this.SetConditionTimer(5f);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100420", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x00024534 File Offset: 0x00022734
		private void method_59(AirFacility airFacility_1)
		{
			this.GetAssignedHostUnit().GetAirOps().RemoveAircraftFromLandingQueue(this.GetAircraft());
			this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Landing_PreTouchdown);
			this.SetConditionTimer(120f);
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x001DE330 File Offset: 0x001DC530
		public void method_60(float float_5)
		{
			try
			{
				ActiveUnit assignedHostUnit = this.GetAssignedHostUnit();
				IEnumerable<AirFacility> enumerable = this.method_61(assignedHostUnit);
				bool flag = assignedHostUnit.GetAirOps().CanBeHostedOnAirFacility(this.GetAircraft());
				if (Information.IsNothing(enumerable))
				{
					Aircraft_Navigator aircraftNavigator = this.GetAircraft().GetAircraftNavigator();
					ActiveUnit assignedHostUnit_ = assignedHostUnit;
					float desiredSpeed_ = (float)this.theUnit.GetKinematics().GetSpeed(this.GetAircraft().GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Cruise);
					Aircraft_Navigator aircraftNavigator2 = this.GetAircraft().GetAircraftNavigator();
					bool flag2 = false;
					float transitAltitude = aircraftNavigator2.GetTransitAltitude(ref flag2);
					Aircraft aircraft;
					ActiveUnit aircraft2;
					bool bool_ = (aircraft = this.GetAircraft()).IsTerrainFollowing(aircraft2 = this.GetAircraft());
					aircraftNavigator.method_68(assignedHostUnit_, desiredSpeed_, transitAltitude, ref bool_);
					aircraft.SetIsTerrainFollowing(aircraft2, bool_);
				}
				else if (!flag)
				{
					this.GetAircraft().GetAircraftAI().vmethod_27(float_5);
				}
				else
				{
					this.method_62(enumerable.ElementAtOrDefault(0), true);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100421", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BFB RID: 19451 RVA: 0x001DE464 File Offset: 0x001DC664
		private IEnumerable<AirFacility> method_61(ActiveUnit activeUnit_3)
		{
			IEnumerable<AirFacility> result = null;
			if (activeUnit_3.GetAirFacilities().Length == 0)
			{
				result = null;
			}
			else
			{
				try
				{
					IEnumerable<AirFacility> enumerable = this.method_69(false, false, activeUnit_3, this.GetAircraft().IsVerticalLaunchable()).OrderBy(Aircraft_AirOps.AirFacilityFunc10).ThenBy(Aircraft_AirOps.AirFacilityFunc11);
					IEnumerable<AirFacility> enumerable2 = null;
					if (!Information.IsNothing(enumerable) && enumerable.Count<AirFacility>() > 0)
					{
						enumerable2 = base.method_2(false, true, this.GetAircraft(), activeUnit_3, this.GetAircraft().IsVerticalLaunchable(), enumerable);
					}
					if (!Information.IsNothing(enumerable2) && enumerable2.Count<AirFacility>() > 0)
					{
						result = enumerable2;
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
					ex2.Data.Add("Error at 100422", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x001DE560 File Offset: 0x001DC760
		public void method_62(AirFacility theRunway, bool NormalLandingSequence = true)
		{
			try
			{
				Aircraft aircraft = this.GetAircraft();
				this.AddToQuickTurnaroundAirborneTimeFlown(ref aircraft);
				this.GetAircraft().GetAircraftNavigator().SupportMission_NextRefPoint = null;
				this.theUnit.SetWeaponState(ActiveUnit._ActiveUnitWeaponState.None);
				this.theUnit.SetFuelState(ActiveUnit._ActiveUnitFuelState.None);
				this.A2AR_NumberOfReceiverHookups = 0;
				if (NormalLandingSequence)
				{
					this.SetHostAirFacility(theRunway);
					this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Landing_PostTouchdown);
					switch (this.GetAircraft().GetTargetVisualSizeClass())
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
						this.SetConditionTimer(20f);
						break;
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						this.SetConditionTimer(30f);
						break;
					case GlobalVariables.TargetVisualSizeClass.Small:
						this.SetConditionTimer(30f);
						break;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						this.SetConditionTimer(30f);
						break;
					case GlobalVariables.TargetVisualSizeClass.Large:
						this.SetConditionTimer(30f);
						break;
					case GlobalVariables.TargetVisualSizeClass.VLarge:
						this.SetConditionTimer(30f);
						break;
					}
				}
				else
				{
					this.Landing(false, true, false);
				}
				if (!Information.IsNothing(this.theUnit.GetAssignedMission(false)))
				{
					if (this.theUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Ferry)
					{
						FerryMission.FerryMissionBehavior ferryMissionBehavior = ((FerryMission)this.theUnit.GetAssignedMission(false)).GetFerryMissionBehavior();
						if (ferryMissionBehavior != FerryMission.FerryMissionBehavior.OneWay)
						{
							if (ferryMissionBehavior == FerryMission.FerryMissionBehavior.Random)
							{
								this.method_31(this.GetAssignedHostUnit(false));
							}
						}
						else
						{
							this.theUnit.DeleteMission(false, null);
							this.SetAssignedHostUnit(false, this.GetCurrentHostUnit());
						}
					}
					if (!Information.IsNothing(this.theUnit.GetAssignedMission(false)) && this.theUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Support && ((SupportMission)this.theUnit.GetAssignedMission(false)).OTO)
					{
						this.theUnit.DeleteMission(false, null);
					}
				}
				if (this.theUnit.HasParentGroup() && this.theUnit.GetParentGroup(false).GetGroupType() == Group.GroupType.AirGroup)
				{
					this.theUnit.method_121(false, true);
				}
				this.theUnit.GetNavigator().ClearPlottedCourse();
				this.theUnit.method_117();
				if (this.theUnit.GetNavigator().HasFlightCourse())
				{
					Mission.Flight flight = this.theUnit.GetNavigator().GetFlight();
					Mission assignedMission = this.theUnit.GetAssignedMission(false);
					this.theUnit.GetNavigator().vmethod_3();
					bool flag = false;
					foreach (ActiveUnit current in this.theUnit.m_Scenario.GetActiveUnitList())
					{
						if (current.GetNavigator().HasFlight() && current.GetNavigator().GetFlight() == flight)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						if (!Information.IsNothing(assignedMission.EmptySlotsList) && assignedMission.EmptySlotsList.Count > 0)
						{
							foreach (Mission.EmptySlot current2 in assignedMission.EmptySlotsList)
							{
								if (current2.GetFlight(this.theUnit.m_Scenario) == flight)
								{
									current2.SetFlight(this.theUnit.m_Scenario, null);
								}
							}
						}
						assignedMission.FlightListRemove(flight);
					}
					if (assignedMission.category == Mission.MissionCategory.Package)
					{
						this.theUnit.DeleteMission(false, null);
						if (!assignedMission.HasFlights())
						{
							this.theUnit.GetSide(false).RemoveMission(assignedMission);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100423", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x001DE970 File Offset: 0x001DCB70
		private void TakeOff(float float_5)
		{
			if (!Information.IsNothing(this.GetCurrentHostUnit()))
			{
				try
				{
					string name = this.GetCurrentHostUnit().Name;
					Aircraft aircraft = (Aircraft)this.theUnit;
					this.AddToQuickTurnaroundSorties(ref aircraft);
					this.theUnit.SetLongitude(null, this.GetCurrentHostUnit().GetLongitude(null));
					this.theUnit.SetLatitude(null, this.GetCurrentHostUnit().GetLatitude(null));
					this.theUnit.SetAltitude_ASL(false, this.GetCurrentHostUnit().GetCurrentAltitude_ASL(false) + 30f);
					this.theUnit.SetCurrentSpeed((float)(0.66666666666666663 * (double)this.theUnit.GetKinematics().GetSpeed(this.theUnit.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter)));
					this.theUnit.SetCurrentHeading(this.GetCurrentHostUnit().GetCurrentHeading());
					this.theUnit.GetKinematics().SetDesiredAltitudeOverride(false);
					this.theUnit.GetKinematics().SetDesiredSpeedOverride(null);
					if (Information.IsNothing(this.GetAssignedHostUnit(false)))
					{
						this.SetAssignedHostUnit(false, this.GetCurrentHostUnit());
					}
					if (!Information.IsNothing(this.GetAircraft().GetLoadout()) && !Information.IsNothing(this.theUnit.GetAssignedMission(false)))
					{
						ActiveUnit theUnit = this.theUnit;
						ActiveUnit_AI aI = this.theUnit.GetAI();
						aircraft = this.GetAircraft();
						Aircraft aircraft3;
						Aircraft aircraft2 = aircraft3 = this.GetAircraft();
						bool? hintIsOperating = null;
						double latitude = aircraft3.GetLatitude(hintIsOperating);
						Aircraft aircraft5;
						Aircraft aircraft4 = aircraft5 = this.GetAircraft();
						bool? hintIsOperating2 = null;
						double longitude = aircraft5.GetLongitude(hintIsOperating2);
						float desiredAltitude = aI.method_77(ref aircraft, ref latitude, ref longitude);
						aircraft4.SetLongitude(hintIsOperating2, longitude);
						aircraft2.SetLatitude(hintIsOperating, latitude);
						theUnit.SetDesiredAltitude(desiredAltitude);
					}
					else
					{
						ActiveUnit theUnit2 = this.theUnit;
						ActiveUnit_AI aI2 = this.theUnit.GetAI();
						Aircraft aircraft4 = this.GetAircraft();
						ActiveUnit theUnit3;
						ActiveUnit theUnit4;
						bool bool_ = (theUnit3 = this.theUnit).IsTerrainFollowing(theUnit4 = this.theUnit);
						float desiredAltitude2 = aI2.method_78(ref aircraft4, ActiveUnit.Throttle.Loiter, ref bool_);
						theUnit3.SetIsTerrainFollowing(theUnit4, bool_);
						theUnit2.SetDesiredAltitude(desiredAltitude2);
					}
					if (!Information.IsNothing(this.theUnit.GetAssignedMission(false)) && this.theUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Ferry && ((FerryMission)this.theUnit.GetAssignedMission(false)).GetFerryMissionBehavior() == FerryMission.FerryMissionBehavior.Cycle)
					{
						this.theUnit.GetAI().SwitchFerryCycleLegIsOutbound();
					}
					this.SetHostAirFacility(null);
					this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Airborne);
					Aircraft_AirOps.Delegate6 @delegate = Aircraft_AirOps.delegate6_0;
					if (@delegate != null)
					{
						@delegate(this.GetAircraft());
					}
					if (this.theUnit.GetEngines()[0].GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed || this.theUnit.GetEngines()[0].GetComponentStatus() == PlatformComponent._ComponentStatus.Damaged)
					{
						this.theUnit.GetEngines()[0].vmethod_8();
					}
					if (!Information.IsNothing(this.theUnit.GetParentGroup(false)) && !this.theUnit.IsGroupLead())
					{
						bool flag = true;
						foreach (ActiveUnit current in this.theUnit.GetParentGroup(false).GetUnitsInGroup().Values)
						{
							if (current != this.theUnit && current.IsOperating())
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							this.theUnit.GetParentGroup(false).SetAsGroupLead(this.theUnit);
						}
					}
					this.GetAircraft().SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
					this.theUnit.GetAI().TargetingContacts(float_5, true, true);
					this.theUnit.GetAI().ScheduleNextPrimaryTargetEvent((short)Math.Round((double)float_5), true);
					this.theUnit.GetAI().ThreatAssessment();
					this.theUnit.GetAI().UpdateUnitStatus(float_5, false, false);
					checked
					{
						if (!this.theUnit.GetNavigator().HasPlottedCourse() && !Information.IsNothing(this.theUnit.GetAssignedMission(false)) && this.theUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Strike)
						{
							switch (((Strike)this.theUnit.GetAssignedMission(false)).strikeType)
							{
							case Strike.StrikeType.Air_Intercept:
							case Strike.StrikeType.Sub_Strike:
								break;
							case Strike.StrikeType.Land_Strike:
							case Strike.StrikeType.Maritime_Strike:
								if (!Information.IsNothing(this.theUnit.GetParentGroup(false)))
								{
									Aircraft aircraft6 = (Aircraft)this.theUnit.GetParentGroup(false).GetGroupLead();
									aircraft6.m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(aircraft6.m_Scenario, false, new bool?(false), false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
									if (aircraft6.GetAircraftNavigator().HasFlightCourse())
									{
										if (this.theUnit.IsGroupLead())
										{
											Waypoint[] flightCourse = aircraft6.GetAircraftNavigator().GetFlight().GetFlightCourse();
											for (int i = 0; i < flightCourse.Length; i++)
											{
												Waypoint waypoint_ = flightCourse[i];
												Aircraft_Navigator aircraftNavigator = aircraft6.GetAircraftNavigator();
												Waypoint[] array = aircraftNavigator.GetPlottedCourse();
												ScenarioArrayUtil.AddWaypoint(ref array, waypoint_);
												aircraftNavigator.SetPlottedCourse(array);
											}
										}
									}
									else if ((this.theUnit.GetParentGroup(false).GetGroupType() != Group.GroupType.AirGroup || !this.theUnit.GetParentGroup(false).method_138()) && aircraft6.GetAircraftNavigator().GetPlottedCourse_PrePlanned().Count<Waypoint>() > 0)
									{
										aircraft6.GetAircraftNavigator().SetPlottedCourse(aircraft6.GetAircraftNavigator().GetPlottedCourse_PrePlanned());
									}
								}
								else
								{
									this.GetAircraft().m_Doctrine.SetIgnorePlottedCourseWhenAttackingDoctrine(this.GetAircraft().m_Scenario, false, new bool?(false), false, false, new Doctrine._IgnorePlottedCourseWhenAttacking?(Doctrine._IgnorePlottedCourseWhenAttacking.const_0));
									if (this.GetAircraft().GetAircraftNavigator().HasFlightCourse())
									{
										Waypoint[] array = this.GetAircraft().GetAircraftNavigator().GetFlight().GetFlightCourse();
										for (int j = 0; j < array.Length; j++)
										{
											Waypoint waypoint_2 = array[j];
											Aircraft_Navigator aircraftNavigator2 = this.GetAircraft().GetAircraftNavigator();
											Waypoint[] plottedCourse = aircraftNavigator2.GetPlottedCourse();
											ScenarioArrayUtil.AddWaypoint(ref plottedCourse, waypoint_2);
											aircraftNavigator2.SetPlottedCourse(plottedCourse);
										}
									}
									else if (this.GetAircraft().GetAircraftNavigator().GetPlottedCourse_PrePlanned().Count<Waypoint>() > 0)
									{
										this.GetAircraft().GetAircraftNavigator().SetPlottedCourse(this.GetAircraft().GetAircraftNavigator().GetPlottedCourse_PrePlanned());
									}
								}
								break;
							default:
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								break;
							}
						}
						if (!Information.IsNothing(this.theUnit.GetParentGroup(false)) && this.theUnit.GetParentGroup(false).GetGroupType() != Group.GroupType.AirGroup && this.theUnit.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.OnPatrol)
						{
							this.theUnit.method_121(false, true);
						}
						string text = "";
						if (Operators.CompareString(this.GetAircraft().Name, this.GetAircraft().UnitClass, false) != 0)
						{
							text = " (" + this.GetAircraft().UnitClass + ")";
						}
						if (this.GetAircraft().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Unassigned)
						{
							this.GetAircraft().LogMessage(string.Concat(new string[]
							{
								this.GetAircraft().Name,
								text,
								" 离开",
								name,
								" 正在待命."
							}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetAircraft().GetLongitude(null), this.GetAircraft().GetLatitude(null)));
						}
						else if (this.GetAircraft().IsGroupLead() && Information.IsNothing(this.GetAircraft().GetAssignedMission(false)))
						{
							this.GetAircraft().LogMessage(string.Concat(new string[]
							{
								this.GetAircraft().Name,
								text,
								" 离开 ",
								name,
								" 正在待命."
							}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetAircraft().GetLongitude(null), this.GetAircraft().GetLatitude(null)));
						}
						else
						{
							this.GetAircraft().LogMessage(string.Concat(new string[]
							{
								this.GetAircraft().Name,
								text,
								" 离开 ",
								name,
								"."
							}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.GetAircraft().GetLongitude(null), this.GetAircraft().GetLatitude(null)));
						}
						this.GetAircraft().GetAircraftSensory().SetIsObeysEMCON(true);
						this.GetAircraft().GetAircraftSensory().ScheduleEMCONEvent(this.GetAircraft().GetAllNoneMCMSensors());
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100424", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x001DF2EC File Offset: 0x001DD4EC
		private void RearmRefuelOrAbortLaunch(AirFacility airFacility_1, bool RearmRefuel_, bool AbortLaunch_)
		{
			try
			{
				this.SetHostAirFacility(airFacility_1);
				if (RearmRefuel_)
				{
					Aircraft aircraft = null;
					if (!Information.IsNothing(this.GetAircraft().GetLoadout()))
					{
						ActiveUnit_AirOps airOps = this.GetCurrentHostUnit().GetAirOps();
						aircraft = this.GetAircraft();
						airOps.RearmAircraft(ref aircraft, this.GetAircraft().GetLoadout().DBID, this.GetAircraft().GetLoadout().DBID, false, this.GetAircraft().GetLoadout().NOW, !this.theUnit.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags), false, true);
					}
					else
					{
						this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Readying);
						this.SetConditionTimer(1800f);
					}
					ActiveUnit_AirOps airOps2 = this.GetCurrentHostUnit().GetAirOps();
					aircraft = this.GetAircraft();
					airOps2.RefuelAircraft(ref aircraft);
					ActiveUnit_AirOps airOps3 = this.GetCurrentHostUnit().GetAirOps();
					aircraft = this.GetAircraft();
					airOps3.RepairAircraft(ref aircraft);
				}
				else if (AbortLaunch_)
				{
					this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Parked);
					this.SetConditionTimer(0f);
					if (!Information.IsNothing(this.theUnit.GetParentGroup(false)))
					{
						this.theUnit.SetParentGroup(false, null);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100425", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x001DF468 File Offset: 0x001DD668
		public void method_65()
		{
			try
			{
				WeaponRec[] weaponRecArray = this.GetAircraft().GetLoadout().WeaponRecArray;
				for (int i = 0; i < weaponRecArray.Length; i = checked(i + 1))
				{
					WeaponRec weaponRec = weaponRecArray[i];
					if (!Weapon.IsNotLaunchableFireWeapon(weaponRec.WeapID, ref this.theUnit.m_Scenario) && weaponRec.GetCurrentLoad() > 0)
					{
						int currentLoad = weaponRec.GetCurrentLoad();
						for (int j = 1; j <= currentLoad; j++)
						{
							this.GetCurrentHostUnit().GetWeaponry().AddToMagazineWeaponLoad(weaponRec.WeapID, true, true);
						}
					}
				}
				this.GetAircraft().GetLoadout().WeaponRecArray = new WeaponRec[0];
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100426", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x001DF564 File Offset: 0x001DD764
		public bool method_66()
		{
			bool result = false;
			if (!Information.IsNothing(this.GetHostAirFacility()))
			{
				result = this.GetHostAirFacility().IsHangarOrOpenParking();
			}
			return result;
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x001DF590 File Offset: 0x001DD790
		public override bool vmethod_6(bool bool_1, ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_0, bool bool_2, ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_1, bool bool_3, bool bool_4)
		{
			bool result = false;
			try
			{
				if (this.GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.RTB && this.theUnit.IsRTB() && !bool_1)
				{
					result = true;
				}
				else if (!Information.IsNothing(this.GetAssignedHostUnit()))
				{
					if (bool_3)
					{
						this.theUnit.method_121(false, bool_4);
					}
					if (!this.theUnit.IsRTB())
					{
						this.theUnit.SetUnitStatus(_ActiveUnitStatus_0);
					}
					this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.RTB);
					this.theUnit.GetKinematics().SetDesiredSpeedOverride(null);
					this.theUnit.GetKinematics().SetDesiredAltitudeOverride(false);
					if (bool_2 && !Information.IsNothing(this.theUnit.GetParentGroup(false)))
					{
						foreach (ActiveUnit current in this.theUnit.GetParentGroup(false).GetUnitsInGroup().Values)
						{
							if (current != this.theUnit)
							{
								if (bool_3)
								{
									this.theUnit.method_121(false, bool_4);
								}
								if (!current.IsRTB())
								{
									current.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB);
								}
								this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.RTB);
								current.GetKinematics().SetDesiredSpeedOverride(null);
								current.GetKinematics().SetDesiredAltitudeOverride(false);
							}
						}
					}
					result = true;
				}
				else
				{
					this.AssignNewHostUnit();
					if (!Information.IsNothing(this.GetAssignedHostUnit(false)))
					{
						if (bool_3)
						{
							this.theUnit.method_121(false, bool_4);
						}
						if (!this.theUnit.IsRTB())
						{
							this.theUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB);
						}
						this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.RTB);
						this.theUnit.GetKinematics().SetDesiredSpeedOverride(null);
						this.theUnit.GetKinematics().SetDesiredAltitudeOverride(false);
						if (bool_2 && !Information.IsNothing(this.theUnit.GetParentGroup(false)))
						{
							foreach (ActiveUnit current2 in this.theUnit.GetParentGroup(false).GetUnitsInGroup().Values)
							{
								if (current2 != this.theUnit)
								{
									if (bool_3)
									{
										this.theUnit.method_121(false, bool_4);
									}
									if (!current2.IsRTB())
									{
										current2.SetUnitStatus(ActiveUnit._ActiveUnitStatus.RTB);
									}
									this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.RTB);
									current2.GetKinematics().SetDesiredSpeedOverride(null);
									current2.GetKinematics().SetDesiredAltitudeOverride(false);
								}
							}
						}
						result = true;
					}
					else
					{
						string str = "";
						if (Operators.CompareString(this.theUnit.Name, this.theUnit.UnitClass, false) != 0)
						{
							str = " (" + this.theUnit.UnitClass + ")";
						}
						if (bool_1)
						{
							this.theUnit.m_Scenario.LogMessage(this.theUnit.Name + str + "没有合适的降落地点!", LoggedMessage.MessageType.AirOps, 15, this.theUnit.GetGuid(), this.theUnit.GetSide(false), new GeoPoint(this.theUnit.GetLongitude(null), this.theUnit.GetLatitude(null)));
						}
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100427", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x001DF970 File Offset: 0x001DDB70
		public bool method_67()
		{
			ActiveUnit currentHostUnit = this.GetCurrentHostUnit();
			bool result = false;
			if (Information.IsNothing(currentHostUnit))
			{
				result = false;
			}
			else
			{
				try
				{
					if (Information.IsNothing(this.GetAircraft().GetAssignedMission(false)))
					{
						result = false;
					}
					else if (this.GetAircraft().GetAssignedMission(false).MissionClass != Mission._MissionClass.Strike)
					{
						result = false;
					}
					else if (this.GetAircraft().GetAircraftAI().IsEscort)
					{
						result = false;
					}
					else
					{
						List<Aircraft> list = new List<Aircraft>();
						foreach (Aircraft current in currentHostUnit.GetAirOps().GetHostedAircrafts())
						{
							if (current != this.theUnit && current.GetAircraftAI().IsEscort && !Information.IsNothing(current.GetAssignedMission(false)) && current.GetAssignedMission(false) == this.theUnit.GetAssignedMission(false))
							{
								Aircraft aircraft = current;
								string text = null;
								if (aircraft.GetMaintenanceLevel(ref text) == Aircraft_AirOps._Maintenance.const_0 && !current.IsParkedInPlace() && !current.IsParking() && current.GetAircraftAirOps().GetAirOpsCondition() != Aircraft_AirOps._AirOpsCondition.Readying)
								{
									list.Add(current);
								}
							}
						}
						if (list.Count == 0)
						{
							result = false;
						}
						else
						{
							this.SetConditionTimer(30f);
							result = true;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200445", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x001DFB4C File Offset: 0x001DDD4C
		public void PreparingToLaunch()
		{
			if (!Information.IsNothing(this.theUnit) && this.GetConditionTimer() <= 0f && !Information.IsNothing(this.GetHostAirFacility()))
			{
				if (Information.IsNothing(this.GetHostAirFacility().GetParentPlatform()) && !Information.IsNothing(this.GetCurrentHostUnit()))
				{
					this.GetCurrentHostUnit().AddAirFacility(this.GetHostAirFacility());
					this.GetHostAirFacility().SetParentPlatform(this.GetCurrentHostUnit());
				}
				try
				{
					AirFacility._AirFacilityType airFacilityType = this.GetHostAirFacility().GetAirFacilityType();
					switch (airFacilityType)
					{
					case AirFacility._AirFacilityType.Runway:
					case AirFacility._AirFacilityType.RunwayWithArrest:
					case AirFacility._AirFacilityType.AircraftCarrierSkiJump:
						goto IL_59E;
					case AirFacility._AirFacilityType.RunwayGradeTaxiway:
						goto IL_B08;
					case AirFacility._AirFacilityType.RunwayAccessPoint:
						break;
					case AirFacility._AirFacilityType.AircraftCarrierCatapult:
						this.method_73(this.GetHostAirFacility());
						return;
					case AirFacility._AirFacilityType.AircraftCarrierArrestingGear:
						goto IL_5C3;
					default:
						if (airFacilityType - AirFacility._AirFacilityType.Pad <= 1)
						{
							goto IL_59E;
						}
						switch (airFacilityType)
						{
						case AirFacility._AirFacilityType.Hangar:
						{
							if (this.GetHostAirFacility().GetParentPlatform().IsShip)
							{
								Ship._ShipCategory category = ((Ship)this.GetHostAirFacility().GetParentPlatform()).Category;
								if (category != Ship._ShipCategory.SurfaceCombatant && category != Ship._ShipCategory.SurfaceCombatant_AviationCapable && category != Ship._ShipCategory.MobileOffshoreBase_AviationCapable)
								{
									for (int i = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; i >= 0; i += -1)
									{
										AirFacility airFacility = this.GetCurrentHostUnit().GetAirFacilities()[i];
										if (airFacility.IsTakeOffOrLandingFacility() && this.method_70(airFacility) && airFacility.method_40(this.GetAircraft()))
										{
											this.method_73(airFacility);
											return;
										}
									}
								}
							}
							if (!Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().GetLandingQueue()) && !Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().vmethod_5()))
							{
								List<AirFacility> list = this.GetCurrentHostUnit().GetAirFacilities().Where(Aircraft_AirOps.AirFacilityFunc23).ToList<AirFacility>();
								List<AirFacility> list2 = list.Where(Aircraft_AirOps.AirFacilityFunc24).ToList<AirFacility>();
								if (this.GetCurrentHostUnit().GetAirOps().GetLandingQueue().Count<Aircraft>() <= 0 && this.GetCurrentHostUnit().GetAirOps().vmethod_5().Count<Aircraft>() <= 0)
								{
									if (!Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().method_10()) && list.Count - list2.Count <= 2)
									{
										this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit);
										this.SetConditionTimer(60f);
										return;
									}
								}
								else if (list.Count - list2.Count <= 2)
								{
									this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit);
									this.SetConditionTimer(60f);
									return;
								}
							}
							IEnumerable<AirFacility> enumerable = base.method_1(this.GetCurrentHostUnit()).OrderBy(Aircraft_AirOps.AirFacilityFunc25);
							if (!Information.IsNothing(enumerable) && enumerable.Count<AirFacility>() > 0)
							{
								IEnumerable<AirFacility> enumerable2 = base.method_0(new bool?(true), this.GetAircraft(), this.GetCurrentHostUnit(), enumerable);
								if (!Information.IsNothing(enumerable2) && enumerable2.Count<AirFacility>() > 0)
								{
									this.method_74(enumerable2.ElementAtOrDefault(0), Aircraft_AirOps.Enum13.const_0);
									return;
								}
							}
							this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit);
							this.SetConditionTimer(60f);
							goto IL_B08;
						}
						case AirFacility._AirFacilityType.OpenParking:
							goto IL_5C3;
						case AirFacility._AirFacilityType.Elevator:
							break;
						default:
							goto IL_B08;
						}
						break;
					}
					if (!Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().GetLandingQueue()) && !Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().vmethod_5()))
					{
						List<AirFacility> list3 = this.GetCurrentHostUnit().GetAirFacilities().Where(Aircraft_AirOps.AirFacilityFunc12).ToList<AirFacility>();
						List<AirFacility> list4 = list3.Where(Aircraft_AirOps.AirFacilityFunc13).ToList<AirFacility>();
						if ((this.GetCurrentHostUnit().GetAirOps().GetLandingQueue().Count<Aircraft>() > 0 || this.GetCurrentHostUnit().GetAirOps().vmethod_5().Count<Aircraft>() > 0) && list3.Count - list4.Count <= 2)
						{
							for (int j = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; j >= 0; j += -1)
							{
								AirFacility airFacility2 = this.GetCurrentHostUnit().GetAirFacilities()[j];
								if (airFacility2.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking && airFacility2.method_40(this.GetAircraft()))
								{
									this.RearmRefuelOrAbortLaunch(airFacility2, false, false);
									this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
									this.SetConditionTimer(35f);
									return;
								}
							}
						}
						if (!Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().method_10()) && list3.Count - list4.Count <= 2)
						{
							for (int k = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; k >= 0; k += -1)
							{
								AirFacility airFacility3 = this.GetCurrentHostUnit().GetAirFacilities()[k];
								if (airFacility3.GetAirFacilityType() == AirFacility._AirFacilityType.OpenParking && airFacility3.method_40(this.GetAircraft()))
								{
									this.RearmRefuelOrAbortLaunch(airFacility3, false, false);
									this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
									this.SetConditionTimer(35f);
									return;
								}
							}
						}
					}
					IEnumerable<AirFacility> enumerable3 = this.method_69(true, false, this.GetCurrentHostUnit(), this.GetAircraft().IsVerticalLaunchable()).OrderBy(Aircraft_AirOps.AirFacilityFunc14).ThenBy(Aircraft_AirOps.AirFacilityFunc15);
					if (Information.IsNothing(enumerable3) || enumerable3.Count<AirFacility>() <= 0)
					{
						goto IL_B08;
					}
					IEnumerable<AirFacility> enumerable4 = base.method_2(true, false, this.GetAircraft(), this.GetCurrentHostUnit(), this.GetAircraft().IsVerticalLaunchable(), enumerable3);
					if (!Information.IsNothing(enumerable4) && enumerable4.Count<AirFacility>() > 0)
					{
						this.method_73(enumerable4.ElementAtOrDefault(0));
						return;
					}
					goto IL_B08;
					IL_59E:
					if (this.method_70(this.GetHostAirFacility()))
					{
						this.method_73(this.GetHostAirFacility());
						return;
					}
					goto IL_B08;
					IL_5C3:
					if (this.GetHostAirFacility().GetParentPlatform().IsShip)
					{
						Ship._ShipCategory category2 = ((Ship)this.GetHostAirFacility().GetParentPlatform()).Category;
						if (category2 != Ship._ShipCategory.SurfaceCombatant && category2 != Ship._ShipCategory.SurfaceCombatant_AviationCapable && category2 != Ship._ShipCategory.MobileOffshoreBase_AviationCapable)
						{
							for (int l = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; l >= 0; l += -1)
							{
								AirFacility airFacility4 = this.GetCurrentHostUnit().GetAirFacilities()[l];
								if (this.method_70(airFacility4) && airFacility4.method_40(this.GetAircraft()))
								{
									this.method_73(airFacility4);
									return;
								}
							}
						}
						else
						{
							if (!Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().GetLandingQueue()) && !Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().vmethod_5()))
							{
								if (category2 != Ship._ShipCategory.MobileOffshoreBase_AviationCapable)
								{
									List<AirFacility> list5 = this.GetCurrentHostUnit().GetAirFacilities().Where(Aircraft_AirOps.AirFacilityFunc16).ToList<AirFacility>();
									List<AirFacility> list6 = list5.Where(Aircraft_AirOps.AirFacilityFunc17).ToList<AirFacility>();
									if (list5.Count > 0)
									{
										int count = list5.Count;
										int num = 0;
										if (count <= 0)
										{
											num = 0;
										}
										else if (count == 1)
										{
											num = 1;
										}
										else if (count == 2)
										{
											num = 1;
										}
										else if (count == 3)
										{
											num = 2;
										}
										else if (count >= 4)
										{
											num = 2;
										}
										if (list5.Count - list6.Count <= num)
										{
											if (this.GetCurrentHostUnit().GetAirOps().GetLandingQueue().Count<Aircraft>() > 0 || this.GetCurrentHostUnit().GetAirOps().vmethod_5().Count<Aircraft>() > 0)
											{
												this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
												this.SetConditionTimer(60f);
												return;
											}
											if (!Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().method_10()))
											{
												this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
												this.SetConditionTimer(60f);
												return;
											}
										}
									}
								}
								else
								{
									List<AirFacility> list7 = this.GetCurrentHostUnit().GetAirFacilities().Where(Aircraft_AirOps.AirFacilityFunc18).ToList<AirFacility>();
									List<AirFacility> list8 = list7.Where(Aircraft_AirOps.AirFacilityFunc19).ToList<AirFacility>();
									if (list7.Count > 0)
									{
										int count2 = list7.Count;
										int num2 = 0;
										if (count2 <= 0)
										{
											num2 = 0;
										}
										else if (count2 == 1)
										{
											num2 = 1;
										}
										else if (count2 == 2)
										{
											num2 = 1;
										}
										else if (count2 == 3)
										{
											num2 = 2;
										}
										else if (count2 >= 4)
										{
											num2 = 2;
										}
										if (list7.Count - list8.Count <= num2)
										{
											if (this.GetCurrentHostUnit().GetAirOps().GetLandingQueue().Count<Aircraft>() > 0 || this.GetCurrentHostUnit().GetAirOps().vmethod_5().Count<Aircraft>() > 0)
											{
												this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
												this.SetConditionTimer(60f);
												return;
											}
											if (!Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().method_10()))
											{
												this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
												this.SetConditionTimer(60f);
												return;
											}
										}
									}
								}
							}
							for (int m = this.GetCurrentHostUnit().GetAirFacilities().Length - 1; m >= 0; m += -1)
							{
								AirFacility airFacility5 = this.GetCurrentHostUnit().GetAirFacilities()[m];
								if (this.method_70(airFacility5) && airFacility5.method_40(this.GetAircraft()))
								{
									this.method_73(airFacility5);
									return;
								}
							}
						}
						this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableRunway);
						this.SetConditionTimer(5f);
					}
					else
					{
						if (!Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().GetLandingQueue()) && !Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().vmethod_5()))
						{
							if (this.GetCurrentHostUnit().GetAirOps().GetLandingQueue().Count<Aircraft>() > 0 || this.GetCurrentHostUnit().GetAirOps().vmethod_5().Count<Aircraft>() > 0)
							{
								this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit);
								this.SetConditionTimer(60f);
								return;
							}
							if (!Information.IsNothing(this.GetCurrentHostUnit().GetAirOps().method_10()))
							{
								List<AirFacility> list9 = this.GetCurrentHostUnit().GetAirFacilities().Where(Aircraft_AirOps.AirFacilityFunc20).ToList<AirFacility>();
								List<AirFacility> list10 = list9.Where(Aircraft_AirOps.AirFacilityFunc21).ToList<AirFacility>();
								if (list9.Count - list10.Count <= 2)
								{
									this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit);
									this.SetConditionTimer(35f);
									return;
								}
							}
						}
						IEnumerable<AirFacility> enumerable5 = base.method_1(this.GetAircraft().GetAircraftAirOps().GetCurrentHostUnit()).OrderBy(Aircraft_AirOps.AirFacilityFunc22);
						if (!Information.IsNothing(enumerable5) && enumerable5.Count<AirFacility>() > 0)
						{
							IEnumerable<AirFacility> enumerable6 = base.method_0(new bool?(true), this.GetAircraft(), this.GetCurrentHostUnit(), enumerable5);
							if (!Information.IsNothing(enumerable6) && enumerable6.Count<AirFacility>() > 0)
							{
								this.method_74(enumerable6.ElementAtOrDefault(0), Aircraft_AirOps.Enum13.const_0);
								return;
							}
						}
						this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.HoldingForAvailableTransit);
						this.SetConditionTimer(60f);
					}
					IL_B08:;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100428", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x001E06C0 File Offset: 0x001DE8C0
		public IEnumerable<AirFacility> method_69(bool bool_1, bool bool_2, ActiveUnit activeUnit_3, bool bool_3)
		{
			IEnumerable<AirFacility> result = null;
			try
			{
				List<AirFacility> list = new List<AirFacility>();
				List<AirFacility> list2 = new List<AirFacility>();
				for (int i = activeUnit_3.GetAirFacilities().Length - 1; i >= 0; i += -1)
				{
					AirFacility airFacility = activeUnit_3.GetAirFacilities()[i];
					AirFacility._AirFacilityType airFacilityType = airFacility.GetAirFacilityType();
					switch (airFacilityType)
					{
					case AirFacility._AirFacilityType.Runway:
					case AirFacility._AirFacilityType.RunwayWithArrest:
					case AirFacility._AirFacilityType.AircraftCarrierCatapult:
					case AirFacility._AirFacilityType.AircraftCarrierSkiJump:
					case AirFacility._AirFacilityType.AircraftCarrierArrestingGear:
						if (bool_1 && !bool_3 && this.GetAircraft().GetAircraftAirOps().method_70(airFacility))
						{
							list.Add(airFacility);
						}
						else if (!bool_1 && !bool_3 && this.GetAircraft().GetAircraftAirOps().HasLandingFacility(airFacility, bool_2))
						{
							list.Add(airFacility);
						}
						else if (bool_1 && bool_3 && this.GetAircraft().GetAircraftAirOps().method_70(airFacility))
						{
							list2.Add(airFacility);
						}
						else if (!bool_1 && bool_3 && this.GetAircraft().GetAircraftAirOps().HasLandingFacility(airFacility, bool_2))
						{
							list2.Add(airFacility);
						}
						break;
					case AirFacility._AirFacilityType.RunwayGradeTaxiway:
						if (bool_1 && this.GetAircraft().GetAircraftAirOps().method_70(airFacility))
						{
							list2.Add(airFacility);
						}
						else if (!bool_1 && this.GetAircraft().GetAircraftAirOps().HasLandingFacility(airFacility, bool_2))
						{
							list2.Add(airFacility);
						}
						break;
					case AirFacility._AirFacilityType.RunwayAccessPoint:
						break;
					default:
						if (airFacilityType - AirFacility._AirFacilityType.Pad <= 1)
						{
							if (bool_1 && bool_3 && this.GetAircraft().GetAircraftAirOps().method_70(airFacility))
							{
								list.Add(airFacility);
							}
							else if (!bool_1 && bool_3 && this.GetAircraft().GetAircraftAirOps().HasLandingFacility(airFacility, bool_2))
							{
								list.Add(airFacility);
							}
						}
						break;
					}
				}
				if (list2.Count > 0 && list.Count == 0)
				{
					result = list2.AsReadOnly();
				}
				else
				{
					result = list.AsReadOnly();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200355", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<AirFacility>();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x001E0948 File Offset: 0x001DEB48
		public bool method_70(AirFacility airFacility_1)
		{
			bool flag = false;
			bool result;
			try
			{
				AirFacility._AirFacilityType airFacilityType = airFacility_1.GetAirFacilityType();
				bool flag2 = false;
				bool flag3 = false;
				switch (airFacilityType)
				{
				case AirFacility._AirFacilityType.Runway:
				case AirFacility._AirFacilityType.RunwayGradeTaxiway:
					break;
				case AirFacility._AirFacilityType.RunwayWithArrest:
				case AirFacility._AirFacilityType.RunwayAccessPoint:
					goto IL_FD;
				case AirFacility._AirFacilityType.AircraftCarrierCatapult:
				case AirFacility._AirFacilityType.AircraftCarrierSkiJump:
					if (this.theUnit.m_Scenario.FeatureCompatibility.get_CarrierCapableFlag(this.theUnit.m_Scenario.GetSQLiteConnection()) && this.GetAircraft().Category != Aircraft._AircraftCategory.FixedWing_CarrierCapable && this.GetAircraft().Category != Aircraft._AircraftCategory.Helicopter && this.GetAircraft().Category != Aircraft._AircraftCategory.Tiltrotor)
					{
						flag = false;
						result = false;
						return result;
					}
					flag2 = true;
					flag3 = (this.GetAircraft().aircraftSizeClass <= airFacility_1.GetAircraftSizeAfterDamage());
					goto IL_FD;
				default:
					if (airFacilityType - AirFacility._AirFacilityType.Pad > 1)
					{
						goto IL_FD;
					}
					break;
				}
				flag2 = (this.GetAircraft().RunwayLengthCode <= airFacility_1.RunwayLengthCode);
				flag3 = (this.GetAircraft().aircraftSizeClass <= airFacility_1.GetAircraftSizeAfterDamage());
				IL_FD:
				flag = (flag2 && flag3);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100429", "");
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

		// Token: 0x06004C06 RID: 19462 RVA: 0x001E0AC0 File Offset: 0x001DECC0
		public bool HasLandingFacility(AirFacility airFacility_1, bool bool_1)
		{
			bool flag = false;
			bool result;
			try
			{
				AirFacility._AirFacilityType airFacilityType = airFacility_1.GetAirFacilityType();
				switch (airFacilityType)
				{
				case AirFacility._AirFacilityType.RunwayWithArrest:
					if (this.GetAircraft().aircraftSizeClass > airFacility_1.GetAircraftSizeAfterDamage())
					{
						flag = false;
						result = false;
						return result;
					}
					goto IL_136;
				case AirFacility._AirFacilityType.RunwayGradeTaxiway:
				case AirFacility._AirFacilityType.RunwayAccessPoint:
					break;
				case AirFacility._AirFacilityType.AircraftCarrierCatapult:
				case AirFacility._AirFacilityType.AircraftCarrierSkiJump:
					goto IL_A7;
				case AirFacility._AirFacilityType.AircraftCarrierArrestingGear:
					if (this.theUnit.m_Scenario.FeatureCompatibility.get_CarrierCapableFlag(this.theUnit.m_Scenario.GetSQLiteConnection()) && this.GetAircraft().Category != Aircraft._AircraftCategory.FixedWing_CarrierCapable && this.GetAircraft().Category != Aircraft._AircraftCategory.Helicopter && this.GetAircraft().Category != Aircraft._AircraftCategory.Tiltrotor)
					{
						flag = false;
						result = false;
						return result;
					}
					if (this.GetAircraft().aircraftSizeClass > airFacility_1.GetAircraftSizeAfterDamage())
					{
						flag = false;
						result = false;
						return result;
					}
					goto IL_136;
				default:
					if (airFacilityType == AirFacility._AirFacilityType.Hangar)
					{
						goto IL_A7;
					}
					break;
				}
				if (this.GetAircraft().RunwayLengthCode > airFacility_1.RunwayLengthCode)
				{
					flag = false;
					result = false;
					return result;
				}
				if (this.GetAircraft().aircraftSizeClass > airFacility_1.GetAircraftSizeAfterDamage())
				{
					flag = false;
					result = false;
					return result;
				}
				goto IL_136;
				IL_A7:
				flag = false;
				result = false;
				return result;
				IL_136:
				flag = (bool_1 || airFacility_1.method_40(this.GetAircraft()));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100430", "");
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

		// Token: 0x06004C07 RID: 19463 RVA: 0x001E0C7C File Offset: 0x001DEE7C
		private bool CanLand(ActiveUnit activeUnit_3, bool bool_1)
		{
			bool result = false;
			checked
			{
				try
				{
					if (Information.IsNothing(activeUnit_3.GetAirFacilities()))
					{
						result = false;
					}
					else
					{
						AirFacility[] airFacilities = activeUnit_3.GetAirFacilities();
						for (int i = 0; i < airFacilities.Length; i++)
						{
							AirFacility airFacility_ = airFacilities[i];
							if (this.HasLandingFacility(airFacility_, bool_1))
							{
								result = true;
								break;
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100431", "");
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

		// Token: 0x06004C08 RID: 19464 RVA: 0x001E0D20 File Offset: 0x001DEF20
		private void method_73(AirFacility airFacility_1)
		{
			this.SetHostAirFacility(airFacility_1);
			this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.TakingOff);
			if (this.GetHostAirFacility().GetAirFacilityType() == AirFacility._AirFacilityType.AircraftCarrierCatapult)
			{
				this.SetConditionTimer(80f);
			}
			else
			{
				switch (this.GetAircraft().GetTargetVisualSizeClass())
				{
				case GlobalVariables.TargetVisualSizeClass.Stealthy:
					this.SetConditionTimer(30f);
					break;
				case GlobalVariables.TargetVisualSizeClass.VSmall:
					this.SetConditionTimer(30f);
					break;
				case GlobalVariables.TargetVisualSizeClass.Small:
					this.SetConditionTimer(30f);
					break;
				case GlobalVariables.TargetVisualSizeClass.Medium:
					this.SetConditionTimer(30f);
					break;
				case GlobalVariables.TargetVisualSizeClass.Large:
					this.SetConditionTimer(30f);
					break;
				case GlobalVariables.TargetVisualSizeClass.VLarge:
					this.SetConditionTimer(30f);
					break;
				}
			}
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x001E0DD8 File Offset: 0x001DEFD8
		private void method_74(AirFacility airFacility_1, Aircraft_AirOps.Enum13 enum13_0)
		{
			this.SetHostAirFacility(airFacility_1);
			switch (enum13_0)
			{
			case Aircraft_AirOps.Enum13.const_0:
				this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.TaxyingToTakeOff);
				break;
			case Aircraft_AirOps.Enum13.const_1:
				this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.TaxyingToPark);
				break;
			case Aircraft_AirOps.Enum13.const_2:
				this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.TaxyingToFlightDeck);
				break;
			}
			switch (this.GetAircraft().GetTargetVisualSizeClass())
			{
			case GlobalVariables.TargetVisualSizeClass.Stealthy:
				this.SetConditionTimer(120f);
				break;
			case GlobalVariables.TargetVisualSizeClass.VSmall:
				this.SetConditionTimer(120f);
				break;
			case GlobalVariables.TargetVisualSizeClass.Small:
				this.SetConditionTimer(120f);
				break;
			case GlobalVariables.TargetVisualSizeClass.Medium:
				this.SetConditionTimer(120f);
				break;
			case GlobalVariables.TargetVisualSizeClass.Large:
				this.SetConditionTimer(120f);
				break;
			case GlobalVariables.TargetVisualSizeClass.VLarge:
				this.SetConditionTimer(120f);
				break;
			}
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x001E0E94 File Offset: 0x001DF094
		public bool method_75()
		{
			bool result = false;
			try
			{
				if (this.GetAircraft().IsOnLand())
				{
					result = false;
				}
				else
				{
					this.theUnit.GetKinematics().SetDesiredSpeedOverride(null);
					this.theUnit.SetDesiredSpeed(0f);
					this.theUnit.SetDesiredAltitude(45.72f);
					this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar);
					this.SetConditionTimer(240f);
					if (this.theUnit.GetCurrentAltitude_ASL(false) > 45.72f)
					{
						this.SetConditionTimer(240f);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100432", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x001E0F74 File Offset: 0x001DF174
		public override void AddsToLandingQueue(ref Scenario scenario_, Dictionary<string, Subject> dictionary_0, bool bool_1)
		{
			checked
			{
				try
				{
					if (Information.IsNothing(this.GetHostAirFacility()) && !string.IsNullOrEmpty(this.HostAirFacilityID))
					{
						if (dictionary_0.ContainsKey(this.HostAirFacilityID))
						{
							this.SetHostAirFacility((AirFacility)dictionary_0[this.HostAirFacilityID]);
						}
						else
						{
							bool flag = false;
							using (List<ActiveUnit>.Enumerator enumerator = scenario_.GetActiveUnitList().GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									AirFacility[] airFacilities = enumerator.Current.GetAirFacilities();
									for (int i = 0; i < airFacilities.Length; i++)
									{
										AirFacility airFacility = airFacilities[i];
										if (string.CompareOrdinal(airFacility.GetGuid(), this.HostAirFacilityID) == 0)
										{
											this.SetHostAirFacility(airFacility);
											goto IL_AE;
										}
									}
									if (!flag)
									{
										continue;
									}
									IL_AE:
									break;
								}
							}
						}
					}
					if (!Information.IsNothing(this.GetCurrentHostUnit()) && !Information.IsNothing(this.GetHostAirFacility()) && !this.GetCurrentHostUnit().GetAirFacilities().Contains(this.GetHostAirFacility()))
					{
						this.GetCurrentHostUnit().GetAirOps().method_18((Aircraft)this.theUnit, bool_1);
					}
					if (Information.IsNothing(this.GetCurrentHostUnit()) && !string.IsNullOrEmpty(this.ParentAircraftID))
					{
						foreach (ActiveUnit current in scenario_.GetActiveUnitList())
						{
							if (Operators.CompareString(current.GetGuid(), this.ParentAircraftID, false) == 0)
							{
								current.GetAirOps().method_18((Aircraft)this.theUnit, bool_1);
							}
						}
					}
					if (!this.GetAircraft().IsOperating() && Information.IsNothing(this.GetHostAirFacility()))
					{
						foreach (ActiveUnit current2 in scenario_.GetActiveUnits().Values)
						{
							if (current2.AirFacilities.Contains(this.HostAirFacilityID))
							{
								break;
							}
						}
					}
					if (Information.IsNothing(this.AssignedHostUnit) && !string.IsNullOrEmpty(this.string_3))
					{
						try
						{
							ActiveUnit value = scenario_.GetActiveUnits()[this.string_3];
							this.SetAssignedHostUnit(false, value);
							if (!this.GetAircraft().IsOperating() && (Information.IsNothing(this.GetHostAirFacility()) || Information.IsNothing(this.GetCurrentHostUnit())))
							{
								this.GetAssignedHostUnit(false).GetAirOps().method_18(this.GetAircraft(), bool_1);
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200022", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
					}
					if (!string.IsNullOrEmpty(this.A2AR_Destination))
					{
						this.A2ARefuelingDestinationAircraft = (Aircraft)scenario_.GetActiveUnits()[this.A2AR_Destination];
					}
					base.AddsToLandingQueue(ref scenario_, dictionary_0, bool_1);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 100433", "");
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x001E133C File Offset: 0x001DF53C
		public List<Aircraft> GetTankersForMe(ref bool bool_1, ref ActiveUnit tanker_, bool bool_2, List<Mission> MissionList, ref string strFeedback)
		{
			List<Aircraft> list = new List<Aircraft>();
			List<Aircraft> list2;
			List<Aircraft> result;
			try
			{
				Doctrine._UseRefuel? useRefuelDoctrine = this.theUnit.m_Doctrine.GetUseRefuelDoctrine(this.theUnit.m_Scenario, false, false, false, false);
				byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					strFeedback = "Aircraft " + this.theUnit.Name + " has a doctrine setting that disallows air-to-air refuelling. As such, the aircraft will not refuel. Change the doctrine setting and try again.";
					list2 = list;
				}
				else
				{
					b = (useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null);
					if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault() && this.GetAircraft().IsAirRefuelingCapable())
					{
						strFeedback = "Aircraft " + this.theUnit.Name + " is a tanker and the Air-to-Air Refuelling doctrine says that tankers are not allowed to refuel tankers. As such, the aircraft will not refuel. Change the doctrine setting and try again.";
						list2 = list;
					}
					else
					{
						int num = 0;
						int num2 = 2147483647;
						if (Information.IsNothing(MissionList) && !Information.IsNothing(this.theUnit.GetAssignedMission(false)) && this.theUnit.GetAssignedMission(false).TankerUsage == Mission.TankerMethod.Mission)
						{
							if (this.theUnit.GetAssignedMission(false).TankerMissionList.Count <= 0)
							{
								list2 = list;
								result = list2;
								return result;
							}
							MissionList = this.theUnit.GetAssignedMission(false).TankerMissionList;
						}
						if (!Information.IsNothing(this.theUnit.GetAssignedMission(false)) && !bool_1)
						{
							num = this.theUnit.GetAssignedMission(false).MaxReceiversInQueuePerTanker_Airborne;
							num2 = this.theUnit.GetAssignedMission(false).TankerMaxDistance_Airborne;
						}
						int num3 = 0;
						bool flag = this.GetAircraft().IsOperating();
						strFeedback = "No tankers are available.";
						List<ActiveUnit> list3;
						if (bool_1 && !Information.IsNothing(tanker_))
						{
							list3 = new List<ActiveUnit>();
							if (tanker_.IsGroup)
							{
								list3 = ((Group)tanker_).GetUnitsInGroup().Values.ToList<ActiveUnit>();
							}
							else
							{
								list3.Add(tanker_);
							}
						}
						else
						{
							list3 = this.GetAircraft().m_Scenario.GetActiveUnitList();
						}
						for (int i = list3.Count - 1; i >= 0; i += -1)
						{
							ActiveUnit activeUnit = list3[i];
							if (activeUnit != this.GetAircraft() && activeUnit.IsAircraft && (activeUnit.GetSide(false) == this.GetAircraft().GetSide(false) || activeUnit.GetSide(false).IsFriendlyToSide(this.GetAircraft().GetSide(false))))
							{
								Aircraft aircraft = (Aircraft)activeUnit;
								if (aircraft.IsAirRefuelingCapable() && activeUnit.IsOperating())
								{
									if (activeUnit.IsRTB())
									{
										if (num3 < 1)
										{
											num3 = 1;
											strFeedback = "Tanker is RTB.";
										}
									}
									else if (Information.IsNothing(this.GetRefuellingConnection(aircraft, this.GetAircraft())))
									{
										if (num3 < 2)
										{
											num3 = 2;
											strFeedback = "Aircraft has lacks compatible air-to-air refuelling (AAR) gear.";
										}
									}
									else
									{
										Doctrine._UseRefuel? useRefuelDoctrine2 = activeUnit.m_Doctrine.GetUseRefuelDoctrine(activeUnit.m_Scenario, false, false, false, false);
										b = (useRefuelDoctrine2.HasValue ? new byte?((byte)useRefuelDoctrine2.GetValueOrDefault()) : null);
										if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
										{
											if (num3 < 3)
											{
												num3 = 3;
												strFeedback = "Aircraft " + activeUnit.Name + " has a doctrine setting that DISALLOWS air-to-air refuelling. As such, refuelling will not be performed. Change the doctrine setting and try again.";
											}
										}
										else
										{
											if (this.GetAircraft().IsAirRefuelingCapable())
											{
												useRefuelDoctrine2 = activeUnit.m_Doctrine.GetUseRefuelDoctrine(activeUnit.m_Scenario, false, false, false, false);
												b = (useRefuelDoctrine2.HasValue ? new byte?((byte)useRefuelDoctrine2.GetValueOrDefault()) : null);
												if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
												{
													if (num3 < 4)
													{
														num3 = 4;
														strFeedback = string.Concat(new string[]
														{
															"Receiving aircraft ",
															this.GetAircraft().Name,
															" is a tanker and the Air-to-Air Refuelling doctrine for ",
															activeUnit.Name,
															" says that tankers are NOT allowed to refuel tankers. As such, the aircraft will not refuel. Change the doctrine setting and try again."
														});
														goto IL_AAD;
													}
													goto IL_AAD;
												}
											}
											if (activeUnit.GetSide(false) != this.GetAircraft().GetSide(false))
											{
												Doctrine._RefuelAlliedUnits? refuelAlliedUnitsDoctrine = activeUnit.m_Doctrine.GetRefuelAlliedUnitsDoctrine(activeUnit.m_Scenario, false, false, false);
												b = (refuelAlliedUnitsDoctrine.HasValue ? new byte?((byte)refuelAlliedUnitsDoctrine.GetValueOrDefault()) : null);
												if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
												{
													b = (refuelAlliedUnitsDoctrine.HasValue ? new byte?((byte)refuelAlliedUnitsDoctrine.GetValueOrDefault()) : null);
													if (!(b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
													{
														goto IL_5BC;
													}
												}
												if (num3 < 5)
												{
													num3 = 5;
													strFeedback = "Aircraft " + activeUnit.Name + " is an ALLIED tanker and is not allowed to refuel allied units.";
													goto IL_AAD;
												}
												goto IL_AAD;
											}
											IL_5BC:
											if (!activeUnit.CanRefuelOrUNREP(this.GetAircraft()))
											{
												if (num3 < 6)
												{
													num3 = 6;
													strFeedback = "Aircraft " + activeUnit.Name + " is a tanker but has the wrong refuelling gear (boom Vs. probe).";
												}
											}
											else
											{
												if (!Information.IsNothing(MissionList))
												{
													if (Information.IsNothing(activeUnit.GetAssignedMission(false)))
													{
														goto IL_AAD;
													}
													bool flag2 = true;
													for (int j = MissionList.Count - 1; j >= 0; j += -1)
													{
														Mission mission = MissionList[j];
														if (activeUnit.GetAssignedMission(false) == mission)
														{
															goto IL_6A7;
														}
													}
													if (flag2)
													{
														if (num3 >= 7)
														{
															goto IL_AAD;
														}
														num3 = 7;
														if (MissionList.Count == 1)
														{
															strFeedback = "Mission " + activeUnit.GetAssignedMission(false).Name + " has no available tankers.";
															goto IL_AAD;
														}
														strFeedback = "There are no available tankers on selected missions.";
														goto IL_AAD;
													}
												}
												IL_6A7:
												bool flag3 = false;
												Aircraft_AirOps aircraftAirOps = ((Aircraft)activeUnit).GetAircraftAirOps();
												if (aircraftAirOps.GetRefuellingQueue().Contains(this.GetAircraft().GetGuid()))
												{
													flag3 = true;
												}
												if (!bool_1 && flag && !flag3)
												{
													if (num > 0 && aircraftAirOps.GetRefuellingQueue().Count >= num)
													{
														if (num3 >= 8)
														{
															goto IL_AAD;
														}
														num3 = 8;
														if (!Information.IsNothing(MissionList) && MissionList.Count == 1)
														{
															strFeedback = "Tankers on mission " + MissionList[0].Name + " have full queues and cannot serve more receivers.";
															goto IL_AAD;
														}
														strFeedback = "Tankers have full queues and cannot serve more receivers.";
														goto IL_AAD;
													}
													else if (!Information.IsNothing(activeUnit.GetAssignedMission(false)) && activeUnit.GetAssignedMission(false).MissionClass == Mission._MissionClass.Support)
													{
														SupportMission supportMission = (SupportMission)activeUnit.GetAssignedMission(false);
														if (supportMission.A2AR_MaxNumberOfReceiversPerTanker > 0 && aircraftAirOps.A2AR_NumberOfReceiverHookups + aircraftAirOps.GetRefuellingQueue().Count + aircraftAirOps.GetA2ARCDictionary().Count >= supportMission.A2AR_MaxNumberOfReceiversPerTanker)
														{
															if (num3 >= 9)
															{
																goto IL_AAD;
															}
															num3 = 9;
															if (!Information.IsNothing(MissionList) && MissionList.Count == 1)
															{
																strFeedback = string.Concat(new string[]
																{
																	"Tankers on mission ",
																	MissionList[0].Name,
																	" are only allowed to serve ",
																	Conversions.ToString(supportMission.A2AR_MaxNumberOfReceiversPerTanker),
																	" receivers per tanker. None of the tankers can serve more receivers."
																});
																goto IL_AAD;
															}
															strFeedback = "Tankers are only allowed to serve " + Conversions.ToString(supportMission.A2AR_MaxNumberOfReceiversPerTanker) + " receivers per tanker. None of the available tankers can serve more receivers.";
															goto IL_AAD;
														}
													}
												}
												if (!activeUnit.HasEnoughFuelLeftAboardToServe(this.GetAircraft(), aircraftAirOps, 0.1f, flag3))
												{
													if (num3 < 10)
													{
														num3 = 10;
														if (!Information.IsNothing(MissionList) && MissionList.Count == 1)
														{
															strFeedback = "Tankers on mission " + MissionList[0].Name + " do not have enough fuel left aboard to serve more receivers.";
														}
														else
														{
															strFeedback = "Tankers do not have enough fuel left aboard to serve more receivers.";
														}
													}
												}
												else
												{
													float? num4 = null;
													if (!bool_1 && flag && !flag3 && num2 != 2147483647)
													{
														num4 = new float?(this.GetAircraft().GetHorizontalRange(activeUnit));
														float num5 = (float)num2;
														if ((num4.HasValue ? new bool?(num5 < num4.GetValueOrDefault()) : null).GetValueOrDefault())
														{
															if (num3 < 11)
															{
																num3 = 11;
																strFeedback = string.Concat(new string[]
																{
																	"Aircraft",
																	this.GetAircraft().Name,
																	" must be within ",
																	Conversions.ToString(num2),
																	" nm of a tanker to refuel, however the nearest tanker is ",
																	Conversions.ToString((int)Math.Round((double)num4.Value)),
																	" nm away"
																});
																goto IL_AAD;
															}
															goto IL_AAD;
														}
													}
													if (bool_2)
													{
														if (Information.IsNothing(num4))
														{
															num4 = new float?(this.GetAircraft().GetHorizontalRange(activeUnit));
														}
														ActiveUnit_AI aircraftAI = this.GetAircraft().GetAircraftAI();
														Unit theTargetUnit_ = activeUnit;
														float? rangeToTargetUnit_ = num4;
														Aircraft_Navigator aircraftNavigator = this.GetAircraft().GetAircraftNavigator();
														bool flag4 = false;
														float transitAltitude = aircraftNavigator.GetTransitAltitude(ref flag4);
														float? speed_ = null;
														float currentHeading = this.theUnit.GetCurrentHeading();
														float? nullable_ = new float?(0.15f);
														bool flag5 = false;
														if (!aircraftAI.CanReachTargetUnit(theTargetUnit_, rangeToTargetUnit_, transitAltitude, speed_, currentHeading, ActiveUnit.Throttle.Cruise, nullable_, true, true, ref flag5))
														{
															if (num3 < 12)
															{
																num3 = 12;
																strFeedback = "Aircraft" + this.GetAircraft().Name + " does not have enough fuel to reach a tanker. Alternatively, there are too many receivers in queue on tankers within range, and that there might not be enough fuel for more receivers.";
																goto IL_AAD;
															}
															goto IL_AAD;
														}
													}
													list.Add((Aircraft)activeUnit);
												}
											}
										}
									}
								}
							}
							IL_AAD:;
						}
						list2 = list;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200293", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				list2 = new List<Aircraft>();
				ProjectData.ClearProjectError();
			}
			result = list2;
			return result;
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x001E1E7C File Offset: 0x001E007C
		public bool CanRendezvousWith(Aircraft tanker_)
		{
			bool flag = false;
			bool result;
			try
			{
				if (this.GetAircraft().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling)
				{
					flag = true;
				}
				else
				{
					if (this.theUnit.GetNavigator().method_25())
					{
						double approxAngularDistanceInDegrees = this.GetAircraft().GetApproxAngularDistanceInDegrees(tanker_);
						double num = Math2.ApproxAngularDistance(this.GetAircraft().GetAircraftNavigator().GetPlottedCourse()[0].GetLatitude(), this.GetAircraft().GetAircraftNavigator().GetPlottedCourse()[0].GetLongitude(), this.GetAircraft().GetLatitude(null), this.GetAircraft().GetLongitude(null));
						if (Math2.ApproxAngularDistance(this.GetAircraft().GetAircraftNavigator().GetPlottedCourse()[0].GetLatitude(), this.GetAircraft().GetAircraftNavigator().GetPlottedCourse()[0].GetLongitude(), tanker_.GetLatitude(null), tanker_.GetLongitude(null)) < approxAngularDistanceInDegrees && approxAngularDistanceInDegrees > num)
						{
							flag = false;
							result = false;
							return result;
						}
					}
					ActiveUnit_AI aircraftAI = this.GetAircraft().GetAircraftAI();
					float? rangeToTargetUnit_ = null;
					Aircraft_Navigator aircraftNavigator = this.GetAircraft().GetAircraftNavigator();
					bool flag2 = false;
					float transitAltitude = aircraftNavigator.GetTransitAltitude(ref flag2);
					float? speed_ = null;
					float currentHeading = this.theUnit.GetCurrentHeading();
					float? nullable_ = new float?(0.25f);
					bool flag3 = false;
					if (aircraftAI.CanReachTargetUnit(tanker_, rangeToTargetUnit_, transitAltitude, speed_, currentHeading, ActiveUnit.Throttle.Cruise, nullable_, true, true, ref flag3))
					{
						this.GetAircraft().SetUnitStatus(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
						this.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel);
						this.method_27(tanker_);
						if (this.GetAircraft().HasParentGroup() && this.GetAircraft().GetParentGroup(false).GetGroupType() == Group.GroupType.AirGroup)
						{
							ActiveUnit groupLead = this.GetAircraft().GetParentGroup(false).GetGroupLead();
							((Aircraft)this.GetAircraft().GetParentGroup(false).GetGroupLead()).GetAircraftAirOps();
							if (!Information.IsNothing(tanker_))
							{
								foreach (ActiveUnit current in this.GetAircraft().GetParentGroup(false).GetUnitsInGroup().Values)
								{
									if (current != groupLead && current.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Refuelling && current.IsOperating())
									{
										Aircraft_AirOps aircraftAirOps = ((Aircraft)current).GetAircraftAirOps();
										current.SetUnitStatus(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
										aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel);
										aircraftAirOps.method_27(tanker_);
									}
								}
							}
						}
						flag = true;
					}
					else
					{
						flag = false;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100435", "");
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

		// Token: 0x06004C0E RID: 19470 RVA: 0x001E2194 File Offset: 0x001E0394
		public bool method_78(GeoPoint geoPoint_, Doctrine._RefuelSelection refuelSelection_, ref bool bool_1, ref ActiveUnit tanker_, ref List<Mission> list_0, ref string string_5, ref bool bool_2)
		{
			Aircraft_AirOps.Class102 @class = new Aircraft_AirOps.Class102(null);
			@class.aircraft_AirOps_0 = this;
			@class.geoPoint_0 = geoPoint_;
			bool flag = false;
			bool result;
			try
			{
				if (!this.GetAircraft().BoomRefuelling && !this.GetAircraft().ProbeRefuelling)
				{
					string_5 = "Aircraft lacks air-to-air refuelling (AAR) capability.";
					flag = false;
				}
				else if (!Information.IsNothing(tanker_) && Information.IsNothing(this.GetRefuellingConnection((Aircraft)tanker_, this.GetAircraft())))
				{
					string_5 = "Aircraft has lacks compatible air-to-air refuelling (AAR) gear.";
					flag = false;
				}
				else if (bool_1 && !Information.IsNothing(tanker_))
				{
					if (tanker_.IsGroup)
					{
						if (Information.IsNothing(((Group)tanker_).GetGroupLead()))
						{
							flag = false;
							result = false;
							return result;
						}
						tanker_ = ((Group)tanker_).GetGroupLead();
					}
					if (this.GetTankersForMe(ref bool_1, ref tanker_, true, list_0, ref string_5).Count == 0)
					{
						flag = false;
					}
					else if (this.CanRendezvousWith((Aircraft)tanker_))
					{
						flag = true;
					}
					else
					{
						string_5 = "Could not rendezvous with selected tanker.";
						flag = false;
					}
				}
				else if (this.GetAircraft().IsNotGroupLead() && this.GetAircraft().GetParentGroup(false).GetGroupType() == Group.GroupType.AirGroup)
				{
					if (this.theUnit.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && (this.theUnit.GetParentGroup(false).GetGroupLead().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint || this.theUnit.GetParentGroup(false).GetGroupLead().GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling))
					{
						flag = true;
					}
					else
					{
						Aircraft aircraft = (Aircraft)this.GetAircraft().GetParentGroup(false).GetGroupLead();
						if (aircraft.GetAircraftAirOps().method_78(@class.geoPoint_0, refuelSelection_, ref bool_1, ref tanker_, ref list_0, ref string_5, ref bool_2))
						{
							Aircraft a2ARefuelingDestinationAircraft = aircraft.GetAircraftAirOps().GetA2ARefuelingDestinationAircraft();
							if (!Information.IsNothing(a2ARefuelingDestinationAircraft))
							{
								foreach (ActiveUnit current in this.GetAircraft().GetParentGroup(false).GetUnitsInGroup().Values)
								{
									if (current != aircraft && current.IsOperating())
									{
										Aircraft_AirOps aircraftAirOps = ((Aircraft)current).GetAircraftAirOps();
										current.SetUnitStatus(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
										aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel);
										aircraftAirOps.method_27(a2ARefuelingDestinationAircraft);
									}
								}
							}
							flag = true;
						}
						else
						{
							flag = false;
						}
					}
				}
				else
				{
					ActiveUnit activeUnit = null;
					List<Aircraft> tankersForMe = this.GetTankersForMe(ref bool_1, ref activeUnit, true, list_0, ref string_5);
					if (tankersForMe.Count == 0)
					{
						flag = false;
					}
					else
					{
						bool arg_2C6_0;
						if (refuelSelection_ != Doctrine._RefuelSelection.const_1)
						{
							if (refuelSelection_ != Doctrine._RefuelSelection.const_2)
							{
								arg_2C6_0 = true;
								goto IL_2C6;
							}
						}
						arg_2C6_0 = !Information.IsNothing(@class.geoPoint_0);
						IL_2C6:
						if (!arg_2C6_0)
						{
							refuelSelection_ = Doctrine._RefuelSelection.const_0;
						}
						Doctrine._RefuelSelection refuelSelection = refuelSelection_;
						if (refuelSelection != Doctrine._RefuelSelection.const_0)
						{
							if (refuelSelection - Doctrine._RefuelSelection.const_1 <= 1)
							{
								if (!bool_2)
								{
									Aircraft_AirOps.Class101 class2 = new Aircraft_AirOps.Class101(null);
									class2.class102_0 = @class;
									class2.double_0 = this.GetAircraft().GetApproxAngularDistanceInDegrees(class2.class102_0.geoPoint_0);
									IEnumerable<Aircraft> source = tankersForMe.Where(new Func<Aircraft, bool>(class2.method_0));
									if (source.Count<Aircraft>() > 0)
									{
										IEnumerable<Aircraft> enumerable = source.OrderBy(new Func<Aircraft, int>(this.method_92));
										using (IEnumerator<Aircraft> enumerator2 = enumerable.GetEnumerator())
										{
											while (enumerator2.MoveNext())
											{
												Aircraft current2 = enumerator2.Current;
												if (this.CanRendezvousWith(current2))
												{
													flag = true;
													result = true;
													return result;
												}
											}
											goto IL_440;
										}
									}
									if (refuelSelection_ == Doctrine._RefuelSelection.const_2)
									{
										IEnumerable<Aircraft> enumerable = tankersForMe.OrderBy(new Func<Aircraft, int>(this.method_93));
										foreach (Aircraft current3 in enumerable)
										{
											double approxAngularDistanceInDegrees = this.GetAircraft().GetApproxAngularDistanceInDegrees(current3);
											double approxAngularDistanceInDegrees2 = current3.GetApproxAngularDistanceInDegrees(class2.class102_0.geoPoint_0);
											if (approxAngularDistanceInDegrees < class2.double_0 && approxAngularDistanceInDegrees2 < class2.double_0 && this.CanRendezvousWith(current3))
											{
												flag = true;
												result = true;
												return result;
											}
										}
									}
									IL_440:
									if (this.theUnit.GetNavigator().method_25() || (this.theUnit.IsNotGroupLead() && !Information.IsNothing(this.theUnit.GetParentGroup(false).GetGroupLead()) && this.theUnit.GetParentGroup(false).GetGroupLead().GetNavigator().method_25()))
									{
										flag = false;
										result = false;
										return result;
									}
								}
								else
								{
									Aircraft_AirOps.Class104 class3 = new Aircraft_AirOps.Class104(null);
									class3.class102_0 = @class;
									class3.activeUnit_0 = this.GetAssignedHostUnit();
									if (Information.IsNothing(class3.activeUnit_0))
									{
										IEnumerable<Aircraft> enumerable = tankersForMe.OrderBy(new Func<Aircraft, int>(this.method_94));
										using (IEnumerator<Aircraft> enumerator4 = enumerable.GetEnumerator())
										{
											while (enumerator4.MoveNext())
											{
												Aircraft current4 = enumerator4.Current;
												if (this.CanRendezvousWith(current4))
												{
													flag = true;
													result = true;
													return result;
												}
											}
											goto IL_709;
										}
									}
									Aircraft_AirOps.Class103 class4 = new Aircraft_AirOps.Class103(null);
									class4.class104_0 = class3;
									class4.double_0 = this.GetAircraft().GetApproxAngularDistanceInDegrees(class4.class104_0.activeUnit_0);
									IEnumerable<Aircraft> source2 = tankersForMe.Where(new Func<Aircraft, bool>(class4.method_0)).OrderBy(new Func<Aircraft, double>(this.method_95));
									if (source2.Count<Aircraft>() > 0)
									{
										IEnumerable<Aircraft> enumerable = source2.OrderBy(new Func<Aircraft, int>(this.method_96));
										using (IEnumerator<Aircraft> enumerator5 = enumerable.GetEnumerator())
										{
											while (enumerator5.MoveNext())
											{
												Aircraft current5 = enumerator5.Current;
												if (this.CanRendezvousWith(current5))
												{
													flag = true;
													result = true;
													return result;
												}
											}
											goto IL_709;
										}
									}
									if (refuelSelection_ == Doctrine._RefuelSelection.const_2)
									{
										ActiveUnit._ActiveUnitFuelState activeUnitFuelState = this.GetAircraft().GetActiveUnitFuelState(class4.class104_0.activeUnit_0, null);
										if (activeUnitFuelState != ActiveUnit._ActiveUnitFuelState.IsBingo && activeUnitFuelState != ActiveUnit._ActiveUnitFuelState.IsJoker)
										{
											flag = false;
											result = false;
											return result;
										}
										IEnumerable<Aircraft> enumerable = tankersForMe.OrderBy(new Func<Aircraft, int>(this.method_97));
										foreach (Aircraft current6 in enumerable)
										{
											if (this.theUnit.GetApproxAngularDistanceInDegrees(current6) < class4.double_0 && this.CanRendezvousWith(current6))
											{
												flag = true;
												result = true;
												return result;
											}
										}
										flag = false;
										result = false;
										return result;
									}
								}
							}
						}
						else
						{
							IEnumerable<Aircraft> enumerable = tankersForMe.OrderBy(new Func<Aircraft, int>(this.method_91));
							foreach (Aircraft current7 in enumerable)
							{
								if (this.CanRendezvousWith(current7))
								{
									flag = true;
									result = true;
									return result;
								}
							}
						}
						IL_709:
						if (refuelSelection_ != Doctrine._RefuelSelection.const_1)
						{
							IEnumerable<Aircraft> enumerable2 = tankersForMe.OrderBy(new Func<Aircraft, double>(this.method_98));
							foreach (Aircraft current8 in enumerable2)
							{
								if (this.CanRendezvousWith(current8))
								{
									flag = true;
									result = true;
									return result;
								}
							}
						}
						string_5 = "Could not find suitable tanker.";
						flag = false;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100436", "");
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

		// Token: 0x06004C0F RID: 19471 RVA: 0x001E2A34 File Offset: 0x001E0C34
		private int method_79(Aircraft aircraft_3)
		{
			float val = this.GetAircraft().method_49(this.GetAircraft().GetCurrentSpeed(), this.GetAircraft().HorizontalRangeTo(aircraft_3.GetLatitude(null), aircraft_3.GetLongitude(null)));
			Aircraft_AirOps aircraftAirOps = aircraft_3.GetAircraftAirOps();
			List<string> list = aircraftAirOps.GetRefuellingQueue().ToList<string>();
            string currentX;

            foreach (string current in list)
			{
				Aircraft aircraft = (Aircraft)this.GetAircraft().m_Scenario.GetActiveUnits()[current];
				if (Information.IsNothing(aircraft) || aircraft.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint)
				{
                    currentX = current;
                    aircraftAirOps.GetRefuellingQueue().TryTake(out currentX);
				}
			}
			float num = 0f;
			foreach (string current2 in list)
			{
				Aircraft aircraft2 = (Aircraft)this.GetAircraft().m_Scenario.GetActiveUnits()[current2];
				if (!aircraft2.IsNotActive())
				{
					Aircraft_AirOps._RefuellingConnection? refuellingConnection = this.GetRefuellingConnection(aircraft_3, aircraft2);
					float num2 = this.method_45(aircraft2, refuellingConnection);
					float num3 = (float)aircraft2.GetFuelRecsMaxQuantity() / num2;
					num += num3;
				}
			}
			return (int)Math.Round((double)Math.Max(val, num));
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x001E2BBC File Offset: 0x001E0DBC
		public bool ManoeuveringToRefuel(bool bool_1)
		{
            bool flag = false;
            try
            {
                if (!(bool_1 || (this.GetAircraft().GetHorizontalRange(this.GetA2ARefuelingDestinationAircraft()) <= this.float_3)))
                {
                    return false;
                }
                if (this.GetA2ARefuelingDestinationAircraft().GetAircraftAirOps().method_85(this.GetAircraft(), bool_1))
                {
                    this.method_81(bool_1);
                    return true;
                }
                if (this.GetAircraft().HasParentGroup())
                {
                    using (IEnumerator<ActiveUnit> enumerator = this.GetAircraft().GetParentGroup(false).GetUnitsInGroup().Values.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            ActiveUnit current = enumerator.Current;
                            if ((current.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling) && (((Aircraft)current).GetAircraftAirOps().GetA2ARefuelingDestinationAircraft() == this.GetA2ARefuelingDestinationAircraft()))
                            {
                                goto Label_00C1;
                            }
                        }
                        return flag;
                    Label_00C1:
                        this.method_81(bool_1);
                        return true;
                    }
                }
                flag = false;
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                Exception exception2 = exception;
                exception2.Data.Add("Error at 100437", "");
                GameGeneral.LogException(ref exception2);
                if (Debugger.IsAttached)
                {
                    Debugger.Break();
                }
                ProjectData.ClearProjectError();
            }
            return flag;

        }

        // Token: 0x06004C11 RID: 19473 RVA: 0x001E2D00 File Offset: 0x001E0F00
        private void method_81(bool bool_1)
		{
			try
			{
				Aircraft_AirOps aircraftAirOps = this.GetA2ARefuelingDestinationAircraft().GetAircraftAirOps();
				if (Information.IsNothing(this.GetAircraft()))
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				else if (string.IsNullOrEmpty(this.GetAircraft().GetGuid()) && Debugger.IsAttached)
				{
					Debugger.Break();
				}
				if (this.GetAircraft().BoomRefuelling)
				{
					if (!aircraftAirOps.GetA2ARCDictionary().ContainsKey(this.GetAircraft().GetGuid()))
					{
						aircraftAirOps.GetA2ARCDictionary().TryAdd(this.GetAircraft().GetGuid(), Aircraft_AirOps._RefuellingConnection.Boom);
					}
					else
					{
						aircraftAirOps.GetA2ARCDictionary()[this.GetAircraft().GetGuid()] = Aircraft_AirOps._RefuellingConnection.Boom;
					}
					this.GetAircraft().SetUnitStatus(ActiveUnit._ActiveUnitStatus.Refuelling);
					aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.OffloadingFuel);
					if (aircraftAirOps.GetRefuellingQueue().Contains(this.GetAircraft().GetGuid()))
					{
						ConcurrentBag<string> refuellingQueue = aircraftAirOps.GetRefuellingQueue();
						string guid = this.GetAircraft().GetGuid();
						refuellingQueue.TryTake(out guid);
					}
				}
				else if (this.GetAircraft().ProbeRefuelling)
				{
					if (!aircraftAirOps.GetA2ARCDictionary().ContainsKey(this.GetAircraft().GetGuid()))
					{
						if (this.GetA2ARefuelingDestinationAircraft().HasBuddyStoreWeapon())
						{
							aircraftAirOps.GetA2ARCDictionary().TryAdd(this.GetAircraft().GetGuid(), Aircraft_AirOps._RefuellingConnection.BuddyStore);
						}
						else
						{
							aircraftAirOps.GetA2ARCDictionary().TryAdd(this.GetAircraft().GetGuid(), Aircraft_AirOps._RefuellingConnection.Probe);
						}
					}
					else if (this.GetA2ARefuelingDestinationAircraft().HasBuddyStoreWeapon())
					{
						aircraftAirOps.GetA2ARCDictionary()[this.GetAircraft().GetGuid()] = Aircraft_AirOps._RefuellingConnection.BuddyStore;
					}
					else
					{
						aircraftAirOps.GetA2ARCDictionary()[this.GetAircraft().GetGuid()] = Aircraft_AirOps._RefuellingConnection.Probe;
					}
					this.GetAircraft().SetUnitStatus(ActiveUnit._ActiveUnitStatus.Refuelling);
					aircraftAirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.OffloadingFuel);
					if (aircraftAirOps.GetRefuellingQueue().Contains(this.GetAircraft().GetGuid()))
					{
						ConcurrentBag<string> refuellingQueue2 = aircraftAirOps.GetRefuellingQueue();
						string guid = this.GetAircraft().GetGuid();
						refuellingQueue2.TryTake(out guid);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100438", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x001E2F68 File Offset: 0x001E1168
		private Aircraft_AirOps._RefuellingConnection? GetRefuellingConnection(Aircraft theTanker_, Aircraft theReceiver_)
		{
			Aircraft_AirOps._RefuellingConnection? result;
			if (theReceiver_.BoomRefuelling && theTanker_.CenterlineBoom)
			{
				result = new Aircraft_AirOps._RefuellingConnection?(Aircraft_AirOps._RefuellingConnection.Boom);
			}
			else if (theReceiver_.ProbeRefuelling && (theTanker_.CenterlineDrogue || theTanker_.WingDrogue))
			{
				result = new Aircraft_AirOps._RefuellingConnection?(Aircraft_AirOps._RefuellingConnection.Probe);
			}
			else if (theTanker_.HasBuddyStoreWeapon() && theReceiver_.ProbeRefuelling)
			{
				result = new Aircraft_AirOps._RefuellingConnection?(Aircraft_AirOps._RefuellingConnection.BuddyStore);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06004C13 RID: 19475 RVA: 0x001E2FEC File Offset: 0x001E11EC
		private bool method_83(Aircraft aircraft_3, bool bool_1)
		{
			bool flag = false;
			bool result;
			try
			{
				if (aircraft_3.BoomRefuelling)
				{
					if (bool_1 && aircraft_3.IsNotGroupLead())
					{
						flag = true;
					}
					else if (this.GetAircraft().CenterlineBoom)
					{
						foreach (KeyValuePair<string, Aircraft_AirOps._RefuellingConnection> current in this.GetA2ARCDictionary())
						{
							if (current.Value == Aircraft_AirOps._RefuellingConnection.Boom)
							{
								flag = false;
								result = false;
								return result;
							}
						}
						flag = true;
					}
					else
					{
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100439", "");
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

		// Token: 0x06004C14 RID: 19476 RVA: 0x001E30D8 File Offset: 0x001E12D8
		private bool method_84(Aircraft aircraft_3, bool bool_1)
		{
			bool result = false;
			try
			{
				if (aircraft_3.ProbeRefuelling)
				{
					if (bool_1 && aircraft_3.IsNotGroupLead())
					{
						result = true;
					}
					else
					{
						int num = 0;
						if (this.GetAircraft().HasBuddyStoreWeapon())
						{
							num++;
						}
						if (this.GetAircraft().CenterlineDrogue)
						{
							num++;
						}
						if (this.GetAircraft().WingDrogue)
						{
							num += 2;
						}
						if (num > 0)
						{
							int num2 = 0;
							foreach (KeyValuePair<string, Aircraft_AirOps._RefuellingConnection> current in this.GetA2ARCDictionary())
							{
								if (current.Value == Aircraft_AirOps._RefuellingConnection.Probe)
								{
									num2++;
								}
							}
							result = (num > num2);
						}
					}
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100440", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x001E3200 File Offset: 0x001E1400
		public bool method_85(Aircraft targetAircraft_, bool bool_1)
		{
			bool flag = false;
			bool result;
			try
			{
				if (!this.GetAircraft().IsAirRefuelingCapable())
				{
					flag = false;
				}
				else if (!this.GetAircraft().CanRefuelOrUNREP(targetAircraft_))
				{
					flag = false;
				}
				else
				{
					if (!bool_1)
					{
						List<string> list = new List<string>();
						bool flag2 = true;
						foreach (KeyValuePair<string, Aircraft_AirOps._RefuellingConnection> current in this.GetA2ARCDictionary())
						{
							if (!Information.IsNothing(current.Key))
							{
								Aircraft aircraft = (Aircraft)this.GetAircraft().m_Scenario.GetActiveUnits()[current.Key];
								if (Information.IsNothing(aircraft))
								{
									list.Add(current.Key);
								}
								else if (aircraft.aircraftSizeClass >= GlobalVariables.AircraftSizeClass.Large)
								{
									flag2 = false;
									break;
								}
							}
						}
						foreach (string current2 in list)
						{
							ConcurrentDictionary<string, Aircraft_AirOps._RefuellingConnection> a2ARCDictionary = this.GetA2ARCDictionary();
							string key = current2;
							Aircraft_AirOps._RefuellingConnection refuellingConnection = Aircraft_AirOps._RefuellingConnection.Probe;
							a2ARCDictionary.TryRemove(key, out refuellingConnection);
						}
						if (!flag2)
						{
							flag = false;
							result = false;
							return result;
						}
					}
					flag = (this.method_83(targetAircraft_, bool_1) || this.method_84(targetAircraft_, bool_1));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100441", "");
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

		// Token: 0x06004C16 RID: 19478 RVA: 0x001E33D8 File Offset: 0x001E15D8
		public void method_86()
		{
			if (this.theUnit.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps) && this.theUnit.m_OnboardCargos.Any(Aircraft_AirOps.CargoFunc26))
			{
				List<Facility> list = Facility.smethod_1(this.theUnit.m_OnboardCargos.Where(Aircraft_AirOps.CargoFunc27).Select(Aircraft_AirOps.CargoFunc28).ToList<Mount>(), this.theUnit.m_Scenario, this.theUnit.GetSide(false));
				foreach (Facility current in list)
				{
					current.SetLongitude(null, this.theUnit.GetLongitude(null));
					current.SetLatitude(null, this.theUnit.GetLatitude(null));
				}
				ScenarioArrayUtil.NewCargoArray(ref this.theUnit.m_OnboardCargos);
			}
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x001E34F0 File Offset: 0x001E16F0
		public void method_87()
		{
			if (this.theUnit.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps))
			{
				List<Facility> list = Facility.smethod_1(this.theUnit.m_OnboardCargos.Select(Aircraft_AirOps.CargoFunc29).ToList<Mount>(), this.theUnit.m_Scenario, this.theUnit.GetSide(false));
				foreach (Facility current in list)
				{
					current.SetLongitude(null, this.theUnit.GetLongitude(null));
					current.SetLatitude(null, this.theUnit.GetLatitude(null));
				}
				ScenarioArrayUtil.NewCargoArray(ref this.theUnit.m_OnboardCargos);
			}
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x001E35E4 File Offset: 0x001E17E4
		public int GetEstimatedRepairTimeInSeconds()
		{
			int num = 0;
			switch (this.GetAircraft().GetAircraftDamage().GetFireIntensityLevel())
			{
			case ActiveUnit_Damage.FireIntensityLevel.Minor:
				num = 900;
				break;
			case ActiveUnit_Damage.FireIntensityLevel.Major:
				num = 1800;
				break;
			case ActiveUnit_Damage.FireIntensityLevel.Severe:
				num = 2700;
				break;
			case ActiveUnit_Damage.FireIntensityLevel.Conflagration:
				num = 3600;
				break;
			}
			int num2 = (int)Math.Round((double)(this.GetAircraft().GetAircraftDamage().GetDamagePts() / 100f * 86400f));
			switch (this.GetAircraft().aircraftSizeClass)
			{
			case GlobalVariables.AircraftSizeClass.Medium:
				num2 = (int)Math.Round((double)num2 * 1.5);
				break;
			case GlobalVariables.AircraftSizeClass.Large:
				num2 *= 2;
				break;
			case GlobalVariables.AircraftSizeClass.VLarge:
				num2 *= 3;
				break;
			}
			int num3 = 0;
			foreach (PlatformComponent current in this.GetAircraft().GetAllPlatformComponents())
			{
				if (current.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
				{
					if (current.IsCargo())
					{
						if (current.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
						{
							num3 += 3600;
						}
						else
						{
							switch (current.GetDamageSeverity())
							{
							case PlatformComponent._DamageSeverityFactor.Light:
								num3 += 900;
								break;
							case PlatformComponent._DamageSeverityFactor.Medium:
								num3 += 1800;
								break;
							case PlatformComponent._DamageSeverityFactor.Heavy:
								num3 += 2700;
								break;
							}
						}
					}
					else if (current.IsCIC())
					{
						if (current.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
						{
							num3 += 10800;
						}
						else
						{
							switch (current.GetDamageSeverity())
							{
							case PlatformComponent._DamageSeverityFactor.Light:
								num3 += 2700;
								break;
							case PlatformComponent._DamageSeverityFactor.Medium:
								num3 += 5400;
								break;
							case PlatformComponent._DamageSeverityFactor.Heavy:
								num3 += 8100;
								break;
							}
						}
					}
					else if (!current.IsCommDevice() && !current.IsSensor() && !current.IsMount())
					{
						if (current.IsEngine())
						{
							if (current.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
							{
								num3 += 14400;
							}
							else
							{
								switch (current.GetDamageSeverity())
								{
								case PlatformComponent._DamageSeverityFactor.Light:
									num3 += 3600;
									break;
								case PlatformComponent._DamageSeverityFactor.Medium:
									num3 += 7200;
									break;
								case PlatformComponent._DamageSeverityFactor.Heavy:
									num3 += 10800;
									break;
								}
							}
						}
					}
					else if (current.GetComponentStatus() == PlatformComponent._ComponentStatus.Destroyed)
					{
						num3 += 14400;
					}
					else
					{
						switch (current.GetDamageSeverity())
						{
						case PlatformComponent._DamageSeverityFactor.Light:
							num3 += 3600;
							break;
						case PlatformComponent._DamageSeverityFactor.Medium:
							num3 += 7200;
							break;
						case PlatformComponent._DamageSeverityFactor.Heavy:
							num3 += 10800;
							break;
						}
					}
				}
			}
			return num + num2 + num3;
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x001E38F0 File Offset: 0x001E1AF0
		[CompilerGenerated]
		private double GetAngularDistance(ActiveUnit activeUnit_)
		{
			return activeUnit_.GetApproxAngularDistanceInDegrees(this.theUnit);
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x001E390C File Offset: 0x001E1B0C
		[CompilerGenerated]
		private double GetAngularDistanceToHostAirFacility(ActiveUnit activeUnit_)
		{
			return activeUnit_.GetApproxAngularDistanceInDegrees(this.HostAirFacility.GetParentPlatform());
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x001E392C File Offset: 0x001E1B2C
		[CompilerGenerated]
		private int method_91(Aircraft aircraft_3)
		{
			return this.method_79(aircraft_3);
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x001E392C File Offset: 0x001E1B2C
		[CompilerGenerated]
		private int method_92(Aircraft aircraft_3)
		{
			return this.method_79(aircraft_3);
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x001E392C File Offset: 0x001E1B2C
		[CompilerGenerated]
		private int method_93(Aircraft aircraft_3)
		{
			return this.method_79(aircraft_3);
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x001E392C File Offset: 0x001E1B2C
		[CompilerGenerated]
		private int method_94(Aircraft aircraft_3)
		{
			return this.method_79(aircraft_3);
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x001E3944 File Offset: 0x001E1B44
		[CompilerGenerated]
		private double method_95(Aircraft aircraft_3)
		{
			return aircraft_3.GetApproxAngularDistanceInDegrees(this.GetAircraft());
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x001E392C File Offset: 0x001E1B2C
		[CompilerGenerated]
		private int method_96(Aircraft aircraft_3)
		{
			return this.method_79(aircraft_3);
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x001E392C File Offset: 0x001E1B2C
		[CompilerGenerated]
		private int method_97(Aircraft aircraft_3)
		{
			return this.method_79(aircraft_3);
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x001E3944 File Offset: 0x001E1B44
		[CompilerGenerated]
		private double method_98(Aircraft aircraft_3)
		{
			return aircraft_3.GetApproxAngularDistanceInDegrees(this.GetAircraft());
		}

		// Token: 0x0400237E RID: 9086
		public static Func<Sensor, bool> SensorFunc0 = (Sensor sensor_0) => sensor_0.IsRadarSonarVisual(true, false);

		// Token: 0x0400237F RID: 9087
		public static Func<Sensor, float> SensorFunc1 = (Sensor sensor_0) => sensor_0.MaxRange;

		// Token: 0x04002380 RID: 9088
		public static Func<Cargo, int> CargoFunc2 = (Cargo cargo_0) => ActiveUnit_DockingOps.lazy_0.Value.Next();

		// Token: 0x04002381 RID: 9089
		public static Func<ActiveUnit, double> ActiveUnitFunc3 = (ActiveUnit activeUnit_0) => Aircraft_AirOps.method_2(activeUnit_0);

		// Token: 0x04002382 RID: 9090
		public new static Func<AirFacility, GlobalVariables.AircraftSizeClass> AirFacilityFunc4 = (AirFacility airFacility_0) => airFacility_0.GetAircraftSizeClass();

		// Token: 0x04002383 RID: 9091
		public new static Func<AirFacility, bool> AirFacilityFunc5 = (AirFacility airFacility_0) => airFacility_0.IsRunwayAccessPointOrElevator() && airFacility_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x04002384 RID: 9092
		public new static Func<AirFacility, bool> AirFacilityFunc6 = (AirFacility airFacility_0) => airFacility_0.GetHostedAircrafts().Count >= airFacility_0.Capacity;

		// Token: 0x04002385 RID: 9093
		public static Func<AirFacility, GlobalVariables.AircraftSizeClass> AirFacilityFunc7 = (AirFacility airFacility_0) => airFacility_0.GetAircraftSizeClass();

		// Token: 0x04002386 RID: 9094
		public static Func<AirFacility, GlobalVariables.AircraftSizeClass> AirFacilityFunc8 = (AirFacility airFacility_0) => airFacility_0.GetAircraftSizeClass();

		// Token: 0x04002387 RID: 9095
		public static Func<AirFacility, GlobalVariables.AircraftSizeClass> AirFacilityFunc9 = (AirFacility airFacility_0) => airFacility_0.GetAircraftSizeAfterDamage();

		// Token: 0x04002388 RID: 9096
		public static Func<AirFacility, GlobalVariables.AircraftSizeClass> AirFacilityFunc10 = (AirFacility airFacility_0) => airFacility_0.GetAircraftSizeClass();

		// Token: 0x04002389 RID: 9097
		public static Func<AirFacility, GlobalVariables.AircraftSizeClass> AirFacilityFunc11 = (AirFacility airFacility_0) => airFacility_0.GetAircraftSizeAfterDamage();

		// Token: 0x0400238A RID: 9098
		public static Func<AirFacility, bool> AirFacilityFunc12 = (AirFacility airFacility_0) => airFacility_0.IsRunwayAccessPointOrElevator() && airFacility_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x0400238B RID: 9099
		public static Func<AirFacility, bool> AirFacilityFunc13 = (AirFacility airFacility_0) => airFacility_0.GetHostedAircrafts().Count >= airFacility_0.Capacity;

		// Token: 0x0400238C RID: 9100
		public static Func<AirFacility, GlobalVariables.AircraftSizeClass> AirFacilityFunc14 = (AirFacility airFacility_0) => airFacility_0.GetAircraftSizeClass();

		// Token: 0x0400238D RID: 9101
		public static Func<AirFacility, GlobalVariables.AircraftSizeClass> AirFacilityFunc15 = (AirFacility airFacility_0) => airFacility_0.GetAircraftSizeAfterDamage();

		// Token: 0x0400238E RID: 9102
		public static Func<AirFacility, bool> AirFacilityFunc16 = (AirFacility airFacility_0) => airFacility_0.IsAircraftCarrierCatapult() && airFacility_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x0400238F RID: 9103
		public static Func<AirFacility, bool> AirFacilityFunc17 = (AirFacility airFacility_0) => !airFacility_0.GetHostedAircrafts().IsEmpty;

		// Token: 0x04002390 RID: 9104
		public static Func<AirFacility, bool> AirFacilityFunc18 = (AirFacility airFacility_0) => airFacility_0.IsTakeOffOrLandingFacility() && airFacility_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x04002391 RID: 9105
		public static Func<AirFacility, bool> AirFacilityFunc19 = (AirFacility airFacility_0) => !airFacility_0.GetHostedAircrafts().IsEmpty;

		// Token: 0x04002392 RID: 9106
		public static Func<AirFacility, bool> AirFacilityFunc20 = (AirFacility airFacility_0) => airFacility_0.IsRunwayAccessPointOrElevator() && airFacility_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x04002393 RID: 9107
		public static Func<AirFacility, bool> AirFacilityFunc21 = (AirFacility airFacility_0) => airFacility_0.GetHostedAircrafts().Count >= airFacility_0.Capacity;

		// Token: 0x04002394 RID: 9108
		public static Func<AirFacility, GlobalVariables.AircraftSizeClass> AirFacilityFunc22 = (AirFacility airFacility_0) => airFacility_0.GetAircraftSizeClass();

		// Token: 0x04002395 RID: 9109
		public static Func<AirFacility, bool> AirFacilityFunc23 = (AirFacility airFacility_0) => airFacility_0.IsRunwayAccessPointOrElevator() && airFacility_0.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed;

		// Token: 0x04002396 RID: 9110
		public static Func<AirFacility, bool> AirFacilityFunc24 = (AirFacility airFacility_0) => airFacility_0.GetHostedAircrafts().Count >= airFacility_0.Capacity;

		// Token: 0x04002397 RID: 9111
		public static Func<AirFacility, GlobalVariables.AircraftSizeClass> AirFacilityFunc25 = (AirFacility airFacility_0) => airFacility_0.GetAircraftSizeClass();

		// Token: 0x04002398 RID: 9112
		public static Func<Cargo, bool> CargoFunc26 = (Cargo cargo_0) => ((Mount)cargo_0.GetCargo()).Cargo_ParadropCapable;

		// Token: 0x04002399 RID: 9113
		public static Func<Cargo, bool> CargoFunc27 = (Cargo cargo_0) => ((Mount)cargo_0.GetCargo()).Cargo_ParadropCapable;

		// Token: 0x0400239A RID: 9114
		public static Func<Cargo, Mount> CargoFunc28 = (Cargo cargo_0) => (Mount)cargo_0.GetCargo();

		// Token: 0x0400239B RID: 9115
		public static Func<Cargo, Mount> CargoFunc29 = (Cargo cargo_0) => (Mount)cargo_0.GetCargo();

		// Token: 0x0400239C RID: 9116
		private Aircraft_AirOps._AirOpsCondition AirOpsCondition;

		// Token: 0x0400239D RID: 9117
		private float ConditionTimer;

		// Token: 0x0400239E RID: 9118
		private AirFacility HostAirFacility;

		// Token: 0x0400239F RID: 9119
		private string HostAirFacilityID;

		// Token: 0x040023A0 RID: 9120
		private ActiveUnit CurrentHostUnit;

		// Token: 0x040023A1 RID: 9121
		private string ParentAircraftID = "";

		// Token: 0x040023A2 RID: 9122
		private ActiveUnit AssignedHostUnit;

		// Token: 0x040023A3 RID: 9123
		private string string_3 = "";

		// Token: 0x040023A4 RID: 9124
		private Aircraft A2ARefuelingDestinationAircraft;

		// Token: 0x040023A5 RID: 9125
		private string A2AR_Destination = "";

		// Token: 0x040023A6 RID: 9126
		private Lazy<ConcurrentBag<string>> RefuellingQueue;

		// Token: 0x040023A7 RID: 9127
		private Lazy<ConcurrentDictionary<string, Aircraft_AirOps._RefuellingConnection>> lazyA2ARefuelingConnectionDictionary;

		// Token: 0x040023A8 RID: 9128
		public int A2AR_NumberOfReceiverHookups;

		// Token: 0x040023A9 RID: 9129
		public bool QuickTurnaround_Enabled;

		// Token: 0x040023AA RID: 9130
		public int QuickTurnaround_SortiesFlown;

		// Token: 0x040023AB RID: 9131
		public int QuickTurnaround_SortiesTotal = 0;

		// Token: 0x040023AC RID: 9132
		public int QuickTurnaround_TimePentalty = 0;

		// Token: 0x040023AD RID: 9133
		public float QuickTurnaround_AirborneTime_Flown;

		// Token: 0x040023AE RID: 9134
		public float QuickTurnaround_AirborneTime_SortieAverage = 0f;

		// Token: 0x040023AF RID: 9135
		public float float_3;

		// Token: 0x040023B0 RID: 9136
		public float float_4 = 0f;

		// Token: 0x040023B1 RID: 9137
		[CompilerGenerated]
		private static Aircraft_AirOps.Delegate6 delegate6_0;

		// Token: 0x040023B2 RID: 9138
		[CompilerGenerated]
		private static Aircraft_AirOps.Delegate7 delegate7_0;

		// Token: 0x040023B3 RID: 9139
		private Aircraft theAircraft;

		// Token: 0x020009E8 RID: 2536
		// (Invoke) Token: 0x06004C43 RID: 19523
		public delegate void Delegate6(Aircraft theAircraft);

		// Token: 0x020009E9 RID: 2537
		// (Invoke) Token: 0x06004C47 RID: 19527
		public delegate void Delegate7(Aircraft theAircraft);

		// Token: 0x020009EA RID: 2538
		private enum Enum13 : byte
		{
			// Token: 0x040023D3 RID: 9171
			const_0,
			// Token: 0x040023D4 RID: 9172
			const_1,
			// Token: 0x040023D5 RID: 9173
			const_2
		}

		// Token: 0x020009EB RID: 2539
		public enum _AirOpsCondition : byte
		{
			// Token: 0x040023D7 RID: 9175
			Airborne,
			// Token: 0x040023D8 RID: 9176
			Parked,
			// Token: 0x040023D9 RID: 9177
			TaxyingToTakeOff,
			// Token: 0x040023DA RID: 9178
			TaxyingToPark,
			// Token: 0x040023DB RID: 9179
			TakingOff,
			// Token: 0x040023DC RID: 9180
			Landing_PreTouchdown,
			// Token: 0x040023DD RID: 9181
			Landing_PostTouchdown,
			// Token: 0x040023DE RID: 9182
			Readying,
			// Token: 0x040023DF RID: 9183
			HoldingForAvailableTransit,
			// Token: 0x040023E0 RID: 9184
			HoldingForAvailableRunway,
			// Token: 0x040023E1 RID: 9185
			HoldingOnLandingQueue,
			// Token: 0x040023E2 RID: 9186
			RTB,
			// Token: 0x040023E3 RID: 9187
			PreparingToLaunch,
			// Token: 0x040023E4 RID: 9188
			ManoeuveringToRefuel,
			// Token: 0x040023E5 RID: 9189
			Refuelling,
			// Token: 0x040023E6 RID: 9190
			OffloadingFuel,
			// Token: 0x040023E7 RID: 9191
			DeployingDippingSonar,
			// Token: 0x040023E8 RID: 9192
			EmergencyLanding,
			// Token: 0x040023E9 RID: 9193
			TaxyingToFlightDeck,
			// Token: 0x040023EA RID: 9194
			BVRAttack,
			// Token: 0x040023EB RID: 9195
			BVRCrank,
			// Token: 0x040023EC RID: 9196
			Dogfight,
			// Token: 0x040023ED RID: 9197
			DeployingCargo
		}

		// Token: 0x020009EC RID: 2540
		public enum _RefuellingConnection : byte
		{
			// Token: 0x040023EF RID: 9199
			Probe,
			// Token: 0x040023F0 RID: 9200
			Boom,
			// Token: 0x040023F1 RID: 9201
			BuddyStore
		}

		// Token: 0x020009ED RID: 2541
		public enum _Maintenance : byte
		{
			// Token: 0x040023F3 RID: 9203
			const_0,
			// Token: 0x040023F4 RID: 9204
			const_1,
			// Token: 0x040023F5 RID: 9205
			Unavailable,
			// Token: 0x040023F6 RID: 9206
			ReserveLoadout,
			// Token: 0x040023F7 RID: 9207
			const_4
		}

		// Token: 距离测量
		[CompilerGenerated]
		public sealed class MeasureDistanceFromAssignedHostUnit
		{
			// Token: 0x06004C4A RID: 19530 RVA: 0x000245ED File Offset: 0x000227ED
			public MeasureDistanceFromAssignedHostUnit(Aircraft_AirOps.MeasureDistanceFromAssignedHostUnit MeasureDistanceFromAssignedHostUnit_)
			{
				if (MeasureDistanceFromAssignedHostUnit_ != null)
				{
					this.assignedHostUnit = MeasureDistanceFromAssignedHostUnit_.assignedHostUnit;
				}
			}

			// Token: 0x06004C4B RID: 19531 RVA: 0x001E3DB4 File Offset: 0x001E1FB4
			internal double GetAngularDistanceTo(ActiveUnit activeUnit_)
			{
				return activeUnit_.GetApproxAngularDistanceInDegrees(this.assignedHostUnit);
			}

			// Token: 0x040023F8 RID: 9208
			public ActiveUnit assignedHostUnit;
		}

		// Token: 0x020009EF RID: 2543
		[CompilerGenerated]
		public sealed class Class100
		{
			// Token: 0x06004C4C RID: 19532 RVA: 0x00024607 File Offset: 0x00022807
			public Class100(Aircraft_AirOps.Class100 class100_0)
			{
				if (class100_0 != null)
				{
					this.aircraft_0 = class100_0.aircraft_0;
				}
			}

			// Token: 0x06004C4D RID: 19533 RVA: 0x00024621 File Offset: 0x00022821
			internal bool IsCloseTo(ActiveUnit activeUnit_)
			{
				return activeUnit_.GetHorizontalRange(this.aircraft_0) < 2f;
			}

			// Token: 0x040023F9 RID: 9209
			public Aircraft aircraft_0;

			// Token: 0x040023FA RID: 9210
			public Func<ActiveUnit, bool> func_0;
		}

		// Token: 0x020009F0 RID: 2544
		[CompilerGenerated]
		public sealed class Class101
		{
			// Token: 0x06004C4E RID: 19534 RVA: 0x00024636 File Offset: 0x00022836
			public Class101(Aircraft_AirOps.Class101 class101_0)
			{
				if (class101_0 != null)
				{
					this.double_0 = class101_0.double_0;
				}
			}

			// Token: 0x06004C4F RID: 19535 RVA: 0x00024650 File Offset: 0x00022850
			internal bool method_0(Aircraft aircraft_0)
			{
				return this.class102_0.aircraft_AirOps_0.GetAircraft().GetApproxAngularDistanceInDegrees(aircraft_0) < this.double_0 && aircraft_0.GetApproxAngularDistanceInDegrees(this.class102_0.geoPoint_0) < this.double_0;
			}

			// Token: 0x040023FB RID: 9211
			public double double_0;

			// Token: 0x040023FC RID: 9212
			public Aircraft_AirOps.Class102 class102_0;
		}

		// Token: 0x020009F1 RID: 2545
		[CompilerGenerated]
		public sealed class Class102
		{
			// Token: 0x06004C50 RID: 19536 RVA: 0x0002468C File Offset: 0x0002288C
			public Class102(Aircraft_AirOps.Class102 class102_0)
			{
				if (class102_0 != null)
				{
					this.geoPoint_0 = class102_0.geoPoint_0;
				}
			}

			// Token: 0x040023FD RID: 9213
			public GeoPoint geoPoint_0;

			// Token: 0x040023FE RID: 9214
			public Aircraft_AirOps aircraft_AirOps_0;
		}

		// Token: 0x020009F2 RID: 2546
		[CompilerGenerated]
		public sealed class Class103
		{
			// Token: 0x06004C51 RID: 19537 RVA: 0x000246A6 File Offset: 0x000228A6
			public Class103(Aircraft_AirOps.Class103 class103_0)
			{
				if (class103_0 != null)
				{
					this.double_0 = class103_0.double_0;
				}
			}

			// Token: 0x06004C52 RID: 19538 RVA: 0x001E3DD0 File Offset: 0x001E1FD0
			internal bool method_0(Aircraft aircraft_0)
			{
				return this.class104_0.class102_0.aircraft_AirOps_0.GetAircraft().GetApproxAngularDistanceInDegrees(aircraft_0) < this.double_0 && aircraft_0.GetApproxAngularDistanceInDegrees(this.class104_0.activeUnit_0) < this.double_0;
			}

			// Token: 0x040023FF RID: 9215
			public double double_0;

			// Token: 0x04002400 RID: 9216
			public Aircraft_AirOps.Class104 class104_0;
		}

		// Token: 0x020009F3 RID: 2547
		[CompilerGenerated]
		public sealed class Class104
		{
			// Token: 0x06004C53 RID: 19539 RVA: 0x000246C0 File Offset: 0x000228C0
			public Class104(Aircraft_AirOps.Class104 class104_0)
			{
				if (class104_0 != null)
				{
					this.activeUnit_0 = class104_0.activeUnit_0;
				}
			}

			// Token: 0x04002401 RID: 9217
			public ActiveUnit activeUnit_0;

			// Token: 0x04002402 RID: 9218
			public Aircraft_AirOps.Class102 class102_0;
		}
	}
}

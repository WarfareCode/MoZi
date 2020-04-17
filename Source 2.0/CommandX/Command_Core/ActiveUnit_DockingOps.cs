using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
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
	// Token: 0x020004F4 RID: 1268
	public sealed class ActiveUnit_DockingOps
	{
		// Token: 0x06002108 RID: 8456 RVA: 0x000D585C File Offset: 0x000D3A5C
		[CompilerGenerated]
		public  ObservableCollection<string> GetUNREPQueue()
		{
			return this.UNREPQueue;
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00013D61 File Offset: 0x00011F61
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public  void SetUNREPQueue(ObservableCollection<string> value)
		{
			this.UNREPQueue = value;
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x000D5874 File Offset: 0x000D3A74
		[CompilerGenerated]
		public static void smethod_0(ActiveUnit_DockingOps.Delegate2 delegate2_1)
		{
			ActiveUnit_DockingOps.Delegate2 @delegate = ActiveUnit_DockingOps.delegate2_0;
			ActiveUnit_DockingOps.Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_DockingOps.Delegate2 value = (ActiveUnit_DockingOps.Delegate2)Delegate.Combine(delegate2, delegate2_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_DockingOps.Delegate2>(ref ActiveUnit_DockingOps.delegate2_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x000D58AC File Offset: 0x000D3AAC
		[CompilerGenerated]
		public static void smethod_1(ActiveUnit_DockingOps.Delegate2 delegate2_1)
		{
			ActiveUnit_DockingOps.Delegate2 @delegate = ActiveUnit_DockingOps.delegate2_0;
			ActiveUnit_DockingOps.Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_DockingOps.Delegate2 value = (ActiveUnit_DockingOps.Delegate2)Delegate.Remove(delegate2, delegate2_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_DockingOps.Delegate2>(ref ActiveUnit_DockingOps.delegate2_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x000D58E4 File Offset: 0x000D3AE4
		[CompilerGenerated]
		public static void smethod_2(ActiveUnit_DockingOps.Delegate3 delegate3_1)
		{
			ActiveUnit_DockingOps.Delegate3 @delegate = ActiveUnit_DockingOps.delegate3_0;
			ActiveUnit_DockingOps.Delegate3 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_DockingOps.Delegate3 value = (ActiveUnit_DockingOps.Delegate3)Delegate.Combine(delegate2, delegate3_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_DockingOps.Delegate3>(ref ActiveUnit_DockingOps.delegate3_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x000D591C File Offset: 0x000D3B1C
		[CompilerGenerated]
		public static void smethod_3(ActiveUnit_DockingOps.Delegate3 delegate3_1)
		{
			ActiveUnit_DockingOps.Delegate3 @delegate = ActiveUnit_DockingOps.delegate3_0;
			ActiveUnit_DockingOps.Delegate3 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_DockingOps.Delegate3 value = (ActiveUnit_DockingOps.Delegate3)Delegate.Remove(delegate2, delegate3_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_DockingOps.Delegate3>(ref ActiveUnit_DockingOps.delegate3_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x000D5954 File Offset: 0x000D3B54
		public void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("ActiveUnit_DockingOps");
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Con";
				int num = (int)this.DockingOpsCondition;
				xmlWriter.WriteElementString(localName, num.ToString());
				xmlWriter_0.WriteElementString("CT", XmlConvert.ToString(this.CT));
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "CBRB";
				num = (int)this.CBRB;
				xmlWriter2.WriteElementString(localName2, num.ToString());
				xmlWriter_0.WriteElementString("CBRB_Depth", XmlConvert.ToString(this.CBRB_Depth));
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "CBRB_ThrottleSetting";
				byte cBRB_ThrottleSetting = (byte)this.CBRB_ThrottleSetting;
				xmlWriter3.WriteElementString(localName3, cBRB_ThrottleSetting.ToString());
				if (!Information.IsNothing(this.HostDockFacility))
				{
					xmlWriter_0.WriteElementString("HDF", this.GetHostDockFacility().GetGuid());
				}
				if (!Information.IsNothing(this.GetCurrentHostUnit()))
				{
					xmlWriter_0.WriteElementString("CHU", this.GetCurrentHostUnit().GetGuid());
				}
				if (!Information.IsNothing(this.AssignedHostUnit))
				{
					xmlWriter_0.WriteElementString("AHU", this.AssignedHostUnit.GetGuid());
				}
				if (!Information.IsNothing(this.GetUNREPDestinationUnit()))
				{
					xmlWriter_0.WriteElementString("UNREP_D", this.GetUNREPDestinationUnit().GetGuid());
				}
				if (!string.IsNullOrEmpty(this.UNREP_Port))
				{
					xmlWriter_0.WriteElementString("UNREP_P", this.UNREP_Port);
				}
				if (!string.IsNullOrEmpty(this.UNREP_Starboard))
				{
					xmlWriter_0.WriteElementString("UNREP_S", this.UNREP_Starboard);
				}
				if (!string.IsNullOrEmpty(this.UNREP_Astern))
				{
					xmlWriter_0.WriteElementString("UNREP_A", this.UNREP_Astern);
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100129", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x000D5B50 File Offset: 0x000D3D50
		public static ActiveUnit_DockingOps Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref ActiveUnit activeUnit_3)
		{
			ActiveUnit_DockingOps result = null;
			try
			{
				ActiveUnit_DockingOps activeUnit_DockingOps = new ActiveUnit_DockingOps(ref activeUnit_3);
				activeUnit_DockingOps.ParentPlatform = activeUnit_3;
				IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						string name = xmlNode.Name;
						uint num = Class382.smethod_0(name);
						if (num <= 1281343745u)
						{
							if (num <= 474553294u)
							{
								if (num != 256444247u)
								{
									if (num != 273221866u)
									{
										if (num == 474553294u && Operators.CompareString(name, "UNREP_D", false) == 0)
										{
											activeUnit_DockingOps.UNREP_D = xmlNode.InnerText;
										}
									}
									else if (Operators.CompareString(name, "UNREP_P", false) == 0 && !string.IsNullOrEmpty(xmlNode.InnerText) && Operators.CompareString(activeUnit_DockingOps.UNREP_Starboard, xmlNode.InnerText, false) != 0 && Operators.CompareString(activeUnit_DockingOps.UNREP_Astern, xmlNode.InnerText, false) != 0)
									{
										activeUnit_DockingOps.UNREP_Port = xmlNode.InnerText;
									}
								}
								else if (Operators.CompareString(name, "UNREP_S", false) == 0 && !string.IsNullOrEmpty(xmlNode.InnerText) && Operators.CompareString(activeUnit_DockingOps.UNREP_Port, xmlNode.InnerText, false) != 0 && Operators.CompareString(activeUnit_DockingOps.UNREP_Astern, xmlNode.InnerText, false) != 0)
								{
									activeUnit_DockingOps.UNREP_Starboard = xmlNode.InnerText;
								}
							}
							else if (num != 558441389u)
							{
								if (num != 898687005u)
								{
									if (num == 1281343745u && Operators.CompareString(name, "CHU", false) == 0)
									{
										activeUnit_DockingOps.CurrentHostUnitName = xmlNode.InnerText;
									}
								}
								else if (Operators.CompareString(name, "HDF", false) == 0)
								{
									activeUnit_DockingOps.HostDockFacilityName = xmlNode.InnerText;
								}
							}
							else if (Operators.CompareString(name, "UNREP_A", false) == 0 && !string.IsNullOrEmpty(xmlNode.InnerText) && Operators.CompareString(activeUnit_DockingOps.UNREP_Port, xmlNode.InnerText, false) != 0 && Operators.CompareString(activeUnit_DockingOps.UNREP_Starboard, xmlNode.InnerText, false) != 0)
							{
								activeUnit_DockingOps.UNREP_Astern = xmlNode.InnerText;
							}
						}
						else
						{
							if (num <= 1792671826u)
							{
								if (num != 1394108651u)
								{
									if (num != 1593765902u)
									{
										if (num == 1792671826u && Operators.CompareString(name, "CT", false) == 0)
										{
											activeUnit_DockingOps.CT = XmlConvert.ToDouble(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "CBRB_Depth", false) == 0)
										{
											activeUnit_DockingOps.CBRB_Depth = XmlConvert.ToSingle(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (Operators.CompareString(name, "Con", false) != 0)
								{
									continue;
								}
							}
							else if (num <= 2112830247u)
							{
								if (num != 1852486619u)
								{
									if (num != 2112830247u || Operators.CompareString(name, "CBRB_ThrottleSetting", false) != 0)
									{
										continue;
									}
									string innerText = xmlNode.InnerText;
									if (Operators.CompareString(innerText, "FullStop", false) == 0)
									{
										activeUnit_DockingOps.CBRB_ThrottleSetting = ActiveUnit.Throttle.FullStop;
										continue;
									}
									if (Operators.CompareString(innerText, "Loiter", false) == 0)
									{
										activeUnit_DockingOps.CBRB_ThrottleSetting = ActiveUnit.Throttle.Loiter;
										continue;
									}
									if (Operators.CompareString(innerText, "Cruise", false) == 0)
									{
										activeUnit_DockingOps.CBRB_ThrottleSetting = ActiveUnit.Throttle.Cruise;
										continue;
									}
									if (Operators.CompareString(innerText, "Full", false) == 0)
									{
										activeUnit_DockingOps.CBRB_ThrottleSetting = ActiveUnit.Throttle.Full;
										continue;
									}
									if (Operators.CompareString(innerText, "Flank", false) != 0)
									{
										activeUnit_DockingOps.CBRB_ThrottleSetting = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									activeUnit_DockingOps.CBRB_ThrottleSetting = ActiveUnit.Throttle.Flank;
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "AHU", false) == 0)
									{
										activeUnit_DockingOps.AssignedHostUnitName = xmlNode.InnerText;
										continue;
									}
									continue;
								}
							}
							else if (num != 2209593132u)
							{
								if (num != 3433242718u || Operators.CompareString(name, "Condition", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "CBRB", false) == 0)
								{
									activeUnit_DockingOps.CBRB = (ActiveUnit_DockingOps._DockingOpsCondition)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							if (Versioned.IsNumeric(xmlNode.InnerText))
							{
								activeUnit_DockingOps.SetDockingOpsCondition((ActiveUnit_DockingOps._DockingOpsCondition)Conversions.ToByte(xmlNode.InnerText));
							}
							else
							{
								activeUnit_DockingOps.SetDockingOpsCondition((ActiveUnit_DockingOps._DockingOpsCondition)Enum.Parse(typeof(ActiveUnit_DockingOps._DockingOpsCondition), xmlNode.InnerText, true));
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
				result = activeUnit_DockingOps;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100130", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x000D60AC File Offset: 0x000D42AC
		public void method_1(ref Scenario scenario_, Dictionary<string, Subject> dictionary_0, bool bool_0)
		{
			checked
			{
				try
				{
					if (Information.IsNothing(this.GetHostDockFacility()) && !string.IsNullOrEmpty(this.HostDockFacilityName))
					{
						if (dictionary_0.ContainsKey(this.HostDockFacilityName))
						{
							this.SetDockFacility((DockFacility)dictionary_0[this.HostDockFacilityName]);
						}
						else
						{
							bool flag = false;
							using (List<ActiveUnit>.Enumerator enumerator = scenario_.GetActiveUnitList().GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									DockFacility[] dockFacilities = enumerator.Current.GetDockFacilities();
									for (int i = 0; i < dockFacilities.Length; i++)
									{
										DockFacility dockFacility = dockFacilities[i];
										if (string.CompareOrdinal(dockFacility.GetGuid(), this.HostDockFacilityName) == 0)
										{
											this.SetDockFacility(dockFacility);
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
					if (!Information.IsNothing(this.GetCurrentHostUnit()) && !Information.IsNothing(this.GetHostDockFacility()) && !this.GetCurrentHostUnit().GetDockFacilities().Contains(this.GetHostDockFacility()))
					{
						this.GetCurrentHostUnit().GetDockingOps().method_39(this.ParentPlatform);
					}
					if (Information.IsNothing(this.AssignedHostUnit) && !Information.IsNothing(this.AssignedHostUnitName))
					{
						try
						{
							ActiveUnit activeUnit = scenario_.GetActiveUnits()[this.AssignedHostUnitName];
							if (!Information.IsNothing(activeUnit))
							{
								if (!this.ParentPlatform.IsOperating())
								{
									activeUnit.GetDockingOps().method_39(this.ParentPlatform);
								}
								else
								{
									this.ParentPlatform.GetDockingOps().SetAssignedHostUnit(false, activeUnit);
								}
							}
							else if (!this.ParentPlatform.IsOperating())
							{
								this.ParentPlatform.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200007", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
					}
					if (Information.IsNothing(this.GetCurrentHostUnit()) && !this.ParentPlatform.IsOperating() && !Information.IsNothing(this.GetAssignedHostUnit(false)))
					{
						this.GetAssignedHostUnit(false).GetDockingOps().method_39(this.ParentPlatform);
					}
					if (!string.IsNullOrEmpty(this.UNREP_D))
					{
						this.UNREPDestinationUnit = scenario_.GetActiveUnits()[this.UNREP_D];
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 100131", "");
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x000D638C File Offset: 0x000D458C
		public IEnumerable<ActiveUnit> method_2()
		{
			IEnumerable<ActiveUnit> result = null;
			try
			{
				result = this.GetDockedUnits().Where(ActiveUnit_DockingOps.ActiveUnitFunc0).AsEnumerable<ActiveUnit>();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100132", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x000D6404 File Offset: 0x000D4604
		public ActiveUnit GetAssignedHostUnit()
		{
			ActiveUnit result = null;
			try
			{
				Mission assignedMission = this.ParentPlatform.GetAssignedMission(false);
				if (Information.IsNothing(assignedMission))
				{
					result = this.GetAssignedHostUnit(false);
				}
				else if (assignedMission.MissionClass != Mission._MissionClass.Ferry)
				{
					result = this.GetAssignedHostUnit(false);
				}
				else if (Information.IsNothing(((FerryMission)assignedMission).GetDestinationHost(this.ParentPlatform.m_Scenario)))
				{
					this.ParentPlatform.LogMessage(string.Concat(new string[]
					{
						this.ParentPlatform.Name,
						" (",
						this.ParentPlatform.UnitClass,
						") is no longer able to execute ferry mission: ",
						assignedMission.Name,
						" (the ferry destination appears to be missing). The unit will be removed from the mission."
					}), LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
					this.ParentPlatform.DeleteMission(false, null);
					result = this.GetAssignedHostUnit(false);
				}
				else
				{
					switch (((FerryMission)assignedMission).GetFerryMissionBehavior())
					{
					case FerryMission.FerryMissionBehavior.OneWay:
						result = ((FerryMission)assignedMission).GetDestinationHost(this.ParentPlatform.m_Scenario);
						break;
					case FerryMission.FerryMissionBehavior.Cycle:
						if (this.ParentPlatform.GetAI().IsFerryCycleLegIsOutbound())
						{
							result = ((FerryMission)assignedMission).GetDestinationHost(this.ParentPlatform.m_Scenario);
						}
						else
						{
							result = this.GetAssignedHostUnit(false);
						}
						break;
					case FerryMission.FerryMissionBehavior.Random:
						result = this.GetAssignedHostUnit(false);
						break;
					default:
						result = this.GetAssignedHostUnit(false);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100133", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00013D6A File Offset: 0x00011F6A
		public void method_4()
		{
			this.list_0 = null;
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x000D65F8 File Offset: 0x000D47F8
		public List<GeoPoint> method_5()
		{
			List<GeoPoint> result;
			if (!this.HasPier())
			{
				result = null;
			}
			else
			{
				if (Information.IsNothing(this.list_0))
				{
					List<GeoPoint> list = new List<GeoPoint>();
					float num = Math2.Normalize(this.ParentPlatform.GetCurrentHeading() - 60f);
					float num2 = Math2.Normalize(this.ParentPlatform.GetCurrentHeading() + 60f);
					float currentHeading = this.ParentPlatform.GetCurrentHeading();
					GeoPoint geoPoint = new GeoPoint();
					double longitude = this.ParentPlatform.GetLongitude(null);
					double latitude = this.ParentPlatform.GetLatitude(null);
					GeoPoint geoPoint2;
					double num3 = (geoPoint2 = geoPoint).GetLongitude();
					GeoPoint geoPoint3;
					double num4 = (geoPoint3 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref num3, ref num4, 2.0, (double)Math2.Normalize(currentHeading + 180f));
					geoPoint3.SetLatitude(num4);
					geoPoint2.SetLongitude(num3);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double longitude2 = this.ParentPlatform.GetLongitude(null);
					double latitude2 = this.ParentPlatform.GetLatitude(null);
					num4 = (geoPoint3 = geoPoint).GetLongitude();
					num3 = (geoPoint2 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude2, latitude2, ref num4, ref num3, 7.0, (double)num);
					geoPoint2.SetLatitude(num3);
					geoPoint3.SetLongitude(num4);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double longitude3 = this.ParentPlatform.GetLongitude(null);
					double latitude3 = this.ParentPlatform.GetLatitude(null);
					num3 = (geoPoint2 = geoPoint).GetLongitude();
					num4 = (geoPoint3 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude3, latitude3, ref num3, ref num4, 7.0, (double)Math2.Normalize(num + 30f));
					geoPoint3.SetLatitude(num4);
					geoPoint2.SetLongitude(num3);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double longitude4 = this.ParentPlatform.GetLongitude(null);
					double latitude4 = this.ParentPlatform.GetLatitude(null);
					num4 = (geoPoint3 = geoPoint).GetLongitude();
					num3 = (geoPoint2 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude4, latitude4, ref num4, ref num3, 7.0, (double)currentHeading);
					geoPoint2.SetLatitude(num3);
					geoPoint3.SetLongitude(num4);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double longitude5 = this.ParentPlatform.GetLongitude(null);
					double latitude5 = this.ParentPlatform.GetLatitude(null);
					num3 = (geoPoint2 = geoPoint).GetLongitude();
					num4 = (geoPoint3 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude5, latitude5, ref num3, ref num4, 7.0, (double)Math2.Normalize(currentHeading + 30f));
					geoPoint3.SetLatitude(num4);
					geoPoint2.SetLongitude(num3);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double longitude6 = this.ParentPlatform.GetLongitude(null);
					double latitude6 = this.ParentPlatform.GetLatitude(null);
					num4 = (geoPoint3 = geoPoint).GetLongitude();
					num3 = (geoPoint2 = geoPoint).GetLatitude();
					GeoPointGenerator.GetOtherGeoPoint(longitude6, latitude6, ref num4, ref num3, 7.0, (double)num2);
					geoPoint2.SetLatitude(num3);
					geoPoint3.SetLongitude(num4);
					list.Add(geoPoint);
					this.list_0 = list;
				}
				result = this.list_0;
			}
			return result;
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x000D699C File Offset: 0x000D4B9C
		public bool HasPier()
		{
			DockFacility[] dockFacilities = this.ParentPlatform.GetDockFacilities();
			checked
			{
				bool result;
				for (int i = 0; i < dockFacilities.Length; i++)
				{
					if (dockFacilities[i].Type == DockFacility._DockFacilityType.Pier)
					{
						result = true;
						return result;
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x000D69E0 File Offset: 0x000D4BE0
		public bool method_7(bool bool_0, ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_0, bool bool_1, ActiveUnit._ActiveUnitStatus _ActiveUnitStatus_1, bool bool_2, bool bool_3)
		{
			bool result = false;
			try
			{
				if (!Information.IsNothing(this.GetAssignedHostUnit()))
				{
					if (!Information.IsNothing(_ActiveUnitStatus_0))
					{
						this.ParentPlatform.SetUnitStatus(_ActiveUnitStatus_0);
					}
					this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.RTB);
					this.ParentPlatform.GetNavigator().ClearPlottedCourse();
					this.ParentPlatform.GetKinematics().SetDesiredSpeedOverride(null);
					this.ParentPlatform.GetKinematics().SetDesiredAltitudeOverride(false);
					if (bool_1 && !Information.IsNothing(this.ParentPlatform.GetParentGroup(false)))
					{
						foreach (ActiveUnit current in this.ParentPlatform.GetParentGroup(false).GetUnitsInGroup().Values)
						{
							if (current != this.ParentPlatform)
							{
								current.SetUnitStatus(_ActiveUnitStatus_1);
								current.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.RTB);
								current.GetNavigator().ClearPlottedCourse();
								current.GetKinematics().SetDesiredSpeedOverride(null);
								current.GetKinematics().SetDesiredAltitudeOverride(false);
							}
						}
					}
					result = true;
				}
				else
				{
					this.PickNewHostUnit();
					if (!Information.IsNothing(this.GetAssignedHostUnit(false)))
					{
						if (!Information.IsNothing(_ActiveUnitStatus_0))
						{
							this.ParentPlatform.SetUnitStatus(_ActiveUnitStatus_0);
						}
						this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.RTB);
						this.ParentPlatform.GetNavigator().ClearPlottedCourse();
						this.ParentPlatform.GetKinematics().SetDesiredSpeedOverride(null);
						this.ParentPlatform.GetKinematics().SetDesiredAltitudeOverride(false);
						if (bool_1 && !Information.IsNothing(this.ParentPlatform.GetParentGroup(false)))
						{
							foreach (ActiveUnit current2 in this.ParentPlatform.GetParentGroup(false).GetUnitsInGroup().Values)
							{
								if (current2 != this.ParentPlatform)
								{
									current2.SetUnitStatus(_ActiveUnitStatus_1);
									current2.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.RTB);
									current2.GetNavigator().ClearPlottedCourse();
									current2.GetKinematics().SetDesiredSpeedOverride(null);
									current2.GetKinematics().SetDesiredAltitudeOverride(false);
								}
							}
						}
						result = true;
					}
					else
					{
						if (bool_0)
						{
							this.ParentPlatform.m_Scenario.LogMessage(this.ParentPlatform.Name + "不能合适停靠位置!", LoggedMessage.MessageType.DockingOps, 15, this.ParentPlatform.GetGuid(), this.ParentPlatform.GetSide(false), new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
						}
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100134", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x000D6D30 File Offset: 0x000D4F30
		public ActiveUnit GetUNREPDestinationUnit()
		{
			return this.UNREPDestinationUnit;
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x000D6D48 File Offset: 0x000D4F48
		public void SetUNREPDestinationUnit(ActiveUnit newDestUnit)
		{
			try
			{
				if (newDestUnit != this.UNREPDestinationUnit && !Information.IsNothing(this.UNREPDestinationUnit) && !Information.IsNothing(this.UNREPDestinationUnit.GetDockingOps()))
				{
					this.UNREPDestinationUnit.GetDockingOps().GetUNREPQueue().Remove(this.ParentPlatform.GetGuid());
				}
				this.UNREPDestinationUnit = newDestUnit;
				if (!Information.IsNothing(newDestUnit))
				{
					ObservableCollection<string> uNREPQueue = this.UNREPDestinationUnit.GetDockingOps().GetUNREPQueue();
					if (!uNREPQueue.Contains(this.ParentPlatform.GetGuid()))
					{
						uNREPQueue.Add(this.ParentPlatform.GetGuid());
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100135", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x000D6E34 File Offset: 0x000D5034
		public ActiveUnit_DockingOps._DockingOpsCondition GetDockingOpsCondition()
		{
			return this.DockingOpsCondition;
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x000D6E4C File Offset: 0x000D504C
		public void SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition DockingOpsCondition_)
		{
			try
			{
				bool flag = this.DockingOpsCondition != DockingOpsCondition_;
				this._DockingOpsCondition_1 = this.DockingOpsCondition;
				this.DockingOpsCondition = DockingOpsCondition_;
				if (flag)
				{
					if (DockingOpsCondition_ == ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway)
					{
						this.CT = (double)this.method_20() * 0.66666666666666663;
					}
					else if (DockingOpsCondition_ == ActiveUnit_DockingOps._DockingOpsCondition.Docking)
					{
						this.CT = (double)this.method_20();
						ActiveUnit_DockingOps.Delegate3 @delegate = ActiveUnit_DockingOps.delegate3_0;
						if (@delegate != null)
						{
							@delegate(this.ParentPlatform);
						}
					}
					else if (DockingOpsCondition_ == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
					{
						this.CBRB_Depth = this.ParentPlatform.GetDesiredAltitude();
						this.CBRB_ThrottleSetting = this.ParentPlatform.GetThrottle();
					}
					else if (this._DockingOpsCondition_1 == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
					{
						if (this.ParentPlatform.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.EngagedDefensive && this.ParentPlatform.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.EngagedOffensive && this.ParentPlatform.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint && this.ParentPlatform.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Refuelling)
						{
							this.ParentPlatform.SetDesiredAltitude(this.CBRB_Depth);
							this.ParentPlatform.SetThrottle(this.CBRB_ThrottleSetting, null);
						}
					}
					else if (DockingOpsCondition_ == ActiveUnit_DockingOps._DockingOpsCondition.Underway)
					{
						ActiveUnit_DockingOps.Delegate2 delegate2 = ActiveUnit_DockingOps.delegate2_0;
						if (delegate2 != null)
						{
							delegate2(this.ParentPlatform);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100136", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x000D700C File Offset: 0x000D520C
		public string GetDockingOpsConditionName()
		{
			string result;
			switch (this.GetDockingOpsCondition())
			{
			case ActiveUnit_DockingOps._DockingOpsCondition.Underway:
				result = "正在航行";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.Docked:
				result = "完成停靠";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway:
				result = "部署出动";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.Docking:
				result = "正在停靠";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.RTB:
				result = "返回基地";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.Readying:
				result = "出动准备";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.ManoeuveringToRefuel:
				result = "前往加油";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.Replenishing:
				result = "接受补给";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP:
				result = "提供补给";
				break;
			case ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries:
				result = "正在充电";
				break;
			default:
				result = this.GetDockingOpsCondition().ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x000D70B8 File Offset: 0x000D52B8
		public ActiveUnit GetAssignedHostUnit(bool PickNewAssignedHost = false)
		{
			ActiveUnit result = null;
			try
			{
				if (PickNewAssignedHost && (Information.IsNothing(this.AssignedHostUnit) || this.AssignedHostUnit.IsNotActive()))
				{
					this.PickNewHostUnit();
				}
				result = this.AssignedHostUnit;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100137", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x000D714C File Offset: 0x000D534C
		public void SetAssignedHostUnit(bool PickNewAssignedHost, ActiveUnit value)
		{
			try
			{
				bool flag = value != this.AssignedHostUnit;
				this.AssignedHostUnit = value;
				if (flag && this.ParentPlatform.IsSubmarine && ((Submarine)this.ParentPlatform).IsROV() && !Information.IsNothing(value))
				{
					this.ParentPlatform.DeleteMission(false, value.GetAssignedMission(false));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100138", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x000D71FC File Offset: 0x000D53FC
		public ReadOnlyCollection<ActiveUnit> GetDockedUnits()
		{
			ReadOnlyCollection<ActiveUnit> result = null;
			checked
			{
				try
				{
					List<ActiveUnit> list = new List<ActiveUnit>();
					DockFacility[] dockFacilities = this.ParentPlatform.GetDockFacilities();
					for (int i = 0; i < dockFacilities.Length; i++)
					{
						DockFacility dockFacility = dockFacilities[i];
						foreach (ActiveUnit current in dockFacility.LazyDockedUnitsDictionary.Value.Values)
						{
							list.Add(current);
						}
					}
					result = list.AsReadOnly();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100139", "");
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

		// Token: 0x0600211F RID: 8479 RVA: 0x000D72E4 File Offset: 0x000D54E4
		public DockFacility GetHostDockFacility()
		{
			return this.HostDockFacility;
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x000D72FC File Offset: 0x000D54FC
		public void SetDockFacility(DockFacility dockFacility_1)
		{
			try
			{
				if (!Information.IsNothing(this.HostDockFacility))
				{
					this.HostDockFacility.LazyDockedUnitsDictionary.Value.TryRemove(this.ParentPlatform.GetGuid(), out this.ParentPlatform);
				}
				if (!Information.IsNothing(dockFacility_1) && !dockFacility_1.LazyDockedUnitsDictionary.Value.ContainsKey(this.ParentPlatform.GetGuid()))
				{
					dockFacility_1.LazyDockedUnitsDictionary.Value.TryAdd(this.ParentPlatform.GetGuid(), this.ParentPlatform);
				}
				this.HostDockFacility = dockFacility_1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100140", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x000D73DC File Offset: 0x000D55DC
		public ActiveUnit GetCurrentHostUnit()
		{
			ActiveUnit result = null;
			try
			{
				DockFacility hostDockFacility = this.GetHostDockFacility();
				if (Information.IsNothing(hostDockFacility))
				{
					result = null;
				}
				else if (Information.IsNothing(hostDockFacility.GetParentPlatform()))
				{
					result = null;
				}
				else
				{
					ActiveUnit parentPlatform = hostDockFacility.GetParentPlatform();
					if (parentPlatform.HasParentGroup() && parentPlatform.GetParentGroup(false).GetGroupType() == Group.GroupType.Installation)
					{
						result = parentPlatform.GetParentGroup(false);
					}
					else
					{
						result = parentPlatform;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100141", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x00013D73 File Offset: 0x00011F73
		public bool HasUNREPTargetUnit()
		{
			return !string.IsNullOrEmpty(this.UNREP_Port) || !string.IsNullOrEmpty(this.UNREP_Starboard) || !string.IsNullOrEmpty(this.UNREP_Astern);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x000D749C File Offset: 0x000D569C
		public ActiveUnit_DockingOps(ref ActiveUnit activeUnit_3)
		{
			this.SetUNREPQueue(new ObservableCollection<string>());
			this.UNREPRangeLimit = 0.3f;
			this.ParentPlatform = activeUnit_3;
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x000D74F0 File Offset: 0x000D56F0
		public short method_20()
		{
			short num = 0;
			short result;
			try
			{
				DockFacility._DockFacilityPhysicalSizeCode dockFacilityPhysicalSizeCode = (DockFacility._DockFacilityPhysicalSizeCode)0;
				if (this.ParentPlatform.IsShip)
				{
					dockFacilityPhysicalSizeCode = ((Ship)this.ParentPlatform).physicalSizeCode;
				}
				if (this.ParentPlatform.IsSubmarine)
				{
					dockFacilityPhysicalSizeCode = ((Submarine)this.ParentPlatform).PhysicalSizeCode;
				}
				if (dockFacilityPhysicalSizeCode <= DockFacility._DockFacilityPhysicalSizeCode.ExtraLargePier)
				{
					if (dockFacilityPhysicalSizeCode == DockFacility._DockFacilityPhysicalSizeCode.None)
					{
						num = 360;
						result = 360;
						return result;
					}
					switch (dockFacilityPhysicalSizeCode)
					{
					case DockFacility._DockFacilityPhysicalSizeCode.VerySmallPier:
						goto IL_105;
					case DockFacility._DockFacilityPhysicalSizeCode.SmallPier:
						goto IL_10D;
					case DockFacility._DockFacilityPhysicalSizeCode.MediumPier:
						goto IL_11B;
					case DockFacility._DockFacilityPhysicalSizeCode.LargePier:
						goto IL_129;
					case DockFacility._DockFacilityPhysicalSizeCode.VeryLargePier:
						num = 900;
						result = 900;
						return result;
					case DockFacility._DockFacilityPhysicalSizeCode.ExtraLargePier:
						num = 1200;
						result = 1200;
						return result;
					}
				}
				else
				{
					switch (dockFacilityPhysicalSizeCode)
					{
					case DockFacility._DockFacilityPhysicalSizeCode.VerySmallDock_Davit:
						goto IL_105;
					case DockFacility._DockFacilityPhysicalSizeCode.SmallDock_Davit:
						goto IL_10D;
					case DockFacility._DockFacilityPhysicalSizeCode.MediumDock:
						goto IL_11B;
					case DockFacility._DockFacilityPhysicalSizeCode.LargeDock:
						goto IL_129;
					default:
						if (dockFacilityPhysicalSizeCode == DockFacility._DockFacilityPhysicalSizeCode.DryDeckShelter)
						{
							goto IL_10D;
						}
						if (dockFacilityPhysicalSizeCode == DockFacility._DockFacilityPhysicalSizeCode.ROV_UUV)
						{
							goto IL_105;
						}
						break;
					}
				}
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw new NotImplementedException();
				IL_105:
				num = 60;
				result = 60;
				return result;
				IL_10D:
				num = 180;
				result = 180;
				return result;
				IL_11B:
				num = 360;
				result = 360;
				return result;
				IL_129:
				num = 600;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100142", "");
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

		// Token: 0x06002125 RID: 8485 RVA: 0x000D7690 File Offset: 0x000D5890
		public void method_21()
		{
			if (this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps) && this.ParentPlatform.m_OnboardCargos.Count<Cargo>() != 0 && !(this.ParentPlatform is Group))
			{
				List<GeoPoint> list = new List<GeoPoint>();
				int num = 1;
				do
				{
					float num2 = 0f;
					do
					{
						GeoPoint geoPoint = new GeoPoint();
						double longitude = this.ParentPlatform.GetLongitude(null);
						double latitude = this.ParentPlatform.GetLatitude(null);
						GeoPoint geoPoint2;
						double longitude2 = (geoPoint2 = geoPoint).GetLongitude();
						GeoPoint geoPoint3;
						double latitude2 = (geoPoint3 = geoPoint).GetLatitude();
						GeoPointGenerator.GetOtherGeoPoint(longitude, latitude, ref longitude2, ref latitude2, (double)num2, (double)num);
						geoPoint3.SetLatitude(latitude2);
						geoPoint2.SetLongitude(longitude2);
						short elevation = Terrain.GetElevation(geoPoint.GetLatitude(), geoPoint.GetLongitude(), false);
						if (elevation > 0 & elevation < 50)
						{
							list.Add(geoPoint);
						}
						num2 += 0.1f;
					}
					while (num2 <= 2f);
					num++;
				}
				while (num <= 360);
				if (list.Any<GeoPoint>())
				{
					GeoPoint geoPoint4 = list.OrderBy(new Func<GeoPoint, double>(this.method_54)).ElementAtOrDefault(0);
					List<Facility> list2 = Facility.smethod_1(this.ParentPlatform.m_OnboardCargos.Select(ActiveUnit_DockingOps.CargoFunc1).ToList<Mount>(), this.ParentPlatform.m_Scenario, this.ParentPlatform.GetSide(false));
					foreach (Facility current in list2)
					{
						current.SetLongitude(null, geoPoint4.GetLongitude());
						current.SetLatitude(null, geoPoint4.GetLatitude());
					}
					ScenarioArrayUtil.NewCargoArray(ref this.ParentPlatform.m_OnboardCargos);
				}
			}
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x000D78A4 File Offset: 0x000D5AA4
		private void CarryOutCargoOps()
		{
			if (this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps) && this.ParentPlatform.GetAssignedMission(false) != null && this.ParentPlatform.GetAssignedMission(false).IsActive() && this.ParentPlatform.GetAssignedMission(false) is CargoMission)
			{
				CargoMission cargoMission = (CargoMission)this.ParentPlatform.GetAssignedMission(false);
				if (this.ParentPlatform is Ship)
				{
					Ship ship = (Ship)this.ParentPlatform;
					if (ship.Cargo_Type != _CargoType.NoCargo)
					{
						if (ship.m_OnboardCargos.Count<Cargo>() > 0)
						{
							float num = ship.GetShipKinematics().vmethod_22() / 2f;
							if ((double)cargoMission.AreaPoints.Select(new Func<ReferencePoint, float>(this.method_55)).Average() < (double)num * 0.75)
							{
								ship.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
							}
						}
						else
						{
							object obj = ActiveUnit_DockingOps.object_0;
							ObjectFlowControl.CheckForSyncLockOnValueType(obj);
							lock (obj)
							{
								Ship ship2 = (Ship)this.GetAssignedHostUnit(false);
								List<Cargo> list = new List<Cargo>();
								double num2 = (double)ship.Cargo_Mass;
								double num3 = (double)ship.Cargo_Area;
								double num4 = (double)ship.Cargo_Crew;
								foreach (Cargo current in ship2.m_OnboardCargos.OrderBy(ActiveUnit_DockingOps.CargoFunc2))
								{
									if (current.GetCurrentType() == Cargo._CargoType.const_1)
									{
										Mount mount = (Mount)current.GetCargo();
										if (mount.Cargo_Type <= ship.Cargo_Type && cargoMission.dictionary_MountsToUnload.ContainsKey(mount.DBID) && cargoMission.dictionary_MountsToUnload[mount.DBID] >= 1 && (num2 >= (double)mount.Cargo_Mass & num3 >= (double)mount.Cargo_Area & num4 >= (double)mount.Cargo_Crew))
										{
											list.Add(current);
											num2 -= (double)mount.Cargo_Mass;
											num3 -= (double)mount.Cargo_Area;
											num4 -= (double)mount.Cargo_Crew;
											Dictionary<int, int> dictionary_MountsToUnload;
											int dBID;
											(dictionary_MountsToUnload = cargoMission.dictionary_MountsToUnload)[dBID = mount.DBID] = dictionary_MountsToUnload[dBID] - 1;
										}
									}
								}
								if (list.Count > 0)
								{
									ship2.GetDockingOps().method_53(ship2, ship, list);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x000D7B8C File Offset: 0x000D5D8C
		public void ScheduleDockingOpsEvent(float elapsedTime_)
		{
			try
			{
				this.RefuelDockedUnits(elapsedTime_);
				this.ReloadDockedUnits(elapsedTime_);
				this.RepairDockedUnits();
				this.CT -= (double)elapsedTime_;
				if (this.CT < 0.0)
				{
					this.CT = 0.0;
				}
				if (this.CT == 0.0)
				{
					switch (this.GetDockingOpsCondition())
					{
					case ActiveUnit_DockingOps._DockingOpsCondition.Docked:
						this.CarryOutCargoOps();
						break;
					case ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway:
						this.Leave(elapsedTime_);
						break;
					case ActiveUnit_DockingOps._DockingOpsCondition.Docking:
						this.method_46();
						break;
					case ActiveUnit_DockingOps._DockingOpsCondition.Readying:
						this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Docked);
						break;
					case ActiveUnit_DockingOps._DockingOpsCondition.ManoeuveringToRefuel:
						this.method_35();
						break;
					case ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP:
						this.ProvideFuelUNREP(elapsedTime_);
						this.ProvideWeaponUNREP(elapsedTime_);
						this.CompleteUNREP();
						if (!this.HasUNREPTargetUnit())
						{
							this.ParentPlatform.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
							this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100143", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x000D7CD4 File Offset: 0x000D5ED4
		private void CompleteUNREP()
		{
			try
			{
				if (!string.IsNullOrEmpty(this.UNREP_Port))
				{
					ActiveUnit activeUnit = this.ParentPlatform.m_Scenario.GetActiveUnits()[this.UNREP_Port];
					if (this.ParentPlatform.GetHorizontalRange(activeUnit) > this.UNREPRangeLimit * 2f)
					{
						activeUnit.GetDockingOps().FinishUNREP();
					}
					else if (this.GetRefuelingQuantity(activeUnit) <= 0 && this.GetReloadQuantity(activeUnit) <= 0)
					{
						activeUnit.GetDockingOps().FinishUNREP();
					}
				}
				if (!string.IsNullOrEmpty(this.UNREP_Starboard))
				{
					ActiveUnit activeUnit2 = this.ParentPlatform.m_Scenario.GetActiveUnits()[this.UNREP_Starboard];
					if (this.ParentPlatform.GetHorizontalRange(activeUnit2) > this.UNREPRangeLimit * 2f)
					{
						activeUnit2.GetDockingOps().FinishUNREP();
					}
					else if (this.GetRefuelingQuantity(activeUnit2) <= 0 && this.GetReloadQuantity(activeUnit2) <= 0)
					{
						activeUnit2.GetDockingOps().FinishUNREP();
					}
				}
				if (!string.IsNullOrEmpty(this.UNREP_Astern))
				{
					ActiveUnit activeUnit2 = this.ParentPlatform.m_Scenario.GetActiveUnits()[this.UNREP_Astern];
					if (this.ParentPlatform.GetHorizontalRange(activeUnit2) > this.UNREPRangeLimit * 2f)
					{
						activeUnit2.GetDockingOps().FinishUNREP();
					}
					else if (this.GetRefuelingQuantity(activeUnit2) <= 0 && this.GetReloadQuantity(activeUnit2) <= 0)
					{
						activeUnit2.GetDockingOps().FinishUNREP();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100144", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x000D7EA8 File Offset: 0x000D60A8
		public void FinishUNREP()
		{
			try
			{
				if (!Information.IsNothing(this.GetUNREPDestinationUnit()))
				{
					ActiveUnit uNREPDestinationUnit = this.GetUNREPDestinationUnit();
					if (Operators.CompareString(this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Port, this.ParentPlatform.GetGuid(), false) == 0)
					{
						this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Port = null;
						this.SetUNREPDestinationUnit(null);
						this.ParentPlatform.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
						this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
					}
					else if (Operators.CompareString(this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Starboard, this.ParentPlatform.GetGuid(), false) == 0)
					{
						this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Starboard = null;
						this.SetUNREPDestinationUnit(null);
						this.ParentPlatform.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
						this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
					}
					else if (Operators.CompareString(this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Astern, this.ParentPlatform.GetGuid(), false) == 0)
					{
						this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Astern = null;
						this.SetUNREPDestinationUnit(null);
						this.ParentPlatform.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
						this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
					}
					else if (!Information.IsNothing(uNREPDestinationUnit) && uNREPDestinationUnit.GetDockingOps().GetUNREPQueue().Contains(this.ParentPlatform.GetGuid()))
					{
						uNREPDestinationUnit.GetDockingOps().GetUNREPQueue().Remove(this.ParentPlatform.GetGuid());
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100145", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x000D8078 File Offset: 0x000D6278
		private void RefuelDockedUnits(float elapsedTime_)
		{
			float num = 63.33f;
			foreach (ActiveUnit current in this.GetDockedUnits())
			{
				ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = current.GetDockingOps().GetDockingOpsCondition();
				if (dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.Docked || dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.Readying)
				{
					int num2 = 0;
					switch (current.GetTargetVisualSizeClass())
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						num2 = 1;
						break;
					case GlobalVariables.TargetVisualSizeClass.Small:
						num2 = 2;
						break;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						num2 = 3;
						break;
					case GlobalVariables.TargetVisualSizeClass.Large:
						num2 = 4;
						break;
					case GlobalVariables.TargetVisualSizeClass.VLarge:
						num2 = 5;
						break;
					}
					float val = num * (float)num2 * elapsedTime_;
					using (IEnumerator<FuelRec> enumerator2 = current.GetFuelRecs().Where(ActiveUnit_DockingOps.FuelRecFunc3).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							ActiveUnit_DockingOps.Class39 @class = new ActiveUnit_DockingOps.Class39(null);
							@class.fuelRecord = enumerator2.Current;
							if (@class.fuelRecord.FuelType == FuelRec._FuelType.Battery)
							{
								@class.fuelRecord.CurrentQuantity = (float)@class.fuelRecord.MaxQuantity;
							}
							else
							{
								FuelRec fuelRec;
								if (this.ParentPlatform.IsFixedFacility())
								{
									fuelRec = new FuelRec(2147483647, (short)@class.fuelRecord.FuelType);
								}
								else
								{
									fuelRec = this.ParentPlatform.GetFuelRecs().Where(new Func<FuelRec, bool>(@class.method_0)).DefaultIfEmpty(null).FirstOrDefault<FuelRec>();
								}
								if (!Information.IsNothing(fuelRec))
								{
									float num3 = (float)@class.fuelRecord.MaxQuantity - @class.fuelRecord.CurrentQuantity;
									float num4 = Math.Min(val, fuelRec.CurrentQuantity);
									if (num3 >= num4)
									{
										current.TransferFuel(num4, fuelRec.FuelType);
										fuelRec.CurrentQuantity -= num4;
										this.ParentPlatform.ExportFuelTransfer(current, num4, fuelRec.FuelType);
									}
									else
									{
										current.TransferFuel(num3, fuelRec.FuelType);
										fuelRec.CurrentQuantity -= num3;
										this.ParentPlatform.ExportFuelTransfer(current, num3, fuelRec.FuelType);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x000D82E4 File Offset: 0x000D64E4
		private void ProvideFuelUNREP(float elapsedTime_)
		{
			float num = 63.33f;
			try
			{
				if (!string.IsNullOrEmpty(this.UNREP_Port))
				{
					ActiveUnit activeUnit = this.ParentPlatform.m_Scenario.GetActiveUnits()[this.UNREP_Port];
					byte refuelToPort_Out = this.ParentPlatform.RefuelOrReplenish.RefuelToPort_Out;
					float val = num * (float)refuelToPort_Out * elapsedTime_;
					using (IEnumerator<FuelRec> enumerator = activeUnit.GetFuelRecs().Where(ActiveUnit_DockingOps.FuelRecFunc4).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							ActiveUnit_DockingOps.Class40 @class = new ActiveUnit_DockingOps.Class40(null);
							@class.fuelRecord = enumerator.Current;
							FuelRec fuelRec = this.ParentPlatform.GetFuelRecs().Where(new Func<FuelRec, bool>(@class.method_0)).DefaultIfEmpty(null).FirstOrDefault<FuelRec>();
							if (!Information.IsNothing(fuelRec))
							{
								float num2 = (float)@class.fuelRecord.MaxQuantity - @class.fuelRecord.CurrentQuantity;
								float num3 = Math.Min(val, fuelRec.CurrentQuantity);
								if (num2 >= num3)
								{
									activeUnit.TransferFuel(num3, fuelRec.FuelType);
									fuelRec.CurrentQuantity -= num3;
									this.ParentPlatform.ExportFuelTransfer(activeUnit, num3, fuelRec.FuelType);
								}
								else
								{
									activeUnit.TransferFuel(num2, fuelRec.FuelType);
									fuelRec.CurrentQuantity -= num2;
									this.ParentPlatform.ExportFuelTransfer(activeUnit, num2, fuelRec.FuelType);
								}
							}
						}
					}
				}
				if (!string.IsNullOrEmpty(this.UNREP_Starboard))
				{
					ActiveUnit activeUnit2 = this.ParentPlatform.m_Scenario.GetActiveUnits()[this.UNREP_Starboard];
					byte refuelToStarboard_Out = this.ParentPlatform.RefuelOrReplenish.RefuelToStarboard_Out;
					float val2 = num * (float)refuelToStarboard_Out * elapsedTime_;
					using (IEnumerator<FuelRec> enumerator2 = activeUnit2.GetFuelRecs().Where(ActiveUnit_DockingOps.FuelRecFunc5).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							ActiveUnit_DockingOps.Class41 class2 = new ActiveUnit_DockingOps.Class41(null);
							class2.fuelRecord = enumerator2.Current;
							FuelRec fuelRec2 = this.ParentPlatform.GetFuelRecs().Where(new Func<FuelRec, bool>(class2.method_0)).DefaultIfEmpty(null).FirstOrDefault<FuelRec>();
							if (!Information.IsNothing(fuelRec2))
							{
								float num4 = (float)class2.fuelRecord.MaxQuantity - class2.fuelRecord.CurrentQuantity;
								float num5 = Math.Min(val2, fuelRec2.CurrentQuantity);
								if (num4 >= num5)
								{
									activeUnit2.TransferFuel(num5, fuelRec2.FuelType);
									fuelRec2.CurrentQuantity -= num5;
									this.ParentPlatform.ExportFuelTransfer(activeUnit2, num5, fuelRec2.FuelType);
								}
								else
								{
									activeUnit2.TransferFuel(num4, fuelRec2.FuelType);
									fuelRec2.CurrentQuantity -= num4;
									this.ParentPlatform.ExportFuelTransfer(activeUnit2, num4, fuelRec2.FuelType);
								}
							}
						}
					}
				}
				if (!string.IsNullOrEmpty(this.UNREP_Astern))
				{
					ActiveUnit activeUnit3 = this.ParentPlatform.m_Scenario.GetActiveUnits()[this.UNREP_Astern];
					byte refuelToAstern_Out = this.ParentPlatform.RefuelOrReplenish.RefuelToAstern_Out;
					float val3 = num * (float)refuelToAstern_Out * elapsedTime_;
					using (IEnumerator<FuelRec> enumerator3 = activeUnit3.GetFuelRecs().Where(ActiveUnit_DockingOps.FuelRecFunc6).GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							ActiveUnit_DockingOps.Class42 class3 = new ActiveUnit_DockingOps.Class42(null);
							class3.fuelRecord = enumerator3.Current;
							FuelRec fuelRec3 = this.ParentPlatform.GetFuelRecs().Where(new Func<FuelRec, bool>(class3.method_0)).DefaultIfEmpty(null).FirstOrDefault<FuelRec>();
							if (!Information.IsNothing(fuelRec3))
							{
								float num6 = (float)class3.fuelRecord.MaxQuantity - class3.fuelRecord.CurrentQuantity;
								float num7 = Math.Min(val3, fuelRec3.CurrentQuantity);
								if (num6 >= num7)
								{
									activeUnit3.TransferFuel(num7, fuelRec3.FuelType);
									fuelRec3.CurrentQuantity -= num7;
									this.ParentPlatform.ExportFuelTransfer(activeUnit3, num7, fuelRec3.FuelType);
								}
								else
								{
									activeUnit3.TransferFuel(num6, fuelRec3.FuelType);
									fuelRec3.CurrentQuantity -= num6;
									this.ParentPlatform.ExportFuelTransfer(activeUnit3, num6, fuelRec3.FuelType);
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
				ex2.Data.Add("Error at 100146", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x000D87E8 File Offset: 0x000D69E8
		private void RepairDockedUnits()
		{
			if (this.ParentPlatform.m_Scenario.FifteenthMinuteIsChangingOnThisPulse)
			{
				foreach (ActiveUnit current in this.GetDockedUnits())
				{
					current.GetDamage().DoRepair(this.ParentPlatform.GetProficiencyLevel().Value);
					current.GetDamage().PutOffFireOrFloodingDisaster(this.ParentPlatform.GetProficiencyLevel().Value);
				}
			}
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x000D8884 File Offset: 0x000D6A84
		private bool method_29(Weapon weapon_)
		{
			bool result;
			if (weapon_.WeightMax > 0)
			{
				int weightMax = weapon_.WeightMax;
				if (weightMax <= 10)
				{
					if (this.ParentPlatform.m_Scenario.SecondIsChangingOnThisPulse)
					{
						result = true;
						return result;
					}
				}
				else if (weightMax <= 50)
				{
					if (this.ParentPlatform.m_Scenario.FifthSecondIsChangingOnThisPulse)
					{
						result = true;
						return result;
					}
				}
				else if (weightMax <= 100)
				{
					if (this.ParentPlatform.m_Scenario.FifteenthSecondIsChangingOnThisPulse)
					{
						result = true;
						return result;
					}
				}
				else if (weightMax <= 150)
				{
					if (this.ParentPlatform.m_Scenario.ThirtiethSecondIsChangingOnThisPulse)
					{
						result = true;
						return result;
					}
				}
				else if (weightMax <= 250)
				{
					if (this.ParentPlatform.m_Scenario.MinuteIsChangingOnThisPulse)
					{
						result = true;
						return result;
					}
				}
				else if (weightMax <= 500)
				{
					if (this.ParentPlatform.m_Scenario.FifthMinuteIsChangingOnThisPulse)
					{
						result = true;
						return result;
					}
				}
				else if (weightMax <= 1000)
				{
					if (this.ParentPlatform.m_Scenario.FifteenthMinuteIsChangingOnThisPulse)
					{
						result = true;
						return result;
					}
				}
				else if (weightMax <= 2500)
				{
					if (this.ParentPlatform.m_Scenario.ThirtiethMinuteIsChangingOnThisPulse)
					{
						result = true;
						return result;
					}
				}
				else if (this.ParentPlatform.m_Scenario.HourIsChangingOnThisPulse)
				{
					result = true;
					return result;
				}
			}
			else
			{
				Weapon._WeaponType weaponType = weapon_.GetWeaponType();
				if (weaponType <= Weapon._WeaponType.DropTank)
				{
					switch (weaponType)
					{
					case Weapon._WeaponType.Rocket:
					case Weapon._WeaponType.Gun:
					{
						Warhead.WarheadCaliber caliber = weapon_.m_Warheads[0].Caliber;
						switch (caliber)
						{
						case Warhead.WarheadCaliber.Gun_6_15mm:
							break;
						case Warhead.WarheadCaliber.Gun_16_24mm:
							goto IL_296;
						case Warhead.WarheadCaliber.Gun_25_60mm:
							goto IL_2B5;
						case Warhead.WarheadCaliber.Gun_61_80mm:
							goto IL_2D4;
						case Warhead.WarheadCaliber.Gun_81_150mm:
							goto IL_2F3;
						case Warhead.WarheadCaliber.Gun_151_200mm:
							goto IL_312;
						case Warhead.WarheadCaliber.Gun_201_350mm:
							goto IL_331;
						case Warhead.WarheadCaliber.Gun_351_450mm:
							goto IL_350;
						default:
							switch (caliber)
							{
							case Warhead.WarheadCaliber.Rocket_6_15mm:
								break;
							case Warhead.WarheadCaliber.Rocket_16_24mm:
								goto IL_296;
							case Warhead.WarheadCaliber.Rocket_25_60mm:
								goto IL_2B5;
							case Warhead.WarheadCaliber.Rocket_61_80mm:
								goto IL_2D4;
							case Warhead.WarheadCaliber.Rocket_81_150mm:
								goto IL_2F3;
							case Warhead.WarheadCaliber.Rocket_151_200mm:
								goto IL_312;
							case Warhead.WarheadCaliber.Rocket_201_350mm:
								goto IL_331;
							case Warhead.WarheadCaliber.Rocket_351_450mm:
								goto IL_350;
							default:
								if (this.ParentPlatform.m_Scenario.HourIsChangingOnThisPulse)
								{
									result = true;
									return result;
								}
								goto IL_454;
							}
							break;
						}
						if (this.ParentPlatform.m_Scenario.SecondIsChangingOnThisPulse)
						{
							result = true;
							return result;
						}
						goto IL_454;
						IL_296:
						if (this.ParentPlatform.m_Scenario.FifthSecondIsChangingOnThisPulse)
						{
							result = true;
							return result;
						}
						goto IL_454;
						IL_2B5:
						if (this.ParentPlatform.m_Scenario.FifteenthSecondIsChangingOnThisPulse)
						{
							result = true;
							return result;
						}
						goto IL_454;
						IL_2D4:
						if (this.ParentPlatform.m_Scenario.ThirtiethSecondIsChangingOnThisPulse)
						{
							result = true;
							return result;
						}
						goto IL_454;
						IL_2F3:
						if (this.ParentPlatform.m_Scenario.MinuteIsChangingOnThisPulse)
						{
							result = true;
							return result;
						}
						goto IL_454;
						IL_312:
						if (this.ParentPlatform.m_Scenario.FifthMinuteIsChangingOnThisPulse)
						{
							result = true;
							return result;
						}
						goto IL_454;
						IL_331:
						if (this.ParentPlatform.m_Scenario.FifteenthMinuteIsChangingOnThisPulse)
						{
							result = true;
							return result;
						}
						goto IL_454;
						IL_350:
						if (this.ParentPlatform.m_Scenario.ThirtiethMinuteIsChangingOnThisPulse)
						{
							result = true;
							return result;
						}
						goto IL_454;
					}
					case Weapon._WeaponType.IronBomb:
					case Weapon._WeaponType.Decoy_Towed:
					case Weapon._WeaponType.TrainingRound:
						break;
					case Weapon._WeaponType.Decoy_Expendable:
					case Weapon._WeaponType.Decoy_Vehicle:
						if (this.ParentPlatform.m_Scenario.FifthMinuteIsChangingOnThisPulse)
						{
							result = true;
							return result;
						}
						goto IL_454;
					case Weapon._WeaponType.Dispenser:
						if (this.ParentPlatform.m_Scenario.FifthMinuteIsChangingOnThisPulse)
						{
							result = true;
							return result;
						}
						goto IL_454;
					default:
						if (weaponType == Weapon._WeaponType.DropTank)
						{
							if (this.ParentPlatform.m_Scenario.FifthMinuteIsChangingOnThisPulse)
							{
								result = true;
								return result;
							}
							goto IL_454;
						}
						break;
					}
				}
				else
				{
					switch (weaponType)
					{
					case Weapon._WeaponType.DepthCharge:
						if (this.ParentPlatform.m_Scenario.FifthMinuteIsChangingOnThisPulse)
						{
							result = true;
							return result;
						}
						goto IL_454;
					case Weapon._WeaponType.Sonobuoy:
					case (Weapon._WeaponType)4010:
						break;
					case Weapon._WeaponType.BottomMine:
					case Weapon._WeaponType.MooredMine:
					case Weapon._WeaponType.FloatingMine:
					case Weapon._WeaponType.MovingMine:
					case Weapon._WeaponType.RisingMine:
					case Weapon._WeaponType.DriftingMine:
					case Weapon._WeaponType.DummyMine:
						if (this.ParentPlatform.m_Scenario.FifthMinuteIsChangingOnThisPulse)
						{
							result = true;
							return result;
						}
						goto IL_454;
					default:
						if (weaponType == Weapon._WeaponType.Laser)
						{
							if (this.ParentPlatform.m_Scenario.FifthMinuteIsChangingOnThisPulse)
							{
								result = true;
								return result;
							}
							goto IL_454;
						}
						break;
					}
				}
				if (this.ParentPlatform.m_Scenario.FifthMinuteIsChangingOnThisPulse)
				{
					result = true;
					return result;
				}
			}
			IL_454:
			result = false;
			return result;
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x000D8CE8 File Offset: 0x000D6EE8
		private void provideWeaponUNREPTo(ActiveUnit currentUnitReceivingUNREP_)
		{
			if (this.GetReloadQuantity(currentUnitReceivingUNREP_) > 0)
			{
				Dictionary<int, Weapon> weaponsDictionary = currentUnitReceivingUNREP_.GetWeaponry().GetWeaponsDictionary(true);
				int num = 1;
				if (this.ParentPlatform.RefuelOrReplenish.RefuelFromPort_In == 4 | this.ParentPlatform.RefuelOrReplenish.RefuelFromStarboard_In == 4)
				{
					num *= 4;
				}
				else if (this.ParentPlatform.RefuelOrReplenish.RefuelFromPort_In == 3 | this.ParentPlatform.RefuelOrReplenish.RefuelFromStarboard_In == 3)
				{
					num *= 3;
				}
				else if (this.ParentPlatform.RefuelOrReplenish.RefuelFromPort_In == 2 | this.ParentPlatform.RefuelOrReplenish.RefuelFromStarboard_In == 2)
				{
					num *= 2;
				}
				if (this.ParentPlatform.IsFacility)
				{
					num *= 2;
				}
				if (currentUnitReceivingUNREP_.IsSubmarine)
				{
					num = Math.Max(1, (int)Math.Round((double)num / 2.0));
				}
				foreach (int current in weaponsDictionary.Keys)
				{
					if (num == 0)
					{
						break;
					}
					Weapon weapon = this.ParentPlatform.m_Scenario.GetWeapon(current);
					if (currentUnitReceivingUNREP_.GetWeaponry().GetDefaultLoadForWeapon(current) - currentUnitReceivingUNREP_.GetWeaponry().GetCurrentLoadForWeapon(current, false) != 0 && this.method_29(weapon))
					{
						if (this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags))
						{
							if (Operators.CompareString(currentUnitReceivingUNREP_.GetWeaponry().vmethod_8(current, false, false), "OK", false) == 0)
							{
								num--;
							}
						}
						else
						{
							Magazine[] magazines;
							if (this.ParentPlatform.HasParentGroup() && this.ParentPlatform.GetParentGroup(false).HasFixedFacility())
							{
								magazines = this.ParentPlatform.GetParentGroup(false).GetMagazines();
							}
							else
							{
								magazines = this.ParentPlatform.GetMagazines();
							}
							Magazine[] array = magazines;
							for (int i = 0; i < array.Length; i = checked(i + 1))
							{
								Magazine magazine = array[i];
								foreach (WeaponRec current2 in magazine.GetWeaponRecCollection())
								{
									if (current2.GetCurrentLoad() > 0 && current2.WeapID == current && Operators.CompareString(currentUnitReceivingUNREP_.GetWeaponry().vmethod_8(current, false, false), "OK", false) == 0)
									{
										current2.SetCurrentLoad(current2.GetCurrentLoad() - 1);
										current2.SetTimeToFire();
										num--;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x000D8FD8 File Offset: 0x000D71D8
		private void ReloadDockedUnits(float elapsedTime_)
		{
			foreach (ActiveUnit current in this.GetDockedUnits())
			{
				ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = current.GetDockingOps().GetDockingOpsCondition();
				if (dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.Docked || dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.Readying)
				{
					this.provideWeaponUNREPTo(current);
				}
			}
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x000D9048 File Offset: 0x000D7248
		private void ProvideWeaponUNREP(float elapsedTime_)
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			try
			{
				if (!string.IsNullOrEmpty(this.UNREP_Port))
				{
					list.Add(this.ParentPlatform.m_Scenario.GetActiveUnits()[this.UNREP_Port]);
				}
				if (!string.IsNullOrEmpty(this.UNREP_Starboard))
				{
					list.Add(this.ParentPlatform.m_Scenario.GetActiveUnits()[this.UNREP_Starboard]);
				}
				if (!string.IsNullOrEmpty(this.UNREP_Astern))
				{
					list.Add(this.ParentPlatform.m_Scenario.GetActiveUnits()[this.UNREP_Astern]);
				}
				foreach (ActiveUnit current in list)
				{
					string guid = current.GetGuid();
					if (Operators.CompareString(guid, this.UNREP_Port, false) == 0)
					{
						this.provideWeaponUNREPTo(current);
					}
					else if (Operators.CompareString(guid, this.UNREP_Starboard, false) == 0)
					{
						this.provideWeaponUNREPTo(current);
					}
					else if (Operators.CompareString(guid, this.UNREP_Astern, false) == 0)
					{
						this.provideWeaponUNREPTo(current);
					}
					else if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100147", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x000D91F8 File Offset: 0x000D73F8
		public int GetRefuelingQuantity(ActiveUnit currentUnitReceivingUNREP_)
		{
			int result = 0;
			checked
			{
				try
				{
					FuelRec[] fuelRecs = currentUnitReceivingUNREP_.GetFuelRecs();
					int num = 0;
					for (int i = 0; i < fuelRecs.Length; i++)
					{
						FuelRec fuelRec = fuelRecs[i];
						if (fuelRec.CurrentQuantity < (float)fuelRec.MaxQuantity)
						{
							int num2 = unchecked((int)Math.Round((double)((float)fuelRec.MaxQuantity - fuelRec.CurrentQuantity)));
							int num3 = 0;
							FuelRec[] fuelRecs2 = this.ParentPlatform.GetFuelRecs();
							for (int j = 0; j < fuelRecs2.Length; j++)
							{
								FuelRec fuelRec2 = fuelRecs2[j];
								if (fuelRec2.FuelType == fuelRec.FuelType)
								{
									num3 = unchecked((int)Math.Round((double)((float)num3 + fuelRec2.CurrentQuantity)));
								}
							}
							unchecked
							{
								if (num2 >= num3)
								{
									num += num3;
								}
								else
								{
									num += num2;
								}
							}
						}
					}
					result = num;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 100148", "");
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

		// Token: 0x06002132 RID: 8498 RVA: 0x000D9320 File Offset: 0x000D7520
		public int GetReloadQuantity(ActiveUnit currentUnitReceivingUNREP_)
		{
			int result = 0;
			try
			{
				Dictionary<int, Weapon> weaponsDictionary = currentUnitReceivingUNREP_.GetWeaponry().GetWeaponsDictionary(true);
				int num = 0;
				foreach (int current in weaponsDictionary.Keys)
				{
					int defaultLoadForWeapon = currentUnitReceivingUNREP_.GetWeaponry().GetDefaultLoadForWeapon(current);
					int currentLoadForWeapon = currentUnitReceivingUNREP_.GetWeaponry().GetCurrentLoadForWeapon(current, false);
					int num2 = defaultLoadForWeapon - currentLoadForWeapon;
					if (num2 > 0)
					{
						int num3;
						if (this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags))
						{
							num3 = 2147483647;
						}
						else
						{
							num3 = this.ParentPlatform.GetWeaponry().GetWeaponLoadsInMagazines(current);
						}
						if (num2 >= num3)
						{
							num += num3;
						}
						else
						{
							num += num2;
						}
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100149", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x000D9458 File Offset: 0x000D7658
		public bool method_35()
		{
			bool result = false;
			try
			{
				if (this.ParentPlatform.GetHorizontalRange(this.GetUNREPDestinationUnit()) > this.UNREPRangeLimit)
				{
					result = false;
				}
				else if (this.GetUNREPDestinationUnit().GetCurrentSpeed() > 0f && this.ParentPlatform.GetCurrentSpeed() > 0f && Math.Abs(Class263.RelativeBearingTo(this.ParentPlatform.GetCurrentHeading(), this.GetUNREPDestinationUnit().GetCurrentHeading())) > 20f)
				{
					result = false;
				}
				else if (this.GetUNREPDestinationUnit().CanRefuelOrUNREP(this.ParentPlatform) && (string.IsNullOrEmpty(this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Port) || string.IsNullOrEmpty(this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Starboard) || string.IsNullOrEmpty(this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Astern)))
				{
					this.method_36();
					result = true;
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
				ex2.Data.Add("Error at 100150", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x000D95A0 File Offset: 0x000D77A0
		private void method_36()
		{
			try
			{
				if (Operators.CompareString(this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Port, this.ParentPlatform.GetGuid(), false) != 0 && Operators.CompareString(this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Starboard, this.ParentPlatform.GetGuid(), false) != 0 && Operators.CompareString(this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Astern, this.ParentPlatform.GetGuid(), false) != 0)
				{
					if (string.IsNullOrEmpty(this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Port) && this.GetUNREPDestinationUnit().RefuelOrReplenish.RefuelToPort_Out > 0)
					{
						this.ParentPlatform.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Refuelling);
						this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Replenishing);
						this.GetUNREPDestinationUnit().GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP);
						this.GetUNREPDestinationUnit().GetDockingOps().GetUNREPQueue().Remove(this.ParentPlatform.GetGuid());
						this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Port = this.ParentPlatform.GetGuid();
					}
					else if (string.IsNullOrEmpty(this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Starboard) && this.GetUNREPDestinationUnit().RefuelOrReplenish.RefuelToStarboard_Out > 0)
					{
						this.ParentPlatform.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Refuelling);
						this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Replenishing);
						this.GetUNREPDestinationUnit().GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP);
						this.GetUNREPDestinationUnit().GetDockingOps().GetUNREPQueue().Remove(this.ParentPlatform.GetGuid());
						this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Starboard = this.ParentPlatform.GetGuid();
					}
					else if (string.IsNullOrEmpty(this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Astern) && this.GetUNREPDestinationUnit().RefuelOrReplenish.RefuelToAstern_Out > 0)
					{
						this.ParentPlatform.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Refuelling);
						this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Replenishing);
						this.GetUNREPDestinationUnit().GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.ProvidingUNREP);
						this.GetUNREPDestinationUnit().GetDockingOps().GetUNREPQueue().Remove(this.ParentPlatform.GetGuid());
						this.GetUNREPDestinationUnit().GetDockingOps().UNREP_Astern = this.ParentPlatform.GetGuid();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100151", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x000D983C File Offset: 0x000D7A3C
		public static bool smethod_5(DockFacility._DockFacilityPhysicalSizeCode dockFacilityPhysicalSizeCode_)
		{
			return dockFacilityPhysicalSizeCode_ - DockFacility._DockFacilityPhysicalSizeCode.VerySmallDock_Davit <= 3 || dockFacilityPhysicalSizeCode_ == DockFacility._DockFacilityPhysicalSizeCode.DryDeckShelter || dockFacilityPhysicalSizeCode_ == DockFacility._DockFacilityPhysicalSizeCode.ROV_UUV;
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x000D9874 File Offset: 0x000D7A74
		public bool method_37(ActiveUnit activeUnit_)
		{
			bool flag = false;
			bool result;
			try
			{
				int num;
				DockFacility._DockFacilityPhysicalSizeCode physicalSizeCode;
				if (activeUnit_.IsShip)
				{
					num = (int)Math.Round((double)((Ship)activeUnit_).Length);
					physicalSizeCode = ((Ship)activeUnit_).physicalSizeCode;
				}
				else
				{
					if (!activeUnit_.IsSubmarine)
					{
						throw new NotImplementedException();
					}
					num = (int)Math.Round((double)((Submarine)activeUnit_).Length);
					physicalSizeCode = ((Submarine)activeUnit_).PhysicalSizeCode;
				}
				DockFacility[] dockFacilities = this.ParentPlatform.GetDockFacilities();
				checked
				{
					for (int i = 0; i < dockFacilities.Length; i++)
					{
						DockFacility dockFacility = dockFacilities[i];
						if (dockFacility.method_28(unchecked((short)num), physicalSizeCode) && dockFacility.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							flag = true;
							result = true;
							return result;
						}
					}
					flag = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100152", "");
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

		// Token: 0x06002137 RID: 8503 RVA: 0x000D9984 File Offset: 0x000D7B84
		public bool method_38(short short_0, DockFacility._DockFacilityPhysicalSizeCode DockFacilityPhysicalSizeCode_)
		{
			bool flag = false;
			checked
			{
				bool result;
				try
				{
					DockFacility[] dockFacilities = this.ParentPlatform.GetDockFacilities();
					for (int i = 0; i < dockFacilities.Length; i++)
					{
						DockFacility dockFacility = dockFacilities[i];
						if (dockFacility.method_28(short_0, DockFacilityPhysicalSizeCode_) && dockFacility.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
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
					ex2.Data.Add("Error at 100153", "");
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

		// Token: 0x06002138 RID: 8504 RVA: 0x000D9A30 File Offset: 0x000D7C30
		public void method_39(ActiveUnit activeUnit_)
		{
			try
			{
				DockFacility dockFacility = this.method_43(activeUnit_);
				activeUnit_.GetDockingOps().SetDockFacility(dockFacility);
				activeUnit_.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Docked);
				activeUnit_.GetDockingOps().SetAssignedHostUnit(false, this.ParentPlatform);
				activeUnit_.SetAltitude_ASL(false, 0f);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100154", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x000D9ACC File Offset: 0x000D7CCC
		public void method_40(ActiveUnit excludeUnit = null)
		{
			try
			{
				ActiveUnit_DockingOps.Class43 @class = new ActiveUnit_DockingOps.Class43();
				@class.activeUnit_DockingOps_0 = this;
				if (this.ParentPlatform.IsShip || this.ParentPlatform.IsSubmarine)
				{
					@class.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
					@class.float_0 = this.ParentPlatform.GetKinematics().vmethod_20(true, null, null);
					Parallel.ForEach<ActiveUnit>(this.ParentPlatform.GetSide(false).ActiveUnitArray.ToList<ActiveUnit>(), new Action<ActiveUnit>(@class.method_0));
					List<ActiveUnit> list = @class.concurrentBag_0.ToList<ActiveUnit>();
					if (!Information.IsNothing(excludeUnit) && list.Contains(excludeUnit))
					{
						list.Remove(excludeUnit);
					}
					if (list.Count > 0)
					{
						int index = GameGeneral.GetRandom().Next(0, list.Count);
						this.SetAssignedHostUnit(false, list[index]);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100155", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x000D9C14 File Offset: 0x000D7E14
		public void PickNewHostUnit()
		{
			try
			{
				Collection<ActiveUnit> collection = new Collection<ActiveUnit>();
				if (!Information.IsNothing(this.GetCurrentHostUnit()))
				{
					this.SetAssignedHostUnit(false, this.GetCurrentHostUnit());
				}
				else
				{
					List<ActiveUnit> list = this.ParentPlatform.GetSide(false).ActiveUnitArray.ToList<ActiveUnit>();
					foreach (ActiveUnit current in list)
					{
						if (Operators.CompareString(this.method_42(current), "OK", false) == 0)
						{
							collection.Add(current);
						}
					}
					if (collection.Count > 0)
					{
						double num = 99999999999.0;
						ActiveUnit value = null;
						foreach (ActiveUnit current2 in collection)
						{
							double num2 = (double)Math2.GetDistance(current2.GetLatitude(null), current2.GetLongitude(null), this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null));
							if (num2 < num)
							{
								num = num2;
								value = current2;
							}
						}
						this.SetAssignedHostUnit(false, value);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100156", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x000D9DF4 File Offset: 0x000D7FF4
		public string method_42(ActiveUnit HostUnit_)
		{
			string text = "";
			string result;
			try
			{
				int num;
				DockFacility._DockFacilityPhysicalSizeCode physicalSizeCode;
				if (this.ParentPlatform.IsShip)
				{
					num = (int)Math.Round((double)((Ship)this.ParentPlatform).Length);
					physicalSizeCode = ((Ship)this.ParentPlatform).physicalSizeCode;
				}
				else
				{
					if (!this.ParentPlatform.IsSubmarine)
					{
						text = "Not possible";
						result = text;
						return result;
					}
					num = (int)Math.Round((double)((Submarine)this.ParentPlatform).Length);
					physicalSizeCode = ((Submarine)this.ParentPlatform).PhysicalSizeCode;
				}
				if (HostUnit_.GetDockingOps().method_38((short)num, physicalSizeCode))
				{
					text = "OK";
				}
				else
				{
					text = "The boat cannot be hosted on any docking facility here";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100157", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = text;
			return result;
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x000D9F00 File Offset: 0x000D8100
		private DockFacility method_43(ActiveUnit activeUnit_)
		{
			List<DockFacility> list = new List<DockFacility>();
			DockFacility result = null;
			try
			{
				int num;
				DockFacility._DockFacilityPhysicalSizeCode physicalSizeCode;
				if (activeUnit_.IsShip)
				{
					num = (int)Math.Round((double)((Ship)activeUnit_).Length);
					physicalSizeCode = ((Ship)activeUnit_).physicalSizeCode;
				}
				else
				{
					if (!activeUnit_.IsSubmarine)
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
					}
					num = (int)Math.Round((double)((Submarine)activeUnit_).Length);
					physicalSizeCode = ((Submarine)activeUnit_).PhysicalSizeCode;
				}
				DockFacility[] dockFacilities = this.ParentPlatform.GetDockFacilities();
				checked
				{
					for (int i = 0; i < dockFacilities.Length; i++)
					{
						DockFacility dockFacility = dockFacilities[i];
						if (dockFacility.method_28(unchecked((short)num), physicalSizeCode) && dockFacility.GetComponentStatus() == PlatformComponent._ComponentStatus.Operational)
						{
							list.Add(dockFacility);
						}
					}
					if (list.Count > 0)
					{
						result = list.OrderBy(ActiveUnit_DockingOps.DockFacilityFunc7).ElementAtOrDefault(0);
					}
					else
					{
						result = null;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100158", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x000DA04C File Offset: 0x000D824C
		private void Leave(float elapsedTime_)
		{
			try
			{
				if (!Information.IsNothing(this.GetCurrentHostUnit()))
				{
					string name = this.GetCurrentHostUnit().Name;
					ActiveUnit currentHostUnit = this.GetCurrentHostUnit();
					this.ParentPlatform.SetLongitude(null, this.GetCurrentHostUnit().GetLongitude(null));
					this.ParentPlatform.SetLatitude(null, this.GetCurrentHostUnit().GetLatitude(null));
					this.ParentPlatform.SetAltitude_ASL(false, 0f);
					this.ParentPlatform.SetCurrentSpeed((float)(0.66666666666666663 * (double)this.ParentPlatform.GetKinematics().GetSpeed(this.ParentPlatform.GetCurrentAltitude_ASL(false), ActiveUnit.Throttle.Loiter)));
					this.ParentPlatform.SetDesiredSpeed(this.ParentPlatform.GetCurrentSpeed());
					this.ParentPlatform.SetCurrentHeading(this.GetCurrentHostUnit().GetCurrentHeading());
					this.SetDockFacility(null);
					this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Underway);
					this.ParentPlatform.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
					this.ParentPlatform.GetAI().TargetingContacts(elapsedTime_, true, true);
					this.ParentPlatform.GetAI().ThreatAssessment();
					this.ParentPlatform.GetAI().UpdateUnitStatus(elapsedTime_, false, false);
					if (this.ParentPlatform.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Unassigned)
					{
						this.ParentPlatform.LogMessage(this.ParentPlatform.Name + " 离开 " + name + "正在待命.", LoggedMessage.MessageType.DockingOps, 0, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
					}
					else if (this.ParentPlatform.IsGroupLead() && Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)))
					{
						this.ParentPlatform.LogMessage(this.ParentPlatform.Name + " 离开 " + name + "正在待命.", LoggedMessage.MessageType.DockingOps, 0, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
					}
					else
					{
						this.ParentPlatform.LogMessage(this.ParentPlatform.Name + " 离开 " + name + ".", LoggedMessage.MessageType.AirOps, 0, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
					}
					if (!Information.IsNothing(currentHostUnit) && currentHostUnit.GetDockingOps().HasPier())
					{
						double longitude_ = 0.0;
						double latitude_ = 0.0;
						GeoPointGenerator.GetOtherGeoPoint(currentHostUnit.GetLongitude(null), currentHostUnit.GetLatitude(null), ref longitude_, ref latitude_, 6.6499999999999995, (double)currentHostUnit.GetCurrentHeading());
						this.ParentPlatform.GetNavigator().method_43(0, new Waypoint(longitude_, latitude_, Waypoint.WaypointType.ManualPlottedCourseWaypoint, Waypoint._Creator.const_1, Waypoint._Category.const_0));
						this.ParentPlatform.SetThrottle(ActiveUnit.Throttle.Cruise, null);
					}
					this.ParentPlatform.GetSensory().SetIsObeysEMCON(true);
					this.ParentPlatform.GetSensory().ScheduleEMCONEvent(this.ParentPlatform.GetAllNoneMCMSensors());
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100159", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x000DA3F8 File Offset: 0x000D85F8
		public void method_45(ActiveUnit theHost, bool CancelDeployment = false)
		{
			DockFacility dockFacility;
			if (CancelDeployment && !Information.IsNothing(this.GetCurrentHostUnit()))
			{
				dockFacility = this.GetHostDockFacility();
			}
			else
			{
				dockFacility = theHost.GetDockingOps().method_43(this.ParentPlatform);
				if (Information.IsNothing(dockFacility))
				{
					return;
				}
			}
			try
			{
				this.SetDockFacility(dockFacility);
				if (CancelDeployment)
				{
					this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Docked);
					this.CT = 0.0;
				}
				else
				{
					this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Docking);
				}
				if (!Information.IsNothing(this.ParentPlatform.GetAssignedMission(false)))
				{
					if (this.ParentPlatform.GetAssignedMission(false).MissionClass == Mission._MissionClass.Ferry)
					{
						switch (((FerryMission)this.ParentPlatform.GetAssignedMission(false)).GetFerryMissionBehavior())
						{
						case FerryMission.FerryMissionBehavior.OneWay:
							this.ParentPlatform.DeleteMission(false, null);
							this.SetAssignedHostUnit(false, this.GetCurrentHostUnit());
							break;
						case FerryMission.FerryMissionBehavior.Cycle:
							this.ParentPlatform.GetAI().SwitchFerryCycleLegIsOutbound();
							break;
						case FerryMission.FerryMissionBehavior.Random:
							this.method_40(this.GetAssignedHostUnit(false));
							break;
						}
					}
					if (this.ParentPlatform.GetAssignedMission(false).MissionClass == Mission._MissionClass.Support && ((SupportMission)this.ParentPlatform.GetAssignedMission(false)).OTO)
					{
						this.ParentPlatform.DeleteMission(false, null);
					}
				}
				if (this.ParentPlatform.HasParentGroup() && this.ParentPlatform.GetParentGroup(false) != this.GetCurrentHostUnit().GetParentGroup(false))
				{
					this.ParentPlatform.method_121(false, true);
				}
				this.ParentPlatform.method_117();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100160", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x00013DA0 File Offset: 0x00011FA0
		private void method_46()
		{
			this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Docked);
			this.method_47();
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00013DAF File Offset: 0x00011FAF
		public void method_47()
		{
			this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Readying);
			this.CT = 1800.0;
			this.method_49();
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x000DA5E0 File Offset: 0x000D87E0
		public bool method_48()
		{
			ActiveUnit_DockingOps._DockingOpsCondition dockingOpsCondition = this.GetDockingOpsCondition();
			return dockingOpsCondition == ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway;
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x000DA5F8 File Offset: 0x000D87F8
		public void method_49()
		{
			try
			{
				foreach (Sensor current in this.ParentPlatform.GetMineCounterMeasures())
				{
					if (current.IsMineNeutralization())
					{
						current.method_25(true);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100161", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x000DA6A4 File Offset: 0x000D88A4
		public List<ActiveUnit> GetUNREPUnits(bool bool_0, List<Mission> theSelectedMissions, ref string FeedBack)
		{
			List<ActiveUnit> list = new List<ActiveUnit>();
			List<ActiveUnit> result = null;
			try
			{
				Doctrine._UseRefuel? useRefuelDoctrine = this.ParentPlatform.m_Doctrine.GetUseRefuelDoctrine(this.ParentPlatform.m_Scenario, false, false, false, false);
				byte? b = useRefuelDoctrine.HasValue ? new byte?((byte)useRefuelDoctrine.GetValueOrDefault()) : null;
				if ((b.HasValue ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					FeedBack = "Unit " + this.ParentPlatform.Name + " has a doctrine setting that disallows UNREP. As such, the unit will not refuel. Change the doctrine setting and try again.";
					result = list;
				}
				else
				{
					int num = 0;
					FeedBack = "No UNREP units are available.";
					foreach (ActiveUnit current in this.ParentPlatform.m_Scenario.GetActiveUnitList())
					{
						if (current != this.ParentPlatform && (current.GetSide(false) == this.ParentPlatform.GetSide(false) || current.GetSide(false).IsFriendlyToSide(this.ParentPlatform.GetSide(false))) && current.IsOperating())
						{
							if (current.IsRTB())
							{
								if (num < 1)
								{
									num = 1;
									FeedBack = "Tanker is RTB.";
								}
							}
							else if (!current.CanRefuelOrUNREP(this.ParentPlatform))
							{
								if (num < 2)
								{
									num = 2;
									FeedBack = string.Concat(new string[]
									{
										"Unit ",
										current.Name,
										" is an UNREP unit but cannot UNREP ",
										this.ParentPlatform.Name,
										"."
									});
								}
							}
							else
							{
								if (!Information.IsNothing(theSelectedMissions))
								{
									if (Information.IsNothing(current.GetAssignedMission(false)))
									{
										if (num < 3)
										{
											num = 3;
											FeedBack = "Mission " + theSelectedMissions[0].Name + " has no available tankers.";
											continue;
										}
										continue;
									}
									else
									{
										bool flag = true;
										foreach (Mission current2 in theSelectedMissions)
										{
											if (current.GetAssignedMission(false) == current2)
											{
												flag = false;
												break;
											}
										}
										if (flag)
										{
											if (num < 4)
											{
												num = 4;
												FeedBack = "Mission " + current.GetAssignedMission(false).Name + " has no available tankers.";
												continue;
											}
											continue;
										}
									}
								}
								if (bool_0)
								{
									ActiveUnit_AI aI = this.ParentPlatform.GetAI();
									Unit theTargetUnit_ = current;
									float? rangeToTargetUnit_ = null;
									float transitAltitude_ = 0f;
									float? speed_ = null;
									float currentHeading = this.ParentPlatform.GetCurrentHeading();
									float? nullable_ = new float?(0.15f);
									bool flag2 = false;
									if (!aI.CanReachTargetUnit(theTargetUnit_, rangeToTargetUnit_, transitAltitude_, speed_, currentHeading, ActiveUnit.Throttle.Full, nullable_, true, false, ref flag2))
									{
										if (num < 5)
										{
											num = 5;
											FeedBack = "作战单元" + this.ParentPlatform.Name + "找不到加油机。可能原因是加油队列太长。";
											continue;
										}
										continue;
									}
								}
								list.Add(current);
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
				ex2.Data.Add("Error at 100163", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x000DAA78 File Offset: 0x000D8C78
		public bool method_51(GeoPoint IntermediateTargetPoint, ActiveUnit theSelectedTanker, List<Mission> theSelectedMissions, string UserFeedback, int? DistanceLimit = null)
		{
			ActiveUnit_DockingOps.RangeMeasurer rangeMeasurer = new ActiveUnit_DockingOps.RangeMeasurer(null);
			rangeMeasurer.dockingOps = this;
			rangeMeasurer.intermediateTargetPoint = IntermediateTargetPoint;
			rangeMeasurer.distanceLimit = DistanceLimit;
			bool flag = false;
			bool result;
			try
			{
				if (!Information.IsNothing(theSelectedTanker))
				{
					if (theSelectedTanker.IsGroup)
					{
						if (Information.IsNothing(((Group)theSelectedTanker).GetGroupLead()))
						{
							flag = false;
							result = false;
							return result;
						}
						theSelectedTanker = ((Group)theSelectedTanker).GetGroupLead();
					}
					if (this.ManoeuverToRefuelFrom(theSelectedTanker))
					{
						flag = true;
					}
					else
					{
						UserFeedback = "不能与所选加油机相会.";
						flag = false;
					}
				}
				else
				{
					List<ActiveUnit> list = this.GetUNREPUnits(true, theSelectedMissions, ref UserFeedback);
					if (!Information.IsNothing(rangeMeasurer.distanceLimit))
					{
						list = list.Where(new Func<ActiveUnit, bool>(rangeMeasurer.IsWithinRange)).ToList<ActiveUnit>();
						if (list.Count == 0)
						{
							this.ParentPlatform.LogMessage(this.ParentPlatform.Name + "在" + (rangeMeasurer.distanceLimit.HasValue ? Conversions.ToString(rangeMeasurer.distanceLimit.GetValueOrDefault()) : null) + "海里之内没有合适的补给对象 - 取消海上补给行动.", LoggedMessage.MessageType.DockingOps, 0, false, new GeoPoint(this.ParentPlatform.GetLongitude(null), this.ParentPlatform.GetLatitude(null)));
							flag = false;
							result = false;
							return result;
						}
					}
					if (list.Count == 0)
					{
						flag = false;
					}
					else if (list.Contains(this.ParentPlatform.GetDockingOps().GetAssignedHostUnit(false)) && this.ManoeuverToRefuelFrom(this.ParentPlatform.GetDockingOps().GetAssignedHostUnit(false)))
					{
						flag = true;
					}
					else
					{
						if (Information.IsNothing(rangeMeasurer.intermediateTargetPoint))
						{
							ActiveUnit_DockingOps.Class46 @class = new ActiveUnit_DockingOps.Class46(null);
							@class.class44_0 = rangeMeasurer;
							@class.activeUnit_0 = this.GetAssignedHostUnit();
							if (Information.IsNothing(@class.activeUnit_0))
							{
								IEnumerable<ActiveUnit> enumerable = list.OrderBy(new Func<ActiveUnit, double>(this.method_56));
								using (IEnumerator<ActiveUnit> enumerator = enumerable.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										ActiveUnit current = enumerator.Current;
										if (this.ManoeuverToRefuelFrom(current))
										{
											flag = true;
											result = true;
											return result;
										}
									}
									goto IL_471;
								}
							}
							ActiveUnit_DockingOps.Class45 class2 = new ActiveUnit_DockingOps.Class45(null);
							class2.class46_0 = @class;
							class2.double_0 = this.ParentPlatform.GetApproxAngularDistanceInDegrees(class2.class46_0.activeUnit_0);
							IEnumerable<ActiveUnit> enumerable2 = list.Where(new Func<ActiveUnit, bool>(class2.method_0)).OrderBy(new Func<ActiveUnit, double>(this.method_57));
							if (enumerable2.Count<ActiveUnit>() > 0)
							{
								using (IEnumerator<ActiveUnit> enumerator2 = enumerable2.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										ActiveUnit current2 = enumerator2.Current;
										if (this.ManoeuverToRefuelFrom(current2))
										{
											flag = true;
											result = true;
											return result;
										}
									}
									goto IL_471;
								}
							}
							ActiveUnit._ActiveUnitFuelState activeUnitFuelState = this.ParentPlatform.GetActiveUnitFuelState(class2.class46_0.activeUnit_0, null);
							if (activeUnitFuelState != ActiveUnit._ActiveUnitFuelState.IsBingo && activeUnitFuelState != ActiveUnit._ActiveUnitFuelState.IsJoker)
							{
								goto IL_471;
							}
							IEnumerable<ActiveUnit> enumerable3 = list.OrderBy(new Func<ActiveUnit, double>(this.method_58));
							using (IEnumerator<ActiveUnit> enumerator3 = enumerable3.GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									ActiveUnit current3 = enumerator3.Current;
									if (this.ManoeuverToRefuelFrom(current3))
									{
										flag = true;
										result = true;
										return result;
									}
								}
								goto IL_471;
							}
						}
						ActiveUnit_DockingOps.Class47 class3 = new ActiveUnit_DockingOps.Class47(null);
						class3.class44_0 = rangeMeasurer;
						class3.double_0 = this.ParentPlatform.GetApproxAngularDistanceInDegrees(class3.class44_0.intermediateTargetPoint);
						IEnumerable<ActiveUnit> enumerable4 = list.Where(new Func<ActiveUnit, bool>(class3.method_0)).OrderBy(new Func<ActiveUnit, double>(this.method_59));
						if (enumerable4.Count<ActiveUnit>() > 0)
						{
							using (IEnumerator<ActiveUnit> enumerator4 = enumerable4.GetEnumerator())
							{
								while (enumerator4.MoveNext())
								{
									ActiveUnit current4 = enumerator4.Current;
									if (this.ManoeuverToRefuelFrom(current4))
									{
										flag = true;
										result = true;
										return result;
									}
								}
								goto IL_471;
							}
						}
						IEnumerable<ActiveUnit> enumerable5 = list.OrderBy(new Func<ActiveUnit, double>(class3.class44_0.GetAngularDistance));
						foreach (ActiveUnit current5 in enumerable5)
						{
							if (this.ManoeuverToRefuelFrom(current5))
							{
								flag = true;
								result = true;
								return result;
							}
						}
						IL_471:
						flag = false;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100164", "");
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

		// Token: 0x06002145 RID: 8517 RVA: 0x000DAFD4 File Offset: 0x000D91D4
		public bool ManoeuverToRefuelFrom(ActiveUnit tankerUnit_)
		{
			bool result = false;
			try
			{
				if (this.ParentPlatform.GetUnitStatus() == ActiveUnit._ActiveUnitStatus.Refuelling)
				{
					result = true;
				}
				else if (tankerUnit_.GetDockingOps().GetRefuelingQuantity(this.ParentPlatform) <= 0 && tankerUnit_.GetDockingOps().GetReloadQuantity(this.ParentPlatform) <= 0)
				{
					result = false;
				}
				else
				{
					ActiveUnit_AI aI = this.ParentPlatform.GetAI();
					float? rangeToTargetUnit_ = null;
					float transitAltitude_ = 0f;
					float? speed_ = null;
					float currentHeading = this.ParentPlatform.GetCurrentHeading();
					float? nullable_ = new float?(0.25f);
					bool flag = false;
					if (aI.CanReachTargetUnit(tankerUnit_, rangeToTargetUnit_, transitAltitude_, speed_, currentHeading, ActiveUnit.Throttle.Cruise, nullable_, true, false, ref flag))
					{
						this.ParentPlatform.SetUnitStatus(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
						this.SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.ManoeuveringToRefuel);
						this.SetUNREPDestinationUnit(tankerUnit_);
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100165", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x000DB0FC File Offset: 0x000D92FC
		public void method_53(ActiveUnit activeUnit_3, ActiveUnit activeUnit_4, List<Cargo> list_1)
		{
			if (this.ParentPlatform.m_Scenario.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CargoOps) && list_1.Count != 0)
			{
				foreach (Cargo current in list_1)
				{
					if (activeUnit_3.m_OnboardCargos.Contains(current))
					{
						ScenarioArrayUtil.RemoveCargo(ref activeUnit_3.m_OnboardCargos, current);
						ScenarioArrayUtil.AddCargo(ref activeUnit_4.m_OnboardCargos, current);
					}
					else if (activeUnit_4.m_OnboardCargos.Contains(current))
					{
						ScenarioArrayUtil.RemoveCargo(ref activeUnit_4.m_OnboardCargos, current);
						ScenarioArrayUtil.AddCargo(ref activeUnit_3.m_OnboardCargos, current);
					}
					else if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				if (activeUnit_4 is Ship)
				{
					activeUnit_4.GetDockingOps().SetDockingOpsCondition(ActiveUnit_DockingOps._DockingOpsCondition.Readying);
					activeUnit_4.GetDockingOps().CT = Math.Max(activeUnit_4.GetDockingOps().CT, 1800.0);
				}
				else if (activeUnit_4 is Aircraft)
				{
					((Aircraft)activeUnit_4).GetAircraftAirOps().SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.Readying);
					((Aircraft)activeUnit_4).GetAircraftAirOps().SetConditionTimer(Math.Max(((Aircraft)activeUnit_4).GetAircraftAirOps().GetConditionTimer(), 1800f));
				}
			}
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x000DB25C File Offset: 0x000D945C
		[CompilerGenerated]
		private double method_54(GeoPoint geoPoint_0)
		{
			return Math2.ApproxAngularDistance(geoPoint_0.GetLatitude(), geoPoint_0.GetLongitude(), this.ParentPlatform.GetLatitude(null), this.ParentPlatform.GetLongitude(null));
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x000DB2A4 File Offset: 0x000D94A4
		[CompilerGenerated]
		private float method_55(ReferencePoint referencePoint_0)
		{
			return referencePoint_0.GetDistance(this.GetAssignedHostUnit(false).GetLongitude(null), this.GetAssignedHostUnit(false).GetLatitude(null));
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x000DB2E4 File Offset: 0x000D94E4
		[CompilerGenerated]
		private double method_56(ActiveUnit activeUnit_3)
		{
			return activeUnit_3.GetApproxAngularDistanceInDegrees(this.ParentPlatform);
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x000DB2E4 File Offset: 0x000D94E4
		[CompilerGenerated]
		private double method_57(ActiveUnit activeUnit_3)
		{
			return activeUnit_3.GetApproxAngularDistanceInDegrees(this.ParentPlatform);
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x000DB2E4 File Offset: 0x000D94E4
		[CompilerGenerated]
		private double method_58(ActiveUnit activeUnit_3)
		{
			return activeUnit_3.GetApproxAngularDistanceInDegrees(this.ParentPlatform);
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x000DB2E4 File Offset: 0x000D94E4
		[CompilerGenerated]
		private double method_59(ActiveUnit activeUnit_3)
		{
			return activeUnit_3.GetApproxAngularDistanceInDegrees(this.ParentPlatform);
		}

		// Token: 0x04000FEA RID: 4074
		public static Func<ActiveUnit, bool> ActiveUnitFunc0 = (ActiveUnit activeUnit_0) => activeUnit_0.GetDockingOps().GetDockingOpsCondition() == ActiveUnit_DockingOps._DockingOpsCondition.Docked && activeUnit_0.GetDockingOps().CT == 0.0;

		// Token: 0x04000FEB RID: 4075
		public static Func<Cargo, Mount> CargoFunc1 = (Cargo cargo_0) => (Mount)cargo_0.GetCargo();

		// Token: 0x04000FEC RID: 4076
		public static Func<Cargo, int> CargoFunc2 = (Cargo cargo_0) => ActiveUnit_DockingOps.lazy_0.Value.Next();

		// Token: 0x04000FED RID: 4077
		public static Func<FuelRec, bool> FuelRecFunc3 = (FuelRec fuelRec_0) => fuelRec_0.CurrentQuantity < (float)fuelRec_0.MaxQuantity;

		// Token: 0x04000FEE RID: 4078
		public static Func<FuelRec, bool> FuelRecFunc4 = (FuelRec fuelRec_0) => fuelRec_0.CurrentQuantity < (float)fuelRec_0.MaxQuantity;

		// Token: 0x04000FEF RID: 4079
		public static Func<FuelRec, bool> FuelRecFunc5 = (FuelRec fuelRec_0) => fuelRec_0.CurrentQuantity < (float)fuelRec_0.MaxQuantity;

		// Token: 0x04000FF0 RID: 4080
		public static Func<FuelRec, bool> FuelRecFunc6 = (FuelRec fuelRec_0) => fuelRec_0.CurrentQuantity < (float)fuelRec_0.MaxQuantity;

		// Token: 0x04000FF1 RID: 4081
		public static Func<DockFacility, int> DockFacilityFunc7 = (DockFacility dockFacility_0) => dockFacility_0.GetPhysicalSizeAvaible();

		// Token: 0x04000FF2 RID: 4082
		protected ActiveUnit ParentPlatform;

		// Token: 0x04000FF3 RID: 4083
		private DockFacility HostDockFacility;

		// Token: 0x04000FF4 RID: 4084
		private string HostDockFacilityName;

		// Token: 0x04000FF5 RID: 4085
		private ActiveUnit AssignedHostUnit;

		// Token: 0x04000FF6 RID: 4086
		private string AssignedHostUnitName;

		// Token: 0x04000FF7 RID: 4087
		private string CurrentHostUnitName = "";

		// Token: 0x04000FF8 RID: 4088
		private ActiveUnit UNREPDestinationUnit;

		// Token: 0x04000FF9 RID: 4089
		private string UNREP_D = "";

		// Token: 0x04000FFA RID: 4090
		public string UNREP_Port = "";

		// Token: 0x04000FFB RID: 4091
		public string UNREP_Starboard;

		// Token: 0x04000FFC RID: 4092
		public string UNREP_Astern;

		// Token: 0x04000FFD RID: 4093
		[CompilerGenerated]
		private ObservableCollection<string> UNREPQueue;

		// Token: 0x04000FFE RID: 4094
		private ActiveUnit_DockingOps._DockingOpsCondition DockingOpsCondition;

		// Token: 0x04000FFF RID: 4095
		public double CT;

		// Token: 0x04001000 RID: 4096
		private ActiveUnit_DockingOps._DockingOpsCondition _DockingOpsCondition_1;

		// Token: 0x04001001 RID: 4097
		internal ActiveUnit_DockingOps._DockingOpsCondition CBRB;

		// Token: 0x04001002 RID: 4098
		internal float CBRB_Depth;

		// Token: 0x04001003 RID: 4099
		internal ActiveUnit.Throttle CBRB_ThrottleSetting;

		// Token: 0x04001004 RID: 4100
		[CompilerGenerated]
		private static ActiveUnit_DockingOps.Delegate2 delegate2_0;

		// Token: 0x04001005 RID: 4101
		[CompilerGenerated]
		private static ActiveUnit_DockingOps.Delegate3 delegate3_0;

		// Token: 0x04001006 RID: 4102
		public float UNREPRangeLimit;

		// Token: 0x04001007 RID: 4103
		private List<GeoPoint> list_0;

		// Token: 0x04001008 RID: 4104
		public static object object_0 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04001009 RID: 4105
		public static Lazy<Random> lazy_0 = new Lazy<Random>();

		// Token: 0x020004F5 RID: 1269
		// (Invoke) Token: 0x06002157 RID: 8535
		public delegate void Delegate2(ActiveUnit theBoat);

		// Token: 0x020004F6 RID: 1270
		// (Invoke) Token: 0x0600215B RID: 8539
		public delegate void Delegate3(ActiveUnit theBoat);

		// Token: 0x020004F7 RID: 1271
		public enum _DockingOpsCondition : byte
		{
			// Token: 0x04001013 RID: 4115
			Underway,
			// Token: 0x04001014 RID: 4116
			Docked,
			// Token: 0x04001015 RID: 4117
			DeployingUnderway,
			// Token: 0x04001016 RID: 4118
			Docking,
			// Token: 0x04001017 RID: 4119
			RTB,
			// Token: 0x04001018 RID: 4120
			Readying,
			// Token: 0x04001019 RID: 4121
			ManoeuveringToRefuel,
			// Token: 0x0400101A RID: 4122
			Replenishing,
			// Token: 0x0400101B RID: 4123
			ProvidingUNREP,
			// Token: 0x0400101C RID: 4124
			RechargingBatteries
		}

		// Token: 0x020004F8 RID: 1272
		[CompilerGenerated]
		public sealed class Class39
		{
			// Token: 0x0600215E RID: 8542 RVA: 0x00013DDE File Offset: 0x00011FDE
			public Class39(ActiveUnit_DockingOps.Class39 class39_0)
			{
				if (class39_0 != null)
				{
					this.fuelRecord = class39_0.fuelRecord;
				}
			}

			// Token: 0x0600215F RID: 8543 RVA: 0x00013DF8 File Offset: 0x00011FF8
			internal bool method_0(FuelRec fuelRec_)
			{
				return fuelRec_.FuelType == this.fuelRecord.FuelType & fuelRec_.CurrentQuantity > 0f;
			}

			// Token: 0x0400101D RID: 4125
			public FuelRec fuelRecord;
		}

		// Token: 0x020004F9 RID: 1273
		[CompilerGenerated]
		public sealed class Class40
		{
			// Token: 0x06002160 RID: 8544 RVA: 0x00013E1B File Offset: 0x0001201B
			public Class40(ActiveUnit_DockingOps.Class40 class40_0)
			{
				if (class40_0 != null)
				{
					this.fuelRecord = class40_0.fuelRecord;
				}
			}

			// Token: 0x06002161 RID: 8545 RVA: 0x00013E35 File Offset: 0x00012035
			internal bool method_0(FuelRec fuelRec_)
			{
				return fuelRec_.FuelType == this.fuelRecord.FuelType && fuelRec_.CurrentQuantity > 0f;
			}

			// Token: 0x0400101E RID: 4126
			public FuelRec fuelRecord;
		}

		// Token: 0x020004FA RID: 1274
		[CompilerGenerated]
		public sealed class Class41
		{
			// Token: 0x06002162 RID: 8546 RVA: 0x00013E5A File Offset: 0x0001205A
			public Class41(ActiveUnit_DockingOps.Class41 class41_0)
			{
				if (class41_0 != null)
				{
					this.fuelRecord = class41_0.fuelRecord;
				}
			}

			// Token: 0x06002163 RID: 8547 RVA: 0x00013E74 File Offset: 0x00012074
			internal bool method_0(FuelRec fuelRec_1)
			{
				return fuelRec_1.FuelType == this.fuelRecord.FuelType && fuelRec_1.CurrentQuantity > 0f;
			}

			// Token: 0x0400101F RID: 4127
			public FuelRec fuelRecord;
		}

		// Token: 0x020004FB RID: 1275
		[CompilerGenerated]
		public sealed class Class42
		{
			// Token: 0x06002164 RID: 8548 RVA: 0x00013E99 File Offset: 0x00012099
			public Class42(ActiveUnit_DockingOps.Class42 class42_0)
			{
				if (class42_0 != null)
				{
					this.fuelRecord = class42_0.fuelRecord;
				}
			}

			// Token: 0x06002165 RID: 8549 RVA: 0x00013EB3 File Offset: 0x000120B3
			internal bool method_0(FuelRec fuelRec_1)
			{
				return fuelRec_1.FuelType == this.fuelRecord.FuelType && fuelRec_1.CurrentQuantity > 0f;
			}

			// Token: 0x04001020 RID: 4128
			public FuelRec fuelRecord;
		}

		// Token: 0x020004FC RID: 1276
		[CompilerGenerated]
		public sealed class Class43
		{
			// Token: 0x06002166 RID: 8550 RVA: 0x000DB48C File Offset: 0x000D968C
			internal void method_0(ActiveUnit activeUnit_0)
			{
				if (activeUnit_0 != this.activeUnit_DockingOps_0.ParentPlatform && this.activeUnit_DockingOps_0.ParentPlatform.GetHorizontalRange(activeUnit_0) <= this.float_0 && Operators.CompareString(this.activeUnit_DockingOps_0.method_42(activeUnit_0), "OK", false) == 0)
				{
					this.concurrentBag_0.Add(activeUnit_0);
				}
			}

			// Token: 0x04001021 RID: 4129
			public float float_0;

			// Token: 0x04001022 RID: 4130
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x04001023 RID: 4131
			public ActiveUnit_DockingOps activeUnit_DockingOps_0;
		}

		// Token: 0x020004FD RID: 1277
		[CompilerGenerated]
		public sealed class RangeMeasurer
		{
			// Token: 0x06002168 RID: 8552 RVA: 0x00013ED8 File Offset: 0x000120D8
			public RangeMeasurer(ActiveUnit_DockingOps.RangeMeasurer RangeMeasurer_)
			{
				if (RangeMeasurer_ != null)
				{
					this.distanceLimit = RangeMeasurer_.distanceLimit;
					this.intermediateTargetPoint = RangeMeasurer_.intermediateTargetPoint;
				}
			}

			// Token: 0x06002169 RID: 8553 RVA: 0x00013EFE File Offset: 0x000120FE
			internal bool IsWithinRange(ActiveUnit activeUnit_)
			{
				return this.dockingOps.ParentPlatform.GetHorizontalRange(activeUnit_) <= (float)this.distanceLimit.Value;
			}

			// Token: 0x0600216A RID: 8554 RVA: 0x000DB4F0 File Offset: 0x000D96F0
			internal double GetAngularDistance(ActiveUnit activeUnit_)
			{
				return activeUnit_.GetApproxAngularDistanceInDegrees(this.intermediateTargetPoint);
			}

			// Token: 0x04001024 RID: 4132
			public int? distanceLimit;

			// Token: 0x04001025 RID: 4133
			public GeoPoint intermediateTargetPoint;

			// Token: 0x04001026 RID: 4134
			public ActiveUnit_DockingOps dockingOps;
		}

		// Token: 0x020004FE RID: 1278
		[CompilerGenerated]
		public sealed class Class45
		{
			// Token: 0x0600216B RID: 8555 RVA: 0x00013F22 File Offset: 0x00012122
			public Class45(ActiveUnit_DockingOps.Class45 class45_0)
			{
				if (class45_0 != null)
				{
					this.double_0 = class45_0.double_0;
				}
			}

			// Token: 0x0600216C RID: 8556 RVA: 0x000DB50C File Offset: 0x000D970C
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return this.class46_0.class44_0.dockingOps.ParentPlatform.GetApproxAngularDistanceInDegrees(activeUnit_0) < this.double_0 && activeUnit_0.GetApproxAngularDistanceInDegrees(this.class46_0.activeUnit_0) < this.double_0;
			}

			// Token: 0x04001027 RID: 4135
			public double double_0;

			// Token: 0x04001028 RID: 4136
			public ActiveUnit_DockingOps.Class46 class46_0;
		}

		// Token: 0x020004FF RID: 1279
		[CompilerGenerated]
		public sealed class Class46
		{
			// Token: 0x0600216D RID: 8557 RVA: 0x00013F3C File Offset: 0x0001213C
			public Class46(ActiveUnit_DockingOps.Class46 class46_0)
			{
				if (class46_0 != null)
				{
					this.activeUnit_0 = class46_0.activeUnit_0;
				}
			}

			// Token: 0x04001029 RID: 4137
			public ActiveUnit activeUnit_0;

			// Token: 0x0400102A RID: 4138
			public ActiveUnit_DockingOps.RangeMeasurer class44_0;
		}

		// Token: 0x02000500 RID: 1280
		[CompilerGenerated]
		public sealed class Class47
		{
			// Token: 0x0600216E RID: 8558 RVA: 0x00013F56 File Offset: 0x00012156
			public Class47(ActiveUnit_DockingOps.Class47 class47_0)
			{
				if (class47_0 != null)
				{
					this.double_0 = class47_0.double_0;
				}
			}

			// Token: 0x0600216F RID: 8559 RVA: 0x00013F70 File Offset: 0x00012170
			internal bool method_0(ActiveUnit activeUnit_)
			{
				return this.class44_0.dockingOps.ParentPlatform.GetApproxAngularDistanceInDegrees(activeUnit_) < this.double_0 && activeUnit_.GetApproxAngularDistanceInDegrees(this.class44_0.intermediateTargetPoint) < this.double_0;
			}

			// Token: 0x0400102B RID: 4139
			public double double_0;

			// Token: 0x0400102C RID: 4140
			public ActiveUnit_DockingOps.RangeMeasurer class44_0;
		}
	}
}

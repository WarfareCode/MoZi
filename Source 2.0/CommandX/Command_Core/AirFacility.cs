using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace Command_Core
{
	// Token: 0x02000B00 RID: 2816
	public sealed class AirFacility : PlatformComponent
	{
		// Token: 0x06005AC2 RID: 23234 RVA: 0x002853D4 File Offset: 0x002835D4
		public override void Save(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0, Scenario scenario_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("AirFacility");
				xmlWriter_0.WriteElementString("ID", base.GetGuid());
				xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
				if (this.DBID == 0)
				{
					xmlWriter_0.WriteElementString("Name", this.Name.ToString());
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "Type";
					int airFacilityType = (int)this.AirFacilityType;
					xmlWriter.WriteElementString(localName, airFacilityType.ToString());
					XmlWriter xmlWriter2 = xmlWriter_0;
					string localName2 = "Size";
					airFacilityType = (int)this.aircraftSizeClass;
					xmlWriter2.WriteElementString(localName2, airFacilityType.ToString());
					xmlWriter_0.WriteElementString("Capacity", this.Capacity.ToString());
				}
				if (hashSet_0.Contains(base.GetGuid()))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(base.GetGuid());
					XmlWriter xmlWriter3 = xmlWriter_0;
					string localName3 = "Status";
					byte componentStatus = (byte)this.m_ComponentStatus;
					xmlWriter3.WriteElementString(localName3, componentStatus.ToString());
					if (base.GetDamageSeverity() != PlatformComponent._DamageSeverityFactor.Light)
					{
						xmlWriter_0.WriteElementString("DamageSeverity", ((byte)base.GetDamageSeverity()).ToString());
					}
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100652", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x00285568 File Offset: 0x00283768
		private static AirFacility smethod_2(XmlNode xmlNode_0)
		{
			AirFacility result = null;
			try
			{
				int num = Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "Type").InnerText);
				int int_ = Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "Capacity").InnerText);
				GlobalVariables._RunwayLengthCode enum105_ = (GlobalVariables._RunwayLengthCode)0;
				GlobalVariables.AircraftSizeClass int_2 = GlobalVariables.AircraftSizeClass.None;
				switch (Conversions.ToInteger(Misc.smethod_48(xmlNode_0.ChildNodes, "Size").InnerText))
				{
				case 1:
					enum105_ = GlobalVariables._RunwayLengthCode.TOD_LAD_0m_VTOL;
					int_2 = GlobalVariables.AircraftSizeClass.Small;
					break;
				case 2:
					enum105_ = GlobalVariables._RunwayLengthCode.TOD_LAD_0m_VTOL;
					int_2 = GlobalVariables.AircraftSizeClass.Medium;
					break;
				case 3:
					enum105_ = GlobalVariables._RunwayLengthCode.TOD_LAD_0m_VTOL;
					int_2 = GlobalVariables.AircraftSizeClass.Large;
					break;
				case 4:
					enum105_ = GlobalVariables._RunwayLengthCode.TOD_LAD_0m_VTOL;
					int_2 = GlobalVariables.AircraftSizeClass.VLarge;
					break;
				case 5:
					enum105_ = GlobalVariables._RunwayLengthCode.TOD_LAD_1_450m;
					int_2 = GlobalVariables.AircraftSizeClass.Small;
					break;
				case 6:
					enum105_ = GlobalVariables._RunwayLengthCode.TOD_LAD_451_900m;
					int_2 = GlobalVariables.AircraftSizeClass.Small;
					break;
				case 7:
					enum105_ = GlobalVariables._RunwayLengthCode.TOD_LAD_901_1400m;
					int_2 = GlobalVariables.AircraftSizeClass.Medium;
					break;
				case 8:
					enum105_ = GlobalVariables._RunwayLengthCode.TOD_LAD_2001_2600m;
					int_2 = GlobalVariables.AircraftSizeClass.Large;
					break;
				case 9:
					enum105_ = GlobalVariables._RunwayLengthCode.TOD_LAD_2601_3200m;
					int_2 = GlobalVariables.AircraftSizeClass.VLarge;
					break;
				}
				result = new AirFacility(null, Misc.smethod_48(xmlNode_0.ChildNodes, "Name").InnerText, (AirFacility._AirFacilityType)num, (int)int_2, int_, enum105_);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200033", ex2.Message);
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

		// Token: 0x06005AC4 RID: 23236 RVA: 0x002856E8 File Offset: 0x002838E8
		public static AirFacility Load(ref XmlNode xmlNode_0, ref Dictionary<string, Subject> dictionary_0, ref Scenario scenario_0)
		{
			AirFacility airFacility = null;
			AirFacility result;
			try
			{
				XmlNode xmlNode = Misc.smethod_48(xmlNode_0.ChildNodes, "DBID");
				string innerText = Misc.smethod_48(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					airFacility = (AirFacility)dictionary_0[innerText];
				}
				else
				{
					AirFacility airFacility2;
					if (Information.IsNothing(xmlNode))
					{
						airFacility2 = AirFacility.smethod_2(xmlNode_0);
					}
					else if (Operators.CompareString(xmlNode.InnerText, "0", false) == 0)
					{
						airFacility2 = AirFacility.smethod_2(xmlNode_0);
						if (Information.IsNothing(airFacility2))
						{
							airFacility = null;
							result = airFacility;
							return result;
						}
					}
					else
					{
						int facilityDBID = Conversions.ToInteger(xmlNode.InnerText);
						SQLiteConnection sQLiteConnection = scenario_0.GetSQLiteConnection();
						airFacility2 = DBFunctions.LoadAircraftFacilityDataTable(facilityDBID, ref sQLiteConnection, null);
					}
					if (dictionary_0.ContainsKey(innerText))
					{
						airFacility = (AirFacility)dictionary_0[innerText];
					}
					else
					{
						airFacility2.SetGuid(innerText);
						dictionary_0.Add(airFacility2.GetGuid(), airFacility2);
						IEnumerator enumerator = xmlNode_0.ChildNodes.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								XmlNode xmlNode2 = (XmlNode)enumerator.Current;
								string name = xmlNode2.Name;
								if (Operators.CompareString(name, "Status", false) != 0)
								{
									if (Operators.CompareString(name, "DamageSeverity", false) == 0)
									{
										airFacility2.SetDamageSeverity((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode2.InnerText));
									}
								}
								else
								{
									string innerText2 = xmlNode2.InnerText;
									if (Operators.CompareString(innerText2, "Operational", false) != 0)
									{
										if (Operators.CompareString(innerText2, "Damaged", false) != 0)
										{
											if (Operators.CompareString(innerText2, "Destroyed", false) != 0)
											{
												airFacility2.m_ComponentStatus = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode2.InnerText);
											}
											else
											{
												airFacility2.m_ComponentStatus = PlatformComponent._ComponentStatus.Destroyed;
											}
										}
										else
										{
											airFacility2.m_ComponentStatus = PlatformComponent._ComponentStatus.Damaged;
										}
									}
									else
									{
										airFacility2.m_ComponentStatus = PlatformComponent._ComponentStatus.Operational;
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
						airFacility = airFacility2;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100653", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			result = airFacility;
			return result;
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x00028C25 File Offset: 0x00026E25
		public AirFacility(ActiveUnit activeUnit_1, string string_2, AirFacility._AirFacilityType enum73_1, int int_1, int int_2, GlobalVariables._RunwayLengthCode enum105_1) : base(activeUnit_1)
		{
			this.Name = string_2;
			this.AirFacilityType = enum73_1;
			this.aircraftSizeClass = (GlobalVariables.AircraftSizeClass)int_1;
			this.RunwayLengthCode = enum105_1;
			this.HostedAircrafts = new Lazy<ConcurrentDictionary<string, Aircraft>>();
			this.Capacity = int_2;
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x00285960 File Offset: 0x00283B60
		public ConcurrentDictionary<string, Aircraft> GetHostedAircrafts()
		{
			return this.HostedAircrafts.Value;
		}

		// Token: 0x06005AC7 RID: 23239 RVA: 0x0028597C File Offset: 0x00283B7C
		public string method_27()
		{
			return this.method_32(this.Name);
		}

		// Token: 0x06005AC8 RID: 23240 RVA: 0x00285998 File Offset: 0x00283B98
		public override PlatformComponent._ComponentStatus GetComponentStatus()
		{
			return base.GetComponentStatus();
		}

		// Token: 0x06005AC9 RID: 23241 RVA: 0x002859B0 File Offset: 0x00283BB0
		public override void BeDestroyed(Side side_0, bool bool_8, bool bool_9)
		{
			try
			{
				if (!this.GetHostedAircrafts().IsEmpty)
				{
					foreach (Aircraft current in this.GetHostedAircrafts().Values)
					{
						base.GetParentPlatform().m_Scenario.RemoveUnit(current);
					}
				}
				base.BeDestroyed(side_0, bool_8, bool_9);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100654", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005ACA RID: 23242 RVA: 0x00285A70 File Offset: 0x00283C70
		public  void vmethod_9(PlatformComponent._DamageSeverityFactor _DamageSeverityFactor_1)
		{
			try
			{
				this.method_28(_DamageSeverityFactor_1);
				base.StopIlluminateAndTurnOff(_DamageSeverityFactor_1);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100655", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005ACB RID: 23243 RVA: 0x00285ADC File Offset: 0x00283CDC
		public void method_28(PlatformComponent._DamageSeverityFactor _DamageSeverityFactor_1)
		{
			if (!this.GetHostedAircrafts().IsEmpty)
			{
				int num = 0;
				switch (_DamageSeverityFactor_1)
				{
				case PlatformComponent._DamageSeverityFactor.Light:
					num = (int)Math.Round((double)this.GetHostedAircrafts().Count / 3.0);
					break;
				case PlatformComponent._DamageSeverityFactor.Medium:
					num = (int)Math.Round((double)this.GetHostedAircrafts().Count / 2.0);
					break;
				case PlatformComponent._DamageSeverityFactor.Heavy:
					num = (int)Math.Round((double)(2 * this.GetHostedAircrafts().Count) / 3.0);
					break;
				}
				int num2 = 0;
				foreach (Aircraft current in this.GetHostedAircrafts().Values)
				{
					string text = "";
					if (Operators.CompareString(current.Name, current.UnitClass, false) != 0)
					{
						text = " (" + current.UnitClass + ")";
					}
					if (!Information.IsNothing(base.GetParentPlatform()))
					{
						base.GetParentPlatform().LogMessage(string.Concat(new string[]
						{
							current.Name,
							text,
							" was hosted in ",
							this.Name,
							" 已经被摧毁!"
						}), LoggedMessage.MessageType.UnitLost, 2, false, new GeoPoint(base.GetParentPlatform().GetLongitude(null), base.GetParentPlatform().GetLatitude(null)));
						base.GetParentPlatform().m_Scenario.RemoveUnit(current);
					}
					num2++;
					if (num2 == num)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06005ACC RID: 23244 RVA: 0x00285C9C File Offset: 0x00283E9C
		public GlobalVariables.AircraftSizeClass GetAircraftSizeAfterDamage()
		{
			GlobalVariables.AircraftSizeClass result;
			if (Information.IsNothing(base.GetParentPlatform()))
			{
				result = GlobalVariables.AircraftSizeClass.None;
			}
			else
			{
				double num = (double)(100f - base.GetParentPlatform().GetDamage().GetDamagePts());
				if (num > 75.0)
				{
					result = this.aircraftSizeClass;
				}
				else if (num > 50.0)
				{
					result = (GlobalVariables.AircraftSizeClass)Math.Max((int)(this.aircraftSizeClass - GlobalVariables.AircraftSizeClass.Small), 0);
				}
				else if (num > 25.0)
				{
					result = (GlobalVariables.AircraftSizeClass)Math.Max((int)(this.aircraftSizeClass - GlobalVariables.AircraftSizeClass.Medium), 0);
				}
				else if (num > 10.0)
				{
					result = (GlobalVariables.AircraftSizeClass)Math.Max((int)(this.aircraftSizeClass - GlobalVariables.AircraftSizeClass.Large), 0);
				}
				else
				{
					result = GlobalVariables.AircraftSizeClass.None;
				}
			}
			return result;
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x00285D64 File Offset: 0x00283F64
		public AirFacility._AirFacilityType GetAirFacilityType()
		{
			return this.AirFacilityType;
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x00285D7C File Offset: 0x00283F7C
		public GlobalVariables.AircraftSizeClass GetAircraftSizeClass()
		{
			return this.aircraftSizeClass;
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x00285D94 File Offset: 0x00283F94
		private string method_32(string string_2)
		{
			int num = Strings.InStr(string_2, "(", CompareMethod.Binary);
			string result;
			if (num == 0)
			{
				result = string_2;
			}
			else
			{
				result = Strings.Trim(Strings.Left(string_2, num - 1));
			}
			return result;
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x00285DD4 File Offset: 0x00283FD4
		public bool IsTakeOffOrLandingFacility()
		{
			AirFacility._AirFacilityType airFacilityType = this.GetAirFacilityType();
			return airFacilityType - AirFacility._AirFacilityType.Runway <= 2 || airFacilityType - AirFacility._AirFacilityType.AircraftCarrierCatapult <= 2 || airFacilityType - AirFacility._AirFacilityType.Pad <= 1;
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x00028C60 File Offset: 0x00026E60
		public bool IsAircraftCarrierCatapult()
		{
			return this.GetAirFacilityType() == AirFacility._AirFacilityType.AircraftCarrierCatapult;
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x00285E10 File Offset: 0x00284010
		public bool method_35()
		{
			AirFacility._AirFacilityType airFacilityType = this.GetAirFacilityType();
			bool flag = false;
			bool result;
			if (airFacilityType <= AirFacility._AirFacilityType.AircraftCarrierSkiJump)
			{
				if (airFacilityType - AirFacility._AirFacilityType.Runway <= 3 || airFacilityType == AirFacility._AirFacilityType.AircraftCarrierSkiJump)
				{
					result = true;
					return result;
				}
			}
			else
			{
				if (airFacilityType - AirFacility._AirFacilityType.Pad <= 1)
				{
					result = true;
					return result;
				}
				if (airFacilityType == AirFacility._AirFacilityType.OpenParking)
				{
					result = true;
					return result;
				}
			}
			result = flag;
			return result;
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x00285E7C File Offset: 0x0028407C
		public bool IsHangarOrOpenParking()
		{
			AirFacility._AirFacilityType airFacilityType = this.GetAirFacilityType();
			return airFacilityType == AirFacility._AirFacilityType.Hangar || airFacilityType == AirFacility._AirFacilityType.OpenParking;
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x00285EA4 File Offset: 0x002840A4
		public bool IsRunwayAccessPointOrElevator()
		{
			AirFacility._AirFacilityType airFacilityType = this.GetAirFacilityType();
			return airFacilityType == AirFacility._AirFacilityType.RunwayAccessPoint || airFacilityType == AirFacility._AirFacilityType.Elevator;
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x00285ECC File Offset: 0x002840CC
		public int method_38()
		{
			int result = 0;
			switch (this.aircraftSizeClass)
			{
			case GlobalVariables.AircraftSizeClass.Small:
				result = this.Capacity;
				break;
			case GlobalVariables.AircraftSizeClass.Medium:
				result = 2 * this.Capacity;
				break;
			case GlobalVariables.AircraftSizeClass.Large:
				result = 3 * this.Capacity;
				break;
			case GlobalVariables.AircraftSizeClass.VLarge:
				result = 4 * this.Capacity;
				break;
			}
			return result;
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x00285F28 File Offset: 0x00284128
		public int method_39()
		{
			int result = 0;
			try
			{
				int num = this.method_38();
				foreach (Aircraft current in this.GetHostedAircrafts().Values)
				{
					num -= (int)current.aircraftSizeClass;
				}
				result = num;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100656", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06005AD7 RID: 23255 RVA: 0x00285FE0 File Offset: 0x002841E0
		public bool method_40(Aircraft aircraft_)
		{
			bool result = false;
			try
			{
				if (Information.IsNothing(base.GetParentPlatform()))
				{
					result = false;
				}
				else
				{
					GlobalVariables.ActiveUnitType unitType = base.GetParentPlatform().GetUnitType();
					if (unitType - GlobalVariables.ActiveUnitType.Ship <= 1 && aircraft_.aircraftSizeClass > this.aircraftSizeClass)
					{
						result = false;
					}
					else
					{
						int num = this.method_39();
						if (this.GetHostedAircrafts().ContainsKey(aircraft_.GetGuid()))
						{
							num = (int)((byte)((byte)num + aircraft_.aircraftSizeClass));
						}
						result = (num >= (int)aircraft_.aircraftSizeClass);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 100657", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04002D6B RID: 11627
		private AirFacility._AirFacilityType AirFacilityType;

		// Token: 0x04002D6C RID: 11628
		private GlobalVariables.AircraftSizeClass aircraftSizeClass;

		// Token: 0x04002D6D RID: 11629
		public int Capacity;

		// Token: 0x04002D6E RID: 11630
		private Lazy<ConcurrentDictionary<string, Aircraft>> HostedAircrafts;

		// Token: 0x04002D6F RID: 11631
		public GlobalVariables._RunwayLengthCode RunwayLengthCode;

		// Token: 0x02000B01 RID: 2817
		public enum _AirFacilityType : short
		{
			// Token: 0x04002D71 RID: 11633
			Unknown = 1001,
			// Token: 0x04002D72 RID: 11634
			Runway = 2001,
			// Token: 0x04002D73 RID: 11635
			RunwayWithArrest,
			// Token: 0x04002D74 RID: 11636
			RunwayGradeTaxiway,
			// Token: 0x04002D75 RID: 11637
			RunwayAccessPoint,
			// Token: 0x04002D76 RID: 11638
			AircraftCarrierCatapult,
			// Token: 0x04002D77 RID: 11639
			AircraftCarrierSkiJump,
			// Token: 0x04002D78 RID: 11640
			AircraftCarrierArrestingGear,
			// Token: 0x04002D79 RID: 11641
			Pad = 3001,
			// Token: 0x04002D7A RID: 11642
			PadWithHaulDown,
			// Token: 0x04002D7B RID: 11643
			Hangar = 4001,
			// Token: 0x04002D7C RID: 11644
			OpenParking,
			// Token: 0x04002D7D RID: 11645
			Elevator
		}
	}
}

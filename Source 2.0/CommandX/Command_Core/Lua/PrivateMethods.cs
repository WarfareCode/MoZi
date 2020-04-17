using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;

namespace Command_Core.Lua
{
	// Token: 0x02000C21 RID: 3105
	public sealed class PrivateMethods
	{
		// Token: 0x060067A1 RID: 26529 RVA: 0x00362AB0 File Offset: 0x00360CB0
		[CompilerGenerated]
		public static void smethod_0(PrivateMethods.Delegate27 delegate27_1)
		{
			PrivateMethods.Delegate27 @delegate = PrivateMethods.delegate27_0;
			PrivateMethods.Delegate27 delegate2;
			do
			{
				delegate2 = @delegate;
				PrivateMethods.Delegate27 value = (PrivateMethods.Delegate27)Delegate.Combine(delegate2, delegate27_1);
				@delegate = Interlocked.CompareExchange<PrivateMethods.Delegate27>(ref PrivateMethods.delegate27_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060067A2 RID: 26530 RVA: 0x00362AE8 File Offset: 0x00360CE8
		[CompilerGenerated]
		public static void smethod_1(PrivateMethods.Delegate28 delegate28_1)
		{
			PrivateMethods.Delegate28 @delegate = PrivateMethods.delegate28_0;
			PrivateMethods.Delegate28 delegate2;
			do
			{
				delegate2 = @delegate;
				PrivateMethods.Delegate28 value = (PrivateMethods.Delegate28)Delegate.Combine(delegate2, delegate28_1);
				@delegate = Interlocked.CompareExchange<PrivateMethods.Delegate28>(ref PrivateMethods.delegate28_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060067A3 RID: 26531 RVA: 0x00362B20 File Offset: 0x00360D20
		public static string smethod_2(string string_0, string string_1, int int_0, int int_1, string string_2, string string_3, string string_4, Scenario scenario_0)
		{
			PrivateMethods.Class300 @class = new PrivateMethods.Class300();
			@class.string_0 = string_0;
			Side theSide = scenario_0.GetSides().Where(new Func<Side, bool>(@class.method_0)).Select(PrivateMethods.SideFunc).First<Side>();
			double longitude = 0.0;
			double latitude = 0.0;
			if (Operators.CompareString(string_2, "DEC", false) != 0)
			{
				if (Operators.CompareString(string_2, "DEG", false) == 0)
				{
					longitude = LuaUtility.smethod_8(string_4);
					latitude = LuaUtility.smethod_7(string_3);
				}
			}
			else
			{
				string_4 = string_4.Replace(",", ".");
				string_3 = string_3.Replace(",", ".");
				longitude = XmlConvert.ToDouble(string_4);
				latitude = XmlConvert.ToDouble(string_3);
			}
			return scenario_0.AddAircraft(theSide, string_1, longitude, latitude, int_0, int_1, 1000f, null).GetGuid();
		}

		// Token: 0x060067A4 RID: 26532 RVA: 0x00362C04 File Offset: 0x00360E04
		public static string smethod_3(string string_0, string string_1, int int_0, string string_2, string string_3, string string_4, Scenario scenario_0)
		{
			PrivateMethods.Class301 @class = new PrivateMethods.Class301();
			@class.string_0 = string_0;
			Side theSide = scenario_0.GetSides().Where(new Func<Side, bool>(@class.method_0)).Select(PrivateMethods.SideFunc).First<Side>();
			double longitude = 0.0;
			double latitude = 0.0;
			if (Operators.CompareString(string_2, "DEC", false) != 0)
			{
				if (Operators.CompareString(string_2, "DEG", false) == 0)
				{
					longitude = LuaUtility.smethod_8(string_4);
					latitude = LuaUtility.smethod_7(string_3);
				}
			}
			else
			{
				string_4 = string_4.Replace(",", ".");
				string_3 = string_3.Replace(",", ".");
				longitude = XmlConvert.ToDouble(string_4);
				latitude = XmlConvert.ToDouble(string_3);
			}
			return scenario_0.AddShip(theSide, int_0, string_1, longitude, latitude, false, null).GetGuid();
		}

		// Token: 0x060067A5 RID: 26533 RVA: 0x00362CE0 File Offset: 0x00360EE0
		public static string smethod_4(string string_0, string string_1, int int_0, string string_2, string string_3, string string_4, Scenario scenario_0)
		{
			PrivateMethods.Class302 @class = new PrivateMethods.Class302();
			@class.string_0 = string_0;
			Side theSide = scenario_0.GetSides().Where(new Func<Side, bool>(@class.method_0)).Select(PrivateMethods.SideFunc).First<Side>();
			double longitude = 0.0;
			double latitude = 0.0;
			if (Operators.CompareString(string_2, "DEC", false) != 0)
			{
				if (Operators.CompareString(string_2, "DEG", false) == 0)
				{
					longitude = LuaUtility.smethod_8(string_4);
					latitude = LuaUtility.smethod_7(string_3);
				}
			}
			else
			{
				string_4 = string_4.Replace(",", ".");
				string_3 = string_3.Replace(",", ".");
				longitude = XmlConvert.ToDouble(string_4);
				latitude = XmlConvert.ToDouble(string_3);
			}
			return scenario_0.AddSubmarine(theSide, int_0, string_1, longitude, latitude, false, null).GetGuid();
		}

		// Token: 0x060067A6 RID: 26534 RVA: 0x00362DBC File Offset: 0x00360FBC
		public static bool smethod_5(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			if (!objectGeoLocation.ContainsKey("WARHEADID"))
			{
				throw new Exception2("Missing mandatory variable 'WarheadID'");
			}
			int int_ = Conversions.ToInteger(objectGeoLocation["WARHEADID"]);
			double? num = LuaUtility.smethod_10(objectGeoLocation);
			if (!num.HasValue)
			{
				throw new Exception2("Missing 'Latitude'");
			}
			double? num2 = LuaUtility.smethod_12(objectGeoLocation);
			if (!num2.HasValue)
			{
				throw new Exception2("Missing 'Longitude'");
			}
			int num3;
			if (objectGeoLocation.ContainsKey("ALTITUDE") && Operators.CompareString(objectGeoLocation["ALTITUDE"].ToString(), "SURFACE", false) != 0)
			{
				num3 = Conversions.ToInteger(objectGeoLocation["ALTITUDE"]);
			}
			else
			{
				short elevation = Terrain.GetElevation(num.Value, num2.Value, false);
				if (elevation < 0)
				{
					num3 = 0;
				}
				else
				{
					num3 = (int)elevation;
				}
			}
			Warhead warhead = DBFunctions.LoadWarheadData(scenario_0, int_);
			new Explosion(ref scenario_0, num2.Value, num.Value, num2.Value, num.Value, 0f, (float)num3, warhead.DP, warhead.DP, warhead.warheadType, warhead.ExplosivesType, null, null, null, null, null, warhead.ClusterBombDispersionAreaLength, warhead.ClusterBombDispersionAreaWidth, (int)warhead.NumberOfWarheads, 0f, 0);
			return true;
		}

		// Token: 0x060067A7 RID: 26535 RVA: 0x00362F20 File Offset: 0x00361120
		public static string smethod_6(string string_0, string string_1, int int_0, int int_1, string string_2, string string_3, string string_4, Scenario scenario_0)
		{
			PrivateMethods.Class303 @class = new PrivateMethods.Class303();
			@class.string_0 = string_0;
			Side theSide = scenario_0.GetSides().Where(new Func<Side, bool>(@class.method_0)).Select(PrivateMethods.SideFunc).First<Side>();
			double longitude = 0.0;
			double latitude = 0.0;
			if (Operators.CompareString(string_2, "DEC", false) != 0)
			{
				if (Operators.CompareString(string_2, "DEG", false) == 0)
				{
					longitude = LuaUtility.smethod_8(string_4);
					latitude = LuaUtility.smethod_7(string_3);
				}
			}
			else
			{
				string_4 = string_4.Replace(",", ".");
				string_3 = string_3.Replace(",", ".");
				longitude = XmlConvert.ToDouble(string_4);
				latitude = XmlConvert.ToDouble(string_3);
			}
			Facility facility = scenario_0.AddFacility(theSide, int_0, string_1, longitude, latitude, false, null);
			facility.SetCurrentHeading((float)int_1);
			return facility.GetGuid();
		}

		// Token: 0x060067A8 RID: 26536 RVA: 0x0036300C File Offset: 0x0036120C
		public static bool smethod_7(LuaTable luaTable_0, Scenario scenario_0, ActiveUnit activeUnit_0)
		{
			bool result = false;
			try
			{
				Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
				ActiveUnit activeUnit = null;
				ActiveUnit activeUnit2 = null;
				if (!objectGeoLocation.ContainsKey("HostedUnitNameOrID".ToUpper()))
				{
					throw new Exception2("HostedUnitNameOrID has not been defined!");
				}
				string text = Conversions.ToString(objectGeoLocation["HostedUnitNameOrID".ToUpper()]);
				if (Operators.CompareString(text, "UnitX", false) == 0)
				{
					if (Information.IsNothing(activeUnit_0))
					{
						throw new Exception2("UnitX has not been defined!");
					}
					activeUnit = activeUnit_0;
				}
				else
				{
					foreach (ActiveUnit current in scenario_0.GetActiveUnitList())
					{
						if (Operators.CompareString(current.Name.ToUpper(), text.ToUpper(), false) == 0 || Operators.CompareString(current.GetGuid(), text.ToLower(), false) == 0)
						{
							activeUnit = current;
							break;
						}
					}
				}
				if (!objectGeoLocation.ContainsKey("SelectedHostNameOrID".ToUpper()))
				{
					throw new Exception2("SelectedHostNameOrID has not been defined!");
				}
				string text2 = Conversions.ToString(objectGeoLocation["SelectedHostNameOrID".ToUpper()]);
				if (Operators.CompareString(text2, "UnitX", false) == 0)
				{
					if (Information.IsNothing(activeUnit_0))
					{
						throw new Exception2("UnitX has not been defined!");
					}
					activeUnit2 = activeUnit_0;
				}
				else
				{
					foreach (ActiveUnit current2 in scenario_0.GetActiveUnitList())
					{
						if (Operators.CompareString(current2.Name.ToUpper(), text2.ToUpper(), false) == 0 || Operators.CompareString(current2.GetGuid(), text2.ToLower(), false) == 0)
						{
							activeUnit2 = current2;
							break;
						}
					}
				}
				if (Information.IsNothing(activeUnit))
				{
					throw new Exception2("Couldn't find the hosted unit " + text);
				}
				if (Information.IsNothing(activeUnit2))
				{
					throw new Exception2("Couldn't find the selected host unit " + text2);
				}
				if (activeUnit.IsAircraft)
				{
					if (activeUnit2.GetAirOps().CanBeHostedOnAirFacility((Aircraft)activeUnit))
					{
						((Aircraft)activeUnit).GetAircraftAirOps().SetHostAirFacility(null);
						activeUnit2.GetAirOps().method_18((Aircraft)activeUnit, false);
						activeUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
						result = true;
					}
					else
					{
						result = false;
					}
				}
				else if (activeUnit2.GetDockingOps().method_37(activeUnit))
				{
					activeUnit.GetDockingOps().SetDockFacility(null);
					activeUnit2.GetDockingOps().method_39(activeUnit);
					activeUnit.SetUnitStatus(ActiveUnit._ActiveUnitStatus.Unassigned);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060067A9 RID: 26537 RVA: 0x00363300 File Offset: 0x00361500
		public static bool smethod_8(string string_0, string string_1, Scenario scenario_0, ActiveUnit activeUnit_0, bool bool_0, bool bool_1)
		{
			bool result = false;
			try
			{
				ActiveUnit activeUnit = null;
				Mission mission = null;
				Side side = null;
				bool flag = bool_0;
				if (Operators.CompareString(string_0, "UnitX", false) == 0)
				{
					if (Information.IsNothing(activeUnit_0))
					{
						throw new Exception2("UnitX has not been defined!");
					}
					activeUnit = activeUnit_0;
					side = activeUnit_0.GetSide(false);
				}
				else
				{
					foreach (ActiveUnit current in scenario_0.GetActiveUnitList())
					{
						if (Operators.CompareString(current.Name.ToUpper(), string_0.ToUpper(), false) == 0 || Operators.CompareString(current.GetGuid(), string_0.ToLower(), false) == 0)
						{
							activeUnit = current;
							side = activeUnit.GetSide(false);
							break;
						}
					}
				}
				foreach (Mission current2 in side.GetMissionCollection())
				{
					if (Operators.CompareString(current2.Name.ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(current2.GetGuid(), string_1.ToLower(), false) == 0)
					{
						mission = current2;
						break;
					}
				}
				if (Information.IsNothing(activeUnit))
				{
					throw new Exception2("Couldn't find the unit " + string_0);
				}
				if (string_1 == null | Operators.CompareString(string_1.ToUpper(), "NONE", false) == 0)
				{
					activeUnit.DeleteMission(false, null);
					result = true;
				}
				else
				{
					if (Information.IsNothing(mission))
					{
						throw new Exception2("Couldn't find the mission " + string_1);
					}
					if (flag & activeUnit.IsGroup)
					{
						activeUnit.AssignToMission(ref activeUnit.m_Scenario, ref activeUnit, ref mission, ref flag);
						using (IEnumerator<ActiveUnit> enumerator3 = ((Group)activeUnit).GetUnitsInGroup().Values.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								ActiveUnit current3 = enumerator3.Current;
								activeUnit.AssignToMission(ref activeUnit.m_Scenario, ref current3, ref mission, ref flag);
							}
							goto IL_20E;
						}
					}
					activeUnit.AssignToMission(ref activeUnit.m_Scenario, ref activeUnit, ref mission, ref flag);
					IL_20E:
					if (!flag & bool_1)
					{
						Collection<ActiveUnit> collection = new Collection<ActiveUnit>();
						collection.Add(activeUnit);
						StrikePlanner.smethod_0(activeUnit.m_Scenario, mission, ref collection, false);
					}
					mission.int_0 = 1;
					result = true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060067AA RID: 26538 RVA: 0x003635D0 File Offset: 0x003617D0
		public static bool smethod_9(LuaTable luaTable_0, Scenario scenario_0, ActiveUnit activeUnit_0)
		{
			bool result = false;
			try
			{
				Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
				Aircraft aircraft = null;
				LuaUtility.smethod_4(ref objectGeoLocation);
				if (!objectGeoLocation.ContainsKey("UnitName".ToUpper()))
				{
					throw new Exception2("UnitName has not been defined!");
				}
				string text = Conversions.ToString(objectGeoLocation["UnitName".ToUpper()]);
				if (Operators.CompareString(text, "UnitX", false) == 0)
				{
					if (Information.IsNothing(activeUnit_0))
					{
						throw new Exception2("UnitX has not been defined!");
					}
					if (!activeUnit_0.IsAircraft)
					{
						throw new Exception2("UnitX is not an aircraft!");
					}
					aircraft = (Aircraft)activeUnit_0;
				}
				else
				{
					foreach (ActiveUnit current in scenario_0.GetActiveUnitList())
					{
						if (current.GetType() == typeof(Aircraft) && (Operators.CompareString(current.Name.ToUpper(), text.ToUpper(), false) == 0 || Operators.CompareString(current.GetGuid(), text.ToLower(), false) == 0))
						{
							aircraft = (Aircraft)current;
							break;
						}
					}
				}
				if (Information.IsNothing(aircraft))
				{
					throw new Exception2("Aircraft has not been found!");
				}
				if (!(aircraft.IsParked() | aircraft.GetAircraftAirOps().GetAirOpsCondition() == Aircraft_AirOps._AirOpsCondition.Readying))
				{
					throw new Exception2("Aircraft is not parked, cannot change loadout!");
				}
				if (!objectGeoLocation.ContainsKey("LOADOUTID"))
				{
					throw new Exception2("LoadoutID has not been defined!");
				}
				int num = Conversions.ToInteger(objectGeoLocation["LOADOUTID"]);
				if (num == 0)
				{
					num = aircraft.GetLoadout().DBID;
				}
				try
				{
					DBFunctions.smethod_47(ref scenario_0, num, true);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					throw new Exception2(ex2.Message);
				}
				if (!objectGeoLocation.ContainsKey("TIMETOREADY_MINUTES"))
				{
					throw new Exception2("TimeToReady_Minutes has not been defined!");
				}
				int num2 = Conversions.ToInteger(objectGeoLocation["TIMETOREADY_MINUTES"]);
				if (!objectGeoLocation.ContainsKey("IGNOREMAGAZINES"))
				{
					throw new Exception2("IgnoreMagazines has not been defined!");
				}
				bool flag = false;
				try
				{
					flag = Conversions.ToBoolean(objectGeoLocation["IGNOREMAGAZINES"]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("Unable to parse IgnoreMagazines to true/false!");
				}
				bool bool_ = false;
				if (objectGeoLocation.ContainsKey("EXCLUDEOPTIONALWEAPONS"))
				{
					try
					{
						bool_ = Conversions.ToBoolean(objectGeoLocation["EXCLUDEOPTIONALWEAPONS"]);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				if (scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags))
				{
					flag = true;
				}
				if (!flag)
				{
					aircraft.GetAircraftAirOps().method_65();
				}
				ActiveUnit currentHostUnit = aircraft.GetAircraftAirOps().GetCurrentHostUnit();
				currentHostUnit.GetAirOps().RearmAircraft(ref aircraft, num, 0, false, bool_, !flag, false, true);
				aircraft.GetAircraftAirOps().SetConditionTimer((float)(num2 * 60));
				currentHostUnit.GetAirOps().RefuelAircraft(ref aircraft);
				currentHostUnit.GetAirOps().RepairAircraft(ref aircraft);
				result = true;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060067AB RID: 26539 RVA: 0x00363958 File Offset: 0x00361B58
		public static bool smethod_10(int int_0, int int_1, float float_0, int int_2, Scenario scenario_0)
		{
			bool result = false;
			try
			{
				scenario_0.GetWeatherProfile().SetTemp((double)int_0);
				scenario_0.GetWeatherProfile().RainFallRate = (float)int_1;
				scenario_0.GetWeatherProfile().SetFUR(float_0);
				scenario_0.GetWeatherProfile().SeaState = int_2;
				result = true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060067AC RID: 26540 RVA: 0x003639CC File Offset: 0x00361BCC
		public static LuaTable smethod_11(Scenario scenario_0)
		{
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			LuaTable result;
			try
			{
				luaTable["temp"] = scenario_0.GetWeatherProfile().GetTemp();
				luaTable["rainfall"] = scenario_0.GetWeatherProfile().RainFallRate;
				luaTable["undercloud"] = scenario_0.GetWeatherProfile().GetFUR();
				luaTable["seastate"] = scenario_0.GetWeatherProfile().SeaState;
				result = luaTable;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060067AD RID: 26541 RVA: 0x00363A80 File Offset: 0x00361C80
		public static bool smethod_12(string string_0, string string_1, string string_2, Scenario scenario_0)
		{
			bool result = false;
			checked
			{
				try
				{
					Side side = null;
					Side side2 = null;
					Side[] sides = scenario_0.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side3 = sides[i];
						if (Operators.CompareString(side3.GetSideName().ToUpper(), string_0.ToUpper(), false) == 0 || Operators.CompareString(side3.GetGuid(), string_0.ToLower(), false) == 0)
						{
							side = side3;
						}
						if (Operators.CompareString(side3.GetSideName().ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(side3.GetGuid(), string_1.ToLower(), false) == 0)
						{
							side2 = side3;
						}
					}
					if (Information.IsNothing(side))
					{
						throw new Exception2("Unable to identify Side-A!");
					}
					if (Information.IsNothing(side2))
					{
						throw new Exception2("Unable to identify Side-B!");
					}
					Misc.PostureStance postureStance_;
					if (Operators.CompareString(string_2, "F", false) != 0)
					{
						if (Operators.CompareString(string_2, "H", false) != 0)
						{
							if (Operators.CompareString(string_2, "N", false) != 0)
							{
								if (Operators.CompareString(string_2, "U", false) != 0)
								{
									throw new Exception2("Invalid posture code! (Valid codes: F, H, N, U)");
								}
								postureStance_ = Misc.PostureStance.Unfriendly;
							}
							else
							{
								postureStance_ = Misc.PostureStance.Neutral;
							}
						}
						else
						{
							postureStance_ = Misc.PostureStance.Hostile;
						}
					}
					else
					{
						postureStance_ = Misc.PostureStance.Friendly;
					}
					side.SetPostureStance(side2, postureStance_);
					result = true;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
				return result;
			}
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x00363C04 File Offset: 0x00361E04
		public static LuaTable smethod_13(LuaTable luaTable_0, Scenario scenario_0)
		{
			LuaTable result;
			try
			{
				Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
				Side side = null;
				if (objectGeoLocation.ContainsKey("SIDE"))
				{
					string str = null;
					try
					{
						str = Conversions.ToString(objectGeoLocation["SIDE"]);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						throw new Exception2("side must be a string");
					}
					try
					{
						side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						throw new Exception2("Can't find Side '" + str + "'");
					}
				}
				if (objectGeoLocation.ContainsKey("AWARENESS"))
				{
					string text = Conversions.ToString(objectGeoLocation["AWARENESS"]).ToUpper();
					uint num = Class382.smethod_0(text);
					if (num <= 923577301u)
					{
						if (num <= 873244444u)
						{
							if (num != 348981803u)
							{
								if (num != 873244444u)
								{
									goto IL_237;
								}
								if (Operators.CompareString(text, "1", false) != 0)
								{
									goto IL_237;
								}
								goto IL_242;
							}
							else
							{
								if (Operators.CompareString(text, "-1", false) != 0)
								{
									goto IL_237;
								}
								goto IL_206;
							}
						}
						else if (num != 890022063u)
						{
							if (num != 906799682u)
							{
								if (num != 923577301u)
								{
									goto IL_237;
								}
								if (Operators.CompareString(text, "2", false) != 0)
								{
									goto IL_237;
								}
							}
							else
							{
								if (Operators.CompareString(text, "3", false) != 0)
								{
									goto IL_237;
								}
								goto IL_220;
							}
						}
						else
						{
							if (Operators.CompareString(text, "0", false) != 0)
							{
								goto IL_237;
							}
							goto IL_1CB;
						}
					}
					else if (num <= 1195330816u)
					{
						if (num != 1009949074u)
						{
							if (num != 1195330816u || Operators.CompareString(text, "AUTOUNIT", false) != 0)
							{
								goto IL_237;
							}
						}
						else
						{
							if (Operators.CompareString(text, "NORMAL", false) == 0)
							{
								goto IL_1CB;
							}
							goto IL_237;
						}
					}
					else if (num != 1214123317u)
					{
						if (num != 3535787620u)
						{
							if (num == 3794288532u && Operators.CompareString(text, "BLIND", false) == 0)
							{
								goto IL_206;
							}
							goto IL_237;
						}
						else
						{
							if (Operators.CompareString(text, "OMNI", false) == 0)
							{
								goto IL_220;
							}
							goto IL_237;
						}
					}
					else
					{
						if (Operators.CompareString(text, "AUTOSIDE", false) != 0)
						{
							goto IL_237;
						}
						goto IL_242;
					}
					Side.AwarenessLevel awarenessLevel = Side.AwarenessLevel.AutoSideAndUnitID;
					goto IL_245;
					IL_1CB:
					awarenessLevel = Side.AwarenessLevel.Normal;
					goto IL_245;
					IL_206:
					awarenessLevel = Side.AwarenessLevel.Blind;
					goto IL_245;
					IL_220:
					awarenessLevel = Side.AwarenessLevel.Omniscient;
					goto IL_245;
					IL_237:
					throw new Exception2("Invalid awareness code! (Valid codes: -1 ... 3)");
					IL_242:
					awarenessLevel = Side.AwarenessLevel.AutoSideID;
					IL_245:
					side.SetAwarenessLevel(awarenessLevel);
				}
				if (objectGeoLocation.ContainsKey("PROFICIENCY"))
				{
					string text2 = Conversions.ToString(objectGeoLocation["PROFICIENCY"]).ToUpper();
					uint num = Class382.smethod_0(text2);
					GlobalVariables.ProficiencyLevel proficiencyLevel;
					if (num <= 890022063u)
					{
						if (num <= 615451163u)
						{
							if (num != 591782726u)
							{
								if (num != 615451163u)
								{
									goto IL_40E;
								}
								if (Operators.CompareString(text2, "NOVICE", false) != 0)
								{
									goto IL_40E;
								}
							}
							else
							{
								if (Operators.CompareString(text2, "CADET", false) != 0)
								{
									goto IL_40E;
								}
								goto IL_339;
							}
						}
						else if (num != 822911587u)
						{
							if (num != 873244444u)
							{
								if (num != 890022063u || Operators.CompareString(text2, "0", false) != 0)
								{
									goto IL_40E;
								}
							}
							else
							{
								if (Operators.CompareString(text2, "1", false) == 0)
								{
									goto IL_339;
								}
								goto IL_40E;
							}
						}
						else
						{
							if (Operators.CompareString(text2, "4", false) != 0)
							{
								goto IL_40E;
							}
							goto IL_3E0;
						}
						proficiencyLevel = GlobalVariables.ProficiencyLevel.Novice;
						goto IL_41C;
						IL_339:
						proficiencyLevel = GlobalVariables.ProficiencyLevel.Cadet;
						goto IL_41C;
					}
					if (num <= 923577301u)
					{
						if (num != 906799682u)
						{
							if (num != 923577301u)
							{
								goto IL_40E;
							}
							if (Operators.CompareString(text2, "2", false) != 0)
							{
								goto IL_40E;
							}
							goto IL_419;
						}
						else if (Operators.CompareString(text2, "3", false) != 0)
						{
							goto IL_40E;
						}
					}
					else if (num != 1139941943u)
					{
						if (num != 2090721268u)
						{
							if (num == 2122752904u && Operators.CompareString(text2, "ACE", false) == 0)
							{
								goto IL_3E0;
							}
							goto IL_40E;
						}
						else if (Operators.CompareString(text2, "VETERAN", false) != 0)
						{
							goto IL_40E;
						}
					}
					else
					{
						if (Operators.CompareString(text2, "REGULAR", false) != 0)
						{
							goto IL_40E;
						}
						goto IL_419;
					}
					proficiencyLevel = GlobalVariables.ProficiencyLevel.Veteran;
					goto IL_41C;
					IL_419:
					proficiencyLevel = GlobalVariables.ProficiencyLevel.Regular;
					goto IL_41C;
					IL_3E0:
					proficiencyLevel = GlobalVariables.ProficiencyLevel.Ace;
					goto IL_41C;
					IL_40E:
					throw new Exception2("Invalid proficiency code! (Valid codes: 0 ... 4)");
					IL_41C:
					side.SetProficiencyLevel(proficiencyLevel);
				}
				LuaUtility.smethod_3(objectGeoLocation, luaTable_0);
				result = PrivateMethods.smethod_21(luaTable_0, scenario_0);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x003640B4 File Offset: 0x003622B4
		public static LuaTable smethod_14(LuaTable luaTable_0, Scenario scenario_0)
		{
			LuaTable result;
			try
			{
				Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
				ActiveUnit activeUnit = null;
				LuaSandBox.Singleton().CreateTable();
				LuaUtility.smethod_4(ref objectGeoLocation);
				string text = LuaUtility.smethod_25(objectGeoLocation, scenario_0);
				if (text.Length != 0)
				{
					throw new Exception2(text);
				}
				if (objectGeoLocation.ContainsKey("GUID"))
				{
					string key;
					try
					{
						key = Conversions.ToString(objectGeoLocation["GUID"]);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						throw new Exception2("guid must be a string");
					}
					try
					{
						activeUnit = scenario_0.GetActiveUnits()[key];
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				if (activeUnit == null)
				{
					throw new Exception2("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
				}
				if (!objectGeoLocation.ContainsKey("LOADOUTID"))
				{
					throw new Exception2("Must provide a valid loadout ID");
				}
				int num = Conversions.ToInteger(objectGeoLocation["LOADOUTID"]);
				Loadout loadout;
				try
				{
					loadout = DBFunctions.smethod_47(ref scenario_0, num, false);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					throw new Exception2("Must provide a valid loadout ID");
				}
				if (!objectGeoLocation.ContainsKey("QUANTITY") || Conversions.ToInteger(objectGeoLocation["QUANTITY"]) <= 0)
				{
					throw new Exception2("Must provide a valid (>0) quantity number");
				}
				int num2 = Conversions.ToInteger(objectGeoLocation["QUANTITY"]);
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				luaTable[1] = string.Concat(new string[]
				{
					"Attempting to add ",
					Conversions.ToString(num2),
					"x packs of loadout: #",
					Conversions.ToString(num),
					" - ",
					loadout.Name,
					" to the magazines of unit: ",
					activeUnit.Name
				});
				int num3 = 1;
				WeaponRec[] weaponRecArray = loadout.WeaponRecArray;
				for (int i = 0; i < weaponRecArray.Length; i = checked(i + 1))
				{
					WeaponRec weaponRec = weaponRecArray[i];
					weaponRec.MaxLoad *= num2;
					weaponRec.SetCurrentLoad(weaponRec.GetCurrentLoad() * num2);
					int num4 = 0;
					int num5 = 0;
					if (weaponRec.GetCurrentLoad() > 0)
					{
						int currentLoad = weaponRec.GetCurrentLoad();
						for (int j = 1; j <= currentLoad; j++)
						{
							if (Operators.CompareString(activeUnit.GetWeaponry().AddToMagazineWeaponLoad(weaponRec.WeapID, true, true), "OK", false) == 0)
							{
								num4++;
							}
							else
							{
								num5++;
							}
						}
						if (num4 > 0)
						{
							num3++;
							luaTable[num3] = "Successfully added " + Conversions.ToString(num4) + "x stores of type: " + weaponRec.GetWeapon(scenario_0).Name;
						}
						if (num5 > 0)
						{
							num3++;
							luaTable[num3] = "Failed to add " + Conversions.ToString(num5) + "x stores of type: " + weaponRec.GetWeapon(scenario_0).Name;
						}
					}
				}
				result = luaTable;
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x00364438 File Offset: 0x00362638
		public static LuaTable smethod_15(LuaTable luaTable_0, Scenario scenario_0)
		{
			LuaTable result;
			try
			{
				Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
				ActiveUnit activeUnit = null;
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				LuaUtility.smethod_4(ref objectGeoLocation);
				string text = LuaUtility.smethod_25(objectGeoLocation, scenario_0);
				if (text.Length == 0)
				{
					if (objectGeoLocation.ContainsKey("GUID"))
					{
						string key;
						try
						{
							key = Conversions.ToString(objectGeoLocation["GUID"]);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							throw new Exception2("guid must be a string");
						}
						activeUnit = scenario_0.GetActiveUnits()[key];
					}
					LuaTable luaTable2;
					if (activeUnit == null)
					{
						luaTable2 = null;
						result = luaTable2;
						return result;
					}
					ActiveUnit_Damage damage = activeUnit.GetDamage();
					int num = 0;
					if (objectGeoLocation.ContainsKey("FIRES"))
					{
						try
						{
							object objectValue = RuntimeHelpers.GetObjectValue(objectGeoLocation["FIRES"]);
							damage.SetFireIntensityLevel((ActiveUnit_Damage.FireIntensityLevel)Conversions.ToByte(objectValue));
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
					}
					if (objectGeoLocation.ContainsKey("FLOOD"))
					{
						try
						{
							object objectValue2 = RuntimeHelpers.GetObjectValue(objectGeoLocation["FLOOD"]);
							damage.vmethod_2((ActiveUnit_Damage.FloodingIntensityLevel)Conversions.ToByte(objectValue2));
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
						}
					}
					if (objectGeoLocation.ContainsKey("DP"))
					{
						try
						{
							num = Conversions.ToInteger(objectGeoLocation["DP"]);
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
						ActiveUnit activeUnit2;
						(activeUnit2 = activeUnit).SetDamagePts(false, activeUnit2.GetDamagePts(false) - (float)num);
					}
					if (objectGeoLocation.ContainsKey("COMPONENTS"))
					{
						List<object> list = LuaUtility.smethod_0(((LuaTable)objectGeoLocation["COMPONENTS"]).GetEnumerator());
						using (List<object>.Enumerator enumerator = list.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator.Current);
								if (!(objectValue3 is LuaTable))
								{
									throw new Exception2("Error at " + LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(objectValue3)) + " in ScenEdit_SetUnitDamage.");
								}
								Dictionary<string, object> objectGeoLocation2 = LuaUtility.GetObjectGeoLocation(((LuaTable)objectValue3).GetEnumerator());
								if (objectGeoLocation2.Count > 0)
								{
									PlatformComponent platformComponent = null;
									bool flag = false;
									string text2 = Conversions.ToString(objectGeoLocation2["1"]);
									PlatformComponent._DamageSeverityFactor damageSeverityFactor = PlatformComponent._DamageSeverityFactor.Light;
									if (Operators.CompareString(Conversions.ToString(objectGeoLocation2["2"]).ToLower(), "none", false) == 0)
									{
										flag = true;
									}
									else
									{
										if (!(Enum.TryParse<PlatformComponent._DamageSeverityFactor>(Conversions.ToString(objectGeoLocation2["2"]), out damageSeverityFactor) & Enum.IsDefined(typeof(PlatformComponent._DamageSeverityFactor), damageSeverityFactor)))
										{
											throw new Exception2("Error in damage level for  '" + text2 + "' in ScenEdit_SetUnitDamage.");
										}
										if (damageSeverityFactor > PlatformComponent._DamageSeverityFactor.Heavy)
										{
											damageSeverityFactor = PlatformComponent._DamageSeverityFactor.Heavy;
										}
										else if (damageSeverityFactor < PlatformComponent._DamageSeverityFactor.Light)
										{
											damageSeverityFactor = PlatformComponent._DamageSeverityFactor.Light;
										}
									}
									int count = activeUnit.GetAllPlatformComponents().Count;
									int num2 = GameGeneral.GetRandom().Next(0, count);
									if (Operators.CompareString(text2.ToUpper(), "TYPE", false) == 0)
									{
										if (objectGeoLocation2.ContainsKey("TYPE"))
										{
											string text3 = Conversions.ToString(objectGeoLocation2["TYPE"]);
											if (count > 0)
											{
												PlatformComponent[] array = new PlatformComponent[count + 1];
												int num3 = 0;
												using (IEnumerator<PlatformComponent> enumerator2 = activeUnit.GetAllPlatformComponents().GetEnumerator())
												{
													while (enumerator2.MoveNext())
													{
														platformComponent = enumerator2.Current;
														if (Operators.CompareString(platformComponent.GetType().Name.ToUpper(), text3.ToUpper(), false) == 0)
														{
															array[num3] = platformComponent;
															num3++;
														}
													}
												}
												if (num3 > 0)
												{
													num2 = GameGeneral.GetRandom().Next(0, num3);
													PlatformComponent._DamageSeverityFactor damageSeverity = array[num2].GetDamageSeverity();
													array[num2].StopIlluminateAndTurnOff(damageSeverityFactor);
													if (damageSeverityFactor == PlatformComponent._DamageSeverityFactor.Light & (flag | damageSeverity > PlatformComponent._DamageSeverityFactor.Light))
													{
														array[num2].vmethod_8();
													}
													LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
													luaTable3["guid"] = array[num2].GetGuid();
													luaTable3["dbid"] = array[num2].DBID;
													luaTable3["name"] = array[num2].Name;
													luaTable3["type"] = array[num2].GetType().Name;
													luaTable3["status"] = array[num2].GetComponentStatus().ToString();
													if (platformComponent.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
													{
														luaTable3["damage"] = array[num2].GetDamageSeverity().ToString();
													}
													luaTable[luaTable.Keys.Count + 1] = luaTable3;
												}
											}
										}
										else
										{
											PlatformComponent._DamageSeverityFactor damageSeverity2 = activeUnit.GetAllPlatformComponents()[num2].GetDamageSeverity();
											activeUnit.GetAllPlatformComponents()[num2].StopIlluminateAndTurnOff(damageSeverityFactor);
											if (damageSeverityFactor == PlatformComponent._DamageSeverityFactor.Light & (flag | damageSeverity2 > PlatformComponent._DamageSeverityFactor.Light))
											{
												activeUnit.GetAllPlatformComponents()[num2].vmethod_8();
											}
										}
									}
									else
									{
										LuaTable luaTable4 = LuaSandBox.Singleton().CreateTable();
										bool flag2 = false;
										string left = activeUnit.GetType().ToString();
										if (Operators.CompareString(left, "Command_Core.Ship", false) != 0)
										{
											if (Operators.CompareString(left, "Command_Core.Submarine", false) != 0)
											{
												if (Operators.CompareString(left, "Command_Core.Facility", false) == 0 && Operators.CompareString(text2.ToUpper(), "RUDDER", false) != 0)
												{
													if (Operators.CompareString(text2.ToUpper(), "CARGO", false) == 0)
													{
														((Facility)activeUnit).m_Cargo.StopIlluminateAndTurnOff(damageSeverityFactor);
														luaTable4["name"] = text2.ToUpper();
														luaTable4["status"] = ((Facility)activeUnit).m_Cargo.GetComponentStatus().ToString();
														if (((Facility)activeUnit).m_Cargo.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
														{
															luaTable4["damage"] = ((Facility)activeUnit).m_Cargo.GetDamageSeverity().ToString();
														}
														luaTable[luaTable.Keys.Count + 1] = luaTable4;
														flag2 = true;
													}
													else if (Operators.CompareString(text2.ToUpper(), "PRESSUREHULL", false) != 0 && Operators.CompareString(text2.ToUpper(), "CIC", false) == 0)
													{
														((Facility)activeUnit).m_CommandPost.StopIlluminateAndTurnOff(damageSeverityFactor);
														luaTable4["name"] = text2.ToUpper();
														luaTable4["status"] = ((Facility)activeUnit).m_CommandPost.GetComponentStatus().ToString();
														if (((Facility)activeUnit).m_CommandPost.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
														{
															luaTable4["damage"] = ((Facility)activeUnit).m_CommandPost.GetDamageSeverity().ToString();
														}
														luaTable[luaTable.Keys.Count + 1] = luaTable4;
														flag2 = true;
													}
												}
											}
											else if (Operators.CompareString(text2.ToUpper(), "RUDDER", false) == 0)
											{
												((Submarine)activeUnit).m_Rudder.StopIlluminateAndTurnOff(damageSeverityFactor);
												luaTable4["name"] = text2.ToUpper();
												luaTable4["status"] = ((Submarine)activeUnit).m_Rudder.GetComponentStatus().ToString();
												if (((Submarine)activeUnit).m_Rudder.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
												{
													luaTable4["damage"] = ((Submarine)activeUnit).m_Rudder.GetDamageSeverity().ToString();
												}
												luaTable[luaTable.Keys.Count + 1] = luaTable4;
												flag2 = true;
											}
											else if (Operators.CompareString(text2.ToUpper(), "CARGO", false) == 0)
											{
												((Submarine)activeUnit).m_Cargo.StopIlluminateAndTurnOff(damageSeverityFactor);
												luaTable4["name"] = text2.ToUpper();
												luaTable4["status"] = ((Submarine)activeUnit).m_Cargo.GetComponentStatus().ToString();
												if (((Submarine)activeUnit).m_Cargo.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
												{
													luaTable4["damage"] = ((Submarine)activeUnit).m_Cargo.GetDamageSeverity().ToString();
												}
												luaTable[luaTable.Keys.Count + 1] = luaTable4;
												flag2 = true;
											}
											else if (Operators.CompareString(text2.ToUpper(), "PRESSUREHULL", false) == 0)
											{
												((Submarine)activeUnit).m_PressureHull.StopIlluminateAndTurnOff(damageSeverityFactor);
												luaTable4["name"] = text2.ToUpper();
												luaTable4["status"] = ((Submarine)activeUnit).m_PressureHull.GetComponentStatus().ToString();
												if (((Submarine)activeUnit).m_PressureHull.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
												{
													luaTable4["damage"] = ((Submarine)activeUnit).m_PressureHull.GetDamageSeverity().ToString();
												}
												luaTable[luaTable.Keys.Count + 1] = luaTable4;
												flag2 = true;
											}
											else if (Operators.CompareString(text2.ToUpper(), "CIC", false) == 0)
											{
												((Submarine)activeUnit).m_CIC.StopIlluminateAndTurnOff(damageSeverityFactor);
												luaTable4["name"] = text2.ToUpper();
												luaTable4["status"] = ((Submarine)activeUnit).m_CIC.GetComponentStatus().ToString();
												if (((Submarine)activeUnit).m_CIC.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
												{
													luaTable4["damage"] = ((Submarine)activeUnit).m_CIC.GetDamageSeverity().ToString();
												}
												luaTable[luaTable.Keys.Count + 1] = luaTable4;
												flag2 = true;
											}
										}
										else if (Operators.CompareString(text2.ToUpper(), "RUDDER", false) == 0)
										{
											((Ship)activeUnit).m_Rudder.StopIlluminateAndTurnOff(damageSeverityFactor);
											luaTable4["name"] = text2.ToUpper();
											luaTable4["status"] = ((Ship)activeUnit).m_Rudder.GetComponentStatus().ToString();
											if (((Ship)activeUnit).m_Rudder.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
											{
												luaTable4["damage"] = ((Ship)activeUnit).m_Rudder.GetDamageSeverity().ToString();
											}
											luaTable[luaTable.Keys.Count + 1] = luaTable4;
											flag2 = true;
										}
										else if (Operators.CompareString(text2.ToUpper(), "CARGO", false) != 0 && Operators.CompareString(text2.ToUpper(), "PRESSUREHULL", false) != 0 && Operators.CompareString(text2.ToUpper(), "CIC", false) == 0)
										{
											((Ship)activeUnit).m_CommandPost.StopIlluminateAndTurnOff(damageSeverityFactor);
											luaTable4["name"] = text2.ToUpper();
											luaTable4["status"] = ((Ship)activeUnit).m_CommandPost.GetComponentStatus().ToString();
											if (((Ship)activeUnit).m_CommandPost.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
											{
												luaTable4["damage"] = ((Ship)activeUnit).m_CommandPost.GetDamageSeverity().ToString();
											}
											luaTable[luaTable.Keys.Count + 1] = luaTable4;
											flag2 = true;
										}
										if (count > 0 & !flag2)
										{
											using (IEnumerator<PlatformComponent> enumerator3 = activeUnit.GetAllPlatformComponents().GetEnumerator())
											{
												while (enumerator3.MoveNext())
												{
													platformComponent = enumerator3.Current;
													if (Operators.CompareString(platformComponent.GetGuid().ToUpper(), text2.ToUpper(), false) == 0 | Operators.CompareString(platformComponent.Name.ToUpper(), text2.ToUpper(), false) == 0)
													{
														PlatformComponent._DamageSeverityFactor damageSeverity3 = platformComponent.GetDamageSeverity();
														platformComponent.StopIlluminateAndTurnOff(damageSeverityFactor);
														if (damageSeverityFactor == PlatformComponent._DamageSeverityFactor.Light & (flag | damageSeverity3 > PlatformComponent._DamageSeverityFactor.Light))
														{
															platformComponent.vmethod_8();
														}
														LuaTable luaTable5 = LuaSandBox.Singleton().CreateTable();
														luaTable5["guid"] = platformComponent.GetGuid();
														luaTable5["dbid"] = platformComponent.DBID;
														luaTable5["name"] = platformComponent.Name;
														luaTable5["type"] = platformComponent.GetType().Name;
														luaTable5["status"] = platformComponent.GetComponentStatus().ToString();
														if (platformComponent.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
														{
															luaTable5["damage"] = platformComponent.GetDamageSeverity().ToString();
														}
														luaTable[luaTable.Keys.Count + 1] = luaTable5;
														break;
													}
												}
											}
										}
									}
								}
							}
							goto IL_D99;
						}
						goto IL_D91;
					}
					IL_D99:
					LuaUtility.smethod_3(objectGeoLocation, luaTable_0);
					luaTable2 = luaTable;
					result = luaTable2;
					return result;
				}
				IL_D91:
				throw new Exception2(text);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x003652CC File Offset: 0x003634CC
		public static bool smethod_16(string string_0, string string_1, string string_2, Scenario scenario_0)
		{
			bool result = false;
			checked
			{
				try
				{
					Doctrine doctrine = null;
					string left = string_0.ToUpper();
					if (Operators.CompareString(left, "SIDE", false) != 0)
					{
						if (Operators.CompareString(left, "MISSION", false) != 0)
						{
							if (Operators.CompareString(left, "GROUP", false) != 0)
							{
								if (Operators.CompareString(left, "UNIT", false) != 0)
								{
									throw new Exception2("Unable to identify EMCON subject type! Valid inputs are: Side / Mission /Group / Unit");
								}
								using (List<ActiveUnit>.Enumerator enumerator = scenario_0.GetActiveUnitList().GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										ActiveUnit current = enumerator.Current;
										if (Operators.CompareString(current.Name.ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(current.GetGuid(), string_1.ToLower(), false) == 0)
										{
											doctrine = current.m_Doctrine;
											break;
										}
									}
									goto IL_267;
								}
							}
							using (List<ActiveUnit>.Enumerator enumerator2 = scenario_0.GetActiveUnitList().GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									ActiveUnit current2 = enumerator2.Current;
									if (current2.IsGroup && (Operators.CompareString(current2.Name.ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(current2.GetGuid(), string_1.ToLower(), false) == 0))
									{
										doctrine = current2.m_Doctrine;
										break;
									}
								}
								goto IL_267;
							}
						}
						Side[] sides = scenario_0.GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							Side side = sides[i];
							foreach (Mission current3 in side.GetMissionCollection())
							{
								if (Operators.CompareString(current3.Name.ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(current3.GetGuid(), string_1.ToLower(), false) == 0)
								{
									doctrine = current3.m_Doctrine;
									break;
								}
							}
						}
					}
					else
					{
						Side[] sides2 = scenario_0.GetSides();
						for (int j = 0; j < sides2.Length; j++)
						{
							Side side2 = sides2[j];
							if (Operators.CompareString(side2.GetSideName().ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(side2.GetGuid(), string_1.ToLower(), false) == 0)
							{
								doctrine = side2.m_Doctrine;
								break;
							}
						}
					}
					IL_267:
					if (Information.IsNothing(doctrine))
					{
						throw new Exception2("Unable to identify subject of EMCON change! Please verify the subject-type and subject-name/ID strings.");
					}
					string[] array = string_2.Split(new char[]
					{
						';'
					});
					for (int k = 0; k < array.Length; k++)
					{
						string text = array[k];
						if (Operators.CompareString(text.ToUpper(), "INHERIT", false) == 0)
						{
							doctrine.SetEMCON_Settings(true);
						}
						else
						{
							KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>(text.Split(new char[]
							{
								'='
							})[0], text.Split(new char[]
							{
								'='
							})[1]);
							string left2 = keyValuePair.Key.ToUpper();
							if (Operators.CompareString(left2, "RADAR", false) != 0)
							{
								if (Operators.CompareString(left2, "SONAR", false) != 0)
								{
									if (Operators.CompareString(left2, "OECM", false) == 0)
									{
										if (Operators.CompareString(keyValuePair.Value.ToUpper(), "ACTIVE", false) == 0)
										{
											if (doctrine.EMCON_SettingsHasNoValue())
											{
												doctrine.SetEMCON_Settings(false);
											}
											doctrine.method_173(Doctrine.EMCON_Settings.Enum36.const_1, scenario_0);
										}
										else
										{
											if (Operators.CompareString(keyValuePair.Value.ToUpper(), "PASSIVE", false) != 0)
											{
												throw new Exception2("Invalid value for OECM EMCON setting (Valid values: Active / Passive).");
											}
											if (doctrine.EMCON_SettingsHasNoValue())
											{
												doctrine.SetEMCON_Settings(false);
											}
											doctrine.method_173(Doctrine.EMCON_Settings.Enum36.const_0, scenario_0);
										}
									}
								}
								else if (Operators.CompareString(keyValuePair.Value.ToUpper(), "ACTIVE", false) == 0)
								{
									if (doctrine.EMCON_SettingsHasNoValue())
									{
										doctrine.SetEMCON_Settings(false);
									}
									doctrine.SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.Enum36.const_1, scenario_0);
								}
								else
								{
									if (Operators.CompareString(keyValuePair.Value.ToUpper(), "PASSIVE", false) != 0)
									{
										throw new Exception2("Invalid value for sonar EMCON setting (Valid values: Active / Passive).");
									}
									if (doctrine.EMCON_SettingsHasNoValue())
									{
										doctrine.SetEMCON_Settings(false);
									}
									doctrine.SetEMCON_SettingsForRadar(Doctrine.EMCON_Settings.Enum36.const_0, scenario_0);
								}
							}
							else if (Operators.CompareString(keyValuePair.Value.ToUpper(), "ACTIVE", false) == 0)
							{
								if (doctrine.EMCON_SettingsHasNoValue())
								{
									doctrine.SetEMCON_Settings(false);
								}
								doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_1, scenario_0);
							}
							else
							{
								if (Operators.CompareString(keyValuePair.Value.ToUpper(), "PASSIVE", false) != 0)
								{
									throw new Exception2("Invalid value for radar EMCON setting (Valid values: Active / Passive).");
								}
								if (doctrine.EMCON_SettingsHasNoValue())
								{
									doctrine.SetEMCON_Settings(false);
								}
								doctrine.SetEMCON_SettingsForSonar(Doctrine.EMCON_Settings.Enum36.const_0, scenario_0);
							}
						}
					}
					result = true;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
				return result;
			}
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x0036584C File Offset: 0x00363A4C
		public static string smethod_17(string string_0, int int_0)
		{
			string result = "";
			PrivateMethods.Delegate27 @delegate = PrivateMethods.delegate27_0;
			if (@delegate != null)
			{
				@delegate(string_0, int_0, ref result);
			}
			return result;
		}

		// Token: 0x060067B3 RID: 26547 RVA: 0x00365878 File Offset: 0x00363A78
		public static string smethod_18(string string_0, bool bool_0, int int_0)
		{
			PrivateMethods.Delegate28 @delegate = PrivateMethods.delegate28_0;
			if (@delegate != null)
			{
				@delegate(string_0, bool_0, int_0);
			}
			return "";
		}

		// Token: 0x060067B4 RID: 26548 RVA: 0x003658A4 File Offset: 0x00363AA4
		public static int smethod_19(string string_0, Scenario scenario_0)
		{
			Side side = LuaUtility.smethod_14(string_0, scenario_0);
			if (Information.IsNothing(side))
			{
				throw new Exception2("Unable to identify Side!");
			}
			return side.GetTotalScore(scenario_0, null);
		}

		// Token: 0x060067B5 RID: 26549 RVA: 0x003658DC File Offset: 0x00363ADC
		public static string smethod_20(string string_0, string string_1, Scenario scenario_0)
		{
			checked
			{
				string text;
				string result;
				try
				{
					Side side = null;
					Side side2 = null;
					Side[] sides = scenario_0.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side3 = sides[i];
						if (Operators.CompareString(side3.GetSideName().ToUpper(), string_0.ToUpper(), false) == 0 || Operators.CompareString(side3.GetGuid(), string_0.ToLower(), false) == 0)
						{
							side = side3;
						}
						if (Operators.CompareString(side3.GetSideName().ToUpper(), string_1.ToUpper(), false) == 0 || Operators.CompareString(side3.GetGuid(), string_1.ToLower(), false) == 0)
						{
							side2 = side3;
						}
					}
					if (Information.IsNothing(side))
					{
						throw new Exception2("Unable to identify Side-A!");
					}
					if (Information.IsNothing(side2))
					{
						throw new Exception2("Unable to identify Side-B!");
					}
					switch (side.GetPostureStance(side2))
					{
					case Misc.PostureStance.Neutral:
						text = "N";
						result = text;
						return result;
					case Misc.PostureStance.Friendly:
						text = "F";
						result = text;
						return result;
					case Misc.PostureStance.Unfriendly:
						text = "U";
						result = text;
						return result;
					case Misc.PostureStance.Hostile:
						text = "H";
						result = text;
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
					throw;
				}
				text = "";
				result = text;
				return result;
			}
		}

		// Token: 0x060067B6 RID: 26550 RVA: 0x00365A4C File Offset: 0x00363C4C
		public static LuaTable smethod_21(LuaTable luaTable_0, Scenario scenario_0)
		{
			try
			{
				Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
				Side side = null;
				if (objectGeoLocation.ContainsKey("SIDE"))
				{
					string str = null;
					try
					{
						str = Conversions.ToString(objectGeoLocation["SIDE"]);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						throw new Exception2("side must be a string");
					}
					try
					{
						side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						throw new Exception2("Can't find Side '" + str + "'");
					}
				}
				objectGeoLocation["SIDE"] = side.GetSideName();
				objectGeoLocation["GUID"] = side.GetGuid();
				objectGeoLocation["AWARENESS"] = side.GetAwarenessLevel().ToString();
				objectGeoLocation["PROFICIENCY"] = side.GetProficiencyLevel().ToString();
				LuaUtility.smethod_3(objectGeoLocation, luaTable_0);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return luaTable_0;
		}

		// Token: 0x060067B7 RID: 26551 RVA: 0x00365B74 File Offset: 0x00363D74
		public static bool smethod_22(string string_0, Scenario scenario_0)
		{
			checked
			{
				bool bool_;
				try
				{
					Side side = null;
					Side[] sides = scenario_0.GetSides();
					int i = 0;
					while (i < sides.Length)
					{
						side = sides[i];
						if (Operators.CompareString(side.GetSideName().ToUpper(), string_0.ToUpper(), false) != 0 && Operators.CompareString(side.GetGuid(), string_0.ToLower(), false) != 0)
						{
							i++;
						}
						else
						{
							side = side;
							if (Information.IsNothing(side))
							{
								throw new Exception2("Unable to identify side!");
							}
							bool_ = side.bool_8;
							return bool_;
						}
					}
					if (Information.IsNothing(side))
					{
						throw new Exception2("Unable to identify side!");
					}
					bool_ = side.bool_8;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
				return bool_;
			}
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x00365C40 File Offset: 0x00363E40
		public static int smethod_23(string string_0, int int_0, Scenario scenario_0, string string_1)
		{
			Side side = LuaUtility.smethod_14(string_0, scenario_0);
			if (Information.IsNothing(side))
			{
				throw new Exception2("Unable to identify Side!");
			}
			side.ChangeScore(scenario_0, string_1, int_0);
			return side.GetTotalScore(scenario_0, null);
		}

		// Token: 0x060067B9 RID: 26553 RVA: 0x00365C80 File Offset: 0x00363E80
		public static int smethod_24(string string_0, string string_1, Scenario scenario_0)
		{
			Side side = LuaUtility.smethod_14(string_0, scenario_0);
			if (Information.IsNothing(side))
			{
				throw new Exception2("Unable to identify Side-A!");
			}
			scenario_0.LogMessage(string_1, LoggedMessage.MessageType.SpecialMessage, 0, null, side, null);
			return 1;
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x00365CBC File Offset: 0x00363EBC
		public static LuaWrapper_ActiveUnit_SE smethod_25(LuaTable luaTable_0, Scenario scenario_0)
		{
			ActiveUnit activeUnit = null;
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			LuaUtility.smethod_4(ref objectGeoLocation);
			if (!objectGeoLocation.ContainsKey("TYPE"))
			{
				throw new Exception2("Missing 'Type' please choose one of SHIP, SUB, AIRCRAFT, FACILITY");
			}
			string text = Conversions.ToString(objectGeoLocation["TYPE"]).ToUpper();
			Side theSide = LuaUtility.smethod_16(objectGeoLocation, scenario_0);
			if (!objectGeoLocation.ContainsKey("DBID"))
			{
				throw new Exception2("Missing 'DBID'");
			}
			int num = Conversions.ToInteger(objectGeoLocation["DBID"]);
			if (!objectGeoLocation.ContainsKey("UNITNAME"))
			{
				throw new Exception2("Missing 'Name'");
			}
			string theName = Conversions.ToString(objectGeoLocation["UNITNAME"]);
			double? num2 = LuaUtility.smethod_10(objectGeoLocation);
			double? num3 = LuaUtility.smethod_12(objectGeoLocation);
			if (!objectGeoLocation.ContainsKey("BASE"))
			{
				if (!num2.HasValue)
				{
					throw new Exception2("Missing 'Latitude'");
				}
				if (!num3.HasValue)
				{
					throw new Exception2("Missing 'Longitude'");
				}
			}
			else
			{
				string aUName = Conversions.ToString(objectGeoLocation["BASE"]);
				if (!LuaUtility.smethod_26(objectGeoLocation, scenario_0))
				{
					throw new Exception2("Invalid base unit");
				}
				string text2 = Conversions.ToString(objectGeoLocation["BASE"]);
				ActiveUnit activeUnit2 = PrivateMethods.smethod_45(Conversions.ToString(objectGeoLocation["BASE"]), scenario_0);
				string aUGUID = text2;
				int i = 0;
				Platform platform = null;
				if (Operators.CompareString(text, "AIR", false) != 0 && Operators.CompareString(text, "AIRCRAFT", false) != 0)
				{
					if (Operators.CompareString(text, "SHIP", false) == 0 || (Operators.CompareString(text, "SUB", false) == 0 | Operators.CompareString(text, "SUBMARINE", false) == 0))
					{
						platform = new Ship(ref scenario_0, null);
						Ship ship = (Ship)platform;
						DBFunctions.smethod_51(ref scenario_0, ref ship, num, true);
					}
				}
				else
				{
					platform = new Aircraft(ref scenario_0, null);
					Aircraft aircraft = (Aircraft)platform;
					DBFunctions.smethod_19(ref scenario_0, ref aircraft, num, true);
				}
				while (i < 100)
				{
					if (Operators.CompareString(text, "AIR", false) != 0 && Operators.CompareString(text, "AIRCRAFT", false) != 0)
					{
						if (Operators.CompareString(text, "SHIP", false) != 0 && !(Operators.CompareString(text, "SUB", false) == 0 | Operators.CompareString(text, "SUBMARINE", false) == 0))
						{
							continue;
						}
						if (!activeUnit2.GetDockingOps().method_37(platform))
						{
							i++;
							activeUnit2 = PrivateMethods.smethod_48(aUGUID, aUName, scenario_0, true);
							if (activeUnit2 != null)
							{
								aUGUID = activeUnit2.GetGuid();
								continue;
							}
							if (text2 != null)
							{
								objectGeoLocation["BASE"] = text2;
							}
						}
						else if (!num3.HasValue | !num2.HasValue)
						{
							objectGeoLocation["LONGITUDE"] = activeUnit2.GetLongitude(null);
							objectGeoLocation["LATITUDE"] = activeUnit2.GetLatitude(null);
							num3 = new double?(activeUnit2.GetLongitude(null));
							num2 = new double?(activeUnit2.GetLatitude(null));
							objectGeoLocation["BASE"] = activeUnit2.GetGuid();
						}
					}
					else if (!activeUnit2.GetAirOps().CanBeHostedOnAirFacility((Aircraft)platform))
					{
						i++;
						activeUnit2 = PrivateMethods.smethod_48(aUGUID, aUName, scenario_0, true);
						if (activeUnit2 != null)
						{
							aUGUID = activeUnit2.GetGuid();
							continue;
						}
						if (text2 != null)
						{
							objectGeoLocation["BASE"] = text2;
						}
					}
					else if (!num3.HasValue | !num2.HasValue)
					{
						objectGeoLocation["ALTITUDE"] = activeUnit2.GetCurrentAltitude_ASL(false);
						objectGeoLocation["LONGITUDE"] = activeUnit2.GetLongitude(null);
						objectGeoLocation["LATITUDE"] = activeUnit2.GetLatitude(null);
						num3 = new double?(activeUnit2.GetLongitude(null));
						num2 = new double?(activeUnit2.GetLatitude(null));
						objectGeoLocation["BASE"] = activeUnit2.GetGuid();
					}
					break;
				}
			}
			try
			{
				uint num4 = Class382.smethod_0(text);
				if (num4 <= 1970077047u)
				{
					if (num4 != 522735669u)
					{
						if (num4 != 1434383544u)
						{
							if (num4 != 1970077047u)
							{
								goto IL_5FC;
							}
							if (Operators.CompareString(text, "AIR", false) != 0)
							{
								goto IL_5FC;
							}
							goto IL_612;
						}
						else if (Operators.CompareString(text, "FACILITY", false) != 0)
						{
							goto IL_5FC;
						}
					}
					else
					{
						if (Operators.CompareString(text, "SUB", false) != 0)
						{
							goto IL_5FC;
						}
						goto IL_55E;
					}
				}
				else if (num4 <= 2872863644u)
				{
					if (num4 != 2872515511u)
					{
						if (num4 != 2872863644u || Operators.CompareString(text, "LAND", false) != 0)
						{
							goto IL_5FC;
						}
					}
					else
					{
						if (Operators.CompareString(text, "SUBMARINE", false) == 0)
						{
							goto IL_55E;
						}
						goto IL_5FC;
					}
				}
				else if (num4 != 2901380595u)
				{
					if (num4 == 3920176767u && Operators.CompareString(text, "SHIP", false) == 0)
					{
						activeUnit = scenario_0.AddShip(theSide, num, theName, num3.Value, num2.Value, false, null);
						objectGeoLocation["TYPE"] = "SHIP";
						goto IL_694;
					}
					goto IL_5FC;
				}
				else
				{
					if (Operators.CompareString(text, "AIRCRAFT", false) != 0)
					{
						goto IL_5FC;
					}
					goto IL_612;
				}
				activeUnit = scenario_0.AddFacility(theSide, num, theName, num3.Value, num2.Value, false, null);
				objectGeoLocation["TYPE"] = "FACILITY";
				goto IL_694;
				IL_55E:
				activeUnit = scenario_0.AddSubmarine(theSide, num, theName, num3.Value, num2.Value, false, null);
				objectGeoLocation["TYPE"] = "SUBMARINE";
				goto IL_694;
				IL_5FC:
				throw new Exception2("Type cannot be " + text + " please choose one of the following: SHIP, SUB, AIRCRAFT, FACILITY");
				IL_612:
				if (!objectGeoLocation.ContainsKey("LOADOUTID"))
				{
					throw new Exception2("Missing 'LoadoutID'");
				}
				int loadoutID = Conversions.ToInteger(objectGeoLocation["LOADOUTID"]);
				float? num5 = LuaUtility.smethod_18(objectGeoLocation);
				if (!num5.HasValue)
				{
					throw new Exception2("Missing 'Altitude'");
				}
				activeUnit = scenario_0.AddAircraft(theSide, theName, num3.Value, num2.Value, num, loadoutID, (float)((short)Math.Round((double)num5.Value)), null);
				objectGeoLocation["TYPE"] = "AIRCRAFT";
				IL_694:;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (activeUnit == null)
			{
				throw new Exception2("Unable to create new unit");
			}
			string guid = activeUnit.GetGuid();
			objectGeoLocation["GUID"] = guid;
			if (objectGeoLocation.ContainsKey("BASE"))
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				luaTable["HostedUnitNameOrID"] = activeUnit.GetGuid();
				luaTable["SelectedHostNameOrID"] = Conversions.ToString(objectGeoLocation["BASE"]);
				if (!PrivateMethods.smethod_7(luaTable, scenario_0, null))
				{
					throw new Exception2("Unable to host unit");
				}
				activeUnit.SetCurrentSpeed(0f);
				activeUnit.SetThrottle(ActiveUnit.Throttle.FullStop, null);
			}
			LuaUtility.smethod_3(objectGeoLocation, luaTable_0);
			return PrivateMethods.smethod_29(luaTable_0, scenario_0);
		}

		// Token: 0x060067BB RID: 26555 RVA: 0x00366444 File Offset: 0x00364644
		public static LuaWrapper_ActiveUnit_SE smethod_26(LuaTable luaTable_0, Scenario scenario_0)
		{
			ActiveUnit activeUnit = null;
			string left = null;
			int num = 0;
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			LuaUtility.smethod_4(ref objectGeoLocation);
			if (objectGeoLocation.ContainsKey("GUID"))
			{
				string text = null;
				try
				{
					text = Conversions.ToString(objectGeoLocation["GUID"]);
					activeUnit = scenario_0.GetActiveUnits()[text];
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("Can't find guid " + text);
				}
			}
			if (objectGeoLocation.ContainsKey("MODE"))
			{
				try
				{
					left = Conversions.ToString(objectGeoLocation["MODE"]).ToUpper();
					if (Operators.CompareString(left, "ADD_SENSOR", false) != 0 && Operators.CompareString(left, "REMOVE_SENSOR", false) != 0 && Operators.CompareString(left, "UPDATE_SENSOR_ARC", false) != 0 && Operators.CompareString(left, "ADD_MOUNT", false) != 0 && Operators.CompareString(left, "REMOVE_MOUNT", false) != 0 && Operators.CompareString(left, "UPDATE_MOUNT_ARC", false) != 0)
					{
						throw new Exception2("function should be 'add_sensor', 'remove_sensor', 'add_mount', 'remove_mount'");
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					throw new Exception2("Unknown function");
				}
			}
			if (objectGeoLocation.ContainsKey("DBID"))
			{
				try
				{
					num = Conversions.ToInteger(objectGeoLocation["DBID"]);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					throw new Exception2("Missing dbid");
				}
			}
			PlatformComponent._CoverageArc coverageArc = default(PlatformComponent._CoverageArc);
			if (objectGeoLocation.ContainsKey("ARC_DETECT"))
			{
				LuaTable luaTable = (LuaTable)objectGeoLocation["ARC_DETECT"];
				PlatformComponent._CoverageArc coverageArc2 = default(PlatformComponent._CoverageArc);
				Conversions.ToString(LuaUtility.GetObjectGeoLocation(luaTable.GetEnumerator())["1"]);
				List<object> list = LuaUtility.smethod_0(luaTable.GetEnumerator());
				try
				{
					using (List<object>.Enumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							string text2 = Conversions.ToString(enumerator.Current);
							string text3 = text2.ToUpper();
							uint num2 = Class382.smethod_0(text3);
							if (num2 <= 2181607519u)
							{
								if (num2 <= 1604558652u)
								{
									if (num2 <= 1469204867u)
									{
										if (num2 != 3032978u)
										{
											if (num2 == 1469204867u && Operators.CompareString(text3, "PMF1", false) == 0)
											{
												coverageArc2.PMF1 = true;
												continue;
											}
										}
										else if (Operators.CompareString(text3, "PS2", false) == 0)
										{
											coverageArc2.PS2 = true;
											continue;
										}
									}
									else if (num2 != 1485982486u)
									{
										if (num2 == 1604558652u && Operators.CompareString(text3, "PMA1", false) == 0)
										{
											coverageArc2.PMA1 = true;
											continue;
										}
									}
									else if (Operators.CompareString(text3, "PMF2", false) == 0)
									{
										coverageArc2.PMF2 = true;
										continue;
									}
								}
								else if (num2 <= 1729738499u)
								{
									if (num2 != 1654891509u)
									{
										if (num2 == 1729738499u && Operators.CompareString(text3, "SS2", false) == 0)
										{
											coverageArc2.SS2 = true;
											continue;
										}
									}
									else if (Operators.CompareString(text3, "PMA2", false) == 0)
									{
										coverageArc2.PMA2 = true;
										continue;
									}
								}
								else if (num2 != 1746516118u)
								{
									if (num2 == 2181607519u && Operators.CompareString(text3, "PB2", false) == 0)
									{
										coverageArc2.PB2 = true;
										continue;
									}
								}
								else if (Operators.CompareString(text3, "SS1", false) == 0)
								{
									coverageArc2.SS1 = true;
									continue;
								}
							}
							else if (num2 <= 2859869279u)
							{
								if (num2 <= 2725501232u)
								{
									if (num2 != 2198385138u)
									{
										if (num2 == 2725501232u && Operators.CompareString(text3, "SMF1", false) == 0)
										{
											coverageArc2.SMF1 = true;
											continue;
										}
									}
									else if (Operators.CompareString(text3, "PB1", false) == 0)
									{
										coverageArc2.PB1 = true;
										continue;
									}
								}
								else if (num2 != 2775834089u)
								{
									if (num2 == 2859869279u && Operators.CompareString(text3, "SMA1", false) == 0)
									{
										coverageArc2.SMA1 = true;
										continue;
									}
								}
								else if (Operators.CompareString(text3, "SMF2", false) == 0)
								{
									coverageArc2.SMF2 = true;
									continue;
								}
							}
							else if (num2 <= 3512027844u)
							{
								if (num2 == 2876646898u)
								{
									if (Operators.CompareString(text3, "SMA2", false) == 0)
									{
										coverageArc2.SMA2 = true;
										continue;
									}
								}
								else if (num2 == 3512027844u && Operators.CompareString(text3, "360", false) == 0)
								{
									coverageArc2.PB1 = true;
									coverageArc2.PMA1 = true;
									coverageArc2.PMF1 = true;
									coverageArc2.PS1 = true;
									coverageArc2.SB1 = true;
									coverageArc2.SMA1 = true;
									coverageArc2.SMF1 = true;
									coverageArc2.SS1 = true;
									coverageArc2.PB2 = true;
									coverageArc2.PMA2 = true;
									coverageArc2.PMF2 = true;
									coverageArc2.PS2 = true;
									coverageArc2.SB2 = true;
									coverageArc2.SMA2 = true;
									coverageArc2.SMF2 = true;
									coverageArc2.SS2 = true;
									break;
								}
							}
							else if (num2 != 3824130755u)
							{
								if (num2 != 3840908374u)
								{
									if (num2 == 4281222655u && Operators.CompareString(text3, "PS1", false) == 0)
									{
										coverageArc2.PS1 = true;
										continue;
									}
								}
								else if (Operators.CompareString(text3, "SB2", false) == 0)
								{
									coverageArc2.SB2 = true;
									continue;
								}
							}
							else if (Operators.CompareString(text3, "SB1", false) == 0)
							{
								coverageArc2.SB1 = true;
								continue;
							}
							throw new Exception2("Invalid arc in arc_detect " + text2);
						}
					}
					coverageArc = coverageArc2;
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					throw new Exception2("Invalid arc in arc_detect ");
				}
			}
			PlatformComponent._CoverageArc coverageArcMax = default(PlatformComponent._CoverageArc);
			if (objectGeoLocation.ContainsKey("ARC_TRACK"))
			{
				LuaTable luaTable2 = (LuaTable)objectGeoLocation["ARC_TRACK"];
				PlatformComponent._CoverageArc coverageArc3 = default(PlatformComponent._CoverageArc);
				Conversions.ToString(LuaUtility.GetObjectGeoLocation(luaTable2.GetEnumerator())["1"]);
				List<object> list2 = LuaUtility.smethod_0(luaTable2.GetEnumerator());
				try
				{
					using (List<object>.Enumerator enumerator2 = list2.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							string text4 = Conversions.ToString(enumerator2.Current);
							string text5 = text4.ToUpper();
							uint num2 = Class382.smethod_0(text5);
							if (num2 <= 2181607519u)
							{
								if (num2 <= 1604558652u)
								{
									if (num2 <= 1469204867u)
									{
										if (num2 != 3032978u)
										{
											if (num2 == 1469204867u && Operators.CompareString(text5, "PMF1", false) == 0)
											{
												coverageArc3.PMF1 = true;
												continue;
											}
										}
										else if (Operators.CompareString(text5, "PS2", false) == 0)
										{
											coverageArc3.PS2 = true;
											continue;
										}
									}
									else if (num2 != 1485982486u)
									{
										if (num2 == 1604558652u && Operators.CompareString(text5, "PMA1", false) == 0)
										{
											coverageArc3.PMA1 = true;
											continue;
										}
									}
									else if (Operators.CompareString(text5, "PMF2", false) == 0)
									{
										coverageArc3.PMF2 = true;
										continue;
									}
								}
								else if (num2 <= 1729738499u)
								{
									if (num2 != 1654891509u)
									{
										if (num2 == 1729738499u && Operators.CompareString(text5, "SS2", false) == 0)
										{
											coverageArc3.SS2 = true;
											continue;
										}
									}
									else if (Operators.CompareString(text5, "PMA2", false) == 0)
									{
										coverageArc3.PMA2 = true;
										continue;
									}
								}
								else if (num2 != 1746516118u)
								{
									if (num2 == 2181607519u && Operators.CompareString(text5, "PB2", false) == 0)
									{
										coverageArc3.PB2 = true;
										continue;
									}
								}
								else if (Operators.CompareString(text5, "SS1", false) == 0)
								{
									coverageArc3.SS1 = true;
									continue;
								}
							}
							else if (num2 <= 2859869279u)
							{
								if (num2 <= 2725501232u)
								{
									if (num2 != 2198385138u)
									{
										if (num2 == 2725501232u && Operators.CompareString(text5, "SMF1", false) == 0)
										{
											coverageArc3.SMF1 = true;
											continue;
										}
									}
									else if (Operators.CompareString(text5, "PB1", false) == 0)
									{
										coverageArc3.PB1 = true;
										continue;
									}
								}
								else if (num2 != 2775834089u)
								{
									if (num2 == 2859869279u && Operators.CompareString(text5, "SMA1", false) == 0)
									{
										coverageArc3.SMA1 = true;
										continue;
									}
								}
								else if (Operators.CompareString(text5, "SMF2", false) == 0)
								{
									coverageArc3.SMF2 = true;
									continue;
								}
							}
							else if (num2 <= 3512027844u)
							{
								if (num2 == 2876646898u)
								{
									if (Operators.CompareString(text5, "SMA2", false) == 0)
									{
										coverageArc3.SMA2 = true;
										continue;
									}
								}
								else if (num2 == 3512027844u && Operators.CompareString(text5, "360", false) == 0)
								{
									coverageArc3.PB1 = true;
									coverageArc3.PMA1 = true;
									coverageArc3.PMF1 = true;
									coverageArc3.PS1 = true;
									coverageArc3.SB1 = true;
									coverageArc3.SMA1 = true;
									coverageArc3.SMF1 = true;
									coverageArc3.SS1 = true;
									coverageArc3.PB2 = true;
									coverageArc3.PMA2 = true;
									coverageArc3.PMF2 = true;
									coverageArc3.PS2 = true;
									coverageArc3.SB2 = true;
									coverageArc3.SMA2 = true;
									coverageArc3.SMF2 = true;
									coverageArc3.SS2 = true;
									break;
								}
							}
							else if (num2 != 3824130755u)
							{
								if (num2 != 3840908374u)
								{
									if (num2 == 4281222655u && Operators.CompareString(text5, "PS1", false) == 0)
									{
										coverageArc3.PS1 = true;
										continue;
									}
								}
								else if (Operators.CompareString(text5, "SB2", false) == 0)
								{
									coverageArc3.SB2 = true;
									continue;
								}
							}
							else if (Operators.CompareString(text5, "SB1", false) == 0)
							{
								coverageArc3.SB1 = true;
								continue;
							}
							throw new Exception2("Invalid arc in arc_track " + text4);
						}
					}
					coverageArcMax = coverageArc3;
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					throw new Exception2("Invalid arc in arc_track ");
				}
			}
			PlatformComponent._CoverageArc coverageArc4 = default(PlatformComponent._CoverageArc);
			if (objectGeoLocation.ContainsKey("ARC_MOUNT"))
			{
				LuaTable luaTable3 = (LuaTable)objectGeoLocation["ARC_MOUNT"];
				PlatformComponent._CoverageArc coverageArc5 = default(PlatformComponent._CoverageArc);
				Conversions.ToString(LuaUtility.GetObjectGeoLocation(luaTable3.GetEnumerator())["1"]);
				List<object> list3 = LuaUtility.smethod_0(luaTable3.GetEnumerator());
				try
				{
					using (List<object>.Enumerator enumerator3 = list3.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							string text6 = Conversions.ToString(enumerator3.Current);
							string text7 = text6.ToUpper();
							uint num2 = Class382.smethod_0(text7);
							if (num2 <= 2181607519u)
							{
								if (num2 <= 1604558652u)
								{
									if (num2 <= 1469204867u)
									{
										if (num2 != 3032978u)
										{
											if (num2 == 1469204867u && Operators.CompareString(text7, "PMF1", false) == 0)
											{
												coverageArc5.PMF1 = true;
												continue;
											}
										}
										else if (Operators.CompareString(text7, "PS2", false) == 0)
										{
											coverageArc5.PS2 = true;
											continue;
										}
									}
									else if (num2 != 1485982486u)
									{
										if (num2 == 1604558652u && Operators.CompareString(text7, "PMA1", false) == 0)
										{
											coverageArc5.PMA1 = true;
											continue;
										}
									}
									else if (Operators.CompareString(text7, "PMF2", false) == 0)
									{
										coverageArc5.PMF2 = true;
										continue;
									}
								}
								else if (num2 <= 1729738499u)
								{
									if (num2 != 1654891509u)
									{
										if (num2 == 1729738499u && Operators.CompareString(text7, "SS2", false) == 0)
										{
											coverageArc5.SS2 = true;
											continue;
										}
									}
									else if (Operators.CompareString(text7, "PMA2", false) == 0)
									{
										coverageArc5.PMA2 = true;
										continue;
									}
								}
								else if (num2 != 1746516118u)
								{
									if (num2 == 2181607519u && Operators.CompareString(text7, "PB2", false) == 0)
									{
										coverageArc5.PB2 = true;
										continue;
									}
								}
								else if (Operators.CompareString(text7, "SS1", false) == 0)
								{
									coverageArc5.SS1 = true;
									continue;
								}
							}
							else if (num2 <= 2859869279u)
							{
								if (num2 <= 2725501232u)
								{
									if (num2 != 2198385138u)
									{
										if (num2 == 2725501232u && Operators.CompareString(text7, "SMF1", false) == 0)
										{
											coverageArc5.SMF1 = true;
											continue;
										}
									}
									else if (Operators.CompareString(text7, "PB1", false) == 0)
									{
										coverageArc5.PB1 = true;
										continue;
									}
								}
								else if (num2 != 2775834089u)
								{
									if (num2 == 2859869279u && Operators.CompareString(text7, "SMA1", false) == 0)
									{
										coverageArc5.SMA1 = true;
										continue;
									}
								}
								else if (Operators.CompareString(text7, "SMF2", false) == 0)
								{
									coverageArc5.SMF2 = true;
									continue;
								}
							}
							else if (num2 <= 3512027844u)
							{
								if (num2 == 2876646898u)
								{
									if (Operators.CompareString(text7, "SMA2", false) == 0)
									{
										coverageArc5.SMA2 = true;
										continue;
									}
								}
								else if (num2 == 3512027844u && Operators.CompareString(text7, "360", false) == 0)
								{
									coverageArc5.PB1 = true;
									coverageArc5.PMA1 = true;
									coverageArc5.PMF1 = true;
									coverageArc5.PS1 = true;
									coverageArc5.SB1 = true;
									coverageArc5.SMA1 = true;
									coverageArc5.SMF1 = true;
									coverageArc5.SS1 = true;
									coverageArc5.PB2 = true;
									coverageArc5.PMA2 = true;
									coverageArc5.PMF2 = true;
									coverageArc5.PS2 = true;
									coverageArc5.SB2 = true;
									coverageArc5.SMA2 = true;
									coverageArc5.SMF2 = true;
									coverageArc5.SS2 = true;
									break;
								}
							}
							else if (num2 != 3824130755u)
							{
								if (num2 != 3840908374u)
								{
									if (num2 == 4281222655u && Operators.CompareString(text7, "PS1", false) == 0)
									{
										coverageArc5.PS1 = true;
										continue;
									}
								}
								else if (Operators.CompareString(text7, "SB2", false) == 0)
								{
									coverageArc5.SB2 = true;
									continue;
								}
							}
							else if (Operators.CompareString(text7, "SB1", false) == 0)
							{
								coverageArc5.SB1 = true;
								continue;
							}
							throw new Exception2("Invalid arc in arc_mount " + text6);
						}
					}
					coverageArc4 = coverageArc5;
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					throw new Exception2("Invalid arc in arc_mount ");
				}
			}
			checked
			{
				if (Operators.CompareString(left, "ADD_SENSOR", false) != 0 && Operators.CompareString(left, "REMOVE_SENSOR", false) != 0 && Operators.CompareString(left, "UPDATE_SENSOR_ARC", false) != 0)
				{
					if (Operators.CompareString(left, "ADD_MOUNT", false) != 0 && Operators.CompareString(left, "REMOVE_MOUNT", false) != 0 && Operators.CompareString(left, "UPDATE_MOUNT_ARC", false) != 0)
					{
						goto IL_16EA;
					}
					if (Operators.CompareString(left, "ADD_MOUNT", false) != 0)
					{
						if (Operators.CompareString(left, "REMOVE_MOUNT", false) == 0)
						{
							if (objectGeoLocation.ContainsKey("MOUNTID"))
							{
								string text8 = null;
								Mount mount = null;
								try
								{
									text8 = Conversions.ToString(objectGeoLocation["MOUNTID"]);
									Mount[] mounts = activeUnit.m_Mounts;
									int i = 0;
									while (i < mounts.Length)
									{
										Mount mount2 = mounts[i];
										if (Operators.CompareString(mount2.GetGuid(), text8, false) != 0)
										{
											i++;
										}
										else
										{
											mount = mount2;
											if (mount == null)
											{
												throw new Exception2("Can't find mount " + text8);
											}
											goto IL_118D;
										}
									}
									if (mount == null)
									{
										throw new Exception2("Can't find mount " + text8);
									}
								}
								catch (Exception projectError7)
								{
									ProjectData.SetProjectError(projectError7);
									throw new Exception2("Can't find mount " + text8);
								}
								IL_118D:
								try
								{
									ScenarioArrayUtil.RemoveMount(ref activeUnit.m_Mounts, mount);
									goto IL_16EA;
								}
								catch (Exception projectError8)
								{
									ProjectData.SetProjectError(projectError8);
									throw new Exception2("Unable to remove " + mount.Name);
								}
							}
							throw new Exception2("mount to remove not defined");
						}
						if (Operators.CompareString(left, "UPDATE_MOUNT_ARC", false) == 0)
						{
							if (objectGeoLocation.ContainsKey("MOUNTID"))
							{
								string text9 = null;
								Mount mount3 = null;
								try
								{
									text9 = Conversions.ToString(objectGeoLocation["MOUNTID"]);
									Mount[] mounts2 = activeUnit.m_Mounts;
									int j = 0;
									while (j < mounts2.Length)
									{
										Mount mount4 = mounts2[j];
										if (Operators.CompareString(mount4.GetGuid(), text9, false) != 0)
										{
											j++;
										}
										else
										{
											mount3 = mount4;
											if (mount3 == null)
											{
												throw new Exception2("Can't find Mount " + text9);
											}
											goto IL_12A0;
										}
									}
									if (mount3 == null)
									{
										throw new Exception2("Can't find Mount " + text9);
									}
								}
								catch (Exception projectError9)
								{
									ProjectData.SetProjectError(projectError9);
									throw new Exception2("Can't find mount " + text9);
								}
								IL_12A0:
								try
								{
									if (coverageArc4.HasSomeCoverage() && !coverageArc4.Equals(mount3.coverageArc))
									{
										mount3.coverageArc = coverageArc4;
									}
									goto IL_16EA;
								}
								catch (Exception projectError10)
								{
									ProjectData.SetProjectError(projectError10);
									throw new Exception2("Unable to update " + mount3.Name);
								}
							}
							throw new Exception2("Sensor to update not defined");
						}
						goto IL_16EA;
					}
					else
					{
						try
						{
							Mount mount5 = DBFunctions.LoadMountData(num, ref scenario_0, true);
							if (mount5 != null)
							{
								if (coverageArc4.HasSomeCoverage() && !coverageArc4.Equals(mount5.coverageArc))
								{
									mount5.coverageArc = coverageArc4;
								}
								mount5.SetParentPlatform(activeUnit);
								ScenarioArrayUtil.AddMount(ref activeUnit.m_Mounts, mount5);
								goto IL_16EA;
							}
							throw new Exception2("Unknown mount " + Conversions.ToString(num));
						}
						catch (Exception projectError11)
						{
							ProjectData.SetProjectError(projectError11);
							throw new Exception2("Unknown mount " + Conversions.ToString(num));
						}
					}
				}
				if (Operators.CompareString(left, "ADD_SENSOR", false) != 0)
				{
					if (Operators.CompareString(left, "REMOVE_SENSOR", false) == 0)
					{
						if (objectGeoLocation.ContainsKey("SENSORID"))
						{
							string text10 = null;
							Sensor sensor = null;
							try
							{
								text10 = Conversions.ToString(objectGeoLocation["SENSORID"]);
								Sensor[] noneMCMSensors = activeUnit.GetNoneMCMSensors();
								int k = 0;
								while (k < noneMCMSensors.Length)
								{
									Sensor sensor2 = noneMCMSensors[k];
									if (Operators.CompareString(sensor2.GetGuid(), text10, false) != 0)
									{
										k++;
									}
									else
									{
										sensor = sensor2;
										if (sensor == null)
										{
											throw new Exception2("Can't find sensor " + text10);
										}
										goto IL_147E;
									}
								}
								if (sensor == null)
								{
									throw new Exception2("Can't find sensor " + text10);
								}
							}
							catch (Exception projectError12)
							{
								ProjectData.SetProjectError(projectError12);
								throw new Exception2("Can't find sensor " + text10);
							}
							IL_147E:
							try
							{
								activeUnit.RemoveSensor(sensor);
								goto IL_16EA;
							}
							catch (Exception projectError13)
							{
								ProjectData.SetProjectError(projectError13);
								throw new Exception2("Unable to remove " + sensor.Name);
							}
						}
						throw new Exception2("Sensor to remove not defined");
					}
					if (Operators.CompareString(left, "UPDATE_SENSOR_ARC", false) == 0)
					{
						if (objectGeoLocation.ContainsKey("SENSORID"))
						{
							string text11 = null;
							Sensor sensor3 = null;
							try
							{
								text11 = Conversions.ToString(objectGeoLocation["SENSORID"]);
								Sensor[] noneMCMSensors2 = activeUnit.GetNoneMCMSensors();
								int l = 0;
								while (l < noneMCMSensors2.Length)
								{
									Sensor sensor4 = noneMCMSensors2[l];
									if (Operators.CompareString(sensor4.GetGuid(), text11, false) != 0)
									{
										l++;
									}
									else
									{
										sensor3 = sensor4;
										if (sensor3 == null)
										{
											throw new Exception2("Can't find sensor " + text11);
										}
										goto IL_158C;
									}
								}
								if (sensor3 == null)
								{
									throw new Exception2("Can't find sensor " + text11);
								}
							}
							catch (Exception projectError14)
							{
								ProjectData.SetProjectError(projectError14);
								throw new Exception2("Can't find sensor " + text11);
							}
							IL_158C:
							try
							{
								if (coverageArc.HasSomeCoverage() && !coverageArc.Equals(sensor3.coverageArc))
								{
									sensor3.coverageArc = coverageArc;
								}
								if (coverageArcMax.HasSomeCoverage() && !coverageArcMax.Equals(sensor3.coverageArcMax))
								{
									sensor3.coverageArcMax = coverageArcMax;
								}
								goto IL_16EA;
							}
							catch (Exception projectError15)
							{
								ProjectData.SetProjectError(projectError15);
								throw new Exception2("Unable to update " + sensor3.Name);
							}
						}
						throw new Exception2("Sensor to update not defined");
					}
				}
				else
				{
					try
					{
						int dBID = num;
						SQLiteConnection sQLiteConnection = activeUnit.m_Scenario.GetSQLiteConnection();
						Sensor sensor5 = DBFunctions.LoadSensorData(dBID, ref sQLiteConnection);
						if (sensor5 == null)
						{
							throw new Exception2("Unknown sensor " + Conversions.ToString(num));
						}
						if (coverageArc.HasSomeCoverage() && !coverageArc.Equals(sensor5.coverageArc))
						{
							sensor5.coverageArc = coverageArc;
						}
						if (coverageArcMax.HasSomeCoverage() && !coverageArcMax.Equals(sensor5.coverageArcMax))
						{
							sensor5.coverageArcMax = coverageArcMax;
						}
						sensor5.SetParentPlatform(activeUnit);
						activeUnit.AddSensor(sensor5);
					}
					catch (Exception projectError16)
					{
						ProjectData.SetProjectError(projectError16);
						throw new Exception2("Unknown sensor " + Conversions.ToString(num));
					}
				}
				IL_16EA:
				LuaUtility.smethod_3(objectGeoLocation, luaTable_0);
				return PrivateMethods.smethod_29(luaTable_0, scenario_0);
			}
		}

		// Token: 0x060067BC RID: 26556 RVA: 0x00367D1C File Offset: 0x00365F1C
		public static LuaWrapper_ActiveUnit_SE smethod_27(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			LuaUtility.smethod_4(ref objectGeoLocation);
			if (objectGeoLocation.ContainsKey("GUID"))
			{
				string text = "";
				try
				{
					text = Conversions.ToString(objectGeoLocation["GUID"]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.GetActiveUnits()[text];
					goto IL_1D7;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					throw new Exception2("Can't find guid " + text);
				}
			}
			if (objectGeoLocation.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class304 @class = new PrivateMethods.Class304();
				try
				{
					@class.string_0 = Conversions.ToString(objectGeoLocation["UNITNAME"]);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					throw new Exception2("name must be a string");
				}
				if (objectGeoLocation.ContainsKey("SIDE"))
				{
					string text2;
					try
					{
						text2 = Conversions.ToString(objectGeoLocation["SIDE"]);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						throw new Exception2("side must be a string");
					}
					Side side;
					try
					{
						side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						throw new Exception2("Can't find Side '" + text2 + "'");
					}
					try
					{
						activeUnit = side.ActiveUnitArray.First(new Func<ActiveUnit, bool>(@class.method_0));
						goto IL_1D7;
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						throw new Exception2(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text2,
							"'"
						}));
					}
				}
				try
				{
					activeUnit = scenario_0.GetActiveUnitList().First(new Func<ActiveUnit, bool>(@class.method_1));
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					throw new Exception2("Can't find Unit '" + @class.string_0 + "'");
				}
			}
			IL_1D7:
			if (activeUnit == null)
			{
				throw new Exception2("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			return new LuaWrapper_ActiveUnit_SE(activeUnit, scenario_0);
		}

		// Token: 0x060067BD RID: 26557 RVA: 0x00367F78 File Offset: 0x00366178
		public static LuaWrapper_Contact smethod_28(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			Contact contact = null;
			Side side = null;
			string text = null;
			LuaUtility.smethod_4(ref objectGeoLocation);
			if (objectGeoLocation.ContainsKey("GUID"))
			{
				try
				{
					text = Conversions.ToString(objectGeoLocation["GUID"]);
					goto IL_8A;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("guid must be a string");
				}
			}
			if (objectGeoLocation.ContainsKey("UNITNAME"))
			{
				try
				{
					text = Conversions.ToString(objectGeoLocation["UNITNAME"]);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					throw new Exception2("name must be a string");
				}
			}
			IL_8A:
			if (objectGeoLocation.ContainsKey("SIDE"))
			{
				string str;
				try
				{
					str = Conversions.ToString(objectGeoLocation["SIDE"]);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					throw new Exception2("side must be a string");
				}
				try
				{
					side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					throw new Exception2("Can't find Side '" + str + "'");
				}
			}
			foreach (Contact current in side.GetContactList())
			{
				if (Operators.CompareString(current.GetGuid().ToLower(), text.ToLower(), false) == 0 || Operators.CompareString(current.Name.ToLower(), text.ToLower(), false) == 0)
				{
					contact = current;
					break;
				}
			}
			if (contact == null)
			{
				throw new Exception2("Need to define a Side and Guid to identify a contact.");
			}
			return new LuaWrapper_Contact(contact, scenario_0, side);
		}

		// Token: 0x060067BE RID: 26558 RVA: 0x00368148 File Offset: 0x00366348
		public static LuaWrapper_ActiveUnit_SE smethod_29(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			Side side = null;
			string text = null;
			LuaUtility.smethod_4(ref objectGeoLocation);
			if (objectGeoLocation.ContainsKey("GUID"))
			{
				string key;
				try
				{
					key = Conversions.ToString(objectGeoLocation["GUID"]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.GetActiveUnits()[key];
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					LuaWrapper_ActiveUnit_SE luaWrapper_ActiveUnit_SE = null;
					ProjectData.ClearProjectError();
					LuaWrapper_ActiveUnit_SE result = luaWrapper_ActiveUnit_SE;
					return result;
				}
				if (activeUnit == null)
				{
					LuaWrapper_ActiveUnit_SE luaWrapper_ActiveUnit_SE = null;
					LuaWrapper_ActiveUnit_SE result = luaWrapper_ActiveUnit_SE;
					return result;
				}
				objectGeoLocation["SIDE"] = activeUnit.GetSide(false).GetSideName();
				objectGeoLocation["UNITNAME"] = activeUnit.Name;
			}
			else if (objectGeoLocation.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class305 @class = new PrivateMethods.Class305(null);
				try
				{
					@class.string_0 = Conversions.ToString(objectGeoLocation["UNITNAME"]);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					throw new Exception2("name must be a string");
				}
				if (objectGeoLocation.ContainsKey("SIDE"))
				{
					string text2;
					try
					{
						text2 = Conversions.ToString(objectGeoLocation["SIDE"]);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						throw new Exception2("side must be a string");
					}
					try
					{
						side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						throw new Exception2("Can't find Side '" + text2 + "'");
					}
					try
					{
						activeUnit = side.ActiveUnitArray.FirstOrDefault(new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						throw new Exception2(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text2,
							"'"
						}));
					}
					objectGeoLocation["GUID"] = activeUnit.GetGuid();
				}
				else
				{
					try
					{
						activeUnit = scenario_0.GetActiveUnitList().FirstOrDefault(new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						throw new Exception2("Can't find Unit '" + @class.string_0 + "'");
					}
					objectGeoLocation["GUID"] = activeUnit.GetGuid();
					objectGeoLocation["SIDE"] = activeUnit.GetSide(false).GetSideName();
				}
			}
			if (activeUnit == null)
			{
				throw new Exception2("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			if (side == null)
			{
				side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
			}
			objectGeoLocation["TYPE"] = activeUnit.GetUnitType().ToString();
			if (objectGeoLocation.ContainsKey("NEWNAME"))
			{
				string text3 = Conversions.ToString(objectGeoLocation["NEWNAME"]);
				if (Operators.CompareString(activeUnit.Name, text3, false) != 0)
				{
					activeUnit.Name = text3;
				}
			}
			if (objectGeoLocation.ContainsKey("GROUP"))
			{
				Group group = LuaUtility.smethod_24(objectGeoLocation, side, scenario_0);
				if (group != activeUnit.GetParentGroup(false))
				{
					activeUnit.SetParentGroup(false, group);
				}
			}
			else if (activeUnit.GetParentGroup(false) != null)
			{
				objectGeoLocation["GROUP"] = activeUnit.GetParentGroup(false).Name;
			}
			if (objectGeoLocation.ContainsKey("MISSION"))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(objectGeoLocation["MISSION"]);
				if (!(objectValue is string))
				{
					goto IL_3C0;
				}
				try
				{
					PrivateMethods.smethod_8(activeUnit.GetGuid(), Conversions.ToString(objectValue), scenario_0, null, false, false);
					goto IL_3C0;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					throw new Exception2(ex2.GetType().Name + " " + ex2.Message);
				}
			}
			if (activeUnit.GetAssignedMission(false) != null)
			{
				objectGeoLocation["MISSION"] = activeUnit.GetAssignedMission(false).Name;
			}
			IL_3C0:
			if (objectGeoLocation.ContainsKey("COURSE"))
			{
				LuaTable luaTable = (LuaTable)objectGeoLocation["COURSE"];
				activeUnit.GetNavigator().ClearPlottedCourse();
				List<object> list = LuaUtility.smethod_0(luaTable.GetEnumerator());
				using (List<object>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
						if (!(objectValue2 is LuaTable))
						{
							throw new Exception2("Error at " + LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(objectValue2)) + " in ScenEdit_SetUnit.");
						}
						Dictionary<string, object> objectGeoLocation2 = LuaUtility.GetObjectGeoLocation(((LuaTable)objectValue2).GetEnumerator());
						double? num = LuaUtility.smethod_12(objectGeoLocation2);
						double? num2 = LuaUtility.smethod_10(objectGeoLocation2);
						if (!num.HasValue | !num.HasValue)
						{
							throw new Exception2("Course object " + LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(objectValue2)) + " needs latitude or longitude.");
						}
						double? num3 = num;
						bool? flag = num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0.0) : null;
						num3 = num;
						bool? flag2 = num3.HasValue ? new bool?(num3.GetValueOrDefault() == 0.0) : null;
						if (((!flag.HasValue || !flag.GetValueOrDefault()) ? (flag2.HasValue ? (flag | flag2.GetValueOrDefault()) : null) : new bool?(true)).GetValueOrDefault())
						{
							throw new Exception2("Course object " + LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(objectValue2)) + " Latitude or Longitude cannot be 0.");
						}
						activeUnit.GetNavigator().AddWaypoint(num2.Value, num.Value, Waypoint.WaypointType.ManualPlottedCourseWaypoint, Waypoint._Creator.const_1, Waypoint._Category.const_0);
					}
				}
			}
			if (objectGeoLocation.ContainsKey("SPEED") & objectGeoLocation.ContainsKey("THROTTLE"))
			{
				throw new Exception2("Use either SPEED or THROTTLE.");
			}
			if (objectGeoLocation.ContainsKey("SPEED"))
			{
				float num4 = Conversions.ToSingle(objectGeoLocation["SPEED"]);
				if (num4 > activeUnit.float_11)
				{
					num4 = activeUnit.float_11;
				}
				else if (num4 < 0f)
				{
					num4 = 0f;
				}
				activeUnit.SetCurrentSpeed(num4);
			}
			else
			{
				objectGeoLocation["SPEED"] = activeUnit.GetCurrentSpeed();
			}
			if (objectGeoLocation.ContainsKey("THROTTLE"))
			{
				ActiveUnit.Throttle throttle = LuaUtility.smethod_21(objectGeoLocation);
				if (throttle > activeUnit.GetMaxThrottleAvailable())
				{
					throttle = activeUnit.GetMaxThrottleAvailable();
				}
				else if (throttle < activeUnit.GetMinThrottleAvailable())
				{
					throttle = activeUnit.GetMinThrottleAvailable();
				}
				activeUnit.SetThrottle(throttle, null);
			}
			else
			{
				objectGeoLocation["THROTTLE"] = activeUnit.GetThrottle();
			}
			if (objectGeoLocation.ContainsKey("RTB") && LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["RTB"])).GetValueOrDefault())
			{
				if (activeUnit.IsAircraft)
				{
					((Aircraft)activeUnit).GetAircraftAirOps().vmethod_6(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
				}
				else
				{
					activeUnit.GetDockingOps().method_7(false, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, true, true);
				}
			}
			if (objectGeoLocation.ContainsKey("REFUEL") && LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["REFUEL"])).GetValueOrDefault() && !Information.IsNothing(activeUnit) && activeUnit.IsActiveUnit() && (activeUnit.GetSide(false) == side || activeUnit.GetSide(false).IsFriendlyToSide(side)) && activeUnit.GetType() != typeof(Weapon))
			{
				ActiveUnit theU = activeUnit;
				Scenario scenarioContext = scenario_0;
				ActiveUnit activeUnit2 = null;
				List<Mission> list2 = null;
				PrivateMethods.smethod_49(theU, scenarioContext, ref text, ref activeUnit2, ref list2);
			}
			objectGeoLocation["DBID"] = activeUnit.DBID;
			bool? booleanValue = new bool?(false);
			if (objectGeoLocation.ContainsKey("MOVETO"))
			{
				booleanValue = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["MOVETO"]));
			}
			GlobalVariables.ActiveUnitType unitType = activeUnit.GetUnitType();
			if (unitType != GlobalVariables.ActiveUnitType.Aircraft)
			{
				if (unitType == GlobalVariables.ActiveUnitType.Submarine)
				{
					float? num5 = LuaUtility.smethod_20(objectGeoLocation);
					if (num5.HasValue)
					{
						float num6 = (float)((int)Math.Round((double)num5.Value));
						if (num6 > 0f & num6 <= 6f)
						{
							float num7 = num6;
							float num8 = 0f;
							if (num7 == 6f)
							{
								num8 = 0f;
							}
							else if (num7 == 1f)
							{
								num8 = -20f;
							}
							else if (num7 == 2f)
							{
								num8 = -40f;
							}
							else if (num7 == 3f)
							{
								num8 = Submarine_AI.GetJustOverLayerDepth(activeUnit);
							}
							else if (num7 == 4f)
							{
								num8 = Submarine_AI.GetJustUnderLayerDepth(activeUnit);
							}
							else if (num7 == 5f)
							{
								num8 = activeUnit.GetKinematics().GetMinAltitude();
							}
							num6 = num8;
						}
						if (num6 < activeUnit.GetKinematics().GetMinAltitude())
						{
							num6 = activeUnit.GetKinematics().GetMinAltitude();
						}
						if (num6 > 0f)
						{
							num6 = 0f;
						}
						if (booleanValue.GetValueOrDefault())
						{
							activeUnit.SetDesiredAltitude((float)((short)Math.Round((double)num6)));
						}
						else
						{
							activeUnit.SetAltitude_ASL(true, (float)((short)Math.Round((double)num6)));
						}
					}
					else
					{
						objectGeoLocation["DEPTH"] = activeUnit.GetCurrentAltitude_ASL(true);
					}
				}
			}
			else
			{
				objectGeoLocation["LOADOUTID"] = ((Aircraft)activeUnit).GetLoadoutDBID();
				objectGeoLocation["LOADOUTNAME"] = ((Aircraft)activeUnit).GetLoadoutName();
				float? num9 = LuaUtility.smethod_18(objectGeoLocation);
				if (num9.HasValue)
				{
					float num10 = (float)((int)Math.Round((double)num9.Value));
					if (num10 > 0f & num10 <= 7f)
					{
						((Aircraft)activeUnit).GetAircraftAI();
						float num11 = num10;
						float num12 = 0f;
						if (num11 == 1f)
						{
							num12 = activeUnit.GetKinematics().GetMinAltitude();
						}
						else if (num11 == 2f)
						{
							num12 = 304.8f;
						}
						else if (num11 == 3f)
						{
							num12 = 609.6f;
						}
						else if (num11 == 4f)
						{
							num12 = 3657.6f;
						}
						else if (num11 == 5f)
						{
							num12 = 7620f;
						}
						else if (num11 == 6f)
						{
							num12 = 10972.8f;
						}
						else if (num11 == 7f)
						{
							num12 = activeUnit.GetKinematics().GetMaxAltitude();
						}
						num10 = num12;
					}
					if (num10 < activeUnit.GetKinematics().GetMinAltitude())
					{
						num10 = activeUnit.GetKinematics().GetMinAltitude();
					}
					if (num10 > activeUnit.GetKinematics().GetMaxAltitude())
					{
						num10 = activeUnit.GetKinematics().GetMaxAltitude();
					}
					if (booleanValue.GetValueOrDefault())
					{
						activeUnit.SetDesiredAltitude((float)((short)Math.Round((double)num10)));
					}
					else
					{
						activeUnit.SetAltitude_ASL(true, (float)((short)Math.Round((double)num10)));
					}
				}
				else
				{
					objectGeoLocation["ALTITUDE"] = activeUnit.GetCurrentAltitude_ASL(true);
				}
			}
			if (objectGeoLocation.ContainsKey("HEADING"))
			{
				float currentHeading = Conversions.ToSingle(objectGeoLocation["HEADING"]);
				activeUnit.SetCurrentHeading(currentHeading);
			}
			else
			{
				objectGeoLocation["HEADING"] = activeUnit.GetCurrentHeading();
			}
			double? num13 = LuaUtility.smethod_10(objectGeoLocation);
			if (num13.HasValue)
			{
				activeUnit.SetLatitude(null, num13.Value);
			}
			else
			{
				objectGeoLocation["LONGITUDE"] = activeUnit.GetLongitude(null);
			}
			double? num14 = LuaUtility.smethod_12(objectGeoLocation);
			if (num14.HasValue)
			{
				activeUnit.SetLongitude(null, num14.Value);
			}
			else
			{
				objectGeoLocation["LONGITUDE"] = activeUnit.GetLongitude(null);
			}
			checked
			{
				if (objectGeoLocation.ContainsKey("AUTODETECTABLE"))
				{
					bool? booleanValue2 = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["AUTODETECTABLE"]));
					if (booleanValue2.HasValue)
					{
						if (booleanValue2.Value)
						{
							if (!activeUnit.IsAutoDetectable(null))
							{
								activeUnit.SetIsAutoDetectable(null, true);
								Contact contact = null;
								Side[] sides = scenario_0.GetSides();
								for (int i = 0; i < sides.Length; i++)
								{
									Side theDetectingSide = sides[i];
									ActiveUnit_Sensory.NewContactDetected(ref contact, ref scenario_0, theDetectingSide, activeUnit, null, Contact_Base.IdentificationStatus.KnownDomain, null);
								}
							}
						}
						else
						{
							activeUnit.SetIsAutoDetectable(null, false);
						}
					}
				}
				if (scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.CommsDisruption) && objectGeoLocation.ContainsKey("OUTOFCOMMS"))
				{
					bool? booleanValue3 = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["OUTOFCOMMS"]));
					if (booleanValue3.HasValue)
					{
						if (!booleanValue3.Value)
						{
							activeUnit.GetCommStuff().SetIsNotOutOfComms(ActiveUnit_CommStuff._OOCReason.const_0, true);
						}
						else
						{
							activeUnit.GetCommStuff().SetIsNotOutOfComms(ActiveUnit_CommStuff._OOCReason.NetworkAttackOrActOfGod, false);
						}
					}
				}
				if (objectGeoLocation.ContainsKey("HOLDPOSITION"))
				{
					bool? booleanValue4 = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["HOLDPOSITION"]));
					if (booleanValue4.HasValue)
					{
						activeUnit.GetAI().HoldPosition = booleanValue4.Value;
					}
				}
				if (objectGeoLocation.ContainsKey("HOLDFIRE"))
				{
					bool? booleanValue5 = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["HOLDFIRE"]));
					if (booleanValue5.HasValue)
					{
						if (booleanValue5.GetValueOrDefault())
						{
							activeUnit.m_Doctrine.method_63(scenario_0, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold));
							activeUnit.m_Doctrine.SetWCS_SurfaceDoctrine(scenario_0, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold));
							activeUnit.m_Doctrine.SetWCS_SubmarineDoctrine(scenario_0, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold));
							activeUnit.m_Doctrine.SetWCS_LandDoctrine(scenario_0, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Hold));
						}
						else
						{
							activeUnit.m_Doctrine.method_63(scenario_0, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
							activeUnit.m_Doctrine.SetWCS_SurfaceDoctrine(scenario_0, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
							activeUnit.m_Doctrine.SetWCS_SubmarineDoctrine(scenario_0, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
							activeUnit.m_Doctrine.SetWCS_LandDoctrine(scenario_0, false, new bool?(false), false, false, new Doctrine._WeaponControlStatus?(Doctrine._WeaponControlStatus.Tight));
						}
					}
				}
				if (objectGeoLocation.ContainsKey("PROFICIENCY"))
				{
					string text4 = Conversions.ToString(objectGeoLocation["PROFICIENCY"]);
					GlobalVariables.ProficiencyLevel value;
					if (Enum.TryParse<GlobalVariables.ProficiencyLevel>(text4, out value))
					{
						activeUnit.SetProficiencyLevel(new GlobalVariables.ProficiencyLevel?(value));
					}
					else
					{
						text4 = text4.ToUpper();
						if (Operators.CompareString(text4, "NOVICE", false) != 0)
						{
							if (Operators.CompareString(text4, "CADET", false) != 0)
							{
								if (Operators.CompareString(text4, "REGULAR", false) != 0)
								{
									if (Operators.CompareString(text4, "VETERAN", false) != 0)
									{
										if (Operators.CompareString(text4, "ACE", false) != 0)
										{
											throw new Exception2("Unable to understand '" + text4 + "' as a Proficiency Level");
										}
										activeUnit.SetProficiencyLevel(new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Ace));
									}
									else
									{
										activeUnit.SetProficiencyLevel(new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Veteran));
									}
								}
								else
								{
									activeUnit.SetProficiencyLevel(new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Regular));
								}
							}
							else
							{
								activeUnit.SetProficiencyLevel(new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Cadet));
							}
						}
						else
						{
							activeUnit.SetProficiencyLevel(new GlobalVariables.ProficiencyLevel?(GlobalVariables.ProficiencyLevel.Novice));
						}
					}
				}
				if (objectGeoLocation.ContainsKey("MANUALSPEED"))
				{
					string left = Conversions.ToString(objectGeoLocation["MANUALSPEED"]).ToUpper();
					if (Operators.CompareString(left, "CURRENT", false) == 0)
					{
						float value2 = activeUnit.GetCurrentSpeed();
						activeUnit.GetKinematics().SetDesiredSpeedOverride(new float?(value2));
					}
					else if (Operators.CompareString(left, "DESIRED", false) == 0)
					{
						float value2 = activeUnit.GetDesiredSpeed();
						activeUnit.GetKinematics().SetDesiredSpeedOverride(new float?(value2));
					}
					else
					{
						float? desiredSpeedOverride = new float?(float.Parse(Conversions.ToString(objectGeoLocation["MANUALSPEED"])));
						if (desiredSpeedOverride.HasValue)
						{
							activeUnit.GetKinematics().SetDesiredSpeedOverride(desiredSpeedOverride);
						}
					}
				}
				if (objectGeoLocation.ContainsKey("MANUALALTITUDE"))
				{
					bool? booleanValue6 = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["MANUALALTITUDE"]));
					if (booleanValue6.HasValue)
					{
						activeUnit.GetKinematics().SetDesiredAltitudeOverride(booleanValue6.Value);
					}
				}
				if (objectGeoLocation.ContainsKey("FUEL"))
				{
					List<object> list3 = LuaUtility.smethod_0(((LuaTable)objectGeoLocation["FUEL"]).GetEnumerator());
					try
					{
						using (List<object>.Enumerator enumerator2 = list3.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
								if (objectValue3 is LuaTable)
								{
									Dictionary<string, object> objectGeoLocation3 = LuaUtility.GetObjectGeoLocation(((LuaTable)objectValue3).GetEnumerator());
									if (!(objectGeoLocation3.ContainsKey("1") & objectGeoLocation3.ContainsKey("2")))
									{
										throw new Exception2("Error at " + LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(objectValue3)) + " in ScenEdit_SetUnit.");
									}
									string value3 = Conversions.ToString(objectGeoLocation3["1"]);
									int val = 2147483647;
									if (!int.TryParse(Conversions.ToString(objectGeoLocation3["2"]), out val))
									{
										throw new Exception2("Error in amount at " + LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(objectValue3)) + " in ScenEdit_SetUnit.");
									}
									PrivateMethods.Class306 class2 = new PrivateMethods.Class306(null);
									if (!(Enum.TryParse<FuelRec._FuelType>(value3, out class2._FuelType_0) & Enum.IsDefined(typeof(FuelRec._FuelType), class2._FuelType_0)))
									{
										throw new Exception2("Error in fuel type at " + LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(objectValue3)) + " in ScenEdit_SetUnit.");
									}
									FuelRec fuelRec = activeUnit.GetFuelRecs().FirstOrDefault(new Func<FuelRec, bool>(class2.method_0));
									if (fuelRec == null)
									{
										throw new Exception2("Missing fuel type at " + LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(objectValue3)) + " in ScenEdit_SetUnit.");
									}
									int num15 = Math.Min(fuelRec.MaxQuantity, val);
									num15 = Math.Max(0, num15);
									fuelRec.CurrentQuantity = (float)num15;
								}
							}
						}
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						throw;
					}
				}
				LuaUtility.smethod_3(objectGeoLocation, luaTable_0);
				LuaWrapper_ActiveUnit_SE luaWrapper_ActiveUnit_SE = new LuaWrapper_ActiveUnit_SE(activeUnit, scenario_0);
				LuaWrapper_ActiveUnit_SE result = luaWrapper_ActiveUnit_SE;
				return result;
			}
		}

		// Token: 0x060067BF RID: 26559 RVA: 0x00369518 File Offset: 0x00367718
		public static bool smethod_30(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			LuaUtility.smethod_4(ref objectGeoLocation);
			if (objectGeoLocation.ContainsKey("GUID"))
			{
				string text = "";
				try
				{
					text = Conversions.ToString(objectGeoLocation["GUID"]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.GetActiveUnits()[text];
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					throw new Exception2("Can't find guid " + text);
				}
				objectGeoLocation["SIDE"] = activeUnit.GetSide(false).GetSideName();
				objectGeoLocation["UNITNAME"] = activeUnit.Name;
			}
			else if (objectGeoLocation.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class307 @class = new PrivateMethods.Class307();
				try
				{
					@class.string_0 = Conversions.ToString(objectGeoLocation["UNITNAME"]);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					throw new Exception2("name must be a string");
				}
				if (objectGeoLocation.ContainsKey("SIDE"))
				{
					string text2;
					try
					{
						text2 = Conversions.ToString(objectGeoLocation["SIDE"]);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						throw new Exception2("side must be a string");
					}
					Side side;
					try
					{
						side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						throw new Exception2("Can't find Side '" + text2 + "'");
					}
					try
					{
						activeUnit = side.ActiveUnitArray.First(new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						throw new Exception2(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text2,
							"'"
						}));
					}
					objectGeoLocation["GUID"] = activeUnit.GetGuid();
				}
				else
				{
					try
					{
						activeUnit = scenario_0.GetActiveUnitList().First(new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						throw new Exception2("Can't find Unit '" + @class.string_0 + "'");
					}
					objectGeoLocation["GUID"] = activeUnit.GetGuid();
					objectGeoLocation["SIDE"] = activeUnit.GetSide(false).GetSideName();
				}
			}
			if (activeUnit == null)
			{
				throw new Exception2("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			if (scenario_0.ExecutionInProgress)
			{
				scenario_0.DeleteUnit(activeUnit);
			}
			else
			{
				GameGeneral.RemoveUnit(ref scenario_0, activeUnit.GetGuid());
			}
			return true;
		}

		// Token: 0x060067C0 RID: 26560 RVA: 0x003697F0 File Offset: 0x003679F0
		public static bool smethod_31(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			LuaUtility.smethod_4(ref objectGeoLocation);
			if (objectGeoLocation.ContainsKey("GUID"))
			{
				string text = "";
				try
				{
					text = Conversions.ToString(objectGeoLocation["GUID"]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.GetActiveUnits()[text];
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					throw new Exception2("Can't find guid " + text);
				}
				objectGeoLocation["SIDE"] = activeUnit.GetSide(false).GetSideName();
				objectGeoLocation["UNITNAME"] = activeUnit.Name;
			}
			else if (objectGeoLocation.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class308 @class = new PrivateMethods.Class308();
				try
				{
					@class.string_0 = Conversions.ToString(objectGeoLocation["UNITNAME"]);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					throw new Exception2("name must be a string");
				}
				if (objectGeoLocation.ContainsKey("SIDE"))
				{
					string text2;
					try
					{
						text2 = Conversions.ToString(objectGeoLocation["SIDE"]);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						throw new Exception2("side must be a string");
					}
					Side side;
					try
					{
						side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						throw new Exception2("Can't find Side '" + text2 + "'");
					}
					try
					{
						activeUnit = side.ActiveUnitArray.First(new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						throw new Exception2(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text2,
							"'"
						}));
					}
					objectGeoLocation["GUID"] = activeUnit.GetGuid();
				}
				else
				{
					try
					{
						activeUnit = scenario_0.GetActiveUnitList().First(new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						throw new Exception2("Can't find Unit '" + @class.string_0 + "'");
					}
					objectGeoLocation["GUID"] = activeUnit.GetGuid();
					objectGeoLocation["SIDE"] = activeUnit.GetSide(false).GetSideName();
				}
			}
			if (activeUnit == null)
			{
				throw new Exception2("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			scenario_0.RemoveUnit(activeUnit);
			return true;
		}

		// Token: 0x060067C1 RID: 26561 RVA: 0x00369AB0 File Offset: 0x00367CB0
		public static bool smethod_32(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			LuaUtility.smethod_4(ref objectGeoLocation);
			if (objectGeoLocation.ContainsKey("GUID"))
			{
				string text = "";
				try
				{
					text = Conversions.ToString(objectGeoLocation["GUID"]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.GetActiveUnits()[text];
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					throw new Exception2("Can't find guid " + text);
				}
				objectGeoLocation["SIDE"] = activeUnit.GetSide(false).GetSideName();
				objectGeoLocation["UNITNAME"] = activeUnit.Name;
			}
			else if (objectGeoLocation.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class309 @class = new PrivateMethods.Class309(null);
				try
				{
					@class.string_0 = Conversions.ToString(objectGeoLocation["UNITNAME"]);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					throw new Exception2("name must be a string");
				}
				if (objectGeoLocation.ContainsKey("SIDE"))
				{
					string text2;
					try
					{
						text2 = Conversions.ToString(objectGeoLocation["SIDE"]);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						throw new Exception2("side must be a string");
					}
					Side side;
					try
					{
						side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						throw new Exception2("Can't find Side '" + text2 + "'");
					}
					try
					{
						activeUnit = side.ActiveUnitArray.First(new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						throw new Exception2(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text2,
							"'"
						}));
					}
					objectGeoLocation["GUID"] = activeUnit.GetGuid();
				}
				else
				{
					try
					{
						activeUnit = scenario_0.GetActiveUnitList().First(new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						throw new Exception2("Can't find Unit '" + @class.string_0 + "'");
					}
					objectGeoLocation["GUID"] = activeUnit.GetGuid();
					objectGeoLocation["SIDE"] = activeUnit.GetSide(false).GetSideName();
				}
			}
			if (activeUnit == null)
			{
				throw new Exception2("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			Side side2 = null;
			checked
			{
				try
				{
					Side[] sides = scenario_0.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side3 = sides[i];
						if (Operators.CompareString(side3.GetSideName().ToUpper(), objectGeoLocation["NEWSIDE"].ToString().ToUpper(), false) == 0)
						{
							side2 = side3;
							break;
						}
					}
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					throw new Exception2("Invalid new-side name!");
				}
				bool result;
				if (!Information.IsNothing(side2))
				{
					foreach (Contact current in side2.GetContactList())
					{
						if (!Information.IsNothing(current.ActualUnit) && Operators.CompareString(current.ActualUnit.GetGuid(), activeUnit.GetGuid(), false) == 0)
						{
							side2.Lazy3DictionaryTryAdd(current, ref scenario_0, false);
							break;
						}
					}
					foreach (Contact current2 in side2.GetBaseContacts())
					{
						if (!Information.IsNothing(current2.ActualUnit) && Operators.CompareString(current2.ActualUnit.GetGuid(), activeUnit.GetGuid(), false) == 0)
						{
							side2.Lazy4DictionaryTryAdd(current2, ref scenario_0, false);
							break;
						}
					}
					activeUnit.SetSide(false, side2);
					result = true;
				}
				else
				{
					result = false;
				}
				return result;
			}
		}

		// Token: 0x060067C2 RID: 26562 RVA: 0x00369F04 File Offset: 0x00368104
		public static int smethod_33(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			Side side = null;
			LuaUtility.smethod_4(ref objectGeoLocation);
			int result;
			if (objectGeoLocation.ContainsKey("GUID"))
			{
				string key = "";
				try
				{
					key = Conversions.ToString(objectGeoLocation["GUID"]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.GetActiveUnits()[key];
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					result = 0;
					return result;
				}
				if (activeUnit == null)
				{
					result = 0;
					return result;
				}
				objectGeoLocation["SIDE"] = activeUnit.GetSide(false).GetSideName();
				objectGeoLocation["UNITNAME"] = activeUnit.Name;
			}
			else if (objectGeoLocation.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class310 @class = new PrivateMethods.Class310(null);
				try
				{
					@class.string_0 = Conversions.ToString(objectGeoLocation["UNITNAME"]);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					throw new Exception2("name must be a string");
				}
				if (objectGeoLocation.ContainsKey("SIDE"))
				{
					string text;
					try
					{
						text = Conversions.ToString(objectGeoLocation["SIDE"]);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						throw new Exception2("side must be a string");
					}
					try
					{
						side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						throw new Exception2("Can't find Side '" + text + "'");
					}
					try
					{
						activeUnit = side.ActiveUnitArray.FirstOrDefault(new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						throw new Exception2(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text,
							"'"
						}));
					}
					objectGeoLocation["GUID"] = activeUnit.GetGuid();
				}
				else
				{
					try
					{
						activeUnit = scenario_0.GetActiveUnitList().FirstOrDefault(new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						throw new Exception2("Can't find Unit '" + @class.string_0 + "'");
					}
					objectGeoLocation["GUID"] = activeUnit.GetGuid();
					objectGeoLocation["SIDE"] = activeUnit.GetSide(false).GetSideName();
				}
			}
			if (activeUnit == null)
			{
				throw new Exception2("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			if (side == null)
			{
				side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
			}
			Mount mount = null;
			int num = 0;
			int num2 = 0;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			int num3 = 0;
			checked
			{
				if (objectGeoLocation.ContainsKey("MOUNT_GUID"))
				{
					if (activeUnit.m_Mounts.Length == 0)
					{
						throw new Exception2("No mount present in unit.");
					}
					Mount[] mounts = activeUnit.m_Mounts;
					for (int i = 0; i < mounts.Length; i++)
					{
						Mount mount2 = mounts[i];
						if (Operators.CompareString(mount2.GetGuid(), Conversions.ToString(objectGeoLocation["MOUNT_GUID"]), false) == 0)
						{
							mount = mount2;
						}
					}
				}
				if (mount == null & activeUnit.m_Mounts.Length == 0)
				{
					throw new Exception2("No mount present in unit.");
				}
				if (!objectGeoLocation.ContainsKey("WPN_DBID"))
				{
					throw new Exception2("No weapon defined.");
				}
				num = Conversions.ToInteger(objectGeoLocation["WPN_DBID"]);
				num2 = 0;
				flag = false;
				flag2 = true;
				flag3 = false;
				num3 = 0;
				if (objectGeoLocation.ContainsKey("NUMBER"))
				{
					num2 = Conversions.ToInteger(objectGeoLocation["NUMBER"]);
				}
				if (objectGeoLocation.ContainsKey("REMOVE"))
				{
					flag = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["REMOVE"])).Value;
				}
				if (objectGeoLocation.ContainsKey("FILLOUT"))
				{
					flag3 = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["FILLOUT"])).Value;
				}
				if (flag3)
				{
					flag2 = false;
					flag = false;
					num2 = 9999999;
				}
			}
			if (num2 > 0)
			{
				if (!Information.IsNothing(mount))
				{
					using (IEnumerator<WeaponRec> enumerator = mount.GetWeaponRecCollection().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							WeaponRec current = enumerator.Current;
							int num4 = current.Multiple;
							if (num4 < 1)
							{
								num4 = 1;
							}
							int num5 = num4 * num2;
							if (current.WeapID == num)
							{
								if (flag)
								{
									if (current.GetCurrentLoad() < num5)
									{
										if (current.GetCurrentLoad() > 0)
										{
											while (current.GetCurrentLoad() > num4 & num5 > 0)
											{
												num5 -= num4;
												num2--;
												WeaponRec weaponRec;
												(weaponRec = current).SetCurrentLoad(weaponRec.GetCurrentLoad() - num4);
												num3++;
											}
											current.SetCurrentLoad(0);
											continue;
										}
										continue;
									}
									else
									{
										WeaponRec weaponRec;
										(weaponRec = current).SetCurrentLoad(weaponRec.GetCurrentLoad() - num5);
										num3 += num2;
										num2 = 0;
									}
								}
								else if (current.GetCurrentLoad() + num5 > current.MaxLoad)
								{
									if (current.GetCurrentLoad() != current.MaxLoad)
									{
										while (current.GetCurrentLoad() < current.MaxLoad & num5 > 0)
										{
											num5 -= num4;
											num2--;
											WeaponRec weaponRec;
											(weaponRec = current).SetCurrentLoad(weaponRec.GetCurrentLoad() + num4);
											num3++;
										}
										current.SetCurrentLoad(current.MaxLoad);
										continue;
									}
									continue;
								}
								else
								{
									WeaponRec weaponRec;
									(weaponRec = current).SetCurrentLoad(weaponRec.GetCurrentLoad() + num5);
									num3 += num2;
									num2 = 0;
								}
								IL_592:
								goto IL_76B;
							}
						}
						goto IL_76B;
					}
				}
				Mount[] mounts2 = activeUnit.m_Mounts;
				for (int j = 0; j < mounts2.Length; j = checked(j + 1))
				{
					Mount mount3 = mounts2[j];
					using (IEnumerator<WeaponRec> enumerator2 = mount3.GetWeaponRecCollection().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							WeaponRec current2 = enumerator2.Current;
							int num6 = current2.Multiple;
							if (num6 < 1)
							{
								num6 = 1;
							}
							int num7 = num6 * num2;
							if (current2.WeapID == num)
							{
								if (flag)
								{
									if (current2.GetCurrentLoad() < num7)
									{
										if (current2.GetCurrentLoad() > 0)
										{
											while (current2.GetCurrentLoad() > num6 & num7 > 0)
											{
												num7 -= num6;
												num2--;
												WeaponRec weaponRec;
												(weaponRec = current2).SetCurrentLoad(weaponRec.GetCurrentLoad() - num6);
												num3++;
											}
											current2.SetCurrentLoad(0);
											continue;
										}
										continue;
									}
									else
									{
										WeaponRec weaponRec;
										(weaponRec = current2).SetCurrentLoad(weaponRec.GetCurrentLoad() - num7);
										num3 += num2;
										num2 = 0;
									}
								}
								else if (current2.GetCurrentLoad() + num7 > current2.MaxLoad)
								{
									if (current2.GetCurrentLoad() != current2.MaxLoad)
									{
										while (current2.GetCurrentLoad() < current2.MaxLoad & num7 > 0)
										{
											num7 -= num6;
											num2--;
											WeaponRec weaponRec;
											(weaponRec = current2).SetCurrentLoad(weaponRec.GetCurrentLoad() + num6);
											num3++;
										}
										current2.SetCurrentLoad(current2.MaxLoad);
										continue;
									}
									continue;
								}
								else
								{
									WeaponRec weaponRec;
									(weaponRec = current2).SetCurrentLoad(weaponRec.GetCurrentLoad() + num7);
									num3 += num2;
									num2 = 0;
								}
								IL_73E:
								if (num2 <= 0)
								{
									goto IL_76B;
								}
								goto IL_758;
							}
						}
                        if (num2 <= 0)
                        {
                            goto IL_76B;
                        }
                        goto IL_758;
                    }
					IL_758:;
				}
			}
			IL_76B:
			if ((num2 > 0 & !flag & !flag3 & flag2) && Information.IsNothing(mount))
			{
			}
			int num8 = num3;
			result = num8;
			return result;
		}

		// Token: 0x060067C3 RID: 26563 RVA: 0x0036A784 File Offset: 0x00368984
		public static int smethod_34(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			Side side = null;
			LuaUtility.smethod_4(ref objectGeoLocation);
			int result;
			if (objectGeoLocation.ContainsKey("GUID"))
			{
				string key = "";
				try
				{
					key = Conversions.ToString(objectGeoLocation["GUID"]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.GetActiveUnits()[key];
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					result = 0;
					return result;
				}
				if (activeUnit == null)
				{
					result = 0;
					return result;
				}
				objectGeoLocation["SIDE"] = activeUnit.GetSide(false).GetSideName();
				objectGeoLocation["UNITNAME"] = activeUnit.Name;
			}
			else if (objectGeoLocation.ContainsKey("UNITNAME"))
			{
				PrivateMethods.Class311 @class = new PrivateMethods.Class311(null);
				try
				{
					@class.string_0 = Conversions.ToString(objectGeoLocation["UNITNAME"]);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					throw new Exception2("name must be a string");
				}
				if (objectGeoLocation.ContainsKey("SIDE"))
				{
					string text = null;
					try
					{
						text = Conversions.ToString(objectGeoLocation["SIDE"]);
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						throw new Exception2("side must be a string");
					}
					try
					{
						side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						throw new Exception2("Can't find Side '" + text + "'");
					}
					try
					{
						activeUnit = side.ActiveUnitArray.FirstOrDefault(new Func<ActiveUnit, bool>(@class.method_0));
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						throw new Exception2(string.Concat(new string[]
						{
							"Can't find Unit '",
							@class.string_0,
							"' on Side '",
							text,
							"'"
						}));
					}
					objectGeoLocation["GUID"] = activeUnit.GetGuid();
				}
				else
				{
					try
					{
						activeUnit = scenario_0.GetActiveUnitList().FirstOrDefault(new Func<ActiveUnit, bool>(@class.method_1));
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						throw new Exception2("Can't find Unit '" + @class.string_0 + "'");
					}
					objectGeoLocation["GUID"] = activeUnit.GetGuid();
					objectGeoLocation["SIDE"] = activeUnit.GetSide(false).GetSideName();
				}
			}
			if (activeUnit == null)
			{
				throw new Exception2("Need to define a Name or Guid to identify a unit. Preferably a Guid or Side & Name.");
			}
			if (side == null)
			{
				side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
			}
			Magazine magazine = null;
			int num = 0;
			int num2 = 0;
			int int_ = 0;
			bool flag = false;
			bool bool_ = false;
			bool flag2 = false;
			int num3 = 0;
			checked
			{
				if (objectGeoLocation.ContainsKey("MAG_GUID"))
				{
					if (activeUnit.GetMagazinesForAllMounts().Count<Magazine>() == 0)
					{
						throw new Exception2("No magazine present in unit.");
					}
					Magazine[] magazinesForAllMounts = activeUnit.GetMagazinesForAllMounts();
					for (int i = 0; i < magazinesForAllMounts.Length; i++)
					{
						Magazine magazine2 = magazinesForAllMounts[i];
						if (Operators.CompareString(magazine2.GetGuid(), Conversions.ToString(objectGeoLocation["MAG_GUID"]), false) == 0)
						{
							magazine = magazine2;
						}
					}
				}
				if (magazine == null & activeUnit.GetMagazinesForAllMounts().Count<Magazine>() == 0)
				{
					throw new Exception2("No magazine present in unit.");
				}
				if (!objectGeoLocation.ContainsKey("WPN_DBID"))
				{
					throw new Exception2("No weapon defined.");
				}
				num = Conversions.ToInteger(objectGeoLocation["WPN_DBID"]);
				num2 = 0;
				int_ = 0;
				flag = false;
				bool_ = true;
				flag2 = false;
				num3 = 0;
				if (objectGeoLocation.ContainsKey("NUMBER"))
				{
					num2 = Conversions.ToInteger(objectGeoLocation["NUMBER"]);
				}
				if (objectGeoLocation.ContainsKey("MAXCAP"))
				{
					int_ = Conversions.ToInteger(objectGeoLocation["MAXCAP"]);
				}
				if (objectGeoLocation.ContainsKey("REMOVE"))
				{
					flag = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["REMOVE"])).Value;
				}
				if (objectGeoLocation.ContainsKey("NEW"))
				{
					bool_ = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["NEW"])).Value;
				}
				if (objectGeoLocation.ContainsKey("FILLOUT"))
				{
					flag2 = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation["FILLOUT"])).Value;
				}
				if (flag2)
				{
					bool_ = false;
					flag = false;
					num2 = 9999999;
				}
			}
			if (num2 > 0)
			{
				if (!Information.IsNothing(magazine))
				{
					using (IEnumerator<WeaponRec> enumerator = magazine.GetWeaponRecCollection().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							WeaponRec current = enumerator.Current;
							if (current.WeapID == num)
							{
								if (flag)
								{
									if (current.GetCurrentLoad() < num2)
									{
										if (current.GetCurrentLoad() > 0)
										{
											num2 -= current.GetCurrentLoad();
											num3 += current.GetCurrentLoad();
											current.SetCurrentLoad(0);
											continue;
										}
										continue;
									}
									else
									{
										WeaponRec weaponRec;
										(weaponRec = current).SetCurrentLoad(weaponRec.GetCurrentLoad() - num2);
										num3 += num2;
										num2 = 0;
									}
								}
								else if (current.GetCurrentLoad() + num2 > current.MaxLoad)
								{
									if (current.GetCurrentLoad() != current.MaxLoad)
									{
										num2 -= current.MaxLoad - current.GetCurrentLoad();
										num3 += current.MaxLoad - current.GetCurrentLoad();
										current.SetCurrentLoad(current.MaxLoad);
										continue;
									}
									continue;
								}
								else
								{
									WeaponRec weaponRec;
									(weaponRec = current).SetCurrentLoad(weaponRec.GetCurrentLoad() + num2);
									num3 += num2;
									num2 = 0;
								}
								IL_592:
								goto IL_81F;
							}
						}
						goto IL_81F;
					}
				}
				Magazine[] magazinesForAllMounts2 = activeUnit.GetMagazinesForAllMounts();
				for (int j = 0; j < magazinesForAllMounts2.Length; j = checked(j + 1))
				{
					Magazine magazine3 = magazinesForAllMounts2[j];
					using (IEnumerator<WeaponRec> enumerator2 = magazine3.GetWeaponRecCollection().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							WeaponRec current2 = enumerator2.Current;
							if (current2.WeapID == num)
							{
								if (flag)
								{
									if (current2.GetCurrentLoad() < num2)
									{
										if (current2.GetCurrentLoad() > 0)
										{
											num2 -= current2.GetCurrentLoad();
											num3 += current2.GetCurrentLoad();
											current2.SetCurrentLoad(0);
											continue;
										}
										continue;
									}
									else
									{
										WeaponRec weaponRec;
										(weaponRec = current2).SetCurrentLoad(weaponRec.GetCurrentLoad() - num2);
										num3 += num2;
										num2 = 0;
									}
								}
								else if (current2.GetCurrentLoad() + num2 > current2.MaxLoad)
								{
									if (current2.GetCurrentLoad() != current2.MaxLoad)
									{
										num2 -= current2.MaxLoad - current2.GetCurrentLoad();
										num3 += current2.MaxLoad - current2.GetCurrentLoad();
										current2.SetCurrentLoad(current2.MaxLoad);
										continue;
									}
									continue;
								}
								else
								{
									WeaponRec weaponRec;
									(weaponRec = current2).SetCurrentLoad(weaponRec.GetCurrentLoad() + num2);
									num3 += num2;
									num2 = 0;
								}
								IL_6DE:
								if (num2 > 0)
								{
									goto IL_6FE;
								}
								goto IL_81F;
							}
						}
                        if (num2 > 0)
                        {
                            goto IL_6FE;
                        }
                        goto IL_81F;
                    }
					IL_6FE:;
				}
			}
			IL_81F:
			int num4;
			while (num2 > 0 & !flag & !flag2)
			{
				if (Information.IsNothing(magazine))
				{
					Magazine magazine4 = null;
					int int_2 = num;
					Magazine magazine5 = null;
					magazine4 = PrivateMethods.smethod_35(ref activeUnit, int_2, ref magazine5, false, bool_, int_);
					if (magazine4 != null)
					{
						num2--;
						num3++;
						foreach (WeaponRec current3 in magazine4.GetWeaponRecCollection())
						{
							if (current3.WeapID == num)
							{
								if (current3.GetCurrentLoad() + num2 <= current3.MaxLoad)
								{
									WeaponRec weaponRec;
									(weaponRec = current3).SetCurrentLoad(weaponRec.GetCurrentLoad() + num2);
									num3 += num2;
									num2 = 0;
									break;
								}
								if (current3.GetCurrentLoad() != current3.MaxLoad)
								{
									num2 -= current3.MaxLoad - current3.GetCurrentLoad();
									num3 += current3.MaxLoad - current3.GetCurrentLoad();
									current3.SetCurrentLoad(current3.MaxLoad);
								}
							}
						}
						magazine4.method_24();
						continue;
					}
				}
				else if (PrivateMethods.smethod_35(ref activeUnit, num, ref magazine, false, bool_, int_) != null)
				{
					num2--;
					num3++;
					foreach (WeaponRec current4 in magazine.GetWeaponRecCollection())
					{
						if (current4.WeapID == num)
						{
							if (current4.GetCurrentLoad() + num2 <= current4.MaxLoad)
							{
								WeaponRec weaponRec;
								(weaponRec = current4).SetCurrentLoad(weaponRec.GetCurrentLoad() + num2);
								num3 += num2;
								num2 = 0;
								break;
							}
							if (current4.GetCurrentLoad() != current4.MaxLoad)
							{
								num2 -= current4.MaxLoad - current4.GetCurrentLoad();
								num3 += current4.MaxLoad - current4.GetCurrentLoad();
								current4.SetCurrentLoad(current4.MaxLoad);
							}
						}
					}
					magazine.method_24();
				}
				num4 = num3;
				result = num4;
				return result;
			}
			num4 = num3;
			result = num4;
			return result;
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x0036B1D4 File Offset: 0x003693D4
		public static Magazine smethod_35(ref ActiveUnit activeUnit_0, int int_0, ref Magazine magazine_0, bool bool_0, bool bool_1, int int_1)
		{
			Magazine[] array = activeUnit_0.GetMagazinesForAllMounts();
			checked
			{
				Magazine magazine3;
				Magazine result;
				if (bool_1 && activeUnit_0.GetMagazines().Length > 0)
				{
					array = activeUnit_0.GetMagazines();
					if (bool_0)
					{
						array = array.OrderByDescending(PrivateMethods.MagazineFunc).ToArray<Magazine>();
					}
					Magazine[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						Magazine magazine = array2[i];
						Magazine magazine2 = magazine;
						int num = 0;
						int num2 = 0;
						if (magazine2.method_29(ref num, ref num2) <= magazine.MagazineCapacity)
						{
							int int_2 = num;
							if (num == 0)
							{
								int_2 = magazine.MagazineCapacity;
							}
							magazine.GetWeaponRecCollection().Add(new WeaponRec(ref activeUnit_0.m_Scenario, int_0, 0, int_2, 1, 1, false, false));
							if (string.CompareOrdinal(magazine.AddToCurrentLoad(int_0), "OK") == 0)
							{
								magazine3 = magazine;
								result = magazine3;
								return result;
							}
						}
					}
				}
				magazine3 = null;
				result = magazine3;
				return result;
			}
		}

		// Token: 0x060067C5 RID: 26565 RVA: 0x0036B2BC File Offset: 0x003694BC
		public static string smethod_36(LuaTable luaTable_0, Scenario scenario_0)
		{
			LuaSandBox.Singleton().CreateTable();
			ActiveUnit activeUnit = null;
			Side side = null;
			string text = "";
			ActiveUnit activeUnit2 = null;
			List<Mission> list = null;
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			LuaUtility.smethod_4(ref objectGeoLocation);
			if (objectGeoLocation.ContainsKey("SIDE"))
			{
				side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
			}
			string text2 = LuaUtility.smethod_25(objectGeoLocation, scenario_0);
			if (text2.Length == 0)
			{
				if (objectGeoLocation.ContainsKey("GUID"))
				{
					activeUnit = PrivateMethods.smethod_45(Conversions.ToString(objectGeoLocation["GUID"]), scenario_0);
					if (side == null)
					{
						side = activeUnit.GetSide(false);
					}
					if (objectGeoLocation.ContainsKey("TANKER"))
					{
						activeUnit2 = PrivateMethods.smethod_46(Conversions.ToString(objectGeoLocation["TANKER"]), side);
					}
					if (objectGeoLocation.ContainsKey("MISSIONS"))
					{
						list = new List<Mission>();
						List<object> list2 = LuaUtility.smethod_0(((LuaTable)objectGeoLocation["MISSIONS"]).GetEnumerator());
						using (List<object>.Enumerator enumerator = list2.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Mission mission = Class273.smethod_9(Conversions.ToString(RuntimeHelpers.GetObjectValue(enumerator.Current)), side);
								if (mission != null)
								{
									list.Add(mission);
								}
							}
						}
					}
					if (!Information.IsNothing(activeUnit) && activeUnit.IsActiveUnit() && (activeUnit.GetSide(false) == side || activeUnit.GetSide(false).IsFriendlyToSide(side)) && activeUnit.GetType() != typeof(Weapon))
					{
						PrivateMethods.smethod_49(activeUnit, scenario_0, ref text, ref activeUnit2, ref list);
					}
				}
				string result;
				if (activeUnit == null)
				{
					result = null;
				}
				else
				{
					result = text;
				}
				return result;
			}
			throw new Exception2(text2);
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x0036B4A4 File Offset: 0x003696A4
		public static LuaTable smethod_37(string string_0, Scenario scenario_0)
		{
			Side side = null;
			Side[] sides = scenario_0.GetSides();
			LuaTable luaTable;
			LuaTable result;
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side2 = sides[i];
					if (Operators.CompareString(side2.GetSideName().ToUpper(), string_0.ToUpper(), false) == 0 || Operators.CompareString(side2.GetGuid().ToUpper(), string_0.ToUpper(), false) == 0)
					{
						side = side2;
						if (side == null)
						{
							luaTable = null;
						}
						else
						{
							LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
							foreach (Contact current in side.GetContactList())
							{
								LuaWrapper_Contact value = new LuaWrapper_Contact(current, scenario_0, side);
								luaTable2[unchecked(luaTable2.Keys.Count + 1)] = value;
							}
							luaTable = luaTable2;
						}
						result = luaTable;
						return result;
					}
				}
			}
			if (side == null)
			{
				luaTable = null;
			}
			else
			{
				LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
				foreach (Contact current in side.GetContactList())
				{
					LuaWrapper_Contact value = new LuaWrapper_Contact(current, scenario_0, side);
					luaTable2[luaTable2.Keys.Count + 1] = value;
				}
				luaTable = luaTable2;
			}
			result = luaTable;
			return result;
		}

		// Token: 0x060067C7 RID: 26567 RVA: 0x0036B624 File Offset: 0x00369824
		public static bool smethod_38(string string_0, string string_1, LuaTable luaTable_0, Scenario scenario_0)
		{
			ActiveUnit activeUnit = null;
			Contact contact = null;
			ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior_ = ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted;
			string left = null;
			double lat_ = 0.0;
			double lon_ = 0.0;
			List<Waypoint> list = new List<Waypoint>();
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			activeUnit = PrivateMethods.smethod_45(string_0, scenario_0);
			bool flag;
			bool result;
			if (activeUnit == null)
			{
				flag = false;
			}
			else
			{
				contact = PrivateMethods.smethod_47(string_1, scenario_0);
				if (contact == null)
				{
					if (Operators.CompareString(string_1.ToUpper(), "BOL", false) != 0)
					{
						result = false;
						return result;
					}
					string string_2 = null;
					if (objectGeoLocation.ContainsKey("LATITUDE"))
					{
						string_2 = Conversions.ToString(objectGeoLocation["LATITUDE"]);
					}
					lat_ = LuaUtility.smethod_7(string_2);
					string_2 = "";
					if (objectGeoLocation.ContainsKey("LONGITUDE"))
					{
						string_2 = Conversions.ToString(objectGeoLocation["LONGITUDE"]);
					}
					lon_ = LuaUtility.smethod_8(string_2);
					if (objectGeoLocation.ContainsKey("COURSE"))
					{
						List<object> list2 = LuaUtility.smethod_0(((LuaTable)objectGeoLocation["COURSE"]).GetEnumerator());
						using (List<object>.Enumerator enumerator = list2.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
								if (!(objectValue is LuaTable))
								{
									throw new Exception2("BOL waypoint error");
								}
								Dictionary<string, object> objectGeoLocation2 = LuaUtility.GetObjectGeoLocation(((LuaTable)objectValue).GetEnumerator());
								double? num = LuaUtility.smethod_12(objectGeoLocation2);
								double? num2 = LuaUtility.smethod_10(objectGeoLocation2);
								if (!num.HasValue | !num.HasValue)
								{
									throw new Exception2("Course object " + LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(objectValue)) + " needs latitude or longitude.");
								}
								Waypoint item = new Waypoint(num.Value, num2.Value, Waypoint.WaypointType.TurningPoint, Waypoint._Creator.const_2, Waypoint._Category.const_0);
								list.Add(item);
							}
						}
					}
					contact = new ActivationPoint_BOL(lat_, lon_);
				}
				if (objectGeoLocation.ContainsKey("MODE"))
				{
					left = Conversions.ToString(objectGeoLocation["MODE"]);
				}
				if (Operators.CompareString(left, "0", false) != 0 && Operators.CompareString(left, "AutoTargeted", false) != 0)
				{
					if (Operators.CompareString(left, "1", false) != 0 && Operators.CompareString(left, "ManualWeaponAlloc", false) != 0)
					{
						if (Operators.CompareString(left, "2", false) != 0 && Operators.CompareString(left, "ManualTargeted", false) != 0)
						{
							throw new Exception2("Invalid targeting behaviour");
						}
						targetingBehavior_ = ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted;
						activeUnit.GetAI().TargetingContact(contact, true, true, ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted);
						activeUnit.GetAI().UpdateMissionStatus(0f);
					}
					else
					{
						targetingBehavior_ = ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc;
						Weapon weapon = null;
						Mount mount = null;
						WeaponRec weaponRec = null;
						int num3 = 0;
						int num4 = 0;
						int num5 = 0;
						int? num6 = new int?(1);
						int num7 = 0;
						if (objectGeoLocation.ContainsKey("MOUNT"))
						{
							num3 = Conversions.ToInteger(objectGeoLocation["MOUNT"]);
						}
						if (objectGeoLocation.ContainsKey("WEAPON"))
						{
							num4 = Conversions.ToInteger(objectGeoLocation["WEAPON"]);
						}
						if (objectGeoLocation.ContainsKey("QTY"))
						{
							num5 = Conversions.ToInteger(objectGeoLocation["QTY"]);
						}
						if (num3 == 0 || num4 == 0 || num5 == 0)
						{
							result = false;
							return result;
						}
						bool flag2 = false;
						Mount[] mounts = activeUnit.m_Mounts;
						for (int i = 0; i < mounts.Length; i = checked(i + 1))
						{
							Mount mount2 = mounts[i];
							if (mount2.DBID == num3 & mount2.GetComponentStatus() != PlatformComponent._ComponentStatus.Destroyed)
							{
								foreach (WeaponRec current in mount2.GetWeaponRecCollection())
								{
									if (current.WeapID == num4)
									{
										if (current.GetCurrentLoad() > 0)
										{
											if (weapon == null)
											{
												weapon = current.GetWeapon(scenario_0);
												weaponRec = current;
												mount = mount2;
											}
											num7 += current.GetCurrentLoad();
											if (mount2.RPrioritySet.Contains(current.WeapID))
											{
												mount2.RPrioritySet.Remove(current.WeapID);
											}
										}
										else
										{
											activeUnit.GetWeaponry();
											if (mount2.GetMagazineForMount().GetWeaponRecCollection().Count > 0 && mount2.GetMagazineForMount().GetWeaponRecCollection().Count > 1 && !current.HasReloadPriorityOnMount(mount2) && !current.GetWeapon(activeUnit.m_Scenario).IsDecoy() && activeUnit.GetWeaponry().method_34(mount2, current.WeapID) != 0 && weapon == null && !mount2.RPrioritySet.Contains(current.WeapID))
											{
												mount2.RPrioritySet.Add(current.WeapID);
												weapon = current.GetWeapon(scenario_0);
												weaponRec = current;
												mount = mount2;
												flag2 = true;
												break;
											}
										}
									}
								}
								if (weapon != null)
								{
									break;
								}
							}
						}
						if (weapon == null || num5 == 0 || (num7 == 0 & !flag2))
						{
							result = false;
							return result;
						}
						List<WeaponSalvo> list3 = activeUnit.GetSide(false).GetWeaponSalvoListForTarget(contact).ToList<WeaponSalvo>();
						foreach (WeaponSalvo current2 in list3)
						{
							if (current2.Target == contact && num4 == current2.WeaponDBID)
							{
								List<WeaponSalvo.Shooter> list4 = current2.m_Shooters.ToList<WeaponSalvo.Shooter>();
								using (List<WeaponSalvo.Shooter>.Enumerator enumerator4 = list4.GetEnumerator())
								{
									while (enumerator4.MoveNext())
									{
										if (Operators.CompareString(enumerator4.Current.ShooterObjectID, activeUnit.GetGuid(), false) == 0)
										{
											if (current2.GetTotalQuantityAssigned() - current2.GetTotalQuantityFired() + num5 > num7)
											{
												result = true;
												return result;
											}
											break;
										}
									}
								}
							}
						}
						activeUnit.GetAI().TargetingContact(contact, true, true, targetingBehavior_);
						if (Operators.CompareString(string_1.ToUpper(), "BOL", false) != 0)
						{
							activeUnit.GetWeaponry().method_14(contact, weapon.DBID, num5, true, DateTime.MinValue);
							activeUnit.GetAI().vmethod_18(0f);
						}
						else
						{
							Side side = activeUnit.GetSide(false);
							Scenario scenario = activeUnit.m_Scenario;
							int? nullable_ = new int?(num5);
							int? nullable_2 = new int?(num5);
							string guid = activeUnit.GetGuid();
							WeaponSalvo weaponSalvo = side.WeaponSalvoAssigned(scenario, ref weapon, ref contact, nullable_, 0, nullable_2, true, ref guid, ref num6, DateTime.MinValue);
							if (list.Count > 0)
							{
								foreach (Waypoint current3 in list)
								{
									ScenarioArrayUtil.AddWaypoint(ref weaponSalvo.PlottedCourse, current3);
								}
							}
						}
						if (flag2)
						{
							mount.RPrioritySet.Remove(weaponRec.WeapID);
						}
					}
				}
				else
				{
					targetingBehavior_ = ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted;
					activeUnit.GetAI().TargetingContact(contact, false, true, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
				}
				flag = true;
			}
			result = flag;
			return result;
		}

		// Token: 0x060067C8 RID: 26568 RVA: 0x0036BDE8 File Offset: 0x00369FE8
		public static LuaWrapper_ActiveUnit smethod_39(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			ActiveUnit activeUnit = null;
			string text = null;
			string text2 = null;
			LuaUtility.smethod_4(ref objectGeoLocation);
			if (objectGeoLocation.ContainsKey("GUID"))
			{
				try
				{
					text2 = Conversions.ToString(objectGeoLocation["GUID"]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("guid must be a string");
				}
				try
				{
					activeUnit = scenario_0.GetActiveUnits()[text2];
					goto IL_149;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					throw new Exception2("Can't find guid " + text2);
				}
			}
			if (objectGeoLocation.ContainsKey("UNITNAME"))
			{
				try
				{
					text = Conversions.ToString(objectGeoLocation["UNITNAME"]);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					throw new Exception2("name must be a string");
				}
				foreach (ActiveUnit current in scenario_0.GetActiveUnitList())
				{
					if (Operators.CompareString(current.Name.ToUpper(), text.ToUpper(), false) == 0 || Operators.CompareString(current.GetGuid().ToUpper(), text.ToUpper(), false) == 0)
					{
						activeUnit = current;
						break;
					}
				}
				if (Information.IsNothing(activeUnit))
				{
					throw new Exception2("Unable to find unit matching name: " + text);
				}
			}
			IL_149:
			if (activeUnit == null)
			{
				Contact contact = null;
				if (text2 != null)
				{
					string nameOrId = text2;
					Side side = null;
					contact = LuaUtility.smethod_27(nameOrId, scenario_0, ref side);
				}
				else if (text != null)
				{
					string nameOrId2 = text;
					Side side = null;
					contact = LuaUtility.smethod_27(nameOrId2, scenario_0, ref side);
				}
				if (contact != null)
				{
					activeUnit = contact.ActualUnit;
				}
			}
			return new LuaWrapper_ActiveUnit(activeUnit, scenario_0);
		}

		// Token: 0x060067C9 RID: 26569 RVA: 0x0036BFCC File Offset: 0x0036A1CC
		public static LuaWrapper_Contact smethod_40(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			Contact contact = null;
			Side fromSide = null;
			checked
			{
				if (objectGeoLocation.ContainsKey("GUID"))
				{
					string text = "";
					try
					{
						text = Conversions.ToString(objectGeoLocation["GUID"]);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						throw new Exception2("guid must be a string");
					}
					bool flag = false;
					try
					{
						Side[] sides = scenario_0.GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							Side side = sides[i];
							if (flag)
							{
								break;
							}
							foreach (Contact current in side.GetContactList())
							{
								if (Operators.CompareString(current.GetGuid(), text.ToLower(), false) == 0)
								{
									fromSide = side;
									contact = current;
									flag = true;
									break;
								}
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						throw new Exception2("Can't find guid " + text);
					}
					if (Information.IsNothing(contact))
					{
						throw new Exception2("Unable to find contact matching guid: " + text);
					}
				}
				return new LuaWrapper_Contact(contact, scenario_0, fromSide);
			}
		}

		// Token: 0x060067CA RID: 26570 RVA: 0x0036C11C File Offset: 0x0036A31C
		public static LuaWrapper_Side smethod_41(LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			Side side = null;
			LuaUtility.smethod_5(ref objectGeoLocation);
			checked
			{
				if (objectGeoLocation.ContainsKey("GUID"))
				{
					string text = "";
					try
					{
						text = Conversions.ToString(objectGeoLocation["GUID"]);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						throw new Exception2("guid must be a string");
					}
					Side[] sides = scenario_0.GetSides();
					int i = 0;
					while (i < sides.Length)
					{
						Side side2 = sides[i];
						if (Operators.CompareString(side2.GetGuid(), text.ToLower(), false) != 0)
						{
							i++;
						}
						else
						{
							side = side2;
							if (Information.IsNothing(side))
							{
								throw new Exception2("Unable to find side matching guid:  " + text);
							}
							goto IL_12C;
						}
					}
					if (Information.IsNothing(side))
					{
						throw new Exception2("Unable to find side matching guid:  " + text);
					}
				}
				else if (objectGeoLocation.ContainsKey("SIDE"))
				{
					string str;
					try
					{
						str = Conversions.ToString(objectGeoLocation["SIDE"]);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						throw new Exception2("name must be a string");
					}
					side = LuaUtility.smethod_15(objectGeoLocation, scenario_0);
					if (Information.IsNothing(side))
					{
						throw new Exception2("Unable to find side matching name: " + str);
					}
				}
				IL_12C:
				return new LuaWrapper_Side(side, scenario_0);
			}
		}

		// Token: 0x060067CB RID: 26571 RVA: 0x0036C27C File Offset: 0x0036A47C
		public static int smethod_42(LuaTable luaTable_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			double? num = LuaUtility.smethod_10(objectGeoLocation);
			if (!num.HasValue)
			{
				throw new Exception2("Missing 'Latitude'");
			}
			double? num2 = LuaUtility.smethod_12(objectGeoLocation);
			if (!num2.HasValue)
			{
				throw new Exception2("Missing 'Longitude'");
			}
			return (int)Terrain.GetElevation(num.Value, num2.Value, false);
		}

		// Token: 0x060067CC RID: 26572 RVA: 0x0036C2E4 File Offset: 0x0036A4E4
		public static LuaTable smethod_43(LuaTable luaTable_0)
		{
			int num = 45;
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			double? num2 = LuaUtility.smethod_10(objectGeoLocation);
			if (!num2.HasValue)
			{
				throw new Exception2("Missing 'Latitude'");
			}
			double? num3 = LuaUtility.smethod_12(objectGeoLocation);
			if (!num3.HasValue)
			{
				throw new Exception2("Missing 'Longitude'");
			}
			if (objectGeoLocation.ContainsKey("NUMPOINTS"))
			{
				try
				{
					num = Conversions.ToInteger(objectGeoLocation["NUMPOINTS"]);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("Numpoints must be an integer");
				}
			}
			if (objectGeoLocation.ContainsKey("RADIUS"))
			{
				float num4 = 0f;
				try
				{
					num4 = Conversions.ToSingle(objectGeoLocation["RADIUS"]);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					throw new Exception2("Radius must be a number");
				}
				Class258.Location[] array = new Class258.Location[num + 1];
				Class258.smethod_9(num2.Value, num3.Value, (double)num4, num, ref array);
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num5 = 1;
				Class258.Location[] array2 = array;
				for (int i = 0; i < array2.Length; i = checked(i + 1))
				{
					Class258.Location location = array2[i];
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					luaTable2["Latitude"] = location.latitude;
					luaTable2["Longitude"] = location.longitude;
					luaTable[num5] = luaTable2;
					num5++;
				}
				return luaTable;
			}
			throw new Exception2("Radius is not specified");
		}

		// Token: 0x060067CD RID: 26573 RVA: 0x0036C48C File Offset: 0x0036A68C
		public static Side smethod_44(string string_0, Scenario scenario_0)
		{
			Side side = null;
			Side[] sides = scenario_0.GetSides();
			int i = 0;
			checked
			{
				Side result;
				while (i < sides.Length)
				{
					Side side2 = sides[i];
					if (Operators.CompareString(side2.GetSideName(), string_0, false) != 0 && Operators.CompareString(side2.GetGuid(), string_0.ToLower(), false) != 0)
					{
						if (Operators.CompareString(side2.GetSideName().ToUpper(), string_0.ToUpper(), false) != 0 && Operators.CompareString(side2.GetGuid().ToUpper(), string_0.ToUpper(), false) != 0)
						{
							i++;
							continue;
						}
						side = side2;
					}
					else
					{
						side = side2;
					}
					result = side;
					return result;
				}
				result = side;
				return result;
			}
		}

		// Token: 0x060067CE RID: 26574 RVA: 0x0036C528 File Offset: 0x0036A728
		public static ActiveUnit smethod_45(string string_0, Scenario scenario_0)
		{
			ActiveUnit result = null;
			foreach (ActiveUnit current in scenario_0.GetActiveUnitList())
			{
				if (Operators.CompareString(current.Name, string_0, false) != 0 && Operators.CompareString(current.GetGuid(), string_0.ToLower(), false) != 0)
				{
					if (Operators.CompareString(current.Name.ToUpper(), string_0.ToUpper(), false) != 0 && Operators.CompareString(current.GetGuid().ToUpper(), string_0.ToUpper(), false) != 0)
					{
						continue;
					}
					result = current;
				}
				else
				{
					result = current;
				}
				break;
			}
			return result;
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x0036C5E8 File Offset: 0x0036A7E8
		public static ActiveUnit smethod_46(string string_0, Side side_0)
		{
			ActiveUnit activeUnit = null;
			ActiveUnit[] activeUnitArray = side_0.ActiveUnitArray;
			int i = 0;
			checked
			{
				ActiveUnit result;
				while (i < activeUnitArray.Length)
				{
					ActiveUnit activeUnit2 = activeUnitArray[i];
					if (Operators.CompareString(activeUnit2.Name, string_0, false) != 0 && Operators.CompareString(activeUnit2.GetGuid(), string_0.ToLower(), false) != 0)
					{
						if (Operators.CompareString(activeUnit2.Name.ToUpper(), string_0.ToUpper(), false) != 0 && Operators.CompareString(activeUnit2.GetGuid().ToUpper(), string_0.ToUpper(), false) != 0)
						{
							i++;
							continue;
						}
						activeUnit = activeUnit2;
					}
					else
					{
						activeUnit = activeUnit2;
					}
					result = activeUnit;
					return result;
				}
				result = activeUnit;
				return result;
			}
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x0036C684 File Offset: 0x0036A884
		public static Contact smethod_47(string string_0, Scenario scenario_0)
		{
			Contact contact = null;
			Side[] sides = scenario_0.GetSides();
			checked
			{
				Contact contact2;
				Contact result;
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					foreach (Contact current in side.GetContactList())
					{
						if (Operators.CompareString(current.Name, string_0, false) == 0 || Operators.CompareString(current.GetGuid(), string_0.ToLower(), false) == 0)
						{
							contact = current;
							contact2 = contact;
							result = contact2;
							return result;
						}
						if (Operators.CompareString(current.Name.ToUpper(), string_0.ToUpper(), false) == 0 || Operators.CompareString(current.GetGuid().ToUpper(), string_0.ToUpper(), false) == 0)
						{
							contact = current;
							contact2 = contact;
							result = contact2;
							return result;
						}
					}
				}
				contact2 = contact;
				result = contact2;
				return result;
			}
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x0036C780 File Offset: 0x0036A980
		public static ActiveUnit smethod_48(string AUGUID, string AUName, Scenario theScen, bool useParentGroup = true)
		{
			ActiveUnit result = null;
			bool flag = false;
			Group group = null;
			foreach (ActiveUnit current in theScen.GetActiveUnitList())
			{
				if (Operators.CompareString(current.GetGuid(), AUGUID.ToLower(), false) == 0)
				{
					flag = true;
					if (useParentGroup)
					{
						group = current.GetParentGroup(false);
					}
				}
				else if (flag && (Operators.CompareString(current.Name, AUName, false) == 0 || Operators.CompareString(current.Name.ToUpper(), AUName.ToUpper(), false) == 0) && (group == null || Operators.CompareString(group.GetGuid(), current.GetParentGroup(false).GetGuid(), false) == 0))
				{
					result = current;
					break;
				}
			}
			return result;
		}

		// Token: 0x060067D2 RID: 26578 RVA: 0x0036C868 File Offset: 0x0036AA68
		public static bool smethod_49(ActiveUnit theU, Scenario ScenarioContext, ref string message, ref ActiveUnit theSelectedTanker, ref List<Mission> theSelectedMissions)
		{
			string text = "";
			if (theU.IsAircraft)
			{
				Aircraft aircraft = (Aircraft)theU;
				Aircraft_AirOps aircraftAirOps = aircraft.GetAircraftAirOps();
				GeoPoint intermediateTargetPoint = aircraft.GetAircraftAI().GetIntermediateTargetPoint();
				bool flag = true;
				bool flag2 = false;
				if (!aircraftAirOps.method_78(intermediateTargetPoint, Doctrine._RefuelSelection.const_0, ref flag, ref theSelectedTanker, ref theSelectedMissions, ref text, ref flag2) && Operators.CompareString(text, "", false) != 0)
				{
					string text2 = "";
					if (Operators.CompareString(aircraft.Name, aircraft.UnitClass, false) != 0)
					{
						text2 = " (" + aircraft.UnitClass + ")";
					}
					message = string.Concat(new string[]
					{
						"Aircraft ",
						aircraft.Name,
						text2,
						" cannot refuel. Reason: ",
						text
					});
				}
				aircraft.GetAircraftAI().UpdateUnitStatus(0f, false, false);
			}
			else if (theU.IsGroup)
			{
				Group group = (Group)theU;
				if (group.GetGroupType() == Group.GroupType.AirGroup && !Information.IsNothing(((Group)theU).GetGroupLead()))
				{
					Aircraft aircraft2 = (Aircraft)((Group)theU).GetGroupLead();
					Aircraft_AirOps aircraftAirOps2 = aircraft2.GetAircraftAirOps();
					GeoPoint intermediateTargetPoint2 = aircraft2.GetAircraftAI().GetIntermediateTargetPoint();
					bool flag2 = true;
					bool flag = true;
					if (aircraftAirOps2.method_78(intermediateTargetPoint2, Doctrine._RefuelSelection.const_0, ref flag2, ref theSelectedTanker, ref theSelectedMissions, ref text, ref flag))
					{
						Aircraft a2ARefuelingDestinationAircraft = aircraft2.GetAircraftAirOps().GetA2ARefuelingDestinationAircraft();
						if (Information.IsNothing(a2ARefuelingDestinationAircraft))
						{
							goto IL_229;
						}
						using (IEnumerator<ActiveUnit> enumerator = group.GetUnitsInGroup().Values.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								ActiveUnit current = enumerator.Current;
								if (current != aircraft2 && current.GetUnitStatus() != ActiveUnit._ActiveUnitStatus.Refuelling && current.IsOperating())
								{
									Aircraft_AirOps aircraft_AirOps = (Aircraft_AirOps)current.GetAirOps();
									current.SetUnitStatus(ActiveUnit._ActiveUnitStatus.HeadingToRefuelPoint);
									aircraft_AirOps.SetAirOpsCondition(Aircraft_AirOps._AirOpsCondition.ManoeuveringToRefuel);
									aircraft_AirOps.method_27(a2ARefuelingDestinationAircraft);
								}
							}
							goto IL_229;
						}
					}
					if (Operators.CompareString(text, "", false) != 0)
					{
						message = "The aircraft in group " + group.Name + " cannot refuel. Reason: " + text;
					}
				}
				IL_229:
				group.GetAI().UpdateUnitStatus(0f, false, false);
			}
			Ship ship = null;
			if (theU.IsShip)
			{
				ship = (Ship)theU;
			}
			if (!Information.IsNothing(ship))
			{
				if (!ship.GetDockingOps().method_51(ship.GetShipAI().GetIntermediateTargetPoint(), theSelectedTanker, theSelectedMissions, text, new int?(100)) && Operators.CompareString(text, "", false) != 0)
				{
					message = "Ship " + ship.Name + " cannot UNREP. Reason: " + text;
				}
				ship.GetShipAI().UpdateUnitStatus(0f, false, false);
			}
			if (theU.IsGroup)
			{
				Group group2 = (Group)theU;
				if (group2.GetGroupType() == Group.GroupType.SurfaceGroup || group2.GetGroupType() == Group.GroupType.SubGroup)
				{
					foreach (ActiveUnit current2 in group2.GetUnitsInGroup().Values)
					{
						text = "";
						if ((current2.IsShip || current2.IsSubmarine) && !current2.GetDockingOps().method_51(current2.GetAI().GetIntermediateTargetPoint(), theSelectedTanker, theSelectedMissions, text, new int?(100)) && Operators.CompareString(text, "", false) != 0)
						{
							message = "Unit " + current2.Name + " cannot UNREP. Reason: " + text;
						}
					}
					group2.GetAI().UpdateUnitStatus(0f, false, false);
				}
			}
			return true;
		}

		// Token: 0x040038B7 RID: 14519
		public static Func<Side, Side> SideFunc = (Side side_0) => side_0;

		// Token: 0x040038B8 RID: 14520
		public static Func<Magazine, string> MagazineFunc = (Magazine magazine_0) => magazine_0.bool_8.ToString();

		// Token: 0x040038B9 RID: 14521
		[CompilerGenerated]
		private static PrivateMethods.Delegate27 delegate27_0;

		// Token: 0x040038BA RID: 14522
		[CompilerGenerated]
		private static PrivateMethods.Delegate28 delegate28_0;

		// Token: 0x02000C22 RID: 3106
		// (Invoke) Token: 0x060067D8 RID: 26584
		public delegate void Delegate27(string theMsg, int theStyle, ref string pressed);

		// Token: 0x02000C23 RID: 3107
		// (Invoke) Token: 0x060067DC RID: 26588
		public delegate void Delegate28(string theFileName, bool FullScreen, int Delay);

		// Token: 0x02000C24 RID: 3108
		[CompilerGenerated]
		public sealed class Class300
		{
			// Token: 0x060067DF RID: 26591 RVA: 0x0002CBCC File Offset: 0x0002ADCC
			internal bool method_0(Side side_0)
			{
				return Operators.CompareString(side_0.GetSideName().ToUpper(), this.string_0.ToUpper(), false) == 0 || Operators.CompareString(side_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x040038BD RID: 14525
			public string string_0;
		}

		// Token: 0x02000C25 RID: 3109
		[CompilerGenerated]
		public sealed class Class301
		{
			// Token: 0x060067E1 RID: 26593 RVA: 0x0002CC09 File Offset: 0x0002AE09
			internal bool method_0(Side side_0)
			{
				return Operators.CompareString(side_0.GetSideName().ToUpper(), this.string_0.ToUpper(), false) == 0 || Operators.CompareString(side_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x040038BE RID: 14526
			public string string_0;
		}

		// Token: 0x02000C26 RID: 3110
		[CompilerGenerated]
		public sealed class Class302
		{
			// Token: 0x060067E3 RID: 26595 RVA: 0x0002CC46 File Offset: 0x0002AE46
			internal bool method_0(Side side_0)
			{
				return Operators.CompareString(side_0.GetSideName().ToUpper(), this.string_0.ToUpper(), false) == 0 || Operators.CompareString(side_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x040038BF RID: 14527
			public string string_0;
		}

		// Token: 0x02000C27 RID: 3111
		[CompilerGenerated]
		public sealed class Class303
		{
			// Token: 0x060067E5 RID: 26597 RVA: 0x0002CC83 File Offset: 0x0002AE83
			internal bool method_0(Side side_0)
			{
				return Operators.CompareString(side_0.GetSideName().ToUpper(), this.string_0.ToUpper(), false) == 0 || Operators.CompareString(side_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x040038C0 RID: 14528
			public string string_0;
		}

		// Token: 0x02000C28 RID: 3112
		[CompilerGenerated]
		public sealed class Class304
		{
			// Token: 0x060067E7 RID: 26599 RVA: 0x0002CCC0 File Offset: 0x0002AEC0
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x060067E8 RID: 26600 RVA: 0x0002CCC0 File Offset: 0x0002AEC0
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x040038C1 RID: 14529
			public string string_0;
		}

		// Token: 0x02000C29 RID: 3113
		[CompilerGenerated]
		public sealed class Class305
		{
			// Token: 0x060067EA RID: 26602 RVA: 0x0002CCFC File Offset: 0x0002AEFC
			public Class305(PrivateMethods.Class305 class305_0)
			{
				if (class305_0 != null)
				{
					this.string_0 = class305_0.string_0;
				}
			}

			// Token: 0x060067EB RID: 26603 RVA: 0x0002CD16 File Offset: 0x0002AF16
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x060067EC RID: 26604 RVA: 0x0002CD16 File Offset: 0x0002AF16
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x040038C2 RID: 14530
			public string string_0;
		}

		// Token: 0x02000C2A RID: 3114
		[CompilerGenerated]
		public sealed class Class306
		{
			// Token: 0x060067ED RID: 26605 RVA: 0x0002CD52 File Offset: 0x0002AF52
			public Class306(PrivateMethods.Class306 class306_0)
			{
				if (class306_0 != null)
				{
					this._FuelType_0 = class306_0._FuelType_0;
				}
			}

			// Token: 0x060067EE RID: 26606 RVA: 0x0002CD6C File Offset: 0x0002AF6C
			internal bool method_0(FuelRec fuelRec_0)
			{
				return fuelRec_0.FuelType == this._FuelType_0;
			}

			// Token: 0x040038C3 RID: 14531
			public FuelRec._FuelType _FuelType_0;
		}

		// Token: 0x02000C2B RID: 3115
		[CompilerGenerated]
		public sealed class Class307
		{
			// Token: 0x060067EF RID: 26607 RVA: 0x0002CD7C File Offset: 0x0002AF7C
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x060067F0 RID: 26608 RVA: 0x0002CD7C File Offset: 0x0002AF7C
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x040038C4 RID: 14532
			public string string_0;
		}

		// Token: 0x02000C2C RID: 3116
		[CompilerGenerated]
		public sealed class Class308
		{
			// Token: 0x060067F2 RID: 26610 RVA: 0x0002CD9D File Offset: 0x0002AF9D
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x060067F3 RID: 26611 RVA: 0x0002CD9D File Offset: 0x0002AF9D
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x040038C5 RID: 14533
			public string string_0;
		}

		// Token: 0x02000C2D RID: 3117
		[CompilerGenerated]
		public sealed class Class309
		{
			// Token: 0x060067F5 RID: 26613 RVA: 0x0002CDD9 File Offset: 0x0002AFD9
			public Class309(PrivateMethods.Class309 class309_0)
			{
				if (class309_0 != null)
				{
					this.string_0 = class309_0.string_0;
				}
			}

			// Token: 0x060067F6 RID: 26614 RVA: 0x0002CDF3 File Offset: 0x0002AFF3
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x060067F7 RID: 26615 RVA: 0x0002CDF3 File Offset: 0x0002AFF3
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x040038C6 RID: 14534
			public string string_0;
		}

		// Token: 0x02000C2E RID: 3118
		[CompilerGenerated]
		public sealed class Class310
		{
			// Token: 0x060067F8 RID: 26616 RVA: 0x0002CE2F File Offset: 0x0002B02F
			public Class310(PrivateMethods.Class310 class310_0)
			{
				if (class310_0 != null)
				{
					this.string_0 = class310_0.string_0;
				}
			}

			// Token: 0x060067F9 RID: 26617 RVA: 0x0002CE49 File Offset: 0x0002B049
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x060067FA RID: 26618 RVA: 0x0002CE49 File Offset: 0x0002B049
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0 | Operators.CompareString(activeUnit_0.GetGuid(), this.string_0.ToLower(), false) == 0;
			}

			// Token: 0x040038C7 RID: 14535
			public string string_0;
		}

		// Token: 0x02000C2F RID: 3119
		[CompilerGenerated]
		public sealed class Class311
		{
			// Token: 0x060067FB RID: 26619 RVA: 0x0002CE85 File Offset: 0x0002B085
			public Class311(PrivateMethods.Class311 class311_0)
			{
				if (class311_0 != null)
				{
					this.string_0 = class311_0.string_0;
				}
			}

			// Token: 0x060067FC RID: 26620 RVA: 0x0002CE9F File Offset: 0x0002B09F
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x060067FD RID: 26621 RVA: 0x0002CE9F File Offset: 0x0002B09F
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return Operators.CompareString(activeUnit_0.Name.ToUpper(), this.string_0.ToUpper(), false) == 0;
			}

			// Token: 0x040038C8 RID: 14536
			public string string_0;
		}
	}
}

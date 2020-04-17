using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns1;
using ns2;
using ns4;

namespace Command_Core.Lua
{
	// Token: 0x02000C69 RID: 3177
	[Attribute1, Attribute2, Attribute3]
	public sealed class LuaWrapper_Mission
	{
		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06006986 RID: 27014 RVA: 0x0038AD9C File Offset: 0x00388F9C
		[Attribute2]
		public string guid
		{
			get
			{
				return this.myMission.GetGuid();
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06006987 RID: 27015 RVA: 0x0038ADB8 File Offset: 0x00388FB8
		// (set) Token: 0x06006988 RID: 27016 RVA: 0x0002D81A File Offset: 0x0002BA1A
		[Attribute2]
		public string name
		{
			get
			{
				return this.myMission.Name;
			}
			set
			{
				this.myMission.Name = value;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06006989 RID: 27017 RVA: 0x0038ADD4 File Offset: 0x00388FD4
		// (set) Token: 0x0600698A RID: 27018 RVA: 0x0038ADFC File Offset: 0x00388FFC
		[Attribute2]
		public object isactive
		{
			get
			{
				return this.myMission.GetMissionStatus(this.ScenarioContext);
			}
			set
			{
				try
				{
					bool? booleanValue = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(value));
					if (booleanValue.HasValue)
					{
						bool? flag = booleanValue;
						if ((flag.HasValue ? new bool?(flag.GetValueOrDefault()) : null).GetValueOrDefault())
						{
							this.myMission.SetMissionStatus(this.ScenarioContext, Mission._MissionStatus.Activation);
						}
						else
						{
							this.myMission.SetMissionStatus(this.ScenarioContext, Mission._MissionStatus.DeActivation);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					throw new Exception2(ex2.Message);
				}
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600698B RID: 27019 RVA: 0x0038AEA0 File Offset: 0x003890A0
		[Attribute2]
		public string side
		{
			get
			{
				return this.mySide.GetSideName();
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600698C RID: 27020 RVA: 0x0038AEBC File Offset: 0x003890BC
		// (set) Token: 0x0600698D RID: 27021 RVA: 0x0038AEE4 File Offset: 0x003890E4
		[Attribute2]
		public string endtime
		{
			get
			{
				return this.myMission.GetEndTime().ToString();
			}
			set
			{
				try
				{
					if (value.Length > 0)
					{
						this.myMission.SetEndTime(new DateTime?(Conversions.ToDate(value)));
					}
					else
					{
						this.myMission.SetEndTime(null);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600698E RID: 27022 RVA: 0x0038AF4C File Offset: 0x0038914C
		// (set) Token: 0x0600698F RID: 27023 RVA: 0x0038AF74 File Offset: 0x00389174
		[Attribute2]
		public string starttime
		{
			get
			{
				return this.myMission.GetStartTime().ToString();
			}
			set
			{
				try
				{
					if (value.Length > 0)
					{
						this.myMission.SetStartTime(new DateTime?(Conversions.ToDate(value)));
					}
					else
					{
						this.myMission.SetStartTime(null);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06006990 RID: 27024 RVA: 0x0038AFDC File Offset: 0x003891DC
		[Attribute2]
		public Mission._MissionClass type
		{
			get
			{
				return this.myMission.MissionClass;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06006991 RID: 27025 RVA: 0x0038AFF8 File Offset: 0x003891F8
		// (set) Token: 0x06006992 RID: 27026 RVA: 0x0002D828 File Offset: 0x0002BA28
		[Attribute2]
		public object subtype
		{
			get
			{
				return this.myMission.GetTypeString(this.ScenarioContext);
			}
			set
			{
				throw new Exception2("Cannot set this property. Please use ScenEdit_Set.");
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06006993 RID: 27027 RVA: 0x0002D834 File Offset: 0x0002BA34
		// (set) Token: 0x06006994 RID: 27028 RVA: 0x0038B018 File Offset: 0x00389218
		[Attribute2]
		public bool SISH
		{
			get
			{
				return this.myMission.SISIH;
			}
			set
			{
				this.myMission.SISIH = LuaUtility.GetBooleanValue(value).Value;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06006995 RID: 27029 RVA: 0x0038B044 File Offset: 0x00389244
		[Attribute2]
		public object __mission
		{
			get
			{
				return this.myMission;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06006996 RID: 27030 RVA: 0x0038B05C File Offset: 0x0038925C
		// (set) Token: 0x06006997 RID: 27031 RVA: 0x0002D828 File Offset: 0x0002BA28
		[Attribute2]
		public LuaTable unitlist
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				List<ActiveUnit> list = new List<ActiveUnit>();
				list = this.myMission.GetUnitsAssignedToMe(this.ScenarioContext);
				int num = 1;
				foreach (ActiveUnit current in list)
				{
					luaTable[num] = current.GetGuid();
					num++;
				}
				return luaTable;
			}
			set
			{
				throw new Exception2("Cannot set this property. Please use ScenEdit_Set.");
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06006998 RID: 27032 RVA: 0x0038B0E4 File Offset: 0x003892E4
		// (set) Token: 0x06006999 RID: 27033 RVA: 0x0002D828 File Offset: 0x0002BA28
		[Attribute2]
		public LuaTable targetlist
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				HashSet<Unit> hashSet = new HashSet<Unit>();
				if (this.myMission.MissionClass == Mission._MissionClass.Strike)
				{
					hashSet = ((Strike)this.myMission).SpecificTargets;
					int num = 1;
					foreach (Unit current in hashSet)
					{
						luaTable[num] = current.GetGuid();
						num++;
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception2("Cannot set this property. Please use ScenEdit_Set.");
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600699A RID: 27034 RVA: 0x0038B180 File Offset: 0x00389380
		// (set) Token: 0x0600699B RID: 27035 RVA: 0x0002D841 File Offset: 0x0002BA41
		[Attribute2]
		public LuaTable aar
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				Doctrine._UseRefuel? useRefuel = null;
				useRefuel = this.myMission.m_Doctrine.GetUseRefuelDoctrine(this.ScenarioContext, false, false, false, false);
				if (useRefuel.HasValue)
				{
					luaTable["Doctrine_UseReplenishment"] = useRefuel.ToString();
				}
				string[] string_ = Class273.string_0;
				checked
				{
					for (int i = 0; i < string_.Length; i++)
					{
						string text = string_[i];
						uint num = Class382.smethod_0(text);
						if (num <= 1025497782u)
						{
							if (num <= 721363522u)
							{
								if (num != 620569374u)
								{
									if (num == 721363522u && Operators.CompareString(text, "TankerMaxDistance_Airborne", false) == 0)
									{
										if (this.myMission.TankerMaxDistance_Airborne < 1000)
										{
											luaTable[text] = this.myMission.TankerMaxDistance_Airborne;
										}
										else
										{
											luaTable[text] = "internal";
										}
									}
								}
								else if (Operators.CompareString(text, "TankerMinNumber_Airborne", false) == 0 && this.myMission.TankerUsage == Mission.TankerMethod.Mission)
								{
									luaTable[text] = this.myMission.TankerMinNumber_Airborne;
								}
							}
							else if (num != 882301358u)
							{
								if (num == 1025497782u && Operators.CompareString(text, "TankerMinNumber_Total", false) == 0 && this.myMission.TankerUsage == Mission.TankerMethod.Mission)
								{
									luaTable[text] = this.myMission.TankerMinNumber_Total;
								}
							}
							else if (Operators.CompareString(text, "LaunchMissionWithoutTankersInPlace", false) == 0 && this.myMission.TankerUsage == Mission.TankerMethod.Mission)
							{
								luaTable[text] = this.myMission.LaunchMissionWithoutTankersInPlace;
							}
						}
						else if (num <= 2367170728u)
						{
							if (num != 1688531320u)
							{
								if (num == 2367170728u && Operators.CompareString(text, "FuelQtyToStartLookingForTanker_Airborne", false) == 0)
								{
									luaTable[text] = this.myMission.FuelQtyToStartLookingForTanker_Airborne;
								}
							}
							else if (Operators.CompareString(text, "TankerMinNumber_Station", false) == 0 && this.myMission.TankerUsage == Mission.TankerMethod.Mission)
							{
								luaTable[text] = this.myMission.TankerMinNumber_Station;
							}
						}
						else if (num != 2435049132u)
						{
							if (num != 3749943133u)
							{
								if (num != 3802618614u)
								{
									if (num == 4100651282u && Operators.CompareString(text, "MaxReceiversInQueuePerTanker_Airborne", false) == 0)
									{
										luaTable[text] = this.myMission.MaxReceiversInQueuePerTanker_Airborne;
									}
								}
								else if (Operators.CompareString(text, "TankerFollowsReceivers", false) == 0)
								{
									luaTable[text] = this.myMission.bTankerFollowsReceivers;
								}
							}
							else if (Operators.CompareString(text, "TankerUsage", false) == 0)
							{
								luaTable[text] = this.myMission.TankerUsage.ToString();
							}
						}
						else if (Operators.CompareString(text, "TankerMissionList", false) == 0 && this.myMission.TankerUsage == Mission.TankerMethod.Mission)
						{
							LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
							foreach (Mission current in this.myMission.TankerMissionList)
							{
								luaTable2[1] = current.Name;
							}
							luaTable[text] = luaTable2;
						}
					}
					return luaTable;
				}
			}
			set
			{
				throw new Exception2("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600699C RID: 27036 RVA: 0x0038B5A4 File Offset: 0x003897A4
		// (set) Token: 0x0600699D RID: 27037 RVA: 0x0002D841 File Offset: 0x0002BA41
		[Attribute2]
		public LuaTable ferrymission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				checked
				{
					if (this.myMission.MissionClass == Mission._MissionClass.Ferry)
					{
						FerryMission ferryMission = (FerryMission)this.myMission;
						string[] string_ = Class273.string_7;
						for (int i = 0; i < string_.Length; i++)
						{
							string text = string_[i];
							uint num = Class382.smethod_0(text);
							if (num <= 933087157u)
							{
								if (num != 486744163u)
								{
									if (num != 543863533u)
									{
										if (num == 933087157u && Operators.CompareString(text, "FerryTerrainFollowingAircraft", false) == 0)
										{
											ferryMission.FerryTerrainFollowing_Aircraft.ToString();
										}
									}
									else if (Operators.CompareString(text, "FerryBehavior", false) == 0)
									{
										luaTable[text] = ferryMission.GetFerryMissionBehavior().ToString();
									}
								}
								else if (Operators.CompareString(text, "UseFlightSize", false) == 0)
								{
									luaTable[text] = ferryMission.UseFlightSizeHardLimit.ToString();
								}
							}
							else if (num <= 3088063337u)
							{
								if (num != 2487526210u)
								{
									if (num == 3088063337u && Operators.CompareString(text, "FerryThrottleAircraft", false) == 0)
									{
										luaTable[text] = ferryMission.FerryThrottle_Aircraft.ToString();
									}
								}
								else if (Operators.CompareString(text, "FlightSize", false) == 0)
								{
									luaTable[text] = ferryMission.m_FlightSize.ToString();
								}
							}
							else if (num != 3838663019u)
							{
								if (num == 3875984603u && Operators.CompareString(text, "FerryAltitudeAircraft", false) == 0)
								{
									luaTable[text] = ferryMission.FerryAltitude_Aircraft.ToString();
								}
							}
							else if (Operators.CompareString(text, "MinAircraftReq", false) == 0)
							{
								luaTable[text] = ferryMission.MinAircraftReq.ToString();
							}
						}
					}
					return luaTable;
				}
			}
			set
			{
				throw new Exception2("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600699E RID: 27038 RVA: 0x0038B7D8 File Offset: 0x003899D8
		// (set) Token: 0x0600699F RID: 27039 RVA: 0x0002D841 File Offset: 0x0002BA41
		[Attribute2]
		public LuaTable mineclearmission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (this.myMission.MissionClass == Mission._MissionClass.MineClearing)
				{
					MineClearingMission mineClearingMission = (MineClearingMission)this.myMission;
					string[] string_ = Class273.string_5;
					for (int i = 0; i < string_.Length; i = checked(i + 1))
					{
						string text = string_[i];
						uint num = Class382.smethod_0(text);
						if (num <= 1971082657u)
						{
							if (num <= 919337238u)
							{
								if (num <= 571839996u)
								{
									if (num != 486744163u)
									{
										if (num == 571839996u && Operators.CompareString(text, "StationDepthSubmarine", false) == 0)
										{
											luaTable[text] = mineClearingMission.StationDepth_Submarine;
										}
									}
									else if (Operators.CompareString(text, "UseFlightSize", false) == 0)
									{
										luaTable[text] = mineClearingMission.UseFlightSizeHardLimit;
									}
								}
								else if (num != 589144192u)
								{
									if (num == 919337238u && Operators.CompareString(text, "OneThirdRule", false) == 0)
									{
										luaTable[text] = mineClearingMission.OTR;
									}
								}
								else if (Operators.CompareString(text, "TransitThrottleSubmarine", false) == 0)
								{
									luaTable[text] = mineClearingMission.TransitThrottle_Submarine;
								}
							}
							else if (num <= 1271533277u)
							{
								if (num != 1082283198u)
								{
									if (num == 1271533277u && Operators.CompareString(text, "StationTerrainFollowingAircraft", false) == 0)
									{
										luaTable[text] = mineClearingMission.StationTerrainFollowing_Aircraft;
									}
								}
								else if (Operators.CompareString(text, "UseGroupSize", false) == 0)
								{
									luaTable[text] = mineClearingMission.UseGroupSizeHardLimit;
								}
							}
							else if (num != 1304453504u)
							{
								if (num != 1723673953u)
								{
									if (num == 1971082657u && Operators.CompareString(text, "StationThrottleSubmarine", false) == 0)
									{
										luaTable[text] = mineClearingMission.StationThrottle_Submarine;
									}
								}
								else if (Operators.CompareString(text, "StationThrottleShip", false) == 0)
								{
									luaTable[text] = mineClearingMission.StationThrottle_Ship;
								}
							}
							else if (Operators.CompareString(text, "TransitAltitudeAircraft", false) == 0)
							{
								luaTable[text] = mineClearingMission.TransitAltitude_Aircraft;
							}
						}
						else if (num <= 3248436129u)
						{
							if (num <= 2487526210u)
							{
								if (num != 2251788647u)
								{
									if (num == 2487526210u && Operators.CompareString(text, "FlightSize", false) == 0)
									{
										luaTable[text] = mineClearingMission.m_FlightSize;
									}
								}
								else if (Operators.CompareString(text, "Zone", false) == 0)
								{
									LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
									int num2 = 1;
									foreach (ReferencePoint current in mineClearingMission.AreaVertices)
									{
										LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
										luaTable3["name"] = current.Name;
										luaTable2[num2] = luaTable3;
										num2++;
									}
									luaTable[text] = luaTable2;
								}
							}
							else if (num != 2895834706u)
							{
								if (num != 3161091587u)
								{
									if (num == 3248436129u && Operators.CompareString(text, "StationThrottleAircraft", false) == 0)
									{
										luaTable[text] = mineClearingMission.StationThrottle_Aircraft;
									}
								}
								else if (Operators.CompareString(text, "TransitDepthSubmarine", false) == 0)
								{
									luaTable[text] = mineClearingMission.TransitDepth_Submarine;
								}
							}
							else if (Operators.CompareString(text, "TransitThrottleShip", false) == 0)
							{
								luaTable[text] = mineClearingMission.TransitThrottle_Ship;
							}
						}
						else if (num <= 3539526598u)
						{
							if (num != 3359711974u)
							{
								if (num == 3539526598u && Operators.CompareString(text, "TransitThrottleAircraft", false) == 0)
								{
									luaTable[text] = mineClearingMission.TransitThrottle_Aircraft;
								}
							}
							else if (Operators.CompareString(text, "TransitTerrainFollowingAircraft", false) == 0)
							{
								luaTable[text] = mineClearingMission.TransitTerrainFollowing_Aircraft;
							}
						}
						else if (num != 3838663019u)
						{
							if (num != 3853660013u)
							{
								if (num == 3863701925u && Operators.CompareString(text, "GroupSize", false) == 0)
								{
									luaTable[text] = mineClearingMission.m_GroupSize;
								}
							}
							else if (Operators.CompareString(text, "StationtAltitudeAircraft", false) == 0)
							{
								luaTable[text] = mineClearingMission.StationAltitude_Aircraft;
							}
						}
						else if (Operators.CompareString(text, "MinAircraftReq", false) == 0)
						{
							luaTable[text] = mineClearingMission.MinAircraftReq;
						}
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception2("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060069A0 RID: 27040 RVA: 0x0038BD90 File Offset: 0x00389F90
		// (set) Token: 0x060069A1 RID: 27041 RVA: 0x0002D841 File Offset: 0x0002BA41
		[Attribute2]
		public LuaTable minemission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (this.myMission.MissionClass == Mission._MissionClass.Mining)
				{
					MiningMission miningMission = (MiningMission)this.myMission;
					string[] string_ = Class273.string_4;
					for (int i = 0; i < string_.Length; i = checked(i + 1))
					{
						string text = string_[i];
						uint num = Class382.smethod_0(text);
						if (num <= 2251788647u)
						{
							if (num <= 1082283198u)
							{
								if (num <= 571839996u)
								{
									if (num != 486744163u)
									{
										if (num == 571839996u && Operators.CompareString(text, "StationDepthSubmarine", false) == 0)
										{
											luaTable[text] = miningMission.StationDepth_Submarine;
										}
									}
									else if (Operators.CompareString(text, "UseFlightSize", false) == 0)
									{
										luaTable[text] = miningMission.UseFlightSizeHardLimit;
									}
								}
								else if (num != 589144192u)
								{
									if (num != 919337238u)
									{
										if (num == 1082283198u && Operators.CompareString(text, "UseGroupSize", false) == 0)
										{
											luaTable[text] = miningMission.UseGroupSizeHardLimit;
										}
									}
									else if (Operators.CompareString(text, "OneThirdRule", false) == 0)
									{
										luaTable[text] = miningMission.bOTR;
									}
								}
								else if (Operators.CompareString(text, "TransitThrottleSubmarine", false) == 0)
								{
									luaTable[text] = miningMission.TransitThrottle_Submarine;
								}
							}
							else if (num <= 1304453504u)
							{
								if (num != 1271533277u)
								{
									if (num == 1304453504u && Operators.CompareString(text, "TransitAltitudeAircraft", false) == 0)
									{
										luaTable[text] = miningMission.TransitAltitude_Aircraft;
									}
								}
								else if (Operators.CompareString(text, "StationTerrainFollowingAircraft", false) == 0)
								{
									luaTable[text] = miningMission.StationTerrainFollowing_Aircraft;
								}
							}
							else if (num != 1723673953u)
							{
								if (num != 1971082657u)
								{
									if (num == 2251788647u && Operators.CompareString(text, "Zone", false) == 0)
									{
										LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
										int num2 = 1;
										foreach (ReferencePoint current in miningMission.AreaVertices)
										{
											LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
											luaTable3["name"] = current.Name;
											luaTable2[num2] = luaTable3;
											num2++;
										}
										luaTable[text] = luaTable2;
									}
								}
								else if (Operators.CompareString(text, "StationThrottleSubmarine", false) == 0)
								{
									luaTable[text] = miningMission.StationThrottle_Submarine;
								}
							}
							else if (Operators.CompareString(text, "StationThrottleShip", false) == 0)
							{
								luaTable[text] = miningMission.StationThrottle_Ship;
							}
						}
						else if (num <= 3248436129u)
						{
							if (num <= 2487526210u)
							{
								if (num != 2395892618u)
								{
									if (num == 2487526210u && Operators.CompareString(text, "FlightSize", false) == 0)
									{
										luaTable[text] = miningMission.m_FlightSize;
									}
								}
								else if (Operators.CompareString(text, "ArmingDelay", false) == 0)
								{
									TimeSpan timeSpan = TimeSpan.FromSeconds((double)miningMission.AD);
									string value = string.Format("{0:D2}d:{1:D2}h:{2:D2}m:{3:D2}s", new object[]
									{
										timeSpan.Days,
										timeSpan.Hours,
										timeSpan.Minutes,
										timeSpan.Seconds
									});
									luaTable[text] = value;
								}
							}
							else if (num != 2895834706u)
							{
								if (num != 3161091587u)
								{
									if (num == 3248436129u && Operators.CompareString(text, "StationThrottleAircraft", false) == 0)
									{
										luaTable[text] = miningMission.StationThrottle_Aircraft;
									}
								}
								else if (Operators.CompareString(text, "TransitDepthSubmarine", false) == 0)
								{
									luaTable[text] = miningMission.TransitDepth_Submarine;
								}
							}
							else if (Operators.CompareString(text, "TransitThrottleShip", false) == 0)
							{
								luaTable[text] = miningMission.TransitThrottle_Ship;
							}
						}
						else if (num <= 3539526598u)
						{
							if (num != 3359711974u)
							{
								if (num == 3539526598u && Operators.CompareString(text, "TransitThrottleAircraft", false) == 0)
								{
									luaTable[text] = miningMission.TransitThrottle_Aircraft;
								}
							}
							else if (Operators.CompareString(text, "TransitTerrainFollowingAircraft", false) == 0)
							{
								luaTable[text] = miningMission.TransitTerrainFollowing_Aircraft;
							}
						}
						else if (num != 3838663019u)
						{
							if (num != 3853660013u)
							{
								if (num == 3863701925u && Operators.CompareString(text, "GroupSize", false) == 0)
								{
									luaTable[text] = miningMission.m_GroupSize;
								}
							}
							else if (Operators.CompareString(text, "StationtAltitudeAircraft", false) == 0)
							{
								luaTable[text] = miningMission.StationAltitude_Aircraft;
							}
						}
						else if (Operators.CompareString(text, "MinAircraftReq", false) == 0)
						{
							luaTable[text] = miningMission.MinAircraftReq;
						}
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception2("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060069A2 RID: 27042 RVA: 0x0038C3E4 File Offset: 0x0038A5E4
		// (set) Token: 0x060069A3 RID: 27043 RVA: 0x0002D841 File Offset: 0x0002BA41
		[Attribute2]
		public LuaTable supportmission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (this.myMission.MissionClass == Mission._MissionClass.Support)
				{
					SupportMission supportMission = (SupportMission)this.myMission;
					string[] string_ = Class273.string_1;
					for (int i = 0; i < string_.Length; i = checked(i + 1))
					{
						string text = string_[i];
						uint num = Class382.smethod_0(text);
						if (num <= 1971082657u)
						{
							if (num <= 844935987u)
							{
								if (num <= 486744163u)
								{
									if (num != 207389640u)
									{
										if (num != 423054875u)
										{
											if (num == 486744163u && Operators.CompareString(text, "UseFlightSize", false) == 0)
											{
												luaTable[text] = supportMission.UseFlightSizeHardLimit;
											}
										}
										else if (Operators.CompareString(text, "TankerOneTime", false) == 0)
										{
											luaTable[text] = supportMission.A2AR_OneTankingCycleOnly;
										}
									}
									else if (Operators.CompareString(text, "OneTimeOnly", false) == 0)
									{
										luaTable[text] = supportMission.OTO;
									}
								}
								else if (num != 571839996u)
								{
									if (num != 589144192u)
									{
										if (num == 844935987u && Operators.CompareString(text, "LoopType", false) == 0)
										{
											luaTable[text] = supportMission.NLT;
										}
									}
									else if (Operators.CompareString(text, "TransitThrottleSubmarine", false) == 0)
									{
										luaTable[text] = supportMission.TransitThrottle_Submarine;
									}
								}
								else if (Operators.CompareString(text, "StationDepthSubmarine", false) == 0)
								{
									luaTable[text] = supportMission.StationDepth_Submarine;
								}
							}
							else if (num <= 1271533277u)
							{
								if (num != 919337238u)
								{
									if (num != 1082283198u)
									{
										if (num == 1271533277u && Operators.CompareString(text, "StationTerrainFollowingAircraft", false) == 0)
										{
											luaTable[text] = supportMission.StationTerrainFollowing_Aircraft;
										}
									}
									else if (Operators.CompareString(text, "UseGroupSize", false) == 0)
									{
										luaTable[text] = supportMission.UseGroupSizeHardLimit;
									}
								}
								else if (Operators.CompareString(text, "OneThirdRule", false) == 0)
								{
									luaTable[text] = supportMission.OTR;
								}
							}
							else if (num != 1304453504u)
							{
								if (num != 1723673953u)
								{
									if (num == 1971082657u && Operators.CompareString(text, "StationThrottleSubmarine", false) == 0)
									{
										luaTable[text] = supportMission.StationThrottle_Submarine;
									}
								}
								else if (Operators.CompareString(text, "StationThrottleShip", false) == 0)
								{
									luaTable[text] = supportMission.StationThrottle_Ship;
								}
							}
							else if (Operators.CompareString(text, "TransitAltitudeAircraft", false) == 0)
							{
								luaTable[text] = supportMission.TransitAltitude_Aircraft;
							}
						}
						else if (num <= 3161091587u)
						{
							if (num <= 2654305815u)
							{
								if (num != 2251788647u)
								{
									if (num != 2487526210u)
									{
										if (num == 2654305815u && Operators.CompareString(text, "ActiveEMCON", false) == 0)
										{
											luaTable[text] = supportMission.AEOOS;
										}
									}
									else if (Operators.CompareString(text, "FlightSize", false) == 0)
									{
										luaTable[text] = supportMission.m_FlightSize;
									}
								}
								else if (Operators.CompareString(text, "Zone", false) == 0)
								{
									LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
									int num2 = 1;
									foreach (ReferencePoint current in supportMission.NavigationCourseReferencePoints)
									{
										LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
										luaTable3["name"] = current.Name;
										luaTable2[num2] = luaTable3;
										num2++;
									}
									luaTable[text] = luaTable2;
								}
							}
							else if (num != 2895834706u)
							{
								if (num != 2974751110u)
								{
									if (num == 3161091587u && Operators.CompareString(text, "TransitDepthSubmarine", false) == 0)
									{
										luaTable[text] = supportMission.TransitDepth_Submarine;
									}
								}
								else if (Operators.CompareString(text, "TankerMaxReceivers", false) == 0)
								{
									luaTable[text] = supportMission.A2AR_MaxNumberOfReceiversPerTanker;
								}
							}
							else if (Operators.CompareString(text, "TransitThrottleShip", false) == 0)
							{
								luaTable[text] = supportMission.TransitThrottle_Ship;
							}
						}
						else if (num <= 3359711974u)
						{
							if (num != 3248436129u)
							{
								if (num != 3327446972u)
								{
									if (num == 3359711974u && Operators.CompareString(text, "TransitTerrainFollowingAircraft", false) == 0)
									{
										luaTable[text] = supportMission.TransitTerrainFollowing_Aircraft;
									}
								}
								else if (Operators.CompareString(text, "OnStation", false) == 0)
								{
									luaTable[text] = supportMission.MNOS;
								}
							}
							else if (Operators.CompareString(text, "StationThrottleAircraft", false) == 0)
							{
								luaTable[text] = supportMission.StationThrottle_Aircraft;
							}
						}
						else if (num <= 3838663019u)
						{
							if (num != 3539526598u)
							{
								if (num == 3838663019u && Operators.CompareString(text, "MinAircraftReq", false) == 0)
								{
									luaTable[text] = supportMission.MinAircraftReq;
								}
							}
							else if (Operators.CompareString(text, "TransitThrottleAircraft", false) == 0)
							{
								luaTable[text] = supportMission.TransitThrottle_Aircraft;
							}
						}
						else if (num != 3853660013u)
						{
							if (num == 3863701925u && Operators.CompareString(text, "GroupSize", false) == 0)
							{
								luaTable[text] = supportMission.m_GroupSize;
							}
						}
						else if (Operators.CompareString(text, "StationtAltitudeAircraft", false) == 0)
						{
							luaTable[text] = supportMission.StationAltitude_Aircraft;
						}
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception2("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060069A4 RID: 27044 RVA: 0x0038CB1C File Offset: 0x0038AD1C
		// (set) Token: 0x060069A5 RID: 27045 RVA: 0x0002D841 File Offset: 0x0002BA41
		[Attribute2]
		public LuaTable patrolmission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (this.myMission.MissionClass == Mission._MissionClass.Patrol)
				{
					Patrol patrol = (Patrol)this.myMission;
					string[] string_ = Class273.string_6;
					for (int i = 0; i < string_.Length; i = checked(i + 1))
					{
						string text = string_[i];
						uint num = Class382.smethod_0(text);
						if (num <= 1971082657u)
						{
							if (num <= 919337238u)
							{
								if (num <= 571839996u)
								{
									if (num <= 474174523u)
									{
										if (num != 260972983u)
										{
											if (num == 474174523u && Operators.CompareString(text, "CheckOPA", false) == 0)
											{
												luaTable[text] = patrol.method_43(this.ScenarioContext);
											}
										}
										else if (Operators.CompareString(text, "AttackThrottleSubmarine", false) == 0)
										{
											luaTable[text] = patrol.AttackThrottle_Submarine;
										}
									}
									else if (num != 486744163u)
									{
										if (num == 571839996u && Operators.CompareString(text, "StationDepthSubmarine", false) == 0)
										{
											luaTable[text] = patrol.StationDepth_Submarine;
										}
									}
									else if (Operators.CompareString(text, "UseFlightSize", false) == 0)
									{
										luaTable[text] = patrol.UseFlightSizeHardLimit;
									}
								}
								else if (num <= 773774400u)
								{
									if (num != 589144192u)
									{
										if (num == 773774400u && Operators.CompareString(text, "AttackDistanceShip", false) == 0)
										{
											luaTable[text] = patrol.AttackDistance_Ship;
										}
									}
									else if (Operators.CompareString(text, "TransitThrottleSubmarine", false) == 0)
									{
										luaTable[text] = patrol.TransitThrottle_Submarine;
									}
								}
								else if (num != 801609397u)
								{
									if (num == 919337238u && Operators.CompareString(text, "OneThirdRule", false) == 0)
									{
										luaTable[text] = patrol.OTR;
									}
								}
								else if (Operators.CompareString(text, "CheckWWR", false) == 0)
								{
									luaTable[text] = patrol.method_45(this.ScenarioContext);
								}
							}
							else if (num <= 1304453504u)
							{
								if (num <= 1261763376u)
								{
									if (num != 1082283198u)
									{
										if (num == 1261763376u && Operators.CompareString(text, "AttackDistanceAircraft", false) == 0)
										{
											luaTable[text] = patrol.AttackDistance_Aircraft;
										}
									}
									else if (Operators.CompareString(text, "UseGroupSize", false) == 0)
									{
										luaTable[text] = patrol.UseGroupSizeHardLimit;
									}
								}
								else if (num != 1271533277u)
								{
									if (num == 1304453504u && Operators.CompareString(text, "TransitAltitudeAircraft", false) == 0)
									{
										luaTable[text] = patrol.TransitAltitude_Aircraft;
									}
								}
								else if (Operators.CompareString(text, "StationTerrainFollowingAircraft", false) == 0)
								{
									luaTable[text] = patrol.StationTerrainFollowing_Aircraft;
								}
							}
							else if (num <= 1723673953u)
							{
								if (num != 1467735683u)
								{
									if (num == 1723673953u && Operators.CompareString(text, "StationThrottleShip", false) == 0)
									{
										luaTable[text] = patrol.StationThrottle_Ship;
									}
								}
								else if (Operators.CompareString(text, "AttackTerrainFollowingAircraft", false) == 0)
								{
									luaTable[text] = patrol.AttackTerrainFollowing_Aircraft;
								}
							}
							else if (num != 1874715478u)
							{
								if (num == 1971082657u && Operators.CompareString(text, "StationThrottleSubmarine", false) == 0)
								{
									luaTable[text] = patrol.StationThrottle_Submarine;
								}
							}
							else if (Operators.CompareString(text, "AttackDistanceSubmarine", false) == 0)
							{
								luaTable[text] = patrol.AttackDistance_Submarine;
							}
						}
						else if (num <= 3161091587u)
						{
							if (num <= 2487526210u)
							{
								if (num <= 2390362545u)
								{
									if (num != 2072361171u)
									{
										if (num == 2390362545u && Operators.CompareString(text, "PatrolZone", false) == 0)
										{
											LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
											int num2 = 1;
											foreach (ReferencePoint current in patrol.ProsecutionAreaVertices)
											{
												LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
												luaTable3["name"] = current.Name;
												luaTable2[num2] = luaTable3;
												num2++;
											}
											luaTable[text] = luaTable2;
										}
									}
									else if (Operators.CompareString(text, "AttackThrottleAircraft", false) == 0)
									{
										luaTable[text] = patrol.AttackThrottle_Aircraft;
									}
								}
								else if (num != 2435735519u)
								{
									if (num == 2487526210u && Operators.CompareString(text, "FlightSize", false) == 0)
									{
										luaTable[text] = patrol.m_FlightSize;
									}
								}
								else if (Operators.CompareString(text, "AttackThrottleShip", false) == 0)
								{
									luaTable[text] = patrol.AttackThrottle_Ship;
								}
							}
							else if (num <= 2895834706u)
							{
								if (num != 2654305815u)
								{
									if (num == 2895834706u && Operators.CompareString(text, "TransitThrottleShip", false) == 0)
									{
										luaTable[text] = patrol.TransitThrottle_Ship;
									}
								}
								else if (Operators.CompareString(text, "ActiveEMCON", false) == 0)
								{
									luaTable[text] = patrol.AEOIPA;
								}
							}
							else if (num != 3143824860u)
							{
								if (num == 3161091587u && Operators.CompareString(text, "TransitDepthSubmarine", false) == 0)
								{
									luaTable[text] = patrol.TransitDepth_Submarine;
								}
							}
							else if (Operators.CompareString(text, "ProsecutionZone", false) == 0)
							{
								LuaTable luaTable4 = LuaSandBox.Singleton().CreateTable();
								int num3 = 1;
								foreach (ReferencePoint current2 in patrol.PatrolAreaVertices)
								{
									LuaTable luaTable5 = LuaSandBox.Singleton().CreateTable();
									luaTable5["name"] = current2.Name;
									luaTable4[num3] = luaTable5;
									num3++;
								}
								luaTable[text] = luaTable4;
							}
						}
						else if (num <= 3539526598u)
						{
							if (num <= 3327446972u)
							{
								if (num != 3248436129u)
								{
									if (num == 3327446972u && Operators.CompareString(text, "OnStation", false) == 0)
									{
										luaTable[text] = patrol.MNOS;
									}
								}
								else if (Operators.CompareString(text, "StationThrottleAircraft", false) == 0)
								{
									luaTable[text] = patrol.StationThrottle_Aircraft;
								}
							}
							else if (num != 3359711974u)
							{
								if (num == 3539526598u && Operators.CompareString(text, "TransitThrottleAircraft", false) == 0)
								{
									luaTable[text] = patrol.TransitThrottle_Aircraft;
								}
							}
							else if (Operators.CompareString(text, "TransitTerrainFollowingAircraft", false) == 0)
							{
								luaTable[text] = patrol.TransitTerrainFollowing_Aircraft;
							}
						}
						else if (num <= 3838663019u)
						{
							if (num != 3743284747u)
							{
								if (num == 3838663019u && Operators.CompareString(text, "MinAircraftReq", false) == 0)
								{
									luaTable[text] = patrol.MinAircraftReq;
								}
							}
							else if (Operators.CompareString(text, "AttacktAltitudeAircraft", false) == 0)
							{
								luaTable[text] = patrol.AttackAltitude_Aircraft;
							}
						}
						else if (num != 3843578174u)
						{
							if (num != 3853660013u)
							{
								if (num == 3863701925u && Operators.CompareString(text, "GroupSize", false) == 0)
								{
									luaTable[text] = patrol.m_GroupSize;
								}
							}
							else if (Operators.CompareString(text, "StationtAltitudeAircraft", false) == 0)
							{
								luaTable[text] = patrol.StationAltitude_Aircraft;
							}
						}
						else if (Operators.CompareString(text, "AttackDepthSubmarine", false) == 0)
						{
							luaTable[text] = patrol.AttackDepth_Submarine;
						}
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception2("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060069A6 RID: 27046 RVA: 0x0038D52C File Offset: 0x0038B72C
		// (set) Token: 0x060069A7 RID: 27047 RVA: 0x0002D841 File Offset: 0x0002BA41
		[Attribute2]
		public LuaTable strikemission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
				checked
				{
					if (this.myMission.MissionClass == Mission._MissionClass.Strike)
					{
						Strike strike = (Strike)this.myMission;
						string[] string_ = Class273.string_2;
						for (int i = 0; i < string_.Length; i++)
						{
							string text = string_[i];
							uint num = Class382.smethod_0(text);
							if (num <= 1099520927u)
							{
								if (num <= 528827493u)
								{
									if (num != 451026229u)
									{
										if (num == 528827493u && Operators.CompareString(text, "EscortMinShooter", false) == 0)
										{
											luaTable2[text] = strike.MinAircraftReq_Escorts_Shooter;
										}
									}
									else if (Operators.CompareString(text, "EscortGroupSize", false) == 0)
									{
										luaTable2[text] = strike.Escort_GroupSize;
									}
								}
								else if (num != 545809894u)
								{
									if (num != 982860115u)
									{
										if (num == 1099520927u && Operators.CompareString(text, "EscortFlightSizeNonShooter", false) == 0)
										{
											luaTable2[text] = strike.Escort_FlightSize_NonShooter;
										}
									}
									else if (Operators.CompareString(text, "EscortMaxShooter", false) == 0)
									{
										luaTable2[text] = strike.MaxAircraftToFly_Escort_Shooter;
									}
								}
								else if (Operators.CompareString(text, "EscortMinNonShooter", false) == 0)
								{
									luaTable2[text] = strike.MinAircraftReq_Escorts_NonShooter;
								}
							}
							else if (num <= 2172848243u)
							{
								if (num != 2014184366u)
								{
									if (num == 2172848243u && Operators.CompareString(text, "EscortUseFlightSize", false) == 0)
									{
										luaTable2[text] = strike.UseFlightSizeHardLimit_Escort;
									}
								}
								else if (Operators.CompareString(text, "EscortUseGroupSize", false) == 0)
								{
									luaTable2[text] = strike.UseGroupSizeHardLimit_Escort;
								}
							}
							else if (num != 2374710346u)
							{
								if (num != 4137769460u)
								{
									if (num == 4146880316u && Operators.CompareString(text, "EscortResponseRadius", false) == 0)
									{
										luaTable2[text] = strike.Escort_ResponseRadius;
									}
								}
								else if (Operators.CompareString(text, "EscortMaxNonShooter", false) == 0)
								{
									luaTable2[text] = strike.MaxAircraftToFly_Escort_NonShooter;
								}
							}
							else if (Operators.CompareString(text, "EscortFlightSizeShooter", false) == 0)
							{
								luaTable2[text] = strike.Escort_FlightSize_Shooter;
							}
						}
						luaTable["Escort"] = luaTable2;
						luaTable2 = LuaSandBox.Singleton().CreateTable();
						string[] string_2 = Class273.string_2;
						for (int j = 0; j < string_2.Length; j++)
						{
							string text2 = string_2[j];
							uint num = Class382.smethod_0(text2);
							if (num <= 2200677047u)
							{
								if (num <= 592543766u)
								{
									if (num != 277681032u)
									{
										if (num == 592543766u && Operators.CompareString(text2, "StrikeOneTimeOnly", false) == 0)
										{
											luaTable2[text2] = strike.OneTimeOnly;
										}
									}
									else if (Operators.CompareString(text2, "StrikeUseGroupSize", false) == 0)
									{
										luaTable2[text2] = strike.UseGroupSizeHardLimit;
									}
								}
								else if (num != 987274155u)
								{
									if (num != 1939995596u)
									{
										if (num == 2200677047u && Operators.CompareString(text2, "StrikeMinimumTrigger", false) == 0)
										{
											luaTable2[text2] = strike.MinimumContactStanceToTrigger;
										}
									}
									else if (Operators.CompareString(text2, "StrikeFlightSize", false) == 0)
									{
										luaTable2[text2] = strike.m_FlightSize;
									}
								}
								else if (Operators.CompareString(text2, "StrikePrePlan", false) == 0)
								{
									luaTable2[text2] = strike.PrePlannedOnly;
								}
							}
							else if (num <= 4027019613u)
							{
								if (num != 3787335319u)
								{
									if (num == 4027019613u && Operators.CompareString(text2, "StrikeMinAircraftReq", false) == 0)
									{
										luaTable2[text2] = strike.MinAircraftReq_Strikers;
									}
								}
								else if (Operators.CompareString(text2, "StrikeGroupSize", false) == 0)
								{
									luaTable2[text2] = strike.m_GroupSize;
								}
							}
							else if (num != 4083776208u)
							{
								if (num != 4155462701u)
								{
									if (num == 4281028583u && Operators.CompareString(text2, "StrikeMax", false) == 0)
									{
										luaTable2[text2] = strike.MaxAircraftToFly_Strikers;
									}
								}
								else if (Operators.CompareString(text2, "StrikeUseFlightSize", false) == 0)
								{
									luaTable2[text2] = strike.UseFlightSizeHardLimit;
								}
							}
							else if (Operators.CompareString(text2, "StrikeAutoPlanner", false) == 0)
							{
								luaTable2[text2] = strike.UseAutoPlanner;
							}
						}
						luaTable["Strike"] = luaTable2;
					}
					return luaTable;
				}
			}
			set
			{
				throw new Exception2("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060069A8 RID: 27048 RVA: 0x0038DAE0 File Offset: 0x0038BCE0
		// (set) Token: 0x060069A9 RID: 27049 RVA: 0x0002D841 File Offset: 0x0002BA41
		[Attribute2]
		public LuaTable cargomission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (this.myMission.MissionClass == Mission._MissionClass.Cargo)
				{
					CargoMission cargoMission = (CargoMission)this.myMission;
					string[] string_ = Class273.string_5;
					for (int i = 0; i < string_.Length; i = checked(i + 1))
					{
						string text = string_[i];
						uint num = Class382.smethod_0(text);
						if (num <= 1723673953u)
						{
							if (num <= 1082283198u)
							{
								if (num != 486744163u)
								{
									if (num == 1082283198u && Operators.CompareString(text, "UseGroupSize", false) == 0)
									{
										luaTable[text] = cargoMission.UseGroupSizeHardLimit;
									}
								}
								else if (Operators.CompareString(text, "UseFlightSize", false) == 0)
								{
									luaTable[text] = cargoMission.UseFlightSizeHardLimit;
								}
							}
							else if (num != 1304453504u)
							{
								if (num == 1723673953u && Operators.CompareString(text, "StationThrottleShip", false) == 0)
								{
									luaTable[text] = cargoMission.StationThrottle_Ship;
								}
							}
							else if (Operators.CompareString(text, "TransitAltitudeAircraft", false) == 0)
							{
								luaTable[text] = cargoMission.TransitAltitude_Aircraft;
							}
						}
						else if (num <= 2895834706u)
						{
							if (num != 2251788647u)
							{
								if (num == 2895834706u && Operators.CompareString(text, "TransitThrottleShip", false) == 0)
								{
									luaTable[text] = cargoMission.TransitThrottle_Ship;
								}
							}
							else if (Operators.CompareString(text, "Zone", false) == 0)
							{
								LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
								int num2 = 1;
								foreach (ReferencePoint current in cargoMission.AreaPoints)
								{
									LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
									luaTable3["name"] = current.Name;
									luaTable2[num2] = luaTable3;
									num2++;
								}
								luaTable[text] = luaTable2;
							}
						}
						else if (num != 3248436129u)
						{
							if (num != 3539526598u)
							{
								if (num == 3853660013u && Operators.CompareString(text, "StationtAltitudeAircraft", false) == 0)
								{
									luaTable[text] = cargoMission.StationAltitude_Aircraft;
								}
							}
							else if (Operators.CompareString(text, "TransitThrottleAircraft", false) == 0)
							{
								luaTable[text] = cargoMission.TransitThrottle_Aircraft;
							}
						}
						else if (Operators.CompareString(text, "StationThrottleAircraft", false) == 0)
						{
							luaTable[text] = cargoMission.StationThrottle_Aircraft;
						}
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception2("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x060069AA RID: 27050 RVA: 0x0038DE00 File Offset: 0x0038C000
		public LuaWrapper_Mission(Mission theMission, Scenario theScen)
		{
			this.myMission = theMission;
			this.ScenarioContext = theScen;
			Side[] sides = this.ScenarioContext.GetSides();
			checked
			{
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					using (IEnumerator<Mission> enumerator = side.GetMissionCollection().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (Operators.CompareString(enumerator.Current.GetGuid(), this.myMission.GetGuid(), false) == 0)
							{
								this.mySide = side;
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x0038DEA4 File Offset: 0x0038C0A4
		[Attribute2]
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"mission {\r\n guid = '",
				this.guid,
				"', \r\n name = '",
				this.name,
				"', \r\n side = '",
				this.side,
				"', \r\n type = '",
				this.type.ToString(),
				"', \r\n subtype = '",
				this.subtype.ToString(),
				"', \r\n isactive = '",
				this.isactive.ToString(),
				"', \r\n starttime = '",
				this.starttime,
				"', \r\n endtime = '",
				this.endtime,
				"', \r\n SISH = '",
				this.SISH.ToString(),
				"', \r\n aar = '",
				this.aar.ToString(),
				"',\r\n unitlist = '",
				this.unitlist.ToString(),
				"',\r\n"
			}) + "}";
		}

		// Token: 0x04003B88 RID: 15240
		private Mission myMission;

		// Token: 0x04003B89 RID: 15241
		private Scenario ScenarioContext;

		// Token: 0x04003B8A RID: 15242
		private Side mySide;
	}
}

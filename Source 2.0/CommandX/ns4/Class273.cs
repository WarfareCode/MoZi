using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns0;
using ns1;
using ns2;
using ns31;

namespace ns4
{
	// Token: 0x02000C17 RID: 3095
	public sealed class Class273
	{
		// Token: 0x06006700 RID: 26368 RVA: 0x0035BA7C File Offset: 0x00359C7C
		public static LuaWrapper_Mission smethod_0(string string_8, string string_9, Scenario scenario_0)
		{
			new List<ReferencePoint>();
			Side side = PrivateMethods.smethod_44(string_8, scenario_0);
			if (side == null)
			{
				throw new Exception2("missing side: " + string_8);
			}
			Mission mission = Class273.smethod_9(string_9, side);
			if (mission == null)
			{
				throw new Exception2("missing mission: " + string_9);
			}
			return new LuaWrapper_Mission(mission, scenario_0);
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x0035BADC File Offset: 0x00359CDC
		public static LuaWrapper_Mission smethod_1(string string_8, string string_9, string string_10, LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			LuaSandBox.Singleton().CreateTable();
			Scenario scenario = scenario_0;
			ActiveUnit activeUnit = null;
			Side side = null;
			List<ReferencePoint> list = new List<ReferencePoint>();
			LuaWrapper_Mission result;
			try
			{
				side = PrivateMethods.smethod_44(string_8, scenario);
				if (side == null)
				{
					throw new Exception2("missing side " + string_8);
				}
				Mission mission = Class273.smethod_9(string_9, side);
				if (!Information.IsNothing(mission))
				{
					throw new Exception2("Existing mission " + string_9);
				}
				string text = null;
				if (objectGeoLocation.ContainsKey("TYPE"))
				{
					text = Conversions.ToString(objectGeoLocation["TYPE"]);
				}
				if (objectGeoLocation.ContainsKey("DESTINATION"))
				{
					activeUnit = PrivateMethods.smethod_46(Conversions.ToString(objectGeoLocation["DESTINATION"]), side);
				}
				if (objectGeoLocation.ContainsKey("ZONE"))
				{
					List<object> list2 = LuaUtility.smethod_0(((LuaTable)objectGeoLocation["ZONE"]).GetEnumerator());
					List<object>.Enumerator enumerator = list2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class273.Class274 @class = new Class273.Class274(null);
							@class.object_0 = RuntimeHelpers.GetObjectValue(enumerator.Current);
							ReferencePoint referencePoint = null;
							if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(@class.method_0))))
							{
								referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(@class.method_1));
							}
							else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(@class.method_2))))
							{
								referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(@class.method_3));
							}
							else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(@class.method_4))))
							{
								referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(@class.method_5));
							}
							else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(@class.method_6))))
							{
								referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(@class.method_7));
							}
							if (!Information.IsNothing(referencePoint))
							{
								list.Add(referencePoint);
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
				}
				if (text == null & (Operators.CompareString(string_10.ToUpper(), "STRIKE", false) == 0 | Operators.CompareString(string_10.ToUpper(), "PATROL", false) == 0))
				{
					throw new Exception2("Missing type of strike/patrol mission");
				}
				string left = string_10.ToUpper();
				uint num = Class382.smethod_0(left);
				if (num <= 922276827u)
				{
					if (num != 324174177u)
					{
						if (num != 809098951u)
						{
							if (num == 922276827u && Operators.CompareString(left, "PATROL", false) == 0)
							{
								string left2 = text.ToUpper();
								num = Class382.smethod_0(left2);
								if (num <= 1970077047u)
								{
									if (num <= 1006726764u)
									{
										if (num != 93149113u)
										{
											if (num != 522735669u)
											{
												if (num == 1006726764u && Operators.CompareString(left2, "SEA", false) == 0)
												{
													mission = new Patrol(side, scenario, string_9, Mission.MissionCategory.Mission, list, GlobalVariables.PatrolType.SeaControl, false);
													goto IL_75C;
												}
												goto IL_541;
											}
											else if (Operators.CompareString(left2, "SUB", false) != 0)
											{
												goto IL_541;
											}
										}
										else
										{
											if (Operators.CompareString(left2, "SUR_MIXED", false) != 0)
											{
												goto IL_541;
											}
											goto IL_408;
										}
									}
									else if (num != 1657064728u)
									{
										if (num != 1890426094u)
										{
											if (num != 1970077047u)
											{
												goto IL_541;
											}
											if (Operators.CompareString(left2, "AIR", false) != 0)
											{
												goto IL_541;
											}
											goto IL_504;
										}
										else if (Operators.CompareString(left2, "ASW", false) != 0)
										{
											goto IL_541;
										}
									}
									else
									{
										if (Operators.CompareString(left2, "MIXED", false) == 0)
										{
											goto IL_408;
										}
										goto IL_541;
									}
									mission = new Patrol(side, scenario, string_9, Mission.MissionCategory.Mission, list, GlobalVariables.PatrolType.ASW, false);
									goto IL_75C;
									IL_408:
									mission = new Patrol(side, scenario, string_9, Mission.MissionCategory.Mission, list, GlobalVariables.PatrolType.ASuW_Mixed, false);
									goto IL_75C;
								}
								if (num > 2872863644u)
								{
									if (num != 3694776191u)
									{
										if (num != 3784749903u)
										{
											if (num != 4132015909u)
											{
												goto IL_541;
											}
											if (Operators.CompareString(left2, "SUR_SEA", false) != 0)
											{
												goto IL_541;
											}
										}
										else
										{
											if (Operators.CompareString(left2, "SUR_LAND", false) == 0)
											{
												goto IL_4DB;
											}
											goto IL_541;
										}
									}
									else if (Operators.CompareString(left2, "NAVAL", false) != 0)
									{
										goto IL_541;
									}
									mission = new Patrol(side, scenario, string_9, Mission.MissionCategory.Mission, list, GlobalVariables.PatrolType.ASuW_Naval, false);
									goto IL_75C;
								}
								if (num != 2655021304u)
								{
									if (num != 2692794592u)
									{
										if (num != 2872863644u || Operators.CompareString(left2, "LAND", false) != 0)
										{
											goto IL_541;
										}
									}
									else
									{
										if (Operators.CompareString(left2, "AAW", false) == 0)
										{
											goto IL_504;
										}
										goto IL_541;
									}
								}
								else
								{
									if (Operators.CompareString(left2, "SEAD", false) == 0)
									{
										mission = new Patrol(side, scenario, string_9, Mission.MissionCategory.Mission, list, GlobalVariables.PatrolType.SEAD, false);
										goto IL_75C;
									}
									goto IL_541;
								}
								IL_4DB:
								mission = new Patrol(side, scenario, string_9, Mission.MissionCategory.Mission, list, GlobalVariables.PatrolType.ASuW_Land, false);
								goto IL_75C;
								IL_504:
								mission = new Patrol(side, scenario, string_9, Mission.MissionCategory.Mission, list, GlobalVariables.PatrolType.AAW, false);
								goto IL_75C;
								IL_541:
								throw new Exception2("missing mission sub-type");
							}
						}
						else if (Operators.CompareString(left, "CARGO", false) == 0)
						{
							mission = new CargoMission(side, scenario, string_9, list, false);
							goto IL_75C;
						}
					}
					else if (Operators.CompareString(left, "MINING", false) == 0)
					{
						mission = new MiningMission(side, scenario, string_9, Mission.MissionCategory.Mission, list, false);
						goto IL_75C;
					}
				}
				else if (num <= 3288198095u)
				{
					if (num != 1998926472u)
					{
						if (num == 3288198095u && Operators.CompareString(left, "STRIKE", false) == 0)
						{
							string left3 = text.ToUpper();
							if (Operators.CompareString(left3, "AIR", false) == 0)
							{
								mission = new Strike(side, scenario, string_9, Mission.MissionCategory.Mission, Strike.StrikeType.Air_Intercept);
								mission.Name = string_9;
								goto IL_75C;
							}
							if (Operators.CompareString(left3, "LAND", false) == 0)
							{
								mission = new Strike(side, scenario, string_9, Mission.MissionCategory.Mission, Strike.StrikeType.Land_Strike);
								mission.Name = string_9;
								goto IL_75C;
							}
							if (Operators.CompareString(left3, "SEA", false) == 0)
							{
								mission = new Strike(side, scenario, string_9, Mission.MissionCategory.Mission, Strike.StrikeType.Maritime_Strike);
								mission.Name = string_9;
								goto IL_75C;
							}
							if (Operators.CompareString(left3, "SUB", false) != 0)
							{
								throw new Exception2("missing mission sub-type");
							}
							mission = new Strike(side, scenario, string_9, Mission.MissionCategory.Mission, Strike.StrikeType.Sub_Strike);
							mission.Name = string_9;
							goto IL_75C;
						}
					}
					else if (Operators.CompareString(left, "SUPPORT", false) == 0)
					{
						mission = new SupportMission(ref side, ref scenario, string_9, Mission.MissionCategory.Mission, ref list, false);
						goto IL_75C;
					}
				}
				else if (num != 3370234609u)
				{
					if (num == 3439695707u && Operators.CompareString(left, "FERRY", false) == 0)
					{
						if (activeUnit == null)
						{
							throw new Exception2("missing destination");
						}
						mission = new FerryMission(side, scenario, string_9, Mission.MissionCategory.Mission, activeUnit);
						goto IL_75C;
					}
				}
				else if (Operators.CompareString(left, "MINECLEARING", false) == 0)
				{
					mission = new MineClearingMission(side, scenario, string_9, Mission.MissionCategory.Mission, list, false);
					goto IL_75C;
				}
				throw new Exception2("missing mission type");
				IL_75C:
				side.AddMission(mission);
				result = new LuaWrapper_Mission(mission, scenario_0);
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

		// Token: 0x06006702 RID: 26370 RVA: 0x0035C2B0 File Offset: 0x0035A4B0
		public static bool smethod_2(string string_8, string string_9, Scenario scenario_0)
		{
			new List<ReferencePoint>();
			Side side = PrivateMethods.smethod_44(string_8, scenario_0);
			if (side == null)
			{
				throw new Exception2("missing side " + string_8);
			}
			Mission mission = Class273.smethod_9(string_9, side);
			if (mission == null)
			{
				throw new Exception2("missing mission " + string_9);
			}
			ActiveUnit[] activeUnitArray = side.ActiveUnitArray;
			checked
			{
				for (int i = 0; i < activeUnitArray.Length; i++)
				{
					ActiveUnit activeUnit = activeUnitArray[i];
					if (Operators.CompareString(activeUnit.GetAssignedMission(false).GetGuid(), mission.GetGuid(), false) == 0)
					{
						activeUnit.DeleteMission(false, null);
					}
				}
				side.RemoveMission(mission);
				return true;
			}
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x0035C358 File Offset: 0x0035A558
		public static LuaTable smethod_3(string string_8, string string_9, Scenario scenario_0)
		{
			Mission mission = null;
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			int num = 1;
			Side side = PrivateMethods.smethod_44(string_8, scenario_0);
			if (side == null)
			{
				throw new Exception2("missing side " + string_8);
			}
			mission = Class273.smethod_9(string_9, side);
			if (Information.IsNothing(mission))
			{
				throw new Exception2("Mission " + string_9 + " not found!");
			}
			if (!Directory.Exists(MyTemplate.GetApp().Info.DirectoryPath + "\\Defaults"))
			{
				Directory.CreateDirectory(MyTemplate.GetApp().Info.DirectoryPath + "\\Defaults");
			}
			FileStream fileStream = File.Create(MyTemplate.GetApp().Info.DirectoryPath + "\\Defaults\\" + string_9 + ".xml");
			XmlWriterSettings settings = new XmlWriterSettings();
			Stream1 stream = new Stream1();
			using (XmlWriter xmlWriter = XmlWriter.Create(stream, settings))
			{
				Mission mission2 = mission;
				XmlWriter xmlWriter2 = xmlWriter;
				HashSet<string> hashSet = null;
				mission2.Save(ref xmlWriter2, ref hashSet, ref scenario_0);
			}
			fileStream.Write(stream.ToArray(), 0, (int)stream.Position);
			fileStream.Close();
			luaTable[num] = mission.GetGuid();
			num++;
			return luaTable;
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x0035C4B0 File Offset: 0x0035A6B0
		public static LuaTable smethod_4(string string_8, string string_9, Scenario scenario_0)
		{
			Side side = null;
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			int num = 1;
			side = PrivateMethods.smethod_44(string_8, scenario_0);
			if (side == null)
			{
				throw new Exception2("missing side " + string_8);
			}
			try
			{
				FileStream fileStream = new FileStream(MyTemplate.GetApp().Info.DirectoryPath + "\\Defaults\\" + string_9 + ".xml", FileMode.Open, FileAccess.Read);
				XmlDocument xmlDocument = new XmlDocument();
				Dictionary<string, Subject> dictionary = new Dictionary<string, Subject>();
				using (fileStream)
				{
					try
					{
						xmlDocument.Load(fileStream);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						Interaction.MsgBox("File is improperly formatted, read failed!", MsgBoxStyle.OkOnly, null);
						ProjectData.ClearProjectError();
					}
				}
				fileStream.Close();
				IEnumerator enumerator = xmlDocument.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode = (XmlNode)enumerator.Current;
						Mission mission = Mission.Load(ref xmlNode, ref dictionary, ref scenario_0);
						if (!Information.IsNothing(mission))
						{
							side.AddMission(mission);
							luaTable[num] = mission.GetGuid();
							num++;
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
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				Interaction.MsgBox("Unable to find directory or file!", MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
			return luaTable;
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x0035C638 File Offset: 0x0035A838
		public static LuaWrapper_Mission smethod_5(string string_8, string string_9, LuaTable luaTable_0, Scenario scenario_0)
		{
			Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(luaTable_0.GetEnumerator());
			LuaSandBox.Singleton().CreateTable();
			Mission mission = null;
			Side side = null;
			List<ReferencePoint> list = new List<ReferencePoint>();
			side = PrivateMethods.smethod_44(string_8, scenario_0);
			if (side == null)
			{
				throw new Exception2("missing side: " + string_8);
			}
			mission = Class273.smethod_9(string_9, side);
			if (mission == null)
			{
				throw new Exception2("missing mission: " + string_9);
			}
			if (objectGeoLocation.ContainsKey("NEWNAME"))
			{
				string name = "";
				try
				{
					name = objectGeoLocation["NEWNAME"].ToString();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("Unable to parse value NewName to string!");
				}
				mission.Name = name;
			}
			if (objectGeoLocation.ContainsKey("SUBTYPE"))
			{
				try
				{
					string text = objectGeoLocation["SUBTYPE"].ToString();
					Mission._MissionClass missionClass = mission.MissionClass;
					if (missionClass != Mission._MissionClass.Strike)
					{
						if (missionClass != Mission._MissionClass.Patrol)
						{
							throw new Exception2("can't change mission sub-type");
						}
						string left = text.ToUpper();
						uint num = Class382.smethod_0(left);
						if (num <= 1970077047u)
						{
							if (num <= 1006726764u)
							{
								if (num != 93149113u)
								{
									if (num != 522735669u)
									{
										if (num == 1006726764u && Operators.CompareString(left, "SEA", false) == 0)
										{
											((Patrol)mission).patrolType = GlobalVariables.PatrolType.SeaControl;
											goto IL_3E2;
										}
										goto IL_345;
									}
									else if (Operators.CompareString(left, "SUB", false) != 0)
									{
										goto IL_345;
									}
								}
								else
								{
									if (Operators.CompareString(left, "SUR_MIXED", false) != 0)
									{
										goto IL_345;
									}
									goto IL_21B;
								}
							}
							else if (num != 1657064728u)
							{
								if (num != 1890426094u)
								{
									if (num != 1970077047u)
									{
										goto IL_345;
									}
									if (Operators.CompareString(left, "AIR", false) != 0)
									{
										goto IL_345;
									}
									goto IL_30E;
								}
								else if (Operators.CompareString(left, "ASW", false) != 0)
								{
									goto IL_345;
								}
							}
							else
							{
								if (Operators.CompareString(left, "MIXED", false) == 0)
								{
									goto IL_21B;
								}
								goto IL_345;
							}
							((Patrol)mission).patrolType = GlobalVariables.PatrolType.ASW;
							goto IL_3E2;
							IL_21B:
							((Patrol)mission).patrolType = GlobalVariables.PatrolType.ASuW_Mixed;
							goto IL_3E2;
						}
						if (num > 2872863644u)
						{
							if (num != 3694776191u)
							{
								if (num != 3784749903u)
								{
									if (num != 4132015909u)
									{
										goto IL_345;
									}
									if (Operators.CompareString(left, "SUR_SEA", false) != 0)
									{
										goto IL_345;
									}
								}
								else
								{
									if (Operators.CompareString(left, "SUR_LAND", false) == 0)
									{
										goto IL_2E8;
									}
									goto IL_345;
								}
							}
							else if (Operators.CompareString(left, "NAVAL", false) != 0)
							{
								goto IL_345;
							}
							((Patrol)mission).patrolType = GlobalVariables.PatrolType.ASuW_Naval;
							goto IL_3E2;
						}
						if (num != 2655021304u)
						{
							if (num != 2692794592u)
							{
								if (num != 2872863644u || Operators.CompareString(left, "LAND", false) != 0)
								{
									goto IL_345;
								}
							}
							else
							{
								if (Operators.CompareString(left, "AAW", false) == 0)
								{
									goto IL_30E;
								}
								goto IL_345;
							}
						}
						else
						{
							if (Operators.CompareString(left, "SEAD", false) == 0)
							{
								((Patrol)mission).patrolType = GlobalVariables.PatrolType.SEAD;
								goto IL_3E2;
							}
							goto IL_345;
						}
						IL_2E8:
						((Patrol)mission).patrolType = GlobalVariables.PatrolType.ASuW_Land;
						goto IL_3E2;
						IL_30E:
						((Patrol)mission).patrolType = GlobalVariables.PatrolType.AAW;
						goto IL_3E2;
						IL_345:
						throw new Exception2("missing mission sub-type");
					}
					else
					{
						string left2 = text.ToUpper();
						if (Operators.CompareString(left2, "AIR", false) != 0)
						{
							if (Operators.CompareString(left2, "LAND", false) != 0)
							{
								if (Operators.CompareString(left2, "SEA", false) != 0)
								{
									if (Operators.CompareString(left2, "SUB", false) != 0)
									{
										throw new Exception2("missing mission sub-type");
									}
									((Strike)mission).strikeType = Strike.StrikeType.Sub_Strike;
								}
								else
								{
									((Strike)mission).strikeType = Strike.StrikeType.Maritime_Strike;
								}
							}
							else
							{
								((Strike)mission).strikeType = Strike.StrikeType.Land_Strike;
							}
						}
						else
						{
							((Strike)mission).strikeType = Strike.StrikeType.Air_Intercept;
						}
					}
					IL_3E2:;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					throw new Exception2("Unable to parse mission subType!");
				}
			}
			if (objectGeoLocation.ContainsKey("use_refuel_unrep".ToUpper()))
			{
				if (Operators.CompareString(Conversions.ToString(objectGeoLocation["use_refuel_unrep".ToUpper()]).ToLower(), "inherit", false) == 0)
				{
					mission.m_Doctrine.SetUseRefuelDoctrine(scenario_0, false, false, false, false, null);
				}
				else
				{
					Doctrine._UseRefuel value;
					if (!Enum.TryParse<Doctrine._UseRefuel>(Conversions.ToString(objectGeoLocation["use_refuel_unrep".ToUpper()]), out value))
					{
						throw new Exception2("Can't understand '" + Conversions.ToString(objectGeoLocation["use_refuel_unrep"]) + "' as use_refuel_unrep allowed values are: '0','1','2' which correspond to Always Excl Tankers, Never, Always Incl Tankers");
					}
					mission.m_Doctrine.SetUseRefuelDoctrine(scenario_0, false, false, false, false, new Doctrine._UseRefuel?(value));
				}
			}
			string[] array = Class273.string_0;
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text2 = array[i];
					text2 = text2.ToUpper();
					string left3 = text2;
					if (Operators.CompareString(left3, "TankerUsage".ToUpper(), false) == 0)
					{
						if (objectGeoLocation.ContainsKey(text2))
						{
							Mission.TankerMethod tankerUsage = Mission.TankerMethod.Automatic;
							if (Enum.TryParse<Mission.TankerMethod>(Conversions.ToString(objectGeoLocation[text2]), out tankerUsage))
							{
								mission.TankerUsage = tankerUsage;
							}
						}
					}
					else if (Operators.CompareString(left3, "LaunchMissionWithoutTankersInPlace".ToUpper(), false) == 0)
					{
						if (objectGeoLocation.ContainsKey(text2) && mission.TankerUsage == Mission.TankerMethod.Mission)
						{
							bool? booleanValue = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectGeoLocation[text2]));
							if (!Information.IsNothing(booleanValue))
							{
								mission.LaunchMissionWithoutTankersInPlace = booleanValue.Value;
							}
						}
					}
					else
					{
						if (Operators.CompareString(left3, "TankerMissionList".ToUpper(), false) == 0)
						{
							if (!objectGeoLocation.ContainsKey(text2) || mission.TankerUsage != Mission.TankerMethod.Mission)
							{
								goto IL_8DE;
							}
							List<object> list2 = LuaUtility.smethod_0(((LuaTable)objectGeoLocation[text2]).GetEnumerator());
							mission.TankerMissionList.Clear();
							List<object>.Enumerator enumerator = list2.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									string text3 = Conversions.ToString(RuntimeHelpers.GetObjectValue(enumerator.Current));
									Mission mission2 = Class273.smethod_8(text3, scenario_0);
									if (!(mission2 == null | Operators.CompareString(mission2.GetGuid(), text3, false) != 0 | mission2.MissionClass != Mission._MissionClass.Support))
									{
										mission.TankerMissionList.Add(mission2);
									}
								}
								goto IL_8DE;
							}
							finally
							{
								IDisposable disposable = enumerator;
								if (disposable != null)
								{
									disposable.Dispose();
								}
							}
						}
						if (Operators.CompareString(left3, "TankerMinNumber_Total".ToUpper(), false) == 0)
						{
							if (objectGeoLocation.ContainsKey(text2) && mission.TankerUsage == Mission.TankerMethod.Mission)
							{
								int tankerMinNumber_Total = Conversions.ToInteger(objectGeoLocation[text2]);
								mission.TankerMinNumber_Total = tankerMinNumber_Total;
							}
						}
						else if (Operators.CompareString(left3, "TankerMinNumber_Airborne".ToUpper(), false) == 0)
						{
							if (objectGeoLocation.ContainsKey(text2) && mission.TankerUsage == Mission.TankerMethod.Mission)
							{
								int tankerMinNumber_Airborne = Conversions.ToInteger(objectGeoLocation[text2]);
								mission.TankerMinNumber_Airborne = tankerMinNumber_Airborne;
							}
						}
						else if (Operators.CompareString(left3, "TankerMinNumber_Station".ToUpper(), false) == 0)
						{
							if (objectGeoLocation.ContainsKey(text2) && mission.TankerUsage == Mission.TankerMethod.Mission)
							{
								int tankerMinNumber_Station = Conversions.ToInteger(objectGeoLocation[text2]);
								mission.TankerMinNumber_Station = tankerMinNumber_Station;
							}
						}
						else if (Operators.CompareString(left3, "MaxReceiversInQueuePerTanker_Airborne".ToUpper(), false) == 0)
						{
							if (objectGeoLocation.ContainsKey(text2))
							{
								int maxReceiversInQueuePerTanker_Airborne = Conversions.ToInteger(objectGeoLocation[text2]);
								mission.MaxReceiversInQueuePerTanker_Airborne = maxReceiversInQueuePerTanker_Airborne;
							}
						}
						else if (Operators.CompareString(left3, "FuelQtyToStartLookingForTanker_Airborne".ToUpper(), false) == 0)
						{
							if (objectGeoLocation.ContainsKey(text2))
							{
								int num2 = Conversions.ToInteger(objectGeoLocation[text2]);
								if (num2 > 0 & num2 < 100)
								{
									mission.FuelQtyToStartLookingForTanker_Airborne = num2;
								}
							}
						}
						else if (Operators.CompareString(left3, "TankerMaxDistance_Airborne".ToUpper(), false) == 0 && objectGeoLocation.ContainsKey(text2))
						{
							int num3;
							if (Operators.CompareString(Conversions.ToString(objectGeoLocation[text2]).ToLower(), "internal", false) == 0)
							{
								num3 = 2147483647;
							}
							else
							{
								num3 = Conversions.ToInteger(objectGeoLocation[text2]);
							}
							int num4 = num3;
							if (num4 < 100)
							{
								num3 = 50;
							}
							else if (num4 < 250)
							{
								num3 = 100;
							}
							else if (num4 < 500)
							{
								num3 = 250;
							}
							else if (num4 < 1000)
							{
								num3 = 500;
							}
							mission.TankerMaxDistance_Airborne = num3;
						}
					}
					IL_8DE:;
				}
				switch (mission.MissionClass)
				{
				case Mission._MissionClass.Strike:
				{
					Strike strike = (Strike)mission;
					string[] array2 = Class273.string_2;
					for (int j = 0; j < array2.Length; j++)
					{
						string text4 = array2[j];
						text4 = text4.ToUpper();
						if (objectGeoLocation.ContainsKey(text4))
						{
							object objectValue = RuntimeHelpers.GetObjectValue(objectGeoLocation[text4]);
							string left4 = text4;
							if (Operators.CompareString(left4, "EscortFlightSizeShooter".ToUpper(), false) == 0)
							{
								Strike strike2 = strike;
								string left5 = Conversions.ToString(objectValue);
								strike2.Escort_FlightSize_Shooter = Class273.smethod_10(ref left5);
							}
							else if (Operators.CompareString(left4, "EscortFlightSizeNonShooter".ToUpper(), false) == 0)
							{
								Strike strike3 = strike;
								string left5 = Conversions.ToString(objectValue);
								strike3.Escort_FlightSize_NonShooter = Class273.smethod_10(ref left5);
							}
							else if (Operators.CompareString(left4, "EscortMaxNonShooter".ToUpper(), false) == 0)
							{
								Strike strike4 = strike;
								string left5 = Conversions.ToString(objectValue);
								strike4.MaxAircraftToFly_Escort_NonShooter = Class273.smethod_11(ref left5);
							}
							else if (Operators.CompareString(left4, "EscortMaxShooter".ToUpper(), false) == 0)
							{
								Strike strike5 = strike;
								string left5 = Conversions.ToString(objectValue);
								strike5.MaxAircraftToFly_Escort_Shooter = Class273.smethod_11(ref left5);
							}
							else if (Operators.CompareString(left4, "EscortMinShooter".ToUpper(), false) == 0)
							{
								Strike strike6 = strike;
								string left5 = Conversions.ToString(objectValue);
								strike6.MinAircraftReq_Escorts_Shooter = Class273.smethod_11(ref left5);
							}
							else if (Operators.CompareString(left4, "EscortMinNonShooter".ToUpper(), false) == 0)
							{
								Strike strike7 = strike;
								string left5 = Conversions.ToString(objectValue);
								strike7.MinAircraftReq_Escorts_NonShooter = Class273.smethod_11(ref left5);
							}
							else if (Operators.CompareString(left4, "EscortResponseRadius".ToUpper(), false) == 0)
							{
								strike.Escort_ResponseRadius = Conversions.ToInteger(objectValue);
							}
							else if (Operators.CompareString(left4, "EscortUseFlightSize".ToUpper(), false) == 0)
							{
								strike.UseFlightSizeHardLimit_Escort = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue)).Value;
							}
							else if (Operators.CompareString(left4, "EscortGroupSize".ToUpper(), false) == 0)
							{
								Strike strike8 = strike;
								string left5 = Conversions.ToString(objectValue);
								strike8.Escort_GroupSize = Class273.smethod_12(ref left5);
							}
							else if (Operators.CompareString(left4, "EscortUseGroupSize".ToUpper(), false) == 0)
							{
								strike.UseGroupSizeHardLimit_Escort = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue)).Value;
							}
							else if (Operators.CompareString(left4, "StrikeOneTimeOnly".ToUpper(), false) == 0)
							{
								strike.OneTimeOnly = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue)).Value;
							}
							else if (Operators.CompareString(left4, "StrikeMinimumTrigger".ToUpper(), false) == 0)
							{
								Strike strike9 = strike;
								string left5 = Conversions.ToString(objectValue);
								strike9.MinimumContactStanceToTrigger = Class273.smethod_13(ref left5);
							}
							else if (Operators.CompareString(left4, "StrikeMax".ToUpper(), false) == 0)
							{
								Strike strike10 = strike;
								string left5 = Conversions.ToString(objectValue);
								strike10.MaxAircraftToFly_Strikers = Class273.smethod_11(ref left5);
							}
							else if (Operators.CompareString(left4, "StrikeMinAircraftReq".ToUpper(), false) == 0)
							{
								Strike strike11 = strike;
								string left5 = Conversions.ToString(objectValue);
								strike11.MinAircraftReq_Strikers = Class273.smethod_11(ref left5);
							}
							else if (Operators.CompareString(left4, "StrikeFlightSize".ToUpper(), false) == 0)
							{
								Mission mission3 = strike;
								string left5 = Conversions.ToString(objectValue);
								mission3.m_FlightSize = Class273.smethod_10(ref left5);
							}
							else if (Operators.CompareString(left4, "StrikeUseFlightSize".ToUpper(), false) == 0)
							{
								strike.UseFlightSizeHardLimit = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue)).Value;
							}
							else if (Operators.CompareString(left4, "StrikeGroupSize".ToUpper(), false) == 0)
							{
								Mission mission4 = strike;
								string left5 = Conversions.ToString(objectValue);
								mission4.m_GroupSize = Class273.smethod_12(ref left5);
							}
							else if (Operators.CompareString(left4, "StrikeUseGroupSize".ToUpper(), false) == 0)
							{
								strike.UseGroupSizeHardLimit = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue)).Value;
							}
							else if (Operators.CompareString(left4, "StrikeAutoPlanner".ToUpper(), false) == 0)
							{
								strike.UseAutoPlanner = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue)).Value;
							}
							else if (Operators.CompareString(left4, "StrikePrePlan".ToUpper(), false) == 0)
							{
								strike.PrePlannedOnly = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue)).Value;
							}
						}
					}
					break;
				}
				case Mission._MissionClass.Patrol:
				{
					Patrol patrol = (Patrol)mission;
					string[] array3 = Class273.string_6;
					for (int k = 0; k < array3.Length; k++)
					{
						string text5 = array3[k];
						text5 = text5.ToUpper();
						if (objectGeoLocation.ContainsKey(text5))
						{
							object objectValue2 = RuntimeHelpers.GetObjectValue(objectGeoLocation[text5]);
							string left5 = text5;
							if (Operators.CompareString(left5, "OneThirdRule".ToUpper(), false) == 0)
							{
								patrol.OTR = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue2)).Value;
							}
							else if (Operators.CompareString(left5, "OnStation".ToUpper(), false) == 0)
							{
								patrol.MNOS = Conversions.ToInteger(objectValue2);
							}
							else if (Operators.CompareString(left5, "CheckOPA".ToUpper(), false) == 0)
							{
								patrol.method_44(scenario_0, LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue2)).Value);
							}
							else if (Operators.CompareString(left5, "CheckWWR".ToUpper(), false) == 0)
							{
								patrol.method_46(scenario_0, LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue2)).Value);
							}
							else if (Operators.CompareString(left5, "ActiveEMCON".ToUpper(), false) == 0)
							{
								patrol.AEOIPA = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue2)).Value;
							}
							else if (Operators.CompareString(left5, "TransitThrottleAircraft".ToUpper(), false) == 0)
							{
								patrol.TransitThrottle_Aircraft = new ActiveUnit.Throttle?(LuaUtility.smethod_22(Conversions.ToString(objectValue2)));
							}
							else if (Operators.CompareString(left5, "TransitAltitudeAircraft".ToUpper(), false) == 0)
							{
								patrol.TransitAltitude_Aircraft = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue2));
							}
							else if (Operators.CompareString(left5, "TransitTerrainFollowingAircraft".ToUpper(), false) == 0)
							{
								patrol.TransitTerrainFollowing_Aircraft = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue2)).Value;
							}
							else if (Operators.CompareString(left5, "StationThrottleAircraft".ToUpper(), false) == 0)
							{
								patrol.StationThrottle_Aircraft = new ActiveUnit.Throttle?(LuaUtility.smethod_22(Conversions.ToString(objectValue2)));
							}
							else if (Operators.CompareString(left5, "StationtAltitudeAircraft".ToUpper(), false) == 0)
							{
								patrol.StationAltitude_Aircraft = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue2));
							}
							else if (Operators.CompareString(left5, "StationTerrainFollowingAircraft".ToUpper(), false) == 0)
							{
								patrol.StationTerrainFollowing_Aircraft = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue2)).Value;
							}
							else if (Operators.CompareString(left5, "AttackThrottleAircraft".ToUpper(), false) == 0)
							{
								patrol.AttackThrottle_Aircraft = new ActiveUnit.Throttle?(LuaUtility.smethod_22(Conversions.ToString(objectValue2)));
							}
							else if (Operators.CompareString(left5, "AttacktAltitudeAircraft".ToUpper(), false) == 0)
							{
								patrol.AttackAltitude_Aircraft = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue2));
							}
							else if (Operators.CompareString(left5, "AttackTerrainFollowingAircraft".ToUpper(), false) == 0)
							{
								patrol.AttackTerrainFollowing_Aircraft = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue2)).Value;
							}
							else if (Operators.CompareString(left5, "AttackDistanceAircraft".ToUpper(), false) == 0)
							{
								int num5 = 0;
								int.TryParse(Conversions.ToString(objectValue2), out num5);
								patrol.AttackDistance_Aircraft = new float?((float)num5);
							}
							else if (Operators.CompareString(left5, "TransitThrottleSubmarine".ToUpper(), false) == 0)
							{
								patrol.TransitThrottle_Submarine = LuaUtility.smethod_22(Conversions.ToString(objectValue2));
							}
							else if (Operators.CompareString(left5, "TransitDepthSubmarine".ToUpper(), false) == 0)
							{
								patrol.TransitDepth_Submarine = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue2));
							}
							else if (Operators.CompareString(left5, "StationThrottleSubmarine".ToUpper(), false) == 0)
							{
								patrol.StationThrottle_Submarine = LuaUtility.smethod_22(Conversions.ToString(objectValue2));
							}
							else if (Operators.CompareString(left5, "StationDepthSubmarine".ToUpper(), false) == 0)
							{
								patrol.StationDepth_Submarine = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue2));
							}
							else if (Operators.CompareString(left5, "AttackThrottleSubmarine".ToUpper(), false) == 0)
							{
								patrol.AttackThrottle_Submarine = new ActiveUnit.Throttle?(LuaUtility.smethod_22(Conversions.ToString(objectValue2)));
							}
							else if (Operators.CompareString(left5, "AttackDepthSubmarine".ToUpper(), false) == 0)
							{
								patrol.AttackDepth_Submarine = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue2));
							}
							else if (Operators.CompareString(left5, "AttackDistanceSubmarine".ToUpper(), false) == 0)
							{
								int num6 = 0;
								int.TryParse(Conversions.ToString(objectValue2), out num6);
								patrol.AttackDistance_Submarine = new float?((float)num6);
							}
							else if (Operators.CompareString(left5, "TransitThrottleShip".ToUpper(), false) == 0)
							{
								patrol.TransitThrottle_Ship = LuaUtility.smethod_22(Conversions.ToString(objectValue2));
							}
							else if (Operators.CompareString(left5, "StationThrottleShip".ToUpper(), false) == 0)
							{
								patrol.StationThrottle_Ship = LuaUtility.smethod_22(Conversions.ToString(objectValue2));
							}
							else if (Operators.CompareString(left5, "AttackThrottleShip".ToUpper(), false) == 0)
							{
								patrol.AttackThrottle_Ship = new ActiveUnit.Throttle?(LuaUtility.smethod_22(Conversions.ToString(objectValue2)));
							}
							else if (Operators.CompareString(left5, "AttackDistanceShip".ToUpper(), false) == 0)
							{
								int num7 = 0;
								int.TryParse(Conversions.ToString(objectValue2), out num7);
								patrol.AttackDistance_Ship = new float?((float)num7);
							}
							else if (Operators.CompareString(left5, "GroupSize".ToUpper(), false) == 0)
							{
								Mission mission5 = patrol;
								string left6 = Conversions.ToString(objectValue2);
								mission5.m_GroupSize = Class273.smethod_12(ref left6);
							}
							else if (Operators.CompareString(left5, "FlightSize".ToUpper(), false) == 0)
							{
								Mission mission6 = patrol;
								string left6 = Conversions.ToString(objectValue2);
								mission6.m_FlightSize = Class273.smethod_10(ref left6);
							}
							else if (Operators.CompareString(left5, "MinAircraftReq".ToUpper(), false) == 0)
							{
								Patrol patrol2 = patrol;
								string left6 = Conversions.ToString(objectValue2);
								patrol2.MinAircraftReq = Class273.smethod_11(ref left6);
							}
							else if (Operators.CompareString(left5, "UseFlightSize".ToUpper(), false) == 0)
							{
								patrol.UseFlightSizeHardLimit = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue2)).Value;
							}
							else if (Operators.CompareString(left5, "UseGroupSize".ToUpper(), false) == 0)
							{
								patrol.UseGroupSizeHardLimit = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue2)).Value;
							}
							else if (Operators.CompareString(left5, "PatrolZone".ToUpper(), false) == 0)
							{
								list.Clear();
								List<object> list3 = LuaUtility.smethod_0(((LuaTable)objectGeoLocation["ZONE"]).GetEnumerator());
								using (List<object>.Enumerator enumerator2 = list3.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										Class273.Class275 @class = new Class273.Class275(null);
										@class.object_0 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
										ReferencePoint referencePoint = null;
										if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(@class.method_0))))
										{
											referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(@class.method_1));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(@class.method_2))))
										{
											referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(@class.method_3));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(@class.method_4))))
										{
											referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(@class.method_5));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(@class.method_6))))
										{
											referencePoint = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(@class.method_7));
										}
										if (!Information.IsNothing(referencePoint))
										{
											list.Add(referencePoint);
										}
									}
								}
								patrol.PatrolAreaVertices = list;
							}
							else if (Operators.CompareString(left5, "ProsecutionZone".ToUpper(), false) == 0)
							{
								list.Clear();
								List<object> list4 = LuaUtility.smethod_0(((LuaTable)objectGeoLocation["ZONE"]).GetEnumerator());
								using (List<object>.Enumerator enumerator3 = list4.GetEnumerator())
								{
									while (enumerator3.MoveNext())
									{
										Class273.Class276 class2 = new Class273.Class276(null);
										class2.object_0 = RuntimeHelpers.GetObjectValue(enumerator3.Current);
										ReferencePoint referencePoint2 = null;
										if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class2.method_0))))
										{
											referencePoint2 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class2.method_1));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class2.method_2))))
										{
											referencePoint2 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class2.method_3));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class2.method_4))))
										{
											referencePoint2 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class2.method_5));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class2.method_6))))
										{
											referencePoint2 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class2.method_7));
										}
										if (!Information.IsNothing(referencePoint2))
										{
											list.Add(referencePoint2);
										}
									}
								}
								patrol.ProsecutionAreaVertices = list;
							}
						}
					}
					break;
				}
				case Mission._MissionClass.Support:
				{
					SupportMission supportMission = (SupportMission)mission;
					string[] array4 = Class273.string_1;
					for (int l = 0; l < array4.Length; l++)
					{
						string text6 = array4[l];
						text6 = text6.ToUpper();
						if (objectGeoLocation.ContainsKey(text6))
						{
							object objectValue3 = RuntimeHelpers.GetObjectValue(objectGeoLocation[text6]);
							string left6 = text6;
							if (Operators.CompareString(left6, "LoopType".ToUpper(), false) == 0)
							{
								SupportMission._NLT nLT = SupportMission._NLT.const_0;
								if (Enum.TryParse<SupportMission._NLT>(Conversions.ToString(objectValue3), out nLT))
								{
									supportMission.NLT = nLT;
								}
							}
							else if (Operators.CompareString(left6, "OneTimeOnly".ToUpper(), false) == 0)
							{
								supportMission.OTO = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue3)).Value;
							}
							else if (Operators.CompareString(left6, "OneThirdRule".ToUpper(), false) == 0)
							{
								supportMission.OTR = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue3)).Value;
							}
							else if (Operators.CompareString(left6, "ActiveEMCON".ToUpper(), false) == 0)
							{
								supportMission.AEOOS = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue3)).Value;
							}
							else if (Operators.CompareString(left6, "TankerOneTime".ToUpper(), false) == 0)
							{
								supportMission.A2AR_OneTankingCycleOnly = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue3)).Value;
							}
							else if (Operators.CompareString(left6, "TankerMaxReceivers".ToUpper(), false) == 0)
							{
								supportMission.A2AR_MaxNumberOfReceiversPerTanker = Conversions.ToInteger(objectValue3);
							}
							else if (Operators.CompareString(left6, "OnStation".ToUpper(), false) == 0)
							{
								supportMission.MNOS = Conversions.ToInteger(objectValue3);
							}
							else if (Operators.CompareString(left6, "TransitThrottleAircraft".ToUpper(), false) == 0)
							{
								supportMission.TransitThrottle_Aircraft = new ActiveUnit.Throttle?(LuaUtility.smethod_22(Conversions.ToString(objectValue3)));
							}
							else if (Operators.CompareString(left6, "TransitAltitudeAircraft".ToUpper(), false) == 0)
							{
								supportMission.TransitAltitude_Aircraft = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue3));
							}
							else if (Operators.CompareString(left6, "TransitTerrainFollowingAircraft".ToUpper(), false) == 0)
							{
								supportMission.TransitTerrainFollowing_Aircraft = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue3)).Value;
							}
							else if (Operators.CompareString(left6, "StationThrottleAircraft".ToUpper(), false) == 0)
							{
								supportMission.StationThrottle_Aircraft = new ActiveUnit.Throttle?(LuaUtility.smethod_22(Conversions.ToString(objectValue3)));
							}
							else if (Operators.CompareString(left6, "StationtAltitudeAircraft".ToUpper(), false) == 0)
							{
								supportMission.StationAltitude_Aircraft = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue3));
							}
							else if (Operators.CompareString(left6, "StationTerrainFollowingAircraft".ToUpper(), false) == 0)
							{
								supportMission.StationTerrainFollowing_Aircraft = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue3)).Value;
							}
							else if (Operators.CompareString(left6, "TransitThrottleSubmarine".ToUpper(), false) == 0)
							{
								supportMission.TransitThrottle_Submarine = LuaUtility.smethod_22(Conversions.ToString(objectValue3));
							}
							else if (Operators.CompareString(left6, "TransitDepthSubmarine".ToUpper(), false) == 0)
							{
								supportMission.TransitDepth_Submarine = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue3));
							}
							else if (Operators.CompareString(left6, "StationThrottleSubmarine".ToUpper(), false) == 0)
							{
								supportMission.StationThrottle_Submarine = LuaUtility.smethod_22(Conversions.ToString(objectValue3));
							}
							else if (Operators.CompareString(left6, "StationDepthSubmarine".ToUpper(), false) == 0)
							{
								supportMission.StationDepth_Submarine = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue3));
							}
							else if (Operators.CompareString(left6, "TransitThrottleShip".ToUpper(), false) == 0)
							{
								supportMission.TransitThrottle_Ship = LuaUtility.smethod_22(Conversions.ToString(objectValue3));
							}
							else if (Operators.CompareString(left6, "StationThrottleShip".ToUpper(), false) == 0)
							{
								supportMission.StationThrottle_Ship = LuaUtility.smethod_22(Conversions.ToString(objectValue3));
							}
							else if (Operators.CompareString(left6, "GroupSize".ToUpper(), false) == 0)
							{
								Mission mission7 = supportMission;
								string left7 = Conversions.ToString(objectValue3);
								mission7.m_GroupSize = Class273.smethod_12(ref left7);
							}
							else if (Operators.CompareString(left6, "FlightSize".ToUpper(), false) == 0)
							{
								Mission mission8 = supportMission;
								string left7 = Conversions.ToString(objectValue3);
								mission8.m_FlightSize = Class273.smethod_10(ref left7);
							}
							else if (Operators.CompareString(left6, "MinAircraftReq".ToUpper(), false) == 0)
							{
								SupportMission supportMission2 = supportMission;
								string left7 = Conversions.ToString(objectValue3);
								supportMission2.MinAircraftReq = Class273.smethod_11(ref left7);
							}
							else if (Operators.CompareString(left6, "UseFlightSize".ToUpper(), false) == 0)
							{
								supportMission.UseFlightSizeHardLimit = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue3)).Value;
							}
							else if (Operators.CompareString(left6, "UseGroupSize".ToUpper(), false) == 0)
							{
								supportMission.UseGroupSizeHardLimit = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue3)).Value;
							}
							else if (Operators.CompareString(left6, "Zone".ToUpper(), false) == 0)
							{
								list.Clear();
								List<object> list5 = LuaUtility.smethod_0(((LuaTable)objectGeoLocation["ZONE"]).GetEnumerator());
								using (List<object>.Enumerator enumerator4 = list5.GetEnumerator())
								{
									while (enumerator4.MoveNext())
									{
										Class273.Class277 class3 = new Class273.Class277(null);
										class3.object_0 = RuntimeHelpers.GetObjectValue(enumerator4.Current);
										ReferencePoint referencePoint3 = null;
										if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class3.method_0))))
										{
											referencePoint3 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class3.method_1));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class3.method_2))))
										{
											referencePoint3 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class3.method_3));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class3.method_4))))
										{
											referencePoint3 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class3.method_5));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class3.method_6))))
										{
											referencePoint3 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class3.method_7));
										}
										if (!Information.IsNothing(referencePoint3))
										{
											list.Add(referencePoint3);
										}
									}
								}
								supportMission.NavigationCourseReferencePoints = list;
							}
						}
					}
					break;
				}
				case Mission._MissionClass.Ferry:
				{
					FerryMission ferryMission = (FerryMission)mission;
					string[] array5 = Class273.string_7;
					for (int m = 0; m < array5.Length; m++)
					{
						string text7 = array5[m];
						text7 = text7.ToUpper();
						if (objectGeoLocation.ContainsKey(text7))
						{
							object objectValue4 = RuntimeHelpers.GetObjectValue(objectGeoLocation[text7]);
							string left7 = text7;
							if (Operators.CompareString(left7, "FerryBehavior".ToUpper(), false) == 0)
							{
								FerryMission.FerryMissionBehavior ferryMissionBehavior = FerryMission.FerryMissionBehavior.OneWay;
								if (Enum.TryParse<FerryMission.FerryMissionBehavior>(Conversions.ToString(objectGeoLocation[Conversions.ToString(objectValue4)]), out ferryMissionBehavior))
								{
									ferryMission.SetFerryMissionBehavior(ferryMissionBehavior);
								}
							}
							else if (Operators.CompareString(left7, "FerryThrottleAircraft".ToUpper(), false) == 0)
							{
								ferryMission.FerryThrottle_Aircraft = new ActiveUnit.Throttle?(LuaUtility.smethod_22(Conversions.ToString(objectValue4)));
							}
							else if (Operators.CompareString(left7, "FerryAltitudeAircraft".ToUpper(), false) == 0)
							{
								ferryMission.FerryAltitude_Aircraft = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue4));
							}
							else if (Operators.CompareString(left7, "FerryTerrainFollowingAircraft".ToUpper(), false) == 0)
							{
								ferryMission.FerryTerrainFollowing_Aircraft = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue4)).Value;
							}
							else if (Operators.CompareString(left7, "FlightSize".ToUpper(), false) == 0)
							{
								Mission mission9 = ferryMission;
								string left8 = Conversions.ToString(objectValue4);
								mission9.m_FlightSize = Class273.smethod_10(ref left8);
							}
							else if (Operators.CompareString(left7, "MinAircraftReq".ToUpper(), false) == 0)
							{
								FerryMission ferryMission2 = ferryMission;
								string left8 = Conversions.ToString(objectValue4);
								ferryMission2.MinAircraftReq = Class273.smethod_11(ref left8);
							}
							else if (Operators.CompareString(left7, "UseFlightSize".ToUpper(), false) == 0)
							{
								ferryMission.UseFlightSizeHardLimit = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue4)).Value;
							}
						}
					}
					break;
				}
				case Mission._MissionClass.Mining:
				{
					MiningMission miningMission = (MiningMission)mission;
					string[] array6 = Class273.string_4;
					for (int n = 0; n < array6.Length; n++)
					{
						string text8 = array6[n];
						text8 = text8.ToUpper();
						if (objectGeoLocation.ContainsKey(text8))
						{
							object objectValue5 = RuntimeHelpers.GetObjectValue(objectGeoLocation[text8]);
							string left8 = text8;
							if (Operators.CompareString(left8, "OneThirdRule".ToUpper(), false) == 0)
							{
								miningMission.bOTR = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue5)).Value;
							}
							else if (Operators.CompareString(left8, "ArmingDelay".ToUpper(), false) == 0)
							{
								miningMission.AD = LuaUtility.smethod_28(Conversions.ToString(objectValue5));
							}
							else if (Operators.CompareString(left8, "TransitThrottleAircraft".ToUpper(), false) == 0)
							{
								miningMission.TransitThrottle_Aircraft = new ActiveUnit.Throttle?(LuaUtility.smethod_22(Conversions.ToString(objectValue5)));
							}
							else if (Operators.CompareString(left8, "TransitAltitudeAircraft".ToUpper(), false) == 0)
							{
								miningMission.TransitAltitude_Aircraft = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue5));
							}
							else if (Operators.CompareString(left8, "TransitTerrainFollowingAircraft".ToUpper(), false) == 0)
							{
								miningMission.TransitTerrainFollowing_Aircraft = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue5)).Value;
							}
							else if (Operators.CompareString(left8, "StationThrottleAircraft".ToUpper(), false) == 0)
							{
								miningMission.StationThrottle_Aircraft = new ActiveUnit.Throttle?(LuaUtility.smethod_22(Conversions.ToString(objectValue5)));
							}
							else if (Operators.CompareString(left8, "StationtAltitudeAircraft".ToUpper(), false) == 0)
							{
								miningMission.StationAltitude_Aircraft = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue5));
							}
							else if (Operators.CompareString(left8, "StationTerrainFollowingAircraft".ToUpper(), false) == 0)
							{
								miningMission.StationTerrainFollowing_Aircraft = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue5)).Value;
							}
							else if (Operators.CompareString(left8, "TransitThrottleSubmarine".ToUpper(), false) == 0)
							{
								miningMission.TransitThrottle_Submarine = LuaUtility.smethod_22(Conversions.ToString(objectValue5));
							}
							else if (Operators.CompareString(left8, "TransitDepthSubmarine".ToUpper(), false) == 0)
							{
								miningMission.TransitDepth_Submarine = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue5));
							}
							else if (Operators.CompareString(left8, "StationThrottleSubmarine".ToUpper(), false) == 0)
							{
								miningMission.StationThrottle_Submarine = LuaUtility.smethod_22(Conversions.ToString(objectValue5));
							}
							else if (Operators.CompareString(left8, "StationDepthSubmarine".ToUpper(), false) == 0)
							{
								miningMission.StationDepth_Submarine = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue5));
							}
							else if (Operators.CompareString(left8, "TransitThrottleShip".ToUpper(), false) == 0)
							{
								miningMission.TransitThrottle_Ship = LuaUtility.smethod_22(Conversions.ToString(objectValue5));
							}
							else if (Operators.CompareString(left8, "StationThrottleShip".ToUpper(), false) == 0)
							{
								miningMission.StationThrottle_Ship = LuaUtility.smethod_22(Conversions.ToString(objectValue5));
							}
							else if (Operators.CompareString(left8, "GroupSize".ToUpper(), false) == 0)
							{
								Mission mission10 = miningMission;
								string left9 = Conversions.ToString(objectValue5);
								mission10.m_GroupSize = Class273.smethod_12(ref left9);
							}
							else if (Operators.CompareString(left8, "FlightSize".ToUpper(), false) == 0)
							{
								Mission mission11 = miningMission;
								string left9 = Conversions.ToString(objectValue5);
								mission11.m_FlightSize = Class273.smethod_10(ref left9);
							}
							else if (Operators.CompareString(left8, "MinAircraftReq".ToUpper(), false) == 0)
							{
								MiningMission miningMission2 = miningMission;
								string left9 = Conversions.ToString(objectValue5);
								miningMission2.MinAircraftReq = Class273.smethod_11(ref left9);
							}
							else if (Operators.CompareString(left8, "UseFlightSize".ToUpper(), false) == 0)
							{
								miningMission.UseFlightSizeHardLimit = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue5)).Value;
							}
							else if (Operators.CompareString(left8, "UseGroupSize".ToUpper(), false) == 0)
							{
								miningMission.UseGroupSizeHardLimit = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue5)).Value;
							}
							else if (Operators.CompareString(left8, "Zone".ToUpper(), false) == 0)
							{
								list.Clear();
								List<object> list6 = LuaUtility.smethod_0(((LuaTable)objectGeoLocation["ZONE"]).GetEnumerator());
								using (List<object>.Enumerator enumerator5 = list6.GetEnumerator())
								{
									while (enumerator5.MoveNext())
									{
										Class273.Class278 class4 = new Class273.Class278(null);
										class4.object_0 = RuntimeHelpers.GetObjectValue(enumerator5.Current);
										ReferencePoint referencePoint4 = null;
										if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class4.method_0))))
										{
											referencePoint4 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class4.method_1));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class4.method_2))))
										{
											referencePoint4 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class4.method_3));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class4.method_4))))
										{
											referencePoint4 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class4.method_5));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class4.method_6))))
										{
											referencePoint4 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class4.method_7));
										}
										if (!Information.IsNothing(referencePoint4))
										{
											list.Add(referencePoint4);
										}
									}
								}
								miningMission.AreaVertices = list;
							}
						}
					}
					break;
				}
				case Mission._MissionClass.MineClearing:
				{
					MineClearingMission mineClearingMission = (MineClearingMission)mission;
					string[] array7 = Class273.string_5;
					for (int num8 = 0; num8 < array7.Length; num8++)
					{
						string text9 = array7[num8];
						text9 = text9.ToUpper();
						if (objectGeoLocation.ContainsKey(text9))
						{
							object objectValue6 = RuntimeHelpers.GetObjectValue(objectGeoLocation[text9]);
							string left9 = text9;
							if (Operators.CompareString(left9, "OneThirdRule".ToUpper(), false) == 0)
							{
								mineClearingMission.OTR = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue6)).Value;
							}
							else if (Operators.CompareString(left9, "TransitThrottleAircraft".ToUpper(), false) == 0)
							{
								mineClearingMission.TransitThrottle_Aircraft = new ActiveUnit.Throttle?(LuaUtility.smethod_22(Conversions.ToString(objectValue6)));
							}
							else if (Operators.CompareString(left9, "TransitAltitudeAircraft".ToUpper(), false) == 0)
							{
								mineClearingMission.TransitAltitude_Aircraft = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue6));
							}
							else if (Operators.CompareString(left9, "TransitTerrainFollowingAircraft".ToUpper(), false) == 0)
							{
								mineClearingMission.TransitTerrainFollowing_Aircraft = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue6)).Value;
							}
							else if (Operators.CompareString(left9, "StationThrottleAircraft".ToUpper(), false) == 0)
							{
								mineClearingMission.StationThrottle_Aircraft = new ActiveUnit.Throttle?(LuaUtility.smethod_22(Conversions.ToString(objectValue6)));
							}
							else if (Operators.CompareString(left9, "StationtAltitudeAircraft".ToUpper(), false) == 0)
							{
								mineClearingMission.StationAltitude_Aircraft = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue6));
							}
							else if (Operators.CompareString(left9, "StationTerrainFollowingAircraft".ToUpper(), false) == 0)
							{
								mineClearingMission.StationTerrainFollowing_Aircraft = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue6)).Value;
							}
							else if (Operators.CompareString(left9, "TransitThrottleSubmarine".ToUpper(), false) == 0)
							{
								mineClearingMission.TransitThrottle_Submarine = LuaUtility.smethod_22(Conversions.ToString(objectValue6));
							}
							else if (Operators.CompareString(left9, "TransitDepthSubmarine".ToUpper(), false) == 0)
							{
								mineClearingMission.TransitDepth_Submarine = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue6));
							}
							else if (Operators.CompareString(left9, "StationThrottleSubmarine".ToUpper(), false) == 0)
							{
								mineClearingMission.StationThrottle_Submarine = LuaUtility.smethod_22(Conversions.ToString(objectValue6));
							}
							else if (Operators.CompareString(left9, "StationDepthSubmarine".ToUpper(), false) == 0)
							{
								mineClearingMission.StationDepth_Submarine = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue6));
							}
							else if (Operators.CompareString(left9, "TransitThrottleShip".ToUpper(), false) == 0)
							{
								mineClearingMission.TransitThrottle_Ship = LuaUtility.smethod_22(Conversions.ToString(objectValue6));
							}
							else if (Operators.CompareString(left9, "StationThrottleShip".ToUpper(), false) == 0)
							{
								mineClearingMission.StationThrottle_Ship = LuaUtility.smethod_22(Conversions.ToString(objectValue6));
							}
							else if (Operators.CompareString(left9, "FlightSize".ToUpper(), false) == 0)
							{
								Mission mission12 = mineClearingMission;
								string left10 = Conversions.ToString(objectValue6);
								mission12.m_FlightSize = Class273.smethod_10(ref left10);
							}
							else if (Operators.CompareString(left9, "MinAircraftReq".ToUpper(), false) == 0)
							{
								MineClearingMission mineClearingMission2 = mineClearingMission;
								string left10 = Conversions.ToString(objectValue6);
								mineClearingMission2.MinAircraftReq = Class273.smethod_11(ref left10);
							}
							else if (Operators.CompareString(left9, "UseFlightSize".ToUpper(), false) == 0)
							{
								mineClearingMission.UseFlightSizeHardLimit = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue6)).Value;
							}
							else if (Operators.CompareString(left9, "UseGroupSize".ToUpper(), false) == 0)
							{
								mineClearingMission.UseGroupSizeHardLimit = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue6)).Value;
							}
							else if (Operators.CompareString(left9, "Zone".ToUpper(), false) == 0)
							{
								list.Clear();
								List<object> list7 = LuaUtility.smethod_0(((LuaTable)objectGeoLocation["ZONE"]).GetEnumerator());
								using (List<object>.Enumerator enumerator6 = list7.GetEnumerator())
								{
									while (enumerator6.MoveNext())
									{
										Class273.Class279 class5 = new Class273.Class279(null);
										class5.object_0 = RuntimeHelpers.GetObjectValue(enumerator6.Current);
										ReferencePoint referencePoint5 = null;
										if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class5.method_0))))
										{
											referencePoint5 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class5.method_1));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class5.method_2))))
										{
											referencePoint5 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class5.method_3));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class5.method_4))))
										{
											referencePoint5 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class5.method_5));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class5.method_6))))
										{
											referencePoint5 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class5.method_7));
										}
										if (!Information.IsNothing(referencePoint5))
										{
											list.Add(referencePoint5);
										}
									}
								}
								mineClearingMission.AreaVertices = list;
							}
						}
					}
					break;
				}
				case Mission._MissionClass.Cargo:
				{
					CargoMission cargoMission = (CargoMission)mission;
					string[] array8 = Class273.string_3;
					for (int num9 = 0; num9 < array8.Length; num9++)
					{
						string text10 = array8[num9];
						text10 = text10.ToUpper();
						if (objectGeoLocation.ContainsKey(text10))
						{
							object objectValue7 = RuntimeHelpers.GetObjectValue(objectGeoLocation[text10]);
							string left10 = text10;
							if (Operators.CompareString(left10, "TransitThrottleAircraft".ToUpper(), false) == 0)
							{
								cargoMission.TransitThrottle_Aircraft = LuaUtility.smethod_22(Conversions.ToString(objectValue7));
							}
							else if (Operators.CompareString(left10, "TransitAltitudeAircraft".ToUpper(), false) == 0)
							{
								cargoMission.TransitAltitude_Aircraft = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue7)).Value;
							}
							else if (Operators.CompareString(left10, "StationThrottleAircraft".ToUpper(), false) == 0)
							{
								cargoMission.StationThrottle_Aircraft = LuaUtility.smethod_22(Conversions.ToString(objectValue7));
							}
							else if (Operators.CompareString(left10, "StationtAltitudeAircraft".ToUpper(), false) == 0)
							{
								cargoMission.StationAltitude_Aircraft = LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(objectValue7)).Value;
							}
							else if (Operators.CompareString(left10, "UseFlightSize".ToUpper(), false) == 0)
							{
								cargoMission.UseFlightSizeHardLimit = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue7)).Value;
							}
							else if (Operators.CompareString(left10, "TransitThrottleShip".ToUpper(), false) == 0)
							{
								cargoMission.TransitThrottle_Ship = LuaUtility.smethod_22(Conversions.ToString(objectValue7));
							}
							else if (Operators.CompareString(left10, "StationThrottleShip".ToUpper(), false) == 0)
							{
								cargoMission.StationThrottle_Ship = LuaUtility.smethod_22(Conversions.ToString(objectValue7));
							}
							else if (Operators.CompareString(left10, "UseGroupSize".ToUpper(), false) == 0)
							{
								cargoMission.UseGroupSizeHardLimit = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(objectValue7)).Value;
							}
							else if (Operators.CompareString(left10, "Zone".ToUpper(), false) == 0)
							{
								list.Clear();
								List<object> list8 = LuaUtility.smethod_0(((LuaTable)objectGeoLocation["ZONE"]).GetEnumerator());
								using (List<object>.Enumerator enumerator7 = list8.GetEnumerator())
								{
									while (enumerator7.MoveNext())
									{
										Class273.Class280 class6 = new Class273.Class280(null);
										class6.object_0 = RuntimeHelpers.GetObjectValue(enumerator7.Current);
										ReferencePoint referencePoint6 = null;
										if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class6.method_0))))
										{
											referencePoint6 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class6.method_1));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class6.method_2))))
										{
											referencePoint6 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class6.method_3));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class6.method_4))))
										{
											referencePoint6 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class6.method_5));
										}
										else if (!Information.IsNothing(side.GetReferencePoints().FirstOrDefault(new Func<ReferencePoint, bool>(class6.method_6))))
										{
											referencePoint6 = side.GetReferencePoints().First(new Func<ReferencePoint, bool>(class6.method_7));
										}
										if (!Information.IsNothing(referencePoint6))
										{
											list.Add(referencePoint6);
										}
									}
								}
								cargoMission.AreaPoints = list;
							}
						}
					}
					break;
				}
				}
				return new LuaWrapper_Mission(mission, scenario_0);
			}
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x0035F784 File Offset: 0x0035D984
		public static LuaTable smethod_6(object object_0, string string_8, Scenario scenario_0, ActiveUnit activeUnit_0)
		{
			Unit unit = null;
			Mission mission = null;
			Side side = null;
			string text = null;
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
			int num = 1;
			LuaTable luaTable3;
			LuaTable result;
			if (object_0 is string)
			{
				text = Conversions.ToString(object_0);
			}
			else
			{
				if (!(object_0 is LuaTable))
				{
					luaTable3 = luaTable2;
					result = luaTable3;
					return result;
				}
				luaTable = (LuaTable)object_0;
			}
			if (Operators.CompareString(text, "UnitX", false) == 0)
			{
				if (!Information.IsNothing(activeUnit_0))
				{
					unit = activeUnit_0;
				}
			}
			else if (!Information.IsNothing(text))
			{
				unit = PrivateMethods.smethod_45(text, scenario_0);
				if (unit == null)
				{
					unit = PrivateMethods.smethod_47(text, scenario_0);
					if (unit == null)
					{
						luaTable3 = luaTable2;
						result = luaTable3;
						return result;
					}
				}
			}
			mission = Class273.smethod_8(string_8, scenario_0);
			if (mission == null)
			{
				luaTable3 = luaTable2;
			}
			else if (mission.MissionClass != Mission._MissionClass.Strike)
			{
				luaTable3 = luaTable2;
			}
			else
			{
				Side[] sides = scenario_0.GetSides();
				List<object> list;
				checked
				{
					for (int i = 0; i < sides.Length; i++)
					{
						Side side2 = sides[i];
						using (IEnumerator<Mission> enumerator = side2.GetMissionCollection().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (Operators.CompareString(enumerator.Current.GetGuid(), mission.GetGuid(), false) == 0)
								{
									side = side2;
									break;
								}
							}
						}
					}
					if (!Information.IsNothing(text))
					{
						luaTable[num] = unit.GetGuid();
					}
					list = LuaUtility.smethod_0(luaTable.GetEnumerator());
				}
				using (List<object>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
						if (objectValue is string)
						{
							string text2 = Conversions.ToString(objectValue);
							unit = PrivateMethods.smethod_45(text2, scenario_0);
							if (unit == null)
							{
								unit = PrivateMethods.smethod_47(text2, scenario_0);
								if (unit == null)
								{
									continue;
								}
							}
							if (mission.MissionClass == Mission._MissionClass.Strike && unit.GetSide(false) != side && !side.IsFriendlyToSide(unit.GetSide(false)))
							{
								if (unit.IsGroup)
								{
									bool flag = false;
									foreach (ActiveUnit current in ((Group)unit).GetUnitsInGroup().Values)
									{
										if (((Strike)mission).SpecificTargets.Add(current))
										{
											luaTable2[num] = current.GetGuid();
											num++;
											flag = true;
										}
									}
									if (flag)
									{
									}
								}
								else if (unit.IsActiveUnit())
								{
									if (((Strike)mission).SpecificTargets.Add(unit))
									{
										luaTable2[num] = unit.GetGuid();
										num++;
									}
								}
								else
								{
									Contact contact = (Contact)unit;
									if (!Information.IsNothing(contact.ActualUnit) && side.GetContactsObDictionary().ContainsKey(contact.ActualUnit.GetGuid()))
									{
										using (IEnumerator<ActiveUnit> enumerator4 = ((Group)contact.ActualUnit).GetUnitsInGroup().Values.GetEnumerator())
										{
											while (enumerator4.MoveNext())
											{
												ActiveUnit current2 = enumerator4.Current;
												if (((Strike)mission).SpecificTargets.Add(current2))
												{
													luaTable2[num] = current2.GetGuid();
													num++;
												}
											}
											continue;
										}
									}
									if (!side.GetContactsObDictionary().ContainsKey(contact.ActualUnit.GetGuid()) && ((Strike)mission).SpecificTargets.Add(contact))
									{
										luaTable2[num] = unit.GetGuid();
										num++;
									}
								}
							}
						}
					}
				}
				luaTable3 = luaTable2;
			}
			result = luaTable3;
			return result;
		}

		// Token: 0x06006707 RID: 26375 RVA: 0x0035FBEC File Offset: 0x0035DDEC
		public static LuaTable smethod_7(object object_0, string string_8, Scenario scenario_0, ActiveUnit activeUnit_0)
		{
			Unit unit = null;
			Mission mission = null;
			Side side = null;
			string text = null;
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
			int num = 1;
			LuaTable luaTable3;
			LuaTable result;
			if (object_0 is string)
			{
				text = Conversions.ToString(object_0);
			}
			else
			{
				if (!(object_0 is LuaTable))
				{
					luaTable3 = luaTable2;
					result = luaTable3;
					return result;
				}
				luaTable = (LuaTable)object_0;
			}
			if (Operators.CompareString(text, "UnitX", false) == 0)
			{
				if (!Information.IsNothing(activeUnit_0))
				{
					unit = activeUnit_0;
				}
			}
			else if (!Information.IsNothing(text))
			{
				unit = PrivateMethods.smethod_45(text, scenario_0);
				if (unit == null)
				{
					unit = PrivateMethods.smethod_47(text, scenario_0);
					if (unit == null)
					{
						luaTable3 = luaTable2;
						result = luaTable3;
						return result;
					}
				}
			}
			mission = Class273.smethod_8(string_8, scenario_0);
			if (mission == null)
			{
				luaTable3 = luaTable2;
			}
			else if (mission.MissionClass != Mission._MissionClass.Strike)
			{
				luaTable3 = luaTable2;
			}
			else
			{
				Side[] sides = scenario_0.GetSides();
				List<object> list;
				checked
				{
					for (int i = 0; i < sides.Length; i++)
					{
						Side side2 = sides[i];
						using (IEnumerator<Mission> enumerator = side2.GetMissionCollection().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (Operators.CompareString(enumerator.Current.GetGuid(), mission.GetGuid(), false) == 0)
								{
									side = side2;
									break;
								}
							}
						}
					}
					if (!Information.IsNothing(text))
					{
						luaTable[num] = unit.GetGuid();
					}
					list = LuaUtility.smethod_0(luaTable.GetEnumerator());
				}
				using (List<object>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
						if (objectValue is string)
						{
							string text2 = Conversions.ToString(objectValue);
							unit = PrivateMethods.smethod_45(text2, scenario_0);
							if (unit == null)
							{
								unit = PrivateMethods.smethod_47(text2, scenario_0);
								if (unit == null)
								{
									continue;
								}
							}
							if (mission.MissionClass == Mission._MissionClass.Strike && unit.GetSide(false) != side && !side.IsFriendlyToSide(unit.GetSide(false)))
							{
								if (unit.IsGroup)
								{
									using (IEnumerator<ActiveUnit> enumerator3 = ((Group)unit).GetUnitsInGroup().Values.GetEnumerator())
									{
										while (enumerator3.MoveNext())
										{
											ActiveUnit current = enumerator3.Current;
											if (((Strike)mission).SpecificTargets.Remove(current))
											{
												luaTable2[num] = current.GetGuid();
												num++;
											}
										}
										continue;
									}
								}
								if (unit.IsActiveUnit())
								{
									if (((Strike)mission).SpecificTargets.Remove(unit))
									{
										luaTable2[num] = unit.GetGuid();
										num++;
									}
								}
								else
								{
									Contact contact = (Contact)unit;
									if (!Information.IsNothing(contact.ActualUnit) && side.GetContactsObDictionary().ContainsKey(contact.ActualUnit.GetGuid()))
									{
										using (IEnumerator<ActiveUnit> enumerator4 = ((Group)contact.ActualUnit).GetUnitsInGroup().Values.GetEnumerator())
										{
											while (enumerator4.MoveNext())
											{
												ActiveUnit current2 = enumerator4.Current;
												if (((Strike)mission).SpecificTargets.Remove(current2))
												{
													luaTable2[num] = current2.GetGuid();
													num++;
												}
											}
											continue;
										}
									}
									if (!side.GetContactsObDictionary().ContainsKey(contact.ActualUnit.GetGuid()) && ((Strike)mission).SpecificTargets.Remove(contact))
									{
										luaTable2[num] = unit.GetGuid();
										num++;
									}
								}
							}
						}
					}
				}
				luaTable3 = luaTable2;
			}
			result = luaTable3;
			return result;
		}

		// Token: 0x06006708 RID: 26376 RVA: 0x00360040 File Offset: 0x0035E240
		public static Mission smethod_8(string string_8, Scenario scenario_0)
		{
			Mission mission = null;
			Side[] sides = scenario_0.GetSides();
			checked
			{
				Mission mission2;
				Mission result;
				for (int i = 0; i < sides.Length; i++)
				{
					Side side = sides[i];
					foreach (Mission current in side.GetMissionCollection())
					{
						if (Operators.CompareString(current.Name, string_8, false) == 0 || Operators.CompareString(current.GetGuid(), string_8, false) == 0)
						{
							mission = current;
							mission2 = mission;
							result = mission2;
							return result;
						}
						if (Operators.CompareString(current.Name.ToUpper(), string_8.ToUpper(), false) == 0 || Operators.CompareString(current.GetGuid().ToUpper(), string_8.ToUpper(), false) == 0)
						{
							mission = current;
							mission2 = mission;
							result = mission2;
							return result;
						}
					}
				}
				mission2 = mission;
				result = mission2;
				return result;
			}
		}

		// Token: 0x06006709 RID: 26377 RVA: 0x00360138 File Offset: 0x0035E338
		public static Mission smethod_9(string string_8, Side side_0)
		{
			Mission result = null;
			foreach (Mission current in side_0.GetMissionCollection())
			{
				if (Operators.CompareString(current.Name, string_8, false) != 0 && Operators.CompareString(current.GetGuid(), string_8, false) != 0)
				{
					if (Operators.CompareString(current.Name.ToUpper(), string_8.ToUpper(), false) != 0 && Operators.CompareString(current.GetGuid().ToUpper(), string_8.ToUpper(), false) != 0)
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

		// Token: 0x0600670A RID: 26378 RVA: 0x003601F4 File Offset: 0x0035E3F4
		public static Mission._FlightSize smethod_10(ref string string_8)
		{
			int num = 0;
			int.TryParse(string_8, out num);
			int num2 = num;
			Mission._FlightSize result;
			if (num2 < 2)
			{
				result = Mission._FlightSize.SingleAircraft;
			}
			else if (num2 < 3)
			{
				result = Mission._FlightSize.TwoAircraft;
			}
			else if (num2 < 4)
			{
				result = Mission._FlightSize.ThreeAircraft;
			}
			else if (num2 < 5)
			{
				result = Mission._FlightSize.FourAircraft;
			}
			else if (num2 < 7)
			{
				result = Mission._FlightSize.SixAircraft;
			}
			else
			{
				result = Mission._FlightSize.SingleAircraft;
			}
			return result;
		}

		// Token: 0x0600670B RID: 26379 RVA: 0x00360258 File Offset: 0x0035E458
		public static Mission._FlightQty smethod_11(ref string string_8)
		{
			Mission._FlightQty result;
			if (Operators.CompareString(string_8.ToLower(), "all", false) == 0)
			{
				result = Mission._FlightQty.All;
			}
			else
			{
				int num = 0;
				int.TryParse(string_8, out num);
				int num2 = num;
				Mission._FlightQty flightQty;
				if (num2 == 0)
				{
					flightQty = Mission._FlightQty.NoPreferences;
				}
				else if (num2 < 2)
				{
					flightQty = Mission._FlightQty.Flight_x1;
				}
				else if (num2 < 3)
				{
					flightQty = Mission._FlightQty.Flight_x2;
				}
				else if (num2 < 4)
				{
					flightQty = Mission._FlightQty.Flight_x3;
				}
				else if (num2 < 5)
				{
					flightQty = Mission._FlightQty.Flight_x4;
				}
				else if (num2 < 7)
				{
					flightQty = Mission._FlightQty.Flight_x6;
				}
				else if (num2 < 9)
				{
					flightQty = Mission._FlightQty.Flight_x8;
				}
				else if (num2 < 13)
				{
					flightQty = Mission._FlightQty.Flight_x12;
				}
				else
				{
					flightQty = Mission._FlightQty.All;
				}
				result = flightQty;
			}
			return result;
		}

		// Token: 0x0600670C RID: 26380 RVA: 0x00360310 File Offset: 0x0035E510
		public static Mission._GroupSize smethod_12(ref string string_8)
		{
			Mission._GroupSize result;
			if (Operators.CompareString(string_8.ToLower(), "all", false) == 0)
			{
				result = Mission._GroupSize.const_0;
			}
			else
			{
				int num = 0;
				int.TryParse(string_8, out num);
				int num2 = num;
				Mission._GroupSize groupSize;
				if (num2 < 2)
				{
					groupSize = Mission._GroupSize.const_1;
				}
				else if (num2 < 3)
				{
					groupSize = Mission._GroupSize.const_2;
				}
				else if (num2 < 4)
				{
					groupSize = Mission._GroupSize.const_3;
				}
				else if (num2 < 5)
				{
					groupSize = Mission._GroupSize.const_4;
				}
				else if (num2 < 7)
				{
					groupSize = Mission._GroupSize.const_5;
				}
				else
				{
					groupSize = Mission._GroupSize.const_1;
				}
				result = groupSize;
			}
			return result;
		}

		// Token: 0x0600670D RID: 26381 RVA: 0x00360394 File Offset: 0x0035E594
		public static Misc.PostureStance smethod_13(ref string string_8)
		{
			string left = string_8.ToLower();
			uint num = Class382.smethod_0(left);
			Misc.PostureStance result;
			if (num <= 906799682u)
			{
				if (num <= 822911587u)
				{
					if (num != 9542285u)
					{
						if (num != 822911587u)
						{
							goto IL_17C;
						}
						if (Operators.CompareString(left, "4", false) != 0)
						{
							goto IL_17C;
						}
						goto IL_167;
					}
					else if (Operators.CompareString(left, "hostile", false) != 0)
					{
						goto IL_17C;
					}
				}
				else if (num != 873244444u)
				{
					if (num != 890022063u)
					{
						if (num != 906799682u || Operators.CompareString(left, "3", false) != 0)
						{
							goto IL_17C;
						}
					}
					else
					{
						if (Operators.CompareString(left, "0", false) != 0)
						{
							goto IL_17C;
						}
						goto IL_180;
					}
				}
				else
				{
					if (Operators.CompareString(left, "1", false) != 0)
					{
						goto IL_17C;
					}
					goto IL_14F;
				}
				result = Misc.PostureStance.Hostile;
				return result;
			}
			if (num <= 2094259269u)
			{
				if (num != 923577301u)
				{
					if (num != 2094259269u)
					{
						goto IL_17C;
					}
					if (Operators.CompareString(left, "unfriendly", false) != 0)
					{
						goto IL_17C;
					}
				}
				else if (Operators.CompareString(left, "2", false) != 0)
				{
					goto IL_17C;
				}
				result = Misc.PostureStance.Unfriendly;
				return result;
			}
			if (num != 2353732312u)
			{
				if (num != 2608177081u)
				{
					if (num != 3453284734u || Operators.CompareString(left, "friendly", false) != 0)
					{
						goto IL_17C;
					}
				}
				else
				{
					if (Operators.CompareString(left, "unknown", false) == 0)
					{
						goto IL_167;
					}
					goto IL_17C;
				}
			}
			else
			{
				if (Operators.CompareString(left, "neutral", false) != 0)
				{
					goto IL_17C;
				}
				goto IL_180;
			}
			IL_14F:
			result = Misc.PostureStance.Friendly;
			return result;
			IL_167:
			result = Misc.PostureStance.Unknown;
			return result;
			IL_17C:
			result = Misc.PostureStance.Unknown;
			return result;
			IL_180:
			result = Misc.PostureStance.Neutral;
			return result;
		}

		// Token: 0x040038A4 RID: 14500
		public static readonly string[] string_0 = new string[]
		{
			"TankerUsage",
			"TankerMissionList",
			"LaunchMissionWithoutTankersInPlace",
			"TankerMinNumber_Total",
			"TankerMinNumber_Airborne",
			"TankerMinNumber_Station",
			"MaxReceiversInQueuePerTanker_Airborne",
			"FuelQtyToStartLookingForTanker_Airborne",
			"TankerMaxDistance_Airborne"
		};

		// Token: 0x040038A5 RID: 14501
		public static readonly string[] string_1 = new string[]
		{
			"OneThirdRule",
			"TransitThrottleAircraft",
			"TransitAltitudeAircraft",
			"TransitTerrainFollowingAircraft",
			"StationThrottleAircraft",
			"StationAltitudeAircraft",
			"StationTerrainFollowingAircraft",
			"TransitThrottleSubmarine",
			"TransitDepthSubmarine",
			"StationThrottleSubmarine",
			"StationDepthSubmarine",
			"TransitThrottleShip",
			"StationThrottleShip",
			"FlightSize",
			"MinAircraftReq",
			"UseFlightSize",
			"GroupSize",
			"UseGroupSize",
			"Zone",
			"LoopType",
			"OnStation",
			"OneTimeOnly",
			"ActiveEMCON",
			"TankerOneTime",
			"TankerMaxReceivers"
		};

		// Token: 0x040038A6 RID: 14502
		public static readonly string[] string_2 = new string[]
		{
			"EscortFlightSizeShooter",
			"EscortMinShooter",
			"EscortMaxShooter",
			"EscortResponseRadius",
			"EscortUseFlightSize",
			"EscortFlightSizeNonShooter",
			"EscortMinNonShooter",
			"EscortMaxNonShooter",
			"EscortGroupSize",
			"EscortUseGroupSize",
			"StrikeOneTimeOnly",
			"StrikeMinimumTrigger",
			"StrikeMax",
			"StrikeFlightSize",
			"StrikeMinAircraftReq",
			"StrikeUseFlightSize",
			"StrikeGroupSize",
			"StrikeUseGroupSize",
			"StrikeAutoPlanner",
			"StrikePrePlan"
		};

		// Token: 0x040038A7 RID: 14503
		public static readonly string[] string_3 = new string[]
		{
			"OneThirdRule",
			"TransitThrottleAircraft",
			"TransitAltitudeAircraft",
			"StationThrottleAircraft",
			"StationAltitudeAircraft",
			"TransitThrottleSubmarine",
			"TransitDepthSubmarine",
			"StationThrottleSubmarine",
			"StationDepthSubmarine",
			"TransitThrottleShip",
			"StationThrottleShip",
			"UseFlightSize",
			"UseGroupSize",
			"Zone"
		};

		// Token: 0x040038A8 RID: 14504
		public static readonly string[] string_4 = new string[]
		{
			"OneThirdRule",
			"TransitThrottleAircraft",
			"TransitAltitudeAircraft",
			"TransitTerrainFollowingAircraft",
			"StationThrottleAircraft",
			"StationAltitudeAircraft",
			"StationTerrainFollowingAircraft",
			"TransitThrottleSubmarine",
			"TransitDepthSubmarine",
			"StationThrottleSubmarine",
			"StationDepthSubmarine",
			"TransitThrottleShip",
			"StationThrottleShip",
			"FlightSize",
			"MinAircraftReq",
			"UseFlightSize",
			"GroupSize",
			"UseGroupSize",
			"Zone",
			"ArmingDelay"
		};

		// Token: 0x040038A9 RID: 14505
		public static readonly string[] string_5 = new string[]
		{
			"OneThirdRule",
			"TransitThrottleAircraft",
			"TransitAltitudeAircraft",
			"TransitTerrainFollowingAircraft",
			"StationThrottleAircraft",
			"StationAltitudeAircraft",
			"StationTerrainFollowingAircraft",
			"TransitThrottleSubmarine",
			"TransitDepthSubmarine",
			"StationThrottleSubmarine",
			"StationDepthSubmarine",
			"TransitThrottleShip",
			"StationThrottleShip",
			"FlightSize",
			"MinAircraftReq",
			"UseFlightSize",
			"GroupSize",
			"UseGroupSize",
			"Zone"
		};

		// Token: 0x040038AA RID: 14506
		public static readonly string[] string_6 = new string[]
		{
			"OneThirdRule",
			"CheckOPA",
			"CheckWWR",
			"ActiveEMCON",
			"TransitThrottleAircraft",
			"TransitAltitudeAircraft",
			"TransitTerrainFollowingAircraft",
			"StationThrottleAircraft",
			"StationAltitudeAircraft",
			"StationTerrainFollowingAircraft",
			"AttackThrottleAircraft",
			"AttackAltitudeAircraft",
			"AttackTerrainFollowingAircraft",
			"AttackDistanceAircraft",
			"TransitThrottleSubmarine",
			"TransitDepthSubmarine",
			"StationThrottleSubmarine",
			"StationDepthSubmarine",
			"AttackThrottleSubmarine",
			"AttackDepthSubmarine",
			"AttackDistanceSubmarine",
			"TransitThrottleShip",
			"StationThrottleShip",
			"AttackThrottleShip",
			"AttackDistanceShip",
			"FlightSize",
			"MinAircraftReq",
			"UseFlightSize",
			"GroupSize",
			"UseGroupSize",
			"ProsecutionZone",
			"PatrolZone"
		};

		// Token: 0x040038AB RID: 14507
		public static readonly string[] string_7 = new string[]
		{
			"FerryBehavior",
			"FerryThrottleAircraft",
			"FerryAltitudeAircraft",
			"FerryTerrainFollowingAircraft",
			"FlightSize",
			"MinAircraftReq",
			"UseFlightSize"
		};

		// Token: 0x02000C18 RID: 3096
		[CompilerGenerated]
		public sealed class Class274
		{
			// Token: 0x06006710 RID: 26384 RVA: 0x0002C662 File Offset: 0x0002A862
			public Class274(Class273.Class274 class274_0)
			{
				if (class274_0 != null)
				{
					this.object_0 = class274_0.object_0;
				}
			}

			// Token: 0x06006711 RID: 26385 RVA: 0x0002C67C File Offset: 0x0002A87C
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006712 RID: 26386 RVA: 0x0002C67C File Offset: 0x0002A87C
			internal bool method_1(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006713 RID: 26387 RVA: 0x0002C698 File Offset: 0x0002A898
			internal bool method_2(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006714 RID: 26388 RVA: 0x0002C698 File Offset: 0x0002A898
			internal bool method_3(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006715 RID: 26389 RVA: 0x0002C6BE File Offset: 0x0002A8BE
			internal bool method_4(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006716 RID: 26390 RVA: 0x0002C6BE File Offset: 0x0002A8BE
			internal bool method_5(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006717 RID: 26391 RVA: 0x0002C6DA File Offset: 0x0002A8DA
			internal bool method_6(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006718 RID: 26392 RVA: 0x0002C6DA File Offset: 0x0002A8DA
			internal bool method_7(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x040038AC RID: 14508
			public object object_0;
		}

		// Token: 0x02000C19 RID: 3097
		[CompilerGenerated]
		public sealed class Class275
		{
			// Token: 0x06006719 RID: 26393 RVA: 0x0002C700 File Offset: 0x0002A900
			public Class275(Class273.Class275 class275_0)
			{
				if (class275_0 != null)
				{
					this.object_0 = class275_0.object_0;
				}
			}

			// Token: 0x0600671A RID: 26394 RVA: 0x0002C71A File Offset: 0x0002A91A
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x0600671B RID: 26395 RVA: 0x0002C71A File Offset: 0x0002A91A
			internal bool method_1(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x0600671C RID: 26396 RVA: 0x0002C736 File Offset: 0x0002A936
			internal bool method_2(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x0600671D RID: 26397 RVA: 0x0002C736 File Offset: 0x0002A936
			internal bool method_3(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x0600671E RID: 26398 RVA: 0x0002C75C File Offset: 0x0002A95C
			internal bool method_4(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x0600671F RID: 26399 RVA: 0x0002C75C File Offset: 0x0002A95C
			internal bool method_5(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006720 RID: 26400 RVA: 0x0002C778 File Offset: 0x0002A978
			internal bool method_6(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006721 RID: 26401 RVA: 0x0002C778 File Offset: 0x0002A978
			internal bool method_7(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x040038AD RID: 14509
			public object object_0;
		}

		// Token: 0x02000C1A RID: 3098
		[CompilerGenerated]
		public sealed class Class276
		{
			// Token: 0x06006722 RID: 26402 RVA: 0x0002C79E File Offset: 0x0002A99E
			public Class276(Class273.Class276 class276_0)
			{
				if (class276_0 != null)
				{
					this.object_0 = class276_0.object_0;
				}
			}

			// Token: 0x06006723 RID: 26403 RVA: 0x0002C7B8 File Offset: 0x0002A9B8
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006724 RID: 26404 RVA: 0x0002C7B8 File Offset: 0x0002A9B8
			internal bool method_1(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006725 RID: 26405 RVA: 0x0002C7D4 File Offset: 0x0002A9D4
			internal bool method_2(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006726 RID: 26406 RVA: 0x0002C7D4 File Offset: 0x0002A9D4
			internal bool method_3(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006727 RID: 26407 RVA: 0x0002C7FA File Offset: 0x0002A9FA
			internal bool method_4(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006728 RID: 26408 RVA: 0x0002C7FA File Offset: 0x0002A9FA
			internal bool method_5(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006729 RID: 26409 RVA: 0x0002C816 File Offset: 0x0002AA16
			internal bool method_6(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x0600672A RID: 26410 RVA: 0x0002C816 File Offset: 0x0002AA16
			internal bool method_7(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x040038AE RID: 14510
			public object object_0;
		}

		// Token: 0x02000C1B RID: 3099
		[CompilerGenerated]
		public sealed class Class277
		{
			// Token: 0x0600672B RID: 26411 RVA: 0x0002C83C File Offset: 0x0002AA3C
			public Class277(Class273.Class277 class277_0)
			{
				if (class277_0 != null)
				{
					this.object_0 = class277_0.object_0;
				}
			}

			// Token: 0x0600672C RID: 26412 RVA: 0x0002C856 File Offset: 0x0002AA56
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x0600672D RID: 26413 RVA: 0x0002C856 File Offset: 0x0002AA56
			internal bool method_1(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x0600672E RID: 26414 RVA: 0x0002C872 File Offset: 0x0002AA72
			internal bool method_2(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x0600672F RID: 26415 RVA: 0x0002C872 File Offset: 0x0002AA72
			internal bool method_3(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006730 RID: 26416 RVA: 0x0002C898 File Offset: 0x0002AA98
			internal bool method_4(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006731 RID: 26417 RVA: 0x0002C898 File Offset: 0x0002AA98
			internal bool method_5(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006732 RID: 26418 RVA: 0x0002C8B4 File Offset: 0x0002AAB4
			internal bool method_6(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006733 RID: 26419 RVA: 0x0002C8B4 File Offset: 0x0002AAB4
			internal bool method_7(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x040038AF RID: 14511
			public object object_0;
		}

		// Token: 0x02000C1C RID: 3100
		[CompilerGenerated]
		public sealed class Class278
		{
			// Token: 0x06006734 RID: 26420 RVA: 0x0002C8DA File Offset: 0x0002AADA
			public Class278(Class273.Class278 class278_0)
			{
				if (class278_0 != null)
				{
					this.object_0 = class278_0.object_0;
				}
			}

			// Token: 0x06006735 RID: 26421 RVA: 0x0002C8F4 File Offset: 0x0002AAF4
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006736 RID: 26422 RVA: 0x0002C8F4 File Offset: 0x0002AAF4
			internal bool method_1(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006737 RID: 26423 RVA: 0x0002C910 File Offset: 0x0002AB10
			internal bool method_2(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006738 RID: 26424 RVA: 0x0002C910 File Offset: 0x0002AB10
			internal bool method_3(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006739 RID: 26425 RVA: 0x0002C936 File Offset: 0x0002AB36
			internal bool method_4(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x0600673A RID: 26426 RVA: 0x0002C936 File Offset: 0x0002AB36
			internal bool method_5(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x0600673B RID: 26427 RVA: 0x0002C952 File Offset: 0x0002AB52
			internal bool method_6(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x0600673C RID: 26428 RVA: 0x0002C952 File Offset: 0x0002AB52
			internal bool method_7(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x040038B0 RID: 14512
			public object object_0;
		}

		// Token: 0x02000C1D RID: 3101
		[CompilerGenerated]
		public sealed class Class279
		{
			// Token: 0x0600673D RID: 26429 RVA: 0x0002C978 File Offset: 0x0002AB78
			public Class279(Class273.Class279 class279_0)
			{
				if (class279_0 != null)
				{
					this.object_0 = class279_0.object_0;
				}
			}

			// Token: 0x0600673E RID: 26430 RVA: 0x0002C992 File Offset: 0x0002AB92
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x0600673F RID: 26431 RVA: 0x0002C992 File Offset: 0x0002AB92
			internal bool method_1(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006740 RID: 26432 RVA: 0x0002C9AE File Offset: 0x0002ABAE
			internal bool method_2(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006741 RID: 26433 RVA: 0x0002C9AE File Offset: 0x0002ABAE
			internal bool method_3(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006742 RID: 26434 RVA: 0x0002C9D4 File Offset: 0x0002ABD4
			internal bool method_4(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006743 RID: 26435 RVA: 0x0002C9D4 File Offset: 0x0002ABD4
			internal bool method_5(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006744 RID: 26436 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
			internal bool method_6(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x06006745 RID: 26437 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
			internal bool method_7(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x040038B1 RID: 14513
			public object object_0;
		}

		// Token: 0x02000C1E RID: 3102
		[CompilerGenerated]
		public sealed class Class280
		{
			// Token: 0x06006746 RID: 26438 RVA: 0x0002CA16 File Offset: 0x0002AC16
			public Class280(Class273.Class280 class280_0)
			{
				if (class280_0 != null)
				{
					this.object_0 = class280_0.object_0;
				}
			}

			// Token: 0x06006747 RID: 26439 RVA: 0x0002CA30 File Offset: 0x0002AC30
			internal bool method_0(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006748 RID: 26440 RVA: 0x0002CA30 File Offset: 0x0002AC30
			internal bool method_1(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name, this.object_0.ToString(), false) == 0;
			}

			// Token: 0x06006749 RID: 26441 RVA: 0x0002CA4C File Offset: 0x0002AC4C
			internal bool method_2(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x0600674A RID: 26442 RVA: 0x0002CA4C File Offset: 0x0002AC4C
			internal bool method_3(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.Name.ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x0600674B RID: 26443 RVA: 0x0002CA72 File Offset: 0x0002AC72
			internal bool method_4(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x0600674C RID: 26444 RVA: 0x0002CA72 File Offset: 0x0002AC72
			internal bool method_5(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid(), this.object_0.ToString(), false) == 0;
			}

			// Token: 0x0600674D RID: 26445 RVA: 0x0002CA8E File Offset: 0x0002AC8E
			internal bool method_6(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x0600674E RID: 26446 RVA: 0x0002CA8E File Offset: 0x0002AC8E
			internal bool method_7(ReferencePoint referencePoint_0)
			{
				return Operators.CompareString(referencePoint_0.GetGuid().ToUpper(), this.object_0.ToString().ToUpper(), false) == 0;
			}

			// Token: 0x040038B2 RID: 14514
			public object object_0;
		}
	}
}

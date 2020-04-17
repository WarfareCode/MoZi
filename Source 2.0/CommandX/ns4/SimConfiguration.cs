using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns2;
using ns29;

namespace ns4
{
	// Token: 0x02000CAC RID: 3244
	public sealed class SimConfiguration
	{
		// Token: 0x06006B26 RID: 27430 RVA: 0x003A3AC0 File Offset: 0x003A1CC0
		public static void LoadSimConfiguration()
		{
			if (File.Exists(Path.Combine(MyTemplate.GetApp().Info.DirectoryPath, "Pro.dat")))
			{
				SimConfiguration.bPro = true;
			}
			checked
			{
				try
				{
					if (!File.Exists(SimConfiguration.GameIniFile))
					{
						SimConfiguration.LoadDefault();
					}
					Class2372 @class = new Class2372(SimConfiguration.GameIniFile);
					SimConfiguration.DefaultDB = @class.GetConfigList()["General"].GetValue("DefaultDB");
					SimConfiguration.gameOptions = new Configuration.GameOptions();
					SimConfiguration.gameOptions.SetUseAutosave(Conversions.ToBoolean(@class.GetConfigList()["Game Preferences"].GetValue("UseAutosave")));
					SimConfiguration.gameOptions.SetRunCoreMultithreaded(Conversions.ToBoolean(@class.GetConfigList()["Game Preferences"].GetValue("RunCoreMultithreaded")));
					SimConfiguration.gameOptions.SetShowDiagnostics(Conversions.ToBoolean(@class.GetConfigList()["Game Preferences"].GetValue("ShowDiagnostics")));
					string value = @class.GetConfigList()["Game Preferences"].GetValue("MessageLogInWindow");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetMessageLogInWindow(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetMessageLogInWindow(false);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("GameSounds");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetGameSoundsON(Conversions.ToBoolean(value));
					}
					else if (SimConfiguration.bPro)
					{
						SimConfiguration.gameOptions.SetGameSoundsON(false);
					}
					else
					{
						SimConfiguration.gameOptions.SetGameSoundsON(true);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("GameMusic");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetGameMusicON(Conversions.ToBoolean(value));
					}
					else if (SimConfiguration.bPro)
					{
						SimConfiguration.gameOptions.SetGameMusicON(false);
					}
					else
					{
						SimConfiguration.gameOptions.SetGameMusicON(true);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("ShowAltitudeInFeet");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetUseImperialUnit(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetUseImperialUnit(false);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("ZoomOnCursor");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetZoomOnCursor(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetZoomOnCursor(false);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("SonobuoyVisibility");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetSonobuoyVisibility((Configuration.GameOptions._SonobuoyVisibility)Conversions.ToByte(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetSonobuoyVisibility(Configuration.GameOptions._SonobuoyVisibility.const_0);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("DPIScalingMethod");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetDPIScalingMethod((Configuration.GameOptions._DPIScalingMethod)Conversions.ToByte(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetDPIScalingMethod(Configuration.GameOptions._DPIScalingMethod.const_0);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("RefPointVisibility");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetRefPointVisibility((Configuration.GameOptions._RefPointVisibility)Conversions.ToByte(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetRefPointVisibility(Configuration.GameOptions._RefPointVisibility.const_0);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("MapSymbolsSet");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetMapSymbolsSet((Configuration.GameOptions._MapSymbolsSet)Conversions.ToByte(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetMapSymbolsSet(Configuration.GameOptions._MapSymbolsSet.NTDS);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("MapCursorBox");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetMapCursorBox((Configuration.GameOptions._MapCursorBox)Conversions.ToByte(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetMapCursorBox(Configuration.GameOptions._MapCursorBox.const_1);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("ShowGhostedGroupMembers");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.method_33((Configuration.GameOptions._ShowGhostedGroupMembers)Conversions.ToByte(value));
					}
					else
					{
						SimConfiguration.gameOptions.method_33(Configuration.GameOptions._ShowGhostedGroupMembers.NONE);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("ShowPlottedPaths");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetShowPlottedPaths((Configuration.GameOptions.Enum45)Conversions.ToByte(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetShowPlottedPaths(Configuration.GameOptions.Enum45.const_0);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("ShowFlightPlans_Airborne");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetShowFlightPlans_Airborne((Configuration.GameOptions._ShowFlightPlans_Airborne)Conversions.ToByte(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetShowFlightPlans_Airborne(Configuration.GameOptions._ShowFlightPlans_Airborne.const_0);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("ShowFlightPlans_Planned");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetShowFlightPlans_Planned((Configuration.GameOptions._ShowFlightPlans_Planned)Conversions.ToByte(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetShowFlightPlans_Planned(Configuration.GameOptions._ShowFlightPlans_Planned.const_0);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("ShowMissionArea");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.method_35((Configuration.GameOptions._ShowMissionArea)Conversions.ToShort(value));
					}
					else
					{
						SimConfiguration.gameOptions.method_35(Configuration.GameOptions._ShowMissionArea.const_1);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("HighFidelityMode");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetHighFidelityMode(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetHighFidelityMode(true);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("NoPulseMapUpdate");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetNoPulseMapUpdate(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetNoPulseMapUpdate(true);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("OnlyShowAvailableLoadouts");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetOnlyShowAvailableLoadouts(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetOnlyShowAvailableLoadouts(false);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("UnitStatusImage");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetIsShowUnitStatusImage(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetIsShowUnitStatusImage(true);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("SalvoTimeout");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetSalvoTimeout(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetSalvoTimeout(true);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("ShowAutomaticFireInfo");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetShowAutomaticFireInfo(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetShowAutomaticFireInfo(true);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("ShowGameSpeedButton");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetShowGameSpeedButton(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetShowGameSpeedButton(false);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("LogDebugInfoToFile");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetLogDebugInfoToFile(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetLogDebugInfoToFile(false);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("MemoryProtection");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetMemoryProtection(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetMemoryProtection(false);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("PlacenameVisibility");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetPlacenameVisibility(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetPlacenameVisibility(true);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("PlacenameShowInChinese");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetPlacenameShowInChinese(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetPlacenameShowInChinese(true);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("MessageLogCanvas");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetMessageLogCanvas(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetMessageLogCanvas(true);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("NavigationMaxDistanceNMSetting");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetNavigationMaxDistanceNMSetting(Conversions.ToSingle(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetNavigationMaxDistanceNMSetting(8f);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("NavigationThresholdDistanceDegSetting");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetNavigationThresholdDistanceDegSetting(Conversions.ToSingle(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetNavigationThresholdDistanceDegSetting(0.5f);
					}
					value = @class.GetConfigList()["Game Preferences"].GetValue("AllowPowerPlanSwitch");
					if (!Information.IsNothing(value))
					{
						SimConfiguration.gameOptions.SetAllowPowerPlanSwitch(Conversions.ToBoolean(value));
					}
					else
					{
						SimConfiguration.gameOptions.SetAllowPowerPlanSwitch(true);
					}
					string[] array = @class.GetConfigList()["MessageLog Preferences"].imethod_3();
					int i = 0;
					while (i < array.Length)
					{
						string text = array[i];
						string[] array2 = @class.GetConfigList()["MessageLog Preferences"].GetValue(text).Split(new char[]
						{
							'|'
						});
						LoggedMessage.MessageType key;
						if (Operators.CompareString(text, "ScenarioGoalFulfil", false) == 0)
						{
							key = LoggedMessage.MessageType.EventEngine;
							goto IL_97E;
						}
						if (Operators.CompareString(text, "OECM_Activity", false) != 0)
						{
							try
							{
								key = (LoggedMessage.MessageType)Enum.Parse(typeof(LoggedMessage.MessageType), text, true);
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ex2.Data.Add("Error at 200499", ex2.Message);
								GameGeneral.LogException(ref ex2);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								ProjectData.ClearProjectError();
								goto IL_9A6;
							}
							goto IL_97E;
						}
						IL_9A6:
						i++;
						continue;
						IL_97E:
						SimConfiguration.gameOptions.MessageTypeShowOptionsDictionary[key] = new LoggedMessage.MessageShowOptions(Conversions.ToBoolean(array2[0]), Conversions.ToBoolean(array2[1]));
						goto IL_9A6;
					}
					if (!Information.IsNothing(@class.GetConfigList()["Secondary Window Settings"]))
					{
						Class267.dictionary_0.Clear();
						string[] array3 = @class.GetConfigList()["Secondary Window Settings"].imethod_3();
						for (int j = 0; j < array3.Length; j++)
						{
							string text2 = array3[j];
							string[] array2 = @class.GetConfigList()["Secondary Window Settings"].GetValue(text2).Split(new char[]
							{
								'|'
							});
							Class267.dictionary_0.Add(text2, new Tuple<int, int, int, int>(Conversions.ToInteger(array2[0]), Conversions.ToInteger(array2[1]), Conversions.ToInteger(array2[2]), Conversions.ToInteger(array2[3])));
						}
					}
					if (SimConfiguration.bPro)
					{
						if (!File.Exists(SimConfiguration.string_2))
						{
							SimConfiguration.smethod_2();
						}
						Class2372 class2 = new Class2372(SimConfiguration.string_2);
						GameGeneral.bUsePitchForWeapons = Conversions.ToBoolean(class2.GetConfigList()["General"].GetValue("UsePitchForWeapons"));
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 101127", "");
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006B27 RID: 27431 RVA: 0x003A4600 File Offset: 0x003A2800
		public static void LoadDefault()
		{
			Class2372 @class = new Class2372();
			try
			{
				@class.GetConfig("General").SetValueString("DefaultDB", 1);
				IConfig config = @class.GetConfig("Realism Settings");
				config.SetValueString("DetailedGunFireControl", "True");
				config.SetValueString("UnlimitedAirWeapons", "False");
				config.SetValueString("CommsJamming", "False");
				config.SetValueString("AircraftDamage", "False");
				IConfig config2 = @class.GetConfig("Game Preferences");
				config2.SetValueString("UseAutosave", "True");
				config2.SetValueString("RunCoreMultithreaded", "False");
				config2.SetValueString("ShowDiagnostics", "False");
				config2.SetValueString("MessageLogInWindow", "False");
				config2.SetValueString("GameSounds", "True");
				config2.SetValueString("GameMusic", "True");
				config2.SetValueString("ShowAltitudeInFeet", "True");
				config2.SetValueString("ZoomOnCursor", "False");
				config2.SetValueString("SonobuoyVisibility", "0");
				config2.SetValueString("RefPointVisibility", "0");
				config2.SetValueString("MapSymbolsSet", "0");
				config2.SetValueString("MapCursorBox", "0");
				config2.SetValueString("HighFidelityMode", "True");
				config2.SetValueString("NoPulseMapUpdate", "True");
				config2.SetValueString("ShowGhostedGroupMembers", "2");
				config2.SetValueString("NavigationMaxDistanceNMSetting", "8");
				config2.SetValueString("NavigationThresholdDistanceDegSetting", "1");
				config2.SetValueString("ShowPlottedPaths", "0");
				config2.SetValueString("ShowFlightPlans", "0");
				config2.SetValueString("ShowMissionArea", "1");
				config2.SetValueString("OnlyShowAvailableLoadouts", "False");
				config2.SetValueString("UnitStatusImage", "True");
				config2.SetValueString("SalvoTimeout", "True");
				config2.SetValueString("PlacenameVisibility", "True");
				config2.SetValueString("PlacenameShowInChinese", "True");
				config2.SetValueString("MessageLogCanvas", "True");
				config2.SetValueString("AllowPowerPlanSwitch", "True");
				config2.SetValueString("ShowGameSpeedButton", "False");
				config2.SetValueString("DPIScalingMethod", "0");
				IConfig config3 = @class.GetConfig("MessageLog Preferences");
				config3.SetValueString("NewContact", "1|0");
				config3.SetValueString("CommsIsolatedMessage", "1|0");
				config3.SetValueString("ContactChange", "1|0");
				config3.SetValueString("WeaponEndgame", "1|0");
				config3.SetValueString("WeaponDamage", "1|0");
				config3.SetValueString("AirOps", "1|0");
				config3.SetValueString("UnitLost", "1|1");
				config3.SetValueString("UnitDamage", "1|0");
				config3.SetValueString("PointDefence", "1|0");
				config3.SetValueString("UI", "1|0");
				config3.SetValueString("WeaponLogic", "1|0");
				config3.SetValueString("UnitAI", "1|0");
				config3.SetValueString("EventEngine", "1|0");
				config3.SetValueString("NewWeaponContact", "1|1");
				config3.SetValueString("DockingOps", "1|0");
				config3.SetValueString("SpecialMessage", "1|1");
				config3.SetValueString("NewMineContact", "1|0");
				config3.SetValueString("NewAirContact", "1|0");
				config3.SetValueString("NewSurfaceContact", "1|0");
				config3.SetValueString("NewUnderwaterContact", "1|0");
				config3.SetValueString("NewGroundContact", "1|0");
				config3.SetValueString("UnguidedWeaponModifiers", "0|0");
				@class.GetConfig("Secondary Window Settings");
				@class.method_5(SimConfiguration.GameIniFile);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101128", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x003A4A38 File Offset: 0x003A2C38
		public static void smethod_2()
		{
			Class2372 @class = new Class2372();
			try
			{
				@class.GetConfig("General").SetValueString("UsePitchForWeapons", 0);
				@class.method_5(SimConfiguration.string_2);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 102134523456661184325762356", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B29 RID: 27433 RVA: 0x003A4AC0 File Offset: 0x003A2CC0
		public static void SaveConfig()
		{
			Class2372 @class = new Class2372();
			try
			{
				IConfig config = @class.GetConfig("General");
				config.SetValueString("DefaultDB", SimConfiguration.DefaultDB);
				config = @class.GetConfig("Game Preferences");
				config.SetValueString("UseAutosave", SimConfiguration.gameOptions.IsUseAutosave().ToString());
				config.SetValueString("RunCoreMultithreaded", SimConfiguration.gameOptions.IsRunCoreMultithreaded().ToString());
				config.SetValueString("ShowDiagnostics", SimConfiguration.gameOptions.IsShowDiagnostics().ToString());
				config.SetValueString("MessageLogInWindow", SimConfiguration.gameOptions.IsMessageLogInWindow().ToString());
				config.SetValueString("GameSounds", SimConfiguration.gameOptions.IsGameSoundsON().ToString());
				config.SetValueString("GameMusic", SimConfiguration.gameOptions.IsGameMusicON().ToString());
				config.SetValueString("ShowAltitudeInFeet", SimConfiguration.gameOptions.UseImperialUnit().ToString());
				config.SetValueString("ZoomOnCursor", SimConfiguration.gameOptions.IsZoomOnCursor().ToString());
				config.SetValueString("SonobuoyVisibility", ((int)SimConfiguration.gameOptions.GetSonobuoyVisibility()).ToString());
				config.SetValueString("RefPointVisibility", ((int)SimConfiguration.gameOptions.GetRefPointVisibility()).ToString());
				config.SetValueString("MapSymbolsSet", ((byte)SimConfiguration.gameOptions.GetMapSymbolsSet()).ToString());
				config.SetValueString("MapCursorBox", ((int)SimConfiguration.gameOptions.GetMapCursorBox()).ToString());
				config.SetValueString("HighFidelityMode", SimConfiguration.gameOptions.IsHighFidelityMode().ToString());
				config.SetValueString("NoPulseMapUpdate", SimConfiguration.gameOptions.NoPulseMapUpdate().ToString());
				config.SetValueString("OnlyShowAvailableLoadouts", SimConfiguration.gameOptions.OnlyShowAvailableLoadouts().ToString());
				config.SetValueString("ShowGhostedGroupMembers", ((byte)SimConfiguration.gameOptions.ShowGhostedGroupMembers()).ToString());
				config.SetValueString("NavigationMaxDistanceNMSetting", SimConfiguration.gameOptions.GetNavigationMaxDistanceNMSetting().ToString());
				config.SetValueString("NavigationThresholdDistanceDegSetting", SimConfiguration.gameOptions.GetNavigationThresholdDistanceDegSetting().ToString());
				config.SetValueString("ShowPlottedPaths", ((byte)SimConfiguration.gameOptions.GetShowPlottedPaths()).ToString());
				config.SetValueString("ShowFlightPlans_Airborne", ((byte)SimConfiguration.gameOptions.GetShowFlightPlans_Airborne()).ToString());
				config.SetValueString("ShowFlightPlans_Planned", ((byte)SimConfiguration.gameOptions.GetShowFlightPlans_Planned()).ToString());
				config.SetValueString("ShowMissionArea", ((byte)SimConfiguration.gameOptions.ShowMissionArea()).ToString());
				config.SetValueString("UnitStatusImage", SimConfiguration.gameOptions.IsShowUnitStatusImage().ToString());
				config.SetValueString("SalvoTimeout", SimConfiguration.gameOptions.IsSalvoTimeout().ToString());
				config.SetValueString("ShowAutomaticFireInfo", SimConfiguration.gameOptions.IsShowAutomaticFireInfo().ToString());
				config.SetValueString("PlacenameVisibility", SimConfiguration.gameOptions.GetPlacenameVisibility().ToString());
				config.SetValueString("PlacenameShowInChinese", SimConfiguration.gameOptions.IsPlacenameShowInChinese().ToString());
				config.SetValueString("MessageLogCanvas", SimConfiguration.gameOptions.IsMessageLogCanvas().ToString());
				config.SetValueString("AllowPowerPlanSwitch", SimConfiguration.gameOptions.IsAllowPowerPlanSwitch().ToString());
				config.SetValueString("ShowGameSpeedButton", SimConfiguration.gameOptions.IsShowGameSpeedButton().ToString());
				config.SetValueString("LogDebugInfoToFile", SimConfiguration.gameOptions.LogDebugInfoToFile().ToString());
				config.SetValueString("MemoryProtection", SimConfiguration.gameOptions.UseMemoryProtection().ToString());
				config.SetValueString("UseAutosave", SimConfiguration.gameOptions.IsUseAutosave().ToString());
				config.SetValueString("DPIScalingMethod", ((byte)SimConfiguration.gameOptions.GetDPIScalingMethod()).ToString());
				config = @class.GetConfig("MessageLog Preferences");
				Dictionary<LoggedMessage.MessageType, LoggedMessage.MessageShowOptions>.KeyCollection.Enumerator enumerator = SimConfiguration.gameOptions.MessageTypeShowOptionsDictionary.Keys.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						LoggedMessage.MessageType current = enumerator.Current;
						config.SetValueString(current.ToString(), Conversions.ToString(SimConfiguration.gameOptions.MessageTypeShowOptionsDictionary[current].bool_0 ? 1 : 0) + "|" + Conversions.ToString(SimConfiguration.gameOptions.MessageTypeShowOptionsDictionary[current].bool_1 ? 1 : 0));
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
				try
				{
					config = @class.GetConfig("Secondary Window Settings");
					foreach (KeyValuePair<string, Tuple<int, int, int, int>> current2 in Class267.dictionary_0)
					{
						config.SetValueString(current2.Key, string.Concat(new string[]
						{
							Conversions.ToString(current2.Value.Item1),
							"|",
							Conversions.ToString(current2.Value.Item2),
							"|",
							Conversions.ToString(current2.Value.Item3),
							"|",
							Conversions.ToString(current2.Value.Item4)
						}));
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101160", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				@class.method_5(SimConfiguration.GameIniFile);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 101129", "");
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B2A RID: 27434 RVA: 0x003A5150 File Offset: 0x003A3350
		public static string smethod_3(string string_3, string string_4)
		{
			string result = "";
			try
			{
				result = new Class2372(SimConfiguration.ExternalURLsFile).GetConfigList()[string_3].GetValue(string_4);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200500", ex2.Message);
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

		// Token: 0x04003CF7 RID: 15607
		public static string DefaultDB;

		// Token: 0x04003CF8 RID: 15608
		public static Configuration.GameOptions gameOptions;

		// Token: 0x04003CF9 RID: 15609
		public static bool bPro = false;

		// Token: 0x04003CFA RID: 15610
		private static string GameIniFile = MyTemplate.GetApp().Info.DirectoryPath + "\\CommandX.ini";

		// Token: 0x04003CFB RID: 15611
		private static string string_2 = MyTemplate.GetApp().Info.DirectoryPath + "\\OPE.ini";

		// Token: 0x04003CFC RID: 15612
		private static string ExternalURLsFile = MyTemplate.GetApp().Info.DirectoryPath + "\\ExternalURLs.ini";
	}
}

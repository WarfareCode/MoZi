using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns4;

namespace ns3
{
	// Token: 0x02000C6F RID: 3183
	public sealed class EventExport_Tacview1x : IEventExporter
	{
		// Token: 0x060069D3 RID: 27091 RVA: 0x0038E6DC File Offset: 0x0038C8DC
		[CompilerGenerated]
		public _RunMode GetRunMode()
		{
			return this.runMode;
		}

		// Token: 0x060069D4 RID: 27092 RVA: 0x0002D90E File Offset: 0x0002BB0E
		[CompilerGenerated]
		public void SetRunMode(_RunMode enum100_1)
		{
			this.runMode = enum100_1;
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x0002D917 File Offset: 0x0002BB17
		[CompilerGenerated]
		public bool IsExportEngagementCycle()
		{
			return this.bool_0;
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x0002D91F File Offset: 0x0002BB1F
		[CompilerGenerated]
		public void SetExportEngagementCycle(bool bool_12)
		{
			this.bool_0 = bool_12;
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x0002D928 File Offset: 0x0002BB28
		[CompilerGenerated]
		public bool IsExportSensorDetectionFailure()
		{
			return this.bool_1;
		}

		// Token: 0x060069D8 RID: 27096 RVA: 0x0002D930 File Offset: 0x0002BB30
		[CompilerGenerated]
		public void SetExportSensorDetectionFailure(bool bool_12)
		{
			this.bool_1 = bool_12;
		}

		// Token: 0x060069D9 RID: 27097 RVA: 0x0002D939 File Offset: 0x0002BB39
		[CompilerGenerated]
		public bool IsExportSensorDetectionSuccess()
		{
			return this.bool_2;
		}

		// Token: 0x060069DA RID: 27098 RVA: 0x0002D941 File Offset: 0x0002BB41
		[CompilerGenerated]
		public void SetExportSensorDetectionSuccess(bool bool_12)
		{
			this.bool_2 = bool_12;
		}

		// Token: 0x060069DB RID: 27099 RVA: 0x0002D94A File Offset: 0x0002BB4A
		[CompilerGenerated]
		public bool IsExportUnitPositions()
		{
			return this.bool_3;
		}

		// Token: 0x060069DC RID: 27100 RVA: 0x0002D952 File Offset: 0x0002BB52
		[CompilerGenerated]
		public void SetExportUnitPositions(bool bool_12)
		{
			this.bool_3 = bool_12;
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x0002D95B File Offset: 0x0002BB5B
		[CompilerGenerated]
		public bool IsExportWeaponEndgame()
		{
			return this.bool_4;
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x0002D963 File Offset: 0x0002BB63
		[CompilerGenerated]
		public void SetExportWeaponEndgame(bool bool_12)
		{
			this.bool_4 = bool_12;
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x0002D96C File Offset: 0x0002BB6C
		[CompilerGenerated]
		public bool IsExportWeaponFired()
		{
			return this.bool_5;
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x0002D974 File Offset: 0x0002BB74
		[CompilerGenerated]
		public void SetExportWeaponFired(bool bool_12)
		{
			this.bool_5 = bool_12;
		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x0002D97D File Offset: 0x0002BB7D
		[CompilerGenerated]
		public bool imethod_24()
		{
			return this.bool_6;
		}

		// Token: 0x060069E2 RID: 27106 RVA: 0x0002D985 File Offset: 0x0002BB85
		[CompilerGenerated]
		public void imethod_25(bool bool_12)
		{
			this.bool_6 = bool_12;
		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x0002D98E File Offset: 0x0002BB8E
		[CompilerGenerated]
		public bool IsExportFuelConsumed()
		{
			return this.bool_7;
		}

		// Token: 0x060069E4 RID: 27108 RVA: 0x0002D996 File Offset: 0x0002BB96
		[CompilerGenerated]
		public void SetExportFuelConsumed(bool bool_12)
		{
			this.bool_7 = bool_12;
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x0002D99F File Offset: 0x0002BB9F
		[CompilerGenerated]
		public bool IsExportFuelTransfer()
		{
			return this.bool_8;
		}

		// Token: 0x060069E6 RID: 27110 RVA: 0x0002D9A7 File Offset: 0x0002BBA7
		[CompilerGenerated]
		public void SetExportFuelTransfer(bool bool_12)
		{
			this.bool_8 = bool_12;
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x0002D9B0 File Offset: 0x0002BBB0
		[CompilerGenerated]
		public bool IsUseZeroHour()
		{
			return this.bool_9;
		}

		// Token: 0x060069E8 RID: 27112 RVA: 0x0002D9B8 File Offset: 0x0002BBB8
		[CompilerGenerated]
		public void SetUseZeroHour(bool bool_12)
		{
			this.bool_9 = bool_12;
		}

		// Token: 0x060069E9 RID: 27113 RVA: 0x0002D9C1 File Offset: 0x0002BBC1
		[CompilerGenerated]
		public bool imethod_30()
		{
			return this.bool_10;
		}

		// Token: 0x060069EA RID: 27114 RVA: 0x0038E6F4 File Offset: 0x0038C8F4
		[CompilerGenerated]
		public string GetExportDirectory()
		{
			return this.string_0;
		}

		// Token: 0x060069EB RID: 27115 RVA: 0x0002D9C9 File Offset: 0x0002BBC9
		[CompilerGenerated]
		public void SetExportDirectory(string string_2)
		{
			this.string_0 = string_2;
		}

		// Token: 0x060069EC RID: 27116 RVA: 0x0038E70C File Offset: 0x0038C90C
		public EventExport_Tacview1x(_RunMode enum100_1, string string_2)
		{
			this.bool_11 = false;
			this.concurrentQueue_0 = new ConcurrentQueue<EventExportNotification>();
			this.concurrentDictionary_0 = new ConcurrentDictionary<string, Dictionary<string, int>>();
			this.dictionary_0 = new Dictionary<string, StreamWriter>();
			this.SetRunMode(enum100_1);
			this.SetUseZeroHour(true);
			this.SetExportUnitPositions(true);
			this.SetExportWeaponFired(true);
			this.imethod_25(true);
			this.SetExportWeaponEndgame(true);
			this.SetExportFuelConsumed(false);
			this.SetExportFuelTransfer(false);
			this.SetExportSensorDetectionSuccess(false);
			this.SetExportSensorDetectionFailure(false);
			if (string.IsNullOrEmpty(string_2))
			{
				this.SetExportDirectory(MyTemplate.GetApp().Info.DirectoryPath);
			}
			else
			{
				this.SetExportDirectory(string_2);
			}
			this.StartExport();
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x0002D9D2 File Offset: 0x0002BBD2
		public void StartExport()
		{
			this.thread_0 = new Thread(new ThreadStart(this.method_0));
			this.thread_0.Priority = ThreadPriority.BelowNormal;
			this.thread_0.Start();
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x0038E7C4 File Offset: 0x0038C9C4
		public int GetEventQueueLength()
		{
			return this.concurrentQueue_0.Count;
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x0038E7E0 File Offset: 0x0038C9E0
		public string GetExporterName()
		{
			return "Tacview1x";
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x0002C525 File Offset: 0x0002A725
		public _ExporterType GetExporterType()
		{
			return _ExporterType.Tacview1x;
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x0038E7F4 File Offset: 0x0038C9F4
		private void method_0()
		{
			this.string_1 = Path.Combine(this.GetExportDirectory(), "Tacview1x.acmi");
			if (File.Exists(this.string_1))
			{
				File.Delete(this.string_1);
			}
			while (true)
			{
				Thread.Sleep(100);
				if (!this.bool_11)
				{
					this.method_2();
				}
			}
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x0038E850 File Offset: 0x0038CA50
		public void ExportEvent(ExportedEventType exportedEventType_0, Dictionary<string, Tuple<Type, string>> dictionary_1, Scenario scenario_0)
		{
			EventExportNotification eventExportNotification = new EventExportNotification();
			eventExportNotification.EventType = exportedEventType_0;
			eventExportNotification.EventParameters = dictionary_1;
			eventExportNotification.ParentScen = scenario_0;
			eventExportNotification.FileExportFolder = this.GetExportDirectory();
			this.concurrentQueue_0.Enqueue(eventExportNotification);
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x0038E890 File Offset: 0x0038CA90
		private int method_1(string string_2, string string_3, ref StringBuilder stringBuilder_0, Scenario scenario_0, string string_4)
		{
			int result = 0;
			try
			{
				Dictionary<string, int> dictionary;
				if (!this.concurrentDictionary_0.ContainsKey(string_4))
				{
					dictionary = new Dictionary<string, int>();
					this.concurrentDictionary_0.TryAdd(string_4, dictionary);
				}
				else
				{
					dictionary = this.concurrentDictionary_0[string_4];
				}
				if (scenario_0.GetActiveUnits().ContainsKey(string_2))
				{
					ActiveUnit activeUnit = scenario_0.GetActiveUnits()[string_2];
					if (Information.IsNothing(activeUnit))
					{
						result = 0;
					}
					else
					{
						int num = GameGeneral.GetRandom().Next(1, 2147483647);
						dictionary.Add(string_2, num);
						stringBuilder_0.Append("+" + Conversions.ToString(num));
						if (string.IsNullOrEmpty(string_3))
						{
							stringBuilder_0.Append(",");
						}
						else
						{
							int value;
							if (dictionary.ContainsKey(string_3))
							{
								value = dictionary[string_3];
							}
							else
							{
								value = this.method_1(string_3, null, ref stringBuilder_0, scenario_0, string_4);
							}
							stringBuilder_0.Append(",").Append(value);
						}
						string str = "";
						switch (activeUnit.GetUnitType())
						{
						case GlobalVariables.ActiveUnitType.Aircraft:
							if (((Aircraft)activeUnit).IsRotaryWingAircraft())
							{
								str = "18";
							}
							else
							{
								str = "10";
							}
							break;
						case GlobalVariables.ActiveUnitType.Ship:
							switch (((Ship)activeUnit).Category)
							{
							case Ship._ShipCategory.SurfaceCombatant:
							case Ship._ShipCategory.Amphibious:
							case Ship._ShipCategory.MobileOffshoreBase_AviationCapable:
								str = "34";
								goto IL_3DB;
							case Ship._ShipCategory.Auxiliary:
							case Ship._ShipCategory.Merchant:
							case Ship._ShipCategory.Civilian:
								str = "38";
								goto IL_3DB;
							}
							str = "30";
							break;
						case GlobalVariables.ActiveUnitType.Submarine:
							str = "30";
							break;
						case GlobalVariables.ActiveUnitType.Facility:
						{
							Facility._FacilityCategory category = ((Facility)activeUnit).Category;
							if (category != Facility._FacilityCategory.Mobile_Vehicle)
							{
								if (category != Facility._FacilityCategory.Mobile_Personnel)
								{
									if (category != Facility._FacilityCategory.AirBase)
									{
										str = "88";
									}
									else
									{
										str = "80";
									}
								}
								else
								{
									str = "2C";
								}
							}
							else
							{
								string left = Misc.smethod_45(activeUnit.UnitClass);
								uint num2 = Class382.smethod_0(left);
								if (num2 <= 562859689u)
								{
									if (num2 != 108276744u)
									{
										if (num2 != 536261884u)
										{
											if (num2 != 562859689u)
											{
												goto IL_32D;
											}
											if (Operators.CompareString(left, "Arty", false) != 0)
											{
												goto IL_32D;
											}
										}
										else
										{
											if (Operators.CompareString(left, "SAM", false) != 0)
											{
												goto IL_32D;
											}
											goto IL_339;
										}
									}
									else if (Operators.CompareString(left, "Inf", false) != 0)
									{
										goto IL_32D;
									}
								}
								else if (num2 <= 1142521834u)
								{
									if (num2 != 716611045u)
									{
										if (num2 != 1142521834u)
										{
											goto IL_32D;
										}
										if (Operators.CompareString(left, "SSM", false) != 0)
										{
											goto IL_32D;
										}
									}
									else if (Operators.CompareString(left, "Armored", false) != 0)
									{
										goto IL_32D;
									}
								}
								else if (num2 != 3061902210u)
								{
									if (num2 != 3887666188u || Operators.CompareString(left, "Mech", false) != 0)
									{
										goto IL_32D;
									}
								}
								else
								{
									if (Operators.CompareString(left, "AAA", false) != 0)
									{
										goto IL_32D;
									}
									goto IL_339;
								}
								str = "24";
								break;
								IL_32D:
								str = "28";
								break;
								IL_339:
								str = "20";
							}
							break;
						}
						case GlobalVariables.ActiveUnitType.Weapon:
						{
							Weapon weapon = (Weapon)activeUnit;
							switch (weapon.GetWeaponType())
							{
							case Weapon._WeaponType.GuidedWeapon:
								if (weapon.method_177())
								{
									str = "4C";
								}
								else
								{
									str = "40";
								}
								break;
							case Weapon._WeaponType.Rocket:
								str = "44";
								break;
							case Weapon._WeaponType.Gun:
								if (weapon.m_Warheads.Any<Warhead>())
								{
									Warhead.WarheadCaliber caliber = weapon.m_Warheads[0].Caliber;
									if (caliber == Warhead.WarheadCaliber.Gun_6_15mm)
									{
										str = "49";
									}
									else
									{
										str = "48";
									}
								}
								break;
							}
							break;
						}
						}
						IL_3DB:
						stringBuilder_0.Append("," + str);
						stringBuilder_0.Append(",").Append(Array.IndexOf<Side>(scenario_0.GetSides(), activeUnit.GetSide(false)));
						stringBuilder_0.Append(",");
						string value2 = this.method_4(activeUnit.UnitClass);
						stringBuilder_0.Append(",").Append(value2);
						stringBuilder_0.Append(",").Append(this.method_4(activeUnit.Name));
						stringBuilder_0.Append(",");
						stringBuilder_0.Append(",");
						result = num;
					}
				}
				else if (scenario_0.GetUnguidedWeapons().ContainsKey(string_2))
				{
					UnguidedWeapon unguidedWeapon = scenario_0.GetUnguidedWeapons()[string_2];
					if (Information.IsNothing(unguidedWeapon))
					{
						result = 0;
					}
					else
					{
						int num3 = GameGeneral.GetRandom().Next(1, 2147483647);
						dictionary.Add(string_2, num3);
						stringBuilder_0.Append("+" + Conversions.ToString(num3));
						if (string.IsNullOrEmpty(string_3))
						{
							stringBuilder_0.Append(",");
						}
						else
						{
							int value3;
							if (dictionary.ContainsKey(string_3))
							{
								value3 = dictionary[string_3];
							}
							else
							{
								value3 = this.method_1(string_3, null, ref stringBuilder_0, scenario_0, string_4);
							}
							stringBuilder_0.Append(",").Append(value3);
						}
						string str2 = "";
						switch (unguidedWeapon.GetWeaponType())
						{
						case Weapon._WeaponType.Rocket:
							str2 = "44";
							break;
						case Weapon._WeaponType.IronBomb:
							str2 = "4C";
							break;
						case Weapon._WeaponType.Gun:
						{
							Warhead.WarheadCaliber caliber2 = unguidedWeapon.WarheadArray[0].Caliber;
							if (caliber2 - Warhead.WarheadCaliber.Gun_6_15mm <= 1)
							{
								str2 = "48";
							}
							else
							{
								str2 = "4A";
							}
							break;
						}
						}
						stringBuilder_0.Append("," + str2);
						stringBuilder_0.Append(",").Append(Array.IndexOf<Side>(scenario_0.GetSides(), unguidedWeapon.GetFiringParent().GetSide(false)));
						stringBuilder_0.Append(",");
						string value4 = this.method_4(unguidedWeapon.UnitClass);
						stringBuilder_0.Append(",").Append(value4);
						stringBuilder_0.Append(",").Append(this.method_4(unguidedWeapon.Name));
						stringBuilder_0.Append(",");
						stringBuilder_0.Append(",");
						result = num3;
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x0038EF38 File Offset: 0x0038D138
		private void method_2()
		{
			this.bool_11 = true;
			try
			{
				EventExportNotification eventExportNotification = null;
				while (this.concurrentQueue_0.Count > 0)
				{
					this.concurrentQueue_0.TryDequeue(out eventExportNotification);
					if (!Information.IsNothing(eventExportNotification))
					{
						this.string_1 = Path.Combine(eventExportNotification.FileExportFolder, "Tacview1x.acmi");
						Dictionary<string, int> dictionary;
						if (!this.concurrentDictionary_0.ContainsKey(this.string_1))
						{
							dictionary = new Dictionary<string, int>();
							this.concurrentDictionary_0.TryAdd(this.string_1, dictionary);
						}
						else
						{
							dictionary = this.concurrentDictionary_0[this.string_1];
						}
						StreamWriter streamWriter;
						if (this.dictionary_0.ContainsKey(this.string_1))
						{
							streamWriter = this.dictionary_0[this.string_1];
						}
						else
						{
							this.method_3(this.string_1, eventExportNotification.EventParameters, eventExportNotification.ParentScen);
							streamWriter = File.AppendText(this.string_1);
							streamWriter.AutoFlush = true;
							this.dictionary_0.Add(this.string_1, streamWriter);
						}
						StringBuilder stringBuilder = new StringBuilder();
						TimeSpan timeSpan = TimeSpan.Parse(eventExportNotification.EventParameters["Time"].Item2);
						stringBuilder.Append("#" + Conversions.ToString(Math.Floor(timeSpan.TotalSeconds)) + "." + Conversions.ToString(timeSpan.Milliseconds)).Append("\r\n");
						switch (eventExportNotification.EventType)
						{
						case ExportedEventType.WeaponFired:
						{
							string item = eventExportNotification.EventParameters["WeaponID"].Item2;
							string item2 = eventExportNotification.EventParameters["FiringUnitID"].Item2;
							if (!dictionary.ContainsKey(item2))
							{
								this.method_1(item2, null, ref stringBuilder, eventExportNotification.ParentScen, this.string_1);
								stringBuilder.Append("\r\n");
							}
							this.method_1(item, item2, ref stringBuilder, eventExportNotification.ParentScen, this.string_1);
							break;
						}
						case ExportedEventType.WeaponEndgame:
						{
							string item3 = eventExportNotification.EventParameters["WeaponID"].Item2;
							string item4 = eventExportNotification.EventParameters["Result"].Item2;
							if (Operators.CompareString(item4, "HIT", false) != 0 && Operators.CompareString(item4, "KILL", false) != 0)
							{
								continue;
							}
							int num;
							if (dictionary.ContainsKey(item3))
							{
								num = dictionary[item3];
							}
							else
							{
								num = this.method_1(item3, null, ref stringBuilder, eventExportNotification.ParentScen, this.string_1);
							}
							string item5 = eventExportNotification.EventParameters["TargetID"].Item2;
							int num2;
							if (dictionary.ContainsKey(item5))
							{
								num2 = dictionary[item5];
							}
							else
							{
								num2 = this.method_1(item5, null, ref stringBuilder, eventExportNotification.ParentScen, this.string_1);
							}
							if (num == 0)
							{
								continue;
							}
							stringBuilder.Append("!2C,").Append(num);
							if (num2 > 0)
							{
								stringBuilder.Append(",").Append(num2);
							}
							dictionary[item3] = 0;
							stringBuilder.Append("\r\n");
							int value = GameGeneral.GetRandom().Next(1, 2147483647);
							stringBuilder.Append("+").Append(value.ToString()).Append(",,").Append("E0,,,Explosion,,,");
							stringBuilder.Append("\r\n");
							stringBuilder.Append(value);
							stringBuilder.Append(",");
							stringBuilder.Append(eventExportNotification.EventParameters["TargetLatitude"].Item2);
							stringBuilder.Append(",");
							stringBuilder.Append(eventExportNotification.EventParameters["TargetLongitude"].Item2);
							stringBuilder.Append(",");
							stringBuilder.Append(eventExportNotification.EventParameters["TargetAltitude_ASL_m"].Item2);
							break;
						}
						case ExportedEventType.UnitDestroyed:
						{
							string item6 = eventExportNotification.EventParameters["UnitID"].Item2;
							if (!dictionary.ContainsKey(item6))
							{
								continue;
							}
							int num3 = dictionary[item6];
							if (num3 == 0)
							{
								continue;
							}
							stringBuilder.Append("!2C,").Append(num3);
							dictionary[item6] = 0;
							break;
						}
						case ExportedEventType.UnitPositions:
						{
							string item7 = eventExportNotification.EventParameters["UnitID"].Item2;
							ActiveUnit activeUnit = null;
							if (eventExportNotification.ParentScen.GetActiveUnits().ContainsKey(item7))
							{
								activeUnit = eventExportNotification.ParentScen.GetActiveUnits()[item7];
								if (Information.IsNothing(activeUnit))
								{
									continue;
								}
								if (activeUnit.IsNotActive())
								{
									continue;
								}
							}
							else if (eventExportNotification.ParentScen.GetUnguidedWeapons().ContainsKey(item7) && Information.IsNothing(eventExportNotification.ParentScen.GetUnguidedWeapons()[item7]))
							{
								continue;
							}
							int num4;
							if (dictionary.ContainsKey(item7))
							{
								num4 = dictionary[item7];
								if (!Information.IsNothing(activeUnit) && Conversions.ToSingle(eventExportNotification.EventParameters["UnitSpeed_kts"].Item2) == 0f)
								{
									continue;
								}
							}
							else
							{
								num4 = this.method_1(item7, null, ref stringBuilder, eventExportNotification.ParentScen, this.string_1);
								stringBuilder.Append("\r\n");
							}
							if (num4 == 0)
							{
								continue;
							}
							stringBuilder.Append(num4);
							stringBuilder.Append(",");
							stringBuilder.Append(eventExportNotification.EventParameters["UnitLatitude"].Item2);
							stringBuilder.Append(",");
							stringBuilder.Append(eventExportNotification.EventParameters["UnitLongitude"].Item2);
							stringBuilder.Append(",");
							stringBuilder.Append(eventExportNotification.EventParameters["UnitAltitude_m"].Item2);
							if (!Information.IsNothing(activeUnit) && activeUnit.IsAircraft)
							{
								stringBuilder.Append(",").Append(eventExportNotification.EventParameters["UnitAttitude_Roll"].Item2);
								stringBuilder.Append(",?");
							}
							else
							{
								stringBuilder.Append(",?");
								stringBuilder.Append(",?");
							}
							stringBuilder.Append(",").Append(eventExportNotification.EventParameters["UnitCourse"].Item2);
							break;
						}
						}
						streamWriter.WriteLine(stringBuilder.ToString());
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			finally
			{
				this.bool_11 = false;
			}
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x0038F630 File Offset: 0x0038D830
		private void method_3(string string_2, Dictionary<string, Tuple<Type, string>> dictionary_1, Scenario scenario_0)
		{
			checked
			{
				try
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("FileType=text/acmi/tacview").Append("\r\n");
					stringBuilder.Append("FileVersion=1.7").Append("\r\n");
					stringBuilder.Append("Source=" + GameGeneral.strVersion).Append("\r\n");
					stringBuilder.Append("Recorder=Tacview 1.4.0").Append("\r\n");
					stringBuilder.Append("RecordingTime=" + DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss")).Append("\r\n");
					stringBuilder.Append("Author=Dimitris").Append("\r\n");
					stringBuilder.Append("MissionTime=" + scenario_0.GetCurrentTime(false).ToString("yyyy-MM-ddThh:mm:ss")).Append("Z").Append("\r\n");
					Side[] sides = scenario_0.GetSides();
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						stringBuilder.Append("Coalition=" + side.GetSideName() + ",");
						if (side == scenario_0.GetSides().First<Side>())
						{
							stringBuilder.Append("Blue").Append("\r\n");
						}
						else
						{
							switch (scenario_0.GetSides()[0].GetPostureStance(side))
							{
							case Misc.PostureStance.Neutral:
								stringBuilder.Append("Green").Append("\r\n");
								break;
							case Misc.PostureStance.Friendly:
								stringBuilder.Append("Blue").Append("\r\n");
								break;
							case Misc.PostureStance.Unfriendly:
								stringBuilder.Append("Orange").Append("\r\n");
								break;
							case Misc.PostureStance.Hostile:
								stringBuilder.Append("Red").Append("\r\n");
								break;
							}
						}
					}
					stringBuilder.Append("ProvidedEvents=Removed,Destroyed").Append("\r\n");
					File.WriteAllText(string_2, stringBuilder.ToString());
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x0038F878 File Offset: 0x0038DA78
		private string method_4(string string_2)
		{
			string result;
			if (string.IsNullOrEmpty(string_2))
			{
				result = string_2;
			}
			else
			{
				if (string_2.Contains(","))
				{
					string_2 = string_2.Replace(",", "\\,");
				}
				if (string_2.Contains("="))
				{
					string_2 = string_2.Replace("=", "\\=");
				}
				result = string_2;
			}
			return result;
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x0038F8E4 File Offset: 0x0038DAE4
		public void StopExport()
		{
			if (!Information.IsNothing(this.thread_0))
			{
				this.thread_0.Abort();
				this.thread_0 = null;
			}
			this.concurrentQueue_0 = new ConcurrentQueue<EventExportNotification>();
			this.concurrentDictionary_0.Clear();
			foreach (StreamWriter current in this.dictionary_0.Values)
			{
				if (!Information.IsNothing(current))
				{
					current.Close();
					current.Dispose();
				}
			}
			this.dictionary_0.Clear();
			this.bool_11 = false;
		}

		// Token: 0x04003B98 RID: 15256
		[CompilerGenerated]
		private _RunMode runMode;

		// Token: 0x04003B99 RID: 15257
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04003B9A RID: 15258
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04003B9B RID: 15259
		[CompilerGenerated]
		private bool bool_2 = false;

		// Token: 0x04003B9C RID: 15260
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x04003B9D RID: 15261
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x04003B9E RID: 15262
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x04003B9F RID: 15263
		[CompilerGenerated]
		private bool bool_6;

		// Token: 0x04003BA0 RID: 15264
		[CompilerGenerated]
		private bool bool_7;

		// Token: 0x04003BA1 RID: 15265
		[CompilerGenerated]
		private bool bool_8;

		// Token: 0x04003BA2 RID: 15266
		[CompilerGenerated]
		private bool bool_9;

		// Token: 0x04003BA3 RID: 15267
		[CompilerGenerated]
		private bool bool_10;

		// Token: 0x04003BA4 RID: 15268
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003BA5 RID: 15269
		private string string_1;

		// Token: 0x04003BA6 RID: 15270
		private bool bool_11;

		// Token: 0x04003BA7 RID: 15271
		private ConcurrentQueue<EventExportNotification> concurrentQueue_0;

		// Token: 0x04003BA8 RID: 15272
		private ConcurrentDictionary<string, Dictionary<string, int>> concurrentDictionary_0;

		// Token: 0x04003BA9 RID: 15273
		private Dictionary<string, StreamWriter> dictionary_0;

		// Token: 0x04003BAA RID: 15274
		private Thread thread_0;
	}
}

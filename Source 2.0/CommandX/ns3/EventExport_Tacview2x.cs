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

namespace ns3
{
	// Token: 0x02000BBC RID: 3004
	public sealed class EventExport_Tacview2x : IEventExporter
	{
		// Token: 0x0600637D RID: 25469 RVA: 0x00313D44 File Offset: 0x00311F44
		[CompilerGenerated]
		public _RunMode GetRunMode()
		{
			return this.enum100_0;
		}

		// Token: 0x0600637E RID: 25470 RVA: 0x0002B87E File Offset: 0x00029A7E
		[CompilerGenerated]
		public void SetRunMode(_RunMode enum100_1)
		{
			this.enum100_0 = enum100_1;
		}

		// Token: 0x0600637F RID: 25471 RVA: 0x0002B887 File Offset: 0x00029A87
		[CompilerGenerated]
		public bool IsExportEngagementCycle()
		{
			return this.bool_0;
		}

		// Token: 0x06006380 RID: 25472 RVA: 0x0002B88F File Offset: 0x00029A8F
		[CompilerGenerated]
		public void SetExportEngagementCycle(bool bool_11)
		{
			this.bool_0 = bool_11;
		}

		// Token: 0x06006381 RID: 25473 RVA: 0x0002B898 File Offset: 0x00029A98
		[CompilerGenerated]
		public bool IsExportSensorDetectionFailure()
		{
			return this.bool_1;
		}

		// Token: 0x06006382 RID: 25474 RVA: 0x0002B8A0 File Offset: 0x00029AA0
		[CompilerGenerated]
		public void SetExportSensorDetectionFailure(bool bool_11)
		{
			this.bool_1 = bool_11;
		}

		// Token: 0x06006383 RID: 25475 RVA: 0x0002B8A9 File Offset: 0x00029AA9
		[CompilerGenerated]
		public bool IsExportSensorDetectionSuccess()
		{
			return this.bool_2;
		}

		// Token: 0x06006384 RID: 25476 RVA: 0x0002B8B1 File Offset: 0x00029AB1
		[CompilerGenerated]
		public void SetExportSensorDetectionSuccess(bool bool_11)
		{
			this.bool_2 = bool_11;
		}

		// Token: 0x06006385 RID: 25477 RVA: 0x0002B8BA File Offset: 0x00029ABA
		[CompilerGenerated]
		public bool IsExportUnitPositions()
		{
			return this.bool_3;
		}

		// Token: 0x06006386 RID: 25478 RVA: 0x0002B8C2 File Offset: 0x00029AC2
		[CompilerGenerated]
		public void SetExportUnitPositions(bool bool_11)
		{
			this.bool_3 = bool_11;
		}

		// Token: 0x06006387 RID: 25479 RVA: 0x0002B8CB File Offset: 0x00029ACB
		[CompilerGenerated]
		public bool IsExportWeaponEndgame()
		{
			return this.bool_4;
		}

		// Token: 0x06006388 RID: 25480 RVA: 0x0002B8D3 File Offset: 0x00029AD3
		[CompilerGenerated]
		public void SetExportWeaponEndgame(bool bool_11)
		{
			this.bool_4 = bool_11;
		}

		// Token: 0x06006389 RID: 25481 RVA: 0x0002B8DC File Offset: 0x00029ADC
		[CompilerGenerated]
		public bool IsExportWeaponFired()
		{
			return this.bool_5;
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x0002B8E4 File Offset: 0x00029AE4
		[CompilerGenerated]
		public void SetExportWeaponFired(bool bool_11)
		{
			this.bool_5 = bool_11;
		}

		// Token: 0x0600638B RID: 25483 RVA: 0x0002B8ED File Offset: 0x00029AED
		[CompilerGenerated]
		public bool imethod_24()
		{
			return this.bool_6;
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x0002B8F5 File Offset: 0x00029AF5
		[CompilerGenerated]
		public void imethod_25(bool bool_11)
		{
			this.bool_6 = bool_11;
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x0002B8FE File Offset: 0x00029AFE
		[CompilerGenerated]
		public bool IsExportFuelConsumed()
		{
			return this.bool_7;
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x0002B906 File Offset: 0x00029B06
		[CompilerGenerated]
		public void SetExportFuelConsumed(bool bool_11)
		{
			this.bool_7 = bool_11;
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x0002B90F File Offset: 0x00029B0F
		[CompilerGenerated]
		public bool IsExportFuelTransfer()
		{
			return this.bool_8;
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x0002B917 File Offset: 0x00029B17
		[CompilerGenerated]
		public void SetExportFuelTransfer(bool bool_11)
		{
			this.bool_8 = bool_11;
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x0002B920 File Offset: 0x00029B20
		[CompilerGenerated]
		public bool IsUseZeroHour()
		{
			return this.bool_9;
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x0002B928 File Offset: 0x00029B28
		[CompilerGenerated]
		public void SetUseZeroHour(bool bool_11)
		{
			this.bool_9 = bool_11;
		}

		// Token: 0x06006393 RID: 25491 RVA: 0x00313D5C File Offset: 0x00311F5C
		[CompilerGenerated]
		public string GetExportDirectory()
		{
			return this.string_0;
		}

		// Token: 0x06006394 RID: 25492 RVA: 0x0002B931 File Offset: 0x00029B31
		[CompilerGenerated]
		public void SetExportDirectory(string string_2)
		{
			this.string_0 = string_2;
		}

		// Token: 0x06006395 RID: 25493 RVA: 0x00313D74 File Offset: 0x00311F74
		public EventExport_Tacview2x(_RunMode enum100_1, string string_2)
		{
			this.bool_10 = false;
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

		// Token: 0x06006396 RID: 25494 RVA: 0x0002B93A File Offset: 0x00029B3A
		public void StartExport()
		{
			this.thread_0 = new Thread(new ThreadStart(this.method_0));
			this.thread_0.Priority = ThreadPriority.BelowNormal;
			this.thread_0.Start();
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x00313E2C File Offset: 0x0031202C
		public int GetEventQueueLength()
		{
			return this.concurrentQueue_0.Count;
		}

		// Token: 0x06006398 RID: 25496 RVA: 0x00313E48 File Offset: 0x00312048
		public string GetExporterName()
		{
			return "Tacview2x";
		}

		// Token: 0x06006399 RID: 25497 RVA: 0x0002B96A File Offset: 0x00029B6A
		public _ExporterType GetExporterType()
		{
			return _ExporterType.Tacview2x;
		}

		// Token: 0x0600639A RID: 25498 RVA: 0x0000945D File Offset: 0x0000765D
		public bool imethod_30()
		{
			return true;
		}

		// Token: 0x0600639B RID: 25499 RVA: 0x00313E5C File Offset: 0x0031205C
		private void method_0()
		{
			this.string_1 = Path.Combine(this.GetExportDirectory(), "Tacview2x.acmi");
			if (File.Exists(this.string_1))
			{
				File.Delete(this.string_1);
			}
			while (true)
			{
				Thread.Sleep(100);
				if (!this.bool_10)
				{
					this.method_4();
				}
			}
		}

		// Token: 0x0600639C RID: 25500 RVA: 0x00313EB8 File Offset: 0x003120B8
		public void ExportEvent(ExportedEventType exportedEventType_0, Dictionary<string, Tuple<Type, string>> dictionary_1, Scenario scenario_0)
		{
			EventExportNotification eventExportNotification = new EventExportNotification();
			eventExportNotification.EventType = exportedEventType_0;
			eventExportNotification.EventParameters = dictionary_1;
			eventExportNotification.ParentScen = scenario_0;
			eventExportNotification.FileExportFolder = this.GetExportDirectory();
			this.concurrentQueue_0.Enqueue(eventExportNotification);
		}

		// Token: 0x0600639D RID: 25501 RVA: 0x00313EF8 File Offset: 0x003120F8
		private void method_1(Unit unit_0, ref StringBuilder stringBuilder_0, EventExportNotification eventExportNotification_0)
		{
			try
			{
				stringBuilder_0.Append("T=");
				if (eventExportNotification_0.EventType == ExportedEventType.WeaponFired)
				{
					stringBuilder_0.Append(eventExportNotification_0.EventParameters["FiringUnitLongitude"].Item2).Append("|");
					stringBuilder_0.Append(eventExportNotification_0.EventParameters["FiringUnitLatitude"].Item2).Append("|");
					stringBuilder_0.Append(eventExportNotification_0.EventParameters["FiringUnitAltitude_m"].Item2);
				}
				else if (eventExportNotification_0.EventType != ExportedEventType.WeaponEndgame)
				{
					if (unit_0.IsAircraft)
					{
						stringBuilder_0.Append(eventExportNotification_0.EventParameters["UnitLongitude"].Item2).Append("|");
						stringBuilder_0.Append(eventExportNotification_0.EventParameters["UnitLatitude"].Item2).Append("|");
						stringBuilder_0.Append(eventExportNotification_0.EventParameters["UnitAltitude_m"].Item2);
						stringBuilder_0.Append("|");
						if (unit_0.IsAircraft)
						{
							stringBuilder_0.Append(eventExportNotification_0.EventParameters["UnitAttitude_Roll"].Item2);
						}
						stringBuilder_0.Append("|");
						if (unit_0.IsOfAirLaunchedGuidedWeapon() | unit_0.IsAircraft)
						{
							stringBuilder_0.Append(eventExportNotification_0.EventParameters["UnitAttitude_Pitch"].Item2);
						}
						stringBuilder_0.Append("|");
						stringBuilder_0.Append(eventExportNotification_0.EventParameters["UnitCourse"].Item2);
						stringBuilder_0.Append(",");
						stringBuilder_0.Append("HDG=").Append(eventExportNotification_0.EventParameters["UnitCourse"].Item2);
					}
					else
					{
						stringBuilder_0.Append(eventExportNotification_0.EventParameters["UnitLongitude"].Item2).Append("|");
						stringBuilder_0.Append(eventExportNotification_0.EventParameters["UnitLatitude"].Item2).Append("|");
						stringBuilder_0.Append(eventExportNotification_0.EventParameters["UnitAltitude_m"].Item2);
						stringBuilder_0.Append(",");
						stringBuilder_0.Append("HDG=").Append(eventExportNotification_0.EventParameters["UnitCourse"].Item2);
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
		}

		// Token: 0x0600639E RID: 25502 RVA: 0x003141C8 File Offset: 0x003123C8
		private void method_2(Unit unit_0, ref StringBuilder stringBuilder_0)
		{
			stringBuilder_0.Append("Type=");
			if (unit_0.IsActiveUnit())
			{
				ActiveUnit activeUnit = (ActiveUnit)unit_0;
				if (activeUnit.IsFixedFacility())
				{
					stringBuilder_0.Append("Static");
				}
				else if (activeUnit.IsSatellite())
				{
					stringBuilder_0.Append("Medium");
				}
				else
				{
					switch (activeUnit.GetTargetVisualSizeClass())
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						stringBuilder_0.Append("Minor");
						break;
					case GlobalVariables.TargetVisualSizeClass.Small:
						stringBuilder_0.Append("Light");
						break;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						stringBuilder_0.Append("Medium");
						break;
					case GlobalVariables.TargetVisualSizeClass.Large:
					case GlobalVariables.TargetVisualSizeClass.VLarge:
						stringBuilder_0.Append("Heavy");
						break;
					}
				}
				switch (activeUnit.GetUnitType())
				{
				case GlobalVariables.ActiveUnitType.Aircraft:
					stringBuilder_0.Append("+Air");
					if (!((Aircraft)activeUnit).IsRotaryWingAircraft())
					{
						stringBuilder_0.Append("+FixedWing");
					}
					else
					{
						stringBuilder_0.Append("+Rotorcraft");
					}
					break;
				case GlobalVariables.ActiveUnitType.Ship:
				{
					stringBuilder_0.Append("+Sea");
					Ship._ShipCategory category = ((Ship)activeUnit).Category;
					if (category != Ship._ShipCategory.SurfaceCombatant)
					{
						if (category == Ship._ShipCategory.Carrier)
						{
							stringBuilder_0.Append("+Warship");
							break;
						}
						if (category != Ship._ShipCategory.SurfaceCombatant_AviationCapable)
						{
							break;
						}
					}
					stringBuilder_0.Append("+AircraftCarrier");
					break;
				}
				case GlobalVariables.ActiveUnitType.Submarine:
					stringBuilder_0.Append("+Sea");
					break;
				case GlobalVariables.ActiveUnitType.Facility:
					stringBuilder_0.Append("+Ground");
					if (activeUnit.IsFixedFacility())
					{
						if (!activeUnit.HasAirFacilities())
						{
							stringBuilder_0.Append("+Building");
						}
						else if (activeUnit.GetAirFacilities()[0].method_35())
						{
							stringBuilder_0.Append("+Aerodrome");
						}
						else
						{
							stringBuilder_0.Append("+Building");
						}
					}
					else
					{
						switch (((Facility)activeUnit).GetMobileUnitCategory())
						{
						case Facility._MobileUnitCategory.Infrantry:
							stringBuilder_0.Append("+Human");
							break;
						case Facility._MobileUnitCategory.Armor:
							stringBuilder_0.Append("+Armor+Tank");
							break;
						case Facility._MobileUnitCategory.AAA:
						case Facility._MobileUnitCategory.SAM:
							stringBuilder_0.Append("+AntiAircraft");
							break;
						case Facility._MobileUnitCategory.Engineer:
						case Facility._MobileUnitCategory.MechanizedInfantry:
							stringBuilder_0.Append("+Vehicle");
							break;
						}
					}
					break;
				case GlobalVariables.ActiveUnitType.Weapon:
				{
					stringBuilder_0.Append("+Weapon");
					Weapon._WeaponType weaponType = ((Weapon)activeUnit).GetWeaponType();
					if (weaponType <= Weapon._WeaponType.GuidedProjectile)
					{
						if (weaponType == Weapon._WeaponType.GuidedWeapon)
						{
							stringBuilder_0.Append("+Missile");
						}
						else if (weaponType - Weapon._WeaponType.Decoy_Expendable <= 1)
						{
							stringBuilder_0.Append("+Decoy");
						}
						else if (weaponType == Weapon._WeaponType.GuidedProjectile)
						{
							stringBuilder_0.Append("+Projectile");
						}
					}
					else if (weaponType == Weapon._WeaponType.Torpedo)
					{
						stringBuilder_0.Append("+Torpedo");
					}
					else if (weaponType == Weapon._WeaponType.RV || weaponType == Weapon._WeaponType.HGV)
					{
						stringBuilder_0.Append("+Missile");
					}
					break;
				}
				}
			}
			else if (unit_0.GetType() == typeof(UnguidedWeapon))
			{
				stringBuilder_0.Append("+Weapon");
				switch (((UnguidedWeapon)unit_0).GetWeaponType())
				{
				case Weapon._WeaponType.Rocket:
					stringBuilder_0.Append("+Rocket");
					break;
				case Weapon._WeaponType.IronBomb:
					stringBuilder_0.Append("+Bomb");
					break;
				case Weapon._WeaponType.Gun:
					stringBuilder_0.Append("+Projectile");
					if (((UnguidedWeapon)unit_0).WarheadArray.Length > 0)
					{
						Warhead.WarheadCaliber caliber = ((UnguidedWeapon)unit_0).WarheadArray[0].Caliber;
						if (caliber == Warhead.WarheadCaliber.Gun_6_15mm)
						{
							stringBuilder_0.Append("+Bullet");
						}
						else
						{
							stringBuilder_0.Append("+Shell");
						}
					}
					break;
				}
			}
			else if (unit_0.GetType() == typeof(WeaponImpact))
			{
				stringBuilder_0.Append("+Explosion");
			}
		}

		// Token: 0x0600639F RID: 25503 RVA: 0x00314634 File Offset: 0x00312834
		private int method_3(string string_2, string string_3, ref StringBuilder stringBuilder_0, Scenario scenario_0, string string_4, EventExportNotification eventExportNotification_0)
		{
			EventExport_Tacview2x.Class251 @class = new EventExport_Tacview2x.Class251();
			@class.string_0 = string_2;
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
				if (scenario_0.GetActiveUnits().ContainsKey(@class.string_0))
				{
					ActiveUnit activeUnit = scenario_0.GetActiveUnits()[@class.string_0];
					if (Information.IsNothing(activeUnit))
					{
						result = 0;
					}
					else if (string.IsNullOrEmpty(activeUnit.UnitClass))
					{
						result = 0;
					}
					else
					{
						int num = GameGeneral.GetRandom().Next(1, 2147483647);
						dictionary.Add(@class.string_0, num);
						stringBuilder_0.Append(num).Append(",");
						this.method_1(activeUnit, ref stringBuilder_0, eventExportNotification_0);
						stringBuilder_0.Append(",");
						this.method_2(activeUnit, ref stringBuilder_0);
						stringBuilder_0.Append(",");
						switch (activeUnit.GetUnitType())
						{
						case GlobalVariables.ActiveUnitType.Aircraft:
							stringBuilder_0.Append("Length=").Append(((Aircraft)activeUnit).Length).Append(",");
							stringBuilder_0.Append("Width=").Append(((Aircraft)activeUnit).Span).Append(",");
							break;
						case GlobalVariables.ActiveUnitType.Ship:
							stringBuilder_0.Append("Length=").Append(((Ship)activeUnit).Length).Append(",");
							stringBuilder_0.Append("Width=").Append(((Ship)activeUnit).Beam).Append(",");
							break;
						case GlobalVariables.ActiveUnitType.Submarine:
							stringBuilder_0.Append("Length=").Append(((Submarine)activeUnit).Length).Append(",");
							stringBuilder_0.Append("Width=").Append(((Submarine)activeUnit).Beam).Append(",");
							break;
						case GlobalVariables.ActiveUnitType.Facility:
							stringBuilder_0.Append("Length=").Append(((Facility)activeUnit).Length).Append(",");
							stringBuilder_0.Append("Width=").Append(((Facility)activeUnit).Width).Append(",");
							if (!activeUnit.HasAirFacilities() || !activeUnit.GetAirFacilities()[0].method_35())
							{
								double value = (double)(((Facility)activeUnit).Length / 4f);
								stringBuilder_0.Append("Height=").Append(value).Append(",");
							}
							break;
						}
						if (eventExportNotification_0.EventType == ExportedEventType.WeaponFired)
						{
							stringBuilder_0.Append("Coalition=").Append(eventExportNotification_0.EventParameters["FiringUnitSide"].Item2);
						}
						else
						{
							stringBuilder_0.Append("Coalition=").Append(eventExportNotification_0.EventParameters["UnitSide"].Item2);
						}
						stringBuilder_0.Append(",");
						string value2 = "";
						if (activeUnit.GetSide(false) == scenario_0.GetSides()[0])
						{
							value2 = "Blue";
						}
						else
						{
							switch (scenario_0.GetSides()[0].GetPostureStance(activeUnit.GetSide(false)))
							{
							case Misc.PostureStance.Neutral:
								value2 = "White";
								break;
							case Misc.PostureStance.Friendly:
								value2 = "Blue";
								break;
							case Misc.PostureStance.Unfriendly:
								value2 = "Orange";
								break;
							case Misc.PostureStance.Hostile:
								value2 = "Red";
								break;
							}
						}
						stringBuilder_0.Append("Color=").Append(value2);
						stringBuilder_0.Append(",Name=").Append(activeUnit.UnitClass.Replace(",", ".")).Append(",Pilot=").Append(activeUnit.Name.Replace(",", "."));
						if (!Information.IsNothing(activeUnit.GetParentGroup(false)))
						{
							stringBuilder_0.Append(",Group=").Append(activeUnit.GetParentGroup(false).Name);
						}
						if (!string.IsNullOrEmpty(string_3))
						{
							int value3;
							if (dictionary.ContainsKey(string_3))
							{
								value3 = dictionary[string_3];
							}
							else
							{
								value3 = this.method_3(string_3, null, ref stringBuilder_0, scenario_0, string_4, eventExportNotification_0);
							}
							stringBuilder_0.Append(",Parent=").Append(value3);
						}
						result = num;
					}
				}
				else if (scenario_0.GetUnguidedWeapons().ContainsKey(@class.string_0))
				{
					UnguidedWeapon unguidedWeapon = scenario_0.GetUnguidedWeapons()[@class.string_0];
					if (Information.IsNothing(unguidedWeapon))
					{
						result = 0;
					}
					else
					{
						int num2 = GameGeneral.GetRandom().Next(1, 2147483647);
						dictionary.Add(@class.string_0, num2);
						stringBuilder_0.Append(num2).Append(",");
						this.method_1(unguidedWeapon, ref stringBuilder_0, eventExportNotification_0);
						stringBuilder_0.Append(",");
						this.method_2(unguidedWeapon, ref stringBuilder_0);
						stringBuilder_0.Append(",");
						stringBuilder_0.Append("Coalition=").Append(eventExportNotification_0.EventParameters["UnitSide"].Item2);
						stringBuilder_0.Append(",");
						string value4 = "";
						if (unguidedWeapon.GetSide(false) == scenario_0.GetSides()[0])
						{
							value4 = "Blue";
						}
						else
						{
							switch (scenario_0.GetSides()[0].GetPostureStance(unguidedWeapon.GetSide(false)))
							{
							case Misc.PostureStance.Neutral:
								value4 = "White";
								break;
							case Misc.PostureStance.Friendly:
								value4 = "Blue";
								break;
							case Misc.PostureStance.Unfriendly:
								value4 = "Orange";
								break;
							case Misc.PostureStance.Hostile:
								value4 = "Red";
								break;
							}
						}
						stringBuilder_0.Append("Color=").Append(value4);
						stringBuilder_0.Append(",Name=").Append(unguidedWeapon.UnitClass.Replace(",", ".")).Append(",Pilot=").Append(unguidedWeapon.Name.Replace(",", "."));
						if (!string.IsNullOrEmpty(string_3))
						{
							int value5;
							if (dictionary.ContainsKey(string_3))
							{
								value5 = dictionary[string_3];
							}
							else
							{
								value5 = this.method_3(string_3, null, ref stringBuilder_0, scenario_0, string_4, eventExportNotification_0);
							}
							stringBuilder_0.Append(",Parent=").Append(value5);
						}
						result = num2;
					}
				}
				else if (scenario_0.GetWeaponImpacts().Where(new Func<WeaponImpact, bool>(@class.method_0)).Count<WeaponImpact>() > 0)
				{
					WeaponImpact weaponImpact = scenario_0.GetWeaponImpacts().Where(new Func<WeaponImpact, bool>(@class.method_1)).ElementAtOrDefault(0);
					if (Information.IsNothing(weaponImpact))
					{
						result = 0;
					}
					else
					{
						int num3 = GameGeneral.GetRandom().Next(1, 2147483647);
						dictionary.Add(@class.string_0, num3);
						stringBuilder_0.Append(num3).Append(",");
						this.method_1(weaponImpact, ref stringBuilder_0, eventExportNotification_0);
						stringBuilder_0.Append(",Type=Misc+Explosion");
						stringBuilder_0.Append("\r\n");
						TimeSpan timeSpan = TimeSpan.Parse(eventExportNotification_0.EventParameters["Time"].Item2);
						stringBuilder_0.Append("#" + Conversions.ToString(Math.Floor(timeSpan.Add(new TimeSpan(0, 0, 5)).TotalSeconds)) + "." + timeSpan.Milliseconds.ToString("D3")).Append("\r\n");
						stringBuilder_0.Append("-").Append(num3);
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

		// Token: 0x060063A0 RID: 25504 RVA: 0x00314E34 File Offset: 0x00313034
		private void method_4()
		{
			this.bool_10 = true;
			try
			{
				EventExportNotification eventExportNotification = null;
				while (this.concurrentQueue_0.Count > 0)
				{
					this.concurrentQueue_0.TryDequeue(out eventExportNotification);
					if (!Information.IsNothing(eventExportNotification))
					{
						this.string_1 = Path.Combine(eventExportNotification.FileExportFolder, "Tacview2x.acmi");
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
							this.method_5(this.string_1, eventExportNotification.EventParameters, eventExportNotification.ParentScen);
							streamWriter = File.AppendText(this.string_1);
							streamWriter.AutoFlush = true;
							this.dictionary_0.Add(this.string_1, streamWriter);
						}
						StringBuilder stringBuilder = new StringBuilder();
						TimeSpan timeSpan = TimeSpan.Parse(eventExportNotification.EventParameters["Time"].Item2);
						stringBuilder.Append("#" + Conversions.ToString(Math.Floor(timeSpan.TotalSeconds)) + "." + timeSpan.Milliseconds.ToString("D3")).Append("\r\n");
						switch (eventExportNotification.EventType)
						{
						case ExportedEventType.WeaponFired:
						{
							string item = eventExportNotification.EventParameters["WeaponID"].Item2;
							string item2 = eventExportNotification.EventParameters["FiringUnitID"].Item2;
							if (!dictionary.ContainsKey(item2))
							{
								this.method_3(item2, null, ref stringBuilder, eventExportNotification.ParentScen, this.string_1, eventExportNotification);
								stringBuilder.Append("\r\n");
							}
							this.method_3(item, item2, ref stringBuilder, eventExportNotification.ParentScen, this.string_1, eventExportNotification);
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
								num = this.method_3(item3, null, ref stringBuilder, eventExportNotification.ParentScen, this.string_1, eventExportNotification);
							}
							if (num == 0)
							{
								continue;
							}
							stringBuilder.Append("-").Append(num);
							dictionary[item3] = 0;
							break;
						}
						case ExportedEventType.UnitDestroyed:
						{
							string item5 = eventExportNotification.EventParameters["UnitID"].Item2;
							if (!dictionary.ContainsKey(item5))
							{
								continue;
							}
							int num2 = dictionary[item5];
							if (num2 == 0)
							{
								continue;
							}
							stringBuilder.Append("-").Append(num2);
							dictionary[item5] = 0;
							break;
						}
						case ExportedEventType.UnitPositions:
						{
							string item6 = eventExportNotification.EventParameters["UnitID"].Item2;
							ActiveUnit activeUnit = null;
							UnguidedWeapon unguidedWeapon = null;
							if (eventExportNotification.ParentScen.GetActiveUnits().ContainsKey(item6))
							{
								activeUnit = eventExportNotification.ParentScen.GetActiveUnits()[item6];
								if (Information.IsNothing(activeUnit))
								{
									continue;
								}
								if (activeUnit.IsNotActive())
								{
									continue;
								}
							}
							else if (eventExportNotification.ParentScen.GetUnguidedWeapons().ContainsKey(item6))
							{
								unguidedWeapon = eventExportNotification.ParentScen.GetUnguidedWeapons()[item6];
								if (Information.IsNothing(unguidedWeapon))
								{
									continue;
								}
							}
							int num3;
							if (dictionary.ContainsKey(item6))
							{
								num3 = dictionary[item6];
								if (Information.IsNothing(activeUnit))
								{
									goto IL_3F4;
								}
								if (activeUnit.GetCurrentSpeed() != 0f)
								{
									goto IL_3F4;
								}
								bool arg_3FC_0 = false;
								IL_3FC:
								if (!arg_3FC_0)
								{
									continue;
								}
								stringBuilder.Append(num3).Append(",");
								if (!Information.IsNothing(activeUnit))
								{
									this.method_1(activeUnit, ref stringBuilder, eventExportNotification);
									break;
								}
								if (!Information.IsNothing(unguidedWeapon))
								{
									this.method_1(unguidedWeapon, ref stringBuilder, eventExportNotification);
									break;
								}
								break;
								IL_3F4:
								arg_3FC_0 = (num3 != 0);
								goto IL_3FC;
							}
							num3 = this.method_3(item6, null, ref stringBuilder, eventExportNotification.ParentScen, this.string_1, eventExportNotification);
							break;
						}
						case ExportedEventType.WeaponImpact:
						{
							string item7 = eventExportNotification.EventParameters["UnitID"].Item2;
							if (!dictionary.ContainsKey(item7))
							{
								this.method_3(item7, null, ref stringBuilder, eventExportNotification.ParentScen, this.string_1, eventExportNotification);
							}
							break;
						}
						case ExportedEventType.Explosion:
						{
							EventExport_Tacview2x.Class252 @class = new EventExport_Tacview2x.Class252(null);
							@class.string_0 = eventExportNotification.EventParameters["ExplosionID"].Item2;
							int value;
							if (dictionary.ContainsKey(@class.string_0))
							{
								value = dictionary[@class.string_0];
							}
							else
							{
								value = this.method_3(@class.string_0, null, ref stringBuilder, eventExportNotification.ParentScen, this.string_1, eventExportNotification);
							}
							Explosion unit_ = eventExportNotification.ParentScen.GetExplosions().Where(new Func<Explosion, bool>(@class.method_0)).ElementAtOrDefault(0);
							stringBuilder.Append(value).Append(",");
							this.method_1(unit_, ref stringBuilder, eventExportNotification);
							stringBuilder.Append(",Type=Misc+Explosion");
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
				this.bool_10 = false;
			}
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x00315424 File Offset: 0x00313624
		private void method_5(string string_2, Dictionary<string, Tuple<Type, string>> dictionary_1, Scenario scenario_0)
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("FileType=text/acmi/tacview").Append("\r\n");
				stringBuilder.Append("FileVersion=2.1").Append("\r\n");
				stringBuilder.Append("0,ReferenceTime=" + scenario_0.GetCurrentTime(false).ToString("yyyy-MM-ddThh:mm:ss")).Append("Z").Append("\r\n");
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

		// Token: 0x060063A2 RID: 25506 RVA: 0x003154D8 File Offset: 0x003136D8
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
			this.bool_10 = false;
		}

		// Token: 0x04003607 RID: 13831
		[CompilerGenerated]
		private _RunMode enum100_0;

		// Token: 0x04003608 RID: 13832
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04003609 RID: 13833
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x0400360A RID: 13834
		[CompilerGenerated]
		private bool bool_2 = false;

		// Token: 0x0400360B RID: 13835
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x0400360C RID: 13836
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x0400360D RID: 13837
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x0400360E RID: 13838
		[CompilerGenerated]
		private bool bool_6;

		// Token: 0x0400360F RID: 13839
		[CompilerGenerated]
		private bool bool_7;

		// Token: 0x04003610 RID: 13840
		[CompilerGenerated]
		private bool bool_8;

		// Token: 0x04003611 RID: 13841
		[CompilerGenerated]
		private bool bool_9;

		// Token: 0x04003612 RID: 13842
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003613 RID: 13843
		private string string_1;

		// Token: 0x04003614 RID: 13844
		private bool bool_10;

		// Token: 0x04003615 RID: 13845
		private ConcurrentQueue<EventExportNotification> concurrentQueue_0;

		// Token: 0x04003616 RID: 13846
		private ConcurrentDictionary<string, Dictionary<string, int>> concurrentDictionary_0;

		// Token: 0x04003617 RID: 13847
		private Dictionary<string, StreamWriter> dictionary_0;

		// Token: 0x04003618 RID: 13848
		private Thread thread_0;

		// Token: 0x02000BBD RID: 3005
		[CompilerGenerated]
		public sealed class Class251
		{
			// Token: 0x060063A3 RID: 25507 RVA: 0x0002B96D File Offset: 0x00029B6D
			internal bool method_0(WeaponImpact weaponImpact_0)
			{
				return Operators.CompareString(weaponImpact_0.GetGuid(), this.string_0, false) == 0;
			}

			// Token: 0x060063A4 RID: 25508 RVA: 0x0002B96D File Offset: 0x00029B6D
			internal bool method_1(WeaponImpact weaponImpact_0)
			{
				return Operators.CompareString(weaponImpact_0.GetGuid(), this.string_0, false) == 0;
			}

			// Token: 0x04003619 RID: 13849
			public string string_0;
		}

		// Token: 0x02000BBE RID: 3006
		[CompilerGenerated]
		public sealed class Class252
		{
			// Token: 0x060063A6 RID: 25510 RVA: 0x0002B984 File Offset: 0x00029B84
			public Class252(EventExport_Tacview2x.Class252 class252_0)
			{
				if (class252_0 != null)
				{
					this.string_0 = class252_0.string_0;
				}
			}

			// Token: 0x060063A7 RID: 25511 RVA: 0x0002B99E File Offset: 0x00029B9E
			internal bool method_0(Explosion explosion_0)
			{
				return Operators.CompareString(explosion_0.GetGuid(), this.string_0, false) == 0;
			}

			// Token: 0x0400361A RID: 13850
			public string string_0;
		}
	}
}

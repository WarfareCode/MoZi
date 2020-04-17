using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns4;

namespace Command_Core.Lua
{
	// Token: 0x02000C1F RID: 3103
	[Attribute1, Attribute2, Attribute3]
	public class LuaWrapper_ActiveUnit
	{
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600674F RID: 26447 RVA: 0x00360A7C File Offset: 0x0035EC7C
		[Attribute2]
		public string subtype
		{
			get
			{
				string result;
				if (this.au.GetUnitType() > GlobalVariables.ActiveUnitType.None)
				{
					result = this.au.GetUnitTypeID().ToString();
				}
				else
				{
					result = "None";
				}
				return result;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06006750 RID: 26448 RVA: 0x00360AC4 File Offset: 0x0035ECC4
		[Attribute2]
		public string type
		{
			get
			{
				string result;
				if (this.au.GetUnitType() > GlobalVariables.ActiveUnitType.None)
				{
					result = this.au.GetUnitType().ToString();
				}
				else if (this.au.IsGroup)
				{
					result = "Group";
				}
				else
				{
					result = "None";
				}
				return result;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06006751 RID: 26449 RVA: 0x00360B24 File Offset: 0x0035ED24
		[Attribute2]
		public int dbid
		{
			get
			{
				return this.au.DBID;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06006752 RID: 26450 RVA: 0x00360B40 File Offset: 0x0035ED40
		// (set) Token: 0x06006753 RID: 26451 RVA: 0x0002CAB4 File Offset: 0x0002ACB4
		[Attribute2]
		public string name
		{
			get
			{
				return this.au.Name;
			}
			set
			{
				this.au.Name = value;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06006754 RID: 26452 RVA: 0x00360B5C File Offset: 0x0035ED5C
		// (set) Token: 0x06006755 RID: 26453 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		[Attribute2]
		public  double latitude
		{
			get
			{
				return this.au.GetLatitude(null);
			}
			set
			{
				throw new Exception2("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06006756 RID: 26454 RVA: 0x00360B80 File Offset: 0x0035ED80
		// (set) Token: 0x06006757 RID: 26455 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		[Attribute2]
		public  double longitude
		{
			get
			{
				return this.au.GetLongitude(null);
			}
			set
			{
				throw new Exception2("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06006758 RID: 26456 RVA: 0x0002CACE File Offset: 0x0002ACCE
		// (set) Token: 0x06006759 RID: 26457 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		[Attribute2]
		public virtual bool autodetectable
		{
			get
			{
				return this.au.IsAutoDetectable(null);
			}
			set
			{
				throw new Exception2("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600675A RID: 26458 RVA: 0x00360BA4 File Offset: 0x0035EDA4
		[Attribute2]
		public string guid
		{
			get
			{
				return this.au.GetGuid();
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600675B RID: 26459 RVA: 0x00360BC0 File Offset: 0x0035EDC0
		[Attribute2]
		public string side
		{
			get
			{
				return this.au.GetSide(false).GetSideName();
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600675C RID: 26460 RVA: 0x00360BE0 File Offset: 0x0035EDE0
		// (set) Token: 0x0600675D RID: 26461 RVA: 0x0002CADC File Offset: 0x0002ACDC
		[Attribute2]
		public object mission
		{
			get
			{
				object result;
				if (this.au.GetAssignedMission(false) == null)
				{
					result = null;
				}
				else
				{
					Mission assignedMission = this.au.GetAssignedMission(false);
					result = new LuaWrapper_Mission(assignedMission, this.ScenarioContext);
				}
				return result;
			}
			set
			{
				if (!(value is string))
				{
					throw new Exception2("Please provide the mission's name.");
				}
				PrivateMethods.smethod_8(this.au.GetGuid(), Conversions.ToString(value), this.ScenarioContext, null, false, false);
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600675E RID: 26462 RVA: 0x0002CB14 File Offset: 0x0002AD14
		// (set) Token: 0x0600675F RID: 26463 RVA: 0x0002CB26 File Offset: 0x0002AD26
		[Attribute2]
		public bool holdposition
		{
			get
			{
				return this.au.GetAI().HoldPosition;
			}
			set
			{
				this.au.GetAI().HoldPosition = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06006760 RID: 26464 RVA: 0x0002CB39 File Offset: 0x0002AD39
		// (set) Token: 0x06006761 RID: 26465 RVA: 0x0002CB45 File Offset: 0x0002AD45
		[Attribute2]
		public object holdfire
		{
			get
			{
				throw new Exception2("This is a Dctrine property for a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit)");
			}
			set
			{
				throw new Exception2("This is a Dctrine property for a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06006762 RID: 26466 RVA: 0x00360C24 File Offset: 0x0035EE24
		// (set) Token: 0x06006763 RID: 26467 RVA: 0x00360CA0 File Offset: 0x0035EEA0
		[Attribute2]
		public virtual object group
		{
			get
			{
				object result;
				if (this.au.GetParentGroup(false) != null | this.au.IsGroup)
				{
					if (this.au.GetParentGroup(false) != null)
					{
						result = new LuaWrapper_Group(this.au.GetParentGroup(false), this.ScenarioContext);
					}
					else
					{
						result = new LuaWrapper_Group((Group)this.au, this.ScenarioContext);
					}
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				try
				{
					this.au.SetParentGroup(false, LuaUtility.smethod_23(RuntimeHelpers.GetObjectValue(value), this.au.GetSide(false), this.ScenarioContext));
				}
				catch (Exception2 projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06006764 RID: 26468 RVA: 0x00360CF8 File Offset: 0x0035EEF8
		// (set) Token: 0x06006765 RID: 26469 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		[Attribute2]
		public virtual object altitude
		{
			get
			{
				return this.au.GetCurrentAltitude_ASL(true);
			}
			set
			{
				throw new Exception2("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06006766 RID: 26470 RVA: 0x00360D18 File Offset: 0x0035EF18
		[Attribute2]
		public object airbornetime
		{
			get
			{
				object result;
				if (this.au.GetType() == typeof(Aircraft))
				{
					result = Misc.GetTimeString((long)Math.Round((double)((Aircraft)this.au).AbnTime), Aircraft_AirOps._Maintenance.const_0, false, true);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06006767 RID: 26471 RVA: 0x00360D70 File Offset: 0x0035EF70
		[Attribute2]
		public object loadoutdbid
		{
			get
			{
				object result;
				if (this.au.GetType() == typeof(Aircraft))
				{
					result = ((Aircraft)this.au).GetLoadout().DBID;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06006768 RID: 26472 RVA: 0x00360DC0 File Offset: 0x0035EFC0
		// (set) Token: 0x06006769 RID: 26473 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		[Attribute2]
		public virtual object speed
		{
			get
			{
				return this.au.GetCurrentSpeed();
			}
			set
			{
				throw new Exception2("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600676A RID: 26474 RVA: 0x00360DE0 File Offset: 0x0035EFE0
		// (set) Token: 0x0600676B RID: 26475 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		[Attribute2]
		public virtual object throttle
		{
			get
			{
				return this.au.GetThrottle();
			}
			set
			{
				throw new Exception2("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600676C RID: 26476 RVA: 0x00360E00 File Offset: 0x0035F000
		[Attribute2]
		public LuaTable damage
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				ActiveUnit_Damage damage = this.au.GetDamage();
				LuaUtility.smethod_3(new Dictionary<string, object>
				{
					{
						"DP",
						this.au.GetDamagePts(false)
					},
					{
						"FLOOD",
						damage.GetFloodingIntensityLevel().ToString()
					},
					{
						"FIRES",
						damage.GetFireIntensityLevel().ToString()
					},
					{
						"STARTDP",
						this.au.GetInitialDP().ToString()
					}
				}, luaTable);
				return luaTable;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x0600676D RID: 26477 RVA: 0x00360EA8 File Offset: 0x0035F0A8
		[Attribute2]
		public LuaTable ascontact
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				Side[] sides = this.au.m_Scenario.GetSides();
				checked
				{
					for (int i = 0; i < sides.Length; i++)
					{
						Side side = sides[i];
						if (!Information.IsNothing(side) && side.GetSideName() != this.side)
						{
							foreach (Contact current in side.GetContactList())
							{
								if (Operators.CompareString(current.ActualUnit.GetGuid(), this.au.GetGuid(), false) == 0)
								{
									LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
									luaTable2["side"] = side.GetGuid();
									luaTable2["guid"] = current.GetGuid();
									luaTable2["name"] = current.Name;
									luaTable[unchecked(luaTable.Keys.Count + 1)] = luaTable2;
								}
							}
						}
					}
					return luaTable;
				}
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x0600676E RID: 26478 RVA: 0x00360FE0 File Offset: 0x0035F1E0
		// (set) Token: 0x0600676F RID: 26479 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		[Attribute2]
		public virtual object heading
		{
			get
			{
				return this.au.GetCurrentHeading();
			}
			set
			{
				throw new Exception2("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06006770 RID: 26480 RVA: 0x00361000 File Offset: 0x0035F200
		[Attribute2]
		public LuaTable weather
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				Weather.WeatherProfile weatherProfile = this.au.GetWeatherProfile();
				luaTable["temp"] = weatherProfile.GetTemperature(Weather._TimeOfDay.Day);
				luaTable["rainfall"] = weatherProfile.RainFallRate;
				luaTable["undercloud"] = weatherProfile.GetFUR();
				luaTable["seastate"] = weatherProfile.SeaState;
				return luaTable;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06006771 RID: 26481 RVA: 0x00361080 File Offset: 0x0035F280
		// (set) Token: 0x06006772 RID: 26482 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		[Attribute2]
		public virtual string proficiency
		{
			get
			{
				string result = null;
				GlobalVariables.ProficiencyLevel? proficiencyLevel = this.au.GetProficiencyLevel();
				int? num = proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					result = "Novice";
				}
				else
				{
					num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
					if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						result = "ʵϰ";
					}
					else
					{
						num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
						if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							result = "Regular";
						}
						else
						{
							num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
							if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
							{
								result = "Veteran";
							}
							else
							{
								num = (proficiencyLevel.HasValue ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
								{
									result = "Ace";
								}
							}
						}
					}
				}
				return result;
			}
			set
			{
				throw new Exception2("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06006773 RID: 26483 RVA: 0x00361270 File Offset: 0x0035F470
		// (set) Token: 0x06006774 RID: 26484 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		[Attribute2]
		public virtual LuaTable course
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				Waypoint[] plottedCourse = this.au.GetNavigator().GetPlottedCourse();
				for (int i = 0; i < plottedCourse.Length; i = checked(i + 1))
				{
					Waypoint waypoint = plottedCourse[i];
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					luaTable2["latitude"] = waypoint.GetLatitude();
					luaTable2["longitude"] = waypoint.GetLongitude();
					luaTable[num] = luaTable2;
					num++;
				}
				return luaTable;
			}
			set
			{
				throw new Exception2("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06006775 RID: 26485 RVA: 0x00361304 File Offset: 0x0035F504
		// (set) Token: 0x06006776 RID: 26486 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		[Attribute2]
		public virtual LuaTable fuel
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				FuelRec[] fuelRecs = this.au.GetFuelRecs();
				checked
				{
					for (int i = 0; i < fuelRecs.Length; i++)
					{
						FuelRec fuelRec = fuelRecs[i];
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["current"] = fuelRec.CurrentQuantity;
						luaTable2["max"] = fuelRec.MaxQuantity;
						luaTable2["name"] = fuelRec.FuelType.ToString();
						luaTable[Convert.ToInt32((short)fuelRec.FuelType)] = luaTable2;
					}
					return luaTable;
				}
			}
			set
			{
				throw new Exception2("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06006777 RID: 26487 RVA: 0x003613B0 File Offset: 0x0035F5B0
		// (set) Token: 0x06006778 RID: 26488 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		[Attribute2]
		public virtual LuaTable magazines
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				Magazine[] magazinesForAllMounts = this.au.GetMagazinesForAllMounts();
				for (int i = 0; i < magazinesForAllMounts.Length; i = checked(i + 1))
				{
					Magazine magazine = magazinesForAllMounts[i];
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
					if (magazine.DBID != 0)
					{
						luaTable2["mag_capacity"] = magazine.MagazineCapacity;
						luaTable2["mag_dbid"] = magazine.DBID;
						luaTable2["mag_guid"] = magazine.GetGuid();
						luaTable2["mag_name"] = magazine.Name;
						foreach (WeaponRec current in magazine.GetWeaponRecCollection())
						{
							LuaTable luaTable4 = LuaSandBox.Singleton().CreateTable();
							luaTable4["wpn_guid"] = current.GetGuid();
							luaTable4["wpn_current"] = current.GetCurrentLoad();
							luaTable4["wpn_maxcap"] = current.MaxLoad;
							luaTable4["wpn_default"] = current.DefaultLoad;
							luaTable4["wpn_dbid"] = current.WeapID;
							luaTable4["wpn_name"] = current.GetWeapon(this.ScenarioContext).Name;
							luaTable3[luaTable3.Keys.Count + 1] = luaTable4;
						}
						luaTable2["mag_weapons"] = luaTable3;
						luaTable[luaTable.Keys.Count + 1] = luaTable2;
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception2("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06006779 RID: 26489 RVA: 0x00361598 File Offset: 0x0035F798
		// (set) Token: 0x0600677A RID: 26490 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		[Attribute2]
		public virtual LuaTable mounts
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				Mount[] mounts = this.au.m_Mounts;
				for (int i = 0; i < mounts.Length; i = checked(i + 1))
				{
					Mount mount = mounts[i];
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
					if (mount.DBID != 0)
					{
						luaTable2["mount_dbid"] = mount.DBID;
						luaTable2["mount_guid"] = mount.GetGuid();
						luaTable2["mount_name"] = mount.Name;
						foreach (WeaponRec current in mount.GetWeaponRecCollection())
						{
							LuaTable luaTable4 = LuaSandBox.Singleton().CreateTable();
							luaTable4["wpn_guid"] = current.GetGuid();
							luaTable4["wpn_current"] = current.GetCurrentLoad();
							luaTable4["wpn_maxcap"] = current.MaxLoad;
							luaTable4["wpn_default"] = current.DefaultLoad;
							luaTable4["wpn_dbid"] = current.WeapID;
							luaTable4["wpn_name"] = current.GetWeapon(this.ScenarioContext).Name;
							luaTable3[luaTable3.Keys.Count + 1] = luaTable4;
						}
						luaTable2["mount_weapons"] = luaTable3;
						luaTable[luaTable.Keys.Count + 1] = luaTable2;
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception2("Cannot set this property on a normal active unit. Please use an ActiveUnit_SE entity instead (via ScenEdit_GetUnit/SetUnit).");
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600677B RID: 26491 RVA: 0x00361768 File Offset: 0x0035F968
		// (set) Token: 0x0600677C RID: 26492 RVA: 0x0002CB51 File Offset: 0x0002AD51
		[Attribute2]
		public virtual LuaTable components
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (this.au.GetAllPlatformComponents().Count > 0)
				{
					foreach (PlatformComponent current in this.au.GetAllPlatformComponents())
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["comp_guid"] = current.GetGuid();
						luaTable2["comp_dbid"] = current.DBID;
						luaTable2["comp_name"] = current.Name;
						luaTable2["comp_type"] = current.GetType().Name;
						luaTable2["comp_status"] = current.GetComponentStatus().ToString();
						if (current.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
						{
							luaTable2["comp_damage"] = current.GetDamageSeverity().ToString();
						}
						luaTable[luaTable.Keys.Count + 1] = luaTable2;
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception2("Cannot set this property on a normal active unit. Not implemented.");
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600677D RID: 26493 RVA: 0x0036189C File Offset: 0x0035FA9C
		[Attribute2]
		public string condition
		{
			get
			{
				string type = this.type;
				string text;
				string result;
				if (Operators.CompareString(type, "Ship", false) != 0 && Operators.CompareString(type, "Submarine", false) != 0)
				{
					if (Operators.CompareString(type, "Aircraft", false) == 0 && this.au.GetAirOps() != null)
					{
						text = ((Aircraft_AirOps)this.au.GetAirOps()).GetAirOpsConditionString();
						result = text;
						return result;
					}
				}
				else if (this.au.GetDockingOps() != null)
				{
					text = this.au.GetDockingOps().GetDockingOpsConditionName();
					result = text;
					return result;
				}
				text = null;
				result = text;
				return result;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600677E RID: 26494 RVA: 0x00361940 File Offset: 0x0035FB40
		[Attribute2]
		public string unitstate
		{
			get
			{
				return this.au.GetUnitStatus().ToString();
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600677F RID: 26495 RVA: 0x00361964 File Offset: 0x0035FB64
		[Attribute2]
		public string fuelstate
		{
			get
			{
				return this.au.GetFuelState().ToString();
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06006780 RID: 26496 RVA: 0x00361988 File Offset: 0x0035FB88
		[Attribute2]
		public string weaponstate
		{
			get
			{
				return this.au.GetWeaponState().ToString();
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06006781 RID: 26497 RVA: 0x003619AC File Offset: 0x0035FBAC
		[Attribute2]
		public object manualSpeed
		{
			get
			{
				return this.au.GetKinematics().GetDesiredSpeedOverride();
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06006782 RID: 26498 RVA: 0x003619D0 File Offset: 0x0035FBD0
		[Attribute2]
		public object manualAltitude
		{
			get
			{
				return this.au.GetKinematics().GetDesiredAltitudeOverride();
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06006783 RID: 26499 RVA: 0x003619F4 File Offset: 0x0035FBF4
		[Attribute2]
		public LuaWrapper_ActiveUnit @base
		{
			get
			{
				LuaWrapper_ActiveUnit result = null;
				string type = this.type;
				if (Operators.CompareString(type, "Ship", false) != 0 && Operators.CompareString(type, "Submarine", false) != 0)
				{
					if (Operators.CompareString(type, "Aircraft", false) == 0 && this.au.GetAirOps() != null)
					{
						Aircraft_AirOps aircraft_AirOps = (Aircraft_AirOps)this.au.GetAirOps();
						if (aircraft_AirOps.GetCurrentHostUnit() != null)
						{
							result = new LuaWrapper_ActiveUnit(aircraft_AirOps.GetCurrentHostUnit(), this.ScenarioContext);
						}
						else if (aircraft_AirOps.GetAssignedHostUnit() != null)
						{
							result = new LuaWrapper_ActiveUnit(aircraft_AirOps.GetAssignedHostUnit(), this.ScenarioContext);
						}
					}
				}
				else if (this.au.GetDockingOps() != null)
				{
					ActiveUnit_DockingOps dockingOps = this.au.GetDockingOps();
					if (dockingOps.GetCurrentHostUnit() != null)
					{
						result = new LuaWrapper_ActiveUnit(dockingOps.GetCurrentHostUnit(), this.ScenarioContext);
					}
					else if (dockingOps.GetAssignedHostUnit() != null)
					{
						result = new LuaWrapper_ActiveUnit(dockingOps.GetAssignedHostUnit(), this.ScenarioContext);
					}
				}
				return result;
			}
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x0002CB5D File Offset: 0x0002AD5D
		public LuaWrapper_ActiveUnit(ActiveUnit a, Scenario s)
		{
			this.au = a;
			this.ScenarioContext = s;
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x00361AFC File Offset: 0x0035FCFC
		[Attribute2]
		public LuaTable filterOnComponent(string type)
		{
			LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
			if (this.au.GetAllPlatformComponents().Count > 0)
			{
				foreach (PlatformComponent current in this.au.GetAllPlatformComponents())
				{
					if (Operators.CompareString(current.GetType().Name.ToUpper(), type.ToUpper(), false) == 0 | Operators.CompareString(type, "", false) == 0)
					{
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["comp_guid"] = current.GetGuid();
						luaTable2["comp_dbid"] = current.DBID;
						luaTable2["comp_name"] = current.Name;
						luaTable2["comp_type"] = current.GetType().Name;
						luaTable2["comp_status"] = current.GetComponentStatus().ToString();
						if (current.GetComponentStatus() != PlatformComponent._ComponentStatus.Operational)
						{
							luaTable2["comp_damage"] = current.GetDamageSeverity().ToString();
						}
						luaTable[luaTable.Keys.Count + 1] = luaTable2;
					}
				}
			}
			return luaTable;
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x00361C74 File Offset: 0x0035FE74
		[Attribute2]
		public float rangetotarget(string contactId)
		{
			Contact contact = PrivateMethods.smethod_47(contactId, this.ScenarioContext);
			float result = 0f;
			if (contact != null)
			{
				this.au.GetApproxAngularDistanceInDegrees(contact);
				float horizontalRange = this.au.GetHorizontalRange(contact);
				if (horizontalRange == 3.40282347E+38f)
				{
					result = 0f;
				}
				else
				{
					result = horizontalRange;
				}
			}
			return result;
		}

		// Token: 0x06006787 RID: 26503 RVA: 0x00361CD0 File Offset: 0x0035FED0
		[Attribute2]
		public override string ToString()
		{
			string text = string.Concat(new string[]
			{
				"unit {\r\n type = '",
				this.type,
				"', \r\n subtype = '",
				this.subtype,
				"', \r\n name = '",
				this.name,
				"', \r\n side = '",
				this.side,
				"', \r\n guid = '",
				this.guid.ToString(),
				"', \r\n proficiency = '",
				this.proficiency,
				"', \r\n latitude = '",
				this.latitude.ToString(),
				"', \r\n longitude = '",
				this.longitude.ToString(),
				"', \r\n altitude = '",
				this.altitude.ToString(),
				"', \r\n speed = '",
				this.speed.ToString(),
				"', \r\n throttle = '",
				((ActiveUnit.Throttle)Conversions.ToByte(this.throttle)).ToString(),
				"', \r\n autodetectable = '",
				this.autodetectable.ToString(),
				"', \r\n"
			});
			if (this.@base != null)
			{
				text = text + " base = '" + this.@base.name + "', \r\n";
			}
			if ((this.group != null | this.au.IsGroup) && this.group != null)
			{
				LuaWrapper_Group luaWrapper_Group = (LuaWrapper_Group)this.group;
				text = text + " group = '" + luaWrapper_Group.name + "', \r\n";
			}
			if (this.mission != null)
			{
				LuaWrapper_Mission luaWrapper_Mission = (LuaWrapper_Mission)this.mission;
				text = text + " mission = '" + luaWrapper_Mission.name + "', \r\n";
			}
			if (Operators.CompareString(this.type, "None", false) != 0)
			{
				try
				{
					if (this.au.m_Mounts != null)
					{
						text = text + " mounts = '" + this.au.m_Mounts.Length.ToString() + "', \r\n";
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (this.au.GetMagazinesForAllMounts() != null)
					{
						text = text + " magazines = '" + this.au.GetMagazinesForAllMounts().Count<Magazine>().ToString() + "', \r\n";
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			text = text + " unitstate = '" + this.au.GetUnitStatus().ToString() + "', \r\n";
			text = text + " fuelstate = '" + this.au.GetFuelState().ToString() + "', \r\n";
			text = text + " weaponstate = '" + this.au.GetWeaponState().ToString() + "', \r\n";
			text += "}";
			return text;
		}

		// Token: 0x040038B3 RID: 14515
		protected ActiveUnit au;

		// Token: 0x040038B4 RID: 14516
		protected Scenario ScenarioContext;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns4;

namespace Command_Core.Lua
{
	// Token: 0x02000C20 RID: 3104
	[Attribute1, Attribute2, Attribute3]
	public sealed class LuaWrapper_ActiveUnit_SE : LuaWrapper_ActiveUnit
	{
		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06006788 RID: 26504 RVA: 0x00361FFC File Offset: 0x003601FC
		[Attribute2]
		public object __au
		{
			get
			{
				return this.au;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06006789 RID: 26505 RVA: 0x00360CF8 File Offset: 0x0035EEF8
		// (set) Token: 0x0600678A RID: 26506 RVA: 0x00362014 File Offset: 0x00360214
		[Attribute2]
		public override object altitude
		{
			get
			{
				return this.au.GetCurrentAltitude_ASL(true);
			}
			set
			{
				ActiveUnit au = this.au;
				au.SetAltitude_ASL(true, LuaUtility.smethod_17(RuntimeHelpers.GetObjectValue(value)).Value);
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600678B RID: 26507 RVA: 0x0002CACE File Offset: 0x0002ACCE
		// (set) Token: 0x0600678C RID: 26508 RVA: 0x0002CB73 File Offset: 0x0002AD73
		[Attribute2]
		public override bool autodetectable
		{
			get
			{
				return this.au.IsAutoDetectable(null);
			}
			set
			{
				this.au.SetIsAutoDetectable(null, value);
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600678D RID: 26509 RVA: 0x00362044 File Offset: 0x00360244
		// (set) Token: 0x0600678E RID: 26510 RVA: 0x003620D8 File Offset: 0x003602D8
		[Attribute2]
		public override LuaTable course
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				Waypoint[] plottedCourse = this.au.GetNavigator().GetPlottedCourse();
				for (int i = 0; i < plottedCourse.Length; i++)
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
				List<object>.Enumerator enumerator = default(List<object>.Enumerator);
				if (value == null)
				{
					this.au.GetNavigator().ClearPlottedCourse();
				}
				else
				{
					this.au.GetNavigator().ClearPlottedCourse();
					List<object> list = LuaUtility.smethod_0(value.GetEnumerator());
					try
					{
						enumerator = list.GetEnumerator();
						while (enumerator.MoveNext())
						{
							object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
							if (!(objectValue is LuaTable))
							{
								throw new Exception2("Error at " + LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(objectValue)));
							}
							Dictionary<string, object> objectGeoLocation = LuaUtility.GetObjectGeoLocation(((LuaTable)objectValue).GetEnumerator());
							double? num = LuaUtility.smethod_12(objectGeoLocation);
							double? num2 = LuaUtility.smethod_10(objectGeoLocation);
							if (!num.HasValue | !num.HasValue)
							{
								throw new Exception2("Course object " + LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(objectValue)) + " needs latitude or longitude.");
							}
							double? num3 = num;
							bool? flag;
							if (num3.HasValue)
							{
								flag = new bool?(num3.GetValueOrDefault() == 0.0);
							}
							else
							{
								flag = null;
							}
							bool? flag2 = flag;
							num3 = num;
							bool? flag3;
							if (num3.HasValue)
							{
								flag3 = new bool?(num3.GetValueOrDefault() == 0.0);
							}
							else
							{
								flag3 = null;
							}
							bool? flag4 = flag3;
							bool? flag5;
							if (flag2.HasValue && flag2.GetValueOrDefault())
							{
								flag5 = new bool?(true);
							}
							else if (flag4.HasValue)
							{
								flag5 = (flag2 | flag4.GetValueOrDefault());
							}
							else
							{
								flag5 = null;
							}
							flag4 = flag5;
							if (flag4.GetValueOrDefault())
							{
								throw new Exception2("Course object " + LuaUtility.smethod_29(RuntimeHelpers.GetObjectValue(objectValue)) + " Latitude or Longitude cannot be 0.");
							}
							this.au.GetNavigator().AddWaypoint(num2.Value, num.Value, Waypoint.WaypointType.ManualPlottedCourseWaypoint, Waypoint._Creator.const_1, Waypoint._Category.const_0);
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
				}
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600678F RID: 26511 RVA: 0x00362318 File Offset: 0x00360518
		// (set) Token: 0x06006790 RID: 26512 RVA: 0x003623C4 File Offset: 0x003605C4
		[Attribute2]
		public override LuaTable fuel
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				FuelRec[] fuelRecs = this.au.GetFuelRecs();
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
			set
			{
				IEnumerator enumerator = null;
				try
				{
					try
					{
						enumerator = value.Keys.GetEnumerator();
						while (enumerator.MoveNext())
						{
							LuaTable luaTable = (LuaTable)value[LuaWrapper_ActiveUnit_SE.Local_key];
							FuelRec fuelRec = this.au.GetFuelRecs().FirstOrDefault((FuelRec F) => (double)Convert.ToInt32((short)F.FuelType) == LuaWrapper_ActiveUnit_SE.Local_key);
							float val = Conversions.ToSingle(luaTable["current"]);
							val = Math.Min((float)fuelRec.MaxQuantity, val);
							fuelRec.CurrentQuantity = Math.Max(0f, val);
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
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw new Exception2("Error setting fuel.");
				}
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06006791 RID: 26513 RVA: 0x003624AC File Offset: 0x003606AC
		// (set) Token: 0x06006792 RID: 26514 RVA: 0x00362520 File Offset: 0x00360720
		[Attribute2]
		public override object group
		{
			get
			{
				object result;
				if (!(this.au.GetParentGroup(false) != null | this.au.IsGroup))
				{
					result = null;
				}
				else
				{
					result = ((this.au.GetParentGroup(false) == null) ? new LuaWrapper_Group((Group)this.au, this.ScenarioContext) : new LuaWrapper_Group(this.au.GetParentGroup(false), this.ScenarioContext));
				}
				return result;
			}
			set
			{
				try
				{
					if (this.au.GetUnitType() == GlobalVariables.ActiveUnitType.None)
					{
						throw new Exception2("Can't change group on a group.");
					}
					if (Operators.CompareString(Conversions.ToString(value).ToLower(), "none", false) != 0)
					{
						Group group = LuaUtility.smethod_23(RuntimeHelpers.GetObjectValue(value), this.au.GetSide(false), this.ScenarioContext);
						if (group != null)
						{
							this.au.SetParentGroup(false, group);
						}
						else
						{
							List<ActiveUnit> selectedUnits = new List<ActiveUnit>
							{
								this.au
							};
							ActiveUnit au = this.au;
							ActiveUnit activeUnit = au;
							Side side = au.GetSide(false);
							Group group2 = new Group(ref this.ScenarioContext, ref side, selectedUnits, false, null, null);
							activeUnit.SetSide(false, side);
							Group group3 = group2;
							group3.Name = Conversions.ToString(value);
							this.au.SetParentGroup(false, group3);
						}
					}
					else
					{
						this.au.SetParentGroup(false, null);
					}
				}
				catch (Exception2 projectError)
				{
					ProjectData.SetProjectError(projectError);
					throw;
				}
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06006793 RID: 26515 RVA: 0x00360FE0 File Offset: 0x0035F1E0
		// (set) Token: 0x06006794 RID: 26516 RVA: 0x0036262C File Offset: 0x0036082C
		[Attribute2]
		public override object heading
		{
			get
			{
				return this.au.GetCurrentHeading();
			}
			set
			{
				float currentHeading = 0f;
				try
				{
					if (float.TryParse(Conversions.ToString(value), out currentHeading))
					{
						this.au.SetCurrentHeading(currentHeading);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06006795 RID: 26517 RVA: 0x00360B5C File Offset: 0x0035ED5C
		// (set) Token: 0x06006796 RID: 26518 RVA: 0x00362680 File Offset: 0x00360880
		[Attribute2]
		public  double latitude
		{
			get
			{
				return this.au.GetLatitude(null);
			}
			set
			{
				double? num = LuaUtility.smethod_11(value);
				if (!num.HasValue)
				{
					throw new Exception2("Can't pass nil in as latitude.");
				}
				bool? hintIsOperating = null;
				this.au.SetGeoLocation(ref this.au.m_Scenario, this.au.GetLongitude(hintIsOperating), num.Value);
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06006797 RID: 26519 RVA: 0x00360B80 File Offset: 0x0035ED80
		// (set) Token: 0x06006798 RID: 26520 RVA: 0x003626E0 File Offset: 0x003608E0
		[Attribute2]
		public  double longitude
		{
			get
			{
				return this.au.GetLongitude(null);
			}
			set
			{
				double? num = LuaUtility.smethod_13(value);
				if (!num.HasValue)
				{
					throw new Exception2("Can't pass nil in as longitude.");
				}
				bool? hintIsOperating = null;
				this.au.SetGeoLocation(ref this.au.m_Scenario, num.Value, this.au.GetLatitude(hintIsOperating));
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06006799 RID: 26521 RVA: 0x00360DC0 File Offset: 0x0035EFC0
		// (set) Token: 0x0600679A RID: 26522 RVA: 0x0002CB82 File Offset: 0x0002AD82
		[Attribute2]
		public override object speed
		{
			get
			{
				return this.au.GetCurrentSpeed();
			}
			set
			{
				this.au.SetCurrentSpeed(Conversions.ToSingle(value));
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600679B RID: 26523 RVA: 0x00360DE0 File Offset: 0x0035EFE0
		// (set) Token: 0x0600679C RID: 26524 RVA: 0x00362740 File Offset: 0x00360940
		[Attribute2]
		public override object throttle
		{
			get
			{
				return this.au.GetThrottle();
			}
			set
			{
				float? specificDesiredSpeed = null;
				this.au.SetThrottle(LuaUtility.smethod_22(Conversions.ToString(value)), specificDesiredSpeed);
			}
		}

		// Token: 0x0600679D RID: 26525 RVA: 0x0002CB95 File Offset: 0x0002AD95
		public LuaWrapper_ActiveUnit_SE(ActiveUnit a, Scenario s) : base(a, s)
		{
		}

		// Token: 0x0600679E RID: 26526 RVA: 0x0002CB9F File Offset: 0x0002AD9F
		[Attribute2]
		public void delete()
		{
			GameGeneral.RemoveUnit(ref this.ScenarioContext, this.au.GetGuid());
		}

		// Token: 0x0600679F RID: 26527 RVA: 0x0036276C File Offset: 0x0036096C
		[Attribute2]
		public override string ToString()
		{
			string[] array = new string[25];
			array[0] = "unit {\r\n type = '";
			array[1] = base.type;
			array[2] = "', \r\n subtype = '";
			array[3] = base.subtype;
			array[4] = "', \r\n name = '";
			array[5] = base.name;
			array[6] = "', \r\n side = '";
			array[7] = base.side;
			array[8] = "', \r\n guid = '";
			array[9] = base.guid.ToString();
			array[10] = "', \r\n proficiency = '";
			array[11] = this.proficiency;
			array[12] = "', \r\n latitude = '";
			array[13] = this.latitude.ToString();
			array[14] = "', \r\n longitude = '";
			array[15] = this.longitude.ToString();
			array[16] = "', \r\n altitude = '";
			array[17] = this.altitude.ToString();
			array[18] = "', \r\n speed = '";
			array[19] = this.speed.ToString();
			array[20] = "', \r\n throttle = '";
			ActiveUnit.Throttle throttle = (ActiveUnit.Throttle)Conversions.ToByte(this.throttle);
			array[21] = throttle.ToString();
			array[22] = "', \r\n autodetectable = '";
			array[23] = this.autodetectable.ToString();
			array[24] = "', \r\n";
			string text = string.Concat(array);
			if (base.@base != null)
			{
				text = text + " base = '" + base.@base.name + "', \r\n";
			}
			if (this.group != null & !this.au.IsGroup)
			{
				LuaWrapper_Group luaWrapper_Group = (LuaWrapper_Group)this.group;
				text = text + " group = '" + luaWrapper_Group.name + "', \r\n";
			}
			if (base.mission != null)
			{
				LuaWrapper_Mission luaWrapper_Mission = (LuaWrapper_Mission)base.mission;
				text = text + " mission = '" + luaWrapper_Mission.name + "', \r\n";
			}
			if (Operators.CompareString(base.type, "None", false) != 0)
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
			ActiveUnit._ActiveUnitStatus unitStatus = this.au.GetUnitStatus();
			text = text + " unitstate = '" + unitStatus.ToString() + "', \r\n";
			ActiveUnit._ActiveUnitFuelState fuelState = this.au.GetFuelState();
			text = text + " fuelstate = '" + fuelState.ToString() + "', \r\n";
			ActiveUnit._ActiveUnitWeaponState weaponState = this.au.GetWeaponState();
			text = text + " weaponstate = '" + weaponState.ToString() + "', \r\n";
			text += "}";
			return text;
		}

		// Token: 0x040038B5 RID: 14517
		public static double Local_key;
	}
}

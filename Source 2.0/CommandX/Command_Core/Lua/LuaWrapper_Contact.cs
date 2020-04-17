using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns4;

namespace Command_Core.Lua
{
	// 目标的分布式对象
	[Attribute1, Attribute2, Attribute3]
	public sealed class LuaWrapper_Contact
	{
		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600667C RID: 26236 RVA: 0x00353D40 File Offset: 0x00351F40
		[Attribute2]
		public object __contact
		{
			get
			{
				return this.myContact;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600667D RID: 26237 RVA: 0x00353D58 File Offset: 0x00351F58
		[Attribute2]
		public int actualunitdbid
		{
			get
			{
				return (this.myContact.GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass || Information.IsNothing(this.myContact.ActualUnit)) ? 0 : this.myContact.ActualUnit.DBID;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600667E RID: 26238 RVA: 0x00353DA0 File Offset: 0x00351FA0
		[Attribute2]
		public string actualunitid
		{
			get
			{
				return (!Information.IsNothing(this.myContact.ActualUnit)) ? this.myContact.ActualUnit.GetGuid() : "";
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600667F RID: 26239 RVA: 0x00353DDC File Offset: 0x00351FDC
		[Attribute2]
		public float age
		{
			get
			{
				return this.myContact.TSD;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06006680 RID: 26240 RVA: 0x00353DF8 File Offset: 0x00351FF8
		[Attribute2]
		public LuaTable areaofuncertainty
		{
			get
			{
				List<GeoPoint>.Enumerator enumerator = default(List<GeoPoint>.Enumerator);
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				if (!Information.IsNothing(this.myContact.GetUncertaintyArea()))
				{
					try
					{
						enumerator = this.myContact.GetUncertaintyArea().GetEnumerator();
						while (enumerator.MoveNext())
						{
							GeoPoint current = enumerator.Current;
							LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
							luaTable2["longitude"] = current.GetLongitude();
							luaTable2["latitude"] = current.GetLatitude();
							luaTable[num] = luaTable2;
							num++;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				return luaTable;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06006681 RID: 26241 RVA: 0x00353EC0 File Offset: 0x003520C0
		[Attribute2]
		public int classificationlevel
		{
			get
			{
				return (int)this.myContact.GetIdentificationStatus();
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06006682 RID: 26242 RVA: 0x00353EDC File Offset: 0x003520DC
		// (set) Token: 0x06006683 RID: 26243 RVA: 0x00353EFC File Offset: 0x003520FC
		[Attribute2]
		public object FilterOut
		{
			get
			{
				return this.myContact.IsFilterOut;
			}
			set
			{
				bool? booleanValue = LuaUtility.GetBooleanValue(RuntimeHelpers.GetObjectValue(value));
				if (booleanValue.HasValue)
				{
					this.myContact.IsFilterOut = booleanValue.Value;
				}
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06006684 RID: 26244 RVA: 0x00353F34 File Offset: 0x00352134
		[Attribute2]
		public object fromside
		{
			get
			{
				return this.fromSidePerspective;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06006685 RID: 26245 RVA: 0x00353F4C File Offset: 0x0035214C
		[Attribute2]
		public string guid
		{
			get
			{
				return this.myContact.GetGuid();
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06006686 RID: 26246 RVA: 0x00353F68 File Offset: 0x00352168
		[Attribute2]
		public double latitude
		{
			get
			{
				return this.myContact.GetLatitude(null);
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06006687 RID: 26247 RVA: 0x00353F8C File Offset: 0x0035218C
		[Attribute2]
		public double longitude
		{
			get
			{
				return this.myContact.GetLongitude(null);
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06006688 RID: 26248 RVA: 0x00353FB0 File Offset: 0x003521B0
		[Attribute2]
		public int missile_defence
		{
			get
			{
				int result;
				if (this.myContact.GetIdentificationStatus() < Contact_Base.IdentificationStatus.KnownClass || Information.IsNothing(this.myContact.ActualUnit))
				{
					result = 0;
				}
				else
				{
					Contact_Base.ContactType contactType = this.myContact.contactType;
					if (contactType == Contact_Base.ContactType.Surface)
					{
						result = (int)((Ship)this.myContact.ActualUnit).MissileDefense;
					}
					else
					{
						result = ((contactType - Contact_Base.ContactType.Facility_Fixed <= 1) ? ((Facility)this.myContact.ActualUnit).MissileDefense : -1);
					}
				}
				return result;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06006689 RID: 26249 RVA: 0x00354038 File Offset: 0x00352238
		// (set) Token: 0x0600668A RID: 26250 RVA: 0x0002C4A4 File Offset: 0x0002A6A4
		[Attribute2]
		public string name
		{
			get
			{
				return this.myContact.Name;
			}
			set
			{
				this.myContact.Name = value;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600668B RID: 26251 RVA: 0x00354054 File Offset: 0x00352254
		[Attribute2]
		public string objectid
		{
			get
			{
				return this.guid;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600668C RID: 26252 RVA: 0x0035406C File Offset: 0x0035226C
		// (set) Token: 0x0600668D RID: 26253 RVA: 0x003540DC File Offset: 0x003522DC
		[Attribute2]
		public string posture
		{
			get
			{
				string result;
				switch (this.myContact.GetPostureStance(this.myContact.OriginalDetectorSide))
				{
				case Misc.PostureStance.Neutral:
					result = "N";
					break;
				case Misc.PostureStance.Friendly:
					result = "F";
					break;
				case Misc.PostureStance.Unfriendly:
					result = "U";
					break;
				case Misc.PostureStance.Hostile:
					result = "H";
					break;
				case Misc.PostureStance.Unknown:
					result = "X";
					break;
				default:
					result = "X";
					break;
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "F", false) == 0)
				{
					this.myContact.MarkAs(this.myContact.OriginalDetectorSide, false, Misc.PostureStance.Friendly);
				}
				else if (Operators.CompareString(value, "H", false) == 0)
				{
					this.myContact.MarkAs(this.myContact.OriginalDetectorSide, false, Misc.PostureStance.Hostile);
				}
				else if (Operators.CompareString(value, "N", false) == 0)
				{
					this.myContact.MarkAs(this.myContact.OriginalDetectorSide, false, Misc.PostureStance.Neutral);
				}
				else if (Operators.CompareString(value, "U", false) == 0)
				{
					this.myContact.MarkAs(this.myContact.OriginalDetectorSide, false, Misc.PostureStance.Unknown);
				}
				else
				{
					if (Operators.CompareString(value, "X", false) != 0)
					{
						throw new Exception2("Invalid posture code: " + value);
					}
					this.myContact.MarkAs(this.myContact.OriginalDetectorSide, false, Misc.PostureStance.Unknown);
				}
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600668E RID: 26254 RVA: 0x003541E4 File Offset: 0x003523E4
		[Attribute2]
		public LuaTable potentialmatches
		{
			get
			{
				List<int>.Enumerator enumerator = default(List<int>.Enumerator);
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				DataRow[] array = null;
				try
				{
					enumerator = this.myContact.method_62().GetEnumerator();
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["DBID"] = current;
						switch (this.myContact.contactType)
						{
						case Contact_Base.ContactType.Air:
							array = this.ScenarioContext.Cache_Aircraft_DT.Select("ID=" + Conversions.ToString(current));
							if (array != null && array.Count<DataRow>() > 0)
							{
								Aircraft aircraft = new Aircraft(ref this.ScenarioContext, null);
								DBFunctions.smethod_19(ref this.ScenarioContext, ref aircraft, current, false);
								luaTable2["TYPE"] = aircraft.Type;
								luaTable2["SUBTYPE"] = aircraft.GetUnitTypeID();
								luaTable2["CATEGORY"] = aircraft.Category;
							}
							break;
						case Contact_Base.ContactType.Missile:
						case Contact_Base.ContactType.Torpedo:
							array = this.ScenarioContext.Cache_Weapons_DT.Select("ID=" + Conversions.ToString(current));
							if (array != null && array.Count<DataRow>() > 0)
							{
								Weapon weapon = Weapon.GetWeapon(ref this.ScenarioContext, 0, null);
								DBFunctions.LoadWeaponData(this.ScenarioContext.GetSQLiteConnection(), weapon, current, this.ScenarioContext, true);
								luaTable2["TYPE"] = weapon.GetWeaponType();
								luaTable2["SUBTYPE"] = weapon.GetUnitTypeID();
							}
							break;
						case Contact_Base.ContactType.Surface:
							array = this.ScenarioContext.Cache_Ships_DT.Select("ID=" + Conversions.ToString(current));
							if (array != null && array.Count<DataRow>() > 0)
							{
								Ship ship = new Ship(ref this.ScenarioContext, null);
								DBFunctions.smethod_51(ref this.ScenarioContext, ref ship, current, false);
								luaTable2["TYPE"] = ship.Type;
								luaTable2["SUBTYPE"] = ship.GetUnitTypeID();
								luaTable2["CATEGORY"] = ship.Category;
								luaTable2["MISSILE_DEFENCE"] = ship.MissileDefense;
							}
							break;
						case Contact_Base.ContactType.Submarine:
							array = this.ScenarioContext.Cache_Subs_DT.Select("ID=" + Conversions.ToString(current));
							if (array != null && array.Count<DataRow>() > 0)
							{
								Submarine submarine = new Submarine(ref this.ScenarioContext, null);
								DBFunctions.LoadSubmarineData(ref this.ScenarioContext, ref submarine, current, false);
								luaTable2["TYPE"] = submarine.Type;
								luaTable2["SUBTYPE"] = submarine.GetUnitTypeID();
								luaTable2["CATEGORY"] = submarine.Category;
							}
							break;
						case Contact_Base.ContactType.Orbital:
							array = this.ScenarioContext.Cache_Satellites_DT.Select("ID=" + Conversions.ToString(current));
							if (array != null && array.Count<DataRow>() > 0)
							{
								Satellite satellite = new Satellite(ref this.ScenarioContext);
								DBFunctions.LoadSatelliteData(ref this.ScenarioContext, ref satellite, current, 0, true);
								luaTable2["TYPE"] = satellite.SatelliteType;
								luaTable2["SUBTYPE"] = satellite.GetUnitTypeID();
								luaTable2["CATEGORY"] = satellite.SatelliteCategory;
							}
							break;
						case Contact_Base.ContactType.Facility_Fixed:
						case Contact_Base.ContactType.Facility_Mobile:
							array = this.ScenarioContext.Cache_Facilities_DT.Select("ID=" + Conversions.ToString(current));
							if (array != null && array.Count<DataRow>() > 0)
							{
								Facility facility = new Facility(ref this.ScenarioContext, null);
								DBFunctions.LoadFacilityData(ref this.ScenarioContext, ref facility, current, false);
								luaTable2["SUBTYPE"] = facility.GetUnitTypeID();
								luaTable2["CATEGORY"] = facility.Category;
								luaTable2["MISSILE_DEFENCE"] = facility.MissileDefense;
							}
							break;
						}
						if (array != null && array.Count<DataRow>() > 0)
						{
							luaTable2["NAME"] = Misc.smethod_11(array[0]["Name"].ToString());
						}
						luaTable[luaTable.Keys.Count + 1] = luaTable2;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600668F RID: 26255 RVA: 0x003546D0 File Offset: 0x003528D0
		[Attribute2]
		public object side
		{
			get
			{
				object result;
				if (!this.myContact.SideIsKnown)
				{
					result = null;
				}
				else
				{
					result = this.myContact.GetSide(false);
				}
				return result;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06006690 RID: 26256 RVA: 0x00354700 File Offset: 0x00352900
		[Attribute2]
		public string type
		{
			get
			{
				return this.myContact.GetContactType();
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06006691 RID: 26257 RVA: 0x0035471C File Offset: 0x0035291C
		[Attribute2]
		public string type_description
		{
			get
			{
				string result;
				if (Information.IsNothing(this.myContact.ActualUnit))
				{
					result = "";
				}
				else
				{
					switch (this.myContact.GetIdentificationStatus())
					{
					case Contact_Base.IdentificationStatus.Unknown:
					case Contact_Base.IdentificationStatus.KnownDomain:
						result = "Type: Unknown";
						break;
					case Contact_Base.IdentificationStatus.KnownType:
						result = "Type: " + this.myContact.ActualUnit.GetUnitTypeDescription();
						break;
					case Contact_Base.IdentificationStatus.KnownClass:
						result = "Class: " + this.myContact.ActualUnit.UnitClass;
						break;
					case Contact_Base.IdentificationStatus.PreciseID:
						result = "Identified: " + this.myContact.ActualUnit.Name;
						break;
					default:
						result = "";
						break;
					}
				}
				return result;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06006692 RID: 26258 RVA: 0x003547D8 File Offset: 0x003529D8
		[Attribute2]
		public int typed
		{
			get
			{
				return (int)this.myContact.contactType;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06006693 RID: 26259 RVA: 0x003547F4 File Offset: 0x003529F4
		[Attribute2]
		public LuaTable weather
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				LuaTable result;
				if (!(Information.IsNothing(this.longitude) & Information.IsNothing(this.longitude)))
				{
					float num = 0f;
					if (this.myContact.Altitude_Known)
					{
						num = this.myContact.GetCurrentAltitude_ASL(false);
					}
					Weather.WeatherProfile weatherProfile = Weather.GetWeatherProfile(this.ScenarioContext, this.latitude, this.longitude, (int)Math.Round((double)num));
					luaTable["temp"] = weatherProfile.GetTemperature(Weather._TimeOfDay.Day);
					luaTable["rainfall"] = weatherProfile.RainFallRate;
					luaTable["undercloud"] = weatherProfile.GetFUR();
					luaTable["seastate"] = weatherProfile.SeaState;
					result = luaTable;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x0002C4B2 File Offset: 0x0002A6B2
		public LuaWrapper_Contact(Contact theContact, Scenario theScen, Side fromSide)
		{
			this.myContact = theContact;
			this.ScenarioContext = theScen;
			this.fromSidePerspective = fromSide;
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x003548DC File Offset: 0x00352ADC
		[Attribute2]
		public object DropContact()
		{
			this.fromSidePerspective.Lazy3DictionaryTryAdd(this.myContact, ref this.ScenarioContext, true);
			return "ok";
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x00354908 File Offset: 0x00352B08
		[Attribute2]
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"contact {\r\n guid = '",
				this.guid,
				"', \r\n name = '",
				this.name,
				"', \r\n type = '",
				this.type.ToString(),
				"', \r\n"
			}) + "}";
		}

		// 目标
		private Contact myContact;  // 

		// Token: 0x04003850 RID: 14416
		private Scenario ScenarioContext;

		// Token: 0x04003851 RID: 14417
		private Side fromSidePerspective;
	}
}

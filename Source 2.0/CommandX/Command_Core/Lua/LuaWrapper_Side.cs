using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns4;

namespace Command_Core.Lua
{
	// Token: 0x02000C0C RID: 3084
	[Attribute1, Attribute2, Attribute3]
	public sealed class LuaWrapper_Side
	{
		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060066AA RID: 26282 RVA: 0x0035671C File Offset: 0x0035491C
		[Attribute2]
		public Side.AwarenessLevel awareness
		{
			get
			{
				return this.mySide.GetAwarenessLevel();
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060066AB RID: 26283 RVA: 0x00356738 File Offset: 0x00354938
		[Attribute2]
		public LuaTable contacts
		{
			get
			{
				List<Contact>.Enumerator enumerator = default(List<Contact>.Enumerator);
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				try
				{
					enumerator = this.mySide.GetContactList().GetEnumerator();
					while (enumerator.MoveNext())
					{
						Contact current = enumerator.Current;
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["guid"] = current.GetGuid();
						luaTable2["name"] = current.Name;
						luaTable[num] = luaTable2;
						num++;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060066AC RID: 26284 RVA: 0x003567E4 File Offset: 0x003549E4
		[Attribute2]
		public LuaTable exclusionzones
		{
			get
			{
				List<ExclusionZone>.Enumerator enumerator = default(List<ExclusionZone>.Enumerator);
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				try
				{
					enumerator = this.mySide.ExclusionZoneList.GetEnumerator();
					while (enumerator.MoveNext())
					{
						ExclusionZone current = enumerator.Current;
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["guid"] = current.GetGuid();
						luaTable2["name"] = current.Name;
						luaTable2["description"] = current.Description;
						luaTable[num] = luaTable2;
						num++;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060066AD RID: 26285 RVA: 0x003568A4 File Offset: 0x00354AA4
		[Attribute2]
		public string guid
		{
			get
			{
				return this.mySide.GetGuid();
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060066AE RID: 26286 RVA: 0x003568C0 File Offset: 0x00354AC0
		// (set) Token: 0x060066AF RID: 26287 RVA: 0x0002C501 File Offset: 0x0002A701
		[Attribute2]
		public string name
		{
			get
			{
				return this.mySide.GetSideName();
			}
			set
			{
				this.mySide.SetSideName(value);
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060066B0 RID: 26288 RVA: 0x003568DC File Offset: 0x00354ADC
		[Attribute2]
		public LuaTable nonavzones
		{
			get
			{
				List<NoNavZone>.Enumerator enumerator = default(List<NoNavZone>.Enumerator);
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				try
				{
					enumerator = this.mySide.NoNavZoneList.GetEnumerator();
					while (enumerator.MoveNext())
					{
						NoNavZone current = enumerator.Current;
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["guid"] = current.GetGuid();
						luaTable2["name"] = current.Name;
						luaTable2["description"] = current.Description;
						luaTable[num] = luaTable2;
						num++;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060066B1 RID: 26289 RVA: 0x0035699C File Offset: 0x00354B9C
		[Attribute2]
		public string ObjectID
		{
			get
			{
				return this.guid;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060066B2 RID: 26290 RVA: 0x003569B4 File Offset: 0x00354BB4
		[Attribute2]
		public GlobalVariables.ProficiencyLevel proficiency
		{
			get
			{
				return this.mySide.GetProficiencyLevel();
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060066B3 RID: 26291 RVA: 0x003569D0 File Offset: 0x00354BD0
		[Attribute2]
		public LuaTable units
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				ActiveUnit[] activeUnitArray = this.mySide.ActiveUnitArray;
				for (int i = 0; i < activeUnitArray.Length; i++)
				{
					ActiveUnit activeUnit = activeUnitArray[i];
					LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
					luaTable2["guid"] = activeUnit.GetGuid();
					luaTable2["name"] = activeUnit.Name;
					luaTable[num] = luaTable2;
					num++;
				}
				return luaTable;
			}
		}

		// Token: 0x060066B4 RID: 26292 RVA: 0x0002C50F File Offset: 0x0002A70F
		public LuaWrapper_Side(Side theSide, Scenario theScen)
		{
			this.mySide = theSide;
			this.ScenarioContext = theScen;
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x00356A54 File Offset: 0x00354C54
		[Attribute2]
		public LuaWrapper_Zone getexclusionzone(string ZoneIDorNameOrDescription)
		{
			List<ExclusionZone>.Enumerator enumerator = default(List<ExclusionZone>.Enumerator);
			Zone zone = null;
			LuaWrapper_Zone result;
			try
			{
				enumerator = this.mySide.ExclusionZoneList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ExclusionZone current = enumerator.Current;
					if (Operators.CompareString(current.GetGuid(), ZoneIDorNameOrDescription, false) == 0 || Operators.CompareString(current.Name, ZoneIDorNameOrDescription, false) == 0 || Operators.CompareString(current.Description, ZoneIDorNameOrDescription, false) == 0)
					{
						zone = current;
						if (Information.IsNothing(zone))
						{
							throw new Exception2("No exclusion zone exists with this name or ID.");
						}
						result = new LuaWrapper_Zone(zone, this.ScenarioContext);
						return result;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			if (Information.IsNothing(zone))
			{
				throw new Exception2("No exclusion zone exists with this name or ID.");
			}
			result = new LuaWrapper_Zone(zone, this.ScenarioContext);
			return result;
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x00356B2C File Offset: 0x00354D2C
		[Attribute2]
		public LuaWrapper_Zone getnonavzone(string ZoneIDorNameOrDescription)
		{
			List<NoNavZone>.Enumerator enumerator = default(List<NoNavZone>.Enumerator);
			Zone zone = null;
			LuaWrapper_Zone result;
			try
			{
				enumerator = this.mySide.NoNavZoneList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					NoNavZone current = enumerator.Current;
					if (Operators.CompareString(current.GetGuid(), ZoneIDorNameOrDescription, false) == 0 || Operators.CompareString(current.Name, ZoneIDorNameOrDescription, false) == 0 || Operators.CompareString(current.Description, ZoneIDorNameOrDescription, false) == 0)
					{
						zone = current;
						if (Information.IsNothing(zone))
						{
							throw new Exception2("No no-navigation zone exists with this name or ID.");
						}
						result = new LuaWrapper_Zone(zone, this.ScenarioContext);
						return result;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			if (Information.IsNothing(zone))
			{
				throw new Exception2("No no-navigation zone exists with this name or ID.");
			}
			result = new LuaWrapper_Zone(zone, this.ScenarioContext);
			return result;
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x00356C04 File Offset: 0x00354E04
		[Attribute2]
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"side {\r\n guid = '",
				this.guid,
				"', \r\n name = '",
				this.name,
				"', \r\n units = '",
				this.units.ToString(),
				"', \r\n contacts = '",
				this.contacts.ToString(),
				"', \r\n"
			}) + "}";
		}

		// Token: 0x04003854 RID: 14420
		private Side mySide;

		// Token: 0x04003855 RID: 14421
		private Scenario ScenarioContext;
	}
}

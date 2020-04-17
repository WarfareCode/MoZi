using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns4;

namespace Command_Core.Lua
{
	// Token: 0x02000C0B RID: 3083
	[Attribute1, Attribute2, Attribute3]
	public sealed class LuaWrapper_Zone
	{
		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060066A0 RID: 26272 RVA: 0x00356584 File Offset: 0x00354784
		[Attribute2]
		public LuaTable area
		{
			get
			{
				List<ReferencePoint>.Enumerator enumerator = default(List<ReferencePoint>.Enumerator);
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				int num = 1;
				try
				{
					enumerator = this.myZone.Area.GetEnumerator();
					while (enumerator.MoveNext())
					{
						ReferencePoint current = enumerator.Current;
						LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
						luaTable2["guid"] = current.GetGuid();
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
				return luaTable;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060066A1 RID: 26273 RVA: 0x0035664C File Offset: 0x0035484C
		// (set) Token: 0x060066A2 RID: 26274 RVA: 0x0002C4CF File Offset: 0x0002A6CF
		[Attribute2]
		public string description
		{
			get
			{
				return this.myZone.Description;
			}
			set
			{
				this.myZone.Description = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060066A3 RID: 26275 RVA: 0x00356668 File Offset: 0x00354868
		[Attribute2]
		public string guid
		{
			get
			{
				return this.myZone.GetGuid();
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060066A4 RID: 26276 RVA: 0x00356684 File Offset: 0x00354884
		// (set) Token: 0x060066A5 RID: 26277 RVA: 0x003566A4 File Offset: 0x003548A4
		[Attribute2]
		public object isactive
		{
			get
			{
				return this.myZone.IsActive;
			}
			set
			{
				try
				{
					this.myZone.IsActive = Conversions.ToBoolean(value);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					throw new Exception2(ex.Message);
				}
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060066A6 RID: 26278 RVA: 0x003566E8 File Offset: 0x003548E8
		// (set) Token: 0x060066A7 RID: 26279 RVA: 0x0002C4DD File Offset: 0x0002A6DD
		[Attribute2]
		public string name
		{
			get
			{
				return this.myZone.Name;
			}
			set
			{
				this.myZone.Name = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060066A8 RID: 26280 RVA: 0x00356704 File Offset: 0x00354904
		[Attribute2]
		public string objectid
		{
			get
			{
				return this.guid;
			}
		}

		// Token: 0x060066A9 RID: 26281 RVA: 0x0002C4EB File Offset: 0x0002A6EB
		public LuaWrapper_Zone(Zone theZone, Scenario theScen)
		{
			this.myZone = theZone;
			this.ScenarioContext = theScen;
		}

		// Token: 0x04003852 RID: 14418
		private Zone myZone;

		// Token: 0x04003853 RID: 14419
		private Scenario ScenarioContext;
	}
}

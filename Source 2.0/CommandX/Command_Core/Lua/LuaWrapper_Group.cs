using System;
using System.Collections.Generic;
using NLua;
using ns4;

namespace Command_Core.Lua
{
	// Token: 0x02000C5C RID: 3164
	[Attribute1, Attribute2, Attribute3]
	public sealed class LuaWrapper_Group
	{
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06006918 RID: 26904 RVA: 0x003867E0 File Offset: 0x003849E0
		[Attribute2]
		public object __group
		{
			get
			{
				return this.au;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06006919 RID: 26905 RVA: 0x003867F8 File Offset: 0x003849F8
		[Attribute2]
		public string guid
		{
			get
			{
				return this.au.GetGuid();
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x0600691A RID: 26906 RVA: 0x00386814 File Offset: 0x00384A14
		// (set) Token: 0x0600691B RID: 26907 RVA: 0x0002D57A File Offset: 0x0002B77A
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

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x0600691C RID: 26908 RVA: 0x00386830 File Offset: 0x00384A30
		[Attribute2]
		public string side
		{
			get
			{
				return this.au.GetSide(false).GetSideName();
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600691D RID: 26909 RVA: 0x00386850 File Offset: 0x00384A50
		[Attribute2]
		public string type
		{
			get
			{
				return this.au.GetGroupType().ToString();
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600691E RID: 26910 RVA: 0x00386874 File Offset: 0x00384A74
		[Attribute2]
		public LuaTable unitlist
		{
			get
			{
				List<Unit>.Enumerator enumerator = default(List<Unit>.Enumerator);
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				List<Unit> list = new List<Unit>();
				list = this.au.GetUnitListInGroup();
				int num = 1;
				try
				{
					enumerator = list.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Unit current = enumerator.Current;
						luaTable[num] = current.GetGuid();
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

		// Token: 0x0600691F RID: 26911 RVA: 0x0002D588 File Offset: 0x0002B788
		public LuaWrapper_Group(Group a, Scenario s)
		{
			this.au = a;
			this.ScenarioContext = s;
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x00386900 File Offset: 0x00384B00
		[Attribute2]
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"group {\r\n guid = '",
				this.guid,
				"', \r\n name = '",
				this.name,
				"', \r\n side = '",
				this.side,
				"', \r\n type = '",
				this.type.ToString(),
				"', \r\n unitlist = '",
				this.unitlist.ToString(),
				"',\r\n"
			}) + "}";
		}

		// Token: 0x04003B25 RID: 15141
		protected Group au;

		// Token: 0x04003B26 RID: 15142
		protected Scenario ScenarioContext;
	}
}

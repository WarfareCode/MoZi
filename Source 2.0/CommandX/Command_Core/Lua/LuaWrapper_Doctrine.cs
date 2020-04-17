using System;
using NLua;
using ns4;

namespace Command_Core.Lua
{
	// Token: 0x02000C5B RID: 3163
	[Attribute1, Attribute2, Attribute3]
	public sealed class LuaWrapper_Doctrine
	{
		// Token: 0x06006916 RID: 26902 RVA: 0x0002D564 File Offset: 0x0002B764
		public LuaWrapper_Doctrine(Doctrine a, Scenario s)
		{
			this.doc = a;
			this.ScenarioContext = s;
		}

		// Token: 0x06006917 RID: 26903 RVA: 0x003867C4 File Offset: 0x003849C4
		[Attribute2]
		public LuaTable filterWRA(string type)
		{
			return LuaSandBox.Singleton().CreateTable();
		}

		// Token: 0x04003B23 RID: 15139
		protected Doctrine doc;

		// Token: 0x04003B24 RID: 15140
		protected Scenario ScenarioContext;
	}
}

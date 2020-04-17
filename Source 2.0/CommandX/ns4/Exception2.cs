using System;
using System.Text;
using Command_Core;
using Command_Core.Lua;
using KeraLua;

namespace ns4
{
	// Token: 0x02000C33 RID: 3123
	public sealed class Exception2 : Exception
	{
		// Token: 0x06006862 RID: 26722 RVA: 0x00370178 File Offset: 0x0036E378
		public Exception2(string string_2)
		{
			this.luaDebug_0 = default(LuaDebug);
			this.string_0 = string_2;
			this.string_1 = LuaSandBox.Singleton().currentFunction;
			LuaSandBox.Singleton().lastError = this.string_1 + "/" + string_2;
			LuaSandBox.Singleton().SB_Getinfo("nSl", ref this.luaDebug_0);
			this.int_0 = this.luaDebug_0.currentline;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Function:" + this.string_1).Append(" (" + this.int_0.ToString() + ") ").Append(" Error:" + this.string_0);
			string text = "... ";
			object obj = stringBuilder.ToString();
			LuaUtility.smethod_30(ref text, ref obj, false);
			LuaSandBox.Singleton().SB_Lua()["_errmsg_"] = string_2;
			LuaSandBox.Singleton().SB_Lua()["_errfnc_"] = this.string_1;
			LuaSandBox.Singleton().SB_Lua()["_errnum_"] = 1;
		}

		// Token: 0x040038D8 RID: 14552
		public string string_0;

		// Token: 0x040038D9 RID: 14553
		public string string_1;

		// Token: 0x040038DA RID: 14554
		public int int_0;

		// Token: 0x040038DB RID: 14555
		private LuaDebug luaDebug_0;
	}
}

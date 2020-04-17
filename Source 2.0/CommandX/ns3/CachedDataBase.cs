using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.Caching;
using System.Runtime.CompilerServices;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3
{
	// Token: 0x02000BB3 RID: 2995
	public sealed class CachedDataBase
	{
		// Token: 0x0600632D RID: 25389 RVA: 0x0030FB2C File Offset: 0x0030DD2C
		public static DataTable GetDataTable(SQLiteDataBase db, string string_0)
		{
			string key = db.sqliteConnection_0.ConnectionString + "_" + string_0;
			DataTable dataTable = (DataTable)CachedDataBase.memoryCache.Get(key, null);
			if (Information.IsNothing(dataTable))
			{
				dataTable = db.GetDataTable(string_0);
				CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
				cacheItemPolicy.SlidingExpiration = new TimeSpan(0, 0, 15);
				CachedDataBase.memoryCache.Add(key, dataTable, cacheItemPolicy, null);
			}
			return dataTable;
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x0030FB9C File Offset: 0x0030DD9C
		public static string ExecuteScalar(SQLiteDataBase db, string string_0)
		{
			string result = "";
			try
			{
				string key = db.sqliteConnection_0.ConnectionString + "_" + string_0;
				string text = Conversions.ToString(CachedDataBase.memoryCache.Get(key, null));
				if (string.IsNullOrEmpty(text))
				{
					text = db.ExecuteScalar(string_0);
					CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
					cacheItemPolicy.SlidingExpiration = new TimeSpan(0, 0, 15);
					CachedDataBase.memoryCache.Add(key, text, cacheItemPolicy, null);
				}
				result = text;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ex2.Data.Add("Error at 200083", ex2.Message);
				GameGeneral.LogException(ref ex2);
				string text = db.ExecuteScalar(string_0);
				result = text;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600632F RID: 25391 RVA: 0x0030FC74 File Offset: 0x0030DE74
		public static object smethod_2(SQLiteDataBase db, string string_0)
		{
			string key = db.sqliteConnection_0.ConnectionString + "_" + string_0;
			return RuntimeHelpers.GetObjectValue(CachedDataBase.memoryCache.Get(key, null));
		}

		// Token: 0x06006330 RID: 25392 RVA: 0x0030FCAC File Offset: 0x0030DEAC
		public static void smethod_3(SQLiteDataBase db, string string_0, object object_0)
		{
			CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
			cacheItemPolicy.SlidingExpiration = new TimeSpan(0, 0, 15);
			CachedDataBase.memoryCache.Add(db.sqliteConnection_0.ConnectionString + "_" + string_0, RuntimeHelpers.GetObjectValue(object_0), cacheItemPolicy, null);
		}

		// Token: 0x06006331 RID: 25393 RVA: 0x0030FCF8 File Offset: 0x0030DEF8
		public static string smethod_4(SQLiteDataBase db, string string_0)
		{
			string key = db.sqliteConnection_0.ConnectionString + "_" + string_0;
			return Conversions.ToString(CachedDataBase.memoryCache.Get(key, null));
		}

		// Token: 0x06006332 RID: 25394 RVA: 0x0030FD30 File Offset: 0x0030DF30
		public static void smethod_5(SQLiteDataBase db, string string_0, string string_1)
		{
			CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
			cacheItemPolicy.SlidingExpiration = new TimeSpan(0, 0, 15);
			CachedDataBase.memoryCache.Add(db.sqliteConnection_0.ConnectionString + "_" + string_0, string_1, cacheItemPolicy, null);
		}

		// Token: 0x040035DF RID: 13791
		private static MemoryCache memoryCache = MemoryCache.Default;
	}
}

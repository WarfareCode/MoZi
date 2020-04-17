using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 录屏记录器
	public sealed class Recorder
	{
		// Token: 0x060069CB RID: 27083 RVA: 0x0038E394 File Offset: 0x0038C594
		public static ScenarioSnapshots GetScenarioSnapshots(string string_2, string string_3)
		{
			ScenarioSnapshots result;
			try
			{
				string text;
				if (string.IsNullOrEmpty(string_3))
				{
					text = Guid.NewGuid().ToString();
				}
				else
				{
					text = string_3;
				}
				ScenarioSnapshots scenarioSnapshots = new ScenarioSnapshots();
				if (string.IsNullOrEmpty(string_2))
				{
					File.Copy(Recorder.RecordingsDirectoryPath + "Sample.rec", Recorder.RecordingsDirectoryPath + text + ".rec");
					scenarioSnapshots.ScenarioRecordFileName = Recorder.RecordingsDirectoryPath + text + ".rec";
				}
				else
				{
					File.Copy(Recorder.RecordingsDirectoryPath + "Sample.rec", Path.Combine(string_2, text) + ".rec");
					scenarioSnapshots.ScenarioRecordFileName = Path.Combine(string_2, text) + ".rec";
				}
				scenarioSnapshots.ScenarioTime = DateAndTime.Now;
				result = scenarioSnapshots;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101125", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ScenarioSnapshots();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060069CC RID: 27084 RVA: 0x0038E4C0 File Offset: 0x0038C6C0
		public static string smethod_1()
		{
			string arg_0F_0 = MyTemplate.GetApp().Info.DirectoryPath;
			IEnumerable<string> source = Directory.GetFiles(Recorder.RecordingsDirectoryPath).Select(Recorder.stringFunc0).Where(Recorder.stringFunc1).OrderByDescending(Recorder.stringFunc2);
			string result;
			if (source.Count<string>() > 0)
			{
				result = source.ElementAtOrDefault(0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060069CD RID: 27085 RVA: 0x0038E52C File Offset: 0x0038C72C
		public static ScenarioSnapshots LoadScenarioSnapshots(string ScenarioRecordFileName_)
		{
			ScenarioSnapshots result;
			try
			{
				ScenarioSnapshots scenarioSnapshots = new ScenarioSnapshots();
				scenarioSnapshots.ScenarioRecordFileName = ScenarioRecordFileName_;
				string connectionString = "Data Source=" + ScenarioRecordFileName_ + ";Version=3";
				SQLiteConnection sqliteConnection_ = new SQLiteConnection(connectionString);
				SQLiteDataReader sQLiteDataReader = new SQLiteDataBase(sqliteConnection_).ExecuteReader("SELECT ID, ScenarioTime from Snapshots order by ID ASC");
				while (sQLiteDataReader.Read())
				{
					scenarioSnapshots.Snapshots.Add(new Tuple<int, DateTime>(Conversions.ToInteger(sQLiteDataReader["ID"]), DateTime.FromBinary(Conversions.ToLong(sQLiteDataReader["ScenarioTime"]))));
				}
				sQLiteDataReader.Close();
				result = scenarioSnapshots;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101126", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ScenarioSnapshots();
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04003B8F RID: 15247
		public static Func<string, string> stringFunc0 = (string string_0) => string_0;

		// Token: 0x04003B90 RID: 15248
		public static Func<string, bool> stringFunc1 = (string string_0) => Operators.CompareString(string_0, "Sample.rec", false) != 0;

		// Token: 0x04003B91 RID: 15249
		public static Func<string, DateTime> stringFunc2 = (string string_0) => Directory.GetLastWriteTimeUtc(string_0);

		// Token: 0x04003B92 RID: 15250
		public static bool bool_0;

		// Token: 0x04003B93 RID: 15251
		private static string RecordingsDirectoryPath = MyTemplate.GetApp().Info.DirectoryPath + "\\Recordings\\";

		// Token: 0x04003B94 RID: 15252
		public static string TempFileDir = GameGeneral.strTempDir + "\\" + Path.GetRandomFileName();
	}
}

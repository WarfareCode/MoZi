using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns4
{
	// Token: 0x02000C74 RID: 3188
	public sealed class ScenarioSnapshots
	{
		// Token: 0x060069FE RID: 27134 RVA: 0x0002DA22 File Offset: 0x0002BC22
		public ScenarioSnapshots()
		{
			this.TimeIndexedScenarioSnapshotQueue = new Queue<Tuple<DateTime, string>>();
			this.Snapshots = new List<Tuple<int, DateTime>>();
			this.TimeStampList = new List<long>();
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x0038FA88 File Offset: 0x0038DC88
		public void AddScenarioSnapshot(DateTime dateTime_, MemoryStream ScenarioStream_)
		{
			if (!this.TimeStampList.Contains(dateTime_.ToBinary()))
			{
				this.TimeStampList.Add(dateTime_.ToBinary());
				this.TakeScenarioSnapshot(dateTime_, ScenarioStream_);
				ScenarioStream_.Close();
				ScenarioStream_.Dispose();
				ScenarioStream_ = null;
				if (this.TimeIndexedScenarioSnapshotQueue.Count > 0 && !Recorder.bool_0)
				{
					this.method_4();
				}
			}
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x0038FAF0 File Offset: 0x0038DCF0
		private void TakeScenarioSnapshot(DateTime dateTime_, Stream ScenarioStream_)
		{
			string text = Guid.NewGuid().ToString();
			ScenContainer scenContainer = new ScenContainer();
			scenContainer.TryToCompressScenario(ScenarioStream_);
			if (!Directory.Exists(Recorder.TempFileDir))
			{
				Directory.CreateDirectory(Recorder.TempFileDir);
			}
			scenContainer.SaveTempScenarioFile(Recorder.TempFileDir + "\\" + text);
			this.TimeIndexedScenarioSnapshotQueue.Enqueue(new Tuple<DateTime, string>(dateTime_, text));
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x0038FB60 File Offset: 0x0038DD60
		private string GetScenarioObjectString(string string_1)
		{
			return ScenContainer.smethod_2(Recorder.TempFileDir + "\\" + string_1).ToString();
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x0002DA4B File Offset: 0x0002BC4B
		private void DeleteTempFile(string string_)
		{
			File.Delete(Recorder.TempFileDir + "\\" + string_);
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x0038FB8C File Offset: 0x0038DD8C
		public void method_4()
		{
			Recorder.bool_0 = true;
			while (this.TimeIndexedScenarioSnapshotQueue.Count > 0)
			{
				Tuple<DateTime, string> tuple = this.TimeIndexedScenarioSnapshotQueue.Dequeue();
				DateTime item = tuple.Item1;
				string strScenarioObject_ = "";
				try
				{
					strScenarioObject_ = this.GetScenarioObjectString(tuple.Item2);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200100", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
					break;
				}
				this.AddToSnapshots(item, strScenarioObject_);
				this.DeleteTempFile(tuple.Item2);
				tuple = null;
				strScenarioObject_ = null;
			}
			Recorder.bool_0 = false;
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x0038FC4C File Offset: 0x0038DE4C
		private void AddToSnapshots(DateTime ScenarioTime_, string strScenarioObject_)
		{
			string connectionString = "Data Source=" + this.ScenarioRecordFileName + ";Version=3";
			SQLiteConnection sQLiteConnection = new SQLiteConnection(connectionString);
			sQLiteConnection.Open();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(sQLiteConnection);
			sQLiteCommand.CommandText = "INSERT INTO Snapshots (ScenarioTime, ScenarioObject) Values (" + ScenarioTime_.ToBinary().ToString() + ", @theString)";
			sQLiteCommand.Parameters.AddWithValue("@theString", strScenarioObject_);
			sQLiteCommand.ExecuteNonQuery();
			sQLiteConnection.Close();
		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x0038FCC8 File Offset: 0x0038DEC8
		public Scenario LoadScenaroFromSnapshots(int ID, ref double PercentageComplete)
		{
			string connectionString = "Data Source=" + this.ScenarioRecordFileName + ";Version=3";
			SQLiteConnection sqliteConnection_ = new SQLiteConnection(connectionString);
			ScenContainer scenContainer = ScenContainer.GetScenContainer(new SQLiteDataBase(sqliteConnection_).ExecuteScalar("SELECT ScenarioObject from Snapshots where ID = " + Conversions.ToString(ID)));
			string text = "";
			return scenContainer.LoadScenario(ref text, ref PercentageComplete, false);
		}

		// Token: 0x04003BBD RID: 15293
		public string ScenarioRecordFileName;

		// Token: 0x04003BBE RID: 15294
		public DateTime ScenarioTime;

		// Token: 0x04003BBF RID: 15295
		public Queue<Tuple<DateTime, string>> TimeIndexedScenarioSnapshotQueue;

		// Token: 0x04003BC0 RID: 15296
		public List<Tuple<int, DateTime>> Snapshots;

		// Token: 0x04003BC1 RID: 15297
		private List<long> TimeStampList;
	}
}

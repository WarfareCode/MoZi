using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns29;

namespace ns3
{
	// Token: 0x02000C66 RID: 3174
	public sealed class EventExport_CSV : IEventExporter
	{
		// Token: 0x06006939 RID: 26937 RVA: 0x00389944 File Offset: 0x00387B44
		[CompilerGenerated]
		public string GetExportDirectory()
		{
			return this.string_0;
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x0002D5DE File Offset: 0x0002B7DE
		[CompilerGenerated]
		public void SetExportDirectory(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x0038995C File Offset: 0x00387B5C
		[CompilerGenerated]
		public _RunMode GetRunMode()
		{
			return this.enum100_0;
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x0002D5E7 File Offset: 0x0002B7E7
		[CompilerGenerated]
		public void SetRunMode(_RunMode enum100_1)
		{
			this.enum100_0 = enum100_1;
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x0002D5F0 File Offset: 0x0002B7F0
		[CompilerGenerated]
		public bool IsUseZeroHour()
		{
			return this.bUseZeroHour;
		}

		// Token: 0x0600693E RID: 26942 RVA: 0x0002D5F8 File Offset: 0x0002B7F8
		[CompilerGenerated]
		public void SetUseZeroHour(bool bool_14)
		{
			this.bUseZeroHour = bool_14;
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x0002D601 File Offset: 0x0002B801
		[CompilerGenerated]
		public bool IsExportSensorDetectionSuccess()
		{
			return this.bExportSensorDetectionSuccess;
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x0002D609 File Offset: 0x0002B809
		[CompilerGenerated]
		public void SetExportSensorDetectionSuccess(bool bool_14)
		{
			this.bExportSensorDetectionSuccess = bool_14;
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x0002D612 File Offset: 0x0002B812
		[CompilerGenerated]
		public bool IsExportSensorDetectionFailure()
		{
			return this.bExportSensorDetectionFailure;
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x0002D61A File Offset: 0x0002B81A
		[CompilerGenerated]
		public void SetExportSensorDetectionFailure(bool bool_14)
		{
			this.bExportSensorDetectionFailure = bool_14;
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x0002D623 File Offset: 0x0002B823
		[CompilerGenerated]
		public bool IsExportWeaponFired()
		{
			return this.bExportWeaponFired;
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x0002D62B File Offset: 0x0002B82B
		[CompilerGenerated]
		public void SetExportWeaponFired(bool value)
		{
			this.bExportWeaponFired = value;
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x0002D634 File Offset: 0x0002B834
		[CompilerGenerated]
		public bool IsExportWeaponEndgame()
		{
			return this.bExportWeaponEndgame;
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x0002D63C File Offset: 0x0002B83C
		[CompilerGenerated]
		public void SetExportWeaponEndgame(bool value)
		{
			this.bExportWeaponEndgame = value;
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x0002D645 File Offset: 0x0002B845
		[CompilerGenerated]
		public bool IsExportUnitPositions()
		{
			return this.bExportUnitPositions;
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x0002D64D File Offset: 0x0002B84D
		[CompilerGenerated]
		public void SetExportUnitPositions(bool bool_14)
		{
			this.bExportUnitPositions = bool_14;
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x0002D656 File Offset: 0x0002B856
		[CompilerGenerated]
		public bool IsExportEngagementCycle()
		{
			return this.bool_9;
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x0002D65E File Offset: 0x0002B85E
		[CompilerGenerated]
		public void SetExportEngagementCycle(bool bool_14)
		{
			this.bool_9 = bool_14;
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x0002D667 File Offset: 0x0002B867
		[CompilerGenerated]
		public bool imethod_24()
		{
			return this.bool_10;
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x0002D66F File Offset: 0x0002B86F
		[CompilerGenerated]
		public void imethod_25(bool bool_14)
		{
			this.bool_10 = bool_14;
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x0002D678 File Offset: 0x0002B878
		[CompilerGenerated]
		public bool IsExportFuelConsumed()
		{
			return this.bool_11;
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x0002D680 File Offset: 0x0002B880
		[CompilerGenerated]
		public void SetExportFuelConsumed(bool bool_14)
		{
			this.bool_11 = bool_14;
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x0002D689 File Offset: 0x0002B889
		[CompilerGenerated]
		public bool IsExportFuelTransfer()
		{
			return this.bool_12;
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x0002D691 File Offset: 0x0002B891
		[CompilerGenerated]
		public void SetExportFuelTransfer(bool bool_14)
		{
			this.bool_12 = bool_14;
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x0002D69A File Offset: 0x0002B89A
		[CompilerGenerated]
		public bool imethod_30()
		{
			return this.bool_13;
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x00389974 File Offset: 0x00387B74
		public EventExport_CSV(_RunMode enum100_1)
		{
			this.bSplitFilesBySide = true;
			this.EventQueque = new ConcurrentQueue<EventExportNotification>();
			this.bool_1 = false;
			this.bInitialized = false;
			this.EventTypeFileHashSet = new HashSet<string>();
			this.dictionary_0 = new Dictionary<string, StreamWriter>();
			this.SetExportDirectory(Path.Combine(MyTemplate.GetApp().Info.DirectoryPath, "EventExport_CSV"));
			this.SetRunMode(enum100_1);
			Class2372 @class = new Class2372(EventExporters.strIniFile);
			this.SetUseZeroHour(@class.GetConfigList()["CSV Settings"].GetValueString("UseZeroHour"));
			this.bSplitFilesBySide = @class.GetConfigList()["CSV Settings"].GetValueString("SplitFilesBySide");
			this.SetExportSensorDetectionSuccess(@class.GetConfigList()["CSV Settings"].GetValueString("ExportSensorDetectionSuccess"));
			this.SetExportSensorDetectionFailure(@class.GetConfigList()["CSV Settings"].GetValueString("ExportSensorDetectionFailure"));
			this.SetExportWeaponFired(@class.GetConfigList()["CSV Settings"].GetValueString("ExportWeaponFired"));
			this.SetExportWeaponEndgame(@class.GetConfigList()["CSV Settings"].GetValueString("ExportWeaponEndgame"));
			this.SetExportUnitPositions(@class.GetConfigList()["CSV Settings"].GetValueString("ExportUnitPositions"));
			this.SetExportEngagementCycle(@class.GetConfigList()["CSV Settings"].GetValueString("ExportEngagementCycle"));
			this.SetExportFuelConsumed(@class.GetConfigList()["CSV Settings"].GetValueString("ExportFuelConsumed"));
			this.SetExportFuelTransfer(@class.GetConfigList()["CSV Settings"].GetValueString("ExportFuelTransfer"));
			this.StartExport();
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x0002D6A2 File Offset: 0x0002B8A2
		public void StartExport()
		{
			this.thread_0 = new Thread(new ThreadStart(this.DoExport));
			this.thread_0.Priority = ThreadPriority.BelowNormal;
			this.thread_0.Start();
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x00389B3C File Offset: 0x00387D3C
		public int GetEventQueueLength()
		{
			return this.EventQueque.Count;
		}

		// Token: 0x06006955 RID: 26965 RVA: 0x00389B58 File Offset: 0x00387D58
		public string GetExporterName()
		{
			return "CSVFile";
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x00011AB0 File Offset: 0x0000FCB0
		public _ExporterType GetExporterType()
		{
			return _ExporterType.CSVFile;
		}

		// Token: 0x06006957 RID: 26967 RVA: 0x00389B6C File Offset: 0x00387D6C
		public void ExportEvent(ExportedEventType exportedEventType_0, Dictionary<string, Tuple<Type, string>> dictionary_1, Scenario scenario_0)
		{
			if (!this.bInitialized)
			{
				if (!Directory.Exists(this.GetExportDirectory()))
				{
					Directory.CreateDirectory(this.GetExportDirectory());
				}
				this.bInitialized = true;
			}
			EventExportNotification eventExportNotification = new EventExportNotification();
			eventExportNotification.EventType = exportedEventType_0;
			eventExportNotification.EventParameters = dictionary_1;
			eventExportNotification.FileExportFolder = this.GetExportDirectory();
			this.EventQueque.Enqueue(eventExportNotification);
		}

		// Token: 0x06006958 RID: 26968 RVA: 0x0002D6D2 File Offset: 0x0002B8D2
		private void DoExport()
		{
			while (true)
			{
				Thread.Sleep(100);
				if (!this.bool_1)
				{
					this.method_1();
				}
			}
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x00389BD0 File Offset: 0x00387DD0
		private void method_1()
		{
			this.bool_1 = true;
			try
			{
				EventExportNotification eventExportNotification = null;
				string text = "";
				while (this.EventQueque.Count > 0)
				{
					this.EventQueque.TryDequeue(out eventExportNotification);
					if (!Information.IsNothing(eventExportNotification))
					{
						string str = "";
						switch (eventExportNotification.EventType)
						{
						case ExportedEventType.WeaponFired:
							text = Path.Combine(eventExportNotification.FileExportFolder, "WeaponFired.csv");
							str = eventExportNotification.EventParameters["FiringUnitSide"].Item2;
							break;
						case ExportedEventType.WeaponEndgame:
							text = Path.Combine(eventExportNotification.FileExportFolder, "WeaponEndgame.csv");
							str = eventExportNotification.EventParameters["WeaponSide"].Item2;
							break;
						case ExportedEventType.FuelConsumed:
							text = Path.Combine(eventExportNotification.FileExportFolder, "FuelConsumed.csv");
							str = eventExportNotification.EventParameters["UnitSide"].Item2;
							break;
						case ExportedEventType.UnitDestroyed:
							text = Path.Combine(eventExportNotification.FileExportFolder, "UnitDestroyed.csv");
							break;
						case ExportedEventType.SensorDetectionAttempt:
							text = Path.Combine(eventExportNotification.FileExportFolder, "SensorDetectionAttempt.csv");
							str = eventExportNotification.EventParameters["SensorParentSide"].Item2;
							break;
						case ExportedEventType.PointDefenceAndDECM:
							text = Path.Combine(eventExportNotification.FileExportFolder, "PointDefenceAndDECM.csv");
							break;
						case ExportedEventType.UnitPositions:
							text = Path.Combine(eventExportNotification.FileExportFolder, "UnitPositions.csv");
							str = eventExportNotification.EventParameters["UnitSide"].Item2;
							break;
						case ExportedEventType.EngagementCycle:
							text = Path.Combine(eventExportNotification.FileExportFolder, "EngagementCycle.csv");
							str = eventExportNotification.EventParameters["UnitSide"].Item2;
							break;
						case ExportedEventType.FuelTransfer:
							text = Path.Combine(eventExportNotification.FileExportFolder, "FuelTransfer.csv");
							str = eventExportNotification.EventParameters["UnitSide"].Item2;
							break;
						}
						if (this.bSplitFilesBySide)
						{
							text = Path.Combine(eventExportNotification.FileExportFolder, str + "_" + Path.GetFileName(text));
						}
						if (!this.EventTypeFileHashSet.Contains(text))
						{
							if (!File.Exists(text))
							{
								this.CreateMetaData(text, eventExportNotification.EventParameters);
							}
							this.EventTypeFileHashSet.Add(text);
						}
						StringBuilder stringBuilder = new StringBuilder();
						using (Dictionary<string, Tuple<Type, string>>.ValueCollection.Enumerator enumerator = eventExportNotification.EventParameters.Values.GetEnumerator())
						{
							int num = 0;
							while (enumerator.MoveNext())
							{
								string value = enumerator.Current.Item2;
								value = EventExport_CSV.Class247.smethod_0(value);
								stringBuilder.Append(value);
								if (num != eventExportNotification.EventParameters.Count - 1)
								{
									stringBuilder.Append(",");
								}
								num++;
							}
						}
						StreamWriter streamWriter;
						if (this.dictionary_0.ContainsKey(text))
						{
							streamWriter = this.dictionary_0[text];
						}
						else
						{
							streamWriter = new StreamWriter(text, true, Encoding.GetEncoding("gb2312"));
							streamWriter.AutoFlush = true;
							this.dictionary_0.Add(text, streamWriter);
						}
						string value2 = stringBuilder.ToString();
						streamWriter.WriteLine(value2);
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			finally
			{
				this.bool_1 = false;
			}
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x00389F58 File Offset: 0x00388158
		private void CreateMetaData(string strEventTypeFile_, Dictionary<string, Tuple<Type, string>> EventParameters_)
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (string current in EventParameters_.Keys)
				{
					if (current == EventParameters_.Keys.ElementAtOrDefault(EventParameters_.Count - 1))
					{
						stringBuilder.Append(current);
					}
					else
					{
						stringBuilder.Append(current).Append(",");
					}
				}
				stringBuilder.Append("\r\n");
				File.WriteAllText(strEventTypeFile_, stringBuilder.ToString());
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x0038A028 File Offset: 0x00388228
		public void StopExport()
		{
			if (!Information.IsNothing(this.thread_0))
			{
				this.thread_0.Abort();
				this.thread_0 = null;
			}
			this.EventQueque = new ConcurrentQueue<EventExportNotification>();
			List<StreamWriter> list = this.dictionary_0.Values.ToList<StreamWriter>();
			foreach (StreamWriter current in list)
			{
				if (!Information.IsNothing(current))
				{
					current.Close();
					current.Dispose();
				}
			}
			this.dictionary_0.Clear();
			this.bool_1 = false;
		}

		// Token: 0x04003B60 RID: 15200
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003B61 RID: 15201
		private bool bSplitFilesBySide;

		// Token: 0x04003B62 RID: 15202
		private ConcurrentQueue<EventExportNotification> EventQueque;

		// Token: 0x04003B63 RID: 15203
		private bool bool_1;

		// Token: 0x04003B64 RID: 15204
		private bool bInitialized = false;

		// Token: 0x04003B65 RID: 15205
		private HashSet<string> EventTypeFileHashSet;

		// Token: 0x04003B66 RID: 15206
		private Dictionary<string, StreamWriter> dictionary_0;

		// Token: 0x04003B67 RID: 15207
		private Thread thread_0;

		// Token: 0x04003B68 RID: 15208
		[CompilerGenerated]
		private _RunMode enum100_0;

		// Token: 0x04003B69 RID: 15209
		[CompilerGenerated]
		private bool bUseZeroHour;

		// Token: 0x04003B6A RID: 15210
		[CompilerGenerated]
		private bool bExportSensorDetectionSuccess;

		// Token: 0x04003B6B RID: 15211
		[CompilerGenerated]
		private bool bExportSensorDetectionFailure;

		// Token: 0x04003B6C RID: 15212
		[CompilerGenerated]
		private bool bExportWeaponFired;

		// Token: 0x04003B6D RID: 15213
		[CompilerGenerated]
		private bool bExportWeaponEndgame;

		// Token: 0x04003B6E RID: 15214
		[CompilerGenerated]
		private bool bExportUnitPositions;

		// Token: 0x04003B6F RID: 15215
		[CompilerGenerated]
		private bool bool_9;

		// Token: 0x04003B70 RID: 15216
		[CompilerGenerated]
		private bool bool_10;

		// Token: 0x04003B71 RID: 15217
		[CompilerGenerated]
		private bool bool_11;

		// Token: 0x04003B72 RID: 15218
		[CompilerGenerated]
		private bool bool_12;

		// Token: 0x04003B73 RID: 15219
		[CompilerGenerated]
		private bool bool_13;

		// Token: 0x02000C67 RID: 3175
		public sealed class Class247
		{
			// Token: 0x0600695C RID: 26972 RVA: 0x0038A0D0 File Offset: 0x003882D0
			public static string smethod_0(string string_0)
			{
				string result;
				if (string.IsNullOrEmpty(string_0))
				{
					result = string_0;
				}
				else
				{
					if (Misc.smethod_21(string_0, "\""))
					{
						string_0 = string_0.Replace("\"", "\"\"");
					}
					if (string_0.IndexOfAny(EventExport_CSV.Class247.char_0) > -1)
					{
						string_0 = Convert.ToString("\"" + string_0) + "\"";
					}
					result = string_0;
				}
				return result;
			}

			// Token: 0x04003B74 RID: 15220
			private static char[] char_0 = new char[]
			{
				',',
				'"',
				'\n'
			};
		}
	}
}

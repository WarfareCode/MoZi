using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using ADODB;
using ADOX;
using Command_Core;
using DAO;
using DiskQueue;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns29;

namespace ns3
{
	// Token: 0x02000C68 RID: 3176
	public sealed class EventExport_MSAccess : IEventExporter
	{
		// Token: 0x0600695F RID: 26975 RVA: 0x0038A148 File Offset: 0x00388348
		[CompilerGenerated]
		public _RunMode GetRunMode()
		{
			return this.runMode;
		}

		// Token: 0x06006960 RID: 26976 RVA: 0x0002D708 File Offset: 0x0002B908
		[CompilerGenerated]
		public void SetRunMode(_RunMode value)
		{
			this.runMode = value;
		}

		// Token: 0x06006961 RID: 26977 RVA: 0x0002D711 File Offset: 0x0002B911
		[CompilerGenerated]
		public bool IsUseZeroHour()
		{
			return this.bUseZeroHour;
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x0002D719 File Offset: 0x0002B919
		[CompilerGenerated]
		public void SetUseZeroHour(bool value)
		{
			this.bUseZeroHour = value;
		}

		// Token: 0x06006963 RID: 26979 RVA: 0x0002D722 File Offset: 0x0002B922
		[CompilerGenerated]
		public bool IsExportSensorDetectionSuccess()
		{
			return this.bExportSensorDetectionSuccess;
		}

		// Token: 0x06006964 RID: 26980 RVA: 0x0002D72A File Offset: 0x0002B92A
		[CompilerGenerated]
		public void SetExportSensorDetectionSuccess(bool value)
		{
			this.bExportSensorDetectionSuccess = value;
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x0002D733 File Offset: 0x0002B933
		[CompilerGenerated]
		public bool IsExportSensorDetectionFailure()
		{
			return this.bExportSensorDetectionFailure;
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x0002D73B File Offset: 0x0002B93B
		[CompilerGenerated]
		public void SetExportSensorDetectionFailure(bool value)
		{
			this.bExportSensorDetectionFailure = value;
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x0002D744 File Offset: 0x0002B944
		[CompilerGenerated]
		public bool IsExportWeaponFired()
		{
			return this.bExportWeaponFired;
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x0002D74C File Offset: 0x0002B94C
		[CompilerGenerated]
		public void SetExportWeaponFired(bool value)
		{
			this.bExportWeaponFired = value;
		}

		// Token: 0x06006969 RID: 26985 RVA: 0x0002D755 File Offset: 0x0002B955
		[CompilerGenerated]
		public bool IsExportWeaponEndgame()
		{
			return this.bExportWeaponEndgame;
		}

		// Token: 0x0600696A RID: 26986 RVA: 0x0002D75D File Offset: 0x0002B95D
		[CompilerGenerated]
		public void SetExportWeaponEndgame(bool bool_12)
		{
			this.bExportWeaponEndgame = bool_12;
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x0002D766 File Offset: 0x0002B966
		[CompilerGenerated]
		public bool IsExportUnitPositions()
		{
			return this.bExportUnitPositions;
		}

		// Token: 0x0600696C RID: 26988 RVA: 0x0002D76E File Offset: 0x0002B96E
		[CompilerGenerated]
		public void SetExportUnitPositions(bool bool_12)
		{
			this.bExportUnitPositions = bool_12;
		}

		// Token: 0x0600696D RID: 26989 RVA: 0x0002D777 File Offset: 0x0002B977
		[CompilerGenerated]
		public bool IsExportEngagementCycle()
		{
			return this.bExportEngagementCycle;
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x0002D77F File Offset: 0x0002B97F
		[CompilerGenerated]
		public void SetExportEngagementCycle(bool value)
		{
			this.bExportEngagementCycle = value;
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x0002D788 File Offset: 0x0002B988
		[CompilerGenerated]
		public bool imethod_24()
		{
			return this.bool_7;
		}

		// Token: 0x06006970 RID: 26992 RVA: 0x0002D790 File Offset: 0x0002B990
		[CompilerGenerated]
		public void imethod_25(bool bool_12)
		{
			this.bool_7 = bool_12;
		}

		// Token: 0x06006971 RID: 26993 RVA: 0x0002D799 File Offset: 0x0002B999
		[CompilerGenerated]
		public bool IsExportFuelConsumed()
		{
			return this.bExportFuelConsumed;
		}

		// Token: 0x06006972 RID: 26994 RVA: 0x0002D7A1 File Offset: 0x0002B9A1
		[CompilerGenerated]
		public void SetExportFuelConsumed(bool value)
		{
			this.bExportFuelConsumed = value;
		}

		// Token: 0x06006973 RID: 26995 RVA: 0x0002D7AA File Offset: 0x0002B9AA
		[CompilerGenerated]
		public bool IsExportFuelTransfer()
		{
			return this.bExportFuelTransfer;
		}

		// Token: 0x06006974 RID: 26996 RVA: 0x0002D7B2 File Offset: 0x0002B9B2
		[CompilerGenerated]
		public void SetExportFuelTransfer(bool value)
		{
			this.bExportFuelTransfer = value;
		}

		// Token: 0x06006975 RID: 26997 RVA: 0x0002D7BB File Offset: 0x0002B9BB
		[CompilerGenerated]
		public bool imethod_30()
		{
			return this.bool_10;
		}

		// Token: 0x06006976 RID: 26998 RVA: 0x0038A160 File Offset: 0x00388360
		public EventExport_MSAccess(_RunMode enum100_1)
		{
			this.bool_11 = false;
			this.m_DBEngine = (DBEngine)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000100-0000-0010-8000-00AA006D2EA4")));
			this.RecordsetDictionary = new Dictionary<string, Recordset>();
			this.hashSet_0 = new HashSet<string>();
			this.SetRunMode(enum100_1);
			Class2372 @class = new Class2372(EventExporters.strIniFile);
			this.SetUseZeroHour(@class.GetConfigList()["MSAccess Settings"].GetValueString("UseZeroHour"));
			this.SetExportSensorDetectionSuccess(@class.GetConfigList()["MSAccess Settings"].GetValueString("ExportSensorDetectionSuccess"));
			this.SetExportSensorDetectionFailure(@class.GetConfigList()["MSAccess Settings"].GetValueString("ExportSensorDetectionFailure"));
			this.SetExportWeaponFired(@class.GetConfigList()["MSAccess Settings"].GetValueString("ExportWeaponFired"));
			this.SetExportWeaponEndgame(@class.GetConfigList()["MSAccess Settings"].GetValueString("ExportWeaponEndgame"));
			this.SetExportUnitPositions(@class.GetConfigList()["MSAccess Settings"].GetValueString("ExportUnitPositions"));
			this.SetExportEngagementCycle(@class.GetConfigList()["MSAccess Settings"].GetValueString("ExportEngagementCycle"));
			this.SetExportFuelConsumed(@class.GetConfigList()["MSAccess Settings"].GetValueString("ExportFuelConsumed"));
			this.SetExportFuelTransfer(@class.GetConfigList()["MSAccess Settings"].GetValueString("ExportFuelTransfer"));
			this.SetExportDirectory(MyTemplate.GetApp().Info.DirectoryPath);
			string path = Path.Combine(this.GetExportDirectory(), "EventExport.mdb");
			if (File.Exists(path))
			{
				try
				{
					File.Delete(path);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			this.method_0();
			this.StartExport();
		}

		// Token: 0x06006977 RID: 26999 RVA: 0x0002D7C3 File Offset: 0x0002B9C3
		public void StartExport()
		{
			this.EventExportThread = new Thread(new ThreadStart(this.DoExport));
			this.EventExportThread.Priority = ThreadPriority.BelowNormal;
			this.EventExportThread.Start();
		}

		// Token: 0x06006978 RID: 27000 RVA: 0x0038A34C File Offset: 0x0038854C
		private void method_0()
		{
			string text;
			if (this.GetRunMode() == _RunMode.Normal)
			{
				text = Path.Combine(GameGeneral.strTempDir, "DiskQueue_EventExport_MSAccess_Interactive");
			}
			else
			{
				text = Path.Combine(GameGeneral.strTempDir, "DiskQueue_EventExport_MSAccess_NonInteractive");
			}
			if (Directory.Exists(text))
			{
				Misc.ClearTemp(text);
			}
			this.diskQueue = new PersistentQueue(text);
			this.diskQueue.Internals.ParanoidFlushing = false;
		}

		// Token: 0x06006979 RID: 27001 RVA: 0x0002D7F3 File Offset: 0x0002B9F3
		private void DoExport()
		{
			while (true)
			{
				Thread.Sleep(100);
				if (!this.bool_11)
				{
					this.ExportToMSAccess();
				}
			}
		}

		// Token: 0x0600697A RID: 27002 RVA: 0x0038A3B8 File Offset: 0x003885B8
		[CompilerGenerated]
		public string GetExportDirectory()
		{
			return this.strExportDirectory;
		}

		// Token: 0x0600697B RID: 27003 RVA: 0x0002D811 File Offset: 0x0002BA11
		[CompilerGenerated]
		public void SetExportDirectory(string string_1)
		{
			this.strExportDirectory = string_1;
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x0038A3D0 File Offset: 0x003885D0
		public void ExportEvent(ExportedEventType exportedEventType_0, Dictionary<string, Tuple<Type, string>> dictionary_1, Scenario scenario_0)
		{
			EventExportNotification eventExportNotification = new EventExportNotification();
			eventExportNotification.EventType = exportedEventType_0;
			eventExportNotification.EventParameters = dictionary_1;
			eventExportNotification.FileExportFolder = this.GetExportDirectory();
			try
			{
				IPersistentQueueSession persistentQueueSession = this.diskQueue.OpenSession();
				using (persistentQueueSession)
				{
					persistentQueueSession.Enqueue(eventExportNotification.GetExportData());
					persistentQueueSession.Flush();
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
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x0038A468 File Offset: 0x00388668
		private void ExportToMSAccess()
		{
			this.bool_11 = true;
			Dictionary<string, Database> dictionary = new Dictionary<string, Database>();
			try
			{
				if (!Information.IsNothing(this.diskQueue))
				{
					while (this.diskQueue.EstimatedCountOfItemsInQueue > 0)
					{
						IPersistentQueueSession persistentQueueSession = this.diskQueue.OpenSession();
						byte[] array;
						using (persistentQueueSession)
						{
							array = persistentQueueSession.Dequeue();
							persistentQueueSession.Flush();
						}
						if (!Information.IsNothing(array))
						{
							EventExportNotification eventExportNotification = EventExportNotification.smethod_0(array);
							if (!Information.IsNothing(eventExportNotification))
							{
								string text = Path.Combine(eventExportNotification.FileExportFolder, "EventExport.mdb");
								string text2 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + text + "; Jet OLEDB:Engine Type=5";
								Database database;
								if (dictionary.ContainsKey(text))
								{
									database = dictionary[text];
								}
								else
								{
									if (!File.Exists(text))
									{
										this.CreateDataBase(text2);
									}
									database = this.m_DBEngine.OpenDatabase(text, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
								}
								string text3;
								switch (eventExportNotification.EventType)
								{
								case ExportedEventType.WeaponFired:
									text3 = "WeaponFired";
									break;
								case ExportedEventType.WeaponEndgame:
									text3 = "WeaponEndgame";
									break;
								case ExportedEventType.FuelConsumed:
									text3 = "FuelConsumed";
									break;
								case ExportedEventType.UnitDestroyed:
									text3 = "UnitDestroyed";
									break;
								case ExportedEventType.SensorDetectionAttempt:
									text3 = "SensorDetectionAttempt";
									break;
								case ExportedEventType.PointDefenceAndDECM:
									text3 = "PointDefenceAndDECM";
									break;
								case ExportedEventType.UnitPositions:
									text3 = "UnitPositions";
									break;
								case ExportedEventType.EngagementCycle:
									text3 = "EngagementCycle";
									break;
								case ExportedEventType.FuelTransfer:
									text3 = "FuelTransfer";
									break;
								default:
									text3 = eventExportNotification.EventType.ToString();
									break;
								}
								string text4 = text + "_" + text3;
								if (!this.hashSet_0.Contains(text4) && !this.IsTableExist(text4, database))
								{
									this.CreateTable(text3, eventExportNotification, text2);
									while (!this.IsTableExist(text3, database))
									{
									}
									this.hashSet_0.Add(text4);
								}
								Recordset recordset;
								if (this.RecordsetDictionary.ContainsKey(text4))
								{
									recordset = this.RecordsetDictionary[text4];
								}
								else
								{
									recordset = database.OpenRecordset(text3, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
									this.RecordsetDictionary.Add(text4, recordset);
								}
								this.AddRecord(recordset, eventExportNotification);
							}
						}
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
				foreach (Database current in dictionary.Values)
				{
					if (!Information.IsNothing(current))
					{
						current.Close();
					}
				}
				this.bool_11 = false;
			}
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x0038A79C File Offset: 0x0038899C
		private void AddRecord(Recordset rs, EventExportNotification eventExportNotification_)
		{
			try
			{
				rs.AddNew();
				foreach (KeyValuePair<string, Tuple<Type, string>> current in eventExportNotification_.EventParameters)
				{
					if (!string.IsNullOrEmpty(eventExportNotification_.EventParameters[current.Key].Item2))
					{
						try
						{
							Tuple<Type, string> tuple = eventExportNotification_.EventParameters[current.Key];
							if (!string.IsNullOrEmpty(tuple.Item2))
							{
								string name = tuple.Item1.Name;
								if (Operators.CompareString(name, "String", false) != 0)
								{
									if (Operators.CompareString(name, "DateTime", false) != 0 && Operators.CompareString(name, "TimeSpan", false) != 0)
									{
										string value;
										if (Versioned.IsNumeric(tuple.Item2))
										{
											value = tuple.Item2;
										}
										else
										{
											value = "";
										}
										rs.Fields[current.Key].Value = value;
									}
									else
									{
										DateTime dateTime = DateTime.Parse(tuple.Item2);
										rs.Fields[current.Key].Value = dateTime;
									}
								}
								else
								{
									string value = Strings.Replace(tuple.Item2, "'", "''", 1, -1, CompareMethod.Binary);
									rs.Fields[current.Key].Value = value;
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
							throw;
						}
					}
				}
				rs.Update(1, false);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x0038A994 File Offset: 0x00388B94
		public int GetEventQueueLength()
		{
			return this.diskQueue.EstimatedCountOfItemsInQueue;
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x0038A9B0 File Offset: 0x00388BB0
		public string GetExporterName()
		{
			return "MSAccess";
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x0002B574 File Offset: 0x00029774
		public _ExporterType GetExporterType()
		{
			return _ExporterType.MSAccess;
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x0038A9C4 File Offset: 0x00388BC4
		private bool CreateDataBase(string string_1)
		{
			bool result = false;
			Catalog catalog = (Catalog)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000602-0000-0010-8000-00AA006D2EA4")));
			try
			{
				catalog.Create(string_1);
				Connection connection = catalog.ActiveConnection as Connection;
				if (connection != null)
				{
					connection.Open("", "", "", -1);
				}
				result = true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x0038AA44 File Offset: 0x00388C44
		private bool IsTableExist(string strTable, Database db)
		{
			db.TableDefs.Refresh();
			IEnumerator enumerator = db.TableDefs.GetEnumerator();
			bool result;
			try
			{
				while (enumerator.MoveNext())
				{
					if (Operators.CompareString(((TableDef)enumerator.Current).Name, strTable, false) == 0)
					{
						result = true;
						return result;
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x0038AAC8 File Offset: 0x00388CC8
		private void CreateTable(string strTablename, EventExportNotification eventExportNotification_, string ConnectStr)
		{
			Connection connection = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000514-0000-0010-8000-00AA006D2EA4")));
			Catalog catalog = (Catalog)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000602-0000-0010-8000-00AA006D2EA4")));
			Table table = (Table)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000609-0000-0010-8000-00AA006D2EA4")));
			try
			{
				connection.Open(ConnectStr, "", "", -1);
				catalog.ActiveConnection = connection;
				table.Name = strTablename;
				foreach (KeyValuePair<string, Tuple<Type, string>> current in eventExportNotification_.EventParameters)
				{
					Type item = current.Value.Item1;
					DataTypeEnum type;
					if (item == typeof(string))
					{
						type = DataTypeEnum.adLongVarWChar;
					}
					else if (item == typeof(int))
					{
						type = DataTypeEnum.adInteger;
					}
					else if (item == typeof(float))
					{
						type = DataTypeEnum.adSingle;
					}
					else if (item == typeof(double))
					{
						type = DataTypeEnum.adDouble;
					}
					else if (item == typeof(DateTime))
					{
						type = DataTypeEnum.adDate;
					}
					else if (item == typeof(TimeSpan))
					{
						type = DataTypeEnum.adDate;
					}
					else
					{
						type = DataTypeEnum.adLongVarWChar;
					}
					Column column = (Column)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("0000061B-0000-0010-8000-00AA006D2EA4")));
					Column column2 = column;
					column2.Name = current.Key;
					column2.Attributes = ColumnAttributesEnum.adColNullable;
					column2.Type = type;
					table.Columns.Append(column, DataTypeEnum.adVarWChar, 0);
				}
				catalog.Tables.Append(table);
				connection.Close();
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

		// Token: 0x06006985 RID: 27013 RVA: 0x0038ACF0 File Offset: 0x00388EF0
		public void StopExport()
		{
			if (!Information.IsNothing(this.EventExportThread))
			{
				this.EventExportThread.Abort();
				this.EventExportThread = null;
			}
			this.diskQueue.Dispose();
			this.diskQueue = null;
			foreach (Recordset current in this.RecordsetDictionary.Values)
			{
				if (!Information.IsNothing(current))
				{
					current.Close();
				}
			}
			this.RecordsetDictionary.Clear();
			this.hashSet_0.Clear();
			this.bool_11 = false;
		}

		// Token: 0x04003B75 RID: 15221
		[CompilerGenerated]
		private _RunMode runMode;

		// Token: 0x04003B76 RID: 15222
		[CompilerGenerated]
		private bool bUseZeroHour;

		// Token: 0x04003B77 RID: 15223
		[CompilerGenerated]
		private bool bExportSensorDetectionSuccess;

		// Token: 0x04003B78 RID: 15224
		[CompilerGenerated]
		private bool bExportSensorDetectionFailure = false;

		// Token: 0x04003B79 RID: 15225
		[CompilerGenerated]
		private bool bExportWeaponFired;

		// Token: 0x04003B7A RID: 15226
		[CompilerGenerated]
		private bool bExportWeaponEndgame;

		// Token: 0x04003B7B RID: 15227
		[CompilerGenerated]
		private bool bExportUnitPositions;

		// Token: 0x04003B7C RID: 15228
		[CompilerGenerated]
		private bool bExportEngagementCycle;

		// Token: 0x04003B7D RID: 15229
		[CompilerGenerated]
		private bool bool_7;

		// Token: 0x04003B7E RID: 15230
		[CompilerGenerated]
		private bool bExportFuelConsumed;

		// Token: 0x04003B7F RID: 15231
		[CompilerGenerated]
		private bool bExportFuelTransfer;

		// Token: 0x04003B80 RID: 15232
		[CompilerGenerated]
		private bool bool_10;

		// Token: 0x04003B81 RID: 15233
		private bool bool_11;

		// Token: 0x04003B82 RID: 15234
		private DBEngine m_DBEngine;

		// Token: 0x04003B83 RID: 15235
		private Dictionary<string, Recordset> RecordsetDictionary;

		// Token: 0x04003B84 RID: 15236
		private HashSet<string> hashSet_0;

		// Token: 0x04003B85 RID: 15237
		private Thread EventExportThread;

		// Token: 0x04003B86 RID: 15238
		private IPersistentQueue diskQueue;

		// Token: 0x04003B87 RID: 15239
		[CompilerGenerated]
		private string strExportDirectory;
	}
}

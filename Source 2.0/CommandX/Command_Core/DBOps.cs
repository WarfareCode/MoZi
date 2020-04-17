using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns3;

namespace Command_Core
{
	// 数据库操作
	public sealed class DBOps
	{
		// Token: 0x06006335 RID: 25397 RVA: 0x0030FD78 File Offset: 0x0030DF78
		static DBOps()
		{
			DBOps.SetDBRecordDictionary(new ObservableDictionary<string, DBRecord>());
			DBOps.UnregisteredDBRecords = new Dictionary<string, DBRecord>();
			DBOps.bool_0 = false;
			DBOps.bool_1 = false;
		}

		// Token: 0x06006336 RID: 25398 RVA: 0x0030FDD0 File Offset: 0x0030DFD0
		[CompilerGenerated]
		private static ObservableDictionary<string, DBRecord> GetDBRecordDictionary()
		{
			return DBOps.DBRecordObservableDictionary;
		}

		// Token: 0x06006337 RID: 25399 RVA: 0x0030FDE4 File Offset: 0x0030DFE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void SetDBRecordDictionary(ObservableDictionary<string, DBRecord> observableDictionary_1)
		{
			INotifyDictionaryChanged<string, DBRecord>.DictionaryChangedEventHandler value = new INotifyDictionaryChanged<string, DBRecord>.DictionaryChangedEventHandler(DBOps.DBRecordDictionary_DictionaryChanged);
			ObservableDictionary<string, DBRecord> dBRecordObservableDictionary = DBOps.DBRecordObservableDictionary;
			if (dBRecordObservableDictionary != null)
			{
				dBRecordObservableDictionary.DictionaryChanged -= value;
			}
			DBOps.DBRecordObservableDictionary = observableDictionary_1;
			dBRecordObservableDictionary = DBOps.DBRecordObservableDictionary;
			if (dBRecordObservableDictionary != null)
			{
				dBRecordObservableDictionary.DictionaryChanged += value;
			}
		}

		// Token: 0x06006338 RID: 25400 RVA: 0x0030FE2C File Offset: 0x0030E02C
		[CompilerGenerated]
		public static void smethod_2(DBOps.Delegate26 delegate26_1)
		{
			DBOps.Delegate26 @delegate = DBOps.delegate26_0;
			DBOps.Delegate26 delegate2;
			do
			{
				delegate2 = @delegate;
				DBOps.Delegate26 value = (DBOps.Delegate26)Delegate.Combine(delegate2, delegate26_1);
				@delegate = Interlocked.CompareExchange<DBOps.Delegate26>(ref DBOps.delegate26_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x0030FE64 File Offset: 0x0030E064
		public static ReadOnlyCollection<DBRecord> GetOfficialDBRecords()
		{
			List<DBRecord> list = new List<DBRecord>();
			list.AddRange(DBOps.GetDBRecordDictionary().Values);
			return list.AsReadOnly();
		}

		// Token: 0x0600633A RID: 25402 RVA: 0x0030FE90 File Offset: 0x0030E090
		public static ReadOnlyCollection<DBRecord> GetUnregisteredDBRecords()
		{
			List<DBRecord> list = new List<DBRecord>();
			list.AddRange(DBOps.UnregisteredDBRecords.Values);
			return list.AsReadOnly();
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private static void DBRecordDictionary_DictionaryChanged(object sender, NotifyDictionaryChangedEventArgs<string, DBRecord> e)
		{
		}

		// Token: 0x0600633C RID: 25404 RVA: 0x0030FEBC File Offset: 0x0030E0BC
		public static void ScanDatabase()
		{
			string directoryPath = MyTemplate.GetApp().Info.DirectoryPath;
			DBOps.ReadDBInfo();
			DBOps.bool_0 = true;
			if (DBOps.bSupportUnregisteredDB)
			{
				DBOps.ScanDBFiles(directoryPath);
			}
			DBOps.bool_1 = true;
			DBOps.Delegate26 @delegate = DBOps.delegate26_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x0600633D RID: 25405 RVA: 0x0030FF0C File Offset: 0x0030E10C
		public static string smethod_7(DBOps.DBFileCheckResult dbfileCheckResult_0)
		{
			string result;
			switch (dbfileCheckResult_0)
			{
			case DBOps.DBFileCheckResult.Undefined:
				result = "Undefined result";
				break;
			case DBOps.DBFileCheckResult.AllOK:
				result = "Everything OK";
				break;
			case DBOps.DBFileCheckResult.DBFileNotPresent:
				result = "Database file was not found - Please contact the database author to obtain a copy of this version of the database";
				break;
			case DBOps.DBFileCheckResult.DBIsUnregistered:
				result = "Database is unregistered";
				break;
			case DBOps.DBFileCheckResult.DBFileIsTampered:
				result = "The database file has been tampered";
				break;
			default:
				if (dbfileCheckResult_0 != DBOps.DBFileCheckResult.UnspecifiedError)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = dbfileCheckResult_0.ToString();
				}
				else
				{
					result = "Unspecified error";
				}
				break;
			}
			return result;
		}

		// Token: 0x0600633E RID: 25406 RVA: 0x0030FF90 File Offset: 0x0030E190
		private static XmlDocument GetDBInfoXmlDoc()
		{
			XmlDocument result;
			if (!Information.IsNothing(DBOps.DBInfoXmlDoc))
			{
				result = DBOps.DBInfoXmlDoc;
			}
			else
			{
				StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.strDBDir, "DBInfo.dat"));
				string text;
				using (streamReader)
				{
					text = streamReader.ReadToEnd();
				}
				text = DBCryptoService.Decrypt(text, "");
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(text);
				DBOps.DBInfoXmlDoc = xmlDocument;
				result = xmlDocument;
			}
			return result;
		}

		// Token: 0x0600633F RID: 25407 RVA: 0x00310018 File Offset: 0x0030E218
		private static bool smethod_9(DBRecord dbrecord_0)
		{
			string left = DBCryptoService.Encrypt(Path.Combine(GameGeneral.strDBDir, dbrecord_0.Filename));
			string hash = dbrecord_0.Hash;
			return Operators.CompareString(left, hash, false) != 0;
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x00310050 File Offset: 0x0030E250
		public static DBRecord GetDBRecord(string theHash, ref DBOps.DBFileCheckResult theResult, bool CheckLocalFileExists = true, bool CheckForTampering = true)
		{
			DBRecord dBRecord2;
			DBRecord result;
			try
			{
				DBRecord dBRecord;
				if (DBOps.GetDBRecordDictionary().ContainsKey(theHash))
				{
					dBRecord = DBOps.GetDBRecordDictionary()[theHash];
				}
				else
				{
					if (!DBOps.bSupportUnregisteredDB)
					{
						theResult = DBOps.DBFileCheckResult.DBIsUnregistered;
						dBRecord2 = null;
						result = dBRecord2;
						return result;
					}
					dBRecord = DBOps.UnregisteredDBRecords[theHash];
				}
				if (CheckLocalFileExists && !dBRecord.ExistsDBFile())
				{
					theResult = DBOps.DBFileCheckResult.DBFileNotPresent;
					dBRecord2 = null;
				}
				else if (CheckForTampering && (DBOps.smethod_9(dBRecord) & !DBOps.bSupportUnregisteredDB))
				{
					theResult = DBOps.DBFileCheckResult.DBFileIsTampered;
					dBRecord2 = null;
				}
				else
				{
					theResult = DBOps.DBFileCheckResult.AllOK;
					dBRecord2 = dBRecord;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				theResult = DBOps.DBFileCheckResult.UnspecifiedError;
				dBRecord2 = null;
				ProjectData.ClearProjectError();
			}
			result = dBRecord2;
			return result;
		}

		// Token: 0x06006341 RID: 25409 RVA: 0x00310110 File Offset: 0x0030E310
		public static DBRecord GetDBRecord(string theHash)
		{
			DBRecord dBRecord;
			DBRecord result;
			try
			{
				if (DBOps.GetDBRecordDictionary().ContainsKey(theHash))
				{
					dBRecord = DBOps.GetDBRecordDictionary()[theHash];
				}
				else
				{
					StreamReader streamReader = new StreamReader(Path.Combine(GameGeneral.strDBDir, "DBInfo.dat"));
					string text = "";
					using (streamReader)
					{
						text = streamReader.ReadToEnd();
					}
					text = DBCryptoService.Decrypt(text, "");
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(text);
					XmlNode xmlNode = xmlDocument.SelectSingleNode("/DBFiles");
					IEnumerator enumerator = xmlNode.ChildNodes.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							XmlNode xmlNode2 = (XmlNode)enumerator.Current;
							DBRecord dBRecord2 = new DBRecord(Conversions.ToInteger(xmlNode2.SelectSingleNode("DBID").InnerText), xmlNode2.SelectSingleNode("Hash").InnerText, xmlNode2.SelectSingleNode("Name").InnerText, xmlNode2.SelectSingleNode("File").InnerText, Conversions.ToBoolean(xmlNode2.SelectSingleNode("Supported").InnerText));
							if (Operators.CompareString(dBRecord2.Hash, theHash, false) == 0 && File.Exists(Path.Combine(GameGeneral.strDBDir, dBRecord2.Filename)) && Operators.CompareString(DBCryptoService.Encrypt(Path.Combine(GameGeneral.strDBDir, dBRecord2.Filename)), dBRecord2.Hash, false) == 0)
							{
								try
								{
									DBOps.GetDBRecordDictionary().Add(dBRecord2.Hash, dBRecord2);
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ex2.Data.Add("Error at 200483", ex2.Message);
									GameGeneral.LogException(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
								}
								dBRecord = dBRecord2;
								result = dBRecord;
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
					dBRecord = DBOps.UnregisteredDBRecords[theHash];
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw new Exception1("您正在尝试加载数据库文件夹中不存在的数据库。请更新到CommandX最新版本，确保您拥有最新版的装备数据库。");
			}
			result = dBRecord;
			return result;
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x003103A0 File Offset: 0x0030E5A0
		public static string GetDBRecordHash(int DBID_)
		{
			while (DBOps.GetDBRecordDictionary().Count == 0)
			{
				Thread.Sleep(100);
			}
			try
			{
				Dictionary<string, DBRecord> dictionary = new Dictionary<string, DBRecord>();
				foreach (KeyValuePair<string, DBRecord> current in DBOps.GetDBRecordDictionary())
				{
					dictionary.Add(current.Key, current.Value);
				}
				if (GameGeneral.bProfessionEdition)
				{
					foreach (KeyValuePair<string, DBRecord> current2 in DBOps.UnregisteredDBRecords)
					{
						if (!dictionary.ContainsKey(current2.Key))
						{
							dictionary.Add(current2.Key, current2.Value);
						}
					}
				}
				IOrderedEnumerable<KeyValuePair<string, DBRecord>> orderedEnumerable = dictionary.OrderByDescending(DBOps.KeyValuePairFunc);
				foreach (KeyValuePair<string, DBRecord> current3 in orderedEnumerable)
				{
					if ((current3.Value.DBID == DBID_ || GameGeneral.bProfessionEdition) && current3.Value.ExistsDBFile())
					{
						return current3.Key;
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
			throw new Exception("没有找到具备此ID号的数据库版本!");
		}

		// Token: 0x06006343 RID: 25411 RVA: 0x0031056C File Offset: 0x0030E76C
		public static string GetDataSource(string string_0, string strHash)
		{
			bool flag = false;
			DBRecord dBRecord = null;
			string result = "";
			try
			{
				if (DBOps.GetDBRecordDictionary().ContainsKey(strHash))
				{
					flag = true;
					dBRecord = DBOps.GetDBRecordDictionary()[strHash];
				}
				if (DBOps.UnregisteredDBRecords.ContainsKey(strHash))
				{
					dBRecord = DBOps.UnregisteredDBRecords[strHash];
				}
				if (Information.IsNothing(dBRecord))
				{
					throw new Exception1("您正在尝试加载数据库文件夹中不存在的数据库。");
				}
				if (!dBRecord.ExistsDBFile())
				{
					string text = "您正在尝试加载数据库文件夹中不存在的数据库。 ";
					if (flag)
					{
						text = text + "数据库的注册名: " + dBRecord.DBName + ".请联系数据库管理员获取数据库拷贝。";
					}
					else
					{
						text = text + "数据库没有注册,文件哈希码: " + strHash + ". 请联系数据库管理员确保可以找到与哈希码相对应的数据库版本。";
					}
					throw new Exception1(text);
				}
				result = dBRecord.GetDataSourceString();
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
			return result;
		}

		// Token: 0x06006344 RID: 25412 RVA: 0x00310654 File Offset: 0x0030E854
		private static void ScanDBFiles(string string_0)
		{
			string[] files = Directory.GetFiles(GameGeneral.strDBDir);
			checked
			{
				for (int i = 0; i < files.Length; i++)
				{
					string fileName = Path.GetFileName(files[i]);
					if (fileName.EndsWith(".db3"))
					{
						bool flag = false;
						using (IEnumerator<DBRecord> enumerator = DBOps.GetDBRecordDictionary().Values.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (Operators.CompareString(enumerator.Current.Filename, fileName, false) == 0)
								{
									flag = true;
									IL_74:
									if (!flag)
									{
										string text = DBCryptoService.Encrypt(Path.Combine(GameGeneral.strDBDir, fileName));
										DBOps.UnregisteredDBRecords.Add(text, new DBRecord(0, text, "用户数据库: " + fileName, fileName, false));
									}
									goto IL_B9;
								}
							}
                            if (!flag)
                            {
                                string text = DBCryptoService.Encrypt(Path.Combine(GameGeneral.strDBDir, fileName));
                                DBOps.UnregisteredDBRecords.Add(text, new DBRecord(0, text, "用户数据库: " + fileName, fileName, false));
                            }
                            goto IL_B9;
                        }
					}
					IL_B9:;
				}
			}
		}

		// Token: 0x06006345 RID: 25413 RVA: 0x0031073C File Offset: 0x0030E93C
		private static void ReadDBInfo()
		{
			DBOps.GetDBRecordDictionary().Clear();
			XmlNode xmlNode = DBOps.GetDBInfoXmlDoc().SelectSingleNode("/DBFiles");
			IEnumerator enumerator = xmlNode.ChildNodes.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = (XmlNode)enumerator.Current;
					DBRecord dBRecord = new DBRecord(Conversions.ToInteger(xmlNode2.SelectSingleNode("DBID").InnerText), xmlNode2.SelectSingleNode("Hash").InnerText, xmlNode2.SelectSingleNode("Name").InnerText, xmlNode2.SelectSingleNode("File").InnerText, Conversions.ToBoolean(xmlNode2.SelectSingleNode("Supported").InnerText));
					if (File.Exists(Path.Combine(GameGeneral.strDBDir, dBRecord.Filename)) && Operators.CompareString(DBCryptoService.Encrypt(Path.Combine(GameGeneral.strDBDir, dBRecord.Filename)), dBRecord.Hash, false) == 0)
					{
						try
						{
							DBOps.GetDBRecordDictionary().Add(dBRecord.Hash, dBRecord);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200484", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
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
		}

		// Token: 0x040035E0 RID: 13792
		public static Func<KeyValuePair<string, DBRecord>, DateTime> KeyValuePairFunc = (KeyValuePair<string, DBRecord> keyValuePair_0) => new FileInfo(Path.Combine(GameGeneral.strDBDir, keyValuePair_0.Value.Filename)).LastWriteTime;

		// Token: 0x040035E1 RID: 13793
		[CompilerGenerated]
		private static ObservableDictionary<string, DBRecord> DBRecordObservableDictionary;

		// Token: 0x040035E2 RID: 13794
		private static Dictionary<string, DBRecord> UnregisteredDBRecords;

		// Token: 0x040035E3 RID: 13795
		public static bool bool_0;

		// Token: 0x040035E4 RID: 13796
		public static bool bool_1;

		// Token: 0x040035E5 RID: 13797
		[CompilerGenerated]
		private static DBOps.Delegate26 delegate26_0;

		// Token: 0x040035E6 RID: 13798
		internal static bool bSupportUnregisteredDB = false;

		// Token: 0x040035E7 RID: 13799
		private static XmlDocument DBInfoXmlDoc;

		// Token: 0x02000BB5 RID: 2997
		// (Invoke) Token: 0x06006349 RID: 25417
		public delegate void Delegate26();

		// Token: 0x02000BB6 RID: 2998
		public enum DBFileCheckResult
		{
			// Token: 0x040035EA RID: 13802
			Undefined,
			// Token: 0x040035EB RID: 13803
			AllOK,
			// Token: 0x040035EC RID: 13804
			DBFileNotPresent,
			// Token: 0x040035ED RID: 13805
			DBIsUnregistered,
			// Token: 0x040035EE RID: 13806
			DBFileIsTampered,
			// Token: 0x040035EF RID: 13807
			UnspecifiedError = 9999
		}
	}
}

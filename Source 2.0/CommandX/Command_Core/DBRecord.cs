using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace Command_Core
{
	// Token: 0x02000BB7 RID: 2999
	public sealed class DBRecord
	{
		// Token: 0x0600634C RID: 25420 RVA: 0x00310908 File Offset: 0x0030EB08
		public List<string> method_0()
		{
			if (Information.IsNothing(this.list_0))
			{
				this.list_0 = new List<string>();
				DataTable dataTable = new DataTable();
				DataTable dataTable2 = new DataTable();
				DataTable dataTable3 = new DataTable();
				DataTable dataTable4 = new DataTable();
				DataTable dataTable5 = new DataTable();
				DataTable dataTable6 = new DataTable();
				SQLiteConnection sQLiteConnection = new SQLiteConnection(this.GetDataSourceString());
				DBFunctions.LoadPlatformDataTables(ref dataTable, ref dataTable2, ref dataTable3, ref dataTable4, ref dataTable5, ref dataTable6, ref sQLiteConnection);
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						this.list_0.Add("Aircraft #" + dataRow["ID"].ToString());
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						this.list_0.Add("Ship #" + dataRow2["ID"].ToString());
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				IEnumerator enumerator3 = dataTable3.Rows.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator3.Current;
						this.list_0.Add("Submarine #" + dataRow3["ID"].ToString());
					}
				}
				finally
				{
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				IEnumerator enumerator4 = dataTable4.Rows.GetEnumerator();
				try
				{
					while (enumerator4.MoveNext())
					{
						DataRow dataRow4 = (DataRow)enumerator4.Current;
						this.list_0.Add("Facility #" + dataRow4["ID"].ToString());
					}
				}
				finally
				{
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
				IEnumerator enumerator5 = dataTable5.Rows.GetEnumerator();
				try
				{
					while (enumerator5.MoveNext())
					{
						DataRow dataRow5 = (DataRow)enumerator5.Current;
						this.list_0.Add("Satellite #" + dataRow5["ID"].ToString());
					}
				}
				finally
				{
					if (enumerator5 is IDisposable)
					{
						(enumerator5 as IDisposable).Dispose();
					}
				}
				IEnumerator enumerator6 = dataTable6.Rows.GetEnumerator();
				try
				{
					while (enumerator6.MoveNext())
					{
						DataRow dataRow6 = (DataRow)enumerator6.Current;
						this.list_0.Add("Weapon #" + dataRow6["ID"].ToString());
					}
				}
				finally
				{
					if (enumerator6 is IDisposable)
					{
						(enumerator6 as IDisposable).Dispose();
					}
				}
			}
			return this.list_0;
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x0002B7F2 File Offset: 0x000299F2
		public bool IsOfficialDBRecord()
		{
			return DBOps.GetOfficialDBRecords().Contains(this);
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x0002B7FF File Offset: 0x000299FF
		public bool ExistsDBFile()
		{
			return File.Exists(MyTemplate.GetApp().Info.DirectoryPath + "\\DB\\" + this.Filename);
		}

		// Token: 0x0600634F RID: 25423 RVA: 0x00310C54 File Offset: 0x0030EE54
		public string GetDataSourceString()
		{
			string directoryPath = MyTemplate.GetApp().Info.DirectoryPath;
			return string.Concat(new string[]
			{
				"Data Source=",
				directoryPath,
				"\\DB\\",
				this.Filename,
				";Version=3;Read Only=True;"
			});
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x0002B825 File Offset: 0x00029A25
		public bool method_4()
		{
			return Operators.CompareString(DBOps.GetDBRecordHash(this.DBID), this.Hash, false) == 0;
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x0002B841 File Offset: 0x00029A41
		public DBRecord(int theDBID, string theHash, string theDBName, string theFilename, bool IsSupported = false)
		{
			this.DBID = theDBID;
			this.Hash = theHash;
			this.DBName = theDBName;
			this.Filename = theFilename;
			this.IsSupported = new bool?(IsSupported);
		}

		// Token: 0x040035F0 RID: 13808
		public int DBID;

		// Token: 0x040035F1 RID: 13809
		public string Hash;

		// Token: 0x040035F2 RID: 13810
		public string DBName;

		// Token: 0x040035F3 RID: 13811
		public string Filename = "";

		// Token: 0x040035F4 RID: 13812
		public bool? IsSupported;

		// Token: 0x040035F5 RID: 13813
		private List<string> list_0;
	}
}

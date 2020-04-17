using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3
{
	// Token: 0x02000BAB RID: 2987
	public sealed class SQLiteDataBase
	{
		// Token: 0x06006295 RID: 25237 RVA: 0x0002B6E2 File Offset: 0x000298E2
		public SQLiteDataBase(SQLiteConnection sqliteConnection_1)
		{
			this.sqliteConnection_0 = sqliteConnection_1;
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x00301510 File Offset: 0x002FF710
		public void ExecuteNonQuery(string string_0)
		{
			this.Open();
			using (DbCommand dbCommand = this.sqliteConnection_0.CreateCommand())
			{
				dbCommand.CommandText = string_0;
				dbCommand.ExecuteNonQuery();
			}
			this.Close();
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x00301564 File Offset: 0x002FF764
		public SQLiteDataReader ExecuteReader(string string_0)
		{
			this.Open();
			SQLiteDataReader result;
			using (DbCommand dbCommand = this.sqliteConnection_0.CreateCommand())
			{
				dbCommand.CommandText = string_0;
				result = (SQLiteDataReader)dbCommand.ExecuteReader();
			}
			return result;
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x003015B8 File Offset: 0x002FF7B8
		public DataTable GetDataTable(string string_0)
		{
			this.Open();
			SQLiteDataReader sQLiteDataReader;
			using (DbCommand dbCommand = this.sqliteConnection_0.CreateCommand())
			{
				dbCommand.CommandText = string_0;
				sQLiteDataReader = (SQLiteDataReader)dbCommand.ExecuteReader();
			}
			DataTable dataTable = new DataTable();
			int fieldCount = sQLiteDataReader.FieldCount;
			int num = fieldCount - 1;
			for (int i = 0; i <= num; i++)
			{
				dataTable.Columns.Add(sQLiteDataReader.GetName(i), sQLiteDataReader.GetFieldType(i));
			}
			while (sQLiteDataReader.Read())
			{
				DataRow dataRow = dataTable.NewRow();
				int num2 = fieldCount - 1;
				for (int j = 0; j <= num2; j++)
				{
					dataRow[j] = RuntimeHelpers.GetObjectValue(sQLiteDataReader[j]);
				}
				dataTable.Rows.Add(dataRow);
			}
			sQLiteDataReader.Close();
			sQLiteDataReader = null;
			return dataTable;
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x003016AC File Offset: 0x002FF8AC
		public string ExecuteScalar(string string_0)
		{
			this.Open();
			string result = "";
			using (DbCommand dbCommand = this.sqliteConnection_0.CreateCommand())
			{
				dbCommand.CommandText = string_0;
				result = Conversions.ToString(dbCommand.ExecuteScalar());
			}
			return result;
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x0002B6F1 File Offset: 0x000298F1
		private void Open()
		{
			if (this.sqliteConnection_0.State == ConnectionState.Closed)
			{
				this.sqliteConnection_0.Open();
			}
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x0002B711 File Offset: 0x00029911
		private void Close()
		{
			if (this.sqliteConnection_0.State == ConnectionState.Open)
			{
				this.sqliteConnection_0.Close();
			}
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x00301708 File Offset: 0x002FF908
		public bool method_6(string string_0)
		{
			string string_ = "SELECT count(*) FROM sqlite_master WHERE type='table' AND name='" + string_0 + "'";
			return Conversions.ToInteger(CachedDataBase.ExecuteScalar(this, string_)) != 0;
		}

		// Token: 0x040035D2 RID: 13778
		public SQLiteConnection sqliteConnection_0;
	}
}

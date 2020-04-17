using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;

namespace System.Data.SQLite
{
	// Token: 0x0200143F RID: 5183
	internal sealed class SQLiteKeyReader : IDisposable
	{
		// Token: 0x0600B21B RID: 45595 RVA: 0x004EF2A4 File Offset: 0x004ED4A4
		internal SQLiteKeyReader(SQLiteConnection cnn, SQLiteDataReader reader, SQLiteStatement stmt)
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			Dictionary<string, List<string>> dictionary2 = new Dictionary<string, List<string>>();
			List<SQLiteKeyReader.KeyInfo> list = new List<SQLiteKeyReader.KeyInfo>();
			this._stmt = stmt;
			using (DataTable schema = cnn.GetSchema("Catalogs"))
			{
				foreach (DataRow dataRow in schema.Rows)
				{
					dictionary.Add((string)dataRow["CATALOG_NAME"], Convert.ToInt32(dataRow["ID"], CultureInfo.InvariantCulture));
				}
			}
			using (DataTable schemaTable = reader.GetSchemaTable(false, false))
			{
				foreach (DataRow dataRow2 in schemaTable.Rows)
				{
					if (dataRow2[SchemaTableOptionalColumn.BaseCatalogName] != DBNull.Value)
					{
						string key = (string)dataRow2[SchemaTableOptionalColumn.BaseCatalogName];
						string item = (string)dataRow2[SchemaTableColumn.BaseTableName];
						List<string> list2;
						if (!dictionary2.ContainsKey(key))
						{
							list2 = new List<string>();
							dictionary2.Add(key, list2);
						}
						else
						{
							list2 = dictionary2[key];
						}
						if (!list2.Contains(item))
						{
							list2.Add(item);
						}
					}
				}
				foreach (KeyValuePair<string, List<string>> current in dictionary2)
				{
					for (int i = 0; i < current.Value.Count; i++)
					{
						string text = current.Value[i];
						DataRow dataRow3 = null;
						using (DataTable schema2 = cnn.GetSchema("Indexes", new string[]
						{
							current.Key,
							null,
							text
						}))
						{
							int num = 0;
							while (num < 2 && dataRow3 == null)
							{
								foreach (DataRow dataRow4 in schema2.Rows)
								{
									if (num != 0 || !(bool)dataRow4["PRIMARY_KEY"])
									{
										if (num != 1 || !(bool)dataRow4["UNIQUE"])
										{
											continue;
										}
										dataRow3 = dataRow4;
									}
									else
									{
										dataRow3 = dataRow4;
									}
									break;
								}
								num++;
							}
							if (dataRow3 == null)
							{
								current.Value.RemoveAt(i);
								i--;
							}
							else
							{
								using (DataTable schema3 = cnn.GetSchema("Tables", new string[]
								{
									current.Key,
									null,
									text
								}))
								{
									int database = dictionary[current.Key];
									int rootPage = Convert.ToInt32(schema3.Rows[0]["TABLE_ROOTPAGE"], CultureInfo.InvariantCulture);
									int cursorForTable = stmt._sql.GetCursorForTable(stmt, database, rootPage);
									using (DataTable schema4 = cnn.GetSchema("IndexColumns", new string[]
									{
										current.Key,
										null,
										text,
										(string)dataRow3["INDEX_NAME"]
									}))
									{
										SQLiteKeyReader.KeyQuery query = null;
										List<string> list3 = new List<string>();
										for (int j = 0; j < schema4.Rows.Count; j++)
										{
											bool flag = true;
											foreach (DataRow dataRow5 in schemaTable.Rows)
											{
												if (!dataRow5.IsNull(SchemaTableColumn.BaseColumnName) && (string)dataRow5[SchemaTableColumn.BaseColumnName] == (string)schema4.Rows[j]["COLUMN_NAME"] && (string)dataRow5[SchemaTableColumn.BaseTableName] == text && (string)dataRow5[SchemaTableOptionalColumn.BaseCatalogName] == current.Key)
												{
													schema4.Rows.RemoveAt(j);
													j--;
													flag = false;
													break;
												}
											}
											if (flag)
											{
												list3.Add((string)schema4.Rows[j]["COLUMN_NAME"]);
											}
										}
										if ((string)dataRow3["INDEX_NAME"] != "sqlite_master_PK_" + text && list3.Count > 0)
										{
											string[] array = new string[list3.Count];
											list3.CopyTo(array);
											query = new SQLiteKeyReader.KeyQuery(cnn, current.Key, text, array);
										}
										for (int k = 0; k < schema4.Rows.Count; k++)
										{
											string columnName = (string)schema4.Rows[k]["COLUMN_NAME"];
											list.Add(new SQLiteKeyReader.KeyInfo
											{
												rootPage = rootPage,
												cursor = cursorForTable,
												database = database,
												databaseName = current.Key,
												tableName = text,
												columnName = columnName,
												query = query,
												column = k
											});
										}
									}
								}
							}
						}
					}
				}
			}
			this._keyInfo = new SQLiteKeyReader.KeyInfo[list.Count];
			list.CopyTo(this._keyInfo);
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x0600B21C RID: 45596 RVA: 0x000549F4 File Offset: 0x00052BF4
		internal int Count
		{
			get
			{
				if (this._keyInfo != null)
				{
					return this._keyInfo.Length;
				}
				return 0;
			}
		}

		// Token: 0x0600B21D RID: 45597 RVA: 0x00054A08 File Offset: 0x00052C08
		internal void Sync(int i)
		{
			this.Sync();
			if (this._keyInfo[i].cursor == -1)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x0600B21E RID: 45598 RVA: 0x004EF960 File Offset: 0x004EDB60
		internal void Sync()
		{
			if (this._isValid)
			{
				return;
			}
			SQLiteKeyReader.KeyQuery keyQuery = null;
			for (int i = 0; i < this._keyInfo.Length; i++)
			{
				if (this._keyInfo[i].query == null || this._keyInfo[i].query != keyQuery)
				{
					keyQuery = this._keyInfo[i].query;
					if (keyQuery != null)
					{
						keyQuery.Sync(this._stmt._sql.GetRowIdForCursor(this._stmt, this._keyInfo[i].cursor));
					}
				}
			}
			this._isValid = true;
		}

		// Token: 0x0600B21F RID: 45599 RVA: 0x004EF9FC File Offset: 0x004EDBFC
		internal void Reset()
		{
			this._isValid = false;
			if (this._keyInfo == null)
			{
				return;
			}
			for (int i = 0; i < this._keyInfo.Length; i++)
			{
				if (this._keyInfo[i].query != null)
				{
					this._keyInfo[i].query.IsValid = false;
				}
			}
		}

		// Token: 0x0600B220 RID: 45600 RVA: 0x004EFA58 File Offset: 0x004EDC58
		public void Dispose()
		{
			this._stmt = null;
			if (this._keyInfo == null)
			{
				return;
			}
			for (int i = 0; i < this._keyInfo.Length; i++)
			{
				if (this._keyInfo[i].query != null)
				{
					this._keyInfo[i].query.Dispose();
				}
			}
			this._keyInfo = null;
		}

		// Token: 0x0600B221 RID: 45601 RVA: 0x004EFAB8 File Offset: 0x004EDCB8
		internal string GetDataTypeName(int i)
		{
			this.Sync();
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetDataTypeName(this._keyInfo[i].column);
			}
			return "integer";
		}

		// Token: 0x0600B222 RID: 45602 RVA: 0x004EFB10 File Offset: 0x004EDD10
		internal Type GetFieldType(int i)
		{
			this.Sync();
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetFieldType(this._keyInfo[i].column);
			}
			return typeof(long);
		}

		// Token: 0x0600B223 RID: 45603 RVA: 0x00054A2A File Offset: 0x00052C2A
		internal string GetName(int i)
		{
			return this._keyInfo[i].columnName;
		}

		// Token: 0x0600B224 RID: 45604 RVA: 0x004EFB70 File Offset: 0x004EDD70
		internal int GetOrdinal(string name)
		{
			for (int i = 0; i < this._keyInfo.Length; i++)
			{
				if (string.Compare(name, this._keyInfo[i].columnName, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600B225 RID: 45605 RVA: 0x004EFBB0 File Offset: 0x004EDDB0
		internal bool GetBoolean(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query == null)
			{
				throw new InvalidCastException();
			}
			return this._keyInfo[i].query._reader.GetBoolean(this._keyInfo[i].column);
		}

		// Token: 0x0600B226 RID: 45606 RVA: 0x004EFC0C File Offset: 0x004EDE0C
		internal byte GetByte(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query == null)
			{
				throw new InvalidCastException();
			}
			return this._keyInfo[i].query._reader.GetByte(this._keyInfo[i].column);
		}

		// Token: 0x0600B227 RID: 45607 RVA: 0x004EFC68 File Offset: 0x004EDE68
		internal long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
		{
			this.Sync(i);
			if (this._keyInfo[i].query == null)
			{
				throw new InvalidCastException();
			}
			return this._keyInfo[i].query._reader.GetBytes(this._keyInfo[i].column, fieldOffset, buffer, bufferoffset, length);
		}

		// Token: 0x0600B228 RID: 45608 RVA: 0x004EFCC8 File Offset: 0x004EDEC8
		internal char GetChar(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query == null)
			{
				throw new InvalidCastException();
			}
			return this._keyInfo[i].query._reader.GetChar(this._keyInfo[i].column);
		}

		// Token: 0x0600B229 RID: 45609 RVA: 0x004EFD24 File Offset: 0x004EDF24
		internal long GetChars(int i, long fieldOffset, char[] buffer, int bufferoffset, int length)
		{
			this.Sync(i);
			if (this._keyInfo[i].query == null)
			{
				throw new InvalidCastException();
			}
			return this._keyInfo[i].query._reader.GetChars(this._keyInfo[i].column, fieldOffset, buffer, bufferoffset, length);
		}

		// Token: 0x0600B22A RID: 45610 RVA: 0x004EFD84 File Offset: 0x004EDF84
		internal DateTime GetDateTime(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query == null)
			{
				throw new InvalidCastException();
			}
			return this._keyInfo[i].query._reader.GetDateTime(this._keyInfo[i].column);
		}

		// Token: 0x0600B22B RID: 45611 RVA: 0x004EFDE0 File Offset: 0x004EDFE0
		internal decimal GetDecimal(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query == null)
			{
				throw new InvalidCastException();
			}
			return this._keyInfo[i].query._reader.GetDecimal(this._keyInfo[i].column);
		}

		// Token: 0x0600B22C RID: 45612 RVA: 0x004EFE3C File Offset: 0x004EE03C
		internal double GetDouble(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query == null)
			{
				throw new InvalidCastException();
			}
			return this._keyInfo[i].query._reader.GetDouble(this._keyInfo[i].column);
		}

		// Token: 0x0600B22D RID: 45613 RVA: 0x004EFE98 File Offset: 0x004EE098
		internal float GetFloat(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query == null)
			{
				throw new InvalidCastException();
			}
			return this._keyInfo[i].query._reader.GetFloat(this._keyInfo[i].column);
		}

		// Token: 0x0600B22E RID: 45614 RVA: 0x004EFEF4 File Offset: 0x004EE0F4
		internal Guid GetGuid(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query == null)
			{
				throw new InvalidCastException();
			}
			return this._keyInfo[i].query._reader.GetGuid(this._keyInfo[i].column);
		}

		// Token: 0x0600B22F RID: 45615 RVA: 0x004EFF50 File Offset: 0x004EE150
		internal short GetInt16(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetInt16(this._keyInfo[i].column);
			}
			long rowIdForCursor = this._stmt._sql.GetRowIdForCursor(this._stmt, this._keyInfo[i].cursor);
			if (rowIdForCursor == 0L)
			{
				throw new InvalidCastException();
			}
			return Convert.ToInt16(rowIdForCursor);
		}

		// Token: 0x0600B230 RID: 45616 RVA: 0x004EFFE4 File Offset: 0x004EE1E4
		internal int GetInt32(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetInt32(this._keyInfo[i].column);
			}
			long rowIdForCursor = this._stmt._sql.GetRowIdForCursor(this._stmt, this._keyInfo[i].cursor);
			if (rowIdForCursor == 0L)
			{
				throw new InvalidCastException();
			}
			return Convert.ToInt32(rowIdForCursor);
		}

		// Token: 0x0600B231 RID: 45617 RVA: 0x004F0078 File Offset: 0x004EE278
		internal long GetInt64(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetInt64(this._keyInfo[i].column);
			}
			long rowIdForCursor = this._stmt._sql.GetRowIdForCursor(this._stmt, this._keyInfo[i].cursor);
			if (rowIdForCursor == 0L)
			{
				throw new InvalidCastException();
			}
			return Convert.ToInt64(rowIdForCursor);
		}

		// Token: 0x0600B232 RID: 45618 RVA: 0x004F010C File Offset: 0x004EE30C
		internal string GetString(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query == null)
			{
				throw new InvalidCastException();
			}
			return this._keyInfo[i].query._reader.GetString(this._keyInfo[i].column);
		}

		// Token: 0x0600B233 RID: 45619 RVA: 0x004F0168 File Offset: 0x004EE368
		internal object GetValue(int i)
		{
			if (this._keyInfo[i].cursor == -1)
			{
				return DBNull.Value;
			}
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetValue(this._keyInfo[i].column);
			}
			if (this.IsDBNull(i))
			{
				return DBNull.Value;
			}
			return this.GetInt64(i);
		}

		// Token: 0x0600B234 RID: 45620 RVA: 0x004F01F4 File Offset: 0x004EE3F4
		internal bool IsDBNull(int i)
		{
			if (this._keyInfo[i].cursor == -1)
			{
				return true;
			}
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.IsDBNull(this._keyInfo[i].column);
			}
			return this._stmt._sql.GetRowIdForCursor(this._stmt, this._keyInfo[i].cursor) == 0L;
		}

		// Token: 0x0600B235 RID: 45621 RVA: 0x004F0290 File Offset: 0x004EE490
		internal void AppendSchemaTable(DataTable tbl)
		{
			SQLiteKeyReader.KeyQuery keyQuery = null;
			for (int i = 0; i < this._keyInfo.Length; i++)
			{
				if (this._keyInfo[i].query == null || this._keyInfo[i].query != keyQuery)
				{
					keyQuery = this._keyInfo[i].query;
					if (keyQuery == null)
					{
						DataRow dataRow = tbl.NewRow();
						dataRow[SchemaTableColumn.ColumnName] = this._keyInfo[i].columnName;
						dataRow[SchemaTableColumn.ColumnOrdinal] = tbl.Rows.Count;
						dataRow[SchemaTableColumn.ColumnSize] = 8;
						dataRow[SchemaTableColumn.NumericPrecision] = 255;
						dataRow[SchemaTableColumn.NumericScale] = 255;
						dataRow[SchemaTableColumn.ProviderType] = DbType.Int64;
						dataRow[SchemaTableColumn.IsLong] = false;
						dataRow[SchemaTableColumn.AllowDBNull] = false;
						dataRow[SchemaTableOptionalColumn.IsReadOnly] = false;
						dataRow[SchemaTableOptionalColumn.IsRowVersion] = false;
						dataRow[SchemaTableColumn.IsUnique] = false;
						dataRow[SchemaTableColumn.IsKey] = true;
						dataRow[SchemaTableColumn.DataType] = typeof(long);
						dataRow[SchemaTableOptionalColumn.IsHidden] = true;
						dataRow[SchemaTableColumn.BaseColumnName] = this._keyInfo[i].columnName;
						dataRow[SchemaTableColumn.IsExpression] = false;
						dataRow[SchemaTableColumn.IsAliased] = false;
						dataRow[SchemaTableColumn.BaseTableName] = this._keyInfo[i].tableName;
						dataRow[SchemaTableOptionalColumn.BaseCatalogName] = this._keyInfo[i].databaseName;
						dataRow[SchemaTableOptionalColumn.IsAutoIncrement] = true;
						dataRow["DataTypeName"] = "integer";
						tbl.Rows.Add(dataRow);
					}
					else
					{
						keyQuery.Sync(0L);
						using (DataTable schemaTable = keyQuery._reader.GetSchemaTable())
						{
							foreach (DataRow dataRow2 in schemaTable.Rows)
							{
								object[] itemArray = dataRow2.ItemArray;
								DataRow dataRow3 = tbl.Rows.Add(itemArray);
								dataRow3[SchemaTableOptionalColumn.IsHidden] = true;
								dataRow3[SchemaTableColumn.ColumnOrdinal] = tbl.Rows.Count - 1;
							}
						}
					}
				}
			}
		}

		// Token: 0x04005E3D RID: 24125
		private SQLiteKeyReader.KeyInfo[] _keyInfo;

		// Token: 0x04005E3E RID: 24126
		private SQLiteStatement _stmt;

		// Token: 0x04005E3F RID: 24127
		private bool _isValid;

		// Token: 0x02001440 RID: 5184
		private struct KeyInfo
		{
			// Token: 0x04005E40 RID: 24128
			internal string databaseName;

			// Token: 0x04005E41 RID: 24129
			internal string tableName;

			// Token: 0x04005E42 RID: 24130
			internal string columnName;

			// Token: 0x04005E43 RID: 24131
			internal int database;

			// Token: 0x04005E44 RID: 24132
			internal int rootPage;

			// Token: 0x04005E45 RID: 24133
			internal int cursor;

			// Token: 0x04005E46 RID: 24134
			internal SQLiteKeyReader.KeyQuery query;

			// Token: 0x04005E47 RID: 24135
			internal int column;
		}

		// Token: 0x02001441 RID: 5185
		private sealed class KeyQuery : IDisposable
		{
			// Token: 0x0600B236 RID: 45622 RVA: 0x004F0584 File Offset: 0x004EE784
			internal KeyQuery(SQLiteConnection cnn, string database, string table, params string[] columns)
			{
				using (SQLiteCommandBuilder sQLiteCommandBuilder = new SQLiteCommandBuilder())
				{
					this._command = cnn.CreateCommand();
					for (int i = 0; i < columns.Length; i++)
					{
						columns[i] = sQLiteCommandBuilder.QuoteIdentifier(columns[i]);
					}
				}
				this._command.CommandText = string.Format(CultureInfo.InvariantCulture, "SELECT {0} FROM [{1}].[{2}] WHERE ROWID = ?", new object[]
				{
					string.Join(",", columns),
					database,
					table
				});
				this._command.Parameters.AddWithValue(null, 0L);
			}

			// Token: 0x17000D53 RID: 3411
			// (set) Token: 0x0600B237 RID: 45623 RVA: 0x00054A3D File Offset: 0x00052C3D
			internal bool IsValid
			{
				set
				{
					if (value)
					{
						throw new ArgumentException();
					}
					if (this._reader != null)
					{
						this._reader.Dispose();
						this._reader = null;
					}
				}
			}

			// Token: 0x0600B238 RID: 45624 RVA: 0x004F063C File Offset: 0x004EE83C
			internal void Sync(long rowid)
			{
				this.IsValid = false;
				this._command.Parameters[0].Value = rowid;
				this._reader = this._command.ExecuteReader();
				this._reader.Read();
			}

			// Token: 0x0600B239 RID: 45625 RVA: 0x00054A62 File Offset: 0x00052C62
			public void Dispose()
			{
				this.IsValid = false;
				if (this._command != null)
				{
					this._command.Dispose();
				}
				this._command = null;
			}

			// Token: 0x04005E48 RID: 24136
			private SQLiteCommand _command;

			// Token: 0x04005E49 RID: 24137
			internal SQLiteDataReader _reader;
		}
	}
}

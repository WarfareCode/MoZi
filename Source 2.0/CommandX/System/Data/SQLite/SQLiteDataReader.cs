using System;
using System.Collections;
using System.Data.Common;
using System.Globalization;

namespace System.Data.SQLite
{
	// Token: 0x0200143B RID: 5179
	public sealed class SQLiteDataReader : DbDataReader
	{
		// Token: 0x0600B1B1 RID: 45489 RVA: 0x004ED660 File Offset: 0x004EB860
		internal SQLiteDataReader(SQLiteCommand cmd, CommandBehavior behave)
		{
			this._command = cmd;
			this._version = this._command.Connection._version;
			this._commandBehavior = behave;
			this._activeStatementIndex = -1;
			this._rowsAffected = -1;
			if (this._command != null)
			{
				this.NextResult();
			}
		}

		// Token: 0x0600B1B2 RID: 45490 RVA: 0x000545BC File Offset: 0x000527BC
		internal void Cancel()
		{
			this._version = 0L;
		}

		// Token: 0x0600B1B3 RID: 45491 RVA: 0x004ED6B4 File Offset: 0x004EB8B4
		public override void Close()
		{
			try
			{
				if (this._command != null)
				{
					try
					{
						try
						{
							if (this._version != 0L)
							{
								try
								{
									while (this.NextResult())
									{
									}
								}
								catch (SQLiteException)
								{
								}
							}
							this._command.ClearDataReader();
						}
						finally
						{
							if ((this._commandBehavior & CommandBehavior.CloseConnection) != CommandBehavior.Default && this._command.Connection != null)
							{
								this._command.Connection.Close();
							}
						}
					}
					finally
					{
						if (this._disposeCommand)
						{
							this._command.Dispose();
						}
					}
				}
				this._command = null;
				this._activeStatement = null;
				this._fieldTypeArray = null;
			}
			finally
			{
				if (this._keyInfo != null)
				{
					this._keyInfo.Dispose();
					this._keyInfo = null;
				}
			}
		}

		// Token: 0x0600B1B4 RID: 45492 RVA: 0x004ED79C File Offset: 0x004EB99C
		private void CheckClosed()
		{
			if (this._command == null)
			{
				throw new InvalidOperationException("DataReader has been closed");
			}
			if (this._version == 0L)
			{
				throw new SQLiteException(4, "Execution was aborted by the user");
			}
			if (this._command.Connection.State != ConnectionState.Open || this._command.Connection._version != this._version)
			{
				throw new InvalidOperationException("Connection was closed, statement was terminated");
			}
		}

		// Token: 0x0600B1B5 RID: 45493 RVA: 0x000545CD File Offset: 0x000527CD
		private void CheckValidRow()
		{
			if (this._readingState != 0)
			{
				throw new InvalidOperationException("No current row");
			}
		}

		// Token: 0x0600B1B6 RID: 45494 RVA: 0x000545E2 File Offset: 0x000527E2
		public override IEnumerator GetEnumerator()
		{
			return new DbEnumerator(this, (this._commandBehavior & CommandBehavior.CloseConnection) == CommandBehavior.CloseConnection);
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x0600B1B7 RID: 45495 RVA: 0x000545F7 File Offset: 0x000527F7
		public override int Depth
		{
			get
			{
				this.CheckClosed();
				return 0;
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x0600B1B8 RID: 45496 RVA: 0x00054600 File Offset: 0x00052800
		public override int FieldCount
		{
			get
			{
				this.CheckClosed();
				if (this._keyInfo == null)
				{
					return this._fieldCount;
				}
				return this._fieldCount + this._keyInfo.Count;
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x0600B1B9 RID: 45497 RVA: 0x00054629 File Offset: 0x00052829
		public override int VisibleFieldCount
		{
			get
			{
				this.CheckClosed();
				return this._fieldCount;
			}
		}

		// Token: 0x0600B1BA RID: 45498 RVA: 0x004ED810 File Offset: 0x004EBA10
		private TypeAffinity VerifyType(int i, DbType typ)
		{
			this.CheckClosed();
			this.CheckValidRow();
			TypeAffinity affinity = this.GetSQLiteType(i).Affinity;
			switch (affinity)
			{
			case TypeAffinity.Int64:
				if (typ == DbType.Int16)
				{
					return affinity;
				}
				if (typ == DbType.Int32)
				{
					return affinity;
				}
				if (typ == DbType.Int64)
				{
					return affinity;
				}
				if (typ == DbType.Boolean)
				{
					return affinity;
				}
				if (typ == DbType.Byte)
				{
					return affinity;
				}
				if (typ == DbType.DateTime)
				{
					return affinity;
				}
				if (typ == DbType.Single)
				{
					return affinity;
				}
				if (typ == DbType.Double)
				{
					return affinity;
				}
				if (typ == DbType.Decimal)
				{
					return affinity;
				}
				break;
			case TypeAffinity.Double:
				if (typ == DbType.Single)
				{
					return affinity;
				}
				if (typ == DbType.Double)
				{
					return affinity;
				}
				if (typ == DbType.Decimal)
				{
					return affinity;
				}
				if (typ == DbType.DateTime)
				{
					return affinity;
				}
				break;
			case TypeAffinity.Text:
				if (typ == DbType.SByte)
				{
					return affinity;
				}
				if (typ == DbType.String)
				{
					return affinity;
				}
				if (typ == DbType.SByte)
				{
					return affinity;
				}
				if (typ == DbType.Guid)
				{
					return affinity;
				}
				if (typ == DbType.DateTime)
				{
					return affinity;
				}
				if (typ == DbType.Decimal)
				{
					return affinity;
				}
				break;
			case TypeAffinity.Blob:
				if (typ == DbType.Guid)
				{
					return affinity;
				}
				if (typ == DbType.String)
				{
					return affinity;
				}
				if (typ == DbType.Binary)
				{
					return affinity;
				}
				break;
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600B1BB RID: 45499 RVA: 0x004ED8EC File Offset: 0x004EBAEC
		public override bool GetBoolean(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetBoolean(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, DbType.Boolean);
			return Convert.ToBoolean(this.GetValue(i), CultureInfo.CurrentCulture);
		}

		// Token: 0x0600B1BC RID: 45500 RVA: 0x004ED938 File Offset: 0x004EBB38
		public override byte GetByte(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetByte(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, DbType.Byte);
			return Convert.ToByte(this._activeStatement._sql.GetInt32(this._activeStatement, i));
		}

		// Token: 0x0600B1BD RID: 45501 RVA: 0x004ED990 File Offset: 0x004EBB90
		public override long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetBytes(i - this.VisibleFieldCount, fieldOffset, buffer, bufferoffset, length);
			}
			this.VerifyType(i, DbType.Binary);
			return this._activeStatement._sql.GetBytes(this._activeStatement, i, (int)fieldOffset, buffer, bufferoffset, length);
		}

		// Token: 0x0600B1BE RID: 45502 RVA: 0x004ED9F0 File Offset: 0x004EBBF0
		public override char GetChar(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetChar(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, DbType.SByte);
			return Convert.ToChar(this._activeStatement._sql.GetInt32(this._activeStatement, i));
		}

		// Token: 0x0600B1BF RID: 45503 RVA: 0x004EDA48 File Offset: 0x004EBC48
		public override long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetChars(i - this.VisibleFieldCount, fieldoffset, buffer, bufferoffset, length);
			}
			this.VerifyType(i, DbType.String);
			return this._activeStatement._sql.GetChars(this._activeStatement, i, (int)fieldoffset, buffer, bufferoffset, length);
		}

		// Token: 0x0600B1C0 RID: 45504 RVA: 0x004EDAA8 File Offset: 0x004EBCA8
		public override string GetDataTypeName(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetDataTypeName(i - this.VisibleFieldCount);
			}
			SQLiteType sQLiteType = this.GetSQLiteType(i);
			if (sQLiteType.Type == DbType.Object)
			{
				return SQLiteConvert.SQLiteTypeToType(sQLiteType).Name;
			}
			return this._activeStatement._sql.ColumnType(this._activeStatement, i, out sQLiteType.Affinity);
		}

		// Token: 0x0600B1C1 RID: 45505 RVA: 0x004EDB18 File Offset: 0x004EBD18
		public override DateTime GetDateTime(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetDateTime(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, DbType.DateTime);
			return this._activeStatement._sql.GetDateTime(this._activeStatement, i);
		}

		// Token: 0x0600B1C2 RID: 45506 RVA: 0x004EDB6C File Offset: 0x004EBD6C
		public override decimal GetDecimal(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetDecimal(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, DbType.Decimal);
			return decimal.Parse(this._activeStatement._sql.GetText(this._activeStatement, i), NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, CultureInfo.InvariantCulture);
		}

		// Token: 0x0600B1C3 RID: 45507 RVA: 0x004EDBD0 File Offset: 0x004EBDD0
		public override double GetDouble(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetDouble(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, DbType.Double);
			return this._activeStatement._sql.GetDouble(this._activeStatement, i);
		}

		// Token: 0x0600B1C4 RID: 45508 RVA: 0x00054637 File Offset: 0x00052837
		public override Type GetFieldType(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetFieldType(i - this.VisibleFieldCount);
			}
			return SQLiteConvert.SQLiteTypeToType(this.GetSQLiteType(i));
		}

		// Token: 0x0600B1C5 RID: 45509 RVA: 0x004EDC24 File Offset: 0x004EBE24
		public override float GetFloat(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetFloat(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, DbType.Single);
			return Convert.ToSingle(this._activeStatement._sql.GetDouble(this._activeStatement, i));
		}

		// Token: 0x0600B1C6 RID: 45510 RVA: 0x004EDC7C File Offset: 0x004EBE7C
		public override Guid GetGuid(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetGuid(i - this.VisibleFieldCount);
			}
			TypeAffinity typeAffinity = this.VerifyType(i, DbType.Guid);
			if (typeAffinity == TypeAffinity.Blob)
			{
				byte[] array = new byte[16];
				this._activeStatement._sql.GetBytes(this._activeStatement, i, 0, array, 0, 16);
				return new Guid(array);
			}
			return new Guid(this._activeStatement._sql.GetText(this._activeStatement, i));
		}

		// Token: 0x0600B1C7 RID: 45511 RVA: 0x004EDD04 File Offset: 0x004EBF04
		public override short GetInt16(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetInt16(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, DbType.Int16);
			return Convert.ToInt16(this._activeStatement._sql.GetInt32(this._activeStatement, i));
		}

		// Token: 0x0600B1C8 RID: 45512 RVA: 0x004EDD5C File Offset: 0x004EBF5C
		public override int GetInt32(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetInt32(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, DbType.Int32);
			return this._activeStatement._sql.GetInt32(this._activeStatement, i);
		}

		// Token: 0x0600B1C9 RID: 45513 RVA: 0x004EDDB0 File Offset: 0x004EBFB0
		public override long GetInt64(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetInt64(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, DbType.Int64);
			return this._activeStatement._sql.GetInt64(this._activeStatement, i);
		}

		// Token: 0x0600B1CA RID: 45514 RVA: 0x0005466A File Offset: 0x0005286A
		public override string GetName(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetName(i - this.VisibleFieldCount);
			}
			return this._activeStatement._sql.ColumnName(this._activeStatement, i);
		}

		// Token: 0x0600B1CB RID: 45515 RVA: 0x004EDE04 File Offset: 0x004EC004
		public override int GetOrdinal(string name)
		{
			this.CheckClosed();
			int num = this._activeStatement._sql.ColumnIndex(this._activeStatement, name);
			if (num == -1 && this._keyInfo != null)
			{
				num = this._keyInfo.GetOrdinal(name);
				if (num > -1)
				{
					num += this.VisibleFieldCount;
				}
			}
			return num;
		}

		// Token: 0x0600B1CC RID: 45516 RVA: 0x000546A8 File Offset: 0x000528A8
		public override DataTable GetSchemaTable()
		{
			return this.GetSchemaTable(true, false);
		}

		// Token: 0x0600B1CD RID: 45517 RVA: 0x004EDE58 File Offset: 0x004EC058
		internal DataTable GetSchemaTable(bool wantUniqueInfo, bool wantDefaultValue)
		{
			this.CheckClosed();
			DataTable dataTable = new DataTable("SchemaTable");
			DataTable dataTable2 = null;
			string b = "";
			string b2 = "";
			string text = "";
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add(SchemaTableColumn.ColumnName, typeof(string));
			dataTable.Columns.Add(SchemaTableColumn.ColumnOrdinal, typeof(int));
			dataTable.Columns.Add(SchemaTableColumn.ColumnSize, typeof(int));
			dataTable.Columns.Add(SchemaTableColumn.NumericPrecision, typeof(short));
			dataTable.Columns.Add(SchemaTableColumn.NumericScale, typeof(short));
			dataTable.Columns.Add(SchemaTableColumn.IsUnique, typeof(bool));
			dataTable.Columns.Add(SchemaTableColumn.IsKey, typeof(bool));
			dataTable.Columns.Add(SchemaTableOptionalColumn.BaseServerName, typeof(string));
			dataTable.Columns.Add(SchemaTableOptionalColumn.BaseCatalogName, typeof(string));
			dataTable.Columns.Add(SchemaTableColumn.BaseColumnName, typeof(string));
			dataTable.Columns.Add(SchemaTableColumn.BaseSchemaName, typeof(string));
			dataTable.Columns.Add(SchemaTableColumn.BaseTableName, typeof(string));
			dataTable.Columns.Add(SchemaTableColumn.DataType, typeof(Type));
			dataTable.Columns.Add(SchemaTableColumn.AllowDBNull, typeof(bool));
			dataTable.Columns.Add(SchemaTableColumn.ProviderType, typeof(int));
			dataTable.Columns.Add(SchemaTableColumn.IsAliased, typeof(bool));
			dataTable.Columns.Add(SchemaTableColumn.IsExpression, typeof(bool));
			dataTable.Columns.Add(SchemaTableOptionalColumn.IsAutoIncrement, typeof(bool));
			dataTable.Columns.Add(SchemaTableOptionalColumn.IsRowVersion, typeof(bool));
			dataTable.Columns.Add(SchemaTableOptionalColumn.IsHidden, typeof(bool));
			dataTable.Columns.Add(SchemaTableColumn.IsLong, typeof(bool));
			dataTable.Columns.Add(SchemaTableOptionalColumn.IsReadOnly, typeof(bool));
			dataTable.Columns.Add(SchemaTableOptionalColumn.ProviderSpecificDataType, typeof(Type));
			dataTable.Columns.Add(SchemaTableOptionalColumn.DefaultValue, typeof(object));
			dataTable.Columns.Add("DataTypeName", typeof(string));
			dataTable.Columns.Add("CollationType", typeof(string));
			dataTable.BeginLoadData();
			for (int i = 0; i < this._fieldCount; i++)
			{
				DataRow dataRow = dataTable.NewRow();
				DbType type = this.GetSQLiteType(i).Type;
				dataRow[SchemaTableColumn.ColumnName] = this.GetName(i);
				dataRow[SchemaTableColumn.ColumnOrdinal] = i;
				dataRow[SchemaTableColumn.ColumnSize] = SQLiteConvert.DbTypeToColumnSize(type);
				dataRow[SchemaTableColumn.NumericPrecision] = SQLiteConvert.DbTypeToNumericPrecision(type);
				dataRow[SchemaTableColumn.NumericScale] = SQLiteConvert.DbTypeToNumericScale(type);
				dataRow[SchemaTableColumn.ProviderType] = this.GetSQLiteType(i).Type;
				dataRow[SchemaTableColumn.IsLong] = false;
				dataRow[SchemaTableColumn.AllowDBNull] = true;
				dataRow[SchemaTableOptionalColumn.IsReadOnly] = false;
				dataRow[SchemaTableOptionalColumn.IsRowVersion] = false;
				dataRow[SchemaTableColumn.IsUnique] = false;
				dataRow[SchemaTableColumn.IsKey] = false;
				dataRow[SchemaTableOptionalColumn.IsAutoIncrement] = false;
				dataRow[SchemaTableColumn.DataType] = this.GetFieldType(i);
				dataRow[SchemaTableOptionalColumn.IsHidden] = false;
				text = this._command.Connection._sql.ColumnOriginalName(this._activeStatement, i);
				if (!string.IsNullOrEmpty(text))
				{
					dataRow[SchemaTableColumn.BaseColumnName] = text;
				}
				dataRow[SchemaTableColumn.IsExpression] = string.IsNullOrEmpty(text);
				dataRow[SchemaTableColumn.IsAliased] = (string.Compare(this.GetName(i), text, StringComparison.OrdinalIgnoreCase) != 0);
				string value = this._command.Connection._sql.ColumnTableName(this._activeStatement, i);
				if (!string.IsNullOrEmpty(value))
				{
					dataRow[SchemaTableColumn.BaseTableName] = value;
				}
				value = this._command.Connection._sql.ColumnDatabaseName(this._activeStatement, i);
				if (!string.IsNullOrEmpty(value))
				{
					dataRow[SchemaTableOptionalColumn.BaseCatalogName] = value;
				}
				string text2 = null;
				if (!string.IsNullOrEmpty(text))
				{
					string value2;
					bool flag;
					bool flag2;
					bool flag3;
					this._command.Connection._sql.ColumnMetaData((string)dataRow[SchemaTableOptionalColumn.BaseCatalogName], (string)dataRow[SchemaTableColumn.BaseTableName], text, out text2, out value2, out flag, out flag2, out flag3);
					if (flag || flag2)
					{
						dataRow[SchemaTableColumn.AllowDBNull] = false;
					}
					dataRow[SchemaTableColumn.IsKey] = flag2;
					dataRow[SchemaTableOptionalColumn.IsAutoIncrement] = flag3;
					dataRow["CollationType"] = value2;
					string[] array = text2.Split(new char[]
					{
						'('
					});
					if (array.Length > 1)
					{
						text2 = array[0];
						array = array[1].Split(new char[]
						{
							')'
						});
						if (array.Length > 1)
						{
							array = array[0].Split(new char[]
							{
								',',
								'.'
							});
							if (this.GetSQLiteType(i).Type != DbType.String)
							{
								if (this.GetSQLiteType(i).Type != DbType.Binary)
								{
									dataRow[SchemaTableColumn.NumericPrecision] = Convert.ToInt32(array[0], CultureInfo.InvariantCulture);
									if (array.Length > 1)
									{
										dataRow[SchemaTableColumn.NumericScale] = Convert.ToInt32(array[1], CultureInfo.InvariantCulture);
										goto IL_681;
									}
									goto IL_681;
								}
							}
							dataRow[SchemaTableColumn.ColumnSize] = Convert.ToInt32(array[0], CultureInfo.InvariantCulture);
						}
					}
					IL_681:
					if (wantDefaultValue)
					{
						using (SQLiteCommand sQLiteCommand = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "PRAGMA [{0}].TABLE_INFO([{1}])", new object[]
						{
							dataRow[SchemaTableOptionalColumn.BaseCatalogName],
							dataRow[SchemaTableColumn.BaseTableName]
						}), this._command.Connection))
						{
							using (DbDataReader dbDataReader = sQLiteCommand.ExecuteReader())
							{
								while (dbDataReader.Read())
								{
									if (string.Compare((string)dataRow[SchemaTableColumn.BaseColumnName], dbDataReader.GetString(1), StringComparison.OrdinalIgnoreCase) == 0)
									{
										if (!dbDataReader.IsDBNull(4))
										{
											dataRow[SchemaTableOptionalColumn.DefaultValue] = dbDataReader[4];
										}
										break;
									}
								}
							}
						}
					}
					if (wantUniqueInfo)
					{
						if ((string)dataRow[SchemaTableOptionalColumn.BaseCatalogName] != b || (string)dataRow[SchemaTableColumn.BaseTableName] != b2)
						{
							b = (string)dataRow[SchemaTableOptionalColumn.BaseCatalogName];
							b2 = (string)dataRow[SchemaTableColumn.BaseTableName];
							DbConnection arg_7DE_0 = this._command.Connection;
							string arg_7DE_1 = "Indexes";
							string[] array2 = new string[4];
							array2[0] = (string)dataRow[SchemaTableOptionalColumn.BaseCatalogName];
							array2[2] = (string)dataRow[SchemaTableColumn.BaseTableName];
							dataTable2 = arg_7DE_0.GetSchema(arg_7DE_1, array2);
						}
						foreach (DataRow dataRow2 in dataTable2.Rows)
						{
							DbConnection arg_85E_0 = this._command.Connection;
							string arg_85E_1 = "IndexColumns";
							string[] array3 = new string[5];
							array3[0] = (string)dataRow[SchemaTableOptionalColumn.BaseCatalogName];
							array3[2] = (string)dataRow[SchemaTableColumn.BaseTableName];
							array3[3] = (string)dataRow2["INDEX_NAME"];
							DataTable schema = arg_85E_0.GetSchema(arg_85E_1, array3);
							foreach (DataRow dataRow3 in schema.Rows)
							{
								if (string.Compare((string)dataRow3["COLUMN_NAME"], text, StringComparison.OrdinalIgnoreCase) == 0)
								{
									if (schema.Rows.Count == 1 && !(bool)dataRow[SchemaTableColumn.AllowDBNull])
									{
										dataRow[SchemaTableColumn.IsUnique] = dataRow2["UNIQUE"];
									}
									if (schema.Rows.Count != 1 || !(bool)dataRow2["PRIMARY_KEY"] || string.IsNullOrEmpty(text2) || string.Compare(text2, "integer", StringComparison.OrdinalIgnoreCase) != 0)
									{
									}
									break;
								}
							}
						}
					}
					if (string.IsNullOrEmpty(text2))
					{
						TypeAffinity typeAffinity;
						text2 = this._activeStatement._sql.ColumnType(this._activeStatement, i, out typeAffinity);
					}
					if (!string.IsNullOrEmpty(text2))
					{
						dataRow["DataTypeName"] = text2;
					}
				}
				dataTable.Rows.Add(dataRow);
			}
			if (this._keyInfo != null)
			{
				this._keyInfo.AppendSchemaTable(dataTable);
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x0600B1CE RID: 45518 RVA: 0x004EE898 File Offset: 0x004ECA98
		public override string GetString(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetString(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, DbType.String);
			return this._activeStatement._sql.GetText(this._activeStatement, i);
		}

		// Token: 0x0600B1CF RID: 45519 RVA: 0x004EE8EC File Offset: 0x004ECAEC
		public override object GetValue(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetValue(i - this.VisibleFieldCount);
			}
			SQLiteType sQLiteType = this.GetSQLiteType(i);
			return this._activeStatement._sql.GetValue(this._activeStatement, i, sQLiteType);
		}

		// Token: 0x0600B1D0 RID: 45520 RVA: 0x004EE940 File Offset: 0x004ECB40
		public override int GetValues(object[] values)
		{
			int num = this.FieldCount;
			if (values.Length < num)
			{
				num = values.Length;
			}
			for (int i = 0; i < num; i++)
			{
				values[i] = this.GetValue(i);
			}
			return num;
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x0600B1D1 RID: 45521 RVA: 0x000546B2 File Offset: 0x000528B2
		public override bool HasRows
		{
			get
			{
				this.CheckClosed();
				return this._readingState != 1;
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x0600B1D2 RID: 45522 RVA: 0x000546C6 File Offset: 0x000528C6
		public override bool IsClosed
		{
			get
			{
				return this._command == null;
			}
		}

		// Token: 0x0600B1D3 RID: 45523 RVA: 0x000546D1 File Offset: 0x000528D1
		public override bool IsDBNull(int i)
		{
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.IsDBNull(i - this.VisibleFieldCount);
			}
			return this._activeStatement._sql.IsNull(this._activeStatement, i);
		}

		// Token: 0x0600B1D4 RID: 45524 RVA: 0x004EE978 File Offset: 0x004ECB78
		public override bool NextResult()
		{
			this.CheckClosed();
			SQLiteStatement sQLiteStatement = null;
			int num;
			while (true)
			{
				if (this._activeStatement != null && sQLiteStatement == null)
				{
					this._activeStatement._sql.Reset(this._activeStatement);
					if ((this._commandBehavior & CommandBehavior.SingleResult) != CommandBehavior.Default)
					{
						break;
					}
				}
				sQLiteStatement = this._command.GetStatement(this._activeStatementIndex + 1);
				if (sQLiteStatement == null)
				{
					return false;
				}
				if (this._readingState < 1)
				{
					this._readingState = 1;
				}
				this._activeStatementIndex++;
				num = sQLiteStatement._sql.ColumnCount(sQLiteStatement);
				if ((this._commandBehavior & CommandBehavior.SchemaOnly) != CommandBehavior.Default && num != 0)
				{
					goto IL_172;
				}
				if (sQLiteStatement._sql.Step(sQLiteStatement))
				{
					goto IL_162;
				}
				if (num != 0)
				{
					goto IL_16B;
				}
				if (this._rowsAffected == -1)
				{
					this._rowsAffected = 0;
				}
				this._rowsAffected += sQLiteStatement._sql.Changes;
				sQLiteStatement._sql.Reset(sQLiteStatement);
			}
			while (true)
			{
				sQLiteStatement = this._command.GetStatement(this._activeStatementIndex + 1);
				if (sQLiteStatement == null)
				{
					break;
				}
				this._activeStatementIndex++;
				sQLiteStatement._sql.Step(sQLiteStatement);
				if (sQLiteStatement._sql.ColumnCount(sQLiteStatement) == 0)
				{
					if (this._rowsAffected == -1)
					{
						this._rowsAffected = 0;
					}
					this._rowsAffected += sQLiteStatement._sql.Changes;
				}
				sQLiteStatement._sql.Reset(sQLiteStatement);
			}
			return false;
			IL_162:
			this._readingState = -1;
			goto IL_172;
			IL_16B:
			this._readingState = 1;
			IL_172:
			this._activeStatement = sQLiteStatement;
			this._fieldCount = num;
			this._fieldTypeArray = null;
			if ((this._commandBehavior & CommandBehavior.KeyInfo) != CommandBehavior.Default)
			{
				this.LoadKeyInfo();
			}
			return true;
		}

		// Token: 0x0600B1D5 RID: 45525 RVA: 0x004EEB20 File Offset: 0x004ECD20
		private SQLiteType GetSQLiteType(int i)
		{
			if (this._fieldTypeArray == null)
			{
				this._fieldTypeArray = new SQLiteType[this.VisibleFieldCount];
			}
			if (this._fieldTypeArray[i] == null)
			{
				this._fieldTypeArray[i] = new SQLiteType();
			}
			SQLiteType sQLiteType = this._fieldTypeArray[i];
			if (sQLiteType.Affinity == TypeAffinity.Uninitialized)
			{
				sQLiteType.Type = SQLiteConvert.TypeNameToDbType(this._activeStatement._sql.ColumnType(this._activeStatement, i, out sQLiteType.Affinity));
			}
			else
			{
				sQLiteType.Affinity = this._activeStatement._sql.ColumnAffinity(this._activeStatement, i);
			}
			return sQLiteType;
		}

		// Token: 0x0600B1D6 RID: 45526 RVA: 0x004EEBB8 File Offset: 0x004ECDB8
		public override bool Read()
		{
			this.CheckClosed();
			if (this._readingState == -1)
			{
				this._readingState = 0;
				return true;
			}
			if (this._readingState == 0)
			{
				if ((this._commandBehavior & CommandBehavior.SingleRow) == CommandBehavior.Default && this._activeStatement._sql.Step(this._activeStatement))
				{
					if (this._keyInfo != null)
					{
						this._keyInfo.Reset();
					}
					return true;
				}
				this._readingState = 1;
			}
			return false;
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x0600B1D7 RID: 45527 RVA: 0x0005470F File Offset: 0x0005290F
		public override int RecordsAffected
		{
			get
			{
				if (this._rowsAffected >= 0)
				{
					return this._rowsAffected;
				}
				return 0;
			}
		}

		// Token: 0x17000D42 RID: 3394
		public override object this[string name]
		{
			get
			{
				return this.GetValue(this.GetOrdinal(name));
			}
		}

		// Token: 0x17000D43 RID: 3395
		public override object this[int i]
		{
			get
			{
				return this.GetValue(i);
			}
		}

		// Token: 0x0600B1DA RID: 45530 RVA: 0x0005473A File Offset: 0x0005293A
		private void LoadKeyInfo()
		{
			if (this._keyInfo != null)
			{
				this._keyInfo.Dispose();
			}
			this._keyInfo = new SQLiteKeyReader(this._command.Connection, this, this._activeStatement);
		}

		// Token: 0x04005E2A RID: 24106
		private SQLiteCommand _command;

		// Token: 0x04005E2B RID: 24107
		private int _activeStatementIndex;

		// Token: 0x04005E2C RID: 24108
		private SQLiteStatement _activeStatement;

		// Token: 0x04005E2D RID: 24109
		private int _readingState;

		// Token: 0x04005E2E RID: 24110
		private int _rowsAffected;

		// Token: 0x04005E2F RID: 24111
		private int _fieldCount;

		// Token: 0x04005E30 RID: 24112
		private SQLiteType[] _fieldTypeArray;

		// Token: 0x04005E31 RID: 24113
		private CommandBehavior _commandBehavior;

		// Token: 0x04005E32 RID: 24114
		internal bool _disposeCommand;

		// Token: 0x04005E33 RID: 24115
		private SQLiteKeyReader _keyInfo;

		// Token: 0x04005E34 RID: 24116
		internal long _version;
	}
}

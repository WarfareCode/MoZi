using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System.Data.SQLite
{
	// Token: 0x02001444 RID: 5188
	internal class SQLite3 : SQLiteBase
	{
		// Token: 0x0600B26B RID: 45675 RVA: 0x00054C06 File Offset: 0x00052E06
		internal SQLite3(SQLiteDateFormats fmt) : base(fmt)
		{
		}

		// Token: 0x0600B26C RID: 45676 RVA: 0x00054C0F File Offset: 0x00052E0F
		protected override void Dispose(bool bDisposing)
		{
			if (bDisposing)
			{
				this.Close();
			}
		}

		// Token: 0x0600B26D RID: 45677 RVA: 0x004F0C24 File Offset: 0x004EEE24
		internal override void Close()
		{
			if (this._sql != null)
			{
				if (this._usePool)
				{
					SQLiteBase.ResetConnection(this._sql);
					SQLiteConnectionPool.Add(this._fileName, this._sql, this._poolVersion);
				}
				else
				{
					this._sql.Dispose();
				}
			}
			this._sql = null;
		}

		// Token: 0x0600B26E RID: 45678 RVA: 0x00054C1A File Offset: 0x00052E1A
		internal override void Cancel()
		{
			UnsafeNativeMethods.sqlite3_interrupt(this._sql);
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x0600B26F RID: 45679 RVA: 0x00053FE8 File Offset: 0x000521E8
		internal override string Version
		{
			get
			{
				return SQLite3.SQLiteVersion;
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x0600B270 RID: 45680 RVA: 0x00054C2C File Offset: 0x00052E2C
		internal static string SQLiteVersion
		{
			get
			{
				return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_libversion(), -1);
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x0600B271 RID: 45681 RVA: 0x00054C39 File Offset: 0x00052E39
		internal override bool AutoCommit
		{
			get
			{
				return SQLiteBase.IsAutocommit(this._sql);
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x0600B272 RID: 45682 RVA: 0x00054C46 File Offset: 0x00052E46
		internal override int Changes
		{
			get
			{
				return UnsafeNativeMethods.sqlite3_changes(this._sql);
			}
		}

		// Token: 0x0600B273 RID: 45683 RVA: 0x004F0C78 File Offset: 0x004EEE78
		internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool)
		{
			if (this._sql != null)
			{
				return;
			}
			this._usePool = usePool;
			if (usePool)
			{
				this._fileName = strFilename;
				this._sql = SQLiteConnectionPool.Remove(strFilename, maxPoolSize, out this._poolVersion);
			}
			if (this._sql == null)
			{
				IntPtr db;
				int num = UnsafeNativeMethods.sqlite3_open_interop(SQLiteConvert.ToUTF8(strFilename), (int)flags, out db);
				if (num > 0)
				{
					throw new SQLiteException(num, null);
				}
				this._sql = db;
			}
			this._functionsArray = SQLiteFunction.BindFunctions(this);
			this.SetTimeout(0);
		}

		// Token: 0x0600B274 RID: 45684 RVA: 0x00054C58 File Offset: 0x00052E58
		internal override void ClearPool()
		{
			SQLiteConnectionPool.ClearPool(this._fileName);
		}

		// Token: 0x0600B275 RID: 45685 RVA: 0x004F0CF8 File Offset: 0x004EEEF8
		internal override void SetTimeout(int nTimeoutMS)
		{
			int num = UnsafeNativeMethods.sqlite3_busy_timeout(this._sql, nTimeoutMS);
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
		}

		// Token: 0x0600B276 RID: 45686 RVA: 0x004F0D28 File Offset: 0x004EEF28
		internal override bool Step(SQLiteStatement stmt)
		{
			Random random = null;
			uint tickCount = (uint)Environment.TickCount;
			uint num = (uint)(stmt._command._commandTimeout * 1000);
			int num2;
			int num3;
			while (true)
			{
				num2 = UnsafeNativeMethods.sqlite3_step(stmt._sqlite_stmt);
				if (num2 == 100)
				{
					return true;
				}
				if (num2 == 101)
				{
					break;
				}
				if (num2 > 0)
				{
					num3 = this.Reset(stmt);
					if (num3 == 0)
					{
						goto IL_80;
					}
					if ((num3 == 6 || num3 == 5) && stmt._command != null)
					{
						if (random == null)
						{
							random = new Random();
						}
						if (Environment.TickCount - (int)tickCount > (int)num)
						{
							goto IL_8D;
						}
						Thread.Sleep(random.Next(1, 150));
					}
				}
			}
			return false;
			IL_80:
			throw new SQLiteException(num2, this.SQLiteLastError());
			IL_8D:
			throw new SQLiteException(num3, this.SQLiteLastError());
		}

		// Token: 0x0600B277 RID: 45687 RVA: 0x004F0DD0 File Offset: 0x004EEFD0
		internal override int Reset(SQLiteStatement stmt)
		{
			int num = UnsafeNativeMethods.sqlite3_reset_interop(stmt._sqlite_stmt);
			if (num == 17)
			{
				string text;
				using (SQLiteStatement sQLiteStatement = this.Prepare(null, stmt._sqlStatement, null, (uint)(stmt._command._commandTimeout * 1000), out text))
				{
					stmt._sqlite_stmt.Dispose();
					stmt._sqlite_stmt = sQLiteStatement._sqlite_stmt;
					sQLiteStatement._sqlite_stmt = null;
					stmt.BindParameters();
				}
				return -1;
			}
			if (num != 6)
			{
				if (num != 5)
				{
					if (num > 0)
					{
						throw new SQLiteException(num, this.SQLiteLastError());
					}
					return 0;
				}
			}
			return num;
		}

		// Token: 0x0600B278 RID: 45688 RVA: 0x00054C65 File Offset: 0x00052E65
		internal override string SQLiteLastError()
		{
			return SQLiteBase.SQLiteLastError(this._sql);
		}

		// Token: 0x0600B279 RID: 45689 RVA: 0x004F0E78 File Offset: 0x004EF078
		internal override SQLiteStatement Prepare(SQLiteConnection cnn, string strSql, SQLiteStatement previous, uint timeoutMS, out string strRemain)
		{
			IntPtr zero = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			int nativestringlen = 0;
			int num = 17;
			int num2 = 0;
			byte[] array = SQLiteConvert.ToUTF8(strSql);
			SQLiteStatement sQLiteStatement = null;
			Random random = null;
			uint tickCount = (uint)Environment.TickCount;
			GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			IntPtr pSql = gCHandle.AddrOfPinnedObject();
			SQLiteStatement result;
			try
			{
				while (true)
				{
					if (num != 17 && num != 6)
					{
						if (num != 5)
						{
							goto IL_10C;
						}
					}
					if (num2 >= 3)
					{
						goto IL_10C;
					}
					num = UnsafeNativeMethods.sqlite3_prepare_interop(this._sql, pSql, array.Length - 1, out zero, out zero2, out nativestringlen);
					if (num == 17)
					{
						num2++;
					}
					else if (num == 1)
					{
						if (string.Compare(this.SQLiteLastError(), "near \"TYPES\": syntax error", StringComparison.OrdinalIgnoreCase) == 0)
						{
							goto IL_163;
						}
						if (!this._buildingSchema && string.Compare(this.SQLiteLastError(), 0, "no such table: TEMP.SCHEMA", 0, 26, StringComparison.OrdinalIgnoreCase) == 0)
						{
							break;
						}
					}
					else if (num == 6 || num == 5)
					{
						if (random == null)
						{
							random = new Random();
						}
						if (Environment.TickCount - (int)tickCount > (int)timeoutMS)
						{
							goto IL_229;
						}
						Thread.Sleep(random.Next(1, 150));
					}
				}
				strRemain = "";
				this._buildingSchema = true;
				try
				{
					ISQLiteSchemaExtensions iSQLiteSchemaExtensions = ((IServiceProvider)SQLiteFactory.Instance).GetService(typeof(ISQLiteSchemaExtensions)) as ISQLiteSchemaExtensions;
					if (iSQLiteSchemaExtensions != null)
					{
						iSQLiteSchemaExtensions.BuildTempSchema(cnn);
					}
					while (sQLiteStatement == null && strSql.Length > 0)
					{
						sQLiteStatement = this.Prepare(cnn, strSql, previous, timeoutMS, out strRemain);
						strSql = strRemain;
					}
					result = sQLiteStatement;
					return result;
				}
				finally
				{
					this._buildingSchema = false;
				}
				goto IL_229;
				IL_10C:
				if (num > 0)
				{
					throw new SQLiteException(num, this.SQLiteLastError());
				}
				strRemain = SQLiteConvert.UTF8ToString(zero2, nativestringlen);
				if (zero != IntPtr.Zero)
				{
					sQLiteStatement = new SQLiteStatement(this, zero, strSql.Substring(0, strSql.Length - strRemain.Length), previous);
				}
				result = sQLiteStatement;
				return result;
				IL_163:
				int num3 = strSql.IndexOf(';');
				if (num3 == -1)
				{
					num3 = strSql.Length - 1;
				}
				string types = strSql.Substring(0, num3 + 1);
				strSql = strSql.Substring(num3 + 1);
				strRemain = "";
				while (sQLiteStatement == null && strSql.Length > 0)
				{
					sQLiteStatement = this.Prepare(cnn, strSql, previous, timeoutMS, out strRemain);
					strSql = strRemain;
				}
				if (sQLiteStatement != null)
				{
					sQLiteStatement.SetTypes(types);
				}
				result = sQLiteStatement;
				return result;
				IL_229:
				throw new SQLiteException(num, this.SQLiteLastError());
			}
			finally
			{
				gCHandle.Free();
			}
			return result;
		}

		// Token: 0x0600B27A RID: 45690 RVA: 0x004F10FC File Offset: 0x004EF2FC
		internal override void Bind_Double(SQLiteStatement stmt, int index, double value)
		{
			int num = UnsafeNativeMethods.sqlite3_bind_double(stmt._sqlite_stmt, index, value);
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
		}

		// Token: 0x0600B27B RID: 45691 RVA: 0x004F1130 File Offset: 0x004EF330
		internal override void Bind_Int32(SQLiteStatement stmt, int index, int value)
		{
			int num = UnsafeNativeMethods.sqlite3_bind_int(stmt._sqlite_stmt, index, value);
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
		}

		// Token: 0x0600B27C RID: 45692 RVA: 0x004F1164 File Offset: 0x004EF364
		internal override void Bind_Int64(SQLiteStatement stmt, int index, long value)
		{
			int num = UnsafeNativeMethods.sqlite3_bind_int64(stmt._sqlite_stmt, index, value);
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
		}

		// Token: 0x0600B27D RID: 45693 RVA: 0x004F1198 File Offset: 0x004EF398
		internal override void Bind_Text(SQLiteStatement stmt, int index, string value)
		{
			byte[] array = SQLiteConvert.ToUTF8(value);
			int num = UnsafeNativeMethods.sqlite3_bind_text(stmt._sqlite_stmt, index, array, array.Length - 1, (IntPtr)(-1));
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
		}

		// Token: 0x0600B27E RID: 45694 RVA: 0x004F11DC File Offset: 0x004EF3DC
		internal override void Bind_DateTime(SQLiteStatement stmt, int index, DateTime dt)
		{
			byte[] array = base.ToUTF8(dt);
			int num = UnsafeNativeMethods.sqlite3_bind_text(stmt._sqlite_stmt, index, array, array.Length - 1, (IntPtr)(-1));
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
		}

		// Token: 0x0600B27F RID: 45695 RVA: 0x004F1220 File Offset: 0x004EF420
		internal override void Bind_Blob(SQLiteStatement stmt, int index, byte[] blobData)
		{
			int num = UnsafeNativeMethods.sqlite3_bind_blob(stmt._sqlite_stmt, index, blobData, blobData.Length, (IntPtr)(-1));
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
		}

		// Token: 0x0600B280 RID: 45696 RVA: 0x004F125C File Offset: 0x004EF45C
		internal override void Bind_Null(SQLiteStatement stmt, int index)
		{
			int num = UnsafeNativeMethods.sqlite3_bind_null(stmt._sqlite_stmt, index);
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
		}

		// Token: 0x0600B281 RID: 45697 RVA: 0x00054C72 File Offset: 0x00052E72
		internal override int Bind_ParamCount(SQLiteStatement stmt)
		{
			return UnsafeNativeMethods.sqlite3_bind_parameter_count(stmt._sqlite_stmt);
		}

		// Token: 0x0600B282 RID: 45698 RVA: 0x004F128C File Offset: 0x004EF48C
		internal override string Bind_ParamName(SQLiteStatement stmt, int index)
		{
			int nativestringlen;
			return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_bind_parameter_name_interop(stmt._sqlite_stmt, index, out nativestringlen), nativestringlen);
		}

		// Token: 0x0600B283 RID: 45699 RVA: 0x00054C84 File Offset: 0x00052E84
		internal override int Bind_ParamIndex(SQLiteStatement stmt, string paramName)
		{
			return UnsafeNativeMethods.sqlite3_bind_parameter_index(stmt._sqlite_stmt, SQLiteConvert.ToUTF8(paramName));
		}

		// Token: 0x0600B284 RID: 45700 RVA: 0x00054C9C File Offset: 0x00052E9C
		internal override int ColumnCount(SQLiteStatement stmt)
		{
			return UnsafeNativeMethods.sqlite3_column_count(stmt._sqlite_stmt);
		}

		// Token: 0x0600B285 RID: 45701 RVA: 0x004F12B4 File Offset: 0x004EF4B4
		internal override string ColumnName(SQLiteStatement stmt, int index)
		{
			int nativestringlen;
			return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_name_interop(stmt._sqlite_stmt, index, out nativestringlen), nativestringlen);
		}

		// Token: 0x0600B286 RID: 45702 RVA: 0x00054CAE File Offset: 0x00052EAE
		internal override TypeAffinity ColumnAffinity(SQLiteStatement stmt, int index)
		{
			return UnsafeNativeMethods.sqlite3_column_type(stmt._sqlite_stmt, index);
		}

		// Token: 0x0600B287 RID: 45703 RVA: 0x004F12DC File Offset: 0x004EF4DC
		internal override string ColumnType(SQLiteStatement stmt, int index, out TypeAffinity nAffinity)
		{
			int nativestringlen;
			IntPtr intPtr = UnsafeNativeMethods.sqlite3_column_decltype_interop(stmt._sqlite_stmt, index, out nativestringlen);
			nAffinity = this.ColumnAffinity(stmt, index);
			if (intPtr != IntPtr.Zero)
			{
				return SQLiteConvert.UTF8ToString(intPtr, nativestringlen);
			}
			string[] typeDefinitions = stmt.TypeDefinitions;
			if (typeDefinitions != null && index < typeDefinitions.Length && typeDefinitions[index] != null)
			{
				return typeDefinitions[index];
			}
			return string.Empty;
		}

		// Token: 0x0600B288 RID: 45704 RVA: 0x004F133C File Offset: 0x004EF53C
		internal override int ColumnIndex(SQLiteStatement stmt, string columnName)
		{
			int num = this.ColumnCount(stmt);
			for (int i = 0; i < num; i++)
			{
				if (string.Compare(columnName, this.ColumnName(stmt, i), StringComparison.OrdinalIgnoreCase) == 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600B289 RID: 45705 RVA: 0x004F1374 File Offset: 0x004EF574
		internal override string ColumnOriginalName(SQLiteStatement stmt, int index)
		{
			int nativestringlen;
			return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_origin_name_interop(stmt._sqlite_stmt, index, out nativestringlen), nativestringlen);
		}

		// Token: 0x0600B28A RID: 45706 RVA: 0x004F139C File Offset: 0x004EF59C
		internal override string ColumnDatabaseName(SQLiteStatement stmt, int index)
		{
			int nativestringlen;
			return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_database_name_interop(stmt._sqlite_stmt, index, out nativestringlen), nativestringlen);
		}

		// Token: 0x0600B28B RID: 45707 RVA: 0x004F13C4 File Offset: 0x004EF5C4
		internal override string ColumnTableName(SQLiteStatement stmt, int index)
		{
			int nativestringlen;
			return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_table_name_interop(stmt._sqlite_stmt, index, out nativestringlen), nativestringlen);
		}

		// Token: 0x0600B28C RID: 45708 RVA: 0x004F13EC File Offset: 0x004EF5EC
		internal override void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement)
		{
			IntPtr nativestring;
			IntPtr nativestring2;
			int num2;
			int num3;
			int num4;
			int nativestringlen;
			int nativestringlen2;
			int num = UnsafeNativeMethods.sqlite3_table_column_metadata_interop(this._sql, SQLiteConvert.ToUTF8(dataBase), SQLiteConvert.ToUTF8(table), SQLiteConvert.ToUTF8(column), out nativestring, out nativestring2, out num2, out num3, out num4, out nativestringlen, out nativestringlen2);
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
			dataType = SQLiteConvert.UTF8ToString(nativestring, nativestringlen);
			collateSequence = SQLiteConvert.UTF8ToString(nativestring2, nativestringlen2);
			notNull = (num2 == 1);
			primaryKey = (num3 == 1);
			autoIncrement = (num4 == 1);
		}

		// Token: 0x0600B28D RID: 45709 RVA: 0x004F1468 File Offset: 0x004EF668
		internal override double GetDouble(SQLiteStatement stmt, int index)
		{
			return UnsafeNativeMethods.sqlite3_column_double(stmt._sqlite_stmt, index);
		}

		// Token: 0x0600B28E RID: 45710 RVA: 0x00054CC1 File Offset: 0x00052EC1
		internal override int GetInt32(SQLiteStatement stmt, int index)
		{
			return UnsafeNativeMethods.sqlite3_column_int(stmt._sqlite_stmt, index);
		}

		// Token: 0x0600B28F RID: 45711 RVA: 0x004F1488 File Offset: 0x004EF688
		internal override long GetInt64(SQLiteStatement stmt, int index)
		{
			return UnsafeNativeMethods.sqlite3_column_int64(stmt._sqlite_stmt, index);
		}

		// Token: 0x0600B290 RID: 45712 RVA: 0x004F14A8 File Offset: 0x004EF6A8
		internal override string GetText(SQLiteStatement stmt, int index)
		{
			int nativestringlen;
			return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_column_text_interop(stmt._sqlite_stmt, index, out nativestringlen), nativestringlen);
		}

		// Token: 0x0600B291 RID: 45713 RVA: 0x004F14D0 File Offset: 0x004EF6D0
		internal override DateTime GetDateTime(SQLiteStatement stmt, int index)
		{
			int len;
			return base.ToDateTime(UnsafeNativeMethods.sqlite3_column_text_interop(stmt._sqlite_stmt, index, out len), len);
		}

		// Token: 0x0600B292 RID: 45714 RVA: 0x004F14F8 File Offset: 0x004EF6F8
		internal override long GetBytes(SQLiteStatement stmt, int index, int nDataOffset, byte[] bDest, int nStart, int nLength)
		{
			int num = nLength;
			int num2 = UnsafeNativeMethods.sqlite3_column_bytes(stmt._sqlite_stmt, index);
			IntPtr intPtr = UnsafeNativeMethods.sqlite3_column_blob(stmt._sqlite_stmt, index);
			if (bDest == null)
			{
				return (long)num2;
			}
			if (num + nStart > bDest.Length)
			{
				num = bDest.Length - nStart;
			}
			if (num + nDataOffset > num2)
			{
				num = num2 - nDataOffset;
			}
			if (num > 0)
			{
				Marshal.Copy((IntPtr)(intPtr.ToInt64() + (long)nDataOffset), bDest, nStart, num);
			}
			else
			{
				num = 0;
			}
			return (long)num;
		}

		// Token: 0x0600B293 RID: 45715 RVA: 0x004F1574 File Offset: 0x004EF774
		internal override long GetChars(SQLiteStatement stmt, int index, int nDataOffset, char[] bDest, int nStart, int nLength)
		{
			int num = nLength;
			string text = this.GetText(stmt, index);
			int length = text.Length;
			if (bDest == null)
			{
				return (long)length;
			}
			if (num + nStart > bDest.Length)
			{
				num = bDest.Length - nStart;
			}
			if (num + nDataOffset > length)
			{
				num = length - nDataOffset;
			}
			if (num > 0)
			{
				text.CopyTo(nDataOffset, bDest, nStart, num);
			}
			else
			{
				num = 0;
			}
			return (long)num;
		}

		// Token: 0x0600B294 RID: 45716 RVA: 0x00054CD4 File Offset: 0x00052ED4
		internal override bool IsNull(SQLiteStatement stmt, int index)
		{
			return this.ColumnAffinity(stmt, index) == TypeAffinity.Null;
		}

		// Token: 0x0600B295 RID: 45717 RVA: 0x00054CE1 File Offset: 0x00052EE1
		internal override int AggregateCount(IntPtr context)
		{
			return UnsafeNativeMethods.sqlite3_aggregate_count(context);
		}

		// Token: 0x0600B296 RID: 45718 RVA: 0x004F15D0 File Offset: 0x004EF7D0
		internal override void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal)
		{
			int num = UnsafeNativeMethods.sqlite3_create_function_interop(this._sql, SQLiteConvert.ToUTF8(strFunction), nArgs, 4, IntPtr.Zero, func, funcstep, funcfinal, needCollSeq ? 1 : 0);
			if (num == 0)
			{
				num = UnsafeNativeMethods.sqlite3_create_function_interop(this._sql, SQLiteConvert.ToUTF8(strFunction), nArgs, 1, IntPtr.Zero, func, funcstep, funcfinal, needCollSeq ? 1 : 0);
			}
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
		}

		// Token: 0x0600B297 RID: 45719 RVA: 0x004F1648 File Offset: 0x004EF848
		internal override void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16)
		{
			int num = UnsafeNativeMethods.sqlite3_create_collation(this._sql, SQLiteConvert.ToUTF8(strCollation), 2, IntPtr.Zero, func16);
			if (num == 0)
			{
				num = UnsafeNativeMethods.sqlite3_create_collation(this._sql, SQLiteConvert.ToUTF8(strCollation), 1, IntPtr.Zero, func);
			}
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
		}

		// Token: 0x0600B298 RID: 45720 RVA: 0x004F16A8 File Offset: 0x004EF8A8
		internal override int ContextCollateCompare(CollationEncodingEnum enc, IntPtr context, string s1, string s2)
		{
			Encoding encoding = null;
			switch (enc)
			{
			case CollationEncodingEnum.UTF8:
				encoding = Encoding.UTF8;
				break;
			case CollationEncodingEnum.UTF16LE:
				encoding = Encoding.Unicode;
				break;
			case CollationEncodingEnum.UTF16BE:
				encoding = Encoding.BigEndianUnicode;
				break;
			}
			byte[] bytes = encoding.GetBytes(s1);
			byte[] bytes2 = encoding.GetBytes(s2);
			return UnsafeNativeMethods.sqlite3_context_collcompare(context, bytes, bytes.Length, bytes2, bytes2.Length);
		}

		// Token: 0x0600B299 RID: 45721 RVA: 0x004F1704 File Offset: 0x004EF904
		internal override int ContextCollateCompare(CollationEncodingEnum enc, IntPtr context, char[] c1, char[] c2)
		{
			Encoding encoding = null;
			switch (enc)
			{
			case CollationEncodingEnum.UTF8:
				encoding = Encoding.UTF8;
				break;
			case CollationEncodingEnum.UTF16LE:
				encoding = Encoding.Unicode;
				break;
			case CollationEncodingEnum.UTF16BE:
				encoding = Encoding.BigEndianUnicode;
				break;
			}
			byte[] bytes = encoding.GetBytes(c1);
			byte[] bytes2 = encoding.GetBytes(c2);
			return UnsafeNativeMethods.sqlite3_context_collcompare(context, bytes, bytes.Length, bytes2, bytes2.Length);
		}

		// Token: 0x0600B29A RID: 45722 RVA: 0x004F1760 File Offset: 0x004EF960
		internal override CollationSequence GetCollationSequence(SQLiteFunction func, IntPtr context)
		{
			CollationSequence result = default(CollationSequence);
			int type;
			int encoding;
			int nativestringlen;
			IntPtr nativestring = UnsafeNativeMethods.sqlite3_context_collseq(context, out type, out encoding, out nativestringlen);
			result.Name = SQLiteConvert.UTF8ToString(nativestring, nativestringlen);
			result.Type = (CollationTypeEnum)type;
			result._func = func;
			result.Encoding = (CollationEncodingEnum)encoding;
			return result;
		}

		// Token: 0x0600B29B RID: 45723 RVA: 0x004F17AC File Offset: 0x004EF9AC
		internal override long GetParamValueBytes(IntPtr p, int nDataOffset, byte[] bDest, int nStart, int nLength)
		{
			int num = nLength;
			int num2 = UnsafeNativeMethods.sqlite3_value_bytes(p);
			IntPtr intPtr = UnsafeNativeMethods.sqlite3_value_blob(p);
			if (bDest == null)
			{
				return (long)num2;
			}
			if (num + nStart > bDest.Length)
			{
				num = bDest.Length - nStart;
			}
			if (num + nDataOffset > num2)
			{
				num = num2 - nDataOffset;
			}
			if (num > 0)
			{
				Marshal.Copy((IntPtr)(intPtr.ToInt32() + nDataOffset), bDest, nStart, num);
			}
			else
			{
				num = 0;
			}
			return (long)num;
		}

		// Token: 0x0600B29C RID: 45724 RVA: 0x004F180C File Offset: 0x004EFA0C
		internal override double GetParamValueDouble(IntPtr ptr)
		{
			return UnsafeNativeMethods.sqlite3_value_double(ptr);
		}

		// Token: 0x0600B29D RID: 45725 RVA: 0x00054CE9 File Offset: 0x00052EE9
		internal override int GetParamValueInt32(IntPtr ptr)
		{
			return UnsafeNativeMethods.sqlite3_value_int(ptr);
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x004F1824 File Offset: 0x004EFA24
		internal override long GetParamValueInt64(IntPtr ptr)
		{
			return UnsafeNativeMethods.sqlite3_value_int64(ptr);
		}

		// Token: 0x0600B29F RID: 45727 RVA: 0x004F183C File Offset: 0x004EFA3C
		internal override string GetParamValueText(IntPtr ptr)
		{
			int nativestringlen;
			return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_value_text_interop(ptr, out nativestringlen), nativestringlen);
		}

		// Token: 0x0600B2A0 RID: 45728 RVA: 0x00054CF1 File Offset: 0x00052EF1
		internal override TypeAffinity GetParamValueType(IntPtr ptr)
		{
			return UnsafeNativeMethods.sqlite3_value_type(ptr);
		}

		// Token: 0x0600B2A1 RID: 45729 RVA: 0x00054CF9 File Offset: 0x00052EF9
		internal override void ReturnBlob(IntPtr context, byte[] value)
		{
			UnsafeNativeMethods.sqlite3_result_blob(context, value, value.Length, (IntPtr)(-1));
		}

		// Token: 0x0600B2A2 RID: 45730 RVA: 0x00054D0B File Offset: 0x00052F0B
		internal override void ReturnDouble(IntPtr context, double value)
		{
			UnsafeNativeMethods.sqlite3_result_double(context, value);
		}

		// Token: 0x0600B2A3 RID: 45731 RVA: 0x00054D14 File Offset: 0x00052F14
		internal override void ReturnError(IntPtr context, string value)
		{
			UnsafeNativeMethods.sqlite3_result_error(context, SQLiteConvert.ToUTF8(value), value.Length);
		}

		// Token: 0x0600B2A4 RID: 45732 RVA: 0x00054D28 File Offset: 0x00052F28
		internal override void ReturnInt32(IntPtr context, int value)
		{
			UnsafeNativeMethods.sqlite3_result_int(context, value);
		}

		// Token: 0x0600B2A5 RID: 45733 RVA: 0x00054D31 File Offset: 0x00052F31
		internal override void ReturnInt64(IntPtr context, long value)
		{
			UnsafeNativeMethods.sqlite3_result_int64(context, value);
		}

		// Token: 0x0600B2A6 RID: 45734 RVA: 0x00054D3A File Offset: 0x00052F3A
		internal override void ReturnNull(IntPtr context)
		{
			UnsafeNativeMethods.sqlite3_result_null(context);
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x004F1858 File Offset: 0x004EFA58
		internal override void ReturnText(IntPtr context, string value)
		{
			byte[] array = SQLiteConvert.ToUTF8(value);
			UnsafeNativeMethods.sqlite3_result_text(context, SQLiteConvert.ToUTF8(value), array.Length - 1, (IntPtr)(-1));
		}

		// Token: 0x0600B2A8 RID: 45736 RVA: 0x00054D42 File Offset: 0x00052F42
		internal override IntPtr AggregateContext(IntPtr context)
		{
			return UnsafeNativeMethods.sqlite3_aggregate_context(context, 1);
		}

		// Token: 0x0600B2A9 RID: 45737 RVA: 0x004F1884 File Offset: 0x004EFA84
		internal override void SetPassword(byte[] passwordBytes)
		{
			int num = UnsafeNativeMethods.sqlite3_key(this._sql, passwordBytes, passwordBytes.Length);
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
		}

		// Token: 0x0600B2AA RID: 45738 RVA: 0x004F18B8 File Offset: 0x004EFAB8
		internal override void ChangePassword(byte[] newPasswordBytes)
		{
			int num = UnsafeNativeMethods.sqlite3_rekey(this._sql, newPasswordBytes, (newPasswordBytes == null) ? 0 : newPasswordBytes.Length);
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
		}

		// Token: 0x0600B2AB RID: 45739 RVA: 0x00054D4B File Offset: 0x00052F4B
		internal override void SetUpdateHook(SQLiteUpdateCallback func)
		{
			UnsafeNativeMethods.sqlite3_update_hook(this._sql, func, IntPtr.Zero);
		}

		// Token: 0x0600B2AC RID: 45740 RVA: 0x00054D64 File Offset: 0x00052F64
		internal override void SetCommitHook(SQLiteCommitCallback func)
		{
			UnsafeNativeMethods.sqlite3_commit_hook(this._sql, func, IntPtr.Zero);
		}

		// Token: 0x0600B2AD RID: 45741 RVA: 0x00054D7D File Offset: 0x00052F7D
		internal override void SetRollbackHook(SQLiteRollbackCallback func)
		{
			UnsafeNativeMethods.sqlite3_rollback_hook(this._sql, func, IntPtr.Zero);
		}

		// Token: 0x0600B2AE RID: 45742 RVA: 0x004F18F4 File Offset: 0x004EFAF4
		internal override object GetValue(SQLiteStatement stmt, int index, SQLiteType typ)
		{
			if (this.IsNull(stmt, index))
			{
				return DBNull.Value;
			}
			TypeAffinity typeAffinity = typ.Affinity;
			Type type = null;
			if (typ.Type != DbType.Object)
			{
				type = SQLiteConvert.SQLiteTypeToType(typ);
				typeAffinity = SQLiteConvert.TypeToAffinity(type);
			}
			TypeAffinity typeAffinity2 = typeAffinity;
			switch (typeAffinity2)
			{
			case TypeAffinity.Int64:
				if (type == null)
				{
					return this.GetInt64(stmt, index);
				}
				return Convert.ChangeType(this.GetInt64(stmt, index), type, null);
			case TypeAffinity.Double:
				if (type == null)
				{
					return this.GetDouble(stmt, index);
				}
				return Convert.ChangeType(this.GetDouble(stmt, index), type, null);
			case TypeAffinity.Text:
				break;
			case TypeAffinity.Blob:
			{
				if (typ.Type == DbType.Guid && typ.Affinity == TypeAffinity.Text)
				{
					return new Guid(this.GetText(stmt, index));
				}
				int num = (int)this.GetBytes(stmt, index, 0, null, 0, 0);
				byte[] array = new byte[num];
				this.GetBytes(stmt, index, 0, array, 0, num);
				if (typ.Type == DbType.Guid && num == 16)
				{
					return new Guid(array);
				}
				return array;
			}
			default:
				if (typeAffinity2 == TypeAffinity.DateTime)
				{
					return this.GetDateTime(stmt, index);
				}
				break;
			}
			return this.GetText(stmt, index);
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x00054D96 File Offset: 0x00052F96
		internal override int GetCursorForTable(SQLiteStatement stmt, int db, int rootPage)
		{
			return UnsafeNativeMethods.sqlite3_table_cursor(stmt._sqlite_stmt, db, rootPage);
		}

		// Token: 0x0600B2B0 RID: 45744 RVA: 0x004F1A20 File Offset: 0x004EFC20
		internal override long GetRowIdForCursor(SQLiteStatement stmt, int cursor)
		{
			long result;
			if (UnsafeNativeMethods.sqlite3_cursor_rowid(stmt._sqlite_stmt, cursor, out result) == 0)
			{
				return result;
			}
			return 0L;
		}

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x004F1A50 File Offset: 0x004EFC50
		internal override void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence)
		{
			IntPtr nativestring;
			int nativestringlen;
			int num = UnsafeNativeMethods.sqlite3_index_column_info_interop(this._sql, SQLiteConvert.ToUTF8(database), SQLiteConvert.ToUTF8(index), SQLiteConvert.ToUTF8(column), out sortMode, out onError, out nativestring, out nativestringlen);
			if (num != 0)
			{
				throw new SQLiteException(num, "");
			}
			collationSequence = SQLiteConvert.UTF8ToString(nativestring, nativestringlen);
		}

		// Token: 0x04005E59 RID: 24153
		protected SQLiteConnectionHandle _sql;

		// Token: 0x04005E5A RID: 24154
		protected string _fileName;

		// Token: 0x04005E5B RID: 24155
		protected bool _usePool;

		// Token: 0x04005E5C RID: 24156
		protected int _poolVersion;

		// Token: 0x04005E5D RID: 24157
		private bool _buildingSchema;

		// Token: 0x04005E5E RID: 24158
		protected SQLiteFunction[] _functionsArray;
	}
}

using System;

namespace System.Data.SQLite
{
	// Token: 0x02001431 RID: 5169
	internal abstract class SQLiteBase : SQLiteConvert, IDisposable
	{
		// Token: 0x0600B154 RID: 45396 RVA: 0x000544CC File Offset: 0x000526CC
		internal SQLiteBase(SQLiteDateFormats fmt) : base(fmt)
		{
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x0600B155 RID: 45397
		internal abstract string Version
		{
			get;
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x0600B156 RID: 45398
		internal abstract int Changes
		{
			get;
		}

		// Token: 0x0600B157 RID: 45399
		internal abstract void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool);

		// Token: 0x0600B158 RID: 45400
		internal abstract void Close();

		// Token: 0x0600B159 RID: 45401
		internal abstract void SetTimeout(int nTimeoutMS);

		// Token: 0x0600B15A RID: 45402
		internal abstract string SQLiteLastError();

		// Token: 0x0600B15B RID: 45403
		internal abstract void ClearPool();

		// Token: 0x0600B15C RID: 45404
		internal abstract SQLiteStatement Prepare(SQLiteConnection cnn, string strSql, SQLiteStatement previous, uint timeoutMS, out string strRemain);

		// Token: 0x0600B15D RID: 45405
		internal abstract bool Step(SQLiteStatement stmt);

		// Token: 0x0600B15E RID: 45406
		internal abstract int Reset(SQLiteStatement stmt);

		// Token: 0x0600B15F RID: 45407
		internal abstract void Cancel();

		// Token: 0x0600B160 RID: 45408
		internal abstract void Bind_Double(SQLiteStatement stmt, int index, double value);

		// Token: 0x0600B161 RID: 45409
		internal abstract void Bind_Int32(SQLiteStatement stmt, int index, int value);

		// Token: 0x0600B162 RID: 45410
		internal abstract void Bind_Int64(SQLiteStatement stmt, int index, long value);

		// Token: 0x0600B163 RID: 45411
		internal abstract void Bind_Text(SQLiteStatement stmt, int index, string value);

		// Token: 0x0600B164 RID: 45412
		internal abstract void Bind_Blob(SQLiteStatement stmt, int index, byte[] blobData);

		// Token: 0x0600B165 RID: 45413
		internal abstract void Bind_DateTime(SQLiteStatement stmt, int index, DateTime dt);

		// Token: 0x0600B166 RID: 45414
		internal abstract void Bind_Null(SQLiteStatement stmt, int index);

		// Token: 0x0600B167 RID: 45415
		internal abstract int Bind_ParamCount(SQLiteStatement stmt);

		// Token: 0x0600B168 RID: 45416
		internal abstract string Bind_ParamName(SQLiteStatement stmt, int index);

		// Token: 0x0600B169 RID: 45417
		internal abstract int Bind_ParamIndex(SQLiteStatement stmt, string paramName);

		// Token: 0x0600B16A RID: 45418
		internal abstract int ColumnCount(SQLiteStatement stmt);

		// Token: 0x0600B16B RID: 45419
		internal abstract string ColumnName(SQLiteStatement stmt, int index);

		// Token: 0x0600B16C RID: 45420
		internal abstract TypeAffinity ColumnAffinity(SQLiteStatement stmt, int index);

		// Token: 0x0600B16D RID: 45421
		internal abstract string ColumnType(SQLiteStatement stmt, int index, out TypeAffinity nAffinity);

		// Token: 0x0600B16E RID: 45422
		internal abstract int ColumnIndex(SQLiteStatement stmt, string columnName);

		// Token: 0x0600B16F RID: 45423
		internal abstract string ColumnOriginalName(SQLiteStatement stmt, int index);

		// Token: 0x0600B170 RID: 45424
		internal abstract string ColumnDatabaseName(SQLiteStatement stmt, int index);

		// Token: 0x0600B171 RID: 45425
		internal abstract string ColumnTableName(SQLiteStatement stmt, int index);

		// Token: 0x0600B172 RID: 45426
		internal abstract void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement);

		// Token: 0x0600B173 RID: 45427
		internal abstract void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence);

		// Token: 0x0600B174 RID: 45428
		internal abstract double GetDouble(SQLiteStatement stmt, int index);

		// Token: 0x0600B175 RID: 45429
		internal abstract int GetInt32(SQLiteStatement stmt, int index);

		// Token: 0x0600B176 RID: 45430
		internal abstract long GetInt64(SQLiteStatement stmt, int index);

		// Token: 0x0600B177 RID: 45431
		internal abstract string GetText(SQLiteStatement stmt, int index);

		// Token: 0x0600B178 RID: 45432
		internal abstract long GetBytes(SQLiteStatement stmt, int index, int nDataoffset, byte[] bDest, int nStart, int nLength);

		// Token: 0x0600B179 RID: 45433
		internal abstract long GetChars(SQLiteStatement stmt, int index, int nDataoffset, char[] bDest, int nStart, int nLength);

		// Token: 0x0600B17A RID: 45434
		internal abstract DateTime GetDateTime(SQLiteStatement stmt, int index);

		// Token: 0x0600B17B RID: 45435
		internal abstract bool IsNull(SQLiteStatement stmt, int index);

		// Token: 0x0600B17C RID: 45436
		internal abstract void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16);

		// Token: 0x0600B17D RID: 45437
		internal abstract void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal);

		// Token: 0x0600B17E RID: 45438
		internal abstract CollationSequence GetCollationSequence(SQLiteFunction func, IntPtr context);

		// Token: 0x0600B17F RID: 45439
		internal abstract int ContextCollateCompare(CollationEncodingEnum enc, IntPtr context, string s1, string s2);

		// Token: 0x0600B180 RID: 45440
		internal abstract int ContextCollateCompare(CollationEncodingEnum enc, IntPtr context, char[] c1, char[] c2);

		// Token: 0x0600B181 RID: 45441
		internal abstract int AggregateCount(IntPtr context);

		// Token: 0x0600B182 RID: 45442
		internal abstract IntPtr AggregateContext(IntPtr context);

		// Token: 0x0600B183 RID: 45443
		internal abstract long GetParamValueBytes(IntPtr ptr, int nDataOffset, byte[] bDest, int nStart, int nLength);

		// Token: 0x0600B184 RID: 45444
		internal abstract double GetParamValueDouble(IntPtr ptr);

		// Token: 0x0600B185 RID: 45445
		internal abstract int GetParamValueInt32(IntPtr ptr);

		// Token: 0x0600B186 RID: 45446
		internal abstract long GetParamValueInt64(IntPtr ptr);

		// Token: 0x0600B187 RID: 45447
		internal abstract string GetParamValueText(IntPtr ptr);

		// Token: 0x0600B188 RID: 45448
		internal abstract TypeAffinity GetParamValueType(IntPtr ptr);

		// Token: 0x0600B189 RID: 45449
		internal abstract void ReturnBlob(IntPtr context, byte[] value);

		// Token: 0x0600B18A RID: 45450
		internal abstract void ReturnDouble(IntPtr context, double value);

		// Token: 0x0600B18B RID: 45451
		internal abstract void ReturnError(IntPtr context, string value);

		// Token: 0x0600B18C RID: 45452
		internal abstract void ReturnInt32(IntPtr context, int value);

		// Token: 0x0600B18D RID: 45453
		internal abstract void ReturnInt64(IntPtr context, long value);

		// Token: 0x0600B18E RID: 45454
		internal abstract void ReturnNull(IntPtr context);

		// Token: 0x0600B18F RID: 45455
		internal abstract void ReturnText(IntPtr context, string value);

		// Token: 0x0600B190 RID: 45456
		internal abstract void SetPassword(byte[] passwordBytes);

		// Token: 0x0600B191 RID: 45457
		internal abstract void ChangePassword(byte[] newPasswordBytes);

		// Token: 0x0600B192 RID: 45458
		internal abstract void SetUpdateHook(SQLiteUpdateCallback func);

		// Token: 0x0600B193 RID: 45459
		internal abstract void SetCommitHook(SQLiteCommitCallback func);

		// Token: 0x0600B194 RID: 45460
		internal abstract void SetRollbackHook(SQLiteRollbackCallback func);

		// Token: 0x0600B195 RID: 45461
		internal abstract int GetCursorForTable(SQLiteStatement stmt, int database, int rootPage);

		// Token: 0x0600B196 RID: 45462
		internal abstract long GetRowIdForCursor(SQLiteStatement stmt, int cursor);

		// Token: 0x0600B197 RID: 45463
		internal abstract object GetValue(SQLiteStatement stmt, int index, SQLiteType typ);

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x0600B198 RID: 45464
		internal abstract bool AutoCommit
		{
			get;
		}

		// Token: 0x0600B199 RID: 45465 RVA: 0x00004BC2 File Offset: 0x00002DC2
		protected virtual void Dispose(bool bDisposing)
		{
		}

		// Token: 0x0600B19A RID: 45466 RVA: 0x000544D5 File Offset: 0x000526D5
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600B19B RID: 45467 RVA: 0x004ED02C File Offset: 0x004EB22C
		internal static string SQLiteLastError(SQLiteConnectionHandle db)
		{
			int nativestringlen;
			return SQLiteConvert.UTF8ToString(UnsafeNativeMethods.sqlite3_errmsg_interop(db, out nativestringlen), nativestringlen);
		}

		// Token: 0x0600B19C RID: 45468 RVA: 0x004ED04C File Offset: 0x004EB24C
		internal static void FinalizeStatement(SQLiteStatementHandle stmt)
		{
			lock (SQLiteBase._lock)
			{
				int num = UnsafeNativeMethods.sqlite3_finalize_interop(stmt);
				if (num > 0)
				{
					throw new SQLiteException(num, null);
				}
			}
		}

		// Token: 0x0600B19D RID: 45469 RVA: 0x004ED098 File Offset: 0x004EB298
		internal static void CloseConnection(SQLiteConnectionHandle db)
		{
			lock (SQLiteBase._lock)
			{
				int num = UnsafeNativeMethods.sqlite3_close_interop(db);
				if (num > 0)
				{
					throw new SQLiteException(num, SQLiteBase.SQLiteLastError(db));
				}
			}
		}

		// Token: 0x0600B19E RID: 45470 RVA: 0x004ED0E8 File Offset: 0x004EB2E8
		internal static void ResetConnection(SQLiteConnectionHandle db)
		{
			lock (SQLiteBase._lock)
			{
				IntPtr intPtr = IntPtr.Zero;
				do
				{
					intPtr = UnsafeNativeMethods.sqlite3_next_stmt(db, intPtr);
					if (intPtr != IntPtr.Zero)
					{
						int num = UnsafeNativeMethods.sqlite3_reset_interop(intPtr);
					}
				}
				while (intPtr != IntPtr.Zero);
				if (!SQLiteBase.IsAutocommit(db))
				{
					int num = UnsafeNativeMethods.sqlite3_exec(db, SQLiteConvert.ToUTF8("ROLLBACK"), IntPtr.Zero, IntPtr.Zero, out intPtr);
					if (num > 0)
					{
						throw new SQLiteException(num, SQLiteBase.SQLiteLastError(db));
					}
				}
			}
		}

		// Token: 0x0600B19F RID: 45471 RVA: 0x000544E4 File Offset: 0x000526E4
		internal static bool IsAutocommit(SQLiteConnectionHandle hdl)
		{
			return UnsafeNativeMethods.sqlite3_get_autocommit(hdl) == 1;
		}

		// Token: 0x04005E02 RID: 24066
		internal static object _lock = new object();
	}
}

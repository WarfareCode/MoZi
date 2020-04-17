using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Data.SQLite
{
	// Token: 0x02001417 RID: 5143
	[SuppressUnmanagedCodeSecurity]
	internal static class UnsafeNativeMethods
	{
		// Token: 0x0600B097 RID: 45207
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_bind_parameter_name_interop(IntPtr stmt, int index, out int len);

		// Token: 0x0600B098 RID: 45208
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_column_database_name_interop(IntPtr stmt, int index, out int len);

		// Token: 0x0600B099 RID: 45209
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_column_database_name16_interop(IntPtr stmt, int index, out int len);

		// Token: 0x0600B09A RID: 45210
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_column_decltype_interop(IntPtr stmt, int index, out int len);

		// Token: 0x0600B09B RID: 45211
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_column_decltype16_interop(IntPtr stmt, int index, out int len);

		// Token: 0x0600B09C RID: 45212
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_column_name_interop(IntPtr stmt, int index, out int len);

		// Token: 0x0600B09D RID: 45213
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_column_name16_interop(IntPtr stmt, int index, out int len);

		// Token: 0x0600B09E RID: 45214
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_column_origin_name_interop(IntPtr stmt, int index, out int len);

		// Token: 0x0600B09F RID: 45215
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_column_origin_name16_interop(IntPtr stmt, int index, out int len);

		// Token: 0x0600B0A0 RID: 45216
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_column_table_name_interop(IntPtr stmt, int index, out int len);

		// Token: 0x0600B0A1 RID: 45217
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_column_table_name16_interop(IntPtr stmt, int index, out int len);

		// Token: 0x0600B0A2 RID: 45218
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_column_text_interop(IntPtr stmt, int index, out int len);

		// Token: 0x0600B0A3 RID: 45219
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_column_text16_interop(IntPtr stmt, int index, out int len);

		// Token: 0x0600B0A4 RID: 45220
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_errmsg_interop(IntPtr db, out int len);

		// Token: 0x0600B0A5 RID: 45221
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern int sqlite3_prepare_interop(IntPtr db, IntPtr pSql, int nBytes, out IntPtr stmt, out IntPtr ptrRemain, out int nRemain);

		// Token: 0x0600B0A6 RID: 45222
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern int sqlite3_table_column_metadata_interop(IntPtr db, byte[] dbName, byte[] tblName, byte[] colName, out IntPtr ptrDataType, out IntPtr ptrCollSeq, out int notNull, out int primaryKey, out int autoInc, out int dtLen, out int csLen);

		// Token: 0x0600B0A7 RID: 45223
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_value_text_interop(IntPtr p, out int len);

		// Token: 0x0600B0A8 RID: 45224
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_value_text16_interop(IntPtr p, out int len);

		// Token: 0x0600B0A9 RID: 45225
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern int sqlite3_close_interop(IntPtr db);

		// Token: 0x0600B0AA RID: 45226
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern int sqlite3_create_function_interop(IntPtr db, byte[] strName, int nArgs, int nType, IntPtr pvUser, SQLiteCallback func, SQLiteCallback fstep, SQLiteFinalCallback ffinal, int needCollSeq);

		// Token: 0x0600B0AB RID: 45227
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern int sqlite3_finalize_interop(IntPtr stmt);

		// Token: 0x0600B0AC RID: 45228
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern int sqlite3_open_interop(byte[] utf8Filename, int flags, out IntPtr db);

		// Token: 0x0600B0AD RID: 45229
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern int sqlite3_open16_interop(byte[] utf8Filename, int flags, out IntPtr db);

		// Token: 0x0600B0AE RID: 45230
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern int sqlite3_reset_interop(IntPtr stmt);

		// Token: 0x0600B0AF RID: 45231
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern IntPtr sqlite3_context_collseq(IntPtr context, out int type, out int enc, out int len);

		// Token: 0x0600B0B0 RID: 45232
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern int sqlite3_context_collcompare(IntPtr context, byte[] p1, int p1len, byte[] p2, int p2len);

		// Token: 0x0600B0B1 RID: 45233
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern int sqlite3_cursor_rowid(IntPtr stmt, int cursor, out long rowid);

		// Token: 0x0600B0B2 RID: 45234
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern int sqlite3_index_column_info_interop(IntPtr db, byte[] catalog, byte[] IndexName, byte[] ColumnName, out int sortOrder, out int onError, out IntPtr Collation, out int colllen);

		// Token: 0x0600B0B3 RID: 45235
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern void sqlite3_resetall_interop(IntPtr db);

		// Token: 0x0600B0B4 RID: 45236
		[DllImport("System.Data.SQLite.DLL")]
		internal static extern int sqlite3_table_cursor(IntPtr stmt, int db, int tableRootPage);

		// Token: 0x0600B0B5 RID: 45237
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr sqlite3_libversion();

		// Token: 0x0600B0B6 RID: 45238
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void sqlite3_interrupt(IntPtr db);

		// Token: 0x0600B0B7 RID: 45239
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_changes(IntPtr db);

		// Token: 0x0600B0B8 RID: 45240
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_busy_timeout(IntPtr db, int ms);

		// Token: 0x0600B0B9 RID: 45241
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_bind_blob(IntPtr stmt, int index, byte[] value, int nSize, IntPtr nTransient);

		// Token: 0x0600B0BA RID: 45242
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_bind_double(IntPtr stmt, int index, double value);

		// Token: 0x0600B0BB RID: 45243
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_bind_int(IntPtr stmt, int index, int value);

		// Token: 0x0600B0BC RID: 45244
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_bind_int64(IntPtr stmt, int index, long value);

		// Token: 0x0600B0BD RID: 45245
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_bind_null(IntPtr stmt, int index);

		// Token: 0x0600B0BE RID: 45246
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_bind_text(IntPtr stmt, int index, byte[] value, int nlen, IntPtr pvReserved);

		// Token: 0x0600B0BF RID: 45247
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_bind_parameter_count(IntPtr stmt);

		// Token: 0x0600B0C0 RID: 45248
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_bind_parameter_index(IntPtr stmt, byte[] strName);

		// Token: 0x0600B0C1 RID: 45249
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_column_count(IntPtr stmt);

		// Token: 0x0600B0C2 RID: 45250
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_step(IntPtr stmt);

		// Token: 0x0600B0C3 RID: 45251
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double sqlite3_column_double(IntPtr stmt, int index);

		// Token: 0x0600B0C4 RID: 45252
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_column_int(IntPtr stmt, int index);

		// Token: 0x0600B0C5 RID: 45253
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long sqlite3_column_int64(IntPtr stmt, int index);

		// Token: 0x0600B0C6 RID: 45254
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr sqlite3_column_blob(IntPtr stmt, int index);

		// Token: 0x0600B0C7 RID: 45255
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_column_bytes(IntPtr stmt, int index);

		// Token: 0x0600B0C8 RID: 45256
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern TypeAffinity sqlite3_column_type(IntPtr stmt, int index);

		// Token: 0x0600B0C9 RID: 45257
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_create_collation(IntPtr db, byte[] strName, int nType, IntPtr pvUser, SQLiteCollation func);

		// Token: 0x0600B0CA RID: 45258
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_aggregate_count(IntPtr context);

		// Token: 0x0600B0CB RID: 45259
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr sqlite3_value_blob(IntPtr p);

		// Token: 0x0600B0CC RID: 45260
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_value_bytes(IntPtr p);

		// Token: 0x0600B0CD RID: 45261
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double sqlite3_value_double(IntPtr p);

		// Token: 0x0600B0CE RID: 45262
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_value_int(IntPtr p);

		// Token: 0x0600B0CF RID: 45263
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long sqlite3_value_int64(IntPtr p);

		// Token: 0x0600B0D0 RID: 45264
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern TypeAffinity sqlite3_value_type(IntPtr p);

		// Token: 0x0600B0D1 RID: 45265
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_blob(IntPtr context, byte[] value, int nSize, IntPtr pvReserved);

		// Token: 0x0600B0D2 RID: 45266
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_double(IntPtr context, double value);

		// Token: 0x0600B0D3 RID: 45267
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_error(IntPtr context, byte[] strErr, int nLen);

		// Token: 0x0600B0D4 RID: 45268
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_int(IntPtr context, int value);

		// Token: 0x0600B0D5 RID: 45269
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_int64(IntPtr context, long value);

		// Token: 0x0600B0D6 RID: 45270
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_null(IntPtr context);

		// Token: 0x0600B0D7 RID: 45271
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_text(IntPtr context, byte[] value, int nLen, IntPtr pvReserved);

		// Token: 0x0600B0D8 RID: 45272
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr sqlite3_aggregate_context(IntPtr context, int nBytes);

		// Token: 0x0600B0D9 RID: 45273
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		internal static extern int sqlite3_bind_text16(IntPtr stmt, int index, string value, int nlen, IntPtr pvReserved);

		// Token: 0x0600B0DA RID: 45274
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		internal static extern void sqlite3_result_error16(IntPtr context, string strName, int nLen);

		// Token: 0x0600B0DB RID: 45275
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		internal static extern void sqlite3_result_text16(IntPtr context, string strName, int nLen, IntPtr pvReserved);

		// Token: 0x0600B0DC RID: 45276
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_key(IntPtr db, byte[] key, int keylen);

		// Token: 0x0600B0DD RID: 45277
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_rekey(IntPtr db, byte[] key, int keylen);

		// Token: 0x0600B0DE RID: 45278
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr sqlite3_update_hook(IntPtr db, SQLiteUpdateCallback func, IntPtr pvUser);

		// Token: 0x0600B0DF RID: 45279
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr sqlite3_commit_hook(IntPtr db, SQLiteCommitCallback func, IntPtr pvUser);

		// Token: 0x0600B0E0 RID: 45280
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr sqlite3_rollback_hook(IntPtr db, SQLiteRollbackCallback func, IntPtr pvUser);

		// Token: 0x0600B0E1 RID: 45281
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr sqlite3_db_handle(IntPtr stmt);

		// Token: 0x0600B0E2 RID: 45282
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr sqlite3_next_stmt(IntPtr db, IntPtr stmt);

		// Token: 0x0600B0E3 RID: 45283
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_exec(IntPtr db, byte[] strSql, IntPtr pvCallback, IntPtr pvParam, out IntPtr errMsg);

		// Token: 0x0600B0E4 RID: 45284
		[DllImport("System.Data.SQLite.DLL", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int sqlite3_get_autocommit(IntPtr db);

		// Token: 0x04005DA9 RID: 23977
		private const string SQLITE_DLL = "System.Data.SQLite.DLL";
	}
}

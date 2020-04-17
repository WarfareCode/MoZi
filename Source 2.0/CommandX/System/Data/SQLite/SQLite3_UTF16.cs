using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02001445 RID: 5189
	internal sealed class SQLite3_UTF16 : SQLite3
	{
		// Token: 0x0600B2B2 RID: 45746 RVA: 0x00054DAA File Offset: 0x00052FAA
		internal SQLite3_UTF16(SQLiteDateFormats fmt) : base(fmt)
		{
		}

		// Token: 0x0600B2B3 RID: 45747 RVA: 0x00054DB3 File Offset: 0x00052FB3
		public override string ToString(IntPtr b, int nbytelen)
		{
			return SQLite3_UTF16.UTF16ToString(b, nbytelen);
		}

		// Token: 0x0600B2B4 RID: 45748 RVA: 0x00054DBC File Offset: 0x00052FBC
		public static string UTF16ToString(IntPtr b, int nbytelen)
		{
			if (nbytelen == 0 || b == IntPtr.Zero)
			{
				return "";
			}
			if (nbytelen == -1)
			{
				return Marshal.PtrToStringUni(b);
			}
			return Marshal.PtrToStringUni(b, nbytelen / 2);
		}

		// Token: 0x0600B2B5 RID: 45749 RVA: 0x004F1AA4 File Offset: 0x004EFCA4
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
				int num = UnsafeNativeMethods.sqlite3_open16_interop(SQLiteConvert.ToUTF8(strFilename), (int)flags, out db);
				if (num > 0)
				{
					throw new SQLiteException(num, null);
				}
				this._sql = db;
			}
			this._functionsArray = SQLiteFunction.BindFunctions(this);
		}

		// Token: 0x0600B2B6 RID: 45750 RVA: 0x00054DE8 File Offset: 0x00052FE8
		internal override void Bind_DateTime(SQLiteStatement stmt, int index, DateTime dt)
		{
			this.Bind_Text(stmt, index, base.ToString(dt));
		}

		// Token: 0x0600B2B7 RID: 45751 RVA: 0x004F1B1C File Offset: 0x004EFD1C
		internal override void Bind_Text(SQLiteStatement stmt, int index, string value)
		{
			int num = UnsafeNativeMethods.sqlite3_bind_text16(stmt._sqlite_stmt, index, value, value.Length * 2, (IntPtr)(-1));
			if (num > 0)
			{
				throw new SQLiteException(num, this.SQLiteLastError());
			}
		}

		// Token: 0x0600B2B8 RID: 45752 RVA: 0x00054DF9 File Offset: 0x00052FF9
		internal override DateTime GetDateTime(SQLiteStatement stmt, int index)
		{
			return base.ToDateTime(this.GetText(stmt, index));
		}

		// Token: 0x0600B2B9 RID: 45753 RVA: 0x004F1B5C File Offset: 0x004EFD5C
		internal override string ColumnName(SQLiteStatement stmt, int index)
		{
			int nbytelen;
			return SQLite3_UTF16.UTF16ToString(UnsafeNativeMethods.sqlite3_column_name16_interop(stmt._sqlite_stmt, index, out nbytelen), nbytelen);
		}

		// Token: 0x0600B2BA RID: 45754 RVA: 0x004F1B84 File Offset: 0x004EFD84
		internal override string GetText(SQLiteStatement stmt, int index)
		{
			int nbytelen;
			return SQLite3_UTF16.UTF16ToString(UnsafeNativeMethods.sqlite3_column_text16_interop(stmt._sqlite_stmt, index, out nbytelen), nbytelen);
		}

		// Token: 0x0600B2BB RID: 45755 RVA: 0x004F1BAC File Offset: 0x004EFDAC
		internal override string ColumnOriginalName(SQLiteStatement stmt, int index)
		{
			int nbytelen;
			return SQLite3_UTF16.UTF16ToString(UnsafeNativeMethods.sqlite3_column_origin_name16_interop(stmt._sqlite_stmt, index, out nbytelen), nbytelen);
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x004F1BD4 File Offset: 0x004EFDD4
		internal override string ColumnDatabaseName(SQLiteStatement stmt, int index)
		{
			int nbytelen;
			return SQLite3_UTF16.UTF16ToString(UnsafeNativeMethods.sqlite3_column_database_name16_interop(stmt._sqlite_stmt, index, out nbytelen), nbytelen);
		}

		// Token: 0x0600B2BD RID: 45757 RVA: 0x004F1BFC File Offset: 0x004EFDFC
		internal override string ColumnTableName(SQLiteStatement stmt, int index)
		{
			int nbytelen;
			return SQLite3_UTF16.UTF16ToString(UnsafeNativeMethods.sqlite3_column_table_name16_interop(stmt._sqlite_stmt, index, out nbytelen), nbytelen);
		}

		// Token: 0x0600B2BE RID: 45758 RVA: 0x004F1C24 File Offset: 0x004EFE24
		internal override string GetParamValueText(IntPtr ptr)
		{
			int nbytelen;
			return SQLite3_UTF16.UTF16ToString(UnsafeNativeMethods.sqlite3_value_text16_interop(ptr, out nbytelen), nbytelen);
		}

		// Token: 0x0600B2BF RID: 45759 RVA: 0x00054E09 File Offset: 0x00053009
		internal override void ReturnError(IntPtr context, string value)
		{
			UnsafeNativeMethods.sqlite3_result_error16(context, value, value.Length * 2);
		}

		// Token: 0x0600B2C0 RID: 45760 RVA: 0x00054E1A File Offset: 0x0005301A
		internal override void ReturnText(IntPtr context, string value)
		{
			UnsafeNativeMethods.sqlite3_result_text16(context, value, value.Length * 2, (IntPtr)(-1));
		}
	}
}

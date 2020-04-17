using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Data.SQLite
{
	// Token: 0x02001430 RID: 5168
	public abstract class SQLiteConvert
	{
		// Token: 0x0600B13C RID: 45372 RVA: 0x000543ED File Offset: 0x000525ED
		internal SQLiteConvert(SQLiteDateFormats fmt)
		{
			this._datetimeFormat = fmt;
		}

		// Token: 0x0600B13D RID: 45373 RVA: 0x004EBFDC File Offset: 0x004EA1DC
		public static byte[] ToUTF8(string sourceText)
		{
			int num = SQLiteConvert._utf8.GetByteCount(sourceText) + 1;
			byte[] array = new byte[num];
			num = SQLiteConvert._utf8.GetBytes(sourceText, 0, sourceText.Length, array, 0);
			array[num] = 0;
			return array;
		}

		// Token: 0x0600B13E RID: 45374 RVA: 0x000543FC File Offset: 0x000525FC
		public byte[] ToUTF8(DateTime dateTimeValue)
		{
			return SQLiteConvert.ToUTF8(this.ToString(dateTimeValue));
		}

		// Token: 0x0600B13F RID: 45375 RVA: 0x0005440A File Offset: 0x0005260A
		public virtual string ToString(IntPtr nativestring, int nativestringlen)
		{
			return SQLiteConvert.UTF8ToString(nativestring, nativestringlen);
		}

		// Token: 0x0600B140 RID: 45376 RVA: 0x004EC018 File Offset: 0x004EA218
		public static string UTF8ToString(IntPtr nativestring, int nativestringlen)
		{
			if (nativestringlen != 0 && !(nativestring == IntPtr.Zero))
			{
				if (nativestringlen == -1)
				{
					do
					{
						nativestringlen++;
					}
					while (Marshal.ReadByte(nativestring, nativestringlen) != 0);
				}
				byte[] array = new byte[nativestringlen];
				Marshal.Copy(nativestring, array, 0, nativestringlen);
				return SQLiteConvert._utf8.GetString(array, 0, nativestringlen);
			}
			return "";
		}

		// Token: 0x0600B141 RID: 45377 RVA: 0x004EC06C File Offset: 0x004EA26C
		public DateTime ToDateTime(string dateText)
		{
			switch (this._datetimeFormat)
			{
			case SQLiteDateFormats.Ticks:
				return new DateTime(Convert.ToInt64(dateText, CultureInfo.InvariantCulture));
			case SQLiteDateFormats.JulianDay:
				return this.ToDateTime(Convert.ToDouble(dateText, CultureInfo.InvariantCulture));
			}
			return DateTime.ParseExact(dateText, SQLiteConvert._datetimeFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
		}

		// Token: 0x0600B142 RID: 45378 RVA: 0x00054413 File Offset: 0x00052613
		public DateTime ToDateTime(double julianDay)
		{
			return DateTime.FromOADate(julianDay - 2415018.5);
		}

		// Token: 0x0600B143 RID: 45379 RVA: 0x00054425 File Offset: 0x00052625
		public double ToJulianDay(DateTime value)
		{
			return value.ToOADate() + 2415018.5;
		}

		// Token: 0x0600B144 RID: 45380 RVA: 0x004EC0C8 File Offset: 0x004EA2C8
		public string ToString(DateTime dateValue)
		{
			switch (this._datetimeFormat)
			{
			case SQLiteDateFormats.Ticks:
				return dateValue.Ticks.ToString(CultureInfo.InvariantCulture);
			case SQLiteDateFormats.JulianDay:
				return this.ToJulianDay(dateValue).ToString(CultureInfo.InvariantCulture);
			}
			return dateValue.ToString(SQLiteConvert._datetimeFormats[7], CultureInfo.InvariantCulture);
		}

		// Token: 0x0600B145 RID: 45381 RVA: 0x00054438 File Offset: 0x00052638
		internal DateTime ToDateTime(IntPtr ptr, int len)
		{
			return this.ToDateTime(this.ToString(ptr, len));
		}

		// Token: 0x0600B146 RID: 45382 RVA: 0x004EC130 File Offset: 0x004EA330
		public static string[] Split(string source, char separator)
		{
			char[] array = new char[]
			{
				'"',
				separator
			};
			char[] array2 = new char[]
			{
				'"'
			};
			int num = 0;
			List<string> list = new List<string>();
			while (source.Length > 0)
			{
				num = source.IndexOfAny(array, num);
				if (num == -1)
				{
					break;
				}
				if (source[num] == array[0])
				{
					num = source.IndexOfAny(array2, num + 1);
					if (num == -1)
					{
						break;
					}
					num++;
				}
				else
				{
					string text = source.Substring(0, num).Trim();
					if (text.Length > 1 && text[0] == array2[0] && text[text.Length - 1] == text[0])
					{
						text = text.Substring(1, text.Length - 2);
					}
					source = source.Substring(num + 1).Trim();
					if (text.Length > 0)
					{
						list.Add(text);
					}
					num = 0;
				}
			}
			if (source.Length > 0)
			{
				string text = source.Trim();
				if (text.Length > 1 && text[0] == array2[0] && text[text.Length - 1] == text[0])
				{
					text = text.Substring(1, text.Length - 2);
				}
				list.Add(text);
			}
			string[] array3 = new string[list.Count];
			list.CopyTo(array3, 0);
			return array3;
		}

		// Token: 0x0600B147 RID: 45383 RVA: 0x00054448 File Offset: 0x00052648
		public static bool ToBoolean(object source)
		{
			if (source is bool)
			{
				return (bool)source;
			}
			return SQLiteConvert.ToBoolean(source.ToString());
		}

		// Token: 0x0600B148 RID: 45384 RVA: 0x004EC288 File Offset: 0x004EA488
		public static bool ToBoolean(string source)
		{
			if (string.Compare(source, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
			if (string.Compare(source, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return false;
			}
			string key;
			switch (key = source.ToLower(CultureInfo.InvariantCulture))
			{
			case "yes":
			case "y":
			case "1":
			case "on":
				return true;
			case "no":
			case "n":
			case "0":
			case "off":
				return false;
			}
			throw new ArgumentException("source");
		}

		// Token: 0x0600B149 RID: 45385 RVA: 0x00054464 File Offset: 0x00052664
		internal static void ColumnToType(SQLiteStatement stmt, int i, SQLiteType typ)
		{
			typ.Type = SQLiteConvert.TypeNameToDbType(stmt._sql.ColumnType(stmt, i, out typ.Affinity));
		}

		// Token: 0x0600B14A RID: 45386 RVA: 0x00054484 File Offset: 0x00052684
		internal static Type SQLiteTypeToType(SQLiteType t)
		{
			if (t.Type == DbType.Object)
			{
				return SQLiteConvert._affinitytotype[(int)t.Affinity];
			}
			return SQLiteConvert.DbTypeToType(t.Type);
		}

		// Token: 0x0600B14B RID: 45387 RVA: 0x004EC384 File Offset: 0x004EA584
		internal static DbType TypeToDbType(Type typ)
		{
			TypeCode typeCode = Type.GetTypeCode(typ);
			if (typeCode != TypeCode.Object)
			{
				return SQLiteConvert._typetodbtype[(int)typeCode];
			}
			if (typ == typeof(byte[]))
			{
				return DbType.Binary;
			}
			if (typ == typeof(Guid))
			{
				return DbType.Guid;
			}
			return DbType.String;
		}

		// Token: 0x0600B14C RID: 45388 RVA: 0x000544A8 File Offset: 0x000526A8
		internal static int DbTypeToColumnSize(DbType typ)
		{
			return SQLiteConvert._dbtypetocolumnsize[(int)typ];
		}

		// Token: 0x0600B14D RID: 45389 RVA: 0x000544B1 File Offset: 0x000526B1
		internal static object DbTypeToNumericPrecision(DbType typ)
		{
			return SQLiteConvert._dbtypetonumericprecision[(int)typ];
		}

		// Token: 0x0600B14E RID: 45390 RVA: 0x000544BA File Offset: 0x000526BA
		internal static object DbTypeToNumericScale(DbType typ)
		{
			return SQLiteConvert._dbtypetonumericscale[(int)typ];
		}

		// Token: 0x0600B14F RID: 45391 RVA: 0x004EC3C8 File Offset: 0x004EA5C8
		internal static string DbTypeToTypeName(DbType typ)
		{
			for (int i = 0; i < SQLiteConvert._dbtypeNames.Length; i++)
			{
				if (SQLiteConvert._dbtypeNames[i].dataType == typ)
				{
					return SQLiteConvert._dbtypeNames[i].typeName;
				}
			}
			return string.Empty;
		}

		// Token: 0x0600B150 RID: 45392 RVA: 0x000544C3 File Offset: 0x000526C3
		internal static Type DbTypeToType(DbType typ)
		{
			return SQLiteConvert._dbtypeToType[(int)typ];
		}

		// Token: 0x0600B151 RID: 45393 RVA: 0x004EC414 File Offset: 0x004EA614
		internal static TypeAffinity TypeToAffinity(Type typ)
		{
			TypeCode typeCode = Type.GetTypeCode(typ);
			if (typeCode == TypeCode.Object)
			{
				if (typ != typeof(byte[]))
				{
					if (typ != typeof(Guid))
					{
						return TypeAffinity.Text;
					}
				}
				return TypeAffinity.Blob;
			}
			return SQLiteConvert._typecodeAffinities[(int)typeCode];
		}

		// Token: 0x0600B152 RID: 45394 RVA: 0x004EC454 File Offset: 0x004EA654
		internal static DbType TypeNameToDbType(string Name)
		{
			if (string.IsNullOrEmpty(Name))
			{
				return DbType.Object;
			}
			int num = SQLiteConvert._typeNames.Length;
			for (int i = 0; i < num; i++)
			{
				if (string.Compare(Name, 0, SQLiteConvert._typeNames[i].typeName, 0, SQLiteConvert._typeNames[i].typeName.Length, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return SQLiteConvert._typeNames[i].dataType;
				}
			}
			return DbType.Object;
		}

		// Token: 0x04005DF6 RID: 24054
		private static string[] _datetimeFormats = new string[]
		{
			"THHmmss",
			"THHmm",
			"HH:mm:ss",
			"HH:mm",
			"HH:mm:ss.FFFFFFF",
			"yy-MM-dd",
			"yyyy-MM-dd",
			"yyyy-MM-dd HH:mm:ss.FFFFFFF",
			"yyyy-MM-dd HH:mm:ss",
			"yyyy-MM-dd HH:mm",
			"yyyy-MM-ddTHH:mm:ss.FFFFFFF",
			"yyyy-MM-ddTHH:mm",
			"yyyy-MM-ddTHH:mm:ss",
			"yyyyMMddHHmmss",
			"yyyyMMddHHmm",
			"yyyyMMddTHHmmssFFFFFFF",
			"yyyyMMdd"
		};

		// Token: 0x04005DF7 RID: 24055
		private static Encoding _utf8 = new UTF8Encoding();

		// Token: 0x04005DF8 RID: 24056
		internal SQLiteDateFormats _datetimeFormat;

		// Token: 0x04005DF9 RID: 24057
		private static Type[] _affinitytotype = new Type[]
		{
			typeof(object),
			typeof(long),
			typeof(double),
			typeof(string),
			typeof(byte[]),
			typeof(object),
			typeof(DateTime),
			typeof(object)
		};

		// Token: 0x04005DFA RID: 24058
		private static DbType[] _typetodbtype = new DbType[]
		{
			DbType.Object,
			DbType.Binary,
			DbType.Object,
			DbType.Boolean,
			DbType.SByte,
			DbType.SByte,
			DbType.Byte,
			DbType.Int16,
			DbType.UInt16,
			DbType.Int32,
			DbType.UInt32,
			DbType.Int64,
			DbType.UInt64,
			DbType.Single,
			DbType.Double,
			DbType.Decimal,
			DbType.DateTime,
			DbType.Object,
			DbType.String
		};

		// Token: 0x04005DFB RID: 24059
		private static int[] _dbtypetocolumnsize = new int[]
		{
			2147483647,
			2147483647,
			1,
			1,
			8,
			8,
			8,
			8,
			8,
			16,
			2,
			4,
			8,
			2147483647,
			1,
			4,
			2147483647,
			8,
			2,
			4,
			8,
			8,
			2147483647,
			2147483647,
			2147483647,
			2147483647
		};

		// Token: 0x04005DFC RID: 24060
		private static object[] _dbtypetonumericprecision = new object[]
		{
			DBNull.Value,
			DBNull.Value,
			3,
			DBNull.Value,
			19,
			DBNull.Value,
			DBNull.Value,
			53,
			53,
			DBNull.Value,
			5,
			10,
			19,
			DBNull.Value,
			3,
			24,
			DBNull.Value,
			DBNull.Value,
			5,
			10,
			19,
			53,
			DBNull.Value,
			DBNull.Value,
			DBNull.Value
		};

		// Token: 0x04005DFD RID: 24061
		private static object[] _dbtypetonumericscale = new object[]
		{
			DBNull.Value,
			DBNull.Value,
			0,
			DBNull.Value,
			4,
			DBNull.Value,
			DBNull.Value,
			DBNull.Value,
			DBNull.Value,
			DBNull.Value,
			0,
			0,
			0,
			DBNull.Value,
			0,
			DBNull.Value,
			DBNull.Value,
			DBNull.Value,
			0,
			0,
			0,
			0,
			DBNull.Value,
			DBNull.Value,
			DBNull.Value
		};

		// Token: 0x04005DFE RID: 24062
		private static SQLiteTypeNames[] _dbtypeNames = new SQLiteTypeNames[]
		{
			new SQLiteTypeNames("INTEGER", DbType.Int64),
			new SQLiteTypeNames("TINYINT", DbType.Byte),
			new SQLiteTypeNames("INT", DbType.Int32),
			new SQLiteTypeNames("VARCHAR", DbType.AnsiString),
			new SQLiteTypeNames("NVARCHAR", DbType.String),
			new SQLiteTypeNames("CHAR", DbType.AnsiStringFixedLength),
			new SQLiteTypeNames("NCHAR", DbType.StringFixedLength),
			new SQLiteTypeNames("FLOAT", DbType.Double),
			new SQLiteTypeNames("REAL", DbType.Single),
			new SQLiteTypeNames("BIT", DbType.Boolean),
			new SQLiteTypeNames("DECIMAL", DbType.Decimal),
			new SQLiteTypeNames("DATETIME", DbType.DateTime),
			new SQLiteTypeNames("BLOB", DbType.Binary),
			new SQLiteTypeNames("UNIQUEIDENTIFIER", DbType.Guid),
			new SQLiteTypeNames("SMALLINT", DbType.Int16)
		};

		// Token: 0x04005DFF RID: 24063
		private static Type[] _dbtypeToType = new Type[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(byte),
			typeof(bool),
			typeof(decimal),
			typeof(DateTime),
			typeof(DateTime),
			typeof(decimal),
			typeof(double),
			typeof(Guid),
			typeof(short),
			typeof(int),
			typeof(long),
			typeof(object),
			typeof(sbyte),
			typeof(float),
			typeof(string),
			typeof(DateTime),
			typeof(ushort),
			typeof(uint),
			typeof(ulong),
			typeof(double),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		};

		// Token: 0x04005E00 RID: 24064
		private static TypeAffinity[] _typecodeAffinities = new TypeAffinity[]
		{
			TypeAffinity.Null,
			TypeAffinity.Blob,
			TypeAffinity.Null,
			TypeAffinity.Int64,
			TypeAffinity.Int64,
			TypeAffinity.Int64,
			TypeAffinity.Int64,
			TypeAffinity.Int64,
			TypeAffinity.Int64,
			TypeAffinity.Int64,
			TypeAffinity.Int64,
			TypeAffinity.Int64,
			TypeAffinity.Int64,
			TypeAffinity.Double,
			TypeAffinity.Double,
			TypeAffinity.Double,
			TypeAffinity.DateTime,
			TypeAffinity.Null,
			TypeAffinity.Text
		};

		// Token: 0x04005E01 RID: 24065
		private static SQLiteTypeNames[] _typeNames = new SQLiteTypeNames[]
		{
			new SQLiteTypeNames("COUNTER", DbType.Int64),
			new SQLiteTypeNames("AUTOINCREMENT", DbType.Int64),
			new SQLiteTypeNames("IDENTITY", DbType.Int64),
			new SQLiteTypeNames("LONGTEXT", DbType.String),
			new SQLiteTypeNames("LONGCHAR", DbType.String),
			new SQLiteTypeNames("LONGVARCHAR", DbType.String),
			new SQLiteTypeNames("LONG", DbType.Int64),
			new SQLiteTypeNames("TINYINT", DbType.Byte),
			new SQLiteTypeNames("INTEGER", DbType.Int64),
			new SQLiteTypeNames("INT", DbType.Int32),
			new SQLiteTypeNames("VARCHAR", DbType.String),
			new SQLiteTypeNames("NVARCHAR", DbType.String),
			new SQLiteTypeNames("CHAR", DbType.String),
			new SQLiteTypeNames("NCHAR", DbType.String),
			new SQLiteTypeNames("TEXT", DbType.String),
			new SQLiteTypeNames("NTEXT", DbType.String),
			new SQLiteTypeNames("STRING", DbType.String),
			new SQLiteTypeNames("DOUBLE", DbType.Double),
			new SQLiteTypeNames("FLOAT", DbType.Double),
			new SQLiteTypeNames("REAL", DbType.Single),
			new SQLiteTypeNames("BIT", DbType.Boolean),
			new SQLiteTypeNames("YESNO", DbType.Boolean),
			new SQLiteTypeNames("LOGICAL", DbType.Boolean),
			new SQLiteTypeNames("BOOL", DbType.Boolean),
			new SQLiteTypeNames("NUMERIC", DbType.Decimal),
			new SQLiteTypeNames("DECIMAL", DbType.Decimal),
			new SQLiteTypeNames("MONEY", DbType.Decimal),
			new SQLiteTypeNames("CURRENCY", DbType.Decimal),
			new SQLiteTypeNames("TIME", DbType.DateTime),
			new SQLiteTypeNames("DATE", DbType.DateTime),
			new SQLiteTypeNames("SMALLDATE", DbType.DateTime),
			new SQLiteTypeNames("BLOB", DbType.Binary),
			new SQLiteTypeNames("BINARY", DbType.Binary),
			new SQLiteTypeNames("VARBINARY", DbType.Binary),
			new SQLiteTypeNames("IMAGE", DbType.Binary),
			new SQLiteTypeNames("GENERAL", DbType.Binary),
			new SQLiteTypeNames("OLEOBJECT", DbType.Binary),
			new SQLiteTypeNames("GUID", DbType.Guid),
			new SQLiteTypeNames("UNIQUEIDENTIFIER", DbType.Guid),
			new SQLiteTypeNames("MEMO", DbType.String),
			new SQLiteTypeNames("NOTE", DbType.String),
			new SQLiteTypeNames("SMALLINT", DbType.Int16),
			new SQLiteTypeNames("BIGINT", DbType.Int64)
		};
	}
}

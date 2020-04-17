using System;
using System.Globalization;

namespace System.Data.SQLite
{
	// Token: 0x02001439 RID: 5177
	internal sealed class SQLiteStatement : IDisposable
	{
		// Token: 0x0600B1A4 RID: 45476 RVA: 0x004ED194 File Offset: 0x004EB394
		internal SQLiteStatement(SQLiteBase sqlbase, SQLiteStatementHandle stmt, string strCommand, SQLiteStatement previous)
		{
			this._sql = sqlbase;
			this._sqlite_stmt = stmt;
			this._sqlStatement = strCommand;
			int num = 0;
			int num2 = this._sql.Bind_ParamCount(this);
			if (num2 > 0)
			{
				if (previous != null)
				{
					num = previous._unnamedParameters;
				}
				this._paramNames = new string[num2];
				this._paramValues = new SQLiteParameter[num2];
				for (int i = 0; i < num2; i++)
				{
					string text = this._sql.Bind_ParamName(this, i + 1);
					if (string.IsNullOrEmpty(text))
					{
						text = string.Format(CultureInfo.InvariantCulture, ";{0}", new object[]
						{
							num
						});
						num++;
						this._unnamedParameters++;
					}
					this._paramNames[i] = text;
					this._paramValues[i] = null;
				}
			}
		}

		// Token: 0x0600B1A5 RID: 45477 RVA: 0x004ED264 File Offset: 0x004EB464
		internal bool MapParameter(string s, SQLiteParameter p)
		{
			if (this._paramNames == null)
			{
				return false;
			}
			int num = 0;
			if (s.Length > 0 && ":$@;".IndexOf(s[0]) == -1)
			{
				num = 1;
			}
			int num2 = this._paramNames.Length;
			for (int i = 0; i < num2; i++)
			{
				if (string.Compare(this._paramNames[i], num, s, 0, Math.Max(this._paramNames[i].Length - num, s.Length), StringComparison.OrdinalIgnoreCase) == 0)
				{
					this._paramValues[i] = p;
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600B1A6 RID: 45478 RVA: 0x00054510 File Offset: 0x00052710
		public void Dispose()
		{
			if (this._sqlite_stmt != null)
			{
				this._sqlite_stmt.Dispose();
			}
			this._sqlite_stmt = null;
			this._paramNames = null;
			this._paramValues = null;
			this._sql = null;
			this._sqlStatement = null;
		}

		// Token: 0x0600B1A7 RID: 45479 RVA: 0x004ED2EC File Offset: 0x004EB4EC
		internal void BindParameters()
		{
			if (this._paramNames == null)
			{
				return;
			}
			int num = this._paramNames.Length;
			for (int i = 0; i < num; i++)
			{
				this.BindParameter(i + 1, this._paramValues[i]);
			}
		}

		// Token: 0x0600B1A8 RID: 45480 RVA: 0x004ED328 File Offset: 0x004EB528
		private void BindParameter(int index, SQLiteParameter param)
		{
			if (param == null)
			{
				throw new SQLiteException(1, "Insufficient parameters supplied to the command");
			}
			object value = param.Value;
			DbType dbType = param.DbType;
			if (!Convert.IsDBNull(value) && value != null)
			{
				if (dbType == DbType.Object)
				{
					dbType = SQLiteConvert.TypeToDbType(value.GetType());
				}
				switch (dbType)
				{
				case DbType.Binary:
					this._sql.Bind_Blob(this, index, (byte[])value);
					return;
				case DbType.Byte:
				case DbType.Boolean:
				case DbType.Int16:
				case DbType.Int32:
				case DbType.SByte:
				case DbType.UInt16:
				case DbType.UInt32:
					this._sql.Bind_Int32(this, index, Convert.ToInt32(value, CultureInfo.CurrentCulture));
					return;
				case DbType.Currency:
				case DbType.Double:
				case DbType.Single:
					this._sql.Bind_Double(this, index, Convert.ToDouble(value, CultureInfo.CurrentCulture));
					return;
				case DbType.Date:
				case DbType.DateTime:
				case DbType.Time:
					this._sql.Bind_DateTime(this, index, Convert.ToDateTime(value, CultureInfo.CurrentCulture));
					return;
				case DbType.Decimal:
					this._sql.Bind_Text(this, index, Convert.ToDecimal(value, CultureInfo.CurrentCulture).ToString(CultureInfo.InvariantCulture));
					return;
				case DbType.Guid:
					if (this._command.Connection._binaryGuid)
					{
						this._sql.Bind_Blob(this, index, ((Guid)value).ToByteArray());
						return;
					}
					this._sql.Bind_Text(this, index, value.ToString());
					return;
				case DbType.Int64:
				case DbType.UInt64:
					this._sql.Bind_Int64(this, index, Convert.ToInt64(value, CultureInfo.CurrentCulture));
					return;
				}
				this._sql.Bind_Text(this, index, value.ToString());
				return;
			}
			this._sql.Bind_Null(this, index);
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x0600B1A9 RID: 45481 RVA: 0x00054548 File Offset: 0x00052748
		internal string[] TypeDefinitions
		{
			get
			{
				return this._types;
			}
		}

		// Token: 0x0600B1AA RID: 45482 RVA: 0x004ED4D8 File Offset: 0x004EB6D8
		internal void SetTypes(string typedefs)
		{
			int num = typedefs.IndexOf("TYPES", 0, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				throw new ArgumentOutOfRangeException();
			}
			string[] array = typedefs.Substring(num + 6).Replace(" ", "").Replace(";", "").Replace("\"", "").Replace("[", "").Replace("]", "").Replace("`", "").Split(new char[]
			{
				',',
				'\r',
				'\n',
				'\t'
			});
			for (int i = 0; i < array.Length; i++)
			{
				if (string.IsNullOrEmpty(array[i]))
				{
					array[i] = null;
				}
			}
			this._types = array;
		}

		// Token: 0x04005E1F RID: 24095
		internal SQLiteBase _sql;

		// Token: 0x04005E20 RID: 24096
		internal string _sqlStatement;

		// Token: 0x04005E21 RID: 24097
		internal SQLiteStatementHandle _sqlite_stmt;

		// Token: 0x04005E22 RID: 24098
		internal int _unnamedParameters;

		// Token: 0x04005E23 RID: 24099
		internal string[] _paramNames;

		// Token: 0x04005E24 RID: 24100
		internal SQLiteParameter[] _paramValues;

		// Token: 0x04005E25 RID: 24101
		internal SQLiteCommand _command;

		// Token: 0x04005E26 RID: 24102
		private string[] _types;
	}
}

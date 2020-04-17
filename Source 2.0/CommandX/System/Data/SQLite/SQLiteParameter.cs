using System;
using System.ComponentModel;
using System.Data.Common;

namespace System.Data.SQLite
{
	// Token: 0x02001446 RID: 5190
	public sealed class SQLiteParameter : DbParameter, ICloneable
	{
		// Token: 0x0600B2C1 RID: 45761 RVA: 0x00054E31 File Offset: 0x00053031
		public SQLiteParameter() : this(null, (DbType)(-1), 0, null, DataRowVersion.Current)
		{
		}

		// Token: 0x0600B2C2 RID: 45762 RVA: 0x00054E42 File Offset: 0x00053042
		public SQLiteParameter(string parameterName) : this(parameterName, (DbType)(-1), 0, null, DataRowVersion.Current)
		{
		}

		// Token: 0x0600B2C3 RID: 45763 RVA: 0x00054E53 File Offset: 0x00053053
		public SQLiteParameter(string parameterName, object value) : this(parameterName, (DbType)(-1), 0, null, DataRowVersion.Current)
		{
			this.Value = value;
		}

		// Token: 0x0600B2C4 RID: 45764 RVA: 0x00054E6B File Offset: 0x0005306B
		public SQLiteParameter(string parameterName, DbType dbType) : this(parameterName, dbType, 0, null, DataRowVersion.Current)
		{
		}

		// Token: 0x0600B2C5 RID: 45765 RVA: 0x00054E7C File Offset: 0x0005307C
		public SQLiteParameter(string parameterName, DbType dbType, string sourceColumn) : this(parameterName, dbType, 0, sourceColumn, DataRowVersion.Current)
		{
		}

		// Token: 0x0600B2C6 RID: 45766 RVA: 0x00054E8D File Offset: 0x0005308D
		public SQLiteParameter(string parameterName, DbType dbType, string sourceColumn, DataRowVersion rowVersion) : this(parameterName, dbType, 0, sourceColumn, rowVersion)
		{
		}

		// Token: 0x0600B2C7 RID: 45767 RVA: 0x00054E9B File Offset: 0x0005309B
		public SQLiteParameter(DbType dbType) : this(null, dbType, 0, null, DataRowVersion.Current)
		{
		}

		// Token: 0x0600B2C8 RID: 45768 RVA: 0x00054EAC File Offset: 0x000530AC
		public SQLiteParameter(DbType dbType, object value) : this(null, dbType, 0, null, DataRowVersion.Current)
		{
			this.Value = value;
		}

		// Token: 0x0600B2C9 RID: 45769 RVA: 0x00054EC4 File Offset: 0x000530C4
		public SQLiteParameter(DbType dbType, string sourceColumn) : this(null, dbType, 0, sourceColumn, DataRowVersion.Current)
		{
		}

		// Token: 0x0600B2CA RID: 45770 RVA: 0x00054ED5 File Offset: 0x000530D5
		public SQLiteParameter(DbType dbType, string sourceColumn, DataRowVersion rowVersion) : this(null, dbType, 0, sourceColumn, rowVersion)
		{
		}

		// Token: 0x0600B2CB RID: 45771 RVA: 0x00054EE2 File Offset: 0x000530E2
		public SQLiteParameter(string parameterName, DbType parameterType, int parameterSize) : this(parameterName, parameterType, parameterSize, null, DataRowVersion.Current)
		{
		}

		// Token: 0x0600B2CC RID: 45772 RVA: 0x00054EF3 File Offset: 0x000530F3
		public SQLiteParameter(string parameterName, DbType parameterType, int parameterSize, string sourceColumn) : this(parameterName, parameterType, parameterSize, sourceColumn, DataRowVersion.Current)
		{
		}

		// Token: 0x0600B2CD RID: 45773 RVA: 0x00054F05 File Offset: 0x00053105
		public SQLiteParameter(string parameterName, DbType parameterType, int parameterSize, string sourceColumn, DataRowVersion rowVersion)
		{
			this._parameterName = parameterName;
			this._dbType = (int)parameterType;
			this._sourceColumn = sourceColumn;
			this._rowVersion = rowVersion;
			this._dataSize = parameterSize;
			this._nullable = true;
		}

		// Token: 0x0600B2CE RID: 45774 RVA: 0x004F1C40 File Offset: 0x004EFE40
		private SQLiteParameter(SQLiteParameter source) : this(source.ParameterName, (DbType)source._dbType, 0, source.Direction, source.IsNullable, 0, 0, source.SourceColumn, source.SourceVersion, source.Value)
		{
			this._nullMapping = source._nullMapping;
		}

		// Token: 0x0600B2CF RID: 45775 RVA: 0x00054F39 File Offset: 0x00053139
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public SQLiteParameter(string parameterName, DbType parameterType, int parameterSize, ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, DataRowVersion rowVersion, object value) : this(parameterName, parameterType, parameterSize, sourceColumn, rowVersion)
		{
			this.Direction = direction;
			this.IsNullable = isNullable;
			this.Value = value;
		}

		// Token: 0x0600B2D0 RID: 45776 RVA: 0x00054F60 File Offset: 0x00053160
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public SQLiteParameter(string parameterName, DbType parameterType, int parameterSize, ParameterDirection direction, byte precision, byte scale, string sourceColumn, DataRowVersion rowVersion, bool sourceColumnNullMapping, object value) : this(parameterName, parameterType, parameterSize, sourceColumn, rowVersion)
		{
			this.Direction = direction;
			this.SourceColumnNullMapping = sourceColumnNullMapping;
			this.Value = value;
		}

		// Token: 0x0600B2D1 RID: 45777 RVA: 0x00054F87 File Offset: 0x00053187
		public SQLiteParameter(DbType parameterType, int parameterSize) : this(null, parameterType, parameterSize, null, DataRowVersion.Current)
		{
		}

		// Token: 0x0600B2D2 RID: 45778 RVA: 0x00054F98 File Offset: 0x00053198
		public SQLiteParameter(DbType parameterType, int parameterSize, string sourceColumn) : this(null, parameterType, parameterSize, sourceColumn, DataRowVersion.Current)
		{
		}

		// Token: 0x0600B2D3 RID: 45779 RVA: 0x00054FA9 File Offset: 0x000531A9
		public SQLiteParameter(DbType parameterType, int parameterSize, string sourceColumn, DataRowVersion rowVersion) : this(null, parameterType, parameterSize, sourceColumn, rowVersion)
		{
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x0600B2D4 RID: 45780 RVA: 0x00054FB7 File Offset: 0x000531B7
		// (set) Token: 0x0600B2D5 RID: 45781 RVA: 0x00054FBF File Offset: 0x000531BF
		public override bool IsNullable
		{
			get
			{
				return this._nullable;
			}
			set
			{
				this._nullable = value;
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x0600B2D6 RID: 45782 RVA: 0x00054FC8 File Offset: 0x000531C8
		// (set) Token: 0x0600B2D7 RID: 45783 RVA: 0x00055002 File Offset: 0x00053202
		[RefreshProperties(RefreshProperties.All), DbProviderSpecificTypeProperty(true)]
		public override DbType DbType
		{
			get
			{
				if (this._dbType != -1)
				{
					return (DbType)this._dbType;
				}
				if (this._objValue != null && this._objValue != DBNull.Value)
				{
					return SQLiteConvert.TypeToDbType(this._objValue.GetType());
				}
				return DbType.String;
			}
			set
			{
				this._dbType = (int)value;
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x0600B2D8 RID: 45784 RVA: 0x0000945D File Offset: 0x0000765D
		// (set) Token: 0x0600B2D9 RID: 45785 RVA: 0x00054B07 File Offset: 0x00052D07
		public override ParameterDirection Direction
		{
			get
			{
				return ParameterDirection.Input;
			}
			set
			{
				if (value != ParameterDirection.Input)
				{
					throw new NotSupportedException();
				}
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x0600B2DA RID: 45786 RVA: 0x0005500B File Offset: 0x0005320B
		// (set) Token: 0x0600B2DB RID: 45787 RVA: 0x00055013 File Offset: 0x00053213
		public override string ParameterName
		{
			get
			{
				return this._parameterName;
			}
			set
			{
				this._parameterName = value;
			}
		}

		// Token: 0x0600B2DC RID: 45788 RVA: 0x0005501C File Offset: 0x0005321C
		public override void ResetDbType()
		{
			this._dbType = -1;
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x0600B2DD RID: 45789 RVA: 0x00055025 File Offset: 0x00053225
		// (set) Token: 0x0600B2DE RID: 45790 RVA: 0x0005502D File Offset: 0x0005322D
		[DefaultValue(0)]
		public override int Size
		{
			get
			{
				return this._dataSize;
			}
			set
			{
				this._dataSize = value;
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x0600B2DF RID: 45791 RVA: 0x00055036 File Offset: 0x00053236
		// (set) Token: 0x0600B2E0 RID: 45792 RVA: 0x0005503E File Offset: 0x0005323E
		public override string SourceColumn
		{
			get
			{
				return this._sourceColumn;
			}
			set
			{
				this._sourceColumn = value;
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x0600B2E1 RID: 45793 RVA: 0x00055047 File Offset: 0x00053247
		// (set) Token: 0x0600B2E2 RID: 45794 RVA: 0x0005504F File Offset: 0x0005324F
		public override bool SourceColumnNullMapping
		{
			get
			{
				return this._nullMapping;
			}
			set
			{
				this._nullMapping = value;
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x0600B2E3 RID: 45795 RVA: 0x00055058 File Offset: 0x00053258
		// (set) Token: 0x0600B2E4 RID: 45796 RVA: 0x00055060 File Offset: 0x00053260
		public override DataRowVersion SourceVersion
		{
			get
			{
				return this._rowVersion;
			}
			set
			{
				this._rowVersion = value;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x0600B2E5 RID: 45797 RVA: 0x00055069 File Offset: 0x00053269
		// (set) Token: 0x0600B2E6 RID: 45798 RVA: 0x00055071 File Offset: 0x00053271
		[RefreshProperties(RefreshProperties.All), TypeConverter(typeof(StringConverter))]
		public override object Value
		{
			get
			{
				return this._objValue;
			}
			set
			{
				this._objValue = value;
				if (this._dbType == -1 && this._objValue != null && this._objValue != DBNull.Value)
				{
					this._dbType = (int)SQLiteConvert.TypeToDbType(this._objValue.GetType());
				}
			}
		}

		// Token: 0x0600B2E7 RID: 45799 RVA: 0x004F1C8C File Offset: 0x004EFE8C
		public object Clone()
		{
			return new SQLiteParameter(this);
		}

		// Token: 0x04005E5F RID: 24159
		internal int _dbType;

		// Token: 0x04005E60 RID: 24160
		private DataRowVersion _rowVersion;

		// Token: 0x04005E61 RID: 24161
		private object _objValue;

		// Token: 0x04005E62 RID: 24162
		private string _sourceColumn;

		// Token: 0x04005E63 RID: 24163
		private string _parameterName;

		// Token: 0x04005E64 RID: 24164
		private int _dataSize;

		// Token: 0x04005E65 RID: 24165
		private bool _nullable;

		// Token: 0x04005E66 RID: 24166
		private bool _nullMapping;
	}
}

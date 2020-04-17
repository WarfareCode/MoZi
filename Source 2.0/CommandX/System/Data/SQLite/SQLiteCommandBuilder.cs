using System;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;

namespace System.Data.SQLite
{
	// Token: 0x02001412 RID: 5138
	public sealed class SQLiteCommandBuilder : DbCommandBuilder
	{
		// Token: 0x0600B023 RID: 45091 RVA: 0x00053C32 File Offset: 0x00051E32
		public SQLiteCommandBuilder() : this(null)
		{
		}

		// Token: 0x0600B024 RID: 45092 RVA: 0x00053C3B File Offset: 0x00051E3B
		public SQLiteCommandBuilder(SQLiteDataAdapter adp)
		{
			this.QuotePrefix = "[";
			this.QuoteSuffix = "]";
			this.DataAdapter = adp;
		}

		// Token: 0x0600B025 RID: 45093 RVA: 0x004E7158 File Offset: 0x004E5358
		protected override void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause)
		{
			SQLiteParameter sQLiteParameter = (SQLiteParameter)parameter;
			sQLiteParameter.DbType = (DbType)row[SchemaTableColumn.ProviderType];
		}

		// Token: 0x0600B026 RID: 45094 RVA: 0x004E7184 File Offset: 0x004E5384
		protected override string GetParameterName(string parameterName)
		{
			return string.Format(CultureInfo.InvariantCulture, "@{0}", new object[]
			{
				parameterName
			});
		}

		// Token: 0x0600B027 RID: 45095 RVA: 0x004E71AC File Offset: 0x004E53AC
		protected override string GetParameterName(int parameterOrdinal)
		{
			return string.Format(CultureInfo.InvariantCulture, "@param{0}", new object[]
			{
				parameterOrdinal
			});
		}

		// Token: 0x0600B028 RID: 45096 RVA: 0x00053C60 File Offset: 0x00051E60
		protected override string GetParameterPlaceholder(int parameterOrdinal)
		{
			return this.GetParameterName(parameterOrdinal);
		}

		// Token: 0x0600B029 RID: 45097 RVA: 0x00053C69 File Offset: 0x00051E69
		protected override void SetRowUpdatingHandler(DbDataAdapter adapter)
		{
			if (adapter == base.DataAdapter)
			{
				((SQLiteDataAdapter)adapter).RowUpdating -= new EventHandler<RowUpdatingEventArgs>(this.RowUpdatingEventHandler);
				return;
			}
			((SQLiteDataAdapter)adapter).RowUpdating += new EventHandler<RowUpdatingEventArgs>(this.RowUpdatingEventHandler);
		}

		// Token: 0x0600B02A RID: 45098 RVA: 0x00053CA3 File Offset: 0x00051EA3
		private void RowUpdatingEventHandler(object sender, RowUpdatingEventArgs e)
		{
			base.RowUpdatingHandler(e);
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x0600B02B RID: 45099 RVA: 0x00053CAC File Offset: 0x00051EAC
		// (set) Token: 0x0600B02C RID: 45100 RVA: 0x00053CB9 File Offset: 0x00051EB9
		public new SQLiteDataAdapter DataAdapter
		{
			get
			{
				return (SQLiteDataAdapter)base.DataAdapter;
			}
			set
			{
				base.DataAdapter = value;
			}
		}

		// Token: 0x0600B02D RID: 45101 RVA: 0x00053CC2 File Offset: 0x00051EC2
		public new SQLiteCommand GetDeleteCommand()
		{
			return (SQLiteCommand)base.GetDeleteCommand();
		}

		// Token: 0x0600B02E RID: 45102 RVA: 0x00053CCF File Offset: 0x00051ECF
		public new SQLiteCommand GetDeleteCommand(bool useColumnsForParameterNames)
		{
			return (SQLiteCommand)base.GetDeleteCommand(useColumnsForParameterNames);
		}

		// Token: 0x0600B02F RID: 45103 RVA: 0x00053CDD File Offset: 0x00051EDD
		public new SQLiteCommand GetUpdateCommand()
		{
			return (SQLiteCommand)base.GetUpdateCommand();
		}

		// Token: 0x0600B030 RID: 45104 RVA: 0x00053CEA File Offset: 0x00051EEA
		public new SQLiteCommand GetUpdateCommand(bool useColumnsForParameterNames)
		{
			return (SQLiteCommand)base.GetUpdateCommand(useColumnsForParameterNames);
		}

		// Token: 0x0600B031 RID: 45105 RVA: 0x00053CF8 File Offset: 0x00051EF8
		public new SQLiteCommand GetInsertCommand()
		{
			return (SQLiteCommand)base.GetInsertCommand();
		}

		// Token: 0x0600B032 RID: 45106 RVA: 0x00053D05 File Offset: 0x00051F05
		public new SQLiteCommand GetInsertCommand(bool useColumnsForParameterNames)
		{
			return (SQLiteCommand)base.GetInsertCommand(useColumnsForParameterNames);
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x0600B033 RID: 45107 RVA: 0x00053D13 File Offset: 0x00051F13
		// (set) Token: 0x0600B034 RID: 45108 RVA: 0x00053D1B File Offset: 0x00051F1B
		[Browsable(false)]
		public override CatalogLocation CatalogLocation
		{
			get
			{
				return base.CatalogLocation;
			}
			set
			{
				base.CatalogLocation = value;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x0600B035 RID: 45109 RVA: 0x00053D24 File Offset: 0x00051F24
		// (set) Token: 0x0600B036 RID: 45110 RVA: 0x00053D2C File Offset: 0x00051F2C
		[Browsable(false)]
		public override string CatalogSeparator
		{
			get
			{
				return base.CatalogSeparator;
			}
			set
			{
				base.CatalogSeparator = value;
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x0600B037 RID: 45111 RVA: 0x00053D35 File Offset: 0x00051F35
		// (set) Token: 0x0600B038 RID: 45112 RVA: 0x00053D3D File Offset: 0x00051F3D
		[Browsable(false), DefaultValue("[")]
		public override string QuotePrefix
		{
			get
			{
				return base.QuotePrefix;
			}
			set
			{
				base.QuotePrefix = value;
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x0600B039 RID: 45113 RVA: 0x00053D46 File Offset: 0x00051F46
		// (set) Token: 0x0600B03A RID: 45114 RVA: 0x00053D4E File Offset: 0x00051F4E
		[Browsable(false)]
		public override string QuoteSuffix
		{
			get
			{
				return base.QuoteSuffix;
			}
			set
			{
				base.QuoteSuffix = value;
			}
		}

		// Token: 0x0600B03B RID: 45115 RVA: 0x004E71DC File Offset: 0x004E53DC
		public override string QuoteIdentifier(string unquotedIdentifier)
		{
			if (!string.IsNullOrEmpty(this.QuotePrefix) && !string.IsNullOrEmpty(this.QuoteSuffix) && !string.IsNullOrEmpty(unquotedIdentifier))
			{
				return this.QuotePrefix + unquotedIdentifier.Replace(this.QuoteSuffix, this.QuoteSuffix + this.QuoteSuffix) + this.QuoteSuffix;
			}
			return unquotedIdentifier;
		}

		// Token: 0x0600B03C RID: 45116 RVA: 0x004E723C File Offset: 0x004E543C
		public override string UnquoteIdentifier(string quotedIdentifier)
		{
			if (string.IsNullOrEmpty(this.QuotePrefix) || string.IsNullOrEmpty(this.QuoteSuffix) || string.IsNullOrEmpty(quotedIdentifier))
			{
				return quotedIdentifier;
			}
			if (quotedIdentifier.StartsWith(this.QuotePrefix, StringComparison.OrdinalIgnoreCase) && quotedIdentifier.EndsWith(this.QuoteSuffix, StringComparison.OrdinalIgnoreCase))
			{
				return quotedIdentifier.Substring(this.QuotePrefix.Length, quotedIdentifier.Length - (this.QuotePrefix.Length + this.QuoteSuffix.Length)).Replace(this.QuoteSuffix + this.QuoteSuffix, this.QuoteSuffix);
			}
			return quotedIdentifier;
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x0600B03D RID: 45117 RVA: 0x00053D57 File Offset: 0x00051F57
		// (set) Token: 0x0600B03E RID: 45118 RVA: 0x00053D5F File Offset: 0x00051F5F
		[Browsable(false)]
		public override string SchemaSeparator
		{
			get
			{
				return base.SchemaSeparator;
			}
			set
			{
				base.SchemaSeparator = value;
			}
		}

		// Token: 0x0600B03F RID: 45119 RVA: 0x004E72DC File Offset: 0x004E54DC
		protected override DataTable GetSchemaTable(DbCommand sourceCommand)
		{
			DataTable result;
			using (IDataReader dataReader = sourceCommand.ExecuteReader(CommandBehavior.SchemaOnly | CommandBehavior.KeyInfo))
			{
				DataTable schemaTable = dataReader.GetSchemaTable();
				if (this.HasSchemaPrimaryKey(schemaTable))
				{
					this.ResetIsUniqueSchemaColumn(schemaTable);
				}
				result = schemaTable;
			}
			return result;
		}

		// Token: 0x0600B040 RID: 45120 RVA: 0x004E7328 File Offset: 0x004E5528
		private bool HasSchemaPrimaryKey(DataTable schema)
		{
			DataColumn column = schema.Columns[SchemaTableColumn.IsKey];
			foreach (DataRow dataRow in schema.Rows)
			{
				if ((bool)dataRow[column])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600B041 RID: 45121 RVA: 0x004E73A4 File Offset: 0x004E55A4
		private void ResetIsUniqueSchemaColumn(DataTable schema)
		{
			DataColumn column = schema.Columns[SchemaTableColumn.IsUnique];
			DataColumn column2 = schema.Columns[SchemaTableColumn.IsKey];
			foreach (DataRow dataRow in schema.Rows)
			{
				if (!(bool)dataRow[column2])
				{
					dataRow[column] = false;
				}
			}
			schema.AcceptChanges();
		}
	}
}

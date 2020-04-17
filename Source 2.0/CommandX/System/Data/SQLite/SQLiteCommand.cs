using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;

namespace System.Data.SQLite
{
	// Token: 0x02001442 RID: 5186
	[Designer("SQLite.Designer.SQLiteCommandDesigner, SQLite.Designer, Version=1.0.37.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139"), ToolboxItem(true)]
	public sealed class SQLiteCommand : DbCommand, ICloneable
	{
		// Token: 0x0600B23A RID: 45626 RVA: 0x00054A85 File Offset: 0x00052C85
		public SQLiteCommand() : this(null, null)
		{
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x00054A8F File Offset: 0x00052C8F
		public SQLiteCommand(string commandText) : this(commandText, null, null)
		{
		}

		// Token: 0x0600B23C RID: 45628 RVA: 0x00054A9A File Offset: 0x00052C9A
		public SQLiteCommand(string commandText, SQLiteConnection connection) : this(commandText, connection, null)
		{
		}

		// Token: 0x0600B23D RID: 45629 RVA: 0x00054AA5 File Offset: 0x00052CA5
		public SQLiteCommand(SQLiteConnection connection) : this(null, connection, null)
		{
		}

		// Token: 0x0600B23E RID: 45630 RVA: 0x004F068C File Offset: 0x004EE88C
		private SQLiteCommand(SQLiteCommand source) : this(source.CommandText, source.Connection, source.Transaction)
		{
			this.CommandTimeout = source.CommandTimeout;
			this.DesignTimeVisible = source.DesignTimeVisible;
			this.UpdatedRowSource = source.UpdatedRowSource;
			foreach (SQLiteParameter sQLiteParameter in source._parameterCollection)
			{
				this.Parameters.Add(sQLiteParameter.Clone());
			}
		}

		// Token: 0x0600B23F RID: 45631 RVA: 0x004F0730 File Offset: 0x004EE930
		public SQLiteCommand(string commandText, SQLiteConnection connection, SQLiteTransaction transaction)
		{
			this._commandTimeout = 30;
			this._parameterCollection = new SQLiteParameterCollection(this);
			this._designTimeVisible = true;
			this._updateRowSource = UpdateRowSource.None;
			if (commandText != null)
			{
				this.CommandText = commandText;
			}
			if (connection != null)
			{
				this.DbConnection = connection;
				this._commandTimeout = connection.DefaultTimeout;
			}
			if (transaction != null)
			{
				this.Transaction = transaction;
			}
		}

		// Token: 0x0600B240 RID: 45632 RVA: 0x004F0790 File Offset: 0x004EE990
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (disposing)
			{
				SQLiteDataReader sQLiteDataReader = null;
				if (this._activeReader != null)
				{
					try
					{
						sQLiteDataReader = (this._activeReader.Target as SQLiteDataReader);
					}
					catch (InvalidOperationException)
					{
					}
				}
				if (sQLiteDataReader != null)
				{
					sQLiteDataReader._disposeCommand = true;
					this._activeReader = null;
					return;
				}
				this.Connection = null;
				this._parameterCollection.Clear();
				this._commandText = null;
			}
		}

		// Token: 0x0600B241 RID: 45633 RVA: 0x004F0804 File Offset: 0x004EEA04
		internal void ClearCommands()
		{
			if (this._activeReader != null)
			{
				SQLiteDataReader sQLiteDataReader = null;
				try
				{
					sQLiteDataReader = (this._activeReader.Target as SQLiteDataReader);
				}
				catch (InvalidOperationException)
				{
				}
				if (sQLiteDataReader != null)
				{
					sQLiteDataReader.Close();
				}
				this._activeReader = null;
			}
			if (this._statementList == null)
			{
				return;
			}
			int count = this._statementList.Count;
			for (int i = 0; i < count; i++)
			{
				this._statementList[i].Dispose();
			}
			this._statementList = null;
			this._parameterCollection.Unbind();
		}

		// Token: 0x0600B242 RID: 45634 RVA: 0x004F0898 File Offset: 0x004EEA98
		internal SQLiteStatement BuildNextCommand()
		{
			SQLiteStatement sQLiteStatement = null;
			SQLiteStatement result;
			try
			{
				if (this._statementList == null)
				{
					this._remainingText = this._commandText;
				}
				sQLiteStatement = this._cnn._sql.Prepare(this._cnn, this._remainingText, (this._statementList == null) ? null : this._statementList[this._statementList.Count - 1], (uint)(this._commandTimeout * 1000), out this._remainingText);
				if (sQLiteStatement != null)
				{
					sQLiteStatement._command = this;
					if (this._statementList == null)
					{
						this._statementList = new List<SQLiteStatement>();
					}
					this._statementList.Add(sQLiteStatement);
					this._parameterCollection.MapParameters(sQLiteStatement);
					sQLiteStatement.BindParameters();
				}
				result = sQLiteStatement;
			}
			catch (Exception)
			{
				if (sQLiteStatement != null)
				{
					if (this._statementList.Contains(sQLiteStatement))
					{
						this._statementList.Remove(sQLiteStatement);
					}
					sQLiteStatement.Dispose();
				}
				this._remainingText = null;
				throw;
			}
			return result;
		}

		// Token: 0x0600B243 RID: 45635 RVA: 0x004F098C File Offset: 0x004EEB8C
		internal SQLiteStatement GetStatement(int index)
		{
			if (this._statementList == null)
			{
				return this.BuildNextCommand();
			}
			if (index != this._statementList.Count)
			{
				SQLiteStatement sQLiteStatement = this._statementList[index];
				sQLiteStatement.BindParameters();
				return sQLiteStatement;
			}
			if (!string.IsNullOrEmpty(this._remainingText))
			{
				return this.BuildNextCommand();
			}
			return null;
		}

		// Token: 0x0600B244 RID: 45636 RVA: 0x004F09E0 File Offset: 0x004EEBE0
		public override void Cancel()
		{
			if (this._activeReader != null)
			{
				SQLiteDataReader sQLiteDataReader = this._activeReader.Target as SQLiteDataReader;
				if (sQLiteDataReader != null)
				{
					sQLiteDataReader.Cancel();
				}
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x0600B245 RID: 45637 RVA: 0x00054AB0 File Offset: 0x00052CB0
		// (set) Token: 0x0600B246 RID: 45638 RVA: 0x00054AB8 File Offset: 0x00052CB8
		[DefaultValue(""), Editor("Microsoft.VSDesigner.Data.SQL.Design.SqlCommandTextEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), RefreshProperties(RefreshProperties.All)]
		public override string CommandText
		{
			get
			{
				return this._commandText;
			}
			set
			{
				if (this._commandText == value)
				{
					return;
				}
				if (this._activeReader != null && this._activeReader.IsAlive)
				{
					throw new InvalidOperationException("Cannot set CommandText while a DataReader is active");
				}
				this.ClearCommands();
				this._commandText = value;
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x0600B247 RID: 45639 RVA: 0x00054AF6 File Offset: 0x00052CF6
		// (set) Token: 0x0600B248 RID: 45640 RVA: 0x00054AFE File Offset: 0x00052CFE
		[DefaultValue(30)]
		public override int CommandTimeout
		{
			get
			{
				return this._commandTimeout;
			}
			set
			{
				this._commandTimeout = value;
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x0600B249 RID: 45641 RVA: 0x0000945D File Offset: 0x0000765D
		// (set) Token: 0x0600B24A RID: 45642 RVA: 0x00054B07 File Offset: 0x00052D07
		[DefaultValue(CommandType.Text), RefreshProperties(RefreshProperties.All)]
		public override CommandType CommandType
		{
			get
			{
				return CommandType.Text;
			}
			set
			{
				if (value != CommandType.Text)
				{
					throw new NotSupportedException();
				}
			}
		}

		// Token: 0x0600B24B RID: 45643 RVA: 0x00054B13 File Offset: 0x00052D13
		protected override DbParameter CreateDbParameter()
		{
			return this.CreateParameter();
		}

		// Token: 0x0600B24C RID: 45644 RVA: 0x00054317 File Offset: 0x00052517
		public new SQLiteParameter CreateParameter()
		{
			return new SQLiteParameter();
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x0600B24D RID: 45645 RVA: 0x00054B1B File Offset: 0x00052D1B
		// (set) Token: 0x0600B24E RID: 45646 RVA: 0x004F0A10 File Offset: 0x004EEC10
		[DefaultValue(null), Editor("Microsoft.VSDesigner.Data.Design.DbConnectionEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public new SQLiteConnection Connection
		{
			get
			{
				return this._cnn;
			}
			set
			{
				if (this._activeReader != null && this._activeReader.IsAlive)
				{
					throw new InvalidOperationException("Cannot set Connection while a DataReader is active");
				}
				if (this._cnn != null)
				{
					this.ClearCommands();
				}
				this._cnn = value;
				if (this._cnn != null)
				{
					this._version = this._cnn._version;
				}
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x0600B24F RID: 45647 RVA: 0x00054B23 File Offset: 0x00052D23
		// (set) Token: 0x0600B250 RID: 45648 RVA: 0x00054B2B File Offset: 0x00052D2B
		protected override DbConnection DbConnection
		{
			get
			{
				return this.Connection;
			}
			set
			{
				this.Connection = (SQLiteConnection)value;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x0600B251 RID: 45649 RVA: 0x00054B39 File Offset: 0x00052D39
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public new SQLiteParameterCollection Parameters
		{
			get
			{
				return this._parameterCollection;
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x0600B252 RID: 45650 RVA: 0x00054B41 File Offset: 0x00052D41
		protected override DbParameterCollection DbParameterCollection
		{
			get
			{
				return this.Parameters;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x0600B253 RID: 45651 RVA: 0x00054B49 File Offset: 0x00052D49
		// (set) Token: 0x0600B254 RID: 45652 RVA: 0x004F0A6C File Offset: 0x004EEC6C
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new SQLiteTransaction Transaction
		{
			get
			{
				return this._transaction;
			}
			set
			{
				if (this._cnn == null)
				{
					if (value != null)
					{
						this.Connection = value.Connection;
					}
					this._transaction = value;
					return;
				}
				if (this._activeReader != null && this._activeReader.IsAlive)
				{
					throw new InvalidOperationException("Cannot set Transaction while a DataReader is active");
				}
				if (value != null && value._cnn != this._cnn)
				{
					throw new ArgumentException("Transaction is not associated with the command's connection");
				}
				this._transaction = value;
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x0600B255 RID: 45653 RVA: 0x00054B51 File Offset: 0x00052D51
		// (set) Token: 0x0600B256 RID: 45654 RVA: 0x00054B59 File Offset: 0x00052D59
		protected override DbTransaction DbTransaction
		{
			get
			{
				return this.Transaction;
			}
			set
			{
				this.Transaction = (SQLiteTransaction)value;
			}
		}

		// Token: 0x0600B257 RID: 45655 RVA: 0x004F0ADC File Offset: 0x004EECDC
		private void InitializeForReader()
		{
			if (this._activeReader != null && this._activeReader.IsAlive)
			{
				throw new InvalidOperationException("DataReader already active on this command");
			}
			if (this._cnn == null)
			{
				throw new InvalidOperationException("No connection associated with this command");
			}
			if (this._cnn.State != ConnectionState.Open)
			{
				throw new InvalidOperationException("Database is not open");
			}
			if (this._cnn._version != this._version)
			{
				this._version = this._cnn._version;
				this.ClearCommands();
			}
			this._parameterCollection.MapParameters(null);
		}

		// Token: 0x0600B258 RID: 45656 RVA: 0x00054B67 File Offset: 0x00052D67
		protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
		{
			return this.ExecuteReader(behavior);
		}

		// Token: 0x0600B259 RID: 45657 RVA: 0x004F0B6C File Offset: 0x004EED6C
		public new SQLiteDataReader ExecuteReader(CommandBehavior behavior)
		{
			this.InitializeForReader();
			SQLiteDataReader sQLiteDataReader = new SQLiteDataReader(this, behavior);
			this._activeReader = new WeakReference(sQLiteDataReader, false);
			return sQLiteDataReader;
		}

		// Token: 0x0600B25A RID: 45658 RVA: 0x00054B70 File Offset: 0x00052D70
		public new SQLiteDataReader ExecuteReader()
		{
			return this.ExecuteReader(CommandBehavior.Default);
		}

		// Token: 0x0600B25B RID: 45659 RVA: 0x00054B79 File Offset: 0x00052D79
		internal void ClearDataReader()
		{
			this._activeReader = null;
		}

		// Token: 0x0600B25C RID: 45660 RVA: 0x004F0B98 File Offset: 0x004EED98
		public override int ExecuteNonQuery()
		{
			int recordsAffected;
			using (SQLiteDataReader sQLiteDataReader = this.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.SingleRow))
			{
				while (sQLiteDataReader.NextResult())
				{
				}
				recordsAffected = sQLiteDataReader.RecordsAffected;
			}
			return recordsAffected;
		}

		// Token: 0x0600B25D RID: 45661 RVA: 0x004F0BDC File Offset: 0x004EEDDC
		public override object ExecuteScalar()
		{
			using (SQLiteDataReader sQLiteDataReader = this.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.SingleRow))
			{
				if (sQLiteDataReader.Read())
				{
					return sQLiteDataReader[0];
				}
			}
			return null;
		}

		// Token: 0x0600B25E RID: 45662 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void Prepare()
		{
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x0600B25F RID: 45663 RVA: 0x00054B82 File Offset: 0x00052D82
		// (set) Token: 0x0600B260 RID: 45664 RVA: 0x00054B8A File Offset: 0x00052D8A
		[DefaultValue(UpdateRowSource.None)]
		public override UpdateRowSource UpdatedRowSource
		{
			get
			{
				return this._updateRowSource;
			}
			set
			{
				this._updateRowSource = value;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x0600B261 RID: 45665 RVA: 0x00054B93 File Offset: 0x00052D93
		// (set) Token: 0x0600B262 RID: 45666 RVA: 0x00054B9B File Offset: 0x00052D9B
		[Browsable(false), DefaultValue(true), DesignOnly(true), EditorBrowsable(EditorBrowsableState.Never)]
		public override bool DesignTimeVisible
		{
			get
			{
				return this._designTimeVisible;
			}
			set
			{
				this._designTimeVisible = value;
				TypeDescriptor.Refresh(this);
			}
		}

		// Token: 0x0600B263 RID: 45667 RVA: 0x00054BAA File Offset: 0x00052DAA
		public object Clone()
		{
			return new SQLiteCommand(this);
		}

		// Token: 0x04005E4A RID: 24138
		private string _commandText;

		// Token: 0x04005E4B RID: 24139
		private SQLiteConnection _cnn;

		// Token: 0x04005E4C RID: 24140
		private long _version;

		// Token: 0x04005E4D RID: 24141
		private WeakReference _activeReader;

		// Token: 0x04005E4E RID: 24142
		internal int _commandTimeout;

		// Token: 0x04005E4F RID: 24143
		private bool _designTimeVisible;

		// Token: 0x04005E50 RID: 24144
		private UpdateRowSource _updateRowSource;

		// Token: 0x04005E51 RID: 24145
		private SQLiteParameterCollection _parameterCollection;

		// Token: 0x04005E52 RID: 24146
		internal List<SQLiteStatement> _statementList;

		// Token: 0x04005E53 RID: 24147
		internal string _remainingText;

		// Token: 0x04005E54 RID: 24148
		private SQLiteTransaction _transaction;
	}
}

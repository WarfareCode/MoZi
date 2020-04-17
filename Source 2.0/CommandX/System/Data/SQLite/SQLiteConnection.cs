using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace System.Data.SQLite
{
	// Token: 0x02001416 RID: 5142
	public sealed class SQLiteConnection : DbConnection, ICloneable
	{
		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x0600B050 RID: 45136 RVA: 0x00053DF1 File Offset: 0x00051FF1
		protected override DbProviderFactory DbProviderFactory
		{
			get
			{
				return SQLiteFactory.Instance;
			}
		}

        // Token: 0x1400010C RID: 268
        // (add) Token: 0x0600B051 RID: 45137 RVA: 0x00053DF8 File Offset: 0x00051FF8
        // (remove) Token: 0x0600B052 RID: 45138 RVA: 0x00053E11 File Offset: 0x00052011
        private event SQLiteUpdateEventHandler _updateHandler;
		
			//[MethodImpl(MethodImplOptions.Synchronized)]
			//add
			//{
			//	this._updateHandler = (SQLiteUpdateEventHandler)Delegate.Combine(this._updateHandler, value);
			//}
			//[MethodImpl(MethodImplOptions.Synchronized)]
			//remove
			//{
			//	this._updateHandler = (SQLiteUpdateEventHandler)Delegate.Remove(this._updateHandler, value);
			//}
		

        // Token: 0x1400010D RID: 269
        // (add) Token: 0x0600B053 RID: 45139 RVA: 0x00053E2A File Offset: 0x0005202A
        // (remove) Token: 0x0600B054 RID: 45140 RVA: 0x00053E43 File Offset: 0x00052043
        private event SQLiteCommitHandler _commitHandler;
		
			//[MethodImpl(MethodImplOptions.Synchronized)]
			//add
			//{
			//	this._commitHandler = (SQLiteCommitHandler)Delegate.Combine(this._commitHandler, value);
			//}
			//[MethodImpl(MethodImplOptions.Synchronized)]
			//remove
			//{
			//	this._commitHandler = (SQLiteCommitHandler)Delegate.Remove(this._commitHandler, value);
			//}
		

        // Token: 0x1400010E RID: 270
        // (add) Token: 0x0600B055 RID: 45141 RVA: 0x00053E5C File Offset: 0x0005205C
        // (remove) Token: 0x0600B056 RID: 45142 RVA: 0x00053E75 File Offset: 0x00052075
        private event EventHandler _rollbackHandler;

        //[MethodImpl(MethodImplOptions.Synchronized)]
        //add
        //{
        //	this._rollbackHandler = (EventHandler)Delegate.Combine(this._rollbackHandler, value);
        //}
        //[MethodImpl(MethodImplOptions.Synchronized)]
        //remove
        //{
        //	this._rollbackHandler = (EventHandler)Delegate.Remove(this._rollbackHandler, value);
        //}


        // Token: 0x1400010F RID: 271
        // (add) Token: 0x0600B057 RID: 45143 RVA: 0x00053E8E File Offset: 0x0005208E
        // (remove) Token: 0x0600B058 RID: 45144 RVA: 0x00053EA7 File Offset: 0x000520A7
        public override event StateChangeEventHandler StateChange;
		
			//[MethodImpl(MethodImplOptions.Synchronized)]
			//add
			//{
			//	this.StateChange = (StateChangeEventHandler)Delegate.Combine(this.StateChange, value);
			//}
			//[MethodImpl(MethodImplOptions.Synchronized)]
			//remove
			//{
			//	this.StateChange = (StateChangeEventHandler)Delegate.Remove(this.StateChange, value);
			//}
		

		// Token: 0x0600B059 RID: 45145 RVA: 0x00053EC0 File Offset: 0x000520C0
		public SQLiteConnection() : this("")
		{
		}

		// Token: 0x0600B05A RID: 45146 RVA: 0x00053ECD File Offset: 0x000520CD
		public SQLiteConnection(string connectionString)
		{
			this._connectionState = ConnectionState.Closed;
			this._connectionString = "";
			if (connectionString != null)
			{
				this.ConnectionString = connectionString;
			}
		}

		// Token: 0x0600B05B RID: 45147 RVA: 0x004E7748 File Offset: 0x004E5948
		public SQLiteConnection(SQLiteConnection connection) : this(connection.ConnectionString)
		{
			if (connection.State == ConnectionState.Open)
			{
				this.Open();
				using (DataTable schema = connection.GetSchema("Catalogs"))
				{
					foreach (DataRow dataRow in schema.Rows)
					{
						string strA = dataRow[0].ToString();
						if (string.Compare(strA, "main", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(strA, "temp", StringComparison.OrdinalIgnoreCase) != 0)
						{
							using (SQLiteCommand sQLiteCommand = this.CreateCommand())
							{
								sQLiteCommand.CommandText = string.Format(CultureInfo.InvariantCulture, "ATTACH DATABASE '{0}' AS [{1}]", new object[]
								{
									dataRow[1],
									dataRow[0]
								});
								sQLiteCommand.ExecuteNonQuery();
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B05C RID: 45148 RVA: 0x00053EF9 File Offset: 0x000520F9
		public object Clone()
		{
			return new SQLiteConnection(this);
		}

		// Token: 0x0600B05D RID: 45149 RVA: 0x00053F01 File Offset: 0x00052101
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (disposing)
			{
				this.Close();
			}
		}

		// Token: 0x0600B05E RID: 45150 RVA: 0x004E7870 File Offset: 0x004E5A70
		public static void CreateFile(string databaseFileName)
		{
			FileStream fileStream = File.Create(databaseFileName);
			fileStream.Close();
		}

		// Token: 0x0600B05F RID: 45151 RVA: 0x004E788C File Offset: 0x004E5A8C
		internal void OnStateChange(ConnectionState newState)
		{
			ConnectionState connectionState = this._connectionState;
			this._connectionState = newState;
			if (this.StateChange != null && connectionState != newState)
			{
				StateChangeEventArgs e = new StateChangeEventArgs(connectionState, newState);
				this.StateChange(this, e);
			}
		}

		// Token: 0x0600B060 RID: 45152 RVA: 0x00053F13 File Offset: 0x00052113
		[Obsolete("Use one of the standard BeginTransaction methods, this one will be removed soon")]
		public SQLiteTransaction BeginTransaction(IsolationLevel isolationLevel, bool deferredLock)
		{
			return (SQLiteTransaction)this.BeginDbTransaction((!deferredLock) ? IsolationLevel.Serializable : IsolationLevel.ReadCommitted);
		}

		// Token: 0x0600B061 RID: 45153 RVA: 0x00053F2F File Offset: 0x0005212F
		[Obsolete("Use one of the standard BeginTransaction methods, this one will be removed soon")]
		public SQLiteTransaction BeginTransaction(bool deferredLock)
		{
			return (SQLiteTransaction)this.BeginDbTransaction((!deferredLock) ? IsolationLevel.Serializable : IsolationLevel.ReadCommitted);
		}

		// Token: 0x0600B062 RID: 45154 RVA: 0x00053F4B File Offset: 0x0005214B
		public new SQLiteTransaction BeginTransaction(IsolationLevel isolationLevel)
		{
			return (SQLiteTransaction)this.BeginDbTransaction(isolationLevel);
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x00053F59 File Offset: 0x00052159
		public new SQLiteTransaction BeginTransaction()
		{
			return (SQLiteTransaction)this.BeginDbTransaction(this._defaultIsolation);
		}

		// Token: 0x0600B064 RID: 45156 RVA: 0x004E78C8 File Offset: 0x004E5AC8
		protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
		{
			if (this._connectionState != ConnectionState.Open)
			{
				throw new InvalidOperationException();
			}
			if (isolationLevel == IsolationLevel.Unspecified)
			{
				isolationLevel = this._defaultIsolation;
			}
			if (isolationLevel != IsolationLevel.Serializable && isolationLevel != IsolationLevel.ReadCommitted)
			{
				throw new ArgumentException("isolationLevel");
			}
			return new SQLiteTransaction(this, isolationLevel != IsolationLevel.Serializable);
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x00025A78 File Offset: 0x00023C78
		public override void ChangeDatabase(string databaseName)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600B066 RID: 45158 RVA: 0x004E791C File Offset: 0x004E5B1C
		public override void Close()
		{
			if (this._sql != null)
			{
				if (this._enlistment != null)
				{
					SQLiteConnection sQLiteConnection = new SQLiteConnection();
					sQLiteConnection._sql = this._sql;
					sQLiteConnection._transactionLevel = this._transactionLevel;
					sQLiteConnection._enlistment = this._enlistment;
					sQLiteConnection._connectionState = this._connectionState;
					sQLiteConnection._version = this._version;
					sQLiteConnection._enlistment._transaction._cnn = sQLiteConnection;
					sQLiteConnection._enlistment._disposeConnection = true;
					this._sql = null;
					this._enlistment = null;
				}
				if (this._sql != null)
				{
					this._sql.Close();
				}
				this._sql = null;
				this._transactionLevel = 0;
			}
			this.OnStateChange(ConnectionState.Closed);
		}

		// Token: 0x0600B067 RID: 45159 RVA: 0x00053F6C File Offset: 0x0005216C
		public static void ClearPool(SQLiteConnection connection)
		{
			if (connection._sql == null)
			{
				return;
			}
			connection._sql.ClearPool();
		}

		// Token: 0x0600B068 RID: 45160 RVA: 0x00053F82 File Offset: 0x00052182
		public static void ClearAllPools()
		{
			SQLiteConnectionPool.ClearAllPools();
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x0600B069 RID: 45161 RVA: 0x00053F89 File Offset: 0x00052189
		// (set) Token: 0x0600B06A RID: 45162 RVA: 0x00053F91 File Offset: 0x00052191
		[DefaultValue(""), Editor("SQLite.Designer.SQLiteConnectionStringEditor, SQLite.Designer, Version=1.0.37.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), RefreshProperties(RefreshProperties.All)]
		public override string ConnectionString
		{
			get
			{
				return this._connectionString;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException();
				}
				if (this._connectionState != ConnectionState.Closed)
				{
					throw new InvalidOperationException();
				}
				this._connectionString = value;
			}
		}

		// Token: 0x0600B06B RID: 45163 RVA: 0x00053FB1 File Offset: 0x000521B1
		public new SQLiteCommand CreateCommand()
		{
			return new SQLiteCommand(this);
		}

		// Token: 0x0600B06C RID: 45164 RVA: 0x00053FB9 File Offset: 0x000521B9
		protected override DbCommand CreateDbCommand()
		{
			return this.CreateCommand();
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x0600B06D RID: 45165 RVA: 0x00053FC1 File Offset: 0x000521C1
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string DataSource
		{
			get
			{
				return this._dataSource;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x0600B06E RID: 45166 RVA: 0x00053FC9 File Offset: 0x000521C9
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string Database
		{
			get
			{
				return "main";
			}
		}

		// Token: 0x0600B06F RID: 45167 RVA: 0x004E79D4 File Offset: 0x004E5BD4
		internal static string MapUriPath(string path)
		{
			if (path.StartsWith("file://", StringComparison.OrdinalIgnoreCase))
			{
				return path.Substring(7);
			}
			if (path.StartsWith("file:", StringComparison.OrdinalIgnoreCase))
			{
				return path.Substring(5);
			}
			if (!path.StartsWith("/", StringComparison.OrdinalIgnoreCase))
			{
				throw new InvalidOperationException("Invalid connection string: invalid URI");
			}
			return path;
		}

		// Token: 0x0600B070 RID: 45168 RVA: 0x004E7A28 File Offset: 0x004E5C28
		internal static SortedList<string, string> ParseConnectionString(string connectionString)
		{
			SortedList<string, string> sortedList = new SortedList<string, string>(StringComparer.OrdinalIgnoreCase);
			string[] array = SQLiteConvert.Split(connectionString, ';');
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				string[] array2 = SQLiteConvert.Split(array[i], '=');
				if (array2.Length != 2)
				{
					throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid ConnectionString format for parameter \"{0}\"", new object[]
					{
						(array2.Length > 0) ? array2[0] : "null"
					}));
				}
				sortedList.Add(array2[0], array2[1]);
			}
			return sortedList;
		}

		// Token: 0x0600B071 RID: 45169 RVA: 0x004E7AB4 File Offset: 0x004E5CB4
		public override void EnlistTransaction(Transaction transaction)
		{
			if (this._transactionLevel > 0 && transaction != null)
			{
				throw new ArgumentException("Unable to enlist in transaction, a local transaction already exists");
			}
			if (this._enlistment != null && transaction == this._enlistment._scope)
			{
				return;
			}
			if (this._enlistment != null)
			{
				throw new ArgumentException("Already enlisted in a transaction");
			}
			this._enlistment = new SQLiteEnlistment(this, transaction);
		}

		// Token: 0x0600B072 RID: 45170 RVA: 0x004E7B1C File Offset: 0x004E5D1C
		internal static string FindKey(SortedList<string, string> items, string key, string defValue)
		{
			string result;
			if (items.TryGetValue(key, out result))
			{
				return result;
			}
			return defValue;
		}

		// Token: 0x0600B073 RID: 45171 RVA: 0x004E7B38 File Offset: 0x004E5D38
		public override void Open()
		{
			if (this._connectionState != ConnectionState.Closed)
			{
				throw new InvalidOperationException();
			}
			this.Close();
			SortedList<string, string> items = SQLiteConnection.ParseConnectionString(this._connectionString);
			if (Convert.ToInt32(SQLiteConnection.FindKey(items, "Version", "3"), CultureInfo.InvariantCulture) != 3)
			{
				throw new NotSupportedException("Only SQLite Version 3 is supported at this time");
			}
			string text = SQLiteConnection.FindKey(items, "Data Source", "");
			if (string.IsNullOrEmpty(text))
			{
				text = SQLiteConnection.FindKey(items, "Uri", "");
				if (string.IsNullOrEmpty(text))
				{
					throw new ArgumentException("Data Source cannot be empty.  Use :memory: to open an in-memory database");
				}
				text = SQLiteConnection.MapUriPath(text);
			}
			if (string.Compare(text, ":MEMORY:", StringComparison.OrdinalIgnoreCase) == 0)
			{
				text = ":memory:";
			}
			else
			{
				text = this.ExpandFileName(text);
			}
			try
			{
				bool usePool = SQLiteConvert.ToBoolean(SQLiteConnection.FindKey(items, "Pooling", bool.FalseString));
				bool flag = SQLiteConvert.ToBoolean(SQLiteConnection.FindKey(items, "UseUTF16Encoding", bool.FalseString));
				int maxPoolSize = Convert.ToInt32(SQLiteConnection.FindKey(items, "Max Pool Size", "100"), CultureInfo.InvariantCulture);
				this._defaultTimeout = Convert.ToInt32(SQLiteConnection.FindKey(items, "Default Timeout", "30"), CultureInfo.CurrentCulture);
				this._defaultIsolation = (IsolationLevel)Enum.Parse(typeof(IsolationLevel), SQLiteConnection.FindKey(items, "Default IsolationLevel", "Serializable"), true);
				if (this._defaultIsolation != IsolationLevel.Serializable && this._defaultIsolation != IsolationLevel.ReadCommitted)
				{
					throw new NotSupportedException("Invalid Default IsolationLevel specified");
				}
				SQLiteDateFormats fmt = (SQLiteDateFormats)Enum.Parse(typeof(SQLiteDateFormats), SQLiteConnection.FindKey(items, "DateTimeFormat", "ISO8601"), true);
				if (flag)
				{
					this._sql = new SQLite3_UTF16(fmt);
				}
				else
				{
					this._sql = new SQLite3(fmt);
				}
				SQLiteOpenFlagsEnum sQLiteOpenFlagsEnum = SQLiteOpenFlagsEnum.None;
				if (!SQLiteConvert.ToBoolean(SQLiteConnection.FindKey(items, "FailIfMissing", bool.FalseString)))
				{
					sQLiteOpenFlagsEnum |= SQLiteOpenFlagsEnum.Create;
				}
				if (SQLiteConvert.ToBoolean(SQLiteConnection.FindKey(items, "Read Only", bool.FalseString)))
				{
					sQLiteOpenFlagsEnum |= SQLiteOpenFlagsEnum.ReadOnly;
				}
				else
				{
					sQLiteOpenFlagsEnum |= SQLiteOpenFlagsEnum.ReadWrite;
				}
				this._sql.Open(text, sQLiteOpenFlagsEnum, maxPoolSize, usePool);
				this._binaryGuid = SQLiteConvert.ToBoolean(SQLiteConnection.FindKey(items, "BinaryGUID", bool.TrueString));
				string text2 = SQLiteConnection.FindKey(items, "Password", null);
				if (!string.IsNullOrEmpty(text2))
				{
					this._sql.SetPassword(Encoding.UTF8.GetBytes(text2));
				}
				else if (this._password != null)
				{
					this._sql.SetPassword(this._password);
				}
				this._password = null;
				this._dataSource = Path.GetFileNameWithoutExtension(text);
				this._version += 1L;
				ConnectionState connectionState = this._connectionState;
				this._connectionState = ConnectionState.Open;
				try
				{
					using (SQLiteCommand sQLiteCommand = this.CreateCommand())
					{
						string text3;
						if (text != ":memory:")
						{
							text3 = SQLiteConnection.FindKey(items, "Page Size", "1024");
							if (Convert.ToInt32(text3, CultureInfo.InvariantCulture) != 1024)
							{
								sQLiteCommand.CommandText = string.Format(CultureInfo.InvariantCulture, "PRAGMA page_size={0}", new object[]
								{
									text3
								});
								sQLiteCommand.ExecuteNonQuery();
							}
						}
						text3 = SQLiteConnection.FindKey(items, "Max Page Count", "0");
						if (Convert.ToInt32(text3, CultureInfo.InvariantCulture) != 0)
						{
							sQLiteCommand.CommandText = string.Format(CultureInfo.InvariantCulture, "PRAGMA max_page_count={0}", new object[]
							{
								text3
							});
							sQLiteCommand.ExecuteNonQuery();
						}
						text3 = SQLiteConnection.FindKey(items, "Legacy Format", bool.FalseString);
						sQLiteCommand.CommandText = string.Format(CultureInfo.InvariantCulture, "PRAGMA legacy_file_format={0}", new object[]
						{
							SQLiteConvert.ToBoolean(text3) ? "ON" : "OFF"
						});
						sQLiteCommand.ExecuteNonQuery();
						text3 = SQLiteConnection.FindKey(items, "Synchronous", "Normal");
						if (string.Compare(text3, "Full", StringComparison.OrdinalIgnoreCase) != 0)
						{
							sQLiteCommand.CommandText = string.Format(CultureInfo.InvariantCulture, "PRAGMA synchronous={0}", new object[]
							{
								text3
							});
							sQLiteCommand.ExecuteNonQuery();
						}
						text3 = SQLiteConnection.FindKey(items, "Cache Size", "2000");
						if (Convert.ToInt32(text3, CultureInfo.InvariantCulture) != 2000)
						{
							sQLiteCommand.CommandText = string.Format(CultureInfo.InvariantCulture, "PRAGMA cache_size={0}", new object[]
							{
								text3
							});
							sQLiteCommand.ExecuteNonQuery();
						}
						text3 = SQLiteConnection.FindKey(items, "Journal Mode", "Delete");
						if (string.Compare(text3, "Default", StringComparison.OrdinalIgnoreCase) != 0)
						{
							sQLiteCommand.CommandText = string.Format(CultureInfo.InvariantCulture, "PRAGMA journal_mode={0}", new object[]
							{
								text3
							});
							sQLiteCommand.ExecuteNonQuery();
						}
					}
					if (this._commitHandler != null)
					{
						this._sql.SetCommitHook(this._commitCallback);
					}
					if (this._updateHandler != null)
					{
						this._sql.SetUpdateHook(this._updateCallback);
					}
					if (this._rollbackHandler != null)
					{
						this._sql.SetRollbackHook(this._rollbackCallback);
					}
					if (Transaction.Current != null && SQLiteConvert.ToBoolean(SQLiteConnection.FindKey(items, "Enlist", bool.TrueString)))
					{
						this.EnlistTransaction(Transaction.Current);
					}
					this._connectionState = connectionState;
					this.OnStateChange(ConnectionState.Open);
				}
				catch
				{
					this._connectionState = connectionState;
					throw;
				}
			}
			catch (SQLiteException)
			{
				this.Close();
				throw;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x0600B074 RID: 45172 RVA: 0x00053FD0 File Offset: 0x000521D0
		// (set) Token: 0x0600B075 RID: 45173 RVA: 0x00053FD8 File Offset: 0x000521D8
		public int DefaultTimeout
		{
			get
			{
				return this._defaultTimeout;
			}
			set
			{
				this._defaultTimeout = value;
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x0600B076 RID: 45174 RVA: 0x00053FE1 File Offset: 0x000521E1
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string ServerVersion
		{
			get
			{
				return SQLiteConnection.SQLiteVersion;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x0600B077 RID: 45175 RVA: 0x00053FE8 File Offset: 0x000521E8
		public static string SQLiteVersion
		{
			get
			{
				return SQLite3.SQLiteVersion;
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x0600B078 RID: 45176 RVA: 0x00053FEF File Offset: 0x000521EF
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override ConnectionState State
		{
			get
			{
				return this._connectionState;
			}
		}

		// Token: 0x0600B079 RID: 45177 RVA: 0x00053FF7 File Offset: 0x000521F7
		public void ChangePassword(string newPassword)
		{
			this.ChangePassword(string.IsNullOrEmpty(newPassword) ? null : Encoding.UTF8.GetBytes(newPassword));
		}

		// Token: 0x0600B07A RID: 45178 RVA: 0x00054015 File Offset: 0x00052215
		public void ChangePassword(byte[] newPassword)
		{
			if (this._connectionState != ConnectionState.Open)
			{
				throw new InvalidOperationException("Database must be opened before changing the password.");
			}
			this._sql.ChangePassword(newPassword);
		}

		// Token: 0x0600B07B RID: 45179 RVA: 0x00054037 File Offset: 0x00052237
		public void SetPassword(string databasePassword)
		{
			this.SetPassword(string.IsNullOrEmpty(databasePassword) ? null : Encoding.UTF8.GetBytes(databasePassword));
		}

		// Token: 0x0600B07C RID: 45180 RVA: 0x00054055 File Offset: 0x00052255
		public void SetPassword(byte[] databasePassword)
		{
			if (this._connectionState != ConnectionState.Closed)
			{
				throw new InvalidOperationException("Password can only be set before the database is opened.");
			}
			if (databasePassword != null && databasePassword.Length == 0)
			{
				databasePassword = null;
			}
			this._password = databasePassword;
		}

		// Token: 0x0600B07D RID: 45181 RVA: 0x004E80BC File Offset: 0x004E62BC
		private string ExpandFileName(string sourceFile)
		{
			if (string.IsNullOrEmpty(sourceFile))
			{
				return sourceFile;
			}
			if (sourceFile.StartsWith("|DataDirectory|", StringComparison.OrdinalIgnoreCase))
			{
				string text = AppDomain.CurrentDomain.GetData("DataDirectory") as string;
				if (string.IsNullOrEmpty(text))
				{
					text = AppDomain.CurrentDomain.BaseDirectory;
				}
				if (sourceFile.Length > "|DataDirectory|".Length && (sourceFile["|DataDirectory|".Length] == Path.DirectorySeparatorChar || sourceFile["|DataDirectory|".Length] == Path.AltDirectorySeparatorChar))
				{
					sourceFile = sourceFile.Remove("|DataDirectory|".Length, 1);
				}
				sourceFile = Path.Combine(text, sourceFile.Substring("|DataDirectory|".Length));
			}
			sourceFile = Path.GetFullPath(sourceFile);
			return sourceFile;
		}

		// Token: 0x0600B07E RID: 45182 RVA: 0x0005407C File Offset: 0x0005227C
		public override DataTable GetSchema()
		{
			return this.GetSchema("MetaDataCollections", null);
		}

		// Token: 0x0600B07F RID: 45183 RVA: 0x0005408A File Offset: 0x0005228A
		public override DataTable GetSchema(string collectionName)
		{
			return this.GetSchema(collectionName, new string[0]);
		}

		// Token: 0x0600B080 RID: 45184 RVA: 0x004E8180 File Offset: 0x004E6380
		public override DataTable GetSchema(string collectionName, string[] restrictionValues)
		{
			if (this._connectionState != ConnectionState.Open)
			{
				throw new InvalidOperationException();
			}
			string[] array = new string[5];
			if (restrictionValues == null)
			{
				restrictionValues = new string[0];
			}
			restrictionValues.CopyTo(array, 0);
			string key;
			switch (key = collectionName.ToUpper(CultureInfo.InvariantCulture))
			{
			case "METADATACOLLECTIONS":
				return SQLiteConnection.Schema_MetaDataCollections();
			case "DATASOURCEINFORMATION":
				return this.Schema_DataSourceInformation();
			case "DATATYPES":
				return this.Schema_DataTypes();
			case "COLUMNS":
			case "TABLECOLUMNS":
				return this.Schema_Columns(array[0], array[2], array[3]);
			case "INDEXES":
				return this.Schema_Indexes(array[0], array[2], array[3]);
			case "TRIGGERS":
				return this.Schema_Triggers(array[0], array[2], array[3]);
			case "INDEXCOLUMNS":
				return this.Schema_IndexColumns(array[0], array[2], array[3], array[4]);
			case "TABLES":
				return this.Schema_Tables(array[0], array[2], array[3]);
			case "VIEWS":
				return this.Schema_Views(array[0], array[2]);
			case "VIEWCOLUMNS":
				return this.Schema_ViewColumns(array[0], array[2], array[3]);
			case "FOREIGNKEYS":
				return this.Schema_ForeignKeys(array[0], array[2], array[3]);
			case "CATALOGS":
				return this.Schema_Catalogs(array[0]);
			case "RESERVEDWORDS":
				return SQLiteConnection.Schema_ReservedWords();
			}
			throw new NotSupportedException();
		}

		// Token: 0x0600B081 RID: 45185 RVA: 0x004E8390 File Offset: 0x004E6590
		private static DataTable Schema_ReservedWords()
		{
			DataTable dataTable = new DataTable("MetaDataCollections");
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add("ReservedWord", typeof(string));
			dataTable.Columns.Add("MaximumVersion", typeof(string));
			dataTable.Columns.Add("MinimumVersion", typeof(string));
			dataTable.BeginLoadData();
			string[] array = SR.Keywords.Split(new char[]
			{
				','
			});
			for (int i = 0; i < array.Length; i++)
			{
				string value = array[i];
				DataRow dataRow = dataTable.NewRow();
				dataRow[0] = value;
				dataTable.Rows.Add(dataRow);
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x0600B082 RID: 45186 RVA: 0x004E8464 File Offset: 0x004E6664
		private static DataTable Schema_MetaDataCollections()
		{
			DataTable dataTable = new DataTable("MetaDataCollections");
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add("CollectionName", typeof(string));
			dataTable.Columns.Add("NumberOfRestrictions", typeof(int));
			dataTable.Columns.Add("NumberOfIdentifierParts", typeof(int));
			dataTable.BeginLoadData();
			StringReader stringReader = new StringReader(SR.MetaDataCollections);
			dataTable.ReadXml(stringReader);
			stringReader.Close();
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x0600B083 RID: 45187 RVA: 0x004E8504 File Offset: 0x004E6704
		private DataTable Schema_DataSourceInformation()
		{
			DataTable dataTable = new DataTable("DataSourceInformation");
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add(DbMetaDataColumnNames.CompositeIdentifierSeparatorPattern, typeof(string));
			dataTable.Columns.Add(DbMetaDataColumnNames.DataSourceProductName, typeof(string));
			dataTable.Columns.Add(DbMetaDataColumnNames.DataSourceProductVersion, typeof(string));
			dataTable.Columns.Add(DbMetaDataColumnNames.DataSourceProductVersionNormalized, typeof(string));
			dataTable.Columns.Add(DbMetaDataColumnNames.GroupByBehavior, typeof(int));
			dataTable.Columns.Add(DbMetaDataColumnNames.IdentifierPattern, typeof(string));
			dataTable.Columns.Add(DbMetaDataColumnNames.IdentifierCase, typeof(int));
			dataTable.Columns.Add(DbMetaDataColumnNames.OrderByColumnsInSelect, typeof(bool));
			dataTable.Columns.Add(DbMetaDataColumnNames.ParameterMarkerFormat, typeof(string));
			dataTable.Columns.Add(DbMetaDataColumnNames.ParameterMarkerPattern, typeof(string));
			dataTable.Columns.Add(DbMetaDataColumnNames.ParameterNameMaxLength, typeof(int));
			dataTable.Columns.Add(DbMetaDataColumnNames.ParameterNamePattern, typeof(string));
			dataTable.Columns.Add(DbMetaDataColumnNames.QuotedIdentifierPattern, typeof(string));
			dataTable.Columns.Add(DbMetaDataColumnNames.QuotedIdentifierCase, typeof(int));
			dataTable.Columns.Add(DbMetaDataColumnNames.StatementSeparatorPattern, typeof(string));
			dataTable.Columns.Add(DbMetaDataColumnNames.StringLiteralPattern, typeof(string));
			dataTable.Columns.Add(DbMetaDataColumnNames.SupportedJoinOperators, typeof(int));
			dataTable.BeginLoadData();
			DataRow dataRow = dataTable.NewRow();
			dataRow.ItemArray = new object[]
			{
				null,
				"SQLite",
				this._sql.Version,
				this._sql.Version,
				3,
				"(^\\[\\p{Lo}\\p{Lu}\\p{Ll}_@#][\\p{Lo}\\p{Lu}\\p{Ll}\\p{Nd}@$#_]*$)|(^\\[[^\\]\\0]|\\]\\]+\\]$)|(^\\\"[^\\\"\\0]|\\\"\\\"+\\\"$)",
				1,
				false,
				"{0}",
				"@[\\p{Lo}\\p{Lu}\\p{Ll}\\p{Lm}_@#][\\p{Lo}\\p{Lu}\\p{Ll}\\p{Lm}\\p{Nd}\\uff3f_@#\\$]*(?=\\s+|$)",
				255,
				"^[\\p{Lo}\\p{Lu}\\p{Ll}\\p{Lm}_@#][\\p{Lo}\\p{Lu}\\p{Ll}\\p{Lm}\\p{Nd}\\uff3f_@#\\$]*(?=\\s+|$)",
				"(([^\\[]|\\]\\])*)",
				1,
				";",
				"'(([^']|'')*)'",
				15
			};
			dataTable.Rows.Add(dataRow);
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x0600B084 RID: 45188 RVA: 0x004E87C8 File Offset: 0x004E69C8
		private DataTable Schema_Columns(string strCatalog, string strTable, string strColumn)
		{
			DataTable dataTable = new DataTable("Columns");
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("COLUMN_NAME", typeof(string));
			dataTable.Columns.Add("COLUMN_GUID", typeof(Guid));
			dataTable.Columns.Add("COLUMN_PROPID", typeof(long));
			dataTable.Columns.Add("ORDINAL_POSITION", typeof(int));
			dataTable.Columns.Add("COLUMN_HASDEFAULT", typeof(bool));
			dataTable.Columns.Add("COLUMN_DEFAULT", typeof(string));
			dataTable.Columns.Add("COLUMN_FLAGS", typeof(long));
			dataTable.Columns.Add("IS_NULLABLE", typeof(bool));
			dataTable.Columns.Add("DATA_TYPE", typeof(string));
			dataTable.Columns.Add("TYPE_GUID", typeof(Guid));
			dataTable.Columns.Add("CHARACTER_MAXIMUM_LENGTH", typeof(int));
			dataTable.Columns.Add("CHARACTER_OCTET_LENGTH", typeof(int));
			dataTable.Columns.Add("NUMERIC_PRECISION", typeof(int));
			dataTable.Columns.Add("NUMERIC_SCALE", typeof(int));
			dataTable.Columns.Add("DATETIME_PRECISION", typeof(long));
			dataTable.Columns.Add("CHARACTER_SET_CATALOG", typeof(string));
			dataTable.Columns.Add("CHARACTER_SET_SCHEMA", typeof(string));
			dataTable.Columns.Add("CHARACTER_SET_NAME", typeof(string));
			dataTable.Columns.Add("COLLATION_CATALOG", typeof(string));
			dataTable.Columns.Add("COLLATION_SCHEMA", typeof(string));
			dataTable.Columns.Add("COLLATION_NAME", typeof(string));
			dataTable.Columns.Add("DOMAIN_CATALOG", typeof(string));
			dataTable.Columns.Add("DOMAIN_NAME", typeof(string));
			dataTable.Columns.Add("DESCRIPTION", typeof(string));
			dataTable.Columns.Add("PRIMARY_KEY", typeof(bool));
			dataTable.Columns.Add("EDM_TYPE", typeof(string));
			dataTable.Columns.Add("AUTOINCREMENT", typeof(bool));
			dataTable.Columns.Add("UNIQUE", typeof(bool));
			dataTable.BeginLoadData();
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			using (SQLiteCommand sQLiteCommand = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}] WHERE [type] LIKE 'table' OR [type] LIKE 'view'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader())
				{
					while (sQLiteDataReader.Read())
					{
						if (string.IsNullOrEmpty(strTable) || string.Compare(strTable, sQLiteDataReader.GetString(2), StringComparison.OrdinalIgnoreCase) == 0)
						{
							try
							{
								using (SQLiteCommand sQLiteCommand2 = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}]", new object[]
								{
									strCatalog,
									sQLiteDataReader.GetString(2)
								}), this))
								{
									using (SQLiteDataReader sQLiteDataReader2 = sQLiteCommand2.ExecuteReader(CommandBehavior.SchemaOnly))
									{
										using (DataTable schemaTable = sQLiteDataReader2.GetSchemaTable(true, true))
										{
											foreach (DataRow dataRow in schemaTable.Rows)
											{
												if (string.Compare(dataRow[SchemaTableColumn.ColumnName].ToString(), strColumn, StringComparison.OrdinalIgnoreCase) == 0 || strColumn == null)
												{
													DataRow dataRow2 = dataTable.NewRow();
													dataRow2["NUMERIC_PRECISION"] = dataRow[SchemaTableColumn.NumericPrecision];
													dataRow2["NUMERIC_SCALE"] = dataRow[SchemaTableColumn.NumericScale];
													dataRow2["TABLE_NAME"] = sQLiteDataReader.GetString(2);
													dataRow2["COLUMN_NAME"] = dataRow[SchemaTableColumn.ColumnName];
													dataRow2["TABLE_CATALOG"] = strCatalog;
													dataRow2["ORDINAL_POSITION"] = dataRow[SchemaTableColumn.ColumnOrdinal];
													dataRow2["COLUMN_HASDEFAULT"] = (dataRow[SchemaTableOptionalColumn.DefaultValue] != DBNull.Value);
													dataRow2["COLUMN_DEFAULT"] = dataRow[SchemaTableOptionalColumn.DefaultValue];
													dataRow2["IS_NULLABLE"] = dataRow[SchemaTableColumn.AllowDBNull];
													dataRow2["DATA_TYPE"] = dataRow["DataTypeName"].ToString().ToLower(CultureInfo.InvariantCulture);
													dataRow2["EDM_TYPE"] = SQLiteConvert.DbTypeToTypeName((DbType)dataRow[SchemaTableColumn.ProviderType]).ToString().ToLower(CultureInfo.InvariantCulture);
													dataRow2["CHARACTER_MAXIMUM_LENGTH"] = dataRow[SchemaTableColumn.ColumnSize];
													dataRow2["TABLE_SCHEMA"] = dataRow[SchemaTableColumn.BaseSchemaName];
													dataRow2["PRIMARY_KEY"] = dataRow[SchemaTableColumn.IsKey];
													dataRow2["AUTOINCREMENT"] = dataRow[SchemaTableOptionalColumn.IsAutoIncrement];
													dataRow2["COLLATION_NAME"] = dataRow["CollationType"];
													dataRow2["UNIQUE"] = dataRow[SchemaTableColumn.IsUnique];
													dataTable.Rows.Add(dataRow2);
												}
											}
										}
									}
								}
							}
							catch (SQLiteException)
							{
							}
						}
					}
				}
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x0600B085 RID: 45189 RVA: 0x004E8F20 File Offset: 0x004E7120
		private DataTable Schema_Indexes(string strCatalog, string strTable, string strIndex)
		{
			DataTable dataTable = new DataTable("Indexes");
			List<int> list = new List<int>();
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("INDEX_CATALOG", typeof(string));
			dataTable.Columns.Add("INDEX_SCHEMA", typeof(string));
			dataTable.Columns.Add("INDEX_NAME", typeof(string));
			dataTable.Columns.Add("PRIMARY_KEY", typeof(bool));
			dataTable.Columns.Add("UNIQUE", typeof(bool));
			dataTable.Columns.Add("CLUSTERED", typeof(bool));
			dataTable.Columns.Add("TYPE", typeof(int));
			dataTable.Columns.Add("FILL_FACTOR", typeof(int));
			dataTable.Columns.Add("INITIAL_SIZE", typeof(int));
			dataTable.Columns.Add("NULLS", typeof(int));
			dataTable.Columns.Add("SORT_BOOKMARKS", typeof(bool));
			dataTable.Columns.Add("AUTO_UPDATE", typeof(bool));
			dataTable.Columns.Add("NULL_COLLATION", typeof(int));
			dataTable.Columns.Add("ORDINAL_POSITION", typeof(int));
			dataTable.Columns.Add("COLUMN_NAME", typeof(string));
			dataTable.Columns.Add("COLUMN_GUID", typeof(Guid));
			dataTable.Columns.Add("COLUMN_PROPID", typeof(long));
			dataTable.Columns.Add("COLLATION", typeof(short));
			dataTable.Columns.Add("CARDINALITY", typeof(decimal));
			dataTable.Columns.Add("PAGES", typeof(int));
			dataTable.Columns.Add("FILTER_CONDITION", typeof(string));
			dataTable.Columns.Add("INTEGRATED", typeof(bool));
			dataTable.Columns.Add("INDEX_DEFINITION", typeof(string));
			dataTable.BeginLoadData();
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			using (SQLiteCommand sQLiteCommand = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}] WHERE [type] LIKE 'table'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader())
				{
					while (sQLiteDataReader.Read())
					{
						bool flag = false;
						list.Clear();
						if (string.IsNullOrEmpty(strTable) || string.Compare(sQLiteDataReader.GetString(2), strTable, StringComparison.OrdinalIgnoreCase) == 0)
						{
							try
							{
								using (SQLiteCommand sQLiteCommand2 = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "PRAGMA [{0}].table_info([{1}])", new object[]
								{
									strCatalog,
									sQLiteDataReader.GetString(2)
								}), this))
								{
									using (SQLiteDataReader sQLiteDataReader2 = sQLiteCommand2.ExecuteReader())
									{
										while (sQLiteDataReader2.Read())
										{
											if (sQLiteDataReader2.GetInt32(5) == 1)
											{
												list.Add(sQLiteDataReader2.GetInt32(0));
												if (string.Compare(sQLiteDataReader2.GetString(2), "INTEGER", StringComparison.OrdinalIgnoreCase) == 0)
												{
													flag = true;
												}
											}
										}
									}
								}
							}
							catch (SQLiteException)
							{
							}
							if (list.Count == 1 && flag)
							{
								DataRow dataRow = dataTable.NewRow();
								dataRow["TABLE_CATALOG"] = strCatalog;
								dataRow["TABLE_NAME"] = sQLiteDataReader.GetString(2);
								dataRow["INDEX_CATALOG"] = strCatalog;
								dataRow["PRIMARY_KEY"] = true;
								dataRow["INDEX_NAME"] = string.Format(CultureInfo.InvariantCulture, "{1}_PK_{0}", new object[]
								{
									sQLiteDataReader.GetString(2),
									text
								});
								dataRow["UNIQUE"] = true;
								if (string.Compare((string)dataRow["INDEX_NAME"], strIndex, StringComparison.OrdinalIgnoreCase) == 0 || strIndex == null)
								{
									dataTable.Rows.Add(dataRow);
								}
								list.Clear();
							}
							try
							{
								using (SQLiteCommand sQLiteCommand3 = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "PRAGMA [{0}].index_list([{1}])", new object[]
								{
									strCatalog,
									sQLiteDataReader.GetString(2)
								}), this))
								{
									using (SQLiteDataReader sQLiteDataReader3 = sQLiteCommand3.ExecuteReader())
									{
										while (sQLiteDataReader3.Read())
										{
											if (string.Compare(sQLiteDataReader3.GetString(1), strIndex, StringComparison.OrdinalIgnoreCase) == 0 || strIndex == null)
											{
												DataRow dataRow = dataTable.NewRow();
												dataRow["TABLE_CATALOG"] = strCatalog;
												dataRow["TABLE_NAME"] = sQLiteDataReader.GetString(2);
												dataRow["INDEX_CATALOG"] = strCatalog;
												dataRow["INDEX_NAME"] = sQLiteDataReader3.GetString(1);
												dataRow["UNIQUE"] = sQLiteDataReader3.GetBoolean(2);
												dataRow["PRIMARY_KEY"] = false;
												using (SQLiteCommand sQLiteCommand4 = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{2}] WHERE [type] LIKE 'index' AND [name] LIKE '{1}'", new object[]
												{
													strCatalog,
													sQLiteDataReader3.GetString(1).Replace("'", "''"),
													text
												}), this))
												{
													using (SQLiteDataReader sQLiteDataReader4 = sQLiteCommand4.ExecuteReader())
													{
														if (sQLiteDataReader4.Read() && !sQLiteDataReader4.IsDBNull(4))
														{
															dataRow["INDEX_DEFINITION"] = sQLiteDataReader4.GetString(4);
														}
													}
												}
												if (list.Count > 0 && sQLiteDataReader3.GetString(1).StartsWith("sqlite_autoindex_" + sQLiteDataReader.GetString(2), StringComparison.InvariantCultureIgnoreCase))
												{
													using (SQLiteCommand sQLiteCommand5 = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "PRAGMA [{0}].index_info([{1}])", new object[]
													{
														strCatalog,
														sQLiteDataReader3.GetString(1)
													}), this))
													{
														using (SQLiteDataReader sQLiteDataReader5 = sQLiteCommand5.ExecuteReader())
														{
															int num = 0;
															while (sQLiteDataReader5.Read())
															{
																if (!list.Contains(sQLiteDataReader5.GetInt32(1)))
																{
																	num = 0;
																	IL_6B6:
																	if (num == list.Count)
																	{
																		dataRow["PRIMARY_KEY"] = true;
																		list.Clear();
																	}
																	goto IL_6E7;
																}
																num++;
															}
                                                            //ZSP goto IL_6B6;
                                                            if (num == list.Count)
                                                            {
                                                                dataRow["PRIMARY_KEY"] = true;
                                                                list.Clear();
                                                            }
                                                            goto IL_6E7;
                                                        }
														IL_6E7:;
													}
												}
												dataTable.Rows.Add(dataRow);
											}
										}
									}
								}
							}
							catch (SQLiteException)
							{
							}
						}
					}
				}
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x0600B086 RID: 45190 RVA: 0x004E97B0 File Offset: 0x004E79B0
		private DataTable Schema_Triggers(string catalog, string table, string triggerName)
		{
			DataTable dataTable = new DataTable("Triggers");
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("TRIGGER_NAME", typeof(string));
			dataTable.Columns.Add("TRIGGER_DEFINITION", typeof(string));
			dataTable.BeginLoadData();
			if (string.IsNullOrEmpty(table))
			{
				table = null;
			}
			if (string.IsNullOrEmpty(catalog))
			{
				catalog = "main";
			}
			string text = (string.Compare(catalog, "temp", StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			using (SQLiteCommand sQLiteCommand = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "SELECT [type], [name], [tbl_name], [rootpage], [sql], [rowid] FROM [{0}].[{1}] WHERE [type] LIKE 'trigger'", new object[]
			{
				catalog,
				text
			}), this))
			{
				using (SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader())
				{
					while (sQLiteDataReader.Read())
					{
						if ((string.Compare(sQLiteDataReader.GetString(1), triggerName, StringComparison.OrdinalIgnoreCase) == 0 || triggerName == null) && (table == null || string.Compare(table, sQLiteDataReader.GetString(2), StringComparison.OrdinalIgnoreCase) == 0))
						{
							DataRow dataRow = dataTable.NewRow();
							dataRow["TABLE_CATALOG"] = catalog;
							dataRow["TABLE_NAME"] = sQLiteDataReader.GetString(2);
							dataRow["TRIGGER_NAME"] = sQLiteDataReader.GetString(1);
							dataRow["TRIGGER_DEFINITION"] = sQLiteDataReader.GetString(4);
							dataTable.Rows.Add(dataRow);
						}
					}
				}
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x0600B087 RID: 45191 RVA: 0x004E9994 File Offset: 0x004E7B94
		private DataTable Schema_Tables(string strCatalog, string strTable, string strType)
		{
			DataTable dataTable = new DataTable("Tables");
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("TABLE_TYPE", typeof(string));
			dataTable.Columns.Add("TABLE_ID", typeof(long));
			dataTable.Columns.Add("TABLE_ROOTPAGE", typeof(int));
			dataTable.Columns.Add("TABLE_DEFINITION", typeof(string));
			dataTable.BeginLoadData();
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			using (SQLiteCommand sQLiteCommand = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "SELECT [type], [name], [tbl_name], [rootpage], [sql], [rowid] FROM [{0}].[{1}] WHERE [type] LIKE 'table'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader())
				{
					while (sQLiteDataReader.Read())
					{
						string text2 = sQLiteDataReader.GetString(0);
						if (string.Compare(sQLiteDataReader.GetString(2), 0, "SQLITE_", 0, 7, StringComparison.OrdinalIgnoreCase) == 0)
						{
							text2 = "SYSTEM_TABLE";
						}
						if ((string.Compare(strType, text2, StringComparison.OrdinalIgnoreCase) == 0 || strType == null) && (string.Compare(sQLiteDataReader.GetString(2), strTable, StringComparison.OrdinalIgnoreCase) == 0 || strTable == null))
						{
							DataRow dataRow = dataTable.NewRow();
							dataRow["TABLE_CATALOG"] = strCatalog;
							dataRow["TABLE_NAME"] = sQLiteDataReader.GetString(2);
							dataRow["TABLE_TYPE"] = text2;
							dataRow["TABLE_ID"] = sQLiteDataReader.GetInt64(5);
							dataRow["TABLE_ROOTPAGE"] = sQLiteDataReader.GetInt32(3);
							dataRow["TABLE_DEFINITION"] = sQLiteDataReader.GetString(4);
							dataTable.Rows.Add(dataRow);
						}
					}
				}
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x0600B088 RID: 45192 RVA: 0x004E9BF4 File Offset: 0x004E7DF4
		private DataTable Schema_Views(string strCatalog, string strView)
		{
			DataTable dataTable = new DataTable("Views");
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("VIEW_DEFINITION", typeof(string));
			dataTable.Columns.Add("CHECK_OPTION", typeof(bool));
			dataTable.Columns.Add("IS_UPDATABLE", typeof(bool));
			dataTable.Columns.Add("DESCRIPTION", typeof(string));
			dataTable.Columns.Add("DATE_CREATED", typeof(DateTime));
			dataTable.Columns.Add("DATE_MODIFIED", typeof(DateTime));
			dataTable.BeginLoadData();
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			using (SQLiteCommand sQLiteCommand = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}] WHERE [type] LIKE 'view'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader())
				{
					while (sQLiteDataReader.Read())
					{
						if (string.Compare(sQLiteDataReader.GetString(1), strView, StringComparison.OrdinalIgnoreCase) == 0 || string.IsNullOrEmpty(strView))
						{
							string text2 = sQLiteDataReader.GetString(4).Replace('\r', ' ').Replace('\n', ' ').Replace('\t', ' ');
							int num = CultureInfo.InvariantCulture.CompareInfo.IndexOf(text2, " AS ", CompareOptions.IgnoreCase);
							if (num > -1)
							{
								text2 = text2.Substring(num + 4).Trim();
								DataRow dataRow = dataTable.NewRow();
								dataRow["TABLE_CATALOG"] = strCatalog;
								dataRow["TABLE_NAME"] = sQLiteDataReader.GetString(2);
								dataRow["IS_UPDATABLE"] = false;
								dataRow["VIEW_DEFINITION"] = text2;
								dataTable.Rows.Add(dataRow);
							}
						}
					}
				}
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x0600B089 RID: 45193 RVA: 0x004E9E7C File Offset: 0x004E807C
		private DataTable Schema_Catalogs(string strCatalog)
		{
			DataTable dataTable = new DataTable("Catalogs");
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add("CATALOG_NAME", typeof(string));
			dataTable.Columns.Add("DESCRIPTION", typeof(string));
			dataTable.Columns.Add("ID", typeof(long));
			dataTable.BeginLoadData();
			using (SQLiteCommand sQLiteCommand = new SQLiteCommand("PRAGMA database_list", this))
			{
				using (SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader())
				{
					while (sQLiteDataReader.Read())
					{
						if (string.Compare(sQLiteDataReader.GetString(1), strCatalog, StringComparison.OrdinalIgnoreCase) == 0 || strCatalog == null)
						{
							DataRow dataRow = dataTable.NewRow();
							dataRow["CATALOG_NAME"] = sQLiteDataReader.GetString(1);
							dataRow["DESCRIPTION"] = sQLiteDataReader.GetString(2);
							dataRow["ID"] = sQLiteDataReader.GetInt64(0);
							dataTable.Rows.Add(dataRow);
						}
					}
				}
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x0600B08A RID: 45194 RVA: 0x004E9FB8 File Offset: 0x004E81B8
		private DataTable Schema_DataTypes()
		{
			DataTable dataTable = new DataTable("DataTypes");
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add("TypeName", typeof(string));
			dataTable.Columns.Add("ProviderDbType", typeof(int));
			dataTable.Columns.Add("ColumnSize", typeof(long));
			dataTable.Columns.Add("CreateFormat", typeof(string));
			dataTable.Columns.Add("CreateParameters", typeof(string));
			dataTable.Columns.Add("DataType", typeof(string));
			dataTable.Columns.Add("IsAutoIncrementable", typeof(bool));
			dataTable.Columns.Add("IsBestMatch", typeof(bool));
			dataTable.Columns.Add("IsCaseSensitive", typeof(bool));
			dataTable.Columns.Add("IsFixedLength", typeof(bool));
			dataTable.Columns.Add("IsFixedPrecisionScale", typeof(bool));
			dataTable.Columns.Add("IsLong", typeof(bool));
			dataTable.Columns.Add("IsNullable", typeof(bool));
			dataTable.Columns.Add("IsSearchable", typeof(bool));
			dataTable.Columns.Add("IsSearchableWithLike", typeof(bool));
			dataTable.Columns.Add("IsLiteralSupported", typeof(bool));
			dataTable.Columns.Add("LiteralPrefix", typeof(string));
			dataTable.Columns.Add("LiteralSuffix", typeof(string));
			dataTable.Columns.Add("IsUnsigned", typeof(bool));
			dataTable.Columns.Add("MaximumScale", typeof(short));
			dataTable.Columns.Add("MinimumScale", typeof(short));
			dataTable.Columns.Add("IsConcurrencyType", typeof(bool));
			dataTable.BeginLoadData();
			StringReader stringReader = new StringReader(SR.DataTypes);
			dataTable.ReadXml(stringReader);
			stringReader.Close();
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x0600B08B RID: 45195 RVA: 0x004EA25C File Offset: 0x004E845C
		private DataTable Schema_IndexColumns(string strCatalog, string strTable, string strIndex, string strColumn)
		{
			DataTable dataTable = new DataTable("IndexColumns");
			List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add("CONSTRAINT_CATALOG", typeof(string));
			dataTable.Columns.Add("CONSTRAINT_SCHEMA", typeof(string));
			dataTable.Columns.Add("CONSTRAINT_NAME", typeof(string));
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("COLUMN_NAME", typeof(string));
			dataTable.Columns.Add("ORDINAL_POSITION", typeof(int));
			dataTable.Columns.Add("INDEX_NAME", typeof(string));
			dataTable.Columns.Add("COLLATION_NAME", typeof(string));
			dataTable.Columns.Add("SORT_MODE", typeof(string));
			dataTable.Columns.Add("CONFLICT_OPTION", typeof(int));
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			dataTable.BeginLoadData();
			using (SQLiteCommand sQLiteCommand = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}] WHERE [type] LIKE 'table'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader())
				{
					while (sQLiteDataReader.Read())
					{
						bool flag = false;
						list.Clear();
						if (string.IsNullOrEmpty(strTable) || string.Compare(sQLiteDataReader.GetString(2), strTable, StringComparison.OrdinalIgnoreCase) == 0)
						{
							try
							{
								using (SQLiteCommand sQLiteCommand2 = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "PRAGMA [{0}].table_info([{1}])", new object[]
								{
									strCatalog,
									sQLiteDataReader.GetString(2)
								}), this))
								{
									using (SQLiteDataReader sQLiteDataReader2 = sQLiteCommand2.ExecuteReader())
									{
										while (sQLiteDataReader2.Read())
										{
											if (sQLiteDataReader2.GetInt32(5) == 1)
											{
												list.Add(new KeyValuePair<int, string>(sQLiteDataReader2.GetInt32(0), sQLiteDataReader2.GetString(1)));
												if (string.Compare(sQLiteDataReader2.GetString(2), "INTEGER", StringComparison.OrdinalIgnoreCase) == 0)
												{
													flag = true;
												}
											}
										}
									}
								}
							}
							catch (SQLiteException)
							{
							}
							if (list.Count == 1 && flag)
							{
								DataRow dataRow = dataTable.NewRow();
								dataRow["CONSTRAINT_CATALOG"] = strCatalog;
								dataRow["CONSTRAINT_NAME"] = string.Format(CultureInfo.InvariantCulture, "{1}_PK_{0}", new object[]
								{
									sQLiteDataReader.GetString(2),
									text
								});
								dataRow["TABLE_CATALOG"] = strCatalog;
								dataRow["TABLE_NAME"] = sQLiteDataReader.GetString(2);
								dataRow["COLUMN_NAME"] = list[0].Value;
								dataRow["INDEX_NAME"] = dataRow["CONSTRAINT_NAME"];
								dataRow["ORDINAL_POSITION"] = 0;
								dataRow["COLLATION_NAME"] = "BINARY";
								dataRow["SORT_MODE"] = "ASC";
								dataRow["CONFLICT_OPTION"] = 2;
								if (string.IsNullOrEmpty(strIndex) || string.Compare(strIndex, (string)dataRow["INDEX_NAME"], StringComparison.OrdinalIgnoreCase) == 0)
								{
									dataTable.Rows.Add(dataRow);
								}
							}
							using (SQLiteCommand sQLiteCommand3 = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{2}] WHERE [type] LIKE 'index' AND [tbl_name] LIKE '{1}'", new object[]
							{
								strCatalog,
								sQLiteDataReader.GetString(2).Replace("'", "''"),
								text
							}), this))
							{
								using (SQLiteDataReader sQLiteDataReader3 = sQLiteCommand3.ExecuteReader())
								{
									while (sQLiteDataReader3.Read())
									{
										int num = 0;
										if (string.IsNullOrEmpty(strIndex) || string.Compare(strIndex, sQLiteDataReader3.GetString(1), StringComparison.OrdinalIgnoreCase) == 0)
										{
											try
											{
												using (SQLiteCommand sQLiteCommand4 = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "PRAGMA [{0}].index_info([{1}])", new object[]
												{
													strCatalog,
													sQLiteDataReader3.GetString(1)
												}), this))
												{
													using (SQLiteDataReader sQLiteDataReader4 = sQLiteCommand4.ExecuteReader())
													{
														while (sQLiteDataReader4.Read())
														{
															DataRow dataRow = dataTable.NewRow();
															dataRow["CONSTRAINT_CATALOG"] = strCatalog;
															dataRow["CONSTRAINT_NAME"] = sQLiteDataReader3.GetString(1);
															dataRow["TABLE_CATALOG"] = strCatalog;
															dataRow["TABLE_NAME"] = sQLiteDataReader3.GetString(2);
															dataRow["COLUMN_NAME"] = sQLiteDataReader4.GetString(2);
															dataRow["INDEX_NAME"] = sQLiteDataReader3.GetString(1);
															dataRow["ORDINAL_POSITION"] = num;
															int num2;
															int num3;
															string value;
															this._sql.GetIndexColumnExtendedInfo(strCatalog, sQLiteDataReader3.GetString(1), sQLiteDataReader4.GetString(2), out num2, out num3, out value);
															if (!string.IsNullOrEmpty(value))
															{
																dataRow["COLLATION_NAME"] = value;
															}
															dataRow["SORT_MODE"] = ((num2 == 0) ? "ASC" : "DESC");
															dataRow["CONFLICT_OPTION"] = num3;
															num++;
															if (string.IsNullOrEmpty(strColumn) || string.Compare(strColumn, dataRow["COLUMN_NAME"].ToString(), StringComparison.OrdinalIgnoreCase) == 0)
															{
																dataTable.Rows.Add(dataRow);
															}
														}
													}
												}
											}
											catch (SQLiteException)
											{
											}
										}
									}
								}
							}
						}
					}
				}
			}
			dataTable.EndLoadData();
			dataTable.AcceptChanges();
			return dataTable;
		}

		// Token: 0x0600B08C RID: 45196 RVA: 0x004EA95C File Offset: 0x004E8B5C
		private DataTable Schema_ViewColumns(string strCatalog, string strView, string strColumn)
		{
			DataTable dataTable = new DataTable("ViewColumns");
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add("VIEW_CATALOG", typeof(string));
			dataTable.Columns.Add("VIEW_SCHEMA", typeof(string));
			dataTable.Columns.Add("VIEW_NAME", typeof(string));
			dataTable.Columns.Add("VIEW_COLUMN_NAME", typeof(string));
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("COLUMN_NAME", typeof(string));
			dataTable.Columns.Add("ORDINAL_POSITION", typeof(int));
			dataTable.Columns.Add("COLUMN_HASDEFAULT", typeof(bool));
			dataTable.Columns.Add("COLUMN_DEFAULT", typeof(string));
			dataTable.Columns.Add("COLUMN_FLAGS", typeof(long));
			dataTable.Columns.Add("IS_NULLABLE", typeof(bool));
			dataTable.Columns.Add("DATA_TYPE", typeof(string));
			dataTable.Columns.Add("CHARACTER_MAXIMUM_LENGTH", typeof(int));
			dataTable.Columns.Add("NUMERIC_PRECISION", typeof(int));
			dataTable.Columns.Add("NUMERIC_SCALE", typeof(int));
			dataTable.Columns.Add("DATETIME_PRECISION", typeof(long));
			dataTable.Columns.Add("CHARACTER_SET_CATALOG", typeof(string));
			dataTable.Columns.Add("CHARACTER_SET_SCHEMA", typeof(string));
			dataTable.Columns.Add("CHARACTER_SET_NAME", typeof(string));
			dataTable.Columns.Add("COLLATION_CATALOG", typeof(string));
			dataTable.Columns.Add("COLLATION_SCHEMA", typeof(string));
			dataTable.Columns.Add("COLLATION_NAME", typeof(string));
			dataTable.Columns.Add("PRIMARY_KEY", typeof(bool));
			dataTable.Columns.Add("EDM_TYPE", typeof(string));
			dataTable.Columns.Add("AUTOINCREMENT", typeof(bool));
			dataTable.Columns.Add("UNIQUE", typeof(bool));
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			dataTable.BeginLoadData();
			using (SQLiteCommand sQLiteCommand = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}] WHERE [type] LIKE 'view'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader())
				{
					while (sQLiteDataReader.Read())
					{
						if (string.IsNullOrEmpty(strView) || string.Compare(strView, sQLiteDataReader.GetString(2), StringComparison.OrdinalIgnoreCase) == 0)
						{
							using (SQLiteCommand sQLiteCommand2 = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}]", new object[]
							{
								strCatalog,
								sQLiteDataReader.GetString(2)
							}), this))
							{
								string text2 = sQLiteDataReader.GetString(4).Replace('\r', ' ').Replace('\n', ' ').Replace('\t', ' ');
								int i = CultureInfo.InvariantCulture.CompareInfo.IndexOf(text2, " AS ", CompareOptions.IgnoreCase);
								if (i >= 0)
								{
									text2 = text2.Substring(i + 4);
									using (SQLiteCommand sQLiteCommand3 = new SQLiteCommand(text2, this))
									{
										using (SQLiteDataReader sQLiteDataReader2 = sQLiteCommand2.ExecuteReader(CommandBehavior.SchemaOnly))
										{
											using (SQLiteDataReader sQLiteDataReader3 = sQLiteCommand3.ExecuteReader(CommandBehavior.SchemaOnly))
											{
												using (DataTable schemaTable = sQLiteDataReader2.GetSchemaTable(false, false))
												{
													using (DataTable schemaTable2 = sQLiteDataReader3.GetSchemaTable(false, false))
													{
														for (i = 0; i < schemaTable2.Rows.Count; i++)
														{
															DataRow dataRow = schemaTable.Rows[i];
															DataRow dataRow2 = schemaTable2.Rows[i];
															if (string.Compare(dataRow[SchemaTableColumn.ColumnName].ToString(), strColumn, StringComparison.OrdinalIgnoreCase) == 0 || strColumn == null)
															{
																DataRow dataRow3 = dataTable.NewRow();
																dataRow3["VIEW_CATALOG"] = strCatalog;
																dataRow3["VIEW_NAME"] = sQLiteDataReader.GetString(2);
																dataRow3["TABLE_CATALOG"] = strCatalog;
																dataRow3["TABLE_SCHEMA"] = dataRow2[SchemaTableColumn.BaseSchemaName];
																dataRow3["TABLE_NAME"] = dataRow2[SchemaTableColumn.BaseTableName];
																dataRow3["COLUMN_NAME"] = dataRow2[SchemaTableColumn.BaseColumnName];
																dataRow3["VIEW_COLUMN_NAME"] = dataRow[SchemaTableColumn.ColumnName];
																dataRow3["COLUMN_HASDEFAULT"] = (dataRow[SchemaTableOptionalColumn.DefaultValue] != DBNull.Value);
																dataRow3["COLUMN_DEFAULT"] = dataRow[SchemaTableOptionalColumn.DefaultValue];
																dataRow3["ORDINAL_POSITION"] = dataRow[SchemaTableColumn.ColumnOrdinal];
																dataRow3["IS_NULLABLE"] = dataRow[SchemaTableColumn.AllowDBNull];
																dataRow3["DATA_TYPE"] = dataRow["DataTypeName"];
																dataRow3["EDM_TYPE"] = SQLiteConvert.DbTypeToTypeName((DbType)dataRow[SchemaTableColumn.ProviderType]).ToString().ToLower(CultureInfo.InvariantCulture);
																dataRow3["CHARACTER_MAXIMUM_LENGTH"] = dataRow[SchemaTableColumn.ColumnSize];
																dataRow3["TABLE_SCHEMA"] = dataRow[SchemaTableColumn.BaseSchemaName];
																dataRow3["PRIMARY_KEY"] = dataRow[SchemaTableColumn.IsKey];
																dataRow3["AUTOINCREMENT"] = dataRow[SchemaTableOptionalColumn.IsAutoIncrement];
																dataRow3["COLLATION_NAME"] = dataRow["CollationType"];
																dataRow3["UNIQUE"] = dataRow[SchemaTableColumn.IsUnique];
																dataTable.Rows.Add(dataRow3);
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			dataTable.EndLoadData();
			dataTable.AcceptChanges();
			return dataTable;
		}

		// Token: 0x0600B08D RID: 45197 RVA: 0x004EB124 File Offset: 0x004E9324
		private DataTable Schema_ForeignKeys(string strCatalog, string strTable, string strKeyName)
		{
			DataTable dataTable = new DataTable("ForeignKeys");
			dataTable.Locale = CultureInfo.InvariantCulture;
			dataTable.Columns.Add("CONSTRAINT_CATALOG", typeof(string));
			dataTable.Columns.Add("CONSTRAINT_SCHEMA", typeof(string));
			dataTable.Columns.Add("CONSTRAINT_NAME", typeof(string));
			dataTable.Columns.Add("TABLE_CATALOG", typeof(string));
			dataTable.Columns.Add("TABLE_SCHEMA", typeof(string));
			dataTable.Columns.Add("TABLE_NAME", typeof(string));
			dataTable.Columns.Add("CONSTRAINT_TYPE", typeof(string));
			dataTable.Columns.Add("IS_DEFERRABLE", typeof(bool));
			dataTable.Columns.Add("INITIALLY_DEFERRED", typeof(bool));
			dataTable.Columns.Add("FKEY_FROM_COLUMN", typeof(string));
			dataTable.Columns.Add("FKEY_FROM_ORDINAL_POSITION", typeof(int));
			dataTable.Columns.Add("FKEY_TO_CATALOG", typeof(string));
			dataTable.Columns.Add("FKEY_TO_SCHEMA", typeof(string));
			dataTable.Columns.Add("FKEY_TO_TABLE", typeof(string));
			dataTable.Columns.Add("FKEY_TO_COLUMN", typeof(string));
			if (string.IsNullOrEmpty(strCatalog))
			{
				strCatalog = "main";
			}
			string text = (string.Compare(strCatalog, "temp", StringComparison.OrdinalIgnoreCase) == 0) ? "sqlite_temp_master" : "sqlite_master";
			dataTable.BeginLoadData();
			using (SQLiteCommand sQLiteCommand = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "SELECT * FROM [{0}].[{1}] WHERE [type] LIKE 'table'", new object[]
			{
				strCatalog,
				text
			}), this))
			{
				using (SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader())
				{
					while (sQLiteDataReader.Read())
					{
						if (string.IsNullOrEmpty(strTable) || string.Compare(strTable, sQLiteDataReader.GetString(2), StringComparison.OrdinalIgnoreCase) == 0)
						{
							try
							{
								using (SQLiteCommandBuilder sQLiteCommandBuilder = new SQLiteCommandBuilder())
								{
									using (SQLiteCommand sQLiteCommand2 = new SQLiteCommand(string.Format(CultureInfo.InvariantCulture, "PRAGMA [{0}].foreign_key_list([{1}])", new object[]
									{
										strCatalog,
										sQLiteDataReader.GetString(2)
									}), this))
									{
										using (SQLiteDataReader sQLiteDataReader2 = sQLiteCommand2.ExecuteReader())
										{
											while (sQLiteDataReader2.Read())
											{
												DataRow dataRow = dataTable.NewRow();
												dataRow["CONSTRAINT_CATALOG"] = strCatalog;
												dataRow["CONSTRAINT_NAME"] = string.Format(CultureInfo.InvariantCulture, "FK_{0}_{1}", new object[]
												{
													sQLiteDataReader[2],
													sQLiteDataReader2.GetInt32(0)
												});
												dataRow["TABLE_CATALOG"] = strCatalog;
												dataRow["TABLE_NAME"] = sQLiteCommandBuilder.UnquoteIdentifier(sQLiteDataReader.GetString(2));
												dataRow["CONSTRAINT_TYPE"] = "FOREIGN KEY";
												dataRow["IS_DEFERRABLE"] = false;
												dataRow["INITIALLY_DEFERRED"] = false;
												dataRow["FKEY_FROM_COLUMN"] = sQLiteCommandBuilder.UnquoteIdentifier(sQLiteDataReader2[3].ToString());
												dataRow["FKEY_TO_CATALOG"] = strCatalog;
												dataRow["FKEY_TO_TABLE"] = sQLiteCommandBuilder.UnquoteIdentifier(sQLiteDataReader2[2].ToString());
												dataRow["FKEY_TO_COLUMN"] = sQLiteCommandBuilder.UnquoteIdentifier(sQLiteDataReader2[4].ToString());
												dataRow["FKEY_FROM_ORDINAL_POSITION"] = sQLiteDataReader2[1];
												if (string.IsNullOrEmpty(strKeyName) || string.Compare(strKeyName, dataRow["CONSTRAINT_NAME"].ToString(), StringComparison.OrdinalIgnoreCase) == 0)
												{
													dataTable.Rows.Add(dataRow);
												}
											}
										}
									}
								}
							}
							catch (SQLiteException)
							{
							}
						}
					}
				}
			}
			dataTable.EndLoadData();
			dataTable.AcceptChanges();
			return dataTable;
		}

		// Token: 0x14000110 RID: 272
		// (add) Token: 0x0600B08E RID: 45198 RVA: 0x004EB5F8 File Offset: 0x004E97F8
		// (remove) Token: 0x0600B08F RID: 45199 RVA: 0x00054099 File Offset: 0x00052299
		public event SQLiteUpdateEventHandler Update
		{
			add
			{
				if (this._updateHandler == null)
				{
					this._updateCallback = new SQLiteUpdateCallback(this.UpdateCallback);
					if (this._sql != null)
					{
						this._sql.SetUpdateHook(this._updateCallback);
					}
				}
				this._updateHandler = (SQLiteUpdateEventHandler)Delegate.Combine(this._updateHandler, value);
			}
			remove
			{
				this._updateHandler = (SQLiteUpdateEventHandler)Delegate.Remove(this._updateHandler, value);
				if (this._updateHandler == null)
				{
					if (this._sql != null)
					{
						this._sql.SetUpdateHook(null);
					}
					this._updateCallback = null;
				}
			}
		}

		// Token: 0x0600B090 RID: 45200 RVA: 0x000540D5 File Offset: 0x000522D5
		private void UpdateCallback(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid)
		{
			this._updateHandler(this, new UpdateEventArgs(SQLiteConvert.UTF8ToString(database, -1), SQLiteConvert.UTF8ToString(table, -1), (UpdateEventType)type, rowid));
		}

        // Token: 0x14000111 RID: 273
        // (add) Token: 0x0600B091 RID: 45201 RVA: 0x004EB650 File Offset: 0x004E9850
        // (remove) Token: 0x0600B092 RID: 45202 RVA: 0x000540FA File Offset: 0x000522FA
        public event SQLiteCommitHandler Commit;
        //{
        //add
        //{
        //	if (this._commitHandler == null)
        //	{
        //		this._commitCallback = new SQLiteCommitCallback(this.CommitCallback);
        //		if (this._sql != null)
        //		{
        //			this._sql.SetCommitHook(this._commitCallback);
        //		}
        //	}
        //	this._commitHandler = (SQLiteCommitHandler)Delegate.Combine(this._commitHandler, value);
        //}
        //remove
        //{
        //	this._commitHandler = (SQLiteCommitHandler)Delegate.Remove(this._commitHandler, value);
        //	if (this._commitHandler == null)
        //	{
        //		if (this._sql != null)
        //		{
        //			this._sql.SetCommitHook(null);
        //		}
        //		this._commitCallback = null;
        //	}
        //}
        //}

        // Token: 0x14000112 RID: 274
        // (add) Token: 0x0600B093 RID: 45203 RVA: 0x004EB6A8 File Offset: 0x004E98A8
        // (remove) Token: 0x0600B094 RID: 45204 RVA: 0x00054136 File Offset: 0x00052336
        public event EventHandler RollBack;
		//{
			//add
			//{
			//	if (this._rollbackHandler == null)
			//	{
			//		this._rollbackCallback = new SQLiteRollbackCallback(this.RollbackCallback);
			//		if (this._sql != null)
			//		{
			//			this._sql.SetRollbackHook(this._rollbackCallback);
			//		}
			//	}
			//	this._rollbackHandler = (EventHandler)Delegate.Combine(this._rollbackHandler, value);
			//}
			//remove
			//{
			//	this._rollbackHandler = (EventHandler)Delegate.Remove(this._rollbackHandler, value);
			//	if (this._rollbackHandler == null)
			//	{
			//		if (this._sql != null)
			//		{
			//			this._sql.SetRollbackHook(null);
			//		}
			//		this._rollbackCallback = null;
			//	}
			//}
		//}

		// Token: 0x0600B095 RID: 45205 RVA: 0x004EB700 File Offset: 0x004E9900
		private int CommitCallback(IntPtr parg)
		{
			CommitEventArgs commitEventArgs = new CommitEventArgs();
			this._commitHandler(this, commitEventArgs);
			if (!commitEventArgs.AbortTransaction)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x0600B096 RID: 45206 RVA: 0x00054172 File Offset: 0x00052372
		private void RollbackCallback(IntPtr parg)
		{
			this._rollbackHandler(this, EventArgs.Empty);
		}

		// Token: 0x04005D94 RID: 23956
		private const string _dataDirectory = "|DataDirectory|";

		// Token: 0x04005D95 RID: 23957
		private const string _masterdb = "sqlite_master";

		// Token: 0x04005D96 RID: 23958
		private const string _tempmasterdb = "sqlite_temp_master";

		// Token: 0x04005D97 RID: 23959
		private ConnectionState _connectionState;

		// Token: 0x04005D98 RID: 23960
		private string _connectionString;

		// Token: 0x04005D99 RID: 23961
		internal int _transactionLevel;

		// Token: 0x04005D9A RID: 23962
		private IsolationLevel _defaultIsolation;

		// Token: 0x04005D9B RID: 23963
		internal SQLiteEnlistment _enlistment;

		// Token: 0x04005D9C RID: 23964
		internal SQLiteBase _sql;

		// Token: 0x04005D9D RID: 23965
		private string _dataSource;

		// Token: 0x04005D9E RID: 23966
		private byte[] _password;

		// Token: 0x04005D9F RID: 23967
		private int _defaultTimeout = 30;

		// Token: 0x04005DA0 RID: 23968
		internal bool _binaryGuid;

		// Token: 0x04005DA1 RID: 23969
		internal long _version;

		// Token: 0x04005DA5 RID: 23973
		private SQLiteUpdateCallback _updateCallback;

		// Token: 0x04005DA6 RID: 23974
		private SQLiteCommitCallback _commitCallback;

		// Token: 0x04005DA7 RID: 23975
		private SQLiteRollbackCallback _rollbackCallback;
	}
}

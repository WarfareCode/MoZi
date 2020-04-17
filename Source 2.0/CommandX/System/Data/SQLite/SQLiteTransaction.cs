using System;
using System.Data.Common;
using System.Threading;

namespace System.Data.SQLite
{
	// Token: 0x0200143D RID: 5181
	public sealed class SQLiteTransaction : DbTransaction
	{
		// Token: 0x0600B1EF RID: 45551 RVA: 0x004EED4C File Offset: 0x004ECF4C
		internal SQLiteTransaction(SQLiteConnection connection, bool deferredLock)
		{
			this._cnn = connection;
			this._version = this._cnn._version;
			this._level = (deferredLock ? IsolationLevel.ReadCommitted : IsolationLevel.Serializable);
			if (this._cnn._transactionLevel++ == 0)
			{
				try
				{
					using (SQLiteCommand sQLiteCommand = this._cnn.CreateCommand())
					{
						if (!deferredLock)
						{
							sQLiteCommand.CommandText = "BEGIN IMMEDIATE";
						}
						else
						{
							sQLiteCommand.CommandText = "BEGIN";
						}
						sQLiteCommand.ExecuteNonQuery();
					}
				}
				catch (SQLiteException)
				{
					this._cnn._transactionLevel--;
					this._cnn = null;
					throw;
				}
			}
		}

		// Token: 0x0600B1F0 RID: 45552 RVA: 0x004EEE1C File Offset: 0x004ED01C
		public override void Commit()
		{
			this.IsValid(true);
			if (this._cnn._transactionLevel - 1 == 0)
			{
				using (SQLiteCommand sQLiteCommand = this._cnn.CreateCommand())
				{
					sQLiteCommand.CommandText = "COMMIT";
					sQLiteCommand.ExecuteNonQuery();
				}
			}
			this._cnn._transactionLevel--;
			this._cnn = null;
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x0600B1F1 RID: 45553 RVA: 0x0005483F File Offset: 0x00052A3F
		public new SQLiteConnection Connection
		{
			get
			{
				return this._cnn;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x0600B1F2 RID: 45554 RVA: 0x00054847 File Offset: 0x00052A47
		protected override DbConnection DbConnection
		{
			get
			{
				return this.Connection;
			}
		}

		// Token: 0x0600B1F3 RID: 45555 RVA: 0x0005484F File Offset: 0x00052A4F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.IsValid(false))
			{
				this.IssueRollback();
			}
			base.Dispose(disposing);
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x0600B1F4 RID: 45556 RVA: 0x0005486A File Offset: 0x00052A6A
		public override IsolationLevel IsolationLevel
		{
			get
			{
				return this._level;
			}
		}

		// Token: 0x0600B1F5 RID: 45557 RVA: 0x00054872 File Offset: 0x00052A72
		public override void Rollback()
		{
			this.IsValid(true);
			this.IssueRollback();
		}

		// Token: 0x0600B1F6 RID: 45558 RVA: 0x004EEE94 File Offset: 0x004ED094
		internal void IssueRollback()
		{
			SQLiteConnection sQLiteConnection = Interlocked.Exchange<SQLiteConnection>(ref this._cnn, null);
			if (sQLiteConnection != null)
			{
				using (SQLiteCommand sQLiteCommand = sQLiteConnection.CreateCommand())
				{
					sQLiteCommand.CommandText = "ROLLBACK";
					sQLiteCommand.ExecuteNonQuery();
				}
				sQLiteConnection._transactionLevel = 0;
			}
		}

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x004EEEF0 File Offset: 0x004ED0F0
		internal bool IsValid(bool throwError)
		{
			if (this._cnn == null)
			{
				if (throwError)
				{
					throw new ArgumentNullException("No connection associated with this transaction");
				}
				return false;
			}
			else if (this._cnn._version != this._version)
			{
				if (throwError)
				{
					throw new SQLiteException(21, "The connection was closed and re-opened, changes were already rolled back");
				}
				return false;
			}
			else if (this._cnn.State != ConnectionState.Open)
			{
				if (throwError)
				{
					throw new SQLiteException(21, "Connection was closed");
				}
				return false;
			}
			else
			{
				if (this._cnn._transactionLevel != 0 && !this._cnn._sql.AutoCommit)
				{
					return true;
				}
				this._cnn._transactionLevel = 0;
				if (throwError)
				{
					throw new SQLiteException(21, "No transaction is active on this connection");
				}
				return false;
			}
		}

		// Token: 0x04005E37 RID: 24119
		internal SQLiteConnection _cnn;

		// Token: 0x04005E38 RID: 24120
		internal long _version;

		// Token: 0x04005E39 RID: 24121
		private IsolationLevel _level;
	}
}

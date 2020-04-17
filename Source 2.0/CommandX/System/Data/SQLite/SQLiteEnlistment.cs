using System;
using System.Transactions;

namespace System.Data.SQLite
{
	// Token: 0x0200143A RID: 5178
	internal sealed class SQLiteEnlistment : IEnlistmentNotification
	{
		// Token: 0x0600B1AB RID: 45483 RVA: 0x00054550 File Offset: 0x00052750
		internal SQLiteEnlistment(SQLiteConnection cnn, Transaction scope)
		{
			this._transaction = cnn.BeginTransaction();
			this._scope = scope;
			this._scope.EnlistVolatile(this, EnlistmentOptions.None);
		}

		// Token: 0x0600B1AC RID: 45484 RVA: 0x00054579 File Offset: 0x00052779
		private void Cleanup(SQLiteConnection cnn)
		{
			if (this._disposeConnection)
			{
				cnn.Dispose();
			}
			this._transaction = null;
			this._scope = null;
		}

		// Token: 0x0600B1AD RID: 45485 RVA: 0x004ED5A8 File Offset: 0x004EB7A8
		public void Commit(Enlistment enlistment)
		{
			SQLiteConnection connection = this._transaction.Connection;
			connection._enlistment = null;
			try
			{
				this._transaction.IsValid(true);
				this._transaction.Connection._transactionLevel = 1;
				this._transaction.Commit();
				enlistment.Done();
			}
			finally
			{
				this.Cleanup(connection);
			}
		}

		// Token: 0x0600B1AE RID: 45486 RVA: 0x00054597 File Offset: 0x00052797
		public void InDoubt(Enlistment enlistment)
		{
			enlistment.Done();
		}

		// Token: 0x0600B1AF RID: 45487 RVA: 0x0005459F File Offset: 0x0005279F
		public void Prepare(PreparingEnlistment preparingEnlistment)
		{
			if (!this._transaction.IsValid(false))
			{
				preparingEnlistment.ForceRollback();
				return;
			}
			preparingEnlistment.Prepared();
		}

		// Token: 0x0600B1B0 RID: 45488 RVA: 0x004ED614 File Offset: 0x004EB814
		public void Rollback(Enlistment enlistment)
		{
			SQLiteConnection connection = this._transaction.Connection;
			connection._enlistment = null;
			try
			{
				this._transaction.Rollback();
				enlistment.Done();
			}
			finally
			{
				this.Cleanup(connection);
			}
		}

		// Token: 0x04005E27 RID: 24103
		internal SQLiteTransaction _transaction;

		// Token: 0x04005E28 RID: 24104
		internal Transaction _scope;

		// Token: 0x04005E29 RID: 24105
		internal bool _disposeConnection;
	}
}

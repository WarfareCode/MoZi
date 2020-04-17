using System;
using System.Data.Common;
using System.Runtime.Serialization;

namespace System.Data.SQLite
{
	// Token: 0x0200142E RID: 5166
	[Serializable]
	public sealed class SQLiteException : DbException
	{
		// Token: 0x0600B134 RID: 45364 RVA: 0x0005436A File Offset: 0x0005256A
		private SQLiteException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B135 RID: 45365 RVA: 0x00054374 File Offset: 0x00052574
		public SQLiteException(int errorCode, string extendedInformation) : base(SQLiteException.GetStockErrorMessage(errorCode, extendedInformation))
		{
			this._errorCode = (SQLiteErrorCode)errorCode;
		}

		// Token: 0x0600B136 RID: 45366 RVA: 0x0005438A File Offset: 0x0005258A
		public SQLiteException(string message) : base(message)
		{
		}

		// Token: 0x0600B137 RID: 45367 RVA: 0x00054393 File Offset: 0x00052593
		public SQLiteException()
		{
		}

		// Token: 0x0600B138 RID: 45368 RVA: 0x0005439B File Offset: 0x0005259B
		public SQLiteException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x0600B139 RID: 45369 RVA: 0x000543A5 File Offset: 0x000525A5
		public new SQLiteErrorCode ErrorCode
		{
			get
			{
				return this._errorCode;
			}
		}

		// Token: 0x0600B13A RID: 45370 RVA: 0x000543AD File Offset: 0x000525AD
		private static string GetStockErrorMessage(int errorCode, string errorMessage)
		{
			if (errorMessage == null)
			{
				errorMessage = "";
			}
			if (errorMessage.Length > 0)
			{
				errorMessage = "\r\n" + errorMessage;
			}
			if (errorCode < 0 || errorCode >= SQLiteException._errorMessages.Length)
			{
				errorCode = 1;
			}
			return SQLiteException._errorMessages[errorCode] + errorMessage;
		}

		// Token: 0x04005DD6 RID: 24022
		private SQLiteErrorCode _errorCode;

		// Token: 0x04005DD7 RID: 24023
		private static string[] _errorMessages = new string[]
		{
			"SQLite OK",
			"SQLite error",
			"An internal logic error in SQLite",
			"Access permission denied",
			"Callback routine requested an abort",
			"The database file is locked",
			"A table in the database is locked",
			"malloc() failed",
			"Attempt to write a read-only database",
			"Operation terminated by sqlite3_interrupt()",
			"Some kind of disk I/O error occurred",
			"The database disk image is malformed",
			"Table or record not found",
			"Insertion failed because the database is full",
			"Unable to open the database file",
			"Database lock protocol error",
			"Database is empty",
			"The database schema changed",
			"Too much data for one row of a table",
			"Abort due to constraint violation",
			"Data type mismatch",
			"Library used incorrectly",
			"Uses OS features not supported on host",
			"Authorization denied",
			"Auxiliary database format error",
			"2nd parameter to sqlite3_bind() out of range",
			"File opened that is not a database file"
		};
	}
}

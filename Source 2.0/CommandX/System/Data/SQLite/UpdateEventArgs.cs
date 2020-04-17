using System;

namespace System.Data.SQLite
{
	// Token: 0x02001421 RID: 5153
	public sealed class UpdateEventArgs : EventArgs
	{
		// Token: 0x0600B105 RID: 45317 RVA: 0x000541DA File Offset: 0x000523DA
		internal UpdateEventArgs(string database, string table, UpdateEventType eventType, long rowid)
		{
			this.Database = database;
			this.Table = table;
			this.Event = eventType;
			this.RowId = rowid;
		}

		// Token: 0x04005DB2 RID: 23986
		public readonly string Database;

		// Token: 0x04005DB3 RID: 23987
		public readonly string Table;

		// Token: 0x04005DB4 RID: 23988
		public readonly UpdateEventType Event;

		// Token: 0x04005DB5 RID: 23989
		public readonly long RowId;
	}
}

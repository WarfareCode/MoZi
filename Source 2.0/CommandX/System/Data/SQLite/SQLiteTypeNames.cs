using System;

namespace System.Data.SQLite
{
	// Token: 0x02001438 RID: 5176
	internal struct SQLiteTypeNames
	{
		// Token: 0x0600B1A3 RID: 45475 RVA: 0x00054500 File Offset: 0x00052700
		internal SQLiteTypeNames(string newtypeName, DbType newdataType)
		{
			this.typeName = newtypeName;
			this.dataType = newdataType;
		}

		// Token: 0x04005E1D RID: 24093
		internal string typeName;

		// Token: 0x04005E1E RID: 24094
		internal DbType dataType;
	}
}

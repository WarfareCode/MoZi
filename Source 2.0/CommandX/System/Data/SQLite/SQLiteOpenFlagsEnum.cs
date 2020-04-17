using System;

namespace System.Data.SQLite
{
	// Token: 0x02001433 RID: 5171
	[Flags]
	internal enum SQLiteOpenFlagsEnum
	{
		// Token: 0x04005E04 RID: 24068
		None = 0,
		// Token: 0x04005E05 RID: 24069
		ReadOnly = 1,
		// Token: 0x04005E06 RID: 24070
		ReadWrite = 2,
		// Token: 0x04005E07 RID: 24071
		Create = 4,
		// Token: 0x04005E08 RID: 24072
		SharedCache = 16777216,
		// Token: 0x04005E09 RID: 24073
		Default = 6
	}
}

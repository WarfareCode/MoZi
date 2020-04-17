using System;

namespace System.Data.SQLite
{
	// Token: 0x02001434 RID: 5172
	public enum TypeAffinity
	{
		// Token: 0x04005E0B RID: 24075
		Uninitialized,
		// Token: 0x04005E0C RID: 24076
		Int64,
		// Token: 0x04005E0D RID: 24077
		Double,
		// Token: 0x04005E0E RID: 24078
		Text,
		// Token: 0x04005E0F RID: 24079
		Blob,
		// Token: 0x04005E10 RID: 24080
		Null,
		// Token: 0x04005E11 RID: 24081
		DateTime = 10,
		// Token: 0x04005E12 RID: 24082
		None
	}
}

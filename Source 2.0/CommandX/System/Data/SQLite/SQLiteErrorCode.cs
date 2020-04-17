using System;

namespace System.Data.SQLite
{
	// Token: 0x0200142F RID: 5167
	public enum SQLiteErrorCode
	{
		// Token: 0x04005DD9 RID: 24025
		Ok,
		// Token: 0x04005DDA RID: 24026
		Error,
		// Token: 0x04005DDB RID: 24027
		Internal,
		// Token: 0x04005DDC RID: 24028
		Perm,
		// Token: 0x04005DDD RID: 24029
		Abort,
		// Token: 0x04005DDE RID: 24030
		Busy,
		// Token: 0x04005DDF RID: 24031
		Locked,
		// Token: 0x04005DE0 RID: 24032
		NoMem,
		// Token: 0x04005DE1 RID: 24033
		ReadOnly,
		// Token: 0x04005DE2 RID: 24034
		Interrupt,
		// Token: 0x04005DE3 RID: 24035
		IOErr,
		// Token: 0x04005DE4 RID: 24036
		Corrupt,
		// Token: 0x04005DE5 RID: 24037
		NotFound,
		// Token: 0x04005DE6 RID: 24038
		Full,
		// Token: 0x04005DE7 RID: 24039
		CantOpen,
		// Token: 0x04005DE8 RID: 24040
		Protocol,
		// Token: 0x04005DE9 RID: 24041
		Empty,
		// Token: 0x04005DEA RID: 24042
		Schema,
		// Token: 0x04005DEB RID: 24043
		TooBig,
		// Token: 0x04005DEC RID: 24044
		Constraint,
		// Token: 0x04005DED RID: 24045
		Mismatch,
		// Token: 0x04005DEE RID: 24046
		Misuse,
		// Token: 0x04005DEF RID: 24047
		NOLFS,
		// Token: 0x04005DF0 RID: 24048
		Auth,
		// Token: 0x04005DF1 RID: 24049
		Format,
		// Token: 0x04005DF2 RID: 24050
		Range,
		// Token: 0x04005DF3 RID: 24051
		NotADatabase,
		// Token: 0x04005DF4 RID: 24052
		Row = 100,
		// Token: 0x04005DF5 RID: 24053
		Done
	}
}

using System;

namespace System.Data.SQLite
{
	// Token: 0x02001425 RID: 5157
	public sealed class SQLiteFunctionEx : SQLiteFunction
	{
		// Token: 0x0600B11A RID: 45338 RVA: 0x0005428E File Offset: 0x0005248E
		protected CollationSequence GetCollationSequence()
		{
			return this._base.GetCollationSequence(this, this._context);
		}
	}
}

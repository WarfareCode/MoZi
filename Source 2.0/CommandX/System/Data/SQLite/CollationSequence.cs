using System;

namespace System.Data.SQLite
{
	// Token: 0x0200142C RID: 5164
	public struct CollationSequence
	{
		// Token: 0x0600B128 RID: 45352 RVA: 0x000542AA File Offset: 0x000524AA
		public int Compare(string s1, string s2)
		{
			return this._func._base.ContextCollateCompare(this.Encoding, this._func._context, s1, s2);
		}

		// Token: 0x0600B129 RID: 45353 RVA: 0x000542CF File Offset: 0x000524CF
		public int Compare(char[] c1, char[] c2)
		{
			return this._func._base.ContextCollateCompare(this.Encoding, this._func._context, c1, c2);
		}

		// Token: 0x04005DCF RID: 24015
		public string Name;

		// Token: 0x04005DD0 RID: 24016
		public CollationTypeEnum Type;

		// Token: 0x04005DD1 RID: 24017
		public CollationEncodingEnum Encoding;

		// Token: 0x04005DD2 RID: 24018
		internal SQLiteFunction _func;
	}
}

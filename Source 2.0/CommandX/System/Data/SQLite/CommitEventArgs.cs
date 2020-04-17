using System;

namespace System.Data.SQLite
{
	// Token: 0x02001422 RID: 5154
	public sealed class CommitEventArgs : EventArgs
	{
		// Token: 0x0600B106 RID: 45318 RVA: 0x000541FF File Offset: 0x000523FF
		internal CommitEventArgs()
		{
		}

		// Token: 0x04005DB6 RID: 23990
		public bool AbortTransaction;
	}
}

using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02001419 RID: 5145
	internal sealed class SQLiteStatementHandle : CriticalHandle
	{
		// Token: 0x0600B0EB RID: 45291 RVA: 0x00054185 File Offset: 0x00052385
		public static implicit operator IntPtr(SQLiteStatementHandle stmt)
		{
			return stmt.handle;
		}

		// Token: 0x0600B0EC RID: 45292 RVA: 0x000541C3 File Offset: 0x000523C3
		public static implicit operator SQLiteStatementHandle(IntPtr stmt)
		{
			return new SQLiteStatementHandle(stmt);
		}

		// Token: 0x0600B0ED RID: 45293 RVA: 0x000541CB File Offset: 0x000523CB
		private SQLiteStatementHandle(IntPtr stmt) : this()
		{
			base.SetHandle(stmt);
		}

		// Token: 0x0600B0EE RID: 45294 RVA: 0x000541A4 File Offset: 0x000523A4
		internal SQLiteStatementHandle() : base(IntPtr.Zero)
		{
		}

		// Token: 0x0600B0EF RID: 45295 RVA: 0x004EB758 File Offset: 0x004E9958
		protected override bool ReleaseHandle()
		{
			try
			{
				SQLiteBase.FinalizeStatement(this);
			}
			catch (SQLiteException)
			{
			}
			return true;
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x0600B0F0 RID: 45296 RVA: 0x000541B1 File Offset: 0x000523B1
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}
	}
}

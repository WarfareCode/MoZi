using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02001418 RID: 5144
	internal sealed class SQLiteConnectionHandle : CriticalHandle
	{
		// Token: 0x0600B0E5 RID: 45285 RVA: 0x00054185 File Offset: 0x00052385
		public static implicit operator IntPtr(SQLiteConnectionHandle db)
		{
			return db.handle;
		}

		// Token: 0x0600B0E6 RID: 45286 RVA: 0x0005418D File Offset: 0x0005238D
		public static implicit operator SQLiteConnectionHandle(IntPtr db)
		{
			return new SQLiteConnectionHandle(db);
		}

		// Token: 0x0600B0E7 RID: 45287 RVA: 0x00054195 File Offset: 0x00052395
		private SQLiteConnectionHandle(IntPtr db) : this()
		{
			base.SetHandle(db);
		}

		// Token: 0x0600B0E8 RID: 45288 RVA: 0x000541A4 File Offset: 0x000523A4
		internal SQLiteConnectionHandle() : base(IntPtr.Zero)
		{
		}

		// Token: 0x0600B0E9 RID: 45289 RVA: 0x004EB72C File Offset: 0x004E992C
		protected override bool ReleaseHandle()
		{
			try
			{
				SQLiteBase.CloseConnection(this);
			}
			catch (SQLiteException)
			{
			}
			return true;
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x0600B0EA RID: 45290 RVA: 0x000541B1 File Offset: 0x000523B1
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}
	}
}

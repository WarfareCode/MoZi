using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x0200141B RID: 5147
	// (Invoke) Token: 0x0600B0F2 RID: 45298
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void SQLiteUpdateCallback(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid);
}

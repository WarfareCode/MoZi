using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x0200141D RID: 5149
	// (Invoke) Token: 0x0600B0FA RID: 45306
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void SQLiteRollbackCallback(IntPtr puser);
}

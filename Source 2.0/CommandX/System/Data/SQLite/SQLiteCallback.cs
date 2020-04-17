using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02001427 RID: 5159
	// (Invoke) Token: 0x0600B11D RID: 45341
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void SQLiteCallback(IntPtr context, int nArgs, IntPtr argsptr);
}

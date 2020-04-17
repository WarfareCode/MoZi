using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x0200141C RID: 5148
	// (Invoke) Token: 0x0600B0F6 RID: 45302
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate int SQLiteCommitCallback(IntPtr puser);
}

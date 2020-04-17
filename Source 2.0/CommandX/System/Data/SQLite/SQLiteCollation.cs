using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02001429 RID: 5161
	// (Invoke) Token: 0x0600B125 RID: 45349
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate int SQLiteCollation(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2);
}

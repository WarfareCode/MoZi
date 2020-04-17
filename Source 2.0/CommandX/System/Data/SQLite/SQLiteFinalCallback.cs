using System;
using System.Runtime.InteropServices;

namespace System.Data.SQLite
{
	// Token: 0x02001428 RID: 5160
	// (Invoke) Token: 0x0600B121 RID: 45345
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void SQLiteFinalCallback(IntPtr context);
}

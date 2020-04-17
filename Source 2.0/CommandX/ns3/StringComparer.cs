using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ns3
{
	// Token: 0x02000B89 RID: 2953
	public sealed class StringComparer : IComparer<string>
	{
		// Token: 0x0600618C RID: 24972
		[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern int StrCmpLogicalW([MarshalAs(UnmanagedType.VBByRefStr)] ref string s1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string s2);

		// Token: 0x0600618D RID: 24973 RVA: 0x002F2F68 File Offset: 0x002F1168
		public int Compare(string x, string y)
		{
			return StringComparer.StrCmpLogicalW(ref x, ref y);
		}
	}
}

using System;
using System.Runtime.InteropServices;

namespace DiskQueue.Implementation.CrossPlatform.Unix
{
	// Token: 0x02000007 RID: 7
	public sealed class UnsafeNativeMethods
	{
		// Token: 0x06000024 RID: 36
		[DllImport("libc", BestFitMapping = false, CharSet = CharSet.Ansi, EntryPoint = "chmod", SetLastError = true, ThrowOnUnmappableChar = true)]
		private static extern int chmod_1(string path, uint mode);

		// Token: 0x06000025 RID: 37 RVA: 0x00055958 File Offset: 0x00053B58
		public static int chmod(string path, UnixFilePermissions mode)
		{
			return UnsafeNativeMethods.chmod_1(path, (uint)mode);
		}
	}
}

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ns18
{
	// Token: 0x0200037E RID: 894
	public sealed class Class1952
	{
		// Token: 0x06001584 RID: 5508 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class1952()
		{
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0008BC64 File Offset: 0x00089E64
		static Class1952()
		{
			long num = 0L;
			if (!Class1952.QueryPerformanceFrequency(ref num))
			{
				throw new NotSupportedException("The machine doesn't appear to support high resolution timer.");
			}
			Class1952.long_0 = num;
		}

		// Token: 0x06001586 RID: 5510
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32")]
		private static extern bool QueryPerformanceFrequency(ref long long_1);

		// Token: 0x06001587 RID: 5511
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32")]
		public static extern bool QueryPerformanceCounter(ref long long_1);

		// Token: 0x040008F4 RID: 2292
		public static long long_0;
	}
}

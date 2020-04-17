using System;
using System.Runtime.InteropServices;

namespace ns11
{
	// Token: 0x020002C7 RID: 711
	internal static class Class558
	{
		// Token: 0x060010AB RID: 4267
		[DllImport("Kernel32.dll")]
		private static extern bool QueryPerformanceCounter(out long perfcount);

		// Token: 0x060010AC RID: 4268
		[DllImport("Kernel32.dll")]
		private static extern bool QueryPerformanceFrequency(out long freq);

		// Token: 0x060010AD RID: 4269 RVA: 0x0000CCB7 File Offset: 0x0000AEB7
		static Class558()
		{
			Class558.QueryPerformanceFrequency(out Class558.long_1);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0000CCC4 File Offset: 0x0000AEC4
		public static void smethod_0()
		{
			Class558.QueryPerformanceCounter(out Class558.long_0);
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0007E934 File Offset: 0x0007CB34
		public static double smethod_1()
		{
			long num;
			Class558.QueryPerformanceCounter(out num);
			return (double)(num - Class558.long_0) / (double)Class558.long_1;
		}

		// Token: 0x040006B8 RID: 1720
		private static long long_0;

		// Token: 0x040006B9 RID: 1721
		private static long long_1;
	}
}

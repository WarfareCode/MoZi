using System;

namespace ns6
{
	// Token: 0x02000C70 RID: 3184
	public sealed class Exception3 : Exception
	{
		// Token: 0x060069F8 RID: 27128 RVA: 0x0002DA02 File Offset: 0x0002BC02
		internal static void smethod_0(string string_0)
		{
			throw new ArgumentNullException(string_0);
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x0002DA0A File Offset: 0x0002BC0A
		internal static void smethod_1()
		{
			throw new Exception3("Destination byte array is not enough to store decompressed data.");
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x0002DA16 File Offset: 0x0002BC16
		internal static void smethod_2()
		{
			throw new Exception3("An attempt to read beyond the end of the source byte array.");
		}

		// Token: 0x060069FB RID: 27131 RVA: 0x00006F02 File Offset: 0x00005102
		private Exception3(string string_0) : base(string_0)
		{
		}
	}
}

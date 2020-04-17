using System;
using System.Text;

namespace ns31
{
	// Token: 0x020004A9 RID: 1193
	public sealed class Class2438
	{
		// Token: 0x06001F2D RID: 7981 RVA: 0x000CE238 File Offset: 0x000CC438
		public static int smethod_0()
		{
			return Class2438.int_0;
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x000CE24C File Offset: 0x000CC44C
		public static string smethod_1(byte[] byte_0, int int_1)
		{
			return Encoding.GetEncoding(Class2438.smethod_0()).GetString(byte_0, 0, int_1);
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x000CE270 File Offset: 0x000CC470
		public static string smethod_2(byte[] byte_0)
		{
			return Class2438.smethod_1(byte_0, byte_0.Length);
		}

		// Token: 0x04000E80 RID: 3712
		private static int int_0 = 0;
	}
}

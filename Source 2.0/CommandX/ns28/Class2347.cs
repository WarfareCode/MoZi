using System;

namespace ns28
{
	// Token: 0x020007F8 RID: 2040
	public sealed class Class2347
	{
		// Token: 0x06003235 RID: 12853 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class2347()
		{
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x0001B097 File Offset: 0x00019297
		public static void smethod_0(bool bool_0)
		{
			Class2347.smethod_1(bool_0, null);
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x0001B0A0 File Offset: 0x000192A0
		public static void smethod_1(bool bool_0, string string_0)
		{
			if (bool_0)
			{
				return;
			}
			if (string_0 == null)
			{
				throw new Exception28();
			}
			throw new Exception28(string_0);
		}
	}
}

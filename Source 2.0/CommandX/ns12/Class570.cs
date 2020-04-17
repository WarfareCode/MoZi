using System;
using ns13;

namespace ns12
{
	// Token: 0x0200035B RID: 859
	public sealed class Class570
	{
		// Token: 0x0600145B RID: 5211 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class570()
		{
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0000E757 File Offset: 0x0000C957
		public static void smethod_0(bool bool_0, string string_0)
		{
			if (bool_0)
			{
				return;
			}
			if (string_0 == null)
			{
				throw new Exception9();
			}
			throw new Exception9(string_0);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0000E775 File Offset: 0x0000C975
		public static void smethod_1()
		{
			Class570.smethod_2(null);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x0000E77D File Offset: 0x0000C97D
		public static void smethod_2(string string_0)
		{
			throw new Exception9("Should never reach here" + ((string_0 != null) ? (": " + string_0) : string.Empty));
		}
	}
}

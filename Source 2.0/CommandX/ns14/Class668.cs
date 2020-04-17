using System;

namespace ns14
{
	// Token: 0x02000487 RID: 1159
	public sealed class Class668
	{
		// Token: 0x06001E0E RID: 7694 RVA: 0x000C2128 File Offset: 0x000C0328
		public static char smethod_0(Enum143 enum143_0)
		{
			char result;
			switch (enum143_0)
			{
			case Enum143.const_3:
				result = '-';
				break;
			case Enum143.const_0:
				result = 'i';
				break;
			case Enum143.const_1:
				result = 'b';
				break;
			case Enum143.const_2:
				result = 'e';
				break;
			default:
				throw new ArgumentException("Unknown location value: " + enum143_0);
			}
			return result;
		}
	}
}

using System;
using ns16;

namespace ns25
{
	// Token: 0x020005F8 RID: 1528
	internal static class Class2226
	{
		// Token: 0x060026A1 RID: 9889 RVA: 0x000EAB64 File Offset: 0x000E8D64
		public static char smethod_0(LocationType enum157_0)
		{
			char result;
			switch (enum157_0)
			{
			case LocationType.Null:
				result = '-';
				break;
			case LocationType.Interior:
				result = 'i';
				break;
			case LocationType.Boundary:
				result = 'b';
				break;
			case LocationType.Exterior:
				result = 'e';
				break;
			default:
				throw new ArgumentException("Unknown location value: " + enum157_0);
			}
			return result;
		}
	}
}

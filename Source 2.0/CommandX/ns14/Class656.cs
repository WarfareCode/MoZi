using System;
using System.Collections.Generic;
using GeoAPI.Geometries;
using ns13;

namespace ns14
{
	// Token: 0x02000456 RID: 1110
	public sealed class Class656
	{
		// Token: 0x02000457 RID: 1111
		private sealed class Class657 : IComparer<ICoordinate>
		{
			// Token: 0x06001C7F RID: 7295 RVA: 0x000B52E4 File Offset: 0x000B34E4
			public int Compare(ICoordinate x, ICoordinate y)
			{
				return Class656.Class657.smethod_0(this.icoordinate_0, x, y);
			}

			// Token: 0x06001C80 RID: 7296 RVA: 0x000B5300 File Offset: 0x000B3500
			private static int smethod_0(ICoordinate icoordinate_1, ICoordinate icoordinate_2, ICoordinate icoordinate_3)
			{
				double num = icoordinate_2.imethod_0() - icoordinate_1.imethod_0();
				double num2 = icoordinate_2.imethod_2() - icoordinate_1.imethod_2();
				double num3 = icoordinate_3.imethod_0() - icoordinate_1.imethod_0();
				double num4 = icoordinate_3.imethod_2() - icoordinate_1.imethod_2();
				int num5 = Class628.smethod_4(icoordinate_1, icoordinate_2, icoordinate_3);
				int result;
				if (num5 == 1)
				{
					result = 1;
				}
				else if (num5 == -1)
				{
					result = -1;
				}
				else
				{
					double num6 = num * num + num2 * num2;
					double num7 = num3 * num3 + num4 * num4;
					if (num6 < num7)
					{
						result = -1;
					}
					else if (num6 > num7)
					{
						result = 1;
					}
					else
					{
						result = 0;
					}
				}
				return result;
			}

			// Token: 0x04000C70 RID: 3184
			private ICoordinate icoordinate_0;
		}
	}
}

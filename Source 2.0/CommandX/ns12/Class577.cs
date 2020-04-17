using System;
using GeoAPI.Geometries;
using ns14;

namespace ns12
{
	// Token: 0x02000368 RID: 872
	public sealed class Class577
	{
		// Token: 0x060014AA RID: 5290 RVA: 0x00089874 File Offset: 0x00087A74
		public static int smethod_0(Enum141 enum141_0, ICoordinate icoordinate_0, ICoordinate icoordinate_1)
		{
			int result;
			if (icoordinate_0.imethod_8(icoordinate_1))
			{
				result = 0;
			}
			else
			{
				int num = Class577.smethod_1(icoordinate_0.imethod_0(), icoordinate_1.imethod_0());
				int num2 = Class577.smethod_1(icoordinate_0.imethod_2(), icoordinate_1.imethod_2());
				switch (enum141_0)
				{
				case Enum141.const_1:
					result = Class577.smethod_2(num, num2);
					break;
				case Enum141.const_2:
					result = Class577.smethod_2(num2, num);
					break;
				case Enum141.const_3:
					result = Class577.smethod_2(num2, -num);
					break;
				case Enum141.const_4:
					result = Class577.smethod_2(-num, num2);
					break;
				case Enum141.const_5:
					result = Class577.smethod_2(-num, -num2);
					break;
				case Enum141.const_6:
					result = Class577.smethod_2(-num2, -num);
					break;
				case Enum141.const_7:
					result = Class577.smethod_2(-num2, num);
					break;
				case Enum141.const_8:
					result = Class577.smethod_2(num, -num2);
					break;
				default:
					Class570.smethod_2("invalid octant value: " + enum141_0);
					result = 0;
					break;
				}
			}
			return result;
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00089958 File Offset: 0x00087B58
		public static int smethod_1(double double_0, double double_1)
		{
			int result;
			if (double_0 < double_1)
			{
				result = -1;
			}
			else if (double_0 > double_1)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00089988 File Offset: 0x00087B88
		private static int smethod_2(int int_0, int int_1)
		{
			int result;
			if (int_0 < 0)
			{
				result = -1;
			}
			else if (int_0 > 0)
			{
				result = 1;
			}
			else if (int_1 < 0)
			{
				result = -1;
			}
			else if (int_1 > 0)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}
	}
}

using System;
using GeoAPI.Geometries;

namespace ns14
{
	// Token: 0x0200045A RID: 1114
	public sealed class Class659
	{
		// Token: 0x06001C84 RID: 7300 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class659()
		{
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x000B53C4 File Offset: 0x000B35C4
		public static int smethod_0(double double_0, double double_1)
		{
			if (double_0 == 0.0 && double_1 == 0.0)
			{
				throw new ArgumentException(string.Concat(new object[]
				{
					"Cannot compute the quadrant for point ( ",
					double_0,
					", ",
					double_1,
					" )"
				}));
			}
			int result;
			if (double_0 >= 0.0)
			{
				if (double_1 >= 0.0)
				{
					result = 0;
				}
				else
				{
					result = 3;
				}
			}
			else if (double_1 >= 0.0)
			{
				result = 1;
			}
			else
			{
				result = 2;
			}
			return result;
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x000B546C File Offset: 0x000B366C
		public static int smethod_1(ICoordinate icoordinate_0, ICoordinate icoordinate_1)
		{
			double num = icoordinate_1.imethod_0() - icoordinate_0.imethod_0();
			double num2 = icoordinate_1.imethod_2() - icoordinate_0.imethod_2();
			if (num == 0.0 && num2 == 0.0)
			{
				throw new ArgumentException("Cannot compute the quadrant for two identical points " + icoordinate_0);
			}
			return Class659.smethod_0(num, num2);
		}
	}
}

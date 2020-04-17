using System;
using DotSpatial.Topology;

namespace ns25
{
	// Token: 0x020005CE RID: 1486
	public sealed class Class2223
	{
		// Token: 0x060025DB RID: 9691 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class2223()
		{
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x000E915C File Offset: 0x000E735C
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
				if (double_1 < 0.0)
				{
					result = 3;
				}
				else
				{
					result = 0;
				}
			}
			else if (double_1 < 0.0)
			{
				result = 2;
			}
			else
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x000E9208 File Offset: 0x000E7408
		public static int smethod_1(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			double num = coordinate_1.X - coordinate_0.X;
			double num2 = coordinate_1.Y - coordinate_0.Y;
			if (num == 0.0 && num2 == 0.0)
			{
				throw new ArgumentException("Cannot compute the quadrant for two identical points " + coordinate_0);
			}
			return Class2223.smethod_0(num, num2);
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x0001582A File Offset: 0x00013A2A
		public static bool smethod_2(int int_0)
		{
			return int_0 == 0 || int_0 == 1;
		}
	}
}

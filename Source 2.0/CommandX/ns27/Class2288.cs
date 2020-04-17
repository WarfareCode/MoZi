using System;
using DotSpatial.Topology;
using DotSpatial.Topology.Noding;

namespace ns27
{
	// Token: 0x020006E6 RID: 1766
	internal static class Class2288
	{
		// Token: 0x06002C40 RID: 11328 RVA: 0x001017FC File Offset: 0x000FF9FC
		public static OctantDirection smethod_0(double double_0, double double_1)
		{
			if (double_0 == 0.0 && double_1 == 0.0)
			{
				throw new ArgumentException(string.Concat(new object[]
				{
					"Cannot compute the octant for point ( ",
					double_0,
					", ",
					double_1,
					" )"
				}));
			}
			double num = Math.Abs(double_0);
			double num2 = Math.Abs(double_1);
			OctantDirection result;
			if (double_0 >= 0.0)
			{
				if (double_1 >= 0.0)
				{
					if (num < num2)
					{
						result = OctantDirection.One;
					}
					else
					{
						result = OctantDirection.Zero;
					}
				}
				else if (num < num2)
				{
					result = OctantDirection.Six;
				}
				else
				{
					result = OctantDirection.Seven;
				}
			}
			else if (double_1 >= 0.0)
			{
				if (num < num2)
				{
					result = OctantDirection.Two;
				}
				else
				{
					result = OctantDirection.Three;
				}
			}
			else if (num < num2)
			{
				result = OctantDirection.Five;
			}
			else
			{
				result = OctantDirection.Four;
			}
			return result;
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x001018E4 File Offset: 0x000FFAE4
		public static OctantDirection smethod_1(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			double num = coordinate_1.X - coordinate_0.X;
			double num2 = coordinate_1.Y - coordinate_0.Y;
			if (num == 0.0 && num2 == 0.0)
			{
				throw new ArgumentException("Cannot compute the octant for two identical points " + coordinate_0);
			}
			return Class2288.smethod_0(num, num2);
		}
	}
}

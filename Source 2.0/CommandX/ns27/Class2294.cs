using System;
using DotSpatial.Topology;
using DotSpatial.Topology.Noding;

namespace ns27
{
	// Token: 0x020006FE RID: 1790
	public sealed class Class2294
	{
		// Token: 0x06002CA9 RID: 11433 RVA: 0x001024E8 File Offset: 0x001006E8
		public static int smethod_0(OctantDirection octantDirection_0, Coordinate coordinate_0, Coordinate coordinate_1)
		{
			int result;
			if (coordinate_0.Equals2D(coordinate_1))
			{
				result = 0;
			}
			else
			{
				int num = Class2294.smethod_1(coordinate_0.X, coordinate_1.X);
				int num2 = Class2294.smethod_1(coordinate_0.Y, coordinate_1.Y);
				switch (octantDirection_0)
				{
				case OctantDirection.Zero:
					result = Class2294.smethod_2(num, num2);
					break;
				case OctantDirection.One:
					result = Class2294.smethod_2(num2, num);
					break;
				case OctantDirection.Two:
					result = Class2294.smethod_2(num2, -num);
					break;
				case OctantDirection.Three:
					result = Class2294.smethod_2(-num, num2);
					break;
				case OctantDirection.Four:
					result = Class2294.smethod_2(-num, -num2);
					break;
				case OctantDirection.Five:
					result = Class2294.smethod_2(-num2, -num);
					break;
				case OctantDirection.Six:
					result = Class2294.smethod_2(-num2, num);
					break;
				case OctantDirection.Seven:
					result = Class2294.smethod_2(num, -num2);
					break;
				default:
					throw new Exception24(octantDirection_0.ToString());
				}
			}
			return result;
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x001025BC File Offset: 0x001007BC
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

		// Token: 0x06002CAB RID: 11435 RVA: 0x001025E8 File Offset: 0x001007E8
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

using System;

namespace ns14
{
	// Token: 0x02000474 RID: 1140
	public sealed class Class663
	{
		// Token: 0x06001D99 RID: 7577 RVA: 0x000BF3B0 File Offset: 0x000BD5B0
		public static int smethod_0(double double_0, double double_1, double double_2, double double_3)
		{
			long num = 0L;
			int num2 = 1;
			int num3;
			int result;
			if (double_0 == 0.0 || double_3 == 0.0)
			{
				if (double_1 == 0.0 || double_2 == 0.0)
				{
					num3 = 0;
				}
				else if (double_1 > 0.0)
				{
					if (double_2 > 0.0)
					{
						num3 = -num2;
					}
					else
					{
						num3 = num2;
					}
				}
				else if (double_2 > 0.0)
				{
					num3 = num2;
				}
				else
				{
					num3 = -num2;
				}
			}
			else if (double_1 == 0.0 || double_2 == 0.0)
			{
				if (double_3 > 0.0)
				{
					if (double_0 > 0.0)
					{
						num3 = num2;
					}
					else
					{
						num3 = -num2;
					}
				}
				else if (double_0 > 0.0)
				{
					num3 = -num2;
				}
				else
				{
					num3 = num2;
				}
			}
			else
			{
				if (0.0 < double_1)
				{
					if (0.0 < double_3)
					{
						if (double_1 > double_3)
						{
							num2 = -num2;
							double num4 = double_0;
							double_0 = double_2;
							double_2 = num4;
							num4 = double_1;
							double_1 = double_3;
							double_3 = num4;
						}
					}
					else if (double_1 <= -double_3)
					{
						num2 = -num2;
						double_2 = -double_2;
						double_3 = -double_3;
					}
					else
					{
						double num4 = double_0;
						double_0 = -double_2;
						double_2 = num4;
						num4 = double_1;
						double_1 = -double_3;
						double_3 = num4;
					}
				}
				else if (0.0 < double_3)
				{
					if (-double_1 <= double_3)
					{
						num2 = -num2;
						double_0 = -double_0;
						double_1 = -double_1;
					}
					else
					{
						double num4 = -double_0;
						double_0 = double_2;
						double_2 = num4;
						num4 = -double_1;
						double_1 = double_3;
						double_3 = num4;
					}
				}
				else if (double_1 >= double_3)
				{
					double_0 = -double_0;
					double_1 = -double_1;
					double_2 = -double_2;
					double_3 = -double_3;
				}
				else
				{
					num2 = -num2;
					double num4 = -double_0;
					double_0 = -double_2;
					double_2 = num4;
					num4 = -double_1;
					double_1 = -double_3;
					double_3 = num4;
				}
				if (0.0 < double_0)
				{
					if (0.0 >= double_2)
					{
						num3 = num2;
						result = num3;
						return result;
					}
					if (double_0 > double_2)
					{
						num3 = num2;
						result = num3;
						return result;
					}
				}
				else
				{
					if (0.0 < double_2)
					{
						num3 = -num2;
						result = num3;
						return result;
					}
					if (double_0 < double_2)
					{
						num3 = -num2;
						result = num3;
						return result;
					}
					num2 = -num2;
					double_0 = -double_0;
					double_2 = -double_2;
				}
				while (true)
				{
					num += 1L;
					double num5 = Math.Floor(double_2 / double_0);
					double_2 -= num5 * double_0;
					double_3 -= num5 * double_1;
					if (double_3 < 0.0)
					{
						goto Block_37;
					}
					if (double_3 > double_1)
					{
						goto IL_3B3;
					}
					if (double_0 > double_2 + double_2)
					{
						if (double_1 < double_3 + double_3)
						{
							break;
						}
					}
					else
					{
						if (double_1 > double_3 + double_3)
						{
							goto IL_3C1;
						}
						double_2 = double_0 - double_2;
						double_3 = double_1 - double_3;
						num2 = -num2;
					}
					if (double_3 == 0.0)
					{
						goto IL_3C9;
					}
					if (double_2 == 0.0)
					{
						goto IL_3E9;
					}
					num5 = Math.Floor(double_0 / double_2);
					double_0 -= num5 * double_2;
					double_1 -= num5 * double_3;
					if (double_1 < 0.0)
					{
						goto IL_3F0;
					}
					if (double_1 > double_3)
					{
						goto IL_3F7;
					}
					if (double_2 > double_0 + double_0)
					{
						if (double_3 < double_1 + double_1)
						{
							goto Block_34;
						}
					}
					else
					{
						if (double_3 > double_1 + double_1)
						{
							goto IL_407;
						}
						double_0 = double_2 - double_0;
						double_1 = double_3 - double_1;
						num2 = -num2;
					}
					if (double_1 == 0.0)
					{
						goto IL_40E;
					}
					if (double_0 == 0.0)
					{
						goto IL_42D;
					}
				}
				num3 = num2;
				result = num3;
				return result;
				Block_34:
				num3 = -num2;
				result = num3;
				return result;
				Block_37:
				num3 = -num2;
				result = num3;
				return result;
				IL_3B3:
				num3 = num2;
				result = num3;
				return result;
				IL_3C1:
				num3 = -num2;
				result = num3;
				return result;
				IL_3C9:
				if (double_2 == 0.0)
				{
					result = 0;
					return result;
				}
				num3 = -num2;
				result = num3;
				return result;
				IL_3E9:
				num3 = num2;
				result = num3;
				return result;
				IL_3F0:
				num3 = num2;
				result = num3;
				return result;
				IL_3F7:
				num3 = -num2;
				result = num3;
				return result;
				IL_407:
				num3 = num2;
				result = num3;
				return result;
				IL_40E:
				if (double_0 == 0.0)
				{
					result = 0;
					return result;
				}
				num3 = num2;
				result = num3;
				return result;
				IL_42D:
				num3 = -num2;
			}
			result = num3;
			return result;
		}
	}
}

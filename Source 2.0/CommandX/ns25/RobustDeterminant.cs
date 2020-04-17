using System;

namespace ns25
{
	// Token: 0x0200063E RID: 1598
	public sealed class RobustDeterminant
	{
		// Token: 0x06002889 RID: 10377 RVA: 0x000F4130 File Offset: 0x000F2330
		public static int SignOfDet2X2(double x1, double y1, double x2, double y2)
		{
			long num = 0L;
			int num2 = 1;
			int result;
			if (x1 != 0.0 && y2 != 0.0)
			{
				if (y1 != 0.0 && x2 != 0.0)
				{
					if (0.0 < y1)
					{
						if (0.0 < y2)
						{
							if (y1 > y2)
							{
								num2 = -num2;
								double num3 = x1;
								x1 = x2;
								x2 = num3;
								num3 = y1;
								y1 = y2;
								y2 = num3;
							}
						}
						else if (y1 <= -y2)
						{
							num2 = -num2;
							x2 = -x2;
							y2 = -y2;
						}
						else
						{
							double num3 = x1;
							x1 = -x2;
							x2 = num3;
							num3 = y1;
							y1 = -y2;
							y2 = num3;
						}
					}
					else if (0.0 < y2)
					{
						if (-y1 <= y2)
						{
							num2 = -num2;
							x1 = -x1;
							y1 = -y1;
						}
						else
						{
							double num3 = -x1;
							x1 = x2;
							x2 = num3;
							num3 = -y1;
							y1 = y2;
							y2 = num3;
						}
					}
					else if (y1 >= y2)
					{
						x1 = -x1;
						y1 = -y1;
						x2 = -x2;
						y2 = -y2;
					}
					else
					{
						num2 = -num2;
						double num3 = -x1;
						x1 = -x2;
						x2 = num3;
						num3 = -y1;
						y1 = -y2;
						y2 = num3;
					}
					if (0.0 < x1)
					{
						if (0.0 >= x2)
						{
							result = num2;
							return result;
						}
						if (x1 > x2)
						{
							result = num2;
							return result;
						}
					}
					else
					{
						if (0.0 < x2)
						{
							result = -num2;
							return result;
						}
						if (x1 < x2)
						{
							result = -num2;
							return result;
						}
						num2 = -num2;
						x1 = -x1;
						x2 = -x2;
					}
					while (true)
					{
						num += 1L;
						double num4 = Math.Floor(x2 / x1);
						x2 -= num4 * x1;
						y2 -= num4 * y1;
						if (y2 < 0.0)
						{
							goto Block_29;
						}
						if (y2 > y1)
						{
							goto IL_2DD;
						}
						if (x1 > x2 + x2)
						{
							if (y1 < y2 + y2)
							{
								break;
							}
						}
						else
						{
							if (y1 > y2 + y2)
							{
								goto IL_2EB;
							}
							x2 = x1 - x2;
							y2 = y1 - y2;
							num2 = -num2;
						}
						if (y2 == 0.0)
						{
							goto IL_2F3;
						}
						if (x2 == 0.0)
						{
							goto IL_313;
						}
						num4 = Math.Floor(x1 / x2);
						x1 -= num4 * x2;
						y1 -= num4 * y2;
						if (y1 < 0.0)
						{
							goto IL_31A;
						}
						if (y1 > y2)
						{
							goto IL_321;
						}
						if (x2 > x1 + x1)
						{
							if (y2 < y1 + y1)
							{
								goto Block_26;
							}
						}
						else
						{
							if (y2 > y1 + y1)
							{
								goto IL_331;
							}
							x1 = x2 - x1;
							y1 = y2 - y1;
							num2 = -num2;
						}
						if (y1 == 0.0)
						{
							goto IL_338;
						}
						if (x1 == 0.0)
						{
							goto IL_354;
						}
					}
					result = num2;
					return result;
					Block_26:
					result = -num2;
					return result;
					Block_29:
					result = -num2;
					return result;
					IL_2DD:
					result = num2;
					return result;
					IL_2EB:
					result = -num2;
					return result;
					IL_2F3:
					if (x2 == 0.0)
					{
						result = 0;
						return result;
					}
					result = -num2;
					return result;
					IL_313:
					result = num2;
					return result;
					IL_31A:
					result = num2;
					return result;
					IL_321:
					result = -num2;
					return result;
					IL_331:
					result = num2;
					return result;
					IL_338:
					if (x1 != 0.0)
					{
						result = num2;
						return result;
					}
					result = 0;
					return result;
					IL_354:
					result = -num2;
				}
				else if (y2 > 0.0)
				{
					if (x1 > 0.0)
					{
						result = num2;
					}
					else
					{
						result = -num2;
					}
				}
				else if (x1 > 0.0)
				{
					result = -num2;
				}
				else
				{
					result = num2;
				}
			}
			else if (y1 != 0.0 && x2 != 0.0)
			{
				if (y1 > 0.0)
				{
					if (x2 > 0.0)
					{
						result = -num2;
					}
					else
					{
						result = num2;
					}
				}
				else if (x2 > 0.0)
				{
					result = num2;
				}
				else
				{
					result = -num2;
				}
			}
			else
			{
				result = 0;
			}
			return result;
		}
	}
}

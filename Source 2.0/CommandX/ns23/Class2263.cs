using System;

namespace ns23
{
	// Token: 0x0200068B RID: 1675
	internal static class Class2263
	{
		// Token: 0x06002A8A RID: 10890 RVA: 0x000FED2C File Offset: 0x000FCF2C
		public static bool smethod_0(double double_0, double double_1)
		{
			double num = double_1 - double_0;
			bool result;
			if (num == 0.0)
			{
				result = true;
			}
			else
			{
				double num2 = Math.Max(Math.Abs(double_0), Math.Abs(double_1));
				double d = num / num2;
				int exponent = DoubleBits.GetExponent(d);
				result = (exponent <= -50);
			}
			return result;
		}
	}
}

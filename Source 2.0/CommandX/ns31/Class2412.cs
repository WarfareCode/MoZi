using System;

namespace ns31
{
	// Token: 0x02000419 RID: 1049
	internal static class Class2412
	{
		// Token: 0x06001A8F RID: 6799 RVA: 0x000A04B4 File Offset: 0x0009E6B4
		public static double smethod_0(double double_2)
		{
			return double_2 * double_2;
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x000A04C8 File Offset: 0x0009E6C8
		public static double smethod_1(double double_2)
		{
			double num = double_2 % 6.2831853071795862;
			if (num < 0.0)
			{
				num += 6.2831853071795862;
			}
			return num;
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000A0504 File Offset: 0x0009E704
		public static double smethod_2(double double_2, double double_3)
		{
			double result;
			if (double_3 == 0.0)
			{
				if (double_2 > 0.0)
				{
					result = 1.5707963267948966;
				}
				else
				{
					result = 4.71238898038469;
				}
			}
			else if (double_3 > 0.0)
			{
				result = Math.Atan(double_2 / double_3);
			}
			else
			{
				result = 3.1415926535897931 + Math.Atan(double_2 / double_3);
			}
			return result;
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x000A0588 File Offset: 0x0009E788
		public static double smethod_3(double double_2)
		{
			return double_2 * 57.295779513082323;
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x000A05A4 File Offset: 0x0009E7A4
		public static double smethod_4(double double_2)
		{
			return double_2 * 0.017453292519943295;
		}

		// Token: 0x04000B34 RID: 2868
		public static double double_0 = Math.Sqrt(0.0055304382151584478);

		// Token: 0x04000B35 RID: 2869
		public static double double_1 = Math.Pow(0.0065849970249924894, 4.0);
	}
}

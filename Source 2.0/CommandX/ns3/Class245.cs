using System;
using ns4;

namespace ns3
{
	// Token: 0x02000C4F RID: 3151
	public sealed class Class245
	{
		// Token: 0x060068E0 RID: 26848 RVA: 0x003853D0 File Offset: 0x003835D0
		public static double smethod_0(ref double double_0)
		{
			double_0 -= 1.0;
			double num = (double)ECM.smethod_7(double_0 / 100.0);
			double num2 = 2.0 - num + (double)ECM.smethod_7(num / 4.0);
			return (double)(ECM.smethod_7(365.25 * double_0) + ECM.smethod_7(428.4014)) + 1720994.5 + num2;
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x0038544C File Offset: 0x0038364C
		public static double smethod_1(ref double double_0)
		{
			double num = (double)ECM.smethod_7(double_0 * 0.001);
			if (num < 57.0)
			{
				num += 2000.0;
			}
			else
			{
				num += 1900.0;
			}
			double num2 = double_0 - (double)ECM.smethod_7(double_0 * 0.001) * 1000.0;
			return Class245.smethod_0(ref num) + num2;
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x003854C4 File Offset: 0x003836C4
		public static double smethod_2(ref double double_0, ref double double_1)
		{
			double num = (double)ECM.smethod_7(double_0 * 0.001);
			if (num < 57.0)
			{
				num += 2000.0;
			}
			else
			{
				num += 1900.0;
			}
			double num2 = double_0 - (double)ECM.smethod_7(double_0 * 0.001) * 1000.0;
			double num3 = num2 - (double)ECM.smethod_7(num2);
			num2 = (double)ECM.smethod_7(num2);
			double num4 = Class245.smethod_0(ref num) + num2;
			double num5 = (num4 - 2451545.0) / 36525.0;
			double num6 = 24110.54841 + num5 * (8640184.812866 + num5 * (0.093104 - num5 * 6.2E-06));
			num6 = Class244.smethod_2(num6 + 86636.555366976 * num3, 86400.0);
			double result = 6.28318530717958 * num6 / 86400.0;
			double_1 = num4 - 2433281.5 + num3;
			return result;
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x003855E0 File Offset: 0x003837E0
		public static double smethod_3(ref DateTime dateTime_0)
		{
			double num = (double)dateTime_0.Year;
			return Class245.smethod_0(ref num) + (double)Class245.smethod_5(dateTime_0.Year, dateTime_0.Month, dateTime_0.Day) + Class245.smethod_4(dateTime_0.Hour, dateTime_0.Minute, (double)dateTime_0.Second) + 5.787037E-06;
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x0038563C File Offset: 0x0038383C
		public static double smethod_4(int int_0, int int_1, double double_0)
		{
			double num = (double)int_0;
			double num2 = (double)int_1;
			return (num + (num2 + double_0 / 60.0) / 60.0) / 24.0;
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x00385674 File Offset: 0x00383874
		public static int smethod_5(int int_0, int int_1, int int_2)
		{
			int[] array = new int[]
			{
				31,
				28,
				31,
				30,
				31,
				30,
				31,
				31,
				30,
				31,
				30,
				31
			};
			int num = 0;
			for (int i = 0; i < int_1 - 1; i++)
			{
				num += array[i];
			}
			num += int_2;
			if (int_0 % 4 == 0 & (int_0 % 100 != 0 | int_0 % 400 == 0) & int_1 > 2)
			{
				num++;
			}
			return num;
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x003856E0 File Offset: 0x003838E0
		public static double smethod_6(double double_0)
		{
			double num = Class244.smethod_7(double_0 + 0.5);
			double_0 -= num;
			double num2 = (double_0 - 2451545.0) / 36525.0;
			double num3 = 24110.54841 + num2 * (8640184.812866 + num2 * (0.093104 - num2 * 6.2E-06));
			num3 = Class244.smethod_2(num3 + 86636.555366976 * num, 86400.0);
			return 6.28318530717958 * num3 / 86400.0;
		}
	}
}

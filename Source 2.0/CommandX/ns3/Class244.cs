using System;
using ns4;

namespace ns3
{
	// Token: 0x02000C4E RID: 3150
	public sealed class Class244
	{
		// Token: 0x060068D6 RID: 26838 RVA: 0x003850EC File Offset: 0x003832EC
		public static double smethod_0(double double_0)
		{
			double_0 = Math.Pow(double_0, 3.0);
			return double_0;
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x00385110 File Offset: 0x00383310
		public static double smethod_1(double double_0)
		{
			double_0 *= double_0;
			return double_0;
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x00385128 File Offset: 0x00383328
		public static double smethod_2(double double_0, double double_1)
		{
			double num = double_0 - (double)ECM.smethod_7(double_0 / double_1) * double_1;
			double result;
			if (num >= 0.0)
			{
				result = num;
			}
			else
			{
				num += double_1;
				result = num;
			}
			return result;
		}

		// Token: 0x060068D9 RID: 26841 RVA: 0x00385168 File Offset: 0x00383368
		public static double smethod_3(ref double double_0)
		{
			double num = double_0 % 6.28318530717958;
			if (num < 0.0)
			{
				num += 6.28318530717958;
			}
			return num;
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x0002D286 File Offset: 0x0002B486
		public static void smethod_4(ref Class242.Struct26 struct26_0)
		{
			struct26_0.double_0[3] = Math.Sqrt(Class244.smethod_1(struct26_0.double_0[0]) + Class244.smethod_1(struct26_0.double_0[1]) + Class244.smethod_1(struct26_0.double_0[2]));
		}

		// Token: 0x060068DB RID: 26843 RVA: 0x003851A4 File Offset: 0x003833A4
		public static double smethod_5(ref double double_0, ref double double_1)
		{
			double result;
			if (double_1 == 0.0)
			{
				if (double_0 > 0.0)
				{
					result = 1.570796326794895;
				}
				else
				{
					result = 4.7123889803846852;
				}
			}
			else if (double_1 > 0.0)
			{
				result = Math.Atan(double_0 / double_1);
			}
			else
			{
				result = 3.14159265358979 + Math.Atan(double_0 / double_1);
			}
			return result;
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x00385230 File Offset: 0x00383430
		public static void smethod_6(double double_0, ref Class242.Struct26 struct26_0, ref Class242.Struct30 struct30_0)
		{
			struct30_0.double_3 = Class244.smethod_5(ref struct26_0.double_0[1], ref struct26_0.double_0[0]);
			double num = struct30_0.double_3 - Class245.smethod_6(double_0);
			struct30_0.double_1 = Class244.smethod_3(ref num);
			double num2 = Math.Sqrt(Class244.smethod_1(struct26_0.double_0[0]) + Class244.smethod_1(struct26_0.double_0[1]));
			double num3 = 0.0066943177782667227;
			struct30_0.double_0 = Class244.smethod_5(ref struct26_0.double_0[2], ref num2);
			double double_;
			double num4;
			do
			{
				double_ = struct30_0.double_0;
				num4 = 1.0 / Math.Sqrt(1.0 - num3 * Class244.smethod_1(Math.Sin(double_)));
				num = struct26_0.double_0[2] + 6378.135 * num4 * num3 * Math.Sin(double_);
				struct30_0.double_0 = Class244.smethod_5(ref num, ref num2);
			}
			while (Math.Abs(struct30_0.double_0 - double_) >= 1E-10);
			struct30_0.double_2 = num2 / Math.Cos(struct30_0.double_0) - 6378.135 * num4;
			if (struct30_0.double_0 > 1.570796326794895)
			{
				struct30_0.double_0 -= 6.28318530717958;
			}
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x0038539C File Offset: 0x0038359C
		public static double smethod_7(double double_0)
		{
			return double_0 - (double)ECM.smethod_7(double_0);
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x003853B4 File Offset: 0x003835B4
		public static double smethod_8(double double_0)
		{
			return double_0 / 0.0174532925199433;
		}
	}
}

using System;
using Command_Core;

namespace ns3
{
	// Token: 0x02000BC8 RID: 3016
	public sealed class Class258
	{
		// Token: 0x0600640B RID: 25611 RVA: 0x0002BE88 File Offset: 0x0002A088
		public static void smethod_0(double double_0, double double_1, ref double double_2, ref double double_3)
		{
			double_2 = double_0 * 0.51444444444444448 * Math.Sin(double_1 * 0.0174532925199433);
			double_3 = double_0 * 0.51444444444444448 * Math.Cos(double_1 * 0.0174532925199433);
		}

		// Token: 0x0600640C RID: 25612 RVA: 0x0031633C File Offset: 0x0031453C
		public static double smethod_1(double double_0, double double_1, double double_2, double double_3, double double_4, double double_5, double double_6, double double_7)
		{
			Class258.Class259 @class = new Class258.Class259(double_0, double_1);
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			double result;
			if (!@class.method_1(double_4, double_5, ref num3, ref num4, false))
			{
				result = 0.0;
			}
			else
			{
				double num5 = num - num3;
				double num6 = num2 - num4;
				double num7 = 0.0;
				double num8 = 0.0;
				Class258.smethod_0(double_2, double_3, ref num7, ref num8);
				double num9 = 0.0;
				double num10 = 0.0;
				Class258.smethod_0(double_6, double_7, ref num9, ref num10);
				double num11 = num7 - num9;
				double num12 = num8 - num10;
				double num13;
				if (num5 == 0.0 & num6 == 0.0)
				{
					num13 = -Math.Sqrt(num11 * num11 + num12 * num12);
				}
				else
				{
					num13 = -(num5 * num11 + num6 * num12) / Math.Sqrt(num5 * num5 + num6 * num6);
				}
				result = num13 * 3600.0 / 1852.0;
			}
			return result;
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x00316480 File Offset: 0x00314680
		public static Class258.Location smethod_2(double double_0, double double_1, double double_2)
		{
			Class258.Location result = default(Class258.Location);
			double num = double_2 + 6371000.0;
			double num2 = num * Math.Cos(double_0 * 0.0174532925199433);
			result.longitude = num2 * Math.Cos(double_1 * 0.0174532925199433);
			result.latitude = num2 * Math.Sin(double_1 * 0.0174532925199433);
			result.altitude = num * Math.Sin(double_0 * 0.0174532925199433);
			return result;
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x00316504 File Offset: 0x00314704
		public static void smethod_3(double double_0, double double_1, double double_2, ref double double_3, ref double double_4, ref double double_5)
		{
			double num = double_2 + 6371000.0;
			double num2 = num * Math.Cos(double_0 * 0.0174532925199433);
			double_3 = num2 * Math.Cos(double_1 * 0.0174532925199433);
			double_4 = num2 * Math.Sin(double_1 * 0.0174532925199433);
			double_5 = num * Math.Sin(double_0 * 0.0174532925199433);
		}

		// Token: 0x0600640F RID: 25615 RVA: 0x00316570 File Offset: 0x00314770
		public static void smethod_4(double double_0, double double_1, double double_2, ref double double_3, ref double double_4, ref double double_5)
		{
			double num = Math.Sqrt(double_0 * double_0 + double_1 * double_1 + double_2 * double_2);
			double_4 = Math.Atan2(double_1, double_0) * 57.2957795130823;
			double_3 = Math.Asin(double_2 / num) * 57.2957795130823;
			double_5 = num - 6371000.0;
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x003165C4 File Offset: 0x003147C4
		public static double smethod_5(double double_0)
		{
			double result;
			if (Math.Abs(double_0) <= 3.14159265359)
			{
				result = double_0;
			}
			else
			{
				double_0 += 3.14159265358979;
				double_0 -= 6.28318530717959 * Math.Floor(double_0 / 6.28318530717959);
				double_0 -= 3.14159265358979;
				result = double_0;
			}
			return result;
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x00316630 File Offset: 0x00314830
		public static double smethod_6(double double_0)
		{
			double result;
			if (Math.Abs(double_0) <= 180.0)
			{
				result = double_0;
			}
			else
			{
				double num = double_0 + 180.0;
				num -= 360.0 * Math.Floor(num / 360.0);
				num -= 180.0;
				result = num;
			}
			return result;
		}

		// Token: 0x06006412 RID: 25618 RVA: 0x0002BEC6 File Offset: 0x0002A0C6
		public static void smethod_7(double double_0, double double_1, ref double double_2, ref double double_3, double double_4, double double_5)
		{
			Class258.smethod_11(double_0, double_1, ref double_2, ref double_3, double_4, double_5);
		}

		// Token: 0x06006413 RID: 25619 RVA: 0x00316698 File Offset: 0x00314898
		public static double GetLookDownAngle(double HorizontalRangeToTargetUnit, double ParentPlatformAltitude_ASL, double TargetUnitAltitude_ASL)
		{
			double d = HorizontalRangeToTargetUnit * 1852.0 / 6371000.0;
			double num = 6371000.0 + TargetUnitAltitude_ASL;
			double num2 = 6371000.0 + ParentPlatformAltitude_ASL;
			double num3 = num * num;
			double num4 = num2 * num2;
			double num5 = Math.Sqrt(num3 + num4 - 2.0 * num * num2 * Math.Cos(d));
			return Math.Acos((num5 * num5 + num3 - num4) / (2.0 * num5 * num)) * 57.2957795130823 - 90.0;
		}

		// Token: 0x06006414 RID: 25620 RVA: 0x00316734 File Offset: 0x00314934
		public static void smethod_9(double double_0, double double_1, double double_2, int int_0, ref Class258.Location[] struct33_0)
		{
			if (int_0 < 3)
			{
				throw new Exception("insufficient numpoints");
			}
			double double_3 = Class258.smethod_6(double_1);
			struct33_0 = new Class258.Location[int_0 - 1 + 1];
			double num = 0.0;
			double num2 = 360.0 / (double)int_0;
			int num3 = int_0 - 1;
			for (int i = 0; i <= num3; i++)
			{
				struct33_0[i].altitude = 0.0;
				Class258.smethod_7(double_0, double_3, ref struct33_0[i].latitude, ref struct33_0[i].longitude, num, double_2);
				num += num2;
			}
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x003167DC File Offset: 0x003149DC
		public static double smethod_10(double double_0, double double_1, double double_2)
		{
			double d = double_0 * 1852.0 / 6371000.0;
			double num = 6371000.0 + double_1;
			double num2 = 6371000.0 + double_2;
			return Math.Sqrt(num * num + num2 * num2 - 2.0 * num * num2 * Math.Cos(d)) / 1852.0;
		}

		// Token: 0x06006416 RID: 25622 RVA: 0x00316844 File Offset: 0x00314A44
		public static void smethod_11(double double_0, double double_1, ref double double_2, ref double double_3, double double_4, double double_5)
		{
			if (double_5 == 0.0)
			{
				double_2 = double_0;
				double_3 = double_1;
			}
			else
			{
				double num = 6378137.0;
				double num2 = 0.0033528106647474805;
				double num3 = 6356752.3142451793;
				double num4 = 1852.0;
				double num5 = double_5 * num4;
				double a = double_0 * 0.0174532925199433;
				double num6 = double_1 * 0.0174532925199433;
				double num7 = double_4 * 0.0174532925199433;
				num7 = Class258.smethod_5(num7);
				double num8 = Math.Atan(0.99664718933525254 * Math.Tan(a));
				double num9 = Math.Cos(num8);
				double num10 = Math.Sin(num8);
				double num11;
				if (Math.Cos(num7) == 0.0)
				{
					num11 = 0.0;
				}
				else
				{
					num11 = Math.Atan2(Math.Tan(num8), Math.Cos(num7));
				}
				double num12 = num9 * Math.Sin(num7);
				double num13 = 1.0 - num12 * num12;
				double num14 = num13 * (num * num - num3 * num3) / (num3 * num3);
				double num15 = 1.0 + num14 / 16384.0 * (4096.0 + num14 * (-768.0 + num14 * (320.0 - 175.0 * num14)));
				double num16 = num14 / 1024.0 * (256.0 + num14 * (-128.0 + num14 * (74.0 - 47.0 * num14)));
				double num17 = num5 / (num3 * num15);
				double num18 = Math.Cos(num17);
				double num19 = Math.Sin(num17);
				int num20 = 1;
				double num21;
				do
				{
					num21 = Math.Cos(2.0 * num11 + num17);
					double num22 = num16 * num19 * (num21 + 0.25 * num16 * (num18 * (-1.0 + 2.0 * num21 * num21) - 0.166666666666666 * num16 * num21 * (-3.0 + 4.0 * num19 * num19) * (-3.0 + 4.0 * num21 * num21)));
					num17 = num5 / (num3 * num15) + num22;
					num18 = Math.Cos(num17);
					num19 = Math.Sin(num17);
					if (Math.Abs(num22) < 1E-10)
					{
						break;
					}
					num20++;
				}
				while (num20 <= 5);
				double num23 = num10 * num19 - num9 * num18 * Math.Cos(num7);
				double num24 = Math.Atan2(num10 * num18 + num9 * num19 * Math.Cos(num7), (1.0 - num2) * Math.Sqrt(num12 * num12 + num23 * num23));
				double num25 = Math.Atan2(num19 * Math.Sin(num7), num9 * num18 - num10 * num19 * Math.Cos(num7));
				double num26 = num2 / 16.0 * (1.0 - num12 * num12) * (4.0 + num2 * (4.0 - 3.0 * num13));
				double num27 = num25 - (1.0 - num26) * num2 * num12 * (num17 + num26 * num19 * (num21 + num26 * num18 * (-1.0 + 2.0 * num21 * num21)));
				double num28 = num6 + num27;
				double_2 = num24 * 57.2957795130823;
				double_3 = num28 * 57.2957795130823;
				if (double_3 == 360.0)
				{
					double_3 = 0.0;
				}
				double num29 = Math.Atan2(num12, -num10 * num19 + num9 * num18 * Math.Cos(num7));
				if (num29 < 0.0)
				{
					num29 += 6.28318530717959;
				}
				if ((double_0 == 90.0 | double_0 == -90.0) && !(double_1 == -180.0 | double_1 == 180.0))
				{
					double_2 = -double_2;
				}
			}
		}

		// Token: 0x02000BC9 RID: 3017
		public sealed class Class259
		{
			// Token: 0x06006418 RID: 25624 RVA: 0x00316C98 File Offset: 0x00314E98
			protected void method_0(double double_19, double double_20)
			{
				this.double_18 = this.double_16 * (1.0 - this.double_17);
				double num = 0.0;
				if (this.method_1(89.999999999999972, 89.999999999999986, ref this.double_6, ref this.double_7, false) && this.method_1(0.0, 89.999999999999986, ref this.double_6, ref num, false))
				{
					this.double_2 = double_19;
					this.double_0 = double_19 * 0.0174532925199433;
					double num2 = Class258.smethod_6(double_20);
					this.double_1 = num2 * 0.0174532925199433;
					this.double_3 = num2;
				}
			}

			// Token: 0x06006419 RID: 25625 RVA: 0x00316D54 File Offset: 0x00314F54
			public Class259()
			{
				this.double_0 = 0.0;
				this.double_1 = 0.0;
				this.double_2 = 0.0;
				this.double_3 = 0.0;
				this.double_4 = 0.0;
				this.double_5 = 0.0;
				this.double_8 = 1.0;
				this.double_9 = 6367449.1458008;
				this.double_10 = 16038.508696861;
				this.double_11 = 16.832613334334;
				this.double_12 = 0.021984404273757;
				this.double_13 = 3.1148371319283E-05;
				this.double_14 = 0.00669437999014138;
				this.double_15 = 0.0067394967565869;
				this.double_16 = 6378137.0;
				this.double_17 = 0.0033528106647474805;
				this.method_0(0.0, 0.0);
			}

			// Token: 0x0600641A RID: 25626 RVA: 0x00316ECC File Offset: 0x003150CC
			public Class259(double double_19, double double_20)
			{
				this.double_0 = 0.0;
				this.double_1 = 0.0;
				this.double_2 = 0.0;
				this.double_3 = 0.0;
				this.double_4 = 0.0;
				this.double_5 = 0.0;
				this.double_8 = 1.0;
				this.double_9 = 6367449.1458008;
				this.double_10 = 16038.508696861;
				this.double_11 = 16.832613334334;
				this.double_12 = 0.021984404273757;
				this.double_13 = 3.1148371319283E-05;
				this.double_14 = 0.00669437999014138;
				this.double_15 = 0.0067394967565869;
				this.double_16 = 6378137.0;
				this.double_17 = 0.0033528106647474805;
				this.method_0(double_19, double_20);
			}

			// Token: 0x0600641B RID: 25627 RVA: 0x00317034 File Offset: 0x00315234
			public bool method_1(double double_19, double double_20, ref double double_21, ref double double_22, bool bool_0)
			{
				int num = 0;
				double num2 = double_19;
				if (Math.Abs(num2) > 89.999999999999986)
				{
					if (num2 > 0.0)
					{
						num2 = 89.999999999999986;
					}
					else
					{
						num2 = -89.999999999999986;
					}
				}
				double num3 = num2 * 0.0174532925199433;
				if (num3 < -1.5707963267948966 | num3 > 1.5707963267948966)
				{
					num++;
				}
				while (double_20 > 180.0 || double_20 < -180.0)
				{
					double_20 = Math2.NormalizeLongitude(double_20);
				}
				double num4 = double_20 * 0.0174532925199433;
				if (num4 > 3.14159265358979)
				{
					num4 -= 6.28318530717958;
				}
				if (num4 < this.double_1 - 1.570796326794897 | num4 > this.double_1 + 1.570796326794897)
				{
					double num5;
					if (num4 < 0.0)
					{
						num5 = num4 + 6.28318530717958;
					}
					else
					{
						num5 = num4;
					}
					double num6;
					if (this.double_1 < 0.0)
					{
						num6 = this.double_1 + 6.28318530717958;
					}
					else
					{
						num6 = this.double_1;
					}
					if (!bool_0)
					{
						if (num5 < num6 - 1.570796326794897 | num5 > num6 + 1.570796326794897)
						{
							num += 2;
						}
					}
					else
					{
						double num7 = 3.141592653589794;
						if (num5 < num6 - num7 | num5 > num6 + num7)
						{
							num += 2;
						}
					}
				}
				bool result;
				if (num != 0)
				{
					result = false;
				}
				else
				{
					double num8 = num4 - this.double_1;
					if (Math.Abs(num8) > 0.15707963267948968)
					{
						num += 512;
					}
					if (num8 > 3.14159265358979)
					{
						num8 -= 6.28318530717958;
					}
					if (num8 < -3.14159265358979)
					{
						num8 += 6.28318530717958;
					}
					if (Math.Abs(num8) < 1E-60)
					{
						num8 = 0.0;
					}
					double num9 = Math.Sin(num3);
					double num10 = Math.Cos(num3);
					double num11 = num10 * num10;
					double num12 = num11 * num10;
					double num13 = num12 * num11;
					double num14 = num13 * num11;
					double num15 = Math.Tan(num3);
					double num16 = num15 * num15;
					double num17 = num16 * num15 * num15;
					double num18 = num17 * num15 * num15;
					double num19 = this.double_15 * num11;
					double num20 = num19 * num19;
					double num21 = num20 * num19;
					double num22 = num21 * num19;
					double num23 = this.method_4(num3);
					double num24 = this.method_5(num3);
					double num25 = this.method_5(this.double_0);
					double num26 = (num24 - num25) * this.double_8;
					double num27 = num23 * num9 * num10 * this.double_8 / 2.0;
					double num28 = num23 * num9 * num12 * this.double_8 * (5.0 - num16 + 9.0 * num19 + 4.0 * num20) / 24.0;
					double num29 = num23 * num9 * num13 * this.double_8 * (61.0 - 58.0 * num16 + num17 + 270.0 * num19 - 330.0 * num16 * num19 + 445.0 * num20 + 324.0 * num21 - 680.0 * num16 * num20 + 88.0 * num22 - 600.0 * num16 * num21 - 192.0 * num16 * num22) / 720.0;
					double num30 = num23 * num9 * num14 * this.double_8 * (1385.0 - 3111.0 * num16 + 543.0 * num17 - num18) / 40320.0;
					double num31 = num8 * num8;
					double num32 = num31 * num8;
					double num33 = num31 * num31;
					double num34 = num33 * num8;
					double num35 = num33 * num31;
					double num36 = num35 * num8;
					double num37 = num33 * num33;
					double_22 = this.double_4 + num26 + num31 * num27 + num33 * num28 + num35 * num29 + num37 * num30;
					double num38 = num23 * num10 * this.double_8;
					double num39 = num23 * num12 * this.double_8 * (1.0 - num16 + num19) / 6.0;
					double num40 = num23 * num13 * this.double_8 * (5.0 - 18.0 * num16 + num17 + 14.0 * num19 - 58.0 * num16 * num19 + 13.0 * num20 + 4.0 * num21 - 64.0 * num16 * num20 - 24.0 * num16 * num21) / 120.0;
					double num41 = num23 * num14 * this.double_8 * (61.0 - 479.0 * num16 + 179.0 * num17 - num18) / 5040.0;
					double_21 = this.double_5 + num8 * num38 + num32 * num39 + num34 * num40 + num36 * num41;
					result = true;
				}
				return result;
			}

			// Token: 0x0600641C RID: 25628 RVA: 0x003175F0 File Offset: 0x003157F0
			protected double method_2(double double_19)
			{
				double num = this.method_3(double_19);
				return this.double_16 * (1.0 - this.double_14) / (num * num * num);
			}

			// Token: 0x0600641D RID: 25629 RVA: 0x00317624 File Offset: 0x00315824
			protected double method_3(double double_19)
			{
				double num = Math.Sin(double_19);
				return Math.Sqrt(1.0 - this.double_14 * (num * num));
			}

			// Token: 0x0600641E RID: 25630 RVA: 0x00317654 File Offset: 0x00315854
			protected double method_4(double double_19)
			{
				double num = Math.Sin(double_19);
				return this.double_16 / Math.Sqrt(1.0 - this.double_14 * (num * num));
			}

			// Token: 0x0600641F RID: 25631 RVA: 0x0031768C File Offset: 0x0031588C
			protected double method_5(double double_19)
			{
				return this.double_9 * double_19 - this.double_10 * Math.Sin(2.0 * double_19) + this.double_11 * Math.Sin(4.0 * double_19) - this.double_12 * Math.Sin(6.0 * double_19) + this.double_13 * Math.Sin(8.0 * double_19);
			}

			// Token: 0x06006420 RID: 25632 RVA: 0x00317704 File Offset: 0x00315904
			public bool method_6(double double_19, double double_20, ref double double_21, ref double double_22)
			{
				int num = 0;
				if (double_19 < this.double_5 - this.double_6 | double_19 > this.double_5 + this.double_6)
				{
					num += 4;
				}
				if (double_20 < this.double_4 - this.double_7 | double_20 > this.double_4 + this.double_7)
				{
					num += 8;
				}
				bool result;
				if (num != 0)
				{
					result = false;
				}
				else
				{
					double num2 = this.double_9 * this.double_0 - this.double_10 * Math.Sin(2.0 * this.double_0) + this.double_11 * Math.Sin(4.0 * this.double_0) - this.double_12 * Math.Sin(6.0 * this.double_0) + this.double_13 * Math.Sin(8.0 * this.double_0) + (double_20 - this.double_4) / this.double_8;
					double num3 = this.method_2(0.0);
					double num4 = num2 / num3;
					int num5 = 0;
					double num6;
					do
					{
						num6 = this.method_5(num4);
						num3 = this.method_2(num4);
						num4 += (num2 - num6) / num3;
						num5++;
					}
					while (num5 <= 4);
					num3 = this.method_2(num4);
					double num7 = this.method_4(num4);
					Math.Sin(num4);
					double num8 = Math.Cos(num4);
					double num9 = Math.Tan(num4);
					double num10 = num9 * num9;
					double num11 = num10 * num10;
					double num12 = num11 * num10;
					double num13 = this.double_15 * (num8 * num8);
					double num14 = num13 * num13;
					double num15 = num14 * num13;
					double num16 = num15 * num13;
					double num17 = double_19 - this.double_5;
					if (Math.Abs(num17) < 0.0001)
					{
						num17 = 0.0;
					}
					double num18 = this.double_8 * this.double_8;
					double num19 = num18 * this.double_8;
					double num20 = num18 * num18;
					double num21 = num20 * this.double_8;
					double num22 = num20 * num18;
					double num23 = num22 * this.double_8;
					double num24 = num20 * num20;
					double num25 = num7 * num7;
					double num26 = num25 * num7;
					double num27 = num26 * num25;
					double num28 = num27 * num25;
					double num29 = num17 * num17;
					double num30 = num29 * num17;
					double num31 = num29 * num29;
					double num32 = num31 * num17;
					double num33 = num31 * num29;
					double num34 = num33 * num17;
					double num35 = num31 * num31;
					num6 = num9 / (2.0 * num3 * num7 * num18);
					double num36 = num9 * (5.0 + 3.0 * num10 + num13 - 4.0 * num14 - 9.0 * num10 * num13) / (24.0 * num3 * num26 * num20);
					double num37 = num9 * (61.0 + 90.0 * num10 + 46.0 * num13 + 45.0 * num11 - 252.0 * num10 * num13 - 3.0 * num14 + 100.0 * num15 - 66.0 * num10 * num14 - 90.0 * num11 * num13 + 88.0 * num16 + 225.0 * num11 * num14 + 84.0 * num10 * num15 - 192.0 * num10 * num16) / (720.0 * num3 * num27 * num22);
					double num38 = num9 * (1385.0 + 3633.0 * num10 + 4095.0 * num11 + 1575.0 * num12) / (40320.0 * num3 * num28 * num24);
					double num39 = num4 - num29 * num6 + num31 * num36 - num33 * num37 + num35 * num38;
					double num40 = 1.0 / (num7 * num8 * this.double_8);
					double num41 = (1.0 + 2.0 * num10 + num13) / (6.0 * num26 * num8 * num19);
					double num42 = (5.0 + 6.0 * num13 + 28.0 * num10 - 3.0 * num14 + 8.0 * num10 * num13 + 24.0 * num11 - 4.0 * num15 + 4.0 * num10 * num14 + 24.0 * num10 * num15) / (120.0 * num27 * num8 * num21);
					double num43 = (61.0 + 662.0 * num10 + 1320.0 * num11 + 720.0 * num12) / (5040.0 * num28 * num8 * num23);
					double num44 = num17 * num40 - num30 * num41 + num32 * num42 - num34 * num43;
					double num45 = this.double_1 + num44;
					if (Math.Abs(num39) > 1.570796326794897)
					{
						num += 8;
					}
					if (Math.Abs(num44) > 0.15707963267948968 * Math.Cos(num39 * 0.0174532925199433))
					{
						num += 512;
					}
					if (num39 > 10000000000.0)
					{
						num += 512;
					}
					double_21 = num39 * 57.2957795130823;
					double_22 = Class258.smethod_6(num45) * 57.2957795130823;
					result = true;
				}
				return result;
			}

			// Token: 0x0400364E RID: 13902
			protected double double_0;

			// Token: 0x0400364F RID: 13903
			protected double double_1;

			// Token: 0x04003650 RID: 13904
			protected double double_2 = 0.0;

			// Token: 0x04003651 RID: 13905
			protected double double_3 = 0.0;

			// Token: 0x04003652 RID: 13906
			protected double double_4 = 0.0;

			// Token: 0x04003653 RID: 13907
			protected double double_5 = 0.0;

			// Token: 0x04003654 RID: 13908
			protected double double_6 = 0.0;

			// Token: 0x04003655 RID: 13909
			protected double double_7 = 0.0;

			// Token: 0x04003656 RID: 13910
			protected double double_8;

			// Token: 0x04003657 RID: 13911
			protected double double_9;

			// Token: 0x04003658 RID: 13912
			protected double double_10;

			// Token: 0x04003659 RID: 13913
			protected double double_11;

			// Token: 0x0400365A RID: 13914
			protected double double_12;

			// Token: 0x0400365B RID: 13915
			protected double double_13;

			// Token: 0x0400365C RID: 13916
			protected double double_14;

			// Token: 0x0400365D RID: 13917
			protected double double_15;

			// Token: 0x0400365E RID: 13918
			protected double double_16;

			// Token: 0x0400365F RID: 13919
			protected double double_17;

			// Token: 0x04003660 RID: 13920
			protected double double_18;
		}

		// Token: 0x02000BCA RID: 3018
		public struct Location
		{
			// Token: 0x04003661 RID: 13921
			public double longitude;

			// Token: 0x04003662 RID: 13922
			public double latitude;

			// Token: 0x04003663 RID: 13923
			public double altitude;
		}
	}
}

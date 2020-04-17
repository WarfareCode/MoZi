using System;
using Command_Core;
using Microsoft.VisualBasic;

namespace ns3
{
	// Token: 0x02000C3B RID: 3131
	public sealed class Class240
	{
		// Token: 0x0600689C RID: 26780 RVA: 0x0037DBE4 File Offset: 0x0037BDE4
		public static string GetTimeOfDayString(Weather._TimeOfDay TimeOfDay_, DateTime dateTime_0, double double_0, bool bool_0, string string_0, string string_1)
		{
			string result;
			switch (TimeOfDay_)
			{
			case Weather._TimeOfDay.Day:
				result = "白天";
				break;
			case Weather._TimeOfDay.DawnOrDusk:
				if (Misc.GetLocalTime(dateTime_0, double_0, bool_0, string_0, string_1).Hour < 12)
				{
					result = "拂晓";
				}
				else
				{
					result = "黄昏";
				}
				break;
			case Weather._TimeOfDay.Night:
				result = "夜间";
				break;
			default:
				result = "-";
				break;
			}
			return result;
		}

		// Token: 0x0600689D RID: 26781 RVA: 0x0037DC54 File Offset: 0x0037BE54
		public static Weather._TimeOfDay GetTimeOfDay(int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, double double_0, double double_1, double double_2)
		{
			if (int_1 < 1950)
			{
				int_1 = 1950;
			}
			Class240.Class241 @class = new Class240.Class241();
			@class.int_8 = int_1;
			@class.int_6 = int_2;
			@class.int_0 = int_3;
			@class.int_3 = int_4;
			@class.int_5 = int_5;
			@class.int_7 = int_6;
			@class.int_4 = 0;
			@class.double_21 = Math2.NormalizeLatitude(double_0);
			@class.double_22 = Math2.NormalizeLongitude(double_1);
			@class.double_39 = 0.0;
			@class.int_2 = 391;
			@class.int_2 &= -2;
			if (@class.method_15() != 0L)
			{
				throw new ArgumentOutOfRangeException("Some error in solpos");
			}
			double double_3 = @class.double_12;
			Weather._TimeOfDay result;
			if (double_3 >= -0.83333333333333337)
			{
				result = Weather._TimeOfDay.Day;
			}
			else if (double_3 > -12.0)
			{
				result = Weather._TimeOfDay.DawnOrDusk;
			}
			else
			{
				result = Weather._TimeOfDay.Night;
			}
			return result;
		}

		// Token: 0x04003AA8 RID: 15016
		public static int[][] int_0 = new int[][]
		{
			new int[]
			{
				0,
				0,
				31,
				59,
				90,
				120,
				151,
				181,
				212,
				243,
				273,
				304,
				334
			},
			new int[]
			{
				0,
				0,
				31,
				60,
				91,
				121,
				152,
				182,
				213,
				244,
				274,
				305,
				335
			}
		};

		// Token: 0x02000C3C RID: 3132
		public sealed class Class241
		{
			// Token: 0x060068A0 RID: 26784 RVA: 0x0037DD88 File Offset: 0x0037BF88
			public Class241()
			{
				this.int_0 = -99;
				this.int_1 = -999;
				this.int_3 = -99;
				this.int_5 = -99;
				this.int_6 = -99;
				this.int_7 = -99;
				this.int_8 = -99;
				this.int_4 = 0;
				this.double_2 = 180.0;
				this.double_21 = -99.0;
				this.double_22 = -999.0;
				this.double_27 = 1013.0;
				this.double_33 = 1367.0;
				this.double_37 = 15.0;
				this.double_38 = 0.0;
				this.double_39 = -99.0;
				this.double_30 = 7.6;
				this.double_31 = 31.7;
				this.double_32 = 0.04;
				this.int_2 = 65535;
			}

			// Token: 0x060068A1 RID: 26785 RVA: 0x0037DEF8 File Offset: 0x0037C0F8
			public void method_0()
			{
				this.int_1 = this.int_0 + Class240.int_0[0][this.int_6];
				if (this.int_8 / 4 == 0 & (this.int_8 / 100 != 0 | this.int_8 / 400 == 0) & this.int_6 > 2)
				{
					this.int_1++;
				}
			}

			// Token: 0x060068A2 RID: 26786 RVA: 0x0037DF68 File Offset: 0x0037C168
			public void method_1(ref Class240.Struct25 struct25_0)
			{
				this.method_10(ref struct25_0);
				double num = struct25_0.double_3 * struct25_0.double_4 + struct25_0.double_0 * struct25_0.double_2 * struct25_0.double_1;
				if (Math.Abs(num) > 1.0)
				{
					if (num >= 0.0)
					{
						num = 1.0;
					}
					else
					{
						num = -1.0;
					}
				}
				this.double_44 = Math.Acos(num) * 57.2957795130823;
				if (this.double_44 > 104.0)
				{
					this.double_44 = 104.0;
				}
				this.double_11 = 90.0 - this.double_44;
			}

			// Token: 0x060068A3 RID: 26787 RVA: 0x0037E02C File Offset: 0x0037C22C
			public void method_2(ref Class240.Struct25 struct25_0)
			{
				this.method_10(ref struct25_0);
				double num = struct25_0.double_0 * struct25_0.double_2;
				if (Math.Abs(num) >= 0.001)
				{
					double num2 = -struct25_0.double_4 * struct25_0.double_3 / num;
					if (num2 < -1.0)
					{
						this.double_34 = 180.0;
					}
					else if (num2 > 1.0)
					{
						this.double_34 = 0.0;
					}
					else
					{
						this.double_34 = 57.2957795130823 * Math.Acos(num2);
					}
				}
				else if ((this.double_7 >= 0.0 && this.double_21 > 0.0) || (this.double_7 < 0.0 && this.double_21 < 0.0))
				{
					this.double_34 = 180.0;
				}
				else
				{
					this.double_34 = 0.0;
				}
			}

			// Token: 0x060068A4 RID: 26788 RVA: 0x0037E144 File Offset: 0x0037C344
			public void method_3()
			{
				if (this.double_5 > 0.0)
				{
					this.double_16 = this.double_33 * this.double_14;
					this.double_15 = this.double_16 * this.double_5;
				}
				else
				{
					this.double_16 = 0.0;
					this.double_15 = 0.0;
				}
			}

			// Token: 0x060068A5 RID: 26789 RVA: 0x0037E1B0 File Offset: 0x0037C3B0
			public void method_4(ref Class240.Struct25 struct25_0)
			{
				this.method_10(ref struct25_0);
				double num = Math.Cos(0.0174532925199433 * this.double_11);
				double num2 = Math.Sin(0.0174532925199433 * this.double_11);
				this.double_3 = 180.0;
				double num3 = num * struct25_0.double_2;
				if (Math.Abs(num3) >= 0.001)
				{
					double num4 = (num2 * struct25_0.double_4 - struct25_0.double_3) / num3;
					if (num4 > 1.0)
					{
						num4 = 1.0;
					}
					else if (num4 < -1.0)
					{
						num4 = -1.0;
					}
					this.double_3 = 180.0 - Math.Acos(num4) * 57.2957795130823;
					if (this.double_19 > 0.0)
					{
						this.double_3 = 360.0 - this.double_3;
					}
				}
			}

			// Token: 0x060068A6 RID: 26790 RVA: 0x0037E2B4 File Offset: 0x0037C4B4
			public void method_5()
			{
				this.double_42 = 1.031 * Math.Exp(-1.4 / (0.9 + 9.4 / this.double_0)) + 0.1;
				this.double_28 = 1.0 / this.double_42;
			}

			// Token: 0x060068A7 RID: 26791 RVA: 0x0037E31C File Offset: 0x0037C51C
			public void method_6(ref Class240.Struct25 struct25_0)
			{
				this.method_10(ref struct25_0);
				double num = 0.6366198 * this.double_30 / this.double_31 * Math.Pow(struct25_0.double_0, 3.0);
				double num2 = struct25_0.double_4 * struct25_0.double_3 * this.double_34 * 0.0174532925199433;
				double num3 = struct25_0.double_2 * struct25_0.double_0 * Math.Sin(this.double_34 * 0.0174532925199433);
				this.double_29 = this.double_32 + 1.0 / (1.0 - num * (num2 + num3));
			}

			// Token: 0x060068A8 RID: 26792 RVA: 0x0037E3C8 File Offset: 0x0037C5C8
			public void method_7()
			{
				if (this.double_45 > 93.0)
				{
					this.double_0 = -1.0;
					this.double_1 = -1.0;
				}
				else
				{
					this.double_0 = 1.0 / (Math.Cos(0.0174532925199433 * this.double_45) + 0.50572 * Math.Pow(96.07995 - this.double_45, -1.6364));
					this.double_1 = this.double_0 * this.double_27 / 1013.0;
				}
			}

			// Token: 0x060068A9 RID: 26793 RVA: 0x0037E478 File Offset: 0x0037C678
			public void method_8()
			{
				double num;
				if (this.double_11 > 85.0)
				{
					num = 0.0;
				}
				else
				{
					double num2 = Math.Tan(0.0174532925199433 * this.double_11);
					if (this.double_11 >= 5.0)
					{
						num = 58.1 / num2 - 0.07 / Math.Pow(num2, 3.0) + 8.6E-05 / Math.Pow(num2, 5.0);
					}
					else if (this.double_11 >= -0.575)
					{
						num = 1735.0 + this.double_11 * (-518.2 + this.double_11 * (103.4 + this.double_11 * (-12.79 + this.double_11 * 0.711)));
					}
					else
					{
						num = -20.774 / num2;
					}
					double num3 = this.double_27 * 283.0 / (1013.0 * (273.0 + this.double_37));
					num *= num3 / 3600.0;
				}
				this.double_12 = this.double_11 + num;
				if (this.double_12 < -12.0)
				{
					this.double_12 = -12.0;
				}
				this.double_45 = 90.0 - this.double_12;
				this.double_5 = Math.Cos(0.0174532925199433 * this.double_45);
			}

			// Token: 0x060068AA RID: 26794 RVA: 0x0037E62C File Offset: 0x0037C82C
			public void method_9()
			{
				int num;
				if (this.int_8 / 4 == 0 && (this.int_8 / 100 != 0 || this.int_8 / 400 == 0))
				{
					num = 1;
				}
				else
				{
					num = 0;
				}
				int num2 = 12;
				while (this.int_1 <= Class240.int_0[num][num2])
				{
					num2--;
				}
				this.int_6 = num2;
				this.int_0 = this.int_1 - Class240.int_0[num][num2];
			}

			// Token: 0x060068AB RID: 26795 RVA: 0x0037E6AC File Offset: 0x0037C8AC
			public void method_10(ref Class240.Struct25 struct25_0)
			{
				if (struct25_0.double_3 < -900.0)
				{
					struct25_0.double_3 = 1.0;
					struct25_0.double_0 = Math.Cos(0.0174532925199433 * this.double_7);
					struct25_0.double_1 = Math.Cos(0.0174532925199433 * this.double_19);
					struct25_0.double_2 = Math.Cos(0.0174532925199433 * this.double_21);
					struct25_0.double_3 = Math.Sin(0.0174532925199433 * this.double_7);
					struct25_0.double_4 = Math.Sin(0.0174532925199433 * this.double_21);
				}
			}

			// Token: 0x060068AC RID: 26796 RVA: 0x0037E768 File Offset: 0x0037C968
			public void method_11()
			{
				double num = Math.Cos(0.0174532925199433 * this.double_3);
				double num2 = Math.Cos(0.0174532925199433 * this.double_2);
				double num3 = Math.Cos(0.0174532925199433 * this.double_38);
				double num4 = Math.Sin(0.0174532925199433 * this.double_3);
				double num5 = Math.Sin(0.0174532925199433 * this.double_2);
				double num6 = Math.Sin(0.0174532925199433 * this.double_38);
				double num7 = Math.Sin(0.0174532925199433 * this.double_45);
				this.double_4 = this.double_5 * num3 + num7 * num6 * (num * num2 + num4 * num5);
				if (this.double_4 > 0.0)
				{
					this.double_17 = this.double_16 * this.double_4;
				}
				else
				{
					this.double_17 = 0.0;
				}
			}

			// Token: 0x060068AD RID: 26797 RVA: 0x0037E86C File Offset: 0x0037CA6C
			public void method_12()
			{
				if (this.double_34 <= 1.0)
				{
					this.double_35 = 2999.0;
					this.double_36 = -2999.0;
				}
				else if (this.double_34 >= 179.0)
				{
					this.double_35 = -2999.0;
					this.double_36 = 2999.0;
				}
				else
				{
					this.double_35 = 720.0 - 4.0 * this.double_34 - this.double_41;
					this.double_36 = 720.0 + 4.0 * this.double_34 - this.double_41;
				}
			}

			// Token: 0x060068AE RID: 26798 RVA: 0x0037E930 File Offset: 0x0037CB30
			public void method_13()
			{
				this.double_6 = 360.0 * (double)(this.int_1 - 1) / 365.0;
				double num = Math.Sin(0.0174532925199433 * this.double_6);
				double num2 = Math.Cos(0.0174532925199433 * this.double_6);
				double num3 = 2.0 * this.double_6;
				double num4 = Math.Cos(0.0174532925199433 * num3);
				double num5 = Math.Sin(0.0174532925199433 * num3);
				this.double_14 = 1.00011 + 0.034221 * num2 + 0.00128 * num;
				this.double_14 += 0.000719 * num4 + 7.7E-05 * num5;
				this.double_43 = (double)this.int_3 * 3600.0 + (double)this.int_5 * 60.0 + (double)this.int_7 - (double)this.int_4 / 2.0;
				this.double_43 = this.double_43 / 3600.0 - this.double_39;
				double num6 = (double)(this.int_8 - 1949);
				int num7 = (int)Math.Round(Conversion.Fix(num6 / 4.0));
				this.double_20 = 32916.5 + num6 * 365.0 + (double)num7 + (double)this.int_1 + this.double_43 / 24.0;
				this.double_10 = this.double_20 - 51545.0;
				this.double_25 = 280.46 + 0.9856474 * this.double_10;
				this.double_25 -= 360.0 * (double)((int)Math.Round(Conversion.Fix(this.double_25 / 360.0)));
				if (this.double_25 < 0.0)
				{
					this.double_25 += 360.0;
				}
				this.double_24 = 357.528 + 0.9856003 * this.double_10;
				this.double_24 -= 360.0 * (double)((int)Math.Round(Conversion.Fix(this.double_24 / 360.0)));
				if (this.double_24 < 0.0)
				{
					this.double_24 += 360.0;
				}
				this.double_8 = this.double_25 + 1.915 * Math.Sin(this.double_24 * 0.0174532925199433) + 0.02 * Math.Sin(2.0 * this.double_24 * 0.0174532925199433);
				this.double_8 -= 360.0 * (double)((int)Math.Round(Conversion.Fix(this.double_8 / 360.0)));
				if (this.double_8 < 0.0)
				{
					this.double_8 += 360.0;
				}
				this.double_9 = 23.439 - 4E-07 * this.double_10;
				this.double_7 = 57.2957795130823 * Math.Asin(Math.Sin(this.double_9 * 0.0174532925199433) * Math.Sin(this.double_8 * 0.0174532925199433));
				double y = Math.Cos(0.0174532925199433 * this.double_9) * Math.Sin(0.0174532925199433 * this.double_8);
				double x = Math.Cos(0.0174532925199433 * this.double_8);
				this.double_26 = 57.2957795130823 * Math.Atan2(y, x);
				if (this.double_26 < 0.0)
				{
					this.double_26 += 360.0;
				}
				this.double_18 = 6.697375 + 0.0657098242 * this.double_10 + this.double_43;
				this.double_18 -= 24.0 * (double)((int)Math.Round(Conversion.Fix(this.double_18 / 24.0)));
				if (this.double_18 < 0.0)
				{
					this.double_18 += 24.0;
				}
				this.double_23 = this.double_18 * 15.0 + this.double_22;
				this.double_23 -= 360.0 * (double)((int)Math.Round(Conversion.Fix(this.double_23 / 360.0)));
				if (this.double_23 < 0.0)
				{
					this.double_23 += 360.0;
				}
				this.double_19 = this.double_23 - this.double_26;
				if (this.double_19 < -180.0)
				{
					this.double_19 += 360.0;
				}
				else if (this.double_19 > 180.0)
				{
					this.double_19 -= 360.0;
				}
			}

			// Token: 0x060068AF RID: 26799 RVA: 0x0037EEF0 File Offset: 0x0037D0F0
			public void method_14()
			{
				this.double_40 = (180.0 + this.double_19) * 4.0;
				this.double_41 = this.double_40 - (double)this.int_3 * 60.0 - (double)this.int_5 - (double)this.int_7 / 60.0 + (double)this.int_4 / 120.0;
				while (this.double_41 > 720.0)
				{
					this.double_41 -= 1440.0;
				}
				while (this.double_41 < -720.0)
				{
					this.double_41 += 1440.0;
				}
				this.double_13 = this.double_41 + 60.0 * this.double_39 - 4.0 * this.double_22;
			}

			// Token: 0x060068B0 RID: 26800 RVA: 0x0037EFEC File Offset: 0x0037D1EC
			public long method_15()
			{
				Class240.Struct25 @struct;
				@struct.double_3 = -999.0;
				@struct.double_0 = 1.0;
				@struct.double_1 = 1.0;
				@struct.double_2 = 1.0;
				@struct.double_4 = 1.0;
				long num = this.method_16();
				long result;
				if (num != 0L)
				{
					result = num;
				}
				else
				{
					if ((this.int_2 & 1) != 0)
					{
						this.method_9();
					}
					else
					{
						this.method_0();
					}
					if ((this.int_2 & 2) != 0)
					{
						this.method_13();
					}
					if ((this.int_2 & 4) != 0)
					{
						this.method_1(ref @struct);
					}
					if ((this.int_2 & 8) != 0)
					{
						this.method_2(ref @struct);
					}
					if ((this.int_2 & 16) != 0)
					{
						this.method_6(ref @struct);
					}
					if ((this.int_2 & 32) != 0)
					{
						this.method_14();
					}
					if ((this.int_2 & 64) != 0)
					{
						this.method_12();
					}
					if ((this.int_2 & 128) != 0)
					{
						this.method_4(ref @struct);
					}
					if ((this.int_2 & 256) != 0)
					{
						this.method_8();
					}
					if ((this.int_2 & 512) != 0)
					{
						this.method_7();
					}
					if ((this.int_2 & 1024) != 0)
					{
						this.method_5();
					}
					if ((this.int_2 & 4096) != 0)
					{
						this.method_3();
					}
					if ((this.int_2 & 2048) != 0)
					{
						this.method_11();
					}
					result = 0L;
				}
				return result;
			}

			// Token: 0x060068B1 RID: 26801 RVA: 0x0037F1A0 File Offset: 0x0037D3A0
			public long method_16()
			{
				long num = 0L;
				if ((this.int_2 & 2) != 0)
				{
					if (this.int_8 < 1950 || this.int_8 > 2050)
					{
						num |= 1L;
					}
					if ((this.int_2 & 1) == 0 && (this.int_6 < 1 || this.int_6 > 12))
					{
						num |= 2L;
					}
					if ((this.int_2 & 1) == 0 && (this.int_0 < 1 || this.int_0 > 31))
					{
						num |= 4L;
					}
					if ((this.int_2 & 1) != 0 && (this.int_1 < 1 || this.int_1 > 366))
					{
						num |= 8L;
					}
					if (this.int_3 < 0 || this.int_3 > 24)
					{
						num |= 16L;
					}
					if (this.int_5 < 0 || this.int_5 > 59)
					{
						num |= 32L;
					}
					if (this.int_7 < 0 || this.int_7 > 59)
					{
						num |= 64L;
					}
					if (this.int_3 == 24 && this.int_5 > 0)
					{
						num |= 48L;
					}
					if (this.int_3 == 24 && this.int_7 > 0)
					{
						num |= 80L;
					}
					if (Math.Abs(this.double_39) > 12.0)
					{
						num |= 128L;
					}
					if (this.int_4 < 0 || this.int_4 > 28800)
					{
						num |= 256L;
					}
					if (Math.Abs(this.double_22) > 180.0)
					{
						num |= 1024L;
					}
					if (Math.Abs(this.double_21) > 90.0)
					{
						num |= 512L;
					}
				}
				if ((this.int_2 & 256) != 0 && Math.Abs(this.double_37) > 100.0)
				{
					num |= 2048L;
				}
				if (((this.int_2 & 256) != 0 && this.double_27 < 0.0) || this.double_27 > 2000.0)
				{
					num |= 4096L;
				}
				if ((this.int_2 & 2048) != 0 && Math.Abs(this.double_38) > 180.0)
				{
					num |= 8192L;
				}
				if ((this.int_2 & 2048) != 0 && Math.Abs(this.double_2) > 360.0)
				{
					num |= 16384L;
				}
				if (((this.int_2 & 16) != 0 && this.double_30 < 1.0) || this.double_30 > 100.0)
				{
					num |= 32768L;
				}
				if (((this.int_2 & 16) != 0 && this.double_31 < 1.0) || this.double_31 > 100.0)
				{
					num |= 65536L;
				}
				if ((this.int_2 & 16) != 0 && Math.Abs(this.double_32) > 1.0)
				{
					num |= 131072L;
				}
				return num;
			}

			// Token: 0x04003AA9 RID: 15017
			public int int_0;

			// Token: 0x04003AAA RID: 15018
			public int int_1;

			// Token: 0x04003AAB RID: 15019
			public int int_2 = 0;

			// Token: 0x04003AAC RID: 15020
			public int int_3 = 0;

			// Token: 0x04003AAD RID: 15021
			public int int_4;

			// Token: 0x04003AAE RID: 15022
			public int int_5;

			// Token: 0x04003AAF RID: 15023
			public int int_6;

			// Token: 0x04003AB0 RID: 15024
			public int int_7;

			// Token: 0x04003AB1 RID: 15025
			public int int_8;

			// Token: 0x04003AB2 RID: 15026
			public double double_0;

			// Token: 0x04003AB3 RID: 15027
			public double double_1;

			// Token: 0x04003AB4 RID: 15028
			public double double_2 = 0.0;

			// Token: 0x04003AB5 RID: 15029
			public double double_3 = 0.0;

			// Token: 0x04003AB6 RID: 15030
			public double double_4 = 0.0;

			// Token: 0x04003AB7 RID: 15031
			public double double_5 = 0.0;

			// Token: 0x04003AB8 RID: 15032
			public double double_6 = 0.0;

			// Token: 0x04003AB9 RID: 15033
			public double double_7 = 0.0;

			// Token: 0x04003ABA RID: 15034
			public double double_8;

			// Token: 0x04003ABB RID: 15035
			public double double_9;

			// Token: 0x04003ABC RID: 15036
			public double double_10;

			// Token: 0x04003ABD RID: 15037
			public double double_11;

			// Token: 0x04003ABE RID: 15038
			public double double_12;

			// Token: 0x04003ABF RID: 15039
			public double double_13;

			// Token: 0x04003AC0 RID: 15040
			public double double_14;

			// Token: 0x04003AC1 RID: 15041
			public double double_15;

			// Token: 0x04003AC2 RID: 15042
			public double double_16;

			// Token: 0x04003AC3 RID: 15043
			public double double_17;

			// Token: 0x04003AC4 RID: 15044
			public double double_18;

			// Token: 0x04003AC5 RID: 15045
			public double double_19;

			// Token: 0x04003AC6 RID: 15046
			public double double_20;

			// Token: 0x04003AC7 RID: 15047
			public double double_21;

			// Token: 0x04003AC8 RID: 15048
			public double double_22;

			// Token: 0x04003AC9 RID: 15049
			public double double_23;

			// Token: 0x04003ACA RID: 15050
			public double double_24;

			// Token: 0x04003ACB RID: 15051
			public double double_25;

			// Token: 0x04003ACC RID: 15052
			public double double_26;

			// Token: 0x04003ACD RID: 15053
			public double double_27;

			// Token: 0x04003ACE RID: 15054
			public double double_28;

			// Token: 0x04003ACF RID: 15055
			public double double_29;

			// Token: 0x04003AD0 RID: 15056
			public double double_30;

			// Token: 0x04003AD1 RID: 15057
			public double double_31;

			// Token: 0x04003AD2 RID: 15058
			public double double_32;

			// Token: 0x04003AD3 RID: 15059
			public double double_33;

			// Token: 0x04003AD4 RID: 15060
			public double double_34;

			// Token: 0x04003AD5 RID: 15061
			public double double_35;

			// Token: 0x04003AD6 RID: 15062
			public double double_36;

			// Token: 0x04003AD7 RID: 15063
			public double double_37;

			// Token: 0x04003AD8 RID: 15064
			public double double_38;

			// Token: 0x04003AD9 RID: 15065
			public double double_39;

			// Token: 0x04003ADA RID: 15066
			public double double_40;

			// Token: 0x04003ADB RID: 15067
			public double double_41;

			// Token: 0x04003ADC RID: 15068
			public double double_42;

			// Token: 0x04003ADD RID: 15069
			public double double_43;

			// Token: 0x04003ADE RID: 15070
			public double double_44;

			// Token: 0x04003ADF RID: 15071
			public double double_45;
		}

		// Token: 0x02000C3D RID: 3133
		public struct Struct25
		{
			// Token: 0x04003AE0 RID: 15072
			public double double_0;

			// Token: 0x04003AE1 RID: 15073
			public double double_1;

			// Token: 0x04003AE2 RID: 15074
			public double double_2;

			// Token: 0x04003AE3 RID: 15075
			public double double_3;

			// Token: 0x04003AE4 RID: 15076
			public double double_4;
		}
	}
}

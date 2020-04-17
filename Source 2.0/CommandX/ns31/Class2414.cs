using System;
using System.Runtime.CompilerServices;
using Zeptomoby.OrbitTools;

namespace ns31
{
	// Token: 0x02000444 RID: 1092
	public abstract class Class2414
	{
		// Token: 0x06001BE1 RID: 7137 RVA: 0x000B2A28 File Offset: 0x000B0C28
		[CompilerGenerated]
		protected Class2417 method_0()
		{
			return this.class2417_0;
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x000117CD File Offset: 0x0000F9CD
		[CompilerGenerated]
		private void method_1(Class2417 class2417_1)
		{
			this.class2417_0 = class2417_1;
		}

		// Token: 0x06001BE3 RID: 7139
		public abstract Class2411 vmethod_0(double double_32);

		// Token: 0x06001BE4 RID: 7140 RVA: 0x000B2A40 File Offset: 0x000B0C40
		public Class2414(Class2417 class2417_1)
		{
			this.method_1(class2417_1);
			this.method_2();
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x000B2ABC File Offset: 0x000B0CBC
		private void method_2()
		{
			this.double_0 = this.method_0().method_11();
			this.double_1 = this.method_0().method_12();
			this.double_2 = Math.Cos(this.double_0);
			this.double_3 = this.double_2 * this.double_2;
			this.double_4 = 3.0 * this.double_3 - 1.0;
			this.double_5 = this.double_1 * this.double_1;
			this.double_6 = 1.0 - this.double_5;
			this.double_7 = Math.Sqrt(this.double_6);
			this.double_8 = this.method_0().method_7();
			this.double_9 = this.method_0().method_8();
			this.double_12 = 6378.135 * (this.double_8 * (1.0 - this.double_1) - 1.0);
			this.double_10 = 1.0122292801892716;
			this.double_11 = Class2412.double_1;
			if (this.double_12 < 156.0)
			{
				this.double_10 = this.double_12 - 78.0;
				if (this.double_12 <= 98.0)
				{
					this.double_10 = 20.0;
				}
				this.double_11 = Math.Pow((120.0 - this.double_10) * 1.0 / 6378.135, 4.0);
				this.double_10 = this.double_10 / 6378.135 + 1.0;
			}
			double num = 1.0 / (this.double_8 * this.double_8 * this.double_6 * this.double_6);
			this.double_13 = 1.0 / (this.double_8 - this.double_10);
			this.double_14 = this.double_8 * this.double_1 * this.double_13;
			this.double_15 = this.double_14 * this.double_14;
			this.double_16 = this.double_1 * this.double_14;
			double num2 = Math.Abs(1.0 - this.double_15);
			this.double_17 = this.double_11 * Math.Pow(this.double_13, 4.0);
			this.double_18 = this.double_17 / Math.Pow(num2, 3.5);
			double num3 = this.double_18 * this.double_9 * (this.double_8 * (1.0 + 1.5 * this.double_15 + this.double_16 * (4.0 + this.double_15)) + 0.000405980925 * this.double_13 / num2 * this.double_4 * (8.0 + 3.0 * this.double_15 * (8.0 + this.double_15)));
			this.double_19 = this.method_0().method_15() * num3;
			this.double_22 = Math.Sin(this.double_0);
			double num4 = 0.0046901403064688327 * Math.Pow(1.0, 3.0);
			this.double_20 = this.double_17 * this.double_13 * num4 * this.double_9 * 1.0 * this.double_22 / this.double_1;
			this.double_23 = 1.0 - this.double_3;
			this.double_21 = 2.0 * this.double_9 * this.double_18 * this.double_8 * this.double_6 * (this.double_14 * (2.0 + 0.5 * this.double_15) + this.double_1 * (0.5 + 2.0 * this.double_15) - 0.0010826158 * this.double_13 / (this.double_8 * num2) * (-3.0 * this.double_4 * (1.0 - 2.0 * this.double_16 + this.double_15 * (1.5 - 0.5 * this.double_16)) + 0.75 * this.double_23 * (2.0 * this.double_15 - this.double_16 * (1.0 + this.double_15)) * Math.Cos(2.0 * this.method_0().method_14())));
			double num5 = this.double_3 * this.double_3;
			double num6 = 0.0016239237 * num * this.double_9;
			double num7 = num6 * 0.0005413079 * num;
			double num8 = 7.7623593749999984E-07 * num * num * this.double_9;
			this.double_24 = this.double_9 + 0.5 * num6 * this.double_7 * this.double_4 + 0.0625 * num7 * this.double_7 * (13.0 - 78.0 * this.double_3 + 137.0 * num5);
			double num9 = 1.0 - 5.0 * this.double_3;
			this.double_25 = -0.5 * num6 * num9 + 0.0625 * num7 * (7.0 - 114.0 * this.double_3 + 395.0 * num5) + num8 * (3.0 - 36.0 * this.double_3 + 49.0 * num5);
			double num10 = -num6 * this.double_2;
			this.double_26 = num10 + (0.5 * num7 * (4.0 - 19.0 * this.double_3) + 2.0 * num8 * (3.0 - 7.0 * this.double_3)) * this.double_2;
			this.double_27 = 3.5 * this.double_6 * num10 * this.double_19;
			this.double_28 = 1.5 * this.double_19;
			this.double_29 = 0.125 * num4 * this.double_22 * (3.0 + 5.0 * this.double_2) / (1.0 + this.double_2);
			this.double_30 = 0.25 * num4 * this.double_22;
			this.double_31 = 7.0 * this.double_3 - 1.0;
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000B31FC File Offset: 0x000B13FC
		protected Class2411 method_3(double double_32, double double_33, double double_34, double double_35, double double_36, double double_37, double double_38, double double_39)
		{
			if (double_34 * double_34 > 1.0)
			{
				throw new PropagationException("Error in satellite data");
			}
			double num = Math.Sqrt(1.0 - double_34 * double_34);
			double num2 = double_34 * Math.Cos(double_33);
			double num3 = 1.0 / (double_35 * num * num);
			double num4 = num3 * this.double_29 * num2;
			double num5 = num3 * this.double_30;
			double num6 = double_36 + num4;
			double num7 = double_34 * Math.Sin(double_33) + num5;
			double num8 = Class2412.smethod_1(num6 - double_37);
			double num9 = num8;
			double num10 = 0.0;
			double num11 = 0.0;
			double num12 = 0.0;
			double num13 = 0.0;
			double num14 = 0.0;
			double num15 = 0.0;
			bool flag = false;
			int num16 = 1;
			while (num16 <= 10 && !flag)
			{
				num14 = Math.Sin(num9);
				num15 = Math.Cos(num9);
				num10 = num2 * num14;
				num11 = num7 * num15;
				num12 = num2 * num15;
				num13 = num7 * num14;
				double num17 = (num8 - num11 + num10 - num9) / (1.0 - num12 - num13) + num9;
				if (Math.Abs(num17 - num9) <= 1E-06)
				{
					flag = true;
				}
				else
				{
					num9 = num17;
				}
				num16++;
			}
			double num18 = num12 + num13;
			double num19 = num10 - num11;
			double num20 = num2 * num2 + num7 * num7;
			num3 = 1.0 - num20;
			double num21 = double_35 * num3;
			double num22 = double_35 * (1.0 - num18);
			double num23 = 1.0 / num22;
			double num24 = Class2412.double_0 * Math.Sqrt(double_35) * num19 * num23;
			double num25 = Class2412.double_0 * Math.Sqrt(num21) * num23;
			num9 = double_35 * num23;
			double num26 = Math.Sqrt(num3);
			num10 = 1.0 / (1.0 + num26);
			double num27 = num9 * (num15 - num2 + num7 * num19 * num10);
			double num28 = num9 * (num14 - num7 - num2 * num19 * num10);
			double num29 = Class2412.smethod_2(num28, num27);
			double num30 = 2.0 * num28 * num27;
			double num31 = 2.0 * num27 * num27 - 1.0;
			num3 = 1.0 / num21;
			num23 = 0.0005413079 * num3;
			num9 = num23 * num3;
			double num32 = num22 * (1.0 - 1.5 * num9 * num26 * this.double_4) + 0.5 * num23 * this.double_23 * num31;
			double num33 = num29 - 0.25 * num9 * this.double_31 * num30;
			double num34 = double_37 + 1.5 * num9 * this.double_2 * num30;
			double num35 = double_32 + 1.5 * num9 * this.double_2 * this.double_22 * num31;
			double num36 = num24 - double_38 * num23 * this.double_23 * num30;
			double num37 = num25 + double_38 * num23 * (this.double_23 * num31 + 1.5 * this.double_4);
			double num38 = Math.Sin(num33);
			double num39 = Math.Cos(num33);
			double num40 = Math.Sin(num35);
			double num41 = Math.Cos(num35);
			double num42 = Math.Sin(num34);
			double num43 = Math.Cos(num34);
			double num44 = -num42 * num41;
			double num45 = num43 * num41;
			double num46 = num44 * num38 + num43 * num39;
			double num47 = num45 * num38 + num42 * num39;
			double num48 = num40 * num38;
			double num49 = num44 * num39 - num43 * num38;
			double num50 = num45 * num39 - num42 * num38;
			double num51 = num40 * num39;
			double num52 = num32 * num46;
			double num53 = num32 * num47;
			double num54 = num32 * num48;
			Class2420 @class = new Class2420(num52, num53, num54);
			DateTime dateTime_ = this.method_0().method_4().AddMinutes(double_39);
			if (@class.method_9() * 6378.135 < 6378.135)
			{
				throw new DecayException(dateTime_, this.method_0().method_20());
			}
			double num55 = num36 * num46 + num37 * num49;
			double num56 = num36 * num47 + num37 * num50;
			double num57 = num36 * num48 + num37 * num51;
			Class2420 class2420_ = new Class2420(num55, num56, num57);
			return new Class2411(@class, class2420_, new Class2413(dateTime_));
		}

		// Token: 0x04000C00 RID: 3072
		protected double double_0;

		// Token: 0x04000C01 RID: 3073
		protected double double_1;

		// Token: 0x04000C02 RID: 3074
		protected double double_2 = 0.0;

		// Token: 0x04000C03 RID: 3075
		protected double double_3 = 0.0;

		// Token: 0x04000C04 RID: 3076
		protected double double_4 = 0.0;

		// Token: 0x04000C05 RID: 3077
		protected double double_5 = 0.0;

		// Token: 0x04000C06 RID: 3078
		protected double double_6 = 0.0;

		// Token: 0x04000C07 RID: 3079
		protected double double_7 = 0.0;

		// Token: 0x04000C08 RID: 3080
		protected double double_8;

		// Token: 0x04000C09 RID: 3081
		protected double double_9;

		// Token: 0x04000C0A RID: 3082
		protected double double_10;

		// Token: 0x04000C0B RID: 3083
		protected double double_11;

		// Token: 0x04000C0C RID: 3084
		protected double double_12;

		// Token: 0x04000C0D RID: 3085
		protected double double_13;

		// Token: 0x04000C0E RID: 3086
		protected double double_14;

		// Token: 0x04000C0F RID: 3087
		protected double double_15;

		// Token: 0x04000C10 RID: 3088
		protected double double_16;

		// Token: 0x04000C11 RID: 3089
		protected double double_17;

		// Token: 0x04000C12 RID: 3090
		protected double double_18;

		// Token: 0x04000C13 RID: 3091
		protected double double_19;

		// Token: 0x04000C14 RID: 3092
		protected double double_20;

		// Token: 0x04000C15 RID: 3093
		protected double double_21;

		// Token: 0x04000C16 RID: 3094
		protected double double_22;

		// Token: 0x04000C17 RID: 3095
		protected double double_23;

		// Token: 0x04000C18 RID: 3096
		protected double double_24;

		// Token: 0x04000C19 RID: 3097
		protected double double_25;

		// Token: 0x04000C1A RID: 3098
		protected double double_26;

		// Token: 0x04000C1B RID: 3099
		protected double double_27;

		// Token: 0x04000C1C RID: 3100
		protected double double_28;

		// Token: 0x04000C1D RID: 3101
		protected double double_29;

		// Token: 0x04000C1E RID: 3102
		protected double double_30;

		// Token: 0x04000C1F RID: 3103
		protected double double_31;

		// Token: 0x04000C20 RID: 3104
		[CompilerGenerated]
		private Class2417 class2417_0;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace ns31
{
	// Token: 0x02000470 RID: 1136
	public sealed class Class2417
	{
		// Token: 0x06001D66 RID: 7526 RVA: 0x000BDDC4 File Offset: 0x000BBFC4
		[CompilerGenerated]
		private Class2419 method_0()
		{
			return this.class2419_0;
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00012127 File Offset: 0x00010327
		[CompilerGenerated]
		private void method_1(Class2419 class2419_1)
		{
			this.class2419_0 = class2419_1;
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x000BDDDC File Offset: 0x000BBFDC
		[CompilerGenerated]
		public Class2413 method_2()
		{
			return this.class2413_0;
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00012130 File Offset: 0x00010330
		[CompilerGenerated]
		private void method_3(Class2413 class2413_1)
		{
			this.class2413_0 = class2413_1;
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x000BDDF4 File Offset: 0x000BBFF4
		public DateTime method_4()
		{
			return this.method_2().method_4();
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x000BDE10 File Offset: 0x000BC010
		[CompilerGenerated]
		private Class2414 method_5()
		{
			return this.class2414_0;
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00012139 File Offset: 0x00010339
		[CompilerGenerated]
		private void method_6(Class2414 class2414_1)
		{
			this.class2414_0 = class2414_1;
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x000BDE28 File Offset: 0x000BC028
		public double method_7()
		{
			return this.double_8;
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x000BDE40 File Offset: 0x000BC040
		public double method_8()
		{
			return this.double_10;
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x000BDE58 File Offset: 0x000BC058
		public double method_9()
		{
			return this.double_11;
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x000BDE70 File Offset: 0x000BC070
		public double method_10()
		{
			return this.double_12;
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x000BDE88 File Offset: 0x000BC088
		public double method_11()
		{
			return this.double_0;
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x000BDEA0 File Offset: 0x000BC0A0
		public double method_12()
		{
			return this.double_1;
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x000BDEB8 File Offset: 0x000BC0B8
		public double method_13()
		{
			return this.double_2;
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x000BDED0 File Offset: 0x000BC0D0
		public double method_14()
		{
			return this.double_3;
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x000BDEE8 File Offset: 0x000BC0E8
		public double method_15()
		{
			return this.double_4;
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x000BDF00 File Offset: 0x000BC100
		public double method_16()
		{
			return this.double_6;
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x000BDF18 File Offset: 0x000BC118
		private double method_17()
		{
			return this.double_7;
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x000BDF30 File Offset: 0x000BC130
		public string method_18()
		{
			return this.method_0().method_1();
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x000BDF4C File Offset: 0x000BC14C
		public string method_19()
		{
			return this.method_0().method_0();
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x000BDF68 File Offset: 0x000BC168
		public string method_20()
		{
			return this.method_19() + " #" + this.method_18();
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x000BDF90 File Offset: 0x000BC190
		public TimeSpan method_21()
		{
			if (this.timeSpan_0.TotalSeconds < 0.0)
			{
				if (this.method_8() == 0.0)
				{
					this.timeSpan_0 = new TimeSpan(0, 0, 0);
				}
				else
				{
					double num = 6.2831853071795862 / this.method_8() * 60.0;
					int milliseconds = (int)((num - (double)((int)num)) * 1000.0);
					this.timeSpan_0 = new TimeSpan(0, 0, 0, (int)num, milliseconds);
				}
			}
			return this.timeSpan_0;
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x000BE024 File Offset: 0x000BC224
		public Class2417(Class2419 class2419_1)
		{
			this.method_1(class2419_1);
			this.method_3(this.method_0().method_2());
			this.double_0 = this.method_25(Class2419.Enum174.const_6);
			this.double_1 = this.method_0().method_4(Class2419.Enum174.const_8);
			this.double_2 = this.method_25(Class2419.Enum174.const_7);
			this.double_3 = this.method_25(Class2419.Enum174.const_9);
			this.double_4 = this.method_0().method_4(Class2419.Enum174.const_14);
			this.double_5 = this.method_0().method_4(Class2419.Enum174.const_12);
			this.double_6 = this.method_25(Class2419.Enum174.const_10);
			this.double_7 = this.method_0().method_4(Class2419.Enum174.const_11);
			double num = this.method_17() * 6.2831853071795862 / 1440.0;
			double num2 = Math.Pow(Class2412.double_0 / num, 0.66666666666666663);
			double num3 = this.method_12();
			double d = this.method_11();
			double num4 = 0.00081196185 * (3.0 * Class2412.smethod_0(Math.Cos(d)) - 1.0) / Math.Pow(1.0 - num3 * num3, 1.5);
			double num5 = num4 / (num2 * num2);
			double num6 = num2 * (1.0 - num5 * (0.33333333333333331 + num5 * (1.0 + 1.654320987654321 * num5)));
			double num7 = num4 / (num6 * num6);
			this.double_10 = num / (1.0 + num7);
			this.double_8 = num6 / (1.0 - num7);
			this.double_9 = this.double_8 * Math.Sqrt(1.0 - num3 * num3);
			this.double_11 = 6378.135 * (this.double_8 * (1.0 - num3) - 1.0);
			this.double_12 = 6378.135 * (this.double_8 * (1.0 + num3) - 1.0);
			if (this.method_21().TotalMinutes >= 225.0)
			{
				this.method_6(new Class2415(this));
			}
			else
			{
				this.method_6(new Class2416(this));
			}
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x000BE2DC File Offset: 0x000BC4DC
		public Class2411 method_22(double double_13)
		{
			Class2411 @class = this.method_5().vmethod_0(double_13);
			double num = 6378.135;
			@class.method_4(num);
			@class.method_5(106.30225);
			return @class;
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000BE31C File Offset: 0x000BC51C
		public Class2411 method_23(DateTime dateTime_0)
		{
			return this.method_22(this.method_24(dateTime_0).TotalMinutes);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x000BE340 File Offset: 0x000BC540
		public TimeSpan method_24(DateTime dateTime_0)
		{
			return dateTime_0 - this.method_4();
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x000BE35C File Offset: 0x000BC55C
		protected double method_25(Class2419.Enum174 enum174_0)
		{
			return this.method_0().method_5(enum174_0, Class2419.Enum175.const_0);
		}

		// Token: 0x04000D0B RID: 3339
		private TimeSpan timeSpan_0 = new TimeSpan(0, 0, 0, -1);

		// Token: 0x04000D0C RID: 3340
		private double double_0;

		// Token: 0x04000D0D RID: 3341
		private double double_1;

		// Token: 0x04000D0E RID: 3342
		private double double_2 = 0.0;

		// Token: 0x04000D0F RID: 3343
		private double double_3 = 0.0;

		// Token: 0x04000D10 RID: 3344
		private double double_4 = 0.0;

		// Token: 0x04000D11 RID: 3345
		private double double_5 = 0.0;

		// Token: 0x04000D12 RID: 3346
		private double double_6 = 0.0;

		// Token: 0x04000D13 RID: 3347
		private double double_7 = 0.0;

		// Token: 0x04000D14 RID: 3348
		private double double_8;

		// Token: 0x04000D15 RID: 3349
		private double double_9;

		// Token: 0x04000D16 RID: 3350
		private double double_10;

		// Token: 0x04000D17 RID: 3351
		private double double_11;

		// Token: 0x04000D18 RID: 3352
		private double double_12;

		// Token: 0x04000D19 RID: 3353
		[CompilerGenerated]
		private Class2419 class2419_0;

		// Token: 0x04000D1A RID: 3354
		[CompilerGenerated]
		private Class2413 class2413_0;

		// Token: 0x04000D1B RID: 3355
		[CompilerGenerated]
		private Class2414 class2414_0;
	}
}

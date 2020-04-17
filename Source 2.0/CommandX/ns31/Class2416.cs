using System;

namespace ns31
{
	// Token: 0x0200046C RID: 1132
	public sealed class Class2416 : Class2414
	{
		// Token: 0x06001D56 RID: 7510 RVA: 0x000BCFAC File Offset: 0x000BB1AC
		public Class2416(Class2417 class2417_1) : base(class2417_1)
		{
			this.double_32 = 2.0 * this.double_18 * this.double_8 * this.double_6 * (1.0 + 2.75 * (this.double_15 + this.double_16) + this.double_16 * this.double_15);
			this.double_33 = base.method_0().method_15() * this.double_20 * Math.Cos(base.method_0().method_14());
			this.double_34 = -0.66666666666666663 * this.double_17 * base.method_0().method_15() * 1.0 / this.double_16;
			this.double_35 = Math.Pow(1.0 + this.double_14 * Math.Cos(base.method_0().method_16()), 3.0);
			this.double_36 = Math.Sin(base.method_0().method_16());
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x000BD0BC File Offset: 0x000BB2BC
		public override Class2411 vmethod_0(double double_37)
		{
			bool flag = false;
			if (this.double_8 * (1.0 - this.double_1) / 1.0 < 1.0344928415594841)
			{
				flag = true;
			}
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			double num5 = 0.0;
			double num6 = 0.0;
			if (!flag)
			{
				double num7 = this.double_19 * this.double_19;
				num = 4.0 * this.double_8 * this.double_13 * num7;
				double num8 = num * this.double_13 * this.double_19 / 3.0;
				num2 = (17.0 * this.double_8 + this.double_10) * num8;
				num3 = 0.5 * num8 * this.double_8 * this.double_13 * (221.0 * this.double_8 + 31.0 * this.double_10) * this.double_19;
				num4 = num + 2.0 * num7;
				num5 = 0.25 * (3.0 * num2 + this.double_19 * (12.0 * num + 10.0 * num7));
				num6 = 0.2 * (3.0 * num3 + 12.0 * this.double_19 * num2 + 6.0 * num * num + 15.0 * num7 * (2.0 * num + num7));
			}
			double num9 = base.method_0().method_16() + this.double_24 * double_37;
			double num10 = base.method_0().method_14() + this.double_25 * double_37;
			double num11 = base.method_0().method_13() + this.double_26 * double_37;
			double num12 = num10;
			double num13 = num9;
			double num14 = double_37 * double_37;
			double num15 = num11 + this.double_27 * num14;
			double num16 = 1.0 - this.double_19 * double_37;
			double num17 = base.method_0().method_15() * this.double_21 * double_37;
			double num18 = this.double_28 * num14;
			if (!flag)
			{
				double num19 = this.double_33 * double_37;
				double num20 = this.double_34 * (Math.Pow(1.0 + this.double_14 * Math.Cos(num9), 3.0) - this.double_35);
				double num21 = num19 + num20;
				num13 = num9 + num21;
				num12 = num10 - num21;
				double num22 = num14 * double_37;
				double num23 = double_37 * num22;
				num16 = num16 - num * num14 - num2 * num22 - num3 * num23;
				num17 += base.method_0().method_15() * this.double_32 * (Math.Sin(num13) - this.double_36);
				num18 = num18 + num4 * num22 + num23 * (num5 + double_37 * num6);
			}
			double x = this.double_8 * Class2412.smethod_0(num16);
			double num24 = this.double_1 - num17;
			double num25 = num13 + num12 + num15 + this.double_9 * num18;
			double double_38 = Class2412.double_0 / Math.Pow(x, 1.5);
			return base.method_3(this.double_0, num10, num24, x, num25, num15, double_38, double_37);
		}

		// Token: 0x04000D03 RID: 3331
		private readonly double double_32;

		// Token: 0x04000D04 RID: 3332
		private readonly double double_33;

		// Token: 0x04000D05 RID: 3333
		private readonly double double_34;

		// Token: 0x04000D06 RID: 3334
		private readonly double double_35;

		// Token: 0x04000D07 RID: 3335
		private readonly double double_36;
	}
}

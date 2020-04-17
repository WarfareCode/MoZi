using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using ns31;

namespace ns30
{
	// Token: 0x02000414 RID: 1044
	public sealed class Class2409
	{
		// Token: 0x06001A65 RID: 6757 RVA: 0x0009FDC4 File Offset: 0x0009DFC4
		[CompilerGenerated]
		public double method_0()
		{
			return this.double_0;
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00010FC1 File Offset: 0x0000F1C1
		[CompilerGenerated]
		public void method_1(double double_3)
		{
			this.double_0 = double_3;
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x0009FDDC File Offset: 0x0009DFDC
		[CompilerGenerated]
		public double method_2()
		{
			return this.double_1;
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00010FCA File Offset: 0x0000F1CA
		[CompilerGenerated]
		public void method_3(double double_3)
		{
			this.double_1 = double_3;
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x0009FDF4 File Offset: 0x0009DFF4
		public double method_4()
		{
			return Class2412.smethod_3(this.method_0());
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0009FE10 File Offset: 0x0009E010
		public double method_5()
		{
			return Class2412.smethod_3(this.method_2());
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0009FE2C File Offset: 0x0009E02C
		[CompilerGenerated]
		public double method_6()
		{
			return this.double_2;
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00010FD3 File Offset: 0x0000F1D3
		[CompilerGenerated]
		public void method_7(double double_3)
		{
			this.double_2 = double_3;
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00010FDC File Offset: 0x0000F1DC
		public Class2409(Class2410 class2410_0, Class2413 class2413_0) : this(class2410_0.method_0(), (Class2412.smethod_2(class2410_0.method_0().method_2(), class2410_0.method_0().method_0()) - class2413_0.method_3()) % 6.2831853071795862)
		{
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0009FE44 File Offset: 0x0009E044
		private Class2409(Class2420 class2420_0, double double_3)
		{
			double_3 %= 6.2831853071795862;
			if (double_3 < 0.0)
			{
				double_3 += 6.2831853071795862;
			}
			double num = Math.Sqrt(Class2412.smethod_0(class2420_0.method_0()) + Class2412.smethod_0(class2420_0.method_2()));
			double num2 = 0.0066943177782667227;
			double num3 = Class2412.smethod_2(class2420_0.method_4(), num);
			double num4;
			double num5;
			do
			{
				num4 = num3;
				num5 = 1.0 / Math.Sqrt(1.0 - num2 * Class2412.smethod_0(Math.Sin(num4)));
				num3 = Class2412.smethod_2(class2420_0.method_4() + 6378.135 * num5 * num2 * Math.Sin(num4), num);
			}
			while (Math.Abs(num3 - num4) > 1E-07);
			this.method_1(num3);
			this.method_3(double_3);
			this.method_7(num / Math.Cos(num3) - 6378.135 * num5);
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0009FF68 File Offset: 0x0009E168
		public override string ToString()
		{
			bool flag = this.method_0() >= 0.0;
			bool flag2 = this.method_2() >= 0.0;
			return string.Format(CultureInfo.CurrentCulture, "{0:00.0}{1} ", new object[]
			{
				Math.Abs(this.method_4()),
				flag ? 'N' : 'S'
			}) + string.Format(CultureInfo.CurrentCulture, "{0:000.0}{1} ", new object[]
			{
				Math.Abs(this.method_5()),
				flag2 ? 'E' : 'W'
			}) + string.Format(CultureInfo.CurrentCulture, "{0:F0}m", new object[]
			{
				this.method_6() * 1000.0
			});
		}

		// Token: 0x04000B27 RID: 2855
		[CompilerGenerated]
		private double double_0;

		// Token: 0x04000B28 RID: 2856
		[CompilerGenerated]
		private double double_1;

		// Token: 0x04000B29 RID: 2857
		[CompilerGenerated]
		private double double_2 = 0.0;
	}
}

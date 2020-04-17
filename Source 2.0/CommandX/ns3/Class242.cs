using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3
{
	// Token: 0x02000C3E RID: 3134
	public sealed class Class242
	{
		// Token: 0x02000C3F RID: 3135
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct Struct26
		{
			// Token: 0x04003AE5 RID: 15077
			public double[] double_0;
		}

		// Token: 0x02000C40 RID: 3136
		public sealed class Class243
		{
			// Token: 0x060068B3 RID: 26803 RVA: 0x0037F59C File Offset: 0x0037D79C
			public Class243()
			{
				this.char_0 = new char[3];
			}

			// Token: 0x060068B4 RID: 26804 RVA: 0x0037F618 File Offset: 0x0037D818
			public void method_0(double double_12, double double_13)
			{
				double num = (double_12 + 6378.135) * 1000.0;
				double num2 = (double_13 + 6378.135) * 1000.0;
				this.method_5((num - num2) / (num + num2));
				this.double_3 = (num + num2) / 2.0;
				this.double_2 = 376.99111843077543 / (6.28318530717959 * Math.Sqrt(this.double_3 * this.double_3 * this.double_3 / 398600441800000.0));
			}

			// Token: 0x060068B5 RID: 26805 RVA: 0x0037F6B0 File Offset: 0x0037D8B0
			public double method_1()
			{
				return this.double_3 / 1000.0 * (1.0 + this.method_4()) - 6378.135;
			}

			// Token: 0x060068B6 RID: 26806 RVA: 0x0037F6EC File Offset: 0x0037D8EC
			public double method_2()
			{
				return this.double_3 / 1000.0 * (1.0 - this.method_4()) - 6378.135;
			}

			// Token: 0x060068B7 RID: 26807 RVA: 0x0002D01A File Offset: 0x0002B21A
			public void method_3(double double_12)
			{
				if (double_12 == 0.0)
				{
					this.double_5 = 1.74532925199433E-12;
				}
				else
				{
					this.double_5 = double_12 * 0.0174532925199433;
				}
			}

			// Token: 0x060068B8 RID: 26808 RVA: 0x0037F728 File Offset: 0x0037D928
			public double method_4()
			{
				return this.double_6;
			}

			// Token: 0x060068B9 RID: 26809 RVA: 0x0037F740 File Offset: 0x0037D940
			public void method_5(double double_12)
			{
				try
				{
					if (double_12 < 0.0 || double_12 >= 1.0)
					{
						throw new Exception("Incorrect eccentricity value");
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200264", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
				if (double_12 == 0.0)
				{
					this.double_6 = 1E-06;
				}
				else
				{
					this.double_6 = double_12;
				}
			}

			// Token: 0x060068BA RID: 26810 RVA: 0x0002D04F File Offset: 0x0002B24F
			public void method_6(double double_12)
			{
				this.double_8 = double_12 * 0.0174532925199433;
			}

			// Token: 0x060068BB RID: 26811 RVA: 0x0002D062 File Offset: 0x0002B262
			public void method_7(double double_12)
			{
				this.double_9 = double_12 * 0.0174532925199433;
			}

			// Token: 0x060068BC RID: 26812 RVA: 0x0037F7E8 File Offset: 0x0037D9E8
			public void method_8()
			{
				double num = Math.Pow(Math.Sqrt(1434962880.0 / Class244.smethod_0(6378.135)) / this.double_2, 0.66666666666666663);
				double num2 = 0.00081196185 * (3.0 * Class244.smethod_1(Math.Cos(this.double_5)) - 1.0) / Math.Pow(1.0 - Class244.smethod_1(this.double_6), 1.5);
				double num3 = num2 / Class244.smethod_1(num);
				double num4 = num * (1.0 - num3 * (0.33333333333333331 + num3 * (1.0 + 1.654320987654321 * num3)));
				double num5 = num2 / Class244.smethod_1(num4);
				double num6 = this.double_2 / (1.0 + num5);
				if (6.28318530717958 / num6 >= 225.0)
				{
					this.int_0 = 1;
				}
				else
				{
					this.int_0 = 0;
				}
			}

			// Token: 0x04003AE6 RID: 15078
			public double double_0;

			// Token: 0x04003AE7 RID: 15079
			public double double_1;

			// Token: 0x04003AE8 RID: 15080
			public double double_2 = 0.0;

			// Token: 0x04003AE9 RID: 15081
			protected double double_3 = 0.0;

			// Token: 0x04003AEA RID: 15082
			public double double_4 = 0.0;

			// Token: 0x04003AEB RID: 15083
			public double double_5 = 0.0;

			// Token: 0x04003AEC RID: 15084
			public double double_6 = 0.0;

			// Token: 0x04003AED RID: 15085
			public double double_7 = 0.0;

			// Token: 0x04003AEE RID: 15086
			public double double_8;

			// Token: 0x04003AEF RID: 15087
			public double double_9;

			// Token: 0x04003AF0 RID: 15088
			public double double_10;

			// Token: 0x04003AF1 RID: 15089
			public double double_11;

			// Token: 0x04003AF2 RID: 15090
			public string string_0;

			// Token: 0x04003AF3 RID: 15091
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public char[] char_0;

			// Token: 0x04003AF4 RID: 15092
			public int int_0;
		}

		// Token: 0x02000C41 RID: 3137
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct Struct27
		{
			// Token: 0x04003AF5 RID: 15093
			public double double_0;

			// Token: 0x04003AF6 RID: 15094
			public double double_1;

			// Token: 0x04003AF7 RID: 15095
			public double double_2;

			// Token: 0x04003AF8 RID: 15096
			public double double_3;

			// Token: 0x04003AF9 RID: 15097
			public double double_4;

			// Token: 0x04003AFA RID: 15098
			public double double_5;

			// Token: 0x04003AFB RID: 15099
			public double double_6;

			// Token: 0x04003AFC RID: 15100
			public double double_7;

			// Token: 0x04003AFD RID: 15101
			public double double_8;

			// Token: 0x04003AFE RID: 15102
			public double double_9;

			// Token: 0x04003AFF RID: 15103
			public double double_10;

			// Token: 0x04003B00 RID: 15104
			public double double_11;

			// Token: 0x04003B01 RID: 15105
			public double double_12;
		}

		// Token: 0x02000C42 RID: 3138
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct Struct28
		{
			// Token: 0x04003B02 RID: 15106
			public double double_0;

			// Token: 0x04003B03 RID: 15107
			public double double_1;

			// Token: 0x04003B04 RID: 15108
			public double double_2;

			// Token: 0x04003B05 RID: 15109
			public double double_3;

			// Token: 0x04003B06 RID: 15110
			public double double_4;

			// Token: 0x04003B07 RID: 15111
			public double double_5;

			// Token: 0x04003B08 RID: 15112
			public double double_6;
		}

		// Token: 0x02000C43 RID: 3139
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct Struct29
		{
			// Token: 0x04003B09 RID: 15113
			public double double_0;

			// Token: 0x04003B0A RID: 15114
			public double double_1;

			// Token: 0x04003B0B RID: 15115
			public double double_2;

			// Token: 0x04003B0C RID: 15116
			public double double_3;

			// Token: 0x04003B0D RID: 15117
			public double double_4;
		}

		// Token: 0x02000C44 RID: 3140
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct Struct30
		{
			// Token: 0x04003B0E RID: 15118
			public double double_0;

			// Token: 0x04003B0F RID: 15119
			public double double_1;

			// Token: 0x04003B10 RID: 15120
			public double double_2;

			// Token: 0x04003B11 RID: 15121
			public double double_3;
		}
	}
}

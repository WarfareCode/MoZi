using System;

namespace ns19
{
	// Token: 0x0200041C RID: 1052
	public abstract class TerrainAccessor : IDisposable
	{
		// Token: 0x06001A9D RID: 6813 RVA: 0x000A05C0 File Offset: 0x0009E7C0
		public double method_0()
		{
			return this.double_0;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x000A05D8 File Offset: 0x0009E7D8
		public double method_1()
		{
			return this.double_1;
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x000A05F0 File Offset: 0x0009E7F0
		public double method_2()
		{
			return this.double_3;
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x000A0608 File Offset: 0x0009E808
		public double method_3()
		{
			return this.double_2;
		}

		// Token: 0x06001AA1 RID: 6817
		public abstract float vmethod_0(double double_4, double double_5, double double_6);

		// Token: 0x06001AA2 RID: 6818 RVA: 0x000A0620 File Offset: 0x0009E820
		public virtual float vmethod_1(double double_4, double double_5)
		{
			return this.vmethod_0(double_4, double_5, 0.0);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x000A0640 File Offset: 0x0009E840
		public virtual Class1972 vmethod_2(double double_4, double double_5, double double_6, double double_7, int int_0)
		{
			Class1972 @class = new Class1972(null);
			@class.double_2 = double_4;
			@class.double_1 = double_5;
			@class.double_3 = double_6;
			@class.double_4 = double_7;
			@class.int_0 = int_0;
			@class.bool_0 = true;
			@class.bool_1 = true;
			double num = Math.Abs(double_4 - double_5);
			double num2 = Math.Abs(double_7 - double_6);
			float[,] array = new float[int_0, int_0];
			float num3 = 1f / (float)(int_0 - 1);
			for (int i = 0; i < int_0; i++)
			{
				for (int j = 0; j < int_0; j++)
				{
					double double_8 = double_4 - (double)num3 * num * (double)i;
					double double_9 = double_6 + (double)num3 * num2 * (double)j;
					array[i, j] = this.vmethod_0(double_8, double_9, 0.0);
				}
			}
			@class.float_0 = array;
			return @class;
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public virtual void Dispose()
		{
		}

		// Token: 0x04000B36 RID: 2870
		protected double double_0;

		// Token: 0x04000B37 RID: 2871
		protected double double_1;

		// Token: 0x04000B38 RID: 2872
		protected double double_2 = 0.0;

		// Token: 0x04000B39 RID: 2873
		protected double double_3 = 0.0;
	}
}

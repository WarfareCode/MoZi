using System;
using ns31;

namespace ns32
{
	// Token: 0x020004B7 RID: 1207
	public sealed class Class2446
	{
		// Token: 0x06001F9A RID: 8090 RVA: 0x000CFD44 File Offset: 0x000CDF44
		static Class2446()
		{
			try
			{
				byte[] array = new byte[288];
				int i = 0;
				while (i < 144)
				{
					array[i++] = 8;
				}
				while (i < 256)
				{
					array[i++] = 9;
				}
				while (i < 280)
				{
					array[i++] = 7;
				}
				while (i < 288)
				{
					array[i++] = 8;
				}
				Class2446.class2446_0 = new Class2446(array);
				array = new byte[32];
				i = 0;
				while (i < 32)
				{
					array[i++] = 5;
				}
				Class2446.class2446_1 = new Class2446(array);
			}
			catch (Exception)
			{
				throw new Exception30("InflaterHuffmanTree: static tree length illegal");
			}
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x00012FF6 File Offset: 0x000111F6
		public Class2446(byte[] byte_0)
		{
			this.method_0(byte_0);
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x000CFE08 File Offset: 0x000CE008
		private void method_0(byte[] byte_0)
		{
			int[] array = new int[Class2446.int_0 + 1];
			int[] array2 = new int[Class2446.int_0 + 1];
			for (int i = 0; i < byte_0.Length; i++)
			{
				int num = (int)byte_0[i];
				if (num > 0)
				{
					int[] array3;
					IntPtr value;
					(array3 = array)[(int)(value = (IntPtr)num)] = array3[(int)value] + 1;
				}
			}
			int num2 = 0;
			int num3 = 512;
			for (int j = 1; j <= Class2446.int_0; j++)
			{
				array2[j] = num2;
				num2 += array[j] << 16 - j;
				if (j >= 10)
				{
					int num4 = array2[j] & 130944;
					int num5 = num2 & 130944;
					num3 += num5 - num4 >> 16 - j;
				}
			}
			this.short_0 = new short[num3];
			int num6 = 512;
			for (int k = Class2446.int_0; k >= 10; k--)
			{
				int num7 = num2 & 130944;
				num2 -= array[k] << 16 - k;
				int num8 = num2 & 130944;
				for (int l = num8; l < num7; l += 128)
				{
					this.short_0[(int)Class2447.smethod_0(l)] = (short)(-num6 << 4 | k);
					num6 += 1 << k - 9;
				}
			}
			for (int m = 0; m < byte_0.Length; m++)
			{
				int num9 = (int)byte_0[m];
				if (num9 != 0)
				{
					num2 = array2[num9];
					int num10 = (int)Class2447.smethod_0(num2);
					if (num9 <= 9)
					{
						do
						{
							this.short_0[num10] = (short)(m << 4 | num9);
							num10 += 1 << num9;
						}
						while (num10 < 512);
					}
					else
					{
						int num11 = (int)this.short_0[num10 & 511];
						int num12 = 1 << (num11 & 15);
						num11 = -(num11 >> 4);
						do
						{
							this.short_0[num11 | num10 >> 9] = (short)(m << 4 | num9);
							num10 += 1 << num9;
						}
						while (num10 < num12);
					}
					array2[num9] = num2 + (1 << 16 - num9);
				}
			}
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x000D0034 File Offset: 0x000CE234
		public int method_1(Class2454 class2454_0)
		{
			int num;
			int result;
			if ((num = class2454_0.method_0(9)) >= 0)
			{
				int num2;
				if ((num2 = (int)this.short_0[num]) >= 0)
				{
					class2454_0.method_1(num2 & 15);
					result = num2 >> 4;
				}
				else
				{
					int num3 = -(num2 >> 4);
					int int_ = num2 & 15;
					if ((num = class2454_0.method_0(int_)) >= 0)
					{
						num2 = (int)this.short_0[num3 | num >> 9];
						class2454_0.method_1(num2 & 15);
						result = num2 >> 4;
					}
					else
					{
						int num4 = class2454_0.method_2();
						num = class2454_0.method_0(num4);
						num2 = (int)this.short_0[num3 | num >> 9];
						if ((num2 & 15) <= num4)
						{
							class2454_0.method_1(num2 & 15);
							result = num2 >> 4;
						}
						else
						{
							result = -1;
						}
					}
				}
			}
			else
			{
				int num5 = class2454_0.method_2();
				num = class2454_0.method_0(num5);
				int num2 = (int)this.short_0[num];
				if (num2 >= 0 && (num2 & 15) <= num5)
				{
					class2454_0.method_1(num2 & 15);
					result = num2 >> 4;
				}
				else
				{
					result = -1;
				}
			}
			return result;
		}

		// Token: 0x04000EDA RID: 3802
		private static int int_0 = 15;

		// Token: 0x04000EDB RID: 3803
		private short[] short_0;

		// Token: 0x04000EDC RID: 3804
		public static Class2446 class2446_0;

		// Token: 0x04000EDD RID: 3805
		public static Class2446 class2446_1;
	}
}

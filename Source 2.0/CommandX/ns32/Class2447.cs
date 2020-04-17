using System;
using ns31;

namespace ns32
{
	// Token: 0x020004CE RID: 1230
	public sealed class Class2447
	{
		// Token: 0x06002011 RID: 8209 RVA: 0x000D18A4 File Offset: 0x000CFAA4
		public static short smethod_0(int int_11)
		{
			return (short)((int)Class2447.byte_0[int_11 & 15] << 12 | (int)Class2447.byte_0[int_11 >> 4 & 15] << 8 | (int)Class2447.byte_0[int_11 >> 8 & 15] << 4 | (int)Class2447.byte_0[int_11 >> 12]);
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x000D18EC File Offset: 0x000CFAEC
		static Class2447()
		{
			int i = 0;
			while (i < 144)
			{
				Class2447.short_1[i] = Class2447.smethod_0(48 + i << 8);
				Class2447.byte_2[i++] = 8;
			}
			while (i < 256)
			{
				Class2447.short_1[i] = Class2447.smethod_0(256 + i << 7);
				Class2447.byte_2[i++] = 9;
			}
			while (i < 280)
			{
				Class2447.short_1[i] = Class2447.smethod_0(-256 + i << 9);
				Class2447.byte_2[i++] = 7;
			}
			while (i < Class2447.int_1)
			{
				Class2447.short_1[i] = Class2447.smethod_0(-88 + i << 8);
				Class2447.byte_2[i++] = 8;
			}
			Class2447.short_2 = new short[Class2447.int_2];
			Class2447.byte_3 = new byte[Class2447.int_2];
			for (i = 0; i < Class2447.int_2; i++)
			{
				Class2447.short_2[i] = Class2447.smethod_0(i << 11);
				Class2447.byte_3[i] = 5;
			}
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x000D1A8C File Offset: 0x000CFC8C
		public Class2447(Class2444 class2444_1)
		{
			this.class2444_0 = class2444_1;
			this.class2448_0 = new Class2447.Class2448(this, Class2447.int_1, 257, 15);
			this.class2448_1 = new Class2447.Class2448(this, Class2447.int_2, 1, 15);
			this.class2448_2 = new Class2447.Class2448(this, Class2447.int_3, 4, 7);
			this.short_0 = new short[Class2447.int_0];
			this.byte_1 = new byte[Class2447.int_0];
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00013557 File Offset: 0x00011757
		public void method_0()
		{
			this.int_9 = 0;
			this.int_10 = 0;
			this.class2448_0.method_0();
			this.class2448_1.method_0();
			this.class2448_2.method_0();
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x000D1B08 File Offset: 0x000CFD08
		private int method_1(int int_11)
		{
			int result;
			if (int_11 == 255)
			{
				result = 285;
			}
			else
			{
				int num = 257;
				while (int_11 >= 8)
				{
					num += 4;
					int_11 >>= 1;
				}
				result = num + int_11;
			}
			return result;
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x000D1B4C File Offset: 0x000CFD4C
		private int method_2(int int_11)
		{
			int num = 0;
			while (int_11 >= 4)
			{
				num += 2;
				int_11 >>= 1;
			}
			return num + int_11;
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x000D1B74 File Offset: 0x000CFD74
		public void method_3(int int_11)
		{
			this.class2448_2.method_3();
			this.class2448_0.method_3();
			this.class2448_1.method_3();
			this.class2444_0.method_4(this.class2448_0.int_1 - 257, 5);
			this.class2444_0.method_4(this.class2448_1.int_1 - 1, 5);
			this.class2444_0.method_4(int_11 - 4, 4);
			for (int i = 0; i < int_11; i++)
			{
				this.class2444_0.method_4((int)this.class2448_2.byte_0[Class2447.int_8[i]], 3);
			}
			this.class2448_0.method_8(this.class2448_2);
			this.class2448_1.method_8(this.class2448_2);
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x000D1C38 File Offset: 0x000CFE38
		public void method_4()
		{
			for (int i = 0; i < this.int_9; i++)
			{
				int num = (int)(this.byte_1[i] & 255);
				int num2 = (int)this.short_0[i];
				if (num2-- != 0)
				{
					int num3 = this.method_1(num);
					this.class2448_0.method_1(num3);
					int num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						this.class2444_0.method_4(num & (1 << num4) - 1, num4);
					}
					int num5 = this.method_2(num2);
					this.class2448_1.method_1(num5);
					num4 = num5 / 2 - 1;
					if (num4 > 0)
					{
						this.class2444_0.method_4(num2 & (1 << num4) - 1, num4);
					}
				}
				else
				{
					this.class2448_0.method_1(num);
				}
			}
			this.class2448_0.method_1(Class2447.int_7);
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x000D1D28 File Offset: 0x000CFF28
		public void method_5(byte[] byte_4, int int_11, int int_12, bool bool_0)
		{
			this.class2444_0.method_4(bool_0 ? 1 : 0, 3);
			this.class2444_0.method_3();
			this.class2444_0.method_1(int_12);
			this.class2444_0.method_1(~int_12);
			this.class2444_0.method_2(byte_4, int_11, int_12);
			this.method_0();
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x000D1D84 File Offset: 0x000CFF84
		public void method_6(byte[] byte_4, int int_11, int int_12, bool bool_0)
		{
			short[] array;
			IntPtr value;
			(array = this.class2448_0.short_0)[(int)(value = (IntPtr)Class2447.int_7)] = (short)(array[(int)value] + 1);
			this.class2448_0.method_5();
			this.class2448_1.method_5();
			this.class2448_0.method_7(this.class2448_2);
			this.class2448_1.method_7(this.class2448_2);
			this.class2448_2.method_5();
			int num = 4;
			for (int i = 18; i > num; i--)
			{
				if (this.class2448_2.byte_0[Class2447.int_8[i]] > 0)
				{
					num = i + 1;
				}
			}
			int num2 = 14 + num * 3 + this.class2448_2.method_6() + this.class2448_0.method_6() + this.class2448_1.method_6() + this.int_10;
			int num3 = this.int_10;
			for (int j = 0; j < Class2447.int_1; j++)
			{
				num3 += (int)(this.class2448_0.short_0[j] * (short)Class2447.byte_2[j]);
			}
			for (int k = 0; k < Class2447.int_2; k++)
			{
				num3 += (int)(this.class2448_1.short_0[k] * (short)Class2447.byte_3[k]);
			}
			if (num2 >= num3)
			{
				num2 = num3;
			}
			if (int_11 >= 0 && int_12 + 4 < num2 >> 3)
			{
				this.method_5(byte_4, int_11, int_12, bool_0);
			}
			else if (num2 == num3)
			{
				this.class2444_0.method_4(2 + (bool_0 ? 1 : 0), 3);
				this.class2448_0.method_2(Class2447.short_1, Class2447.byte_2);
				this.class2448_1.method_2(Class2447.short_2, Class2447.byte_3);
				this.method_4();
				this.method_0();
			}
			else
			{
				this.class2444_0.method_4(4 + (bool_0 ? 1 : 0), 3);
				this.method_3(num);
				this.method_4();
				this.method_0();
			}
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00013588 File Offset: 0x00011788
		public bool method_7()
		{
			return this.int_9 >= Class2447.int_0;
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x000D1F80 File Offset: 0x000D0180
		public bool method_8(int int_11)
		{
			this.short_0[this.int_9] = 0;
			this.byte_1[this.int_9++] = (byte)int_11;
			short[] array;
			(array = this.class2448_0.short_0)[int_11] = (short)(array[int_11] + 1);
			return this.method_7();
		}

		// Token: 0x04000F36 RID: 3894
		private static int int_0 = 16384;

		// Token: 0x04000F37 RID: 3895
		private static int int_1 = 286;

		// Token: 0x04000F38 RID: 3896
		private static int int_2 = 30;

		// Token: 0x04000F39 RID: 3897
		private static int int_3 = 19;

		// Token: 0x04000F3A RID: 3898
		private static int int_4 = 16;

		// Token: 0x04000F3B RID: 3899
		private static int int_5 = 17;

		// Token: 0x04000F3C RID: 3900
		private static int int_6 = 18;

		// Token: 0x04000F3D RID: 3901
		private static int int_7 = 256;

		// Token: 0x04000F3E RID: 3902
		private static int[] int_8 = new int[]
		{
			16,
			17,
			18,
			0,
			8,
			7,
			9,
			6,
			10,
			5,
			11,
			4,
			12,
			3,
			13,
			2,
			14,
			1,
			15
		};

		// Token: 0x04000F3F RID: 3903
		private static byte[] byte_0 = new byte[]
		{
			0,
			8,
			4,
			12,
			2,
			10,
			6,
			14,
			1,
			9,
			5,
			13,
			3,
			11,
			7,
			15
		};

		// Token: 0x04000F40 RID: 3904
		public Class2444 class2444_0;

		// Token: 0x04000F41 RID: 3905
		private Class2447.Class2448 class2448_0;

		// Token: 0x04000F42 RID: 3906
		private Class2447.Class2448 class2448_1;

		// Token: 0x04000F43 RID: 3907
		private Class2447.Class2448 class2448_2;

		// Token: 0x04000F44 RID: 3908
		private short[] short_0;

		// Token: 0x04000F45 RID: 3909
		private byte[] byte_1;

		// Token: 0x04000F46 RID: 3910
		private int int_9;

		// Token: 0x04000F47 RID: 3911
		private int int_10;

		// Token: 0x04000F48 RID: 3912
		private static short[] short_1 = new short[Class2447.int_1];

		// Token: 0x04000F49 RID: 3913
		private static byte[] byte_2 = new byte[Class2447.int_1];

		// Token: 0x04000F4A RID: 3914
		private static short[] short_2;

		// Token: 0x04000F4B RID: 3915
		private static byte[] byte_3;

		// Token: 0x020004CF RID: 1231
		public sealed class Class2448
		{
			// Token: 0x0600201D RID: 8221 RVA: 0x0001359A File Offset: 0x0001179A
			public Class2448(Class2447 class2447_1, int int_4, int int_5, int int_6)
			{
				this.class2447_0 = class2447_1;
				this.int_0 = int_5;
				this.int_3 = int_6;
				this.short_0 = new short[int_4];
				this.int_2 = new int[int_6];
			}

			// Token: 0x0600201E RID: 8222 RVA: 0x000D1FD0 File Offset: 0x000D01D0
			public void method_0()
			{
				for (int i = 0; i < this.short_0.Length; i++)
				{
					this.short_0[i] = 0;
				}
				this.short_1 = null;
				this.byte_0 = null;
			}

			// Token: 0x0600201F RID: 8223 RVA: 0x000135D8 File Offset: 0x000117D8
			public void method_1(int int_4)
			{
				this.class2447_0.class2444_0.method_4((int)this.short_1[int_4] & 65535, (int)this.byte_0[int_4]);
			}

			// Token: 0x06002020 RID: 8224 RVA: 0x00013600 File Offset: 0x00011800
			public void method_2(short[] short_2, byte[] byte_1)
			{
				this.short_1 = short_2;
				this.byte_0 = byte_1;
			}

			// Token: 0x06002021 RID: 8225 RVA: 0x000D200C File Offset: 0x000D020C
			public void method_3()
			{
				int[] array = new int[this.int_3];
				int num = 0;
				this.short_1 = new short[this.short_0.Length];
				for (int i = 0; i < this.int_3; i++)
				{
					array[i] = num;
					num += this.int_2[i] << 15 - i;
				}
				for (int j = 0; j < this.int_1; j++)
				{
					int num2 = (int)this.byte_0[j];
					if (num2 > 0)
					{
						this.short_1[j] = Class2447.smethod_0(array[num2 - 1]);
						int[] array2;
						IntPtr value;
						(array2 = array)[(int)(value = (IntPtr)(num2 - 1))] = array2[(int)value] + (1 << 16 - num2);
					}
				}
			}

			// Token: 0x06002022 RID: 8226 RVA: 0x000D20CC File Offset: 0x000D02CC
			private void method_4(int[] int_4)
			{
				this.byte_0 = new byte[this.short_0.Length];
				int num = int_4.Length / 2;
				int num2 = (num + 1) / 2;
				int num3 = 0;
				for (int i = 0; i < this.int_3; i++)
				{
					this.int_2[i] = 0;
				}
				int[] array = new int[num];
				array[num - 1] = 0;
				for (int j = num - 1; j >= 0; j--)
				{
					if (int_4[2 * j + 1] != -1)
					{
						int num4 = array[j] + 1;
						if (num4 > this.int_3)
						{
							num4 = this.int_3;
							num3++;
						}
						array[int_4[2 * j]] = (array[int_4[2 * j + 1]] = num4);
					}
					else
					{
						int num5 = array[j];
						int[] array2;
						IntPtr value;
						(array2 = this.int_2)[(int)(value = (IntPtr)(num5 - 1))] = array2[(int)value] + 1;
						this.byte_0[int_4[2 * j]] = (byte)array[j];
					}
				}
				if (num3 != 0)
				{
					int num6 = this.int_3 - 1;
					int[] array2;
					IntPtr value;
					while (true)
					{
						if (this.int_2[--num6] != 0)
						{
							do
							{
								(array2 = this.int_2)[(int)(value = (IntPtr)num6)] = array2[(int)value] - 1;
								(array2 = this.int_2)[(int)(value = (IntPtr)(++num6))] = array2[(int)value] + 1;
								num3 -= 1 << this.int_3 - 1 - num6;
							}
							while (num3 > 0 && num6 < this.int_3 - 1);
							if (num3 <= 0)
							{
								break;
							}
						}
					}
					(array2 = this.int_2)[(int)(value = (IntPtr)(this.int_3 - 1))] = array2[(int)value] + num3;
					(array2 = this.int_2)[(int)(value = (IntPtr)(this.int_3 - 2))] = array2[(int)value] - num3;
					int num7 = 2 * num2;
					for (int num8 = this.int_3; num8 != 0; num8--)
					{
						int k = this.int_2[num8 - 1];
						while (k > 0)
						{
							int num9 = 2 * int_4[num7++];
							if (int_4[num9 + 1] == -1)
							{
								this.byte_0[int_4[num9]] = (byte)num8;
								k--;
							}
						}
					}
				}
			}

			// Token: 0x06002023 RID: 8227 RVA: 0x000D2348 File Offset: 0x000D0548
			public void method_5()
			{
				int num = this.short_0.Length;
				int[] array = new int[num];
				int i = 0;
				int num2 = 0;
				for (int j = 0; j < num; j++)
				{
					int num3 = (int)this.short_0[j];
					if (num3 != 0)
					{
						int num4 = i++;
						int num5 = 0;
						while (num4 > 0 && (int)this.short_0[array[num5 = (num4 - 1) / 2]] > num3)
						{
							array[num4] = array[num5];
							num4 = num5;
						}
						array[num4] = j;
						num2 = j;
					}
				}
				while (i < 2)
				{
					int num6 = (num2 < 2) ? (++num2) : 0;
					array[i++] = num6;
				}
				this.int_1 = Math.Max(num2 + 1, this.int_0);
				int num7 = i;
				int[] array2 = new int[4 * i - 2];
				int[] array3 = new int[2 * i - 1];
				int num8 = num7;
				for (int k = 0; k < i; k++)
				{
					int num9 = array[k];
					array2[2 * k] = num9;
					array2[2 * k + 1] = -1;
					array3[k] = (int)this.short_0[num9] << 8;
					array[k] = k;
				}
				do
				{
					int num10 = array[0];
					int num11 = array[--i];
					int num12 = 0;
					int l;
					for (l = 1; l < i; l = l * 2 + 1)
					{
						if (l + 1 < i && array3[array[l]] > array3[array[l + 1]])
						{
							l++;
						}
						array[num12] = array[l];
						num12 = l;
					}
					int num13 = array3[num11];
					while ((l = num12) > 0 && array3[array[num12 = (l - 1) / 2]] > num13)
					{
						array[l] = array[num12];
					}
					array[l] = num11;
					int num14 = array[0];
					num11 = num8++;
					array2[2 * num11] = num10;
					array2[2 * num11 + 1] = num14;
					int num15 = Math.Min(array3[num10] & 255, array3[num14] & 255);
					num13 = (array3[num11] = array3[num10] + array3[num14] - num15 + 1);
					num12 = 0;
					for (l = 1; l < i; l = num12 * 2 + 1)
					{
						if (l + 1 < i && array3[array[l]] > array3[array[l + 1]])
						{
							l++;
						}
						array[num12] = array[l];
						num12 = l;
					}
					while ((l = num12) > 0 && array3[array[num12 = (l - 1) / 2]] > num13)
					{
						array[l] = array[num12];
					}
					array[l] = num11;
				}
				while (i > 1);
				if (array[0] != array2.Length / 2 - 1)
				{
					throw new Exception30("Heap invariant violated");
				}
				this.method_4(array2);
			}

			// Token: 0x06002024 RID: 8228 RVA: 0x000D2600 File Offset: 0x000D0800
			public int method_6()
			{
				int num = 0;
				for (int i = 0; i < this.short_0.Length; i++)
				{
					num += (int)(this.short_0[i] * (short)this.byte_0[i]);
				}
				return num;
			}

			// Token: 0x06002025 RID: 8229 RVA: 0x000D263C File Offset: 0x000D083C
			public void method_7(Class2447.Class2448 class2448_0)
			{
				int num = -1;
				int i = 0;
				while (i < this.int_1)
				{
					int num2 = 1;
					int num3 = (int)this.byte_0[i];
					int num4;
					int num5;
					if (num3 == 0)
					{
						num4 = 138;
						num5 = 3;
					}
					else
					{
						num4 = 6;
						num5 = 3;
						if (num != num3)
						{
							short[] array;
							IntPtr value;
							(array = class2448_0.short_0)[(int)(value = (IntPtr)num3)] = (short)(array[(int)value] + 1);
							num2 = 0;
						}
					}
					num = num3;
					i++;
					while (i < this.int_1 && num == (int)this.byte_0[i])
					{
						i++;
						if (++num2 >= num4)
						{
							break;
						}
					}
					if (num2 < num5)
					{
						short[] array;
						IntPtr value;
						(array = class2448_0.short_0)[(int)(value = (IntPtr)num)] = (short)(array[(int)value] + (short)num2);
					}
					else if (num != 0)
					{
						short[] array;
						IntPtr value;
						(array = class2448_0.short_0)[(int)(value = (IntPtr)Class2447.int_4)] = (short)(array[(int)value] + 1);
					}
					else if (num2 <= 10)
					{
						short[] array;
						IntPtr value;
						(array = class2448_0.short_0)[(int)(value = (IntPtr)Class2447.int_5)] = (short)(array[(int)value] + 1);
					}
					else
					{
						short[] array;
						IntPtr value;
						(array = class2448_0.short_0)[(int)(value = (IntPtr)Class2447.int_6)] = (short)(array[(int)value] + 1);
					}
				}
			}

			// Token: 0x06002026 RID: 8230 RVA: 0x000D27AC File Offset: 0x000D09AC
			public void method_8(Class2447.Class2448 class2448_0)
			{
				int num = -1;
				int i = 0;
				while (i < this.int_1)
				{
					int num2 = 1;
					int num3 = (int)this.byte_0[i];
					int num4;
					int num5;
					if (num3 == 0)
					{
						num4 = 138;
						num5 = 3;
					}
					else
					{
						num4 = 6;
						num5 = 3;
						if (num != num3)
						{
							class2448_0.method_1(num3);
							num2 = 0;
						}
					}
					num = num3;
					i++;
					while (i < this.int_1 && num == (int)this.byte_0[i])
					{
						i++;
						if (++num2 >= num4)
						{
							break;
						}
					}
					if (num2 < num5)
					{
						while (num2-- > 0)
						{
							class2448_0.method_1(num);
						}
					}
					else if (num != 0)
					{
						class2448_0.method_1(Class2447.int_4);
						this.class2447_0.class2444_0.method_4(num2 - 3, 2);
					}
					else if (num2 <= 10)
					{
						class2448_0.method_1(Class2447.int_5);
						this.class2447_0.class2444_0.method_4(num2 - 3, 3);
					}
					else
					{
						class2448_0.method_1(Class2447.int_6);
						this.class2447_0.class2444_0.method_4(num2 - 11, 7);
					}
				}
			}

			// Token: 0x04000F4C RID: 3916
			public short[] short_0;

			// Token: 0x04000F4D RID: 3917
			public byte[] byte_0;

			// Token: 0x04000F4E RID: 3918
			public int int_0;

			// Token: 0x04000F4F RID: 3919
			public int int_1;

			// Token: 0x04000F50 RID: 3920
			private short[] short_1;

			// Token: 0x04000F51 RID: 3921
			private int[] int_2;

			// Token: 0x04000F52 RID: 3922
			private int int_3 = 0;

			// Token: 0x04000F53 RID: 3923
			private Class2447 class2447_0;
		}
	}
}

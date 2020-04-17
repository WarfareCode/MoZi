using System;

namespace ns31
{
	// Token: 0x020004A0 RID: 1184
	public sealed class Class2437 : ICloneable
	{
		// Token: 0x06001E94 RID: 7828 RVA: 0x0001279C File Offset: 0x0001099C
		public bool method_0()
		{
			return (this.int_6 & 1) != 0;
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x000127AC File Offset: 0x000109AC
		public void method_1(int int_8)
		{
			this.int_6 = int_8;
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x000CA2B8 File Offset: 0x000C84B8
		public int method_2()
		{
			int result;
			if (((int)this.ushort_0 & Class2437.int_4) == 0)
			{
				result = -1;
			}
			else
			{
				result = this.int_5;
			}
			return result;
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x000CA2E8 File Offset: 0x000C84E8
		public int method_3()
		{
			return this.ushort_1 >> 8 & 255;
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x000127B5 File Offset: 0x000109B5
		internal Class2437(string string_2, int int_8) : this(string_2, int_8, 20)
		{
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x000CA308 File Offset: 0x000C8508
		internal Class2437(string string_2, int int_8, int int_9)
		{
			if (string_2 == null)
			{
				throw new ArgumentNullException("ZipEntry name");
			}
			if (string_2.Length == 0)
			{
				throw new ArgumentException("ZipEntry name is empty");
			}
			if (int_8 != 0 && int_8 < 10)
			{
				throw new ArgumentOutOfRangeException("versionRequiredToExtract");
			}
			this.method_8(DateTime.Now);
			this.string_0 = string_2;
			this.ushort_1 = (ushort)int_9;
			this.ushort_2 = (ushort)int_8;
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x000CA3B0 File Offset: 0x000C85B0
		public int method_4()
		{
			int result;
			if (this.ushort_2 != 0)
			{
				result = (int)this.ushort_2;
			}
			else
			{
				int num = 10;
				if (Enum178.const_1 == this.enum178_0)
				{
					num = 20;
				}
				else if (this.method_16())
				{
					num = 20;
				}
				else if (this.method_0())
				{
					num = 20;
				}
				else if (((int)this.ushort_0 & Class2437.int_4) != 0 && (this.int_5 & 8) != 0)
				{
					num = 11;
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x000CA42C File Offset: 0x000C862C
		public long method_5()
		{
			long result;
			if (((int)this.ushort_0 & Class2437.int_3) == 0)
			{
				result = 0L;
			}
			else
			{
				result = (long)((ulong)this.uint_1);
			}
			return result;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x000127C1 File Offset: 0x000109C1
		public void method_6(long long_0)
		{
			this.uint_1 = (uint)long_0;
			this.ushort_0 |= (ushort)Class2437.int_3;
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x000CA464 File Offset: 0x000C8664
		public DateTime method_7()
		{
			DateTime result;
			if (this.uint_1 == 0u)
			{
				result = DateTime.Now;
			}
			else
			{
				uint second = 2u * (this.uint_1 & 31u);
				uint minute = this.uint_1 >> 5 & 63u;
				uint hour = this.uint_1 >> 11 & 31u;
				uint day = this.uint_1 >> 16 & 31u;
				uint month = this.uint_1 >> 21 & 15u;
				uint year = (this.uint_1 >> 25 & 127u) + 1980u;
				result = new DateTime((int)year, (int)month, (int)day, (int)hour, (int)minute, (int)second);
			}
			return result;
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x000CA4EC File Offset: 0x000C86EC
		public void method_8(DateTime dateTime_0)
		{
			this.method_6((long)((dateTime_0.Year - 1980 & 127) << 25 | dateTime_0.Month << 21 | dateTime_0.Day << 16 | dateTime_0.Hour << 11 | dateTime_0.Minute << 5 | (int)((uint)dateTime_0.Second >> 1)));
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x000CA548 File Offset: 0x000C8748
		public string method_9()
		{
			return this.string_0;
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x000127DF File Offset: 0x000109DF
		public void method_10(long long_0)
		{
			if ((long_0 & -4294967296L) != 0L)
			{
				throw new ArgumentOutOfRangeException("size");
			}
			this.ulong_0 = (ulong)long_0;
			this.ushort_0 |= (ushort)Class2437.int_0;
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x0001281F File Offset: 0x00010A1F
		public void method_11(long long_0)
		{
			if ((long_0 & -4294967296L) != 0L)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.ulong_1 = (ulong)long_0;
			this.ushort_0 |= (ushort)Class2437.int_1;
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x000CA560 File Offset: 0x000C8760
		public long method_12()
		{
			long result;
			if (((int)this.ushort_0 & Class2437.int_2) == 0)
			{
				result = -1L;
			}
			else
			{
				result = (long)((ulong)this.uint_0 & 18446744073709551615uL);
			}
			return result;
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x0001285A File Offset: 0x00010A5A
		public void method_13(long long_0)
		{
			this.uint_0 = (uint)long_0;
			this.ushort_0 |= (ushort)Class2437.int_2;
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00012878 File Offset: 0x00010A78
		public void method_14(Enum178 enum178_1)
		{
			this.enum178_0 = enum178_1;
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x000CA5A0 File Offset: 0x000C87A0
		public void method_15(byte[] byte_1)
		{
			if (byte_1 == null)
			{
				this.byte_0 = null;
			}
			else
			{
				if (byte_1.Length > 65535)
				{
					throw new ArgumentOutOfRangeException();
				}
				this.byte_0 = new byte[byte_1.Length];
				Array.Copy(byte_1, 0, this.byte_0, 0, byte_1.Length);
				try
				{
					int num2;
					for (int i = 0; i < this.byte_0.Length; i += num2)
					{
						int num = (int)(this.byte_0[i++] & 255) | (int)(this.byte_0[i++] & 255) << 8;
						num2 = ((int)(this.byte_0[i++] & 255) | (int)(this.byte_0[i++] & 255) << 8);
						if (num2 < 0 || i + num2 > this.byte_0.Length)
						{
							break;
						}
						if (num == 21589)
						{
							int num3 = (int)this.byte_0[i];
							if ((num3 & 1) != 0 && num2 >= 5)
							{
								int seconds = (int)(this.byte_0[i + 1] & 255) | (int)(this.byte_0[i + 2] & 255) << 8 | (int)(this.byte_0[i + 3] & 255) << 16 | (int)(this.byte_0[i + 4] & 255) << 24;
								this.method_8((new DateTime(1970, 1, 1, 0, 0, 0) + new TimeSpan(0, 0, 0, seconds, 0)).ToLocalTime());
								this.ushort_0 |= (ushort)Class2437.int_3;
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x000CA75C File Offset: 0x000C895C
		public bool method_16()
		{
			int length = this.string_0.Length;
			bool result;
			if (!(result = (length > 0 && this.string_0[length - 1] == '/')) && ((int)this.ushort_0 & Class2437.int_4) != 0 && this.method_3() == 0 && (this.method_2() & 16) != 0)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x000CA7C0 File Offset: 0x000C89C0
		public bool method_17()
		{
			bool result;
			if ((result = !this.method_16()) && ((int)this.ushort_0 & Class2437.int_4) != 0 && this.method_3() == 0 && (this.method_2() & 8) != 0)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x000CA808 File Offset: 0x000C8A08
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000CA548 File Offset: 0x000C8748
		public override string ToString()
		{
			return this.string_0;
		}

		// Token: 0x04000E0E RID: 3598
		private static int int_0 = 1;

		// Token: 0x04000E0F RID: 3599
		private static int int_1 = 2;

		// Token: 0x04000E10 RID: 3600
		private static int int_2 = 4;

		// Token: 0x04000E11 RID: 3601
		private static int int_3 = 8;

		// Token: 0x04000E12 RID: 3602
		private static int int_4 = 16;

		// Token: 0x04000E13 RID: 3603
		private ushort ushort_0 = 0;

		// Token: 0x04000E14 RID: 3604
		private int int_5 = -1;

		// Token: 0x04000E15 RID: 3605
		private ushort ushort_1;

		// Token: 0x04000E16 RID: 3606
		private string string_0;

		// Token: 0x04000E17 RID: 3607
		private ulong ulong_0;

		// Token: 0x04000E18 RID: 3608
		private ulong ulong_1;

		// Token: 0x04000E19 RID: 3609
		private ushort ushort_2;

		// Token: 0x04000E1A RID: 3610
		private uint uint_0;

		// Token: 0x04000E1B RID: 3611
		private uint uint_1;

		// Token: 0x04000E1C RID: 3612
		private Enum178 enum178_0 = Enum178.const_1;

		// Token: 0x04000E1D RID: 3613
		private byte[] byte_0 = null;

		// Token: 0x04000E1E RID: 3614
		private string string_1 = null;

		// Token: 0x04000E1F RID: 3615
		private int int_6;

		// Token: 0x04000E20 RID: 3616
		private int int_7 = -1;
	}
}

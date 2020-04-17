using System;

namespace ns26
{
	// Token: 0x020007E9 RID: 2025
	public sealed class Class2336
	{
		// Token: 0x0600320F RID: 12815 RVA: 0x0010D310 File Offset: 0x0010B510
		public static long smethod_0(long long_2)
		{
			return long_2 >> 52;
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x0010D324 File Offset: 0x0010B524
		public static int smethod_1(long long_2, long long_3)
		{
			int num = 0;
			int result;
			for (int i = 52; i >= 0; i--)
			{
				if (Class2336.smethod_3(long_2, i) != Class2336.smethod_3(long_3, i))
				{
					result = num;
					return result;
				}
				num++;
			}
			result = 52;
			return result;
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x0010D364 File Offset: 0x0010B564
		public static long smethod_2(long long_2, int int_1)
		{
			long num = (1L << int_1) - 1L;
			long num2 = ~num;
			return long_2 & num2;
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x0010D394 File Offset: 0x0010B594
		public static int smethod_3(long long_2, int int_1)
		{
			long num = 1L << int_1;
			int result;
			if ((long_2 & num) == 0L)
			{
				result = 0;
			}
			else
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x0010D3CC File Offset: 0x0010B5CC
		public  void vmethod_0(double double_0)
		{
			long num = BitConverter.DoubleToInt64Bits(double_0);
			if (this.bool_0)
			{
				this.long_0 = num;
				this.long_1 = Class2336.smethod_0(this.long_0);
				this.bool_0 = false;
			}
			else
			{
				long num2 = Class2336.smethod_0(num);
				if (num2 != this.long_1)
				{
					this.long_0 = 0L;
				}
				else
				{
					this.int_0 = Class2336.smethod_1(this.long_0, num);
					this.long_0 = Class2336.smethod_2(this.long_0, 64 - (12 + this.int_0));
				}
			}
		}

		// Token: 0x04001736 RID: 5942
		private long long_0;

		// Token: 0x04001737 RID: 5943
		private int int_0 = 53;

		// Token: 0x04001738 RID: 5944
		private long long_1;

		// Token: 0x04001739 RID: 5945
		private bool bool_0 = true;
	}
}

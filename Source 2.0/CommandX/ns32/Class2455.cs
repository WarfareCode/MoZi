using System;

namespace ns32
{
	// Token: 0x020004E1 RID: 1249
	public sealed class Class2455
	{
		// Token: 0x06002086 RID: 8326 RVA: 0x000D47C4 File Offset: 0x000D29C4
		public void method_0(int int_4)
		{
			if (this.int_3++ == Class2455.int_0)
			{
				throw new InvalidOperationException("Window full");
			}
			this.byte_0[this.int_2++] = (byte)int_4;
			this.int_2 &= Class2455.int_1;
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x000D4828 File Offset: 0x000D2A28
		private void method_1(int int_4, int int_5, int int_6)
		{
			while (int_5-- > 0)
			{
				this.byte_0[this.int_2++] = this.byte_0[int_4++];
				this.int_2 &= Class2455.int_1;
				int_4 &= Class2455.int_1;
			}
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x000D4884 File Offset: 0x000D2A84
		public void method_2(int int_4, int int_5)
		{
			if ((this.int_3 += int_4) > Class2455.int_0)
			{
				throw new InvalidOperationException("Window full");
			}
			int num = this.int_2 - int_5 & Class2455.int_1;
			int num2 = Class2455.int_0 - int_4;
			if (num > num2 || this.int_2 >= num2)
			{
				this.method_1(num, int_4, int_5);
			}
			else if (int_4 <= int_5)
			{
				Array.Copy(this.byte_0, num, this.byte_0, this.int_2, int_4);
				this.int_2 += int_4;
			}
			else
			{
				while (int_4-- > 0)
				{
					this.byte_0[this.int_2++] = this.byte_0[num++];
				}
			}
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x000D494C File Offset: 0x000D2B4C
		public int method_3(Class2454 class2454_0, int int_4)
		{
			int_4 = Math.Min(Math.Min(int_4, Class2455.int_0 - this.int_3), class2454_0.method_3());
			int num = Class2455.int_0 - this.int_2;
			int num2;
			if (int_4 > num)
			{
				num2 = class2454_0.method_6(this.byte_0, this.int_2, num);
				if (num2 == num)
				{
					num2 += class2454_0.method_6(this.byte_0, 0, int_4 - num);
				}
			}
			else
			{
				num2 = class2454_0.method_6(this.byte_0, this.int_2, int_4);
			}
			this.int_2 = (this.int_2 + num2 & Class2455.int_1);
			this.int_3 += num2;
			return num2;
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x000D49FC File Offset: 0x000D2BFC
		public int method_4()
		{
			return Class2455.int_0 - this.int_3;
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x000D4A18 File Offset: 0x000D2C18
		public int method_5()
		{
			return this.int_3;
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x000D4A30 File Offset: 0x000D2C30
		public int method_6(byte[] byte_1, int int_4, int int_5)
		{
			int num = this.int_2;
			if (int_5 > this.int_3)
			{
				int_5 = this.int_3;
			}
			else
			{
				num = (this.int_2 - this.int_3 + int_5 & Class2455.int_1);
			}
			int num2 = int_5;
			int num3 = int_5 - num;
			if (num3 > 0)
			{
				Array.Copy(this.byte_0, Class2455.int_0 - num3, byte_1, int_4, num3);
				int_4 += num3;
				int_5 = num;
			}
			Array.Copy(this.byte_0, num - int_5, byte_1, int_4, int_5);
			this.int_3 -= num2;
			if (this.int_3 < 0)
			{
				throw new InvalidOperationException();
			}
			return num2;
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00013950 File Offset: 0x00011B50
		public void method_7()
		{
			this.int_2 = 0;
			this.int_3 = 0;
		}

		// Token: 0x04000FC8 RID: 4040
		private static int int_0 = 32768;

		// Token: 0x04000FC9 RID: 4041
		private static int int_1 = Class2455.int_0 - 1;

		// Token: 0x04000FCA RID: 4042
		private byte[] byte_0 = new byte[Class2455.int_0];

		// Token: 0x04000FCB RID: 4043
		private int int_2 = 0;

		// Token: 0x04000FCC RID: 4044
		private int int_3 = 0;
	}
}

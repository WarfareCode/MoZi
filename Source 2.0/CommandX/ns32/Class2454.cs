using System;

namespace ns32
{
	// Token: 0x020004DC RID: 1244
	public sealed class Class2454
	{
		// Token: 0x0600205F RID: 8287 RVA: 0x000D3EB8 File Offset: 0x000D20B8
		public int method_0(int int_3)
		{
			int result;
			if (this.int_2 < int_3)
			{
				if (this.int_0 == this.int_1)
				{
					result = -1;
					return result;
				}
				this.uint_0 |= (uint)((uint)((int)(this.byte_0[this.int_0++] & 255) | (int)(this.byte_0[this.int_0++] & 255) << 8) << this.int_2);
				this.int_2 += 16;
			}
			result = (int)((ulong)this.uint_0 & (ulong)((long)((1 << int_3) - 1)));
			return result;
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x000137D9 File Offset: 0x000119D9
		public void method_1(int int_3)
		{
			this.uint_0 >>= int_3;
			this.int_2 -= int_3;
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000D3F64 File Offset: 0x000D2164
		public int method_2()
		{
			return this.int_2;
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000D3F7C File Offset: 0x000D217C
		public int method_3()
		{
			return this.int_1 - this.int_0 + (this.int_2 >> 3);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000137FA File Offset: 0x000119FA
		public void method_4()
		{
			this.uint_0 >>= (this.int_2 & 7);
			this.int_2 &= -8;
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x00013823 File Offset: 0x00011A23
		public bool method_5()
		{
			return this.int_0 == this.int_1;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000D3FA4 File Offset: 0x000D21A4
		public int method_6(byte[] byte_1, int int_3, int int_4)
		{
			if (int_4 < 0)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			if ((this.int_2 & 7) != 0)
			{
				throw new InvalidOperationException("Bit buffer is not byte aligned!");
			}
			int num = 0;
			while (this.int_2 > 0 && int_4 > 0)
			{
				byte_1[int_3++] = (byte)this.uint_0;
				this.uint_0 >>= 8;
				this.int_2 -= 8;
				int_4--;
				num++;
			}
			int result;
			if (int_4 == 0)
			{
				result = num;
			}
			else
			{
				int num2 = this.int_1 - this.int_0;
				if (int_4 > num2)
				{
					int_4 = num2;
				}
				Array.Copy(this.byte_0, this.int_0, byte_1, int_3, int_4);
				this.int_0 += int_4;
				if ((this.int_0 - this.int_1 & 1) != 0)
				{
					this.uint_0 = (uint)(this.byte_0[this.int_0++] & 255);
					this.int_2 = 8;
				}
				result = num + int_4;
			}
			return result;
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00013833 File Offset: 0x00011A33
		public void method_7()
		{
			this.int_2 = 0;
			this.int_1 = 0;
			this.int_0 = 0;
			this.uint_0 = 0u;
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000D40B8 File Offset: 0x000D22B8
		public void method_8(byte[] byte_1, int int_3, int int_4)
		{
			if (this.int_0 < this.int_1)
			{
				throw new InvalidOperationException("Old input was not completely processed");
			}
			int num = int_3 + int_4;
			if (0 <= int_3 && int_3 <= num && num <= byte_1.Length)
			{
				if ((int_4 & 1) != 0)
				{
					this.uint_0 |= (uint)((uint)(byte_1[int_3++] & 255) << this.int_2);
					this.int_2 += 8;
				}
				this.byte_0 = byte_1;
				this.int_0 = int_3;
				this.int_1 = num;
				return;
			}
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x04000FBF RID: 4031
		private byte[] byte_0;

		// Token: 0x04000FC0 RID: 4032
		private int int_0 = 0;

		// Token: 0x04000FC1 RID: 4033
		private int int_1 = 0;

		// Token: 0x04000FC2 RID: 4034
		private uint uint_0 = 0u;

		// Token: 0x04000FC3 RID: 4035
		private int int_2 = 0;
	}
}

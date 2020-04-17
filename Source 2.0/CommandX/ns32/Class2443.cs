using System;

namespace ns32
{
	// Token: 0x020004B1 RID: 1201
	public class Class2443
	{
		// Token: 0x06001F74 RID: 8052 RVA: 0x00012E4A File Offset: 0x0001104A
		public Class2443() : this(4096)
		{
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00012E57 File Offset: 0x00011057
		public Class2443(int int_3)
		{
			this.byte_0 = new byte[int_3];
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00012E72 File Offset: 0x00011072
		public void method_0()
		{
			this.int_2 = 0;
			this.int_1 = 0;
			this.int_0 = 0;
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x000CF28C File Offset: 0x000CD48C
		public void method_1(int int_3)
		{
			this.byte_0[this.int_1++] = (byte)int_3;
			this.byte_0[this.int_1++] = (byte)(int_3 >> 8);
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00012E89 File Offset: 0x00011089
		public void method_2(byte[] byte_1, int int_3, int int_4)
		{
			Array.Copy(byte_1, int_3, this.byte_0, this.int_1, int_4);
			this.int_1 += int_4;
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x000CF2D0 File Offset: 0x000CD4D0
		public void method_3()
		{
			if (this.int_2 > 0)
			{
				this.byte_0[this.int_1++] = (byte)this.uint_0;
				if (this.int_2 > 8)
				{
					this.byte_0[this.int_1++] = (byte)(this.uint_0 >> 8);
				}
			}
			this.uint_0 = 0u;
			this.int_2 = 0;
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x000CF348 File Offset: 0x000CD548
		public void method_4(int int_3, int int_4)
		{
			this.uint_0 |= (uint)((uint)int_3 << this.int_2);
			this.int_2 += int_4;
			if (this.int_2 >= 16)
			{
				this.byte_0[this.int_1++] = (byte)this.uint_0;
				this.byte_0[this.int_1++] = (byte)(this.uint_0 >> 8);
				this.uint_0 >>= 16;
				this.int_2 -= 16;
			}
		}

		// Token: 0x04000EB3 RID: 3763
		protected byte[] byte_0;

		// Token: 0x04000EB4 RID: 3764
		private int int_0;

		// Token: 0x04000EB5 RID: 3765
		private int int_1;

		// Token: 0x04000EB6 RID: 3766
		private uint uint_0;

		// Token: 0x04000EB7 RID: 3767
		private int int_2 = 0;
	}
}

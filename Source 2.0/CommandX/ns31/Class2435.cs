using System;

namespace ns31
{
	// Token: 0x02000498 RID: 1176
	public sealed class Class2435
	{
		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x000C65EC File Offset: 0x000C47EC
		public long Value
		{
			get
			{
				return (long)((ulong)this.uint_1);
			}
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x000126AC File Offset: 0x000108AC
		public Class2435()
		{
			this.vmethod_0();
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x000126BA File Offset: 0x000108BA
		public void vmethod_0()
		{
			this.uint_1 = 1u;
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x000C6604 File Offset: 0x000C4804
		public void vmethod_1(byte[] byte_0, int int_0, int int_1)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("buf");
			}
			if (int_0 >= 0 && int_1 >= 0 && int_0 + int_1 <= byte_0.Length)
			{
				uint num = this.uint_1 & 65535u;
				uint num2 = this.uint_1 >> 16;
				while (int_1 > 0)
				{
					int num3 = 3800;
					if (3800 > int_1)
					{
						num3 = int_1;
					}
					int_1 -= num3;
					while (--num3 >= 0)
					{
						num += (uint)(byte_0[int_0++] & 255);
						num2 += num;
					}
					num %= Class2435.uint_0;
					num2 %= Class2435.uint_0;
				}
				this.uint_1 = (num2 << 16 | num);
				return;
			}
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x04000DEE RID: 3566
		private static readonly uint uint_0 = 65521u;

		// Token: 0x04000DEF RID: 3567
		private uint uint_1;
	}
}

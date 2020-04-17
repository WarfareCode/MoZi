using System;
using ns31;

namespace ns32
{
	// Token: 0x020004D2 RID: 1234
	public sealed class Class2450 : Class2449
	{
		// Token: 0x06002029 RID: 8233 RVA: 0x000D295C File Offset: 0x000D0B5C
		public Class2450(Class2444 class2444_1)
		{
			this.class2444_0 = class2444_1;
			this.class2447_0 = new Class2447(class2444_1);
			this.class2435_0 = new Class2435();
			this.byte_0 = new byte[65536];
			this.short_0 = new short[32768];
			this.short_1 = new short[32768];
			this.int_10 = 1;
			this.int_9 = 1;
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x000D29CC File Offset: 0x000D0BCC
		public void method_0()
		{
			this.class2447_0.method_0();
			this.class2435_0.vmethod_0();
			this.int_10 = 1;
			this.int_9 = 1;
			this.int_11 = 0;
			this.int_17 = 0;
			this.bool_0 = false;
			this.int_8 = 2;
			for (int i = 0; i < 32768; i++)
			{
				this.short_0[i] = 0;
			}
			for (int j = 0; j < 32768; j++)
			{
				this.short_1[j] = 0;
			}
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00013610 File Offset: 0x00011810
		public void method_1(Enum179 enum179_1)
		{
			this.enum179_0 = enum179_1;
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x000D2A50 File Offset: 0x000D0C50
		public void method_2(int int_18)
		{
			this.int_15 = Class2449.int_1[int_18];
			this.int_13 = Class2449.int_2[int_18];
			this.int_14 = Class2449.int_3[int_18];
			this.int_12 = Class2449.int_4[int_18];
			if (Class2449.int_5[int_18] != this.int_16)
			{
				switch (this.int_16)
				{
				case 0:
					if (this.int_10 > this.int_9)
					{
						this.class2447_0.method_5(this.byte_0, this.int_9, this.int_10 - this.int_9, false);
						this.int_9 = this.int_10;
					}
					this.method_3();
					break;
				case 1:
					if (this.int_10 > this.int_9)
					{
						this.class2447_0.method_6(this.byte_0, this.int_9, this.int_10 - this.int_9, false);
						this.int_9 = this.int_10;
					}
					break;
				case 2:
					if (this.bool_0)
					{
						this.class2447_0.method_8((int)(this.byte_0[this.int_10 - 1] & 255));
					}
					if (this.int_10 > this.int_9)
					{
						this.class2447_0.method_6(this.byte_0, this.int_9, this.int_10 - this.int_9, false);
						this.int_9 = this.int_10;
					}
					this.bool_0 = false;
					this.int_8 = 2;
					break;
				}
				this.int_16 = Class2449.int_5[int_18];
			}
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00013619 File Offset: 0x00011819
		private void method_3()
		{
			this.int_7 = ((int)this.byte_0[this.int_10] << 5 ^ (int)this.byte_0[this.int_10 + 1]);
		}

		// Token: 0x04000F5E RID: 3934
		private static int int_6 = 4096;

		// Token: 0x04000F5F RID: 3935
		private int int_7;

		// Token: 0x04000F60 RID: 3936
		private short[] short_0;

		// Token: 0x04000F61 RID: 3937
		private short[] short_1;

		// Token: 0x04000F62 RID: 3938
		private int int_8;

		// Token: 0x04000F63 RID: 3939
		private bool bool_0;

		// Token: 0x04000F64 RID: 3940
		private int int_9;

		// Token: 0x04000F65 RID: 3941
		private int int_10;

		// Token: 0x04000F66 RID: 3942
		private int int_11;

		// Token: 0x04000F67 RID: 3943
		private byte[] byte_0;

		// Token: 0x04000F68 RID: 3944
		private Enum179 enum179_0;

		// Token: 0x04000F69 RID: 3945
		private int int_12;

		// Token: 0x04000F6A RID: 3946
		private int int_13;

		// Token: 0x04000F6B RID: 3947
		private int int_14;

		// Token: 0x04000F6C RID: 3948
		private int int_15;

		// Token: 0x04000F6D RID: 3949
		private int int_16;

		// Token: 0x04000F6E RID: 3950
		private int int_17;

		// Token: 0x04000F6F RID: 3951
		private Class2444 class2444_0;

		// Token: 0x04000F70 RID: 3952
		private Class2447 class2447_0;

		// Token: 0x04000F71 RID: 3953
		private Class2435 class2435_0;
	}
}

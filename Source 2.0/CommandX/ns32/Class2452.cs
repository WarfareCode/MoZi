using System;

namespace ns32
{
	// Token: 0x020004D6 RID: 1238
	public sealed class Class2452
	{
		// Token: 0x0600204C RID: 8268 RVA: 0x0001374C File Offset: 0x0001194C
		public Class2452() : this(Class2452.int_2, false)
		{
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x000D3940 File Offset: 0x000D1B40
		public Class2452(int int_17, bool bool_1)
		{
			if (int_17 == Class2452.int_2)
			{
				int_17 = 6;
			}
			else if (int_17 < Class2452.int_3 || int_17 > Class2452.int_0)
			{
				throw new ArgumentOutOfRangeException("level");
			}
			this.class2444_0 = new Class2444();
			this.class2450_0 = new Class2450(this.class2444_0);
			this.bool_0 = bool_1;
			this.method_2(Enum179.const_0);
			this.method_1(int_17);
			this.method_0();
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x000D39C0 File Offset: 0x000D1BC0
		public void method_0()
		{
			this.int_16 = (this.bool_0 ? Class2452.int_10 : Class2452.int_8);
			this.long_0 = 0L;
			this.class2444_0.method_0();
			this.class2450_0.method_0();
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x000D3A0C File Offset: 0x000D1C0C
		public void method_1(int int_17)
		{
			if (int_17 == Class2452.int_2)
			{
				int_17 = 6;
			}
			else if (int_17 < Class2452.int_3 || int_17 > Class2452.int_0)
			{
				throw new ArgumentOutOfRangeException("lvl");
			}
			if (this.int_15 != int_17)
			{
				this.int_15 = int_17;
				this.class2450_0.method_2(int_17);
			}
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x0001375A File Offset: 0x0001195A
		public void method_2(Enum179 enum179_0)
		{
			this.class2450_0.method_1(enum179_0);
		}

		// Token: 0x04000F8E RID: 3982
		public static int int_0 = 9;

		// Token: 0x04000F8F RID: 3983
		public static int int_1 = 1;

		// Token: 0x04000F90 RID: 3984
		public static int int_2 = -1;

		// Token: 0x04000F91 RID: 3985
		public static int int_3 = 0;

		// Token: 0x04000F92 RID: 3986
		public static int int_4 = 8;

		// Token: 0x04000F93 RID: 3987
		private static int int_5 = 1;

		// Token: 0x04000F94 RID: 3988
		private static int int_6 = 4;

		// Token: 0x04000F95 RID: 3989
		private static int int_7 = 8;

		// Token: 0x04000F96 RID: 3990
		private static int int_8 = 0;

		// Token: 0x04000F97 RID: 3991
		private static int int_9 = 1;

		// Token: 0x04000F98 RID: 3992
		private static int int_10 = 16;

		// Token: 0x04000F99 RID: 3993
		private static int int_11 = 20;

		// Token: 0x04000F9A RID: 3994
		private static int int_12 = 28;

		// Token: 0x04000F9B RID: 3995
		private static int int_13 = 30;

		// Token: 0x04000F9C RID: 3996
		private static int int_14 = 127;

		// Token: 0x04000F9D RID: 3997
		private int int_15;

		// Token: 0x04000F9E RID: 3998
		private bool bool_0;

		// Token: 0x04000F9F RID: 3999
		private int int_16;

		// Token: 0x04000FA0 RID: 4000
		private long long_0;

		// Token: 0x04000FA1 RID: 4001
		private Class2444 class2444_0;

		// Token: 0x04000FA2 RID: 4002
		private Class2450 class2450_0;
	}
}

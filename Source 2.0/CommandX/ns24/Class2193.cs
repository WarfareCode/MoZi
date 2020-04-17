using System;
using ns16;
using ns25;

namespace ns24
{
	// Token: 0x02000562 RID: 1378
	public sealed class Class2193 : Class2192
	{
		// Token: 0x06002386 RID: 9094 RVA: 0x000E0250 File Offset: 0x000DE450
		public Class2193(Class2199 class2199_1, bool bool_3) : base(class2199_1)
		{
			this.bool_0 = bool_3;
			if (this.bool_0)
			{
				base.vmethod_9(class2199_1.vmethod_16(0), class2199_1.vmethod_16(1));
			}
			else
			{
				int num = class2199_1.vmethod_7() - 1;
				base.vmethod_9(class2199_1.vmethod_16(num), class2199_1.vmethod_16(num - 1));
			}
			this.method_1();
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x000149D7 File Offset: 0x00012BD7
		private void method_1()
		{
			this.vmethod_2(new Class2217(this.vmethod_0().vmethod_0()));
			if (!this.bool_0)
			{
				this.vmethod_1().vmethod_0();
			}
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x000E02D8 File Offset: 0x000DE4D8
		public  int vmethod_12(Enum158 enum158_0)
		{
			return this.int_1[(int)enum158_0];
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00014A02 File Offset: 0x00012C02
		public  void vmethod_13(Enum158 enum158_0, int int_2)
		{
			if (this.int_1[(int)enum158_0] != -999 && this.int_1[(int)enum158_0] != int_2)
			{
				throw new TopologyException(TopologyText.GetTopologyException_Depth(), this.vmethod_3());
			}
			this.int_1[(int)enum158_0] = int_2;
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x000E02F0 File Offset: 0x000DE4F0
		public  void vmethod_14(Enum158 enum158_0, int int_2)
		{
			int num = this.vmethod_0().vmethod_10();
			if (!this.bool_0)
			{
				num = -num;
			}
			int num2 = 1;
			if (enum158_0 == Enum158.const_1)
			{
				num2 = -1;
			}
			Enum158 enum158_ = Class2222.smethod_0(enum158_0);
			int num3 = num * num2;
			int int_3 = int_2 + num3;
			this.vmethod_13(enum158_0, int_2);
			this.vmethod_13(enum158_, int_3);
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x000E0344 File Offset: 0x000DE544
		public  Class2205 vmethod_15()
		{
			return this.class2205_0;
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00014A3D File Offset: 0x00012C3D
		public  void vmethod_16(Class2205 class2205_2)
		{
			this.class2205_0 = class2205_2;
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00014A46 File Offset: 0x00012C46
		public   bool vmethod_17()
		{
			return this.bool_0;
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x00014A4E File Offset: 0x00012C4E
		public   bool vmethod_18()
		{
			return this.bool_1;
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x00014A56 File Offset: 0x00012C56
		public  void vmethod_19(bool bool_3)
		{
			this.bool_1 = bool_3;
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x000E035C File Offset: 0x000DE55C
		public   bool vmethod_20()
		{
			bool result = true;
			for (int i = 0; i < 2; i++)
			{
				if (!this.vmethod_1().vmethod_8(i) || this.vmethod_1().vmethod_1(i, Enum158.const_1) != LocationType.Interior || this.vmethod_1().vmethod_1(i, Enum158.const_2) != LocationType.Interior)
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x00014A5F File Offset: 0x00012C5F
		public   bool vmethod_21()
		{
			return this.bool_2;
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x00014A67 File Offset: 0x00012C67
		public  void vmethod_22(bool bool_3)
		{
			this.bool_2 = bool_3;
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x000E03B0 File Offset: 0x000DE5B0
		public  Class2205 vmethod_23()
		{
			return this.class2205_1;
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x00014A70 File Offset: 0x00012C70
		public  void vmethod_24(Class2205 class2205_2)
		{
			this.class2205_1 = class2205_2;
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x000E03C8 File Offset: 0x000DE5C8
		public  Class2193 vmethod_25()
		{
			return this.class2193_0;
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x00014A79 File Offset: 0x00012C79
		public  void vmethod_26(Class2193 class2193_3)
		{
			this.class2193_0 = class2193_3;
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x000E03E0 File Offset: 0x000DE5E0
		public  Class2193 vmethod_27()
		{
			return this.class2193_1;
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x00014A82 File Offset: 0x00012C82
		public  void vmethod_28(Class2193 class2193_3)
		{
			this.class2193_1 = class2193_3;
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x000E03F8 File Offset: 0x000DE5F8
		public  Class2193 vmethod_29()
		{
			return this.class2193_2;
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00014A8B File Offset: 0x00012C8B
		public  void vmethod_30(Class2193 class2193_3)
		{
			this.class2193_2 = class2193_3;
		}

		// Token: 0x04001133 RID: 4403
		private readonly int[] int_1 = new int[]
		{
			0,
			-999,
			-999
		};

		// Token: 0x04001134 RID: 4404
		private Class2205 class2205_0;

		// Token: 0x04001135 RID: 4405
		private bool bool_0;

		// Token: 0x04001136 RID: 4406
		private bool bool_1;

		// Token: 0x04001137 RID: 4407
		private bool bool_2 = false;

		// Token: 0x04001138 RID: 4408
		private Class2205 class2205_1;

		// Token: 0x04001139 RID: 4409
		private Class2193 class2193_0;

		// Token: 0x0400113A RID: 4410
		private Class2193 class2193_1;

		// Token: 0x0400113B RID: 4411
		private Class2193 class2193_2;
	}
}

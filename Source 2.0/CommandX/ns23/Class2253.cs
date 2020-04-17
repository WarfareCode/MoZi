using System;

namespace ns23
{
	// Token: 0x0200065D RID: 1629
	public sealed class Class2253
	{
		// Token: 0x06002990 RID: 10640 RVA: 0x00016C98 File Offset: 0x00014E98
		public Class2253(Class2252 class2252_1)
		{
			this.method_0(class2252_1);
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x000FD870 File Offset: 0x000FBA70
		public  int vmethod_0()
		{
			return this.int_0;
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x000FD888 File Offset: 0x000FBA88
		public  Class2252 vmethod_1()
		{
			return this.class2252_0;
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x000FD8A0 File Offset: 0x000FBAA0
		public static int smethod_0(Class2252 class2252_1)
		{
			double d = class2252_1.vmethod_4();
			return DoubleBits.GetExponent(d) + 1;
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x000FD8C0 File Offset: 0x000FBAC0
		public void method_0(Class2252 class2252_1)
		{
			this.int_0 = Class2253.smethod_0(class2252_1);
			this.class2252_0 = new Class2252();
			this.method_1(this.int_0, class2252_1);
			while (!this.class2252_0.vmethod_8(class2252_1))
			{
				this.int_0++;
				this.method_1(this.int_0, class2252_1);
			}
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000FD920 File Offset: 0x000FBB20
		private void method_1(int int_1, Class2252 class2252_1)
		{
			double num = DoubleBits.PowerOf2(int_1);
			this.double_0 = Math.Floor(class2252_1.vmethod_0() / num) * num;
			this.class2252_0.method_0(this.double_0, this.double_0 + num);
		}

		// Token: 0x040013F0 RID: 5104
		private Class2252 class2252_0;

		// Token: 0x040013F1 RID: 5105
		private int int_0;

		// Token: 0x040013F2 RID: 5106
		private double double_0;
	}
}

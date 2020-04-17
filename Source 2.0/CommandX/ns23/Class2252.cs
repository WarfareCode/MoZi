using System;

namespace ns23
{
	// Token: 0x0200065C RID: 1628
	public sealed class Class2252
	{
		// Token: 0x06002982 RID: 10626 RVA: 0x00016B76 File Offset: 0x00014D76
		public Class2252()
		{
			this.double_1 = 0.0;
			this.double_0 = 0.0;
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x00016B9C File Offset: 0x00014D9C
		public Class2252(double double_2, double double_3)
		{
			this.method_0(double_2, double_3);
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x00016BAC File Offset: 0x00014DAC
		public Class2252(Class2252 class2252_0)
		{
			this.method_0(class2252_0.vmethod_0(), class2252_0.vmethod_2());
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x000FD824 File Offset: 0x000FBA24
		public  double vmethod_0()
		{
			return this.double_1;
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x00016BC6 File Offset: 0x00014DC6
		public  void vmethod_1(double double_2)
		{
			this.double_1 = double_2;
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x000FD83C File Offset: 0x000FBA3C
		public  double vmethod_2()
		{
			return this.double_0;
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x00016BCF File Offset: 0x00014DCF
		public  void vmethod_3(double double_2)
		{
			this.double_0 = double_2;
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x000FD854 File Offset: 0x000FBA54
		public  double vmethod_4()
		{
			return this.vmethod_2() - this.vmethod_0();
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x00016BD8 File Offset: 0x00014DD8
		public void method_0(double double_2, double double_3)
		{
			this.vmethod_1(double_2);
			this.vmethod_3(double_3);
			if (double_2 > double_3)
			{
				this.vmethod_1(double_3);
				this.vmethod_3(double_2);
			}
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x00016BFC File Offset: 0x00014DFC
		public  void vmethod_5(Class2252 class2252_0)
		{
			if (class2252_0.vmethod_2() > this.vmethod_2())
			{
				this.vmethod_3(class2252_0.vmethod_2());
			}
			if (class2252_0.vmethod_0() < this.vmethod_0())
			{
				this.vmethod_1(class2252_0.vmethod_0());
			}
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00016C3C File Offset: 0x00014E3C
		public   bool vmethod_6(Class2252 class2252_0)
		{
			return this.vmethod_7(class2252_0.vmethod_0(), class2252_0.vmethod_2());
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00016C50 File Offset: 0x00014E50
		public   bool vmethod_7(double double_2, double double_3)
		{
			return this.vmethod_0() <= double_3 && this.vmethod_2() >= double_2;
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x00016C6A File Offset: 0x00014E6A
		public   bool vmethod_8(Class2252 class2252_0)
		{
			return this.vmethod_9(class2252_0.vmethod_0(), class2252_0.vmethod_2());
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x00016C7E File Offset: 0x00014E7E
		public   bool vmethod_9(double double_2, double double_3)
		{
			return double_2 >= this.vmethod_0() && double_3 <= this.vmethod_2();
		}

		// Token: 0x040013EE RID: 5102
		private double double_0;

		// Token: 0x040013EF RID: 5103
		private double double_1;
	}
}

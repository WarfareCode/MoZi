using System;
using System.Runtime.CompilerServices;

namespace ns31
{
	// Token: 0x0200047A RID: 1146
	public sealed class Class2420
	{
		// Token: 0x06001DAE RID: 7598 RVA: 0x0001227B File Offset: 0x0001047B
		public Class2420()
		{
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000122A1 File Offset: 0x000104A1
		public Class2420(double double_4, double double_5, double double_6)
		{
			this.method_1(double_4);
			this.method_3(double_5);
			this.method_5(double_6);
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x000BFDBC File Offset: 0x000BDFBC
		[CompilerGenerated]
		public double method_0()
		{
			return this.double_0;
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x000122DC File Offset: 0x000104DC
		[CompilerGenerated]
		public void method_1(double double_4)
		{
			this.double_0 = double_4;
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x000BFDD4 File Offset: 0x000BDFD4
		[CompilerGenerated]
		public double method_2()
		{
			return this.double_1;
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x000122E5 File Offset: 0x000104E5
		[CompilerGenerated]
		public void method_3(double double_4)
		{
			this.double_1 = double_4;
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x000BFDEC File Offset: 0x000BDFEC
		[CompilerGenerated]
		public double method_4()
		{
			return this.double_2;
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x000122EE File Offset: 0x000104EE
		[CompilerGenerated]
		public void method_5(double double_4)
		{
			this.double_2 = double_4;
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x000BFE04 File Offset: 0x000BE004
		[CompilerGenerated]
		public double method_6()
		{
			return this.double_3;
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x000122F7 File Offset: 0x000104F7
		[CompilerGenerated]
		public void method_7(double double_4)
		{
			this.double_3 = double_4;
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00012300 File Offset: 0x00010500
		public void method_8(double double_4)
		{
			this.method_1(this.method_0() * double_4);
			this.method_3(this.method_2() * double_4);
			this.method_5(this.method_4() * double_4);
			this.method_7(this.method_6() * Math.Abs(double_4));
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x000BFE1C File Offset: 0x000BE01C
		public double method_9()
		{
			return Math.Sqrt(this.method_0() * this.method_0() + this.method_2() * this.method_2() + this.method_4() * this.method_4());
		}

		// Token: 0x04000D48 RID: 3400
		[CompilerGenerated]
		private double double_0;

		// Token: 0x04000D49 RID: 3401
		[CompilerGenerated]
		private double double_1;

		// Token: 0x04000D4A RID: 3402
		[CompilerGenerated]
		private double double_2 = 0.0;

		// Token: 0x04000D4B RID: 3403
		[CompilerGenerated]
		private double double_3 = 0.0;
	}
}

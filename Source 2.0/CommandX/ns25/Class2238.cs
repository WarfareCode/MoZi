using System;
using DotSpatial.Topology;

namespace ns25
{
	// Token: 0x02000634 RID: 1588
	public sealed class Class2238
	{
		// Token: 0x06002851 RID: 10321 RVA: 0x000F33B4 File Offset: 0x000F15B4
		public Class2238()
		{
			this.double_1 = 0.0;
			this.double_2 = 0.0;
			this.double_0 = 1.0;
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x0001656E File Offset: 0x0001476E
		public Class2238(Coordinate coordinate_0)
		{
			this.double_1 = coordinate_0.X;
			this.double_2 = coordinate_0.Y;
			this.double_0 = 1.0;
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x000F3404 File Offset: 0x000F1604
		public Class2238(Class2238 class2238_0, Class2238 class2238_1)
		{
			this.double_1 = class2238_0.double_2 * class2238_1.double_0 - class2238_1.double_2 * class2238_0.double_0;
			this.double_2 = class2238_1.double_1 * class2238_0.double_0 - class2238_0.double_1 * class2238_1.double_0;
			this.double_0 = class2238_0.double_1 * class2238_1.double_2 - class2238_1.double_1 * class2238_0.double_2;
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x000F348C File Offset: 0x000F168C
		public  Coordinate vmethod_0()
		{
			return new Coordinate(this.vmethod_1(), this.vmethod_2());
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x000F34AC File Offset: 0x000F16AC
		public static Coordinate smethod_0(Coordinate coordinate_0, Coordinate coordinate_1, Coordinate coordinate_2, Coordinate coordinate_3)
		{
			Class2238 class2238_ = new Class2238(new Class2238(coordinate_0), new Class2238(coordinate_1));
			Class2238 class2238_2 = new Class2238(new Class2238(coordinate_2), new Class2238(coordinate_3));
			Class2238 @class = new Class2238(class2238_, class2238_2);
			return @class.vmethod_0();
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x000F34F0 File Offset: 0x000F16F0
		public  double vmethod_1()
		{
			double num = this.double_1 / this.double_0;
			if (double.IsNaN(num) || double.IsInfinity(num))
			{
				throw new Exception22();
			}
			return num;
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x000F352C File Offset: 0x000F172C
		public  double vmethod_2()
		{
			double num = this.double_2 / this.double_0;
			if (double.IsNaN(num) || double.IsInfinity(num))
			{
				throw new Exception22();
			}
			return num;
		}

		// Token: 0x0400134A RID: 4938
		private double double_0;

		// Token: 0x0400134B RID: 4939
		private double double_1;

		// Token: 0x0400134C RID: 4940
		private double double_2 = 0.0;
	}
}

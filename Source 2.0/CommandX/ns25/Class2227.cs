using System;
using DotSpatial.Topology;

namespace ns25
{
	// Token: 0x02000616 RID: 1558
	public sealed class Class2227
	{
		// Token: 0x060027AC RID: 10156 RVA: 0x0001612A File Offset: 0x0001432A
		public Class2227(Coordinate coordinate_3, Coordinate coordinate_4, Coordinate coordinate_5)
		{
			this.coordinate_0 = coordinate_3;
			this.coordinate_1 = coordinate_4;
			this.coordinate_2 = coordinate_5;
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x000F1100 File Offset: 0x000EF300
		public  Coordinate vmethod_0()
		{
			return this.coordinate_2;
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x000F1118 File Offset: 0x000EF318
		public  Coordinate vmethod_1()
		{
			return this.coordinate_1;
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x000F1130 File Offset: 0x000EF330
		public  Coordinate vmethod_2()
		{
			return this.coordinate_0;
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x000F1148 File Offset: 0x000EF348
		public  Coordinate vmethod_3()
		{
			double num = this.vmethod_1().Distance(this.vmethod_0());
			double num2 = this.vmethod_2().Distance(this.vmethod_0());
			double num3 = this.vmethod_2().Distance(this.vmethod_1());
			double num4 = num + num2 + num3;
			double double_ = (num * this.vmethod_2().X + num2 * this.vmethod_1().X + num3 * this.vmethod_0().X) / num4;
			double double_2 = (num * this.vmethod_2().Y + num2 * this.vmethod_1().Y + num3 * this.vmethod_0().Y) / num4;
			return new Coordinate(double_, double_2);
		}

		// Token: 0x04001312 RID: 4882
		private Coordinate coordinate_0;

		// Token: 0x04001313 RID: 4883
		private Coordinate coordinate_1;

		// Token: 0x04001314 RID: 4884
		private Coordinate coordinate_2;
	}
}

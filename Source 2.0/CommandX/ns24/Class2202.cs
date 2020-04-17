using System;
using DotSpatial.Topology;

namespace ns24
{
	// Token: 0x02000569 RID: 1385
	public sealed class Class2202 : IComparable
	{
		// Token: 0x060023D7 RID: 9175 RVA: 0x00014BDE File Offset: 0x00012DDE
		public Class2202(Coordinate coordinate_1, int int_1, double double_1)
		{
			this.coordinate_0 = new Coordinate(coordinate_1);
			this.int_0 = int_1;
			this.double_0 = double_1;
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x000E0FDC File Offset: 0x000DF1DC
		public  Coordinate vmethod_0()
		{
			return this.coordinate_0;
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x000E0FF4 File Offset: 0x000DF1F4
		public  int vmethod_1()
		{
			return this.int_0;
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x000E100C File Offset: 0x000DF20C
		public  double vmethod_2()
		{
			return this.double_0;
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x000E1024 File Offset: 0x000DF224
		public  int CompareTo(object target)
		{
			Class2202 @class = (Class2202)target;
			return this.vmethod_3(@class.vmethod_1(), @class.vmethod_2());
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x000E104C File Offset: 0x000DF24C
		public  int vmethod_3(int int_1, double double_1)
		{
			int result;
			if (this.vmethod_1() < int_1)
			{
				result = -1;
			}
			else if (this.vmethod_1() > int_1)
			{
				result = 1;
			}
			else if (this.vmethod_2() < double_1)
			{
				result = -1;
			}
			else if (this.vmethod_2() <= double_1)
			{
				result = 0;
			}
			else
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x0400114E RID: 4430
		private Coordinate coordinate_0;

		// Token: 0x0400114F RID: 4431
		private double double_0;

		// Token: 0x04001150 RID: 4432
		private int int_0;
	}
}

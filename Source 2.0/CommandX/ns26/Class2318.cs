using System;
using DotSpatial.Topology;
using ns27;

namespace ns26
{
	// Token: 0x020007E7 RID: 2023
	public sealed class Class2318 : Class2313
	{
		// Token: 0x06003205 RID: 12805 RVA: 0x0001AF01 File Offset: 0x00019101
		public Class2318(Coordinate coordinate_1) : this(coordinate_1, new Class2334())
		{
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x0001AF0F File Offset: 0x0001910F
		public Class2318(Coordinate coordinate_1, Class2334 class2334_1)
		{
			this.coordinate_0 = coordinate_1;
			this.class2334_0 = class2334_1;
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x0010D224 File Offset: 0x0010B424
		public  Coordinate vmethod_0()
		{
			return this.coordinate_0;
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x0010D23C File Offset: 0x0010B43C
		public  int vmethod_1()
		{
			return this.class2334_0.vmethod_0();
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x0001AF25 File Offset: 0x00019125
		public  void vmethod_2(Class2314 class2314_0)
		{
			this.class2334_0.vmethod_1(class2314_0);
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x0010D258 File Offset: 0x0010B458
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"NODE: ",
				this.coordinate_0.ToString(),
				": ",
				this.vmethod_1()
			});
		}

		// Token: 0x04001733 RID: 5939
		protected readonly Class2334 class2334_0;

		// Token: 0x04001734 RID: 5940
		private Coordinate coordinate_0;
	}
}

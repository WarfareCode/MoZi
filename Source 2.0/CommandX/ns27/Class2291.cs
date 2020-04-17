using System;
using DotSpatial.Topology;
using DotSpatial.Topology.Noding;

namespace ns27
{
	// Token: 0x020006EE RID: 1774
	public sealed class Class2291 : IComparable
	{
		// Token: 0x06002C5E RID: 11358 RVA: 0x0001809D File Offset: 0x0001629D
		public Class2291(Class2295 class2295_0, Coordinate coordinate_1, int int_1, OctantDirection octantDirection_1)
		{
			this.coordinate_0 = new Coordinate(coordinate_1);
			this.int_0 = int_1;
			this.octantDirection_0 = octantDirection_1;
			this.bool_0 = !coordinate_1.Equals2D(class2295_0.method_5(int_1));
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x000180DD File Offset: 0x000162DD
		public bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x00101FF4 File Offset: 0x001001F4
		public int CompareTo(object target)
		{
			Class2291 @class = (Class2291)target;
			int result;
			if (this.int_0 < @class.int_0)
			{
				result = -1;
			}
			else if (this.int_0 > @class.int_0)
			{
				result = 1;
			}
			else if (this.coordinate_0.Equals2D(@class.coordinate_0))
			{
				result = 0;
			}
			else
			{
				result = Class2294.smethod_0(this.octantDirection_0, this.coordinate_0, @class.coordinate_0);
			}
			return result;
		}

		// Token: 0x040014FA RID: 5370
		public readonly Coordinate coordinate_0;

		// Token: 0x040014FB RID: 5371
		public readonly int int_0;

		// Token: 0x040014FC RID: 5372
		private readonly bool bool_0;

		// Token: 0x040014FD RID: 5373
		private readonly OctantDirection octantDirection_0 = OctantDirection.Null;
	}
}

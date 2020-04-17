using System;
using GeoAPI.Geometries;
using ns13;

namespace ns12
{
	// Token: 0x0200035D RID: 861
	public sealed class Class572 : Class571, IComparable
	{
		// Token: 0x06001460 RID: 5216 RVA: 0x00088888 File Offset: 0x00086A88
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x000888A0 File Offset: 0x00086AA0
		public int CompareTo(object target)
		{
			Class572 class572_ = (Class572)target;
			return this.method_1(class572_);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x000888C0 File Offset: 0x00086AC0
		public int method_1(Class572 class572_0)
		{
			if (this.int_0 <= class572_0.method_0())
			{
			}
			if (this.int_0 >= class572_0.method_0())
			{
			}
			return Class628.smethod_4(class572_0.icoordinate_0, class572_0.icoordinate_1, this.icoordinate_1);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0008890C File Offset: 0x00086B0C
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"DirectedEdge: ",
				this.icoordinate_0,
				" - ",
				this.icoordinate_1,
				" ",
				this.int_0,
				":",
				this.double_0
			});
		}

		// Token: 0x04000873 RID: 2163
		protected ICoordinate icoordinate_0;

		// Token: 0x04000874 RID: 2164
		protected ICoordinate icoordinate_1;

		// Token: 0x04000875 RID: 2165
		protected int int_0;

		// Token: 0x04000876 RID: 2166
		protected double double_0;
	}
}

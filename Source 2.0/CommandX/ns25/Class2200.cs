using System;
using DotSpatial.Topology;
using ns16;
using ns24;

namespace ns25
{
	// Token: 0x020005B7 RID: 1463
	public class Class2200 : Class2198
	{
		// Token: 0x06002583 RID: 9603 RVA: 0x000155A8 File Offset: 0x000137A8
		public Class2200(Coordinate coordinate_1, Class2195 class2195_1)
		{
			this.coordinate_0 = coordinate_1;
			this.class2195_0 = class2195_1;
			base.vmethod_1(new Class2217(0, LocationType.Null));
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x000E8924 File Offset: 0x000E6B24
		public override Coordinate vmethod_5()
		{
			return this.coordinate_0;
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x000E893C File Offset: 0x000E6B3C
		public virtual Class2195 vmethod_6()
		{
			return this.class2195_0;
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x000155CB File Offset: 0x000137CB
		public  void vmethod_7(Class2192 class2192_0)
		{
			this.class2195_0.vmethod_3(class2192_0);
			class2192_0.vmethod_8(this);
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x000155E0 File Offset: 0x000137E0
		public  void vmethod_8(int int_0, LocationType enum157_0)
		{
			if (this.vmethod_0() == null)
			{
				this.vmethod_1(new Class2217(int_0, enum157_0));
			}
			else
			{
				this.vmethod_0().vmethod_4(int_0, enum157_0);
			}
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x000E8954 File Offset: 0x000E6B54
		public  void vmethod_9(int int_0)
		{
			LocationType enum157_;
			if (this.vmethod_0() != null)
			{
				switch (this.vmethod_0().vmethod_2(int_0))
				{
				case LocationType.Interior:
					enum157_ = LocationType.Boundary;
					goto IL_32;
				case LocationType.Boundary:
					enum157_ = LocationType.Interior;
					goto IL_32;
				}
			}
			enum157_ = LocationType.Boundary;
			IL_32:
			base.vmethod_0().vmethod_4(int_0, enum157_);
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x000E89A0 File Offset: 0x000E6BA0
		public override string ToString()
		{
			return this.coordinate_0 + " " + this.class2195_0;
		}

		// Token: 0x04001207 RID: 4615
		private Coordinate coordinate_0;

		// Token: 0x04001208 RID: 4616
		private Class2195 class2195_0;
	}
}

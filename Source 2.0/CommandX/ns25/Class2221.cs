using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;

namespace ns25
{
	// Token: 0x020005B9 RID: 1465
	public sealed class Class2221
	{
		// Token: 0x0600258C RID: 9612 RVA: 0x0001560C File Offset: 0x0001380C
		public Class2221(Class2218 class2218_1)
		{
			this.class2218_0 = class2218_1;
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x000E89E0 File Offset: 0x000E6BE0
		public  Class2200 vmethod_0(Coordinate coordinate_0)
		{
			Class2200 @class = (Class2200)this.idictionary_0[coordinate_0];
			if (@class == null)
			{
				@class = this.class2218_0.vmethod_0(coordinate_0);
				this.idictionary_0.Add(coordinate_0, @class);
			}
			return @class;
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x000E8A28 File Offset: 0x000E6C28
		public  void vmethod_1(Class2192 class2192_0)
		{
			Coordinate coordinate_ = class2192_0.vmethod_3();
			Class2200 @class = this.vmethod_0(coordinate_);
			@class.vmethod_7(class2192_0);
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x000E8A4C File Offset: 0x000E6C4C
		public  Class2200 vmethod_2(Coordinate coordinate_0)
		{
			return (Class2200)this.idictionary_0[coordinate_0];
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x000E8A6C File Offset: 0x000E6C6C
		public  IEnumerator vmethod_3()
		{
			return this.idictionary_0.Values.GetEnumerator();
		}

		// Token: 0x04001209 RID: 4617
		private readonly Class2218 class2218_0;

		// Token: 0x0400120A RID: 4618
		private readonly IDictionary idictionary_0 = new SortedList();
	}
}

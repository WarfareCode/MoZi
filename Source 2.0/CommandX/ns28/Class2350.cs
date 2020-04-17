using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns24;

namespace ns28
{
	// Token: 0x020007FE RID: 2046
	public sealed class Class2350 : ICoordinateFilter
	{
		// Token: 0x06003247 RID: 12871 RVA: 0x0010DBAC File Offset: 0x0010BDAC
		public  Coordinate[] vmethod_0()
		{
			return (Coordinate[])this.arrayList_0.ToArray(typeof(Coordinate));
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x0001B0D5 File Offset: 0x000192D5
		public  void Filter(Coordinate coordinate_0)
		{
			if (!this.iset_0.Contains(coordinate_0))
			{
				this.arrayList_0.Add(coordinate_0);
				this.iset_0.Add(coordinate_0);
			}
		}

		// Token: 0x04001755 RID: 5973
		private readonly ArrayList arrayList_0 = new ArrayList();

		// Token: 0x04001756 RID: 5974
		private readonly ISet<Coordinate> iset_0 = new SortedSet<Coordinate>();
	}
}

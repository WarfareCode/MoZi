using System;
using System.Collections.Generic;
using DotSpatial.Topology;

namespace ns24
{
	// Token: 0x02000526 RID: 1318
	public interface IBasicGeometry : ICloneable
	{
		// Token: 0x060021E7 RID: 8679
		IList<Coordinate> GetCoordinates();

		// Token: 0x060021E8 RID: 8680
		void SetCoordinates(IList<Coordinate> ilist_0);

		// Token: 0x060021E9 RID: 8681
		int GetNumGeometries();

		// Token: 0x060021EA RID: 8682
		int GetNumPoints();

		// Token: 0x060021EB RID: 8683
		string GetGeometryType();

		// Token: 0x060021EC RID: 8684
		IBasicGeometry GetBasicGeometryN(int int_0);
	}
}

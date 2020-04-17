using System;
using ns14;

namespace GeoAPI.Geometries
{
	// Token: 0x02000391 RID: 913
	public interface ICoordinateSequence : ICloneable
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06001609 RID: 5641
		int Count
		{
			get;
		}

		// Token: 0x0600160A RID: 5642
		ICoordinate imethod_0(int int_0);

		// Token: 0x0600160B RID: 5643
		double imethod_1(int int_0, Enum142 enum142_0);

		// Token: 0x0600160C RID: 5644
		void imethod_2(int int_0, Enum142 enum142_0, double double_0);

		// Token: 0x0600160D RID: 5645
		ICoordinate[] imethod_3();
	}
}

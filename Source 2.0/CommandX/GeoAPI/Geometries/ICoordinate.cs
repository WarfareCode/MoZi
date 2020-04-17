using System;

namespace GeoAPI.Geometries
{
	// Token: 0x02000382 RID: 898
	public interface ICoordinate : IComparable<ICoordinate>, IEquatable<ICoordinate>, IComparable, ICloneable
	{
		// Token: 0x06001590 RID: 5520
		double imethod_0();

		// Token: 0x06001591 RID: 5521
		void imethod_1(double double_0);

		// Token: 0x06001592 RID: 5522
		double imethod_2();

		// Token: 0x06001593 RID: 5523
		void imethod_3(double double_0);

		// Token: 0x06001594 RID: 5524
		double imethod_4();

		// Token: 0x06001595 RID: 5525
		void imethod_5(double double_0);

		// Token: 0x06001596 RID: 5526
		void imethod_6(ICoordinate icoordinate_0);

		// Token: 0x06001597 RID: 5527
		double imethod_7(ICoordinate icoordinate_0);

		// Token: 0x06001598 RID: 5528
		bool imethod_8(ICoordinate icoordinate_0);
	}
}

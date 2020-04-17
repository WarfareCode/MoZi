using System;

namespace GeoAPI.Geometries
{
	// Token: 0x0200039B RID: 923
	public interface IGeometry : IComparable<IGeometry>, IEquatable<IGeometry>, IComparable, ICloneable
	{
		// Token: 0x06001660 RID: 5728
		IGeometryFactory imethod_0();

		// Token: 0x06001661 RID: 5729
		IPrecisionModel imethod_1();

		// Token: 0x06001662 RID: 5730
		int imethod_2();

		// Token: 0x06001663 RID: 5731
		int imethod_3();

		// Token: 0x06001664 RID: 5732
		Dimensions imethod_4();

		// Token: 0x06001665 RID: 5733
		ICoordinate imethod_5();

		// Token: 0x06001666 RID: 5734
		ICoordinate[] imethod_6();

		// Token: 0x06001667 RID: 5735
		Dimensions imethod_7();

		// Token: 0x06001668 RID: 5736
		IEnvelope imethod_8();

		// Token: 0x06001669 RID: 5737
		IGeometry imethod_9(int int_0);

		// Token: 0x0600166A RID: 5738
		bool imethod_10();
	}
}

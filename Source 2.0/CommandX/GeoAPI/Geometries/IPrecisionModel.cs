using System;

namespace GeoAPI.Geometries
{
	// Token: 0x0200038F RID: 911
	public interface IPrecisionModel : IComparable<IPrecisionModel>, IEquatable<IPrecisionModel>, IComparable
	{
		// Token: 0x060015F7 RID: 5623
		PrecisionModels imethod_0();

		// Token: 0x060015F8 RID: 5624
		int imethod_1();

		// Token: 0x060015F9 RID: 5625
		double imethod_2();

		// Token: 0x060015FA RID: 5626
		void imethod_3(ICoordinate icoordinate_0);
	}
}

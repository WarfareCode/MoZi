using System;

namespace GeoAPI.Geometries
{
	// Token: 0x02000372 RID: 882
	public interface IEnvelope : IComparable<IEnvelope>, IEquatable<IEnvelope>, IComparable, ICloneable
	{
		// Token: 0x0600150F RID: 5391
		double imethod_0();

		// Token: 0x06001510 RID: 5392
		double imethod_1();

		// Token: 0x06001511 RID: 5393
		double imethod_2();

		// Token: 0x06001512 RID: 5394
		double imethod_3();

		// Token: 0x06001513 RID: 5395
		double imethod_4();

		// Token: 0x06001514 RID: 5396
		bool imethod_5(ICoordinate icoordinate_0);

		// Token: 0x06001515 RID: 5397
		bool imethod_6(IEnvelope ienvelope_0);

		// Token: 0x06001516 RID: 5398
		void imethod_7(IEnvelope ienvelope_0);

		// Token: 0x06001517 RID: 5399
		void imethod_8(ICoordinate icoordinate_0, ICoordinate icoordinate_1);

		// Token: 0x06001518 RID: 5400
		bool imethod_9(IEnvelope ienvelope_0);

		// Token: 0x06001519 RID: 5401
		bool imethod_10();
	}
}

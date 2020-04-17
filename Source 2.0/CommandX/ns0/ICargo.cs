using System;

namespace ns0
{
	// Token: 0x020009CC RID: 2508
	internal interface ICargo
	{
		// Token: 0x060043E4 RID: 17380
		float GetCargoCrew();

		// Token: 0x060043E5 RID: 17381
		float GetCargoArea();

		// Token: 0x060043E6 RID: 17382
		_CargoType GetCargoType();

		// Token: 0x060043E7 RID: 17383
		float GetCargoMass();
	}
}

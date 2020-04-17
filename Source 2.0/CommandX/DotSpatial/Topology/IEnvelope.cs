using System;
using System.ComponentModel;
using ns24;

namespace DotSpatial.Topology
{
	// Token: 0x020004F1 RID: 1265
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public interface IEnvelope : ICloneable, Interface29
	{
		// Token: 0x060020FD RID: 8445
		void Init(Coordinate coordinate_0, Coordinate coordinate_1);

		// Token: 0x060020FE RID: 8446
		Coordinate GetMinimum();

		// Token: 0x060020FF RID: 8447
		Coordinate GetMaximum();

		// Token: 0x06002100 RID: 8448
		int GetNumOrdinates();

		// Token: 0x06002101 RID: 8449
		bool IsNull();
	}
}

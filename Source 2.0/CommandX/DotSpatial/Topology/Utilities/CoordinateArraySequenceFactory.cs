using System;

namespace DotSpatial.Topology.Utilities
{
	// Token: 0x020004E7 RID: 1255
	[Serializable]
	public sealed class CoordinateArraySequenceFactory : ICoordinateSequenceFactory
	{
		// Token: 0x060020AF RID: 8367 RVA: 0x00004A21 File Offset: 0x00002C21
		private CoordinateArraySequenceFactory()
		{
		}

		// Token: 0x04000FD4 RID: 4052
		public static readonly CoordinateArraySequenceFactory Instance = new CoordinateArraySequenceFactory();
	}
}

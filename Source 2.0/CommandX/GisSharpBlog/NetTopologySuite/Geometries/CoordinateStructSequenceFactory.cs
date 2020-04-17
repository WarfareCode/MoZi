using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000453 RID: 1107
	[Serializable]
	public sealed class CoordinateStructSequenceFactory : ICoordinateSequenceFactory
	{
		// Token: 0x06001C74 RID: 7284 RVA: 0x00004A21 File Offset: 0x00002C21
		private CoordinateStructSequenceFactory()
		{
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x000B5120 File Offset: 0x000B3320
		public ICoordinateSequence imethod_0(ICoordinate[] icoordinate_0)
		{
			return new CoordinateStructSequence(icoordinate_0);
		}

		// Token: 0x04000C67 RID: 3175
		private static readonly CoordinateStructSequenceFactory instance = new CoordinateStructSequenceFactory();
	}
}

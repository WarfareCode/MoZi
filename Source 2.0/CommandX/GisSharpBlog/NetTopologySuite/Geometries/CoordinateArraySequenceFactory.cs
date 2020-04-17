using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000435 RID: 1077
	[Serializable]
	public sealed class CoordinateArraySequenceFactory : ICoordinateSequenceFactory
	{
		// Token: 0x06001B93 RID: 7059 RVA: 0x00004A21 File Offset: 0x00002C21
		private CoordinateArraySequenceFactory()
		{
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x000B16B0 File Offset: 0x000AF8B0
		public static CoordinateArraySequenceFactory smethod_0()
		{
			return CoordinateArraySequenceFactory.instance;
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x000B16C4 File Offset: 0x000AF8C4
		public ICoordinateSequence imethod_0(ICoordinate[] icoordinate_0)
		{
			return new CoordinateArraySequence(icoordinate_0);
		}

		// Token: 0x04000BD0 RID: 3024
		private static readonly CoordinateArraySequenceFactory instance = new CoordinateArraySequenceFactory();
	}
}

using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000467 RID: 1127
	[Obsolete("No longer used")]
	[Serializable]
	public sealed class DefaultCoordinateSequenceFactory : ICoordinateSequenceFactory
	{
		// Token: 0x06001D08 RID: 7432 RVA: 0x00004A21 File Offset: 0x00002C21
		private DefaultCoordinateSequenceFactory()
		{
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x000B726C File Offset: 0x000B546C
		public ICoordinateSequence imethod_0(ICoordinate[] icoordinate_0)
		{
			return new DefaultCoordinateSequence(icoordinate_0);
		}

		// Token: 0x04000CAE RID: 3246
		private static readonly DefaultCoordinateSequenceFactory instance = new DefaultCoordinateSequenceFactory();
	}
}

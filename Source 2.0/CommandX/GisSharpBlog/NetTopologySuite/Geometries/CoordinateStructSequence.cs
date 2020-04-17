using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x0200047E RID: 1150
	[Serializable]
	public sealed class CoordinateStructSequence : CoordinateArraySequence
	{
		// Token: 0x06001DC1 RID: 7617 RVA: 0x00012356 File Offset: 0x00010556
		public CoordinateStructSequence(ICoordinate[] icoordinate_0) : base(icoordinate_0)
		{
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x000C0324 File Offset: 0x000BE524
		public  object Clone()
		{
			ICoordinate[] icoordinate_ = base.method_0();
			return new CoordinateStructSequence(icoordinate_);
		}
	}
}

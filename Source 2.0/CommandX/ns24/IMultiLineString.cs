using System;
using System.Collections;
using DotSpatial.Topology;

namespace ns24
{
	// Token: 0x0200054C RID: 1356
	public interface IMultiLineString : IEnumerable, IComparable, ICloneable, IBasicGeometry, IGeometry, IGeometryCollection
	{
		// Token: 0x1700027F RID: 639
		ILineString this[int index]
		{
			get;
		}
	}
}

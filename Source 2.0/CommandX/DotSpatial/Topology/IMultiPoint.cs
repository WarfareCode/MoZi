using System;
using System.Collections;
using ns24;

namespace DotSpatial.Topology
{
	// Token: 0x0200054D RID: 1357
	public interface IMultiPoint : IEnumerable, IComparable, ICloneable, IBasicGeometry, IGeometry, IGeometryCollection
	{
		// Token: 0x17000280 RID: 640
		IPoint this[int int_0]
		{
			get;
			set;
		}
	}
}

using System;
using System.Collections;
using ns24;

namespace DotSpatial.Topology
{
	// Token: 0x02000531 RID: 1329
	public interface IGeometryCollection : IEnumerable, IComparable, ICloneable, IBasicGeometry, IGeometry
	{
		// Token: 0x1700026A RID: 618
		IGeometry this[int int_0]
		{
			get;
		}

		// Token: 0x06002239 RID: 8761
		IGeometry[] GetGeometries();
	}
}

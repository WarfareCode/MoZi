using System;
using System.Collections;

namespace GeoAPI.Geometries
{
	// Token: 0x0200039D RID: 925
	public interface IGeometryCollection : IComparable<IGeometry>, IEquatable<IGeometry>, IEnumerable, IComparable, ICloneable, IGeometry
	{
		// Token: 0x170001D8 RID: 472
		IGeometry this[int int_0]
		{
			get;
		}

		// Token: 0x0600168B RID: 5771
		IGeometry[] imethod_11();
	}
}

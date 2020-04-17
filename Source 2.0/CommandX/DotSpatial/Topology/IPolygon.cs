using System;
using ns24;

namespace DotSpatial.Topology
{
	// Token: 0x02000550 RID: 1360
	public interface IPolygon : IComparable, ICloneable, IBasicGeometry, IGeometry, IBasicPolygon
	{
		// Token: 0x0600232A RID: 9002
		ILinearRing GetShell();

		// Token: 0x0600232B RID: 9003
		ILinearRing[] GetHoles();

		// Token: 0x0600232C RID: 9004
		ILineString GetInteriorRingN(int n);
	}
}

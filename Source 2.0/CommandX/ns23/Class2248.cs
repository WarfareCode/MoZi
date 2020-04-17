using System;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns25;

namespace ns23
{
	// Token: 0x0200064C RID: 1612
	public sealed class Class2248 : Interface42
	{
		// Token: 0x0600295C RID: 10588 RVA: 0x00016A3A File Offset: 0x00014C3A
		public  bool imethod_0(Coordinate coordinate_0)
		{
			return CgAlgorithms.IsPointInRing(coordinate_0, this.ilist_0);
		}

		// Token: 0x040013CD RID: 5069
		private readonly IList<Coordinate> ilist_0;
	}
}

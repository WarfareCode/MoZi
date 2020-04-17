using System;
using System.Collections;
using DotSpatial.Topology;

namespace ns23
{
	// Token: 0x0200067E RID: 1662
	public interface ISpatialIndex
	{
		// Token: 0x06002A4F RID: 10831
		void Insert(IEnvelope ienvelope_0, object object_0);

		// Token: 0x06002A50 RID: 10832
		IList Query(IEnvelope ienvelope_0);
	}
}

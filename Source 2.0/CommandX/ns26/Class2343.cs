using System;
using System.Collections;
using DotSpatial.Topology;
using ns23;

namespace ns26
{
	// Token: 0x020007F3 RID: 2035
	public sealed class Class2343 : Interface43
	{
		// Token: 0x0600322D RID: 12845 RVA: 0x0010D7EC File Offset: 0x0010B9EC
		public  void VisitItem(object object_0)
		{
			LineSegment lineSegment = (LineSegment)object_0;
			if (Envelope.Intersects(lineSegment.GetP0(), lineSegment.GetP1(), this.lineSegment_0.GetP0(), this.lineSegment_0.GetP1()))
			{
				this.arrayList_0.Add(object_0);
			}
		}

		// Token: 0x04001749 RID: 5961
		private readonly ArrayList arrayList_0;

		// Token: 0x0400174A RID: 5962
		private readonly LineSegment lineSegment_0;
	}
}

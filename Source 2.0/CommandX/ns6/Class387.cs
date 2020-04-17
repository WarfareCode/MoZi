using System;
using System.Collections;

namespace ns6
{
	// Token: 0x02000C8D RID: 3213
	public sealed class Class387 : IComparer
	{
		// Token: 0x06006A9B RID: 27291 RVA: 0x00393A28 File Offset: 0x00391C28
		public int Compare(object x, object y)
		{
			return string.Compare(((Class386)x).struct67_0.Name, ((Class386)y).struct67_0.Name, true);
		}
	}
}

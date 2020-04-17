using System;
using System.Collections;

namespace ns13
{
	// Token: 0x0200043A RID: 1082
	public sealed class Class645 : IComparer
	{
		// Token: 0x06001BC2 RID: 7106 RVA: 0x000B2388 File Offset: 0x000B0588
		public int Compare(object x, object y)
		{
			return Comparer.Default.Compare(x, y) * -1;
		}
	}
}

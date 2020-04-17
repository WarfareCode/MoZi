using System;
using System.Collections.Generic;

namespace ns11
{
	// Token: 0x020002D6 RID: 726
	public sealed class Class560
	{
		// Token: 0x020002D7 RID: 727
		public sealed class Class561 : IComparer<Struct54>
		{
			// Token: 0x060010F0 RID: 4336 RVA: 0x0007ED80 File Offset: 0x0007CF80
			public int Compare(Struct54 x, Struct54 y)
			{
				int result;
				if (x.int_0 > y.int_0)
				{
					result = 1;
				}
				else if (x.int_0 < y.int_0)
				{
					result = -1;
				}
				else
				{
					result = 0;
				}
				return result;
			}
		}
	}
}

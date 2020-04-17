using System;

namespace ns23
{
	// Token: 0x020006CA RID: 1738
	public sealed class Class2282 : IComparable
	{
		// Token: 0x06002BCE RID: 11214 RVA: 0x00100D28 File Offset: 0x000FEF28
		public  int CompareTo(object target)
		{
			Class2282 @class = (Class2282)target;
			int result;
			if (this.double_0 < @class.double_0)
			{
				result = -1;
			}
			else if (this.double_0 > @class.double_0)
			{
				result = 1;
			}
			else if (this.enum160_0 < @class.enum160_0)
			{
				result = -1;
			}
			else if (this.enum160_0 > @class.enum160_0)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x040014A8 RID: 5288
		private readonly Class2282.Enum160 enum160_0;

		// Token: 0x040014A9 RID: 5289
		private readonly double double_0;

		// Token: 0x020006CB RID: 1739
		public enum Enum160
		{
			// Token: 0x040014AB RID: 5291
			const_0 = 1,
			// Token: 0x040014AC RID: 5292
			const_1
		}
	}
}

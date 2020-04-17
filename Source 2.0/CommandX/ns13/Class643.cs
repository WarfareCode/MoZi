using System;

namespace ns13
{
	// Token: 0x02000432 RID: 1074
	public sealed class Class643 : IComparable
	{
		// Token: 0x06001B8F RID: 7055 RVA: 0x000B15F0 File Offset: 0x000AF7F0
		public int CompareTo(object target)
		{
			Class643 @class = (Class643)target;
			int result;
			if (this.double_0 < @class.double_0)
			{
				result = -1;
			}
			else if (this.double_0 > @class.double_0)
			{
				result = 1;
			}
			else if (this.enum139_0 < @class.enum139_0)
			{
				result = -1;
			}
			else if (this.enum139_0 > @class.enum139_0)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x04000BC8 RID: 3016
		private double double_0;

		// Token: 0x04000BC9 RID: 3017
		private Enum139 enum139_0;
	}
}

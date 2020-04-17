using System;
using GeoAPI.Geometries;
using ns12;

namespace ns14
{
	// Token: 0x02000451 RID: 1105
	public sealed class Class651 : IComparable
	{
		// Token: 0x06001C5F RID: 7263 RVA: 0x000B4F64 File Offset: 0x000B3164
		public int CompareTo(object target)
		{
			Class651 @class = (Class651)target;
			int result;
			if (this.int_0 < @class.int_0)
			{
				result = -1;
			}
			else if (this.int_0 > @class.int_0)
			{
				result = 1;
			}
			else if (this.icoordinate_0.imethod_8(@class.icoordinate_0))
			{
				result = 0;
			}
			else
			{
				result = Class577.smethod_0(this.enum141_0, this.icoordinate_0, @class.icoordinate_0);
			}
			return result;
		}

		// Token: 0x04000C63 RID: 3171
		public readonly ICoordinate icoordinate_0;

		// Token: 0x04000C64 RID: 3172
		public readonly int int_0;

		// Token: 0x04000C65 RID: 3173
		private readonly Enum141 enum141_0;
	}
}

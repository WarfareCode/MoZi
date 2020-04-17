using System;
using System.Collections.Generic;
using DotSpatial.Topology;

namespace ns27
{
	// Token: 0x020006E7 RID: 1767
	public sealed class Class2289 : IComparable
	{
		// Token: 0x06002C42 RID: 11330 RVA: 0x00101948 File Offset: 0x000FFB48
		public int CompareTo(object target)
		{
			Class2289 @class = (Class2289)target;
			return Class2289.smethod_0(this.ilist_0, this.bool_0, @class.ilist_0, @class.bool_0);
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x0010197C File Offset: 0x000FFB7C
		private static int smethod_0(IList<Coordinate> ilist_1, bool bool_1, IList<Coordinate> ilist_2, bool bool_2)
		{
			int num = bool_1 ? 1 : -1;
			int num2 = bool_2 ? 1 : -1;
			int num3 = bool_1 ? ilist_1.Count : -1;
			int num4 = bool_2 ? ilist_2.Count : -1;
			int num5 = bool_1 ? 0 : (ilist_1.Count - 1);
			int num6 = bool_2 ? 0 : (ilist_2.Count - 1);
			int num7;
			while (true)
			{
				num7 = ilist_1[num5].CompareTo(ilist_2[num6]);
				if (num7 != 0)
				{
					break;
				}
				num5 += num;
				num6 += num2;
				bool flag = num5 == num3;
				bool flag2 = num6 == num4;
				if (flag && !flag2)
				{
					goto IL_AA;
				}
				if (!flag && flag2)
				{
					goto IL_AF;
				}
				if (flag)
				{
					goto IL_B4;
				}
			}
			int result = num7;
			return result;
			IL_AA:
			result = -1;
			return result;
			IL_AF:
			result = 1;
			return result;
			IL_B4:
			result = 0;
			return result;
		}

		// Token: 0x040014E8 RID: 5352
		private readonly bool bool_0;

		// Token: 0x040014E9 RID: 5353
		private readonly IList<Coordinate> ilist_0;
	}
}

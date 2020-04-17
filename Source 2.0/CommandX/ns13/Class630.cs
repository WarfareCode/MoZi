using System;
using GeoAPI.Geometries;

namespace ns13
{
	// Token: 0x020003EC RID: 1004
	public sealed class Class630 : IComparable
	{
		// Token: 0x06001902 RID: 6402 RVA: 0x00099844 File Offset: 0x00097A44
		public int CompareTo(object target)
		{
			Class630 @class = (Class630)target;
			return Class630.smethod_0(this.icoordinate_0, this.bool_0, @class.icoordinate_0, @class.bool_0);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00099878 File Offset: 0x00097A78
		private static int smethod_0(ICoordinate[] icoordinate_1, bool bool_1, ICoordinate[] icoordinate_2, bool bool_2)
		{
			int num = bool_1 ? 1 : -1;
			int num2 = bool_2 ? 1 : -1;
			int num3 = bool_1 ? icoordinate_1.Length : -1;
			int num4 = bool_2 ? icoordinate_2.Length : -1;
			int num5 = bool_1 ? 0 : (icoordinate_1.Length - 1);
			int num6 = bool_2 ? 0 : (icoordinate_2.Length - 1);
			int num7;
			while (true)
			{
				num7 = icoordinate_1[num5].CompareTo(icoordinate_2[num6]);
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
					goto IL_A1;
				}
				if (!flag && flag2)
				{
					goto IL_A9;
				}
				if (flag && flag2)
				{
					goto IL_B1;
				}
			}
			int num8 = num7;
			int result = num8;
			return result;
			IL_A1:
			result = -1;
			return result;
			IL_A9:
			result = 1;
			return result;
			IL_B1:
			result = 0;
			return result;
		}

		// Token: 0x04000A42 RID: 2626
		private ICoordinate[] icoordinate_0;

		// Token: 0x04000A43 RID: 2627
		private bool bool_0;
	}
}

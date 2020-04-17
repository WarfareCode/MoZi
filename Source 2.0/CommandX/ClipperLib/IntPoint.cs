using System;

namespace ClipperLib
{
	// Token: 0x02000826 RID: 2086
	public struct IntPoint
	{
		// Token: 0x06003365 RID: 13157 RVA: 0x0001B7F4 File Offset: 0x000199F4
		public IntPoint(long long_2, long long_3)
		{
			this.long_0 = long_2;
			this.long_1 = long_3;
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x0001B804 File Offset: 0x00019A04
		public static bool smethod_0(IntPoint intPoint_0, IntPoint intPoint_1)
		{
			return intPoint_0.long_0 == intPoint_1.long_0 && intPoint_0.long_1 == intPoint_1.long_1;
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x0001B829 File Offset: 0x00019A29
		public static bool smethod_1(IntPoint intPoint_0, IntPoint intPoint_1)
		{
			return intPoint_0.long_0 != intPoint_1.long_0 || intPoint_0.long_1 != intPoint_1.long_1;
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x001199C0 File Offset: 0x00117BC0
		public override bool Equals(object obj)
		{
			bool result;
			if (obj == null)
			{
				result = false;
			}
			else if (obj is IntPoint)
			{
				IntPoint intPoint = (IntPoint)obj;
				result = (this.long_0 == intPoint.long_0 && this.long_1 == intPoint.long_1);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x00119A18 File Offset: 0x00117C18
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x040017D8 RID: 6104
		public long long_0;

		// Token: 0x040017D9 RID: 6105
		public long long_1;
	}
}

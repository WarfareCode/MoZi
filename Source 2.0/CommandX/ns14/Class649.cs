using System;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;

namespace ns14
{
	// Token: 0x0200044A RID: 1098
	public sealed class Class649 : IComparable
	{
		// Token: 0x06001C22 RID: 7202 RVA: 0x000B4674 File Offset: 0x000B2874
		public ICoordinate method_0()
		{
			return this.icoordinate_0;
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x000B468C File Offset: 0x000B288C
		public int method_1()
		{
			return this.int_0;
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x000B46A4 File Offset: 0x000B28A4
		public double method_2()
		{
			return this.double_0;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00011A41 File Offset: 0x0000FC41
		public Class649(ICoordinate icoordinate_1, int int_1, double double_1)
		{
			this.icoordinate_0 = new Coordinate(icoordinate_1);
			this.int_0 = int_1;
			this.double_0 = double_1;
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000B46BC File Offset: 0x000B28BC
		public int CompareTo(object target)
		{
			Class649 @class = (Class649)target;
			return this.method_3(@class.method_1(), @class.method_2());
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x000B46E4 File Offset: 0x000B28E4
		public int method_3(int int_1, double double_1)
		{
			int result;
			if (this.method_1() < int_1)
			{
				result = -1;
			}
			else if (this.method_1() > int_1)
			{
				result = 1;
			}
			else if (this.method_2() < double_1)
			{
				result = -1;
			}
			else if (this.method_2() > double_1)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x04000C4D RID: 3149
		private ICoordinate icoordinate_0;

		// Token: 0x04000C4E RID: 3150
		private int int_0;

		// Token: 0x04000C4F RID: 3151
		private double double_0;
	}
}

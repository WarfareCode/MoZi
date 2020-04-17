using System;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;

namespace ns13
{
	// Token: 0x02000439 RID: 1081
	public sealed class Class644
	{
		// Token: 0x06001BBB RID: 7099 RVA: 0x000B21D4 File Offset: 0x000B03D4
		public static ICoordinate smethod_0(ICoordinate icoordinate_0, ICoordinate icoordinate_1, ICoordinate icoordinate_2, ICoordinate icoordinate_3)
		{
			Class644 class644_ = new Class644(new Class644(icoordinate_0), new Class644(icoordinate_1));
			Class644 class644_2 = new Class644(new Class644(icoordinate_2), new Class644(icoordinate_3));
			Class644 @class = new Class644(class644_, class644_2);
			return @class.method_2();
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x000B2218 File Offset: 0x000B0418
		public Class644()
		{
			this.double_0 = 0.0;
			this.double_1 = 0.0;
			this.double_2 = 1.0;
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x000116E1 File Offset: 0x0000F8E1
		public Class644(ICoordinate icoordinate_0)
		{
			this.double_0 = icoordinate_0.imethod_0();
			this.double_1 = icoordinate_0.imethod_2();
			this.double_2 = 1.0;
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x000B2268 File Offset: 0x000B0468
		public Class644(Class644 class644_0, Class644 class644_1)
		{
			this.double_0 = class644_0.double_1 * class644_1.double_2 - class644_1.double_1 * class644_0.double_2;
			this.double_1 = class644_1.double_0 * class644_0.double_2 - class644_0.double_0 * class644_1.double_2;
			this.double_2 = class644_0.double_0 * class644_1.double_1 - class644_1.double_0 * class644_0.double_1;
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000B22F0 File Offset: 0x000B04F0
		public double method_0()
		{
			double num = this.double_0 / this.double_2;
			if (double.IsNaN(num) || double.IsInfinity(num))
			{
				throw new Exception10();
			}
			return num;
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000B232C File Offset: 0x000B052C
		public double method_1()
		{
			double num = this.double_1 / this.double_2;
			if (double.IsNaN(num) || double.IsInfinity(num))
			{
				throw new Exception10();
			}
			return num;
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x000B2368 File Offset: 0x000B0568
		public ICoordinate method_2()
		{
			return new Coordinate(this.method_0(), this.method_1());
		}

		// Token: 0x04000BEC RID: 3052
		private double double_0;

		// Token: 0x04000BED RID: 3053
		private double double_1;

		// Token: 0x04000BEE RID: 3054
		private double double_2 = 0.0;
	}
}

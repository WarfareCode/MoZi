using System;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using ns14;

namespace ns13
{
	// Token: 0x020003D0 RID: 976
	public sealed class Class621
	{
		// Token: 0x0600182F RID: 6191 RVA: 0x000966E4 File Offset: 0x000948E4
		public Class621(Class581 class581_1)
		{
			this.class581_0 = class581_1;
			this.icoordinate_0 = class581_1.method_5();
			Class635 @class = new Class635();
			this.int_0 = @class.method_0(this.icoordinate_0);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00096738 File Offset: 0x00094938
		public int[] method_0()
		{
			return this.int_0;
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00096750 File Offset: 0x00094950
		public double method_1(int int_1)
		{
			double num = this.icoordinate_0[this.int_0[int_1]].imethod_0();
			double num2 = this.icoordinate_0[this.int_0[int_1 + 1]].imethod_0();
			return (num < num2) ? num : num2;
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00096794 File Offset: 0x00094994
		public double method_2(int int_1)
		{
			double num = this.icoordinate_0[this.int_0[int_1]].imethod_0();
			double num2 = this.icoordinate_0[this.int_0[int_1 + 1]].imethod_0();
			return (num > num2) ? num : num2;
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00010169 File Offset: 0x0000E369
		public void method_3(int int_1, Class621 class621_0, int int_2, Class647 class647_0)
		{
			this.method_4(this.int_0[int_1], this.int_0[int_1 + 1], class621_0, class621_0.int_0[int_2], class621_0.int_0[int_2 + 1], class647_0);
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x000967D8 File Offset: 0x000949D8
		private void method_4(int int_1, int int_2, Class621 class621_0, int int_3, int int_4, Class647 class647_0)
		{
			ICoordinate coordinate = this.icoordinate_0[int_1];
			ICoordinate icoordinate_ = this.icoordinate_0[int_2];
			ICoordinate coordinate2 = class621_0.icoordinate_0[int_3];
			ICoordinate icoordinate_2 = class621_0.icoordinate_0[int_4];
			if (int_2 - int_1 == 1 && int_4 - int_3 == 1)
			{
				class647_0.method_4(this.class581_0, int_1, class621_0.class581_0, int_3);
			}
			else
			{
				this.ienvelope_0.imethod_8(coordinate, icoordinate_);
				this.ienvelope_1.imethod_8(coordinate2, icoordinate_2);
				if (this.ienvelope_0.imethod_9(this.ienvelope_1))
				{
					int num = (int_1 + int_2) / 2;
					int num2 = (int_3 + int_4) / 2;
					if (int_1 < num)
					{
						if (int_3 < num2)
						{
							this.method_4(int_1, num, class621_0, int_3, num2, class647_0);
						}
						if (num2 < int_4)
						{
							this.method_4(int_1, num, class621_0, num2, int_4, class647_0);
						}
					}
					if (num < int_2)
					{
						if (int_3 < num2)
						{
							this.method_4(num, int_2, class621_0, int_3, num2, class647_0);
						}
						if (num2 < int_4)
						{
							this.method_4(num, int_2, class621_0, num2, int_4, class647_0);
						}
					}
				}
			}
		}

		// Token: 0x040009F3 RID: 2547
		private Class581 class581_0;

		// Token: 0x040009F4 RID: 2548
		private ICoordinate[] icoordinate_0;

		// Token: 0x040009F5 RID: 2549
		private int[] int_0;

		// Token: 0x040009F6 RID: 2550
		private IEnvelope ienvelope_0 = new Envelope();

		// Token: 0x040009F7 RID: 2551
		private IEnvelope ienvelope_1 = new Envelope();
	}
}

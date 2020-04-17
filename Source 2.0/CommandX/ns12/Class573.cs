using System;
using System.Text;
using GeoAPI.Geometries;
using ns13;
using ns14;

namespace ns12
{
	// Token: 0x0200035E RID: 862
	public class Class573 : IComparable
	{
		// Token: 0x06001465 RID: 5221 RVA: 0x0000E7C1 File Offset: 0x0000C9C1
		protected Class573(Class581 class581_1)
		{
			this.class581_0 = class581_1;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0000E7DE File Offset: 0x0000C9DE
		public Class573(Class581 class581_1, ICoordinate icoordinate_2, ICoordinate icoordinate_3, Class652 class652_1) : this(class581_1)
		{
			this.method_0(icoordinate_2, icoordinate_3);
			this.class652_0 = class652_1;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00088978 File Offset: 0x00086B78
		protected void method_0(ICoordinate icoordinate_2, ICoordinate icoordinate_3)
		{
			this.icoordinate_0 = icoordinate_2;
			this.icoordinate_1 = icoordinate_3;
			this.double_0 = icoordinate_3.imethod_0() - icoordinate_2.imethod_0();
			this.double_1 = icoordinate_3.imethod_2() - icoordinate_2.imethod_2();
			this.int_0 = Class659.smethod_0(this.double_0, this.double_1);
			Class570.smethod_0(this.double_0 != 0.0 || this.double_1 != 0.0, "EdgeEnd with identical endpoints found");
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00088A04 File Offset: 0x00086C04
		public Class581 method_1()
		{
			return this.class581_0;
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00088A1C File Offset: 0x00086C1C
		public Class652 method_2()
		{
			return this.class652_0;
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00088A34 File Offset: 0x00086C34
		public ICoordinate method_3()
		{
			return this.icoordinate_0;
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00088A4C File Offset: 0x00086C4C
		public ICoordinate method_4()
		{
			return this.icoordinate_1;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0000E7F7 File Offset: 0x0000C9F7
		public void method_5(Class579 class579_1)
		{
			this.class579_0 = class579_1;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00088A64 File Offset: 0x00086C64
		public int CompareTo(object target)
		{
			Class573 class573_ = (Class573)target;
			return this.method_6(class573_);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00088A84 File Offset: 0x00086C84
		public int method_6(Class573 class573_0)
		{
			int result;
			if (this.double_0 == class573_0.double_0 && this.double_1 == class573_0.double_1)
			{
				result = 0;
			}
			else if (this.int_0 > class573_0.int_0)
			{
				result = 1;
			}
			else if (this.int_0 < class573_0.int_0)
			{
				result = -1;
			}
			else
			{
				result = Class628.smethod_4(class573_0.icoordinate_0, class573_0.icoordinate_1, this.icoordinate_1);
			}
			return result;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public  void vmethod_0()
		{
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00088B04 File Offset: 0x00086D04
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('[');
			stringBuilder.Append(this.icoordinate_0.imethod_0());
			stringBuilder.Append(' ');
			stringBuilder.Append(this.icoordinate_1.imethod_2());
			stringBuilder.Append(']');
			return stringBuilder.ToString();
		}

		// Token: 0x04000877 RID: 2167
		protected Class581 class581_0 = null;

		// Token: 0x04000878 RID: 2168
		protected Class652 class652_0 = null;

		// Token: 0x04000879 RID: 2169
		private Class579 class579_0;

		// Token: 0x0400087A RID: 2170
		private ICoordinate icoordinate_0;

		// Token: 0x0400087B RID: 2171
		private ICoordinate icoordinate_1;

		// Token: 0x0400087C RID: 2172
		private double double_0;

		// Token: 0x0400087D RID: 2173
		private double double_1;

		// Token: 0x0400087E RID: 2174
		private int int_0;
	}
}

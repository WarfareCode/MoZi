using System;
using System.Text;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;

namespace ns12
{
	// Token: 0x020003A5 RID: 933
	public abstract class Class596
	{
		// Token: 0x060016D4 RID: 5844 RVA: 0x00091128 File Offset: 0x0008F328
		public static double smethod_0(ICoordinate icoordinate_4, ICoordinate icoordinate_5, ICoordinate icoordinate_6)
		{
			double num = Math.Abs(icoordinate_6.imethod_0() - icoordinate_5.imethod_0());
			double num2 = Math.Abs(icoordinate_6.imethod_2() - icoordinate_5.imethod_2());
			double num3;
			if (icoordinate_4.Equals(icoordinate_5))
			{
				num3 = 0.0;
			}
			else if (icoordinate_4.Equals(icoordinate_6))
			{
				if (num > num2)
				{
					num3 = num;
				}
				else
				{
					num3 = num2;
				}
			}
			else
			{
				double num4 = Math.Abs(icoordinate_4.imethod_0() - icoordinate_5.imethod_0());
				double num5 = Math.Abs(icoordinate_4.imethod_2() - icoordinate_5.imethod_2());
				if (num > num2)
				{
					num3 = num4;
				}
				else
				{
					num3 = num5;
				}
				if (num3 == 0.0 && !icoordinate_4.Equals(icoordinate_5))
				{
					num3 = Math.Max(num4, num5);
				}
			}
			Class570.smethod_0(num3 != 0.0 || icoordinate_4.Equals(icoordinate_5), "Bad distance calculation");
			return num3;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00091218 File Offset: 0x0008F418
		public Class596()
		{
			this.icoordinate_1[0] = new Coordinate();
			this.icoordinate_1[1] = new Coordinate();
			this.icoordinate_2 = this.icoordinate_1[0];
			this.icoordinate_3 = this.icoordinate_1[1];
			this.int_0 = 0;
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0000F794 File Offset: 0x0000D994
		public void method_0(IPrecisionModel iprecisionModel_1)
		{
			this.iprecisionModel_0 = iprecisionModel_1;
		}

		// Token: 0x060016D7 RID: 5847
		public abstract void vmethod_0(ICoordinate icoordinate_4, ICoordinate icoordinate_5, ICoordinate icoordinate_6);

		// Token: 0x060016D8 RID: 5848 RVA: 0x0000F79D File Offset: 0x0000D99D
		protected bool method_1()
		{
			return this.int_0 == 2;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0000F7A8 File Offset: 0x0000D9A8
		public void method_2(ICoordinate icoordinate_4, ICoordinate icoordinate_5, ICoordinate icoordinate_6, ICoordinate icoordinate_7)
		{
			this.icoordinate_0[0] = icoordinate_4;
			this.icoordinate_0[1] = icoordinate_5;
			this.icoordinate_0[2] = icoordinate_6;
			this.icoordinate_0[3] = icoordinate_7;
			this.int_0 = this.vmethod_1(icoordinate_4, icoordinate_5, icoordinate_6, icoordinate_7);
		}

		// Token: 0x060016DA RID: 5850
		public abstract int vmethod_1(ICoordinate icoordinate_4, ICoordinate icoordinate_5, ICoordinate icoordinate_6, ICoordinate icoordinate_7);

		// Token: 0x060016DB RID: 5851 RVA: 0x00091288 File Offset: 0x0008F488
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.icoordinate_0[0]).Append("-");
			stringBuilder.Append(this.icoordinate_0[1]).Append(" ");
			stringBuilder.Append(this.icoordinate_0[2]).Append("-");
			stringBuilder.Append(this.icoordinate_0[3]).Append(" : ");
			if (this.method_3())
			{
				stringBuilder.Append(" endpoint");
			}
			if (this.bool_0)
			{
				stringBuilder.Append(" proper");
			}
			if (this.method_1())
			{
				stringBuilder.Append(" collinear");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		protected bool method_3()
		{
			return this.method_4() && !this.bool_0;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0000F7F6 File Offset: 0x0000D9F6
		public bool method_4()
		{
			return this.int_0 != 0;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x0009134C File Offset: 0x0008F54C
		public int method_5()
		{
			return this.int_0;
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00091364 File Offset: 0x0008F564
		public ICoordinate method_6(int int_1)
		{
			return this.icoordinate_1[int_1];
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x0009137C File Offset: 0x0008F57C
		public bool method_7(ICoordinate icoordinate_4)
		{
			bool result;
			for (int i = 0; i < this.int_0; i++)
			{
				if (this.icoordinate_1[i].imethod_8(icoordinate_4))
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x0000F804 File Offset: 0x0000DA04
		public bool method_8()
		{
			return this.method_4() && this.bool_0;
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x000913B8 File Offset: 0x0008F5B8
		public double method_9(int int_1, int int_2)
		{
			return Class596.smethod_0(this.icoordinate_1[int_2], this.icoordinate_0[int_1 * 2], this.icoordinate_0[int_1 * 2 + 1]);
		}

		// Token: 0x04000973 RID: 2419
		protected int int_0;

		// Token: 0x04000974 RID: 2420
		protected ICoordinate[] icoordinate_0 = new ICoordinate[4];

		// Token: 0x04000975 RID: 2421
		protected ICoordinate[] icoordinate_1 = new ICoordinate[2];

		// Token: 0x04000976 RID: 2422
		protected bool bool_0;

		// Token: 0x04000977 RID: 2423
		protected ICoordinate icoordinate_2;

		// Token: 0x04000978 RID: 2424
		protected ICoordinate icoordinate_3;

		// Token: 0x04000979 RID: 2425
		protected IPrecisionModel iprecisionModel_0 = null;
	}
}

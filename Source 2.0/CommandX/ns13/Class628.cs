using System;
using GeoAPI.Geometries;
using GisSharpBlog.NetTopologySuite.Geometries;
using ns12;
using ns14;

namespace ns13
{
	// Token: 0x020003E3 RID: 995
	internal static class Class628
	{
		// Token: 0x060018C7 RID: 6343 RVA: 0x00098D10 File Offset: 0x00096F10
		public static int smethod_0(ICoordinate icoordinate_0, ICoordinate icoordinate_1, ICoordinate icoordinate_2)
		{
			double num = icoordinate_1.imethod_0();
			double num2 = icoordinate_1.imethod_2();
			double double_ = num - icoordinate_0.imethod_0();
			double double_2 = num2 - icoordinate_0.imethod_2();
			double double_3 = icoordinate_2.imethod_0() - num;
			double double_4 = icoordinate_2.imethod_2() - num2;
			return Class663.smethod_0(double_, double_2, double_3, double_4);
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00098D60 File Offset: 0x00096F60
		public static bool smethod_1(ICoordinate icoordinate_0, ICoordinate[] icoordinate_1)
		{
			if (icoordinate_0 == null)
			{
				throw new ArgumentNullException("p", "coordinate 'p' is null");
			}
			if (icoordinate_1 == null)
			{
				throw new ArgumentNullException("ring", "ring 'ring' is null");
			}
			int num = 0;
			for (int i = 1; i < icoordinate_1.Length; i++)
			{
				int num2 = i - 1;
				ICoordinate coordinate = icoordinate_1[i];
				ICoordinate coordinate2 = icoordinate_1[num2];
				double num3 = icoordinate_0.imethod_0();
				double num4 = icoordinate_0.imethod_2();
				double num5 = coordinate.imethod_2();
				double num6 = coordinate2.imethod_2();
				if ((num5 > num4 && num6 <= num4) || (num6 > num4 && num5 <= num4))
				{
					double double_ = coordinate.imethod_0() - num3;
					double num7 = num5 - num4;
					double double_2 = coordinate2.imethod_0() - num3;
					double num8 = num6 - num4;
					double num9 = (double)Class663.smethod_0(double_, num7, double_2, num8) / (num8 - num7);
					if (0.0 < num9)
					{
						num++;
					}
				}
			}
			return num % 2 == 1;
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00098E5C File Offset: 0x0009705C
		public static bool smethod_2(ICoordinate icoordinate_0, ICoordinate[] icoordinate_1)
		{
			Class596 @class = new Class597();
			bool result;
			for (int i = 1; i < icoordinate_1.Length; i++)
			{
				ICoordinate coordinate = icoordinate_1[i - 1];
				ICoordinate coordinate2 = icoordinate_1[i];
				@class.vmethod_0((Coordinate)icoordinate_0, (Coordinate)coordinate, (Coordinate)coordinate2);
				if (@class.method_4())
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00098EB8 File Offset: 0x000970B8
		public static bool smethod_3(ICoordinate[] icoordinate_0)
		{
			int num = icoordinate_0.Length - 1;
			ICoordinate coordinate = icoordinate_0[0];
			int num2 = 0;
			for (int i = 1; i <= num; i++)
			{
				ICoordinate coordinate2 = icoordinate_0[i];
				if (coordinate2.imethod_2() > coordinate.imethod_2())
				{
					coordinate = coordinate2;
					num2 = i;
				}
			}
			int num3 = num2;
			do
			{
				num3--;
				if (num3 < 0)
				{
					num3 = num;
				}
			}
			while (icoordinate_0[num3].imethod_8(coordinate) && num3 != num2);
			int num4 = num2;
			do
			{
				num4 = (num4 + 1) % num;
			}
			while (icoordinate_0[num4].imethod_8(coordinate) && num4 != num2);
			ICoordinate coordinate3 = icoordinate_0[num3];
			ICoordinate coordinate4 = icoordinate_0[num4];
			bool result;
			if (coordinate3.imethod_8(coordinate) || coordinate4.imethod_8(coordinate) || coordinate3.imethod_8(coordinate4))
			{
				result = false;
			}
			else
			{
				int num5 = Class628.smethod_4(coordinate3, coordinate, coordinate4);
				bool flag;
				if (num5 == 0)
				{
					flag = (coordinate3.imethod_0() > coordinate4.imethod_0());
				}
				else
				{
					flag = (num5 > 0);
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x00098FD4 File Offset: 0x000971D4
		public static int smethod_4(ICoordinate icoordinate_0, ICoordinate icoordinate_1, ICoordinate icoordinate_2)
		{
			return Class628.smethod_0(icoordinate_0, icoordinate_1, icoordinate_2);
		}
	}
}

using System;
using System.Collections.Generic;
using GeoAPI.Geometries;
using ns14;

namespace ns12
{
	// Token: 0x0200037F RID: 895
	internal static class Class585
	{
		// Token: 0x06001588 RID: 5512 RVA: 0x0008BC98 File Offset: 0x00089E98
		public static int smethod_0(ICoordinate[] icoordinate_0, ICoordinate[] icoordinate_1)
		{
			int num = 0;
			int result;
			while (num < icoordinate_0.Length && num < icoordinate_1.Length)
			{
				int num2 = icoordinate_0[num].CompareTo(icoordinate_1[num]);
				if (num2 != 0)
				{
					int num3 = num2;
					result = num3;
					return result;
				}
				num++;
			}
			if (num < icoordinate_1.Length)
			{
				result = -1;
				return result;
			}
			if (num < icoordinate_0.Length)
			{
				result = 1;
				return result;
			}
			result = 0;
			return result;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0008BD04 File Offset: 0x00089F04
		private static bool smethod_1(ICoordinate[] icoordinate_0, ICoordinate[] icoordinate_1)
		{
			bool result;
			for (int i = 0; i < icoordinate_0.Length; i++)
			{
				ICoordinate coordinate = icoordinate_0[i];
				ICoordinate other = icoordinate_1[icoordinate_0.Length - i - 1];
				if (coordinate.CompareTo(other) != 0)
				{
					result = false;
					return result;
				}
			}
			result = true;
			return result;
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0008BD44 File Offset: 0x00089F44
		public static bool smethod_2(ICoordinate[] icoordinate_0)
		{
			bool result;
			for (int i = 1; i < icoordinate_0.Length; i++)
			{
				if (icoordinate_0[i - 1].Equals(icoordinate_0[i]))
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0008BD7C File Offset: 0x00089F7C
		public static ICoordinate[] smethod_3(ICoordinate[] icoordinate_0)
		{
			ICoordinate[] result;
			if (!Class585.smethod_2(icoordinate_0))
			{
				result = icoordinate_0;
			}
			else
			{
				Class662 @class = new Class662(icoordinate_0, false);
				result = @class.method_3();
			}
			return result;
		}

		// Token: 0x02000380 RID: 896
		public sealed class Class586 : IComparer<ICoordinate[]>
		{
			// Token: 0x0600158C RID: 5516 RVA: 0x0008BDA8 File Offset: 0x00089FA8
			public int Compare(ICoordinate[] x, ICoordinate[] y)
			{
				return Class585.smethod_0(x, y);
			}
		}

		// Token: 0x02000381 RID: 897
		public sealed class Class587 : IComparer<ICoordinate[]>
		{
			// Token: 0x0600158E RID: 5518 RVA: 0x0008BDC0 File Offset: 0x00089FC0
			public int Compare(ICoordinate[] x, ICoordinate[] y)
			{
				int result;
				if (x.Length < y.Length)
				{
					result = -1;
				}
				else if (x.Length > y.Length)
				{
					result = 1;
				}
				else if (x.Length == 0)
				{
					result = 0;
				}
				else
				{
					int num = Class585.smethod_0(x, y);
					if (Class585.smethod_1(x, y))
					{
						result = 0;
					}
					else
					{
						result = num;
					}
				}
				return result;
			}
		}
	}
}

using System;
using System.Collections.Generic;
using DotSpatial.Topology;

namespace ns16
{
	// Token: 0x020004DE RID: 1246
	internal static class Class2178
	{
		// Token: 0x0600207E RID: 8318 RVA: 0x000D4630 File Offset: 0x000D2830
		public static int smethod_0(Coordinate[] coordinate_0, Coordinate[] coordinate_1)
		{
			int num = 0;
			int result;
			while (num < coordinate_0.Length && num < coordinate_1.Length)
			{
				int num2 = coordinate_0[num].CompareTo(coordinate_1[num]);
				if (num2 != 0)
				{
					result = num2;
					return result;
				}
				num++;
			}
			if (num < coordinate_1.Length)
			{
				result = -1;
				return result;
			}
			if (num < coordinate_0.Length)
			{
				result = 1;
				return result;
			}
			result = 0;
			return result;
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x000D4694 File Offset: 0x000D2894
		private static bool smethod_1(Coordinate[] coordinate_0, Coordinate[] coordinate_1)
		{
			bool result;
			for (int i = 0; i < coordinate_0.Length; i++)
			{
				Coordinate coordinate = coordinate_0[i];
				Coordinate other = coordinate_1[coordinate_0.Length - i - 1];
				if (coordinate.CompareTo(other) != 0)
				{
					result = false;
					return result;
				}
			}
			result = true;
			return result;
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x000D46D4 File Offset: 0x000D28D4
		public static bool smethod_2(IEnumerable<Coordinate> ienumerable_0)
		{
			Coordinate obj = null;
			bool result;
			foreach (Coordinate current in ienumerable_0)
			{
				if (current.Equals(obj))
				{
					result = true;
					return result;
				}
				obj = current;
			}
			result = false;
			return result;
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x000D4730 File Offset: 0x000D2930
		public static IList<Coordinate> smethod_3(IList<Coordinate> ilist_0)
		{
			IList<Coordinate> result;
			if (!Class2178.smethod_2(ilist_0))
			{
				result = ilist_0;
			}
			else
			{
				result = new Class833(ilist_0, false);
			}
			return result;
		}

		// Token: 0x020004DF RID: 1247
		public sealed class Class2179 : IComparer<Coordinate[]>
		{
			// Token: 0x06002082 RID: 8322 RVA: 0x000D4754 File Offset: 0x000D2954
			public  int Compare(Coordinate[] x, Coordinate[] y)
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
					int num = Class2178.smethod_0(x, y);
					if (!Class2178.smethod_1(x, y))
					{
						result = num;
					}
					else
					{
						result = 0;
					}
				}
				return result;
			}
		}

		// Token: 0x020004E0 RID: 1248
		public sealed class Class2180 : IComparer<Coordinate[]>
		{
			// Token: 0x06002084 RID: 8324 RVA: 0x000D47AC File Offset: 0x000D29AC
			public  int Compare(Coordinate[] x, Coordinate[] y)
			{
				return Class2178.smethod_0(x, y);
			}
		}
	}
}

using System;
using System.Collections;
using GeoAPI.Geometries;
using ns14;

namespace ns13
{
	// Token: 0x020003FB RID: 1019
	public sealed class Class635
	{
		// Token: 0x0600196D RID: 6509 RVA: 0x0009AF1C File Offset: 0x0009911C
		public static int[] smethod_0(IList ilist_0)
		{
			int[] array = new int[ilist_0.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToInt32(ilist_0[i]);
			}
			return array;
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x0009AF58 File Offset: 0x00099158
		public int[] method_0(ICoordinate[] icoordinate_0)
		{
			int num = 0;
			IList list = new ArrayList();
			list.Add(0);
			do
			{
				int num2 = this.method_1(icoordinate_0, num);
				list.Add(num2);
				num = num2;
			}
			while (num < icoordinate_0.Length - 1);
			return Class635.smethod_0(list);
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x0009AFA4 File Offset: 0x000991A4
		private int method_1(ICoordinate[] icoordinate_0, int int_0)
		{
			int num = Class659.smethod_1(icoordinate_0[int_0], icoordinate_0[int_0 + 1]);
			int i;
			for (i = int_0 + 1; i < icoordinate_0.Length; i++)
			{
				int num2 = Class659.smethod_1(icoordinate_0[i - 1], icoordinate_0[i]);
				if (num2 != num)
				{
					break;
				}
			}
			return i - 1;
		}
	}
}

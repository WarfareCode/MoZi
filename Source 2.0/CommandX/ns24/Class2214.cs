using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns25;

namespace ns24
{
	// Token: 0x0200059D RID: 1437
	public sealed class Class2214
	{
		// Token: 0x060024D4 RID: 9428 RVA: 0x0009AF1C File Offset: 0x0009911C
		public static int[] smethod_0(IList ilist_0)
		{
			int[] array = new int[ilist_0.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToInt32(ilist_0[i]);
			}
			return array;
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x000E3078 File Offset: 0x000E1278
		public  int[] vmethod_0(IList<Coordinate> ilist_0)
		{
			int num = 0;
			IList list = new ArrayList();
			list.Add(0);
			do
			{
				int num2 = Class2214.smethod_1(ilist_0, num);
				list.Add(num2);
				num = num2;
			}
			while (num < ilist_0.Count - 1);
			return Class2214.smethod_0(list);
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x000E30C8 File Offset: 0x000E12C8
		private static int smethod_1(IList<Coordinate> ilist_0, int int_0)
		{
			int num = Class2223.smethod_1(ilist_0[int_0], ilist_0[int_0 + 1]);
			int i;
			for (i = int_0 + 1; i < ilist_0.Count; i++)
			{
				int num2 = Class2223.smethod_1(ilist_0[i - 1], ilist_0[i]);
				if (num2 != num)
				{
					break;
				}
			}
			return i - 1;
		}
	}
}

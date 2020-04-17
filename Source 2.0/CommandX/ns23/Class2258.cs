using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns25;

namespace ns23
{
	// Token: 0x0200067C RID: 1660
	public sealed class Class2258
	{
		// Token: 0x06002A40 RID: 10816 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class2258()
		{
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x000FE748 File Offset: 0x000FC948
		public static int[] smethod_0(IList ilist_0)
		{
			int[] array = new int[ilist_0.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (int)ilist_0[i];
			}
			return array;
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x000FE784 File Offset: 0x000FC984
		public static IList smethod_1(IList<Coordinate> ilist_0)
		{
			return Class2258.smethod_2(ilist_0, null);
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x000FE79C File Offset: 0x000FC99C
		public static IList smethod_2(IList<Coordinate> ilist_0, object object_0)
		{
			IList list = new ArrayList();
			int[] array = Class2258.smethod_3(ilist_0);
			for (int i = 0; i < array.Length - 1; i++)
			{
				Class2257 value = new Class2257(ilist_0, array[i], array[i + 1], object_0);
				list.Add(value);
			}
			return list;
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x000FE7E8 File Offset: 0x000FC9E8
		public static int[] smethod_3(IList<Coordinate> ilist_0)
		{
			int num = 0;
			IList list = new ArrayList();
			list.Add(0);
			do
			{
				int num2 = Class2258.smethod_4(ilist_0, num);
				list.Add(num2);
				num = num2;
			}
			while (num < ilist_0.Count - 1);
			return Class2258.smethod_0(list);
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x000E30C8 File Offset: 0x000E12C8
		private static int smethod_4(IList<Coordinate> ilist_0, int int_0)
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

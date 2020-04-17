using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology;
using ns23;
using ns25;

namespace ns27
{
	// Token: 0x02000711 RID: 1809
	public sealed class Class2300 : Interface47
	{
		// Token: 0x06002D06 RID: 11526 RVA: 0x00102EBC File Offset: 0x001010BC
		public IList imethod_1()
		{
			return Class2295.smethod_0(this.ilist_0);
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x000187F8 File Offset: 0x000169F8
		public void imethod_0(IList ilist_1)
		{
			this.ilist_0 = ilist_1;
			this.method_0(ilist_1, this.class2239_0);
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x00102ED8 File Offset: 0x001010D8
		private void method_0(IList ilist_1, LineIntersector class2239_1)
		{
			IList ilist_2 = Class2300.smethod_0(ilist_1, class2239_1);
			this.method_1(ilist_1, ilist_2);
			this.method_3(ilist_1);
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x00102EFC File Offset: 0x001010FC
		private static IList smethod_0(IList ilist_1, LineIntersector class2239_1)
		{
			Class2284 @class = new Class2284(class2239_1);
			Class2286 class2 = new Class2287(@class);
			class2.imethod_0(ilist_1);
			return @class.method_0();
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x00102F28 File Offset: 0x00101128
		private void method_1(IList ilist_1, IList ilist_2)
		{
			foreach (object current in ilist_1)
			{
				Class2295 class2295_ = (Class2295)current;
				this.method_2(class2295_, ilist_2);
			}
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x00102F84 File Offset: 0x00101184
		private void method_2(Class2295 class2295_0, IList ilist_1)
		{
			foreach (object current in ilist_1)
			{
				Coordinate coordinate_ = (Coordinate)current;
				Class2296 class2296_ = new Class2296(coordinate_, this.double_0, this.class2239_0);
				for (int i = 0; i < class2295_0.method_2() - 1; i++)
				{
					Class2300.smethod_1(class2296_, class2295_0, i);
				}
			}
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x00103010 File Offset: 0x00101210
		public void method_3(IList ilist_1)
		{
			foreach (object current in ilist_1)
			{
				Class2295 class2295_ = (Class2295)current;
				foreach (object current2 in ilist_1)
				{
					Class2295 class2295_2 = (Class2295)current2;
					this.method_4(class2295_, class2295_2);
				}
			}
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x001030B8 File Offset: 0x001012B8
		private void method_4(Class2295 class2295_0, Class2295 class2295_1)
		{
			IList<Coordinate> list = class2295_0.method_3();
			IList<Coordinate> list2 = class2295_1.method_3();
			for (int i = 0; i < list.Count - 1; i++)
			{
				Class2296 class2296_ = new Class2296(list[i], this.double_0, this.class2239_0);
				int j = 0;
				while (j < list2.Count - 1)
				{
					if (class2295_0 != class2295_1)
					{
						goto IL_3E;
					}
					if (i != j)
					{
						goto IL_3E;
					}
					bool arg_4A_0 = true;
					IL_4A:
					if (!arg_4A_0)
					{
						class2295_0.method_9(list[i], i);
					}
					j++;
					continue;
					IL_3E:
					arg_4A_0 = !Class2300.smethod_1(class2296_, class2295_1, j);
					goto IL_4A;
				}
			}
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x00103144 File Offset: 0x00101344
		public static bool smethod_1(Class2296 class2296_0, Class2295 class2295_0, int int_0)
		{
			Coordinate coordinate_ = class2295_0.method_5(int_0);
			Coordinate coordinate_2 = class2295_0.method_5(int_0 + 1);
			bool result;
			if (class2296_0.method_4(coordinate_, coordinate_2))
			{
				class2295_0.method_9(class2296_0.method_0(), int_0);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0400151F RID: 5407
		private readonly LineIntersector class2239_0;

		// Token: 0x04001520 RID: 5408
		private readonly double double_0;

		// Token: 0x04001521 RID: 5409
		private IList ilist_0;
	}
}

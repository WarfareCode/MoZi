using System;
using System.Collections;
using DotSpatial.Topology;
using ns28;

namespace ns27
{
	// Token: 0x020006F9 RID: 1785
	public sealed class Class2292 : IEnumerable
	{
		// Token: 0x06002C8E RID: 11406 RVA: 0x00018365 File Offset: 0x00016565
		public Class2292(Class2295 class2295_1)
		{
			this.class2295_0 = class2295_1;
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x001020A4 File Offset: 0x001002A4
		public IEnumerator GetEnumerator()
		{
			return this.idictionary_0.Values.GetEnumerator();
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x001020C4 File Offset: 0x001002C4
		public void method_0(Coordinate coordinate_0, int int_0)
		{
			Class2291 @class = new Class2291(this.class2295_0, coordinate_0, int_0, this.class2295_0.method_6(int_0));
			Class2291 class2 = (Class2291)this.idictionary_0[@class];
			if (class2 != null)
			{
				Class2347.smethod_1(class2.coordinate_0.Equals2D(coordinate_0), "Found equal nodes with different coordinates");
			}
			else
			{
				this.idictionary_0.Add(@class, @class);
			}
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x00102128 File Offset: 0x00100328
		private void method_1()
		{
			int int_ = this.class2295_0.method_2() - 1;
			this.method_0(this.class2295_0.method_5(0), 0);
			this.method_0(this.class2295_0.method_5(int_), int_);
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x0010216C File Offset: 0x0010036C
		private void method_2()
		{
			IList list = new ArrayList();
			this.method_4(list);
			this.method_3(list);
			foreach (object current in list)
			{
				int int_ = (int)current;
				this.method_0(this.class2295_0.method_5(int_), int_);
			}
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x001021EC File Offset: 0x001003EC
		private void method_3(IList ilist_0)
		{
			for (int i = 0; i < this.class2295_0.method_2() - 2; i++)
			{
				Coordinate coordinate = this.class2295_0.method_5(i);
				Coordinate b = this.class2295_0.method_5(i + 2);
				if (coordinate.Equals2D(b))
				{
					ilist_0.Add(i + 1);
				}
			}
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x0010224C File Offset: 0x0010044C
		private void method_4(IList ilist_0)
		{
			int[] array = new int[1];
			IEnumerator enumerator = this.GetEnumerator();
			enumerator.MoveNext();
			Class2291 class2291_ = (Class2291)enumerator.Current;
			while (enumerator.MoveNext())
			{
				Class2291 @class = (Class2291)enumerator.Current;
				if (Class2292.smethod_0(class2291_, @class, array))
				{
					ilist_0.Add(array[0]);
				}
				class2291_ = @class;
			}
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x001022B0 File Offset: 0x001004B0
		private static bool smethod_0(Class2291 class2291_0, Class2291 class2291_1, int[] int_0)
		{
			bool result;
			if (!class2291_0.coordinate_0.Equals2D(class2291_1.coordinate_0))
			{
				result = false;
			}
			else
			{
				int num = class2291_1.int_0 - class2291_0.int_0;
				if (!class2291_1.method_0())
				{
					num--;
				}
				if (num == 1)
				{
					int_0[0] = class2291_0.int_0 + 1;
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x0010230C File Offset: 0x0010050C
		public void method_5(IList ilist_0)
		{
			this.method_1();
			this.method_2();
			IEnumerator enumerator = this.GetEnumerator();
			enumerator.MoveNext();
			Class2291 class2291_ = (Class2291)enumerator.Current;
			while (enumerator.MoveNext())
			{
				Class2291 @class = (Class2291)enumerator.Current;
				Class2295 value = this.method_6(class2291_, @class);
				ilist_0.Add(value);
				class2291_ = @class;
			}
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x00102368 File Offset: 0x00100568
		private Class2295 method_6(Class2291 class2291_0, Class2291 class2291_1)
		{
			int num = class2291_1.int_0 - class2291_0.int_0 + 2;
			Coordinate b = this.class2295_0.method_5(class2291_1.int_0);
			bool flag;
			if (!(flag = (class2291_1.method_0() || !class2291_1.coordinate_0.Equals2D(b))))
			{
				num--;
			}
			Coordinate[] array = new Coordinate[num];
			Coordinate[] array2 = array;
			int num2 = 1;
			array2[0] = new Coordinate(class2291_0.coordinate_0);
			for (int i = class2291_0.int_0 + 1; i <= class2291_1.int_0; i++)
			{
				array[num2++] = this.class2295_0.method_5(i);
			}
			if (flag)
			{
				array[num2] = class2291_1.coordinate_0;
			}
			return new Class2295(array, this.class2295_0.method_0());
		}

		// Token: 0x040014FE RID: 5374
		private readonly Class2295 class2295_0;

		// Token: 0x040014FF RID: 5375
		private readonly IDictionary idictionary_0 = new SortedList();
	}
}

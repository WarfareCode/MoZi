using System;
using System.Collections;
using DotSpatial.Topology;
using ns25;

namespace ns24
{
	// Token: 0x0200056A RID: 1386
	public sealed class Class2203
	{
		// Token: 0x060023DD RID: 9181 RVA: 0x00014C00 File Offset: 0x00012E00
		public Class2203(Class2199 class2199_1)
		{
			this.class2199_0 = class2199_1;
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x000E10A4 File Offset: 0x000DF2A4
		public  void vmethod_0(Coordinate coordinate_0, int int_0, double double_0)
		{
			Class2202 @class = new Class2202(coordinate_0, int_0, double_0);
			Class2202 class2 = (Class2202)this.idictionary_0[@class];
			if (class2 == null)
			{
				this.idictionary_0.Add(@class, @class);
			}
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x000E10E0 File Offset: 0x000DF2E0
		public  IEnumerator vmethod_1()
		{
			return this.idictionary_0.Values.GetEnumerator();
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x000E1100 File Offset: 0x000DF300
		public   bool vmethod_2(Coordinate coordinate_0)
		{
			IEnumerator enumerator = this.vmethod_1();
			bool result;
			while (enumerator.MoveNext())
			{
				Class2202 @class = (Class2202)enumerator.Current;
				if (@class.vmethod_0().Equals(coordinate_0))
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x000E1144 File Offset: 0x000DF344
		public  void vmethod_3()
		{
			int num = this.class2199_0.vmethod_6().Count - 1;
			this.vmethod_0(this.class2199_0.vmethod_6()[0], 0, 0.0);
			this.vmethod_0(this.class2199_0.vmethod_6()[num], num, 0.0);
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x000E11A8 File Offset: 0x000DF3A8
		public  void vmethod_4(IList ilist_0)
		{
			this.vmethod_3();
			IEnumerator enumerator = this.vmethod_1();
			enumerator.MoveNext();
			Class2202 class2202_ = (Class2202)enumerator.Current;
			while (enumerator.MoveNext())
			{
				Class2202 @class = (Class2202)enumerator.Current;
				Class2199 value = this.vmethod_5(class2202_, @class);
				ilist_0.Add(value);
				class2202_ = @class;
			}
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x000E1200 File Offset: 0x000DF400
		public  Class2199 vmethod_5(Class2202 class2202_0, Class2202 class2202_1)
		{
			int num = class2202_1.vmethod_1() - class2202_0.vmethod_1() + 2;
			Coordinate b = this.class2199_0.vmethod_6()[class2202_1.vmethod_1()];
			bool flag;
			if (!(flag = (class2202_1.vmethod_2() > 0.0 || !class2202_1.vmethod_0().Equals2D(b))))
			{
				num--;
			}
			Coordinate[] array = new Coordinate[num];
			Coordinate[] array2 = array;
			int num2 = 1;
			array2[0] = new Coordinate(class2202_0.vmethod_0());
			for (int i = class2202_0.vmethod_1() + 1; i <= class2202_1.vmethod_1(); i++)
			{
				array[num2++] = this.class2199_0.vmethod_6()[i];
			}
			if (flag)
			{
				array[num2] = class2202_1.vmethod_0();
			}
			return new Class2199(array, new Class2217(this.class2199_0.vmethod_0()));
		}

		// Token: 0x04001151 RID: 4433
		private readonly Class2199 class2199_0;

		// Token: 0x04001152 RID: 4434
		private readonly IDictionary idictionary_0 = new SortedList();
	}
}

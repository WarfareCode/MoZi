using System;
using System.Collections;
using ns26;
using ns28;

namespace ns23
{
	// Token: 0x020006A1 RID: 1697
	public abstract class Class2272
	{
		// Token: 0x06002AFD RID: 11005 RVA: 0x000176FC File Offset: 0x000158FC
		protected Class2272(int int_1)
		{
			Class2347.smethod_1(int_1 > 1, "Node capacity must be greater than 1");
			this.int_0 = int_1;
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x000FFAD4 File Offset: 0x000FDCD4
		public  int vmethod_0()
		{
			return this.int_0;
		}

		// Token: 0x06002AFF RID: 11007
		protected abstract Class2272.Interface46 vmethod_1();

		// Token: 0x06002B00 RID: 11008 RVA: 0x00017724 File Offset: 0x00015924
		public  void vmethod_2()
		{
			Class2347.smethod_0(!this.bool_0);
			this.class2269_0 = ((this.arrayList_0.Count == 0) ? this.vmethod_3(0) : this.method_0(this.arrayList_0, -1));
			this.bool_0 = true;
		}

		// Token: 0x06002B01 RID: 11009
		protected abstract Class2269 vmethod_3(int int_1);

		// Token: 0x06002B02 RID: 11010 RVA: 0x000FFAEC File Offset: 0x000FDCEC
		protected virtual IList vmethod_4(IList ilist_0, int int_1)
		{
			Class2347.smethod_0(ilist_0.Count != 0);
			ArrayList arrayList = new ArrayList();
			arrayList.Add(this.vmethod_3(int_1));
			ArrayList arrayList2 = new ArrayList(ilist_0);
			arrayList2.Sort(this.vmethod_10());
			IEnumerator enumerator = arrayList2.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Interface45 interface45_ = (Interface45)enumerator.Current;
				if (this.vmethod_5(arrayList).vmethod_0().Count == this.vmethod_0())
				{
					arrayList.Add(this.vmethod_3(int_1));
				}
				this.vmethod_5(arrayList).vmethod_2(interface45_);
			}
			return arrayList;
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x000FFB8C File Offset: 0x000FDD8C
		protected virtual Class2269 vmethod_5(IList ilist_0)
		{
			return (Class2269)ilist_0[ilist_0.Count - 1];
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x000FFBB0 File Offset: 0x000FDDB0
		protected virtual int vmethod_6(double double_0, double double_1)
		{
			int result;
			if (double_0 > double_1)
			{
				result = 1;
			}
			else if (double_0 >= double_1)
			{
				result = 0;
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x000FFBD8 File Offset: 0x000FDDD8
		private Class2269 method_0(IList ilist_0, int int_1)
		{
			Class2347.smethod_0(ilist_0.Count != 0);
			IList list = this.vmethod_4(ilist_0, int_1 + 1);
			Class2269 result;
			if (list.Count == 1)
			{
				result = (Class2269)list[0];
			}
			else
			{
				result = this.method_0(list, int_1 + 1);
			}
			return result;
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x00017764 File Offset: 0x00015964
		protected virtual void vmethod_7(object object_0, object object_1)
		{
			Class2347.smethod_1(!this.bool_0, "Cannot insert items into an STR packed R-tree after it has been built.");
			this.arrayList_0.Add(new Class2276(object_0, object_1));
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x000FFC2C File Offset: 0x000FDE2C
		protected virtual IList vmethod_8(object object_0)
		{
			if (!this.bool_0)
			{
				this.vmethod_2();
			}
			ArrayList arrayList = new ArrayList();
			IList result;
			if (this.arrayList_0.Count == 0)
			{
				Class2347.smethod_0(this.class2269_0.imethod_0() == null);
				result = arrayList;
			}
			else
			{
				if (this.vmethod_1().imethod_0(this.class2269_0.imethod_0(), object_0))
				{
					this.method_1(object_0, this.class2269_0, arrayList);
				}
				result = arrayList;
			}
			return result;
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x000FFCA4 File Offset: 0x000FDEA4
		protected virtual void vmethod_9(object object_0, Interface43 interface43_0)
		{
			if (!this.bool_0)
			{
				this.vmethod_2();
			}
			if (this.arrayList_0.Count == 0)
			{
				Class2347.smethod_0(this.class2269_0.imethod_0() == null);
			}
			if (this.vmethod_1().imethod_0(this.class2269_0.imethod_0(), object_0))
			{
				this.method_2(object_0, this.class2269_0, interface43_0);
			}
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000FFD10 File Offset: 0x000FDF10
		private void method_1(object object_0, Class2269 class2269_1, IList ilist_0)
		{
			foreach (object current in class2269_1.vmethod_0())
			{
				Interface45 @interface = (Interface45)current;
				if (this.vmethod_1().imethod_0(@interface.imethod_0(), object_0))
				{
					if (@interface is Class2269)
					{
						this.method_1(object_0, (Class2269)@interface, ilist_0);
					}
					else
					{
						if (!(@interface is Class2276))
						{
							throw new Exception27();
						}
						ilist_0.Add(((Class2276)@interface).vmethod_0());
					}
				}
			}
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x000FFDC4 File Offset: 0x000FDFC4
		private void method_2(object object_0, Class2269 class2269_1, Interface43 interface43_0)
		{
			foreach (object current in class2269_1.vmethod_0())
			{
				Interface45 @interface = (Interface45)current;
				if (this.vmethod_1().imethod_0(@interface.imethod_0(), object_0))
				{
					if (@interface is Class2269)
					{
						this.method_2(object_0, (Class2269)@interface, interface43_0);
					}
					else
					{
						if (!(@interface is Class2276))
						{
							throw new Exception27();
						}
						interface43_0.VisitItem(((Class2276)@interface).vmethod_0());
					}
				}
			}
		}

		// Token: 0x06002B0B RID: 11019
		protected abstract IComparer vmethod_10();

		// Token: 0x0400146C RID: 5228
		private readonly ArrayList arrayList_0 = new ArrayList();

		// Token: 0x0400146D RID: 5229
		private readonly int int_0;

		// Token: 0x0400146E RID: 5230
		private bool bool_0;

		// Token: 0x0400146F RID: 5231
		private Class2269 class2269_0;

		// Token: 0x020006A2 RID: 1698
		protected interface Interface46
		{
			// Token: 0x06002B0C RID: 11020
			bool imethod_0(object object_0, object object_1);
		}
	}
}

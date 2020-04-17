using System;
using System.Collections;
using DotSpatial.Topology;
using ns16;
using ns25;
using ns28;

namespace ns24
{
	// Token: 0x02000565 RID: 1381
	public abstract class Class2195
	{
		// Token: 0x060023A4 RID: 9124 RVA: 0x000E056C File Offset: 0x000DE76C
		protected IDictionary method_0()
		{
			return this.idictionary_0;
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x000E0584 File Offset: 0x000DE784
		protected IList method_1()
		{
			return this.ilist_0;
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x000E059C File Offset: 0x000DE79C
		public  Coordinate vmethod_0()
		{
			IEnumerator enumerator = this.vmethod_4();
			Coordinate result;
			if (!enumerator.MoveNext())
			{
				result = Coordinate.GetEmpty();
			}
			else
			{
				Class2192 @class = (Class2192)enumerator.Current;
				result = @class.vmethod_3();
			}
			return result;
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x000E05D4 File Offset: 0x000DE7D4
		public  IList vmethod_1()
		{
			this.method_3();
			return this.ilist_0;
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x00014ABE File Offset: 0x00012CBE
		public   bool vmethod_2()
		{
			this.method_4();
			return this.method_5(0);
		}

		// Token: 0x060023A9 RID: 9129
		public abstract void vmethod_3(Class2192 class2192_0);

		// Token: 0x060023AA RID: 9130 RVA: 0x00014ACD File Offset: 0x00012CCD
		protected void method_2(Class2192 class2192_0, object object_0)
		{
			if (!this.idictionary_0.Contains(class2192_0))
			{
				this.idictionary_0.Add(class2192_0, object_0);
				this.ilist_0 = null;
			}
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x000E05F0 File Offset: 0x000DE7F0
		public  IEnumerator vmethod_4()
		{
			return this.vmethod_1().GetEnumerator();
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x00014AF4 File Offset: 0x00012CF4
		protected void method_3()
		{
			if (this.ilist_0 == null)
			{
				this.ilist_0 = new ArrayList(this.idictionary_0.Values);
			}
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x000E060C File Offset: 0x000DE80C
		private void method_4()
		{
			IEnumerator enumerator = this.vmethod_4();
			while (enumerator.MoveNext())
			{
				Class2192 @class = (Class2192)enumerator.Current;
				@class.vmethod_11();
			}
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x000E063C File Offset: 0x000DE83C
		private bool method_5(int int_0)
		{
			IList list = this.vmethod_1();
			bool result;
			if (list.Count <= 0)
			{
				result = true;
			}
			else
			{
				int index = list.Count - 1;
				Class2217 @class = ((Class2192)list[index]).vmethod_1();
				LocationType locationType = @class.vmethod_1(int_0, Enum158.const_1);
				Class2347.smethod_1(locationType != LocationType.Null, "Found unlabelled area edge");
				LocationType locationType2 = locationType;
				IEnumerator enumerator = this.vmethod_4();
				while (enumerator.MoveNext())
				{
					Class2192 class2 = (Class2192)enumerator.Current;
					Class2217 class3 = class2.vmethod_1();
					Class2347.smethod_1(class3.vmethod_8(int_0), "Found non-area edge");
					LocationType locationType3 = class3.vmethod_1(int_0, Enum158.const_1);
					LocationType locationType4 = class3.vmethod_1(int_0, Enum158.const_2);
					if (locationType3 == locationType4)
					{
						result = false;
						return result;
					}
					if (locationType4 != locationType2)
					{
						result = false;
						return result;
					}
					locationType2 = locationType3;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x000E0714 File Offset: 0x000DE914
		public  int vmethod_5(Class2192 class2192_0)
		{
			this.vmethod_4();
			int result;
			for (int i = 0; i < this.ilist_0.Count; i++)
			{
				Class2192 @class = (Class2192)this.ilist_0[i];
				if (@class == class2192_0)
				{
					result = i;
					return result;
				}
			}
			result = -1;
			return result;
		}

		// Token: 0x0400113F RID: 4415
		private readonly IDictionary idictionary_0 = new SortedList();

		// Token: 0x04001140 RID: 4416
		private readonly LocationType[] enum157_0 = new LocationType[]
		{
			LocationType.Null,
			LocationType.Null
		};

		// Token: 0x04001141 RID: 4417
		private IList ilist_0;
	}
}

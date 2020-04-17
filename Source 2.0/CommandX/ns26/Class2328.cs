using System;
using System.Collections;
using ns16;
using ns24;
using ns25;

namespace ns26
{
	// Token: 0x02000798 RID: 1944
	public sealed class Class2328
	{
		// Token: 0x0600302B RID: 12331 RVA: 0x00109AC4 File Offset: 0x00107CC4
		public  IEnumerator vmethod_0()
		{
			return this.class2221_0.vmethod_3();
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x00109AE0 File Offset: 0x00107CE0
		public  void vmethod_1(GeometryGraph class2209_0)
		{
			this.vmethod_2(class2209_0, 0);
			this.vmethod_3(class2209_0, 0);
			Class2327 @class = new Class2327();
			IList ilist_ = @class.vmethod_0(class2209_0.vmethod_5());
			this.vmethod_4(ilist_);
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x00109B18 File Offset: 0x00107D18
		public  void vmethod_2(GeometryGraph class2209_0, int int_0)
		{
			IEnumerator enumerator = class2209_0.vmethod_5();
			while (enumerator.MoveNext())
			{
				Class2199 @class = (Class2199)enumerator.Current;
				LocationType locationType = @class.vmethod_0().vmethod_2(int_0);
				IEnumerator enumerator2 = @class.vmethod_12().vmethod_1();
				while (enumerator2.MoveNext())
				{
					Class2202 class2 = (Class2202)enumerator2.Current;
					Class2201 class3 = (Class2201)this.class2221_0.vmethod_0(class2.vmethod_0());
					if (locationType == LocationType.Boundary)
					{
						class3.vmethod_9(int_0);
					}
					else if (class3.vmethod_0().vmethod_6(int_0))
					{
						class3.vmethod_8(int_0, LocationType.Interior);
					}
				}
			}
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x00109BC0 File Offset: 0x00107DC0
		public  void vmethod_3(GeometryGraph class2209_0, int int_0)
		{
			IEnumerator enumerator = class2209_0.vmethod_4();
			while (enumerator.MoveNext())
			{
				Class2200 @class = (Class2200)enumerator.Current;
				Class2200 class2 = this.class2221_0.vmethod_0(@class.vmethod_5());
				class2.vmethod_8(int_0, @class.vmethod_0().vmethod_2(int_0));
			}
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x00109C10 File Offset: 0x00107E10
		public  void vmethod_4(IList ilist_0)
		{
			IEnumerator enumerator = ilist_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2192 class2192_ = (Class2192)enumerator.Current;
				this.class2221_0.vmethod_1(class2192_);
			}
		}

		// Token: 0x04001677 RID: 5751
		private readonly Class2221 class2221_0 = new Class2221(new Class2220());
	}
}

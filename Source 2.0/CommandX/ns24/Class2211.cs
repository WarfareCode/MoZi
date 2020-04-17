using System;
using System.Collections;
using ns25;

namespace ns24
{
	// Token: 0x020005AD RID: 1453
	public sealed class Class2211 : EdgeSetIntersector
	{
		// Token: 0x06002514 RID: 9492 RVA: 0x000152E8 File Offset: 0x000134E8
		public override void ComputeIntersections(IList ilist_0, SegmentIntersector class2215_0, bool bool_0)
		{
			if (bool_0)
			{
				this.method_1(ilist_0, null);
			}
			else
			{
				this.method_0(ilist_0);
			}
			this.method_4(class2215_0);
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x000E380C File Offset: 0x000E1A0C
		private void method_0(IEnumerable ienumerable_0)
		{
			IEnumerator enumerator = ienumerable_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2199 @class = (Class2199)enumerator.Current;
				this.method_2(@class, @class);
			}
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x000E3840 File Offset: 0x000E1A40
		private void method_1(IEnumerable ienumerable_0, object object_0)
		{
			IEnumerator enumerator = ienumerable_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class2199 class2199_ = (Class2199)enumerator.Current;
				this.method_2(class2199_, object_0);
			}
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x000E3874 File Offset: 0x000E1A74
		private void method_2(Class2199 class2199_0, object object_0)
		{
			Class2213 @class = class2199_0.vmethod_13();
			int[] array = @class.vmethod_0();
			for (int i = 0; i < array.Length - 1; i++)
			{
				Class2212 object_ = new Class2212(@class, i);
				Class2216 class2 = new Class2216(object_0, @class.vmethod_1(i), null, object_);
				this.arrayList_0.Add(class2);
				this.arrayList_0.Add(new Class2216(object_0, @class.vmethod_2(i), class2, object_));
			}
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x000E38E4 File Offset: 0x000E1AE4
		private void method_3()
		{
			this.arrayList_0.Sort();
			for (int i = 0; i < this.arrayList_0.Count; i++)
			{
				Class2216 @class = (Class2216)this.arrayList_0[i];
				if (@class.vmethod_2())
				{
					@class.method_0().vmethod_4(i);
				}
			}
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x000E3940 File Offset: 0x000E1B40
		private void method_4(SegmentIntersector class2215_0)
		{
			this.int_0 = 0;
			this.method_3();
			for (int i = 0; i < this.arrayList_0.Count; i++)
			{
				Class2216 @class = (Class2216)this.arrayList_0[i];
				if (@class.vmethod_1())
				{
					this.method_5(i, @class.vmethod_3(), @class, class2215_0);
				}
			}
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x000E39A0 File Offset: 0x000E1BA0
		private void method_5(int int_1, int int_2, Class2216 class2216_0, SegmentIntersector class2215_0)
		{
			Class2212 @class = (Class2212)class2216_0.vmethod_5();
			for (int i = int_1; i < int_2; i++)
			{
				Class2216 class2 = (Class2216)this.arrayList_0[i];
				if (class2.vmethod_1())
				{
					Class2212 class2212_ = (Class2212)class2.vmethod_5();
					class2216_0.vmethod_0();
					if (class2216_0.vmethod_0() == null || class2216_0.vmethod_0() != class2.vmethod_0())
					{
						@class.vmethod_0(class2212_, class2215_0);
						this.int_0++;
					}
				}
			}
		}

		// Token: 0x040011D8 RID: 4568
		private readonly ArrayList arrayList_0 = new ArrayList();

		// Token: 0x040011D9 RID: 4569
		private int int_0;
	}
}

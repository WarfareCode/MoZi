using System;
using System.Collections;
using ns13;

namespace ns14
{
	// Token: 0x02000446 RID: 1094
	public sealed class Class620 : Class619
	{
		// Token: 0x06001BF9 RID: 7161 RVA: 0x00011883 File Offset: 0x0000FA83
		public override void vmethod_0(IList ilist_0, Class647 class647_0, bool bool_0)
		{
			if (bool_0)
			{
				this.method_1(ilist_0, null);
			}
			else
			{
				this.method_0(ilist_0);
			}
			this.method_4(class647_0);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x000118A3 File Offset: 0x0000FAA3
		public override void vmethod_1(IList ilist_0, IList ilist_1, Class647 class647_0)
		{
			this.method_1(ilist_0, ilist_0);
			this.method_1(ilist_1, ilist_1);
			this.method_4(class647_0);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x000B38C0 File Offset: 0x000B1AC0
		private void method_0(IList ilist_0)
		{
			IEnumerator enumerator = ilist_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class581 @class = (Class581)enumerator.Current;
				this.method_2(@class, @class);
			}
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x000B38F4 File Offset: 0x000B1AF4
		private void method_1(IList ilist_0, object object_0)
		{
			IEnumerator enumerator = ilist_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class581 class581_ = (Class581)enumerator.Current;
				this.method_2(class581_, object_0);
			}
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x000B3928 File Offset: 0x000B1B28
		private void method_2(Class581 class581_0, object object_0)
		{
			Class621 @class = class581_0.method_8();
			int[] array = @class.method_0();
			for (int i = 0; i < array.Length - 1; i++)
			{
				Class648 object_ = new Class648(@class, i);
				Class618 class2 = new Class618(object_0, @class.method_1(i), null, object_);
				this.arrayList_0.Add(class2);
				this.arrayList_0.Add(new Class618(object_0, @class.method_2(i), class2, object_));
			}
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x000B3998 File Offset: 0x000B1B98
		private void method_3()
		{
			this.arrayList_0.Sort();
			for (int i = 0; i < this.arrayList_0.Count; i++)
			{
				Class618 @class = (Class618)this.arrayList_0[i];
				if (@class.method_2())
				{
					@class.method_3().method_5(i);
				}
			}
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x000B39F4 File Offset: 0x000B1BF4
		private void method_4(Class647 class647_0)
		{
			this.int_0 = 0;
			this.method_3();
			for (int i = 0; i < this.arrayList_0.Count; i++)
			{
				Class618 @class = (Class618)this.arrayList_0[i];
				if (@class.method_1())
				{
					this.method_5(i, @class.method_4(), @class, class647_0);
				}
			}
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x000B3A54 File Offset: 0x000B1C54
		private void method_5(int int_1, int int_2, Class618 class618_0, Class647 class647_0)
		{
			Class648 @class = (Class648)class618_0.method_6();
			for (int i = int_1; i < int_2; i++)
			{
				Class618 class2 = (Class618)this.arrayList_0[i];
				if (class2.method_1())
				{
					Class648 class648_ = (Class648)class2.method_6();
					if (class618_0.method_0() == null || class618_0.method_0() != class2.method_0())
					{
						@class.method_0(class648_, class647_0);
						this.int_0++;
					}
				}
			}
		}

		// Token: 0x04000C22 RID: 3106
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x04000C23 RID: 3107
		private int int_0;
	}
}

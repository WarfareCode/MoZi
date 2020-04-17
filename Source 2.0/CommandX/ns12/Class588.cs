using System;
using System.Collections;
using GeoAPI.Geometries;
using ns13;
using ns14;

namespace ns12
{
	// Token: 0x02000384 RID: 900
	public sealed class Class588
	{
		// Token: 0x060015A7 RID: 5543 RVA: 0x0008C060 File Offset: 0x0008A260
		public IList method_0(IEnumerator ienumerator_0)
		{
			IList list = new ArrayList();
			while (ienumerator_0.MoveNext())
			{
				Class581 class581_ = (Class581)ienumerator_0.Current;
				this.method_1(class581_, list);
			}
			return list;
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x0008C094 File Offset: 0x0008A294
		public void method_1(Class581 class581_0, IList ilist_0)
		{
			Class622 @class = class581_0.method_7();
			@class.method_2();
			IEnumerator enumerator = @class.method_1();
			Class649 class2 = null;
			if (enumerator.MoveNext())
			{
				Class649 class3 = (Class649)enumerator.Current;
				do
				{
					Class649 class649_ = class2;
					class2 = class3;
					class3 = null;
					if (enumerator.MoveNext())
					{
						class3 = (Class649)enumerator.Current;
					}
					if (class2 != null)
					{
						this.method_2(class581_0, ilist_0, class2, class649_);
						this.method_3(class581_0, ilist_0, class2, class3);
					}
				}
				while (class2 != null);
			}
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0008C118 File Offset: 0x0008A318
		public void method_2(Class581 class581_0, IList ilist_0, Class649 class649_0, Class649 class649_1)
		{
			int num = class649_0.method_1();
			if (class649_0.method_2() == 0.0)
			{
				if (num == 0)
				{
					return;
				}
				num--;
			}
			ICoordinate icoordinate_ = class581_0.method_6(num);
			if (class649_1 != null && class649_1.method_1() >= num)
			{
				icoordinate_ = class649_1.method_0();
			}
			Class652 @class = new Class652(class581_0.method_0());
			@class.method_0();
			Class573 value = new Class573(class581_0, class649_0.method_0(), icoordinate_, @class);
			ilist_0.Add(value);
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x0008C19C File Offset: 0x0008A39C
		public void method_3(Class581 class581_0, IList ilist_0, Class649 class649_0, Class649 class649_1)
		{
			int num = class649_0.method_1() + 1;
			if (num < class581_0.method_4() || class649_1 != null)
			{
				ICoordinate icoordinate_ = class581_0.method_6(num);
				if (class649_1 != null && class649_1.method_1() == class649_0.method_1())
				{
					icoordinate_ = class649_1.method_0();
				}
				Class573 value = new Class573(class581_0, class649_0.method_0(), icoordinate_, new Class652(class581_0.method_0()));
				ilist_0.Add(value);
			}
		}
	}
}

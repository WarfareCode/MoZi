using System;
using System.Collections;
using DotSpatial.Topology;
using ns24;
using ns25;

namespace ns26
{
	// Token: 0x02000793 RID: 1939
	public sealed class Class2327
	{
		// Token: 0x06003019 RID: 12313 RVA: 0x00109700 File Offset: 0x00107900
		public  IList vmethod_0(IEnumerator ienumerator_0)
		{
			IList list = new ArrayList();
			while (ienumerator_0.MoveNext())
			{
				Class2199 class2199_ = (Class2199)ienumerator_0.Current;
				this.vmethod_1(class2199_, list);
			}
			return list;
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x00109734 File Offset: 0x00107934
		public  void vmethod_1(Class2199 class2199_0, IList ilist_0)
		{
			Class2203 @class = class2199_0.vmethod_12();
			@class.vmethod_3();
			IEnumerator enumerator = @class.vmethod_1();
			Class2202 class2 = null;
			if (enumerator.MoveNext())
			{
				Class2202 class3 = (Class2202)enumerator.Current;
				do
				{
					Class2202 class2202_ = class2;
					class2 = class3;
					class3 = null;
					if (enumerator.MoveNext())
					{
						class3 = (Class2202)enumerator.Current;
					}
					if (class2 != null)
					{
						this.vmethod_2(class2199_0, ilist_0, class2, class2202_);
						this.vmethod_3(class2199_0, ilist_0, class2, class3);
					}
				}
				while (class2 != null);
			}
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x001097B8 File Offset: 0x001079B8
		public  void vmethod_2(Class2199 class2199_0, IList ilist_0, Class2202 class2202_0, Class2202 class2202_1)
		{
			int num = class2202_0.vmethod_1();
			if (class2202_0.vmethod_2() == 0.0)
			{
				if (num == 0)
				{
					return;
				}
				num--;
			}
			Coordinate coordinate_ = class2199_0.vmethod_16(num);
			if (class2202_1 != null && class2202_1.vmethod_1() >= num)
			{
				coordinate_ = class2202_1.vmethod_0();
			}
			Class2217 @class = new Class2217(class2199_0.vmethod_0());
			@class.vmethod_0();
			Class2192 value = new Class2192(class2199_0, class2202_0.vmethod_0(), coordinate_, @class);
			ilist_0.Add(value);
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x0010983C File Offset: 0x00107A3C
		public  void vmethod_3(Class2199 class2199_0, IList ilist_0, Class2202 class2202_0, Class2202 class2202_1)
		{
			int num = class2202_0.vmethod_1() + 1;
			if (num < class2199_0.vmethod_7() || class2202_1 != null)
			{
				Coordinate coordinate_ = class2199_0.vmethod_16(num);
				if (class2202_1 != null && class2202_1.vmethod_1() == class2202_0.vmethod_1())
				{
					coordinate_ = class2202_1.vmethod_0();
				}
				Class2192 value = new Class2192(class2199_0, class2202_0.vmethod_0(), coordinate_, new Class2217(class2199_0.vmethod_0()));
				ilist_0.Add(value);
			}
		}
	}
}

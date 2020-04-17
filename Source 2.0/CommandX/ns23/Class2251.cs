using System;
using System.Collections;

namespace ns23
{
	// Token: 0x0200065A RID: 1626
	public sealed class Class2251
	{
		// Token: 0x06002978 RID: 10616 RVA: 0x00016B14 File Offset: 0x00014D14
		public Class2251()
		{
			this.class2256_0 = new Class2256();
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000FD72C File Offset: 0x000FB92C
		public static Class2252 smethod_0(Class2252 class2252_0, double double_1)
		{
			double num = class2252_0.vmethod_0();
			double num2 = class2252_0.vmethod_2();
			Class2252 result;
			if (num != num2)
			{
				result = class2252_0;
			}
			else
			{
				if (num == num2)
				{
					num -= double_1 / 2.0;
					num2 = num + double_1 / 2.0;
				}
				result = new Class2252(num, num2);
			}
			return result;
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000FD780 File Offset: 0x000FB980
		public  void vmethod_0(Class2252 class2252_0, object object_0)
		{
			this.method_0(class2252_0);
			Class2252 class2252_ = Class2251.smethod_0(class2252_0, this.double_0);
			this.class2256_0.vmethod_3(class2252_, object_0);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000FD7B0 File Offset: 0x000FB9B0
		public  IList vmethod_1(Class2252 class2252_0)
		{
			IList list = new ArrayList();
			this.vmethod_2(class2252_0, list);
			return list;
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00016B36 File Offset: 0x00014D36
		public  void vmethod_2(Class2252 class2252_0, IList ilist_0)
		{
			this.class2256_0.vmethod_1(class2252_0, ilist_0);
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x000FD7D0 File Offset: 0x000FB9D0
		private void method_0(Class2252 class2252_0)
		{
			double num = class2252_0.vmethod_4();
			if (num < this.double_0 && num > 0.0)
			{
				this.double_0 = num;
			}
		}

		// Token: 0x040013EC RID: 5100
		private readonly Class2256 class2256_0;

		// Token: 0x040013ED RID: 5101
		private double double_0 = 1.0;
	}
}

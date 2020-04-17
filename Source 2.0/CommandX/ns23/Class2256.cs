using System;
using ns28;

namespace ns23
{
	// Token: 0x02000660 RID: 1632
	public sealed class Class2256 : Class2254
	{
		// Token: 0x060029A7 RID: 10663 RVA: 0x000FDC78 File Offset: 0x000FBE78
		public  void vmethod_3(Class2252 class2252_0, object object_0)
		{
			int num = Class2254.smethod_0(class2252_0, 0.0);
			if (num == -1)
			{
				this.vmethod_0(object_0);
			}
			else
			{
				Class2255 @class = this.Nodes[num];
				if (@class == null || !@class.vmethod_3().vmethod_8(class2252_0))
				{
					Class2255 class2 = Class2255.smethod_2(@class, class2252_0);
					this.Nodes[num] = class2;
				}
				Class2256.smethod_1(this.Nodes[num], class2252_0, object_0);
			}
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x000FDCE4 File Offset: 0x000FBEE4
		private static void smethod_1(Class2255 class2255_1, Class2252 class2252_0, object object_0)
		{
			Class2347.smethod_0(class2255_1.vmethod_3().vmethod_8(class2252_0));
			Class2254 @class;
			if (Class2263.smethod_0(class2252_0.vmethod_0(), class2252_0.vmethod_2()))
			{
				@class = class2255_1.vmethod_5(class2252_0);
			}
			else
			{
				@class = class2255_1.vmethod_4(class2252_0);
			}
			@class.vmethod_0(object_0);
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x0000945D File Offset: 0x0000765D
		protected override bool vmethod_2(Class2252 class2252_0)
		{
			return true;
		}
	}
}

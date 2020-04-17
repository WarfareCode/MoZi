using System;
using System.Collections;
using ns23;
using ns25;

namespace ns27
{
	// Token: 0x020006D1 RID: 1745
	public sealed class Class2285 : Interface47
	{
		// Token: 0x06002BDB RID: 11227 RVA: 0x00101018 File Offset: 0x000FF218
		public IList imethod_1()
		{
			return this.ilist_0;
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x00101030 File Offset: 0x000FF230
		public void imethod_0(IList ilist_1)
		{
			int[] array = new int[1];
			this.ilist_0 = ilist_1;
			int num = 0;
			int num2 = -1;
			do
			{
				this.method_0(this.ilist_0, array);
				num++;
				int num3 = array[0];
				if (num2 > 0 && num3 >= num2 && num > this.int_0)
				{
					goto IL_4E;
				}
				num2 = num3;
			}
			while (num2 > 0);
			return;
			IL_4E:
			throw new TopologyException("Iterated noding failed to converge after " + num + " iterations");
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x001010A8 File Offset: 0x000FF2A8
		private void method_0(IList ilist_1, int[] int_1)
		{
			Class2283 @class = new Class2283(this.class2239_0);
			Class2287 class2 = new Class2287(@class);
			class2.imethod_0(ilist_1);
			this.ilist_0 = class2.imethod_1();
			int_1[0] = @class.int_0;
		}

		// Token: 0x040014B8 RID: 5304
		private readonly LineIntersector class2239_0;

		// Token: 0x040014B9 RID: 5305
		private int int_0;

		// Token: 0x040014BA RID: 5306
		private IList ilist_0;
	}
}

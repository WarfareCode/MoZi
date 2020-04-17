using System;
using System.Collections;

namespace ns12
{
	// Token: 0x020003B2 RID: 946
	public abstract class Class603
	{
		// Token: 0x06001775 RID: 6005 RVA: 0x0000FC6D File Offset: 0x0000DE6D
		public Class603(int int_1)
		{
			Class570.smethod_0(int_1 > 1, "Node capacity must be greater than 1");
			this.int_0 = int_1;
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x000928BC File Offset: 0x00090ABC
		protected int method_0(double double_0, double double_1)
		{
			return (double_0 > double_1) ? 1 : ((double_0 < double_1) ? -1 : 0);
		}

		// Token: 0x040009A7 RID: 2471
		private bool bool_0 = false;

		// Token: 0x040009A8 RID: 2472
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x040009A9 RID: 2473
		private int int_0;

		// Token: 0x020003B3 RID: 947
		protected interface Interface22
		{
		}
	}
}

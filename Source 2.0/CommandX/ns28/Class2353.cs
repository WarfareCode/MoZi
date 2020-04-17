using System;
using System.Collections.Generic;
using ClipperLib;

namespace ns28
{
	// Token: 0x02000805 RID: 2053
	public sealed class Class2353
	{
		// Token: 0x060032B9 RID: 12985 RVA: 0x00118CD0 File Offset: 0x00116ED0
		public int method_0()
		{
			return this.list_1.Count;
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x00118CEC File Offset: 0x00116EEC
		internal void method_1(Class2353 class2353_1)
		{
			int count = this.list_1.Count;
			this.list_1.Add(class2353_1);
			class2353_1.class2353_0 = this;
			class2353_1.int_0 = count;
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x00118D20 File Offset: 0x00116F20
		public List<Class2353> method_2()
		{
			return this.list_1;
		}

		// Token: 0x04001798 RID: 6040
		internal Class2353 class2353_0;

		// Token: 0x04001799 RID: 6041
		internal List<IntPoint> list_0 = new List<IntPoint>();

		// Token: 0x0400179A RID: 6042
		internal int int_0;

		// Token: 0x0400179B RID: 6043
		internal Enum165 enum165_0;

		// Token: 0x0400179C RID: 6044
		internal Enum166 enum166_0;

		// Token: 0x0400179D RID: 6045
		internal List<Class2353> list_1 = new List<Class2353>();
	}
}

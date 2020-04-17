using System;

namespace ns29
{
	// Token: 0x02000215 RID: 533
	public sealed class Class2385 : ICloneable
	{
		// Token: 0x06000C89 RID: 3209 RVA: 0x0000A7B4 File Offset: 0x000089B4
		public Class2385()
		{
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0000A7D1 File Offset: 0x000089D1
		public Class2385(Class2385 class2385_0)
		{
			this.int_0 = class2385_0.method_0();
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00079834 File Offset: 0x00077A34
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0007984C File Offset: 0x00077A4C
		object ICloneable.Clone()
		{
			return new Class2385(this);
		}

		// Token: 0x04000567 RID: 1383
		private int int_0 = 5;

		// Token: 0x04000568 RID: 1384
		private double[,] double_0 = null;

		// Token: 0x04000569 RID: 1385
		private float[,] float_0 = null;
	}
}

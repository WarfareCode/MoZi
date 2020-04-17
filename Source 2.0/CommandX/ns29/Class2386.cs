using System;

namespace ns29
{
	// Token: 0x0200021B RID: 539
	public sealed class Class2386 : ICloneable
	{
		// Token: 0x06000CA6 RID: 3238 RVA: 0x0000A8F3 File Offset: 0x00008AF3
		public Class2386()
		{
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0000A903 File Offset: 0x00008B03
		public Class2386(Class2386 class2386_0)
		{
			this.int_0 = class2386_0.int_0;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000799D4 File Offset: 0x00077BD4
		object ICloneable.Clone()
		{
			return new Class2386(this);
		}

		// Token: 0x04000572 RID: 1394
		private int int_0 = 100;
	}
}

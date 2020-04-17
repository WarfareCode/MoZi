using System;
using ns15;

namespace ns23
{
	// Token: 0x02000680 RID: 1664
	public sealed class Class2261 : ICloneable
	{
		// Token: 0x06002A52 RID: 10834 RVA: 0x000171C0 File Offset: 0x000153C0
		public Class2261(Class2177 class2177_2, Class2177 class2177_3)
		{
			this.class2177_1 = Class835.smethod_0<Class2177>(class2177_2);
			this.class2177_0 = Class835.smethod_0<Class2177>(class2177_3);
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x000FE898 File Offset: 0x000FCA98
		public object Clone()
		{
			return new Class2261(this.class2177_1, this.class2177_0);
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x000FE8B8 File Offset: 0x000FCAB8
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				this.class2177_1,
				"\n",
				this.class2177_0,
				"\n"
			});
		}

		// Token: 0x04001432 RID: 5170
		internal Class2177 class2177_0;

		// Token: 0x04001433 RID: 5171
		internal Class2177 class2177_1;
	}
}

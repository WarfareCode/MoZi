using System;
using System.Collections;
using ns12;
using ns14;

namespace ns13
{
	// Token: 0x020003E7 RID: 999
	public sealed class Class625 : Class624
	{
		// Token: 0x060018E5 RID: 6373 RVA: 0x0009946C File Offset: 0x0009766C
		public override void vmethod_0(Class573 class573_0)
		{
			Class574 @class = (Class574)this.idictionary_0[class573_0];
			if (@class == null)
			{
				@class = new Class574(class573_0);
				base.method_0(class573_0, @class);
			}
			else
			{
				@class.method_8(class573_0);
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x000994AC File Offset: 0x000976AC
		public void method_6(Class666 class666_0)
		{
			IEnumerator enumerator = base.method_1();
			while (enumerator.MoveNext())
			{
				Class574 @class = (Class574)enumerator.Current;
				@class.method_12(class666_0);
			}
		}
	}
}

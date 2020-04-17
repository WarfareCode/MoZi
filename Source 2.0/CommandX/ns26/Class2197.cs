using System;
using ns24;

namespace ns26
{
	// Token: 0x02000795 RID: 1941
	public sealed class Class2197 : Class2195
	{
		// Token: 0x06003026 RID: 12326 RVA: 0x00109A68 File Offset: 0x00107C68
		public override void vmethod_3(Class2192 class2192_0)
		{
			Class2194 @class = (Class2194)base.method_0()[class2192_0];
			if (@class == null)
			{
				@class = new Class2194(class2192_0);
				base.method_2(class2192_0, @class);
			}
			else
			{
				@class.method_1(class2192_0);
			}
		}
	}
}

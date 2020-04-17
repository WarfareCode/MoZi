using System;

namespace ns15
{
	// Token: 0x02000646 RID: 1606
	internal static class Class835
	{
		// Token: 0x060028D2 RID: 10450 RVA: 0x000F76D4 File Offset: 0x000F58D4
		public static T smethod_0<T>(T gparam_0) where T : class, ICloneable
		{
			T result;
			if (gparam_0 != null)
			{
				result = (gparam_0.Clone() as T);
			}
			else
			{
				result = default(T);
			}
			return result;
		}
	}
}

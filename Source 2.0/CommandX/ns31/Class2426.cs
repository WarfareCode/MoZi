using System;
using System.Collections.Generic;

namespace ns31
{
	// Token: 0x0200048F RID: 1167
	internal static class Class2426
	{
		// Token: 0x06001E24 RID: 7716 RVA: 0x000C2E04 File Offset: 0x000C1004
		public static T smethod_0<T, K>(IDictionary<K, T> idictionary_0, K gparam_0)
		{
			T t;
			T result;
			if (idictionary_0.TryGetValue(gparam_0, out t))
			{
				result = t;
			}
			else
			{
				result = default(T);
			}
			return result;
		}
	}
}

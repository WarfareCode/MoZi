using System;
using System.Collections.Generic;

namespace DiskQueue.Implementation
{
	// Token: 0x02000009 RID: 9
	public static class Extensions
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00055AA0 File Offset: 0x00053CA0
		public static T GetOrCreateValue<T, K>(this IDictionary<K, T> self, K key) where T : new()
		{
			T t;
			if (!self.TryGetValue(key, out t))
			{
				t = ((default(T) == null) ? Activator.CreateInstance<T>() : default(T));
				self.Add(key, t);
			}
			return t;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00055AE4 File Offset: 0x00053CE4
		public static T GetValueOrDefault<T, K>(this IDictionary<K, T> self, K key)
		{
			T t;
			return (!self.TryGetValue(key, out t)) ? default(T) : t;
		}
	}
}

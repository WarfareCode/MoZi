using System;
using System.Collections.Generic;

namespace ns24
{
	// Token: 0x02000522 RID: 1314
	internal static class EnumerableExt
	{
		// Token: 0x060021DB RID: 8667 RVA: 0x000DCA64 File Offset: 0x000DAC64
		public static List<T> CloneList<T>(IEnumerable<T> ienumerable_0) where T : ICloneable
		{
			List<T> list = new List<T>();
			foreach (T current in ienumerable_0)
			{
				list.Add(EnumerableExt.SafeCastTo<T>(current.Clone()));
			}
			return list;
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x000DCACC File Offset: 0x000DACCC
		private static T SafeCastTo<T>(object obj)
		{
			T result;
			if (obj == null)
			{
				result = default(T);
			}
			else if (!(obj is T))
			{
				result = default(T);
			}
			else
			{
				result = (T)((object)obj);
			}
			return result;
		}
	}
}

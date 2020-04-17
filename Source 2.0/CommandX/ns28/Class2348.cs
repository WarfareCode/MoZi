using System;
using System.Collections;

namespace ns28
{
	// Token: 0x020007FB RID: 2043
	public sealed class Class2348
	{
		// Token: 0x0600323E RID: 12862 RVA: 0x0010D99C File Offset: 0x0010BB9C
		public static IList smethod_0(ICollection icollection_0, Class2348.Delegate38<object> delegate38_0)
		{
			IList list = new ArrayList();
			foreach (object current in icollection_0)
			{
				list.Add(delegate38_0(current));
			}
			return list;
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x0010DA04 File Offset: 0x0010BC04
		public static void smethod_1(ICollection icollection_0, Class2348.Delegate38<object> delegate38_0)
		{
			foreach (object current in icollection_0)
			{
				delegate38_0(current);
			}
		}

		// Token: 0x020007FC RID: 2044
		// (Invoke) Token: 0x06003242 RID: 12866
		public delegate T Delegate38<T>(T obj);
	}
}

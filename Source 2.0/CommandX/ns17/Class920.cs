using System;
using System.Threading;

namespace ns17
{
	// Token: 0x020006EA RID: 1770
	public sealed class Class920
	{
		// Token: 0x06002C4B RID: 11339 RVA: 0x00101CB0 File Offset: 0x000FFEB0
		public static Thread smethod_0(ThreadStart threadStart_0)
		{
			return new Thread(threadStart_0);
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x00101CC8 File Offset: 0x000FFEC8
		public static Thread smethod_1(ParameterizedThreadStart parameterizedThreadStart_0)
		{
			return new Thread(parameterizedThreadStart_0);
		}
	}
}

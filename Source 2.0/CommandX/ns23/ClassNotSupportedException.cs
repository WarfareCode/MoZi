using System;
using ns25;

namespace ns23
{
	// Token: 0x02000650 RID: 1616
	public sealed class ClassNotSupportedException : Exception
	{
		// Token: 0x0600296A RID: 10602 RVA: 0x00016AB7 File Offset: 0x00014CB7
		public ClassNotSupportedException(string string_0) : base(TopologyText.GetClassNotSupportedException_S().Replace("%S", string_0))
		{
		}
	}
}

using System;
using ns25;

namespace ns27
{
	// Token: 0x020006D0 RID: 1744
	public sealed class Exception24 : Exception
	{
		// Token: 0x06002BDA RID: 11226 RVA: 0x00017D70 File Offset: 0x00015F70
		public Exception24(string string_0) : base(TopologyText.GetInvalidOctantException_S().Replace("%S", string_0))
		{
		}
	}
}

using System;
using ns25;

namespace ns24
{
	// Token: 0x02000525 RID: 1317
	public sealed class Exception17 : ArgumentException
	{
		// Token: 0x060021E5 RID: 8677 RVA: 0x000141B1 File Offset: 0x000123B1
		public Exception17() : base(TopologyText.GetInsufficientDimensions())
		{
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000141BE File Offset: 0x000123BE
		public Exception17(string string_0) : base(TopologyText.GetInsufficientDimensions_S().Replace("%S", string_0))
		{
		}
	}
}

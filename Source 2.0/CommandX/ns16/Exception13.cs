using System;

namespace ns16
{
	// Token: 0x020004BD RID: 1213
	public class Exception13 : Exception
	{
		// Token: 0x06001FAB RID: 8107 RVA: 0x000130AA File Offset: 0x000112AA
		public Exception13(string string_1) : base(string_1)
		{
			this.exception_0 = null;
			this.string_0 = string_1;
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x000130C1 File Offset: 0x000112C1
		public Exception13(Exception exception_1) : base("", exception_1)
		{
			this.exception_0 = exception_1;
			this.string_0 = exception_1.Message;
		}

		// Token: 0x04000F03 RID: 3843
		protected Exception exception_0;

		// Token: 0x04000F04 RID: 3844
		protected string string_0;
	}
}

using System;

namespace ns32
{
	// Token: 0x020004E5 RID: 1253
	public sealed class Class2457
	{
		// Token: 0x060020AD RID: 8365 RVA: 0x000D4FAC File Offset: 0x000D31AC
		public void method_0(string string_0)
		{
			if (this.delegate47_0 != null)
			{
				EventArgs7 e = new EventArgs7(string_0);
				this.delegate47_0(this, e);
			}
		}

		// Token: 0x04000FD3 RID: 4051
		public Delegate47 delegate47_0;
	}
}

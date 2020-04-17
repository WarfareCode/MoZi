using System;
using System.Threading;
using System.Windows.Forms;

namespace ns35
{
	// Token: 0x02000AF2 RID: 2802
	public sealed class Class2526 : IDisposable
	{
		// Token: 0x06005A7B RID: 23163 RVA: 0x002829E0 File Offset: 0x00280BE0
		public Class2526() : this(Guid.NewGuid().ToString())
		{
		}

		// Token: 0x06005A7C RID: 23164 RVA: 0x00028AB2 File Offset: 0x00026CB2
		public Class2526(string string_1) : this(string_1, 2048)
		{
		}

		// Token: 0x06005A7D RID: 23165 RVA: 0x00282A08 File Offset: 0x00280C08
		public Class2526(string string_1, int int_1)
		{
			this.control_0 = new Control();
			this.manualResetEvent_0 = new ManualResetEvent(false);
			this.manualResetEvent_1 = new ManualResetEvent(false);
			this.bool_0 = false;
			this.int_0 = int_1;
			this.string_0 = string_1;
			this.control_0.CreateControl();
		}

		// Token: 0x06005A7E RID: 23166 RVA: 0x00028AC0 File Offset: 0x00026CC0
		public void Dispose()
		{
			this.vmethod_0(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06005A7F RID: 23167 RVA: 0x00028ACF File Offset: 0x00026CCF
		protected  void vmethod_0(bool bool_1)
		{
			this.bool_0 = true;
		}

		// Token: 0x04002CE5 RID: 11493
		private Control control_0;

		// Token: 0x04002CE6 RID: 11494
		private ManualResetEvent manualResetEvent_0;

		// Token: 0x04002CE7 RID: 11495
		private ManualResetEvent manualResetEvent_1;

		// Token: 0x04002CE8 RID: 11496
		private int int_0;

		// Token: 0x04002CE9 RID: 11497
		private string string_0;

		// Token: 0x04002CEA RID: 11498
		private bool bool_0;
	}
}

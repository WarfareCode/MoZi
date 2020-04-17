using System;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace ns35
{
	// Token: 0x02000AF1 RID: 2801
	public sealed class Class2525 : IDisposable
	{
		// Token: 0x06005A78 RID: 23160 RVA: 0x00028A73 File Offset: 0x00026C73
		public void Dispose()
		{
			this.vmethod_0(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x00028A82 File Offset: 0x00026C82
		protected  void vmethod_0(bool bool_1)
		{
			if (!this.bool_0 && bool_1)
			{
				this.safeFileHandle_0.Close();
				this.stream_0.Dispose();
			}
			this.bool_0 = true;
		}

		// Token: 0x04002CE2 RID: 11490
		private SafeFileHandle safeFileHandle_0;

		// Token: 0x04002CE3 RID: 11491
		private Stream stream_0;

		// Token: 0x04002CE4 RID: 11492
		private bool bool_0;
	}
}

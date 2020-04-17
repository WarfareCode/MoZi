using System;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x02000C75 RID: 3189
	public sealed class Class383
	{
		// Token: 0x06006A06 RID: 27142 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class383()
		{
		}

		// Token: 0x06006A07 RID: 27143
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr LocalFree(IntPtr intptr_0);

		// Token: 0x02000C76 RID: 3190
		internal struct Struct43 : IDisposable
		{
			// Token: 0x06006A08 RID: 27144 RVA: 0x0002DA62 File Offset: 0x0002BC62
			public void Dispose()
			{
				if (this.intptr_1 != IntPtr.Zero)
				{
					Class383.LocalFree(this.intptr_1);
					this.intptr_1 = IntPtr.Zero;
				}
			}

			// Token: 0x04003BC2 RID: 15298
			public IntPtr intptr_0;

			// Token: 0x04003BC3 RID: 15299
			public int int_0;

			// Token: 0x04003BC4 RID: 15300
			public IntPtr intptr_1;
		}
	}
}

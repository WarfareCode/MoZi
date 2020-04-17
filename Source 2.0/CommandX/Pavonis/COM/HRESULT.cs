using System;
using System.Runtime.InteropServices;

namespace Pavonis.COM
{
	// Token: 0x02001073 RID: 4211
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	internal struct HRESULT
	{
		// Token: 0x04004E5F RID: 20063
		public const int S_OK = 0;

		// Token: 0x04004E60 RID: 20064
		public const int S_FALSE = 1;

		// Token: 0x04004E61 RID: 20065
		public const int E_PENDING = -2147483638;

		// Token: 0x04004E62 RID: 20066
		public const int E_NOTIMPL = -2147467263;

		// Token: 0x04004E63 RID: 20067
		public const int E_NOINTERFACE = -2147467262;

		// Token: 0x04004E64 RID: 20068
		public const int E_POINTER = -2147467261;

		// Token: 0x04004E65 RID: 20069
		public const int E_ABORT = -2147467260;

		// Token: 0x04004E66 RID: 20070
		public const int E_FAIL = -2147467259;

		// Token: 0x04004E67 RID: 20071
		public const int E_ACCESSDENIED = -2147024890;

		// Token: 0x04004E68 RID: 20072
		public const int E_HANDLE = -2147024890;

		// Token: 0x04004E69 RID: 20073
		public const int E_INVALIDARG = -2147024809;

		// Token: 0x04004E6A RID: 20074
		public const int E_UNEXPECTED = -2147418113;
	}
}

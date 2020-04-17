using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000D14 RID: 3348
	[DefaultMember("ConnectionString"), CompilerGenerated, Guid("00001550-0000-0010-8000-00AA006D2EA4"), TypeIdentifier]
	[ComImport]
	public interface _Connection : Connection15, _ADO
	{
		// Token: 0x06007345 RID: 29509
		void _VtblGap1_8();

		// Token: 0x06007346 RID: 29510
		[DispId(5)]
		void Close();

		// Token: 0x06007347 RID: 29511
		void _VtblGap2_4();

		// Token: 0x06007348 RID: 29512
		[DispId(10)]
		void Open([MarshalAs(UnmanagedType.BStr)] [In] string ConnectionString = "", [MarshalAs(UnmanagedType.BStr)] [In] string UserID = "", [MarshalAs(UnmanagedType.BStr)] [In] string Password = "", [In] int Options = -1);
	}
}

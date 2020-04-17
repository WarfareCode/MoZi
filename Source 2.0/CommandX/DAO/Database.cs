using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DAO
{
	// Token: 0x02000CFC RID: 3324
	[DefaultMember("TableDefs"), CompilerGenerated, Guid("00000071-0000-0010-8000-00AA006D2EA4"), TypeIdentifier]
	[ComImport]
	public interface Database : _DAO
	{
		// Token: 0x0600732E RID: 29486
		void _VtblGap1_10();

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600732F RID: 29487
		TableDefs TableDefs
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		// Token: 0x06007330 RID: 29488
		void _VtblGap2_4();

		// Token: 0x06007331 RID: 29489
		[DispId(1610809358)]
		void Close();

		// Token: 0x06007332 RID: 29490
		void _VtblGap3_24();

		// Token: 0x06007333 RID: 29491
		[DispId(1610809383)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Recordset OpenRecordset([MarshalAs(UnmanagedType.BStr)] [In] string Name, [MarshalAs(UnmanagedType.Struct)] [In] object Type = null, [MarshalAs(UnmanagedType.Struct)] [In] object Options = null, [MarshalAs(UnmanagedType.Struct)] [In] object LockEdit = null);
	}
}

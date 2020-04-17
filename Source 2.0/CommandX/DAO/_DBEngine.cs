using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DAO
{
	// Token: 0x02000CF9 RID: 3321
	[DefaultMember("Workspaces"), CompilerGenerated, Guid("00000021-0000-0010-8000-00AA006D2EA4"), TypeIdentifier]
	[ComImport]
	public interface _DBEngine : _DAO
	{
		// Token: 0x06007325 RID: 29477
		void _VtblGap1_15();

		// Token: 0x06007326 RID: 29478
		[DispId(1610809358)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Database OpenDatabase([MarshalAs(UnmanagedType.BStr)] [In] string Name, [MarshalAs(UnmanagedType.Struct)] [In] object Options = null, [MarshalAs(UnmanagedType.Struct)] [In] object ReadOnly = null, [MarshalAs(UnmanagedType.Struct)] [In] object Connect = null);
	}
}

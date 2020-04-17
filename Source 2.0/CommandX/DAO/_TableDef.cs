using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DAO
{
	// Token: 0x02000D1A RID: 3354
	[DefaultMember("Fields"), CompilerGenerated, Guid("00000049-0000-0010-8000-00AA006D2EA4"), TypeIdentifier]
	[ComImport]
	public interface _TableDef : _DAO
	{
		// Token: 0x0600734C RID: 29516
		void _VtblGap1_7();

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x0600734D RID: 29517
		// (set) Token: 0x0600734E RID: 29518
		string Name
		{
			[DispId(1610809350)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1610809350)]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}
	}
}

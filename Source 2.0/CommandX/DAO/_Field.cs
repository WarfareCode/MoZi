using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DAO
{
	// Token: 0x02000D10 RID: 3344
	[DefaultMember("Value"), CompilerGenerated, Guid("00000051-0000-0010-8000-00AA006D2EA4"), TypeIdentifier]
	[ComImport]
	public interface _Field : _DAO
	{
		// Token: 0x0600733C RID: 29500
		void _VtblGap1_10();

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600733D RID: 29501
		// (set) Token: 0x0600733E RID: 29502
		object Value
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.Struct)]
			get;
			[DispId(0)]
			[param: MarshalAs(UnmanagedType.Struct)]
			set;
		}
	}
}

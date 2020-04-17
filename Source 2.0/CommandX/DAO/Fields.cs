using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DAO
{
	// Token: 0x02000D0C RID: 3340
	[CompilerGenerated, Guid("00000053-0000-0010-8000-00AA006D2EA4"), TypeIdentifier]
	[ComImport]
	public interface Fields : IEnumerable, _DynaCollection, _Collection
	{
		// Token: 0x0600733A RID: 29498
		void _VtblGap1_5();

		// Token: 0x17000526 RID: 1318
		Field this[[MarshalAs(UnmanagedType.Struct)] [In] object Item]
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}
	}
}

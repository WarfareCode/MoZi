using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADOX
{
	// Token: 0x02000D1C RID: 3356
	[DefaultMember("Columns"), CompilerGenerated, Guid("00000610-0000-0010-8000-00AA006D2EA4"), TypeIdentifier]
	[ComImport]
	public interface _Table
	{
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x0600734F RID: 29519
		Columns Columns
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06007350 RID: 29520
		// (set) Token: 0x06007351 RID: 29521
		string Name
		{
			[DispId(1)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1)]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}
	}
}

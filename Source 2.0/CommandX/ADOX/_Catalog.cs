using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADOX
{
	// Token: 0x02000D12 RID: 3346
	[DefaultMember("Tables"), CompilerGenerated, Guid("00000603-0000-0010-8000-00AA006D2EA4"), TypeIdentifier]
	[ComImport]
	public interface _Catalog
	{
		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600733F RID: 29503
		Tables Tables
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06007340 RID: 29504
		// (set) Token: 0x06007342 RID: 29506
		object ActiveConnection
		{
			[DispId(1)]
			[return: MarshalAs(UnmanagedType.Struct)]
			get;
			[DispId(1)]
			[param: MarshalAs(UnmanagedType.IDispatch)]
			set;
		}

		// Token: 0x06007341 RID: 29505
		void _VtblGap1_1();

		// Token: 0x06007343 RID: 29507
		void _VtblGap2_4();

		// Token: 0x06007344 RID: 29508
		[DispId(6)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object Create([MarshalAs(UnmanagedType.BStr)] [In] string ConnectString);
	}
}

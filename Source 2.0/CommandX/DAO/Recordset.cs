using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DAO
{
	// Token: 0x02000CFB RID: 3323
	[DefaultMember("Fields"), CompilerGenerated, Guid("00000031-0000-0010-8000-00AA006D2EA4"), TypeIdentifier]
	[ComImport]
	public interface Recordset : _DAO
	{
		// Token: 0x06007327 RID: 29479
		void _VtblGap1_38();

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06007328 RID: 29480
		Fields Fields
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		// Token: 0x06007329 RID: 29481
		void _VtblGap2_2();

		// Token: 0x0600732A RID: 29482
		[DispId(132)]
		void AddNew();

		// Token: 0x0600732B RID: 29483
		[DispId(133)]
		void Close();

		// Token: 0x0600732C RID: 29484
		void _VtblGap3_39();

		// Token: 0x0600732D RID: 29485
		[DispId(168)]
		void Update([In] int UpdateType = 1, [In] bool Force = false);
	}
}

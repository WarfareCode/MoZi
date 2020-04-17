using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADOX
{
	// Token: 0x02000D1E RID: 3358
	[DefaultMember("Name"), CompilerGenerated, Guid("0000061C-0000-0010-8000-00AA006D2EA4"), TypeIdentifier]
	[ComImport]
	public interface _Column
	{
		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06007352 RID: 29522
		// (set) Token: 0x06007353 RID: 29523
		string Name
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(0)]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06007354 RID: 29524
		// (set) Token: 0x06007355 RID: 29525
		ColumnAttributesEnum Attributes
		{
			[DispId(1)]
			get;
			[DispId(1)]
			set;
		}

		// Token: 0x06007356 RID: 29526
		void _VtblGap1_10();

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06007357 RID: 29527
		// (set) Token: 0x06007358 RID: 29528
		DataTypeEnum Type
		{
			[DispId(8)]
			get;
			[DispId(8)]
			set;
		}
	}
}

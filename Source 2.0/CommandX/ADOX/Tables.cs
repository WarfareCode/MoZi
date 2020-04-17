using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADOX
{
	// Token: 0x02000D23 RID: 3363
	[DefaultMember("Item"), CompilerGenerated, Guid("00000611-0000-0010-8000-00AA006D2EA4"), TypeIdentifier]
	[ComImport]
	public interface Tables : IEnumerable, _Collection
	{
		// Token: 0x0600735B RID: 29531
		void _VtblGap1_4();

		// Token: 0x0600735C RID: 29532
		[DispId(1610809345)]
		void Append([MarshalAs(UnmanagedType.Struct)] [In] object Item);
	}
}

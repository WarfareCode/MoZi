using System;
using System.Runtime.InteropServices;

namespace Pavonis.COM.IOleCommandTarget
{
	// Token: 0x02001077 RID: 4215
	[ComVisible(true), Guid("b722bccb-4e68-101b-a2bc-00aa00404770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	internal interface IOleCommandTarget
	{
		// Token: 0x06009566 RID: 38246
		[PreserveSig]
		int QueryStatus(ref Guid pguidCmdGroup, uint cCmds, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] OLECMD prgCmds, ref IntPtr pCmdText);

		// Token: 0x06009567 RID: 38247
		[PreserveSig]
		int Exec(ref Guid pguidCmdGroup, uint nCmdID, uint nCmdExecOpt, ref object pvaIn, ref object pvaOut);
	}
}

using System;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using ns17;

namespace ns19
{
	// Token: 0x0200043D RID: 1085
	public sealed class Class1983
	{
		// Token: 0x06001BCE RID: 7118
		[DllImport("winhttp.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern IntPtr WinHttpOpen(string string_0, int int_0, IntPtr intptr_1, IntPtr intptr_2, int int_1);

		// Token: 0x06001BCF RID: 7119
		[DllImport("winhttp.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		private static extern bool WinHttpGetProxyForUrl(IntPtr intptr_1, string string_0, ref Class1983.Struct65 struct65_0, ref Class1983.Struct66 struct66_0);

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class1983()
		{
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00011793 File Offset: 0x0000F993
		private static bool smethod_0(string string_0)
		{
			return string_0 == null || string_0.Length == 0;
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000117A4 File Offset: 0x0000F9A4
		private static void smethod_1()
		{
			Class1983.intptr_0 = Class1983.WinHttpOpen("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322)", 0, IntPtr.Zero, IntPtr.Zero, 0);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x000B26DC File Offset: 0x000B08DC
		private static ICredentials smethod_2(string string_0, string string_1, string string_2)
		{
			ICredentials result = null;
			if (!Class1983.smethod_0(string_0))
			{
				result = ((string_2 == null) ? new NetworkCredential(string_0, string_1) : new NetworkCredential(string_0, string_1, string_2));
			}
			return result;
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x000B270C File Offset: 0x000B090C
		private static IWebProxy smethod_3(string string_0, string string_1, ref int int_0)
		{
			if (Class1983.intptr_0 == IntPtr.Zero)
			{
				Class1983.smethod_1();
			}
			Class1983.Struct65 @struct = default(Class1983.Struct65);
			Class1983.Struct66 struct2 = default(Class1983.Struct66);
			struct2.intptr_0 = (struct2.intptr_1 = IntPtr.Zero);
			if (!Class1983.smethod_0(string_1))
			{
				@struct.int_0 = 2;
				@struct.string_0 = string_1;
				@struct.int_1 = 0;
			}
			else
			{
				@struct.int_0 = 1;
				@struct.int_1 = 3;
			}
			@struct.bool_0 = true;
			if (!Class1983.WinHttpGetProxyForUrl(Class1983.intptr_0, string_0, ref @struct, ref struct2))
			{
				int_0 = Marshal.GetLastWin32Error();
			}
			string text = "";
			if (struct2.intptr_0 != IntPtr.Zero)
			{
				text = Marshal.PtrToStringUni(struct2.intptr_0);
				Marshal.FreeHGlobal(struct2.intptr_0);
				text = text.Split(new char[]
				{
					';'
				})[0].Replace("PROXY ", "").Trim();
			}
			if (struct2.intptr_1 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(struct2.intptr_1);
			}
			IWebProxy result;
			if (!Class1983.smethod_0(text))
			{
				result = new WebProxy(text);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x000B2848 File Offset: 0x000B0A48
		public static IWebProxy smethod_4(string string_0, bool bool_0, bool bool_1, string string_1, string string_2, string string_3)
		{
			IWebProxy webProxy;
			if (bool_0)
			{
				webProxy = WebRequest.DefaultWebProxy;
			}
			else if (bool_1)
			{
				int num = 0;
				webProxy = Class1983.smethod_3(string_0, string_1, ref num);
				if (num != 0)
				{
					throw new Exception(string.Format(CultureInfo.CurrentCulture, "Determining dynamic proxy for target url '{0}' using script url '{1}' failed with Win32 error '{2}'", new object[]
					{
						string_0,
						Class1983.smethod_0(string_1) ? "(none)" : string_1,
						Class921.smethod_0(num)
					}));
				}
			}
			else if (Class1983.smethod_0(string_1))
			{
				webProxy = null;
			}
			else
			{
				webProxy = new WebProxy(string_1);
			}
			if (webProxy != null)
			{
				webProxy.Credentials = Class1983.smethod_2(string_2, string_3, null);
			}
			return webProxy;
		}

		// Token: 0x04000BF3 RID: 3059
		private static IntPtr intptr_0 = IntPtr.Zero;

		// Token: 0x0200043E RID: 1086
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct Struct65
		{
			// Token: 0x04000BF4 RID: 3060
			[MarshalAs(UnmanagedType.U4)]
			public int int_0;

			// Token: 0x04000BF5 RID: 3061
			[MarshalAs(UnmanagedType.U4)]
			public int int_1;

			// Token: 0x04000BF6 RID: 3062
			public string string_0;

			// Token: 0x04000BF7 RID: 3063
			public IntPtr intptr_0;

			// Token: 0x04000BF8 RID: 3064
			[MarshalAs(UnmanagedType.U4)]
			public int int_2;

			// Token: 0x04000BF9 RID: 3065
			public bool bool_0;
		}

		// Token: 0x0200043F RID: 1087
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct Struct66
		{
			// Token: 0x04000BFA RID: 3066
			[MarshalAs(UnmanagedType.U4)]
			public int int_0;

			// Token: 0x04000BFB RID: 3067
			public IntPtr intptr_0;

			// Token: 0x04000BFC RID: 3068
			public IntPtr intptr_1;
		}
	}
}

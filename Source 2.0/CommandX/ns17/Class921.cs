using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace ns17
{
	// Token: 0x020006EC RID: 1772
	public sealed class Class921
	{
		// Token: 0x06002C57 RID: 11351 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class921()
		{
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x00101E9C File Offset: 0x0010009C
		static Class921()
		{
			Class921.arrayList_0.Add(new Class921.Class922(12000, 12184, "winhttp"));
			Class921.arrayList_0.Add(new Class921.Class922(2100, 2999, "netmsg.dll"));
		}

		// Token: 0x06002C59 RID: 11353
		[DllImport("kernel32.dll")]
		private static extern IntPtr LoadLibraryEx(string string_0, int[] int_0, uint uint_0);

		// Token: 0x06002C5A RID: 11354
		[DllImport("kernel32.dll")]
		private static extern int FreeLibrary(IntPtr intptr_0);

		// Token: 0x06002C5B RID: 11355
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int FormatMessage(int dwFlags, IntPtr lpSource, int dwMessageId, int dwLanguageId, out IntPtr MsgBuffer, int nSize, IntPtr Arguments);

		// Token: 0x06002C5C RID: 11356 RVA: 0x00101EF4 File Offset: 0x001000F4
		public static string smethod_0(int int_0)
		{
			IntPtr intPtr = IntPtr.Zero;
			string result = string.Format("Last Win32 Error #{0:X8}", int_0);
			int num = 4864;
			foreach (Class921.Class922 @class in Class921.arrayList_0)
			{
				if (int_0 >= @class.int_0 && int_0 <= @class.int_1)
				{
					intPtr = Class921.LoadLibraryEx(@class.string_0, null, 2u);
					if (intPtr != IntPtr.Zero)
					{
						num |= 2048;
					}
					break;
				}
			}
			IntPtr intPtr2;
			if (Class921.FormatMessage(num, intPtr, int_0, 1024, out intPtr2, 0, IntPtr.Zero) > 0)
			{
				result = Marshal.PtrToStringUni(intPtr2);
				Marshal.FreeHGlobal(intPtr2);
			}
			if (intPtr != IntPtr.Zero)
			{
				Class921.FreeLibrary(intPtr);
			}
			return result;
		}

		// Token: 0x040014F6 RID: 5366
		private static ArrayList arrayList_0 = new ArrayList();

		// Token: 0x020006ED RID: 1773
		public sealed class Class922
		{
			// Token: 0x06002C5D RID: 11357 RVA: 0x00018080 File Offset: 0x00016280
			public Class922(int int_2, int int_3, string string_1)
			{
				this.int_0 = int_2;
				this.int_1 = int_3;
				this.string_0 = string_1;
			}

			// Token: 0x040014F7 RID: 5367
			public int int_0;

			// Token: 0x040014F8 RID: 5368
			public int int_1;

			// Token: 0x040014F9 RID: 5369
			public string string_0;
		}
	}
}

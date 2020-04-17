using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ns15
{
	// Token: 0x02000640 RID: 1600
	public sealed class Class831
	{
		// Token: 0x060028BF RID: 10431 RVA: 0x00004A21 File Offset: 0x00002C21
		private Class831()
		{
		}

		// Token: 0x060028C0 RID: 10432
		[DllImport("uxtheme")]
		public static extern int SetWindowTheme(IntPtr hwnd, [MarshalAs(UnmanagedType.LPWStr)] string pszSubAppName, [MarshalAs(UnmanagedType.LPWStr)] string pszSubIdList);

		// Token: 0x060028C1 RID: 10433
		[DllImport("uxtheme")]
		public static extern IntPtr GetWindowTheme(IntPtr intptr_0);

		// Token: 0x060028C2 RID: 10434
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x060028C3 RID: 10435
		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		public static extern IntPtr SendMessage_1(IntPtr intptr_0, int int_0, IntPtr intptr_1, ref Class831.Struct60 struct60_0);

		// Token: 0x060028C4 RID: 10436
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.I4)]
		public static extern int DrawState(IntPtr hdc, IntPtr hbr, IntPtr lpOutputFunc, IntPtr lData, IntPtr wData, int x, int y, int cx, int cy, int fuFlags);

		// Token: 0x060028C5 RID: 10437
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.I4)]
		public static extern int DrawText(IntPtr hDC, string lpString, int nCount, ref Class831.Struct61 lpRect, Class831.Enum148 uFormat);

		// Token: 0x060028C6 RID: 10438
		[DllImport("gdi32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

		// Token: 0x060028C7 RID: 10439
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleDC(IntPtr intptr_0);

		// Token: 0x060028C8 RID: 10440
		[DllImport("gdi32.dll")]
		public static extern int SetTextColor(IntPtr intptr_0, int int_0);

		// Token: 0x060028C9 RID: 10441
		[DllImport("gdi32.dll")]
		public static extern int SetBkMode(IntPtr intptr_0, int int_0);

		// Token: 0x060028CA RID: 10442
		[DllImport("gdi32.dll")]
		public static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x060028CB RID: 10443
		[DllImport("gdi32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteObject(IntPtr hObject);

		// Token: 0x060028CC RID: 10444
		[DllImport("gdi32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteDC(IntPtr hdc);

		// Token: 0x060028CD RID: 10445
		[DllImport("gdi32.dll")]
		public static extern int SetLayout(IntPtr intptr_0, int int_0);

		// Token: 0x02000641 RID: 1601
		[Flags]
		public enum Enum146
		{
			// Token: 0x04001372 RID: 4978
			flag_0 = 1,
			// Token: 0x04001373 RID: 4979
			flag_1 = 2,
			// Token: 0x04001374 RID: 4980
			flag_2 = 4,
			// Token: 0x04001375 RID: 4981
			flag_3 = 6
		}

		// Token: 0x02000642 RID: 1602
		[Flags]
		public enum Enum147
		{
			// Token: 0x04001377 RID: 4983
			flag_0 = 0,
			// Token: 0x04001378 RID: 4984
			flag_1 = 1,
			// Token: 0x04001379 RID: 4985
			flag_2 = 2,
			// Token: 0x0400137A RID: 4986
			flag_3 = 3,
			// Token: 0x0400137B RID: 4987
			flag_4 = 4,
			// Token: 0x0400137C RID: 4988
			flag_5 = 32,
			// Token: 0x0400137D RID: 4989
			flag_6 = 512,
			// Token: 0x0400137E RID: 4990
			flag_7 = 32768,
			// Token: 0x0400137F RID: 4991
			flag_8 = 131072
		}

		// Token: 0x02000643 RID: 1603
		[Flags]
		public enum Enum148
		{
			// Token: 0x04001381 RID: 4993
			flag_0 = 0,
			// Token: 0x04001382 RID: 4994
			flag_1 = 0,
			// Token: 0x04001383 RID: 4995
			flag_2 = 1,
			// Token: 0x04001384 RID: 4996
			flag_3 = 2,
			// Token: 0x04001385 RID: 4997
			flag_4 = 4,
			// Token: 0x04001386 RID: 4998
			flag_5 = 8,
			// Token: 0x04001387 RID: 4999
			flag_6 = 16,
			// Token: 0x04001388 RID: 5000
			flag_7 = 32,
			// Token: 0x04001389 RID: 5001
			flag_8 = 64,
			// Token: 0x0400138A RID: 5002
			flag_9 = 128,
			// Token: 0x0400138B RID: 5003
			flag_10 = 256,
			// Token: 0x0400138C RID: 5004
			flag_11 = 512,
			// Token: 0x0400138D RID: 5005
			flag_12 = 1024,
			// Token: 0x0400138E RID: 5006
			flag_13 = 2048,
			// Token: 0x0400138F RID: 5007
			flag_14 = 4096,
			// Token: 0x04001390 RID: 5008
			flag_15 = 1048576
		}

		// Token: 0x02000644 RID: 1604
		public struct Struct60
		{
			// Token: 0x060028CE RID: 10446 RVA: 0x000167C7 File Offset: 0x000149C7
			public Struct60(int int_0, int int_1)
			{
				this.point_0 = new Point(int_0, int_1);
				this.enum146_0 = Class831.Enum146.flag_3;
			}

			// Token: 0x04001391 RID: 5009
			public Point point_0;

			// Token: 0x04001392 RID: 5010
			public Class831.Enum146 enum146_0;
		}

		// Token: 0x02000645 RID: 1605
		public struct Struct61
		{
			// Token: 0x060028CF RID: 10447 RVA: 0x000F767C File Offset: 0x000F587C
			public int method_0()
			{
				return this.int_3 - this.int_1;
			}

			// Token: 0x060028D0 RID: 10448 RVA: 0x000F7698 File Offset: 0x000F5898
			public int method_1()
			{
				return this.int_2 - this.int_0;
			}

			// Token: 0x060028D1 RID: 10449 RVA: 0x000F76B4 File Offset: 0x000F58B4
			public Size method_2()
			{
				return new Size(this.method_1(), this.method_0());
			}

			// Token: 0x04001393 RID: 5011
			public int int_0;

			// Token: 0x04001394 RID: 5012
			public int int_1;

			// Token: 0x04001395 RID: 5013
			public int int_2;

			// Token: 0x04001396 RID: 5014
			public int int_3;
		}
	}
}

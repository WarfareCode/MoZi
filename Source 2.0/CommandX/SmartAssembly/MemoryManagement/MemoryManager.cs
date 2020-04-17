using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartAssembly.MemoryManagement
{
	// Token: 0x0200127C RID: 4732
	public sealed class MemoryManager
	{
		// Token: 0x0600A6D4 RID: 42708
		[DllImport("kernel32")]
		private static extern int SetProcessWorkingSetSize(IntPtr intptr_0, int int_0, int int_1);

		// Token: 0x0600A6D5 RID: 42709 RVA: 0x004DED54 File Offset: 0x004DCF54
		private void method_0()
		{
			try
			{
				using (Process currentProcess = Process.GetCurrentProcess())
				{
					MemoryManager.SetProcessWorkingSetSize(currentProcess.Handle, -1, -1);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600A6D6 RID: 42710 RVA: 0x004DEDA4 File Offset: 0x004DCFA4
		private void method_1(object sender, EventArgs e)
		{
			try
			{
				long ticks = DateTime.Now.Ticks;
				if (ticks - this.long_0 > 10000000L)
				{
					this.long_0 = ticks;
					this.method_0();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600A6D7 RID: 42711 RVA: 0x004DEDF4 File Offset: 0x004DCFF4
		private MemoryManager()
		{
			Application.Idle += new EventHandler(this.method_1);
			this.method_0();
		}

		// Token: 0x0600A6D8 RID: 42712 RVA: 0x004DEE34 File Offset: 0x004DD034
		public static void AttachApp()
		{
			try
			{
				if (Environment.OSVersion.Platform == PlatformID.Win32NT)
				{
					MemoryManager.memoryManager_0 = new MemoryManager();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0400564F RID: 22095
		private static MemoryManager memoryManager_0;

		// Token: 0x04005650 RID: 22096
		private long long_0 = DateTime.Now.Ticks;
	}
}

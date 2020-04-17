using System;
using System.Threading;
using System.Windows.Forms;

namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x0200052D RID: 1325
	internal static class Program
	{
		// Token: 0x06002210 RID: 8720 RVA: 0x000DD210 File Offset: 0x000DB410
		[STAThread]
		private static void Main_()
		{
			string name = string.Format("{0}-{1}-{2}-SingleInstance", Application.CompanyName, Application.ProductName, Application.ProductVersion);
			bool flag = false;
            // ZSP ERR Program.onlyOneAppMutex = new Mutex(true, name, ref flag);
            Program.onlyOneAppMutex = new Mutex(true, name, out flag);
            if (!flag)
			{
				MessageBox.Show("Another instance is already running.");
			}
			else
			{
				if (!Program.IsValidOs())
				{
					throw new InvalidOperationException(string.Format("This application does not run on {0}. Works on Vista and latter", Environment.OSVersion.VersionString));
				}
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new AppContext());
			}
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x000142D0 File Offset: 0x000124D0
		private static bool IsValidOs()
		{
			return Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6;
		}

		// Token: 0x0400108F RID: 4239
		private static Mutex onlyOneAppMutex;
	}
}

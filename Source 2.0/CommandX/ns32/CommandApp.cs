using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns33;
using ns4;
using ns6;

namespace ns32
{
	// Token: 0x02000523 RID: 1315
	[GeneratedCode("MyTemplate", "11.0.0.0"), EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class CommandApp : WindowsFormsApplicationBase
	{
		// Token: 0x060021DD RID: 8669 RVA: 0x0001415D File Offset: 0x0001235D
		[EditorBrowsable(EditorBrowsableState.Advanced), STAThread]
		[MethodImpl(MethodImplOptions.NoOptimization)]
		internal static void Main(string[] args)
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			CommandFactory.GetCommandApp().Run(args);
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x00004BC2 File Offset: 0x00002DC2
		private void CommandApp_NetworkAvailabilityChanged(object sender, NetworkAvailableEventArgs e)
		{
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x00014174 File Offset: 0x00012374
		private void CommandApp_Shutdown(object sender, EventArgs e)
		{
			Client.CancelAsync();
			SimConfiguration.SaveConfig();
			Terrain.Close();
			SteamSession.Shutdown();
			if (PowerSchemeManager.Win32NTVersion6Above())
			{
				PowerSchemeManager.RestorePowerScheme();
			}
			Environment.Exit(0);
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000DCB10 File Offset: 0x000DAD10
		private void CommandApp_Startup(object sender, StartupEventArgs e)
		{
			checked
			{
				try
				{
					Client.smethod_30(CommandFactory.GetCommandApp().Info.DirectoryPath.Contains("steamapps\\common"));

                    str = CommandFactory.GetCommandApp().Info.DirectoryPath + "\\force_steam";
                    if (File.Exists(str))
					{
						Client.smethod_30(true);
					}
					if (Client.smethod_29())
					{
						SteamSession.Init();
						if (!SteamSession.bool_0)
						{
							Interaction.MsgBox("It appears you are running Command in Steam mode, but the Steam client does not appear to be running. Please ensure the Steam client is running before starting Command. The game will now exit.", MsgBoxStyle.OkCancel, "Steam client not running!");
							Environment.Exit(0);
						}
					}
					try
					{
						Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 200358", ex2.Message);
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
					}
					Process[] processes = Process.GetProcesses();
					string processName = Process.GetCurrentProcess().ProcessName;
					DateTime startTime = Process.GetCurrentProcess().StartTime;
					Process[] array = processes;
					for (int i = 0; i < array.Length; i++)
					{
						Process process = array[i];
						if (Operators.CompareString(process.ProcessName, processName, false) == 0 && DateTime.Compare(process.StartTime, startTime) != 0)
						{
							process.Kill();
						}
					}
					if (File.Exists(GameGeneral.strTempDir + "\\instance"))
					{
						Interaction.MsgBox("Only one Instance of the application is allowed!!!", MsgBoxStyle.OkOnly, null);
						Environment.Exit(0);
					}
					else
					{
						File.Create(GameGeneral.strTempDir + "\\instance", 10, FileOptions.DeleteOnClose);
					}
					if (Screen.PrimaryScreen.BitsPerPixel != 32)
					{
						Interaction.MsgBox("Please set your screen's color depth to 32-bit and restart Command.", MsgBoxStyle.OkOnly, null);
						Environment.Exit(0);
					}
					this.InitWorldWindow();
					UnhandledExceptionHandler targetObject = new UnhandledExceptionHandler();
					CommandFactory.GetCommandApp().UnhandledException += new Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventHandler(targetObject.HandleException);
					CommandFactory.GetCommandMain().GetMainSplash().Show();
					CommandFactory.GetCommandApp().DoEvents();
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ex4.Data.Add("Error at 200575", ex4.Message);
					GameGeneral.LogException(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					Interaction.MsgBox("Error found during application startup. Error details: " + ex4.Message, MsgBoxStyle.OkOnly, "Error in Application_Startup!");
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x000DCD88 File Offset: 0x000DAF88
		private void InitWorldWindow()
		{
			try
			{
				Client.m_WorldWindow = new WorldWindow();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("The program will now abort. Error details: " + ex2.Message, MsgBoxStyle.OkOnly, "Error in initializing 3D graphics!");
				Application.Exit();
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000DCDE4 File Offset: 0x000DAFE4
		public CommandApp() : base(AuthenticationMode.Windows)
		{
			base.NetworkAvailabilityChanged += new NetworkAvailableEventHandler(this.CommandApp_NetworkAvailabilityChanged);
			base.Shutdown += new ShutdownEventHandler(this.CommandApp_Shutdown);
			base.Startup += new StartupEventHandler(this.CommandApp_Startup);
			base.IsSingleInstance = false;
			base.EnableVisualStyles = true;
			base.SaveMySettingsOnExit = true;
			base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x0001419F File Offset: 0x0001239F
		protected override void OnCreateMainForm()
		{
			base.MainForm = CommandFactory.GetCommandMain().GetMainForm();
		}
        private string str;

    }
}

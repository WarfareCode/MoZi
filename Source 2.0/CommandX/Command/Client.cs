using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Command_Core;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns16;
using ns2;
using ns3;
using ns32;
using ns33;
using ns34;
using ns35;
using ns4;
using ns6;

namespace Command
{
	// Token: 0x020005F9 RID: 1529
	public sealed class Client
	{
		// Token: 0x060026A2 RID: 9890 RVA: 0x000EABB4 File Offset: 0x000E8DB4
		[CompilerGenerated]
		public static Configuration GetConfiguration()
		{
			return Client.m_Configuration;
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x00015CAC File Offset: 0x00013EAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public static void SetConfiguration(Configuration value)
		{
			Client.m_Configuration = value;
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x000EABC8 File Offset: 0x000E8DC8
		[CompilerGenerated]
		private static Scenario GetScenario()
		{
			return Client.m_Scenario;
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00015CB4 File Offset: 0x00013EB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void SetScenario(Scenario value)
		{
			Client.m_Scenario = value;
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x000EABDC File Offset: 0x000E8DDC
		[CompilerGenerated]
		private static Side GetSide()
		{
			return Client.m_Side;
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00015CBC File Offset: 0x00013EBC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void SetSide(Side value)
		{
			Client.m_Side = value;
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x000EABF0 File Offset: 0x000E8DF0
		[CompilerGenerated]
		private static System.Windows.Forms.Timer GetScenarioProgressTimer()
		{
			return Client.ScenarioProgressTimer;
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x000EAC04 File Offset: 0x000E8E04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void SetScenarioProgressTimer(System.Windows.Forms.Timer timer_2)
		{
			EventHandler value = new EventHandler(Client.ScenarioProgressTimer_Click);
			System.Windows.Forms.Timer scenarioProgressTimer = Client.ScenarioProgressTimer;
			if (scenarioProgressTimer != null)
			{
				scenarioProgressTimer.Tick -= value;
			}
			Client.ScenarioProgressTimer = timer_2;
			scenarioProgressTimer = Client.ScenarioProgressTimer;
			if (scenarioProgressTimer != null)
			{
				scenarioProgressTimer.Tick += value;
			}
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x000EAC4C File Offset: 0x000E8E4C
		[CompilerGenerated]
		private static System.Windows.Forms.Timer smethod_8()
		{
			return Client.timer_1;
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x000EAC60 File Offset: 0x000E8E60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void smethod_9(System.Windows.Forms.Timer timer_2)
		{
			EventHandler value = new EventHandler(Client.TimerEventHandle);
			System.Windows.Forms.Timer timer = Client.timer_1;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			Client.timer_1 = timer_2;
			timer = Client.timer_1;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x00015CC4 File Offset: 0x00013EC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
        //private static void smethod_10(BackgroundWorker backgroundWorker_2)
        //ZSP BackGround
        private static void smethod_10(BackgroundWorker bg_Worker)
		{
			Client.Client_backgroundWorker_0 = bg_Worker;
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x000EACA8 File Offset: 0x000E8EA8
		[CompilerGenerated]
		private static BackgroundWorker GetEventScheduler()
		{
			return Client.SimEventScheduler;
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x000EACBC File Offset: 0x000E8EBC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void SetEventScheduler(BackgroundWorker backgroundWorker_2)
		{
            // 事件句柄
			DoWorkEventHandler value = new DoWorkEventHandler(Client.EventScheduler_DoWork);
			RunWorkerCompletedEventHandler value2 = new RunWorkerCompletedEventHandler(Client.EventScheduler_RunWorkerCompleted);
			BackgroundWorker simEventScheduler = Client.SimEventScheduler;
			if (simEventScheduler != null)
			{
				simEventScheduler.DoWork -= value;
				simEventScheduler.RunWorkerCompleted -= value2;
			}
			Client.SimEventScheduler = backgroundWorker_2;
			simEventScheduler = Client.SimEventScheduler;
			if (simEventScheduler != null)
			{
				simEventScheduler.DoWork += value;
				simEventScheduler.RunWorkerCompleted += value2;
			}
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x000EAD20 File Offset: 0x000E8F20
		[CompilerGenerated]
		public static void smethod_13(Client.Delegate49 delegate49_1)
		{
			Client.Delegate49 @delegate = Client.delegate49_0;
			Client.Delegate49 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate49 value = (Client.Delegate49)Delegate.Combine(delegate2, delegate49_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate49>(ref Client.delegate49_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x000EAD58 File Offset: 0x000E8F58
		[CompilerGenerated]
		public static void smethod_14(Client.Delegate49 delegate49_1)
		{
			Client.Delegate49 @delegate = Client.delegate49_0;
			Client.Delegate49 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate49 value = (Client.Delegate49)Delegate.Remove(delegate2, delegate49_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate49>(ref Client.delegate49_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x000EAD90 File Offset: 0x000E8F90
		[CompilerGenerated]
		public static void smethod_15(Client.Delegate50 delegate50_1)
		{
			Client.Delegate50 @delegate = Client.delegate50_0;
			Client.Delegate50 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate50 value = (Client.Delegate50)Delegate.Combine(delegate2, delegate50_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate50>(ref Client.delegate50_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x000EADC8 File Offset: 0x000E8FC8
		[CompilerGenerated]
		public static void smethod_16(Client.Delegate50 delegate50_1)
		{
			Client.Delegate50 @delegate = Client.delegate50_0;
			Client.Delegate50 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate50 value = (Client.Delegate50)Delegate.Remove(delegate2, delegate50_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate50>(ref Client.delegate50_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x000EAE00 File Offset: 0x000E9000
		[CompilerGenerated]
		public static void smethod_17(Client.Delegate52 delegate52_1)
		{
			Client.Delegate52 @delegate = Client.delegate52_0;
			Client.Delegate52 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate52 value = (Client.Delegate52)Delegate.Combine(delegate2, delegate52_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate52>(ref Client.delegate52_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x000EAE38 File Offset: 0x000E9038
		[CompilerGenerated]
		public static void smethod_18(Client.Delegate52 delegate52_1)
		{
			Client.Delegate52 @delegate = Client.delegate52_0;
			Client.Delegate52 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate52 value = (Client.Delegate52)Delegate.Remove(delegate2, delegate52_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate52>(ref Client.delegate52_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x000EAE70 File Offset: 0x000E9070
		[CompilerGenerated]
		public static void smethod_19(Client.Delegate53 delegate53_1)
		{
			Client.Delegate53 @delegate = Client.delegate53_0;
			Client.Delegate53 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate53 value = (Client.Delegate53)Delegate.Combine(delegate2, delegate53_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate53>(ref Client.delegate53_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x000EAEA8 File Offset: 0x000E90A8
		[CompilerGenerated]
		public static void smethod_20(Client.Delegate53 delegate53_1)
		{
			Client.Delegate53 @delegate = Client.delegate53_0;
			Client.Delegate53 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate53 value = (Client.Delegate53)Delegate.Remove(delegate2, delegate53_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate53>(ref Client.delegate53_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x000EAEE0 File Offset: 0x000E90E0
		[CompilerGenerated]
		public static void smethod_21(Client.Delegate55 delegate55_1)
		{
			Client.Delegate55 @delegate = Client.delegate55_0;
			Client.Delegate55 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate55 value = (Client.Delegate55)Delegate.Combine(delegate2, delegate55_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate55>(ref Client.delegate55_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x000EAF18 File Offset: 0x000E9118
		[CompilerGenerated]
		public static void smethod_22(Client.Delegate55 delegate55_1)
		{
			Client.Delegate55 @delegate = Client.delegate55_0;
			Client.Delegate55 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate55 value = (Client.Delegate55)Delegate.Remove(delegate2, delegate55_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate55>(ref Client.delegate55_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x000EAF50 File Offset: 0x000E9150
		public static MissionEditor GetMissionEditor()
		{
			if (Information.IsNothing(Client.m_missionEditor))
			{
				Client.m_missionEditor = new MissionEditor();
			}
			return CommandFactory.GetCommandMain().GetMissionEditor();
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x000EAF84 File Offset: 0x000E9184
		public static AttackTarget GetAttackTarget()
		{
			if (Information.IsNothing(Client.m_attackTarget))
			{
				Client.m_attackTarget = new AttackTarget();
			}
			return Client.m_attackTarget;
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x00015CCC File Offset: 0x00013ECC
		public static void SetAttackTarget(AttackTarget attackTarget_1)
		{
			Client.m_attackTarget = attackTarget_1;
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x000EAFB4 File Offset: 0x000E91B4
		public static WeaponsWindow smethod_26()
		{
			return Client.lazy_WeaponsWindow.Value;
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x000EAFD0 File Offset: 0x000E91D0
		public static void Initialize()
		{
			try
			{
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "Initialization started.";
					GameGeneral.Log(ref text);
				}
				Client.SetScenarioProgressTimer(new System.Windows.Forms.Timer());
				Client.GetScenarioProgressTimer().Interval = 1000;
				Client.GetScenarioProgressTimer().Start();
				CommandFactory.GetCommandMain().GetMainForm().bitmap_2 = null;
				if (!Directory.Exists(Client.strSteamWorkshopScenarioDir))
				{
					Directory.CreateDirectory(Client.strSteamWorkshopScenarioDir);
				}
				if (!Directory.Exists(GameGeneral.strAttachmentRepoDir))
				{
					Directory.CreateDirectory(GameGeneral.strAttachmentRepoDir);
				}
				LicenseFile.Parse();
				GameGeneral.InitializeSimCore(GameGeneral.bProfessionEdition, LicenseFile.ProFeatures.Contains(LicenseFile.ProFeature.UnregisteredDB));
				if (GameGeneral.bProfessionEdition)
				{
					LicenseChecker.smethod_22();
				}
				LicenseChecker.smethod_0(Client.smethod_29());
				PlatformComponent.smethod_0(new PlatformComponent.Delegate21(Client.smethod_59));
				ActiveUnit_Damage.smethod_0(new ActiveUnit_Damage.Delegate1(Client.smethod_60));
				Scenario.AddCurrentSideChangedEventHandler(new Scenario.CurrentSideChangedEventHandler(Client.OnCurrentSideChanged));
				Scenario.AddSidesChangedEventHandler(new Scenario.SidesChangedEventHandler(Client.OnSidesChanged));
				Scenario.AddScenCompletedEventHandler(new Scenario.ScenCompletedEventHandler(Client.OnScenCompleted));
				Side.smethod_0(new Side.Delegate23(Client.SetScenCompleted));
				SAO_OverlaySingle.smethod_2(new SAO_OverlaySingle.Delegate8(Client.smethod_93));
				if (!Directory.Exists(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Logs"))
				{
					Directory.CreateDirectory(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Logs");
				}
				Class2531.smethod_0();
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "Successfully initialized Sim Core.";
					GameGeneral.Log(ref text);
				}
				if (PowerSchemeManager.Win32NTVersion6Above() && SimConfiguration.gameOptions.IsAllowPowerPlanSwitch())
				{
					PowerSchemeManager.smethod_0();
					if (SimConfiguration.gameOptions.LogDebugInfoToFile())
					{
						string text = "Successfully switched to High Performance power plan.";
						GameGeneral.Log(ref text);
					}
				}
				Class2524.smethod_2();
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "Successfully loaded Lua UI Handlers.";
					GameGeneral.Log(ref text);
				}
				Client.SetConfiguration(new Configuration());
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "Successfully created new game.";
					GameGeneral.Log(ref text);
				}
				string text2 = SimConfiguration.DefaultDB;
				if (Information.IsNothing(text2))
				{
					text2 = DBOps.GetDBRecordHash(1);
					SimConfiguration.DefaultDB = text2;
				}
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "Successfully set database hash value.";
					GameGeneral.Log(ref text);
				}
				if (Versioned.IsNumeric(text2))
				{
					text2 = DBOps.GetDBRecordHash(Conversions.ToInteger(text2));
				}
				Client.SetClientScenario(new Scenario(text2), false);
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "Successfully completed Set Current Scenario.";
					GameGeneral.Log(ref text);
				}
				Client.InitializeLua();
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "Successfully initialized Lua.";
					GameGeneral.Log(ref text);
				}
				Client.LastAutoSave = 20.0;
				Client.LoadSymbolsSet();
				Client.smethod_63();
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "Successfully created scenario.";
					GameGeneral.Log(ref text);
				}
				Client.SetEventScheduler(new BackgroundWorker());
				Client.GetEventScheduler().WorkerSupportsCancellation = true;
				Client.smethod_9(new System.Windows.Forms.Timer());
				Client.smethod_8().Interval = 30000;
				Client.smethod_8().Start();
				if (LicenseFile.ProFeatures.Contains(LicenseFile.ProFeature.EventExport))
				{
					EventExporters.Init();
				}
				File.SetLastWriteTimeUtc(Path.Combine(CommandFactory.GetCommandApp().Info.DirectoryPath, "CommandX.ini"), DateTime.UtcNow);
				if (SimConfiguration.gameOptions.LogDebugInfoToFile())
				{
					string text = "Initialization completed.";
					GameGeneral.Log(ref text);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200576", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000EB39C File Offset: 0x000E959C
		private static void InitializeLua()
		{
			try
			{
				Client.GetClientScenario().GetLuaSandBox();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("Failed to load Lua! Error: " + ex2.Message, MsgBoxStyle.Critical, null);
				Environment.Exit(0);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x00015CD4 File Offset: 0x00013ED4
		public static bool smethod_29()
		{
			return Client.bool_4;
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00015CDB File Offset: 0x00013EDB
		public static void smethod_30(bool bool_8)
		{
			Client.bool_4 = bool_8;
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x000EB3F8 File Offset: 0x000E95F8
		public static DBRecord GetDBRecord()
		{
			return Client.DBRecordUsed;
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x000EB40C File Offset: 0x000E960C
		public static void SetDBRecord(DBRecord NewDbrecord)
		{
			bool flag = NewDbrecord != Client.DBRecordUsed;
			DBRecord dBRecordUsed = Client.DBRecordUsed;
			Client.DBRecordUsed = NewDbrecord;
			if (flag)
			{
				Client.UpdateDBRecordUsed(dBRecordUsed);
			}
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x000EB440 File Offset: 0x000E9640
		internal static Unit smethod_33()
		{
			return Client.unit_0;
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x000EB454 File Offset: 0x000E9654
		internal static void ClientRefreshMap(Unit unit_)
		{
			bool flag;
			if (Information.IsNothing(Client.unit_0))
			{
				flag = !Information.IsNothing(unit_);
			}
			else
			{
				flag = (Client.unit_0 != unit_);
			}
			if (flag && !Information.IsNothing(Client.unit_0) && Client.unit_0.IsContact() && ((Contact)Client.unit_0).IsFilterOut)
			{
				Client.b_Completed = true;
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
			Client.unit_0 = unit_;
			if (flag)
			{
				CommandFactory.GetCommandMain().GetMainForm().method_19();
			}
			if (flag && !Information.IsNothing(Client.unit_0) && Client.unit_0.IsContact() && ((Contact)Client.unit_0).IsFilterOut)
			{
				Client.b_Completed = true;
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x00015CE3 File Offset: 0x00013EE3
		internal static bool IsRecorderStarted()
		{
			return Client.bRecorderStarted;
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x000EB534 File Offset: 0x000E9734
		internal static void StartRecord(bool bStarted)
		{
			Client.bRecorderStarted = bStarted;
			if (bStarted)
			{
				CommandFactory.GetCommandMain().GetMainForm().GetTSB_Record().Checked = true;
				CommandFactory.GetCommandMain().GetMainForm().GetTSB_Record().Text = "停止录像";
				CommandFactory.GetCommandMain().GetMainForm().GetTSB_Record().Image = Image.FromFile(Application.StartupPath + "\\Symbols\\Menu\\Stop.gif");
			}
			else
			{
				CommandFactory.GetCommandMain().GetMainForm().GetTSB_Record().Checked = false;
				CommandFactory.GetCommandMain().GetMainForm().GetTSB_Record().Text = "录像";
				CommandFactory.GetCommandMain().GetMainForm().GetTSB_Record().Image = Image.FromFile(Application.StartupPath + "\\Symbols\\Menu\\record_button.png");
			}
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x000EB5FC File Offset: 0x000E97FC
		public static Scenario GetClientScenario()
		{
			return Client.GetScenario();
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x000EB610 File Offset: 0x000E9810
		public static void SetClientScenario(Scenario scenario_, bool bGodEyeView)
		{
			try
			{
				Scenario scenario = Client.GetScenario();
				ConcurrentDictionary<int, Weapon> cache_Weapons = null;
				if (!Information.IsNothing(scenario))
				{
					cache_Weapons = scenario.Cache_Weapons;
				}
				bool flag = scenario_ != Client.GetScenario();
				Client.SetScenario(scenario_);
				bool isGodsEyeView = false;
				bool flag2;
				if (!Information.IsNothing(Client.GetClientSide()))
				{
					isGodsEyeView = Client.GetClientSide().GetMapProfile().IsGodsEyeView();
					flag2 = flag;
					if (!flag)
					{
						goto IL_6A;
					}
				}
				else
				{
					flag2 = flag;
					if (!flag)
					{
						goto IL_6A;
					}
				}
				if (bGodEyeView)
				{
					Client.GetScenario().Cache_Weapons = cache_Weapons;
				}
				IL_6A:
				Class260.concurrentDictionary_0.TryAdd(Client.GetScenario().GetObjectID(), Client.GetScenario());
				if (flag2)
				{
					Client.unitSensors = null;
					Client.damageControlWindow = null;
					Client.videoWindow = null;
                    //ZSP BackGround
                    Client.smethod_10(null);
					Client.newMission = null;
					Client.MessageTypeFormDictionary = null;
					Client.unitSensors = new UnitSensors();
					Client.damageControlWindow = new DamageControlWindow();
					Client.videoWindow = new VideoWindow();
                    //ZSP BackGround
                    Client.smethod_10(new BackgroundWorker());
					Client.newMission = new NewMission();
					Client.MessageTypeFormDictionary = new Dictionary<LoggedMessage.MessageType, NewMessageForm>();
					Client.LastAutoSave = 20000.0;
					Client.SetHookedUnit(true, null);
					if (!Information.IsNothing(Client.RenderableObjectList))
					{
						foreach (RenderableObject current in Client.RenderableObjectList)
						{
							Client.m_WorldWindow.method_2().GetRenderableObjectList().Remove(current.GetName());
						}
						Client.RenderableObjectList.Clear();
					}
					Client.RenderableObjectList = null;
					Client.queue_0 = null;
					Client.RenderableObjectList = new List<RenderableObject>();
					Client.queue_0 = new Queue<string>();
					Class260.smethod_0(scenario);
					scenario = null;
					DBOps.DBFileCheckResult dbfileCheckResult_ = DBOps.DBFileCheckResult.Undefined;
					Client.SetDBRecord(DBOps.GetDBRecord(Client.GetScenario().GetDBUsed(), ref dbfileCheckResult_, true, true));
					if (Information.IsNothing(Client.GetDBRecord()))
					{
						throw new Exception(DBOps.smethod_7(dbfileCheckResult_));
					}
					Configuration._GameMode gameMode = Client.GetConfiguration().GetGameMode();
					Client.SetConfiguration(new Configuration());
					Client.GetConfiguration().SetGameMode(gameMode);
					foreach (IEventExporter current2 in EventExporters.listRegular)
					{
						current2.StopExport();
						current2.StartExport();
					}
					if (Client.b_MainForm_Shown)
					{
						Client.GetClientScenario().SetTimeCompression(0);
					}
					if (!Information.IsNothing(Client.GetClientScenario()))
					{
						if (Information.IsNothing(Client.GetScenario().GetCurrentSide()))
						{
							if (Client.GetScenario().GetSides().Any<Side>())
							{
								Client.SetClientSide(Client.GetScenario().GetSides()[0]);
							}
						}
						else
						{
							Side currentSide = Client.GetScenario().GetCurrentSide();
							if (bGodEyeView)
							{
								currentSide.GetMapProfile().SetIsGodsEyeView(isGodsEyeView);
							}
							Client.SetClientSide(currentSide);
						}
						if (!Information.IsNothing(Client.GetClientSide()) && !bGodEyeView)
						{
							if (Client.GetClientSide().CameraAlt != 0.0)
							{
								CommandFactory.GetCommandMain().GetMainForm().method_6((int)Math.Round(Client.GetClientSide().CameraAlt));
							}
							if (!Information.IsNothing(Client.GetClientSide().GetMapCenter()))
							{
								CommandFactory.GetCommandMain().GetMainForm().method_14(true, Client.GetClientSide().GetMapCenter());
							}
						}
						else
						{
							Client.b_Completed = true;
						}
						try
						{
							if (Client.b_MainForm_Shown)
							{
								CommandFactory.GetCommandMain().GetMainForm().method_156();
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ex2.Data.Add("Error at 200359", ex2.Message);
							GameGeneral.LogException(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							ProjectData.ClearProjectError();
						}
						Client.Delegate49 @delegate = Client.delegate49_0;
						if (@delegate != null)
						{
							@delegate();
						}
						CommandFactory.GetCommandMain().GetLoadSaveProgress().Hide();
						if (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Run)
						{
							Client.GetConfiguration().SetSimStopMode();
						}
						Client.GetClientScenario().TriggerScenLoadedEvents();
						if (!bGodEyeView)
						{
							Scenario clientScenario = Client.GetClientScenario();
							string text = "";
							clientScenario.ZoneAreaCheck(false, ref text);
						}
						Application.DoEvents();
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 200516", ex4.Message);
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x000EBAB0 File Offset: 0x000E9CB0
		public static Side GetClientSide()
		{
			return Client.GetSide();
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x000EBAC4 File Offset: 0x000E9CC4
		public static void SetClientSide(Side side_1)
		{
			Side side = Client.GetSide();
			Client.SetSide(side_1);
			if (side != side_1)
			{
				Client.SetHookedUnit(true, null);
				if (!Information.IsNothing(side))
				{
					side.bool_8 = false;
				}
				if (!Information.IsNothing(side_1))
				{
					side_1.bool_8 = true;
					if (Client.GetConfiguration().GetGameMode() != Configuration._GameMode.Edit)
					{
						side_1.RemoveMissionSISIH(Client.GetClientScenario());
					}
					Client.smethod_42(side_1.GetMapProfile());
					CommandFactory.GetCommandMain().GetMainForm().method_261();
					CommandFactory.GetCommandMain().GetMainForm().method_262();
					Client.GetClientScenario().LogMessage("当前推演方为: " + side_1.GetSideName(), LoggedMessage.MessageType.UI, 0, null, null, null);
				}
				Client.IssueOrdersToUnit(Client._CommandOrder.None);
				Client.Delegate54 @delegate = Client.delegate54_0;
				if (@delegate != null)
				{
					@delegate();
				}
			}
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x000EBB88 File Offset: 0x000E9D88
		public static MapProfile GetMap()
		{
			if (Information.IsNothing(Client.mapProfile))
			{
				Client.mapProfile = MapProfile.GetDefaultMapProfile();
			}
			return Client.mapProfile;
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x00015CEA File Offset: 0x00013EEA
		public static void smethod_42(MapProfile MapProfile_)
		{
			Client.mapProfile = MapProfile_;
			CommandFactory.GetCommandMain().GetMainForm().RenderMap();
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x000EBBB8 File Offset: 0x000E9DB8
		public static Unit GetHookedUnit()
		{
			return Client.HookedUnit;
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x000EBBCC File Offset: 0x000E9DCC
		public static void SetHookedUnit(bool ThisUnitOnly, Unit value)
		{
			bool flag;
			if (flag = (Information.IsNothing(value) || Information.IsNothing(Client.HookedUnit) || Client.HookedUnit.GetGuid() != value.GetGuid()))
			{
				Client.Delegate52 @delegate = Client.delegate52_0;
				if (@delegate != null)
				{
					@delegate();
				}
			}
			Unit hookedUnit = Client.HookedUnit;
			Client.HookedUnit = value;
			if (flag)
			{
				Client.Delegate50 delegate2 = Client.delegate50_0;
				if (delegate2 != null)
				{
					delegate2(value);
				}
			}
			if (ThisUnitOnly && flag && Client.bool_7)
			{
				CommandFactory.GetCommandMain().GetMainForm().method_3().method_3(value, hookedUnit);
			}
			if (!Information.IsNothing(value) && CommandFactory.GetCommandMain().GetDBViewer().Visible)
			{
				if (Information.IsNothing(Client.GetHookedUnit()))
				{
					return;
				}
				ActiveUnit activeUnit = null;
				if (Client.GetHookedUnit().IsActiveUnit())
				{
					activeUnit = (ActiveUnit)Client.GetHookedUnit();
				}
				if (Client.GetHookedUnit().IsContact() && ((Contact)Client.GetHookedUnit()).GetIdentificationStatus() >= Contact_Base.IdentificationStatus.KnownClass)
				{
					activeUnit = ((Contact)Client.GetHookedUnit()).ActualUnit;
				}
				if (Client.GetHookedUnit().IsGroup && ((Group)Client.GetHookedUnit()).GetGroupType() == Group.GroupType.AirGroup)
				{
					activeUnit = ((Group)Client.GetHookedUnit()).GetUnitsInGroup().Values.ElementAtOrDefault(0);
				}
				if (!Information.IsNothing(activeUnit))
				{
					Client.ShowDBInfo(activeUnit);
				}
			}
			Client.b_Completed = true;
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x000EBD4C File Offset: 0x000E9F4C
		public static Waypoint GetWayPointSelected()
		{
			return Client.WayPointSelected;
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x000EBD60 File Offset: 0x000E9F60
		public static void SetWayPointSelected(Waypoint waypoint_1)
		{
			try
			{
				bool flag;
				if (flag = (Information.IsNothing(waypoint_1) || Information.IsNothing(Client.WayPointSelected) || Client.WayPointSelected.GetGuid() != waypoint_1.GetGuid()))
				{
					Client.Delegate53 @delegate = Client.delegate53_0;
					if (@delegate != null)
					{
						@delegate();
					}
				}
				Client.WayPointSelected = waypoint_1;
				if (flag)
				{
					Client.Delegate51 delegate2 = Client.delegate51_0;
					if (delegate2 != null)
					{
						delegate2(waypoint_1);
					}
				}
				Client.b_Completed = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200629", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x000EBE2C File Offset: 0x000EA02C
		public static List<ReferencePoint> GetRefPointSelList()
		{
			List<ReferencePoint> result;
			if (Information.IsNothing(Client.GetClientSide()))
			{
				result = null;
			}
			else
			{
				List<ReferencePoint> list = new List<ReferencePoint>();
				foreach (ReferencePoint current in Client.GetClientSide().GetReferencePoints())
				{
					if (!Information.IsNothing(current) && current.IsSelected())
					{
						list.Add(current);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x000EBEB8 File Offset: 0x000EA0B8
		public static Client._CommandOrder GetCommandOrder()
		{
			return Client.CommandOrder;
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x000EBECC File Offset: 0x000EA0CC
		public static void IssueOrdersToUnit(Client._CommandOrder commandOrder_)
		{
			Client._CommandOrder commandOrder = Client.CommandOrder;
			bool flag = Client.CommandOrder != commandOrder_;
			Client.CommandOrder = commandOrder_;
			if (flag)
			{
				if (Client.CommandOrder == Client._CommandOrder.AddNewWeaponWaypoint)
				{
					Client.b_Completed = true;
					Client.GetAttackTarget().Hide();
				}
				if (commandOrder == Client._CommandOrder.AddNewWeaponWaypoint && !Client.GetAttackTarget().IsDisposed)
				{
					Client.GetAttackTarget().method_2();
					Client.GetAttackTarget().Show();
				}
				CommandFactory.GetCommandMain().GetMainForm().ProcessCommandOrder();
			}
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x000EBF4C File Offset: 0x000EA14C
		public static void ShowDBInfo(string strUnitType, int DBID)
		{
			if (!Information.IsNothing(CommandFactory.GetCommandMain().GetDBViewer()))
			{
				CommandFactory.GetCommandMain().GetDBViewer().strUnitType = strUnitType;
				CommandFactory.GetCommandMain().GetDBViewer().DBID = DBID;
				if (CommandFactory.GetCommandMain().GetDBViewer().Visible)
				{
					CommandFactory.GetCommandMain().GetDBViewer().method_1();
				}
				else
				{
					CommandFactory.GetCommandMain().GetDBViewer().Show();
					CommandFactory.GetCommandMain().GetDBViewer().method_1();
				}
			}
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x000EBFD0 File Offset: 0x000EA1D0
		public static void ShowDBInfo(ActiveUnit activeUnit_0)
		{
			if (!Information.IsNothing(CommandFactory.GetCommandMain().GetDBViewer()) && !Information.IsNothing(activeUnit_0) && !activeUnit_0.IsGroup)
			{
				if (activeUnit_0.IsAircraft)
				{
					CommandFactory.GetCommandMain().GetDBViewer().strUnitType = "飞机";
				}
				else if (activeUnit_0.IsShip)
				{
					CommandFactory.GetCommandMain().GetDBViewer().strUnitType = "水面舰艇";
				}
				else if (activeUnit_0.IsSubmarine)
				{
					CommandFactory.GetCommandMain().GetDBViewer().strUnitType = "潜艇";
				}
				else if (activeUnit_0.IsFacility)
				{
					CommandFactory.GetCommandMain().GetDBViewer().strUnitType = "战场设施";
				}
				else if (activeUnit_0.IsSatellite())
				{
					CommandFactory.GetCommandMain().GetDBViewer().strUnitType = "卫星";
				}
				else if (activeUnit_0.IsWeapon)
				{
					CommandFactory.GetCommandMain().GetDBViewer().strUnitType = "武器";
				}
				Client.ShowDBInfo(CommandFactory.GetCommandMain().GetDBViewer().strUnitType, activeUnit_0.DBID);
			}
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00015D01 File Offset: 0x00013F01
		private static void OnScenCompleted(Scenario scenario_)
		{
			if (Client.GetClientScenario() == scenario_ && Client.GetClientScenario().GetSides().Count<Side>() > 0)
			{
				Client.bScenCompleted = true;
			}
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x00015D2B File Offset: 0x00013F2B
		public static void CancelAsync()
		{
			if (!Information.IsNothing(Client.GetEventScheduler()))
			{
				Client.GetEventScheduler().CancelAsync();
			}
		}

        // Token: 0x060026D8 RID: 9944 RVA: 0x000EC0E8 File Offset: 0x000EA2E8
        //public static void smethod_54(int int_4)
        //ZSP BackGround
        public static void SetEventSchedulerTime(int int_4)
		{
			try
			{
				Client.TryAutoSave((float)int_4);
                //判断是非启动运行，如果是就执行Client.GetEventScheduler().RunWorkerAsync()，开始事件调度
                if (!Information.IsNothing(Client.GetConfiguration()) && Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Run)
				{
					Client.TakeSnapShot();
					if (!Client.GetEventScheduler().IsBusy)
					{
						if (!Information.IsNothing(GameGeneral.exception_0))
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw GameGeneral.exception_0;
						}
						Scenario clientScenario = Client.GetClientScenario();
						GameGeneral.ClearWeaponImpacts(ref clientScenario);
						Client.GetEventScheduler().RunWorkerAsync();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200593", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00015D43 File Offset: 0x00013F43
		private static void UpdateDBRecordUsed(DBRecord dbrecord_1)
		{
			if (!Information.IsNothing(dbrecord_1))
			{
				CommandFactory.GetCommandMain().GetMainForm().method_258();
			}
			Client.b_Completed = true;
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x000EC1B4 File Offset: 0x000EA3B4
		public static void LoadSymbolsSet()
		{
			Client.dictionary_1.Clear();
			Dictionary<string, Bitmap> dictionary = new Dictionary<string, Bitmap>();
			string str = "";
			switch (SimConfiguration.gameOptions.GetMapSymbolsSet())
			{
			case Configuration.GameOptions._MapSymbolsSet.NTDS:
				str = "NTDS";
				break;
			case Configuration.GameOptions._MapSymbolsSet.Stylized:
				str = "Stylized";
				break;
			case Configuration.GameOptions._MapSymbolsSet.Directional:
				str = "Directional";
				break;
			case Configuration.GameOptions._MapSymbolsSet.ChineseMilitary:
				str = "ChineseMilitary";
				break;
			default:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				break;
			}
			string[] files = Directory.GetFiles(Application.StartupPath + "\\Symbols\\" + str);
			checked
			{
				for (int i = 0; i < files.Length; i++)
				{
					string text = files[i];
					if (text.EndsWith(".png") | text.EndsWith(".gif"))
					{
						Bitmap original = new Bitmap(text);
						Bitmap bitmap = new Bitmap(original);
						Bitmap value = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format32bppArgb);
						dictionary.Add(Path.GetFileName(text), value);
					}
				}
				if (SimConfiguration.gameOptions.GetMapSymbolsSet() == Configuration.GameOptions._MapSymbolsSet.Directional || SimConfiguration.gameOptions.GetMapSymbolsSet() == Configuration.GameOptions._MapSymbolsSet.ChineseMilitary)
				{
					string[] files2 = Directory.GetFiles(Application.StartupPath + "\\Symbols\\Stylized");
					for (int j = 0; j < files2.Length; j++)
					{
						string text2 = files2[j];
						if ((text2.EndsWith(".png") | text2.EndsWith(".gif")) && !dictionary.ContainsKey(Path.GetFileName(text2)))
						{
							Client.bitmap_0 = (Bitmap)Image.FromFile(text2);
							dictionary.Add(Path.GetFileName(text2), Client.bitmap_0);
						}
					}
				}
				Client.dictionary_0 = dictionary;
				CommandFactory.GetCommandMain().GetMainForm().bitmap_2 = dictionary["hosted_units.png"];
			}
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x000EC380 File Offset: 0x000EA580
		private static void OnCurrentSideChanged(Scenario scenario_1)
		{
			if (scenario_1 == Client.GetClientScenario())
			{
				Client.SetClientSide(Client.GetClientScenario().GetCurrentSide());
				if (!Information.IsNothing(Client.GetClientSide()))
				{
					CommandFactory.GetCommandMain().GetMainForm().GetTSL_Status().Text = "当前推演方: " + Client.GetClientSide().GetSideName();
				}
			}
			Client.b_Completed = true;
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x000EC3E4 File Offset: 0x000EA5E4
		private static void OnSidesChanged(Scenario scenario_1, Scenario._SideChange enum81_0)
		{
			if (scenario_1 == Client.GetClientScenario())
			{
				CommandFactory.GetCommandMain().GetMainForm().method_261();
			}
			if (enum81_0 == Scenario._SideChange.RemoveSide && !Client.GetClientScenario().GetSides().Contains(Client.GetClientSide()))
			{
				if (Client.GetClientScenario().GetSides().Count<Side>() > 0)
				{
					Client.GetClientScenario().ChangeSide(Client.GetClientScenario().GetSides()[0]);
				}
				else
				{
					Client.GetClientScenario().ChangeSide(null);
				}
			}
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x000EC464 File Offset: 0x000EA664
		private static void smethod_59(PlatformComponent platformComponent_0)
		{
			if (platformComponent_0.GetType() == typeof(Sensor) && ((Sensor)platformComponent_0).GetParentPlatform() == Client.GetHookedUnit() && Client.unitSensors.Visible)
			{
				Client.unitSensors.vmethod_16().Start();
			}
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x00015D62 File Offset: 0x00013F62
		private static void smethod_60(ActiveUnit activeUnit_0)
		{
			if (activeUnit_0 == Client.GetHookedUnit() && Client.unitSensors.Visible)
			{
				Client.unitSensors.vmethod_16().Start();
			}
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x000EC4BC File Offset: 0x000EA6BC
		public static void AddSide(string string_6, ref Scenario scenario_1)
		{
			Side side = new Side(string_6, ref scenario_1);
			Client.GetClientScenario().AddSide(side);
			if (Client.GetClientScenario().GetSides().Length == 1)
			{
				Client.SetClientSide(side);
			}
			if (CommandFactory.GetCommandMain().GetSides().Visible)
			{
				CommandFactory.GetCommandMain().GetSides().method_2();
			}
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x000EC51C File Offset: 0x000EA71C
		public static void SaveTempScenarioFile(bool SBR, string CustomFileName = "", bool MarkAsCampaignCheckpoint = false)
		{
			bool flag = false;
			if (flag = (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Run))
			{
				Client.GetConfiguration().SetSimStopMode();
			}
			GameGeneral.SerializeScenario(Client.GetClientScenario());
			Client.GetClientScenario().SetDBUsed(Client.GetDBRecord().Hash);
			Client.GetClientScenario().LastSavedInScenEdit = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
			int num = 0;
			do
			{
				try
				{
					if (string.IsNullOrEmpty(CustomFileName))
					{
						Class260.SaveTempScenarioFile(Client.GetClientScenario(), Client.GetClientSide(), CommandFactory.GetCommandMain().GetMainForm().vmethod_26().FileName, SBR, MarkAsCampaignCheckpoint);
					}
					else
					{
						Class260.SaveTempScenarioFile(Client.GetClientScenario(), Client.GetClientSide(), CustomFileName, SBR, MarkAsCampaignCheckpoint);
					}
					break;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					GC.Collect();
					ex2.Data.Add("Error at 200360", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
				num++;
			}
			while (num <= 4);
			if (flag)
			{
				Client.GetConfiguration().SetSimRunMode();
			}
			CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
			Client.IssueOrdersToUnit(Client._CommandOrder.None);
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x000EC658 File Offset: 0x000EA858
		public static void smethod_63()
		{
			Client.SetClientScenario(new Scenario(Client.GetDBRecord().Hash), false);
			Client.GetClientScenario().AdvanceSimTime(false, DateAndTime.Now.ToUniversalTime());
			Client.GetClientScenario().SetTimeStep(1f);
			Client.GetClientScenario().SetTimeCompression(0);
			Client.GetClientScenario().LastSavedInScenEdit = true;
			Client.GetClientScenario().FileName = null;
			Client.string_3 = null;
			Client.SetClientSide(null);
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x000EC6D0 File Offset: 0x000EA8D0
		public static bool IsVisible(Unit theUnit)
		{
			return Client.GetMap().IsGodsEyeView() || (theUnit.IsActiveUnit() && ((theUnit.IsWeapon && !Information.IsNothing(((Weapon)theUnit).GetDataLinkParent()) && Class2529.IsIsolatedPOVObject(((Weapon)theUnit).GetDataLinkParent())) || ((((ActiveUnit)theUnit).GetCommStuff().IsNotOutOfComms() || Operators.CompareString(theUnit.GetGuid(), Client.GetMap().GetIsolatedPOVObjectID(), false) == 0) && (Information.IsNothing(Client.GetMap().GetIsolatedPOVObjectID()) || Operators.CompareString(theUnit.GetGuid(), Client.GetMap().GetIsolatedPOVObjectID(), false) == 0) && theUnit.GetSide(false) == Client.GetClientSide())));
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x00015D8D File Offset: 0x00013F8D
		private static void EventScheduler_DoWork(object sender, DoWorkEventArgs e)
		{
			Client.ScheduleEvent();
		}

		// 调度事件
		public static void ScheduleEvent()
		{
			Client.NumOfUnits = Client.GetClientScenario().GetActiveUnitList().Count;
			Client.double_1 = (double)Class324.smethod_5();
			Client.string_1 = Class324.smethod_6();
			int timeCompression = Client.GetClientScenario().GetTimeCompression();
			int num = 1;
			while (true)
			{
				IL_E4:
				if (num <= timeCompression)
				{
					goto IL_CF;
				}
				bool arg_3C_0 = false;
				IL_3C:
				if (!arg_3C_0)
				{
					break;
				}
				Client.ProcessEvent(Client.GetClientScenario(), ref Client.ElapsedTime);
				using (Queue<LoggedMessage>.Enumerator enumerator = Client.GetClientScenario().UnhandledPopUpMessages.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.side == Client.GetClientSide())
						{
							Client.GetConfiguration().SetSimStopMode();
							if (SimConfiguration.gameOptions.NoPulseMapUpdate())
							{
								if (Client.GetClientScenario().GetTimeCompression() > 1)
								{
									Client.b_Completed = true;
								}
								num++;
								goto IL_E4;
							}
							num++;
							goto IL_E4;
						}
					}
                    if (SimConfiguration.gameOptions.NoPulseMapUpdate())
                    {
                        if (Client.GetClientScenario().GetTimeCompression() > 1)
                        {
                            Client.b_Completed = true;
                        }
                        num++;
                        goto IL_E4;
                    }
                    num++;
                    goto IL_E4;
                }
				IL_CF:
				arg_3C_0 = (Client.GetConfiguration().GetSimStatus() != Configuration.EnumRunStop.const_Stop);
				goto IL_3C;
			}
			Client.LogMessage(Client.GetClientScenario());
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x00015D94 File Offset: 0x00013F94
		private static void EventScheduler_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Client.b_Completed = true;
			Client.CheckScenCompleteCondition();
		}

		// 处理事件
		internal static void ProcessEvent(Scenario scenario, ref double ElapsedTime)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			bool bSave_ = false;
			if (Client.TimeSinceLastScenarioSave >= Client.ScenarioAutoSaveInterval)
			{
				bSave_ = true;
				Client.TimeSinceLastScenarioSave = 0;
			}
			else
			{
				bSave_ = false;
				Client.TimeSinceLastScenarioSave++;
			}
			try
			{
				try
				{
					GameGeneral.AdvanceTimeStep(ref scenario, scenario.GetTimeStep(), bSave_);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (ex2.GetType() == typeof(OutOfMemoryException))
					{
						GameGeneral.ForceGarbageCollection();
					}
					ex2.Data.Add("Error at 200362 GC.Collect 1", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					if (SimConfiguration.gameOptions.UseMemoryProtection())
					{
						Class260.smethod_0(scenario);
						string text = Misc.smethod_49(GameGeneral.GetScenarioStream(scenario));
						string text2 = "";
						double num = 0.0;
						scenario = Scenario.LoadScenario(text, ref text2, ref num, false);
						try
						{
							GameGeneral.AdvanceTimeStep(ref scenario, scenario.GetTimeStep(), bSave_);
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							if (ex4.GetType() == typeof(OutOfMemoryException))
							{
								GameGeneral.ForceGarbageCollection();
							}
							ex4.Data.Add("Error at 200363 GC.Collect 2", ex4.Message);
							GameGeneral.LogException(ref ex4);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							Class260.smethod_0(scenario);
							string text3 = Misc.smethod_49(GameGeneral.GetScenarioStream(scenario));
							text2 = "";
							num = 0.0;
							scenario = Scenario.LoadScenario(text3, ref text2, ref num, false);
							try
							{
								GameGeneral.AdvanceTimeStep(ref scenario, scenario.GetTimeStep(), bSave_);
							}
							catch (Exception ex5)
							{
								ProjectData.SetProjectError(ex5);
								Exception ex6 = ex5;
								if (ex6.GetType() == typeof(OutOfMemoryException))
								{
									GameGeneral.ForceGarbageCollection();
								}
								ex6.Data.Add("Error at 200364 GC.Collect 3", ex6.Message);
								GameGeneral.LogException(ref ex6);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								Class260.smethod_0(scenario);
								string text4 = Misc.smethod_49(GameGeneral.GetScenarioStream(scenario));
								text2 = "";
								num = 0.0;
								scenario = Scenario.LoadScenario(text4, ref text2, ref num, false);
								try
								{
									GameGeneral.AdvanceTimeStep(ref scenario, scenario.GetTimeStep(), bSave_);
								}
								catch (Exception ex7)
								{
									ProjectData.SetProjectError(ex7);
									Exception ex8 = ex7;
									ex6.Data.Add("Error at 101163", ex8.Message);
									GameGeneral.LogException(ref ex6);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									throw;
								}
								ProjectData.ClearProjectError();
							}
							Client.SetNavigationOptions(ref scenario);
							ProjectData.ClearProjectError();
						}
					}
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex9)
			{
				ProjectData.SetProjectError(ex9);
				Exception ex10 = ex9;
				ex10.Data.Add("Error at 101163", ex10.Message);
				GameGeneral.LogException(ref ex10);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			stopwatch.Stop();
			ElapsedTime = (double)stopwatch.ElapsedMilliseconds;
			Client.Delegate55 @delegate = Client.delegate55_0;
			if (@delegate != null)
			{
				@delegate(scenario);
			}
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00015DA1 File Offset: 0x00013FA1
		public static void SetNavigationOptions(ref Scenario scenario_)
		{
			scenario_.Navigation_FinegrainedMaxDistance = SimConfiguration.gameOptions.GetNavigationMaxDistanceNMSetting();
			scenario_.Navigation_FinegrainedThresholdDistance = SimConfiguration.gameOptions.GetNavigationThresholdDistanceDegSetting();
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00015DC5 File Offset: 0x00013FC5
		public static void SetUserIsPlottingCourse(ref Scenario scenario_1, bool bool_8)
		{
			scenario_1.UserIsPlottingCourse = bool_8;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x000ECC20 File Offset: 0x000EAE20
		private static List<KeyValuePair<long, LoggedMessage>> GetMessageLogList()
		{
			return Client.GetClientScenario().MessageLog.Where(Client.KeyValuePairFunc0).ToList<KeyValuePair<long, LoggedMessage>>();
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x000ECC48 File Offset: 0x000EAE48
		private static void LogMessage(Scenario scenario_1)
		{
			try
			{
				if (scenario_1.SecondIsChangingOnThisPulse)
				{
					StringBuilder stringBuilder = new StringBuilder();
					List<KeyValuePair<long, LoggedMessage>> list = Client.GetMessageLogList();
					foreach (KeyValuePair<long, LoggedMessage> current in list)
					{
						LoggedMessage loggedMessage = current.Value;
						string text;
						if (Information.IsNothing(loggedMessage.side))
						{
							text = "";
						}
						else
						{
							text = loggedMessage.side.GetSideName();
						}
						stringBuilder.Append(string.Concat(new string[]
						{
							loggedMessage.TStamp.ToString(),
							" - ",
							text,
							": ",
							loggedMessage.Text,
							"\r\n\r\n"
						}));
						loggedMessage.bool_8 = true;
					}
					StreamWriter streamWriter = File.AppendText(CommandFactory.GetCommandApp().Info.DirectoryPath + "\\Logs\\" + Client.GetConfiguration().string_0 + ".txt");
					streamWriter.Write(stringBuilder.ToString());
					streamWriter.Close();
				}
				if ((scenario_1.GetTimeCompression() == 1 && scenario_1.FifthSecondIsChangingOnThisPulse) || scenario_1.GetTimeCompression() > 1)
				{
					Side[] sides = scenario_1.GetSides();
					for (int i = 0; i < sides.Length; i = checked(i + 1))
					{
						List<LoggedMessage> list2 = sides[i].GetLoggedMessageList(scenario_1).OrderByDescending(Client.LoggedMessageFunc1).ThenByDescending(Client.LoggedMessageFunc2).ToList<LoggedMessage>();
						int count = list2.Count;
						if (count > 100)
						{
							int num = count - 1;
							for (int num2 = 100; num2 <= num; num2++)
							{
								try
								{
									LoggedMessage loggedMessage = list2[num2];
									scenario_1.MessageLog.TryRemove(loggedMessage.Increment, out loggedMessage);
									goto IL_221;
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ex2.Data.Add("Error at 200366", ex2.Message);
									GameGeneral.LogException(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									ProjectData.ClearProjectError();
									goto IL_221;
								}
								break;
								IL_221:;
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ex4.Data.Add("Error at 200367", ex4.Message);
				GameGeneral.LogException(ref ex4);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000ECF14 File Offset: 0x000EB114
		public static bool smethod_73(ref ActiveUnit theUnit, bool MergedRangeSymbols, ref Contact theContact)
		{
			bool flag;
			bool result;
			if (MergedRangeSymbols)
			{
				flag = true;
			}
			else if (!theUnit.HasParentGroup())
			{
				flag = true;
			}
			else
			{
				MapProfile._ViewMode viewMode = Client.GetMap().ViewMode;
				if (viewMode != MapProfile._ViewMode.GroupMode)
				{
					if (viewMode == MapProfile._ViewMode.UnitMode)
					{
						result = true;
						return result;
					}
				}
				else
				{
					if (SimConfiguration.gameOptions.ShowGhostedGroupMembers() == Configuration.GameOptions._ShowGhostedGroupMembers.ALL)
					{
						result = true;
						return result;
					}
					if (SimConfiguration.gameOptions.ShowGhostedGroupMembers() == Configuration.GameOptions._ShowGhostedGroupMembers.SEL)
					{
						if (Information.IsNothing(theContact))
						{
							result = (theUnit.GetParentGroup(false) == Client.GetHookedUnit());
							return result;
						}
						result = (!theUnit.IsFacility || (!Information.IsNothing(Client.GetHookedUnit()) && Client.GetHookedUnit().IsContact() && theUnit.GetParentGroup(false) == ((Contact)Client.GetHookedUnit()).ActualUnit));
						return result;
					}
					else if (SimConfiguration.gameOptions.ShowGhostedGroupMembers() == Configuration.GameOptions._ShowGhostedGroupMembers.NONE)
					{
						result = (!Information.IsNothing(theContact) && !theUnit.IsFacility);
						return result;
					}
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000ED02C File Offset: 0x000EB22C
		private static bool IsMillisecondOver100()
		{
			return Client.GetClientScenario().GetTimeCompression() != 1 || Client.GetClientScenario().GetCurrentTime(false).Millisecond - 100 <= 0;
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000ED068 File Offset: 0x000EB268
		private static void TryAutoSave(float float_1)
		{
			if (!Information.IsNothing(Client.GetConfiguration()) && Client.GetClientScenario().GetSides().Count<Side>() != 0 && !Client.bool_3 && SimConfiguration.gameOptions.IsUseAutosave() && Client.LastAutoSave <= 0.0)
			{
				Client.LastAutoSave = 20000.0;
				Task.Factory.StartNew(Client.AutosaveAction);
			}
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000ED0D8 File Offset: 0x000EB2D8
		private static void TakeSnapShot()
		{
			if (Client.IsRecorderStarted() && Client.IsMillisecondOver100())
			{
				Client.ScenarioSnapshotTaker scenarioSnapshotTaker = new Client.ScenarioSnapshotTaker(null);
				while (Client.GetClientScenario().SerializationInProgress)
				{
					Thread.Sleep(20);
				}
				scenarioSnapshotTaker.ScenarioStream = GameGeneral.GetScenarioStream(Client.GetClientScenario());
				if (scenarioSnapshotTaker.ScenarioStream.Length > 0L)
				{
					Task.Factory.StartNew(new Action(scenarioSnapshotTaker.TakeSnapshot));
				}
			}
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000ED158 File Offset: 0x000EB358
		public static void CheckScenCompleteCondition()
		{
			if (DateTime.Compare(Client.GetClientScenario().GetCurrentTime(false), Client.GetClientScenario().GetStartTime().Add(Client.GetClientScenario().GetDuration())) > 0 && !Client.GetClientScenario().HasEnded())
			{
				Client.GetConfiguration().SetSimStopMode();
				Client.GetClientScenario().ScenCompleted();
			}
		}

		// 自动保存
		public static void AutoSave()
		{
			try
			{
				if (Client.GetConfiguration().GetSimStatus() != Configuration.EnumRunStop.const_Stop)
				{
					Client.GetClientScenario().LastSavedInScenEdit = (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit);
					ScenContainer scenContainer = new ScenContainer(Client.GetClientScenario());
					scenContainer.TryToCompressScenario(GameGeneral.GetScenarioStream(Client.GetClientScenario()));
					if (File.Exists(GameGeneral.strScenariosDir + "\\Autosave_100sec.scen"))
					{
						File.Delete(GameGeneral.strScenariosDir + "\\Autosave_100sec.scen");
					}
					if (File.Exists(GameGeneral.strScenariosDir + "\\Autosave_80sec.scen"))
					{
						File.Move(GameGeneral.strScenariosDir + "\\Autosave_80sec.scen", GameGeneral.strScenariosDir + "\\Autosave_100sec.scen");
					}
					if (File.Exists(GameGeneral.strScenariosDir + "\\Autosave_60sec.scen"))
					{
						File.Move(GameGeneral.strScenariosDir + "\\Autosave_60sec.scen", GameGeneral.strScenariosDir + "\\Autosave_80sec.scen");
					}
					if (File.Exists(GameGeneral.strScenariosDir + "\\Autosave_40sec.scen"))
					{
						File.Move(GameGeneral.strScenariosDir + "\\Autosave_40sec.scen", GameGeneral.strScenariosDir + "\\Autosave_60sec.scen");
					}
					if (File.Exists(GameGeneral.strScenariosDir + "\\Autosave_20sec.scen"))
					{
						File.Move(GameGeneral.strScenariosDir + "\\Autosave_20sec.scen", GameGeneral.strScenariosDir + "\\Autosave_40sec.scen");
					}
					if (File.Exists(GameGeneral.strScenariosDir + "\\Autosave.scen"))
					{
						File.Move(GameGeneral.strScenariosDir + "\\Autosave.scen", GameGeneral.strScenariosDir + "\\Autosave_20sec.scen");
					}
					scenContainer.SaveTempScenarioFile(GameGeneral.strScenariosDir + "\\Autosave.scen");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Client.exception_0 = ex2;
				Client.b_Completed = true;
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000ED3B4 File Offset: 0x000EB5B4
		public static void GetAlpha(ref float float_1, ref int int_4, ref ActiveUnit activeUnit_)
		{
			MapProfile._ViewMode viewMode = Client.GetMap().ViewMode;
			if (viewMode != MapProfile._ViewMode.GroupMode)
			{
				if (viewMode == MapProfile._ViewMode.UnitMode)
				{
					if (activeUnit_.IsGroup)
					{
						float_1 = (float)Client.double_2;
						int_4 = (int)Client.byte_0;
					}
					else
					{
						float_1 = 1f;
						int_4 = 255;
					}
				}
			}
			else if (activeUnit_.IsGroup)
			{
				float_1 = 1f;
				int_4 = 255;
			}
			else if (activeUnit_.HasParentGroup())
			{
				float_1 = (float)Client.double_2;
				int_4 = (int)Client.byte_0;
			}
			else
			{
				float_1 = 1f;
				int_4 = 255;
			}
			if (!activeUnit_.GetCommStuff().IsNotOutOfComms() && !Client.GetMap().IsGodsEyeView() && !Class2529.IsIsolatedPOVObject(activeUnit_))
			{
				int_4 = 128;
				float_1 = 0.25f;
			}
			if (activeUnit_.IsWeapon && ((Weapon)activeUnit_).GetWeaponType() == Weapon._WeaponType.Sonobuoy && SimConfiguration.gameOptions.GetSonobuoyVisibility() == Configuration.GameOptions._SonobuoyVisibility.const_1)
			{
				int_4 = 128;
				float_1 = 0.25f;
			}
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000ED4C4 File Offset: 0x000EB6C4
		public static void smethod_80()
		{
			Client.smethod_63();
			Class260.concurrentDictionary_0.TryAdd(Client.GetClientScenario().GetObjectID(), Client.GetClientScenario());
			string string_ = "NATO";
			Scenario clientScenario = Client.GetClientScenario();
			Client.AddSide(string_, ref clientScenario);
			string string_2 = "WP";
			clientScenario = Client.GetClientScenario();
			Client.AddSide(string_2, ref clientScenario);
			Client.GetClientScenario().GetSides()[0].SetPostureStance(Client.GetClientScenario().GetSides()[1], Misc.PostureStance.Hostile);
			Client.GetClientScenario().GetSides()[1].SetPostureStance(Client.GetClientScenario().GetSides()[0], Misc.PostureStance.Hostile);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Raptor 1", 5.0, 5.0, 691, 4521, 10000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Raptor 2", 5.0, 4.95, 691, 4521, 10000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Flanker 1", 5.8, 5.8, 2099, 2368, 10000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Flanker 2", 5.8, 5.7, 2099, 2368, 10000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Flanker 3", 5.8, 5.6, 2099, 2368, 10000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Flanker 4", 5.8, 5.5, 2099, 2368, 10000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Mainstay 1", 5.82, 5.52, 2149, 8060, 10000f, null);
			checked
			{
				foreach (ActiveUnit current in Client.GetClientScenario().GetActiveUnitList())
				{
					if (current.GetSide(false) == Client.GetClientScenario().GetSides()[1])
					{
						Sensor[] allNoneMCMSensors = current.GetAllNoneMCMSensors();
						for (int i = 0; i < allNoneMCMSensors.Length; i++)
						{
							Sensor sensor = allNoneMCMSensors[i];
							if (sensor.sensorType == Sensor.SensorType.Radar)
							{
								sensor.TurnOn();
							}
						}
					}
				}
				Client.SetClientSide(Client.GetClientScenario().GetSides()[0]);
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
		}

        // Token: 0x060026F3 RID: 9971 RVA: 0x000ED7C4 File Offset: 0x000EB9C4
        // "#1 (A2A)" 测试
        public static void smethod_81()
		{
			Client.smethod_63();
			string string_ = "NATO";
			Scenario clientScenario = Client.GetClientScenario();
			Client.AddSide(string_, ref clientScenario);
			string string_2 = "WP";
			clientScenario = Client.GetClientScenario();
			Client.AddSide(string_2, ref clientScenario);
			Client.GetClientScenario().GetSides()[0].SetPostureStance(Client.GetClientScenario().GetSides()[1], Misc.PostureStance.Hostile);
			Client.GetClientScenario().GetSides()[1].SetPostureStance(Client.GetClientScenario().GetSides()[0], Misc.PostureStance.Hostile);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 1447, "Perry 1", 5.0, 5.0, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 259, "Tanker 1", 4.9, 5.1, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 42, "Tico 1", 4.85, 5.15, false, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Backfire 1", 8.1, 5.8, 1669, 2423, 10000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Backfire 2", 7.6, 5.7, 1669, 2423, 10000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Backfire 3", 8.2, 5.6, 1669, 2423, 10000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Backfire 4", 7.5, 5.5, 1669, 2423, 10000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Backfire 5", 8.3, 5.4, 1669, 2423, 10000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Backfire 6", 7.4, 5.3, 1669, 2423, 10000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Backfire 7", 8.4, 5.2, 1669, 2423, 10000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Backfire 8", 7.3, 5.1, 1669, 2423, 10000f, null);
			Client.GetClientScenario().AddSubmarine(Client.GetClientScenario().GetSides()[1], 185, "Tomsk", 2.5731, 3.5107, false, null);
			Client.SetClientSide(Client.GetClientScenario().GetSides()[0]);
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

        // Token: 0x060026F4 RID: 9972 RVA: 0x000EDB1C File Offset: 0x000EBD1C
        // "#3 (Mike)"; 测试
        public static void smethod_82()
		{
			Client.smethod_63();
			string string_ = "Australia";
			Scenario clientScenario = Client.GetClientScenario();
			Client.AddSide(string_, ref clientScenario);
			string string_2 = "OPFOR";
			clientScenario = Client.GetClientScenario();
			Client.AddSide(string_2, ref clientScenario);
			Client.GetClientScenario().GetSides()[0].SetPostureStance(Client.GetClientScenario().GetSides()[1], Misc.PostureStance.Hostile);
			Client.GetClientScenario().GetSides()[1].SetPostureStance(Client.GetClientScenario().GetSides()[0], Misc.PostureStance.Hostile);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 956, "Adelaide 1", 5.0, 5.0, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 592, "Anzac 1", 4.85, 5.15, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[1], 1832, "Luhai 1", 5.0, 4.0, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[1], 690, "Guangzhou 1", 4.85, 4.0, false, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Backfire 1", 8.1, 5.8, 1669, 2423, 5000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Backfire 2", 7.6, 5.7, 1669, 2423, 5000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Mirage F.1 #1", 6.1, 5.8, 1203, 7545, 1000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Mirage F.1 #2", 5.6, 5.7, 1203, 7545, 1000f, null);
			Client.SetClientSide(Client.GetClientScenario().GetSides()[0]);
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

        // Token: 0x060026F5 RID: 9973 RVA: 0x000EDD80 File Offset: 0x000EBF80
        //"#4 (Group + Air Ops)"  测试
        public static void smethod_83()
		{
			Client.smethod_63();
			string string_ = "USN";
			Scenario clientScenario = Client.GetClientScenario();
			Client.AddSide(string_, ref clientScenario);
			string string_2 = "OPFOR";
			clientScenario = Client.GetClientScenario();
			Client.AddSide(string_2, ref clientScenario);
			Client.GetClientScenario().GetSides()[0].SetPostureStance(Client.GetClientScenario().GetSides()[1], Misc.PostureStance.Hostile);
			Client.GetClientScenario().GetSides()[1].SetPostureStance(Client.GetClientScenario().GetSides()[0], Misc.PostureStance.Hostile);
			Ship ship = Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 272, "Enterprise", -76.1, 37.2, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 42, "Yorktown", -76.11, 37.19, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 521, "Truxtun", -76.2, 37.3, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 761, "King", -76.15, 37.0, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 116, "Underwood", -76.3, 37.25, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 1812, "Wichita", -76.09, 37.21, false, null);
			Aircraft aircraft = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Tomcat 1", -76.12, 37.2, 10, 0, 1000f, null);
			if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft))
			{
				ship.GetAirOps().method_18(aircraft, false);
			}
			aircraft = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Tomcat 2", -76.12, 37.2, 10, 0, 1000f, null);
			if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft))
			{
				ship.GetAirOps().method_18(aircraft, false);
			}
			aircraft = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Hornet 1", -76.12, 37.2, 47, 0, 1000f, null);
			if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft))
			{
				ship.GetAirOps().method_18(aircraft, false);
			}
			aircraft = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Hornet 2", -76.12, 37.2, 47, 0, 1000f, null);
			if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft))
			{
				ship.GetAirOps().method_18(aircraft, false);
			}
			aircraft = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Hornet 3", -76.12, 37.2, 47, 0, 1000f, null);
			if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft))
			{
				ship.GetAirOps().method_18(aircraft, false);
			}
			aircraft = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Hornet 4", -76.12, 37.2, 47, 0, 1000f, null);
			if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft))
			{
				ship.GetAirOps().method_18(aircraft, false);
			}
			aircraft = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Intruder 1", -76.12, 37.2, 221, 0, 1000f, null);
			if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft))
			{
				ship.GetAirOps().method_18(aircraft, false);
			}
			aircraft = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Intruder 2", -76.12, 37.2, 221, 0, 1000f, null);
			if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft))
			{
				ship.GetAirOps().method_18(aircraft, false);
			}
			aircraft = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "SeaHawk 1", -76.12, 37.2, 237, 0, 1000f, null);
			if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft))
			{
				ship.GetAirOps().method_18(aircraft, false);
			}
			aircraft = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Sea King 1", -76.12, 37.2, 55, 0, 1000f, null);
			if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft))
			{
				ship.GetAirOps().method_18(aircraft, false);
			}
			Client.SetClientSide(Client.GetClientScenario().GetSides()[0]);
			CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
		}

        // Token: 0x060026F6 RID: 9974 RVA: 0x000EE2C8 File Offset: 0x000EC4C8
        //"#5 (Iran)"; 测试
        public static void smethod_84()
		{
			Client.smethod_63();
			string string_ = "US";
			Scenario clientScenario = Client.GetClientScenario();
			Client.AddSide(string_, ref clientScenario);
			string string_2 = "Iran";
			clientScenario = Client.GetClientScenario();
			Client.AddSide(string_2, ref clientScenario);
			Client.GetClientScenario().GetSides()[0].SetPostureStance(Client.GetClientScenario().GetSides()[1], Misc.PostureStance.Hostile);
			Client.GetClientScenario().GetSides()[1].SetPostureStance(Client.GetClientScenario().GetSides()[0], Misc.PostureStance.Hostile);
			Client.GetClientScenario().ImportUnits(Application.StartupPath + "\\ImportExport\\Iran\\Natanz 2008.inst", Client.GetClientScenario().GetSides()[1]);
			Client.GetClientScenario().ImportUnits(Application.StartupPath + "\\ImportExport\\Iran\\Bandar Abbas.inst", Client.GetClientScenario().GetSides()[1]);
			Group group = Client.GetClientScenario().Groups.method_0("Bandar Abbas International/TAB 9");
			int num = 1;
			do
			{
				Aircraft aircraft = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Falcon 50 #" + Conversions.ToString(num), -76.12, 37.2, 639, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft))
				{
					group.GetAirOps().method_18(aircraft, false);
				}
				num++;
			}
			while (num <= 4);
			num = 1;
			do
			{
				Aircraft aircraft2 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "F.27 #" + Conversions.ToString(num), -76.12, 37.2, 2091, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft2))
				{
					group.GetAirOps().method_18(aircraft2, false);
				}
				num++;
			}
			while (num <= 4);
			Client.GetClientScenario().ImportUnits(Application.StartupPath + "\\ImportExport\\Iran\\Bushehr.inst", Client.GetClientScenario().GetSides()[1]);
			Client.GetClientScenario().GetSides()[1].AddMission(new Strike(Client.GetClientScenario().GetSides()[1], Client.GetClientScenario(), "Mission 1", Mission.MissionCategory.Mission, Strike.StrikeType.Air_Intercept));
			group = Client.GetClientScenario().Groups.method_0("Bushehr Airport/TAB 6");
			Mission mission_ = Client.GetClientScenario().GetSides()[1].GetPatrolMissionCollection(Client.GetClientScenario())[0];
			num = 1;
			do
			{
				Aircraft aircraft3 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Bushehr Phantom-D #" + Conversions.ToString(num), -76.12, 37.2, 229, 2173, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft3))
				{
					group.GetAirOps().method_18(aircraft3, false);
				}
				aircraft3.DeleteMission(false, mission_);
				num++;
			}
			while (num <= 6);
			num = 1;
			do
			{
				Aircraft aircraft4 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Bushehr Phantom-E #" + Conversions.ToString(num), -76.12, 37.2, 1309, 332, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft4))
				{
					group.GetAirOps().method_18(aircraft4, false);
				}
				aircraft4.DeleteMission(false, mission_);
				num++;
			}
			while (num <= 18);
			num = 1;
			do
			{
				Aircraft aircraft5 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Bushehr Tomcat #" + Conversions.ToString(num), -76.12, 37.2, 1312, 770, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft5))
				{
					group.GetAirOps().method_18(aircraft5, false);
				}
				aircraft5.DeleteMission(false, mission_);
				num++;
			}
			while (num <= 12);
			num = 1;
			do
			{
				Aircraft aircraft6 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Bushehr Falcon 50 #" + Conversions.ToString(num), -76.12, 37.2, 639, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft6))
				{
					group.GetAirOps().method_18(aircraft6, false);
				}
				num++;
			}
			while (num <= 2);
			Client.GetClientScenario().ImportUnits(Application.StartupPath + "\\ImportExport\\Iran\\Dezful.inst", Client.GetClientScenario().GetSides()[1]);
			group = Client.GetClientScenario().Groups.method_0("Dezful");
			num = 1;
			do
			{
				Aircraft aircraft7 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Dezful Tiger #" + Conversions.ToString(num), -76.12, 37.2, 1310, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft7))
				{
					group.GetAirOps().method_18(aircraft7, false);
				}
				num++;
			}
			while (num <= 36);
			Client.GetClientScenario().ImportUnits(Application.StartupPath + "\\ImportExport\\Iran\\Esfahan.inst", Client.GetClientScenario().GetSides()[1]);
			group = Client.GetClientScenario().Groups.method_0("Esfahan");
			num = 1;
			do
			{
				Aircraft aircraft8 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Esfahan Tiger #" + Conversions.ToString(num), -76.12, 37.2, 1310, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft8))
				{
					group.GetAirOps().method_18(aircraft8, false);
				}
				num++;
			}
			while (num <= 12);
			num = 1;
			do
			{
				Aircraft aircraft9 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Esfahan Fencer #" + Conversions.ToString(num), -76.12, 37.2, 1327, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft9))
				{
					group.GetAirOps().method_18(aircraft9, false);
				}
				num++;
			}
			while (num <= 2);
			Client.GetClientScenario().ImportUnits(Application.StartupPath + "\\ImportExport\\Iran\\Hamadan.inst", Client.GetClientScenario().GetSides()[1]);
			group = Client.GetClientScenario().Groups.method_0("Hamadan");
			num = 1;
			do
			{
				Aircraft aircraft10 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Hamadan Phantom-D #" + Conversions.ToString(num), -76.12, 37.2, 229, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft10))
				{
					group.GetAirOps().method_18(aircraft10, false);
				}
				num++;
			}
			while (num <= 12);
			num = 1;
			do
			{
				Aircraft aircraft11 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Hamadan Phantom-E #" + Conversions.ToString(num), -76.12, 37.2, 1309, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft11))
				{
					group.GetAirOps().method_18(aircraft11, false);
				}
				num++;
			}
			while (num <= 12);
			Client.GetClientScenario().ImportUnits(Application.StartupPath + "\\ImportExport\\Iran\\Mehrabad.inst", Client.GetClientScenario().GetSides()[1]);
			group = Client.GetClientScenario().Groups.method_0("Mehrabad");
			num = 1;
			do
			{
				Aircraft aircraft12 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Mehrabad Fulcrum #" + Conversions.ToString(num), -76.12, 37.2, 1346, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft12))
				{
					group.GetAirOps().method_18(aircraft12, false);
				}
				num++;
			}
			while (num <= 12);
			num = 1;
			do
			{
				Aircraft aircraft13 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Mehrabad Fencer #" + Conversions.ToString(num), -76.12, 37.2, 1327, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft13))
				{
					group.GetAirOps().method_18(aircraft13, false);
				}
				num++;
			}
			while (num <= 12);
			num = 1;
			do
			{
				Aircraft aircraft14 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Mehrabad Tanker-707 #" + Conversions.ToString(num), -76.12, 37.2, 2423, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft14))
				{
					group.GetAirOps().method_18(aircraft14, false);
				}
				num++;
			}
			while (num <= 10);
			num = 1;
			do
			{
				Aircraft aircraft15 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Mehrabad Tanker-747 #" + Conversions.ToString(num), -76.12, 37.2, 1660, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft15))
				{
					group.GetAirOps().method_18(aircraft15, false);
				}
				num++;
			}
			while (num <= 5);
			Client.GetClientScenario().ImportUnits(Application.StartupPath + "\\ImportExport\\Iran\\Omidiyeh.inst", Client.GetClientScenario().GetSides()[1]);
			group = Client.GetClientScenario().Groups.method_0("Omidiyeh");
			num = 1;
			do
			{
				Aircraft aircraft16 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Omidiyeh Airguard #" + Conversions.ToString(num), -76.12, 37.2, 1354, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft16))
				{
					group.GetAirOps().method_18(aircraft16, false);
				}
				num++;
			}
			while (num <= 36);
			Client.GetClientScenario().ImportUnits(Application.StartupPath + "\\ImportExport\\Iran\\Shiraz.inst", Client.GetClientScenario().GetSides()[1]);
			group = Client.GetClientScenario().Groups.method_0("Shiraz");
			num = 1;
			do
			{
				Aircraft aircraft17 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Shiraz Fencer #" + Conversions.ToString(num), -76.12, 37.2, 1327, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft17))
				{
					group.GetAirOps().method_18(aircraft17, false);
				}
				num++;
			}
			while (num <= 12);
			num = 1;
			do
			{
				Aircraft aircraft18 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Shiraz Frogfoot #" + Conversions.ToString(num), -76.12, 37.2, 133, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft18))
				{
					group.GetAirOps().method_18(aircraft18, false);
				}
				num++;
			}
			while (num <= 12);
			Client.GetClientScenario().ImportUnits(Application.StartupPath + "\\ImportExport\\Iran\\Tabriz.inst", Client.GetClientScenario().GetSides()[1]);
			group = Client.GetClientScenario().Groups.method_0("Tabriz");
			num = 1;
			do
			{
				Aircraft aircraft19 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Tabriz Tiger #" + Conversions.ToString(num), -76.12, 37.2, 1310, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft19))
				{
					group.GetAirOps().method_18(aircraft19, false);
				}
				num++;
			}
			while (num <= 24);
			num = 1;
			do
			{
				Aircraft aircraft20 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[1], "Tabriz Fulcrum #" + Conversions.ToString(num), -76.12, 37.2, 1346, 0, 1000f, null);
				if (group.GetAirOps().CanBeHostedOnAirFacility(aircraft20))
				{
					group.GetAirOps().method_18(aircraft20, false);
				}
				num++;
			}
			while (num <= 12);
			Client.GetClientScenario().ImportUnits(Application.StartupPath + "\\ImportExport\\Iran\\Iran EW.inst", Client.GetClientScenario().GetSides()[1]);
			Client.GetClientScenario().ImportUnits(Application.StartupPath + "\\ImportExport\\Iran\\Iran AD.inst", Client.GetClientScenario().GetSides()[1]);
			Ship ship = Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 1215, "Roosevelt", 51.144952, 27.025, false, null);
			num = 1;
			do
			{
				Aircraft aircraft21 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Super Bug #" + Conversions.ToString(num), -76.12, 37.2, 1089, 0, 1000f, null);
				if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft21))
				{
					ship.GetAirOps().method_18(aircraft21, false);
				}
				num++;
			}
			while (num <= 24);
			num = 1;
			do
			{
				Aircraft aircraft22 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Classic Bug #" + Conversions.ToString(num), -76.12, 37.2, 2039, 0, 1000f, null);
				if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft22))
				{
					ship.GetAirOps().method_18(aircraft22, false);
				}
				num++;
			}
			while (num <= 24);
			num = 1;
			do
			{
				Aircraft aircraft23 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Prowler #" + Conversions.ToString(num), -76.12, 37.2, 601, 0, 1000f, null);
				if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft23))
				{
					ship.GetAirOps().method_18(aircraft23, false);
				}
				num++;
			}
			while (num <= 4);
			num = 1;
			do
			{
				Aircraft aircraft24 = Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "Hawkeye #" + Conversions.ToString(num), -76.12, 37.2, 694, 0, 1000f, null);
				if (ship.GetAirOps().CanBeHostedOnAirFacility(aircraft24))
				{
					ship.GetAirOps().method_18(aircraft24, false);
				}
				num++;
			}
			while (num <= 4);
			checked
			{
				foreach (ActiveUnit current in Client.GetClientScenario().GetActiveUnitList())
				{
					if (current.GetSide(false) == Client.GetClientScenario().GetSides()[1])
					{
						Sensor[] allNoneMCMSensors = current.GetAllNoneMCMSensors();
						for (int i = 0; i < allNoneMCMSensors.Length; i++)
						{
							Sensor sensor = allNoneMCMSensors[i];
							if (sensor.sensorType == Sensor.SensorType.Radar)
							{
								sensor.TurnOn();
							}
						}
					}
				}
				Client.SetClientSide(Client.GetClientScenario().GetSides()[0]);
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
		}

        // Token: 0x060026F7 RID: 9975 RVA: 0x000EF380 File Offset: 0x000ED580
        // "#6 (LOS + Terrain masking)" 测试
        public static void smethod_85()
		{
			Client.smethod_63();
			string string_ = "Blue";
			Scenario clientScenario = Client.GetClientScenario();
			Client.AddSide(string_, ref clientScenario);
			string string_2 = "Red";
			clientScenario = Client.GetClientScenario();
			Client.AddSide(string_2, ref clientScenario);
			Client.GetClientScenario().GetSides()[0].SetPostureStance(Client.GetClientScenario().GetSides()[1], Misc.PostureStance.Hostile);
			Client.GetClientScenario().GetSides()[1].SetPostureStance(Client.GetClientScenario().GetSides()[0], Misc.PostureStance.Hostile);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "BUFF 1", Class263.smethod_7(24.143), Class263.smethod_7(34.5059), 14, 6995, 1000f, null);
			Client.GetClientScenario().AddAircraft(Client.GetClientScenario().GetSides()[0], "BUFF 2", Class263.smethod_7(24.1714), Class263.smethod_7(35.243), 14, 6995, 100f, null);
			Client.GetClientScenario().AddFacility(Client.GetClientScenario().GetSides()[1], 691, "IHAWK Bty", Class263.smethod_7(24.1454), Class263.smethod_7(35.1115), false, null);
			checked
			{
				using (IEnumerator<ActiveUnit> enumerator = Client.GetClientScenario().GetActiveUnits().Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Sensor[] allNoneMCMSensors = enumerator.Current.GetAllNoneMCMSensors();
						for (int i = 0; i < allNoneMCMSensors.Length; i++)
						{
							Sensor sensor = allNoneMCMSensors[i];
							if (sensor.sensorType == Sensor.SensorType.Radar)
							{
								sensor.TurnOn();
							}
						}
					}
				}
				Client.SetClientSide(Client.GetClientScenario().GetSides()[1]);
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
		}

        // Token: 0x060026F8 RID: 9976 RVA: 0x000EF564 File Offset: 0x000ED764
        // "#7 (ESM freeze bug)"; 测试
        public static void smethod_86()
		{
			Client.smethod_63();
			string string_ = "Blue";
			Scenario clientScenario = Client.GetClientScenario();
			Client.AddSide(string_, ref clientScenario);
			string string_2 = "Red";
			clientScenario = Client.GetClientScenario();
			Client.AddSide(string_2, ref clientScenario);
			Client.GetClientScenario().GetSides()[0].SetPostureStance(Client.GetClientScenario().GetSides()[1], Misc.PostureStance.Hostile);
			Client.GetClientScenario().GetSides()[1].SetPostureStance(Client.GetClientScenario().GetSides()[0], Misc.PostureStance.Hostile);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 503, "Ticonderoga", -6.5724901248489074, 35.951348412451246, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 1079, "Underwood", -7.0591524050254906, 36.3974394215724, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[0], 1079, "Doyle", -6.9327656606761447, 35.632462827276647, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[1], 1734, "Charles De Gaulle", -11.548334045232812, 34.5312840865825, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[1], 49, "Tourville", -8.8958075990439642, 35.938456581620152, false, null);
			Client.GetClientScenario().AddShip(Client.GetClientScenario().GetSides()[1], 49, "De Grasse", -8.6556071022743346, 34.573328936901532, false, null);
			checked
			{
				foreach (ActiveUnit current in Client.GetClientScenario().GetActiveUnits().Values)
				{
					if (current.GetSide(false) == Client.GetClientScenario().GetSides()[1])
					{
						Sensor[] allNoneMCMSensors = current.GetAllNoneMCMSensors();
						for (int i = 0; i < allNoneMCMSensors.Length; i++)
						{
							Sensor sensor = allNoneMCMSensors[i];
							if (sensor.sensorType == Sensor.SensorType.Radar)
							{
								sensor.TurnOn();
							}
						}
					}
				}
				Client.SetClientSide(Client.GetClientScenario().GetSides()[0]);
				CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
			}
		}

        // Token: 0x060026F9 RID: 9977 RVA: 0x000EF7D4 File Offset: 0x000ED9D4
        //消息输出, "打印到文件"; 
        public static void AALogPrintToFile()
		{
			StringBuilder stringBuilder = new StringBuilder();
			List<LoggedMessage> list = Client.GetClientSide().GetLoggedMessageList(Client.GetClientScenario());
			if (!Information.IsNothing(list))
			{
				foreach (LoggedMessage current in list)
				{
					stringBuilder.Append(current.TStamp.ToString() + ": " + current.Text + "\r\n\r\n");
				}
			}
			StreamWriter streamWriter = File.CreateText(Application.StartupPath + "\\AALog.txt");
			streamWriter.Write(stringBuilder.ToString());
			streamWriter.Close();
			stringBuilder = null;
			Interaction.MsgBox("AALog exported!", MsgBoxStyle.OkOnly, null);
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x000EF8A0 File Offset: 0x000EDAA0
		internal static void SetDBUsedHash(string string_6)
		{
			if (Versioned.IsNumeric(string_6))
			{
				string_6 = DBOps.GetDBRecordHash(Conversions.ToInteger(string_6));
			}
			DBOps.DBFileCheckResult dbfileCheckResult_ = DBOps.DBFileCheckResult.Undefined;
			Client.SetDBRecord(DBOps.GetDBRecord(string_6, ref dbfileCheckResult_, true, true));
			if (Information.IsNothing(Client.GetDBRecord()))
			{
				Interaction.MsgBox("错误: " + DBOps.smethod_7(dbfileCheckResult_) + "\r\n终止...", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				Client.GetClientScenario().SetDBUsed(string_6);
			}
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00015DCF File Offset: 0x00013FCF
		private static void ScenarioProgressTimer_Click(object sender, EventArgs e)
		{
			if (Client.bScenCompleted)
			{
				Client.bScenCompleted = false;
				Interaction.MsgBox("推演已经结束。下面对您的参演表现进行评估。", MsgBoxStyle.OkOnly, "推演完毕");
				CommandFactory.GetCommandMain().GetEvaluation().Show();
			}
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x000EF910 File Offset: 0x000EDB10
		public static void CheckScenario(Scenario scenario_1, string string_6)
		{
			scenario_1.CheckDeclaredFeatures();
			List<Scenario.ScenarioFeatureOption> list = new List<Scenario.ScenarioFeatureOption>();
			foreach (Scenario.ScenarioFeatureOption current in scenario_1.DeclaredFeatures)
			{
				if (!LicenseChecker.IsFeatureSupported(current))
				{
					list.Add(current);
				}
			}
			if (list.Count > 0)
			{
				new UnlicensedFeaturesWindow
				{
					DataContext = new LicenseDialogViewModel(list)
				}.Show();
			}
			else
			{
				if (scenario_1.LastSavedInScenEdit)
				{
					CommandFactory.GetCommandMain().GetChooseSide().scenario_0 = scenario_1;
					CommandFactory.GetCommandMain().GetChooseSide().string_0 = string_6;
					CommandFactory.GetCommandMain().GetChooseSide().Show();
				}
				else
				{
					Client.SetClientScenario(scenario_1, false);
					Client.SetClientSide(Client.GetClientScenario().GetCurrentSide());
					if (Information.IsNothing(Client.GetClientSide()))
					{
						CommandFactory.GetCommandMain().GetMainForm().method_6(4000000);
					}
					else
					{
						CommandFactory.GetCommandMain().GetMainForm().method_6((int)Math.Round(Client.GetClientSide().CameraAlt));
						CommandFactory.GetCommandMain().GetMainForm().method_14(true, Client.GetClientSide().GetMapCenter());
					}
					Client.GetConfiguration().SetSimStopMode();
					Client.b_Completed = true;
					CommandFactory.GetCommandMain().GetMainForm().RefreshMap();
					CommandFactory.GetCommandMain().GetMainForm().method_156();
					if (Client.GetConfiguration().GetSimStatus() == Configuration.EnumRunStop.const_Run)
					{
						Client.GetConfiguration().SetSimStopMode();
					}
					CommandFactory.GetCommandMain().GetMainForm().method_161();
					CommandFactory.GetCommandMain().GetMainForm().Enabled = true;
				}
				if (!string.IsNullOrEmpty(Client.string_2))
				{
					Interaction.MsgBox(Client.string_2, MsgBoxStyle.Exclamation, null);
					Client.string_2 = "";
				}
				checked
				{
					if (Client.GetConfiguration().GetGameMode() == Configuration._GameMode.Edit)
					{
						List<string> list2 = new List<string>();
						Side[] sides = scenario_1.GetSides();
						for (int i = 0; i < sides.Length; i++)
						{
							Side side = sides[i];
							if (!Information.IsNothing(side.GetMissionCollection()))
							{
                                Mission current2X;
                                foreach (Mission current2 in side.GetPatrolMissionCollection(scenario_1))
								{
                                    current2X = current2;
                                    list2.AddRange(scenario_1.FlightSizeHardLimitCheckInfo(ref side, ref current2X));
								}
							}
						}
						string text = "";
						if (list2.Count > 0)
						{
							text = "警告!由于编队规模限制，该任务行动中的某些飞机不能起飞!\r\n\r\n为解决这个问题，您可以改变编队规模，向任务行动中分配更多飞机，也可以改变现有飞机的挂载方案使得足够多的飞机具备相同的挂载，或者取消对“飞机数量低于编队规模不允许起飞”标志位的选择。\r\n\r\n";
							foreach (string current3 in list2)
							{
								text = text + "\r\n" + current3;
							}
							if (!string.IsNullOrEmpty(text))
							{
								Interaction.MsgBox(text, MsgBoxStyle.Exclamation, null);
							}
						}
					}
					Client.string_0 = string_6;
				}
			}
        }

        // Token: 0x060026FD RID: 9981 RVA: 0x000EFC04 File Offset: 0x000EDE04
        //"添加图层" 相关
        public static void AddImageLayerList()
		{
			CommandFactory.GetCommandMain().GetMainForm().vmethod_108().InitialDirectory = Application.StartupPath;
			checked
			{
				if (CommandFactory.GetCommandMain().GetMainForm().vmethod_108().ShowDialog() == DialogResult.OK)
				{
					string[] fileNames = CommandFactory.GetCommandMain().GetMainForm().vmethod_108().FileNames;
					for (int i = 0; i < fileNames.Length; i++)
					{
						string string_ = fileNames[i];
						try
						{
							Client.AddImageLayer(string_);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000EFCA8 File Offset: 0x000EDEA8
		public static void AddImageLayer(string string_6)
		{
			new CultureInfo("en-US");
			string text = Path.GetExtension(string_6);
			if (text.Length == 4)
			{
				text = Conversions.ToString(text[0]) + Conversions.ToString(text[1]) + Conversions.ToString(text[text.Length - 1]) + "w";
			}
			else
			{
				text += "w";
			}
			string path = Path.ChangeExtension(string_6, text);
			if (File.Exists(path))
			{
				string text2 = File.ReadAllText(path);
				text2 = text2.Replace(",", ".");
				File.WriteAllText(path, text2);
				TextReader textReader = File.OpenText(path);
				double num = 0.0;
				double num2 = 0.0;
				double num3 = 0.0;
				double num4 = 0.0;
				try
				{
					num = Math2.smethod_23(textReader.ReadLine());
					Math2.smethod_23(textReader.ReadLine());
					Math2.smethod_23(textReader.ReadLine());
					num2 = Math2.smethod_23(textReader.ReadLine());
					num3 = Math2.smethod_23(textReader.ReadLine());
					num4 = Math2.smethod_23(textReader.ReadLine());
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200369", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
					return;
				}
				finally
				{
					textReader.Close();
				}
				ImageInformation imageInformation = TextureLoader.ImageInformationFromFile(string_6);
				double double_ = (double)imageInformation.Height * num2 + num4;
				double double_2 = (double)imageInformation.Width * num + num3;
				ImageLayer imageLayer = new ImageLayer(string_6, Client.m_WorldWindow.method_2(), 0.0, string_6, double_, num4, num3, double_2, 100.0, Client.m_WorldWindow.method_2().GetTerrainAccessor());
				imageLayer.SetOpacity(255);
				imageLayer.method_0(Color.Black.ToArgb());
				imageLayer.Initialize(Client.m_WorldWindow.GetDrawArgs());
				imageLayer.vmethod_14(Path.GetFileName(string_6));
				Client.m_WorldWindow.method_2().GetRenderableObjectList().Add(imageLayer);
				Client.RenderableObjectList.Add(imageLayer);
				CommandFactory.GetCommandMain().GetMainForm().MapBoxResize();
			}
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x00015E01 File Offset: 0x00014001
		private static void smethod_93(string string_6)
		{
			Client.queue_0.Enqueue(string_6);
			Client.b_Completed = true;
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x000EFF10 File Offset: 0x000EE110
		private static void SetScenCompleted(Side side_1)
		{
			if (side_1 == Client.GetClientSide() && Client.GetClientScenario().IsCampaignSession())
			{
				int num = Class2529.smethod_12(Client.GetClientScenario());
				if (side_1.GetTotalScore(Client.GetClientScenario(), null) >= num)
				{
					Client.GetClientScenario().ScenCompleted();
				}
			}
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x00015E14 File Offset: 0x00014014
		private static void TimerEventHandle(object sender, EventArgs e)
		{
			SteamWorkshop.smethod_3();
		}

		// Token: 0x04001276 RID: 4726
		public static Func<KeyValuePair<long, LoggedMessage>, bool> KeyValuePairFunc0 = (KeyValuePair<long, LoggedMessage> keyValuePair_0) => !Information.IsNothing(keyValuePair_0.Value) && !keyValuePair_0.Value.bool_8;

		// Token: 0x04001277 RID: 4727
		public static Func<LoggedMessage, DateTime> LoggedMessageFunc1 = (LoggedMessage loggedMessage_0) => loggedMessage_0.TStamp;

		// Token: 0x04001278 RID: 4728
		public static Func<LoggedMessage, long> LoggedMessageFunc2 = (LoggedMessage loggedMessage_0) => loggedMessage_0.Increment;

		// Token: 0x04001279 RID: 4729
		public static Action AutosaveAction = delegate
		{
			Client.AutoSave();
		};

		// Token: 0x0400127A RID: 4730
		internal static bool b_MainForm_Shown = false;

		// Token: 0x0400127B RID: 4731
		public static bool b_Completed;

		// Token: 0x0400127C RID: 4732
		public static Dictionary<string, Bitmap> dictionary_0;

		// Token: 0x0400127D RID: 4733
		[CompilerGenerated]
		private static Configuration m_Configuration;

		// Token: 0x0400127E RID: 4734
		[CompilerGenerated]
		private static Scenario m_Scenario;

		// Token: 0x0400127F RID: 4735
		internal static string string_0;

		// Token: 0x04001280 RID: 4736
		[CompilerGenerated]
		private static Side m_Side;

		// Token: 0x04001281 RID: 4737
		private static Client._CommandOrder CommandOrder;

		// Token: 0x04001282 RID: 4738
		private static DBRecord DBRecordUsed;

		// Token: 0x04001283 RID: 4739
		internal static ScenarioSnapshots m_ScenarioSnapshots;

		// Token: 0x04001284 RID: 4740
		private static bool bRecorderStarted = false;

		// Token: 0x04001285 RID: 4741
		internal static RecorderForm recorderForm;

		// Token: 0x04001286 RID: 4742
		internal static bool bool_3;

		// Token: 0x04001287 RID: 4743
		private static bool bool_4;

		// Token: 0x04001288 RID: 4744
		internal static int NumOfUnits;

		// Token: 0x04001289 RID: 4745
		internal static double ElapsedTime;

		// Token: 0x0400128A RID: 4746
		internal static double double_1;

		// Token: 0x0400128B RID: 4747
		internal static string string_1;

		// Token: 0x0400128C RID: 4748
		[CompilerGenerated]
		private static System.Windows.Forms.Timer ScenarioProgressTimer;

		// Token: 0x0400128D RID: 4749
		[CompilerGenerated]
		private static System.Windows.Forms.Timer timer_1;

		// Token: 0x0400128E RID: 4750
		private static bool bScenCompleted;

		// Token: 0x0400128F RID: 4751
		internal static ReferencePoint.OrientationType orientationType_0;

		// Token: 0x04001290 RID: 4752
		internal static List<RenderableObject> RenderableObjectList;

		// Token: 0x04001291 RID: 4753
		internal static float float_0;

		// Token: 0x04001292 RID: 4754
		internal static string string_2 = "";

		// Token: 0x04001293 RID: 4755
		private static Unit unit_0;

		// Token: 0x04001294 RID: 4756
		internal static bool bool_6;

		// Token: 0x04001295 RID: 4757
		internal static WorldWindow m_WorldWindow;

		// Token: 0x04001296 RID: 4758
		public static int ScenarioAutoSaveInterval;

		// Token: 0x04001297 RID: 4759
		private static int TimeSinceLastScenarioSave;

		// Token: 0x04001298 RID: 4760
		internal static Mount m_Mount;

		// Token: 0x04001299 RID: 4761
		internal static WeaponSalvo weaponSalvo;

		// Token: 0x0400129A RID: 4762
		internal static int int_3;

		// Token: 0x0400129B RID: 4763
		internal static bool bool_7;

		// Token: 0x0400129C RID: 4764
		internal static Exception exception_0;

		// Token: 0x0400129D RID: 4765
		internal static Queue<string> queue_0;

		// Token: 0x0400129E RID: 4766
		public static string string_3;

		// Token: 0x0400129F RID: 4767
		internal static string strSteamWorkshopScenarioDir = Path.Combine(Application.StartupPath, "Scenarios", "Steam Workshop");

		// Token: 0x040012A0 RID: 4768
		private static Bitmap bitmap_0;

		// Token: 0x040012A1 RID: 4769
		internal static Dictionary<string, Image> dictionary_1 = new Dictionary<string, Image>();

		// Token: 0x040012A2 RID: 4770
		internal static Color color_Friendly = Color.FromArgb(255, 82, 255, 255);

		// Token: 0x040012A3 RID: 4771
		internal static Color color_Unknown = Color.Yellow;

		// Token: 0x040012A4 RID: 4772
		internal static Color color_Neutral = Color.LightGreen;

		// Token: 0x040012A5 RID: 4773
		internal static Color color_Unfriendly = Color.Orange;

		// Token: 0x040012A6 RID: 4774
		internal static Color color_Hostile = Color.Red;

		// Token: 0x040012A7 RID: 4775
		private static MapProfile mapProfile;

		// Token: 0x040012A8 RID: 4776
		private static Unit HookedUnit;

		// Token: 0x040012A9 RID: 4777
		private static Waypoint WayPointSelected;

		// Token: 0x040012AA RID: 4778
		public static double double_2 = 0.6;

		// Token: 0x040012AB RID: 4779
		public static byte byte_0 = 100;

		// Token: 0x040012AC RID: 4780
		public static byte byte_1 = 55;

		// Token: 0x040012AD RID: 4781
		public static double LastAutoSave = 0.0;

		// Token: 0x040012AE RID: 4782
		private static Lazy<WeaponsWindow> lazy_WeaponsWindow = new Lazy<WeaponsWindow>();

		// Token: 0x040012AF RID: 4783
		public static UnitSensors unitSensors;

		// Token: 0x040012B0 RID: 4784
		public static DamageControlWindow damageControlWindow;

		// Token: 0x040012B1 RID: 4785
		public static Magazines magazines = new Magazines();

		// Token: 0x040012B2 RID: 4786
		public static CampaignEditorWindow campaignEditorWindow = new CampaignEditorWindow();

		// Token: 0x040012B3 RID: 4787
		public static VideoWindow videoWindow;

		// Token: 0x040012B4 RID: 4788
		[CompilerGenerated]
		private static BackgroundWorker Client_backgroundWorker_0;

		// Token: 0x040012B5 RID: 4789
		[CompilerGenerated]
		private static BackgroundWorker SimEventScheduler;

		// Token: 0x040012B6 RID: 4790
		public static NewMission newMission;

		// Token: 0x040012B7 RID: 4791
		public static FlightPlans flightPlans = new FlightPlans();

		// Token: 0x040012B8 RID: 4792
		public static FlightPlanEditor flightPlanEditor = new FlightPlanEditor();

		// Token: 0x040012B9 RID: 4793
		public static FlightPlanErrors flightPlanErrors = new FlightPlanErrors();

		// Token: 0x040012BA RID: 4794
		public static FlightPlanTime flightPlanTime = new FlightPlanTime();

		// Token: 0x040012BB RID: 4795
		internal static string strClass;

		// Token: 0x040012BC RID: 4796
		internal static byte? Type;

		// Token: 0x040012BD RID: 4797
		internal static int? CountryID;

		// Token: 0x040012BE RID: 4798
		public static Dictionary<LoggedMessage.MessageType, NewMessageForm> MessageTypeFormDictionary;

		// Token: 0x040012BF RID: 4799
		[CompilerGenerated]
		private static Client.Delegate49 delegate49_0;

		// Token: 0x040012C0 RID: 4800
		[CompilerGenerated]
		private static Client.Delegate50 delegate50_0;

		// Token: 0x040012C1 RID: 4801
		[CompilerGenerated]
		private static Client.Delegate51 delegate51_0;

		// Token: 0x040012C2 RID: 4802
		[CompilerGenerated]
		private static Client.Delegate52 delegate52_0;

		// Token: 0x040012C3 RID: 4803
		[CompilerGenerated]
		private static Client.Delegate53 delegate53_0;

		// Token: 0x040012C4 RID: 4804
		[CompilerGenerated]
		private static Client.Delegate54 delegate54_0;

		// Token: 0x040012C5 RID: 4805
		[CompilerGenerated]
		private static Client.Delegate55 delegate55_0;

		// Token: 0x040012C6 RID: 4806
		public static ElementHost elementHost;

		// Token: 0x040012C7 RID: 4807
		public static ScenarioFeatures scenarioFeatures;

		// Token: 0x040012C8 RID: 4808
		private static MissionEditor m_missionEditor;

		// Token: 0x040012C9 RID: 4809
		private static AttackTarget m_attackTarget;

		// Token: 0x020005FA RID: 1530
		// (Invoke) Token: 0x06002709 RID: 9993
		public delegate void Delegate49();

		// Token: 0x020005FB RID: 1531
		// (Invoke) Token: 0x0600270D RID: 9997
		public delegate void Delegate50(Unit theUnit);

		// Token: 0x020005FC RID: 1532
		// (Invoke) Token: 0x06002711 RID: 10001
		public delegate void Delegate51(Waypoint theWaypoint);

		// Token: 0x020005FD RID: 1533
		// (Invoke) Token: 0x06002715 RID: 10005
		public delegate void Delegate52();

		// Token: 0x020005FE RID: 1534
		// (Invoke) Token: 0x06002719 RID: 10009
		public delegate void Delegate53();

		// Token: 0x020005FF RID: 1535
		// (Invoke) Token: 0x0600271D RID: 10013
		public delegate void Delegate54();

		// Token: 0x02000600 RID: 1536
		// (Invoke) Token: 0x06002721 RID: 10017
		public delegate void Delegate55(Scenario theScen);

		// Token: 0x02000601 RID: 1537
		public enum _CommandOrder
		{
			// Token: 0x040012CF RID: 4815
			None,
			// Token: 0x040012D0 RID: 4816
			ViewRangeBearing,
			// Token: 0x040012D1 RID: 4817
			AddUnit,
			// Token: 0x040012D2 RID: 4818
			CreateNewScenario,
			// Token: 0x040012D3 RID: 4819
			EditScenario,
			// Token: 0x040012D4 RID: 4820
			SaveScenario,
			// Token: 0x040012D5 RID: 4821
			AddNewWayPoint,
			// Token: 0x040012D6 RID: 4822
			SetBaseForUnit,
			// Token: 0x040012D7 RID: 4823
			AddReferencePoint,
			// Token: 0x040012D8 RID: 4824
			MoveReferencePoint,
			// Token: 0x040012D9 RID: 4825
			DropTarget,
			// Token: 0x040012DA RID: 4826
			MoveUnit,
			// Token: 0x040012DB RID: 4827
			CopyUnit,
			// Token: 0x040012DC RID: 4828
			SetFormationLeader,
			// Token: 0x040012DD RID: 4829
			SetFormationStation,
			// Token: 0x040012DE RID: 4830
			SelectRelativeObject,
			// Token: 0x040012DF RID: 4831
			SelectTargetToIntercept,
			// Token: 0x040012E0 RID: 4832
			SelectTargetToAttack,
			// Token: 0x040012E1 RID: 4833
			SelectAimPointforBearingOnlyAttack,
			// Token: 0x040012E2 RID: 4834
			DefineArea,
			// Token: 0x040012E3 RID: 4835
			SatellitePassPredication,
			// Token: 0x040012E4 RID: 4836
			CloneUnit,
			// Token: 0x040012E5 RID: 4837
			EditBriefing,
			// Token: 0x040012E6 RID: 4838
			AddNewWeaponWaypoint,
			// Token: 0x040012E7 RID: 4839
			SelectTankerToRefuelFrom
		}

		// Token: 0x02000602 RID: 1538
		[CompilerGenerated]
		public sealed class ScenarioSnapshotTaker
		{
			// Token: 0x06002724 RID: 10020 RVA: 0x00015E44 File Offset: 0x00014044
			public ScenarioSnapshotTaker(Client.ScenarioSnapshotTaker ScenarioSnapshotTaker_)
			{
				if (ScenarioSnapshotTaker_ != null)
				{
					this.ScenarioStream = ScenarioSnapshotTaker_.ScenarioStream;
				}
			}

			// Token: 0x06002725 RID: 10021 RVA: 0x00015E5E File Offset: 0x0001405E
			internal void TakeSnapshot()
			{
				Client.m_ScenarioSnapshots.AddScenarioSnapshot(Client.GetClientScenario().GetCurrentTime(false), this.ScenarioStream);
			}

			// Token: 0x040012E8 RID: 4840
			public MemoryStream ScenarioStream;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic;

namespace ns2
{
	// Token: 0x02000AC6 RID: 2758
	public sealed class Configuration
	{
		// Token: 0x06005840 RID: 22592 RVA: 0x0026D39C File Offset: 0x0026B59C
		[CompilerGenerated]
		public static void smethod_0(Configuration.Delegate11 delegate11_1)
		{
			Configuration.Delegate11 @delegate = Configuration.delegate11_0;
			Configuration.Delegate11 delegate2;
			do
			{
				delegate2 = @delegate;
				Configuration.Delegate11 value = (Configuration.Delegate11)Delegate.Combine(delegate2, delegate11_1);
				@delegate = Interlocked.CompareExchange<Configuration.Delegate11>(ref Configuration.delegate11_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x0026D3D4 File Offset: 0x0026B5D4
		[CompilerGenerated]
		public static void smethod_1(Configuration.Delegate12 delegate12_1)
		{
			Configuration.Delegate12 @delegate = Configuration.delegate12_0;
			Configuration.Delegate12 delegate2;
			do
			{
				delegate2 = @delegate;
				Configuration.Delegate12 value = (Configuration.Delegate12)Delegate.Combine(delegate2, delegate12_1);
				@delegate = Interlocked.CompareExchange<Configuration.Delegate12>(ref Configuration.delegate12_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x0026D40C File Offset: 0x0026B60C
		public Configuration.EnumRunStop GetSimStatus()
		{
			return this.enumSimStatus;
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x0026D424 File Offset: 0x0026B624
		public Configuration._GameMode GetGameMode()
		{
			return this.GameMode;
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x0026D43C File Offset: 0x0026B63C
		public void SetGameMode(Configuration._GameMode enum37_1)
		{
			bool flag = this.GameMode != enum37_1;
			this.GameMode = enum37_1;
			if (flag)
			{
				Configuration.Delegate11 @delegate = Configuration.delegate11_0;
				if (@delegate != null)
				{
					@delegate();
				}
			}
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x0026D478 File Offset: 0x0026B678
		public void SetSimRunMode()
		{
			this.enumSimStatus = Configuration.EnumRunStop.const_Run;
			Configuration.Delegate12 @delegate = Configuration.delegate12_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x0026D4A0 File Offset: 0x0026B6A0
		public void SetSimStopMode()
		{
			this.enumSimStatus = Configuration.EnumRunStop.const_Stop;
			Configuration.Delegate12 @delegate = Configuration.delegate12_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x0026D4C8 File Offset: 0x0026B6C8
		public Configuration()
		{
			DateTime now = DateAndTime.Now;
			this.string_0 = string.Concat(new string[]
			{
				now.Year.ToString(),
				"-",
				now.Month.ToString(),
				"-",
				now.Day.ToString(),
				"_",
				now.Hour.ToString(),
				".",
				now.Minute.ToString(),
				".",
				now.Second.ToString()
			});
		}

		// Token: 0x04002B70 RID: 11120
		private Configuration.EnumRunStop enumSimStatus;

		// Token: 0x04002B71 RID: 11121
		private Configuration._GameMode GameMode;

		// Token: 0x04002B72 RID: 11122
		[CompilerGenerated]
		private static Configuration.Delegate11 delegate11_0;

		// Token: 0x04002B73 RID: 11123
		[CompilerGenerated]
		private static Configuration.Delegate12 delegate12_0;

		// Token: 0x04002B74 RID: 11124
		public string string_0;

		// Token: 0x02000AC7 RID: 2759
		// (Invoke) Token: 0x06005849 RID: 22601
		public delegate void Delegate11();

		// Token: 0x02000AC8 RID: 2760
		// (Invoke) Token: 0x0600584D RID: 22605
		public delegate void Delegate12();

		// Token: 0x02000AC9 RID: 2761
		public enum _GameMode : byte
		{
			// Token: 0x04002B76 RID: 11126
			Play,
			// Token: 0x04002B77 RID: 11127
			Simulation,
			// Token: 0x04002B78 RID: 11128
			Edit
		}

		// Token: 0x02000ACA RID: 2762
		public enum EnumRunStop : byte
		{
			// Token: 0x04002B7A RID: 11130
			const_Stop,
			// Token: 0x04002B7B RID: 11131
			const_Run
		}

		// Token: 0x02000ACB RID: 2763
		public sealed class GameOptions
		{
			// Token: 0x06005850 RID: 22608 RVA: 0x00027F18 File Offset: 0x00026118
			public bool IsPlacenameShowInChinese()
			{
				return this.bPlacenameShowInChinese;
			}

			// Token: 0x06005851 RID: 22609 RVA: 0x00027F20 File Offset: 0x00026120
			public void SetPlacenameShowInChinese(bool value)
			{
				this.bPlacenameShowInChinese = value;
			}

			// Token: 0x06005852 RID: 22610 RVA: 0x00027F29 File Offset: 0x00026129
			public bool IsUseAutosave()
			{
				return this.bUseAutosave;
			}

			// Token: 0x06005853 RID: 22611 RVA: 0x00027F31 File Offset: 0x00026131
			public void SetUseAutosave(bool bool_20)
			{
				this.bUseAutosave = bool_20;
			}

			// Token: 0x06005854 RID: 22612 RVA: 0x00027F3A File Offset: 0x0002613A
			public bool IsRunCoreMultithreaded()
			{
				return this.bRunCoreMultithreaded;
			}

			// Token: 0x06005855 RID: 22613 RVA: 0x00027F42 File Offset: 0x00026142
			public void SetRunCoreMultithreaded(bool bool_20)
			{
				this.bRunCoreMultithreaded = bool_20;
			}

			// Token: 0x06005856 RID: 22614 RVA: 0x00027F4B File Offset: 0x0002614B
			public bool IsShowDiagnostics()
			{
				return this.bShowDiagnostics;
			}

			// Token: 0x06005857 RID: 22615 RVA: 0x00027F53 File Offset: 0x00026153
			public void SetShowDiagnostics(bool bool_20)
			{
				this.bShowDiagnostics = bool_20;
			}

			// Token: 0x06005858 RID: 22616 RVA: 0x00027F5C File Offset: 0x0002615C
			public bool IsMessageLogInWindow()
			{
				return this.bMessageLogInWindow;
			}

			// Token: 0x06005859 RID: 22617 RVA: 0x00027F64 File Offset: 0x00026164
			public void SetMessageLogInWindow(bool bool_20)
			{
				this.bMessageLogInWindow = bool_20;
			}

			// Token: 0x0600585A RID: 22618 RVA: 0x00027F6D File Offset: 0x0002616D
			public bool IsGameSoundsON()
			{
				return this.bGameSoundsON;
			}

			// Token: 0x0600585B RID: 22619 RVA: 0x00027F75 File Offset: 0x00026175
			public void SetGameSoundsON(bool bool_20)
			{
				this.bGameSoundsON = bool_20;
			}

			// Token: 0x0600585C RID: 22620 RVA: 0x00027F7E File Offset: 0x0002617E
			public bool IsGameMusicON()
			{
				return this.bGameMusicON;
			}

			// Token: 0x0600585D RID: 22621 RVA: 0x00027F86 File Offset: 0x00026186
			public void SetGameMusicON(bool bool_20)
			{
				this.bGameMusicON = bool_20;
			}

			// Token: 0x0600585E RID: 22622 RVA: 0x00027F8F File Offset: 0x0002618F
			public bool UseImperialUnit()
			{
				return this.useImperialUnit;
			}

			// Token: 0x0600585F RID: 22623 RVA: 0x00027F97 File Offset: 0x00026197
			public void SetUseImperialUnit(bool bool_20)
			{
				this.useImperialUnit = bool_20;
			}

			// Token: 0x06005860 RID: 22624 RVA: 0x00027FA0 File Offset: 0x000261A0
			public bool IsZoomOnCursor()
			{
				return this.bZoomOnCursor;
			}

			// Token: 0x06005861 RID: 22625 RVA: 0x00027FA8 File Offset: 0x000261A8
			public void SetZoomOnCursor(bool bool_20)
			{
				this.bZoomOnCursor = bool_20;
			}

			// Token: 0x06005862 RID: 22626 RVA: 0x0026D58C File Offset: 0x0026B78C
			public Configuration.GameOptions._SonobuoyVisibility GetSonobuoyVisibility()
			{
				return this.sonobuoyVisibility;
			}

			// Token: 0x06005863 RID: 22627 RVA: 0x00027FB1 File Offset: 0x000261B1
			public void SetSonobuoyVisibility(Configuration.GameOptions._SonobuoyVisibility enum39_1)
			{
				this.sonobuoyVisibility = enum39_1;
			}

			// Token: 0x06005864 RID: 22628 RVA: 0x0026D5A4 File Offset: 0x0026B7A4
			public Configuration.GameOptions._DPIScalingMethod GetDPIScalingMethod()
			{
				return this.dPIScalingMethod;
			}

			// Token: 0x06005865 RID: 22629 RVA: 0x00027FBA File Offset: 0x000261BA
			public void SetDPIScalingMethod(Configuration.GameOptions._DPIScalingMethod enum40_1)
			{
				this.dPIScalingMethod = enum40_1;
			}

			// Token: 0x06005866 RID: 22630 RVA: 0x0026D5BC File Offset: 0x0026B7BC
			public Configuration.GameOptions._RefPointVisibility GetRefPointVisibility()
			{
				return this.refPointVisibility;
			}

			// Token: 0x06005867 RID: 22631 RVA: 0x00027FC3 File Offset: 0x000261C3
			public void SetRefPointVisibility(Configuration.GameOptions._RefPointVisibility enum41_1)
			{
				this.refPointVisibility = enum41_1;
			}

			// Token: 0x06005868 RID: 22632 RVA: 0x0026D5D4 File Offset: 0x0026B7D4
			public Configuration.GameOptions._MapSymbolsSet GetMapSymbolsSet()
			{
				return this.mapSymbolsSet;
			}

			// Token: 0x06005869 RID: 22633 RVA: 0x00027FCC File Offset: 0x000261CC
			public void SetMapSymbolsSet(Configuration.GameOptions._MapSymbolsSet MapSymbolsSet_)
			{
				this.mapSymbolsSet = MapSymbolsSet_;
			}

			// Token: 0x0600586A RID: 22634 RVA: 0x0026D5EC File Offset: 0x0026B7EC
			public Configuration.GameOptions._MapCursorBox GetMapCursorBox()
			{
				return this.mapCursorBox;
			}

			// Token: 0x0600586B RID: 22635 RVA: 0x00027FD5 File Offset: 0x000261D5
			public void SetMapCursorBox(Configuration.GameOptions._MapCursorBox enum42_1)
			{
				this.mapCursorBox = enum42_1;
			}

			// Token: 0x0600586C RID: 22636 RVA: 0x00027FDE File Offset: 0x000261DE
			public bool IsHighFidelityMode()
			{
				return this.bHighFidelityMode;
			}

			// Token: 0x0600586D RID: 22637 RVA: 0x00027FE6 File Offset: 0x000261E6
			public void SetHighFidelityMode(bool bool_20)
			{
				this.bHighFidelityMode = bool_20;
			}

			// Token: 0x0600586E RID: 22638 RVA: 0x00027FEF File Offset: 0x000261EF
			public bool NoPulseMapUpdate()
			{
				return this.bNoPulseMapUpdate;
			}

			// Token: 0x0600586F RID: 22639 RVA: 0x00027FF7 File Offset: 0x000261F7
			public void SetNoPulseMapUpdate(bool bool_20)
			{
				this.bNoPulseMapUpdate = bool_20;
			}

			// Token: 0x06005870 RID: 22640 RVA: 0x00028000 File Offset: 0x00026200
			public bool OnlyShowAvailableLoadouts()
			{
				return this.bOnlyShowAvailableLoadouts;
			}

			// Token: 0x06005871 RID: 22641 RVA: 0x00028008 File Offset: 0x00026208
			public void SetOnlyShowAvailableLoadouts(bool bool_20)
			{
				this.bOnlyShowAvailableLoadouts = bool_20;
			}

			// Token: 0x06005872 RID: 22642 RVA: 0x0026D604 File Offset: 0x0026B804
			public Configuration.GameOptions._ShowGhostedGroupMembers ShowGhostedGroupMembers()
			{
				return this.showGhostedGroupMembers;
			}

			// Token: 0x06005873 RID: 22643 RVA: 0x00028011 File Offset: 0x00026211
			public void method_33(Configuration.GameOptions._ShowGhostedGroupMembers enum44_1)
			{
				this.showGhostedGroupMembers = enum44_1;
			}

			// Token: 0x06005874 RID: 22644 RVA: 0x0026D61C File Offset: 0x0026B81C
			public Configuration.GameOptions._ShowMissionArea ShowMissionArea()
			{
				return this.showMissionArea;
			}

			// Token: 0x06005875 RID: 22645 RVA: 0x0002801A File Offset: 0x0002621A
			public void method_35(Configuration.GameOptions._ShowMissionArea enum48_1)
			{
				this.showMissionArea = enum48_1;
			}

			// Token: 0x06005876 RID: 22646 RVA: 0x0026D634 File Offset: 0x0026B834
			public Configuration.GameOptions.Enum45 GetShowPlottedPaths()
			{
				return this.enum45_0;
			}

			// Token: 0x06005877 RID: 22647 RVA: 0x00028023 File Offset: 0x00026223
			public void SetShowPlottedPaths(Configuration.GameOptions.Enum45 enum45_1)
			{
				this.enum45_0 = enum45_1;
			}

			// Token: 0x06005878 RID: 22648 RVA: 0x0026D64C File Offset: 0x0026B84C
			public Configuration.GameOptions._ShowFlightPlans_Airborne GetShowFlightPlans_Airborne()
			{
				return this.showFlightPlans_Airborne;
			}

			// Token: 0x06005879 RID: 22649 RVA: 0x0002802C File Offset: 0x0002622C
			public void SetShowFlightPlans_Airborne(Configuration.GameOptions._ShowFlightPlans_Airborne enum46_1)
			{
				this.showFlightPlans_Airborne = enum46_1;
			}

			// Token: 0x0600587A RID: 22650 RVA: 0x0026D664 File Offset: 0x0026B864
			public Configuration.GameOptions._ShowFlightPlans_Planned GetShowFlightPlans_Planned()
			{
				return this.showFlightPlans_Planned;
			}

			// Token: 0x0600587B RID: 22651 RVA: 0x00028035 File Offset: 0x00026235
			public void SetShowFlightPlans_Planned(Configuration.GameOptions._ShowFlightPlans_Planned enum47_1)
			{
				this.showFlightPlans_Planned = enum47_1;
			}

			// Token: 0x0600587C RID: 22652 RVA: 0x0026D67C File Offset: 0x0026B87C
			public float GetNavigationMaxDistanceNMSetting()
			{
				return this.float_0;
			}

			// Token: 0x0600587D RID: 22653 RVA: 0x0002803E File Offset: 0x0002623E
			public void SetNavigationMaxDistanceNMSetting(float float_2)
			{
				this.float_0 = float_2;
			}

			// Token: 0x0600587E RID: 22654 RVA: 0x0026D694 File Offset: 0x0026B894
			public float GetNavigationThresholdDistanceDegSetting()
			{
				return this.float_1;
			}

			// Token: 0x0600587F RID: 22655 RVA: 0x00028047 File Offset: 0x00026247
			public void SetNavigationThresholdDistanceDegSetting(float float_2)
			{
				this.float_1 = float_2;
			}

			// Token: 0x06005880 RID: 22656 RVA: 0x00028050 File Offset: 0x00026250
			public bool IsShowUnitStatusImage()
			{
				return this.bool_11;
			}

			// Token: 0x06005881 RID: 22657 RVA: 0x00028058 File Offset: 0x00026258
			public void SetIsShowUnitStatusImage(bool bool_20)
			{
				this.bool_11 = bool_20;
			}

			// Token: 0x06005882 RID: 22658 RVA: 0x00028061 File Offset: 0x00026261
			public bool IsSalvoTimeout()
			{
				return this.bool_12;
			}

			// Token: 0x06005883 RID: 22659 RVA: 0x00028069 File Offset: 0x00026269
			public void SetSalvoTimeout(bool bool_20)
			{
				this.bool_12 = bool_20;
			}

			// Token: 0x06005884 RID: 22660 RVA: 0x00028072 File Offset: 0x00026272
			public bool IsShowAutomaticFireInfo()
			{
				return this.bool_13;
			}

			// Token: 0x06005885 RID: 22661 RVA: 0x0002807A File Offset: 0x0002627A
			public void SetShowAutomaticFireInfo(bool bool_20)
			{
				this.bool_13 = bool_20;
			}

			// Token: 0x06005886 RID: 22662 RVA: 0x00028083 File Offset: 0x00026283
			public bool IsShowGameSpeedButton()
			{
				return this.bool_14;
			}

			// Token: 0x06005887 RID: 22663 RVA: 0x0002808B File Offset: 0x0002628B
			public void SetShowGameSpeedButton(bool bool_20)
			{
				this.bool_14 = bool_20;
			}

			// Token: 0x06005888 RID: 22664 RVA: 0x00028094 File Offset: 0x00026294
			public bool LogDebugInfoToFile()
			{
				return this.bool_15;
			}

			// Token: 0x06005889 RID: 22665 RVA: 0x0002809C File Offset: 0x0002629C
			public void SetLogDebugInfoToFile(bool bool_20)
			{
				this.bool_15 = bool_20;
			}

			// Token: 0x0600588A RID: 22666 RVA: 0x000280A5 File Offset: 0x000262A5
			public bool UseMemoryProtection()
			{
				return this.bool_16;
			}

			// Token: 0x0600588B RID: 22667 RVA: 0x000280AD File Offset: 0x000262AD
			public void SetMemoryProtection(bool bool_20)
			{
				this.bool_16 = bool_20;
			}

			// Token: 0x0600588C RID: 22668 RVA: 0x000280B6 File Offset: 0x000262B6
			public bool GetPlacenameVisibility()
			{
				return this.bool_17;
			}

			// Token: 0x0600588D RID: 22669 RVA: 0x000280BE File Offset: 0x000262BE
			public void SetPlacenameVisibility(bool bool_20)
			{
				this.bool_17 = bool_20;
			}

			// Token: 0x0600588E RID: 22670 RVA: 0x000280C7 File Offset: 0x000262C7
			public bool IsMessageLogCanvas()
			{
				return this.bool_18;
			}

			// Token: 0x0600588F RID: 22671 RVA: 0x000280CF File Offset: 0x000262CF
			public void SetMessageLogCanvas(bool bool_20)
			{
				this.bool_18 = bool_20;
			}

			// Token: 0x06005890 RID: 22672 RVA: 0x000280D8 File Offset: 0x000262D8
			public bool IsAllowPowerPlanSwitch()
			{
				return this.bool_19;
			}

			// Token: 0x06005891 RID: 22673 RVA: 0x000280E0 File Offset: 0x000262E0
			public void SetAllowPowerPlanSwitch(bool bool_20)
			{
				this.bool_19 = bool_20;
			}

			// Token: 0x06005892 RID: 22674 RVA: 0x0026D6AC File Offset: 0x0026B8AC
			public GameOptions()
			{
				this.MessageTypeShowOptionsDictionary = new Dictionary<LoggedMessage.MessageType, LoggedMessage.MessageShowOptions>();
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.AirOps, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.CommsIsolatedMessage, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.ContactChange, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.DockingOps, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.NewContact, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.NewAirContact, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.NewSurfaceContact, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.NewUnderwaterContact, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.NewGroundContact, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.NewMineContact, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.PointDefence, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.EventEngine, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.SpecialMessage, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.UI, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.UnitAI, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.UnitDamage, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.UnitLost, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.WeaponDamage, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.WeaponEndgame, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.WeaponLogic, new LoggedMessage.MessageShowOptions(false, false));
				this.MessageTypeShowOptionsDictionary.Add(LoggedMessage.MessageType.UnguidedWeaponModifiers, new LoggedMessage.MessageShowOptions(false, false));
			}

			// Token: 0x04002B7C RID: 11132
			private bool bUseAutosave;

			// Token: 0x04002B7D RID: 11133
			private bool bRunCoreMultithreaded;

			// Token: 0x04002B7E RID: 11134
			private bool bShowDiagnostics;

			// Token: 0x04002B7F RID: 11135
			private bool bMessageLogInWindow;

			// Token: 0x04002B80 RID: 11136
			private bool bGameSoundsON;

			// Token: 0x04002B81 RID: 11137
			private bool bGameMusicON;

			// Token: 0x04002B82 RID: 11138
			private bool useImperialUnit;

			// Token: 0x04002B83 RID: 11139
			private bool bZoomOnCursor;

			// Token: 0x04002B84 RID: 11140
			private Configuration.GameOptions._SonobuoyVisibility sonobuoyVisibility;

			// Token: 0x04002B85 RID: 11141
			private Configuration.GameOptions._DPIScalingMethod dPIScalingMethod;

			// Token: 0x04002B86 RID: 11142
			private Configuration.GameOptions._RefPointVisibility refPointVisibility;

			// Token: 0x04002B87 RID: 11143
			private Configuration.GameOptions._MapSymbolsSet mapSymbolsSet;

			// Token: 0x04002B88 RID: 11144
			private Configuration.GameOptions._MapCursorBox mapCursorBox;

			// Token: 0x04002B89 RID: 11145
			private bool bHighFidelityMode;

			// Token: 0x04002B8A RID: 11146
			private bool bNoPulseMapUpdate;

			// Token: 0x04002B8B RID: 11147
			private bool bOnlyShowAvailableLoadouts;

			// Token: 0x04002B8C RID: 11148
			private Configuration.GameOptions._ShowGhostedGroupMembers showGhostedGroupMembers;

			// Token: 0x04002B8D RID: 11149
			private Configuration.GameOptions.Enum45 enum45_0;

			// Token: 0x04002B8E RID: 11150
			private Configuration.GameOptions._ShowFlightPlans_Airborne showFlightPlans_Airborne;

			// Token: 0x04002B8F RID: 11151
			private Configuration.GameOptions._ShowFlightPlans_Planned showFlightPlans_Planned;

			// Token: 0x04002B90 RID: 11152
			private float float_0;

			// Token: 0x04002B91 RID: 11153
			private float float_1;

			// Token: 0x04002B92 RID: 11154
			private Configuration.GameOptions._ShowMissionArea showMissionArea;

			// Token: 0x04002B93 RID: 11155
			private bool bool_11;

			// Token: 0x04002B94 RID: 11156
			private bool bool_12;

			// Token: 0x04002B95 RID: 11157
			private bool bool_13;

			// Token: 0x04002B96 RID: 11158
			private bool bool_14;

			// Token: 0x04002B97 RID: 11159
			private bool bool_15;

			// Token: 0x04002B98 RID: 11160
			private bool bool_16;

			// Token: 0x04002B99 RID: 11161
			private bool bool_17;

			// Token: 0x04002B9A RID: 11162
			private bool bool_18;

			// Token: 0x04002B9B RID: 11163
			private bool bool_19;

			// Token: 0x04002B9C RID: 11164
			public Dictionary<LoggedMessage.MessageType, LoggedMessage.MessageShowOptions> MessageTypeShowOptionsDictionary;

			// Token: 0x04002B9D RID: 11165
			private bool bPlacenameShowInChinese;

			// Token: 0x02000ACC RID: 2764
			public enum _SonobuoyVisibility : byte
			{
				// Token: 0x04002B9F RID: 11167
				const_0,
				// Token: 0x04002BA0 RID: 11168
				const_1,
				// Token: 0x04002BA1 RID: 11169
				const_2
			}

			// Token: 0x02000ACD RID: 2765
			public enum _DPIScalingMethod : byte
			{
				// Token: 0x04002BA3 RID: 11171
				const_0,
				// Token: 0x04002BA4 RID: 11172
				const_1
			}

			// Token: 0x02000ACE RID: 2766
			public enum _RefPointVisibility : byte
			{
				// Token: 0x04002BA6 RID: 11174
				const_0,
				// Token: 0x04002BA7 RID: 11175
				const_1,
				// Token: 0x04002BA8 RID: 11176
				const_2
			}

			// Token: 0x02000ACF RID: 2767
			public enum _MapCursorBox : byte
			{
				// Token: 0x04002BAA RID: 11178
				const_0,
				// Token: 0x04002BAB RID: 11179
				const_1,
				// Token: 0x04002BAC RID: 11180
				const_2
			}

			// Token: 0x02000AD0 RID: 2768
			public enum _MapSymbolsSet : byte
			{
				// Token: 0x04002BAE RID: 11182
				NTDS,
				// Token: 0x04002BAF RID: 11183
				Stylized,
				// Token: 0x04002BB0 RID: 11184
				Directional,
				// Token: 0x04002BB1 RID: 11185
				ChineseMilitary
			}

			// Token: 0x02000AD1 RID: 2769
			public enum _ShowGhostedGroupMembers : byte
			{
				// Token: 0x04002BB3 RID: 11187
				ALL,
				// Token: 0x04002BB4 RID: 11188
				SEL,
				// Token: 0x04002BB5 RID: 11189
				NONE
			}

			// Token: 0x02000AD2 RID: 2770
			public enum Enum45 : byte
			{
				// Token: 0x04002BB7 RID: 11191
				const_0,
				// Token: 0x04002BB8 RID: 11192
				const_1,
				// Token: 0x04002BB9 RID: 11193
				const_2
			}

			// Token: 0x02000AD3 RID: 2771
			public enum _ShowFlightPlans_Airborne : byte
			{
				// Token: 0x04002BBB RID: 11195
				const_0,
				// Token: 0x04002BBC RID: 11196
				const_1,
				// Token: 0x04002BBD RID: 11197
				const_2
			}

			// Token: 0x02000AD4 RID: 2772
			public enum _ShowFlightPlans_Planned : byte
			{
				// Token: 0x04002BBF RID: 11199
				const_0,
				// Token: 0x04002BC0 RID: 11200
				const_1,
				// Token: 0x04002BC1 RID: 11201
				const_2,
				// Token: 0x04002BC2 RID: 11202
				const_3,
				// Token: 0x04002BC3 RID: 11203
				const_4
			}

			// Token: 0x02000AD5 RID: 2773
			public enum _ShowMissionArea : short
			{
				// Token: 0x04002BC5 RID: 11205
				const_0,
				// Token: 0x04002BC6 RID: 11206
				const_1,
				// Token: 0x04002BC7 RID: 11207
				const_2
			}
		}
	}
}

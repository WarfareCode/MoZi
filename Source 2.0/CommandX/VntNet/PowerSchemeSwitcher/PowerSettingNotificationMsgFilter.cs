using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x02000528 RID: 1320
	public sealed class PowerSettingNotificationMsgFilter : IDisposable
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060021FA RID: 8698 RVA: 0x000DCE4C File Offset: 0x000DB04C
		// (remove) Token: 0x060021FB RID: 8699 RVA: 0x000DCE88 File Offset: 0x000DB088
		[CompilerGenerated]
		[method: CompilerGenerated]
		internal event Action<PowerSettingNotificationMsgFilter.PowerSavingLevelEnum> PowerSchemeChanged;

		// Token: 0x060021FC RID: 8700 RVA: 0x000141D6 File Offset: 0x000123D6
		public PowerSettingNotificationMsgFilter(Form form)
		{
			this._pwrNotHelper = new PowerSettingNotificationMsgFilter.PowerSettingNotificationHelper(form.Handle);
			this._pwrNotHelper.OnPowerSchemeChanged += new Action<Guid>(this.pwrNotHelper_OnPowerSchemeChanged);
			this._init = false;
			this.Init();
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x000DCEC4 File Offset: 0x000DB0C4
		private void pwrNotHelper_OnPowerSchemeChanged(Guid newPersonality)
		{
			PowerSettingNotificationMsgFilter.PowerSavingLevelEnum level = PowerSettingNotificationMsgFilter.PowerSavingLevelEnum.Unkown;
			if (this.PowerSchemeChanged != null)
			{
				if (newPersonality == PowerSettingNotificationMsgFilter.PowerSettingNotificationHelper.GUID_MAX_POWER_SAVINGS)
				{
					level = PowerSettingNotificationMsgFilter.PowerSavingLevelEnum.Max;
				}
				else if (newPersonality == PowerSettingNotificationMsgFilter.PowerSettingNotificationHelper.GUID_MIN_POWER_SAVINGS)
				{
					level = PowerSettingNotificationMsgFilter.PowerSavingLevelEnum.Min;
				}
				else if (newPersonality == PowerSettingNotificationMsgFilter.PowerSettingNotificationHelper.GUID_TYPICAL_POWER_SAVINGS)
				{
					level = PowerSettingNotificationMsgFilter.PowerSavingLevelEnum.Typical;
				}
				this.OnPowerSchemeChanged(level);
			}
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00014213 File Offset: 0x00012413
		private void OnPowerSchemeChanged(PowerSettingNotificationMsgFilter.PowerSavingLevelEnum level)
		{
			if (this.PowerSchemeChanged != null)
			{
				this.PowerSchemeChanged(level);
			}
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x0001422C File Offset: 0x0001242C
		public bool PreFilterMessage(ref Message m)
		{
			return this._init && this._pwrNotHelper.PreFilterMessage(ref m);
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00014245 File Offset: 0x00012445
		private void Init()
		{
			if (!this._init)
			{
				this._pwrNotHelper.RegisterForPowerNotifications();
				this._init = true;
			}
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00014261 File Offset: 0x00012461
		public void Destroy()
		{
			if (this._init)
			{
				this._pwrNotHelper.UnregisterForPowerNotifications();
				this._init = false;
			}
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00014280 File Offset: 0x00012480
		void IDisposable.Dispose()
		{
			this.Destroy();
		}

		// Token: 0x04001066 RID: 4198
		private PowerSettingNotificationMsgFilter.PowerSettingNotificationHelper _pwrNotHelper;

		// Token: 0x04001067 RID: 4199
		private bool _init;

		// Token: 0x02000529 RID: 1321
		public enum PowerSavingLevelEnum
		{
			// Token: 0x0400106A RID: 4202
			Max,
			// Token: 0x0400106B RID: 4203
			Min,
			// Token: 0x0400106C RID: 4204
			Typical,
			// Token: 0x0400106D RID: 4205
			Unkown
		}

		// Token: 0x0200052A RID: 1322
		private sealed class PowerSettingNotificationHelper
		{
			// Token: 0x1400000A RID: 10
			// (add) Token: 0x06002203 RID: 8707 RVA: 0x000DCF20 File Offset: 0x000DB120
			// (remove) Token: 0x06002204 RID: 8708 RVA: 0x000DCF5C File Offset: 0x000DB15C
			[CompilerGenerated]
			[method: CompilerGenerated]
			public event Action<Guid> OnPowerSchemeChanged;

			// Token: 0x06002205 RID: 8709
			[DllImport("User32", CallingConvention = CallingConvention.StdCall)]
			private static extern IntPtr RegisterPowerSettingNotification(IntPtr hRecipient, ref Guid PowerSettingGuid, int Flags);

			// Token: 0x06002206 RID: 8710
			[DllImport("User32", CallingConvention = CallingConvention.StdCall)]
			private static extern bool UnregisterPowerSettingNotification(IntPtr handle);

			// Token: 0x06002207 RID: 8711
			[DllImport("Kernel32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
			public static extern PowerSettingNotificationMsgFilter.PowerSettingNotificationHelper.EXECUTION_STATE SetThreadExecutionState(PowerSettingNotificationMsgFilter.PowerSettingNotificationHelper.EXECUTION_STATE state);

			// Token: 0x06002208 RID: 8712 RVA: 0x000DCF98 File Offset: 0x000DB198
			public PowerSettingNotificationHelper(IntPtr FormHandle)
			{
				this.handle = FormHandle;
			}

			// Token: 0x06002209 RID: 8713 RVA: 0x00014288 File Offset: 0x00012488
			public void RegisterForPowerNotifications()
			{
				this.hPowerScheme = PowerSettingNotificationMsgFilter.PowerSettingNotificationHelper.RegisterPowerSettingNotification(this.handle, ref this.GUID_POWERSCHEME_PERSONALITY, 0);
			}

			// Token: 0x0600220A RID: 8714 RVA: 0x000142A2 File Offset: 0x000124A2
			public void UnregisterForPowerNotifications()
			{
				PowerSettingNotificationMsgFilter.PowerSettingNotificationHelper.UnregisterPowerSettingNotification(this.hPowerScheme);
			}

			// Token: 0x0600220B RID: 8715 RVA: 0x000DD070 File Offset: 0x000DB270
			public bool PreFilterMessage(ref Message m)
			{
				int msg = m.Msg;
				bool result;
				if (msg == 536)
				{
					this.OnPowerBroadcast(ref m);
					result = true;
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x0600220C RID: 8716 RVA: 0x000142B0 File Offset: 0x000124B0
			private void OnPowerBroadcast(ref Message m)
			{
				if ((int)m.WParam == 32787)
				{
					this.PowerSettingChange(ref m);
				}
			}

			// Token: 0x0600220D RID: 8717 RVA: 0x000DD0A0 File Offset: 0x000DB2A0
			private void PowerSettingChange(ref Message m)
			{
				PowerSettingNotificationMsgFilter.PowerSettingNotificationHelper.POWERBROADCAST_SETTING pOWERBROADCAST_SETTING = (PowerSettingNotificationMsgFilter.PowerSettingNotificationHelper.POWERBROADCAST_SETTING)Marshal.PtrToStructure(m.LParam, typeof(PowerSettingNotificationMsgFilter.PowerSettingNotificationHelper.POWERBROADCAST_SETTING));
				IntPtr pData = (IntPtr)((int)m.LParam + Marshal.SizeOf(pOWERBROADCAST_SETTING));
				if (pOWERBROADCAST_SETTING.PowerSetting == this.GUID_POWERSCHEME_PERSONALITY)
				{
					this.UpdateSelectedPowerPlan(pOWERBROADCAST_SETTING, pData);
				}
			}

			// Token: 0x0600220E RID: 8718 RVA: 0x000DD104 File Offset: 0x000DB304
			private void UpdateSelectedPowerPlan(PowerSettingNotificationMsgFilter.PowerSettingNotificationHelper.POWERBROADCAST_SETTING ps, IntPtr pData)
			{
				if (ps.DataLength == Marshal.SizeOf(typeof(Guid)))
				{
					Guid obj = (Guid)Marshal.PtrToStructure(pData, typeof(Guid));
					if (this.OnPowerSchemeChanged != null)
					{
						this.OnPowerSchemeChanged(obj);
					}
				}
			}

			// Token: 0x0400106E RID: 4206
			private const int WM_POWERBROADCAST = 536;

			// Token: 0x0400106F RID: 4207
			private const int PBT_APMQUERYSUSPEND = 0;

			// Token: 0x04001070 RID: 4208
			private const int PBT_APMQUERYSTANDBY = 1;

			// Token: 0x04001071 RID: 4209
			private const int PBT_APMQUERYSUSPENDFAILED = 2;

			// Token: 0x04001072 RID: 4210
			private const int PBT_APMQUERYSTANDBYFAILED = 3;

			// Token: 0x04001073 RID: 4211
			private const int PBT_APMSUSPEND = 4;

			// Token: 0x04001074 RID: 4212
			private const int PBT_APMSTANDBY = 5;

			// Token: 0x04001075 RID: 4213
			private const int PBT_APMRESUMECRITICAL = 6;

			// Token: 0x04001076 RID: 4214
			private const int PBT_APMRESUMESUSPEND = 7;

			// Token: 0x04001077 RID: 4215
			private const int PBT_APMRESUMESTANDBY = 8;

			// Token: 0x04001078 RID: 4216
			private const int PBT_APMBATTERYLOW = 9;

			// Token: 0x04001079 RID: 4217
			private const int PBT_APMPOWERSTATUSCHANGE = 10;

			// Token: 0x0400107A RID: 4218
			private const int PBT_APMOEMEVENT = 11;

			// Token: 0x0400107B RID: 4219
			private const int PBT_APMRESUMEAUTOMATIC = 18;

			// Token: 0x0400107C RID: 4220
			private const int PBT_POWERSETTINGCHANGE = 32787;

			// Token: 0x0400107D RID: 4221
			private const int DEVICE_NOTIFY_WINDOW_HANDLE = 0;

			// Token: 0x0400107E RID: 4222
			private const int DEVICE_NOTIFY_SERVICE_HANDLE = 1;

			// Token: 0x0400107F RID: 4223
			internal static Guid GUID_MAX_POWER_SAVINGS = new Guid(2709787400u, 13633, 20395, 188, 129, 247, 21, 86, 242, 11, 74);

			// Token: 0x04001080 RID: 4224
			internal static Guid GUID_MIN_POWER_SAVINGS = new Guid(2355003354u, 59583, 19094, 154, 133, 166, 226, 58, 140, 99, 92);

			// Token: 0x04001081 RID: 4225
			internal static Guid GUID_TYPICAL_POWER_SAVINGS = new Guid(941310498u, 63124, 16880, 150, 133, 255, 91, 178, 96, 223, 46);

			// Token: 0x04001082 RID: 4226
			private IntPtr hPowerScheme;

			// Token: 0x04001083 RID: 4227
			private IntPtr handle;

			// Token: 0x04001084 RID: 4228
			private Guid GUID_BATTERY_PERCENTAGE_REMAINING = new Guid("A7AD8041-B45A-4CAE-87A3-EECBB468A9E1");

			// Token: 0x04001085 RID: 4229
			private Guid GUID_MONITOR_POWER_ON = new Guid(41095189, 17680, 17702, 153, 230, 229, 161, 126, 189, 26, 234);

			// Token: 0x04001086 RID: 4230
			private Guid GUID_ACDC_POWER_SOURCE = new Guid(1564383833u, 59861, 19200, 166, 189, 255, 52, 255, 81, 101, 72);

			// Token: 0x04001087 RID: 4231
			private Guid GUID_POWERSCHEME_PERSONALITY = new Guid(610108737, 14659, 17442, 176, 37, 19, 167, 132, 246, 121, 183);

			// Token: 0x0200052B RID: 1323
			[StructLayout(LayoutKind.Sequential, Pack = 4)]
			internal struct POWERBROADCAST_SETTING
			{
				// Token: 0x04001089 RID: 4233
				public Guid PowerSetting;

				// Token: 0x0400108A RID: 4234
				public int DataLength;
			}

			// Token: 0x0200052C RID: 1324
			[Flags]
			public enum EXECUTION_STATE : uint
			{
				// Token: 0x0400108C RID: 4236
				ES_SYSTEM_REQUIRED = 1u,
				// Token: 0x0400108D RID: 4237
				ES_DISPLAY_REQUIRED = 2u,
				// Token: 0x0400108E RID: 4238
				ES_CONTINUOUS = 2147483648u
			}
		}
	}
}

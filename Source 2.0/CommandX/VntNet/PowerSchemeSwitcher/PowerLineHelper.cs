using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x02000504 RID: 1284
	public sealed class PowerLineHelper
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600217F RID: 8575 RVA: 0x000DB854 File Offset: 0x000D9A54
		// (remove) Token: 0x06002180 RID: 8576 RVA: 0x000DB890 File Offset: 0x000D9A90
		[CompilerGenerated]
		[method: CompilerGenerated]
		public event Action<PowerLineHelper.PowerLineStatus> PowerLineStatusChanged;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06002181 RID: 8577 RVA: 0x000DB8CC File Offset: 0x000D9ACC
		// (remove) Token: 0x06002182 RID: 8578 RVA: 0x000DB908 File Offset: 0x000D9B08
		[CompilerGenerated]
		[method: CompilerGenerated]
		public event Action<int> BatteryLifePercentChanged;

		// Token: 0x06002183 RID: 8579 RVA: 0x000DB944 File Offset: 0x000D9B44
		public PowerLineHelper()
		{
			this._checkBatteryEvent = new ManualResetEvent(true);
			this._exit = false;
			this._prevBatteryLifePercent = 0;
			SystemEvents.PowerModeChanged += new PowerModeChangedEventHandler(this.SystemEvents_PowerModeChanged);
			Application.ApplicationExit += new EventHandler(this.Application_ApplicationExit);
			WaitCallback callBack = delegate(object param0)
			{
				this.MonitorBatteryStatusThreadFn();
			};
			ThreadPool.QueueUserWorkItem(callBack);
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x00013FF7 File Offset: 0x000121F7
		private void Application_ApplicationExit(object sender, EventArgs e)
		{
			this._exit = true;
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x000DB9AC File Offset: 0x000D9BAC
		private void MonitorBatteryStatusThreadFn()
		{
			while (!this._exit)
			{
				this._checkBatteryEvent.WaitOne(30000);
				this._checkBatteryEvent.Reset();
				try
				{
					this.MonitorBatteryStatusInternal();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00014000 File Offset: 0x00012200
		internal void ForceBatteryStatuCheck()
		{
			this._checkBatteryEvent.Set();
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x000DBA00 File Offset: 0x000D9C00
		private void MonitorBatteryStatusInternal()
		{
			if (PowerLineHelper.GetCurrentSystemPowerStatus() == PowerLineHelper.PowerLineStatus.Battery)
			{
				int currentBatteryLifePercent = PowerLineHelper.PowerLineNativeHelper.GetCurrentBatteryLifePercent();
				if (currentBatteryLifePercent != -1 && currentBatteryLifePercent != this._prevBatteryLifePercent)
				{
					this.OnBatteryLifePercentChanged(currentBatteryLifePercent);
					this._prevBatteryLifePercent = currentBatteryLifePercent;
				}
			}
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x0001400E File Offset: 0x0001220E
		private void OnBatteryLifePercentChanged(int batteryLifePercent)
		{
			if (this.BatteryLifePercentChanged != null)
			{
				this.BatteryLifePercentChanged(batteryLifePercent);
			}
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00014027 File Offset: 0x00012227
		private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
		{
			if (this.PowerLineStatusChanged != null)
			{
				this.PowerLineStatusChanged((PowerLineHelper.PowerLineStatus)e.Mode);
			}
			if (PowerLineHelper.PowerLineNativeHelper.GetCurrentSystemPowerLineStatus() == PowerLineHelper.PowerLineStatus.Battery)
			{
				this.ForceBatteryStatuCheck();
			}
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x000DBA40 File Offset: 0x000D9C40
		internal static PowerLineHelper.PowerLineStatus GetCurrentSystemPowerStatus()
		{
			return PowerLineHelper.PowerLineNativeHelper.GetCurrentSystemPowerLineStatus();
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x000DBA54 File Offset: 0x000D9C54
		internal static int GetCurrentBatteryLifePercent()
		{
			return PowerLineHelper.PowerLineNativeHelper.GetCurrentBatteryLifePercent();
		}

		// Token: 0x0400102E RID: 4142
		private const int LoopInterval = 30000;

		// Token: 0x0400102F RID: 4143
		private int _prevBatteryLifePercent;

		// Token: 0x04001030 RID: 4144
		private bool _exit;

		// Token: 0x04001031 RID: 4145
		private ManualResetEvent _checkBatteryEvent;

		// Token: 0x02000505 RID: 1285
		public enum PowerLineStatus : byte
		{
			// Token: 0x04001035 RID: 4149
			Battery,
			// Token: 0x04001036 RID: 4150
			AC,
			// Token: 0x04001037 RID: 4151
			Unknown = 255
		}

		// Token: 0x02000506 RID: 1286
		private sealed class PowerLineNativeHelper
		{
			// Token: 0x0600218D RID: 8589
			[DllImport("kernel32")]
			private static extern bool GetSystemPowerStatus(out PowerLineHelper.PowerLineNativeHelper.SystemPowerStatus sps);

			// Token: 0x0600218E RID: 8590 RVA: 0x000DBA68 File Offset: 0x000D9C68
			public static PowerLineHelper.PowerLineStatus GetCurrentSystemPowerLineStatus()
			{
				PowerLineHelper.PowerLineNativeHelper.SystemPowerStatus systemPowerStatus;
				PowerLineHelper.PowerLineStatus result;
				if (PowerLineHelper.PowerLineNativeHelper.GetSystemPowerStatus(out systemPowerStatus))
				{
					result = systemPowerStatus.PowerLineStatus;
				}
				else
				{
					result = PowerLineHelper.PowerLineStatus.Unknown;
				}
				return result;
			}

			// Token: 0x0600218F RID: 8591 RVA: 0x000DBA94 File Offset: 0x000D9C94
			public static int GetCurrentBatteryLifePercent()
			{
				PowerLineHelper.PowerLineNativeHelper.SystemPowerStatus systemPowerStatus;
				int result;
				if (PowerLineHelper.PowerLineNativeHelper.GetSystemPowerStatus(out systemPowerStatus))
				{
					result = (int)systemPowerStatus.BatteryLifePercent;
				}
				else
				{
					result = -1;
				}
				return result;
			}

			// Token: 0x02000507 RID: 1287
			[Flags]
			private enum BatteryFlag : byte
			{
				// Token: 0x04001039 RID: 4153
				High = 1,
				// Token: 0x0400103A RID: 4154
				Low = 2,
				// Token: 0x0400103B RID: 4155
				Critical = 4,
				// Token: 0x0400103C RID: 4156
				Charging = 8,
				// Token: 0x0400103D RID: 4157
				NoSystemBattery = 128,
				// Token: 0x0400103E RID: 4158
				Unknown = 255
			}

			// Token: 0x02000508 RID: 1288
			private struct SystemPowerStatus
			{
				// Token: 0x0400103F RID: 4159
				internal PowerLineHelper.PowerLineStatus PowerLineStatus;

				// Token: 0x04001040 RID: 4160
				internal PowerLineHelper.PowerLineNativeHelper.BatteryFlag BatteryFlag;

				// Token: 0x04001041 RID: 4161
				internal byte BatteryLifePercent;

				// Token: 0x04001042 RID: 4162
				internal byte Reserved1;

				// Token: 0x04001043 RID: 4163
				internal uint BatteryLifeTime;

				// Token: 0x04001044 RID: 4164
				internal uint BatteryFullLifeTime;
			}
		}
	}
}

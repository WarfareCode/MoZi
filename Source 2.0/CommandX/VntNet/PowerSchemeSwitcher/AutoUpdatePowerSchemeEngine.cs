using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using VntNet.PowerSchemeSwitcher.Properties;

namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x020004C1 RID: 1217
	public sealed class AutoUpdatePowerSchemeEngine
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06001FB1 RID: 8113 RVA: 0x000D0D8C File Offset: 0x000CEF8C
		// (remove) Token: 0x06001FB2 RID: 8114 RVA: 0x000D0DC8 File Offset: 0x000CEFC8
		[CompilerGenerated]
		[method: CompilerGenerated]
		internal event Action<bool> SettingValidated;

		// Token: 0x06001FB3 RID: 8115 RVA: 0x000D0E04 File Offset: 0x000CF004
		public AutoUpdatePowerSchemeEngine()
		{
			this._exit = 0;
			this._settingUpdatedEvent = new ManualResetEvent(false);
			WaitCallback callBack = delegate(object param0)
			{
				this.MonitorPowerStatusThreadFn();
			};
			ThreadPool.QueueUserWorkItem(callBack);
			Application.ApplicationExit += new EventHandler(this.Application_ApplicationExit);
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x00013118 File Offset: 0x00011318
		private void Application_ApplicationExit(object sender, EventArgs e)
		{
			Interlocked.Increment(ref this._exit);
			this.Update();
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x0001312C File Offset: 0x0001132C
		internal void Update()
		{
			this._settingUpdatedEvent.Set();
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x0001313A File Offset: 0x0001133A
		private bool IsValidSchema(Guid schemeGuid)
		{
			return this._planList.ContainsKey(schemeGuid);
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x00013148 File Offset: 0x00011348
		private void OnSettingValidated(bool result)
		{
			if (this.SettingValidated != null)
			{
				this.SettingValidated(result);
			}
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x000D0E54 File Offset: 0x000CF054
		private void MonitorPowerStatusThreadFn()
		{
			while (this._exit == 0)
			{
				this._settingUpdatedEvent.WaitOne();
				this._settingUpdatedEvent.Reset();
				if (this._exit > 0)
				{
					break;
				}
				try
				{
					this.MonitorPowerStatusThreadFnInternal();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x000D0EB0 File Offset: 0x000CF0B0
		private void MonitorPowerStatusThreadFnInternal()
		{
			this._planList = PowerSchemeHelper.GetAllPowerSchemas();
			if (this.CheckSettings() && Settings.Default.EnableAutoSwitching)
			{
				PowerLineHelper.PowerLineStatus currentSystemPowerStatus = PowerLineHelper.GetCurrentSystemPowerStatus();
				int currentBatteryLifePercent = PowerLineHelper.GetCurrentBatteryLifePercent();
				if (currentSystemPowerStatus != PowerLineHelper.PowerLineStatus.Battery)
				{
					if (currentSystemPowerStatus == PowerLineHelper.PowerLineStatus.AC)
					{
						PowerSchemeHelper.SetPowerScheme(this._planList[Settings.Default.OnAcScheme].SchemeGuid);
					}
				}
				else if (currentBatteryLifePercent <= Settings.Default.LowBatteryPercentage)
				{
					PowerSchemeHelper.SetPowerScheme(this._planList[Settings.Default.OnLowBatteryScheme].SchemeGuid);
				}
				else
				{
					PowerSchemeHelper.SetPowerScheme(this._planList[Settings.Default.OnFullBatteryScheme].SchemeGuid);
				}
			}
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x000D0F70 File Offset: 0x000CF170
		internal bool CheckSettings()
		{
			bool result = true;
			if (!this.IsValidSchema(Settings.Default.OnAcScheme) || !this.IsValidSchema(Settings.Default.OnFullBatteryScheme) || !this.IsValidSchema(Settings.Default.OnLowBatteryScheme))
			{
				result = false;
			}
			this.OnSettingValidated(result);
			return result;
		}

		// Token: 0x04000F07 RID: 3847
		private const int CHECKTIMEOUT = 30000;

		// Token: 0x04000F08 RID: 3848
		private Dictionary<Guid, PowerPlanInfo> _planList;

		// Token: 0x04000F09 RID: 3849
		private ManualResetEvent _settingUpdatedEvent;

		// Token: 0x04000F0A RID: 3850
		private int _exit;
	}
}
